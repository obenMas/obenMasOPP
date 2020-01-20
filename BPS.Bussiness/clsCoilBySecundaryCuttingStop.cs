using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilBySecundaryCuttingStop
    {
         //Attributes
        private int cbscs_codsec;
        private int cbscs_fkCoil;
        private clsCoil cbscs_coil;
        private int cbscs_fkCuttingStop;
        private double cbscs_length;

        //Properties
        public int codsec { get { return cbscs_codsec; } set { cbscs_codsec = value; } }

        public int fkCoil { get { return cbscs_fkCoil; } set { cbscs_fkCoil = value; } }

        public clsCoil objCoil { get { return cbscs_coil; } set { cbscs_coil = value; } }

        public int fkCuttingStop { get { return cbscs_fkCuttingStop; } set { cbscs_fkCuttingStop = value; } }

        public double length { get { return cbscs_length; } set { cbscs_length = value; } }

        //Constructor
        public clsCoilBySecundaryCuttingStop()
        {
            this.codsec = 0;
            this.fkCuttingStop = 0;
            this.fkCoil = 0;
            this.objCoil = new clsCoil();
            this.length = 0;
        }

        //Method
        public void load(int coilByCuttingStopCodsec)
        {
            DataSet DS = new DataSet();
            
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilBySecundaryCuttingStop WHERE cbscs_codsec = " + coilByCuttingStopCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cbscs_codsec"]);
                this.fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["cbscs_fkCuttingStop"]);
                this.fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cbscs_fkCoil"]);
                this.objCoil.load(this.fkCoil);
                this.length = Convert.ToDouble(DS.Tables[0].Rows[0]["cbscs_length"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_coilBySecundaryCuttingStop (cbscs_fkCoil, cbscs_fkCuttingStop, cbscs_Length) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkCoil.ToString() + ", ";
                    queryString += "" + this.fkCuttingStop.ToString() + ", ";
                    queryString += "" + this.length.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_coilBySecundaryCuttingStop";
                    queryString += " SET ";
                    queryString += "cbscs_fkCoil = " + this.fkCoil.ToString() + ", ";
                    queryString += "cbscs_fkCuttingStop = " + this.fkCuttingStop.ToString() + ", ";
                    queryString += "cbscs_Length = " + this.length.ToString() + " ";
                    queryString += " WHERE cbscs_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "coilBySecundaryCuttingStop.save");
                return false;
            }
        }
        public static List<clsCoilBySecundaryCuttingStop> getListByCuttingStop(int cbscsCodsec)
        {
            List<clsCoilBySecundaryCuttingStop> lstCoilBySecundaryCuttingStop = new List<clsCoilBySecundaryCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilBySecundaryCuttingStop WHERE cbscs_fkCuttingStop = " + cbscsCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilBySecundaryCuttingStop.Add(new clsCoilBySecundaryCuttingStop());

                    lstCoilBySecundaryCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cbscs_codsec"]);
                    lstCoilBySecundaryCuttingStop[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["cbscs_fkCuttingStop"]);
                    lstCoilBySecundaryCuttingStop[i].fkCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["cbscs_fkCoil"]);
                    lstCoilBySecundaryCuttingStop[i].objCoil.loadSimplified(lstCoilBySecundaryCuttingStop[i].fkCoil);
                    lstCoilBySecundaryCuttingStop[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["cbscs_length"]);
                }
            }

            return lstCoilBySecundaryCuttingStop;
        }

        public static void delete(int codsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_coilBySecundaryCuttingStop WHERE cbscs_codsec = " + codsec.ToString());
        }
    }
}
