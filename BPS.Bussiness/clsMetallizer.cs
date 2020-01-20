using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de la maquina metalizadora 
    /// </summary>
    public class clsMetallizer
    {
        //Atributes

        private int met_codsec;
        private string met_name;
        private string met_number;
        private int met_fkSector;
        private string met_SectorName;
        private int met_fkPlant;
        private string met_PlantName;
        private int met_fkStatus;
        private string met_StatusName;
        private int met_fkProductionLine;
        private string met_ProductionLineName;
        private int met_minFilmWidth;
        private int met_maxFilmWidth;
        private int met_maxVelocity;
        private int met_maxDiameter;

        //Properties

        public int codsec { get { return met_codsec; } set { met_codsec = value; } }

        public string name { get { return met_name; } set { met_name = value; } }

        public string number { get { return met_number; } set { met_number = value; } }

        public int fkSector { get { return met_fkSector; } set { met_fkSector = value; } }

        public string SectorName { get { return met_SectorName; } set { met_SectorName = value; } }

        public int fkPlant { get { return met_fkPlant; } set { met_fkPlant = value; } }

        public string PlantName { get { return met_PlantName; } set { met_PlantName = value; } }

        public int fkStatus { get { return met_fkStatus; } set { met_fkStatus = value; } }

        public string StatusName { get { return met_StatusName; } set { met_StatusName = value; } }

        public int fkProductionLine { get { return met_fkProductionLine; } set { met_fkProductionLine = value; } }

        public string ProductionLineName { get { return met_ProductionLineName; } set { met_ProductionLineName = value; } }

        public int minFilmWidth { get { return met_minFilmWidth; } set { met_minFilmWidth = value; } }

        public int maxFilmWidth { get { return met_maxFilmWidth; } set { met_maxFilmWidth = value; } }

        public int maxVelocity { get { return met_maxVelocity; } set { met_maxVelocity = value; } }

        public int maxDiameter { get { return met_maxDiameter; } set { met_maxDiameter = value; } }

        //Constructor

        public clsMetallizer()
        { 
        met_codsec = 0;
        met_name = "";
        met_number = "";
        met_fkSector = 0;
        met_SectorName = "";
        met_fkPlant = 0;
        met_PlantName = "";
        met_fkStatus = 0;
        met_StatusName = "";
        met_minFilmWidth = 0;
        met_maxFilmWidth = 0;
        met_maxVelocity = 0;
        met_fkProductionLine = 0;
        met_ProductionLineName = "";
        met_maxDiameter = 0;
        }

        public clsMetallizer(int codsec)
        {
            this.load(codsec);
        }

        public clsMetallizer(string name)
        {
            this.load(name);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizermachine where met_codsec = " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["met_codsec"]);
                this.name = DS.Tables[0].Rows[0]["met_name"].ToString();
                this.number = DS.Tables[0].Rows[0]["met_number"].ToString();
                this.minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["met_minFilmWidth"]);
                this.maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxFilmWidth"]);
                this.maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxVelocity"]);
                this.maxDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxDiameter"]);
                this.fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkProductionLine"]);
                this.ProductionLineName = DS.Tables[0].Rows[0]["met_ProductionLineName"].ToString();
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkPlant"]);
                this.PlantName = DS.Tables[0].Rows[0]["met_PlantName"].ToString();
                this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkSector"]);
                this.SectorName = DS.Tables[0].Rows[0]["met_SectorName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["met_StatusName"].ToString();
            }
        }

        public void load(string name)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizermachine where met_name = '" + name.ToString()+"'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["met_codsec"]);
                this.name = DS.Tables[0].Rows[0]["met_name"].ToString();
                this.number = DS.Tables[0].Rows[0]["met_number"].ToString();
                this.minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["met_minFilmWidth"]);
                this.maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxFilmWidth"]);
                this.maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxVelocity"]);
                this.maxDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["met_maxDiameter"]);
                this.fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkProductionLine"]);
                this.ProductionLineName = DS.Tables[0].Rows[0]["met_ProductionLineName"].ToString();
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkPlant"]);
                this.PlantName = DS.Tables[0].Rows[0]["met_PlantName"].ToString();
                this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkSector"]);
                this.SectorName = DS.Tables[0].Rows[0]["met_SectorName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["met_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["met_StatusName"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_metallizer (met_fkProductionLine,met_name,met_number, met_minFilmWidth,met_maxFilmWidth, met_maxVelocity, met_maxDiameter)";
                    queryString += " VALUES (";
                    queryString += this.fkProductionLine.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.number + "',";
                    queryString += this.minFilmWidth.ToString() + ",";
                    queryString += this.maxFilmWidth.ToString() + ",";
                    queryString += this.maxVelocity.ToString() + ",";
                    queryString += this.maxDiameter.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_metallizer";
                    queryString += " SET ";
                    queryString += "met_fkProductionLine = " + this.fkProductionLine.ToString() + ",";
                    queryString += "met_name = '" + this.name + "',";
                    queryString += "met_number = '" + this.number + "',";
                    queryString += "met_minFilmWidth = " + this.minFilmWidth.ToString() + ",";
                    queryString += "met_maxFilmWidth = " + this.maxFilmWidth.ToString() + ",";
                    queryString += "met_maxVelocity = " + this.maxVelocity.ToString() + ",";
                    queryString += "met_maxDiameter = " + this.maxDiameter.ToString() + "";
                    queryString += " WHERE met_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizer.save");
                return false;
            }
        }

        public static List<clsMetallizer> getList()
        {
            List<clsMetallizer> lstMetallizer = new List<clsMetallizer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizermachine order by met_name asc");

            lstMetallizer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizer.Add(new clsMetallizer());
                lstMetallizer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["met_codsec"]);
                lstMetallizer[i].name = DS.Tables[0].Rows[i]["met_name"].ToString();
                lstMetallizer[i].number = DS.Tables[0].Rows[0]["met_number"].ToString();
                lstMetallizer[i].minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["met_minFilmWidth"]);
                lstMetallizer[i].maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxFilmWidth"]);
                lstMetallizer[i].maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxVelocity"]);
                lstMetallizer[i].maxDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxDiameter"]);
                lstMetallizer[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkSector"]);
                lstMetallizer[i].SectorName = DS.Tables[0].Rows[i]["met_SectorName"].ToString();
                lstMetallizer[i].fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkProductionLine"]);
                lstMetallizer[i].ProductionLineName = DS.Tables[0].Rows[i]["met_ProductionLineName"].ToString();
                lstMetallizer[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkPlant"]);
                lstMetallizer[i].PlantName = DS.Tables[0].Rows[i]["met_PlantName"].ToString();
                lstMetallizer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkStatus"]);
                lstMetallizer[i].StatusName = DS.Tables[0].Rows[i]["met_StatusName"].ToString();
                
                
            }

            return lstMetallizer;
        }

        public static List<clsMetallizer> getListByPlant(int pla)
        {
            List<clsMetallizer> lstMetallizer = new List<clsMetallizer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizermachine WHERE met_fkPlant=" + pla.ToString() + " order by met_name asc");

            lstMetallizer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizer.Add(new clsMetallizer());
                lstMetallizer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["met_codsec"]);
                lstMetallizer[i].name = DS.Tables[0].Rows[i]["met_name"].ToString();
                lstMetallizer[i].number = DS.Tables[0].Rows[0]["met_number"].ToString();
                lstMetallizer[i].minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["met_minFilmWidth"]);
                lstMetallizer[i].maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxFilmWidth"]);
                lstMetallizer[i].maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxVelocity"]);
                lstMetallizer[i].maxDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["met_maxDiameter"]);
                lstMetallizer[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkSector"]);
                lstMetallizer[i].SectorName = DS.Tables[0].Rows[i]["met_SectorName"].ToString();
                lstMetallizer[i].fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkProductionLine"]);
                lstMetallizer[i].ProductionLineName = DS.Tables[0].Rows[i]["met_ProductionLineName"].ToString();
                lstMetallizer[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkPlant"]);
                lstMetallizer[i].PlantName = DS.Tables[0].Rows[i]["met_PlantName"].ToString();
                lstMetallizer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["met_fkStatus"]);
                lstMetallizer[i].StatusName = DS.Tables[0].Rows[i]["met_StatusName"].ToString();


            }

            return lstMetallizer;
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_metallizer ORDER BY met_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["met_codsec"]);

        }

        public static int returnCodsecByName(string name)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spMachineCodsecByName('" + name.ToString() + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsecMch"]);
            }
            else
            {
                return 0;
            }
        }
    }
}
