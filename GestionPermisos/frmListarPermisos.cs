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
    public partial class frmListarPermisos : Form
    {

        clsCore _clsCore;
        Controlador_Permisos _controlador_Permisos;

        public frmListarPermisos(clsCore clsCore)
        {
            InitializeComponent();

            _clsCore = clsCore;
            _controlador_Permisos = new Controlador_Permisos(this, _clsCore);
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmListarPermisos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {

            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Permisos);
            //destinos.Add(clsDS.DATASETSQL.Permisos_Detalle);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para el formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);

            //DataTable dt = new DataTable();
            //dt.Columns.Add("FechaSol", typeof(string));
            //dt.Columns.Add("Estado", typeof(string));
            //dt.Columns.Add("FechaInicio", typeof(string));
            //dt.Columns.Add("FechaTermino", typeof(string));
            //dt.Columns.Add("Dias", typeof(string));
            //dt.Columns.Add("Tipo", typeof(string));

            //dt.Rows.Add("11-07-2017", "PENDIENTE", "12-09-2017", "14-09-2017", "2", "Administrativo");
            //dt.Rows.Add("15-07-2017", "AUTORIZADO", "15-09-2017", "14-10-2017", "29", "Pos Parto");

            //olvPermisos.SetObjects(dt.Select());
        }

        private void exito_carga()
        {
            if (clsDS.DS_PERMISOS != null)
            {
                if (clsDS.DS_PERMISOS.Tables[0] != null)
                {
                    olvPermisos.SetObjects(clsDS.DS_PERMISOS.Tables[0].Select("USUARIOS_ID_USUARIO = '" + Properties.Settings.Default.ID_USUARIO + "'"));
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPermiso frm = new frmPermiso(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvPermisos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                frmPermiso frm = new frmPermiso(_clsCore, id_permiso);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void olvPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmNueva_Click(object sender, EventArgs e)
        {
            frmPermiso frm = new frmPermiso(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (olvPermisos.SelectedObject != null)
            {
                string id_permiso = ((DataRow)olvPermisos.SelectedObject)["ID_PERMISO"].ToString();

                frmPermiso frm = new frmPermiso(_clsCore, id_permiso);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void olvPermisos_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            //if (((DataRow)e.Model)["FECHAEMISION"].ToString() != "")
            //{
            //    DateTime dt = Convert.ToDateTime(e.Item.Text);
            //    e.Item.Text = dt.ToString("dd/MM/yyyy");
            //}

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
                dw.RowFilter = "ID_PERMISO = '" + id_permiso +"'";

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
