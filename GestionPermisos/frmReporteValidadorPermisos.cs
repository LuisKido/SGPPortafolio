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
    public partial class frmReporteValidadorPermisos : Form
    {

        SGPServiceAsistencia.SGPServiceClient _client;
        DataSet ds_asistencia;

        public frmReporteValidadorPermisos()
        {
            InitializeComponent();
            _client = new SGPServiceAsistencia.SGPServiceClient();
        }

        private void frmReporteValidadorPermisos_Load(object sender, EventArgs e)
        {
            dtpFiltroFecha.Format = DateTimePickerFormat.Custom;
            dtpFiltroFecha.CustomFormat = "MMMM yyyy";
            //dtpFiltroFecha.ShowUpDown = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            get_ingresos_mes();
            //DataRow[] query = clsDS.DS_PERMISOS.Tables[0].Select("Convert(FECHAEMISION, 'System.String') LIKE '" + dtpFiltroFecha.Value.Month + "-*'");
            DataTable newtable = clsDS.DS_PERMISOS.Tables[0].Copy();
            DataColumn verify = new DataColumn("ESTADO_VERIFICADO");
            verify.DefaultValue = "No cumplido";
            newtable.Columns.Add(verify);
            var query2 = newtable.AsEnumerable().Where(r => r.Field<DateTime>("FECHAEMISION").Month == dtpFiltroFecha.Value.Month);

            int cumplidos = 0;

            foreach(DataRow dr in newtable.Rows)
            {
                foreach(DataRow drw in ds_asistencia.Tables[0].Rows)
                {
                    DateTime fecha_inicio = Convert.ToDateTime(dr["FECHAINICIO"].ToString());
                    DateTime fechaDrw = Convert.ToDateTime(drw["Fecha_Hora"].ToString());

                    if(fecha_inicio.Month == fechaDrw.Month)
                    {
                        if(fecha_inicio.Day == fechaDrw.Day)
                        {
                            dr["ESTADO_VERIFICADO"] = "Cumplido";
                            cumplidos++;
                        }
                    }
                }
            }

            olvPermisos.SetObjects(query2);
            lblCumplidos.Text = cumplidos.ToString();
            lblCantidadPermisos.Text = newtable.Rows.Count.ToString();
        }

        private void get_ingresos_mes()
        {
            //int mes = dtpFiltroFecha.Value.Month;
            string sSQL = "SELECT * FROM REGISTROS_ENTRADA WHERE DATEPART(month, Fecha_Hora) = " + dtpFiltroFecha.Value.Month;

            ds_asistencia = _client.SQL_GET_DATASET(sSQL, "SGPAsistencia");

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clsPrinter _printer = new clsPrinter();
            _printer.printReportePermisos("Reporte Permisos Cumplidos", olvPermisos.Objects.Cast<DataRow>());
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
        }
    }
}
