using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo de la Aditivacion para producto BOPP/Cast/Coating
    /// </summary>
    public class clsAdditivation
    {

        //Atributes

        private int adt_codsec;
        private string adt_name;
        private string adt_abbreviation;
        private Boolean adt_isForBopp;
        private Boolean adt_isForCpp;

        //Properties

        public int codsec { get { return adt_codsec; } set { adt_codsec = value; } }

        public string name { get { return adt_name; } set { adt_name = value; } }

        public string abbreviation { get { return adt_abbreviation; } set { adt_abbreviation = value; } }

        public Boolean isForBopp { get { return adt_isForBopp; } set { adt_isForBopp = value; } }

        public Boolean isForCpp { get { return adt_isForCpp; } set { adt_isForCpp = value; } }

        //Constructor

        public clsAdditivation()
        {
            adt_codsec = 0;
            adt_name = "";
            adt_abbreviation = "";
            adt_isForBopp = false;
            adt_isForCpp = false;
        }
        public clsAdditivation(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_additivation where adt_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["adt_codsec"]);
            this.name = DS.Tables[0].Rows[0]["adt_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["adt_abbreviation"].ToString();
            this.isForBopp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["adt_isForBopp"], DS.Tables[0].Rows[0]["adt_isForBopp"].GetType().FullName);
            this.isForCpp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["adt_isForCpp"], DS.Tables[0].Rows[0]["adt_isForCpp"].GetType().FullName);
        
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_additivation (adt_name, adt_abbreviation, adt_isForBopp, adt_isForCpp)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "',";
                    queryString += "" + this.isForBopp + ",";
                    queryString += "" + this.isForCpp + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_additivation";
                    queryString += " SET ";
                    queryString += "adt_name = '" + this.name + "',";
                    queryString += "adt_abbreviation = '" + this.abbreviation + "',";
                    queryString += "adt_isForBopp = " + this.isForBopp.ToString() + ",";
                    queryString += "adt_isForCpp = " + this.isForCpp.ToString() + "";
                    queryString += " WHERE adt_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }
                

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsAdditivation.save");
                return false;
            }

        }

        public static List<clsAdditivation> getList()
        {
            List<clsAdditivation> lstAdditivation = new List<clsAdditivation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_additivation order by adt_abbreviation asc");

            lstAdditivation.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstAdditivation.Add(new clsAdditivation());
                lstAdditivation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["adt_codsec"]);
                lstAdditivation[i].name = DS.Tables[0].Rows[i]["adt_name"].ToString();
                lstAdditivation[i].abbreviation = DS.Tables[0].Rows[i]["adt_abbreviation"].ToString();
                lstAdditivation[i].isForBopp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["adt_isForBopp"], DS.Tables[0].Rows[i]["adt_isForBopp"].GetType().FullName);
                lstAdditivation[i].isForCpp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["adt_isForCpp"], DS.Tables[0].Rows[i]["adt_isForCpp"].GetType().FullName);
            }

            return lstAdditivation;
        }

        public static List<clsAdditivation> getListAdditivationForBopp()
        {
            List<clsAdditivation> lstAdditivationForBopp = new List<clsAdditivation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_additivation where adt_isForBopp = 1 order by adt_abbreviation asc");

            lstAdditivationForBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstAdditivationForBopp.Add(new clsAdditivation());
                lstAdditivationForBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["adt_codsec"]);
                lstAdditivationForBopp[i].name = DS.Tables[0].Rows[i]["adt_name"].ToString();
                lstAdditivationForBopp[i].abbreviation = DS.Tables[0].Rows[i]["adt_abbreviation"].ToString();
                
            }

            return lstAdditivationForBopp;
        }

        public static List<clsAdditivation> getListAdditivationForCast()
        {
            List<clsAdditivation> lstAdditivationForCast = new List<clsAdditivation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_additivation where adt_isForCpp = 1 order by adt_abbreviation asc");

            lstAdditivationForCast.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstAdditivationForCast.Add(new clsAdditivation());
                lstAdditivationForCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["adt_codsec"]);
                lstAdditivationForCast[i].name = DS.Tables[0].Rows[i]["adt_name"].ToString();
                lstAdditivationForCast[i].abbreviation = DS.Tables[0].Rows[i]["adt_abbreviation"].ToString();

            }

            return lstAdditivationForCast;
        }

        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }

    }
}
