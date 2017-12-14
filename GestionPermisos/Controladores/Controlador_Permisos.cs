using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Permisos
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Permisos(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void insert_Permiso(string id_tipo_permiso)
        {
            //string fecha = DateTime.Now.ToShortDateString();


            //Este insert quedo mas simple
            string sSQL = "begin PERMISOS_TAPI.ins(' ',sys_guid(),'" + id_tipo_permiso + "','" + Properties.Settings.Default.ID_USUARIO + "'); end;";
            //_clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Permisos, false);

            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Permisos);

            _clsCore.SQL_NON_ASYNCCOREQUERY_DS2METHOD(sSQL, "exito_carga", "exito_Permiso", _frmOrigen, _frmOrigen.Owner, destinos, false);
        }

        public void update_Permiso(string id_tipo_permiso, string recurso_legal, string id_permiso)
        {
            string fecha = DateTime.Now.ToShortDateString();

            string sSQL = "begin PERMISOS_TAPI.upd(,' ','" + id_permiso + "','" + id_tipo_permiso + "','" + Properties.Settings.Default.ID_USUARIO + "'); end;";

            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Permisos, false);
        }

        public void insert_Detalle(string id_permiso, string fecha_inicio, string fecha_fin, int dias, string motivo)
        {
            string estado = "1";

            string fecha = DateTime.Now.ToShortDateString();

            //El primero 1 de la query es que el estado fue cambiado a un numero, despues hay que darle interpretacion.
            string sSQL = "begin PERMISOS_DETALLES_tapi.ins(" + estado + ",'" + fecha + "','" + fecha_inicio + "','" + fecha_fin + "','" + motivo + "',sys_guid(), " + dias + ",'" + id_permiso + "','" + Properties.Settings.Default.ID_USUARIO + "'); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Permisos, true);
        }

        public void update_Detalle(string id_permiso, string fecha_inicio, string fecha_fin, int dias, string id_detalle, string motivo)
        {
            string estado = "1";

            string fecha = DateTime.Now.ToShortDateString();

            string sSQL = "begin PERMISOS_DETALLES_tapi.upd(" + estado + ",'" + fecha + "','" + fecha_inicio + "','" + fecha_fin + "','" + motivo +"' ,'" + id_detalle + "', " + dias + ",'" + id_permiso + "','" + Properties.Settings.Default.ID_USUARIO + "'); end;";
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
