using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsComparator
    {
        //Atributes

        private int plt_codsec;
        private int plt_fkProduct;
        private clsProduct plt_product;
        private int plt_palletNumber;
        private string plt_code;
        private double plt_netWeight;
        private List<clsCoil> plt_lstCoil;
        private int plt_fkCoilCellar;
        private string plt_coilCellarName;
        private string plt_salesOrderNumber;
        private string plt_customerName;
        private string plt_origin;
        private string plt_destination;
        private string plt_lotNumber;
        private DateTime plt_extrusionDate;
        private int plt_coilCount;
        private string plt_ubication;

        private int plt_pos;

        public int pos
        {
            get { return plt_pos; }
            set { plt_pos = value; }
        }

        private string plt_productName;

        public string productName
        {
            get { return plt_productName; }
            set { plt_productName = value; }
        }

        private double plt_grossweigth;

        public double grossWeigth
        {
            get { return plt_grossweigth; }
            set { plt_grossweigth = value; }
        }

        private string plt_nave;

        public string nave
        {
            get { return plt_nave; }
            set { plt_nave = value; }
        }

        private int plt_width;

        public int width
        {
            get { return plt_width; }
            set { plt_width = value; }
        }


        //Properties

        public int codsec { get { return plt_codsec; } set { plt_codsec = value; } }

        public int fkProduct { get { return plt_fkProduct; } set { plt_fkProduct = value; } }

        public clsProduct product { get { return plt_product; } set { plt_product = value; } }

        public int palletNumber { get { return plt_palletNumber; } set { plt_palletNumber = value; } }

        public string code { get { return plt_code; } set { plt_code = value; } }

        public double netWeight { get { return plt_netWeight; } set { plt_netWeight = value; } }

        public List<clsCoil> lstCoil { get { return plt_lstCoil; } set { plt_lstCoil = value; } }

        public int fkCoilCellar { get { return plt_fkCoilCellar; } set { plt_fkCoilCellar = value; } }

        public string coilCellarName { get { return plt_coilCellarName; } set { plt_coilCellarName = value; } }

        public string salesOrderNumber { get { return plt_salesOrderNumber; } set { plt_salesOrderNumber = value; } }

        public string customerName { get { return plt_customerName; } set { plt_customerName = value; } }

        public string origin { get { return plt_origin; } set { plt_origin = value; } }

        public string destination { get { return plt_destination; } set { plt_destination = value; } }

        public string lotNumber { get { return plt_lotNumber; } set { plt_lotNumber = value; } }

        public DateTime extrusionDate { get { return plt_extrusionDate; } set { plt_extrusionDate = value; } }

        public int coilCount { get { return plt_coilCount; } set { plt_coilCount = value; } }

        public string ubication { get { return plt_ubication; } set { plt_ubication = value; } }


        //Constructor

        public clsComparator()
        {
            plt_codsec = 0;
            plt_fkProduct = 0;
            plt_product = new clsProduct();
            plt_palletNumber = 0;
            plt_code = "";
            plt_netWeight = 0;
            plt_lstCoil = new List<clsCoil>();
            plt_fkCoilCellar = 0;
            plt_coilCellarName = "";
            plt_salesOrderNumber = "";
            plt_customerName = "";
            plt_origin = "";
            plt_destination = "";
            plt_lotNumber = "";
            plt_extrusionDate = DateTime.Now;
            plt_coilCount = 0;
            plt_ubication = "";

        }
        //Methos

        public static List<clsComparator> getComparator(int codsec)
        {
            List<clsComparator> lstComparator = new List<clsComparator>();
            List<clsComparator> lstComparatorInventary = new List<clsComparator>();
            bool flgValidateBacklaodList = false;
            bool flgValidateInventoryList = false;
            bool flgValidateInventory = false;
            List<int> lstOK = new List<int>();
            List<int> lstBackload = new List<int>();
            List<int> lstBackLoadOnly = new List<int>();
            List<int> lstInventory = new List<int>();
            List<int> lstInventoryOnly = new List<int>();
            List<int> lstPalletInventory = new List<int>();
            List<int> lstPallet = new List<int>();
            List<int> lstPalletWithError = new List<int>();
            DataSet DsBackload = new DataSet();
            DataSet DsInventory = new DataSet();
            DataSet DsPallet = new DataSet();


            DsBackload = clsConnection.getDataSetResult("spPalletListBackloadShort");

            DsInventory = clsConnection.getDataSetResult("SELECT invdet_fkpallet AS inv_pltcodsec FROM bps_prod_detailinventory WHERE invdet_fkinventory = " + codsec.ToString());

            for (int i = 0; i < DsBackload.Tables[0].Rows.Count; i++)
                lstBackload.Add(Convert.ToInt32(DsBackload.Tables[0].Rows[i]["plt_codsec"]));

            for (int i = 0; i < DsInventory.Tables[0].Rows.Count; i++)
                lstInventory.Add(Convert.ToInt32(DsInventory.Tables[0].Rows[i]["inv_pltcodsec"]));

            for (int i = 0; i < lstBackload.Count; i++)
            {
                for (int j = 0; j < lstInventory.Count; j++)
                {
                    if (lstInventory[j] == lstBackload[i])
                    {
                        lstOK.Add(lstInventory[j]);
                        flgValidateBacklaodList = true;
                        break;
                    }
                    else
                        flgValidateBacklaodList = false;
                }
                if (!flgValidateBacklaodList)
                    lstBackLoadOnly.Add(lstBackload[i]);
            }

            for (int i = 0; i < lstInventory.Count; i++)
            {
                for (int j = 0; j < lstBackload.Count; j++)
                {
                    if (lstInventory[i] == lstBackload[j])
                    {
                        flgValidateInventoryList = true;
                        break;
                    }
                    else
                        flgValidateInventoryList = false;
                }
                if (!flgValidateInventoryList)
                    lstInventoryOnly.Add(lstInventory[i]);
            }

            for (int i = 0; i < lstBackLoadOnly.Count; i++)
                lstPalletInventory.Add(lstBackLoadOnly[i]);

            for (int i = 0; i < lstOK.Count; i++)
                lstPalletInventory.Add(lstOK[i]);

            for (int i = 0; i < lstInventoryOnly.Count; i++)
                lstPalletInventory.Add(lstInventoryOnly[i]);

            for (int i = 0; i < lstPalletInventory.Count; i++)
            {
                DsPallet = clsConnection.getDataSetResult("spPalletByCodsecForInventory " + lstPalletInventory[i].ToString());

                if (DsPallet.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < DsPallet.Tables[0].Rows.Count; j++)
                    {
                        lstComparator.Add(new clsComparator());
                        lstComparator[i].code = DsPallet.Tables[0].Rows[j]["plt_code"].ToString();
                        lstComparator[i].codsec = Convert.ToInt32(DsPallet.Tables[0].Rows[j]["plt_codsec"]);
                        lstComparator[i].fkProduct = Convert.ToInt32(DsPallet.Tables[0].Rows[j]["plt_fkProduct"]);
                        lstComparator[i].product = new clsProduct(lstComparator[i].fkProduct, true);
                        lstComparator[i].netWeight = Convert.ToDouble(DsPallet.Tables[0].Rows[j]["plt_netWeight"]);
                        lstComparator[i].origin = DsPallet.Tables[0].Rows[j]["plt_origin"].ToString();
                        lstComparator[i].salesOrderNumber = DsPallet.Tables[0].Rows[j]["plt_salesOrderNumber"].ToString();
                        lstComparator[i].customerName = DsPallet.Tables[0].Rows[j]["plt_customerName"].ToString();
                        lstComparator[i].destination = DsPallet.Tables[0].Rows[j]["plt_destination"].ToString();
                        lstComparator[i].lotNumber = DsPallet.Tables[0].Rows[j]["plt_lotNumber"].ToString();
                        lstComparator[i].coilCellarName = DsPallet.Tables[0].Rows[j]["plt_coilCellarName"].ToString();
                        lstComparator[i].palletNumber = Convert.ToInt32(DsPallet.Tables[0].Rows[j]["plt_palletNumber"]);
                        lstComparator[i].coilCount = Convert.ToInt32(DsPallet.Tables[0].Rows[j]["plt_coilCount"]);
                        lstComparator[i].extrusionDate = Convert.ToDateTime(DsPallet.Tables[0].Rows[j]["plt_extrusionDate"]);
                        for (int k = 0; k < lstOK.Count; k++)
                        {
                            if (lstComparator[i].codsec == lstOK[k])
                            {
                                lstComparator[i].ubication = "OK";
                                flgValidateInventory = true;
                                break;
                            }
                        }
                        if (!flgValidateInventory)
                        {
                            for (int k = 0; k < lstBackLoadOnly.Count; k++)
                            {
                                if (lstComparator[i].codsec == lstBackLoadOnly[k])
                                {
                                    lstComparator[i].ubication = "Backload";
                                    flgValidateInventory = true;
                                    break;
                                }
                            }
                        }
                        if (!flgValidateInventory)
                        {
                            for (int k = 0; k < lstInventoryOnly.Count; k++)
                            {
                                if (lstComparator[i].codsec == lstInventoryOnly[k])
                                {
                                    lstComparator[i].ubication = "Inventario";
                                    flgValidateInventory = true;
                                    break;
                                }
                            }
                        }
                        flgValidateInventory = false;
                    }
                }
                else
                    lstPalletWithError.Add(lstPalletInventory[i]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DsPallet.Dispose();
            DsBackload.Dispose();
            DsInventory.Dispose();
            return lstComparator;
        }

        public static List<clsComparator> getComparatorShort(int codsec)
        {
            List<clsComparator> lstComparator = new List<clsComparator>();
            DataSet Ds = new DataSet();

            Ds = clsConnection.getDataSetResult("spPalletListBackloadShort 'List'," + codsec.ToString());

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {

                    lstComparator.Add(new clsComparator());
                    lstComparator[i].codsec = Convert.ToInt32(Ds.Tables[0].Rows[i]["codsec"]);
                    lstComparator[i].destination = Ds.Tables[0].Rows[i]["mystatus"].ToString();
                    lstComparator[i].productName = Ds.Tables[0].Rows[i]["film"].ToString();
                    lstComparator[i].netWeight = Convert.ToDouble(Ds.Tables[0].Rows[i]["netweigth"]);
                    lstComparator[i].grossWeigth = Convert.ToDouble(Ds.Tables[0].Rows[i]["grossweigth"]);
                    lstComparator[i].origin = Ds.Tables[0].Rows[i]["mysource"].ToString();
                    lstComparator[i].salesOrderNumber = Ds.Tables[0].Rows[i]["myorder"].ToString();
                    lstComparator[i].customerName = Ds.Tables[0].Rows[i]["customer"].ToString();
                    lstComparator[i].coilCellarName = Ds.Tables[0].Rows[i]["cellar"].ToString();
                    lstComparator[i].palletNumber = Convert.ToInt32(Ds.Tables[0].Rows[i]["pallet"]);
                    lstComparator[i].coilCount = Convert.ToInt32(Ds.Tables[0].Rows[i]["coil"]);
                    lstComparator[i].nave = Ds.Tables[0].Rows[i]["nave"].ToString();
                    lstComparator[i].code = Ds.Tables[0].Rows[i]["code"].ToString();
                    lstComparator[i].fkProduct = Convert.ToInt32(Ds.Tables[0].Rows[i]["fkproduct"]);
                    lstComparator[i].width = Convert.ToInt32(Ds.Tables[0].Rows[i]["width"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Ds.Dispose();
            return lstComparator;
        }

        public static List<clsComparator> getComparatorShortRePro(int codsec)
        {
            List<clsComparator> lstComparator = new List<clsComparator>();
            DataSet Ds = new DataSet();

            Ds = clsConnection.getDataSetResult("spPalletListBackloadShort 'ReProList'," + codsec.ToString());

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {

                    lstComparator.Add(new clsComparator());
                    lstComparator[i].codsec = Convert.ToInt32(Ds.Tables[0].Rows[i]["codsec"]);
                    lstComparator[i].destination = Ds.Tables[0].Rows[i]["mystatus"].ToString();
                    lstComparator[i].productName = Ds.Tables[0].Rows[i]["film"].ToString();
                    lstComparator[i].netWeight = Convert.ToDouble(Ds.Tables[0].Rows[i]["netweigth"]);
                    lstComparator[i].grossWeigth = Convert.ToDouble(Ds.Tables[0].Rows[i]["grossweigth"]);
                    lstComparator[i].origin = Ds.Tables[0].Rows[i]["mysource"].ToString();
                    lstComparator[i].salesOrderNumber = Ds.Tables[0].Rows[i]["myorder"].ToString();
                    lstComparator[i].customerName = Ds.Tables[0].Rows[i]["customer"].ToString();
                    lstComparator[i].coilCellarName = Ds.Tables[0].Rows[i]["cellar"].ToString();
                    lstComparator[i].palletNumber = Convert.ToInt32(Ds.Tables[0].Rows[i]["pallet"]);
                    lstComparator[i].coilCount = Convert.ToInt32(Ds.Tables[0].Rows[i]["coil"]);
                    lstComparator[i].nave = Ds.Tables[0].Rows[i]["nave"].ToString();
                    lstComparator[i].code = Ds.Tables[0].Rows[i]["code"].ToString();
                    lstComparator[i].fkProduct = Convert.ToInt32(Ds.Tables[0].Rows[i]["fkproduct"]);
                    lstComparator[i].width = Convert.ToInt32(Ds.Tables[0].Rows[i]["width"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Ds.Dispose();
            return lstComparator;
        }

        public static List<clsComparator> getComparatorShortRaw(int codsec)
        {
            List<clsComparator> lstComparator = new List<clsComparator>();
            DataSet Ds = new DataSet();

            Ds = clsConnection.getDataSetResult("spPalletListBackloadShort 'RawList'," + codsec.ToString());

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {

                    lstComparator.Add(new clsComparator());
                    lstComparator[i].codsec = Convert.ToInt32(Ds.Tables[0].Rows[i]["codsec"]);
                    lstComparator[i].destination = Ds.Tables[0].Rows[i]["mystatus"].ToString();
                    lstComparator[i].productName = Ds.Tables[0].Rows[i]["film"].ToString();
                    lstComparator[i].netWeight = Convert.ToDouble(Ds.Tables[0].Rows[i]["netweigth"]);
                    lstComparator[i].grossWeigth = Convert.ToDouble(Ds.Tables[0].Rows[i]["grossweigth"]);
                    lstComparator[i].origin = Ds.Tables[0].Rows[i]["mysource"].ToString();
                    lstComparator[i].salesOrderNumber = Ds.Tables[0].Rows[i]["myorder"].ToString();
                    lstComparator[i].customerName = Ds.Tables[0].Rows[i]["customer"].ToString();
                    lstComparator[i].coilCellarName = Ds.Tables[0].Rows[i]["cellar"].ToString();
                    lstComparator[i].palletNumber = Convert.ToInt32(Ds.Tables[0].Rows[i]["pallet"]);
                    lstComparator[i].coilCount = Convert.ToInt32(Ds.Tables[0].Rows[i]["coil"]);
                    lstComparator[i].nave = Ds.Tables[0].Rows[i]["nave"].ToString();
                    lstComparator[i].code = Ds.Tables[0].Rows[i]["code"].ToString();
                    lstComparator[i].fkProduct = Convert.ToInt32(Ds.Tables[0].Rows[i]["fkproduct"]);
                    lstComparator[i].width = Convert.ToInt32(Ds.Tables[0].Rows[i]["width"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Ds.Dispose();
            return lstComparator;
        }
    }
}
