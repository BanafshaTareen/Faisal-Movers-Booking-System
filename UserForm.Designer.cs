namespace Faisal_Movers_Booking_System
{
    partial class UserForm
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
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.txtusernames = new System.Windows.Forms.TextBox();
            this.txtpasswords = new System.Windows.Forms.TextBox();
            this.btnadduser = new System.Windows.Forms.Button();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.Btnviewusers = new System.Windows.Forms.Button();
            this.Btndeluser = new System.Windows.Forms.Button();
            this.Btnedituser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // cbrole
            // 
            this.cbrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "Admin",
            "Clerk"});
            this.cbrole.Location = new System.Drawing.Point(248, 202);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(156, 37);
            this.cbrole.TabIndex = 3;
            // 
            // txtusernames
            // 
            this.txtusernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusernames.Location = new System.Drawing.Point(248, 81);
            this.txtusernames.Name = "txtusernames";
            this.txtusernames.Size = new System.Drawing.Size(156, 34);
            this.txtusernames.TabIndex = 4;
            // 
            // txtpasswords
            // 
            this.txtpasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswords.Location = new System.Drawing.Point(248, 142);
            this.txtpasswords.Name = "txtpasswords";
            this.txtpasswords.Size = new System.Drawing.Size(156, 34);
            this.txtpasswords.TabIndex = 5;
            // 
            // btnadduser
            // 
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.Location = new System.Drawing.Point(51, 305);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(143, 40);
            this.btnadduser.TabIndex = 6;
            this.btnadduser.Text = "Add user";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // dgvusers
            // 
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Location = new System.Drawing.Point(432, 71);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.RowHeadersWidth = 51;
            this.dgvusers.RowTemplate.Height = 24;
            this.dgvusers.Size = new System.Drawing.Size(343, 177);
            this.dgvusers.TabIndex = 7;
            this.dgvusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusers_CellClick);
            // 
            // Btnviewusers
            // 
            this.Btnviewusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewusers.Location = new System.Drawing.Point(561, 305);
            this.Btnviewusers.Name = "Btnviewusers";
            this.Btnviewusers.Size = new System.Drawing.Size(195, 40);
            this.Btnviewusers.TabIndex = 8;
            this.Btnviewusers.Text = "View users";
            this.Btnviewusers.UseVisualStyleBackColor = true;
            this.Btnviewusers.Click += new System.EventHandler(this.Btnviewusers_Click);
            // 
            // Btndeluser
            // 
            this.Btndeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndeluser.Location = new System.Drawing.Point(397, 305);
            this.Btndeluser.Name = "Btndeluser";
            this.Btndeluser.Size = new System.Drawing.Size(143, 40);
            this.Btndeluser.TabIndex = 9;
            this.Btndeluser.Text = "Delete user";
            this.Btndeluser.UseVisualStyleBackColor = true;
            this.Btndeluser.Click += new System.EventHandler(this.Btndeluser_Click);
            // 
            // Btnedituser
            // 
            this.Btnedituser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnedituser.Location = new System.Drawing.Point(228, 305);
            this.Btnedituser.Name = "Btnedituser";
            this.Btnedituser.Size = new System.Drawing.Size(143, 40);
            this.Btnedituser.TabIndex = 10;
            this.Btnedituser.Text = "Edit user";
            this.Btnedituser.UseVisualStyleBackColor = true;
            this.Btnedituser.Click += new System.EventHandler(this.Btnedituser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnedituser);
            this.Controls.Add(this.Btndeluser);
            this.Controls.Add(this.Btnviewusers);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.txtpasswords);
            this.Controls.Add(this.txtusernames);
            this.Controls.Add(this.cbrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "User Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.TextBox txtusernames;
        private System.Windows.Forms.TextBox txtpasswords;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.Button Btnviewusers;
        private System.Windows.Forms.Button Btndeluser;
        private System.Windows.Forms.Button Btnedituser;
    }
}