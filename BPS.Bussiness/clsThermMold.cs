using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los moldes de termoformado
    /// </summary>
    public class clsThermMold
    {
        //Atributes

        private int mold_codsec;
        private int mold_fkProduct;
        private string mold_productName;
        private string mold_productCode;
        private string mold_name;
        private string mold_description;
        private int mold_cavitiesNumber;

        //Properties

        public int codsec { get { return mold_codsec; } set { mold_codsec = value; } }

        public int fkProduct { get { return mold_fkProduct; } set { mold_fkProduct = value; } }

        public string productName { get { return mold_productName; } set { mold_productName = value; } }

        public string productCode { get { return mold_productCode; } set { mold_productCode = value; } }

        public string name { get { return mold_name; } set { mold_name = value; } }

        public string description { get { return mold_description; } set { mold_description = value; } }

        public int cavitiesNumber { get { return mold_cavitiesNumber; } set { mold_cavitiesNumber = value; } }

        //Constructor

        public clsThermMold()
        {
            mold_codsec = 0;
            mold_fkProduct = 0;
            mold_productName = "";
            mold_productCode = "";
            mold_name = "";
            mold_description = "";
            mold_cavitiesNumber = 0;
        }

        public clsThermMold(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("select mold.mold_codsec as mold_codsec, prod.prod_codsec as mold_fkProduct, prod.prod_name as mold_productName, prod.prod_code as mold_productCode, mold.mold_name as mold_name, mold.mold_description as mold_description, mold.mold_cavitiesNumber as mold_cavitiesNumber from bps_prod_mold mold, bps_prod_product prod where mold.mold_fkProduct = prod.prod_codsec and mold.mold_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mold_codsec"]);
            this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["mold_fkProduct"]);
            this.productName = DS.Tables[0].Rows[0]["mold_productName"].ToString();
            this.productCode = DS.Tables[0].Rows[0]["mold_productCode"].ToString();
            this.name = DS.Tables[0].Rows[0]["mold_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["mold_description"].ToString();
            this.cavitiesNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["mold_cavitiesNumber"]);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_mold (mold_fkProduct, mold_name, mold_description, mold_cavitiesNumber)";
                    queryString += " VALUES (";
                    queryString += this.fkProduct + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += "'" + this.cavitiesNumber.ToString() + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_mold";
                    queryString += " SET ";
                    queryString += "mold_fkProduct = " + this.fkProduct + ",";
                    queryString += "mold_name = '" + this.name + "',";
                    queryString += "mold_description = '" + this.description + "',";
                    queryString += "mold_cavitiesNumber = '" + this.cavitiesNumber.ToString() + "'";
                    queryString += " WHERE mold_codsec = " + this.codsec + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermMold.save");
                return false;
            }
        }


        public static List<clsThermMold> getList()
        {
            List<clsThermMold> lstThermMold = new List<clsThermMold>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select mold.mold_codsec as mold_codsec, prod.prod_codsec as mold_fkProduct, prod.prod_name as mold_productName, prod.prod_code as mold_productCode, mold.mold_name as mold_name, mold.mold_description as mold_description, mold.mold_cavitiesNumber as mold_cavitiesNumber from bps_prod_mold mold, bps_prod_product prod where mold.mold_fkProduct = prod.prod_codsec");

            lstThermMold.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThermMold.Add(new clsThermMold());
                lstThermMold[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mold_codsec"]);
                lstThermMold[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mold_fkProduct"]);
                lstThermMold[i].productName = DS.Tables[0].Rows[i]["mold_productName"].ToString();
                lstThermMold[i].productCode = DS.Tables[0].Rows[i]["mold_productCode"].ToString();
                lstThermMold[i].name = DS.Tables[0].Rows[i]["mold_name"].ToString();
                lstThermMold[i].description = DS.Tables[0].Rows[i]["mold_description"].ToString();
                lstThermMold[i].cavitiesNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["mold_cavitiesNumber"]);
            }

            return lstThermMold;
        }


    }
}
