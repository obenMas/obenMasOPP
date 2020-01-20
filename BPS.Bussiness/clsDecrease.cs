using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Tipos de mermas
    /// </summary>
    public class clsDecrease
    {
        //Atributes

        private int dcr_codsec;
        private string dcr_name;
        private string dcr_description;
        private bool dcr_isForMainCoil;
        
        //Properties


        public int codsec { get { return dcr_codsec; } set { dcr_codsec = value; } }

        public string name { get { return dcr_name; } set { dcr_name = value; } }

        public string description { get { return dcr_description; } set { dcr_description = value; } }

        public bool isForMainCoil { get { return dcr_isForMainCoil; } set { dcr_isForMainCoil = value; } }

        //Constructor

        public clsDecrease()
        {
            dcr_codsec = 0;
            dcr_name = "";
            dcr_description = "";
        }

        public clsDecrease(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_decrease  where dcr_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["dcr_codsec"]);
            this.name = DS.Tables[0].Rows[0]["dcr_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["dcr_description"].ToString();
            this.isForMainCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["dcr_isForMainCoil"], DS.Tables[0].Rows[0]["dcr_isForMainCoil"].GetType().FullName);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_decrease (dcr_name, dcr_description, dcr_isForMainCoil)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += "'" + this.isForMainCoil.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_decrease";
                    queryString += " SET ";
                    queryString += "dcr_name = '" + this.name + "',";
                    queryString += "dcr_description = '" + this.description + "'";
                    queryString += "dcr_isForMainCoil = '" + this.isForMainCoil.ToString() + "'";
                    queryString += " WHERE dcr_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDecrease.save");
                return false;
            }


        }

        public static List<clsDecrease> getList()
        {
            List<clsDecrease> lstDecrease = new List<clsDecrease>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_decrease order by dcr_name asc");

            lstDecrease.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstDecrease.Add(new clsDecrease());
                lstDecrease[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dcr_codsec"]);
                lstDecrease[i].name = DS.Tables[0].Rows[i]["dcr_name"].ToString();
                lstDecrease[i].description = DS.Tables[0].Rows[i]["dcr_description"].ToString();
                lstDecrease[i].isForMainCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["dcr_isForMainCoil"], DS.Tables[0].Rows[i]["dcr_isForMainCoil"].GetType().FullName);
            }

            return lstDecrease;
        }
        public static List<clsDecrease> getListForMainCoil()
        {
            List<clsDecrease> lstDecrease = new List<clsDecrease>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_decrease where dcr_isForMainCoil = 1 order by dcr_name asc");

            lstDecrease.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstDecrease.Add(new clsDecrease());
                lstDecrease[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dcr_codsec"]);
                lstDecrease[i].name = DS.Tables[0].Rows[i]["dcr_name"].ToString();
                lstDecrease[i].description = DS.Tables[0].Rows[i]["dcr_description"].ToString();
                lstDecrease[i].isForMainCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["dcr_isForMainCoil"], DS.Tables[0].Rows[i]["dcr_isForMainCoil"].GetType().FullName);
            }

            return lstDecrease;
        }
        public static List<clsDecrease> getListForFilmProductionPlan()
        {
            List<clsDecrease> lstDecrease = new List<clsDecrease>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_decrease where dcr_isForMainCoil = 0 order by dcr_name asc");

            lstDecrease.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstDecrease.Add(new clsDecrease());
                lstDecrease[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dcr_codsec"]);
                lstDecrease[i].name = DS.Tables[0].Rows[i]["dcr_name"].ToString();
                lstDecrease[i].description = DS.Tables[0].Rows[i]["dcr_description"].ToString();
                lstDecrease[i].isForMainCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["dcr_isForMainCoil"], DS.Tables[0].Rows[i]["dcr_isForMainCoil"].GetType().FullName);
            }

            return lstDecrease;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
