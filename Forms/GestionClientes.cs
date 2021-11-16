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
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
            CargarLista();
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
                    ws.EliminarCliente(cedula);
                    MessageBox.Show("Cliente eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente FrmNuevoCliente;
            FrmNuevoCliente = new NuevoCliente();
            FrmNuevoCliente.Owner = this;  // <-- This is the important thing
            FrmNuevoCliente.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }

        private void CargarLista()
        {

            VeterianriaWinForms.GestionVeterinarioServices.VOCliente[] lista; // new VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario[]();

            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerClientes(Global.IdVeterinaria);
            string activo;
            foreach (var item in lista)
            {
                ListViewItem listado = new ListViewItem(item.Cedula.ToString());
                listado.SubItems.Add(item.Nombre);
                listado.SubItems.Add(item.Telefono);
                listado.SubItems.Add(item.Direccion);
                listado.SubItems.Add(item.Correo);
                if (item.Activo) {
                    activo = "Activo";
                }
                else{
                    activo = "Inactivo";
                }
                listado.SubItems.Add(activo);
                listView1.Items.Add(listado);
            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                long cedula = long.Parse(lista.Text);
                EditarCliente FrmEditarCliente;
                FrmEditarCliente = new EditarCliente(cedula);
                FrmEditarCliente.Owner = this;  // <-- This is the important thing
                FrmEditarCliente.ShowDialog();
                listView1.Items.Clear();
                CargarLista();

            }
        }

        private void btnListadoMascotas_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    long cedula = long.Parse(lista.Text);
                    GestionMascotas FrmGestionMascotas;
                    FrmGestionMascotas = new GestionMascotas(cedula);
                    FrmGestionMascotas.Owner = this;  // <-- This is the important thing
                    FrmGestionMascotas.ShowDialog();

                }
            }
            else {
                MessageBox.Show("Para acceder a ver las mascotas es necesario seleccionar un cliente", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

    

        }
    }
}
