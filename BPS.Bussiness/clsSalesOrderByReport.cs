using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSalesOrderByReport
    {
        //Attributes
        private int sord_YearCreatedDate;
        private string sord_MonthNameCreatedDate;
        private int sord_MonthCreatedDate;
        private DateTime sord_createdDate;
        private string entt_companyName;
        private int entt_isCustomer;
        private int entt_isProvider;
        private string ctry_name;
        private string stt_name;        
        private string prod_name;
        private string bopp_code;
        private string ValidateNull;
        private string fml_name;
        private string thick_value;
        private double sod_quantity;
        private double sod_price;
        private double prod_width;
        private string prod_systemCode;

        //Properties
        public int yearcreateddate { get { return sord_YearCreatedDate; } set { sord_YearCreatedDate = value; } }

        public string monthnamecreateddate { get { return sord_MonthNameCreatedDate; } set { sord_MonthNameCreatedDate = value; } }

        public int monthcreateddate { get { return sord_MonthCreatedDate; } set { sord_MonthCreatedDate = value; } }

        public DateTime createddate { get { return sord_createdDate; } set { sord_createdDate = value; } }

        public string companyname { get { return entt_companyName; } set { entt_companyName = value; } }

        public int iscustomer { get { return entt_isCustomer; } set { entt_isCustomer = value; } }

        public int isprovider { get { return entt_isProvider; } set { entt_isProvider = value; } }

        public string countryname { get { return ctry_name; } set { ctry_name = value; } }

        public string statusname { get { return stt_name; } set { stt_name = value; } }

        public string productname { get { return prod_name; } set { prod_name = value; } }

        public string boppcode { get { return bopp_code; } set { bopp_code = value; } }

        public string validatenull { get { return ValidateNull; } set { ValidateNull = value; } }

        public string familyname { get { return fml_name; } set { fml_name = value; } }

        public string thicknessvalue { get { return thick_value; } set { thick_value = value; } }

        public double quantity { get { return sod_quantity; } set { sod_quantity = value; } }

        public double price { get { return sod_price; } set { sod_price = value; } }

        public double width { get { return prod_width; } set { prod_width = value; } }

        public string systemcode { get { return prod_systemCode; } set { prod_systemCode = value; } }

        //Constrcutor

        public clsSalesOrderByReport()
        {
            sord_YearCreatedDate=0;
            sord_MonthNameCreatedDate = "";
            sord_MonthCreatedDate = 0;
            sord_createdDate = DateTime.Now;
            entt_companyName = "";
            entt_isCustomer = 0;
            entt_isProvider = 0;
            ctry_name = "";
            stt_name = "";
            prod_name = "";
            bopp_code = "";
            ValidateNull = "";
            fml_name = "";
            thick_value = "";
            sod_quantity = 0;
            sod_price = 0;
            prod_width = 0;
            prod_systemCode = "";
        }
        //Methous

        public static List<clsSalesOrderByReport> Load()
        {
            List<clsSalesOrderByReport> lstSalesOrderByReport = new List<clsSalesOrderByReport>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderByReport();");
            lstSalesOrderByReport.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSalesOrderByReport.Add(new clsSalesOrderByReport());
                lstSalesOrderByReport[i].yearcreateddate = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_YearCreatedDate"]);
                lstSalesOrderByReport[i].monthnamecreateddate = DS.Tables[0].Rows[i]["sord_MonthNameCreatedDate"].ToString();
                lstSalesOrderByReport[i].monthcreateddate = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_MonthCreatedDate"]);
                lstSalesOrderByReport[i].createddate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                lstSalesOrderByReport[i].companyname = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstSalesOrderByReport[i].iscustomer = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_isCustomer"]);
                lstSalesOrderByReport[i].isprovider = Convert.ToInt32(DS.Tables[0].Rows[i]["entt_isProvider"]);
                lstSalesOrderByReport[i].countryname = DS.Tables[0].Rows[i]["ctry_name"].ToString();
                lstSalesOrderByReport[i].statusname = DS.Tables[0].Rows[i]["stt_name"].ToString();
                lstSalesOrderByReport[i].productname = DS.Tables[0].Rows[i]["prod_name"].ToString();
                lstSalesOrderByReport[i].boppcode = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                lstSalesOrderByReport[i].validatenull = DS.Tables[0].Rows[i]["ValidateNull"].ToString();
                lstSalesOrderByReport[i].familyname = DS.Tables[0].Rows[i]["fml_name"].ToString();
                lstSalesOrderByReport[i].thicknessvalue = DS.Tables[0].Rows[i]["thick_value"].ToString();
                lstSalesOrderByReport[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_quantity"]);
                lstSalesOrderByReport[i].price = Convert.ToDouble(DS.Tables[0].Rows[i]["sod_price"]);
                lstSalesOrderByReport[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["prod_width"]);
                lstSalesOrderByReport[i].systemcode = DS.Tables[0].Rows[i]["prod_systemCode"].ToString();
            }
            return lstSalesOrderByReport;
        }
    }
}
