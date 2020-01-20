using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo del Tratamiento para producto BOPP/Cast/Coating
    /// </summary>
    public class clsTreatment
    {

        //Atributes

        private int trnt_codsec;
        private string trnt_name;
        private string trnt_abbreviation;
        private Boolean trnt_isForBopp;
        private Boolean trnt_isForCpp;
        private Boolean trnt_isForCoat;


        //Properties

        public int codsec { get { return trnt_codsec; } set { trnt_codsec = value; } }

        public string name { get { return trnt_name; } set { trnt_name = value; } }

        public string abbreviation { get { return trnt_abbreviation; } set { trnt_abbreviation = value; } }

        public Boolean isForBopp { get { return trnt_isForBopp; } set { trnt_isForBopp = value; } }

        public Boolean isForCpp { get { return trnt_isForCpp; } set { trnt_isForCpp = value; } }

        public Boolean isForCoat { get { return trnt_isForCoat; } set { trnt_isForCoat = value; } }

        //Constructor

        public clsTreatment()
        {
            trnt_codsec = 0;
            trnt_name = "";
            trnt_abbreviation = "";
            trnt_isForBopp = false;
            trnt_isForCpp = false;
            trnt_isForCoat = false;
        }
        public clsTreatment(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_treatment where trnt_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trnt_codsec"]);
            this.name = DS.Tables[0].Rows[0]["trnt_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["trnt_abbreviation"].ToString();
            this.isForBopp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["trnt_isForBopp"], DS.Tables[0].Rows[0]["trnt_isForBopp"].GetType().FullName);
            this.isForCpp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["trnt_isForCpp"], DS.Tables[0].Rows[0]["trnt_isForCpp"].GetType().FullName);
            this.isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["trnt_isForCoat"],DS.Tables[0].Rows[0]["trnt_isForCoat"].GetType().FullName);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_treatment (trnt_name,trnt_abbreviation,trnt_isForBopp,trnt_isForCpp,trnt_isForCoat)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "',";
                    queryString += "" + this.isForBopp + ",";
                    queryString += "" + this.isForCpp + ",";
                    queryString += "" + this.isForCoat + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                    
                else
                {
                    queryString += "UPDATE bps_prod_treatment";
                    queryString += " SET ";
                    queryString += "trnt_name = '" + this.name + "',";
                    queryString += "trnt_abbreviation = '" + this.abbreviation + "',";
                    queryString += "trnt_isForBopp = " + this.isForBopp.ToString() + ",";
                    queryString += "trnt_isForCpp = " + this.isForCpp.ToString() + ",";
                    queryString += "trnt_isForCoat = " + this.isForCoat.ToString() + "";
                    queryString += " WHERE trnt_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }

                
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTreatment.save");
                return false;
            }
        }

        public static List<clsTreatment> getList()
        {
            List<clsTreatment> lstTreatment = new List<clsTreatment>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_treatment ORDER BY trnt_abbreviation");

            lstTreatment.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTreatment.Add(new clsTreatment());
                lstTreatment[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trnt_codsec"]);
                lstTreatment[i].name = DS.Tables[0].Rows[i]["trnt_name"].ToString();
                lstTreatment[i].abbreviation = DS.Tables[0].Rows[i]["trnt_abbreviation"].ToString();
                lstTreatment[i].isForBopp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["trnt_isForBopp"], DS.Tables[0].Rows[i]["trnt_isForBopp"].GetType().FullName);
                lstTreatment[i].isForCpp = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["trnt_isForCpp"],DS.Tables[0].Rows[i]["trnt_isForCpp"].GetType().FullName);
                lstTreatment[i].isForCoat = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["trnt_isForCoat"], DS.Tables[0].Rows[i]["trnt_isForCoat"].GetType().FullName);
            }

            return lstTreatment;
        }

        public static List<clsTreatment> getListForBopp()
        {
            List<clsTreatment> lstTreatmentForBopp = new List<clsTreatment>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_treatment where trnt_isForBopp = 1 ORDER BY trnt_abbreviation");

            lstTreatmentForBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTreatmentForBopp.Add(new clsTreatment());
                lstTreatmentForBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trnt_codsec"]);
                lstTreatmentForBopp[i].name = DS.Tables[0].Rows[i]["trnt_name"].ToString();
                lstTreatmentForBopp[i].abbreviation = DS.Tables[0].Rows[i]["trnt_abbreviation"].ToString();

            }

            return lstTreatmentForBopp;
        }

        public static List<clsTreatment> getListForCast()
        {
            List<clsTreatment> lstTreatmentForCast = new List<clsTreatment>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_treatment where trnt_isForCpp = 1 ORDER BY trnt_abbreviation");

            lstTreatmentForCast.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTreatmentForCast.Add(new clsTreatment());
                lstTreatmentForCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trnt_codsec"]);
                lstTreatmentForCast[i].name = DS.Tables[0].Rows[i]["trnt_name"].ToString();
                lstTreatmentForCast[i].abbreviation = DS.Tables[0].Rows[i]["trnt_abbreviation"].ToString();

            }

            return lstTreatmentForCast;
        }

        public static List<clsTreatment> getListForCoating()
        {
            List<clsTreatment> lstTreatmentForCoating = new List<clsTreatment>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_treatment where trnt_isForCoat = 1 ORDER BY trnt_abbreviation");

            lstTreatmentForCoating.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTreatmentForCoating.Add(new clsTreatment());
                lstTreatmentForCoating[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trnt_codsec"]);
                lstTreatmentForCoating[i].name = DS.Tables[0].Rows[i]["trnt_name"].ToString();
                lstTreatmentForCoating[i].abbreviation = DS.Tables[0].Rows[i]["trnt_abbreviation"].ToString();

            }

            return lstTreatmentForCoating;
        }

        public override string ToString()
        {
            return "[" + this.abbreviation + "]" + " " + this.name;
        }




    }
}
