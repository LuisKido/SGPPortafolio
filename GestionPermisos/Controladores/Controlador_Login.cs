using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPermisos.DBService;
using System.Data;

namespace GestionPermisos.Controladores
{
    public class Controlador_Login
    {
        clsCore _clsCore;
        Form _frmOrigen;
        
        clsOracleDB _clsOracle;//Esta es una implementación temporal hasta que pueda encontrar un implementación que pase a traves del clsCore;

        public Controlador_Login(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
            _clsOracle = new DBService.clsOracleDB();
        }
    }
}
