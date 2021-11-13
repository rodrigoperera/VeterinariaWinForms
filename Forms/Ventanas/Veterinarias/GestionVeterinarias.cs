using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterianriaWinForms.Forms.Ventanas.Veterinarias
{
    public partial class GestionVeterinarias : Form
    {
        public GestionVeterinarias()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVeterinaria FrmNuevaVeterinaria;
            FrmNuevaVeterinaria = new NuevaVeterinaria();
            FrmNuevaVeterinaria.Owner = this;
            FrmNuevaVeterinaria.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarVeterinaria FrmEditarVeterinaria;
            FrmEditarVeterinaria = new EditarVeterinaria();
            FrmEditarVeterinaria.Owner = this;
            FrmEditarVeterinaria.ShowDialog();
        }
    }
}
