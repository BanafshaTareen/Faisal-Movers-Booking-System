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
    public partial class AdminMenu : BaseForm
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btnmanagebus_Click(object sender, EventArgs e)
        {
            BusForm bf= new BusForm();
            bf.ShowDialog();
        }

        private void Btnmanageroute_Click(object sender, EventArgs e)
        {
            RouteForm rf= new RouteForm();
            rf.ShowDialog();
        }

        private void btnmanageschedule_Click(object sender, EventArgs e)
        {
            ScheduleForm sf= new ScheduleForm();
            sf.ShowDialog();
        }

        private void Btnmanageuser_Click(object sender, EventArgs e)
        {
            UserForm uf= new UserForm();
            uf.ShowDialog();
        }

        private void Btnviewreservation_Click(object sender, EventArgs e)
        {
            ViewReservations vr= new ViewReservations();
            vr.ShowDialog();
        }

        private void Btnadminlogout_Click(object sender, EventArgs e)
        {
            Login l= new Login();
            l.Show();
            this.Close();
        }
    }
}
