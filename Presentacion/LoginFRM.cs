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
                    if (Guser.email_bien_escrito(usuario) == true)
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
                    else
                    {
                        MessageBox.Show("debes escribir un correo electronico valido (ejemplo@ejemplo.com)", "formato de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if (Gadmin.email_bien_escrito(administradores) == true)
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
                            MessageBox.Show("Credenciales incorrectas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("debes escribir un correo electronico valido (ejemplo@ejemplo.com)", "formato de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtIngresoPass_TextChanged(object sender, EventArgs e)
        {
            txtIngresoPass.PasswordChar = '*';
            txtIngresoPass.MaxLength = 20;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
