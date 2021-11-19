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
    public partial class NuevaMascota : Form
    {
        long cedula;
        byte[] m_barrImg;

        public NuevaMascota(long ci)
        {
            InitializeComponent();
            CargarCombos();
            this.cedula = ci;
        }

        private void CargarCombos() {
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoAnimal));
            comboBoxRaza.DataSource = Enum.GetValues(typeof(Raza));
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = dialog.FileName;
                    imagen.Image = Image.FromFile(imageLocation);
                    FileInfo info = new FileInfo(imageLocation);
                    long size = info.Length;
                    FileStream fs = new FileStream(imageLocation, FileMode.Open,
                          FileAccess.Read, FileShare.Read);
                    this.m_barrImg = new byte[Convert.ToInt32(size)];
                    int iBytesRead = fs.Read(this.m_barrImg, 0,
                                     Convert.ToInt32(size));
                    fs.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Error al intentar cargar la imagen", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = CrearVO();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.CrearMascota(vomascota);
                    MessageBox.Show("Mascota ingresada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarDatos();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al ingresar la mascota al sistema. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private VeterianriaWinForms.GestionVeterinarioServices.VOMascota CrearVO()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = new VeterianriaWinForms.GestionVeterinarioServices.VOMascota();
            vomascota.cedulaCliente = this.cedula;
            vomascota.Animal = (GestionVeterinarioServices.TipoAnimal)comboBoxTipo.SelectedItem;
            vomascota.Nombre = textBoxNombre.Text;
            vomascota.Raza = (GestionVeterinarioServices.Raza)comboBoxRaza.SelectedItem;
            vomascota.Edad = Convert.ToInt32(textBoxEdad.Text);
            vomascota.VacunaAlDia = checkBox.Checked;
            VeterianriaWinForms.GestionVeterinarioServices.VOCarnetInscripcion vocarnetinscripcion = new VeterianriaWinForms.GestionVeterinarioServices.VOCarnetInscripcion();
            vocarnetinscripcion.Expedido = DateTime.Now;
            vocarnetinscripcion.Foto = this.m_barrImg;
            vomascota.CarnetInscripcion = vocarnetinscripcion;
            return vomascota;
        }

        private void BorrarDatos()
        {
            comboBoxTipo.SelectedItem = null;
            comboBoxRaza.SelectedItem = null;
            textBoxNombre.Text = String.Empty;
            textBoxEdad.Text = String.Empty;
            checkBox.Checked = false;
            imagen = null;
        }

        private bool ValidarDatos()
        {
            bool exito = false;
            if (ValidarNombre() && ValidarEdad() && ValidarFoto())
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

        private bool ValidarFoto()
        {
            bool bStatus = true;
            if (imagen.Image == null)
            {
                errorProvider1.SetError(imagen, "Por favor ingrese la foto mascota");
                bStatus = false;
            }
            else
                errorProvider1.SetError(imagen, "");
            return bStatus;
        }
    }
}
