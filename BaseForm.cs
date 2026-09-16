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
    using System.ComponentModel;

    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            ApplyTheme();
            ApplyLabelColor(this);
        }

        private void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(30, 58, 95);
            picLogo.Image = Properties.Resources.FMLogo;
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
        private void ApplyLabelColor(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.LightSkyBlue;
                }

                // Recursively apply to nested controls
                if (ctrl.HasChildren)
                {
                    ApplyLabelColor(ctrl);
                }
            }
        }

    }

}
