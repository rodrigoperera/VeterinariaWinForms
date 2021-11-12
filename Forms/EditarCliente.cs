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
    public partial class EditarCliente : Form
    {
        long cedula;
        public EditarCliente(long cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            PreCargarForm(cedula);
        }

        private void PreCargarForm(long cedula)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();


            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = ws.ObtenerCliente(cedula);

            lblCedulaValor.Text = vocliente.Cedula.ToString();
            textBoxNombre.Text = vocliente.Nombre;
            textBoxTelefono.Text = vocliente.Telefono;
            textBoxDireccion.Text = vocliente.Direccion;
            textBoxCorreo.Text = vocliente.Correo;
            checkBoxActivo.Checked = vocliente.Activo;

            textBoxNombre.Focus();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

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

                    VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.EditarCliente(vocliente);
                    MessageBox.Show("Cliente editado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOCliente CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = new VeterianriaWinForms.GestionVeterinarioServices.VOCliente();
            vocliente.Cedula = this.cedula;
            vocliente.Nombre = textBoxNombre.Text;
            vocliente.Telefono = textBoxTelefono.Text;
            vocliente.Direccion = textBoxDireccion.Text;
            vocliente.Correo = textBoxCorreo.Text;
            vocliente.Activo = checkBoxActivo.Checked;
            return vocliente;

        }

        private bool ValidarDatos()
        {
            bool exito = false;
            exito = ValidarNombre();
            exito = ValidarTelefono();
            exito = ValidarDireccion();
            exito = ValidarCorreo();

            return exito;

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
