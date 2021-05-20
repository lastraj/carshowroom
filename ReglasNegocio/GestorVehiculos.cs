using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actores;
using AcccesoDatos;

namespace ReglasNegocio
{
    public class GestorVehiculos
    {
        DataVehiculos GestorVehi = new DataVehiculos();
        public bool RegistrarVehi(Vehiculos vehiculos)
        {
            return GestorVehi.Registrarvehiculos(vehiculos);
        }
        public bool IsEmpty1(Vehiculos vehiculos)
        {
            if (vehiculos.marca.Equals("") || vehiculos.modelo.Equals(""))

            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
