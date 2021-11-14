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
    public partial class NuevaVeterinaria : Form
    {
        public NuevaVeterinaria()
        {
            InitializeComponent();
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

                    VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria voveterinaria = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.CrearVeterinaria(voveterinaria);
                    MessageBox.Show("Veterinaria creada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarDatos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BorrarDatos()
        {
            textBoxNombre.Text = String.Empty;
            textBoxTelefono.Text = String.Empty;
            textBoxDireccion.Text = String.Empty;

        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria voveterinaria = new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria();
            voveterinaria.Nombre = textBoxNombre.Text;
            voveterinaria.Telefono = textBoxTelefono.Text;
            voveterinaria.Direccion = textBoxDireccion.Text;
            return voveterinaria;

        }

        private bool ValidarDatos()
        {
            bool exito = false;
            exito = ValidarNombre();
            exito = ValidarTelefono();

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
    }
}
