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
            }
            else
            {
                DGVehiculos.DataSource = GestorV.MostrarVehiculosfiltro(vehiculo);

            }
        }

        private void DGVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conversion = DGVehiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            conversion1 = DGVehiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CodigoQRFRM QR = new CodigoQRFRM();
            QR.Show();
            texToQr.Text = $"{conversion}\r\n{conversion1}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(texToQr.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pk = qrCode.GetGraphic(5);
            

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
    }
}
