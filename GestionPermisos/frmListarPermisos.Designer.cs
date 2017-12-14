namespace GestionPermisos
{
    partial class frmListarPermisos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.olvPermisos = new BrightIdeasSoftware.ObjectListView();
            this.columnHeader11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsPermisos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportarPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportarXML = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).BeginInit();
            this.cmsPermisos.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(846, 51);
            this.panel1.TabIndex = 34;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::GestionPermisos.Properties.Resources.refresh;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(636, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(694, 0);
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
            this.btnNuevo.Location = new System.Drawing.Point(705, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 51);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis Permisos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // olvPermisos
            // 
            this.olvPermisos.AllColumns.Add(this.columnHeader11);
            this.olvPermisos.AllColumns.Add(this.olvColumn1);
            this.olvPermisos.AllColumns.Add(this.olvColumn5);
            this.olvPermisos.AllColumns.Add(this.olvColumn6);
            this.olvPermisos.AllColumns.Add(this.olvColumn2);
            this.olvPermisos.AllColumns.Add(this.olvColumn3);
            this.olvPermisos.AllowColumnReorder = true;
            this.olvPermisos.AllowDrop = true;
            this.olvPermisos.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvPermisos.CellEditUseWholeCell = false;
            this.olvPermisos.CheckedAspectName = "";
            this.olvPermisos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.olvColumn1,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn2,
            this.olvColumn3});
            this.olvPermisos.ContextMenuStrip = this.cmsPermisos;
            this.olvPermisos.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPermisos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvPermisos.FullRowSelect = true;
            this.olvPermisos.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvPermisos.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvPermisos.HeaderWordWrap = true;
            this.olvPermisos.HideSelection = false;
            this.olvPermisos.IncludeColumnHeadersInCopy = true;
            this.olvPermisos.Location = new System.Drawing.Point(0, 51);
            this.olvPermisos.Name = "olvPermisos";
            this.olvPermisos.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvPermisos.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvPermisos.OverlayText.BorderWidth = 2F;
            this.olvPermisos.OverlayText.Rotation = -20;
            this.olvPermisos.OverlayText.Text = "";
            this.olvPermisos.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvPermisos.ShowCommandMenuOnRightClick = true;
            this.olvPermisos.ShowGroups = false;
            this.olvPermisos.ShowHeaderInAllViews = false;
            this.olvPermisos.ShowItemToolTips = true;
            this.olvPermisos.Size = new System.Drawing.Size(846, 315);
            this.olvPermisos.SortGroupItemsByPrimaryColumn = false;
            this.olvPermisos.TabIndex = 35;
            this.olvPermisos.UseAlternatingBackColors = true;
            this.olvPermisos.UseCellFormatEvents = true;
            this.olvPermisos.UseCompatibleStateImageBehavior = false;
            this.olvPermisos.UseFilterIndicator = true;
            this.olvPermisos.UseFiltering = true;
            this.olvPermisos.UseHotItem = true;
            this.olvPermisos.View = System.Windows.Forms.View.Details;
            this.olvPermisos.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvPermisos_FormatCell);
            this.olvPermisos.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvPermisos_FormatRow);
            this.olvPermisos.SelectedIndexChanged += new System.EventHandler(this.olvPermisos_SelectedIndexChanged);
            this.olvPermisos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvPermisos_MouseDoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.AspectName = "FECHAEMISION";
            this.columnHeader11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.columnHeader11.MaximumWidth = 200;
            this.columnHeader11.MinimumWidth = 100;
            this.columnHeader11.Text = "Fecha Solicitud";
            this.columnHeader11.ToolTipText = "This is a long tooltip text that should appear when the mouse is over this column" +
    " header but contains absolutely no useful information :)";
            this.columnHeader11.UseInitialLetterForGroup = true;
            this.columnHeader11.Width = 160;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ID_PERMISO";
            this.olvColumn1.Text = "Id Permiso";
            this.olvColumn1.Width = 280;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "MOTIVO";
            this.olvColumn5.Text = "Motivo";
            this.olvColumn5.Width = 113;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "DETALLEPERMISO";
            this.olvColumn6.Text = "Tipo Permiso";
            this.olvColumn6.Width = 115;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "DIAS";
            this.olvColumn2.Text = "Dias Permiso";
            this.olvColumn2.Width = 104;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "ESTADO";
            this.olvColumn3.Text = "Estado";
            this.olvColumn3.Width = 100;
            // 
            // cmsPermisos
            // 
            this.cmsPermisos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmEditar,
            this.tsmExportarPDF,
            this.tsmExportarXML});
            this.cmsPermisos.Name = "cmsUnidades";
            this.cmsPermisos.Size = new System.Drawing.Size(145, 120);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(144, 22);
            this.tsmActualizar.Text = "Actualizar";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmNueva
            // 
            this.tsmNueva.Name = "tsmNueva";
            this.tsmNueva.Size = new System.Drawing.Size(144, 22);
            this.tsmNueva.Text = "Nuevo";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(144, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // tsmExportarPDF
            // 
            this.tsmExportarPDF.Name = "tsmExportarPDF";
            this.tsmExportarPDF.Size = new System.Drawing.Size(144, 22);
            this.tsmExportarPDF.Text = "Exportar PDF";
            this.tsmExportarPDF.Click += new System.EventHandler(this.tsmExportarPDF_Click);
            // 
            // tsmExportarXML
            // 
            this.tsmExportarXML.Name = "tsmExportarXML";
            this.tsmExportarXML.Size = new System.Drawing.Size(144, 22);
            this.tsmExportarXML.Text = "Exportar XML";
            this.tsmExportarXML.Click += new System.EventHandler(this.tsmExportarXML_Click);
            // 
            // frmListarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 366);
            this.Controls.Add(this.olvPermisos);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarPermisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.frmListarPermisos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).EndInit();
            this.cmsPermisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.ObjectListView olvPermisos;
        private BrightIdeasSoftware.OLVColumn columnHeader11;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.ContextMenuStrip cmsPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmExportarPDF;
        private System.Windows.Forms.ToolStripMenuItem tsmExportarXML;
    }
}