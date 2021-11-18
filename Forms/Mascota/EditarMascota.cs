using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterianriaWinForms.Forms
{
    public partial class EditarMascota : Form
    {
        int id;
        int numeroCarnet;
        long ciCliente;
        byte[] m_barrImg;

        public EditarMascota(int id)
        {
            InitializeComponent();
            this.id = id;
            PreCargarForm(id);
        }

        private void PreCargarForm(int id)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = ws.ObtenerMascota(id);
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoAnimal));
            comboBoxTipo.SelectedIndex = Convert.ToInt32(vomascota.Animal);
            comboBoxRaza.DataSource = Enum.GetValues(typeof(Raza));
            comboBoxRaza.SelectedIndex = Convert.ToInt32(vomascota.Raza);
            textBoxNombre.Text = vomascota.Nombre;
            textBoxEdad.Text = vomascota.Edad.ToString();
            checkBox.Checked = vomascota.VacunaAlDia;
            this.ciCliente = vomascota.cedulaCliente;
            this.numeroCarnet = vomascota.CarnetInscripcion.Numero;

            m_barrImg = vomascota.CarnetInscripcion.Foto;
            string strfn = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs = new FileStream(strfn,
                              FileMode.CreateNew, FileAccess.Write);
            fs.Write(m_barrImg, 0, m_barrImg.Length);
            fs.Flush();
            fs.Close();
            imagen.Image = Image.FromFile(strfn);
            textBoxNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = CrearVO();
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                ws.EditarMascota(vomascota);
                MessageBox.Show("Mascota editada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOMascota CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = new VeterianriaWinForms.GestionVeterinarioServices.VOMascota();
            vomascota.Id = this.id;
            vomascota.cedulaCliente = this.ciCliente;
            vomascota.Animal = (GestionVeterinarioServices.TipoAnimal)comboBoxTipo.SelectedItem;
            vomascota.Nombre = textBoxNombre.Text;
            vomascota.Raza = (GestionVeterinarioServices.Raza)comboBoxRaza.SelectedItem;
            vomascota.Edad = Convert.ToInt32(textBoxEdad.Text);
            vomascota.VacunaAlDia = checkBox.Checked;
            vomascota.CarnetInscripcion = new VeterianriaWinForms.GestionVeterinarioServices.VOCarnetInscripcion();
            return vomascota;
        }

        private bool ValidarDatos()
        {
            bool exito = false;
            if (ValidarNombre() && ValidarEdad())
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

        private bool ValidarEdad()
        {
            bool bStatus = true;
            if (textBoxEdad.Text == "")
            {
                errorProvider1.SetError(textBoxEdad, "Por favor ingrese la edad de la mascota");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxEdad, "");
            return bStatus;
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxEdad.Text, "[^0-9]"))
            {
                textBoxEdad.Text = textBoxEdad.Text.Remove(textBoxEdad.Text.Length - 1);
            }
        }
    }
}

