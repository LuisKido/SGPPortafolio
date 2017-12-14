using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Usuarios
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Usuarios(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void insert_Usuario(string rut, string email, string id_unidad, string id_perfil, string nombre)
        {
            string sSQL = "begin USUARIOS_TAPI.ins('1234','" + rut + "',sys_guid(), '" + id_unidad + "', '" + id_perfil + "' , '" + email + "',0,'" + nombre + "'); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Usuarios, true);
        }

        public void update_Usuario(string id_usuario, string rut, string email, string id_unidad, string id_perfil, string contraseña, string nombre)
        {
            string sSQL = "begin USUARIOS_TAPI.upd('" + contraseña + "','" + rut + "','" + id_usuario + "', '" + id_unidad + "', '" + id_perfil + "' , '" + email + "', 0, '" + nombre + "'); end;";
            _clsCore.SQL_NON_ASYNCCOREQUERY_DS(sSQL, "exito_carga", _frmOrigen, _frmOrigen.Owner, clsDS.DATASETSQL.Usuarios, true);
        }

        public void update_Pass(string id_usuario, string contraseña)
        {
            string sSQL = "UPDATE USUARIOS SET CONTRASENA = '" + contraseña + "' WHERE ID_USUARIO = '" + id_usuario + "'";
            _clsCore.SQL_NON_ASYNC_QUERY(sSQL, _frmOrigen, true, true);
        }
    }
}
