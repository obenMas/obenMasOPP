using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletPreShipping
    {
        //Atributes

        private int palship_codsec;
        private int palship_fkpallet;
        private clsPallet palship_pallet;
        private int palship_fksalesorder;
        private clsSalesOrder palship_salesorder;
        private string palship_code;
        private int palship_number;
        private DateTime palship_date;
        private DateTime palship_modifieddate;
        private DateTime palship_programmeddate;
        private int palship_createdby;
        private int palship_modifiedby;
        private bool palship_isinternational;
        private int plt_fkStatus;
        private bool palship_nodate;
        private string palship_plant;
        

        private string prod_code;
        private string sord_number;
        private int plt_palletNumber;
        private int pbsod_coilnumber;
        private double plt_netWeight;
        private string entt_companyname;
        private string plt_lotnumber;
        private string palship_remito;

      
        //Properties

        public int codsec { get { return palship_codsec; } set { palship_codsec = value; } }

        public string code { get { return palship_code; } set { palship_code = value; } }

        public int number { get { return palship_number; } set { palship_number = value; } }

        public int fkpallet { get { return palship_fkpallet; } set { palship_fkpallet = value; } }

        public clsPallet pallet { get { return palship_pallet; } set { palship_pallet = value; } }

        public int fksalesorder { get { return palship_fksalesorder; } set { palship_fksalesorder = value; } }

        public clsSalesOrder salesorder { get { return palship_salesorder; } set { palship_salesorder = value; } }

        public DateTime date { get { return palship_date; } set { palship_date = value; } }

        public DateTime modifieddate { get { return palship_modifieddate; } set { palship_modifieddate = value; } }

        public DateTime programmeddate { get { return palship_programmeddate; } set { palship_programmeddate = value; } }

        public int createdby { get { return palship_createdby; } set { palship_createdby = value; } }

        public int modifiedby { get { return palship_modifiedby; } set { palship_modifiedby = value; } }

        public string codeproduct { get { return prod_code; } set { prod_code = value; } }

        public string salesordernumber { get { return sord_number; } set { sord_number = value; } }

        public int palletnumber { get { return plt_palletNumber; } set { plt_palletNumber = value; } }

        public int coilnumber { get { return pbsod_coilnumber; } set { pbsod_coilnumber = value; } }

        public double netweight { get { return plt_netWeight; } set { plt_netWeight = value; } }

        public string companyname { get { return entt_companyname; } set { entt_companyname = value; } }

        public string lotnumber { get { return plt_lotnumber; } set { plt_lotnumber = value; } }

        public bool isinternational { get { return palship_isinternational; } set { palship_isinternational = value; } }

        public int fkStatus { get { return plt_fkStatus; } set { plt_fkStatus = value; } }

        public string remito { get { return palship_remito; } set { palship_remito = value; } }

        public bool nodate { get { return palship_nodate; } set { palship_nodate = value; } }

        public string plant { get { return palship_plant; } set { palship_plant = value; } }
        
        //Constructor
        public clsPalletPreShipping()
        {
            palship_codsec = 0;
            palship_fkpallet = 0;
            palship_pallet = new clsPallet();
            palship_fksalesorder = 0;
            palship_salesorder = new clsSalesOrder();
            palship_code = string.Empty;
            palship_number = 0;
            palship_date = DateTime.Now;
            palship_modifieddate = DateTime.Now;
            palship_programmeddate = DateTime.Now;
            palship_createdby = 0;
            palship_modifiedby = 0;
            prod_code = string.Empty;
            sord_number = string.Empty;
            plt_palletNumber = 0;
            pbsod_coilnumber = 0;
            plt_netWeight = 0;
            entt_companyname = string.Empty;
            plt_lotnumber = string.Empty;
            palship_isinternational = false;
            plt_fkStatus = 0;
            palship_remito = string.Empty;
            palship_nodate = false;
            palship_plant = string.Empty;
        }

        public clsPalletPreShipping(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping where palship_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palship_codsec"]);
                this.fkpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["palship_fkpallet"]);
                this.pallet = new clsPallet(this.fkpallet);
                this.fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[0]["palship_fksalesorder"]);
                this.salesorder = new clsSalesOrder(this.fksalesorder);
                this.code = DS.Tables[0].Rows[0]["palship_code"].ToString();
                this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["palship_number"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palship_date"]);
                this.programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palship_programmeddate"]);
                this.palship_remito = DS.Tables[0].Rows[0]["palship_remito"].ToString();
                this.palship_nodate = Convert.ToBoolean(DS.Tables[0].Rows[0]["palship_nodate"]);
            }
        }

        public static int GetOrdinalNumber()
        {
            int seq = clsSequential.SequentialList("preshipping");
            clsSequential.addSequential("preshipping");
            return seq;
            /*DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT palship_number FROM bps_prod_palletpreshipping ORDER BY palship_codsec DESC");
            if (DS.Tables[0].Rows.Count > 0)
            {
                if (DS.Tables[0].Rows[0]["palship_number"].ToString() == null || DS.Tables[0].Rows[0]["palship_number"].ToString() == string.Empty)
                    return 0;
                else
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["palship_number"]);
            }
            else
                return 0;*/
        }

        public static bool delete(int pre, string code)
        {
            try
            {
                string queryString = "";

                
                queryString += "DELETE bps_prod_palletpreshipping WHERE ";
                queryString += "palship_number = "+pre.ToString();
                queryString += " AND ";
                queryString += "palship_code = '"+code+"'";
  

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
                
           }
           catch (Exception ex)
           {
               clsLog.addLog(ex, 3, "clsPalletPreShipping.save");
               return false;
           }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_palletpreshipping (palship_fkpallet, palship_fksalesorder, palship_code, palship_number, palship_date, palship_modifieddate,palship_programmeddate, palship_createdby, palship_modifiedby, palship_isinternational, palship_remito, palship_nodate)";
                    queryString += " VALUES ( ";
                    queryString += this.fkpallet + ", ";
                    queryString += this.fksalesorder + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += "'" + this.number + "', ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.modifieddate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.palship_programmeddate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += clsGlobal.LoggedUser.codsec + ", ";
                    queryString += clsGlobal.LoggedUser.codsec + ", ";
                    queryString += this.isinternational + ", ";
                    queryString += "0, ";
                    queryString += this.nodate.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_palletpreshipping";
                    queryString += " SET ";
                    queryString += "palship_fkpallet = " + this.fkpallet + ", ";
                    queryString += "palship_fksalesorder = " + this.fksalesorder + ", ";
                    queryString += "palship_code = '" + this.code + "',";
                    queryString += "palship_number = '" + this.number + "', ";
                    queryString += "palship_modifieddate ='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.palship_programmeddate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "palship_modifiedby = " + clsGlobal.LoggedUser.codsec + ", ";
                    queryString += "palship_isinternational ="+this.isinternational + ", ";
                    queryString += "palship_remito = "+this.remito+", ";
                    queryString += "palship_nodate = " + this.palship_nodate;
                    queryString += " WHERE palship_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletPreShipping.save");
                return false;
            }
        }

        public static List<clsPalletPreShipping> getList()
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping order by palship_codsec asc");

            lstPalletPreShipping.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_codsec"]);
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fkpallet"]);
                lstPalletPreShipping[i].pallet = new clsPallet(lstPalletPreShipping[i].fkpallet);
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fksalesorder"]);
                lstPalletPreShipping[i].salesorder = new clsSalesOrder(lstPalletPreShipping[i].fksalesorder);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["palship_code"].ToString();
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_programmeddate"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListPreShipping()
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingList()");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].entt_companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
            }
            return lstPalletPreShipping;
        }


        public static List<clsPalletPreShipping> getListPreShippingBySelTOP(int quant)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingListBySelTOP("+ quant.ToString()+")");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].entt_companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstPalletPreShipping[i].palship_plant = DS.Tables[0].Rows[i]["plant_name"].ToString();
            }
            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByCodsec(int codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping WHERE palship_codsec = '" + codsec.ToString() + "' order by palship_codsec asc");

            lstPalletPreShipping.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_codsec"]);
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fkpallet"]);
                lstPalletPreShipping[i].pallet = new clsPallet(lstPalletPreShipping[i].fkpallet);
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fksalesorder"]);
                lstPalletPreShipping[i].salesorder = new clsSalesOrder(lstPalletPreShipping[i].fksalesorder);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["palship_code"].ToString();
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_programmeddate"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByNumber(string codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingByNumber(" + codsec + ")");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].entt_companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
            }
            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByNumberCompiled(string codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingDetail('" + codsec + "')");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                lstPalletPreShipping[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                lstPalletPreShipping[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_coilnumber"]);
                lstPalletPreShipping[i].netweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                lstPalletPreShipping[i].lotnumber = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                lstPalletPreShipping[i].salesordernumber = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstPalletPreShipping[i].companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstPalletPreShipping[i].codeproduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByCodePallet(string codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping WHERE palship_code = '" + codsec + "' order by palship_codsec asc");

            lstPalletPreShipping.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_codsec"]);
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fkpallet"]);
                lstPalletPreShipping[i].pallet = new clsPallet(lstPalletPreShipping[i].fkpallet);
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fksalesorder"]);
                lstPalletPreShipping[i].salesorder = new clsSalesOrder(lstPalletPreShipping[i].fksalesorder);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["palship_code"].ToString();
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_programmeddate"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByCodsecPallet(int codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping WHERE palship_fkpallet = '" + codsec.ToString() + "' order by palship_codsec asc");

            lstPalletPreShipping.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_codsec"]);
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fkpallet"]);
                lstPalletPreShipping[i].pallet = new clsPallet(lstPalletPreShipping[i].fkpallet);
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fksalesorder"]);
                lstPalletPreShipping[i].salesorder = new clsSalesOrder(lstPalletPreShipping[i].fksalesorder);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["palship_code"].ToString();
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_programmeddate"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getListByCodsecSalesOrder(int codsec)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshipping WHERE palship_fksalesorder = '" + codsec.ToString() + "' order by palship_codsec asc");

            lstPalletPreShipping.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_codsec"]);
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fkpallet"]);
                lstPalletPreShipping[i].pallet = new clsPallet(lstPalletPreShipping[i].fkpallet);
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_fksalesorder"]);
                lstPalletPreShipping[i].salesorder = new clsSalesOrder(lstPalletPreShipping[i].fksalesorder);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["palship_code"].ToString();
                lstPalletPreShipping[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palship_number"]);
                lstPalletPreShipping[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_date"]);
                lstPalletPreShipping[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["palship_programmeddate"]);
                lstPalletPreShipping[i].isinternational = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["palship_isinternational"], DS.Tables[0].Rows[i]["palship_isinternational"].GetType().FullName);
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }

            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getPalletListBySalesOrderNumberOnlyPT(string number)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrderOPT('" + number + "')");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_fkPallet"]);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                lstPalletPreShipping[i].codeproduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstPalletPreShipping[i].salesordernumber = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstPalletPreShipping[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                lstPalletPreShipping[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_coilnumber"]);
                lstPalletPreShipping[i].netweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                lstPalletPreShipping[i].companyname = DS.Tables[0].Rows[i]["plt_delivery"].ToString();
                lstPalletPreShipping[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                //lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
                //lstPalletPreShipping[i].nodate = Convert.ToBoolean(DS.Tables[0].Rows[i]["palship_nodate"]);
            }
            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getPalletListBySalesOrderNumber(string number)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrder('" + number + "')");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_fkPallet"]);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                lstPalletPreShipping[i].codeproduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstPalletPreShipping[i].salesordernumber = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstPalletPreShipping[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                lstPalletPreShipping[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_coilnumber"]);
                lstPalletPreShipping[i].netweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                lstPalletPreShipping[i].companyname = DS.Tables[0].Rows[i]["plt_delivery"].ToString();
                lstPalletPreShipping[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_fkStatus"]);
                //lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
            }
            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getInternationalPalletListBySalesOrderNumber(string number)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrder('" + number + "')");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_fkPallet"]);
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
                lstPalletPreShipping[i].codeproduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstPalletPreShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstPalletPreShipping[i].salesordernumber = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstPalletPreShipping[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_palletNumber"]);
                lstPalletPreShipping[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pbsod_coilnumber"]);
                lstPalletPreShipping[i].netweight = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                lstPalletPreShipping[i].companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();
            }
            return lstPalletPreShipping;
        }

        public static List<clsPalletPreShipping> getPalletListBySalesOrderNumberForAllDelivery(string number)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrder('" + number + "')");
            lstPalletPreShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShipping.Add(new clsPalletPreShipping());
                lstPalletPreShipping[i].code = DS.Tables[0].Rows[i]["plt_code"].ToString();
            }
            return lstPalletPreShipping;
        }
    }
}
