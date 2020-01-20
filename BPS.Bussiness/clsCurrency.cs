using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los diferentes tipos de Monedas
    /// </summary>
    public class clsCurrency
    {
        //Atributes

        private int crr_codsec;
        private string crr_name;
        private string crr_symbol;
        private decimal crr_decimalNumber;


        //Properties

        public int codsec { get { return crr_codsec; } set { crr_codsec = value; } }

        public string name { get { return crr_name; } set { crr_name = value; } }

        public string symbol { get { return crr_symbol; } set { crr_symbol = value; } }

        public decimal decimalNumber { get { return crr_decimalNumber; } set { crr_decimalNumber = value; } }

        //Constructor

        public clsCurrency()
        { 
        crr_codsec = 0;
        crr_name = "";
        crr_symbol = "";
        crr_decimalNumber = 0;
        
        }

        public clsCurrency(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_currency where crr_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["crr_codsec"]);
            this.name = DS.Tables[0].Rows[0]["crr_name"].ToString();
            this.symbol = DS.Tables[0].Rows[0]["crr_symbol"].ToString();
            this.decimalNumber = Convert.ToDecimal(DS.Tables[0].Rows[0]["crr_decimal"]);
        }

        public bool save()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {   
                    queryString += "INSERT INTO bps_admin_currency (crr_name, crr_symbol, crr_decimal) ";
                    queryString += "VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.symbol + "',";
                    queryString += this.decimalNumber.ToString();
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_admin_currency";
                    queryString += " SET ";
                    queryString += "crr_name = '" + this.name + "',";
                    queryString += "crr_symbol = '" + this.symbol + "',";
                    queryString += "crr_decimal = " + this.decimalNumber.ToString() + "";
                    queryString += " WHERE crr_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCurrency.save");
                return false;
            }

            
        }

        public static List<clsCurrency> getList()
        {
            List<clsCurrency> lstCurrency = new List<clsCurrency>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_currency ORDER BY crr_name");

            lstCurrency.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCurrency.Add(new clsCurrency());
                lstCurrency[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["crr_codsec"]);
                lstCurrency[i].name = DS.Tables[0].Rows[i]["crr_name"].ToString();
                lstCurrency[i].symbol = DS.Tables[0].Rows[i]["crr_symbol"].ToString();
                lstCurrency[i].decimalNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["crr_decimal"]);
            }

            return lstCurrency;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
