using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo de Ordenes de Compra de Materias Primas y Suministros
    /// </summary>
    public class clsPurchaseOrder
    {
        //Atributes

        private int purord_codsec;
        private int purord_fkStatus;
        private string purord_statusName;
        private int purord_fkCommercialCondition;
        private string purord_comercialConditionName;
        private int purord_fkEntity;
        private string purord_entityName;
        private string purord_entityId;
        private int purord_fkCurrency;
        private string purord_currencyName;
        private double purord_quote;
        private string purord_purchaseOrder;
        private string purord_number;
        private string purord_notes;
        private int purord_createdBy;
        private string purord_creatorUser;
        private int purord_modifiedBy;
        private string purord_modificatorUser;
        private DateTime purord_createdDate;
        private DateTime purord_modifiedDate;
        private List<clsPurchaseOrderDetail> purord_lstPurchaseOrderDetail;
        public double purord_delivered;
        public double purord_requestedQuantity;
        public double purord_missingQuantity;

        //Properties

        public int codsec { get { return purord_codsec; } set { purord_codsec = value; } }

        public int fkStatus { get { return purord_fkStatus; } set { purord_fkStatus = value; } }

        public string statusName { get { return purord_statusName; } set { purord_statusName = value; } }

        public int fkCommercialCondition { get { return purord_fkCommercialCondition; } set { purord_fkCommercialCondition = value; } }

        public string comercialConditionName { get { return purord_comercialConditionName; } set { purord_comercialConditionName = value; } }

        public int fkEntity { get { return purord_fkEntity; } set { purord_fkEntity = value; } }

        public string entityName { get { return purord_entityName; } set { purord_entityName = value; } }

        public string entityId { get { return purord_entityId; } set { purord_entityId = value; } }

        public int fkCurrency { get { return purord_fkCurrency; } set { purord_fkCurrency = value; } }

        public string currencyName { get { return purord_currencyName; } set { purord_currencyName = value; } }

        public double quote { get { return purord_quote; } set { purord_quote = value; } }
        
        public string purchaseOrder { get { return purord_purchaseOrder; } set { purord_purchaseOrder = value; } }

        public string number { get { return purord_number; } set { purord_number = value; } }

        public string notes { get { return purord_notes; } set { purord_notes = value; } }

        public int createdBy { get { return purord_createdBy; } set { purord_createdBy = value; } }

        public string creatorUser { get { return purord_creatorUser; } set { purord_creatorUser = value; } }

        public int modifiedBy { get { return purord_modifiedBy; } set { purord_modifiedBy = value; } }

        public string modificatorUser { get { return purord_modificatorUser; } set { purord_modificatorUser = value; } }

        public DateTime createdDate { get { return purord_createdDate; } set { purord_createdDate = value; } }

        public DateTime modifiedDate { get { return purord_modifiedDate; } set { purord_modifiedDate = value; } }

        public List<clsPurchaseOrderDetail> lstPurchaseOrderDetail { get { return purord_lstPurchaseOrderDetail; } set { purord_lstPurchaseOrderDetail = value; } }

        public double delivered { get { return purord_delivered; } set { purord_delivered = value; } }

        public double requestedQuantity { get { return purord_requestedQuantity; } set { purord_requestedQuantity = value; } }

        public double missingQuantity { get { return purord_missingQuantity; } set { purord_missingQuantity = value; } }


        //Constructor

        public clsPurchaseOrder()
        {
            
            purord_codsec = 0;
            purord_fkStatus = 0;
            purord_statusName = "";
            purord_fkCommercialCondition = 0;
            purord_comercialConditionName = "";
            purord_fkEntity = 0;
            purord_entityName = "";
            purord_entityId = "";
            purord_fkCurrency = 0;
            purord_currencyName = "";
            purord_quote = 0;
            purord_purchaseOrder = "";
            purord_number = "";
            purord_notes = "";
            purord_createdBy = 0;
            purord_creatorUser = "";
            purord_modifiedBy = 0;
            purord_modificatorUser = "";
            purord_createdDate = DateTime.Now;
            purord_modifiedDate = DateTime.Now;
            purord_lstPurchaseOrderDetail = new List<clsPurchaseOrderDetail>();
            purord_delivered = 0;
            purord_requestedQuantity = 0;
            purord_missingQuantity = 0;
        
        }

        public clsPurchaseOrder(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwpurchaseorder where purord_codsec = " + codsec.ToString());// + " group by purord_codsec");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_codsec"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_fkStatus"]);
            this.statusName = DS.Tables[0].Rows[0]["purord_statusName"].ToString();
            this.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_fkCommercialCondition"]);
            this.comercialConditionName = DS.Tables[0].Rows[0]["purord_comercialConditionName"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["purord_entityName"].ToString();
            this.entityId = DS.Tables[0].Rows[0]["purord_entityId"].ToString();
            this.fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_fkCurrency"]);
            this.currencyName = DS.Tables[0].Rows[0]["purord_currencyName"].ToString();
            this.quote = Convert.ToDouble(DS.Tables[0].Rows[0]["purord_quote"]);
            this.purchaseOrder = DS.Tables[0].Rows[0]["purord_purchaseOrder"].ToString();
            this.number = DS.Tables[0].Rows[0]["purord_number"].ToString();
            this.notes = DS.Tables[0].Rows[0]["purord_notes"].ToString();
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["purord_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["purord_modificatorUser"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["purord_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["purord_modifiedDate"]);
            this.lstPurchaseOrderDetail = clsPurchaseOrderDetail.getListByPurchaseOrder(codsec);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_purchaseorder(purord_fkStatus,purord_fkCommercialCondition,purord_fkEntity,purord_fkCurrency,purord_quote,purord_purchaseOrder,purord_number,purord_notes,purord_createdBy,purord_modifiedBy,purord_createdDate,purord_modifiedDate)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += this.fkCommercialCondition.ToString() + ",";
                    queryString += this.fkEntity.ToString() + ",";
                    queryString += this.fkCurrency.ToString() + ",";
                    queryString += this.quote.ToString() + ",";
                    queryString += "'" + this.purchaseOrder + "',";
                    queryString += "'" + this.number + "',";
                    queryString += "'" + this.notes + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += ");";
                   
                }
                else
                {
                    queryString += "UPDATE bps_admin_purchaseorder";
                    queryString += " SET ";
                    queryString += "purord_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "purord_fkCommercialCondition = " + this.fkCommercialCondition.ToString() + ",";
                    queryString += "purord_fkEntity = " + this.fkEntity.ToString() + ",";
                    queryString += "purord_fkCurrency = " + this.fkCurrency.ToString() + ",";
                    queryString += "purord_quote = " + this.quote.ToString() + ",";
                    queryString += "purord_purchaseOrder = '" + this.purchaseOrder + "',";
                    queryString += "purord_number = '" + this.number + "',";
                    queryString += "purord_notes = '" + this.notes + "',";
                    queryString += "purord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "purord_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += " WHERE purord_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);

                if (this.codsec == 0) 
                    this.codsec = clsPurchaseOrder.getLastPurchaseOrderCodsec();

                for (int i = 0; i < lstPurchaseOrderDetail.Count; i++)
                {
                    if (lstPurchaseOrderDetail[i].quantity > 0)
                    {
                        lstPurchaseOrderDetail[i].fkPurchaseOrder = this.codsec;
                        lstPurchaseOrderDetail[i].save();
                    }
                }

                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPurchaseOrder.save");
                return false;
            }
        }

        public static string getLastNumberOrder()
        {
            DataSet DS = new DataSet();
            int number = 0;

            try
            {
                DS = clsConnection.getDataSetResult("SELECT max(purord_number) FROM bps_admin_purchaseorder group by purord_codsec Order By purord_codsec DESC LIMIT 1");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    number = Convert.ToInt32(DS.Tables[0].Rows[0]["purord_number"]) + 1;
                }
                else
                {
                    number = 1;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPurchaseOrder.getLastNumberOrder");
                number = 1;
            }

            return number.ToString();
            
        }

        public static int getLastPurchaseOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT purord_codsec FROM vwpurchaseorder group by purord_codsec Order By purord_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["purord_codsec"]);
        }


        public static List<clsPurchaseOrder> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsPurchaseOrder> lstPurchaseOrder = new List<clsPurchaseOrder>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwpurchaseorder " + where + " group by purord_codsec order by purord_createdDate DESC");

            lstPurchaseOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPurchaseOrder.Add(new clsPurchaseOrder());
                lstPurchaseOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_codsec"]);
                lstPurchaseOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkEntity"]);
                lstPurchaseOrder[i].entityName = DS.Tables[0].Rows[i]["purord_entityName"].ToString();
                lstPurchaseOrder[i].entityId = DS.Tables[0].Rows[i]["purord_entityId"].ToString();
                lstPurchaseOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCommercialCondition"]);
                lstPurchaseOrder[i].comercialConditionName = DS.Tables[0].Rows[i]["purord_comercialConditionName"].ToString();
                lstPurchaseOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkStatus"]);
                lstPurchaseOrder[i].statusName = DS.Tables[0].Rows[i]["purord_statusName"].ToString();
                lstPurchaseOrder[i].fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCurrency"]);
                lstPurchaseOrder[i].currencyName = DS.Tables[0].Rows[i]["purord_currencyName"].ToString();
                lstPurchaseOrder[i].number = DS.Tables[0].Rows[i]["purord_number"].ToString();
                lstPurchaseOrder[i].notes = DS.Tables[0].Rows[i]["purord_notes"].ToString();
                lstPurchaseOrder[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["purord_quote"]);
                lstPurchaseOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["purord_purchaseOrder"].ToString();
                lstPurchaseOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_createdDate"]);
                lstPurchaseOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_createdBy"]);
                lstPurchaseOrder[i].creatorUser = DS.Tables[0].Rows[i]["purord_createdBy"].ToString();
                lstPurchaseOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_modifiedDate"]);
                lstPurchaseOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_modifiedBy"]);
                lstPurchaseOrder[i].modificatorUser = DS.Tables[0].Rows[i]["purord_modificatorUser"].ToString();

           
            }
            return lstPurchaseOrder;
        }


        public static List<clsPurchaseOrder> getList()
        {
            List<clsPurchaseOrder> lstPurchaseOrder = new List<clsPurchaseOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwpurchaseorder order by purord_createdDate DESC");

            lstPurchaseOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPurchaseOrder.Add(new clsPurchaseOrder());
                lstPurchaseOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_codsec"]);
                lstPurchaseOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkEntity"]);
                lstPurchaseOrder[i].entityName = DS.Tables[0].Rows[i]["purord_entityName"].ToString();
                lstPurchaseOrder[i].entityId = DS.Tables[0].Rows[i]["purord_entityId"].ToString();
                lstPurchaseOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCommercialCondition"]);
                lstPurchaseOrder[i].comercialConditionName = DS.Tables[0].Rows[i]["purord_comercialConditionName"].ToString();
                lstPurchaseOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkStatus"]);
                lstPurchaseOrder[i].statusName = DS.Tables[0].Rows[i]["purord_statusName"].ToString();
                lstPurchaseOrder[i].fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCurrency"]);
                lstPurchaseOrder[i].currencyName = DS.Tables[0].Rows[i]["purord_currencyName"].ToString();
                lstPurchaseOrder[i].number = DS.Tables[0].Rows[i]["purord_number"].ToString();
                lstPurchaseOrder[i].notes = DS.Tables[0].Rows[i]["purord_notes"].ToString();
                lstPurchaseOrder[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["purord_quote"]);
                lstPurchaseOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["purord_purchaseOrder"].ToString();
                lstPurchaseOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_createdDate"]);
                lstPurchaseOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_createdBy"]);
                lstPurchaseOrder[i].creatorUser = DS.Tables[0].Rows[i]["purord_createdBy"].ToString();
                lstPurchaseOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_modifiedDate"]);
                lstPurchaseOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_modifiedBy"]);
                lstPurchaseOrder[i].modificatorUser = DS.Tables[0].Rows[i]["purord_modificatorUser"].ToString();


            }
            return lstPurchaseOrder;
        }

        public static List<clsPurchaseOrder> getListPuchaseOrderActive()
        {
            List<clsPurchaseOrder> lstPurchaseOrder = new List<clsPurchaseOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwpurchaseorder where purord_statusName = 'Orden Activa' or purord_statusName = 'Parcialmente Recepcionada' order by purord_createdDate ASC");

            lstPurchaseOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPurchaseOrder.Add(new clsPurchaseOrder());
                lstPurchaseOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_codsec"]);
                lstPurchaseOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkEntity"]);
                lstPurchaseOrder[i].entityName = DS.Tables[0].Rows[i]["purord_entityName"].ToString();
                lstPurchaseOrder[i].entityId = DS.Tables[0].Rows[i]["purord_entityId"].ToString();
                lstPurchaseOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCommercialCondition"]);
                lstPurchaseOrder[i].comercialConditionName = DS.Tables[0].Rows[i]["purord_comercialConditionName"].ToString();
                lstPurchaseOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkStatus"]);
                lstPurchaseOrder[i].statusName = DS.Tables[0].Rows[i]["purord_statusName"].ToString();
                lstPurchaseOrder[i].fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_fkCurrency"]);
                lstPurchaseOrder[i].currencyName = DS.Tables[0].Rows[i]["purord_currencyName"].ToString();
                lstPurchaseOrder[i].number = DS.Tables[0].Rows[i]["purord_number"].ToString();
                lstPurchaseOrder[i].notes = DS.Tables[0].Rows[i]["purord_notes"].ToString();
                lstPurchaseOrder[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["purord_quote"]);
                lstPurchaseOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["purord_purchaseOrder"].ToString();
                lstPurchaseOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_createdDate"]);
                lstPurchaseOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_createdBy"]);
                lstPurchaseOrder[i].creatorUser = DS.Tables[0].Rows[i]["purord_createdBy"].ToString();
                lstPurchaseOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["purord_modifiedDate"]);
                lstPurchaseOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["purord_modifiedBy"]);
                lstPurchaseOrder[i].modificatorUser = DS.Tables[0].Rows[i]["purord_modificatorUser"].ToString();


            }
            return lstPurchaseOrder;
        }

       




        public int getPurchaseOrderStatusCodsec(string status)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT stt_codsec FROM bps_admin_status where stt_name = '" + status + "'");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["stt_codsec"]);
        }


        public double getTotalDeliverder(int codsec)
        {
            double recibido = 0;
            double pedido = 0;
            double total = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COALESCE(sum(rcp.`rcp_quantity`),0) as TotalRecibido FROM  `bps_admin_purchaseorderdetail` pod , `bps_prod_reception` rcp WHERE  pod.`purorddt_codsec` = rcp.`rcp_fkPurchaseOrderDetail` and pod.`purorddt_fkPurchaseOrder` = " + codsec.ToString());
            recibido = Convert.ToDouble(DS.Tables[0].Rows[0]["TotalRecibido"]);
            DataSet DS1 = new DataSet();
            DS1 = clsConnection.getDataSetResult("Select sum(pod.`purorddt_quantity`) as Pedido from `bps_admin_purchaseorderdetail` pod where pod.`purorddt_fkPurchaseOrder` = " + codsec.ToString());
            pedido = Convert.ToDouble(DS1.Tables[0].Rows[0]["Pedido"]);
            total = pedido - recibido;                
            return total;

        }


        public override string ToString()
        {
            return this.number.ToString();
        } 

    }
}
