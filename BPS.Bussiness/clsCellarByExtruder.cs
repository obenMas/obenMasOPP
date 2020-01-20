using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las bodegas por extrusora
    /// </summary>
    public class clsCellarByExtruder
    {

        //Atributes

        private int cllbyext_codsec;
        private int cllbyext_fkCellar;
        private string cllbyext_cellarName;
        private int cllbyext_fkExtruder;
        private string cllbyext_extruderName;
        private Boolean cllext_isProductionCellar;
        private Boolean cllext_isConsumption;


        //Properties

        public int codsec { get { return cllbyext_codsec; } set { cllbyext_codsec = value; } }

        public int fkCellar { get { return cllbyext_fkCellar; } set { cllbyext_fkCellar = value; } }

        public string cellarName { get { return cllbyext_cellarName; } set { cllbyext_cellarName = value; } }

        public int fkExtruder { get { return cllbyext_fkExtruder; } set { cllbyext_fkExtruder = value; } }

        public string extruderName { get { return cllbyext_extruderName; } set { cllbyext_extruderName = value; } }

        public Boolean isProductionCellar { get { return cllext_isProductionCellar; } set { cllext_isProductionCellar = value; } }

        public Boolean isConsumption { get { return cllext_isConsumption; } set { cllext_isConsumption = value; } }


        //Constructor

        public clsCellarByExtruder()
        {
            cllbyext_codsec = 0;
            cllbyext_fkCellar = 0;
            cllbyext_cellarName = "";
            cllbyext_fkExtruder = 0;
            cllbyext_extruderName = "";
            cllext_isProductionCellar = false;
            cllext_isConsumption = false;
        }

        public clsCellarByExtruder(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cllext.`cllext_codsec` as cllbyext_codsec, cll.`clr_codsec` as cllbyext_fkCellar, cll.`clr_name` as cllbyext_cellarName, ext.`ext_codsec` as cllbyext_fkExtruder, ext.`ext_name` as cllbyext_extruderName, cllext.`cllext_isProductionCellar` as cllext_isProductionCellar,cllext.`cllext_isConsumption` as cllext_isConsumption FROM `bps_admin_cellar` cll, `bps_admin_cellarbyextruder` cllext, `bps_prod_extruder` ext WHERE ext.`ext_codsec` = cllext.`cllext_fkExtruder` and cll.`clr_codsec` = cllext.`cllext_fkCellar` and cllext.`cllext_fkCellar` = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cllbyext_codsec"]);
            this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cllbyext_fkCellar"]);
            this.cellarName = DS.Tables[0].Rows[0]["cllbyext_cellarName"].ToString();
            this.fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["cllbyext_fkExtruder"]);
            this.extruderName = DS.Tables[0].Rows[0]["cllbyext_extruderName"].ToString();
            this.isProductionCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cllext_isProductionCellar"], DS.Tables[0].Rows[0]["cllext_isProductionCellar"].GetType().FullName);
            this.isConsumption = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cllext_isConsumption"], DS.Tables[0].Rows[0]["cllext_isConsumption"].GetType().FullName);
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_cellarbyextruder (cllext_fkCellar, cllext_fkExtruder,cllext_isProductionCellar,cllext_isConsumption)";
                    queryString += " VALUES (";
                    queryString += this.fkCellar + ",";
                    queryString += this.fkExtruder + "',";
                    queryString += "" + this.isProductionCellar + ",";
                    queryString += "" + this.isConsumption + "";
                    queryString += ");";
                    
                }
                else
                {
                    queryString += "UPDATE bps_admin_cellarbyextruder";
                    queryString += " SET ";
                    queryString += "cllext_fkCellar = " + this.fkCellar + ",";
                    queryString += "cllext_fkExtruder = " + this.fkExtruder + "";
                    queryString += "cllext_isProductionCellar = " + this.isProductionCellar.ToString() + "";
                    queryString += "cllext_isConsumption = " + this.isProductionCellar.ToString() + "";
                    queryString += " WHERE cllext_codsec = " + this.codsec + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCellarByExtruder.save");
                return false;
            }
        }

        public static List<clsCellarByExtruder> getList()
        {
            List<clsCellarByExtruder> lstCellarByExtruder = new List<clsCellarByExtruder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cllext.`cllext_codsec` as cllbyext_codsec, cll.`clr_codsec` as cllbyext_fkCellar, cll.`clr_name` as cllbyext_cellarName, ext.`ext_codsec` as cllbyext_fkExtruder, ext.`ext_name` as cllbyext_extruderName, cllext.`cllext_isProductionCellar` as cllext_isProductionCellar,cllext.`cllext_isConsumption` as cllext_isConsumption FROM `bps_admin_cellar` cll, `bps_admin_cellarbyextruder` cllext, `bps_prod_extruder` ext WHERE ext.`ext_codsec` = cllext.`cllext_fkExtruder` and cll.`clr_codsec` = cllext.`cllext_fkCellar`");

            lstCellarByExtruder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCellarByExtruder.Add(new clsCellarByExtruder());
                lstCellarByExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_codsec"]);
                lstCellarByExtruder[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkCellar"]);
                lstCellarByExtruder[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkExtruder"]);
                lstCellarByExtruder[i].cellarName = DS.Tables[0].Rows[i]["cllbyext_cellarName"].ToString();
                lstCellarByExtruder[i].extruderName = DS.Tables[0].Rows[i]["cllbyext_extruderName"].ToString();
                lstCellarByExtruder[i].isProductionCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isProductionCellar"], DS.Tables[0].Rows[i]["cllext_isProductionCellar"].GetType().FullName);
                lstCellarByExtruder[i].isConsumption = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isConsumption"], DS.Tables[0].Rows[i]["cllext_isConsumption"].GetType().FullName);

            }

            return lstCellarByExtruder;
        }


        public static List<clsCellarByExtruder> getListProductionCellarByExtruder(int extruderCodsec)
        {
            List<clsCellarByExtruder> lstProductionCelarByExtruder = new List<clsCellarByExtruder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cllext.`cllext_codsec` as cllbyext_codsec, cll.`clr_codsec` as cllbyext_fkCellar, cll.`clr_name` as cllbyext_cellarName, ext.`ext_codsec` as cllbyext_fkExtruder, ext.`ext_name` as cllbyext_extruderName, cllext.`cllext_isProductionCellar` as cllext_isProductionCellar,cllext.`cllext_isConsumption` as cllext_isConsumption FROM `bps_admin_cellar` cll, `bps_admin_cellarbyextruder` cllext, `bps_prod_extruder` ext WHERE ext.`ext_codsec` = cllext.`cllext_fkExtruder` and cll.`clr_codsec` = cllext.`cllext_fkCellar` and `cllext`.`cllext_isProductionCellar` = 1 and ext.`ext_codsec` = " + extruderCodsec.ToString());

            lstProductionCelarByExtruder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProductionCelarByExtruder.Add(new clsCellarByExtruder());
                lstProductionCelarByExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_codsec"]);
                lstProductionCelarByExtruder[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkCellar"]);
                lstProductionCelarByExtruder[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkExtruder"]);
                lstProductionCelarByExtruder[i].cellarName = DS.Tables[0].Rows[i]["cllbyext_cellarName"].ToString();
                lstProductionCelarByExtruder[i].extruderName = DS.Tables[0].Rows[i]["cllbyext_extruderName"].ToString();
                lstProductionCelarByExtruder[i].isProductionCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isProductionCellar"], DS.Tables[0].Rows[i]["cllext_isProductionCellar"].GetType().FullName);
                lstProductionCelarByExtruder[i].isConsumption = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isConsumption"], DS.Tables[0].Rows[i]["cllext_isConsumption"].GetType().FullName);

            }

            return lstProductionCelarByExtruder;
        }

        public static List<clsCellarByExtruder> getListConsumptionByExtruder(int extruderCodsec)
        {
            List<clsCellarByExtruder> lstConsumptionByExtruder = new List<clsCellarByExtruder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cllext.`cllext_codsec` as cllbyext_codsec, cll.`clr_codsec` as cllbyext_fkCellar, cll.`clr_name` as cllbyext_cellarName, ext.`ext_codsec` as cllbyext_fkExtruder, ext.`ext_name` as cllbyext_extruderName, cllext.`cllext_isProductionCellar` as cllext_isProductionCellar,cllext.`cllext_isConsumption` as cllext_isConsumption FROM `bps_admin_cellar` cll, `bps_admin_cellarbyextruder` cllext, `bps_prod_extruder` ext WHERE ext.`ext_codsec` = cllext.`cllext_fkExtruder` and cll.`clr_codsec` = cllext.`cllext_fkCellar` and `cllext`.`cllext_isConsumption` = 1 and ext.`ext_codsec` = " + extruderCodsec.ToString());

            lstConsumptionByExtruder.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstConsumptionByExtruder.Add(new clsCellarByExtruder());
                lstConsumptionByExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_codsec"]);
                lstConsumptionByExtruder[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkCellar"]);
                lstConsumptionByExtruder[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["cllbyext_fkExtruder"]);
                lstConsumptionByExtruder[i].cellarName = DS.Tables[0].Rows[i]["cllbyext_cellarName"].ToString();
                lstConsumptionByExtruder[i].extruderName = DS.Tables[0].Rows[i]["cllbyext_extruderName"].ToString();
                lstConsumptionByExtruder[i].isProductionCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isProductionCellar"], DS.Tables[0].Rows[i]["cllext_isProductionCellar"].GetType().FullName);
                lstConsumptionByExtruder[i].isConsumption = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cllext_isConsumption"], DS.Tables[0].Rows[i]["cllext_isConsumption"].GetType().FullName);

            }

            return lstConsumptionByExtruder;
        }

        public override string ToString()
        {
            return this.cellarName;
        }
    }

}
