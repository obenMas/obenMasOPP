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
    public class clsMainCoilMetal
    {
        //Atributes

        private int mclm_codsec;
        private int mclm_fkBoppFrom;
        private int mclm_fkProductFrom;
        private int mclm_fkBoppTo;
        private int mclm_fkProductTo;
        private int mclm_fkStatus;
        private string mclm_StatusName;
        private int mclm_fkFilmProductionPlan;
        private string mclm_mcode;
        private string mclm_bcode;
        private string mclm_lotNumber;
        private double mclm_netlength;
        private double mclm_grossWeigth;
        private double mclm_netWeigth;
        private int mclm_width;
        private double mclm_diameter;
        private double mclm_density;
        private int mclm_cuttingPosition;
        private int mclm_cuttingStop;
        private string mclm_notes;
        private string mclm_origin;
        private bool mclm_isMaquile;
        private DateTime mclm_createdDate;
        private DateTime mclm_modifiedDate;
        private int mclm_createdBy;
        private string mclm_creatorUser;
        private int mclm_modifiedBy;
        private string mclm_modificatorUser;
        private string mclm_AnalistRating;
        private string mclm_labRating;
        private int mclm_fkorigin;
        private string mclm_maincode;
        private string mclm_BoppFromCode;
        private string mclm_BoppToCode;
        private string mclm_ProductFromCode;
        private string mclm_ProductToCode;
        private double mclm_originweigth;
        private double mclm_decrease;


        private int mclm_supervisor;
        private string mclm_operatorName;
        private int mclm_coiler;
        private string mclm_coilerName;
        private string mclm_CastCode;
        private int mclm_fkCoating;
        private string mclm_CoatingCode;
        private string mclm_FilmProductionPlanLotNumber;
        private int mclm_fkMachine;
        private string mclm_MachineName;
        private int mclm_fkProductionOrder;
        private int mclm_ProductionOrderNumber;
        private int mclm_variation;
        private double mclm_grosslength;
        private double mclm_usedLength;
        private double mclm_gramaje;
        private double mclm_velocity;
        private double mclm_productionKgHr;
        private DateTime mclm_initDate;
        private DateTime mclm_endDate;
        private string mtod_processValues;
        private List<string> mtod_processList;




        //Properties

        public int codsec { get { return mclm_codsec; } set { mclm_codsec = value; } }

        public int fkBoppFrom { get { return mclm_fkBoppFrom; } set { mclm_fkBoppFrom = value; } }

        public int fkProductFrom { get { return mclm_fkProductFrom; } set { mclm_fkProductFrom = value; } }

        public int fkBoppTo { get { return mclm_fkBoppTo; } set { mclm_fkBoppTo = value; } }

        public int fkProductTo { get { return mclm_fkProductTo; } set { mclm_fkProductTo = value; } }

        public int fkStatus { get { return mclm_fkStatus; } set { mclm_fkStatus = value; } }

        public string StatusName { get { return mclm_StatusName; } set { mclm_StatusName = value; } }

        public int fkFilmProductionPlan { get { return mclm_fkFilmProductionPlan; } set { mclm_fkFilmProductionPlan = value; } }

        public string mcode { get { return mclm_mcode; } set { mclm_mcode = value; } }

        public string bcode { get { return mclm_bcode; } set { mclm_bcode = value; } }

        public string lotNumber { get { return mclm_lotNumber; } set { mclm_lotNumber = value; } }

        public double netlength { get { return mclm_netlength; } set { mclm_netlength = value; } }

        public double grossWeigth { get { return mclm_grossWeigth; } set { mclm_grossWeigth = value; } }

        public double netWeigth { get { return mclm_netWeigth; } set { mclm_netWeigth = value; } }

        public int width { get { return mclm_width; } set { mclm_width = value; } }

        public double diameter { get { return mclm_diameter; } set { mclm_diameter = value; } }

        public double density { get { return mclm_density; } set { mclm_density = value; } }

        public int cuttingPosition { get { return mclm_cuttingPosition; } set { mclm_cuttingPosition = value; } }

        public int cuttingStop { get { return mclm_cuttingStop; } set { mclm_cuttingStop = value; } }

        public string notes { get { return mclm_notes; } set { mclm_notes = value; } }

        public string origin { get { return mclm_origin; } set { mclm_origin = value; } }

        public bool isMaquile { get { return mclm_isMaquile; } set { mclm_isMaquile = value; } }

        public DateTime createdDate { get { return mclm_createdDate; } set { mclm_createdDate = value; } }

        public DateTime modifiedDate { get { return mclm_modifiedDate; } set { mclm_modifiedDate = value; } }

        public int createdBy { get { return mclm_createdBy; } set { mclm_createdBy = value; } }

        public string creatorUser { get { return mclm_creatorUser; } set { mclm_creatorUser = value; } }

        public int modifiedBy { get { return mclm_modifiedBy; } set { mclm_modifiedBy = value; } }

        public string modificatorUser { get { return mclm_modificatorUser; } set { mclm_modificatorUser = value; } }

        public string analistRating { get { return mclm_AnalistRating; } set { mclm_AnalistRating = value; } }

        public string labRating { get { return mclm_labRating; } set { mclm_labRating = value; } }

        public int fkorigin { get { return mclm_fkorigin; } set { mclm_fkorigin = value; } }

        public string maincode { get { return mclm_maincode; } set { mclm_maincode = value; } }

        public string ProductToCode { get { return mclm_ProductToCode; } set { mclm_ProductToCode = value; } }

        public string ProductFromCode { get { return mclm_ProductFromCode; } set { mclm_ProductFromCode = value; } }

        public string processValues { get { return mtod_processValues; } set { mtod_processValues = value; } }

        public List<string> processList { get { return mtod_processList; } set { mtod_processList = value; } }





        public string CastCode { get { return mclm_CastCode; } set { mclm_CastCode = value; } }

        public int fkCoating { get { return mclm_fkCoating; } set { mclm_fkCoating = value; } }

        public string CoatingCode { get { return mclm_CoatingCode; } set { mclm_CoatingCode = value; } }

        public string FilmProductionPlanLotNumber { get { return mclm_FilmProductionPlanLotNumber; } set { mclm_FilmProductionPlanLotNumber = value; } }

        public double OriginWeigth { get { return mclm_originweigth; } set { mclm_originweigth = value; } }

        public int fkMachine { get { return mclm_fkMachine; } set { mclm_fkMachine = value; } }

        public string MachineName { get { return mclm_MachineName; } set { mclm_MachineName = value; } }

        public double decrease { get { return mclm_decrease; } set { mclm_decrease = value; } }

        public int fkProductionOrder { get { return mclm_fkProductionOrder; } set { mclm_fkProductionOrder = value; } }

        public int ProductionOrderNumber { get { return mclm_ProductionOrderNumber; } set { mclm_ProductionOrderNumber = value; } }

        public int variation { get { return mclm_variation; } set { mclm_variation = value; } }

        public double grosslength { get { return mclm_grosslength; } set { mclm_grosslength = value; } }

        public double usedLength { get { return mclm_usedLength; } set { mclm_usedLength = value; } }

        public double gramaje { get { return mclm_gramaje; } set { mclm_gramaje = value; } }

        public double velocity { get { return mclm_velocity; } set { mclm_velocity = value; } }

        public double productionKgHr { get { return mclm_productionKgHr; } set { mclm_productionKgHr = value; } }

        public DateTime initDate { get { return mclm_initDate; } set { mclm_initDate = value; } }

        public DateTime endDate { get { return mclm_endDate; } set { mclm_endDate = value; } }

        public int supervisor { get { return mclm_supervisor; } set { mclm_supervisor = value; } }



        public string operatorName { get { return mclm_operatorName; } set { mclm_operatorName = value; } }

        public int coiler { get { return mclm_coiler; } set { mclm_coiler = value; } }

        public string coilerName { get { return mclm_coilerName; } set { mclm_coilerName = value; } }

        public string BoppFromCode { get { return mclm_BoppFromCode; } set { mclm_BoppFromCode = value; } }

        public string BoppToCode { get { return mclm_BoppToCode; } set { mclm_BoppToCode = value; } }

        //Constructor

        public clsMainCoilMetal()
        {
            mclm_decrease = 0;
            mclm_originweigth = 0;
            mtod_processValues = "0;0;0;0;0;0;0;0;0;0;0;0;0";
            mtod_processList = new List<string>();
            mclm_BoppToCode = "";
            mclm_BoppFromCode = "";
            mclm_maincode = "";
            mclm_fkorigin = 0;
            mclm_codsec = 0;
            mclm_fkBoppFrom = 0;
            mclm_fkProductFrom = 0;
            mclm_fkBoppTo = 0;
            mclm_fkProductTo = 0;
            mclm_CastCode = "";
            mclm_fkCoating = 0;
            mclm_CoatingCode = "";
            mclm_fkStatus = 0;
            mclm_StatusName = "";
            mclm_fkFilmProductionPlan = 0;
            mclm_FilmProductionPlanLotNumber = "";
            mclm_originweigth = 0;
            mclm_fkMachine = 0;
            mclm_MachineName = "";
            mclm_decrease = 0;
            mclm_fkProductionOrder = 0;
            mclm_ProductionOrderNumber = 0;
            mclm_mcode = "";
            mclm_variation = 0;
            mclm_lotNumber = "";
            mclm_grosslength = 0;
            mclm_netlength = 0;
            mclm_usedLength = 0;
            mclm_grossWeigth = 0;
            mclm_netWeigth = 0;
            mclm_width = 0;
            mclm_gramaje = 0;
            mclm_velocity = 0;
            mclm_productionKgHr = 0;
            mclm_notes = "";
            mclm_initDate = DateTime.Now;
            mclm_endDate = DateTime.Now;
            mclm_createdDate = DateTime.Now;
            mclm_modifiedDate = DateTime.Now;
            mclm_createdBy = 0;
            mclm_creatorUser = "";
            mclm_modifiedBy = 0;
            mclm_modificatorUser = "";
            mclm_AnalistRating = "";
            mclm_labRating = "";
            mclm_supervisor = 0;
            mclm_ProductToCode = "";
            mclm_operatorName = "";
            mclm_coiler = 0;
            mclm_coilerName = "";

        }

        public clsMainCoilMetal(int mainCoilCodsec)
        {
            this.load(mainCoilCodsec);
        }

        public clsMainCoilMetal(string mainCoilCode)
        {
            this.load(mainCoilCode, true);
        }

        public clsMainCoilMetal(string mainCoilCode, bool flgValidate)
        {
            this.load(mainCoilCode, true, 0);
        }

        public clsMainCoilMetal(string mainCoilCode, bool flgValidate, bool flg)
        {
            this.load(mainCoilCode, true, true);
        }

        //Methods

        public void load(int mainCoilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + mainCoilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                this.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                this.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                this.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                this.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                this.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                this.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                this.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                this.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                this.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                this.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                this.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                this.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                this.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                this.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                this.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                this.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                this.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                this.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                this.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                this.processList = clsGlobal.getStringListFromString(this.processValues);
                this.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
            }
        }

        public void load(string mainCoilCode, bool data)
        {
            DataSet DS = new DataSet();
            DataSet Ds = new DataSet();

            Ds = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_bcode = '" + mainCoilCode + "'");

            if (Ds.Tables[0].Rows.Count > 0)
            {
                DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + Ds.Tables[0].Rows[0]["mclm_codsec"].ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                    this.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                    this.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                    this.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                    this.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                    this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                    this.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                    this.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                    this.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                    this.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                    this.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                    this.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                    this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                    this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                    this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                    this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                    this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                    this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                    this.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                    this.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                    this.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                    this.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                    this.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                    this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                    this.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                    this.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                    this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                    this.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                    this.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                    this.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                    this.processList = clsGlobal.getStringListFromString(this.processValues);
                    this.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
                }
            }
        }

        public void load(string mainCoilCode, bool data, int number)
        {
            DataSet DS = new DataSet();
            DataSet Ds = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilQualityMetal 'MaquileCode', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0, '" + mainCoilCode.ToUpper() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                this.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                this.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                this.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                this.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                this.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                this.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                this.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                this.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                this.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                this.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                this.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                this.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                this.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                this.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                this.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                this.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                this.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                this.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                this.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                this.processList = clsGlobal.getStringListFromString(this.processValues);
                //this.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
            }
        }

        public void load(string mainCoilCode, bool test, bool mydata)
        {
            DataSet DS = new DataSet();
            DataSet Ds = new DataSet();
            DataSet ds = new DataSet();

            Ds = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_mcode = '" + mainCoilCode + "'");

            if (Ds.Tables[0].Rows.Count > 0)
            {
                DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + Ds.Tables[0].Rows[0]["mclm_codsec"].ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                    this.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                    this.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                    this.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                    this.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                    this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                    this.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                    this.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                    this.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                    this.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                    this.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                    this.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                    this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                    this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                    this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                    this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                    this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                    this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                    this.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                    this.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                    this.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                    this.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                    this.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                    this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                    this.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                    this.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                    this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                    this.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                    this.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                    this.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                    this.processList = clsGlobal.getStringListFromString(this.processValues);
                    this.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
                    this.modificatorUser = DS.Tables[0].Rows[0]["UserModificator"].ToString();
                    this.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_decrease"]);
                }
            }
            else
            {
                ds = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_bcode = '" + mainCoilCode + "'");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + ds.Tables[0].Rows[0]["mclm_codsec"].ToString());

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                        this.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                        this.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                        this.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                        this.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                        this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                        this.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                        this.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                        this.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                        this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                        this.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                        this.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                        this.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                        this.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                        this.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                        this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                        this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                        this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                        this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                        this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                        this.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                        this.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                        this.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                        this.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                        this.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                        this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                        this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                        this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                        this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                        this.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                        this.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                        this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                        this.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                        this.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                        this.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                        this.processList = clsGlobal.getStringListFromString(this.processValues);
                        this.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
                        this.modificatorUser = DS.Tables[0].Rows[0]["UserModificator"].ToString();
                        this.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_decrease"]);
                    }
                }
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maincoilmetal (mclm_fkBoppFrom, mclm_fkProductFrom, mclm_fkBoppTo, mclm_fkProductTo, mclm_fkStatus, mclm_fkFilmProductionPlan, mclm_mcode, mclm_bcode, mclm_lotNumber,mclm_length , mclm_grossWeight, mclm_netWeight, mclm_width, mclm_diameter, mclm_density, mclm_cuttingPosition, mclm_cuttingStop, mclm_notes, mclm_origin, mclm_isMaquile, mclm_createdDate, mclm_modifiedDate, mclm_createdBy, mclm_modifiedBy, mclm_labRating, mclm_analistRating, mclm_fkorigin, mclm_maincode, mclm_originweigth, mclm_decrease)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkBoppFrom.ToString() + ",";
                    queryString += "" + this.fkProductFrom.ToString() + ",";
                    queryString += "" + this.fkBoppTo.ToString() + ",";
                    queryString += "" + this.fkProductTo.ToString() + ",";
                    queryString += "" + this.fkStatus.ToString() + ",";
                    queryString += "" + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += "'" + this.mcode.ToString() + "',";
                    queryString += "'" + this.bcode.ToString() + "',";
                    queryString += "'" + this.lotNumber.ToString() + "',";
                    queryString += "" + this.netlength.ToString() + ",";
                    queryString += "" + this.grossWeigth.ToString() + ",";
                    queryString += "" + this.netWeigth.ToString() + ",";
                    queryString += "" + this.width.ToString() + ",";
                    queryString += "" + this.diameter.ToString() + ",";
                    queryString += "" + this.density.ToString() + ",";
                    queryString += "" + this.cuttingPosition.ToString() + ",";
                    queryString += "" + this.cuttingStop.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + this.origin.ToString() + "',";
                    queryString += "" + this.isMaquile.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.labRating.ToString() + "',";
                    queryString += "'" + this.analistRating.ToString() + "',";
                    queryString += "" + this.fkorigin.ToString() + ",";
                    queryString += "'" + this.maincode.ToString() + "',";
                    queryString += "" + this.OriginWeigth.ToString() + ",";
                    queryString += "" + this.decrease.ToString() + "";
                    queryString += ")";
                }
                else
                {
                    queryString += "UPDATE bps_prod_maincoilmetal";
                    queryString += " SET ";
                    queryString += " mclm_fkBopp = " + this.fkBoppFrom.ToString() + ",";
                    queryString += " mclm_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += " mclm_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += " mclm_code = '" + this.mcode.ToString() + "',";
                    queryString += " mclm_variation = " + this.variation.ToString() + ",";
                    queryString += " mclm_lotNumber = '" + this.lotNumber.ToString() + "',";
                    queryString += " mclm_grosslength = " + this.grosslength.ToString() + ",";
                    queryString += " mclm_netlength = " + this.netlength.ToString() + ",";
                    queryString += " mclm_grossWeight = " + this.grossWeigth.ToString() + ",";
                    queryString += " mclm_netWeight = " + this.netWeigth.ToString() + ",";
                    queryString += " mclm_width = " + this.width.ToString() + ",";
                    queryString += " mclm_gramaje = " + this.gramaje.ToString() + ",";
                    queryString += " mclm_velocity = " + this.velocity.ToString() + ",";
                    queryString += " mclm_productionKgHr = " + this.productionKgHr.ToString() + ",";
                    queryString += " mclm_notes = '" + this.notes.ToString() + "',";
                    queryString += " mclm_initDate = '" + this.initDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " mclm_endDate = '" + this.endDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " mclm_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " mclm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " mclm_createdBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += " mclm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += " mclm_analistRating = '" + this.analistRating.ToString() + "',";
                    queryString += " mclm_process = '" + this.processValues.ToString() + "',";
                    queryString += " mclm_labRating = '" + this.labRating.ToString() + "'";

                    queryString += " WHERE mclm_codsec = " + this.codsec.ToString();
                }

                if (clsConnection.executeQuery(queryString))
                {
                    clsSequential.addSequential("mainCoilMetal");
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public bool UpdateLengthAndObs()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_notes = '" + this.notes.ToString() + "',";
                queryString += " mclm_length = " + this.netlength.ToString();
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }
        public bool toUpdateLab()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_analistRating = '" + this.analistRating.ToString() + "',";
                queryString += " mclm_labRating = '" + this.labRating.ToString() + "'";
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public bool toUpdateProcess()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_length = " + this.netlength.ToString() + ",";
                queryString += " mclm_notes = '" + this.notes.ToString().Replace("'", "") + "',";
                queryString += " mclm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += " mclm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                queryString += " mclm_process = '" + this.processValues.ToString() + "'";
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public bool toUpdateWeigth()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_grossWeight = " + this.grossWeigth.ToString() + ",";
                queryString += " mclm_netWeight = " + this.netWeigth.ToString() + ",";
                queryString += " mclm_decrease = " + this.decrease.ToString() + ",";
                queryString += " mclm_bcode = '" + this.bcode.ToString() + "',";
                queryString += " mclm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += " mclm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public bool toCloseCoil()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "Cerrada").codsec + ",";
                queryString += " mclm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += " mclm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static int getTotalMainCoilByFilmProductionPlan(int codsec)
        {
            clsFilmProductionPlanMetal objFilmProductionPlan = new clsFilmProductionPlanMetal(codsec);

            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByFilmProductionPlan', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + objFilmProductionPlan.codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows.Count);
            else
                return 0;
        }

        public static List<clsMainCoilMetal> getListByFilmProductionPlan(int fkfilmproductionplan)
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByFilmProductionPlan', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + fkfilmproductionplan.ToString());

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoilMetal());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
            }

            return lstMainCoil;
        }

        public static bool toCrossCoil(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += "mclm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "Anulada").codsec.ToString() + ", ";
                queryString += "mclm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mclm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mclm_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static bool toCrossCoilDelete(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "DELETE FROM  bps_prod_maincoilmetal";
                queryString += " WHERE mclm_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static string toCheckData(int codsec)
        {
            try
            {
                DataSet DS = new DataSet();
                DataSet Ds = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_metalizedpression WHERE mtop_fkOrder =" + codsec.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                    return "Presión";
                else
                {
                    Ds = clsConnection.getDataSetResult("SELECT * FROM bps_prod_deadtimemetalized WHERE mtodt_fkOrder =" + codsec.ToString());
                    if (Ds.Tables[0].Rows.Count > 0)
                        return "Tiempo Muerto";
                    else
                        return "OK";
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return "";
            }
        }

        public static int getProductionOrderByMainCoil(int codsec)
        {
            DataSet DS = new DataSet();
            DataSet Ds = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT mclm_fkFilmProductionPlan FROM bps_prod_maincoilmetal WHERE mclm_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                Ds = clsConnection.getDataSetResult("SELECT fpom_fkProductionOrder FROM bps_prod_filmproductionplanmetal WHERE fpom_codsec = " + DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"].ToString());
                if (Ds.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(Ds.Tables[0].Rows[0]["fpom_fkProductionOrder"]);
                else
                    return 0;
            }
            else
                return 0;
        }

        public static bool isUnique(string code)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_bcode = '" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static List<clsMainCoil> getBoppMainCoilByProductionPlant(int codsecProductionPlan)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilByFilmProductionPlan(" + codsecProductionPlan.ToString() + ");");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoil());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();
            }

            return lstMainCoil;
        }

        public static List<clsMainCoil> getMainCoilByLotNumber(int codsecProductionPlan)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil where mclm_fkFilmProductionPlan = " + codsecProductionPlan.ToString() + " group by mclm_lotNumber order by mclm_variation asc");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoil());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();
            }

            return lstMainCoil;
        }

        public static List<clsMainCoil> getBoppMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil order by mclm_codsec DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                    lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();

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
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                    lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();

                }
            }
            return lstMainCoil;
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
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                    lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();

                }
            }
            return lstMainCoil;
        }

        public static DataSet getMainCoilMetalStock(int fkplant)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spMainCoilMetalStockByPlant("+fkplant.ToString()+")");
            return DS;
        }

        public static List<clsMainCoil> getBoppMainCoilListByFilter(List<clsFilter> lstFilter)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoil " + where + "  order by mclm_initDate DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoil());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                    lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();

                }
            }
            return lstMainCoil;
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
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBopp"]);
                    lstMainCoil[i].BoppCode = DS.Tables[0].Rows[i]["mclm_boppCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_StatusName"].ToString();
                    lstMainCoil[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkFilmProductionPlan"]);
                    lstMainCoil[i].FilmProductionPlanLotNumber = DS.Tables[0].Rows[i]["mclm_FilmProductionPlanLotNumber"].ToString();
                    lstMainCoil[i].FilmProductionPlanTotalWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_FilmProductionPlanTotalWeigth"]);
                    lstMainCoil[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkMachine"]);
                    lstMainCoil[i].MachineName = DS.Tables[0].Rows[i]["mclm_MachineName"].ToString();
                    lstMainCoil[i].ProductionOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_ProductionOrderQuantity"]);
                    lstMainCoil[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductionOrder"]);
                    lstMainCoil[i].ProductionOrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_ProductionOrderNumber"]);
                    lstMainCoil[i].code = DS.Tables[0].Rows[i]["mclm_code"].ToString();
                    lstMainCoil[i].variation = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_variation"]);
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].grosslength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grosslength"]);
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netlength"]);
                    lstMainCoil[i].usedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_usedLength"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeigth"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeigth"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].gramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_gramaje"]);
                    lstMainCoil[i].velocity = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_velocity"]);
                    lstMainCoil[i].productionKgHr = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_productionKgHr"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_initDate"]);
                    lstMainCoil[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_endDate"]);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].creatorUser = DS.Tables[0].Rows[i]["mclm_creatorUser"].ToString();
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].modificatorUser = DS.Tables[0].Rows[i]["mclm_modificatorUser"].ToString();
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].supervisor = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_supervisor"]);
                    lstMainCoil[i].supervisorName = DS.Tables[0].Rows[i]["mclm_supervisorName"].ToString();
                    lstMainCoil[i].Operator = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_Operator"]);
                    lstMainCoil[i].operatorName = DS.Tables[0].Rows[i]["mclm_operatorName"].ToString();
                    lstMainCoil[i].coiler = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_coiler"]);
                    lstMainCoil[i].coilerName = DS.Tables[0].Rows[i]["mclm_coilerName"].ToString();

                }
            }
            return lstMainCoil;
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mclm_codsec FROM bps_prod_maincoil ORDER BY mclm_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
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
            return this.mcode;
        }

        public static void delete(int mainCoilCodsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_maincoil WHERE mclm_codsec = " + mainCoilCodsec.ToString());
        }

        public static int getLastCoilRegisteredMonthByMchine(int machineCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spLastMainCoilByMachine(" + machineCodsec.ToString() + ")");

            return Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_endDate"]).Month;
        }

        public static List<clsMainCoilMetal> getListByMainCoilCodsec(int codsecMainCoil)
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + codsecMainCoil.ToString());

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoilMetal());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
            }

            return lstMainCoil;
        }

        public static clsMainCoilMetal toCheckMainCoilData(string mcode)
        {
            DataSet DS = new DataSet();

            clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_mcode = '" + mcode + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objMainCoilMetal.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_codsec"]);
                objMainCoilMetal.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_diameter"]);
                objMainCoilMetal.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_grossWeight"]);
                objMainCoilMetal.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
                objMainCoilMetal.netlength = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_length"]);
                objMainCoilMetal.width = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_width"]);
                objMainCoilMetal.lotNumber = DS.Tables[0].Rows[0]["mclm_lotNumber"].ToString();
                objMainCoilMetal.mcode = DS.Tables[0].Rows[0]["mclm_mcode"].ToString();
                objMainCoilMetal.notes = DS.Tables[0].Rows[0]["mclm_notes"].ToString();
                //objMainCoilMetal.fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppFrom"]);
                //objMainCoilMetal.BoppFromCode = DS.Tables[0].Rows[0]["mclm_BoppFromCode"].ToString();
                //objMainCoilMetal.fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductFrom"]);
                //objMainCoilMetal.ProductFromCode = DS.Tables[0].Rows[0]["mclm_ProductFromCode"].ToString();
                //objMainCoilMetal.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkBoppTo"]);
                //objMainCoilMetal.BoppToCode = DS.Tables[0].Rows[0]["mclm_BoppToCode"].ToString();
                objMainCoilMetal.fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkProductTo"]);
                //objMainCoilMetal.ProductToCode = DS.Tables[0].Rows[0]["mclm_ProductToCode"].ToString();
                //objMainCoilMetal.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkStatus"]);
                //objMainCoilMetal.StatusName = DS.Tables[0].Rows[0]["mclm_sttname"].ToString();
                //objMainCoilMetal.bcode = DS.Tables[0].Rows[0]["mclm_bcode"].ToString();
                //objMainCoilMetal.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_density"]);
                //objMainCoilMetal.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingPosition"]);
                //objMainCoilMetal.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_cuttingStop"]);
                //objMainCoilMetal.origin = DS.Tables[0].Rows[0]["mclm_origin"].ToString();
                //objMainCoilMetal.isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                //objMainCoilMetal.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_createdDate"]);
                //objMainCoilMetal.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mclm_modifiedDate"]);
                //objMainCoilMetal.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_createdBy"]);
                //objMainCoilMetal.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_modifiedBy"]);
                //objMainCoilMetal.analistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();
                //objMainCoilMetal.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                //objMainCoilMetal.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkFilmProductionPlan"]);
                //objMainCoilMetal.fkorigin = Convert.ToInt32(DS.Tables[0].Rows[0]["mclm_fkorigin"]);
                objMainCoilMetal.maincode = DS.Tables[0].Rows[0]["mclm_maincode"].ToString();
                //objMainCoilMetal.processValues = DS.Tables[0].Rows[0]["mclm_process"].ToString();
                //objMainCoilMetal.processList = clsGlobal.getStringListFromString(objMainCoilMetal.processValues);
                //objMainCoilMetal.OriginWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_originweigth"]);
            }
            return objMainCoilMetal;
        }

        public static List<clsMainCoilMetal> getActiveMainCoilMetalByFilter(string mainCoilMetalCode)
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();
            DataSet ds = new DataSet();
            DataSet dst = new DataSet();

            ds = clsConnection.getDataSetResult("SELECT mclm_codsec FROM bps_prod_maincoilmetal WHERE mclm_mcode = '" + mainCoilMetalCode + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + ds.Tables[0].Rows[0]["mclm_codsec"].ToString());

                lstMainCoil.Clear();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoilMetal());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                    lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                    lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                    lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                    lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                    lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                    lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                    lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                    lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                    lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                    lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                    lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                    lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                    lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                    lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                    lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                    lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
                }
            }
            else
            {
                dst = clsConnection.getDataSetResult("SELECT mclm_codsec FROM bps_prod_maincoilmetal WHERE mclm_bcode = '" + mainCoilMetalCode + "'");

                if (dst.Tables[0].Rows.Count > 0)
                {
                    DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilByCodsec', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', " + dst.Tables[0].Rows[0]["mclm_codsec"].ToString());

                    lstMainCoil.Clear();

                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstMainCoil.Add(new clsMainCoilMetal());
                        lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                        lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                        lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                        lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                        lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                        lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                        lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                        lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                        lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                        lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                        lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                        lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                        lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                        lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                        lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                        lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                        lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                        lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                        lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                        lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                        lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                        lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                        lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                        lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                        lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                        lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                        lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                        lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                        lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                        lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                        lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                        lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                        lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                        lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                        lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
                    }
                }
            }

            return lstMainCoil;
        }

        public static List<clsMainCoilMetal> getActiveMainCoilMetal()
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilMultiple 'MainCoilList', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', 0");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoilMetal());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
            }

            return lstMainCoil;
        }

        public static List<clsMainCoilMetal> getActiveMainCoilMetal(int planta)
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMainCoilMetalListByPlant("+planta.ToString()+")");

            lstMainCoil.Clear();
            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoil.Add(new clsMainCoilMetal());
                    lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                    lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                    lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                    lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                    lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                    lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                    lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                    lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                    lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                    lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                    lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                    lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                    lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                    lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                    lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                    lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                    lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                    lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                    lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                    lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                    lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                    lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                    lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                    lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                    lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                    lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                    lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                    lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                    lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                    lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                    lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                    lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                    lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                    lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                    lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
                }
            }
            

            return lstMainCoil;
        }

        public static bool getExistMainCoilByLotNumber(string lotnumber)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maincoilmetal WHERE mclm_lotNumber = '" + lotnumber + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool toUpdateLotNumber()
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_maincoilmetal";
                queryString += " SET ";
                queryString += " mclm_lotNumber = '" + this.lotNumber + "'";
                queryString += " WHERE mclm_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static double getListForReportProduction(String initdate, String enddate)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMailMetalFilm 'MonthProduction', '" + initdate.ToString() + "', '" + enddate.ToString() + "', 0, '' ");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToDouble(DS.Tables[0].Rows[0]["mclm_netWeight"]);
            else
                return 0;
        }

        public static List<clsMainCoilMetal> getListMainCoilMetalForMailSend(DateTime initdate, DateTime enddate)
        {
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMailMetalFilm 'ListMainCoilMetal', '" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "', 0, '' ");

            lstMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoil.Add(new clsMainCoilMetal());
                lstMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_codsec"]);
                lstMainCoil[i].fkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppFrom"]);
                lstMainCoil[i].BoppFromCode = DS.Tables[0].Rows[i]["mclm_BoppFromCode"].ToString();
                lstMainCoil[i].fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductFrom"]);
                lstMainCoil[i].ProductFromCode = DS.Tables[0].Rows[i]["mclm_ProductFromCode"].ToString();
                lstMainCoil[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkBoppTo"]);
                lstMainCoil[i].BoppToCode = DS.Tables[0].Rows[i]["mclm_BoppToCode"].ToString();
                lstMainCoil[i].fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkProductTo"]);
                lstMainCoil[i].ProductToCode = DS.Tables[0].Rows[i]["mclm_ProductToCode"].ToString();
                lstMainCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkStatus"]);
                lstMainCoil[i].StatusName = DS.Tables[0].Rows[i]["mclm_sttname"].ToString();
                lstMainCoil[i].mcode = DS.Tables[0].Rows[i]["mclm_mcode"].ToString();
                lstMainCoil[i].bcode = DS.Tables[0].Rows[i]["mclm_bcode"].ToString();
                lstMainCoil[i].lotNumber = DS.Tables[0].Rows[i]["mclm_lotNumber"].ToString();
                lstMainCoil[i].netlength = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_length"]);
                lstMainCoil[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_grossWeight"]);
                lstMainCoil[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_netWeight"]);
                lstMainCoil[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_width"]);
                lstMainCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_diameter"]);
                lstMainCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mclm_density"]);
                lstMainCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingPosition"]);
                lstMainCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_cuttingStop"]);
                lstMainCoil[i].notes = DS.Tables[0].Rows[i]["mclm_notes"].ToString();
                lstMainCoil[i].origin = DS.Tables[0].Rows[i]["mclm_origin"].ToString();
                lstMainCoil[i].isMaquile = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mclm_isMaquile"], DS.Tables[0].Rows[0]["mclm_isMaquile"].GetType().FullName);
                lstMainCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_createdDate"]);
                lstMainCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mclm_modifiedDate"]);
                lstMainCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_createdBy"]);
                lstMainCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_modifiedBy"]);
                lstMainCoil[i].analistRating = DS.Tables[0].Rows[i]["mclm_analistRating"].ToString();
                lstMainCoil[i].labRating = DS.Tables[0].Rows[i]["mclm_labRating"].ToString();
                lstMainCoil[i].fkorigin = Convert.ToInt32(DS.Tables[0].Rows[i]["mclm_fkorigin"]);
                lstMainCoil[i].maincode = DS.Tables[0].Rows[i]["mclm_maincode"].ToString();
                lstMainCoil[i].processValues = DS.Tables[0].Rows[i]["mclm_process"].ToString();
                lstMainCoil[i].processList = clsGlobal.getStringListFromString(lstMainCoil[i].processValues);
            }

            return lstMainCoil;
        }
    }
}