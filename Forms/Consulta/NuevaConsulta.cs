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

namespace VeterianriaWinForms.Forms.Consulta
{
    public partial class NuevaConsulta : Form
    {
        long cedula;
        public NuevaConsulta(long cedulaCliente)
        {
            InitializeComponent();
            this.cedula = cedulaCliente;
            CargarComboVeterinaria();
            CargarComboMascotas();

        }

        private void CargarComboVeterinaria() {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            comboBoxVeterinario.DataSource = ws.ObtenerVeterinarios(Global.IdVeterinaria);
            comboBoxVeterinario.DisplayMember = "nombre";//String.Format("{0}({1})", voconsulta.Veterinario.Cedula, voconsulta.Veterinario.Nombre);
            comboBoxVeterinario.ValueMember = "cedula";
        }

        private void CargarComboMascotas()
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            comboBoxMascota.DataSource = ws.ObtenerMascotas(this.cedula);
            comboBoxMascota.DisplayMember = "nombre";//String.Format("{0}:{1}-{2}", voconsulta.Mascota.Id, voconsulta.Mascota.Animal, voconsulta.Mascota.Raza);
            comboBoxMascota.ValueMember = "id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    VeterianriaWinForms.GestionVeterinarioServices.VOConsulta voconsulta = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.CrearConsulta(voconsulta);
                    MessageBox.Show("Consulta creada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            bool exito = false;
            exito = ValidarDetalle();
            return exito;
        }

        private bool ValidarDetalle()
        {
            bool bStatus = true;
            if (textBoxDetalle.Text == "")
            {
                errorProvider1.SetError(textBoxDetalle, "Por favor ingrese la descripcion de la consulta");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxDetalle, "");
            return bStatus;
        }



        private VeterianriaWinForms.GestionVeterinarioServices.VOConsulta CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta voconsulta = new VeterianriaWinForms.GestionVeterinarioServices.VOConsulta();
            voconsulta.Fecha = DTFecha.Value;
            voconsulta.Veterinario = (GestionVeterinarioServices.VOVeterinario)comboBoxVeterinario.SelectedItem;
            voconsulta.Mascota = (GestionVeterinarioServices.VOMascota)comboBoxMascota.SelectedItem;
            voconsulta.Descripcion = textBoxDetalle.Text;
            voconsulta.Realizada = checkBoxRealizada.Checked;
            voconsulta.Importe = Convert.ToDouble(textBoxImporte.Text);
            return voconsulta;
        }
    }
}
