using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsReassign
    {
        //Atributes

        private int rea_codsec;
        private int rea_fkPallet;
        private double rea_weigth;
        private int rea_fkOldSalesOrderDetail;
        private int rea_fkNewSalesOrderDetail;
        private DateTime rea_date;
        private int rea_fkUser;

        //Properties

        public int codsec { get { return rea_codsec; } set { rea_codsec = value; } }

        public int fkPallet { get { return rea_fkPallet; } set { rea_fkPallet = value; } }

        public double weigth { get { return rea_weigth; } set { rea_weigth = value; } }

        public int fkOldSalesOrderDetail { get { return rea_fkOldSalesOrderDetail; } set { rea_fkOldSalesOrderDetail = value; } }

        public int fkNewSalesOrderDetail { get { return rea_fkNewSalesOrderDetail; } set { rea_fkNewSalesOrderDetail = value; } }

        public DateTime date { get { return rea_date; } set { rea_date = value; } }

        public int fkUser { get { return rea_fkUser; } set { rea_fkUser = value; } }

        //Constructor

        public clsReassign()
        {
            rea_codsec = 0;
            rea_fkPallet = 0;
            rea_weigth = 0;
            rea_fkOldSalesOrderDetail = 0;
            rea_fkNewSalesOrderDetail = 0;
            rea_date = DateTime.Now;
            rea_fkUser = 0;
        }

        public clsReassign(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_reassign where rea_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rea_codsec"]);
            this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rea_fkPallet"]);
            this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rea_weigth"]);
            this.fkOldSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["rea_fkOldSalesOrderDetail"]);
            this.fkNewSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["rea_fkNewSalesOrderDetail"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rea_date"]);
            this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["rea_fkUser"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                queryString += "INSERT INTO bps_prod_reassign (rea_fkPallet, rea_weigth, rea_fkOldSalesOrderDetail, rea_fkNewSalesOrderDetail, rea_fkUser, rea_date)";
                queryString += " VALUES (";
                queryString += this.fkPallet.ToString() + ", ";
                queryString += this.weigth.ToString() + ", ";
                queryString += this.fkOldSalesOrderDetail.ToString() + ", ";
                queryString += this.fkNewSalesOrderDetail.ToString() + ", ";
                queryString += this.fkUser.ToString() + ", ";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += ");";
                if (clsConnection.executeQuery(queryString))
                {
                    return true;
                }
               
                return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReassign.save");
                return false;
            }
        }

    }
}
