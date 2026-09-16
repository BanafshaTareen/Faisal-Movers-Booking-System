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
    public partial class ReservationForm :BaseForm
    {
        public ReservationForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadRoutes();
            LoadPassengerCNICs();
        }
        private void LoadRoutes()
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = "SELECT RouteID, FromCity + ' -> ' + ToCity AS RouteName FROM Route";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbroutes.DisplayMember = "RouteName";
                cbroutes.ValueMember = "RouteID";
                cbroutes.DataSource = dt;
            }
        }

        private void Btnshowschedule_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = @"
        SELECT 
            s.ScheduleID,
            CONVERT(varchar, s.DepartureTime, 108) + ' - ' +
            CONVERT(varchar, s.ArrivalTime, 108) + 
            ' (' + b.BusType + ')' AS ScheduleDisplay
        FROM Schedule s
        JOIN Bus b ON s.BusID = b.BusID
        WHERE s.RouteID = @RouteID";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@RouteID", cbroutes.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbschedules.DisplayMember = "ScheduleDisplay";
                cbschedules.ValueMember = "ScheduleID";
                cbschedules.DataSource = dt;
            }
        }

        private void Btnshowseats_Click(object sender, EventArgs e)
        {
            cbseats.Items.Clear();

            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = @"
        DECLARE @capacity INT;

        SELECT @capacity = b.Capacity
        FROM Schedule s
        JOIN Bus b ON s.BusID = b.BusID
        WHERE s.ScheduleID = @ScheduleID;

        SELECT number
        FROM master..spt_values
        WHERE type='P'
        AND number BETWEEN 1 AND @capacity
        AND number NOT IN (
            SELECT SeatNo FROM Reservation
            WHERE ScheduleID=@ScheduleID
            AND TravelDate=@TravelDate
        )";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ScheduleID", cbschedules.SelectedValue);
                cmd.Parameters.AddWithValue("@TravelDate", dateTravelDate.Value.Date);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbseats.Items.Add(dr["number"].ToString());
                }
                con.Close();
            }
        }
        private void LoadPassengerCNICs()
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = "SELECT CNIC FROM Passenger";
                SqlCommand cmd = new SqlCommand(q, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbpasscnic.Items.Add(dr["CNIC"].ToString());
                }
                con.Close();
            }
        }
        private void cmbpasscnic_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = "SELECT Name, Phone FROM Passenger WHERE CNIC=@CNIC";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@CNIC", cmbpasscnic.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtpname.Text = dr["Name"].ToString();
                    txtpphnum.Text = dr["Phone"].ToString();
                }
                con.Close();
            }
        }

        private void Btnaddnewpass_Click(object sender, EventArgs e)
        {
            PassengerForm p = new PassengerForm();
            p.ShowDialog();
            
        }

        private void CalculateFare()
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = @"
        SELECT 
        CASE 
          WHEN b.BusType='Sleeper' THEN r.Distance * 5
          ELSE r.Distance * 3
        END AS Fare
        FROM Schedule s
        JOIN Bus b ON s.BusID=b.BusID
        JOIN Route r ON s.RouteID=r.RouteID
        WHERE s.ScheduleID=@ScheduleID";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ScheduleID", cbschedules.SelectedValue);

                con.Open();
                txtfare.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
        }

        private void Btnsavereservation_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connectionclass.GetConnection())
            {
                string q = @"
        INSERT INTO Reservation
        (ScheduleID, PassengerID, SeatNo, TravelDate, Fare)
        VALUES
        (
          @ScheduleID,
          (SELECT PassengerID FROM Passenger WHERE CNIC=@CNIC),
          @Seat,
          @Date,
          @Fare
        )";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ScheduleID", cbschedules.SelectedValue);
                cmd.Parameters.AddWithValue("@CNIC", cmbpasscnic.Text);
                cmd.Parameters.AddWithValue("@Seat", cbseats.Text);
                cmd.Parameters.AddWithValue("@Date", dateTravelDate.Value.Date);
                cmd.Parameters.AddWithValue("@Fare", txtfare.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Reservation successful!");
                
            }
        }

        private void cbschedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbschedules.SelectedIndex != -1)
            {
               CalculateFare();
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            LoadPassengerCNICs();
        }
    }
}
