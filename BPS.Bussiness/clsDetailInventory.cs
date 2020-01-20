using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDetailInventory
    {
        // Attributes
        private int invdet_codsec;
        private int invdet_fkinventory;
        private int invdet_fkpallet;
        private String invdet_code;
        private int invdet_fkproduct;
        private String invdet_productName;
        private Double invdet_netweigth;
        private int invdet_palletnumber;
        private int invdet_coilnumber;
        private string invdet_diference;

        public string diference
        {
            get { return invdet_diference; }
            set { invdet_diference = value; }
        }

        private double invdet_coilnet;

        public double coilnet
        {
            get { return invdet_coilnet; }
            set { invdet_coilnet = value; }
        }

        private int invdet_fkCoilcellar;


        public int fkcoilcellar
        {
            get { return invdet_fkCoilcellar; }
            set { invdet_fkCoilcellar = value; }
        }

        private string invdet_Cellar;

        public string cellar
        {
            get { return invdet_Cellar; }
            set { invdet_Cellar = value; }
        }

        private string invdet_salesordernumber;

        public string order
        {
            get { return invdet_salesordernumber; }
            set { invdet_salesordernumber = value; }
        }

        private string invdet_customer;

        public string customer
        {
            get { return invdet_customer; }
            set { invdet_customer = value; }
        }


        private string invdet_nave;

        public string nave
        {
            get { return invdet_nave; }
            set { invdet_nave = value; }
        }


        // Properties
        public int codsec { get { return invdet_codsec; } set { invdet_codsec = value; } }

        public int inventarycodsec { get { return invdet_fkinventory; } set { invdet_fkinventory = value; } }

        public int fkpallet { get { return invdet_fkpallet; } set { invdet_fkpallet = value; } }

        public String code { get { return invdet_code; } set { invdet_code = value; } }

        public int fkproduct { get { return invdet_fkproduct; } set { invdet_fkproduct = value; } }

        public String productname { get { return invdet_productName; } set { invdet_productName = value; } }

        public Double netweigth { get { return invdet_netweigth; } set { invdet_netweigth = value; } }

        public int palletnumber { get { return invdet_palletnumber; } set { invdet_palletnumber = value; } }

        public int coilnumber { get { return invdet_coilnumber; } set { invdet_coilnumber = value; } }


        // Constructor
        public clsDetailInventory()
        {
            codsec = 0;
            inventarycodsec = 0;
            fkpallet = 0;
            code = String.Empty;
            fkproduct = 0;
            productname = String.Empty;
            netweigth = 0;
            palletnumber = 0;
            coilnumber = 0;
        }

        // Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_detailinventory where invdet_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_codsec"]);
                this.inventarycodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_fkinventory"]);
                this.fkpallet = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_fkpallet"]);
                this.code = DS.Tables[0].Rows[0]["invdet_code"].ToString();
                this.fkproduct = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_fkproduct"]);
                this.productname = DS.Tables[0].Rows[0]["invdet_productname"].ToString();
                this.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["invdet_netweigth"]);
                this.palletnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_palletnumber"]);
                this.coilnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["invdet_coilnumber"]);
            }
        }


        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_detailinventory (invdet_fkinventory, invdet_fkpallet, invdet_code, invdet_fkproduct, invdet_productname," +
                    "invdet_netweigth, invdet_palletnumber, invdet_coilnumber, invdet_nave)";
                    queryString += " VALUES (";
                    queryString += " " + this.inventarycodsec + ", ";
                    queryString += " " + this.fkpallet.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += " " + this.fkproduct.ToString() + ", ";
                    queryString += "'" + this.productname.ToString() + "', ";
                    queryString += " " + this.netweigth.ToString() + ", ";
                    queryString += " " + this.palletnumber.ToString() + ", ";
                    queryString += " " + this.coilnumber.ToString() + ", ";
                    queryString += "'" + this.nave.ToString() + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_inventory ";
                    queryString += " SET ";
                    queryString += " invdet_fkinventory = " + this.inventarycodsec.ToString() + ",";
                    queryString += " invdet_fkpallet = " + this.fkpallet.ToString() + ",";
                    queryString += " invdet_code = '" + this.code.ToString() + "',";
                    queryString += " invdet_fkproduct = " + this.fkproduct.ToString() + ",";
                    queryString += " invdet_productname = '" + this.productname.ToString() + "' ";
                    queryString += " invdet_netweigth = " + this.netweigth.ToString() + ",";
                    queryString += " invdet_palletnumber = " + this.palletnumber.ToString() + ",";
                    queryString += " invdet_coilnumber = " + this.coilnumber.ToString() + ",";
                    queryString += " invdet_diference = '" + this.diference.ToString() + "',";
                    queryString += " invdet_fkCoilcellar = " + this.fkcoilcellar.ToString() + ",";
                    queryString += " invdet_Cellar = '" + this.cellar.ToString() + "',";
                    queryString += " invdet_salesordernumber = '" + this.order.ToString() + "',";
                    queryString += " invdet_customer = '" + this.customer.ToString() + "',";
                    queryString += " WHERE invdet_codsec =  " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDetailInventory.save");
                return false;
            }
        }

        public static List<clsDetailInventory> getListByInventory(int codsec)
        {
            List<clsDetailInventory> lstDetailInventory = new List<clsDetailInventory>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_detailinventory WHERE invdet_fkinventory =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDetailInventory.Add(new clsDetailInventory());
                    lstDetailInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_codsec"]);
                    lstDetailInventory[i].inventarycodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkinventory"]);
                    lstDetailInventory[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkpallet"]);
                    lstDetailInventory[i].code = DS.Tables[0].Rows[i]["invdet_code"].ToString();
                    lstDetailInventory[i].fkproduct = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkproduct"]);
                    lstDetailInventory[i].productname = DS.Tables[0].Rows[i]["invdet_productname"].ToString();
                    lstDetailInventory[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["invdet_netweigth"]);
                    lstDetailInventory[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_palletnumber"]);
                    lstDetailInventory[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_coilnumber"]);
                    lstDetailInventory[i].nave = DS.Tables[0].Rows[i]["invdet_nave"].ToString();
                    lstDetailInventory[i].pos = int.Parse(DS.Tables[0].Rows[i]["invdet_nave"].ToString().Replace("N - ", ""));
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstDetailInventory;
        }

        public static int getTotalRecordByInventory(int codsec)
        {
            var mycount = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COUNT(*) AS count_record FROM bps_prod_detailinventory WHERE invdet_fkinventory =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    mycount = Convert.ToInt32(DS.Tables[0].Rows[i]["count_record"]);
            }
            return mycount;
        }

        public static int getTotalWeigthByInventory(int codsec)
        {
            var myweigth = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT SUM(invdet_netweigth) AS invdet_netweigth FROM bps_prod_detailinventory WHERE invdet_fkinventory =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    myweigth = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_netweigth"]);
            }
            return myweigth;
        }

        public static List<clsDetailInventory> getListByInventoryRePro(int codsec)
        {
            List<clsDetailInventory> lstDetailInventory = new List<clsDetailInventory>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_detailinventory WHERE invdet_fkinventory =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDetailInventory.Add(new clsDetailInventory());
                    lstDetailInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_codsec"]);
                    lstDetailInventory[i].inventarycodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkinventory"]);
                    lstDetailInventory[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkpallet"]);
                    lstDetailInventory[i].code = DS.Tables[0].Rows[i]["invdet_code"].ToString();
                    lstDetailInventory[i].productname = DS.Tables[0].Rows[i]["invdet_productname"].ToString();
                    lstDetailInventory[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["invdet_netweigth"]);
                    lstDetailInventory[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_palletnumber"]);
                    lstDetailInventory[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_coilnumber"]);
                    lstDetailInventory[i].nave = DS.Tables[0].Rows[i]["invdet_nave"].ToString();
                    lstDetailInventory[i].pos = int.Parse(DS.Tables[0].Rows[i]["invdet_nave"].ToString().Replace("N - ", ""));
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstDetailInventory;
        }

        public static List<clsDetailInventory> getListByInventoryRaw(int codsec)
        {
            List<clsDetailInventory> lstDetailInventory = new List<clsDetailInventory>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_detailinventory WHERE invdet_fkinventory =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDetailInventory.Add(new clsDetailInventory());
                    lstDetailInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_codsec"]);
                    lstDetailInventory[i].inventarycodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkinventory"]);
                    lstDetailInventory[i].fkpallet = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_fkpallet"]);
                    lstDetailInventory[i].code = DS.Tables[0].Rows[i]["invdet_code"].ToString();
                    lstDetailInventory[i].productname = DS.Tables[0].Rows[i]["invdet_productname"].ToString();
                    lstDetailInventory[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["invdet_netweigth"]);
                    lstDetailInventory[i].palletnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_palletnumber"]);
                    lstDetailInventory[i].coilnumber = Convert.ToInt32(DS.Tables[0].Rows[i]["invdet_coilnumber"]);
                    lstDetailInventory[i].nave = DS.Tables[0].Rows[i]["invdet_nave"].ToString();
                    lstDetailInventory[i].pos = int.Parse(DS.Tables[0].Rows[i]["invdet_nave"].ToString().Replace("N - ", ""));
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstDetailInventory;
        }

        public int pos { get; set; }
    }
}
