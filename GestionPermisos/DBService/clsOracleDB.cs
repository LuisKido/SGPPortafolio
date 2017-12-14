using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Web;
using System.Windows.Forms;

namespace GestionPermisos.DBService
{
    public class clsOracleDB
    {

        //Esta clase despues va a estar en el WebService, esto es provicional para hacer pruebas. (Kido)

        OracleConnection _conn;

        private bool primera = true;

        public DataSet SQL_GET_DATASET(string sql)
        {
            try
            {
                //Dataset retorno
                DataSet ds;

                //Obtengo la conexion
                _conn = GetDBConnection();

                //Creo un comando para enviarle a la BD
                OracleCommand cmd = _conn.CreateCommand();

                //Query a enviar en este caso deberia ser un select.
                cmd.CommandText = sql;

                //Aqui declaro el tipo de comando que envio, por defecto viene text pero si mandas un store procedure deberias cambiarse.
                cmd.CommandType = CommandType.Text;

                //Inicializo en DS que declare arriba.
                ds = new DataSet();

                //Creo un adapter para que contenga el comando y lo ejecute.
                OracleDataAdapter adp = new OracleDataAdapter(cmd);

                //Utilizo el adaptador y lleno mi dataset, ademas le coloco el nombre de la tabla y/o vista que traje.
                adp.Fill(ds);

                DataSet ds2 = new DataSet();
                ds2.Tables.Add(ds.Tables[0].Clone());

                foreach (DataTable table in ds2.Tables)
                {
                    DataColumnCollection columns = table.Columns;
                    int[] ColumnNumbers = new int[columns.Count];
                    int ColumnNumbersIndex = 0;
                    for (int i = 0; i < columns.Count; i++)
                    {
                        DataColumn col = columns[i];

                        if (col.DataType == typeof(byte[]))
                        {
                            //ds2.Tables[0].Columns[i].DataType = typeof(string);
                            col.DataType = typeof(string);
                            ColumnNumbers[ColumnNumbersIndex] = i;
                            ColumnNumbersIndex++;
                        }
                    }
                }

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    ds2.Tables[0].ImportRow(rows);
                }

                foreach (DataTable table in ds.Tables)
                {
                    DataColumnCollection columns = table.Columns;
                    int[] ColumnNumbers = new int[columns.Count];
                    int ColumnNumbersIndex = 0;
                    for (int i = 0; i < columns.Count; i++)
                    {
                        DataColumn col = columns[i];

                        if (col.DataType == typeof(byte[]))
                        {
                            //ds2.Tables[0].Columns[i].DataType = typeof(string);
                            //col.DataType = typeof(string);
                            ColumnNumbers[ColumnNumbersIndex] = i;
                            ColumnNumbersIndex++;
                        }

                        foreach (DataRow row in table.Rows)
                        {
                            AdjustString(row, ColumnNumbers, ColumnNumbersIndex, ds2.Tables[0], ds.Tables[0]);
                        }
                    }
                }

                primera = true;

                return ds2;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        void AdjustString(DataRow row, int[] ColumnNumbers, int columnCount, DataTable dt, DataTable origin)
        {

            DataRow nueva;

            if (primera)
            {
                nueva = dt.Rows[0];
                primera = false;
            }
            else
            {
                int index = origin.Rows.IndexOf(row);
                nueva = dt.Rows[index];
            }

            for (int i = 0; i < columnCount; i++)
            {
                int columnIndex = ColumnNumbers[i];

                if (row[columnIndex].ToString() != "")
                {
                    Byte[] rawBytesFromOracle = (byte[])row[columnIndex];
                    Guid dotNetGuid = new Guid(rawBytesFromOracle);

                    string original = dotNetGuid.ToString();
                    string nuevo = DotNetToOracle(original);
                    nueva[columnIndex] = nuevo;
                    //row[columnIndex] = nuevo;
                }
            }
        }

        static string OracleToDotNet(string text)
        {
            byte[] bytes = ParseHex(text);
            Guid guid = new Guid(bytes);
            return guid.ToString("N").ToUpperInvariant();
        }

        static string DotNetToOracle(string text)
        {
            Guid guid = new Guid(text);
            return BitConverter.ToString(guid.ToByteArray()).Replace("-", "");
        }

        static byte[] ParseHex(string text)
        {
            // Not the most efficient code in the world, but
            // it works...
            byte[] ret = new byte[text.Length / 2];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return ret;
        }

        public void SQL_NON_QUERY(string sSQL)
        {
            string retorno = "";
            int result = 0;

            _conn = GetDBConnection();

            // Abrimos la conexion
            _conn.Open();
            retorno = sSQL;
            OracleCommand dbCommand = null;

            dbCommand = _conn.CreateCommand();

            try
            {
                if (dbCommand != null)
                {
                    dbCommand.CommandText = sSQL; //Acá va la sentencia
                    dbCommand.CommandTimeout = 30;
                    //System.Threading.Thread.Sleep(20);
                    dbCommand.Transaction = _conn.BeginTransaction();

                    result = dbCommand.ExecuteNonQuery(); //Ejecutas query.. nonquery etc
                    dbCommand.Transaction.Commit(); //Haces el commit de la transacción
                    _conn.Close();
                }
                else
                {
                    throw new Exception("sqlConnection.CreateCommand() retornó nulo.");
                }
            }
            catch (Exception _ex)
            {
                if (dbCommand != null)
                {
                    if (dbCommand.Transaction != null)
                    {
                        //Si algo falla, hace rollback y no escribe nada de la sentencia sSQL.
                        dbCommand.Transaction.Rollback();
                    }
                }
                throw _ex;
            }

        }

        public static string DATASET_XML(DataSet ds)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(DataSet));
                    xmlSerializer.Serialize(streamWriter, ds);
                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }

        public string DATATABLE_JSON(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        public static OracleConnection GetDBConnection()
        {
            string host = "oracleport.cpwyjew1j2kx.us-east-2.rds.amazonaws.com";
            int port = 1521;
            string sid = "ORCL";
            string user = "administrador";
            string password = "Portafolio1.";

            return GetDBConnection(host, port, sid, user, password);
        }

        public static OracleConnection
                       GetDBConnection(string host, int port, String sid, String user, String password)
        {

            //Console.WriteLine("Getting Connection ...");

            // 'Connection string' to connect directly to Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }

        //Metodos async para funcionamiento de clsCore.

        public async Task<DataSet> SQL_GET_DATASET_ASYNC(string sSQL)
        {
            return await Task.Run(() => SQL_GET_DATASET(sSQL));
        }

        public string sSQL_NON_QUERY(string sSQL)
        {
            try
            {
                SQL_NON_QUERY(sSQL);
                return "Listo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique el estado de su conexion. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "No listo";
            }
        }

        public async Task<string> SQL_NON_QUERY_ASYNC(string sSQL)
        {
            return await Task.Run(() => sSQL_NON_QUERY(sSQL));
        }
    }
}
