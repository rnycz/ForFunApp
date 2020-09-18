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
    public partial class Dodger : Form
    {
        public Dodger(string login)
        {
            InitializeComponent();
            pokaLogin(login);
        }

        bool goUp = false;
        bool goDown = false;
        bool goLeft = false;
        bool goRight = false;
        int boxSpeed = 7; //jak szybko spadają obiekty z góry
        int score = 0;
        Random rand = new Random();

        private void pokaLogin(string loginPoka)
        {
            loginTB.Text = loginPoka; //metoda do pobrania loginu do textboxa
        }

        //jeśli przycisk na klawiaturze zostanie wciśnięty
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
        }

        //jeśli przycisk na klawiaturze zostanie odpuszczony
        private void keisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
        }

        int countBox = 0; //ilość obiektów która spadła z mapy
        private void timer_Tick(object sender, EventArgs e)
        {
            scoreLBL.Text = score.ToString();
            //mechanizm poruszania się
            if (goLeft)
            {
                player.Left = player.Left - 5;
            }
            if (goRight)
            {
                player.Left = player.Left + 5;
            }
            if (goUp)
            {
                player.Top = player.Top - 5;
            }
            if (goDown)
            {
                player.Top = player.Top + 5;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "box1" || (string)x.Tag == "box2" || (string)x.Tag == "box3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) //jeśli gracz wpadnie w spadający obiekt
                    {
                        timer.Stop();
                        MessageBox.Show("Zdobyłeś "+score+" punktów","Gratulacje");
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
                if (x is PictureBox && (string)x.Tag == "box1")
                { //operacje na pierwszym spadającym obiekcie
                    x.Top = x.Top + boxSpeed; //spadanie obiektu
                    if (x.Top - x.Height > 500)
                    {//po spadnęciu ponownie pojawia się u góry w losowym miejscu
                        x.Top = this.ClientSize.Width - rand.Next(500, 600);
                        x.Left = this.ClientSize.Width - rand.Next(20, 480);
                        countBox++; 
                        score++;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "box2" && countBox > 2)
                {//pojawienie się kolejnego obiektu
                    pictureBox2.Visible = true;
                    x.Top = x.Top + boxSpeed;
                    if (x.Top - x.Height > 500)
                    {
                        x.Top = this.ClientSize.Width - rand.Next(500, 600);
                        x.Left = this.ClientSize.Width - rand.Next(20, 480);
                        score++;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "box3" && countBox > 10)
                {//pojawienie się kolejnego obiektu
                    pictureBox3.Visible = true;
                    x.Top = x.Top + boxSpeed;
                    if (x.Top - x.Height > 500)
                    {
                        x.Top = this.ClientSize.Width - rand.Next(500, 500);
                        x.Left = this.ClientSize.Width - rand.Next(20, 480);
                        score++;
                    }
                }
                //zwiększanie szybkości spadania obiektów z góry
                if(countBox > 5)
                {
                    boxSpeed = 10;
                    if(countBox > 10)
                    {
                        boxSpeed = 13;
                        if (countBox > 25)
                        {
                            boxSpeed = 17;
                            if (countBox > 40)
                            {
                                boxSpeed = 21;
                                if (countBox > 60)
                                {
                                    boxSpeed = 24;
                                }
                            }
                        }
                    }
                }
                //zdarzenia jeśli gracz wyjdzie poza obszar planszy
                if(player.Location.Y > 605 - player.Height || player.Location.Y < 10 - player.Height ||
                   player.Location.X > 495 - player.Width || player.Location.X < 6 - player.Width)
                {
                    timer.Stop();
                    DialogResult result = MessageBox.Show("Grasz dalej?", "Nie uciekaj z planszy!", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        this.Hide();
                        Dodger d = new Dodger(loginTB.Text);
                        d.Show();
                        break;
                    }
                    else
                    {
                        this.Hide();
                        UserMain um = new UserMain(loginTB.Text);
                        um.Show();
                        break;
                    }
                }
            }
        }
    }
}
