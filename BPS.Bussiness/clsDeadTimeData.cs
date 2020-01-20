using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeData : clsMyHerency
    {
        public clsDeadTimeData()
        {
            this.codsec = 0;
            this.fkDeadTime = 0;
            this.createdDate = DateTime.Now;
            this.notes = string.Empty;
            this.sourceDeadTime = 0;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimedata (dtt_fkDeadTime, dtt_date, dtt_notes, dtt_source)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDeadTime.ToString() + ",";
                    queryString += "'" + this.createdDate + "',";
                    queryString += "'" + this.notes + "',";
                    queryString += "" + this.sourceDeadTime.ToString() + ",";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimedata";
                    queryString += " SET ";
                    queryString += "dtt_fkDeadTime = " + this.fkDeadTime.ToString() + ",";
                    queryString += "dtt_date = '" + this.createdDate + "',";
                    queryString += "dtt_notes = '" + this.notes + "',";
                    queryString += "dtt_source = " + this.sourceDeadTime + "";
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

        public static int getLastCodsec() 
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT TOP(1) COALESCE(MAX(dtt_codsec),0) AS codsec FROM bps_prod_deadtimedata");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"]);
            else
                return 0;
        }
    }
}
