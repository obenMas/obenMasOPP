using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPaper
    {
        // Attributes
        private int pap_codsec;
        private int pap_fkCustomer;
        private clsEntity pap_Customer;
        private int pap_fkCountry;
        private clsCountry pap_Country;        
        private double pap_width;
        private double pap_netweigth;
        private double pap_grossweigth;
        private double pap_diameter;
        private double pap_density;
        private int pap_memo;
        private String pap_material;
        private String pap_code;
        private DateTime pap_createdDate;
        private DateTime pap_modificatedDate;
        private int pap_createdBY;
        private int pap_modifyBy;
        

        // Properties
        public int codsec { get { return pap_codsec; } set { pap_codsec = value; } }

        public int fkCustomer { get { return pap_fkCustomer; } set { pap_fkCustomer = value; } }

        public clsEntity Customer { get { return pap_Customer; } set { pap_Customer = value; } }

        public int fkCountry { get { return pap_fkCountry; } set { pap_fkCountry = value; } }

        public clsCountry Country { get { return pap_Country; } set { pap_Country = value; } }

        public Double width { get { return pap_width; } set { pap_width = value; } }

        public double netweigth { get { return pap_netweigth; } set { pap_netweigth = value; } }

        public double grossweigth { get { return pap_grossweigth; } set { pap_grossweigth = value; } }

        public double diameter { get { return pap_diameter; } set { pap_diameter = value; } }

        public double density { get { return pap_density; } set { pap_density = value; } }

        public int memo { get { return pap_memo; } set { pap_memo = value; } }

        public String material { get { return pap_material; } set { pap_material = value; } }

        public String code { get { return pap_code; } set { pap_code = value; } }

        public DateTime createdDate { get { return pap_createdDate; } set { pap_createdDate = value; } }

        public DateTime modificatedDate { get { return pap_modificatedDate; } set { pap_modificatedDate = value; } }

        public int createdBY { get { return pap_createdBY; } set { pap_createdBY = value; } }

        public int modifyBy { get { return pap_modifyBy; } set { pap_modifyBy = value; } }


        // Constructor
        public clsPaper()
        {
            codsec = 0;
            fkCustomer = 0;
            Customer = new clsEntity();
            fkCountry = 0;
            Country = new clsCountry();
            width = 0;
            netweigth = 0;
            grossweigth = 0;
            diameter = 0;
            density = 0;
            memo = 0;
            material = string.Empty;
            code = String.Empty;
            createdDate = DateTime.Now;
            modificatedDate = DateTime.Now;
            createdBY = 0;
            modifyBy = 0;
        }


        public clsPaper(int codsec)
        {
            load(codsec);
        }
        // Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_paper where pap_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_codsec"]);
                this.fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_fkCustomer"]);
                this.Customer = new clsEntity(this.fkCustomer);
                this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_fkCountry"]);
                this.Country = new clsCountry(this.fkCountry);
                this.width = Convert.ToDouble(DS.Tables[0].Rows[0]["pap_width"]);
                this.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pap_netweigth"]);
                this.grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["pap_grossweigth"]);
                this.diameter = Convert.ToDouble(DS.Tables[0].Rows[0]["pap_diameter"]);
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["pap_density"]);
                this.memo = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_memo"]);
                this.material = DS.Tables[0].Rows[0]["pap_material"].ToString();
                this.code = DS.Tables[0].Rows[0]["pap_code"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pap_createdDate"]);
                this.modificatedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pap_modificatedDate"]);
                this.createdBY = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_createdBy"]);
                this.modifyBy = Convert.ToInt32(DS.Tables[0].Rows[0]["pap_modifyBy"]);
            }
        }
        

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_paper (pap_fkCustomer, pap_fkCountry, pap_width, pap_netweigth, pap_grossweigth, pap_diameter, pap_density, pap_memo, pap_material, pap_code, pap_createdDate, pap_modificatedDate, pap_createdBy, pap_modifyBy)";
                    queryString += " VALUES (";
                    queryString += this.fkCustomer.ToString() + ", ";
                    queryString += this.fkCountry.ToString() + ", ";
                    queryString += this.width.ToString() + ", ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.grossweigth.ToString() + ", ";
                    queryString += this.diameter.ToString() + ", ";
                    queryString += this.density.ToString() + ", ";
                    queryString += this.memo.ToString() + ", ";
                    queryString += "'" + this.material.ToString() + "', ";
                    queryString += "'" + this.code.ToString() + "', ";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "'" + this.modificatedDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += this.createdBY.ToString() + ", ";
                    queryString += this.modifyBy.ToString() + " ";
                    queryString += ");";
                }
                else 
                {
                    queryString += "UPDATE bps_prod_paper ";
                    queryString += " SET ";
                    queryString += " pap_fkCustomer = " + this.fkCustomer.ToString() + ",";
                    queryString += " pap_fkCountry = '" + this.fkCountry.ToString() + "',";
                    queryString += " pap_width = '" + this.width.ToString() + "',";
                    queryString += " pap_netweigth = " + this.netweigth.ToString() + ",";
                    queryString += " pap_grossweigth = " + this.grossweigth.ToString() + ", ";
                    queryString += " pap_diameter = " + this.diameter.ToString() + ", ";
                    queryString += " pap_density = " + this.density.ToString() + ", ";
                    queryString += " pap_memo = " + this.memo.ToString() + ", ";
                    queryString += " pap_material = '" + this.material.ToString() + "', ";
                    queryString += " pap_code = '" + this.code.ToString() + "', ";
                    queryString += " pap_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += " pap_modificatedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += " pap_createdBy = " + this.createdBY.ToString() + ",";
                    queryString += " pap_modifyBy = " + this.modifyBy.ToString() + "";
                    queryString += " WHERE pap_codsec =  " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPaper.save");
                return false;
            }
        }

        public static List<clsPaper> getList()
        {
            List<clsPaper> lstPaper = new List<clsPaper>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_paper ORDER BY pap_codsec");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPaper.Add(new clsPaper());
                    lstPaper[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_codsec"]);
                    lstPaper[i].fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_fkCustomer"]);
                    lstPaper[i].Customer = new clsEntity(lstPaper[i].fkCustomer);
                    lstPaper[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_fkCountry"]);
                    lstPaper[i].Country = new clsCountry(lstPaper[i].fkCountry);
                    lstPaper[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_width"]);
                    lstPaper[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_netweigth"]);
                    lstPaper[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_grossweigth"]);
                    lstPaper[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_diameter"]);
                    lstPaper[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_density"]);
                    lstPaper[i].memo = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_memo"]);
                    lstPaper[i].material = DS.Tables[0].Rows[i]["pap_material"].ToString();
                    lstPaper[i].code = DS.Tables[0].Rows[i]["pap_code"].ToString();
                    lstPaper[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pap_createdDate"]);
                    lstPaper[i].modificatedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pap_modificatedDate"]);
                    lstPaper[i].createdBY = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_createdBy"]);
                    lstPaper[i].modifyBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_modifyBy"]);
                }
            }
            return lstPaper;
        }

        public static List<clsPaper> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsPaper> lstPaper = new List<clsPaper>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwPaperCoil " + where + " order by pap_codsec DESC");

            lstPaper.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPaper.Add(new clsPaper());
                lstPaper[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_codsec"]);
                lstPaper[i].fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_fkCustomer"]);
                lstPaper[i].Customer = new clsEntity(lstPaper[i].fkCustomer);
                lstPaper[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_fkCountry"]);
                lstPaper[i].Country = new clsCountry(lstPaper[i].fkCountry);
                lstPaper[i].width = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_width"]);
                lstPaper[i].netweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_netweigth"]);
                lstPaper[i].grossweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_grossweigth"]);
                lstPaper[i].diameter = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_diameter"]);
                lstPaper[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["pap_density"]);
                lstPaper[i].memo = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_memo"]);
                lstPaper[i].material = DS.Tables[0].Rows[i]["pap_material"].ToString();
                lstPaper[i].code = DS.Tables[0].Rows[i]["pap_code"].ToString();
                lstPaper[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pap_createdDate"]);
                lstPaper[i].modificatedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pap_modificatedDate"]);
                lstPaper[i].createdBY = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_createdBy"]);
                lstPaper[i].modifyBy = Convert.ToInt32(DS.Tables[0].Rows[i]["pap_modifyBy"]);
            }
            return lstPaper;
        }

        //public static List<clsInventory> getListByDate(DateTime Initdate, DateTime Enddate)
        //{
        //    List<clsInventory> lstInventory = new List<clsInventory>();
        //    DataSet DS = new DataSet();
        //    DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_inventory WHERE inv_date BETWEEN '" + Initdate.ToString("dd/MM/yyyy HH:mm:ss") + "' AND '" + Enddate.ToString("dd/MM/yyyy HH:mm:ss") + "'");
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstInventory.Add(new clsInventory());
        //            lstInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_codsec"]);
        //            lstInventory[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["inv_date"]);
        //            lstInventory[i].liableaccounting = DS.Tables[0].Rows[i]["inv_liableaccounting"].ToString();
        //            lstInventory[i].liablecellar = DS.Tables[0].Rows[i]["inv_liablecellar"].ToString();
        //            lstInventory[i].totalrecord = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_totalrecord"]);
        //            lstInventory[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["inv_totalweigth"]);
        //            lstInventory[i].fkstatus = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_fkstatus"]);
        //        }
        //    }
        //    return lstInventory;
        //}

        //public static List<clsInventory> getListByLock(int codsec)
        //{
        //    List<clsInventory> lstInventory = new List<clsInventory>();
        //    DataSet DS = new DataSet();
        //    DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_paper WHERE inv_fkstatus = " + codsec.ToString());
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstInventory.Add(new clsInventory());
        //            lstInventory[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_codsec"]);
        //            lstInventory[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["inv_date"]);
        //            lstInventory[i].liableaccounting = DS.Tables[0].Rows[i]["inv_liableaccounting"].ToString();
        //            lstInventory[i].liablecellar = DS.Tables[0].Rows[i]["inv_liablecellar"].ToString();
        //            lstInventory[i].totalrecord = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_totalrecord"]);
        //            lstInventory[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["inv_totalweigth"]);
        //            lstInventory[i].fkstatus = Convert.ToInt32(DS.Tables[0].Rows[i]["inv_fkstatus"]);
        //        }
        //    }
        //    return lstInventory;
        //}

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_paper ORDER BY pap_codsec DESC LIMIT 1");
            return Convert.ToInt32(DS.Tables[0].Rows[0]["pap_codsec"]);
        }
    }
}
