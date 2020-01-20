using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRawMaterialbyCoilCellar : IComparable<clsRawMaterialbyCoilCellar>
    {
        internal struct stcWeigthCellar
        {
            public string cellar { get; set; }
            public double weigth { get; set; }
        }

        //Attributes
        private int rwmc_codsec;
        private int rwmc_fkStatus;
        private int rwmc_fkrawmaterial;
        private string rwmc_rawmaterialproduct;
        private string rwmc_lotnumber;
        private string siigocellar;
        private string siigomovement;
        private int rwmc_bag;
        private bool rwmc_in;
        private bool rwmc_out;
        private bool rwmc_devolution;
        private string rwmc_code;
        private double rwmc_netweigth;
        private double rwmc_grossweigth;
        private double rwmc_palletweigth;
        private int rwmc_order;
        private string rwmc_provider;
        private DateTime rwmc_date;
        private string rwmc_movement;
        private bool rwmc_isImport;
        private double rwmc_density;
        private string rwmc_millName;
        private int rwmc_fkProduct;
        private string rwmc_productName;
        private string rwmc_notes;


        private DateTime plt_createDate;
        private bool rwmc_wasExportedToSystem;

        private clsProduct rwmc_Product;
        private string siigocode;
        private string siigoreference;
        private double rwmc_width;

        //Properties
        public int codsec { get { return rwmc_codsec; } set { rwmc_codsec = value; } }

        public int fkStatus { get { return rwmc_fkStatus; } set { rwmc_fkStatus = value; } }

        public int fkrawmaterial { get { return rwmc_fkrawmaterial; } set { rwmc_fkrawmaterial = value; } }

        public string product { get { return rwmc_rawmaterialproduct; } set { rwmc_rawmaterialproduct = value; } }

        public string lotnumber { get { return rwmc_lotnumber; } set { rwmc_lotnumber = value; } }

        public string siigoCellar { get { return siigocellar; } set { siigocellar = value; } }

        public string siigoMovement { get { return siigomovement; } set { siigomovement = value; } }

        public int bag { get { return rwmc_bag; } set { rwmc_bag = value; } }

        public bool ingress { get { return rwmc_in; } set { rwmc_in = value; } }

        public bool output { get { return rwmc_out; } set { rwmc_out = value; } }

        public bool devolution { get { return rwmc_devolution; } set { rwmc_devolution = value; } }

        public string code { get { return rwmc_code; } set { rwmc_code = value; } }

        public double netweigth { get { return rwmc_netweigth; } set { rwmc_netweigth = value; } }

        public double grossweigth { get { return rwmc_grossweigth; } set { rwmc_grossweigth = value; } }

        public double palletweigth { get { return rwmc_palletweigth; } set { rwmc_palletweigth = value; } }

        public int order { get { return rwmc_order; } set { rwmc_order = value; } }

        public string provider { get { return rwmc_provider; } set { rwmc_provider = value; } }

        public DateTime date { get { return rwmc_date; } set { rwmc_date = value; } }

        public string movement { get { return rwmc_movement; } set { rwmc_movement = value; } }

        public bool isImport { get { return rwmc_isImport; } set { rwmc_isImport = value; } }

        public double density { get { return rwmc_density; } set { rwmc_density = value; } }

        public int fkProduct { get { return rwmc_fkProduct; } set { rwmc_fkProduct = value; } }

        public string productName { get { return rwmc_productName; } set { rwmc_productName = value; } }

        public string notes { get { return rwmc_notes; } set { rwmc_notes = value; } }

        public double width { get { return rwmc_width; } set { rwmc_width = value; } }

        public DateTime createdate { get { return plt_createDate; } set { plt_createDate = value; } }

        public bool wasExportedToSystem { get { return rwmc_wasExportedToSystem; } set { rwmc_wasExportedToSystem = value; } }

        public string millName { get { return rwmc_millName; } set { rwmc_millName = value; } }

        public clsProduct ObjProduct { get { return rwmc_Product; } set { rwmc_Product = value; } }

        public string siigoCode { get { return siigocode; } set { siigocode = value; } }

        public string siigoReference { get { return siigoreference; } set { siigoreference = value; } }

        public bool isPending { get; set; }


        //Constructor
        public clsRawMaterialbyCoilCellar()
        {
            rwmc_codsec = 0;
            rwmc_fkrawmaterial = 0;
            rwmc_in = false;
            rwmc_out = false;
            rwmc_devolution = false;
            rwmc_date = DateTime.Now;
            rwmc_movement = string.Empty;
            rwmc_code = string.Empty;
            rwmc_rawmaterialproduct = string.Empty;
            rwmc_lotnumber = string.Empty;
            rwmc_density = 0;
            rwmc_fkStatus = 0;
            rwmc_provider = string.Empty;
            rwmc_order = 0;
            rwmc_width = 0;
            rwmc_palletweigth = 0;
            rwmc_grossweigth = 0;
            rwmc_netweigth = 0;
            plt_createDate = DateTime.Now;
            rwmc_wasExportedToSystem = false;
            rwmc_notes = string.Empty;
            rwmc_fkProduct = 0;
            rwmc_bag = 0;
            rwmc_Product = new clsProduct();

            //Filter
            rwmc_millName = string.Empty;
            rwmc_productName = string.Empty;

            siigocellar = string.Empty;
            siigomovement = string.Empty;
            siigocode = string.Empty;
            siigoreference = string.Empty;

            rwmc_isImport = false;
        }

        //public clsRawMaterialbyCoilCellar(int codsec)
        //{
        //    loadByMillPallet(codsec);
        //}

        public clsRawMaterialbyCoilCellar(string code, bool ingress, bool output, bool devolution)
        {
            LoaderIngress(code, ingress, output, devolution);
        }

        public clsRawMaterialbyCoilCellar(int codsec)
        {
            load(codsec);
        }

        private void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbycoilcellar WHERE rwmc_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkStatus"]);
                fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"]);
                product = DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString();
                lotnumber = DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["rwmc_cellarsiigo"].ToString();
                siigoMovement = DS.Tables[0].Rows[0]["rwmc_movementsiigo"].ToString();
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_bag"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_in"], DS.Tables[0].Rows[0]["rwmc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_out"], DS.Tables[0].Rows[0]["rwmc_out"].GetType().FullName);
                devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_devolution"], DS.Tables[0].Rows[0]["rwmc_devolution"].GetType().FullName);
                code = DS.Tables[0].Rows[0]["rwmc_code"].ToString().ToUpper();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_grossweigth"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_order"]);
                provider = DS.Tables[0].Rows[0]["rwmc_provider"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwmc_date"]);
                movement = DS.Tables[0].Rows[0]["rwmc_movement"].ToString();
                notes = DS.Tables[0].Rows[0]["rwmc_notes"].ToString();
                isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isImport"], DS.Tables[0].Rows[0]["rwmc_isImport"].GetType().FullName);
                isLastM = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isLastM"], DS.Tables[0].Rows[0]["rwmc_isLastM"].GetType().FullName);
                isPending = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isPending"], DS.Tables[0].Rows[0]["rwmc_isPending"].GetType().FullName);
                isReProcess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isReProcess"], DS.Tables[0].Rows[0]["rwmc_isReProcess"].GetType().FullName);
                fkOrigin = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkOrigin"]);
            }
        }

        private void LoaderIngress(string code, bool ingress, bool output, bool devolution)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbycoilcellar WHERE rwmc_code = '" + code.ToUpper() + "' AND rwmc_in =" + ingress.ToString() + " AND rwmc_out = 0 AND rwmc_devolution = 0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkStatus"]);
                fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"]);
                product = DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString();
                lotnumber = DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["rwmc_cellarsiigo"].ToString();
                siigoMovement = DS.Tables[0].Rows[0]["rwmc_movementsiigo"].ToString();
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_bag"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_in"], DS.Tables[0].Rows[0]["rwmc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_out"], DS.Tables[0].Rows[0]["rwmc_out"].GetType().FullName);
                devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_devolution"], DS.Tables[0].Rows[0]["rwmc_devolution"].GetType().FullName);
                code = DS.Tables[0].Rows[0]["rwmc_code"].ToString().ToUpper();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_grossweigth"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_order"]);
                provider = DS.Tables[0].Rows[0]["rwmc_provider"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwmc_date"]);
                movement = DS.Tables[0].Rows[0]["rwmc_movement"].ToString();
                notes = DS.Tables[0].Rows[0]["rwmc_notes"].ToString();
                isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isImport"], DS.Tables[0].Rows[0]["rwmc_isImport"].GetType().FullName);
            }
        }

        public int CompareTo(clsRawMaterialbyCoilCellar b)
        {
            if (this.grossweigth > b.grossweigth)
            {
                return this.grossweigth.CompareTo(b.grossweigth);
            }
            return this.product.CompareTo(b.product);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkrawmaterial.ToString() + ", ";
                    queryString += "'" + this.product + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.provider + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.isImport.ToString() + " ";
                    queryString += ");";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return false;
            }
        }

        public bool saveRePro()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, ";
                    queryString += "rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, ";
                    queryString += "rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport, rwmc_isLastM, rwmc_isPending, rwmc_isReProcess, rwmc_fkOrigin)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkrawmaterial.ToString() + ", ";
                    queryString += "'" + this.product + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.provider + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.isImport.ToString() + ", ";
                    queryString += "" + this.isLastM.ToString() + ", ";
                    queryString += "" + this.isPending.ToString() + ", ";
                    queryString += "" + this.isReProcess.ToString() + ", ";
                    queryString += "" + this.fkOrigin.ToString() + " ";
                    queryString += ");";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return false;
            }
        }

        public bool saveReProRMP(string product)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, ";
                    queryString += "rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, ";
                    queryString += "rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport, rwmc_isLastM, rwmc_isPending, rwmc_isReProcess, rwmc_fkOrigin)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkrawmaterial.ToString() + ", ";
                    queryString += "'" + product + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.provider + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.isImport.ToString() + ", ";
                    queryString += "" + this.isLastM.ToString() + ", ";
                    queryString += "" + this.isPending.ToString() + ", ";
                    queryString += "" + this.isReProcess.ToString() + ", ";
                    queryString += "" + this.fkOrigin.ToString() + " ";
                    queryString += ");";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return false;
            }
        }

        public int saveRePro(string code, string product)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, ";
                    queryString += "rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, ";
                    queryString += "rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport, rwmc_isLastM, rwmc_isPending, rwmc_isReProcess, rwmc_fkOrigin)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkrawmaterial.ToString() + ", ";
                    queryString += "'" + product + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.provider + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.isImport.ToString() + ", ";
                    queryString += "" + this.isLastM.ToString() + ", ";
                    queryString += "" + this.isPending.ToString() + ", ";
                    queryString += "" + this.isReProcess.ToString() + ", ";
                    queryString += "" + this.fkOrigin.ToString() + " ";
                    queryString += ");";
                }

                if (clsConnection.executeQuery(queryString))
                    return clsRawMaterialbyCoilCellar.getLastCodsecByCode(code);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private static int getLastCodsecByCode(string code)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(rwmc_codsec) as codsec FROM bps_prod_rawmaterialbycoilcellar WHERE rwmc_code = '" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(rwmc_codsec) as codsec FROM bps_prod_rawmaterialbycoilcellar");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        public bool saveR()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport, rwmc_isPending)";
                    queryString += " VALUES (";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkrawmaterial.ToString() + ", ";
                    queryString += "'" + this.product + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += "'" + this.siigoCellar + "', ";
                    queryString += "'" + this.siigoMovement + "', ";
                    queryString += this.bag.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += this.devolution.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.order.ToString() + ", ";
                    queryString += "'" + this.provider + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "" + this.isImport.ToString() + ", ";
                    queryString += "" + this.isPending.ToString() + " ";
                    queryString += ");";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbyCoilCellar.save");
                return false;
            }
        }

        public bool toUpdateData()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET rwmc_fkrawmaterial = " + this.fkrawmaterial + ", ";
                queryString += "rwmc_rawmaterialproduct = ' " + this.product.ToString() + "', ";
                queryString += "rwmc_lotnumber = ' " + this.lotnumber.ToString() + "', ";
                queryString += "rwmc_bag =  " + this.bag.ToString() + ",";
                queryString += "rwmc_neetweigth =  " + this.netweigth.ToString() + ",";
                queryString += "rwmc_grossweigth =  " + this.grossweigth.ToString() + ",";
                queryString += "rwmc_provider = ' " + this.provider.ToString() + "' ";
                queryString += "WHERE rwmc_codsec = " + this.codsec.ToString();

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

        public static bool setTransferM(string codsecRW)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET ";
            queryString += "rwmc_isLastM = 0";
            queryString += " WHERE rwmc_codsec = " + codsecRW + ";";

            return clsConnection.executeQuery(queryString);
        }

        public static bool setTransferMR(string codsecRW)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET ";
            queryString += "rwmc_isPending = 0";
            queryString += " WHERE rwmc_codsec = " + codsecRW + ";";

            return clsConnection.executeQuery(queryString);
        }

        public static bool setTransferMRP(string codsecRW)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET ";
            queryString += "rwmc_isPending = 0,";
            queryString += "rwmc_isLastM = 0";
            queryString += " WHERE rwmc_codsec = " + codsecRW + ";";

            return clsConnection.executeQuery(queryString);
        }

        public static bool siloMaterialValidation(string rwcod, string silo)
        {
            bool result = false;

            DataSet DS2 = new DataSet();

            DS2 = clsConnection.getDataSetResult("CALL spRawMaterialBySilo (" + silo +")");

            if (DS2.Tables[0].Rows.Count > 0)
            {
                if (DS2.Tables[0].Rows[0]["materialname"].ToString() == rwcod)
                {
                    result = true; 
                }
            }
             

            return result;
        }

        public static bool setTransfer(string codsecRW, string outString, string movementSiigo)
        {
            bool result = false;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawCodsec'," + codsecRW + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");


            if (DS.Tables[0].Rows.Count > 0)
            {
                string queryString = "";

                if (movementSiigo == "1" || movementSiigo == "2" || movementSiigo == "3" || movementSiigo == "4" || movementSiigo == "5" || movementSiigo == "6" || movementSiigo == "7" || movementSiigo == "8")
                {
                    

                    DataSet DS2 = new DataSet();

                    DS2 = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbysilo WHERE rwbs_fksilo = " + movementSiigo);

                    if (DS2.Tables[0].Rows.Count > 0)
                    {
                        if (!DS2.Tables[0].Rows[0]["rwbs_fkrawcodsec"].Equals(DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"]))
                        {
                            queryString = "";

                            queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET ";
                            queryString += "rwmc_isLastM = 1";
                            queryString += " WHERE rwmc_codsec = " + codsecRW + ";";

                            clsConnection.executeQuery(queryString);

                            return false;
                        }
                    }
                }

                queryString += "INSERT INTO bps_prod_rawmaterialbycoilcellar (rwmc_fkStatus, rwmc_fkrawmaterial, rwmc_rawmaterialproduct, rwmc_lotnumber, rwmc_cellarsiigo, rwmc_movementsiigo, rwmc_bag, rwmc_in, rwmc_out, rwmc_devolution, rwmc_code, rwmc_neetweigth, rwmc_grossweigth, rwmc_order, rwmc_provider, rwmc_date, rwmc_movement, rwmc_notes, rwmc_isImport, rwmc_isPending, rwmc_isLastM)";
                queryString += " VALUES (";
                queryString += getStatus(outString) + ", ";
                queryString += DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"].ToString() + ", ";
                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString() + "', ";
                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString() + "', ";
                queryString += "'" + getCellarSiigo(movementSiigo) + "', ";
                queryString += "'" + movementSiigo + "', ";
                queryString += DS.Tables[0].Rows[0]["rwmc_bag"].ToString() + ", ";
                queryString += "0, ";
                queryString += "1, ";
                queryString += "0, ";
                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_code"].ToString() + "', ";
                queryString += DS.Tables[0].Rows[0]["rwmc_neetweigth"].ToString() + ", ";
                queryString += DS.Tables[0].Rows[0]["rwmc_grossweigth"].ToString() + ", ";
                queryString += DS.Tables[0].Rows[0]["rwmc_order"].ToString() + ", ";
                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_provider"].ToString() + "', ";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "'" + outString + "', ";
                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_notes"].ToString() + "', ";
                queryString += "0, ";
                queryString += "1, ";
                queryString += "1);";

                if (clsConnection.executeQuery(queryString))
                {
                    if (outString == "Salida de Materia Prima DMT")
                    {
                        //Agregar datos para extrusión
                        var fkRaw = clsRawMaterialbyCoilCellar.getLastCodsec();

                        queryString = "";

                        queryString += "INSERT INTO bps_prod_rawmaterialextruder (rw_fkRaw, rw_fkMaterial, rw_lotnumber, rw_bag, rw_code, rw_netweigth, rw_date)";
                        queryString += " VALUES (";
                        queryString += fkRaw.ToString() + ", ";
                        queryString += DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"].ToString() + ", ";
                        queryString += "'" + DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString() + "', ";
                        queryString += DS.Tables[0].Rows[0]["rwmc_bag"].ToString() + ", ";
                        queryString += "'" + DS.Tables[0].Rows[0]["rwmc_code"].ToString() + "', ";
                        queryString += DS.Tables[0].Rows[0]["rwmc_neetweigth"].ToString() + ", ";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "');";

                        return clsConnection.executeQuery(queryString);
                    }
                    else
                    {

                        if (movementSiigo == "1" || movementSiigo == "2" || movementSiigo == "3" || movementSiigo == "4" || movementSiigo == "5" || movementSiigo == "6" || movementSiigo == "7" || movementSiigo == "8")
                            
                        {

                            DataSet DS2 = new DataSet();

                            DS2 = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbysilo WHERE rwbs_fksilo = " + movementSiigo);

                            if (DS2.Tables[0].Rows.Count > 0)
                            {
                                queryString = "";
                                Double totalWe = Convert.ToDouble(DS2.Tables[0].Rows[0]["rwbs_weigth"]) + Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                                queryString += "UPDATE bps_prod_rawmaterialbysilo SET ";
                                queryString += "rwbs_weigth = " + totalWe.ToString();
                                queryString += " WHERE rwbs_fksilo = " + movementSiigo + ";";

                                return clsConnection.executeQuery(queryString);
                            }
                            else
                            {
                                queryString = "";

                                queryString += "INSERT INTO bps_prod_rawmaterialbysilo (rwbs_fkrawcodsec, rwbs_rawmaterialname, rwbs_weigth, rwbs_fksilo)";
                                queryString += " VALUES (";
                                queryString += DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"].ToString() + ", ";
                                queryString += "'" + DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString() + "', ";
                                queryString += DS.Tables[0].Rows[0]["rwmc_neetweigth"].ToString() + ", ";
                                queryString += Convert.ToInt32(movementSiigo);
                                queryString += ");";

                                return clsConnection.executeQuery(queryString);
                            }
                            
                        }
                       

                    }

                }
                else
                    return false;

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return result;
        }

        private static string getStatus(string outString)
        {
            string result = "";

            if (outString == "Salida de Materia Prima Calderón - Consumo")
                result = "1113";
            else if (outString == "Salida de Materia Prima Ventas MP - Consumo")
                result = "1099";
            else if (outString == "Salida de Materia Prima Devolución Proveedor - Consumo")
                result = "1114";
            else if (outString == "Salida de Materia Prima Calderón - Dep Ind")
                result = "1115";
            else if (outString.StartsWith("Salida de Materia Prima"))
                result = "1097";

            return result;

        }

        private static string getCellarSiigo(string movementSiigo)
        {
            string value = "";

            if (movementSiigo.ToUpper() == "H016")
                value = "001";
            else if (movementSiigo.ToUpper() == "H004")
                value = "001";
            else if (movementSiigo.ToUpper() == "H018")
                value = "001";
            else if (movementSiigo.ToUpper() == "H017")
                value = "001";
            else if (movementSiigo.ToUpper() == "H005")
                value = "001";
            else if (movementSiigo.ToUpper() == "S019")
                value = "001";
            else if (movementSiigo.ToUpper() == "S021")
                value = "001";
            else if (movementSiigo.ToUpper() == "H001")
                value = "004";
            else if (movementSiigo.ToUpper() == "H003")
                value = "004";
            else if (movementSiigo.ToUpper() == "H006")
                value = "004";
            else if (movementSiigo.ToUpper() == "H007")
                value = "004";

            return value;
        }

        public static List<clsRawMaterialbyCoilCellar> getMovementListByDate(DateTime initdate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawMList',0,'','" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "','" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() != "H017" || DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() != "S019" ||
                        DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() != "S021" || DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() != "H006")
                    {
                        rawMList.Add(new clsRawMaterialbyCoilCellar());
                        int pos = rawMList.Count - 1;
                        rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                        rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                        rawMList[pos].fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkrawmaterial"]);
                        rawMList[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_in"], DS.Tables[0].Rows[i]["rwmc_in"].GetType().FullName);
                        rawMList[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_out"], DS.Tables[0].Rows[i]["rwmc_out"].GetType().FullName);
                        rawMList[pos].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_devolution"], DS.Tables[0].Rows[i]["rwmc_devolution"].GetType().FullName);
                        rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                        rawMList[pos].movement = DS.Tables[0].Rows[i]["rwmc_movement"].ToString();
                        rawMList[pos].product = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                        rawMList[pos].productName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                        rawMList[pos].plbg = DS.Tables[0].Rows[i]["rwmc_order"].ToString() + "-" + DS.Tables[0].Rows[i]["rwmc_bag"].ToString();
                        rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["rwmc_cellarsiigo"].ToString().Replace("0", "");
                        rawMList[pos].siigoMovement = DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString().Replace("0", "");
                        rawMList[pos].siigoReference = DS.Tables[0].Rows[i]["rwmc_siiigoId"].ToString();
                        rawMList[pos].siigoCode = DS.Tables[0].Rows[i]["rwmc_siiigoCode"].ToString();
                        //rawMList[pos].bag = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_bag"]);
                        //rawMList[pos].order = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_order"]);
                    }
                }
            }

            return rawMList;
        }

        public static List<clsRawMaterialbyCoilCellar> getMovementListByDateShip(DateTime initdate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawMList',0,'','" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "','" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() == "H017" || DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() == "S019" ||
                        DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() == "S021" || DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString() == "H006")
                    {
                        rawMList.Add(new clsRawMaterialbyCoilCellar());
                        int pos = rawMList.Count - 1;
                        rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                        rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                        rawMList[pos].fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkrawmaterial"]);
                        rawMList[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_in"], DS.Tables[0].Rows[i]["rwmc_in"].GetType().FullName);
                        rawMList[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_out"], DS.Tables[0].Rows[i]["rwmc_out"].GetType().FullName);
                        rawMList[pos].devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_devolution"], DS.Tables[0].Rows[i]["rwmc_devolution"].GetType().FullName);
                        rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                        rawMList[pos].movement = DS.Tables[0].Rows[i]["rwmc_movement"].ToString();
                        rawMList[pos].product = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                        rawMList[pos].productName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                        rawMList[pos].plbg = DS.Tables[0].Rows[i]["rwmc_order"].ToString() + "-" + DS.Tables[0].Rows[i]["rwmc_bag"].ToString();
                        rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["rwmc_cellarsiigo"].ToString().Replace("0", "");
                        rawMList[pos].siigoMovement = DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString().Replace("0", "");
                        rawMList[pos].siigoReference = DS.Tables[0].Rows[i]["rwmc_siiigoId"].ToString();
                        rawMList[pos].siigoCode = DS.Tables[0].Rows[i]["rwmc_siiigoCode"].ToString();
                    }
                }
            }

            return rawMList;
        }

        public string plbg { get; set; }

        internal static List<clsRawMaterialbyCoilCellar> getListToList(List<string> rawListCodsec)
        {
            string codeF = "";
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();

            foreach (var item in rawListCodsec)
            {
                codeF += item + ";";
            }

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawMEXPList',0,'" + codeF + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawMList.Add(new clsRawMaterialbyCoilCellar());
                    int pos = rawMList.Count - 1;

                    rawMList[pos].documentType = DS.Tables[0].Rows[i]["documentType"].ToString();
                    rawMList[pos].receiptCode = DS.Tables[0].Rows[i]["receiptCode"].ToString();
                    rawMList[pos].movementCT = DS.Tables[0].Rows[i]["movementCT"].ToString();
                    rawMList[pos].product = DS.Tables[0].Rows[i]["productCode"].ToString();
                    rawMList[pos].movement = DS.Tables[0].Rows[i]["descriptionM"].ToString();
                    rawMList[pos].movementType = DS.Tables[0].Rows[i]["movementType"].ToString();
                    rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["cellarCode"].ToString().Replace("0", "");
                    rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["dateM"].ToString());
                    rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"].ToString());
                }
            }

            return rawMList;
        }

        public string documentType { get; set; }

        public string receiptCode { get; set; }

        public string movementCT { get; set; }

        public string movementType { get; set; }

        public static List<clsRawMaterialbyCoilCellar> getListBackLoad()
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawBList',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawMList.Add(new clsRawMaterialbyCoilCellar());
                    int pos = rawMList.Count - 1;
                    rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                    rawMList[pos].product = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                    rawMList[pos].productName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                    rawMList[pos].lotnumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                    rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["rwmc_cellar"].ToString();
                    rawMList[pos].plbg = DS.Tables[0].Rows[i]["rwmc_palletbag"].ToString();
                    rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                    rawMList[pos].code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                    rawMList[pos].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                    rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                    rawMList[pos].fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkrawmaterial"]);
                }
            }

            return rawMList;
        }

        public static List<clsRawMaterialbyCoilCellar> getListBackLoadExtruder()
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawBListExtruder',0,'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawMList.Add(new clsRawMaterialbyCoilCellar());
                    int pos = rawMList.Count - 1;
                    rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                    rawMList[pos].product = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                    rawMList[pos].productName = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                    rawMList[pos].lotnumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                    rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["rwmc_cellar"].ToString();
                    rawMList[pos].plbg = DS.Tables[0].Rows[i]["rwmc_palletbag"].ToString();
                    rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                    rawMList[pos].code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                    rawMList[pos].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                    rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                    rawMList[pos].fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkrawmaterial"]);
                }
            }

            return rawMList;
        }

        public void LoadToDetail(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawCodsecDetailP'," + palletCodsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_codsec"]);
                code = DS.Tables[0].Rows[0]["rwmc_code"].ToString();
                productName = DS.Tables[0].Rows[0]["trwm_name"].ToString();
                product = DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_grossweigth"]);
                palletweigth = grossweigth - netweigth;
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_bag"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_order"]);
                lotnumber = DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString();
                notes = DS.Tables[0].Rows[0]["rwmc_notes"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["rwmc_cellar"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public void LoadToDetailF(int palletCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawCodsecDetailF'," + palletCodsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rw_codsec"]);
                code = DS.Tables[0].Rows[0]["rw_code"].ToString();
                productName = DS.Tables[0].Rows[0]["trwm_name"].ToString();
                product = DS.Tables[0].Rows[0]["rwm_name"].ToString();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rw_netweigth"]);
                lotnumber = DS.Tables[0].Rows[0]["rw_lotnumber"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public void getRawByCode(string rawCode)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawCodeD',0,'" + rawCode + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_codsec"]);
                code = DS.Tables[0].Rows[0]["rwmc_code"].ToString();
                productName = DS.Tables[0].Rows[0]["trwm_name"].ToString();
                product = DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_grossweigth"]);
                palletweigth = grossweigth - netweigth;
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_bag"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_order"]);
                lotnumber = DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString();
                notes = DS.Tables[0].Rows[0]["rwmc_notes"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["rwmc_cellar"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        public static bool setDeleteTransferMR(string codsec)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_rawmaterialbycoilcellar SET ";
            queryString += "rwmc_isPending = 1,";
            queryString += "rwmc_isLastM = 1";
            queryString += " WHERE rwmc_codsec = " + codsec + ";";

            return clsConnection.executeQuery(queryString);
        }

        public bool isLastM { get; set; }

        public bool isReProcess { get; set; }

        public int fkOrigin { get; set; }

        public static clsRawMaterialbyCoilCellar getPalletInInventory(string code)
        {
            clsRawMaterialbyCoilCellar objPallet = new clsRawMaterialbyCoilCellar();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spPalletByInventorty 'ExistRaw','" + code + "'");

            try
            {
                objPallet.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_codsec"]);
                objPallet.code = DS.Tables[0].Rows[0]["plt_code"].ToString();
                objPallet.provider = DS.Tables[0].Rows[0]["plt_prove"].ToString();
                objPallet.documentType = DS.Tables[0].Rows[0]["plt_tmp"].ToString();
                objPallet.productName = DS.Tables[0].Rows[0]["prod_prod"].ToString();
                objPallet.order = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_palletNumber"]);
                objPallet.bag = Convert.ToInt32(DS.Tables[0].Rows[0]["plt_coilcount"]);
                objPallet.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netWeigh"]);
                objPallet.notes = DS.Tables[0].Rows[0]["plt_coilCellarName"].ToString();
            }
            catch (Exception)
            {
                objPallet = new clsRawMaterialbyCoilCellar();
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static List<clsRawMaterialbyCoilCellar> getFilterList(string source, string value1, string value2)
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialbyCoilCellar> rawMList = new List<clsRawMaterialbyCoilCellar>();

            if (source == "code")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar '" + value1.ToUpper() + "',' ',' ',0,0,' ',0,0,'codeRaw'");
            else if (source == "product")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar ' ','" + value1 + "',' ',0,0,' ',0,0,'productRaw'");
            else if (source == "lot")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar ' ',' ','" + value1 + "',0,0,' ',0,0,'lotRaw'");
            else if (source == "provider")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar ' ',' ',' ',0,0,'" + value1 + "',0,0,'providerRaw'");
            else if (source == "w1")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar ' ',' ',' '," + Convert.ToDouble(value1) + ",0,' ',0,0,'w1Raw'");
            else if (source == "w2")
                DS = clsConnection.getDataSetResult("spPalletTrazabilityCellar ' ',' ',' '," + Convert.ToDouble(value1) + "," + Convert.ToDouble(value2) + ",' ',0,0,'w2Raw'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                rawMList.Add(new clsRawMaterialbyCoilCellar());
                int pos = rawMList.Count - 1;

                rawMList[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_codsec"]);
                rawMList[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmc_neetweigth"]);
                rawMList[pos].lotnumber = DS.Tables[0].Rows[i]["rwmc_lotnumber"].ToString();
                rawMList[pos].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                rawMList[pos].product = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                rawMList[pos].code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                rawMList[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["rwmc_date"]);
                rawMList[pos].movement = DS.Tables[0].Rows[i]["rwmc_movement"].ToString();
                rawMList[pos].siigoCellar = DS.Tables[0].Rows[i]["rwmc_cellarsiigo"].ToString();
                rawMList[pos].siigoMovement = DS.Tables[0].Rows[i]["rwmc_movementsiigo"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return rawMList;
        }
    }
}
