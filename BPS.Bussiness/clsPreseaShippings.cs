using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPreseaShippings
    {
        private int ps_codsec;
        private double ps_number;
        private string ps_type;
        private double ps_customerId;
        private string ps_customerName;
        private DateTime ps_date;
        private string ps_code;
        private double ps_price;
        private double ps_quantity;
        private double ps_iva;
        private string ps_detail;
        private string ps_user;
        private string ps_origin;
        private string ps_origin2;
        private string ps_saleOrder;
        private string ps_observation;

        public int codsec { get { return ps_codsec; } set { ps_codsec = value; } }
        public double number { get { return ps_number; } set { ps_number = value; } }
        public string type { get { return ps_type; } set { ps_type = value; } }
        public double customerId { get { return ps_customerId; } set { ps_customerId = value; } }
        public string customerName { get { return ps_customerName; } set { ps_customerName = value; } }
        public DateTime date { get { return ps_date; } set { ps_date = value; } }
        public double internalCode { get { return ps_number; } set { ps_number = value; } }
        public string code { get { return ps_code; } set { ps_code = value; } }
        public double price { get { return ps_price; } set { ps_price = value; } }
        public double quantity { get { return ps_quantity; } set { ps_quantity = value; } }
        public double iva { get { return ps_iva; } set { ps_iva = value; } }
        public string detail { get { return ps_detail; } set { ps_detail = value; } }
        public string user { get { return ps_user; } set { ps_user = value; } }
        public string origin { get { return ps_origin; } set { ps_origin = value; } }
        public string origin2 { get { return ps_origin2; } set { ps_origin2 = value; } }
        public string saleOrder { get { return ps_saleOrder; } set { ps_saleOrder = value; } }
        public string observation { get { return ps_observation; } set { ps_observation = value; } }

        public clsPreseaShippings()
        {
            ps_codsec=0;
            ps_number=0;
            ps_type=string.Empty;
            ps_customerId=0;
            ps_customerName=string.Empty;
            ps_date=DateTime.Now;
            ps_code=string.Empty;
            ps_price=0;
            ps_quantity=0;
            ps_iva=0;
            ps_detail=string.Empty;
            ps_user = string.Empty;
            ps_origin = string.Empty;
            ps_origin2 = string.Empty;
            ps_saleOrder = string.Empty;
            ps_observation = string.Empty;
        }

        public bool save()
        {
            try
            {
                string queryString = "";
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_preseaShippings (ps_number, ps_type, ps_customerId, ps_customerName, ps_date, ps_internalCode, ps_code, ps_price, ps_quantity, ps_iva, ps_detail, ps_user, ps_origin, ps_origin2, ps_saleOrder, ps_observation) ";
                    queryString += " VALUES (";
                    queryString += "" + this.number.ToString() + ", ";
                    queryString += "'" + this.type.ToString() + "', ";
                    queryString += "" + this.customerId.ToString() + ", ";
                    queryString += "'" + this.customerName.ToString() + "', ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "" + this.internalCode.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "" + this.price.ToString() + ", ";
                    queryString += "" + this.quantity.ToString() + ", ";
                    queryString += "" + this.iva.ToString() + ", ";
                    queryString += "'" + this.detail.ToString() + "', ";
                    queryString += "'" + this.user.ToString() + "', ";
                    queryString += "'" + this.origin.ToString() + "', ";
                    queryString += "'" + this.origin2.ToString() + "', ";
                    queryString += "'" + this.saleOrder.ToString() + "', ";
                    queryString += "'" + this.observation.ToString() + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_preseaShippings ";
                    queryString += " SET ";
                    queryString += "ps_number = " + this.number.ToString() + ", ";
                    queryString += "ps_type = '" + this.type.ToString() + "', ";
                    queryString += "ps_customerId = " + this.customerId.ToString() + ", ";
                    queryString += "ps_customerName = '" + this.customerName.ToString() + "', ";
                    queryString += "ps_date = '" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "ps_internalCode = '" + this.internalCode.ToString() + "', ";
                    queryString += "ps_code = '" + this.code.ToString() + "', ";
                    queryString += "ps_price = " + this.price.ToString() + ", ";
                    queryString += "ps_quantity = " + this.quantity.ToString() + ", ";
                    queryString += "ps_iva = " + this.iva.ToString() + ", ";
                    queryString += "ps_detail = '" + this.detail.ToString() + "', ";
                    queryString += "ps_user = '" + this.user.ToString() + "', ";
                    queryString += "ps_origin = '" + this.origin.ToString() + "', ";
                    queryString += "ps_origin2 = '" + this.origin2.ToString() + "', ";
                    queryString += "ps_saleOrder = '" + this.saleOrder.ToString() + "', ";
                    queryString += "ps_observation = '" + this.observation.ToString() + "' ";
                    
                    queryString += " WHERE ps_codsec = " + this.codsec.ToString() + ";";
                }


                clsConnection.executeQuery(queryString);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsPreseaShippings.save");
                return false;
            }
        }

        public static List<clsPreseaShippings> getList(int quantity)
        {
            List<clsPreseaShippings> lst = new List<clsPreseaShippings>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP ("+quantity+") * FROM bps_prod_PreseaShippings ORDER BY ps_number DESC");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(new clsPreseaShippings());
                    lst[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ps_codsec"]);
                    lst[i].type = DS.Tables[0].Rows[i]["ps_type"].ToString();
                    lst[i].customerId = Convert.ToInt32(DS.Tables[0].Rows[i]["ps_customerId"]);
                    lst[i].customerName = DS.Tables[0].Rows[i]["ps_customerName"].ToString();
                    lst[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["ps_date"]);
                    lst[i].internalCode = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_internalCode"]);
                    lst[i].code = DS.Tables[0].Rows[i]["ps_code"].ToString();
                    lst[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_price"]);
                    lst[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_quantity"]);
                    lst[i].iva = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_iva"]);
                    lst[i].detail = DS.Tables[0].Rows[i]["ps_detail"].ToString();
                    lst[i].user = DS.Tables[0].Rows[i]["ps_user"].ToString();
                    lst[i].origin = DS.Tables[0].Rows[i]["ps_origin"].ToString();
                    lst[i].origin2 = DS.Tables[0].Rows[i]["ps_origin2"].ToString();
                    lst[i].saleOrder = DS.Tables[0].Rows[i]["ps_saleOrder"].ToString();
                    lst[i].observation = DS.Tables[0].Rows[i]["ps_observation"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lst;
        }

        public static void clear()
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_PreseaShippings");
        }
    }
}
