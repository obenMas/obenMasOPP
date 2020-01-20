using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    public class clsSalesOrderPalletsTree
    {
        public static TreeNode getTreeByActiveCuttingOrdersWithStock()
        {
            TreeNode trnMainNode = new TreeNode();
            trnMainNode = new TreeNode("Ordenes de corte");
            trnMainNode.ImageIndex = 0;
            trnMainNode.SelectedImageIndex = 0;
            trnMainNode.Tag = 0;

            List<clsCuttingOrder> lstCuttingOrders = clsCuttingOrder.getActiveOrderListWithStockProducts();
            for (int i = 0; i < lstCuttingOrders.Count; i++)
            {
                TreeNode trnNode = new TreeNode();
                List<TreeNode> lstChildrenNodes = new List<TreeNode>();

                clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();

                if (lstCuttingOrders[i].codsec > 0)
                {
                    trnNode = new TreeNode("Orden de corte #" + lstCuttingOrders[i].number);
                    trnNode.ImageIndex = 0;
                    trnNode.SelectedImageIndex = 0;
                    trnNode.Tag = "cuttingOrder-" + lstCuttingOrders[i].codsec.ToString();

                    lstChildrenNodes = objSalesOrderPalletsTree.getStockSalesOrderChildrenNodesByCuttingOrder(lstCuttingOrders[i].codsec);
                    for (int j = 0; j < lstChildrenNodes.Count; j++)
                        trnNode.Nodes.Add(lstChildrenNodes[j]);

                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }

                trnMainNode.Nodes.Add(trnNode);
            }


            return trnMainNode;
        }
        public static TreeNode getTreeByActiveCuttingOrdersByMachine(int MachineCodsec)
        {
            TreeNode trnMainNode = new TreeNode();
            trnMainNode = new TreeNode("Ordenes de corte");
            trnMainNode.ImageIndex = 0;
            trnMainNode.SelectedImageIndex = 0;
            trnMainNode.Tag = 0;

            List<clsCuttingOrder> lstCuttingOrders = clsCuttingOrder.getActiveOrderListByMachine(MachineCodsec);
            for (int i = 0; i < lstCuttingOrders.Count; i++)
            {
                TreeNode trnNode = new TreeNode();
                List<TreeNode> lstChildrenNodes = new List<TreeNode>();

                clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();

                if (lstCuttingOrders[i].codsec > 0)
                {
                    trnNode = new TreeNode("Orden de corte # " + lstCuttingOrders[i].number);
                    trnNode.ImageIndex = 0;
                    trnNode.SelectedImageIndex = 0;
                    trnNode.Tag = "cuttingOrder-" + lstCuttingOrders[i].codsec.ToString();

                    lstChildrenNodes = objSalesOrderPalletsTree.getSalesOrderChildrenNodesByCuttingOrder(lstCuttingOrders[i].codsec);
                    for (int j = 0; j < lstChildrenNodes.Count; j++)
                        trnNode.Nodes.Add(lstChildrenNodes[j]);

                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }

                trnMainNode.Nodes.Add(trnNode);
            }


            return trnMainNode;
        }
        public static TreeNode getTreeByCuttingOrder(int CuttingOrderCodsec)
        {
            TreeNode trnNode = new TreeNode();
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(CuttingOrderCodsec);
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();

            if (objCuttingOrder.codsec > 0)
            {
                trnNode = new TreeNode("Orden de corte # " + objCuttingOrder.number);
                trnNode.ImageIndex = 0;
                trnNode.SelectedImageIndex = 0;
                trnNode.Tag = "cuttingOrder-" + objCuttingOrder.codsec.ToString();

                lstChildrenNodes = objSalesOrderPalletsTree.getSalesOrderChildrenNodesByCuttingOrder(objCuttingOrder.codsec);
                for (int i = 0; i < lstChildrenNodes.Count; i++)
                    trnNode.Nodes.Add(lstChildrenNodes[i]);

            }
            else
            {
                trnNode = new TreeNode("No existe datos de la orden");
            }

            return trnNode;
        }
        public static TreeNode getTreeByActiveSalesOrder()
        {
            TreeNode trnNode = new TreeNode();
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getList();
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();
            try
            {
                if (lstSalesOrder.Count >= 0)
                {
                    trnNode = new TreeNode("Ordenes de venta");
                    trnNode.ImageIndex = 9;
                    trnNode.SelectedImageIndex = 9;
                    trnNode.Tag = "salesOderList-0";

                    for (int i = 0; i < lstSalesOrder.Count; i++)
                    {
                        if (lstSalesOrder[i].StatusName == "Activa")
                        {
                            lstChildrenNodes.Add(new TreeNode());
                            lstChildrenNodes[lstChildrenNodes.Count - 1].Text = lstSalesOrder[i].EntityName + " [" + lstSalesOrder[i].number + "]";
                            if (lstSalesOrder[i].isInternationalSale == true)
                            {
                                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 2;
                                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 2;
                            }
                            else
                            {
                                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 1;
                                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 1;
                            }
                            lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "salesOrder-" + lstSalesOrder[i].codsec.ToString();

                            List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getContainerChildrenBySalesOrder(lstSalesOrder[i].codsec);
                            for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                                lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                            trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count - 1]);

                            //AQUI HAY EL CAMBIO
                            /*
                            List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getSalesOrderDetailChildrenNodes(lstSalesOrder[i].codsec);
                            for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                                lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                            trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count -1]);
                            */
                        }
                    }
                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }
                return trnNode;
            }
            catch (Exception)
            {
                return trnNode;
            }
        }
        public static TreeNode getTreeBySalesOrderCodsec(int salesOrderCodsec)
        {
            TreeNode trnNode = new TreeNode();
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsSalesOrder objSalesOrder = new clsSalesOrder(salesOrderCodsec);
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();
            try
            {
                lstSalesOrder.Add(objSalesOrder);
                if (lstSalesOrder.Count >= 0)
                {
                    trnNode = new TreeNode("Ordenes de venta");
                    trnNode.ImageIndex = 9;
                    trnNode.SelectedImageIndex = 9;
                    trnNode.Tag = "salesOderList-0";

                    for (int i = 0; i < lstSalesOrder.Count; i++)
                    {
                        if (lstSalesOrder[i].StatusName == "Activa")
                        {
                            lstChildrenNodes.Add(new TreeNode());
                            lstChildrenNodes[lstChildrenNodes.Count - 1].Text = lstSalesOrder[i].EntityName + " [" + lstSalesOrder[i].number + "]";
                            if (lstSalesOrder[i].isInternationalSale == true)
                            {
                                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 2;
                                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 2;
                            }
                            else
                            {
                                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 1;
                                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 1;
                            }
                            lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "salesOrder-" + lstSalesOrder[i].codsec.ToString();

                            List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getContainerChildrenBySalesOrder(lstSalesOrder[i].codsec);
                            for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                                lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                            trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count - 1]);

                            //AQUI HAY EL CAMBIO
                            /*
                            List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getSalesOrderDetailChildrenNodes(lstSalesOrder[i].codsec);
                            for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                                lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                            trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count -1]);
                            */
                        }
                    }
                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }
                return trnNode;
            }
            catch (Exception)
            {
                return trnNode;
            }
        }
        public static TreeNode getTreeBySalesOrder(int salesOrderCodsec)
        {
            TreeNode trnNode = new TreeNode();
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsSalesOrder objSalesOrder = new clsSalesOrder(salesOrderCodsec);
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();
            try
            {
                if (objSalesOrder.codsec != 0)
                {
                    trnNode = new TreeNode("Orden de venta");
                    trnNode.ImageIndex = 9;
                    trnNode.SelectedImageIndex = 9;
                    trnNode.Tag = "salesOderList-0";


                    lstChildrenNodes.Add(new TreeNode());
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Text = objSalesOrder.EntityName + " [" + objSalesOrder.number + "]";
                    if (objSalesOrder.isInternationalSale == true)
                    {
                        lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 2;
                        lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 2;
                    }
                    else
                    {
                        lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 1;
                        lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 1;
                    }
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "salesOrder-" + objSalesOrder.codsec.ToString();

                    List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getContainerChildrenBySalesOrder(objSalesOrder.codsec);
                    for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                        lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                    trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count - 1]);


                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }
                return trnNode;
            }
            catch (Exception)
            {
                return trnNode;
            }
        }
        public static TreeNode getTreeBySalesOrder(clsSalesOrder objSalesOrder)
        {
            TreeNode trnNode = new TreeNode();
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();
            try
            {
                if (objSalesOrder.codsec != 0)
                {
                    trnNode = new TreeNode("Orden de venta");
                    trnNode.ImageIndex = 9;
                    trnNode.SelectedImageIndex = 9;
                    trnNode.Tag = "salesOderList-0";


                    lstChildrenNodes.Add(new TreeNode());
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Text = objSalesOrder.EntityName + " [" + objSalesOrder.number + "]";
                    if (objSalesOrder.isInternationalSale == true)
                    {
                        lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 2;
                        lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 2;
                    }
                    else
                    {
                        lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 1;
                        lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 1;
                    }
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "salesOrder-" + objSalesOrder.codsec.ToString();

                    List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getContainerChildrenBySalesOrder(objSalesOrder.codsec);
                    for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                        lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                    trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count - 1]);


                }
                else
                {
                    trnNode = new TreeNode("No existe datos de la orden");
                }
                return trnNode;
            }
            catch (Exception)
            {
                return trnNode;
            }
        }
        public List<TreeNode> getContainerChildrenBySalesOrder(int salesOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(salesOrderCodsec);
            clsSalesOrderPalletsTree objSalesOrderPalletsTree = new clsSalesOrderPalletsTree();
            TreeNode trnNode = new TreeNode();

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[lstChildrenNodes.Count - 1].Text = lstTransportBySalesOrder[i].ToString();
                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 11;
                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 11;
                lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "transport-" + lstTransportBySalesOrder[i].codsec.ToString();

                //List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getSalesOrderDetailChildrenNodesByTransport(lstTransportBySalesOrder[i].codsec, lstTransportBySalesOrder[i].fkSalesOrder);
                List<TreeNode> lstNewChildrenNodes = objSalesOrderPalletsTree.getSalesOrderDetailChildrenNodesByTransport(lstTransportBySalesOrder[i]);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);

                trnNode.Nodes.Add(lstChildrenNodes[lstChildrenNodes.Count - 1]);
            }


            return lstChildrenNodes;
        }

        private List<TreeNode> getSalesOrderDetailChildrenNodesByTransport(int transportCodsec, int salesOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsTransportBySalesOrder objTransportBySalesOrder = new clsTransportBySalesOrder(transportCodsec);
            List<clsSalesOrderDetail> lstIncludedSalesOrderDetail = clsSalesOrderDetail.getListByTransport(transportCodsec);

            for (int i = 0; i < lstIncludedSalesOrderDetail.Count; i++)
            {

                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstIncludedSalesOrderDetail[i].product.code + " [" + lstIncludedSalesOrderDetail[i].quantity + "]";
                lstChildrenNodes[i].ImageIndex = 3;
                lstChildrenNodes[i].SelectedImageIndex = 3;
                lstChildrenNodes[i].Tag = "salesOrderDetail-" + lstIncludedSalesOrderDetail[i].codsec.ToString();


                List<TreeNode> lstNewChildrenNodes = getPalletTypeChildrenNodesByTransport(lstIncludedSalesOrderDetail[i].codsec, transportCodsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);

            }

            return lstChildrenNodes;
        }
        private List<TreeNode> getSalesOrderDetailChildrenNodesByTransport(clsTransportBySalesOrder objTransportBySalesOrder)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsSalesOrderDetail> lstIncludedSalesOrderDetail = clsSalesOrderDetail.getListByTransport(objTransportBySalesOrder.codsec);

            for (int i = 0; i < lstIncludedSalesOrderDetail.Count; i++)
            {

                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstIncludedSalesOrderDetail[i].product.code + " [" + lstIncludedSalesOrderDetail[i].quantity + "]";
                lstChildrenNodes[i].ImageIndex = 3;
                lstChildrenNodes[i].SelectedImageIndex = 3;
                lstChildrenNodes[i].Tag = "salesOrderDetail-" + lstIncludedSalesOrderDetail[i].codsec.ToString();


                List<TreeNode> lstNewChildrenNodes = getPalletTypeChildrenNodesByTransport(lstIncludedSalesOrderDetail[i].codsec, objTransportBySalesOrder.codsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);

            }

            return lstChildrenNodes;
        }
        public List<TreeNode> getSalesOrderChildrenNodesByCuttingOrder(int CuttingOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsSalesOrder> lstSalesOrder = clsCuttingOrder.getSalesOrderByCuttingOrder(CuttingOrderCodsec);

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstSalesOrder[i].EntityName + " [" + lstSalesOrder[i].number + "]";
                if (lstSalesOrder[i].isInternationalSale == true)
                {
                    lstChildrenNodes[i].ImageIndex = 2;
                    lstChildrenNodes[i].SelectedImageIndex = 2;
                }
                else
                {
                    lstChildrenNodes[i].ImageIndex = 1;
                    lstChildrenNodes[i].SelectedImageIndex = 1;
                }
                lstChildrenNodes[i].Tag = "salesOrder-" + lstSalesOrder[i].codsec.ToString();

                List<TreeNode> lstNewChildrenNodes = getSalesOrderDetailChildrenNodes(lstSalesOrder[i].codsec, CuttingOrderCodsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }
            if (clsCuttingOrder.cuttingOrderHasStockEntries(CuttingOrderCodsec))
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[lstChildrenNodes.Count - 1].Text = "Stock";
                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 7;
                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 7;
                lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "stock-0";

                List<TreeNode> lstNewChildrenNodes = getStockCuttingOrderChildrenNodes(CuttingOrderCodsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);
            }

            return lstChildrenNodes;
        }
        public List<TreeNode> getStockSalesOrderChildrenNodesByCuttingOrder(int CuttingOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsSalesOrder> lstSalesOrder = clsCuttingOrder.getSalesOrderByCuttingOrder(CuttingOrderCodsec);

            if (clsCuttingOrder.cuttingOrderHasStockEntries(CuttingOrderCodsec))
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[lstChildrenNodes.Count - 1].Text = "Stock";
                lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 7;
                lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 7;
                lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "stock-0";

                List<TreeNode> lstNewChildrenNodes = getStockCuttingOrderChildrenNodes(CuttingOrderCodsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[lstChildrenNodes.Count - 1].Nodes.Add(lstNewChildrenNodes[j]);
            }

            return lstChildrenNodes;
        }
        public List<TreeNode> getSalesOrderDetailChildrenNodes(int salesOrderCodsec, int cuttingOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(cuttingOrderCodsec, true);
            List<clsSalesOrderDetail> lstIncludedSalesOrderDetail = new List<clsSalesOrderDetail>();
            int pos = 0;

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                bool isIncluded = false;
                clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);

                if (objSalesOrderDetail.fkSalesOrder == salesOrderCodsec)
                {
                    for (int j = 0; j < lstIncludedSalesOrderDetail.Count; j++)
                    {
                        if (lstIncludedSalesOrderDetail[j].codsec == objSalesOrderDetail.codsec)
                            isIncluded = true;
                    }

                    if (isIncluded == false)
                    {
                        lstChildrenNodes.Add(new TreeNode());
                        lstChildrenNodes[pos].Text = objSalesOrderDetail.product.code + " [" + objSalesOrderDetail.quantity + "]";
                        lstChildrenNodes[pos].ImageIndex = 3;
                        lstChildrenNodes[pos].SelectedImageIndex = 3;
                        lstChildrenNodes[pos].Tag = "salesOrderDetail-" + objSalesOrderDetail.codsec.ToString();


                        List<TreeNode> lstNewChildrenNodes = getPalletTypeChildrenNodes(objSalesOrderDetail.codsec);
                        for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                            lstChildrenNodes[pos].Nodes.Add(lstNewChildrenNodes[j]);

                        pos++;
                        lstIncludedSalesOrderDetail.Add(objSalesOrderDetail);
                    }
                }
            }

            return lstChildrenNodes;
        }
        public List<TreeNode> getSalesOrderDetailChildrenNodes(int salesOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsSalesOrderDetail> lstSalesOrderDetail = clsSalesOrderDetail.getListByOrderDetail(salesOrderCodsec);

            for (int i = 0; i < lstSalesOrderDetail.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstSalesOrderDetail[i].product.code + " [" + lstSalesOrderDetail[i].quantity + "]";
                lstChildrenNodes[i].ImageIndex = 3;
                lstChildrenNodes[i].SelectedImageIndex = 3;
                lstChildrenNodes[i].Tag = "salesOrderDetail-" + lstSalesOrderDetail[i].codsec.ToString();


                List<TreeNode> lstNewChildrenNodes = getPalletTypeChildrenNodes(lstSalesOrderDetail[i].codsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }

            return lstChildrenNodes;
        }
        public List<TreeNode> getPalletTypeChildrenNodes(int SalesOrderDetail)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsPalletTypeBySalesOrderDetail> lstPalletType = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(SalesOrderDetail);

            for (int i = 0; i < lstPalletType.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstPalletType[i].palletType.name + " - " + lstPalletType[i].palletDimention.ToString() + " [" + lstPalletType[i].quantity.ToString() + "]";
                lstChildrenNodes[i].ImageIndex = 4;
                lstChildrenNodes[i].SelectedImageIndex = 4;
                lstChildrenNodes[i].Tag = "palletTypeBySalesOrderDetail-" + lstPalletType[i].codsec.ToString();

                List<TreeNode> lstNewChildrenNodes = getPalletsChildrenNodes(lstPalletType[i].codsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }
            return lstChildrenNodes;

        }

        public List<TreeNode> getPalletTypeChildrenNodesByTransport(int SalesOrderDetail, int transportCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsPalletTypeBySalesOrderDetail> lstPalletType = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetailAndTransport(SalesOrderDetail, transportCodsec);

            for (int i = 0; i < lstPalletType.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstPalletType[i].palletType.name + " - " + lstPalletType[i].palletDimention.ToString() + " [" + lstPalletType[i].quantity.ToString() + "]";
                lstChildrenNodes[i].ImageIndex = 4;
                lstChildrenNodes[i].SelectedImageIndex = 4;
                lstChildrenNodes[i].Tag = "palletTypeBySalesOrderDetail-" + lstPalletType[i].codsec.ToString();

                //List<TreeNode> lstNewChildrenNodes = getPalletsChildrenNodes(lstPalletType[i].codsec);
                List<TreeNode> lstNewChildrenNodes = getPalletsChildrenNodes(lstPalletType[i]);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }
            return lstChildrenNodes;

        }

        public List<TreeNode> getPalletsChildrenNodes(int palletTypeBySalesOrderDetailCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsPalletTypeBySalesOrderDetail objPalletTypeBySalesOrderDetail = new clsPalletTypeBySalesOrderDetail(palletTypeBySalesOrderDetailCodsec);
            List<clsPallet> lstPallet = clsPallet.getListBySalesOrderDetailAndPalletType(objPalletTypeBySalesOrderDetail.fkSalesOrderDetail, objPalletTypeBySalesOrderDetail.fkPalletType, objPalletTypeBySalesOrderDetail.fkPalletDimention);
            int pos = 0;
            for (int i = 0; i < lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = lstPallet[i].palletType.name + " [" + lstPallet[i].code + "]";
                if (lstPallet[i].statusName == "Abierto")
                {
                    lstChildrenNodes[pos].ImageIndex = 5;
                    lstChildrenNodes[pos].SelectedImageIndex = 5;
                }
                else if (lstPallet[i].statusName == "Activo")
                {
                    lstChildrenNodes[pos].ImageIndex = 6;
                    lstChildrenNodes[pos].SelectedImageIndex = 6;
                }
                lstChildrenNodes[pos].Tag = "pallet-" + lstPallet[i].codsec.ToString();
                pos++;

            }
            for (int i = 0; i < objPalletTypeBySalesOrderDetail.quantity - lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = objPalletTypeBySalesOrderDetail.palletType.name + " [---]";
                lstChildrenNodes[pos].ImageIndex = 8;
                lstChildrenNodes[pos].SelectedImageIndex = 8;
                lstChildrenNodes[pos].Tag = "pallet-0";
                pos++;
            }

            return lstChildrenNodes;

        }
        public List<TreeNode> getPalletsChildrenNodes(clsPalletTypeBySalesOrderDetail objPalletTypeBySalesOrderDetail)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsPallet> lstPallet = clsPallet.getListBySalesOrderDetailAndPalletType(objPalletTypeBySalesOrderDetail.fkSalesOrderDetail, objPalletTypeBySalesOrderDetail.fkPalletType, objPalletTypeBySalesOrderDetail.fkPalletDimention);
            int pos = 0;
            for (int i = 0; i < lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = lstPallet[i].palletType.name + " [" + lstPallet[i].code + "]";
                if (lstPallet[i].statusName == "Abierto")
                {
                    lstChildrenNodes[pos].ImageIndex = 5;
                    lstChildrenNodes[pos].SelectedImageIndex = 5;
                }
                else if (lstPallet[i].statusName == "Activo" || lstPallet[i].statusName == "Despachado")
                {
                    lstChildrenNodes[pos].ImageIndex = 6;
                    lstChildrenNodes[pos].SelectedImageIndex = 6;
                }
                lstChildrenNodes[pos].Tag = "pallet-" + lstPallet[i].codsec.ToString();
                pos++;

            }
            for (int i = 0; i < objPalletTypeBySalesOrderDetail.quantity - lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = objPalletTypeBySalesOrderDetail.palletType.name + " [---]";
                lstChildrenNodes[pos].ImageIndex = 8;
                lstChildrenNodes[pos].SelectedImageIndex = 8;
                lstChildrenNodes[pos].Tag = "pallet-0";
                pos++;
            }

            return lstChildrenNodes;

        }
        public List<TreeNode> getStockCuttingOrderChildrenNodes(int cuttingOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsCuttingOrderDetail> lstStockCuttingOrderDetail = clsCuttingOrderDetail.getStockEntriesByCuttingOrder(cuttingOrderCodsec);

            for (int i = 0; i < lstStockCuttingOrderDetail.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstStockCuttingOrderDetail[i].product.code + " [" + lstStockCuttingOrderDetail[i].programmedWeight.ToString() + "]";
                lstChildrenNodes[i].ImageIndex = 3;
                lstChildrenNodes[i].SelectedImageIndex = 3;
                lstChildrenNodes[i].Tag = "cuttingOrderDetail-" + lstStockCuttingOrderDetail[i].codsec.ToString();

                List<TreeNode> lstNewChildrenNodes = getStockPalletTypeChildrenNodes(lstStockCuttingOrderDetail[i].codsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }
            return lstChildrenNodes;
        }
        public List<TreeNode> getStockPalletTypeChildrenNodes(int CuttingOrderCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            List<clsPalletTypeByCuttingOrderDetail> lstPalletType = clsPalletTypeByCuttingOrderDetail.getListByCuttingOrderDetail(CuttingOrderCodsec);

            for (int i = 0; i < lstPalletType.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[i].Text = lstPalletType[i].palletType.name + " - " + lstPalletType[i].palletDimention.ToString() + " [" + lstPalletType[i].quantity.ToString() + "]";
                lstChildrenNodes[i].ImageIndex = 4;
                lstChildrenNodes[i].SelectedImageIndex = 4;
                lstChildrenNodes[i].Tag = "palletTypeByCuttingOrderDetail-" + lstPalletType[i].codsec.ToString();

                List<TreeNode> lstNewChildrenNodes = getStockPalletsChildrenNodes(lstPalletType[i].codsec);
                for (int j = 0; j < lstNewChildrenNodes.Count; j++)
                    lstChildrenNodes[i].Nodes.Add(lstNewChildrenNodes[j]);
            }

            lstChildrenNodes.Add(new TreeNode());
            lstChildrenNodes[lstChildrenNodes.Count - 1].Text = "Agregar pallet de Stock";
            lstChildrenNodes[lstChildrenNodes.Count - 1].ImageIndex = 10;
            lstChildrenNodes[lstChildrenNodes.Count - 1].SelectedImageIndex = 10;
            lstChildrenNodes[lstChildrenNodes.Count - 1].Tag = "addPalletTypeByCuttingOrderDetail-" + CuttingOrderCodsec.ToString();
            return lstChildrenNodes;

        }
        public List<TreeNode> getStockPalletsChildrenNodes(int palletTypeByCuttingOrderDetailCodsec)
        {
            List<TreeNode> lstChildrenNodes = new List<TreeNode>();
            clsPalletTypeByCuttingOrderDetail objPalletTypeByCuttingOrderDetail = new clsPalletTypeByCuttingOrderDetail(palletTypeByCuttingOrderDetailCodsec);
            List<clsPallet> lstPallet = clsPallet.getListByCuttingOrderDetailAndPalletType(objPalletTypeByCuttingOrderDetail.fkCuttingOrderDetail, objPalletTypeByCuttingOrderDetail.fkPalletType, objPalletTypeByCuttingOrderDetail.fkPalletDimention);
            int pos = 0;

            for (int i = 0; i < lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = lstPallet[i].palletType.name + " [" + lstPallet[i].code + "]";
                if (lstPallet[i].statusName == "Abierto")
                {
                    lstChildrenNodes[pos].ImageIndex = 5;
                    lstChildrenNodes[pos].SelectedImageIndex = 5;
                }
                else if (lstPallet[i].statusName == "Activo")
                {
                    lstChildrenNodes[pos].ImageIndex = 6;
                    lstChildrenNodes[pos].SelectedImageIndex = 6;
                }
                lstChildrenNodes[pos].Tag = "pallet-" + lstPallet[i].codsec.ToString();
                pos++;
            }
            for (int i = 0; i < objPalletTypeByCuttingOrderDetail.quantity - lstPallet.Count; i++)
            {
                lstChildrenNodes.Add(new TreeNode());
                lstChildrenNodes[pos].Text = objPalletTypeByCuttingOrderDetail.palletType.name + " [---]";
                lstChildrenNodes[pos].ImageIndex = 8;
                lstChildrenNodes[pos].SelectedImageIndex = 8;
                lstChildrenNodes[pos].Tag = "pallet-0";
                pos++;
            }

            return lstChildrenNodes;

        }
    }
}
