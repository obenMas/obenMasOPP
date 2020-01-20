using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCuttingPlan
    {
        //Atributes
        private int cp_codsec;
        private int cp_fkMachine;
        private int cp_fkActivity;
        private string cp_notes;
        private int cp_fkCuttingOrder;
        private int cp_cuttingStop;
        private int cp_fkParameters;
        private DateTime cp_programmedInitDate;
        private DateTime cp_programmedEndDate;
        private DateTime cp_InitDate;
        private DateTime cp_EndDate;
        

        //Properties
        public int codsec { get { return cp_codsec; } set { cp_codsec = value; } }
        public int fkMachine { get { return cp_fkMachine; } set { cp_fkMachine = value; } }
        public int fkActivity { get { return cp_fkActivity; } set { cp_fkActivity = value; } }
        public string notes { get { return cp_notes; } set { cp_notes = value; } }
        public int fkCuttingOrder { get { return cp_fkCuttingOrder; } set { cp_fkCuttingOrder = value; } }
        public int cuttingStop { get { return cp_cuttingStop; } set { cp_cuttingStop = value; } }
        public int fkParameters { get { return cp_fkParameters; } set { cp_fkParameters = value; } }        
        public DateTime programmedInitDate { get { return cp_programmedInitDate; } set { cp_programmedInitDate= value; } }
        public DateTime programmedEndDate { get { return cp_programmedEndDate; } set { cp_programmedEndDate = value; } }
        public DateTime initDate { get { return cp_InitDate; } set { cp_InitDate= value; } }
        public DateTime endDate { get { return cp_EndDate; } set { cp_EndDate = value; } }

        //Constructor
        public clsCuttingPlan()
        {
            codsec = 0;
            fkMachine = 0;
            fkActivity = 0;
            notes = "";
            fkCuttingOrder = 0;
            cuttingStop = 0;
            fkParameters = 0;            
            programmedInitDate =DateTime.Now;
            programmedEndDate = DateTime.Now;
            initDate =DateTime.Now;
            endDate = DateTime.Now;
        }

        public clsCuttingPlan(int maCodsec)
        {
            this.load(maCodsec);
        }

        //Methods

        public void load(int maCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingPlan WHERE cp_codsec=" + maCodsec.ToString());
            if(DS.Tables[0].Rows.Count>0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_fkMachine"]);
                fkActivity = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_fkActivity"]);
                notes = DS.Tables[0].Rows[0]["cp_notes"].ToString();
                fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_fkCuttingOrder"]);
                cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_cuttingStop"]);
                fkParameters = Convert.ToInt32(DS.Tables[0].Rows[0]["cp_fkParameters"]);
                programmedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cp_programmedInitDate"]);
                programmedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cp_programmedEndDate"]);
                initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cp_InitDate"]);
                endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cp_EndDate"]);
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
                    queryString += "INSERT INTO bps_prod_cuttingPlan (cp_fkMachine, cp_fkActivity, cp_notes, cp_fkCuttingOrder, cp_cuttingStop, cp_fkParameters, cp_programmedInitDate, cp_programmedEndDate,cp_InitDate, cp_EndDate) ";
                    queryString += " VALUES(";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + this.fkActivity.ToString() + ", ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "" + this.cuttingStop.ToString() + ", ";
                    queryString += "" + this.fkParameters.ToString() + ", ";                    
                    queryString += "'" + this.programmedInitDate.ToString() + "', ";
                    queryString += "'" + this.programmedEndDate.ToString() + "', ";
                    queryString += "'" + this.initDate.ToString() + "', ";
                    queryString += "'" + this.endDate.ToString() + "'); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingPlan ";
                    queryString += " SET ";
                    queryString += "cp_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += "cp_fkActivity = " + this.fkActivity.ToString() + ", ";
                    queryString += "cp_notes = '" + this.notes.ToString() + "', ";
                    queryString += "cp_fkCuttingOrder = " + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "cp_cuttingStop = " + this.cuttingStop.ToString() + ", ";
                    queryString += "cp_fkParameters = " + this.fkParameters.ToString() + ", ";
                    queryString += "cp_programmedInitDate = '" + this.programmedInitDate.ToString() + "', ";
                    queryString += "cp_programmedEndDate = '" + this.programmedEndDate.ToString() + "', ";
                    queryString += "cp_InitDate = '" + this.initDate.ToString() + "', ";
                    queryString += "cp_EndDate = '" + this.endDate.ToString() + "' ";
                    
                    queryString += " WHERE cp_codsec = " + this.codsec.ToString() + ";";
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

                clsLog.addLog(ex, 3, "clsCuttingPlan.save");
                return false;
            }
            
        }
    }
}
