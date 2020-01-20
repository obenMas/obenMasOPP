using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsShippings
    {
        //Atributes

        private int shp_codsec;
        private int shp_fkPallet;
        private int shp_fkEntity;
        private int shp_fkSalesOrder;
        private int shp_fkProduct;
        private double shp_weigth;
        private DateTime shp_date;
        private int shp_fkPlant;


        //Properties

        public int codsec { get { return shp_codsec; } set { shp_codsec = value; } }

        public int fkPallet { get { return shp_fkPallet; } set { shp_fkPallet = value; } }

        public int fkEntity { get { return shp_fkEntity; } set { shp_fkEntity = value; } }

        public int fkSalesOrder { get { return shp_fkSalesOrder; } set { shp_fkSalesOrder = value; } }

        public int fkProduct { get { return shp_fkProduct; } set { shp_fkProduct = value; } }

        public double weigth { get { return shp_weigth; } set { shp_weigth = value; } }

        public DateTime date { get { return shp_date; } set { shp_date = value; } }

        public int fkPlant { get { return shp_fkPlant; } set { shp_fkPlant = value; } }

        //Constructor

        public clsShippings()
        {
            shp_codsec = 0;
            shp_fkPallet = 0;
            shp_fkEntity = 0;
            shp_fkSalesOrder = 0;
            shp_fkProduct = 0;
            shp_weigth = 0;
            shp_date = DateTime.Now;
            shp_fkPlant = 0;
        }

        public clsShippings(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_shippings where shp_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
            this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkPallet"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkEntity"]);
            this.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkSalesOrder"]);
            this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkProduct"]);
            this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_weigth"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rtn_date"]);
            this.shp_fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkPlant"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";
    
                queryString += "INSERT INTO bps_prod_shippings (shp_fkPallet, shp_fkEntity, shp_fkSalesOrder, shp_fkProduct, shp_weigth, shp_date, shp_fkPlant)";
                queryString += " VALUES (";
                queryString += this.fkPallet.ToString() + ", ";
                queryString += this.fkEntity.ToString() + ", ";
                queryString += this.fkSalesOrder.ToString() + ", ";
                queryString += this.fkProduct.ToString() + ", ";
                queryString += this.weigth.ToString() + ", ";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
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
                clsLog.addLog(ex, 3, "clsShippings.save");
                return false;
            }
        }

    }
}
