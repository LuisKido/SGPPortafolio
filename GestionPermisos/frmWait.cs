using GestionPermisos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos
{
    public partial class frmWait : Form
    {

        bool _startUP;

        List<clsDS.DATASETSQL> _list;

        int _porcentaje, _total, _llamadas;

        private void frmWait_Load(object sender, EventArgs e)
        {
            lcCargando.Active = true;
            lcCargando.InnerCircleRadius = 14;
            lcCargando.OuterCircleRadius = 12;
            lcCargando.NumberSpoke = 40;
            lcCargando.RotationSpeed = 20;
        }

        private void frmWait_Resize(object sender, EventArgs e)
        {
            lcCargando.Location = new Point(this.Width / 2 - lcCargando.Width / 2, this.Height / 2 - lcCargando.Height / 2);
            lblCargando.Location = new Point(this.Width / 2 - lblCargando.Width / 2, lcCargando.Location.Y + lcCargando.Height);
            lblPorcentaje.Location = new Point(this.Width / 2 + lblCargando.Width - lblPorcentaje.Width / 2, lcCargando.Location.Y + lcCargando.Height);
        }

        public frmWait(bool starUP, List<clsDS.DATASETSQL> list)
        {
            InitializeComponent();

            _startUP = starUP;

            _total = list.Count;
            _llamadas = 0;
        }

        private void exito()
        {
            _llamadas = _llamadas + 1;

            _porcentaje = (_llamadas * 100) / _total;

            lblPorcentaje.Text = _porcentaje.ToString() + "%";
        }
    }
}
