using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPhotoBackload
    {
        //Atributes
        private int pht_codsec;
        private int pht_fkinventory;
        private int pht_invpalletcodsec;
        private int pht_invfkproduct;
        private clsProduct plt_product;
        private int pht_invpalletnumber;
        private string pht_invcode;
        private double pht_invnetweight;
        private int pht_invfkcoilcellar;
        private string pht_invsalesordernumber;
        private string pht_invcustomername;
        private string pht_invorigin;
        private string pht_invlotnumber;
        private DateTime pht_invextrusiondate;
        private int pht_invcoilcount;

        //Properties

        public int codsec { get { return pht_codsec; } set { pht_codsec = value; } }

        public int fkinventory { get { return pht_fkinventory; } set { pht_fkinventory = value; } }

        public int palletcodsec { get { return pht_invpalletcodsec; } set { pht_invpalletcodsec = value; } }

        public int fkProduct { get { return pht_invfkproduct; } set { pht_invfkproduct = value; } }

        public clsProduct product { get { return plt_product; } set { plt_product = value; } }

        public int palletnumber { get { return pht_invpalletnumber; } set { pht_invpalletnumber = value; } }

        public string code { get { return pht_invcode; } set { pht_invcode = value; } }
        
        public double netWeight { get { return pht_invnetweight; } set { pht_invnetweight = value; } }

        public int fkcoilcellar { get { return pht_invfkcoilcellar; } set { pht_invfkcoilcellar = value; } }

        public string salesOrderNumber { get { return pht_invsalesordernumber; } set { pht_invsalesordernumber = value; } }

        public string customerName { get { return pht_invcustomername; } set { pht_invcustomername = value; } }

        public string origin { get { return pht_invorigin; } set { pht_invorigin = value; } }

        public string lotNumber { get { return pht_invlotnumber; } set { pht_invlotnumber = value; } }

        public DateTime extrusionDate { get { return pht_invextrusiondate; } set { pht_invextrusiondate = value; } }

        public int coilCount { get { return pht_invcoilcount; } set { pht_invcoilcount = value; } }


        //Constructor

        public clsPhotoBackload()
        { 
            pht_codsec = 0;
            pht_invpalletcodsec = 0;
            pht_invfkproduct = 0;
            plt_product = new clsProduct();
            pht_invpalletnumber = 0;
            pht_invcode = "";
            pht_invnetweight = 0;
            pht_invfkcoilcellar = 0;
            pht_invsalesordernumber = "";
            pht_invcustomername = "";
            pht_invorigin = "";
            pht_invlotnumber = "";
            pht_invextrusiondate = DateTime.Now;
            pht_invcoilcount = 0;
        }

        public clsPhotoBackload(int palletCodsec)
        {
            this.load(palletCodsec);
        }

        //Methods

        public void load(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCodsec(" + palletCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count >0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                palletcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                product = new clsProduct(fkProduct, true);
                palletnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                fkinventory = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public bool save(int codsec)
        {
            try
            {
                DataSet Ds = new DataSet();
                Ds = clsConnection.getDataSetResult("spPhotoBackload " + codsec);
                if (Ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsPhotoBackload.save");
                return false;
            }
        }

        public static int countPhotoByInventory(int inventory)
        {
            int mynumber = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COUNT(*) AS count_photo FROM bps_prod_photobackload WHERE pht_fkinventory = " + inventory.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    mynumber = Convert.ToInt32(DS.Tables[0].Rows[i]["count_photo"]);
            }
            return mynumber;
        }
    }
}
