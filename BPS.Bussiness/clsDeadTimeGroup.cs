using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeGroup
    {
        //Attributes
        private int dtg_codsec;
        private string dtg_Name;
        private string dtg_abbreviation;


        //Properties
        public int codsec { get { return dtg_codsec; } set { dtg_codsec = value; } }

        public string name { get { return dtg_Name; } set { dtg_Name = value; } }

        public string abbreviation { get { return dtg_abbreviation; } set { dtg_abbreviation = value; } }

        //Constructor

        public clsDeadTimeGroup()
        { 
            dtg_codsec = 0;
            dtg_Name = "";
            dtg_abbreviation = "";
        }

        public clsDeadTimeGroup(int deadTimeGroupCodsec)
        {
            this.load(deadTimeGroupCodsec);
        }

        //Methods

        public void load(int deadTimeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadTimeGroup WHERE dtg_codsec = " + deadTimeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["dtg_codsec"]);
                this.name = DS.Tables[0].Rows[0]["dtg_name"].ToString();
                this.abbreviation = DS.Tables[0].Rows[0]["dtg_abbreviation"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadTimeGroup (dtg_name, dtg_abbreviation)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadTimeGroup";
                    queryString += " SET ";
                    queryString += "dtg_name = '" + this.name + "',";
                    queryString += "dtg_abbreviation = '" + this.abbreviation + "'";
                    queryString += " WHERE dtg_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeGroup.save");
                return false;
            }
        }

        public static List<clsDeadTimeGroup> getList()
        {
            List<clsDeadTimeGroup> lstDeadTimeGroup = new List<clsDeadTimeGroup>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadTimeGroup order By dtg_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeGroup.Add(new clsDeadTimeGroup());
                    lstDeadTimeGroup[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtg_codsec"]);
                    lstDeadTimeGroup[i].name = DS.Tables[0].Rows[i]["dtg_name"].ToString();
                    lstDeadTimeGroup[i].abbreviation = DS.Tables[0].Rows[i]["dtg_abbreviation"].ToString();
                }
            }

            return lstDeadTimeGroup;
        }

        public override string ToString()
        {
            return this.name + " [" + this.abbreviation + "]";
        }
    }
}
