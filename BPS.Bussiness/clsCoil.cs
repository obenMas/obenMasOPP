using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las bobinas de Producto terminado
    /// </summary>
    public class clsCoil
    {
        //Atributes

        private int coil_codsec;
        private int coil_fkCuttingQuality;
        private string coil_CuttingQualityName;
        private int coil_fkBalance;
        private string coil_BalanceName;
        private int coil_fkBopp;
        private int coil_fkCast;
        private int coil_fkProduct;
        private string coil_ProductName;
        private string coil_ProductCode;
        private int coil_fkCuttingStop;
        private int coil_fkStatus;
        private string coil_statusName;
        private string coil_code;
        private double coil_length;
        private double coil_width;
        private double coil_diameter;
        private double coil_density;
        private double coil_palletnetwieght;
        private double coil_palletgrossweight;
        private int coil_cuttingPosition;
        private int coil_cuttingStop;
        private double coil_netWeight;
        private double coil_grossWeight;
        private string coil_treatmentSide;
        private string coil_defects;
        private List<bool> coil_lstDefects;
        private string coil_notes;
        private DateTime coil_cuttingDate;
        private DateTime coil_createdDate;
        private DateTime coil_modifiedDate;
        private int coil_createdBy;
        private string coil_creatorUser;
        private int coil_modifiedBy;
        private string coil_modificatorUser;
        private clsCoilCellar coil_CoilCellarContainer;
        private string coil_customerName;
        private int coil_fkEntity;
        private string coil_salesOrderNumber;
        private int coil_fkSalesOrder;
        private int coil_fkSalesOrderDetail;
        private int coil_fkPallet;
        private string coil_palletCode;
        private bool coil_wasAuthorized;
        private bool coil_wasRewined;
        private bool coil_wasCutted;
        private bool coil_wasMilled;
        private bool coil_isExternalCoil;
        private string coil_lotNumber;
        private string coil_mainCoilCode;
        private string coil_supervisorName;
        private string coil_supervisorInitials;
        private string coil_digitizerName;
        private string coil_digitizerInitials;
        private string coil_operatorName;
        private string coil_operatorInitials;
        private bool coil_externalLabelPrint;
        private DateTime coil_extrusionDate;
        private int coil_fkCoilCellar;
        private string coil_cellar;
        private int coil_core;
        private string coil_diameters;
        private string coil_origin;
        private bool coil_isblock;
        private int coil_fkProcedenceCountry;
        private int coil_fkCoilcellar;

        public bool isBlock
        {
            get { return coil_isblock; }
            set { coil_isblock = value; }
        }


        //Properties

        public int codsec { get { return coil_codsec; } set { coil_codsec = value; } }

        public int fkCuttingQuality { get { return coil_fkCuttingQuality; } set { coil_fkCuttingQuality = value; } }

        public string CuttingQualityName { get { return coil_CuttingQualityName; } set { coil_CuttingQualityName = value; } }

        public int fkBalance { get { return coil_fkBalance; } set { coil_fkBalance = value; } }

        public string BalanceName { get { return coil_BalanceName; } set { coil_BalanceName = value; } }

        public int fkBopp { get { return coil_fkBopp; } set { coil_fkBopp = value; } }

        public int fkCast { get { return coil_fkCast; } set { coil_fkCast = value; } }

        public int fkProduct { get { return coil_fkProduct; } set { coil_fkProduct = value; } }

        public string ProductName { get { return coil_ProductName; } set { coil_ProductName = value; } }

        public string ProductCode { get { return coil_ProductCode; } set { coil_ProductCode = value; } }

        public int fkStatus { get { return coil_fkStatus; } set { coil_fkStatus = value; } }

        public string statusName { get { return coil_statusName; } set { coil_statusName = value; } }

        public string code { get { return coil_code; } set { coil_code = value; } }

        public int fkCuttingStop { get { return coil_fkCuttingStop; } set { coil_fkCuttingStop = value; } }

        public double length { get { return coil_length; } set { coil_length = value; } }

        public double width { get { return coil_width; } set { coil_width = value; } }

        public double diameter { get { return coil_diameter; } set { coil_diameter = value; } }

        public double palletNetweight { get { return coil_palletnetwieght; } set { coil_palletnetwieght = value; } }

        public double palletGrossweight { get { return coil_palletgrossweight; } set { coil_palletgrossweight = value; } }

        public double density { get { return coil_density; } set { coil_density = value; } }

        public int cuttingPosition { get { return coil_cuttingPosition; } set { coil_cuttingPosition = value; } }

        public int cuttingStop { get { return coil_cuttingStop; } set { coil_cuttingStop = value; } }

        public double netWeight { get { return coil_netWeight; } set { coil_netWeight = value; } }

        public double grossWeight { get { return coil_grossWeight; } set { coil_grossWeight = value; } }

        public string treatmentSide { get { return coil_treatmentSide; } set { coil_treatmentSide = value; } }

        public string defects { get { return coil_defects; } set { coil_defects = value; } }

        public List<bool> lstDefects { get { return coil_lstDefects; } set { coil_lstDefects = value; } }

        public string notes { get { return coil_notes; } set { coil_notes = value; } }

        public DateTime cuttingDate { get { return coil_cuttingDate; } set { coil_cuttingDate = value; } }

        public DateTime createdDate { get { return coil_createdDate; } set { coil_createdDate = value; } }

        public DateTime modifiedDate { get { return coil_modifiedDate; } set { coil_modifiedDate = value; } }

        public int createdBy { get { return coil_createdBy; } set { coil_createdBy = value; } }

        public string creatorUser { get { return coil_creatorUser; } set { coil_creatorUser = value; } }

        public int modifiedBy { get { return coil_modifiedBy; } set { coil_modifiedBy = value; } }

        public string modificatorUser { get { return coil_modificatorUser; } set { coil_modificatorUser = value; } }

        public clsCoilCellar coilCellarContainer { get { return coil_CoilCellarContainer; } set { coil_CoilCellarContainer = value; } }

        public clsCoilCellar Coil_CoilCellarContainer { get { return coil_CoilCellarContainer; } set { coil_CoilCellarContainer = value; } }

        public int fkEntity { get { return coil_fkEntity; } set { coil_fkEntity = value; } }

        public string customerName { get { return coil_customerName; } set { coil_customerName = value; } }

        public string salesOrderNumber { get { return coil_salesOrderNumber; } set { coil_salesOrderNumber = value; } }

        public int fkSalesOrder { get { return coil_fkSalesOrder; } set { coil_fkSalesOrder = value; } }

        public int fkSalesOrderDetail { get { return coil_fkSalesOrderDetail; } set { coil_fkSalesOrderDetail = value; } }

        public int fkPallet { get { return coil_fkPallet; } set { coil_fkPallet = value; } }

        public string palletCode { get { return coil_palletCode; } set { coil_palletCode = value; } }

        public bool wasAuthorized { get { return coil_wasAuthorized; } set { coil_wasAuthorized = value; } }

        public bool wasRewined { get { return coil_wasRewined; } set { coil_wasRewined = value; } }

        public bool wasCutted { get { return coil_wasCutted; } set { coil_wasCutted = value; } }

        public bool wasMilled { get { return coil_wasMilled; } set { coil_wasMilled = value; } }

        public bool isExternalCoil { get { return coil_isExternalCoil; } set { coil_isExternalCoil = value; } }

        public string lotNumber { get { return coil_lotNumber; } set { coil_lotNumber = value; } }

        public string mainCoilCode { get { return coil_mainCoilCode; } set { coil_mainCoilCode = value; } }

        public string supervisorName { get { return coil_supervisorName; } set { coil_supervisorName = value; } }

        public string supervisorInitials { get { return coil_supervisorInitials; } set { coil_supervisorInitials = value; } }

        public string digitizerName { get { return coil_digitizerName; } set { coil_digitizerName = value; } }

        public string digitizerInitials { get { return coil_digitizerInitials; } set { coil_digitizerInitials = value; } }

        public string operatorName { get { return coil_operatorName; } set { coil_operatorName = value; } }

        public string operatorInitials { get { return coil_operatorInitials; } set { coil_operatorInitials = value; } }

        public bool externalLabelPrint { get { return coil_externalLabelPrint; } set { coil_externalLabelPrint = value; } }

        public DateTime extrusionDate { get { return coil_extrusionDate; } set { coil_extrusionDate = value; } }

        public int fkCoilCellar { get { return coil_fkCoilCellar; } set { coil_fkCoilCellar = value; } }

        public string CellarCoil { get { return coil_cellar; } set { coil_cellar = value; } }

        public int core { get { return coil_core; } set { coil_core = value; } }

        public string diameteres { get { return coil_diameters; } set { coil_diameters = value; } }

        public string origin { get { return coil_origin; } set { coil_origin = value; } }

        public int procedence { get { return coil_fkProcedenceCountry; } set { coil_fkProcedenceCountry = value; } }

        public int cellar { get { return coil_fkCoilcellar; } set { coil_fkCoilcellar = value; } }

        //Constructor

        public clsCoil()
        {
            coil_codsec = 0;
            coil_fkCuttingQuality = 0;
            coil_CuttingQualityName = "";
            coil_fkBalance = 0;
            coil_BalanceName = "";
            coil_fkBopp = 0;
            coil_fkCast = 0;
            coil_fkProduct = 0;
            coil_ProductName = "";
            coil_ProductCode = "";
            coil_fkCuttingStop = 0;
            coil_fkStatus = 0;
            coil_statusName = "";
            coil_code = "";
            coil_length = 0;
            coil_width = 0;
            coil_diameter = 0;
            coil_density = 0;
            coil_cuttingPosition = 0;
            coil_cuttingStop = 0;
            coil_netWeight = 0;
            coil_grossWeight = 0;
            coil_treatmentSide = "";
            coil_defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
            coil_lstDefects = new List<bool>();
            for (int i = 0; i < 16; i++)
            {
                lstDefects.Add(false);
            }
            coil_notes = "";
            coil_cuttingDate = DateTime.Now;
            coil_createdDate = DateTime.Now;
            coil_modifiedDate = DateTime.Now;
            coil_createdBy = 0;
            coil_creatorUser = "";
            coil_modifiedBy = 0;
            coil_modificatorUser = "";
            coil_CoilCellarContainer = new clsCoilCellar();
            coil_fkEntity = 0;
            coil_customerName = "";
            coil_salesOrderNumber = "";
            coil_fkSalesOrder = 0;
            coil_fkSalesOrderDetail = 0;
            coil_fkPallet = 0;
            coil_palletCode = "";
            coil_wasAuthorized = false;
            coil_wasCutted = false;
            coil_wasMilled = false;
            coil_wasRewined = false;
            coil_isExternalCoil = false;
            coil_lotNumber = "";
            coil_mainCoilCode = "";
            coil_lotNumber = "";
            coil_mainCoilCode = "";
            coil_supervisorName = "";
            coil_supervisorInitials = "";
            coil_operatorName = "";
            coil_operatorInitials = "";
            coil_externalLabelPrint = false;
            coil_extrusionDate = DateTime.Now;
            coil_fkCoilCellar = 0;
            coil_cellar = string.Empty;
            coil_fkProcedenceCountry = 0;
            coil_fkCoilcellar = 0;
        }

        public clsCoil(int coilCodsec)
        {
            this.load(coilCodsec);
        }

        //Methods

        public void load(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByCodsec(" + coilCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
                fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingQuality"]);
                CuttingQualityName = DS.Tables[0].Rows[0]["coil_CuttingQualityName"].ToString();
                fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkBalance"]);
                BalanceName = DS.Tables[0].Rows[0]["coil_BalanceName"].ToString();
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProduct"]);
                ProductName = DS.Tables[0].Rows[0]["coil_ProductName"].ToString();
                ProductCode = DS.Tables[0].Rows[0]["coil_ProductCode"].ToString();
                fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingStop"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["coil_statusName"].ToString();
                code = DS.Tables[0].Rows[0]["coil_code"].ToString();
                length = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_length"]);
                width = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_width"]);
                diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_diameter"]);
                density = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_density"]);
                cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingPosition"]);
                cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingStop"]);
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_netWeight"]);
                grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_grossWeight"]);
                treatmentSide = DS.Tables[0].Rows[0]["coil_treatmentSide"].ToString();
                defects = DS.Tables[0].Rows[0]["coil_defects"].ToString();
                lstDefects = clsGlobal.getBooleanListFromString(defects);
                notes = DS.Tables[0].Rows[0]["coil_notes"].ToString();
                cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_cuttingDate"]);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["coil_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["coil_modificatorUser"].ToString();
                fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkEntity"]);
                coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]));
                customerName = DS.Tables[0].Rows[0]["coil_customerName"].ToString();
                salesOrderNumber = DS.Tables[0].Rows[0]["coil_salesOrderNumber"].ToString();
                fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkSalesOrder"]);
                fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkSalesOrderDetail"]);
                fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkPallet"]);
                palletCode = DS.Tables[0].Rows[0]["coil_palletCode"].ToString();
                wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasAuthorized"], DS.Tables[0].Rows[0]["coil_wasAuthorized"].GetType().FullName);
                wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasCutted"], DS.Tables[0].Rows[0]["coil_wasCutted"].GetType().FullName);
                wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasMilled"], DS.Tables[0].Rows[0]["coil_wasMilled"].GetType().FullName);
                wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasRewined"], DS.Tables[0].Rows[0]["coil_wasRewined"].GetType().FullName);
                isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_isExternalCoil"], DS.Tables[0].Rows[0]["coil_isExternalCoil"].GetType().FullName);
                lotNumber = DS.Tables[0].Rows[0]["coil_lotNumber"].ToString();
                mainCoilCode = DS.Tables[0].Rows[0]["coil_mainCoilCode"].ToString();
                externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_externalLabelPrint"], DS.Tables[0].Rows[0]["coil_externalLabelPrint"].GetType().FullName);
                extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_extrusionDate"]);
                procedence = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProcedenceCountry"]);
                cellar = Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]);

                string strSupervisorName;
                string strSupervisorInitials;
                string strDigitizerName;
                string strDigitizerInitials;
                string strOperatorName;
                string strOperatorInitials;

                clsCoil.getSupervisorDigitizerAndOperator(out strSupervisorName, out strSupervisorInitials, out strDigitizerName, out strDigitizerInitials, out strOperatorName, out strOperatorInitials, codsec, creatorUser);

                supervisorName = strSupervisorName;
                supervisorInitials = strSupervisorInitials;
                digitizerName = strDigitizerName;
                digitizerInitials = strDigitizerInitials;
                operatorName = strOperatorName;
                operatorInitials = strOperatorInitials;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void loadSimplified(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByCodsec(" + coilCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
                fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingQuality"]);
                CuttingQualityName = DS.Tables[0].Rows[0]["coil_CuttingQualityName"].ToString();
                fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkBalance"]);
                BalanceName = DS.Tables[0].Rows[0]["coil_BalanceName"].ToString();
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProduct"]);
                ProductName = DS.Tables[0].Rows[0]["coil_ProductName"].ToString();
                ProductCode = DS.Tables[0].Rows[0]["coil_ProductCode"].ToString();
                fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingStop"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["coil_statusName"].ToString();
                code = DS.Tables[0].Rows[0]["coil_code"].ToString();
                length = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_length"]);
                width = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_width"]);
                diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_diameter"]);
                density = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_density"]);
                cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingPosition"]);
                cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingStop"]);
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_netWeight"]);
                grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_grossWeight"]);
                treatmentSide = DS.Tables[0].Rows[0]["coil_treatmentSide"].ToString();
                defects = DS.Tables[0].Rows[0]["coil_defects"].ToString();
                lstDefects = clsGlobal.getBooleanListFromString(defects);
                notes = DS.Tables[0].Rows[0]["coil_notes"].ToString();
                cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_cuttingDate"]);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["coil_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["coil_modificatorUser"].ToString();
                fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkEntity"]);
                coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]));
                customerName = DS.Tables[0].Rows[0]["coil_customerName"].ToString();
                salesOrderNumber = DS.Tables[0].Rows[0]["coil_salesOrderNumber"].ToString();
                fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkSalesOrder"]);
                fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkSalesOrderDetail"]);
                fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkPallet"]);
                palletCode = DS.Tables[0].Rows[0]["coil_palletCode"].ToString();
                wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasAuthorized"], DS.Tables[0].Rows[0]["coil_wasAuthorized"].GetType().FullName);
                wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasCutted"], DS.Tables[0].Rows[0]["coil_wasCutted"].GetType().FullName);
                wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasMilled"], DS.Tables[0].Rows[0]["coil_wasMilled"].GetType().FullName);
                wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasRewined"], DS.Tables[0].Rows[0]["coil_wasRewined"].GetType().FullName);
                isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_isExternalCoil"], DS.Tables[0].Rows[0]["coil_isExternalCoil"].GetType().FullName);
                lotNumber = DS.Tables[0].Rows[0]["coil_lotNumber"].ToString();
                mainCoilCode = DS.Tables[0].Rows[0]["coil_mainCoilCode"].ToString();
                externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_externalLabelPrint"], DS.Tables[0].Rows[0]["coil_externalLabelPrint"].GetType().FullName);
                extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_extrusionDate"]);
                procedence = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProcedenceCountry"]);
                cellar = Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]);

                //clsCoil.getSupervisorDigitizerAndOperator(out strSupervisorName, out strSupervisorInitials, out strDigitizerName, out strDigitizerInitials, out strOperatorName, out strOperatorInitials, codsec, creatorUser);

                //supervisorName = strSupervisorName;
                //supervisorInitials = strSupervisorInitials;
                //digitizerName = strDigitizerName;
                //digitizerInitials = strDigitizerInitials;
                //operatorName = strOperatorName;
                //operatorInitials = strOperatorInitials;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public bool save()
        {
            return this.save(0, 0, 0, 0);
        }
        public bool save(int coilCellarCodsec)
        {
            return this.save(0, 0, coilCellarCodsec, 0);
        }
        public bool save(int cuttingStopCodsec, int salesOrderDetailCodsec, int coilCellarCodsec, int cuttingOrderDetailCodsec)
        {
            bool flgIsNew = false;
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Activa");

                    queryString += "INSERT INTO bps_prod_coil (coil_fkCuttingQuality, coil_fkBalance, coil_fkProduct, coil_fkStatus, coil_code, coil_length, coil_width, coil_diameter, coil_density, coil_cuttingPosition, coil_cuttingStop, coil_netWeight, coil_grossWeight, coil_treatmentSide, coil_defects, coil_notes, coil_cuttingDate, coil_createdDate, coil_modifiedDate, coil_createdBy, coil_modifiedBy,coil_wasRewined , coil_isExternalCoil, coil_lotNumber, coil_mainCoilCode, coil_externalLabelPrint, coil_extrusionDate, coil_fkProcedenceCountry, coil_fkCoilcellar) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkCuttingQuality.ToString() + ", ";
                    queryString += "" + this.fkBalance.ToString() + ", ";
                    queryString += "" + this.fkProduct.ToString() + ", ";
                    queryString += "" + objStatus.codsec.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "" + this.length.ToString() + ", ";
                    queryString += "" + this.width.ToString() + ", ";
                    queryString += "" + this.diameter.ToString() + ", ";
                    queryString += "" + this.density.ToString() + ", ";
                    queryString += "" + this.cuttingPosition.ToString() + ", ";
                    queryString += "" + this.cuttingStop.ToString() + ", ";
                    queryString += "" + this.netWeight.ToString() + ", ";
                    queryString += "" + this.grossWeight.ToString() + ", ";
                    queryString += "'" + this.treatmentSide + "', ";
                    queryString += "'" + this.defects.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + this.createdBy.ToString() + ", ";
                    queryString += "" + this.modifiedBy.ToString() + ", ";
                    queryString += "" + this.wasRewined.ToString() + ", ";
                    queryString += "" + this.isExternalCoil.ToString() + ", ";
                    queryString += "'" + this.lotNumber.ToString() + "', ";
                    queryString += "'" + this.mainCoilCode.ToString() + "', ";
                    queryString += "" + this.externalLabelPrint.ToString() + ", ";
                    queryString += "'" + this.extrusionDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += "" + this.procedence.ToString() + ", ";
                    queryString += "" + this.cellar.ToString() + " ";
                    queryString += ");";

                    flgIsNew = true;
                }
                else
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Activa");

                    queryString += "UPDATE bps_prod_coil ";
                    queryString += " SET ";
                    queryString += "coil_fkCuttingQuality = " + this.fkCuttingQuality.ToString() + ", ";
                    queryString += "coil_fkBalance = " + this.fkBalance.ToString() + ", ";
                    queryString += "coil_fkProduct = " + this.fkProduct.ToString() + ", ";
                    queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
                    queryString += "coil_code = '" + this.code.ToString() + "', ";
                    queryString += "coil_length = " + this.length.ToString() + ", ";
                    queryString += "coil_width = " + this.width.ToString() + ", ";
                    queryString += "coil_diameter = " + this.diameter.ToString() + ", ";
                    queryString += "coil_density = " + this.density.ToString() + ", ";
                    queryString += "coil_cuttingPosition = " + this.cuttingPosition.ToString() + ", ";
                    queryString += "coil_cuttingStop = " + this.cuttingStop.ToString() + ", ";
                    queryString += "coil_netWeight = " + this.netWeight.ToString() + ", ";
                    queryString += "coil_grossWeight = " + this.grossWeight.ToString() + ", ";
                    queryString += "coil_treatmentSide = '" + this.treatmentSide + "', ";
                    queryString += "coil_defects = '" + this.defects + "', ";
                    queryString += "coil_notes = '" + this.notes + "', ";
                    queryString += "coil_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
                    queryString += "coil_modifiedBy = " + this.modifiedBy.ToString() + ", ";
                    queryString += "coil_lotNumber = '" + this.lotNumber.ToString() + "', ";
                    queryString += "coil_mainCoilCode = '" + this.mainCoilCode.ToString() + "', ";
                    queryString += "coil_externalLabelPrint = " + this.externalLabelPrint.ToString() + ", ";
                    queryString += "coil_extrusionDate = '" + this.extrusionDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "coil_fkProcedenceCountry = " + this.procedence.ToString() + ", ";
                    queryString += "coil_fkCoilcellar = " + this.cellar.ToString() + " ";
                    queryString += " WHERE coil_codsec = " + this.codsec.ToString() + ";";

                    flgIsNew = false;
                }

                bool test = clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                {
                    this.codsec = clsCoil.getDetailByCode(this.code).codsec;
                    clsSequential.addSequential("coil");
                }

                if (cuttingStopCodsec != 0 && flgIsNew == true)
                {

                    queryString = "INSERT INTO bps_prod_coilByCuttingStop (cbcs_fkCuttingStop, cbcs_fkCoil) ";
                    queryString += " VALUES (";
                    queryString += "" + cuttingStopCodsec.ToString() + ", ";
                    queryString += "" + this.codsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);
                }
                if (salesOrderDetailCodsec != 0 && flgIsNew == true)
                {
                    queryString = "INSERT INTO bps_prod_coilpersalesorderdetail (cpsod_fkOrderDetail, cpsod_fkCoil) ";
                    queryString += " VALUES (";
                    queryString += "" + salesOrderDetailCodsec.ToString() + ", ";
                    queryString += "" + this.codsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);
                }
                if (cuttingOrderDetailCodsec != 0 && flgIsNew == true)
                {
                    queryString = "INSERT INTO bps_prod_coilbycuttingorderdetail (cbcod_fkCuttingOrderDetail, cbcod_fkCoil) ";
                    queryString += " VALUES (";
                    queryString += "" + cuttingOrderDetailCodsec.ToString() + ", ";
                    queryString += "" + this.codsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);
                }
                if (coilCellarCodsec != 0 && flgIsNew == true)
                {
                    clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
                    objCoilByCoilCellar.fkCoil = this.codsec;
                    objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
                    objCoilByCoilCellar.In = true;
                    objCoilByCoilCellar.Out = false;
                    objCoilByCoilCellar.date = DateTime.Now;

                    objCoilByCoilCellar.save();
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

        public bool save(string SalesOrderNumber, int coilCellarCodsec)
        {
            bool flgIsNew = false;

            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(salesOrderNumber);
            int salesOrderDetailCodsec = 0;

            for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
            {
                if (this.fkProduct == objSalesOrder.lstSalesOrderDetail[i].fkProduct)
                {
                    salesOrderDetailCodsec = objSalesOrder.lstSalesOrderDetail[i].codsec;
                }
            }

            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Activa");

                    queryString += "INSERT INTO bps_prod_coil (coil_fkCuttingQuality, coil_fkBalance, coil_fkProduct, coil_fkStatus, coil_code, coil_length, coil_width, coil_diameter, coil_density, coil_cuttingPosition, coil_cuttingStop, coil_netWeight, coil_grossWeight, coil_treatmentSide, coil_defects, coil_notes, coil_cuttingDate, coil_createdDate, coil_modifiedDate, coil_createdBy, coil_modifiedBy, coil_isExternalCoil, coil_lotNumber, coil_mainCoilCode, coil_externalLabelPrint, coil_extrusionDate, coil_fkProcedenceCountry, coil_fkCoilcellar)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkCuttingQuality.ToString() + ", ";
                    queryString += "" + this.fkBalance.ToString() + ", ";
                    queryString += "" + this.fkProduct.ToString() + ", ";
                    queryString += "" + objStatus.codsec.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "" + this.length.ToString() + ", ";
                    queryString += "" + this.width.ToString() + ", ";
                    queryString += "" + this.diameter.ToString() + ", ";
                    queryString += "" + this.density.ToString() + ", ";
                    queryString += "" + this.cuttingPosition.ToString() + ", ";
                    queryString += "" + this.cuttingStop.ToString() + ", ";
                    queryString += "" + this.netWeight.ToString() + ", ";
                    queryString += "" + this.grossWeight.ToString() + ", ";
                    queryString += "'" + this.treatmentSide + "', ";
                    queryString += "'" + this.defects.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + this.createdBy.ToString() + ", ";
                    queryString += "" + this.modifiedBy.ToString() + ", ";
                    queryString += "" + this.isExternalCoil.ToString() + ", ";
                    queryString += "'" + this.lotNumber.ToString() + "', ";
                    queryString += "'" + this.mainCoilCode.ToString() + "', ";
                    queryString += "" + this.externalLabelPrint.ToString() + ", ";
                    queryString += "'" + this.extrusionDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "" + this.procedence.ToString() + ", ";
                    queryString += "" + this.cellar.ToString() + " ";
                    queryString += ");";

                    flgIsNew = true;
                }
                else
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Activa");

                    queryString += "UPDATE bps_prod_coil ";
                    queryString += " SET ";
                    queryString += "coil_fkCuttingQuality = " + this.fkCuttingQuality.ToString() + ", ";
                    queryString += "coil_fkBalance = " + this.fkBalance.ToString() + ", ";
                    queryString += "coil_fkProduct = " + this.fkProduct.ToString() + ", ";
                    queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
                    queryString += "coil_code = '" + this.code.ToString() + "', ";
                    queryString += "coil_length = " + this.length.ToString() + ", ";
                    queryString += "coil_width = " + this.width.ToString() + ", ";
                    queryString += "coil_diameter = " + this.diameter.ToString() + ", ";
                    queryString += "coil_density = " + this.density.ToString() + ", ";
                    queryString += "coil_cuttingPosition = " + this.cuttingPosition.ToString() + ", ";
                    queryString += "coil_cuttingStop = " + this.cuttingStop.ToString() + ", ";
                    queryString += "coil_netWeight = " + this.netWeight.ToString() + ", ";
                    queryString += "coil_grossWeight = " + this.grossWeight.ToString() + ", ";
                    queryString += "coil_treatmentSide = '" + this.treatmentSide + "', ";
                    queryString += "coil_defects = '" + this.defects + "', ";
                    queryString += "coil_notes = '" + this.notes + "', ";
                    queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "coil_modifiedBy = " + this.modifiedBy.ToString() + ", ";
                    queryString += "coil_lotNumber = '" + this.lotNumber.ToString() + "', ";
                    queryString += "coil_mainCoilCode = '" + this.mainCoilCode.ToString() + "', ";
                    queryString += "coil_externalLabelPrint = " + this.externalLabelPrint.ToString() + ", ";
                    queryString += "coil_extrusionDate = '" + this.extrusionDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "coil_fkProcedenceCountry = " + this.procedence.ToString() + ", ";
                    queryString += "coil_fkCoilcellar = " + this.cellar.ToString() + " ";
                    queryString += " WHERE coil_codsec = " + this.codsec.ToString() + ";";

                    flgIsNew = false;
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                {
                    this.codsec = clsCoil.getDetailByCode(this.code).codsec;
                    clsSequential.addSequential("coil");
                }
                if (salesOrderDetailCodsec != 0 && flgIsNew == true)
                {
                    queryString = "INSERT INTO bps_prod_coilpersalesorderdetail (cpsod_fkOrderDetail, cpsod_fkCoil) ";
                    queryString += " VALUES (";
                    queryString += "" + salesOrderDetailCodsec.ToString() + ", ";
                    queryString += "" + this.codsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);
                }
                if (coilCellarCodsec != 0 && flgIsNew == true)
                {
                    clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
                    objCoilByCoilCellar.fkCoil = this.codsec;
                    objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
                    objCoilByCoilCellar.In = true;
                    objCoilByCoilCellar.Out = false;
                    objCoilByCoilCellar.date = DateTime.Now;

                    objCoilByCoilCellar.save();
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

        public bool toupdate()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_isExternalCoil = " + this.isExternalCoil + " ";
                queryString += " WHERE coil_codsec = " + this.codsec.ToString() + ";";

                clsConnection.executeQuery(queryString);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

        public bool toChangeStatus(int Status)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkStatus = " + Status.ToString() + ", ";
                queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
                queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += " WHERE coil_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

        public static clsCoil getDetailByCode(string coilCode)
        {
            clsCoil objCoil = new clsCoil();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCoilByCode '" + coilCode + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCoil.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
                objCoil.fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingQuality"]);
                objCoil.CuttingQualityName = DS.Tables[0].Rows[0]["coil_CuttingQualityName"].ToString();
                objCoil.fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkBalance"]);
                objCoil.BalanceName = DS.Tables[0].Rows[0]["coil_BalanceName"].ToString();
                objCoil.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProduct"]);
                objCoil.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkBopp"]);
                objCoil.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCast"]);
                objCoil.ProductName = DS.Tables[0].Rows[0]["coil_ProductName"].ToString();
                objCoil.ProductCode = DS.Tables[0].Rows[0]["coil_ProductCode"].ToString();
                objCoil.fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingStop"]);
                objCoil.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkStatus"]);
                objCoil.statusName = DS.Tables[0].Rows[0]["coil_statusName"].ToString();
                objCoil.code = DS.Tables[0].Rows[0]["coil_code"].ToString();
                objCoil.length = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_length"]);
                objCoil.width = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_width"]);
                objCoil.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_diameter"]);
                objCoil.density = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_density"]);
                objCoil.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingPosition"]);
                objCoil.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingStop"]);
                objCoil.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_netWeight"]);
                objCoil.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_grossWeight"]);
                objCoil.treatmentSide = DS.Tables[0].Rows[0]["coil_treatmentSide"].ToString();
                objCoil.defects = DS.Tables[0].Rows[0]["coil_defects"].ToString();
                objCoil.lstDefects = clsGlobal.getBooleanListFromString(objCoil.defects);
                objCoil.notes = DS.Tables[0].Rows[0]["coil_notes"].ToString();
                objCoil.cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_cuttingDate"]);
                objCoil.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_createdDate"]);
                objCoil.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_modifiedDate"]);
                objCoil.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_createdBy"]);
                objCoil.creatorUser = DS.Tables[0].Rows[0]["coil_creatorUser"].ToString();
                objCoil.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_modifiedBy"]);
                objCoil.modificatorUser = DS.Tables[0].Rows[0]["coil_modificatorUser"].ToString();
                objCoil.coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]));
                objCoil.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkEntity"]);
                objCoil.customerName = DS.Tables[0].Rows[0]["coil_customerName"].ToString();
                objCoil.salesOrderNumber = DS.Tables[0].Rows[0]["coil_salesOrderNumber"].ToString();
                objCoil.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkSalesOrder"]);
                objCoil.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkPallet"]);
                objCoil.palletCode = DS.Tables[0].Rows[0]["coil_palletCode"].ToString();
                objCoil.wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasAuthorized"], DS.Tables[0].Rows[0]["coil_wasAuthorized"].GetType().FullName);
                objCoil.wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasCutted"], DS.Tables[0].Rows[0]["coil_wasCutted"].GetType().FullName);
                objCoil.wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasMilled"], DS.Tables[0].Rows[0]["coil_wasMilled"].GetType().FullName);
                objCoil.wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_wasRewined"], DS.Tables[0].Rows[0]["coil_wasRewined"].GetType().FullName);
                objCoil.isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_isExternalCoil"], DS.Tables[0].Rows[0]["coil_isExternalCoil"].GetType().FullName);
                objCoil.lotNumber = DS.Tables[0].Rows[0]["coil_lotNumber"].ToString();
                objCoil.mainCoilCode = DS.Tables[0].Rows[0]["coil_mainCoilCode"].ToString();
                objCoil.externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_externalLabelPrint"], DS.Tables[0].Rows[0]["coil_externalLabelPrint"].GetType().FullName);
                objCoil.extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_extrusionDate"]);
                objCoil.diameteres = DS.Tables[0].Rows[0]["dtr_abbreviation"].ToString();
                objCoil.core = Convert.ToInt32(DS.Tables[0].Rows[0]["core_value"]);
                objCoil.origin = (objCoil.isExternalCoil == false) ? "BOPP" : "OPP";
                objCoil.isBlock = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["coil_isblock"], DS.Tables[0].Rows[0]["coil_isblock"].GetType().FullName);
                objCoil.procedence = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProcedenceCountry"]);
                objCoil.cellar = Convert.ToInt32(DS.Tables[0].Rows[0]["fkCoilcellar"]);


                string strSupervisorName;
                string strSupervisorInitials;
                string strDigitizerName;
                string strDigitizerInitials;
                string strOperatorName;
                string strOperatorInitials;

                clsCoil.getSupervisorDigitizerAndOperator(out strSupervisorName, out strSupervisorInitials, out strDigitizerName, out strDigitizerInitials, out strOperatorName, out strOperatorInitials, objCoil.codsec, objCoil.creatorUser);

                objCoil.supervisorName = strSupervisorName;
                objCoil.supervisorInitials = strSupervisorInitials;
                objCoil.digitizerName = strDigitizerName;
                objCoil.digitizerInitials = strDigitizerInitials;
                objCoil.operatorName = strOperatorName;
                objCoil.operatorInitials = strOperatorInitials;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objCoil;
        }
        public static clsSalesOrderDetail getSalesOrderDetailByCoil(int coilCodsec)
        {
            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + coilCodsec);

            if (DS.Tables[0].Rows.Count > 0)
            {
                objSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(DS.Tables[0].Rows[0]["cpsod_fkOrderDetail"]));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objSalesOrderDetail;
        }
        public static clsCuttingStop getCuttingStopByCoil(int coilCodsec)
        {
            clsCuttingStop objCuttingStop = new clsCuttingStop();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbycuttingstop WHERE cbcs_fkCoil = " + coilCodsec);

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCuttingStop = new clsCuttingStop(Convert.ToInt32(DS.Tables[0].Rows[0]["cbcs_fkCuttingStop"]));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objCuttingStop;
        }
        public static clsCoilCellar getContainerCellarByCoil(int coilCodsec)
        {
            clsCoilCellar objCoilCellar = new clsCoilCellar();
            /*int lastCellarIn = 0;
            int lastInCodsec = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cbcc_codsec, cbcc_fkCoilCellar FROM bps_prod_coilbycoilcellar WHERE cbcc_fkCoil = " + coilCodsec + " and cbcc_in = True ORDER BY cbcc_codsec DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                lastCellarIn = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_fkCoilCellar"]);
                lastInCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_codsec"]);
            }
            DS = clsConnection.getDataSetResult("SELECT cbcc_codsec FROM bps_prod_coilbycoilcellar WHERE cbcc_fkCoil = " + coilCodsec + " and cbcc_out = True ORDER BY cbcc_codsec DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                if (lastInCodsec > Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_codsec"]))
                    objCoilCellar = new clsCoilCellar(lastCellarIn);
                else
                    objCoilCellar = new clsCoilCellar();
            }
            else
            {
                objCoilCellar = new clsCoilCellar(lastCellarIn);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();*/
            clsCoil objcoil = new clsCoil(coilCodsec);
            objCoilCellar = new clsCoilCellar(objcoil.cellar);
            return objCoilCellar;
        }
        public static List<clsCoil> getCoilList()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoil ");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getObservationCoilList()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spObservationCoil();");

            try
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstCoil.Add(new clsCoil());
                        lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                        lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                        lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                        lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                        lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                        lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                        lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                        lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                        lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                        lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                        lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                        lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                        lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                        lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                        lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                        lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                        lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                        lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                        lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                        lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                        lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                        lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                        lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                        lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                        lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                        lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                        lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                        lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                        lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                        lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                        lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                        lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                        lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                        lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                        lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                        lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                        lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                        lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                        lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                        lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                        lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                        lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                        lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                        lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                        lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                        lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                        lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                        lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                        lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getObservationCoilList(bool report)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spObservationCoilByReport();");

            try
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {

                        lstCoil.Add(new clsCoil());
                        lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                        lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                        lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                        lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                        lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                        lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                        lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                        lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                        lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                        lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                        lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                        lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                        lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                        lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                        lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                        lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                        lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                        lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                        lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                        lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                        lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                        lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                        lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                        lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                        lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                        lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                        lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                        lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                        lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                        lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                        lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                        lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                        lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                        lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                        lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                        lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                        lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                        lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                        lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                        lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                        lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                        lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                        lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                        lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                        lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                        lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                        lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                        lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                        lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getCoilListByCuttingStop(int cuttingStopCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByCuttingStop(" + cuttingStopCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getCoilListBySalesOrderDetail(int salesOrderDetailCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilsBySalesOrderDetail(" + salesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getStockCoils()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockCoils()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getStockCoilsByProduct(int productCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockCoilsByProduct(" + productCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getCoilOutOfPalletsListByCoilCellar(int coilCellarCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoil WHERE fkCoilcellar = " + coilCellarCodsec.ToString() + " and coil_fkPallet = 0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getCoilOutOfPalletsListByCoilCellarAndFilters(int coilCellarCodsec, List<clsFilter> lstFilter)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoil WHERE fkCoilcellar = " + coilCellarCodsec.ToString() + " AND  coil_fkPallet = 0 " + where);

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getCoilListByCoilCellar(int coilCellarCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoil WHERE fkCoilcellar = " + coilCellarCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getCoilListByPallet(int palletCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByPallet( " + palletCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getSimpleCoilListByPallet(int palletCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByPallet( " + palletCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getCoilListShortByPalletShippingNational(int palletCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByPallet( " + palletCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCoilCellar"]);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return lstCoil;
        }

        public static List<clsCoil> getCoilListByPalletShortNationalShipping(int palletCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByPallet( " + palletCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getSimplifiedCoilListByPallet(int palletCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilByPallet( " + palletCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getListByTransfer(int transferCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoil, bps_prod_palletCoilTransferDetail WHERE pctd_fkCoil = coil_codsec AND pctd_fkPalletCoilTransfer = " + transferCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }


        //lista de bobinas bopp, q no hayan sido reprocesadas..

        public static List<clsCoil> getListByBoppCodsec(int boppCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilbopp WHERE `coil_fkBopp` =  " + boppCodsec.ToString() + " and coil_fkStatus = 33");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBopp"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        //fin 

        //Lista bobinas del mismo producto bopp que no sean reprocesadas

        public static List<clsCoil> getListByBoppProductCodsec(int productCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilbopp WHERE `coil_fkProduct` =  " + productCodsec.ToString() + " and coil_fkStatus = 33");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBopp"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        //fin

        //Lista bobinas del mismo producto cast que no sean reprocesadas

        public static List<clsCoil> getListByCastProductCodsec(int productCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilcast WHERE `coil_fkProduct` =  " + productCodsec.ToString() + " and coil_fkStatus = 33");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCast"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        //fin




        //lista de bobinas cast, q no hayan sido reprocesadas..

        public static List<clsCoil> getListByCastCodsec(int castCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilcast WHERE `coil_fkCast` =  " + castCodsec.ToString() + " and coil_fkStatus = 33");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCast"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        //fin 

        public static List<clsCoil> getListByBoppCodsecAndCode(int boppCodsec, string BoppCoilCode)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilbopp WHERE `coil_fkBopp` =  " + boppCodsec.ToString() + " and `coil_fkStatus` = 33 and `coil_code` LIKE '%" + BoppCoilCode.ToString() + "%';");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBopp"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        //

        public static List<clsCoil> getListByCastCodsecAndCode(int castCodsec, string castCoilCode)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilcast WHERE `coil_fkCast` =  " + castCodsec.ToString() + " and `coil_fkStatus` = 33 and `coil_code` LIKE '%" + castCoilCode.ToString() + "%';");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCast"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        //funcion que trae las bobinas metalizadas por orden de metalizado de bopp
        public static List<clsCoil> getListByMetalizedOrder(int metalizedOrder)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spGetListByMetalizedOrder " + metalizedOrder.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBopp"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }


        //


        //funcion que trae las bobinas metalizadas por orden de metalizado de cast
        public static List<clsCoil> getListByCastMetalizedOrder(int metalizedOrder)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoilcast, `bps_prod_coilbycoilcellar`, `bps_prod_coilbycoil` WHERE `vwcoilcast`.`coil_codsec` = `bps_prod_coilbycoil`.`cbc_fkDestinationCoil` AND `bps_prod_coilbycoil`.`cbc_fkDestinationCoil` = `bps_prod_coilbycoilcellar`.`cbcc_fkCoil` AND `bps_prod_coilbycoilcellar`.`cbcc_fkCoilCellar` = 5 AND `vwcoilcast`.`coil_fkStatus` = 33 AND `bps_prod_coilbycoil`.`cbc_fkMetallizedOrder` =  " + metalizedOrder.ToString() + " group by coil_codsec;");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCast"]);
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        public static List<clsCoil> getCoilListByChangeOrder(int changeSalesOrderCodsec)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCoilListByChangeOrder(" + changeSalesOrderCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].coilCellarContainer = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]));
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spGetLasCoilCodsec();");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
        }


        //para esta funcion el metalizado en bps_prod_family.codsec = 6
        public static int getLastMetalizedCoilSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT coil_codsec FROM vwLastSaveMetalizedCoil ORDER BY coil_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
        }


        //para esta funcion el metalizado en bps_prod_procces.codsec = 4
        public static int getLastCastMetalizedCoilSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT coil_codsec FROM vwLastCastSaveMetalizedCoil ORDER BY coil_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
        }

        public static bool IsInPallet(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cbp_codsec FROM bps_prod_coilByPallet WHERE cbp_fkCoil = " + coilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static int getContainerPalletCodsecByCoil(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cbp_fkPallet FROM bps_prod_coilByPallet WHERE cbp_fkCoil = " + coilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["cbp_fkPallet"]);
            else
                return 0;
        }
        public static void transferCoilTo(int coilCodsec, int coilCellarCodsec)
        {
            try
            {
                clsCoil objCoil = new clsCoil(coilCodsec);

                clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
                objCoilByCoilCellar.fkCoil = objCoil.codsec;
                objCoilByCoilCellar.fkCoilCellar = objCoil.coilCellarContainer.codsec;
                objCoilByCoilCellar.In = false;
                objCoilByCoilCellar.Out = true;
                objCoilByCoilCellar.date = DateTime.Now;

                objCoilByCoilCellar.save();

                objCoilByCoilCellar.fkCoil = objCoil.codsec;
                objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
                objCoilByCoilCellar.In = true;
                objCoilByCoilCellar.Out = false;
                objCoilByCoilCellar.date = DateTime.Now;

                objCoilByCoilCellar.save();

                string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkCoilcellar = " + coilCellarCodsec.ToString() + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");

            }

            
        }
        public static void transferCoilTo(clsCoil objCoil, int coilCellarCodsec)
        {

            try
            {
                clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
                objCoilByCoilCellar.fkCoil = objCoil.codsec;
                objCoilByCoilCellar.fkCoilCellar = objCoil.coilCellarContainer.codsec;
                objCoilByCoilCellar.In = false;
                objCoilByCoilCellar.Out = true;
                objCoilByCoilCellar.date = DateTime.Now;

                objCoilByCoilCellar.save();

                objCoilByCoilCellar.fkCoil = objCoil.codsec;
                objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
                objCoilByCoilCellar.In = true;
                objCoilByCoilCellar.Out = false;
                objCoilByCoilCellar.date = DateTime.Now;

                objCoilByCoilCellar.save();

                string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkCoilcellar = " + coilCellarCodsec.ToString() + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");

            }
        }
        public static void waitingTransferCoilTo(int coilCodsec, int coilCellarCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();

            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
            objCoilByCoilCellar.In = false;
            objCoilByCoilCellar.Out = true;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();

        }
        public static void executeTransferTo(int coilCodsec, int coilCellarCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();

            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
            objCoilByCoilCellar.In = true;
            objCoilByCoilCellar.Out = false;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();
        }
        public static void cancelTransferTo(int coilCodsec, int coilCellarCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();

            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
            objCoilByCoilCellar.In = true;
            objCoilByCoilCellar.Out = false;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();
        }
        public static void removeCoilFromCellar(int coilCodsec, int coilCellarCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();

            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = coilCellarCodsec;
            objCoilByCoilCellar.In = false;
            objCoilByCoilCellar.Out = true;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();

        }
        public static double getCoilDensity(double weigth, double externalDiameter, clsCore objCore, double width)
        {
            double density = 0;

            double internalDiameter;

            if (objCore.value == 3)
                internalDiameter = 9.5;
            else
                internalDiameter = 16.5;


            density = (weigth * 1000) / ((Math.PI / 4) * (Math.Pow(externalDiameter, 2) - Math.Pow(internalDiameter, 2)) * (width / 10));

            return Math.Round(density, 5);
        }
        public static void setCoilReprocess(int coilCodsec, bool wasRewined, bool wasCutted, bool wasMilled)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);

            string queryString = "";

            if (wasCutted)
            {

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_wasCutted = " + wasCutted.ToString() + ", ";
                queryString += "coil_wasMilled = " + wasMilled.ToString() + ", ";
                queryString += "coil_wasRewined = " + wasRewined.ToString() + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";
            }
            else if (wasRewined)
            {
                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_wasCutted = " + wasCutted.ToString() + ", ";
                queryString += "coil_wasMilled = " + wasMilled.ToString() + ", ";
                queryString += "coil_wasRewined = " + wasRewined.ToString() + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";
            }
            else
            {
                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkStatus = 35 ,";
                queryString += "coil_wasCutted = " + wasCutted.ToString() + ", ";
                queryString += "coil_wasMilled = " + wasMilled.ToString() + ", ";
                queryString += "coil_wasRewined = " + wasRewined.ToString() + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";
            }

            clsConnection.executeQuery(queryString);
        }
        public static void dropCoil(int coilCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);

            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = objCoil.coilCellarContainer.codsec;
            objCoilByCoilCellar.In = false;
            objCoilByCoilCellar.Out = true;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Destruida");
            string queryString = "";

            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
            queryString += "coil_wasMilled = 1 ";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);
        }
        public static void dropCoilBySalesOrderForReDelivery(int coilCodsec)
        {
            string queryString = "";
            queryString += "DELETE bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + coilCodsec.ToString();
            clsConnection.executeQuery(queryString);
        }
        public static void setCoilAsReprocesed(int coilCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);

            /*clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = objCoil.coilCellarContainer.codsec;
            objCoilByCoilCellar.In = false;
            objCoilByCoilCellar.Out = true;
            objCoilByCoilCellar.date = DateTime.Now;

            objCoilByCoilCellar.save();*/

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Reprocesada");
            string queryString = "";

            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "coil_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
            queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
            queryString += "coil_wasCutted = True ";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);
        }

        public static void setCoilAsPreShipped(List<clsCoil> lstCoil)
        {
            //clsCoil objCoil = new clsCoil(coilCodsec);
            for (int i = 0; i < lstCoil.Count; i++)
			{
			    string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkStatus = 3072, ";
                queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
                queryString += " WHERE coil_codsec = " + lstCoil[i].codsec.ToString() + ";";

                clsConnection.executeQuery(queryString);
            }
        }

        public static void cancelPreShipping(int coilCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);

            if(objCoil.fkStatus==3072)
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_coil ";
                queryString += " SET ";
                queryString += "coil_fkStatus = 33, ";
                queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
                queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

                clsConnection.executeQuery(queryString);
            }
        }

        public static void setCoilAsReturned(clsCoil objCoil, int coilcellar)
        {
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = coilcellar;
            objCoilByCoilCellar.In = true;
            objCoilByCoilCellar.Out = false;
            objCoilByCoilCellar.date = DateTime.Now;
            objCoilByCoilCellar.save();

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Pre-Despachada");
            string queryString = "";

            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);
        }

        public static void setCoilAsDelivered(clsCoil objCoil)
        {
            clsCoilByCoilCellar objCoilByCoilCellar = new clsCoilByCoilCellar();
            objCoilByCoilCellar.fkCoil = objCoil.codsec;
            objCoilByCoilCellar.fkCoilCellar = objCoil.coilCellarContainer.codsec;
            objCoilByCoilCellar.In = false;
            objCoilByCoilCellar.Out = true;
            objCoilByCoilCellar.date = DateTime.Now;
            objCoilByCoilCellar.save();

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Despachada");
            string queryString = "";

            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);
        }

        public static void setCoilAsReDelivered(clsCoil objCoil)
        {
            string queryString = "";
            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = 33, ";
            queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "coil_modifiedBy = 68";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";
            clsConnection.executeQuery(queryString);
        }

        public static void assignToSalesOrder(int coilCodsec, int salesOrderDetailCodsec)
        {
            string queryString;

            clsConnection.executeQuery("DELETE FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + coilCodsec.ToString());

            if (salesOrderDetailCodsec > 0)
            {
                queryString = "INSERT INTO bps_prod_coilpersalesorderdetail (cpsod_fkOrderDetail, cpsod_fkCoil) ";
                queryString += " VALUES (";
                queryString += "" + salesOrderDetailCodsec.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + "); ";
                clsConnection.executeQuery(queryString);
            }
        }
        public static void getSupervisorDigitizerAndOperator(out string supervisorName, out string supervisorInitials, out string digitizerName, out string digitizerInitials, out string operatorName, out string operatorInitials, int coilCodsec, string createdBy)
        {
            clsCuttingStop objCuttingStop = clsCuttingStop.getCuttingStopByCoil(coilCodsec);

            if (objCuttingStop.codsec > 0)
            {
                supervisorName = objCuttingStop.supervisor;
                //supervisorInitials = (objCuttingStop.supervisor.)objCuttingStop.supervisor.Split(new char[] { '.' })[0].Substring(0, 1).ToUpper() + objCuttingStop.supervisor.Split(new char[] { '.' })[1].Substring(0, 1).ToUpper();
                digitizerName = objCuttingStop.digitizer;
                //digitizerInitials = objCuttingStop.digitizer.Split(new char[] { '.' })[0].Substring(0, 1).ToUpper() + objCuttingStop.digitizer.Split(new char[] { '.' })[1].Substring(0, 1).ToUpper();
                operatorName = objCuttingStop.Operator;
                //operatorInitials = objCuttingStop.Operator.Split(new char[] { '.' })[0].Substring(0, 1).ToUpper() + objCuttingStop.Operator.Split(new char[] { '.' })[1].Substring(0, 1).ToUpper();
                supervisorInitials = "";
                digitizerInitials = "";
                operatorInitials = "";
            }
            else
            {
                supervisorName = "";
                supervisorInitials = "";
                digitizerName = createdBy;
                if (createdBy.Contains("."))
                    digitizerInitials = createdBy.Split(new char[] { '.' })[0].Substring(0, 1).ToUpper() + createdBy.Split(new char[] { '.' })[1].Substring(0, 1).ToUpper();
                else
                    digitizerInitials = "MT";
                operatorName = "";
                operatorInitials = "";
            }
        }



        // RETORNA EL CODIGO DE LA ULTIMA BOBINA METALIZADA BOPP DE PROCEDENCIA OPP PERU

        public static List<clsCoil> getLastBoppExternalMetalizedCoilCode()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * FROM vwgetlastboppexternalmetalizedcoilcode");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                }
            }


            return lstCoil;
        }

        // RETORNA EL CODIGO DE LA ULTIMA BOBINA METALIZADA CAST DE PROCEDENCIA OPP PERU

        public static List<clsCoil> getLastCastExternalMetalizedCoilCode()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * FROM vwgetlastcastexternalmetalizedcoilcode");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                }
            }


            return lstCoil;
        }

        // RETORNA EL CODIGO DE LA ULTIMA BOBINA METALIZADA BOPP DE PROCEDENCIA LOCAL

        public static List<clsCoil> getLastBoppInternalMetalizedCoilCode()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * FROM vwgetlastboppinternalmetalizedcoilcode");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                }
            }


            return lstCoil;
        }

        // RETORNA EL CODIGO DE LA ULTIMA BOBINA METALIZADA CAST DE PROCEDENCIA LOCAL

        public static List<clsCoil> getLastCastInternalMetalizedCoilCode()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("Select * FROM vwgetlastcastinternalmetalizedcoilcode");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                }
            }


            return lstCoil;
        }

        public bool deleteCoilByPallet(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_coilbypallet WHERE cbp_fkPallet = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.delete");
                return false;
            }
        }

        public bool deleteCoilPerSalesOrderDetail(int Coilcodsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + Coilcodsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.delete");
                return false;
            }
        }

        public bool deleteCoilDetailByPalletDetail(int Coilcodsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_coildetailbypalletdetail WHERE cdbpd_fkCoil = " + Coilcodsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.delete");
                return false;
            }
        }

        public bool deleteCoilDrop(int Coilcodsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_coil WHERE coil_codsec = " + Coilcodsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.delete");
                return false;
            }
        }


        public static List<clsCoil> getCoilListInStock()
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCoilListInStock");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_product"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_productcode"].ToString();
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].CellarCoil = DS.Tables[0].Rows[i]["coil_cellar"].ToString();
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].palletNetweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstCoil[i].palletGrossweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].coil_fkProcedenceCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProcedenceCountry"]);
                    lstCoil[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static string getOrderByCoil(int codsec)
        {
            string result = "";
            try
            {
                DataSet DSSalesOrder = new DataSet();
                DataSet DSSalesOrderDetail = new DataSet();
                DataSet DS = new DataSet();
                DSSalesOrder = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + codsec.ToString());
                if (DSSalesOrder.Tables[0].Rows.Count > 0)
                {
                    DSSalesOrderDetail = clsConnection.getDataSetResult("SELECT * FROM bps_com_salesorderdetail WHERE sod_codsec = " + Convert.ToInt32(DSSalesOrder.Tables[0].Rows[0]["cpsod_fkOrderDetail"]));
                    if (DSSalesOrder.Tables[0].Rows.Count > 0)
                    {
                        DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_salesorder WHERE sord_codsec = " + Convert.ToInt32(DSSalesOrderDetail.Tables[0].Rows[0]["sod_fkSalesOrder"]));
                        result = DS.Tables[0].Rows[0]["sord_number"].ToString();
                    }
                    else
                        result = "----------";
                }
                else
                {
                    result = "----------";
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        public static string getCustomerByCoil(string order)
        {
            try
            {
                if (order == "----------")
                    return "STOCK";
                else
                {
                    DataSet DSSalesOrder = new DataSet();
                    DataSet DSSalesOrderDetail = new DataSet();
                    DataSet DS = new DataSet();
                    DSSalesOrder = clsConnection.getDataSetResult("SELECT * FROM bps_com_salesorder WHERE sord_number = " + order);
                    if (DSSalesOrder.Tables[0].Rows.Count > 0)
                    {
                        DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_entity WHERE entt_codsec = " + Convert.ToInt32(DSSalesOrder.Tables[0].Rows[0]["sord_fkEntity"]));
                        return DS.Tables[0].Rows[0]["entt_companyName"].ToString();
                    }
                    else
                        return "STOCK";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        public static List<clsCoil> getListByMainCoilMetal(string maincoilCode)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilQualityMetal 'CoilByMainCoilMetal','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,'" + maincoilCode.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingQuality"]);
                    lstCoil[i].CuttingQualityName = DS.Tables[0].Rows[i]["coil_CuttingQualityName"].ToString();
                    lstCoil[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkBalance"]);
                    lstCoil[i].BalanceName = DS.Tables[0].Rows[i]["coil_BalanceName"].ToString();
                    lstCoil[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkProduct"]);
                    lstCoil[i].ProductName = DS.Tables[0].Rows[i]["coil_ProductName"].ToString();
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["coil_ProductCode"].ToString();
                    lstCoil[i].fkCuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkCuttingStop"]);
                    lstCoil[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkStatus"]);
                    lstCoil[i].statusName = DS.Tables[0].Rows[i]["coil_statusName"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].length = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_length"]);
                    lstCoil[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_width"]);
                    lstCoil[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_diameter"]);
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingPosition"]);
                    lstCoil[i].cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_cuttingStop"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_grossWeight"]);
                    lstCoil[i].treatmentSide = DS.Tables[0].Rows[i]["coil_treatmentSide"].ToString();
                    lstCoil[i].defects = DS.Tables[0].Rows[i]["coil_defects"].ToString();
                    lstCoil[i].lstDefects = clsGlobal.getBooleanListFromString(lstCoil[i].defects);
                    lstCoil[i].notes = DS.Tables[0].Rows[i]["coil_notes"].ToString();
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_createdDate"]);
                    lstCoil[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_modifiedDate"]);
                    lstCoil[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_createdBy"]);
                    lstCoil[i].creatorUser = DS.Tables[0].Rows[i]["coil_creatorUser"].ToString();
                    lstCoil[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_modifiedBy"]);
                    lstCoil[i].modificatorUser = DS.Tables[0].Rows[i]["coil_modificatorUser"].ToString();
                    lstCoil[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkEntity"]);
                    lstCoil[i].customerName = DS.Tables[0].Rows[i]["coil_customerName"].ToString();
                    lstCoil[i].salesOrderNumber = DS.Tables[0].Rows[i]["coil_salesOrderNumber"].ToString();
                    lstCoil[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkSalesOrder"]);
                    lstCoil[i].fkPallet = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_fkPallet"]);
                    lstCoil[i].palletCode = DS.Tables[0].Rows[i]["coil_palletCode"].ToString();
                    lstCoil[i].wasAuthorized = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasAuthorized"], DS.Tables[0].Rows[i]["coil_wasAuthorized"].GetType().FullName);
                    lstCoil[i].wasCutted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasCutted"], DS.Tables[0].Rows[i]["coil_wasCutted"].GetType().FullName);
                    lstCoil[i].wasMilled = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasMilled"], DS.Tables[0].Rows[i]["coil_wasMilled"].GetType().FullName);
                    lstCoil[i].wasRewined = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_wasRewined"], DS.Tables[0].Rows[i]["coil_wasRewined"].GetType().FullName);
                    lstCoil[i].isExternalCoil = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_isExternalCoil"], DS.Tables[0].Rows[i]["coil_isExternalCoil"].GetType().FullName);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                    lstCoil[i].externalLabelPrint = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["coil_externalLabelPrint"], DS.Tables[0].Rows[i]["coil_externalLabelPrint"].GetType().FullName);
                    lstCoil[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_extrusionDate"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static bool ChangeQuality(int codsec)
        {
            clsCoil objcoil = new clsCoil(codsec);
            
            string queryString = "";
            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            if (objcoil.coil_fkCuttingQuality == 3)
            {
                queryString += "coil_fkCuttingQuality = 4, ";
            }
            else
            {
                queryString += "coil_fkCuttingQuality = 3, ";
            }
            
            queryString += "coil_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "coil_modifiedBy =" + clsGlobal.LoggedUser.codsec + "";
            queryString += " WHERE coil_codsec = " + codsec.ToString() + ";";
            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public static bool ChangeQuality(int codsec, string quality)
        {
            if(quality=="En Proceso")
            {
                quality = "Observación";
            }
            clsCoil objcoil = new clsCoil(codsec);

            string queryString = "";
            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkCuttingQuality = " + clsCuttingQuality.getQualityByName(quality).codsec.ToString() + ", ";
            queryString += "coil_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
            queryString += "coil_modifiedBy =" + clsGlobal.LoggedUser.codsec + "";
            queryString += " WHERE coil_codsec = " + codsec.ToString() + ";";
            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public static bool getCoilValidate(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coil WHERE bps_prod_coil.coil_code = '" + code + "'");


            if (DS.Tables[0].Rows.Count > 0)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DS.Dispose();
                return true;
            }
            else
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DS.Dispose();
                return false;
            }
        }

        public static bool isUnique(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coil WHERE coil_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool removeCoilToPallet(int coilCodsec)
        {

            string queryString = "";

            try
            {
                queryString = "DELETE FROM bps_prod_coilbypallet  WHERE cbp_fkCoil = " + coilCodsec.ToString() + "; ";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            
            
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.removeCoilToPallet");
                return false;
            }
        }

        public static string getMainCoilByCoil(string coilCode)
        {
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coil WHERE coil_code = '" + coilCode + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                DSM = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coil WHERE coil_codsec = " + DS.Tables[0].Rows[0]["coil_codsec"].ToString() + "");
                if (DSM.Tables[0].Rows.Count > 0)
                    return DSM.Tables[0].Rows[0]["coil_mainCoilCode"].ToString();
                else
                    return "";
            }
            else
                return "";
        }

        public static List<clsCoil> getCoilListByLotNumber(string lotnumber)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'BlockMaterialList',0,0,'" + lotnumber + "0" + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["prod_code"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }

        public static List<clsCoil> getCoilListByLotNumberExteernalCoil(string lotnumber)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'BlockMaterialListExternal',0,0,'" + lotnumber + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoil.Add(new clsCoil());
                    lstCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    lstCoil[i].ProductCode = DS.Tables[0].Rows[i]["prod_code"].ToString();
                    lstCoil[i].code = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    lstCoil[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_density"]);
                    lstCoil[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["coil_netWeight"]);
                    lstCoil[i].cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["coil_cuttingDate"]);
                    lstCoil[i].lotNumber = DS.Tables[0].Rows[i]["coil_lotNumber"].ToString();
                    lstCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["coil_mainCoilCode"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lstCoil;
        }
        
        public static bool saveBlockUnblock(List<int> lstCoil, bool isblock)
        {
            bool isValid = true;
            try
            {
                for (int i = 0; i < lstCoil.Count; i++)
                {
                    string queryString = "";

                    queryString += "UPDATE bps_prod_coil ";
                    queryString += " SET ";
                    queryString += "coil_isblock = " + isblock + " ";
                    queryString += " WHERE coil_codsec = " + lstCoil[i].ToString() + ";";

                    if (!clsConnection.executeQuery(queryString))
                    {
                        isValid = false;
                        break;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.saveblock");
                return false;
            }
        }
        public static void setCoilAsRewined(int coilCodsec)
        {
            clsCoil objCoil = new clsCoil(coilCodsec);
            string queryString = "";

            queryString += "UPDATE bps_prod_coil ";
            queryString += " SET ";
            queryString += "coil_fkStatus = 34" + ", ";
            queryString += "coil_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
            queryString += "coil_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
            queryString += "coil_wasRewined = True ";
            queryString += " WHERE coil_codsec = " + objCoil.codsec.ToString() + ";";

            bool preuba = clsConnection.executeQuery(queryString);
        }


        //Todos los metodos que se encuentren despues de esto, son "inventados" sobre la marcha por necesidad.

        public bool delete()
        {
            try
            {
                string queryString = "";

                if (this.codsec != 0)
                {
                    queryString += "UPDATE bps_prod_coil";
                    queryString += " SET ";
                    queryString += " coil_fkStatus = " + Convert.ToInt32(35) + "";
                    queryString += " WHERE coil_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

        public double getUsedLength(int fkCoil)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM vwusedlengthbycoil WHERE codsec =  " + fkCoil.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                   return Convert.ToDouble(DS.Tables[0].Rows[0]["usedLength"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.save");
                return 0;
            }
        }

        public static clsCoil getAllByCode(string coilCode)
        {
            clsCoil objCoil = new clsCoil();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coil WHERE coil_code = '" + coilCode.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCoil.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_codsec"]);
                objCoil.fkCuttingQuality = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkCuttingQuality"]);
                objCoil.fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkBalance"]);
                objCoil.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkProduct"]);
                objCoil.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_fkStatus"]);
                objCoil.code = DS.Tables[0].Rows[0]["coil_code"].ToString();
                objCoil.length = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_length"]);
                objCoil.width = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_width"]);
                objCoil.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_diameter"]);
                objCoil.density = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_density"]);
                objCoil.cuttingPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingPosition"]);
                objCoil.cuttingStop = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_cuttingStop"]);
                objCoil.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_netWeight"]);
                objCoil.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["coil_grossWeight"]);
                objCoil.treatmentSide = DS.Tables[0].Rows[0]["coil_treatmentSide"].ToString();
                objCoil.defects = DS.Tables[0].Rows[0]["coil_defects"].ToString();
                objCoil.notes = DS.Tables[0].Rows[0]["coil_notes"].ToString();
                objCoil.cuttingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_cuttingDate"]);
                objCoil.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_createdDate"]);
                objCoil.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["coil_modifiedDate"]);
                objCoil.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_createdBy"]);
                objCoil.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["coil_modifiedBy"]);
                objCoil.lotNumber = DS.Tables[0].Rows[0]["coil_lotNumber"].ToString();
                objCoil.mainCoilCode = DS.Tables[0].Rows[0]["coil_mainCoilCode"].ToString();

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objCoil;

        }

        public static int getFkSaleOrderByCoilCodsec(int coilCodsec)
        {

            DataSet DS = new DataSet();
            int fkSalesOrderDetail = 0;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkCoil = " + coilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cpsod_fkOrderDetail"]);
                return fkSalesOrderDetail;
            }
            else
            {
                return fkSalesOrderDetail;
            }

        }

        public static double pesoNeto(clsCoil objCoil)
        {
            double currentWeigth = 0;
            double netWeigth = objCoil.netWeight;

            currentWeigth = netWeigth - (((objCoil.getUsedLength(objCoil.codsec)) * objCoil.netWeight) / objCoil.length);

            return currentWeigth;
        }

    }
}
