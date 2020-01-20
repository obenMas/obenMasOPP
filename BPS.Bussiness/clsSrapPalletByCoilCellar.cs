using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsScrapPalletByCoilCellar
    {
        //Atributes
        private int spbcc_codsec;
        private int spbcc_fkScrapPallet;
        private int spbcc_fkCoilCellar;

        //Properties

        public int codsec { get { return spbcc_codsec; } set { spbcc_codsec = value; } }
        public int fkScrapPallet { get { return spbcc_fkScrapPallet; } set { spbcc_fkScrapPallet = value; } }
        public int fkCoilCellar { get { return spbcc_fkCoilCellar; } set { spbcc_fkCoilCellar = value; } }

        //Constructor

        public clsScrapPalletByCoilCellar(){
            codsec=0;
            fkScrapPallet=0;
            fkCoilCellar=0;

        }
        public clsScrapPalletByCoilCellar(int fkScrap)
        {
            this.load(fkScrap);
        }

        //Methods

    /* lo dejo por las dudas.

        public void load(int codsec){

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrappalletbycoilcellar WHERE spbcc_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_codsec"]);
                this.fkScrapPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_fkScrapPallet"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_fkCoilCellar"]);
            }
        }
     * */

        
        public void load(int fkScrap)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrappalletbycoilcellar WHERE spbcc_fkScrapPallet = " + fkScrap.ToString());

            if(DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_codsec"]);
                this.spbcc_fkScrapPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_fkScrapPallet"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["spbcc_fkCoilCellar"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_scrappalletbycoilcellar (spbcc_fkScrapPallet,spbcc_fkCoilCellar)";
                    queryString += "VALUES ( ";
                    queryString += this.fkScrapPallet.ToString() + ", ";
                    queryString += this.fkCoilCellar.ToString() + ") ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_scrappalletbycoilcellar";
                    queryString += " SET ";
                    queryString += " spbcc_fkScrapPallet = " + this.fkScrapPallet.ToString() + ", ";
                    queryString += " spbcc_fkCoilCellar = " + this.fkCoilCellar.ToString() + "";
                    queryString += " WHERE spbcc_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapPalletByCoilCellar.save");
                return false;
            }
        }
    }
}

