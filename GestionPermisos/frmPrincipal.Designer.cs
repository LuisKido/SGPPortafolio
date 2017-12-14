namespace GestionPermisos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneradorReportes = new System.Windows.Forms.Button();
            this.btnVerificadorDocumentos = new System.Windows.Forms.Button();
            this.btnResoluciones = new System.Windows.Forms.Button();
            this.btnGestionPermisos = new System.Windows.Forms.Button();
            this.btnMisPermisos = new System.Windows.Forms.Button();
            this.btnPerfiles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnTiposPermisos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsUsuario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCambiarPass = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.cmsUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(248)))));
            this.pnlTop.Controls.Add(this.lblCargo);
            this.pnlTop.Controls.Add(this.lblNombreUsuario);
            this.pnlTop.Controls.Add(this.panel6);
            this.pnlTop.Controls.Add(this.panel5);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.panel7);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(304, 107);
            this.pnlTop.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(97, 60);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(207, 29);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Funcionario";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(97, 20);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(207, 40);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Juan Perez";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(97, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 20);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(82, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 107);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GestionPermisos.Properties.Resources.no_image_user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 107);
            this.panel7.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGeneradorReportes);
            this.panel1.Controls.Add(this.btnVerificadorDocumentos);
            this.panel1.Controls.Add(this.btnResoluciones);
            this.panel1.Controls.Add(this.btnGestionPermisos);
            this.panel1.Controls.Add(this.btnMisPermisos);
            this.panel1.Controls.Add(this.btnPerfiles);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnUnidades);
            this.panel1.Controls.Add(this.btnTiposPermisos);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 681);
            this.panel1.TabIndex = 3;
            // 
            // btnGeneradorReportes
            // 
            this.btnGeneradorReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneradorReportes.FlatAppearance.BorderSize = 0;
            this.btnGeneradorReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneradorReportes.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneradorReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnGeneradorReportes.Location = new System.Drawing.Point(30, 465);
            this.btnGeneradorReportes.Name = "btnGeneradorReportes";
            this.btnGeneradorReportes.Size = new System.Drawing.Size(274, 41);
            this.btnGeneradorReportes.TabIndex = 14;
            this.btnGeneradorReportes.Text = "Generador de Reportes";
            this.btnGeneradorReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneradorReportes.UseVisualStyleBackColor = true;
            this.btnGeneradorReportes.Click += new System.EventHandler(this.btnGeneradorReportes_Click);
            // 
            // btnVerificadorDocumentos
            // 
            this.btnVerificadorDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerificadorDocumentos.FlatAppearance.BorderSize = 0;
            this.btnVerificadorDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificadorDocumentos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificadorDocumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnVerificadorDocumentos.Location = new System.Drawing.Point(30, 424);
            this.btnVerificadorDocumentos.Name = "btnVerificadorDocumentos";
            this.btnVerificadorDocumentos.Size = new System.Drawing.Size(274, 41);
            this.btnVerificadorDocumentos.TabIndex = 10;
            this.btnVerificadorDocumentos.Text = "Verificador documentos";
            this.btnVerificadorDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificadorDocumentos.UseVisualStyleBackColor = true;
            this.btnVerificadorDocumentos.Click += new System.EventHandler(this.btnVerificadorDocumentos_Click);
            // 
            // btnResoluciones
            // 
            this.btnResoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResoluciones.FlatAppearance.BorderSize = 0;
            this.btnResoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResoluciones.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResoluciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnResoluciones.Location = new System.Drawing.Point(30, 383);
            this.btnResoluciones.Name = "btnResoluciones";
            this.btnResoluciones.Size = new System.Drawing.Size(274, 41);
            this.btnResoluciones.TabIndex = 9;
            this.btnResoluciones.Text = "Resoluciones";
            this.btnResoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResoluciones.UseVisualStyleBackColor = true;
            this.btnResoluciones.Click += new System.EventHandler(this.btnResoluciones_Click);
            // 
            // btnGestionPermisos
            // 
            this.btnGestionPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPermisos.FlatAppearance.BorderSize = 0;
            this.btnGestionPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPermisos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnGestionPermisos.Location = new System.Drawing.Point(30, 342);
            this.btnGestionPermisos.Name = "btnGestionPermisos";
            this.btnGestionPermisos.Size = new System.Drawing.Size(274, 41);
            this.btnGestionPermisos.TabIndex = 8;
            this.btnGestionPermisos.Text = "Gestion Permisos";
            this.btnGestionPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPermisos.UseVisualStyleBackColor = true;
            this.btnGestionPermisos.Click += new System.EventHandler(this.btnGestionPermisos_Click);
            // 
            // btnMisPermisos
            // 
            this.btnMisPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisPermisos.FlatAppearance.BorderSize = 0;
            this.btnMisPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPermisos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnMisPermisos.Location = new System.Drawing.Point(30, 301);
            this.btnMisPermisos.Name = "btnMisPermisos";
            this.btnMisPermisos.Size = new System.Drawing.Size(274, 41);
            this.btnMisPermisos.TabIndex = 7;
            this.btnMisPermisos.Text = "Mis Permisos";
            this.btnMisPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPermisos.UseVisualStyleBackColor = true;
            this.btnMisPermisos.Click += new System.EventHandler(this.btnMisPermisos_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfiles.FlatAppearance.BorderSize = 0;
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnPerfiles.Location = new System.Drawing.Point(30, 260);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(274, 41);
            this.btnPerfiles.TabIndex = 6;
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfiles.UseVisualStyleBackColor = true;
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnUsuarios.Location = new System.Drawing.Point(30, 219);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(274, 41);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnidades.FlatAppearance.BorderSize = 0;
            this.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidades.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnUnidades.Location = new System.Drawing.Point(30, 178);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(274, 41);
            this.btnUnidades.TabIndex = 4;
            this.btnUnidades.Text = "Unidades";
            this.btnUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // btnTiposPermisos
            // 
            this.btnTiposPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiposPermisos.FlatAppearance.BorderSize = 0;
            this.btnTiposPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposPermisos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.btnTiposPermisos.Location = new System.Drawing.Point(30, 137);
            this.btnTiposPermisos.Name = "btnTiposPermisos";
            this.btnTiposPermisos.Size = new System.Drawing.Size(274, 41);
            this.btnTiposPermisos.TabIndex = 3;
            this.btnTiposPermisos.Text = "Tipos Permisos";
            this.btnTiposPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposPermisos.UseVisualStyleBackColor = true;
            this.btnTiposPermisos.Click += new System.EventHandler(this.btnTiposPermisos_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(15, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 544);
            this.panel4.TabIndex = 13;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.lblDashboard.Location = new System.Drawing.Point(15, 107);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(117, 30);
            this.lblDashboard.TabIndex = 11;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 574);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblFechaHora);
            this.panel2.Controls.Add(this.btnDesconectar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 107);
            this.panel2.TabIndex = 4;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(781, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(38, 40);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "...";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDesconectar.FlatAppearance.BorderSize = 3;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(819, 0);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(141, 107);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.Location = new System.Drawing.Point(304, 107);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(960, 574);
            this.pnlWelcome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 574);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bienvenido a nuestro nuevo sistema \r\ncentralizado de generación de permisos.\r\n \r\n" +
    "Para continuar seleccione una opción.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsUsuario
            // 
            this.cmsUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCambiarPass});
            this.cmsUsuario.Name = "cmsUsuario";
            this.cmsUsuario.Size = new System.Drawing.Size(183, 26);
            // 
            // tsmCambiarPass
            // 
            this.tsmCambiarPass.Name = "tsmCambiarPass";
            this.tsmCambiarPass.Size = new System.Drawing.Size(182, 22);
            this.tsmCambiarPass.Text = "Cambiar Contraseña";
            this.tsmCambiarPass.Click += new System.EventHandler(this.tsmCambiarPass_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionador Permisos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.cmsUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnVerificadorDocumentos;
        public System.Windows.Forms.Button btnResoluciones;
        public System.Windows.Forms.Button btnGestionPermisos;
        public System.Windows.Forms.Button btnMisPermisos;
        public System.Windows.Forms.Button btnPerfiles;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.Button btnUnidades;
        public System.Windows.Forms.Button btnTiposPermisos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.ContextMenuStrip cmsUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarPass;
        public System.Windows.Forms.Button btnGeneradorReportes;
    }
}