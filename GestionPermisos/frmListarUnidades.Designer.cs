namespace GestionPermisos
{
    partial class frmListarUnidades
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
            this.olvUnidades = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsUnidades = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUnidades)).BeginInit();
            this.cmsUnidades.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(814, 51);
            this.panel1.TabIndex = 32;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::GestionPermisos.Properties.Resources.refresh;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(604, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(662, 0);
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
            this.btnNuevo.Location = new System.Drawing.Point(673, 0);
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
            this.label1.Text = "Unidades";
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
            // olvUnidades
            // 
            this.olvUnidades.AllColumns.Add(this.olvColumn1);
            this.olvUnidades.AllowColumnReorder = true;
            this.olvUnidades.AllowDrop = true;
            this.olvUnidades.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvUnidades.CellEditUseWholeCell = false;
            this.olvUnidades.CheckedAspectName = "";
            this.olvUnidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.olvUnidades.ContextMenuStrip = this.cmsUnidades;
            this.olvUnidades.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvUnidades.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvUnidades.FullRowSelect = true;
            this.olvUnidades.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvUnidades.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvUnidades.HeaderWordWrap = true;
            this.olvUnidades.HideSelection = false;
            this.olvUnidades.IncludeColumnHeadersInCopy = true;
            this.olvUnidades.Location = new System.Drawing.Point(0, 51);
            this.olvUnidades.Name = "olvUnidades";
            this.olvUnidades.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvUnidades.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvUnidades.OverlayText.BorderWidth = 2F;
            this.olvUnidades.OverlayText.Rotation = -20;
            this.olvUnidades.OverlayText.Text = "";
            this.olvUnidades.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvUnidades.ShowCommandMenuOnRightClick = true;
            this.olvUnidades.ShowGroups = false;
            this.olvUnidades.ShowHeaderInAllViews = false;
            this.olvUnidades.ShowItemToolTips = true;
            this.olvUnidades.Size = new System.Drawing.Size(814, 276);
            this.olvUnidades.SortGroupItemsByPrimaryColumn = false;
            this.olvUnidades.TabIndex = 33;
            this.olvUnidades.UseAlternatingBackColors = true;
            this.olvUnidades.UseCellFormatEvents = true;
            this.olvUnidades.UseCompatibleStateImageBehavior = false;
            this.olvUnidades.UseFilterIndicator = true;
            this.olvUnidades.UseFiltering = true;
            this.olvUnidades.UseHotItem = true;
            this.olvUnidades.View = System.Windows.Forms.View.Details;
            this.olvUnidades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvUnidades_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "NOMBREUNIDAD";
            this.olvColumn1.Text = "Nombre Unidad";
            this.olvColumn1.Width = 160;
            // 
            // cmsUnidades
            // 
            this.cmsUnidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmEditar});
            this.cmsUnidades.Name = "cmsUnidades";
            this.cmsUnidades.Size = new System.Drawing.Size(127, 76);
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
            this.tsmNueva.Text = "Nueva";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(126, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // frmListarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 327);
            this.Controls.Add(this.olvUnidades);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarUnidades";
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.frmListarUnidades_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvUnidades)).EndInit();
            this.cmsUnidades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.ObjectListView olvUnidades;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.ContextMenuStrip cmsUnidades;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
    }
}