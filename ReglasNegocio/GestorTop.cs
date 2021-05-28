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
    public class GestorTop
    {

        

        DataTop3 GestorT = new DataTop3();

        public DataTable MostrarTop(Vehiculos vehiculos)
        {
            return GestorT.MostrarTop(vehiculos);
        }

        public DataTable MostrarTopMenos(Vehiculos vehiculos)
        {
            return GestorT.MostrarTopMenos(vehiculos);
        }

    }
}
