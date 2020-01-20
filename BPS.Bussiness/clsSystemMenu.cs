using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSystemMenu
    {
        //Attibutes

        private int sm_codsec;
        private int sm_parentMenu;
        private string sm_name;
        private string sm_controlName;
        private List<clsSystemMenu> sm_lstMenuChildren;

        //Properties

        public int codsec { get { return sm_codsec; } set { sm_codsec = value; } }

        public int parentMenu { get { return sm_parentMenu; } set { sm_parentMenu = value; } }

        public string name { get { return sm_name; } set { sm_name = value; } }

        public string controlName { get { return sm_controlName; } set { sm_controlName = value; } }

        public List<clsSystemMenu> lstMenuChildren { get { return sm_lstMenuChildren; } set { sm_lstMenuChildren = value; } }

        //Constructor

        public clsSystemMenu()
        {
            sm_codsec = 0;
            sm_parentMenu = 0;
            sm_name = "";
            sm_controlName = "";
            sm_lstMenuChildren = new List<clsSystemMenu>();
        }
        public clsSystemMenu(int systemMenuCodsec)
        {
            load(systemMenuCodsec);
        }
        
        //Methods

        public void load(int systemManuCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_systemMenu WHERE sm_codsec = " + systemManuCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_codsec"]);
                this.parentMenu = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_parentMenu"]);
                this.name = DS.Tables[0].Rows[0]["sm_name"].ToString();
                this.controlName = DS.Tables[0].Rows[0]["sm_controlName"].ToString();
                this.lstMenuChildren = clsSystemMenu.getMenuChildren(this.codsec);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_systemMenu (sm_parentMenu, sm_name, sm_controlName)";
                    queryString += " VALUES (";
                    queryString += "" + this.parentMenu + "";
                    queryString += "'" + this.name + "'";
                    queryString += "'" + this.controlName + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_systemMenu";
                    queryString += " SET ";
                    queryString += "sm_parentMenu = " + this.parentMenu.ToString() + "";
                    queryString += "sm_name = '" + this.name + "'";
                    queryString += "sm_controlName = '" + this.controlName + "'";
                    queryString += " WHERE sm_codsec = " + this.codsec.ToString() + ";";
                }

                clsConnection.executeQuery(queryString);

                return true;

            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSystemMenu.save");
                return false;
            }
        }

        public static List<clsSystemMenu> getMenuChildren(int systemMenuCodsec)
        {
            DataSet DS = new DataSet();
            List<clsSystemMenu> lstSystemMenu = new List<clsSystemMenu>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_systemMenu WHERE sm_parentMenu = " + systemMenuCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstSystemMenu.Add(new clsSystemMenu());

                    lstSystemMenu[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sm_codsec"]);
                    lstSystemMenu[i].parentMenu = Convert.ToInt32(DS.Tables[0].Rows[i]["sm_parentMenu"]);
                    lstSystemMenu[i].name = DS.Tables[0].Rows[i]["sm_name"].ToString();
                    lstSystemMenu[i].controlName = DS.Tables[0].Rows[i]["sm_controlName"].ToString();
                    lstSystemMenu[i].lstMenuChildren = clsSystemMenu.getMenuChildren(lstSystemMenu[i].codsec);
                }
            }

            return lstSystemMenu;
        }

        public static List<clsSystemMenu> getRootSystemMenus()
        {
            DataSet DS = new DataSet();
            List<clsSystemMenu> lstSystemMenu = new List<clsSystemMenu>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_systemMenu WHERE sm_parentMenu = 0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstSystemMenu.Add(new clsSystemMenu());

                    lstSystemMenu[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sm_codsec"]);
                    lstSystemMenu[i].parentMenu = Convert.ToInt32(DS.Tables[0].Rows[i]["sm_parentMenu"]);
                    lstSystemMenu[i].name = DS.Tables[0].Rows[i]["sm_name"].ToString();
                    lstSystemMenu[i].controlName = DS.Tables[0].Rows[i]["sm_controlName"].ToString();
                    lstSystemMenu[i].lstMenuChildren = clsSystemMenu.getMenuChildren(lstSystemMenu[i].codsec);
                }
            }

            return lstSystemMenu;        
        }
    }
}
