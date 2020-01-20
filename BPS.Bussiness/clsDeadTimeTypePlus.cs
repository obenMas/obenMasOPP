using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeTypePlus : clsDeadTimeType
    {
        public static List<clsDeadTimeTypePlus> getListByGroup(int codsecGroup)
        {
            List<clsDeadTimeTypePlus> lstDeadTimeType = new List<clsDeadTimeTypePlus>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimetype WHERE dtt_isVisible = 1 AND dtt_fkDeadTimeGroup = " + codsecGroup.ToString() + " AND dtt_codsec <> 163 ORDER BY dtt_deadTimeName ASC");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsDeadTimeTypePlus());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_codsec"]);
                    lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_fkDeadTimeGroup"]);
                    lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["dtt_deadTimeGroupName"].ToString();
                    lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["dtt_deadTimeName"].ToString();
                    lstDeadTimeType[i].descrition = DS.Tables[0].Rows[i]["dtt_descrition"].ToString();
                    lstDeadTimeType[i].days = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_days"]);
                    lstDeadTimeType[i].standartTime = TimeSpan.Parse(DS.Tables[0].Rows[i]["dtt_standartTime"].ToString());
                }
            }

            return lstDeadTimeType;
        }

        public static clsDeadTimeTypePlus Load(int codsec)
        {
            clsDeadTimeTypePlus objDeadTime = new clsDeadTimeTypePlus();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimetype WHERE dtt_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    objDeadTime.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_codsec"]);
                    objDeadTime.fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_fkDeadTimeGroup"]);
                    objDeadTime.deadTimeName = DS.Tables[0].Rows[i]["dtt_deadTimeName"].ToString();
                    objDeadTime.descrition = DS.Tables[0].Rows[i]["dtt_descrition"].ToString();
                    objDeadTime.standartTime = TimeSpan.Parse(DS.Tables[0].Rows[i]["dtt_standartTime"].ToString());
                    objDeadTime.days = Convert.ToInt32(DS.Tables[0].Rows[i]["dtt_days"]);
                    objDeadTime.isEnable = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["dtt_isEnable"], DS.Tables[0].Rows[i]["dtt_isEnable"].GetType().FullName);
                }
            }

            return objDeadTime;
        }

        public override string ToString()
        {
            return this.deadTimeName;
        }
    }
}
