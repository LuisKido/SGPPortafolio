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

namespace GestionPermisos
{
    public partial class frmListarPerfiles : Form
    {

        clsCore _clsCore;

        Controlador_Perfiles _controlador_Perfiles;

        public frmListarPerfiles(clsCore clsCore)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            _clsCore = clsCore;
            _controlador_Perfiles = new Controlador_Perfiles(this, _clsCore);
        }

        private void frmListarPerfiles_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            CargaDatos();
        }

        private void CargaDatos()
        {
            //Lista de dataset a actualizar
            List<clsDS.DATASETSQL> destinos = new List<clsDS.DATASETSQL>();
            destinos.Add(clsDS.DATASETSQL.Perfiles);

            //Metodo que ejecutara el select al DS y tiene sus distintas propiedades para le formulario.
            _clsCore.SQL_NON_ASYNCORE_DS(this, "exito_carga", destinos, false, true, true);

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Nombre", typeof(string));
            //dt.Columns.Add("Tipos", typeof(string));
            //dt.Columns.Add("Unidades", typeof(string));
            //dt.Columns.Add("Permisos", typeof(string));
            //dt.Columns.Add("Resoluciones", typeof(string));

            //dt.Rows.Add("Funcionario", "No", "No", "Si", "No");
            //dt.Rows.Add("Administrador", "Si", "Si", "Si", "Si");

            //olvPerfiles.SetObjects(clsDS.DS_PERFILES.Tables[0].Select());
        }


        //Metodo exito que carga los datos en el OLV
        private void exito_carga()
        {
            olvPerfiles.SetObjects(clsDS.DS_PERFILES.Tables[0].Select());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvPerfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvPerfiles.SelectedObject != null)
            {
                string id_perfil = ((DataRow)olvPerfiles.SelectedObject)["ID_PERFIL"].ToString();

                frmPerfil frm = new frmPerfil(_clsCore, id_perfil);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (olvPerfiles.SelectedObject != null)
            {
                string id_perfil = ((DataRow)olvPerfiles.SelectedObject)["ID_PERFIL"].ToString();

                frmPerfil frm = new frmPerfil(_clsCore, id_perfil);
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void tsmNueva_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil(_clsCore);
            frm.Owner = this;
            frm.Show();
        }

        private void olvPerfiles_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if(e.Column.Name != "Nombre Perfil")
            {
                if(e.SubItem.Text == "1")
                {
                    e.SubItem.Text = "Si";
                }
                else if(e.SubItem.Text == "0")
                {
                    e.SubItem.Text = "No";
                }
            }
        }
    }
}
