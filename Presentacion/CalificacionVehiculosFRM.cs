using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actores;
using ReglasNegocio;
using Syncfusion.Windows.Forms.Tools;

namespace Presentacion
{
    public partial class CalificacionVehiculosFRM : Form
    {
        RatingControl ratingControl1 = new RatingControl();
        GestorCalificacion gestorCalificacion = new GestorCalificacion();
        Calificacion calificacion = new Calificacion();
        int idRecibido = 0;

        public CalificacionVehiculosFRM(int idCarro)
        {
            InitializeComponent();
            idRecibido = idCarro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalificacionVehiculosFRM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
        
                if (calificacionInput.Value == 0 || observacionInp.Text == "")
                {
                    MessageBox.Show("Debes llenar todos los campos");
                    return;
                }
                else
                {
                    calificacion.calificacion = Convert.ToInt32(calificacionInput.Value);
                    calificacion.observacion = observacionInp.Text;
                    calificacion.recomendacion = recomiendaInp.Checked == true ? 'S' : 'N';
                    calificacion.idCarro = idRecibido;
                }

                string respuesta = gestorCalificacion.ingresarCalificacion(calificacion);

                if (respuesta == "true")
                {
                    MessageBox.Show("Se registró la calificación exitosamente!");
                }
                else
                {
                    MessageBox.Show("Se produjo un error al registrar la calificación :/");
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calificacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
