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
        private int IdVeterinaria;
        public Main()
        {
            InitializeComponent();
            CargarLista();

        }
       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Global.IdVeterinaria = Convert.ToInt32(comboBox.SelectedValue);
            Global.NombreVeterinaria = "FALTA OBTENERLO DE LA BASE";
            Inicio FrmInicio;
            FrmInicio = new Inicio();
            this.Hide();
            FrmInicio.Closed += (s, args) => this.Close();
            FrmInicio.Show();
        }


        private void CargarLista()
        {

            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria[] lista; // new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[]();

            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerVeterinarias();
            comboBox.DataSource = lista;
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";

        }
    }
}
