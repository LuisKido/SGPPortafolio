using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Perfiles
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Perfiles(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void insert_Perfil(string nombre, int mTipos, int mUnidades, int gPermisos, int gRes, int authPer, int consPer, int consRes, int verDoc, int descDoc, int genRep)
        {
            string sSQL = "begin PERFILES_TAPI.ins(" + mTipos + ", " + consPer + ",'" + nombre + "'," + descDoc + ",sys_guid(), " + consRes + " , " + mUnidades + ", " +
                "" + gPermisos + "," + authPer + ",1," + gRes + "," + genRep + "," + verDoc + "); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Perfiles, true);
        }

        public void update_Perfil(string id, string nombre, int mTipos, int mUnidades, int gPermisos, int gRes, int authPer, int consPer, int consRes, int verDoc, int descDoc, int genRep)
        {
            string sSQL = "begin PERFILES_TAPI.upd(" + mTipos + ", " + consPer + ",'" + nombre + "'," + descDoc + ",'" + id + "', " + consRes + " , " + mUnidades + ", " +
                "" + gPermisos + "," + authPer + ",1," + gRes + "," + genRep + "," + verDoc + "); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Perfiles, true);
        }
    }
}
