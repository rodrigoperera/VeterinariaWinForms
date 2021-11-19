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
    public partial class GestionCarnet : Form
    {
        private VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota;

        public GestionCarnet(int id)
        {
            InitializeComponent();
            ObtenerMascota(id);
        }

        private void ObtenerMascota(int id)
        {
            try
            {
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = ws.ObtenerMascota(id);
                VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = ws.ObtenerCliente(vomascota.cedulaCliente);
                this.vomascota = vomascota;

                labelNombre.Text = vomascota.Nombre;
                labelvalorraza.Text = vomascota.Raza.ToString();
                labelvaloredad.Text = vomascota.Edad.ToString();
                labelvalordueno.Text = vocliente.Nombre;
                labelvalorvacunado.Text = vomascota.VacunaAlDia ? "Vacunas al dia" : "Vacunas vencidas";

                this.vomascota.CarnetInscripcion.Foto = vomascota.CarnetInscripcion.Foto;
                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strfn,
                                  FileMode.CreateNew, FileAccess.Write);
                fs.Write(this.vomascota.CarnetInscripcion.Foto, 0, this.vomascota.CarnetInscripcion.Foto.Length);
                fs.Flush();
                fs.Close();
                pictureBox1.Image = Image.FromFile(strfn);
            }
            catch
            {
                MessageBox.Show("Hubo un error al consultar por el carnet de la mascota. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.Image = Image.FromFile(imageLocation);
                    FileInfo info = new FileInfo(imageLocation);
                    long size = info.Length;
                    FileStream fs = new FileStream(imageLocation, FileMode.Open,
                          FileAccess.Read, FileShare.Read);
                    this.vomascota.CarnetInscripcion.Foto = new byte[Convert.ToInt32(size)];
                    int iBytesRead = fs.Read(this.vomascota.CarnetInscripcion.Foto, 0,
                                     Convert.ToInt32(size));
                    fs.Close();
                }
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                ws.EditarCarnet(this.vomascota.CarnetInscripcion);
            }
            catch 
            {
                MessageBox.Show("Error al intentar cargar la imagen", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
