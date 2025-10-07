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

    public partial class frmDashboardPrincipal : Form
    {
        public frmDashboardPrincipal()
        {
            InitializeComponent();

            lblUsuario.Text = SesionActual.NombreUsuario;
            //Console.WriteLine(SesionActual.NombreUsuario);
            //Console.WriteLine(SesionActual.RolId);
            //Console.WriteLine(SesionActual.correo);
            CargarMenu();
        }
        private void CargarMenu()
        {
            btnInicio.Visible = true;
            btnEstudiantes.Visible = false;
            btnMaterias.Visible = false;
            btnProfesores.Visible = false;
            btnCalificaciones.Visible = false;
            btnCalificacionesEstu.Visible = false;

            switch (SesionActual.RolId)
            {
                case 1://Admin
                    btnEstudiantes.Visible = true;
                    btnMaterias.Visible = true;
                    btnProfesores.Visible = true;
                    btnCalificaciones.Visible = true;
                    btnCalificacionesEstu.Visible = false;
                    break;

                case 2://Profesor
                    btnCalificaciones.Visible = true;
                    break;

                case 3://Estudiante
                   
                    btnCalificacionesEstu.Visible = true;
                    break;
            }
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

        private void frmDashboardPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCalificacionesEstu_Click(object sender, EventArgs e)
        {
            
            frmCalificacionesEstudiante frmCalificacionesEstudiante = new frmCalificacionesEstudiante();
            frmCalificacionesEstudiante.Show();
            this.Hide();
        }
    }
}
