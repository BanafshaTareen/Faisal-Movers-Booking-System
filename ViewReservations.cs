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
    public partial class ViewReservations :BaseForm
    {
        public ViewReservations()
        {
            InitializeComponent();
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            LoadAllReservations();
            this.BookingReceipt.RefreshReport();
        }
        private void LoadAllReservations()
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = @"
        SELECT 
            r.ReservationID,
            p.Name AS PassengerName,
            p.CNIC,
            rt.FromCity + ' -> ' + rt.ToCity AS Route,
            CONVERT(varchar, s.DepartureTime, 108) + ' - ' +
            CONVERT(varchar, s.ArrivalTime, 108) AS Schedule,
            r.TravelDate,
            r.SeatNo,
            r.Fare
        FROM Reservation r
        JOIN Passenger p ON r.PassengerID = p.PassengerID
        JOIN Schedule s ON r.ScheduleID = s.ScheduleID
        JOIN Route rt ON s.RouteID = rt.RouteID";

                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservations.DataSource = dt;
            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            if (txtSearchCNIC.Text.Trim() == "")
            {
                MessageBox.Show("Please enter CNIC.");
                return;
            }

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                // Step 1: Check if passenger exists
                string checkPassenger = "SELECT COUNT(*) FROM Passenger WHERE CNIC=@CNIC";
                SqlCommand cmdCheck = new SqlCommand(checkPassenger, con);
                cmdCheck.Parameters.AddWithValue("@CNIC", txtSearchCNIC.Text.Trim());

                con.Open();
                int passengerExists = Convert.ToInt32(cmdCheck.ExecuteScalar());
                con.Close();

                if (passengerExists == 0)
                {
                    MessageBox.Show("Passenger does not exist.");
                    return;
                }

                // Step 2: Get reservations for that CNIC
                string q = @"
        SELECT 
            r.ReservationID,
            p.Name AS PassengerName,
            p.CNIC,
            rt.FromCity + ' -> ' + rt.ToCity AS Route,
            CONVERT(varchar, s.DepartureTime, 108) + ' - ' +
            CONVERT(varchar, s.ArrivalTime, 108) AS Schedule,
            r.TravelDate,
            r.SeatNo,
            r.Fare
        FROM Reservation r
        JOIN Passenger p ON r.PassengerID = p.PassengerID
        JOIN Schedule s ON r.ScheduleID = s.ScheduleID
        JOIN Route rt ON s.RouteID = rt.RouteID
        WHERE p.CNIC = @CNIC";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@CNIC", txtSearchCNIC.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No reservation found for this CNIC.");
                    dgvReservations.DataSource = null;
                }
                else
                {
                    dgvReservations.DataSource = dt;
                }
            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            txtSearchCNIC.Clear();    
            LoadAllReservations();    
            txtSearchCNIC.Focus();
        }
        private int selectedReservationID = 0;

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservations.Rows[e.RowIndex];
                selectedReservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);
               
            }
        }
        private void Btndelrecord_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == 0)
            {
                MessageBox.Show("Please select a Reservation to delete!");
                return;
            }

            try
            {
                using (SqlConnection con = Connectionclass.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Reservation WHERE ReservationID=@ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", selectedReservationID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reservation deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadAllReservations();
        }
    }
}
