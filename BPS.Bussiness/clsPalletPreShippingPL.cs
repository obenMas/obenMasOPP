using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
    public class clsPalletPreShippingPL
    {
        //Atributes

        private int palshippl_codsec;
        private int palshippl_fksalesorderdetail;
        private string palshippl_palletcode;
        private int palshippl_number;
        private DateTime palshippl_date;
        private DateTime palshippl_modifieddate;
        private int palshippl_createdby;
        private int palshippl_modifiedby;
        private string palshippl_remito;
        private DateTime palshippl_programmeddate;
        private string entt_companyname;
        
        
        /*private string prod_code;
        private string sord_number;
        private int plt_palletNumber;
        private int pbsod_coilnumber;
        private double plt_netWeight;
        
        private string plt_lotnumber;
        private string palship_remito;
         */

      
        //Properties

        public int codsec { get { return palshippl_codsec; } set { palshippl_codsec = value; } }

        public int fksalesorderdetail { get { return palshippl_fksalesorderdetail; } set { palshippl_fksalesorderdetail = value; } }

        public string palletcode { get { return palshippl_palletcode; } set { palshippl_palletcode = value; } }

        public int number { get { return palshippl_number; } set { palshippl_number = value; } }

        public DateTime date { get { return palshippl_date; } set { palshippl_date = value; } }

        public DateTime modifieddate { get { return palshippl_modifieddate; } set { palshippl_modifieddate = value; } }

        public int createdby { get { return palshippl_createdby; } set { palshippl_createdby = value; } }

        public int modifiedby { get { return palshippl_modifiedby; } set { palshippl_modifiedby = value; } }

        public string remito { get { return palshippl_remito; } set { palshippl_remito = value; } }

        public DateTime programmeddate { get { return palshippl_programmeddate; } set { palshippl_programmeddate = value; } }

        public string companyname { get { return entt_companyname; } set { entt_companyname = value; } }

        //Constructor

        public clsPalletPreShippingPL()
        {
            palshippl_codsec = 0;
            palshippl_fksalesorderdetail = 0;
            palshippl_palletcode = string.Empty;
            palshippl_number = 0;
            palshippl_date = DateTime.Now;
            palshippl_modifieddate = DateTime.Now;
            palshippl_createdby = 0;
            palshippl_modifiedby = 0;
            palshippl_remito = string.Empty;
            palshippl_programmeddate = DateTime.Now;
            entt_companyname = string.Empty;
        }

        public clsPalletPreShippingPL(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshippingPL WHERE palshippl_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                this.fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                this.palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                this.number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                this.modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                this.createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                this.modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                this.remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                this.programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
            }
        }

        public static int GetOrdinalNumber()
        {
            int seq = clsSequential.SequentialList("preshippingpl");
            clsSequential.addSequential("preshippingpl");
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

                
                queryString += "DELETE bps_prod_palletpreshippingPL WHERE ";
                queryString += "palshippl_number = "+pre.ToString();
                queryString += " AND ";
                queryString += "palshippl_palletcode = '"+code+"'";
  

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
                
           }
           catch (Exception ex)
           {
               clsLog.addLog(ex, 3, "clsPalletPreShippingPL.save");
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
                    queryString += "INSERT INTO bps_prod_palletpreshippingPL (palshippl_fksalesorderdetail, palshippl_palletcode, palshippl_number, palshippl_date, palshippl_modifieddate, palshippl_createdby,palshippl_modifiedby, palshippl_remito, palshippl_programmeddate)";
                    queryString += " VALUES ( ";
                    queryString += this.fksalesorderdetail + ", ";
                    queryString += "'" + this.palletcode + "', ";
                    queryString += this.number + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "'" + this.modifieddate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += clsGlobal.LoggedUser.codsec + ", "; //creado por
                    queryString += clsGlobal.LoggedUser.codsec + ", "; //modificado por
                    queryString += "'" + this.remito + "', ";
                    queryString += "'" + this.programmeddate.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_palletpreshippingPL";
                    queryString += " SET ";
                    queryString += "palshippl_fksalesorderdetail = " + this.fksalesorderdetail + ", ";
                    queryString += "palshippl_palletcode = '" + this.palletcode + "', ";
                    queryString += "palshippl_number = " + this.number + ", ";
                    queryString += "' " + this.date.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "' " + this.modifieddate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "palshippl_createdby =" + this.createdby + ", ";
                    queryString += "palshippl_modifiedby =" + this.modifiedby + ", ";
                    queryString += "palshippl_remito = '" + this.remito + "', ";
                    queryString += "' " + this.programmeddate.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
                    queryString += " WHERE palshippl_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletPreShippingPL.save");
                return false;
            }
        }

        public static List<clsPalletPreShippingPL> getList()
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshippingPL order by palshippl_codsec asc");

            lstPalletPreShippingPL.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                lstPalletPreShippingPL[i].fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                lstPalletPreShippingPL[i].palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                lstPalletPreShippingPL[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                lstPalletPreShippingPL[i].modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                lstPalletPreShippingPL[i].createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                lstPalletPreShippingPL[i].modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
            }

            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getListPreShipping()
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingListPL()");
            lstPalletPreShippingPL.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palshippl_number"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[i]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString(); 

                
            }
            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getListByCodsec(int codsec)
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshippingPL WHERE palshippl_codsec = '" + codsec.ToString() + "' order by palshippl_codsec asc");

            lstPalletPreShippingPL.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                lstPalletPreShippingPL[i].fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                lstPalletPreShippingPL[i].palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                lstPalletPreShippingPL[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                lstPalletPreShippingPL[i].modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                lstPalletPreShippingPL[i].createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                lstPalletPreShippingPL[i].modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
            }

            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getListByNumber(string number)
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingByNumberPL(" + number + ")");
            lstPalletPreShippingPL.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[i]["palshippl_number"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[i]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString(); 
            }
            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getListByCodePallet(string palletcode)
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshippingPL WHERE palshippl_palletcode = '" + palletcode + "' order by palshippl_codsec asc");

            lstPalletPreShippingPL.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                lstPalletPreShippingPL[i].fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                lstPalletPreShippingPL[i].palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                lstPalletPreShippingPL[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                lstPalletPreShippingPL[i].modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                lstPalletPreShippingPL[i].createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                lstPalletPreShippingPL[i].modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
            }

            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getListByCodsecSalesOrder(int codsec)
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletpreshippingPL WHERE palshippl_fksalesorderdetail = '" + codsec.ToString() + "' order by palshippl_codsec asc");

            lstPalletPreShippingPL.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                lstPalletPreShippingPL[i].fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                lstPalletPreShippingPL[i].palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                lstPalletPreShippingPL[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                lstPalletPreShippingPL[i].modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                lstPalletPreShippingPL[i].createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                lstPalletPreShippingPL[i].modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
            }
            return lstPalletPreShippingPL;
        }

        public static List<clsPalletPreShippingPL> getPalletListBySalesOrderNumber(string number)
        {
            List<clsPalletPreShippingPL> lstPalletPreShippingPL = new List<clsPalletPreShippingPL>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrder('" + number + "')");
            lstPalletPreShippingPL.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {

                lstPalletPreShippingPL.Add(new clsPalletPreShippingPL());
                lstPalletPreShippingPL[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_codsec"]);
                lstPalletPreShippingPL[i].fksalesorderdetail = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_fksalesorderdetail"]);
                lstPalletPreShippingPL[i].palletcode = DS.Tables[0].Rows[0]["palshippl_palletcode"].ToString();
                lstPalletPreShippingPL[i].number = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_number"]);
                lstPalletPreShippingPL[i].date = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_date"]);
                lstPalletPreShippingPL[i].modifieddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_modifieddate"]);
                lstPalletPreShippingPL[i].createdby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_createdby"]);
                lstPalletPreShippingPL[i].modifiedby = Convert.ToInt32(DS.Tables[0].Rows[0]["palshippl_modifiedby"]);
                lstPalletPreShippingPL[i].remito = DS.Tables[0].Rows[0]["palshippl_remito"].ToString();
                lstPalletPreShippingPL[i].programmeddate = Convert.ToDateTime(DS.Tables[0].Rows[0]["palshippl_programmeddate"]);
                
                
                /*lstPalletPreShipping.Add(new clsPalletPreShippingPL());
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
                lstPalletPreShipping[i].remito = DS.Tables[0].Rows[i]["palship_remito"].ToString();*/
            }
            return lstPalletPreShippingPL;
        }
    }
}

