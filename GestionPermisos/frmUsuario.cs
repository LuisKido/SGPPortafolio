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
    public partial class frmUsuario : Form
    {

        Controlador_Usuarios _controlador_Usuarios;

        string _id_Usuario, _contraseña, _rut;

        bool _nuevo;

        public frmUsuario(clsCore clsCore)
        {
            InitializeComponent();

            _controlador_Usuarios = new Controlador_Usuarios(this, clsCore);

            txtRut.KeyPress += clsValidator.KeyPress_Solo_Letras_Numeros_Sin_Espacio;

            _nuevo = true;
        }

        public frmUsuario(clsCore clsCore, string id_usuario, string contraseña)
        {
            InitializeComponent();
            _controlador_Usuarios = new Controlador_Usuarios(this, clsCore);

            txtRut.KeyPress += clsValidator.KeyPress_Solo_Letras_Numeros_Sin_Espacio;

            _id_Usuario = id_usuario;
            _contraseña = contraseña;
            _nuevo = false;

            btnAgregar.Text = "Actualizar";
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            carga_Unidades();
            carga_Perfiles();

            if (!_nuevo)
            {
                carga_datos();
            }
        } 

        private void carga_datos()
        {
            DataRow[] rows = clsDS.DS_USUARIOS.Tables[0].Select("ID_USUARIO = '" + _id_Usuario + "'");

            if (rows.Length > 0)
            {
                txtRut.Text = rows[0]["RUT"].ToString();
                txtEmail.Text = rows[0]["EMAIL"].ToString();
                txtNombre.Text = rows[0]["NOMBRE"].ToString();

                _rut = rows[0]["RUT"].ToString();

                //cmbUnidades.SelectedIndex = cmbUnidades.FindStringExact(rows[0]["UNIDADES_ID_UNIDAD"].ToString());
                //cmbPerfiles.SelectedIndex = cmbPerfiles.FindStringExact(rows[0]["PERFILES_ID_PERFIL"].ToString());

                cmbUnidades.SelectedValue = rows[0]["UNIDADES_ID_UNIDAD"].ToString();
                cmbPerfiles.SelectedValue = rows[0]["PERFILES_ID_PERFIL"].ToString();

                this.Text += " - " + rows[0]["RUT"].ToString();
            }
        }

        private void carga_Unidades()
        {

            if (clsDS.DS_UNIDADES != null)
            {
                if (clsDS.DS_UNIDADES.Tables.Count > 0)
                {
                    if (clsDS.DS_UNIDADES.Tables[0].Rows.Count > 0)
                    {
                        DataView dv = clsDS.DS_UNIDADES.Tables[0].DefaultView;
                        cmbUnidades.DataSource = dv;
                        cmbUnidades.DisplayMember = "NOMBREUNIDAD";
                        cmbUnidades.ValueMember = "ID_UNIDAD";
                        cmbUnidades.SelectedIndex = 0;
                    }
                }
            }
        }

        private void carga_Perfiles()
        {

            if (clsDS.DS_PERFILES != null)
            {
                if (clsDS.DS_PERFILES.Tables.Count > 0)
                {
                    if (clsDS.DS_PERFILES.Tables[0].Rows.Count > 0)
                    {
                        DataView dv = clsDS.DS_PERFILES.Tables[0].DefaultView;
                        cmbPerfiles.DataSource = dv;
                        cmbPerfiles.DisplayMember = "NOMBREPERFIL";
                        cmbPerfiles.ValueMember = "ID_PERFIL";
                        cmbPerfiles.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.Text == "-")
            {
                txtRut.Text = "";
            }
            else
            {
                if (txtRut.Text.Trim() != string.Empty)
                {
                    txtRut.Text = clsValidator.formatearRut(txtRut.Text);
                    txtRut.SelectionStart = txtRut.Text.Length;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            List<TextBox> tbox = new List<TextBox>();

            tbox.Add(txtEmail);
            tbox.Add(txtRut);
            tbox.Add(txtNombre);

            if (clsValidator.Valida_Vacios(tbox))
            {

                bool valido = clsValidator.validarRut(txtRut.Text);

                string rut = txtRut.Text;
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");

                if (clsValidator.Validar_Email(txtEmail.Text))
                {
                    if (valido)
                    {

                        if (_nuevo)
                        {
                            if (!comprueba_existencia(rut))
                            {
                                _controlador_Usuarios.insert_Usuario(rut, txtEmail.Text, cmbUnidades.SelectedValue.ToString(), cmbPerfiles.SelectedValue.ToString(), txtNombre.Text);
                            }
                        }
                        else
                        {
                            if (rut != _rut)
                            {
                                if (!comprueba_existencia(rut))
                                {
                                    _controlador_Usuarios.update_Usuario(_id_Usuario, rut, txtEmail.Text, cmbUnidades.SelectedValue.ToString(), cmbPerfiles.SelectedValue.ToString(), _contraseña, txtNombre.Text);
                                }
                            }
                            else
                            {
                                _controlador_Usuarios.update_Usuario(_id_Usuario, rut, txtEmail.Text, cmbUnidades.SelectedValue.ToString(), cmbPerfiles.SelectedValue.ToString(), _contraseña, txtNombre.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El rut ingresado no es valido, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El Email ingresado no tiene formato valido, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos solicitados, reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool comprueba_existencia(string rut)
        {
            bool existe = false;

            //DataSet ds = controlador_gestor_implementos.get_trabajadores();

            if (clsDS.DS_USUARIOS != null)
            {
                if (clsDS.DS_USUARIOS.Tables[0] != null)
                {
                    if (clsDS.DS_USUARIOS.Tables[0].Rows.Count > 0)
                    {

                        DataRow[] rows = clsDS.DS_USUARIOS.Tables[0].Select("RUT = '" + rut + "'");

                        if (rows.Length > 0)
                        {
                            MessageBox.Show("El rut ingresado ya existe, reingrese");
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
