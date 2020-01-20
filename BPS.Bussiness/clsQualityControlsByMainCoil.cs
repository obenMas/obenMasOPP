using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using BPS.Bussiness;

namespace BPS.Business
{
    /// <summary>
    /// Clase que administra los controles de Bobinas Madre
    /// </summary>
    public class clsQualityControlsByMainCoil
    {
        //Atributes

        private int qcbmc_codsec;
        private int qcbmc_fkMainCoil;
        private int qcbmc_fkQualityControlByFilm;
        private int qcbmc_meditionNumber;
        private string qcbmc_Value;

        //Properties

        public int codsec { get { return qcbmc_codsec; } set { qcbmc_codsec = value; } }

        public int fkMainCoil { get { return qcbmc_fkMainCoil; } set { qcbmc_fkMainCoil = value; } }

        public int fkQualityControlByFilm { get { return qcbmc_fkQualityControlByFilm; } set { qcbmc_fkQualityControlByFilm = value; } }

        public int meditionNumber { get { return qcbmc_meditionNumber; } set { qcbmc_meditionNumber = value; } }

        public string Value { get { return qcbmc_Value; } set { qcbmc_Value = value; } }


        //Constructor

        public clsQualityControlsByMainCoil()
        {
            codsec = 0;
            fkMainCoil = 0;
            fkQualityControlByFilm = 0;
            meditionNumber = 0;
            Value = string.Empty;
        }

        public clsQualityControlsByMainCoil(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            
            DS = clsConnection.getDataSetResult("CALL spQualityControlsByMainCoil(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_codsec"]);
                fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_fkMainCoil"]);
                fkQualityControlByFilm = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_fkQualityControlByFilm"]);
                meditionNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_meditionNumber"]);
                Value = DS.Tables[0].Rows[0]["qcbmc_Value"].ToString();
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
                    queryString += "INSERT INTO bps_prod_qualitycontrolsbymaincoil (qcbmc_fkMainCoil, qcbmc_fkQualityControlByFilm, qcbmc_meditionNumber, qcbmc_Value)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkMainCoil.ToString() + ",";
                    queryString += "" + this.fkQualityControlByFilm.ToString() + ",";
                    queryString += "" + this.meditionNumber.ToString() + ",";
                    queryString += "'" + this.Value.ToString() + "'";
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
                    queryString += "UPDATE bps_prod_qualitycontrolsbymaincoil";
                    queryString += " SET ";
                    queryString += "qcbmc_fkMainCoil = " + this.fkMainCoil.ToString() + ",";
                    queryString += "qcbmc_fkQualityControlByFilm =" + this.fkQualityControlByFilm.ToString() + ",";
                    queryString += "qcbmc_meditionNumber = " + this.meditionNumber.ToString() + ",";
                    queryString += "qcbmc_Value = '" + this.Value.ToString()+"'";
                    queryString += " WHERE qcbmc_codsec = " + this.codsec;
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
                clsLog.addLog(ex, 3, "clsQualityControlsByMainCoil.save");
                return false;
            }
        }

        public static List<clsQualityControlsByMainCoil> getList()
        {
            List<clsQualityControlsByMainCoil> lstQCByMainCoil = new List<clsQualityControlsByMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_qualitycontrolsbymaincoil");

            lstQCByMainCoil.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstQCByMainCoil.Add(new clsQualityControlsByMainCoil());
                lstQCByMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_codsec"]);
                lstQCByMainCoil[i].fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_fkMainCoil"]);
                lstQCByMainCoil[i].fkQualityControlByFilm = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_fkQualityControlByFilm"]);
                lstQCByMainCoil[i].meditionNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbmc_meditionNumber"]);
                lstQCByMainCoil[i].Value = DS.Tables[0].Rows[0]["qcbmc_Value"].ToString();
                
            }
            return lstQCByMainCoil;
        }

        public static bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_qualitycontrolsbymaincoil WHERE ";
                queryString += "qcbmc_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControlsByMainCoil.save");
                return false;
            }
        }
    }

}
