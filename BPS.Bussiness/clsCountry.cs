using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los paises
    /// </summary>
    public class clsCountry
    {
        //Atributes

        private int ctry_codsec;
        private string ctry_name;
        private string ctry_abbreviation;


        //Properties

        public int codsec { get { return ctry_codsec; } set { ctry_codsec = value; } }

        public string name { get { return ctry_name; } set { ctry_name = value; } }

        public string abbreviation { get { return ctry_abbreviation; } set { ctry_abbreviation = value; } }


        //Constructor

        public clsCountry()
        { 
        ctry_codsec = 0;
        ctry_name = "";
        ctry_abbreviation = "";
        
        }

        public clsCountry(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_country where ctry_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ctry_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ctry_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["ctry_abbreviation"].ToString();
        }

        public bool save()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_country (ctry_name, ctry_abbreviation) VALUES ('";
                    queryString += this.name + "' , '";
                    queryString += this.abbreviation + "');";
                }
                else
                {
                    queryString += "UPDATE bps_admin_country SET ctry_name = '" + this.name;
                    queryString += "', ctry_abbreviation = '" + this.abbreviation + "' ";
                    queryString += "WHERE ctry_codsec = " + this.codsec + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCountry.save");
                return false;
            }

            
        }

        public static List<clsCountry> getList()
        {
            return getList("");
        }

        public static List<clsCountry> getList(string orderBy)
        {
            List<clsCountry> lstCountry = new List<clsCountry>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_country ORDER BY ctry_name");
            lstCountry.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCountry.Add(new clsCountry());
                lstCountry[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ctry_codsec"]);
                lstCountry[i].name = DS.Tables[0].Rows[i]["ctry_name"].ToString();
                lstCountry[i].abbreviation = DS.Tables[0].Rows[i]["ctry_abbreviation"].ToString();
                
            }

            return lstCountry;
        }
        public override string ToString()
        {
            return this.name;
        }
        

    }
}
