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
    public partial class RouteForm : BaseForm
    {
        public RouteForm()
        {
            InitializeComponent();
        }
        private void Btnviewroute_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "SELECT RouteID, FromCity, ToCity, Distance FROM Route";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvroutes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btnaddroute_Click(object sender, EventArgs e)
        {
            string fromCity = cbfromcity.SelectedItem?.ToString();
            string toCity = cbtocity.SelectedItem?.ToString();
            string distance = txtdistance.Text.Trim();

            if (string.IsNullOrEmpty(fromCity) || string.IsNullOrEmpty(toCity) || distance == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            if (fromCity == toCity)
            {
                MessageBox.Show("From City and To City cannot be the same!");
                return;
            }
            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();

                    // Check if route already exists
                    string checkQuery = "SELECT COUNT(*) FROM Route WHERE FromCity=@FromCity AND ToCity=@ToCity";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@FromCity", fromCity);
                        checkCmd.Parameters.AddWithValue("@ToCity", toCity);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This route already exists!");
                            return; 
                        }
                    }

                    // Insert new route
                    string insertQuery = "INSERT INTO Route (FromCity, ToCity, Distance) VALUES (@FromCity, @ToCity, @Distance)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@FromCity", fromCity);
                        cmd.Parameters.AddWithValue("@ToCity", toCity);
                        cmd.Parameters.AddWithValue("@Distance", distance);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Route added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private int selectedRouteID = 0;

        private void dgvroutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvroutes.Rows[e.RowIndex];
                selectedRouteID = Convert.ToInt32(row.Cells["RouteID"].Value);
                cbfromcity.SelectedItem = row.Cells["FromCity"].Value.ToString();
                cbtocity.SelectedItem = row.Cells["ToCity"].Value.ToString();
                txtdistance.Text = row.Cells["Distance"].Value.ToString();
            }
        }

        private void Btndeleteroute_Click(object sender, EventArgs e)
        {
            if (selectedRouteID == 0)
            {
                MessageBox.Show("Please select a route to delete!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Route WHERE RouteID=@RouteID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RouteID", selectedRouteID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Route deleted successfully!");
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
