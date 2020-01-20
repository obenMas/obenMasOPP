using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeByFilmProductionPlan
    {
        //Attributes
        private int dtbfpp_codsec;
        private int dtbfpp_fkDeadTimeType;
        private string dtbfpp_deadTimeTypeName;
        private string dtbfpp_deadTimeGroup;
        private int dtbfpp_fkFilmProductionPlan;
        private string dtbfpp_lotNumber;
        private DateTime dtbfpp_initDate;
        private DateTime dtbfpp_endDate;
        private int dtbfpp_fkMachine;
        private double dtbfpp_hourdead;
        private double dtbfpp_tmp;
        private double dtbfpp_tmm;
        private double dtbfpp_tmothers;
        private double dtbfpp_total;

        private int dtbfpp_source;

        public int source
        {
            get { return dtbfpp_source; }
            set { dtbfpp_source = value; }
        }

        private string dtbfpp_notes;

        public string notes
        {
            get { return dtbfpp_notes; }
            set { dtbfpp_notes = value; }
        }



        //Properties
        public int codsec { get { return dtbfpp_codsec; } set { dtbfpp_codsec = value; } }

        public int fkDeadTimeType { get { return dtbfpp_fkDeadTimeType; } set { dtbfpp_fkDeadTimeType = value; } }

        public string deadTimeTypeName { get { return dtbfpp_deadTimeTypeName; } set { dtbfpp_deadTimeTypeName = value; } }

        public string deadTimeGroup { get { return dtbfpp_deadTimeGroup; } set { dtbfpp_deadTimeGroup = value; } }

        public int fkFilmProductionPlan { get { return dtbfpp_fkFilmProductionPlan; } set { dtbfpp_fkFilmProductionPlan = value; } }

        public string lotNumber { get { return dtbfpp_lotNumber; } set { dtbfpp_lotNumber = value; } }

        public DateTime initDate { get { return dtbfpp_initDate; } set { dtbfpp_initDate = value; } }

        public DateTime endDate { get { return dtbfpp_endDate; } set { dtbfpp_endDate = value; } }

        public int fkMachine { get { return dtbfpp_fkMachine; } set { dtbfpp_fkMachine = value; } }

        public double HourDead { get { return dtbfpp_hourdead; } set { dtbfpp_hourdead = value; } }

        public double tmp { get { return dtbfpp_tmp; } set { dtbfpp_tmp = value; } }

        public double tmm { get { return dtbfpp_tmm; } set { dtbfpp_tmm = value; } }

        public double tmothers { get { return dtbfpp_tmothers; } set { dtbfpp_tmothers = value; } }

        public double total { get { return dtbfpp_total; } set { dtbfpp_total = value; } }

        //Constructor
        public clsDeadTimeByFilmProductionPlan()
        {
            dtbfpp_codsec = 0;
            dtbfpp_fkDeadTimeType = 0;
            dtbfpp_deadTimeTypeName = "";
            dtbfpp_deadTimeGroup = "";
            dtbfpp_fkFilmProductionPlan = 0;
            dtbfpp_lotNumber = "";
            dtbfpp_initDate = DateTime.Now;
            dtbfpp_endDate = DateTime.Now;
            dtbfpp_fkMachine = 0;
            dtbfpp_hourdead = 0;
            dtbfpp_tmp = 0;
            dtbfpp_tmm = 0;
            dtbfpp_tmothers = 0;
            dtbfpp_total = 0;
        }

        //Methods
        public void load(int deadTimeByFilmProducctionPlanCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplan WHERE dtbfpp_codsec = " + deadTimeByFilmProducctionPlanCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["dtbfpp_codsec"]);
                this.fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[0]["dtbfpp_fkDeadTimeType"]);
                this.deadTimeTypeName = DS.Tables[0].Rows[0]["dtbfpp_deadTimeTypeName"].ToString();
                this.deadTimeGroup = DS.Tables[0].Rows[0]["dtbfpp_deadTimeGroup"].ToString();
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["dtbfpp_fkFilmProductionPlan"]);
                this.lotNumber = DS.Tables[0].Rows[0]["dtbfpp_lotNumber"].ToString();
                this.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["dtbfpp_initDate"]);
                this.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["dtbfpp_endDate"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["dtbfpp_fkMachine"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_deadtimebyfilmproductionplan (dtbfpp_fkDeadTimeType, dtbfpp_fkFilmProductionPlan, dtbfpp_initDate, dtbfpp_endDate, dtbfpp_source)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDeadTimeType.ToString() + ",";
                    queryString += "'" + this.fkFilmProductionPlan.ToString() + "',";
                    queryString += "'" + this.initDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.endDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + this.source.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_deadtimebyfilmproductionplan";
                    queryString += " SET ";
                    queryString += "dtbfpp_fkDeadTimeType = " + this.fkDeadTimeType.ToString() + ",";
                    queryString += "dtbfpp_fkFilmProductionPlan = '" + this.fkFilmProductionPlan.ToString() + "',";
                    queryString += "dtbfpp_initDate = '" + this.initDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "dtbfpp_endDate = '" + this.endDate.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += " WHERE dtbfpp_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeByFilmProductionPlan.save");
                return false;
            }
        }

        public static List<clsDeadTimeByFilmProductionPlan> getList()
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimetype order By dtt_deadTimeName");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                }
            }

            return lstDeadTimeByFilmProductionPlan;
        }
        public static List<clsDeadTimeByFilmProductionPlan> getListByFilmProductionPlan(int filmProductionPlanCodsec)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplan WHERE dtbfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString() + " order By dtbfpp_deadTimeTypeName");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                }
            }
            return lstDeadTimeByFilmProductionPlan;
        }

        public static List<clsDeadTimeByFilmProductionPlan> getListByFilmProductionPlanByGroup(int filmProductionPlanCodsec)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplanbydeadtimegroup  WHERE dtbfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                }
            }
            return lstDeadTimeByFilmProductionPlan;
        }
        public static List<clsDeadTimeByFilmProductionPlan> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplan " + where + " order By dtbfpp_deadTimeTypeName");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                }
            }

            return lstDeadTimeByFilmProductionPlan;
        }

        public static List<clsDeadTimeByFilmProductionPlan> getListFilmProductionPlanByMothByMachine(int fkMachine, string endDate, string initDate)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeByDate" + "'" + initDate.ToString() + "', " + "'" + endDate.ToString() + "', " + fkMachine.ToString() + "");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                    lstDeadTimeByFilmProductionPlan[i].HourDead = Convert.ToInt32(DS.Tables[0].Rows[i]["hourdead"]);
                }
            }

            return lstDeadTimeByFilmProductionPlan;
        }
        public static List<clsDeadTimeByFilmProductionPlan> getDeadTimeByMachineAndDate(DateTime initDate, DateTime endDate, int MachineCod)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplan where dtbfpp_initDate BETWEEN '" + initDate.ToString("dd/MM/yyyy HH:mm:ss") + "' AND '" + endDate.ToString("dd/MM/yyyy HH:mm:ss") + "' AND dtbfpp_fkMachine=" + MachineCod.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                }
            }

            return lstDeadTimeByFilmProductionPlan;
        }
        public static List<clsDeadTimeByFilmProductionPlan> getListProductionReport(int fkMachine, string endDate, string initDate)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spDeadTimeByDate(" + "'" + initDate.ToString() + "', " + "'" + endDate.ToString() + "', " + fkMachine.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                }
            }

            return lstDeadTimeByFilmProductionPlan;
        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) COALESCE(MAX(dtbfpp_codsec),0) AS codsec FROM bps_prod_deadtimebyfilmproductionplan");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"]);
            else
                return 0;
        }


        public static List<clsDeadTimeByFilmProductionPlan> getListByFilmProductionPlanSecond(int filmProductionPlanCodsec)
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplan WHERE dtbfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString() + " order By dtbfpp_deadTimeTypeName");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlan.Add(new clsDeadTimeByFilmProductionPlan());
                    lstDeadTimeByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_codsec"]);
                    lstDeadTimeByFilmProductionPlan[i].fkDeadTimeType = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkDeadTimeType"]);
                    lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].deadTimeGroup = DS.Tables[0].Rows[i]["dtbfpp_deadTimeGroup"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"]);
                    lstDeadTimeByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["dtbfpp_lotNumber"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlan[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkMachine"]);
                    lstDeadTimeByFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["dtbfpp_notes"].ToString();
                    lstDeadTimeByFilmProductionPlan[i].source = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_source"]);
                }
            }
            return lstDeadTimeByFilmProductionPlan;
        }

        public static bool updateSource(int lastCodsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_deadtimebyfilmproductionplan";
                queryString += " SET ";
                queryString += "dtbfpp_source = " + lastCodsec.ToString() + "";
                queryString += " WHERE dtbfpp_codsec = " + lastCodsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeByFilmProductionPlan.save");
                return false;
            }
        }

        public static bool updateNotes(int codsec, string notes)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_deadtimebyfilmproductionplan";
                queryString += " SET ";
                queryString += "dtbfpp_notes = '" + notes + "'";
                queryString += " WHERE dtbfpp_codsec = " + codsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeByFilmProductionPlan.save");
                return false;
            }
        }

        public static bool detele(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "DELETE FROM bps_prod_deadtimebyfilmproductionplan";
                queryString += " WHERE dtbfpp_codsec = " + codsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeByFilmProductionPlan.save");
                return false;
            }
        }

        public static bool deteleSource(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "DELETE FROM bps_prod_deadtimebyfilmproductionplan";
                queryString += " WHERE dtbfpp_source = " + codsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDeadTimeByFilmProductionPlan.save");
                return false;
            }
        }
    }
}
