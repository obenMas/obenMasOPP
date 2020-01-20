using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
    public class clsCuttingDefinition
    {
        //Atributes

        private int cuttdef_codsec;
        private string cuttdef_film;
        private double cuttdef_quantity;
        private double cuttdef_margin;
        private DateTime cuttdef_estimatedstart;
        private string cuttdef_status;
        private int cuttdef_fkPlant;

        //Properties

        public int codsec { get { return cuttdef_codsec; } set { cuttdef_codsec = value; } }

        public string film { get { return cuttdef_film; } set { cuttdef_film = value; } }

        public double quantity { get { return cuttdef_quantity; } set { cuttdef_quantity = value; } }

        public double margin { get { return cuttdef_margin; } set { cuttdef_margin = value; } }

        public DateTime date { get { return cuttdef_estimatedstart; } set { cuttdef_estimatedstart = value; } }

        public string status { get { return cuttdef_status; } set { cuttdef_status = value; } }

        public int fkPlant { get { return cuttdef_fkPlant; } set { cuttdef_fkPlant = value; } }

        //Constructor

        public clsCuttingDefinition()
        {
            cuttdef_codsec = 0;
            cuttdef_film = string.Empty;
            cuttdef_quantity = 0;
            cuttdef_margin = 0;
            cuttdef_estimatedstart = DateTime.Now;
            cuttdef_status = string.Empty;
            cuttdef_fkPlant = 0;

        }

        public clsCuttingDefinition(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingdefinition WHERE cuttdef_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdef_codsec"]);
                this.film = DS.Tables[0].Rows[0]["cuttdef_film"].ToString();
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdef_quantity"]);
                this.margin = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdef_margin"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cuttdef_estimatedstart"]);
                this.status = DS.Tables[0].Rows[0]["cuttdef_status"].ToString();
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdef_fkPlant"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingdefinition (cuttdef_film, cuttdef_quantity, cuttdef_margin, cuttdef_estimatedstart, cuttdef_status, cuttdef_fkPlant)";
                    queryString += " VALUES ( ";
                    queryString += "'" + this.film + "', ";
                    queryString += this.quantity + ", ";
                    queryString += this.margin + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.status + "', ";
                    queryString += this.fkPlant;
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingdefinition";
                    queryString += " SET ";
                    queryString += "cuttdef_film = '" + this.film + "', ";
                    queryString += "cuttdef_quantity = " + this.quantity + ", ";
                    queryString += "cuttdef_margin = " + this.margin + ", ";
                    queryString += "cuttdef_estimatedstart = '" + this.date.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "cuttdef_status = '" + this.status + "', ";
                    queryString += "cuttdef_fkPlant = " + this.fkPlant;
                    queryString += " WHERE cuttdef_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingDefinition.save");
                return false;
            }
        }

        public static List<clsCuttingDefinition> getList()
        {
            List<clsCuttingDefinition> lstCuttingDefinition = new List<clsCuttingDefinition>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingdefinition order by cuttdef_codsec asc");

            lstCuttingDefinition.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCuttingDefinition.Add(new clsCuttingDefinition());
                lstCuttingDefinition[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdef_codsec"]);
                lstCuttingDefinition[i].film = DS.Tables[0].Rows[0]["cuttdef_film"].ToString();
                lstCuttingDefinition[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdef_quantity"]);
                lstCuttingDefinition[i].margin = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdef_margin"]);
                lstCuttingDefinition[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cuttdef_estimatedstart"]);
                lstCuttingDefinition[i].status = (DS.Tables[0].Rows[0]["cuttdef_status"]).ToString();
                lstCuttingDefinition[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdef_fkPlant"]);
            }

            return lstCuttingDefinition;

        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT MAX(cuttdef_codsec) AS cuttdef_codsec FROM bps_prod_cuttingdefinition");

            if(DS.Tables.Count >0 && DS.Tables[0].Rows.Count>0)
            {
                return Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdef_codsec"]);
            }
            else
            {
                return 0;
            }
        }

    }
}
