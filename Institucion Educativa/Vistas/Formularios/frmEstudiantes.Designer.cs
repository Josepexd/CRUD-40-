namespace Vistas.Formularios
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnActualizarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefonoProfesor = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.dvgEstudiante = new System.Windows.Forms.DataGridView();
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
            this.btnCancelarActuEstu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiante)).BeginInit();
            this.pnlPantalladesplegableSalir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnEliminarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(1097, 298);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(196, 49);
            this.btnEliminarEstudiante.TabIndex = 27;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnActualizarEstudiante
            // 
            this.btnActualizarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnActualizarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstudiante.Location = new System.Drawing.Point(538, 298);
            this.btnActualizarEstudiante.Name = "btnActualizarEstudiante";
            this.btnActualizarEstudiante.Size = new System.Drawing.Size(196, 49);
            this.btnActualizarEstudiante.TabIndex = 26;
            this.btnActualizarEstudiante.Text = "Actualizar";
            this.btnActualizarEstudiante.UseVisualStyleBackColor = false;
            this.btnActualizarEstudiante.Click += new System.EventHandler(this.btnActualizarEstudiante_Click);
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnAgregarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(249, 298);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(196, 49);
            this.btnAgregarEstudiante.TabIndex = 25;
            this.btnAgregarEstudiante.Text = "Agregar";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(858, 181);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 31);
            this.txtPassword.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPassword.Location = new System.Drawing.Point(776, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(858, 234);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 31);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefonoProfesor
            // 
            this.lblTelefonoProfesor.AutoSize = true;
            this.lblTelefonoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelefonoProfesor.Location = new System.Drawing.Point(776, 249);
            this.lblTelefonoProfesor.Name = "lblTelefonoProfesor";
            this.lblTelefonoProfesor.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoProfesor.TabIndex = 21;
            this.lblTelefonoProfesor.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(386, 234);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(349, 36);
            this.txtCorreo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(329, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Correo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(386, 182);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(349, 31);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.Location = new System.Drawing.Point(263, 192);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(117, 16);
            this.lblNombreProfesor.TabIndex = 17;
            this.lblNombreProfesor.Text = "Nombre Completo";
            // 
            // dvgEstudiante
            // 
            this.dvgEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEstudiante.Location = new System.Drawing.Point(249, 370);
            this.dvgEstudiante.MaximumSize = new System.Drawing.Size(1044, 328);
            this.dvgEstudiante.MinimumSize = new System.Drawing.Size(1044, 328);
            this.dvgEstudiante.Name = "dvgEstudiante";
            this.dvgEstudiante.ReadOnly = true;
            this.dvgEstudiante.RowHeadersVisible = false;
            this.dvgEstudiante.RowHeadersWidth = 51;
            this.dvgEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEstudiante.Size = new System.Drawing.Size(1044, 328);
            this.dvgEstudiante.TabIndex = 16;
            this.dvgEstudiante.DoubleClick += new System.EventHandler(this.dvgEstudiante_DoubleClick);
            // 
            // pnlPantalladesplegableSalir
            // 
            this.pnlPantalladesplegableSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.pnlPantalladesplegableSalir.Controls.Add(this.btnSalir);
            this.pnlPantalladesplegableSalir.Location = new System.Drawing.Point(1197, 152);
            this.pnlPantalladesplegableSalir.Name = "pnlPantalladesplegableSalir";
            this.pnlPantalladesplegableSalir.Size = new System.Drawing.Size(178, 89);
            this.pnlPantalladesplegableSalir.TabIndex = 28;
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 698);
            this.panel1.TabIndex = 29;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(24, 218);
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
            this.btnProfesores.Location = new System.Drawing.Point(24, 316);
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
            this.btnMaterias.Location = new System.Drawing.Point(24, 519);
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
            this.btnEstudiantes.Location = new System.Drawing.Point(24, 412);
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
            this.btnCalificaciones.Location = new System.Drawing.Point(24, 614);
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
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 146);
            this.panel2.TabIndex = 30;
            // 
            // btnCerrarSecion1
            // 
            this.btnCerrarSecion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSecion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(158)))));
            this.btnCerrarSecion1.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSecion1.Image")));
            this.btnCerrarSecion1.Location = new System.Drawing.Point(1085, 44);
            this.btnCerrarSecion1.Name = "btnCerrarSecion1";
            this.btnCerrarSecion1.Size = new System.Drawing.Size(72, 65);
            this.btnCerrarSecion1.TabIndex = 0;
            this.btnCerrarSecion1.UseVisualStyleBackColor = true;
            this.btnCerrarSecion1.Click += new System.EventHandler(this.btnCerrarSecion1_Click);
            // 
            // btnCancelarActuEstu
            // 
            this.btnCancelarActuEstu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnCancelarActuEstu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActuEstu.Location = new System.Drawing.Point(858, 298);
            this.btnCancelarActuEstu.Name = "btnCancelarActuEstu";
            this.btnCancelarActuEstu.Size = new System.Drawing.Size(196, 49);
            this.btnCancelarActuEstu.TabIndex = 31;
            this.btnCancelarActuEstu.Text = "Cancelar";
            this.btnCancelarActuEstu.UseVisualStyleBackColor = false;
            this.btnCancelarActuEstu.Click += new System.EventHandler(this.btnCancelarActuEstu_Click);
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1379, 694);
            this.Controls.Add(this.btnCancelarActuEstu);
            this.Controls.Add(this.pnlPantalladesplegableSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnActualizarEstudiante);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefonoProfesor);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.dvgEstudiante);
            this.MaximumSize = new System.Drawing.Size(1395, 733);
            this.MinimumSize = new System.Drawing.Size(1395, 733);
            this.Name = "frmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xxx";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiante)).EndInit();
            this.pnlPantalladesplegableSalir.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnActualizarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefonoProfesor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.DataGridView dvgEstudiante;
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
        private System.Windows.Forms.Button btnCancelarActuEstu;
    }
}