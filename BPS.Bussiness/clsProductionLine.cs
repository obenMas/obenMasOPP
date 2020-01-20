using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja las lineas por planta
    /// </summary>
    public class clsProductionLine
    {
        //Atributes

        private int pdl_codsec;
        private int pdl_fkPlant;
        private string pdl_PlantName;
        private string pdl_name;
        private string pdl_description;
        private int pdl_numberLine;

        //Properties

        public int codsec { get { return pdl_codsec; } set { pdl_codsec = value; } }

        public int fkPlant { get { return pdl_fkPlant; } set { pdl_fkPlant = value; } }

        public string PlantName { get { return pdl_PlantName; } set { pdl_PlantName = value; } }

        public string name { get { return pdl_name; } set { pdl_name = value; } }

        public string description { get { return pdl_description; } set { pdl_description = value; } }

        public int numberLine { get { return pdl_numberLine; } set { pdl_numberLine = value; } }


        //Constructor

        public clsProductionLine()
        {
            pdl_codsec = 0;
            pdl_fkPlant = 0;
            pdl_PlantName = "";
            pdl_name = "";
            pdl_description = "";            
            pdl_numberLine = 0;
     
        }

        public clsProductionLine(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwlineproductionbyplant where pdl_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pdl_codsec"]);
            this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["pdl_fkPlant"]);
            this.PlantName = DS.Tables[0].Rows[0]["pdl_PlantName"].ToString();
            this.name = DS.Tables[0].Rows[0]["pdl_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["pdl_description"].ToString();
            this.numberLine = Convert.ToInt32(DS.Tables[0].Rows[0]["pdl_numberLine"]);        
            

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_productionline (pdl_fkPlant,pdl_name, pdl_description, pdl_numberLine)";
                    queryString += " VALUES (";
                    queryString += this.fkPlant.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += this.numberLine.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_productionline";
                    queryString += " SET ";
                    queryString += "pdl_fkPlant = " + this.fkPlant + ",";
                    queryString += "pdl_name =  '" + this.name.ToString() + "',";
                    queryString += "pdl_description =  '" + this.description.ToString() + "',";
                    queryString += "pdl_numberLine = " + this.numberLine.ToString() + "";
                    queryString += " WHERE pdl_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProductionLine.save");
                return false;
            }
        }

        public static List<clsProductionLine> getList()
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwlineproductionbyplant order by pdl_name asc");

            lstProductionLine.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProductionLine.Add(new clsProductionLine());
                lstProductionLine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_codsec"]);
                lstProductionLine[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_fkPlant"]);
                lstProductionLine[i].PlantName = DS.Tables[0].Rows[i]["pdl_PlantName"].ToString();
                lstProductionLine[i].name = DS.Tables[0].Rows[i]["pdl_name"].ToString();
                lstProductionLine[i].description = DS.Tables[0].Rows[i]["pdl_description"].ToString();
                lstProductionLine[i].numberLine = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_numberLine"]);
            }

            return lstProductionLine;
        }


        public static List<clsProductionLine> getListProductionLineByPlant(int plantCodsec)
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwlineproductionbyplant Where pdl_fkPlant = " + plantCodsec.ToString());

            lstProductionLine.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProductionLine.Add(new clsProductionLine());
                lstProductionLine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_codsec"]);
                lstProductionLine[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_fkPlant"]);
                lstProductionLine[i].PlantName = DS.Tables[0].Rows[i]["pdl_PlantName"].ToString();
                lstProductionLine[i].name = DS.Tables[0].Rows[i]["pdl_name"].ToString();
                lstProductionLine[i].description = DS.Tables[0].Rows[i]["pdl_description"].ToString();
                lstProductionLine[i].numberLine = Convert.ToInt32(DS.Tables[0].Rows[i]["pdl_numberLine"]);
            }

            return lstProductionLine;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
