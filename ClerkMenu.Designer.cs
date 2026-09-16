namespace Faisal_Movers_Booking_System
{
    partial class ClerkMenu
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
            this.Btnbookticket = new System.Windows.Forms.Button();
            this.Btnclerklogout = new System.Windows.Forms.Button();
            this.Btnviewbooking = new System.Windows.Forms.Button();
            this.Btnaddpassenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnbookticket
            // 
            this.Btnbookticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbookticket.Location = new System.Drawing.Point(158, 95);
            this.Btnbookticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnbookticket.Name = "Btnbookticket";
            this.Btnbookticket.Size = new System.Drawing.Size(152, 91);
            this.Btnbookticket.TabIndex = 0;
            this.Btnbookticket.Text = "Book Ticket";
            this.Btnbookticket.UseVisualStyleBackColor = true;
            this.Btnbookticket.Click += new System.EventHandler(this.Btnbookticket_Click);
            // 
            // Btnclerklogout
            // 
            this.Btnclerklogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclerklogout.Location = new System.Drawing.Point(375, 258);
            this.Btnclerklogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnclerklogout.Name = "Btnclerklogout";
            this.Btnclerklogout.Size = new System.Drawing.Size(152, 91);
            this.Btnclerklogout.TabIndex = 1;
            this.Btnclerklogout.Text = "Logout";
            this.Btnclerklogout.UseVisualStyleBackColor = true;
            this.Btnclerklogout.Click += new System.EventHandler(this.Btnclerklogout_Click);
            // 
            // Btnviewbooking
            // 
            this.Btnviewbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewbooking.Location = new System.Drawing.Point(595, 95);
            this.Btnviewbooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnviewbooking.Name = "Btnviewbooking";
            this.Btnviewbooking.Size = new System.Drawing.Size(152, 91);
            this.Btnviewbooking.TabIndex = 2;
            this.Btnviewbooking.Text = "View Booking";
            this.Btnviewbooking.UseVisualStyleBackColor = true;
            this.Btnviewbooking.Click += new System.EventHandler(this.Btnviewbooking_Click);
            // 
            // Btnaddpassenger
            // 
            this.Btnaddpassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddpassenger.Location = new System.Drawing.Point(362, 95);
            this.Btnaddpassenger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnaddpassenger.Name = "Btnaddpassenger";
            this.Btnaddpassenger.Size = new System.Drawing.Size(176, 91);
            this.Btnaddpassenger.TabIndex = 3;
            this.Btnaddpassenger.Text = "Add Passenger";
            this.Btnaddpassenger.UseVisualStyleBackColor = true;
            this.Btnaddpassenger.Click += new System.EventHandler(this.Btnaddpassenger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clerk Menu";
            // 
            // ClerkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnaddpassenger);
            this.Controls.Add(this.Btnviewbooking);
            this.Controls.Add(this.Btnclerklogout);
            this.Controls.Add(this.Btnbookticket);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClerkMenu";
            this.Text = "Clerk Menu";
            this.Controls.SetChildIndex(this.Btnbookticket, 0);
            this.Controls.SetChildIndex(this.Btnclerklogout, 0);
            this.Controls.SetChildIndex(this.Btnviewbooking, 0);
            this.Controls.SetChildIndex(this.Btnaddpassenger, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnbookticket;
        private System.Windows.Forms.Button Btnclerklogout;
        private System.Windows.Forms.Button Btnviewbooking;
        private System.Windows.Forms.Button Btnaddpassenger;
        private System.Windows.Forms.Label label1;
    }
}