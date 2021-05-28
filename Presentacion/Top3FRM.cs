using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasNegocio;
using Actores;

namespace Presentacion
{
    public partial class Top3FRM : Form
    {
        public Top3FRM()
        {
            InitializeComponent();
        }

         GestorTop GestorT = new GestorTop();

        private void DGVtop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculo = new Vehiculos();

            DGVtop.DataSource = GestorT.MostrarTop(vehiculo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculo = new Vehiculos();

            DGVtop.DataSource = GestorT.MostrarTopMenos(vehiculo);
        }
    }
}
