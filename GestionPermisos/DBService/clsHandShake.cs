using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPermisos.DBService
{
    public class clsHandShake
    {
        private string user { get; set; }
        private string pass { get; set; }
        private clsOracleDB conexion;
        public clsHandShake(string usuario, string contraseña)
        {
            conexion = new clsOracleDB();
            user = usuario;
            pass = clsCypher.Encrypt(contraseña, "Passw0rd");
        }
        private DataSet obtenerPerfilado(bool result, int idPerfil)
        {
            try
            {
                if (!result)
                {
                    // Se cancela el perfilado
                    return null;
                }
                else
                {
                    DataSet perfil = conexion.SQL_GET_DATASET("SELECT * FROM PERFILES WHERE ID_PERFIL="+idPerfil+";");
                    return perfil;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool loginUsuario()
        {
            try
            {
                DataSet usuario = conexion.SQL_GET_DATASET("SELECT * FROM USUARIO WHERE CONTRASENA =" + pass + ";");
                if (usuario != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
