using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsAymasSalesOrder
    {
        private int aysord_codsec;
        private int aysord_fkSalesOrderDetail;
        private int aysord_number;
        private double aysord_quantity;
        private int aysord_fkUser;
        private DateTime aysord_date;
        private string aysord_status;


        public int codsec { get { return aysord_codsec; } set { aysord_codsec = value; } }

        public int fkSalesOrderDetail { get { return aysord_fkSalesOrderDetail; } set { aysord_fkSalesOrderDetail = value; } }

        public int number { get { return aysord_number; } set { aysord_number = value; } }

        public double quantity { get { return aysord_quantity; } set { aysord_quantity = value; } }

        public int fkUser { get { return aysord_fkUser; } set { aysord_fkUser = value; } }

        public DateTime date { get { return aysord_date; } set { aysord_date = value; } }

        public string status { get { return aysord_status; } set { aysord_status = value; } }

        public clsAymasSalesOrder()
        {
            aysord_codsec = 0;
            aysord_fkSalesOrderDetail = 0;
            aysord_number = 0;
            aysord_quantity = 0;
            aysord_fkUser = 0;
            aysord_date = DateTime.Now;
            aysord_status = string.Empty;
        }

         public clsAymasSalesOrder(int codsec)
        {
            this.load(codsec);
        }


        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";
                if(this.codsec==0)
                {
                    queryString += "INSERT INTO bps_prod_aymassalesorder (aysord_fkSalesOrderDetail, aysord_number, aysord_quantity, aysord_fkUser, aysord_status, aysord_date) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkSalesOrderDetail.ToString() + ", ";
                    queryString += "" + this.number.ToString() + ", ";
                    queryString += "" + this.quantity.ToString() + ", ";
                    queryString += "" + this.fkUser.ToString() + ", ";
                    queryString += "'" + this.status.ToString() + "', ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_aymassalesorder ";
                    queryString += " SET ";
                    queryString += "aysord_fkSalesOrderDetail = " + this.fkSalesOrderDetail.ToString() + ", ";
                    queryString += "aysord_number = " + this.number.ToString() + ", ";
                    queryString += "aysord_quantity = " + this.quantity.ToString() + ", ";
                    queryString += "aysord_fkUser = " + this.fkUser.ToString() + ", ";
                    queryString += "aysord_status = '" + this.status.ToString() + "', ";
                    queryString += "aysord_date = '" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                    queryString += " WHERE ayd_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsAymasSalesOrder.save");
                return false;
            }  
            
        }

        public static List<clsAymasSalesOrder> GetList(int fkSalesOrderDetail)
        {
            List<clsAymasSalesOrder> lst = new List<clsAymasSalesOrder>();
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_aymassalesorder WHERE aysord_fkSalesOrderDetail = "+fkSalesOrderDetail+";");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(new clsAymasSalesOrder());
                    lst[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["aysord_codsec"]);
                    lst[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["aysord_fkSalesOrderDetail"]);
                    lst[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["aysord_number"]);
                    lst[i].quantity = Convert.ToInt32(DS.Tables[0].Rows[i]["aysord_quantity"]);
                    lst[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["aysord_fkUser"]);
                    lst[i].status = DS.Tables[0].Rows[i]["aysord_status"].ToString();
                    lst[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["aysord_date"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lst;
        }

        public void load(int cod)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_aymassalesorder WHERE aysord_codsec = " + cod + ";");
            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["aysord_codsec"]);
                aysord_fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["aysord_fkSalesOrderDetail"]);
                number = Convert.ToInt32(DS.Tables[0].Rows[0]["aysord_number"]);
                quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["aysord_quantity"]);
                fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["aysord_fkUser"]);
                status = DS.Tables[0].Rows[0]["aysord_status"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["aysord_date"]);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        public bool close()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_aymassalesorder ";
                queryString += " SET ";
                queryString += "aysord_status = 'Cerrada' ";
                queryString += " WHERE aysord_codsec = " + this.codsec.ToString() + ";";
                
                bool res= clsConnection.executeQuery(queryString);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return res;

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsAymasSalesOrder.close");
                return false;
            }

        }

        public bool open()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_aymassalesorder ";
                queryString += " SET ";
                queryString += "aysord_status = 'Abierta' ";
                queryString += " WHERE aysord_codsec = " + this.codsec.ToString() + ";";

                bool res = clsConnection.executeQuery(queryString);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return res;

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsAymasSalesOrder.open");
                return false;
            }

        }

        public static int getSaleOrderDetailCodsec(string id)
        {
            int fksod = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwAymasSaleOrder WHERE Id=" + id);

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                fksod = Convert.ToInt32(DS.Tables[0].Rows[0]["fkSalesOrderDetail"]);
            }

            return fksod;
        }
    }
}


