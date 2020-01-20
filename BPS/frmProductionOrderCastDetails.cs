using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionOrderCastDetails : Form
    {
        clsProductionOrderDetail objProductionOrderDetail = new clsProductionOrderDetail();
        clsProductionOrder objProductionOrder = new clsProductionOrder();
        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
        clsCast ObjCast = new clsCast();

        public frmProductionOrderCastDetails(int productionOrderCodsec)
        {
            InitializeComponent();
            objProductionOrderDetail.load(productionOrderCodsec);
            objProductionOrder.load(objProductionOrderDetail.fkProductionOrder);
            objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(objProductionOrder.codsec);
            ObjCast.load(objProductionOrder.fkCast);
        }
        private void loadMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            lstMainCoil = clsMainCoil.getBoppMainCoilByProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
            dgvProductionOrderMainCoil.Rows.Clear();

            for (int i = 0; i < lstMainCoil.Count; i++)
            {
                dgvProductionOrderMainCoil.Rows.Add();
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCodsec.Index].Value = lstMainCoil[i].codsec.ToString();
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCode.Index].Value = lstMainCoil[i].code.ToString();
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilBatch.Index].Value = lstMainCoil[i].lotNumber.ToString();
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilWeigth.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netWeigth, 2));
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilLength.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netlength, 2));
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilStatus.Index].Value = lstMainCoil[i].StatusName.ToString();
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderEdit.Index].Value = BPS.Properties.Resources.pencil;
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderOutLine.Index].Value = BPS.Properties.Resources.chart_line;
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderCoilQuality.Index].Value = BPS.Properties.Resources.report;
                dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderDeleteMainCoil.Index].Value = BPS.Properties.Resources.cross;
            }
        }

        private void loadDecreaseByFilmProductionPlan()
        {
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlan.codsec);
            double totalDecrease = 0;
            dgvDecrease.Rows.Clear();

            for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
            {
                dgvDecrease.Rows.Add();
                dgvDecrease.Rows[i].Cells[clmDecreaseCodsec.Index].Value = lstDecreaseByFilmProductionPlan[i].codsec;
                dgvDecrease.Rows[i].Cells[clmDecreaseName.Index].Value = lstDecreaseByFilmProductionPlan[i].decreaseName;
                dgvDecrease.Rows[i].Cells[clmDecreaseWeight.Index].Value = lstDecreaseByFilmProductionPlan[i].weight;
                dgvDecrease.Rows[i].Cells[clmDecreaseDate.Index].Value = lstDecreaseByFilmProductionPlan[i].createdDate.ToString("dd/MM/yyyy HH:mm");
                dgvDecrease.Rows[i].Cells[clmDecreaseDelete.Index].Value = global::BPS.Properties.Resources.cross;

                totalDecrease = totalDecrease + lstDecreaseByFilmProductionPlan[i].weight;
            }

            lblTotalDecrease.Text = Math.Round(totalDecrease, 2).ToString();
        }

        private void loadDeadTimeByFilmProductionPlan()
        {
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlan.codsec);
            double totalTime = 0;
            dgvDeadTime.Rows.Clear();

            for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
            {
                dgvDeadTime.Rows.Add();
                dgvDeadTime.Rows[i].Cells[clmDeadTimeCodsec.Index].Value = lstDeadTimeByFilmProductionPlan[i].codsec;
                dgvDeadTime.Rows[i].Cells[clmDeadTimeCause.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName;
                dgvDeadTime.Rows[i].Cells[clmDeadTimeInit.Index].Value = lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm");
                dgvDeadTime.Rows[i].Cells[clmDeadTimeEnd.Index].Value = lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm");
                dgvDeadTime.Rows[i].Cells[clmDeadTimeTime.Index].Value = Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                dgvDeadTime.Rows[i].Cells[clmDeadTimeDelete.Index].Value = global::BPS.Properties.Resources.cross;

                totalTime += lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours;
            }

            lblTotalDeadTime.Text = Math.Round(totalTime, 2).ToString();
        }

        private void frmProductionOrderDetails_Load(object sender, EventArgs e)
        {
            
            //Load production Order
            txtProductionOrderDetailNumber.Text = objProductionOrderDetail.OrderNumber.ToString();
            txtProductionOrderDetailFilm.Text = objProductionOrderDetail.castCode;
            txtProductionOrderMachine.Text = objProductionOrderDetail.MachineName;
            txtProductionOrderStatus.Text = objProductionOrderDetail.StatusName;
            txtProductionOrderRequestedKg.Text = Convert.ToString(Math.Round(objProductionOrderDetail.Quantity, 2));
            txtProductionOrderExtrudedKg.Text = Convert.ToString(Math.Round(objProductionOrderDetail.FulfilledQuantity, 2));
            txtKg.Text = Convert.ToString(Math.Round((objProductionOrderDetail.Quantity - objProductionOrderDetail.FulfilledQuantity), 2));
            lblWidts.Text = objFilmProductionPlan.widths;
            lblLength.Text = objFilmProductionPlan.estimatedLength.ToString();
            lblNotes.Text = objFilmProductionPlan.notes;
            lblInitDate.Text = objFilmProductionPlan.estimatedInitDate.ToString("dd/MM/yyyy HH:mm");
            lblEndDate.Text = (objProductionOrder.StatusName == "Cerrada") ? objFilmProductionPlan.estimatedEndDate.ToString("dd/MM/yyyy HH:mm") : "----";

            List<clsFormulation> lstFormulation = clsFormulation.getListByCastFilm(objProductionOrderDetail.fkCast);

            for (int i = 0; i < lstFormulation.Count; i++)
                cmbProductionOrderFormulation.Items.Add(lstFormulation[i]);

            loadMainCoilList();

            List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
            dgvProductionOrderFormulation.Rows.Clear();

            for (int i = 0; i < lstFormulationByFilmProductionPlan.Count; i++)
            {
                dgvProductionOrderFormulation.Rows.Add();
                dgvProductionOrderFormulation.Rows[i].Cells["clmProductionOrderFormulationCodsec"].Value = lstFormulationByFilmProductionPlan[i].fkFormulation.ToString();
                dgvProductionOrderFormulation.Rows[i].Cells["clmProductionOrderFormulationCode"].Value = lstFormulationByFilmProductionPlan[i].formulationName.ToString();
            }
            if (objProductionOrder.StatusName == "Cerrada")
            {
                tbcProductionOrder.TabPages.Remove(tbpClose);
                cmbProductionOrderFormulation.Enabled = false;
                btnProductionOrderAddFormulation.Enabled = false;
            }

            List<clsDecrease> lstDecrease = clsDecrease.getListForFilmProductionPlan();

            for (int i = 0; i < lstDecrease.Count; i++)
                cmbDecreaseName.Items.Add(lstDecrease[i]);

            loadDecreaseByFilmProductionPlan();
            List<clsDeadTimeType> lstDeadTimeType = clsDeadTimeType.getList();
            for (int i = 0; i < lstDeadTimeType.Count; i++)
                cmbCause.Items.Add(lstDeadTimeType[i]);
            
            loadDeadTimeByFilmProductionPlan();

            if (objFilmProductionPlan.variation == true)
            {
                lblVatiation.Text = "La orden de producción ha sigo modificada el día : " + objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy");
                lblVatiation.Visible = true;
            }
        }

        

        private void btnProductionOrderAddFormulation_Click(object sender, EventArgs e)
        {
            clsFormulationByFilmProductionPlan objFormulationByFilmProductionPlan = new clsFormulationByFilmProductionPlan();
            List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = new List<clsFormulationByFilmProductionPlan>();
            List<clsFormulationByFilmProductionPlan> lstFormulationByActiveFilmPlan = new List<clsFormulationByFilmProductionPlan>();
            lstFormulationByActiveFilmPlan = clsFormulationByFilmProductionPlan.getActiveFormulationByFilmProductionPlanList(Convert.ToInt32(objProductionOrderDetail.fkFilmProductionPlan));

            for (int i = 0; i < lstFormulationByActiveFilmPlan.Count; i++)
            {
                objFormulationByFilmProductionPlan.codsec = lstFormulationByActiveFilmPlan[i].codsec;
                objFormulationByFilmProductionPlan.fkFilmProductionPlan = lstFormulationByActiveFilmPlan[i].fkFilmProductionPlan;
                objFormulationByFilmProductionPlan.fkFormulation = lstFormulationByActiveFilmPlan[i].fkFormulation;
                objFormulationByFilmProductionPlan.createdDate = lstFormulationByActiveFilmPlan[i].createdDate;
                objFormulationByFilmProductionPlan.createdBy = lstFormulationByActiveFilmPlan[i].createdBy;
                objFormulationByFilmProductionPlan.isActive = false;
                objFormulationByFilmProductionPlan.save();
            }
            objFormulationByFilmProductionPlan = new clsFormulationByFilmProductionPlan();
            objFormulationByFilmProductionPlan.fkFormulation = ((clsFormulation)cmbProductionOrderFormulation.SelectedItem).codsec;
            objFormulationByFilmProductionPlan.fkFilmProductionPlan = objProductionOrderDetail.fkFilmProductionPlan;
            objFormulationByFilmProductionPlan.isActive = true;
            if (objFormulationByFilmProductionPlan.save())
            {
                MessageBox.Show("Se agrego la formulación con éxito.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                objFormulationByFilmProductionPlan = new clsFormulationByFilmProductionPlan();
                lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
                dgvProductionOrderFormulation.Rows.Clear();
                for (int i = 0; i < lstFormulationByFilmProductionPlan.Count; i++)
                {
                    dgvProductionOrderFormulation.Rows.Add();
                    dgvProductionOrderFormulation.Rows[i].Cells["clmProductionOrderFormulationCodsec"].Value = lstFormulationByFilmProductionPlan[i].fkFormulation.ToString();
                    dgvProductionOrderFormulation.Rows[i].Cells["clmProductionOrderFormulationCode"].Value = lstFormulationByFilmProductionPlan[i].formulationName.ToString();
                }
            }
            else
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductionOrderFormulation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductionOrderFormulation.Rows.RemoveAt(e.RowIndex);
        }

        private void chbxCloseProductionOrder_CheckedChanged(object sender, EventArgs e)
        {
            txtCloseProductionOrderObservations.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmProductionOrderClose winProductionOrderClose = new frmProductionOrderClose(objProductionOrder.codsec, objFilmProductionPlan.fkMachine);
            winProductionOrderClose.StartPosition = FormStartPosition.CenterParent;
            winProductionOrderClose.ShowDialog(this);
            objProductionOrder.load(objProductionOrder.codsec);
            if (objProductionOrder.StatusName == "Cerrada")
            {
                tbcProductionOrder.TabPages.Remove(tbpClose);
                cmbProductionOrderFormulation.Enabled = false;
                btnProductionOrderAddFormulation.Enabled = false;
            }
            /*objProductionOrder.close();
            MessageBox.Show("La orden de producción ha sido cerrada.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            tbcProductionOrder.TabPages.Remove(tbpClose);
            cmbProductionOrderFormulation.Enabled = false;
            btnProductionOrderAddFormulation.Enabled = false;*/
        }

        private void cmbProductionOrderFormulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFormulation objFormulation = clsFormulation.getFormulationCastDetail(((clsFormulation)cmbProductionOrderFormulation.SelectedItem).codsec);
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();

            lblFormulationC1Thickness.Text = objFormulation.thickLayerC1.ToString();
            lblFormulationC2Thickness.Text = objFormulation.thickLayerC2.ToString();
            lblFormulationCentralLayerThickness.Text = objFormulation.thickCentralLayer.ToString();

            lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objFormulation.codsec);

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC1 == true)
                {
                    dgvC1.Rows.Add();
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells["clmC1RawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells["clmC1Percentage"].Value = lstRawMaterialByFormulation[i].percentage;

                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC2 == true)
                {
                    dgvC2.Rows.Add();
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells["clmC2RawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells["clmC2Percentage"].Value = lstRawMaterialByFormulation[i].percentage;

                }
            }


            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].CentralLayer == true)
                {
                    dgvCentralLayer.Rows.Add();
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells["clmCentralLayerRawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells["clmCentralLayerPercentage"].Value = lstRawMaterialByFormulation[i].percentage;

                }
            }
        }

        private void dgvProductionOrderMainCoil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmProductionOrderOutLine.Index)
            {
                frmMainCoilOutline winMainCoilOutline = new frmMainCoilOutline(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value));
                winMainCoilOutline.MdiParent = this.MdiParent;
                winMainCoilOutline.StartPosition = FormStartPosition.Manual;
                winMainCoilOutline.Show();
            }
            if (e.ColumnIndex == clmProductionOrderCoilQuality.Index)
            {
                frmMainCoilQualityReport winMainCoilQualityReport = new frmMainCoilQualityReport(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value));
                winMainCoilQualityReport.MdiParent = this.MdiParent;
                winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                winMainCoilQualityReport.Show();
            }
            if (e.ColumnIndex == clmProductionOrderEdit.Index)
            {
                frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value), true);
                winMainCoilRegister.ShowDialog();

                List<clsMainCoil> lstMainCoil = clsMainCoil.getBoppMainCoilByProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
                dgvProductionOrderMainCoil.Rows.Clear();

                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvProductionOrderMainCoil.Rows.Add();
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCodsec.Index].Value = lstMainCoil[i].codsec.ToString();
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCode.Index].Value = lstMainCoil[i].code.ToString();
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilBatch.Index].Value = lstMainCoil[i].lotNumber.ToString();
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilWeigth.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netWeigth, 2));
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilLength.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netlength, 2));
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilStatus.Index].Value = lstMainCoil[i].StatusName.ToString();
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderEdit.Index].Value = BPS.Properties.Resources.pencil;
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderOutLine.Index].Value = BPS.Properties.Resources.chart_line;
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderCoilQuality.Index].Value = BPS.Properties.Resources.report;
                    dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderDeleteMainCoil.Index].Value = BPS.Properties.Resources.cross;
                }
            }
            if (e.ColumnIndex == clmProductionOrderDeleteMainCoil.Index)
            {
                if (MessageBox.Show("Está seguro que desea borrar el rollo madre?, tenga en cuenta que es un proceso irreversible.", "borrado de rollo madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsMainCoil.delete(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value));
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMainCoilList();
        }

        private void btnAddDecrease_Click(object sender, EventArgs e)
        {
            clsDecreaseByFilmProductionPlan objDecreaseByFilmProductionPlan = new clsDecreaseByFilmProductionPlan();
            objDecreaseByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
            objDecreaseByFilmProductionPlan.fkDecrease = ((clsDecrease)cmbDecreaseName.SelectedItem).codsec;
            objDecreaseByFilmProductionPlan.weight = Convert.ToDouble(txtDecreaseQuantity.Text);
            objDecreaseByFilmProductionPlan.createdDate = dtpDecreaseDate.Value;
            objDecreaseByFilmProductionPlan.fkFormulation = clsFormulationByFilmProductionPlan.getActiveFormulationByFilmProductionPlan(objFilmProductionPlan.codsec).fkFormulation;
            objDecreaseByFilmProductionPlan.save();
            loadDecreaseByFilmProductionPlan();
            cmbDecreaseName.SelectedIndex = -1;
            txtDecreaseQuantity.Text = "0";
            cmbDecreaseName.Focus();

        }

        private void btnAddDeadTime_Click(object sender, EventArgs e)
        {
            clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
            objDeadTimeByFilmProductionPlan.fkDeadTimeType = ((clsDeadTimeType)cmbCause.SelectedItem).codsec;
            objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
            objDeadTimeByFilmProductionPlan.initDate = dtpInitDeadTime.Value;
            objDeadTimeByFilmProductionPlan.endDate = dtpEndDeadTime.Value;
            objDeadTimeByFilmProductionPlan.save();
            loadDeadTimeByFilmProductionPlan();
            cmbCause.SelectedIndex = -1;
            dtpEndDeadTime.Value = DateTime.Now;
            dtpInitDeadTime.Value = DateTime.Now;
            cmbCause.Focus();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnExit5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDecreaseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsDecrease> lstDecrease = clsDecrease.getListForFilmProductionPlan();
                cmbDecreaseName.Items.Clear();
                for (int i = 0; i < lstDecrease.Count; i++)
                    cmbDecreaseName.Items.Add(lstDecrease[i]);
            }
        }

        private void cmbCause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsDeadTimeType> lstDeadTimeType = clsDeadTimeType.getList();
                cmbCause.Items.Clear();
                for (int i = 0; i < lstDeadTimeType.Count; i++)
                    cmbCause.Items.Add(lstDeadTimeType[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmNewMainCoilRegister winNewMainCoilRegister = new frmNewMainCoilRegister(objFilmProductionPlan.fkMachine);
            winNewMainCoilRegister.StartPosition = FormStartPosition.CenterScreen;
            winNewMainCoilRegister.ShowDialog();

            loadMainCoilList();
        }

        private void dgvDecrease_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDecreaseDelete.Index)
            {
                if (MessageBox.Show("Eliminar el desperdicio seleccionado?", "Desperdicios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsConnection.executeQuery("DELETE FROM bps_prod_decreasebyfilmproductionplan WHERE dbfpp_codsec = " + dgvDecrease.Rows[e.RowIndex].Cells[clmDecreaseCodsec.Index].Value.ToString());
                    loadDecreaseByFilmProductionPlan();
                }
            }
        }

        private void dgvDeadTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDeadTimeDelete.Index)
            {
                if (MessageBox.Show("Eliminar el tiempo muerto seleccionado?", "Tiempos muertos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsConnection.executeQuery("DELETE FROM bps_prod_deadtimebyfilmproductionplan WHERE dtbfpp_codsec = " + dgvDeadTime.Rows[e.RowIndex].Cells[clmDeadTimeCodsec.Index].Value.ToString());
                    loadDeadTimeByFilmProductionPlan();
                }
            }
        }
    }    
}