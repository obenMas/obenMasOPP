using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los tipos de core para productos BOPP/Cast/Coating
    /// </summary>
    public class clsCore
    {
        //Atributes

        private int core_codsec;
        private string core_name;
        private int core_value;
        private double core_weigthPerMilimeter;
        private double core_weigthPerMilimeter2;

        //Properties

        public int codsec { get { return core_codsec; } set { core_codsec = value; } }

        public string name { get { return core_name; } set { core_name = value; } }

        public int value { get { return core_value; } set { core_value = value; } }

        public double weigthPerMilimeter { get { return core_weigthPerMilimeter; } set { core_weigthPerMilimeter = value; } }

        public double weigthPerMilimeter2 { get { return core_weigthPerMilimeter2; } set { core_weigthPerMilimeter2 = value; } }


        //Constructor

        public clsCore()
        { 
            core_codsec = 0;
            core_name = "";
            core_value = 0;
            core_weigthPerMilimeter = 0;
            core_weigthPerMilimeter2 = 0;
        }

        public clsCore(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_core where core_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["core_codsec"]);
                this.name = DS.Tables[0].Rows[0]["core_name"].ToString();
                this.value = Convert.ToInt32(DS.Tables[0].Rows[0]["core_value"]);
                this.weigthPerMilimeter = Convert.ToDouble(DS.Tables[0].Rows[0]["core_weigthPerMilimeter"]);
                this.weigthPerMilimeter2 = Convert.ToDouble(DS.Tables[0].Rows[0]["core_weigthPerMilimeter2"]);
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_core (core_name, core_value,core_weigthPerMilimeter)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += this.value.ToString() + ",";
                    queryString += this.weigthPerMilimeter.ToString() + ",";
                    queryString += this.weigthPerMilimeter2.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_core";
                    queryString += " SET ";
                    queryString += "core_name = '" + this.name + "',";
                    queryString += "core_value = " + this.value.ToString() + ",";
                    queryString += "core_weigthPerMilimeter = " + this.weigthPerMilimeter.ToString() + ",";
                    queryString += "core_weigthPerMilimeter2 = " + this.weigthPerMilimeter2.ToString() + "";
                    queryString += " WHERE core_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCore.save");
                return false;
            }
        }

        public static List<clsCore> getList()
        {
            List<clsCore> lstCore = new List<clsCore>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_core order by core_name asc");

            lstCore.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCore.Add(new clsCore());
                lstCore[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["core_codsec"]);
                lstCore[i].name = DS.Tables[0].Rows[i]["core_name"].ToString();
                lstCore[i].value = Convert.ToInt32(DS.Tables[0].Rows[i]["core_value"]);
                lstCore[i].weigthPerMilimeter = Convert.ToDouble(DS.Tables[0].Rows[i]["core_weigthPerMilimeter"]);
                lstCore[i].weigthPerMilimeter2 = Convert.ToDouble(DS.Tables[0].Rows[i]["core_weigthPerMilimeter2"]);
                
            }

            return lstCore;
        }
        public override string ToString()
        {
            return this.name;
        }
    }

}
