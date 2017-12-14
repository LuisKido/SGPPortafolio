using GestionPermisos.Controladores;
using GestionPermisos.DBService;
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
    public partial class frmCambiarPass : Form
    {


        Controlador_Usuarios _controlador_Usuarios;

        public frmCambiarPass(clsCore clsCore)
        {
            InitializeComponent();
            _controlador_Usuarios = new Controlador_Usuarios(this, clsCore);
        }

        private void frmCambiarPass_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbox = new List<TextBox>();

            tbox.Add(txtActual);
            tbox.Add(txtNueva);
            tbox.Add(txtConfirmar);

            if (clsValidator.Valida_Vacios(tbox))
            {
                if (validar_pass(txtActual.Text))
                {
                    if (txtNueva.Text == txtConfirmar.Text)
                    {
                        _controlador_Usuarios.update_Pass(Properties.Settings.Default.ID_USUARIO, txtConfirmar.Text);
                    }
                }
            }
        }

        private bool validar_pass(string passActual)
        {
            string actual = clsCypher.Decrypt(Properties.Settings.Default.PASS_USUARIO, "Portafolio1.");

            if (actual == passActual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
