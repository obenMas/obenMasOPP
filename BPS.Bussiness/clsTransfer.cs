using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que adminisrta las transferencias de Materias Primas 
    /// </summary>
    public class clsTransfer
    {
        //Atributes

        private int transf_codsec;
        private int transf_fkRawMaterialByReception;
        private int transf_fkExtruder;
        private double transf_amountTransferred;
        private string transf_number;
        private DateTime transf_createdDate;
        private DateTime transf_modifiedDate;
        private int transf_createdBy;
        private string transf_creatorUser;
        private int transf_modifiedBy;
        private string transf_modificatorUser;
        private int transf_fkRawMaterialReception;
        private int transf_fkRawMaterialType;
        private string transf_RawMaterialTypeName;
        private int transf_fkRawMaterial;
        private string transf_RawMaterialName;
        private string transf_RawMaterialCode;
        private int transf_fkEntity;
        private string transf_EntityName;
        private int transf_availableUnits;
        private double transf_availableWeigth;
        private int transf_fkCellarByExtruder;
        private int transf_fkCellar;
        private string transf_cellarName;
        private double transf_cost;
        private int transf_fkCurrency;
        private string transf_currencyName;
        private double transf_Quote;
        private int transf_unitsTransferred;
        private string transf_code;
        private double transf_unitWeigth;
        private double transf_consummed;
        private double transf_unitsConsumed;
        


        //Properties

        public int codsec { get { return transf_codsec; } set { transf_codsec = value; } }

        public int fkRawMaterialByReception { get { return transf_fkRawMaterialByReception; } set { transf_fkRawMaterialByReception = value; } }

        public int fkExtruder { get { return transf_fkExtruder; } set { transf_fkExtruder = value; } }

        public double amountTransferred { get { return transf_amountTransferred; } set { transf_amountTransferred = value; } }

        public string number { get { return transf_number; } set { transf_number = value; } }

        public DateTime createdDate { get { return transf_createdDate; } set { transf_createdDate = value; } }

        public DateTime modifiedDate { get { return transf_modifiedDate; } set { transf_modifiedDate = value; } }

        public int createdBy { get { return transf_createdBy; } set { transf_createdBy = value; } }

        public string creatorUser { get { return transf_creatorUser; } set { transf_creatorUser = value; } }

        public int modifiedBy { get { return transf_modifiedBy; } set { transf_modifiedBy = value; } }

        public string modificatorUser { get { return transf_modificatorUser; } set { transf_modificatorUser = value; } }

        public int fkRawMaterialReception { get { return transf_fkRawMaterialReception; } set { transf_fkRawMaterialReception = value; } }

        public int fkRawMaterialType { get { return transf_fkRawMaterialType; } set { transf_fkRawMaterialType = value; } }

        public string rawMaterialTypeName { get { return transf_RawMaterialTypeName; } set { transf_RawMaterialTypeName = value; } }

        public int fkRawMaterial { get { return transf_fkRawMaterial; } set { transf_fkRawMaterial = value; } }

        public string rawMaterialName { get { return transf_RawMaterialName; } set { transf_RawMaterialName = value; } }

        public string rawMaterialCode { get { return transf_RawMaterialCode; } set { transf_RawMaterialCode = value; } }

        public int fkEntity { get { return transf_fkEntity; } set { transf_fkEntity = value; } }

        public string entityName { get { return transf_EntityName; } set { transf_EntityName = value; } }

        public int availableUnits { get { return transf_availableUnits; } set { transf_availableUnits = value; } }

        public double availableWeigth { get { return transf_availableWeigth; } set { transf_availableWeigth = value; } }
        
        public int fkCellarByExtruder { get { return transf_fkCellarByExtruder; } set { transf_fkCellarByExtruder = value; } }

        public int fkCellar { get { return transf_fkCellar; } set { transf_fkCellar = value; } }

        public string cellarName { get { return transf_cellarName; } set { transf_cellarName = value; } }

        public double cost { get { return transf_cost; } set { transf_cost = value; } }

        public int fkCurrency { get { return transf_fkCurrency; } set { transf_fkCurrency = value; } }

        public string currencyName { get { return transf_currencyName; } set { transf_currencyName = value; } }

        public double Quote { get { return transf_Quote; } set { transf_Quote = value; } } 

        public int unitsTransferred { get { return transf_unitsTransferred; } set { transf_unitsTransferred = value; } }

        public string code { get { return transf_code; } set { transf_code = value; } }

        public double unitWeigth { get { return transf_unitWeigth; } set { transf_unitWeigth = value; } }

        public string EntityName { get { return transf_EntityName; } set { transf_EntityName = value; } }

        public double consummed { get { return transf_consummed; } set { transf_consummed = value; } }

        public double unitsConsumed { get { return transf_unitsConsumed; } set { transf_unitsConsumed = value; } }



        //Constructor

        public clsTransfer()
        { 
        transf_codsec = 0;
        transf_fkRawMaterialByReception = 0;
        transf_fkExtruder = 0;
        transf_amountTransferred = 0;
        transf_number = "";
        transf_createdDate = DateTime.Now;
        transf_modifiedDate = DateTime.Now;
        transf_createdBy = 0;
        transf_creatorUser = "";
        transf_modifiedBy = 0;
        transf_modificatorUser = "";
        transf_fkRawMaterialReception = 0;
        transf_fkRawMaterialType = 0;
        transf_RawMaterialTypeName = "";
        transf_fkRawMaterial = 0;
        transf_RawMaterialName = "";
        transf_RawMaterialCode = "";
        transf_fkEntity = 0;
        transf_EntityName = "";
        transf_availableUnits = 0;
        transf_availableWeigth = 0;
        transf_fkCellarByExtruder = 0;
        transf_fkCellar = 0;
        transf_cellarName = "";
        transf_cost = 0;
        transf_fkCurrency = 0;
        transf_currencyName = "";
        transf_Quote = 0;
        transf_unitsTransferred = 0;
        transf_code = "";
        transf_unitWeigth = 0;
        transf_consummed = 0;
        transf_unitsConsumed = 0;
        
        }
        public clsTransfer(int codsec)
        {

            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwtransfer where transf_codsec = " + codsec.ToString() + " group by transf_codsec ORDER BY transf_createdDate");


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_codsec"]);
            this.fkRawMaterialByReception = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkRawMaterialByReception"]);
            this.fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkExtruder"]);
            this.number = DS.Tables[0].Rows[0]["transf_number"].ToString();
            this.amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_amountTransferred"]);
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
            this.fkCellarByExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkCellarByExtruder"]);
            this.cellarName = DS.Tables[0].Rows[0]["transf_cellarName"].ToString();
            this.cost = Convert.ToDouble(DS.Tables[0].Rows[0]["transf_cost"]);
            this.fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkCurrency"]);
            this.currencyName = DS.Tables[0].Rows[0]["transf_currencyName"].ToString();
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_transfer (transf_fkRawMaterialByReception,transf_fkExtruder,transf_fkRawMaterial,transf_fkCellar,transf_amountTransferred,transf_number,transf_unitsTransferred,transf_createdDate,transf_modifiedDate,transf_createdBy,transf_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkRawMaterialByReception + ",";
                    queryString += "" + this.fkExtruder + ",";
                    queryString += "" + this.fkRawMaterial + ",";
                    queryString += "" + this.fkCellar + ",";
                    queryString += "" + this.amountTransferred + ",";
                    queryString += "'" + this.number + "',";
                    queryString += "" + this.unitsTransferred + ",";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_transfer";
                    queryString += " SET ";
                    queryString += "transf_fkRawMaterialByReception = " + this.fkRawMaterialByReception + ",";
                    queryString += "transf_fkExtruder = " + this.fkExtruder + ",";
                    queryString += "transf_fkRawMaterial = " + this.fkRawMaterial + ",";
                    queryString += "transf_fkCellar = " + this.fkCellar + ",";
                    queryString += "transf_amountTransferred = " + this.amountTransferred + ",";
                    queryString += "transf_unitsTransferred = " + this.unitsTransferred + ",";
                    queryString += "transf_number = '" + this.number + "',";
                    queryString += "transf_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += "transf_modifiedDate" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += " WHERE transf_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTransfer.save");
                return false;
            }
        }


        public static List<clsTransfer> getList()
        {
            List<clsTransfer> lstTransfer = new List<clsTransfer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwTransfer ORDER BY transf_createdDate");

            lstTransfer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransfer.Add(new clsTransfer());
                lstTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_codsec"]);
                lstTransfer[i].fkRawMaterialByReception = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialByReception"]);
                lstTransfer[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkExtruder"]);
                lstTransfer[i].number = DS.Tables[0].Rows[i]["transf_number"].ToString();
                lstTransfer[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_amountTransferred"]);
                lstTransfer[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transf_createdDate"]);
                lstTransfer[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transf_modifiedDate"]);
                lstTransfer[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_createdBy"]);
                lstTransfer[i].creatorUser = DS.Tables[0].Rows[i]["transf_creatorUser"].ToString();
                lstTransfer[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_modifiedBy"]);
                lstTransfer[i].modificatorUser = DS.Tables[0].Rows[i]["transf_modificatorUser"].ToString();
                lstTransfer[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialType"]);
                lstTransfer[i].rawMaterialTypeName = DS.Tables[0].Rows[i]["transf_RawMaterialTypeName"].ToString();
                lstTransfer[i].rawMaterialCode = DS.Tables[0].Rows[i]["transf_RawMaterialCode"].ToString();
                lstTransfer[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterial"]);
                lstTransfer[i].rawMaterialName = DS.Tables[0].Rows[0]["transf_RawMaterialName"].ToString();
                lstTransfer[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkEntity"]);
                lstTransfer[i].entityName = DS.Tables[0].Rows[i]["transf_EntityName"].ToString();
                lstTransfer[i].fkCellarByExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCellarByExtruder"]);
                lstTransfer[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCellar"]);
                lstTransfer[i].cellarName = DS.Tables[0].Rows[i]["transf_cellarName"].ToString();
                lstTransfer[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_cost"]);
                lstTransfer[i].fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCurrency"]);
                lstTransfer[i].currencyName = DS.Tables[0].Rows[i]["transf_currencyName"].ToString();
                
           }
            return lstTransfer;
        }


        public static List<clsTransfer> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsTransfer> lstTransfer = new List<clsTransfer>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwTransfer " + where + " order by transf_createdDate DESC");

            lstTransfer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransfer.Add(new clsTransfer());
                lstTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_codsec"]);
                lstTransfer[i].fkRawMaterialByReception = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialByReception"]);
                lstTransfer[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkExtruder"]);
                lstTransfer[i].number = DS.Tables[0].Rows[i]["transf_number"].ToString();
                lstTransfer[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_amountTransferred"]);
                lstTransfer[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transf_createdDate"]);
                lstTransfer[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transf_modifiedDate"]);
                lstTransfer[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_createdBy"]);
                lstTransfer[i].creatorUser = DS.Tables[0].Rows[i]["transf_creatorUser"].ToString();
                lstTransfer[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_modifiedBy"]);
                lstTransfer[i].modificatorUser = DS.Tables[0].Rows[i]["transf_modificatorUser"].ToString();
                lstTransfer[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialType"]);
                lstTransfer[i].rawMaterialTypeName = DS.Tables[0].Rows[i]["transf_RawMaterialTypeName"].ToString();
                lstTransfer[i].rawMaterialCode = DS.Tables[0].Rows[i]["transf_RawMaterialCode"].ToString();
                lstTransfer[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterial"]);
                lstTransfer[i].rawMaterialName = DS.Tables[0].Rows[0]["transf_RawMaterialName"].ToString();
                lstTransfer[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkEntity"]);
                lstTransfer[i].entityName = DS.Tables[0].Rows[i]["transf_EntityName"].ToString();
                lstTransfer[i].fkCellarByExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCellarByExtruder"]);
                lstTransfer[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCellar"]);
                lstTransfer[i].cellarName = DS.Tables[0].Rows[i]["transf_cellarName"].ToString();
                lstTransfer[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_cost"]);
                lstTransfer[i].fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCurrency"]);
                lstTransfer[i].currencyName = DS.Tables[0].Rows[i]["transf_currencyName"].ToString();
            }
            return lstTransfer;
        }
    
        public string getLastBatch()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT transf_number FROM bps_prod_transfer order by transf_codsec desc Limit 1");

            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["transf_number"].ToString();
        }


        public double CalculateOutputBalance(int codsecRawMaterial)
        {
            double received = 0;
            double dispatched = 0;
            double Balance = 0;
            DataSet DSReceived = new DataSet();
            DataSet DSDispatched = new DataSet();
            DSReceived = clsConnection.getDataSetResult("SELECT COALESCE(sum(rc.`rcp_quantity`),0) as Received FROM `bps_prod_reception` rc, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm WHERE rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and pod.`purorddt_codsec` = rc.`rcp_fkPurchaseOrderDetail` and rm.`rwm_codsec` = " + codsecRawMaterial.ToString());
            received = Convert.ToDouble(DSReceived.Tables[0].Rows[0]["Received"].ToString());

            DSDispatched = clsConnection.getDataSetResult("SELECT COALESCE(sum(tf.`transf_amountTransferred`),0) as Dispatched FROM `bps_prod_transfer` as tf,`bps_prod_rawmaterialbyreception` as rmrc WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and rmrc.`rmbr_fkRawMaterial` = " + codsecRawMaterial.ToString());
            dispatched = Convert.ToDouble(DSDispatched.Tables[0].Rows[0]["Dispatched"].ToString());
            Balance = Convert.ToDouble(received - dispatched);

            if (Balance == 0)
                return 0;
            else
                return Balance;  
        }

        public double CalculateOutputToProductionBalance(int codsecRawMaterial, int codsecCellar, int codsecMachine)
        {
            double received = 0;
            double dispatched = 0;
            double Balance = 0;
            DataSet DSReceivedP = new DataSet();
            DataSet DSDispatchedP = new DataSet();

            DSReceivedP = clsConnection.getDataSetResult("SELECT sum(kdx.`kdx_quantityIn`) as Received FROM `bps_prod_kardex` kdx, `bps_prod_cellarbymachine` cllmch WHERE kdx.`kdx_fkCellar` = cllmch.`cllmch_fkCellar` and cllmch.`cllmch_fkMachine` = " +codsecMachine+ " and cllmch.`cllmch_fkCellar` != " +codsecCellar+ " and kdx.`kdx_fkRawMaterial` = " +codsecRawMaterial +"");
            received = Convert.ToDouble(DSReceivedP.Tables[0].Rows[0]["Received"].ToString());

            DSDispatchedP = clsConnection.getDataSetResult("SELECT COALESCE(sum(tf.`transf_amountTransferred`),0) as Dispatched FROM `bps_prod_transfer` as tf,`bps_prod_rawmaterialbyreception` as rmrc, `bps_prod_cellarbymachine` as cllmch WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and tf.`transf_fkCellar` = cllmch.`cllmch_fkCellar` and cllmch.`cllmch_fkCellar` = "+ codsecCellar +" and cllmch.`cllmch_fkMachine` = "+ codsecMachine +" and rmrc.`rmbr_fkRawMaterial` = "+ codsecRawMaterial +"");
            dispatched = Convert.ToDouble(DSDispatchedP.Tables[0].Rows[0]["Dispatched"].ToString());

            Balance = Convert.ToDouble(received - dispatched);

            if (Balance == 0)
                return 0;
            else
                return Balance;
        }


        public double CalculateInputToProductionBalance(int codsecRawMaterial, int codsecCellar, int codsecMachine)
        {
            double dispatched = 0;
            double Balance = 0;

            DataSet DSDispatched = new DataSet();
            DSDispatched = clsConnection.getDataSetResult("SELECT COALESCE(sum(tf.`transf_amountTransferred`),0) as Dispatched FROM `bps_prod_transfer` as tf,`bps_prod_rawmaterialbyreception` as rmrc, `bps_prod_cellarbymachine` cllmch WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and rmrc.`rmbr_fkRawMaterial` = " + codsecRawMaterial + " and tf.`transf_fkCellar` = " + codsecCellar + " and cllmch.`cllmch_fkMachine` = " +codsecMachine+"");
            dispatched = Convert.ToDouble(DSDispatched.Tables[0].Rows[0]["Dispatched"].ToString());

            Balance = Convert.ToDouble(dispatched);

            if (Balance == 0)
                return 0;
            else
                return Balance;
        }

        public double CalculateInputBalance(int codsecRawMaterial, int codsecCellar)
        {
            double dispatched = 0;
            double Balance = 0;

            DataSet DSDispatched = new DataSet();
         
            DSDispatched = clsConnection.getDataSetResult("SELECT COALESCE(sum(tf.`transf_amountTransferred`),0) as Dispatched FROM `bps_prod_transfer` as tf,`bps_prod_rawmaterialbyreception` as rmrc WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and rmrc.`rmbr_fkRawMaterial` = " + codsecRawMaterial.ToString() + " and tf.`transf_fkCellar` = " + codsecCellar.ToString());
            dispatched = Convert.ToDouble(DSDispatched.Tables[0].Rows[0]["Dispatched"].ToString());

            Balance = Convert.ToDouble(dispatched);

            if (Balance == 0)
                return 0;
            else
                return Balance;  
        }


        public static List<clsTransfer> getListByMachineAndCode(int codsecMachine, string code)
        {
            List<clsTransfer> lstTransferByMachine = new List<clsTransfer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT tf.`transf_codsec`,tf.`transf_fkRawMaterialByReception` as transf_fkRawMaterialByReception, tf.`transf_fkCellar` as transf_fkCellar, tf.`transf_fkExtruder` as transf_fkExtruder,cll.`clr_name` as transf_cellarName, rmrc.`rmbr_fkRawMaterial` as transf_fkRawMaterial, rm.`rwm_name` as transf_RawMaterialName, rm.`rwm_code` as transf_RawMaterialCode, rmt.`trwm_codsec` as transf_fkRawMaterialType, rmt.`trwm_name` as transf_RawMaterialTypeName, tf.`transf_unitsTransferred`, pod.`purorddt_price` as transf_cost, po.`purord_quote` as transf_Quote, rmrc.`rmbr_codePackage` as transf_code, rmrc.`rmbr_unitWeight` as transf_unitWeigth, entt.`entt_codsec` as transf_fkEntity, entt.`entt_companyName` as transf_EntityName FROM `bps_prod_cellarbymachine` cllmch,`bps_prod_machine` mch, `bps_prod_transfer` tf, `bps_prod_rawmaterialbyreception` rmrc, `bps_admin_cellar` cll, `bps_admin_purchaseorder` po, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt, `bps_prod_reception` rcp, `bps_com_entity` entt WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and pod.`purorddt_codsec` = rcp.`rcp_fkPurchaseOrderDetail` and rcp.`rcp_codsec` = rmrc.`rmbr_fkReception` and rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and  rm.`rwm_codsec` = rmrc.`rmbr_fkRawMaterial` and cll.`clr_codsec` = tf.`transf_fkCellar`  and tf.`transf_fkCellar` = cllmch.`cllmch_fkCellar` and po.`purord_codsec` = pod.`purorddt_fkPurchaseOrder` and entt.`entt_codsec` = po.`purord_fkEntity` and cllmch.`cllmch_fkMachine` = " + codsecMachine + " and rmrc.`rmbr_codePackage` = '" + code + "' group by rmrc.`rmbr_codePackage`");

            lstTransferByMachine.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransferByMachine.Add(new clsTransfer());
                lstTransferByMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_codsec"]);
                lstTransferByMachine[i].fkRawMaterialByReception = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialByReception"]);
                lstTransferByMachine[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["transf_fkExtruder"]);
                lstTransferByMachine[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkCellar"]);
                lstTransferByMachine[i].cellarName = DS.Tables[0].Rows[i]["transf_cellarName"].ToString();
                lstTransferByMachine[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterial"]);
                lstTransferByMachine[i].rawMaterialName = DS.Tables[0].Rows[i]["transf_RawMaterialName"].ToString();
                lstTransferByMachine[i].rawMaterialCode = DS.Tables[0].Rows[i]["transf_RawMaterialCode"].ToString();
                lstTransferByMachine[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_fkRawMaterialType"]);
                lstTransferByMachine[i].rawMaterialTypeName = DS.Tables[0].Rows[i]["transf_RawMaterialTypeName"].ToString();
                lstTransferByMachine[i].unitsTransferred = Convert.ToInt32(DS.Tables[0].Rows[i]["transf_unitsTransferred"]);
                lstTransferByMachine[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_cost"]);
                lstTransferByMachine[i].Quote = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_Quote"]);
                lstTransferByMachine[i].code = DS.Tables[0].Rows[i]["transf_code"].ToString();
                lstTransferByMachine[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[i]["transf_amountTransferred"]);
                lstTransferByMachine[i].entityName = DS.Tables[0].Rows[i]["transf_EntityName"].ToString();
                
            }
            return lstTransferByMachine;
        }

        public int getAvailableUnits(int codsecMachine, string code)
        {
         DataSet DSIn = new DataSet();
         DSIn = clsConnection.getDataSetResult("SELECT tf.`transf_fkCellar` as fkCellar,sum(tf.`transf_unitsTransferred`) as TotalIn FROM `bps_prod_rawmaterialbyreception` rmrc, `bps_prod_cellarbymachine` cllmch, `bps_prod_transfer` tf WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and tf.`transf_fkCellar` = cllmch.`cllmch_fkCellar`  and cllmch.`cllmch_fkMachine` = " + codsecMachine + " and rmrc.`rmbr_codePackage` = '" + code + "' GROUP BY tf.`transf_fkCellar` order by transf_fkCellar asc Limit 1");
         DataSet DSOut = new DataSet();
         DSOut = clsConnection.getDataSetResult("SELECT tf.`transf_fkCellar`as fkCellar, sum(tf.`transf_unitsTransferred`) as TotalOut FROM `bps_prod_rawmaterialbyreception` rmrc, `bps_prod_cellarbymachine` cllmch, `bps_prod_transfer` tf WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and tf.`transf_fkCellar` = cllmch.`cllmch_fkCellar`  and cllmch.`cllmch_fkMachine` = " + codsecMachine + " and rmrc.`rmbr_codePackage` = '" + code + "' GROUP BY tf.`transf_fkCellar` order by transf_fkCellar asc Limit 1");
         int i = Convert.ToInt32(DSIn.Tables[0].Rows[0]["fkCellar"]);
         int O = Convert.ToInt32(DSOut.Tables[0].Rows[0]["fkCellar"]);
           int ti = Convert.ToInt32(DSIn.Tables[0].Rows[0]["TotalIn"]);
           int to = Convert.ToInt32(DSOut.Tables[0].Rows[0]["TotalOut"]);
            if(Convert.ToInt32(DSIn.Tables[0].Rows[0]["fkCellar"]) != Convert.ToInt32(DSOut.Tables[0].Rows[0]["fkCellar"]))
                return (Convert.ToInt32(DSIn.Tables[0].Rows[0]["TotalIn"]) - Convert.ToInt32(DSOut.Tables[0].Rows[0]["TotalOut"]));
            else
                return Convert.ToInt32(DSIn.Tables[0].Rows[0]["TotalIn"]);
        /*     DataSet DS = new DataSet();
             DS = clsConnection.getDataSetResult("SELECT tf.`transf_fkCellar` as fkCellar,sum(tf.`transf_unitsTransferred`) as TotalIn FROM `bps_prod_rawmaterialbyreception` rmrc, `bps_prod_cellarbymachine` cllmch, `bps_prod_transfer` tf WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and tf.`transf_fkCellar` = cllmch.`cllmch_fkCellar`  and cllmch.`cllmch_fkMachine` = " + codsecMachine + " and rmrc.`rmbr_codePackage` = '" + code + "' group by cllmch.`cllmch_fkCellar`");

             if (DS.Tables[0].Rows.Count > 1)
             {
                 int prodCellarIn = 0;
                 int prodCellarOut = 0;
             }
             else
                 return DS.Tables[0].Rows[0]["TotalIn"];
             */
        }
            
    }
}
