using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewExtrusionPlanDetail
    {
        private int nepd_codsec;
        private int nepd_fkNewExtrusionPlan;
        private int nepd_sequential;
        private int nepd_fkNewExtrusionOrder;
        private double nepd_deadTime;
        private double nepd_hours;

        //Properties

        public int codsec { get { return nepd_codsec; } set { nepd_codsec = value; } }

        public int fkNewExtrusionPlan { get { return nepd_fkNewExtrusionPlan; } set { nepd_fkNewExtrusionPlan = value; } }

        public int sequential { get { return nepd_sequential; } set { nepd_sequential = value; } }

        public int fkNewExtrusionOrder { get { return nepd_fkNewExtrusionOrder; } set { nepd_fkNewExtrusionOrder = value; } }

        public double deadTime { get { return nepd_deadTime; } set { nepd_deadTime = value; } }

        public double hours { get { return nepd_hours; } set { nepd_hours = value; } }


        //Constructor

        public clsNewExtrusionPlanDetail()
        {
            codsec = 0;
            fkNewExtrusionPlan = 0;
            sequential = 0;
            fkNewExtrusionOrder = 0;
            deadTime = 0;
            hours = 0;
        }

        public clsNewExtrusionPlanDetail(int cod)
        {
            this.load(cod);
        }

        //Methods

        public void load(int cod)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionPlanDetail where nepd_codsec = " + cod.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nepd_codsec"]);
                this.fkNewExtrusionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["nepd_fkNewExtrusionPlan"]);
                this.sequential = Convert.ToInt32(DS.Tables[0].Rows[0]["nepd_sequential"]);
                this.fkNewExtrusionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["nepd_fkNewExtrusionOrder"]);
                this.deadTime = Convert.ToDouble(DS.Tables[0].Rows[0]["nepd_deadTime"]);
                this.hours = Convert.ToDouble(DS.Tables[0].Rows[0]["nepd_hours"]);
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_new_extrusionPlanDetail (nepd_fkNewExtrusionPlan, nepd_sequential, nepd_fkNewExtrusionOrder,nepd_deadTime,nepd_hours)";
                    queryString += " VALUES (";
                    queryString += this.fkNewExtrusionPlan + ", ";
                    queryString += this.sequential + ", ";
                    queryString += this.fkNewExtrusionOrder + ", ";
                    queryString += this.deadTime + ", ";
                    queryString += this.hours + " ";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_new_extrusionPlanDetail";
                    queryString += " SET ";
                    queryString += "nepd_fkNewExtrusionPlan = " + this.fkNewExtrusionPlan + ", ";
                    queryString += "nepd_sequential = " + this.sequential + ", ";
                    queryString += "nepd_fkNewExtrusionOrder = " + this.fkNewExtrusionOrder + ", ";
                    queryString += "nepd_deadTime = " + this.deadTime + ", ";
                    queryString += "nepd_hours = " + this.hours + "";
                    queryString += " WHERE nepd_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewExtrusionPlanDetail.save");
                return false;
            }
        }

        public static bool delete(int cod)
        {
            try
            {
                string queryString = "DELETE FROM bps_new_extrusionPlanDetail WHERE nepd_codsec=" + cod;
                return (clsConnection.executeQuery(queryString));
            }
            catch(Exception ex) 
            {
                clsLog.addLog(ex, 3, "clsNewExtrusionPlanDetail.delete");
                return false;
            }
        }

        public static bool deletePlanDetail(int cod)
        {
            try
            {
                string queryString = "DELETE FROM bps_new_extrusionPlanDetail WHERE nepd_fkNewExtrusionPlan=" + cod;
                return (clsConnection.executeQuery(queryString));
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewExtrusionPlanDetail.deletePlanDetail");
                return false;
            }
        }
    }
}
