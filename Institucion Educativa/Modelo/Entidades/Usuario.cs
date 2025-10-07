using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Conexion;

namespace Modelo.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private int idRol;
        private string nombre;
        private string correo;
        private string telefono;
        private string contraseña;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool InsertarUsuarios()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Insert into usuarios(idRol, nombre, correo, telefono, contraseña)" +
            "values(@idRol, @nombre, @correo, @telefono, @contraseña);";

            SqlCommand cmd = new SqlCommand(comando,con);
            cmd.Parameters.AddWithValue("@idRol", idRol);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarUsuario()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "UPDATE usuarios set nombre=@nombre, correo=@correo, telefono=@telefono, where idUsuario=@idUsuario";
            SqlCommand cmd = new SqlCommand(comando,con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@telefono",telefono);
            cmd.Parameters.AddWithValue("@idUsuario",idUsuario);

            if (cmd.ExecuteNonQuery() > 0)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public bool inicioDeSesion()
        {
            SqlConnection sqlConnection = ConexionDB.Conectar();

            string comando = @"select count(*) from usuarios
                        where contraseña = @contraseña 
                        and usuarios.correo = @Correo";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@contraseña", contraseña);
            sqlCommand.Parameters.AddWithValue("@Correo", Correo);
            int count = Convert.ToInt32(sqlCommand.ExecuteScalar());


            return count > 0;
        }*/

        //public bool VerificarInicioDeSeccion(string correo, string clave)
        public SqlDataReader VerificarInicioDeSeccion(string correo, string clave)
        {
            SqlConnection con = Conexion.ConexionDB.Conectar();
            string comando = "SELECT contraseña,u.nombre,u.idRol FROM usuarios U WHERE U.correo = @correo";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@correo", correo);

            /*
            string hashGuardado = (string)cmd.ExecuteScalar(); // Trae el hash de la BD


            if (hashGuardado != null && BCrypt.Net.BCrypt.Verify(clave, hashGuardado))
            {
                //Console.WriteLine("✅ Acceso permitido");
                return true;
            }
            else
            {
                //Console.WriteLine("❌ Usuario o contraseña incorrectos");
                return false;
            }
            */

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string hashGuardado = dr["contraseña"].ToString();
                //string nombreUsu = dr["nombre"].ToString();
                //string idRol = dr["idRol"].ToString();


                if (hashGuardado != null && BCrypt.Net.BCrypt.Verify(clave, hashGuardado))
                {
                    //Console.WriteLine("✅ Acceso permitido");
                    return dr;
                }
                else
                {
                    //Console.WriteLine("❌ Usuario o contraseña incorrectos");
                    
                }
            }
            else
            {
                Console.WriteLine("No se encontró el usuario.");
            }

            return null;

        }
    }
}
