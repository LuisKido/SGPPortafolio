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
    public partial class frmTipoPermiso : Form
    {

        Controlador_Tipos_Permisos _controlador_Tipos_Permisos;

        string _id_TPermiso, _detalle_Permiso;

        bool _nuevo;

        public frmTipoPermiso(clsCore clsCore)
        {
            InitializeComponent();

            _controlador_Tipos_Permisos = new Controlador_Tipos_Permisos(this, clsCore);

            _nuevo = true;
        }

        public frmTipoPermiso(clsCore clsCore, string id_TPermiso)
        {
            InitializeComponent();
            _controlador_Tipos_Permisos = new Controlador_Tipos_Permisos(this, clsCore);

            _id_TPermiso = id_TPermiso;
            _nuevo = false;

            btnAgregar.Text = "Actualizar";
        }

        private void carga_datos()
        {
            DataRow[] rows = clsDS.DS_TIPOS_PERMISOS.Tables[0].Select("ID_TIPO_PERMISO = '" + _id_TPermiso + "'");

            if (rows.Length > 0)
            {
                txtDetalle.Text = rows[0]["DETALLEPERMISO"].ToString();
                _detalle_Permiso = rows[0]["DETALLEPERMISO"].ToString();
                numDias.Value = Convert.ToInt32(rows[0]["DIASAFECTOS"].ToString());

                this.Text += " - " + rows[0]["DETALLEPERMISO"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbox = new List<TextBox>();

            tbox.Add(txtDetalle);

            if (clsValidator.Valida_Vacios(tbox))
            {
                if (_nuevo)
                {
                    if (!comprueba_existencia(txtDetalle.Text))
                    {
                        _controlador_Tipos_Permisos.insert_Tipo_Permiso(txtDetalle.Text, Convert.ToInt32(numDias.Value));
                    }
                }
                else
                {
                    if (txtDetalle.Text != _detalle_Permiso)
                    {
                        if (!comprueba_existencia(txtDetalle.Text))
                        {
                            _controlador_Tipos_Permisos.update_Tipo_Permiso(txtDetalle.Text, Convert.ToInt32(numDias.Value), _id_TPermiso);
                        }
                    }
                    else
                    {
                        _controlador_Tipos_Permisos.update_Tipo_Permiso(txtDetalle.Text, Convert.ToInt32(numDias.Value), _id_TPermiso);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos solicitados, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTipoPermiso_Load(object sender, EventArgs e)
        {
            if (!_nuevo)
            {
                carga_datos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool comprueba_existencia(string detalle_permiso)
        {
            bool existe = false;

            //DataSet ds = controlador_gestor_implementos.get_trabajadores();

            if (clsDS.DS_TIPOS_PERMISOS != null)
            {
                if (clsDS.DS_TIPOS_PERMISOS.Tables[0] != null)
                {
                    if (clsDS.DS_TIPOS_PERMISOS.Tables[0].Rows.Count > 0)
                    {

                        DataRow[] rows = clsDS.DS_TIPOS_PERMISOS.Tables[0].Select("DETALLEPERMISO = '" + detalle_permiso + "'");

                        if (rows.Length > 0)
                        {
                            MessageBox.Show("Ya existe un tipo permiso con ese detalle, reingrese");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        existe = false;
                    }
                }
            }

            return existe;
        }
    }
}
