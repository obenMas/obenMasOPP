using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    // <summary>
    /// Clase para el manejo de la Estructura para producto Cast/Coating
    /// </summary>
    public class clsStructure
    {
        //Atributes

        private int strc_codsec;
        private string strc_name;
        private string strc_abbreviation;
        private Boolean strc_isForCast;
        private Boolean strc_isForCoat;


        //Properties

        public int codsec { get { return strc_codsec; } set { strc_codsec = value; } }

        public string name { get { return strc_name; } set { strc_name = value; } }

        public string abbreviation { get { return strc_abbreviation; } set { strc_abbreviation = value; } }

        public Boolean isForCast { get { return strc_isForCast; } set { strc_isForCast = value; } }

        public Boolean isForCoat { get { return strc_isForCoat; } set { strc_isForCoat = value; } }


        //Constructor

        public clsStructure()
        {
            strc_codsec = 0;
            strc_name = "";
            strc_abbreviation = "";
            strc_isForCast = false;
            strc_isForCoat = false;
        }

        public clsStructure(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_structure where strc_codsec = " + codsec.ToString());


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["strc_codsec"]);
            this.name = DS.Tables[0].Rows[0]["strc_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["strc_abbreviation"].ToString();
            this.isForCast = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["strc_isForCast"], DS.Tables[0].Rows[0]["strc_isForCast"].GetType().FullName);
            this.isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["strc_isForCoat"], DS.Tables[0].Rows[0]["strc_isForCoat"].GetType().FullName);

        }

        public bool save()
        {
            try
            {
                    string queryString = "";


                    if (this.codsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_structure (strc_name, strc_abbreviation, strc_isForCast, strc_isForCoat)";
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
                        queryString += "UPDATE bps_prod_structure";
                        queryString += " SET ";
                        queryString += "strc_name = '" + this.name + "',";
                        queryString += "strc_abbreviation = '" + this.abbreviation + "',";
                        queryString += "strc_isForCast = " + this.isForCast.ToString() + ",";
                        queryString += "strc_isForCoat = " + this.isForCoat.ToString() + "";
                        queryString += " WHERE strc_codsec = " + this.codsec.ToString() + ";";
                        clsConnection.executeQuery(queryString);

                    }
                    return true;
              }

              catch (Exception ex)
              {
                  clsLog.addLog(ex, 3, "clsStructure.save");
                  return false;
              }
        }

        public static List<clsStructure> getList()
        {
            List<clsStructure> lstStructures = new List<clsStructure>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_structure ORDER BY  strc_name");

            lstStructures.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStructures.Add(new clsStructure());
                lstStructures[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["strc_codsec"]);
                lstStructures[i].name = DS.Tables[0].Rows[i]["strc_name"].ToString();
                lstStructures[i].abbreviation = DS.Tables[0].Rows[i]["strc_abbreviation"].ToString();
                lstStructures[i].isForCast = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["strc_isForCast"], DS.Tables[0].Rows[i]["strc_isForCast"].GetType().FullName);
                lstStructures[i].isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["strc_isForCoat"], DS.Tables[0].Rows[i]["strc_isForCoat"].GetType().FullName);
            }

            return lstStructures;

        }

        public static List<clsStructure> getListStructureForCast()
        {
            List<clsStructure> lstStructureForCast = new List<clsStructure>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_structure where strc_isForCast = 1 order by strc_abbreviation asc");

            lstStructureForCast.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStructureForCast.Add(new clsStructure());
                lstStructureForCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["strc_codsec"]);
                lstStructureForCast[i].name = DS.Tables[0].Rows[i]["strc_name"].ToString();
                lstStructureForCast[i].abbreviation = DS.Tables[0].Rows[i]["strc_abbreviation"].ToString();

            }

            return lstStructureForCast;
        }

        public static List<clsStructure> getListStructureForCoat()
        {
            List<clsStructure> lstStructureForCoat = new List<clsStructure>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_structure where strc_isForCoat = 1 order by strc_abbreviation asc");

            lstStructureForCoat.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStructureForCoat.Add(new clsStructure());
                lstStructureForCoat[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["strc_codsec"]);
                lstStructureForCoat[i].name = DS.Tables[0].Rows[i]["strc_name"].ToString();
                lstStructureForCoat[i].abbreviation = DS.Tables[0].Rows[i]["strc_abbreviation"].ToString();

            }

            return lstStructureForCoat;
        }

        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }
    }
}
