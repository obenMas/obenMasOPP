using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsCoilByPalletAditional
    {
        //Attributes
        private int pcc_codsec;
        private int pcc_fkcoilcellar;
        private int pcc_fkpallet;
        private bool pcc_in;
        private bool pcc_out;
        private DateTime pcc_date;
        private string pcc_movement;
        private string pcc_code;
        private string pcc_producto;
        private int pcc_palletnumber;
        private int pcc_coilnumber;
        private string pcc_customer;
        private string pcc_order;
        private double pcc_width;
        private double pc_netweigth;
        private double pcc_localweigth;
        private double pcc_oppweigth;
        private DateTime plt_createDate;
        private bool pcc_wasExportedToSystem;
        private int pcc_localCoils;
        private int pcc_oppCoils;
        private string plt_origin;
        private clsProduct pcc_Product;

        private string siigocellar;
        private string siigomovement;
        private string siigocode;
        private string siigoreference;


        //Filters
        private string palletfilter;
        private int pcc_isImport;

        //Properties
        public int codsec { get { return pcc_codsec; } set { pcc_codsec = value; } }

        public int fkcoilcellar { get { return pcc_fkcoilcellar; } set { pcc_fkcoilcellar = value; } }

        public int fkpallet { get { return pcc_fkpallet; } set { pcc_fkpallet = value; } }

        public bool ingress { get { return pcc_in; } set { pcc_in = value; } }

        public bool output { get { return pcc_out; } set { pcc_out = value; } }

        public DateTime date { get { return pcc_date; } set { pcc_date = value; } }

        public string movement { get { return pcc_movement; } set { pcc_movement = value; } }

        public string code { get { return pcc_code; } set { pcc_code = value; } }

        public string producto { get { return pcc_producto; } set { pcc_producto = value; } }

        public int palletnumber { get { return pcc_palletnumber; } set { pcc_palletnumber = value; } }

        public int coilnumber { get { return pcc_coilnumber; } set { pcc_coilnumber = value; } }

        public string customer { get { return pcc_customer; } set { pcc_customer = value; } }

        public string order { get { return pcc_order; } set { pcc_order = value; } }

        public double width { get { return pcc_width; } set { pcc_width = value; } }

        public double netweigth { get { return pc_netweigth; } set { pc_netweigth = value; } }

        public double localweigth { get { return pcc_localweigth; } set { pcc_localweigth = value; } }

        public double oppweigth { get { return pcc_oppweigth; } set { pcc_oppweigth = value; } }

        public DateTime createdate { get { return plt_createDate; } set { plt_createDate = value; } }

        public bool wasExportedToSystem { get { return pcc_wasExportedToSystem; } set { pcc_wasExportedToSystem = value; } }
        
        public int localCoils { get { return pcc_localCoils; } set { pcc_localCoils = value; } }

        public int oppCoils { get { return pcc_oppCoils; } set { pcc_oppCoils = value; } }

        //Filter
        public string PalletFilter{get { return palletfilter; }set { palletfilter = value; } }

        public string origin { get { return plt_origin; } set { plt_origin = value; } }

        public clsProduct ObjProduct { get { return pcc_Product; } set { pcc_Product = value; } }


        public string siigoCellar { get { return siigocellar; } set { siigocellar = value; } }

        public string siigoMovement { get { return siigomovement; } set { siigomovement = value; } }

        public string siigoCode { get { return siigocode; } set { siigocode = value; } }

        public string siigoReference { get { return siigoreference; } set { siigoreference = value; } }

        public int isImport { get { return pcc_isImport; } set { pcc_isImport = value; } }


        //Constructor
        public clsCoilByPalletAditional()
        {
            pcc_codsec = 0;
            pcc_fkcoilcellar = 0;
            pcc_fkpallet = 0;
            pcc_in = false;
            pcc_out = false;
            pcc_date = DateTime.Now;
            pcc_movement = string.Empty;
            pcc_code = string.Empty;
            pcc_producto = string.Empty;
            pcc_palletnumber = 0;
            pcc_coilnumber = 0;
            pcc_customer = string.Empty;
            pcc_order = string.Empty;
            pcc_width = 0;
            pc_netweigth = 0;
            pcc_localweigth = 0;
            pcc_oppweigth = 0;
            plt_createDate = DateTime.Now;
            pcc_wasExportedToSystem = false;
            pcc_localCoils = 0;
            pcc_oppCoils = 0;
            pcc_Product = new clsProduct();

            //Filter
            palletfilter=string.Empty;
            plt_origin = string.Empty;

            siigocellar = string.Empty;
            siigomovement = string.Empty;
            siigocode = string.Empty;
            siigoreference = string.Empty;

            pcc_isImport = 0;
        }
    }
}
