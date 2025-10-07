namespace Vistas.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInicioDeSesion = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPasswordInicio = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirSistema = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(33, 337);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(33, 244);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 22);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblInicioDeSesion
            // 
            this.lblInicioDeSesion.AutoSize = true;
            this.lblInicioDeSesion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioDeSesion.ForeColor = System.Drawing.Color.Black;
            this.lblInicioDeSesion.Location = new System.Drawing.Point(125, 91);
            this.lblInicioDeSesion.Name = "lblInicioDeSesion";
            this.lblInicioDeSesion.Size = new System.Drawing.Size(115, 22);
            this.lblInicioDeSesion.TabIndex = 1;
            this.lblInicioDeSesion.Text = "iniciar sesion";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUsuario.Location = new System.Drawing.Point(37, 269);
            this.txtNombreUsuario.Multiline = true;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(288, 33);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtPasswordInicio
            // 
            this.txtPasswordInicio.Location = new System.Drawing.Point(37, 362);
            this.txtPasswordInicio.Multiline = true;
            this.txtPasswordInicio.Name = "txtPasswordInicio";
            this.txtPasswordInicio.PasswordChar = '*';
            this.txtPasswordInicio.Size = new System.Drawing.Size(285, 32);
            this.txtPasswordInicio.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(112, 461);
            this.btnIngresar.MaximumSize = new System.Drawing.Size(128, 39);
            this.btnIngresar.MinimumSize = new System.Drawing.Size(128, 39);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(128, 39);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenido.Location = new System.Drawing.Point(106, 60);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(150, 31);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.btnSalirSistema);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblInicioDeSesion);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.txtPasswordInicio);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 567);
            this.panel1.TabIndex = 6;
            // 
            // btnSalirSistema
            // 
            this.btnSalirSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.btnSalirSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirSistema.Image")));
            this.btnSalirSistema.Location = new System.Drawing.Point(297, 14);
            this.btnSalirSistema.Name = "btnSalirSistema";
            this.btnSalirSistema.Size = new System.Drawing.Size(42, 46);
            this.btnSalirSistema.TabIndex = 6;
            this.btnSalirSistema.UseVisualStyleBackColor = false;
            this.btnSalirSistema.Click += new System.EventHandler(this.btnSalirSistema_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(408, 598);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInicioDeSesion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPasswordInicio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirSistema;
    }
}