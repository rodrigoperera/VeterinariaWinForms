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
    public partial class NuevaMascota : Form
    {
        public NuevaMascota()
        {
            InitializeComponent();
            CargarCombos();

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
                    imagen.ImageLocation = imageLocation;

                }
            }
            catch {
                MessageBox.Show("Error al intentar cargar la imagen");
            }
        }
    }
}
