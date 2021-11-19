
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
            this.components = new System.ComponentModel.Container();
            this.lblNumConsulta = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.lblNumConsultaValor = new System.Windows.Forms.Label();
            this.lblRealizada = new System.Windows.Forms.Label();
            this.checkBoxRealizada = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.lblVeterinario.Location = new System.Drawing.Point(13, 77);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(96, 17);
            this.lblVeterinario.TabIndex = 1;
            this.lblVeterinario.Text = "Veterinario (*)";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(13, 108);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(80, 17);
            this.lblMascota.TabIndex = 2;
            this.lblMascota.Text = "Mascota (*)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha (*)";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(13, 146);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(71, 17);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle (*)";
            // 
            // DTFecha
            // 
            this.DTFecha.CustomFormat = "dd/MM/yyyy |  HH:mm";
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFecha.Location = new System.Drawing.Point(176, 46);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(200, 22);
            this.DTFecha.TabIndex = 5;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(176, 77);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(305, 24);
            this.comboBoxVeterinario.TabIndex = 6;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lblRealizada
            // 
            this.lblRealizada.AutoSize = true;
            this.lblRealizada.Location = new System.Drawing.Point(13, 370);
            this.lblRealizada.Name = "lblRealizada";
            this.lblRealizada.Size = new System.Drawing.Size(106, 17);
            this.lblRealizada.TabIndex = 10;
            this.lblRealizada.Text = "¿Realizada? (*)";
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.Location = new System.Drawing.Point(176, 365);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRealizada.TabIndex = 11;
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(13, 403);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 17);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(176, 400);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(163, 22);
            this.textBoxImporte.TabIndex = 13;
            this.textBoxImporte.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.Color.Olive;
            this.btnConfirmar.Location = new System.Drawing.Point(247, 478);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 23);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(110, 478);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Los campos indicados con * son obligatorios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 535);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.checkBoxRealizada);
            this.Controls.Add(this.lblRealizada);
            this.Controls.Add(this.lblNumConsultaValor);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblVeterinario);
            this.Controls.Add(this.lblNumConsulta);
            this.Name = "EditarConsulta";
            this.Text = "Editar Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumConsulta;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.Label lblNumConsultaValor;
        private System.Windows.Forms.Label lblRealizada;
        private System.Windows.Forms.CheckBox checkBoxRealizada;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}