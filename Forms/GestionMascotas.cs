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
    public partial class GestionMascotas : Form
    {
        long cedula;
        string nombre;
        public GestionMascotas(long cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            ObtenerCliente(cedula);
            CargarLista();

        }

        private void ObtenerCliente(long cedula)
        {
            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            VeterianriaWinForms.GestionVeterinarioServices.VOCliente vocliente = ws.ObtenerCliente(cedula);
            lblClienteNombre.Text = vocliente.Nombre;
        }

        private void CargarLista()
        {

            VeterianriaWinForms.GestionVeterinarioServices.VOMascota[] lista; 

            GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
            lista = ws.ObtenerMascotas(this.cedula);
            foreach (var item in lista)
            {
                // aca debería ir el id de la mascota. pero el VO solo tiene get para ese atributo.
                // luego ese dato se usa para eliminar.
                ListViewItem listado = new ListViewItem(item.Edad.ToString());
                listado.SubItems.Add(item.Animal.ToString());
                listado.SubItems.Add(item.Nombre);
                listado.SubItems.Add(item.Raza.ToString());
                listado.SubItems.Add(item.Edad.ToString());
                listado.SubItems.Add(item.VacunaAlDia ? "Vacunas al dia" : "Vacunas vencias");
                listado.SubItems.Add(item.CarnetInscripcion.Expedido.ToString());
                //listado.SubItems.Add(item.CarnetInscripcion.Foto);
                listView1.Items.Add(listado);
                
            }
            




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                // TODO: NO ESTA FUNCIONADNO AHORA. VA A FUNCIONAR CUANDO TENGAMOS EL ID DE LA MASCOTA EN EL LISTADO
                // YA QUE ESO ES LO QUE SE LE PASA AL ELIMINAR. 
                int id = int.Parse(lista.Text); // es necesario que el primer campo sea el id de la mascota asi lo mandamos en el eliminar
                try
                {

                    lista.Remove();
                    GestionVeterinarioServices.WebServiceVeterinariasSoapClient ws = new GestionVeterinarioServices.WebServiceVeterinariasSoapClient();
                    ws.EliminarMascota(id);
                    MessageBox.Show("Mascota eliminada con exito", "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gestion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
