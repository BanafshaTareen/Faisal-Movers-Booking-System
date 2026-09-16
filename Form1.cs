using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Faisal_Movers_Booking_System
{
    public partial class Login : BaseForm
    {
        SqlConnection con = Connectionclass.GetConnection();
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("enter details please");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();

                    string query = "SELECT Role FROM [Users] WHERE Username=@Username AND PasswordHash=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object roleObj = cmd.ExecuteScalar();

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();

                            if (role == "Admin")
                            {
                                AdminMenu adminForm = new AdminMenu();
                                adminForm.Show();
                                this.Hide(); // hide login form
                            }
                            else if (role == "Clerk")
                            {
                                ClerkMenu clerkForm = new ClerkMenu();
                                clerkForm.Show();
                                this.Hide(); // hide login form
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
          
        }

        private void BtnTogglePassword_Click(object sender, EventArgs e)
        { 
            if (txtpassword.PasswordChar == '*')
            {
                txtpassword.PasswordChar = '\0'; // show
                BtnTogglePassword.Text = "🙈";   // eye closed
            }
            else
            {
                txtpassword.PasswordChar = '*';  // hide
                BtnTogglePassword.Text = "👁";   // eye open
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
