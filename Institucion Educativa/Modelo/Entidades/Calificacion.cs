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
    public class Calificacion
    {
        private int idCalificacion;
        private int idEstudiante;
        private int idMateria;
        private decimal notas;
        private DateTime Fecharegistro;

        public int IdCalificacion { get => idCalificacion; set => idCalificacion = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public decimal Notas { get => notas; set => notas = value; }
        public DateTime Fecharegistro1 { get => Fecharegistro; set => Fecharegistro = value; }

           public static DataTable CargarCalif()
           {
           using (SqlConnection con = ConexionDB.Conectar())
           {
            string comando = "SELECT C.idCalificacion, C.idMateria, m.nombreMateria,C.idEstudiante, u.nombre, C.Calificacion from calificaciones C INNER JOIN materias m ON C.idMateria = m.idMateria INNER JOIN estudiantes E ON E.idEstudiante = C.idEstudiante INNER JOIN usuarios u On u.idUsuario = E.idUsuario; \r\n";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            }
            }

        public static DataTable CargarCalifEstu(string correo)
        {
            DataTable table = new DataTable();

            if (string.IsNullOrWhiteSpace(correo))
                return table; // Devuelve vacío si no hay correo

            using (SqlConnection con = ConexionDB.Conectar())
            {
                string comando = "SELECT  m.nombreMateria, C.Calificacion " +
                    "from " +
                    "calificaciones C " +
                    "INNER JOIN materias m ON C.idMateria = m.idMateria " +
                    "INNER JOIN estudiantes E ON E.idEstudiante = C.idEstudiante " +
                    "INNER JOIN usuarios u On u.idUsuario = E.idUsuario and u.correo = @correo;";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@correo", correo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                return table;
            }
        }

        public bool InsertarCalificacion()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "insert into calificaciones (idEstudiante, idMateria, Calificacion, Fecharegistro) values ( @idEstudiante,@idMateria,@notas, @Fecharegistro)";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idEstudiante", IdEstudiante);
            cmd.Parameters.AddWithValue("@idMateria", IdMateria);
            cmd.Parameters.AddWithValue("@notas", notas);
            cmd.Parameters.AddWithValue("@Fecharegistro", Fecharegistro);



            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarCalificaciones()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Update calificaciones set idEstudiante=@idEstudiante,idMateria=@idMateria, Calificacion=@notas where idCalificacion=@idCalificacion";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idCalificacion", idCalificacion);
            cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            cmd.Parameters.AddWithValue("@notas", notas);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarCalificacion(int idCalificacion)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Delete from calificaciones Where idCalificacion=@idCalificacion";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idCalificacion", idCalificacion);
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
