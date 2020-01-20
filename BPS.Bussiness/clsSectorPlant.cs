using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsSectorPlant
    {
        //Methods

        public static bool save(int fkPlant, int fkSector)
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_admin_sectorplant (sctplant_fkPlant,sctplant_fkSector) VALUES(";
                queryString += fkSector.ToString() + ",";
                queryString += fkPlant.ToString();
                queryString += ");";
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSectorPlant.save");
                return false;
            }


        }


        public static void clearSectorByPlant(int sectorCodsec)
        {

            string queryString = "";

            queryString += "DELETE FROM bps_admin_sectorplant where sctplant_fkSector = " + sectorCodsec.ToString() + ";";
            clsConnection.executeQuery(queryString);

        }

    }
}
