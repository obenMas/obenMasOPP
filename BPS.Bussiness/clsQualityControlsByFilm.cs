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
    public class clsQualityControlsByFilm
    {
        //Atributes
        private int qcbf_codsec;
        private int qcbf_fkBopp;   
        private int qcbf_fkqualitycontrol;
        private int qcbf_valuesquantity;
        private double qcbf_minimum;
        private double qcbf_maximum;

        //Properties

        public int codsec { get { return qcbf_codsec; } set { qcbf_codsec = value; } }

        public int fkBopp { get { return qcbf_fkBopp; } set { qcbf_fkBopp = value; } }

        public int fkqualitycontrol { get { return qcbf_fkqualitycontrol; } set { qcbf_fkqualitycontrol = value; } }

        public int valuesquantity { get { return qcbf_valuesquantity; } set { qcbf_valuesquantity = value; } }

        public double minimum { get { return qcbf_minimum; } set { qcbf_minimum = value; } }

        public double maximum { get { return qcbf_maximum; } set { qcbf_maximum = value; } }


        //Constructor

        public clsQualityControlsByFilm()
        {
            qcbf_codsec = 0;
            qcbf_fkBopp = 0;
            qcbf_fkqualitycontrol = 0;
            qcbf_valuesquantity = 0;
            qcbf_minimum  = 0;
            qcbf_maximum = 0;
        }

        public clsQualityControlsByFilm(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            string bopp;

            DS = clsConnection.getDataSetResult("CALL spQualityControlsByFilmByCodsec(" + codsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbf_codsec"]);
                fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbf_fkBopp"]);
                bopp = DS.Tables[0].Rows[0]["bopp_code"].ToString();
                fkqualitycontrol = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbf_fkqualitycontrol"]);
                valuesquantity = Convert.ToInt32(DS.Tables[0].Rows[0]["qcbf_valuesquantity"]);
                minimum = Convert.ToDouble(DS.Tables[0].Rows[0]["qcbf_minimum"]);
                maximum = Convert.ToDouble(DS.Tables[0].Rows[0]["qcbf_maximum"]);
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
                    queryString += "INSERT INTO bps_prod_qualitycontrolsbyfilm (qcbf_fkBopp,qcbf_fkqualitycontrol,qcbf_valuesquantity,qcbf_minimum,qcbf_maximum)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkBopp.ToString() + ",";
                    queryString += "" + this.fkqualitycontrol.ToString() + ",";
                    queryString += "" + this.valuesquantity.ToString() + ",";
                    queryString += "" + this.minimum.ToString() + ",";
                    queryString += "" + this.maximum.ToString() + "";
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
                    queryString += "UPDATE bps_prod_qualitycontrolsbyfilm";
                    queryString += " SET ";
                    queryString += "qcbf_fkBopp = " + this.fkBopp.ToString() + ",";
                    queryString += "qcbf_fkqualitycontrol =" + this.fkqualitycontrol.ToString() + ",";
                    queryString += "qcbf_valuesquantity = " + this.valuesquantity.ToString() + ",";
                    queryString += "qcbf_minimum = " + this.minimum.ToString() + ",";
                    queryString += "qcbf_maximum = " + this.maximum.ToString() + "";
                    queryString += " WHERE qcbf_codsec = " + this.codsec;
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
                clsLog.addLog(ex, 3, "clsQualityControlsByFilm.save");
                return false;
            }
        }

        public static List<clsQualityControlsByFilm> getList()
        {
            List<clsQualityControlsByFilm> lstQualityControlsByFilm = new List<clsQualityControlsByFilm>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_qualitycontrolsbyfilm");

            lstQualityControlsByFilm.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstQualityControlsByFilm.Add(new clsQualityControlsByFilm());
                lstQualityControlsByFilm[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_codsec"]);
                lstQualityControlsByFilm[i].fkBopp= Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_fkBopp"]);
                lstQualityControlsByFilm[i].fkqualitycontrol = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_fkqualitycontrol"]);
                lstQualityControlsByFilm[i].valuesquantity = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_valuesquantity"]);
                lstQualityControlsByFilm[i].minimum = Convert.ToDouble(DS.Tables[0].Rows[i]["qcbf_minimum"]);
                lstQualityControlsByFilm[i].maximum = Convert.ToDouble(DS.Tables[0].Rows[i]["qcbf_maximum"]);
                
            }
            return lstQualityControlsByFilm;
        }

        public string QualityControlsNameByCodsec(int codsec)
        {
            string bopp = string.Empty;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_bopp.bopp_code FROM bps_prod_qualitycontrolsbyfilm  LEFT JOIN bps_prod_bopp ON(bps_prod_bopp.bopp_codsec = bps_prod_qualitycontrolsbyfilm.qcbf_fkBopp) WHERE qcbf_codsec = " + codsec+ ");");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                bopp = DS.Tables[0].Rows[i]["bopp_code"].ToString();
            }
            return bopp;
        }

        public int QualityControlsCodsecByName(string name)
        {
            int qualityCodsec = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT qcbf_codsec FROM bps_prod_qualitycontrolsbyfilm LEFT JOIN bps_prod_bopp ON(bps_prod_bopp.bopp_codsec = bps_prod_qualitycontrolsbyfilm.qcbf_fkBopp) WHERE bopp_code = '" + name +")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                qualityCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["qct_codsec"]);
            }
            return qualityCodsec;
        }

        public static bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_qualitycontrolsbyfilm WHERE ";
                queryString += "qcbf_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsQualityControlsByFilm.save");
                return false;
            }
        }
    }

}
