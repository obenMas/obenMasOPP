using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCellarStocks
    {
        //Atributes

        private int cs_codsec;
        private int cs_fkCoilCellar;
        private int cs_fkRawMaterial;
        private string cs_lotNumber;
        private double cs_quantity;

        //Properties

        public int codsec { get { return cs_codsec; } set { cs_codsec = value; } }

        public int fkCoilCellar { get { return cs_fkCoilCellar; } set { cs_fkCoilCellar = value; } }

        public int fkRawMaterial { get { return cs_fkRawMaterial; } set { cs_fkRawMaterial = value; } }

        public string lotNumber { get { return cs_lotNumber; } set { cs_lotNumber = value; } }

        public double quantity { get { return cs_quantity; } set { cs_quantity = value; } }


        //Constructor

        public clsCellarStocks()
        {
            codsec = 0;
            fkCoilCellar = 0;
            fkRawMaterial = 0;
            lotNumber = "";
            quantity = 0;
        }

        public clsCellarStocks(int cellar, int fkraw, string lot)
        {
            this.load(cellar,fkraw,lot);
        }

        //Methods

        public void load(int cellar,int fkraw, string lot)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cellarstocks where cs_fkCoilCellar = " + cellar.ToString() + " AND fkRawMaterial = " + fkraw.ToString() + " AND cs_lotNumber = '" + lot +"'");

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cs_codsec"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cs_fkCoilCellar"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["cs_fkRawMaterial"]);
                this.lotNumber = DS.Tables[0].Rows[0]["cs_lotNumber"].ToString();
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cs_quantity"]);
            }
            else
            {
                this.fkCoilCellar = cellar;
                this.fkRawMaterial = fkraw;
                this.lotNumber = lot;
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cellarstocks (cs_fkCoilCellar, cs_fkRawMaterial, cs_lotNumber, cs_quantity)";
                    queryString += " VALUES (";
                    queryString += this.fkCoilCellar.ToString() + ",";
                    queryString += this.fkRawMaterial.ToString() + ",";
                    queryString += "'" + this.lotNumber.ToString() + "',";
                    queryString += this.quantity.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_cellarstocks";
                    queryString += " SET ";
                    queryString += "cs_fkCoilCellar = " + this.fkCoilCellar.ToString() + ",";
                    queryString += "cs_fkRawMaterial = " + this.fkRawMaterial.ToString() + ",";
                    queryString += "cs_lotNumber = '" + this.lotNumber + "',";
                    queryString += "cs_quantity = " + this.quantity.ToString() + "";
                    queryString += " WHERE cs_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCellarStocks.save");
                return false;
            }
        }

        public bool alterQuantity(double q)
        {
            if(this.quantity + q < 0)
            {
                return false;
            }
            {
                this.quantity += q;
                this.save();
            }
            return true;
        }

    }
}
