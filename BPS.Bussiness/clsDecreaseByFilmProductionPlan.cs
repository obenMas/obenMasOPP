using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDecreaseByFilmProductionPlan
    {
        //Attibutes
        private int dbfpp_codsec;
        private int dbfpp_fkDecrease;
        private string dbfpp_decreaseName;
        private int dbfpp_fkFilmProductionPlan;
        private string dbfpp_FilmProductionPlanCode;
        private double dbfpp_weight;
        private DateTime dbfpp_createdDate;
        private int dbfpp_fkMachine;
        private string dbfpp_filmCode;
        private int dbfpp_fkFormulation;
        private string dbfpp_formulationName;
        private int dbfpp_orderNumber;
        private double TotalWeight;

        //Properties
        public int codsec { get { return dbfpp_codsec; } set { dbfpp_codsec = value; } }

        public int fkDecrease { get { return dbfpp_fkDecrease; } set { dbfpp_fkDecrease = value; } }

        public string decreaseName{get{return dbfpp_decreaseName;}set{dbfpp_decreaseName = value;}}

        public int fkFilmProductionPlan { get { return dbfpp_fkFilmProductionPlan; } set { dbfpp_fkFilmProductionPlan = value; } }

        public string FilmProductionPlanCode{get{return dbfpp_FilmProductionPlanCode;}set{dbfpp_FilmProductionPlanCode = value;}}

        public double weight { get { return dbfpp_weight; } set { dbfpp_weight = value; } }

        public DateTime createdDate  { get { return dbfpp_createdDate; } set { dbfpp_createdDate = value; } }

        public int fkMachine { get { return dbfpp_fkMachine; } set { dbfpp_fkMachine = value; } }

        public string filmCode { get { return dbfpp_filmCode; } set { dbfpp_filmCode = value; } }
        
        public int fkFormulation { get { return dbfpp_fkFormulation; } set { dbfpp_fkFormulation = value; } }

        public double TotalWeigth { get { return TotalWeight; } set { TotalWeight = value; } }

        public string formulationName { get { return dbfpp_formulationName; } set { dbfpp_formulationName = value; } }

        public int orderNumber { get { return dbfpp_orderNumber; } set { dbfpp_orderNumber = value; } }

        //Constructor
        public clsDecreaseByFilmProductionPlan()
        {
            dbfpp_codsec = 0;
            dbfpp_fkDecrease = 0;
            dbfpp_fkFilmProductionPlan = 0;
            dbfpp_weight = 0;
            dbfpp_createdDate = DateTime.Now;
            dbfpp_fkMachine = 0;
            dbfpp_filmCode = "";
            dbfpp_fkFormulation = 0;
            dbfpp_formulationName = "";
            dbfpp_orderNumber = 0;
        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_decreasebyFilmProductionPlan (dbfpp_fkDecrease, dbfpp_fkFilmProductionPlan, dbfpp_fkFormulation, dbfpp_weight, dbfpp_createdDate)";
                    queryString += " VALUES (";
                    queryString += " " + this.fkDecrease.ToString() + ",";
                    queryString += " " + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += " " + this.fkFormulation.ToString() + ",";
                    queryString += " " + this.weight.ToString() + ",";
                    queryString += " '" + this.createdDate.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_decreasebyFilmProductionPlan";
                    queryString += " SET ";
                    queryString += "dbfpp_fkDecrease = " + this.fkDecrease.ToString() + ",";
                    queryString += "dbfpp_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += "dbfpp_fkFormulation = " + this.fkFormulation.ToString() + ",";
                    queryString += "dbfpp_weight = " + this.weight.ToString() + ",";
                    queryString += "dbfpp_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += " WHERE dbfpp_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDecreaseByFilmProductionPlan.save");
                return false;
            }
        }

        public static List<clsDecreaseByFilmProductionPlan> getListByFilmProductionPlan(int FilmProductionPlanCodsec)
        {
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdecreasebyFilmProductionPlan WHERE dbfpp_fkFilmProductionPlan = " + FilmProductionPlanCodsec.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDecreaseByFilmProductionPlan.Add(new clsDecreaseByFilmProductionPlan());
                    lstDecreaseByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_codsec"]);
                    lstDecreaseByFilmProductionPlan[i].fkDecrease = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkDecrease"]);
                    lstDecreaseByFilmProductionPlan[i].decreaseName = DS.Tables[0].Rows[i]["dbfpp_decreaseName"].ToString();
                    lstDecreaseByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFilmProductionPlan"]);
                    lstDecreaseByFilmProductionPlan[i].FilmProductionPlanCode = DS.Tables[0].Rows[i]["dbfpp_FilmProductionPlanCode"].ToString();
                    lstDecreaseByFilmProductionPlan[i].weight = Convert.ToDouble(DS.Tables[0].Rows[i]["dbfpp_weight"]);
                    lstDecreaseByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dbfpp_createdDate"]);
                    lstDecreaseByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkMachine"]);
                    lstDecreaseByFilmProductionPlan[i].filmCode = DS.Tables[0].Rows[i]["dbfpp_filmCode"].ToString();
                    lstDecreaseByFilmProductionPlan[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFormulation"]);
                    lstDecreaseByFilmProductionPlan[i].formulationName = DS.Tables[0].Rows[i]["dbfpp_formulationName"].ToString();
                    lstDecreaseByFilmProductionPlan[i].orderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_orderNumber"]); 
                }
            }

            return lstDecreaseByFilmProductionPlan;
        }
        public static List<clsDecreaseByFilmProductionPlan> getListByfilter(List<clsFilter> lstFilter)
        {
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdecreasebyFilmProductionPlan " + where);

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDecreaseByFilmProductionPlan.Add(new clsDecreaseByFilmProductionPlan());
                    lstDecreaseByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_codsec"]);
                    lstDecreaseByFilmProductionPlan[i].fkDecrease = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkDecrease"]);
                    lstDecreaseByFilmProductionPlan[i].decreaseName = DS.Tables[0].Rows[i]["dbfpp_decreaseName"].ToString();
                    lstDecreaseByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFilmProductionPlan"]);
                    //lstDecreaseByFilmProductionPlan[i].FilmProductionPlanCode = DS.Tables[0].Rows[i]["dbfpp_FilmProductionPlanCode"].ToString();
                    lstDecreaseByFilmProductionPlan[i].weight = Convert.ToDouble(DS.Tables[0].Rows[i]["dbfpp_weight"]);
                    lstDecreaseByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dbfpp_createdDate"]);
                    lstDecreaseByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkMachine"]);
                    lstDecreaseByFilmProductionPlan[i].filmCode = DS.Tables[0].Rows[i]["dbfpp_filmCode"].ToString();
                    lstDecreaseByFilmProductionPlan[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFormulation"]);
                    lstDecreaseByFilmProductionPlan[i].formulationName = DS.Tables[0].Rows[i]["dbfpp_formulationName"].ToString();
                    //lstDecreaseByFilmProductionPlan[i].orderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_orderNumber"]); 
                }
            }

            return lstDecreaseByFilmProductionPlan;
        }
        public static List<clsDecreaseByFilmProductionPlan> getListDecrease(int Machine, String initDate, String endDate)
        {
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDecreaseByDate'" + initDate + "','" + endDate + "'," + Machine.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDecreaseByFilmProductionPlan.Add(new clsDecreaseByFilmProductionPlan());
                    lstDecreaseByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_codsec"]);
                    lstDecreaseByFilmProductionPlan[i].fkDecrease = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkDecrease"]);
                    lstDecreaseByFilmProductionPlan[i].decreaseName = DS.Tables[0].Rows[i]["dbfpp_decreaseName"].ToString();
                    lstDecreaseByFilmProductionPlan[i].weight = Convert.ToDouble(DS.Tables[0].Rows[i]["dbfpp_weight"]);
                    lstDecreaseByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dbfpp_createdDate"]);
                    //lstDecreaseByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                }
            }
            return lstDecreaseByFilmProductionPlan;
        }

        public static List<clsDecreaseByFilmProductionPlan> getListByProductionReport(int fkMachine, string initDate, string endDate)
        {
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spDecreaseByDate(" + "'" + initDate.ToString() + "', " + "'" + endDate.ToString() + "', " + fkMachine.ToString() + ");");
            
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstDecreaseByFilmProductionPlan.Add(new clsDecreaseByFilmProductionPlan());
                lstDecreaseByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_codsec"]);
                lstDecreaseByFilmProductionPlan[i].fkDecrease = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkDecrease"]);
                lstDecreaseByFilmProductionPlan[i].decreaseName = DS.Tables[0].Rows[i]["dbfpp_decreaseName"].ToString();
                lstDecreaseByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFilmProductionPlan"]);
                lstDecreaseByFilmProductionPlan[i].FilmProductionPlanCode = DS.Tables[0].Rows[i]["dbfpp_FilmProductionPlanCode"].ToString();
                lstDecreaseByFilmProductionPlan[i].weight = Convert.ToDouble(DS.Tables[0].Rows[i]["dbfpp_weight"]);
                lstDecreaseByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dbfpp_createdDate"]);
                lstDecreaseByFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkMachine"]);
                lstDecreaseByFilmProductionPlan[i].filmCode = DS.Tables[0].Rows[i]["dbfpp_filmCode"].ToString();
                lstDecreaseByFilmProductionPlan[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFormulation"]);
                lstDecreaseByFilmProductionPlan[i].formulationName = DS.Tables[0].Rows[i]["dbfpp_formulationName"].ToString();
                lstDecreaseByFilmProductionPlan[i].orderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_orderNumber"]); 
            }
            return lstDecreaseByFilmProductionPlan;
        }

        public static double getTotalDecreaseByFilmProductionPlan(int codsec)
        {   
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT dbo.fnGetDecreaseByFilmProductionPlan(" + codsec.ToString() + ") AS totalweigth");
            return Convert.ToDouble(DS.Tables[0].Rows[0]["totalweigth"].ToString());
        }
    }
}
