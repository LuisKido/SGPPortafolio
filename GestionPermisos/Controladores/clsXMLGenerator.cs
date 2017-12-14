using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace GestionPermisos.Controladores
{
    public class clsXMLGenerator
    {
        clsCore _clsCore;
        Form _frmOrigen;

        public clsXMLGenerator(clsCore clsCore, Form frmOrigen)
        {
            _clsCore = clsCore;
            _frmOrigen = frmOrigen;
        }

        public void generar_XML(DataView dw, string id_documento, string tipo_doc)
        {

            //SaveFileDialog sf = new SaveFileDialog();

            //sf.Filter = "XML FIle |*.xml";
            //sf.Title = "Seleccione nombre y ubicacion del archivo";
            //sf.FileName = "xmlNew";

            DataTable dt = dw.ToTable();

            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tipo_doc + " - " + id_documento + ".xml");

            //string savePath = Path.GetDirectoryName(sf.FileName);
            XmlDocument xml = new XmlDocument();
            dt.WriteXml(outputFile);

        }

        public async void generar_XMLDesempeño(string id_usuario)
        {

            DataSet ds = await get_Permisos(id_usuario);

            string rut = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(docNode);
                XmlDocumentType doctype = doc.CreateDocumentType("MENSAJE", null, "define_permiso.dtd", null);
                doc.AppendChild(doctype);

                XmlElement permisosNode;
                XmlElement funcionarioNode;
                XmlElement nombreNode;
                XmlElement runNode;
                XmlElement dvrunNode;
                XmlElement unidadNode;
                XmlElement DetalleNode;
                XmlElement fechaInicioNode;
                XmlElement fechaFinNode;
                XmlElement diasNode;
                XmlElement tipoNode;

                XmlElement permisossNode = doc.CreateElement("permisos");
                doc.AppendChild(permisossNode); 

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    permisosNode = doc.CreateElement("permiso");
                    permisossNode.AppendChild(permisosNode);

                    funcionarioNode = doc.CreateElement("funcionario");
                    permisosNode.AppendChild(funcionarioNode);

                    nombreNode = doc.CreateElement("nombre");
                    nombreNode.AppendChild(doc.CreateTextNode(dr["NOMBRE"].ToString()));
                    funcionarioNode.AppendChild(nombreNode);

                    runNode = doc.CreateElement("run");
                    string run = dr["RUT"].ToString().Substring(0, 8);
                    rut = dr["RUT"].ToString();
                    runNode.AppendChild(doc.CreateTextNode(run));
                    funcionarioNode.AppendChild(runNode);

                    dvrunNode = doc.CreateElement("dvrun");
                    string dv = dr["RUT"].ToString().Substring(8, 1);
                    dvrunNode.AppendChild(doc.CreateTextNode(dv));
                    funcionarioNode.AppendChild(dvrunNode);

                    unidadNode = doc.CreateElement("unidad");
                    unidadNode.AppendChild(doc.CreateTextNode(dr["NOMBREUNIDAD"].ToString()));
                    funcionarioNode.AppendChild(unidadNode);

                    DetalleNode = doc.CreateElement("detalle");
                    permisosNode.AppendChild(DetalleNode);

                    fechaInicioNode = doc.CreateElement("fecha_inicio");
                    DateTime dtinicio = Convert.ToDateTime(dr["FECHAINICIO"].ToString());
                    string fechainicio = dtinicio.ToString("dd/MM/yyyy");
                    fechaInicioNode.AppendChild(doc.CreateTextNode(fechainicio));
                    DetalleNode.AppendChild(fechaInicioNode);

                    fechaFinNode = doc.CreateElement("fecha_fin");
                    DateTime dtfin = Convert.ToDateTime(dr["FECHAFIN"].ToString());
                    string fechafin = dtfin.ToString("dd/MM/yyyy");
                    fechaFinNode.AppendChild(doc.CreateTextNode(fechafin));
                    DetalleNode.AppendChild(fechaFinNode);

                    diasNode = doc.CreateElement("dias");
                    diasNode.AppendChild(doc.CreateTextNode(dr["DIAS"].ToString()));
                    DetalleNode.AppendChild(diasNode);

                    tipoNode = doc.CreateElement("tipo");
                    tipoNode.AppendChild(doc.CreateTextNode(dr["DETALLEPERMISO"].ToString()));
                    DetalleNode.AppendChild(tipoNode);
                }

                string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DesempeñoUsuario - " + rut +".xml");

                doc.Save(outputFile);
            }
            else
            {
                MessageBox.Show("El usuario no ha solicitado permisos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async Task<DataSet> get_Permisos(string id_usuario)
        {
            string sSQL = "SELECT " +
    "usuarios.id_usuario, " +
    "usuarios.nombre, " +
    "usuarios.rut, " +
    "unidades.nombreunidad, " +
    "tipos_permisos.detallepermiso, " +
    "permisos_detalles.fechainicio, " +
    "permisos_detalles.fechafin, " +
    "permisos_detalles.dias " +
"FROM " +
    "usuarios " +
    "INNER JOIN unidades ON unidades.id_unidad = usuarios.unidades_id_unidad " +
    "INNER JOIN permisos_detalles ON usuarios.id_usuario = permisos_detalles.usuarios_id_usuario " +
    "INNER JOIN permisos ON " +
    "    permisos.id_permiso = permisos_detalles.permisos_id_permiso " +
    "AND " +
    "    usuarios.id_usuario = permisos.usuarios_id_usuario " +
    "INNER JOIN tipos_permisos ON tipos_permisos.id_tipo_permiso = permisos.id_tipo_permiso " +
                "WHERE usuarios.id_usuario = '" + id_usuario + "'";

            DataSet ds = await _clsCore.SQL_RETURN_DS(sSQL, _frmOrigen, false);

            return ds;
        }
    }
}
