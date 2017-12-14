namespace GestionPermisos
{
    partial class frmListarTiposPermisos
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
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle10 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle11 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle12 = new BrightIdeasSoftware.HeaderStateStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.olvTiposPermiso = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.cmsTiposPermisos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTiposPermiso)).BeginInit();
            this.cmsTiposPermisos.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(802, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::GestionPermisos.Properties.Resources.refresh;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(592, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(650, 0);
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
            this.btnNuevo.Location = new System.Drawing.Point(661, 0);
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
            this.label1.Text = "Tipos de Permisos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 51);
            this.panel2.TabIndex = 2;
            // 
            // olvTiposPermiso
            // 
            this.olvTiposPermiso.AllColumns.Add(this.olvColumn2);
            this.olvTiposPermiso.AllColumns.Add(this.columnHeader12);
            this.olvTiposPermiso.AllowColumnReorder = true;
            this.olvTiposPermiso.AllowDrop = true;
            this.olvTiposPermiso.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvTiposPermiso.BackColor = System.Drawing.SystemColors.Window;
            this.olvTiposPermiso.CellEditUseWholeCell = false;
            this.olvTiposPermiso.CheckedAspectName = "";
            this.olvTiposPermiso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.columnHeader12});
            this.olvTiposPermiso.ContextMenuStrip = this.cmsTiposPermisos;
            this.olvTiposPermiso.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTiposPermiso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTiposPermiso.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvTiposPermiso.FullRowSelect = true;
            this.olvTiposPermiso.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTiposPermiso.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvTiposPermiso.HeaderWordWrap = true;
            this.olvTiposPermiso.HideSelection = false;
            this.olvTiposPermiso.IncludeColumnHeadersInCopy = true;
            this.olvTiposPermiso.Location = new System.Drawing.Point(0, 51);
            this.olvTiposPermiso.Name = "olvTiposPermiso";
            this.olvTiposPermiso.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvTiposPermiso.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvTiposPermiso.OverlayText.BorderWidth = 2F;
            this.olvTiposPermiso.OverlayText.Rotation = -20;
            this.olvTiposPermiso.OverlayText.Text = "";
            this.olvTiposPermiso.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvTiposPermiso.ShowCommandMenuOnRightClick = true;
            this.olvTiposPermiso.ShowGroups = false;
            this.olvTiposPermiso.ShowHeaderInAllViews = false;
            this.olvTiposPermiso.ShowItemToolTips = true;
            this.olvTiposPermiso.Size = new System.Drawing.Size(802, 267);
            this.olvTiposPermiso.SortGroupItemsByPrimaryColumn = false;
            this.olvTiposPermiso.TabIndex = 31;
            this.olvTiposPermiso.UseAlternatingBackColors = true;
            this.olvTiposPermiso.UseCellFormatEvents = true;
            this.olvTiposPermiso.UseCompatibleStateImageBehavior = false;
            this.olvTiposPermiso.UseFilterIndicator = true;
            this.olvTiposPermiso.UseFiltering = true;
            this.olvTiposPermiso.UseHotItem = true;
            this.olvTiposPermiso.View = System.Windows.Forms.View.Details;
            this.olvTiposPermiso.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTiposPermiso_MouseDoubleClick);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "DETALLEPERMISO";
            this.olvColumn2.Text = "Detalle Permiso";
            this.olvColumn2.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.AspectName = "DIASAFECTOS";
            this.columnHeader12.Hyperlink = true;
            this.columnHeader12.MaximumWidth = 180;
            this.columnHeader12.MinimumWidth = 50;
            this.columnHeader12.Text = "Días Afectos";
            this.columnHeader12.Width = 180;
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle10;
            headerStateStyle11.BackColor = System.Drawing.Color.White;
            headerStateStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerStateStyle11.FrameColor = System.Drawing.Color.Silver;
            this.headerFormatStyle1.Normal = headerStateStyle11;
            this.headerFormatStyle1.Pressed = headerStateStyle12;
            // 
            // cmsTiposPermisos
            // 
            this.cmsTiposPermisos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmEditar});
            this.cmsTiposPermisos.Name = "cmsUnidades";
            this.cmsTiposPermisos.Size = new System.Drawing.Size(127, 76);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(152, 22);
            this.tsmActualizar.Text = "Actualizar";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmNueva
            // 
            this.tsmNueva.Name = "tsmNueva";
            this.tsmNueva.Size = new System.Drawing.Size(152, 22);
            this.tsmNueva.Text = "Nuevo";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(152, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // frmListarTiposPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 318);
            this.Controls.Add(this.olvTiposPermiso);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarTiposPermisos";
            this.Text = "Tipos Permisos";
            this.Load += new System.EventHandler(this.frmTiposPermisos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTiposPermiso)).EndInit();
            this.cmsTiposPermisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.ObjectListView olvTiposPermiso;
        private BrightIdeasSoftware.OLVColumn columnHeader12;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip cmsTiposPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
    }
}