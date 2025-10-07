namespace Vistas.Formularios
{
    partial class frmAgregarProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProfesores));
            this.dvgProfesores = new System.Windows.Forms.DataGridView();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefonoProfesor = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesores = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancelarActuProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).BeginInit();
            this.pnlPantalladesplegableSalir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgProfesores
            // 
            this.dvgProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProfesores.Location = new System.Drawing.Point(219, 355);
            this.dvgProfesores.Name = "dvgProfesores";
            this.dvgProfesores.ReadOnly = true;
            this.dvgProfesores.RowHeadersVisible = false;
            this.dvgProfesores.RowHeadersWidth = 51;
            this.dvgProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProfesores.Size = new System.Drawing.Size(1044, 328);
            this.dvgProfesores.TabIndex = 4;
            this.dvgProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProfesores_CellContentClick);
            this.dvgProfesores.DoubleClick += new System.EventHandler(this.dvgProfesores_DoubleClick);
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.Location = new System.Drawing.Point(216, 181);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(117, 16);
            this.lblNombreProfesor.TabIndex = 5;
            this.lblNombreProfesor.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(339, 180);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 31);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(282, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(339, 233);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(370, 36);
            this.txtCorreo.TabIndex = 8;
            // 
            // lblTelefonoProfesor
            // 
            this.lblTelefonoProfesor.AutoSize = true;
            this.lblTelefonoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelefonoProfesor.Location = new System.Drawing.Point(729, 248);
            this.lblTelefonoProfesor.Name = "lblTelefonoProfesor";
            this.lblTelefonoProfesor.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoProfesor.TabIndex = 9;
            this.lblTelefonoProfesor.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(811, 233);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 31);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPassword.Location = new System.Drawing.Point(729, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(811, 180);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 31);
            this.txtPassword.TabIndex = 12;
            // 
            // btnAgregarProfesores
            // 
            this.btnAgregarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnAgregarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProfesores.Location = new System.Drawing.Point(219, 290);
            this.btnAgregarProfesores.Name = "btnAgregarProfesores";
            this.btnAgregarProfesores.Size = new System.Drawing.Size(196, 49);
            this.btnAgregarProfesores.TabIndex = 13;
            this.btnAgregarProfesores.Text = "Agregar";
            this.btnAgregarProfesores.UseVisualStyleBackColor = false;
            this.btnAgregarProfesores.Click += new System.EventHandler(this.btnAgregarProfesores_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(512, 290);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(196, 49);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(1067, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 49);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlPantalladesplegableSalir
            // 
            this.pnlPantalladesplegableSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.pnlPantalladesplegableSalir.Controls.Add(this.btnSalir);
            this.pnlPantalladesplegableSalir.Location = new System.Drawing.Point(1190, 153);
            this.pnlPantalladesplegableSalir.Name = "pnlPantalladesplegableSalir";
            this.pnlPantalladesplegableSalir.Size = new System.Drawing.Size(178, 89);
            this.pnlPantalladesplegableSalir.TabIndex = 16;
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMaterias);
            this.panel1.Controls.Add(this.btnEstudiantes);
            this.panel1.Controls.Add(this.btnCalificaciones);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 696);
            this.panel1.TabIndex = 17;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(24, 228);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(133, 47);
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
            this.btnProfesores.Location = new System.Drawing.Point(24, 320);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(133, 47);
            this.btnProfesores.TabIndex = 4;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Location = new System.Drawing.Point(24, 517);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(133, 47);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click_1);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Location = new System.Drawing.Point(24, 415);
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
            this.btnCalificaciones.Location = new System.Drawing.Point(24, 617);
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
            this.panel2.Location = new System.Drawing.Point(183, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 146);
            this.panel2.TabIndex = 18;
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
            // btnCancelarActuProf
            // 
            this.btnCancelarActuProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCancelarActuProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActuProf.Location = new System.Drawing.Point(811, 290);
            this.btnCancelarActuProf.Name = "btnCancelarActuProf";
            this.btnCancelarActuProf.Size = new System.Drawing.Size(196, 49);
            this.btnCancelarActuProf.TabIndex = 19;
            this.btnCancelarActuProf.Text = "Cancelar";
            this.btnCancelarActuProf.UseVisualStyleBackColor = false;
            this.btnCancelarActuProf.Click += new System.EventHandler(this.btnCancelarActuProf_Click);
            // 
            // frmAgregarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1379, 694);
            this.Controls.Add(this.btnCancelarActuProf);
            this.Controls.Add(this.pnlPantalladesplegableSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarProfesores);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefonoProfesor);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.dvgProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1395, 733);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1395, 733);
            this.Name = "frmAgregarProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarProfesores";
            this.Load += new System.EventHandler(this.frmAgregarProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).EndInit();
            this.pnlPantalladesplegableSalir.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgProfesores;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefonoProfesor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAgregarProfesores;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelarActuProf;
    }
}