using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Data;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase encargada de actuar sobre las conexiones a la base de datos.
    /// </summary>
    public class clsConnection
    {
        public static void connect(ref MySqlConnection dbConnection)
        {
            try
            {
                string fileName = "";
                string server = "", database = "", userName = "", password = "";
                string connectionString = "";

                if (clsGlobal.server == "")
                {
                    if (File.Exists("config.xml"))
                        fileName = "config.xml";
                    else if (File.Exists("../../config.xml"))
                        fileName = "../../config.xml";
                    XmlTextReader xmlRdr = new XmlTextReader(fileName);


                    while (xmlRdr.Read())
                    {
                        switch (xmlRdr.Name)
                        {
                            case "server":
                                server = xmlRdr.GetAttribute("value");
                                clsGlobal.server = server;
                                break;
                            case "database":
                                database = xmlRdr.GetAttribute("value");
                                clsGlobal.database = database;
                                break;
                            case "userName":
                                userName = xmlRdr.GetAttribute("value");
                                clsGlobal.databaseUser = userName;
                                break;
                            case "password":
                                password = xmlRdr.GetAttribute("value");
                                clsGlobal.password = password;
                                break;
                        }
                    }
                }

                connectionString = "Server = " + clsGlobal.server + "; Database = " + clsGlobal.database + "; Uid = " + clsGlobal.databaseUser + "; Pwd = " + clsGlobal.password + ";";

                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsConnection.connect");

                string connectionString = "";

                var pathConfig = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "config.xml").Replace("file:\\", "");

                string xmlText = File.ReadAllText(pathConfig);
                var doc = new XmlDocument();
                doc.LoadXml(xmlText);

                XmlNodeList serverNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/server");
                XmlNodeList dataNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/database");
                XmlNodeList userNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/userName");
                XmlNodeList passNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/password");

                foreach (XmlNode item in serverNodes)
                {
                    clsGlobal.server = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in dataNodes)
                {
                    clsGlobal.database = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in userNodes)
                {
                    clsGlobal.databaseUser = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in passNodes)
                {
                    clsGlobal.password = item.Attributes["value"].Value;
                }

                connectionString = "Server = " + clsGlobal.server + "; Database = " + clsGlobal.database + "; Uid = " + clsGlobal.databaseUser + "; Pwd = " + clsGlobal.password + ";";

                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
            }

        }

        public static void connect(ref SqlConnection dbConnection)
        {
            try
            {
                string fileName = "";
                string server = "", database = "", userName = "", password = "";
                string connectionString = "";

                if (clsGlobal.server == "")
                {
                    if (File.Exists("config.xml"))
                        fileName = "config.xml";
                    else if (File.Exists("../../config.xml"))
                        fileName = "../../config.xml";

                    XmlTextReader xmlRdr = new XmlTextReader(fileName);

                    while (xmlRdr.Read())
                    {
                        switch (xmlRdr.Name)
                        {
                            case "server":
                                server = xmlRdr.GetAttribute("value");
                                clsGlobal.server = server;
                                break;
                            case "database":
                                database = xmlRdr.GetAttribute("value");
                                clsGlobal.database = database;
                                break;
                            case "userName":
                                userName = xmlRdr.GetAttribute("value");
                                clsGlobal.databaseUser = userName;
                                break;
                            case "password":
                                password = xmlRdr.GetAttribute("value");
                                clsGlobal.password = password;
                                break;
                        }
                    }
                }

                connectionString = "Server = " + clsGlobal.server + "; Database = " + clsGlobal.database + "; Uid = " + clsGlobal.databaseUser + "; Pwd = " + clsGlobal.password + ";";

                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsConnection.connect");

                //Generar la nueva conexión para un catch

                string connectionString = "";
                var pathConfig = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "config.xml").Replace("file:\\", "");

                string xmlText = File.ReadAllText(pathConfig);
                var doc = new XmlDocument();
                doc.LoadXml(xmlText);

                XmlNodeList serverNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/server");
                XmlNodeList dataNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/database");
                XmlNodeList userNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/userName");
                XmlNodeList passNodes = doc.DocumentElement.SelectNodes("/config/databaseConnection/password");


                foreach (XmlNode item in serverNodes)
                {
                    clsGlobal.server = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in dataNodes)
                {
                    clsGlobal.database = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in userNodes)
                {
                    clsGlobal.databaseUser = item.Attributes["value"].Value;
                }

                foreach (XmlNode item in passNodes)
                {
                    clsGlobal.password = item.Attributes["value"].Value;
                }

                //XmlTextReader xmlRdr = new XmlTextReader("../../config.xml");

                //string server = "", database = "", userName = "", password = "";


                //while (xmlRdr.Read())
                //{
                //    while (xmlRdr.Read())
                //    {
                //        switch (xmlRdr.Name)
                //        {
                //            case "server":
                //                server = xmlRdr.GetAttribute("value");
                //                clsGlobal.server = server;
                //                break;
                //            case "database":
                //                database = xmlRdr.GetAttribute("value");
                //                clsGlobal.database = database;
                //                break;
                //            case "userName":
                //                userName = xmlRdr.GetAttribute("value");
                //                clsGlobal.databaseUser = userName;
                //                break;
                //            case "password":
                //                password = xmlRdr.GetAttribute("value");
                //                clsGlobal.password = password;
                //                break;
                //        }
                //    }
                //}

                connectionString = "Server = " + clsGlobal.server + "; Database = " + clsGlobal.database + "; Uid = " + clsGlobal.databaseUser + "; Pwd = " + clsGlobal.password + ";";

                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
            }

        }

        public static bool validateConnection(string server, string database, string userName, string password, string dataBaseEngine)
        {
            bool flgValidConnection = false;
            string connectionString = "";

            MySqlConnection dbConnection = new MySqlConnection();
            SqlConnection sqlConn = new SqlConnection();

            try
            {
                connectionString = "Server = " + server + "; Database = " + database + "; Uid = " + userName + "; Pwd = " + password + ";";

                if (dataBaseEngine == "MySql")
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();
                    dbConnection.Close();
                    flgValidConnection = true;
                }
                else
                {
                    sqlConn.ConnectionString = connectionString;
                    sqlConn.Open();
                    sqlConn.Close();
                    flgValidConnection = true;
                }
            }
            catch (Exception)
            {
                dbConnection.Close();
                sqlConn.Close();
                flgValidConnection = false;
            }

            return flgValidConnection;
        }

        public static DataSet getDataSetResult(string queryString)
        {
            MySqlConnection dbConnection = new MySqlConnection();
            MySqlCommand dbComm = new MySqlCommand();
            MySqlDataAdapter dbDA = new MySqlDataAdapter();

            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlComm = new SqlCommand();
            SqlDataAdapter sqlDA = new SqlDataAdapter();

            DataSet DS = new DataSet();


            try
            {
                if (clsGlobal.DataBaseEngine == "MySql")
                {
                    clsConnection.connect(ref dbConnection);

                    dbComm.CommandText = queryString;
                    dbComm.Connection = dbConnection;
                    dbDA.SelectCommand = dbComm;

                    dbDA.Fill(DS);
                    dbConnection.Close();

                    return DS;
                }
                else
                {
                    if (queryString.ToUpper().Contains("CALL"))
                        queryString = queryString.Replace("CALL ", "").Replace("CALL ", "").Replace("(", " ").Replace(")", "").Replace(";", "");

                    if (queryString.ToUpper().Contains("LIMIT 1"))
                        queryString = queryString.Replace("SELECT ", "SELECT TOP 1 ").Replace("LIMIT 1", "").Replace("Limit 1", "");

                    queryString = queryString.Replace("True", "1").Replace("False", "0");

                    queryString = queryString.Replace("NOW()", "GETDATE()").Replace("Now()", "GETDATE()");

                    queryString = queryString.Replace("`", "");

                    clsConnection.connect(ref sqlConn);

                    sqlComm.CommandText = queryString;
                    sqlComm.Connection = sqlConn;
                    sqlDA.SelectCommand = sqlComm;

                    sqlDA.Fill(DS);
                    sqlConn.Close();

                    return DS;
                }

            }
            catch (Exception ex)
            {
                dbConnection.Close();
                sqlConn.Close();
                DS = new DataSet();
                clsLog.addLog(ex, 3, "clsConnection.getDataSetResult");
                return DS;

            }
        }

        public static bool executeQuery(string queryString)
        {
            MySqlConnection dbConnection = new MySqlConnection();
            MySqlCommand dbComm = new MySqlCommand();

            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlComm = new SqlCommand();

            try
            {
                if (clsGlobal.DataBaseEngine == "MySql")
                {
                    clsConnection.connect(ref dbConnection);

                    dbComm.CommandText = queryString;
                    dbComm.Connection = dbConnection;

                    dbComm.ExecuteNonQuery();

                    dbConnection.Close();

                    return true;
                }
                else
                {
                    if (queryString.ToUpper().Contains("CALL"))
                        // queryString = queryString.Replace("CALL ", "").Replace("CALL ", "").Replace(";", "");
                        queryString = queryString.Replace("CALL ", "").Replace("CALL ", "").Replace("(", " ").Replace(")", "").Replace(";", "");

                    if (queryString.ToUpper().Contains("LIMIT 1"))
                        queryString = queryString.Replace("SELECT ", "SELECT TOP 1 ").Replace("LIMIT 1", "");

                    if (!queryString.Contains("bps_prod_maincoilquality"))
                        queryString = queryString.Replace("True", "1").Replace("False", "0");

                    queryString = queryString.Replace("NOW()", "GETDATE()").Replace("Now()", "GETDATE()");

                    queryString = queryString.Replace("`", "");

                    clsConnection.connect(ref sqlConn);

                    sqlComm.CommandText = queryString;
                    sqlComm.Connection = sqlConn;

                    sqlComm.ExecuteNonQuery();

                    sqlConn.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "executeQuery");
                dbConnection.Close();
                sqlConn.Close();
                return false;
            }
        }
    }
}
