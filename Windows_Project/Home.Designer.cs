
namespace Windows_Project
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.academicDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.staffDetailsToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.eToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // staffDetailsToolStripMenuItem
            // 
            this.staffDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem1,
            this.academicDetailsToolStripMenuItem1});
            this.staffDetailsToolStripMenuItem.Name = "staffDetailsToolStripMenuItem";
            this.staffDetailsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.staffDetailsToolStripMenuItem.Text = "Staff Details";
            // 
            // personalDetailsToolStripMenuItem1
            // 
            this.personalDetailsToolStripMenuItem1.Name = "personalDetailsToolStripMenuItem1";
            this.personalDetailsToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.personalDetailsToolStripMenuItem1.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem1.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem1_Click);
            // 
            // academicDetailsToolStripMenuItem1
            // 
            this.academicDetailsToolStripMenuItem1.Name = "academicDetailsToolStripMenuItem1";
            this.academicDetailsToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.academicDetailsToolStripMenuItem1.Text = "Salary Details";
            this.academicDetailsToolStripMenuItem1.Click += new System.EventHandler(this.academicDetailsToolStripMenuItem1_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem,
            this.marksToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marksToolStripMenuItem.Text = "Marks";
            this.marksToolStripMenuItem.Click += new System.EventHandler(this.marksToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exitToolStripMenuItem.Text = "Extra Caricular ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.eToolStripMenuItem.Text = "Exit";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(300, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chennai-600 070";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(280, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kamarajapuram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(152, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = " Sacred Heart Matric Hr.Sec.School";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem academicDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}