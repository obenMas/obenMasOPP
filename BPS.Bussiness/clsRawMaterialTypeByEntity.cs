using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsRawMaterialTypeByEntity
    {
        
        //Atributes

        private int trwm_codsec;
        private string trwm_name;
        private int trwm_Entity;
        private string trwm_entityName;
        private int trwm_fkRawMaterialType;
        private string trwm_RawMaterialTypeName;
        private DateTime trwm_createdDate;
        private DateTime trwm_modifiedDate;
        private int trwm_createdBy;
        private string trwm_creatorUser;
        private int trwm_modifiedBy;
        private string trwm_modificatorUser;

        //Properties

        public int codsec { get { return trwm_codsec; } set { trwm_codsec = value; } }

        public string name { get { return trwm_name; } set { trwm_name = value; } }

        public int fkRawMaterialType { get { return trwm_fkRawMaterialType; } set { trwm_fkRawMaterialType = value; } }

        public string RawMaterialTypeName { get { return trwm_RawMaterialTypeName; } set { trwm_RawMaterialTypeName = value; } }

        public DateTime createdDate { get { return trwm_createdDate; } set { trwm_createdDate = value; } }

        public DateTime modifiedDate { get { return trwm_modifiedDate; } set { trwm_modifiedDate = value; } }

        public int createdBy { get { return trwm_createdBy; } set { trwm_createdBy = value; } }

        public string creatorUser { get { return trwm_creatorUser; } set { trwm_creatorUser = value; } }

        public int modifiedBy { get { return trwm_modifiedBy; } set { trwm_modifiedBy = value; } }

        public string modificatorUser { get { return trwm_modificatorUser; } set { trwm_modificatorUser = value; } }

        public int Entity { get { return trwm_Entity; } set { trwm_Entity = value; } }

        public string entityName { get { return trwm_entityName; } set { trwm_entityName = value; } }



        //Constructor

        public clsRawMaterialTypeByEntity()
        { 
        trwm_codsec = 0;
        trwm_name = "";
        trwm_fkRawMaterialType = 0;
        trwm_RawMaterialTypeName = "";
        trwm_createdDate = DateTime.Now;
        trwm_modifiedDate = DateTime.Now;
        trwm_createdBy = 0;
        trwm_creatorUser = "";
        trwm_modifiedBy = 0;
        trwm_modificatorUser = "";
        trwm_Entity = 0;
        trwm_entityName = "";

        }
        public clsRawMaterialTypeByEntity(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwrawmaterialtypebyentity where trwm_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_codsec"]);
            this.name = DS.Tables[0].Rows[0]["trwm_RawMaterialTypeName"].ToString();
            this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_fkRawMaterialType"]);
            this.RawMaterialTypeName = DS.Tables[0].Rows[0]["trwm_RawMaterialTypeName"].ToString();
            this.Entity = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["trwm_EntityName"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trwm_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trwm_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["trwm_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["trwm_modificatorUser"].ToString();
            
        }
        //Methods

        public static bool save(int fkRawMaterialType, int fkEntity)
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_rawmaterialtypebyentity (rwmtxent_fkRawMaterialtype,rwmtxent_fkEntity) VALUES(";
                queryString += fkRawMaterialType.ToString() + ",";
                queryString += fkEntity.ToString();
                queryString += ");";
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialTypeByEntity.save");
                return false;
            }


        }

        public static List<clsRawMaterialTypeByEntity> getList()
        {
            List<clsRawMaterialTypeByEntity> lstRawMaterialtype = new List<clsRawMaterialTypeByEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwrawmaterialtypebyentity order by trwm_codsec asc");

            lstRawMaterialtype.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialtype.Add(new clsRawMaterialTypeByEntity());
                lstRawMaterialtype[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_codsec"]);
                lstRawMaterialtype[i].name = DS.Tables[0].Rows[i]["trwm_RawMaterialTypeName"].ToString();
                lstRawMaterialtype[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_fkRawMaterialType"]);
                lstRawMaterialtype[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["trwm_RawMaterialTypeName"].ToString();
                lstRawMaterialtype[i].Entity = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_fkEntity"]);
                lstRawMaterialtype[i].entityName = DS.Tables[0].Rows[i]["trwm_EntityName"].ToString();
                lstRawMaterialtype[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_createdDate"]);
                lstRawMaterialtype[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_modifiedDate"]);
                lstRawMaterialtype[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_createdBy"]);
                lstRawMaterialtype[i].creatorUser = DS.Tables[0].Rows[i]["trwm_creatorUser"].ToString();
                lstRawMaterialtype[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_modifiedBy"]);
                lstRawMaterialtype[i].modificatorUser = DS.Tables[0].Rows[i]["trwm_modificatorUser"].ToString();

            }

            return lstRawMaterialtype;
        }

        public static List<clsRawMaterialTypeByEntity> getListByEntity(int entityCodsec)
        {
            List<clsRawMaterialTypeByEntity> lstRawMaterialtypeByEntity = new List<clsRawMaterialTypeByEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwrawmaterialtypebyentity where trwm_fkentity = " + entityCodsec + " order by trwm_codsec asc");

            lstRawMaterialtypeByEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialtypeByEntity.Add(new clsRawMaterialTypeByEntity());
                lstRawMaterialtypeByEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_codsec"]);
                lstRawMaterialtypeByEntity[i].name = DS.Tables[0].Rows[i]["trwm_RawMaterialTypeName"].ToString();
                lstRawMaterialtypeByEntity[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_fkRawMaterialType"]);
                lstRawMaterialtypeByEntity[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["trwm_RawMaterialTypeName"].ToString();
                lstRawMaterialtypeByEntity[i].Entity = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_fkEntity"]);
                lstRawMaterialtypeByEntity[i].entityName = DS.Tables[0].Rows[i]["trwm_EntityName"].ToString();
                lstRawMaterialtypeByEntity[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_createdDate"]);
                lstRawMaterialtypeByEntity[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_modifiedDate"]);
                lstRawMaterialtypeByEntity[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_createdBy"]);
                lstRawMaterialtypeByEntity[i].creatorUser = DS.Tables[0].Rows[i]["trwm_creatorUser"].ToString();
                lstRawMaterialtypeByEntity[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_modifiedBy"]);
                lstRawMaterialtypeByEntity[i].modificatorUser = DS.Tables[0].Rows[i]["trwm_modificatorUser"].ToString();

            }

            return lstRawMaterialtypeByEntity;
        }

       

        public static void clearRawMaterialTypeByEntity(int rawMaterialTypeCodsec)
        {

            string queryString = "";

            queryString += "DELETE FROM bps_prod_rawmaterialtypebyentity where rwmtxent_fkRawMaterialtype = " + rawMaterialTypeCodsec.ToString() + ";";
            clsConnection.executeQuery(queryString);

        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialtypebyentity ORDER BY rwmtxent_fkRawMaterialtype DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["rwmtxent_fkRawMaterialtype"]);

        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
