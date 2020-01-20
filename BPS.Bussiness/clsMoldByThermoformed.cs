using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra que moldes se usan por termoformadora
    /// </summary>
    public class clsMoldByThermoformed
    {
        //Atributes

        private int moldbytherm_codsec;
        private int moldbytherm_fkMold;
        private string moldbytherm_moldName;
        private int moldbytherm_fkThermoformer;
        private string moldbytherm_thermoformerName;

        //Properties

        public int codsec { get { return moldbytherm_codsec; } set { moldbytherm_codsec = value; } }

        public int fkMold { get { return moldbytherm_fkMold; } set { moldbytherm_fkMold = value; } }

        public string moldName { get { return moldbytherm_moldName; } set { moldbytherm_moldName = value; } }

        public int fkThermoformer { get { return moldbytherm_fkThermoformer; } set { moldbytherm_fkThermoformer = value; } }

        public string thermoformerName { get { return moldbytherm_thermoformerName; } set { moldbytherm_thermoformerName = value; } }

        //Constructor

        public clsMoldByThermoformed()
        {
            moldbytherm_codsec = 0;
            moldbytherm_fkMold = 0;
            moldbytherm_moldName = "";
            moldbytherm_fkThermoformer = 0;
            moldbytherm_thermoformerName = "";
        }

        public clsMoldByThermoformed(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("select mbyt.moldbytherm_codsec as moldbytherm_codsec, mold.mold_codsec as moldbytherm_fkMold, mold.mold_name as moldbytherm_moldName, therm.ther_codsec as moldbytherm_fkThermoformer, therm.ther_name as moldbytherm_thermoformerName from bps_prod_mold mold, bps_prod_thermoformer therm, bps_prod_moldbythermoformed mbyt where mbyt.moldbytherm_fkMold = mold.mold_codsec and mbyt.moldbytherm_fkThermoformed = therm.ther_codsec and mbyt.moldbytherm_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["moldbytherm_codsec"]);
            this.fkMold = Convert.ToInt32(DS.Tables[0].Rows[0]["moldbytherm_fkMold"]);
            this.moldName = DS.Tables[0].Rows[0]["moldbytherm_moldName"].ToString();
            this.fkThermoformer = Convert.ToInt32(DS.Tables[0].Rows[0]["moldbytherm_fkThermoformer"]);
            this.thermoformerName = DS.Tables[0].Rows[0]["moldbytherm_thermoformerName"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_moldbythermoformed (moldbytherm_fkMold, moldbytherm_fkThermoformed)";
                    queryString += " VALUES (";
                    queryString += this.fkMold + ",";
                    queryString += this.fkThermoformer + ",";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_moldbythermoformed";
                    queryString += " SET ";
                    queryString += "moldbytherm_fkMold = " + this.fkMold + ",";
                    queryString += "moldbytherm_fkThermoformed = " + this.fkThermoformer + ",";
                    queryString += " WHERE moldbytherm_codsec = " + this.codsec + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMoldByThermoformed.save");
                return false;
            }
        }
    }
}
