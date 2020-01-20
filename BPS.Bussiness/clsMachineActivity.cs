using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMachineActivity
    {
        //Atributes
        private int ma_codsec;
        private int ma_fkMachine;
        private int ma_fkCuttingOrder;
        private int ma_fkMetallizedOrder;
        private int ma_fkExtruderOrder;
        private int ma_fkActivity;
        private DateTime ma_initialDate;
        private DateTime ma_endDate;
        private int ma_fkUser;
        private string ma_notes;

        //Properties
        public int codsec { get { return ma_codsec; } set { ma_codsec = value; } }
        public int fkMachine { get { return ma_fkMachine; } set { ma_fkMachine = value; } }
        public int fkCuttingOrder { get { return ma_fkCuttingOrder; } set { ma_fkCuttingOrder = value; } }
        public int fkMetallizedOrder { get { return ma_fkMetallizedOrder; } set { ma_fkMetallizedOrder = value; } }
        public int fkExtruderOrder { get { return ma_fkExtruderOrder; } set { ma_fkExtruderOrder = value; } }
        public int fkActivity { get { return ma_fkActivity; } set { ma_fkActivity = value; } }
        public DateTime initialDate { get { return ma_initialDate; } set { ma_initialDate= value; } }
        public DateTime endDate { get { return ma_endDate; } set { ma_endDate = value; } }
        public int fkUser { get { return ma_fkUser; } set { ma_fkUser = value; } }
        public string notes { get { return ma_notes; } set { ma_notes = value; } }

        //Constructor
        public clsMachineActivity()
        {
            codsec = 0;
            fkMachine = 0;
            fkCuttingOrder = 0;
            fkMetallizedOrder = 0;
            fkExtruderOrder = 0;
            fkActivity = 0;
            initialDate =DateTime.Now;
            endDate = DateTime.Now;
            fkUser = 0;
            notes = "";
        }

        public clsMachineActivity(int maCodsec)
        {
            this.load(maCodsec);
        }

        //Methods

        public void load(int maCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machineActivity WHERE ma_codsec=" + maCodsec.ToString());
            if(DS.Tables[0].Rows.Count>0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_fkMachine"]);
                fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_fkCuttingOrder"]);
                fkMetallizedOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_fkMetallizedOrder"]);
                fkExtruderOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_fkExtruderOrder"]);
                fkActivity= Convert.ToInt32(DS.Tables[0].Rows[0]["ma_fkActivity"]);
                initialDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ma_initialDate"]);
                endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ma_endDate"]);
                fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["ma_user"]);
                notes = DS.Tables[0].Rows[0]["ma_notes"].ToString();
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
                    queryString += "INSERT INTO bps_prod_machineActivity (ma_fkMachine, ma_fkCuttingOrder, ma_fkMetallizedOrder, ma_fkExtruderOrder, ma_fkActivity, ma_initialDate, ma_endDate, ma_fkUser, ma_notes) ";
                    queryString += " VALUES(";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "" + this.fkMetallizedOrder.ToString() + ", ";
                    queryString += "" + this.fkExtruderOrder.ToString() + ", ";
                    queryString += "" + this.fkActivity.ToString() + ", ";
                    queryString += "'" + this.initialDate.ToString() + "', ";
                    queryString += "'" + this.endDate.ToString() + "', ";
                    queryString += "" + this.fkUser.ToString() + ", ";
                    queryString += "'" + this.notes.ToString() + "'); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_machineActivity ";
                    queryString += " SET ";
                    queryString += "ma_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += "ma_fkCuttingOrder = " + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "ma_fkMetallizedOrder = " + this.fkMetallizedOrder.ToString() + ", ";
                    queryString += "ma_fkExtruderOrder = " + this.fkExtruderOrder.ToString() + ", ";
                    queryString += "ma_fkActivity = " + this.fkActivity.ToString() + ", ";
                    queryString += "ma_initialDate = '" + this.initialDate.ToString() + "', ";
                    queryString += "ma_endDate = '" + this.endDate.ToString() + "', ";
                    queryString += "ma_fkUser = " + this.fkUser.ToString() + ", ";
                    queryString += "ma_notes = '" + this.notes.ToString() + "' ";
                    queryString += " WHERE ma_codsec = " + this.codsec.ToString() + ";";
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

                clsLog.addLog(ex, 3, "clsMachineActivity.save");
                return false;
            }
            
        }
    }
}
