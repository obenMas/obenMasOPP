using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de produccion para productos de Film
    /// </summary>
    public class clsFilmProductionPlan
    {
        //Atributes

        private int fpo_codsec;
        private int fpo_fkProductionOrder;
        private clsProductionOrder fpo_productionOrder;
        private int fpo_fkMachine;
        private string fpo_MachineName;
        private int fpo_fkBaseFilm;
        private int fpo_productionOrderNumber;
        private int fpo_fkProductionOrderStatus;
        private string fpo_productionOrderStatusName;
        private string fpo_lotNumber;
        private double fpo_totalWeight;
        private DateTime fpo_estimatedInitDate;
        private DateTime fpo_estimatedEndDate;
        private int fpo_estimatedKilogramsPerHour;
        private int fpo_estimatedIdleTime;
        private int fpo_lotNumberSequential;
        private string fpo_notes;
        private string fpo_widths;
        private int fpo_estimatedLength;
        private string fpo_companyName;
        private string bopp_Code;
        private string cast_Code;
        private string coating_Code;
        private double sum_acount;
        private bool fpo_variation;
        private DateTime fpo_variationDate;
        private double fpo_consumptionWeight;
        private int fpo_ordenation;

        //Properties

        public int codsec { get { return fpo_codsec; } set { fpo_codsec = value; } }

        public int fkProductionOrder { get { return fpo_fkProductionOrder; } set { fpo_fkProductionOrder = value; } }

        public clsProductionOrder productionOrder { get { return fpo_productionOrder; } set { fpo_productionOrder = value; } }

        public int fkMachine { get { return fpo_fkMachine; } set { fpo_fkMachine = value; } }

        public string MachineName { get { return fpo_MachineName; } set { fpo_MachineName = value; } }

        public int fkBaseFilm { get { return fpo_fkBaseFilm; } set { fpo_fkBaseFilm = value; } }

        public int productionOrderNumber { get { return fpo_productionOrderNumber; } set { fpo_productionOrderNumber = value; } }

        public int fkProductionOrderStatus { get { return fpo_fkProductionOrderStatus; } set { fpo_fkProductionOrderStatus = value; } }

        public string productionOrderStatusName { get { return fpo_productionOrderStatusName; } set { fpo_productionOrderStatusName = value; } }

        public string lotNumber { get { return fpo_lotNumber; } set { fpo_lotNumber = value; } }

        public double totalWeight { get { return fpo_totalWeight; } set { fpo_totalWeight = value; } }

        public DateTime estimatedInitDate { get { return fpo_estimatedInitDate; } set { fpo_estimatedInitDate = value; } }

        public DateTime estimatedEndDate { get { return fpo_estimatedEndDate; } set { fpo_estimatedEndDate = value; } }

        public int estimatedKilogramsPerHour { get { return fpo_estimatedKilogramsPerHour; } set { fpo_estimatedKilogramsPerHour = value; } }

        public int estimatedIdleTime { get { return fpo_estimatedIdleTime; } set { fpo_estimatedIdleTime = value; } }

        public int lotNumberSequential { get { return fpo_lotNumberSequential; } set { fpo_lotNumberSequential = value; } }

        public string notes { get { return fpo_notes; } set { fpo_notes = value; } }

        public string widths { get { return fpo_widths; } set { fpo_widths = value; } }

        public int estimatedLength { get { return fpo_estimatedLength; } set { fpo_estimatedLength = value; } }

        public string companyName { get { return fpo_companyName; } set { fpo_companyName = value; } }

        public string boppcode { get { return bopp_Code; } set { bopp_Code = value; } }

        public string castcode { get { return cast_Code; } set { cast_Code = value; } }

        public string coatingcode { get { return coating_Code; } set { coating_Code = value; } }

        public double acount { get { return sum_acount; } set { sum_acount = value; } }

        public bool variation { get { return fpo_variation; } set { fpo_variation = value; } }

        public DateTime variationDate { get { return fpo_variationDate; } set { fpo_variationDate = value; } }

        public double consumptionWeight { get { return fpo_consumptionWeight; } set { fpo_consumptionWeight = value; } }

        public int ordenation { get { return fpo_ordenation; } set { fpo_ordenation = value; } }


        //Constructor

        public clsFilmProductionPlan()
        {
            fpo_codsec = 0;
            fpo_fkProductionOrder = 0;
            fpo_productionOrder = new clsProductionOrder();
            fpo_productionOrderNumber = 0;
            fpo_productionOrderStatusName = "";
            fpo_fkProductionOrderStatus = 0;
            fpo_lotNumber = "";
            fpo_fkMachine = 0;
            fpo_MachineName = "";
            fpo_fkBaseFilm = 0;
            fpo_totalWeight = 0;
            fpo_estimatedInitDate = DateTime.Now;
            fpo_estimatedEndDate = DateTime.Now;
            fpo_estimatedKilogramsPerHour = 0;
            fpo_estimatedIdleTime = 0;
            fpo_lotNumberSequential = 0;
            fpo_notes = "";
            fpo_widths = "";
            fpo_estimatedLength = 0;
            fpo_companyName = "";
            sum_acount = 0;
            fpo_variation = false;
            fpo_variationDate = DateTime.Now;
            fpo_consumptionWeight = 0;
            fpo_ordenation = 0;
        }
        public clsFilmProductionPlan(int filmProductionPlanCodsec)
        {
            this.load(filmProductionPlanCodsec);
        }
        public clsFilmProductionPlan(int filmProductionPlanCodsec, bool simplified)
        {
            this.loadSimplified(filmProductionPlanCodsec);
        }

        public clsFilmProductionPlan(string lotNumber)
        {
            this.loadByLotNumber(lotNumber);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + codsec.ToString() + ",'GetFilmProductionPlanByCodsec'");

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrder"]);
                this.productionOrder = new clsProductionOrder(this.fkProductionOrder);
                this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_productionOrderNumber"]);
                this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrderStatus"]);
                this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpo_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpo_lotNumber"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["fpo_MachineName"].ToString();
                this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_totalWeigth"]);
                this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedInitDate"]);
                this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedEndDate"]);
                this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedKilogramsPerHour"]);
                this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedIdleTime"]);
                this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpo_notes"].ToString();
                this.widths = DS.Tables[0].Rows[0]["fpo_widths"].ToString();
                this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedLength"]);
                this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpo_variation"], DS.Tables[0].Rows[0]["fpo_variation"].GetType().FullName);
                this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_variationDate"]);
                this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpo_consumptionWeight"]);
            }
        }

        public void loadSimplified(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilmProductionPlanByCodsec " + codsec.ToString() + "");

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrder"]);
                this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_productionOrderNumber"]);
                this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrderStatus"]);
                this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpo_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpo_lotNumber"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["fpo_MachineName"].ToString();
                this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_totalWeigth"]);
                this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedInitDate"]);
                this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedEndDate"]);
                this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedKilogramsPerHour"]);
                this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedIdleTime"]);
                this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpo_notes"].ToString();
                this.widths = DS.Tables[0].Rows[0]["fpo_widths"].ToString();
                this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedLength"]);
                this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpo_variation"], DS.Tables[0].Rows[0]["fpo_variation"].GetType().FullName);
                this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_variationDate"]);
                this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpo_consumptionWeight"]);
            }
        }

        public void loadByLotNumber(string lotNumber)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_filmproductionplan WHERE fpo_lotNumber = " + lotNumber.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrder"]);
                this.lotNumber = DS.Tables[0].Rows[0]["fpo_lotNumber"].ToString();    
            }
        }

        public static clsFilmProductionPlan getFilmProductionPlanByProductionOrder(int ProductionOrdercodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + ProductionOrdercodsec.ToString() + ",'GetFilmProductionPlanByProductionOrder'");

            clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();

            if (DS.Tables.Count > 0)
            {
                objFilmProductionPlan.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
                objFilmProductionPlan.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrder"]);
                objFilmProductionPlan.productionOrder = new clsProductionOrder(objFilmProductionPlan.fkProductionOrder);
                objFilmProductionPlan.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_productionOrderNumber"]);
                objFilmProductionPlan.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrderStatus"]);
                objFilmProductionPlan.productionOrderStatusName = DS.Tables[0].Rows[0]["fpo_productionOrderStatusName"].ToString();
                objFilmProductionPlan.lotNumber = DS.Tables[0].Rows[0]["fpo_lotNumber"].ToString();
                objFilmProductionPlan.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkMachine"]);
                objFilmProductionPlan.MachineName = DS.Tables[0].Rows[0]["fpo_MachineName"].ToString();
                objFilmProductionPlan.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_totalWeigth"]);
                objFilmProductionPlan.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedInitDate"]);
                objFilmProductionPlan.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedEndDate"]);
                objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedKilogramsPerHour"]);
                objFilmProductionPlan.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedIdleTime"]);
                objFilmProductionPlan.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]);
                objFilmProductionPlan.notes = DS.Tables[0].Rows[0]["fpo_notes"].ToString();
                objFilmProductionPlan.widths = DS.Tables[0].Rows[0]["fpo_widths"].ToString();
                objFilmProductionPlan.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedLength"]);
                objFilmProductionPlan.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpo_variation"], DS.Tables[0].Rows[0]["fpo_variation"].GetType().FullName);
                objFilmProductionPlan.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_variationDate"]);
                objFilmProductionPlan.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpo_consumptionWeight"]);
            }
            return objFilmProductionPlan;
        }

        public void loadFilmProductionPlanByProductionOrder(int productionOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + productionOrderCodsec.ToString() + ",'GetFilmProductionPlanByProductionOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrder"]);
                //this.productionOrder.load(this.fkProductionOrder);
                this.productionOrder = new clsProductionOrder(this.fkProductionOrder);
                this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_productionOrderNumber"]);
                this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkProductionOrderStatus"]);
                this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpo_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpo_lotNumber"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["fpo_MachineName"].ToString();
                this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_totalWeigth"]);
                this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedInitDate"]);
                this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_estimatedEndDate"]);
                this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedKilogramsPerHour"]);
                this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedIdleTime"]);
                this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpo_notes"].ToString();
                this.widths = DS.Tables[0].Rows[0]["fpo_widths"].ToString();
                this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_estimatedLength"]);
                this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpo_variation"], DS.Tables[0].Rows[0]["fpo_variation"].GetType().FullName);
                this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpo_variationDate"]);
                this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpo_consumptionWeight"]);
            }
        }
        public bool save()
        {
            return this.save(false);
        }

        public bool save(bool registerVariation)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_filmproductionplan (fpo_fkProductionOrder, fpo_fkMachine, fpo_lotNumber, fpo_totalWeigth, fpo_estimatedInitDate, fpo_estimatedEndDate, fpo_estimatedKilogramsPerHour, fpo_estimatedIdleTime, fpo_lotNumberSequential, fpo_notes, fpo_widths, fpo_estimatedLength, fpo_variation, fpo_variationDate, fpo_consumptionWeight) ";
                    queryString += " VALUES (";
                    queryString += " " + this.fkProductionOrder.ToString() + ",";
                    queryString += " " + this.fkMachine.ToString() + ",";
                    queryString += " '" + this.lotNumber.ToString() + "',";
                    queryString += " " + this.totalWeight.ToString() + ",";
                    queryString += " '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " " + this.estimatedKilogramsPerHour.ToString() + ",";
                    queryString += " " + this.estimatedIdleTime.ToString() + ",";
                    queryString += " " + this.lotNumberSequential.ToString() + ",";
                    queryString += " '" + this.notes + "',";
                    queryString += " '" + this.widths + "',";
                    queryString += " " + this.estimatedLength + ", ";
                    queryString += " " + "0" + ", ";
                    queryString += " '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " 0";
                    queryString += ");";
                }
                else
                {
                    if (registerVariation)
                    {
                        queryString += "UPDATE bps_prod_filmproductionplan";
                        queryString += " SET ";
                        queryString += " fpo_fkProductionOrder = " + this.fkProductionOrder.ToString() + ",";
                        queryString += " fpo_fkMachine = " + this.fkMachine.ToString() + ",";
                        queryString += " fpo_lotNumber = '" + this.lotNumber.ToString() + "',";
                        queryString += " fpo_totalWeigth = " + this.totalWeight.ToString() + ",";
                        queryString += " fpo_estimatedInitDate = '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpo_estimatedEndDate = '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpo_estimatedKilogramsPerHour = " + this.estimatedKilogramsPerHour.ToString() + ", ";
                        queryString += " fpo_estimatedIdleTime = " + this.estimatedIdleTime.ToString() + ", ";
                        queryString += " fpo_lotNumberSequential = " + this.lotNumberSequential.ToString() + ", ";
                        queryString += " fpo_notes = '" + this.notes.ToString() + "',";
                        queryString += " fpo_widths = '" + this.widths + "',";
                        queryString += " fpo_estimatedLength = " + this.estimatedLength.ToString() + ", ";
                        queryString += " fpo_variation = 1, ";
                        queryString += " fpo_variationDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
                        queryString += " WHERE fpo_codsec = " + this.codsec.ToString() + ";";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_filmproductionplan";
                        queryString += " SET ";
                        queryString += " fpo_fkProductionOrder = " + this.fkProductionOrder.ToString() + ",";
                        queryString += " fpo_fkMachine = " + this.fkMachine.ToString() + ",";
                        queryString += " fpo_lotNumber = '" + this.lotNumber.ToString() + "',";
                        queryString += " fpo_totalWeigth = " + this.totalWeight.ToString() + ",";
                        queryString += " fpo_estimatedInitDate = '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpo_estimatedEndDate = '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpo_estimatedKilogramsPerHour = " + this.estimatedKilogramsPerHour.ToString() + ", ";
                        queryString += " fpo_estimatedIdleTime = " + this.estimatedIdleTime.ToString() + ", ";
                        queryString += " fpo_lotNumberSequential = " + this.lotNumberSequential.ToString() + ", ";
                        queryString += " fpo_notes = '" + this.notes.ToString() + "',";
                        queryString += " fpo_widths = '" + this.widths + "',";
                        queryString += " fpo_estimatedLength = " + this.estimatedLength.ToString() + " ";
                        queryString += " WHERE fpo_codsec = " + this.codsec.ToString() + ";";
                    }
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = this.getLastSavedCodsec();

                return true;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFilmProductionPlan.save");
                return false;
            }
        }

        public bool save(string pos)
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_filmproductionplan";
                queryString += " SET ";
                queryString += " fpo_ordenation = " + this.ordenation.ToString() + " ";
                queryString += " WHERE fpo_codsec = " + this.codsec.ToString() + ";";
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFilmProductionPlan.save(pos)");
                return false;
            }
        }

        public static List<clsFilmProductionPlan> getList()
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,'GetFilmProductionPlanList'");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }

            return lstFilmProductionPlan;
        }

        public static List<clsFilmProductionPlan> getListByLotNumeber()
        {
            List<clsFilmProductionPlan> lstFilmProductionPlanByLotNumeber = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,'GetLotNumber'");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlanByLotNumeber.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlanByLotNumeber[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlanByLotNumeber[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlanByLotNumeber[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlanByLotNumeber[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlanByLotNumeber[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlanByLotNumeber[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlanByLotNumeber[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }

            return lstFilmProductionPlanByLotNumeber;
        }

        public static List<clsFilmProductionPlan> getListByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + machineCodsec.ToString() + ",'GetFilmProductionPlanByMachine'");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }
            return lstFilmProductionPlan;
        }

        public static List<clsFilmProductionPlan> getListByMachineNow(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFilmProductionBySalesOrderNOW (" + machineCodsec.ToString() + ")");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlan[i].boppcode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstFilmProductionPlan[i].castcode = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                    lstFilmProductionPlan[i].coatingcode = DS.Tables[0].Rows[i]["coat_code"].ToString();
                    lstFilmProductionPlan[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }
            return lstFilmProductionPlan;
        }
        public static List<clsFilmProductionPlan> getActiveListByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("Select * FROM vwFilmProductionPlan WHERE fpo_fkMachine = " + machineCodsec.ToString());
            //DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + machineCodsec.ToString() + ",'GetFilmProductionPlanByMachine'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString() != "Cerrada" && DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString() != "Anulada")
                    {
                        lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrder.load(lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrder);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                    }
                }
            }
            return lstFilmProductionPlan;
        }

        //Cambie el parametro machine de char a int
        public static List<clsFilmProductionPlan> getExtruderOrder(int machine)
        {
            DataSet DS = new DataSet();
            List<clsFilmProductionPlan> filmproList = new List<clsFilmProductionPlan>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawExtruder',0,'" + machine + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    filmproList.Add(new clsFilmProductionPlan());
                    filmproList[filmproList.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pro_fkFilmProductionOrder"]);
                    filmproList[filmproList.Count - 1].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["pro_fkProductionOrder"]);
                    filmproList[filmproList.Count - 1].boppcode = DS.Tables[0].Rows[i]["pro_Bopp"].ToString();
                    filmproList[filmproList.Count - 1].productionOrderStatusName = DS.Tables[0].Rows[i]["pro_Status"].ToString();
                    filmproList[filmproList.Count - 1].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["pro_quantity"]);
                    filmproList[filmproList.Count - 1].lotNumber = DS.Tables[0].Rows[i]["pro_lotNumber"].ToString();
                    filmproList[filmproList.Count - 1].MachineName = DS.Tables[0].Rows[i]["pro_name"].ToString();
                    filmproList[filmproList.Count - 1].notes = DS.Tables[0].Rows[i]["pro_machine"].ToString();
                    filmproList[filmproList.Count - 1].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"].ToString());
                }
            }

            return filmproList;
        }

        public static List<clsFilmProductionPlan> getListByMachineAndFilter(int machineCodsec, DateTime date, string operation)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + date.ToString("dd/MM/yyyy HH:mm:ss") + "', " + machineCodsec.ToString() + ", '" + operation + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_machine"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].boppcode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                    lstFilmProductionPlan[i].ordenation = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_ordenation"]);
                }
            }
            return lstFilmProductionPlan;
        }

        public static List<clsFilmProductionPlan> getFilmProductionPlanListByFilter(List<clsFilter> lstFilter)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFilmProductionPlan " + where + "  order by fpo_lotNumber DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                }
            }
            return lstFilmProductionPlan;
        }


        public static List<clsFilmProductionPlan> getListOfActiveItemsByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            //DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + machineCodsec.ToString() + ",'GetFilmProductionPlanByMachinePerStatusOK'");

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpo_fkMachine = " + machineCodsec.ToString() + " and (fpo_productionOrderStatusName = 'Planificada' or fpo_productionOrderStatusName = 'En Producción') ");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }
            return lstFilmProductionPlan;
        }
        public static void recalculateActiveItemsByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            //DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + machineCodsec.ToString() + ",'GetFilmProductionPlanByMachinePerStatus'");
            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpo_fkMachine = " + machineCodsec.ToString() + " and (fpo_productionOrderStatusName = 'Planificada' or fpo_productionOrderStatusName = 'En Producción') ");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                }
            }
            DateTime initDate = new DateTime();
            if (lstFilmProductionPlan.Count > 0)
                initDate = lstFilmProductionPlan[0].estimatedInitDate;

            for (int i = 0; i < lstFilmProductionPlan.Count; i++)
            {
                if (i == 0)
                {
                    lstFilmProductionPlan[i].estimatedInitDate = initDate;
                    lstFilmProductionPlan[i].estimatedEndDate = initDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                else
                {
                    lstFilmProductionPlan[i].estimatedInitDate = lstFilmProductionPlan[i - 1].estimatedEndDate;
                    lstFilmProductionPlan[i].estimatedEndDate = lstFilmProductionPlan[i].estimatedInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                lstFilmProductionPlan[i].save();
            }
        }
        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT fpo_codsec FROM bps_prod_filmproductionplan ORDER BY fpo_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_codsec"]);
        }
        public static int getNextLotNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT fpo_lotNumberSequential FROM bps_prod_filmproductionplan ORDER BY fpo_lotNumber DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]) + 1;
        }

        public static int getNextLotNumberByMachine(int mchCodsec)
        {
            int lotnumber = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT fpo_lotNumberSequential FROM bps_prod_filmproductionplan WHERE fpo_fkMachine = " + mchCodsec.ToString() + " AND fpo_lotNumberSequential <> 0 ORDER BY fpo_estimatedInitDate DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                lotnumber = ((Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"])) + 1);
                if (lotnumber != Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]))
                    return lotnumber;
                else
                {
                    if (lotnumber == Convert.ToInt32(DS.Tables[0].Rows[0]["fpo_lotNumberSequential"]))
                        return (lotnumber + 1);
                    else
                        return (lotnumber + 1);
                }
            }
            else
                return 0;
        }

        public void setLotNumberSecuential()
        {
            this.lotNumberSequential = clsFilmProductionPlan.getNextLotNumberByMachine(this.fkMachine);
            clsConnection.executeQuery("UPDATE bps_prod_filmproductionplan SET fpo_lotNumberSequential = " + this.lotNumberSequential.ToString() + " WHERE fpo_codsec = " + this.codsec.ToString());
        }

        public void setConsumptionValue()
        {
            clsConnection.executeQuery("UPDATE bps_prod_filmproductionplan SET fpo_consumptionWeight = " + this.consumptionWeight.ToString() + " WHERE fpo_codsec = " + this.codsec.ToString());
        }

        public double GetAcumulator(string Date, int fkFilmProductionPlan)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spFilmProductionByDate ('" + Date.ToString() + "', " + fkFilmProductionPlan.ToString() + ")");
            return Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_netWeight"]);
        }

        public override string ToString()
        {
            return Convert.ToString(this.lotNumber);
        }

        public static void setIddleTimeInFilmProductionPlan(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(machineCodsec);
            if (lstFilmProductionPlan.Count > 0)
            {
                if (lstFilmProductionPlan[0].productionOrderStatusName == "En producción")
                {
                    clsProductionOrderDetail objProductionOrderDetail = new clsProductionOrderDetail();
                    List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilmProductionPlan(lstFilmProductionPlan[0].codsec);

                    double totalTime = 0;
                    double totalIdleTime = 0;

                    for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                        totalTime += lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours;

                    objProductionOrderDetail.load(lstFilmProductionPlan[0].fkProductionOrder);

                    TimeSpan ts = DateTime.Now.AddHours((Convert.ToDouble(lstFilmProductionPlan[0].totalWeight) - objProductionOrderDetail.FulfilledQuantity) / Convert.ToDouble(lstFilmProductionPlan[0].estimatedKilogramsPerHour)) - DateTime.Now;

                    totalIdleTime = totalTime + Math.Ceiling((ts.TotalHours / 24) * 2);

                    lstFilmProductionPlan[0].estimatedIdleTime = Convert.ToInt32(Math.Ceiling(totalIdleTime));
                    lstFilmProductionPlan[0].estimatedEndDate = lstFilmProductionPlan[0].estimatedInitDate.AddHours((lstFilmProductionPlan[0].totalWeight / lstFilmProductionPlan[0].estimatedKilogramsPerHour) + lstFilmProductionPlan[0].estimatedIdleTime);

                    lstFilmProductionPlan[0].save();


                    lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(machineCodsec);


                    for (int i = 1; i < lstFilmProductionPlan.Count; i++)
                    {
                        lstFilmProductionPlan[i].estimatedInitDate = lstFilmProductionPlan[i - 1].estimatedEndDate;
                        lstFilmProductionPlan[i].estimatedEndDate = lstFilmProductionPlan[i].estimatedInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);

                        lstFilmProductionPlan[i].save();
                    }
                }
            }
        }

        public static List<clsFilmProductionPlan> getLotNumberEfficiency()
        {
            List<clsFilmProductionPlan> lstFilmProductionPlanByLotNumeber = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFilProductionBySalesOrderDate '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,'GetLotNumberEfficiency'");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlanByLotNumeber.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlanByLotNumeber[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_codsec"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrder"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_productionOrderNumber"]);
                    lstFilmProductionPlanByLotNumeber[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkMachine"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_fkProductionOrderStatus"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpo_productionOrderStatusName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].lotNumber = DS.Tables[0].Rows[i]["fpo_lotNumber"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].MachineName = DS.Tables[0].Rows[i]["fpo_MachineName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_totalWeigth"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedInitDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_estimatedEndDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedIdleTime"]);
                    lstFilmProductionPlanByLotNumeber[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumberSequential"]);
                    lstFilmProductionPlanByLotNumeber[i].notes = DS.Tables[0].Rows[i]["fpo_notes"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].widths = DS.Tables[0].Rows[i]["fpo_widths"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_estimatedLength"]);
                    lstFilmProductionPlanByLotNumeber[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpo_variation"], DS.Tables[0].Rows[i]["fpo_variation"].GetType().FullName);
                    lstFilmProductionPlanByLotNumeber[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpo_variationDate"]);
                    lstFilmProductionPlanByLotNumeber[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpo_consumptionWeight"]);
                    lstFilmProductionPlanByLotNumeber[i].boppcode = DS.Tables[0].Rows[i]["fpo_Bopp"].ToString().ToUpper();
                }
            }

            return lstFilmProductionPlanByLotNumeber;
        }

        public static double toCheckQuality(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT COALESCE(dbo.fnGetTotalWeightByFilmProductionPlan(" + codsec.ToString() + "), 0) AS quality");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToDouble(DS.Tables[0].Rows[0]["quality"]);
            else
                return 0;
        }

        public static bool DeletePlanAndOrder(int codsecplan, int codsecorder)
        {
            bool bandera = true;
            bandera = clsConnection.executeQuery("DELETE FROM bps_prod_productionorder WHERE fpo_codsec=" + codsecplan.ToString());
            bandera = clsConnection.executeQuery("DELETE FROM bps_prod_filmproductionplan WHERE fpo_codsec=" + codsecplan.ToString());
            return bandera;
        }
        public static bool DeletePlan(int codsecplan)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_filmproductionplan WHERE fpo_codsec=" + codsecplan.ToString());
        }
    }
}
