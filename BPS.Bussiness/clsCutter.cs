using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de la maquina cortadora 
    /// </summary>
    public class clsCutter
    {
        //Atributes

        private int cut_codsec;
        private string cut_name;
        private int cut_arms;
        private int cut_utilWidth;
        private int cut_maxVelocity;
        private int cut_fkSector;
        private string cut_SectorName;
        private int cut_fkPlant;
        private string cut_PlantName;
        private int cut_fkStatus;
        private string cut_StatusName;
        private int cut_fkProductionLine;
        private string cut_ProductionLineName;
        private int cut_cutterNumber;




        //Properties

        public int codsec { get { return cut_codsec; } set { cut_codsec = value; } }

        public string name { get { return cut_name; } set { cut_name = value; } }

        public int arms { get { return cut_arms; } set { cut_arms = value; } }

        public int utilWidth { get { return cut_utilWidth; } set { cut_utilWidth = value; } }

        public int maxVelocity { get { return cut_maxVelocity; } set { cut_maxVelocity = value; } }

        public int fkSector { get { return cut_fkSector; } set { cut_fkSector = value; } }

        public string SectorName { get { return cut_SectorName; } set { cut_SectorName = value; } }

        public int fkPlant { get { return cut_fkPlant; } set { cut_fkPlant = value; } }

        public string PlantName { get { return cut_PlantName; } set { cut_PlantName = value; } }

        public int fkStatus { get { return cut_fkStatus; } set { cut_fkStatus = value; } }

        public string StatusName { get { return cut_StatusName; } set { cut_StatusName = value; } }

        public int fkProductionLine { get { return cut_fkProductionLine; } set { cut_fkProductionLine = value; } }

        public string ProductionLineName { get { return cut_ProductionLineName; } set { cut_ProductionLineName = value; } }

        public int cutterNumber { get { return cut_cutterNumber; } set { cut_cutterNumber = value; } }

        
        //Constructor

        public clsCutter()
        { 
            cut_codsec = 0;
            cut_name = "";
            cut_arms = 0;
            cut_utilWidth = 0;
            cut_maxVelocity = 0;
            cut_fkSector = 0;
            cut_SectorName = "";
            cut_fkPlant = 0;
            cut_PlantName = "";
            cut_fkStatus = 0;
            cut_StatusName = "";
            cut_fkProductionLine = 0;
            cut_ProductionLineName = "";
            cut_cutterNumber = 0;
        }

        public clsCutter(string nomCutt)
        {
            this.load(nomCutt);
        }

        public clsCutter(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCutterMachine where cut_codsec = " + codsec.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_codsec"]);
                this.name = DS.Tables[0].Rows[0]["cut_name"].ToString();
                this.arms = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_arms"]);
                this.utilWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_utilWidth"]);
                this.maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_maxVelocity"]);
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkPlant"]);
                this.PlantName = DS.Tables[0].Rows[0]["cut_PlantName"].ToString();
                this.fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkProductionLine"]);
                this.ProductionLineName = DS.Tables[0].Rows[0]["cut_ProductionLineName"].ToString();
                this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkSector"]);
                this.SectorName = DS.Tables[0].Rows[0]["cut_SectorName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["cut_StatusName"].ToString();
                this.cutterNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_cutterNumber"]);
            }
            

        }

        public void load(string nomCut)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCutterMachine where cut_name = " + "'" + nomCut.ToString() + "'");

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_codsec"]);
                this.name = DS.Tables[0].Rows[0]["cut_name"].ToString();
                this.arms = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_arms"]);
                this.utilWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_utilWidth"]);
                this.maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_maxVelocity"]);
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkPlant"]);
                this.PlantName = DS.Tables[0].Rows[0]["cut_PlantName"].ToString();
                this.fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkProductionLine"]);
                this.ProductionLineName = DS.Tables[0].Rows[0]["cut_ProductionLineName"].ToString();
                this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkSector"]);
                this.SectorName = DS.Tables[0].Rows[0]["cut_SectorName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["cut_StatusName"].ToString();
                this.cutterNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["cut_cutterNumber"]);
            }
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cutter (cut_fkProductionLine,cut_name, cut_arms, cut_utilWidth, cut_maxVelocity, cut_cutterNumber)";
                    queryString += " VALUES (";
                    queryString += this.fkProductionLine.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += this.arms.ToString() + ",";
                    queryString += this.utilWidth.ToString() + ",";
                    queryString += this.maxVelocity.ToString() + ",";
                    queryString += this.cutterNumber.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_cutter";
                    queryString += " SET ";
                    queryString += "cut_fkProductionLine = " + this.fkProductionLine.ToString() + ",";
                    queryString += "cut_name = '" + this.name + "',";
                    queryString += "cut_arms = " + this.arms.ToString() + ",";
                    queryString += "cut_utilWidth = " + this.utilWidth.ToString() + ",";
                    queryString += "cut_maxVelocity = " + this.maxVelocity.ToString() + ",";
                    queryString += "cut_cutterNumber = " + this.cutterNumber.ToString() + "";
                    queryString += " WHERE cut_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCutter.save");
                return false;
            }
        }

        public static List<clsCutter> CutterListByPlant(int fkPlant)
        {
            List<clsCutter> CutterListByPlant = new List<clsCutter>(fkPlant);
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCutterListByPlant(" + fkPlant + ")");

            CutterListByPlant.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                CutterListByPlant.Add(new clsCutter());
                CutterListByPlant[i].name = DS.Tables[0].Rows[i]["Cortadora"].ToString();
            }
            return CutterListByPlant;
       
        }

        public static List<clsCutter> getList()
        {
            List<clsCutter> lstCutter = new List<clsCutter>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCutterMachine order by cut_name asc");

            lstCutter.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCutter.Add(new clsCutter());
                lstCutter[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_codsec"]);
                lstCutter[i].name = DS.Tables[0].Rows[i]["cut_name"].ToString();
                lstCutter[i].arms = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_arms"]);
                lstCutter[i].utilWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_utilWidth"]);
                lstCutter[i].maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_maxVelocity"]);
                lstCutter[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_fkSector"]);
                lstCutter[i].SectorName = DS.Tables[0].Rows[i]["cut_SectorName"].ToString();
                lstCutter[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_fkPlant"]);
                lstCutter[i].PlantName = DS.Tables[0].Rows[i]["cut_PlantName"].ToString();
                lstCutter[i].fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_fkProductionLine"]);
                lstCutter[i].ProductionLineName = DS.Tables[0].Rows[i]["cut_ProductionLineName"].ToString();
                lstCutter[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_fkStatus"]);
                lstCutter[i].StatusName = DS.Tables[0].Rows[i]["cut_StatusName"].ToString();
                lstCutter[i].cutterNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["cut_cutterNumber"]);
                
            }
            return lstCutter;
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cutter ORDER BY cut_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cut_codsec"]);

        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
