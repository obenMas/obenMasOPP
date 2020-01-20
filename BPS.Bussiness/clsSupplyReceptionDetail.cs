using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSupplyReceptionDetail
    {

        //Atributes

        private int spybr_codsec;
        private int spybr_fkReception;
        private double spybr_weigthPerPackage;
        private int spybr_unitsPerPackage;
        private double spybr_unitWeigth;
        private int spybr_availableUnitsPerpackage;
        private string spybr_codePackage;
        private int spybr_fkEntity;
        private string spybr_entityName;
        private int spybr_fkSupply;
        private string spybr_supplyName;
        private string spybr_supplyCode;
        private int spybr_fkUnit;
        private string spybr_unitName;

        //Properties

        public int codsec { get { return spybr_codsec; } set { spybr_codsec = value; } }

        public int fkReception { get { return spybr_fkReception; } set { spybr_fkReception = value; } }

        public double weigthPerPackage { get { return spybr_weigthPerPackage; } set { spybr_weigthPerPackage = value; } }

        public int unitsPerPackage { get { return spybr_unitsPerPackage; } set { spybr_unitsPerPackage = value; } }

        public double unitWeigth { get { return spybr_unitWeigth; } set { spybr_unitWeigth = value; } }

        public int availableUnitsPerpackage { get { return spybr_availableUnitsPerpackage; } set { spybr_availableUnitsPerpackage = value; } }

        public string codePackage { get { return spybr_codePackage; } set { spybr_codePackage = value; } }

        public int fkEntity { get { return spybr_fkEntity; } set { spybr_fkEntity = value; } }

        public string entityName { get { return spybr_entityName; } set { spybr_entityName = value; } }

        public int fkSupply { get { return spybr_fkSupply; } set { spybr_fkSupply = value; } }

        public string supplyCode { get { return spybr_supplyCode; } set { spybr_supplyCode = value; } }

        public string supplyName { get { return spybr_supplyName; } set { spybr_supplyName = value; } }

        public int fkUnit { get { return spybr_fkUnit; } set { spybr_fkUnit = value; } }

        public string unitName { get { return spybr_unitName; } set { spybr_unitName = value; } }


          //Constructor

        public clsSupplyReceptionDetail()
        {
            spybr_codsec = 0;
            spybr_fkReception = 0;
            spybr_weigthPerPackage = 0;
            spybr_unitsPerPackage = 0;
            spybr_unitWeigth = 0;
            spybr_availableUnitsPerpackage = 0;
            spybr_codePackage = "";
            spybr_fkEntity = 0;
            spybr_entityName = "";
            spybr_fkSupply = 0;
            spybr_supplyName = "";
            spybr_supplyCode = "";
            spybr_fkUnit = 0;
            spybr_unitName = "";
        }

        public clsSupplyReceptionDetail(int codsec)
            {
                this.load(codsec);
            }

            //Methods

            public void load(int codsec)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT spybyrcp.`spybr_codsec` as spybr_codsec, spyrcp.`rcpspy_codsec` as spybr_fkReception,spybyrcp.`spybr_weigthPerPackage`,spybyrcp.`spybr_unitsPerPackage`,spybyrcp.`spybr_unitWeigth`,spybyrcp.`spybr_availableUnitsPerpackage`,spybyrcp.`spybr_codePackage`, entt.`entt_codsec` as spybr_fkEntity,entt.`entt_companyName` as spybr_entityName, spy.`spy_codsec` as spybr_fkSupply,spy.`spy_name` as spybr_supplyName, spy.`spy_code` as spybr_supplyCode, unt.`unit_codsec` as spybr_fkUnit, unt.`unit_name` as spybr_unitName FROM `bps_prod_supply` spy, `bps_prod_supplyreception` spyrcp, `bps_prod_supplybyreception` spybyrcp, `bps_com_entity` entt, `bps_admin_unit` unt WHERE spy.`spy_codsec` = spyrcp.`rcpspy_fkSupply` and entt.`entt_codsec` = spyrcp.`rcpspy_fkEntity` and unt.`unit_codsec` = spy.`spy_fkUnit` and spyrcp.`rcpspy_codsec` = spybyrcp.`spybr_fkReception` and spybyrcp.`spybr_codsec` =  " + codsec.ToString() + " group by spybyrcp.`spybr_codsec`");

                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_codsec"]);
                this.fkReception = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_fkReception"]);
                this.weigthPerPackage = Convert.ToDouble(DS.Tables[0].Rows[0]["spybr_weigthPerPackage"]);
                this.unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_unitsPerPackage"]);
                this.unitWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["spybr_unitWeigth"]);
                this.availableUnitsPerpackage = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_availableUnitsPerpackage"]);
                this.codePackage = DS.Tables[0].Rows[0]["spybr_codePackage"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_fkEntity"]);
                this.entityName = DS.Tables[0].Rows[0]["spybr_entityName"].ToString();
                this.fkSupply = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_fkSupply"]);
                this.supplyName = DS.Tables[0].Rows[0]["spybr_supplyName"].ToString();
                this.supplyCode = DS.Tables[0].Rows[0]["spybr_supplyCode"].ToString();
                this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["spybr_fkUnit"]);
                this.unitName = DS.Tables[0].Rows[0]["spybr_unitName"].ToString();


            }


        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supplybyreception (spybr_fkReception,spybr_weigthPerPackage,spybr_unitsPerPackage,spybr_unitWeigth,spybr_availableUnitsPerpackage,spybr_codePackage)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkReception + ",";
                    queryString += "" + this.weigthPerPackage + ",";
                    queryString += "" + this.unitsPerPackage + ",";
                    queryString += "" + this.unitWeigth + ",";
                    queryString += "" + this.availableUnitsPerpackage + ",";
                    queryString += "'" + this.codePackage + "'";
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_prod_supplybyreception";
                    queryString += " SET ";
                    queryString += "spybr_fkReception = " + this.fkReception + ",";
                    queryString += "spybr_weigthPerPackage = " + this.weigthPerPackage + ",";
                    queryString += "spybr_unitsPerPackage = " + this.unitsPerPackage + ",";
                    queryString += "spybr_unitWeigth = " + this.unitWeigth + ",";
                    queryString += "spybr_availableUnitsPerpackage = " + this.availableUnitsPerpackage + ",";
                    queryString += "spybr_codePackage = '" + this.codePackage + "'";
                    queryString += " WHERE spybr_codsec = " + this.codsec.ToString() + ";";


                }
                clsConnection.executeQuery(queryString);
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplyReceptionDetail.save");
                return false;
            }
        }

        public static List<clsSupplyReceptionDetail> getListBySupply(int supplyCodsec)
        {
            List<clsSupplyReceptionDetail> lstSupplyReceptionDetail = new List<clsSupplyReceptionDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT spybyrcp.`spybr_codsec` as spybr_codsec, spyrcp.`rcpspy_codsec` as spybr_fkReception,spybyrcp.`spybr_weigthPerPackage`,spybyrcp.`spybr_unitsPerPackage`,spybyrcp.`spybr_unitWeigth`,spybyrcp.`spybr_availableUnitsPerpackage`,spybyrcp.`spybr_codePackage`, entt.`entt_codsec` as spybr_fkEntity,entt.`entt_companyName` as spybr_entityName, spy.`spy_codsec` as spybr_fkSupply,spy.`spy_name` as spybr_supplyName, spy.`spy_code` as spybr_supplyCode, unt.`unit_codsec` as spybr_fkUnit, unt.`unit_name` as spybr_unitName FROM `bps_prod_supply` spy, `bps_prod_supplyreception` spyrcp, `bps_prod_supplybyreception` spybyrcp, `bps_com_entity` entt, `bps_admin_unit` unt WHERE entt.`entt_codsec` = spyrcp.`rcpspy_fkEntity` and unt.`unit_codsec` = spy.`spy_fkUnit` and spyrcp.`rcpspy_codsec` = spybyrcp.`spybr_fkReception` and spy.`spy_codsec` = spyrcp.`rcpspy_fkSupply` and  spyrcp.`rcpspy_fkSupply` = " + supplyCodsec.ToString() + " group by spybyrcp.`spybr_codsec`");

            lstSupplyReceptionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyReceptionDetail.Add(new clsSupplyReceptionDetail());
                lstSupplyReceptionDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_codsec"]);
                lstSupplyReceptionDetail[i].fkReception = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_fkReception"]);
                lstSupplyReceptionDetail[i].weigthPerPackage = Convert.ToDouble(DS.Tables[0].Rows[i]["spybr_weigthPerPackage"]);
                lstSupplyReceptionDetail[i].unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_unitsPerPackage"]);
                lstSupplyReceptionDetail[i].unitWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["spybr_unitWeigth"]);
                lstSupplyReceptionDetail[i].availableUnitsPerpackage = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_availableUnitsPerpackage"]);
                lstSupplyReceptionDetail[i].codePackage = DS.Tables[0].Rows[i]["spybr_codePackage"].ToString();
                lstSupplyReceptionDetail[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_fkEntity"]);
                lstSupplyReceptionDetail[i].entityName = DS.Tables[0].Rows[i]["spybr_entityName"].ToString();
                lstSupplyReceptionDetail[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_fkSupply"]);
                lstSupplyReceptionDetail[i].supplyName = DS.Tables[0].Rows[i]["spybr_supplyName"].ToString();
                lstSupplyReceptionDetail[i].supplyCode = DS.Tables[0].Rows[i]["spybr_supplyCode"].ToString();
                lstSupplyReceptionDetail[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["spybr_fkUnit"]);
                lstSupplyReceptionDetail[i].unitName = DS.Tables[0].Rows[i]["spybr_unitName"].ToString();

            }

            return lstSupplyReceptionDetail;
        }

        public int getLastReceptionSaved()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT spyrcp.`rcpspy_codsec` FROM `bps_prod_supplyreception` spyrcp order by  spyrcp.`rcpspy_codsec` desc Limit 1");

            if (DS.Tables[0].Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DS.Tables[0].Rows[0]["rcpspy_codsec"].ToString());


        }
    }
}
