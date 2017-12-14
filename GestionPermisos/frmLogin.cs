using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPermisos.Controladores;
using GestionPermisos.DBService;

namespace GestionPermisos
{
    public partial class frmLogin : Form
    {
        clsCore _clsCore;
        Controlador_Login ctrlLogin;

        public frmLogin()
        {
            InitializeComponent();
            pnlBackGround.BackColor = Color.FromArgb(160, 0, 0, 0);
            pnlTop.BackColor = Color.FromArgb(120, 0, 0, 0);
            pnlLogin.BackColor = Color.FromArgb(180, 192, 192, 192);

            pnlLogin.Location = new Point(
            this.ClientSize.Width / 2 - pnlLogin.Size.Width / 2,
            this.ClientSize.Height / 2 - pnlLogin.Size.Height / 2);
            pnlLogin.Anchor = AnchorStyles.None;

            _clsCore = new clsCore();
            ctrlLogin = new Controlador_Login(this, _clsCore);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            #region Implementación Demo
            try
            {

                List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
                destinos.Add(clsDS.DATASETSQL.Usuarios);
                destinos.Add(clsDS.DATASETSQL.Perfiles);

                //Preparación del DataSet para realizar la autenticación
                //_clsCore.SQL_NON_ASYNCCORE_DS(this, destinos.First(), false);
                //_clsCore.SQL_NON_ASYNCCORE_DS(this, destinos.Last(), false);

                _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, false);


            }
            catch (Exception ex)
            {
                labelError.Visible = true;
            }
            #endregion

        }

        private void exito_carga()
        {

            try
            {
                string rut = txtUsuario.Text;
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                //Voy a buscar el usuario autenticante al DS de usuarios para ver correspondencia.
                DataRow[] autenticante = clsDS.DS_USUARIOS.Tables[0].Select("RUT='" + rut + "' AND CONTRASENA='" + txtPass.Text + "'");
                DataRow[] privilegios_autenticante = clsDS.DS_PERFILES.Tables[0].Select("ID_PERFIL='" + autenticante[0]["PERFILES_ID_PERFIL"] + "'");
                Form frm = new frmPrincipal(_clsCore, privilegios_autenticante[0], autenticante[0]);

                Properties.Settings.Default.ID_USUARIO = autenticante[0]["ID_USUARIO"].ToString();
                Properties.Settings.Default.RUT_USUARIO = autenticante[0]["RUT"].ToString();

                string passcy = clsCypher.Encrypt(autenticante[0]["CONTRASENA"].ToString(), "Portafolio1.");

                Properties.Settings.Default.PASS_USUARIO = passcy;

                Properties.Settings.Default.Save();

                this.Hide();

                frm.FormClosed += (s, aegs) => this.Close();
                frm.Show();
            }
            catch (Exception ex)
            {
                labelError.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "-")
            {
                txtUsuario.Text = "";
            }
            else
            {
                if (txtUsuario.Text.Trim() != string.Empty)
                {
                    txtUsuario.Text = clsValidator.formatearRut(txtUsuario.Text);
                    txtUsuario.SelectionStart = txtUsuario.Text.Length;
                }
            }
        }
    }
}
