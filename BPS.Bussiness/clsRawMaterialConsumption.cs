using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que adminisrta los consumo de Materias Primas  de la bodega de materias primas en produccion
    /// </summary>
    public class clsRawMaterialConsumption
    {

        //Atributes

        private int consm_codsec;
        private int consm_fkTransfer;
        private int consm_fkCellar;
        private int consm_fkRawMaterialByReception;
        private int consm_fkProductionOrder;
        private int consm_numberProductionOrder;
        private string consm_cellarName;
        private double consm_amountTransferred;
        private string consm_number;
        private DateTime consm_createdDate;
        private DateTime consm_modifiedDate;
        private int consm_createdBy;
        private string consm_creatorUser;
        private int consm_modifiedBy;
        private string consm_modificatorUser;
        private int consm_fkRawMaterialReception;
        private int consm_fkRawMaterialType;
        private string consm_RawMaterialTypeName;
        private int consm_fkRawMaterial;
        private string consm_RawMaterialName;
        private string consm_RawMaterialCode;
        private int consm_fkEntity;
        private string consm_EntityName;
        private int consm_availableUnits;
        private double consm_availableWeigth;
        private double consm_cost;
        private int consm_fkCurrency;
        private string consm_currencyName;
        private double consm_Quote;
        private int consm_unitsTransferred;
        private string consm_code;
        private double consm_unitWeigth;

        //Properties

        public int codsec { get { return consm_codsec; } set { consm_codsec = value; } }

        public int fkRawMaterialByReception { get { return consm_fkRawMaterialByReception; } set { consm_fkRawMaterialByReception = value; } } 

        public int fkTransfer { get { return consm_fkTransfer; } set { consm_fkTransfer = value; } }

        public int fkCellar { get { return consm_fkCellar; } set { consm_fkCellar = value; } }

        public int fkProductionOrder { get { return consm_fkProductionOrder; } set { consm_fkProductionOrder = value; } }

        public int numberProductionOrder { get { return consm_numberProductionOrder; } set { consm_numberProductionOrder = value; } }

        public double amountTransferred { get { return consm_amountTransferred; } set { consm_amountTransferred = value; } }

        public string number { get { return consm_number; } set { consm_number = value; } }

        public DateTime createdDate { get { return consm_createdDate; } set { consm_createdDate = value; } }

        public DateTime modifiedDate { get { return consm_modifiedDate; } set { consm_modifiedDate = value; } }

        public int createdBy { get { return consm_createdBy; } set { consm_createdBy = value; } }

        public string creatorUser { get { return consm_creatorUser; } set { consm_creatorUser = value; } }

        public int modifiedBy { get { return consm_modifiedBy; } set { consm_modifiedBy = value; } }

        public string modificatorUser { get { return consm_modificatorUser; } set { consm_modificatorUser = value; } }

        public int fkRawMaterialReception { get { return consm_fkRawMaterialReception; } set { consm_fkRawMaterialReception = value; } }

        public int fkRawMaterialType { get { return consm_fkRawMaterialType; } set { consm_fkRawMaterialType = value; } }

        public string rawMaterialTypeName { get { return consm_RawMaterialTypeName; } set { consm_RawMaterialTypeName = value; } }

        public int fkRawMaterial { get { return consm_fkRawMaterial; } set { consm_fkRawMaterial = value; } }

        public string rawMaterialName { get { return consm_RawMaterialName; } set { consm_RawMaterialName = value; } }

        public string rawMaterialCode { get { return consm_RawMaterialCode; } set { consm_RawMaterialCode = value; } }

        public int fkEntity { get { return consm_fkEntity; } set { consm_fkEntity = value; } }

        public string entityName { get { return consm_EntityName; } set { consm_EntityName = value; } }

        public int availableUnits { get { return consm_availableUnits; } set { consm_availableUnits = value; } }

        public double availableWeigth { get { return consm_availableWeigth; } set { consm_availableWeigth = value; } }

        public string cellarName { get { return consm_cellarName; } set { consm_cellarName = value; } }

        public double cost { get { return consm_cost; } set { consm_cost = value; } }

        public int fkCurrency { get { return consm_fkCurrency; } set { consm_fkCurrency = value; } }

        public string currencyName { get { return consm_currencyName; } set { consm_currencyName = value; } }

        public double Quote { get { return consm_Quote; } set { consm_Quote = value; } }

        public int unitsTransferred { get { return consm_unitsTransferred; } set { consm_unitsTransferred = value; } }

        public string code { get { return consm_code; } set { consm_code = value; } }

        public double unitWeigth { get { return consm_unitWeigth; } set { consm_unitWeigth = value; } }

        public string EntityName { get { return consm_EntityName; } set { consm_EntityName = value; } }

        //Constructor

        public clsRawMaterialConsumption()
        { 

        consm_codsec = 0;
        consm_fkTransfer = 0;
        consm_fkCellar = 0;
        consm_fkRawMaterialByReception = 0;
        consm_fkProductionOrder = 0;
        consm_numberProductionOrder = 0;
        consm_cellarName = "";
        consm_amountTransferred = 0;
        consm_number = "";
        consm_createdDate = DateTime.Now;
        consm_modifiedDate = DateTime.Now;
        consm_createdBy = 0;
        consm_creatorUser = "";
        consm_modifiedBy = 0;
        consm_modificatorUser = "";
        consm_fkRawMaterialReception = 0;
        consm_fkRawMaterialType = 0;
        consm_RawMaterialTypeName = "";
        consm_fkRawMaterial = 0;
        consm_RawMaterialName = "";
        consm_RawMaterialCode = "";
        consm_fkEntity = 0;
        consm_EntityName = "";
        consm_availableUnits = 0;
        consm_availableWeigth = 0;
        consm_fkCellar = 0;
        consm_cellarName = "";
        consm_cost = 0;
        consm_fkCurrency = 0;
        consm_currencyName = "";
        consm_Quote = 0;
        consm_unitsTransferred = 0;
        consm_code = "";
        consm_unitWeigth = 0;
        
        }

        public clsRawMaterialConsumption(int codsec)
        {

            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwtransfer where transf_codsec = " + codsec.ToString() + " group by transf_codsec");


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_codsec"]);
            this.fkRawMaterialByReception = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkRawMaterialByReception"]);
            this.availableUnits = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_availableUnits"]);
            this.availableWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_availableWeigth"]);
            this.amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_amountTransferred"]);
            this.number = DS.Tables[0].Rows[0]["transf_number"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["transf_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["transf_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["transf_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["transf_modificatorUser"].ToString();
            this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkRawMaterialType"]);
            this.rawMaterialTypeName = DS.Tables[0].Rows[0]["transf_RawMaterialTypeName"].ToString();
            this.rawMaterialCode = DS.Tables[0].Rows[0]["transf_RawMaterialCode"].ToString();
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkRawMaterial"]);
            this.rawMaterialName = DS.Tables[0].Rows[0]["transf_RawMaterialName"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["transf_EntityName"].ToString();
            this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkCellar"]);
            this.cellarName = DS.Tables[0].Rows[0]["transf_cellarName"].ToString();
            this.cost = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_cost"]);
            this.fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkCurrency"]);
            this.currencyName = DS.Tables[0].Rows[0]["transf_currencyName"].ToString();
            this.Quote = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_Quote"]);
            
        }

    }


}
