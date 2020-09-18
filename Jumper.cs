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
    public partial class Jumper : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jump = false;

        int jumpSpeed = 10; //szybkość skoku
        int force = 8; //wysokość skoku
        int score = 300;

        public Jumper(string login)
        {
            InitializeComponent();
            pokaLogin(login);
        }

        private void pokaLogin(string loginPoka)
        {
            loginTB.Text = loginPoka; //metoda do pobrania loginu do textboxa
        }

        //jeśli przycisk na klawiaturze zostanie wciśnięty
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && !jump)
            {
                jump = true;
            }
        }
        //jeśli przycisk na klawiaturze zostanie odpuszczony
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jump)
            {
                jump = false;
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            scoreLBL.Text = score--.ToString();
            player.Top = player.Top + jumpSpeed; //umieszczenie gracza na mape, spada na platforme
            //mechanizm poruszania się
            if(jump && force < 0)
            {
                jump = false;
            }
            if (goLeft)
            {
                player.Left = player.Left - 5;
            }
            if (goRight)
            {
                player.Left = player.Left + 5;
            }
            if (jump)
            {
                jumpSpeed = -12;
                force = force - 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "platform")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds) && !jump) //jeśli gracz dotknie platformy to stanie na niej
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
                if(x is PictureBox && (string)x.Tag == "coin") 
                {
                    if(player.Bounds.IntersectsWith(x.Bounds) && !jump) //jeśli gracz dotknie bonusu 'pieniążka'
                    {
                        this.Controls.Remove(x);
                        score = score + 130;
                    }
                }
            }
            
            if (player.Location.Y > 580) // jeśli spadnie z planszy
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("Grasz dalej?", "Spadłeś z planszy", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    this.Hide();
                    Jumper j = new Jumper(loginTB.Text);
                    j.Show();
                }
                else
                {
                    this.Hide();
                    UserMain um = new UserMain(loginTB.Text);
                    um.Show();
                    this.Close();
                }
            }
            if (scoreLBL.Text == 0.ToString())
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("Niestety idzie Ci za wolno, nie dostaniesz punktów za tą próbę, nawet tych ujemnych. \n" +
                    "Możesz spróbować jeszcze raz.", "Brakło ci czasu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Jumper j = new Jumper(loginTB.Text);
                    j.Show();
                }
                else
                {
                    this.Hide();
                    UserMain um = new UserMain(loginTB.Text);
                    um.Show();
                    this.Close();
                }
            }
            if (player.Bounds.IntersectsWith(door.Bounds)) //jeśli gracz dojdzie na mete
            {
                timer.Stop();
                MessageBox.Show("Wygrałeś! Zdobyłeś "+scoreLBL.Text+" punktów!", "Gratulacje");

                SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");
                cnn.Open();
                String sql = "update users set score = score + @addScore where login = +'" + loginTB.Text + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("addScore", scoreLBL.Text);
                command.ExecuteNonQuery();
                cnn.Close();

                UserMain um = new UserMain(loginTB.Text);
                um.Show();
                this.Close();
            }
        }
    }
}
