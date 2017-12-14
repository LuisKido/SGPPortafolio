using GestionPermisos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos
{
    public partial class frmEstadoPermiso : Form
    {
        Controlador_Estado_Permiso _controlador_Estado_Permiso;

        string _id_Permiso, _id_Detalle;

        public frmEstadoPermiso(clsCore clsCore)
        {
            _controlador_Estado_Permiso = new Controlador_Estado_Permiso(this, clsCore);
            InitializeComponent();
        }

        private void frmEstadoPermiso_Load(object sender, EventArgs e)
        {
            carga_Tipos_Permiso();

            carga_datos();
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
                    _id_Detalle = rows[0]["ID_DETALLE_PERMISO"].ToString();

                    //lblEstado.Text = rows[0]["ESTADO"].ToString();
                    dtInicio.Value = Convert.ToDateTime(rows[0]["FECHAINICIO"].ToString());
                    dtFin.Value = Convert.ToDateTime(rows[0]["FECHAFIN"].ToString());
                    numDias.Value = Convert.ToInt32(rows[0]["DIAS"].ToString());

                }

                switch (rows[0]["ESTADO"].ToString())
                {
                    case "1":
                        cmbEstado.SelectedIndex = 0;
                        break;

                    case "2":
                        cmbEstado.SelectedIndex = 1;
                        break;

                    case "3":
                        cmbEstado.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }
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

        public frmEstadoPermiso(clsCore clsCore, string id_Permiso)
        {
            InitializeComponent();
            _controlador_Estado_Permiso = new Controlador_Estado_Permiso(this, clsCore);

            _id_Permiso = id_Permiso;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            _controlador_Estado_Permiso.update_Detalle(_id_Permiso, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value), _id_Detalle, cmbEstado.SelectedIndex.ToString(), txtMotivo.Text);
            send_email();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            clsPrinter printer = new clsPrinter();
            printer.printPermiso(_id_Permiso, "Pendiente", cmbTpoPermiso.SelectedText, dtInicio.Value.ToShortDateString(), dtFin.Value.ToShortDateString(), Convert.ToInt32(numDias.Value).ToString(), txtMotivo.Text, Properties.Settings.Default.RUT_USUARIO, "Permiso");
            MessageBox.Show("Permiso exportado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void send_email()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("homeworld.universe@gmail.com");

                DataRow[] rowsPermiso = clsDS.DS_PERMISOS.Tables[0].Select("ID_PERMISO = '" + _id_Permiso + "'");

                string id_usuario = rowsPermiso[0]["USUARIOS_ID_USUARIO"].ToString();

                DataRow[] rowsUsuario = clsDS.DS_USUARIOS.Tables[0].Select("ID_USUARIO = '" + id_usuario + "'");

                message.To.Add(rowsUsuario[0]["EMAIL"].ToString());

                message.Subject = "Su permiso ha cambiado su estado.";

                message.Body = "<h1> Su Permiso id: " + _id_Permiso + " :</h1> \n";
                message.Body += "\n";
                message.IsBodyHtml = true;

                string estado = "";

                int estadoi = cmbEstado.SelectedIndex;

                switch (estadoi)
                {
                    case 1:
                        estado = "PENDIENTE";
                        break;
                    case 2:
                        estado = "APROVADO";
                        break;
                    case 3:
                        estado = "RECHAZADO";
                        break;
                }

                message.Body += "<h2> Ha cambiado su estado a : " + estado + " :</h2> \n";

                smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("homeworld.universe@gmail.com", "kuun-lan94252743");
                smtp.SendAsync(message, message.Subject);
            }
            catch(Exception ex)
            {

            }
        }
    }

}
