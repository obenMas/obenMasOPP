using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de las termoformadoras
    /// </summary>
    public class clsThermoformer
    {
        //Atributes

        private int ther_codsec;
        private string ther_name;
        private int ther_filmWidth;
        private int therm_minhitsperminute;
        private int therm_maxhitsperminute;
        private bool therm_includeextruder;


        //Properties

        public int codsec { get { return ther_codsec; } set { ther_codsec = value; } }

        public string name { get { return ther_name; } set { ther_name = value; } }

        public int filmWidth { get { return ther_filmWidth; } set { ther_filmWidth = value; } }

        public int minhitsperminute { get { return therm_minhitsperminute; } set { therm_minhitsperminute = value; } }

        public int maxhitsperminute { get { return therm_maxhitsperminute; } set { therm_maxhitsperminute = value; } }

        public bool includeextruder { get { return therm_includeextruder; } set { therm_includeextruder = value; } }


        //Constructor

        public clsThermoformer()
        { 
            ther_codsec = 0;
            ther_name = "";
            ther_filmWidth = 0;
            therm_minhitsperminute = 0;
            therm_maxhitsperminute = 0;
            therm_includeextruder = false;
        }
        public clsThermoformer(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermoformer where ther_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ther_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ther_name"].ToString();
            this.filmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["ther_filmWidth"]);
            this.minhitsperminute = Convert.ToInt32(DS.Tables[0].Rows[0]["therm_minhitsperminute"]);
            this.maxhitsperminute = Convert.ToInt32(DS.Tables[0].Rows[0]["therm_maxhitsperminute"]);
            this.includeextruder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["therm_includeextruder"], DS.Tables[0].Rows[0]["therm_includeextruder"].GetType().FullName);
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_thermoformer (ther_name, ther_filmWidth, therm_minhitsperminute, therm_maxhitsperminute, therm_includeextruder)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += this.filmWidth.ToString() + ",";
                    queryString += this.minhitsperminute + ",";
                    queryString += this.maxhitsperminute + ",";
                    queryString += this.includeextruder.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_thermoformer";
                    queryString += " SET ";
                    queryString += "ther_name = '" + this.name + "',";
                    queryString += "ther_filmWidth = " + this.filmWidth.ToString() + ",";
                    queryString += "therm_minhitsperminute = " + this.minhitsperminute + ",";
                    queryString += "therm_maxhitsperminute = " + this.maxhitsperminute + ",";
                    queryString += "therm_includeextruder = " + this.includeextruder.ToString();
                    queryString += " WHERE ther_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermoformer.save");
                return false;
            }
        }

        public static List<clsThermoformer> getList()
        {
            List<clsThermoformer> lstThermoformer = new List<clsThermoformer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermoformer order by ther_name asc");

            lstThermoformer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThermoformer.Add(new clsThermoformer());
                lstThermoformer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ther_codsec"]);
                lstThermoformer[i].name = DS.Tables[0].Rows[i]["ther_name"].ToString();
                lstThermoformer[i].filmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["ther_filmWidth"]);
                lstThermoformer[i].minhitsperminute = Convert.ToInt32(DS.Tables[0].Rows[i]["therm_minhitsperminute"]);
                lstThermoformer[i].maxhitsperminute = Convert.ToInt32(DS.Tables[0].Rows[i]["therm_maxhitsperminute"]);
                lstThermoformer[i].includeextruder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["therm_includeextruder"], DS.Tables[0].Rows[i]["therm_includeextruder"].GetType().FullName);
            }

            return lstThermoformer;
        }
    }
}
