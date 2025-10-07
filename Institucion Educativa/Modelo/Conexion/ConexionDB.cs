using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    public class ConexionDB
    {
        public static string servidor = "DESKTOP-HQ6TBMH\\SQLEXPRESS";
        public static string database = "institucion_educativ";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data source={servidor}; initial catalog={database};integrated security=true;";

            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();
            return conexion;


        }


    }
}

