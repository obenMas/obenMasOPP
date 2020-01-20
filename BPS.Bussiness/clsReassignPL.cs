using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsReassignPL
    {
        //Atributes

        private int reapl_codsec;
        private string reapl_palletCode;
        private double reapl_weigth;
        private int reapl_fkOldSalesOrderDetail;
        private int reapl_fkNewSalesOrderDetail;
        private DateTime reapl_date;
        private int reapl_fkUser;
        private string reapl_newSaleOrder;
        private int reapl_isLast;

        //Properties

        public int codsec { get { return reapl_codsec; } set { reapl_codsec = value; } }

        public string palletCode { get { return reapl_palletCode; } set { reapl_palletCode = value; } }

        public double weigth { get { return reapl_weigth; } set { reapl_weigth = value; } }

        public int fkOldSalesOrderDetail { get { return reapl_fkOldSalesOrderDetail; } set { reapl_fkOldSalesOrderDetail = value; } }

        public int fkNewSalesOrderDetail { get { return reapl_fkNewSalesOrderDetail; } set { reapl_fkNewSalesOrderDetail = value; } }

        public DateTime date { get { return reapl_date; } set { reapl_date = value; } }

        public int fkUser { get { return reapl_fkUser; } set { reapl_fkUser = value; } }

        public string newSaleOrder { get { return reapl_newSaleOrder; } set { reapl_newSaleOrder = value; } }

        public int isLast { get { return reapl_isLast; } set { reapl_isLast = value; } }


        //Constructor

        public clsReassignPL()
        {
            reapl_codsec = 0;
            reapl_palletCode = string.Empty;
            reapl_weigth = 0;
            reapl_fkOldSalesOrderDetail = 0;
            reapl_fkNewSalesOrderDetail = 0;
            reapl_date = DateTime.Now;
            reapl_fkUser = 0;
            reapl_newSaleOrder = string.Empty;
            reapl_isLast = 1;
        }

        public clsReassignPL(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_reassignpl where rea_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["reapl_codsec"]);
            this.palletCode = DS.Tables[0].Rows[0]["reapl_palletCode"].ToString();
            this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["reapl_weigth"]);
            this.fkOldSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["reapl_fkOldSalesOrderDetail"]);
            this.fkNewSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["reapl_fkNewSalesOrderDetail"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["reapl_date"]);
            this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["reapl_fkUser"]);
            this.newSaleOrder = DS.Tables[0].Rows[0]["reapl_newSaleOrder"].ToString();
            this.isLast = Convert.ToInt32(DS.Tables[0].Rows[0]["reapl_isLast"]);

        }

        public bool save()
        {
            try
            {
                searchDuplicated();
                string queryString = "";

                queryString += "INSERT INTO bps_prod_reassignpl (reapl_palletCode, reapl_weigth, reapl_fkOldSalesOrderDetail, reapl_fkNewSalesOrderDetail,reapl_newSaleOrder, reapl_fkUser, reapl_date, reapl_isLast)";
                queryString += " VALUES (";
                queryString += " '"+ this.palletCode.ToString() + "' , ";
                queryString += this.weigth.ToString() + ", ";
                queryString += this.fkOldSalesOrderDetail.ToString() + ", ";
                queryString += this.fkNewSalesOrderDetail.ToString() + ", ";
                queryString += " '" + this.newSaleOrder.ToString() + "' , ";
                queryString += this.fkUser.ToString() + ", ";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += this.isLast.ToString();
                queryString += ");";
                if (clsConnection.executeQuery(queryString))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReassignPL.save");
                return false;
            }
        }

        public bool searchDuplicated()
        {
            string queryString="";
            queryString += "UPDATE bps_prod_reassignpl ";
            queryString += " SET ";
            queryString += "reapl_isLast = 0 ";
            queryString += "WHERE reapl_palletCode = '" + this.palletCode+"'";

            if (clsConnection.executeQuery(queryString))
            {
                return true;
            }

            return false;
        }

    }
}