namespace Faisal_Movers_Booking_System
{
    partial class RouteForm
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
            this.cbfromcity = new System.Windows.Forms.ComboBox();
            this.cbtocity = new System.Windows.Forms.ComboBox();
            this.txtdistance = new System.Windows.Forms.TextBox();
            this.Btnaddroute = new System.Windows.Forms.Button();
            this.Btnviewroute = new System.Windows.Forms.Button();
            this.Btndeleteroute = new System.Windows.Forms.Button();
            this.dgvroutes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "From City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "To City:";
            // 
            // cbfromcity
            // 
            this.cbfromcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfromcity.FormattingEnabled = true;
            this.cbfromcity.Items.AddRange(new object[] {
            "Multan",
            "Lahore",
            "Karachi",
            "Islamabad",
            "Faislabad",
            "Quetta",
            "Peshawar",
            "Abbotabad",
            "Rahim Yar Khan",
            "Gujranwala"});
            this.cbfromcity.Location = new System.Drawing.Point(235, 67);
            this.cbfromcity.Name = "cbfromcity";
            this.cbfromcity.Size = new System.Drawing.Size(121, 37);
            this.cbfromcity.TabIndex = 4;
            // 
            // cbtocity
            // 
            this.cbtocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtocity.FormattingEnabled = true;
            this.cbtocity.Items.AddRange(new object[] {
            "Multan",
            "Lahore",
            "Karachi",
            "Islamabad",
            "Faislabad",
            "Quetta",
            "Peshawar",
            "Abbotabad",
            "Rahim Yar Khan",
            "Gujranwala"});
            this.cbtocity.Location = new System.Drawing.Point(235, 142);
            this.cbtocity.Name = "cbtocity";
            this.cbtocity.Size = new System.Drawing.Size(121, 37);
            this.cbtocity.TabIndex = 5;
            // 
            // txtdistance
            // 
            this.txtdistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistance.Location = new System.Drawing.Point(235, 217);
            this.txtdistance.Name = "txtdistance";
            this.txtdistance.Size = new System.Drawing.Size(121, 34);
            this.txtdistance.TabIndex = 6;
            // 
            // Btnaddroute
            // 
            this.Btnaddroute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddroute.Location = new System.Drawing.Point(73, 316);
            this.Btnaddroute.Name = "Btnaddroute";
            this.Btnaddroute.Size = new System.Drawing.Size(116, 87);
            this.Btnaddroute.TabIndex = 7;
            this.Btnaddroute.Text = "Add Route";
            this.Btnaddroute.UseVisualStyleBackColor = true;
            this.Btnaddroute.Click += new System.EventHandler(this.Btnaddroute_Click);
            // 
            // Btnviewroute
            // 
            this.Btnviewroute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewroute.Location = new System.Drawing.Point(534, 316);
            this.Btnviewroute.Name = "Btnviewroute";
            this.Btnviewroute.Size = new System.Drawing.Size(110, 87);
            this.Btnviewroute.TabIndex = 8;
            this.Btnviewroute.Text = "View Routes";
            this.Btnviewroute.UseVisualStyleBackColor = true;
            this.Btnviewroute.Click += new System.EventHandler(this.Btnviewroute_Click);
            // 
            // Btndeleteroute
            // 
            this.Btndeleteroute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndeleteroute.Location = new System.Drawing.Point(318, 316);
            this.Btndeleteroute.Name = "Btndeleteroute";
            this.Btndeleteroute.Size = new System.Drawing.Size(120, 87);
            this.Btndeleteroute.TabIndex = 9;
            this.Btndeleteroute.Text = "Delete Route";
            this.Btndeleteroute.UseVisualStyleBackColor = true;
            this.Btndeleteroute.Click += new System.EventHandler(this.Btndeleteroute_Click);
            // 
            // dgvroutes
            // 
            this.dgvroutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroutes.Location = new System.Drawing.Point(424, 67);
            this.dgvroutes.Name = "dgvroutes";
            this.dgvroutes.RowHeadersWidth = 51;
            this.dgvroutes.RowTemplate.Height = 24;
            this.dgvroutes.Size = new System.Drawing.Size(323, 184);
            this.dgvroutes.TabIndex = 11;
            this.dgvroutes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroutes_CellClick);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvroutes);
            this.Controls.Add(this.Btndeleteroute);
            this.Controls.Add(this.Btnviewroute);
            this.Controls.Add(this.Btnaddroute);
            this.Controls.Add(this.txtdistance);
            this.Controls.Add(this.cbtocity);
            this.Controls.Add(this.cbfromcity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RouteForm";
            this.Text = "Route Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvroutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbfromcity;
        private System.Windows.Forms.ComboBox cbtocity;
        private System.Windows.Forms.TextBox txtdistance;
        private System.Windows.Forms.Button Btnaddroute;
        private System.Windows.Forms.Button Btnviewroute;
        private System.Windows.Forms.Button Btndeleteroute;
        private System.Windows.Forms.DataGridView dgvroutes;
    }
}