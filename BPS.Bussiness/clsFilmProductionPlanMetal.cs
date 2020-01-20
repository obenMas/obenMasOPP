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
    public class clsFilmProductionPlanMetal
    {
        //Atributes

        private int fpom_codsec;
        private int fpom_fkProductionOrder;
        private clsProductionOrderMetal fpom_productionOrderMetal;
        private int fpom_fkMachine;
        private string fpom_MachineName;
        private int fpom_fkBaseFilm;
        private int fpom_productionOrderNumber;
        private int fpom_fkProductionOrderStatus;
        private string fpom_productionOrderStatusName;
        private string fpom_lotNumber;
        private double fpom_totalWeight;
        private DateTime fpom_estimatedInitDate;
        private DateTime fpom_estimatedEndDate;
        private int fpom_estimatedKilogramsPerHour;
        private int fpom_estimatedIdleTime;
        private int fpom_lotNumberSequential;
        private string fpom_notes;
        private string fpom_widths;
        private int fpom_estimatedLength;
        private string fpom_companyName;
        private string bopp_Code;
        private string cast_Code;
        private string coating_Code;
        private double sum_acount;
        private bool fpom_variation;
        private DateTime fpom_variationDate;
        private double fpom_consumptionWeight;
        private int fpom_ordenation;
        private string fpom_widthFrom;
        private string fpom_widthTo;
        private int fpom_coilsnumber;
        private double fpom_density;

        //Properties

        public int codsec { get { return fpom_codsec; } set { fpom_codsec = value; } }

        public int fkProductionOrder { get { return fpom_fkProductionOrder; } set { fpom_fkProductionOrder = value; } }

        public clsProductionOrderMetal productionOrderMetal { get { return fpom_productionOrderMetal; } set { fpom_productionOrderMetal = value; } }

        public int fkMachine { get { return fpom_fkMachine; } set { fpom_fkMachine = value; } }

        public string MachineName { get { return fpom_MachineName; } set { fpom_MachineName = value; } }

        public int fkBaseFilm { get { return fpom_fkBaseFilm; } set { fpom_fkBaseFilm = value; } }

        public int productionOrderNumber { get { return fpom_productionOrderNumber; } set { fpom_productionOrderNumber = value; } }

        public int fkProductionOrderStatus { get { return fpom_fkProductionOrderStatus; } set { fpom_fkProductionOrderStatus = value; } }

        public string productionOrderStatusName { get { return fpom_productionOrderStatusName; } set { fpom_productionOrderStatusName = value; } }

        public string lotNumber { get { return fpom_lotNumber; } set { fpom_lotNumber = value; } }

        public double totalWeight { get { return fpom_totalWeight; } set { fpom_totalWeight = value; } }

        public DateTime estimatedInitDate { get { return fpom_estimatedInitDate; } set { fpom_estimatedInitDate = value; } }

        public DateTime estimatedEndDate { get { return fpom_estimatedEndDate; } set { fpom_estimatedEndDate = value; } }

        public int estimatedKilogramsPerHour { get { return fpom_estimatedKilogramsPerHour; } set { fpom_estimatedKilogramsPerHour = value; } }

        public int estimatedIdleTime { get { return fpom_estimatedIdleTime; } set { fpom_estimatedIdleTime = value; } }

        public int lotNumberSequential { get { return fpom_lotNumberSequential; } set { fpom_lotNumberSequential = value; } }

        public string notes { get { return fpom_notes; } set { fpom_notes = value; } }

        public string widths { get { return fpom_widths; } set { fpom_widths = value; } }

        public int estimatedLength { get { return fpom_estimatedLength; } set { fpom_estimatedLength = value; } }

        public string companyName { get { return fpom_companyName; } set { fpom_companyName = value; } }

        public string boppcode { get { return bopp_Code; } set { bopp_Code = value; } }

        public string castcode { get { return cast_Code; } set { cast_Code = value; } }

        public string coatingcode { get { return coating_Code; } set { coating_Code = value; } }

        public double acount { get { return sum_acount; } set { sum_acount = value; } }

        public bool variation { get { return fpom_variation; } set { fpom_variation = value; } }

        public DateTime variationDate { get { return fpom_variationDate; } set { fpom_variationDate = value; } }

        public double consumptionWeight { get { return fpom_consumptionWeight; } set { fpom_consumptionWeight = value; } }

        public int ordenation { get { return fpom_ordenation; } set { fpom_ordenation = value; } }

        public string widthFrom { get { return fpom_widthFrom; } set { fpom_widthFrom = value; } }

        public string widthTo { get { return fpom_widthTo; } set { fpom_widthTo = value; } }

        public int coilsnumber { get { return fpom_coilsnumber; } set { fpom_coilsnumber = value; } }

        public double density { get { return fpom_density; } set { fpom_density = value; } }


        //Constructor

        public clsFilmProductionPlanMetal()
        {
            fpom_codsec = 0;
            fpom_fkProductionOrder = 0;
            fpom_productionOrderMetal = new clsProductionOrderMetal();
            fpom_productionOrderNumber = 0;
            fpom_productionOrderStatusName = "";
            fpom_fkProductionOrderStatus = 0;
            fpom_lotNumber = "";
            fpom_fkMachine = 0;
            fpom_MachineName = "";
            fpom_fkBaseFilm = 0;
            fpom_totalWeight = 0;
            fpom_estimatedInitDate = DateTime.Now;
            fpom_estimatedEndDate = DateTime.Now;
            fpom_estimatedKilogramsPerHour = 0;
            fpom_estimatedIdleTime = 0;
            fpom_lotNumberSequential = 0;
            fpom_notes = "";
            fpom_widths = "";
            fpom_estimatedLength = 0;
            fpom_companyName = "";
            sum_acount = 0;
            fpom_variation = false;
            fpom_variationDate = DateTime.Now;
            fpom_consumptionWeight = 0;
            fpom_ordenation = 0;
            fpom_widthFrom = "";
            fpom_widthTo = "";
            fpom_coilsnumber = 0;
            fpom_density = 0;
        }

        public clsFilmProductionPlanMetal(int filmProductionPlanCodsec)
        {
            this.load(filmProductionPlanCodsec);
        }

        public clsFilmProductionPlanMetal(int filmProductionPlanCodsec, bool simplified)
        {
            this.loadSimplified(filmProductionPlanCodsec);
        }
        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_filmproductionplanmetal WHERE fpom_fkProductionOrder = " + codsec.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrder"]);
                this.productionOrderMetal = new clsProductionOrderMetal(this.fkProductionOrder);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["fpom_density"]);
                //this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_productionOrderNumber"]);
                //this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrderStatus"]);
                //this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpom_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpom_lotNumber"].ToString();
                //this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkMachine"]);
                //this.MachineName = DS.Tables[0].Rows[0]["fpom_MachineName"].ToString();
                //this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_totalWeigth"]);
                //this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedInitDate"]);
                //this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedEndDate"]);
                //this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedKilogramsPerHour"]);
                //this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedIdleTime"]);
                //this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpom_notes"].ToString();
                //this.widths = DS.Tables[0].Rows[0]["fpom_widths"].ToString();
                //this.coilsnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_coilsnumber"]);
                //this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpom_variation"], DS.Tables[0].Rows[0]["fpom_variation"].GetType().FullName);
                //this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_variationDate"]);
                //this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpom_consumptionWeight"]);
            }
        }

        public void loadSimplified(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFilmProductionPlanByCodsec (" + codsec.ToString() + ")");

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrder"]);
                this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_productionOrderNumber"]);
                this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrderStatus"]);
                this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpom_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpom_lotNumber"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["fpom_MachineName"].ToString();
                this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_totalWeigth"]);
                this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedInitDate"]);
                this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedEndDate"]);
                this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedKilogramsPerHour"]);
                this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedIdleTime"]);
                this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpom_notes"].ToString();
                this.widths = DS.Tables[0].Rows[0]["fpom_widths"].ToString();
                this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedLength"]);
                this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpom_variation"], DS.Tables[0].Rows[0]["fpom_variation"].GetType().FullName);
                this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_variationDate"]);
                this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpom_consumptionWeight"]);
            }
        }

        public static clsFilmProductionPlan getFilmProductionPlanByProductionOrder(int ProductionOrdercodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkProductionOrder = " + ProductionOrdercodsec.ToString());

            clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();

            if (DS.Tables.Count > 0)
            {
                objFilmProductionPlan.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
                objFilmProductionPlan.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrder"]);
                objFilmProductionPlan.productionOrder = new clsProductionOrder(objFilmProductionPlan.fkProductionOrder);
                objFilmProductionPlan.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_productionOrderNumber"]);
                objFilmProductionPlan.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrderStatus"]);
                objFilmProductionPlan.productionOrderStatusName = DS.Tables[0].Rows[0]["fpom_productionOrderStatusName"].ToString();
                objFilmProductionPlan.lotNumber = DS.Tables[0].Rows[0]["fpom_lotNumber"].ToString();
                objFilmProductionPlan.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkMachine"]);
                objFilmProductionPlan.MachineName = DS.Tables[0].Rows[0]["fpom_MachineName"].ToString();
                objFilmProductionPlan.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_totalWeigth"]);
                objFilmProductionPlan.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedInitDate"]);
                objFilmProductionPlan.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedEndDate"]);
                objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedKilogramsPerHour"]);
                objFilmProductionPlan.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedIdleTime"]);
                objFilmProductionPlan.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]);
                objFilmProductionPlan.notes = DS.Tables[0].Rows[0]["fpom_notes"].ToString();
                objFilmProductionPlan.widths = DS.Tables[0].Rows[0]["fpom_widths"].ToString();
                objFilmProductionPlan.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedLength"]);
                objFilmProductionPlan.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpom_variation"], DS.Tables[0].Rows[0]["fpom_variation"].GetType().FullName);
                objFilmProductionPlan.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_variationDate"]);
                objFilmProductionPlan.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpom_consumptionWeight"]);
            }
            return objFilmProductionPlan;
        }

        public void loadFilmProductionPlanByProductionOrder(int productionOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkProductionOrder = " + productionOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrder"]);
                //this.productionOrder.load(this.fkProductionOrder);
                this.productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_productionOrderNumber"]);
                this.fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkProductionOrderStatus"]);
                this.productionOrderStatusName = DS.Tables[0].Rows[0]["fpom_productionOrderStatusName"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["fpom_lotNumber"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["fpom_MachineName"].ToString();
                this.totalWeight = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_totalWeigth"]);
                this.estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedInitDate"]);
                this.estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedEndDate"]);
                this.estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedKilogramsPerHour"]);
                this.estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedIdleTime"]);
                this.lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]);
                this.notes = DS.Tables[0].Rows[0]["fpom_notes"].ToString();
                this.widths = DS.Tables[0].Rows[0]["fpom_widths"].ToString();
                this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedLength"]);
                this.variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpom_variation"], DS.Tables[0].Rows[0]["fpom_variation"].GetType().FullName);
                this.variationDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_variationDate"]);
                this.consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["fpom_consumptionWeight"]);
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
                    queryString += "INSERT INTO bps_prod_filmproductionplanmetal (fpom_fkProductionOrder, fpom_fkMachine, fpom_lotNumber, fpom_widthFrom, fpom_widthTo, fpom_estimatedInitDate, fpom_estimatedEndDate, fpom_estimatedKilogramsPerHour, fpom_coilsnumber, fpom_density, fpom_notes, fpom_variationDate, fpom_variation, fpom_ordenation) ";
                    queryString += " VALUES (";
                    queryString += " " + this.fkProductionOrder.ToString() + ",";
                    queryString += " " + this.fkMachine.ToString() + ",";
                    queryString += " '" + this.lotNumber.ToString() + "',";
                    queryString += " '" + this.widthFrom.ToString() + "',";
                    queryString += " '" + this.widthTo.ToString() + "',";
                    queryString += " '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " " + this.estimatedKilogramsPerHour.ToString() + ",";
                    queryString += " " + this.coilsnumber.ToString() + ",";
                    queryString += " " + this.density.ToString() + ",";
                    queryString += " '" + this.notes + "',";
                    queryString += " '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " " + "0" + ", ";
                    queryString += " 0";
                    queryString += ");";
                }
                else
                {
                    if (registerVariation)
                    {
                        queryString += "UPDATE bps_prod_filmproductionplanmetal";
                        queryString += " SET ";
                        queryString += " fpom_fkProductionOrder = " + this.fkProductionOrder.ToString() + ",";
                        queryString += " fpom_fkMachine = " + this.fkMachine.ToString() + ",";
                        queryString += " fpom_lotNumber = '" + this.lotNumber.ToString() + "',";
                        queryString += " fpom_totalWeigth = " + this.totalWeight.ToString() + ",";
                        queryString += " fpom_estimatedInitDate = '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpom_estimatedEndDate = '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpom_estimatedKilogramsPerHour = " + this.estimatedKilogramsPerHour.ToString() + ", ";
                        queryString += " fpom_estimatedIdleTime = " + this.estimatedIdleTime.ToString() + ", ";
                        queryString += " fpom_lotNumberSequential = " + this.lotNumberSequential.ToString() + ", ";
                        queryString += " fpom_notes = '" + this.notes.ToString() + "',";
                        queryString += " fpom_widths = '" + this.widths + "',";
                        queryString += " fpom_estimatedLength = " + this.estimatedLength.ToString() + ", ";
                        queryString += " fpom_variation = 1, ";
                        queryString += " fpom_variationDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
                        queryString += " WHERE fpom_codsec = " + this.codsec.ToString() + ";";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_filmproductionplanmetal";
                        queryString += " SET ";
                        queryString += " fpom_fkProductionOrder = " + this.fkProductionOrder.ToString() + ",";
                        queryString += " fpom_fkMachine = " + this.fkMachine.ToString() + ",";
                        queryString += " fpom_lotNumber = '" + this.lotNumber.ToString() + "',";
                        queryString += " fpom_totalWeigth = " + this.totalWeight.ToString() + ",";
                        queryString += " fpom_estimatedInitDate = '" + this.estimatedInitDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpom_estimatedEndDate = '" + this.estimatedEndDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                        queryString += " fpom_estimatedKilogramsPerHour = " + this.estimatedKilogramsPerHour.ToString() + ", ";
                        queryString += " fpom_estimatedIdleTime = " + this.estimatedIdleTime.ToString() + ", ";
                        queryString += " fpom_lotNumberSequential = " + this.lotNumberSequential.ToString() + ", ";
                        queryString += " fpom_notes = '" + this.notes.ToString() + "',";
                        queryString += " fpom_widths = '" + this.widths + "',";
                        queryString += " fpom_estimatedLength = " + this.estimatedLength.ToString() + " ";
                        queryString += " WHERE fpom_codsec = " + this.codsec.ToString() + ";";
                    }
                }

                if (clsConnection.executeQuery(queryString))
                {
                    //clsSequential.addSequential("metallizedOrder");
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFilmProductionPlan.save");
                return false;
            }
        }

        public bool ChangeLotNumber()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_filmproductionplanmetal";
                queryString += " SET ";
                queryString += " fpom_lotNumber = '" + this.lotNumber.ToString() + "',";
                queryString += " fpom_coilsnumber = " + this.coilsnumber.ToString() + ",";
                queryString += " fpom_notes = '" + this.notes.ToString() + "',";
                queryString += " fpom_variation = 1, ";
                queryString += " fpom_variationDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
                queryString += " WHERE fpom_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFilmProductionPlan.save");
                return false;
            }
        }


        public bool save(string pos, int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_filmproductionplanmetal";
                queryString += " SET ";
                queryString += " fpom_ordenation = " + this.ordenation.ToString() + " ";
                queryString += " WHERE fpom_codsec = " + codsec.ToString() + ";";
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

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
                }
            }

            return lstFilmProductionPlan;
        }

        public static List<clsFilmProductionPlan> getListByLotNumeber()
        {
            List<clsFilmProductionPlan> lstFilmProductionPlanByLotNumeber = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan where fpom_lotNumber != 0");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlanByLotNumeber.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlanByLotNumeber[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlanByLotNumeber[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlanByLotNumeber[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlanByLotNumeber[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlanByLotNumeber[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlanByLotNumeber[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlanByLotNumeber[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlanByLotNumeber[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlanByLotNumeber[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlanByLotNumeber[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlanByLotNumeber[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
                }
            }

            return lstFilmProductionPlanByLotNumeber;
        }

        public static List<clsFilmProductionPlan> getListByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkMachine = " + machineCodsec.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
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
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlan[i].boppcode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstFilmProductionPlan[i].castcode = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                    lstFilmProductionPlan[i].coatingcode = DS.Tables[0].Rows[i]["coat_code"].ToString();
                    lstFilmProductionPlan[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
                }
            }
            return lstFilmProductionPlan;
        }
        public static List<clsFilmProductionPlan> getActiveListByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkMachine = " + machineCodsec.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString() != "Cerrada" && DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString() != "Anulada")
                    {
                        lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrder.load(lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrder);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                        lstFilmProductionPlan[lstFilmProductionPlan.Count - 1].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
                    }
                }
            }
            return lstFilmProductionPlan;
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
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_machine"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].boppcode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                    lstFilmProductionPlan[i].ordenation = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_ordenation"]);
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

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFilmProductionPlan " + where + "  order by fpom_lotNumber DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                }
            }
            return lstFilmProductionPlan;
        }


        public static List<clsFilmProductionPlan> getListOfActiveItemsByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkMachine = " + machineCodsec.ToString() + " and (fpom_productionOrderStatusName = 'Planificada' or fpom_productionOrderStatusName = 'En Producción') ");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
                }
            }
            return lstFilmProductionPlan;
        }
        public static void recalculateActiveItemsByMachine(int machineCodsec)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from vwFilmProductionPlan WHERE fpom_fkMachine = " + machineCodsec.ToString() + " and (fpom_productionOrderStatusName = 'Planificada' or fpom_productionOrderStatusName = 'En Producción') ");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlan.Add(new clsFilmProductionPlan());
                    lstFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                    lstFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrder"]);
                    lstFilmProductionPlan[i].productionOrder.load(lstFilmProductionPlan[i].fkProductionOrder);
                    lstFilmProductionPlan[i].productionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_productionOrderNumber"]);
                    lstFilmProductionPlan[i].fkProductionOrderStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkProductionOrderStatus"]);
                    lstFilmProductionPlan[i].productionOrderStatusName = DS.Tables[0].Rows[i]["fpom_productionOrderStatusName"].ToString();
                    lstFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstFilmProductionPlan[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_fkMachine"]);
                    lstFilmProductionPlan[i].MachineName = DS.Tables[0].Rows[i]["fpom_MachineName"].ToString();
                    lstFilmProductionPlan[i].totalWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_totalWeigth"]);
                    lstFilmProductionPlan[i].estimatedInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstFilmProductionPlan[i].estimatedEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                    lstFilmProductionPlan[i].estimatedKilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstFilmProductionPlan[i].estimatedIdleTime = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedIdleTime"]);
                    lstFilmProductionPlan[i].lotNumberSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_lotNumberSequential"]);
                    lstFilmProductionPlan[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstFilmProductionPlan[i].widths = DS.Tables[0].Rows[i]["fpom_widths"].ToString();
                    lstFilmProductionPlan[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedLength"]);
                    lstFilmProductionPlan[i].variation = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpom_variation"], DS.Tables[0].Rows[i]["fpom_variation"].GetType().FullName);
                    lstFilmProductionPlan[i].variationDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_variationDate"]);
                    lstFilmProductionPlan[i].consumptionWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_consumptionWeight"]);
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

            DS = clsConnection.getDataSetResult("SELECT fpom_codsec FROM vwFilmProductionPlan Order By fpom_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
        }
        public static int getNextLotNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT fpom_lotNumberSequential FROM vwFilmProductionPlan Order By fpom_lotNumber DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]) + 1;
        }

        public static int getNextLotNumberByMachine(int mchCodsec)
        {
            int lotnumber = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT fpom_lotNumberSequential FROM bps_prod_filmproductionplan WHERE fpom_fkMachine = " + mchCodsec.ToString() + " AND fpom_lotNumberSequential <> 0 ORDER BY fpom_estimatedInitDate DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                lotnumber = ((Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"])) + 1);
                if (lotnumber != Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]))
                    return lotnumber;
                else
                {
                    if (lotnumber == Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_lotNumberSequential"]))
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
            clsConnection.executeQuery("UPDATE bps_prod_filmproductionplan SET fpom_lotNumberSequential = " + this.lotNumberSequential.ToString() + " WHERE fpom_codsec = " + this.codsec.ToString());
        }
        public void setConsumptionValue()
        {
            clsConnection.executeQuery("UPDATE bps_prod_filmproductionplan SET fpom_consumptionWeight = " + this.consumptionWeight.ToString() + " WHERE fpom_codsec = " + this.codsec.ToString());
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
    }
}
