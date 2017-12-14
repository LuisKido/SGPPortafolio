using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRG.Controls.UI;
using System.Drawing;
using System.Data;

namespace GestionPermisos.Controladores
{
    public class clsCore
    {

        //clsOracleDB la voy a usar como asistente con el WS.
        DBService.clsOracleDB _clsOracleDB;

        //Formularios pienso que siempre habra un Origen y un Owner aparte del formulario que viene.
        Form _frmOrigen;
        Form _frmOwner;

        //Objetos del panel que despues voy a editar
        Panel pnlwait;
        LoadingCircle circle;
        Label lblCargando;

        /// <summary>
        /// Constructor que inicializa la clase clsOracleDB en esa clase esta la conexion a la BD que deberia estar en un WS.
        /// </summary>
        public clsCore()
        {
            _clsOracleDB = new DBService.clsOracleDB();
        }

        /// <summary>
        /// Metodo que ejecuta una consulta asincronica sin esperar un resultado.
        /// </summary>
        /// <param name="sSQL">Query en texto para mandar a la BD</param>
        /// <param name="frmOrigen">Formulario de Origen</param>
        /// <param name="cerrarForm">Si es que se quiere cerrar el form</param>
        /// <param name="inhabilitar_form">Si es que se quiere inhabilitar el form</param>
        public async void SQL_NON_ASYNC_QUERY(string sSQL, Form frmOrigen, bool cerrarForm, bool inhabilitar_form)
        {
            _frmOrigen = frmOrigen;

            inhabilitar_formOrigen(inhabilitar_form);

            await _clsOracleDB.SQL_NON_QUERY_ASYNC(sSQL);

            habiitar_formOrigen(cerrarForm);
        }

        /// <summary>
        /// Metodo que actualiza un DS estatico y ejecuta un metodo de exito.
        /// </summary>
        /// <param name="frmOrigen">Formulario de Origen</param>
        /// <param name="metodo_Exito">Metodo de exito llamado en string</param>
        /// <param name="dsdestino">Dataset Destino a actualizar</param>
        /// <param name="cerrarForm">Si se desea cerrar el form</param>
        /// <param name="inhabilitarForm">Si se desea inhabilitar el form</param>
        public async void SQL_NON_ASYNCORE_DS(Form frmOrigen, string metodo_Exito, clsDS.DATASETSQL dsdestino, bool cerrarForm, bool inhabilitarForm)
        {
            _frmOrigen = frmOrigen;

            MethodInfo dynMethod = _frmOrigen.GetType().GetMethod(metodo_Exito,
            BindingFlags.NonPublic | BindingFlags.Instance);


            inhabilitar_formOrigen(inhabilitarForm);

            await UPDATE_DATASET(dsdestino);

            Delegate del = CreateDelegateWithObjectParameters(_frmOrigen, dynMethod);

            _frmOrigen.BeginInvoke(del);


            habiitar_formOrigen(cerrarForm);

        }

        /// <summary>
        /// Metodo que realiza una query tiene la capacidad de actualizar uno o mas Dataset estatico y maneja las interfaces.
        /// </summary>
        /// <param name="frmOrigen">Formulario de donde es llamado</param>
        /// <param name="metodo_Exito">Metodo exito que debe ser escrito en string y coincidir con el del formulario origen</param>
        /// <param name="destinos">Lista de destionos de Dataset</param>
        /// <param name="cerrarForm">Si es que al finalizar quiero cerrar el form</param>
        /// <param name="inhabilitarForm">Si lo quiero inhabilitar los controles</param>
        /// <param name="inhabilitarOwner">Si quiero desabilitar el owner del formulario</param>
        public async void SQL_NON_ASYNCORE_DS(Form frmOrigen, string metodo_Exito, List<clsDS.DATASETSQL> destinos, bool cerrarForm, bool inhabilitarForm, bool inhabilitarOwner)
        {
            _frmOrigen = frmOrigen;

            MethodInfo dynMethod = _frmOrigen.GetType().GetMethod(metodo_Exito,
            BindingFlags.NonPublic | BindingFlags.Instance);

            inhabilitar_formOrigen(inhabilitarForm);

            if (inhabilitarOwner)
            {
                inhabilitar_MDIParent();
            }

            foreach (clsDS.DATASETSQL destino in destinos)
            {
                await UPDATE_DATASET(destino);
            }

            Delegate del = CreateDelegateWithObjectParameters(_frmOrigen, dynMethod);

            _frmOrigen.BeginInvoke(del);

            if (inhabilitarOwner)
            {
                habilitar_MDIParent();
            }

            habiitar_formOrigen(cerrarForm);
        }

