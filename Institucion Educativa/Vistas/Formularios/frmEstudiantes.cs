using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entidades;

namespace Vistas.Formularios
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
            txtTelefono.MaxLength = 9;
            btnActualizarEstudiante.Visible = false;
            btnCancelarActuEstu.Visible = false;
            btnEliminarEstudiante.Visible = false;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiantes frmEstudiantes = new frmEstudiantes();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmAgregarProfesores frmProfesor = new frmAgregarProfesores();
            frmProfesor.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
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

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            MostrarEstudiantes();
        }
        private void MostrarEstudiantes()
        {
            dvgEstudiante.DataSource = null;
            dvgEstudiante.DataSource = Estudiante.CargarEstudiantes();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (dvgEstudiante.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un estudiante antes de eliminar.", "Advertencia");
                return;
            }

            int idUsuario;
            if (!int.TryParse(dvgEstudiante.CurrentRow.Cells[0].Value?.ToString(), out idUsuario))
            {
                MessageBox.Show("No se pudo obtener el ID del estudiante.", "Error");
                return;
            }

            Estudiante E = new Estudiante();
            if (E.EliminarEstudiantes(idUsuario))
            {
                MessageBox.Show("Registro eliminado correctamente", "Éxito");
                MostrarEstudiantes();
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Se produjo un error al eliminar el registro.", "Advertencia");
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = new Usuario();
            u.IdRol = 3;
            u.Nombre = txtNombre.Text;
            u.Correo = txtCorreo.Text;
            u.Telefono = txtTelefono.Text;
            u.Contraseña = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
            try
            {
                u.InsertarUsuarios();
                MessageBox.Show("Estudiante agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos para que al usuario se le facilirte insertar mas de un usuario/estudiante/Profesor
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtPassword.Text = "";

                MostrarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            if (dvgEstudiante.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un estudiante antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica que la celda no sea nula ya que si esta es nula genera un error y lo imprimo para que al usuario se le facilite el uso
            if (dvgEstudiante.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("La fila seleccionada no contiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario u = new Usuario();
            u.IdRol = 3;
            u.Nombre = txtNombre.Text;
            u.Correo = txtCorreo.Text;
            u.Telefono = txtTelefono.Text;
            u.Contraseña = txtPassword.Text;
            u.IdUsuario = int.Parse(dvgEstudiante.CurrentRow.Cells[0].Value.ToString());

            if (u.ActualizarUsuario())
            {
                MostrarEstudiantes();
                txtNombre.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtPassword.Clear();
                MessageBox.Show("Estudiante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgEstudiante_DoubleClick(object sender, EventArgs e)
        {
            btnAgregarEstudiante.Visible = false;
            btnEliminarEstudiante.Visible = true;
            btnCancelarActuEstu.Visible = true;
            btnActualizarEstudiante.Visible = true;
            txtPassword.Visible = false;
            lblPassword.Visible = false;

            txtNombre.Text = dvgEstudiante.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dvgEstudiante.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dvgEstudiante.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dvgEstudiante.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {
            frmAgregarProfesores frmAgregarProfesores = new frmAgregarProfesores();
            frmAgregarProfesores.Show();
            this.Hide();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
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

        private void btnCancelarActuEstu_Click(object sender, EventArgs e)
        {
            btnCancelarActuEstu.Visible = false;
            btnActualizarEstudiante.Visible = false;
            btnEliminarEstudiante.Visible = false;
            btnAgregarEstudiante.Visible = true;
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
