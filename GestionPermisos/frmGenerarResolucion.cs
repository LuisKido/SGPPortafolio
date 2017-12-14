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
    public partial class frmGenerarResolucion : Form
    {
        clsCore _clsCore;
        Controlador_Generar_Resolucion _controlador_Generar_Resolucion;
        DataSet ds;
        DataTable dt;

        string _id_Resolucion;
        bool _nuevo;

        public frmGenerarResolucion(clsCore clsCore)
        {
            InitializeComponent();
            _clsCore = clsCore;
            _controlador_Generar_Resolucion = new Controlador_Generar_Resolucion(this, _clsCore);
            _nuevo = true;
        }

        public frmGenerarResolucion(clsCore clsCore, string id_resolucion)
        {
            InitializeComponent();
            _clsCore = clsCore;
            _controlador_Generar_Resolucion = new Controlador_Generar_Resolucion(this, _clsCore);
            _id_Resolucion = id_resolucion;
            _nuevo = false;
        }

        private void CargaDatos()
        {

            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Permisos);
            destinos.Add(clsDS.DATASETSQL.Permisos_Detalle);
            destinos.Add(clsDS.DATASETSQL.Unidades);
            destinos.Add(clsDS.DATASETSQL.Resoluciones_Detalle);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para el formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, false);

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

        private void cargaResolucion()
        {
            pnlFiltros.Visible = false;
            btnGenerarResolucion.Visible = false;
            lblResolucion.Text = "Resolucion Mensual";

            olvColumnIDPermiso.AspectName = "PERMISOS_ID_PERMISO";
            olvColumnTipoPermiso.AspectName = "DETALLEPERMISO";

            if (clsDS.DS_RESOLUCIONES_DETALLE.Tables[0] != null)
            {
                olvPermisos.SetObjects(clsDS.DS_RESOLUCIONES_DETALLE.Tables[0].Select("RESOLUCIONES_ID_RESOLUCION = '" + _id_Resolucion + "'"));
            }

            int cantPermisos = 0;
            int cantPermisosAuth = 0;
            int cantPermisosPend = 0;
            int cantPermisosDesauth = 0;
            int cantDiasPermisos = 0;

            foreach (DataRow permiso in olvPermisos.Objects)
            {
                permiso.ToString();
                cantPermisos++;
                cantDiasPermisos = Convert.ToInt32(permiso["DIAS"]);
                switch (permiso["ESTADO"].ToString())
                {
                    case "1":
                        cantPermisosPend++;
                        break;
                    case "2":
                        cantPermisosAuth++;
                        break;
                    case "3":
                        cantPermisosDesauth++;
                        break;
                    default:
                        break;
                }

            }

            string resolucion = "Permisos Emitidos en el Mes: " + cantPermisos + " Permisos Autorizados: " + cantPermisosAuth + " Permisos Denegados: " + cantPermisosDesauth + " Permisos Pendientes: " + cantPermisosPend + ". Resolución emitida para el mes de " + dtpFiltroFecha.Value.ToString("MMMM") + ".";
            tbxResolucionGeneral.Text = resolucion;
            //consultar();
        }

        private void frmGenerarResolucion_Load(object sender, EventArgs e)
        {
            cargarUnidades();
            CargaDatos();
        }

        private void exito_carga()
        {
            if (!_nuevo)
            {
                cargaResolucion();
            }
            else
            {

                if (clsDS.DS_PERMISOS != null)
                {
                    if (clsDS.DS_PERMISOS.Tables[0] != null)
                    {
                        olvPermisos.SetObjects(clsDS.DS_PERMISOS.Tables[0].Select());

                        //DataSet ds = await _controlador_Generar_Resolucion.get_filtered_query(dtpFiltroFecha.Value.Month.ToString(), cbxUnidad.Text.ToString());
                        //DataTable dt = ds.Tables[0];

                        //olvPermisos.SetObjects(dt.AsEnumerable());
                    }
                }
            }
        }

        private async void exito_Resolucion()
        {
            DataSet dsr = await _controlador_Generar_Resolucion.get_last_id();

            DataRow[] rowsR = dsr.Tables[0].Select();

            if (rowsR.Length > 0)
            {
                string _id_Resolucion = rowsR[0]["ID_RESOLUCION"].ToString();

                string sql = "begin ";

                foreach (DataRow permiso in ds.Tables[0].Rows)
                {
                    //_controlador_Generar_Resolucion.insert_Detalle(permiso["ID_PERMISO"].ToString(),_id_Resolucion, tbxResolucionGeneral.Text);
                    sql += _controlador_Generar_Resolucion.generate_query_detalle(permiso["ID_PERMISO"].ToString(), _id_Resolucion, tbxResolucionGeneral.Text);
                }

                sql += "end;";

                _controlador_Generar_Resolucion.insert_Detalle(sql);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private async void consultar()
        {
            if (_nuevo)
            {
                ds = await _controlador_Generar_Resolucion.get_filtered_query(dtpFiltroFecha.Value.Month.ToString(), cbxUnidad.Text.ToString());
                dt = ds.Tables[0];


                olvPermisos.SetObjects(dt.AsEnumerable());
            }

            int cantPermisos = 0;
            int cantPermisosAuth = 0;
            int cantPermisosPend = 0;
            int cantPermisosDesauth = 0;
            int cantDiasPermisos = 0;

            foreach (DataRow permiso in ds.Tables[0].Rows)
            {
                permiso.ToString();
                cantPermisos++;
                cantDiasPermisos = Convert.ToInt32(permiso["DIAS"]);
                switch (permiso["ESTADO"].ToString())
                {
                    case "1":
                        cantPermisosPend++;
                        break;
                    case "2":
                        cantPermisosAuth++;
                        break;
                    case "3":
                        cantPermisosDesauth++;
                        break;
                    default:
                        break;
                }

            }

            string resolucion = "Permisos Emitidos en el Mes: " + cantPermisos + " Permisos Autorizados: " + cantPermisosAuth + " Permisos Denegados: " + cantPermisosDesauth + " Permisos Pendientes: " + cantPermisosPend + ". Resolución emitida para la unidad " + cbxUnidad.Text.ToString() + ", para el mes de " + dtpFiltroFecha.Value.ToString("MMMM") + ".";
            tbxResolucionGeneral.Text = resolucion;
        }

        private void cargarUnidades()
        {
            DataView dv = clsDS.DS_UNIDADES.Tables[0].DefaultView;
            cbxUnidad.DataSource = dv;
            cbxUnidad.DisplayMember = "NOMBREUNIDAD";
            cbxUnidad.ValueMember = "ID_UNIDAD";
            cbxUnidad.SelectedIndex = 0;
        }

        private void btnGenerarResolucion_Click(object sender, EventArgs e)
        {
            List<TextBox> tbox = new List<TextBox>();

            tbox.Add(tbxResolucionGeneral);

            if (clsValidator.Valida_Vacios(tbox))
            {
                generarResolucionGeneral();
            }
            else
            {
                MessageBox.Show("Debe consultar para generar una resolucion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void generarResolucionGeneral()
        {
            _controlador_Generar_Resolucion.insert_Resolución(tbxResolucionGeneral.Text);
        }

        private void olvPermisos_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            //if (e.Column.Text == "Fecha Solicitud")
            //{
            //    if (((DataRow)e.Model)["FECHAEMISION"].ToString() != "")
            //    {
            //        DateTime dt = Convert.ToDateTime(e.Item.Text);
            //        e.SubItem.Text = dt.ToString("dd/MM/yyyy");
            //    }
            //}
            //else if (e.Column.Text == "Estado")
            //{
            //    if (((DataRow)e.Model)["ESTADO"].ToString() != "")
            //    {
            //        int estado = Convert.ToInt32(e.SubItem.Text);

            //        switch (estado)
            //        {
            //            case 1:
            //                e.SubItem.Text = "PENDIENTE";
            //                break;
            //            case 2:
            //                e.SubItem.Text = "APROVADO";
            //                break;
            //            case 3:
            //                e.SubItem.Text = "RECHAZADO";
            //                break;
            //        }
            //    }
            //}
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
                            e.SubItem.Text = "APROVADO";
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
