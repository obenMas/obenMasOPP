using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja las condiciones de venta / compra
    /// </summary>
    public class clsCommercialCondition
    {
        //Atributes

        private int salcond_codsec;
        private string salcond_name;
        private string salcond_description;


        //Properties

        public int codsec { get { return salcond_codsec; } set { salcond_codsec = value; } }

        public string name { get { return salcond_name; } set { salcond_name = value; } }

        public string description { get { return salcond_description; } set { salcond_description = value; } }

        
        //Constructor

        public clsCommercialCondition()
        { 
        salcond_codsec = 0;
        salcond_name = "";
        salcond_description = "";
        }

        public clsCommercialCondition(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_commercialcondition where salcond_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["salcond_codsec"]);
            this.name = DS.Tables[0].Rows[0]["salcond_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["salcond_description"].ToString();
            
        
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_commercialcondition (salcond_name, salcond_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_commercialcondition";
                    queryString += " SET ";
                    queryString += "salcond_name = '" + this.name + "',";
                    queryString += "salcond_description = '" + this.description + "'";
                    queryString += " WHERE salcond_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCommercialCondition.save");
                return false;
            }
        }

        public static List<clsCommercialCondition> getList()
        {
            List<clsCommercialCondition> lstCommercialCondition = new List<clsCommercialCondition>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_commercialcondition order by salcond_name asc");

            lstCommercialCondition.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCommercialCondition.Add(new clsCommercialCondition());
                lstCommercialCondition[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["salcond_codsec"]);
                lstCommercialCondition[i].name = DS.Tables[0].Rows[i]["salcond_name"].ToString();
                lstCommercialCondition[i].description = DS.Tables[0].Rows[i]["salcond_description"].ToString();
                
            }

            return lstCommercialCondition;
        }
        public override string ToString()
        {
            return this.name;
        }



    }
}
