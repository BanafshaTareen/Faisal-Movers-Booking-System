using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faisal_Movers_Booking_System
{
    public partial class BusForm : BaseForm
    {
        SqlConnection con = Connectionclass.GetConnection();
        public BusForm()
        {
            InitializeComponent();
        }

        private void Btnviewbuses_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "SELECT BusID, BusNumber, Capacity, BusType FROM Bus";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbus.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btnaddbus_Click(object sender, EventArgs e)
        {
            string busNumber = txtbusnumber.Text.Trim();
            string capacity = txtbuscapacity.Text.Trim();
            string busType = cbtype.SelectedItem?.ToString();

            if (busNumber == "" || capacity == "" || string.IsNullOrEmpty(busType))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Bus (BusNumber, Capacity, BusType) VALUES (@BusNumber, @Capacity, @BusType)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BusNumber", busNumber);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@BusType", busType);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bus added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private int selectedBusID = 0;

        private void dgvbus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbus.Rows[e.RowIndex];
                selectedBusID = Convert.ToInt32(row.Cells["BusID"].Value);
                txtbusnumber.Text = row.Cells["BusNumber"].Value.ToString();
                txtbuscapacity.Text = row.Cells["Capacity"].Value.ToString();
                cbtype.SelectedItem = row.Cells["BusType"].Value.ToString();
            }
        }

        private void Btneditbus_Click(object sender, EventArgs e)
        {
            if (selectedBusID == 0)
            {
                MessageBox.Show("Please select a bus to edit!");
                return;
            }

            string busNumber = txtbusnumber.Text.Trim();
            string capacity = txtbuscapacity.Text.Trim();
            string busType = cbtype.SelectedItem?.ToString();

            if (busNumber == "" || capacity == "" || string.IsNullOrEmpty(busType))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Bus SET BusNumber=@BusNumber, Capacity=@Capacity, BusType=@BusType WHERE BusID=@BusID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BusNumber", busNumber);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@BusType", busType);
                        cmd.Parameters.AddWithValue("@BusID", selectedBusID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bus updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btndeletebus_Click(object sender, EventArgs e)
        {
            if (selectedBusID == 0)
            {
                MessageBox.Show("Please select a bus to delete!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Bus WHERE BusID=@BusID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BusID", selectedBusID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bus deleted successfully!");
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
