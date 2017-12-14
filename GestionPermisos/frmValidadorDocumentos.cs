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
    public partial class frmValidadorDocumentos : Form
    {

        clsCore _clsCore;
        

        public frmValidadorDocumentos(clsCore clsCore)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _clsCore = clsCore;
           
        }

        private void frmValidadorDocumentos_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void cargaDatos()
        {
            //List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            //destinos.Add(clsDS.DATASETSQL.Permisos);
            //destinos.Add(clsDS.DATASETSQL.Resoluciones);

            _clsCore.SQL_NON_ASYNCCORE_DS(this, clsDS.DATASETSQL.Permisos, false);
            _clsCore.SQL_NON_ASYNCCORE_DS(this, clsDS.DATASETSQL.Resoluciones, false);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            DataRow[] rowsPermisos = null;
            DataRow[] rowsResoluciones = null;

            if (clsDS.DS_PERMISOS != null)
            {
                if (clsDS.DS_PERMISOS.Tables[0] != null)
                {
                    rowsPermisos = clsDS.DS_PERMISOS.Tables[0].Select("ID_PERMISO = '" + txtCodigo.Text + "'");
                }
            }

            if (clsDS.DS_RESOLUCIONES != null)
            {
                if (clsDS.DS_RESOLUCIONES.Tables[0] != null)
                {
                    rowsResoluciones = clsDS.DS_RESOLUCIONES.Tables[0].Select("ID_RESOLUCION = '" + txtCodigo.Text + "'");
                }
            }

            if (rowsPermisos != null)
            {
                if (rowsPermisos.Length > 1)
                {
                    MessageBox.Show("El codigo de permiso ingresado es correcto, ¿Desea visualizarlo?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else if (rowsResoluciones.Length > 1)
                {
                    MessageBox.Show("El codigo de Resolucion ingresado es correcto, ¿Desea visualizarlo?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no es valido, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El codigo ingresado no es valido, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}

