using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsLanguage
    {
        
        //Atributes

           private int lng_codsec;
           private string lng_name;
           private string lng_abbreviation;

        //Properties

           public int codsec{get{return lng_codsec;}set{lng_codsec = value;}}

           public string name{get{return lng_name;}set{lng_name = value;}}

           public string abbreviation{get{return lng_abbreviation;}set{lng_abbreviation = value;}}


        //Constructor

        public clsLanguage()
        { 
        lng_codsec = 0;
        lng_name = "";
        lng_abbreviation = "";
        }

        public clsLanguage(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * from bps_admin_language WHERE lng_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["lng_codsec"]);
            this.name = DS.Tables[0].Rows[0]["lng_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["lng_abbreviation"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO  bps_admin_language (lng_name, lng_abbreviation) ";
                    queryString += " VALUES (";
                    queryString += "'" + this.name +  "',";
                    queryString += "'" + this.abbreviation + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_language";
                    queryString += " SET ";
                    queryString += "lng_name = '" + this.name + "',";
                    queryString += "lng_abbreviation = '" + this.abbreviation + "'";
                    queryString += " WHERE lng_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsLanguage.save");
                return false;
                throw;
            }
  
        }

        public static List<clsLanguage> getList()
        {
            List<clsLanguage> lstLanguages = new List<clsLanguage>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * from bps_admin_language order by lng_name");

            lstLanguages.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstLanguages.Add(new clsLanguage());
                lstLanguages[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["lng_codsec"]);
                lstLanguages[i].name = DS.Tables[0].Rows[i]["lng_name"].ToString();
                lstLanguages[i].abbreviation = DS.Tables[0].Rows[i]["lng_abbreviation"].ToString();
            }

            return lstLanguages;
        }
    }
}
