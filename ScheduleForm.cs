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
    public partial class ScheduleForm : BaseForm
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadAvailableBuses();
            LoadRoutes();
        }
        private void LoadAvailableBuses()
        {
            cbbuses.Items.Clear();

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                con.Open();
                string query = @"
              SELECT BusID, BusNumber 
              FROM Bus 
              WHERE BusID NOT IN (SELECT BusID FROM Schedule)";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbbuses.Items.Add(new ComboBoxItem
                        (
                        dr["BusNumber"].ToString(),
                        dr["BusID"].ToString()
                    ));
                }
            }
        }
        private void LoadRoutes()
        {
            cbroutes.Items.Clear();

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                con.Open();
                string query = "SELECT RouteID, FromCity, ToCity FROM Route";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string display = dr["FromCity"] + " → " + dr["ToCity"];
                    cbroutes.Items.Add(new ComboBoxItem(display, dr["RouteID"].ToString()));
                }
            }
        }

        private void Btnsaveschedule_Click(object sender, EventArgs e)
        {
           
            if (cbbuses.SelectedItem == null || cbroutes.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            ComboBoxItem bus = (ComboBoxItem)cbbuses.SelectedItem;
            ComboBoxItem route = (ComboBoxItem)cbroutes.SelectedItem;

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO Schedule 
                        (BusID, RouteID, DepartureTime, ArrivalTime)
                        VALUES (@BusID, @RouteID, @Departure, @Arrival)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BusID", bus.Value);
                cmd.Parameters.AddWithValue("@RouteID", route.Value);
                cmd.Parameters.AddWithValue("@Departure", dtpDeparture.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@Arrival", dtpArrival.Value.TimeOfDay);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule saved successfully!");
            }

            LoadAvailableBuses();   // remove used bus
  
        }

        private void Btnviewschedule_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT s.ScheduleID,
                   b.BusNumber,
                   r.FromCity + ' → ' + r.ToCity AS Route,
                   s.DepartureTime,
                   s.ArrivalTime
            FROM Schedule s
            JOIN Bus b ON s.BusID = b.BusID
            JOIN Route r ON s.RouteID = r.RouteID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvschedule.DataSource = dt;
            }
        }
        int selectedScheduleID = 0;

        private void dgvschedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedScheduleID = Convert.ToInt32(dgvschedule.Rows[e.RowIndex].Cells["ScheduleID"].Value);
            }
        }

        private void Btndelschedule_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == 0)
            {
                MessageBox.Show("Please select a schedule to delete!");
                return;
            }

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Schedule WHERE ScheduleID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", selectedScheduleID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule deleted!");
            }

            selectedScheduleID = 0;
            LoadAvailableBuses();   // bus becomes available again
            Btnviewschedule_Click(null, null);
        }
    }
}
