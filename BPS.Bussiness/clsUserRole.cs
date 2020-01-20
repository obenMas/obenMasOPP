using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los tipos de rol que posee un usuario
    /// </summary>
    public class clsUserRole
    {
        
        //Methods

        public static bool save(int fkUser, int fkRole)
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_admin_userrole (usrrole_fkUser,usrrole_fkRole) VALUES(";
                queryString += fkUser.ToString() + ",";
                queryString += fkRole.ToString();
                queryString += ");";
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsUserRole.save");
                return false;
            }
            
 
        }

        public static void clearRolesByUser(int userCodsec)
        {
            
            string queryString = "";

            queryString += "DELETE FROM bps_admin_userrole where usrrole_fkUser = " + userCodsec.ToString() +";";
            clsConnection.executeQuery(queryString);

        }






      
       
    }    

}
