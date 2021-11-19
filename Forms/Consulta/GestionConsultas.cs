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
            try
            {
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                VeterianriaWinForms.GestionVeterinarioServices.VOMascota vomascota = ws.ObtenerMascota(id);
                lblMascotaNombre.Text = String.Format("{0}", vomascota.Nombre);
                this.cedulaCliente = vomascota.cedulaCliente;
            }
            catch
            {
                MessageBox.Show("Hubo un error al intentar obtener datos de la mascota. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarConsultas()
        {
            try
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
            catch
            {
                MessageBox.Show("Hubo un error al intentar obtener los datos de las consultas. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
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
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la consulta?", "Eliminar Consulta", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                lista.Remove();
                                ws.EliminarConsulta(id);
                                MessageBox.Show("Consulta eliminada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar la consulta. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    FrmEditarConsulta.Owner = this;
                    FrmEditarConsulta.ShowDialog();
                    CargarConsultas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
