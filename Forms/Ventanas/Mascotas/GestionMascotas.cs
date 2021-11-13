﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterianriaWinForms.Forms.Ventanas.Carnet;

namespace VeterianriaWinForms.Forms.Ventanas.Mascotas
{
    public partial class GestionMascotas : Form
    {
        public GestionMascotas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarnetMascota FrmCarnetMascota;
            FrmCarnetMascota = new CarnetMascota();
            FrmCarnetMascota.Owner = this;
            FrmCarnetMascota.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaMascota FrmNuevaMascota;
            FrmNuevaMascota = new NuevaMascota();
            FrmNuevaMascota.Owner = this;
            FrmNuevaMascota.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EditarMascota FrmEditarMascota;
            FrmEditarMascota = new EditarMascota();
            FrmEditarMascota.Owner = this;
            FrmEditarMascota.ShowDialog();
        }
    }
}
