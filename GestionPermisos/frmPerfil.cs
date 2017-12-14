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
    public partial class frmPerfil : Form
    {
        Controlador_Perfiles _controlador_Perfiles;

        string _id_Perfil, _nombre_Perfil;

        bool _nuevo;

        public frmPerfil(clsCore clsCore)
        {
            InitializeComponent();

            _controlador_Perfiles = new Controlador_Perfiles(this, clsCore);

            _nuevo = true;
        }

        public frmPerfil(clsCore clsCore, string id_Perfil)
        {
            InitializeComponent();
            _controlador_Perfiles = new Controlador_Perfiles(this, clsCore);

            _id_Perfil = id_Perfil;
            _nuevo = false;

            btnAgregar.Text = "Actualizar";
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            if (!_nuevo)
            {
                carga_datos();
            }
        }

        private void carga_datos()
        {
            DataRow[] rows = clsDS.DS_PERFILES.Tables[0].Select("ID_PERFIL = '" + _id_Perfil + "'");

            if (rows.Length > 0)
            {
                txtNombre.Text = rows[0]["NOMBREPERFIL"].ToString();
                _nombre_Perfil = rows[0]["NOMBREPERFIL"].ToString();
                chkmTipos.Checked = Convert.ToBoolean(rows[0]["CRUD_TIPOS_AUTH"]);
                chkmUnidades.Checked = Convert.ToBoolean(rows[0]["CRUD_UNIDADES_AUTH"]);
                chkgPer.Checked = Convert.ToBoolean(rows[0]["GEN_PERMISOS_AUTH"]);
                chkgRes.Checked = Convert.ToBoolean(rows[0]["GEN_RESOLUCIONES_AUTH"]);
                chkAuthPer.Checked = Convert.ToBoolean(rows[0]["AUTH_PERMISOS_AUTH"]);
                chkconPer.Checked = Convert.ToBoolean(rows[0]["QRY_PERMISOS_AUTH"]);
                chkconRes.Checked = Convert.ToBoolean(rows[0]["QRY_RESOLUCIONES_AUTH"]);
                chkverDoc.Checked = Convert.ToBoolean(rows[0]["VER_DOCUMENTOS_AUTH"]);
                chkdesDoc.Checked = Convert.ToBoolean(rows[0]["DOW_DOCUMENTOS_AUTH"]);
                chkgrepo.Checked = Convert.ToBoolean(rows[0]["GEN_REPORTES_AUTH"]);


                this.Text += " - " + rows[0]["NOMBREPERFIL"].ToString();
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
                        _controlador_Perfiles.insert_Perfil(txtNombre.Text, Convert.ToInt32(chkmTipos.Checked), Convert.ToInt32(chkmUnidades.Checked), Convert.ToInt32(chkgPer.Checked), Convert.ToInt32(chkgRes.Checked), Convert.ToInt32(chkAuthPer.Checked), Convert.ToInt32(chkconPer.Checked), Convert.ToInt32(chkconRes.Checked), Convert.ToInt32(chkverDoc.Checked), Convert.ToInt32(chkdesDoc.Checked), Convert.ToInt32(chkgrepo.Checked));
                    }
                }
                else
                {
                    if (txtNombre.Text != _nombre_Perfil)
                    {
                        if (!comprueba_existencia(txtNombre.Text))
                        {
                            _controlador_Perfiles.update_Perfil(_id_Perfil, txtNombre.Text, Convert.ToInt32(chkmTipos.Checked), Convert.ToInt32(chkmUnidades.Checked), Convert.ToInt32(chkgPer.Checked), Convert.ToInt32(chkgRes.Checked), Convert.ToInt32(chkAuthPer.Checked), Convert.ToInt32(chkconPer.Checked), Convert.ToInt32(chkconRes.Checked), Convert.ToInt32(chkverDoc.Checked), Convert.ToInt32(chkdesDoc.Checked), Convert.ToInt32(chkgrepo.Checked));
                        }
                    }
                    else
                    {
                        _controlador_Perfiles.update_Perfil(_id_Perfil, txtNombre.Text, Convert.ToInt32(chkmTipos.Checked), Convert.ToInt32(chkmUnidades.Checked), Convert.ToInt32(chkgPer.Checked), Convert.ToInt32(chkgRes.Checked), Convert.ToInt32(chkAuthPer.Checked), Convert.ToInt32(chkconPer.Checked), Convert.ToInt32(chkconRes.Checked), Convert.ToInt32(chkverDoc.Checked), Convert.ToInt32(chkdesDoc.Checked), Convert.ToInt32(chkgrepo.Checked));
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

        private bool comprueba_existencia(string nombre_perfil)
        {
            bool existe = false;

            //DataSet ds = controlador_gestor_implementos.get_trabajadores();

            if (clsDS.DS_PERFILES != null)
            {
                if (clsDS.DS_PERFILES.Tables[0] != null)
                {
                    if (clsDS.DS_PERFILES.Tables[0].Rows.Count > 0)
                    {

                        DataRow[] rows = clsDS.DS_PERFILES.Tables[0].Select("NOMBREPERFIL = '" + nombre_perfil + "'");

                        if (rows.Length > 0)
                        {
                            MessageBox.Show("Ya existe un Perfil con ese nombre, reingrese");
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
