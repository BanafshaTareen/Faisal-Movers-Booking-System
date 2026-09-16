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

namespace Faisal_Movers_Booking_System
{
    public partial class UserForm : BaseForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Btnviewusers_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "SELECT UserID, Username, PasswordHash, Role FROM [Users]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvusers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

/// //////////////////////////////////////////////////////

        private void btnadduser_Click(object sender, EventArgs e)
        {
            string username = txtusernames.Text.Trim();
            string password = txtpasswords.Text.Trim();
            string role = cbrole.SelectedItem?.ToString();

            if (username == "" || password == "" || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO [Users] (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private int selectedUserID = 0;
           
        private void dgvusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvusers.Rows[e.RowIndex];
                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txtusernames.Text = row.Cells["Username"].Value.ToString();
                txtpasswords.Text = row.Cells["PasswordHash"].Value.ToString();
                cbrole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }
/// ////////////////////////////////////////////////////
        private void Btnedituser_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to edit!");
                return;
            }

            string username = txtusernames.Text.Trim();
            string password = txtpasswords.Text.Trim();
            string role = cbrole.SelectedItem?.ToString();
            if (username == "" || password == "" || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE [Users] SET Username=@Username, PasswordHash=@PasswordHash, Role=@Role WHERE UserID=@UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@UserID", selectedUserID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btndeluser_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to delete!");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM [Users] WHERE UserID=@UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", selectedUserID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

