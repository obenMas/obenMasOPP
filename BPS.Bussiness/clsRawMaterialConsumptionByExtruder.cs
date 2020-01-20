using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsRawMaterialConsumptionByExtruder
    {

        //Atributes

        private int rmop_codsec;
        private int rmop_fkRawMaterialType;
        private string rmop_RawMaterialTypeName;
        private int rmop_fkRawMaterial;
        private string rmop_RawMaterialCode;
        private string rmop_RawMaterialName;
        private int rmop_fkCellar;
        private string rmop_cellarName;
        private int rmop_fkMachine;
        private string rmop_extruderName;
        private int rmop_fkProductionOrder;
        private int rmop_fkProductionPlan;
        private int rmop_fkExtruder;
        private int rmop_fkCellarByExtruder;
        private double rmop_transferred;
        private double rmop_transferredTotal;
        private double rmop_consumed;
        private double rmop_available;
        private string rmop_number;
        private DateTime rmop_createdDate;
        private DateTime rmop_modifiedDate;
        private int rmop_createdBy;
        private string rmop_creatorUser;
        private int rmop_modifiedBy;
        private string rmop_modificatorUser;
        private double rmop_amountTransferred;
        private int rmop_fkEntity;
        private string rmop_entityName;

        //Properties

        public int codsec { get { return rmop_codsec; } set { rmop_codsec = value; } }
             
        public string RawMaterialCode { get { return rmop_RawMaterialCode; } set { rmop_RawMaterialCode = value; } }
        
        public int fkRawMaterial { get { return rmop_fkRawMaterial; } set { rmop_fkRawMaterial = value; } }

        public string RawMaterialName { get { return rmop_RawMaterialName; } set { rmop_RawMaterialName = value; } }

        public int fkRawMaterialType { get { return rmop_fkRawMaterialType; } set { rmop_fkRawMaterialType = value; } }

        public string RawMaterialTypeName { get { return rmop_RawMaterialTypeName; } set { rmop_RawMaterialTypeName = value; } }

        public int fkCellar { get { return rmop_fkCellar; } set { rmop_fkCellar = value; } }

        public string cellarName { get { return rmop_cellarName; } set { rmop_cellarName = value; } }

        public int fkEntity { get { return rmop_fkEntity; } set { rmop_fkEntity = value; } }

        public string entityName { get { return rmop_entityName; } set { rmop_entityName = value; } }
               
        public int fkMachine { get { return rmop_fkMachine; } set { rmop_fkMachine = value; } }

        public string extruderName { get { return rmop_extruderName; } set { rmop_extruderName = value; } }

        public int fkProductionOrder { get { return rmop_fkProductionOrder; } set { rmop_fkProductionOrder = value; } }
        
        public int fkProductionPlan { get { return rmop_fkProductionPlan; } set { rmop_fkProductionPlan = value; } }

        public int fkExtruder { get { return rmop_fkExtruder; } set { rmop_fkExtruder = value; } }

        public int fkCellarByExtruder { get { return rmop_fkCellarByExtruder; } set { rmop_fkCellarByExtruder = value; } }

        public double transferred { get { return rmop_transferred; } set { rmop_transferred = value; } }

        public double transferredTotal { get { return rmop_transferredTotal; } set { rmop_transferredTotal = value; } }

        public double amountTransferred { get { return rmop_amountTransferred; } set { rmop_amountTransferred = value; } }

        public double consumed { get { return rmop_consumed; } set { rmop_consumed = value; } }

        public double available { get { return rmop_available; } set { rmop_available = value; } }

        public string number { get { return rmop_number; } set { rmop_number = value; } }

        public DateTime createdDate { get { return rmop_createdDate; } set { rmop_createdDate = value; } }

        public DateTime modifiedDate { get { return rmop_modifiedDate; } set { rmop_modifiedDate = value; } }

        public int createdBy { get { return rmop_createdBy; } set { rmop_createdBy = value; } }

        public string creatorUser { get { return rmop_creatorUser; } set { rmop_creatorUser = value; } }

        public int modifiedBy { get { return rmop_modifiedBy; } set { rmop_modifiedBy = value; } }

        public string modificatorUser { get { return rmop_modificatorUser; } set { rmop_modificatorUser = value; } }         




        //Constructor

        public clsRawMaterialConsumptionByExtruder()
        {

            rmop_codsec = 0;
            rmop_fkRawMaterialType = 0;
            rmop_RawMaterialTypeName = "";
            rmop_fkRawMaterial = 0;
            rmop_RawMaterialCode = "";
            rmop_RawMaterialName = "";
            rmop_fkCellar = 0;
            rmop_cellarName = "";
            rmop_fkMachine = 0;
            rmop_extruderName = "";
            rmop_fkProductionOrder = 0;
            rmop_fkProductionPlan = 0;
            rmop_fkExtruder = 0;
            rmop_fkCellarByExtruder = 0;
            rmop_transferred = 0;
            rmop_transferredTotal = 0;
            rmop_consumed = 0;
            rmop_available = 0;
            rmop_number = "";
            rmop_createdDate = DateTime.Now;
            rmop_modifiedDate = DateTime.Now;
            rmop_createdBy  = 0;
            rmop_creatorUser = "";
            rmop_modifiedBy = 0;
            rmop_modificatorUser = "";
            rmop_fkEntity = 0;
            rmop_entityName = "";
            rmop_amountTransferred = 0;

        }


        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialConsumptionByProductionOrder where rmop_codsec =  " + codsec + " group by rm.`rwm_codsec`, cllext.`cllext_codsec`, cll.`clr_codsec`,  rmc.`consm_codsec`");
            
            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_codsec"]);
                this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkRawMaterialType"]);
                this.RawMaterialTypeName = DS.Tables[0].Rows[0]["rmop_RawMaterialTypeName"].ToString();
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkRawMaterial"]);
                this.RawMaterialCode = DS.Tables[0].Rows[0]["rmop_RawMaterialCode"].ToString();
                this.RawMaterialName = DS.Tables[0].Rows[0]["rmop_RawMaterialName"].ToString();
                this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkCellar"]);
                this.cellarName = DS.Tables[0].Rows[0]["rmop_cellarName"].ToString();
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkMachine"]);
                this.extruderName = DS.Tables[0].Rows[0]["rmop_extruderName"].ToString();
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkProductionOrder"]);
                this.fkProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkFilmProductionPlan"]);
                this.fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkExtruder"]);
                this.fkCellarByExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkCellarByExtruder"]);
                this.consumed = Convert.ToDouble(DS.Tables[0].Rows[0]["rmop_consumed"]);
                this.number = DS.Tables[0].Rows[0]["rmop_number"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialconsumption (consm_fkCellar,consm_fkProductionOrder,consm_fkRawMaterial,consm_fkExtruder,consm_amountTransferred,consm_createdDate,consm_modifiedDate,consm_createdBy,consm_modifiedBy,consm_number)";
                    queryString += " VALUES (";
                    queryString += "'" + this.fkCellar + "',";
                    queryString += "'" + this.fkProductionOrder + "',";
                    queryString += "'" + this.fkRawMaterial + "',";
                    queryString += "'" + this.fkExtruder + "',";
                    queryString += "'" + this.consumed + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.number.ToString() + "'";
                    queryString += ");";
                    
                }
                else
                {

                    queryString += "UPDATE bps_prod_rawmaterialconsumption";
                    queryString += " SET ";
                    queryString += "consm_fkRawMaterial = " + this.fkRawMaterial + ",";
                    queryString += "consm_fkProductionOrder = " + this.fkProductionOrder + ",";
                    queryString += "consm_fkExtruder = " + this.fkExtruder + ",";
                    queryString += "consm_number = '" + this.number.ToString() + "',";
                    queryString += "consm_amountTransferred = " + this.consumed + ",";
                    queryString += "consm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "consm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE consm_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialConsumptionByExtruder.save");
                return false;
            }
        }

        public static List<clsRawMaterialConsumptionByExtruder> getListByExtruder(int extruderCodsec)
        {
            List<clsRawMaterialConsumptionByExtruder> lstRawMaterialConsumptionByOrderProduction = new List<clsRawMaterialConsumptionByExtruder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spRawMaterialConsumptionByProductionOrder(" + extruderCodsec.ToString() + ")");

            lstRawMaterialConsumptionByOrderProduction.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialConsumptionByOrderProduction.Add(new clsRawMaterialConsumptionByExtruder());
                lstRawMaterialConsumptionByOrderProduction[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_fkRawMaterial"]);
                lstRawMaterialConsumptionByOrderProduction[i].RawMaterialCode = DS.Tables[0].Rows[0]["rmop_RawMaterialCode"].ToString();
                lstRawMaterialConsumptionByOrderProduction[i].RawMaterialName = DS.Tables[0].Rows[0]["rmop_RawMaterialName"].ToString();
                lstRawMaterialConsumptionByOrderProduction[i].transferred = Convert.ToDouble(DS.Tables[0].Rows[0]["total1"]);
                lstRawMaterialConsumptionByOrderProduction[i].consumed = Convert.ToDouble(DS.Tables[0].Rows[0]["total2"]);
                lstRawMaterialConsumptionByOrderProduction[i].available = Convert.ToDouble(DS.Tables[0].Rows[0]["STOCK"]);
    
            }

            return lstRawMaterialConsumptionByOrderProduction;
        }



        public static List<clsRawMaterialConsumptionByExtruder> getStockByExtruderAndRawMaterial(int extruderCodsec, int RawMaterialCodsec)
        {
            List<clsRawMaterialConsumptionByExtruder> lstgetStockByExtruderAndRawMaterial = new List<clsRawMaterialConsumptionByExtruder>();
            DataSet DS = new DataSet();

         //   DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialAvailable WHERE transf_fkExtruder =  " + extruderCodsec.ToString() + " and rwm_codsec =  " + RawMaterialCodsec.ToString() + " GROUP BY rwm_codsec");
            //DS = clsConnection.getDataSetResult("SELECT `bps_prod_rawmaterial`.`rwm_codsec`, `bps_prod_rawmaterial`.`rwm_code`, `bps_prod_rawmaterial`.`rwm_name`, sum(`bps_prod_transfer`.`transf_amountTransferred`) as Traspaso,`fnTransferedTotal`(`bps_prod_transfer`.`transf_fkExtruder`,`bps_prod_rawmaterial`.`rwm_codsec`) as total1,COALESCE(`fnConsumedTotal`(`bps_prod_transfer`.`transf_fkExtruder`,`bps_prod_rawmaterial`.`rwm_codsec`),0) as total2,(`fnTransferedTotal`(`bps_prod_transfer`.`transf_fkExtruder`,`bps_prod_rawmaterial`.`rwm_codsec`) - COALESCE(`fnConsumedTotal`(`bps_prod_transfer`.`transf_fkExtruder`,`bps_prod_rawmaterial`.`rwm_codsec`),0)) AS STOCK FROM `bps_prod_transfer` JOIN `bps_prod_rawmaterialbyreception` ON (`bps_prod_rawmaterialbyreception`.`rmbr_codsec` = `bps_prod_transfer`.`transf_fkRawMaterialByReception`) JOIN `bps_prod_rawmaterial` ON (`bps_prod_rawmaterial`.`rwm_codsec` = `bps_prod_rawmaterialbyreception`.`rmbr_fkRawMaterial`) left join `bps_prod_rawmaterialconsumption` on(`bps_prod_rawmaterialconsumption`.`consm_fkRawMaterial` = `bps_prod_rawmaterial`.`rwm_codsec`) WHERE `bps_prod_transfer`.`transf_fkExtruder` =  " + extruderCodsec.ToString() + " and `bps_prod_rawmaterial`.`rwm_codsec` =  " + RawMaterialCodsec.ToString() + " GROUP BY `bps_prod_rawmaterial`.`rwm_codsec`");
            DS = clsConnection.getDataSetResult("spGetStockByExtruderAndRawMaterial  " + extruderCodsec.ToString() + ",  " + RawMaterialCodsec.ToString());
            lstgetStockByExtruderAndRawMaterial.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstgetStockByExtruderAndRawMaterial.Add(new clsRawMaterialConsumptionByExtruder());
                lstgetStockByExtruderAndRawMaterial[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                lstgetStockByExtruderAndRawMaterial[i].RawMaterialCode = DS.Tables[0].Rows[0]["rwm_code"].ToString();
                lstgetStockByExtruderAndRawMaterial[i].RawMaterialName = DS.Tables[0].Rows[0]["rwm_name"].ToString();
                lstgetStockByExtruderAndRawMaterial[i].transferredTotal = Convert.ToDouble(DS.Tables[0].Rows[0]["Traspaso"]);
                lstgetStockByExtruderAndRawMaterial[i].transferred = Convert.ToDouble(DS.Tables[0].Rows[0]["total1"]);
                lstgetStockByExtruderAndRawMaterial[i].consumed = Convert.ToDouble(DS.Tables[0].Rows[0]["total2"]);
                lstgetStockByExtruderAndRawMaterial[i].available = Convert.ToDouble(DS.Tables[0].Rows[0]["STOCK"]);


            }

            return lstgetStockByExtruderAndRawMaterial;
        }

        

         


        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbyfilmproductionplan ORDER BY rmop_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["rmop_codsec"]);

        }

        public string getLastBatch()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT consm_number FROM bps_prod_rawmaterialconsumption order by consm_codsec desc Limit 1");


            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["consm_number"].ToString();
        }

    }
}


