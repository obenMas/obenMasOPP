using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja las Provincias
    /// </summary>
    public class clsState
    {
        //Atributes
        
        private int ste_codsec;
        private int ste_fkCountry;
        private string ste_CountryName;
        private string ste_name;
        


        //Properties

        public int codsec { get { return ste_codsec; } set { ste_codsec = value; } }

        public int fkCountry { get { return ste_fkCountry; } set { ste_fkCountry = value; } }

        public string CountryName { get { return ste_CountryName; } set { ste_CountryName = value; } }

        public string name { get { return ste_name; } set { ste_name = value; } }



        //Constructor

        public clsState()
        {
        ste_codsec = 0;
        ste_fkCountry = 0;
        ste_CountryName = "";
        ste_name = "";
        }

        public clsState(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_state where ste_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ste_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ste_name"].ToString();
            this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["ste_fkCountry"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_state (ste_fkCountry, ste_name) VALUES (";
                    queryString += this.fkCountry.ToString() + " , '";
                    queryString += this.name + "');";
                }
                else
                {
                    queryString += "UPDATE bps_admin_state SET ste_fkCountry = " + this.fkCountry.ToString();
                    queryString += ", ste_name = '" + this.name + "' ";
                    queryString += "WHERE ste_codsec = " + this.codsec + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsState.save");
                return false;
            }
                        
        }

        public static List<clsState> getList()
        {
            return getList("");
        }

        public static List<clsState> getList(string orderBy)
        {
            List<clsState> lstState = new List<clsState>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_state ORDER BY ste_name");
            lstState.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstState.Add(new clsState());
                lstState[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ste_codsec"]);
                lstState[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["ste_fkCountry"]);
                lstState[i].name = DS.Tables[0].Rows[i]["ste_name"].ToString();

            }

            return lstState;
        }

        public static List<clsState> getListByCountry(int countryCodsec)
        {
            return getListByCountry(countryCodsec , "");
        }

        public static List<clsState> getListByCountry(int countryCodsec, string orderBy)
        {
            List<clsState> lstState = new List<clsState>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_state where ste_fkCountry =" + countryCodsec.ToString() + " ORDER BY ste_name");
            lstState.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstState.Add(new clsState());
                lstState[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ste_codsec"]);
                lstState[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["ste_fkCountry"]);
                lstState[i].name = DS.Tables[0].Rows[i]["ste_name"].ToString();
            }

            return lstState;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
