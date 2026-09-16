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
using System.Xml.Linq;

namespace Faisal_Movers_Booking_System
{
    public partial class PassengerForm : BaseForm
    {
        public PassengerForm()
        {
            InitializeComponent();
        }

        private void txtcnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private bool IsValidCNIC()
        {
            if (txtcnic.Text.Length != 13)
            {
                MessageBox.Show("CNIC must be exactly 13 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcnic.Focus();
                return false;
            }
            return true;
        }

        private void Btnviewpassenger_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string query = "SELECT Name, CNIC, Phone FROM Passenger";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpassengers.DataSource = dt;
            }
        }

        private void btnaddpass_Click(object sender, EventArgs e)
        {
            if (txtpassname.Text == "" || txtcnic.Text == "" || txtphnum.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!IsValidCNIC()) return;

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string query = @"INSERT INTO Passenger (Name, CNIC, Phone)
                         VALUES (@Name, @CNIC, @Phone)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtpassname.Text);
                cmd.Parameters.AddWithValue("@CNIC", txtcnic.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphnum.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Passenger added successfully.");
                Btnviewpassenger.PerformClick();
                ClearFields();
            }
        }
        int selectedPassengerID = 0;

        private void dgvpassengers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvpassengers.Rows[e.RowIndex];
                selectedPassengerID = Convert.ToInt32(row.Cells["PassengerID"].Value);
                txtpassname.Text = row.Cells["Name"].Value.ToString();
                txtcnic.Text = row.Cells["CNIC"].Value.ToString();
                txtphnum.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void btneditpass_Click(object sender, EventArgs e)
        {
            if (selectedPassengerID == 0)
            {
                MessageBox.Show("Please select a passenger to edit.");
                return;
            }

            if (!IsValidCNIC()) return;

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string query = @"UPDATE Passenger 
                         SET Name=@Name, CNIC=@CNIC, Phone=@Phone
                         WHERE PassengerID=@PassengerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtpassname.Text);
                cmd.Parameters.AddWithValue("@CNIC", txtcnic.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphnum.Text);
                cmd.Parameters.AddWithValue("@PassengerID", selectedPassengerID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Passenger updated successfully.");
                Btnviewpassenger.PerformClick();
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtpassname.Clear();
            txtcnic.Clear();
            txtphnum.Clear();
            selectedPassengerID = 0;
        }

    }
}

