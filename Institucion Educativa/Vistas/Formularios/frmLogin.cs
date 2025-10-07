using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entidades;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                {
                    if (!(string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtPasswordInicio.Text)))
                    {
                        string correo = txtNombreUsuario.Text;
                        string password = txtPasswordInicio.Text;

                        Usuario usuario = new Usuario();
                        SqlDataReader dr = usuario.VerificarInicioDeSeccion(correo, password);
                        if (dr != null)
                        {
                            MessageBox.Show("Login exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            SesionActual.NombreUsuario = dr["nombre"].ToString();  // Ejemplo: "Aldemaro González"
                            SesionActual.RolId  = Convert.ToInt32(dr["idRol"]);               // Ejemplo: "Administrador"
                            SesionActual.correo = txtNombreUsuario.Text;

                            
                            //Console.WriteLine(SesionActual.NombreUsuario);
                            //Console.WriteLine(SesionActual.RolId);
                            //Console.WriteLine(SesionActual.correo);

                            Vistas.Formularios.frmDashboardPrincipal frmDashboardPrincipal 
                                = new Vistas.Formularios.frmDashboardPrincipal(
                                    );
                            frmDashboardPrincipal.Show();

                            Form parentForm = this.FindForm();
                            if (parentForm != null)
                            {
                                parentForm.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Correo o contraseña incorrectos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un correo y una contraseña");
                    }
                }
                
                /*Usuario u = new Usuario();
                u.Correo = txtNombreUsuario.Text;
                u.Contraseña = txtPasswordInicio.Text;

                if (u.inicioDeSesion())
                {
                    frmDashboardPrincipal ingresar = new frmDashboardPrincipal();
                    ingresar.Show();
                    this.Hide();

                   
                }
                else
                {
                    MessageBox.Show("Error al ingresar: usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar" + ex.Message);
            }
        }

        private void gpbIniciodeSesion_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

