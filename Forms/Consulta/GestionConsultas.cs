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
        private long cedulaCliente;
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
            this.cedulaCliente = vomascota.cedulaCliente;
        }

        private void CargarConsultas()
        {
            listView1.Items.Clear();
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta[] lista;
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerConsultasPorMascota(this.idMascota);
            foreach (var item in lista)
            {
                ListViewItem listado = new ListViewItem(item.Numero.ToString());
                listado.SubItems.Add(item.Realizada ? "SI" : "NO");
                listado.SubItems.Add(item.Fecha.ToString());
                listado.SubItems.Add(item.Veterinario.Nombre);
                listado.SubItems.Add(String.Format("{0}-{1}", item.Mascota.Id.ToString(), item.Mascota.Nombre));
                listado.SubItems.Add(item.Descripcion);
                listado.SubItems.Add(item.Calificacion.ToString());
                listado.SubItems.Add(item.Importe.ToString());

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
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();

                    VeterianriaWinForms.GestionVeterinarioServices.VOConsulta con = ws.ObtenerConsulta(id);
                    if (con.Realizada)
                    {
                        MessageBox.Show("Eliminación no disponible. La consulta que intenta eliminar ya fue realizada.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else {
                        lista.Remove();
                        ws.EliminarConsulta(id);
                        MessageBox.Show("Consulta eliminada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            NuevaConsulta FrmNuevaConsulta;
            FrmNuevaConsulta = new NuevaConsulta(this.cedulaCliente);
            FrmNuevaConsulta.Owner = this;  
            FrmNuevaConsulta.ShowDialog();
            CargarConsultas();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    int numeroConsulta = int.Parse(lista.Text);
                    EditarConsulta FrmEditarConsulta;
                    FrmEditarConsulta = new EditarConsulta(numeroConsulta);
                    FrmEditarConsulta.Owner = this;  // <-- This is the important thing
                    FrmEditarConsulta.ShowDialog();
                    CargarConsultas();
                }
            }
            else
            {
                MessageBox.Show("Para acceder a editar una consulta es necesario seleccionarla", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
