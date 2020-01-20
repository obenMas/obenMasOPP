using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsVapor
    {
        //Atributes
        private int vap_codsec;
        private int vap_fkshippingbuilding;
        private string vap_shippingbuilding;
        private DateTime vap_estimatedate;
        private DateTime vap_cuttoff;


        //Properties
        public int codsec { get { return vap_codsec; } set { vap_codsec = value; } }

        public DateTime estimatedate { get { return vap_estimatedate; } set { vap_estimatedate = value; } }

        public DateTime cuttoff { get { return vap_cuttoff; } set { vap_cuttoff = value; } }

        public int fkshippingbuilding { get { return vap_fkshippingbuilding; } set { vap_fkshippingbuilding = value; } }

        public string shippingbuilding { get { return vap_shippingbuilding; } set { vap_shippingbuilding = value; } }

        
        //Constructor
        public clsVapor()
        {
            vap_codsec = 0;
            vap_estimatedate = DateTime.Now;
            vap_cuttoff = DateTime.Now;
            vap_fkshippingbuilding = 0;
            vap_shippingbuilding = "";
        }

        public clsVapor(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwvapor where vap_codsec = " + codsec.ToString());
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["vap_codsec"]);
            this.estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[0]["vap_estimatedate"]);
            this.cuttoff = Convert.ToDateTime(DS.Tables[0].Rows[0]["vap_cuttoff"]);
            this.fkshippingbuilding = Convert.ToInt32(DS.Tables[0].Rows[0]["vap_fkshippingbuilding"]);
            this.shippingbuilding = DS.Tables[0].Rows[0]["vap_shippingbuilding"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_vapor (vap_fkshippingbuilding, vap_estimatedate, vap_cuttoff)";
                    queryString += " VALUES ( ";
                    queryString += this.fkshippingbuilding.ToString() + " , ";
                    queryString += "'" + this.estimatedate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.cuttoff.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_vapor";
                    queryString += " SET ";
                    queryString += " vap_fkshippingbuilding = " + this.fkshippingbuilding.ToString() + " ,";
                    queryString += "vap_estimatedate = '" + this.estimatedate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "vap_cuttoff = '" + this.cuttoff.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += " WHERE vap_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsVapor.save");
                return false;
            }
        }

        public static bool delete(int codsec)
        {
            try
            {
                clsConnection.executeQuery("DELETE FROM bps_prod_vapor WHERE vap_codsec = " + codsec.ToString());
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsVapor.delete");
                return false;
            }
        }

        public static List<clsVapor> getList()
        {
            List<clsVapor> lstvapor = new List<clsVapor>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spVapor();");
            lstvapor.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstvapor.Add(new clsVapor());
                lstvapor[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_codsec"]);
                lstvapor[i].estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_estimatedate"]);
                lstvapor[i].cuttoff = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_cuttoff"]);
                lstvapor[i].fkshippingbuilding = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_fkshippingbuilding"]);
                lstvapor[i].shippingbuilding = DS.Tables[0].Rows[i]["vap_shippingbuilding"].ToString();
            }
            return lstvapor;
        }

        public static List<clsVapor> getListByShppingBuilding(int codsec)
        {
            List<clsVapor> lstvapor = new List<clsVapor>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spVaporByShippingBuilding(" + codsec.ToString() + ");");
            lstvapor.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstvapor.Add(new clsVapor());
                lstvapor[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_codsec"]);
                lstvapor[i].estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_estimatedate"]);
                lstvapor[i].cuttoff = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_cuttoff"]);
                lstvapor[i].fkshippingbuilding = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_fkshippingbuilding"]);
                lstvapor[i].shippingbuilding = DS.Tables[0].Rows[i]["vap_shippingbuilding"].ToString();
            }
            return lstvapor;
        }

        public static List<clsVapor> getListByEstimdateDate(DateTime date)
        {
            List<clsVapor> lstvapor = new List<clsVapor>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spVaporbyEstimdateDate(" + date.ToString("dd/MM/yyyy") + ");");
            lstvapor.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstvapor.Add(new clsVapor());
                lstvapor[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_codsec"]);
                lstvapor[i].estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_estimatedate"]);
                lstvapor[i].cuttoff = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_cuttoff"]);
                lstvapor[i].fkshippingbuilding = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_fkshippingbuilding"]);
                lstvapor[i].shippingbuilding = DS.Tables[0].Rows[i]["vap_shippingbuilding"].ToString();
            }
            return lstvapor;
        }

        public static List<clsVapor> getListByFilter(int shippingbuilding, DateTime date)
        {
            List<clsVapor> lstvapor = new List<clsVapor>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spVaporByFilter(" + date.ToString("dd/MM/yyyy") + "," + shippingbuilding.ToString() + ");");
            lstvapor.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstvapor.Add(new clsVapor());
                lstvapor[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_codsec"]);
                lstvapor[i].estimatedate = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_estimatedate"]);
                lstvapor[i].cuttoff = Convert.ToDateTime(DS.Tables[0].Rows[i]["vap_cuttoff"]);
                lstvapor[i].fkshippingbuilding = Convert.ToInt32(DS.Tables[0].Rows[i]["vap_fkshippingbuilding"]);
                lstvapor[i].shippingbuilding = DS.Tables[0].Rows[i]["vap_shippingbuilding"].ToString();
            }
            return lstvapor;
        }

        public override string ToString()
        {
            return this.shippingbuilding + "-" + this.estimatedate + "-" + this.cuttoff;
        }
    }
}
