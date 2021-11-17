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
                listado.SubItems.Add(item.VacunaAlDia ? "Vacunas al dia" : "Vacunas vencidas");
                listado.SubItems.Add(item.CarnetInscripcion.Expedido.ToString());
                listView1.Items.Add(listado);
            }
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
            FrmNuevaMascota = new NuevaMascota(cedula);
            FrmNuevaMascota.Owner = this;  // <-- This is the important thing
            FrmNuevaMascota.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }

        private void BtnCarnet_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                int id = int.Parse(lista.Text);
                GestionCarnet FrmGestionCarnet;
                FrmGestionCarnet = new GestionCarnet(id);
                FrmGestionCarnet.Owner = this;  // <-- This is the important thing
                FrmGestionCarnet.ShowDialog();
            }

        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    int id = int.Parse(lista.Text);
                    GestionConsultas FrmGestionConsultas;
                    FrmGestionConsultas = new GestionConsultas(id);
                    FrmGestionConsultas.Owner = this;  // <-- This is the important thing
                    FrmGestionConsultas.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Para acceder a ver las consultas es necesario seleccionar una mascota", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                int id = int.Parse(lista.Text);
                EditarMascota FrmEditarMascota;
                FrmEditarMascota = new EditarMascota(id);
                FrmEditarMascota.Owner = this;
                FrmEditarMascota.ShowDialog();
                listView1.Items.Clear();
                CargarLista();
            }
        }
    }
}
