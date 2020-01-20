using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRawMaterialExtruder
    {
        public string code { get; set; }

        public double netWeigth { get; set; }

        public int bag { get; set; }

        public string lotNumber { get; set; }

        public string MaterialCode { get; set; }

        public string MaterialName { get; set; }

        public int fkMaterial { get; set; }

        public int codsec { get; set; }

        public string message { get; set; }

        public int fkRaw { get; set; }

        public bool isParent { get; set; }

        public bool isSon { get; set; }

        public bool isProcess { get; set; }

        public string Cellar { get; set; }

        public string info { get; set; }

        public DateTime date { get; set; }

        public string provider { get; set; }


        public clsRawMaterialExtruder()
        {
            code = "";
            netWeigth = 0;
            bag = 0;
            lotNumber = "";
            MaterialCode = "";
            MaterialName = "";
            fkMaterial = 0;
            codsec = 0;
            message = "";
            fkRaw = 0;
            isParent = true;
            isSon = false;
            isProcess = false;
            Cellar = "";
            info = "";
            date = DateTime.Now;
            provider = "";
        }

        public static clsRawMaterialExtruder getRawByCodeExtruder(string code)
        {
            clsRawMaterialExtruder rawOBJ = new clsRawMaterialExtruder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJFormulationEXT',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_codsec"]);
                rawOBJ.fkMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_fkMaterial"]);
                rawOBJ.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_fkRaw"]);
                rawOBJ.MaterialName = DS.Tables[0].Rows[i]["rw_MaterialType"].ToString();
                rawOBJ.MaterialCode = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rw_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_bag"]);
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rw_netweigth"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rw_code"].ToString();
                rawOBJ.isParent = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isParent"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.isSon = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isSon"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.isProcess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isProcess"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();

                rawOBJ.message = "";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public static clsRawMaterialExtruder getRawByCodeExtruderTraza(string code)
        {
            clsRawMaterialExtruder rawOBJ = new clsRawMaterialExtruder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJFormulationEXTTRAZA',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rw_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_bag"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rw_code"].ToString();
                rawOBJ.date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rw_dateIngress"]);
                rawOBJ.datePro = Convert.ToDateTime(DS.Tables[0].Rows[i]["rw_dateProces"]);
                rawOBJ.message = DS.Tables[0].Rows[i]["frml_name"].ToString();
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rw_netweigth"]);
                rawOBJ.MaterialCode = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.MaterialName = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                rawOBJ.codsec = 1;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public static bool setTransferMR(string codsecRW)
        {
            string queryString = "";
            queryString += "UPDATE bps_prod_rawmaterialextruder SET rw_isProcess = 1 WHERE rw_codsec = " + codsecRW + ";";
            return clsConnection.executeQuery(queryString);
        }

        public static bool setReProcess(double resultW, string codsec, bool isParent)
        {
            string queryString = "";

            if (isParent)
                queryString += "UPDATE bps_prod_rawmaterialextruder SET rw_netweigth = " + resultW.ToString() + ", rw_isParent = 1, rw_isSon = 0, rw_isProcess = 1 WHERE rw_codsec = " + codsec + ";";
            else
                queryString += "UPDATE bps_prod_rawmaterialextruder SET rw_netweigth = " + resultW.ToString() + ", rw_isParent = 0, rw_isSon = 1, rw_isProcess = 1 WHERE rw_codsec = " + codsec + ";";

            return clsConnection.executeQuery(queryString);
        }

        public int toSave()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialextruder (rw_fkRaw, rw_fkMaterial, rw_lotnumber, rw_bag, rw_code, ";
                    queryString += "rw_netweigth, rw_date, rw_isParent, rw_isSon, rw_isProcess)";
                    queryString += " VALUES (";
                    queryString += this.fkRaw.ToString() + ", ";
                    queryString += this.fkMaterial.ToString() + ", ";
                    queryString += "'" + this.lotNumber + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netWeigth.ToString() + ", ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + this.isParent.ToString() + ", ";
                    queryString += "" + this.isSon.ToString() + ", ";
                    queryString += "" + this.isProcess.ToString() + " ";
                    queryString += ");";
                }

                clsConnection.executeQuery(queryString);

                return clsRawMaterialExtruder.getLastCodsec();
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return 0;
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialextruder (rw_fkRaw, rw_fkMaterial, rw_lotnumber, rw_bag, rw_code, ";
                    queryString += "rw_netweigth, rw_date, rw_isParent, rw_isSon, rw_isProcess)";
                    queryString += " VALUES (";
                    queryString += this.fkRaw.ToString() + ", ";
                    queryString += this.fkMaterial.ToString() + ", ";
                    queryString += "'" + this.lotNumber + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netWeigth.ToString() + ", ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + this.isParent.ToString() + ", ";
                    queryString += "" + this.isSon.ToString() + ", ";
                    queryString += "" + this.isProcess.ToString() + " ";
                    queryString += ");";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return false;
            }
        }

        private static int getLastCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(rw_codsec) as codsec FROM bps_prod_rawmaterialextruder");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        public static bool setDeleteTransferMR(string codsec)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialextruder SET ";
            queryString += "rw_isProcess = 0";
            queryString += " WHERE rw_codsec = " + codsec + ";";

            return clsConnection.executeQuery(queryString);
        }

        public static List<clsRawMaterialExtruder> getListBackLoadExtruder()
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialExtruder> rawMList = new List<clsRawMaterialExtruder>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawBListExtruderEXT',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawMList.Add(new clsRawMaterialExtruder());
                    int pos = rawMList.Count - 1;
                    rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                    rawMList[pos].fkRaw = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_fkRaw"]);
                    rawMList[pos].MaterialCode = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                    rawMList[pos].MaterialName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                    rawMList[pos].lotNumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                    rawMList[pos].Cellar = DS.Tables[0].Rows[i]["rwmc_cellar"].ToString();
                    rawMList[pos].info = DS.Tables[0].Rows[i]["rwmc_palletbag"].ToString();
                    rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                    rawMList[pos].code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                    rawMList[pos].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                    rawMList[pos].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                    rawMList[pos].fkMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkrawmaterial"]);
                }
            }

            return rawMList;
        }

        public static clsRawMaterialExtruder getRawByCodeExtruderAdt(string code)
        {
            clsRawMaterialExtruder rawOBJ = new clsRawMaterialExtruder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJFormulationEXTADT',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_codsec"]);
                rawOBJ.fkMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_fkMaterial"]);
                rawOBJ.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_fkRaw"]);
                rawOBJ.MaterialName = DS.Tables[0].Rows[i]["rw_MaterialType"].ToString();
                rawOBJ.MaterialCode = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rw_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rw_bag"]);
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rw_netweigth"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rw_code"].ToString();
                rawOBJ.isParent = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isParent"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.isSon = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isSon"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.isProcess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isProcess"], DS.Tables[0].Rows[i]["rw_isParent"].GetType().FullName);
                rawOBJ.message = "";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public static bool setAditive(string codsec)
        {
            string queryString = "";
            queryString += "UPDATE bps_prod_rawmaterialextruder SET rw_isParent = 1, rw_isProcess = 1 WHERE rw_codsec = " + codsec + ";";
            return clsConnection.executeQuery(queryString);
        }

        public static void setTransferD(string codsec)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialextruder SET ";
            queryString += "rw_isProcess = 1,";
            queryString += "rw_isReturn = 1";
            queryString += " WHERE rw_codsec = " + codsec + ";";

            clsConnection.executeQuery(queryString);
        }

        public DateTime datePro { get; set; }
    }
}
