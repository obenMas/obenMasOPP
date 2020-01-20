using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BPS.Raw.ProcessR.Line
{
    public class clsReverseMP
    {
        internal static void processReverse(string codsecRMF, string codsecRM, string codsecFK)
        {
            toCheckSon(codsecRM, codsecFK);
        }

        private static void toCheckSon(string codsecRM, string codsecFK)
        {
            //DataSet DS = new DataSet();
            ////SERVER
            //DS = clsConnection.getDataSetResult("SELECT COALESCE(COUNT(rwmc_codsec),0) AS codes FROM bps_prod_rawmaterialbycoilcellar " +
            //    "WHERE rwmc_movement = 'Movimiento Interno Extrusión ReProceso Listado Backload' AND rwmc_code='" + code + "'");

            //if (DS.Tables[0].Rows.Count > 0)
            //    value = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString()) + 1;

            //return value.ToString();
        }
    }
}
