using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMainCoilByOrder
    {
        //Atributes

        private int mcl_codsec;
        private int mcl_fkBopp;
        private string mcl_BoppCode;
        private int mcl_fkCast;
        private string mcl_CastCode;
        private int mcl_fkCoating;
        private string mcl_CoatingCode;
        private int mcl_fkFilmProductionPlan;
        private string mcl_FilmProductionPlanLotNumber;
        private double mcl_FilmProductionPlanTotalWeigth;
        private int mcl_fkMachine;
        private string mcl_MachineName;
        private double mcl_ProductionOrderQuantity;
        private int mcl_fkProductionOrder;
        private int mcl_ProductionOrderNumber;
        private string mcl_code;
        private int mcl_variation;
        private string mcl_lotNumber;
        private double mcl_grosslength;
        private double mcl_netlength;
        private double mcl_usedLength;
        private double mcl_grossWeigth;
        private double mcl_netWeigth;
        private int mcl_width;
        private double mcl_gramaje;
        private double mcl_velocity;
        private double mcl_productionKgHr;
        private string mcl_notes;
        private DateTime mcl_initDate;
        private DateTime mcl_endDate;
        private int dbfpp_codsec;
        private DateTime dbfpp_createdDate;
        private string dbfpp_decreaseName;
        private int dbfpp_fkFilmProductionPlan;
        private int fpo_lotNumber;
        private double dbfpp_weight;
        private string dbfpp_formulationName;
        private string dtbfpp_deadTimeTypeName;
        private DateTime dtbfpp_initDate;
        private DateTime dtbfpp_endDate;
       // private int dtbfpp_fkFilmProductionPlan;
 
        //Properties

        public int codsec { get { return mcl_codsec; } set { mcl_codsec = value; } }

        public int fkBopp { get { return mcl_fkBopp; } set { mcl_fkBopp = value; } }

        public string BoppCode { get { return mcl_BoppCode; } set { mcl_BoppCode = value; } }

        public int fkCast { get { return mcl_fkCast; } set { mcl_fkCast = value; } }

        public string CastCode { get { return mcl_CastCode; } set { mcl_CastCode = value; } }

        public int fkCoating { get { return mcl_fkCoating; } set { mcl_fkCoating = value; } }

        public string CoatingCode { get { return mcl_CoatingCode; } set { mcl_CoatingCode = value; } }

        public int fkFilmProductionPlan { get { return mcl_fkFilmProductionPlan; } set { mcl_fkFilmProductionPlan = value; } }

        public string FilmProductionPlanLotNumber { get { return mcl_FilmProductionPlanLotNumber; } set { mcl_FilmProductionPlanLotNumber = value; } }

        public double FilmProductionPlanTotalWeigth { get { return mcl_FilmProductionPlanTotalWeigth; } set { mcl_FilmProductionPlanTotalWeigth = value; } }

        public int fkMachine { get { return mcl_fkMachine; } set { mcl_fkMachine = value; } }

        public string MachineName { get { return mcl_MachineName; } set { mcl_MachineName = value; } }

        public double ProductionOrderQuantity { get { return mcl_ProductionOrderQuantity; } set { mcl_ProductionOrderQuantity = value; } }

        public int fkProductionOrder { get { return mcl_fkProductionOrder; } set { mcl_fkProductionOrder = value; } }

        public int ProductionOrderNumber { get { return mcl_ProductionOrderNumber; } set { mcl_ProductionOrderNumber = value; } }

        public string code { get { return mcl_code; } set { mcl_code = value; } }

        public int variation { get { return mcl_variation; } set { mcl_variation = value; } }

        public string lotNumber { get { return mcl_lotNumber; } set { mcl_lotNumber = value; } }

        public double grosslength { get { return mcl_grosslength; } set { mcl_grosslength = value; } }

        public double netlength { get { return mcl_netlength; } set { mcl_netlength = value; } }

        public double usedLength { get { return mcl_usedLength; } set { mcl_usedLength = value; } }

        public double grossWeigth { get { return mcl_grossWeigth; } set { mcl_grossWeigth = value; } }

        public double netWeigth { get { return mcl_netWeigth; } set { mcl_netWeigth = value; } }

        public int width { get { return mcl_width; } set { mcl_width = value; } }

        public double gramaje { get { return mcl_gramaje; } set { mcl_gramaje = value; } }

        public double velocity { get { return mcl_velocity; } set { mcl_velocity = value; } }

        public double productionKgHr { get { return mcl_productionKgHr; } set { mcl_productionKgHr = value; } }

        public string notes { get { return mcl_notes; } set { mcl_notes = value; } }

        public DateTime initDate { get { return mcl_initDate; } set { mcl_initDate = value; } }

        public DateTime endDate { get { return mcl_endDate; } set { mcl_endDate = value; } }

        public int DecreaseCodsec { get { return dbfpp_codsec; } set { dbfpp_codsec = value; } }

        public DateTime DecreaseCreatedDate { get { return dbfpp_createdDate; } set { dbfpp_createdDate = value; } }

        public string DecreaseName { get { return dbfpp_decreaseName; } set { dbfpp_decreaseName = value; } }

        public int DecreaseFilmProductionPlan { get { return dbfpp_fkFilmProductionPlan; } set { dbfpp_fkFilmProductionPlan = value; } }

        public int DecreaseLotNumber { get { return fpo_lotNumber; } set { fpo_lotNumber = value; } }

        public double DecreaseWeight { get { return dbfpp_weight; } set { dbfpp_weight = value; } }

        public string DecreaseFormulationName { get { return dbfpp_formulationName; } set { dbfpp_formulationName = value; } }

        public string DeadTimeName { get { return dtbfpp_deadTimeTypeName; } set { dtbfpp_deadTimeTypeName = value; } }

        public DateTime DeadTimeInitDate { get { return dtbfpp_initDate; } set { dtbfpp_initDate = value; } }

        public DateTime DeadTimeEndDate { get { return dtbfpp_endDate; } set { dtbfpp_endDate = value; } }

       // public int DeadTimeFimlProductionPlan { get { return dtbfpp_fkFilmProductionPlan; } set { dtbfpp_fkFilmProductionPlan = value; } }
        
        //Constructor

        public clsMainCoilByOrder()
        {
            mcl_codsec = 0;
            mcl_fkBopp = 0;
            mcl_BoppCode = "";
            mcl_fkCast = 0;
            mcl_CastCode = "";
            mcl_fkCoating = 0;
            mcl_CoatingCode = "";
            mcl_fkFilmProductionPlan = 0;
            mcl_FilmProductionPlanLotNumber = "";
            mcl_FilmProductionPlanTotalWeigth = 0;
            mcl_fkMachine = 0;
            mcl_MachineName = "";
            mcl_ProductionOrderQuantity = 0;
            mcl_fkProductionOrder = 0;
            mcl_ProductionOrderNumber = 0;
            mcl_code = "";
            mcl_variation = 0;
            mcl_lotNumber = "";
            mcl_grosslength = 0;
            mcl_netlength = 0;
            mcl_usedLength = 0;
            mcl_grossWeigth = 0;
            mcl_netWeigth = 0;
            mcl_width = 0;
            mcl_gramaje = 0;
            mcl_velocity = 0;
            mcl_productionKgHr = 0;
            mcl_notes = "";
            mcl_initDate = DateTime.Now;
            mcl_endDate = DateTime.Now;
            dbfpp_codsec = 0;
            dbfpp_createdDate = DateTime.Now;
            dbfpp_decreaseName = "";
            dbfpp_fkFilmProductionPlan = 0;
            fpo_lotNumber = 0;
            dbfpp_weight = 0;
            dbfpp_formulationName = "";
            dtbfpp_deadTimeTypeName = "";
        //dtbfpp_fkFilmProductionPlan = 0;
            
        }

        public clsMainCoilByOrder(int mainCoilCodsec)
        {
            this.load(mainCoilCodsec);
        }

        //Methods

        public void load(int mainCoilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil WHERE mcl_codsec = " + mainCoilCodsec.ToString() + " group by mcl_codsec order by mcl_code asc");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);                
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkBopp"]);
                this.BoppCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCast"]);
                this.CastCode = DS.Tables[0].Rows[0]["mcl_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCoating"]);
                this.CoatingCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                //this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkStatus"]);
                //this.StatusName = DS.Tables[0].Rows[0]["mcl_StatusName"].ToString();
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkFilmProductionPlan"]);
                this.FilmProductionPlanLotNumber = DS.Tables[0].Rows[0]["mcl_FilmProductionPlanLotNumber"].ToString();
                this.FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_FilmProductionPlanTotalWeigth"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["mcl_MachineName"].ToString();
                this.ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_ProductionOrderQuantity"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkProductionOrder"]);
                this.ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_ProductionOrderNumber"]);
                this.code = DS.Tables[0].Rows[0]["mcl_code"].ToString();
                this.variation = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_variation"]);
                this.lotNumber = DS.Tables[0].Rows[0]["mcl_lotNumber"].ToString();
                this.grosslength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_grosslength"]);
                this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_netlength"]);
                this.usedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_usedLength"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_grossWeigth"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_netWeigth"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_width"]);
                this.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_gramaje"]);
                this.velocity = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_velocity"]);
                this.productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_productionKgHr"]);
                this.notes = DS.Tables[0].Rows[0]["mcl_notes"].ToString();
                this.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_initDate"]);
                this.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_endDate"]);
                //this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_createdDate"]);
                //this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_modifiedDate"]);
                //this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_createdBy"]);
                //this.creatorUser = DS.Tables[0].Rows[0]["mcl_creatorUser"].ToString();
                //this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_modifiedBy"]);
                //this.modificatorUser = DS.Tables[0].Rows[0]["mcl_modificatorUser"].ToString();
                //this.analistRating = DS.Tables[0].Rows[0]["mcl_analistRating"].ToString();
                //this.labRating = DS.Tables[0].Rows[0]["mcl_labRating"].ToString();
                //this.supervisor = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_supervisor"]);
                //this.supervisorName = DS.Tables[0].Rows[0]["mcl_supervisorName"].ToString();
                //this.Operator = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_Operator"]);
                //this.operatorName = DS.Tables[0].Rows[0]["mcl_operatorName"].ToString();
                //this.coiler = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_coiler"]);
                //this.coilerName = DS.Tables[0].Rows[0]["mcl_coilerName"].ToString();
                
            }
        }
        public void load(string mainCoilCode)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil WHERE mcl_code = '" + mainCoilCode.ToString() + "' group by mcl_codsec order by mcl_code asc");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkBopp"]);
                this.BoppCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCast"]);
                this.CastCode = DS.Tables[0].Rows[0]["mcl_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCoating"]);
                this.CoatingCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                //this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkStatus"]);
                //this.StatusName = DS.Tables[0].Rows[0]["mcl_StatusName"].ToString();
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkFilmProductionPlan"]);
                this.FilmProductionPlanLotNumber = DS.Tables[0].Rows[0]["mcl_FilmProductionPlanLotNumber"].ToString();
                this.FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_FilmProductionPlanTotalWeigth"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["mcl_MachineName"].ToString();
                this.ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_ProductionOrderQuantity"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkProductionOrder"]);
                this.ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_ProductionOrderNumber"]);
                this.code = DS.Tables[0].Rows[0]["mcl_code"].ToString();
                this.variation = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_variation"]);
                this.lotNumber = DS.Tables[0].Rows[0]["mcl_lotNumber"].ToString();
                this.grosslength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_grosslength"]);
                this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_netlength"]);
                this.usedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_usedLength"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_grossWeigth"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_netWeigth"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_width"]);
                this.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_gramaje"]);
                this.velocity = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_velocity"]);
                this.productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_productionKgHr"]);
                this.notes = DS.Tables[0].Rows[0]["mcl_notes"].ToString();
                this.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_initDate"]);
                this.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_endDate"]);
                //this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_createdDate"]);
                //this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_modifiedDate"]);
                //this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_createdBy"]);
                //this.creatorUser = DS.Tables[0].Rows[0]["mcl_creatorUser"].ToString();
                //this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_modifiedBy"]);
                //this.modificatorUser = DS.Tables[0].Rows[0]["mcl_modificatorUser"].ToString();
                //this.analistRating = DS.Tables[0].Rows[0]["mcl_analistRating"].ToString();
                //this.labRating = DS.Tables[0].Rows[0]["mcl_labRating"].ToString();
                //this.supervisor = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_supervisor"]);
                //this.supervisorName = DS.Tables[0].Rows[0]["mcl_supervisorName"].ToString();
                //this.Operator = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_Operator"]);
                //this.operatorName = DS.Tables[0].Rows[0]["mcl_operatorName"].ToString();
                //this.coiler = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_coiler"]);
                //this.coilerName = DS.Tables[0].Rows[0]["mcl_coilerName"].ToString();
            }
        }
        //public bool save()
        //{
        //    try
        //    {
        //        string filmType = "",queryString = "" ;

        //        if (this.fkBopp != 0)
        //            filmType = "Bopp";
        //        else if (this.fkCast != 0)
        //            filmType = "Cast";
        //        else if (this.fkCoating != 0)
        //            filmType = "Coating";

        //        if (this.codsec == 0)
        //        {
        //            switch (filmType)
        //            {
        //                case "Bopp":
        //                    queryString += "INSERT INTO bps_prod_maincoil (mcl_fkBopp, mcl_fkStatus, mcl_fkFilmProductionPlan, mcl_code, mcl_variation, mcl_lotNumber, mcl_grosslength, mcl_netlength, mcl_grossWeight, mcl_netWeight, mcl_width, mcl_gramaje, mcl_velocity, mcl_productionKgHr, mcl_notes, mcl_initDate, mcl_endDate, mcl_createdDate, mcl_modifiedDate, mcl_createdBy, mcl_modifiedBy, mcl_supervisor, mcl_operator, mcl_coiler, mcl_analistRating, mcl_labRating)";
        //                    queryString += " VALUES (";
        //                    queryString += "" + this.fkBopp.ToString() + ",";
        //                    //queryString += "" + this.fkStatus.ToString() + ",";
        //                    queryString += "" + this.fkFilmProductionPlan.ToString() + ",";
        //                    queryString += "'" + this.code.ToString() + "',";
        //                    queryString += "" + this.variation.ToString() + ",";
        //                    queryString += "'" + this.lotNumber.ToString() + "',";
        //                    queryString += "" + this.grosslength.ToString() + ",";
        //                    queryString += "" + this.netlength.ToString() + ",";
        //                    queryString += "" + this.grossWeigth.ToString() + ",";
        //                    queryString += "" + this.netWeigth.ToString() + ",";
        //                    queryString += "" + this.width.ToString() + ",";
        //                    queryString += "" + this.gramaje.ToString() + ",";
        //                    queryString += "" + this.velocity.ToString() + ",";
        //                    queryString += "" + this.productionKgHr.ToString() + ",";
        //                    queryString += "'" + this.notes.ToString() + "',";
        //                    queryString += "'" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
        //                    queryString += "'" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
        //                    queryString += "NOW(),";
        //                    queryString += "NOW(),";
        //                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
        //                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
        //                    //queryString += "" + this.supervisor.ToString() + ",";
        //                    //queryString += "" + this.Operator.ToString() + ",";
        //                    //queryString += "" + this.coiler.ToString() + ",";
        //                    //queryString += "'" + this.analistRating.ToString() + "',";
        //                    //queryString += "'" + this.labRating.ToString() + "'";
        //                    queryString += ");";
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            switch (filmType)
        //            {
        //                case "Bopp":
        //                    queryString += "UPDATE bps_prod_maincoil";
        //                    queryString += " SET ";
        //                    queryString += " mcl_fkBopp = " + this.fkBopp.ToString() + ",";
        //                    //queryString += " mcl_fkStatus = " + this.fkStatus.ToString() + ",";
        //                    queryString += " mcl_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
        //                    queryString += " mcl_code = '" + this.code.ToString() + "',";
        //                    queryString += " mcl_variation = " + this.variation.ToString() + ",";
        //                    queryString += " mcl_lotNumber = '" + this.lotNumber.ToString() + "',";
        //                    queryString += " mcl_grosslength = " + this.grosslength.ToString() + ",";
        //                    queryString += " mcl_netlength = " + this.netlength.ToString() + ",";
        //                    queryString += " mcl_grossWeight = " + this.grossWeigth.ToString() + ",";
        //                    queryString += " mcl_netWeight = " + this.netWeigth.ToString() + ",";
        //                    queryString += " mcl_width = " + this.width.ToString() + ",";
        //                    queryString += " mcl_gramaje = " + this.gramaje.ToString() + ",";
        //                    queryString += " mcl_velocity = " + this.velocity.ToString() + ",";
        //                    queryString += " mcl_productionKgHr = " + this.productionKgHr.ToString() + ",";
        //                    queryString += " mcl_notes = '" + this.notes.ToString() + "',";
        //                    queryString += " mcl_initDate = '" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
        //                    queryString += " mcl_endDate = '" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
        //                    queryString += " mcl_createdDate = NOW(),";
        //                    queryString += " mcl_modifiedDate = NOW(),";
        //                    queryString += " mcl_createdBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
        //                    queryString += " mcl_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
        //                    //queryString += " mcl_analistRating = '" + this.analistRating.ToString() + "',";
        //                    //queryString += " mcl_labRating = '" + this.labRating.ToString() + "'";
        //                    queryString += " WHERE mcl_codsec = " + this.codsec.ToString();
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        clsConnection.executeQuery(queryString);

        //        if (this.codsec == 0)
        //          //  this.codsec = clsMainCoilByOrder.getLastSavedCodsec();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        clsLog.addLog(ex, 3, "clsMainCoilByOrder.save");
        //        return false;
        //    }
        //}

        public static List<clsMainCoilByOrder> getList()
        {
            List<clsMainCoilByOrder> lstMainCoil = new List<clsMainCoilByOrder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoilByOrder());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_BoppCode"].ToString();
                lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                lstMainCoil[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCoating"]);
                lstMainCoil[i].CoatingCode = DS.Tables[0].Rows[i]["mcl_BoppCode"].ToString();
                //lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                //lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
                lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkFilmProductionPlan"]);
                lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mcl_FilmProductionPlanLotNumber"].ToString();
                lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_FilmProductionPlanTotalWeigth"]);
                lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkMachine"]);
                lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mcl_MachineName"].ToString();
                lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_ProductionOrderQuantity"]);
                lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkProductionOrder"]);
                lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_ProductionOrderNumber"]);
                lstMainCoil[i].code = DS.Tables[0].Rows[i]["mcl_code"].ToString();
                lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_variation"]);
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mcl_lotNumber"].ToString();
                lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grosslength"]);
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netlength"]);
                lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_usedLength"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grossWeigth"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netWeigth"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_width"]);
                lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_gramaje"]);
                lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_velocity"]);
                lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_productionKgHr"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mcl_notes"].ToString();
                lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_initDate"]);
                lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_endDate"]);
                //lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                //lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                //lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                //lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                //lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                //lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                //lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                //lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                //lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                //lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                //lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                //lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                //lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                //lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
            }

            return lstMainCoil;
        }

        public static List<clsMainCoilByOrder> getBoppMainCoilListByFilter(List<clsFilter> lstFilter)
        {
            List<clsMainCoilByOrder> lstMainCoil = new List<clsMainCoilByOrder>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilbyfilmproductionplan " + where + "  order by mcl_initDate ASC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoilByOrder());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mcl_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mcl_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mcl_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mcl_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netlength"]);
                    //lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mcl_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_endDate"]);
                    lstMainCoil[i].DecreaseCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_codsec"]);
                    lstMainCoil[i].DecreaseCreatedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dbfpp_createdDate"]);
                    lstMainCoil[i].DecreaseName = DS.Tables[0].Rows[i]["dbfpp_decreaseName"].ToString();
                    lstMainCoil[i].DecreaseFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dbfpp_fkFilmProductionPlan"]);
                    lstMainCoil[i].DecreaseLotNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["fpo_lotNumber"]);
                    lstMainCoil[i].DecreaseWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["dbfpp_weight"]);
                    lstMainCoil[i].DecreaseFormulationName = DS.Tables[0].Rows[i]["dbfpp_formulationName"].ToString();
                    lstMainCoil[i].DeadTimeName = DS.Tables[0].Rows[i]["dtbfpp_deadTimeTypeName"].ToString();
                    lstMainCoil[i].DeadTimeInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstMainCoil[i].DeadTimeEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);

                    //lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    //lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    //lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    //lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    //lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    //lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();

                }
            }
            return lstMainCoil;
        }

        public override string ToString()
        {
            return this.lotNumber;
        }
    }
}
