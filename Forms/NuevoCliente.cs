using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterianriaWinForms.Forms
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                try
                {

                    VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.CrearCliente(vocliente);
                    MessageBox.Show("Cliente ingresado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarDatos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void BorrarDatos()
        {
            TextBoxCedula.Text = String.Empty;
            textBoxNombre.Text = String.Empty;
            textBoxTelefono.Text = String.Empty;
            textBoxDireccion.Text = String.Empty;
            textBoxCorreo.Text = String.Empty;

        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOCliente CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = new VeterianriaWinForms.GestionVeterinarioServices.VOCliente();
            vocliente.Cedula = Convert.ToInt64(TextBoxCedula.Text);
            vocliente.Nombre = textBoxNombre.Text;
            vocliente.Telefono = textBoxTelefono.Text;
            vocliente.Direccion = textBoxDireccion.Text;
            vocliente.Correo= textBoxCorreo.Text;
            vocliente.Activo = true;

            return vocliente;

        }

        private bool ValidarDatos()
        {
            bool exito = false;
            exito = ValidarCedula();
            exito = ValidarNombre();
            exito = ValidarTelefono();
            exito = ValidarDireccion();
            exito = ValidarCorreo();

            return exito;

        }

        private bool ValidarCedula()
        {
            bool bStatus = true;
            if (TextBoxCedula.Text == "")
            {
                errorProvider1.SetError(TextBoxCedula, "Por favor ingrese la cedula");
                bStatus = false;
            }
            else
                errorProvider1.SetError(TextBoxCedula, "");
            return bStatus;
        }

        private bool ValidarNombre()
        {
            bool bStatus = true;
            if (textBoxNombre.Text == "")
            {
                errorProvider1.SetError(textBoxNombre, "Por favor ingrese el nombre");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxNombre, "");
            return bStatus;
        }

        private bool ValidarTelefono()
        {
            bool bStatus = true;
            if (textBoxTelefono.Text == "")
            {
                errorProvider1.SetError(textBoxTelefono, "Por favor ingrese el telefono");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxTelefono, "");
            return bStatus;
        }

        private bool ValidarDireccion()
        {
            bool bStatus = true;
            if (textBoxDireccion.Text == "")
            {
                errorProvider1.SetError(textBoxDireccion, "Por favor ingrese la direccion");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxDireccion, "");
            return bStatus;
        }

        private bool ValidarCorreo()
        {
            bool bStatus = true;
            if (textBoxCorreo.Text == "")
            {
                errorProvider1.SetError(textBoxCorreo, "Por favor ingrese el correo");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxCorreo, "");
            return bStatus;
        }


    }
}
