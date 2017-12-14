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
    public partial class frmPermiso : Form
    {

        Controlador_Permisos _controlador_Permisos;

        string _id_Permiso, _id_Detalle;

        bool _nuevo, _nuevo_detalle;

        public frmPermiso(clsCore clsCore)
        {
            InitializeComponent();

            _controlador_Permisos = new Controlador_Permisos(this, clsCore);

            _nuevo = true;
            _nuevo_detalle = true;
        }

        public frmPermiso(clsCore clsCore, string id_Permiso)
        {
            InitializeComponent();
            _controlador_Permisos = new Controlador_Permisos(this, clsCore);

            _id_Permiso = id_Permiso;
            _nuevo = false;
            _nuevo_detalle = true;

            btnAgregar.Text = "Actualizar";
        }

        private void frmPermiso_Load(object sender, EventArgs e)
        {
            carga_Tipos_Permiso();

            if (!_nuevo)
            {
                carga_datos();
            }
        }

        private void carga_datos()
        {
            DataRow[] rows = clsDS.DS_PERMISOS.Tables[0].Select("ID_PERMISO = '" + _id_Permiso + "'");

            if (rows.Length > 0)
            {
                txtMotivo.Text = rows[0]["MOTIVO"].ToString();
                cmbTpoPermiso.SelectedValue = rows[0]["ID_TIPO_PERMISO"].ToString();
                //this.Text += " - " + rows[0]["NOMBREUNIDAD"].ToString();

                if (rows[0]["ID_DETALLE_PERMISO"].ToString() != "")
                {
                    _nuevo_detalle = false;

                    _id_Detalle = rows[0]["ID_DETALLE_PERMISO"].ToString();

                    lblEstado.Text = rows[0]["ESTADO"].ToString();
                    dtInicio.Value = Convert.ToDateTime(rows[0]["FECHAINICIO"].ToString());
                    dtFin.Value = Convert.ToDateTime(rows[0]["FECHAFIN"].ToString());
                    numDias.Value = Convert.ToInt32(rows[0]["DIAS"].ToString());

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_nuevo)
            {
                _controlador_Permisos.insert_Permiso(cmbTpoPermiso.SelectedValue.ToString());
            }
            else
            {
                _controlador_Permisos.update_Detalle(_id_Permiso, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value), _id_Detalle, txtMotivo.Text);
            }
        }

        private void carga_Tipos_Permiso()
        {

            if (clsDS.DS_TIPOS_PERMISOS != null)
            {
                if (clsDS.DS_TIPOS_PERMISOS.Tables.Count > 0)
                {
                    if (clsDS.DS_TIPOS_PERMISOS.Tables[0].Rows.Count > 0)
                    {
                        DataView dv = clsDS.DS_TIPOS_PERMISOS.Tables[0].DefaultView;
                        cmbTpoPermiso.DataSource = dv;
                        cmbTpoPermiso.DisplayMember = "DETALLEPERMISO";
                        cmbTpoPermiso.ValueMember = "ID_TIPO_PERMISO";
                        cmbTpoPermiso.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void exito_Permiso()
        {
            DataSet ds = await _controlador_Permisos.get_last_id();

            DataRow[] rows = ds.Tables[0].Select();

            if (rows.Length > 0)
            {
                _id_Permiso = rows[0]["ID_PERMISO"].ToString();
                _nuevo = false;

                _controlador_Permisos.insert_Detalle(_id_Permiso, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value), txtMotivo.Text);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (_nuevo_detalle)
            {
                _controlador_Permisos.insert_Detalle(_id_Permiso, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value), txtMotivo.Text);
            }
            else
            {
                //_controlador_Permisos.update_Detalle(_id_Permiso, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value), _id_Detalle);
            }
        }
    }
}
