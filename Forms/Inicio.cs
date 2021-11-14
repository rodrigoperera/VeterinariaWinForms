using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Clases;

namespace VeterianriaWinForms.Forms
{
    public partial class Inicio : Form
    {
        private string Nombre;
        public Inicio()
        {
            InitializeComponent();
            this.Text = String.Format("Sistem de gestion para la veterinaria {0}", Global.NombreVeterinaria);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            DigiClockTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void trabajarConVeterinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVeterinarios FrmGestionVeterinarios;
            FrmGestionVeterinarios = new GestionVeterinarios();
            FrmGestionVeterinarios.Owner = this;
            FrmGestionVeterinarios.ShowDialog();
        }

        private void trabajarConClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionClientes FrmGestionClientes;
            FrmGestionClientes = new GestionClientes();
            FrmGestionClientes.Owner = this;
            FrmGestionClientes.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigiClockTextBox.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
