namespace Faisal_Movers_Booking_System
{
    partial class BusForm
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
            this.txtbusnumber = new System.Windows.Forms.TextBox();
            this.txtbuscapacity = new System.Windows.Forms.TextBox();
            this.Btnaddbus = new System.Windows.Forms.Button();
            this.Btndeletebus = new System.Windows.Forms.Button();
            this.Btneditbus = new System.Windows.Forms.Button();
            this.Btnviewbuses = new System.Windows.Forms.Button();
            this.dgvbus = new System.Windows.Forms.DataGridView();
            this.cbtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bus Capacity:";
            // 
            // txtbusnumber
            // 
            this.txtbusnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnumber.Location = new System.Drawing.Point(228, 71);
            this.txtbusnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbusnumber.Name = "txtbusnumber";
            this.txtbusnumber.Size = new System.Drawing.Size(166, 39);
            this.txtbusnumber.TabIndex = 3;
            // 
            // txtbuscapacity
            // 
            this.txtbuscapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscapacity.Location = new System.Drawing.Point(228, 149);
            this.txtbuscapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbuscapacity.Name = "txtbuscapacity";
            this.txtbuscapacity.Size = new System.Drawing.Size(166, 39);
            this.txtbuscapacity.TabIndex = 5;
            // 
            // Btnaddbus
            // 
            this.Btnaddbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddbus.Location = new System.Drawing.Point(138, 382);
            this.Btnaddbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnaddbus.Name = "Btnaddbus";
            this.Btnaddbus.Size = new System.Drawing.Size(129, 95);
            this.Btnaddbus.TabIndex = 6;
            this.Btnaddbus.Text = "Add Bus";
            this.Btnaddbus.UseVisualStyleBackColor = true;
            this.Btnaddbus.Click += new System.EventHandler(this.Btnaddbus_Click);
            // 
            // Btndeletebus
            // 
            this.Btndeletebus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndeletebus.Location = new System.Drawing.Point(532, 382);
            this.Btndeletebus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndeletebus.Name = "Btndeletebus";
            this.Btndeletebus.Size = new System.Drawing.Size(141, 95);
            this.Btndeletebus.TabIndex = 7;
            this.Btndeletebus.Text = "Delete Bus";
            this.Btndeletebus.UseVisualStyleBackColor = true;
            this.Btndeletebus.Click += new System.EventHandler(this.Btndeletebus_Click);
            // 
            // Btneditbus
            // 
            this.Btneditbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneditbus.Location = new System.Drawing.Point(344, 382);
            this.Btneditbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btneditbus.Name = "Btneditbus";
            this.Btneditbus.Size = new System.Drawing.Size(125, 95);
            this.Btneditbus.TabIndex = 8;
            this.Btneditbus.Text = "Edit Bus";
            this.Btneditbus.UseVisualStyleBackColor = true;
            this.Btneditbus.Click += new System.EventHandler(this.Btneditbus_Click);
            // 
            // Btnviewbuses
            // 
            this.Btnviewbuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewbuses.Location = new System.Drawing.Point(720, 382);
            this.Btnviewbuses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnviewbuses.Name = "Btnviewbuses";
            this.Btnviewbuses.Size = new System.Drawing.Size(141, 95);
            this.Btnviewbuses.TabIndex = 9;
            this.Btnviewbuses.Text = "View Buses";
            this.Btnviewbuses.UseVisualStyleBackColor = true;
            this.Btnviewbuses.Click += new System.EventHandler(this.Btnviewbuses_Click);
            // 
            // dgvbus
            // 
            this.dgvbus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbus.Location = new System.Drawing.Point(418, 71);
            this.dgvbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvbus.Name = "dgvbus";
            this.dgvbus.RowHeadersWidth = 51;
            this.dgvbus.RowTemplate.Height = 24;
            this.dgvbus.Size = new System.Drawing.Size(527, 214);
            this.dgvbus.TabIndex = 10;
            this.dgvbus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbus_CellClick);
            // 
            // cbtype
            // 
            this.cbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Seater",
            "Sleeper"});
            this.cbtype.Location = new System.Drawing.Point(228, 239);
            this.cbtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(166, 40);
            this.cbtype.TabIndex = 11;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 562);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.dgvbus);
            this.Controls.Add(this.Btnviewbuses);
            this.Controls.Add(this.Btneditbus);
            this.Controls.Add(this.Btndeletebus);
            this.Controls.Add(this.Btnaddbus);
            this.Controls.Add(this.txtbuscapacity);
            this.Controls.Add(this.txtbusnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BusForm";
            this.Text = "Buses";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtbusnumber, 0);
            this.Controls.SetChildIndex(this.txtbuscapacity, 0);
            this.Controls.SetChildIndex(this.Btnaddbus, 0);
            this.Controls.SetChildIndex(this.Btndeletebus, 0);
            this.Controls.SetChildIndex(this.Btneditbus, 0);
            this.Controls.SetChildIndex(this.Btnviewbuses, 0);
            this.Controls.SetChildIndex(this.dgvbus, 0);
            this.Controls.SetChildIndex(this.cbtype, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusnumber;
        private System.Windows.Forms.TextBox txtbuscapacity;
        private System.Windows.Forms.Button Btnaddbus;
        private System.Windows.Forms.Button Btndeletebus;
        private System.Windows.Forms.Button Btneditbus;
        private System.Windows.Forms.Button Btnviewbuses;
        private System.Windows.Forms.DataGridView dgvbus;
        private System.Windows.Forms.ComboBox cbtype;
    }
}