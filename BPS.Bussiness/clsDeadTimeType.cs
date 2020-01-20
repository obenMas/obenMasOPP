using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeType
    {
        //Attributes
        private int dtt_codsec;
        private int dtt_fkDeadTimeGroup;
        private string dtt_deadTimeGroupName;
        private string dtt_deadTimeName;
        private string dtt_descrition;
        private bool dtt_isVisible;

        private TimeSpan dtt_standartTime;

        public TimeSpan standartTime
        {
            get { return dtt_standartTime; }
            set { dtt_standartTime = value; }
        }


        private int dtt_days;

        public int days
        {
            get { return dtt_days; }
            set { dtt_days = value; }
        }


        private bool dtt_isEnable;

        public bool isEnable
        {
            get { return dtt_isEnable; }
            set { dtt_isEnable = value; }
        }


        //Properties
        public int codsec { get { return dtt_codsec; } set { dtt_codsec = value; } }

        public int fkDeadTimeGroup { get { return dtt_fkDeadTimeGroup; } set { dtt_fkDeadTimeGroup = value; } }

        public string deadTimeGroupName { get { return dtt_deadTimeGroupName; } set { dtt_deadTimeGroupName = value; } }

        public string deadTimeName { get { return dtt_deadTimeName; } set { dtt_deadTimeName = value; } }

        public string descrition { get { return dtt_descrition; } set { dtt_descrition = value; } }

        public bool isVisible { get { return dtt_isVisible; } set { dtt_isVisible = value; } }

        //Constructor
        public clsDeadTimeType()
        { 
            dtt_codsec = 0;
            dtt_fkDeadTimeGroup = 0;
            dtt_deadTimeGroupName = "";
            dtt_deadTimeName = "";
            dtt_descrition = "";
            dtt_isVisible = false;
        }

        public clsDeadTimeType(int deadTimeCodsec)
        {
            this.load(deadTimeCodsec);
        }

        //Methods
        public void load(int deadTimeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimetype WHERE dtt_codsec = " + deadTimeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["dtt_codsec"]);
                this.fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[0]["dtt_fkDeadTimeGroup"]);
                this.deadTimeGroupName = DS.Tables[0].Rows[0]["dtt_deadTimeGroupName"].ToString();
                this.deadTimeName = DS.Tables[0].Rows[0]["dtt_deadTimeName"].ToString();
                this.descrition = DS.Tables[0].Rows[0]["dtt_descrition"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimetype (dtt_fkDeadTimeGroup, dtt_deadTimeName, dtt_descrition)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "'" + this.deadTimeName + "',";
                    queryString += "'" + this.descrition + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimetype";
                    queryString += " SET ";
                    queryString += "dtt_fkDeadTimeGroup = " + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "dtt_deadTimeName = '" + this.deadTimeName + "',";
                    queryString += "dtt_descrition = '" + this.descrition + "'";
                    queryString += " WHERE dtt_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeType.save");
                return false;
            }
        }

        public bool saveStandart()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimetype (dtt_fkDeadTimeGroup, dtt_deadTimeName, dtt_descrition, dtt_days, dtt_standartTime, dtt_isEnable, dtt_isVisible)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "'" + this.deadTimeName + "',";
                    queryString += "'" + this.descrition + "',";
                    queryString += "" + this.days.ToString() + ",";
                    queryString += "'" + this.standartTime.ToString() + "',";
                    queryString += "" + this.isEnable.ToString() + ",";
                    queryString += "" + this.isVisible.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimetype";
                    queryString += " SET ";
                    queryString += "dtt_fkDeadTimeGroup = " + this.fkDeadTimeGroup.ToString() + ",";
                    queryString += "dtt_deadTimeName = '" + this.deadTimeName + "',";
                    queryString += "dtt_descrition = '" + this.descrition + "'";
                    queryString += " WHERE dtt_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeType.save");
                return false;
            }
        }

        public static List<clsDeadTimeType> getList()
        {
            List<clsDeadTimeType> lstDeadTimeType = new List<clsDeadTimeType>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimetype WHERE dtt_isVisible = 1 ORDER BY dtt_fkDeadTimeGroup DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsDeadTimeType());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_codsec"]);
                    lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_fkDeadTimeGroup"]);
                    lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["dtt_deadTimeGroupName"].ToString();
                    lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["dtt_deadTimeName"].ToString();
                    lstDeadTimeType[i].descrition = DS.Tables[0].Rows[i]["dtt_descrition"].ToString();
                }
            }

            return lstDeadTimeType;
        }

        public static bool checkDeadTimeName(string name)
        {
            bool isValid = true;
            DataSet DS = new DataSet();
            DataSet Ds = new DataSet();
            List<clsDeadTimeType> lstDeadTimeType = new List<clsDeadTimeType>();

            Ds = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimetype WHERE dtt_isVisible = 1");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                lstDeadTimeType.Add(new clsDeadTimeType());
                lstDeadTimeType[i].deadTimeName = Ds.Tables[0].Rows[i]["dtt_deadTimeName"].ToString();
            }

            for (int i = 0; i < lstDeadTimeType.Count; i++)
            {
                if (lstDeadTimeType[i].deadTimeName.Trim().ToUpper().Replace(" ","") == name.Trim().ToUpper().Replace(" ",""))
                {
                    isValid = false;
                    break;
                }
                else
                    isValid = true;
            }
            return isValid;
        }

        public override string ToString()
        {
            return "[" + this.deadTimeGroupName + "] - " + this.deadTimeName;
        }

    }
}
