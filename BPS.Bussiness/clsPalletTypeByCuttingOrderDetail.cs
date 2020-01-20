using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletTypeByCuttingOrderDetail
    {
        //Attibutes
        private int ptcod_codsec;
        private int ptcod_fkCuttingOrderDetail;
        private int ptcod_fkPalletType;
        private int ptcod_fkPalletDimention;
        private clsPalletType ptcod_palletType;
        private clsPalletDimentions ptcod_palletDimention;
        private int ptcod_quantity;

        //Properties
        public int codsec { get { return ptcod_codsec; } set { ptcod_codsec = value; } }

        public int fkCuttingOrderDetail { get { return ptcod_fkCuttingOrderDetail; } set { ptcod_fkCuttingOrderDetail = value; } }

        public int fkPalletType { get { return ptcod_fkPalletType; } set { ptcod_fkPalletType = value; } }

        public int fkPalletDimention { get { return ptcod_fkPalletDimention; } set { ptcod_fkPalletDimention = value; } }

        public clsPalletType palletType { get { return ptcod_palletType; } set { ptcod_palletType = value; } }

        public clsPalletDimentions palletDimention { get { return ptcod_palletDimention; } set { ptcod_palletDimention = value; } }

        public int quantity { get { return ptcod_quantity; } set { ptcod_quantity = value; } }


        //Constructor
        public clsPalletTypeByCuttingOrderDetail()
        {
            codsec = 0;
            fkCuttingOrderDetail = 0;
            fkPalletType = 0;
            fkPalletDimention = 0;
            palletType = new clsPalletType();
            palletDimention = new clsPalletDimentions();
            quantity = 0;
        }
        public clsPalletTypeByCuttingOrderDetail(int ptsodCodsec)
        {
            this.load(ptsodCodsec);
        }
        //Methods
        public void load(int ptsodCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_pallettypebycuttingorderdetail where ptcod_codsec = " + ptsodCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_codsec"]);
                fkCuttingOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkCuttingOrderDetail"]);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkPalletType"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkPalletDimention"]);
                palletType = new clsPalletType(fkPalletType);
                palletDimention = new clsPalletDimentions(fkPalletDimention);
                quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_quantity"]);
            }
        }
        public void loadByPalletTypeAndCuttingOrderDetail(int fkCuttingOrderDetail, int fkPalletType)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_pallettypebycuttingorderdetail where ptcod_fkCuttingOrderDetail = " + fkCuttingOrderDetail.ToString() + " AND ptcod_fkPalletType = " + fkPalletType.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_codsec"]);
                fkCuttingOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkCuttingOrderDetail"]);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkPalletType"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_fkPalletDimention"]);
                palletType = new clsPalletType(fkPalletType);
                palletDimention = new clsPalletDimentions(fkPalletDimention);
                quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["ptcod_quantity"]);
            }
        }
        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_pallettypebycuttingorderdetail (ptcod_fkCuttingOrderDetail, ptcod_fkPalletType, ptcod_fkPalletDimention, ptcod_quantity)";
                    queryString += " VALUES (";
                    queryString += this.fkCuttingOrderDetail.ToString() + ",";
                    queryString += this.fkPalletType.ToString() + ",";
                    queryString += this.fkPalletDimention.ToString() + ",";
                    queryString += this.quantity.ToString() + ")";
                }
                else
                {
                    queryString += "UPDATE bps_prod_pallettypebycuttingorderdetail ";
                    queryString += " SET ";
                    queryString += " ptcod_fkCuttingOrderDetail = " + this.fkCuttingOrderDetail.ToString() + ", ";
                    queryString += " ptcod_fkPalletType = " + this.fkPalletType.ToString() + ", ";
                    queryString += " ptcod_fkPalletDimention = " + this.fkPalletDimention.ToString() + ", ";
                    queryString += " ptcod_quantity = " + this.quantity.ToString() + " ";
                    queryString += " WHERE ptcod_codsec =  " + this.codsec.ToString() + " ";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBopp.save");
                return false;
            }
        }
        public static List<clsPalletTypeByCuttingOrderDetail> getListByCuttingOrderDetail(int CuttingOrderDetailCodsec)
        {
            List<clsPalletTypeByCuttingOrderDetail> lstPalletTypeByCuttingOrderDetail = new List<clsPalletTypeByCuttingOrderDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_pallettypebycuttingorderdetail where ptcod_fkCuttingOrderDetail = " + CuttingOrderDetailCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletTypeByCuttingOrderDetail.Add(new clsPalletTypeByCuttingOrderDetail());
                    lstPalletTypeByCuttingOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ptcod_codsec"]);
                    lstPalletTypeByCuttingOrderDetail[i].fkCuttingOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["ptcod_fkCuttingOrderDetail"]);
                    lstPalletTypeByCuttingOrderDetail[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["ptcod_fkPalletType"]);
                    lstPalletTypeByCuttingOrderDetail[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["ptcod_fkPalletDimention"]);
                    lstPalletTypeByCuttingOrderDetail[i].palletType = new clsPalletType(lstPalletTypeByCuttingOrderDetail[i].fkPalletType);
                    lstPalletTypeByCuttingOrderDetail[i].palletDimention = new clsPalletDimentions(lstPalletTypeByCuttingOrderDetail[i].fkPalletDimention);
                    lstPalletTypeByCuttingOrderDetail[i].quantity = Convert.ToInt32(DS.Tables[0].Rows[i]["ptcod_quantity"]);
                }

            }

            return lstPalletTypeByCuttingOrderDetail;
        }
        public static int getCoilsNumberByCuttingOrderDetail(int cuttingOrderDetailCodsec)
        { 
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(bps_prod_pallettypebycuttingorderdetail.ptcod_quantity * bps_prod_palletType.pltt_coilNumber), 0) AS TotalCoils FROM bps_prod_pallettypebycuttingorderdetail, bps_prod_palletType WHERE bps_prod_palletType.pltt_codsec = bps_prod_pallettypebycuttingorderdetail.ptcod_fkPalletType AND  bps_prod_pallettypebycuttingorderdetail.ptcod_fkCuttingOrderDetail = " + cuttingOrderDetailCodsec.ToString());

            return Convert.ToInt32(DS.Tables[0].Rows[0]["TotalCoils"]);
        }

        internal static void delete(int ptcodCodsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_pallettypebycuttingorderdetail WHERE ptcod_codsec = " + ptcodCodsec.ToString());
        }
    }
}
