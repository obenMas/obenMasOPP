using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsTransportBySalesOrder
    {
        //Attributes

        private int tbso_codsec;
        private int tbso_fkSalesOrder;
        private int tbso_fkTransport;
        private string tbso_salesOrderNumber;
        private string tbso_transportName;
        private string tbso_driverName;
        private string tbso_companyName;
        private string tbso_vehiclePlate;
        private DateTime tbso_deliveryDate;
        private Boolean tbso_isClosed;

        private double tbso_cubicMeters;

        public double cubicMeters
        {
            get { return tbso_cubicMeters; }
            set { tbso_cubicMeters = value; }
        }

        private DateTime tbso_date;

        public DateTime date
        {
            get { return tbso_date; }
            set { tbso_date = value; }
        }

        private string tbso_sales;

        public string sales
        {
            get { return tbso_sales; }
            set { tbso_sales = value; }
        }

        private bool tbso_isVisible;

        public bool isVisible
        {
            get { return tbso_isVisible; }
            set { tbso_isVisible = value; }
        }

        private string tbso_head;

        public string head
        {
            get { return tbso_head; }
            set { tbso_head = value; }
        }

        private string tbso_footer;

        public string footer
        {
            get { return tbso_footer; }
            set { tbso_footer = value; }
        }

        private string tbso_verify;

        public string verify
        {
            get { return tbso_verify; }
            set { tbso_verify = value; }
        }



        //Properties

        public int codsec { get { return tbso_codsec; } set { tbso_codsec = value; } }

        public int fkSalesOrder { get { return tbso_fkSalesOrder; } set { tbso_fkSalesOrder = value; } }

        public int fkTransport { get { return tbso_fkTransport; } set { tbso_fkTransport = value; } }

        public string salesOrderNumber { get { return tbso_salesOrderNumber; } set { tbso_salesOrderNumber = value; } }

        public string transportName { get { return tbso_transportName; } set { tbso_transportName = value; } }

        public string driverName { get { return tbso_driverName; } set { tbso_driverName = value; } }

        public string companyName { get { return tbso_companyName; } set { tbso_companyName = value; } }

        public string vehiclePlate { get { return tbso_vehiclePlate; } set { tbso_vehiclePlate = value; } }

        public DateTime deliveryDate { get { return tbso_deliveryDate; } set { tbso_deliveryDate = value; } }

        public Boolean isClosed { get { return tbso_isClosed; } set { tbso_isClosed = value; } }

        //Constructor

        public clsTransportBySalesOrder()
        { 
            tbso_codsec = 0;
            tbso_fkSalesOrder = 0;
            tbso_fkTransport = 0;
            tbso_salesOrderNumber = "";
            tbso_transportName = "";
            tbso_driverName = "";
            tbso_companyName = "";
            tbso_vehiclePlate = "";
            tbso_deliveryDate = DateTime.Now;
            tbso_isClosed = false;
        }

        public clsTransportBySalesOrder(int transportationBySalesOrderCodsec)
        {
            this.load(transportationBySalesOrderCodsec);
        }

        public clsTransportBySalesOrder(int transportationBySalesOrderCodsec, bool data)
        {
            this.load(transportationBySalesOrderCodsec, data);
        }
        //Methods

        public void load(int transportationBySalesOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwtransportbysalesorder WHERE tbso_codsec = " + transportationBySalesOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tbso_codsec"]);
                this.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["tbso_fkSalesOrder"]);
                this.fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["tbso_fkTransport"]);
                this.salesOrderNumber = DS.Tables[0].Rows[0]["tbso_salesOrderNumber"].ToString();
                this.transportName = DS.Tables[0].Rows[0]["tbso_transportName"].ToString();
                this.driverName = DS.Tables[0].Rows[0]["tbso_driverName"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["tbso_companyName"].ToString();
                this.vehiclePlate = DS.Tables[0].Rows[0]["tbso_vehiclePlate"].ToString();
                this.deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["tbso_deliveryDate"]);
                this.isClosed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["tbso_isClosed"], DS.Tables[0].Rows[0]["tbso_isClosed"].GetType().FullName);
            }
        }

        public void load(int transportationBySalesOrderCodsec, bool data)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_transportbysalesorder WHERE tbso_codsec = " + transportationBySalesOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tbso_codsec"]);
                this.cubicMeters = Convert.ToDouble(DS.Tables[0].Rows[0]["tbso_cubicMeters"]);
                this.sales = DS.Tables[0].Rows[0]["tbso_sales"].ToString();
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["tbso_date"]);
                this.isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["tbso_isVisible"], DS.Tables[0].Rows[0]["tbso_isVisible"].GetType().FullName);
                this.head = DS.Tables[0].Rows[0]["tbso_head"].ToString();
                this.footer = DS.Tables[0].Rows[0]["tbso_footer"].ToString();
                this.verify = DS.Tables[0].Rows[0]["tbso_verify"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO  bps_prod_transportbysalesorder ( tbso_fkSalesOrder, tbso_fkTransport, tbso_driverName, tbso_companyName, tbso_vehiclePlate, tbso_deliveryDate, tbso_isClosed ) ";
                    queryString += " VALUES (";
                    queryString += " " + this.fkSalesOrder.ToString() + ",";
                    queryString += " " + this.fkTransport.ToString() + ",";
                    queryString += " '" + this.driverName.ToString() + "',";
                    queryString += " '" + this.companyName + "',";
                    queryString += " '" + this.vehiclePlate + "',";
                    queryString += " '" + this.deliveryDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " " + this.isClosed.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE  bps_prod_transportbysalesorder";
                    queryString += " SET ";
                    queryString += " tbso_fkSalesOrder = " + this.fkSalesOrder.ToString() + ",";
                    queryString += " tbso_fkTransport =  " + this.fkTransport.ToString() + ",";
                    queryString += " tbso_driverName =  '" + this.driverName.ToString() + "',";
                    queryString += " tbso_companyName =  '" + this.companyName + "',";
                    queryString += " tbso_vehiclePlate =  '" + this.vehiclePlate + "',";
                    queryString += " tbso_deliveryDate =  '" + this.deliveryDate + "',";
                    queryString += " tbso_isClosed =  " + this.isClosed.ToString() + "";
                    queryString += " WHERE tbso_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);

                return true;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTransportBySalesOrder.save");
                return false;
            }
        }

        public static List<clsTransportBySalesOrder> getListBySalesOrder(int salesOrderCodsec)
        {
            List<clsTransportBySalesOrder> lstTransportBySalesOrder = new List<clsTransportBySalesOrder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwtransportbysalesorder WHERE tbso_fkSalesOrder = " + salesOrderCodsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransportBySalesOrder.Add(new clsTransportBySalesOrder());
                lstTransportBySalesOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["tbso_codsec"]);
                lstTransportBySalesOrder[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["tbso_fkSalesOrder"]);
                lstTransportBySalesOrder[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["tbso_fkTransport"]);
                lstTransportBySalesOrder[i].salesOrderNumber = DS.Tables[0].Rows[i]["tbso_salesOrderNumber"].ToString();
                lstTransportBySalesOrder[i].transportName = DS.Tables[0].Rows[i]["tbso_transportName"].ToString();
                lstTransportBySalesOrder[i].driverName = DS.Tables[0].Rows[i]["tbso_driverName"].ToString();
                lstTransportBySalesOrder[i].companyName = DS.Tables[0].Rows[i]["tbso_companyName"].ToString();
                lstTransportBySalesOrder[i].vehiclePlate = DS.Tables[0].Rows[i]["tbso_vehiclePlate"].ToString();
                lstTransportBySalesOrder[i].deliveryDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["tbso_deliveryDate"]);
                lstTransportBySalesOrder[i].isClosed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["tbso_isClosed"], DS.Tables[0].Rows[i]["tbso_isClosed"].GetType().FullName);
            }

            return lstTransportBySalesOrder;
        }

        public override string ToString()
        {
            List<clsTransportBySalesOrder> lstTransportBSO = clsTransportBySalesOrder.getListBySalesOrder(this.fkSalesOrder);
            int pos = -1;
            for (int i = 0; i < lstTransportBSO.Count; i++)
            {
                if (lstTransportBSO[i].codsec == this.codsec)
                    pos = i + 1;
            }

            return "Contenedor  " + pos.ToString() + "/" + lstTransportBSO.Count.ToString() + "  [" + this.transportName + "]";
        }

        public bool saveCube()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE  bps_prod_transportbysalesorder";
                queryString += " SET ";
                queryString += " tbso_cubicMeters = " + this.cubicMeters.ToString() + ",";
                queryString += " tbso_sales =  '" + this.sales + "',";
                queryString += " tbso_isVisible =  '" + this.isVisible + "',";
                queryString += " tbso_head =  '" + this.head + "',";
                queryString += " tbso_footer =  '" + this.footer + "',";
                queryString += " tbso_verify =  '" + this.verify + "',";
                queryString += " tbso_date =  '" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                queryString += " WHERE tbso_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTransportBySalesOrder.save");
                return false;
            }
        }
    }
}
