using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actores
{
    public class Vehiculos
    {
        
        public bool isEmpty(Vehiculos vehiculo)
        {
            if (vehiculo.marca.Equals(""))
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
