using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsReceptionRawMaterialDetail
    {

      
            //Atributes

            private int rcpmpdt_codsec;
            private int rcpmpdt_fkPurchaseOrder;
            private int rcpmpdt_fkPurchaseOrderDetail;
            private int rcpmpdt_fkRawMaterialType;
            private string rcpmpdt_RawMaterialTypeName;
            private int rcpmpdt_fkRawMaterial;
            private string rcpmpdt_RawMaterialName;
            private string rcpmpdt_RawMaterialCode;
            private double rcpmpdt_TotalQuantity;
            private double rcpmpdt_DeliveredAmount;
            private double rcpmpdt_AmountLeft;
            private int rcpmpdt_fkReception;
            private string rcpmpdt_ReceptionBatch;
            private string rcpmpdt_PurchaseOrder;
            private double rcpmpdt_weigthPerPackage;
            private int rcpmpdt_unitsPerPackage;
            private double rcpmpdt_unitWeight;
            private int rcpmpdt_avaliableUnitsPerpackage;
            private string rcpmpdt_codePackage;
            private int rcpmpdt_fkentity;
            private string rcpmpdt_entityName;
            private double rcpmpdt_cost;
            private int rcpmpdt_avaliableUnits;
            private double rcpmpdt_avaliableWeigth;
            private int rcpmpdt_fkCellar;
            private string rcpmpdt_cellarName;
            private double rcpmpdt_quote;
            


            //Properties


            public int codsec { get { return rcpmpdt_codsec; } set { rcpmpdt_codsec = value; } }

            public int fkPurchaseOrder { get { return rcpmpdt_fkPurchaseOrder; } set { rcpmpdt_fkPurchaseOrder = value; } }

            public int fkPurchaseOrderDetail { get { return rcpmpdt_fkPurchaseOrderDetail; } set { rcpmpdt_fkPurchaseOrderDetail = value; } }

            public int fkRawMaterialType { get { return rcpmpdt_fkRawMaterialType; } set { rcpmpdt_fkRawMaterialType = value; } }

            public string RawMaterialTypeName { get { return rcpmpdt_RawMaterialTypeName; } set { rcpmpdt_RawMaterialTypeName = value; } }

            public int fkRawMaterial { get { return rcpmpdt_fkRawMaterial; } set { rcpmpdt_fkRawMaterial = value; } }

            public string RawMaterialName { get { return rcpmpdt_RawMaterialName; } set { rcpmpdt_RawMaterialName = value; } }

            public string RawMaterialCode { get { return rcpmpdt_RawMaterialCode; } set { rcpmpdt_RawMaterialCode = value; } }

            public double TotalQuantity { get { return rcpmpdt_TotalQuantity; } set { rcpmpdt_TotalQuantity = value; } }

            public double DeliveredAmount { get { return rcpmpdt_DeliveredAmount; } set { rcpmpdt_DeliveredAmount = value; } }

            public double AmountLeft { get { return rcpmpdt_AmountLeft; } set { rcpmpdt_AmountLeft = value; } }

            public int fkReception { get { return rcpmpdt_fkReception; } set { rcpmpdt_fkReception = value; } }

            public string ReceptionBatch { get { return rcpmpdt_ReceptionBatch; } set { rcpmpdt_ReceptionBatch = value; } }

            public string PurchaseOrder { get { return rcpmpdt_PurchaseOrder; } set { rcpmpdt_PurchaseOrder = value; } }

            public double weigthPerPackage { get { return rcpmpdt_weigthPerPackage; } set { rcpmpdt_weigthPerPackage = value; } }

            public int unitsPerPackage { get { return rcpmpdt_unitsPerPackage; } set { rcpmpdt_unitsPerPackage = value; } }

            public double unitWeight { get { return rcpmpdt_unitWeight; } set { rcpmpdt_unitWeight = value; } }

            public int avaliableUnitsPerpackage { get { return rcpmpdt_avaliableUnitsPerpackage; } set { rcpmpdt_avaliableUnitsPerpackage = value; } }

            public string codePackage { get { return rcpmpdt_codePackage; } set { rcpmpdt_codePackage = value; } }

            public int fkentity { get { return rcpmpdt_fkentity; } set { rcpmpdt_fkentity = value; } }

            public string entityName { get { return rcpmpdt_entityName; } set { rcpmpdt_entityName = value; } }

            public double cost { get { return rcpmpdt_cost; } set { rcpmpdt_cost = value; } }

            public int avaliableUnits { get { return rcpmpdt_avaliableUnits; } set { rcpmpdt_avaliableUnits = value; } }

            public double avaliableWeigth { get { return rcpmpdt_avaliableWeigth; } set { rcpmpdt_avaliableWeigth = value; } } 

            public int fkCellar { get { return rcpmpdt_fkCellar; } set { rcpmpdt_fkCellar = value; } }

            public string cellarName { get { return rcpmpdt_cellarName; } set { rcpmpdt_cellarName = value; } }

            public double quote { get { return rcpmpdt_quote; } set { rcpmpdt_quote = value; } } 



            //Constructor

            public clsReceptionRawMaterialDetail()
            {
                rcpmpdt_codsec = 0;
                rcpmpdt_fkPurchaseOrder = 0;
                rcpmpdt_fkPurchaseOrderDetail = 0;
                rcpmpdt_fkRawMaterialType = 0;
                rcpmpdt_RawMaterialTypeName = "";
                rcpmpdt_fkRawMaterial = 0;
                rcpmpdt_RawMaterialName = "";
                rcpmpdt_RawMaterialCode = "";
                rcpmpdt_TotalQuantity = 0;
                rcpmpdt_DeliveredAmount = 0;
                rcpmpdt_AmountLeft = 0;
                rcpmpdt_fkReception = 0;
                rcpmpdt_ReceptionBatch = "";
                rcpmpdt_PurchaseOrder = "";
                rcpmpdt_weigthPerPackage = 0;
                rcpmpdt_unitsPerPackage = 0;
                rcpmpdt_unitWeight = 0;
                rcpmpdt_avaliableUnitsPerpackage = 0;
                rcpmpdt_codePackage = "";
                rcpmpdt_fkentity = 0;
                rcpmpdt_entityName = "";
                rcpmpdt_cost = 0;
                rcpmpdt_avaliableUnits = 0;
                rcpmpdt_avaliableWeigth = 0;
                rcpmpdt_fkCellar = 0;
                rcpmpdt_cellarName = "";
                rcpmpdt_quote = 0;

            }


            public clsReceptionRawMaterialDetail(int codsec)
            {
                this.load(codsec);
            }

            //Methods

            public void load(int codsec)
            {
                DataSet DS = new DataSet();

                //DS = clsConnection.getDataSetResult("select rmrcp.`rmbr_codsec` as rcpmpdt_codsec,rmrcp.`rmbr_fkReception` as rcpmpdt_fkReception, rmrcp.`rmbr_weightPerPackage` as rcpmpdt_weigthPerPackage,rmrcp.`rmbr_unitsPerPackage` as rcpmpdt_unitsPerPackage,rmrcp.`rmbr_unitWeight` as rcpmpdt_unitWeight,rmrcp.`rmbr_availableUnitsPerPackage` as rcpmpdt_avaliableUnitsPerPackage, rmrcp.`rmbr_codePackage` as rcpmpdt_codePackage,pod.`purorddt_fkPurchaseOrder` as rcpmpdt_fkPurchaseOrder, rmt.`trwm_codsec` as rcpmpdt_fkRawMaterialType,rmt.`trwm_name` as rcpmpdt_RawMaterialTypeName,rm.`rwm_codsec` as rcpmpdt_fkRawMaterial,rm.`rwm_name` as rcpmpdt_RawMaterialName,rm.`rwm_code` as rcpmpdt_RawMaterialCode,pod.`purorddt_quantity` as rcpmpdt_TotalQuantity, sum(rmrcp.`rmbr_unitsPerPackage` * rmrcp.`rmbr_unitWeight`) as rcpmpdt_DeliveredAmount,(pod.`purorddt_quantity` - sum(rmrcp.`rmbr_unitsPerPackage` * rmrcp.`rmbr_unitWeight`)) as rcpmpdt_AmountLeft, rmrcp.`rmbr_availableUnitsPerpackage` as rcpmpdt_avaliableUnits from `bps_prod_reception` rcp, `bps_prod_rawmaterialbyreception` rmrcp, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt where rcp.`rcp_codsec` = rmrcp.`rmbr_fkReception` and rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and rmrcp.`rmbr_codsec` = " + codsec.ToString() + "");
                DS = clsConnection.getDataSetResult("select rmrcp.`rmbr_codsec` as rcpmpdt_codsec,rmrcp.`rmbr_fkReception` as rcpmpdt_fkReception, rmrcp.`rmbr_weightPerPackage` as rcpmpdt_weigthPerPackage,rmrcp.`rmbr_unitsPerPackage` as rcpmpdt_unitsPerPackage,rmrcp.`rmbr_unitWeight` as rcpmpdt_unitWeight,rmrcp.`rmbr_availableUnitsPerPackage` as rcpmpdt_avaliableUnitsPerPackage, rmrcp.`rmbr_codePackage` as rcpmpdt_codePackage,pod.`purorddt_fkPurchaseOrder` as rcpmpdt_fkPurchaseOrder, rmt.`trwm_codsec` as rcpmpdt_fkRawMaterialType,rmt.`trwm_name` as rcpmpdt_RawMaterialTypeName,rm.`rwm_codsec` as rcpmpdt_fkRawMaterial,rm.`rwm_name` as rcpmpdt_RawMaterialName,rm.`rwm_code` as rcpmpdt_RawMaterialCode,pod.`purorddt_quantity` as rcpmpdt_TotalQuantity,  rmrcp.`rmbr_availableUnitsPerpackage` as rcpmpdt_avaliableUnits from `bps_prod_reception` rcp, `bps_prod_rawmaterialbyreception` rmrcp, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt where rcp.`rcp_codsec` = rmrcp.`rmbr_fkReception` and rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and rmrcp.`rmbr_codsec` = " + codsec.ToString() + "");

                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_codsec"]);
                this.fkReception = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkReception"]);
                this.weigthPerPackage = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpmpdt_weigthPerPackage"]);
                this.unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_unitsPerPackage"]);
                this.unitWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpmpdt_unitWeight"]);
                this.avaliableUnitsPerpackage = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_avaliableUnitsPerPackage"]);
                this.codePackage = DS.Tables[0].Rows[0]["rcpmpdt_codePackage"].ToString();
                this.fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkPurchaseOrder"]);
             //   this.fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkPurchaseOrderDetail"]);
                this.fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkRawMaterialType"]);
                this.RawMaterialTypeName = DS.Tables[0].Rows[0]["rcpmpdt_RawMaterialTypeName"].ToString();
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkRawMaterial"]);
                this.RawMaterialName = DS.Tables[0].Rows[0]["rcpmpdt_RawMaterialName"].ToString();
                this.RawMaterialCode = DS.Tables[0].Rows[0]["rcpmpdt_RawMaterialCode"].ToString();
                this.TotalQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpmpdt_TotalQuantity"]);
                //this.DeliveredAmount = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpmpdt_DeliveredAmount"]);
                //this.AmountLeft = Convert.ToDouble(DS.Tables[0].Rows[0]["rcpmpdt_AmountLeft"]);
                this.avaliableUnits = Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_avaliableUnits"]);
                
            }




        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbyreception (rmbr_fkReception, rmbr_fkRawMaterial, rmbr_weightPerPackage, rmbr_unitsPerPackage, rmbr_unitWeight,rmbr_availableUnitsPerpackage,rmbr_codePackage)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkReception + ",";
                    queryString += "" + this.fkRawMaterial + ",";
                    queryString += "" + this.weigthPerPackage + ",";
                    queryString += "" + this.unitsPerPackage + ",";
                    queryString += "" + this.unitWeight + ",";
                    queryString += "" + this.avaliableUnitsPerpackage + ",";
                    queryString += "'" + this.codePackage + "'";
                    queryString += ");";
                    
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterialbyreception";
                    queryString += " SET ";
                    queryString += "rmbr_fkReception = " + this.fkReception + ",";
                    queryString += "rmbr_fkRawMaterial = " + this.fkRawMaterial + ",";
                    queryString += "rmbr_weightPerPackage = " + this.weigthPerPackage + ",";
                    queryString += "rmbr_unitsPerPackage = " + this.unitsPerPackage + ",";
                    queryString += "rmbr_unitWeight = " + this.unitWeight + ",";
                    queryString += "rmbr_availableUnitsPerpackage = " + this.avaliableUnitsPerpackage + ",";
                    queryString += "rmbr_codePackage = '" + this.codePackage + "'";
                    queryString += " WHERE rmbr_codsec = " + this.codsec.ToString() + ";";


                }
                clsConnection.executeQuery(queryString);
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReceptionRawMaterialDetail.save");
                return false;
            }
        }



        

        public static List<clsReceptionRawMaterialDetail> getList(int codsec)
        {
            List<clsReceptionRawMaterialDetail> lstReceptionRawMaterialDetail = new List<clsReceptionRawMaterialDetail>();
            List<clsReceptionRawMaterialDetail> lstReceptionRMDetail = new List<clsReceptionRawMaterialDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select pod.`purorddt_fkPurchaseOrder` as rcpmpdt_fkPurchaseOrder,pod.purorddt_codsec as rcpmpdt_fkPurchaseOrderDetail, rmt.`trwm_codsec` as rcpmpdt_fkRawMaterialType,rmt.`trwm_name` as rcpmpdt_RawMaterialTypeName,rm.`rwm_codsec` as rcpmpdt_fkRawMaterial,rm.`rwm_name` as rcpmpdt_RawMaterialName,rm.`rwm_code` as rcpmpdt_RawMaterialCode,pod.`purorddt_quantity` as rcpmpdt_TotalQuantity, sum(rmrcp.`rmbr_unitsPerPackage` * rmrcp.`rmbr_unitWeight`) as rcpmpdt_DeliveredAmount,(pod.`purorddt_quantity` - sum(rmrcp.`rmbr_unitsPerPackage` * rmrcp.`rmbr_unitWeight`)) as rcpmpdt_AmountLeft from `bps_prod_reception` rcp, `bps_prod_rawmaterialbyreception` rmrcp, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt where rcp.`rcp_codsec` = rmrcp.`rmbr_fkReception` and pod.`purorddt_codsec` = rcp.`rcp_fkPurchaseOrderDetail` and rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and pod.`purorddt_fkPurchaseOrder` = " + codsec.ToString() + " group by rcpmpdt_fkPurchaseOrderDetail");

            lstReceptionRawMaterialDetail.Clear();
       
            if (Convert.ToInt32(DS.Tables.Count) > 0)
            {
                
                lstReceptionRMDetail = clsReceptionRawMaterialDetail.getInitialList(codsec);
            }
            else
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstReceptionRawMaterialDetail.Add(new clsReceptionRawMaterialDetail());
                    lstReceptionRawMaterialDetail[i].fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrder"]);
                    lstReceptionRawMaterialDetail[i].fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrderDetail"]);
                    lstReceptionRawMaterialDetail[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterialType"]);
                    lstReceptionRawMaterialDetail[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialTypeName"].ToString();
                    lstReceptionRawMaterialDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterial"]);
                    lstReceptionRawMaterialDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialName"].ToString();
                    lstReceptionRawMaterialDetail[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialCode"].ToString();
                    lstReceptionRawMaterialDetail[i].TotalQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]);
                    lstReceptionRawMaterialDetail[i].DeliveredAmount = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_DeliveredAmount"]);
                    lstReceptionRawMaterialDetail[i].AmountLeft = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_AmountLeft"]);

                }
            }

            return lstReceptionRMDetail;
        }

        public static List<clsReceptionRawMaterialDetail> getInitialList(int codsec)
        {
            List<clsReceptionRawMaterialDetail> lstReceptionRMDetail = new List<clsReceptionRawMaterialDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select po.purord_codsec as rcpmpdt_fkPurchaseOrder, pod.purorddt_codsec as rcpmpdt_fkPurchaseOrderDetail,rmt.trwm_codsec as rcpmpdt_fkRawMaterialType,rmt.trwm_name as rcpmpdt_RawMaterialTypeName,rm.rwm_codsec as rcpmpdt_fkRawMaterial, rm.rwm_name as rcpmpdt_RawMaterialName, rm.rwm_name as rcpmpdt_RawMaterialCode,pod.`purorddt_quantity` as rcpmpdt_TotalQuantity from `bps_admin_purchaseorder` po, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt where rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and po.`purord_codsec` = pod.`purorddt_fkPurchaseOrder` and po.purord_codsec = " + codsec.ToString() + " group by pod.purorddt_codsec");

            lstReceptionRMDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReceptionRMDetail.Add(new clsReceptionRawMaterialDetail());
                lstReceptionRMDetail[i].fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrder"]);
                lstReceptionRMDetail[i].fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrderDetail"]);
                lstReceptionRMDetail[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterialType"]);
                lstReceptionRMDetail[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialTypeName"].ToString();
                lstReceptionRMDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterial"]);
                lstReceptionRMDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialName"].ToString();
                lstReceptionRMDetail[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialCode"].ToString();
                lstReceptionRMDetail[i].TotalQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]);
                lstReceptionRMDetail[i].DeliveredAmount = 0;
                lstReceptionRMDetail[i].AmountLeft = (Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]) - Convert.ToInt32(lstReceptionRMDetail[i].DeliveredAmount));

            }
            return lstReceptionRMDetail;

        }

        public static List<clsReceptionRawMaterialDetail> getReceptionDetail(int codsec)
        {
            List<clsReceptionRawMaterialDetail> lstReceptionDetail = new List<clsReceptionRawMaterialDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select rcp.`rcp_quantity` as rcpmpdt_DeliveredAmount,po.purord_codsec as rcpmpdt_fkPurchaseOrder,po.purord_number as rcpmpdt_PurchaseOrder, pod.purorddt_codsec as rcpmpdt_fkPurchaseOrderDetail,rmt.trwm_codsec as rcpmpdt_fkRawMaterialType,rmt.trwm_name as rcpmpdt_RawMaterialTypeName,rm.rwm_codsec as rcpmpdt_fkRawMaterial, rm.rwm_name as rcpmpdt_RawMaterialName, rm.rwm_name as rcpmpdt_RawMaterialCode,pod.`purorddt_quantity` as rcpmpdt_TotalQuantity, rcp.`rcp_codsec` as rcpmpdt_fkReception,rcp.`rcp_batch` as rcpmpdt_ReceptionBatch from `bps_admin_purchaseorder` po, `bps_admin_purchaseorderdetail` pod, `bps_prod_rawmaterial` rm, `bps_prod_rawmaterialtype` rmt, `bps_prod_reception` rcp where rmt.`trwm_codsec` = rm.`rwn_fkRawMaterialtype` and rm.`rwm_codsec` = pod.`purorddt_fkRawMaterial` and po.`purord_codsec` = pod.`purorddt_fkPurchaseOrder` and pod.`purorddt_codsec` = rcp.`rcp_fkPurchaseOrderDetail` and rcp.`rcp_codsec` = " + codsec.ToString() );//+ " group by pod.purorddt_codsec ");

            lstReceptionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReceptionDetail.Add(new clsReceptionRawMaterialDetail());
                lstReceptionDetail[i].fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrder"]);
                lstReceptionDetail[i].fkPurchaseOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrderDetail"]);
                lstReceptionDetail[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterialType"]);
                lstReceptionDetail[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialTypeName"].ToString();
                lstReceptionDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterial"]);
                lstReceptionDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialName"].ToString();
                lstReceptionDetail[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialCode"].ToString();
                lstReceptionDetail[i].TotalQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]);
                lstReceptionDetail[i].DeliveredAmount = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_DeliveredAmount"]);
                lstReceptionDetail[i].AmountLeft = (Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]) - Convert.ToInt32(lstReceptionDetail[i].DeliveredAmount));
                lstReceptionDetail[i].fkReception = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkReception"]);
                lstReceptionDetail[i].ReceptionBatch = DS.Tables[0].Rows[i]["rcpmpdt_ReceptionBatch"].ToString();
                lstReceptionDetail[i].PurchaseOrder = DS.Tables[0].Rows[i]["rcpmpdt_PurchaseOrder"].ToString();

            }
            return lstReceptionDetail;

        }
        public static List<clsReceptionRawMaterialDetail> getRawMaterialByReceptionList(int ReceptionCodsec)
        {
            List<clsReceptionRawMaterialDetail> lstReceptionDetail = new List<clsReceptionRawMaterialDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spRawMaterialByReceptionList " + ReceptionCodsec.ToString());

            lstReceptionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReceptionDetail.Add(new clsReceptionRawMaterialDetail());
                lstReceptionDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_codsec"]);
                lstReceptionDetail[i].fkReception = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkReception"]);
                lstReceptionDetail[i].weigthPerPackage = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_weigthPerPackage"]);
                lstReceptionDetail[i].unitsPerPackage = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_unitsPerPackage"]);
                lstReceptionDetail[i].unitWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_unitWeight"]);
                lstReceptionDetail[i].avaliableUnitsPerpackage = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_avaliableUnitsPerPackage"]);
                lstReceptionDetail[i].codePackage = DS.Tables[0].Rows[i]["rcpmpdt_codePackage"].ToString();
                lstReceptionDetail[i].fkPurchaseOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkPurchaseOrder"]);
                lstReceptionDetail[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterialType"]);
                lstReceptionDetail[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialTypeName"].ToString();
                lstReceptionDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterial"]);
                lstReceptionDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialName"].ToString();
                lstReceptionDetail[i].RawMaterialCode = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialCode"].ToString();
                lstReceptionDetail[i].TotalQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_TotalQuantity"]);
                lstReceptionDetail[i].avaliableUnits = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_avaliableUnits"]);
            }
            return lstReceptionDetail;

        }
       
        public static List<clsReceptionRawMaterialDetail> getReceptionDetailByPackageCode(string code)
        {
            List<clsReceptionRawMaterialDetail> lstReceptionDetail = new List<clsReceptionRawMaterialDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialReceptionDetail WHERE rcpmpdt_codePackage = '" + code + "' ");

            lstReceptionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstReceptionDetail.Add(new clsReceptionRawMaterialDetail());
                lstReceptionDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_codsec"]);
                lstReceptionDetail[i].fkentity = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkentity"]);
                lstReceptionDetail[i].entityName = DS.Tables[0].Rows[i]["rcpmpdt_entityName"].ToString();
                lstReceptionDetail[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterialType"]);
                lstReceptionDetail[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialTypeName"].ToString();
                lstReceptionDetail[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_fkRawMaterial"]);
                lstReceptionDetail[i].RawMaterialName = DS.Tables[0].Rows[i]["rcpmpdt_RawMaterialName"].ToString();
                lstReceptionDetail[i].avaliableUnits = Convert.ToInt32(DS.Tables[0].Rows[i]["rcpmpdt_avaliableUnits"]);
                lstReceptionDetail[i].avaliableWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_avaliableWeigth"]);
                lstReceptionDetail[i].codePackage = DS.Tables[0].Rows[i]["rcpmpdt_codePackage"].ToString();
                lstReceptionDetail[i].cost = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_cost"]);
                lstReceptionDetail[i].unitWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_unitWeight"]);
                lstReceptionDetail[i].quote = Convert.ToDouble(DS.Tables[0].Rows[i]["rcpmpdt_quote"]);

            }
            return lstReceptionDetail;

        }





        public int getLastReceptionSaved()
        { 
          DataSet DS = new DataSet();
          DS = clsConnection.getDataSetResult("select rcp.`rcp_codsec` as rcpmpdt_fkReception from `bps_prod_reception` rcp order by rcp.`rcp_codsec` desc Limit 1");
          
          if (DS.Tables[0].Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DS.Tables[0].Rows[0]["rcpmpdt_fkReception"].ToString());
        
        
        }

    }
}
