namespace GestionPermisos
{
    partial class frmReporteValidadorPermisos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.olvPermisos = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnFecha = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIDPermiso = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMotivo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTipoPermiso = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDias = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEstado = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnValidado = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadPermisos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCumplidos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResolucion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 61);
            this.panel1.TabIndex = 1;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolucion.Location = new System.Drawing.Point(12, 18);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(263, 28);
            this.lblResolucion.TabIndex = 0;
            this.lblResolucion.Text = "Reporte Validador Permisos";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Controls.Add(this.dtpFiltroFecha);
            this.pnlFiltros.Controls.Add(this.label4);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 61);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(898, 47);
            this.pnlFiltros.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(404, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 41);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFiltroFecha
            // 
            this.dtpFiltroFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroFecha.Location = new System.Drawing.Point(63, 9);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(335, 33);
            this.dtpFiltroFecha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mes";
            // 
            // olvPermisos
            // 
            this.olvPermisos.AllColumns.Add(this.olvColumnFecha);
            this.olvPermisos.AllColumns.Add(this.olvColumnIDPermiso);
            this.olvPermisos.AllColumns.Add(this.olvColumnMotivo);
            this.olvPermisos.AllColumns.Add(this.olvColumnTipoPermiso);
            this.olvPermisos.AllColumns.Add(this.olvColumnDias);
            this.olvPermisos.AllColumns.Add(this.olvColumnEstado);
            this.olvPermisos.AllColumns.Add(this.olvColumnValidado);
            this.olvPermisos.AllowColumnReorder = true;
            this.olvPermisos.AllowDrop = true;
            this.olvPermisos.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvPermisos.CellEditUseWholeCell = false;
            this.olvPermisos.CheckedAspectName = "";
            this.olvPermisos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnFecha,
            this.olvColumnIDPermiso,
            this.olvColumnMotivo,
            this.olvColumnTipoPermiso,
            this.olvColumnDias,
            this.olvColumnEstado,
            this.olvColumnValidado});
            this.olvPermisos.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPermisos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.olvPermisos.FullRowSelect = true;
            this.olvPermisos.HeaderFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvPermisos.HeaderWordWrap = true;
            this.olvPermisos.HideSelection = false;
            this.olvPermisos.IncludeColumnHeadersInCopy = true;
            this.olvPermisos.Location = new System.Drawing.Point(0, 0);
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
            this.olvPermisos.Size = new System.Drawing.Size(898, 303);
            this.olvPermisos.SortGroupItemsByPrimaryColumn = false;
            this.olvPermisos.TabIndex = 37;
            this.olvPermisos.UseAlternatingBackColors = true;
            this.olvPermisos.UseCellFormatEvents = true;
            this.olvPermisos.UseCompatibleStateImageBehavior = false;
            this.olvPermisos.UseFilterIndicator = true;
            this.olvPermisos.UseFiltering = true;
            this.olvPermisos.UseHotItem = true;
            this.olvPermisos.View = System.Windows.Forms.View.Details;
            this.olvPermisos.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvPermisos_FormatCell);
            // 
            // olvColumnFecha
            // 
            this.olvColumnFecha.AspectName = "FECHAEMISION";
            this.olvColumnFecha.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.olvColumnFecha.MaximumWidth = 200;
            this.olvColumnFecha.MinimumWidth = 100;
            this.olvColumnFecha.Text = "Fecha Solicitud";
            this.olvColumnFecha.ToolTipText = "This is a long tooltip text that should appear when the mouse is over this column" +
    " header but contains absolutely no useful information :)";
            this.olvColumnFecha.UseInitialLetterForGroup = true;
            this.olvColumnFecha.Width = 144;
            // 
            // olvColumnIDPermiso
            // 
            this.olvColumnIDPermiso.AspectName = "ID_PERMISO";
            this.olvColumnIDPermiso.Text = "Id Permiso";
            this.olvColumnIDPermiso.Width = 99;
            // 
            // olvColumnMotivo
            // 
            this.olvColumnMotivo.AspectName = "MOTIVO";
            this.olvColumnMotivo.Text = "Motivo";
            this.olvColumnMotivo.Width = 113;
            // 
            // olvColumnTipoPermiso
            // 
            this.olvColumnTipoPermiso.AspectName = "DETALLEPERMISO";
            this.olvColumnTipoPermiso.Text = "Tipo Permiso";
            this.olvColumnTipoPermiso.Width = 115;
            // 
            // olvColumnDias
            // 
            this.olvColumnDias.AspectName = "DIAS";
            this.olvColumnDias.Text = "Dias Permiso";
            this.olvColumnDias.Width = 104;
            // 
            // olvColumnEstado
            // 
            this.olvColumnEstado.AspectName = "ESTADO";
            this.olvColumnEstado.Text = "Estado";
            this.olvColumnEstado.Width = 110;
            // 
            // olvColumnValidado
            // 
            this.olvColumnValidado.AspectName = "ESTADO_VERIFICADO";
            this.olvColumnValidado.Text = "Validado";
            this.olvColumnValidado.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.olvPermisos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 303);
            this.panel2.TabIndex = 38;
            // 
            // btnExportar
            // 
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(359, 459);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(192, 41);
            this.btnExportar.TabIndex = 39;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCumplidos);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblCantidadPermisos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 40);
            this.panel3.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Permisos:";
            // 
            // lblCantidadPermisos
            // 
            this.lblCantidadPermisos.AutoSize = true;
            this.lblCantidadPermisos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPermisos.Location = new System.Drawing.Point(232, 7);
            this.lblCantidadPermisos.Name = "lblCantidadPermisos";
            this.lblCantidadPermisos.Size = new System.Drawing.Size(23, 28);
            this.lblCantidadPermisos.TabIndex = 1;
            this.lblCantidadPermisos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cumplidos:";
            // 
            // lblCumplidos
            // 
            this.lblCumplidos.AutoSize = true;
            this.lblCumplidos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumplidos.Location = new System.Drawing.Point(462, 7);
            this.lblCumplidos.Name = "lblCumplidos";
            this.lblCumplidos.Size = new System.Drawing.Size(23, 28);
            this.lblCumplidos.TabIndex = 3;
            this.lblCumplidos.Text = "0";
            // 
            // frmReporteValidadorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteValidadorPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Validador Permisos";
            this.Load += new System.EventHandler(this.frmReporteValidadorPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFiltroFecha;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.ObjectListView olvPermisos;
        private BrightIdeasSoftware.OLVColumn olvColumnFecha;
        private BrightIdeasSoftware.OLVColumn olvColumnIDPermiso;
        private BrightIdeasSoftware.OLVColumn olvColumnMotivo;
        private BrightIdeasSoftware.OLVColumn olvColumnTipoPermiso;
        private BrightIdeasSoftware.OLVColumn olvColumnDias;
        private BrightIdeasSoftware.OLVColumn olvColumnEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportar;
        private BrightIdeasSoftware.OLVColumn olvColumnValidado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCumplidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadPermisos;
        private System.Windows.Forms.Label label1;
    }
}