using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de produccion para BOPP/Cast/Coating/Termoformado
    /// </summary>
    public class clsProductionOrder
    {
        //Atributes

        private int pord_codsec;
        private int pord_fkBopp;
        private clsBopp pord_Bopp;
        private int pord_fkBoppOriginal;
        private clsBopp pord_BoppOriginal;
        private int pord_fkCast;
        private clsCast pord_Cast;
        private int pord_fkCoating;
        private clsCoating pord_Coating;
        private int pord_fkThermoformed;
        private string pord_ThermoformedName;
        private int pord_fkReprocessed;
        private string pord_ReprocessedName;
        private int pord_fkStatus;
        private string pord_StatusName;
        private int pord_number;
        private double pord_quantity;
        private int pord_inheritedFrom;
        private string pord_closeObservation;
        private DateTime pord_createdDate;
        private DateTime pord_modifiedDate;
        private int pord_createdBy;
        private string pord_creatorUser;
        private int pord_modifiedBy;
        private string pord_modificatorUser;
        private List<clsSalesOrder> pord_lstSalesOrder;
        private string pord_customerLists;
        private Boolean pord_createdFromOtherOrder;



        //Properties

        public int codsec { get { return pord_codsec; } set { pord_codsec = value; } }

        public int fkBopp { get { return pord_fkBopp; } set { pord_fkBopp = value; } }

        public clsBopp Bopp { get { return pord_Bopp; } set { pord_Bopp = value; } }

        public int fkBoppOriginal { get { return pord_fkBoppOriginal; } set { pord_fkBoppOriginal = value; } }

        public clsBopp BoppOriginal { get { return pord_BoppOriginal; } set { pord_BoppOriginal = value; } }

        public int fkCast { get { return pord_fkCast; } set { pord_fkCast = value; } }

        public clsCast Cast { get { return pord_Cast; } set { pord_Cast = value; } }

        public int fkCoating { get { return pord_fkCoating; } set { pord_fkCoating = value; } }

        public clsCoating Coating { get { return pord_Coating; } set { pord_Coating = value; } }

        public int fkThermoformed { get { return pord_fkThermoformed; } set { pord_fkThermoformed = value; } }

        public string ThermoformedName { get { return pord_ThermoformedName; } set { pord_ThermoformedName = value; } }

        public int fkReprocessed { get { return pord_fkReprocessed; } set { pord_fkReprocessed = value; } }

        public string ReprocessedName { get { return pord_ReprocessedName; } set { pord_ReprocessedName = value; } }

        public int fkStatus { get { return pord_fkStatus; } set { pord_fkStatus = value; } }

        public int number { get { return pord_number; } set { pord_number = value; } }

        public double quantity { get { return pord_quantity; } set { pord_quantity = value; } }

        public string StatusName { get { return pord_StatusName; } set { pord_StatusName = value; } }

        public int inheritedFrom { get { return pord_inheritedFrom; } set { pord_inheritedFrom = value; } }

        public string closeObservation { get { return pord_closeObservation; } set { pord_closeObservation = value; } }

        public DateTime createdDate { get { return pord_createdDate; } set { pord_createdDate = value; } }

        public DateTime modifiedDate { get { return pord_modifiedDate; } set { pord_modifiedDate = value; } }

        public int createdBy { get { return pord_createdBy; } set { pord_createdBy = value; } }

        public string creatorUser { get { return pord_creatorUser; } set { pord_creatorUser = value; } }

        public int modifiedBy { get { return pord_modifiedBy; } set { pord_modifiedBy = value; } }

        public string modificatorUser { get { return pord_modificatorUser; } set { pord_modificatorUser = value; } }

        public List<clsSalesOrder> lstSalesOrder{get{return pord_lstSalesOrder;}set{pord_lstSalesOrder = value;}}

        public string customerLists { get { return pord_customerLists; } set { pord_customerLists = value; } }

        public Boolean createdFromOtherOrder { get { return pord_createdFromOtherOrder; } set { pord_createdFromOtherOrder = value; } }


        //Constructor

        public clsProductionOrder()
        { 
            pord_codsec = 0;
            pord_fkBopp= 0;
            pord_Bopp = new clsBopp();
            pord_fkBoppOriginal = 0;
            pord_BoppOriginal = new clsBopp();
            pord_fkCast = 0;
            pord_Cast = new clsCast();
            pord_fkCoating = 0;
            pord_Coating = new clsCoating();
            pord_fkThermoformed = 0;
            pord_ThermoformedName = "";
            pord_fkReprocessed = 0;
            pord_ReprocessedName = "";
            pord_fkStatus = 0;
            pord_StatusName = "";
            pord_number = 0;
            pord_quantity = 0;
            pord_inheritedFrom = 0;
            pord_closeObservation = "";
            pord_createdDate = DateTime.Now;
            pord_modifiedDate = DateTime.Now;
            pord_createdBy = 0;
            pord_creatorUser = "";
            pord_modifiedBy = 0;
            pord_modificatorUser = "";
            pord_lstSalesOrder = new List<clsSalesOrder>();
            pord_customerLists = "";
            pord_createdFromOtherOrder = false;
        }
        public clsProductionOrder(int productionOrderCodsec)
        {
            this.load(productionOrderCodsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spProductionOrderByCodsec " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBopp"]);
                this.Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBopp"]));
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkCast"]);
                this.fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBoppOriginal"]);
                this.BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBoppOriginal"]));
                this.Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkCast"]));
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["pord_StatusName"].ToString();
                this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_number"]);
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["pord_quantity"]);
                this.inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_inheritedFrom"]);
                this.closeObservation = DS.Tables[0].Rows[0]["pord_closeObservation"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pord_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pord_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["pord_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["pord_modificatorUser"].ToString();
                this.lstSalesOrder = clsSalesOrder.getListByProductionOrder(this.codsec);
                this.createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pord_createdFromOtherOrder"], DS.Tables[0].Rows[0]["pord_createdFromOtherOrder"].GetType().FullName);
                for (int i = 0; i < this.lstSalesOrder.Count; i++)
                {
                    this.customerLists += this.lstSalesOrder[i].EntityName + "(" + this.lstSalesOrder[i].number.ToString() + "); ";
                }
            }
        }

        public void load(int codsec, bool data)
        {
            DataSet DS = new DataSet();
            
            DS = clsConnection.getDataSetResult("CALL spProductionOrderByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBopp"]);
                this.Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBopp"]));
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkCast"]);
                this.fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBoppOriginal"]);
                this.BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkBoppOriginal"]));
                this.Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkCast"]));
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["pord_StatusName"].ToString();
                this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_number"]);
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["pord_quantity"]);
                this.inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_inheritedFrom"]);
                this.closeObservation = DS.Tables[0].Rows[0]["pord_closeObservation"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pord_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pord_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["pord_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["pord_modificatorUser"].ToString();
                this.lstSalesOrder = clsSalesOrder.getListByProductionOrder(this.codsec);
                this.createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pord_createdFromOtherOrder"], DS.Tables[0].Rows[0]["pord_createdFromOtherOrder"].GetType().FullName);
                for (int i = 0; i < this.lstSalesOrder.Count; i++)
                {
                    this.customerLists += this.lstSalesOrder[i].EntityName + "(" + this.lstSalesOrder[i].number.ToString() + "); ";
                }
            }
        }

        public bool save()
        {
            string productionOrderType = "";
            string queryString = "";
            clsStatus objStatus = new clsStatus();

            try
            {
                if (this.fkBopp != 0)
                    productionOrderType = "Bopp";
                else if (this.fkCast != 0)
                    productionOrderType = "Cast";
                else if (this.fkCoating != 0)
                    productionOrderType = "Coating";

                if (this.codsec == 0 && this.createdFromOtherOrder == false)
                    objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", "Sin Planificar");
                else
                    objStatus.load(this.fkStatus);

                switch (productionOrderType)
                {
                    case "Bopp":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_productionorder (pord_fkBopp, pord_fkBoppOriginal, pord_fkThermoformed, pord_fkReprocessed, pord_fkStatus, pord_number, pord_quantity, pord_inheritedFrom, pord_closeObservation,pord_createdDate, pord_modifiedDate, pord_createdBy, pord_modifiedBy, pord_createdFromOtherOrder)";
                            queryString += " VALUES (";
                            queryString += " " + this.fkBopp.ToString() +",";
                            queryString += " " + this.fkBoppOriginal.ToString() +",";
                            queryString += " " + this.fkThermoformed.ToString()  + ",";
                            queryString += " " + this.fkReprocessed.ToString() +",";
                            queryString += " " + objStatus.codsec.ToString()  + ",";
                            queryString += " " + this.number.ToString()  + ",";
                            queryString += " " + this.quantity.ToString()  + ",";
                            queryString += " " + this.inheritedFrom.ToString()  + ",";
                            queryString += " '" + this.closeObservation.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + this.createdFromOtherOrder.ToString() + ");";
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_productionorder";
                            queryString += " SET ";
                            queryString += " pord_fkBopp = " + this.fkBopp.ToString() + ",";
                            queryString += " pord_fkBoppOriginal = " + this.fkBoppOriginal.ToString() + ",";
                            queryString += " pord_fkThermoformed = " + this.fkThermoformed.ToString() + ",";
                            queryString += " pord_fkReprocessed = " + this.fkReprocessed.ToString() + ",";
                            queryString += " pord_number = " + this.number.ToString() + ",";
                            queryString += " pord_quantity = " + this.quantity.ToString() + ",";
                            queryString += " pord_closeObservation = '" + this.closeObservation.ToString() + "',";
                            queryString += " pord_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " pord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                            queryString += " WHERE pord_codsec = " + this.codsec.ToString()+";";   
                        }
                        break;
                    case "Cast":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_productionorder (pord_fkCast, pord_fkThermoformed, pord_fkReprocessed, pord_fkStatus, pord_number, pord_quantity, pord_inheritedFrom, pord_closeObservation,pord_createdDate, pord_modifiedDate, pord_createdBy, pord_modifiedBy, pord_createdFromOtherOrder)";
                            queryString += " VALUES (";
                            queryString += " " + this.fkCast.ToString() + ",";
                            queryString += " " + this.fkThermoformed.ToString() + ",";
                            queryString += " " + this.fkReprocessed.ToString() + ",";
                            queryString += " " + objStatus.codsec.ToString() + ",";
                            queryString += " " + this.number.ToString() + ",";
                            queryString += " " + this.quantity.ToString() + ",";
                            queryString += " " + this.inheritedFrom.ToString() + ",";
                            queryString += " '" + this.closeObservation.ToString() + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + this.createdFromOtherOrder.ToString() + ");";
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_productionorder";
                            queryString += " SET ";
                            queryString += " pord_fkCast = " + this.fkCast.ToString() + ",";
                            queryString += " pord_fkThermoformed = " + this.fkThermoformed.ToString() + ",";
                            queryString += " pord_fkReprocessed = " + this.fkReprocessed.ToString() + ",";
                            queryString += " pord_number = " + this.number.ToString() + ",";
                            queryString += " pord_quantity = " + this.quantity.ToString() + ",";
                            queryString += " pord_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " pord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                            queryString += " WHERE pord_codsec = " + this.codsec.ToString() + ";";
                        }
                        break;
                    case "Coating":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_productionorder (pord_fkCoating, pord_fkThermoformed, pord_fkReprocessed, pord_fkStatus, pord_inheritedFrom, pord_initDate, pord_endDate, pord_createdDate, pord_modifiedDate, pord_createdBy, pord_modifiedBy)";
                            queryString += " VALUES (";
                            queryString += " " + this.fkCoating.ToString() + ",";
                            queryString += " " + this.fkThermoformed.ToString() + ",";
                            queryString += " " + this.fkReprocessed.ToString() + ",";
                            queryString += " " + objStatus.codsec.ToString() + ",";
                            queryString += " " + this.number.ToString() + ",";
                            queryString += " " + this.quantity.ToString() + ",";
                            queryString += " " + this.inheritedFrom.ToString() + ",";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                            queryString += " " + this.createdFromOtherOrder.ToString() + ");";
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_productionorder";
                            queryString += " SET ";
                            queryString += " pord_fkCoating = " + this.fkCoating.ToString() + ",";
                            queryString += " pord_fkThermoformed = " + this.fkThermoformed.ToString() + ",";
                            queryString += " pord_fkReprocessed = " + this.fkReprocessed.ToString() + ",";
                            queryString += " pord_number = " + this.number.ToString() + ",";
                            queryString += " pord_quantity = " + this.quantity.ToString() + ",";
                            queryString += " pord_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                            queryString += " pord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                            queryString += " WHERE pord_codsec = " + this.codsec.ToString() + ";";
                        }
                        break;
                    default:
                        break;
                }

                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                        this.codsec = getLastSavedCodsec();
                    if (clsConnection.executeQuery("DELETE FROM bps_prod_productionorderpersalesorder WHERE popso_fkProductionOrder = " + this.codsec.ToString()))
                    {
                        for (int i = 0; i < this.lstSalesOrder.Count; i++)
                        {
                            clsConnection.executeQuery("INSERT INTO bps_prod_productionorderpersalesorder (`popso_fkProductionOrder`, `popso_fkOrder`,`popso_quantity`  ) VALUES (" + this.codsec.ToString() + ", " + this.lstSalesOrder[i].codsec.ToString() + ", " + this.lstSalesOrder[i].quantityByProductionOrder + ");");
                            List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();
                            if (productionOrderType == "Bopp")
                                lstSalesOrderDetail = clsSalesOrderDetail.getListByBoppFilm(lstSalesOrder[i].codsec, this.fkBopp);
                            if (productionOrderType == "Cast")
                                lstSalesOrderDetail = clsSalesOrderDetail.getListByCastFilm(lstSalesOrder[i].codsec, this.fkCast);

                            //for (int j = 0; j < lstSalesOrderDetail.Count; j++)
                                //clsSalesOrderDetail.changeStatus(lstSalesOrderDetail[j].codsec, "Planificada");
                        }
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProductionOrder.save");
                return false;
            }
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pord_codsec FROM bps_prod_productionorder ORDER BY pord_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["pord_codsec"]);
        }
        public static List<clsProductionOrder> getList()
        {

            DataSet DS = new DataSet();
            List<clsProductionOrder> lstProductionOrders = new List<clsProductionOrder>();

            DS = clsConnection.getDataSetResult("CALL spProductionOrderList()");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrder());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]);
                    lstProductionOrders[i].Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]));
                    lstProductionOrders[i].fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]);
                    lstProductionOrders[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]);
                    lstProductionOrders[i].Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]));
                    lstProductionOrders[i].BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]));
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["pord_StatusName"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pord_quantity"]);
                    lstProductionOrders[i].inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_inheritedFrom"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_createdBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["pord_creatorUser"].ToString();
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_modifiedBy"]);
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["pord_modificatorUser"].ToString();
                    lstProductionOrders[i].lstSalesOrder = clsSalesOrder.getListByProductionOrder(lstProductionOrders[i].codsec);
                    lstProductionOrders[i].createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"], DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"].GetType().FullName);
                    for (int j = 0; i < lstProductionOrders[j].lstSalesOrder.Count; i++)
                    {
                        lstProductionOrders[i].customerLists += lstProductionOrders[i].lstSalesOrder[i].EntityName + "(" + lstProductionOrders[i].lstSalesOrder[j].number.ToString() + "); ";
                    }
                }
            }
            return lstProductionOrders;
        }
        public static List<clsProductionOrder> getListWithoutPlanning()
        {
            DataSet DS = new DataSet();
            List<clsProductionOrder> lstProductionOrders = new List<clsProductionOrder>();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwproductionorder WHERE pord_fkStatus=17");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrder());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]);
                    lstProductionOrders[i].Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]));
                    lstProductionOrders[i].fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]);
                    lstProductionOrders[i].BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]));
                    lstProductionOrders[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]);
                    lstProductionOrders[i].Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]));
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["pord_StatusName"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pord_quantity"]);
                    lstProductionOrders[i].inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_inheritedFrom"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_createdBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["pord_creatorUser"].ToString();
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_modifiedBy"]);
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["pord_modificatorUser"].ToString();
                    lstProductionOrders[i].lstSalesOrder = clsSalesOrder.getListByProductionOrder(lstProductionOrders[i].codsec);
                    lstProductionOrders[i].createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"], DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"].GetType().FullName);
                }
            }

            return lstProductionOrders;
        }
        public static List<clsProductionOrder> getListByFilter(List<clsFilter> lstFilter)
        {

            DataSet DS = new DataSet();
            List<clsProductionOrder> lstProductionOrders = new List<clsProductionOrder>();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = "WHERE  " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwproductionorder " + where);

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrder());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]);
                    lstProductionOrders[i].Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBopp"]));
                    lstProductionOrders[i].fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]);
                    lstProductionOrders[i].BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkBoppOriginal"]));
                    lstProductionOrders[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]);
                    lstProductionOrders[i].Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkCast"]));
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["pord_StatusName"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pord_quantity"]);
                    lstProductionOrders[i].inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_inheritedFrom"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pord_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_createdBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["pord_creatorUser"].ToString();
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_modifiedBy"]);
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["pord_modificatorUser"].ToString();
                    lstProductionOrders[i].lstSalesOrder = clsSalesOrder.getListByProductionOrder(lstProductionOrders[i].codsec);
                    lstProductionOrders[i].createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"], DS.Tables[0].Rows[i]["pord_createdFromOtherOrder"].GetType().FullName);
                    for (int j = 0; j < lstProductionOrders[i].lstSalesOrder.Count; j++)
                        lstProductionOrders[i].customerLists += lstProductionOrders[i].lstSalesOrder[j].EntityName + "(" + lstProductionOrders[i].lstSalesOrder[j].number.ToString() + "); ";
                }
            }

            return lstProductionOrders;
        }
        public static void changeOrderStatus(int codsec, string status)
        {
            clsStatus objStatus = new clsStatus();
            string queryString = "";

            try
            {
                if (status == "Cerrada")
                {
                    objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", status);
                    queryString += "UPDATE bps_prod_productionorder";
                    queryString += " SET ";
                    queryString += " pord_fkStatus = " + objStatus.codsec.ToString() + ", ";
                    queryString += " pord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += " pord_modifiedDate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " pord_closeObservation = 'Orden Cerrada en EXTRUSION '";
                    queryString += " WHERE pord_codsec = " + codsec + ";";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", status);
                    queryString += "UPDATE bps_prod_productionorder";
                    queryString += " SET ";
                    queryString += " pord_fkStatus = " + objStatus.codsec.ToString() + ", ";
                    queryString += " pord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += " pord_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " pord_closeObservation = 'Orden Anulada en el dep. programación'";
                    queryString += " WHERE pord_codsec = " + codsec + ";";
                    clsConnection.executeQuery(queryString);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "changeOrderStatus.save");
            }
        }


        public static int getNextNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pord_number FROM vwproductionorder Order By pord_number DESC LIMIT 1");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["pord_number"]) + 1;
            else
                return 1;
        }

        public void close()
        {
            clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
            objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(this.codsec);

            List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(objFilmProductionPlan.fkMachine);

            objFilmProductionPlan.estimatedEndDate = DateTime.Now;
            objFilmProductionPlan.save();

            DateTime initDate = new DateTime();
            if (lstFilmProductionPlan.Count > 0)
                initDate = DateTime.Now;

            for (int i = 1; i < lstFilmProductionPlan.Count; i++)
            {
                if (i == 1)
                {
                    lstFilmProductionPlan[i].estimatedInitDate = initDate;
                    lstFilmProductionPlan[i].estimatedEndDate = initDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                else
                {
                    lstFilmProductionPlan[i].estimatedInitDate = lstFilmProductionPlan[i - 1].estimatedEndDate;
                    lstFilmProductionPlan[i].estimatedEndDate = lstFilmProductionPlan[i].estimatedInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                lstFilmProductionPlan[i].save();
            }

            clsProductionOrder.changeOrderStatus(this.codsec, "Cerrada");            
        }

        public static int toCheckStatus(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pord_fkStatus FROM bps_prod_productionorder WHERE pord_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["pord_fkStatus"]);
            else
                return 0;
        }
        public static bool DeleteByCodsec(int codsec)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_productionorder WHERE pord_codsec=" + codsec.ToString());
        }
        public bool UpdateStatusToPlanned()
        {
            return clsConnection.executeQuery("UPDATE bps_prod_productionorder SET pord_fkStatus=18 WHERE pord_codsec=" + codsec.ToString());
        }
        public bool UpdateStatusToUnplanned()
        {
            return clsConnection.executeQuery("UPDATE bps_prod_productionorder SET pord_fkStatus=17 WHERE pord_codsec=" + codsec.ToString());
        }
    }
}
