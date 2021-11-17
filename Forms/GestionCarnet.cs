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
        private byte[] m_barrImg;

        public GestionCarnet(int id)
        {
            InitializeComponent();
            //this.id = id;
            ObtenerMascota(id);
        }

        private void ObtenerMascota(int id)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = ws.ObtenerMascota(id);
            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = ws.ObtenerCliente(vomascota.cedulaCliente);


            labelNombre.Text = vomascota.Nombre;
            labelvalorraza.Text = vomascota.Raza.ToString();
            labelvaloredad.Text = vomascota.Edad.ToString();
            labelvalordueno.Text = vocliente.Nombre;
            labelvalorvacunado.Text = vomascota.VacunaAlDia ? "Vacunas al dia" : "Vacunas vencidas";

            m_barrImg = vomascota.CarnetInscripcion.Foto;
            string strfn = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs = new FileStream(strfn,
                              FileMode.CreateNew, FileAccess.Write);
            fs.Write(m_barrImg, 0, m_barrImg.Length);
            fs.Flush();
            fs.Close();
            pictureBox1.Image = Image.FromFile(strfn);
        }
    }
}
