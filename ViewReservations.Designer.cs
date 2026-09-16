namespace Faisal_Movers_Booking_System
{
    partial class ViewReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnsearch = new System.Windows.Forms.Button();
            this.Btnclear = new System.Windows.Forms.Button();
            this.Btndelrecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(1088, 12);
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(67, 80);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(1018, 349);
            this.dgvReservations.TabIndex = 0;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservations:";
            // 
            // txtSearchCNIC
            // 
            this.txtSearchCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCNIC.Location = new System.Drawing.Point(351, 484);
            this.txtSearchCNIC.Name = "txtSearchCNIC";
            this.txtSearchCNIC.Size = new System.Drawing.Size(243, 39);
            this.txtSearchCNIC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter CNIC to Search:";
            // 
            // Btnsearch
            // 
            this.Btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsearch.Location = new System.Drawing.Point(610, 480);
            this.Btnsearch.Name = "Btnsearch";
            this.Btnsearch.Size = new System.Drawing.Size(120, 47);
            this.Btnsearch.TabIndex = 4;
            this.Btnsearch.Text = "Search";
            this.Btnsearch.UseVisualStyleBackColor = true;
            this.Btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // Btnclear
            // 
            this.Btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclear.Location = new System.Drawing.Point(748, 480);
            this.Btnclear.Name = "Btnclear";
            this.Btnclear.Size = new System.Drawing.Size(120, 47);
            this.Btnclear.TabIndex = 5;
            this.Btnclear.Text = "Clear";
            this.Btnclear.UseVisualStyleBackColor = true;
            this.Btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // Btndelrecord
            // 
            this.Btndelrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelrecord.Location = new System.Drawing.Point(950, 476);
            this.Btndelrecord.Name = "Btndelrecord";
            this.Btndelrecord.Size = new System.Drawing.Size(120, 47);
            this.Btndelrecord.TabIndex = 6;
            this.Btndelrecord.Text = "Delete";
            this.Btndelrecord.UseVisualStyleBackColor = true;
            this.Btndelrecord.Click += new System.EventHandler(this.Btndelrecord_Click);
            // 
            // ViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 562);
            this.Controls.Add(this.Btndelrecord);
            this.Controls.Add(this.Btnclear);
            this.Controls.Add(this.Btnsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchCNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservations);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewReservations";
            this.Text = "View Reservations";
            this.Load += new System.EventHandler(this.ViewReservations_Load);
            this.Controls.SetChildIndex(this.dgvReservations, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchCNIC, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Btnsearch, 0);
            this.Controls.SetChildIndex(this.Btnclear, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.Btndelrecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnsearch;
        private System.Windows.Forms.Button Btnclear;
        private System.Windows.Forms.Button Btndelrecord;
    }
}