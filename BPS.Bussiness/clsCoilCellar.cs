using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilCellar
    {
        //Attibutes
        private int cclr_codsec;
        private string cclr_name;
        private bool cclr_isInitialCellar;
        private bool cclr_isShippingCellar;
        private bool cclr_isRewindCellar;
        private bool cclr_isMetallizedBaseCellar;
        private bool cclr_isMetallizedCellar;
        private bool cclr_isStockCellar;
        private bool cclr_isDropCellar;
        private bool cclr_isSecundaryCutCellar;
        private int cclr_fkPlant;
        private int cclr_isScrapCellar;
        private int cclr_isRawCellar;
        private int cclr_isSiloCellar;

        //properties
        public int codsec { get { return cclr_codsec; } set { cclr_codsec = value; } }

        public string name { get { return cclr_name; } set { cclr_name = value; } }

        public bool isInitialCellar { get { return cclr_isInitialCellar; } set { cclr_isInitialCellar = value; } }

        public bool isShippingCellar { get { return cclr_isShippingCellar; } set { cclr_isShippingCellar = value; } }

        public bool isRewindCellar { get { return cclr_isRewindCellar; } set { cclr_isRewindCellar = value; } }

        public bool isMetallizedBaseCellar { get { return cclr_isMetallizedBaseCellar; } set { cclr_isMetallizedBaseCellar = value; } }

        public bool isMetallizedCellar { get { return cclr_isMetallizedCellar; } set { cclr_isMetallizedCellar = value; } }

        public bool isStockCellar { get { return cclr_isStockCellar; } set { cclr_isStockCellar = value; } }

        public bool isDropCellar { get { return cclr_isDropCellar; } set { cclr_isDropCellar = value; } }

        public bool isSecundaryCutCellar { get { return cclr_isSecundaryCutCellar; } set { cclr_isSecundaryCutCellar = value; } }

        public int fkPlant { get { return cclr_fkPlant; } set { cclr_fkPlant = value; } }

        public int isScrapCellar { get { return cclr_isScrapCellar; } set { cclr_isScrapCellar = value; } }

        public int isRawCellar { get { return cclr_isRawCellar; } set { cclr_isRawCellar = value; } }

        public int isSiloCellar { get { return cclr_isSiloCellar; } set { cclr_isSiloCellar = value; } }

        //Constructor
        public clsCoilCellar()
        {
            codsec = 0;
            name = "";
            isInitialCellar = false;
            isShippingCellar = false;
            isRewindCellar = false;
            isMetallizedBaseCellar = false;
            isMetallizedCellar = false;
            isStockCellar = false;
            isDropCellar = false;
            isSecundaryCutCellar = false;
            fkPlant = 0;
        }
        public clsCoilCellar(int coilCellarCodsec)
        {
            this.load(coilCellarCodsec);
        }

        public clsCoilCellar(string coilcellarname)
        {
            this.load(coilcellarname);
        }

        //Methods
        public void load(int coilCellarCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_codsec = " + coilCellarCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_codsec"]);
                this.name = Convert.ToString(DS.Tables[0].Rows[0]["cclr_name"]);
                this.isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isInitialCellar"], DS.Tables[0].Rows[0]["cclr_isInitialCellar"].GetType().FullName);
                this.isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isShippingCellar"], DS.Tables[0].Rows[0]["cclr_isShippingCellar"].GetType().FullName);
                this.isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                this.isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                this.isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"].GetType().FullName);
                this.isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isStockCellar"], DS.Tables[0].Rows[0]["cclr_isStockCellar"].GetType().FullName);
                this.isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isDropCellar"], DS.Tables[0].Rows[0]["cclr_isDropCellar"].GetType().FullName);
                this.isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_fkPlant"]);
                this.isScrapCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isScrapCellar"]);
                this.isRawCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isRawCellar"]);
                this.isSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isSiloCellar"]);
            }
        }

        public void load(string coilcellarname)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_name = " +  "'" + coilcellarname + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_codsec"]);
                this.name = Convert.ToString(DS.Tables[0].Rows[0]["cclr_name"]);
                this.isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isInitialCellar"], DS.Tables[0].Rows[0]["cclr_isInitialCellar"].GetType().FullName);
                this.isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isShippingCellar"], DS.Tables[0].Rows[0]["cclr_isShippingCellar"].GetType().FullName);
                this.isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                this.isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                this.isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"].GetType().FullName);
                this.isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isStockCellar"], DS.Tables[0].Rows[0]["cclr_isStockCellar"].GetType().FullName);
                this.isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isDropCellar"], DS.Tables[0].Rows[0]["cclr_isDropCellar"].GetType().FullName);
                this.isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                this.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_fkPlant"]);
                this.isScrapCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isScrapCellar"]);
                this.isRawCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isRawCellar"]);
                this.isSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_isSiloCellar"]);
            }

        }

        public static List<clsCoilCellar> getList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    //lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                    
                }
            }

            return lstCoilCellar;
        }

        public static List<clsCoilCellar> getListByPlant(int fkPlant)
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_fkPlant = " + fkPlant);

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    //lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);

                }
            }

            return lstCoilCellar;
        }


        public static clsCoilCellar getCellarByName(string coilCellarName)
        {
            DataSet DS = new DataSet();
            clsCoilCellar objCoilCellar = new clsCoilCellar();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_name = '" + coilCellarName + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCoilCellar.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_codsec"]);
                objCoilCellar.name = Convert.ToString(DS.Tables[0].Rows[0]["cclr_name"]);
                objCoilCellar.isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isInitialCellar"], DS.Tables[0].Rows[0]["cclr_isInitialCellar"].GetType().FullName);
                objCoilCellar.isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isShippingCellar"], DS.Tables[0].Rows[0]["cclr_isShippingCellar"].GetType().FullName);
                objCoilCellar.isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                objCoilCellar.isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                objCoilCellar.isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[0]["cclr_isMetallizedCellar"].GetType().FullName);
                objCoilCellar.isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isStockCellar"], DS.Tables[0].Rows[0]["cclr_isStockCellar"].GetType().FullName);
                objCoilCellar.isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isDropCellar"], DS.Tables[0].Rows[0]["cclr_isDropCellar"].GetType().FullName);
                objCoilCellar.isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                objCoilCellar.fkPlant = Convert.ToInt32(DS.Tables[0].Rows[0]["cclr_fkPlant"]);

            }

            return objCoilCellar;
        }
        public static List<clsCoilCellar> getInitialCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isInitialCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
               
                }
            }

            return lstCoilCellar;
        }

        public static List<clsCoilCellar> getInitialCellarList(int fkPlant)
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isInitialCellar = True AND cclr_fkPlant="+fkPlant.ToString()+" ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }

        public static List<clsCoilCellar> getShippingCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isShippingCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getRewindCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isRewindCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getMetallizedBaseCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isMetallizedBaseCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getMetallizedCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isMetallizedCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getStockCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isStockCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getDropCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isDropCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }
        public static List<clsCoilCellar> getSecundaryCutCellarList()
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilCellar WHERE cclr_isSecundaryCutCellar = True ORDER BY cclr_name");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }


        public static List<clsCoilCellar> getCoilCellarByCoilCodsec(int codsec)
        {
            List<clsCoilCellar> lstCoilCellar = new List<clsCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbycoilcellar WHERE cbcc_fkCoil = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellar.Add(new clsCoilCellar());
                    lstCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]);
                    lstCoilCellar[i].name = Convert.ToString(DS.Tables[0].Rows[i]["cclr_name"]);
                    lstCoilCellar[i].isInitialCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isInitialCellar"], DS.Tables[0].Rows[i]["cclr_isInitialCellar"].GetType().FullName);
                    lstCoilCellar[i].isShippingCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isShippingCellar"], DS.Tables[0].Rows[i]["cclr_isShippingCellar"].GetType().FullName);
                    lstCoilCellar[i].isRewindCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isRewindCellar"], DS.Tables[0].Rows[0]["cclr_isRewindCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedBaseCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedBaseCellar"].GetType().FullName);
                    lstCoilCellar[i].isMetallizedCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"], DS.Tables[0].Rows[i]["cclr_isMetallizedCellar"].GetType().FullName);
                    lstCoilCellar[i].isStockCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isStockCellar"], DS.Tables[0].Rows[i]["cclr_isStockCellar"].GetType().FullName);
                    lstCoilCellar[i].isDropCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cclr_isDropCellar"], DS.Tables[0].Rows[i]["cclr_isDropCellar"].GetType().FullName);
                    lstCoilCellar[i].isSecundaryCutCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"], DS.Tables[0].Rows[0]["cclr_isSecundaryCutCellar"].GetType().FullName);
                    lstCoilCellar[i].fkPlant = Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_fkPlant"]);
                }
            }

            return lstCoilCellar;
        }

        public override string ToString()
        {
            return this.name;
        }

        public static List<clsCoilCellar> lstCellarScrap(int fkPlant)
        {
            List<clsCoilCellar> lstCellarScrap = new List<clsCoilCellar>();
            clsCoilCellar bodegas = new clsCoilCellar();
            

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_fkPlant = " +  fkPlant.ToString() +  "AND (cclr_isScrapCellar = 1 OR cclr_isStockCellar = 1)");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    bodegas = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstCellarScrap.Add(bodegas);

                }
            }
            return lstCellarScrap;
        }

        public static List<clsCoilCellar> lstRawCellar()
        {
            List<clsCoilCellar> lstRawCellar = new List<clsCoilCellar>();
            clsCoilCellar bodegas = new clsCoilCellar();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_isRawCellar = 1");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    bodegas = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstRawCellar.Add(bodegas);
                }
            }
            return lstRawCellar;
        }

        public static List<clsCoilCellar> lstSiloCellar()
        {
            List<clsCoilCellar> lstSiloCellar = new List<clsCoilCellar>();
            clsCoilCellar silos = new clsCoilCellar();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_isSiloCellar = 1");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    silos = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstSiloCellar.Add(silos);
                }
            }
            return lstSiloCellar;
        }

        public static List<clsCoilCellar> lstSiloCellarByPlant(int fkPlant)
        {
            //Esto hay que mejorarlo por que las listas de objetos son pocos eficientes si crecen mucho.

            List<clsCoilCellar> lstSilo = new List<clsCoilCellar>();
            clsCoilCellar silo = new clsCoilCellar();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_fkPlant = " + fkPlant.ToString() + "AND cclr_isSiloCellar = 1");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    silo = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstSilo.Add(silo);
                }
            }
            return lstSilo;
        }

        public static List<clsCoilCellar> lstSiloAndRawCellar(int fkPlant)
        {
            List<clsCoilCellar> lstSiloAndRawCellar = new List<clsCoilCellar>();
            clsCoilCellar siloraw = new clsCoilCellar();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_fkPlant = " + fkPlant.ToString() + "AND" + "(cclr_isSiloCellar = 1 OR cclr_isRawCellar = 1)");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    siloraw = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstSiloAndRawCellar.Add(siloraw);
                }
            }
            return lstSiloAndRawCellar;
        }

        public static DataSet lstStockCellarByPlant(int fkPlant)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE (cclr_isStockCellar = 1 OR cclr_isInitialCellar = 1 OR cclr_isRewindCellar = 1) AND cclr_fkPlant = " + fkPlant.ToString());

            if (DS.Tables.Count > 0)
            {
                return DS;
            }
            else
            {
                return DS;
            }
        }

        public static List<clsCoilCellar> lstStockCellar(int fkPlant)
        {
            List<clsCoilCellar> lstStockCellar = new List<clsCoilCellar>();
            clsCoilCellar stockCellar = new clsCoilCellar();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE cclr_fkPlant= " + fkPlant.ToString() + " AND (cclr_isStockCellar = 1 OR cclr_isScrapCellar = 1 OR cclr_isMetallizedBaseCellar = 1)");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    stockCellar = new clsCoilCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["cclr_codsec"]));
                    lstStockCellar.Add(stockCellar);
                }
            }
            return lstStockCellar;
        }
    }
}
