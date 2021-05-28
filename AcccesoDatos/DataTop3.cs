using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using Actores;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AcccesoDatos
{
    public class DataTop3
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CadenaConexion"]);

        public DataTable MostrarTop(Vehiculos vehiculos)
        {


            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("USP_Top", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable DGVtop = new DataTable();
                DGVtop.Load(dr);
                cn.Close();

                return DGVtop;


            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }


        public DataTable MostrarTopMenos(Vehiculos vehiculos)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("USP_TopMenos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable DGVtop = new DataTable();
                DGVtop.Load(dr);
                cn.Close();

                return DGVtop;


            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }



        }
    }
}
