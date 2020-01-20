using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los colores de productos termoformados
    /// </summary>
    public class clsColor
    {
           
        //Atributes

        private int color_codsec;
        private string color_name;
        private string color_code;


        //Properties

        public int codsec { get { return color_codsec; } set { color_codsec = value; } }

        public string name { get { return color_name; } set { color_name = value; } }

        public string code { get { return color_code; } set { color_code = value; } }

        


        //Constructor

        public clsColor()
        {
            color_codsec = 0;
            color_name = "";
            color_code = "";
        }

        public clsColor(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_color where color_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["color_codsec"]);
            this.name = DS.Tables[0].Rows[0]["color_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["color_code"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_color (color_name, color_code)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_color";
                    queryString += " SET ";
                    queryString += "color_name = '" + this.name + "',";
                    queryString += "color_code = '" + this.code + "'";
                    queryString += " WHERE color_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;                
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsColor.save");
                return false;
            }

        }

        public static List<clsColor> getList()
        {
            List<clsColor> lstColor = new List<clsColor>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_color order by color_name asc");

            lstColor.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstColor.Add(new clsColor());
                lstColor[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["color_codsec"]);
                lstColor[i].name = DS.Tables[0].Rows[i]["color_name"].ToString();
                lstColor[i].code = DS.Tables[0].Rows[i]["color_code"].ToString();
               
            }

            return lstColor;
        }

        public override string ToString()
        {
            return this.name;
        }


    }
}
