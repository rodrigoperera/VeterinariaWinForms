
namespace VeterianriaWinForms.Forms
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajarConClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajarConVeterinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DigiClockTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.veterinariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajarConClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // trabajarConClientesToolStripMenuItem
            // 
            this.trabajarConClientesToolStripMenuItem.Name = "trabajarConClientesToolStripMenuItem";
            this.trabajarConClientesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.trabajarConClientesToolStripMenuItem.Text = "Trabajar con clientes";
            this.trabajarConClientesToolStripMenuItem.Click += new System.EventHandler(this.trabajarConClientesToolStripMenuItem_Click);
            // 
            // veterinariosToolStripMenuItem
            // 
            this.veterinariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajarConVeterinariosToolStripMenuItem});
            this.veterinariosToolStripMenuItem.Name = "veterinariosToolStripMenuItem";
            this.veterinariosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.veterinariosToolStripMenuItem.Text = "Veterinarios";
            // 
            // trabajarConVeterinariosToolStripMenuItem
            // 
            this.trabajarConVeterinariosToolStripMenuItem.Name = "trabajarConVeterinariosToolStripMenuItem";
            this.trabajarConVeterinariosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.trabajarConVeterinariosToolStripMenuItem.Text = "Trabajar con veterinarios";
            this.trabajarConVeterinariosToolStripMenuItem.Click += new System.EventHandler(this.trabajarConVeterinariosToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(426, 101);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DigiClockTextBox
            // 
            this.DigiClockTextBox.AutoSize = true;
            this.DigiClockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiClockTextBox.Location = new System.Drawing.Point(603, 59);
            this.DigiClockTextBox.Name = "DigiClockTextBox";
            this.DigiClockTextBox.Size = new System.Drawing.Size(71, 20);
            this.DigiClockTextBox.TabIndex = 3;
            this.DigiClockTextBox.Text = "00:00:00";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.DigiClockTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajarConClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajarConVeterinariosToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DigiClockTextBox;
    }
}