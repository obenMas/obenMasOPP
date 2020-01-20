using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra el kardex de deposito M.P.
    /// </summary>
    public class clsKardex
    {
        //Atributes

        private int kdx_codsec;
        private int kdx_fkRawMaterialType;
        private string kdx_RawMaterialTypeName;
        private int kdx_fkRawMaterial;
        private string kdx_RawMaterialName;
        private string kdx_RawMaterialCode;
        private int kdx_fkCellar;
        private string kdx_CellarName;
        private string kdx_description;
        private double kdx_quantityIn;
        private double kdx_quantityOut;
        private double kdx_balance;
        private double kdx_cost;
        private DateTime kdx_date;
        private double kdx_quote;
        private int kdx_fkEntity;
        private string kdx_EntityName;



        //Properties

        public int codsec { get { return kdx_codsec; } set { kdx_codsec = value; } }

        public int fkRawMaterialType { get { return kdx_fkRawMaterialType; } set { kdx_fkRawMaterialType = value; } }

        public string RawMaterialTypeName { get { return kdx_RawMaterialTypeName; } set { kdx_RawMaterialTypeName = value; } }

        public int fkEntity { get { return kdx_fkEntity; } set { kdx_fkEntity = value; } }

        public string EntityName { get { return kdx_EntityName; } set { kdx_EntityName = value; } }

        public int fkRawMaterial { get { return kdx_fkRawMaterial; } set { kdx_fkRawMaterial = value; } }

        public string RawMaterialName { get { return kdx_RawMaterialName; } set { kdx_RawMaterialName = value; } }

        public string RawMaterialCode { get { return kdx_RawMaterialCode; } set { kdx_RawMaterialCode = value; } }

        public int fkCellar { get { return kdx_fkCellar; } set { kdx_fkCellar = value; } }

        public string CellarName { get { return kdx_CellarName; } set { kdx_CellarName = value; } }

        public string description { get { return kdx_description; } set { kdx_description = value; } }

        public double quantityIn { get { return kdx_quantityIn; } set { kdx_quantityIn = value; } }

        public double quantityOut { get { return kdx_quantityOut; } set { kdx_quantityOut = value; } }

        public double balance { get { return kdx_balance; } set { kdx_balance = value; } }

        public double cost { get { return kdx_cost; } set { kdx_cost = value; } }

        public DateTime date { get { return kdx_date; } set { kdx_date = value; } }

        public double quote { get { return kdx_quote; } set { kdx_quote = value; } }


         //Constructor

        public clsKardex()
        { 
        kdx_codsec = 0;
        kdx_fkRawMaterialType = 0;
        kdx_RawMaterialTypeName = "";
        kdx_fkEntity = 0;
        kdx_EntityName = "";
        kdx_fkRawMaterial = 0;
        kdx_RawMaterialName = "";
        kdx_RawMaterialCode = "";
        kdx_fkCellar = 0;
        kdx_CellarName = "";
        kdx_description = "";
        kdx_quantityIn = 0;
        kdx_quantityOut = 0;
        kdx_balance = 0;
        kdx_cost = 0;
        kdx_date = DateTime.Now;
        kdx_quote = 0;
        }

        public clsKardex(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwKardex where kdx_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["kdx_codsec"]);
            this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["kdx_fkRawMaterialType"]);
            this.RawMaterialTypeName = DS.Tables[0].Rows[0]["kdx_RawMaterialTypeName"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["kdx_fkEntity"]);
            this.EntityName = DS.Tables[0].Rows[0]["kdx_EntityName"].ToString();
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["kdx_fkRawMaterial"]);
            this.RawMaterialName = DS.Tables[0].Rows[0]["kdx_RawMaterialName"].ToString();
            this.RawMaterialCode = DS.Tables[0].Rows[0]["kdx_RawMaterialCode"].ToString();
            this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["kdx_fkCellar"]);
            this.CellarName = DS.Tables[0].Rows[0]["kdx_CellarName"].ToString();
            this.description = DS.Tables[0].Rows[0]["kdx_description"].ToString();
            this.quantityIn = Convert.ToDouble(DS.Tables[0].Rows[0]["kdx_quantityIn"]);
            this.quantityOut = Convert.ToDouble(DS.Tables[0].Rows[0]["kdx_quantityOut"]);
            this.balance = Convert.ToDouble(DS.Tables[0].Rows[0]["kdx_balance"]);
            this.cost = Convert.ToDouble(DS.Tables[0].Rows[0]["kdx_cost"]);
            this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["kdx_date"]);
            this.quote = Convert.ToDouble(DS.Tables[0].Rows[0]["kdx_quote"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_kardex (kdx_fkRawMaterial,kdx_fkCellar, kdx_description, kdx_quantityIn, kdx_quantityOut,kdx_balance,kdx_cost,kdx_quote, kdx_date)";
                    queryString += " VALUES (";
                    queryString += this.fkRawMaterial.ToString() + ",";
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
                    queryString += "UPDATE bps_prod_kardex";
                    queryString += " SET ";
                    queryString += "kdx_fkRawMaterial = " + this.fkRawMaterial.ToString() + ",";
                    queryString += "kdx_fkCellar = " + this.fkCellar.ToString() + ",";
                    queryString += "kdx_description = '" + this.description + "',";
                    queryString += "kdx_quantityIn = " + this.quantityIn.ToString() + ",";
                    queryString += "kdx_quantityOut = " + this.quantityOut.ToString() + ",";
                    queryString += "kdx_balance = " + this.balance.ToString() + ",";
                    queryString += "kdx_cost = " + this.cost.ToString() + ",";
                    queryString += "kdx_quote = " + this.quote.ToString() + "";
                    queryString += " WHERE kdx_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsKardex.save");
                return false;
            }
        }

        public static List<clsKardex> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsKardex> lstKardex = new List<clsKardex>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwkardex " + where + " group by kdx_codsec order by kdx_date DESC");

            lstKardex.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstKardex.Add(new clsKardex());
                lstKardex[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_codsec"]);
                lstKardex[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkRawMaterialType"]);
                lstKardex[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["kdx_RawMaterialTypeName"].ToString();
                lstKardex[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkEntity"]);
                lstKardex[i].EntityName = DS.Tables[0].Rows[i]["kdx_EntityName"].ToString();
                lstKardex[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkRawMaterial"]);
                lstKardex[i].RawMaterialName = DS.Tables[0].Rows[i]["kdx_RawMaterialName"].ToString();
                lstKardex[i].RawMaterialCode = DS.Tables[0].Rows[i]["kdx_RawMaterialCode"].ToString();
                lstKardex[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkCellar"]);
                lstKardex[i].CellarName = DS.Tables[0].Rows[i]["kdx_CellarName"].ToString();
                lstKardex[i].description = DS.Tables[0].Rows[i]["kdx_description"].ToString();
                lstKardex[i].quantityIn = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quantityIn"]);
                lstKardex[i].quantityOut = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quantityOut"]);
                lstKardex[i].balance = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_balance"]);
                lstKardex[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_cost"]);
                lstKardex[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["kdx_date"]);
                lstKardex[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quote"]);

            }
            return lstKardex;
        }


        public static List<clsKardex> getList()
        {
            List<clsKardex> lstKardex = new List<clsKardex>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwKardex");

            lstKardex.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstKardex.Add(new clsKardex());
                lstKardex[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_codsec"]);
                lstKardex[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkRawMaterialType"]);
                lstKardex[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["kdx_RawMaterialTypeName"].ToString();
                lstKardex[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkEntity"]);
                lstKardex[i].EntityName = DS.Tables[0].Rows[i]["kdx_EntityName"].ToString();
                lstKardex[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkRawMaterial"]);
                lstKardex[i].RawMaterialName = DS.Tables[0].Rows[i]["kdx_RawMaterialName"].ToString();
                lstKardex[i].RawMaterialCode = DS.Tables[0].Rows[i]["kdx_RawMaterialCode"].ToString();
                lstKardex[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["kdx_fkCellar"]);
                lstKardex[i].CellarName = DS.Tables[0].Rows[i]["kdx_CellarName"].ToString();
                lstKardex[i].description = DS.Tables[0].Rows[i]["kdx_description"].ToString();
                lstKardex[i].quantityIn = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quantityIn"]);
                lstKardex[i].quantityOut = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quantityOut"]);
                lstKardex[i].balance = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_balance"]);
                lstKardex[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_cost"]);
                lstKardex[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["kdx_date"]);
                lstKardex[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["kdx_quote"]);

            }
            return lstKardex;
        }


        


    }
}
