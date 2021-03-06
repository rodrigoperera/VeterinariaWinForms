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
    public partial class EditarVeterinario : Form
    {
        long cedula;
        public EditarVeterinario(long cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            PreCargarForm(cedula);
        }

        private void PreCargarForm(long cedula)
        {
            try
            {
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = ws.ObtenerVeterinario(cedula);
                lblCedulaValor.Text = voveterinario.Cedula.ToString();
                textBoxNombre.Text = voveterinario.Nombre;
                textBoxTelefono.Text = voveterinario.Telefono;
                textBoxHorario.Text = voveterinario.Horario;
                textBoxNombre.Focus();
            }             
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al obtener los datos del veterinario. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = CrearVO();
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                ws.EditarVeterinario(voveterinario);
                MessageBox.Show("Veterinario editado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar editar un veterinario. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario();
            voveterinario.Cedula = this.cedula;
            voveterinario.Nombre = textBoxNombre.Text;
            voveterinario.Telefono = textBoxTelefono.Text;
            voveterinario.Horario = textBoxHorario.Text;
            voveterinario.IdVeterinaria = Global.IdVeterinaria;
            return voveterinario;
        }

        private bool ValidarDatos()
        {
            bool exito = false;
            if (ValidarNombre() && ValidarTelefono() && ValidarHorario())
                exito = true;
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

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxTelefono.Text, "[^0-9]"))
            {
                textBoxTelefono.Text = textBoxTelefono.Text.Remove(textBoxTelefono.Text.Length - 1);
            }
        }
    }
}
