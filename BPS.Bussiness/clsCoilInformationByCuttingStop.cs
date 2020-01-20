using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilInformationByCuttingStop
    {
        // Attributes
        private int cibcs_codsec;
        private int cibcs_fkCuttingStop;
        private int cibcs_position;
        private double cibcs_weigth;
        private double cibcs_diameter;

        // Properties

        public int codsec { get { return cibcs_codsec; } set { cibcs_codsec = value; } }

        public int fkCuttingStop { get { return cibcs_fkCuttingStop; } set { cibcs_fkCuttingStop = value; } }

        public int position { get { return cibcs_position; } set { cibcs_position = value; } }

        public double weigth { get { return cibcs_weigth; } set { cibcs_weigth = value; } }

        public double diameter { get { return cibcs_diameter; } set { cibcs_diameter = value; } }

        // Constructor

        public clsCoilInformationByCuttingStop()
        {
            codsec = 0;
            fkCuttingStop = 0;
            position = 0;
            weigth = 0;
            diameter = 0;
        }

        // Methods

        public void load(int coilInformationCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilinformationbycuttingstop WHERE cibcs_codsec = " + coilInformationCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cibcs_codsec"]);
                fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["cibcs_fkCuttingStop"]);
                position = Convert.ToInt32(DS.Tables[0].Rows[0]["cibcs_position"]);
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["cibcs_weigth"]);
                diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["cibcs_diameter"]);
            }
        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_coilinformationbycuttingstop (cibcs_fkCuttingStop, cibcs_position, cibcs_weigth, cibcs_diameter)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkCuttingStop.ToString() + ", ";
                    queryString += "" + this.position.ToString() + ", ";
                    queryString += "" + this.weigth.ToString() + ", ";
                    queryString += "" + this.diameter.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_coilinformationbycuttingstop";
                    queryString += " SET ";
                    queryString += "cibcs_fkCuttingStop = " + this.fkCuttingStop.ToString() + ", ";
                    queryString += "cibcs_position = " + this.position.ToString() + ", ";
                    queryString += "cibcs_weigth = " + this.weigth.ToString() + ", ";
                    queryString += "cibcs_diameter = " + this.diameter.ToString() + " ";
                    queryString += " WHERE cibcs_codsec = " + this.codsec.ToString() + ";";
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = clsCoilInformationByCuttingStop.getLastSavedCodsec();

                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoilByCoilCellar.save");
                return false;
            }
        }
        public static List<clsCoilInformationByCuttingStop> getListByCuttingStop(int cuttingStopCodsec)
        {
            DataSet DS = new DataSet();
            List<clsCoilInformationByCuttingStop> lstCoilInformationByCuttingStop = new List<clsCoilInformationByCuttingStop>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilinformationbycuttingstop WHERE cibcs_fkCuttingStop = " + cuttingStopCodsec.ToString() + " ORDER BY cibcs_position");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCoilInformationByCuttingStop.Add(new clsCoilInformationByCuttingStop());
                lstCoilInformationByCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cibcs_codsec"]);
                lstCoilInformationByCuttingStop[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["cibcs_fkCuttingStop"]);
                lstCoilInformationByCuttingStop[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cibcs_position"]);
                lstCoilInformationByCuttingStop[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["cibcs_weigth"]);
                lstCoilInformationByCuttingStop[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["cibcs_diameter"]);
            }

            return lstCoilInformationByCuttingStop;
                
        }
        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cibcs_codsec FROM bps_prod_coilinformationbycuttingstop ORDER BY cibcs_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cibcs_codsec"]);
        }
    }
}
