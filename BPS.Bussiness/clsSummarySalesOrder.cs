using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSummarySalesOrder
    {
        private string sord_EntityName;
        private string sord_number;
        private bool sord_isInternationalSale;
        private DateTime sord_createdDate;
        private string sord_FilmName;
        private int prod_width;
        private double sod_quantity;
        private double sod_produced;
        private double sod_total;
        private String coil_cuttingdate;
        private string sord_statusName;
        private DateTime sord_compromiseDate;


        //Properties

        public string EntityName { get { return sord_EntityName; } set { sord_EntityName = value; } }

        public string number { get { return sord_number; } set { sord_number = value; } }

        public bool isInternationalSale { get { return sord_isInternationalSale; } set { sord_isInternationalSale = value; } }

        public DateTime createdDate { get { return sord_createdDate; } set { sord_createdDate = value; } }

        public string FilmName { get { return sord_FilmName; } set { sord_FilmName = value; } }

        public int width { get { return prod_width; } set { prod_width = value; } }

        public double quantity { get { return sod_quantity; } set { sod_quantity = value; } }

        public double produced { get { return sod_produced; } set { sod_produced = value; } }

        public double total { get { return sod_total; } set { sod_total = value; } }

        public string cuttingDate { get { return coil_cuttingdate; } set { coil_cuttingdate = value; } }

        public string statusName { get { return sord_statusName; } set { sord_statusName = value; } }

        public DateTime compromiseDate { get { return sord_compromiseDate; } set { sord_compromiseDate = value; } }

        public clsSummarySalesOrder()
        { 
            sord_EntityName = "";
            sord_number = "";
            sord_isInternationalSale = false;
            sord_createdDate = DateTime.Now;
            coil_cuttingdate = string.Empty;
            sord_FilmName = "";
            prod_width = 0;
            sod_quantity = 0;
            sod_produced = 0;
            sod_total = 0;
            sord_statusName = string.Empty;
            sord_compromiseDate = DateTime.Now;
        }

        public static List<clsSummarySalesOrder> getList()
        {
            List<clsSummarySalesOrder> lstSalesOrder = new List<clsSummarySalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderfulfillment()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSummarySalesOrder());
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].FilmName = DS.Tables[0].Rows[i]["prod_film"].ToString();
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"].ToString());
                lstSalesOrder[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstSalesOrder[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstSalesOrder[i].produced = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_produced"]);
                lstSalesOrder[i].total = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_total"]);
                lstSalesOrder[i].cuttingDate = DS.Tables[0].Rows[i]["coil_cuttingdate"].ToString();
                lstSalesOrder[i].statusName = DS.Tables[0].Rows[i]["sord_statusName"].ToString();
                lstSalesOrder[i].compromiseDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_compromiseDate"].ToString());
            }
            return lstSalesOrder;
        }

        public static List<clsSummarySalesOrder> getListByYear()
        {
            List<clsSummarySalesOrder> lstSalesOrder = new List<clsSummarySalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spSalesOrderFulFillmentByYear 0,'','National','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSummarySalesOrder());
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].FilmName = DS.Tables[0].Rows[i]["prod_film"].ToString();
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"].ToString());
                lstSalesOrder[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstSalesOrder[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstSalesOrder[i].produced = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_produced"]);
                lstSalesOrder[i].total = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_total"]);
                lstSalesOrder[i].cuttingDate = DS.Tables[0].Rows[i]["coil_cuttingdate"].ToString();
                lstSalesOrder[i].statusName = DS.Tables[0].Rows[i]["sord_statusName"].ToString();
                lstSalesOrder[i].compromiseDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_compromiseDate"].ToString());
            }
            return lstSalesOrder;
        }

        public static List<clsSummarySalesOrder> getListInternationalSummarySalesOrder()
        {
            List<clsSummarySalesOrder> lstSalesOrder = new List<clsSummarySalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spSalesOrderFulFillmentByYear 0,'','International','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSummarySalesOrder());
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].FilmName = DS.Tables[0].Rows[i]["prod_film"].ToString();
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"].ToString());
                lstSalesOrder[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstSalesOrder[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstSalesOrder[i].produced = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_produced"]);
                lstSalesOrder[i].total = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_total"]);
                lstSalesOrder[i].cuttingDate = DS.Tables[0].Rows[i]["coil_cuttingdate"].ToString();
                lstSalesOrder[i].statusName = DS.Tables[0].Rows[i]["sord_statusName"].ToString();
            }
            return lstSalesOrder;
        }

        public static List<clsSummarySalesOrder> getListInternational()
        {
            List<clsSummarySalesOrder> lstSalesOrder = new List<clsSummarySalesOrder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderfulfillmentInternational()");

            lstSalesOrder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrder.Add(new clsSummarySalesOrder());
                lstSalesOrder[i].EntityName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstSalesOrder[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstSalesOrder[i].FilmName = DS.Tables[0].Rows[i]["prod_film"].ToString();
                lstSalesOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"].ToString());
                lstSalesOrder[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstSalesOrder[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstSalesOrder[i].produced = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_produced"]);
                lstSalesOrder[i].total = Convert.ToDouble(DS.Tables[0].Rows[i]["sord_total"]);
                lstSalesOrder[i].cuttingDate = DS.Tables[0].Rows[i]["coil_cuttingdate"].ToString();
            }
            return lstSalesOrder;
        }
    }
}
