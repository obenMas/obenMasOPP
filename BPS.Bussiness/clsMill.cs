using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de los molinos
    /// </summary>
    public class clsMill
    {
        //Atributes

        private int mill_codsec;
        private string mill_name;
        private int mill_kilogramsPerHour;
        private int mill_fkSector;
        private string mill_SectorName;
        private int mill_fkPlant;
        private string mill_PlantName;
        private int mill_fkStatus;
        private string mill_StatusName;


        //Properties

        public int codsec { get { return mill_codsec; } set { mill_codsec = value; } }

        public string name { get { return mill_name; } set { mill_name = value; } }

        public int kilogramsPerHour { get { return mill_kilogramsPerHour; } set { mill_kilogramsPerHour = value; } }

        public int fkSector { get { return mill_fkSector; } set { mill_fkSector = value; } }

        public string SectorName { get { return mill_SectorName; } set { mill_SectorName = value; } }

        public int fkPlant { get { return mill_fkPlant; } set { mill_fkPlant = value; } }

        public string PlantName { get { return mill_PlantName; } set { mill_PlantName = value; } }

        public int fkStatus { get { return mill_fkStatus; } set { mill_fkStatus = value; } }

        public string StatusName { get { return mill_StatusName; } set { mill_StatusName = value; } }

        //Constructor

        public clsMill()
        { 
        mill_codsec = 0;
        mill_name = "";
        mill_kilogramsPerHour = 0;
        mill_fkSector = 0;
        mill_SectorName = "";
        mill_fkPlant = 0;
        mill_PlantName = "";
        mill_fkStatus = 0;
        mill_StatusName = "";

        }
        

        public clsMill(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmillmachine where mill_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
            this.name = DS.Tables[0].Rows[0]["mill_name"].ToString();
            this.kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_kilogramsPerHour"]);
            this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkPlant"]);
            this.PlantName = DS.Tables[0].Rows[0]["mill_PlantName"].ToString();
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkSector"]);
            this.SectorName = DS.Tables[0].Rows[0]["mill_SectorName"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["mill_StatusName"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_mill (mill_name, mill_kilogramsPerHour)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += this.kilogramsPerHour.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_mill";
                    queryString += " SET ";
                    queryString += "mill_name = '" + this.name + "',";
                    queryString += "mill_kilogramsPerHour = " + this.kilogramsPerHour.ToString() + "";
                    queryString += " WHERE mill_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMill.save");
                return false;
            }
        }

        public static List<clsMill> getList()
        {
            List<clsMill> lstMill = new List<clsMill>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmillmachine order by mill_name asc");

            lstMill.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMill.Add(new clsMill());
                lstMill[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                lstMill[i].name = DS.Tables[0].Rows[i]["mill_name"].ToString();
                lstMill[i].kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_kilogramsPerHour"]);
                lstMill[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkSector"]);
                lstMill[i].SectorName = DS.Tables[0].Rows[i]["mill_SectorName"].ToString();
                lstMill[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkPlant"]);
                lstMill[i].PlantName = DS.Tables[0].Rows[i]["mill_PlantName"].ToString();
                lstMill[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkStatus"]);
                lstMill[i].StatusName = DS.Tables[0].Rows[i]["mill_StatusName"].ToString();
                                
            }

            return lstMill;
        }

        public static List<clsMill> getListMill()
        {
            List<clsMill> lstMill = new List<clsMill>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_mill ORDER BY mill_codsec ASC");

            lstMill.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMill.Add(new clsMill());
                lstMill[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                lstMill[i].name = DS.Tables[0].Rows[i]["mill_name"].ToString();
                lstMill[i].kilogramsPerHour = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_kilogramsPerHour"]);
            }

            return lstMill;
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_mill ORDER BY mill_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);

        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
