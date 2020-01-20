using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsSupplyByEntity
    {
        //Atributes

        private int spyentt_codsec;
        private int spyentt_fkEntity;
        private string spyentt_entityName;
        private int spyentt_fkSupply;
        private string spyentt_SupplyName;

        //Properties

        public int codsec { get { return spyentt_codsec; } set { spyentt_codsec = value; } }

        public int fkEntity { get { return spyentt_fkEntity; } set { spyentt_fkEntity = value; } }

        public string entityName { get { return spyentt_entityName; } set { spyentt_entityName = value; } }

        public int fkSupply { get { return spyentt_fkSupply; } set { spyentt_fkSupply = value; } }

        public string SupplyName { get { return spyentt_SupplyName; } set { spyentt_SupplyName = value; } }

        
        //Constructor

        public clsSupplyByEntity()
        { 
        spyentt_codsec = 0;
        spyentt_fkEntity = 0;
        spyentt_entityName = "";
        spyentt_fkSupply = 0;
        spyentt_SupplyName = "";
        
        }
        public clsSupplyByEntity(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT spyentt.`spybyentt_codsec`, entt.`entt_codsec` as spyentt_fkEntity, entt.`entt_companyName` as spyentt_entityName, spy.`spy_codsec` as spyentt_fkSupply, spy.`spy_name` as spyentt_SupplyName FROM `bps_prod_supply` spy, `bps_com_entity` entt, `bps_prod_supplybyentity` spyentt WHERE spy.`spy_codsec` = spyentt.`spybyentt_fkSupply` and entt.`entt_codsec` = spyentt.`spybyentt_fkEntity`");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spyentt_codsec"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["spyentt_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["spyentt_entityName"].ToString();
            this.fkSupply = Convert.ToInt32(DS.Tables[0].Rows[0]["spyentt_fkSupply"]);
            this.SupplyName = DS.Tables[0].Rows[0]["spyentt_SupplyName"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";
                
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supplybyentity (spybyentt_fkEntity,spybyentt_fkSupply)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkEntity + ",";
                    queryString += "" + this.fkSupply + ");";                   
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_supplybyentity";
                    queryString += " SET ";
                    queryString += "spybyentt_fkEntity = " + this.fkEntity + ",";
                    queryString += "spybyentt_fkSupply = " + this.fkSupply + ";";
                    queryString += " WHERE spybyentt_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplyByEntity.save");
                return false;
            }
        }

        public static List<clsSupplyByEntity> getList()
        {
            List<clsSupplyByEntity> lstSupplyByEntity = new List<clsSupplyByEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT spyentt.`spybyentt_codsec` as spyentt_codsec, entt.`entt_codsec` as spyentt_fkEntity, entt.`entt_companyName` as spyentt_entityName, spy.`spy_codsec` as spyentt_fkSupply, spy.`spy_name` as spyentt_SupplyName FROM `bps_prod_supply` spy, `bps_com_entity` entt, `bps_prod_supplybyentity` spyentt WHERE spy.`spy_codsec` = spyentt.`spybyentt_fkSupply` and entt.`entt_codsec` = spyentt.`spybyentt_fkEntity` order by spyentt_SupplyName asc");

            lstSupplyByEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyByEntity.Add(new clsSupplyByEntity());
                lstSupplyByEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_codsec"]);
                lstSupplyByEntity[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_fkEntity"]);
                lstSupplyByEntity[i].entityName = DS.Tables[0].Rows[i]["spyentt_entityName"].ToString();
                lstSupplyByEntity[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_fkSupply"]);
                lstSupplyByEntity[i].SupplyName = DS.Tables[0].Rows[i]["spyentt_SupplyName"].ToString();
                

            }

            return lstSupplyByEntity;
        }

        public static List<clsSupplyByEntity> getListByEntity(int entityCodsec)
        {
            List<clsSupplyByEntity> lstSupplyByEntity = new List<clsSupplyByEntity>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT spyentt.`spybyentt_codsec`, entt.`entt_codsec` as spyentt_fkEntity, entt.`entt_companyName` as spyentt_entityName, spy.`spy_codsec` as spyentt_fkSupply, spy.`spy_name` as spyentt_SupplyName FROM `bps_prod_supply` spy, `bps_com_entity` entt, `bps_prod_supplybyentity` spyentt WHERE spy.`spy_codsec` = spyentt.`spybyentt_fkSupply` and entt.`entt_codsec` = spyentt.`spybyentt_fkEntity` and spyentt.`spybyentt_fkEntity` = " + entityCodsec + " order by spyentt_SupplyName asc");

            lstSupplyByEntity.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyByEntity.Add(new clsSupplyByEntity());
                lstSupplyByEntity[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_codsec"]);
                lstSupplyByEntity[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_fkEntity"]);
                lstSupplyByEntity[i].entityName = DS.Tables[0].Rows[i]["spyentt_entityName"].ToString();
                lstSupplyByEntity[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["spyentt_fkSupply"]);
                lstSupplyByEntity[i].SupplyName = DS.Tables[0].Rows[i]["spyentt_SupplyName"].ToString();


            }

            return lstSupplyByEntity;
        }


      
    }
}
