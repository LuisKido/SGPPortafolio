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
    public partial class frmGestionarPermisos : Form
    {
        clsCore _clsCore;
        Controlador_Permisos _controlador_Permisos;

        public frmGestionarPermisos(clsCore clsCore)
        {
            InitializeComponent();

            _clsCore = clsCore;
            _controlador_Permisos = new Controlador_Permisos(this, _clsCore);
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmGestionarPermisos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Permisos);
            destinos.Add(clsDS.DATASETSQL.Permisos_Detalle);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para el formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);

            //olvPermisos.SetObjects(dt.Select());
        }

        private void exito_carga()
        {
            if (clsDS.DS_PERMISOS != null)
            {
                if (clsDS.DS_PERMISOS.Tables[0] != null)
                {
                    olvPermisos.SetObjects(clsDS.DS_PERMISOS.Tables[0].Select());
                }
            }
        }

        private void olvPermisos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                frmEstadoPermiso frm = new frmEstadoPermiso(_clsCore, id_permiso);
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

        private void tsmAbrir_Click(object sender, EventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                frmEstadoPermiso frm = new frmEstadoPermiso(_clsCore, id_permiso);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void tsmExportarPDF_Click(object sender, EventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                DataRow[] rows = clsDS.DS_PERMISOS.Tables[0].Select("ID_PERMISO = '" + id_permiso + "'");

                if (rows.Length > 0)
                {
                    clsPrinter printer = new clsPrinter();
                    printer.printPermiso(id_permiso, "Pendiente", rows[0]["TIPOPERMISO"].ToString(), Convert.ToDateTime(rows[0]["FECHAINICIO"].ToString()).ToShortDateString(), Convert.ToDateTime(rows[0]["FECHAFIN"].ToString()).ToShortDateString(), Convert.ToInt32(rows[0]["DIAS"].ToString()).ToString(), rows[0]["MOTIVO"].ToString(), Properties.Settings.Default.RUT_USUARIO, "Permiso");
                    MessageBox.Show("Permiso exportado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsmExportarXML_Click(object sender, EventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                clsXMLGenerator xml = new clsXMLGenerator(_clsCore, this);

                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                DataView dw = clsDS.DS_PERMISOS.Tables[0].DefaultView;
                dw.RowFilter = "ID_PERMISO = '" + id_permiso + "'";

                if (dw.Count > 0)
                {
                    xml.generar_XML(dw, id_permiso, "Permiso");
                }
            }
        }

        private void olvPermisos_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.Column.Text == "Fecha Solicitud")
            {
                if (((DataRow)e.Model)["FECHAEMISION"].ToString() != "")
                {
                    DateTime dt = Convert.ToDateTime(e.Item.Text);
                    e.SubItem.Text = dt.ToString("dd/MM/yyyy");
                }
            }
            else if (e.Column.Text == "Estado")
            {
                if (((DataRow)e.Model)["ESTADO"].ToString() != "")
                {
                    int estado = Convert.ToInt32(e.SubItem.Text);

                    switch (estado)
                    {
                        case 1:
                            e.SubItem.Text = "PENDIENTE";
                            break;
                        case 2:
                            e.SubItem.Text = "APROBADO";
                            break;
                        case 3:
                            e.SubItem.Text = "RECHAZADO";
                            break;
                    }
                }
            }
        }
    }
}
