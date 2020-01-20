using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los tipos de diametro para productos BOPP/Cast/Coating
    /// </summary>
    public class clsDiameter
    {
        //Atributes

        private int dtr_codsec;
        private string dtr_name;
        private string dtr_abbreviation;
        private double dtr_value;

        //Properties

        public int codsec { get { return dtr_codsec; } set { dtr_codsec = value; } }

        public string name { get { return dtr_name; } set { dtr_name = value; } }

        public string abbreviation { get { return dtr_abbreviation; } set { dtr_abbreviation = value; } }

        public double value { get { return dtr_value; } set { dtr_value = value; } }

        //Constructor

        public clsDiameter()
        { 
        dtr_codsec = 0;
        dtr_name = "";
        dtr_abbreviation = "";
        dtr_value = 0;
        
        }

        public clsDiameter(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_diameter where dtr_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["dtr_codsec"]);
            this.name = DS.Tables[0].Rows[0]["dtr_name"].ToString();
            this.abbreviation = DS.Tables[0].Rows[0]["dtr_abbreviation"].ToString();
            this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["dtr_value"]);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_diameter (dtr_name, dtr_abbreviation, dtr_value)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.abbreviation + "',";
                    queryString += this.value.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_diameter";
                    queryString += " SET ";
                    queryString += "dtr_name = '" + this.name + "',";
                    queryString += "dtr_abbreviation = '" + this.abbreviation + "',";
                    queryString += "dtr_value = " + this.value.ToString();
                    queryString += " WHERE dtr_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDiameter.save");
                return false;
            }
        }

        public static List<clsDiameter> getList()
        {
            List<clsDiameter> lstDiameter = new List<clsDiameter>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_diameter order by dtr_name asc");

            lstDiameter.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstDiameter.Add(new clsDiameter());
                lstDiameter[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtr_codsec"]);
                lstDiameter[i].name = DS.Tables[0].Rows[i]["dtr_name"].ToString();
                lstDiameter[i].abbreviation = DS.Tables[0].Rows[i]["dtr_abbreviation"].ToString();
                lstDiameter[i].value = Convert.ToInt32(DS.Tables[0].Rows[i]["dtr_value"]);

            }

            return lstDiameter;
        }
        public override string ToString()
        {
            return "(" + this.abbreviation + ") " + this.name;
        }
    }
}
