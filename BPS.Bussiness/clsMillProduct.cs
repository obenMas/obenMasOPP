using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los incoterms para despachos de pt
    /// </summary>
    public class clsMillProduct
    {
        //Atributes

        private int mill_codsec;
        private string mill_name;
        private string mill_code;
        private bool mill_isvisible;

        //Properties

        public int codsec { get { return mill_codsec; } set { mill_codsec = value; } }

        public string name { get { return mill_name; } set { mill_name = value; } }

        public string code { get { return mill_code; } set { mill_code = value; } }

        public bool isVisible { get { return mill_isvisible; } set { mill_isvisible = value; } }

        //Constructor

        public clsMillProduct()
        {
            mill_codsec = 0;
            mill_name = "";
            mill_code = "";
            mill_isvisible = true;
        }

        public clsMillProduct(int codsec)
        {
            this.load(codsec);
        }

        public clsMillProduct(string name)
        {
            this.load(name);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millproduct WHERE mill_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
            this.name = DS.Tables[0].Rows[0]["mill_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["mill_code"].ToString();
            this.isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mill_isVisible"], DS.Tables[0].Rows[0]["mill_isVisible"].GetType().FullName);
        }

        public void load(string name)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millproduct WHERE mill_name = '" + name + "'");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
            this.name = DS.Tables[0].Rows[0]["mill_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["mill_code"].ToString();
            this.isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mill_isVisible"], DS.Tables[0].Rows[0]["mill_isVisible"].GetType().FullName);
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_millproduct (mill_name, mill_code)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_millproduct";
                    queryString += " SET ";
                    queryString += "mill_name = '" + this.name + "',";
                    queryString += "mill_code = '" + this.code + "'";
                    queryString += " WHERE mill_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillProduct.save");
                return false;
            }
        }


        public static List<clsMillProduct> getList()
        {
            List<clsMillProduct> lstMilProduct = new List<clsMillProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millproduct WHERE mill_isVisible = 1 ORDER BY mill_codsec ASC");

            lstMilProduct.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMilProduct.Add(new clsMillProduct());
                lstMilProduct[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                lstMilProduct[i].name = DS.Tables[0].Rows[i]["mill_name"].ToString();
                lstMilProduct[i].code= DS.Tables[0].Rows[i]["mill_code"].ToString();
                lstMilProduct[i].isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mill_isVisible"], DS.Tables[0].Rows[0]["mill_isVisible"].GetType().FullName);
            }

            return lstMilProduct;
        }

        public static string getExternalCode(clsMillProduct objProduct)
        {
            if (objProduct.codsec > 0)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT TOP (1) * FROM bps_xtr_filmequivalencemill WHERE feq_fkMillProduct = " + objProduct.codsec.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                else
                    return "";
            }
            else
                return "";
        }

        public static string getExternalCode(string ProductName)
        {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT TOP (1) * FROM bps_prod_millproduct WHERE mill_name = '" + ProductName + "'");

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["mill_code"].ToString();
                else
                    return "";
        }
        
        public override string ToString()
        {
            return this.name + " [" + this.code + "] ";
        }
    }
}