        public async void SQL_NON_ASYNCCOREQUERY_DS(string sSQL, string metodo_Exito_Owner, Form frmOrigen, Form frmOwner, clsDS.DATASETSQL dsdestino, bool cerrarForm)
        {
            _frmOrigen = frmOrigen;

            MethodInfo dynMethod = frmOwner.GetType().GetMethod(metodo_Exito_Owner,
            BindingFlags.NonPublic | BindingFlags.Instance);

            inhabilitar_formOrigen(true);

            await _clsOracleDB.SQL_NON_QUERY_ASYNC(sSQL);
            await UPDATE_DATASET(dsdestino);

            Delegate del = CreateDelegateWithObjectParameters(frmOwner, dynMethod);

            frmOwner.BeginInvoke(del);

            habiitar_formOrigen(cerrarForm);

        }

        /// <summary>
        /// Metodo que actualiza el Dataset sin tener un metodo destino, solo lo actualiza
        /// </summary>
        /// <param name="frmOrigen">Formulario Origen</param>
        /// <param name="dsdestino">Dataset a actualizar</param>
        /// <param name="cerrarForm">Si es que se desea cerrar el formulario</param>
        public async void SQL_NON_ASYNCCORE_DS(Form frmOrigen, clsDS.DATASETSQL dsdestino, bool cerrarForm)
        {

            _frmOrigen = frmOrigen;

            inhabilitar_formOrigen(true);

            await UPDATE_DATASET(dsdestino);

            habiitar_formOrigen(cerrarForm);
        }

        /// <summary>
        /// Metodo que ejecuta una query, ejecuta un metodo de exito y actualiza un Dataset
        /// </summary>
        /// <param name="sSQL">Query a enviar</param>
        /// <param name="metodo_Exito">Metodo exito en string</param>
        /// <param name="frmOrigen">Formulario de Origen</param>
        /// <param name="dsdestino">Dataset Destino</param>
        /// <param name="cerrarForm">Si es que se desea cerrar el formulario</param>
        public async void SQL_NON_ASYNC_QUERY(string sSQL, string metodo_Exito, Form frmOrigen, clsDS.DATASETSQL dsdestino, bool cerrarForm)
        {

            _frmOrigen = frmOrigen;

            MethodInfo dynMethod = _frmOrigen.GetType().GetMethod(metodo_Exito,
            BindingFlags.NonPublic | BindingFlags.Instance);

            inhabilitar_formOrigen(true);

            await _clsOracleDB.SQL_NON_QUERY_ASYNC(sSQL);
            await UPDATE_DATASET(dsdestino);

            Delegate del = CreateDelegateWithObjectParameters(_frmOrigen, dynMethod);

            _frmOrigen.BeginInvoke(del);

            habiitar_formOrigen(cerrarForm);

        }

