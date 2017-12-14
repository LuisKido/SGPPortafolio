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
using System.Reflection;

namespace GestionPermisos
{
    public partial class frmPrincipal : Form
    {

        clsCore _clsCore;


        public frmPrincipal(clsCore clsCore, DataRow privilegios, DataRow autenticante)
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            trasbasePerfil(privilegios, autenticante);
            _clsCore = clsCore;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MainMenuStrip = new MenuStrip();
            this.SetBevel(false);

            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(52, 52, 52);
                    // 4#
                    break;
                }
            }

            cargaDatosUsuario();
            STARTUP();

        }

        //private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        //{
        //    if (this.ActiveMdiChild == null)
        //        tabForms.Visible = false; // If no any child form, hide tabControl
        //    else
        //    {
        //        this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

        //        // If child form is new and no has tabPage, create new tabPage
        //        if (this.ActiveMdiChild.Tag == null)
        //        {
        //            // Add a tabPage to tabControl with child form caption
        //            TabPage tp = new TabPage(this.ActiveMdiChild.Text);
        //            tp.Tag = this.ActiveMdiChild;
        //            tp.Parent = tabForms;
        //            tabForms.SelectedTab = tp;

        //            this.ActiveMdiChild.Tag = tp;
        //            this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
        //        }

        //        if (!tabForms.Visible) tabForms.Visible = true;
        //    }
        //}

        //private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    ((sender as Form).Tag as TabPage).Dispose();
        //}

        //private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
        //        (tabForms.SelectedTab.Tag as Form).Select();
        //}

        private void btnTiposPermisos_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarTiposPermisos)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarTiposPermisos frm = new frmListarTiposPermisos(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarUnidades)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarUnidades frm = new frmListarUnidades(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarUsuarios)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarUsuarios frm = new frmListarUsuarios(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarPerfiles)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarPerfiles frm = new frmListarPerfiles(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnMisPermisos_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarPermisos)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarPermisos frm = new frmListarPermisos(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnGestionPermisos_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmGestionarPermisos)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmGestionarPermisos frm = new frmGestionarPermisos(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnResoluciones_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmListarResoluciones)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmListarResoluciones frm = new frmListarResoluciones(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnVerificadorDocumentos_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmValidadorDocumentos)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmValidadorDocumentos frm = new frmValidadorDocumentos(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private async void STARTUP()
        {
            this.Enabled = false;

            List<clsDS.DATASETSQL> list = new List<clsDS.DATASETSQL>();

            list.Add(clsDS.DATASETSQL.Usuarios);
            list.Add(clsDS.DATASETSQL.Unidades);
            list.Add(clsDS.DATASETSQL.Perfiles);
            list.Add(clsDS.DATASETSQL.Tipos_Permisos);
            list.Add(clsDS.DATASETSQL.Permisos);
            list.Add(clsDS.DATASETSQL.Resoluciones);

            frmWait frm = new frmWait(true, list);

            MethodInfo dynMethod = frm.GetType().GetMethod("exito",
            BindingFlags.NonPublic | BindingFlags.Instance);

            Delegate del = _clsCore.CreateDelegateWithObjectParameters(frm, dynMethod);

            frm.Show();
            foreach (clsDS.DATASETSQL destino in list)
            {
                frm.BringToFront();
                await _clsCore.UPDATE_DATASET(destino);
                frm.BeginInvoke(del);
            }

            frm.Close();
            this.Enabled = true;
            this.BringToFront();
        }

        /// <summary>
        /// Método que modifica la vista principal según los permisos de la cuenta autenticandose.
        /// </summary>
        /// <param name="rowPrivilegios">Fila de valores de distintos permisos para indicar que controles deshabilitar.</param>
        /// <param name="autenticante">Información del usuario autenticandose para pasar información a forms posteriores.</param>
        private void trasbasePerfil(DataRow rowPrivilegios, DataRow autenticante)
        {
            #region Privilegios
            if (Int32.Parse(rowPrivilegios["CRUD_TIPOS_AUTH"].ToString()) == 0)
            {
                btnTiposPermisos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["CRUD_MOTIVOS_AUTH"].ToString()) == 0)
            {
                btnTiposPermisos.Visible = false;
                
            }
            if (Int32.Parse(rowPrivilegios["CRUD_UNIDADES_AUTH"].ToString()) == 0)
            {
                btnUnidades.Visible = false;
                btnUsuarios.Visible = false;
                btnPerfiles.Visible = false;
                btnUnidades.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["GEN_PERMISOS_AUTH"].ToString()) == 0)
            {
                btnMisPermisos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["GEN_RESOLUCIONES_AUTH"].ToString()) == 0)
            {
                btnResoluciones.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["AUTH_PERMISOS_AUTH"].ToString()) == 0)
            {
                btnGestionPermisos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["QRY_PERMISOS_AUTH"].ToString()) == 0)
            {
                //btnMisPermisos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["VER_DOCUMENTOS_AUTH"].ToString()) == 0)
            {
                //btnVerificadorDocumentos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["DOW_DOCUMENTOS_AUTH"].ToString()) == 0)
            {
                //btnVerificadorDocumentos.Visible = false;
            }
            if (Int32.Parse(rowPrivilegios["GEN_REPORTES_AUTH"].ToString()) == 0)
            {
                btnGeneradorReportes.Visible = false;
            }
            #endregion
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ID_USUARIO = "";
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void cargaDatosUsuario()
        {
            DataRow[] rows = clsDS.DS_USUARIOS.Tables[0].Select("ID_USUARIO = '" + Properties.Settings.Default.ID_USUARIO + "'");

            if (rows.Length > 0)
            {
                lblNombreUsuario.Text = rows[0]["NOMBRE"].ToString();

                DataRow[] rows2 = clsDS.DS_PERFILES.Tables[0].Select("ID_PERFIL = '" + rows[0]["PERFILES_ID_PERFIL"].ToString() + "'");

                if (rows2.Length > 0)
                {
                    lblCargo.Text = rows2[0]["NOMBREPERFIL"].ToString();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            cmsUsuario.Show(ptLowerLeft);
        }

        private void tsmCambiarPass_Click(object sender, EventArgs e)
        {
            frmCambiarPass frm = new frmCambiarPass(_clsCore);
            frm.Show();
        }

        private void btnGeneradorReportes_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            pnlWelcome.Hide();

            foreach (var form in this.MdiChildren)
            {
                if (form is frmGeneradorReportes)
                {
                    abierto = true;
                    form.BringToFront();
                    form.Activate();
                    break;
                }
                else
                {
                    abierto = false;
                }
            }

            if (!abierto)
            {
                frmGeneradorReportes frm = new frmGeneradorReportes(_clsCore);
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
