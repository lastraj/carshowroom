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
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbuser1.Checked)
            {
                GestorUsuarios Guser = new GestorUsuarios();
                Usuarios usuario = new Usuarios();
                usuario.correo = txtIngresoMail.Text;
                usuario.contraseña = txtIngresoPass.Text;
                if (Guser.IsEmpty(usuario) == false)
                {
                    MessageBox.Show("Debes llenar todos los campos");
                }
                else
                {
                    if (Guser.iniciarSesionUser(usuario))
                    {
                        MessageBox.Show("Bienvenido a carshowroom");
                        this.Hide();
                        VisualizacionVehiculoFRM VerVeh = new VisualizacionVehiculoFRM();
                        
                        VerVeh.Show();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }
            }
            if (rdbAdmin1.Checked)
            {
                GestorAdministradores Gadmin = new GestorAdministradores();
                Administradores administradores = new Administradores();
                administradores.correo = txtIngresoMail.Text;
                administradores.contraseña = txtIngresoPass.Text;
                if (Gadmin.IsEmpty(administradores) == false)
                {
                    MessageBox.Show("Debes llenar todos los campos");
                }
                else
                {
                    if (Gadmin.iniciarSesionAdmin(administradores))
                    {
                        MessageBox.Show("Administrador, Bienvenido a carshowroom");
                        this.Hide();
                        IngresoVehiculosFRM InVeh = new IngresoVehiculosFRM();

                        InVeh.Show();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistroFRM rfrm = new RegistroFRM();
            rfrm.Show();
        }
    }
}
