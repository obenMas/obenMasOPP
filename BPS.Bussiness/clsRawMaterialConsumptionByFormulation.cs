using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRawMaterialConsumptionByFormulation
    {
        private int rmc_rawMaterialCodsec;
        private string rmc_rawMaterialName;
        private double rmc_rawMaterialPercentage;
        private double rmc_consumption;
        private clsRawMaterialEquivalence rmc_rawMaterialEquivalence;

        public int rawMaterialCodsec { get { return rmc_rawMaterialCodsec; } set { rmc_rawMaterialCodsec = value; } }

        public string rawMaterialName { get { return rmc_rawMaterialName; } set { rmc_rawMaterialName = value; } }

        public double rawMaterialPercentage { get { return rmc_rawMaterialPercentage; } set { rmc_rawMaterialPercentage = value; } }

        public double consumption { get { return rmc_consumption; } set { rmc_consumption = value; } }

        public clsRawMaterialEquivalence rawMaterialEquivalence { get { return rmc_rawMaterialEquivalence; } set { rmc_rawMaterialEquivalence = value; } }

        public clsRawMaterialConsumptionByFormulation()
        {
            rmc_rawMaterialCodsec = 0;
            rmc_rawMaterialName = "";
            rmc_rawMaterialPercentage = 0;
            rmc_consumption = 0;
            rmc_rawMaterialEquivalence = new clsRawMaterialEquivalence();
        }

        public static List<clsRawMaterialConsumptionByFormulation> getRawMaterialConsumptionByFormulation(int formulationCodsec, double weigth)
        { 
            double C1Percentage = 0;
            double C2Percentage = 0;
            double CentralLayerPercentage = 0;
            double TotalPercentage = 0;
            clsFormulation objFormulation = new clsFormulation(formulationCodsec);
            List<clsRawMaterialConsumptionByFormulation> lstRawMaterialConsumptionByFormulation = new List<clsRawMaterialConsumptionByFormulation>();
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();


            C1Percentage = (Convert.ToDouble(objFormulation.thickLayerC1) * 100) / Convert.ToDouble(objFormulation.thick);
            C2Percentage = (Convert.ToDouble(objFormulation.thickLayerC2) * 100) / Convert.ToDouble(objFormulation.thick);
            CentralLayerPercentage = (Convert.ToDouble(objFormulation.thickCentralLayer) * 100) / Convert.ToDouble(objFormulation.thick);
            TotalPercentage = C1Percentage + C2Percentage + CentralLayerPercentage;

            lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(formulationCodsec);
            

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC1 == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage * C1Percentage / 100);
                }
                else if (lstRawMaterialByFormulation[i].layerC2 == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage * C2Percentage / 100);
                }
                else if (lstRawMaterialByFormulation[i].CentralLayer == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage * CentralLayerPercentage / 100);
                }
            }
            
            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                bool isInArray = false;
                int inArrayIndex = -1;

                for (int j = 0; j < lstRawMaterialConsumptionByFormulation.Count; j++)
                {
                    if (lstRawMaterialByFormulation[i].name == lstRawMaterialConsumptionByFormulation[j].rawMaterialName)
                    {
                        isInArray = true;
                        inArrayIndex = j;
                    }

                }
                if (isInArray == true)
                {
                    lstRawMaterialConsumptionByFormulation[inArrayIndex].consumption += (lstRawMaterialByFormulation[i].globalPercentage / 100) * Convert.ToDouble(weigth);
                    lstRawMaterialConsumptionByFormulation[inArrayIndex].rawMaterialPercentage += lstRawMaterialByFormulation[i].globalPercentage;
                   
                }
                else
                {
                    lstRawMaterialConsumptionByFormulation.Add(new clsRawMaterialConsumptionByFormulation());

                    lstRawMaterialConsumptionByFormulation[lstRawMaterialConsumptionByFormulation.Count - 1].rawMaterialCodsec = lstRawMaterialByFormulation[i].codsec;
                    lstRawMaterialConsumptionByFormulation[lstRawMaterialConsumptionByFormulation.Count - 1].rawMaterialName = lstRawMaterialByFormulation[i].name;
                    lstRawMaterialConsumptionByFormulation[lstRawMaterialConsumptionByFormulation.Count - 1].consumption = (lstRawMaterialByFormulation[i].globalPercentage / 100) * weigth;
                    lstRawMaterialConsumptionByFormulation[lstRawMaterialConsumptionByFormulation.Count - 1].rawMaterialPercentage = lstRawMaterialByFormulation[i].globalPercentage;
                    lstRawMaterialConsumptionByFormulation[lstRawMaterialConsumptionByFormulation.Count - 1].rawMaterialEquivalence = clsRawMaterialEquivalence.getDetailByRawMaterial(lstRawMaterialByFormulation[i].codsec);
                }
            }

            return lstRawMaterialConsumptionByFormulation;
        }
    }
}
