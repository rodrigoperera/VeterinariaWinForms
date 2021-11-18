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
    public partial class NuevoVeterinario : Form
    {

        public NuevoVeterinario()
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
                    VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.CrearVeterinario(voveterinario);
                    MessageBox.Show("Veterinario ingresado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarDatos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al intentar agregar un nuevo veterinario. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BorrarDatos()
        {
            TextBoxCedula.Text = String.Empty;
            textBoxNombre.Text = String.Empty;
            textBoxTelefono.Text = String.Empty;
            textBoxHorario.Text = String.Empty;

        }
        
        private VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario();
            voveterinario.Cedula = Convert.ToInt64(TextBoxCedula.Text);
            voveterinario.Nombre = textBoxNombre.Text;
            voveterinario.Telefono = textBoxTelefono.Text;
            voveterinario.Horario = textBoxHorario.Text;
            voveterinario.IdVeterinaria = Global.IdVeterinaria;
            return voveterinario;
        }

        private bool ValidarDatos()
        {
            bool exito = false;
            if (ValidarCedula() && ValidarNombre() && ValidarTelefono() && ValidarHorario())
                exito = true;
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

        private bool ValidarHorario()
        {
            bool bStatus = true;
            if (textBoxHorario.Text == "")
            {
                errorProvider1.SetError(textBoxHorario, "Por favor ingrese el horario");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxHorario, "");
            return bStatus;
        }

        private void TextBoxCedula_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxCedula.Text, "[^0-9]"))
            {
                TextBoxCedula.Text = TextBoxCedula.Text.Remove(TextBoxCedula.Text.Length - 1);
            }
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
