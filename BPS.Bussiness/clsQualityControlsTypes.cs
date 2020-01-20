using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using BPS.Bussiness;

namespace BPS.Business
{
    /// <summary>
    /// Clase que administra los tipos de controles de Calidad
    /// </summary>
    public class clsQualityControlsTypes
    {
        //Atributes
        private int qct_codsec;
        private string qct_name;

        //Properties

        public int codsec { get { return qct_codsec; } set { qct_codsec = value; } }

        public string name { get { return qct_name; } set { qct_name = value; } }

        //Constructor

        public clsQualityControlsTypes()
        {
        qct_codsec = 0;
        qct_name = string.Empty; 
        }

        public clsQualityControlsTypes(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spQualityControlsTypesByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["qct_codsec"]);
                name = DS.Tables[0].Rows[0]["qct_name"].ToString();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_qualitycontrolstypes (qct_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name.ToString() + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_qualitycontrols";
                    queryString += " SET ";
                    queryString += "qc_name = " + this.name.ToString() + "";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControlsTypes.save");
                return false;
            }
        }

        public static List<clsQualityControlsTypes> getList()
        {
            List<clsQualityControlsTypes> lstQualityControlsTypes = new List<clsQualityControlsTypes>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_qualitycontrolstypes order by qct_name asc");

            lstQualityControlsTypes.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstQualityControlsTypes.Add(new clsQualityControlsTypes());
                lstQualityControlsTypes[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qct_codsec"]);
                lstQualityControlsTypes[i].name = DS.Tables[0].Rows[i]["qct_name"].ToString();
            }
            return lstQualityControlsTypes;
        }

        public string QualityControlTypeNameByCodsec(int codsec)
        {
            string qualityCTName = string.Empty;
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT qct_name FROM bps_prod_qualityControlsTypes where qct_codsec = " + codsec + "order by qct_name asc");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                qualityCTName = DS.Tables[0].Rows[i]["qct_name"].ToString();
            }
            return qualityCTName;
        }

        public int QualityControlTypeCodsecByName(string name)
        {
            int qualityCodsec = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT qct_codsec FROM bps_prod_qualityControlsTypes where qct_name = '" +name+ "' order by qct_name asc");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                qualityCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qct_codsec"]);
            }
            return qualityCodsec;
        }



    }

}
