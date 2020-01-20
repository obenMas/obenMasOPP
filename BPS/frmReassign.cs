using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmReassign : Form
    {
        private string film = string.Empty;
        private int width = 0;
        private int salesorderdetail = 0;
        private List<clsPallet> toStock = new List<clsPallet>();
        private List<clsPallet> toSaleOrder = new List<clsPallet>();
        private List<clsPlant> plants = new List<clsPlant>();
        clsPlant plant = new clsPlant();
        clsPlant fkPlant = new clsPlant();
    
        //PILAR

        private List<clsAymasDepot> toStockPL = new List<clsAymasDepot>();
        private List<clsAymasDepot> toSaleOrderPL = new List<clsAymasDepot>();

        public frmReassign()
        {   
            
            InitializeComponent();
        }

        public frmReassign(int sodcodsec, double pendingquantity,string plant)
        {
            clsSalesOrderDetail obj = new clsSalesOrderDetail(sodcodsec);
            salesorderdetail = obj.codsec;
            clsProduct objProd = new clsProduct(obj.fkProduct);
            clsSalesOrder objSaleOrder = new clsSalesOrder(obj.fkSalesOrder);
            InitializeComponent();
            width = Convert.ToInt32(objProd.width);
            film = objProd.boppCode.ToString() + objProd.castCode.ToString() + objProd.coatingCode.ToString();

            //Completa el combo de las plantas
            List<clsPlant> plist = clsPlant.getList();
            for (int i = 0; i < plist.Count; i++)
            {
                cmbPlant.Items.Add(plist[i].name);
            }
            /*if(plant == "Campana")
            {
                tbcReassign.SelectedIndex = 2;
            }
            else
            {
                tbcReassign.SelectedIndex = 3;
            }*/

            //Populate Campana
            PopulateAsignedPalletsDataGrid(sodcodsec);
            if(plant == "Campana")
            {
                cmbPlant.SelectedIndex = 0;
            }
            else if(plant == "Pilar")
            {
                cmbPlant.SelectedIndex = 1;
            }
            else
            {
                cmbPlant.SelectedIndex = -1;
            }
            
           // PopulatePalletsToAssignDataGrid(film,width,fkPlant.codsec);

            //txtOvReassign.Text = objSaleOrder.number.ToString();
            txtOvReassign.Text =obj.codsec.ToString();
            txtCustomerReassign.Text = objSaleOrder.EntityName.ToString();
            txtDateReassign.Text = Convert.ToDateTime(objSaleOrder.createdDate).ToShortDateString();
            txtStatusReassign.Text = objSaleOrder.StatusName.ToString();
            txtProductReassign.Text = objProd.code;
            txtSolicitedQuantityReassign.Text = obj.quantity.ToString();
            txtPendingAllocationReassign.Text = Math.Round(Convert.ToDouble(pendingquantity),2).ToString(); 
        }
       
        private void PopulateAsignedPalletsDataGrid(int number)
        {   
            double totalWeightAssigned = 0;
            dgvAsignedPallets.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spGetPalletListBySalesOrderDetail(" + number.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvAsignedPallets.Rows.Add();
                    dgvAsignedPallets.Rows[i].Cells[clmCodsecSalesOrder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                    dgvAsignedPallets.Rows[i].Cells[clmCodsecAsigned.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    dgvAsignedPallets.Rows[i].Cells[clmPalletCodeAsigned.Index].Value = DS.Tables[0].Rows[i]["Codigo"];
                    dgvAsignedPallets.Rows[i].Cells[clmWidthAsigned.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    dgvAsignedPallets.Rows[i].Cells[clmDiameterAsigned.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvAsignedPallets.Rows[i].Cells[clmCoreAsigned.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                    dgvAsignedPallets.Rows[i].Cells[clmWeightAsigned.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]),2);
                    totalWeightAssigned += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                }
            }
            txtTotalPalletAsigned.Text = Math.Round(totalWeightAssigned,2).ToString();
        }

        private void PopulatePalletsToAssignDataGrid(String film,int width,int plant)
        {
            double totalWeightToAssign = 0;
            dgvPalletsToAssign.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spAssignablePalletsByPlant(" + film.ToString()+", "+width.ToString()+", " + txtMoreOrLessPltToAssign.Text+", " + plant.ToString()+")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    bool flag = false;
                    
                    for (int j = 0; j < dgvAsignedPallets.Rows.Count; j++)
                    {
                       

                        if (Convert.ToInt32(dgvAsignedPallets.Rows[j].Cells["clmCodsecAsigned"].Value) == Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]))
                        {
                            flag = true;
                        }

                    }
                    if(!flag)
                    {
                        dgvPalletsToAssign.Rows.Add();
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmCodsecToAssignPallet.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmPalletCodeToAssign.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmWidthToAssignPallet.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmDiameterToAssignPallet.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmCoreToAssignPallet.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmWeightToAssignPallet.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmCustomerToAssignPallet.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmOrderToAssignPallet.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                        dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].Cells[clmDateToAssignPallet.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToShortDateString();
                        totalWeightToAssign += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString()),2);
                        string codigo=DS.Tables[0].Rows[i]["Codigo"].ToString();
                        if(codigo.Substring(codigo.Length-1,1)=="B")
                            dgvPalletsToAssign.Rows[dgvPalletsToAssign.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            txtTotalPalletToAssign.Text = totalWeightToAssign.ToString();
        }

        private void btnSearchC_Click(object sender, EventArgs e)
        {
            PopulatePalletsToAssignDataGrid(film, width,fkPlant.codsec);
        }

        private void dgvAsignedPallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == clmImgAssignPallet.Index)
            {
                clsPallet objpallet = new clsPallet(Convert.ToInt32(dgvAsignedPallets.Rows[e.RowIndex].Cells["clmCodsecAsigned"].Value));
                
                if (!toStock.Contains(objpallet) && !toSaleOrder.Contains(objpallet))
                {
                    toStock.Add(objpallet);
                }

                if(toSaleOrder.Contains(objpallet))
                {
                    toSaleOrder.Remove(objpallet);
                }

                dgvAsignedPallets.Rows.RemoveAt(e.RowIndex);
                double result=Math.Round(Convert.ToDouble(txtTotalPalletAsigned.Text),2) - Math.Round(Convert.ToDouble(objpallet.netWeight),2);
                txtTotalPalletAsigned.Text = Math.Round(Convert.ToDouble(result),2).ToString();
                txtPendingAllocationReassign.Text = (Math.Round(Convert.ToDouble(txtPendingAllocationReassign.Text), 2) + Math.Round(Convert.ToDouble(objpallet.netWeight),2)).ToString();
                PopulatePalletsToAssignDataGrid(film, width, fkPlant.codsec);
            }
        }

        private void dgvPalletsToAssign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmImgToAssignPallet.Index)
            {
                clsPallet objpallet = new clsPallet(Convert.ToInt32(dgvPalletsToAssign.Rows[e.RowIndex].Cells["clmCodsecToAssignPallet"].Value));

                if (!toStock.Contains(objpallet))
                {
                    toSaleOrder.Add(objpallet);
                }
                else
                {
                    toStock.Remove(objpallet);
                }

                dgvAsignedPallets.Rows.Add();
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count - 1].Cells[clmCodsecSalesOrder.Index].Value = salesorderdetail;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count-1].Cells[clmCodsecAsigned.Index].Value = objpallet.codsec;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count-1].Cells[clmPalletCodeAsigned.Index].Value = objpallet.code;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count-1].Cells[clmWidthAsigned.Index].Value = objpallet.product.width;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count - 1].Cells[clmDiameterAsigned.Index].Value = objpallet.product.DiameterAbbreviation;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count - 1].Cells[clmCoreAsigned.Index].Value = objpallet.product.CoreValue;
                dgvAsignedPallets.Rows[dgvAsignedPallets.Rows.Count-1].Cells[clmWeightAsigned.Index].Value =Math.Round(Convert.ToDouble(objpallet.netWeight),2);

                txtTotalPalletAsigned.Text = (Math.Round(Convert.ToDouble(txtTotalPalletAsigned.Text),2)+ Math.Round(Convert.ToDouble(objpallet.netWeight),2)).ToString();
                txtPendingAllocationReassign.Text = (Math.Round(Convert.ToDouble(txtPendingAllocationReassign.Text), 2) - Math.Round(Convert.ToDouble(objpallet.netWeight),2)).ToString();
                dgvPalletsToAssign.Rows.RemoveAt(e.RowIndex);
                PopulatePalletsToAssignDataGrid(film, width, fkPlant.codsec);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(toStock.Count>0 || toSaleOrder.Count>0)
            {
                if (MessageBox.Show("Va a realizar las siguientes reasignaciones: \n"+toStock.Count.ToString()+" pallets se reasignaran a stock.\n"+
                    ""+toSaleOrder.Count.ToString()+" pallets se reasignaran al pedido "+txtOvReassign.Text+".\n ¿Desea continuar?", "Reasignación de pallets", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    for(int i=0;i<toStock.Count;i++)
                    {
                        for (int j = 0; j < toStock[i].lstCoil.Count; j++)
                        {
                            clsCoil.assignToSalesOrder(toStock[i].lstCoil[j].codsec, 0);
                        }
                        clsReassign objrea = new clsReassign();
                        objrea.fkOldSalesOrderDetail = toStock[i].fkSalesOrderDetail;
                        objrea.fkNewSalesOrderDetail = 0;
                        objrea.fkPallet = toStock[i].codsec;
                        objrea.weigth = toStock[i].netWeight;
                        objrea.fkUser = clsGlobal.LoggedUser.codsec;
                        objrea.save();
                        clsPallet.assignPalletToSalesOrderDetail(toStock[i].codsec, 0);

                    }

                    for (int i = 0; i < toSaleOrder.Count; i++)
                    {
                        for (int j = 0; j < toSaleOrder[i].lstCoil.Count; j++)
                        {
                            clsCoil.assignToSalesOrder(toSaleOrder[i].lstCoil[j].codsec, salesorderdetail);
                        }

                        clsReassign objrea = new clsReassign();
                        objrea.fkOldSalesOrderDetail = toSaleOrder[i].fkSalesOrderDetail;
                        objrea.fkNewSalesOrderDetail = salesorderdetail;
                        objrea.fkPallet = toSaleOrder[i].codsec;
                        objrea.weigth = toSaleOrder[i].netWeight;
                        objrea.fkUser = clsGlobal.LoggedUser.codsec;
                        objrea.save();
                        clsPallet.assignPalletToSalesOrderDetail(toSaleOrder[i].codsec, salesorderdetail);
                        toSaleOrder[i].validarCompletitud(salesorderdetail);
                    
                    }

                    MessageBox.Show("Se realizaron correctamente las reasignaciones solicitadas.", "Reasignación de pallets", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se canceló la operación, NO se realizaron las reasignaciones.", "Reasignación cancelada", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("NO se realizaron reasignaciones.", "Reasignación de pallets", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            fkPlant.load(cmbPlant.SelectedItem.ToString());

            if (cmbPlant.SelectedIndex != -1)
            {
                PopulatePalletsToAssignDataGrid(film, width, fkPlant.codsec);
            }
            
            
            
        }
    }
}
