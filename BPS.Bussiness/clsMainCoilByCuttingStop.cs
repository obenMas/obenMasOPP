using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMainCoilByCuttingStop
    {
        //Attributes
        private int mccs_codsec;
        private int mccs_fkMainCoil;
        private clsMainCoil mccs_mainCoil;
        private int mccs_fkCuttingStop;
        private double mccs_length;

        //Properties
        public int codsec { get { return mccs_codsec; } set { mccs_codsec = value; } }

        public int fkMainCoil { get { return mccs_fkMainCoil; } set { mccs_fkMainCoil = value; } }

        public clsMainCoil mainCoil { get { return mccs_mainCoil; } set { mccs_mainCoil = value; } }

        public int fkCuttingStop { get { return mccs_fkCuttingStop; } set { mccs_fkCuttingStop = value; } }

        public double length { get { return mccs_length; } set { mccs_length = value; } }

        //Constructor
        public clsMainCoilByCuttingStop()
        {
            this.codsec = 0;
            this.fkCuttingStop = 0;
            this.fkMainCoil = 0;
            this.mainCoil = new clsMainCoil();
            this.length = 0;
        }

        //Method
        public void load(int mainCoilByCuttingStopCodsec)
        {
            DataSet DS = new DataSet();
            
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_mainCoilByCuttingStop WHERE mccs_codsec = " + mainCoilByCuttingStopCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mccs_codsec"]);
                this.fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["mccs_fkCuttingStop"]);
                this.fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["mccs_fkMainCoil"]);
                this.mainCoil.load(this.fkMainCoil);
                this.length = Convert.ToDouble(DS.Tables[0].Rows[0]["mccs_length"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maincoilbycuttingstop (mccs_fkMainCoil, mccs_fkCuttingStop, mccs_Length) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkMainCoil.ToString() + ", ";
                    queryString += "" + this.fkCuttingStop.ToString() + ", ";
                    queryString += "" + this.length.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_maincoilbycuttingstop";
                    queryString += " SET ";
                    queryString += "mccs_fkMainCoil = " + this.fkMainCoil.ToString() + ", ";
                    queryString += "mccs_fkCuttingStop = " + this.fkCuttingStop.ToString() + ", ";
                    queryString += "mccs_Length = " + this.length.ToString() + " ";
                    queryString += " WHERE mccs_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "mainCoilByCuttingStop.save");
                return false;
            }
        }
        public static List<clsMainCoilByCuttingStop> getListByCuttingStop(int mccsCodsec)
        {
            List<clsMainCoilByCuttingStop> lstMainCoilByCuttingStop = new List<clsMainCoilByCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_mainCoilByCuttingStop WHERE mccs_fkCuttingStop = " + mccsCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoilByCuttingStop.Add(new clsMainCoilByCuttingStop());

                    lstMainCoilByCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mccs_codsec"]);
                    lstMainCoilByCuttingStop[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["mccs_fkCuttingStop"]);
                    lstMainCoilByCuttingStop[i].fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["mccs_fkMainCoil"]);
                    lstMainCoilByCuttingStop[i].mainCoil.load(lstMainCoilByCuttingStop[i].fkMainCoil);
                    lstMainCoilByCuttingStop[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["mccs_length"]);
                }
            }

            return lstMainCoilByCuttingStop;
        }

        public static void delete(int codsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_mainCoilByCuttingStop WHERE mccs_codsec = " + codsec.ToString());
        }
    }
}
