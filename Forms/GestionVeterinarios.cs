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
                VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[] lista; // new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[]();
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
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoVeterinario FrmNuevoVeterinario;
            FrmNuevoVeterinario = new NuevoVeterinario();
            FrmNuevoVeterinario.Owner = this;  // <-- This is the important thing
            FrmNuevoVeterinario.ShowDialog();
            listView1.Items.Clear();
            CargarLista(); 
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                long cedula = long.Parse(lista.Text);
                EditarVeterinario FrmEditarVeterinario;
                FrmEditarVeterinario = new EditarVeterinario(cedula);
                FrmEditarVeterinario.Owner = this;  // <-- This is the important thing
                FrmEditarVeterinario.ShowDialog();
                listView1.Items.Clear();
                CargarLista();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                long cedula = long.Parse(lista.Text);
                try
                {
                    lista.Remove();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.EliminarVeterinario(cedula);
                    MessageBox.Show("Veterinario eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al eliminar una veterinario. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
