using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using BPS.Bussiness;
using BPS.Business;


namespace BPS.Business
{
    /// <summary>
    /// Clase que administra los controles de Calidad
    /// </summary>
    public class clsQualityControls
    {
        //Atributes
        private int qc_codsec;
        private string qc_name;
        private int qc_fkQualityControlType;
        private string qc_unity;
        private string qc_norm;

        //Properties

        public int codsec { get { return qc_codsec; } set { qc_codsec = value; } }

        public string name { get { return qc_name; } set { qc_name = value; } }

        public int fkQualityControlType { get { return qc_fkQualityControlType; } set { qc_fkQualityControlType = value; } }

        public string unity { get { return qc_unity; } set { qc_unity = value; } }

        public string norm { get { return qc_norm; } set { qc_norm = value; } }
        
        //Constructor

        public clsQualityControls()
        {
        qc_codsec = 0;
        qc_name = string.Empty;
        qc_fkQualityControlType = 0;
        qc_unity = string.Empty;
        qc_norm = string.Empty;

        }

        public clsQualityControls(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spQualityControlsByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["qc_codsec"]);
                this.fkQualityControlType = Convert.ToInt32(DS.Tables[0].Rows[0]["qc_fkQualityControlType"]);
                this.name = DS.Tables[0].Rows[0]["qc_name"].ToString();
                this.unity = DS.Tables[0].Rows[0]["qc_unit"].ToString();
                this.norm = DS.Tables[0].Rows[0]["qc_norm"].ToString();
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
                    queryString += "INSERT INTO bps_prod_qualitycontrols (qc_fkQualityControlType,qc_name,qc_unit,qc_norm)";
                    queryString += " VALUES (";
                    queryString += this.fkQualityControlType + ",";
                    queryString += "'" + this.name.ToString() + "',";
                    queryString += "'" + this.unity.ToString() + "',";
                    queryString += "'" + this.norm.ToString() + "'";
                    queryString += ");";

                    if (clsConnection.executeQuery(queryString))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    queryString += "UPDATE bps_prod_qualitycontrols";
                    queryString += " SET ";
                    queryString += "qc_fkQualityControlType = " + this.fkQualityControlType + ",";
                    queryString += "qc_name = '" + this.name.ToString() + "',";
                    queryString += "qc_unit = '" + this.unity.ToString() + "',";
                    queryString += "qc_norm = '" + this.norm.ToString() + "'";
                    queryString += " WHERE qc_codsec = " + this.codsec;
                }
                if (clsConnection.executeQuery(queryString))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControls.save");
                return false;
            }
        }


        public bool save(int codsec,string qcName,string qcUnit,string qcNorm)
        {
            try
            {
                string queryString = "";

                if (codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_qualitycontrols (qc_fkQualityControlType,qc_name,qc_unit,qc_norm)";
                    queryString += " VALUES (";
                    queryString += "'" + qcName.ToString() + "',";
                    queryString += "'" + qcUnit.ToString() + "',";
                    queryString += "'" + qcNorm.ToString() + "'";
                    queryString += ");";
                    if (clsConnection.executeQuery(queryString))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    queryString += "UPDATE bps_prod_qualitycontrols";
                    queryString += " SET ";
                    queryString += "qc_name = '" + qcName.ToString() + "',";
                    queryString += "qc_unit = '" + qcUnit.ToString() + "',";
                    queryString += "qc_norm = '" + qcNorm.ToString() + "'";
                    queryString += " WHERE qc_codsec = " + this.codsec;
                    if (clsConnection.executeQuery(queryString))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControls.save");
                return false;
            }
        }

        public static List<clsQualityControls> getList()
        {
            List<clsQualityControls> lstQualityControls = new List<clsQualityControls>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_qualitycontrols order by qc_name asc");

            lstQualityControls.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstQualityControls.Add(new clsQualityControls());
                lstQualityControls[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qc_codsec"]);
                lstQualityControls[i].name = DS.Tables[0].Rows[i]["qc_name"].ToString();
                lstQualityControls[i].fkQualityControlType = Convert.ToInt32(DS.Tables[0].Rows[i]["qc_fkQualityControlType"]);
                lstQualityControls[i].unity = DS.Tables[0].Rows[i]["qc_unit"].ToString();
                lstQualityControls[i].norm = DS.Tables[0].Rows[i]["qc_norm"].ToString();
            }
            return lstQualityControls;
        }

        public static int codsecByQualityControlName(string qualityCtrlName)
        {
            DataSet DS = new DataSet();
            int codsec = 0;

            DS = clsConnection.getDataSetResult("SELECT  QC.qc_codsec FROM bps_prod_qualitycontrols AS QC WHERE QC.qc_name = '"+qualityCtrlName.ToString()+"'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qc_codsec"]);
            }
            return codsec;

        }


        public static string nameByQualityControlCodsec(int qualityCtrlCodsec)
        {
            DataSet DS = new DataSet();
            string nameControl = string.Empty;

            DS = clsConnection.getDataSetResult("SELECT  QC.qc_name FROM bps_prod_qualitycontrols AS QC WHERE QC.qc_codsec = " +qualityCtrlCodsec);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                nameControl = DS.Tables[0].Rows[i]["qc_name"].ToString();
            }
            return nameControl;

        }

        public static bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_qualitycontrols WHERE ";
                queryString += "qc_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControls.save");
                return false;
            }
        }


    }
}
