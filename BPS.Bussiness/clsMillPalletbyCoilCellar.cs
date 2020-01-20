using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMillPalletbyCoilCellar : IComparable<clsMillPalletbyCoilCellar>
    {
        internal struct stcWeigthCellar
        {
            public string cellar { get; set; }
            public double weigth { get; set; }
        }

        //Attributes
        private int pcc_codsec;
        private int pcc_fkStatus;
        private int pcc_fkmillpallet;
        private string pcc_product;
        private string siigocellar;
        private string siigomovement;
        private int pcc_bag;
        private bool pcc_in;
        private bool pcc_out;
        private bool pcc_devolution;
        private string pcc_code;
        private double pcc_netweigth;
        private double pcc_grossweigth;
        private double pcc_palletweigth;
        private int pcc_order;
        private string pcc_customer;
        private DateTime pcc_date;
        private string pcc_movement;
        private bool pcc_isImport;
        private double pcc_density;
        private string pcc_millName;
        private int pcc_fkProduct;
        private string pcc_productName;


        private DateTime plt_createDate;
        private bool pcc_wasExportedToSystem;
        
        private clsProduct pcc_Product;
        private string siigocode;
        private string siigoreference;
        private double pcc_width;
        
       

        //Properties
        public int codsec { get { return pcc_codsec; } set { pcc_codsec = value; } }

        public int fkStatus { get { return pcc_fkStatus; } set { pcc_fkStatus = value; } }

        public int fkmillpallet { get { return pcc_fkmillpallet; } set { pcc_fkmillpallet = value; } }

        public string product { get { return pcc_product; } set { pcc_product = value; } }

        public string siigoCellar { get { return siigocellar; } set { siigocellar = value; } }

        public string siigoMovement { get { return siigomovement; } set { siigomovement = value; } }

        public int bag { get { return pcc_bag; } set { pcc_bag = value; } }

        public bool ingress { get { return pcc_in; } set { pcc_in = value; } }

        public bool output { get { return pcc_out; } set { pcc_out = value; } }

        public bool devolution { get { return pcc_devolution; } set { pcc_devolution = value; } }

        public string code { get { return pcc_code; } set { pcc_code = value; } }

        public double netweigth { get { return pcc_netweigth; } set { pcc_netweigth = value; } }

        public double grossweigth { get { return pcc_grossweigth; } set { pcc_grossweigth = value; } }

        public double palletweigth { get { return pcc_palletweigth; } set { pcc_palletweigth = value; } }

        public int order { get { return pcc_order; } set { pcc_order = value; } }

        public string customer { get { return pcc_customer; } set { pcc_customer = value; } }

        public DateTime date { get { return pcc_date; } set { pcc_date = value; } }

        public string movement { get { return pcc_movement; } set { pcc_movement = value; } }

        public bool isImport { get { return pcc_isImport; } set { pcc_isImport = value; } }

        public double density { get { return pcc_density; } set { pcc_density = value; } }

        public int fkProduct { get { return pcc_fkProduct; } set { pcc_fkProduct = value; } }

        public string productName { get { return pcc_productName; } set { pcc_productName = value; } }


        
        public double width { get { return pcc_width; } set { pcc_width = value; } }

        public DateTime createdate { get { return plt_createDate; } set { plt_createDate = value; } }

        public bool wasExportedToSystem { get { return pcc_wasExportedToSystem; } set { pcc_wasExportedToSystem = value; } }
        
        

        public string millName {get { return pcc_millName; }set { pcc_millName = value; } }

        

        public clsProduct ObjProduct { get { return pcc_Product; } set { pcc_Product = value; } }

        public string siigoCode { get { return siigocode; } set { siigocode = value; } }

        public string siigoReference { get { return siigoreference; } set { siigoreference = value; } }

        


        //Constructor
        public clsMillPalletbyCoilCellar()
        {
            pcc_codsec = 0;
            pcc_fkmillpallet = 0;
            pcc_in = false;
            pcc_out = false;
            pcc_devolution = false;
            pcc_date = DateTime.Now;
            pcc_movement = string.Empty;
            pcc_code = string.Empty;
            pcc_product = string.Empty;
            pcc_density = 0;
            pcc_fkStatus = 0;
            pcc_customer = string.Empty;
            pcc_order = 0;
            pcc_width = 0;
            pcc_palletweigth = 0;
            pcc_grossweigth = 0;
            pcc_netweigth = 0;
            plt_createDate = DateTime.Now;
            pcc_wasExportedToSystem = false;
            pcc_fkProduct = 0;
            pcc_bag = 0;
            pcc_Product = new clsProduct();

            //Filter
            pcc_millName=string.Empty;
            pcc_productName = string.Empty;

            siigocellar = string.Empty;
            siigomovement = string.Empty;
            siigocode = string.Empty;
            siigoreference = string.Empty;

            pcc_isImport = false;
        }

        public clsMillPalletbyCoilCellar(int codsec)
        {
            loadByMillPallet(codsec);
        }

        public clsMillPalletbyCoilCellar(int codsec, bool data)
        {
            load(codsec, data);
        }

        public int CompareTo(clsMillPalletbyCoilCellar b)
        {
            if (this.grossweigth > b.grossweigth)
            {
                return this.grossweigth.CompareTo(b.grossweigth);
            }
            return this.product.CompareTo(b.product);
        }

        //Methous
        public void loadByMillPallet(int codSec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpalletbycoilcellar WHERE pcc_fkmillpallet = " + codSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkStatus"]);
                fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkmillpallet"]);
                product = DS.Tables[0].Rows[0]["pcc_product"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["pcc_cellarsiigo"].ToString();
                siigoMovement = DS.Tables[0].Rows[0]["pcc_movementsiigo"].ToString();
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_bag"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_in"], DS.Tables[0].Rows[0]["pcc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_out"], DS.Tables[0].Rows[0]["pcc_out"].GetType().FullName);
                devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_devolution"], DS.Tables[0].Rows[0]["pcc_devolution"].GetType().FullName);
                code = DS.Tables[0].Rows[0]["pcc_code"].ToString();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_grossweigth"]);
                palletweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_pnetweigth"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_order"]);
                customer = DS.Tables[0].Rows[0]["pcc_customer"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["pcc_date"]);
                movement = DS.Tables[0].Rows[0]["pcc_movement"].ToString();
                density = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_density"]);
                isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_isImport"], DS.Tables[0].Rows[0]["pcc_isImport"].GetType().FullName);
            }
        }

        private void load(int codsec, bool data)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spReprocess 'ReprocessByCodsec','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + codsec.ToString() + ",0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkStatus"]);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["mill_productcodsec"]);
                fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkmillpallet"]);
                product = DS.Tables[0].Rows[0]["pcc_product"].ToString();
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_bag"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_in"], DS.Tables[0].Rows[0]["pcc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_out"], DS.Tables[0].Rows[0]["pcc_out"].GetType().FullName);
                devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_devolution"], DS.Tables[0].Rows[0]["pcc_devolution"].GetType().FullName);
                code = DS.Tables[0].Rows[0]["pcc_code"].ToString();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_grossweigth"]);
                palletweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_pnetweigth"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_order"]);
                customer = DS.Tables[0].Rows[0]["pcc_customer"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["pcc_date"]);
                movement = DS.Tables[0].Rows[0]["pcc_movement"].ToString();
                density = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_density"]);
                isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_isImport"], DS.Tables[0].Rows[0]["pcc_isImport"].GetType().FullName);
                millName = DS.Tables[0].Rows[0]["mill_millName"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["pcc_cellarsiigo"].ToString();
                siigoMovement = DS.Tables[0].Rows[0]["pcc_movementsiigo"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_millpalletbycoilcellar (pcc_fkStatus, pcc_fkmillpallet, pcc_product, pcc_cellarsiigo, pcc_movementsiigo, pcc_bag, pcc_in, pcc_out, pcc_devolution, pcc_code, pcc_neetweigth, pcc_grossweigth, pcc_pnetweigth, pcc_order, pcc_customer, pcc_date, pcc_movement, pcc_density, pcc_isImport)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkmillpallet.ToString() + ", ";
                    queryString += "'" + this.product + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.palletweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.customer + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += this.density.ToString() + ", ";
                    queryString += "" + this.isImport.ToString() + " ";
                    queryString += ");";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPalletbyCoilCellar.save");
                return false;
            }
        }

        public bool toUpdateOutStatus()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_millpalletbycoilcellar SET pcc_fkStatus =" + this.fkStatus.ToString() + " WHERE pcc_fkmillpallet = " + this.fkmillpallet.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPalletbyCoilCellar.delete");
                return false;
            }
        }


        public static List<clsMillPalletbyCoilCellar> getListMovementByDate(DateTime inidate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            List<clsMillPalletbyCoilCellar> lstMilPalletAux = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("spReprocess 'ReportDayListDate','','" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "',0,0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkStatus"]);
                    lstMillPalletByCoilCellar[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].millName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                    //All Data SIIGO
                    lstMilPalletAux.Add(lstMillPalletByCoilCellar[i]);
                    lstMillPalletByCoilCellar[i].siigoCode = clsXportCellarMovementsToSIIGO.siigoDataMill(lstMilPalletAux, "siigoCode");
                    lstMillPalletByCoilCellar[i].siigoReference = clsXportCellarMovementsToSIIGO.siigoDataMill(lstMilPalletAux, "siigoReference");
                    lstMilPalletAux.Clear();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        //public static List<clsMillPalletbyCoilCellar> getListMovementByDate(DateTime inidate, DateTime enddate, string movement)
        //{
        //    DataSet DS = new DataSet();
        //    List<clsMillPalletbyCoilCellar> lstMillPalletCoilCellar = new List<clsMillPalletbyCoilCellar>();
        //    List<clsMillPalletbyCoilCellar> lstMilPalletAux = new List<clsMillPalletbyCoilCellar>();
        //    //SERVER
        //    DS = clsConnection.getDataSetResult("spPalletMovementByDate 'ReportDay','','" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "',0,"+isIn(movement));
        //    //LOCAL
        //    //DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");

        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            if (movement == "Ingreso a bodega de stock local")
        //            {
        //                if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement || DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Ingreso a bodega de stock Perú")
        //                {
        //                    lstMillPalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                    int i = lstMillPalletCoilCellar.Count - 1;
        //                    lstMillPalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                    lstMillPalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                    lstMillPalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                    lstMillPalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                    lstMillPalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                    lstMillPalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                    lstMillPalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                    lstMillPalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                    lstMillPalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                    lstMillPalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                    lstMillPalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                    lstMillPalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                    lstMillPalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                    lstMillPalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                    lstMillPalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                    lstMillPalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //                    lstMillPalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                    lstMillPalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                    lstMillPalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                    lstMillPalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                    lstMillPalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //                    if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils == 0)
        //                        lstMillPalletCoilCellar[i].origin = "BOPP";
        //                    else if (lstMillPalletCoilCellar[i].localCoils == 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                        lstMillPalletCoilCellar[i].origin = "OPP";
        //                    else if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                        lstMillPalletCoilCellar[i].origin = "MIXTO";
        //                    else
        //                        lstMillPalletCoilCellar[i].origin = "-----";
        //                    lstMillPalletCoilCellar[i].ObjProduct = new clsProduct(lstMillPalletCoilCellar[i].producto);
        //                    //All Data SIIGO
        //                    lstMilPalletAux.Add(lstMillPalletCoilCellar[i]);
        //                    lstMillPalletCoilCellar[i].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstMilPalletAux).Replace("0", "");
        //                    lstMillPalletCoilCellar[i].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstMilPalletAux);
        //                    lstMillPalletCoilCellar[i].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstMilPalletAux);
        //                    lstMillPalletCoilCellar[i].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstMillPalletCoilCellar[i].siigoCode);
        //                    lstMilPalletAux.Clear();
        //                }
        //            }
        //            else
        //            {
        //                if (movement == "Salida a bodega de proceso")
        //                {
        //                    if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement || DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Salida a bodega de base para metalizar")
        //                    {
        //                        lstMillPalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                        int i = lstMillPalletCoilCellar.Count - 1;
        //                        lstMillPalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                        lstMillPalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                        lstMillPalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                        lstMillPalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                        lstMillPalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                        lstMillPalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                        lstMillPalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                        lstMillPalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                        lstMillPalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                        lstMillPalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                        lstMillPalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                        lstMillPalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                        lstMillPalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                        lstMillPalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                        lstMillPalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                        lstMillPalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //                        lstMillPalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                        lstMillPalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                        lstMillPalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                        lstMillPalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                        lstMillPalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //                        if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils == 0)
        //                            lstMillPalletCoilCellar[i].origin = "BOPP";
        //                        else if (lstMillPalletCoilCellar[i].localCoils == 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                            lstMillPalletCoilCellar[i].origin = "OPP";
        //                        else if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                            lstMillPalletCoilCellar[i].origin = "MIXTO";
        //                        else
        //                            lstMillPalletCoilCellar[i].origin = "-----";
        //                        lstMillPalletCoilCellar[i].ObjProduct = new clsProduct(lstMillPalletCoilCellar[i].producto);
        //                        //All Data SIIGO
        //                        lstMilPalletAux.Add(lstMillPalletCoilCellar[i]);
        //                        lstMillPalletCoilCellar[i].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstMilPalletAux).Replace("0", "");
        //                        lstMillPalletCoilCellar[i].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstMilPalletAux);
        //                        lstMillPalletCoilCellar[i].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstMilPalletAux);
        //                        lstMillPalletCoilCellar[i].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstMillPalletCoilCellar[i].siigoCode);
        //                        lstMilPalletAux.Clear();
        //                    }
        //                }
        //                else
        //                {
        //                    if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement)
        //                    {
        //                        lstMillPalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                        int i = lstMillPalletCoilCellar.Count - 1;
        //                        lstMillPalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                        lstMillPalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                        lstMillPalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                        lstMillPalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                        lstMillPalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                        lstMillPalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                        lstMillPalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                        lstMillPalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                        lstMillPalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                        lstMillPalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                        lstMillPalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                        lstMillPalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                        lstMillPalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                        lstMillPalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                        lstMillPalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                        lstMillPalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //                        lstMillPalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                        lstMillPalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                        lstMillPalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                        lstMillPalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                        lstMillPalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //                        if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils == 0)
        //                            lstMillPalletCoilCellar[i].origin = "BOPP";
        //                        else if (lstMillPalletCoilCellar[i].localCoils == 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                            lstMillPalletCoilCellar[i].origin = "OPP";
        //                        else if (lstMillPalletCoilCellar[i].localCoils > 0 && lstMillPalletCoilCellar[i].oppCoils > 0)
        //                            lstMillPalletCoilCellar[i].origin = "MIXTO";
        //                        else
        //                            lstMillPalletCoilCellar[i].origin = "-----";
        //                        lstMillPalletCoilCellar[i].ObjProduct = new clsProduct(lstMillPalletCoilCellar[i].producto);
        //                        //All Data SIIGO
        //                        lstMilPalletAux.Add(lstMillPalletCoilCellar[i]);
        //                        lstMillPalletCoilCellar[i].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstMilPalletAux).Replace("0", "");
        //                        lstMillPalletCoilCellar[i].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstMilPalletAux);
        //                        lstMillPalletCoilCellar[i].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstMilPalletAux);
        //                        lstMillPalletCoilCellar[i].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstMillPalletCoilCellar[i].siigoCode);
        //                        lstMilPalletAux.Clear();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return lstMillPalletCoilCellar;
        //}

        


        //public static List<clsPalletbyCoilCellar> getListMovement(DateTime inidate, DateTime enddate, int codsec)
        //{
        //    DataSet DS = new DataSet();
        //    List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
        //    DS = clsConnection.getDataSetResult("CALL spPalletMovementByReport('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "', " + codsec.ToString() + ")");
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //            lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //            lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //            lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //            lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //            lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //            lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //            lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //            lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //            lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //            lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //            lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //            lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //            lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //            lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //            lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //            lstpalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //            lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //            lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //            lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //            lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //            lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //        }
        //    }
        //    return lstpalletCoilCellar;
        //}
        //public static List<clsPalletbyCoilCellar> getListMovementByDate(DateTime inidate, DateTime enddate)
        //{
        //    DataSet DS = new DataSet();
        //    List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
        //    DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //            lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //            lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //            lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //            lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //            lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //            lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //            lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //            lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //            lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //            lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //            lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //            lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //            lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //            lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //            lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //            lstpalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //            lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //            lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //            lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //            lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //            lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //        }
        //    }
        //    return lstpalletCoilCellar;
        //}
        

        

        //public static List<clsPalletbyCoilCellar> getListMovementByDateShipping(DateTime inidate, DateTime enddate)
        //{
        //    DataSet DS = new DataSet();
        //    List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
        //    DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Despacho de mercadería")
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                int i = lstpalletCoilCellar.Count - 1;
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    return lstpalletCoilCellar;
        //}

        //public static List<clsPalletbyCoilCellar> getListTrabilityPallet(String palletcode, Boolean palletcodefilter, String product, Boolean productfilter, String customer, Boolean customerfilter, Double initweigth, Double endweigth, Boolean weigthfilter, String order, Boolean orderfilter, Int32 initwidth, Int32 endwidth, Boolean widthfilter)
        //{
        //    DataSet DS = new DataSet();
        //    List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
        //    if (palletcodefilter && !productfilter && !customerfilter && !weigthfilter && !orderfilter && !widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'palletcode')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    else if (!palletcodefilter && productfilter && !customerfilter && !weigthfilter && !orderfilter && !widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','%" + product + "%','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'product')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    else if (!palletcodefilter && !productfilter && customerfilter && !weigthfilter && !orderfilter && !widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','%" + customer + "%'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'customer')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    else if (!palletcodefilter && !productfilter && !customerfilter && weigthfilter && !orderfilter && !widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'weigth')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    else if (!palletcodefilter && !productfilter && !customerfilter && !weigthfilter && orderfilter && !widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'%" + order + "%'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'order')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    else if (!palletcodefilter && !productfilter && !customerfilter && !weigthfilter && !orderfilter && widthfilter)
        //    {
        //        DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'width')");
        //        if (DS.Tables[0].Rows.Count > 0)
        //        {
        //            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //            {
        //                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
        //                lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
        //                lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
        //                lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
        //                lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
        //                lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
        //                lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
        //                lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
        //                lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
        //                lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
        //                lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
        //                lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
        //                lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
        //                lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
        //                lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
        //                lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
        //                lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
        //                lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
        //                lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
        //                lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
        //                lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
        //            }
        //        }
        //    }
        //    return lstpalletCoilCellar;
        //}

        public static List<clsMillPalletbyCoilCellar> getListForReprocessBackLoad()
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("spReprocess 'ReprocessListForBackload','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkStatus"]);
                    lstMillPalletByCoilCellar[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].millName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static int toCodsecByMillPalletCodsec(int fkmillPallet)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpalletbycoilcellar WHERE pcc_fkmillpallet = " + fkmillPallet.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool toShipping(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_millpalletbycoilcellar SET pcc_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Despacho").codsec.ToString() + " WHERE pcc_fkmillpallet = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPalletbyCoilCellar.delete");
                return false;
            }
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_millpalletbycoilcellar WHERE pcc_codsec = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillPalletbyCoilCellar.delete");
                return false;
            }
        }

        public static List<clsMillPalletbyCoilCellar> getMillListTrazabilityCode(string code)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("spReprocess 'MillCellarCode','" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkStatus"]);
                    lstMillPalletByCoilCellar[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].millName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static List<clsMillPalletbyCoilCellar> getMillListTrazabilityProduct(string product)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("spReprocess 'MillCellarProduct','%" + product + "%','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkStatus"]);
                    lstMillPalletByCoilCellar[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].millName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static List<clsMillPalletbyCoilCellar> getMillListTrazabilityOrder(string order)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("spReprocess 'MillCellarOrder','%" + order   + "%','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,0,0,0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkStatus"]);
                    lstMillPalletByCoilCellar[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["mill_productcodsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].millName = DS.Tables[0].Rows[i]["mill_millName"].ToString();
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static List<clsMillPalletbyCoilCellar> getMillListWeigthFrom(double weigthFrom)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpalletbycoilcellar WHERE pcc_neetweigth LIKE '%" + weigthFrom.ToString() + "%'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static List<clsMillPalletbyCoilCellar> getMillListWeigthFromTo(double weigthFrom, double weigthTo)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpalletbycoilcellar WHERE pcc_pnetweigth BETWEEN " + weigthFrom.ToString() + " AND " + weigthTo.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }

        public static List<clsMillPalletbyCoilCellar> getMillListWeigthTo(double weigthTo)
        {
            DataSet DS = new DataSet();
            List<clsMillPalletbyCoilCellar> lstMillPalletByCoilCellar = new List<clsMillPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millpalletbycoilcellar WHERE pcc_pnetweigth BETWEEN 0 AND " + weigthTo.ToString() + "");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMillPalletByCoilCellar.Add(new clsMillPalletbyCoilCellar());
                    lstMillPalletByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstMillPalletByCoilCellar[i].fkmillpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkmillpallet"]);
                    lstMillPalletByCoilCellar[i].product = DS.Tables[0].Rows[i]["pcc_product"].ToString();
                    lstMillPalletByCoilCellar[i].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_bag"]);
                    lstMillPalletByCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_devolution"], DS.Tables[0].Rows[i]["pcc_devolution"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstMillPalletByCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_neetweigth"]);
                    lstMillPalletByCoilCellar[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_grossweigth"]);
                    lstMillPalletByCoilCellar[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_pnetweigth"]);
                    lstMillPalletByCoilCellar[i].order = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_order"]);
                    lstMillPalletByCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstMillPalletByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstMillPalletByCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstMillPalletByCoilCellar[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_density"]);
                    lstMillPalletByCoilCellar[i].isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_isImport"], DS.Tables[0].Rows[i]["pcc_isImport"].GetType().FullName);
                    lstMillPalletByCoilCellar[i].siigoCellar = DS.Tables[0].Rows[i]["pcc_cellarsiigo"].ToString();
                    lstMillPalletByCoilCellar[i].siigoMovement = DS.Tables[0].Rows[i]["pcc_movementsiigo"].ToString();
                }
            }
            return lstMillPalletByCoilCellar;
        }
    }
}
