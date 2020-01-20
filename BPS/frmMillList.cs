using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using System.IO.Ports;

namespace BPS
{
    public partial class frmMillList : Form
    {
        public int codsec = 0;
        public bool isAutoricet = false;

        public frmMillList()
        {
            if (CheckOrder())
            {
                isAutoricet = true;
                InitializeComponent();
            }
            else
            {
                isAutoricet = false;
                MessageBox.Show("No existen material en Re-Proceso", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                this.Close();
            }
        }

        private bool CheckOrder()
        {
            List<clsMillPallet> lstMetal = new List<clsMillPallet>();
            lstMetal = clsMillPallet.getList();
            if (lstMetal.Count > 0)
                return true;
            else
                return false;
        }

        private void frmMetalizeOrderList_Load(object sender, EventArgs e)
        {
            PopulateOrder();
        }

        private void PopulateOrder()
        {
            try
            {
                List<clsMillPallet> lstMetal = new List<clsMillPallet>();
                lstMetal = clsMillPallet.getList();
                dgvMetalizeOrder.Rows.Clear();
                if (lstMetal.Count > 0)
                {
                    for (int i = 0; i < lstMetal.Count; i++)
                    {
                        dgvMetalizeOrder.Rows.Add();
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecodsec.Index].Value = lstMetal[i].codsec;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedensity.Index].Value = lstMetal[i].density;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizemill.Index].Value = lstMetal[i].MillName;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproduct.Index].Value = lstMetal[i].ProductName + " - " + lstMetal[i].ProductCode;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecode.Index].Value = lstMetal[i].code;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeorder.Index].Value = lstMetal[i].order;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizednetweigth.Index].Value = lstMetal[i].netWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedgrossweigth.Index].Value = lstMetal[i].grossWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedpalletweigth.Index].Value = lstMetal[i].palletWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizenotes.Index].Value = lstMetal[i].notes;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedate.Index].Value = lstMetal[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value = lstMetal[i].fkStatus;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizededit.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Properties.Resources.pencil : global::BPS.Properties.Resources.clear;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void PopulateOrderByFilter(string code)
        {
            try
            {
                List<clsMillPallet> lstMetal = new List<clsMillPallet>();
                lstMetal = clsMillPallet.getListByCode(code);
                dgvMetalizeOrder.Rows.Clear();
                if (lstMetal.Count > 0)
                {
                    for (int i = 0; i < lstMetal.Count; i++)
                    {
                        dgvMetalizeOrder.Rows.Add();
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecodsec.Index].Value = lstMetal[i].codsec;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedensity.Index].Value = lstMetal[i].density;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizemill.Index].Value = lstMetal[i].MillName;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproduct.Index].Value = lstMetal[i].ProductName + " - " + lstMetal[i].ProductCode;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecode.Index].Value = lstMetal[i].code;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeorder.Index].Value = lstMetal[i].order;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizednetweigth.Index].Value = lstMetal[i].netWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedgrossweigth.Index].Value = lstMetal[i].grossWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedpalletweigth.Index].Value = lstMetal[i].palletWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizenotes.Index].Value = lstMetal[i].notes;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedate.Index].Value = lstMetal[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value = lstMetal[i].fkStatus;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizededit.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Properties.Resources.pencil : global::BPS.Properties.Resources.clear;
                    }
                }
                else
                {
                    MessageBox.Show("No existen registro con dicho código en Re-Proceso", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    PopulateOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvMetalizeOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmmetalizededit.Index)
                {
                    if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedmystated.Index].Value.ToString() == "1075")
                    {
                        frmMillOrder winMetal = new frmMillOrder(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value));
                        winMetal.MdiParent = this.MdiParent;
                        winMetal.StartPosition = FormStartPosition.CenterScreen;
                        winMetal.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("No puede editar una orden que se encuentre cerrada por favor comuníquese con el departamento de sistemas", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PopulateOrderByFilter(txtCode.Text);
        }
    }
}
