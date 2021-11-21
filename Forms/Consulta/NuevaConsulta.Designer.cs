
namespace VeterianriaWinForms.Forms.Consulta
{
    partial class NuevaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaConsulta));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.checkBoxRealizada = new System.Windows.Forms.CheckBox();
            this.lblRealizada = new System.Windows.Forms.Label();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(296, 598);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 29);
            this.btnConfirmar.TabIndex = 65;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(143, 598);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 29);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Los campos indicados con * son obligatorios";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(206, 502);
            this.textBoxImporte.MaxLength = 9;
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(182, 26);
            this.textBoxImporte.TabIndex = 62;
            this.textBoxImporte.Text = "0";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(22, 505);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(56, 20);
            this.lblCosto.TabIndex = 61;
            this.lblCosto.Text = "Costo";
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.Location = new System.Drawing.Point(206, 457);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRealizada.TabIndex = 60;
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // lblRealizada
            // 
            this.lblRealizada.AutoSize = true;
            this.lblRealizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizada.Location = new System.Drawing.Point(22, 463);
            this.lblRealizada.Name = "lblRealizada";
            this.lblRealizada.Size = new System.Drawing.Size(133, 20);
            this.lblRealizada.TabIndex = 59;
            this.lblRealizada.Text = "¿Realizada? (*)";
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(206, 183);
            this.textBoxDetalle.Multiline = true;
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(343, 255);
            this.textBoxDetalle.TabIndex = 58;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMascota.FormattingEnabled = true;
            this.comboBoxMascota.Location = new System.Drawing.Point(206, 137);
            this.comboBoxMascota.Name = "comboBoxMascota";
            this.comboBoxMascota.Size = new System.Drawing.Size(343, 28);
            this.comboBoxMascota.TabIndex = 57;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(206, 97);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(343, 28);
            this.comboBoxVeterinario.TabIndex = 56;
            // 
            // DTFecha
            // 
            this.DTFecha.CustomFormat = "dd/MM/yyyy |  HH:mm";
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFecha.Location = new System.Drawing.Point(206, 58);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(224, 26);
            this.DTFecha.TabIndex = 55;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(22, 183);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(90, 20);
            this.lblDetalle.TabIndex = 54;
            this.lblDetalle.Text = "Detalle (*)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(22, 58);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 20);
            this.lblFecha.TabIndex = 53;
            this.lblFecha.Text = "Fecha (*)";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(22, 137);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(101, 20);
            this.lblMascota.TabIndex = 52;
            this.lblMascota.Text = "Mascota (*)";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinario.Location = new System.Drawing.Point(22, 97);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(121, 20);
            this.lblVeterinario.TabIndex = 51;
            this.lblVeterinario.Text = "Veterinario (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Nueva consulta";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 665);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.checkBoxRealizada);
            this.Controls.Add(this.lblRealizada);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblVeterinario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.CheckBox checkBoxRealizada;
        private System.Windows.Forms.Label lblRealizada;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}