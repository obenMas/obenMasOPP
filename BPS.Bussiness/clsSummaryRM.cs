using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsSummaryRM
    {
        public static void getSummary(clsRawMaterialByFormulation objRW)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spSummaryRM " + objRW.fkFormulation + "," + objRW.CentralLayer + "," + objRW.layerC1 + "," + objRW.layerC2 + "," + objRW.layerC3 + "," + objRW.layerC4 + "");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public static bool validateToDeleteRow(string fkRaw, int fkFilmProduction)
        {
            bool isValid = true;

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT TOP(1) COALESCE(fpfpp_fkFormulation,0) AS fpfpp_fkFormulation FROM  bps_prod_formulationperfilmproductionplanreload WHERE fpfpp_fkFilmProductionPlan = " + fkFilmProduction.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                var formulation = DS.Tables[0].Rows[0][0].ToString();
                DS.Clear();
                DS = clsConnection.getDataSetResult("SELECT rwt_fkFormulation FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_fkRaw = " + fkRaw + " GROUP BY rwt_fkFormulation");

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (formulation != DS.Tables[0].Rows[i][0].ToString())
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
        }

        internal static void getSummarytoDelete(string fkformulation, int CL, int L1, int L2, int L3, int L4)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spSummaryRM " + fkformulation + "," + CL.ToString() + "," + L1.ToString() + "," + L2.ToString() + "," + L3.ToString() + "," + L4.ToString() + "");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
