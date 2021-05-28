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

namespace Presentacion
{
    public partial class RegistroFRM : Form
    {
        public RegistroFRM()
        {
            InitializeComponent();
        }

       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarRegistro_Click_1(object sender, EventArgs e)
        {
            if (rdb_Usuario.Checked)
            {
                
                GestorUsuarios GestorU = new GestorUsuarios();
                Usuarios usuario = new Usuarios();
                usuario.nombre = txtNom.Text;
                usuario.contraseña = txtContraseña.Text;
                usuario.correo = txtCorreo.Text;


                if (GestorU.IsEmpty(usuario) == false)
                {

                    MessageBox.Show("Debes llenar todos los campos para poder registrarte");
                    txtContraseña.Clear();
                    txtNom.Clear();
                    txtCorreo.Clear();
                    txtEmp.Clear();




                }
                else
                {
                    if (GestorU.Registrar(usuario))
                    {
                        MessageBox.Show("Te has registrado correctamente \n ¡Bienvenido!");
                        this.Hide();
                        VisualizacionVehiculoFRM inicio = new VisualizacionVehiculoFRM();
                        inicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe");
                        txtContraseña.Clear();
                        txtNom.Clear();
                        txtCorreo.Clear();
                        txtEmp.Clear();

                    }
                }
            }
           
                if (rdb_Admin.Checked)
                {
                   
                GestorAdministradores GestorAdm = new GestorAdministradores();
                Administradores administradores = new Administradores();
                administradores.nombre = txtNom.Text;
                administradores.contraseña = txtContraseña.Text;
 
                administradores.empresa = txtEmp.Text;
                administradores.correo = txtCorreo.Text;


                    if (GestorAdm.IsEmpty(administradores) == false)
                    {

                        MessageBox.Show("Debes llenar todos los campos para poder registrarte");
                        txtContraseña.Clear();
                        txtNom.Clear();
                        txtCorreo.Clear();
                        txtEmp.Clear();



                    }
                    else
                    {
                        if (GestorAdm.Registrar(administradores))
                        {
                            MessageBox.Show("Te has registrado correctamente \n ¡Bienvenido!");
                            this.Hide();
                            IngresoVehiculosFRM inicio = new IngresoVehiculosFRM();
                            inicio.Show();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya existe");
                            txtContraseña.Clear();
                            txtNom.Clear();
                            txtCorreo.Clear();
                            txtEmp.Clear();

                        }
                    }
                }
               
            
           
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            txtContraseña.MaxLength = 20;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void rdb_Usuario_CheckedChanged(object sender, EventArgs e)
        {


            txtEmp.Hide();
            label4.Hide();
        }

        private void rdb_Admin_CheckedChanged(object sender, EventArgs e)
        {
            txtEmp.Show();
            label4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginFRM loge = new LoginFRM();
            loge.Show();
        }
    }
}