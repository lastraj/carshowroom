using QRCoder;
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
    public partial class VisualizacionVehiculoFRM : Form 
    {
        public VisualizacionVehiculoFRM()
        {
            InitializeComponent();
        }
        public static string conversion;
        public static string conversion1;
        public static string conversion2;
        public static string conversion3;
        public static string conversion4;
        public static string conversion5;
        public static string conversion6;
        string marca;
        GestorVehiculos GestorV = new GestorVehiculos();
        private object pk;

        private void button1_Click(object sender, EventArgs e)
        {
            marca = txtMarca.Text;
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.marca = marca;
            if (vehiculo.isEmpty(vehiculo) == false)
            {
                DGVehiculos.DataSource = GestorV.MostrarVehiculos(vehiculo);
                DGVehiculos.Columns[1].Visible = false;
                DGVehiculos.Columns[4].Visible = false;
                DGVehiculos.Columns[5].Visible = false;
                DGVehiculos.Columns[6].Visible = false;
                DGVehiculos.Columns[7].Visible = false;

            }
            else
            {
                DGVehiculos.DataSource = GestorV.MostrarVehiculosfiltro(vehiculo);
                DGVehiculos.Columns[1].Visible = false;
                DGVehiculos.Columns[4].Visible = false;
                DGVehiculos.Columns[5].Visible = false;
                DGVehiculos.Columns[6].Visible = false;
                DGVehiculos.Columns[7].Visible = false;

            }
        }

        private void DGVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Top3FRM tp = new Top3FRM();

            conversion = DGVehiculos.CurrentRow.Cells[2].Value.ToString();
            conversion1 = DGVehiculos.CurrentRow.Cells[3].Value.ToString();
            conversion2 = DGVehiculos.CurrentRow.Cells[4].Value.ToString();
            conversion3 = DGVehiculos.CurrentRow.Cells[5].Value.ToString();
            conversion4 = DGVehiculos.CurrentRow.Cells[6].Value.ToString();
            conversion5 = DGVehiculos.CurrentRow.Cells[7].Value.ToString();
            //conversion4 = dg

            texToQr.Text = $"{conversion}\r\n{conversion1}\r\n{conversion2}\r\n{conversion3}\r\n{conversion4}\r\n{conversion5}\r\n{conversion6}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(texToQr.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            CodigoQRFRM code = new CodigoQRFRM();
            code.Show();
            code.pk1.Image = qrCode.GetGraphic(5);

            this.Close();
        }

        private void texToQR_TextChanged(object sender, EventArgs e)
        {
            texToQr.Hide();
        }

        private void DGVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var test = DGVehiculos.CurrentCell.RowIndex;

                string aux = DGVehiculos[1, e.RowIndex].Value.ToString(); // IMPORTAN
                int idVehiculo = Convert.ToInt32(aux);
                CalificacionVehiculosFRM CV = new CalificacionVehiculosFRM(idVehiculo);
                CV.Show();
            }
            catch(Exception err)
            {

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DGVehiculos_CellDoubleClic(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualizacionVehiculoFRM_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Top3FRM CV = new Top3FRM();
            CV.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginFRM log = new LoginFRM();
            log.Show();
        }
    }
}
