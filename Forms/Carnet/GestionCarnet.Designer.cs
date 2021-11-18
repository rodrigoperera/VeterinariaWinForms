
namespace VeterianriaWinForms.Forms
{
    partial class GestionCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCarnet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelvalorraza = new System.Windows.Forms.Label();
            this.labelvaloredad = new System.Windows.Forms.Label();
            this.labelvalordueno = new System.Windows.Forms.Label();
            this.labelvalorvacunado = new System.Windows.Forms.Label();
            this.labelvacunado = new System.Windows.Forms.Label();
            this.labeldueno = new System.Windows.Forms.Label();
            this.labeledad = new System.Windows.Forms.Label();
            this.labelraza = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(223, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(249, 25);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE DE MASCOTA";
            // 
            // labelvalorraza
            // 
            this.labelvalorraza.AutoSize = true;
            this.labelvalorraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorraza.Location = new System.Drawing.Point(292, 59);
            this.labelvalorraza.Name = "labelvalorraza";
            this.labelvalorraza.Size = new System.Drawing.Size(16, 16);
            this.labelvalorraza.TabIndex = 2;
            this.labelvalorraza.Text = "X";
            // 
            // labelvaloredad
            // 
            this.labelvaloredad.AutoSize = true;
            this.labelvaloredad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvaloredad.Location = new System.Drawing.Point(292, 94);
            this.labelvaloredad.Name = "labelvaloredad";
            this.labelvaloredad.Size = new System.Drawing.Size(16, 16);
            this.labelvaloredad.TabIndex = 3;
            this.labelvaloredad.Text = "X";
            // 
            // labelvalordueno
            // 
            this.labelvalordueno.AutoSize = true;
            this.labelvalordueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalordueno.Location = new System.Drawing.Point(302, 128);
            this.labelvalordueno.Name = "labelvalordueno";
            this.labelvalordueno.Size = new System.Drawing.Size(16, 16);
            this.labelvalordueno.TabIndex = 4;
            this.labelvalordueno.Text = "X";
            // 
            // labelvalorvacunado
            // 
            this.labelvalorvacunado.AutoSize = true;
            this.labelvalorvacunado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorvacunado.Location = new System.Drawing.Point(327, 165);
            this.labelvalorvacunado.Name = "labelvalorvacunado";
            this.labelvalorvacunado.Size = new System.Drawing.Size(16, 16);
            this.labelvalorvacunado.TabIndex = 5;
            this.labelvalorvacunado.Text = "X";
            // 
            // labelvacunado
            // 
            this.labelvacunado.AutoSize = true;
            this.labelvacunado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvacunado.Location = new System.Drawing.Point(233, 162);
            this.labelvacunado.Name = "labelvacunado";
            this.labelvacunado.Size = new System.Drawing.Size(95, 20);
            this.labelvacunado.TabIndex = 9;
            this.labelvacunado.Text = "Vacunado:";
            // 
            // labeldueno
            // 
            this.labeldueno.AutoSize = true;
            this.labeldueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldueno.Location = new System.Drawing.Point(233, 125);
            this.labeldueno.Name = "labeldueno";
            this.labeldueno.Size = new System.Drawing.Size(67, 20);
            this.labeldueno.TabIndex = 8;
            this.labeldueno.Text = "Dueño:";
            // 
            // labeledad
            // 
            this.labeledad.AutoSize = true;
            this.labeledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledad.Location = new System.Drawing.Point(233, 91);
            this.labeledad.Name = "labeledad";
            this.labeledad.Size = new System.Drawing.Size(56, 20);
            this.labeledad.TabIndex = 7;
            this.labeledad.Text = "Edad:";
            // 
            // labelraza
            // 
            this.labelraza.AutoSize = true;
            this.labelraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelraza.Location = new System.Drawing.Point(233, 56);
            this.labelraza.Name = "labelraza";
            this.labelraza.Size = new System.Drawing.Size(56, 20);
            this.labelraza.TabIndex = 6;
            this.labelraza.Text = "Raza:";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(400, 201);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(101, 26);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // GestionCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 239);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.labelvacunado);
            this.Controls.Add(this.labeldueno);
            this.Controls.Add(this.labeledad);
            this.Controls.Add(this.labelraza);
            this.Controls.Add(this.labelvalorvacunado);
            this.Controls.Add(this.labelvalordueno);
            this.Controls.Add(this.labelvaloredad);
            this.Controls.Add(this.labelvalorraza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet de Mascota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelvalorraza;
        private System.Windows.Forms.Label labelvaloredad;
        private System.Windows.Forms.Label labelvalordueno;
        private System.Windows.Forms.Label labelvalorvacunado;
        private System.Windows.Forms.Label labelvacunado;
        private System.Windows.Forms.Label labeldueno;
        private System.Windows.Forms.Label labeledad;
        private System.Windows.Forms.Label labelraza;
        private System.Windows.Forms.Button BtnModificar;
    }
}