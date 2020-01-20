using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra Materias Primas y Suministros
    /// </summary>
    public class clsRawMaterial
    {
        //Atributes


        private int rwm_codsec;
        private int rwn_fkRawMaterialtype;
        private string rwn_RawMaterialtypeName;
        private int rwn_fkEntity;
        private string rwn_EntityName;
        private int rwn_fkUnit;
        private string rwn_UnitName;
        private int rwn_fkPackagingType;
        private string rwn_PackagingTypeName;
        private string rwm_name;
        private string rwm_code;
        private string rwm_note;
        private DateTime rwm_createdDate;
        private DateTime rwm_modifiedDate;
        private int rwm_createdBy;
        private string rwm_creatorUser;
        private int rwm_modifiedBy;
        private string rwm_modificatorUser;
        private double rwm_stock;



        //Properties

        public int codsec { get { return rwm_codsec; } set { rwm_codsec = value; } }

        public int fkRawMaterialtype { get { return rwn_fkRawMaterialtype; } set { rwn_fkRawMaterialtype = value; } }

        public string RawMaterialtypeName { get { return rwn_RawMaterialtypeName; } set { rwn_RawMaterialtypeName = value; } }

        public int fkEntity { get { return rwn_fkEntity; } set { rwn_fkEntity = value; } }

        public string EntityName { get { return rwn_EntityName; } set { rwn_EntityName = value; } }

        public int fkUnit { get { return rwn_fkUnit; } set { rwn_fkUnit = value; } }

        public string UnitName { get { return rwn_UnitName; } set { rwn_UnitName = value; } }

        public int fkPackagingType { get { return rwn_fkPackagingType; } set { rwn_fkPackagingType = value; } }

        public string PackagingTypeName { get { return rwn_PackagingTypeName; } set { rwn_PackagingTypeName = value; } }

        public string name { get { return rwm_name; } set { rwm_name = value; } }

        public string code { get { return rwm_code; } set { rwm_code = value; } }

        public string note { get { return rwm_note; } set { rwm_note = value; } }

        public DateTime createdDate { get { return rwm_createdDate; } set { rwm_createdDate = value; } }

        public DateTime modifiedDate { get { return rwm_modifiedDate; } set { rwm_modifiedDate = value; } }

        public int createdBy { get { return rwm_createdBy; } set { rwm_createdBy = value; } }

        public string creatorUser { get { return rwm_creatorUser; } set { rwm_creatorUser = value; } }

        public int modifiedBy { get { return rwm_modifiedBy; } set { rwm_modifiedBy = value; } }

        public string modificatorUser { get { return rwm_modificatorUser; } set { rwm_modificatorUser = value; } }

        public double stock { get { return rwm_stock; } set { rwm_stock = value; } }

        public string RawMaterialCode { get; set; }

        public string lotNumber { get; set; }

        public int bag { get; set; }

        public double netWeigth { get; set; }

        public double grossWeigth { get; set; }

        //Constructor

        public clsRawMaterial()
        {
            rwm_codsec = 0;
            rwn_fkRawMaterialtype = 0;
            rwn_RawMaterialtypeName = "";
            rwn_fkEntity = 0;
            rwn_fkUnit = 0;
            rwn_UnitName = "";
            rwn_EntityName = "";
            rwn_fkPackagingType = 0;
            rwn_PackagingTypeName = "";
            rwm_name = "";
            rwm_code = "";
            rwm_note = "";
            rwm_createdDate = DateTime.Now;
            rwm_modifiedDate = DateTime.Now;
            rwm_createdBy = 0;
            rwm_creatorUser = "";
            rwm_modifiedBy = 0;
            rwm_modificatorUser = "";
            rwm_stock = 0;
        }

        public clsRawMaterial(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterial where rwm_codsec =  " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                this.fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[0]["rwn_fkRawMaterialtype"]);
                this.RawMaterialtypeName = DS.Tables[0].Rows[0]["rwn_RawMaterialtypeName"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["rwm_EntityName"].ToString();
                this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_fkUnit"]);
                this.UnitName = DS.Tables[0].Rows[0]["rwm_UnitName"].ToString();
                this.fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[0]["rwn_fkPackagingType"]);
                this.PackagingTypeName = DS.Tables[0].Rows[0]["rwn_PackagingTypeName"].ToString();
                this.name = DS.Tables[0].Rows[0]["rwm_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["rwm_code"].ToString();
                this.note = DS.Tables[0].Rows[0]["rwm_note"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwm_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwm_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["rwm_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["rwm_modificatorUser"].ToString();
            }
        }

        public void loadF(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterial WHERE rwm_codsec =  " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                this.name = DS.Tables[0].Rows[0]["rwm_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["rwm_code"].ToString();
            }
        }

        public void loadByCode(string codigo)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterial where rwm_code =  '" + codigo+"'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                this.fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[0]["rwn_fkRawMaterialtype"]);
                this.RawMaterialtypeName = DS.Tables[0].Rows[0]["rwn_RawMaterialtypeName"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["rwm_EntityName"].ToString();
                this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_fkUnit"]);
                this.UnitName = DS.Tables[0].Rows[0]["rwm_UnitName"].ToString();
                this.fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[0]["rwn_fkPackagingType"]);
                this.PackagingTypeName = DS.Tables[0].Rows[0]["rwn_PackagingTypeName"].ToString();
                this.name = DS.Tables[0].Rows[0]["rwm_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["rwm_code"].ToString();
                this.note = DS.Tables[0].Rows[0]["rwm_note"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwm_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwm_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_createdBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["rwm_creatorUser"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_modifiedBy"]);
                this.modificatorUser = DS.Tables[0].Rows[0]["rwm_modificatorUser"].ToString();
            }
        }
      

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterial (rwn_fkRawMaterialtype,rwn_fkPackagingType,rwm_fkUnit,rwm_fkEntity,rwm_name,rwm_code,rwm_note,rwm_createdDate,rwm_modifiedDate,rwm_createdBy,rwm_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += this.fkRawMaterialtype.ToString() + ",";
                    queryString += this.fkPackagingType.ToString() + ",";
                    queryString += this.fkUnit.ToString() + ",";
                    queryString += this.fkEntity.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "'" + this.note + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterial";
                    queryString += " SET ";
                    queryString += "rwn_fkRawMaterialtype = " + this.fkRawMaterialtype + ",";
                    queryString += "rwn_fkPackagingType = " + this.fkPackagingType + ",";
                    queryString += "rwm_fkUnit = " + this.fkUnit + ",";
                    queryString += "rwm_fkEntity = " + this.fkEntity + ",";
                    queryString += "rwm_name = '" + this.name.ToString() + "',";
                    queryString += "rwm_code = '" + this.code.ToString() + "',";
                    queryString += "rwm_note = '" + this.note.ToString() + "',";
                    queryString += "rwm_modifiedDate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "rwm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE rwm_codsec = " + this.codsec.ToString() + ";";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterial.save");
                return false;
            }
        }

        public static List<clsRawMaterial> getList()
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterial order by rwm_name asc");

            lstRawMaterial.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterial.Add(new clsRawMaterial());
                lstRawMaterial[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                lstRawMaterial[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkRawMaterialtype"]);
                lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwn_RawMaterialtypeName"].ToString();
                lstRawMaterial[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkEntity"]);
                lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_EntityName"].ToString();
                lstRawMaterial[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkUnit"]);
                lstRawMaterial[i].UnitName = DS.Tables[0].Rows[i]["rwm_UnitName"].ToString();
                lstRawMaterial[i].fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkPackagingType"]);
                lstRawMaterial[i].PackagingTypeName = DS.Tables[0].Rows[i]["rwn_PackagingTypeName"].ToString();
                lstRawMaterial[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterial[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                lstRawMaterial[i].note = DS.Tables[0].Rows[i]["rwm_note"].ToString();
                lstRawMaterial[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_createdDate"]);
                lstRawMaterial[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_modifiedDate"]);
                lstRawMaterial[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_createdBy"]);
                lstRawMaterial[i].creatorUser = DS.Tables[0].Rows[i]["rwm_creatorUser"].ToString();
                lstRawMaterial[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_modifiedBy"]);
                lstRawMaterial[i].modificatorUser = DS.Tables[0].Rows[i]["rwm_modificatorUser"].ToString();

            }

            return lstRawMaterial;
        }

        public static List<clsRawMaterial> getListShort()
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawList',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstRawMaterial.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterial.Add(new clsRawMaterial());
                lstRawMaterial[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                lstRawMaterial[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkRawMaterialtype"]);
                lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwn_RawMaterialtypeName"].ToString();
                lstRawMaterial[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkEntity"]);
                lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_EntityName"].ToString();
                lstRawMaterial[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkUnit"]);
                lstRawMaterial[i].UnitName = DS.Tables[0].Rows[i]["rwm_UnitName"].ToString();
                lstRawMaterial[i].fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkPackagingType"]);
                lstRawMaterial[i].PackagingTypeName = DS.Tables[0].Rows[i]["rwn_PackagingTypeName"].ToString();
                lstRawMaterial[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterial[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                lstRawMaterial[i].note = DS.Tables[0].Rows[i]["rwm_note"].ToString();
                lstRawMaterial[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_createdDate"]);
                lstRawMaterial[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_modifiedDate"]);
                lstRawMaterial[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_createdBy"]);
                lstRawMaterial[i].creatorUser = DS.Tables[0].Rows[i]["rwm_creatorUser"].ToString();
                lstRawMaterial[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_modifiedBy"]);
                lstRawMaterial[i].modificatorUser = DS.Tables[0].Rows[i]["rwm_modificatorUser"].ToString();

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstRawMaterial;
        }

        public static List<clsRawMaterial> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE" + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterial " + where + " order by rwm_name asc");

            lstRawMaterial.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRawMaterial.Add(new clsRawMaterial());
                    lstRawMaterial[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                    lstRawMaterial[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkRawMaterialtype"]);
                    lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwn_RawMaterialtypeName"].ToString();
                    lstRawMaterial[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkEntity"]);
                    lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_EntityName"].ToString();
                    lstRawMaterial[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkUnit"]);
                    lstRawMaterial[i].UnitName = DS.Tables[0].Rows[i]["rwm_UnitName"].ToString();
                    lstRawMaterial[i].fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkPackagingType"]);
                    lstRawMaterial[i].PackagingTypeName = DS.Tables[0].Rows[i]["rwn_PackagingTypeName"].ToString();
                    lstRawMaterial[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                    lstRawMaterial[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                    lstRawMaterial[i].note = DS.Tables[0].Rows[i]["rwm_note"].ToString();
                    lstRawMaterial[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_createdDate"]);
                    lstRawMaterial[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_modifiedDate"]);
                    lstRawMaterial[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_createdBy"]);
                    lstRawMaterial[i].creatorUser = DS.Tables[0].Rows[i]["rwm_creatorUser"].ToString();
                    lstRawMaterial[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_modifiedBy"]);
                    lstRawMaterial[i].modificatorUser = DS.Tables[0].Rows[i]["rwm_modificatorUser"].ToString();
                }
            }

            return lstRawMaterial;
        }

        public static List<clsRawMaterial> getListByRawMaterialType(int rwCodsec)
        {
            List<clsRawMaterial> lstRawMaterialByRawMaterialType = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rwm.rwm_codsec as rwm_codsec,rwm.rwn_fkRawMaterialtype as rwm_fkRawMaterialType,rwm.rwm_name as rwm_name,rwm.rwm_code as rwm_code FROM bps_prod_rawmaterial rwm where rwm.rwn_fkRawMaterialtype = " + rwCodsec + " order by rwm_code asc");

            lstRawMaterialByRawMaterialType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByRawMaterialType.Add(new clsRawMaterial());
                lstRawMaterialByRawMaterialType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                lstRawMaterialByRawMaterialType[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkRawMaterialType"]);
                lstRawMaterialByRawMaterialType[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterialByRawMaterialType[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();


            }

            return lstRawMaterialByRawMaterialType;
        }

        public static List<clsRawMaterial> getStockRawMaterial()
        {
            List<clsRawMaterial> lstStockByType = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * from vwStockRawMaterial order by RawMaterialTypeName");

            lstStockByType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStockByType.Add(new clsRawMaterial());
                lstStockByType[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rmbr_fkRawMaterial"]);
                lstStockByType[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["RawMaterialTypeName"].ToString();
                lstStockByType[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["stock"]);
            }
            return lstStockByType;
        }

        public static List<clsRawMaterial> getStockRawMaterialDetail(int fkRawMaterialType)
        {
            List<clsRawMaterial> lstStockDetail = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rmrc.rmbr_fkRawMaterial as fkRawMaterial, rm.`rwm_name` as RawMaterialName,  rm.`rwm_code` as RawMaterialCode,sum(rmrc.rmbr_unitWeight * rmrc.rmbr_availableUnitsPerpackage) as stock FROM bps_prod_rawmaterialbyreception rmrc, bps_prod_rawmaterial rm where rm.`rwm_codsec` = rmrc.`rmbr_fkRawMaterial` and rm.`rwn_fkRawMaterialtype` = " + fkRawMaterialType + " AND rmrc.rmbr_availableUnitsPerpackage != 0");// group by rm.`rwm_codsec`");

            lstStockDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStockDetail.Add(new clsRawMaterial());
                lstStockDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fkRawMaterial"]);
                lstStockDetail[i].name = DS.Tables[0].Rows[i]["RawMaterialName"].ToString();
                lstStockDetail[i].code = DS.Tables[0].Rows[i]["RawMaterialCode"].ToString();
                lstStockDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["stock"]);
            }
            return lstStockDetail;
        }

        public static List<clsRawMaterial> getStockRawMaterialProductionDetail(int fkRawMaterialType, int machinecodsec)
        {
            List<clsRawMaterial> lstStockProductionDetail = new List<clsRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rmrc.rmbr_fkRawMaterial as fkRawMaterial, rm.`rwm_name` as RawMaterialName, sum(tf.`transf_amountTransferred`) as stock FROM `bps_prod_rawmaterial` rm, `bps_prod_transfer` tf, `bps_prod_rawmaterialbyreception` rmrc, `bps_prod_cellarbymachine` cllmch, `bps_admin_cellar` cll, `bps_prod_rawmaterialtype` rmt WHERE rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and rm.`rwm_codsec` = rmrc.`rmbr_fkRawMaterial` and rmrc.`rmbr_codsec` = tf.`transf_fkRawMaterialByReception` and cll.`clr_codsec` = tf.`transf_fkCellar` and cll.`clr_codsec` = cllmch.`cllmch_fkCellar` and cll.`clr_productioncellar` = 1 and cllmch.`cllmch_fkMachine` = '" + machinecodsec + "' and rmt.`trwm_codsec` = '" + fkRawMaterialType + "' group by rm.`rwm_codsec`");

            lstStockProductionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStockProductionDetail.Add(new clsRawMaterial());
                lstStockProductionDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fkRawMaterial"]);
                lstStockProductionDetail[i].name = DS.Tables[0].Rows[i]["RawMaterialName"].ToString();
                lstStockProductionDetail[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["stock"]);
            }
            return lstStockProductionDetail;
        }

        public override string ToString()
        {
            return this.code;
        }

        public static clsRawMaterial getRawByCode(string code, string mov)
        {
            clsRawMaterial rawOBJ = new clsRawMaterial();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJ',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                rawOBJ.RawMaterialtypeName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                rawOBJ.RawMaterialCode = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_bag"]);
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                rawOBJ.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_grossweigth"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();

                /*if (mov.Trim().ToUpper() == "H016" || mov.Trim().ToUpper() == "H004" || mov.Trim().ToUpper() == "H018" || mov.Trim().ToUpper() == "H005")
                {
                    if (DS.Tables[0].Rows[i]["rwmc_cellarsiigo"].ToString() == "001")
                        rawOBJ.message = "";
                    else
                        rawOBJ.message = code + " en bodega Depósito Industrial - movimiento consumo";
                }
                else if (mov.Trim().ToUpper() == "H001" || mov.Trim().ToUpper() == "H003" || mov.Trim().ToUpper() == "H007")
                {
                    if (DS.Tables[0].Rows[i]["rwmc_cellarsiigo"].ToString() == "004")
                        rawOBJ.message = "";
                    else
                        rawOBJ.message = code + " en bodega Consumo - movimiento depósito industrial";
                }
                else*/
                    rawOBJ.message = "";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public string message { get; set; }

        public static clsRawMaterial getRawByCodeReturn(string code)
        {
            clsRawMaterial rawOBJ = new clsRawMaterial();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJReturn',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                rawOBJ.RawMaterialtypeName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                rawOBJ.RawMaterialCode = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_bag"]);
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                rawOBJ.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_grossweigth"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                rawOBJ.message = "";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public static clsRawMaterial getRawByCodeExtruder(string code)
        {
            clsRawMaterial rawOBJ = new clsRawMaterial();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawOBJFormulation',0,'" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawOBJ.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                rawOBJ.fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkRawM"]);
                rawOBJ.RawMaterialtypeName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                rawOBJ.RawMaterialCode = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                rawOBJ.lotNumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                rawOBJ.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_bag"]);
                rawOBJ.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                rawOBJ.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_grossweigth"]);
                rawOBJ.code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                rawOBJ.message = "";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawOBJ;
        }

        public static bool isUniqueCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rwm_codsec FROM bps_prod_rawmaterial WHERE rwm_code = '" + code.Trim().ToUpper() + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static List<clsRawMaterial> getListRaw()
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            DataSet DS = new DataSet();
            //28-09 Nahuel: Cambio el formato de fecha a dd/MM/yyyy y el procedimiento spFormulationMultiple no contiene la operacion
            //'ListRaw', dejo comentada la linea original y cambio el procedimiento por una vista
            //DS = clsConnection.getDataSetResult("spFormulationMultiple 'ListRaw','',0,'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            DS = clsConnection.getDataSetResult("SELECT * from vwrawmaterial");
            lstRawMaterial.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterial.Add(new clsRawMaterial());
                lstRawMaterial[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                //lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_companyName"].ToString();
                lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_EntityName"].ToString();
                //lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwm_rawTypeName"].ToString();
                lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwn_RawMaterialtypeName"].ToString();
                lstRawMaterial[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterial[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
            }

            return lstRawMaterial;
        }

        public static List<clsRawMaterial> getListByFilterRaw(List<clsFilter> lstFilter)
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            DataSet DS = new DataSet();
            string where = "", top = "";

            if (lstFilter.Count > 0)
            {
                if (clsFilter.getSql(lstFilter) != "")
                    where = " WHERE" + clsFilter.getSql(lstFilter);

                top = "TOP(10)";
            }
            else
                top = "TOP(100)";

            DS = clsConnection.getDataSetResult("SELECT " + top + " * FROM vwRawMaterialdata " + where);

            lstRawMaterial.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstRawMaterial.Add(new clsRawMaterial());
                    lstRawMaterial[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                    lstRawMaterial[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwm_rawTypeName"].ToString();
                    lstRawMaterial[i].EntityName = DS.Tables[0].Rows[i]["rwm_companyName"].ToString();
                    lstRawMaterial[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                    lstRawMaterial[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                }
            }

            return lstRawMaterial;
        }

        public int getCodsecByName(string name)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterial WHERE rwm_name = '" + name.ToString() + "'");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                }
                else
                {
                    return 0;
                }

            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterial.save");
                return 0;
            }
        }

        public static int getCodsecByCode(string code)
        {
            try
            {
                DataSet DS = new DataSet();

                DS= clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterial WHERE rwm_code = " + "'" + code.ToString() + "'");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["rwm_codsec"]);
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterial.save");
                return 0;
            }
        }

        public static clsRawMaterial getObjByCode(string code)
        {
            clsRawMaterial objRaw = new clsRawMaterial();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterial WHERE rwm_code = '" + code.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables.Count; i++)
                {
                    objRaw.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                    objRaw.fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkRawMaterialtype"]);
                    objRaw.fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[i]["rwn_fkPackagingType"]);
                    objRaw.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkUnit"]);
                    objRaw.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkEntity"]);
                    objRaw.name = Convert.ToString(DS.Tables[0].Rows[i]["rwm_name"]);
                    objRaw.code = Convert.ToString(DS.Tables[0].Rows[i]["rwm_code"]);
                    objRaw.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_createdDate"]);
                    objRaw.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwm_modifiedDate"]);
                    objRaw.createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_modifiedBy"]);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DS.Dispose();

                return objRaw;
            }
            else
            {
                objRaw.codsec = 0; // ñeri mode ON.
                return objRaw;
            }
        }
    }
}
