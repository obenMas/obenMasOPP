using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletMovements
    {
        //  Attriubutes
        private int plm_codsec;
        private string plm_type;
        private int plm_fkPallet;
        private int plm_fkProduct;
        private string plm_lote;
        private int plm_fkOrigCellar;
        private int plm_fkDestCellar;
        private int plm_fkUser;
        private DateTime plm_date;

       //   Properties
        public int codsec { get { return plm_codsec; } set { plm_codsec = value; } }
        public string type { get { return plm_type; } set { plm_type = value; } }
        public int fkPallet { get { return plm_fkPallet; } set { plm_fkPallet = value; } }
        public int fkProduct { get { return plm_fkProduct; } set { plm_fkProduct = value; } }
        public string lote { get { return plm_lote; } set { plm_lote = value; } }
        public int fkOrigCellar { get { return plm_fkOrigCellar; } set { plm_fkOrigCellar = value; } }
        public int fkDestCellar { get { return plm_fkDestCellar; } set { plm_fkDestCellar = value; } }
        public int fkUser { get { return plm_fkUser; } set { plm_fkUser = value; } }
        public DateTime date { get { return plm_date; } set { plm_date = value; } }

      //    Constructor
        public clsPalletMovements()
        {
            codsec = 0;
            type = "";
            fkPallet = 0;
            fkProduct = 0;
            lote = "";
            fkOrigCellar = 0;
            fkDestCellar = 0;
            fkUser = 0;
        }

        public clsPalletMovements(int codsec)
        {
            this.load(codsec);
        }
        /*
        public clsPalletMovements(int fkPallet)
        {
            this.loadByFkPallet(fkPallet);
        }*/

     //     Metodos

        private void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletmovements WHERE plm_codsec = " + codsec.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_codsec"]);
                this.type = Convert.ToString(DS.Tables[0].Rows[0]["plm_type"]);
                this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkPallet"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkProduct"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["plm_lote"]);
                this.fkOrigCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkOrigCellar"]);
                this.fkDestCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkDestCellar"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["plm_date"]);
            }
        }

        private void loadByFkPallet(int fkPallet)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletmovements WHERE plm_fkPallet = " + fkPallet.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_codsec"]);
                this.type = Convert.ToString(DS.Tables[0].Rows[0]["plm_type"]);
                this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkPallet"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkProduct"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["plm_lote"]);
                this.fkOrigCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkOrigCellar"]);
                this.fkDestCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkDestCellar"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["plm_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["plm_date"]);
            }
        }

        public bool save()
        {
            try
            {
                string stringQuery = "";
                DataSet DS = new DataSet();

                if (this.codsec == 0)
                {
                    stringQuery += "INSERT INTO bps_prod_palletmovements(plm_type,plm_fkPallet,plm_fkProduct,plm_lote,plm_fkOrigCellar,plm_fkDestCellar,plm_fkUser,plm_date)";
                    stringQuery += " VALUES(";
                    stringQuery += "'" + this.type.ToString() + "',";
                    stringQuery += this.fkPallet.ToString() + ", ";
                    stringQuery += this.fkProduct.ToString() + ", ";
                    stringQuery += "'" + this.lote.ToString() + "', ";
                    stringQuery += this.fkOrigCellar.ToString() + ", ";
                    stringQuery += this.fkDestCellar.ToString() + ", ";
                    stringQuery += this.fkUser.ToString() + ", ";
                    stringQuery += "'" + this.date.ToString("dd/MM/yyyy HH:mm") + "');";
                }
                else
                {
                    stringQuery += "UPDATE bps_prod_palletmovements";
                    stringQuery += "SET ";
                    stringQuery += "'" + this.type.ToString() + ", ";
                    stringQuery += this.fkPallet.ToString() + ", ";
                    stringQuery += this.fkProduct.ToString() + ", ";
                    stringQuery += "'" + this.lote.ToString() + "', ";
                    stringQuery += this.fkOrigCellar.ToString() + ", ";
                    stringQuery += this.fkDestCellar.ToString() + ", ";
                    stringQuery += this.fkUser.ToString() + ", ";
                    stringQuery += "'" + this.date.ToString("dd/MM/yyyy HH:mm") + "');";
                }

               return clsConnection.executeQuery(stringQuery);
            
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletMovements.save");
                return false;
            }
        }
    }
}
