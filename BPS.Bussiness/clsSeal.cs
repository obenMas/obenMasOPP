using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo del Sello para producto BOPP
    /// </summary>
    public class clsSeal
    {
        //Atributes

        private int seal_codsec;
        private string seal_name;
        private string seal_abbreviation;

        //Properties

        public int codsec { get { return seal_codsec; } set { seal_codsec = value; } }

        public string name { get { return seal_name; } set { seal_name = value; } }

        public string abbreviation { get { return seal_abbreviation; } set { seal_abbreviation = value; } }



        //Constructor

        public clsSeal()
        {
            seal_codsec = 0;
            seal_name = "";
            seal_abbreviation = "";
        }
        public clsSeal(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_seal where seal_codsec = " + codsec.ToString());
            
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["seal_codsec"]);
            this.name = DS.Tables[0].Rows[0]["seal_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["seal_abbreviation"].ToString();

         }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_seal (seal_name, seal_abbreviation)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_seal";
                    queryString += " SET ";
                    queryString += "seal_name = '" + this.name + "',";
                    queryString += "seal_abbreviation = '" + this.abbreviation + "'";
                    queryString += " WHERE seal_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSeal.save");
                return false;
            }
        }

        public static List<clsSeal> getList()
        {
            List<clsSeal> lstSeal = new List<clsSeal>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_seal ORDER BY seal_name");

            lstSeal.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSeal.Add(new clsSeal());
                lstSeal[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["seal_codsec"]);
                lstSeal[i].name = DS.Tables[0].Rows[i]["seal_name"].ToString();
                lstSeal[i].abbreviation = DS.Tables[0].Rows[i]["seal_abbreviation"].ToString();
            }

            return lstSeal;
        }

        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }
    }
}
