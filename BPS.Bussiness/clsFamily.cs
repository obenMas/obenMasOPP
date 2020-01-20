using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo de la Familia para producto BOPP
    /// </summary>
    public class clsFamily
    {
        //Atributes

        private int fml_codsec;
        private string fml_name;
        private string fml_abbreviation;

        //Properties

        public int codsec { get { return fml_codsec; } set { fml_codsec = value; } }

        public string name { get { return fml_name; } set { fml_name = value; } }

        public string abbreviation { get { return fml_abbreviation; } set { fml_abbreviation = value; } }
        
        //Constructor

        public clsFamily()
        { 
            fml_codsec = 0;
            fml_name = "";
            fml_abbreviation = "";        
        }
        public clsFamily(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_family where fml_codsec = " + codsec.ToString());
                        
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fml_codsec"]);
            this.name = DS.Tables[0].Rows[0]["fml_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["fml_abbreviation"].ToString();         
 
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_family (fml_name, fml_abbreviation)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_family";
                    queryString += " SET ";
                    queryString += "fml_name = '" + this.name + "',";
                    queryString += "fml_abbreviation = '" + this.abbreviation + "'";
                    queryString += " WHERE fml_codsec = " + this.codsec.ToString()+ ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFamily.save");
                return false;
            }
        }

        public static List<clsFamily> getList()
        {
            List<clsFamily> lstFamily = new List<clsFamily>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_family ORDER BY fml_name");

            lstFamily.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstFamily.Add(new clsFamily());
                lstFamily[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fml_codsec"]);
                lstFamily[i].name = DS.Tables[0].Rows[i]["fml_name"].ToString();
                lstFamily[i].abbreviation = DS.Tables[0].Rows[i]["fml_abbreviation"].ToString();
            }

            return lstFamily;
        }

        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }

    }
}
