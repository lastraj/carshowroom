using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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
        public DataTable MostrarVehiculosfiltro(Vehiculos vehiculos)
        {
            return GestorVehi.MostrarVehiculosfiltro(vehiculos);
        }
        public DataTable MostrarVehiculos(Vehiculos vehiculos)
        {
            return GestorVehi.MostrarVehiculos(vehiculos);
        }
        
    }
}
