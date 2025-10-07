using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Modelo;
using Modelo.Entidades;
namespace Vistas.Formularios
{

    public partial class frmAgregarProfesores : Form
    {
        public frmAgregarProfesores()
        {
            InitializeComponent();
            txtTelefono.MaxLength = 9;

            btnCancelarActuProf.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
           
        }
        
        private void frmAgregarProfesores_Load(object sender, EventArgs e)
        {
            MostrarProfesores();
        }
        private void MostrarProfesores()
        {
            dvgProfesores.DataSource = null;
            dvgProfesores.DataSource = Profesor.CargarProfesores();
        }

        private void btnAgregarProfesores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = new Usuario();
            u.IdRol = 2;
            u.Nombre = txtNombre.Text;
            u.Correo = txtCorreo.Text;
            u.Telefono = txtTelefono.Text;
            u.Contraseña = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            try
            {
                u.InsertarUsuarios();
                MessageBox.Show("Profesor agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos para que al usuario se le facilirte insertar mas de un usuario/estudiante/Profesor
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtPassword.Text = "";

                MostrarProfesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmAgregarProfesores frmProfesor = new frmAgregarProfesores();
            frmProfesor.Show();
            this.Hide();
        }

        private void dvgProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
            this.Hide();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiantes frmEstudiantes = new frmEstudiantes();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias frmMaterias = new frmMaterias();
            frmMaterias.Show();
            this.Hide();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            frmCalificaciones frmCalificaciones = new frmCalificaciones();
            frmCalificaciones.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(dvgProfesores.CurrentRow.Cells[0].Value.ToString());
            Profesor p = new Profesor();
            if(p.EliminarProfesores(idUsuario) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarProfesores();
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (dvgProfesores.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un profesor antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = new Usuario();
            u.IdRol = 2;
            u.Nombre = txtNombre.Text;
            u.Correo = txtCorreo.Text;
            u.Telefono = txtTelefono.Text;
            


            if (!int.TryParse(dvgProfesores.CurrentRow.Cells[0].Value?.ToString(), out int idUsuario))
            {
                MessageBox.Show("No se pudo obtener el ID del profesor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            u.IdUsuario = idUsuario;

            if (u.ActualizarUsuario())
            {
                MostrarProfesores();
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtPassword.Text = "";

                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgProfesores_DoubleClick(object sender, EventArgs e)
        {
            btnAgregarProfesores.Visible = false;
            btnEliminar.Visible = true;
            btnCancelarActuProf.Visible = true;
            btnActualizar.Visible = true;
            txtPassword.Visible = false;
            lblPassword.Visible = false;


            txtNombre.Text = dvgProfesores.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dvgProfesores.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dvgProfesores.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dvgProfesores.CurrentRow.Cells[4].Value.ToString();
            

        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
            this.Hide();
        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {
            frmAgregarProfesores frmAgregarProfesores = new frmAgregarProfesores();
            frmAgregarProfesores.Show();
            this.Hide();
        }

        private void btnEstudiantes_Click_1(object sender, EventArgs e)
        {
            frmEstudiantes frmEstudiantes = new frmEstudiantes();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void btnMaterias_Click_1(object sender, EventArgs e)
        {
            frmMaterias frmMaterias = new frmMaterias();
            frmMaterias.Show();
            this.Hide();
        }

        private void btnCalificaciones_Click_1(object sender, EventArgs e)
        {
            frmCalificaciones frmCalificaciones = new frmCalificaciones();
            frmCalificaciones.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnCerrarSecion1_Click(object sender, EventArgs e)
        {
            pnlPantalladesplegableSalir.Visible = !pnlPantalladesplegableSalir.Visible;

        }

        private void btnCancelarActuProf_Click(object sender, EventArgs e)
        {
            btnCancelarActuProf.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregarProfesores.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtPassword.Text = "";



        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string barra = txtTelefono.Text.Replace("-", "");
            if (barra.Length > 4)
                barra = barra.Insert(4, "-"); 

            txtTelefono.Text = barra;
            txtTelefono.SelectionStart = txtTelefono.Text.Length;

            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
               
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden ingresar dígitos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden ingresar dígitos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

