using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasNegocio;
using Actores;

namespace Presentacion
{
    public partial class CodigoQRFRM : Form
    {
        public CodigoQRFRM()
        {
            InitializeComponent();
        }

        public void pk_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            VisualizacionVehiculoFRM ver = new VisualizacionVehiculoFRM();
            ver.Show();
        }
    }
}
