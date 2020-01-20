using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para control de desperdicios por Rollo Madre
    /// </summary>
    public class clsDeadTimeByMainCoilMetal
    {
        //Attibutes
        private int dcrmcl_codsec;
        private int dcrmcl_fkDecrease;
        private string mtodtg_name;
        private int dcrmcl_fkMainCoil;
        private string mclm_BoppToCode;
        private double mtodt_time;
        private DateTime mtodt_initdate;
        private DateTime mtodt_enddate;

        private string mtodtg_description;
        private int mtogr_codsec;

        //Properties
        public int codsec { get { return dcrmcl_codsec; } set { dcrmcl_codsec = value; } }

        public int fkDecrease { get { return dcrmcl_fkDecrease; } set { dcrmcl_fkDecrease = value; } }

        public string Name{get{return mtodtg_name;}set{mtodtg_name = value;}}

        public int fkMainCoil { get { return dcrmcl_fkMainCoil; } set { dcrmcl_fkMainCoil = value; } }

        public string BoppToCode { get { return mclm_BoppToCode; } set { mclm_BoppToCode = value; } }

        public double time { get { return mtodt_time; } set { mtodt_time = value; } }

        public DateTime initdate { get { return mtodt_initdate; } set { mtodt_initdate = value; } }

        public DateTime enddate { get { return mtodt_enddate; } set { mtodt_enddate = value; } }

        public string Description { get { return mtodtg_description; } set { mtodtg_description = value; } }

        public int codsecGroup { get { return mtogr_codsec; } set { mtogr_codsec = value; } }


        //Constructor
        public clsDeadTimeByMainCoilMetal()
        {
            dcrmcl_codsec = 0;
            dcrmcl_fkDecrease = 0;
            dcrmcl_fkMainCoil = 0;
            mtodt_time = 0;
            mtodt_initdate = DateTime.Now;
            mtodt_enddate = DateTime.Now;
            mtodtg_description = "";
            mtogr_codsec = 0;
        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_decreasebymaincoil (dcrmcl_fkDecrease, dcrmcl_fkMainCoil, dcrmcl_weigth)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDecrease + ",";
                    queryString += "" + this.fkMainCoil + ",";
                    queryString += "" + this.time + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_decreasebymaincoil";
                    queryString += " SET ";
                    queryString += "dcrmcl_fkDecrease = " + this.fkDecrease + ",";
                    queryString += "dcrmcl_fkMainCoil = " + this.fkMainCoil + ",";
                    queryString += "dcrmcl_weigth = " + this.time + "";
                    queryString += " WHERE dcrmcl_codsec = " + this.codsec + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDecreaseByMainCoil.save");
                return false;
            }
        }

        public static List<clsDeadTimeByMainCoilMetal> getListDeadTimeByMainCoilMetal(DateTime initdate, DateTime enddate)
        {
            List<clsDeadTimeByMainCoilMetal> lstDeadTimeByMainCoilMetal = new List<clsDeadTimeByMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMailMetalFilm 'ListMainCoilMetalDeadTimeInGroup', '" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "', 0, '' ");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByMainCoilMetal.Add(new clsDeadTimeByMainCoilMetal());
                    lstDeadTimeByMainCoilMetal[i].codsecGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["mtogr_codsec"]);
                    lstDeadTimeByMainCoilMetal[i].initdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_initdate"]);
                    lstDeadTimeByMainCoilMetal[i].enddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_enddate"]);
                    lstDeadTimeByMainCoilMetal[i].Name = DS.Tables[0].Rows[i]["mtodtg_name"].ToString();
                    lstDeadTimeByMainCoilMetal[i].Description = DS.Tables[0].Rows[i]["mtogr_description"].ToString();
                    //lstDeadTimeByMainCoilMetal[i].fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["dcrmcl_fkMainCoil"]);
                    lstDeadTimeByMainCoilMetal[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                    lstDeadTimeByMainCoilMetal[i].time = Convert.ToDouble(DS.Tables[0].Rows[i]["mtodt_time"]);
                }
            }

            return lstDeadTimeByMainCoilMetal;
        }

        public static List<clsDeadTimeByMainCoilMetal> getListByTypeDeadtime()
        {
            List<clsDeadTimeByMainCoilMetal> lstDeadTimeByMainCoilMetal = new List<clsDeadTimeByMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimegroupmetlized WHERE mtogr_codsec <> 4");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByMainCoilMetal.Add(new clsDeadTimeByMainCoilMetal());
                    lstDeadTimeByMainCoilMetal[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtogr_codsec"]);
                    lstDeadTimeByMainCoilMetal[i].Description = DS.Tables[0].Rows[i]["mtogr_description"].ToString();
                }
            }

            return lstDeadTimeByMainCoilMetal;
        }

    }
}
