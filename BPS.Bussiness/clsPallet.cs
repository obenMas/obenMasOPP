using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion de pallets para peliculas BOPP/Cast/Coating
    /// </summary>
    public class clsPallet: IEquatable<clsPallet>
    {
        private int plt_codsec;
        private int plt_fkPalletType;
        private clsPalletType plt_palletType;
        private int plt_fkPalletDimention;
        private clsPalletDimentions plt_palletDimention;
        private int plt_fkProduct;
        private int plt_fkStatus;
        private string plt_statusName;
        private string plt_filName;
        private clsProduct plt_product;
        private int plt_palletNumber;
        private string plt_code;
        private double plt_netWeight;
        private double plt_grossWeight;
        private Boolean plt_isPrinted;
        private DateTime plt_createdDate;
        private DateTime plt_modifiedDate;
        private int plt_createdBy;
        private string plt_creatorUser;
        private int plt_modifiedBy;
        private string plt_modificatorUser;
        private List<clsCoil> plt_lstCoil;
        private int plt_fkCoilCellar;
        private string plt_coilCellarName;
        private int plt_fkCoilCellar1;
        private string plt_coilCellarName1;
        private int plt_fkSalesOrder;
        private int plt_fkSalesOrderDetail;
        private string plt_salesOrderNumber;
        private string plt_customerName;
        private string plt_origin;
        private string plt_destination;
        private string plt_lotNumber;
        private DateTime plt_closedDate;
        private DateTime plt_delivery;
        private DateTime plt_extrusionDate;
        private int plt_coilCount;
        private int plt_inventory;
        private String plt_inventoryvsbackload;
        private string plt_diference;
        private int plt_count;
        private String plt_productName;
        private bool plt_isblock;
        private string plt_position;
        private int plt_fkPalletCoilcellar;
       
        public bool isBlock
        {
            get { return plt_isblock; }
            set { plt_isblock = value; }
        }

        private string plt_coilvaluesblock;

        public string coilValuesBlock
        {
            get { return plt_coilvaluesblock; }
            set { plt_coilvaluesblock = value; }
        }


        private List<int> plt_coilList;

        public List<int> coilList
        {
            get { return plt_coilList; }
            set { plt_coilList = value; }
        }

        private string plt_notes;

        public string notes
        {
            get { return plt_notes; }
            set { plt_notes = value; }
        }


        private string plt_checkOrigin;

        public string checkOrigin
        {
            get { return plt_checkOrigin; }
            set { plt_checkOrigin = value; }
        }




        //Properties

        public int codsec { get { return plt_codsec; } set { plt_codsec = value; } }

        public int fkPalletType { get { return plt_fkPalletType; } set { plt_fkPalletType = value; } }

        public clsPalletType palletType { get { return plt_palletType; } set { plt_palletType = value; } }

        public int fkPalletDimention { get { return plt_fkPalletDimention; } set { plt_fkPalletDimention = value; } }

        public clsPalletDimentions palletDimention { get { return plt_palletDimention; } set { plt_palletDimention = value; } }

        public int fkProduct { get { return plt_fkProduct; } set { plt_fkProduct = value; } }

        public clsProduct product { get { return plt_product; } set { plt_product = value; } }

        public int fkStatus { get { return plt_fkStatus; } set { plt_fkStatus = value; } }

        public string statusName { get { return plt_statusName; } set { plt_statusName = value; } }

        public string filmName { get { return plt_filName; } set { plt_filName = value; } }

        public int palletNumber { get { return plt_palletNumber; } set { plt_palletNumber = value; } }

        public string code { get { return plt_code; } set { plt_code = value; } }

        public double netWeight { get { return plt_netWeight; } set { plt_netWeight = value; } }

        public double grossWeight { get { return plt_grossWeight; } set { plt_grossWeight = value; } }

        public Boolean isPrinted { get { return plt_isPrinted; } set { plt_isPrinted = value; } }

        public DateTime createdDate { get { return plt_createdDate; } set { plt_createdDate = value; } }

        public DateTime modifiedDate { get { return plt_modifiedDate; } set { plt_modifiedDate = value; } }

        public int createdBy { get { return plt_createdBy; } set { plt_createdBy = value; } }

        public string creatorUser { get { return plt_creatorUser; } set { plt_creatorUser = value; } }

        public int modifiedBy { get { return plt_modifiedBy; } set { plt_modifiedBy = value; } }

        public string modificatorUser { get { return plt_modificatorUser; } set { plt_modificatorUser = value; } }

        public List<clsCoil> lstCoil { get { return plt_lstCoil; } set { plt_lstCoil = value; } }

        public int fkCoilCellar { get { return plt_fkCoilCellar; } set { plt_fkCoilCellar = value; } }

        public string coilCellarName { get { return plt_coilCellarName; } set { plt_coilCellarName = value; } }

        public int fkCoilCellar1 { get { return plt_fkCoilCellar1; } set { plt_fkCoilCellar1 = value; } }

        public string coilCellarName1 { get { return plt_coilCellarName1; } set { plt_coilCellarName1 = value; } }

        public int fkSalesOrder { get { return plt_fkSalesOrder; } set { plt_fkSalesOrder = value; } }

        public int fkSalesOrderDetail { get { return plt_fkSalesOrderDetail; } set { plt_fkSalesOrderDetail = value; } }

        public string salesOrderNumber { get { return plt_salesOrderNumber; } set { plt_salesOrderNumber = value; } }

        public string customerName { get { return plt_customerName; } set { plt_customerName = value; } }

        public string origin { get { return plt_origin; } set { plt_origin = value; } }

        public string destination { get { return plt_destination; } set { plt_destination = value; } }

        public string lotNumber { get { return plt_lotNumber; } set { plt_lotNumber = value; } }

        public DateTime closedDate { get { return plt_closedDate; } set { plt_closedDate = value; } }

        public DateTime delivery { get { return plt_delivery; } set { plt_delivery = value; } }

        public DateTime extrusionDate { get { return plt_extrusionDate; } set { plt_extrusionDate = value; } }

        public int coilCount { get { return plt_coilCount; } set { plt_coilCount = value; } }

        public int inventory { get { return plt_inventory; } set { plt_inventory = value; } }

        public String inventoryvsbackload { get { return plt_inventoryvsbackload; } set { plt_inventoryvsbackload = value; } }

        public String diference { get { return plt_diference; } set { plt_diference = value; } }

        public double coilnetweigth { get { return plt_netWeight; } set { plt_netWeight = value; } }

        public int countpallet { get { return plt_count; } set { plt_count = value; } }

        public String productName { get { return plt_productName; } set { plt_productName = value; } }

        public string position { get { return plt_position; } set { plt_position = value; } }

        public int fkPalletCoilcellar { get { return plt_fkPalletCoilcellar ; } set { plt_fkPalletCoilcellar = value; } }



        //Constructor

        public clsPallet()
        {
            plt_codsec = 0;
            plt_fkPalletDimention = 0;
            plt_fkPalletType = 0;
            plt_palletDimention = new clsPalletDimentions();
            plt_palletType = new clsPalletType();
            plt_fkProduct = 0;
            plt_product = new clsProduct();
            plt_fkStatus = 0;
            plt_statusName = "";
            plt_palletNumber = 0;
            plt_code = "";
            plt_netWeight = 0;
            plt_grossWeight = 0;
            plt_isPrinted = false;
            plt_createdDate = DateTime.Now;
            plt_modifiedDate = DateTime.Now;
            plt_createdBy = 0;
            plt_creatorUser = "";
            plt_modifiedBy = 0;
            plt_modificatorUser = "";
            plt_lstCoil = new List<clsCoil>();
            plt_fkCoilCellar = 0;
            plt_coilCellarName = "";
            plt_fkSalesOrder = 0;
            plt_fkSalesOrderDetail = 0;
            plt_salesOrderNumber = "";
            plt_customerName = "";
            plt_origin = "";
            plt_destination = "";
            plt_lotNumber = "";
            plt_closedDate = DateTime.Now;
            plt_delivery = DateTime.Now;
            plt_extrusionDate = DateTime.Now;
            plt_coilCount = 0;
            plt_inventory = 0;
            plt_inventoryvsbackload = String.Empty;
            plt_filName = string.Empty;
            plt_diference = string.Empty;
            plt_netWeight = 0;
            plt_count = 0;
            plt_productName = string.Empty;
            plt_checkOrigin = string.Empty;
            plt_position = string.Empty;
            plt_fkPalletCoilcellar = 11;
        }

        public clsPallet(int palletCodsec)
        {
            this.load(palletCodsec);
        }
        public clsPallet(int palletCodsec, bool simple)
        {
            this.loadSimple(palletCodsec);
        }
        public clsPallet(int palletCodsec, bool simple, bool withDetail)
        {
            this.loadSimpleWithDetail(palletCodsec);
        }

        //Methods
        public bool Equals(clsPallet obj)
        {
            return (this.codsec == obj.codsec);
        }


        public void load(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCodsec(" + palletCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                palletDimention = new clsPalletDimentions(fkPalletDimention);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                palletType = new clsPalletType(fkPalletType);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                product = new clsProduct(fkProduct, true);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                lstCoil = clsCoil.getCoilListByPallet(codsec);
                fkCoilCellar = 0;
                coilCellarName = "";
                fkCoilCellar1 = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                coilCellarName1 = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrderDetail"]);
                salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                checkOrigin = DS.Tables[0].Rows[0]["plt_originCheck"].ToString().ToUpper();
                position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public void loadSimple(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCodsec(" + palletCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                palletDimention = new clsPalletDimentions(fkPalletDimention);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                palletType = new clsPalletType(fkPalletType);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                product = new clsProduct(fkProduct, true);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                fkCoilCellar = 0;
                coilCellarName = "";
                fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public void loadSimpleWithDetail(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCodsec(" + palletCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                palletType = new clsPalletType(fkPalletType);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                lstCoil = clsCoil.getSimplifiedCoilListByPallet(codsec);
                fkCoilCellar = 0;
                coilCellarName = "";
                fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public static clsPallet getDetailByCode(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                objPallet.palletDimention = new clsPalletDimentions(objPallet.fkPalletDimention);
                objPallet.fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                objPallet.palletType = new clsPalletType(objPallet.fkPalletType);
                objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                objPallet.product = new clsProduct(objPallet.fkProduct, true);
                objPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                objPallet.statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                objPallet.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                objPallet.isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                objPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                objPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                objPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                objPallet.creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                objPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                objPallet.modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
                objPallet.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                objPallet.coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                objPallet.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                objPallet.closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                objPallet.delivery = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_delivery"]);
                objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilCellar"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static clsPallet getPalletInInventory(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletByInventorty 'Exist','" + palletCode + "'");

            try
            {

                if (DS.Tables[0].Rows.Count == 1)
                {
                    objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                    objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                    objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                    objPallet.productName = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                    objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                    objPallet.coilCount = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);
                    objPallet.diference = DS.Tables[0].Rows[0]["plt_diference"].ToString();
                    objPallet.coilnetweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_coilnetweigth"]);
                    objPallet.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                    objPallet.coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                    objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                    objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                    objPallet.notes = "Normal";
                    objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                    objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
                }
                else if (DS.Tables[0].Rows.Count > 1)
                {
                    objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                    objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                    objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                    objPallet.productName = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                    objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                    objPallet.coilCount = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);
                    objPallet.diference = DS.Tables[0].Rows[0]["plt_diference"].ToString();
                    objPallet.coilnetweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_coilnetweigth"]);
                    objPallet.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                    objPallet.coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                    objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                    objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                    objPallet.notes = "Duplicado";
                    objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                    objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
                }
                else
                {
                    objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                    objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                    objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                    objPallet.productName = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                    objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                    objPallet.coilCount = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);
                    objPallet.diference = DS.Tables[0].Rows[0]["plt_diference"].ToString();
                    objPallet.coilnetweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_coilnetweigth"]);
                    objPallet.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                    objPallet.coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                    objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                    objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                    objPallet.notes = "NoEspecifico";
                    objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                    objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
                }
            }
            catch (Exception)
            {
                objPallet = new clsPallet();
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static clsPallet getDetailByCodeShortNationalShipping(string palletCode)
        {
            clsPallet objPallet = new clsPallet();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");
            if (DS.Tables[0].Rows.Count > 0)
                objPallet.lstCoil = clsCoil.getCoilListShortByPalletShippingNational(Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]));
            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
            return objPallet;
        }

        public static clsPallet getSimpleDetailByCode(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                objPallet.palletDimention = new clsPalletDimentions(objPallet.fkPalletDimention);
                objPallet.fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                objPallet.palletType = new clsPalletType(objPallet.fkPalletType);
                objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                objPallet.product = new clsProduct(objPallet.fkProduct);
                objPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                objPallet.statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                objPallet.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                objPallet.isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                objPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                objPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                objPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                objPallet.creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                objPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                objPallet.modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                //objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
                objPallet.fkCoilCellar = 0;
                objPallet.coilCellarName = "";
                objPallet.fkSalesOrder = 0;
                objPallet.salesOrderNumber = "";
                objPallet.customerName = "";
                objPallet.closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();


            return objPallet;
        }

        public static clsPallet getCompleteDetailByCode(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                objPallet.palletDimention = new clsPalletDimentions(objPallet.fkPalletDimention);
                objPallet.fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                objPallet.palletType = new clsPalletType(objPallet.fkPalletType);
                objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                objPallet.product = new clsProduct(objPallet.fkProduct, true);
                objPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                objPallet.statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                objPallet.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                objPallet.isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                objPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                objPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                objPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                objPallet.creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                objPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                objPallet.modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
                objPallet.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkCoilCellar"]);
                objPallet.coilCellarName = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
                objPallet.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                objPallet.closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static clsPallet getCompleteDetailByCodePalletForPrint(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static List<clsPallet> getCompleteListForShipping(List<string> code)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();
            for (int j = 0; j < code.Count; j++)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + code[j].ToString() + "')");

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[lstPallet.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[lstPallet.Count - 1].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[lstPallet.Count - 1].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[lstPallet.Count - 1].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[lstPallet.Count - 1].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[lstPallet.Count - 1].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[lstPallet.Count - 1].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[lstPallet.Count - 1].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[lstPallet.Count - 1].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[lstPallet.Count - 1].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[lstPallet.Count - 1].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[lstPallet.Count - 1].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[lstPallet.Count - 1].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[lstPallet.Count - 1].position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                    lstPallet[lstPallet.Count - 1].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }
            return lstPallet;
        }

        public static clsPallet getCompleteDetailByCode(string palletCode, bool simple)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCode('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                objPallet.palletDimention = new clsPalletDimentions(objPallet.fkPalletDimention);
                objPallet.fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                objPallet.palletType = new clsPalletType(objPallet.fkPalletType);
                objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                objPallet.product = new clsProduct(objPallet.fkProduct, true);
                objPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                objPallet.statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                objPallet.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                objPallet.isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                objPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                objPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                objPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                objPallet.creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                objPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                objPallet.modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                //objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
                objPallet.fkCoilCellar = 0;
                objPallet.coilCellarName = "";
                objPallet.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                objPallet.closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                objPallet.position = DS.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
                objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public bool save()
        {
            return save(0, 0);
        }

        public bool save(int salesOrderDetailCodsec, int cuttingOrderDetailCodsec)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Abierto")).codsec;

                    if (this.fkPalletType == 0)
                        this.fkPalletType = 114;
                    if (this.fkPalletDimention == 0)
                        this.fkPalletDimention = 77;

                    queryString += "INSERT INTO bps_prod_pallet (plt_fkPalletType, plt_fkPalletDimention, plt_fkProduct, plt_fkStatus, plt_palletNumber, plt_code, plt_netWeight, plt_grossWeight, plt_isPrinted, plt_createdDate, plt_modifiedDate, plt_createdBy, plt_modifiedBy, plt_position, plt_fkPalletCoilcellar)";
                    queryString += " VALUES (";
                    queryString += " " + this.fkPalletType.ToString() + ", ";
                    queryString += " " + this.fkPalletDimention.ToString() + ", ";
                    queryString += " " + this.fkProduct.ToString() + ", ";
                    queryString += " " + this.fkStatus.ToString() + ", ";
                    queryString += " " + this.palletNumber.ToString() + ", ";
                    queryString += " '" + this.code.ToString() + "', ";
                    queryString += " " + this.netWeight.ToString() + ", ";
                    queryString += " " + this.grossWeight.ToString() + ", ";
                    queryString += " " + this.isPrinted.ToString() + ", ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " " + this.createdBy.ToString() + ", ";
                    queryString += " " + this.modifiedBy.ToString() + ", ";
                    queryString += " 0,";
                    queryString += " " + this.fkPalletCoilcellar.ToString() + ") ";
                   
                }
                else
                {
                    queryString += "UPDATE bps_prod_pallet ";
                    queryString += " SET ";
                    queryString += "plt_fkPalletType = " + this.fkPalletType.ToString() + ", ";
                    queryString += "plt_fkPalletDimention = " + this.fkPalletDimention.ToString() + ", ";
                    queryString += "plt_fkProduct = " + this.fkProduct.ToString() + ", ";
                    queryString += "plt_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += "plt_palletNumber = " + this.palletNumber.ToString() + ", ";
                    queryString += "plt_code = '" + this.code.ToString() + "', ";
                    queryString += "plt_netWeight = " + this.netWeight.ToString() + ", ";
                    queryString += "plt_grossWeight = " + this.grossWeight.ToString() + ", ";
                    queryString += "plt_isPrinted = " + "0" + ", ";
                    queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "plt_position = '" + this.position.ToString() + "', " ;
                    queryString += "plt_fkPalletCoilcellar = " + this.fkPalletCoilcellar.ToString();
                    queryString += " WHERE plt_codsec = " + this.codsec.ToString() + " ";
                }
                bool prueba = clsConnection.executeQuery(queryString);

                //clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                {
                    //clsSequential.addSequential("pallet");
                    this.codsec = clsPallet.getDetailByCode(this.code).codsec;
                }

                if (salesOrderDetailCodsec != 0)
                {
                    this.palletNumber = clsPallet.getCountBySalesOrderDetail(salesOrderDetailCodsec) + 1;
                    queryString = "UPDATE bps_prod_pallet SET plt_palletNumber = " + this.palletNumber.ToString() + " WHERE plt_codsec = " + this.codsec;
                    clsConnection.executeQuery(queryString);

                    queryString = "INSERT INTO bps_prod_palletbysalesorderdetail (pbsod_fkPallet, pbsod_fkSalesOrderDetail) ";
                    queryString += " VALUES (";
                    queryString += "" + this.codsec.ToString() + ", ";
                    queryString += "" + salesOrderDetailCodsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);

                    int newCodsec = 0;
                    DataSet DS = clsConnection.getDataSetResult("SELECT pbsod_codsec FROM bps_prod_palletbysalesorderdetail ORDER BY pbsod_codsec DESC Limit 1 ");

                    newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pbsod_codsec"]);

                    clsPalletDetailByPalletType.addPalletToDetail(salesOrderDetailCodsec, this.codsec, newCodsec, this.fkPalletType);
                }
                if (cuttingOrderDetailCodsec != 0)
                {
                    queryString = "INSERT INTO bps_prod_palletbycuttingorderdetail (pbcod_fkPallet, pbcod_fkCuttingOrderDetail)";
                    queryString += " VALUES (";
                    queryString += "" + this.codsec.ToString() + ", ";
                    queryString += "" + cuttingOrderDetailCodsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsPallet.save");
                return false;
            }
        }

        public bool updatePosition(string position)
        {
            this.position = position;
            string queryString = "";

            queryString += "UPDATE bps_prod_pallet ";
            queryString += " SET ";            
            
            queryString += "plt_position = '" + position.ToString() + "' ";
            
            queryString += "WHERE plt_codsec = " + this.codsec.ToString() + " ";

            return clsConnection.executeQuery(queryString);
        }

        public static bool updatePalletCoilcellar(string palletCode, int coilCellar)
        {
            string queryString = "";
            try
            {
                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkPalletCoilCellar = " + coilCellar.ToString() + " ";
                queryString += "WHERE plt_code = '" + palletCode.ToString() + "' ";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }


        public bool save(string salesOrderNumber)
        {
            try
            {
                clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(salesOrderNumber);
                int salesOrderDetailCodsec = 0;

                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    if (this.fkProduct == objSalesOrder.lstSalesOrderDetail[i].fkProduct)
                        salesOrderDetailCodsec = objSalesOrder.lstSalesOrderDetail[i].codsec;
                }

                string queryString = "";

                if (this.codsec == 0)
                {
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Abierto")).codsec;

                    if (this.fkPalletType == 0)
                        this.fkPalletType = 1;

                    queryString += "INSERT INTO bps_prod_pallet (plt_fkPalletType, plt_fkPalletDimention, plt_fkProduct, plt_fkStatus, plt_palletNumber, plt_code, plt_netWeight, plt_grossWeight, plt_isPrinted, plt_createdDate, plt_modifiedDate, plt_createdBy, plt_modifiedBy, plt_position, plt_fkPalletCoilcellar)";
                    queryString += " VALUES (";
                    queryString += " " + this.fkPalletType.ToString() + ", ";
                    queryString += " " + this.fkPalletDimention.ToString() + ", ";
                    queryString += " " + this.fkProduct.ToString() + ", ";
                    queryString += " " + this.fkStatus.ToString() + ", ";
                    queryString += " " + this.palletNumber.ToString() + ", ";
                    queryString += " '" + this.code.ToString() + "', ";
                    queryString += " " + this.netWeight.ToString() + ", ";
                    queryString += " " + this.grossWeight.ToString() + ", ";
                    queryString += " " + this.isPrinted.ToString() + ", ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " " + this.createdBy.ToString() + ", ";
                    queryString += " " + this.modifiedBy.ToString() + ", ";
                    queryString += " " + this.position.ToString() + ", ";
                    queryString += " " + this.fkPalletCoilcellar.ToString() + ") ";

                }
                else
                {
                    queryString += "UPDATE bps_prod_pallet ";
                    queryString += " SET ";
                    queryString += "plt_fkPalletType = " + this.fkPalletType.ToString() + ", ";
                    queryString += "plt_fkPalletDimention = " + this.fkPalletDimention.ToString() + ", ";
                    queryString += "plt_fkProduct = " + this.fkProduct.ToString() + ", ";
                    queryString += "plt_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += "plt_palletNumber = " + this.palletNumber.ToString() + ", ";
                    queryString += "plt_code = '" + this.code.ToString() + "', ";
                    queryString += "plt_netWeight = " + this.netWeight.ToString() + ", ";
                    queryString += "plt_grossWeight = " + this.grossWeight.ToString() + ", ";
                    queryString += "plt_isPrinted = " + this.isPrinted.ToString() + ", ";
                    queryString += "plt_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "plt_modifiedBy = " + this.modifiedBy.ToString() + ", ";
                    queryString += "plt_position = " + this.position.ToString() + ", ";
                    queryString += "plt_fkPalletCoilcellar = " + this.fkPalletCoilcellar.ToString() + " ";
                    queryString += "WHERE plt_codsec = " + this.codsec.ToString() + " ";
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                {
                    clsSequential.addSequential("pallet");
                    this.codsec = clsPallet.getLastSavedCodsec();
                }

                if (salesOrderDetailCodsec != 0)
                {
                    this.palletNumber = clsPallet.getCountBySalesOrderDetail(salesOrderDetailCodsec) + 1;
                    queryString = "UPDATE bps_prod_pallet SET plt_palletNumber = " + this.palletNumber.ToString() + " WHERE plt_codsec = " + this.codsec;
                    clsConnection.executeQuery(queryString);

                    queryString = "INSERT INTO bps_prod_palletbysalesorderdetail (pbsod_fkPallet, pbsod_fkSalesOrderDetail) ";
                    queryString += " VALUES (";
                    queryString += "" + this.codsec.ToString() + ", ";
                    queryString += "" + salesOrderDetailCodsec.ToString() + "); ";
                    clsConnection.executeQuery(queryString);

                    int newCodsec = 0;
                    DataSet DS = clsConnection.getDataSetResult("SELECT pbsod_codsec FROM bps_prod_palletbysalesorderdetail ORDER BY pbsod_codsec DESC Limit 1 ");

                    newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pbsod_codsec"]);

                    clsPalletDetailByPalletType.addPalletToDetail(salesOrderDetailCodsec, this.codsec, newCodsec, this.fkPalletType);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsPallet.save");
                return false;
            }
        }

        public bool addCoilToPallet(int coilCodsec)
        {

            string queryString = "";

            try
            {
                queryString = "INSERT INTO bps_prod_coilbypallet (cbp_fkPallet, cbp_fkCoil) ";
                queryString += " VALUES (";
                queryString += "" + this.codsec.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + "); ";
                clsConnection.executeQuery(queryString);

                clsCoil coil = new clsCoil(coilCodsec);

                clsCoilMovements coilm = new clsCoilMovements();
                coilm.fkCoil = coilCodsec;
                coilm.fkDestCellar = this.fkPalletCoilcellar;
                coilm.fkOrgCellar = this.fkPalletCoilcellar;
                coilm.fkUser = clsGlobal.LoggedUser.codsec;
                coilm.netWeigth = coil.netWeight;
                coilm.length = Convert.ToInt32(coil.length);
                coilm.type = "Agregada al pallet " + this.code;
                coilm.date = DateTime.Now;
                coilm.save();

                DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + this.codsec.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    clsPalletDetailByPalletType objPalletDetailByPalletType = clsPalletDetailByPalletType.loadByPalletBySalesOrder(Convert.ToInt32(DS.Tables[0].Rows[0]["pbsod_codsec"]));

                    List<clsCoilDetailByPalletDetail> lstCoilDetailByPalletDetail = clsCoilDetailByPalletDetail.getListByPalletDetail(objPalletDetailByPalletType.codsec);

                    for (int i = 0; i < lstCoilDetailByPalletDetail.Count; i++)
                    {
                        if (lstCoilDetailByPalletDetail[i].fkCoil == 0)
                        {
                            lstCoilDetailByPalletDetail[i].fkCoil = coilCodsec;

                            lstCoilDetailByPalletDetail[i].save();

                            break;
                        }
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {

                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsPallet.addCoilToPallet");
                return false;
            }
        }

        public bool removeCoilToPallet(int coilCodsec)
        {
            clsCoilMovements movimientoBobina = new clsCoilMovements();
            string queryString = "";

            try
            {
                queryString = "DELETE FROM bps_prod_coilbypallet  WHERE cbp_fkPallet = " + this.codsec.ToString() + " AND ";
                queryString += "cbp_fkCoil = " + coilCodsec.ToString() + "; ";

                movimientoBobina.fkCoil = coilCodsec;
                movimientoBobina.fkUser = clsGlobal.LoggedUser.codsec;
                movimientoBobina.type = "Se quito la bobina del pallet " + this.code;
                movimientoBobina.save();


                return clsConnection.executeQuery(queryString);

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.removeCoilToPallet");
                return false;
            }
        }

        public bool removeAllCoilToPallet()
        {

            string queryString = "";

            try
            {
                queryString = "DELETE FROM bps_prod_coilbypallet  WHERE ";
                queryString += "cbp_fkPallet = " + this.codsec.ToString();
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

        public static List<clsPallet> getList()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletList();");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getAvailableListBySalesOrderDetail(int SalesOrderDetailCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spAvailablePalletListBySalesOrderDetail(" + SalesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListBySalesOrderDetail(int SalesOrderDetailCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListBySalesOrderDetail(" + SalesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListBySalesOrderDetailSimple(int SalesOrderDetailCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListBySalesOrderDetail(" + SalesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getCompleteListBySalesOrderDetail(int SalesOrderDetailCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListBySalesOrderDetail(" + SalesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListBySalesOrderDetailAndPalletType(int SalesOrderDetailCodsec, int palletTypeCodsec, int palletDimentionCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spListBySalesOrderDetailAndPalletTypeAndDimention(" + SalesOrderDetailCodsec.ToString() + " , " + palletTypeCodsec.ToString() + "," + palletDimentionCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static int getCountBySalesOrderDetail(int SalesOrderDetailCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT `bps_prod_pallet`.`plt_palletNumber` AS plt_count FROM bps_prod_pallet, bps_prod_palletBySalesOrderDetail WHERE plt_codsec = pbsod_fkPallet AND pbsod_fkSalesOrderDetail = " + SalesOrderDetailCodsec.ToString() + "  order by `bps_prod_pallet`.`plt_palletNumber` DESC LIMIT 1;");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["plt_count"]);
            else
                return 0;
        }

        public static int getCountByStockAndProduct(int productCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT `bps_prod_pallet`.`plt_palletNumber` FROM bps_prod_pallet WHERE plt_fkProduct = " + productCodsec.ToString() + " AND plt_codsec not in (SELECT  pbsod_fkPallet from bps_prod_palletBySalesOrderDetail) order by `bps_prod_pallet`.`plt_palletNumber` DESC LIMIT 1;");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
            else
                return 0;
        }

        public static List<clsPallet> getListByCuttingOrderDetailAndPalletType(int cuttingOrderDetailCodsec, int palletTypeCodsec, int palletDimentionCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwPallet, bps_prod_palletByCuttingOrderDetail WHERE plt_codsec = pbcod_fkPallet AND pbcod_fkCuttingOrderDetail = " + cuttingOrderDetailCodsec.ToString() + " AND plt_fkPalletType = " + palletTypeCodsec.ToString() + " AND plt_fkPalletDimention = " + palletDimentionCodsec.ToString() + " ORDER BY plt_codsec");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListByCoilCellar(int coilCellarCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListByCoilCellar(" + coilCellarCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkCoilCellar"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkSalesOrder"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListByCoilCellarAndFilters(int coilCellarCodsec, List<clsFilter> lstFilter)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " AND " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwpalletbycellar WHERE plt_fkCoilCellar = " + coilCellarCodsec.ToString() + where);

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkCoilCellar"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkSalesOrder"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);

                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListByTransfer(int transferCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwPallet, bps_prod_palletCoilTransferDetail WHERE pctd_fkPallet = plt_codsec AND pctd_fkPalletCoilTransfer = " + transferCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkCoilCellar"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkSalesOrder"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListByMetallizedOrder(int metallizedOrderCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletListByMetalizedOrder " + metallizedOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkCoilCellar"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkSalesOrder"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListStockPallet()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListStock();");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].filmName = DS.Tables[0].Rows[i]["prod_film"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);

                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
            return lstPallet;
        }

        public static List<clsPallet> getListForBackLoad()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletListBackload();");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].lstCoil = clsCoil.getSimpleCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].coilValuesBlock = DS.Tables[0].Rows[i]["plt_coilisblock"].ToString();
                    lstPallet[i].coilList = clsGlobal.getIntListFromString(lstPallet[i].coilValuesBlock);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForBackLoadReload()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletBackloadReload");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    //lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    //lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    //lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].lstCoil = clsCoil.getSimpleCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].coilValuesBlock = DS.Tables[0].Rows[i]["plt_coilisblock"].ToString();
                    lstPallet[i].coilList = clsGlobal.getIntListFromString(lstPallet[i].coilValuesBlock);

                    lstPallet[i].productCode = DS.Tables[0].Rows[i]["plt_productCode"].ToString();
                    lstPallet[i].productWidth = DS.Tables[0].Rows[i]["plt_productWidth"].ToString();
                    lstPallet[i].productAbbreviation = DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString();
                    lstPallet[i].productCore = DS.Tables[0].Rows[i]["plt_productCore"].ToString();
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);

                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForDepotState()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spDepotState");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    //lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    //lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    //lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].lstCoil = clsCoil.getSimpleCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].coilValuesBlock = DS.Tables[0].Rows[i]["plt_coilisblock"].ToString();
                    lstPallet[i].coilList = clsGlobal.getIntListFromString(lstPallet[i].coilValuesBlock);

                    lstPallet[i].productCode = DS.Tables[0].Rows[i]["plt_productCode"].ToString();
                    lstPallet[i].productWidth = DS.Tables[0].Rows[i]["plt_productWidth"].ToString();
                    lstPallet[i].productAbbreviation = DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString();
                    lstPallet[i].productCore = DS.Tables[0].Rows[i]["plt_productCore"].ToString();
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);

                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForBaseFilm()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletStockListBaseFilm;");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].lstCoil = clsCoil.getSimpleCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForBackLoadSales()
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletListBackloadSales");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].lstCoil = clsCoil.getSimpleCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].coilValuesBlock = DS.Tables[0].Rows[i]["plt_coilisblock"].ToString();
                    lstPallet[i].coilList = clsGlobal.getIntListFromString(lstPallet[i].coilValuesBlock);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForInventory(int codsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByInventory('" + codsec.ToString() + "');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    //lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsPallet> getListForInventoryVsBackload(int codsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByInventoryVsBackload('" + codsec.ToString() + "');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].origin = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    lstPallet[i].destination = DS.Tables[0].Rows[i]["plt_destination"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    lstPallet[i].extrusionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_extrusionDate"]);
                    lstPallet[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].inventory = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_inventory"]);
                    lstPallet[i].inventoryvsbackload = (lstPallet[i].inventory == 1) ? "Inventario" : "Backload";
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT plt_codsec FROM bps_prod_pallet ORDER BY plt_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
        }

        public bool close()
        {
            DataSet DS = new DataSet();
          

            //if (this.lstCoil.Count == this.palletType.coilNumber)
            //{
                try
                {
                    bool band = true;

                    if(this.fkStatus!=3073)
                    {
                        clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Activo");
                        band = clsConnection.executeQuery("UPDATE bps_prod_pallet SET plt_fkStatus = " + objStatus.codsec + ", plt_closedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "' WHERE plt_codsec = " + this.codsec);
                    }
                    
                    return band;

                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsPallet.close()");
                    return false;
                }
            //}
            //else
            //    return false;
        }

        public bool open()
        {
            DataSet DS = new DataSet();
            clsPalletMovements movPallet = new clsPalletMovements();

            if (lstCoil != null)
            {
                //if (this.lstCoil.Count == this.palletType.coilNumber)
                //{
                try
                {
                    if (this.fkStatus != 40)
                    {
                        clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Abierto");
                        bool prueba=clsConnection.executeQuery("UPDATE bps_prod_pallet SET plt_fkStatus = " + objStatus.codsec + ", plt_closedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "' WHERE plt_codsec = " + this.codsec);
                        

                        // Genero le movimiento de abertura de pallet. Por que actualmente no teniamos trazabilidad.
                        movPallet.fkPallet = this.codsec;
                        movPallet.fkProduct = this.fkProduct;
                        movPallet.type = "Se abrió el pallet.";
                        movPallet.fkUser = clsGlobal.LoggedUser.codsec;
                        movPallet.fkOrigCellar = this.fkCoilCellar;
                        movPallet.fkDestCellar = this.fkCoilCellar1;
                        movPallet.date = DateTime.Now;

                        movPallet.save();

                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsPallet.close()");
                    return false;
                }
                //}
                //else
                //    return false;
            }
            else
                return true;
        }

        public static bool savein(clsPallet objPallet)
        {
            try
            {
                string queryString = "";

                queryString += "INSERT INTO bps_prod_depotin (dpi_fkPallet, dpi_salesorder)";
                queryString += " VALUES (";
                queryString += objPallet.codsec.ToString() + ", ";
                
                if (objPallet.salesOrderNumber.ToString()!="----")
                {
                    queryString += " '" + objPallet.salesOrderNumber.ToString() + "' ";
                }
                else
                {
                    queryString += "0 ";
                }
                queryString += ");";
            
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.savein");
                return false;
            }
        }


        public static bool saveinPL(clsPallet objPallet)
        {
            try
            {
                string queryString = "";

                queryString += "INSERT INTO bps_prod_depotinPL (dpi_fkPallet, dpi_salesorder)";
                queryString += " VALUES (";
                queryString += objPallet.codsec.ToString() + ", ";

                if (objPallet.salesOrderNumber.ToString() != "----")
                {
                    queryString += " '" + objPallet.salesOrderNumber.ToString() + "' ";
                }
                else
                {
                    queryString += "0 ";
                }
                queryString += ");";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.saveinPL");
                return false;
            }
        }

        public static void transferTo(int palletCodsec, int coilCellarCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);
            objPallet.fkPalletCoilcellar = coilCellarCodsec;
            objPallet.save();

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                clsCoil.transferCoilTo(objPallet.lstCoil[i].codsec, coilCellarCodsec);
            }
        }

        public static void transferTo(clsPallet objPallet, int coilCellarCodsec)
        {
            List<int> isNational = new List<int>();
            List<int> isInternational = new List<int>();
            objPallet.fkPalletCoilcellar = coilCellarCodsec;
            bool prue=objPallet.save();

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                if (objPallet.lstCoil[i].isExternalCoil == true)
                    isInternational.Add(objPallet.lstCoil[i].codsec);
                else
                    isNational.Add(objPallet.lstCoil[i].codsec);
            }

            for (int i = 0; i < isInternational.Count; i++)
            {
                if (objPallet.fkSalesOrder > 0)
                    clsCoil.transferCoilTo(isInternational[i], coilCellarCodsec);
                else
                {
                    //if (coilCellarCodsec == 4)
                        //coilCellarCodsec = 8;

                    //if (coilCellarCodsec == 2 || coilCellarCodsec == 7 || coilCellarCodsec == 8 || coilCellarCodsec == 9)
                        clsCoil.transferCoilTo(isInternational[i], coilCellarCodsec);
                    //else
                        //clsCoil.transferCoilTo(isInternational[i], 11);
                }
            }
            for (int i = 0; i < isNational.Count; i++)
                clsCoil.transferCoilTo(isNational[i], coilCellarCodsec);
        }

        public static void transferTo(DateTime date, string palletcode, int palletcodsec, int codseccoilcellar, string product, int palletnumber, string customer, string order, int width, double netweigth, string movement, bool isInProcess)
        {
            clsPalletbyCoilCellar ObjPalletByCoilCellar = new clsPalletbyCoilCellar();

            if (isInProcess == true)
            {
                ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                ObjPalletByCoilCellar.fkpallet = palletcodsec;
                ObjPalletByCoilCellar.ingress = true;
                ObjPalletByCoilCellar.output = false;
                ObjPalletByCoilCellar.date = date;
                ObjPalletByCoilCellar.movement = getMovement(codseccoilcellar);
                ObjPalletByCoilCellar.code = palletcode;
                ObjPalletByCoilCellar.producto = product;
                ObjPalletByCoilCellar.palletnumber = palletnumber;
                ObjPalletByCoilCellar.customer = customer;
                ObjPalletByCoilCellar.order = order;
                ObjPalletByCoilCellar.width = width;
                ObjPalletByCoilCellar.netweigth = netweigth;
                ObjPalletByCoilCellar.save();
            }
            else
            {
                //if (codseccoilcellar == 1 || codseccoilcellar == 3 || codseccoilcellar == 4 || codseccoilcellar == 8 || codseccoilcellar == 9 || codseccoilcellar == 11 || codseccoilcellar == 12)
                //{
                    //salida para proceso
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = false;
                    ObjPalletByCoilCellar.output = true;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.save();
                //}
            }

            ObjPalletByCoilCellar = new clsPalletbyCoilCellar();
        }

        private static string getMovement(int codseccoilcellar)
        {
            if (codseccoilcellar == 11)
            {
                return "Ingreso a bodega de conversión";
            }
            else if (codseccoilcellar == 1011)
            {
                //ingreso a bodega de producto terminado
                return "Ingreso a bodega de producto terminado";
            }
            else if (codseccoilcellar == 2011)
            {
                //ingreso a bodega de stock
                return "Ingreso a bodega de bobinas base y metalizado";
            }
            else if (codseccoilcellar == 3012)
            {
                //ingreso a bodega de stock guayaquil
                return "Ingreso a bodega de producto en proceso"; //movement;
            }
            else if (codseccoilcellar == 4013)
            {
                //ingreso a bodega de stock guayaquil
                return "Devolución de mercadería"; //movement;
            }
            else
            {
                return "Ingreso";
            }
        }

        public static void transferTo(DateTime date, string palletcode, int palletcodsec, int codseccoilcellar, string product, int palletnumber, string customer, string order, int width, double netweigth, string movement, bool isInProcess, int isImport)
        {
            clsPalletbyCoilCellar ObjPalletByCoilCellar = new clsPalletbyCoilCellar();

            if (isInProcess == true)
            {
                if (codseccoilcellar == 11)
                {
                    //ingreso a bodega de conversion
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = true;
                    ObjPalletByCoilCellar.output = false;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = "Ingreso a bodega de conversión"; //movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.isImport = isImport;
                    ObjPalletByCoilCellar.save();
                }
                else if (codseccoilcellar == 1011)
                {
                    //ingreso a bodega de producto terminado
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = true;
                    ObjPalletByCoilCellar.output = false;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = "Ingreso a bodega de producto terminado"; //movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.isImport = isImport;
                    ObjPalletByCoilCellar.save();
                }
                else if (codseccoilcellar == 2011)
                {
                    //ingreso a bodega de bobinas base y metalizado
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = true;
                    ObjPalletByCoilCellar.output = false;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = "Ingreso a bodega de bobinas base y metalizado"; //movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.isImport = isImport;
                    ObjPalletByCoilCellar.save();
                }
            }
            else
            {
                //if (codseccoilcellar == 8)
                //{
                    //salida para proceso
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = false;
                    ObjPalletByCoilCellar.output = true;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.save();
                //}
                //else if (codseccoilcellar == 3)
                //{
                    //Despacho de mercadera
                    /*ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = false;
                    ObjPalletByCoilCellar.output = true;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.save();
                }
                else if (codseccoilcellar == 4)
                {
                    //salida para bajas
                    ObjPalletByCoilCellar.fkcoilcellar = codseccoilcellar;
                    ObjPalletByCoilCellar.fkpallet = palletcodsec;
                    ObjPalletByCoilCellar.ingress = false;
                    ObjPalletByCoilCellar.output = true;
                    ObjPalletByCoilCellar.date = date;
                    ObjPalletByCoilCellar.movement = movement;
                    ObjPalletByCoilCellar.code = palletcode;
                    ObjPalletByCoilCellar.producto = product;
                    ObjPalletByCoilCellar.palletnumber = palletnumber;
                    ObjPalletByCoilCellar.customer = customer;
                    ObjPalletByCoilCellar.order = order;
                    ObjPalletByCoilCellar.width = width;
                    ObjPalletByCoilCellar.netweigth = netweigth;
                    ObjPalletByCoilCellar.save();
                }*/
            }
            ObjPalletByCoilCellar = new clsPalletbyCoilCellar();
        }

        public static void waitingTransferTo(int palletCodsec, int coilCellarCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                clsCoil.waitingTransferCoilTo(objPallet.lstCoil[i].codsec, coilCellarCodsec);
            }
        }

        public static void executeTransferTo(int palletCodsec, int coilCellarCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                clsCoil.executeTransferTo(objPallet.lstCoil[i].codsec, coilCellarCodsec);
        }

        public static void executeRequestFrom(int palletCodsec, int destinationCoilCellarCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                clsCoil.transferCoilTo(objPallet.lstCoil[i].codsec, destinationCoilCellarCodsec);
        }

        public static void cancelTransferTo(int palletCodsec, int coilCellarCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                clsCoil.cancelTransferTo(objPallet.lstCoil[i].codsec, coilCellarCodsec);
        }

        public static void assignPalletToSalesOrderDetail(int palletCodsec, int salesOrderDetailCodsec)
        {
            clsPallet objPallet = new clsPallet(palletCodsec);
            string queryString;

            if (salesOrderDetailCodsec != 0)
            {

                DataSet DS = new DataSet();

                objPallet.palletNumber = clsPallet.getCountBySalesOrderDetail(salesOrderDetailCodsec) + 1;
                queryString = "UPDATE bps_prod_pallet SET plt_palletNumber = " + objPallet.palletNumber.ToString() + " WHERE plt_codsec = " + objPallet.codsec;
                clsConnection.executeQuery(queryString);

                queryString = "SELECT * from bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + palletCodsec.ToString();
                DS = clsConnection.getDataSetResult(queryString);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    queryString = "UPDATE bps_prod_palletdetailbypallettype";
                    queryString += " SET ";
                    queryString += " pdbpt_fkPalletBySalesOrder = 0 ";
                    queryString += " WHERE pdbpt_fkPalletBySalesOrder = " + DS.Tables[0].Rows[0]["pbsod_codsec"];

                    clsConnection.executeQuery(queryString);

                    clsConnection.executeQuery("DELETE FROM bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + palletCodsec.ToString());
                }

                queryString = "INSERT INTO bps_prod_palletbysalesorderdetail (pbsod_fkPallet, pbsod_fkSalesOrderDetail) ";
                queryString += " VALUES (";
                queryString += "" + objPallet.codsec.ToString() + ", ";
                queryString += "" + salesOrderDetailCodsec.ToString() + "); ";
                clsConnection.executeQuery(queryString);

                int newCodsec = 0;
                DS = clsConnection.getDataSetResult("SELECT pbsod_codsec FROM bps_prod_palletbysalesorderdetail ORDER BY pbsod_codsec DESC Limit 1 ");

                newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pbsod_codsec"]);

                clsPalletDetailByPalletType.addPalletToDetail(salesOrderDetailCodsec, objPallet.codsec, newCodsec, objPallet.fkPalletType);

                objPallet.close();
            }
            else
            {
                DataSet DS = new DataSet();

                queryString = "UPDATE bps_prod_pallet SET plt_palletNumber = 1 WHERE plt_codsec = " + objPallet.codsec;
                clsConnection.executeQuery(queryString);

                queryString = "DELETE from bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + palletCodsec.ToString();
                clsConnection.executeQuery(queryString);
            }

            //TODO: Validacion en la reasignacion de Pedidos. 
            objPallet.validarCompletitud();
        }

        public static List<clsPallet> getListByDate(DateTime initDate, DateTime endDate)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletListByDate '" + initDate.ToString("dd/MM/yyyy HH:mm:ss") + "','" + endDate.ToString("dd/MM/yyyy HH:mm:ss") + "'," + clsGlobal.LoggedUser.codsec + ",'" + clsGlobal.LoggedUser.userName + "','Reporte de Pallets Completos'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    lstPallet[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletDimention"]);
                    lstPallet[i].palletDimention = new clsPalletDimentions(lstPallet[i].fkPalletDimention);
                    lstPallet[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletType"]);
                    lstPallet[i].palletType = new clsPalletType(lstPallet[i].fkPalletType);
                    lstPallet[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkProduct"]);
                    lstPallet[i].product = new clsProduct(lstPallet[i].fkProduct, true);
                    lstPallet[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                    lstPallet[i].statusName = DS.Tables[0].Rows[i]["plt_statusName"].ToString();
                    lstPallet[i].palletNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                    lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    lstPallet[i].grossWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]);
                    lstPallet[i].isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["plt_isPrinted"], DS.Tables[0].Rows[i]["plt_isPrinted"].GetType().FullName);
                    lstPallet[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    lstPallet[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_modifiedDate"]);
                    lstPallet[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_createdBy"]);
                    lstPallet[i].creatorUser = DS.Tables[0].Rows[i]["plt_creatorUser"].ToString();
                    lstPallet[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_modifiedBy"]);
                    lstPallet[i].modificatorUser = DS.Tables[0].Rows[i]["plt_modificatorUser"].ToString();
                    lstPallet[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkCoilCellar"]);
                    lstPallet[i].coilCellarName = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    lstPallet[i].fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkSalesOrder"]);
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    lstPallet[i].lstCoil = clsCoil.getCoilListByPallet(lstPallet[i].codsec);
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_closedDate"]);
                    lstPallet[i].diference = DS.Tables[0].Rows[i]["plt_diference"].ToString();
                    lstPallet[i].coilnetweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_coilnetweigth"]);
                    lstPallet[i].position = DS.Tables[0].Rows[i]["plt_position"].ToString().ToUpper();
                    lstPallet[i].fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkPalletCoilcellar"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static bool getPalletValidate(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletCodeBool '" + code + "'");

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

        public static string getPalletValidate(string code, bool data)
        {
            bool isblock = false;
            string mydata = string.Empty;

            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletCodeBool '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < DS.Tables[0].Rows.Count; j++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[j].coilValuesBlock = DS.Tables[0].Rows[j]["plt_coilisblock"].ToString();
                    lstPallet[j].coilList = clsGlobal.getIntListFromString(lstPallet[j].coilValuesBlock);
                    for (int i = 0; i < lstPallet[0].coilList.Count; i++)
                    {
                        if (lstPallet[j].coilList[i] == 1)
                        {
                            isblock = true;
                            break;
                        }
                        else
                            isblock = false;
                    }
                    if (isblock)
                        mydata = "BLOCK";
                    else
                        mydata = "OK";
                }
                return mydata;
            }
            else
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DS.Dispose();
                return "NO";
            }
        }

        public static List<clsPallet> getListByTransport(int transportBySalesOrderCodsec)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spTransportAndPalletBySalesOrder(" + transportBySalesOrderCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]), true));
                    //lstPallet.Add(new clsPallet(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"])));
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        internal void reOpen()
        {
            throw new NotImplementedException();
        }

        public static void setPalletAsReturned(int objPalletCodsec)
        {
            clsPallet objPallet = new clsPallet(objPalletCodsec);
            objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;
            clsCoilCellar cellar = clsCoilCellar.getCellarByName("Devoluciones");

            clsPallet.transferTo(DateTime.Now, objPallet.code, objPallet.codsec, cellar.codsec, objPallet.product.code, objPallet.palletNumber, objPallet.customerName, objPallet.salesOrderNumber, Convert.ToInt32(objPallet.product.width), objPallet.netWeight, "Devolución de mercadería", true);

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Pre-Despachado");
            string queryString = "";

            queryString += "UPDATE bps_prod_pallet ";
            queryString += " SET ";
            queryString += "plt_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "plt_modifiedDate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
            queryString += "plt_position = 0, ";
            queryString += "plt_fkPalletCoilCellar = "+cellar.codsec + " ";
            queryString += " WHERE plt_codsec = " + objPallet.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                clsCoil.setCoilAsReturned(objPallet.lstCoil[i], clsCoilCellar.getCellarByName("Devoluciones").codsec);
            }
        }

        public static void setPalletAsDelivered(int objPalletCodsec)
        {
            clsPallet objPallet = new clsPallet(objPalletCodsec);
            clsShippings objship = new clsShippings();
            clsSalesOrder objsale = new clsSalesOrder(objPallet.fkSalesOrder);
            objship.fkPallet = objPallet.codsec;
            objship.fkEntity = objsale.fkEntity;
            objship.fkProduct = objPallet.fkProduct;
            objship.fkSalesOrder = objPallet.fkSalesOrder;
            objship.weigth = objPallet.netWeight;
            objship.fkPlant = new clsCoilCellar(objPallet.fkPalletCoilcellar).fkPlant;
            objship.save();

            objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;

            clsPallet.transferTo(DateTime.Now, objPallet.code, objPallet.codsec, objPallet.fkCoilCellar, objPallet.product.code, objPallet.palletNumber, objPallet.customerName, objPallet.salesOrderNumber, Convert.ToInt32(objPallet.product.width), objPallet.netWeight, "Despacho de mercadería", false);

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Despachado");
            string queryString = "";

            queryString += "UPDATE bps_prod_pallet ";
            queryString += " SET ";
            queryString += "plt_fkStatus = " + objStatus.codsec.ToString() + ", ";
            queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "plt_delivery = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
            queryString += " WHERE plt_codsec = " + objPallet.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);

            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                clsCoil.setCoilAsDelivered(objPallet.lstCoil[i]);
            }
        }

        #region CancelPreShipping Overloading

        public static void cancelPreShipping(int objPalletCodsec)
        {
            clsPallet objPallet = new clsPallet(objPalletCodsec);
            objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;

            if(objPallet.fkStatus==3073)
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus = 38, ";
                queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
                queryString += " WHERE plt_codsec = " + objPallet.codsec.ToString() + ";";

                clsConnection.executeQuery(queryString);

                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                {
                    clsCoil.cancelPreShipping(objPallet.lstCoil[i].codsec);
                }
            }
        }

        public static void cancelPreShipping(clsPallet objPallet)
        {
          
            objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;

            if (objPallet.fkStatus == 3073)
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus = 38, ";
                queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
                queryString += " WHERE plt_codsec = " + objPallet.codsec.ToString() + ";";

                clsConnection.executeQuery(queryString);

                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                {
                    clsCoil.cancelPreShipping(objPallet.lstCoil[i].codsec);
                }
            }
        }
        #endregion

        public static void setPalletAsPreShipped(clsPallet objPallet) // BEFORE: Antes pasaba el codsec del pallet, y lo volvia a instanciar abajo.
        {
            //clsPallet objPallet = new clsPallet(objPalletCodsec); Nose por que lo vuelve a instanciar, si se podria pasar el objeto instanciado.
            
            objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;

            string queryString = "";

            queryString += "UPDATE bps_prod_pallet ";
            queryString += " SET ";
            queryString += "plt_fkStatus = 3073, ";
            queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + " ";
            queryString += " WHERE plt_codsec = " + objPallet.codsec.ToString() + ";";

            clsConnection.executeQuery(queryString);

            //for (int i = 0; i < objPallet.lstCoil.Count; i++)
            //{
                //clsCoil.setCoilAsPreShipped(objPallet.lstCoil[i].codsec); BEFORE: Le pasaba el codsec de bobina y lo volvia a instanciar en la clase.
                clsCoil.setCoilAsPreShipped(objPallet.lstCoil); // Se le pasa la lista y no se instancia cada bobina.
            //}
        }

        public static void setPalletAsDeliveredNational(List<string> code)
        {

            clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Despachado");
            string queryString = "";

            for (int i = 0; i < code.Count; i++)
            {
                clsPallet objPallet = clsPallet.getCompleteDetailByCode(code[i]);
                clsShippings objship = new clsShippings();
                clsSalesOrder objsale = new clsSalesOrder(objPallet.fkSalesOrder);
                objship.fkPallet = objPallet.codsec;
                objship.fkEntity = objsale.fkEntity;
                objship.fkProduct = objPallet.fkProduct;
                objship.fkSalesOrder = objPallet.fkSalesOrder;
                objship.weigth = objPallet.netWeight;
                objship.fkPlant = new clsCoilCellar(objPallet.fkPalletCoilcellar).fkPlant;
                objship.save();

                objPallet.fkCoilCellar = getContainerCellarByPallet(objPallet.codsec).codsec;

               // clsPallet.transferTo(DateTime.Now, objPallet.code, objPallet.codsec, objPallet.fkCoilCellar, objPallet.product.code, objPallet.palletNumber, objPallet.customerName, objPallet.salesOrderNumber, Convert.ToInt32(objPallet.product.width), objPallet.netWeight, "Despacho de mercadería", false);

                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus = " + objStatus.codsec.ToString() + ", ";
                queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec + ", ";
                queryString += "plt_delivery = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += " WHERE plt_code = '" + code[i].ToString() + "' ;";
                clsConnection.executeQuery(queryString);
                objPallet = new clsPallet();

                objPallet = clsPallet.getDetailByCodeShortNationalShipping(code[i].ToString());

                for (int j = 0; j < objPallet.lstCoil.Count; j++)
                {
                    clsCoil.setCoilAsDelivered(objPallet.lstCoil[j]);
                    if(objPallet.lstCoil[j].fkSalesOrderDetail!=0)
                    {
                        clsSalesOrderDetail objsod = new clsSalesOrderDetail(objPallet.lstCoil[j].fkSalesOrderDetail);
                         //objsod.setStatus();
                    }
                }
                    
                queryString = string.Empty;
            }
        }

        public static void deletePallet(int palletCodsec)
        {
            bool prueba;
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_palletbycuttingorderdetail WHERE pbcod_fkPallet = " + palletCodsec.ToString());
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_palletbymetallizedorder WHERE pbmo_fkPallet = " + palletCodsec.ToString());
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + palletCodsec.ToString());
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_palletcoiltransferdetail WHERE pctd_fkPallet = " + palletCodsec.ToString());
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_statusbypallet WHERE sbp_fkPallet = " + palletCodsec.ToString());
            prueba = clsConnection.executeQuery("DELETE FROM bps_prod_palletbycoilcellar WHERE pcc_fkPallet = " + palletCodsec.ToString());
            prueba=clsConnection.executeQuery("DELETE FROM bps_prod_pallet WHERE plt_codsec = " + palletCodsec.ToString());
        }

        public void deletePalletforMet()
        {
            bool prueba = false;
            prueba = clsConnection.executeQuery("UPDATE bps_prod_pallet SET plt_fkStatus = 41 WHERE plt_codsec = " + this.codsec.ToString());
            prueba = clsConnection.executeQuery("DELETE FROM bps_prod_coilbypallet WHERE cbp_fkPallet = " + this.codsec.ToString());
        }

        public void deletePalletforChangeOrder()
        {
            bool prueba=false;
            prueba=clsConnection.executeQuery("UPDATE bps_prod_pallet SET plt_fkStatus = 41 WHERE plt_codsec = " + this.codsec.ToString());
            //prueba = clsConnection.executeQuery("DELETE FROM bps_prod_coilbypallet WHERE cbp_fkPallet = " + this.codsec.ToString());
        }

        public static List<clsPallet> getPalletListBySalesOrder(String order)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrder('" + order + "')");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPallet.Add(new clsPallet());
                lstPallet[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
            }
            return lstPallet;
        }

        public static void setPalletReDelivery(List<string> code)
        {
            //clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Despachado");
            string queryString = "";

            for (int i = 0; i < code.Count; i++)
            {
                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus =  38, ";
                queryString += "plt_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "plt_modifiedBy =  1 , ";
                queryString += "plt_delivery = NULL ";
                queryString += " WHERE plt_code = '" + code[i].ToString() + "' ;";
                clsConnection.executeQuery(queryString);
                //clsPallet objPallet = new clsPallet();
                //objPallet = clsPallet.getDetailByCodeShortNationalShipping(code[i].ToString());
                //for (int j = 0; j < objPallet.lstCoil.Count; j++)
                //    clsCoil.setCoilAsDelivered(objPallet.lstCoil[j]);
                queryString = string.Empty;
            }
        }

        public static clsCoilCellar getContainerCellarByPallet(int coilCodsec)
        {
            clsCoilCellar objCoilCellar = new clsCoilCellar();
            int lastCellarIn = 0;
            int lastInCodsec = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pcc_codsec, pcc_fkCoilCellar FROM bps_prod_palletbycoilcellar WHERE pcc_fkpallet = " + coilCodsec + " and pcc_in = True ORDER BY pcc_codsec DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                lastCellarIn = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkCoilCellar"]);
                lastInCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
            }
            DS = clsConnection.getDataSetResult("SELECT pcc_codsec FROM bps_prod_palletbycoilcellar WHERE pcc_fkpallet = " + coilCodsec + " and pcc_out = True ORDER BY pcc_codsec DESC LIMIT 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                if (lastInCodsec > Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]))
                    objCoilCellar = new clsCoilCellar(lastCellarIn);
                else
                    objCoilCellar = new clsCoilCellar();
            }
            else
            {
                objCoilCellar = new clsCoilCellar(lastCellarIn);
            }

            if (objCoilCellar.codsec == 0)
            {
                clsPallet objPallet = new clsPallet(coilCodsec);
                objCoilCellar = objPallet.lstCoil[0].coilCellarContainer;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objCoilCellar;
        }

        public static void setUpdateStatusWhenDeliveryPallet(List<string> code)
        {
            string queryString = "";
            for (int i = 0; i < code.Count; i++)
            {
                clsPallet objPallet = clsPallet.getCompleteDetailByCode(code[i]);
                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Pallets", "Despachado").codsec.ToString() + ", ";
                queryString += "plt_delivery = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "plt_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                queryString += " WHERE plt_code = '" + code[i].ToString() + "' ;";
                if (clsConnection.executeQuery(queryString))
                {
                    objPallet = new clsPallet();
                    objPallet = clsPallet.getDetailByCodeShortNationalShipping(code[i].ToString());
                    for (int j = 0; j < objPallet.lstCoil.Count; j++)
                        clsCoil.setCoilAsDelivered(objPallet.lstCoil[j]);
                    queryString = string.Empty;
                }
                else
                    break;
            }
        }

        public static void setUpdateStatusWhenNotDeliveryPallet(List<string> code)
        {
            string queryString = "";
            for (int i = 0; i < code.Count; i++)
            {
                queryString += "UPDATE bps_prod_pallet ";
                queryString += " SET ";
                queryString += "plt_fkStatus = 38, ";
                queryString += "plt_delivery = NULL";
                queryString += " WHERE plt_code = '" + code[i].ToString() + "' ;";
                if (clsConnection.executeQuery(queryString))
                {
                    clsPallet ObjPallet = new clsPallet();
                    ObjPallet = clsPallet.getDetailByCodeShortNationalShipping(code[i].ToString());
                    for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
                        clsCoil.setCoilAsReDelivered(ObjPallet.lstCoil[j]);
                    queryString = string.Empty;
                }
            }
        }

        public bool deleteSalesOrderDetail(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_palletbysalesorderdetail WHERE pbsod_fkPallet = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.delete");
                return false;
            }
        }

        public bool deletePalletDrop(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_pallet WHERE plt_codsec = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.delete");
                return false;
            }
        }

        public static string getOrgin(int codsecPallet)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT dbo.fnOriginByPallet(" + codsecPallet + ")");
            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["COLUMN1"].ToString();
            else
                return "No found";
        }

        public static clsPallet getDetailByCodeWithAuditory(string palletCode)
        {
            clsPallet objPallet = new clsPallet();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPalletAuditory'" + palletCode + "'," + clsGlobal.LoggedUser.codsec + ",'" + clsGlobal.LoggedUser.userName + "', 'Ingreso a Bodega'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletDimention"]);
                objPallet.palletDimention = new clsPalletDimentions(objPallet.fkPalletDimention);
                objPallet.fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletType"]);
                objPallet.palletType = new clsPalletType(objPallet.fkPalletType);
                objPallet.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkProduct"]);
                objPallet.product = new clsProduct(objPallet.fkProduct);
                objPallet.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]);
                objPallet.statusName = DS.Tables[0].Rows[0]["plt_statusName"].ToString();
                objPallet.palletNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.netWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeight"]);
                objPallet.grossWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_grossWeight"]);
                objPallet.isPrinted = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["plt_isPrinted"], DS.Tables[0].Rows[0]["plt_isPrinted"].GetType().FullName);
                objPallet.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_createdDate"]);
                objPallet.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_modifiedDate"]);
                objPallet.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_createdBy"]);
                objPallet.creatorUser = DS.Tables[0].Rows[0]["plt_creatorUser"].ToString();
                objPallet.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_modifiedBy"]);
                objPallet.modificatorUser = DS.Tables[0].Rows[0]["plt_modificatorUser"].ToString();
                objPallet.lstCoil = clsCoil.getCoilListByPallet(objPallet.codsec);
                objPallet.fkCoilCellar = 0;
                objPallet.coilCellarName = "";
                objPallet.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkSalesOrder"]);
                objPallet.salesOrderNumber = DS.Tables[0].Rows[0]["plt_salesOrderNumber"].ToString();
                objPallet.customerName = DS.Tables[0].Rows[0]["plt_customerName"].ToString();
                objPallet.closedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["plt_closedDate"]);
                objPallet.diference = DS.Tables[0].Rows[0]["plt_diference"].ToString();
                objPallet.countpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_count"]);
                objPallet.fkPalletCoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);

                if (objPallet.grossWeight <= objPallet.netWeight)
                    objPallet.diference = "PESOS_DIF";

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static bool changeCreatedDateByChangeOrder(int codsec)
        {
            string queryString = "";
            queryString += "UPDATE bps_prod_pallet ";
            queryString += " SET ";
            queryString += "plt_createdDate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "plt_closedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += " WHERE plt_codsec = " + codsec.ToString() + " ;";
            return clsConnection.executeQuery(queryString);
        }

        public static int getContainerCellarByPalletLast(int codsecPallet)
        {
            int result = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMultipleMovementCellar 'InputCellar','" + codsecPallet.ToString() + "',''");

            if (DS.Tables[0].Rows.Count > 0)
                result = Convert.ToInt32(DS.Tables[0].Rows[0]["result"]);

            return result;
        }

        public static void transferToWithInternationPallet(clsPallet objPallet, int coilCellarCodsec)
        {
            foreach (var item in objPallet.lstCoil)
            {
                if (item.isExternalCoil)
                    clsCoil.transferCoilTo(item.codsec, coilCellarCodsec);
            }
        }

        public string productCode { get; set; }

        public string productWidth { get; set; }

        public string productAbbreviation { get; set; }

        public string productCore { get; set; }

        public static string getStatusOpenPallet(clsPallet objPallet)
        {
            string result = "OK";

            if (objPallet.fkStatus == 40)
                result = "Usted no puede cerrar un pallet que se encuentre como despachado, Fecha de Despacho :" + objPallet.delivery.ToString("dd/MM/yyyy HH:mm:ss");
            //else
            //{
            //    if (objPallet.delivery.ToString("dd/MM/yyyy HH:mm:ss") == "01/01/0001 00:00:00")
            //        result = "OK";
            //    else
            //    {
            //        var resultDate = DateTime.Compare(DateTime.Now, objPallet.delivery);

            //        if (resultDate == 0)
            //            result = "Usted no puede cerrar un pallet que se encuentre como despachado, Fecha de Despacho :" + objPallet.delivery.ToString("dd/MM/yyyy HH:mm:ss");
            //        else
            //            result = "Usted no puede cerrar un pallet que se encuentre como despachado, Fecha de Despacho :" + objPallet.delivery.ToString("dd/MM/yyyy HH:mm:ss");
            //    }
            //}

            return result;
        }

        public static List<clsPallet> getListCross(DateTime initDate, DateTime endDate, int source)
        {
            List<clsPallet> lstPallet = new List<clsPallet>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spPhotoBackload " + source.ToString() + ",'" + initDate.ToString("dd/MM/yyyy HH:mm:ss") + "','" + endDate.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsPallet());
                    lstPallet[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    lstPallet[i].productAbbreviation = DS.Tables[0].Rows[i]["productCode"].ToString();
                    lstPallet[i].notes = DS.Tables[0].Rows[i]["palcoil"].ToString();
                    lstPallet[i].salesOrderNumber = DS.Tables[0].Rows[i]["orderN"].ToString();
                    lstPallet[i].productWidth = DS.Tables[0].Rows[i]["width"].ToString();
                    lstPallet[i].netWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["netw"]);
                    lstPallet[i].localW = Convert.ToDouble(DS.Tables[0].Rows[i]["localW"]);
                    lstPallet[i].extW = Convert.ToDouble(DS.Tables[0].Rows[i]["oppW"]);
                    lstPallet[i].customerName = DS.Tables[0].Rows[i]["customer"].ToString();
                    lstPallet[i].lotNumber = DS.Tables[0].Rows[i]["lot"].ToString();
                    lstPallet[i].code = DS.Tables[0].Rows[i]["code"].ToString();
                    lstPallet[i].closedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["prodate"]);
                    lstPallet[i].processDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["indate"]);
                    lstPallet[i].diference = DS.Tables[0].Rows[i]["info"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsCoil> getListOfCoilsByPalletCodsec(int palletCodsec)
        {
            List<clsCoil> listaCoils = new List<clsCoil>();
            DataSet DS = new DataSet();
            clsCoil bobina = new clsCoil();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbypallet WHERE cbp_fkPallet = " + palletCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    bobina = new clsCoil(Convert.ToInt32(DS.Tables[0].Rows[i]["cbp_fkCoil"]));
                    listaCoils.Add(bobina);
                }
            }
            return listaCoils;
        }

        public static List<clsCoilByCoilCellar> getListOfCoilCellarByPalletCodsec(int palletCodsec)
        {
            List<clsCoilByCoilCellar> listaBodega = new List<clsCoilByCoilCellar>();
            clsCoilByCoilCellar bodega = new clsCoilByCoilCellar();
            DataSet DS = new DataSet();
            DataSet DS2 = new DataSet();

            DS2 = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbypallet WHERE cbp_fkPallet = " + palletCodsec.ToString());

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbycoilcellar WHERE cbcc_fkCoil IN " + DS2.Tables[0].Columns["cbp_fkCoil"]);

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    bodega.load(Convert.ToInt32(DS.Tables[0].Rows[i]["cbcc_fkCoil"]));
                    listaBodega.Add(bodega);
                }
            }
            return listaBodega;
        }

        public static bool setCoilCellar(string palletCode, int fkCoilcellarNew)
        {
            DataSet DS = new DataSet();
            string queryString = "";

            try
            {
                queryString += "UPDATE bps_prod_pallet ";
                queryString += "SET plt_fkPalletCoilCellar = " + fkCoilcellarNew.ToString();
                queryString += " WHERE plt_code = '" + palletCode.ToString() + "'";

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.save");
                return false;
            }
        }

        public double localW { get; set; }

        public double extW { get; set; }

        public DateTime processDate { get; set; }

        public static bool checkIfDispached(int codsecPallet)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_pallet WHERE plt_codsec =" + codsecPallet.ToString());

            if (Convert.ToInt32(DS.Tables[0].Rows[0]["plt_fkStatus"]) == 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarCompletitud()
        {
            double restantePedido,cantSol, cantPalND, cantPalD, cantEnt, cantPD;
            clsSalesOrderDetail sod = new clsSalesOrderDetail(this.fkSalesOrderDetail);
            bool estaCompleta = false;
            try
            {
                if(this.fkSalesOrderDetail!=0)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderControl WHERE codsec = " + this.fkSalesOrderDetail);

                    cantSol = sod.quantity * 0.9;
                    cantPalD = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaDisponible"]);
                    cantPalND = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaNoDisponible"]);
                    cantEnt = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadEntregada"]);
                    cantPD = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPredespachada"]);

                    restantePedido = cantSol - cantPalD - cantPalND - cantEnt - cantPD;

                    if (restantePedido <= 0)
                    {
                        sod.completionDate = DateTime.Now;
                        sod.wasCompleted = true;
                        if (sod.save())
                        {
                            estaCompleta = true;
                        }

                    }
                }
                else
                {
                    estaCompleta = false;
                }
                
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3,"clsPallet.validateCompletitud");
                estaCompleta = false;

            }

            return estaCompleta;
        
        }

        public bool validarCompletitud(int sodet)
        {
            double restantePedido, cantSol, cantPalND, cantPalD, cantEnt, cantPD;
            clsSalesOrderDetail sod = new clsSalesOrderDetail(sodet);
            bool estaCompleta = false;
            try
            {
                DataSet DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderControl WHERE codsec = " + sod.codsec);

                cantSol = sod.quantity * 0.9;
                cantPalD = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaDisponible"]);
                cantPalND = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPaletizadaNoDisponible"]);
                cantEnt = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadEntregada"]);
                cantPD = Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadPredespachada"]);

                restantePedido = cantSol - cantPalD - cantPalND - cantEnt - cantPD;

                if (restantePedido <= 0)
                {
                    sod.completionDate = DateTime.Now;
                    sod.wasCompleted = true;
                    if (sod.save())
                    {
                        estaCompleta = true;
                    }

                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPallet.validateCompletitud");
                estaCompleta = false;

            }

            return estaCompleta;

        }
    }
}
