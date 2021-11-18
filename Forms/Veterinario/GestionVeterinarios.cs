using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Clases;

namespace VeterianriaWinForms.Forms
{
    public partial class GestionVeterinarios : Form
    {
        public GestionVeterinarios()
        {
            InitializeComponent();
            CargarLista();
        }

        private void CargarLista()
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[] lista;
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                lista = ws.ObtenerVeterinarios(Global.IdVeterinaria);

                foreach (var item in lista)
                {
                    ListViewItem listado = new ListViewItem(item.Cedula.ToString());
                    listado.SubItems.Add(item.Nombre);
                    listado.SubItems.Add(item.Telefono);
                    listado.SubItems.Add(item.Horario);
                    listView1.Items.Add(listado);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error al obtener los veterinarios. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNuevo.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoVeterinario FrmNuevoVeterinario;
            FrmNuevoVeterinario = new NuevoVeterinario();
            FrmNuevoVeterinario.Owner = this;
            FrmNuevoVeterinario.ShowDialog();
            listView1.Items.Clear();
            CargarLista(); 
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    long cedula = long.Parse(lista.Text);
                    EditarVeterinario FrmEditarVeterinario;
                    FrmEditarVeterinario = new EditarVeterinario(cedula);
                    FrmEditarVeterinario.Owner = this;
                    FrmEditarVeterinario.ShowDialog();
                    listView1.Items.Clear();
                    CargarLista();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    long cedula = long.Parse(lista.Text);
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el veterinario?", "Eliminar Veterinario", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lista.Remove();
                            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                            ws.EliminarVeterinario(cedula);
                            MessageBox.Show("Veterinario eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al eliminar una veterinario. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
