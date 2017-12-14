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
    public partial class frmListarTiposPermisos : Form
    {
        clsCore _clsCore;

        Controlador_Tipos_Permisos _controlador_Tipos_Permisos;

        public frmListarTiposPermisos(clsCore clsCore)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            _clsCore = clsCore;
            _controlador_Tipos_Permisos = new Controlador_Tipos_Permisos(this, _clsCore);
        }

        private void frmTiposPermisos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {
            //Lista de dataset a actualizar
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Tipos_Permisos);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para le formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);
        }

        //Metodo exito que carga los datos en el OLV
        private void exito_carga()
        {
            if (clsDS.DS_TIPOS_PERMISOS != null)
            {
                olvTiposPermiso.SetObjects(clsDS.DS_TIPOS_PERMISOS.Tables[0].Select());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoPermiso frm = new frmTipoPermiso(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvTiposPermiso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvTiposPermiso.SelectedObject != null)
            {
                string id_Tipo_Permiso = ((DataRow)olvTiposPermiso.SelectedObject)["ID_TIPO_PERMISO"].ToString();

                frmTipoPermiso frm = new frmTipoPermiso(_clsCore, id_Tipo_Permiso);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmNueva_Click(object sender, EventArgs e)
        {
            frmTipoPermiso frm = new frmTipoPermiso(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (olvTiposPermiso.SelectedObject != null)
            {
                string id_Tipo_Permiso = ((DataRow)olvTiposPermiso.SelectedObject)["ID_TIPO_PERMISO"].ToString();

                frmTipoPermiso frm = new frmTipoPermiso(_clsCore, id_Tipo_Permiso);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }
    }
}
