using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de metalizado
    /// </summary>
    public class clsMetallizedOrderDetail
    {
        //Atributes
        private int mtod_codsec;
        private int mtod_fkOrder;
        private clsMetallizedOrder mtod_Order;
        private List<clsMetallizedOrder> mtod_lstMetalizedOrder;
        private int mtod_fkproductfrom;
        private clsProduct mtod_productfrom;
        private List<clsProduct> mtod_lstproductfrom;
        private int mtod_fkproductto;
        private clsProduct mtod_productto;
        private List<clsProduct> mtod_lstproductto;
        private double mtod_decrease;
        private double mtod_netweigth;
        private double mtod_grossweigth;
        private string mtod_code;
        private string mtod_mcode;
        private DateTime mtod_inithour;
        private DateTime mtod_endhour;
        private string mtod_processValues;
        private List<string> mtod_processList;
        private string mtod_pressionValues;
        private List<double> mtod_pressionList;
        private string mtod_notes;
        private int mtod_closeby;
        private string mtod_closeuser;
        private int mtod_coil;
        private string mtod_productFromName;
        private string mtod_productToName;
        private string mtod_customer;
        private int mtod_fkmaquile;

        //Properties

        public int codsec { get { return mtod_codsec; } set { mtod_codsec = value; } }

        public int fkOrder { get { return mtod_fkOrder; } set { mtod_fkOrder = value; } }

        public clsMetallizedOrder Order { get { return mtod_Order; } set { mtod_Order = value; } }

        public List<clsMetallizedOrder> lstMetalizedOrder { get { return mtod_lstMetalizedOrder; } set { mtod_lstMetalizedOrder = value; } }

        public int fkproductFrom { get { return mtod_fkproductfrom; } set { mtod_fkproductfrom = value; } }

        public clsProduct ProductFrom { get { return mtod_productfrom; } set { mtod_productfrom = value; } }

        public List<clsProduct> lstProductFrom { get { return mtod_lstproductfrom; } set { mtod_lstproductfrom = value; } }

        public int fkproductTo { get { return mtod_fkproductto; } set { mtod_fkproductto = value; } }

        public clsProduct ProductTo { get { return mtod_productto; } set { mtod_productto = value; } }

        public List<clsProduct> lstProductTo { get { return mtod_lstproductto; } set { mtod_lstproductto = value; } }

        public double decrease { get { return mtod_decrease; } set { mtod_decrease = value; } }

        public double netweigth { get { return mtod_netweigth; } set { mtod_netweigth = value; } }

        public double grossweigth { get { return mtod_grossweigth; } set { mtod_grossweigth = value; } }

        public string code { get { return mtod_code; } set { mtod_code = value; } }

        public string mcode { get { return mtod_mcode; } set { mtod_mcode = value; } }

        public DateTime initHour { get { return mtod_inithour; } set { mtod_inithour = value; } }

        public DateTime endHour { get { return mtod_endhour; } set { mtod_endhour = value; } }

        public string processValues { get { return mtod_processValues; } set { mtod_processValues = value; } }

        public List<string> processList { get { return mtod_processList; } set { mtod_processList = value; } }

        public string pressionValues { get { return mtod_pressionValues; } set { mtod_pressionValues = value; } }

        public List<double> pressionList { get { return mtod_pressionList; } set { mtod_pressionList = value; } }

        public string notes { get { return mtod_notes; } set { mtod_notes = value; } }

        public int closeBy { get { return mtod_closeby; } set { mtod_closeby = value; } }

        public string closeUser { get { return mtod_closeuser; } set { mtod_closeuser = value; } }

        public int fkCoil { get { return mtod_coil; } set { mtod_coil = value; } }

        public string productFromName { get { return mtod_productFromName; } set { mtod_productFromName = value; } }

        public string productToName { get { return mtod_productToName; } set { mtod_productToName = value; } }

        public string customer { get { return mtod_customer; } set { mtod_customer = value; } }

        public int fkmaquile { get { return mtod_fkmaquile; } set { mtod_fkmaquile = value; } }

        //Constructor

        public clsMetallizedOrderDetail()
        {
            mtod_codsec = 0;
            mtod_fkOrder = 0;
            mtod_Order = new clsMetallizedOrder();
            mtod_lstMetalizedOrder = new List<clsMetallizedOrder>();
            mtod_fkproductfrom = 0;
            mtod_productfrom = new clsProduct();
            mtod_lstproductfrom = new List<clsProduct>();
            mtod_fkproductto = 0;
            mtod_productto = new clsProduct();
            mtod_lstproductto = new List<clsProduct>();
            mtod_code = "";
            mtod_mcode = "";
            mtod_decrease = 0;
            mtod_netweigth = 0;
            mtod_grossweigth = 0;
            mtod_notes = "";
            mtod_inithour = DateTime.Now;
            mtod_endhour = DateTime.Now;
            mtod_processValues = "0;0;0;0;0;0;0;0;0;0;0;0;0";
            mtod_processList = new List<string>();
            mtod_pressionValues = "0;0;0;0;0;0;0;0";
            mtod_pressionList = new List<double>();
            mtod_closeby = 0;
            mtod_closeuser = "";
            mtod_coil = 0;
            mtod_productToName = "";
            mtod_productFromName = "";
            mtod_customer = "";
            mtod_fkmaquile = 0;
        }

        public clsMetallizedOrderDetail(int codsec)
        {
            Loader(codsec);
        }

        //Methods


        public void Loader(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedDetailByCodsec " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_codsec"]);
                fkOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_fkOrder"]);
                Order = new clsMetallizedOrder(this.fkOrder);
                fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_fkproductfrom"]);
                //ProductFrom = new clsProduct(fkproductFrom);
                fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_fkproductto"]);
                ProductTo = new clsProduct(fkproductTo);
                decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_decrease"]);
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_netweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_grossweigth"]);
                code = DS.Tables[0].Rows[0]["mtod_code"].ToString();
                mcode = DS.Tables[0].Rows[0]["mtod_mcode"].ToString();
                initHour = Convert.ToDateTime(DS.Tables[0].Rows[0]["mtod_initdhour"]);
                endHour = Convert.ToDateTime(DS.Tables[0].Rows[0]["mtod_endhour"]);
                processValues = DS.Tables[0].Rows[0]["mtod_process"].ToString();
                processList = clsGlobal.getStringListFromString(processValues);
                pressionValues = DS.Tables[0].Rows[0]["mtod_pression"].ToString();
                pressionList = clsGlobal.getDoubleListFromString(processValues);
                notes = DS.Tables[0].Rows[0]["mtod_notes"].ToString();
                closeBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_closeby"]);
                closeUser = DS.Tables[0].Rows[0]["usr_userName"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_metalizeddetail (mtod_fkOrder, mtod_fkproductfrom,mtod_fkproductto,mtod_decrease, mtod_netweigth, mtod_grossweigth, mtod_mcode, mtod_code, mtod_initdhour, mtod_endhour, mtod_process, mtod_pression, mtod_notes, mtod_ejecuteby, mtod_closeby) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkOrder.ToString() + ", ";
                    queryString += "" + this.fkproductFrom.ToString() + ", ";
                    queryString += "" + this.fkproductTo.ToString() + ", ";
                    queryString += "" + this.decrease.ToString() + ", ";
                    queryString += "" + this.netweigth.ToString() + ", ";
                    queryString += "" + this.grossweigth.ToString() + ", ";
                    queryString += "'" + this.mcode.ToString() + "', ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "'" + this.initHour.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.endHour.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.processValues.ToString() + "', ";
                    queryString += "'" + this.pressionValues.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_metalizeddetail";
                    queryString += " SET ";
                    queryString += "mtod_fkOrder = " + this.fkOrder.ToString() + ", ";
                    queryString += "mtod_fkproductfrom = " + this.fkproductFrom.ToString() + ", ";
                    queryString += "mtod_fkproductto = " + this.fkproductTo.ToString() + ", ";
                    queryString += "mtod_decrease = " + this.decrease.ToString() + ", ";
                    queryString += "mtod_netweigth = " + this.netweigth.ToString() + ", ";
                    queryString += "mtod_grossweigth = " + this.grossweigth.ToString() + ", ";
                    queryString += "mtod_mcode = '" + this.mcode.ToString() + "', ";
                    queryString += "mtod_code = '" + this.code.ToString() + "', ";
                    queryString += "mtod_initdhour = '" + this.initHour.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "mtod_endhour = '" + this.endHour.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "mtod_process = '" + this.processValues.ToString() + "', ";
                    queryString += "mtod_pression = '" + this.pressionValues.ToString() + "', ";
                    queryString += "mtod_notes = '" + this.notes.ToString() + "', ";
                    queryString += "mtod_closeby = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mtod_codsec = " + this.codsec.ToString() + ";";
                }

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

        public static List<clsMetallizedOrderDetail> getListByOrder(int codsec)
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrderDetail> lstMetallizedOrderDetail = new List<clsMetallizedOrderDetail>();

            DS = clsConnection.getDataSetResult("spMetalizedDetailListByOrder " + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrderDetail.Add(new clsMetallizedOrderDetail());

                lstMetallizedOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_codsec"]);
                lstMetallizedOrderDetail[i].fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkOrder"]);
                lstMetallizedOrderDetail[i].Order = new clsMetallizedOrder(lstMetallizedOrderDetail[i].fkOrder);
                lstMetallizedOrderDetail[i].lstMetalizedOrder = clsMetallizedOrder.getOrderListByCodsec(lstMetallizedOrderDetail[i].fkOrder);
                //lstMetallizedOrderDetail[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductfrom"]);
                //lstMetallizedOrderDetail[i].ProductFrom = new clsProduct(lstMetallizedOrderDetail[i].fkproductFrom);
                //lstMetallizedOrderDetail[i].lstProductFrom = clsProduct.getBoppProductListByCode(lstMetallizedOrderDetail[i].ProductFrom.boppCode);
                lstMetallizedOrderDetail[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductfrom"]);
                lstMetallizedOrderDetail[i].ProductTo = new clsProduct(lstMetallizedOrderDetail[i].fkproductTo);
                lstMetallizedOrderDetail[i].lstProductFrom = clsProduct.getBoppProductListByCode(lstMetallizedOrderDetail[i].ProductTo.boppCode);
                lstMetallizedOrderDetail[i].decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_decrease"]);
                lstMetallizedOrderDetail[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_netweigth"]);
                lstMetallizedOrderDetail[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_grossweigth"]);
                lstMetallizedOrderDetail[i].code = DS.Tables[0].Rows[0]["mtod_code"].ToString();
                lstMetallizedOrderDetail[i].initHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_initdhour"]);
                lstMetallizedOrderDetail[i].endHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_endhour"]);
                lstMetallizedOrderDetail[i].processValues = DS.Tables[0].Rows[i]["mtod_process"].ToString();
                lstMetallizedOrderDetail[i].processList = clsGlobal.getStringListFromString(lstMetallizedOrderDetail[i].processValues);
                lstMetallizedOrderDetail[i].pressionValues = DS.Tables[0].Rows[i]["mtod_process"].ToString();
                lstMetallizedOrderDetail[i].pressionList = clsGlobal.getDoubleListFromString(lstMetallizedOrderDetail[i].pressionValues);
                lstMetallizedOrderDetail[i].notes = DS.Tables[0].Rows[i]["mtod_notes"].ToString();
                lstMetallizedOrderDetail[i].closeBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_closeby"]);
                lstMetallizedOrderDetail[i].closeUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
            }

            return lstMetallizedOrderDetail;
        }

        public static clsMetallizedOrderDetail getListByOrder(int codsec, bool data)
        {
            DataSet DS = new DataSet();

            clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();

            DS = clsConnection.getDataSetResult("spMetalizedDetailListByOrder " + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                ObjMetalizedOrderDetail.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_codsec"]);
                ObjMetalizedOrderDetail.fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkOrder"]);
                ObjMetalizedOrderDetail.Order = new clsMetallizedOrder(ObjMetalizedOrderDetail.fkOrder);
                ObjMetalizedOrderDetail.lstMetalizedOrder = clsMetallizedOrder.getOrderListByCodsec(ObjMetalizedOrderDetail.fkOrder);
                ObjMetalizedOrderDetail.fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductfrom"]);
                //ObjMetalizedOrderDetail.ProductFrom = new clsProduct(ObjMetalizedOrderDetail.fkproductFrom);
                //ObjMetalizedOrderDetail.lstProductFrom = clsProduct.getBoppProductListByCode(ObjMetalizedOrderDetail.ProductFrom.boppCode);
                ObjMetalizedOrderDetail.fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductto"]);
                ObjMetalizedOrderDetail.ProductTo = new clsProduct(ObjMetalizedOrderDetail.fkproductTo);
                //ObjMetalizedOrderDetail.lstProductTo = (ObjMetalizedOrderDetail.fkproductTo == 0) ? lstProductTo : clsProduct.getBoppProductListByCode(ObjMetalizedOrderDetail.ProductTo.code);
                ObjMetalizedOrderDetail.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_decrease"]);
                ObjMetalizedOrderDetail.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_netweigth"]);
                ObjMetalizedOrderDetail.grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_grossweigth"]);
                ObjMetalizedOrderDetail.code = DS.Tables[0].Rows[0]["mtod_code"].ToString();
                ObjMetalizedOrderDetail.mcode = DS.Tables[0].Rows[0]["mtod_mcode"].ToString();
                ObjMetalizedOrderDetail.initHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_initdhour"]);
                ObjMetalizedOrderDetail.endHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_endhour"]);
                ObjMetalizedOrderDetail.processValues = DS.Tables[0].Rows[i]["mtod_process"].ToString();
                ObjMetalizedOrderDetail.processList = clsGlobal.getStringListFromString(ObjMetalizedOrderDetail.processValues);
                ObjMetalizedOrderDetail.pressionValues = DS.Tables[0].Rows[i]["mtod_pression"].ToString();
                ObjMetalizedOrderDetail.pressionList = clsGlobal.getDoubleListFromString(ObjMetalizedOrderDetail.pressionValues);
                ObjMetalizedOrderDetail.notes = DS.Tables[0].Rows[i]["mtod_notes"].ToString();
                ObjMetalizedOrderDetail.closeBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_closeby"]);
                ObjMetalizedOrderDetail.closeUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
            }
            return ObjMetalizedOrderDetail;
        }


        public static bool getCoilByCode(int codsec)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT mtod_codsec FROM bps_prod_metalizeddetail WHERE mtod_fkproductfrom = " + codsec.ToString());

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

        public static bool toDeleteCoil(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizeddetail";
                queryString += " SET ";
                queryString += "mtod_fkproductfrom = 0 , ";
                queryString += "mtod_fkproductto = 0 , ";
                queryString += "mtod_decrease = 0 , ";
                queryString += "mtod_netweigth = 0 , ";
                queryString += "mtod_grossweigth = 0 , ";
                queryString += "mtod_mcode = '' , ";
                queryString += "mtod_code = '' , ";
                queryString += "mtod_closeby = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mtod_fkOrder = " + codsec.ToString() + ";";

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

        public static clsMetallizedOrderDetail getDeatilByCode(string code)
        {
            DataSet DS = new DataSet();

            clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();

            DS = clsConnection.getDataSetResult("spMetalizeDetailMultiple '" + code + "', 'MetalizedMaquile'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                ObjMetalizedOrderDetail.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_codsec"]);
                ObjMetalizedOrderDetail.fkmaquile = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                ObjMetalizedOrderDetail.code = DS.Tables[0].Rows[i]["mtod_code"].ToString();
                ObjMetalizedOrderDetail.productFromName = DS.Tables[0].Rows[i]["ProductFrom"].ToString();
                ObjMetalizedOrderDetail.productToName = DS.Tables[0].Rows[i]["ProductTo"].ToString();
                ObjMetalizedOrderDetail.customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                ObjMetalizedOrderDetail.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_netweigth"]);

                //ObjMetalizedOrderDetail.fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkOrder"]);
                //ObjMetalizedOrderDetail.Order = new clsMetallizedOrder(ObjMetalizedOrderDetail.fkOrder);
                //ObjMetalizedOrderDetail.lstMetalizedOrder = clsMetallizedOrder.getOrderListByCodsec(ObjMetalizedOrderDetail.fkOrder);
                //ObjMetalizedOrderDetail.fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductfrom"]);
                ////ObjMetalizedOrderDetail.ProductFrom = new clsProduct(ObjMetalizedOrderDetail.fkproductFrom);
                ////ObjMetalizedOrderDetail.lstProductFrom = clsProduct.getBoppProductListByCode(ObjMetalizedOrderDetail.ProductFrom.boppCode);
                //ObjMetalizedOrderDetail.fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mtod_fkproductto"]);
                //ObjMetalizedOrderDetail.ProductTo = new clsProduct(ObjMetalizedOrderDetail.fkproductTo);
                ////ObjMetalizedOrderDetail.lstProductTo = (ObjMetalizedOrderDetail.fkproductTo == 0) ? lstProductTo : clsProduct.getBoppProductListByCode(ObjMetalizedOrderDetail.ProductTo.code);
                //ObjMetalizedOrderDetail.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_decrease"]);
                
                //ObjMetalizedOrderDetail.grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mtod_grossweigth"]);
                //ObjMetalizedOrderDetail.code = DS.Tables[0].Rows[0]["mtod_code"].ToString();
                //ObjMetalizedOrderDetail.mcode = DS.Tables[0].Rows[0]["mtod_mcode"].ToString();
                //ObjMetalizedOrderDetail.initHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_initdhour"]);
                //ObjMetalizedOrderDetail.endHour = Convert.ToDateTime(DS.Tables[0].Rows[i]["mtod_endhour"]);
                //ObjMetalizedOrderDetail.processValues = DS.Tables[0].Rows[i]["mtod_process"].ToString();
                //ObjMetalizedOrderDetail.processList = clsGlobal.getStringListFromString(ObjMetalizedOrderDetail.processValues);
                //ObjMetalizedOrderDetail.pressionValues = DS.Tables[0].Rows[i]["mtod_pression"].ToString();
                //ObjMetalizedOrderDetail.pressionList = clsGlobal.getDoubleListFromString(ObjMetalizedOrderDetail.pressionValues);
                //ObjMetalizedOrderDetail.notes = DS.Tables[0].Rows[i]["mtod_notes"].ToString();
                //ObjMetalizedOrderDetail.closeBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_closeby"]);
                //ObjMetalizedOrderDetail.closeUser = DS.Tables[0].Rows[i]["usr_userName"].ToString();
            }
            return ObjMetalizedOrderDetail;
        }

        //public static bool toCrossOrder(int codsec)
        //{
        //    try
        //    {
        //        string queryString = "";

        //        queryString += "UPDATE bps_prod_metalizedorder";
        //        queryString += " SET ";
        //        queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Anulada").codsec.ToString() + ", ";
        //        queryString += "mto_modifiedDate = " + "NOW()" + ", ";
        //        queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
        //        queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

        //        clsConnection.executeQuery("DELETE bps_prod_metalizepersalesorderdetail WHERE mtosod_fkMetailizeOrder = " + codsec.ToString());

        //        if (clsConnection.executeQuery(queryString))
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
        //        return false;
        //    }
        //}

        //public static bool toProcessOrder(int codsec)
        //{
        //    try
        //    {
        //        string queryString = "";

        //        queryString += "UPDATE bps_prod_metalizedorder";
        //        queryString += " SET ";
        //        queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Proceso").codsec.ToString() + ", ";
        //        queryString += "mto_modifiedDate = " + "NOW()" + ", ";
        //        queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
        //        queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

        //        if (clsConnection.executeQuery(queryString))
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
        //        return false;
        //    }
        //}

        //public static List<clsMetallizedOrder> getActiveOrderList()
        //{
        //    DataSet DS = new DataSet();

        //    List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

        //    DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizedorder WHERE mto_fkStatus = 46");

        //    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //    {
        //        lstMetallizedOrder.Add(new clsMetallizedOrder());

        //        lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
        //        lstMetallizedOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkMachine"]);
        //        lstMetallizedOrder[i].MachineName = DS.Tables[0].Rows[i]["mto_MachineName"].ToString();
        //        lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
        //        lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
        //        lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
        //        lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
        //        lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
        //        lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();
        //        lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
        //        lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
        //        lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();
        //        lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
        //        lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
        //        lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);
        //        lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
        //        lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
        //        lstMetallizedOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_createdDate"]);
        //        lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
        //        lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
        //        lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
        //        lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
        //        lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
        //    }

        //    return lstMetallizedOrder;
        //}

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mtod_codsec FROM bps_prod_metalizeddetail ORDER BY mtod_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mtod_codsec"]);
        }

        public static bool isUnique(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mtod_code FROM bps_prod_metalizeddetail WHERE mtod_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        public static bool wasMetalized(int codsecMaquile)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mtod_code FROM bps_prod_metalizeddetail WHERE mtod_fkproductfrom = " + codsecMaquile.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        //public static List<clsMetallizedOrder> getActiveOrderListSummary()
        //{
        //    DataSet DS = new DataSet();

        //    List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

        //    DS = clsConnection.getDataSetResult("spMetalizeOrderList");

        //    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //    {
        //        lstMetallizedOrder.Add(new clsMetallizedOrder());
        //        lstMetallizedOrder[i].customerfrom = DS.Tables[0].Rows[i]["customerFrom"].ToString();
        //        lstMetallizedOrder[i].customerto = DS.Tables[0].Rows[i]["customerTo"].ToString();
        //        lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
        //        lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
        //        lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
        //        lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
        //        lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
        //        lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["mto_lotnumber"].ToString();
        //        lstMetallizedOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateinitdate"]);
        //        lstMetallizedOrder[i].widthFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductFromWidth"]);
        //        lstMetallizedOrder[i].widthTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductToWidth"]);
        //        lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
        //        lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
                
        //        //lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
        //        //lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
        //        //lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
        //        //lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
        //        //lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();
                
        //        //lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
        //        //lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();
                
                
        //        //lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);
                
        //        //lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
               
        //        //lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
        //        //lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
        //        //lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
        //        //lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
        //        //lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
        //    }

        //    return lstMetallizedOrder;
        //}

        //public static List<clsMetallizedOrder> getActiveOrderListByOrderDate(DateTime date)
        //{
        //    DataSet DS = new DataSet();

        //    List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

        //    DS = clsConnection.getDataSetResult("spMetalizeOrderByDate'" + date.ToString("dd/MM/yyyy HH:mm:ss") + "'");

        //    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //    {
        //        lstMetallizedOrder.Add(new clsMetallizedOrder());

        //        lstMetallizedOrder[i].ordenation = DS.Tables[0].Rows[i]["mto_ordenation"].ToString();
        //        lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
        //        lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["mto_lotnumber"].ToString();
        //        lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
        //        lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
        //        lstMetallizedOrder[i].widthFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductFromWidth"]);
        //        lstMetallizedOrder[i].widthTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductToWidth"]);
        //        lstMetallizedOrder[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_totalweigth"]);
        //        lstMetallizedOrder[i].kg = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_kg"]);
        //        lstMetallizedOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateinitdate"]);
        //        lstMetallizedOrder[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateenddate"]);
        //        lstMetallizedOrder[i].customerto = DS.Tables[0].Rows[i]["customerlistTo"].ToString();
                
                
        //        //lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
        //        //lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
                
                
                

        //        //lstMetallizedOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkMachine"]);
        //        //lstMetallizedOrder[i].MachineName = DS.Tables[0].Rows[i]["mto_MachineName"].ToString();

        //        //lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_BoppFrom"].ToString();
        //        //lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_BoppTo"].ToString();
        //        //lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
        //        //lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
        //        //lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
        //        //lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();

        //        //lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
        //        //lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();


        //        //lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);

        //        //lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();

        //        //lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
        //        //lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
        //        //lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
        //        //lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
        //        //lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
        //    }

        //    return lstMetallizedOrder;
        //}
    }
}
