using System;
using System.Windows.Forms;
using VeterianriaWinForms.Forms.Ventanas.Clientes;

namespace VeterianriaWinForms.Forms.Ventanas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionVeterinaria FrmGestionVeterinarios;
            FrmGestionVeterinarios = new GestionVeterinaria();
            FrmGestionVeterinarios.Owner = this;
            FrmGestionVeterinarios.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes FrmGestionClientes;
            FrmGestionClientes = new GestionClientes();
            FrmGestionClientes.Owner = this;
            FrmGestionClientes.ShowDialog();
        }
    }
}
