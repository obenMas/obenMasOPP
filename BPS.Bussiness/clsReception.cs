using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que adminsitra las recepciones de materias primas 
    /// </summary>
    public class clsReception
    {
        //Atributes

        private int rcp_codsec;
        private int rcp_fkPurchaseOrder;
        private int rcp_PurchaseOrderNumer;
        private int rcp_fkRawMaterialType;
        private string rcp_RawMaterialTypeName;
        private int rcp_fkPurchaseOrderDetail;
        private int rcp_fkRawMaterial;
        private string rcp_RawMaterialName;
        private string rcp_RawMaterialCode;
        private int rcp_fkEntity;
        private string rcp_EntityName;
        private double rcp_PurchaseOrderQuantity;        
        private string rcp_batch;
        private double rcp_quantity;
        private string rcp_notes;
        private string rcp_documentNumber;
        private DateTime rcp_createdDate;
        private DateTime rcp_modifiedDate;
        private int rcp_createdBy;
        private string rcp_creatorUser;
        private int rcp_modifiedBy;
        private string rcp_modificatorUser;
        private double rcp_calculateBalance;
        private double rcp_cost;
        private string rcp_statusName;
        private int rcp_fkStatus;



        //Properties

        public int codsec { get { return rcp_codsec; } set { rcp_codsec = value; } }

        public int fkPurchaseOrder { get { return rcp_fkPurchaseOrder; } set { rcp_fkPurchaseOrder = value; } }

        public int PurchaseOrderNumer { get { return rcp_PurchaseOrderNumer; } set { rcp_PurchaseOrderNumer = value; } }

        public int fkRawMaterialType { get { return rcp_fkRawMaterialType; } set { rcp_fkRawMaterialType = value; } }

        public string RawMaterialTypeName { get { return rcp_RawMaterialTypeName; } set { rcp_RawMaterialTypeName = value; } }

        public int fkPurchaseOrderDetail { get { return rcp_fkPurchaseOrderDetail; } set { rcp_fkPurchaseOrderDetail = value; } }        

        public int fkRawMaterial { get { return rcp_fkRawMaterial; } set { rcp_fkRawMaterial = value; } }

        public string RawMaterialName { get { return rcp_RawMaterialName; } set { rcp_RawMaterialName = value; } }

        public string RawMaterialCode { get { return rcp_RawMaterialCode; } set { rcp_RawMaterialCode = value; } }

        public int fkEntity { get { return rcp_fkEntity; } set { rcp_fkEntity = value; } }

        public string EntityName { get { return rcp_EntityName; } set { rcp_EntityName = value; } }

        public double PurchaseOrderQuantity { get { return rcp_PurchaseOrderQuantity; } set { rcp_PurchaseOrderQuantity = value; } }

        public string batch { get { return rcp_batch; } set { rcp_batch = value; } }

        public double quantity { get { return rcp_quantity; } set { rcp_quantity = value; } }

        public string notes { get { return rcp_notes; } set { rcp_notes = value; } }

        public string documentNumber { get { return rcp_documentNumber; } set { rcp_documentNumber = value; } }

        public DateTime createdDate { get { return rcp_createdDate; } set { rcp_createdDate = value; } }

        public DateTime modifiedDate { get { return rcp_modifiedDate; } set { rcp_modifiedDate = value; } }

        public int createdBy { get { return rcp_createdBy; } set { rcp_createdBy = value; } }

        public string creatorUser { get { return rcp_creatorUser; } set { rcp_creatorUser = value; } }

        public int modifiedBy { get { return rcp_modifiedBy; } set { rcp_modifiedBy = value; } }

        public string modificatorUser { get { return rcp_modificatorUser; } set { rcp_modificatorUser = value; } }

        public double calculateBalance { get { return rcp_calculateBalance; } set { rcp_calculateBalance = value; } }

        public double cost { get { return rcp_cost; } set { rcp_cost = value; } }

        public string statusName { get { return rcp_statusName; } set { rcp_statusName = value; } }

        public int fkStatus { get { return rcp_fkStatus; } set { rcp_fkStatus = value; } }

        //Constructor

        public clsReception()
        {
            rcp_codsec = 0;
            rcp_fkPurchaseOrder = 0;
            rcp_PurchaseOrderNumer = 0;
            rcp_fkRawMaterialType = 0;
            rcp_fkPurchaseOrderDetail = 0;
            rcp_RawMaterialTypeName = "";
            rcp_fkRawMaterial = 0;
            rcp_RawMaterialName = "";
            rcp_RawMaterialCode = "";
            rcp_fkEntity = 0;
            rcp_PurchaseOrderQuantity = 0;
            rcp_EntityName = "";
            rcp_batch = "";
            rcp_quantity = 0;
            rcp_notes = "";
            rcp_documentNumber = "";
            rcp_createdDate = DateTime.Now;
            rcp_modifiedDate = DateTime.Now;
            rcp_createdBy = 0;
            rcp_creatorUser = "";
            rcp_modifiedBy = 0;
            rcp_modificatorUser = "";
            rcp_calculateBalance = 0;
            rcp_cost = 0;
            rcp_statusName = "";
            rcp_fkStatus = 0;
        }

        public clsReception(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwReception where rcp_codsec = " + codsec.ToString());


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_codsec"]);
            this.fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkPurchaseOrder"]);
            this.PurchaseOrderNumer = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_PurchaseOrderNumer"]);
            this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkRawMaterialType"]);
            this.fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkPurchaseOrder"]);
            this.fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkPurchaseOrderDetail"]);
            this.RawMaterialTypeName = DS.Tables[0].Rows[0]["rcp_RawMaterialTypeName"].ToString();
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkRawMaterial"]);
            this.RawMaterialName = DS.Tables[0].Rows[0]["rcp_RawMaterialName"].ToString();
            this.RawMaterialCode = DS.Tables[0].Rows[0]["rcp_RawMaterialCode"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_fkEntityCodsec"]);
            this.EntityName = DS.Tables[0].Rows[0]["rcp_EntityName"].ToString();
            this.PurchaseOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["rcp_PurchaseOrderQuantity"]);
            this.batch = DS.Tables[0].Rows[0]["rcp_batch"].ToString();
            this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["rcp_quantity"]);
            this.notes = DS.Tables[0].Rows[0]["rcp_notes"].ToString();
            this.documentNumber = DS.Tables[0].Rows[0]["rcp_documentNumber"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rcp_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rcp_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["rcp_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rcp_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["rcp_modificatorUser"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_reception (rcp_fkPurchaseOrderDetail, rcp_batch, rcp_quantity, rcp_notes, rcp_documentNumber,rcp_createdDate,rcp_modifiedDate,rcp_createdBy,rcp_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkPurchaseOrderDetail + ",";
                    queryString += "'" + this.batch + "',";
                    queryString += "" + this.quantity + ",";
                    queryString += "'" + this.notes + "',";
                    queryString += "'" + this.documentNumber + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_reception";
                    queryString += " SET ";
                    queryString += "rcp_fkPurchaseOrderDetail = " + this.fkPurchaseOrderDetail + ",";
                    queryString += "rcp_batch = '" + this.batch + "',";
                    queryString += "rcp_quantity = " + this.quantity.ToString() + ",";
                    queryString += "rcp_notes = '" + this.notes + "',";
                    queryString += "rcp_documentNumber = '" + this.documentNumber + "',";
                    queryString += "rcp_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += "rcp_modifiedDate" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += " WHERE rcp_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);


                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReception.save");
                return false;
            }
        }


        public string getLastBatch()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rcp_batch FROM bps_prod_reception order by rcp_codsec desc Limit 1");


            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["rcp_batch"].ToString();
        }

        public double CalculateBalance(int codsecRawMaterial)
        {
            double received = 0;
            double dispatched = 0;
            double Balance = 0;
            DataSet DSReceived = new DataSet();
            DataSet DSDispatched = new DataSet();
        
            DSReceived = clsConnection.getDataSetResult("SELECT COALESCE(sum(rc.`rcp_quantity`),0) as Received FROM `bps_prod_reception` rc, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm WHERE rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and pod.`purorddt_codsec` = rc.`rcp_fkPurchaseOrderDetail` and rm.`rwm_codsec` = " + codsecRawMaterial.ToString());
            received = Convert.ToDouble(DSReceived.Tables[0].Rows[0]["Received"].ToString());

            DSDispatched = clsConnection.getDataSetResult("SELECT COALESCE(sum(tf.`transf_amountTransferred`),0) as Dispatched FROM `bps_prod_transfer` as tf,  `bps_prod_rawmaterialbyreception` as rmrc WHERE rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and rmrc.`rmbr_fkRawMaterial` = " + codsecRawMaterial.ToString());
            dispatched = Convert.ToDouble(DSDispatched.Tables[0].Rows[0]["Dispatched"].ToString());

            Balance = Convert.ToDouble(received - dispatched);   
            
            if (Balance == 0)
                return 0;
            else
                return Balance;       
        
        
        }

        public static List<clsReception> getList()
        {
            List<clsReception> lstReception = new List<clsReception>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwReceptionList");

            lstReception.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReception.Add(new clsReception());
                lstReception[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_codsec"]);
                lstReception[i].PurchaseOrderNumer = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_PurchaseOrderNumer"]);
                lstReception[i].EntityName = DS.Tables[0].Rows[i]["rcp_entityName"].ToString();
                lstReception[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcp_RawMaterialTypeName"].ToString();
                lstReception[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcp_RawMaterialCode"].ToString();
                lstReception[i].RawMaterialName = DS.Tables[0].Rows[i]["rcp_RawMaterialName"].ToString();
                lstReception[i].batch = DS.Tables[0].Rows[i]["rcp_batch"].ToString();
                lstReception[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_quantity"]);
                lstReception[i].statusName = DS.Tables[0].Rows[i]["rcp_StatusName"].ToString();
                lstReception[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rcp_createdDate"]);
                lstReception[i].creatorUser = DS.Tables[0].Rows[i]["rcp_creatorUser"].ToString();

            }

            return lstReception;
        }

        public static List<clsReception> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsReception> lstReception = new List<clsReception>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwReceptionList " + where + " group by rcp_codsec order by rcp_createdDate DESC");

            lstReception.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReception.Add(new clsReception());
                lstReception[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_codsec"]);
                lstReception[i].PurchaseOrderNumer = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_PurchaseOrderNumer"]);
                lstReception[i].EntityName = DS.Tables[0].Rows[i]["rcp_entityName"].ToString();
                lstReception[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcp_RawMaterialTypeName"].ToString();
                lstReception[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcp_RawMaterialCode"].ToString();
                lstReception[i].RawMaterialName = DS.Tables[0].Rows[i]["rcp_RawMaterialName"].ToString();
                lstReception[i].batch = DS.Tables[0].Rows[i]["rcp_batch"].ToString();
                lstReception[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_quantity"]);
                lstReception[i].statusName = DS.Tables[0].Rows[i]["rcp_StatusName"].ToString();
                lstReception[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rcp_createdDate"]);
                lstReception[i].creatorUser = DS.Tables[0].Rows[i]["rcp_creatorUser"].ToString();


            }
            return lstReception;
        }
        
    }
}
