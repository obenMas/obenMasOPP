using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsShiping
    {
        //Atributes
        private int ship_codsec;     
        private int ship_fksalesorder;
        private int ship_fkvapor;
        private DateTime ship_customerdate;
        private DateTime ship_estimatedate;
        private DateTime ship_pledge;
        private DateTime ship_releasedate;
        private DateTime ship_vapordate;
        private DateTime ship_thermaldate;
        private string ship_vaporname;
        private string ship_name;
        private bool ship_hide;

        

        private int sord_codsec;
        private string sord_number;
        private string sord_notes;
        private string entt_companyName;
        private string trans_name;
        private int trans_container;
        private bool sord_hide;


        //Properties
        public int codsec { get { return ship_codsec; } set { ship_codsec = value; } }

        public int fksalesorder { get { return ship_fksalesorder; } set { ship_fksalesorder = value; } }

        public DateTime customerdate { get { return ship_customerdate; } set { ship_customerdate = value; } }

        public DateTime estimatedate { get { return ship_estimatedate; } set { ship_estimatedate = value; } }

        public DateTime releasedate { get { return ship_releasedate; } set { ship_releasedate = value; } }

        public DateTime pledge { get { return ship_pledge; } set { ship_pledge = value; } }

        public DateTime vapor { get { return ship_vapordate; } set { ship_vapordate = value; } }

        public DateTime thermal { get { return ship_thermaldate; } set { ship_thermaldate = value; } }

        public int fkvapor { get { return ship_fkvapor; } set { ship_fkvapor = value; } }

        public string name { get { return ship_name; } set { ship_name = value; } }

        public string vaporname { get { return ship_vaporname; } set { ship_vaporname = value; } }

        public bool shippinghide { get { return ship_hide; } set { ship_hide = value; } }


        
        public int salescodsec { get { return sord_codsec; } set { sord_codsec = value; } }

        public string salesnumber { get { return sord_number; } set { sord_number = value; } }

        public string salesnotes { get { return sord_notes; } set { sord_notes = value; } }

        public string sordcompany { get { return entt_companyName; } set { entt_companyName = value; } }

        public string salestransport { get { return trans_name; } set { trans_name = value; } }

        public int containernum { get { return trans_container; } set { trans_container = value; } }

        public bool salesorderhide { get { return sord_hide; } set { sord_hide = value; } }

        
        //Constructor
        public clsShiping()
        {
            ship_codsec = 0;
            ship_fksalesorder = 0;
            ship_customerdate = DateTime.Now;
            ship_estimatedate = DateTime.Now;
            ship_releasedate = DateTime.Now;
            ship_vapordate = DateTime.Now;
            ship_thermaldate = DateTime.Now;
            ship_name = "";
            sord_codsec = 0;
            sord_number = "";
            sord_notes = "";
            entt_companyName = "";
            trans_name = "";
            trans_container = 0;
            ship_vaporname = "";
            sord_hide = false;
            ship_hide = false;
        }
        

        //Methods
        public clsShiping(int codsec)
        {
            Load(codsec);
        }

        private void Load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_shipping where ship_codsec = " + codsec.ToString());
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ship_codsec"]);
            this.fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[0]["ship_fksalesorder"]);
            this.estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ship_estimatedate"]);
            this.releasedate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ship_estimatedate"]);
            this.vapor = Convert.ToDateTime(DS.Tables[0].Rows[0]["ship_vapor"]);
            this.thermal = Convert.ToDateTime(DS.Tables[0].Rows[0]["ship_vapor"]);
            this.name = DS.Tables[0].Rows[0]["ship_name"].ToString();
        }

        public static List<clsShiping> getActiveListCompleteInternationalSalesOrder()
        {
            List <clsShiping> lstShipping = new List<clsShiping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spInternationSalesOrderActive()");
            lstShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstShipping.Add(new clsShiping());
                lstShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_codsec"]);
                lstShipping[i].salesnumber = DS.Tables[0].Rows[i]["sord_number"].ToString();
                lstShipping[i].salesnotes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                lstShipping[i].name = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstShipping[i].containernum = Convert.ToInt32(DS.Tables[0].Rows[i]["con_number"]);
                lstShipping[i].salestransport = DS.Tables[0].Rows[i]["trans_name"].ToString();
                lstShipping[i].salesorderhide = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_hide"], DS.Tables[0].Rows[i]["sord_hide"].GetType().FullName);
                //lstShipping[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_fkStatus"]);
                //lstShipping[i].StatusName = DS.Tables[0].Rows[i]["sord_StatusName"].ToString();
                //lstShipping[i].number = DS.Tables[0].Rows[i]["sord_number"].ToString();
                //lstShipping[i].notes = DS.Tables[0].Rows[i]["sord_notes"].ToString();
                //lstShipping[i].isInternationalSale = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["sord_isInternationalSale"], DS.Tables[0].Rows[i]["sord_isInternationalSale"].GetType().FullName);
                //lstShipping[i].deliveredDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_deliveredDate"]);
                //lstShipping[i].closingDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_closingDate"]);
                //lstShipping[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_createdDate"]);
                //lstShipping[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_createdBy"]);
                //lstShipping[i].creatorUser = DS.Tables[0].Rows[i]["sord_creatorUser"].ToString();
                //lstShipping[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["sord_modifiedDate"]);
                //lstShipping[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_modifiedBy"]);
                //lstSalesOrder[i].modificatorUser = DS.Tables[0].Rows[i]["sord_modificatorUser"].ToString();
                //lstSalesOrder[i].exportedToERP = Convert.ToInt32(DS.Tables[0].Rows[i]["sord_exportedToERP"]);
            }            
            return lstShipping;
        }

        public static List<clsShiping> getCompareList(int codsec)
        {
            List<clsShiping> lstShipping = new List<clsShiping>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spShippingBySalesOrder(" + codsec.ToString() + ");");
            lstShipping.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstShipping.Add(new clsShiping());
                lstShipping[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ship_codsec"]);
                lstShipping[i].fksalesorder = Convert.ToInt32(DS.Tables[0].Rows[i]["ship_fkSalesOrder"].ToString());
                lstShipping[i].fkvapor = Convert.ToInt32(DS.Tables[0].Rows[i]["ship_fkVapor"].ToString());
                lstShipping[i].vaporname = DS.Tables[0].Rows[i]["ship_vaporname"].ToString();
                lstShipping[i].estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["ship_EstimatedDate"]);
                lstShipping[i].customerdate = Convert.ToDateTime(DS.Tables[0].Rows[i]["ship_CustomerDate"]);
                lstShipping[i].releasedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["ship_ReleaseDate"]);
                lstShipping[i].vapor = Convert.ToDateTime(DS.Tables[0].Rows[i]["ship_VaporDate"]);
                lstShipping[i].thermal = Convert.ToDateTime(DS.Tables[0].Rows[i]["ship_ThermalDate"]);
                lstShipping[i].shippinghide = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["ship_hide"], DS.Tables[0].Rows[i]["ship_hide"].GetType().FullName);
            }
            return lstShipping;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_shipping (ship_fkSalesOrder, ship_fkVapor, ship_EstimatedDate, ship_ReleaseDate, ship_CustomerDate, ship_VaporDate, ship_ThermalDate, ship_hide)";
                    queryString += " VALUES (";
                    queryString += "" + this.fksalesorder.ToString() + ",";
                    queryString += "" + this.fkvapor.ToString() + ",";
                    queryString += "'" + this.estimatedate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.releasedate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.customerdate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.vapor.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.thermal.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "" + this.shippinghide.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_shipping";
                    queryString += " SET ";
                    queryString += "ship_fkSalesOrder = " + this.fksalesorder + ", ";
                    queryString += "ship_fkVapor = " + this.fkvapor + ", ";
                    queryString += "ship_EstimatedDate = '" + this.estimatedate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "ship_ReleaseDate = '" + this.releasedate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "ship_CustomerDate = '" + this.customerdate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "ship_VaporDate = '" + this.vapor.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "ship_ThermalDate = '" + this.thermal.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "ship_hide = " + this.shippinghide + "";
                    queryString += " WHERE ship_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsShipping.save");
                return false;
            }
        }
    }
}
