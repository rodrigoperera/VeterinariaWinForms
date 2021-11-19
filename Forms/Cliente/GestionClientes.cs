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
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    long cedula = long.Parse(lista.Text);
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lista.Remove();
                            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                            ws.EliminarCliente(cedula);
                            MessageBox.Show("Cliente eliminado con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar un cliente. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la lista", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente FrmNuevoCliente;
            FrmNuevoCliente = new NuevoCliente();
            FrmNuevoCliente.Owner = this;
            FrmNuevoCliente.ShowDialog();
            listView1.Items.Clear();
            CargarLista();
        }

        private void CargarLista()
        {
            try
            {
                VeterianriaWinForms.GestionVeterinarioServices.VOCliente[] lista;
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
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al obtener la lista de clientes. Contacte a un administrador.", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnListadoMascotas.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                long cedula = long.Parse(lista.Text);
                EditarCliente FrmEditarCliente;
                FrmEditarCliente = new EditarCliente(cedula);
                FrmEditarCliente.Owner = this;
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
                    FrmGestionMascotas.Owner = this;
                    this.Hide();
                    FrmGestionMascotas.ShowDialog();
                    this.Show();
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
