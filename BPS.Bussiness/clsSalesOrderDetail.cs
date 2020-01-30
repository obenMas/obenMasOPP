using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja el detalle de la orden de venta (Producto, Cantidad,Precio)
    /// 
    /// </summary>
    public class clsSalesOrderDetail
    {
        //Atributes

        private int sod_codsec;
        private int sod_fkSalesOrder;
        private int sod_fkProduct;
        private clsProduct sod_product;
        private int sod_fkStatus;
        private string sod_StatusName;
        private double sod_quantity;
        private double sod_stock;
        private double sod_price;
        private DateTime sod_closingDate;
        private int sod_closingBy;
        private string sod_closedUser;
        private double sod_programmedWeigth;

        private int sord_codsec;
        private int sord_fkEntity;
        private string sord_EntityName;
        private string sord_CommercialConditionName;
        private int sord_number;
        private string sod_ProductName;
        private double sod_observationWeight;
        private double sod_fulfilledWeight;
        private int sod_pendingToChange;
        private int sod_coilsToCut;
        private int sod_palletnumber;
        private double sod_exchangerate;
        private int sod_fkPlant;
        private string sod_notes;
        private DateTime sod_deliveryDate;
        private DateTime sod_compromisedDate;
        private DateTime sod_otifDate;
        private DateTime sod_completionDate;
        private bool sod_wasCompleted;

        //Properties

        public int codsec { get { return sod_codsec; } set { sod_codsec = value; } }

        public int fkSalesOrder { get { return sod_fkSalesOrder; } set { sod_fkSalesOrder = value; } }

        public int fkProduct { get { return sod_fkProduct; } set { sod_fkProduct = value; } }

        public clsProduct product { get { return sod_product; } set { sod_product = value; } }

        public int fkStatus { get { return sod_fkStatus; } set { sod_fkStatus = value; } }

        public string StatusName { get { return sod_StatusName; } set { sod_StatusName = value; } }

        public double quantity { get { return sod_quantity; } set { sod_quantity = value; } }

        public double stock { get { return sod_stock; } set { sod_stock = value; } }

        public double price { get { return sod_price; } set { sod_price = value; } }

        public DateTime closingDate { get { return sod_closingDate; } set { sod_closingDate = value; } }

        public int closingBy { get { return sod_closingBy; } set { sod_closingBy = value; } }

        public string closedUser { get { return sod_closedUser; } set { sod_closedUser = value; } }

        public double programmedWeigth { get { return sod_programmedWeigth; } set { sod_programmedWeigth = value; } }

        public int sordcodsec { get { return sord_codsec; } set { sord_codsec = value; } }

        public int sordfkEntity { get { return sord_fkEntity; } set { sord_fkEntity = value; } }

        public string sordEntityName { get { return sord_EntityName; } set { sord_EntityName = value; } }

        public string sordCommercialConditionName { get { return sord_CommercialConditionName; } set { sord_CommercialConditionName = value; } }

        public int sordnumber { get { return sord_number; } set { sord_number = value; } }

        public string sodProductName { get { return sod_ProductName; } set { sod_ProductName = value; } }

        public double observationWeight { get { return sod_observationWeight; } set { sod_observationWeight = value; } }

        public double fulfilledWeight { get { return sod_fulfilledWeight; } set { sod_fulfilledWeight = value; } }

        public int pendingToChange { get { return sod_pendingToChange; } set { sod_pendingToChange = value; } }

        public int coilsToCut { get { return sod_coilsToCut; } set { sod_coilsToCut = value; } }

        public int palletnumber { get { return sod_palletnumber; } set { sod_palletnumber = value; } }

        public double exchangerate { get { return sod_exchangerate; } set { sod_exchangerate = value; } }

        public int fkPlant { get { return sod_fkPlant; } set { sod_fkPlant = value; } }

        public string notes { get { return sod_notes; } set { sod_notes = value; } }

        public DateTime deliveryDate { get { return sod_deliveryDate; } set { sod_deliveryDate = value; } }

        public DateTime compromisedDate { get { return sod_compromisedDate; } set { sod_compromisedDate = value; } }

        public DateTime otifDate { get { return sod_otifDate; } set { sod_otifDate = value; } }

        public DateTime completionDate { get { return sod_completionDate; } set { sod_completionDate = value; } }

        public bool wasCompleted { get { return sod_wasCompleted; } set { sod_wasCompleted = value; } }

        //Constructor

        public clsSalesOrderDetail()
        {
            sod_codsec = 0;
            sod_fkSalesOrder = 0;
            sod_fkProduct = 0;
            sod_product = new clsProduct();
            sod_fkStatus = 0;
            sod_StatusName = "";
            sod_quantity = 0;
            sod_stock = 0;
            sod_price = 0;
            sod_closingDate = DateTime.Now;
            sod_closingBy = 88;
            sod_closedUser = "";
            sod_programmedWeigth = 0;
            sord_codsec = 0;
            sord_fkEntity = 0;
            sord_EntityName = "";
            sord_CommercialConditionName = "";
            sord_number = 0;
            sod_ProductName = "";
            sod_observationWeight = 0;
            sod_fulfilledWeight = 0;
            sod_pendingToChange = 0;
            sod_coilsToCut = 0;
            sod_palletnumber = 0;
            sod_exchangerate = 0;
            sod_fkPlant = 0;
            sod_notes = "";
            sod_deliveryDate = DateTime.Now;
            sod_compromisedDate = DateTime.Now;
            sod_otifDate = DateTime.Now;
            sod_completionDate = DateTime.Now;
            sod_wasCompleted = false;
        }

        public clsSalesOrderDetail(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailByCodsec(" + codsec.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_codsec"]);
                this.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkSalesOrder"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkProduct"]);
                product = new clsProduct(this.fkProduct);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["sod_StatusName"].ToString();
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_quantity"]);
                this.stock = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_stock"]);
                this.price = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_price"]);
                this.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_closingDate"]);
                this.closingBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_closingBy"]);
                this.closedUser = DS.Tables[0].Rows[0]["sod_closedUser"].ToString();
                this.programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_programmedWeight"]);
                this.observationWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_observationWeight"]);
                this.fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_fulfilledWeight"]);
                this.pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_pendingToChange"]);
                this.coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_coilsToCut"]);
                this.exchangerate = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_exchangerate"]);
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkPlant"]);
                this.notes = DS.Tables[0].Rows[0]["sod_notes"].ToString();
                this.deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_deliveryDate"]);
                this.compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_compromisedDate"]);
                this.otifDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_otifDate"]);
                this.completionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_completionDate"]);
                this.wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[0]["sod_wasCompleted"]);
            }

        }

        public static clsSalesOrderDetail getSimplifiedDetail(int codsec)
        {
            DataSet DS = new DataSet();
            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();

            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailByCodsec(" + codsec.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                objSalesOrderDetail.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_codsec"]);
                objSalesOrderDetail.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkSalesOrder"]);
                objSalesOrderDetail.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkProduct"]);
                objSalesOrderDetail.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkStatus"]);
                objSalesOrderDetail.StatusName = DS.Tables[0].Rows[0]["sod_StatusName"].ToString();
                objSalesOrderDetail.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_quantity"]);
                objSalesOrderDetail.stock = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_stock"]);
                objSalesOrderDetail.price = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_price"]);
                objSalesOrderDetail.closingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_closingDate"]);
                objSalesOrderDetail.closingBy = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_closingBy"]);
                objSalesOrderDetail.closedUser = DS.Tables[0].Rows[0]["sod_closedUser"].ToString();
                objSalesOrderDetail.pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_pendingToChange"]);
                objSalesOrderDetail.coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_coilsToCut"]);
                objSalesOrderDetail.exchangerate = Convert.ToDouble(DS.Tables[0].Rows[0]["sod_exchangerate"]);
                objSalesOrderDetail.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sod_fkPlant"]);
                objSalesOrderDetail.deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_deliveryDate"]);
                objSalesOrderDetail.compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_compromisedDate"]);
                objSalesOrderDetail.otifDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_otifDate"]);
                objSalesOrderDetail.completionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["sod_completionDate"]);
                objSalesOrderDetail.wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[0]["sod_wasCompleted"]);
            }

            return objSalesOrderDetail;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO  bps_com_salesorderdetail (sod_fkSalesOrder, sod_fkProduct, sod_fkStatus, sod_quantity, sod_stock,sod_price, sod_closingDate, sod_closingBy, sod_coilsToCut, sod_palletnumber, sod_exchangerate, sod_fkPlant, sod_notes, sod_deliveryDate, sod_otifDate, sod_wasCompleted) ";
                    queryString += " VALUES (";
                    queryString += this.fkSalesOrder.ToString() + ",";
                    queryString += this.fkProduct.ToString() + ",";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += this.quantity.ToString() + ",";
                    queryString += this.stock.ToString() + ",";
                    queryString += this.price.ToString() + ",";
                    queryString += "'1900/01/01',";
                    queryString += "" + this.closingBy.ToString() + ",";
                    queryString += "" + this.coilsToCut.ToString() + ",";
                    queryString += "" + this.palletnumber.ToString() + ",";
                    queryString += "" + this.exchangerate.ToString() + ",";
                    queryString += "" + this.fkPlant.ToString() +", " ;
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + this.deliveryDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "'" + this.compromisedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.otifDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "'" + this.completionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    if(this.wasCompleted)
                    {
                        queryString += "1" + ");";
                    }
                    else
                    {
                        queryString += "0" + ");";
                    }
                        
                    
                }
                else
                {
                    queryString += "UPDATE bps_com_salesorderdetail";
                    queryString += " SET ";
                    queryString += " sod_fkSalesOrder = " + this.fkSalesOrder.ToString() + ",";
                    queryString += " sod_fkProduct = " + this.fkProduct.ToString() + ",";
                    queryString += " sod_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += " sod_quantity = " + this.quantity.ToString() + ",";
                    queryString += " sod_stock = " + this.stock.ToString() + ",";
                    queryString += " sod_price = " + this.price.ToString() + ",";
                    queryString += " sod_closingDate = '" + this.closingDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " sod_closingBy = " + this.closingBy.ToString() + ",";
                    queryString += " sod_coilsToCut = " + this.coilsToCut.ToString() + ",";
                    queryString += " sod_palletnumber = " + this.palletnumber.ToString() + ",";
                    queryString += " sod_exchangerate = " + this.exchangerate.ToString() + ",";
                    queryString += " sod_fkPlant = " + this.fkPlant.ToString() + ",";
                    queryString += " sod_notes = '" + this.notes+"',";
                    queryString += " sod_deliveryDate = '" + this.deliveryDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " sod_compromisedDate = '" + this.compromisedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " sod_otifDate = '" + this.otifDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += " sod_completionDate = '" + this.completionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    if(wasCompleted)
                    {
                        queryString += " sod_wasCompleted =1"; 
                    }
                    else
                    {
                        queryString += " sod_wasCompleted =0";
                    }
                    queryString += " WHERE sod_codsec = " + this.codsec.ToString();
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.save");
                return false;
            }

        }

        public bool updateObs(string notes)
        {
            this.notes = notes;
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += " sod_notes = '" + this.notes.ToString() + "' ";
                queryString += " WHERE sod_codsec = " + this.codsec.ToString();


                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public bool updateCompromisedDate(DateTime date)
        {
            this.compromisedDate = date;
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += " sod_compromisedDate = '" + this.compromisedDate.ToString("dd/MM/yyyy") + "'";
                queryString += " WHERE sod_codsec = " + this.codsec.ToString();


                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public bool updateOTIFDate(DateTime date)
        {
            this.otifDate = date;
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += " sod_otifDate = '" + this.otifDate.ToString("dd/MM/yyyy") + "'";
                queryString += " WHERE sod_codsec = " + this.codsec.ToString();


                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public bool updatePrice(double price)
        {
            this.price=price;
             try
            {
                string queryString = "";

               
                    queryString += "UPDATE bps_com_salesorderdetail";
                    queryString += " SET ";
                    queryString += " sod_price = " + this.price.ToString() + " ";
                    queryString += " WHERE sod_codsec = " + this.codsec.ToString();
                

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public bool updateExchangerate(double exchangerate)
        {
            this.exchangerate = exchangerate;
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += "sod_exchangerate = " + this.exchangerate.ToString() + " ";
                queryString += " WHERE sod_codsec = " + this.codsec.ToString();


                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public static List<clsSalesOrderDetail> getListByOrderDetail(int orderCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailBySalesOrder(" + orderCodsec.ToString() + ")");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_palletnumber"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].notes = DS.Tables[0].Rows[i]["sod_notes"].ToString();
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getListByTransport(int transportCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailByTransport(" + transportCodsec.ToString() + ")");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);

            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getListByBoppFilm(int orderCodsec, int boppCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailByBoppFilm(" + orderCodsec.ToString() + "," + boppCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                //lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getListByCastFilm(int orderCodsec, int castCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderDetailByCastFilm(" + orderCodsec.ToString() + "," + castCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                //lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppFilm(int boppCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilm(" + boppCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppFilmAndPlant(int boppCodsec,int plant)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilmAndPlant(" + boppCodsec.ToString() + "," + plant.ToString()+");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByCastFilm(int castCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastFilm(" + castCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByCastFilmAndPlant(int castCodsec,int plant)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastFilmAndPlant(" + castCodsec.ToString() + "," + plant.ToString() +");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppEquivalentFilm(int boppCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppEquivalentFilm(" + boppCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppEquivalentFilmAndPlant(int boppCodsec,int plant)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppEquivalentFilmAndPlant(" + boppCodsec.ToString() + ","+ plant.ToString() +");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByCastEquivalentFilm(int castCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastEquivalentFilm(" + castCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByCastEquivalentFilmAndPlant(int castCodsec,int plant)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastEquivalentFilmAndPlant(" + castCodsec.ToString() +","+plant.ToString()+ ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product.load(lstOrderDetail[i].fkProduct, true);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByProduct(int productCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            if (productCodsec > 0)
            {
                clsProduct objProduct = new clsProduct(productCodsec);

                DataSet DS = new DataSet();
                if (objProduct.fkBopp > 0)
                    DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilm(" + objProduct.fkBopp.ToString() + ");");
                else if (objProduct.fkCast > 0)
                    DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastFilm(" + objProduct.fkCast.ToString() + ");");
                lstOrderDetail.Clear();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (Convert.ToDouble(DS.Tables[0].Rows[i]["sod_width"]) <= objProduct.width)
                    {
                        lstOrderDetail.Add(new clsSalesOrderDetail());
                        lstOrderDetail[lstOrderDetail.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].product.load(lstOrderDetail[lstOrderDetail.Count - 1].fkProduct, true);
                        lstOrderDetail[lstOrderDetail.Count - 1].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                        lstOrderDetail[lstOrderDetail.Count - 1].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                        lstOrderDetail[lstOrderDetail.Count - 1].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                        //lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                        lstOrderDetail[lstOrderDetail.Count - 1].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
                    }
                }

            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListBySpecificProduct(int productCodsec)
        {
            clsProduct objProduct = new clsProduct(productCodsec);

            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            if (objProduct.fkBopp > 0)
                DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilm(" + objProduct.fkBopp.ToString() + ");");
            else if (objProduct.fkCast > 0)
                DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByCastFilm(" + objProduct.fkCast.ToString() + ");");
            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fkProduct"]) == objProduct.codsec)
                {
                    lstOrderDetail.Add(new clsSalesOrderDetail());
                    lstOrderDetail[lstOrderDetail.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].product.load(lstOrderDetail[lstOrderDetail.Count - 1].fkProduct, true);
                    lstOrderDetail[lstOrderDetail.Count - 1].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                    lstOrderDetail[lstOrderDetail.Count - 1].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                    lstOrderDetail[lstOrderDetail.Count - 1].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                    //lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                    lstOrderDetail[lstOrderDetail.Count - 1].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
                }
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppFilmAndDiameterCore(int boppCodsec, int diameterCodsec, int coreCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilmAndCoreDiameter(" + boppCodsec.ToString() + "," + diameterCodsec.ToString() + "," + coreCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppFilmAndCore(int boppCodsec, int coreCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilmAndCore(" + boppCodsec.ToString() + "," + coreCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppFilmAndDiameter(int boppCodsec, int diameterCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilmAndDiameter(" + boppCodsec.ToString() + "," + diameterCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static List<clsSalesOrderDetail> getCompleteListByBoppEquivalentFilmAndDiameter(int boppCodsec, int diameterCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCompleteSalesOrderDetailByBoppFilmAndDiameter(" + boppCodsec.ToString() + "," + diameterCodsec.ToString() + ");");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                lstOrderDetail[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkSalesOrder"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].product = new clsProduct(lstOrderDetail[i].fkProduct);
                lstOrderDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkStatus"]);
                lstOrderDetail[i].StatusName = DS.Tables[0].Rows[i]["sod_StatusName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_stock"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_closingDate"]);
                lstOrderDetail[i].closingBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_closingBy"]);
                lstOrderDetail[i].closedUser = DS.Tables[0].Rows[i]["sod_closedUser"].ToString();
                lstOrderDetail[i].programmedWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_programmedWeight"]);
                lstOrderDetail[i].observationWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_observationWeight"]);
                lstOrderDetail[i].fulfilledWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_fulfilledWeight"]);
                lstOrderDetail[i].pendingToChange = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_pendingToChange"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static void checkDeletedSalesOrderDetails(List<clsSalesOrderDetail> lstSalesOrderDetail, int salesOrdercodsec)
        {
            bool isInList = false;
            List<clsSalesOrderDetail> lstActualSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(salesOrdercodsec);

            for (int i = 0; i < lstActualSalesOrderDetail.Count; i++)
            {
                isInList = false;

                for (int j = 0; j < lstSalesOrderDetail.Count; j++)
                {
                    if (lstActualSalesOrderDetail[i].codsec == lstSalesOrderDetail[j].codsec)
                        isInList = true;
                }

                if (isInList == false)
                    clsSalesOrderDetail.delete(lstActualSalesOrderDetail[i].codsec);
            }
        }
        public static void changeStatus(int codsec, string status)
        {
            clsStatus objStatus = new clsStatus();
            string queryString = "";

            try
            {
                objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Detalle de Ordenes de Venta", status);

                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += " sod_fkStatus = " + objStatus.codsec.ToString() + "";
                queryString += " WHERE sod_codsec = " + codsec + ";";

                clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProductionOrder.save");
            }
        }
        public static bool delete(int codsec)
        {
            string queryString = "";
            queryString += "DELETE FROM bps_com_salesorderdetail WHERE sod_codsec = " + codsec.ToString() + ";";
            return clsConnection.executeQuery(queryString);
        }

        public static List<int> getListByCustomer(string customerName)
        {
            List<int> lstOrderDetail = new List<int>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderControl where Cliente = '" + customerName+"'");

            lstOrderDetail.Clear();

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    lstOrderDetail.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]));
                }
            }

            return lstOrderDetail;
        }

        public static List<clsSalesOrderDetail> getListByOrderDetailByCustomer(int CustomerCodsec)
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorderbysalesdetails where sord_fkEntity = " + CustomerCodsec.ToString());

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].sordcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstOrderDetail[i].sordfkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstOrderDetail[i].sordEntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstOrderDetail[i].sordCommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstOrderDetail[i].sordnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].sodProductName = DS.Tables[0].Rows[i]["sod_ProductName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                //lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }

        public static List<clsSalesOrderDetail> getListByAllCustomer()
        {
            List<clsSalesOrderDetail> lstOrderDetail = new List<clsSalesOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwsalesorderbysalesdetails ORDER BY sord_EntityName");

            lstOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOrderDetail.Add(new clsSalesOrderDetail());
                lstOrderDetail[i].sordcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstOrderDetail[i].sordfkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkEntity"]);
                lstOrderDetail[i].sordEntityName = DS.Tables[0].Rows[i]["sord_EntityName"].ToString();
                lstOrderDetail[i].sordCommercialConditionName = DS.Tables[0].Rows[i]["sord_CommercialConditionName"].ToString();
                lstOrderDetail[i].sordnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_number"]);
                lstOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkProduct"]);
                lstOrderDetail[i].sodProductName = DS.Tables[0].Rows[i]["sod_ProductName"].ToString();
                lstOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstOrderDetail[i].coilsToCut = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_coilsToCut"]);
                lstOrderDetail[i].exchangerate = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_exchangerate"]);
                lstOrderDetail[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_fkPlant"]);
                lstOrderDetail[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_deliveryDate"]);
                lstOrderDetail[i].compromisedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_compromisedDate"]);
                lstOrderDetail[i].otifDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_otifDate"]);
                lstOrderDetail[i].completionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sod_completionDate"]);
                lstOrderDetail[i].wasCompleted = Convert.ToBoolean(DS.Tables[0].Rows[i]["sod_wasCompleted"]);
            }
            return lstOrderDetail;
        }
        public static int getPendingCoilBySalesOrderDetail(int salesOrderDetailCodsec)
        {
            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(salesOrderDetailCodsec);
            int pendingCoils = 0;
            int totalCoils = 0;
            int programmedCoils = 0;
            int fulfilledStops = 0;
            int fulfilledCoils = 0;
            int observationCoils = 0;

            //totalCoils = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.quantity)));
            totalCoils = objSalesOrderDetail.coilsToCut;
            programmedCoils = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.programmedWeigth)));
            fulfilledCoils = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.fulfilledWeight)));
            observationCoils = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.observationWeight)));

            DataSet DS = clsConnection.getDataSetResult("CALL spCompleteStopsBySalesOrderDetail(" + objSalesOrderDetail.codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    fulfilledStops += Convert.ToInt32(DS.Tables[0].Rows[i]["completesStops"]);
                }
            }

            pendingCoils = totalCoils - programmedCoils - fulfilledCoils - fulfilledStops + observationCoils - objSalesOrderDetail.pendingToChange;

            return pendingCoils;
        }
        public static double getPendingCoilBySalesOrderDetailObj(clsSalesOrderDetail objSalesOrderDetail)
        {
            double pendingCoils = 0;
            double totalCoils = 0;
            double programmedCoils = 0;
            double fulfilledStops = 0;
            int fulfilledCoils = 0;
            double observationCoils = 0;
            //try
            //{

            totalCoils = Convert.ToDouble(Math.Round(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp,objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.quantity),1));
            //totalCoils = objSalesOrderDetail.coilsToCut;
            //}
            //catch (Exception)
            //{
            //   totalCoils = Convert.t(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.quantity)));
            //}
            programmedCoils = Convert.ToDouble(Math.Round(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.programmedWeigth),1));
            fulfilledCoils = Convert.ToInt32(Math.Round(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.fulfilledWeight)));
            //observationCoils = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.fkBopp, objSalesOrderDetail.product.fkCast, objSalesOrderDetail.product.fkDiameter, objSalesOrderDetail.product.fkCore, objSalesOrderDetail.product.width, objSalesOrderDetail.observationWeight)));

            DataSet DS = clsConnection.getDataSetResult("CALL spCompleteStopsBySalesOrderDetail(" + objSalesOrderDetail.codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    fulfilledStops += Convert.ToInt32(DS.Tables[0].Rows[i]["completesStops"]);
                }
            }

            pendingCoils = totalCoils - programmedCoils - fulfilledCoils - fulfilledStops + observationCoils - objSalesOrderDetail.pendingToChange;

            return pendingCoils;
        }
        public static double getCuttedWeightBySalesOrderDetail(int salesOrderDetailCodsec)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spCuttedWeightBySalesOrderDetail(" + salesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
                return Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["cuttedWeight"]), 1);
            else
                return 0;
        }
        public static int getCuttedCoilCountBySalesOrderDetail(int salesOrderDetailCodsec)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spCuttedCoilsCountBySalesOrderDetail(" + salesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["cuttedCoils"]);
            else
                return 0;
        }
        public override string ToString()
        {
            return this.sordEntityName + " - " + this.sord_number;
        }

        public static bool complete(int detailS)
        {
            string queryString = "";

            queryString += "UPDATE bps_com_salesorderdetail";
            queryString += " SET ";
            queryString += " sod_fkStatus = 1116";
            queryString += " WHERE sod_codsec = " + detailS.ToString();

            return clsConnection.executeQuery(queryString);
        }

        public static bool completeOpen(int detailS)
        {
            string queryString = "";

            queryString += "UPDATE bps_com_salesorderdetail";
            queryString += " SET ";
            queryString += " sod_fkStatus = 14";
            queryString += " WHERE sod_codsec = " + detailS.ToString();

            return clsConnection.executeQuery(queryString);
        }


        public bool changeStatus(int codsec)
        {   
            this.fkStatus = codsec;
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_com_salesorderdetail";
                queryString += " SET ";
                queryString += "sod_fkStatus = " + this.fkStatus.ToString() + " ";
                queryString += " WHERE sod_codsec = " + this.codsec.ToString();


                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSalesOrderDetail.update");
                return false;
            }
        }

        public bool cancelAvailable()
        { 
            double solicitado = 0;
            double fabricado = 0;
            double entregado = 0;
            double objetivo = 0;
            double programado = 0;
            string estado = string.Empty;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderControl(" + this.codsec.ToString() + ")");

            if (DS.Tables.Count > 0)
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    solicitado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSolicitada"]);
                    objetivo = solicitado * 0.9;
                    programado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadProgramada"]);
                    fabricado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSinPaletizar"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaNoDisponible"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaDisponible"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPredespachada"]);
                    entregado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadEntregada"]);
                    estado = DS.Tables[0].Rows[0]["Estado"].ToString();
                }
            }
            if (estado == "Pendiente" || estado == "Activo")
            {
                return true;
            }
            else if (estado == "Parc. Ent." && fabricado==0 && programado==0)
            {
                if(MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se anuló el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;

                }
            }
            else if(estado == "Parc. Ent." && fabricado >0 && programado == 0)
            {
                if (MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido. Se enviarán " + fabricado.ToString() + " kilos a stock.", "Control de pedidos", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se anuló el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;
                }
            }
            else if(estado == "Parc. Fab." || fabricado >0 && programado == 0)
            {
                if (MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido. Se enviarán " + fabricado.ToString() + " kilos a stock.", "Control de pedidos", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se anuló el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la acción porque el pedido se encuentra programado o entregado.", "Control de pedidos", MessageBoxButtons.OKCancel);
                return false;
            }

        }        
  
         public bool closeAvailable()
        {
            double solicitado = 0;
            double fabricado = 0;
            double entregado = 0;
            double objetivo = 0;
            double programado = 0;
            string estado = string.Empty;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderControl(" + this.codsec.ToString() + ")");

            if (DS.Tables.Count > 0)
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    solicitado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSolicitada"]);
                    objetivo = solicitado * 0.9;
                    programado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadProgramada"]);
                    fabricado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSinPaletizar"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaNoDisponible"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaDisponible"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPredespachada"]);
                    entregado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadEntregada"]);
                    estado = DS.Tables[0].Rows[0]["Estado"].ToString();
                }
            }
            if (estado == "Entregada" && fabricado == 0 && programado == 0)
            {
                return true;
            }
            else if (estado == "Entregada" && fabricado > 0 && programado == 0)
            {
                if (MessageBox.Show("¿Confirma que desea cerrar la orden? se enviarán " + fabricado.ToString() + " kilos a stock.", "Control de pedidos", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se cerró el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;
                }
            }
            else if (estado == "Pendiente" || estado == "Activo")
            {
                return true;
            }
            else if (estado == "Parc. Ent." && fabricado==0 && programado==0)
            {
                if(MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se cerró el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;

                }
            }
            else if(estado == "Parc. Ent." && fabricado >0 && programado == 0)
            {
                if (MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido. Se enviarán " + fabricado.ToString() + " kilos a stock.", "Control de pedidos", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se cerró el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;
                }
            }
            else if(estado == "Parc. Fab." || fabricado >0 && programado == 0)
            {
                if (MessageBox.Show("¿Confirma que desea cerrar la orden? quedan kilos por entregar para completar el pedido. Se enviarán " + fabricado.ToString() + " kilos a stock.", "Control de pedidos", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se cerró el pedido.", "Control de pedidos", MessageBoxButtons.OKCancel);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la acción porque el pedido se encuentra programado.", "Control de pedidos", MessageBoxButtons.OKCancel);
                return false;
            }
        }


        public void setStatus()
        {
            double solicitado = 0;
            double fabricado = 0;
            double entregado = 0;
            double objetivo = 0;
            double programado = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderControl("+this.codsec.ToString()+")");

            if(DS.Tables.Count>0)
            {
                if(DS.Tables[0].Rows.Count>0)
                {
                    solicitado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSolicitada"]);
                    objetivo = solicitado*0.9;
                    programado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadProgramada"]);
                    fabricado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadSinPaletizar"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaNoDisponible"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaDisponible"]);
                    entregado = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadEntregada"]);
                }
            }
            
            //if 90% entregado, status=Entregado
            if(entregado >= objetivo)
            {
                //entregado
                changeStatus(3063);

            }
            //else if 0<entregado<90%, status=parc.ent.
            else if(entregado>0)
            {
                //parc.ent.
                changeStatus(3062);
            }
            //else if 90% deposito, status=fabricado
            else if(fabricado>=objetivo)
            {
                //fabricado
                changeStatus(3061);
            }
            //else if 0<deposito<90%, status= parc.fab.
            else if(fabricado>0)
            {
                //parc.fab.
                changeStatus(3060);
            }
            else if(programado>0)
            {
                //programada
                changeStatus(3059);
            }
            //else if status=pend
            else
            {
                //pend
                changeStatus(3058);
            }
        }

        public void setStatus(double solicitado,double fabricado,double entregado,double programado)
        {
            double objetivo = 0;
            objetivo = solicitado * 0.9;

            //if 90% entregado, status=Entregado
            if (entregado >= objetivo)
            {
                //entregado
                changeStatus(3063);

            }
            //else if 0<entregado<90%, status=parc.ent.
            else if (entregado > 0)
            {
                //parc.ent.
                changeStatus(3062);
            }
            //else if 90% deposito, status=fabricado
            else if (fabricado >= objetivo)
            {
                //fabricado
                changeStatus(3061);
            }
            //else if 0<deposito<90%, status= parc.fab.
            else if (fabricado > 0)
            {
                //parc.fab.
                changeStatus(3060);
            }
            else if (programado > 0)
            {
                //programada
                changeStatus(3059);
            }
            //else if status=pend
            else
            {
                //pend
                changeStatus(3058);
            }
        }

    }
}
