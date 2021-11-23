
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarConsulta));
            this.lblNumConsulta = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMascotaId = new System.Windows.Forms.TextBox();
            this.textBoxMascota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumConsulta
            // 
            this.lblNumConsulta.AutoSize = true;
            this.lblNumConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConsulta.Location = new System.Drawing.Point(15, 63);
            this.lblNumConsulta.Name = "lblNumConsulta";
            this.lblNumConsulta.Size = new System.Drawing.Size(204, 25);
            this.lblNumConsulta.TabIndex = 0;
            this.lblNumConsulta.Text = "Número de consulta";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinario.Location = new System.Drawing.Point(15, 143);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(148, 25);
            this.lblVeterinario.TabIndex = 1;
            this.lblVeterinario.Text = "Veterinario (*)";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(15, 181);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(125, 25);
            this.lblMascota.TabIndex = 2;
            this.lblMascota.Text = "Mascota (*)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 25);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha (*)";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(15, 229);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(110, 25);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle (*)";
            // 
            // DTFecha
            // 
            this.DTFecha.CustomFormat = "dd/MM/yyyy |  HH:mm";
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFecha.Location = new System.Drawing.Point(198, 103);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(224, 30);
            this.DTFecha.TabIndex = 5;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(198, 143);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(343, 33);
            this.comboBoxVeterinario.TabIndex = 6;
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(198, 229);
            this.textBoxDetalle.Multiline = true;
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(343, 255);
            this.textBoxDetalle.TabIndex = 8;
            // 
            // lblNumConsultaValor
            // 
            this.lblNumConsultaValor.AutoSize = true;
            this.lblNumConsultaValor.Location = new System.Drawing.Point(198, 63);
            this.lblNumConsultaValor.Name = "lblNumConsultaValor";
            this.lblNumConsultaValor.Size = new System.Drawing.Size(64, 25);
            this.lblNumConsultaValor.TabIndex = 9;
            this.lblNumConsultaValor.Text = "label1";
            // 
            // lblRealizada
            // 
            this.lblRealizada.AutoSize = true;
            this.lblRealizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizada.Location = new System.Drawing.Point(15, 509);
            this.lblRealizada.Name = "lblRealizada";
            this.lblRealizada.Size = new System.Drawing.Size(163, 25);
            this.lblRealizada.TabIndex = 10;
            this.lblRealizada.Text = "¿Realizada? (*)";
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.Location = new System.Drawing.Point(198, 503);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRealizada.TabIndex = 11;
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(15, 549);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(69, 25);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(198, 546);
            this.textBoxImporte.MaxLength = 9;
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(182, 30);
            this.textBoxImporte.TabIndex = 13;
            this.textBoxImporte.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(278, 643);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 29);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(123, 643);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 29);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Los campos indicados con * son obligatorios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Editar consulta";
            // 
            // textBoxMascotaId
            // 
            this.textBoxMascotaId.Location = new System.Drawing.Point(198, 182);
            this.textBoxMascotaId.Name = "textBoxMascotaId";
            this.textBoxMascotaId.Size = new System.Drawing.Size(36, 30);
            this.textBoxMascotaId.TabIndex = 68;
            // 
            // textBoxMascota
            // 
            this.textBoxMascota.Location = new System.Drawing.Point(240, 182);
            this.textBoxMascota.Name = "textBoxMascota";
            this.textBoxMascota.Size = new System.Drawing.Size(301, 30);
            this.textBoxMascota.TabIndex = 69;
            // 
            // EditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 685);
            this.Controls.Add(this.textBoxMascota);
            this.Controls.Add(this.textBoxMascotaId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.checkBoxRealizada);
            this.Controls.Add(this.lblRealizada);
            this.Controls.Add(this.lblNumConsultaValor);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblVeterinario);
            this.Controls.Add(this.lblNumConsulta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMascota;
        private System.Windows.Forms.TextBox textBoxMascotaId;
    }
}