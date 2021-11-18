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
    public partial class EditarVeterinaria : Form
    {
        private int id;
        public EditarVeterinaria(int id)
        {
            InitializeComponent();
            this.id = id;
            PreCargarForm(id);
        }

        private void PreCargarForm(long cedula)
        {
            try
            {
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria voveterinaria = ws.ObtenerVeterinaria(id);
                lblIdValor.Text = voveterinaria.Id.ToString();
                textBoxNombre.Text = voveterinaria.Nombre;
                textBoxTelefono.Text = voveterinaria.Telefono;
                textBoxDireccion.Text = voveterinaria.Direccion;
                textBoxNombre.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al obtener los datos de la veterinaria. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria voveterinaria = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.EditarVeterinaria(voveterinaria);
                    MessageBox.Show("Veterinaria editado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception )
                {
                    MessageBox.Show("Hubo un error al guardar los datos de la veterinaria. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria voveterinaria = new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria();
            voveterinaria.Id = this.id;
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

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxTelefono.Text, "[^0-9]"))
            {
                textBoxTelefono.Text = textBoxTelefono.Text.Remove(textBoxTelefono.Text.Length - 1);
            }
        }
    }
}
