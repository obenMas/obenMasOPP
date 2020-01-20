using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de la maquina de extrusion 
    /// </summary>
    public class clsExtruder
    {
        //Atributes

        private int ext_codsec;
        private string ext_name;
        private int ext_minFilmWidth;
        private int ext_maxFilmWidth;
        private int ext_maxVelocity;
        private int ext_coilNumber;
        private int ext_kilogramsPerHour;
        private int ext_fkSector;
        private string ext_SectorName;
        private int ext_fkPlant;
        private string ext_PlantName;
        private int ext_fkProductionLine;
        private string ext_ProductionLineName;
        private int ext_ProductionLineNumber;
        private int ext_fkStatus;
        private string ext_StatusName;
        private List<int> ext_coilersNumbers;
        private int ext_sequential;
        private int ext_productionOrderSequential;
        private int ext_coilerRegistration;

        //Properties

        public int codsec { get { return ext_codsec; } set { ext_codsec = value; } }

        public string name { get { return ext_name; } set { ext_name = value; } }

        public int minFilmWidth { get { return ext_minFilmWidth; } set { ext_minFilmWidth = value; } }

        public int maxFilmWidth { get { return ext_maxFilmWidth; } set { ext_maxFilmWidth = value; } }

        public int maxVelocity { get { return ext_maxVelocity; } set { ext_maxVelocity = value; } }
        
        public int coilNumber { get { return ext_coilNumber; } set { ext_coilNumber = value; } }

        public int kilogramsPerHour { get { return ext_kilogramsPerHour; } set { ext_kilogramsPerHour = value; } }

        public int fkSector { get { return ext_fkSector; } set { ext_fkSector = value; } }

        public string SectorName { get { return ext_SectorName; } set { ext_SectorName = value; } }

        public int fkPlant { get { return ext_fkPlant; } set { ext_fkPlant = value; } }

        public string PlantName { get { return ext_PlantName; } set { ext_PlantName = value; } }

        public int fkProductionLine { get { return ext_fkProductionLine; } set { ext_fkProductionLine = value; } }

        public string ProductionLineName { get { return ext_ProductionLineName; } set { ext_ProductionLineName = value; } }

        public int ProductionLineNumber { get { return ext_ProductionLineNumber; } set { ext_ProductionLineNumber = value; } }

        public int fkStatus { get { return ext_fkStatus; } set { ext_fkStatus = value; } }

        public string StatusName { get { return ext_StatusName; } set { ext_StatusName = value; } }

        public List<int> coilersNumbers { get { return ext_coilersNumbers; } set { ext_coilersNumbers = value; } }

        public int sequential { get { return ext_sequential; } set { ext_sequential = value; } }

        public int productionOrderSequential { get { return ext_productionOrderSequential; } set { ext_productionOrderSequential = value; } }

        public int coilerRegistration { get { return ext_coilerRegistration; } set { ext_coilerRegistration = value; } }


        //Constructor

        public clsExtruder()
        { 
            ext_codsec = 0;
            ext_name = "";
            ext_minFilmWidth = 0;
            ext_maxFilmWidth = 0;
            ext_maxVelocity = 0;
            ext_coilNumber = 0;
            ext_kilogramsPerHour = 0;
            ext_fkSector = 0;
            ext_SectorName = "";
            ext_fkPlant = 0;
            ext_PlantName = "";
            ext_fkProductionLine = 0;
            ext_ProductionLineName = "";
            ext_ProductionLineNumber = 0;
            ext_fkStatus = 0;
            ext_StatusName = "";
            ext_coilersNumbers = new List<int>();
            ext_sequential = 0;
            ext_productionOrderSequential = 0;
            ext_coilerRegistration = 0;
        }
        
        public clsExtruder(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwextrudermachine where ext_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ext_name"].ToString();
            this.minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_minFilmWidth"]);
            this.maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_maxFilmWidth"]);
            this.maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_maxVelocity"]);
            this.coilNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_coilNumber"]);
            this.kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_kilogramsPerHour"]);
            this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_fkPlant"]);
            this.PlantName = DS.Tables[0].Rows[0]["ext_PlantName"].ToString();
            this.fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_fkProductionLine"]);
            this.ProductionLineName = DS.Tables[0].Rows[0]["ext_ProductionLineName"].ToString();
            this.ProductionLineNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_ProductionLineNumber"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_fkSector"]);
            this.SectorName = DS.Tables[0].Rows[0]["ext_SectorName"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["ext_StatusName"].ToString();
            this.coilersNumbers = clsExtruder.getCoilersNumbersByExtruder(this.codsec);
            this.sequential = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_secuensial"]);
            this.productionOrderSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_productionOrderSequential"]);
            this.coilerRegistration = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_coilerRegistration"]);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_extruder (ext_fkProductionLine,ext_name, ext_minFilmWidth,ext_maxFilmWidth,ext_maxVelocity, ext_coilNumber, ext_kilogramsPerHour, ext_secuensial, ext_productionOrderSequential, ext_coilerRegistration)";
                    queryString += " VALUES (";
                    queryString += this.fkProductionLine.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += this.minFilmWidth.ToString()+ ",";
                    queryString += this.maxFilmWidth.ToString() + ",";
                    queryString += this.maxVelocity.ToString() + ",";
                    queryString += this.coilNumber.ToString()+ ",";
                    queryString += this.kilogramsPerHour.ToString()+ ",";
                    queryString += "1,1,0";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_extruder";
                    queryString += " SET ";
                    queryString += "ext_fkProductionLine = " + this.fkProductionLine.ToString() + ",";
                    queryString += "ext_name = '" + this.name + "',";
                    queryString += "ext_minFilmWidth = " + this.minFilmWidth.ToString()+ ",";
                    queryString += "ext_maxFilmWidth = " + this.maxFilmWidth.ToString() + ",";
                    queryString += "ext_maxVelocity = " + this.maxVelocity.ToString() + ",";
                    queryString += "ext_coilNumber = " + this.coilNumber.ToString()+ ",";
                    queryString += "ext_kilogramsPerHour = " + this.kilogramsPerHour.ToString()+ "";
                    queryString += " WHERE ext_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsExtruder.save");
                return false;
            }
        }

        public static List<clsExtruder> getList()
        {
            List<clsExtruder> lstExtruder = new List<clsExtruder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwextrudermachine order by ext_name asc");

            lstExtruder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstExtruder.Add(new clsExtruder());
                lstExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_codsec"]);
                lstExtruder[i].name = DS.Tables[0].Rows[i]["ext_name"].ToString();
                lstExtruder[i].minFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_minFilmWidth"]);
                lstExtruder[i].maxFilmWidth = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_maxFilmWidth"]);
                lstExtruder[i].maxVelocity = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_maxVelocity"]);
                lstExtruder[i].coilNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_coilNumber"]);
                lstExtruder[i].kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_kilogramsPerHour"]);
                lstExtruder[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_fkSector"]);
                lstExtruder[i].SectorName = DS.Tables[0].Rows[i]["ext_SectorName"].ToString();
                lstExtruder[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_fkPlant"]);
                lstExtruder[i].PlantName = DS.Tables[0].Rows[i]["ext_PlantName"].ToString();
                lstExtruder[i].fkProductionLine = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_fkProductionLine"]);
                lstExtruder[i].ProductionLineName = DS.Tables[0].Rows[i]["ext_ProductionLineName"].ToString();
                lstExtruder[i].ProductionLineNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_ProductionLineNumber"]); 
                lstExtruder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_fkStatus"]);
                lstExtruder[i].StatusName = DS.Tables[0].Rows[i]["ext_StatusName"].ToString();
                lstExtruder[i].sequential = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_secuensial"]);
                lstExtruder[i].coilersNumbers = clsExtruder.getCoilersNumbersByExtruder(lstExtruder[i].codsec);
                lstExtruder[i].productionOrderSequential = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_productionOrderSequential"]);
                lstExtruder[i].coilerRegistration = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_coilerRegistration"]);
            }

            return lstExtruder;
        }
        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_extruder ORDER BY ext_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["ext_codsec"]);

        }
        public static bool saveExtruderCoilersNumbers(int extruderCodsec, List<int> lstNumbers)
        {
            try
            {
                clsConnection.executeQuery("DELETE FROM bps_prod_CoilerByExtruder WHERE cbe_fkExtruder = " + extruderCodsec.ToString());

                for (int i = 0; i < lstNumbers.Count; i++)
                {
                    clsConnection.executeQuery("INSERT INTO bps_prod_CoilerByExtruder (cbe_fkExtruder, cbe_coilerNumber) VALUES (" + extruderCodsec.ToString() + "," + lstNumbers[i].ToString() + ");");
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsExtruder.saveExtruderCoilersNumbers");
                return false;
            }
        }
        public static List<int> getCoilersNumbersByExtruder(int extruderCodsec)
        {
            List<int> lstNumbers = new List<int>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_CoilerByExtruder WHERE cbe_fkExtruder = " + extruderCodsec.ToString());

            lstNumbers.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    lstNumbers.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["cbe_coilerNumber"]));
            }
            return lstNumbers;
        }
        public void resetSequential()
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_secuensial =  1 WHERE ext_codsec = " + this.codsec);
            this.sequential = 1;
        }
        public void increaseSequential()
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_secuensial = ext_secuensial + 1, ext_coilerRegistration = " + this.coilersNumbers[0] + " WHERE ext_codsec = " + this.codsec);
        }
        public void increaseCoilerRegistration()
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_coilerRegistration = ext_coilerRegistration + 1 WHERE ext_codsec = " + this.codsec);
        }
        public void increaseProductOrderSequential()
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_productionOrderSequential = ext_productionOrderSequential + 1 WHERE ext_codsec = " + this.codsec);
        }
        public static int getNextProductionOrderByExtruder(int extruderCodsec)
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_extruder WHERE ext_codsec = " + extruderCodsec.ToString() + "  ORDER BY ext_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["ext_productionOrderSequential"]);
        }
        public static List<clsExtruder> getExtruderListByMachine(int machineCodsec)
        {
            List<clsExtruder> lstExtruder = new List<clsExtruder>();
            DataSet DS = new DataSet ();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_extruder WHERE ext_codsec = " + machineCodsec.ToString() + " ORDER BY ext_codsec ASC");

            lstExtruder.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstExtruder.Add(new clsExtruder());
                    lstExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_codsec"]);
                    lstExtruder[i].kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["ext_kilogramsPerHour"]);
                    lstExtruder[i].name = DS.Tables[0].Rows[i]["ext_name"].ToString();
                }
            }
            return lstExtruder;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
