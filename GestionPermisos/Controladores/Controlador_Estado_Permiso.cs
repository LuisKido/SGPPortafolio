using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Estado_Permiso
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Estado_Permiso(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void update_Detalle(string id_permiso, string fecha_inicio, string fecha_fin, int dias, string id_detalle, string estado, string motivo)
        {
            int estadoi = 0;

            switch (estado)
            {
                case "0":
                    estadoi = 1;
                    break;
                case "1":
                    estadoi = 2;
                    break;
                case "2":
                    estadoi = 3;
                    break;
            }

            string fecha = DateTime.Now.ToShortDateString();

            string sSQL = "begin PERMISOS_DETALLES_tapi.upd(" + estadoi + ",'" + fecha + "','" + fecha_inicio + "','" + fecha_fin + "', '"+ motivo +"', '" + id_detalle + "', " + dias + ",'" + id_permiso + "','" + Properties.Settings.Default.ID_USUARIO + "'); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Permisos, true);
        }

        public async Task<DataSet> get_last_id()
        {
            string sSQL = "SELECT * FROM ( " +
                          "SELECT* FROM PERMISOS ORDER BY ID_INCREMENT DESC " +
                          ") WHERE ROWNUM = 1";

            DataSet ds = await _clsCore.SQL_RETURN_DS(sSQL, _frmOrigen, false);

            return ds;
        }
    }
}
