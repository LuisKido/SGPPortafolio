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
    public partial class frmListarResoluciones : Form
    {
        clsCore _clsCore;
        Controlador_Resoluciones _controlador_Resoluciones;
        public frmListarResoluciones(clsCore clsCore)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            _clsCore = clsCore;
            _controlador_Resoluciones = new Controlador_Resoluciones(this, _clsCore);
        }

        private void frmListarResoluciones_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("FechaEmision", typeof(string));
            //dt.Columns.Add("Mes", typeof(string));
            //dt.Columns.Add("Emisor", typeof(string));
            //dt.Columns.Add("RecursoLegal", typeof(string));

            //dt.Rows.Add("01-09-2017", "Septiembre", "Juan", "Administrativo");
            //dt.Rows.Add("02-08-2017", "Agosto", "Juan", "Administrativo");

            //olvResoluciones.SetObjects(dt.Select());
            //Lista de dataset a actualizar
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Resoluciones);
            destinos.Add(clsDS.DATASETSQL.Resoluciones_Detalle);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para le formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);
        }

        //Metodo exito que carga los datos en el OLV
        private void exito_carga()
        {
            olvResoluciones.SetObjects(clsDS.DS_RESOLUCIONES.Tables[0].Select());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGenerarResolucion frm = new frmGenerarResolucion(_clsCore);
            frm.Owner = this;
            frm.Show();
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
            frmGenerarResolucion frm = new frmGenerarResolucion(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void tsmExportarXML_Click(object sender, EventArgs e)
        {
            if (olvResoluciones.SelectedObject != null)
            {
                clsXMLGenerator xml = new clsXMLGenerator(_clsCore, this);

                string id_resolucion = ((DataRow)olvResoluciones.SelectedObject)["ID_RESOLUCION"].ToString();

                DataView dw = clsDS.DS_RESOLUCIONES_DETALLE.Tables[0].DefaultView;
                dw.RowFilter = "RESOLUCIONES_ID_RESOLUCION = '" + id_resolucion + "'";

                if (dw.Count > 0)
                {
                    xml.generar_XML(dw, id_resolucion, "Resolucion");
                }
            }
        }

        private void tsmExportarPDF_Click(object sender, EventArgs e)
        {
            if (olvResoluciones.SelectedObject != null)
            {
                string id_resolucion = ((DataRow)olvResoluciones.SelectedObject)["ID_RESOLUCION"].ToString();

                DataView dw = clsDS.DS_RESOLUCIONES_DETALLE.Tables[0].DefaultView;
                dw.RowFilter = "RESOLUCIONES_ID_RESOLUCION = '" + id_resolucion + "'";

                DataView dw2 = clsDS.DS_RESOLUCIONES.Tables[0].DefaultView;
                dw2.RowFilter = "ID_RESOLUCION = '" + id_resolucion + "'";

                if (dw.Count > 0)
                {
                    clsPrinter printer = new clsPrinter();
                    printer.printResolucion(id_resolucion, dw, "Resolucion", dw2);
                    MessageBox.Show("Resolución exportada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsmAbrir_Click(object sender, EventArgs e)
        {

        }

        private void olvResoluciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvResoluciones.SelectedObject != null)
            {
                string id_resolucion = ((DataRow)olvResoluciones.SelectedObject)["ID_RESOLUCION"].ToString();

                frmGenerarResolucion frm = new frmGenerarResolucion(_clsCore, id_resolucion);
                frm.Owner = this;
                frm.Show();

            }
        }
    }
}
