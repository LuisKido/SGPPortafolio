namespace GestionPermisos
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.txtPass = new CustomTransparentPanel.CueTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUsuario = new CustomTransparentPanel.CueTextbox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNombreapp = new System.Windows.Forms.Label();
            this.lblMunipalidad = new System.Windows.Forms.Label();
            this.pnlBackGround.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackGround.Controls.Add(this.pnlLogin);
            this.pnlBackGround.Controls.Add(this.pnlTop);
            this.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(1264, 681);
            this.pnlBackGround.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLogin.Controls.Add(this.labelError);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.panel6);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.btnIniciarSesion);
            this.pnlLogin.Controls.Add(this.panel5);
            this.pnlLogin.Controls.Add(this.panel4);
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.picLogin);
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Location = new System.Drawing.Point(502, 149);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(293, 335);
            this.pnlLogin.TabIndex = 14;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(29, 234);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(233, 18);
            this.labelError.TabIndex = 26;
            this.labelError.Text = "Usuario o Contraseña Incorrectos";
            this.labelError.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Cue = "Contraseña";
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(25, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(243, 29);
            this.txtPass.TabIndex = 25;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(25, 171);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 20);
            this.panel6.TabIndex = 22;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cue = "Usuario";
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(25, 142);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 29);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(25, 265);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(243, 40);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(25, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 30);
            this.panel5.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(25, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 29);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(268, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 222);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 222);
            this.panel2.TabIndex = 18;
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogin.Image = global::GestionPermisos.Properties.Resources.login;
            this.picLogin.Location = new System.Drawing.Point(0, 34);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(293, 79);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 16;
            this.picLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 34);
            this.panel1.TabIndex = 17;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblNombreapp);
            this.pnlTop.Controls.Add(this.lblMunipalidad);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1264, 100);
            this.pnlTop.TabIndex = 8;
            // 
            // lblNombreapp
            // 
            this.lblNombreapp.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreapp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreapp.ForeColor = System.Drawing.Color.White;
            this.lblNombreapp.Location = new System.Drawing.Point(0, 45);
            this.lblNombreapp.Name = "lblNombreapp";
            this.lblNombreapp.Size = new System.Drawing.Size(1264, 45);
            this.lblNombreapp.TabIndex = 2;
            this.lblNombreapp.Text = "Sistema de Solicitudes de Permisos";
            this.lblNombreapp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMunipalidad
            // 
            this.lblMunipalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblMunipalidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMunipalidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunipalidad.ForeColor = System.Drawing.Color.White;
            this.lblMunipalidad.Location = new System.Drawing.Point(0, 0);
            this.lblMunipalidad.Name = "lblMunipalidad";
            this.lblMunipalidad.Size = new System.Drawing.Size(1264, 45);
            this.lblMunipalidad.TabIndex = 1;
            this.lblMunipalidad.Text = "Ilustre Municipalidad de Vista Hermosa";
            this.lblMunipalidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GestionPermisos.Properties.Resources.vista_hermosa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Permisos";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMunipalidad;
        private System.Windows.Forms.Label lblNombreapp;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private CustomTransparentPanel.CueTextbox txtPass;
        private CustomTransparentPanel.CueTextbox txtUsuario;
        private System.Windows.Forms.Label labelError;
    }
}

