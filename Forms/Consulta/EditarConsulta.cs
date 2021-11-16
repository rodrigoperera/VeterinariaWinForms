using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterianriaWinForms.Forms.Consulta
{
    public partial class EditarConsulta : Form
    {
        int numero;

        public EditarConsulta(int numero)
        {
            InitializeComponent();
            this.numero = numero;
            PreCargarForm(numero);
        }

        private void PreCargarForm(long cedula)
        {
            /*
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta voconsulta = ws.ObtenerConsulta(numero);
            
            lblNumConsultaValor.Text = voconsulta.Numero.ToString();
            comboBoxVeterinario.DataSource = voconsulta.Veterinario;
            comboBoxMascota.DataSource = voconsulta.Mascota;
            textBoxDetalle.Text = voconsulta.Descripcion;
            textBoxDetalle.Focus();
            */
            
        }
    }
}
