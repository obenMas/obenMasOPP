using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsChangeSalesOrder
    {
        //Attributes

        private int cso_codsec;
        private int cso_fkOriginalSalesOrderDetail;
        private clsSalesOrder cso_originalSalesOrder;
        private clsSalesOrderDetail cso_originalSalesOrderDetail;
        private int cso_fkDestinationSalesOrderDetail;
        private clsSalesOrder cso_destinationSalesOrder;
        private clsSalesOrderDetail cso_destinationSalesOrderDetail;
        private int cso_fkStatus;
        private string cso_statusName;
        private int cso_fkProduct;
        private clsProduct cso_objProduct;
        private int cso_coilsToChange;
        private string cso_notes;
        private DateTime cso_createdDate;
        private DateTime cso_modifiedDate;
        private int cso_createdBy;
        private int cso_modifiedBy;
        private List<clsChangeSalesOrderDetail> cso_lstChangeSalesOrderDetail;

        // Properties

        public int codsec { get { return cso_codsec; } set { cso_codsec = value; } }

        public int fkOriginalSalesOrderDetail { get { return cso_fkOriginalSalesOrderDetail; } set { cso_fkOriginalSalesOrderDetail = value; } }

        public clsSalesOrder originalSalesOrder { get { return cso_originalSalesOrder; } set { cso_originalSalesOrder = value; } }

        public clsSalesOrderDetail originalSalesOrderDetail { get { return cso_originalSalesOrderDetail; } set { cso_originalSalesOrderDetail = value; } }

        public int fkDestinationSalesOrderDetail { get { return cso_fkDestinationSalesOrderDetail; } set { cso_fkDestinationSalesOrderDetail = value; } }

        public clsSalesOrder destinationSalesOrder { get { return cso_destinationSalesOrder; } set { cso_destinationSalesOrder = value; } }

        public clsSalesOrderDetail destinationSalesOrderDetail { get { return cso_destinationSalesOrderDetail; } set { cso_destinationSalesOrderDetail = value; } }

        public int fkProduct { get { return cso_fkProduct; } set { cso_fkProduct = value; } }

        public clsProduct objProduct { get { return cso_objProduct; } set { cso_objProduct = value; } }

        public int fkStatus { get { return cso_fkStatus; } set { cso_fkStatus = value; } }

        public string statusName { get { return cso_statusName; } set { cso_statusName = value; } }

        public int coilsToChange { get { return cso_coilsToChange; } set { cso_coilsToChange = value; } }

        public string notes { get { return cso_notes; } set { cso_notes = value; } }

        public DateTime createdDate { get { return cso_createdDate; } set { cso_createdDate = value; } }

        public DateTime modifiedDate { get { return cso_modifiedDate; } set { cso_modifiedDate = value; } }

        public int createdBy { get { return cso_createdBy; } set { cso_createdBy = value; } }

        public int modifiedBy { get { return cso_modifiedBy; } set { cso_modifiedBy = value; } }

        public List<clsChangeSalesOrderDetail> lstChangeSalesOrderDetail { get { return cso_lstChangeSalesOrderDetail; } set { cso_lstChangeSalesOrderDetail = value; } }

        // Constructor

        public clsChangeSalesOrder()
        {
            cso_codsec = 0;
            cso_fkOriginalSalesOrderDetail = 0;
            cso_originalSalesOrder = new clsSalesOrder();
            cso_originalSalesOrderDetail = new clsSalesOrderDetail();
            cso_fkDestinationSalesOrderDetail = 0;
            cso_destinationSalesOrder = new clsSalesOrder();
            cso_destinationSalesOrderDetail = new clsSalesOrderDetail();
            cso_fkProduct = 0;
            cso_objProduct = new clsProduct();
            cso_fkStatus = 0;
            cso_statusName = "";
            cso_coilsToChange = 0;
            cso_notes = "";
            cso_createdDate = DateTime.Now;
            cso_modifiedDate = DateTime.Now;
            cso_createdBy = 0;
            cso_modifiedBy = 0;
            cso_lstChangeSalesOrderDetail = new List<clsChangeSalesOrderDetail>();
        }

        public clsChangeSalesOrder(int changeCodsec)
        {
            this.load(changeCodsec);
        }
        // Methods

        public void load(int changeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spChangeSalesOrderDetail(" + changeCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_codsec"]);
                this.fkOriginalSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkOriginalSalesOrderDetail"]);
                this.originalSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkOriginalSalesOrderDetail"]));
                this.originalSalesOrder = new clsSalesOrder(this.originalSalesOrderDetail.fkSalesOrder);
                this.fkDestinationSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkDestinationSalesOrderDetail"]);
                this.destinationSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkDestinationSalesOrderDetail"]));
                this.destinationSalesOrder = new clsSalesOrder(destinationSalesOrderDetail.fkSalesOrder);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkProduct"]);
                this.objProduct = new clsProduct(fkProduct);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["cso_statusName"].ToString();
                this.coilsToChange = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_coilsToChange"]);
                this.notes = DS.Tables[0].Rows[0]["cso_notes"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cso_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cso_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cso_modifiedBy"]);
                this.lstChangeSalesOrderDetail = clsChangeSalesOrderDetail.getListByChangeSalesOrder(this.codsec);
            }

        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    if (this.fkOriginalSalesOrderDetail > 0 && this.fkDestinationSalesOrderDetail > 0)
                    {
                        clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Cambio de orden", "Activa");

                        queryString += "INSERT INTO bps_prod_changesalesorder (cso_fkOriginalSalesOrderDetail, cso_fkDestinationSalesOrderDetail, cso_fkProduct, cso_fkStatus, cso_coilsToChange, cso_notes, cso_createdDate, cso_modifiedDate, cso_createdBy, cso_modifiedBy)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkOriginalSalesOrderDetail.ToString() + ", ";
                        queryString += "" + this.fkDestinationSalesOrderDetail.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "" + clsStatus.getStatusByStatusGroupNameAndStatusName("Cambio de orden", "Activa").codsec +", ";
                        queryString += "" + this.coilsToChange.ToString() + ", ";
                        queryString += "'" + this.notes + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + " ";
                        queryString += ");";
                    }
                    else if (this.fkDestinationSalesOrderDetail == 0)
                    {
                        clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Cambio de orden", "Activa");

                        queryString += "INSERT INTO bps_prod_changesalesorder (cso_fkOriginalSalesOrderDetail, cso_fkProduct, cso_fkStatus, cso_coilsToChange, cso_notes, cso_createdDate, cso_modifiedDate, cso_createdBy, cso_modifiedBy)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkOriginalSalesOrderDetail.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "" + clsStatus.getStatusByStatusGroupNameAndStatusName("Cambio de orden", "Activa").codsec +", ";
                        queryString += "" + this.coilsToChange.ToString() + ", ";
                        queryString += "'" + this.notes + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + " ";
                        queryString += ");";
                    }
                    else
                    {
                        queryString += "INSERT INTO bps_prod_changesalesorder (cso_fkDestinationSalesOrderDetail, cso_fkProduct, cso_fkStatus, cso_coilsToChange, cso_notes, cso_createdDate, cso_modifiedDate, cso_createdBy, cso_modifiedBy)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkDestinationSalesOrderDetail.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "" + clsStatus.getStatusByStatusGroupNameAndStatusName("Cambio de orden", "Activa").codsec +", ";
                        queryString += "" + this.coilsToChange.ToString() + ", ";
                        queryString += "'" + this.notes + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + " ";
                        queryString += ");";
                    }
                }
                else
                {
                    if (this.fkOriginalSalesOrderDetail > 0 && this.fkDestinationSalesOrderDetail > 0)
                    {
                        queryString += "UPDATE  bps_prod_changesalesorder";
                        queryString += " SET ";
                        queryString += " cso_fkOriginalSalesOrderDetail = " + this.fkOriginalSalesOrderDetail.ToString() + ", ";
                        queryString += " cso_fkDestinationSalesOrderDetail = " + this.fkDestinationSalesOrderDetail.ToString() + ", ";
                        queryString += " cso_fkProduct = " + this.fkProduct.ToString() + ", ";
                        queryString += " cso_coilsToChange = " + this.coilsToChange.ToString() + ", ";
                        queryString += " cso_notes =  '" + this.notes.ToString() + "', ";
                        queryString += " cso_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += " cso_modifiedBy = " + this.modifiedBy.ToString() + " ";
                        queryString += " WHERE cso_codsec = " + this.codsec.ToString() + ");";
                    }
                    else if (this.fkDestinationSalesOrderDetail == 0)
                    { 
                        queryString += "UPDATE  bps_prod_changesalesorder";
                        queryString += " SET ";
                        queryString += " cso_fkOriginalSalesOrderDetail = " + this.fkOriginalSalesOrderDetail.ToString() + ", ";
                        queryString += " cso_fkProduct = " + this.fkProduct.ToString() + ", ";
                        queryString += " cso_coilsToChange = " + this.coilsToChange.ToString() + ", ";
                        queryString += " cso_notes =  '" + this.notes.ToString() + "', ";
                        queryString += " cso_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += " cso_modifiedBy = " + this.modifiedBy.ToString() + " ";
                        queryString += " WHERE cso_codsec = " + this.codsec.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE  bps_prod_changesalesorder";
                        queryString += " SET ";
                        queryString += " cso_fkDestinationSalesOrderDetail = " + this.fkDestinationSalesOrderDetail.ToString() + ", ";
                        queryString += " cso_fkProduct = " + this.fkProduct.ToString() + ", ";
                        queryString += " cso_coilsToChange = " + this.coilsToChange.ToString() + ", ";
                        queryString += " cso_notes =  '" + this.notes.ToString() + "', ";
                        queryString += " cso_modifiedDate = '" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += " cso_modifiedBy = " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " ";
                        queryString += " WHERE cso_codsec = " + this.codsec.ToString() + ");";
                    }
                }

                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsChangeSalesOrder.save");
                return false;
            }
        }

        public static List<clsChangeSalesOrder> getList()
        {
            DataSet DS = new DataSet();
            List<clsChangeSalesOrder> lstChangeSalesOrder = new List<clsChangeSalesOrder>();

            DS = clsConnection.getDataSetResult("CALL spChangeSalesOrderList()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstChangeSalesOrder.Add(new clsChangeSalesOrder());
                    lstChangeSalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_codsec"]);
                    lstChangeSalesOrder[i].fkOriginalSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_fkOriginalSalesOrderDetail"]);
                    lstChangeSalesOrder[i].originalSalesOrderDetail = clsSalesOrderDetail.getSimplifiedDetail(lstChangeSalesOrder[i].fkOriginalSalesOrderDetail);
                    lstChangeSalesOrder[i].originalSalesOrder.loadWithoutDetail(lstChangeSalesOrder[i].originalSalesOrderDetail.fkSalesOrder);
                    lstChangeSalesOrder[i].fkDestinationSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_fkDestinationSalesOrderDetail"]);
                    lstChangeSalesOrder[i].destinationSalesOrderDetail = clsSalesOrderDetail.getSimplifiedDetail(lstChangeSalesOrder[i].fkDestinationSalesOrderDetail);
                    lstChangeSalesOrder[i].destinationSalesOrder.loadWithoutDetail(lstChangeSalesOrder[i].destinationSalesOrderDetail.fkSalesOrder);
                    lstChangeSalesOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_fkProduct"]);
                    lstChangeSalesOrder[i].objProduct = new clsProduct(lstChangeSalesOrder[i].fkProduct);
                    lstChangeSalesOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_fkStatus"]);
                    lstChangeSalesOrder[i].statusName = DS.Tables[0].Rows[i]["cso_statusName"].ToString();
                    lstChangeSalesOrder[i].coilsToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_coilsToChange"]);
                    lstChangeSalesOrder[i].notes = DS.Tables[0].Rows[i]["cso_notes"].ToString();
                    lstChangeSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cso_createdDate"]);
                    lstChangeSalesOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cso_modifiedDate"]);
                    lstChangeSalesOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_createdBy"]);
                    lstChangeSalesOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cso_modifiedBy"]);
                }                
            }

            return lstChangeSalesOrder;
        }

        public static void delete(int codsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_changesalesorder WHERE cso_codsec = " + codsec.ToString());
        }
        public static void close(int codsec)
        {
            clsConnection.executeQuery("UPDATE bps_prod_changesalesorder SET cso_fkStatus = 55 WHERE cso_codsec = " + codsec.ToString());
        }
    }
}
