using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los diferentes tipos productos
    /// </summary>
    public class clsProduct
    {
        //Atributes

        private int prod_codsec;
        private int prod_fkProductType;
        private string prod_ProductTypeName;
        private int prod_fkBopp;
        private clsBopp prod_Bopp;
        private string prod_boppFilmName;//New
        private string prod_boppCode;//New
        private int prod_fkCast;
        private clsCast prod_Cast;
        private string prod_castFilmName;//New
        private string prod_castCode;//New
        private int prod_fkCoating;
        private clsCoating prod_Coating;
        private string prod_coatingFilmName;//New
        private string prod_coatingCode;//New
        private int prod_fkThermoformed;
        private string prod_ThermoformedName;
        private string prod_ThermoformedCode;//New
        private int prod_fkColor; //New
        private string prod_colorName; //New
        private int prod_fkOunce; //New
        private double prod_ounceValue; //New
        private double prod_gramsperunit; //New
        private int prod_fkReprocessed;
        private string prod_ReprocessedName;
        private int prod_fkCore;
        private string prod_CoreName;
        private int prod_CoreValue;
        private int prod_fkDiameter;
        private string prod_DiameterName; //New
        private string prod_DiameterAbbreviation;
        private double prod_DiameterValue;
        private int prod_fkUnit;
        private string prod_UnitName;
        private string prod_UnitSymbol;
        private int prod_fkStatus;
        private string prod_StatusName;
        private string prod_name;
        private string prod_description;
        private string prod_code;
        private string prod_systemCode;
        private double prod_value;
        private double prod_width;
        private string prod_color;
        private Boolean prod_isLocalProduct;
        private DateTime prod_createdDate;
        private DateTime prod_modifiedDate;
        private int prod_createdBy;
        private string prod_creatorUser;
        private int prod_modifiedBy;
        private string prod_modificatorUser;
        private double prod_weigthInCoilCellar;

        private bool prod_castisNylon;

        public bool castisNylon
        {
            get { return prod_castisNylon; }
            set { prod_castisNylon = value; }
        }


        //Properties

        public int codsec { get { return prod_codsec; } set { prod_codsec = value; } }

        public int fkProductType { get { return prod_fkProductType; } set { prod_fkProductType = value; } }

        public string ProductTypeName { get { return prod_ProductTypeName; } set { prod_ProductTypeName = value; } }

        public int fkBopp { get { return prod_fkBopp; } set { prod_fkBopp = value; } }

        public clsBopp Bopp { get { return prod_Bopp; } set { prod_Bopp = value; } }

        public int fkCast { get { return prod_fkCast; } set { prod_fkCast = value; } }

        public clsCast Cast { get { return prod_Cast; } set { prod_Cast = value; } }

        public int fkCoating { get { return prod_fkCoating; } set { prod_fkCoating = value; } }

        public clsCoating Coating { get { return prod_Coating; } set { prod_Coating = value; } }

        public int fkThermoformed { get { return prod_fkThermoformed; } set { prod_fkThermoformed = value; } }

        public string ThermoformedName { get { return prod_ThermoformedName; } set { prod_ThermoformedName = value; } }

        public string ThermoformedCode { get { return prod_ThermoformedCode; } set { prod_ThermoformedCode = value; } }

        public int fkColor { get { return prod_fkColor; } set { prod_fkColor = value; } }

        public string colorName { get { return prod_colorName; } set { prod_colorName = value; } }

        public int fkOunce { get { return prod_fkOunce; } set { prod_fkOunce = value; } }

        public double ounceValue { get { return prod_ounceValue; } set { prod_ounceValue = value; } }

        public double gramsperunit { get { return prod_gramsperunit; } set { prod_gramsperunit = value; } }

        public int fkReprocessed { get { return prod_fkReprocessed; } set { prod_fkReprocessed = value; } }

        public string ReprocessedName { get { return prod_ReprocessedName; } set { prod_ReprocessedName = value; } }

        public int fkCore { get { return prod_fkCore; } set { prod_fkCore = value; } }

        public string CoreName { get { return prod_CoreName; } set { prod_CoreName = value; } }

        public int CoreValue { get { return prod_CoreValue; } set { prod_CoreValue = value; } }

        public int fkDiameter { get { return prod_fkDiameter; } set { prod_fkDiameter = value; } }

        public string DiameterAbbreviation { get { return prod_DiameterAbbreviation; } set { prod_DiameterAbbreviation = value; } }

        public double DiameterValue { get { return prod_DiameterValue; } set { prod_DiameterValue = value; } }

        public int fkUnit { get { return prod_fkUnit; } set { prod_fkUnit = value; } }

        public string UnitName { get { return prod_UnitName; } set { prod_UnitName = value; } }

        public string UnitSymbol { get { return prod_UnitSymbol; } set { prod_UnitSymbol = value; } }

        public int fkStatus { get { return prod_fkStatus; } set { prod_fkStatus = value; } }

        public string StatusName { get { return prod_StatusName; } set { prod_StatusName = value; } }

        public string name { get { return prod_name; } set { prod_name = value; } }

        public string description { get { return prod_description; } set { prod_description = value; } }

        public string code { get { return prod_code; } set { prod_code = value; } }

        public string systemCode { get { return prod_systemCode; } set { prod_systemCode = value; } }

        public double value { get { return prod_value; } set { prod_value = value; } }

        public double width { get { return prod_width; } set { prod_width = value; } }

        public string color { get { return prod_color; } set { prod_color = value; } }

        public Boolean isLocalProduct { get { return prod_isLocalProduct; } set { prod_isLocalProduct = value; } }

        public DateTime createdDate { get { return prod_createdDate; } set { prod_createdDate = value; } }

        public DateTime modifiedDate { get { return prod_modifiedDate; } set { prod_modifiedDate = value; } }

        public int createdBy { get { return prod_createdBy; } set { prod_createdBy = value; } }

        public string creatorUser { get { return prod_creatorUser; } set { prod_creatorUser = value; } }

        public int modifiedBy { get { return prod_modifiedBy; } set { prod_modifiedBy = value; } }

        public string modificatorUser { get { return prod_modificatorUser; } set { prod_modificatorUser = value; } }

        public string boppFilmName { get { return prod_boppFilmName; } set { prod_boppFilmName = value; } }

        public string boppCode { get { return prod_boppCode; } set { prod_boppCode = value; } }

        public string castFilmName { get { return prod_castFilmName; } set { prod_castFilmName = value; } }

        public string castCode { get { return prod_castCode; } set { prod_castCode = value; } }

        public string coatingFilmName { get { return prod_coatingFilmName; } set { prod_coatingFilmName = value; } }

        public string coatingCode { get { return prod_coatingCode; } set { prod_coatingCode = value; } }

        public string diameterName { get { return prod_DiameterName; } set { prod_DiameterName = value; } }

        public double weigthInCoilCellar { get { return prod_weigthInCoilCellar; } set { prod_weigthInCoilCellar = value; } }

        //Constructor

        public clsProduct()
        {
            prod_codsec = 0;
            prod_fkProductType = 0;
            prod_ProductTypeName = "";
            prod_fkBopp = 0;
            prod_Bopp = new clsBopp();
            prod_boppFilmName = "";
            prod_boppCode = "";
            prod_fkCast = 0;
            prod_Cast = new clsCast();
            prod_castFilmName = "";
            prod_castCode = "";
            prod_fkCoating = 0;
            prod_Coating = new clsCoating();
            prod_coatingFilmName = "";
            prod_coatingCode = "";
            prod_fkThermoformed = 0;
            prod_ThermoformedName = "";
            prod_ThermoformedCode = "";
            prod_fkColor = 0;
            prod_colorName = "";
            prod_fkOunce = 0;
            prod_ounceValue = 0;
            prod_gramsperunit = 0;
            prod_fkReprocessed = 0;
            prod_ReprocessedName = "";
            prod_fkCore = 0;
            prod_CoreName = "";
            prod_CoreValue = 0;
            prod_fkDiameter = 0;
            prod_DiameterName = "";
            prod_DiameterAbbreviation = "";
            prod_DiameterValue = 0;
            prod_fkUnit = 0;
            prod_UnitName = "";
            prod_UnitSymbol = "";
            prod_fkStatus = 0;
            prod_StatusName = "";
            prod_name = "";
            prod_description = "";
            prod_code = "";
            prod_systemCode = "";
            prod_value = 0;
            prod_width = 0;
            prod_color = "";
            prod_isLocalProduct = false;
            prod_createdDate = DateTime.Now;
            prod_modifiedDate = DateTime.Now;
            prod_createdBy = 0;
            prod_creatorUser = "";
            prod_modifiedBy = 0;
            prod_modificatorUser = "";
            prod_weigthInCoilCellar = 0;
        }

        public clsProduct(int codsec)
        {
            this.load(codsec);
        }
        public clsProduct(int codsec, bool simple)
        {
            this.load(codsec, true);
        }
        public clsProduct(string code)
        {
            this.load(code);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spProduct " + codsec.ToString() + "");
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
                this.fkProductType = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkProductType"]);
                this.ProductTypeName = DS.Tables[0].Rows[0]["prod_ProductTypeName"].ToString();
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]);
                this.Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]));
                this.boppFilmName = DS.Tables[0].Rows[0]["prod_boppFilmName"].ToString();
                this.boppCode = DS.Tables[0].Rows[0]["prod_boppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]);
                this.Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]));
                this.castFilmName = DS.Tables[0].Rows[0]["prod_CastFilmName"].ToString();
                this.castCode = DS.Tables[0].Rows[0]["prod_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]);
                this.Coating = new clsCoating(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]));
                this.coatingFilmName = DS.Tables[0].Rows[0]["prod_CoatingFilmName"].ToString();
                this.coatingCode = DS.Tables[0].Rows[0]["prod_CoatingCode"].ToString();
                this.fkThermoformed = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkThermoformed"]);
                this.ThermoformedName = DS.Tables[0].Rows[0]["prod_ThermoformedName"].ToString();
                this.ThermoformedCode = DS.Tables[0].Rows[0]["prod_ThermoformedCode"].ToString();
                this.fkColor = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkColor"]);
                this.colorName = DS.Tables[0].Rows[0]["prod_colorName"].ToString();
                this.fkOunce = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkOunce"]);
                this.ounceValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_ounceValue"]);
                this.gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_gramsperunit"]);
                this.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCore"]);
                this.CoreName = DS.Tables[0].Rows[0]["prod_CoreName"].ToString();
                this.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_CoreValue"]);
                this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkDiameter"]);
                this.diameterName = DS.Tables[0].Rows[0]["prod_diameterName"].ToString();
                this.DiameterAbbreviation = DS.Tables[0].Rows[0]["prod_DiameterAbbreviation"].ToString();
                this.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_DiameterValue"]);
                this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkUnit"]);
                this.UnitName = DS.Tables[0].Rows[0]["prod_UnitName"].ToString();
                this.UnitSymbol = DS.Tables[0].Rows[0]["prod_UnitSymbol"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["prod_StatusName"].ToString();
                this.name = DS.Tables[0].Rows[0]["prod_name"].ToString();
                this.description = DS.Tables[0].Rows[0]["prod_description"].ToString();
                this.code = DS.Tables[0].Rows[0]["prod_code"].ToString();
                this.systemCode = DS.Tables[0].Rows[0]["prod_systemCode"].ToString();
                this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_value"]);
                this.width = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_width"]);
                this.color = DS.Tables[0].Rows[0]["prod_color"].ToString();
                this.isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["prod_isLocalProduct"], DS.Tables[0].Rows[0]["prod_isLocalProduct"].GetType().FullName);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["prod_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["prod_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["prod_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["prod_modificatorUser"].ToString();
            }
        }
        public void load(int codsec, bool simplified)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProduct( " + codsec.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
                this.fkProductType = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkProductType"]);
                this.ProductTypeName = DS.Tables[0].Rows[0]["prod_ProductTypeName"].ToString();
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]);
                this.boppFilmName = DS.Tables[0].Rows[0]["prod_boppFilmName"].ToString();
                this.boppCode = DS.Tables[0].Rows[0]["prod_boppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]);
                this.castFilmName = DS.Tables[0].Rows[0]["prod_CastFilmName"].ToString();
                this.castCode = DS.Tables[0].Rows[0]["prod_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]);
                this.coatingFilmName = DS.Tables[0].Rows[0]["prod_CoatingFilmName"].ToString();
                this.coatingCode = DS.Tables[0].Rows[0]["prod_CoatingCode"].ToString();
                this.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCore"]);
                this.CoreName = DS.Tables[0].Rows[0]["prod_CoreName"].ToString();
                this.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_CoreValue"]);
                this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkDiameter"]);
                this.diameterName = DS.Tables[0].Rows[0]["prod_diameterName"].ToString();
                this.DiameterAbbreviation = DS.Tables[0].Rows[0]["prod_DiameterAbbreviation"].ToString();
                this.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_DiameterValue"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["prod_StatusName"].ToString();
                this.name = DS.Tables[0].Rows[0]["prod_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["prod_code"].ToString();
                this.systemCode = DS.Tables[0].Rows[0]["prod_systemCode"].ToString();
                this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_value"]);
                this.width = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_width"]);
                if (simplified == false)
                {
                    this.Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]));
                    this.Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]));
                    this.Coating = new clsCoating(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]));
                    this.fkThermoformed = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkThermoformed"]);
                    this.ThermoformedName = DS.Tables[0].Rows[0]["prod_ThermoformedName"].ToString();
                    this.ThermoformedCode = DS.Tables[0].Rows[0]["prod_ThermoformedCode"].ToString();
                    this.fkColor = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkColor"]);
                    this.colorName = DS.Tables[0].Rows[0]["prod_colorName"].ToString();
                    this.fkOunce = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkOunce"]);
                    this.ounceValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_ounceValue"]);
                    this.gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_gramsperunit"]);
                    this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkUnit"]);
                    this.UnitName = DS.Tables[0].Rows[0]["prod_UnitName"].ToString();
                    this.UnitSymbol = DS.Tables[0].Rows[0]["prod_UnitSymbol"].ToString();
                    this.description = DS.Tables[0].Rows[0]["prod_description"].ToString();
                    this.color = DS.Tables[0].Rows[0]["prod_color"].ToString();
                    this.isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["prod_isLocalProduct"], DS.Tables[0].Rows[0]["prod_isLocalProduct"].GetType().FullName);
                    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["prod_createdDate"]);
                    this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["prod_modifiedDate"]);
                    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_createdBy"]);
                    this.creatorUser = DS.Tables[0].Rows[0]["prod_creatorUser"].ToString();
                    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_modifiedBy"]);
                    this.modificatorUser = DS.Tables[0].Rows[0]["prod_modificatorUser"].ToString();
                }
            }
        }

        public void load(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductByCode( " + code.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
                this.fkProductType = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkProductType"]);
                this.ProductTypeName = DS.Tables[0].Rows[0]["prod_ProductTypeName"].ToString();
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]);
                this.Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]));
                this.boppFilmName = DS.Tables[0].Rows[0]["prod_boppFilmName"].ToString();
                this.boppCode = DS.Tables[0].Rows[0]["prod_boppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]);
                this.castFilmName = DS.Tables[0].Rows[0]["prod_CastFilmName"].ToString();
                this.castCode = DS.Tables[0].Rows[0]["prod_CastCode"].ToString();
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]);
                this.coatingFilmName = DS.Tables[0].Rows[0]["prod_CoatingFilmName"].ToString();
                this.coatingCode = DS.Tables[0].Rows[0]["prod_CoatingCode"].ToString();
                this.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCore"]);
                this.CoreName = DS.Tables[0].Rows[0]["prod_CoreName"].ToString();
                this.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_CoreValue"]);
                this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkDiameter"]);
                this.diameterName = DS.Tables[0].Rows[0]["prod_diameterName"].ToString();
                this.DiameterAbbreviation = DS.Tables[0].Rows[0]["prod_DiameterAbbreviation"].ToString();
                this.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_DiameterValue"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["prod_StatusName"].ToString();
                this.name = DS.Tables[0].Rows[0]["prod_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["prod_code"].ToString();
                this.systemCode = DS.Tables[0].Rows[0]["prod_systemCode"].ToString();
                this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_value"]);
                this.width = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_width"]);
            }
        }

        //public void checkProductMaquile(string code)
        //{
        //    DataSet DS = new DataSet();

        //    DS = clsConnection.getDataSetResult("CALL spProductByCode( " + code.ToString() + ")");
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
        //        this.fkProductType = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkProductType"]);
        //        this.ProductTypeName = DS.Tables[0].Rows[0]["prod_ProductTypeName"].ToString();
        //        this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkBopp"]);
        //        this.boppFilmName = DS.Tables[0].Rows[0]["prod_boppFilmName"].ToString();
        //        this.boppCode = DS.Tables[0].Rows[0]["prod_boppCode"].ToString();
        //        this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCast"]);
        //        this.castFilmName = DS.Tables[0].Rows[0]["prod_CastFilmName"].ToString();
        //        this.castCode = DS.Tables[0].Rows[0]["prod_CastCode"].ToString();
        //        this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCoating"]);
        //        this.coatingFilmName = DS.Tables[0].Rows[0]["prod_CoatingFilmName"].ToString();
        //        this.coatingCode = DS.Tables[0].Rows[0]["prod_CoatingCode"].ToString();
        //        this.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkCore"]);
        //        this.CoreName = DS.Tables[0].Rows[0]["prod_CoreName"].ToString();
        //        this.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_CoreValue"]);
        //        this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkDiameter"]);
        //        this.diameterName = DS.Tables[0].Rows[0]["prod_diameterName"].ToString();
        //        this.DiameterAbbreviation = DS.Tables[0].Rows[0]["prod_DiameterAbbreviation"].ToString();
        //        this.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_DiameterValue"]);
        //        this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["prod_fkStatus"]);
        //        this.StatusName = DS.Tables[0].Rows[0]["prod_StatusName"].ToString();
        //        this.name = DS.Tables[0].Rows[0]["prod_name"].ToString();
        //        this.code = DS.Tables[0].Rows[0]["prod_code"].ToString();
        //        this.systemCode = DS.Tables[0].Rows[0]["prod_systemCode"].ToString();
        //        this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_value"]);
        //        this.width = Convert.ToDouble(DS.Tables[0].Rows[0]["prod_width"]);
        //    }
        //}

        public bool save(string productType)
        {
            try
            {
                string queryString = "";

                DataSet DS1 = new DataSet();

                DS1 = clsConnection.getDataSetResult("SELECT  ptype_codsec FROM bps_prod_producttype WHERE ptype_name = '" + productType.ToUpper() + "'");

                this.prod_fkProductType = Convert.ToInt32(DS1.Tables[0].Rows[0]["ptype_codsec"].ToString());

                switch (productType)
                {
                    case "Bopp":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_product (prod_fkProductType,prod_fkBopp,prod_fkCore,prod_fkDiameter,prod_fkUnit,prod_fkStatus,prod_name,prod_description,prod_code,prod_systemCode,prod_value,prod_width,prod_color,prod_isLocalProduct,prod_createdDate,prod_modifiedDate,prod_createdBy,prod_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += this.prod_fkProductType.ToString() + ",";
                            queryString += this.prod_fkBopp + ",";
                            queryString += this.prod_fkCore.ToString() + ",";
                            queryString += this.prod_fkDiameter.ToString() + ",";
                            queryString += this.prod_fkUnit.ToString() + ",";
                            queryString += this.prod_fkStatus.ToString() + ",";
                            queryString += "'" + this.name + "',";
                            queryString += "'" + this.description + "',";
                            queryString += "'" + this.code + "',";
                            queryString += "'" + this.systemCode + "',";
                            queryString += "'" + this.value.ToString() + "',";
                            queryString += "'" + this.width.ToString() + "',";
                            queryString += "'" + this.color + "',";
                            queryString += "'" + this.isLocalProduct.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += clsGlobal.LoggedUser.codsec.ToString();
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_product";
                            queryString += " SET ";
                            queryString += "prod_fkProductType = " + this.fkProductType.ToString() + ",";
                            queryString += "prod_fkBopp = " + this.fkBopp + ",";
                            queryString += "prod_fkCore = " + this.fkCore.ToString() + ",";
                            queryString += "prod_fkDiameter = " + this.fkDiameter.ToString() + ",";
                            queryString += "prod_fkUnit = " + this.fkUnit.ToString() + ",";
                            queryString += "prod_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += "prod_name = '" + this.name.ToString() + "',";
                            queryString += "prod_description = '" + this.description.ToString() + "',";
                            queryString += "prod_code = '" + this.code.ToString() + "',";
                            queryString += "prod_systemCode = '" + this.systemCode.ToString() + "',";
                            queryString += "prod_value = " + this.value.ToString() + ",";
                            queryString += "prod_width = " + this.width.ToString() + ",";
                            queryString += "prod_color = '" + this.color + "',";
                            queryString += "prod_isLocalProduct = " + this.isLocalProduct + ",";
                            queryString += "prod_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "prod_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                            queryString += " WHERE prod_codsec = " + this.codsec.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;
                    case "Cast":

                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_product (prod_fkProductType,prod_fkCast,prod_fkCore,prod_fkDiameter,prod_fkUnit,prod_fkStatus,prod_name,prod_description,prod_code,prod_systemCode,prod_value,prod_width,prod_color,prod_isLocalProduct,prod_createdDate,prod_modifiedDate,prod_createdBy,prod_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += this.prod_fkProductType.ToString() + ",";
                            queryString += this.prod_fkCast + ",";
                            queryString += this.prod_fkCore.ToString() + ",";
                            queryString += this.prod_fkDiameter.ToString() + ",";
                            queryString += this.prod_fkUnit.ToString() + ",";
                            queryString += this.prod_fkStatus.ToString() + ",";
                            queryString += "'" + this.name + "',";
                            queryString += "'" + this.description + "',";
                            queryString += "'" + this.code + "',";
                            queryString += "'" + this.systemCode + "',";
                            queryString += "'" + this.value.ToString() + "',";
                            queryString += "'" + this.width.ToString() + "',";
                            queryString += "'" + this.color + "',";
                            queryString += "'" + this.isLocalProduct.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += clsGlobal.LoggedUser.codsec.ToString();
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_product";
                            queryString += " SET ";
                            queryString += "prod_fkProductType = " + this.fkProductType.ToString() + ",";
                            queryString += "prod_fkCast = " + this.fkCast + ",";
                            queryString += "prod_fkCore = " + this.fkCore.ToString() + ",";
                            queryString += "prod_fkDiameter = " + this.fkDiameter.ToString() + ",";
                            queryString += "prod_fkUnit = " + this.fkUnit.ToString() + ",";
                            queryString += "prod_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += "prod_name = '" + this.name.ToString() + "',";
                            queryString += "prod_description = '" + this.description.ToString() + "',";
                            queryString += "prod_code = '" + this.code.ToString() + "',";
                            queryString += "prod_systemCode = '" + this.systemCode.ToString() + "',";
                            queryString += "prod_value = " + this.value.ToString() + ",";
                            queryString += "prod_width = " + this.width.ToString() + ",";
                            queryString += "prod_color = '" + this.color + "',";
                            queryString += "prod_isLocalProduct = " + this.isLocalProduct + ",";
                            queryString += "prod_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "prod_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                            queryString += " WHERE prod_codsec = " + this.codsec.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }

                        break;
                    case "Coating":

                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_product (prod_fkProductType,prod_fkCoating,prod_fkCore,prod_fkDiameter,prod_fkUnit,prod_fkStatus,prod_name,prod_description,prod_code,prod_systemCode,prod_value,prod_width,prod_color,prod_isLocalProduct,prod_createdDate,prod_modifiedDate,prod_createdBy,prod_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += this.prod_fkProductType.ToString() + ",";
                            queryString += this.prod_fkCoating + ",";
                            queryString += this.prod_fkCore.ToString() + ",";
                            queryString += this.prod_fkDiameter.ToString() + ",";
                            queryString += this.prod_fkUnit.ToString() + ",";
                            queryString += this.prod_fkStatus.ToString() + ",";
                            queryString += "'" + this.name + "',";
                            queryString += "'" + this.description + "',";
                            queryString += "'" + this.code + "',";
                            queryString += "'" + this.systemCode + "',";
                            queryString += "'" + this.value.ToString() + "',";
                            queryString += "'" + this.width.ToString() + "',";
                            queryString += "'" + this.color + "',";
                            queryString += "'" + this.isLocalProduct.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += clsGlobal.LoggedUser.codsec.ToString();
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_product";
                            queryString += " SET ";
                            queryString += "prod_fkProductType = " + this.fkProductType.ToString() + ",";
                            queryString += "prod_fkCast = " + this.fkCoating + ",";
                            queryString += "prod_fkCore = " + this.fkCore.ToString() + ",";
                            queryString += "prod_fkDiameter = " + this.fkDiameter.ToString() + ",";
                            queryString += "prod_fkUnit = " + this.fkUnit.ToString() + ",";
                            queryString += "prod_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += "prod_name = '" + this.name.ToString() + "',";
                            queryString += "prod_description = '" + this.description.ToString() + "',";
                            queryString += "prod_code = '" + this.code.ToString() + "',";
                            queryString += "prod_systemCode = '" + this.systemCode.ToString() + "',";
                            queryString += "prod_value = " + this.value.ToString() + ",";
                            queryString += "prod_width = " + this.width.ToString() + ",";
                            queryString += "prod_color = '" + this.color + "',";
                            queryString += "prod_isLocalProduct = " + this.isLocalProduct + ",";
                            queryString += "prod_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "prod_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                            queryString += " WHERE prod_codsec = " + this.codsec.ToString() + ";";
                            clsConnection.executeQuery(queryString);
                        }

                        break;
                    case "Nylon":

                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_product (prod_fkProductType,prod_fkCast,prod_fkCore,prod_fkDiameter,prod_fkUnit,prod_fkStatus,prod_name,prod_description,prod_code,prod_systemCode,prod_value,prod_width,prod_color,prod_isLocalProduct,prod_createdDate,prod_modifiedDate,prod_createdBy,prod_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += this.prod_fkProductType.ToString() + ",";
                            queryString += this.prod_fkCast + ",";
                            queryString += this.prod_fkCore.ToString() + ",";
                            queryString += this.prod_fkDiameter.ToString() + ",";
                            queryString += this.prod_fkUnit.ToString() + ",";
                            queryString += this.prod_fkStatus.ToString() + ",";
                            queryString += "'" + this.name + "',";
                            queryString += "'" + this.description + "',";
                            queryString += "'" + this.code + "',";
                            queryString += "'" + this.systemCode + "',";
                            queryString += "'" + this.value.ToString() + "',";
                            queryString += "'" + this.width.ToString() + "',";
                            queryString += "'" + this.color + "',";
                            queryString += "'" + this.isLocalProduct.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += clsGlobal.LoggedUser.codsec.ToString();
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_product";
                            queryString += " SET ";
                            queryString += "prod_fkProductType = " + this.fkProductType.ToString() + ",";
                            queryString += "prod_fkCast = " + this.fkCast + ",";
                            queryString += "prod_fkCore = " + this.fkCore.ToString() + ",";
                            queryString += "prod_fkDiameter = " + this.fkDiameter.ToString() + ",";
                            queryString += "prod_fkUnit = " + this.fkUnit.ToString() + ",";
                            queryString += "prod_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += "prod_name = '" + this.name.ToString() + "',";
                            queryString += "prod_description = '" + this.description.ToString() + "',";
                            queryString += "prod_code = '" + this.code.ToString() + "',";
                            queryString += "prod_systemCode = '" + this.systemCode.ToString() + "',";
                            queryString += "prod_value = " + this.value.ToString() + ",";
                            queryString += "prod_width = " + this.width.ToString() + ",";
                            queryString += "prod_color = '" + this.color + "',";
                            queryString += "prod_isLocalProduct = " + this.isLocalProduct + ",";
                            queryString += "prod_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "prod_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                            queryString += " WHERE prod_codsec = " + this.codsec.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }

                        break;
                    case "Termoformado":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_product (prod_fkProductType,prod_fkThermoformed,prod_fkUnit,prod_fkStatus,prod_name,prod_description,prod_code,prod_systemCode,prod_value,prod_createdDate,prod_modifiedDate,prod_createdBy,prod_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += this.prod_fkProductType.ToString() + ",";
                            queryString += this.prod_fkThermoformed + ",";
                            queryString += this.prod_fkUnit.ToString() + ",";
                            queryString += this.prod_fkStatus.ToString() + ",";
                            queryString += "'" + this.name + "',";
                            queryString += "'" + this.description + "',";
                            queryString += "'" + this.code + "',";
                            queryString += "'" + this.systemCode + "',";
                            queryString += "'" + this.value.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += clsGlobal.LoggedUser.codsec.ToString();
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_product";
                            queryString += " SET ";
                            queryString += "prod_fkProductType = " + this.fkProductType.ToString() + ",";
                            queryString += "prod_fkThermoformed = " + this.fkThermoformed + ",";
                            queryString += "prod_fkUnit = " + this.fkUnit.ToString() + ",";
                            queryString += "prod_fkStatus = " + this.fkStatus.ToString() + ",";
                            queryString += "prod_name = '" + this.name.ToString() + "',";
                            queryString += "prod_description = '" + this.description.ToString() + "',";
                            queryString += "prod_code = '" + this.code.ToString() + "',";
                            queryString += "prod_systemCode = '" + this.systemCode.ToString() + "',";
                            queryString += "prod_value = " + this.value.ToString() + ",";
                            queryString += "prod_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "prod_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                            queryString += " WHERE prod_codsec = " + this.codsec.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }

                        break;
                    case "Reprocessed":
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProduct.save");
                return false;
            }

        }

        public static List<clsProduct> getBoppProductList()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsBoppFilm()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static List<clsProduct> getBoppProductListByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spBoppProductListByCode('" + code + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        public static List<clsProduct> getListByBopp(int codsec)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_fkBopp = " + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
            }

            return lstProduct;
        }

        public static List<clsProduct> getListByCast(int codsec)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_fkCast = " + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
            }

            return lstProduct;
        }
        // Para que funcione este spProductsBoppMetalFilm el familia y subfamilia de cast el metalizado debe tener el id = 6 y el ancho sera menor o igual a la base seleccionada

        public static List<clsProduct> getBoppMetalProductList(int widthProduct, int thicknessProduct)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsBoppMetalFilm('" + widthProduct + "','" + thicknessProduct + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        //nuevo
        public static List<clsProduct> getBoppMetalProductListByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsBoppMetalFilmByCode('" + code + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        //fin


        public static List<clsProduct> getBoppProductListByCoilCellar(int coilCellarCodsec)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductByCoilAndCoilCellar(" + coilCellarCodsec.ToString() + ")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
                lstProduct[i].weigthInCoilCellar = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_totalCoilWeigth"]);
            }

            return lstProduct;
        }
        public static List<clsProduct> getBoppProductListForSecundaryCut(int coilCellarCodsec)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductByCoilAndCoilCellar(" + coilCellarCodsec.ToString() + ")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
                lstProduct[i].weigthInCoilCellar = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_totalCoilWeigth"]);
            }

            return lstProduct;
        }
        public static List<clsProduct> getCastProductListForSecundaryCut(int coilCellarCodsec)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductByCoilAndCoilCellar(" + coilCellarCodsec.ToString() + ")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
                lstProduct[i].weigthInCoilCellar = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_totalCoilWeigth"]);
            }

            return lstProduct;
        }


        public static List<clsProduct> getBoppProductListisBase()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductisBase()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);

            }

            return lstProduct;
        }

        public static List<clsProduct> getBoppProductListisBaseByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductisBaseByCode('" + code + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
            }
            return lstProduct;
        }


        public static List<clsProduct> getCastProductListByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsCastFilmByCode('" + code + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }


        public static List<clsProduct> getBoppProductListByFilter(List<clsFilter> lstFilter)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT TOP(100) * FROM vwProduct WHERE prod_fkBopp > 0 " + where + " ORDER BY prod_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        public static List<clsProduct> getBoppProductListByFilterCast(List<clsFilter> lstFilter)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProduct WHERE " + where + " ORDER BY prod_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        public static List<clsProduct> getCastProductList()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsCastFilm()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        // Para que funcione este spProductsCastMetalFilm el Proceso y subproceso de cast el metalizado debe tener el id = 4
        public static List<clsProduct> getCastProductMetalList()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsCastMetalFilm()");


            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        //nuevo
        public static List<clsProduct> getCastProductMetalListByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductsCastMetalFilmByCode('" + code + "')");


            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        //fin
        public static List<clsProduct> getCastProductListByFilter(List<clsFilter> lstFilter)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT TOP(100) * FROM vwProduct WHERE prod_fkCast > 0 " + where + " ORDER BY prod_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
                lstProduct[i].castisNylon = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_castisNylon"], DS.Tables[0].Rows[i]["prod_castisNylon"].GetType().FullName);
            }

            return lstProduct;
        }
        public static List<clsProduct> getCoatProductList()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProduct WHERE prod_fkCoating > 0 ORDER BY prod_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }
            return lstProduct;
        }
        public static List<clsProduct> getCoatProductListByFilter(List<clsFilter> lstFilter)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProduct WHERE prod_fkCoating > 0 " + where + " ORDER BY prod_name");


            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }
            return lstProduct;
        }

        public static List<clsProduct> getThermoformedProductList()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProduct WHERE prod_fkThermoformed > 0");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkThermoformed = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkThermoformed"]);
                lstProduct[i].ThermoformedName = DS.Tables[0].Rows[i]["prod_ThermoformedName"].ToString();
                lstProduct[i].ThermoformedCode = DS.Tables[0].Rows[i]["prod_ThermoformedCode"].ToString();
                lstProduct[i].fkColor = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkColor"]);
                lstProduct[i].colorName = DS.Tables[0].Rows[i]["prod_colorName"].ToString();
                lstProduct[i].fkColor = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkOunce"]);
                lstProduct[i].ounceValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_ounceValue"]);
                lstProduct[i].gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_gramsperunit"]);
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        public static List<clsProduct> getThermoformedProductListByFilter(List<clsFilter> lstFilter)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProduct WHERE prod_fkThermoformed > 0 " + where + " ORDER BY prod_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkThermoformed = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkThermoformed"]);
                lstProduct[i].ThermoformedName = DS.Tables[0].Rows[i]["prod_ThermoformedName"].ToString();
                lstProduct[i].ThermoformedCode = DS.Tables[0].Rows[i]["prod_ThermoformedCode"].ToString();
                lstProduct[i].fkColor = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkColor"]);
                lstProduct[i].colorName = DS.Tables[0].Rows[i]["prod_colorName"].ToString();
                lstProduct[i].fkColor = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkOunce"]);
                lstProduct[i].ounceValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_ounceValue"]);
                lstProduct[i].gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_gramsperunit"]);
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static List<clsProduct> getBoppProductListInActiveSalesOrder()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spBoppProductListInActiveSalesOrder()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static List<clsProduct> getBoppProductListInActiveSalesOrderByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spBoppProductListInActiveSalesOrderByCode('" + code + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static List<clsProduct> getCastProductListInActiveSalesOrder()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastProductListInActiveSalesOrder()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static List<clsProduct> getCastProductListInActiveSalesOrderByCode(string code)
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastProductListInActiveSalesOrderByCode('" + code + "')");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }

        public static List<clsProduct> getProductListInStock()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductListInStock()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].fkProductType = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkProductType"]);
                lstProduct[i].ProductTypeName = DS.Tables[0].Rows[i]["prod_ProductTypeName"].ToString();
                lstProduct[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkBopp"]);
                lstProduct[i].boppFilmName = DS.Tables[0].Rows[i]["prod_boppFilmName"].ToString();
                lstProduct[i].boppCode = DS.Tables[0].Rows[i]["prod_boppCode"].ToString();
                lstProduct[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCast"]);
                lstProduct[i].castFilmName = DS.Tables[0].Rows[i]["prod_CastFilmName"].ToString();
                lstProduct[i].castCode = DS.Tables[0].Rows[i]["prod_CastCode"].ToString();
                lstProduct[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCoating"]);
                lstProduct[i].coatingFilmName = DS.Tables[0].Rows[i]["prod_CoatingFilmName"].ToString();
                lstProduct[i].coatingCode = DS.Tables[0].Rows[i]["prod_CoatingCode"].ToString();
                lstProduct[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkCore"]);
                lstProduct[i].CoreName = DS.Tables[0].Rows[i]["prod_CoreName"].ToString();
                lstProduct[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_CoreValue"]);
                lstProduct[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkDiameter"]);
                lstProduct[i].diameterName = DS.Tables[0].Rows[i]["prod_diameterName"].ToString();
                lstProduct[i].DiameterAbbreviation = DS.Tables[0].Rows[i]["prod_DiameterAbbreviation"].ToString();
                lstProduct[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_DiameterValue"]);
                lstProduct[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkUnit"]);
                lstProduct[i].UnitName = DS.Tables[0].Rows[i]["prod_UnitName"].ToString();
                lstProduct[i].UnitSymbol = DS.Tables[0].Rows[i]["prod_UnitSymbol"].ToString();
                lstProduct[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_fkStatus"]);
                lstProduct[i].StatusName = DS.Tables[0].Rows[i]["prod_StatusName"].ToString();
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].description = DS.Tables[0].Rows[i]["prod_description"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstProduct[i].systemCode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
                lstProduct[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_value"]);
                lstProduct[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstProduct[i].color = DS.Tables[0].Rows[i]["prod_color"].ToString();
                lstProduct[i].isLocalProduct = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["prod_isLocalProduct"], DS.Tables[0].Rows[i]["prod_isLocalProduct"].GetType().FullName);
                lstProduct[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_createdDate"]);
                lstProduct[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prod_modifiedDate"]);
                lstProduct[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_createdBy"]);
                lstProduct[i].creatorUser = DS.Tables[0].Rows[i]["prod_creatorUser"].ToString();
                lstProduct[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_modifiedBy"]);
                lstProduct[i].modificatorUser = DS.Tables[0].Rows[i]["prod_modificatorUser"].ToString();
            }

            return lstProduct;
        }
        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT prod_codsec FROM bps_prod_product WHERE prod_createdBy = " + clsGlobal.LoggedUser.codsec + " Order By prod_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
        }
        public static string getExternalERPCode(clsProduct objProduct)
        {
            if (objProduct.fkBopp > 0)
                return objProduct.Bopp.externalID;
            else
                return objProduct.Cast.externalID;
        }

        public static string getExternalERPDescription(clsProduct objProduct)
        {
            if (objProduct.fkBopp > 0)
                return objProduct.Bopp.externalDescription + " " + Math.Round(objProduct.width, 0).ToString() + "MM";
            else
                return objProduct.Cast.externalDescription + " " + Math.Round(objProduct.width, 0).ToString() + "MM";
        }
        public static string getExternalERPDescriptionExternalCode(clsProduct objProduct)
        {
            if (objProduct.fkBopp > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkBopp = " + objProduct.fkBopp.ToString() + " AND feq_externalCode LIKE 'OPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + objProduct.fkCast.ToString() + " AND feq_externalCode LIKE 'OPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
        }

        public static string getExternalERPDescriptionExternalCode(int fkBopp, int fkCast)
        {
            if (fkBopp > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkBopp = " + fkBopp.ToString() + " AND feq_externalCode LIKE 'OPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + fkCast.ToString() + " AND feq_externalCode LIKE 'OPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
        }


        public static string getExternalERPDescriptionNationalCode(clsProduct objProduct)
        {
            if (objProduct.fkBopp > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkBopp = " + objProduct.fkBopp.ToString() + " AND feq_externalCode LIKE 'BOPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + objProduct.fkCast.ToString() + " AND feq_externalCode LIKE 'BOPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
        }

        public static string getExternalERPDescriptionNationalCode(int fkBopp, int fkCast)
        {
            if (fkBopp > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkBopp = " + fkBopp.ToString() + " AND feq_externalCode LIKE 'BOPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + fkCast.ToString() + " AND feq_externalCode LIKE 'BOPP%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
        }

        public static string getExternalERPDescriptionStockCode(clsProduct objProduct)
        {
            if (objProduct.fkBopp > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkBopp = " + objProduct.fkBopp.ToString() + " AND feq_externalCode LIKE 'PROC%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + objProduct.fkCast.ToString() + " AND feq_externalCode LIKE 'PROC%'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
        }

        public static int getExternalEquivalenceToSIIGO(string description, string productCode, string reference, string descriptionII, string micron)
        {
            int equivalenceBopp = 0;
            int equivalenceCast = 0;
            int Codsec = 0;

            if (micron != "-----")
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_externalId =" + productCode);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    if (DS.Tables[0].Rows[0]["feq_fkBopp"] != null)
                        equivalenceBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkBopp"].ToString());
                    else
                        equivalenceCast = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkCast"].ToString());

                    List<clsProduct> lstProduct = new List<clsProduct>();
                    if (equivalenceCast == 0)
                    {
                        lstProduct = clsProduct.getListByBopp(equivalenceBopp);
                        for (int i = 0; i < lstProduct.Count; i++)
                        {
                            if (lstProduct[i].width == Convert.ToDouble(micron))
                            {
                                Codsec = lstProduct[i].codsec;
                                break;
                            }
                            else
                                Codsec = 0;
                        }
                    }
                    else
                    {
                        lstProduct = clsProduct.getListByCast(equivalenceCast);
                        for (int i = 0; i < lstProduct.Count; i++)
                        {
                            if (lstProduct[i].width == Convert.ToDouble(micron))
                            {
                                Codsec = lstProduct[i].codsec;
                                break;
                            }
                            else
                                Codsec = 0;
                        }
                    }
                }
                else
                {
                    DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_externalDescription = '" + description + "'");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        if (DS.Tables[0].Rows[0]["feq_fkBopp"] != null)
                            equivalenceBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkBopp"].ToString());
                        else
                            equivalenceCast = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkCast"].ToString());

                        List<clsProduct> lstProduct = new List<clsProduct>();
                        if (equivalenceCast == 0)
                        {
                            lstProduct = clsProduct.getListByBopp(equivalenceBopp);
                            for (int i = 0; i < lstProduct.Count; i++)
                            {
                                if (lstProduct[i].width == Convert.ToDouble(micron))
                                {
                                    Codsec = lstProduct[i].codsec;
                                    break;
                                }
                                else
                                    Codsec = 0;
                            }
                        }
                        else
                        {
                            lstProduct = clsProduct.getListByCast(equivalenceCast);
                            for (int i = 0; i < lstProduct.Count; i++)
                            {
                                if (lstProduct[i].width == Convert.ToDouble(micron))
                                {
                                    Codsec = lstProduct[i].codsec;
                                    break;
                                }
                                else
                                    Codsec = 0;
                            }
                        }
                    }
                    else
                    {
                        DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_externalCode ='" + reference + "'");
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            if (DS.Tables[0].Rows[0]["feq_fkBopp"] != null)
                                equivalenceBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkBopp"].ToString());
                            else
                                equivalenceCast = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkCast"].ToString());

                            List<clsProduct> lstProduct = new List<clsProduct>();
                            if (equivalenceCast == 0)
                            {
                                lstProduct = clsProduct.getListByBopp(equivalenceBopp);
                                for (int i = 0; i < lstProduct.Count; i++)
                                {
                                    if (lstProduct[i].width == Convert.ToDouble(micron))
                                    {
                                        Codsec = lstProduct[i].codsec;
                                        break;
                                    }
                                    else
                                        Codsec = 0;
                                }
                            }
                            else
                            {
                                lstProduct = clsProduct.getListByCast(equivalenceCast);
                                for (int i = 0; i < lstProduct.Count; i++)
                                {
                                    if (lstProduct[i].width == Convert.ToDouble(micron))
                                    {
                                        Codsec = lstProduct[i].codsec;
                                        break;
                                    }
                                    else
                                        Codsec = 0;
                                }
                            }
                        }
                        else
                        {
                            DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_externalDescription ='" + descriptionII + "'");
                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                if (DS.Tables[0].Rows[0]["feq_fkBopp"] != null)
                                    equivalenceBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkBopp"].ToString());
                                else
                                    equivalenceCast = Convert.ToInt32(DS.Tables[0].Rows[0]["feq_fkCast"].ToString());

                                List<clsProduct> lstProduct = new List<clsProduct>();
                                if (equivalenceCast == 0)
                                {
                                    lstProduct = clsProduct.getListByBopp(equivalenceBopp);
                                    for (int i = 0; i < lstProduct.Count; i++)
                                    {
                                        if (lstProduct[i].width == Convert.ToDouble(micron))
                                        {
                                            Codsec = lstProduct[i].codsec;
                                            break;
                                        }
                                        else
                                            Codsec = 0;
                                    }
                                }
                                else
                                {
                                    lstProduct = clsProduct.getListByCast(equivalenceCast);
                                    for (int i = 0; i < lstProduct.Count; i++)
                                    {
                                        if (lstProduct[i].width == Convert.ToDouble(micron))
                                        {
                                            Codsec = lstProduct[i].codsec;
                                            break;
                                        }
                                        else
                                            Codsec = 0;
                                    }
                                }
                            }
                            else
                                Codsec = 0;
                        }
                    }
                }
            }
            else
                Codsec = 0;
            return Codsec;
        }

        public static string getMetalizeFormBaseFilm(int fkthickness, string film, int fkBopp)
        {
            try
            {
                string metalizeFilm = "";
                metalizeFilm = film.Replace("B", "M").Replace("g", "");
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_bopp WHERE bopp_fkThickness = " + fkthickness.ToString() + " AND bopp_code ='" + metalizeFilm + "'");
                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["bopp_code"].ToString();
                else
                    return "MA015";
            }
            catch (Exception)
            {
                return "NO REFERECNIA";
                throw;
            }
        }

        public static int getMetalizeFormBaseFilm(int fkcore, int fkdiameter, string ProductCode)
        {
            try
            {
                string metalizeFilm = "";

                if (ProductCode.StartsWith("BC"))
                    metalizeFilm = ProductCode.Replace("BC", "MC");
                else
                    if (ProductCode.StartsWith("BD"))
                        metalizeFilm = ProductCode.Replace("BD", "NH");
                    else
                        if (ProductCode.StartsWith("BF"))
                            metalizeFilm = ProductCode.Replace("BF", "NF");
                        else
                            metalizeFilm = ProductCode.Replace("B", "M").Replace("g", "");
                
                DataSet DS = new DataSet();
                DataSet DST = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_code = '" + metalizeFilm + "'");
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
                else
                {
                    DST = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_fkCore = " + fkcore.ToString() + " AND prod_fkDiameter = " + fkdiameter.ToString() + " prod_code = '" + ProductCode + "'");
                    if (DST.Tables[0].Rows.Count > 0)
                        return Convert.ToInt32(DST.Tables[0].Rows[0]["prod_codsec"]);
                    else
                        return 0;
                }
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public static int getMetalizeFormBaseFilmCodsec(int fkthickness, string film, int fkBopp)
        {
            try
            {
                string metalizeFilm = "";
                metalizeFilm = film.Replace("B", "M").Replace("g", "");
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_bopp WHERE bopp_fkThickness = " + fkthickness.ToString() + " AND bopp_code ='" + metalizeFilm + "'");
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_codsec"]);
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public static List<clsProduct> getListMetalProduct()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_code LIKE 'M%'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProduct.Add(new clsProduct());
                lstProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]);
                lstProduct[i].name = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstProduct[i].code = DS.Tables[0].Rows[i]["prod_code"].ToString();
            }

            return lstProduct;
        }

        public static bool toCheckProductMaquile(int fkCore, int fkDiameter, int Width, int fkBopp)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_fkBopp = " + fkBopp + " AND prod_fkCore = " + fkCore + " AND prod_fkDiameter = " + fkDiameter + " AND prod_width = " + Width);

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool toCheckProductMaquileMetalized(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static string maquileCode(int fkCore, int fkDiameter, int Width, int fkBopp)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_fkBopp = " + fkBopp + " AND prod_fkCore = " + fkCore + " AND prod_fkDiameter = " + fkDiameter + " AND prod_width = " + Width);

            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["prod_code"].ToString();
            else
                return "No";
        }

        public static int toCheckProductMaquileMetalizedCodsec(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT prod_codsec FROM bps_prod_product WHERE prod_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
            else
                return 0;
        }

        public static int toCheckProductMaquileCodsec(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT prod_codsec FROM bps_prod_product WHERE prod_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["prod_codsec"]);
            else
                return 0;
        }

        public static string getMaquileProductFrom(int fkproductFrom)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_codsec = " + fkproductFrom.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["prod_code"].ToString();
            else
                return "";
        }

        public static string getMaquileProductTo(int fkproductTo)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_codsec = " + fkproductTo.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["prod_code"].ToString();
            else
                return "";
        }


        public override string ToString()
        {
            return this.code.Replace("-", "") + this.name;
        }
    }
}
