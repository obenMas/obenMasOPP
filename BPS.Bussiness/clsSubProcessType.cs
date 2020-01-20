using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los tipos de subprocesos para film (Rebobinado,Corte Secundario,Metalizado)
    /// </summary>
    public class clsSubProcessType
    {
        //Atributes

        private int spt_codsec;
        private string spt_name;
        private string spt_code;


        //Properties

        public int codsec { get { return spt_codsec; } set { spt_codsec = value; } }

        public string name { get { return spt_name; } set { spt_name = value; } }

        public string code { get { return spt_code; } set { spt_code = value; } }



        //Constructor

        public clsSubProcessType()
        { 
        spt_codsec = 0; 
        spt_name = "";
        spt_code = "";
        }
        public clsSubProcessType(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from bps_prod_subProccessType WHERE spt_codsec = " + codsec);

            if (DS.Tables[0].Rows.Count > 1)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spt_codsec"]);
                this.name = DS.Tables[0].Rows[0]["spt_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["spt_codsec"].ToString();
            }
        }

        public void save()
        {
            string queryString = "";

            if (this.codsec == 0)
            {
                queryString += "INSERT INTO bps_prod_subprocesstype (spt_name, spt_code)";
                queryString += " VALUE (";
                queryString += "'" + this.name + "',";
                queryString += "'" + this.code + "'";
                queryString += ");";
            }
            else
            {
                queryString += "UPDATE bps_prod_subprocesstype";
                queryString += " SET ";
                queryString += "spt_name = '" + this.name + "',";
                queryString += "spt_code = '" + this.code + "'";
                queryString += "WHERE spt_codsec = " + this.codsec + ";";
            }

            clsConnection.executeQuery(queryString);
        }

        public static List<clsSubProcessType> getList()
        {
            List<clsSubProcessType> lstSubProccessType = new List<clsSubProcessType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * from bps_prod_subProccessType ORDER BY spt_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
			{
                lstSubProccessType.Add(new clsSubProcessType());
                lstSubProccessType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spt_codsec"]);
                lstSubProccessType[i].name = DS.Tables[0].Rows[i]["spt_name"].ToString();
                lstSubProccessType[i].code = DS.Tables[0].Rows[i]["spt_codsec"].ToString();
			}

            return lstSubProccessType;
        }
    }
}
