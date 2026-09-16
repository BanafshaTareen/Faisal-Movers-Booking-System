using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faisal_Movers_Booking_System
{
    public partial class ClerkMenu : BaseForm
    {
        public ClerkMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btnbookticket_Click(object sender, EventArgs e)
        {
            ReservationForm rfs=new ReservationForm();
            rfs.ShowDialog();
        }

        private void Btnaddpassenger_Click(object sender, EventArgs e)
        {
            PassengerForm pf=new PassengerForm();
            pf.ShowDialog();
        }

        private void Btnviewbooking_Click(object sender, EventArgs e)
        {
            ViewReservations vrf=new ViewReservations();
            vrf.ShowDialog();
        }

        private void Btnclerklogout_Click(object sender, EventArgs e)
        {
            Login lg=new Login();
            lg.ShowDialog();
            this.Close();
        }
    }
}
