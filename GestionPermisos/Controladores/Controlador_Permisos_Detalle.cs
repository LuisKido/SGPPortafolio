using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class Controlador_Permisos_Detalle
    {
        clsCore _clsCore;

        Form _frmOrigen;

        public Controlador_Permisos_Detalle(Form frmOrigen, clsCore clsCore)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }
    }
}
