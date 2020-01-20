using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletTypeBySalesOrderDetail
    {
        //Attibutes
        private int ptsod_codsec;
        private int ptsod_fkSalesOrderDetail;
        private int ptsod_fkPalletType;
        private int ptsod_fkPalletDimention;
        private int ptsod_fkTransport;
        private clsPalletType ptsod_palletType;
        private clsPalletDimentions ptsod_palletDimention;
        private int ptsod_quantity;
        private bool ptsod_useSingleFace;

        //Properties
        public int codsec { get { return ptsod_codsec; } set { ptsod_codsec = value; } }

        public int fkSalesOrderDetail { get { return ptsod_fkSalesOrderDetail; } set { ptsod_fkSalesOrderDetail = value; } }

        public int fkPalletType { get { return ptsod_fkPalletType; } set { ptsod_fkPalletType = value; } }

        public int fkPalletDimention { get { return ptsod_fkPalletDimention; } set { ptsod_fkPalletDimention = value; } }

        public int fkTransport { get { return ptsod_fkTransport; } set { ptsod_fkTransport = value; } }

        public clsPalletType palletType { get { return ptsod_palletType; } set { ptsod_palletType = value; } }

        public clsPalletDimentions palletDimention { get { return ptsod_palletDimention; } set { ptsod_palletDimention = value; } }

        public int quantity { get { return ptsod_quantity; } set { ptsod_quantity = value; } }

        public bool useSingleFace { get { return ptsod_useSingleFace; } set { ptsod_useSingleFace = value; } }


        //Constructor
        public clsPalletTypeBySalesOrderDetail()
        {
            codsec = 0;
            fkSalesOrderDetail = 0;
            fkPalletType = 0;
            fkPalletDimention = 0;
            fkTransport = 0;
            palletType = new clsPalletType();
            palletDimention = new clsPalletDimentions();
            quantity = 0;
            useSingleFace = false;
        }
        public clsPalletTypeBySalesOrderDetail(int ptsodCodsec)
        {
            this.load(ptsodCodsec);
        }
        //Methods
        public void load(int ptsodCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletTypeBySalesOrderDetail where ptsod_codsec = " + ptsodCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_codsec"]);
                fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_fkSalesOrderDetail"]);
                fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_fkPalletType"]);
                fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_fkPalletDimention"]);
                fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_fkTransport"]);
                palletType = new clsPalletType(fkPalletType);
                palletDimention = new clsPalletDimentions(fkPalletDimention);
                quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_quantity"]);
                useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["ptsod_useSingleFace"], DS.Tables[0].Rows[0]["ptsod_useSingleFace"].GetType().FullName);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_pallettypebysalesorderdetail (ptsod_fkSalesOrderDetail, ptsod_fkPalletType, ptsod_fkPalletDimention, ptsod_fkTransport, ptsod_quantity, ptsod_useSingleFace)";
                    queryString += " VALUES (";
                    queryString += this.fkSalesOrderDetail.ToString() + ",";
                    queryString += this.fkPalletType.ToString() + ",";
                    queryString += this.fkPalletDimention.ToString() + ",";
                    queryString += this.fkTransport.ToString() + ",";
                    queryString += this.quantity.ToString() + ",";
                    queryString += this.useSingleFace.ToString() + ")";
                }
                else
                {
                    queryString += "UPDATE bps_prod_pallettypebysalesorderdetail ";
                    queryString += " SET ";
                    queryString += " ptsod_fkSalesOrderDetail = " + this.fkSalesOrderDetail.ToString() + ", ";
                    queryString += " ptsod_fkPalletType = " + this.fkPalletType.ToString() + ", ";
                    queryString += " ptsod_fkPalletDimention = " + this.fkPalletDimention.ToString() + ", ";
                    queryString += " ptsod_fkTransport = " + this.fkTransport.ToString() + ", ";
                    queryString += " ptsod_quantity = " + this.quantity.ToString() + ", ";
                    queryString += " ptsod_useSingleFace = " + this.useSingleFace.ToString() + " ";
                    queryString += " WHERE ptsod_codsec =  " + this.codsec.ToString() + " ";

                }

                clsConnection.executeQuery(queryString);

                DataSet DS = clsConnection.getDataSetResult("SELECT ptsod_codsec FROM bps_prod_pallettypebysalesorderdetail ORDER BY ptsod_codsec DESC LIMIT 1 ");
                int newCodsec = 0;

                if (DS.Tables[0].Rows.Count > 0)
                {
                    newCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ptsod_codsec"]);
                    clsPalletDetailByPalletType.setEntriesByPalletType(newCodsec, this.quantity);
                }

                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletTypeBySalesOrderDetail.save");
                return false;
            }
        }
        public static List<clsPalletTypeBySalesOrderDetail> getListBySalesOrderDetail(int SalesOrderDetailCodsec)
        {
            List<clsPalletTypeBySalesOrderDetail> lstPalletTypeBySalesOrderDetail = new List<clsPalletTypeBySalesOrderDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletTypeBySalesOrderDetail where ptsod_fkSalesOrderDetail = " + SalesOrderDetailCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletTypeBySalesOrderDetail.Add(new clsPalletTypeBySalesOrderDetail());
                    lstPalletTypeBySalesOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_codsec"]);
                    lstPalletTypeBySalesOrderDetail[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkSalesOrderDetail"]);
                    lstPalletTypeBySalesOrderDetail[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkPalletType"]);
                    lstPalletTypeBySalesOrderDetail[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkPalletDimention"]);
                    lstPalletTypeBySalesOrderDetail[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkTransport"]);
                    lstPalletTypeBySalesOrderDetail[i].palletType = new clsPalletType(lstPalletTypeBySalesOrderDetail[i].fkPalletType);
                    lstPalletTypeBySalesOrderDetail[i].palletDimention = new clsPalletDimentions(lstPalletTypeBySalesOrderDetail[i].fkPalletDimention);
                    lstPalletTypeBySalesOrderDetail[i].quantity = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_quantity"]);
                    lstPalletTypeBySalesOrderDetail[i].useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["ptsod_useSingleFace"], DS.Tables[0].Rows[i]["ptsod_useSingleFace"].GetType().FullName);
                }

            }

            return lstPalletTypeBySalesOrderDetail;
        }
        public static List<clsPalletTypeBySalesOrderDetail> getListBySalesOrderDetailAndTransport(int SalesOrderDetailCodsec, int transportCodsec)
        {
            List<clsPalletTypeBySalesOrderDetail> lstPalletTypeBySalesOrderDetail = new List<clsPalletTypeBySalesOrderDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletTypeBySalesOrderDetail( " + SalesOrderDetailCodsec.ToString() + " , " + transportCodsec.ToString()+");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletTypeBySalesOrderDetail.Add(new clsPalletTypeBySalesOrderDetail());
                    lstPalletTypeBySalesOrderDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_codsec"]);
                    lstPalletTypeBySalesOrderDetail[i].fkSalesOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkSalesOrderDetail"]);
                    lstPalletTypeBySalesOrderDetail[i].fkPalletType = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkPalletType"]);
                    lstPalletTypeBySalesOrderDetail[i].fkPalletDimention = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkPalletDimention"]);
                    lstPalletTypeBySalesOrderDetail[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_fkTransport"]);
                    lstPalletTypeBySalesOrderDetail[i].palletType = new clsPalletType(lstPalletTypeBySalesOrderDetail[i].fkPalletType);
                    lstPalletTypeBySalesOrderDetail[i].palletDimention = new clsPalletDimentions(lstPalletTypeBySalesOrderDetail[i].fkPalletDimention);
                    lstPalletTypeBySalesOrderDetail[i].quantity = Convert.ToInt32(DS.Tables[0].Rows[i]["ptsod_quantity"]);
                    lstPalletTypeBySalesOrderDetail[i].useSingleFace = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["ptsod_useSingleFace"], DS.Tables[0].Rows[i]["ptsod_useSingleFace"].GetType().FullName);
                }

            }

            return lstPalletTypeBySalesOrderDetail;
        }
        public static int getCoilsNumberBySalesOrderDetail(int salesOrderDetailCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(bps_prod_pallettypebysalesorderdetail.ptsod_quantity * bps_prod_palletType.pltt_coilNumber), 0) AS TotalCoils FROM bps_prod_pallettypebysalesorderdetail, bps_prod_palletType WHERE bps_prod_palletType.pltt_codsec = bps_prod_pallettypebysalesorderdetail.ptsod_fkPalletType AND  bps_prod_pallettypebysalesorderdetail.ptsod_fkSalesOrderDetail = " + salesOrderDetailCodsec.ToString());

            return Convert.ToInt32(DS.Tables[0].Rows[0]["TotalCoils"]);
        }

        public static void delete(int ptsodCodsec)
        {
            clsPalletDetailByPalletType.deleteEntriesByPalletType(ptsodCodsec);

            clsConnection.executeQuery("DELETE FROM bps_prod_pallettypebysalesorderdetail WHERE ptsod_codsec = " + ptsodCodsec.ToString());
        }

        public static void correctPalletsBySalesOrderDetail(clsSalesOrderDetail objSalesOrderDetail)
        {
            List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrderDetail.fkSalesOrder);

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
            {
                List<clsPalletTypeBySalesOrderDetail> lstPalletTypeBySalesOrderDetail = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetailAndTransport(objSalesOrderDetail.codsec, lstTransportBySalesOrder[i].codsec);


                for (int j = 0; j < lstPalletTypeBySalesOrderDetail.Count; j++)
                {
                    clsPalletDetailByPalletType.setEntriesByPalletType(lstPalletTypeBySalesOrderDetail[j].codsec, lstPalletTypeBySalesOrderDetail[j].quantity);

                    List<clsPalletDetailByPalletType> lstPalletDetailByPalletType = clsPalletDetailByPalletType.getListByPalletType(lstPalletTypeBySalesOrderDetail[j].codsec);
                    
                    DataSet DS = new DataSet();

                    DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrderDetailByPalletTypeAndPalletdimention(" + objSalesOrderDetail.codsec.ToString() + ", " + lstPalletTypeBySalesOrderDetail[j].fkPalletType.ToString() + "," + lstPalletTypeBySalesOrderDetail[j].fkPalletDimention.ToString() + ")");

                    for (int k = 0; k < lstPalletDetailByPalletType.Count; k++)
                    {
                        lstPalletDetailByPalletType[k].fkPalletBySalesOrder = 0;
                        lstPalletDetailByPalletType[k].save();
                    }

                    for (int k = 0; k < DS.Tables[0].Rows.Count; k++)
                    {
                        if (k < lstPalletDetailByPalletType.Count)
                        {
                            string queryString = "";

                            queryString = "UPDATE bps_prod_palletdetailbypallettype";
                            queryString += " SET ";
                            queryString += " pdbpt_fkPalletBySalesOrder = 0 ";
                            queryString += " WHERE pdbpt_fkPalletBySalesOrder = " + DS.Tables[0].Rows[k]["pbsod_codsec"].ToString();

                            clsConnection.executeQuery(queryString);

                            lstPalletDetailByPalletType[k].fkPalletBySalesOrder = Convert.ToInt32(DS.Tables[0].Rows[k]["pbsod_codsec"]);
                            lstPalletDetailByPalletType[k].save();


                            clsCoilDetailByPalletDetail.clearEntriesByPalletDetail(lstPalletDetailByPalletType[k].codsec);

                            clsPallet objPallet = new clsPallet(Convert.ToInt32(DS.Tables[0].Rows[k]["plt_codsec"]), true, true);

                            clsCoilDetailByPalletDetail.setEntriesByPalletDetail(lstPalletDetailByPalletType[k].codsec, objPallet.palletType.coilNumber);

                            List<clsCoilDetailByPalletDetail> lstCoilDetailByPalletDetail = clsCoilDetailByPalletDetail.getListByPalletDetail(lstPalletDetailByPalletType[k].codsec);

                            for (int l = 0; l < objPallet.lstCoil.Count; l++)
                            {
                                lstCoilDetailByPalletDetail[l].fkCoil = objPallet.lstCoil[l].codsec;
                                lstCoilDetailByPalletDetail[l].save();
                            }
                        }
                        
                    }
                    
                }
            }
        }
    }
}
