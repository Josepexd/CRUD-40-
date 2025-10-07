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
using Modelo.Conexion;
using Modelo.Entidades;

namespace Vistas.Formularios
{
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
            CargarEstudiantesCalificacion();
            CargarMateriasCalif();
            CargarCalif();
            CargarMenu();
            btnCancelarActuCalif.Visible = false;
            btnActualizarCalificacion.Visible = false;
            btnEliminarCalificacion.Visible = false;
        }
        private void CargarMenu()
        {
            btnInicio.Visible = true;
            btnEstudiantes.Visible = false;
            btnMaterias.Visible = false;
            btnProfesores.Visible = false;
            btnCalificaciones.Visible = false;


            switch (SesionActual.RolId)
            {
                case 1://Admin
                    btnEstudiantes.Visible = true;
                    btnMaterias.Visible = true;
                    btnProfesores.Visible = true;
                    btnCalificaciones.Visible = true;
  
                    break;

                case 2://Profesor
                    btnCalificaciones.Visible = true;
                    break;

                case 3://Estudiante


                    break;
            }
        }


        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
            this.Hide();
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

        private void btnCalificaciones_Click_1(object sender, EventArgs e)
        {
            frmCalificaciones frmCalificaciones = new frmCalificaciones();
            frmCalificaciones.Show();
            this.Hide();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias frmMaterias = new frmMaterias();
            frmMaterias.Show();
            this.Hide();
        }

        private void btnEstudiantes_Click_1(object sender, EventArgs e)
        {
            frmEstudiantes frmEstudiantes = new frmEstudiantes();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            CargarCalif();
        }
        private void CargarCalif()
        {
            dvgCalificaciones.DataSource = null;
            dvgCalificaciones.DataSource = Calificacion.CargarCalif();
        }
        private void CargarEstudiantesCalificacion()
        {
            SqlConnection con = ConexionDB.Conectar();
            string ConsultaProfMat = "Select E.idEstudiante, u.nombre from estudiantes E inner JOIN usuarios u  On E.idUsuario = u.idUsuario;";
            SqlCommand comando = new SqlCommand(ConsultaProfMat, con);
            DataTable datable = new DataTable();
            datable.Load(comando.ExecuteReader());
            cmbAlumno.DataSource = datable;
            cmbAlumno.ValueMember = datable.Columns[0].ColumnName;
            cmbAlumno.DisplayMember = datable.Columns[1].ColumnName;
            cmbAlumno.SelectedValue = 0;


        }
        private void CargarMateriasCalif()
        {
            SqlConnection con = ConexionDB.Conectar();
            string ConsultaProfMat = "Select m.idMateria, m.nombreMateria from materias m;";
            SqlCommand comando = new SqlCommand(ConsultaProfMat, con);
            DataTable datable = new DataTable();
            datable.Load(comando.ExecuteReader());
            cmbMateria.DataSource = datable;
            cmbMateria.ValueMember = datable.Columns[0].ColumnName;
            cmbMateria.DisplayMember = datable.Columns[1].ColumnName;
            cmbMateria.SelectedValue = 0;
        }
        private void btnAgregarCalificaciones_Click(object sender, EventArgs e)
        {
            if (cmbAlumno.SelectedValue == null || int.Parse(cmbAlumno.SelectedValue.ToString()) == 0 || cmbMateria.SelectedValue == null || int.Parse(cmbMateria.SelectedValue.ToString()) == 0 || nudNota.Value < 0)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Calificacion C = new Calificacion();
            C.IdEstudiante = int.Parse(cmbAlumno.SelectedValue.ToString());
            C.IdMateria = int.Parse(cmbMateria.SelectedValue.ToString());
            C.Notas = nudNota.Value;
            C.Fecharegistro1 = DateTime.Now;


            try
            {
                C.InsertarCalificacion();
                CargarCalif();
                MessageBox.Show("Calificacion agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos para que al usuario se le facilirte insertar mas de un usuario/estudiante/Profesor
                cmbAlumno.SelectedValue = 0;
                cmbMateria.SelectedValue = 0;
                nudNota.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la calificacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSecion1_Click(object sender, EventArgs e)
        {
            pnlPantalladesplegableSalir.Visible = !pnlPantalladesplegableSalir.Visible;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void dvgCalificaciones_DoubleClick(object sender, EventArgs e)
        {
            if (dvgCalificaciones.CurrentRow == null || dvgCalificaciones.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una calificación válida antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dvgCalificaciones.CurrentRow;

            if (fila.Cells[5].Value == DBNull.Value || fila.Cells[3].Value == DBNull.Value || fila.Cells[1].Value == DBNull.Value)
            {
                MessageBox.Show("La fila seleccionada contiene datos vacíos o incompletos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnAgregarCalificaciones.Visible = false;
            btnEliminarCalificacion.Visible = true;
            btnCancelarActuCalif.Visible = true;
            btnActualizarCalificacion.Visible = true;

            nudNota.Value = Convert.ToDecimal(fila.Cells[5].Value);
            cmbAlumno.SelectedValue = fila.Cells[3].Value.ToString();
            cmbMateria.SelectedValue = fila.Cells[1].Value.ToString();
        }

        private void btnCancelarActuCalif_Click(object sender, EventArgs e)
        {
            btnCancelarActuCalif.Visible = false;
            btnActualizarCalificacion.Visible = false;
            btnEliminarCalificacion.Visible = false;
            btnAgregarCalificaciones.Visible = true;
            nudNota.Value = 0;
            cmbAlumno.SelectedValue = 0;
            cmbMateria.SelectedValue = 0;
        }

        private void btnActualizarCalificacion_Click(object sender, EventArgs e)
        {
            if (nudNota.Value < 0 || int.Parse(cmbAlumno.SelectedValue.ToString()) == 0 || int.Parse(cmbMateria.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Calificacion C = new Calificacion();
            C.Notas = nudNota.Value;
            C.IdEstudiante = int.Parse(cmbAlumno.SelectedValue.ToString());
            C.IdMateria = int.Parse(cmbMateria.SelectedValue.ToString());
            C.IdCalificacion = int.Parse(dvgCalificaciones.CurrentRow.Cells[0].Value.ToString());


            if (C.ActualizarCalificaciones() == true)
            {
                CargarCalif();
                nudNota.Value = 0;
                cmbAlumno.SelectedValue = 0;
                cmbMateria.SelectedValue = 0;

            }
            else
            {
                MessageBox.Show("Ocurrio un error al actualizar el registro", "Error");
            }
        }

        private void btnEliminarCalificacion_Click(object sender, EventArgs e)
        {
            int idCalificacion = int.Parse(dvgCalificaciones.CurrentRow.Cells[0].Value.ToString());
            Calificacion C = new Calificacion();
            if (C.EliminarCalificacion(idCalificacion) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                CargarCalif();
                nudNota.Value = 0;
                cmbAlumno.SelectedValue = 0;
                cmbMateria.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia");
            }
        }
    }
  }
    

