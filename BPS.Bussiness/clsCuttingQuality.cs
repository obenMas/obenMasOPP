using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la calidad de las bobinas de producto terminado (Primera,Segunda)
    /// </summary>
    public class clsCuttingQuality
    {
        //Atributes

        private int cqlty_codsec;
        private string cqlty_name;
        

        //Properties


        public int codsec { get { return cqlty_codsec; } set { cqlty_codsec = value; } }

        public string name { get { return cqlty_name; } set { cqlty_name = value; } }


        //Constructor

        public clsCuttingQuality()
        {
        cqlty_codsec = 0;
        cqlty_name = "";
        }

        public clsCuttingQuality(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingquality where cqlty_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cqlty_codsec"]);
            this.name = DS.Tables[0].Rows[0]["cqlty_name"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingquality (cqlty_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingquality";
                    queryString += " SET ";
                    queryString += "cqlty_name = '" + this.name + "',";
                    queryString += " WHERE cqlty_codsec = ;" + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingQuality.save");
                return false;
                throw;
            }
            
        }

        public static List<clsCuttingQuality> getList()
        {
            List<clsCuttingQuality> lstCuttingQuality = new List<clsCuttingQuality>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingquality order by cqlty_codsec asc");

            lstCuttingQuality.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCuttingQuality.Add(new clsCuttingQuality());
                lstCuttingQuality[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cqlty_codsec"]);
                lstCuttingQuality[i].name = DS.Tables[0].Rows[i]["cqlty_name"].ToString();
                
            }

            return lstCuttingQuality;
        }
        public override string ToString()
        {
            return name;
        }

        public static clsCuttingQuality getQualityByName(string cittingQualityName)
        {
            DataSet DS = new DataSet();
            clsCuttingQuality objCuttingQuality = new clsCuttingQuality();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingquality where cqlty_name = '" + cittingQualityName + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCuttingQuality.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cqlty_codsec"]);
                objCuttingQuality.name = DS.Tables[0].Rows[0]["cqlty_name"].ToString();
            }

            return objCuttingQuality;
        }
    }
}
