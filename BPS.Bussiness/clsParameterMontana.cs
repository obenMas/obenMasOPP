using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsParameterMontana : clsMyHerency
    {
        public clsParameterMontana()
        {
            codsec = 0;
            fkCast = 0;
            fkBopp = 0;
            notes = "";
        }

        public clsParameterMontana(int codsec)
        {
            this.load(codsec);
        }

        private void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_parameterm WHERE prmm_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_codsec"]);
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkBopp"]);
            this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkCast"]);
            this.notes = DS.Tables[0].Rows[0]["prmm_notes"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_parameterm (prmm_fkBopp,prmm_fkCast,prmm_notes)";
                    queryString += " VALUES (";
                    queryString += this.fkBopp.ToString() + ",";
                    queryString += this.fkCast.ToString() + ",'";
                    queryString += this.notes.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_parameterm";
                    queryString += " SET ";
                    queryString += "prmm_fkBopp = " + this.fkBopp.ToString() + ",";
                    queryString += "prmm_fkCast = " + this.fkCast.ToString() + ",";
                    queryString += "prmm_notes = '" + this.notes.ToString() + "'";
                    queryString += " WHERE prmm_codsec = " + this.codsec.ToString();
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsParameterMontana.save");
                return false;
            }
        }

        public static clsParameterMontana getDescriptionByBopp (int boppCodsec)
        {
            clsParameterMontana objParametersMontana = new clsParameterMontana();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_parameterm WHERE prmm_fkBopp = " + boppCodsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                objParametersMontana.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_codsec"]);
                objParametersMontana.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkBopp"]);
                objParametersMontana.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkCast"]);
                objParametersMontana.notes = DS.Tables[0].Rows[0]["prmm_notes"].ToString();
            }
            return objParametersMontana;
        }

        public static clsParameterMontana getDescriptionByCast (int castCodsec)
        {
            clsParameterMontana objParametersMontana = new clsParameterMontana();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_parameterm WHERE prmm_fkCast = " + castCodsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                objParametersMontana.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_codsec"]);
                objParametersMontana.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkBopp"]);
                objParametersMontana.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prmm_fkCast"]);
                objParametersMontana.notes = DS.Tables[0].Rows[0]["prmm_notes"].ToString();
            }
            return objParametersMontana;
        }

        public static List<clsParameterMontana> getList()
        {
            List<clsParameterMontana> lstParameters = new List<clsParameterMontana>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_parameterm ORDER BY prmm_codsec DESC");

            lstParameters.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstParameters.Add(new clsParameterMontana());
                lstParameters[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prmm_codsec"]);
                lstParameters[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prmm_fkBopp"]);
                lstParameters[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prmm_fkCast"]);
                lstParameters[i].notes = DS.Tables[0].Rows[i]["prmm_notes"].ToString();
            }

            return lstParameters;
        }

        public override string ToString()
        {
            return this.notes;
        }
    }
}
