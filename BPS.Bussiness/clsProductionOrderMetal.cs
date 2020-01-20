using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de Metalizado
    /// </summary>
    public class clsProductionOrderMetal
    {
        //Atributes

        private int pordm_codsec;
        private int pordm_fkBopp;
        private clsBopp pordm_Bopp;
        private int pordm_fkBoppOriginal;
        private clsBopp pordm_BoppOriginal;
        private int pordm_fkCast;
        private clsCast pordm_Cast;
        private int pordm_fkCoating;
        private clsCoating pordm_Coating;
        private int pordm_fkThermoformed;
        private string pordm_ThermoformedName;
        private int pordm_fkReprocessed;
        private string pordm_ReprocessedName;
        private int pordm_fkStatus;
        private string pordm_StatusName;
        private int pordm_number;
        private double pordm_quantity;
        private int pordm_inheritedFrom;
        private string pordm_closeObservation;
        private DateTime pordm_createdDate;
        private DateTime pordm_modifiedDate;
        private int pordm_createdBy;
        private string pordm_creatorUser;
        private int pordm_modifiedBy;
        private string pordm_modificatorUser;
        private List<clsSalesOrder> pordm_lstSalesOrder;
        private string pordm_customerLists;
        private Boolean pordm_createdFromOtherOrder;
        private List<int> lstDetails;
        private int pordm_fkBoppTo;
        private string pordm_BoppFrom;
        private string pordm_BoppTo;
        private string pordm_lotNumber;
        private string pordm_customer;
        private int pordm_coil;
        private DateTime pordm_estimateinitdate;
        private int pordm_ordenation;
        private string pordm_widthFrom;
        private string pordm_widthTo;
        private int pordm_kilograms;
        private DateTime pordm_estimadteendDate;
        private int pordm_fkFilmProductionOrderMetal;
        private string pordm_notes;

        private int pordm_fkMachine;
        private string pordm_MachineName;
        private double pordm_densityoptic;
        private int pordm_countmaincoil;

        //Properties

        public int codsec { get { return pordm_codsec; } set { pordm_codsec = value; } }

        public int fkBopp { get { return pordm_fkBopp; } set { pordm_fkBopp = value; } }

        public clsBopp Bopp { get { return pordm_Bopp; } set { pordm_Bopp = value; } }

        public int fkBoppOriginal { get { return pordm_fkBoppOriginal; } set { pordm_fkBoppOriginal = value; } }

        public clsBopp BoppOriginal { get { return pordm_BoppOriginal; } set { pordm_BoppOriginal = value; } }

        public int fkCast { get { return pordm_fkCast; } set { pordm_fkCast = value; } }

        public clsCast Cast { get { return pordm_Cast; } set { pordm_Cast = value; } }

        public int fkCoating { get { return pordm_fkCoating; } set { pordm_fkCoating = value; } }

        public clsCoating Coating { get { return pordm_Coating; } set { pordm_Coating = value; } }

        public int fkThermoformed { get { return pordm_fkThermoformed; } set { pordm_fkThermoformed = value; } }

        public string ThermoformedName { get { return pordm_ThermoformedName; } set { pordm_ThermoformedName = value; } }

        public int fkReprocessed { get { return pordm_fkReprocessed; } set { pordm_fkReprocessed = value; } }

        public string ReprocessedName { get { return pordm_ReprocessedName; } set { pordm_ReprocessedName = value; } }

        public int fkStatus { get { return pordm_fkStatus; } set { pordm_fkStatus = value; } }

        public int number { get { return pordm_number; } set { pordm_number = value; } }

        public double quantity { get { return pordm_quantity; } set { pordm_quantity = value; } }

        public string StatusName { get { return pordm_StatusName; } set { pordm_StatusName = value; } }

        public int inheritedFrom { get { return pordm_inheritedFrom; } set { pordm_inheritedFrom = value; } }

        public string closeObservation { get { return pordm_closeObservation; } set { pordm_closeObservation = value; } }

        public DateTime createdDate { get { return pordm_createdDate; } set { pordm_createdDate = value; } }

        public DateTime modifiedDate { get { return pordm_modifiedDate; } set { pordm_modifiedDate = value; } }

        public int createdBy { get { return pordm_createdBy; } set { pordm_createdBy = value; } }

        public string creatorUser { get { return pordm_creatorUser; } set { pordm_creatorUser = value; } }

        public int modifiedBy { get { return pordm_modifiedBy; } set { pordm_modifiedBy = value; } }

        public string modificatorUser { get { return pordm_modificatorUser; } set { pordm_modificatorUser = value; } }

        public List<clsSalesOrder> lstSalesOrder { get { return pordm_lstSalesOrder; } set { pordm_lstSalesOrder = value; } }

        public string customerLists { get { return pordm_customerLists; } set { pordm_customerLists = value; } }

        public Boolean createdFromOtherOrder { get { return pordm_createdFromOtherOrder; } set { pordm_createdFromOtherOrder = value; } }

        public List<int> lstdetail { get { return lstDetails; } set { lstDetails = value; } }

        public int fkBoppTo { get { return pordm_fkBoppTo; } set { pordm_fkBoppTo = value; } }

        public string BoppFrom { get { return pordm_BoppFrom; } set { pordm_BoppFrom = value; } }

        public string BoppTo { get { return pordm_BoppTo; } set { pordm_BoppTo = value; } }

        public string lotNumber { get { return pordm_lotNumber; } set { pordm_lotNumber = value; } }

        public string Customer { get { return pordm_customer; } set { pordm_customer = value; } }

        public int Coil { get { return pordm_coil; } set { pordm_coil = value; } }

        public DateTime EstimateInitDate { get { return pordm_estimateinitdate; } set { pordm_estimateinitdate = value; } }

        public int ordenation { get { return pordm_ordenation; } set { pordm_ordenation = value; } }

        public string widthFrom { get { return pordm_widthFrom; } set { pordm_widthFrom = value; } }

        public string widthTo { get { return pordm_widthTo; } set { pordm_widthTo = value; } }

        public int kilograms { get { return pordm_kilograms; } set { pordm_kilograms = value; } }

        public DateTime EstimadteEndDate { get { return pordm_estimadteendDate; } set { pordm_estimadteendDate = value; } }

        public int fkFilmProductionOrderMetal { get { return pordm_fkFilmProductionOrderMetal; } set { pordm_fkFilmProductionOrderMetal = value; } }

        public string notes { get { return pordm_notes; } set { pordm_notes = value; } }

        public int fkMachine { get { return pordm_fkMachine; } set { pordm_fkMachine = value; } }

        public string MachineName { get { return pordm_MachineName; } set { pordm_MachineName = value; } }

        public double densityoptic { get { return pordm_densityoptic; } set { pordm_densityoptic = value; } }

        public int countmaincoil { get { return pordm_countmaincoil; } set { pordm_countmaincoil = value; } }


        //Constructor

        public clsProductionOrderMetal()
        {
            pordm_densityoptic = 0;
            pordm_MachineName = "";
            pordm_fkMachine = 0;
            pordm_codsec = 0;
            pordm_fkBopp = 0;
            pordm_Bopp = new clsBopp();
            pordm_fkBoppOriginal = 0;
            pordm_BoppOriginal = new clsBopp();
            pordm_fkCast = 0;
            pordm_Cast = new clsCast();
            pordm_fkCoating = 0;
            pordm_Coating = new clsCoating();
            pordm_fkThermoformed = 0;
            pordm_ThermoformedName = "";
            pordm_fkReprocessed = 0;
            pordm_ReprocessedName = "";
            pordm_fkStatus = 0;
            pordm_StatusName = "";
            pordm_number = 0;
            pordm_quantity = 0;
            pordm_inheritedFrom = 0;
            pordm_closeObservation = "";
            pordm_createdDate = DateTime.Now;
            pordm_modifiedDate = DateTime.Now;
            pordm_createdBy = 0;
            pordm_creatorUser = "";
            pordm_modifiedBy = 0;
            pordm_modificatorUser = "";
            pordm_lstSalesOrder = new List<clsSalesOrder>();
            pordm_customerLists = "";
            pordm_createdFromOtherOrder = false;
            lstDetails = new List<int>();
            pordm_fkBoppTo = 0;
            pordm_BoppFrom = "";
            pordm_BoppTo = "";
            pordm_lotNumber = "";
            pordm_customer = "";
            pordm_coil = 0;
            pordm_estimateinitdate = DateTime.Now;
            pordm_ordenation = 0;
            pordm_widthFrom = "";
            pordm_widthTo = "";
            pordm_kilograms = 0;
            pordm_estimadteendDate = DateTime.Now;
            pordm_fkFilmProductionOrderMetal = 0;
            pordm_notes = "---------";
        }
        public clsProductionOrderMetal(int productionOrderCodsec)
        {
            this.load(productionOrderCodsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedOrderMultiple 'ProductionListByCodsec','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_codsec"]);
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_fkBoppFrom"]);
            this.BoppFrom = DS.Tables[0].Rows[0]["BoppFrom_code"].ToString();
            this.fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_fkBoppTo"]);
            this.BoppTo = DS.Tables[0].Rows[0]["BoppTo_code"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["stt_name"].ToString();
            this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_number"]);
            this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["pordm_quantity"]);
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pordm_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pordm_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_createdBy"]);
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_modifiedBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["usr_userName"].ToString();
            this.modificatorUser = DS.Tables[0].Rows[0]["usr_userName"].ToString();
            this.lotNumber = DS.Tables[0].Rows[0]["fpom_lotNumber"].ToString();
            this.Customer = DS.Tables[0].Rows[0]["Customer"].ToString();
            this.Coil = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_coilsnumber"]);
            this.EstimateInitDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedInitDate"]);
            this.ordenation = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_ordenation"]);
            this.widthFrom = DS.Tables[0].Rows[0]["fpom_widthFrom"].ToString();
            this.widthTo = DS.Tables[0].Rows[0]["fpom_widthTo"].ToString();
            this.kilograms = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_estimatedKilogramsPerHour"]);
            this.EstimadteEndDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpom_estimatedEndDate"]);
            this.fkFilmProductionOrderMetal = Convert.ToInt32(DS.Tables[0].Rows[0]["fpom_codsec"]);
        }
        public bool save()
        {
            try
            {
                string queryString = "";
                clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Activa");

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_productionordermetal (pordm_fkBoppFrom, pordm_fkBoppTo, pordm_fkStatus, pordm_number, pordm_quantity, pordm_createdDate, pordm_modifiedDate, pordm_createdBy, pordm_modifiedBy, pordm_closeObservation)";
                    queryString += " VALUES (";
                    queryString += " " + this.fkBopp.ToString() + ",";
                    queryString += " " + this.fkBoppTo.ToString() + ",";
                    queryString += " " + objStatus.codsec.ToString() + ",";
                    queryString += " " + this.number.ToString() + ",";
                    queryString += " " + this.quantity.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += " " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += " '" + this.closeObservation.ToString() + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_productionordermetal";
                    queryString += " SET ";
                    queryString += " pordm_fkBopp = " + this.fkBopp.ToString() + ",";
                    queryString += " pordm_number = " + this.number.ToString() + ",";
                    queryString += " pordm_quantity = " + this.quantity.ToString() + ",";
                    queryString += " pordm_closeObservation = '" + this.closeObservation.ToString() + "',";
                    queryString += " pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                    queryString += " WHERE pordm_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                        this.codsec = getLastSavedCodsec();

                    if (clsConnection.executeQuery("DELETE FROM bps_prod_metalizepersalesorderdetail WHERE mtosod_fkMetailizeOrder = " + this.codsec.ToString()))
                    {
                        for (int i = 0; i < this.lstdetail.Count; i++)
                        {
                            clsConnection.executeQuery("INSERT INTO bps_prod_metalizepersalesorderdetail (`mtosod_fkMetailizeOrder`, `mtosod_fkSalesOrderDetail`) VALUES (" + this.codsec.ToString() + ", " + this.lstdetail[i] + ");");
                        }
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProductionOrder.save");
                return false;
            }
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pordm_codsec FROM bps_prod_productionordermetal ORDER BY pordm_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_codsec"]);
        }
        public static List<clsProductionOrderMetal> getActiveList()
        {
            DataSet DS = new DataSet();
            List<clsProductionOrderMetal> lstProductionOrders = new List<clsProductionOrderMetal>();

            DS = clsConnection.getDataSetResult("spMetalizedOrderMultiple 'ActiveList','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrderMetal());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppFrom"]);
                    lstProductionOrders[i].BoppFrom = DS.Tables[0].Rows[i]["BoppFrom_code"].ToString();
                    lstProductionOrders[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppTo"]);
                    lstProductionOrders[i].BoppTo = DS.Tables[0].Rows[i]["BoppTo_code"].ToString();
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_createdBy"]);
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_modifiedBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstProductionOrders[i].Customer = DS.Tables[0].Rows[i]["Customer"].ToString();
                    lstProductionOrders[i].Coil = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_coilsnumber"]);
                    lstProductionOrders[i].EstimateInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstProductionOrders[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstProductionOrders[i].widthFrom = DS.Tables[0].Rows[i]["fpom_widthFrom"].ToString();
                    lstProductionOrders[i].widthTo = DS.Tables[0].Rows[i]["fpom_widthTo"].ToString();
                    lstProductionOrders[i].fkFilmProductionOrderMetal = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                }
            }
            return lstProductionOrders;
        }

        public static List<clsProductionOrderMetal> getActiveList(int fkplant)
        {
            DataSet DS = new DataSet();
            List<clsProductionOrderMetal> lstProductionOrders = new List<clsProductionOrderMetal>();

            DS = clsConnection.getDataSetResult("spMetalizedOrderByplant "+fkplant.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrderMetal());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppFrom"]);
                    lstProductionOrders[i].BoppFrom = DS.Tables[0].Rows[i]["BoppFrom_code"].ToString();
                    lstProductionOrders[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppTo"]);
                    lstProductionOrders[i].BoppTo = DS.Tables[0].Rows[i]["BoppTo_code"].ToString();
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_createdBy"]);
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_modifiedBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstProductionOrders[i].Customer = DS.Tables[0].Rows[i]["Customer"].ToString();
                    lstProductionOrders[i].Coil = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_coilsnumber"]);
                    lstProductionOrders[i].EstimateInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstProductionOrders[i].notes = DS.Tables[0].Rows[i]["fpom_notes"].ToString();
                    lstProductionOrders[i].widthFrom = DS.Tables[0].Rows[i]["fpom_widthFrom"].ToString();
                    lstProductionOrders[i].widthTo = DS.Tables[0].Rows[i]["fpom_widthTo"].ToString();
                    lstProductionOrders[i].fkFilmProductionOrderMetal = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_codsec"]);
                }
            }
            return lstProductionOrders;
        }

        public static List<clsProductionOrderMetal> getActiveListByDate(DateTime myDate)
        {
            DataSet DS = new DataSet();
            List<clsProductionOrderMetal> lstProductionOrders = new List<clsProductionOrderMetal>();

            DS = clsConnection.getDataSetResult("spMetalizedOrderMultiple 'ProductionList','" + myDate.ToString("dd/MM/yyyy HH:mm:ss") + "',0");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrderMetal());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppFrom"]);
                    lstProductionOrders[i].BoppFrom = DS.Tables[0].Rows[i]["BoppFrom_code"].ToString();
                    lstProductionOrders[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppTo"]);
                    lstProductionOrders[i].BoppTo = DS.Tables[0].Rows[i]["BoppTo_code"].ToString();
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_createdBy"]);
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_modifiedBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstProductionOrders[i].Customer = DS.Tables[0].Rows[i]["Customer"].ToString();
                    lstProductionOrders[i].Coil = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_coilsnumber"]);
                    lstProductionOrders[i].EstimateInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstProductionOrders[i].ordenation = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_ordenation"]);
                    lstProductionOrders[i].widthFrom = DS.Tables[0].Rows[i]["fpom_widthFrom"].ToString();
                    lstProductionOrders[i].widthTo = DS.Tables[0].Rows[i]["fpom_widthTo"].ToString();
                    lstProductionOrders[i].kilograms = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstProductionOrders[i].EstimadteEndDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedEndDate"]);
                }
            }
            return lstProductionOrders;
        }

        public bool updatePos()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += "pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE pordm_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                {
                    clsFilmProductionPlanMetal objFilmProductionPlanMetal = new clsFilmProductionPlanMetal();
                    objFilmProductionPlanMetal.ordenation = this.ordenation;
                    if (objFilmProductionPlanMetal.save("pos", this.fkFilmProductionOrderMetal))
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public bool UpdateQuality()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += "pordm_quantity = " + this.quantity.ToString() + ", ";
                queryString += "pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE pordm_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
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

        public static bool toCrossOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += "pordm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Anulada").codsec.ToString() + ", ";
                queryString += "pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE pordm_codsec = " + codsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);

                //if (clsConnection.executeQuery(queryString))
                //{
                //    queryString = "";
                //    queryString = "UPDATE bps_admin_sequential SET seq_metallizedOrder = " + (clsSequential.SequentialList("metallizedOrder") - 1);
                //    if (clsConnection.executeQuery(queryString))
                //        return true;
                //    else
                //        return false;
                //}
                //else
                //    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static List<clsProductionOrder> getListByFilter(List<clsFilter> lstFilter)
        {

            DataSet DS = new DataSet();
            List<clsProductionOrder> lstProductionOrders = new List<clsProductionOrder>();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = "WHERE  " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwproductionorder " + where);

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrder());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBopp"]);
                    lstProductionOrders[i].Bopp = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBopp"]));
                    lstProductionOrders[i].fkBoppOriginal = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppOriginal"]);
                    lstProductionOrders[i].BoppOriginal = new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppOriginal"]));
                    lstProductionOrders[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkCast"]);
                    lstProductionOrders[i].Cast = new clsCast(Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkCast"]));
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["pordm_StatusName"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstProductionOrders[i].inheritedFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_inheritedFrom"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_createdBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["pordm_creatorUser"].ToString();
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_modifiedBy"]);
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["pordm_modificatorUser"].ToString();
                    lstProductionOrders[i].lstSalesOrder = clsSalesOrder.getListByProductionOrder(lstProductionOrders[i].codsec);
                    lstProductionOrders[i].createdFromOtherOrder = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pordm_createdFromOtherOrder"], DS.Tables[0].Rows[i]["pordm_createdFromOtherOrder"].GetType().FullName);
                    for (int j = 0; j < lstProductionOrders[i].lstSalesOrder.Count; j++)
                        lstProductionOrders[i].customerLists += lstProductionOrders[i].lstSalesOrder[j].EntityName + "(" + lstProductionOrders[i].lstSalesOrder[j].number.ToString() + "); ";
                }
            }

            return lstProductionOrders;
        }

        public static void changeOrderStatus(int codsec, string status)
        {
            clsStatus objStatus = new clsStatus();
            string queryString = "";

            try
            {
                objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", status);
                queryString += "UPDATE bps_prod_productionorder";
                queryString += " SET ";
                queryString += " pordm_fkStatus = " + objStatus.codsec.ToString() + "";
                queryString += " WHERE pordm_codsec = " + codsec + ";";
                clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "changeOrderStatus.save");
            }
        }

        public static int getNextNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pordm_number FROM vwproductionorder Order By pordm_number DESC LIMIT 1");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_number"]) + 1;
            else
                return 1;
        }

        public static bool toProcessOrder(int codsec, int fkFilmProductionOrderMetal, string lotNumber)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += "pordm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Proceso").codsec.ToString() + ", ";
                queryString += "pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE pordm_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                {
                    queryString = "";
                    queryString += "UPDATE bps_prod_filmproductionplanmetal";
                    queryString += " SET ";
                    queryString += "fpom_lotNumber = '" + lotNumber + "', ";
                    queryString += "fpom_variationDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "fpom_variation = 1";
                    queryString += " WHERE fpom_codsec = " + fkFilmProductionOrderMetal.ToString() + ";";

                    return clsConnection.executeQuery(queryString);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                
                return false;
            }
        }

        

        public static bool toPauseOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += "pordm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Cerrada").codsec.ToString() + ", ";
                queryString += "pordm_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE pordm_codsec = " + codsec.ToString() + ";";

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public bool toCloseOrder()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_productionordermetal";
                queryString += " SET ";
                queryString += " pordm_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Cerrada").codsec + ",";
                queryString += " pordm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += " pordm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                queryString += " WHERE pordm_codsec = " + this.codsec.ToString();

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

        public void close()
        {
            clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
            objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(this.codsec);

            List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(objFilmProductionPlan.fkMachine);

            objFilmProductionPlan.estimatedEndDate = DateTime.Now;
            objFilmProductionPlan.save();

            DateTime initDate = new DateTime();
            if (lstFilmProductionPlan.Count > 0)
                initDate = DateTime.Now;

            for (int i = 1; i < lstFilmProductionPlan.Count; i++)
            {
                if (i == 1)
                {
                    lstFilmProductionPlan[i].estimatedInitDate = initDate;
                    lstFilmProductionPlan[i].estimatedEndDate = initDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                else
                {
                    lstFilmProductionPlan[i].estimatedInitDate = lstFilmProductionPlan[i - 1].estimatedEndDate;
                    lstFilmProductionPlan[i].estimatedEndDate = lstFilmProductionPlan[i].estimatedInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                lstFilmProductionPlan[i].save();
            }

            clsProductionOrder.changeOrderStatus(this.codsec, "Cerrada");
        }

        public static int toCheckMainCoilMetal(int fkProductionOrderMetal)
        {
            DataSet DS = new DataSet();
            List<clsProductionOrderMetal> lstProductionOrders = new List<clsProductionOrderMetal>();

            DS = clsConnection.getDataSetResult("SELECT COUNT(*) as mycoil FROM bps_prod_maincoilmetal WHERE bps_prod_maincoilmetal.mclm_fkFilmProductionPlan = " + fkProductionOrderMetal.ToString());

            if (DS.Tables.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["mycoil"]);
            else
                return 0;
        }

        public static List<clsProductionOrderMetal> getFilmProductionPlanByCodsec(int fkFilmProductionPlan)
        {
            DataSet DS = new DataSet();
            List<clsProductionOrderMetal> lstProductionOrders = new List<clsProductionOrderMetal>();

            DS = clsConnection.getDataSetResult("spMetalizedOrderMultiple 'FilmProductionPlanByCodsec','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + fkFilmProductionPlan.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrders.Add(new clsProductionOrderMetal());
                    lstProductionOrders[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_codsec"]);
                    lstProductionOrders[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppFrom"]);
                    lstProductionOrders[i].BoppFrom = DS.Tables[0].Rows[i]["BoppFrom_code"].ToString();
                    lstProductionOrders[i].fkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkBoppTo"]);
                    lstProductionOrders[i].BoppTo = DS.Tables[0].Rows[i]["BoppTo_code"].ToString();
                    lstProductionOrders[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_fkStatus"]);
                    lstProductionOrders[i].StatusName = DS.Tables[0].Rows[i]["stt_name"].ToString();
                    lstProductionOrders[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_number"]);
                    lstProductionOrders[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstProductionOrders[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_createdDate"]);
                    lstProductionOrders[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pordm_modifiedDate"]);
                    lstProductionOrders[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_createdBy"]);
                    lstProductionOrders[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pordm_modifiedBy"]);
                    lstProductionOrders[i].creatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].modificatorUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
                    lstProductionOrders[i].lotNumber = DS.Tables[0].Rows[i]["fpom_lotNumber"].ToString();
                    lstProductionOrders[i].Customer = DS.Tables[0].Rows[i]["Customer"].ToString();
                    lstProductionOrders[i].Coil = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_coilsnumber"]);
                    lstProductionOrders[i].EstimateInitDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpom_estimatedInitDate"]);
                    lstProductionOrders[i].MachineName = DS.Tables[0].Rows[i]["met_name"].ToString();
                    lstProductionOrders[i].kilograms = Convert.ToInt32(DS.Tables[0].Rows[i]["fpom_estimatedKilogramsPerHour"]);
                    lstProductionOrders[i].densityoptic = Convert.ToDouble(DS.Tables[0].Rows[i]["fpom_density"]);
                }
            }
            return lstProductionOrders;
        }
    }
}
