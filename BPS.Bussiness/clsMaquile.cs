using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las devoluciones de productos terminados 
    /// </summary>
    public class clsMaquile
    {
        //Atributes
        private int maq_codsec;
        private string maq_customer;
        private double maq_quantity;
        private string maq_note;
        private string maq_abbreviation;
        private DateTime maq_createdDate;
        private DateTime maq_modifiedDate;
        private int maq_createdBy;
        private string maq_creatorUser;
        private int maq_modifiedBy;
        private string maq_modificatorUser;
        private string maq_movement;
        private int maq_fkstatus;
        private int maq_fkfilm;
        private int maq_fkProduct;
        private string maq_cellarname;
        private string maq_cellar;
        private double maq_weigth;
        private bool maq_in;
        private bool maq_out;
        private double maq_boppweigth;
        private double maq_oppweigth;
        private string maq_code;
        private string maq_name;
        private string maq_product;
        private int maq_width;
        private int maq_diameter;
        private int maq_core;
        private int maq_coil;
        private int maq_pallet;
        private string maq_diameters;

        private string maq_reference;
        private string maq_origin;
        private string maq_movementcellar;
        private int maq_fkproductTo;
        private int maq_fkproductFrom;

        private int maq_fkExport;
        private int maq_fkProductTo;
        private int maq_fkProductFrom;
        private clsProduct maq_productoTo;
        private clsProduct maq_productofrom;

        private int maq_fkmainCoilMetal;
        private string maq_mainCoilMetalCode;

        //Properties

        public int codsec { get { return maq_codsec; } set { maq_codsec = value; } }

        public string customer { get { return maq_customer; } set { maq_customer = value; } }

        public double quantity { get { return maq_quantity; } set { maq_quantity = value; } }

        public string notes { get { return maq_note; } set { maq_note = value; } }

        public string abbreviation { get { return maq_abbreviation; } set { maq_abbreviation = value; } }

        public DateTime createdDate { get { return maq_createdDate; } set { maq_createdDate = value; } }

        public DateTime modifiedDate { get { return maq_modifiedDate; } set { maq_modifiedDate = value; } }

        public int createdBy { get { return maq_createdBy; } set { maq_createdBy = value; } }

        public string creatorUser { get { return maq_creatorUser; } set { maq_creatorUser = value; } }

        public int modifiedBy { get { return maq_modifiedBy; } set { maq_modifiedBy = value; } }

        public string modificatorUser { get { return maq_modificatorUser; } set { maq_modificatorUser = value; } }

        public int fkFilm { get { return maq_fkfilm; } set { maq_fkfilm = value; } }

        public int fkProduct { get { return maq_fkProduct; } set { maq_fkProduct = value; } }

        public int fkProductFrom { get { return maq_fkProductFrom; } set { maq_fkProductFrom = value; } }

        public int fkProductTo { get { return maq_fkProductTo; } set { maq_fkProductTo = value; } }

        public string cellar { get { return maq_cellar; } set { maq_cellar = value; } }

        public double weigth { get { return maq_weigth; } set { maq_weigth = value; } }

        public string movement { get { return maq_movement; } set { maq_movement = value; } }

        public string cellarName { get { return maq_cellarname; } set { maq_cellarname = value; } }

        public bool ingress { get { return maq_in; } set { maq_in = value; } }

        public bool outt { get { return maq_out; } set { maq_out = value; } }

        public double boppweigth { get { return maq_boppweigth; } set { maq_boppweigth = value; } }

        public double oppweigth { get { return maq_oppweigth; } set { maq_oppweigth = value; } }

        public string code { get { return maq_code; } set { maq_code = value; } }

        public string name { get { return maq_name; } set { maq_name = value; } }

        public string product { get { return maq_product; } set { maq_product = value; } }

        public int width { get { return maq_width; } set { maq_width = value; } }

        public int diameter { get { return maq_diameter; } set { maq_diameter = value; } }

        public int core { get { return maq_core; } set { maq_core = value; } }

        public int pallet { get { return maq_pallet; } set { maq_pallet = value; } }

        public int coil { get { return maq_coil; } set { maq_coil = value; } }

        public string Diameter { get { return maq_diameters; } set { maq_diameters = value; } }

        public int fkExport { get { return maq_fkExport; } set { maq_fkExport = value; } }

        public int fkStatus { get { return maq_fkstatus; } set { maq_fkstatus = value; } }

        public string reference { get { return maq_reference; } set { maq_reference = value; } }

        public string origin { get { return maq_origin; } set { maq_origin = value; } }

        public string movementcellar { get { return maq_movementcellar; } set { maq_movementcellar = value; } }

        public int fkproductTo { get { return maq_fkproductTo; } set { maq_fkproductTo = value; } }

        public int fkproductFrom { get { return maq_fkproductFrom; } set { maq_fkproductFrom = value; } }

        public clsProduct ProductTo { get { return maq_productoTo; } set { maq_productoTo = value; } }

        public clsProduct ProductFrom { get { return maq_productofrom; } set { maq_productofrom = value; } }

        public int fkmainCoilMetal { get { return maq_fkmainCoilMetal; } set { maq_fkmainCoilMetal = value; } }

        public string mainCoilMetalCode { get { return maq_mainCoilMetalCode; } set { maq_mainCoilMetalCode = value; } }

        //Constructor

        public clsMaquile()
        {
            maq_productoTo = new clsProduct();
            maq_productofrom = new clsProduct();
            maq_codsec = 0;
            maq_customer = "";
            maq_quantity = 0;
            maq_note = "";
            maq_abbreviation = "";
            maq_createdDate = DateTime.Now;
            maq_modifiedDate = DateTime.Now;
            maq_createdBy = 0;
            maq_creatorUser = "";
            maq_modifiedBy = 0;
            maq_modificatorUser = "";
            maq_fkfilm = 0;
            maq_fkProduct = 0;
            maq_cellar = "";
            maq_weigth = 0;
            maq_movement = "E011";
            maq_cellarname = "Maquilas";
            maq_cellar = "0019";
            maq_code = "";
            maq_fkExport = 353;

            maq_fkmainCoilMetal = 0;
            maq_mainCoilMetalCode = "";
        }

        public clsMaquile(int codsec)
        {
            load(codsec);
        }

        public void load(int codSec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_codsec = " + codSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
                code = DS.Tables[0].Rows[0]["maq_code"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkStatus"]);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkProduct"]);
                customer = DS.Tables[0].Rows[0]["maq_customer"].ToString();
                cellarName = DS.Tables[0].Rows[0]["maq_cellarname"].ToString();
                notes = DS.Tables[0].Rows[0]["maq_note"].ToString();
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_weigth"]);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["maq_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["maq_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_createdBy"]);
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_modifiedBy"]);
                movement = DS.Tables[0].Rows[0]["maq_movement"].ToString();
                cellar = DS.Tables[0].Rows[0]["maq_cellar"].ToString();
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["maq_in"], DS.Tables[0].Rows[0]["maq_in"].GetType().FullName);
                outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["maq_out"], DS.Tables[0].Rows[0]["maq_out"].GetType().FullName);
                boppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_boppweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_oppweigth"]);
                pallet = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_pallet"]);
                coil = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_coil"]);
                diameter = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkdiameter"]);
                core = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkcore"]);
                width = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_width"]);
                fkExport = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkExport"]);
                fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkproductTo"]);
                fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkproductFrom"]);
                fkmainCoilMetal = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkmainCoilMetal"]);
                mainCoilMetalCode = DS.Tables[0].Rows[0]["maq_mainCoilMetalCode"].ToString();
            }
        }

        public void load(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
                code = DS.Tables[0].Rows[0]["maq_code"].ToString();
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkProduct"]);
                customer = DS.Tables[0].Rows[0]["maq_customer"].ToString();
                notes = DS.Tables[0].Rows[0]["maq_note"].ToString();
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_weigth"]);
                boppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_boppweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_oppweigth"]);
                pallet = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_pallet"]);
                coil = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_coil"]);
                diameter = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkdiameter"]);
                core = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkcore"]);
                width = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_width"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["maq_in"], DS.Tables[0].Rows[0]["maq_in"].GetType().FullName);
                outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["maq_out"], DS.Tables[0].Rows[0]["maq_out"].GetType().FullName);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["maq_createdDate"]);
                fkProductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkproductFrom"]);
                fkProductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_fkProductTo"]);
                ProductFrom = new clsProduct(this.fkProductFrom);
                ProductTo = new clsProduct(this.fkProductTo);
                //if (ingress)
                //    movementcellar = "Bodega Devoluciones";
                //else
                //    movementcellar = "Bodega Proceso";
            }
        }


        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maquile (maq_code, maq_fkStatus, maq_fkProduct, maq_customer, maq_cellarname, maq_note, maq_weigth, maq_createdDate, maq_modifiedDate, maq_createdBy, maq_modifiedBy, maq_movement, maq_cellar, maq_in, maq_out, maq_boppweigth, maq_oppweigth, maq_pallet, maq_coil, maq_fkdiameter, maq_fkcore, maq_width, maq_fkExport, maq_fkProductTo, maq_fkproductFrom, maq_fkmainCoilMetal, maq_mainCoilMetalCode)";
                    queryString += " VALUES (";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += clsStatus.getStatusByStatusGroupNameAndStatusName("Maquilas", "Activa").codsec.ToString() + ",";
                    queryString += this.fkProduct.ToString() + ",";
                    queryString += "'" + this.customer.ToString() + "',";
                    queryString += "'" + this.cellarName.ToString() + "',";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += this.weigth.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + movement.ToString() + "',";
                    queryString += "'" + cellar.ToString() + "',";
                    queryString += this.ingress.ToString() + ",";
                    queryString += this.outt.ToString() + ",";
                    queryString += this.boppweigth.ToString() + ",";
                    queryString += this.oppweigth.ToString() + ",";
                    queryString += this.pallet.ToString() + ",";
                    queryString += this.coil.ToString() + ",";
                    queryString += this.diameter.ToString() + ",";
                    queryString += this.core.ToString() + ",";
                    queryString += this.width.ToString() + ",";
                    queryString += this.fkExport.ToString() + ",";
                    queryString += this.fkproductTo.ToString() + ",";
                    queryString += this.fkproductFrom.ToString() + ",";
                    queryString += this.fkmainCoilMetal.ToString() + ",'";
                    queryString += this.mainCoilMetalCode.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_maquile";
                    queryString += " SET ";
                    queryString += "maq_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "maq_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE maq_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReturn.save");
                return false;
            }

        }

        public bool save(bool data)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maquile (maq_code, maq_fkStatus, maq_fkProduct, maq_customer, maq_cellarname, maq_note, maq_weigth, maq_createdDate, maq_modifiedDate, maq_createdBy, maq_modifiedBy, maq_movement, maq_cellar, maq_in, maq_out, maq_boppweigth, maq_oppweigth, maq_pallet, maq_coil, maq_fkdiameter, maq_fkcore, maq_width, maq_fkExport)";
                    queryString += " VALUES (";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += clsStatus.getStatusByStatusGroupNameAndStatusName("Maquilas", "Proceso").codsec.ToString() + ",";
                    queryString += this.fkProduct.ToString() + ",";
                    queryString += "'" + this.customer.ToString() + "',";
                    queryString += "'" + this.cellarName.ToString() + "',";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += this.weigth.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + movement.ToString() + "',";
                    queryString += "'" + cellar.ToString() + "',";
                    queryString += this.ingress.ToString() + ",";
                    queryString += this.outt.ToString() + ",";
                    queryString += this.boppweigth.ToString() + ",";
                    queryString += this.oppweigth.ToString() + ",";
                    queryString += this.pallet.ToString() + ",";
                    queryString += this.coil.ToString() + ",";
                    queryString += this.diameter.ToString() + ",";
                    queryString += this.core.ToString() + ",";
                    queryString += this.width.ToString() + ",";
                    queryString += this.fkExport.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_maquile";
                    queryString += " SET ";
                    queryString += "maq_fkFilm = " + this.fkFilm.ToString() + ",";
                    queryString += "maq_fkProduct = " + this.fkProduct.ToString() + ",";
                    queryString += "maq_customer = '" + this.customer.ToString() + "',";
                    queryString += "maq_cellar = '" + this.cellar.ToString() + "',";
                    queryString += "maq_note = '" + this.notes.ToString() + "',";
                    queryString += "maq_weigth = " + this.weigth.ToString() + ",";
                    queryString += "maq_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "maq_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE maq_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsReturn.save");
                return false;
            }

        }

        public bool save(string data)
        {
            try
            {
                string queryString = "";

                if (data == "Maquile")
                {
                    if (this.codsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_maquile (maq_code, maq_fkStatus, maq_fkProduct, maq_customer, maq_cellarname, maq_note, maq_weigth, maq_createdDate, maq_modifiedDate, maq_createdBy, maq_modifiedBy, maq_movement, maq_cellar, maq_in, maq_out, maq_boppweigth, maq_oppweigth, maq_pallet, maq_coil, maq_fkdiameter, maq_fkcore, maq_width, maq_fkExport, maq_fkmainCoilMetal, maq_mainCoilMetalCode)";
                        queryString += " VALUES (";
                        queryString += "'" + this.code.ToString() + "',";
                        queryString += this.fkStatus.ToString() + ",";
                        queryString += this.fkProduct.ToString() + ",";
                        queryString += "'" + this.customer.ToString() + "',";
                        queryString += "'" + this.cellarName.ToString() + "',";
                        queryString += "'" + this.notes.ToString() + "',";
                        queryString += this.weigth.ToString() + ",";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                        queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                        queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                        queryString += "'" + movement.ToString() + "',";
                        queryString += "'" + cellar.ToString() + "',";
                        queryString += this.ingress.ToString() + ",";
                        queryString += this.outt.ToString() + ",";
                        queryString += this.boppweigth.ToString() + ",";
                        queryString += this.oppweigth.ToString() + ",";
                        queryString += this.pallet.ToString() + ",";
                        queryString += this.coil.ToString() + ",";
                        queryString += this.diameter.ToString() + ",";
                        queryString += this.core.ToString() + ",";
                        queryString += this.width.ToString() + ",";
                        queryString += this.fkExport.ToString() + ",";
                        queryString += this.fkmainCoilMetal.ToString() + ",";
                        queryString += "'" + mainCoilMetalCode.ToString() + "'";
                        queryString += ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_maquile";
                        queryString += " SET ";
                        queryString += "maq_fkFilm = " + this.fkFilm.ToString() + ",";
                        queryString += "maq_fkProduct = " + this.fkProduct.ToString() + ",";
                        queryString += "maq_customer = '" + this.customer.ToString() + "',";
                        queryString += "maq_cellar = '" + this.cellar.ToString() + "',";
                        queryString += "maq_note = '" + this.notes.ToString() + "',";
                        queryString += "maq_weigth = " + this.weigth.ToString() + ",";
                        queryString += "maq_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                        queryString += "maq_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                        queryString += " WHERE maq_codsec = " + this.codsec.ToString() + ";";
                    }
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMaquile.save");
                return false;
            }
        }

        public static bool isUnique(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static bool isExistCoil(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static int getlastcodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP (1) maq_codsec FROM bps_prod_maquile ORDER BY maq_codsec DESC");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
            else
                return 0;
        }

        public static List<clsMaquile> getList()
        {
            try
            {
                List<clsMaquile> lstRetun = new List<clsMaquile>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("spMaquileCoilList");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstRetun.Add(new clsMaquile());
                        lstRetun[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                        lstRetun[i].name = DS.Tables[0].Rows[i]["maq_name"].ToString();
                        lstRetun[i].abbreviation = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
                        lstRetun[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_width"]);
                        lstRetun[i].Diameter = DS.Tables[0].Rows[i]["maq_diameter"].ToString();
                        lstRetun[i].core = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_core"]);
                        lstRetun[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_weigth"]);
                        lstRetun[i].customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                        lstRetun[i].notes = DS.Tables[0].Rows[i]["maq_note"].ToString();
                        lstRetun[i].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_pallet"]);
                        lstRetun[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_coil"]);
                        lstRetun[i].cellarName = DS.Tables[0].Rows[i]["maq_cellarname"].ToString();
                    }
                }
                return lstRetun;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static clsMaquile getMovementByCode(String Code)
        {
            try
            {
                clsMaquile ObjMaquile = new clsMaquile();
                DataSet DSCode = new DataSet();
                DataSet DS = new DataSet();
                DSCode = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_code = '" + Code + "'");
                if (DSCode.Tables[0].Rows.Count > 0)
                {
                    DS = clsConnection.getDataSetResult("spMaquileByCodsec'" + DSCode.Tables[0].Rows[0]["maq_codsec"].ToString() + "'");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        ObjMaquile.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
                        ObjMaquile.code = DS.Tables[0].Rows[0]["maq_code"].ToString();
                        ObjMaquile.product = DS.Tables[0].Rows[0]["maq_abbreviation"].ToString();
                        ObjMaquile.customer = DS.Tables[0].Rows[0]["maq_customer"].ToString();
                        ObjMaquile.notes = DS.Tables[0].Rows[0]["maq_note"].ToString();
                        ObjMaquile.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_weigth"]);
                        ObjMaquile.name = DS.Tables[0].Rows[0]["maq_name"].ToString();
                    }
                }
                return ObjMaquile;
            }
            catch (Exception)
            {
                clsMaquile ObjMaquile = new clsMaquile();
                return ObjMaquile;
            }
        }

        public static double getWeigthByCodsec(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT maq_weigth FROM bps_prod_maquile WHERE maq_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToDouble(DS.Tables[0].Rows[0]["maq_weigth"]);
            else
                return 0;
        }

        public static List<clsMaquile> getListMovementByDate(DateTime inidate, DateTime enddate, string movementload)
        {
            try
            {
                List<clsMaquile> lstMaquile = new List<clsMaquile>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("spMaquileMovement'" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");
                //DS = clsConnection.getDataSetResult("spMaquileMovement'" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (movementload == "Ingreso Cliente")
                        {
                            if (clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_in"], DS.Tables[0].Rows[i]["maq_in"].GetType().FullName) == true)
                            {
                                lstMaquile.Add(new clsMaquile());
                                int pos = lstMaquile.Count - 1;
                                lstMaquile[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                                lstMaquile[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_boppweigth"]);
                                lstMaquile[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_oppweigth"]);
                                lstMaquile[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_weigth"]);
                                lstMaquile[pos].product = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
                                lstMaquile[pos].customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                                lstMaquile[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_width"]);
                                lstMaquile[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_pallet"]);
                                lstMaquile[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_coil"]);
                                lstMaquile[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["maq_createdDate"]);
                                lstMaquile[pos].cellar = DS.Tables[0].Rows[i]["maq_cellar"].ToString().Replace("0", "");
                                lstMaquile[pos].movement = DS.Tables[0].Rows[i]["maq_movement"].ToString();
                                lstMaquile[pos].code = DS.Tables[0].Rows[i]["feq_externalId"].ToString();
                                lstMaquile[pos].reference = DS.Tables[0].Rows[i]["feq_externalCode"].ToString();
                                lstMaquile[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_in"], DS.Tables[0].Rows[i]["maq_in"].GetType().FullName);
                                lstMaquile[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_out"], DS.Tables[0].Rows[i]["maq_out"].GetType().FullName);
                                if (lstMaquile[pos].boppweigth == 0)
                                    lstMaquile[pos].origin = "OPP";
                                else
                                    lstMaquile[pos].origin = "BOPP";
                                if (lstMaquile[pos].ingress == true)
                                    lstMaquile[pos].movementcellar = "Maquilas";
                                else
                                    lstMaquile[pos].movementcellar = "Proceso";
                                lstMaquile[pos].notes = DS.Tables[0].Rows[i]["maq_code"].ToString();
                            }
                        }
                        else if (movementload == "Ingreso Metalizado")
                        {
                            if (DS.Tables[0].Rows[i]["maq_cellarname"].ToString() == "Maquila - Metalizada" && DS.Tables[0].Rows[i]["maq_movement"].ToString() == "E012")
                            {
                                lstMaquile.Add(new clsMaquile());
                                int pos = lstMaquile.Count - 1;
                                lstMaquile[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                                lstMaquile[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_boppweigth"]);
                                lstMaquile[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_oppweigth"]);
                                lstMaquile[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_weigth"]);
                                lstMaquile[pos].product = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
                                lstMaquile[pos].customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                                lstMaquile[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_width"]);
                                lstMaquile[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_pallet"]);
                                lstMaquile[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_coil"]);
                                lstMaquile[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["maq_createdDate"]);
                                lstMaquile[pos].cellar = DS.Tables[0].Rows[i]["maq_cellar"].ToString().Replace("0", "");
                                lstMaquile[pos].movement = DS.Tables[0].Rows[i]["maq_movement"].ToString();
                                lstMaquile[pos].code = DS.Tables[0].Rows[i]["feq_externalId"].ToString();
                                lstMaquile[pos].reference = DS.Tables[0].Rows[i]["feq_externalCode"].ToString();
                                lstMaquile[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_in"], DS.Tables[0].Rows[i]["maq_in"].GetType().FullName);
                                lstMaquile[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_out"], DS.Tables[0].Rows[i]["maq_out"].GetType().FullName);
                                lstMaquile[pos].origin = "BOPP";
                                lstMaquile[pos].movementcellar = "Maquila -  Metalizada";
                                lstMaquile[pos].fkmainCoilMetal = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_fkmainCoilMetal"]);
                                lstMaquile[pos].mainCoilMetalCode = DS.Tables[0].Rows[i]["maq_mainCoilMetalCode"].ToString();
                                lstMaquile[pos].notes = DS.Tables[0].Rows[i]["maq_code"].ToString();
                            }
                        }
                        else if (movementload == "Salida Proceso")
                        {
                            if (DS.Tables[0].Rows[i]["maq_movement"].ToString() == "H013")
                            {
                                lstMaquile.Add(new clsMaquile());
                                int pos = lstMaquile.Count - 1;
                                lstMaquile[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                                lstMaquile[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_boppweigth"]);
                                lstMaquile[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_oppweigth"]);
                                lstMaquile[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_weigth"]);
                                lstMaquile[pos].product = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
                                lstMaquile[pos].customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                                lstMaquile[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_width"]);
                                lstMaquile[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_pallet"]);
                                lstMaquile[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_coil"]);
                                lstMaquile[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["maq_createdDate"]);
                                lstMaquile[pos].cellar = DS.Tables[0].Rows[i]["maq_cellar"].ToString().Replace("0", "");
                                lstMaquile[pos].movement = DS.Tables[0].Rows[i]["maq_movement"].ToString();
                                lstMaquile[pos].code = DS.Tables[0].Rows[i]["feq_externalId"].ToString();
                                lstMaquile[pos].reference = DS.Tables[0].Rows[i]["feq_externalCode"].ToString();
                                lstMaquile[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_in"], DS.Tables[0].Rows[i]["maq_in"].GetType().FullName);
                                lstMaquile[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_out"], DS.Tables[0].Rows[i]["maq_out"].GetType().FullName);
                                if (lstMaquile[pos].boppweigth == 0)
                                    lstMaquile[pos].origin = "OPP";
                                else
                                    lstMaquile[pos].origin = "BOPP";
                                if (lstMaquile[pos].ingress == true)
                                    lstMaquile[pos].movementcellar = "Maquilas";
                                else
                                    lstMaquile[pos].movementcellar = "Proceso";
                                lstMaquile[pos].notes = DS.Tables[0].Rows[i]["maq_code"].ToString();
                            }
                        }
                        else if (movementload == "Despacho Maquila")
                        {
                            if (DS.Tables[0].Rows[i]["maq_movement"].ToString() == "S014")
                            {
                                lstMaquile.Add(new clsMaquile());
                                int pos = lstMaquile.Count - 1;
                                lstMaquile[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_codsec"]);
                                lstMaquile[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_boppweigth"]);
                                lstMaquile[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_oppweigth"]);
                                lstMaquile[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["maq_weigth"]);
                                lstMaquile[pos].product = DS.Tables[0].Rows[i]["maq_abbreviation"].ToString();
                                lstMaquile[pos].customer = DS.Tables[0].Rows[i]["maq_customer"].ToString();
                                lstMaquile[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_width"]);
                                lstMaquile[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_pallet"]);
                                lstMaquile[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["maq_coil"]);
                                lstMaquile[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["maq_createdDate"]);
                                lstMaquile[pos].cellar = DS.Tables[0].Rows[i]["maq_cellar"].ToString().Replace("0", "");
                                lstMaquile[pos].movement = DS.Tables[0].Rows[i]["maq_movement"].ToString();
                                lstMaquile[pos].code = DS.Tables[0].Rows[i]["feq_externalId"].ToString();
                                lstMaquile[pos].reference = DS.Tables[0].Rows[i]["feq_externalCode"].ToString();
                                lstMaquile[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_in"], DS.Tables[0].Rows[i]["maq_in"].GetType().FullName);
                                lstMaquile[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["maq_out"], DS.Tables[0].Rows[i]["maq_out"].GetType().FullName);
                                if (lstMaquile[pos].boppweigth == 0)
                                    lstMaquile[pos].origin = "OPP";
                                else
                                    lstMaquile[pos].origin = "BOPP";
                                lstMaquile[pos].movementcellar = "Despacho";
                                lstMaquile[pos].notes = DS.Tables[0].Rows[i]["maq_code"].ToString();
                            }
                        }
                    }
                }
                return lstMaquile;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool getMaquileByCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_maquile WHERE maq_mainCoilMetalCode = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static clsMaquile getMaquileObjByCode(string code)
        {
            try
            {
                clsMaquile objMaquile = new clsMaquile();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("spDeadTimeMultipleMill 'MaquileByCode','" + code + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objMaquile.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["maq_codsec"]);
                    objMaquile.customer = DS.Tables[0].Rows[0]["maq_customer"].ToString();
                    objMaquile.mainCoilMetalCode = DS.Tables[0].Rows[0]["maq_mainCoilMetalCode"].ToString();
                    objMaquile.product = DS.Tables[0].Rows[0]["maq_abbreviation"].ToString();
                    objMaquile.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["maq_weigth"]);
                    objMaquile.name = DS.Tables[0].Rows[0]["prod_code"].ToString();
                    objMaquile.reference = DS.Tables[0].Rows[0]["ProductToprod_code"].ToString();
                }
                return objMaquile;
            }
            catch (Exception)
            {
                clsMaquile objMaquile = new clsMaquile();
                return objMaquile;
            }
        }
    }
}
