using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las plantas de la empresa por pais
    /// </summary>
    public class    clsPlant
    {
         //Atributes

        private int plant_codsec;
        private string plant_name;
        private string plant_abr;
        
        //Properties

        public int codsec { get { return plant_codsec; } set { plant_codsec = value; } }

        public string name { get { return plant_name; } set { plant_name = value; } }

        public string abr { get { return plant_abr; } set { plant_abr = value; } }
        
        //Constructor

        public clsPlant()
        { 
        plant_codsec = 0;
        plant_name = "";
        plant_abr = "";
        }


        public clsPlant(int codsec)
        {
            this.load(codsec);
        }

        public clsPlant(string name)
        {
            this.load(name);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_plant where plant_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plant_codsec"]);
            this.name = DS.Tables[0].Rows[0]["plant_name"].ToString();
            this.abr = DS.Tables[0].Rows[0]["plant_abr"].ToString();

        }

        public void load(string name)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_plant where plant_name = '" + name.ToString()+"'");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plant_codsec"]);
            this.name = DS.Tables[0].Rows[0]["plant_name"].ToString();
            this.abr = DS.Tables[0].Rows[0]["plant_abr"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_plant (plant_name,plant_abr)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abr + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_plant";
                    queryString += " SET ";
                    queryString += "plant_name = '" + this.name + "',";
                    queryString += "plant_abr = '" + this.abr + "'";
                    queryString += " WHERE plant_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPlant.save");
                return false;
            }
        }

        public static List<clsPlant> getList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_plant order by plant_name asc");

            lstPlant.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPlant.Add(new clsPlant());
                lstPlant[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plant_codsec"]);
                lstPlant[i].name = DS.Tables[0].Rows[i]["plant_name"].ToString();
                lstPlant[i].abr = DS.Tables[0].Rows[i]["plant_abr"].ToString();
            }

            return lstPlant;
        }

        public static List<clsPlant> getListPlantBySector(int codsec)
        {
            List<clsPlant> lstPlant = new List<clsPlant>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSectorPlant where sct_codsec = " + codsec.ToString());

            lstPlant.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPlant.Add(new clsPlant());
                lstPlant[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sct_fkPlant"]);
                lstPlant[i].name = DS.Tables[0].Rows[i]["sct_plantName"].ToString();
                lstPlant[i].abr = DS.Tables[0].Rows[i]["sct_plantAbr"].ToString();

            }

            return lstPlant;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
