using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMetalizedDeadTime
    {
        //Attributes
        private int dtt_codsec;
        private int mtodtg_fkDeadTime;
        private string dtt_deadTimeGroupName;
        private string mtodtg_name;

        //Properties
        public int codsec { get { return dtt_codsec; } set { dtt_codsec = value; } }

        public int fkDeadTimeGroup { get { return mtodtg_fkDeadTime; } set { mtodtg_fkDeadTime = value; } }

        public string deadTimeGroupName { get { return dtt_deadTimeGroupName; } set { dtt_deadTimeGroupName = value; } }

        public string deadTimeName { get { return mtodtg_name; } set { mtodtg_name = value; } }

        //Constructor
        public clsMetalizedDeadTime()
        { 
            dtt_codsec = 0;
            mtodtg_fkDeadTime = 0;
            dtt_deadTimeGroupName = "";
            mtodtg_name = "";
        }

        public clsMetalizedDeadTime(int deadTimeCodsec)
        {
            this.load(deadTimeCodsec);
        }

        //Methods
        public void load(int deadTimeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMetalizedByCodsec " + deadTimeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mtodtg_codsec"]);
                this.fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[0]["mtodtg_fkDeadTime"]);
                this.deadTimeGroupName = DS.Tables[0].Rows[0]["mtogr_name"].ToString();
                this.deadTimeName = DS.Tables[0].Rows[0]["mtodtg_name"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimemetalizedgroup (mtodtg_fkDeadTime, mtodtg_name)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "'" + this.deadTimeName + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimemetalizedgroup";
                    queryString += " SET ";
                    queryString += "mtodtg_fkDeadTime = " + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "mtodtg_name = '" + this.deadTimeName + "'";
                    queryString += " WHERE mtodtg_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeType.save");
                return false;
            }
        }

        public static List<clsMetalizedDeadTime> getList()
        {
            List<clsMetalizedDeadTime> lstDeadTimeType = new List<clsMetalizedDeadTime>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMetalizedList");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedDeadTime());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_codsec"]);
                    lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_fkDeadTime"]);
                    lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
                    lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["mtodtg_name"].ToString();
                }
            }

            return lstDeadTimeType;
        }

        public static List<clsMetalizedDeadTime> getListMill()
        {
            List<clsMetalizedDeadTime> lstDeadTimeType = new List<clsMetalizedDeadTime>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'DeadTimeMillList','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedDeadTime());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_codsec"]);
                    lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_fkDeadTime"]);
                    lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
                    lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["mtodtg_name"].ToString();
                }
            }

            return lstDeadTimeType;
        }

        public static List<clsMetalizedDeadTime> getListByGroup(int codsec)
        {
            List<clsMetalizedDeadTime> lstDeadTimeType = new List<clsMetalizedDeadTime>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMetalizedByGroup " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedDeadTime());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_codsec"]);
                    lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_fkDeadTime"]);
                    lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
                    lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["mtodtg_name"].ToString();
                }
            }

            return lstDeadTimeType;
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_deadtimemetalized WHERE mtodt_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetalizedDeadTime.delete");
                return false;
            }
        }

        public override string ToString()
        {
            return this.deadTimeName;
        }
    }
}
