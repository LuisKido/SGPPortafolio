using GestionPermisos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos
{
    public partial class frmListarUnidades : Form
    {
        clsCore _clsCore;
        Controlador_Unidades _controlador_Unidades;

        public frmListarUnidades(clsCore clsCore)
        {
            InitializeComponent();

            //this.WindowState = FormWindowState.Maximized;
            _clsCore = clsCore;
            _controlador_Unidades = new Controlador_Unidades(this, _clsCore);
        }

        private void frmListarUnidades_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Unidades);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para el formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);
        }

        private void exito_carga()
        {
            if (clsDS.DS_UNIDADES != null)
            {
                if (clsDS.DS_UNIDADES.Tables[0] != null)
                {
                    olvUnidades.SetObjects(clsDS.DS_UNIDADES.Tables[0].Select());
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUnidad frm = new frmUnidad(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvUnidades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvUnidades.SelectedObject != null)
            {
                string id_unidad = ((DataRow)olvUnidades.SelectedObject)["ID_UNIDAD"].ToString();

                frmUnidad frm = new frmUnidad(_clsCore, id_unidad);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmNueva_Click(object sender, EventArgs e)
        {
            frmUnidad frm = new frmUnidad(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (olvUnidades.SelectedObject != null)
            {
                string id_unidad = ((DataRow)olvUnidades.SelectedObject)["ID_UNIDAD"].ToString();

                frmUnidad frm = new frmUnidad(_clsCore, id_unidad);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }
    }
}
