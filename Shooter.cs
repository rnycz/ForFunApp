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
    public partial class Shooter : Form
    {
        public Shooter(string login)
        {
            InitializeComponent();
            pokaLogin(login);
        }

        private void pokaLogin(string loginPoka)
        {
            loginTB.Text = loginPoka; //pobieranie loginu
        }

        Random rand = new Random();
        bool goRight = false;
        bool goLeft = false;
        bool shoot = false;
        int score = 0;
        int tankSpeed = 5;
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.X && !shoot)
            {
                shoot = true;
                makeBullet();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.X)
            {
                shoot = false;
            }
        }

        //metoda tworząca pociski
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Size = new Size(5, 20);
            bullet.BackColor = Color.Red;
            bullet.Tag = "bullet";
            bullet.Left = tank.Left + tank.Width / 2;
            bullet.Top = tank.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        //metoda tworząca potwory
        private void makeMonster()
        {
            PictureBox monster = new PictureBox();
            monster.Size = new Size(48, 43);
            monster.Image = Properties.Resources.monster;
            monster.Tag = "monster";
            monster.Top = this.ClientSize.Height - rand.Next(400,450);
            monster.Left = this.ClientSize.Width - rand.Next(50,890);
            if (score > 3)
            {
                monster.Top = this.ClientSize.Height - rand.Next(350, 400);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            if (score > 10)
            {
                monster.Top = this.ClientSize.Height - rand.Next(300, 350);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            if (score > 30)
            {
                monster.Top = this.ClientSize.Height - rand.Next(250, 300);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            if (score > 40)
            {
                monster.Top = this.ClientSize.Height - rand.Next(200, 250);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            if (score > 55)
            {
                monster.Top = this.ClientSize.Height - rand.Next(150, 200);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            if (score > 70)
            {
                monster.Top = this.ClientSize.Height - rand.Next(100, 150);
                monster.Left = this.ClientSize.Width - rand.Next(50, 890);
            }
            this.Controls.Add(monster);
            monster.BringToFront();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            scoreLBL.Text = "Wynik: "+score.ToString();

            //sterowanie
            if (goLeft)
            {
                tank.Left -= tankSpeed;
            }
            if (goRight)
            {
                tank.Left += tankSpeed;
            }

            //animacja lecących pocisków
            foreach(Control bullet in this.Controls)
            {
                if(bullet is PictureBox && (string)bullet.Tag == "bullet")
                {
                    bullet.Top -= 20;
                }
                if(bullet.Top < this.Height - 495)
                {
                    this.Controls.Remove(bullet);
                }
            }

            //zdarzenie gry czołg zetknie się z potworem
            foreach(Control tank in this.Controls)
            {
                foreach(Control monster in this.Controls)
                {
                    if (tank is PictureBox && (string)tank.Tag == "tank")
                    {
                        if(monster is PictureBox && (string)monster.Tag == "monster")
                        {
                            if (monster.Bounds.IntersectsWith(tank.Bounds))
                            {
                                timer.Stop();
                                MessageBox.Show("Potwory są zbyt blisko ciebie. \n" +
                                    "Zdobyłeś " + score + " puntków.", "Koniec gry");
                                SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");
                                cnn.Open();
                                String sql = "update users set score = score + @addScore where login = +'" + loginTB.Text + "'";
                                SqlCommand command = new SqlCommand(sql, cnn);
                                command.Parameters.AddWithValue("addScore", score);
                                command.ExecuteNonQuery();
                                cnn.Close();

                                UserMain um = new UserMain(loginTB.Text);
                                um.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }

            //zdarzenie gdy pocisk trafi potwora
            foreach(Control bullet in this.Controls)
            {
                foreach(Control monster in this.Controls)
                {
                    if(bullet is PictureBox && (string)bullet.Tag == "bullet")
                    {
                        if(monster is PictureBox && (string)monster.Tag == "monster")
                        {
                            if (bullet.Bounds.IntersectsWith(monster.Bounds))
                            {
                                score++;
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(monster);
                                makeMonster();
                                if(score > 5)
                                {
                                    makeMonster();
                                    tankSpeed = 7;
                                }
                                if (score > 35)
                                {
                                    tankSpeed = 10;
                                }
                            }
                        }
                    }
                }
            }

            //zdarzenie gdy czołg wyjedzie poza plansze
            if(tank.Location.X > 858 || tank.Location.X < -40)
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("Grasz dalej?", "Nie uciekaj z placu boju!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Shooter s = new Shooter(loginTB.Text);
                    s.Show();
                }
                else
                {
                    this.Hide();
                    UserMain um = new UserMain(loginTB.Text);
                    um.Show();
                }
            }
        }
    }
}
