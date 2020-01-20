using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMachineActivities
    {
        //Atributes
        private int mac_codsec;
        private int mac_fkMachineActivityType;
        private string mac_machineActivityName;
        private string mac_machineType;
        private bool mac_enabled;

        //Properties
        public int codsec { get { return mac_codsec; } set { mac_codsec = value; } }
        public int fkActivityType { get { return mac_fkMachineActivityType; } set { mac_fkMachineActivityType = value; } }
        public string activityName { get { return mac_machineActivityName; } set { mac_machineActivityName = value; } }
        public string machineType { get { return mac_machineType; } set { mac_machineType = value; } }
        public bool enabled { get { return mac_enabled; } set { mac_enabled = value; } }

        //Constructor
         
        public clsMachineActivities()
        {
            codsec = 0;
            fkActivityType = 0;
            activityName = "";
            machineType = "";
            enabled = false;
        }
        public clsMachineActivities(int macCodsec)
        {
            this.load(macCodsec);
        }

        //Methods

        public void load(int macCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machineActivities WHERE mac_codsec=" + macCodsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mac_codsec"]);
                fkActivityType = Convert.ToInt32(DS.Tables[0].Rows[0]["mac_fkMachineActivityType"]);
                activityName = DS.Tables[0].Rows[0]["mac_machineActivityName"].ToString();
                machineType = DS.Tables[0].Rows[0]["mac_machineType"].ToString();
                enabled = Convert.ToBoolean(DS.Tables[0].Rows[0]["mac_enabled"]);
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
                    queryString += "INSERT INTO bps_prod_machineActivities (mac_fkMachineActivityType, mac_machineActivityName, mac_machineType, mac_enabled) ";
                    queryString += " VALUES(";
                    queryString += "" + this.fkActivityType.ToString() + ", ";
                    queryString += "'" + this.activityName.ToString() + "', ";
                    queryString += "'" + this.machineType.ToString() + "', ";
                    if(this.enabled)
                    {
                        queryString += "1); ";
                    }
                    else
                    {
                        queryString += "0); ";
                    }
                    
                }
                else
                {
                    queryString += "UPDATE bps_prod_machineActivities ";
                    queryString += " SET ";
                    queryString += "mac_fkMachineActivityType =" + this.fkActivityType.ToString() + ", ";
                    queryString += "mac_machineActivityName = '" + this.activityName.ToString() + "', ";
                    queryString += "mac_machineType = '" + this.machineType.ToString() + "', ";
                    if (this.enabled)
                    {
                        queryString += "mac_enabled=1; ";
                    }
                    else
                    {
                        queryString += "mac_enabled=0; ";
                    }
                    queryString += " WHERE mac_codsec = " + this.codsec.ToString() + ";";
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

                clsLog.addLog(ex, 3, "clsMachineActivities.save");
                return false;
            }

        }
    }
}
