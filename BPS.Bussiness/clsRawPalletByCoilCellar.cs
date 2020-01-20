using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRawPalletByCoilCellar
    {
        //Atributos
        private int rpbcc_codsec;
        private int rpbcc_fkRawPallet;
        private int rpbcc_fkCoilCellar;

        //Properties
        public int codsec { get { return rpbcc_codsec; } set { rpbcc_codsec = value; } }
        public int fkRawPallet { get { return rpbcc_fkRawPallet; } set { rpbcc_fkRawPallet = value; } }
        public int fkCoilCellar { get { return rpbcc_fkCoilCellar; } set { rpbcc_fkCoilCellar = value; } }
        //Constructor

        public clsRawPalletByCoilCellar()
        {
            codsec = 0;
            fkRawPallet = 0;
            fkCoilCellar = 0;
        }
       
        public clsRawPalletByCoilCellar(int codsec)
        {
            this.load(codsec);            
        }

        //Methods

        public void load(int fkRawPallet)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawPalletByCoilCellar WHERE rpbcc_fkRawPallet = " + fkRawPallet.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rpbcc_codsec"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rpbcc_fkCoilCellar"]);
                this.fkRawPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rpbcc_fkRawPallet"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawPalletByCoilCellar(rpbcc_fkRawPallet,rpbcc_fkCoilCellar)";
                    queryString += "VALUES ( ";
                    queryString += this.fkRawPallet.ToString() + ", ";
                    queryString += this.fkCoilCellar.ToString() + " ) ";
                }
                else
                {
                    //(rpbcc_fkRawPallet,rpbcc_fkCoilCellar)
                    queryString += "UPDATE bps_prod_rawPalletbyCoilCellar ";
                    queryString += " SET ";
                    queryString += " rpbcc_fkRawPallet = " + this.fkRawPallet.ToString() + ", ";
                    queryString += " rpbcc_fkCoilCellar = " + this.fkCoilCellar.ToString() + "";
                    queryString += " WHERE rpbcc_fkRawPallet = " + this.fkRawPallet.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex)
            {             
                clsLog.addLog(ex, 3, "clsRawPalletByCoilCellar.save");
                return false;
            }
        }

        public int getfkCoilCellarByfkRawPallet(int fkRawPallet)
        {
             DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawPalletByCoilCellar WHERE rpbcc_fkRawPallet = " + fkRawPallet.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(DS.Tables[0].Rows[0]["rpbcc_fkCoilCellar"]);
            }
            else
            {
                return 0;
            }
        }

        public static bool setFkCoilCellarNew(int palletCodsec, int fkcoilcellar)
        {
            DataSet DS = new DataSet();
            string queryString = "";

            try
            {
                queryString += "UPDATE bps_prod_rawPalletByCoilCellar ";
                queryString += "SET rpbcc_fkCoilCellar = " + fkcoilcellar.ToString();
                queryString += "WHERE rpbcc_fkRawPallet = " + palletCodsec.ToString();

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawPalletByCoilCellar.save");
                return false;
            }
        }
    }
}
    

      
