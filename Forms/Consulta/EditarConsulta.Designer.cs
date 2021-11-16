
namespace VeterianriaWinForms.Forms.Consulta
{
    partial class EditarConsulta
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
            this.lblNumConsulta = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.lblNumConsultaValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumConsulta
            // 
            this.lblNumConsulta.AutoSize = true;
            this.lblNumConsulta.Location = new System.Drawing.Point(13, 13);
            this.lblNumConsulta.Name = "lblNumConsulta";
            this.lblNumConsulta.Size = new System.Drawing.Size(135, 17);
            this.lblNumConsulta.TabIndex = 0;
            this.lblNumConsulta.Text = "Número de consulta";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(16, 77);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(77, 17);
            this.lblVeterinario.TabIndex = 1;
            this.lblVeterinario.Text = "Veterinario";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(16, 108);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(61, 17);
            this.lblMascota.TabIndex = 2;
            this.lblMascota.Text = "Mascota";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(19, 146);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(52, 17);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(176, 77);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(305, 24);
            this.comboBoxVeterinario.TabIndex = 6;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.FormattingEnabled = true;
            this.comboBoxMascota.Location = new System.Drawing.Point(176, 108);
            this.comboBoxMascota.Name = "comboBoxMascota";
            this.comboBoxMascota.Size = new System.Drawing.Size(305, 24);
            this.comboBoxMascota.TabIndex = 7;
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(176, 146);
            this.textBoxDetalle.Multiline = true;
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(305, 205);
            this.textBoxDetalle.TabIndex = 8;
            // 
            // lblNumConsultaValor
            // 
            this.lblNumConsultaValor.AutoSize = true;
            this.lblNumConsultaValor.Location = new System.Drawing.Point(176, 13);
            this.lblNumConsultaValor.Name = "lblNumConsultaValor";
            this.lblNumConsultaValor.Size = new System.Drawing.Size(46, 17);
            this.lblNumConsultaValor.TabIndex = 9;
            this.lblNumConsultaValor.Text = "label1";
            // 
            // EditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 392);
            this.Controls.Add(this.lblNumConsultaValor);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblVeterinario);
            this.Controls.Add(this.lblNumConsulta);
            this.Name = "EditarConsulta";
            this.Text = "Editar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumConsulta;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.Label lblNumConsultaValor;
    }
}