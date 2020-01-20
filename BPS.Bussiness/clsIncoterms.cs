using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los incoterms para despachos de pt
    /// </summary>
    public class clsIncoterms
    {
        //Atributes

        private int ict_codsec;
        private string ict_name;
        private string ict_abbreviation;
        private string ict_description;



        //Properties

        public int codsec { get { return ict_codsec; } set { ict_codsec = value; } }

        public string name { get { return ict_name; } set { ict_name = value; } }

        public string abbreviation { get { return ict_abbreviation; } set { ict_abbreviation = value; } }

        public string description { get { return ict_description; } set { ict_description = value; } }

        //Constructor

        public clsIncoterms()
        {
            ict_codsec = 0;
            ict_name = "";
            ict_abbreviation = "";
            ict_description = "";
        }

        public clsIncoterms(int codsec)
        {
            this.load(codsec);
        }


        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_incoterms where ict_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ict_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ict_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["ict_abbreviation"].ToString();
            this.description = DS.Tables[0].Rows[0]["ict_description"].ToString();
            
        }


        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_com_incoterms (ict_name, ict_abbreviation,ict_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_com_incoterms";
                    queryString += " SET ";
                    queryString += "ict_name = '" + this.name + "',";
                    queryString += "ict_abbreviation = '" + this.abbreviation + "',";
                    queryString += "ict_description = '" + this.description + "'";
                    queryString += " WHERE ict_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsIncoterms.save");
                return false;
            }
        }


        public static List<clsIncoterms> getList()
        {
            List<clsIncoterms> lstIncoterms = new List<clsIncoterms>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_incoterms order by ict_name asc");

            lstIncoterms.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstIncoterms.Add(new clsIncoterms());
                lstIncoterms[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ict_codsec"]);
                lstIncoterms[i].name = DS.Tables[0].Rows[i]["ict_name"].ToString();
                lstIncoterms[i].abbreviation = DS.Tables[0].Rows[i]["ict_abbreviation"].ToString();
                lstIncoterms[i].description = DS.Tables[0].Rows[i]["ict_description"].ToString();

            }

            return lstIncoterms;
        }
        public override string ToString()
        {
            return this.abbreviation + " - " + this.name;
        }
    }
}
