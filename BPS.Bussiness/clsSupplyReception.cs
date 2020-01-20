using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que adminsitra las recepciones de  suministros
    /// </summary>
    public class clsSupplyReception
    {
        //Atributes


        private int rcpspy_codsec;
        private int rcpspy_fkPurchaseOrderDetail;
        private int rcpspy_PurchaseOrderNumer;
        private int rcpspy_fkSupply;
        private string rcpspy_SupplyName;
        private string rcpspy_SupplyCode;
        private int rcpspy_fkEntity;
        private string rcpspy_EntityName;
        private double rcpspy_quantity;
        private string rcpspy_batch;
        private string rcpspy_notes;
        private string rcpspy_documentNumber;
        private DateTime rcpspy_createdDate;
        private DateTime rcpspy_modifiedDate;
        private int rcpspy_createdBy;
        private string rcpspy_creatorUser;
        private int rcpspy_modifiedBy;
        private string rcpspy_modificatorUser;
        private int rcpspy_fkUnit;
        private string rcpspy_unitName;


        //Properties

        public int codsec { get { return rcpspy_codsec; } set { rcpspy_codsec = value; } }

        public int fkPurchaseOrderDetail { get { return rcpspy_fkPurchaseOrderDetail; } set { rcpspy_fkPurchaseOrderDetail = value; } }

        public int PurchaseOrderNumer { get { return rcpspy_PurchaseOrderNumer; } set { rcpspy_PurchaseOrderNumer = value; } }

        public int fkSupply { get { return rcpspy_fkSupply; } set { rcpspy_fkSupply = value; } }

        public string supplyName { get { return rcpspy_SupplyName; } set { rcpspy_SupplyName = value; } }

        public string supplyCode { get { return rcpspy_SupplyCode; } set { rcpspy_SupplyCode = value; } }

        public int fkEntity { get { return rcpspy_fkEntity; } set { rcpspy_fkEntity = value; } }

        public string EntityName { get { return rcpspy_EntityName; } set { rcpspy_EntityName = value; } }

        public double quantity { get { return rcpspy_quantity; } set { rcpspy_quantity = value; } }

        public string batch { get { return rcpspy_batch; } set { rcpspy_batch = value; } }

        public string notes { get { return rcpspy_notes; } set { rcpspy_notes = value; } }

        public string documentNumber { get { return rcpspy_documentNumber; } set { rcpspy_documentNumber = value; } }

        public DateTime createdDate { get { return rcpspy_createdDate; } set { rcpspy_createdDate = value; } }

        public DateTime modifiedDate { get { return rcpspy_modifiedDate; } set { rcpspy_modifiedDate = value; } }

        public int createdBy { get { return rcpspy_createdBy; } set { rcpspy_createdBy = value; } }

        public string creatorUser { get { return rcpspy_creatorUser; } set { rcpspy_creatorUser = value; } }

        public int modifiedBy { get { return rcpspy_modifiedBy; } set { rcpspy_modifiedBy = value; } }

        public string modificatorUser { get { return rcpspy_modificatorUser; } set { rcpspy_modificatorUser = value; } }

        public int fkUnit { get { return rcpspy_fkUnit; } set { rcpspy_fkUnit = value; } }

        public string unitName { get { return rcpspy_unitName; } set { rcpspy_unitName = value; } }

        //Constructor

        public clsSupplyReception()
        { 

        rcpspy_codsec = 0;
        rcpspy_fkPurchaseOrderDetail = 0;
        rcpspy_PurchaseOrderNumer = 0;
        rcpspy_fkSupply = 0;
        rcpspy_SupplyName = "";
        rcpspy_SupplyCode = "";
        rcpspy_fkEntity = 0;
        rcpspy_EntityName = "";
        rcpspy_quantity = 0;
        rcpspy_batch = "";        
        rcpspy_notes = "";
        rcpspy_documentNumber = "";
        rcpspy_createdDate = DateTime.Now;
        rcpspy_modifiedDate = DateTime.Now;
        rcpspy_createdBy = 0;
        rcpspy_creatorUser = "";
        rcpspy_modifiedBy = 0;
        rcpspy_modificatorUser = "";
        rcpspy_fkUnit = 0;
        rcpspy_unitName = "";

        }

        public clsSupplyReception(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT spyrcp.`rcpspy_codsec`, spyrcp.`rcpspy_fkPurchaseOrderDetail`, spy.`spy_codsec` as rcpspy_fkSupply, spy.`spy_name` as rcpspy_SupplyName, spy.`spy_code` as rcpspy_SupplyCode, entt.`entt_codsec` as rcpspy_fkEntity, entt.`entt_companyName` as rcpspy_EntityName, spyrcp.`rcpspy_quantity`,spyrcp.`rcpspy_batch`,spyrcp.`rcpspy_notes`, spyrcp.`rcpspy_documentNumber`,spyrcp.`rcpspy_createdDate`,spyrcp.`rcpspy_modifiedDate`, usr.`usr_codsec` as rcpspy_createdBy, usr.`usr_userName` as rcpspy_creatorUser, usrM.`usr_codsec` as rcpspy_modifiedBy, usrM.`usr_userName` as rcpspy_modificatorUser FROM `bps_prod_supplyreception` spyrcp, `bps_com_entity` entt, `bps_prod_supply` spy, bps_admin_user usr, bps_admin_user usrM WHERE entt.`entt_codsec` = spyrcp.`rcpspy_fkEntity` and spy.`spy_codsec` = spyrcp.`rcpspy_fkSupply` and usr.`usr_codsec` = spyrcp.`rcpspy_createdBy` and usrM.`usr_codsec` = spyrcp.`rcpspy_modifiedBy` and spyrcp.`rcpspy_codsec` ='"+codsec.ToString()+"' group by spyrcp.`rcpspy_codsec`");


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_codsec"]);
            this.fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_fkPurchaseOrderDetail"]);
            this.fkSupply = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_fkSupply"]);
            this.supplyName = DS.Tables[0].Rows[0]["rcpspy_SupplyName"].ToString();
            this.supplyCode = DS.Tables[0].Rows[0]["rcpspy_SupplyCode"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_fkEntity"]);
            this.EntityName = DS.Tables[0].Rows[0]["rcpspy_EntityName"].ToString();
            this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpspy_quantity"]);
            this.batch = DS.Tables[0].Rows[0]["rcpspy_batch"].ToString();
            this.notes = DS.Tables[0].Rows[0]["rcpspy_notes"].ToString();
            this.documentNumber = DS.Tables[0].Rows[0]["rcpspy_documentNumber"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rcpspy_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rcpspy_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["rcpspy_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["rcpspy_modificatorUser"].ToString();

        }
        
        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supplyreception (rcpspy_fkPurchaseOrderDetail, rcpspy_fkSupply, rcpspy_fkEntity, rcpspy_batch, rcpspy_quantity,rcpspy_documentNumber,rcpspy_notes,rcpspy_createdDate,rcpspy_modifiedDate,rcpspy_createdBy,rcpspy_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkPurchaseOrderDetail + ",";
                    queryString += "" + this.fkSupply + ",";
                    queryString += "" + this.fkEntity + ",";
                    queryString += "'" + this.batch + "',";
                    queryString += "" + this.quantity + ",";
                    queryString += "'" + this.documentNumber + "',";
                    queryString += "'" + this.notes + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    
                }
                else
                {
                    queryString += "UPDATE bps_prod_supplyreception";
                    queryString += " SET ";
                    queryString += "rcpspy_fkPurchaseOrderDetail = " + this.fkPurchaseOrderDetail + ",";
                    queryString += "rcpspy_fkSupply = " + this.fkPurchaseOrderDetail + ",";
                    queryString += "rcpspy_fkEntity = " + this.fkPurchaseOrderDetail + ",";
                    queryString += "rcpspy_batch = '" + this.batch + "',";
                    queryString += "rcpspy_quantity = " + this.quantity.ToString() + ",";
                    queryString += "rcpspy_notes = '" + this.notes + "',";
                    queryString += "rcpspy_documentNumber = '" + this.documentNumber + "',";
                    queryString += "rcpspy_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += "rcpspy_modifiedDate" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += " WHERE rcpspy_codsec = " + this.codsec.ToString() + ";";


                }
                clsConnection.executeQuery(queryString);
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplyReception.save");
                return false;
            }
        }


        public string getLastBatch()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rcpspy_batch FROM bps_prod_supplyreception order by rcpspy_codsec desc Limit 1");


            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["rcpspy_batch"].ToString();
        }

        public static List<clsSupplyReception> getReceptionDetail(int codsec)
        {
            List<clsSupplyReception> lstSupplyReception = new List<clsSupplyReception>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT spy.`spy_codsec` as rcpspy_fkSupply, spy.`spy_name` as rcpspy_SupplyName, spyrcp.`rcpspy_codsec` as rcpspy_codsec, spyrcp.`rcpspy_batch` as rcpspy_batch, spyrcp.`rcpspy_quantity` as rcpspy_quantity, unt.`unit_codsec` as rcpspy_fkUnit, unt.`unit_name` as rcpspy_unitName FROM `bps_prod_supplyreception` spyrcp, `bps_prod_supply` spy, `bps_admin_unit` unt WHERE spy.`spy_codsec` = spyrcp.`rcpspy_fkSupply` and unt.`unit_codsec` = spy.`spy_fkUnit` and spyrcp.`rcpspy_codsec` = '"+ codsec +"' and spyrcp.`rcpspy_createdBy` ='" + clsGlobal.LoggedUser.codsec.ToString() + "'");

            lstSupplyReception.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyReception.Add(new clsSupplyReception());
                lstSupplyReception[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpspy_codsec"]);
                lstSupplyReception[i].batch = DS.Tables[0].Rows[i]["rcpspy_batch"].ToString();
                lstSupplyReception[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpspy_fkSupply"]);
                lstSupplyReception[i].supplyName = DS.Tables[0].Rows[i]["rcpspy_SupplyName"].ToString();
                lstSupplyReception[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpspy_quantity"]);
                lstSupplyReception[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpspy_fkUnit"]);
                lstSupplyReception[i].unitName = DS.Tables[0].Rows[i]["rcpspy_unitName"].ToString();                               

            }
            return lstSupplyReception;

        }
        
        public double CalculateBalance(int codsecSupply)
        {
            double received = 0;
            double dispatched = 0;
            double Balance = 0;
            DataSet DSReceived = new DataSet();
            DataSet DSDispatched = new DataSet();

            DSReceived = clsConnection.getDataSetResult("SELECT COALESCE(sum(spyrcp.`rcpspy_quantity`),0) as Received FROM `bps_prod_supplyreception` spyrcp, `bps_prod_supplybyreception` spybyrcp, `bps_prod_supply` spy WHERE spy.`spy_codsec` = spyrcp.`rcpspy_fkSupply` and spyrcp.`rcpspy_codsec` = spybyrcp.`spybr_fkReception` and spy.`spy_codsec` = " + codsecSupply.ToString());
            received = Convert.ToDouble(DSReceived.Tables[0].Rows[0]["Received"].ToString());

            DSDispatched = clsConnection.getDataSetResult("SELECT COALESCE(sum(spytf.`transfspy_unitsTransferred`),0) as Dispatched FROM `bps_prod_supplytransfer` spytf, `bps_prod_supplyreception` spyrcp, `bps_prod_supplybyreception` spybyrcp, `bps_prod_supply` spy WHERE spybyrcp.`spybr_codsec` = spytf.`transfspy_fkSupplyByReception` and spyrcp.`rcpspy_codsec` = spybyrcp.`spybr_fkReception` and spy.`spy_codsec` = spyrcp.`rcpspy_codsec` and spyrcp.`rcpspy_fkSupply` =" + codsecSupply.ToString());
            dispatched = Convert.ToDouble(DSDispatched.Tables[0].Rows[0]["Dispatched"].ToString());

            Balance = Convert.ToDouble(received - dispatched);

            if (Balance == 0)
                return 0;
            else
                return Balance;


        }

        
    }
}
