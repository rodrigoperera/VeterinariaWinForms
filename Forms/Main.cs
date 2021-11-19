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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CargarLista();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Global.IdVeterinaria = Convert.ToInt32(comboBox.SelectedValue);
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                Global.NombreVeterinaria = ws.ObtenerVeterinaria(Global.IdVeterinaria).Nombre;
                Inicio FrmInicio;
                FrmInicio = new Inicio();
                this.Hide();
                FrmInicio.Closed += (s, args) => this.Close();
                FrmInicio.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al conectarse al servidor. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLista()
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria[] lista; // new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[]();
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                lista = ws.ObtenerVeterinarias();
                comboBox.DataSource = lista;
                comboBox.DisplayMember = "Nombre";
                comboBox.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al conectarse al servidor. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConfiguraciones.Enabled = false;
                comboBox.Enabled = false;
                btnIngresar.Enabled = false;
            }
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            GestionVeterinarias FrmGestionVeterinarias;
            FrmGestionVeterinarias = new GestionVeterinarias();
            FrmGestionVeterinarias.Owner = this;
            this.Hide();
            FrmGestionVeterinarias.ShowDialog();
            btnIngresar.Enabled = false;
            CargarLista();
            this.Show();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedValue == null)
                btnIngresar.Enabled = false;
            else
                btnIngresar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
