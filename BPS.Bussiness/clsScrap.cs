using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsScrap
    {
        // Atributes
        private int sc_codsec;
        private string sc_name;
        private string sc_abr;
        // Properties 

        public int codsec { get { return sc_codsec; } set { sc_codsec = value; } }
        public string name { get { return sc_name; } set { sc_name = value; } }
        public string abr { get { return sc_abr; } set { sc_abr = value; } }
 
        // Constructor

        public clsScrap() {
            codsec = 0;
            name = "";
            abr = "";
        }
        public clsScrap(string nscrap)
        {
            this.load(nscrap);
        }
        public clsScrap(int codsec)
        {
            this.load(codsec);
        }
        // Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrap WHERE sc_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0) {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sc_codsec"]);
                this.name = Convert.ToString(DS.Tables[0].Rows[0]["sc_name"]);
                this.abr = Convert.ToString(DS.Tables[0].Rows[0]["sc_abr"]);
            }


        }
        // Esto se denomina sobrecarga, tener 2 procesos iguales con diferente parametro de entrada.

        public void load(string nscrap)
        {
            DataSet DS = new DataSet();
            // RECORDAR si le paso texto en el matching del where, ponerle ' TEXTO ' luego del campo con el que quiero matchear.

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrap WHERE sc_name = '" + nscrap.ToString() + "'");

           if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sc_codsec"]);
                this.name = Convert.ToString(DS.Tables[0].Rows[0]["sc_name"]);
                this.abr = Convert.ToString(DS.Tables[0].Rows[0]["sc_abr"]);
            }

        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_scrap (sc_name,sc_abr)";
                    queryString += "VALUES (";
                    queryString += this.name.ToString() + ", ";
                    queryString += this.abr.ToString() + ") ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_scrap (sc_name,sc_abr)";
                    queryString += " SET ";
                    queryString += " sc_name = " + this.name.ToString() + ",";
                    queryString += " sc_abr = " + this.abr.ToString() + "";
                    queryString += " WHERE sc_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex){
                clsLog.addLog(ex, 3, "clsScrap.save");
                return false;
            }
        }

        public static List<clsScrap> getList()
        {
            List<clsScrap> lstScrap = new List<clsScrap>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrap");

            lstScrap.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstScrap.Add(new clsScrap());
                lstScrap[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sc_codsec"]);
                lstScrap[i].name = DS.Tables[0].Rows[i]["sc_name"].ToString();
                lstScrap[i].abr = DS.Tables[0].Rows[i]["sc_abr"].ToString();

            }

            return lstScrap;
        }

    }
}