        /// <summary>
        /// Metodo que ejecuta 2 metodos de exito del formulario owner y desde el formulario destino.
        /// </summary>
        /// <param name="sSQL">Consulta para la BD</param>
        /// <param name="metodo_Exito_Owner">El metodo del owner del formulario</param>
        /// <param name="metodo_exito">Metodo de destino donde se llama el metodo</param>
        /// <param name="frmOrigen">Formulario de Origen</param>
        /// <param name="frmOwner">Formulario Owner</param>
        /// <param name="destinos">Datasets a actualizar</param>
        /// <param name="cerrarForm">Si es que se desea cerrar el form</param>
        public async void SQL_NON_ASYNCCOREQUERY_DS2METHOD(string sSQL, string metodo_Exito_Owner, string metodo_exito, Form frmOrigen, Form frmOwner, List<clsDS.DATASETSQL> destinos, bool cerrarForm)
        {
            _frmOrigen = frmOrigen;

            MethodInfo dynMethodOwner = frmOwner.GetType().GetMethod(metodo_Exito_Owner,
            BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo dynMethod = frmOrigen.GetType().GetMethod(metodo_exito,
            BindingFlags.NonPublic | BindingFlags.Instance);

            inhabilitar_formOrigen(true);

            await _clsOracleDB.SQL_NON_QUERY_ASYNC(sSQL);

            foreach (clsDS.DATASETSQL destino in destinos)
            {
                await UPDATE_DATASET(destino);
            }

            Delegate delOwner = CreateDelegateWithObjectParameters(frmOwner, dynMethodOwner);
            Delegate del = CreateDelegateWithObjectParameters(frmOrigen, dynMethod);

            frmOwner.BeginInvoke(delOwner);
            frmOrigen.BeginInvoke(del);

            habiitar_formOrigen(cerrarForm);
        }

        /// <summary>
        /// Metodo que carga los dataset staticos
        /// </summary>
        /// <param name="dsdestino">Dataset Destino a actualizar</param>
        /// <returns></returns>
        public async Task<string> UPDATE_DATASET(clsDS.DATASETSQL dsdestino)
        {
            try
            {
                string result = "";

                switch (dsdestino)
                {
                    case clsDS.DATASETSQL.Perfiles:
                        {
                            clsDS.DS_PERFILES = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_PERFILES);
                            result = "Listo Perfiles";
                            return result;
                        }
                    case clsDS.DATASETSQL.Usuarios:
                        {
                            clsDS.DS_USUARIOS = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_USUARIOS);
                            result = "Listo Usuarios";
                            return result;
                        }
                    case clsDS.DATASETSQL.Unidades:
                        {
                            clsDS.DS_UNIDADES = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_UNIDADES);
                            result = "Listo Unidades";
                            return result;
                        }
                    case clsDS.DATASETSQL.Permisos:
                        {
                            clsDS.DS_PERMISOS = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_PERMISOS);
                            result = "Listo Permisos";
                            return result;
                        }
                    case clsDS.DATASETSQL.Resoluciones:
                        {
                            clsDS.DS_RESOLUCIONES = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_RESOLUCIONES);
                            result = "Listo Resoluciones";
                            return result;
                        }
                    case clsDS.DATASETSQL.Tipos_Permisos:
                        {
                            clsDS.DS_TIPOS_PERMISOS = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_TIPOS_PERMISOS);
                            result = "Listo Tipos Permisos";
                            return result;
                        }
                    case clsDS.DATASETSQL.Permisos_Detalle:
                        {
                            clsDS.DS_PERMISOS_DETALLE = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_PERMISOS_DETALLES);
                            result = "Listo Permisos Detalle";
                            return result;
                        }
                    case clsDS.DATASETSQL.Resoluciones_Detalle:
                        {
                            clsDS.DS_RESOLUCIONES_DETALLE = await _clsOracleDB.SQL_GET_DATASET_ASYNC(clsDS.sSQL_RESOLUCIONES_DETALLES);
                            result = "Listo Resoluciones Detalle";
                            return result;
                        }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que ejecuta una consulta y devuelve un dataset
        /// </summary>
        /// <param name="sSQL">Consulta</param>
        /// <param name="frmOrigen">Formulario origen</param>
        /// <param name="cerrar">Si es que se desea cerrar el dormulario</param>
        /// <returns></returns>
        public async Task<DataSet> SQL_RETURN_DS(string sSQL, Form frmOrigen, bool cerrar)
        {

            //Metodo que devuelve un dataset usar con await
            _frmOrigen = frmOrigen;

            inhabilitar_formOrigen(true);

            DataSet ds;

            ds = await _clsOracleDB.SQL_GET_DATASET_ASYNC(sSQL);

            habiitar_formOrigen(cerrar);

            return ds;
        }

        /// <summary>
        /// Metodo que crea un panel y lo ubica en el formulario
        /// </summary>
        /// <param name="inhabilitar">Si es que se desea inhabilitar el formuario del background</param>
        private void inhabilitar_formOrigen(bool inhabilitar)
        {
            pnlwait = new Panel();
            pnlwait.Name = "pnlwait";

            pnlwait.Size = new System.Drawing.Size(450, 80);


            circle = new MRG.Controls.UI.LoadingCircle();
            circle.Size = new Size(75, 37);
            circle.Color = Color.FromArgb(128, 186, 40);
            //circle.Anchor = AnchorStyles.None;
            circle.Name = "circle";
            circle.Active = true;
            circle.InnerCircleRadius = 8;
            circle.BackColor = Color.FromArgb(255, 255, 255);
            circle.SpokeThickness = 4;
            circle.NumberSpoke = 24;
            circle.OuterCircleRadius = 9;
            circle.RotationSpeed = 20;
            circle.InnerCircleRadius = 8;
            //circle.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - pnlwait.Width - circle.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - pnlwait.Height - circle.Height) / 2);

            circle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;

            lblCargando = new Label();
            lblCargando.Name = "lblCargando";
            lblCargando.AutoSize = false;
            lblCargando.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblCargando.Location = new System.Drawing.Point(197, 52);

            //this.lblCargando.Name = "lblCargando";
            lblCargando.Size = new System.Drawing.Size(76, 17);
            //this.lblCargando.TabIndex = 1;
            lblCargando.Text = "Cargando...";
            lblCargando.BackColor = Color.FromArgb(255, 255, 255);
            lblCargando.ForeColor = Color.Black;
            lblCargando.TextAlign = ContentAlignment.MiddleCenter;
            //lblCargando.Dock = DockStyle.Fill;

            pnlwait.Anchor = AnchorStyles.None;
            pnlwait.Width = _frmOrigen.Width;

            pnlwait.Location = new Point(0, _frmOrigen.Height / 2 - pnlwait.Height / 2);
            circle.Location = new Point(pnlwait.Width / 2 - circle.Width / 2, pnlwait.Height / 2 - circle.Height / 2);
            lblCargando.Location = new Point(pnlwait.Width / 2 - lblCargando.Width / 2, circle.Location.Y + circle.Height);

            pnlwait.BackColor = Color.FromArgb(255, 255, 255);


            if (inhabilitar)
            {
                foreach (Control crtl in _frmOrigen.Controls)
                {
                    crtl.Enabled = false;
                }
            }


            _frmOrigen.Controls.Add(pnlwait);
            pnlwait.Controls.Add(circle);
            pnlwait.Controls.Add(lblCargando);
            pnlwait.BringToFront();
            circle.BringToFront();
            lblCargando.BringToFront();
        }

        /// <summary>
        /// Metodo que inhabilita el Parent del formulatio
        /// </summary>
        private void inhabilitar_MDIParent()
        {
            foreach (Control crtl in _frmOrigen.MdiParent.Controls)
            {
                crtl.Enabled = false;
            }
        }

        /// <summary>
        /// Metodo que habilita el Parent Form.
        /// </summary>
        private void habilitar_MDIParent()
        {
            foreach (Control crtl in _frmOrigen.MdiParent.Controls)
            {
                crtl.Enabled = true;
            }
        }

        /// <summary>
        /// Metodo que habilita el formulario origen
        /// </summary>
        /// <param name="cerrar">Si es que se desea cerrar el form</param>
        private void habiitar_formOrigen(bool cerrar)
        {
            #region FRMWAIT
            //try
            //{
            //    _frmWait.Close();
            //    _frmOrigen.Enabled = true;
            //    _frmOrigen.BringToFront();
            //    _frmWait.Cursor = Cursors.Default;
            //    _frmOrigen.Cursor = Cursors.Default;
            //    if (cerrar)
            //    {
            //        _frmOrigen.Close();
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            #endregion

            try
            {
                Control[] pnlwaits = _frmOrigen.Controls.Find("pnlwait", true);

                foreach (Control crtl in pnlwaits)
                {
                    _frmOrigen.Controls.Remove(crtl);
                }

                Control[] circles = _frmOrigen.Controls.Find("circle", true);

                foreach (Control crtl in circles)
                {
                    _frmOrigen.Controls.Remove(crtl);
                }

                Control[] lblCargandos = _frmOrigen.Controls.Find("circle", true);

                foreach (Control crtl in lblCargandos)
                {
                    _frmOrigen.Controls.Remove(crtl);
                }

                //frmOrigen.Enabled = true;
                foreach (Control crtl in _frmOrigen.Controls)
                {
                    crtl.Enabled = true;
                }

                if (cerrar)
                {
                    _frmOrigen.Close();
                }
                _frmOrigen.BringToFront();

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Metodo que habilita un formulario owner
        /// </summary>
        private void habilitar_formOrigenOwner()
        {
            try
            {
                _frmOwner.Controls.Remove(pnlwait);
                _frmOwner.Controls.Remove(circle);
                _frmOwner.Controls.Remove(lblCargando);
                //frmOrigen.Enabled = true;
                foreach (Control crtl in _frmOwner.Controls)
                {
                    crtl.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// Metodo que crea un delegado,donde recibe una instancia y informacion del metodo es decir su nombre.
        /// </summary>
        /// <param name="instance">Obheto instanciado que quiero hacer la llamada como referencia</param>
        /// <param name="methodInfo">Informacion del metodo</param>
        /// <returns></returns>
        public Delegate CreateDelegateWithObjectParameters(object instance, MethodInfo methodInfo)
        {
            var parameters = methodInfo.GetParameters()
                .Select(parameterInfo => new
                {
                    MethodParameterType = parameterInfo.ParameterType,
                    DelegateParameter = Expression.Parameter(typeof(object), parameterInfo.Name)
                })
                .Select(x => new
                {
                    x.DelegateParameter,
                    MethodParameter = Expression.Convert(x.DelegateParameter, x.MethodParameterType)
                });
            MethodCallExpression methodCallExpression = instance == null
                                                            ? Expression.Call(methodInfo, parameters.Select(x => x.MethodParameter).ToArray())
                                                            : Expression.Call(Expression.Constant(instance), methodInfo, parameters.Select(x => x.MethodParameter).ToArray());
            return Expression.Lambda(methodCallExpression, parameters.Select(x => x.DelegateParameter).ToArray()).Compile();
        }
    }
}
