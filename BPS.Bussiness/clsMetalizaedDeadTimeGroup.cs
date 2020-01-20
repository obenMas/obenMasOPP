using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMetalizaedDeadTimeGroup
    {
        //Attributes
        private int dtg_codsec;
        private string mtogr_name;
        private string mtogr_description;


        //Properties
        public int codsec { get { return dtg_codsec; } set { dtg_codsec = value; } }

        public string name { get { return mtogr_name; } set { mtogr_name = value; } }

        public string abbreviation { get { return mtogr_description; } set { mtogr_description = value; } }

        //Constructor

        public clsMetalizaedDeadTimeGroup()
        { 
            dtg_codsec = 0;
            mtogr_name = "";
            mtogr_description = "";
        }

        public clsMetalizaedDeadTimeGroup(int deadTimeGroupCodsec)
        {
            this.load(deadTimeGroupCodsec);
        }

        //Methods

        public void load(int deadTimeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimegroupmetlized WHERE mtogr_codsec = " + deadTimeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mtogr_codsec"]);
                this.name = DS.Tables[0].Rows[0]["mtogr_name"].ToString();
                this.abbreviation = DS.Tables[0].Rows[0]["mtogr_description"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimegroupmetlized (mtogr_name, mtogr_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimegroupmetlized";
                    queryString += " SET ";
                    queryString += "mtogr_name = '" + this.name + "',";
                    queryString += "mtogr_description = '" + this.abbreviation + "'";
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

        public static List<clsMetalizaedDeadTimeGroup> getList()
        {
            List<clsMetalizaedDeadTimeGroup> lstDeadTimeGroup = new List<clsMetalizaedDeadTimeGroup>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimegroupmetlized WHERE bps_prod_deadtimegroupmetlized.mtogr_codsec <> 4 ORDER BY mtogr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeGroup.Add(new clsMetalizaedDeadTimeGroup());
                    lstDeadTimeGroup[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtogr_codsec"]);
                    lstDeadTimeGroup[i].name = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
                    lstDeadTimeGroup[i].abbreviation = DS.Tables[0].Rows[i]["mtogr_description"].ToString();
                }
            }

            return lstDeadTimeGroup;
        }

        public static List<clsMetalizaedDeadTimeGroup> getListMill()
        {
            List<clsMetalizaedDeadTimeGroup> lstDeadTimeGroup = new List<clsMetalizaedDeadTimeGroup>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimegroupmetlized WHERE bps_prod_deadtimegroupmetlized.mtogr_codsec = 4 ORDER BY mtogr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeGroup.Add(new clsMetalizaedDeadTimeGroup());
                    lstDeadTimeGroup[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtogr_codsec"]);
                    lstDeadTimeGroup[i].name = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
                    lstDeadTimeGroup[i].abbreviation = DS.Tables[0].Rows[i]["mtogr_description"].ToString();
                }
            }

            return lstDeadTimeGroup;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
