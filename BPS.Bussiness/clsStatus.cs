using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja todos los estados
    /// </summary>
    public class clsStatus
    {
        //Atributes

        private int stt_codsec;
        private string stt_name;
        private string stt_description;
        private int stt_fkStatusGroup;
        private string stt_StatusGroupName;
        private DateTime stt_createdDate;
        private DateTime stt_modifiedDate;
        private int stt_createdBy;
        private string stt_creatorUser;
        private int stt_modifiedBy;
        private string stt_modificatorUser;
        
        //Properties

        public int codsec { get { return stt_codsec; } set { stt_codsec = value; } }

        public string name { get { return stt_name; } set { stt_name = value; } }

        public string description { get { return stt_description; } set { stt_description = value; } }

        public int fkStatusGroup { get { return stt_fkStatusGroup; } set { stt_fkStatusGroup = value; } }

        public string StatusGroupName { get { return stt_StatusGroupName; } set { stt_StatusGroupName = value; } }

        public DateTime createdDate { get { return stt_createdDate; } set { stt_createdDate = value; } }

        public DateTime modifiedDate { get { return stt_modifiedDate; } set { stt_modifiedDate = value; } }

        public int createdBy { get { return stt_createdBy; } set { stt_createdBy = value; } }

        public string creatorUser { get { return stt_creatorUser; } set { stt_creatorUser = value; } }

        public int modifiedBy { get { return stt_modifiedBy; } set { stt_modifiedBy = value; } }

        public string modificatorUser { get { return stt_modificatorUser; } set { stt_modificatorUser = value; } }



        //Constructor

        public clsStatus()
        {
            stt_codsec = 0;
            stt_name = "";
            stt_description = "";
            stt_fkStatusGroup = 0;
            stt_StatusGroupName = "";
            stt_createdDate = DateTime.Now;
            stt_modifiedDate = DateTime.Now;
            stt_createdBy = 0;
            stt_creatorUser = "";
            stt_modifiedBy = 0;
            stt_modificatorUser = "";
     
        }

        public clsStatus(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwStatus where stt_codsec =  " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_codsec"]);
                this.name = DS.Tables[0].Rows[0]["stt_name"].ToString();
                this.description = DS.Tables[0].Rows[0]["stt_description"].ToString();
                this.fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_fkStatusGroup"]);
                this.StatusGroupName = DS.Tables[0].Rows[0]["stt_StatusGroupName"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["stt_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["stt_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["stt_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["stt_modificatorUser"].ToString();
            }
            
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_status (stt_name, stt_description,stt_fkStatusGroup, stt_createdDate,stt_modifiedDate,stt_createdBy,stt_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += this.fkStatusGroup.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_status";
                    queryString += " SET ";
                    queryString += "stt_name =  '" + this.name.ToString() + "',";
                    queryString += "stt_description =  '" + this.description.ToString() + "',";
                    queryString += "stt_fkStatusGroup = " + this.fkStatusGroup.ToString() + ",";
                    queryString += "stt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "stt_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE stt_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsStatus.save");
                return false;
            }
        }

        public static List<clsStatus> getList()
        {
            List<clsStatus> lstCubeDetail = new List<clsStatus>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwstatus order by stt_StatusGroupName asc");

            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsStatus());
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"]);
                lstCubeDetail[i].fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_fkStatusGroup"]);
                lstCubeDetail[i].StatusGroupName = DS.Tables[0].Rows[i]["stt_statusGroupName"].ToString();
                lstCubeDetail[i].name = DS.Tables[0].Rows[i]["stt_name"].ToString();
                lstCubeDetail[i].description = DS.Tables[0].Rows[i]["stt_description"].ToString();
                lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_createdDate"]);
                lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_modifiedDate"]);
                lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_createdBy"]);
                lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_modifiedBy"]);
                lstCubeDetail[i].creatorUser = DS.Tables[0].Rows[i]["stt_creatorUser"].ToString();
                lstCubeDetail[i].modificatorUser = DS.Tables[0].Rows[i]["stt_modificatorUser"].ToString();
            }

            return lstCubeDetail;
        }
        public static List<clsStatus> getListByStatusGroup(int statusGroupCodsec)
        {
            List<clsStatus> lstCubeDetail = new List<clsStatus>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwstatus Where stt_fkStatusGroup = " + statusGroupCodsec.ToString());

            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsStatus());
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"]);
                lstCubeDetail[i].fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_fkStatusGroup"]);
                lstCubeDetail[i].StatusGroupName = DS.Tables[0].Rows[i]["stt_statusGroupName"].ToString();
                lstCubeDetail[i].name = DS.Tables[0].Rows[i]["stt_name"].ToString();
                lstCubeDetail[i].description = DS.Tables[0].Rows[i]["stt_description"].ToString();
                lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_createdDate"]);
                lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_modifiedDate"]);
                lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_createdBy"]);
                lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_modifiedBy"]);
                lstCubeDetail[i].creatorUser = DS.Tables[0].Rows[i]["stt_creatorUser"].ToString();
                lstCubeDetail[i].modificatorUser = DS.Tables[0].Rows[i]["stt_modificatorUser"].ToString();
            }

            return lstCubeDetail;
        }

        public static List<clsStatus> getListStatusGroupByStatus(int statusCodsec)
        {
            List<clsStatus> lstCubeDetail = new List<clsStatus>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwstatus Where stt_codsec = " + statusCodsec.ToString());

            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsStatus());
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"]);
                lstCubeDetail[i].fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_fkStatusGroup"]);
                lstCubeDetail[i].StatusGroupName = DS.Tables[0].Rows[i]["stt_statusGroupName"].ToString();
                lstCubeDetail[i].name = DS.Tables[0].Rows[i]["stt_name"].ToString();
                lstCubeDetail[i].description = DS.Tables[0].Rows[i]["stt_description"].ToString();
                lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_createdDate"]);
                lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_modifiedBy"]);
                lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_createdBy"]);
                lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_modifiedBy"]);
                lstCubeDetail[i].creatorUser = DS.Tables[0].Rows[i]["stt_creatorUser"].ToString();
                lstCubeDetail[i].modificatorUser = DS.Tables[0].Rows[i]["stt_modificatorUser"].ToString();
            }

            return lstCubeDetail;
        }




        public static List<clsStatus> getListByStatusGroupName(string statusGroupName)
        {
            List<clsStatus> lstCubeDetail = new List<clsStatus>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwstatus Where stt_StatusGroupName = '" + statusGroupName + "'");

            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsStatus());
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"]);
                lstCubeDetail[i].fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_fkStatusGroup"]);
                lstCubeDetail[i].StatusGroupName = DS.Tables[0].Rows[i]["stt_statusGroupName"].ToString();
                lstCubeDetail[i].name = DS.Tables[0].Rows[i]["stt_name"].ToString();
                lstCubeDetail[i].description = DS.Tables[0].Rows[i]["stt_description"].ToString();
                lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_createdDate"]);
                lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["stt_modifiedDate"]);
                lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_createdBy"]);
                lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_modifiedBy"]);
                lstCubeDetail[i].creatorUser = DS.Tables[0].Rows[i]["stt_creatorUser"].ToString();
                lstCubeDetail[i].modificatorUser = DS.Tables[0].Rows[i]["stt_modificatorUser"].ToString();
            }

            return lstCubeDetail;
        }
        public static clsStatus getStatusByStatusGroupNameAndStatusName(string statusGroupName, string statusName)
        {
            clsStatus objStatus = new clsStatus();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwstatus Where stt_StatusGroupName = '" + statusGroupName + "' AND stt_name = '" + statusName + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objStatus.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_codsec"]);
                objStatus.fkStatusGroup = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_fkStatusGroup"]);
                objStatus.StatusGroupName = DS.Tables[0].Rows[0]["stt_statusGroupName"].ToString();
                objStatus.name = DS.Tables[0].Rows[0]["stt_name"].ToString();
                objStatus.description = DS.Tables[0].Rows[0]["stt_description"].ToString();
                objStatus.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["stt_createdDate"]);
                objStatus.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["stt_modifiedDate"]);
                objStatus.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_createdBy"]);
                objStatus.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_modifiedBy"]);
                objStatus.creatorUser = DS.Tables[0].Rows[0]["stt_creatorUser"].ToString();
                objStatus.modificatorUser = DS.Tables[0].Rows[0]["stt_modificatorUser"].ToString();
            }

            return objStatus;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
