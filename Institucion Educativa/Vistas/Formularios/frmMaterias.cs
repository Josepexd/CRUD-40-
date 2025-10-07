using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Conexion;
using Modelo.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Formularios
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            btnCancelarActuMater.Visible = false;
            btnActualizarMateria.Visible = false;
            btnEliminarMateria.Visible = false;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmAgregarProfesores frmProfesor = new frmAgregarProfesores();
            frmProfesor.Show();
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

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            CargaProfesoresMateria();
            CargarMaterias();
        }
        private void CargaProfesoresMateria()
        {
            SqlConnection con = ConexionDB.Conectar();
            string ConsultaProfMat = "Select p.idProfesor, u.nombre from Usuarios u INNER JOIN profesores p on p.idUsuario = u.idUsuario;";
            SqlCommand comando = new SqlCommand(ConsultaProfMat, con);
            DataTable datable = new DataTable();
            datable.Load(comando.ExecuteReader());
            cmbProfesor.DataSource = datable;
            cmbProfesor.ValueMember = datable.Columns[0].ColumnName;
            cmbProfesor.DisplayMember = datable.Columns[1].ColumnName;
            cmbProfesor.SelectedValue = 0;


        }
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
           
                
                if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || cmbProfesor.SelectedValue == null || int.Parse(cmbProfesor.SelectedValue.ToString()) == 0)
                {
                MessageBox.Show("El campo de Nombre de la materia no puede estar vacío","Validación",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                Materia m = new Materia();
                m.NombreMateria = txtNombreMateria.Text;
                m.IdProfesor = int.Parse(cmbProfesor.SelectedValue.ToString());
                m.InsertarMaterias();
                MessageBox.Show("Materia agregada correctamente", "Exito");
                txtNombreMateria.Text = "";
                cmbProfesor.SelectedValue = 0;
                CargarMaterias();
                }
            
            

        }


        private void CargarMaterias()
        {
            dvgMateria.DataSource = null;
            dvgMateria.DataSource = Materia.CargarMaterias();
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

        private void txtNombreMateria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            int idMateria = int.Parse(dvgMateria.CurrentRow.Cells[0].Value.ToString());
            Materia M = new Materia();
            if (M.EliminarMaterias(idMateria) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                CargarMaterias();
                txtNombreMateria.Text = "";
                cmbProfesor.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia");
            }
        }

        private void dvgMateria_DoubleClick(object sender, EventArgs e)
        {
            if (dvgMateria.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnAgregarMateria.Visible = false;
            btnEliminarMateria.Visible = true;
            btnCancelarActuMater.Visible = true;
            btnActualizarMateria.Visible = true;

            txtNombreMateria.Text = dvgMateria.CurrentRow.Cells[1].Value?.ToString() ?? "";

            
            if (int.TryParse(dvgMateria.CurrentRow.Cells[3].Value?.ToString(), out int idProfesor))
            {
                cmbProfesor.SelectedValue = idProfesor;
            }
            else
            {
                MessageBox.Show("El valor de la materia no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnActualizarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || int.Parse(cmbProfesor.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Materia M = new Materia();
            M.NombreMateria = txtNombreMateria.Text;
            M.IdProfesor = int.Parse(cmbProfesor.SelectedValue.ToString());
            M.IdMateria = int.Parse(dvgMateria.CurrentRow.Cells[0].Value.ToString());

            if (M.ActualizarMaterias() == true)
            {
                CargarMaterias();
                txtNombreMateria.Text = "";
                cmbProfesor.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al actualizar el registro", "Error");
            }
        }

        private void btnCancelarActuMater_Click(object sender, EventArgs e)
        {
            btnCancelarActuMater.Visible = false;
            btnActualizarMateria.Visible = false;
            btnEliminarMateria.Visible = false;
            btnAgregarMateria.Visible = true;
            txtNombreMateria.Text = "";
            cmbProfesor.SelectedValue = 0;

        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

