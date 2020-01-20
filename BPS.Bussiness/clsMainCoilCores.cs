using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{

    /// <summary>
    /// Clase que administra los cores de los Rollos Madre
    /// </summary>
    public class clsMainCoilCores
    {

        //Atributes

        private int mcc_codsec;
        private int mcc_number;
        private int mcc_weight;
        private int mcc_fkPlant;


        //Properties

        public int codsec { get { return mcc_codsec; } set { mcc_codsec = value; } }

        public int number { get { return mcc_number; } set { mcc_number = value; } }

        public int weight { get { return mcc_weight; } set { mcc_weight = value; } }

        public int fkPlant { get { return mcc_fkPlant; } set { mcc_fkPlant = value; } }

        //Constructor

        public clsMainCoilCores()
        {
            mcc_codsec = 0;
            mcc_number = 0;
            mcc_weight = 0;
            mcc_fkPlant = 0;
        }

        //Methods
        
        public static List<clsMainCoilCores> getMainCoilCoresList()
        {
            List<clsMainCoilCores> lstMainCoilCores = new List<clsMainCoilCores>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwMainCoilCores ");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMainCoilCores.Add(new clsMainCoilCores());
                    lstMainCoilCores[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cmm_codsec"]);
                    lstMainCoilCores[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["cmm_number"]);
                    lstMainCoilCores[i].weight = Convert.ToInt32(DS.Tables[0].Rows[i]["cmm_weight"]);
                    lstMainCoilCores[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cmm_fkPlant"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstMainCoilCores;
        }

        public static int getWeightByMainCoilCoreNumber(int coreNumber, int plant)
        {
            int coreWeight = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_maincoilcores.mcc_weight FROM bps_prod_maincoilcores WHERE bps_prod_maincoilcores.mcc_number = " + coreNumber.ToString() + "AND mcc_fkPlant="+plant.ToString());
             if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    coreWeight = Convert.ToInt32(DS.Tables[0].Rows[i]["mcc_weight"]);
                }
            }
            return coreWeight;
        }

    }
}
