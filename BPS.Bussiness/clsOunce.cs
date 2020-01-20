using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las onzas de productos termoformados
    /// </summary>
    public class clsOunce
    {
        //Atributes

        private int onc_codsec;
        private double onc_value;
        

        //Properties

        public int codsec { get { return onc_codsec; } set { onc_codsec = value; } }

        public double value { get { return onc_value; } set { onc_value = value; } }
        


        //Constructor

        public clsOunce()
        {
            onc_codsec = 0;
            onc_value = 0;
        }

        public clsOunce(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_ounce where onc_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["onc_codsec"]);
            this.value = Convert.ToDouble(DS.Tables[0].Rows[0]["onc_value"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_ounce (onc_value)";
                    queryString += " VALUES (";
                    queryString += "'" + this.value + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_ounce";
                    queryString += " SET ";
                    queryString += "onc_value = '" + this.value + "'";
                    queryString += " WHERE onc_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;                
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsOunce.save");
                return false;
            }

        }

        public static List<clsOunce> getList()
        {
            List<clsOunce> lstOunce = new List<clsOunce>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_ounce order by onc_value asc");

            lstOunce.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstOunce.Add(new clsOunce());
                lstOunce[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["onc_codsec"]);
                lstOunce[i].value = Convert.ToDouble(DS.Tables[0].Rows[i]["onc_value"]);
                               
            }

            return lstOunce;
        }

        public override string ToString()
        {
            return this.onc_value.ToString();
        }

       
    }
}
