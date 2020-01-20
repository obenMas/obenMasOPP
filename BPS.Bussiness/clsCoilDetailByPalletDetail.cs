using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilDetailByPalletDetail
    {
        //Attibutes
        private int cdbpd_codsec;
        private int cdbpd_fkPalletDetailByPalletType;
        private int cdbpd_fkCoil;

        //Properties

        public int codsec { get { return cdbpd_codsec; } set { cdbpd_codsec = value; } }

        public int fkPalletDetailByPalletType { get { return cdbpd_fkPalletDetailByPalletType; } set { cdbpd_fkPalletDetailByPalletType = value; } }

        public int fkCoil { get { return cdbpd_fkCoil; } set { cdbpd_fkCoil = value; } }

        //Constructor
        public clsCoilDetailByPalletDetail()
        {
            cdbpd_codsec = 0;
            cdbpd_fkPalletDetailByPalletType = 0;
            cdbpd_fkCoil = 0;
        }

        //Methods
        public static void setEntriesByPalletDetail(int palletDetailCodsec, int quantity)
        {
            string queryString = "";

            queryString = "DELETE FROM bps_prod_coildetailbypalletdetail WHERE cdbpd_fkPalletDetailByPalletType = " + palletDetailCodsec.ToString();
            clsConnection.executeQuery(queryString);
            
            for (int i = 0; i < quantity; i++)
            {
                queryString = "INSERT INTO bps_prod_coildetailbypalletdetail (cdbpd_fkPalletDetailByPalletType,cdbpd_fkCoil)";
                queryString += " VALUES (";
                queryString += " " + palletDetailCodsec.ToString() + ",0); ";

                clsConnection.executeQuery(queryString);
            }
        }
        public static List<clsCoilDetailByPalletDetail> getListByPalletDetail(int palletDetailCodsec)
        {
            List<clsCoilDetailByPalletDetail> lstCoilDetailByPalletDetail = new List<clsCoilDetailByPalletDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coildetailbypalletdetail WHERE cdbpd_fkPalletDetailByPalletType = " + palletDetailCodsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCoilDetailByPalletDetail.Add(new clsCoilDetailByPalletDetail());
                lstCoilDetailByPalletDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cdbpd_codsec"]);
                lstCoilDetailByPalletDetail[i].fkPalletDetailByPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["cdbpd_fkPalletDetailByPalletType"]);
                lstCoilDetailByPalletDetail[i].fkCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["cdbpd_fkCoil"]);
            }

            return lstCoilDetailByPalletDetail;
        }

        public static void deleteEntriesByPalletDetail(int palletDetailCodsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_coildetailbypalletdetail WHERE cdbpd_fkPalletDetailByPalletType = " + palletDetailCodsec.ToString());
        }

        public void save()
        {
            string queryString = "";

            queryString = "UPDATE bps_prod_coildetailbypalletdetail";
            queryString += " SET ";
            queryString += " cdbpd_fkCoil = " + fkCoil.ToString() + " ";
            queryString += " WHERE cdbpd_codsec = " + this.codsec.ToString();

            clsConnection.executeQuery(queryString);
        }

        public static void clearEntriesByPalletDetail(int palletDetailCodsec)
        {
            string queryString = "";

            queryString = "UPDATE bps_prod_coildetailbypalletdetail";
            queryString += " SET ";
            queryString += " cdbpd_fkCoil = 0 ";
            queryString += " WHERE cdbpd_fkPalletDetailByPalletType = " + palletDetailCodsec.ToString();

            clsConnection.executeQuery(queryString);
        }
    }
}
