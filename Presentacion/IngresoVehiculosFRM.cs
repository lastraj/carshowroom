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
    public partial class IngresoVehiculosFRM : Form
    {
        public IngresoVehiculosFRM()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorVehiculos Gvehi = new GestorVehiculos();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.marca = txtMarca.Text;
            vehiculos.modelo = txtModelo.Text;
            vehiculos.año = txtAño.Text;
            vehiculos.motor = TXTmotor.Text;
            vehiculos.linea = TXTlinea.Text;
            vehiculos.precio = txtPrecio.Text;
            if (Gvehi.IsEmpty1(vehiculos) == false)
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
            else
            {
                if (Gvehi. RegistrarVehi(vehiculos))
                {
                    MessageBox.Show("el vehiculo se ha registrado correctamente \n ¡Bienvenido!");
                    this.Hide();
                    VisualizacionVehiculoFRM inicio = new VisualizacionVehiculoFRM();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("El vehiculo ya existe");
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAño.Clear();
                    TXTmotor.Clear();
                    TXTlinea.Clear();
                    txtPrecio.Clear();

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            VisualizacionVehiculoFRM ver = new VisualizacionVehiculoFRM();
            ver.Show();
        }
    }
}
