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
    public partial class GestionMascotas : Form
    {
        long cedula;
        string nombre;
        public GestionMascotas(long cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            ObtenerCliente(cedula);
            CargarLista();

        }

        private void ObtenerCliente(long cedula)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = ws.ObtenerCliente(cedula);
            lblClienteNombre.Text = vocliente.Nombre;
        }

        private void CargarLista()
        {

            VeterianriaWinForms.GestionVeterinarioServices.VOMascota[] lista; 

            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerMascotas(this.cedula);
            foreach (var item in lista)
            {
                ListViewItem listado = new ListViewItem(item.Id.ToString());
                listado.SubItems.Add(item.Animal.ToString());
                listado.SubItems.Add(item.Nombre);
                listado.SubItems.Add(item.Raza.ToString());
                listado.SubItems.Add(item.Edad.ToString());
                listado.SubItems.Add(item.VacunaAlDia ? "Vacunas al dia" : "Vacunas vencias");
                listado.SubItems.Add(item.CarnetInscripcion.Expedido.ToString());
                listView1.Items.Add(listado);
                
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                
                int id = int.Parse(lista.Text);
                try
                {

                    lista.Remove();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.EliminarMascota(id);
                    MessageBox.Show("Mascota eliminada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaMascota FrmNuevaMascota;
            FrmNuevaMascota = new NuevaMascota();
            FrmNuevaMascota.Owner = this;  // <-- This is the important thing
            FrmNuevaMascota.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }
    }
}
