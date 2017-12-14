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
    public partial class frmListarUsuarios : Form
    {
        clsCore _clsCore;

        Controlador_Usuarios _controlador_Usuarios;

        public frmListarUsuarios(clsCore clsCore)
        {
            InitializeComponent();

            //this.WindowState = FormWindowState.Maximized;

            _clsCore = clsCore;
            _controlador_Usuarios = new Controlador_Usuarios(this, _clsCore);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Lista de dataset a actualizar
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Usuarios);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para le formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);
        }

        //Metodo exito que carga los datos en el OLV
        private void exito_carga()
        {
            olvUsuarios.SetObjects(clsDS.DS_USUARIOS.Tables[0].Select());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvUsuarios.SelectedObject != null)
            {
                string id_usuario = ((DataRow)olvUsuarios.SelectedObject)["ID_USUARIO"].ToString();
                string contraseña = ((DataRow)olvUsuarios.SelectedObject)["CONTRASENA"].ToString();

                frmUsuario frm = new frmUsuario(_clsCore, id_usuario, contraseña);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void olvUsuarios_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            if (((DataRow)e.Model)["RUT"].ToString() != "")
            {
                e.Item.Text = clsValidator.formatearRut(e.Item.Text);
            }
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (olvUsuarios.SelectedObject != null)
            {
                string id_usuario = ((DataRow)olvUsuarios.SelectedObject)["ID_USUARIO"].ToString();
                string contraseña = ((DataRow)olvUsuarios.SelectedObject)["CONTRASENA"].ToString();

                frmUsuario frm = new frmUsuario(_clsCore, id_usuario, contraseña);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void tsmNueva_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void tsmDesempeño_Click(object sender, EventArgs e)
        {
            if (olvUsuarios.SelectedObject != null)
            {

                string id_usuario = ((DataRow)olvUsuarios.SelectedObject)["ID_USUARIO"].ToString();

                clsXMLGenerator _clsXMLGenerator = new clsXMLGenerator(_clsCore, this);
                _clsXMLGenerator.generar_XMLDesempeño(id_usuario);
            }
        }
    }
}
