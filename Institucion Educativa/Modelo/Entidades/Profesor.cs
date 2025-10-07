using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo.Conexion;
using System.Windows.Forms;

namespace Modelo.Entidades
{
    public class Profesor
    {
        private int idProfesor;
        private int idUsuario;

        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
       

        public static DataTable CargarProfesores()
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                string comando = "SELECT u.idUsuario, u.nombre, u.telefono, u.correo, u.contraseña FROM Profesores p INNER JOIN Usuarios u ON p.idUsuario = u.idUsuario;";
                SqlDataAdapter adapter = new SqlDataAdapter(comando, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public bool EliminarProfesores(int idUsuario)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Delete from profesores Where idUsuario=@idUsuario";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            if (cmd.ExecuteNonQuery() > 0)
            {
                string comando2 = "Delete from Usuarios Where idUsuario=@idUsuario";
                cmd = new SqlCommand(comando2, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                if(cmd.ExecuteNonQuery() > 0)
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



