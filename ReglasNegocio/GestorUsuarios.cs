using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actores;
using AcccesoDatos;

namespace ReglasNegocio
{
    public class GestorUsuarios
    {
        DataUsuarios GestorUsrs = new DataUsuarios();

        public bool Registrar(Usuarios usuario)
        {
            return GestorUsrs.Registrar(usuario);
        }
        public bool IsEmpty(Usuarios usuario)
        {
            if (usuario.correo.Equals("") || usuario.contraseña.Equals(""))

            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool iniciarSesionUser(Usuarios usuario)
        {

            return GestorUsrs.iniciarSesionUser(usuario);

        }
    }
}
