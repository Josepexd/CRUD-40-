namespace Vistas.Formularios
{
    partial class frmCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalificaciones));
            this.pnlPantalladesplegableSalir = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSecion1 = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnCancelarActuCalif = new System.Windows.Forms.Button();
            this.btnEliminarCalificacion = new System.Windows.Forms.Button();
            this.btnActualizarCalificacion = new System.Windows.Forms.Button();
            this.btnAgregarCalificaciones = new System.Windows.Forms.Button();
            this.dvgCalificaciones = new System.Windows.Forms.DataGridView();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.pnlPantalladesplegableSalir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPantalladesplegableSalir
            // 
            this.pnlPantalladesplegableSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.pnlPantalladesplegableSalir.Controls.Add(this.btnSalir);
            this.pnlPantalladesplegableSalir.Location = new System.Drawing.Point(1191, 154);
            this.pnlPantalladesplegableSalir.Name = "pnlPantalladesplegableSalir";
            this.pnlPantalladesplegableSalir.Size = new System.Drawing.Size(178, 89);
            this.pnlPantalladesplegableSalir.TabIndex = 10;
            this.pnlPantalladesplegableSalir.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(39, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 42);
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
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnMaterias);
            this.panel1.Controls.Add(this.btnEstudiantes);
            this.panel1.Controls.Add(this.btnCalificaciones);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 699);
            this.panel1.TabIndex = 11;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(24, 217);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(133, 47);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.ForeColor = System.Drawing.Color.Black;
            this.btnProfesores.Location = new System.Drawing.Point(24, 311);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(133, 47);
            this.btnProfesores.TabIndex = 4;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Location = new System.Drawing.Point(24, 513);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(133, 47);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Location = new System.Drawing.Point(24, 416);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(133, 47);
            this.btnEstudiantes.TabIndex = 7;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click_1);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Location = new System.Drawing.Point(24, 609);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(133, 47);
            this.btnCalificaciones.TabIndex = 6;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.btnCerrarSecion1);
            this.panel2.Location = new System.Drawing.Point(184, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 146);
            this.panel2.TabIndex = 12;
            // 
            // btnCerrarSecion1
            // 
            this.btnCerrarSecion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSecion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(158)))));
            this.btnCerrarSecion1.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSecion1.Image")));
            this.btnCerrarSecion1.Location = new System.Drawing.Point(1078, 42);
            this.btnCerrarSecion1.Name = "btnCerrarSecion1";
            this.btnCerrarSecion1.Size = new System.Drawing.Size(72, 65);
            this.btnCerrarSecion1.TabIndex = 0;
            this.btnCerrarSecion1.UseVisualStyleBackColor = true;
            this.btnCerrarSecion1.Click += new System.EventHandler(this.btnCerrarSecion1_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(346, 221);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(312, 21);
            this.cmbMateria.TabIndex = 14;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(346, 165);
            this.cmbAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(312, 21);
            this.cmbAlumno.TabIndex = 15;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAlumno.Location = new System.Drawing.Point(260, 165);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(52, 16);
            this.lblAlumno.TabIndex = 16;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMateria.Location = new System.Drawing.Point(260, 221);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 17;
            this.lblMateria.Text = "Materia";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNota.Location = new System.Drawing.Point(260, 269);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(68, 16);
            this.lblNota.TabIndex = 18;
            this.lblNota.Text = "Nota Final";
            // 
            // btnCancelarActuCalif
            // 
            this.btnCancelarActuCalif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCancelarActuCalif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActuCalif.Location = new System.Drawing.Point(703, 165);
            this.btnCancelarActuCalif.Name = "btnCancelarActuCalif";
            this.btnCancelarActuCalif.Size = new System.Drawing.Size(196, 49);
            this.btnCancelarActuCalif.TabIndex = 35;
            this.btnCancelarActuCalif.Text = "Cancelar";
            this.btnCancelarActuCalif.UseVisualStyleBackColor = false;
            this.btnCancelarActuCalif.Click += new System.EventHandler(this.btnCancelarActuCalif_Click);
            // 
            // btnEliminarCalificacion
            // 
            this.btnEliminarCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEliminarCalificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCalificacion.Location = new System.Drawing.Point(928, 248);
            this.btnEliminarCalificacion.Name = "btnEliminarCalificacion";
            this.btnEliminarCalificacion.Size = new System.Drawing.Size(196, 49);
            this.btnEliminarCalificacion.TabIndex = 34;
            this.btnEliminarCalificacion.Text = "Eliminar";
            this.btnEliminarCalificacion.UseVisualStyleBackColor = false;
            this.btnEliminarCalificacion.Click += new System.EventHandler(this.btnEliminarCalificacion_Click);
            // 
            // btnActualizarCalificacion
            // 
            this.btnActualizarCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnActualizarCalificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCalificacion.Location = new System.Drawing.Point(928, 165);
            this.btnActualizarCalificacion.Name = "btnActualizarCalificacion";
            this.btnActualizarCalificacion.Size = new System.Drawing.Size(196, 49);
            this.btnActualizarCalificacion.TabIndex = 33;
            this.btnActualizarCalificacion.Text = "Actualizar";
            this.btnActualizarCalificacion.UseVisualStyleBackColor = false;
            this.btnActualizarCalificacion.Click += new System.EventHandler(this.btnActualizarCalificacion_Click);
            // 
            // btnAgregarCalificaciones
            // 
            this.btnAgregarCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnAgregarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCalificaciones.Location = new System.Drawing.Point(703, 248);
            this.btnAgregarCalificaciones.Name = "btnAgregarCalificaciones";
            this.btnAgregarCalificaciones.Size = new System.Drawing.Size(196, 49);
            this.btnAgregarCalificaciones.TabIndex = 32;
            this.btnAgregarCalificaciones.Text = "Agregar";
            this.btnAgregarCalificaciones.UseVisualStyleBackColor = false;
            this.btnAgregarCalificaciones.Click += new System.EventHandler(this.btnAgregarCalificaciones_Click);
            // 
            // dvgCalificaciones
            // 
            this.dvgCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCalificaciones.Location = new System.Drawing.Point(262, 349);
            this.dvgCalificaciones.Name = "dvgCalificaciones";
            this.dvgCalificaciones.ReadOnly = true;
            this.dvgCalificaciones.RowHeadersVisible = false;
            this.dvgCalificaciones.RowHeadersWidth = 51;
            this.dvgCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCalificaciones.Size = new System.Drawing.Size(1044, 328);
            this.dvgCalificaciones.TabIndex = 36;
            this.dvgCalificaciones.DoubleClick += new System.EventHandler(this.dvgCalificaciones_DoubleClick);
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 2;
            this.nudNota.Location = new System.Drawing.Point(346, 269);
            this.nudNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(91, 20);
            this.nudNota.TabIndex = 37;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1378, 687);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.dvgCalificaciones);
            this.Controls.Add(this.btnCancelarActuCalif);
            this.Controls.Add(this.btnEliminarCalificacion);
            this.Controls.Add(this.btnActualizarCalificacion);
            this.Controls.Add(this.btnAgregarCalificaciones);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.pnlPantalladesplegableSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1394, 726);
            this.MinimumSize = new System.Drawing.Size(1394, 726);
            this.Name = "frmCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            this.pnlPantalladesplegableSalir.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPantalladesplegableSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrarSecion1;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnCancelarActuCalif;
        private System.Windows.Forms.Button btnEliminarCalificacion;
        private System.Windows.Forms.Button btnActualizarCalificacion;
        private System.Windows.Forms.Button btnAgregarCalificaciones;
        private System.Windows.Forms.DataGridView dvgCalificaciones;
        private System.Windows.Forms.NumericUpDown nudNota;
    }
}