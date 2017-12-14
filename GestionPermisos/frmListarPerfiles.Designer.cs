namespace GestionPermisos
{
    partial class frmListarPerfiles
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
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.olvPerfiles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsPerfiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPerfiles)).BeginInit();
            this.cmsPerfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfiles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 51);
            this.panel1.TabIndex = 36;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::GestionPermisos.Properties.Resources.refresh;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(749, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(807, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 51);
            this.panel3.TabIndex = 9;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNuevo.FlatAppearance.BorderSize = 3;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(818, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 51);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 51);
            this.panel2.TabIndex = 3;
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle1;
            headerStateStyle2.BackColor = System.Drawing.Color.White;
            headerStateStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerFormatStyle1.Normal = headerStateStyle2;
            this.headerFormatStyle1.Pressed = headerStateStyle3;
            // 
            // olvPerfiles
            // 
            this.olvPerfiles.AllColumns.Add(this.olvColumn1);
            this.olvPerfiles.AllColumns.Add(this.columnHeader11);
            this.olvPerfiles.AllColumns.Add(this.olvColumn3);
            this.olvPerfiles.AllColumns.Add(this.olvColumn4);
            this.olvPerfiles.AllColumns.Add(this.olvColumn5);
            this.olvPerfiles.AllColumns.Add(this.olvColumn6);
            this.olvPerfiles.AllColumns.Add(this.olvColumn7);
            this.olvPerfiles.AllColumns.Add(this.olvColumn8);
            this.olvPerfiles.AllColumns.Add(this.olvColumn9);
            this.olvPerfiles.AllColumns.Add(this.olvColumn10);
            this.olvPerfiles.AllColumns.Add(this.olvColumn11);
            this.olvPerfiles.AllowColumnReorder = true;
            this.olvPerfiles.AllowDrop = true;
            this.olvPerfiles.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvPerfiles.CellEditUseWholeCell = false;
            this.olvPerfiles.CheckedAspectName = "";
            this.olvPerfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.columnHeader11,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn11});
            this.olvPerfiles.ContextMenuStrip = this.cmsPerfiles;
            this.olvPerfiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPerfiles.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvPerfiles.FullRowSelect = true;
            this.olvPerfiles.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvPerfiles.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvPerfiles.HeaderWordWrap = true;
            this.olvPerfiles.HideSelection = false;
            this.olvPerfiles.IncludeColumnHeadersInCopy = true;
            this.olvPerfiles.Location = new System.Drawing.Point(0, 51);
            this.olvPerfiles.Name = "olvPerfiles";
            this.olvPerfiles.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvPerfiles.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvPerfiles.OverlayText.BorderWidth = 2F;
            this.olvPerfiles.OverlayText.Rotation = -20;
            this.olvPerfiles.OverlayText.Text = "";
            this.olvPerfiles.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvPerfiles.ShowCommandMenuOnRightClick = true;
            this.olvPerfiles.ShowGroups = false;
            this.olvPerfiles.ShowHeaderInAllViews = false;
            this.olvPerfiles.ShowImagesOnSubItems = true;
            this.olvPerfiles.ShowItemToolTips = true;
            this.olvPerfiles.Size = new System.Drawing.Size(959, 264);
            this.olvPerfiles.SortGroupItemsByPrimaryColumn = false;
            this.olvPerfiles.TabIndex = 37;
            this.olvPerfiles.UseAlternatingBackColors = true;
            this.olvPerfiles.UseCellFormatEvents = true;
            this.olvPerfiles.UseCompatibleStateImageBehavior = false;
            this.olvPerfiles.UseFilterIndicator = true;
            this.olvPerfiles.UseFiltering = true;
            this.olvPerfiles.UseHotItem = true;
            this.olvPerfiles.UseSubItemCheckBoxes = true;
            this.olvPerfiles.View = System.Windows.Forms.View.Details;
            this.olvPerfiles.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvPerfiles_FormatCell);
            this.olvPerfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvPerfiles_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "NOMBREPERFIL";
            this.olvColumn1.Text = "Nombre Perfil";
            this.olvColumn1.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.AspectName = "CRUD_TIPOS_AUTH";
            this.columnHeader11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.columnHeader11.MaximumWidth = 200;
            this.columnHeader11.MinimumWidth = 100;
            this.columnHeader11.Text = "Mantenedor Tipos";
            this.columnHeader11.ToolTipText = "This is a long tooltip text that should appear when the mouse is over this column" +
    " header but contains absolutely no useful information :)";
            this.columnHeader11.UseInitialLetterForGroup = true;
            this.columnHeader11.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "CRUD_UNIDADES_AUTH";
            this.olvColumn3.Text = "Mantenedor Unidades";
            this.olvColumn3.Width = 150;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "GEN_PERMISOS_AUTH";
            this.olvColumn4.Text = "Generación Permisos";
            this.olvColumn4.Width = 150;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "GEN_RESOLUCIONES_AUTH";
            this.olvColumn5.Text = "Generación Resoluciones";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "AUTH_PERMISOS_AUTH";
            this.olvColumn6.Text = "Autenticar Permisos";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "QRY_PERMISOS_AUTH";
            this.olvColumn7.Text = "Consulta Permisos";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "QRY_RESOLUCIONES_AUTH";
            this.olvColumn8.Text = "Consulta Resoluciones";
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "VER_DOCUMENTOS_AUTH";
            this.olvColumn9.Text = "Verificación Documentos";
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "DOW_DOCUMENTOS_AUTH";
            this.olvColumn10.Text = "Descarga Documentos";
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "GEN_REPORTES_AUTH";
            this.olvColumn11.Text = "Generación Reportes";
            // 
            // cmsPerfiles
            // 
            this.cmsPerfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmEditar});
            this.cmsPerfiles.Name = "cmsUnidades";
            this.cmsPerfiles.Size = new System.Drawing.Size(127, 76);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(126, 22);
            this.tsmActualizar.Text = "Actualizar";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmNueva
            // 
            this.tsmNueva.Name = "tsmNueva";
            this.tsmNueva.Size = new System.Drawing.Size(126, 22);
            this.tsmNueva.Text = "Nuevo";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(126, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // frmListarPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 315);
            this.Controls.Add(this.olvPerfiles);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarPerfiles";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.frmListarPerfiles_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPerfiles)).EndInit();
            this.cmsPerfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.ObjectListView olvPerfiles;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn columnHeader11;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip cmsPerfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
    }
}