
namespace VeterianriaWinForms.Forms
{
    partial class GestionConsultas
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripción = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(81, 222);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(56, 19);
            this.BtnEditar.TabIndex = 26;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(12, 222);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(56, 19);
            this.btnNueva.TabIndex = 25;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(151, 222);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(56, 19);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblClienteNombre.Location = new System.Drawing.Point(184, 19);
            this.lblClienteNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(61, 15);
            this.lblClienteNombre.TabIndex = 23;
            this.lblClienteNombre.Text = "mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Listado de consultasde la mascota";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Fecha,
            this.Descripción,
            this.Calificación});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(11, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 178);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 103;
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            this.Descripción.Width = 522;
            // 
            // Calificación
            // 
            this.Calificación.Text = "Calificación";
            this.Calificación.Width = 84;
            // 
            // GestionConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 250);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "GestionConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas por MASCORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Descripción;
        private System.Windows.Forms.ColumnHeader Calificación;
    }
}