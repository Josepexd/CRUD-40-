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
    public partial class frmCalificacionesEstudiante : Form
    {
        public frmCalificacionesEstudiante()
        {
            InitializeComponent();

            CargarCalifEstu();
        }

        private void CalificacionesEstudiante_Load(object sender, EventArgs e)
        {
            CargarCalifEstu();
        }
        private void CargarCalifEstu()
        {
            dvgCalificacionesEstudiante.DataSource = null;
            dvgCalificacionesEstudiante.DataSource = Calificacion.CargarCalifEstu(SesionActual.correo);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashboardPrincipal frmDashboardPrincipal = new frmDashboardPrincipal();
            frmDashboardPrincipal.Show();
            this.Hide();
        }

        private void btnCalificacionesEstu_Click(object sender, EventArgs e)
        {
            frmCalificacionesEstudiante frmCalificacionesEstudiante = new frmCalificacionesEstudiante();
            frmCalificacionesEstudiante.Show();
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
    }
}
