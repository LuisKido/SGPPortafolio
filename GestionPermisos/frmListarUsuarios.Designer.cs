namespace GestionPermisos
{
    partial class frmListarUsuarios
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
            this.olvUsuarios = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsUsuarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDesempeño = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUsuarios)).BeginInit();
            this.cmsUsuarios.SuspendLayout();
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
            this.label1.Text = "Usuarios";
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
            this.panel1.Size = new System.Drawing.Size(831, 51);
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
            this.btnActualizar.Location = new System.Drawing.Point(621, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 51);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(679, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 51);
            this.panel3.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNuevo.FlatAppearance.BorderSize = 3;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(690, 0);
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
            // olvUsuarios
            // 
            this.olvUsuarios.AllColumns.Add(this.olvColumn3);
            this.olvUsuarios.AllColumns.Add(this.olvColumn2);
            this.olvUsuarios.AllColumns.Add(this.olvColumn4);
            this.olvUsuarios.AllColumns.Add(this.olvColumn5);
            this.olvUsuarios.AllowColumnReorder = true;
            this.olvUsuarios.AllowDrop = true;
            this.olvUsuarios.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvUsuarios.CellEditUseWholeCell = false;
            this.olvUsuarios.CheckedAspectName = "";
            this.olvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn2});
            this.olvUsuarios.ContextMenuStrip = this.cmsUsuarios;
            this.olvUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvUsuarios.FullRowSelect = true;
            this.olvUsuarios.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvUsuarios.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvUsuarios.HeaderWordWrap = true;
            this.olvUsuarios.HideSelection = false;
            this.olvUsuarios.IncludeColumnHeadersInCopy = true;
            this.olvUsuarios.Location = new System.Drawing.Point(0, 51);
            this.olvUsuarios.Name = "olvUsuarios";
            this.olvUsuarios.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvUsuarios.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvUsuarios.OverlayText.BorderWidth = 2F;
            this.olvUsuarios.OverlayText.Rotation = -20;
            this.olvUsuarios.OverlayText.Text = "";
            this.olvUsuarios.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvUsuarios.ShowCommandMenuOnRightClick = true;
            this.olvUsuarios.ShowGroups = false;
            this.olvUsuarios.ShowHeaderInAllViews = false;
            this.olvUsuarios.ShowItemToolTips = true;
            this.olvUsuarios.Size = new System.Drawing.Size(831, 274);
            this.olvUsuarios.SortGroupItemsByPrimaryColumn = false;
            this.olvUsuarios.TabIndex = 35;
            this.olvUsuarios.UseAlternatingBackColors = true;
            this.olvUsuarios.UseCellFormatEvents = true;
            this.olvUsuarios.UseCompatibleStateImageBehavior = false;
            this.olvUsuarios.UseFilterIndicator = true;
            this.olvUsuarios.UseFiltering = true;
            this.olvUsuarios.UseHotItem = true;
            this.olvUsuarios.View = System.Windows.Forms.View.Details;
            this.olvUsuarios.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvUsuarios_FormatRow);
            this.olvUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvUsuarios_MouseDoubleClick);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "RUT";
            this.olvColumn3.Text = "Rut";
            this.olvColumn3.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "EMAIL";
            this.olvColumn2.Text = "Email";
            this.olvColumn2.Width = 186;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "UNIDADES_ID_UNIDAD";
            this.olvColumn4.DisplayIndex = 2;
            this.olvColumn4.IsVisible = false;
            this.olvColumn4.Text = "ID Unidad";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "PERFILES_ID_PERFIL";
            this.olvColumn5.DisplayIndex = 3;
            this.olvColumn5.IsVisible = false;
            this.olvColumn5.Text = "ID Perfil";
            // 
            // cmsUsuarios
            // 
            this.cmsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripMenuItem1,
            this.tsmNueva,
            this.tsmEditar,
            this.toolStripMenuItem2,
            this.tsmDesempeño});
            this.cmsUsuarios.Name = "cmsUnidades";
            this.cmsUsuarios.Size = new System.Drawing.Size(165, 126);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(164, 22);
            this.tsmActualizar.Text = "Actualizar";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmNueva
            // 
            this.tsmNueva.Name = "tsmNueva";
            this.tsmNueva.Size = new System.Drawing.Size(164, 22);
            this.tsmNueva.Text = "Nuevo";
            this.tsmNueva.Click += new System.EventHandler(this.tsmNueva_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(164, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmDesempeño
            // 
            this.tsmDesempeño.Name = "tsmDesempeño";
            this.tsmDesempeño.Size = new System.Drawing.Size(164, 22);
            this.tsmDesempeño.Text = "Desempeño XML";
            this.tsmDesempeño.Click += new System.EventHandler(this.tsmDesempeño_Click);
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 325);
            this.Controls.Add(this.olvUsuarios);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvUsuarios)).EndInit();
            this.cmsUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.ObjectListView olvUsuarios;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip cmsUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmDesempeño;
    }
}