using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    /// <summary>
    /// 
    /// </summary>
    public class clsUser
    {
        //Attributes
        private int usr_codsec;
        private int usr_fkInning;
        private string usr_InningName;
        private int usr_fkRole;
        private string usr_RoleName;
        private int usr_fkStatus;
        private string usr_StatusName;
        private string usr_firstName;
        private string usr_lastName;
        private string usr_userName;
        private string usr_password;
        private DateTime usr_createdDate;
        private DateTime usr_modifiedDate;
        private int usr_createdBy;
        private string usr_creatorUser;
        private string usr_modificatorUser;
        private int usr_modifiedBy;

        private string usr_mail;




        //Properties

        public int codsec { get { return usr_codsec; } set { usr_codsec = value; } }

        public int fkInning { get { return usr_fkInning; } set { usr_fkInning = value; } }

        public string InningName { get { return usr_InningName; } set { usr_InningName = value; } }

        public int fkRole { get { return usr_fkRole; } set { usr_fkRole = value; } }

        public string RoleName { get { return usr_RoleName; } set { usr_RoleName = value; } }

        public int fkStatus { get { return usr_fkStatus; } set { usr_fkStatus = value; } }

        public string StatusName { get { return usr_StatusName; } set { usr_StatusName = value; } }

        public string firstName { get { return usr_firstName; } set { usr_firstName = value; } }

        public string lastName { get { return usr_lastName; } set { usr_lastName = value; } }

        public string userName { get { return usr_userName; } set { usr_userName = value; } }

        public string password { get { return usr_password; } set { usr_password = value; } }

        public DateTime createdDate { get { return usr_createdDate; } set { usr_createdDate = value; } }

        public DateTime modifiedDate { get { return usr_modifiedDate; } set { usr_modifiedDate = value; } }

        public int createdBy { get { return usr_createdBy; } set { usr_createdBy = value; } }

        public int modifiedBy { get { return usr_modifiedBy; } set { usr_modifiedBy = value; } }

        public string creatorUser { get { return usr_creatorUser; } set { usr_creatorUser = value; } }

        public string modificatorUser { get { return usr_modificatorUser; } set { usr_modificatorUser = value; } }

        public string mail { get { return usr_mail; } set { usr_mail = value; } }

        //Constructor
        public clsUser()
        {
            usr_codsec = 0;
            usr_fkInning = 0;
            usr_InningName = "";
            usr_fkRole = 0;
            usr_RoleName = "";
            usr_fkStatus = 0;
            usr_StatusName = "";
            usr_firstName = "";
            usr_lastName = "";
            usr_userName = "";
            usr_password = "";
            usr_createdDate = DateTime.Now;
            usr_modifiedDate = DateTime.Now;
            usr_createdBy = 0;
            usr_creatorUser = "";
            usr_modificatorUser = "";
            usr_modifiedBy = 0;
            usr_mail = "unknow@boppdelecuador.com";
        }
        public clsUser(int codsec)
        {
            load(codsec);
        }
        
        public clsUser(string name)
        {
            load(name);
        }

        public void load(string name)
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwuser where usr_userName = '" + name.ToString() + "' ");


            DSUser = clsConnection.getDataSetResult("CALL spRoleByUserName " + name.ToString());


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"]);
            this.fkInning = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_fkInning"]);
            this.InningName = DS.Tables[0].Rows[0]["usr_InningName"].ToString();
            this.fkRole = Convert.ToInt32(DSUser.Tables[0].Rows[0]["usr_fkRole"]);
            this.RoleName = DSUser.Tables[0].Rows[0]["usr_RoleName"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["usr_StatusName"].ToString();
            this.firstName = DS.Tables[0].Rows[0]["usr_firstName"].ToString();
            this.lastName = DS.Tables[0].Rows[0]["usr_lastName"].ToString();
            this.userName = DS.Tables[0].Rows[0]["usr_userName"].ToString();
            this.password = DS.Tables[0].Rows[0]["usr_password"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["usr_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["usr_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["usr_creatorUser"].ToString();
            this.modificatorUser = DS.Tables[0].Rows[0]["usr_modificatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_modifiedBy"]);
            this.mail = DS.Tables[0].Rows[0]["usr_mail"].ToString();
        }
        

        //Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codsec"></param>
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwuser where usr_codsec = " + codsec.ToString());


            DSUser = clsConnection.getDataSetResult("SELECT * FROM vwrolebyuser where usr_codsec = " + codsec.ToString());


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"]);
            this.fkInning = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_fkInning"]);
            this.InningName = DS.Tables[0].Rows[0]["usr_InningName"].ToString();
            this.fkRole = Convert.ToInt32(DSUser.Tables[0].Rows[0]["usr_fkRole"]);
            this.RoleName = DSUser.Tables[0].Rows[0]["usr_RoleName"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["usr_StatusName"].ToString();
            this.firstName = DS.Tables[0].Rows[0]["usr_firstName"].ToString();
            this.lastName = DS.Tables[0].Rows[0]["usr_lastName"].ToString();
            this.userName = DS.Tables[0].Rows[0]["usr_userName"].ToString();
            this.password = DS.Tables[0].Rows[0]["usr_password"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["usr_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["usr_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["usr_creatorUser"].ToString();
            this.modificatorUser = DS.Tables[0].Rows[0]["usr_modificatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_modifiedBy"]);
            this.mail = DS.Tables[0].Rows[0]["usr_mail"].ToString();
        }
        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT usr_codsec FROM bps_admin_user where usr_createdBy = " + clsGlobal.LoggedUser.codsec + " ORDER BY usr_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"]);

        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_user (usr_fkInning, usr_fkStatus, usr_firstName, usr_lastName, usr_userName, usr_password, usr_createdDate, usr_modifiedDate, usr_createdBy, usr_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += this.fkInning.ToString() + ",";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += "'" + this.firstName + "',";
                    queryString += "'" + this.lastName + "',";
                    queryString += "'" + this.userName + "',";
                    queryString += "'" + clsGlobal.getMd5(this.password) + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_user";
                    queryString += " SET ";
                    queryString += "usr_fkInning = " + this.fkInning.ToString() + ",";
                    queryString += "usr_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "usr_firstName = '" + this.firstName + "',";
                    queryString += "usr_lastName = '" + this.lastName + "',";
                    queryString += "usr_userName = '" + this.userName + "',";
                    queryString += "usr_password = '" + clsGlobal.getMd5(this.password) + "',";
                    queryString += "usr_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "usr_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += "WHERE usr_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsUser.save");
                return false;
            }

        }

        public static List<clsUser> getList()
        {
            List<clsUser> lstUser = new List<clsUser>();
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwUser ORDER BY usr_firstName, usr_lastName");

            lstUser.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstUser.Add(new clsUser());
                lstUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"]);
                lstUser[i].fkInning = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkInning"]);
                lstUser[i].InningName = DS.Tables[0].Rows[i]["usr_InningName"].ToString();

                DSUser = clsConnection.getDataSetResult("SELECT * FROM vwrolebyuser WHERE usr_codsec = " + lstUser[i].codsec.ToString());
                lstUser[i].fkRole = Convert.ToInt32(DSUser.Tables[0].Rows[0]["usr_fkRole"]);
                lstUser[i].RoleName = DSUser.Tables[0].Rows[0]["usr_RoleName"].ToString();
                lstUser[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkStatus"]);
                lstUser[i].StatusName = DS.Tables[0].Rows[i]["usr_StatusName"].ToString();
                lstUser[i].firstName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                lstUser[i].lastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                lstUser[i].userName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                lstUser[i].password = DS.Tables[0].Rows[i]["usr_password"].ToString();
                lstUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_createdDate"]);
                lstUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_modifiedDate"]);
                lstUser[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_createdBy"]);
                lstUser[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_modifiedBy"]);
                lstUser[i].creatorUser = DS.Tables[0].Rows[i]["usr_creatorUser"].ToString();
                lstUser[i].modificatorUser = DS.Tables[0].Rows[i]["usr_modificatorUser"].ToString();
                lstUser[i].mail = DS.Tables[0].Rows[i]["usr_mail"].ToString();
            }

            return lstUser;

        }
        public static List<clsUser> getListByRole(string roleName)
        {
            List<clsUser> lstUser = new List<clsUser>();
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwUser WHERE usr_RoleName = '" + roleName + "' ORDER BY usr_firstName, usr_lastName");

            lstUser.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstUser.Add(new clsUser());
                lstUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"]);
                lstUser[i].fkInning = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkInning"]);
                lstUser[i].InningName = DS.Tables[0].Rows[i]["usr_InningName"].ToString();
                lstUser[i].fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_fkRole"]);
                lstUser[i].RoleName = DS.Tables[0].Rows[0]["usr_RoleName"].ToString();
                lstUser[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkStatus"]);
                lstUser[i].StatusName = DS.Tables[0].Rows[i]["usr_StatusName"].ToString();
                lstUser[i].firstName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                lstUser[i].lastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                lstUser[i].userName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                lstUser[i].password = DS.Tables[0].Rows[i]["usr_password"].ToString();
                lstUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_createdDate"]);
                lstUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_modifiedDate"]);
                lstUser[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_createdBy"]);
                lstUser[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_modifiedBy"]);
                lstUser[i].creatorUser = DS.Tables[0].Rows[i]["usr_creatorUser"].ToString();
                lstUser[i].modificatorUser = DS.Tables[0].Rows[i]["usr_modificatorUser"].ToString();
                lstUser[i].mail = DS.Tables[0].Rows[i]["usr_mail"].ToString();

            }

            return lstUser;

        }

        public static clsUser Login(string userName, string password)
        {
            clsUser loggedUser = new clsUser();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT usr_codsec FROM bps_admin_user where usr_username = '" + userName + "' AND usr_password = '" + clsGlobal.getMd5(password) + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                loggedUser.load(Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"]));
            }

            return loggedUser;
        }

        public static List<clsUser> getListExclude()
        {
            List<clsUser> lstUser = new List<clsUser>();
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_user WHERE usr_fkStatus = 2 ORDER BY usr_lastName, usr_firstName");

            lstUser.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstUser.Add(new clsUser());
                lstUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"]);
                lstUser[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkStatus"]);
                lstUser[i].firstName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                lstUser[i].lastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                lstUser[i].userName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                lstUser[i].password = DS.Tables[0].Rows[i]["usr_password"].ToString();
                lstUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_createdDate"]);
                lstUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_modifiedDate"]);
                lstUser[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_createdBy"]);
                lstUser[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_modifiedBy"]);
                DSUser = clsConnection.getDataSetResult("SELECT * FROM vwrolebyuser WHERE usr_codsec = " + lstUser[i].codsec.ToString());
                lstUser[i].fkRole = Convert.ToInt32(DSUser.Tables[0].Rows[0]["usr_fkRole"]);
                lstUser[i].mail = DS.Tables[0].Rows[i]["usr_mail"].ToString();
            }

            return lstUser;
        }

        public static List<clsUser> getListByCodsec(int codsec)
        {
            List<clsUser> lstUser = new List<clsUser>();
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_user WHERE usr_codsec = " + codsec.ToString() + " ORDER BY usr_lastName, usr_firstName");

            lstUser.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstUser.Add(new clsUser());
                lstUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"]);
                lstUser[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_fkStatus"]);
                lstUser[i].firstName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                lstUser[i].lastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                lstUser[i].userName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                lstUser[i].password = DS.Tables[0].Rows[i]["usr_password"].ToString();
                lstUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_createdDate"]);
                lstUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["usr_modifiedDate"]);
                lstUser[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_createdBy"]);
                lstUser[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_modifiedBy"]);
                DSUser = clsConnection.getDataSetResult("SELECT * FROM vwrolebyuser WHERE usr_codsec = " + lstUser[i].codsec.ToString());
                lstUser[i].fkRole = Convert.ToInt32(DSUser.Tables[0].Rows[0]["usr_fkRole"]);
                lstUser[i].RoleName = DSUser.Tables[0].Rows[0]["usr_RoleName"].ToString();
                lstUser[i].mail = DS.Tables[0].Rows[i]["usr_mail"].ToString();
            }

            return lstUser;
        }

        public override string ToString()
        {
            return this.userName;
        }

    }
}
