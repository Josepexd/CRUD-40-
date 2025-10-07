namespace Vistas.Formularios
{
    partial class frmMaterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterias));
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnActualizarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.dvgMateria = new System.Windows.Forms.DataGridView();
            this.lblProfesorAsociado = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.pnlPantalladesplegableSalir = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSecion1 = new System.Windows.Forms.Button();
            this.btnCancelarActuMater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMateria)).BeginInit();
            this.pnlPantalladesplegableSalir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEliminarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMateria.Location = new System.Drawing.Point(1492, 334);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(261, 60);
            this.btnEliminarMateria.TabIndex = 27;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = false;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnActualizarMateria
            // 
            this.btnActualizarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnActualizarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMateria.Location = new System.Drawing.Point(747, 334);
            this.btnActualizarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarMateria.Name = "btnActualizarMateria";
            this.btnActualizarMateria.Size = new System.Drawing.Size(261, 60);
            this.btnActualizarMateria.TabIndex = 26;
            this.btnActualizarMateria.Text = "Actualizar";
            this.btnActualizarMateria.UseVisualStyleBackColor = false;
            this.btnActualizarMateria.Click += new System.EventHandler(this.btnActualizarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Location = new System.Drawing.Point(361, 334);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(261, 60);
            this.btnAgregarMateria.TabIndex = 25;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(561, 207);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMateria.MaxLength = 100;
            this.txtNombreMateria.Multiline = true;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(545, 37);
            this.txtNombreMateria.TabIndex = 18;
            this.txtNombreMateria.TextChanged += new System.EventHandler(this.txtNombreMateria_TextChanged);
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(371, 208);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(170, 20);
            this.lblNombreMateria.TabIndex = 17;
            this.lblNombreMateria.Text = "Nombre de la Materia";
            // 
            // dvgMateria
            // 
            this.dvgMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMateria.Location = new System.Drawing.Point(361, 422);
            this.dvgMateria.Margin = new System.Windows.Forms.Padding(4);
            this.dvgMateria.Name = "dvgMateria";
            this.dvgMateria.ReadOnly = true;
            this.dvgMateria.RowHeadersVisible = false;
            this.dvgMateria.RowHeadersWidth = 51;
            this.dvgMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMateria.Size = new System.Drawing.Size(1392, 404);
            this.dvgMateria.TabIndex = 16;
            this.dvgMateria.DoubleClick += new System.EventHandler(this.dvgMateria_DoubleClick);
            // 
            // lblProfesorAsociado
            // 
            this.lblProfesorAsociado.AutoSize = true;
            this.lblProfesorAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblProfesorAsociado.Location = new System.Drawing.Point(472, 277);
            this.lblProfesorAsociado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesorAsociado.Name = "lblProfesorAsociado";
            this.lblProfesorAsociado.Size = new System.Drawing.Size(78, 20);
            this.lblProfesorAsociado.TabIndex = 21;
            this.lblProfesorAsociado.Text = "Profesor:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(561, 271);
            this.cmbProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(545, 24);
            this.cmbProfesor.TabIndex = 28;
            this.cmbProfesor.SelectedIndexChanged += new System.EventHandler(this.cmbProfesor_SelectedIndexChanged);
            // 
            // pnlPantalladesplegableSalir
            // 
            this.pnlPantalladesplegableSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.pnlPantalladesplegableSalir.Controls.Add(this.btnSalir);
            this.pnlPantalladesplegableSalir.Location = new System.Drawing.Point(1588, 187);
            this.pnlPantalladesplegableSalir.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPantalladesplegableSalir.Name = "pnlPantalladesplegableSalir";
            this.pnlPantalladesplegableSalir.Size = new System.Drawing.Size(237, 110);
            this.pnlPantalladesplegableSalir.TabIndex = 29;
            this.pnlPantalladesplegableSalir.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(52, 33);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 52);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Cerrar Sesion";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnProfesores);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMaterias);
            this.panel1.Controls.Add(this.btnEstudiantes);
            this.panel1.Controls.Add(this.btnCalificaciones);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 858);
            this.panel1.TabIndex = 30;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(32, 258);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(177, 58);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnProfesores
            // 
            this.btnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.ForeColor = System.Drawing.Color.Black;
            this.btnProfesores.Location = new System.Drawing.Point(32, 364);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(177, 58);
            this.btnProfesores.TabIndex = 4;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Location = new System.Drawing.Point(32, 588);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(177, 58);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click_1);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Location = new System.Drawing.Point(32, 474);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(177, 58);
            this.btnEstudiantes.TabIndex = 7;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click_1);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Location = new System.Drawing.Point(32, 704);
            this.btnCalificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(177, 58);
            this.btnCalificaciones.TabIndex = 6;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.btnCerrarSecion1);
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1601, 180);
            this.panel2.TabIndex = 31;
            // 
            // btnCerrarSecion1
            // 
            this.btnCerrarSecion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSecion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(158)))));
            this.btnCerrarSecion1.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSecion1.Image")));
            this.btnCerrarSecion1.Location = new System.Drawing.Point(1455, 49);
            this.btnCerrarSecion1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSecion1.Name = "btnCerrarSecion1";
            this.btnCerrarSecion1.Size = new System.Drawing.Size(96, 80);
            this.btnCerrarSecion1.TabIndex = 0;
            this.btnCerrarSecion1.UseVisualStyleBackColor = true;
            this.btnCerrarSecion1.Click += new System.EventHandler(this.btnCerrarSecion1_Click);
            // 
            // btnCancelarActuMater
            // 
            this.btnCancelarActuMater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCancelarActuMater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActuMater.Location = new System.Drawing.Point(1114, 334);
            this.btnCancelarActuMater.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarActuMater.Name = "btnCancelarActuMater";
            this.btnCancelarActuMater.Size = new System.Drawing.Size(261, 60);
            this.btnCancelarActuMater.TabIndex = 32;
            this.btnCancelarActuMater.Text = "Cancelar";
            this.btnCancelarActuMater.UseVisualStyleBackColor = false;
            this.btnCancelarActuMater.Click += new System.EventHandler(this.btnCancelarActuMater_Click);
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1837, 846);
            this.Controls.Add(this.btnCancelarActuMater);
            this.Controls.Add(this.pnlPantalladesplegableSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnActualizarMateria);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.dvgMateria);
            this.Controls.Add(this.lblNombreMateria);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.lblProfesorAsociado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1855, 893);
            this.MinimumSize = new System.Drawing.Size(1855, 893);
            this.Name = "frmMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMateria)).EndInit();
            this.pnlPantalladesplegableSalir.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnActualizarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.DataGridView dvgMateria;
        private System.Windows.Forms.Label lblProfesorAsociado;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Panel pnlPantalladesplegableSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrarSecion1;
        private System.Windows.Forms.Button btnCancelarActuMater;
    }
}