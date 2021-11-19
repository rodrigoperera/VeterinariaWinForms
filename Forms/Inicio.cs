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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.Text = String.Format("Sistem de gestion para la veterinaria {0}", Global.NombreVeterinaria);
            CargarConsultas();
            CargarVeterinarios();

        }

        private void CargarVeterinarios() {

            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            comboBoxVeterinario.DataSource = ws.ObtenerVeterinarios(Global.IdVeterinaria);
            comboBoxVeterinario.DisplayMember = "nombre";
            comboBoxVeterinario.ValueMember = "cedula";

        }

        private void CargarConsultas() 
        {
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta[] lista; 
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            DateTime desde = DateTime.Today;
            DateTime hasta = desde.AddDays(7);
            lista = ws.ObtenerConsultasPorFecha(Global.IdVeterinaria, desde, hasta);
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

        private void trabajarConVeterinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVeterinarios FrmGestionVeterinarios;
            FrmGestionVeterinarios = new GestionVeterinarios();
            FrmGestionVeterinarios.Owner = this;
            FrmGestionVeterinarios.ShowDialog();
        }

        private void trabajarConClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionClientes FrmGestionClientes;
            FrmGestionClientes = new GestionClientes();
            FrmGestionClientes.Owner = this;
            FrmGestionClientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            VeterianriaWinForms.GestionVeterinarioServices.VOVeterinario voveterinario = (GestionVeterinarioServices.VOVeterinario)comboBoxVeterinario.SelectedItem;
            
            VeterianriaWinForms.GestionVeterinarioServices.VOConsulta[] lista;
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            
            lista = ws.ObtenerConsultasPorVeterinario(voveterinario.Cedula, DPDesde.Value, DPHasta.Value);
            foreach (var item in lista)
            {
                ListViewItem listado = new ListViewItem(item.Numero.ToString());
                listado.SubItems.Add(item.Realizada ? "SI" : "NO");
                listado.SubItems.Add(item.Fecha.ToString());
                listado.SubItems.Add(item.Veterinario.Nombre);
                listado.SubItems.Add(String.Format("{0}-{1}", item.Mascota.Id.ToString(), item.Mascota.Nombre));
                listado.SubItems.Add(item.Descripcion);
                listado.SubItems.Add(item.Importe.ToString());
                listView1.Items.Add(listado);

            }
        }
    }
}
