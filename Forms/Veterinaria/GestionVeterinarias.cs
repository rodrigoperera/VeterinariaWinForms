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
    public partial class GestionVeterinarias : Form
    {
        public GestionVeterinarias()
        {
            InitializeComponent();
            CargarLista();
        }

        private void CargarLista()
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria[] lista;
                GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                lista = ws.ObtenerVeterinarias();

                foreach (var item in lista)
                {
                    ListViewItem listado = new ListViewItem(item.Id.ToString());
                    listado.SubItems.Add(item.Nombre);
                    listado.SubItems.Add(item.Direccion);
                    listado.SubItems.Add(item.Telefono);
                    listView1.Items.Add(listado);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al obtener la lista de veterinarias. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la veterinaria?", "Eliminar Veterinaria", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lista.Remove();
                            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                            ws.EliminarVeterinaria(id);
                            MessageBox.Show("Veterinaria eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al eliminar una veterinaria. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    int id = int.Parse(lista.Text);
                    EditarVeterinaria FrmEditarVeterinaria;
                    FrmEditarVeterinaria = new EditarVeterinaria(id);
                    FrmEditarVeterinaria.Owner = this;
                    FrmEditarVeterinaria.ShowDialog();
                    listView1.Items.Clear();
                    CargarLista();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVeterinaria FrmNuevoVeterinaria;
            FrmNuevoVeterinaria = new NuevaVeterinaria();
            FrmNuevoVeterinaria.Owner = this;
            FrmNuevoVeterinaria.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
