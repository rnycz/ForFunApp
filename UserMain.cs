using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class UserMain : Form
    {
        public UserMain(string login)
        {
            InitializeComponent();
            Powitanie(login);
            //możliwe godziny dodania dodatkowych punktów
            if(DateTime.Now.Hour == 5 || DateTime.Now.Hour == 10 || DateTime.Now.Hour == 15 || DateTime.Now.Hour == 20)
            {
                dodajPktBTN.Enabled = true;
                dodajPktBTN.Text = "Dodaj 10 punktów";
                dodajPktBTN.BackColor = Color.YellowGreen;
            }
        }

        //wiadomość na powitanie po zalogowaniu
        private void Powitanie(string loginPowitanie)
        {
            SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");
            cnn.Open();
            String sql = "select email, score from users where login='"+loginPowitanie+"'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string emailPowitanie = reader["email"].ToString();
                int punkty = (int)reader["score"];
                powitanieLBL.Text = "Witamy na twoim profilu " + loginPowitanie + "! \n"
                + "Adres e-mail z którym jest powiązane twoje konto: " +emailPowitanie+" \n"
                +"Twoje punkty: "+punkty;
                loginBoxTB.Text = loginPowitanie;
            }
            reader.Close();
            cnn.Close();
        }

        //wyloguj a tak na prawde zmień okno
        private void wylogujBTN_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Visible = false;
        }

        //wyłącz całą apke
        private void offBTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //dodaj bonusowe punkty
        int count = 0;
        private void dodajPktBTN_Click(object sender, EventArgs e)
        {
            count++; //ilość kliknięć przycisku
            int score = 10;
            SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");
            cnn.Open();
            String sql = "update users set score = score + @addScore where login ='"+loginBoxTB.Text+"'";
            SqlCommand command = new SqlCommand(sql, cnn);
            if(DateTime.Now.Hour == 5 || DateTime.Now.Hour == 10 || DateTime.Now.Hour == 15 || DateTime.Now.Hour == 20)
            {
                if (count > 0)
                {
                    dodajPktBTN.Enabled = false;
                    dodajPktBTN.Text = "Raz wystarczy ";
                    dodajPktBTN.BackColor = Color.Yellow;
                    command.Parameters.AddWithValue("addScore", score);
                    command.ExecuteNonQuery();
                    Powitanie(loginBoxTB.Text);
                }
            }
            else
            {
                dodajPktBTN.Enabled = false;
                dodajPktBTN.Text = "Nie ta pora";
                dodajPktBTN.BackColor = Color.Yellow;
            }
            cnn.Close();
        }

        //włącz gre Jumper
        private void jumperBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dojdź na samą górę jak najszybciej, im szybciej tym więcej punktów. \n" +
                "Po drodze możesz zebrać bonus dodający punkty. \n" +
                "Naciśnij OK, aby rozpocząć grę.", "Zasady");
            Jumper j = new Jumper(loginBoxTB.Text);
            j.Show();
            this.Close();
        }

        //włącz gre Dodger
        private void dodgerBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unikaj lecących obiektów i zdobywaj punkty. \n" +
                "Naciśnij OK, aby rozpocząć grę.","Zasady");
            Dodger d = new Dodger(loginBoxTB.Text);
            d.Show();
            this.Close();
        }
    }
}
