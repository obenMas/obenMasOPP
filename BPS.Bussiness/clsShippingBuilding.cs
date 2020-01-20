using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsShippingBuilding
    {
        //Atributes
        private int shipbui_codsec;
        private int shipbui_fkcountry;
        private string shipbui_country;
        private string shipbui_name;
        private string shipbui_description;


        //Properties
        public int codsec { get { return shipbui_codsec; } set { shipbui_codsec = value; } }

        public string name { get { return shipbui_name; } set { shipbui_name = value; } }

        public string description { get { return shipbui_description; } set { shipbui_description = value; } }

        public int fkcountry { get { return shipbui_fkcountry; } set { shipbui_fkcountry = value; } }

        public string country { get { return shipbui_country; } set { shipbui_country = value; } }

        
        //Constructor
        public clsShippingBuilding()
        { 
            shipbui_codsec = 0;
            shipbui_name = "";
            shipbui_description = "";
            shipbui_fkcountry = 0;
            shipbui_country = "";
        }

        public clsShippingBuilding(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwshippingbuilding where shipbui_codsec = " + codsec.ToString());
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["shipbui_codsec"]);
            this.name = DS.Tables[0].Rows[0]["shipbui_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["shipbui_description"].ToString();
            this.fkcountry = Convert.ToInt32(DS.Tables[0].Rows[0]["shipbui_fkcountry"]);
            this.country = DS.Tables[0].Rows[0]["shipbui_country"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_shippingbuilding (shipbui_fkcountry, shipbui_name, shipbui_description)";
                    queryString += " VALUES ( ";
                    queryString += this.fkcountry.ToString() + " , ";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_shippingbuilding";
                    queryString += " SET ";
                    queryString += " shipbui_fkcountry = " + this.fkcountry.ToString() + " ,";
                    queryString += "shipbui_name = '" + this.name + "',";
                    queryString += "shipbui_description = '" + this.description + "'";
                    queryString += " WHERE shipbui_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsShippingBuilding.save");
                return false;
            }
        }

        public static bool delete(int codsec)
        {
            try
            {
                clsConnection.executeQuery("DELETE FROM bps_prod_shippingbuilding WHERE shipbui_codsec = " + codsec.ToString());
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsShippingBuilding.save");
                return false;
            }
        }

        public static List<clsShippingBuilding> getList()
        {
            List<clsShippingBuilding> lstshippingbuilding = new List<clsShippingBuilding>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spShppingBuilding();");
            lstshippingbuilding.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstshippingbuilding.Add(new clsShippingBuilding());
                lstshippingbuilding[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["shipbui_codsec"]);
                lstshippingbuilding[i].fkcountry = Convert.ToInt32(DS.Tables[0].Rows[i]["shipbui_fkcountry"]);
                lstshippingbuilding[i].country = DS.Tables[0].Rows[i]["shipbui_country"].ToString();
                lstshippingbuilding[i].name = DS.Tables[0].Rows[i]["shipbui_name"].ToString();
                lstshippingbuilding[i].description = DS.Tables[0].Rows[i]["shipbui_description"].ToString();
            }
            return lstshippingbuilding;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
