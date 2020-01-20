using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    public class clsRawMaterialByEntity
    {
        //Atributes

        private int rmbr_codsec;
        private int rmbr_fkReception;
        private int rmbr_fkEntity;
        private string rmbr_entityName;
        private int rmbr_fkRawMaterialType;
        private string rmbr_rawMaterialTypeName;
        private int rmbr_fkRawMaterial;
        private string rmbr_rawMaterialName;
        private string rmbr_rawMaterialCode;
        private double rmbr_weightPerPackage;
        private int rmbr_unitsPerPackage;
        private double rmbr_unitWeight;
        private int rmbr_availableUnitsPerPackage;
        private string rmbr_codePackage;
        private double rmbr_amountTransferred;
        private double rmbr_unitsTransfered;
        private double rmbr_amountConsumed;
        private double rmbr_unitsConsumed;

        //Properties

        public int codsec { get { return rmbr_codsec; } set { rmbr_codsec = value; } }

        public int fkReception { get { return rmbr_fkReception; } set { rmbr_fkReception = value; } }

        public int fkEntity { get { return rmbr_fkEntity; } set { rmbr_fkEntity = value; } }

        public string entityName { get { return rmbr_entityName; } set { rmbr_entityName = value; } }

        public int fkRawMaterialType { get { return rmbr_fkRawMaterialType; } set { rmbr_fkRawMaterialType = value; } }

        public string rawMaterialTypeName { get { return rmbr_rawMaterialTypeName; } set { rmbr_rawMaterialTypeName = value; } }

        public int fkRawMaterial { get { return rmbr_fkRawMaterial; } set { rmbr_fkRawMaterial = value; } }

        public string rawMaterialName { get { return rmbr_rawMaterialName; } set { rmbr_rawMaterialName = value; } }

        public string rawMaterialCode { get { return rmbr_rawMaterialCode; } set { rmbr_rawMaterialCode = value; } }

        public double weightPerPackage { get { return rmbr_weightPerPackage; } set { rmbr_weightPerPackage = value; } }

        public int unitsPerPackage { get { return rmbr_unitsPerPackage; } set { rmbr_unitsPerPackage = value; } }

        public double unitWeight { get { return rmbr_unitWeight; } set { rmbr_unitWeight = value; } }

        public int availableUnitsPerPackage { get { return rmbr_availableUnitsPerPackage; } set { rmbr_availableUnitsPerPackage = value; } }

        public string codePackage { get { return rmbr_codePackage; } set { rmbr_codePackage = value; } }

        public double amountTransferred { get { return rmbr_amountTransferred; } set { rmbr_amountTransferred = value; } }

        public double unitsTransfered { get { return rmbr_unitsTransfered; } set { rmbr_unitsTransfered = value; } }

        public double amountConsumed { get { return rmbr_amountConsumed; } set { rmbr_amountConsumed = value; } }

        public double unitsConsumed { get { return rmbr_unitsConsumed; } set { rmbr_unitsConsumed = value; } }

        //Constructor

        public clsRawMaterialByEntity()
        {
            rmbr_codsec = 0;
            rmbr_fkReception = 0;
            rmbr_fkEntity = 0;
            rmbr_entityName = "";
            rmbr_fkRawMaterialType = 0;
            rmbr_rawMaterialTypeName = "";
            rmbr_fkRawMaterial = 0;
            rmbr_rawMaterialName = "";
            rmbr_rawMaterialCode = "";
            rmbr_weightPerPackage = 0;
            rmbr_unitsPerPackage = 0;
            rmbr_unitWeight = 0;
            rmbr_availableUnitsPerPackage = 0;
            rmbr_codePackage = "";
            rmbr_amountTransferred = 0;
            rmbr_unitsTransfered = 0;
            rmbr_amountConsumed = 0;
            rmbr_unitsConsumed = 0;
        }

        public clsRawMaterialByEntity(int codsec)
        {

            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwrawmaterialbyreception where rmbr_codsec = " + codsec.ToString());


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_codsec"]);
            this.fkReception = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkReception"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["rmbr_entityName"].ToString();
            this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkRawMaterialType"]);
            this.rawMaterialTypeName = DS.Tables[0].Rows[0]["rmbr_rawMaterialTypeName"].ToString();
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkRawMaterial"]);
            this.rawMaterialName = DS.Tables[0].Rows[0]["rmbr_rawMaterialName"].ToString();
            this.rawMaterialCode = DS.Tables[0].Rows[0]["rmbr_rawMaterialCode"].ToString();
            this.weightPerPackage = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_weightPerPackage"]);
            this.unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsPerPackage"]);
            this.unitWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_unitWeight"]);
            this.availableUnitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_availableUnitsPerPackage"]);
            this.codePackage = DS.Tables[0].Rows[0]["rmbr_codePackage"].ToString();
            this.amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_amountTransferred"]);
            this.unitsTransfered = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsTransfered"]);
            this.amountConsumed = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_amountConsumed"]);
            this.unitsConsumed = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsConsumed"]);
        }

        public static List<clsRawMaterialByEntity> getListByCode(string code)
        {
            List<clsRawMaterialByEntity> lstRawMaterialByEntity = new List<clsRawMaterialByEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwrawmaterialbyreception where rmbr_codePackage = '" + code + "'");

            lstRawMaterialByEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByEntity.Add(new clsRawMaterialByEntity());
                lstRawMaterialByEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_codsec"]);
                lstRawMaterialByEntity[i].fkReception = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkReception"]);
                lstRawMaterialByEntity[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkEntity"]);
                lstRawMaterialByEntity[i].entityName = DS.Tables[0].Rows[0]["rmbr_entityName"].ToString();
                lstRawMaterialByEntity[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkRawMaterialType"]);
                lstRawMaterialByEntity[i].rawMaterialTypeName = DS.Tables[0].Rows[0]["rmbr_rawMaterialTypeName"].ToString();
                lstRawMaterialByEntity[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_fkRawMaterial"]);
                lstRawMaterialByEntity[i].rawMaterialName = DS.Tables[0].Rows[0]["rmbr_rawMaterialName"].ToString();
                lstRawMaterialByEntity[i].rawMaterialCode = DS.Tables[0].Rows[0]["rmbr_rawMaterialCode"].ToString();
                lstRawMaterialByEntity[i].weightPerPackage = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_weightPerPackage"]);
                lstRawMaterialByEntity[i].unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsPerPackage"]);
                lstRawMaterialByEntity[i].unitWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_unitWeight"]);
                lstRawMaterialByEntity[i].availableUnitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_availableUnitsPerPackage"]);
                lstRawMaterialByEntity[i].codePackage = DS.Tables[0].Rows[0]["rmbr_codePackage"].ToString();
                lstRawMaterialByEntity[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_amountTransfered"]);
                lstRawMaterialByEntity[i].unitsTransfered = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsTransfered"]);
                lstRawMaterialByEntity[i].amountConsumed = Convert.ToDouble(DS.Tables[0].Rows[0]["rmbr_amountConsumed"]);
                lstRawMaterialByEntity[i].unitsConsumed = Convert.ToInt32(DS.Tables[0].Rows[0]["rmbr_unitsConsumed"]);


            }
            return lstRawMaterialByEntity;
        }

        internal static int getLastCodsec()
        {
            throw new NotImplementedException();
        }
    }
}

