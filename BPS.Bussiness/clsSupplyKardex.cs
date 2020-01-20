using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    // <summary>
    /// Clase que administra el kardex de deposito Suministros
    /// </summary>
    public class clsSupplyKardex
    {

        //Atributes

        private int spykdx_codsec;
        private int spykdx_fkSupply;
        private string spykdx_SupplyName;
        private string spykdx_SupplyCode;
        private int spykdx_fkCellar;
        private string spykdx_CellarName;
        private string spykdx_description;
        private double spykdx_quantityIn;
        private double spykdx_quantityOut;
        private double spykdx_balance;
        private double spykdx_cost;
        private DateTime spykdx_date;
        private double spykdx_quote;
        private int spykdx_fkEntity;
        private string spykdx_EntityName;

        //Properties

        public int codsec { get { return spykdx_codsec; } set { spykdx_codsec = value; } }

        public int fkEntity { get { return spykdx_fkEntity; } set { spykdx_fkEntity = value; } }

        public string EntityName { get { return spykdx_EntityName; } set { spykdx_EntityName = value; } }

        public int fkSupply { get { return spykdx_fkSupply; } set { spykdx_fkSupply = value; } }

        public string SupplyName { get { return spykdx_SupplyName; } set { spykdx_SupplyName = value; } }

        public string SupplyCode { get { return spykdx_SupplyCode; } set { spykdx_SupplyCode = value; } }

        public int fkCellar { get { return spykdx_fkCellar; } set { spykdx_fkCellar = value; } }

        public string CellarName { get { return spykdx_CellarName; } set { spykdx_CellarName = value; } }

        public string description { get { return spykdx_description; } set { spykdx_description = value; } }

        public double quantityIn { get { return spykdx_quantityIn; } set { spykdx_quantityIn = value; } }

        public double quantityOut { get { return spykdx_quantityOut; } set { spykdx_quantityOut = value; } }

        public double balance { get { return spykdx_balance; } set { spykdx_balance = value; } }

        public double cost { get { return spykdx_cost; } set { spykdx_cost = value; } }

        public DateTime date { get { return spykdx_date; } set { spykdx_date = value; } }

        public double quote { get { return spykdx_quote; } set { spykdx_quote = value; } }

         //Constructor

        public clsSupplyKardex()
        { 
        spykdx_codsec = 0;
        spykdx_fkEntity = 0;
        spykdx_EntityName = "";
        spykdx_fkSupply = 0;
        spykdx_SupplyName = "";
        spykdx_SupplyCode = "";
        spykdx_fkCellar = 0;
        spykdx_CellarName = "";
        spykdx_description = "";
        spykdx_quantityIn = 0;
        spykdx_quantityOut = 0;
        spykdx_balance = 0;
        spykdx_cost = 0;
        spykdx_date = DateTime.Now;
        spykdx_quote = 0;
        }

        public clsSupplyKardex(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSypplyKardex where spykdx_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spykdx_codsec"]);
            this.fkSupply = Convert.ToInt32(DS.Tables[0].Rows[0]["spykdx_fkSupply"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["spykdx_fkEntity"]);
            this.EntityName = DS.Tables[0].Rows[0]["spykdx_EntityName"].ToString();
            this.SupplyName = DS.Tables[0].Rows[0]["spykdx_SupplyName"].ToString();
            this.SupplyCode = DS.Tables[0].Rows[0]["spykdx_SupplyCode"].ToString();
            this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["spykdx_fkCellar"]);
            this.CellarName = DS.Tables[0].Rows[0]["spykdx_CellarName"].ToString();
            this.description = DS.Tables[0].Rows[0]["spykdx_description"].ToString();
            this.quantityIn = Convert.ToDouble(DS.Tables[0].Rows[0]["spykdx_quantityIn"]);
            this.quantityOut = Convert.ToDouble(DS.Tables[0].Rows[0]["spykdx_quantityOut"]);
            this.balance = Convert.ToDouble(DS.Tables[0].Rows[0]["spykdx_balance"]);
            this.cost = Convert.ToDouble(DS.Tables[0].Rows[0]["spykdx_cost"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["spykdx_date"]);
            this.quote = Convert.ToDouble(DS.Tables[0].Rows[0]["spykdx_quote"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supplykardex (spykdx_fkSupply,spykdx_fkCellar,spykdx_description,spykdx_quantityIn,spykdx_quantityOut,spykdx_balance,spykdx_cost,spykdx_quote,spykdx_date)";
                    queryString += " VALUES (";
                    queryString += this.fkSupply.ToString() + ",";
                    queryString += this.fkCellar.ToString() + ",";
                    queryString += "'" + this.description + "',";
                    queryString += this.quantityIn.ToString() + ",";
                    queryString += this.quantityOut.ToString() + ",";
                    queryString += this.balance.ToString() + ",";
                    queryString += this.cost.ToString() + ",";
                    queryString += this.quote.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_supplykardex";
                    queryString += " SET ";
                    queryString += "spykdx_fkSupply = " + this.fkSupply.ToString() + ",";
                    queryString += "spykdx_fkCellar = " + this.fkCellar.ToString() + ",";
                    queryString += "spykdx_description = '" + this.description + "',";
                    queryString += "spykdx_quantityIn = " + this.quantityIn.ToString() + ",";
                    queryString += "spykdx_quantityOut = " + this.quantityOut.ToString() + ",";
                    queryString += "spykdx_balance = " + this.balance.ToString() + ",";
                    queryString += "spykdx_cost = " + this.cost.ToString() + ",";
                    queryString += "spykdx_quote = " + this.quote.ToString() + "";
                    queryString += "spykdx_codsec = " + this.quote.ToString() + "";
                    queryString += " WHERE spykdx_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplyKardex.save");
                return false;
            }
        }

        public static List<clsSupplyKardex> getList()
        {
            List<clsSupplyKardex> lstSupplyKardex = new List<clsSupplyKardex>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSypplyKardex");

            lstSupplyKardex.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {

                lstSupplyKardex.Add(new clsSupplyKardex());
                lstSupplyKardex[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spykdx_codsec"]);
                lstSupplyKardex[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["spykdx_fkEntity"]);
                lstSupplyKardex[i].EntityName = DS.Tables[0].Rows[i]["spykdx_EntityName"].ToString();
                lstSupplyKardex[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["spykdx_fkSupply"]);
                lstSupplyKardex[i].SupplyName = DS.Tables[0].Rows[i]["spykdx_SupplyName"].ToString();
                lstSupplyKardex[i].SupplyCode = DS.Tables[0].Rows[i]["spykdx_SupplyCode"].ToString();
                lstSupplyKardex[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["spykdx_fkCellar"]);
                lstSupplyKardex[i].CellarName = DS.Tables[0].Rows[i]["spykdx_CellarName"].ToString();
                lstSupplyKardex[i].description = DS.Tables[0].Rows[i]["spykdx_description"].ToString();
                lstSupplyKardex[i].quantityIn = Convert.ToDouble(DS.Tables[0].Rows[i]["spykdx_quantityIn"]);
                lstSupplyKardex[i].quantityOut = Convert.ToDouble(DS.Tables[0].Rows[i]["spykdx_quantityOut"]);
                lstSupplyKardex[i].balance = Convert.ToDouble(DS.Tables[0].Rows[i]["spykdx_balance"]);
                lstSupplyKardex[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["spykdx_cost"]);
                lstSupplyKardex[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["spykdx_date"]);
                lstSupplyKardex[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["spykdx_quote"]);

            }
            return lstSupplyKardex;
        }

    }
}
