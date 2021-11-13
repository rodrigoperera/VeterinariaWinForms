using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Forms.Ventanas.Mascotas;

namespace VeterianriaWinForms.Forms.Ventanas.Clientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionMascotas FrmGestionMascotas;
            FrmGestionMascotas = new GestionMascotas();
            FrmGestionMascotas.Owner = this;
            FrmGestionMascotas.ShowDialog();
        }
    }
}
