using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFilmByCustomer
    {
        private string ctry_name;
        private string sord_moth;
        private string prod_film;
        private string prod_productname;
        private int prod_width;
        private string entt_countryName;
        
        public string country { get { return ctry_name; } set { ctry_name = value; } }

        public string month { get { return sord_moth; } set { sord_moth = value; } }

        public string film { get { return prod_film; } set { prod_film = value; } }

        public string product { get { return prod_productname; } set { prod_productname = value; } }

        public int width { get { return prod_width; } set { prod_width = value; } }

        public string customer { get { return entt_countryName; } set { entt_countryName = value; } }

        public clsFilmByCustomer()
        {
            ctry_name = string.Empty;
            sord_moth = string.Empty;
            prod_film = string.Empty;
            prod_productname = string.Empty;
            prod_width = 0;
            entt_countryName = string.Empty;
        }

        public static List<clsFilmByCustomer> getList()
        {
            List<clsFilmByCustomer> lstFilmByCustomer = new List<clsFilmByCustomer>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spSalesOrderFilmByCustomer()");
            lstFilmByCustomer.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstFilmByCustomer.Add(new clsFilmByCustomer());
                lstFilmByCustomer[i].country = DS.Tables[0].Rows[i]["ctry_name"].ToString();
                lstFilmByCustomer[i].month = DS.Tables[0].Rows[i]["sord_moth"].ToString();
                lstFilmByCustomer[i].film = DS.Tables[0].Rows[i]["prod_film"].ToString();
                lstFilmByCustomer[i].product = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstFilmByCustomer[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstFilmByCustomer[i].customer = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
            }
            return lstFilmByCustomer;
        }
    }
}
