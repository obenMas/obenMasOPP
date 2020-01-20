using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    // <summary>
    /// Clase para el manejo de los Procesos para producto Cast/Coating
    /// </summary>
    public class clsProcess
    {
        //Atributes

        private int pcss_codsec;
        private string pcss_name;
        private string pcss_abbreviation;
        private Boolean pcss_isForCast;
        private Boolean pcss_isForCoat;


        //Properties

        public int codsec { get { return pcss_codsec; } set { pcss_codsec = value; } }

        public string name { get { return pcss_name; } set { pcss_name = value; } }

        public string abbreviation { get { return pcss_abbreviation; } set { pcss_abbreviation = value; } }

        public Boolean isForCast { get { return pcss_isForCast; } set { pcss_isForCast = value; } }

        public Boolean isForCoat { get { return pcss_isForCoat; } set { pcss_isForCoat = value; } }

        //Constructor

        public clsProcess()
        { 
            pcss_codsec = 0;
            pcss_name = "";
            pcss_abbreviation = "";
            pcss_isForCast = false;
            pcss_isForCoat = false;
        }
        public clsProcess(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_process where pcss_codsec = " + codsec.ToString());
           

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcss_codsec"]);
            this.name = DS.Tables[0].Rows[0]["pcss_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["pcss_abbreviation"].ToString();
            this.isForCast = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcss_isForCast"], DS.Tables[0].Rows[0]["pcss_isForCast"].GetType().FullName);
            this.isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcss_isForCoat"], DS.Tables[0].Rows[0]["pcss_isForCoat"].GetType().FullName);

        }

        public bool save()
        {

            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_process (pcss_name, pcss_abbreviation, pcss_isForCast, pcss_isForCoat)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "',";
                    queryString += "" + this.isForCast + ",";
                    queryString += "" + this.isForCoat + "";
                    queryString += ");";
                    
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_process";
                    queryString += " SET ";
                    queryString += "pcss_name = '" + this.name + "',";
                    queryString += "pcss_abbreviation = '" + this.abbreviation + "',";
                    queryString += "pcss_isForCast = " + this.isForCast.ToString() + ",";
                    queryString += "pcss_isForCoat = " + this.isForCoat.ToString() + "";
                    queryString += " WHERE pcss_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProcess.save");
                return false;
            }
        }

        public static List<clsProcess> getList()
        {
            List<clsProcess> lstProcess = new List<clsProcess>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_process ORDER BY pcss_name");

            lstProcess.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProcess.Add(new clsProcess());
                lstProcess[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcss_codsec"]);
                lstProcess[i].name = DS.Tables[0].Rows[i]["pcss_name"].ToString();
                lstProcess[i].abbreviation = DS.Tables[0].Rows[i]["pcss_abbreviation"].ToString();
                lstProcess[i].isForCast = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcss_isForCast"], DS.Tables[0].Rows[i]["pcss_isForCast"].GetType().FullName);
                lstProcess[i].isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcss_isForCoat"], DS.Tables[0].Rows[i]["pcss_isForCoat"].GetType().FullName);
            }

            return lstProcess;
        }


        public static List<clsProcess> getListProcessForCast()
        {
            List<clsProcess> lstProcessForCast = new List<clsProcess>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_process where pcss_isForCast = 1 order by pcss_abbreviation asc");

            lstProcessForCast.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProcessForCast.Add(new clsProcess());
                lstProcessForCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcss_codsec"]);
                lstProcessForCast[i].name = DS.Tables[0].Rows[i]["pcss_name"].ToString();
                lstProcessForCast[i].abbreviation = DS.Tables[0].Rows[i]["pcss_abbreviation"].ToString();

            }

            return lstProcessForCast;
        }

        public static List<clsProcess> getListProcessForCoat()
        {
            List<clsProcess> lstProcessForCoat = new List<clsProcess>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_process where pcss_isForCoat = 1 order by pcss_abbreviation asc");

            lstProcessForCoat.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProcessForCoat.Add(new clsProcess());
                lstProcessForCoat[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcss_codsec"]);
                lstProcessForCoat[i].name = DS.Tables[0].Rows[i]["pcss_name"].ToString();
                lstProcessForCoat[i].abbreviation = DS.Tables[0].Rows[i]["pcss_abbreviation"].ToString();

            }

            return lstProcessForCoat;
        }


        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }
        



    }
}
