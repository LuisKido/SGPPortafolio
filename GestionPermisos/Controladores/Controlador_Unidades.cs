using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Unidades
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Unidades(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void insert_Unidad(string nombre)
        {
            string sSQL = "begin UNIDADES_TAPI.ins('" + nombre + "',sys_guid(),0); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Unidades, true);
        }

        public void update_Unidad(string id, string nombre)
        {
            string sSQL = "begin UNIDADES_TAPI.upd('" + nombre + "', '" + id + "', 0); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Unidades, true);
        }
    }
}
