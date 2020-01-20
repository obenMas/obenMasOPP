using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRequestUser : clsMyHerency
    {
        public clsRequestUser()
        {
            codsec = 0;
            fkType = 0;
            fkRol = 0;
            fkStatus = 0;
            fkUser = 0;
            number = 0;
            priority = string.Empty;
            source = string.Empty;
            manager = string.Empty;
            firstName = string.Empty;
            lastName = string.Empty;
            id = string.Empty;
            notes = string.Empty;
            isVisible = true;
            createdDate = DateTime.Now;
            modifiedDate = DateTime.Now;
            createdBy = 0;
            modifiedBy = 0;
            isApprovedDate = DateTime.Now;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_requestuser (req_fkType,req_fkRol,req_fkStatus,req_fkUser,req_number,req_priority,req_departament,req_manager,req_firtsName,req_lastName,req_id,req_notes,req_isVisible,req_createdDate,req_modifiedDate,req_createdBy,req_modifedBy)";
                    queryString += " VALUES (";
                    queryString += this.fkType.ToString() + ",";
                    queryString += this.fkRol.ToString() + ",";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += this.fkUser.ToString() + ",";
                    queryString += this.number.ToString() + ",";
                    queryString += "'" + this.priority + "',";
                    queryString += "'" + this.source + "',";
                    queryString += "'" + this.manager + "',";
                    queryString += "'" + this.firstName + "',";
                    queryString += "'" + this.lastName + "',";
                    queryString += "'" + this.id + "',";
                    queryString += "'" + this.notes + "',";
                    queryString += this.isVisible.ToString() + ",";
                    queryString += "GETDATE(),";
                    queryString += "GETDATE(),";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + "";
                    queryString += ");";

                }
                else
                {
                    //queryString += "UPDATE bps_prod_formulation";
                    //queryString += " SET ";
                    //queryString += "frml_name = '" + this.name + "',";
                    //queryString += "frml_description = '" + this.description + "',";
                    //queryString += "frml_thick = " + this.thick.ToString() + ",";
                    //queryString += "frml_thickLayerC1 = " + this.thickLayerC1.ToString() + ",";
                    //queryString += "frml_thickLayerC2 = " + this.thickLayerC2.ToString() + ",";
                    //queryString += "frml_thickCentralLayer = " + this.thickCentralLayer.ToString() + ",";
                    //queryString += "frml_fkBopp = " + this.fkBopp.ToString() + "";
                    //queryString += " WHERE frml_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulation.save");
                return false;
            }
        }

        public static int getLastNumber()
        {
            int result = 0;

            try
            {
                DataSet DS = new DataSet();
                DataSet Ds = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT dbo.fnGenerateNumberRequest(0) AS req_number");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    result = Convert.ToInt32(DS.Tables[0].Rows[0]["req_number"].ToString());
                    if (result == 0)
                        result += 1;
                }
                else
                    result = 0;

                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'lastCodsec',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            return Convert.ToInt32(DS.Tables[0].Rows[0]["req_codsec"]);
        }

        public void LoadByCodsec(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'RequestUserByCodsec'," + codsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["req_codsec"].ToString());
                this.fkType = Convert.ToInt32(DS.Tables[0].Rows[0]["treq_codsec"].ToString());
                this.source = DS.Tables[0].Rows[0]["treq_source"].ToString();
                this.name = DS.Tables[0].Rows[0]["treq_name"].ToString();
                this.rolName = DS.Tables[0].Rows[0]["role_name"].ToString();
                this.statusCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["stt_codsec"].ToString());
                this.statusName = DS.Tables[0].Rows[0]["stt_name"].ToString();
                this.userCodsecForRequest = Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"].ToString());
                this.userForRequestUserName = DS.Tables[0].Rows[0]["usr_userName"].ToString();
                this.userForRequestFirtsName = DS.Tables[0].Rows[0]["usr_firstName"].ToString();
                this.userForRequestLastName = DS.Tables[0].Rows[0]["usr_lastName"].ToString();
                this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["req_number"].ToString());
                this.priority = DS.Tables[0].Rows[0]["req_priority"].ToString();
                this.departament = DS.Tables[0].Rows[0]["req_departament"].ToString();
                this.manager = DS.Tables[0].Rows[0]["req_manager"].ToString();
                this.firstName = DS.Tables[0].Rows[0]["req_firtsName"].ToString();
                this.lastName = DS.Tables[0].Rows[0]["req_lastName"].ToString();
                this.id = DS.Tables[0].Rows[0]["req_id"].ToString();
                this.notes = DS.Tables[0].Rows[0]["req_notes"].ToString();
                this.isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["req_isVisible"], DS.Tables[0].Rows[0]["req_isVisible"].GetType().FullName);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["req_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["req_modifiedDate"]);
                this.lstUserCreator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[0]["req_createdBy"].ToString()));
                this.lstUserModificator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[0]["req_modifedBy"].ToString()));
                this.lstUserMain = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[0]["usr_codsec"].ToString()));
                this.isApprovedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["req_isApprovedDate"]);
                this.isApprovedNotes = DS.Tables[0].Rows[0]["req_isApprovedNotes"].ToString();
            }
        }


        public static List<clsRequestUser> getList()
        {
            List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'ActiveList',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRequestUser.Add(new clsRequestUser());
                    lstRequestUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["req_codsec"].ToString());
                    lstRequestUser[i].fkType = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                    lstRequestUser[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                    lstRequestUser[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                    lstRequestUser[i].rolName = DS.Tables[0].Rows[i]["role_name"].ToString();
                    lstRequestUser[i].statusCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"].ToString());
                    lstRequestUser[i].statusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstRequestUser[i].userCodsecForRequest = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString());
                    lstRequestUser[i].userForRequestUserName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstRequestUser[i].userForRequestFirtsName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                    lstRequestUser[i].userForRequestLastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                    lstRequestUser[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["req_number"].ToString());
                    lstRequestUser[i].priority = DS.Tables[0].Rows[i]["req_priority"].ToString();
                    lstRequestUser[i].departament = DS.Tables[0].Rows[i]["req_departament"].ToString();
                    lstRequestUser[i].manager = DS.Tables[0].Rows[i]["req_manager"].ToString();
                    lstRequestUser[i].firstName = DS.Tables[0].Rows[i]["req_firtsName"].ToString();
                    lstRequestUser[i].lastName = DS.Tables[0].Rows[i]["req_lastName"].ToString();
                    lstRequestUser[i].id = DS.Tables[0].Rows[i]["req_id"].ToString();
                    lstRequestUser[i].notes = DS.Tables[0].Rows[i]["req_notes"].ToString();
                    lstRequestUser[i].isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["req_isVisible"], DS.Tables[0].Rows[i]["req_isVisible"].GetType().FullName);
                    lstRequestUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_createdDate"]);
                    lstRequestUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_modifiedDate"]);
                    lstRequestUser[i].lstUserCreator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_createdBy"].ToString()));
                    lstRequestUser[i].lstUserModificator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_modifedBy"].ToString()));
                    lstRequestUser[i].lstUserMain = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString()));
                }
            }
            return lstRequestUser;
        }

        public static bool isApproved(int codsec, bool isApproved, string notes)
        {
            string queryString = "";
            if (isApproved)
            {
                queryString += "UPDATE bps_prod_requestuser ";
                queryString += " SET ";
                queryString += "req_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Aprobada").codsec.ToString() + ",";
                queryString += "req_isApproved = " + isApproved.ToString() + ",";
                queryString += "req_isApprovedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "req_isApprovedNotes = '" + notes + "', ";
                queryString += "req_isApprovedBy =" + clsGlobal.LoggedUser.codsec + "";
                queryString += " WHERE req_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            else
            {
                queryString += "UPDATE bps_prod_requestuser ";
                queryString += " SET ";
                queryString += "req_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Negada").codsec.ToString() + ",";
                queryString += "req_isApproved = " + isApproved.ToString() + ",";
                queryString += "req_isApprovedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "req_isApprovedNotes = '" + notes + "', ";
                queryString += "req_isApprovedBy =" + clsGlobal.LoggedUser.codsec + "";
                queryString += " WHERE req_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
        }

        public static bool isDeleted(int codsec)
        {
            string queryString = "";
            queryString += "UPDATE bps_prod_requestuser ";
            queryString += " SET ";
            queryString += "req_isApproved = 0,";
            queryString += "req_isVisible = 0,";
            queryString += "req_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Eliminada").codsec + ",";
            queryString += "req_isApprovedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "req_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "req_isApprovedNotes = 'Solicitud Eliminada', ";
            queryString += "req_isApprovedBy =" + clsGlobal.LoggedUser.codsec + ",";
            queryString += "req_modifedBy =" + clsGlobal.LoggedUser.codsec + "";
            queryString += " WHERE coil_codsec = " + codsec.ToString() + ";";
            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public static List<clsRequestUser> getListByFilterID(string id)
        {
            List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'ActiveListByFilterID',0,'" + id.ToUpper() + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRequestUser.Add(new clsRequestUser());
                    lstRequestUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["req_codsec"].ToString());
                    lstRequestUser[i].fkType = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                    lstRequestUser[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                    lstRequestUser[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                    lstRequestUser[i].rolName = DS.Tables[0].Rows[i]["role_name"].ToString();
                    lstRequestUser[i].statusCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"].ToString());
                    lstRequestUser[i].statusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstRequestUser[i].userCodsecForRequest = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString());
                    lstRequestUser[i].userForRequestUserName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstRequestUser[i].userForRequestFirtsName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                    lstRequestUser[i].userForRequestLastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                    lstRequestUser[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["req_number"].ToString());
                    lstRequestUser[i].priority = DS.Tables[0].Rows[i]["req_priority"].ToString();
                    lstRequestUser[i].departament = DS.Tables[0].Rows[i]["req_departament"].ToString();
                    lstRequestUser[i].manager = DS.Tables[0].Rows[i]["req_manager"].ToString();
                    lstRequestUser[i].firstName = DS.Tables[0].Rows[i]["req_firtsName"].ToString();
                    lstRequestUser[i].lastName = DS.Tables[0].Rows[i]["req_lastName"].ToString();
                    lstRequestUser[i].id = DS.Tables[0].Rows[i]["req_id"].ToString();
                    lstRequestUser[i].notes = DS.Tables[0].Rows[i]["req_notes"].ToString();
                    lstRequestUser[i].isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["req_isVisible"], DS.Tables[0].Rows[i]["req_isVisible"].GetType().FullName);
                    lstRequestUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_createdDate"]);
                    lstRequestUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_modifiedDate"]);
                    lstRequestUser[i].lstUserCreator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_createdBy"].ToString()));
                    lstRequestUser[i].lstUserModificator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_modifedBy"].ToString()));
                    lstRequestUser[i].lstUserMain = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString()));
                }
            }
            return lstRequestUser;
        }

        public static List<clsRequestUser> getListByFilterNumber(string number)
        {
            List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'ActiveListByFilterNumber',0,'" + number.ToUpper() + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRequestUser.Add(new clsRequestUser());
                    lstRequestUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["req_codsec"].ToString());
                    lstRequestUser[i].fkType = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                    lstRequestUser[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                    lstRequestUser[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                    lstRequestUser[i].rolName = DS.Tables[0].Rows[i]["role_name"].ToString();
                    lstRequestUser[i].statusCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"].ToString());
                    lstRequestUser[i].statusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstRequestUser[i].userCodsecForRequest = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString());
                    lstRequestUser[i].userForRequestUserName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstRequestUser[i].userForRequestFirtsName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                    lstRequestUser[i].userForRequestLastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                    lstRequestUser[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["req_number"].ToString());
                    lstRequestUser[i].priority = DS.Tables[0].Rows[i]["req_priority"].ToString();
                    lstRequestUser[i].departament = DS.Tables[0].Rows[i]["req_departament"].ToString();
                    lstRequestUser[i].manager = DS.Tables[0].Rows[i]["req_manager"].ToString();
                    lstRequestUser[i].firstName = DS.Tables[0].Rows[i]["req_firtsName"].ToString();
                    lstRequestUser[i].lastName = DS.Tables[0].Rows[i]["req_lastName"].ToString();
                    lstRequestUser[i].id = DS.Tables[0].Rows[i]["req_id"].ToString();
                    lstRequestUser[i].notes = DS.Tables[0].Rows[i]["req_notes"].ToString();
                    lstRequestUser[i].isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["req_isVisible"], DS.Tables[0].Rows[i]["req_isVisible"].GetType().FullName);
                    lstRequestUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_createdDate"]);
                    lstRequestUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_modifiedDate"]);
                    lstRequestUser[i].lstUserCreator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_createdBy"].ToString()));
                    lstRequestUser[i].lstUserModificator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_modifedBy"].ToString()));
                    lstRequestUser[i].lstUserMain = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString()));
                }
            }
            return lstRequestUser;
        }

        public static List<clsRequestUser> getListByFilterStatus(int status)
        {
            List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'ActiveListByFilterStatus'," + status.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRequestUser.Add(new clsRequestUser());
                    lstRequestUser[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["req_codsec"].ToString());
                    lstRequestUser[i].fkType = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                    lstRequestUser[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                    lstRequestUser[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                    lstRequestUser[i].rolName = DS.Tables[0].Rows[i]["role_name"].ToString();
                    lstRequestUser[i].statusCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stt_codsec"].ToString());
                    lstRequestUser[i].statusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstRequestUser[i].userCodsecForRequest = Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString());
                    lstRequestUser[i].userForRequestUserName = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstRequestUser[i].userForRequestFirtsName = DS.Tables[0].Rows[i]["usr_firstName"].ToString();
                    lstRequestUser[i].userForRequestLastName = DS.Tables[0].Rows[i]["usr_lastName"].ToString();
                    lstRequestUser[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["req_number"].ToString());
                    lstRequestUser[i].priority = DS.Tables[0].Rows[i]["req_priority"].ToString();
                    lstRequestUser[i].departament = DS.Tables[0].Rows[i]["req_departament"].ToString();
                    lstRequestUser[i].manager = DS.Tables[0].Rows[i]["req_manager"].ToString();
                    lstRequestUser[i].firstName = DS.Tables[0].Rows[i]["req_firtsName"].ToString();
                    lstRequestUser[i].lastName = DS.Tables[0].Rows[i]["req_lastName"].ToString();
                    lstRequestUser[i].id = DS.Tables[0].Rows[i]["req_id"].ToString();
                    lstRequestUser[i].notes = DS.Tables[0].Rows[i]["req_notes"].ToString();
                    lstRequestUser[i].isVisible = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["req_isVisible"], DS.Tables[0].Rows[i]["req_isVisible"].GetType().FullName);
                    lstRequestUser[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_createdDate"]);
                    lstRequestUser[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["req_modifiedDate"]);
                    lstRequestUser[i].lstUserCreator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_createdBy"].ToString()));
                    lstRequestUser[i].lstUserModificator = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["req_modifedBy"].ToString()));
                    lstRequestUser[i].lstUserMain = clsUser.getListByCodsec(Convert.ToInt32(DS.Tables[0].Rows[i]["usr_codsec"].ToString()));
                }
            }
            return lstRequestUser;
        }
    }
}
