using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsChangeSalesOrderDetail
    {
        //Attributes
        private int csod_codsec;
        private int csod_fkChangeSalesOrder;
        private int csod_fkCoil;
        private clsCoil csod_coil;

        internal clsCoil coil
        {
            get { return csod_coil; }
            set { csod_coil = value; }
        }
        private bool csod_changed;

        //Properties
        public int codsec { get { return csod_codsec; } set { csod_codsec = value; } }

        public int fkChangeSalesOrder { get { return csod_fkChangeSalesOrder; } set { csod_fkChangeSalesOrder = value; } }

        public int fkCoil { get { return csod_fkCoil; } set { csod_fkCoil = value; } }

        public bool changed { get { return csod_changed; } set { csod_changed = value; } }

        // Constructor

        public clsChangeSalesOrderDetail()
        {
            csod_codsec = 0;
            csod_fkChangeSalesOrder = 0;
            csod_fkCoil = 0;
            csod_coil = new clsCoil();
            csod_changed = false;
        }
        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_changesalesorderdetail (csod_fkChangeSalesOrder, csod_fkCoil, csod_changed)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkChangeSalesOrder.ToString() + ", ";
                    queryString += "" + this.fkCoil.ToString() + ", ";
                    queryString += "" + this.changed.ToString() + " ";
                    queryString += ");";                    
                }

                clsConnection.executeQuery(queryString);

                this.codsec = getLastSavedCodsec();

                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsChangeSalesOrderDetail.save");
                return false;
            }
        }
        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT csod_codsec FROM bps_prod_changesalesorderdetail Order By csod_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["csod_codsec"]);
        }
        public static void delete(int changeSalesOrderDetailCodsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_changesalesorderdetail WHERE csod_codsec = " + changeSalesOrderDetailCodsec.ToString());
        }
        public static List<clsChangeSalesOrderDetail> getListByChangeSalesOrder(int changeSalesOrderCodsec)
        {
            List<clsChangeSalesOrderDetail> lstChangeSalesOrderDetail = new List<clsChangeSalesOrderDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_changesalesorderdetail WHERE csod_fkChangeSalesOrder = " + changeSalesOrderCodsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstChangeSalesOrderDetail.Add(new clsChangeSalesOrderDetail());
                lstChangeSalesOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["csod_codsec"]);
                lstChangeSalesOrderDetail[i].fkChangeSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["csod_fkChangeSalesOrder"]);
                lstChangeSalesOrderDetail[i].fkCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["csod_fkCoil"]);
                lstChangeSalesOrderDetail[i].coil = new clsCoil(lstChangeSalesOrderDetail[i].fkCoil);
                lstChangeSalesOrderDetail[i].changed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["csod_changed"], DS.Tables[0].Rows[i]["csod_changed"].GetType().FullName);
            }            

            return lstChangeSalesOrderDetail;
        }
    }
}
