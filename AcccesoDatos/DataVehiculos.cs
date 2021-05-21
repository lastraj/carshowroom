using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Actores;

namespace AcccesoDatos
{
   public class DataVehiculos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CadenaConexion"]);
        public bool Registrarvehiculos(Vehiculos vehiculos)

        {
            try
            {

                bool existe = false;
                string respuesta = "";



                SqlCommand cmd = new SqlCommand("USP_RegistrarVehiculo", cn);



                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@marca", vehiculos.marca);
                cmd.Parameters.Add("@modelo", vehiculos.modelo);
                cmd.Parameters.Add("@año", vehiculos.año);
                cmd.Parameters.Add("@precio", vehiculos.precio);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    respuesta = dr["respuesta"].ToString();
                    cn.Close();
                }


                if (respuesta.Equals("true"))
                {
                    existe = true;
                }

                return existe;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }
    }
}
