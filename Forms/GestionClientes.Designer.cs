
namespace VeterianriaWinForms.Forms
{
    partial class GestionClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnListadoMascotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de clientes registrados";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cedula,
            this.Nombre,
            this.Telefono,
            this.Direccion,
            this.Correo,
            this.Activo});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(13, 39);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 237);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 192;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 146;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 119;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 186;
            // 
            // Correo
            // 
            this.Correo.Text = "Correo";
            this.Correo.Width = 232;
            // 
            // Activo
            // 
            this.Activo.Text = "Activo?";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 292);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(154, 292);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(56, 19);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(82, 292);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(56, 19);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnListadoMascotas
            // 
            this.btnListadoMascotas.Location = new System.Drawing.Point(720, 289);
            this.btnListadoMascotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListadoMascotas.Name = "btnListadoMascotas";
            this.btnListadoMascotas.Size = new System.Drawing.Size(147, 19);
            this.btnListadoMascotas.TabIndex = 16;
            this.btnListadoMascotas.Text = "Listado de Mascotas";
            this.btnListadoMascotas.UseVisualStyleBackColor = true;
            this.btnListadoMascotas.Click += new System.EventHandler(this.btnListadoMascotas_Click);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 318);
            this.Controls.Add(this.btnListadoMascotas);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de clientes del sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cedula;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Activo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button btnListadoMascotas;
    }
}