namespace GestionPermisos
{
    partial class frmListarResoluciones
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
            BrightIdeasSoftware.OLVColumn olvColumn4;
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            this.olvResoluciones = new BrightIdeasSoftware.ObjectListView();
            this.columnHeader11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsResoluciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportarXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportarPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvResoluciones)).BeginInit();
            this.cmsResoluciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvColumn4
            // 
            olvColumn4.AspectName = "ID_RESOLUCION";
            olvColumn4.Text = "ID Resolución";
            olvColumn4.Width = 198;
            // 
            // olvResoluciones
            // 
            this.olvResoluciones.AllColumns.Add(olvColumn4);
            this.olvResoluciones.AllColumns.Add(this.columnHeader11);
            this.olvResoluciones.AllowColumnReorder = true;
            this.olvResoluciones.AllowDrop = true;
            this.olvResoluciones.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvResoluciones.CellEditUseWholeCell = false;
            this.olvResoluciones.CheckedAspectName = "";
            this.olvResoluciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            olvColumn4,
            this.columnHeader11});
            this.olvResoluciones.ContextMenuStrip = this.cmsResoluciones;
            this.olvResoluciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvResoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvResoluciones.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvResoluciones.FullRowSelect = true;
            this.olvResoluciones.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvResoluciones.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvResoluciones.HeaderWordWrap = true;
            this.olvResoluciones.HideSelection = false;
            this.olvResoluciones.IncludeColumnHeadersInCopy = true;
            this.olvResoluciones.Location = new System.Drawing.Point(0, 51);
            this.olvResoluciones.Name = "olvResoluciones";
            this.olvResoluciones.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvResoluciones.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvResoluciones.OverlayText.BorderWidth = 2F;
            this.olvResoluciones.OverlayText.Rotation = -20;
            this.olvResoluciones.OverlayText.Text = "";
            this.olvResoluciones.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvResoluciones.ShowCommandMenuOnRightClick = true;
            this.olvResoluciones.ShowGroups = false;
            this.olvResoluciones.ShowHeaderInAllViews = false;
            this.olvResoluciones.ShowItemToolTips = true;
            this.olvResoluciones.Size = new System.Drawing.Size(721, 236);
            this.olvResoluciones.SortGroupItemsByPrimaryColumn = false;
            this.olvResoluciones.TabIndex = 37;
            this.olvResoluciones.UseAlternatingBackColors = true;
            this.olvResoluciones.UseCellFormatEvents = true;
            this.olvResoluciones.UseCompatibleStateImageBehavior = false;
            this.olvResoluciones.UseFilterIndicator = true;
            this.olvResoluciones.UseFiltering = true;
            this.olvResoluciones.UseHotItem = true;
            this.olvResoluciones.View = System.Windows.Forms.View.Details;
            this.olvResoluciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvResoluciones_MouseDoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.AspectName = "RESOLUCION";
            this.columnHeader11.FillsFreeSpace = true;
            this.columnHeader11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.columnHeader11.MaximumWidth = 200;
            this.columnHeader11.MinimumWidth = 100;
            this.columnHeader11.Text = "Detalle Resolución";
            this.columnHeader11.ToolTipText = "";
            this.columnHeader11.UseInitialLetterForGroup = true;
            this.columnHeader11.Width = 200;
            // 
            // cmsResoluciones
            // 
            this.cmsResoluciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmAbrir,
            this.tsmExportarXML,
            this.tsmExportarPDF});
            this.cmsResoluciones.Name = "cmsUnidades";
            this.cmsResoluciones.Size = new System.Drawing.Size(145, 120);
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
            this.tsmNueva.Text = "Nueva";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmAbrir
            // 
            this.tsmAbrir.Name = "tsmAbrir";
            this.tsmAbrir.Size = new System.Drawing.Size(144, 22);
            this.tsmAbrir.Text = "Abrir";
            this.tsmAbrir.Click += new System.EventHandler(this.tsmAbrir_Click);
            // 
            // tsmExportarXML
            // 
            this.tsmExportarXML.Name = "tsmExportarXML";
            this.tsmExportarXML.Size = new System.Drawing.Size(144, 22);
            this.tsmExportarXML.Text = "Exportar XML";
            this.tsmExportarXML.Click += new System.EventHandler(this.tsmExportarXML_Click);
            // 
            // tsmExportarPDF
            // 
            this.tsmExportarPDF.Name = "tsmExportarPDF";
            this.tsmExportarPDF.Size = new System.Drawing.Size(144, 22);
            this.tsmExportarPDF.Text = "Exportar PDF";
            this.tsmExportarPDF.Click += new System.EventHandler(this.tsmExportarPDF_Click);
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle1;
            headerStateStyle2.BackColor = System.Drawing.Color.White;
            headerStateStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerFormatStyle1.Normal = headerStateStyle2;
            this.headerFormatStyle1.Pressed = headerStateStyle3;
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
            this.panel1.Size = new System.Drawing.Size(721, 51);
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
            this.btnActualizar.Location = new System.Drawing.Point(485, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(543, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 51);
            this.panel3.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNuevo.FlatAppearance.BorderSize = 3;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(554, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 51);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Generar Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generacion de Resoluciones";
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
            // frmListarResoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 287);
            this.Controls.Add(this.olvResoluciones);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarResoluciones";
            this.Text = "Resoluciones";
            this.Load += new System.EventHandler(this.frmListarResoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvResoluciones)).EndInit();
            this.cmsResoluciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvResoluciones;
        private BrightIdeasSoftware.OLVColumn columnHeader11;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip cmsResoluciones;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmExportarXML;
        private System.Windows.Forms.ToolStripMenuItem tsmExportarPDF;
    }
}