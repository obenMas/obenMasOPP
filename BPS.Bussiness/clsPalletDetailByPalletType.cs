using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletDetailByPalletType
    {
        //Attributes
        private int pdbpt_codsec;
        private int pdbpt_fkPalletTypeBySalesOrder;
        private int pdbpt_fkPalletBySalesOrder;

        //Properties

        public int codsec { get { return pdbpt_codsec; } set { pdbpt_codsec = value; } }

        public int fkPalletTypeBySalesOrder { get { return pdbpt_fkPalletTypeBySalesOrder; } set { pdbpt_fkPalletTypeBySalesOrder = value; } }
        
        public int fkPalletBySalesOrder { get { return pdbpt_fkPalletBySalesOrder; } set { pdbpt_fkPalletBySalesOrder = value; } }

        //Constructor

        public clsPalletDetailByPalletType()
        {
            pdbpt_codsec = 0;
            pdbpt_fkPalletTypeBySalesOrder = 0;
            pdbpt_fkPalletBySalesOrder = 0;
        }

        //Methods
        public static clsPalletDetailByPalletType loadByPalletTypeBySalesOrder(int PalletBySalesOrderTypeCodsec)
        {
            clsPalletDetailByPalletType objPalletDetailByPalletType = new clsPalletDetailByPalletType();
            DataSet DS = new DataSet();

            //DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdetailbypallettype WHERE pdbpt_fkPalletTypeBySalesOrder = " + PalletBySalesOrderTypeCodsec.ToString());
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdetailbypallettype WHERE pdbpt_fkPalletBySalesOrder = " + PalletBySalesOrderTypeCodsec.ToString());


            if (DS.Tables[0].Rows.Count > 0)
            {
                objPalletDetailByPalletType.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_codsec"]);
                objPalletDetailByPalletType.fkPalletTypeBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_fkPalletTypeBySalesOrder"]);
                objPalletDetailByPalletType.fkPalletBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_fkPalletBySalesOrder"]);
            }

            return objPalletDetailByPalletType;
        }
        public static clsPalletDetailByPalletType loadByPalletBySalesOrder(int PalletBySalesOrderTypeCodsec)
        {
            clsPalletDetailByPalletType objPalletDetailByPalletType = new clsPalletDetailByPalletType();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdetailbypallettype WHERE pdbpt_fkPalletBySalesOrder = " + PalletBySalesOrderTypeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPalletDetailByPalletType.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_codsec"]);
                objPalletDetailByPalletType.fkPalletTypeBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_fkPalletTypeBySalesOrder"]);
                objPalletDetailByPalletType.fkPalletBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_fkPalletBySalesOrder"]);
            }

            return objPalletDetailByPalletType;
        }
        public static void setEntriesByPalletType(int palletTypeCodsec, int quantity)
        {
            clsPalletTypeBySalesOrderDetail objPalletTypeSalesOrderDetail = new clsPalletTypeBySalesOrderDetail();
            List<clsPalletDetailByPalletType> lstPalletDetailByPalletType = clsPalletDetailByPalletType.getListByPalletType(palletTypeCodsec);
            string queryString = ""; 

            if (lstPalletDetailByPalletType.Count == 0)
            {

                for (int i = 0; i < quantity; i++)
                {
                    queryString = "INSERT INTO bps_prod_palletdetailbypallettype (pdbpt_fkPalletTypeBySalesOrder, pdbpt_fkPalletBySalesOrder)";
                    queryString += " VALUES (";
                    queryString += " " + palletTypeCodsec.ToString() + ",0); ";

                    clsConnection.executeQuery(queryString);

                    DataSet DS = clsConnection.getDataSetResult("SELECT pdbpt_codsec FROM bps_prod_palletdetailbypallettype ORDER BY pdbpt_codsec DESC LIMIT 1 ");
                    int newCodsec = 0;

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        objPalletTypeSalesOrderDetail = new clsPalletTypeBySalesOrderDetail(palletTypeCodsec);
                        newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_codsec"]);
                        clsCoilDetailByPalletDetail.setEntriesByPalletDetail(newCodsec, objPalletTypeSalesOrderDetail.palletType.coilNumber);
                    }
                }
            }
            else if (lstPalletDetailByPalletType.Count > quantity)
            {
                for (int i = 0; i < lstPalletDetailByPalletType.Count; i++)
                {
                    if ((i + 1) > quantity)
                    {
                        queryString = "DELETE FROM bps_prod_coildetailbypalletdetail WHERE cdbpd_fkPalletDetailByPalletType = " + lstPalletDetailByPalletType[i].codsec.ToString();

                        clsConnection.executeQuery(queryString); 

                        queryString = "DELETE FROM bps_prod_palletdetailbypallettype WHERE pdbpt_codsec = " + lstPalletDetailByPalletType[i].codsec.ToString();

                        clsConnection.executeQuery(queryString);
                    }
                }
            }
            else if (lstPalletDetailByPalletType.Count < quantity)
            {
                for (int i = 0; i < quantity - lstPalletDetailByPalletType.Count; i++)
                {
                    queryString = "INSERT INTO bps_prod_palletdetailbypallettype (pdbpt_fkPalletTypeBySalesOrder,pdbpt_fkPalletBySalesOrder)";
                    queryString += " VALUES (";
                    queryString += " " + palletTypeCodsec.ToString() + ",0); ";

                    clsConnection.executeQuery(queryString);

                    DataSet DS = clsConnection.getDataSetResult("SELECT pdbpt_codsec FROM bps_prod_palletdetailbypallettype ORDER BY pdbpt_codsec DESC LIMIT 1 ");
                    int newCodsec = 0;

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        objPalletTypeSalesOrderDetail = new clsPalletTypeBySalesOrderDetail(palletTypeCodsec);
                        newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pdbpt_codsec"]);
                        clsCoilDetailByPalletDetail.setEntriesByPalletDetail(newCodsec, objPalletTypeSalesOrderDetail.palletType.coilNumber);
                    }
                }
            }

        }        
        public static List<clsPalletDetailByPalletType> getListByPalletType(int palletTypeCodsec)
        {
            List<clsPalletDetailByPalletType> lstPalletDetailByPalletType = new List<clsPalletDetailByPalletType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdetailbypallettype WHERE pdbpt_fkPalletTypeBySalesOrder = " + palletTypeCodsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletDetailByPalletType.Add(new clsPalletDetailByPalletType());
                lstPalletDetailByPalletType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pdbpt_codsec"]);
                lstPalletDetailByPalletType[i].fkPalletTypeBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["pdbpt_fkPalletTypeBySalesOrder"]);
                lstPalletDetailByPalletType[i].fkPalletBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["pdbpt_fkPalletBySalesOrder"]);
            }

            return lstPalletDetailByPalletType;
        }


        public static void deleteEntriesByPalletType(int ptsodCodsec)
        {
            List<clsPalletDetailByPalletType> lstPalletDetailByPalletType = clsPalletDetailByPalletType.getListByPalletType(ptsodCodsec);
            for (int i = 0; i < lstPalletDetailByPalletType.Count; i++)
			{
                clsCoilDetailByPalletDetail.deleteEntriesByPalletDetail(lstPalletDetailByPalletType[i].codsec);
			}

            clsConnection.executeQuery("DELETE FROM bps_prod_palletdetailbypallettype WHERE pdbpt_fkPalletTypeBySalesOrder = " + ptsodCodsec.ToString());
        }
        public void save()
        {
            string queryString = "";

            queryString = "UPDATE bps_prod_palletdetailbypallettype";
            queryString += " SET ";
            queryString += " pdbpt_fkPalletBySalesOrder = " + fkPalletBySalesOrder.ToString() + " ";
            queryString += " WHERE pdbpt_codsec = " + this.codsec.ToString();

            clsConnection.executeQuery(queryString);
        }
        public static void addPalletToDetail(int salesOrderDetailCodsec, int palletCodsec, int palletbysalesorderdetail, int palletType)
        {
            clsPalletDetailByPalletType objPalletDetailByPalletType = clsPalletDetailByPalletType.loadByPalletTypeBySalesOrder(palletbysalesorderdetail);

            if (objPalletDetailByPalletType.codsec == 0)
            {
                List<clsPalletTypeBySalesOrderDetail> lstPalletTypeBySalesOrderDetail = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(salesOrderDetailCodsec);

                for (int i = 0; i < lstPalletTypeBySalesOrderDetail.Count; i++)
                {
                    List<clsPalletDetailByPalletType> lstPalletDetailByPalletType = clsPalletDetailByPalletType.getListByPalletType(lstPalletTypeBySalesOrderDetail[i].codsec);

                    for (int j = 0; j < lstPalletDetailByPalletType.Count; j++)
                    {
                        if (lstPalletDetailByPalletType[j].fkPalletBySalesOrder == 0 && palletType == lstPalletTypeBySalesOrderDetail[i].fkPalletType)
                        {
                            lstPalletDetailByPalletType[j].fkPalletBySalesOrder = palletbysalesorderdetail;

                            lstPalletDetailByPalletType[j].save();

                            break;
                        }
                    }
                }
            }
        }
    }
}
