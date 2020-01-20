using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los Swap entre planta Pilar y planta Campana
    /// </summary>
    public class clsSwap
    {
        //Atributes

        private int sw_codsec;
        private string sw_type;
        private int sw_fkPallet;
        private int sw_fkUser;
        private int sw_fkOriginalCellar;
        private int sw_fkDestinationCellar;
        private DateTime sw_date;
        private double sw_netWeigth;

        //Properties

        public int codsec { get { return sw_codsec; } set { sw_codsec = value; } }

        public string type { get { return sw_type; } set { sw_type = value; } }

        public int fkPallet { get { return sw_fkPallet; } set { sw_fkPallet = value; } }

        public int fkUser { get { return sw_fkUser; } set { sw_fkUser = value; } }

        public int fkOriginalCellar { get { return sw_fkOriginalCellar; } set { sw_fkOriginalCellar = value; } }

        public int fkDestinationCellar { get { return sw_fkDestinationCellar; } set { sw_fkDestinationCellar = value; } }

        public DateTime date { get { return sw_date; } set { sw_date = value; } }

        public double netWeigth { get { return sw_netWeigth; } set { sw_netWeigth = value; } }

        //Constructor

        public clsSwap()
        {
            codsec = 0;
            type = "";
            fkPallet = 0;
            fkUser = 0;
            fkOriginalCellar = 0;
            fkDestinationCellar = 0;
            date = DateTime.Now;
            netWeigth = 0;

        }

        public clsSwap(int swCodsec)
        {
            this.load(swCodsec);
        }

        //Methods

        public void load(int swCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spSwapByCodsec(" + swCodsec.ToString() + ")");

             if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_codsec"]);
                type = Convert.ToString(DS.Tables[0].Rows[0]["sw_type"]);
                fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkPallet"]);
                fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkUser"]);
                fkOriginalCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkOriginalCellar"]);
                fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkDestinationCellar"]);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sw_Date"]);
                netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["sw_netWeigth"]);
            }

             GC.Collect();
             GC.WaitForPendingFinalizers();
        }

        public static clsSwap getDetailByCodeSec(string swCodsec)
        {
            clsSwap objSwap = new clsSwap();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spSwapByCodsec(" + swCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objSwap.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_codsec"]);
                objSwap.type = Convert.ToString(DS.Tables[0].Rows[0]["sw_type"]);
                objSwap.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkPallet"]);
                objSwap.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkUser"]);
                objSwap.fkOriginalCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkOriginalCellar"]);
                objSwap.fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkDestinationCellar"]);
                objSwap.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sw_Date"]);
                objSwap.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["sw_netWeigth"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objSwap;
        }

        public static List<clsSwap> getSwapList()
        {
            List<clsSwap> lstSwap = new List<clsSwap>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSwap ");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstSwap.Add(new clsSwap());
                    lstSwap[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_codsec"]);
                    lstSwap[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkPallet"]);
                    lstSwap[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkUser"]);
                    lstSwap[i].fkOriginalCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkOriginalCellar"]);
                    lstSwap[i].fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sw_fkDestinationCellar"]);
                    lstSwap[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sw_Date"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstSwap;
        }

        public bool save(clsSwap objSW)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_swap (sw_type,sw_fkPallet,sw_fkUser,sw_fkOriginalCellar,sw_fkDestinationCellar,sw_date,sw_netWeigth)";
                    queryString += " VALUES (";
                    queryString += "'" + objSW.type.ToString() + "',";
                    queryString += "" + objSW.fkPallet.ToString() + ",";
                    queryString += "" + objSW.fkUser.ToString() + ",";
                    queryString += "" + objSW.fkOriginalCellar.ToString() + ",";
                    queryString += "" + objSW.fkDestinationCellar.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + objSW.netWeigth.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_swap";
                    queryString += " SET ";
                    queryString += "sw_type = '" + objSW.type.ToString() + "',";
                    queryString += "sw_fkPallet = " + objSW.fkPallet.ToString() + ",";
                    queryString += "sw_fkUser = " + objSW.fkUser.ToString() + ",";
                    queryString += "sw_fkOriginalCellar = " + objSW.fkOriginalCellar.ToString() + ",";
                    queryString += "sw_fkDestinationCellar = " + objSW.fkDestinationCellar.ToString() + ",";
                    queryString += "sw_date = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "sw_netWeigth = " + netWeigth.ToString() + "";
                    queryString += " WHERE sw_codsec = " + objSW.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSwap.save");
                return false;
            }
        }
}
}
