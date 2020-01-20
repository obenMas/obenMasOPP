using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para administrar los defectos posibles en la muestra de termoformado
    /// </summary>
    public class clsThermDefects
    {
        //Atributes

        private int thermdefect_codsec;
        private string thermdefect_name;
        private string thermdefect_description;

        //Properties

        public int codsec { get { return thermdefect_codsec; } set { thermdefect_codsec = value; } }

        public string name { get { return thermdefect_name; } set { thermdefect_name = value; } }

        public string description { get { return thermdefect_description; } set { thermdefect_description = value; } }


          //Constructor

        public clsThermDefects()
        {
            thermdefect_codsec = 0;
            thermdefect_name = "";
            thermdefect_description = "";

        }

         public clsThermDefects(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermdefects where thermdefect_codsec =  " + codsec.ToString());
            
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["thermdefect_codsec"]);
            this.name = DS.Tables[0].Rows[0]["thermdefect_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["thermdefect_description"].ToString();

        }

        
        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_thermdefects (thermdefect_name, thermdefect_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                    
                }
                else
                {
                    queryString += "UPDATE bps_prod_thermdefects";
                    queryString += " SET ";
                    queryString += "thermdefect_name =  '" + this.name.ToString() + "',";
                    queryString += "thermdefect_description =  '" + this.description.ToString() + "'";
                    queryString += " WHERE thermdefect_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermDefects.save");
                return false;
            }
        }

        public static List<clsThermDefects> getList()
        {
            List<clsThermDefects> lstThermDefects = new List<clsThermDefects>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermdefects order by thermdefect_name asc");

            lstThermDefects.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstThermDefects.Add(new clsThermDefects());
                lstThermDefects[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["thermdefect_codsec"]);
                lstThermDefects[i].name = DS.Tables[0].Rows[i]["thermdefect_name"].ToString();
                lstThermDefects[i].description = DS.Tables[0].Rows[i]["thermdefect_description"].ToString();
                
            }

            return lstThermDefects;
        }


    }
}
