using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Tipos de rollos madres
    /// </summary>
    public class clsTypeMainCoil
    {
        //Atributes

        private int tmcl_codsec;
        private string tmcl_name;
        private string tmcl_description;

        //Properties


        public int codsec { get { return tmcl_codsec; } set { tmcl_codsec = value; } }

        public string name { get { return tmcl_name; } set { tmcl_name = value; } }

        public string description { get { return tmcl_description; } set { tmcl_description = value; } }

        //Constructor

        public clsTypeMainCoil()
        {
            tmcl_codsec = 0;
            tmcl_name = "";
            tmcl_description = "";
        }

        public clsTypeMainCoil(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_typemaincoil where tmcl_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tmcl_codsec"]);
            this.name = DS.Tables[0].Rows[0]["tmcl_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["tmcl_description"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_typemaincoil (tmcl_name, tmcl_description)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_typemaincoil";
                    queryString += " SET ";
                    queryString += "tmcl_name = '" + this.name + "',";
                    queryString += "tmcl_description = '" + this.description + "'";
                    queryString += " WHERE tmcl_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTypeMainCoil.save");
                return false;
            }


        }

        public static List<clsTypeMainCoil> getList()
        {
            List<clsTypeMainCoil> lstTypeMainCoil = new List<clsTypeMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_typemaincoil order by tmcl_name asc");

            lstTypeMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTypeMainCoil.Add(new clsTypeMainCoil());
                lstTypeMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["tmcl_codsec"]);
                lstTypeMainCoil[i].name = DS.Tables[0].Rows[i]["tmcl_name"].ToString();
                lstTypeMainCoil[i].description = DS.Tables[0].Rows[i]["tmcl_description"].ToString();
            }

            return lstTypeMainCoil;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
