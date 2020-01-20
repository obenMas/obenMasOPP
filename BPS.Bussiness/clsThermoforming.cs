using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los productos de termoformado
    /// </summary>
    public class clsThermoforming
    {
        //Atributes

        private int therm_codsec;
        private int therm_fkColor;
        private string therm_colorName;
        private string therm_colorCode;
        private int therm_fkOunce;
        private double therm_ounceValue;
        private string therm_name;
        private string therm_code;
        private double therm_gramsperunit;
        private Boolean therm_isspecial;

        //Properties

        public int codsec { get { return therm_codsec; } set { therm_codsec = value; } }

        public int fkColor { get { return therm_fkColor; } set { therm_fkColor = value; } }

        public string colorName { get { return therm_colorName; } set { therm_colorName = value; } }

        public string colorCode { get { return therm_colorCode; } set { therm_colorCode = value; } }

        public int fkOunce { get { return therm_fkOunce; } set { therm_fkOunce = value; } }

        public double ounceValue { get { return therm_ounceValue; } set { therm_ounceValue = value; } }

        public string name { get { return therm_name; } set { therm_name = value; } }

        public string code { get { return therm_code; } set { therm_code = value; } }

        public double gramsperunit { get { return therm_gramsperunit; } set { therm_gramsperunit = value; } }

        public Boolean isspecial { get { return therm_isspecial; } set { therm_isspecial = value; } }

        //Constructor

        public clsThermoforming()
        {
            therm_codsec = 0;
            therm_fkColor = 0;
            therm_colorName = "";
            therm_colorCode = "";
            therm_fkOunce = 0;
            therm_ounceValue = 0;
            therm_name = "";
            therm_code = "";
            therm_gramsperunit = 0;
            therm_isspecial = false;
        }

        public clsThermoforming(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwthermoforming where therm_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["therm_codsec"]);
            this.fkColor = Convert.ToInt32(DS.Tables[0].Rows[0]["therm_fkColor"]);
            this.colorName = DS.Tables[0].Rows[0]["therm_colorName"].ToString();
            this.colorCode = DS.Tables[0].Rows[0]["therm_colorCode"].ToString();
            this.fkOunce = Convert.ToInt32(DS.Tables[0].Rows[0]["therm_fkOunce"]);
            this.ounceValue = Convert.ToDouble(DS.Tables[0].Rows[0]["therm_ounceValue"]);
            this.name = DS.Tables[0].Rows[0]["therm_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["therm_code"].ToString();
            this.gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[0]["therm_gramsperunit"]);
            this.isspecial = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["therm_isspecial"], DS.Tables[0].Rows[0]["therm_isspecial"].GetType().FullName);
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_thermoforming (therm_fkColor, therm_fkOunce, therm_name, therm_code, therm_gramsperunit, therm_isspecial)";
                    queryString += " VALUES (";
                    queryString += this.fkColor + ",";
                    queryString += this.fkOunce + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "'" + this.gramsperunit.ToString() + "',";
                    queryString += this.isspecial.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_thermoformer";
                    queryString += " SET ";
                    queryString += "therm_fkColor = " + this.fkColor + ",";
                    queryString += "therm_fkOunce = " + this.fkOunce + ",";
                    queryString += "therm_name = '" + this.name + "',";
                    queryString += "therm_code = '" + this.code + "',";
                    queryString += "therm_gramsperunit = " + this.gramsperunit + ",";
                    queryString += "therm_isspecial = '" + this.gramsperunit + "'";
                    queryString += " WHERE therm_codsec = " + this.codsec + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermoforming.save");
                return false;
            }
        }

        public static List<clsThermoforming> getList()
        {
            List<clsThermoforming> lstThermoforming = new List<clsThermoforming>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwthermoforming order by therm_name asc");

            lstThermoforming.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThermoforming.Add(new clsThermoforming());
                lstThermoforming[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["therm_codsec"]);
                lstThermoforming[i].fkColor = Convert.ToInt32(DS.Tables[0].Rows[i]["therm_fkColor"]);
                lstThermoforming[i].colorName = DS.Tables[0].Rows[i]["therm_colorName"].ToString();
                lstThermoforming[i].colorCode = DS.Tables[0].Rows[i]["therm_colorCode"].ToString();
                lstThermoforming[i].fkOunce = Convert.ToInt32(DS.Tables[0].Rows[i]["therm_fkOunce"]);
                lstThermoforming[i].ounceValue = Convert.ToDouble(DS.Tables[0].Rows[i]["therm_ounceValue"]);
                lstThermoforming[i].name = DS.Tables[0].Rows[i]["therm_name"].ToString();
                lstThermoforming[i].code = DS.Tables[0].Rows[i]["therm_code"].ToString();
                lstThermoforming[i].gramsperunit = Convert.ToDouble(DS.Tables[0].Rows[i]["therm_gramsperunit"]);
                lstThermoforming[i].isspecial = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["therm_isspecial"], DS.Tables[0].Rows[i]["therm_isspecial"].GetType().FullName);
            }

            return lstThermoforming;
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
