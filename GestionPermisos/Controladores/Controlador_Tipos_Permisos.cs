using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Tipos_Permisos
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Tipos_Permisos(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void insert_Tipo_Permiso(string detalle, int dias)
        {
            string sSQL = "begin TIPOS_PERMISOS_TAPI.ins('" + detalle + "' ," + dias + ",sys_guid(), 0); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Tipos_Permisos, true);
        }

        public void update_Tipo_Permiso(string detalle, int dias, string id_tipo_permiso)
        {
            string sSQL = "begin TIPOS_PERMISOS_TAPI.upd('" + detalle + "' ," + dias + ",'" + id_tipo_permiso + "', 0); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Tipos_Permisos, true);
        }
    }
}
