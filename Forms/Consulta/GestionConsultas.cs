using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Forms.Consulta;

namespace VeterianriaWinForms.Forms
{
    public partial class GestionConsultas : Form
    {
        private int idMascota;
        public GestionConsultas(int idMascota)
        {
            InitializeComponent();
            this.idMascota = idMascota;
            ObtenerMascota (idMascota);
            CargarConsultas();
        }

        private void ObtenerMascota(int id)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = ws.ObtenerMascota(id);
            lblMascotaNombre.Text = String.Format("{0} - {1}", vomascota.Id, vomascota.Nombre);
        }

        private void CargarConsultas()
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta[] lista;
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerConsultasPorMascota(this.idMascota);
            foreach (var item in lista)
            {
                ListViewItem listado = new ListViewItem(item.Numero.ToString());
                listado.SubItems.Add(item.Veterinario.Nombre);
                listado.SubItems.Add(item.Fecha.ToString());
                listado.SubItems.Add(item.Descripcion);
                listado.SubItems.Add(String.Format("{0}-{1}", item.Mascota.Id.ToString(), item.Mascota.Nombre));
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
                    ws.EliminarConsulta(id);
                    MessageBox.Show("Consulta eliminada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    int numero = int.Parse(lista.Text);
                    EditarConsulta FrmEditarConsulta;
                    FrmEditarConsulta = new EditarConsulta(numero);
                    FrmEditarConsulta.Owner = this;  // <-- This is the important thing
                    FrmEditarConsulta.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Para acceder a editar una consulta es necesario seleccionarla", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
