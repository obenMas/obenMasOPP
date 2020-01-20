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
    public class clsMaquileProduct
    {
        //Atributes

        private int maq_codsec;
        private string maq_name;
        private string maq_abbreviation;
        private string maq_description;



        //Properties

        public int codsec { get { return maq_codsec; } set { maq_codsec = value; } }

        public string name { get { return maq_name; } set { maq_name = value; } }

        public string abbreviation { get { return maq_abbreviation; } set { maq_abbreviation = value; } }

        public string description { get { return maq_description; } set { maq_description = value; } }

        //Constructor

        public clsMaquileProduct()
        {
            maq_codsec = 0;
            maq_name = "";
            maq_abbreviation = "";
            maq_description = "";
        }

        public clsMaquileProduct(int codsec)
        {
            this.load(codsec);
        }


        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquileproduct WHERE maq_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
            this.name = DS.Tables[0].Rows[0]["maq_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["maq_abbreviation"].ToString();
        }


        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maquileproduct (maq_name, maq_abbreviation)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "' ";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_maquileproduct";
                    queryString += " SET ";
                    queryString += "maq_name = '" + this.name + "',";
                    queryString += "maq_abbreviation = '" + this.abbreviation + "'";
                    queryString += " WHERE maq_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsIncoterms.save");
                return false;
            }
        }


        public static List<clsMaquileProduct> getList()
        {
            List<clsMaquileProduct> lstIncoterms = new List<clsMaquileProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquileproduct ORDER BY maq_name ASC");

            lstIncoterms.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstIncoterms.Add(new clsMaquileProduct());
                lstIncoterms[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                lstIncoterms[i].name = DS.Tables[0].Rows[i]["maq_name"].ToString();
                lstIncoterms[i].abbreviation = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
            }

            return lstIncoterms;
        }

        public static List<clsMaquileProduct> getListByAbbrebiation(string code)
        {
            List<clsMaquileProduct> lstIncoterms = new List<clsMaquileProduct>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquileproduct WHERE maq_abbreviation = '" + code + "'ORDER BY maq_name ASC");

            lstIncoterms.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstIncoterms.Add(new clsMaquileProduct());
                lstIncoterms[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                lstIncoterms[i].name = DS.Tables[0].Rows[i]["maq_name"].ToString();
                lstIncoterms[i].abbreviation = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
            }

            return lstIncoterms;
        }

        public override string ToString()
        {
            return this.abbreviation;
        }
    }
}
