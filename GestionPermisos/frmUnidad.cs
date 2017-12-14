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
    public partial class frmUnidad : Form
    {

        Controlador_Unidades _controlador_Unidades;

        string _id_Unidad, _nombre_Unidad;

        bool _nuevo;

        public frmUnidad(clsCore clsCore)
        {
            InitializeComponent();
            _controlador_Unidades = new Controlador_Unidades(this, clsCore);

            _nuevo = true;
        }

        public frmUnidad(clsCore clsCore, string id_Unidad)
        {
            InitializeComponent();
            _controlador_Unidades = new Controlador_Unidades(this, clsCore);

            _id_Unidad = id_Unidad;
            _nuevo = false;

            btnAgregar.Text = "Actualizar";
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            if (!_nuevo)
            {
                carga_datos();
            }
        }

        private void carga_datos()
        {
            DataRow[] rows = clsDS.DS_UNIDADES.Tables[0].Select("ID_UNIDAD = '" + _id_Unidad + "'");

            if (rows.Length > 0)
            {
                txtNombre.Text = rows[0]["NOMBREUNIDAD"].ToString();
                _nombre_Unidad = rows[0]["NOMBREUNIDAD"].ToString();
                this.Text += " - " + rows[0]["NOMBREUNIDAD"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbox = new List<TextBox>();

            tbox.Add(txtNombre);

            if (clsValidator.Valida_Vacios(tbox))
            {
                if (_nuevo)
                {
                    if (!comprueba_existencia(txtNombre.Text))
                    {
                        _controlador_Unidades.insert_Unidad(txtNombre.Text);
                    }
                }
                else
                {
                    if (txtNombre.Text != _nombre_Unidad)
                    {
                        if (!comprueba_existencia(txtNombre.Text))
                        {
                            _controlador_Unidades.update_Unidad(_id_Unidad, txtNombre.Text);
                        }
                    }
                    else
                    {
                        _controlador_Unidades.update_Unidad(_id_Unidad, txtNombre.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos solicitados, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool comprueba_existencia(string nombre_unidad)
        {
            bool existe = false;

            //DataSet ds = controlador_gestor_implementos.get_trabajadores();

            if (clsDS.DS_UNIDADES != null)
            {
                if (clsDS.DS_UNIDADES.Tables[0] != null)
                {
                    if (clsDS.DS_UNIDADES.Tables[0].Rows.Count > 0)
                    {

                        DataRow[] rows = clsDS.DS_UNIDADES.Tables[0].Select("NOMBREUNIDAD = '" + nombre_unidad + "'");

                        if (rows.Length > 0)
                        {
                            MessageBox.Show("Ya existe una Unidad con ese nombre, reingrese");
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
