using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los procesos de corte (Primario,Secundario,Metalizado)
    /// </summary>
    public class clsCuttingProccess
    {
        //Atributes

        private int cprcs_codsec;
        private string cprcs_name;

        //Properties

        public int codsec { get { return cprcs_codsec; } set { cprcs_codsec = value; } }

        public string name { get { return cprcs_name; } set { cprcs_name = value; } }



        //Constructor

        public clsCuttingProccess()
        { 
        cprcs_codsec = 0;
        cprcs_name = "";

        }

        public clsCuttingProccess(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingproccess where cprcs_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cprcs_codsec"]);
            this.name = DS.Tables[0].Rows[0]["cprcs_name"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingproccess (cprcs_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingproccess";
                    queryString += " SET ";
                    queryString += "cprcs_name = '" + this.name + "',";
                    queryString += " WHERE cprcs_codsec = ;" + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, ".save");
                return false;
                throw;
            }
            
        }

        public static List<clsCuttingProccess> getList()
        {
            List<clsCuttingProccess> lstCuttingProccess = new List<clsCuttingProccess>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingproccess order by cprcs_codsec asc");

            lstCuttingProccess.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCuttingProccess.Add(new clsCuttingProccess());
                lstCuttingProccess[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cprcs_codsec"]);
                lstCuttingProccess[i].name = DS.Tables[0].Rows[i]["cprcs_name"].ToString();
                
            }

            return lstCuttingProccess;
        }
    }
}
