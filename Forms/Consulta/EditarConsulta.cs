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
    public partial class EditarConsulta : Form
    {
        int numero;

        public EditarConsulta(int numero)
        {
            InitializeComponent();
            this.numero = numero;
            PreCargarForm(numero);
        }

        private void PreCargarForm(int numero)
        {
            try
            {
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                VeterianriaWinForms.GestionVeterinarioServices.VOConsulta voconsulta = ws.ObtenerConsulta(numero);
                lblNumConsultaValor.Text = voconsulta.Numero.ToString();

                DTFecha.Value = voconsulta.Fecha;
                comboBoxVeterinario.DataSource = ws.ObtenerVeterinarios(Global.IdVeterinaria);
                comboBoxVeterinario.DisplayMember = "nombre";//String.Format("{0}({1})", voconsulta.Veterinario.Cedula, voconsulta.Veterinario.Nombre);
                comboBoxVeterinario.ValueMember = "cedula";

                comboBoxVeterinario.SelectedIndex = comboBoxVeterinario.FindStringExact(voconsulta.Veterinario.Nombre.ToString());

                comboBoxMascota.DataSource = ws.ObtenerMascotas(voconsulta.Mascota.cedulaCliente);
                comboBoxMascota.DisplayMember = "nombre";//String.Format("{0}:{1}-{2}", voconsulta.Mascota.Id, voconsulta.Mascota.Animal, voconsulta.Mascota.Raza);
                comboBoxMascota.ValueMember = "id";

                textBoxDetalle.Text = voconsulta.Descripcion;
                textBoxDetalle.Focus();

                checkBoxRealizada.Checked = voconsulta.Realizada;
                textBoxImporte.Text = voconsulta.Importe.ToString();
            }
            catch
            {
                MessageBox.Show("Hubo un error al obtener los datos de la consulta. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    ws.EditarConsulta(voconsulta);
                    MessageBox.Show("Consulta editada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al intentar guardar los datos de la consulta. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            return ValidarDetalle(); ;
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
            voconsulta.Numero = Convert.ToInt32(lblNumConsultaValor.Text);
            voconsulta.Fecha = DTFecha.Value;
            voconsulta.Veterinario = (GestionVeterinarioServices.VOVeterinario)comboBoxVeterinario.SelectedItem;
            voconsulta.Mascota= (GestionVeterinarioServices.VOMascota)comboBoxMascota.SelectedItem;
            voconsulta.Descripcion = textBoxDetalle.Text;
            voconsulta.Realizada = checkBoxRealizada.Checked;
            voconsulta.Importe = Convert.ToDouble(textBoxImporte.Text);
            return voconsulta;
        }
    }
}
