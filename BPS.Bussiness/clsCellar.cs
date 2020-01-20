using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los depositos
    /// </summary>
    public class clsCellar
    {
        //Atributes

        private int clr_codsec;
        private string clr_name;
        private string clr_description;



        //Properties

        public int codsec { get { return clr_codsec; } set { clr_codsec = value; } }

        public string name { get { return clr_name; } set { clr_name = value; } }

        public string description { get { return clr_description; } set { clr_description = value; } }

        //Constructor

        public clsCellar()
        {
            clr_codsec = 0;
            clr_name = "";
            clr_description = "";
        }

        public clsCellar(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_cellar where clr_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["clr_codsec"]);
            this.name = DS.Tables[0].Rows[0]["clr_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["clr_description"].ToString();

        }


        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_cellar (clr_name,clr_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_cellar";
                    queryString += " SET ";
                    queryString += "clr_name = '" + this.name + "',";
                    queryString += "clr_description = '" + this.description + "'";
                    queryString += " WHERE clr_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCellar.save");
                return false;
            }
        }


        public static List<clsCellar> getList()
        {
            List<clsCellar> lstCellar = new List<clsCellar>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_cellar order by clr_name asc");

            lstCellar.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCellar.Add(new clsCellar());
                lstCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["clr_codsec"]);
                lstCellar[i].name = DS.Tables[0].Rows[i]["clr_name"].ToString();
                lstCellar[i].description = DS.Tables[0].Rows[i]["clr_description"].ToString();

            }

            return lstCellar;
        }


        public static List<clsCellar> getRawMaterialList()
        {
            List<clsCellar> lstRawMaterialCellar = new List<clsCellar>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_cellar where clr_rawmaterial = 1  order by clr_name asc");

            lstRawMaterialCellar.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialCellar.Add(new clsCellar());
                lstRawMaterialCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["clr_codsec"]);
                lstRawMaterialCellar[i].name = DS.Tables[0].Rows[i]["clr_name"].ToString();
                lstRawMaterialCellar[i].description = DS.Tables[0].Rows[i]["clr_description"].ToString();

            }

            return lstRawMaterialCellar;
        }

        public static List<clsCellar> getSupplyList()
        {
            List<clsCellar> lstSupplyCellar = new List<clsCellar>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_cellar where clr_supply = 1  order by clr_name asc");

            lstSupplyCellar.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyCellar.Add(new clsCellar());
                lstSupplyCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["clr_codsec"]);
                lstSupplyCellar[i].name = DS.Tables[0].Rows[i]["clr_name"].ToString();
                lstSupplyCellar[i].description = DS.Tables[0].Rows[i]["clr_description"].ToString();

            }

            return lstSupplyCellar;
        }




        public int getCellarCodsec()
        {
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT clr_codsec  FROM bps_admin_cellar where clr_name = 'Bodega Materia Prima' order by clr_codsec desc Limit 1");

            if (DS.Tables[0].Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DS.Tables[0].Rows[0]["clr_codsec"].ToString());
        }

        public int getCellarProductionCodsecByMachine(int mach)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT clr_codsec FROM `bps_admin_cellar` cll, `bps_prod_cellarbymachine` cllbymch WHERE cll.`clr_codsec` = cllbymch.`cllmch_fkCellar` and cll.`clr_production` = 1 and cllbymch.`cllmch_fkMachine` =" + mach.ToString());

            if (DS.Tables[0].Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DS.Tables[0].Rows[0]["clr_codsec"].ToString());
        }

        public int getSupplyCellarCodsec()
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT clr_codsec  FROM bps_admin_cellar where clr_name = 'Bodega Suministros' order by clr_codsec desc Limit 1");

            if (DS.Tables[0].Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DS.Tables[0].Rows[0]["clr_codsec"].ToString());
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
