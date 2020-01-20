using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMetalizedDeadTimeMillPallet
    {
        //Attributes
        private int mtodt_codsec;
        private int mtodt_fkOrder;
        private clsMillPallet mtodt_Order;
        private int mtodt_fkDeadTime;
        private clsMetalizedDeadTime mtdt_DeadTime;
        private DateTime mtodt_initdate;
        private DateTime mtodt_enddate;
        private double mtodt_totaldeadtime;
        private clsMainCoilMetal mtodt_MainCoilMetal;

        //Properties
        public int codsec { get { return mtodt_codsec; } set { mtodt_codsec = value; } }

        public int fkOrder { get { return mtodt_fkOrder; } set { mtodt_fkOrder = value; } }

        public clsMillPallet Order { get { return mtodt_Order; } set { mtodt_Order = value; } }

        public int fkDeadTime { get { return mtodt_fkDeadTime; } set { mtodt_fkDeadTime = value; } }

        public clsMetalizedDeadTime DeadTime { get { return mtdt_DeadTime; } set { mtdt_DeadTime = value; } }

        public DateTime InitDate { get { return mtodt_initdate; } set { mtodt_initdate = value; } }

        public DateTime EndDate { get { return mtodt_enddate; } set { mtodt_enddate = value; } }

        public double TotalDeadTimeMinutes { get { return mtodt_totaldeadtime; } set { mtodt_totaldeadtime = value; } }

        public clsMainCoilMetal MainCoilMetal { get { return mtodt_MainCoilMetal; } set { mtodt_MainCoilMetal = value; } }


        //Constructor
        public clsMetalizedDeadTimeMillPallet()
        { 
            mtodt_codsec = 0;
            mtodt_fkOrder = 0;
            mtodt_initdate = DateTime.Now;
            mtodt_enddate = DateTime.Now;
            mtodt_Order = new clsMillPallet();
            mtdt_DeadTime = new clsMetalizedDeadTime();
            mtodt_totaldeadtime = 0;
            mtodt_MainCoilMetal = new clsMainCoilMetal();
        }

        public clsMetalizedDeadTimeMillPallet(int Codsec)
        {
            this.load(Codsec);
        }

        //Methods
        public void load(int deadTimeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime " + deadTimeCodsec.ToString() + ", 'DeadTimeByCodsec'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mtodt_codsec"]);
                this.fkOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["mtodt_fkOrder"]);
                this.Order = new clsMillPallet(this.fkOrder);
                this.fkDeadTime = Convert.ToInt32(DS.Tables[0].Rows[0]["mtodt_fkDeadTime"]);
                this.DeadTime = new clsMetalizedDeadTime(this.fkDeadTime);
                this.InitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mtodt_initdate"]);
                this.EndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mtodt_enddate"]);
                this.TotalDeadTimeMinutes = Convert.ToDouble(DS.Tables[0].Rows[0]["mtodt_totaldeadtime"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimemillpallet (mtodt_fkOrder, mtodt_fkDeadTime, mtodt_initdate, mtodt_enddate, mtodt_totaldeadtime)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkOrder.ToString() + ",";
                    queryString += "" + this.fkDeadTime.ToString() + ",";
                    queryString += "'" + this.InitDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.EndDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "" + this.TotalDeadTimeMinutes + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimemillpallet";
                    queryString += " SET ";
                    queryString += "mtodt_fkOrder = " + this.fkOrder.ToString() + ",";
                    queryString += "mtodt_fkDeadTime = " + this.fkDeadTime.ToString() + ",";
                    queryString += "mtodt_initdate = '" + this.InitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "mtodt_enddate = '" + this.EndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "mtodt_totaldeadtime = " + this.TotalDeadTimeMinutes.ToString() + "";
                    queryString += " WHERE mtodt_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetalizedDeadTimeValues.save");
                return false;
            }
        }

        //public static List<clsMetalizedDeadTimeValues> getListByOrder(int codsec)
        //{
        //    List<clsMetalizedDeadTimeValues> lstDeadTimeType = new List<clsMetalizedDeadTimeValues>();

        //    DataSet DS = new DataSet();

        //    DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime " + codsec.ToString() + ", 'DeadTimeByOrder'");

        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstDeadTimeType.Add(new clsMetalizedDeadTimeValues());
        //            lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_codsec"]);
        //            lstDeadTimeType[i].fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_fkOrder"]);
        //            lstDeadTimeType[i].fkDeadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_fkDeadTime"]);
        //            lstDeadTimeType[i].DeadTime = new clsMetalizedDeadTime(lstDeadTimeType[i].fkDeadTime);
        //            lstDeadTimeType[i].InitDate =  Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_initdate"]);
        //            lstDeadTimeType[i].EndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_enddate"]);
        //            lstDeadTimeType[i].TotalDeadTimeMinutes = Convert.ToDouble(DS.Tables[0].Rows[i]["mtodt_totaldeadtimediff"]);
        //        }
        //    }

        //    return lstDeadTimeType;
        //}

        public static List<clsMetalizedDeadTimeMillPallet> getListByMillPallet(int codsec)
        {
            List<clsMetalizedDeadTimeMillPallet> lstDeadTimeType = new List<clsMetalizedDeadTimeMillPallet>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'DeadTimeByMillPallet','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedDeadTimeMillPallet());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_codsec"]);
                    lstDeadTimeType[i].fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_fkOrder"]);
                    lstDeadTimeType[i].fkDeadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodt_fkDeadTime"]);
                    lstDeadTimeType[i].DeadTime = new clsMetalizedDeadTime(lstDeadTimeType[i].fkDeadTime);
                    lstDeadTimeType[i].InitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_initdate"]);
                    lstDeadTimeType[i].EndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtodt_enddate"]);
                    lstDeadTimeType[i].TotalDeadTimeMinutes = Convert.ToDouble(DS.Tables[0].Rows[i]["mtodt_totaldeadtimediff"]);
                    lstDeadTimeType[i].Order = new clsMillPallet(lstDeadTimeType[i].fkOrder);
                }
            }

            return lstDeadTimeType;
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_deadtimemillpallet WHERE mtodt_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetalizedDeadTime.delete");
                return false;
            }
        }
    }
}
