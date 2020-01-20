using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSystemMenuByUserRole
    {
        //Attributes
        private int smbur_codsec;
        private int smbur_fkSystemMenu;
        private int smbur_fkUserRole;
        private Boolean smbur_enabled;
        private Boolean smbur_visible;

        //Properties
        public int codsec { get { return smbur_codsec; } set { smbur_codsec = value; } }

        public int fkSystemMenu { get { return smbur_fkSystemMenu; } set { smbur_fkSystemMenu = value; } }

        public int fkUserRole { get { return smbur_fkUserRole; } set { smbur_fkUserRole = value; } }

        public Boolean enabled { get { return smbur_enabled; } set { smbur_enabled = value; } }

        public Boolean visible { get { return smbur_visible; } set { smbur_visible = value; } }

        //Constructor

        public clsSystemMenuByUserRole()
        { 
            smbur_codsec = 0;
            smbur_fkSystemMenu = 0;
            smbur_fkUserRole = 0;
            smbur_enabled = false;
            smbur_visible = false;
        }

        public clsSystemMenuByUserRole(int systemMenuByUserRoleCodsec)
        {
            this.load(systemMenuByUserRoleCodsec);
        }

        //Methods

        public void load(int systemMenuByUserRoleCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_systemMenuByUserRole WHERE smbur_codsec = " + systemMenuByUserRoleCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_codsec"]);
                fkSystemMenu = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_fkSystemMenu"]);
                fkUserRole = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_fkUserRole"]);
                enabled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["smbur_enabled"], DS.Tables[0].Rows[0]["smbur_enabled"].GetType().FullName);
                visible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["smbur_visible"], DS.Tables[0].Rows[0]["smbur_visible"].GetType().FullName);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_systemMenuByUserRole (smbur_fkSystemMenu, smbur_fkUserRole, smbur_enabled, smbur_visible)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkSystemMenu.ToString() + "";
                    queryString += "" + this.fkUserRole.ToString() + "";
                    queryString += "'" + this.enabled.ToString() + "'";
                    queryString += "'" + this.visible.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_systemMenuByUserRole";
                    queryString += " SET ";
                    queryString += "smbur_fkSystemMenu = " + this.fkSystemMenu.ToString() + "";
                    queryString += "smbur_fkUserRole = " + this.fkUserRole.ToString() + "";
                    queryString += "smbur_enabled = '" + this.enabled.ToString() + "'";
                    queryString += "smbur_visible = '" + this.visible.ToString() + "'";
                    queryString += " WHERE smbur_codsec = " + this.codsec.ToString() + ";";
                }

                clsConnection.executeQuery(queryString);

                return true;

            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSystemMenuByUserRole.save");
                return false;
            }
        }
        public static clsSystemMenuByUserRole getDetailByUserRoleAndControlName(int userRole, string controlName)
        {
            DataSet DS = new DataSet();
            clsSystemMenuByUserRole objSystemMenuByUserRole = new clsSystemMenuByUserRole();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_systemMenuByUserRole, bps_admin_systemMenu WHERE sm_codsec = smbur_fkSystemMenu AND smbur_fkUserRole = '" + userRole.ToString() + "' AND sm_controlName = '" + controlName + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objSystemMenuByUserRole.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_codsec"]);
                objSystemMenuByUserRole.fkSystemMenu = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_fkSystemMenu"]);
                objSystemMenuByUserRole.fkUserRole = Convert.ToInt32(DS.Tables[0].Rows[0]["smbur_fkUserRole"]);
                objSystemMenuByUserRole.enabled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["smbur_enabled"], DS.Tables[0].Rows[0]["smbur_enabled"].GetType().FullName);
                objSystemMenuByUserRole.visible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["smbur_visible"], DS.Tables[0].Rows[0]["smbur_visible"].GetType().FullName);
            }

            return objSystemMenuByUserRole;
        }
    }
}
