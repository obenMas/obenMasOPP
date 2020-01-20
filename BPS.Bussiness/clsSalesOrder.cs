using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo de Ordenes de Venta 
    /// </summary>
    public class clsSalesOrder
    {
        //Atributes
        private int sord_codsec;
        private int sord_fkEntity;
        private string sord_EntityName;
        private string sord_EntityId;
        private int sord_fkCommercialCondition;
        private string sord_CommercialConditionName;
        private int sord_fkStatus;
        private string sord_StatusName;
        private string sord_number;
        private string sord_notes;
        private bool sord_isInternationalSale;
        private DateTime sord_deliveredDate;
        private DateTime sord_closingDate;
        private DateTime sord_createdDate;
        private DateTime sord_modifiedDate;
        private int sord_createdBy;
        private string sord_creatorUser;
        private int sord_modifiedBy;
        private string sord_modificatorUser;
        private clsExportData sord_ExportData;
        private List<clsSalesOrderDetail> sord_lstSalesOrderDetail;
        private double sord_totalByBoppFilm;
        private double sord_totalByCastFilm;
        private double sord_totalByCoatingFilm;
        private bool sord_isPlannifiedByFilm;
        private int sord_quantityByProductionOrder;
        private int sord_exportedToERP;
        private bool sord_hide;
        private DateTime sord_compromiseDate;
        private string sord_product;
        private int sord_codsecdetail;
        private string sord_boppcode;
        private double sord_quantity;
        private int sod_fkproduct;
        private int sord_width;
        private string sord_purchaseOrder;
        private int sord_fkPlant;

        //Properties

        public int codsec { get { return sord_codsec; } set { sord_codsec = value; } }

        public int fkEntity { get { return sord_fkEntity; } set { sord_fkEntity = value; } }

        public string EntityName { get { return sord_EntityName; } set { sord_EntityName = value; } }

        public string EntityID { get { return sord_EntityId; } set { sord_EntityId = value; } }

        public int fkCommercialCondition { get { return sord_fkCommercialCondition; } set { sord_fkCommercialCondition = value; } }

        public string CommercialConditionName { get { return sord_CommercialConditionName; } set { sord_CommercialConditionName = value; } }

        public int fkStatus { get { return sord_fkStatus; } set { sord_fkStatus = value; } }

        public string StatusName { get { return sord_StatusName; } set { sord_StatusName = value; } }

        public string number { get { return sord_number; } set { sord_number = value; } }

        public string notes { get { return sord_notes; } set { sord_notes = value; } }
        
        public bool isInternationalSale { get { return sord_isInternationalSale; } set { sord_isInternationalSale = value; } }

        public DateTime deliveredDate { get { return sord_deliveredDate; } set { sord_deliveredDate = value; } }

        public DateTime closingDate { get { return sord_closingDate; } set { sord_closingDate = value; } }

        public DateTime createdDate { get { return sord_createdDate; } set { sord_createdDate = value; } }

        public DateTime modifiedDate { get { return sord_modifiedDate; } set { sord_modifiedDate = value; } }

        public int createdBy { get { return sord_createdBy; } set { sord_createdBy = value; } }

        public string creatorUser { get { return sord_creatorUser; } set { sord_creatorUser = value; } }

        public int modifiedBy { get { return sord_modifiedBy; } set { sord_modifiedBy = value; } }

        public string modificatorUser { get { return sord_modificatorUser; } set { sord_modificatorUser = value; } }

        public clsExportData ExportData { get { return sord_ExportData; } set { sord_ExportData = value; } }

        public List<clsSalesOrderDetail> lstSalesOrderDetail { get { return sord_lstSalesOrderDetail; } set { sord_lstSalesOrderDetail = value; } }

        public double totalByBoppFilm { get { return sord_totalByBoppFilm; } set { sord_totalByBoppFilm = value; } }

        public double totalByCastFilm { get { return sord_totalByCastFilm; } set { sord_totalByCastFilm = value; } }

        public double totalByCoatingFilm { get { return sord_totalByCoatingFilm; } set { sord_totalByCoatingFilm = value; } }

        public bool isPlannifiedByFilm { get { return sord_isPlannifiedByFilm; } set { sord_isPlannifiedByFilm = value; } }

        public int quantityByProductionOrder { get { return sord_quantityByProductionOrder; } set { sord_quantityByProductionOrder = value; } }

        public int exportedToERP { get { return sord_exportedToERP; } set { sord_exportedToERP = value; } }

        public bool hide { get { return sord_hide; } set { sord_hide = value; } }

        public DateTime compromisedate { get { return sord_compromiseDate; } set { sord_compromiseDate = value; } }

        public string product { get { return sord_product; } set { sord_product = value; } }

        public int codsecDetail { get { return sord_codsecdetail; } set { sord_codsecdetail = value; } }

        public string boppCode { get { return sord_boppcode; } set { sord_boppcode = value; } }

        public double quantity { get { return sord_quantity; } set { sord_quantity = value; } }

        public int fkProduct { get { return sod_fkproduct; } set { sod_fkproduct = value; } }

        public int width { get { return sord_width; } set { sord_width = value; } }

        public string purchaseOrder { get { return sord_purchaseOrder; } set { sord_purchaseOrder = value; } }

        public int fkPlant { get { return sord_fkPlant; } set { sord_fkPlant = value; } }

        //Constructor

        public clsSalesOrder()
        { 
            sord_codsec = 0;
            sord_fkEntity = 0;
            sord_EntityName = "";
            sord_EntityId = "";
            sord_fkCommercialCondition = 0;
            sord_CommercialConditionName = "";
            sord_fkStatus = 0;
            sord_StatusName = "";
            sord_number = "";
            sord_notes = "";
            sord_isInternationalSale = false;
            sord_deliveredDate = DateTime.Now;
            sord_closingDate = DateTime.Now;
            sord_createdDate = DateTime.Now;
            sord_modifiedDate = DateTime.Now;
            sord_createdBy = 0;
            sord_creatorUser = "";
            sord_modifiedBy = 0;
            sord_modificatorUser = "";
            sord_ExportData = new clsExportData();
            sord_lstSalesOrderDetail = new List<clsSalesOrderDetail>();
            sord_totalByBoppFilm = 0;
            sord_totalByCastFilm = 0;
            sord_totalByCoatingFilm = 0;
            sord_isPlannifiedByFilm = false;
            sord_quantityByProductionOrder = 0;
            sord_exportedToERP = 0;
            sord_hide = false;
            sord_compromiseDate = DateTime.Now;
            sord_product = "";
            sord_width = 0;
            sord_purchaseOrder = "";
            sord_fkPlant=0;
        }

        public clsSalesOrder(int codsec)
        {
            this.load(codsec);
        }

        public clsSalesOrder(string number)
        {
            this.load(number);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                this.EntityID = DS.Tables[0].Rows[0]["sord_EntityId"].ToString();
                this.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                this.CommercialConditionName = DS.Tables[0].Rows[0]["sord_CommercialConditionName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["sord_StatusName"].ToString();
                this.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                this.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                this.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                this.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                this.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                this.ExportData = new clsExportData();
                if (this.isInternationalSale)
                    this.ExportData.getDetailBySalesOrder(this.codsec);
                this.lstSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(codsec);
                this.exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_exportedToERP"]);
                this.sord_purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                this.sord_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
                this.compromisedate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_compromiseDate"]);
            }
       }

        public void load(string number)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spGetSalesOrderByNumber('" + number.ToString() + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                this.EntityID = DS.Tables[0].Rows[0]["sord_EntityId"].ToString();
                this.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                this.CommercialConditionName = DS.Tables[0].Rows[0]["sord_CommercialConditionName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["sord_StatusName"].ToString();
                this.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                this.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                this.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                this.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                this.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                this.ExportData = new clsExportData();
                if (this.isInternationalSale)
                    this.ExportData.getDetailBySalesOrder(this.codsec);
                this.lstSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(codsec);
                this.exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_exportedToERP"]);
                this.sord_purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                this.sord_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
        }

        public void loadWithoutDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                this.EntityID = DS.Tables[0].Rows[0]["sord_EntityId"].ToString();
                this.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                this.CommercialConditionName = DS.Tables[0].Rows[0]["sord_CommercialConditionName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["sord_StatusName"].ToString();
                this.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                this.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                this.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                this.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                this.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                this.ExportData = new clsExportData();
                if (this.isInternationalSale)
                    this.ExportData.getDetailBySalesOrder(this.codsec);
                this.exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_exportedToERP"]);
                this.sord_purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                this.sord_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
        }

        public void loadWithoutShipping(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                this.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                this.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                this.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                this.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                this.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                this.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                this.hide = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_hide"], DS.Tables[0].Rows[0]["sord_hide"].GetType().FullName);
                this.sord_purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                this.sord_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
        }

        public void loadSimplifiedWithoutDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                this.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                this.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                this.sord_purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                this.sord_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
        }
        public bool save()
        {
            bool isNewSalesOreder = true;
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_com_salesorder (sord_fkEntity,sord_fkCommercialCondition,sord_fkStatus,sord_number,sord_notes,sord_isInternationalSale,sord_deliveredDate,sord_closingDate,sord_createdDate,sord_createdBy,sord_modifiedDate,sord_modifiedBy, sord_exportedToERP, sord_compromiseDate, sord_purchaseOrder, sord_fkPlant)";
                    queryString += " VALUES (";
                    queryString += this.fkEntity.ToString() + ",";
                    queryString += this.fkCommercialCondition.ToString() + ",";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += "'" + this.number + "',";
                    queryString += "'" + this.notes + "',";
                    queryString += "" + this.isInternationalSale.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "0,";
                    queryString += "'" + this.compromisedate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.sord_purchaseOrder.ToString() + "',";
                    queryString += this.sord_fkPlant.ToString() + ");";
                }
                else
                {
                    isNewSalesOreder = false;

                    queryString += "UPDATE bps_com_salesorder";
                    queryString += " SET ";
                    queryString += "sord_fkEntity = " + this.fkEntity.ToString() + ",";
                    queryString += "sord_fkCommercialCondition = " + this.fkCommercialCondition.ToString() + ",";
                    queryString += "sord_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "sord_number = '" + this.number + "',";
                    queryString += "sord_notes = '" + this.notes + "',";
                    queryString += "sord_isInternationalSale = " + this.isInternationalSale.ToString() + ",";
                    queryString += "sord_deliveredDate = '" + this.deliveredDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "sord_closingDate = '" + this.closingDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "sord_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "sord_createdBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "sord_modifiedDate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "sord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString()+ ",";
                    queryString += "sord_purchaseOrder = '" + this.sord_purchaseOrder.ToString() + "',";
                    queryString += "sord_fkPlant = " + this.sord_fkPlant.ToString();
                    queryString += " WHERE sord_codsec = " + this.codsec.ToString() + ";";
                }


                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                        this.codsec = clsSalesOrder.getLastSavedSalesOrderCodsec();

                    if (this.isInternationalSale == true)
                    {
                        this.ExportData.fkSalesOrder = this.codsec;
                        this.ExportData.save();
                    }
                    if (isNewSalesOreder == false)
                    {
                        clsSalesOrderDetail.checkDeletedSalesOrderDetails(lstSalesOrderDetail, codsec);
                    }
                    for (int i = 0; i < lstSalesOrderDetail.Count; i++)
                    {
                        if (lstSalesOrderDetail[i].fkProduct > 0)
                        {
                            lstSalesOrderDetail[i].fkSalesOrder = this.codsec;
                            lstSalesOrderDetail[i].save();
                        }
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrder.save");
                return false;
            }   
        }

        public bool updateforshipping()
        {
            try
            {
                string queryString = "";

                if (this.codsec != 0)
                {
                    queryString += "UPDATE bps_com_salesorder";
                    queryString += " SET ";
                    queryString += "sord_fkEntity = " + this.fkEntity.ToString() + ",";
                    queryString += "sord_fkCommercialCondition = " + this.fkCommercialCondition.ToString() + ",";
                    queryString += "sord_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "sord_number = '" + this.number + "',";
                    queryString += "sord_notes = '" + this.notes + "',";
                    queryString += "sord_isInternationalSale = " + this.isInternationalSale.ToString() + ",";
                    queryString += "sord_deliveredDate = '" + this.deliveredDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "sord_closingDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "sord_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "sord_createdBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "sord_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "sord_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "sord_hide = " + this.hide + "";
                    queryString += " WHERE sord_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrder.updateforshipping");
                return false;
            }
        }

        public static clsSalesOrder getDetailByNumber(string number)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByNumber('" + number + "')");
            clsSalesOrder objSalesOrder = new clsSalesOrder();

            if (DS.Tables[0].Rows.Count > 0)
            {
                objSalesOrder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                objSalesOrder.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                objSalesOrder.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                objSalesOrder.EntityID = DS.Tables[0].Rows[0]["sord_EntityId"].ToString();
                objSalesOrder.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                objSalesOrder.CommercialConditionName = DS.Tables[0].Rows[0]["sord_CommercialConditionName"].ToString();
                objSalesOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                objSalesOrder.StatusName = DS.Tables[0].Rows[0]["sord_StatusName"].ToString();
                objSalesOrder.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                objSalesOrder.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                objSalesOrder.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                objSalesOrder.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                objSalesOrder.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                objSalesOrder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                objSalesOrder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                objSalesOrder.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                objSalesOrder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                objSalesOrder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                objSalesOrder.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                objSalesOrder.ExportData = new clsExportData();
                if (objSalesOrder.isInternationalSale)
                    objSalesOrder.ExportData.getDetailBySalesOrder(objSalesOrder.codsec);
                objSalesOrder.lstSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(objSalesOrder.codsec);
                objSalesOrder.purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                objSalesOrder.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
            return objSalesOrder;
        }

        public static clsSalesOrder getDetailByNumberOnlySalesOrder(string number)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByNumber('" + number + "')");
            clsSalesOrder objSalesOrder = new clsSalesOrder();

            if (DS.Tables[0].Rows.Count > 0)
            {
                objSalesOrder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
                objSalesOrder.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkEntity"]);
                objSalesOrder.EntityName = DS.Tables[0].Rows[0]["sord_EntityName"].ToString();
                objSalesOrder.EntityID = DS.Tables[0].Rows[0]["sord_EntityId"].ToString();
                objSalesOrder.fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkCommercialCondition"]);
                objSalesOrder.CommercialConditionName = DS.Tables[0].Rows[0]["sord_CommercialConditionName"].ToString();
                objSalesOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkStatus"]);
                objSalesOrder.StatusName = DS.Tables[0].Rows[0]["sord_StatusName"].ToString();
                objSalesOrder.number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                objSalesOrder.notes = DS.Tables[0].Rows[0]["sord_notes"].ToString();
                objSalesOrder.isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["sord_isInternationalSale"], DS.Tables[0].Rows[0]["sord_isInternationalSale"].GetType().FullName);
                objSalesOrder.deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_deliveredDate"]);
                objSalesOrder.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_closingDate"]);
                objSalesOrder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_createdDate"]);
                objSalesOrder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_createdBy"]);
                objSalesOrder.creatorUser = DS.Tables[0].Rows[0]["sord_creatorUser"].ToString();
                objSalesOrder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sord_modifiedDate"]);
                objSalesOrder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_modifiedBy"]);
                objSalesOrder.modificatorUser = DS.Tables[0].Rows[0]["sord_modificatorUser"].ToString();
                objSalesOrder.ExportData = new clsExportData();
                //if (objSalesOrder.isInternationalSale)
                //    objSalesOrder.ExportData.getDetailBySalesOrder(objSalesOrder.codsec);
                //objSalesOrder.lstSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(objSalesOrder.codsec);
                objSalesOrder.purchaseOrder = DS.Tables[0].Rows[0]["sord_purchaseOrder"].ToString();
                objSalesOrder.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_fkPlant"]);
            }
            return objSalesOrder;
        }

        public static int getDetailByNumberSimple(int number)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByNumber(" + number.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
            else
                return 0;
            
        }
        public static List<clsSalesOrder> getList()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderList()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getActiveList()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spActiveSalesOrder()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }

        public static List<clsSalesOrder> getActiveListForPreShipping()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spActiveSalesOrderPreShipping()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorder " + where + " order by sord_createdDate DESC");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getList(bool isInternationalSale)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            if (isInternationalSale)
                DS = clsConnection.getDataSetResult("CALL spInternationalSalesOrderList()");
            else
                DS = clsConnection.getDataSetResult("CALL spNationalSalesOrderList()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }

        public static List<clsSalesOrder> getListByCoilReportSalesOrder(int isInternationalSale)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCoilBySalesOrder('" + isInternationalSale.ToString() + "')");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }

        public static List<clsSalesOrder> getListByFilter(List<clsFilter> lstFilter, bool isInternationalSale)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            if(lstFilter.Count == 0)
            {
                return lstSalesOrder;
            }

            DataSet DS = new DataSet();

            string where = "";

            if (lstFilter[0].field == "sord_number")
            {
                if (clsFilter.getSql(lstFilter) != "")
                    where = " WHERE sord_isInternationalSale = " + isInternationalSale.ToString() + " AND " + clsFilter.getSql(lstFilter);

                DS = clsConnection.getDataSetResult("SELECT TOP(100) * FROM vwsalesorder " + where + " order by sord_createdDate DESC");
            }
            else
            {
                if (clsFilter.getSql(lstFilter) != "")
                    where = " WHERE sord_isInternationalSale = " + isInternationalSale.ToString() + " AND " + clsFilter.getSql(lstFilter);

                DS = clsConnection.getDataSetResult("SELECT TOP(100) * FROM vwsalesorder " + where + " order by sord_createdDate DESC");
            }

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getListByEntity(int entityCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorder where sord_fkEntity = " + entityCodsec.ToString() + " order by sord_createdDate DESC");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }

        public static List<clsSalesOrder> getListByCommercialCondition(int conditionCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorder where sord_fkCommercialCondition = " + conditionCodsec.ToString() + " order by sord_createdDate DESC");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getListByBoppFilm(int boppCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByBoppFilm(" + boppCodsec.ToString() + ")");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].totalByBoppFilm = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_totalByBoppFilm"]);
                lstSalesOrder[i].isPlannifiedByFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isPlanned"], DS.Tables[0].Rows[i]["sord_isPlanned"].GetType().FullName);
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].product = DS.Tables[0].Rows[i]["sord_product"].ToString();
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static List<clsSalesOrder> getListByCastFilm(int castCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByCastFilm(" + castCodsec.ToString() + ")");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].sord_totalByCastFilm = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_totalByCastFilm"]);
                lstSalesOrder[i].isPlannifiedByFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isPlanned"], DS.Tables[0].Rows[i]["sord_isPlanned"].GetType().FullName);
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }
        public static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT sord_codsec FROM vwsalesorder Order By sord_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["sord_codsec"]);
        }
        public static string getNextNumber()
        {
            DataSet DS = new DataSet();
            int number = 0;

            try
            {
                DS = clsConnection.getDataSetResult("SELECT sord_number FROM vwsalesorder Order By sord_codsec DESC LIMIT 1");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    number = Convert.ToInt32(DS.Tables[0].Rows[0]["sord_number"]) + 1;
                }
                else
                {
                    number = 1;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrder.getNextNumber");
                number = 1;
            }

            return number.ToString();
        }

        public static List<clsSalesOrder> getListByProductionOrder(int productionOrderCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorder, bps_prod_productionorderpersalesorder where sord_codsec = popso_fkOrder AND popso_fkProductionOrder = " + productionOrderCodsec.ToString() + " order by sord_createdDate DESC");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSalesOrder());
                lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstSalesOrder[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                lstSalesOrder[i].quantityByProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["popso_quantity"]);
                lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
            }
            return lstSalesOrder;
        }

        public override string ToString()
        {
            if (this.codsec != 0)
                return "" + this.number + "   -   " +  this.EntityName ;
            else
                return "STOCK";
        }

        public static bool IsUniqueSalesOrderNumber(string salesOrderNumber, int salesOrderCodsec)
        {
            bool isUnique = true;

            if (salesOrderCodsec == 0)
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorder where sord_number = '" + salesOrderNumber + "'");

                if (DS.Tables[0].Rows.Count > 0)
                    isUnique = false;
            }
            else
                isUnique = true;

            return isUnique;
        }
        public static void setAsCompleted(int salesOrderCodsec)
        {
            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de Venta", "Completa");

            clsConnection.executeQuery("UPDATE bps_com_salesorder SET sord_fkStatus = " + objStatus.codsec.ToString() + " where sord_codsec = " + salesOrderCodsec.ToString());

        }
        public static void closeSalesOrder(int salesOrderCodsec)
        {

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de Venta", "Cerrada");

            clsConnection.executeQuery("UPDATE bps_com_salesorder SET sord_fkStatus where sord_codsec = " + salesOrderCodsec.ToString());
        }
        public static List<clsSalesOrder> getListByMetalizedProduct(int boppCodsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("EXECUTE spSalesOrderByMetalizeBopp " + boppCodsec.ToString());

            lstSalesOrder.Clear();

            if(DS.Tables.Count>0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstSalesOrder.Add(new clsSalesOrder());
                    lstSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                    lstSalesOrder[i].codsecDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                    lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                    lstSalesOrder[i].product = DS.Tables[0].Rows[i]["prod_code"].ToString();
                    lstSalesOrder[i].boppCode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                    lstSalesOrder[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                    lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                    lstSalesOrder[i].totalByBoppFilm = Convert.ToDouble(DS.Tables[0].Rows[i]["cuttingweigth"]);
                    lstSalesOrder[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                    //lstSalesOrder[i].EntityID = DS.Tables[0].Rows[i]["sord_EntityId"].ToString();
                    //lstSalesOrder[i].fkCommercialCondition = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkCommercialCondition"]);
                    //lstSalesOrder[i].CommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                    lstSalesOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                    lstSalesOrder[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                    //lstSalesOrder[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                    //lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                    //lstSalesOrder[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();

                    //lstSalesOrder[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                    //lstSalesOrder[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);

                    //lstSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                    //lstSalesOrder[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                    //lstSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                    //lstSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                    //lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                    //lstSalesOrder[i].totalByBoppFilm = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_totalByBoppFilm"]);
                    //lstSalesOrder[i].isPlannifiedByFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isPlanned"], DS.Tables[0].Rows[i]["sord_isPlanned"].GetType().FullName);
                    //lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
                    lstSalesOrder[i].purchaseOrder = DS.Tables[0].Rows[i]["sord_purchaseOrder"].ToString();
                    lstSalesOrder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkPlant"]);
                }
            }
            
            return lstSalesOrder;
        }

        public static string GetOrdinalNumber()
        {
            string ret = "P"+DateTime.Now.Year.ToString();
            string mon = "";
            if(DateTime.Now.Month < 10)
            {
                mon = DateTime.Now.Month.ToString();
            }
            else
            {
                switch(DateTime.Now.Month)
                {
                    case 10:
                        mon = "A";
                        break;

                    case 11:
                        mon = "B";
                        break;

                    case 12:
                        mon = "C";
                        break;
                }
            }
            int seq = clsSequential.SequentialList("salesOrder");
            clsSequential.addSequential("salesOrder");
            if(seq<10)
            {
                ret = ret + mon +"000"+ seq.ToString();
            }
            else if(seq<100)
            {
                ret = ret + mon + "00" + seq.ToString();
            }
            else if(seq<1000)
            {
                ret = ret + mon + "0" + seq.ToString();
            }
            else
            {
                ret = ret + mon + seq.ToString();
            }
            return ret;
        }
        public bool UpdateOc(string purchaseorder)
        {
            this.purchaseOrder = purchaseorder;
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_com_salesorder";
                queryString += " SET ";
                queryString += " sord_purchaseOrder = '" + this.purchaseOrder.ToString() + "' ";
                queryString += " WHERE sord_codsec = " + this.codsec.ToString();

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrder.update");
                return false;
            }
        }
    }
}
