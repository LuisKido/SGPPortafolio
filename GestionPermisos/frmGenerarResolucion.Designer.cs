namespace GestionPermisos
{
    partial class frmGenerarResolucion
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
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            this.lblFiltroUnidad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.olvPermisos = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnFecha = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIDPermiso = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMotivo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTipoPermiso = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDias = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEstado = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxResolucionGeneral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarResolucion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResolucion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolucion.Location = new System.Drawing.Point(12, 18);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(331, 28);
            this.lblResolucion.TabIndex = 0;
            this.lblResolucion.Text = "Generación de Resolución Mensual";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Controls.Add(this.dtpFiltroFecha);
            this.pnlFiltros.Controls.Add(this.label4);
            this.pnlFiltros.Controls.Add(this.cbxUnidad);
            this.pnlFiltros.Controls.Add(this.lblFiltroUnidad);
            this.pnlFiltros.Location = new System.Drawing.Point(0, 67);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(973, 47);
            this.pnlFiltros.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(851, 3);
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
            this.dtpFiltroFecha.Location = new System.Drawing.Point(489, 9);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(335, 33);
            this.dtpFiltroFecha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mes Resolución";
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.Location = new System.Drawing.Point(141, 9);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(191, 33);
            this.cbxUnidad.TabIndex = 1;
            // 
            // lblFiltroUnidad
            // 
            this.lblFiltroUnidad.AutoSize = true;
            this.lblFiltroUnidad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroUnidad.Location = new System.Drawing.Point(12, 12);
            this.lblFiltroUnidad.Name = "lblFiltroUnidad";
            this.lblFiltroUnidad.Size = new System.Drawing.Size(123, 25);
            this.lblFiltroUnidad.TabIndex = 0;
            this.lblFiltroUnidad.Text = "Filtro Unidad";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.olvPermisos);
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 274);
            this.panel3.TabIndex = 2;
            // 
            // olvPermisos
            // 
            this.olvPermisos.AllColumns.Add(this.olvColumnFecha);
            this.olvPermisos.AllColumns.Add(this.olvColumnIDPermiso);
            this.olvPermisos.AllColumns.Add(this.olvColumnMotivo);
            this.olvPermisos.AllColumns.Add(this.olvColumnTipoPermiso);
            this.olvPermisos.AllColumns.Add(this.olvColumnDias);
            this.olvPermisos.AllColumns.Add(this.olvColumnEstado);
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
            this.olvColumnEstado});
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
            this.olvPermisos.Size = new System.Drawing.Size(712, 274);
            this.olvPermisos.SortGroupItemsByPrimaryColumn = false;
            this.olvPermisos.TabIndex = 36;
            this.olvPermisos.UseAlternatingBackColors = true;
            this.olvPermisos.UseCellFormatEvents = true;
            this.olvPermisos.UseCompatibleStateImageBehavior = false;
            this.olvPermisos.UseFilterIndicator = true;
            this.olvPermisos.UseFiltering = true;
            this.olvPermisos.UseHotItem = true;
            this.olvPermisos.View = System.Windows.Forms.View.Details;
            this.olvPermisos.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvPermisos_FormatCell);
            this.olvPermisos.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvPermisos_FormatRow);
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
            this.olvColumnTipoPermiso.AspectName = "TIPOPERMISO";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxResolucionGeneral);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(718, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 274);
            this.panel4.TabIndex = 3;
            // 
            // tbxResolucionGeneral
            // 
            this.tbxResolucionGeneral.Enabled = false;
            this.tbxResolucionGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.tbxResolucionGeneral.Location = new System.Drawing.Point(3, 37);
            this.tbxResolucionGeneral.Multiline = true;
            this.tbxResolucionGeneral.Name = "tbxResolucionGeneral";
            this.tbxResolucionGeneral.Size = new System.Drawing.Size(249, 234);
            this.tbxResolucionGeneral.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resolución General";
            // 
            // btnGenerarResolucion
            // 
            this.btnGenerarResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarResolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarResolucion.Location = new System.Drawing.Point(368, 400);
            this.btnGenerarResolucion.Name = "btnGenerarResolucion";
            this.btnGenerarResolucion.Size = new System.Drawing.Size(236, 47);
            this.btnGenerarResolucion.TabIndex = 4;
            this.btnGenerarResolucion.Text = "Generar Resolución";
            this.btnGenerarResolucion.UseVisualStyleBackColor = true;
            this.btnGenerarResolucion.Click += new System.EventHandler(this.btnGenerarResolucion_Click);
            // 
            // frmGenerarResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.btnGenerarResolucion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.panel1);
            this.Name = "frmGenerarResolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolucion";
            this.Load += new System.EventHandler(this.frmGenerarResolucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPermisos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFiltroFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUnidad;
        private System.Windows.Forms.Label lblFiltroUnidad;
        private BrightIdeasSoftware.ObjectListView olvPermisos;
        private BrightIdeasSoftware.OLVColumn olvColumnFecha;
        private BrightIdeasSoftware.OLVColumn olvColumnIDPermiso;
        private BrightIdeasSoftware.OLVColumn olvColumnMotivo;
        private BrightIdeasSoftware.OLVColumn olvColumnTipoPermiso;
        private BrightIdeasSoftware.OLVColumn olvColumnDias;
        private BrightIdeasSoftware.OLVColumn olvColumnEstado;
        private System.Windows.Forms.TextBox tbxResolucionGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarResolucion;
        private System.Windows.Forms.Button btnConsultar;
    }
}