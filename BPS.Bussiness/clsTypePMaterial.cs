using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsTypePMaterial
    {
        // Attribute
        private int tpm_codsec;
        private string tpm_description;

        // Properties
        public int codsec{get { return tpm_codsec; }set { tpm_codsec = value; }}
        public string description{get { return tpm_description; }set { tpm_description = value; }}

        // Constructor

        public clsTypePMaterial()
        {
            codsec = 0;
            description = "";
        }

        public clsTypePMaterial(string desc)
        {
            this.load(desc);
        }

        // Methods

        public void load(string desc)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_typepMaterial WHERE tpm_description = " + desc.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tpm_codsec"]);
                this.description = DS.Tables[0].Rows[0]["tpm_description"].ToString();
            }
        }

        public bool save()
        {
            string query = "";
            try
            {
                if (this.codsec == 0)
                {
                    query = "INSERT INTO bps_prod_typepMaterial(tpm_description)";
                    query += " VALUES( '";
                    query += this.description.ToString() + ");";  
                }
                else
                {
                    query = "UPDATE bps_prod_typepMaterial";
                    query += " SET";
                    query += "tpm_description = '" + this.description.ToString() + "'";
                }

                return clsConnection.executeQuery(query);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex,3,"clsTypePMaterial.save()");
                return false;
            }
        }

    }
}
