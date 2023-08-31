namespace HotelManagement.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomProessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blaBlaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestProcessToolStripMenuItem,
            this.roomProessToolStripMenuItem,
            this.reservationProcessToolStripMenuItem,
            this.employeeProcessToolStripMenuItem,
            this.paymentProcessToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // guestProcessToolStripMenuItem
            // 
            this.guestProcessToolStripMenuItem.Name = "guestProcessToolStripMenuItem";
            this.guestProcessToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.guestProcessToolStripMenuItem.Text = "Guest Process";
            this.guestProcessToolStripMenuItem.Click += new System.EventHandler(this.guestProcessToolStripMenuItem_Click);
            // 
            // roomProessToolStripMenuItem
            // 
            this.roomProessToolStripMenuItem.Name = "roomProessToolStripMenuItem";
            this.roomProessToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.roomProessToolStripMenuItem.Text = "Room Proess";
            this.roomProessToolStripMenuItem.Click += new System.EventHandler(this.roomProessToolStripMenuItem_Click);
            // 
            // reservationProcessToolStripMenuItem
            // 
            this.reservationProcessToolStripMenuItem.Name = "reservationProcessToolStripMenuItem";
            this.reservationProcessToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.reservationProcessToolStripMenuItem.Text = "Reservation Process";
            this.reservationProcessToolStripMenuItem.Click += new System.EventHandler(this.reservationProcessToolStripMenuItem_Click);
            // 
            // employeeProcessToolStripMenuItem
            // 
            this.employeeProcessToolStripMenuItem.Name = "employeeProcessToolStripMenuItem";
            this.employeeProcessToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.employeeProcessToolStripMenuItem.Text = "Employee Process";
            this.employeeProcessToolStripMenuItem.Click += new System.EventHandler(this.employeeProcessToolStripMenuItem_Click);
            // 
            // paymentProcessToolStripMenuItem
            // 
            this.paymentProcessToolStripMenuItem.Name = "paymentProcessToolStripMenuItem";
            this.paymentProcessToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.paymentProcessToolStripMenuItem.Text = "Payment Process";
            this.paymentProcessToolStripMenuItem.Click += new System.EventHandler(this.paymentProcessToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaBlaaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // blaBlaaToolStripMenuItem
            // 
            this.blaBlaaToolStripMenuItem.Name = "blaBlaaToolStripMenuItem";
            this.blaBlaaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.blaBlaaToolStripMenuItem.Text = "bla blaa.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomProessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blaBlaaToolStripMenuItem;
    }
}