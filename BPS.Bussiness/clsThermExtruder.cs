using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las extrusoras de termoformado
    /// </summary>
    public class clsThermExtruder
    {

        //Atributes

        private int tmex_codsec;
        private string tmex_name;
        private int tmex_minFilmWidth;
        private int tmex_maxFilmWidth;
        private double tmex_maxVelocity;
        private int trmex_coilNumber;
        private int tmex_kilogramsPerHour;
        private int tmex_secuencial;


        //Properties

        public int codsec { get { return tmex_codsec; } set { tmex_codsec = value; } }

        public string name { get { return tmex_name; } set { tmex_name = value; } }

        public int minFilmWidth { get { return tmex_minFilmWidth; } set { tmex_minFilmWidth = value; } }

        public int maxFilmWidth { get { return tmex_maxFilmWidth; } set { tmex_maxFilmWidth = value; } }

        public double maxVelocity { get { return tmex_maxVelocity; } set { tmex_maxVelocity = value; } }

        public int coilNumber { get { return trmex_coilNumber; } set { trmex_coilNumber = value; } }

        public int kilogramsPerHour { get { return tmex_kilogramsPerHour; } set { tmex_kilogramsPerHour = value; } }

        public int secuencial { get { return tmex_secuencial; } set { tmex_secuencial = value; } }


        //Constructor

        public clsThermExtruder()
        {
            tmex_codsec = 0;
            tmex_name = "";
            tmex_minFilmWidth = 0;
            tmex_maxFilmWidth = 0;
            tmex_maxVelocity = 0;
            trmex_coilNumber = 0;
            tmex_kilogramsPerHour = 0;
            tmex_secuencial = 0;
        }

        public clsThermExtruder(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermextruder where tmex_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tmex_codsec"]);
            this.name = DS.Tables[0].Rows[0]["tmex_name"].ToString();
            this.minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["tmex_minFilmWidth"]);
            this.maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["tmex_maxFilmWidth"]);
            this.maxVelocity = Convert.ToDouble(DS.Tables[0].Rows[0]["tmex_maxVelocity"]);
            this.coilNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["trmex_coilNumber"]);
            this.kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["tmex_kilogramsPerHour"]);
            this.secuencial = Convert.ToInt32(DS.Tables[0].Rows[0]["tmex_secuencial"]);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_thermextruder (tmex_name, tmex_minFilmWidth,tmex_maxFilmWidth,tmex_maxVelocity,trmex_coilNumber,tmex_kilogramsPerHour,tmex_secuencial)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += this.minFilmWidth.ToString() + ",";
                    queryString += this.maxFilmWidth.ToString() + ",";
                    queryString += this.maxVelocity.ToString() + ",";
                    queryString += this.coilNumber.ToString() + ",";
                    queryString += this.kilogramsPerHour.ToString() + ",";
                    queryString += "1";
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_prod_thermextruder";
                    queryString += " SET ";
                    queryString += "tmex_name = '" + this.name + "',";
                    queryString += "tmex_minFilmWidth = " + this.minFilmWidth.ToString() + ",";
                    queryString += "tmex_maxFilmWidth = " + this.maxFilmWidth.ToString() + ",";
                    queryString += "tmex_maxVelocity = " + this.maxVelocity.ToString() + ",";
                    queryString += "trmex_coilNumber = " + this.coilNumber.ToString() + ",";
                    queryString += "tmex_kilogramsPerHour = " + this.kilogramsPerHour.ToString() + "";
                    queryString += " WHERE tmex_codsec = " + this.codsec.ToString() + ";";

                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermExtruder.save");
                return false;
            }
        }

        public static List<clsThermExtruder> getList()
        {
            List<clsThermExtruder> lstThermExtruder = new List<clsThermExtruder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermextruder order by tmex_name asc");

            lstThermExtruder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThermExtruder.Add(new clsThermExtruder());
                lstThermExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_codsec"]);
                lstThermExtruder[i].name = DS.Tables[0].Rows[i]["tmex_name"].ToString();
                lstThermExtruder[i].minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_minFilmWidth"]);
                lstThermExtruder[i].maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_maxFilmWidth"]);
                lstThermExtruder[i].maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_maxVelocity"]);
                lstThermExtruder[i].coilNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["trmex_coilNumber"]);
                lstThermExtruder[i].kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_kilogramsPerHour"]);
                lstThermExtruder[i].secuencial = Convert.ToInt32(DS.Tables[0].Rows[i]["tmex_secuencial"]);
                
            }

            return lstThermExtruder;
        }

    }
}
