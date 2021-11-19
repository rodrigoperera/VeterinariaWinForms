
namespace VeterianriaWinForms.Forms
{
    partial class EditarVeterinaria
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
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValor.ForeColor = System.Drawing.Color.DimGray;
            this.lblIdValor.Location = new System.Drawing.Point(133, 60);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(20, 17);
            this.lblIdValor.TabIndex = 40;
            this.lblIdValor.Text = "...";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(23, 56);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(25, 20);
            this.lblCedula.TabIndex = 39;
            this.lblCedula.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Editar veterinaria";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(138, 178);
            this.textBoxDireccion.MaxLength = 30;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(261, 26);
            this.textBoxDireccion.TabIndex = 47;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(23, 181);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 20);
            this.lblDireccion.TabIndex = 46;
            this.lblDireccion.Text = "Direccion";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(138, 136);
            this.textBoxTelefono.MaxLength = 9;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(261, 26);
            this.textBoxTelefono.TabIndex = 45;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(138, 92);
            this.textBoxNombre.MaxLength = 30;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(261, 26);
            this.textBoxNombre.TabIndex = 44;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(23, 136);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(103, 20);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Telefono (*)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 20);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(226, 260);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(162, 29);
            this.btnConfirmar.TabIndex = 49;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(55, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 29);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Los campos indicados con * son obligatorios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditarVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(196)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(443, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdValor);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarVeterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Veterinaria";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}