using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsErrorByInventory
    {
        // Attributes
        private int inverr_codsec;
        private int inverr_fkinventoty;
        private String inverr_code;        
        private String inverr_description;

        // Properties
        public int codsec { get { return inverr_codsec; } set { inverr_codsec = value; } }

        public int fkinventory { get { return inverr_fkinventoty; } set { inverr_fkinventoty = value; } }

        public String code { get { return inverr_code; } set { inverr_code = value; } }

        public String description { get { return inverr_description; } set { inverr_description = value; } }


        // Constructor
        public clsErrorByInventory()
        {
            codsec = 0;
            fkinventory = 0;
            code = String.Empty;
            description = String.Empty;
        }

        public clsErrorByInventory(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_inventoryerror WHERE inverr_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["inverr_codsec"]);
                this.fkinventory = Convert.ToInt32(DS.Tables[0].Rows[0]["inverr_fkinventory"]);
                this.code = DS.Tables[0].Rows[0]["inverr_code"].ToString();
                this.description = DS.Tables[0].Rows[0]["inverr_description"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        // Methods
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_inventoryerror (inverr_fkinventory, inverr_code, inverr_description)";
                    queryString += " VALUES (";
                    queryString += this.fkinventory + ", ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "'" + this.description.ToString() + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_inventoryerror ";
                    queryString += " SET ";
                    queryString += " inverr_fkinventory = " + this.fkinventory + ",";
                    queryString += " inverr_code = '" + this.code.ToString() + "',";
                    queryString += " inverr_description = '" + this.description.ToString() + "'";
                    queryString += " WHERE inverr_codsec =  " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsInventory.save");
                return false;
            }
        }

        public static List<clsErrorByInventory> getListByInventory(int inventory)
        {
            List<clsErrorByInventory> lstErrorInventory = new List<clsErrorByInventory>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_inventoryerror WHERE inverr_fkinventory = " + inventory.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstErrorInventory.Add(new clsErrorByInventory());
                    lstErrorInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["inverr_codsec"]);
                    lstErrorInventory[i].fkinventory = Convert.ToInt32(DS.Tables[0].Rows[i]["inverr_fkinventory"]);
                    lstErrorInventory[i].code = DS.Tables[0].Rows[i]["inverr_code"].ToString();
                    lstErrorInventory[i].description = DS.Tables[0].Rows[i]["inverr_description"].ToString();
                }
            }
            return lstErrorInventory;
        }

        public static int countTotalError(int inventory)
        {
            int mynumber = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COUNT(*) AS count_error FROM bps_prod_inventoryerror WHERE inverr_fkinventory = " + inventory.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    mynumber = Convert.ToInt32(DS.Tables[0].Rows[i]["count_error"]);
            }
            return mynumber;
        }
    }
}
