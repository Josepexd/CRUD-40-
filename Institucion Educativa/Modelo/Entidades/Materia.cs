using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;

namespace Modelo.Entidades
{
    public class Materia
    {
        private int idMateria;
        private string nombreMateria;
        private int idProfesor;

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }

        public static DataTable CargarMaterias()
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                string comando = "SELECT m.idMateria, m.nombreMateria, u.nombre, p.idProfesor FROM profesores p INNER JOIN materias m ON m.idProfesor = p.idProfesor INNER JOIN usuarios u ON u.idUsuario = p.idUsuario;";
                SqlDataAdapter adapter = new SqlDataAdapter(comando, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public bool InsertarMaterias()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "insert into materias (nombreMateria, idProfesor) values (@nombreMateria,@idProfesor)";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreMateria", nombreMateria);
            cmd.Parameters.AddWithValue("@idProfesor", idProfesor);


            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarMaterias(int idMateria)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Delete from materias Where idMateria=@idMateria";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarMaterias()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Update materias set nombreMateria=@nombreMateria, idProfesor=@idProfesor where idMateria=@idMateria";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            cmd.Parameters.AddWithValue("@nombreMateria", nombreMateria);
            cmd.Parameters.AddWithValue("@idProfesor", idProfesor);
            
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
  }
   

