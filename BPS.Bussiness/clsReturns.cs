using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsReturns
    {
        //Atributes

        private int rtn_codsec;
        private int rtn_fkPallet;
        private int rtn_fkCoil;
        private int rtn_fkEntity;
        private int rtn_fkSalesOrder;
        private int rtn_fkProduct;
        private double rtn_weigth;
        private DateTime rtn_date;
        private string rtn_MovementTypes;
        private int rtn_fkPlant;


        //Properties

        public int codsec { get { return rtn_codsec; } set { rtn_codsec = value; } }

        public int fkPallet { get { return rtn_fkPallet; } set { rtn_fkPallet = value; } }

        public int fkCoil { get { return rtn_fkCoil; } set { rtn_fkCoil = value; } }

        public int fkEntity { get { return rtn_fkEntity; } set { rtn_fkEntity = value; } }

        public int fkSalesOrder { get { return rtn_fkSalesOrder; } set { rtn_fkSalesOrder = value; } }

        public int fkProduct { get { return rtn_fkProduct; } set { rtn_fkProduct = value; } }

        public double weigth { get { return rtn_weigth; } set { rtn_weigth = value; } }

        public DateTime date { get { return rtn_date; } set { rtn_date = value; } }

        public string MovementTypes { get { return rtn_MovementTypes; } set { rtn_MovementTypes = value; } }

        public int fkPlant { get { return rtn_fkPlant; } set { rtn_fkPlant = value; } }

        //Constructor

        public clsReturns()
        {
            rtn_codsec = 0;
            rtn_fkPallet = 0;
            rtn_fkCoil = 0;
            rtn_fkEntity = 0;
            rtn_fkSalesOrder = 0;
            rtn_fkProduct = 0;
            rtn_weigth = 0;
            rtn_date = DateTime.Now;
            rtn_MovementTypes = string.Empty;
            rtn_fkPlant = 0;
        }

        public clsReturns(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_returns where rtn_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
            this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkPallet"]);
            this.fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkCoil"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkEntity"]);
            this.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkSalesOrder"]);
            this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkProduct"]);
            this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_weigth"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rtn_date"]);
            this.MovementTypes = DS.Tables[0].Rows[0]["rtn_MovementTypes"].ToString();
            this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkPlant"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";
    
                queryString += "INSERT INTO bps_prod_returns (rtn_fkPallet, rtn_fkCoil, rtn_fkEntity, rtn_fkSalesOrder, rtn_fkProduct, rtn_weigth,rtn_MovementTypes, rtn_date, rtn_fkPlant)";
                queryString += " VALUES (";
                queryString += this.fkPallet.ToString() + ", ";
                queryString += this.fkCoil.ToString() + ", ";
                queryString += this.fkEntity.ToString() + ", ";
                queryString += this.fkSalesOrder.ToString() + ", ";
                queryString += this.fkProduct.ToString() + ", ";
                queryString += this.weigth.ToString() + ", ";
                queryString += "' " + this.MovementTypes.ToString() + "' " + ", ";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "', ";
                queryString += this.fkPlant.ToString() + " ";
                queryString += ");";
                if (clsConnection.executeQuery(queryString))
                {
                    return true;
                }
               
                return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReturns.save");
                return false;
            }
        }

    }
}
