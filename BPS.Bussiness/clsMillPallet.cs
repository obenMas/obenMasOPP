using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las bobinas Madres
    /// </summary>
    public class clsMillPallet
    {
        //Atributes

        private int mill_codsec;
        private int mill_fkStatus;
        private string mill_StatusName;
        private int mill_fkMill;
        private string mill_MillName;
        private string mill_Product;
        private string mill_mcode;
        private string mill_lotNumber;
        private int mill_bag;
        private int mill_order;
        private double mill_palletWeigth;
        private double mill_grossWeigth;
        private double mill_netWeigth;
        private double mill_density;
        private string mill_notes;
        private DateTime mill_createdDate;
        private DateTime mill_modifiedDate;
        private int mill_createdBy;
        private string mill_creatorUser;
        private int mill_modifiedBy;
        private string mill_modificatorUser;
        private string mill_customer;
        private string mill_operatorM;
        private int mill_ProductCodsec;
        private string mill_ProductName;
        private string mill_ProductCode;
        private int mill_fkProduct;
        private int mill_fkEntity;
        private string mill_entityName;


        private int mill_fkProductTo;
        private int mill_fkFilmProductionPlan;
        private int mill_width;
        private double mill_diameter;
        private int mill_cuttingPosition;
        private int mill_cuttingStop;
        private bool mill_isMaquile;
        private string mill_AnalistRating;
        private string mill_labRating;
        private int mill_fkorigin;
        private string mill_ProductToCode;
        private double mill_originweigth;
        private double mill_decrease;
        private int mill_supervisor;
        private string mill_operatorName;
        private int mill_coiler;
        private string mill_CastCode;
        private string mill_CoatingCode;
        private string mill_FilmProductionPlanLotNumber;
        private int mill_fkMachine;
        private string mill_MachineName;
        private int mill_fkProductionOrder;
        private int mill_ProductionOrderNumber;
        private int mill_variation;
        private double mill_grosslength;
        private double mill_usedLength;
        private double mill_gramaje;
        private double mill_velocity;
        private double mill_productionKgHr;
        private DateTime mill_initDate;
        private DateTime mill_endDate;
        private string mtod_processValues;
        private List<string> mtod_processList;


        //Properties

        public int codsec { get { return mill_codsec; } set { mill_codsec = value; } }

        public int fkStatus { get { return mill_fkStatus; } set { mill_fkStatus = value; } }

        public string StatusName { get { return mill_StatusName; } set { mill_StatusName = value; } }

        public int fkMill { get { return mill_fkMill; } set { mill_fkMill = value; } }

        public string MillName { get { return mill_MillName; } set { mill_MillName = value; } }

        public string Product { get { return mill_Product; } set { mill_Product = value; } }

        public string code { get { return mill_mcode; } set { mill_mcode = value; } }

        public string lotNumber { get { return mill_lotNumber; } set { mill_lotNumber = value; } }

        public int bag { get { return mill_bag; } set { mill_bag = value; } }

        public int order { get { return mill_order; } set { mill_order = value; } }

        public double palletWeigth { get { return mill_palletWeigth; } set { mill_palletWeigth = value; } }

        public double grossWeigth { get { return mill_grossWeigth; } set { mill_grossWeigth = value; } }

        public double netWeigth { get { return mill_netWeigth; } set { mill_netWeigth = value; } }

        public double density { get { return mill_density; } set { mill_density = value; } }

        public string notes { get { return mill_notes; } set { mill_notes = value; } }

        public DateTime createdDate { get { return mill_createdDate; } set { mill_createdDate = value; } }

        public DateTime modifiedDate { get { return mill_modifiedDate; } set { mill_modifiedDate = value; } }

        public int createdBy { get { return mill_createdBy; } set { mill_createdBy = value; } }

        public string creatorUser { get { return mill_creatorUser; } set { mill_creatorUser = value; } }

        public int modifiedBy { get { return mill_modifiedBy; } set { mill_modifiedBy = value; } }

        public string modificatorUser { get { return mill_modificatorUser; } set { mill_modificatorUser = value; } }

        public string enityName { get { return mill_entityName; } set { mill_entityName = value; } }



        public string OperatorM { get { return mill_operatorM; } set { mill_operatorM = value; } }

        public int fkProduct { get { return mill_fkProduct; } set { mill_fkProduct = value; } }

        public int fkEntity { get { return mill_fkEntity; } set { mill_fkEntity = value; } }

        public int fkProductTo { get { return mill_fkProductTo; } set { mill_fkProductTo = value; } }

        public int fkFilmProductionPlan { get { return mill_fkFilmProductionPlan; } set { mill_fkFilmProductionPlan = value; } }

        public int width { get { return mill_width; } set { mill_width = value; } }

        public double diameter { get { return mill_diameter; } set { mill_diameter = value; } }

        public int cuttingPosition { get { return mill_cuttingPosition; } set { mill_cuttingPosition = value; } }

        public int cuttingStop { get { return mill_cuttingStop; } set { mill_cuttingStop = value; } }

        public bool isMaquile { get { return mill_isMaquile; } set { mill_isMaquile = value; } }

        public string analistRating { get { return mill_AnalistRating; } set { mill_AnalistRating = value; } }

        public string labRating { get { return mill_labRating; } set { mill_labRating = value; } }

        public int fkorigin { get { return mill_fkorigin; } set { mill_fkorigin = value; } }

        public string customer { get { return mill_customer; } set { mill_customer = value; } }

        public string ProductToCode { get { return mill_ProductToCode; } set { mill_ProductToCode = value; } }

        public string processValues { get { return mtod_processValues; } set { mtod_processValues = value; } }

        public List<string> processList { get { return mtod_processList; } set { mtod_processList = value; } }

        public string CastCode { get { return mill_CastCode; } set { mill_CastCode = value; } }

        public int ProductCodsec { get { return mill_ProductCodsec; } set { mill_ProductCodsec = value; } }

        public string CoatingCode { get { return mill_CoatingCode; } set { mill_CoatingCode = value; } }

        public string FilmProductionPlanLotNumber { get { return mill_FilmProductionPlanLotNumber; } set { mill_FilmProductionPlanLotNumber = value; } }

        public double OriginWeigth { get { return mill_originweigth; } set { mill_originweigth = value; } }

        public int fkMachine { get { return mill_fkMachine; } set { mill_fkMachine = value; } }

        public string MachineName { get { return mill_MachineName; } set { mill_MachineName = value; } }

        public double decrease { get { return mill_decrease; } set { mill_decrease = value; } }

        public int fkProductionOrder { get { return mill_fkProductionOrder; } set { mill_fkProductionOrder = value; } }

        public int ProductionOrderNumber { get { return mill_ProductionOrderNumber; } set { mill_ProductionOrderNumber = value; } }

        public int variation { get { return mill_variation; } set { mill_variation = value; } }

        public double grosslength { get { return mill_grosslength; } set { mill_grosslength = value; } }

        public double usedLength { get { return mill_usedLength; } set { mill_usedLength = value; } }

        public double gramaje { get { return mill_gramaje; } set { mill_gramaje = value; } }

        public double velocity { get { return mill_velocity; } set { mill_velocity = value; } }

        public double productionKgHr { get { return mill_productionKgHr; } set { mill_productionKgHr = value; } }

        public DateTime initDate { get { return mill_initDate; } set { mill_initDate = value; } }

        public DateTime endDate { get { return mill_endDate; } set { mill_endDate = value; } }

        public int supervisor { get { return mill_supervisor; } set { mill_supervisor = value; } }

        public string operatorName { get { return mill_operatorName; } set { mill_operatorName = value; } }

        public int coiler { get { return mill_coiler; } set { mill_coiler = value; } }

        public string ProductName { get { return mill_ProductName; } set { mill_ProductName = value; } }

        public string ProductCode { get { return mill_ProductCode; } set { mill_ProductCode = value; } }

        //Constructor

        public clsMillPallet()
        {
            mill_decrease = 0;
            mill_originweigth = 0;
            mtod_processValues = "0;0;0;0;0;0;0;0;0;0;0;0;0";
            mtod_processList = new List<string>();
            mill_ProductCode = "";
            mill_ProductName = "";
            mill_customer = "";
            mill_fkorigin = 0;
            mill_codsec = 0;
            mill_operatorM = "";
            mill_fkProduct = 0;
            mill_fkEntity = 0;
            mill_fkProductTo = 0;
            mill_CastCode = "";
            mill_ProductCodsec = 0;
            mill_CoatingCode = "";
            mill_fkStatus = 0;
            mill_StatusName = "";
            mill_fkFilmProductionPlan = 0;
            mill_FilmProductionPlanLotNumber = "";
            mill_originweigth = 0;
            mill_fkMachine = 0;
            mill_MachineName = "";
            mill_decrease = 0;
            mill_fkProductionOrder = 0;
            mill_ProductionOrderNumber = 0;
            mill_mcode = "";
            mill_variation = 0;
            mill_lotNumber = "";
            mill_grosslength = 0;
            mill_palletWeigth = 0;
            mill_usedLength = 0;
            mill_grossWeigth = 0;
            mill_netWeigth = 0;
            mill_width = 0;
            mill_gramaje = 0;
            mill_velocity = 0;
            mill_productionKgHr = 0;
            mill_notes = "";
            mill_initDate = DateTime.Now;
            mill_endDate = DateTime.Now;
            mill_createdDate = DateTime.Now;
            mill_modifiedDate = DateTime.Now;
            mill_createdBy = 0;
            mill_creatorUser = "";
            mill_modifiedBy = 0;
            mill_modificatorUser = "";
            mill_AnalistRating = "";
            mill_labRating = "";
            mill_supervisor = 0;
            mill_ProductToCode = "";
            mill_operatorName = "";
            mill_coiler = 0;
            mill_entityName = "";

        }

        public clsMillPallet(int mainCoilCodsec)
        {
            this.load(mainCoilCodsec);
        }

        public clsMillPallet(string millCode)
        {
            this.load(millCode);
        }

        private void load(string millCode)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletListByCode','" + millCode + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mill_sttName"].ToString();
                this.fkMill = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkMill"]);
                this.MillName = DS.Tables[0].Rows[0]["mill_millName"].ToString();
                this.ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_productcodsec"]);
                this.ProductName = DS.Tables[0].Rows[0]["mill_productname"].ToString();
                this.ProductCode = DS.Tables[0].Rows[0]["mill_productcode"].ToString();
                this.Product = DS.Tables[0].Rows[0]["mill_Product"].ToString();
                this.code = DS.Tables[0].Rows[0]["mill_code"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["mill_lotNumber"].ToString();
                this.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_bag"].ToString());
                this.order = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_order"].ToString());
                this.palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_palletWeight"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_grossWeight"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_netWeight"]);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_density"]);
                this.notes = DS.Tables[0].Rows[0]["mill_notes"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_modifiedBy"]);
                this.customer = DS.Tables[0].Rows[0]["mill_customer"].ToString();
                this.OperatorM = DS.Tables[0].Rows[0]["mill_operator"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkEntity"]);
                this.enityName = DS.Tables[0].Rows[0]["mill_customerName"].ToString();
            }
        }


        //Methods

        public void load(int mainCoilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletByCodsec','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + mainCoilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["mill_sttName"].ToString();
                this.fkMill = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkMill"]);
                this.MillName = DS.Tables[0].Rows[0]["mill_millName"].ToString();
                this.Product = DS.Tables[0].Rows[0]["mill_Product"].ToString();
                this.code = DS.Tables[0].Rows[0]["mill_code"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["mill_lotNumber"].ToString();
                this.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_bag"].ToString());
                this.order = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_order"].ToString());
                this.palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_palletWeight"]);
                this.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_grossWeight"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_netWeight"]);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_density"]);
                this.notes = DS.Tables[0].Rows[0]["mill_notes"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_modifiedDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_modifiedBy"]);
                this.customer = DS.Tables[0].Rows[0]["mill_customer"].ToString();
                this.ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_productcodsec"]);
                this.ProductName = DS.Tables[0].Rows[0]["mill_productname"].ToString();
                this.ProductCode = DS.Tables[0].Rows[0]["mill_productcode"].ToString();
                this.OperatorM = DS.Tables[0].Rows[0]["mill_operator"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkEntity"]);
                this.enityName = DS.Tables[0].Rows[0]["mill_customerName"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_millpallet (mill_fkStatus, mill_fkMill, mill_fkProduct, mill_fkEntity, mill_Product, mill_code, mill_lotNumber, mill_bag, mill_order, mill_palletWeight, mill_grossWeight, mill_netWeight, mill_density, mill_notes, mill_createdDate, mill_modifiedDate, mill_createdBy, mill_modifiedBy, mill_customer, mill_operator)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkStatus.ToString() + ",";
                    queryString += "" + this.fkMill.ToString() + ",";
                    queryString += "" + this.fkProduct.ToString() + ",";
                    queryString += "" + this.fkEntity.ToString() + ",";
                    queryString += "'" + this.Product.ToString() + "',";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += "'" + this.lotNumber.ToString() + "',";
                    queryString += "" + this.bag.ToString() + ",";
                    queryString += "" + this.order.ToString() + ",";
                    queryString += "" + this.palletWeigth.ToString() + ",";
                    queryString += "" + this.grossWeigth.ToString() + ",";
                    queryString += "" + this.netWeigth.ToString() + ",";
                    queryString += "" + this.density.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.customer.ToString() + "',";
                    queryString += "'" + this.OperatorM.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_millpallet";
                    queryString += " SET ";
                    queryString += " mill_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += " mill_fkMill = " + this.fkMill.ToString() + ",";
                    queryString += " mill_fkProduct = " + this.fkProduct.ToString() + ",";
                    queryString += " mill_fkEntity = " + this.fkEntity.ToString() + ",";
                    queryString += " mill_Product = '" + this.Product.ToString() + "',";
                    queryString += " mill_bag = " + this.bag.ToString() + ",";
                    queryString += " mill_customer = '" + this.customer.ToString() + "',";
                    queryString += " mill_operator = '" + this.OperatorM.ToString() + "',";
                    queryString += " mill_notes = '" + this.notes.ToString() + "',";
                    queryString += " mill_palletWeight = " + this.palletWeigth.ToString() + ",";
                    queryString += " mill_grossWeight = " + this.grossWeigth.ToString() + ",";
                    queryString += " mill_netWeight = " + this.netWeigth.ToString() + ",";
                    queryString += " mill_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mill_codsec = " + this.codsec.ToString();
                }

                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                    {
                        clsSequential.addSequential("millPallet");
                        return true;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPallet.save");
                return false;
            }
        }

        public bool saveDensity()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_millpallet";
                queryString += " SET ";
                queryString += " mill_density = " + this.density.ToString() + "";
                queryString += " WHERE mill_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPallet.save");
                return false;
            }
        }

        public static bool toClose(int codsec)
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_millpallet";
                queryString += " SET ";
                queryString += " mill_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Cerrada").codsec.ToString() + "";
                queryString += " WHERE mill_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static bool toReOpen(int codsec)
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_millpallet";
                queryString += " SET ";
                queryString += " mill_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Activa").codsec.ToString() + "";
                queryString += " WHERE mill_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";


                queryString += "UPDATE bps_prod_millpallet";
                queryString += " SET ";
                queryString += " mill_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Anulada").codsec.ToString() + ",";
                queryString += " mill_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += " mill_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                queryString += " WHERE mill_codsec = " + codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoil.save");
                return false;
            }
        }

        public static List<clsMillPallet> getList()
        {
            List<clsMillPallet> lstMillPallet = new List<clsMillPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletList','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            lstMillPallet.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMillPallet.Add(new clsMillPallet());

                lstMillPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                lstMillPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkStatus"]);
                lstMillPallet[i].StatusName = DS.Tables[0].Rows[i]["mill_sttName"].ToString();
                lstMillPallet[i].fkMill = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkMill"]);
                lstMillPallet[i].MillName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                lstMillPallet[i].Product = DS.Tables[0].Rows[i]["mill_Product"].ToString();
                lstMillPallet[i].code = DS.Tables[0].Rows[i]["mill_code"].ToString();
                lstMillPallet[i].lotNumber = DS.Tables[0].Rows[i]["mill_lotNumber"].ToString();
                lstMillPallet[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_bag"].ToString());
                lstMillPallet[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_order"].ToString());
                lstMillPallet[i].palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_palletWeight"]);
                lstMillPallet[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_grossWeight"]);
                lstMillPallet[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_netWeight"]);
                lstMillPallet[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_density"]);
                lstMillPallet[i].notes = DS.Tables[0].Rows[i]["mill_notes"].ToString();
                lstMillPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_createdDate"]);
                lstMillPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_modifiedDate"]);
                lstMillPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_createdBy"]);
                lstMillPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_modifiedBy"]);
                lstMillPallet[i].customer = DS.Tables[0].Rows[i]["mill_customer"].ToString();
                lstMillPallet[i].ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                lstMillPallet[i].ProductName = DS.Tables[0].Rows[i]["mill_productname"].ToString();
                lstMillPallet[i].ProductCode = DS.Tables[0].Rows[i]["mill_productcode"].ToString();
                lstMillPallet[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkEntity"]);
                lstMillPallet[i].enityName = DS.Tables[0].Rows[i]["mill_customerName"].ToString();
            }

            return lstMillPallet;
        }

        public static clsMillPallet getMillPalletByCodsec(int codsec)
        {
            clsMillPallet objMillPallet = new clsMillPallet();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletByCodsec','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                objMillPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                objMillPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkStatus"]);
                objMillPallet.StatusName = DS.Tables[0].Rows[i]["mill_sttName"].ToString();
                objMillPallet.fkMill = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkMill"]);
                objMillPallet.MillName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                objMillPallet.Product = DS.Tables[0].Rows[i]["mill_Product"].ToString();
                objMillPallet.code = DS.Tables[0].Rows[i]["mill_code"].ToString();
                objMillPallet.lotNumber = DS.Tables[0].Rows[i]["mill_lotNumber"].ToString();
                objMillPallet.bag = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_bag"].ToString());
                objMillPallet.order = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_order"].ToString());
                objMillPallet.palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_palletWeight"]);
                objMillPallet.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_grossWeight"]);
                objMillPallet.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_netWeight"]);
                objMillPallet.density = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_density"]);
                objMillPallet.notes = DS.Tables[0].Rows[i]["mill_notes"].ToString();
                objMillPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_createdDate"]);
                objMillPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_modifiedDate"]);
                objMillPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_createdBy"]);
                objMillPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_modifiedBy"]);
                objMillPallet.customer = DS.Tables[0].Rows[i]["mill_customer"].ToString();
                objMillPallet.ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                objMillPallet.ProductName = DS.Tables[0].Rows[i]["mill_productname"].ToString();
                objMillPallet.ProductCode = DS.Tables[0].Rows[i]["mill_productcode"].ToString();
                objMillPallet.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkEntity"]);
                objMillPallet.enityName = DS.Tables[0].Rows[i]["mill_customerName"].ToString();
            }

            return objMillPallet;
        }

        public static List<clsMillPallet> getListByCode(string code)
        {
            List<clsMillPallet> lstMillPallet = new List<clsMillPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletListByCode','" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            lstMillPallet.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMillPallet.Add(new clsMillPallet());

                lstMillPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_codsec"]);
                lstMillPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkStatus"]);
                lstMillPallet[i].StatusName = DS.Tables[0].Rows[i]["mill_sttName"].ToString();
                lstMillPallet[i].fkMill = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkMill"]);
                lstMillPallet[i].MillName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                lstMillPallet[i].Product = DS.Tables[0].Rows[i]["mill_Product"].ToString();
                lstMillPallet[i].code = DS.Tables[0].Rows[i]["mill_code"].ToString();
                lstMillPallet[i].lotNumber = DS.Tables[0].Rows[i]["mill_lotNumber"].ToString();
                lstMillPallet[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_bag"].ToString());
                lstMillPallet[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_order"].ToString());
                lstMillPallet[i].palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_palletWeight"]);
                lstMillPallet[i].grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_grossWeight"]);
                lstMillPallet[i].netWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_netWeight"]);
                lstMillPallet[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["mill_density"]);
                lstMillPallet[i].notes = DS.Tables[0].Rows[i]["mill_notes"].ToString();
                lstMillPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_createdDate"]);
                lstMillPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mill_modifiedDate"]);
                lstMillPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_createdBy"]);
                lstMillPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_modifiedBy"]);
                lstMillPallet[i].customer = DS.Tables[0].Rows[i]["mill_customer"].ToString();
                lstMillPallet[i].ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                lstMillPallet[i].ProductName = DS.Tables[0].Rows[i]["mill_productname"].ToString();
                lstMillPallet[i].ProductCode = DS.Tables[0].Rows[i]["mill_productcode"].ToString();
                lstMillPallet[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_fkEntity"]);
                lstMillPallet[i].enityName = DS.Tables[0].Rows[i]["mill_customerName"].ToString();
            }

            return lstMillPallet;
        }

        public static string toCustomer(int codsec)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpallet WHERE bps_prod_millpallet.mill_codsec = " + codsec.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0]["mill_customer"].ToString();
                else
                    return "";

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return "";
            }
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mill_codsec FROM bps_prod_millpallet ORDER BY mill_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
        }

        public void changeStatus(string status)
        {
            switch (status)
            {
                case "En proceso":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", status)).codsec;
                    this.save();
                    break;
                case "Cerrada":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", status)).codsec;
                    this.save();
                    break;
            }
        }

        public override string ToString()
        {
            return this.code;
        }

        public static bool getMillPalletByCode(string Code)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpallet WHERE bps_prod_millpallet.mill_code = '" + Code + "'");

                if (DS.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static clsMillPallet getObjMillPallet(string code)
        {
            clsMillPallet objMillPallet = new clsMillPallet();

            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MillPalletListByCode','" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    objMillPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_codsec"]);
                    objMillPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkStatus"]);
                    objMillPallet.StatusName = DS.Tables[0].Rows[0]["mill_sttName"].ToString();
                    objMillPallet.fkMill = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkMill"]);
                    objMillPallet.MillName = DS.Tables[0].Rows[0]["mill_millName"].ToString();
                    objMillPallet.ProductCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_productcodsec"]);
                    objMillPallet.ProductName = DS.Tables[0].Rows[0]["mill_productname"].ToString();
                    objMillPallet.ProductCode = DS.Tables[0].Rows[0]["mill_productcode"].ToString();
                    objMillPallet.Product = DS.Tables[0].Rows[0]["mill_Product"].ToString();
                    objMillPallet.code = DS.Tables[0].Rows[0]["mill_code"].ToString();
                    objMillPallet.lotNumber = DS.Tables[0].Rows[0]["mill_lotNumber"].ToString();
                    objMillPallet.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_bag"].ToString());
                    objMillPallet.order = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_order"].ToString());
                    objMillPallet.palletWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_palletWeight"]);
                    objMillPallet.grossWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_grossWeight"]);
                    objMillPallet.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_netWeight"]);
                    objMillPallet.density = Convert.ToDouble(DS.Tables[0].Rows[0]["mill_density"]);
                    objMillPallet.notes = DS.Tables[0].Rows[0]["mill_notes"].ToString();
                    objMillPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_createdDate"]);
                    objMillPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mill_modifiedDate"]);
                    objMillPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_createdBy"]);
                    objMillPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_modifiedBy"]);
                    objMillPallet.customer = DS.Tables[0].Rows[0]["mill_customer"].ToString();
                    objMillPallet.OperatorM = DS.Tables[0].Rows[0]["mill_operator"].ToString();
                    objMillPallet.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_fkEntity"]);
                    objMillPallet.enityName = DS.Tables[0].Rows[0]["mill_customerName"].ToString();
                }
                return objMillPallet;
            }
            catch (Exception)
            {
                return objMillPallet;
            }
        }

        public static clsMillPallet getPalletInInventory(string code)
        {
            clsMillPallet objPallet = new clsMillPallet();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spPalletByInventorty 'ExistRepro','" + code + "'");

            try
            {

                if (DS.Tables[0].Rows.Count == 1)
                {
                    objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                    objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                    objPallet.ProductName = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objPallet.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                    objPallet.order = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                    objPallet.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);

                    if (DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString() == "Bodega Reproceso")
                        objPallet.notes = "Normal";
                    else
                        objPallet.notes = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                }
                else if (DS.Tables[0].Rows.Count > 1)
                {
                    objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                    objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                    objPallet.ProductName = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objPallet.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                    objPallet.order = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                    objPallet.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);

                    if (DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString() == "Bodega Reproceso")
                        objPallet.notes = "Duplicado";
                    else
                        objPallet.notes = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                }
            }
            catch (Exception)
            {
                objPallet = new clsMillPallet();
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }
    }
}