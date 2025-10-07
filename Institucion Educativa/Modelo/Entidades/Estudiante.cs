using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;

namespace Modelo.Entidades
{
    public class Estudiante
    {
        private int idEstudiante;
        private int idUsuario;
        
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        


        public static DataTable CargarEstudiantes()
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                string comando = "SELECT u.idUsuario, u.nombre, u.telefono, u.correo, u.contraseña FROM estudiantes p INNER JOIN Usuarios u ON p.idUsuario = u.idUsuario;";
                SqlDataAdapter adapter = new SqlDataAdapter(comando, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public bool EliminarEstudiantes(int idUsuario)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Delete from estudiantes Where idUsuario=@idUsuario";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            if (cmd.ExecuteNonQuery() > 0)
            {
                string comando2 = "Delete from Usuarios Where idUsuario=@idUsuario";
                cmd = new SqlCommand(comando2, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
    }
}
