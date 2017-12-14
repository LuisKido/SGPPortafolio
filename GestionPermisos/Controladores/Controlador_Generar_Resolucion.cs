using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Generar_Resolucion
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Generar_Resolucion(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        /// <summary>
        /// Método de query personalizada para traer al form de generación de resoluciones según reglas de negocio.
        /// </summary>
        /// <param name="mes">Parámetro para filtrar por mes la consulta de permisos</param>
        /// <param name="unidad">Parámetro para filtrar por unidad la consulta de permisos</param>
        /// <returns></returns>
        public async Task<DataSet> get_filtered_query(string mes, string unidad)
        {
            string sSQL = "SELECT (SELECT unidades.nombreunidad from unidades where usuarios.UNIDADES_ID_UNIDAD = unidades.ID_UNIDAD) \"UNIDAD\", permisos.*, permisos_detalles.id_detalle_permiso, EXTRACT(MONTH FROM permisos_detalles.fechaemision) \"MES_EMISION\", permisos_detalles.fechaemision, permisos_detalles.estado, permisos_detalles.fechainicio, permisos_detalles.fechafin, permisos_detalles.dias, permisos_detalles.usuarios_id_usuario AS usuarios_id_usuario1, permisos_detalles.motivo FROM permisos LEFT JOIN permisos_detalles ON permisos.id_permiso = permisos_detalles.permisos_id_permiso LEFT JOIN usuarios on usuarios.ID_USUARIO = permisos.USUARIOS_ID_USUARIO WHERE EXTRACT(MONTH FROM permisos_detalles.fechaemision) = " + mes +" AND usuarios.UNIDADES_ID_UNIDAD = (SELECT unidades.ID_UNIDAD from unidades where unidades.NOMBREUNIDAD = '"+ unidad +"')";

            DataSet ds = await _clsCore.SQL_RETURN_DS(sSQL, _frmOrigen, false);

            return ds;
        }

        public void insert_Resolución(string resolucion)
        {
            //string fecha = DateTime.Now.ToShortDateString();


            //Este insert quedo mas simple
            string sSQL = "begin RESOLUCIONES_TAPI.ins('"+ resolucion +"',sys_guid()); end;";
            //_clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Permisos, false);

            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Resoluciones);

            _clsCore.SQL_NON_ASYNCCOREQUERY_DS2METHOD(sSQL, "exito_carga", "exito_Resolucion", _frmOrigen, _frmOrigen.Owner, destinos, false);
        }

        public void insert_Detalle(string sql)
        {

            //string fecha = DateTime.Now.ToShortDateString();

            //El primero 1 de la query es que el estado fue cambiado a un numero, despues hay que darle interpretacion.
            //string sSQL = "begin RESOLUCIONES_DETALLE_tapi.ins('"+ fecha +"', 10001, sys_guid(), '"+ id_resolucion +"','"+ justificacion +"', '"+ id_permiso +"'); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sql, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Resoluciones_Detalle, true);
        }

        public string generate_query_detalle(string id_permiso, string id_resolucion, string justificacion)
        {

            string fecha = DateTime.Now.ToShortDateString();

            string sSQL = "RESOLUCIONES_DETALLE_tapi.ins('" + fecha + "', 10001, sys_guid(), '" + id_resolucion + "','" + justificacion + "', '" + id_permiso + "'); ";
            return sSQL;
        }

        public async Task<DataSet> get_last_id()
        {
            string sSQL = "SELECT ID_RESOLUCION from resoluciones minus SELECT ID_Resolucion from RESOLUCIONES where ROWNUM < (select count(*) from resoluciones)";

            DataSet ds = await _clsCore.SQL_RETURN_DS(sSQL, _frmOrigen, false);

            return ds;
        }
    }
}
