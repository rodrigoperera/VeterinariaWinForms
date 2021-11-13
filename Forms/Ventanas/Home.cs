using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Forms.Ventanas;
using VeterianriaWinForms.Forms.Ventanas.Veterinarias;

namespace VeterianriaWinForms.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal FrmMenuPrincipal = new MenuPrincipal();
            FrmMenuPrincipal.Closed += (s, args) => this.Close();
            FrmMenuPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionVeterinarias FrmGestionVeterinarias;
            FrmGestionVeterinarias = new GestionVeterinarias();
            FrmGestionVeterinarias.Owner = this;
            FrmGestionVeterinarias.ShowDialog();
        }
    }
}
