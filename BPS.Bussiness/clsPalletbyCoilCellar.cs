using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletbyCoilCellar : IComparable<clsPalletbyCoilCellar>
    {

        internal struct stcWeigthCellar
        {
            public string cellar { get; set; }
            public double weigth { get; set; }
        }
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

        private int pcc_fkproductalfa;

        public int fkproductalfa
        {
            get { return pcc_fkproductalfa; }
            set { pcc_fkproductalfa = value; }
        }



        //Filters
        private string palletfilter;
        private int pcc_isImport;

        private int pcc_filmbopp;

        public int filmBopp
        {
            get { return pcc_filmbopp; }
            set { pcc_filmbopp = value; }
        }

        private int pcc_filmopp;

        public int filmOpp
        {
            get { return pcc_filmopp; }
            set { pcc_filmopp = value; }
        }


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
        public clsPalletbyCoilCellar()
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

        public clsPalletbyCoilCellar(int codsec)
        {
            load(codsec);
        }

        public clsPalletbyCoilCellar(int codsec, bool data)
        {
            load(codsec, data);
        }

        private void load(int codsec, bool data)
        {
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();


            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbycoilcellar WHERE pcc_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkcoilcellar"]);
                fkpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkpallet"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_in"], DS.Tables[0].Rows[0]["pcc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_out"], DS.Tables[0].Rows[0]["pcc_out"].GetType().FullName);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["pcc_date"]);
                movement = DS.Tables[0].Rows[0]["pcc_movement"].ToString();
                wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[0]["pcc_wasExportedToSystem"]);
                code = DS.Tables[0].Rows[0]["pcc_code"].ToString();
                producto = DS.Tables[0].Rows[0]["pcc_producto"].ToString();
                palletnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_palletnumber"]);
                coilnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_coilnumber"]);
                customer = DS.Tables[0].Rows[0]["pcc_customer"].ToString();
                order = DS.Tables[0].Rows[0]["pcc_order"].ToString();
                width = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_width"]);
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_netweigth"]);
                localweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_localweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_oppweigth"]);
                localCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_localCoils"]);
                oppCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_oppCoils"]);
                isImport = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_isImport"]);
            }
        }

        public int CompareTo(clsPalletbyCoilCellar b)
        {

            if (this.localweigth > b.localweigth)
            {
                return this.localweigth.CompareTo(b.localweigth);
            }

            //if (this.oppweigth > b.oppweigth)
            //{
            //    return this.oppweigth.CompareTo(b.oppweigth);
            //}

            return this.producto.CompareTo(b.producto);
        }

        //Methous
        public void load(int codSec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbycoilcellar WHERE pcc_codsec = " + codSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkcoilcellar"]);
                fkpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkpallet"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_in"], DS.Tables[0].Rows[0]["pcc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_out"], DS.Tables[0].Rows[0]["pcc_out"].GetType().FullName);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["pcc_date"]);
                movement = DS.Tables[0].Rows[0]["pcc_movement"].ToString();
                wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[0]["pcc_wasExportedToSystem"]); 
                code = DS.Tables[0].Rows[0]["pcc_code"].ToString();
                producto = DS.Tables[0].Rows[0]["pcc_producto"].ToString();
                palletnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_palletnumber"]);
                coilnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_coilnumber"]);
                customer = DS.Tables[0].Rows[0]["pcc_customer"].ToString();
                order = DS.Tables[0].Rows[0]["pcc_order"].ToString();
                width = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_width"]);
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_netweigth"]);
                localweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_localweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_oppweigth"]);
                localCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_localCoils"]);
                oppCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_oppCoils"]);
                isImport = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_isImport"]);
                if (localCoils > 0 && oppCoils == 0)
                    origin = "BOPP";
                else if (localCoils == 0 && oppCoils > 0)
                    origin = "OPP";
                else if (localCoils > 0 && oppCoils > 0)
                    origin = "MIXTO";
                else
                    origin = "-----";
            }
        }

        public void loadbypallet(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbycoilcellar WHERE pcc_fkpallet = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_codsec"]);
                fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkcoilcellar"]);
                fkpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_fkpallet"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_in"], DS.Tables[0].Rows[0]["pcc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pcc_out"], DS.Tables[0].Rows[0]["pcc_out"].GetType().FullName);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["pcc_date"]);
                movement = DS.Tables[0].Rows[0]["pcc_movement"].ToString();
                wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[0]["pcc_wasExportedToSystem"]);
                localweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_localweigth"]);
                oppweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pcc_oppweigth"]);
                localCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_localCoils"]);
                oppCoils = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_oppCoils"]);
                isImport = Convert.ToInt32(DS.Tables[0].Rows[0]["pcc_isImport"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_palletbycoilcellar (pcc_fkcoilcellar, pcc_fkpallet, pcc_in, pcc_out, pcc_date, pcc_movement, pcc_code, pcc_producto, pcc_palletnumber, pcc_coilnumber, pcc_customer, pcc_order, pcc_width, pcc_netweigth, pcc_localweigth, pcc_oppweigth, pcc_wasExportedToSystem, pcc_localCoils, pcc_oppCoils, pcc_isImport)";
                    queryString += " VALUES (";
                    queryString += this.fkcoilcellar.ToString() + ", ";
                    queryString += this.fkpallet.ToString() + ", ";
                    queryString += this.ingress.ToString() + ", ";
                    queryString += this.output.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += "'" + this.movement.ToString() + "', ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "'" + this.producto.ToString() + "', ";
                    queryString += this.palletnumber.ToString() + ", ";
                    queryString += this.GetCoilNumber(fkpallet).ToString() + ", ";
                    queryString += "'" + this.customer + "', ";
                    queryString += "'" + this.order.ToString() + "', ";
                    queryString += "'" + this.width.ToString() + "', ";
                    queryString += "'" + this.netweigth.ToString() + "', ";
                    queryString += "'" + this.GetLocalWeigth(fkpallet, netweigth).ToString() + "', ";
                    queryString += "'" + this.GetOppWeigth(fkpallet,netweigth).ToString() + "', ";
                    queryString += "" + this.wasExportedToSystem.ToString() + ", ";
                    queryString += "" + this.GetLocalCoilCont(fkpallet).ToString() + ", ";
                    queryString += "" + this.GetOppCoilCount(fkpallet).ToString() + ", ";
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
                clsLog.addLog(ex, 3, "clsPalletbyCoilCellar.save");
                return false;
            }
        }

        public bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_palletbycoilcellar WHERE pcc_fkpallet = " + codsec.ToString();
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletbyCoilCellar.delete");
                return false;
            }
        }

        private double GetOppWeigth(int pallet, double netweigth)
        {
            try
            {
                string queryString = string.Empty;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT dbo.fnExternalWeightByPallet(" + pallet + ") as weigth;");
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]);

                if (oppweigth == 0)
                    return oppweigth;
                else
                {
                    if (oppweigth == netweigth)
                        return oppweigth;
                    else
                        return netweigth;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private int GetOppCoilCount(int pallet)
        {
            try
            {
                int coilCount = 0;
                string queryString = string.Empty;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT dbo.fnExternalCoilCountByPallet(" + pallet + ") as coilCount;");
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["coilCount"]);
                }
                return coilCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private double GetLocalWeigth(int pallet, double netWeigth)
        {
            try
            {
                string queryString = string.Empty;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT dbo.fnLocalWeightByPallet(" + pallet + ") as weigth;");
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]);
                }

                if (oppweigth == 0)
                    return oppweigth;
                else
                {
                    if (oppweigth == netweigth)
                        return oppweigth;
                    else
                        return netweigth;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private int GetLocalCoilCont(int pallet)
        {
            try
            {
                int coilCount = 0;
                string queryString = string.Empty;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT dbo.fnLocalCoilsCountByPallet(" + pallet + ") as coilCount;");
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["coilCount"]);
                }
                return coilCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private double GetCoilNumber(int pallet)
        {
            try
            {
                string queryString = string.Empty;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT dbo.spNumberCoilByPallet(" + pallet.ToString() + ") as coil;");
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["coil"]);
                }
                return oppweigth;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex.Message, 3, "GetOppWeigth(" + pallet.ToString() + ")");
                return 0;
            }
        }

        public static List<clsPalletbyCoilCellar> getListMovement(DateTime inidate, DateTime enddate, int codsec)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByReport('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "', " + codsec.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                    lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                    lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                    lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                    lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                    lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                    lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                    lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                    lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                    lstpalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                    lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                    lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                    lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                    lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                    lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                }
            }
            return lstpalletCoilCellar;
        }
        public static List<clsPalletbyCoilCellar> getListMovementByDate(DateTime inidate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                    lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                    lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                    lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                    lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                    lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                    lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                    lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                    lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                    lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                    lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                    lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                    lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                    lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                    lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                    lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                    lstpalletCoilCellar[i].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                    lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                    lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                    lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                    lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                    lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                }
            }
            return lstpalletCoilCellar;
        }
        public static List<clsPalletbyCoilCellar> getListMovementByDateNoShipping(DateTime inidate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() != "Despacho de mercadería")
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        int pos = lstpalletCoilCellar.Count - 1;
                        lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                        lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                        if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                            lstpalletCoilCellar[pos].origin = "BOPP";
                        else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "OPP";
                        else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "MIXTO";
                        else 
                            lstpalletCoilCellar[pos].origin = "-----";
                        lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                    }
                }
            }
            return lstpalletCoilCellar;
        }

        public static List<clsPalletbyCoilCellar> getListMovementByDateNoShipping(DateTime inidate, DateTime enddate, string movement)
        {
            if (movement == "Ingreso Producto Terminado")
                movement = "Ingreso a bodega de producto terminado";
            else if (movement == "Ingreso Stock local")
                movement = "Ingreso a bodega de stock local";
            else if (movement == "Salida Proceso")
                movement = "Salida a bodega de proceso";

            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
            //LOCAL
            //DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (movement == "Ingreso a bodega de stock local")
                    {
                        if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement || DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Ingreso a bodega de stock Perú")
                        {
                            lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                            int pos = lstpalletCoilCellar.Count - 1;
                            lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                            lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                            lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                            lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                            lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                            lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                            lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                            lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                            lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                            lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                            lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                            lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                            lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                            lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                            lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                            lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                            lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                            lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                            lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                            lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                            lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                            if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                                lstpalletCoilCellar[pos].origin = "BOPP";
                            else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                lstpalletCoilCellar[pos].origin = "OPP";
                            else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                lstpalletCoilCellar[pos].origin = "MIXTO";
                            else
                                lstpalletCoilCellar[pos].origin = "-----";
                            lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                            //All Data SIIGO
                            lstPalletAux.Add(lstpalletCoilCellar[pos]);
                            lstpalletCoilCellar[pos].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                            lstpalletCoilCellar[pos].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                            lstpalletCoilCellar[pos].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                            lstpalletCoilCellar[pos].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[pos].siigoCode);
                            lstPalletAux.Clear();
                        }
                    }
                    else
                    {
                        if (movement == "Salida a bodega de proceso")
                        {
                            if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement || DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Salida a bodega de base para metalizar")
                            {
                                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                                int pos = lstpalletCoilCellar.Count - 1;
                                lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                                lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                                lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                                lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                                lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                                lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                                lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                                lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                                lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                                lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                                lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                                lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                                lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                                lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                                lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                                lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                                lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                                lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                                lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                                lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                                lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                                if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                                    lstpalletCoilCellar[pos].origin = "BOPP";
                                else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                    lstpalletCoilCellar[pos].origin = "OPP";
                                else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                    lstpalletCoilCellar[pos].origin = "MIXTO";
                                else
                                    lstpalletCoilCellar[pos].origin = "-----";
                                lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                                //All Data SIIGO
                                lstPalletAux.Add(lstpalletCoilCellar[pos]);
                                lstpalletCoilCellar[pos].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                                lstpalletCoilCellar[pos].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                                lstpalletCoilCellar[pos].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                                lstpalletCoilCellar[pos].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[pos].siigoCode);
                                lstPalletAux.Clear();
                            }
                        }
                        else
                        {
                            if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == movement)
                            {
                                lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                                int pos = lstpalletCoilCellar.Count - 1;
                                lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                                lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                                lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                                lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                                lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                                lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                                lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                                lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                                lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                                lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                                lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                                lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                                lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                                lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                                lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                                lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                                lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                                lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                                lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                                lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                                lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                                if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                                    lstpalletCoilCellar[pos].origin = "BOPP";
                                else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                    lstpalletCoilCellar[pos].origin = "OPP";
                                else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                                    lstpalletCoilCellar[pos].origin = "MIXTO";
                                else
                                    lstpalletCoilCellar[pos].origin = "-----";
                                lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                                //All Data SIIGO
                                lstPalletAux.Add(lstpalletCoilCellar[pos]);
                                lstpalletCoilCellar[pos].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                                lstpalletCoilCellar[pos].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                                lstpalletCoilCellar[pos].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                                lstpalletCoilCellar[pos].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[pos].siigoCode);
                                lstPalletAux.Clear();
                            }
                        }
                    }
                }
            }
            return lstpalletCoilCellar;
        }

        public static List<clsPalletbyCoilCellar> getListMovementByDateShipping(DateTime inidate, DateTime enddate)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
            //LOCAL
            //DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() == "Despacho de mercadería")
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        int pos = lstpalletCoilCellar.Count - 1;
                        lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                        lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                        lstpalletCoilCellar[pos].isImport = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_isImport"]);
                        if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                            lstpalletCoilCellar[pos].origin = "BOPP";
                        else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "OPP";
                        else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "MIXTO";
                        else
                            lstpalletCoilCellar[pos].origin = "-----";
                        lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                        //All Data SIIGO
                        lstPalletAux.Add(lstpalletCoilCellar[pos]);
                        lstpalletCoilCellar[pos].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                        lstpalletCoilCellar[pos].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                        lstpalletCoilCellar[pos].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                        lstpalletCoilCellar[pos].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[pos].siigoCode);
                        lstPalletAux.Clear();
                    }
                }
            }
            return lstpalletCoilCellar;
        }

        public static List<clsPalletbyCoilCellar> getListTrabilityPallet(String palletcode, Boolean palletcodefilter, String product, Boolean productfilter, String customer, Boolean customerfilter, Double initweigth, Double endweigth, Boolean weigthfilter, String order, Boolean orderfilter, Int32 initwidth, Int32 endwidth, Boolean widthfilter)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            if (palletcodefilter && !productfilter && !customerfilter && !weigthfilter && !orderfilter && !widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'palletcode')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            else if (!palletcodefilter && productfilter && !customerfilter && !weigthfilter && !orderfilter && !widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','%" + product + "%','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'product')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            else if (!palletcodefilter && !productfilter && customerfilter && !weigthfilter && !orderfilter && !widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','%" + customer + "%'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'customer')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            else if (!palletcodefilter && !productfilter && !customerfilter && weigthfilter && !orderfilter && !widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'weigth')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            else if (!palletcodefilter && !productfilter && !customerfilter && !weigthfilter && orderfilter && !widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'%" + order + "%'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'order')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            else if (!palletcodefilter && !productfilter && !customerfilter && !weigthfilter && !orderfilter && widthfilter)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletTrazabilityCellar('" + palletcode + "','" + product + "','" + customer + "'," + initweigth.ToString() + "," + endweigth.ToString() + ",'" + order + "'," + initwidth.ToString() + "," + endwidth.ToString() + ", 'width')");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[i].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[i].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[i].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[i].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[i].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[i].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[i].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                    }
                }
            }
            return lstpalletCoilCellar;
        }

        public static List<clsPalletbyCoilCellar> getListMovementByDateNoShipping(DateTime inidate, DateTime enddate, string movement, bool mydata)
        {
            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();
            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();
            //SERVER
            DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");
            //LOCAL
            //DS = clsConnection.getDataSetResult("CALL spPalletMovementByDate('" + inidate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["pcc_movement"].ToString() != "Despacho de mercadería")
                    {
                        lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                        int pos = lstpalletCoilCellar.Count - 1;
                        lstpalletCoilCellar[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_codsec"]);
                        lstpalletCoilCellar[pos].fkcoilcellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkcoilcellar"]);
                        lstpalletCoilCellar[pos].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_fkpallet"]);
                        lstpalletCoilCellar[pos].ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_in"], DS.Tables[0].Rows[i]["pcc_in"].GetType().FullName);
                        lstpalletCoilCellar[pos].output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pcc_out"], DS.Tables[0].Rows[i]["pcc_out"].GetType().FullName);
                        lstpalletCoilCellar[pos].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["pcc_date"]);
                        lstpalletCoilCellar[pos].movement = DS.Tables[0].Rows[i]["pcc_movement"].ToString();
                        lstpalletCoilCellar[pos].code = DS.Tables[0].Rows[i]["pcc_code"].ToString();
                        lstpalletCoilCellar[pos].producto = DS.Tables[0].Rows[i]["pcc_producto"].ToString();
                        lstpalletCoilCellar[pos].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_palletnumber"]);
                        lstpalletCoilCellar[pos].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_coilnumber"]);
                        lstpalletCoilCellar[pos].customer = DS.Tables[0].Rows[i]["pcc_customer"].ToString();
                        lstpalletCoilCellar[pos].order = DS.Tables[0].Rows[i]["pcc_order"].ToString();
                        lstpalletCoilCellar[pos].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_width"]);
                        lstpalletCoilCellar[pos].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_netweigth"]);
                        lstpalletCoilCellar[pos].createdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createddate"]);
                        lstpalletCoilCellar[pos].wasExportedToSystem = Convert.ToBoolean(DS.Tables[0].Rows[i]["pcc_wasExportedToSystem"]);
                        lstpalletCoilCellar[pos].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_localweigth"]);
                        lstpalletCoilCellar[pos].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pcc_oppweigth"]);
                        lstpalletCoilCellar[pos].localCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_localCoils"]);
                        lstpalletCoilCellar[pos].oppCoils = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_oppCoils"]);
                        lstpalletCoilCellar[pos].isImport = Convert.ToInt32(DS.Tables[0].Rows[i]["pcc_isImport"]);
                        if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils == 0)
                            lstpalletCoilCellar[pos].origin = "BOPP";
                        else if (lstpalletCoilCellar[pos].localCoils == 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "OPP";
                        else if (lstpalletCoilCellar[pos].localCoils > 0 && lstpalletCoilCellar[pos].oppCoils > 0)
                            lstpalletCoilCellar[pos].origin = "MIXTO";
                        else
                            lstpalletCoilCellar[pos].origin = "-----";
                        lstpalletCoilCellar[pos].ObjProduct = new clsProduct(lstpalletCoilCellar[pos].producto);
                        //All Data SIIGO
                        lstPalletAux.Add(lstpalletCoilCellar[pos]);
                        lstpalletCoilCellar[pos].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                        lstpalletCoilCellar[pos].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                        lstpalletCoilCellar[pos].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                        lstpalletCoilCellar[pos].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[pos].siigoCode);
                        lstPalletAux.Clear();
                    }
                }
            }
            return lstpalletCoilCellar;
        }

        public static List<clsPalletbyCoilCellar> getAccumulatedOrder(List<clsPalletbyCoilCellar> lstPallet)
        {
            string myList = "";

            for (int i = 0; i < lstPallet.Count; i++)
            {
                myList += lstPallet[i].codsec;
                myList += ((i < lstPallet.Count - 1) ? ";" : "");
            }

            DataSet DS = new DataSet();
            List<clsPalletbyCoilCellar> lstpalletCoilCellar = new List<clsPalletbyCoilCellar>();

            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();

            //SERVER
            DS = clsConnection.getDataSetResult("spPalletListByCellarAccumulated '" + myList + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstpalletCoilCellar.Add(new clsPalletbyCoilCellar());
                    lstpalletCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    lstpalletCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["dates"]);
                    lstpalletCoilCellar[i].code = DS.Tables[0].Rows[i]["film"].ToString();
                    lstpalletCoilCellar[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pallet"]);
                    lstpalletCoilCellar[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["coil"]);
                    lstpalletCoilCellar[i].customer = DS.Tables[0].Rows[i]["customer"].ToString();
                    lstpalletCoilCellar[i].order = DS.Tables[0].Rows[i]["ordernumber"].ToString();
                    lstpalletCoilCellar[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["width"]);
                    lstpalletCoilCellar[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]);
                    lstpalletCoilCellar[i].localweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["localweigth"]);
                    lstpalletCoilCellar[i].oppweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["oppweigth"]);
                    lstpalletCoilCellar[i].origin = DS.Tables[0].Rows[i]["origin"].ToString();
                    lstpalletCoilCellar[i].filmBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["filmcodsecbopp"]);
                    lstpalletCoilCellar[i].filmOpp = Convert.ToInt32(DS.Tables[0].Rows[i]["filmcodsecopp"]);

                    if (lstpalletCoilCellar[i].filmBopp > 0 && lstpalletCoilCellar[i].filmOpp == 0)
                        lstpalletCoilCellar[i].ObjProduct = new clsProduct(lstpalletCoilCellar[i].filmBopp);
                    else
                        lstpalletCoilCellar[i].ObjProduct = new clsProduct(lstpalletCoilCellar[i].filmOpp);

                    lstpalletCoilCellar[i].movement = DS.Tables[0].Rows[i]["movement"].ToString().Replace("/(1000)PALLET/(1000)BOBINAS/", "/(" + lstpalletCoilCellar[i].palletnumber + ")P/(" + lstpalletCoilCellar[i].coilnumber + ")B/");


                    lstpalletCoilCellar[i].fkproductalfa = Convert.ToInt32(DS.Tables[0].Rows[i]["fkproduct"]);
                    ////All Data SIIGO
                    //lstPalletAux.Add(lstpalletCoilCellar[i]);
                    //lstpalletCoilCellar[i].siigoCellar = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                    //lstpalletCoilCellar[i].siigoMovement = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                    //lstpalletCoilCellar[i].siigoCode = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                    //lstpalletCoilCellar[i].siigoReference = clsXportCellarMovementsToSIIGO.ReferenceCellar(lstpalletCoilCellar[i].siigoCode);
                    //lstPalletAux.Clear();
                }
            }
            return lstpalletCoilCellar;
        }
    }
}
