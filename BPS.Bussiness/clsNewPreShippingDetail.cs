using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    public class clsNewPreShippingDetail
    {
        private int npsd_codsec;
        private int npsd_fkNewPreShipping;
        private int npsd_fkPallet;
        private int npsd_fkProduct;
        private double npsd_netWeight;
        private int npsd_fkSaleOrderDetail;

        public int codsec { get { return npsd_codsec; } set { npsd_codsec = value; } }

        public int fkNewPreShipping { get { return npsd_fkNewPreShipping; } set { npsd_fkNewPreShipping = value; } }

        public int fkPallet { get { return npsd_fkPallet; } set { npsd_fkPallet = value; } }

        public int fkProduct { get { return npsd_fkProduct; } set { npsd_fkProduct = value; } }

        public double netWeight { get { return npsd_netWeight; } set { npsd_netWeight = value; } }

        public int fkSaleOrderDetail { get { return npsd_fkSaleOrderDetail; } set { npsd_fkSaleOrderDetail = value; } }
        
        //Constructor
        public clsNewPreShippingDetail()
        {
            codsec = 0;
            fkNewPreShipping = 0;
            fkPallet = 0;
            fkProduct = 0;
            netWeight = 0;
            fkSaleOrderDetail = 0;
        }

        public clsNewPreShippingDetail(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreShippingDetail where npsd_fkPallet = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["npsd_codsec"]);
                this.fkNewPreShipping = Convert.ToInt32(DS.Tables[0].Rows[0]["npsd_fkNewPreShipping"]);
                this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["npsd_fkPallet"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["npsd_fkProduct"]);
                this.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["npsd_netWeight"]);
                this.fkSaleOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["npsd_fkSaleOrderDetail"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_newPreShippingDetail (npsd_fkNewPreShipping, npsd_fkPallet, npsd_fkProduct, npsd_netWeight, npsd_fkSaleOrderDetail)";
                    queryString += " VALUES ( ";
                    queryString += "" + this.fkNewPreShipping + ", ";
                    queryString += "" + this.fkPallet + ", ";
                    queryString += "" + this.fkProduct + ", ";
                    queryString += "" + this.netWeight + ", ";
                    queryString += "" + this.fkSaleOrderDetail + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_newPreShippingDetail";
                    queryString += " SET ";
                    queryString += "npsd_fkNewPreShipping = " + this.fkNewPreShipping + ", ";
                    queryString += "npsd_fkPallet = " + this.fkPallet + ", ";
                    queryString += "npsd_fkProduct = " + this.fkProduct + ", ";
                    queryString += "npsd_netWeight =" + this.netWeight + ", ";
                    queryString += "npsd_fkSaleOrderDetail = " + this.fkSaleOrderDetail + ", ";
                    queryString += " WHERE npship_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewPreShippingDetail.save");
                return false;
            }
        }

        public bool cancel()
        {
            bool anduvo = false;

            anduvo = clsConnection.executeQuery("DELETE FROM bps_prod_newPreShippingDetail where npsd_fkPallet = " + fkPallet.ToString());
                
            return anduvo;
        }

        public bool returned()
        {
            bool anduvo = false;

            anduvo = clsConnection.executeQuery("UPDATE bps_prod_newPreShipping SET npship_fkStatus = 3067 where npsd_fkNewPreShipping = " + this.fkNewPreShipping.ToString());

            return anduvo;
        }

        public bool delete()
        {
            clsNewPreShipping nps = new clsNewPreShipping(this.fkNewPreShipping);
            if(nps.getStatusName()=="Abierto")
            {
                clsConnection.executeQuery("DELETE FROM bps_prod_newPreShippingDetail where npsd_fkPallet = " + fkPallet.ToString());
                return true;
            }
            else
            {
                MessageBox.Show("El pre-despacho que intenta modificar no se encuentra abierto. Para poder realizar modificaciones, el pre-depacho no puede estar programado o despachado.");
                return false;
            }
        }

        public static DataSet getListByPDCodsec(int pdCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreshippingDetail WHERE npsd_fkNewPreshipping = " + pdCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                    
            }
            else
            {

            }
            return DS;
        }
    }
}
