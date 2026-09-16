namespace Faisal_Movers_Booking_System
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnshowschedule = new System.Windows.Forms.Button();
            this.cbroutes = new System.Windows.Forms.ComboBox();
            this.cbschedules = new System.Windows.Forms.ComboBox();
            this.dateTravelDate = new System.Windows.Forms.DateTimePicker();
            this.Btnshowseats = new System.Windows.Forms.Button();
            this.cbseats = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfare = new System.Windows.Forms.TextBox();
            this.Btnaddnewpass = new System.Windows.Forms.Button();
            this.cmbpasscnic = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpphnum = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.Btnsavereservation = new System.Windows.Forms.Button();
            this.Btnprintreceipt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Btnclose = new System.Windows.Forms.Button();
            this.Btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(1291, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Travel Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passenger CNIC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Schedules:";
            // 
            // Btnshowschedule
            // 
            this.Btnshowschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnshowschedule.Location = new System.Drawing.Point(67, 297);
            this.Btnshowschedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnshowschedule.Name = "Btnshowschedule";
            this.Btnshowschedule.Size = new System.Drawing.Size(254, 94);
            this.Btnshowschedule.TabIndex = 5;
            this.Btnshowschedule.Text = "Show available Schedules";
            this.Btnshowschedule.UseVisualStyleBackColor = true;
            this.Btnshowschedule.Click += new System.EventHandler(this.Btnshowschedule_Click);
            // 
            // cbroutes
            // 
            this.cbroutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroutes.FormattingEnabled = true;
            this.cbroutes.Location = new System.Drawing.Point(34, 173);
            this.cbroutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbroutes.Name = "cbroutes";
            this.cbroutes.Size = new System.Drawing.Size(322, 40);
            this.cbroutes.TabIndex = 6;
            // 
            // cbschedules
            // 
            this.cbschedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbschedules.FormattingEnabled = true;
            this.cbschedules.Location = new System.Drawing.Point(12, 440);
            this.cbschedules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbschedules.Name = "cbschedules";
            this.cbschedules.Size = new System.Drawing.Size(373, 40);
            this.cbschedules.TabIndex = 7;
            this.cbschedules.SelectedIndexChanged += new System.EventHandler(this.cbschedules_SelectedIndexChanged);
            // 
            // dateTravelDate
            // 
            this.dateTravelDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTravelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTravelDate.Location = new System.Drawing.Point(24, 77);
            this.dateTravelDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTravelDate.Name = "dateTravelDate";
            this.dateTravelDate.Size = new System.Drawing.Size(401, 35);
            this.dateTravelDate.TabIndex = 8;
            // 
            // Btnshowseats
            // 
            this.Btnshowseats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnshowseats.Location = new System.Drawing.Point(388, 297);
            this.Btnshowseats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnshowseats.Name = "Btnshowseats";
            this.Btnshowseats.Size = new System.Drawing.Size(254, 94);
            this.Btnshowseats.TabIndex = 9;
            this.Btnshowseats.Text = "Show available seats";
            this.Btnshowseats.UseVisualStyleBackColor = true;
            this.Btnshowseats.Click += new System.EventHandler(this.Btnshowseats_Click);
            // 
            // cbseats
            // 
            this.cbseats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseats.FormattingEnabled = true;
            this.cbseats.Location = new System.Drawing.Point(431, 440);
            this.cbseats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbseats.Name = "cbseats";
            this.cbseats.Size = new System.Drawing.Size(169, 40);
            this.cbseats.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fare:";
            // 
            // txtfare
            // 
            this.txtfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfare.Location = new System.Drawing.Point(802, 356);
            this.txtfare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfare.Name = "txtfare";
            this.txtfare.Size = new System.Drawing.Size(130, 39);
            this.txtfare.TabIndex = 12;
            // 
            // Btnaddnewpass
            // 
            this.Btnaddnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddnewpass.Location = new System.Drawing.Point(1056, 48);
            this.Btnaddnewpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnaddnewpass.Name = "Btnaddnewpass";
            this.Btnaddnewpass.Size = new System.Drawing.Size(188, 94);
            this.Btnaddnewpass.TabIndex = 14;
            this.Btnaddnewpass.Text = "Add Passenger";
            this.Btnaddnewpass.UseVisualStyleBackColor = true;
            this.Btnaddnewpass.Click += new System.EventHandler(this.Btnaddnewpass_Click);
            // 
            // cmbpasscnic
            // 
            this.cmbpasscnic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpasscnic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpasscnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpasscnic.FormattingEnabled = true;
            this.cmbpasscnic.Location = new System.Drawing.Point(683, 92);
            this.cmbpasscnic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbpasscnic.Name = "cmbpasscnic";
            this.cmbpasscnic.Size = new System.Drawing.Size(323, 40);
            this.cmbpasscnic.TabIndex = 15;
            this.cmbpasscnic.SelectedIndexChanged += new System.EventHandler(this.cmbpasscnic_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passenger Phone#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(687, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Passenger Name:";
            // 
            // txtpphnum
            // 
            this.txtpphnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpphnum.Location = new System.Drawing.Point(972, 266);
            this.txtpphnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpphnum.Name = "txtpphnum";
            this.txtpphnum.Size = new System.Drawing.Size(296, 39);
            this.txtpphnum.TabIndex = 18;
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(972, 188);
            this.txtpname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(296, 39);
            this.txtpname.TabIndex = 19;
            // 
            // Btnsavereservation
            // 
            this.Btnsavereservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsavereservation.Location = new System.Drawing.Point(718, 458);
            this.Btnsavereservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnsavereservation.Name = "Btnsavereservation";
            this.Btnsavereservation.Size = new System.Drawing.Size(195, 94);
            this.Btnsavereservation.TabIndex = 20;
            this.Btnsavereservation.Text = "Save Reservation";
            this.Btnsavereservation.UseVisualStyleBackColor = true;
            this.Btnsavereservation.Click += new System.EventHandler(this.Btnsavereservation_Click);
            // 
            // Btnprintreceipt
            // 
            this.Btnprintreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnprintreceipt.Location = new System.Drawing.Point(952, 458);
            this.Btnprintreceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnprintreceipt.Name = "Btnprintreceipt";
            this.Btnprintreceipt.Size = new System.Drawing.Size(195, 94);
            this.Btnprintreceipt.TabIndex = 21;
            this.Btnprintreceipt.Text = "Print Receipt";
            this.Btnprintreceipt.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(701, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(8, 8);
            this.button6.TabIndex = 22;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Btnclose
            // 
            this.Btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclose.Location = new System.Drawing.Point(1167, 458);
            this.Btnclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(195, 94);
            this.Btnclose.TabIndex = 23;
            this.Btnclose.Text = "Close";
            this.Btnclose.UseVisualStyleBackColor = true;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btnrefresh
            // 
            this.Btnrefresh.Location = new System.Drawing.Point(995, 139);
            this.Btnrefresh.Name = "Btnrefresh";
            this.Btnrefresh.Size = new System.Drawing.Size(44, 37);
            this.Btnrefresh.TabIndex = 24;
            this.Btnrefresh.Text = "@";
            this.Btnrefresh.UseVisualStyleBackColor = true;
            this.Btnrefresh.Click += new System.EventHandler(this.Btnrefresh_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 630);
            this.Controls.Add(this.Btnrefresh);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Btnprintreceipt);
            this.Controls.Add(this.Btnsavereservation);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.txtpphnum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbpasscnic);
            this.Controls.Add(this.Btnaddnewpass);
            this.Controls.Add(this.txtfare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbseats);
            this.Controls.Add(this.Btnshowseats);
            this.Controls.Add(this.dateTravelDate);
            this.Controls.Add(this.cbschedules);
            this.Controls.Add(this.cbroutes);
            this.Controls.Add(this.Btnshowschedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReservationForm";
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Btnshowschedule, 0);
            this.Controls.SetChildIndex(this.cbroutes, 0);
            this.Controls.SetChildIndex(this.cbschedules, 0);
            this.Controls.SetChildIndex(this.dateTravelDate, 0);
            this.Controls.SetChildIndex(this.Btnshowseats, 0);
            this.Controls.SetChildIndex(this.cbseats, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtfare, 0);
            this.Controls.SetChildIndex(this.Btnaddnewpass, 0);
            this.Controls.SetChildIndex(this.cmbpasscnic, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtpphnum, 0);
            this.Controls.SetChildIndex(this.txtpname, 0);
            this.Controls.SetChildIndex(this.Btnsavereservation, 0);
            this.Controls.SetChildIndex(this.Btnprintreceipt, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.Btnclose, 0);
            this.Controls.SetChildIndex(this.Btnrefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnshowschedule;
        private System.Windows.Forms.ComboBox cbroutes;
        private System.Windows.Forms.ComboBox cbschedules;
        private System.Windows.Forms.DateTimePicker dateTravelDate;
        private System.Windows.Forms.Button Btnshowseats;
        private System.Windows.Forms.ComboBox cbseats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfare;
        private System.Windows.Forms.Button Btnaddnewpass;
        private System.Windows.Forms.ComboBox cmbpasscnic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpphnum;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Button Btnsavereservation;
        private System.Windows.Forms.Button Btnprintreceipt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Btnclose;
        private System.Windows.Forms.Button Btnrefresh;
    }
}