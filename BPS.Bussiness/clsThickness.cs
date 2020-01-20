using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo del Espesor para producto BOPP/Cast/Coating
    /// </summary>
    public class clsThickness
    {
        //Atributes

        private int thick_codsec;
        private int thick_value;


        //Properties

        public int codsec { get { return thick_codsec; } set { thick_codsec = value; } }

        public int value { get { return thick_value; } set { thick_value = value; } }

        //Constructor

        public clsThickness()
        {
            thick_codsec = 0;
            thick_value = 0;
        }
        public clsThickness(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thickness where thick_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["thick_codsec"]);
            this.value = Convert.ToInt32(DS.Tables[0].Rows[0]["thick_value"]);
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_thickness (thick_value)";
                    queryString += " VALUES (";
                    queryString += "'" + this.value.ToString() + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_thickness";
                    queryString += " SET ";
                    queryString += "thick_value = '" + this.value.ToString() + "'";
                    queryString += " WHERE thick_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThickness.save");
                return false;
            }
        }

        public static List<clsThickness> getList()
        {
            List<clsThickness> lstThickness = new List<clsThickness>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thickness ORDER BY thick_value");

            lstThickness.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThickness.Add(new clsThickness());
                lstThickness[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["thick_codsec"]);
                lstThickness[i].value = Convert.ToInt32(DS.Tables[0].Rows[i]["thick_value"]);                
            }

            return lstThickness;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
