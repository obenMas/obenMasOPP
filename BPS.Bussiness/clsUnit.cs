using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los tipos de unidades para todos los diferentes productos
    /// </summary>
    public class clsUnit
    {
        //Atributes

        private int unit_codsec;
        private string unit_name;
        private string unit_symbol;


        //Properties

        public int codsec { get { return unit_codsec; } set { unit_codsec = value; } }

        public string name { get { return unit_name; } set { unit_name = value; } }

        public string symbol { get { return unit_symbol; } set { unit_symbol = value; } }


        //Constructor

        public clsUnit()
        {
        unit_codsec = 0;
        unit_name = "";
        unit_symbol = "";
        }

        public clsUnit(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_unit where unit_codsec = " + codsec.ToString());
           
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["unit_codsec"]);
            this.name = DS.Tables[0].Rows[0]["unit_name"].ToString();
            this.symbol = DS.Tables[0].Rows[0]["unit_symbol"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_unit (unit_name, unit_symbol)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.symbol + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_unit";
                    queryString += " SET ";
                    queryString += "unit_name = '" + this.name + "',";
                    queryString += "unit_symbol = '" + this.symbol + "'";
                    queryString += " WHERE unit_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsUnit.save");
                return false;
            }
        }

        public static List<clsUnit> getList()
        {
            List<clsUnit> lstUnits = new List<clsUnit>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_unit ORDER BY unit_name");

            lstUnits.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstUnits.Add(new clsUnit());
                lstUnits[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["unit_codsec"]);
                lstUnits[i].name = DS.Tables[0].Rows[i]["unit_name"].ToString();
                lstUnits[i].symbol = DS.Tables[0].Rows[i]["unit_symbol"].ToString();
            }

            return lstUnits;
        }

        public override string ToString()
        {
            return this.name + "(" + this.symbol + ")";
        }
    }
}
