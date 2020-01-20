using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las M.P., precio, cantidad de cada orden de compra
    /// </summary>
    public class clsPurchaseOrderDetail
    {

        //Atributes

        private int purorddt_codsec;
        private int purorddt_fkPurchaseOrder;
        private int purorddt_fkTypeRawMaterial;
        private string purorddt_TypeRawMaterialName;
        private int purorddt_fkRawMaterial;
        private string purorddt_RawMaterialName;
        private string purorddt_RawMaterialCode;
        private double purorddt_quantity;
        private double purorddt_price;
        private double purorddt_totalRecepted;

        //Properties


        public int codsec { get { return purorddt_codsec; } set { purorddt_codsec = value; } }

        public int fkPurchaseOrder { get { return purorddt_fkPurchaseOrder; } set { purorddt_fkPurchaseOrder = value; } }

        public int fkTypeRawMaterial { get { return purorddt_fkTypeRawMaterial; } set { purorddt_fkTypeRawMaterial = value; } }

        public string TypeRawMaterialName { get { return purorddt_TypeRawMaterialName; } set { purorddt_TypeRawMaterialName = value; } }
        
        public int fkRawMaterial { get { return purorddt_fkRawMaterial; } set { purorddt_fkRawMaterial = value; } }

        public string RawMaterialName { get { return purorddt_RawMaterialName; } set { purorddt_RawMaterialName = value; } }

        public string RawMaterialCode { get { return purorddt_RawMaterialCode; } set { purorddt_RawMaterialCode = value; } }        

        public double quantity { get { return purorddt_quantity; } set { purorddt_quantity = value; } }

        public double price { get { return purorddt_price; } set { purorddt_price = value; } }

        public double totalRecepted { get { return purorddt_totalRecepted; } set { purorddt_totalRecepted = value; } }

        
        //Constructor

        public clsPurchaseOrderDetail()
        {
            purorddt_codsec = 0;
            purorddt_fkPurchaseOrder = 0;
            purorddt_fkTypeRawMaterial = 0;
            purorddt_TypeRawMaterialName = "";
            purorddt_fkRawMaterial = 0;
            purorddt_RawMaterialName = "";
            purorddt_RawMaterialCode = "";
            purorddt_quantity = 0;
            purorddt_price = 0;
            purorddt_totalRecepted = 0;
        }

        public clsPurchaseOrderDetail(int codsec)
        {
            this.load(codsec);
        }


        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwPurchaseOrderDetail where purorddt_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["purorddt_codsec"]);
            this.fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["purorddt_fkPurchaseOrder"]);
            this.fkTypeRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["purorddt_fkTypeRawMaterial"]);
            this.TypeRawMaterialName = DS.Tables[0].Rows[0]["purorddt_fkTypeRawMaterial"].ToString();
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["purorddt_fkRawMaterial"]);
            this.RawMaterialName = DS.Tables[0].Rows[0]["purorddt_RawMaterialName"].ToString();
            this.RawMaterialCode = DS.Tables[0].Rows[0]["purorddt_RawMaterialCode"].ToString();
            this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["purorddt_quantity"]);
            this.price = Convert.ToDouble(DS.Tables[0].Rows[0]["purorddt_price"]);

        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO  bps_admin_purchaseorderdetail (purorddt_fkPurchaseOrder, purorddt_fkRawMaterial, purorddt_quantity, purorddt_price) ";
                    queryString += " VALUES (";
                    queryString += this.fkPurchaseOrder.ToString() + ",";
                    queryString += this.fkRawMaterial.ToString() + ",";
                    queryString += this.quantity.ToString() + ",";
                    queryString += this.price.ToString() + ");";
                    // aqui te faltaba poner el ) en esta ultima línea... eso te daba un error de sql
                }
                else
                {
                    queryString += "UPDATE bps_admin_purchaseorderdetail";
                    queryString += " SET ";
                    queryString += " purorddt_fkPurchaseOrder = " + this.fkPurchaseOrder.ToString() + ",";
                    queryString += " purorddt_fkRawMaterial = " + this.fkRawMaterial.ToString() + ",";
                    queryString += " purorddt_quantity = " + this.quantity.ToString() + ",";
                    queryString += " purorddt_price = " + this.price.ToString() + "";
                    queryString += " WHERE purorddt_codsec = " + this.codsec.ToString();
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPurchaseOrderDetail.save");
                return false;
            }

        }

        public static List<clsPurchaseOrderDetail> getListByPurchaseOrder(int orderCodsec)
        {
            List<clsPurchaseOrderDetail> lsPurchaseOrderDetail = new List<clsPurchaseOrderDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwPurchaseOrderDetail where purorddt_fkPurchaseOrder = " + orderCodsec.ToString());

            lsPurchaseOrderDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lsPurchaseOrderDetail.Add(new clsPurchaseOrderDetail());
                lsPurchaseOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["purorddt_codsec"]);
                lsPurchaseOrderDetail[i].fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["purorddt_fkPurchaseOrder"]);
                lsPurchaseOrderDetail[i].fkTypeRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["purorddt_fkTypeRawMaterial"]);
                lsPurchaseOrderDetail[i].TypeRawMaterialName = DS.Tables[0].Rows[i]["purorddt_TypeRawMaterialName"].ToString();
                lsPurchaseOrderDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["purorddt_fkRawMaterial"]);
                lsPurchaseOrderDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["purorddt_RawMaterialName"].ToString();
                lsPurchaseOrderDetail[i].RawMaterialCode = DS.Tables[0].Rows[i]["purorddt_RawMaterialCode"].ToString();
                lsPurchaseOrderDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["purorddt_quantity"]);
                lsPurchaseOrderDetail[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["purorddt_price"]);
                lsPurchaseOrderDetail[i].totalRecepted = Convert.ToDouble(DS.Tables[0].Rows[i]["purorddt_totalRecepted"]);
            }
            return lsPurchaseOrderDetail;
        }

        
    }
}

