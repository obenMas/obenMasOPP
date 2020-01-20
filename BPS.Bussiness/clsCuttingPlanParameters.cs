using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCuttingPlanParameters
    {
        private int cpp_codsec;
        private string cpp_name;
        private int cpp_fkMachine;
        private int cpp_speed;
        private int cpp_cuttingOrderChange;
        private int cpp_cuttingStopChange;
        private int cpp_mainCoilChange;
        private int cpp_mainCoilSize;
        

        //Properties
        public int codsec { get { return cpp_codsec; } set { cpp_codsec = value; } }
        public string name { get { return cpp_name; } set { cpp_name = value; } }
        public int fkMachine { get { return cpp_fkMachine; } set { cpp_fkMachine = value; } }
        public int speed { get { return cpp_speed; } set { cpp_speed = value; } }
        public int cuttingOrderChange { get { return cpp_cuttingOrderChange; } set { cpp_cuttingOrderChange = value; } }
        public int cuttingStopChange { get { return cpp_cuttingStopChange; } set { cpp_cuttingStopChange = value; } }
        public int mainCoilChange { get { return cpp_mainCoilChange; } set { cpp_mainCoilChange = value; } }
        public int mainCoilSize { get { return cpp_mainCoilSize; } set { cpp_mainCoilSize = value; } }

        //Constructor
        public clsCuttingPlanParameters()
        {
            codsec = 0;
            name = "";
            fkMachine = 0;
            speed = 0;
            cuttingOrderChange = 0;
            cuttingStopChange = 0;
            mainCoilChange = 0;
            mainCoilSize = 0;
            
        }

        public clsCuttingPlanParameters(int maCodsec)
        {
            this.load(maCodsec);
        }

        //Methods

        public void load(int maCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingPlanParameters WHERE cpp_codsec" + maCodsec.ToString());
            if(DS.Tables[0].Rows.Count>0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_codsec"]);
                name = DS.Tables[0].Rows[0]["cpp_name"].ToString();
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkMachine"]);
                speed = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_speed"]);
                cuttingOrderChange = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_cuttingOrderChange"]);
                cuttingStopChange = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_cuttingStopChange"]);
                mainCoilChange = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_mainCoilChange"]);
                mainCoilSize = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_mainCoilSize"]);
                
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public bool save()
        {
            return this.save(0, 0);
        }
        public bool save(int machineCodsec,int activityCodsec)
        {
            try
            {
                string queryString="";
                if(this.codsec==0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingPlanParameters (cpp_name, cpp_fkMachine, cpp_speed, cpp_cuttingOrderChange, cpp_cuttingStopChange, cpp_mainCoilChange, cpp_mainCoilSize) ";
                    queryString += " VALUES(";
                    queryString += "'" + this.name.ToString() + "', ";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + this.speed.ToString() + ", ";
                    queryString += "" + this.cuttingOrderChange.ToString() + ", ";
                    queryString += "" + this.cuttingStopChange.ToString() + ", ";
                    queryString += "" + this.mainCoilChange.ToString() + ", ";
                    queryString += "" + this.mainCoilSize.ToString() + "); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingPlanParameters ";
                    queryString += " SET ";
                    queryString += "cpp_name = '" + this.name.ToString() + "', ";
                    queryString += "cpp_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += "cpp_speed = " + this.speed.ToString() + ", ";
                    queryString += "cpp_cuttingOrderChange = " + this.cuttingOrderChange.ToString() + ", ";
                    queryString += "cpp_cuttingStopChange = " + this.cuttingStopChange.ToString() + ", ";
                    queryString += "cpp_mainCoilChange = " + this.mainCoilChange.ToString() + ", ";
                    queryString += "cpp_mainCoilSize = " + this.mainCoilSize.ToString() + " ";
                    queryString += " WHERE cpp_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return true;
            }
            catch(Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCuttingPlanParameters.save");
                return false;
            }
            
        }
    }
}
