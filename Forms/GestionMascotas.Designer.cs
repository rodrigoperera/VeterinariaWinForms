
namespace VeterianriaWinForms.Forms
{
    partial class GestionMascotas
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Raza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vacunas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnCarnet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Tipo,
            this.Nombre,
            this.Raza,
            this.Edad,
            this.Vacunas,
            this.Expedido});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(10, 30);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 178);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo animal";
            this.Tipo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 130;
            // 
            // Raza
            // 
            this.Raza.Text = "Raza";
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 98;
            // 
            // Vacunas
            // 
            this.Vacunas.Text = "Vacunas al dia?";
            this.Vacunas.Width = 213;
            // 
            // Expedido
            // 
            this.Expedido.Text = "Carnet - Fecha expedido";
            this.Expedido.Width = 212;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de mascotas para el cliente";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblClienteNombre.Location = new System.Drawing.Point(183, 9);
            this.lblClienteNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(50, 15);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "cliente";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(150, 212);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(56, 19);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(80, 212);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(56, 19);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 212);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Location = new System.Drawing.Point(222, 212);
            this.BtnConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(64, 19);
            this.BtnConsultas.TabIndex = 19;
            this.BtnConsultas.Text = "Consultas";
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnCarnet
            // 
            this.BtnCarnet.Location = new System.Drawing.Point(301, 212);
            this.BtnCarnet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCarnet.Name = "BtnCarnet";
            this.BtnCarnet.Size = new System.Drawing.Size(64, 19);
            this.BtnCarnet.TabIndex = 20;
            this.BtnCarnet.Text = "Carnet";
            this.BtnCarnet.UseVisualStyleBackColor = true;
            this.BtnCarnet.Click += new System.EventHandler(this.BtnCarnet_Click);
            // 
            // GestionMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 237);
            this.Controls.Add(this.BtnCarnet);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionMascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de mascostas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Raza;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.ColumnHeader Vacunas;
        private System.Windows.Forms.ColumnHeader Expedido;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnCarnet;
    }
}