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

            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinaria[] lista; // new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[]();

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

        private void label1_Click(object sender, EventArgs e)
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
                    ws.EliminarVeterinaria(id);
                    MessageBox.Show("Veterinaria eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                int id = int.Parse(lista.Text);
                EditarVeterinaria FrmEditarVeterinaria;
                FrmEditarVeterinaria = new EditarVeterinaria(id);
                FrmEditarVeterinaria.Owner = this;  // <-- This is the important thing
                FrmEditarVeterinaria.ShowDialog();
                listView1.Items.Clear();
                CargarLista();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVeterinaria FrmNuevoVeterinaria;
            FrmNuevoVeterinaria = new NuevaVeterinaria();
            FrmNuevoVeterinaria.Owner = this;  // <-- This is the important thing
            FrmNuevoVeterinaria.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }

        private void GestionVeterinarias_Load(object sender, EventArgs e)
        {

        }
    }
}
