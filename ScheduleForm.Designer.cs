namespace Faisal_Movers_Booking_System
{
    partial class ScheduleForm
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
            this.cbbuses = new System.Windows.Forms.ComboBox();
            this.cbroutes = new System.Windows.Forms.ComboBox();
            this.dgvschedule = new System.Windows.Forms.DataGridView();
            this.Btnsaveschedule = new System.Windows.Forms.Button();
            this.Btndelschedule = new System.Windows.Forms.Button();
            this.Btnviewschedule = new System.Windows.Forms.Button();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Route:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival Time:";
            // 
            // cbbuses
            // 
            this.cbbuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbuses.FormattingEnabled = true;
            this.cbbuses.Location = new System.Drawing.Point(435, 72);
            this.cbbuses.Name = "cbbuses";
            this.cbbuses.Size = new System.Drawing.Size(121, 37);
            this.cbbuses.TabIndex = 6;
            // 
            // cbroutes
            // 
            this.cbroutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroutes.FormattingEnabled = true;
            this.cbroutes.Location = new System.Drawing.Point(610, 72);
            this.cbroutes.Name = "cbroutes";
            this.cbroutes.Size = new System.Drawing.Size(121, 37);
            this.cbroutes.TabIndex = 7;
            // 
            // dgvschedule
            // 
            this.dgvschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvschedule.Location = new System.Drawing.Point(36, 200);
            this.dgvschedule.Name = "dgvschedule";
            this.dgvschedule.RowHeadersWidth = 51;
            this.dgvschedule.RowTemplate.Height = 24;
            this.dgvschedule.Size = new System.Drawing.Size(337, 150);
            this.dgvschedule.TabIndex = 8;
            this.dgvschedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvschedule_CellClick);
            // 
            // Btnsaveschedule
            // 
            this.Btnsaveschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsaveschedule.Location = new System.Drawing.Point(407, 250);
            this.Btnsaveschedule.Name = "Btnsaveschedule";
            this.Btnsaveschedule.Size = new System.Drawing.Size(149, 81);
            this.Btnsaveschedule.TabIndex = 9;
            this.Btnsaveschedule.Text = "Save Schedule";
            this.Btnsaveschedule.UseVisualStyleBackColor = true;
            this.Btnsaveschedule.Click += new System.EventHandler(this.Btnsaveschedule_Click);
            // 
            // Btndelschedule
            // 
            this.Btndelschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelschedule.Location = new System.Drawing.Point(630, 250);
            this.Btndelschedule.Name = "Btndelschedule";
            this.Btndelschedule.Size = new System.Drawing.Size(149, 81);
            this.Btndelschedule.TabIndex = 10;
            this.Btndelschedule.Text = "Delete Schedule";
            this.Btndelschedule.UseVisualStyleBackColor = true;
            this.Btndelschedule.Click += new System.EventHandler(this.Btndelschedule_Click);
            // 
            // Btnviewschedule
            // 
            this.Btnviewschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewschedule.Location = new System.Drawing.Point(536, 357);
            this.Btnviewschedule.Name = "Btnviewschedule";
            this.Btnviewschedule.Size = new System.Drawing.Size(149, 81);
            this.Btnviewschedule.TabIndex = 11;
            this.Btnviewschedule.Text = "View Schedule";
            this.Btnviewschedule.UseVisualStyleBackColor = true;
            this.Btnviewschedule.Click += new System.EventHandler(this.Btnviewschedule_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDeparture.Location = new System.Drawing.Point(227, 55);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.ShowUpDown = true;
            this.dtpDeparture.Size = new System.Drawing.Size(175, 30);
            this.dtpDeparture.TabIndex = 12;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArrival.Location = new System.Drawing.Point(227, 116);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.ShowUpDown = true;
            this.dtpArrival.Size = new System.Drawing.Size(175, 30);
            this.dtpArrival.TabIndex = 13;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.Btnviewschedule);
            this.Controls.Add(this.Btndelschedule);
            this.Controls.Add(this.Btnsaveschedule);
            this.Controls.Add(this.dgvschedule);
            this.Controls.Add(this.cbroutes);
            this.Controls.Add(this.cbbuses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleForm";
            this.Text = "Schedule Form";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvschedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbuses;
        private System.Windows.Forms.ComboBox cbroutes;
        private System.Windows.Forms.DataGridView dgvschedule;
        private System.Windows.Forms.Button Btnsaveschedule;
        private System.Windows.Forms.Button Btndelschedule;
        private System.Windows.Forms.Button Btnviewschedule;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
    }
}