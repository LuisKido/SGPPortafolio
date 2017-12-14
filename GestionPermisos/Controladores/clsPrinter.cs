using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;

namespace GestionPermisos.Controladores
{
    public class clsPrinter
    {
        /// <summary>
        /// Método para imprimir un documento PDF del permiso en revisión.
        /// </summary>
        /// <param name="verifyCode">Código de verificación del documento para autenticidad.</param>
        /// <param name="detallePermiso">Información del permiso para ser imprimida en un documento PDF</param>
        public void printPermiso(string verifyCode, string estadoPermiso, string tipoPermiso, string fechaInicio, string fechaTermino, string diasPermiso, string motivoPermiso, string rut, string tipo_doc)
        {
            //This is the absolute path to the PDF that we will create
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tipo_doc + " - " + verifyCode + ".pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();

                        Paragraph head = new Paragraph("Detalle de permiso laboral de la Municipalidad Vista Hermosa");
                        Paragraph body = new Paragraph("Permiso laboral emitido por el empleado de RUT: " + rut + "\n\nEstado actual del permiso: " + estadoPermiso + "\n\nFecha de inicio de permiso: " + fechaInicio + "\n\nFecha término de permiso: " + fechaTermino + "\n\nDías totales de permiso: " + diasPermiso + "\n\nMotivo de permiso: " + motivoPermiso);
                        Paragraph foot = new Paragraph("Documento generado desde SGP. Codigo de Verificación: " + verifyCode);

                        foot.SpacingBefore = 380f;
                        body.SpacingBefore = 50f;
                        doc.Add(head);
                        doc.Add(body);
                        doc.Add(foot);

                        doc.Close();
                    }
                }
            }
        }

        public void printResolucion(string verifyCode, DataView dw, string tipo_doc, DataView dw2)
        {
            //This is the absolute path to the PDF that we will create
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tipo_doc + " - " + verifyCode + ".pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //w.AddPageDictEntry(PdfName.ROTATE, PdfPage.SEASCAPE);
                        //Open the document for writing
                        doc.Open();

                        Font font_resolucion = new Font(Font.NORMAL, 8);
                        Font font_resolucion_body = new Font(Font.NORMAL, 6);
                        Paragraph body = new Paragraph(dw2.Table.Rows[0]["RESOLUCION"].ToString());
                        Paragraph head = new Paragraph("Detalle de resolución mensual de la Municipalidad Vista Hermosa");
                        Paragraph foot = new Paragraph("Documento generado desde SGP. Codigo de Verificación: " + verifyCode);
                        //Create a table with two columns
                        PdfPTable t = new PdfPTable(9);

                        t.SetWidths(new int[] { 2, 2, 2, 2, 2, 2, 2, 4, 3 });
                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        t.DefaultCell.Border = 2;

                        t.AddCell(new PdfPCell(new Phrase("RUT", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("RECURSO LEGAL AFECTO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("FECHA EMISION", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("ESTADO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("FECHA INICIO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("FECHA FIN", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("DIAS", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("MOTIVO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("DETALLE PERMISO", font_resolucion)));


                        //Add four cells. Cells are added starting at the top left of the table working left to right first, then down
                        foreach (DataRow row in dw.Table.Rows)
                        {
                            t.AddCell(new Phrase(row["RUT"].ToString(), font_resolucion_body));
                            //t.AddCell(row["JUSTIFICACION"].ToString());
                            t.AddCell(new Phrase(row["RECURSOLEGALAFECTO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["FECHAEMISION"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["ESTADO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["FECHAINICIO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["FECHAFIN"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["DIAS"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["MOTIVO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["DETALLEPERMISO"].ToString(), font_resolucion_body));
                        }

                        body.SpacingBefore = 50f;
                        foot.SpacingBefore = 50f;
                        t.SpacingBefore = 50f;
                        doc.Add(head);
                        doc.Add(body);
                        //Add the table to our document
                        doc.Add(t);

                        doc.Add(foot);

                        //Close our document
                        doc.Close();
                    }
                }
            }
        }

        public void printReportePermisos(string tipo_doc, IEnumerable<DataRow> drs)
        {
            //This is the absolute path to the PDF that we will create
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tipo_doc + ".pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //w.AddPageDictEntry(PdfName.ROTATE, PdfPage.SEASCAPE);
                        //Open the document for writing
                        doc.Open();

                        Font font_resolucion = new Font(Font.NORMAL, 8);
                        Font font_resolucion_body = new Font(Font.NORMAL, 6);
                        Paragraph body = new Paragraph();
                        Paragraph head = new Paragraph("Detalle de Permisos cumplidos de la Municipalidad Vista Hermosa");
                        Paragraph foot = new Paragraph("Documento generado desde SGP.");
                        //Create a table with two column
                        PdfPTable t = new PdfPTable(7);

                        t.SetWidths(new int[] { 2, 3, 2, 2, 2, 2, 2 });
                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        t.DefaultCell.Border = 2;

                        //
                        t.AddCell(new PdfPCell(new Phrase("FECHA SOLICITUD", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("ID PERMISO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("MOTIVO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("TIPO PERMISO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("DIAS", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("ESTADO", font_resolucion)));
                        t.AddCell(new PdfPCell(new Phrase("VALIDADO", font_resolucion)));


                        //Add four cells. Cells are added starting at the top left of the table working left to right first, then down
                        foreach (DataRow row in drs)
                        {
                            //t.AddCell(new Phrase(row["RUT"].ToString(), font_resolucion_body));
                            //t.AddCell(row["JUSTIFICACION"].ToString());
                            //t.AddCell(new Phrase(row["RECURSOLEGALAFECTO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["FECHAEMISION"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["ID_PERMISO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["MOTIVO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["DETALLEPERMISO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["DIAS"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["ESTADO"].ToString(), font_resolucion_body));
                            t.AddCell(new Phrase(row["ESTADO_VERIFICADO"].ToString(), font_resolucion_body));
                            
                        }

                        body.SpacingBefore = 30f;
                        foot.SpacingBefore = 30f;
                        t.SpacingBefore = 30f;
                        doc.Add(head);
                        doc.Add(body);
                        //Add the table to our document
                        doc.Add(t);

                        doc.Add(foot);

                        //Close our document
                        doc.Close();
                    }
                }
            }
        }
    }
}
