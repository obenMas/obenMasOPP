using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los sectores de la planta
    /// </summary>
    public class clsSector
    {
         //Atributes

        private int sct_codsec;
        private string sct_name;
        private int sct_fkPlant;
        private string sct_plantName;
        
        //Properties

        public int codsec { get { return sct_codsec; } set { sct_codsec = value; } }

        public string name { get { return sct_name; } set { sct_name = value; } }

        public int fkPlant { get { return sct_fkPlant; } set { sct_fkPlant = value; } }

        public string plantName { get { return sct_plantName; } set { sct_plantName = value; } }

        
        //Constructor

        public clsSector()
        { 
        sct_codsec = 0;
        sct_name = "";
        sct_fkPlant = 0;
        sct_plantName = "";
        }


        public clsSector(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSectorPlant where sct_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sct_codsec"]);
            this.name = DS.Tables[0].Rows[0]["sct_name"].ToString();
            this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["sct_fkPlant"]);
            this.plantName = DS.Tables[0].Rows[0]["sct_plantName"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_sector (sct_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_sector";
                    queryString += " SET ";
                    queryString += "sct_name = '" + this.name + "'";
                    queryString += " WHERE sct_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSector.save");
                return false;
            }
        }

        public static List<clsSector> getList()
        {
            List<clsSector> lstSector = new List<clsSector>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSectorPlant order by sct_name, sct_plantName asc");

            lstSector.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSector.Add(new clsSector());
                lstSector[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sct_codsec"]);
                lstSector[i].name = DS.Tables[0].Rows[i]["sct_name"].ToString();
                lstSector[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sct_fkPlant"]);
                lstSector[i].plantName = DS.Tables[0].Rows[i]["sct_plantName"].ToString();
                             
            }

            return lstSector;
        }


         public static List<clsSector> getListByPlant(int plantCodsec)
        {
            List<clsSector> lstSector = new List<clsSector>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwSectorPlant where sct_fkPlant = " + plantCodsec.ToString());

            lstSector.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSector.Add(new clsSector());
                lstSector[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sct_codsec"]);
                lstSector[i].name = DS.Tables[0].Rows[i]["sct_name"].ToString();
                lstSector[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["sct_fkPlant"]);
                lstSector[i].plantName = DS.Tables[0].Rows[i]["sct_plantName"].ToString();
                             
            }

            return lstSector;
        }
       
        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_sector ORDER BY sct_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["sct_codsec"]);

        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
