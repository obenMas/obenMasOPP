using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los roles de usuario
    /// </summary>
    public class clsRole
    {
        //Atributes

        private int role_codsec;
        private string role_name;
        private string role_description;
        private DateTime role_createdDate;
        private DateTime role_modifiedDate;
        private int role_createdBy;
        private string role_creatorUser;
        private int role_modifiedBy;
        private string role_modificatorUser;


        //Properties

        public int codsec { get { return role_codsec; } set { role_codsec = value; } }

        public string name { get { return role_name; } set { role_name = value; } }

        public string description { get { return role_description; } set { role_description = value; } }

        public DateTime createdDate { get { return role_createdDate; } set { role_createdDate = value; } }

        public DateTime modifiedDate { get { return role_modifiedDate; } set { role_modifiedDate = value; } }

        public int createdBy { get { return role_createdBy; } set { role_createdBy = value; } }

        public string creatorUser { get { return role_creatorUser; } set { role_creatorUser = value; } }

        public int modifiedBy { get { return role_modifiedBy; } set { role_modifiedBy = value; } }

        public string modificatorUser { get { return role_modificatorUser; } set { role_modificatorUser = value; } }


        //Constructor

        public clsRole()
        { 
        role_codsec = 0;
        role_name = "";
        role_description = "";
        role_createdDate = DateTime.Now;
        role_modifiedDate = DateTime.Now;
        role_createdBy = 0;
        role_creatorUser = "";
        role_modifiedBy = 0;
        role_modificatorUser = "";
        }
        //

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRole where role_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["role_codsec"]);
            this.name = DS.Tables[0].Rows[0]["role_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["role_description"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["role_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["role_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["role_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["role_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["role_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["role_modificatorUser"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_role (role_name, role_description,role_createdDate, role_modifiedDate,role_createdBy,role_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_role";
                    queryString += " SET ";
                    queryString += "role_name = '" + this.name.ToString() + "',";
                    queryString += "role_description = '" + this.description.ToString() + "',";
                    queryString += "role_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "role_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE role_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRole.save");
                return false;
            }
        }
        
        
        public static List<clsRole> getList()
        {
            List<clsRole> lstRole = new List<clsRole>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_role order by role_name asc");

            lstRole.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRole.Add(new clsRole());
                lstRole[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["role_codsec"]);
                lstRole[i].name = DS.Tables[0].Rows[i]["role_name"].ToString();
                lstRole[i].description = DS.Tables[0].Rows[i]["role_description"].ToString();

            }

            return lstRole;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
