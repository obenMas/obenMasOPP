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
    public class clsReturn
    {
        //Atributes
        private int rcp_codsec;
        private string rcp_customer;
        private double rcp_quantity;
        private string rcp_note;
        private string rcp_documentNumber;
        private DateTime rcp_createdDate;
        private DateTime rcp_modifiedDate;
        private int rcp_createdBy;
        private string rcp_creatorUser;
        private int rcp_modifiedBy;
        private string rcp_modificatorUser;
        private string rcp_movement;
        private int rcp_fkfilm;
        private int rcp_fkProduct;
        private string rcp_cellarname;
        private string rcp_cellar;
        private double rcp_weigth;
        private bool rcp_in;
        private bool rcp_out;
        private double rcp_boppweigth;
        private double rcp_oppweigth;
        private string rcp_code;
        private string rcp_film;
        private string rcp_product;
        private int rcp_width;
        private string rcp_diameter;
        private int rcp_core;
        private int rcp_coil;
        private int rcp_pallet;
        private string rcp_origin;
        private string rcp_reference;
        private string rcp_originalcellar;
        private int rcp_fkExport;
        private int rcp_fkStatus;

        //SIIGO

        //Properties

        public int codsec { get { return rcp_codsec; } set { rcp_codsec = value; } }

        public string customer { get { return rcp_customer; } set { rcp_customer = value; } }

        public double quantity { get { return rcp_quantity; } set { rcp_quantity = value; } }

        public string notes { get { return rcp_note; } set { rcp_note = value; } }

        public string documentNumber { get { return rcp_documentNumber; } set { rcp_documentNumber = value; } }

        public DateTime createdDate { get { return rcp_createdDate; } set { rcp_createdDate = value; } }

        public DateTime modifiedDate { get { return rcp_modifiedDate; } set { rcp_modifiedDate = value; } }

        public int createdBy { get { return rcp_createdBy; } set { rcp_createdBy = value; } }

        public string creatorUser { get { return rcp_creatorUser; } set { rcp_creatorUser = value; } }

        public int modifiedBy { get { return rcp_modifiedBy; } set { rcp_modifiedBy = value; } }

        public string modificatorUser { get { return rcp_modificatorUser; } set { rcp_modificatorUser = value; } }

        public int fkFilm { get { return rcp_fkfilm; } set { rcp_fkfilm = value; } }

        public int fkProduct { get { return rcp_fkProduct; } set { rcp_fkProduct = value; } }

        public string cellar { get { return rcp_cellar; } set { rcp_cellar = value; } }

        public double weigth { get { return rcp_weigth; } set { rcp_weigth = value; } }

        public string movement { get { return rcp_movement; } set { rcp_movement = value; } }

        public string cellarName { get { return rcp_cellarname; } set { rcp_cellarname = value; } }

        public bool ingress { get { return rcp_in; } set { rcp_in = value; } }

        public bool outt { get { return rcp_out; } set { rcp_out = value; } }

        public double boppweigth { get { return rcp_boppweigth; } set { rcp_boppweigth = value; } }

        public double oppweigth { get { return rcp_oppweigth; } set { rcp_oppweigth = value; } }

        public string code { get { return rcp_code; } set { rcp_code = value; } }

        public string film { get { return rcp_film; } set { rcp_film = value; } }

        public string product { get { return rcp_product; } set { rcp_product = value; } }

        public int width { get { return rcp_width; } set { rcp_width = value; } }

        public string diameter { get { return rcp_diameter; } set { rcp_diameter = value; } }

        public int core { get { return rcp_core; } set { rcp_core = value; } }

        public int pallet { get { return rcp_pallet; } set { rcp_pallet = value; } }

        public int coil { get { return rcp_coil; } set { rcp_coil = value; } }

        public string origin { get { return rcp_origin; } set { rcp_origin = value; } }

        public string reference { get { return rcp_reference; } set { rcp_reference = value; } }

        public string movementcellar { get { return rcp_originalcellar; } set { rcp_originalcellar = value; } }

        public int fkExport { get { return rcp_fkExport; } set { rcp_fkExport = value; } }

        public int fkStatus { get { return rcp_fkStatus; } set { rcp_fkStatus = value; } }

        //Constructor

        public clsReturn()
        {
            rcp_codsec = 0;
            rcp_customer = "";
            rcp_quantity = 0;
            rcp_note = "";
            rcp_documentNumber = "";
            rcp_createdDate = DateTime.Now;
            rcp_modifiedDate = DateTime.Now;
            rcp_createdBy = 0;
            rcp_creatorUser = "";
            rcp_modifiedBy = 0;
            rcp_modificatorUser = "";
            rcp_fkfilm = 0;
            rcp_fkProduct = 0;
            rcp_cellar = "";
            rcp_weigth = 0;
            rcp_movement = "E001";
            rcp_cellarname = "Devoluciones";
            rcp_cellar = "H023";
            rcp_code = "";
            rcp_origin = "";

        }

        public clsReturn(int codsec)
        {
            load(codsec);
        }


        public void load(int codSec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_return WHERE rtn_codsec = " + codSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
                code = DS.Tables[0].Rows[0]["rtn_code"].ToString();
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_weigth"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rtn_in"], DS.Tables[0].Rows[0]["rtn_in"].GetType().FullName);
                outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rtn_out"], DS.Tables[0].Rows[0]["rtn_out"].GetType().FullName);
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["rtn_createdDate"]);
                if (ingress)
                    movementcellar = "Bodega Devoluciones";
                else
                    movementcellar = "Bodega Proceso";
            }
        }

        public void load(int codSec, bool data)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_return WHERE rtn_codsec = " + codSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
                code = DS.Tables[0].Rows[0]["rtn_code"].ToString();
                fkFilm = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkFilm"]);
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkProduct"]);
                customer = DS.Tables[0].Rows[0]["rtn_customer"].ToString();
                cellarName = DS.Tables[0].Rows[0]["rtn_cellarname"].ToString();
                notes = DS.Tables[0].Rows[0]["rtn_note"].ToString();
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_weigth"]);
                movement = DS.Tables[0].Rows[0]["rtn_note"].ToString();
                pallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_pallet"]);
                coil = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_coil"]);
                fkExport = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_fkExport"]);
                boppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_boppweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_oppweigth"]);
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
                    queryString += "INSERT INTO bps_prod_return (rtn_code, rtn_fkStatus,rtn_fkFilm,rtn_fkProduct,rtn_customer,rtn_cellarname,rtn_note,rtn_weigth,rtn_createdDate,rtn_modifiedDate,rtn_createdBy,rtn_modifiedBy, rtn_movement, rtn_cellar, rtn_in, rtn_out, rtn_boppweigth, rtn_oppweigth, rtn_pallet, rtn_coil)";
                    queryString += " VALUES (";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += clsStatus.getStatusByStatusGroupNameAndStatusName("Devoluciones", "Activa").codsec.ToString() + ",";
                    queryString += this.fkFilm.ToString() + ",";
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
                    queryString += this.coil.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_return";
                    queryString += " SET ";
                    queryString += "rtn_fkStatus = " + this.fkStatus.ToString() + ",";
                    queryString += "rtn_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "rtn_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE rtn_codsec = " + this.codsec.ToString() + ";";
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
                    queryString += "INSERT INTO bps_prod_return (rtn_code, rtn_fkStatus,rtn_fkFilm,rtn_fkProduct,rtn_customer,rtn_cellarname,rtn_note,rtn_weigth,rtn_createdDate,rtn_modifiedDate,rtn_createdBy,rtn_modifiedBy, rtn_movement, rtn_cellar, rtn_in, rtn_out, rtn_boppweigth, rtn_oppweigth, rtn_pallet, rtn_coil)";
                    queryString += " VALUES (";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += clsStatus.getStatusByStatusGroupNameAndStatusName("Devoluciones", "Proceso").codsec.ToString() + ",";
                    queryString += this.fkFilm.ToString() + ",";
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
                    queryString += this.coil.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_return";
                    queryString += " SET ";
                    queryString += "rtn_fkFilm = " + this.fkFilm.ToString() + ",";
                    queryString += "rtn_fkProduct = " + this.fkProduct.ToString() + ",";
                    queryString += "rtn_customer = '" + this.customer.ToString() + "',";
                    queryString += "rtn_cellar = '" + this.cellar.ToString() + "',";
                    queryString += "rtn_note = '" + this.notes.ToString() + "',";
                    queryString += "rtn_weigth = " + this.weigth.ToString() + ",";
                    queryString += "rtn_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "rtn_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE rtn_codsec = " + this.codsec.ToString() + ";";
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

        public static bool isUnique(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_return WHERE rtn_code = '" + code + "'");

            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static int getlastcodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP (1) rtn_codsec FROM bps_prod_return ORDER BY rtn_codsec DESC");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
            else
                return 0;
        }

        public static List<clsReturn> getList()
        {
            try
            {
                List<clsReturn> lstRetun = new List<clsReturn>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("spReturnCoilList");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstRetun.Add(new clsReturn());
                        lstRetun[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_codsec"]);
                        lstRetun[i].film = DS.Tables[0].Rows[i]["rcp_film"].ToString();
                        lstRetun[i].product = DS.Tables[0].Rows[i]["rcp_product"].ToString();
                        lstRetun[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_width"]);
                        lstRetun[i].diameter = DS.Tables[0].Rows[i]["rcp_diameter"].ToString();
                        lstRetun[i].core = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_core"]);
                        lstRetun[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_weigth"]);
                        lstRetun[i].customer = DS.Tables[0].Rows[i]["rcp_customer"].ToString();
                        lstRetun[i].notes = DS.Tables[0].Rows[i]["rcp_note"].ToString();
                        lstRetun[i].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_pallet"]);
                        lstRetun[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_coil"]);
                        lstRetun[i].cellarName = DS.Tables[0].Rows[i]["rcp_cellar"].ToString();
                    }
                }
                return lstRetun;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<clsReturn> getListMovementByDate(DateTime inidate, DateTime enddate, string movementload)
        {
            try
            {
                List<clsReturn> lstRetun = new List<clsReturn>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("spReturnCoilMovement'" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (movementload == "Ingreso Cliente")
                        {
                            if (DS.Tables[0].Rows[i]["rcp_in"].ToString() == "1")
                            {
                                lstRetun.Add(new clsReturn());
                                int pos = lstRetun.Count - 1;
                                lstRetun[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_codsec"]);
                                lstRetun[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_boppweigth"]);
                                lstRetun[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_oppweigth"]);
                                lstRetun[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_weigth"]);
                                lstRetun[pos].product = DS.Tables[0].Rows[i]["rcp_product"].ToString();
                                lstRetun[pos].customer = DS.Tables[0].Rows[i]["rcp_customer"].ToString();
                                lstRetun[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_width"]);
                                lstRetun[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_pallet"]);
                                lstRetun[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_coil"]);
                                lstRetun[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rcp_create"]);
                                lstRetun[pos].cellar = DS.Tables[0].Rows[i]["rcp_siigoCel"].ToString().Replace("0", "");
                                lstRetun[pos].movement = DS.Tables[0].Rows[i]["rcp_siigoMov"].ToString();
                                lstRetun[pos].code = DS.Tables[0].Rows[i]["rcp_siigoID"].ToString();
                                lstRetun[pos].reference = DS.Tables[0].Rows[i]["rcp_siigoRef"].ToString();
                                lstRetun[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rcp_in"], DS.Tables[0].Rows[i]["rcp_in"].GetType().FullName);
                                lstRetun[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rcp_out"], DS.Tables[0].Rows[i]["rcp_out"].GetType().FullName);
                                if (lstRetun[pos].boppweigth == 0)
                                    lstRetun[pos].origin = "OPP";
                                else
                                    lstRetun[pos].origin = "BOPP";
                                if (lstRetun[pos].ingress == true)
                                    lstRetun[pos].movementcellar = "Devoluciones";
                                else
                                    lstRetun[pos].movementcellar = "Proceso";
                            }
                        }
                        else
                        {
                            if (DS.Tables[0].Rows[i]["rcp_in"].ToString() == "0")
                            {
                                lstRetun.Add(new clsReturn());
                                int pos = lstRetun.Count - 1;
                                lstRetun[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_codsec"]);
                                lstRetun[pos].boppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_boppweigth"]);
                                lstRetun[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_oppweigth"]);
                                lstRetun[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rcp_weigth"]);
                                lstRetun[pos].product = DS.Tables[0].Rows[i]["rcp_product"].ToString();
                                lstRetun[pos].customer = DS.Tables[0].Rows[i]["rcp_customer"].ToString();
                                lstRetun[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_width"]);
                                lstRetun[pos].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_pallet"]);
                                lstRetun[pos].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["rcp_coil"]);
                                lstRetun[pos].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["rcp_create"]);
                                lstRetun[pos].cellar = DS.Tables[0].Rows[i]["rcp_siigoCel"].ToString().Replace("0", "");
                                lstRetun[pos].movement = DS.Tables[0].Rows[i]["rcp_siigoMov"].ToString();
                                lstRetun[pos].code = DS.Tables[0].Rows[i]["rcp_siigoID"].ToString();
                                lstRetun[pos].reference = DS.Tables[0].Rows[i]["rcp_siigoRef"].ToString();
                                lstRetun[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rcp_in"], DS.Tables[0].Rows[i]["rcp_in"].GetType().FullName);
                                lstRetun[pos].outt = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rcp_out"], DS.Tables[0].Rows[i]["rcp_out"].GetType().FullName);
                                if (lstRetun[pos].boppweigth == 0)
                                    lstRetun[pos].origin = "BOPP";
                                else
                                    lstRetun[pos].origin = "OPP";
                                if (lstRetun[pos].ingress == true)
                                    lstRetun[pos].movementcellar = "Devoluciones";
                                else
                                    lstRetun[pos].movementcellar = "Proceso";
                            }
                        }
                    }
                }
                return lstRetun;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static clsReturn getMovementByCode(String Code)
        {
            try
            {
                clsReturn ObjReturn = new clsReturn();
                DataSet DSCode = new DataSet();
                DataSet DS = new DataSet();
                DSCode = clsConnection.getDataSetResult("SELECT * FROM bps_prod_return WHERE rtn_code = '" + Code + "'");
                if (DSCode.Tables[0].Rows.Count > 0)
                {
                    DS = clsConnection.getDataSetResult("spReturnCoil'" + DSCode.Tables[0].Rows[0]["rtn_codsec"].ToString() + "'");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        ObjReturn.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rtn_codsec"]);
                        ObjReturn.code = DS.Tables[0].Rows[0]["rtn_code"].ToString();
                        ObjReturn.product = DS.Tables[0].Rows[0]["prod_code"].ToString();
                        ObjReturn.customer = DS.Tables[0].Rows[0]["rtn_customer"].ToString();
                        ObjReturn.notes = DS.Tables[0].Rows[0]["rtn_note"].ToString();
                        ObjReturn.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rtn_weigth"]);
                    }
                }
                return ObjReturn;
            }
            catch (Exception)
            {
                clsReturn ObjReturn = new clsReturn();
                return ObjReturn;
            }
        }
    }
}
