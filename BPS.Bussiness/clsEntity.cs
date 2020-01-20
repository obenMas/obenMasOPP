using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja entidades (Clientes y Proveedores)
    /// </summary>
    public class clsEntity
    {
        //Atributes

        private int entt_codsec;
        private int entt_fkIdType;
        private string entt_TypeName;
        private int entt_fkCountry;
        private string entt_countryName;
        private int entt_fkStatus;
        private string entt_statusName;
        private string entt_id;
        private string entt_companyName;
        private string entt_contactName;
        private Boolean entt_isCustomer;
        private Boolean entt_isProvider;
        private int entt_fkSegmentation;
        private int entt_fkUser;
        private string entt_AymasName;


        //Properties

        public int codsec { get { return entt_codsec; } set { entt_codsec = value; } }

        public int fkIdType { get { return entt_fkIdType; } set { entt_fkIdType = value; } }

        public string TypeName { get { return entt_TypeName; } set { entt_TypeName = value; } }

        public int fkCountry { get { return entt_fkCountry; } set { entt_fkCountry = value; } }

        public string countryName { get { return entt_countryName; } set { entt_countryName = value; } }

        public int fkStatus { get { return entt_fkStatus; } set { entt_fkStatus = value; } }

        public string statusName { get { return entt_statusName; } set { entt_statusName = value; } }

        public string id { get { return entt_id; } set { entt_id = value; } }

        public string companyName { get { return entt_companyName; } set { entt_companyName = value; } }

        public string contactName { get { return entt_contactName; } set { entt_contactName = value; } }

        public Boolean isCustomer { get { return entt_isCustomer; } set { entt_isCustomer = value; } }

        public Boolean isProvider { get { return entt_isProvider; } set { entt_isProvider = value; } }

        public int fkSegmentation { get { return entt_fkSegmentation; } set { entt_fkSegmentation = value; } }

        public int fkUser { get { return entt_fkUser; } set { entt_fkUser = value; } }

        public string AymasName { get { return entt_AymasName; } set { entt_AymasName = value; } }


        //Constructor

        public clsEntity()
        {
            entt_codsec = 0;
            entt_fkIdType = 0;
            entt_TypeName = "";
            entt_fkCountry = 0;
            entt_countryName = "";
            entt_fkStatus = 0;
            entt_statusName = "";
            entt_id = "";
            entt_companyName = "";
            entt_contactName = "";
            entt_isCustomer = false;
            entt_isProvider = false;
            entt_fkSegmentation = 0;
            entt_fkUser = 0;
            entt_AymasName = "";
        }

        public clsEntity(int codsec)
        {
            this.load(codsec);
        }

        public clsEntity(string data)
        {
            this.load(data);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                this.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                this.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                this.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                this.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                this.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                this.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                this.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                this.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                this.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();
            }
        }

        public void load(string codsec, string data)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_id = '" + codsec + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                this.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                this.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                this.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                this.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                this.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                this.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                this.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                this.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                this.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();
            }
        }

        public void load(string data)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_companyName = '" + data + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                this.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                this.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                this.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                this.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                this.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                this.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                this.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                this.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                this.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();
            }
        }

        public void load(string codsec, string data, string test)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_companyName = '" + data + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                this.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                this.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                this.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                this.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                this.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                this.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                this.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                this.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                this.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();
            }
        }

        public void load()
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                this.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                this.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                this.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                this.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                this.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                this.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                this.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                this.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                this.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                this.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                this.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();
            }
        }

        public static clsEntity getCustomerById(string id)
        {
            clsEntity objEntity = new clsEntity();
            DataSet DS = new DataSet();

            try
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_isCustomer = True and entt_id = '" + id + "'");

                objEntity.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                objEntity.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                objEntity.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                objEntity.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                objEntity.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                objEntity.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                objEntity.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                objEntity.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                objEntity.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                objEntity.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                objEntity.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                objEntity.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                objEntity.fkSegmentation= Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                objEntity.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                objEntity.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();

                return objEntity;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsEntity.getCustomerById");
                objEntity = new clsEntity();
                return objEntity;
            }
        }

        public static clsEntity getProviderById(string id)
        {
            clsEntity objEntity = new clsEntity();
            DataSet DS = new DataSet();

            try
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwEntity where entt_isProvider = True and entt_id = '" + id + "'");

                objEntity.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
                objEntity.fkIdType = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkIdType"]);
                objEntity.TypeName = DS.Tables[0].Rows[0]["entt_TypeName"].ToString();
                objEntity.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkCountry"]);
                objEntity.countryName = DS.Tables[0].Rows[0]["entt_countryName"].ToString();
                objEntity.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkStatus"]);
                objEntity.statusName = DS.Tables[0].Rows[0]["entt_StatusName"].ToString();
                objEntity.id = DS.Tables[0].Rows[0]["entt_id"].ToString();
                objEntity.companyName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                objEntity.contactName = DS.Tables[0].Rows[0]["entt_contactName"].ToString();
                objEntity.isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isCustomer"], DS.Tables[0].Rows[0]["entt_isCustomer"].GetType().FullName);
                objEntity.isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["entt_isProvider"], DS.Tables[0].Rows[0]["entt_isProvider"].GetType().FullName);
                objEntity.fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkSegmentation"]);
                objEntity.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["entt_fkUser"]);
                objEntity.AymasName = DS.Tables[0].Rows[0]["entt_AymasName"].ToString();

                return objEntity;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsEntity.getProviderById");
                objEntity = new clsEntity();
                return objEntity;
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_com_entity (entt_fkIdType,entt_fkCountry,entt_fkStatus,entt_id,entt_companyName,entt_contactName,entt_isCustomer,entt_isProvider,entt_fkSegmentation,entt_fkUser, entt_AymasName)";
                    queryString += " VALUES ( ";
                    queryString += this.fkIdType.ToString() + ", ";
                    queryString += this.fkCountry.ToString() + ", ";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += "'" + this.id + "', ";
                    queryString += "'" + this.companyName + "', ";
                    queryString += "'" + this.contactName + "', ";
                    queryString += this.isCustomer.ToString() + ", ";
                    queryString += this.isProvider.ToString() + ", ";
                    queryString += this.fkSegmentation.ToString() + ", ";
                    queryString += this.fkUser.ToString() + ", ";
                    queryString += "'" + this.AymasName.ToString() + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_com_entity";
                    queryString += " SET ";
                    queryString += "entt_fkIdType = " + this.fkIdType.ToString() + ",";
                    queryString += "entt_fkCountry = " + this.fkCountry.ToString() + ",";
                    queryString += "entt_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "entt_id = '" + this.id + "',";
                    queryString += "entt_companyName = '" + this.companyName + "',";
                    queryString += "entt_contactName = '" + this.contactName + "',";
                    queryString += "entt_isCustomer = " + this.isCustomer.ToString() + ",";
                    queryString += "entt_isProvider = " + this.isProvider.ToString() + ",";
                    queryString += "entt_fkSegmentation = " + this.fkSegmentation.ToString() + ",";
                    queryString += "entt_fkUser = " + this.fkUser.ToString() + ", ";
                    queryString += "entt_AymasName = '" + this.AymasName.ToString() + "' ";
                    queryString += " WHERE entt_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);



            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsEntity.save");
                return false;
            }

        }

        public static List<clsEntity> getList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwentity order by entt_companyName asc");

            lstEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntity.Add(new clsEntity());
                lstEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_codsec"]);
                lstEntity[i].fkIdType = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkIdType"]);
                lstEntity[i].TypeName = DS.Tables[0].Rows[i]["entt_TypeName"].ToString();
                lstEntity[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkCountry"]);
                lstEntity[i].countryName = DS.Tables[0].Rows[i]["entt_countryName"].ToString();
                lstEntity[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkStatus"]);
                lstEntity[i].statusName = DS.Tables[0].Rows[i]["entt_StatusName"].ToString();
                lstEntity[i].id = DS.Tables[0].Rows[i]["entt_id"].ToString();
                lstEntity[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstEntity[i].contactName = DS.Tables[0].Rows[i]["entt_contactName"].ToString();
                lstEntity[i].isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isCustomer"], DS.Tables[0].Rows[i]["entt_isCustomer"].GetType().FullName);
                lstEntity[i].isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isProvider"], DS.Tables[0].Rows[i]["entt_isProvider"].GetType().FullName);
                lstEntity[i].fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkSegmentation"]);
                lstEntity[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkUser"]);
                lstEntity[i].AymasName = DS.Tables[0].Rows[i]["entt_AymasName"].ToString(); 
            }

            return lstEntity;
        }

        public static List<clsEntity> getCustomerList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwentity WHERE entt_isCustomer = '1' ORDER BY entt_companyName asc");

            lstEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntity.Add(new clsEntity());
                lstEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_codsec"]);
                lstEntity[i].fkIdType = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkIdType"]);
                lstEntity[i].TypeName = DS.Tables[0].Rows[i]["entt_TypeName"].ToString();
                lstEntity[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkCountry"]);
                lstEntity[i].countryName = DS.Tables[0].Rows[i]["entt_countryName"].ToString();
                lstEntity[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkStatus"]);
                lstEntity[i].statusName = DS.Tables[0].Rows[i]["entt_StatusName"].ToString();
                lstEntity[i].id = DS.Tables[0].Rows[i]["entt_id"].ToString();
                lstEntity[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstEntity[i].contactName = DS.Tables[0].Rows[i]["entt_contactName"].ToString();
                lstEntity[i].isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isCustomer"], DS.Tables[0].Rows[i]["entt_isCustomer"].GetType().FullName);
                lstEntity[i].isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isProvider"], DS.Tables[0].Rows[i]["entt_isProvider"].GetType().FullName);
                lstEntity[i].fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkSegmentation"]);
                lstEntity[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkUser"]);
                lstEntity[i].AymasName = DS.Tables[0].Rows[i]["entt_AymasName"].ToString();
            }

            return lstEntity;
        }

        public static List<clsEntity> getCustomerListByFilter(List<clsFilter> lstFilter)
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);


            DS = clsConnection.getDataSetResult("SELECT * FROM vwentity WHERE entt_isCustomer = True " + where + " ORDER BY entt_companyName asc");

            lstEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntity.Add(new clsEntity());
                lstEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_codsec"]);
                lstEntity[i].fkIdType = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkIdType"]);
                lstEntity[i].TypeName = DS.Tables[0].Rows[i]["entt_TypeName"].ToString();
                lstEntity[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkCountry"]);
                lstEntity[i].countryName = DS.Tables[0].Rows[i]["entt_countryName"].ToString();
                lstEntity[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkStatus"]);
                lstEntity[i].statusName = DS.Tables[0].Rows[i]["entt_StatusName"].ToString();
                lstEntity[i].id = DS.Tables[0].Rows[i]["entt_id"].ToString();
                lstEntity[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstEntity[i].contactName = DS.Tables[0].Rows[i]["entt_contactName"].ToString();
                lstEntity[i].isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isCustomer"], DS.Tables[0].Rows[i]["entt_isCustomer"].GetType().FullName);
                lstEntity[i].isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isProvider"], DS.Tables[0].Rows[i]["entt_isProvider"].GetType().FullName);
                lstEntity[i].fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkSegmentation"]);
                lstEntity[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkUser"]);
                lstEntity[i].AymasName = DS.Tables[0].Rows[i]["entt_AymasName"].ToString();
            }

            return lstEntity;
        }

        public static List<clsEntity> getProviderList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            DataSet DS = new DataSet();
            //Nahuel: no encuentro entt_isVisible en vwentity, saco del string "AND entt_isVisible = True " antes de ORDER BY
            DS = clsConnection.getDataSetResult("SELECT * FROM vwentity WHERE entt_isProvider = True ORDER BY entt_companyName ASC");

            lstEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntity.Add(new clsEntity());
                lstEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_codsec"]);
                lstEntity[i].fkIdType = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkIdType"]);
                lstEntity[i].TypeName = DS.Tables[0].Rows[i]["entt_TypeName"].ToString();
                lstEntity[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkCountry"]);
                lstEntity[i].countryName = DS.Tables[0].Rows[i]["entt_countryName"].ToString();
                lstEntity[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkStatus"]);
                lstEntity[i].statusName = DS.Tables[0].Rows[i]["entt_StatusName"].ToString();
                lstEntity[i].id = DS.Tables[0].Rows[i]["entt_id"].ToString();
                lstEntity[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstEntity[i].contactName = DS.Tables[0].Rows[i]["entt_contactName"].ToString();
                lstEntity[i].isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isCustomer"], DS.Tables[0].Rows[i]["entt_isCustomer"].GetType().FullName);
                lstEntity[i].isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isProvider"], DS.Tables[0].Rows[i]["entt_isProvider"].GetType().FullName);
                lstEntity[i].fkSegmentation = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkSegmentation"]);
                lstEntity[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkUser"]);
                lstEntity[i].AymasName = DS.Tables[0].Rows[i]["entt_AymasName"].ToString();
            }

            return lstEntity;
        }

        public static List<clsEntity> getProviderListByFilter(List<clsFilter> lstFilter)
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwentity WHERE entt_isProvider = True " + where + " AND entt_isVisible = True ORDER BY entt_companyName ASC");

            lstEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntity.Add(new clsEntity());
                lstEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_codsec"]);
                lstEntity[i].fkIdType = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkIdType"]);
                lstEntity[i].TypeName = DS.Tables[0].Rows[i]["entt_TypeName"].ToString();
                lstEntity[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkCountry"]);
                lstEntity[i].countryName = DS.Tables[0].Rows[i]["entt_countryName"].ToString();
                lstEntity[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_fkStatus"]);
                lstEntity[i].statusName = DS.Tables[0].Rows[i]["entt_StatusName"].ToString();
                lstEntity[i].id = DS.Tables[0].Rows[i]["entt_id"].ToString();
                lstEntity[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstEntity[i].contactName = DS.Tables[0].Rows[i]["entt_contactName"].ToString();
                lstEntity[i].isCustomer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isCustomer"], DS.Tables[0].Rows[i]["entt_isCustomer"].GetType().FullName);
                lstEntity[i].isProvider = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["entt_isProvider"], DS.Tables[0].Rows[i]["entt_isProvider"].GetType().FullName);
                lstEntity[i].AymasName = DS.Tables[0].Rows[i]["entt_AymasName"].ToString();
            }

            return lstEntity;
        }

        public static int getLastSavedCustomerCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT entt_codsec FROM vwEntity where entt_isCustomer = True Order By entt_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
        }

        public static int getLastSavedProviderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT entt_codsec FROM vwEntity where entt_isProvider = True Order By entt_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["entt_codsec"]);
        }

        public override string ToString()
        {
            return this.companyName;
        }
        public static string getObenName(string AymasName)
        {
            string obenName = "";
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT entt_companyName from bps_com_entity WHERE entt_AymasName='"+AymasName+"'" );
            if(DS.Tables[0].Rows.Count>0)
            {
                obenName = DS.Tables[0].Rows[0]["entt_companyName"].ToString();
            }
            else
            {
                obenName = "NOMBRE NO ENCONTRADO";
            }
            return obenName;
        }

    }
}

