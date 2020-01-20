using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las bobinas Madres
    /// </summary>
    public class clsMainCoil
    {
        //Atributes

        private int mcl_codsec;
        private int mcl_fkBopp;
        private string mcl_BoppCode;
        private int mcl_fkCast;
        private string mcl_CastCode;
        private int mcl_fkCoating;
        private string mcl_CoatingCode;
        private int mcl_fkStatus;
        private string mcl_StatusName;
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
        private DateTime mcl_createdDate;
        private DateTime mcl_modifiedDate;
        private int mcl_createdBy;
        private string mcl_creatorUser;
        private int mcl_modifiedBy;
        private string mcl_modificatorUser;
        private string mcl_AnalistRating;
        private string mcl_labRating;
        private int mcl_supervisor;
        private string mcl_supervisorName;
        private int mcl_operator;
        private string mcl_operatorName;
        private int mcl_coiler;
        private string mcl_coilerName;
        private string mcl_hours;
        private double mcl_accumulated;
        private bool mcl_calculateWeight;
        private double mcl_coftf;
        private double mcl_cofntf;
        private double mcl_thikness;
        private string mcl_surfacetension;
        private int mcl_core;


        //Properties

        public int codsec { get { return mcl_codsec; } set { mcl_codsec = value; } }

        public int fkBopp { get { return mcl_fkBopp; } set { mcl_fkBopp = value; } }

        public string BoppCode { get { return mcl_BoppCode; } set { mcl_BoppCode = value; } }

        public int fkCast { get { return mcl_fkCast; } set { mcl_fkCast = value; } }

        public string CastCode { get { return mcl_CastCode; } set { mcl_CastCode = value; } }

        public int fkCoating { get { return mcl_fkCoating; } set { mcl_fkCoating = value; } }

        public string CoatingCode { get { return mcl_CoatingCode; } set { mcl_CoatingCode = value; } }

        public int fkStatus { get { return mcl_fkStatus; } set { mcl_fkStatus = value; } }

        public string StatusName { get { return mcl_StatusName; } set { mcl_StatusName = value; } }

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

        public DateTime createdDate { get { return mcl_createdDate; } set { mcl_createdDate = value; } }

        public DateTime modifiedDate { get { return mcl_modifiedDate; } set { mcl_modifiedDate = value; } }

        public int createdBy { get { return mcl_createdBy; } set { mcl_createdBy = value; } }

        public string creatorUser { get { return mcl_creatorUser; } set { mcl_creatorUser = value; } }

        public int modifiedBy { get { return mcl_modifiedBy; } set { mcl_modifiedBy = value; } }

        public string modificatorUser { get { return mcl_modificatorUser; } set { mcl_modificatorUser = value; } }

        public string analistRating { get { return mcl_AnalistRating; } set { mcl_AnalistRating = value; } }

        public string labRating { get { return mcl_labRating; } set { mcl_labRating = value; } }

        public int supervisor { get { return mcl_supervisor; } set { mcl_supervisor = value; } }

        public string supervisorName { get { return mcl_supervisorName; } set { mcl_supervisorName = value; } }

        public int Operator { get { return mcl_operator; } set { mcl_operator = value; } }

        public string operatorName { get { return mcl_operatorName; } set { mcl_operatorName = value; } }

        public int coiler { get { return mcl_coiler; } set { mcl_coiler = value; } }

        public string coilerName { get { return mcl_coilerName; } set { mcl_coilerName = value; } }

        public string hours { get { return mcl_hours; } set { mcl_hours = value; } }

        public double accumulated { get { return mcl_accumulated; } set { mcl_accumulated = value; } }

        public bool calculateWeight { get { return mcl_calculateWeight; } set { mcl_calculateWeight = value; } }

        public double coftf { get { return mcl_coftf; } set { mcl_coftf = value; } }

        public double cofntf { get { return mcl_cofntf; } set { mcl_cofntf = value; } }

        public double thikness { get { return mcl_thikness; } set { mcl_thikness = value; } }

        public string surfacetension { get { return mcl_surfacetension; } set { mcl_surfacetension = value; } }

        public int core { get { return mcl_core; } set { mcl_core = value; } }

        //Constructor

        public clsMainCoil()
        {
            mcl_codsec = 0;
            mcl_fkBopp = 0;
            mcl_BoppCode = "";
            mcl_fkCast = 0;
            mcl_CastCode = "";
            mcl_fkCoating = 0;
            mcl_CoatingCode = "";
            mcl_fkStatus = 0;
            mcl_StatusName = "";
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
            mcl_createdDate = DateTime.Now;
            mcl_modifiedDate = DateTime.Now;
            mcl_createdBy = 0;
            mcl_creatorUser = "";
            mcl_modifiedBy = 0;
            mcl_modificatorUser = "";
            mcl_AnalistRating = "";
            mcl_labRating = "";
            mcl_supervisor = 0;
            mcl_supervisorName = "";
            mcl_operator = 0;
            mcl_operatorName = "";
            mcl_coiler = 0;
            mcl_coilerName = "";
            mcl_hours = "";
            mcl_accumulated = 0;
            mcl_calculateWeight = true;
            mcl_surfacetension = "0;0";
            mcl_core = 0;
        }

        public clsMainCoil(int mainCoilCodsec)
        {
            this.load(mainCoilCodsec);
        }

        public clsMainCoil(string mainCoilCode)
        {
            this.load(mainCoilCode);
        }

        //Methods

        public void load(int mainCoilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoil(" + mainCoilCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);                
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkBopp"]);
                this.BoppCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCast"]);
                this.CastCode = DS.Tables[0].Rows[0]["mcl_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCoating"]);
                this.CoatingCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mcl_StatusName"].ToString();
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
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["mcl_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["mcl_modificatorUser"].ToString();
                this.analistRating = DS.Tables[0].Rows[0]["mcl_analistRating"].ToString();
                this.labRating = DS.Tables[0].Rows[0]["mcl_labRating"].ToString();
                this.supervisor = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_supervisor"]);
                this.supervisorName = DS.Tables[0].Rows[0]["mcl_supervisorName"].ToString();
                this.Operator = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_Operator"]);
                this.operatorName = DS.Tables[0].Rows[0]["mcl_operatorName"].ToString();
                this.coiler = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_coiler"]);
                this.coilerName = DS.Tables[0].Rows[0]["mcl_coilerName"].ToString();
                this.mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[0]["mcl_calculateWeight"]);
                this.mcl_core = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_core"]);
                
            }
        }
        public void load(string mainCoilCode)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilByCode('" + mainCoilCode.ToString() + "');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkBopp"]);
                this.BoppCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCast"]);
                this.CastCode = DS.Tables[0].Rows[0]["mcl_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkCoating"]);
                this.CoatingCode = DS.Tables[0].Rows[0]["mcl_BoppCode"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mcl_StatusName"].ToString();
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
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["mcl_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["mcl_modificatorUser"].ToString();
                this.analistRating = DS.Tables[0].Rows[0]["mcl_analistRating"].ToString();
                this.labRating = DS.Tables[0].Rows[0]["mcl_labRating"].ToString();
                this.supervisor = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_supervisor"]);
                this.supervisorName = DS.Tables[0].Rows[0]["mcl_supervisorName"].ToString();
                this.Operator = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_Operator"]);
                this.operatorName = DS.Tables[0].Rows[0]["mcl_operatorName"].ToString();
                this.coiler = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_coiler"]);
                this.coilerName = DS.Tables[0].Rows[0]["mcl_coilerName"].ToString();
                this.mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[0]["mcl_calculateWeight"]);
                this.mcl_core = Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_core"]);
            }
        }
        public bool save()
        {
            try
            {
                string filmType = "",queryString = "" ;

                if (this.fkBopp != 0)
                    filmType = "Bopp";
                else if (this.fkCast != 0)
                    filmType = "Cast";
                else if (this.fkCoating != 0)
                    filmType = "Coating";

                if (this.codsec == 0)
                {
                    switch (filmType)
                    {
                        case "Bopp":
                            queryString += "INSERT INTO bps_prod_maincoil (mcl_fkBopp, mcl_fkStatus, mcl_fkFilmProductionPlan, mcl_code, mcl_variation, mcl_lotNumber, mcl_grosslength, mcl_netlength, mcl_grossWeight, mcl_netWeight, mcl_width, mcl_gramaje, mcl_velocity, mcl_productionKgHr, mcl_notes, mcl_initDate, mcl_endDate, mcl_createdDate, mcl_modifiedDate, mcl_createdBy, mcl_modifiedBy, mcl_supervisor, mcl_operator, mcl_coiler, mcl_analistRating, mcl_labRating, mcl_calculateWeight, mcl_core)";
                            queryString += " VALUES (";
                            queryString += "" + this.fkBopp.ToString() + ",";
                            queryString += "" + this.fkStatus.ToString() + ",";
                            queryString += "" + this.fkFilmProductionPlan.ToString() + ",";
                            queryString += "'" + this.code.ToString() + "',";
                            queryString += "" + this.variation.ToString() + ",";
                            queryString += "'" + this.lotNumber.ToString() + "',";
                            queryString += "" + this.grosslength.ToString() + ",";
                            queryString += "" + this.netlength.ToString() + ",";
                            queryString += "" + this.grossWeigth.ToString() + ",";
                            queryString += "" + this.netWeigth.ToString() + ",";
                            queryString += "" + this.width.ToString() + ",";
                            queryString += "" + this.gramaje.ToString() + ",";
                            queryString += "" + this.velocity.ToString() + ",";
                            queryString += "" + this.productionKgHr.ToString() + ",";
                            queryString += "'" + this.notes.ToString() + "',";
                            queryString += "'" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += "'" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += "" + this.supervisor.ToString() + ",";
                            queryString += "" + this.Operator.ToString() + ",";
                            queryString += "" + this.coiler.ToString() + ",";
                            queryString += "'" + this.analistRating.ToString() + "',";
                            queryString += "'" + this.labRating.ToString() + "',";
                            queryString += "" + this.calculateWeight.ToString() + ",";
                            queryString += "" + this.mcl_core.ToString() + "";
                            queryString += ");";
                            break;
                        case "Cast":
                            queryString += "INSERT INTO bps_prod_maincoil (mcl_fkCast, mcl_fkStatus, mcl_fkFilmProductionPlan, mcl_code, mcl_variation, mcl_lotNumber, mcl_grosslength, mcl_netlength, mcl_grossWeight, mcl_netWeight, mcl_width, mcl_gramaje, mcl_velocity, mcl_productionKgHr, mcl_notes, mcl_initDate, mcl_endDate, mcl_createdDate, mcl_modifiedDate, mcl_createdBy, mcl_modifiedBy, mcl_supervisor, mcl_operator, mcl_coiler, mcl_analistRating, mcl_labRating, mcl_calculateWeight, mcl_core)";
                            queryString += " VALUES (";
                            queryString += "" + this.fkCast.ToString() + ",";
                            queryString += "" + this.fkStatus.ToString() + ",";
                            queryString += "" + this.fkFilmProductionPlan.ToString() + ",";
                            queryString += "'" + this.code.ToString() + "',";
                            queryString += "" + this.variation.ToString() + ",";
                            queryString += "'" + this.lotNumber.ToString() + "',";
                            queryString += "" + this.grosslength.ToString() + ",";
                            queryString += "" + this.netlength.ToString() + ",";
                            queryString += "" + this.grossWeigth.ToString() + ",";
                            queryString += "" + this.netWeigth.ToString() + ",";
                            queryString += "" + this.width.ToString() + ",";
                            queryString += "" + this.gramaje.ToString() + ",";
                            queryString += "" + this.velocity.ToString() + ",";
                            queryString += "" + this.productionKgHr.ToString() + ",";
                            queryString += "'" + this.notes.ToString() + "',";
                            queryString += "'" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += "'" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += "" + this.supervisor.ToString() + ",";
                            queryString += "" + this.Operator.ToString() + ",";
                            queryString += "" + this.coiler.ToString() + ",";
                            queryString += "'" + this.analistRating.ToString() + "',";
                            queryString += "'" + this.labRating.ToString() + "',";
                            queryString += "" + this.calculateWeight.ToString() + ",";
                            queryString += "" + this.mcl_core.ToString() + "";
                            queryString += ");";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (filmType)
                    {
                        case "Bopp":
                            queryString += "UPDATE bps_prod_maincoil";
                            queryString += " SET ";
                            queryString += " mcl_fkBopp = " + this.fkBopp.ToString() + ",";
                            queryString += " mcl_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += " mcl_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
                            queryString += " mcl_code = '" + this.code.ToString() + "',";
                            queryString += " mcl_variation = " + this.variation.ToString() + ",";
                            queryString += " mcl_lotNumber = '" + this.lotNumber.ToString() + "',";
                            queryString += " mcl_grosslength = " + this.grosslength.ToString() + ",";
                            queryString += " mcl_netlength = " + this.netlength.ToString() + ",";
                            queryString += " mcl_grossWeight = " + this.grossWeigth.ToString() + ",";
                            queryString += " mcl_netWeight = " + this.netWeigth.ToString() + ",";
                            queryString += " mcl_width = " + this.width.ToString() + ",";
                            queryString += " mcl_gramaje = " + this.gramaje.ToString() + ",";
                            queryString += " mcl_velocity = " + this.velocity.ToString() + ",";
                            queryString += " mcl_productionKgHr = " + this.productionKgHr.ToString() + ",";
                            queryString += " mcl_notes = '" + this.notes.ToString() + "',";
                            queryString += " mcl_initDate = '" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += " mcl_endDate = '" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += " mcl_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
                            queryString += " mcl_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " mcl_analistRating = '" + this.analistRating.ToString() + "',";
                            queryString += " mcl_labRating = '" + this.labRating.ToString() +"',";
                            queryString += " mcl_core = " + this.mcl_core.ToString() + "";
                            queryString += " WHERE mcl_codsec = " + this.codsec.ToString();
                            
                            break;
                        case "Cast":
                            queryString += "UPDATE bps_prod_maincoil";
                            queryString += " SET ";
                            queryString += " mcl_fkCast = " + this.fkCast.ToString() + ",";
                            queryString += " mcl_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += " mcl_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
                            queryString += " mcl_code = '" + this.code.ToString() + "',";
                            queryString += " mcl_variation = " + this.variation.ToString() + ",";
                            queryString += " mcl_lotNumber = '" + this.lotNumber.ToString() + "',";
                            queryString += " mcl_grosslength = " + this.grosslength.ToString() + ",";
                            queryString += " mcl_netlength = " + this.netlength.ToString() + ",";
                            queryString += " mcl_grossWeight = " + this.grossWeigth.ToString() + ",";
                            queryString += " mcl_netWeight = " + this.netWeigth.ToString() + ",";
                            queryString += " mcl_width = " + this.width.ToString() + ",";
                            queryString += " mcl_gramaje = " + this.gramaje.ToString() + ",";
                            queryString += " mcl_velocity = " + this.velocity.ToString() + ",";
                            queryString += " mcl_productionKgHr = " + this.productionKgHr.ToString() + ",";
                            queryString += " mcl_notes = '" + this.notes.ToString() + "',";
                            queryString += " mcl_initDate = '" + this.initDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += " mcl_endDate = '" + this.endDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                            queryString += " mcl_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
                            queryString += " mcl_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " mcl_analistRating = '" + this.analistRating.ToString() + "',";
                            queryString += " mcl_labRating = '" + this.labRating.ToString() + "',";
                            queryString += " mcl_core = " + this.mcl_core.ToString() + "";
                            queryString += " WHERE mcl_codsec = " + this.codsec.ToString();
                            
                            break;
                        default:
                            break;
                    }
                }
                bool test = false;
                test=clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = clsMainCoil.getLastSavedCodsec();

                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static List<clsMainCoil> getList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoil());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_BoppCode"].ToString();
                lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                lstMainCoil[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCoating"]);
                lstMainCoil[i].CoatingCode = DS.Tables[0].Rows[i]["mcl_BoppCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
            }

            return lstMainCoil;
        }

        public static List<clsMainCoil> getBoppMainCoilByProductionPlan(int codsecProductionPlan)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilByFilmProductionPlan(" + codsecProductionPlan.ToString() + ");");
            
            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoil());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
            }

            return lstMainCoil;
        }

        public static List<clsMainCoil> getMainCoilByLotNumber(int codsecProductionPlan)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil where mcl_fkFilmProductionPlan = " + codsecProductionPlan.ToString() + " group by mcl_lotNumber order by mcl_variation asc");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoil());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
            }

            return lstMainCoil;
        }

        public static List<clsMainCoil> getBoppMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil order by mcl_codsec DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {
            
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }
        public static List<clsMainCoil> getActiveBoppMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveMainCoilList();");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_castCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }

        public static List<clsMainCoil> getActiveBoppMainCoilListQuality()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilListForQuality();");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclq_boppCode"].ToString();
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclq_code"].ToString();
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclq_lotNumber"].ToString();
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_netlength"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_gramaje"]);
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclq_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclq_endDate"]);
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclq_labRating"].ToString();
                    lstMainCoil[i].coftf = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_coftf"]);
                    lstMainCoil[i].cofntf = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_cofntf"]);
                    lstMainCoil[i].thikness = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_thikness"]);
                    lstMainCoil[i].surfacetension = DS.Tables[0].Rows[i]["mclq_surfacetension"].ToString();
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
                }
            }
            return lstMainCoil;
        }


        public static DataSet getActiveBoppMainCoilDSQuality()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilListForQuality();");

            
            return DS;
        }


        public static List<clsMainCoil> getActiveBoppMainCoilListQuality(int plant)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilListForQualityByPlant("+plant.ToString()+");");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclq_boppCode"].ToString();
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclq_code"].ToString();
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclq_lotNumber"].ToString();
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_netlength"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclq_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_gramaje"]);
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclq_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclq_endDate"]);
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclq_labRating"].ToString();
                    lstMainCoil[i].coftf = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_coftf"]);
                    lstMainCoil[i].cofntf = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_cofntf"]);
                    lstMainCoil[i].thikness = Convert.ToDouble(DS.Tables[0].Rows[i]["mclq_thikness"]);
                    lstMainCoil[i].surfacetension = DS.Tables[0].Rows[i]["mclq_surfacetension"].ToString();
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
                }
            }
            return lstMainCoil;
        }


        public static DataSet getActiveBoppMainCoilDSQuality(int plant)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilListForQualityByPlant(" + plant.ToString() + ");");

            
            return DS;
        }


        public static List<clsMainCoil> getActiveBoppMainCoilListByMachine(int machineCodsec)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveMainCoilListByMachine(" + machineCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }

        public static List<clsMainCoil> getMainCoilListForPerOulLine(int machineCodsec,string source,DateTime initdate, DateTime enddate, string code)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            if (source == "Date")
            {
                DS = clsConnection.getDataSetResult("spMainCoilQualityMetal 'MainCoilOutLineByDate','" + initdate.ToString("dd/MM/yyyy 00:00:00") + "','" + enddate.ToString("dd/MM/yyyy 23:59:59") + "'," + machineCodsec.ToString() + ",'" + code + "'");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstMainCoil.Add(new clsMainCoil());
                        lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                        lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                        lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                        lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                        lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                        lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                        lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                        lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                        lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                        lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                        lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                        lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                        lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                        lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                        lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                        lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                        lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                        lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                        lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                        lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                        lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                        lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                        lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                    }
                }
            }
            else
            {
                DS = clsConnection.getDataSetResult("spMainCoilQualityMetal 'MainCoilOutLineByLotnumber','" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "','" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'," + machineCodsec.ToString() + ",'" + code + "'");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstMainCoil.Add(new clsMainCoil());
                        lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                        lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                        lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                        lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                        lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                        lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                        lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                        lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                        lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                        lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                        lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                        lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                        lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                        lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                        lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                        lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                        lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                        lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                        lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                        lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                        lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                        lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                        lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                    }
                }
            }
            return lstMainCoil;
        }

        public static List<clsMainCoil> getBoppMainCoilListByFilter(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT TOP (300) * FROM vwmaincoil " + where + "  order by mcl_initDate DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString(); 
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].coftf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_coftf"]);
                    lstMainCoil[i].cofntf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_cofntf"]);
                    lstMainCoil[i].thikness = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_thikness"]);
                    lstMainCoil[i].surfacetension = DS.Tables[0].Rows[i]["mcl_surfacetension"].ToString();
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }

        public static List<clsMainCoil> getMainCoilCodeList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcl_code FROM bps_prod_maincoil order by bps_prod_maincoil.mcl_initDate DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mcl_code"].ToString();
                }
            }
            return lstMainCoil;
        }

        public static DataSet getBoppMainCoilDSByFilter(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            string query = "SELECT TOP (1000) * FROM vwMainCoilListForQuality " + where + "  order by mclq_initDate DESC";
            DS = clsConnection.getDataSetResult(query);

            return DS;
        }

        public static List<clsMainCoil> getBoppMainCoilListByFilterPL(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT TOP (300) * FROM vwmaincoil " + where + " AND mcl_fkplant=4  order by mcl_initDate DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].coftf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_coftf"]);
                    lstMainCoil[i].cofntf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_cofntf"]);
                    lstMainCoil[i].thikness = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_thikness"]);
                    lstMainCoil[i].surfacetension = DS.Tables[0].Rows[i]["mcl_surfacetension"].ToString();
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }


        public static DataSet getBoppMainCoilDSByFilterPL(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);
            string query = "SELECT TOP (1000) * FROM vwMainCoilListForQuality " + where + " AND mcl_fkplant=4  order by mclq_initDate DESC";
            DS = clsConnection.getDataSetResult(query);

            
            return DS;
        }


        public static List<clsMainCoil> getBoppMainCoilListByFilterC(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT TOP (300) * FROM vwmaincoil " + where + " AND mcl_fkplant=3  order by mcl_initDate DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString();
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].coftf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_coftf"]);
                    lstMainCoil[i].cofntf = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_cofntf"]);
                    lstMainCoil[i].thikness = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_thikness"]);
                    lstMainCoil[i].surfacetension = DS.Tables[0].Rows[i]["mcl_surfacetension"].ToString();
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);

                }
            }
            return lstMainCoil;
        }


        public static DataSet getBoppMainCoilDSByFilterC(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            string query = "SELECT TOP (1000) * FROM vwMainCoilListForQuality " + where + " AND mcl_fkplant=3  order by mclq_initDate DESC";

            DS = clsConnection.getDataSetResult(query);

            
            return DS;
        }


        public static List<clsMainCoil> getBoppMainCoilListByQualityReport(int qualityCodsec)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spBoppMainCoilListByQualityReport(" + qualityCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mcl_StatusName"].ToString();
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
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mcl_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mcl_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mcl_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mcl_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mcl_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mcl_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mcl_coilerName"].ToString(); 
                    lstMainCoil[i].mcl_calculateWeight = Convert.ToBoolean(DS.Tables[0].Rows[i]["mcl_calculateWeight"]);
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
                }
            }
            return lstMainCoil;
        }

        public static List<clsMainCoil> getListForReportProduction(int fkMachine, string InitDate, string EndDate)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spMailCoilByDateAndMachine(" + "'" + InitDate.ToString() + "', " + "'" + EndDate.ToString() + "', " + fkMachine.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].hours = DS.Tables[0].Rows[i]["mcl_hoursEndDate"].ToString();
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mcl_boppCode"].ToString();
                    lstMainCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkCast"]);
                    lstMainCoil[i].CastCode = DS.Tables[0].Rows[i]["mcl_CastCode"].ToString();
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mcl_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkMachine"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mcl_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mcl_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netlength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_gramaje"]);
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mcl_modifiedDate"]);
                    lstMainCoil[i].accumulated = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_accumulatedWeigth"]);
                    lstMainCoil[i].mcl_core = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_core"]);
                }
            }
            return lstMainCoil;
        }

        public static double getaccumulatedbyfilproductionplan(int fkfilmproductionplan)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spAccumulatedbyfilmproductionplan(" + fkfilmproductionplan.ToString() + ");");
            if (DS.Tables[0].Rows.Count > 0)
            {
                return Convert.ToDouble(DS.Tables[0].Rows[0]["mcl_accumulatedWeigth"]);
            }
            else
                return 0;
        }


        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcl_codsec FROM bps_prod_maincoil ORDER BY mcl_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);
        }

        public static int getMainCoilCodsecByCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcl_codsec FROM bps_prod_maincoil WHERE mcl_code = '" + code + "'");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcl_codsec"]);
        }

        public static string getMainCoilCodeByCodsec(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcl_code FROM bps_prod_maincoil WHERE mcl_codsec = '" + codsec + "'");

            return DS.Tables[0].Rows[0]["mcl_code"].ToString();
        }

        public void changeStatus(string status)
        {
            switch (status)
            {
                case "En proceso":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", status)).codsec;
                    this.save();
                    break;
                case "Cerrada":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", status)).codsec;
                    this.save();
                    break;
            }
        }
        public override string ToString()
        {
            return this.code;
        }

        public static void delete(int mainCoilCodsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_maincoil WHERE mcl_codsec = " + mainCoilCodsec.ToString());
        }

        public static int getLastCoilRegisteredMonthByMchine(int machineCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spLastMainCoilByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToDateTime(DS.Tables[0].Rows[0]["mcl_endDate"]).Month;
            else
                return DateTime.Now.Month;
        }

        public static bool getExistMainCoilByLotNumber(string lotnumber)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoil WHERE mcl_lotNumber = '" + lotnumber + "0'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static List<clsMainCoil> getListByLotNumber(string lotnumber)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoil WHERE bps_prod_maincoil.mcl_lotNumber = '" + lotnumber + "0'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mcl_codsec"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mcl_code"].ToString();
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mcl_netWeigth"]);
                }
            }
            return lstMainCoil;
        }

        public bool delete()
        {
            try
            {
                string queryString = "";

                if (this.codsec != 0)
                {
                    queryString += "UPDATE bps_prod_maincoil";
                    queryString += " SET ";
                    queryString += " mcl_fkStatus = " + Convert.ToInt32(51) + ""; // saber que estado de bobina ponerle.
                    queryString += " WHERE mcl_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }
    }
}