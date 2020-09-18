using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            hasloTB.PasswordChar = '*';
        }

        //walidator adresu e-mail
        bool ValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void rejestracjaBTN_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string email = emailTB.Text;
            string haslo = hasloTB.Text;

            SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-2I2V4OF;
                                                             Database=DatabaseApp;
                                                             Trusted_Connection=True;");//połączenie z bazą danych
            cnn.Open();
            String sql = "Insert into users (login,email,password) values (@param1,@param2,@param3)";
            String sqlLogin = "select count(*) from users where login='" + loginTB.Text + "'";
            String sqlPunkty = "update users set score = @setScore where login = '" + loginTB.Text + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlCommand commandLogin = new SqlCommand(sqlLogin, cnn);


            int ileLogin = (int)commandLogin.ExecuteScalar();

            //poniżej walidacja poszczególnych danych do wpisania podczas rejestracji
            if (loginTB.TextLength < 4)
            {
                loginInfoLBL.Text = "Za krótki login";
                loginInfoLBL.BackColor = Color.IndianRed;
            }
            else
            {
                if (ileLogin > 0)
                {
                    loginInfoLBL.Text = "Istnieje już użytkownik o takim loginie";
                    loginInfoLBL.BackColor = Color.IndianRed;
                }
                else
                {
                    command.Parameters.AddWithValue("@param1", login);
                    loginInfoLBL.Text = "OK";
                    loginInfoLBL.BackColor = Color.Green;
                }
            }
            if (ValidEmail(email) == false)
            {
                emailInfoLBL.Text = "Zły format";
                emailInfoLBL.BackColor = Color.IndianRed;
            }
            else
            {
                command.Parameters.AddWithValue("@param2", email);
                emailInfoLBL.Text = "OK";
                emailInfoLBL.BackColor = Color.Green;
            }
            bool hasloNumber = hasloTB.Text.Any(char.IsDigit);
            if(hasloTB.TextLength < 5 || hasloNumber == false)
            {
                hasloInfoLBL.Text = "Za krótkie hasło lub brakuje w nim cyfr";
                hasloInfoLBL.BackColor = Color.IndianRed;
            }
            else
            {
                command.Parameters.AddWithValue("@param3", haslo);
                hasloInfoLBL.Text = "OK";
                hasloInfoLBL.BackColor = Color.Green;
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch(System.Data.SqlClient.SqlException)
            {
                //MessageBox.Show("Uzupełnij odpowiednio dane");
            }
            if(emailInfoLBL.Text == "OK" && loginInfoLBL.Text == "OK" && hasloInfoLBL.Text == "OK")
            {
                hasloTB.Text = "";
                loginTB.Text = "";
                emailTB.Text = "";
                MessageBox.Show("Rejestracja udana! Zaloguj się");
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Visible = false;
            }
            cnn.Close();
        }

        private void logowanieBTN_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Visible = false;
        }

        private void offBTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
