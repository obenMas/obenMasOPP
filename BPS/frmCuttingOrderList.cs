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
    public partial class frmCuttingOrderList : Form
    {
        List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
        clsMachine objCutterMachine = new clsMachine();

        private void loadCuttingOrderList()
        {
            lstCuttingOrder = clsCuttingOrder.getProgramedListByMachine(objCutterMachine.codsec);
            dgvCuttingOrder.Rows.Clear();
            for (int i = 0; i < lstCuttingOrder.Count; i++)
            {
                if (lstCuttingOrder[i].isSecundaryCut == false)
                {
                    dgvCuttingOrder.Rows.Add();
                    dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
                    dgvCuttingOrder.Rows[i].Cells[clmPrio.Index].Value = lstCuttingOrder[i].priority;
                    dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrder[i].machineName;
                    if (lstCuttingOrder[i].fkBopp > 0)
                        dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = new clsBopp(lstCuttingOrder[i].fkBopp).code.Replace("-", "");
                    else
                        dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = new clsCast(lstCuttingOrder[i].fkCast).code.Replace("-", "");
                    dgvCuttingOrder.Rows[i].Cells[clmOrderNumber.Index].Value = lstCuttingOrder[i].number;
                    dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
                    for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
                    {
                        dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
                        if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
                            dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " + ";
                    }
                    dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " ]";
                    dgvCuttingOrder.Rows[i].Cells[clmRepetitions.Index].Value = lstCuttingOrder[i].repetitions.ToString();
                    dgvCuttingOrder.Rows[i].Cells[clmProgrammedWeigth.Index].Value = lstCuttingOrder[i].programmedWeight.ToString();
                    dgvCuttingOrder.Rows[i].Cells[clmCreatedDate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
                    if (lstCuttingOrder[i].fkStatus == 25)
                    {
                        for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                            dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;

                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.play_sharp;
                    }
                    else if (lstCuttingOrder[i].fkStatus == 24)
                    {
                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.calendar_2;
                    }
                    else if (lstCuttingOrder[i].fkStatus == 31)
                    {
                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.pause_sharp;
                    }
                    dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = false;
                }
                else
                {
                    dgvCuttingOrder.Rows.Add();
                    dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
                    dgvCuttingOrder.Rows[i].Cells[clmPrio.Index].Value = lstCuttingOrder[i].priority;
                    dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrder[i].machineName;
                    dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = lstCuttingOrder[i].productCode;
                    dgvCuttingOrder.Rows[i].Cells[clmOrderNumber.Index].Value = lstCuttingOrder[i].number;
                    dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
                    for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
                    {
                        dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
                        if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
                            dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " + ";
                    }
                    dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " ]";
                    dgvCuttingOrder.Rows[i].Cells[clmRepetitions.Index].Value = lstCuttingOrder[i].repetitions.ToString();
                    dgvCuttingOrder.Rows[i].Cells[clmProgrammedWeigth.Index].Value = lstCuttingOrder[i].programmedWeight.ToString();
                    dgvCuttingOrder.Rows[i].Cells[clmCreatedDate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
                    if (lstCuttingOrder[i].fkStatus == 25)
                    {
                        for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                            dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;

                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.play_sharp;
                    }
                    else if (lstCuttingOrder[i].fkStatus == 24)
                    {
                        for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                            dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);

                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.calendar_2;
                    }
                    else if (lstCuttingOrder[i].fkStatus == 31)
                    {
                        for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                            dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);

                        dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.pause_sharp;
                    }
                    dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = true;
                }
            }
        }

        public frmCuttingOrderList()
        {
            InitializeComponent();
        }

        public frmCuttingOrderList(int codsec, bool edit)
        {
            InitializeComponent();
            objCutterMachine.load(codsec, "Cutter");
            dgvCuttingOrder.ReadOnly = edit;
        }

        private void frmCuttingOrderList_Load(object sender, EventArgs e)
        {
            loadCuttingOrderList();
        }
        private void dgvCuttingOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgvCuttingOrder.Rows[e.RowIndex].Cells[clmIsSecundaryCut.Index].Value) == false)
                {
                    GroupBox objGrpbDetail = clsCuttingOrderResume.getCuttingOrderResumeLayoutByCuttingOrder(new clsCuttingOrder(Convert.ToInt32(dgvCuttingOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value),true), "cuttingOrderList");
                    ((Button)objGrpbDetail.Controls["btnProcess"]).Click += new System.EventHandler(edit);
                    ((NumericUpDown)objGrpbDetail.Controls["nudStopsNumber"]).Visible = false;
                    ((Button)objGrpbDetail.Controls["btnRefresh"]).Click += new System.EventHandler(changeStops);
                    ((Button)objGrpbDetail.Controls["btnChangeCutter"]).Click += new System.EventHandler(changeCutter);
                    ((Button)objGrpbDetail.Controls["btnCancel"]).Click += new System.EventHandler(delete);
                    ((ComboBox)objGrpbDetail.Controls["cmbCutter"]).Visible = false;
                    for (int j = 0; j < objGrpbDetail.Controls["grpbCombination"].Controls.Count; j++)
                    {
                        if (object.ReferenceEquals(objGrpbDetail.Controls["grpbCombination"].Controls[j].GetType(), typeof(System.Windows.Forms.CheckBox)))
                            ((CheckBox)objGrpbDetail.Controls["grpbCombination"].Controls[j]).Enabled = false;
                    }
                    grpbCuttingOrderDetail.Controls.Clear();
                    grpbCuttingOrderDetail.Controls.Add(objGrpbDetail);
                }
                else
                {
                    GroupBox objGrpbDetail = clsCuttingOrderResume.getSecundaryCuttingOrderResumeLayoutByCuttingOrder(new clsCuttingOrder(Convert.ToInt32(dgvCuttingOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)), "cuttingOrderList");
                    ((Button)objGrpbDetail.Controls["btnProcess"]).Click += new System.EventHandler(edit);
                    ((NumericUpDown)objGrpbDetail.Controls["nudStopsNumber"]).Visible = false;
                    ((Button)objGrpbDetail.Controls["btnRefresh"]).Click += new System.EventHandler(changeStops);
                    ((Button)objGrpbDetail.Controls["btnChangeCutter"]).Click += new System.EventHandler(changeCutter);
                    ((Button)objGrpbDetail.Controls["btnCancel"]).Click += new System.EventHandler(delete);
                    ((ComboBox)objGrpbDetail.Controls["cmbCutter"]).Visible = false;
                    for (int j = 0; j < objGrpbDetail.Controls["grpbCombination"].Controls.Count; j++)
                    {
                        if (object.ReferenceEquals(objGrpbDetail.Controls["grpbCombination"].Controls[j].GetType(), typeof(System.Windows.Forms.CheckBox)))
                            ((CheckBox)objGrpbDetail.Controls["grpbCombination"].Controls[j]).Enabled = false;
                    }
                    grpbCuttingOrderDetail.Controls.Clear();
                    grpbCuttingOrderDetail.Controls.Add(objGrpbDetail);
                }
            }
        }
        private void edit(object sender, EventArgs e)
        {
            frmCuttingOrderDetail winCuttingOrderDetail = new frmCuttingOrderDetail(Convert.ToInt32(dgvCuttingOrder.CurrentRow.Cells[clmCodsec.Index].Value));
            winCuttingOrderDetail.ShowInTaskbar = false;
            winCuttingOrderDetail.ShowDialog(this);
            loadCuttingOrderList();
        }

        private void dgvCuttingOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadCuttingOrderList();
            }
        }
        private void changeStops(object sender, EventArgs e)
        {
            if (((NumericUpDown)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["nudStopsNumber"]).Visible == false)
            {
                ((NumericUpDown)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["nudStopsNumber"]).Visible = true;
                ((Label)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["lblStopsNumber"]).Visible = false;
                ((Button)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["btnRefresh"]).Image = global::BPS.Properties.Resources.disk;
            }
            else
            {
                int COcodsec = Convert.ToInt32(dgvCuttingOrder.Rows[dgvCuttingOrder.CurrentRow.Index].Cells[clmCodsec.Index].Value);
                clsCuttingOrder objCuttingOrder = new clsCuttingOrder(COcodsec);
                objCuttingOrder.repetitions = Convert.ToInt32(((NumericUpDown)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["nudStopsNumber"]).Value);
                objCuttingOrder.save();
                loadCuttingOrderList();

                GroupBox objGrpbDetail = clsCuttingOrderResume.getCuttingOrderResumeLayoutByCuttingOrder(new clsCuttingOrder(COcodsec), "cuttingOrderList");
                ((Button)objGrpbDetail.Controls["btnProcess"]).Click += new System.EventHandler(edit);
                ((NumericUpDown)objGrpbDetail.Controls["nudStopsNumber"]).Visible = false;
                ((Button)objGrpbDetail.Controls["btnRefresh"]).Click += new System.EventHandler(changeStops);
                for (int j = 0; j < objGrpbDetail.Controls["grpbCombination"].Controls.Count; j++)
                {
                    if (object.ReferenceEquals(objGrpbDetail.Controls["grpbCombination"].Controls[j].GetType(), typeof(System.Windows.Forms.CheckBox)))
                        ((CheckBox)objGrpbDetail.Controls["grpbCombination"].Controls[j]).Enabled = false;
                }
                grpbCuttingOrderDetail.Controls.Clear();
                grpbCuttingOrderDetail.Controls.Add(objGrpbDetail);
            }
        }
        private void changeCutter(object sender, EventArgs e)
        {
            if (((ComboBox)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["cmbCutter"]).Visible == false)
            {
                ((ComboBox)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["cmbCutter"]).Visible = true;
                ((Label)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["lblCutterName"]).Visible = false;
                ((Button)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["btnChangeCutter"]).Image = global::BPS.Properties.Resources.disk;
            }
            else
            {
                int COcodsec = Convert.ToInt32(dgvCuttingOrder.Rows[dgvCuttingOrder.CurrentRow.Index].Cells[clmCodsec.Index].Value);
                clsCuttingOrder objCuttingOrder = new clsCuttingOrder(COcodsec);
                objCuttingOrder.fkMachine = ((clsMachine)((ComboBox)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["cmbCutter"]).SelectedItem).codsec;
                objCuttingOrder.save();
                loadCuttingOrderList();
                grpbCuttingOrderDetail.Controls.Clear();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            /*frmCuttingOrderListReport winCuttongOrderListReport = new frmCuttingOrderListReport(objCutterMachine.codsec);
            winCuttongOrderListReport.MdiParent = this.MdiParent;
            winCuttongOrderListReport.StartPosition = FormStartPosition.Manual;
            winCuttongOrderListReport.Show();*/
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingPlan('" + objCutterMachine.codsec + "')");

            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Plan de corte";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Plan de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Plan de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar esta orden de corte?", "Ordenes de corte.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                clsCuttingOrder objCuttingOrder = new clsCuttingOrder(Convert.ToInt32(dgvCuttingOrder.Rows[dgvCuttingOrder.CurrentCell.RowIndex].Cells[clmCodsec.Index].Value));
                objCuttingOrder.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Cerrada")).codsec;
                objCuttingOrder.statusName = "Cerrada";
                objCuttingOrder.save();
                loadCuttingOrderList();
            }
        }

        private void dgvCuttingOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string queryString = "UPDATE bps_prod_cuttingorder ";
            queryString += " SET ";
            queryString += "cord_Priority = " + dgvCuttingOrder.Rows[e.RowIndex].Cells[clmPrio.Index].Value.ToString();
            queryString += "WHERE cord_codsec = " + dgvCuttingOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString() + " ";

            clsConnection.executeQuery(queryString);
        }

      
    }
}