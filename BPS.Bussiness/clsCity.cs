using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja las ciudades
    /// </summary>
    public class clsCity
    {
        //Atributes

        private int cty_codsec;
        private int cty_fkState;
        private string cty_StateName;
        private string cty_name;
  

        //Properties

        public int codsec { get { return cty_codsec; } set { cty_codsec = value; } }

        public int fkState { get { return cty_fkState; } set { cty_fkState = value; } }

        public string StateName { get { return cty_StateName; } set { cty_StateName = value; } }

        public string name { get { return cty_name; } set { cty_name = value; } }

       
        //Constructor

        public clsCity()

        { 
        
        cty_codsec = 0;
        cty_fkState = 0;
        cty_StateName = "";
        cty_name = "";
        
        }

        public clsCity(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_city where cty_codsec = " + codsec.ToString());
                        
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cty_codsec"]);
            this.name = DS.Tables[0].Rows[0]["cty_name"].ToString();
            this.fkState = Convert.ToInt32(DS.Tables[0].Rows[0]["cty_fkState"]);
        }

        public bool save()
        {
            try
            {
            string queryString = "";

            if (this.codsec == 0)
            {
                queryString += "INSERT INTO bps_admin_city (cty_fkState, cty_name) VALUES (";
                queryString += this.fkState.ToString() + " , '";
                queryString += this.name + "');";
            }
            else
            {
                queryString += "UPDATE bps_admin_city SET cty_fkState = " + this.fkState.ToString();
                queryString += ", cty_name = '" + this.name + "' " ;
                queryString += "WHERE cty_codsec = " + this.codsec + ";";
            }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCity.save");
                return false;
            }

            
        }        

        public static List<clsCity> getList()
        {
            return getList("");
        }

        public static List<clsCity> getList(string orderBy)
        {
            List<clsCity> lstCity = new List<clsCity>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_city ORDER BY cty_name");
            lstCity.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCity.Add(new clsCity());
                lstCity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_codsec"]);
                lstCity[i].fkState = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_fkState"]);
                lstCity[i].name = DS.Tables[0].Rows[i]["cty_name"].ToString();

            }

            return lstCity;
        }

        public static List<clsCity> getListByState(int countryCodsec)
        {
            return getListByState(countryCodsec, "");
        }

        public static List<clsCity> getListByState(int stateCodsec, string orderBy)
        {
            List<clsCity> lstCity = new List<clsCity>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_city where cty_fkState =" + stateCodsec.ToString() + " ORDER BY cty_name");
            lstCity.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCity.Add(new clsCity());
                lstCity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_codsec"]);
                lstCity[i].fkState = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_fkState"]);
                lstCity[i].name = DS.Tables[0].Rows[i]["cty_name"].ToString();
            }

            return lstCity;
        }
        public static List<clsCity> getListByCountry(int countryCodsec)
        {
            List<clsCity> lstCity = new List<clsCity>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCities where cty_fkCountry =" + countryCodsec.ToString() + " ORDER BY cty_name");
            lstCity.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCity.Add(new clsCity());
                lstCity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_codsec"]);
                lstCity[i].fkState = Convert.ToInt32(DS.Tables[0].Rows[i]["cty_fkState"]);
                lstCity[i].name = DS.Tables[0].Rows[i]["cty_name"].ToString();
            }

            return lstCity;
        }
        public static int getCountry(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCities where cty_codsec =" + codsec.ToString());

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cty_fkCountry"]);

        }
        public override string ToString()
        {
            return this.name;
        }

    }
}
