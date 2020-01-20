using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMachineActivityTypes
    {
        //Atributes
        private int mat_codsec;
        private string mat_activityTypeName;

        //Properties
        public int codsec { get { return mat_codsec; } set { mat_codsec = value; } }
        public string activityTypeName { get { return mat_activityTypeName; } set { mat_activityTypeName = value; } }

        //Constructor
         
        public clsMachineActivityTypes()
        {
            codsec = 0;
            activityTypeName = "";
        }
        public clsMachineActivityTypes(int macCodsec)
        {
            this.load(macCodsec);
        }

        //Methods

        public void load(int macCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machineActivityTypes WHERE mat_codsec=" + macCodsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mat_codsec"]);
                activityTypeName = DS.Tables[0].Rows[0]["mat_activityTypeName"].ToString();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public bool save()
        {
            try
            {
                string queryString = "";
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_machineActivityTypes (mat_activityTypeName) ";
                    queryString += " VALUES(";
                    queryString += "'" + this.activityTypeName.ToString() + "'; ";
                    
                }
                else
                {
                    queryString += "UPDATE bps_prod_machineActivityTypes ";
                    queryString += " SET ";
                    queryString += "mat_activityTypeName = '" + this.activityTypeName.ToString() + "', ";
                    queryString += " WHERE mat_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsMachineActivityTypes.save");
                return false;
            }

        }
    }
}
