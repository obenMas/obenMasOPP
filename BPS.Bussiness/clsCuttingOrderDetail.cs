using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra el detalle de la combinacion de corte
    /// </summary>
    public class clsCuttingOrderDetail
    {
        //Atributes

        private int cod_codsec;
        private int cod_fkCuttingOrder;
        private int cod_fkProduct;
        private clsProduct cod_product;
        private int cod_fkSalesOrderDetail;
        private string cod_salesOrderNumber;
        private string cod_ProductName;
        private double cod_width;
        private int cod_position;
        private double cod_programmedWeight;
        private double cod_programmedLength;
        private bool cod_useSingleFace;
        private string cod_pallet;
        private string cod_CompanyName;
        


        //Properties

        public int codsec { get { return cod_codsec; } set { cod_codsec = value; } }

        public int fkCuttingOrder { get { return cod_fkCuttingOrder; } set { cod_fkCuttingOrder = value; } }

        public int fkProduct { get { return cod_fkProduct; } set { cod_fkProduct = value; } }

        public clsProduct product { get { return cod_product; } set { cod_product = value; } }

        public string ProductName { get { return cod_ProductName; } set { cod_ProductName = value; } }

        public double width { get { return cod_width; } set { cod_width = value; } }

        public int fkSalesOrderDetail{get{return cod_fkSalesOrderDetail;}set{cod_fkSalesOrderDetail = value;}}

        public string salesOrderNumber{get{return cod_salesOrderNumber;}set{cod_salesOrderNumber = value;}}

        public int position { get { return cod_position; } set { cod_position = value; } }

        public double programmedWeight { get { return cod_programmedWeight; } set { cod_programmedWeight = value; } }

        public double programmedLength { get { return cod_programmedLength; } set { cod_programmedLength = value; } }

        public bool useSingleFace { get { return cod_useSingleFace; } set { cod_useSingleFace = value; } }

        public string pallet { get { return cod_pallet; } set { cod_pallet = value; } }

        public string companyName { get { return cod_CompanyName; } set { cod_CompanyName = value; } }


        //Constructor

        public clsCuttingOrderDetail()
        { 
            cod_codsec = 0;
            cod_fkCuttingOrder = 0;
            cod_fkProduct = 0;
            cod_ProductName = "";
            cod_width = 0;
            cod_fkSalesOrderDetail = 0;
            cod_salesOrderNumber = "";
            cod_position = 0;
            cod_programmedWeight = 0;
            cod_programmedLength = 0;
            cod_useSingleFace = false;
            cod_pallet = string.Empty;
            cod_CompanyName = "";
        }

        public clsCuttingOrderDetail(int cuttingOrderDetailCodsec)
        {
            this.load(cuttingOrderDetailCodsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcuttingorderdetail where cod_codsec =  " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.product = new clsProduct();
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cod_codsec"]);
                this.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["cod_fkCuttingOrder"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cod_fkProduct"]);
                this.product.load(fkProduct);
                this.fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cod_fkSalesOrderDetail"]);
                this.salesOrderNumber = DS.Tables[0].Rows[0]["cod_salesOrderNumber"].ToString();
                this.ProductName = DS.Tables[0].Rows[0]["cod_ProductName"].ToString();
                this.position = Convert.ToInt32(DS.Tables[0].Rows[0]["cod_position"]);
                this.programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cod_programmedWeight"]);
                this.programmedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["cod_programmedLength"]);
                this.useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cod_useSingleFace"], DS.Tables[0].Rows[0]["cod_useSingleFace"].GetType().FullName); 
                
            }
        }
        public bool save()
        {
            //try
            //{
                string queryString = "";

                if (this.codsec == 0)
                {
                    if (this.fkSalesOrderDetail > 0)
                    {
                        queryString += "INSERT INTO bps_prod_cuttingorderdetail (cod_fkCuttingOrder, cod_fkProduct, cod_fkSalesOrderDetail, cod_position, cod_programmedWeight, cod_programmedLength, cod_useSingleFace, cod_pallet)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkCuttingOrder.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "" + this.fkSalesOrderDetail.ToString() + ", ";
                        queryString += "" + this.position.ToString() + ", ";
                        queryString += "" + this.programmedWeight.ToString() + ", ";
                        queryString += "" + this.programmedLength.ToString() + ", ";
                        queryString += "" + this.useSingleFace.ToString() + ", ";
                        queryString += "'" + this.pallet.ToString() + "' ";
                        queryString += ");";
                    }
                    else
                    {
                        queryString += "INSERT INTO bps_prod_cuttingorderdetail (cod_fkCuttingOrder, cod_fkProduct, cod_position, cod_programmedWeight, cod_programmedLength, cod_useSingleFace, cod_pallet)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkCuttingOrder.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "" + this.position.ToString() + ", ";
                        queryString += "" + this.programmedWeight.ToString() + ", ";
                        queryString += "" + this.programmedLength.ToString() + ", ";
                        queryString += "" + this.useSingleFace.ToString() + ", ";
                        queryString += "'" + this.pallet.ToString() + "' ";
                        queryString += ");";
                    }
                }
                else
                {
                    if (this.fkSalesOrderDetail > 0)
                    {
                        queryString += "UPDATE bps_prod_cuttingorderdetail ";
                        queryString += " SET ";
                        queryString += "cod_fkCuttingOrder = " + this.fkCuttingOrder.ToString() + ", ";
                        queryString += "cod_fkProduct = " + this.fkProduct.ToString() + ", ";
                        queryString += "cod_fkSalesOrderDetail = " + this.fkSalesOrderDetail.ToString() + ", ";
                        queryString += "cod_position = " + this.position.ToString() + ", ";
                        queryString += "cod_programmedWeight = " + this.programmedWeight.ToString() + ", ";
                        queryString += "cod_programmedLength = " + this.programmedLength.ToString() + ", ";
                        queryString += "cod_useSingleFace = " + this.useSingleFace.ToString() + ", ";
                        queryString += "cod_pallet = '" + this.pallet + "' ";
                        queryString += " WHERE cod_codsec = " + this.codsec + ";";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_cuttingorderdetail";
                        queryString += " SET ";
                        queryString += "cod_fkCuttingOrder = " + this.fkCuttingOrder.ToString() + ", ";
                        queryString += "cod_fkProduct = " + this.fkProduct.ToString() + ", ";
                        queryString += "cod_position = " + this.position.ToString() + ", ";
                        queryString += "cod_programmedWeight = " + this.programmedWeight.ToString() + ", ";
                        queryString += "cod_programmedLength = " + this.programmedLength.ToString() + ", ";
                        queryString += "cod_useSingleFace = " + this.useSingleFace.ToString() + ", ";
                        queryString += "cod_pallet = '" + this.pallet + "' ";
                        queryString += " WHERE cod_codsec = " + this.codsec + ";";
                    }
                }
                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = getLastSavedSalesOrderCodsec();

                return true;
            //}
            //catch (Exception ex)
            //{
                //clsLog.addLog(ex, 3, "clsCuttingOrderDetail.save");
                //return false;
            //}
        }
        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cod_codsec FROM vwcuttingorderdetail Order By cod_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cod_codsec"]);
        }
        public static List<clsCuttingOrderDetail> getListByCuttingOrder(int CuttingOrderCodsec)
        {
            List<clsCuttingOrderDetail> lstCuttingOrderDetail = new List<clsCuttingOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwcuttingorderdetail WHERE cod_fkCuttingOrder =  " + CuttingOrderCodsec.ToString() + " ORDER BY cod_position");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count ; i++)
                {
                    lstCuttingOrderDetail.Add(new clsCuttingOrderDetail());

                    lstCuttingOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_codsec"]);
                    lstCuttingOrderDetail[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkCuttingOrder"]);
                    lstCuttingOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkProduct"]);
                    lstCuttingOrderDetail[i].product = new clsProduct();
                    lstCuttingOrderDetail[i].product.load(lstCuttingOrderDetail[i].fkProduct, true);
                    lstCuttingOrderDetail[i].width = lstCuttingOrderDetail[i].product.width;
                    lstCuttingOrderDetail[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkSalesOrderDetail"]);
                    lstCuttingOrderDetail[i].salesOrderNumber = DS.Tables[0].Rows[i]["cod_salesOrderNumber"].ToString();
                    lstCuttingOrderDetail[i].ProductName = DS.Tables[0].Rows[i]["cod_ProductName"].ToString();
                    lstCuttingOrderDetail[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_position"]);
                    lstCuttingOrderDetail[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cod_programmedWeight"]);
                    lstCuttingOrderDetail[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cod_programmedLength"]);
                    lstCuttingOrderDetail[i].useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cod_useSingleFace"], DS.Tables[0].Rows[i]["cod_useSingleFace"].GetType().FullName);
                    lstCuttingOrderDetail[i].pallet = DS.Tables[0].Rows[i]["cod_pallet"].ToString();
                    lstCuttingOrderDetail[i].companyName = DS.Tables[0].Rows[i]["cod_CompanyName"].ToString();
                }
            }
            return lstCuttingOrderDetail;
        }
        public static List<clsCuttingOrderDetail> getStockEntriesByCuttingOrder(object CuttingOrderCodsec)
        {
            List<clsCuttingOrderDetail> lstCuttingOrderDetail = new List<clsCuttingOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT min(cod_codsec) as cod_codsec, min(cod_fkCuttingOrder) as cod_fkCuttingOrder, min(cod_fkProduct) as cod_fkProduct,  min(cod_productName) as cod_productName, min(cod_fkSalesOrderDetail) as cod_fkSalesOrderDetail, min(cod_SalesOrderNumber) as cod_SalesOrderNumber, min(cod_CompanyName) as cod_CompanyName,  min(cod_position) as cod_position,  min(cod_programmedWeight) as cod_programmedWeight, min(cod_programmedLength) as cod_programmedLength,  min(cod_useSingleFace) as cod_useSingleFace,  SUM(vwcuttingorderdetail.`cod_programmedWeight`) as totalWeigth FROM vwcuttingorderdetail where cod_fkCuttingOrder =  " + CuttingOrderCodsec.ToString() + " AND cod_fkSalesOrderDetail = 0 GROUP BY vwcuttingorderdetail.`cod_fkProduct`");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrderDetail.Add(new clsCuttingOrderDetail());

                    lstCuttingOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_codsec"]);
                    lstCuttingOrderDetail[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkCuttingOrder"]);
                    lstCuttingOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkProduct"]);
                    lstCuttingOrderDetail[i].product = new clsProduct(lstCuttingOrderDetail[i].fkProduct);
                    lstCuttingOrderDetail[i].width = lstCuttingOrderDetail[i].product.width;
                    lstCuttingOrderDetail[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkSalesOrderDetail"]);
                    lstCuttingOrderDetail[i].salesOrderNumber = DS.Tables[0].Rows[i]["cod_salesOrderNumber"].ToString();
                    lstCuttingOrderDetail[i].ProductName = DS.Tables[0].Rows[i]["cod_ProductName"].ToString();
                    lstCuttingOrderDetail[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_position"]);
                    lstCuttingOrderDetail[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["totalWeigth"]);
                    lstCuttingOrderDetail[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cod_programmedLength"]);
                    lstCuttingOrderDetail[i].useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cod_useSingleFace"], DS.Tables[0].Rows[i]["cod_useSingleFace"].GetType().FullName);
                }
            }
            return lstCuttingOrderDetail;
        }
        public static List<clsCuttingOrderDetail> getStockEntries()
        {
            List<clsCuttingOrderDetail> lstCuttingOrderDetail = new List<clsCuttingOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT vwcuttingorderdetail.*,  SUM(vwcuttingorderdetail.`cod_programmedWeight`) as totalWeigth FROM vwcuttingorderdetail where cod_fkSalesOrderDetail = 0 GROUP BY vwcuttingorderdetail.`cod_fkProduct`");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrderDetail.Add(new clsCuttingOrderDetail());

                    lstCuttingOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_codsec"]);
                    lstCuttingOrderDetail[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkCuttingOrder"]);
                    lstCuttingOrderDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkProduct"]);
                    lstCuttingOrderDetail[i].product = new clsProduct(lstCuttingOrderDetail[i].fkProduct);
                    lstCuttingOrderDetail[i].width = lstCuttingOrderDetail[i].product.width;
                    lstCuttingOrderDetail[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_fkSalesOrderDetail"]);
                    lstCuttingOrderDetail[i].salesOrderNumber = DS.Tables[0].Rows[i]["cod_salesOrderNumber"].ToString();
                    lstCuttingOrderDetail[i].ProductName = DS.Tables[0].Rows[i]["cod_ProductName"].ToString();
                    lstCuttingOrderDetail[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cod_position"]);
                    lstCuttingOrderDetail[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["totalWeigth"]);
                    lstCuttingOrderDetail[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cod_programmedLength"]);
                    lstCuttingOrderDetail[i].useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cod_useSingleFace"], DS.Tables[0].Rows[i]["cod_useSingleFace"].GetType().FullName);
                }
            }
            return lstCuttingOrderDetail;
        }
        public static void checkDeletedCuttingOrderDetails(List<clsCuttingOrderDetail> lstCuttingOrderDetail, int CuttingOrderCodsec)
        {
            bool isInList = false;
            List<clsCuttingOrderDetail> lstActualCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(CuttingOrderCodsec);

            for (int i = 0; i < lstActualCuttingOrderDetail.Count; i++)
            {
                isInList = false;

                for (int j = 0; j < lstCuttingOrderDetail.Count; j++)
                {
                    if (lstActualCuttingOrderDetail[i].codsec == lstCuttingOrderDetail[j].codsec)
                        isInList = true;
                }

                if (isInList == false)
                    clsCuttingOrderDetail.delete(lstActualCuttingOrderDetail[i].codsec);
            }
        }
        public static string getSalesOrderDetailCustomer(int salesOrderDetailCodsec)
        {
            DataSet DS = clsConnection.getDataSetResult("spGetCustomerNameByCuttingOrderDetail " + salesOrderDetailCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                return DS.Tables[0].Rows[0]["customerName"].ToString();
            }
            else
                return "";
        }
        private static bool delete(int codsec)
        {
            string queryString = "";
            queryString += "DELETE FROM bps_prod_cuttingorderdetail WHERE cod_codsec = " + codsec.ToString() + ";";
            return clsConnection.executeQuery(queryString);
        }

        public static bool DeleteByCuttingOrderCodsec(int fkcuttingorder)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_cuttingorderdetail WHERE cod_fkCuttingOrder=" + fkcuttingorder.ToString());
        }
    }
}
