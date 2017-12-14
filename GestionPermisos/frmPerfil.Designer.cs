namespace GestionPermisos
{
    partial class frmPerfil
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleform = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkconRes = new System.Windows.Forms.CheckBox();
            this.chkgrepo = new System.Windows.Forms.CheckBox();
            this.chkdesDoc = new System.Windows.Forms.CheckBox();
            this.chkverDoc = new System.Windows.Forms.CheckBox();
            this.chkconPer = new System.Windows.Forms.CheckBox();
            this.chkAuthPer = new System.Windows.Forms.CheckBox();
            this.chkgRes = new System.Windows.Forms.CheckBox();
            this.chkgPer = new System.Windows.Forms.CheckBox();
            this.chkmUnidades = new System.Windows.Forms.CheckBox();
            this.chkmTipos = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(101, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 33);
            this.txtNombre.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(404, 331);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 33);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(307, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitleform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 46);
            this.panel1.TabIndex = 9;
            // 
            // lblTitleform
            // 
            this.lblTitleform.AutoSize = true;
            this.lblTitleform.BackColor = System.Drawing.Color.White;
            this.lblTitleform.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleform.ForeColor = System.Drawing.Color.Black;
            this.lblTitleform.Location = new System.Drawing.Point(5, 12);
            this.lblTitleform.Name = "lblTitleform";
            this.lblTitleform.Size = new System.Drawing.Size(88, 19);
            this.lblTitleform.TabIndex = 5;
            this.lblTitleform.Text = "Datos Perfil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkconRes);
            this.groupBox1.Controls.Add(this.chkgrepo);
            this.groupBox1.Controls.Add(this.chkdesDoc);
            this.groupBox1.Controls.Add(this.chkverDoc);
            this.groupBox1.Controls.Add(this.chkconPer);
            this.groupBox1.Controls.Add(this.chkAuthPer);
            this.groupBox1.Controls.Add(this.chkgRes);
            this.groupBox1.Controls.Add(this.chkgPer);
            this.groupBox1.Controls.Add(this.chkmUnidades);
            this.groupBox1.Controls.Add(this.chkmTipos);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso";
            // 
            // chkconRes
            // 
            this.chkconRes.AutoSize = true;
            this.chkconRes.Location = new System.Drawing.Point(254, 55);
            this.chkconRes.Name = "chkconRes";
            this.chkconRes.Size = new System.Drawing.Size(179, 23);
            this.chkconRes.TabIndex = 9;
            this.chkconRes.Text = "Consulta Resoluciones";
            this.chkconRes.UseVisualStyleBackColor = true;
            // 
            // chkgrepo
            // 
            this.chkgrepo.AutoSize = true;
            this.chkgrepo.Location = new System.Drawing.Point(254, 142);
            this.chkgrepo.Name = "chkgrepo";
            this.chkgrepo.Size = new System.Drawing.Size(171, 23);
            this.chkgrepo.TabIndex = 8;
            this.chkgrepo.Text = "Generación Reportes";
            this.chkgrepo.UseVisualStyleBackColor = true;
            // 
            // chkdesDoc
            // 
            this.chkdesDoc.AutoSize = true;
            this.chkdesDoc.Location = new System.Drawing.Point(254, 113);
            this.chkdesDoc.Name = "chkdesDoc";
            this.chkdesDoc.Size = new System.Drawing.Size(179, 23);
            this.chkdesDoc.TabIndex = 7;
            this.chkdesDoc.Text = "Descarga Documentos";
            this.chkdesDoc.UseVisualStyleBackColor = true;
            // 
            // chkverDoc
            // 
            this.chkverDoc.AutoSize = true;
            this.chkverDoc.Location = new System.Drawing.Point(254, 84);
            this.chkverDoc.Name = "chkverDoc";
            this.chkverDoc.Size = new System.Drawing.Size(197, 23);
            this.chkverDoc.TabIndex = 6;
            this.chkverDoc.Text = "Verificación Documentos";
            this.chkverDoc.UseVisualStyleBackColor = true;
            // 
            // chkconPer
            // 
            this.chkconPer.AutoSize = true;
            this.chkconPer.Location = new System.Drawing.Point(254, 26);
            this.chkconPer.Name = "chkconPer";
            this.chkconPer.Size = new System.Drawing.Size(152, 23);
            this.chkconPer.TabIndex = 5;
            this.chkconPer.Text = "Consulta Permisos";
            this.chkconPer.UseVisualStyleBackColor = true;
            // 
            // chkAuthPer
            // 
            this.chkAuthPer.AutoSize = true;
            this.chkAuthPer.Location = new System.Drawing.Point(6, 142);
            this.chkAuthPer.Name = "chkAuthPer";
            this.chkAuthPer.Size = new System.Drawing.Size(165, 23);
            this.chkAuthPer.TabIndex = 4;
            this.chkAuthPer.Text = "Autenticar Permisos";
            this.chkAuthPer.UseVisualStyleBackColor = true;
            // 
            // chkgRes
            // 
            this.chkgRes.AutoSize = true;
            this.chkgRes.Location = new System.Drawing.Point(6, 113);
            this.chkgRes.Name = "chkgRes";
            this.chkgRes.Size = new System.Drawing.Size(198, 23);
            this.chkgRes.TabIndex = 3;
            this.chkgRes.Text = "Generación Resoluciones";
            this.chkgRes.UseVisualStyleBackColor = true;
            // 
            // chkgPer
            // 
            this.chkgPer.AutoSize = true;
            this.chkgPer.Location = new System.Drawing.Point(6, 84);
            this.chkgPer.Name = "chkgPer";
            this.chkgPer.Size = new System.Drawing.Size(171, 23);
            this.chkgPer.TabIndex = 2;
            this.chkgPer.Text = "Generación Permisos";
            this.chkgPer.UseVisualStyleBackColor = true;
            // 
            // chkmUnidades
            // 
            this.chkmUnidades.AutoSize = true;
            this.chkmUnidades.Location = new System.Drawing.Point(6, 55);
            this.chkmUnidades.Name = "chkmUnidades";
            this.chkmUnidades.Size = new System.Drawing.Size(181, 23);
            this.chkmUnidades.TabIndex = 1;
            this.chkmUnidades.Text = "Mantenedor Unidades";
            this.chkmUnidades.UseVisualStyleBackColor = true;
            // 
            // chkmTipos
            // 
            this.chkmTipos.AutoSize = true;
            this.chkmTipos.Location = new System.Drawing.Point(6, 26);
            this.chkmTipos.Name = "chkmTipos";
            this.chkmTipos.Size = new System.Drawing.Size(154, 23);
            this.chkmTipos.TabIndex = 0;
            this.chkmTipos.Text = "Mantenedor Tipos";
            this.chkmTipos.UseVisualStyleBackColor = true;
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleform;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkgrepo;
        private System.Windows.Forms.CheckBox chkdesDoc;
        private System.Windows.Forms.CheckBox chkverDoc;
        private System.Windows.Forms.CheckBox chkconPer;
        private System.Windows.Forms.CheckBox chkAuthPer;
        private System.Windows.Forms.CheckBox chkgRes;
        private System.Windows.Forms.CheckBox chkgPer;
        private System.Windows.Forms.CheckBox chkmUnidades;
        private System.Windows.Forms.CheckBox chkmTipos;
        private System.Windows.Forms.CheckBox chkconRes;
    }
}