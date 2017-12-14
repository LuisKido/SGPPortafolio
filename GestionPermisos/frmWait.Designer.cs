namespace GestionPermisos
{
    partial class frmWait
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lcCargando = new MRG.Controls.UI.LoadingCircle();
            this.lblCargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(178, 52);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(26, 17);
            this.lblPorcentaje.TabIndex = 7;
            this.lblPorcentaje.Text = "0%";
            // 
            // lcCargando
            // 
            this.lcCargando.Active = false;
            this.lcCargando.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(186)))), ((int)(((byte)(40)))));
            this.lcCargando.InnerCircleRadius = 8;
            this.lcCargando.Location = new System.Drawing.Point(122, 12);
            this.lcCargando.Name = "lcCargando";
            this.lcCargando.NumberSpoke = 24;
            this.lcCargando.OuterCircleRadius = 9;
            this.lcCargando.RotationSpeed = 100;
            this.lcCargando.Size = new System.Drawing.Size(75, 37);
            this.lcCargando.SpokeThickness = 4;
            this.lcCargando.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;
            this.lcCargando.TabIndex = 6;
            this.lcCargando.Text = "loadingCircle1";
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.BackColor = System.Drawing.Color.White;
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.Black;
            this.lblCargando.Location = new System.Drawing.Point(96, 52);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(76, 17);
            this.lblCargando.TabIndex = 5;
            this.lblCargando.Text = "Cargando...";
            // 
            // frmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 80);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lcCargando);
            this.Controls.Add(this.lblCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWait";
            this.Load += new System.EventHandler(this.frmWait_Load);
            this.Resize += new System.EventHandler(this.frmWait_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorcentaje;
        private MRG.Controls.UI.LoadingCircle lcCargando;
        private System.Windows.Forms.Label lblCargando;
    }
}