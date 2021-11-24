using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterianriaWinForms.Forms.Empresa
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            textBoxVersion.Text = "2.3";
            textBoxVersion.ReadOnly = true;
            textBoxFecha.Text = "20/11/2021";
            textBoxFecha.ReadOnly = true;
        }
    }
}
