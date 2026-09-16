namespace Faisal_Movers_Booking_System
{
    partial class PassengerForm
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
            this.txtpassname = new System.Windows.Forms.TextBox();
            this.txtphnum = new System.Windows.Forms.TextBox();
            this.txtcnic = new System.Windows.Forms.TextBox();
            this.btnaddpass = new System.Windows.Forms.Button();
            this.btneditpass = new System.Windows.Forms.Button();
            this.dgvpassengers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnviewpassenger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(1164, 2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNIC:";
            // 
            // txtpassname
            // 
            this.txtpassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassname.Location = new System.Drawing.Point(287, 110);
            this.txtpassname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassname.Name = "txtpassname";
            this.txtpassname.Size = new System.Drawing.Size(227, 39);
            this.txtpassname.TabIndex = 3;
            // 
            // txtphnum
            // 
            this.txtphnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphnum.Location = new System.Drawing.Point(287, 289);
            this.txtphnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphnum.Name = "txtphnum";
            this.txtphnum.Size = new System.Drawing.Size(227, 39);
            this.txtphnum.TabIndex = 4;
            // 
            // txtcnic
            // 
            this.txtcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnic.Location = new System.Drawing.Point(287, 200);
            this.txtcnic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcnic.Name = "txtcnic";
            this.txtcnic.Size = new System.Drawing.Size(227, 39);
            this.txtcnic.TabIndex = 5;
            this.txtcnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnic_KeyPress);
            // 
            // btnaddpass
            // 
            this.btnaddpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpass.Location = new System.Drawing.Point(213, 386);
            this.btnaddpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddpass.Name = "btnaddpass";
            this.btnaddpass.Size = new System.Drawing.Size(178, 95);
            this.btnaddpass.TabIndex = 6;
            this.btnaddpass.Text = "Add Passenger";
            this.btnaddpass.UseVisualStyleBackColor = true;
            this.btnaddpass.Click += new System.EventHandler(this.btnaddpass_Click);
            // 
            // btneditpass
            // 
            this.btneditpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditpass.Location = new System.Drawing.Point(439, 386);
            this.btneditpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditpass.Name = "btneditpass";
            this.btneditpass.Size = new System.Drawing.Size(190, 95);
            this.btneditpass.TabIndex = 7;
            this.btneditpass.Text = "Edit Passenger";
            this.btneditpass.UseVisualStyleBackColor = true;
            this.btneditpass.Click += new System.EventHandler(this.btneditpass_Click);
            // 
            // dgvpassengers
            // 
            this.dgvpassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpassengers.Location = new System.Drawing.Point(595, 110);
            this.dgvpassengers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvpassengers.Name = "dgvpassengers";
            this.dgvpassengers.RowHeadersWidth = 51;
            this.dgvpassengers.RowTemplate.Height = 24;
            this.dgvpassengers.Size = new System.Drawing.Size(643, 218);
            this.dgvpassengers.TabIndex = 8;
            this.dgvpassengers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpassengers_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Passengers";
            // 
            // Btnviewpassenger
            // 
            this.Btnviewpassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewpassenger.Location = new System.Drawing.Point(685, 386);
            this.Btnviewpassenger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnviewpassenger.Name = "Btnviewpassenger";
            this.Btnviewpassenger.Size = new System.Drawing.Size(198, 95);
            this.Btnviewpassenger.TabIndex = 10;
            this.Btnviewpassenger.Text = "View Passengers";
            this.Btnviewpassenger.UseVisualStyleBackColor = true;
            this.Btnviewpassenger.Click += new System.EventHandler(this.Btnviewpassenger_Click);
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 562);
            this.Controls.Add(this.Btnviewpassenger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvpassengers);
            this.Controls.Add(this.btneditpass);
            this.Controls.Add(this.btnaddpass);
            this.Controls.Add(this.txtcnic);
            this.Controls.Add(this.txtphnum);
            this.Controls.Add(this.txtpassname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PassengerForm";
            this.Text = "PassengerForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtpassname, 0);
            this.Controls.SetChildIndex(this.txtphnum, 0);
            this.Controls.SetChildIndex(this.txtcnic, 0);
            this.Controls.SetChildIndex(this.btnaddpass, 0);
            this.Controls.SetChildIndex(this.btneditpass, 0);
            this.Controls.SetChildIndex(this.dgvpassengers, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Btnviewpassenger, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassname;
        private System.Windows.Forms.TextBox txtphnum;
        private System.Windows.Forms.TextBox txtcnic;
        private System.Windows.Forms.Button btnaddpass;
        private System.Windows.Forms.Button btneditpass;
        private System.Windows.Forms.DataGridView dgvpassengers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btnviewpassenger;
    }
}