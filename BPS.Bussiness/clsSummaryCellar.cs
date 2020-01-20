using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSummaryCellar
    {
        //Atributes
        private double salesorder;
        private double outsalesorder;
        private double outstock;
        private double stock;
        private double delivey;

        //Properties
        public double SalesOrder { get { return salesorder; } set { salesorder = value; } }

        public double OutSalesOrder { get { return outsalesorder; } set { outsalesorder = value; } }

        public double OutStock { get { return outstock; } set { outstock = value; } }

        public double Stock { get { return stock; } set { stock = value; } }

        public double Delivey { get { return delivey; } set { delivey = value; } }
        
        //Constructor
        public clsSummaryCellar()
        {
            salesorder = 0;
            outsalesorder = 0;
            outstock = 0;
            stock = 0;
            delivey = 0;
        }

        //Methods
        public double getSalesOrder(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortSalesOrder('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                SalesOrder += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return SalesOrder;
        }

        public double getOutSalesOrder(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortOutSalesOrder('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                OutSalesOrder += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return OutSalesOrder;
        }

        public double getOutStock(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortOutStock('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                OutStock += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return OutStock;
        }

        public double getStock(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortStock('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                Stock += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return Stock;
        }

        public double getDelivery(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortDeliveryBopp('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                Delivey += Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
            return Delivey;
        }

        public double getSalesOrderOpp(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortSalesOrderOpp('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                SalesOrder += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return SalesOrder;
        }

        public double getOutSalesOrderOpp(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortOutSalesOrderOpp('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                OutSalesOrder += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return OutSalesOrder;
        }

        public double getStockOpp(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortStockOpp('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                Stock += Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
            return Stock;
        }

        public double getDeliveryOpp(String initdate, String enddate)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSummaryShortDeliveryOpp('" + initdate + "' , '" + enddate + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                Delivey += Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
            return Delivey;
        }
    }
}
