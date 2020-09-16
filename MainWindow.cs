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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            hasloTB.PasswordChar = '*';
        }

        private void rejestracjaBTN_Click(object sender, EventArgs e)
        {
            Rejestracja r = new Rejestracja();
            r.Show();
            this.Visible = false;
        }

        private void zalogujBTN_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string haslo = hasloTB.Text;

            SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");
            cnn.Open();
            String sql = "select count(*) from users where login ='"+login+"' and password ='"+haslo+"'";
            SqlCommand command = new SqlCommand(sql, cnn);

            int sqlIle = (int)command.ExecuteScalar();

            if(sqlIle > 0)
            {
                UserMain um = new UserMain(login);               
                um.Show();
                logowanieInfoLBL.Text = "";
                this.Visible = false;
            }
            else
            {
                logowanieInfoLBL.Text = "Błędne dane logowania";
                logowanieInfoLBL.BackColor = Color.IndianRed;
            }
            cnn.Close();
        }

        private void offBTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
