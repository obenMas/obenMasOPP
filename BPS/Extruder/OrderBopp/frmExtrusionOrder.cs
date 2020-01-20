using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmExtrusionOrder : Form
    {
        public bool inProduction = false;
        public int selectedProductionOrder = 0;
        List<clsFormulation> lstFormulation = new List<clsFormulation>();
        int rowSelected = -1;

        public frmExtrusionOrder()
        {
            InitializeComponent();
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtKgPerHour, ref lblKgPerHour, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbFormulation, ref lblFormulation, "selected")) isValid = false;
            return isValid;
        }
        private void getMachineInformation()
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            txtKPH.Text = "0";
            lblMaximumWidthValue.Text = "0";
            lblMinimumWidthValue.Text = "0";
            if (cmbMachine.SelectedIndex >= 0)
            {
                int lotNumberSequencial;
                lotNumberSequencial = clsFilmProductionPlan.getNextLotNumberByMachine(((clsMachine)cmbMachine.SelectedItem).codsec);
                txtKPH.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.kilogramsPerHour.ToString();
                lblMaximumWidthValue.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.maxFilmWidth.ToString();
                lblMinimumWidthValue.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.minFilmWidth.ToString();
                lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(((clsMachine)cmbMachine.SelectedItem).codsec);
                dgvCalendar.Rows.Clear();
                inProduction = false;
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                {
                    this.dgvCalendar.Rows.Add();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value = lstFilmProductionPlan[i].codsec.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarPONumber.Index].Value = (lstFilmProductionPlan[i].productionOrderNumber == 0) ? " --- " : lstFilmProductionPlan[i].productionOrderNumber.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarPOCodsec.Index].Value = lstFilmProductionPlan[i].fkProductionOrder.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarFilm.Index].Value = lstFilmProductionPlan[i].productionOrder.Bopp.code.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value = lstFilmProductionPlan[i].totalWeight.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value = lstFilmProductionPlan[i].estimatedKilogramsPerHour.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarProductionTime.Index].Value = Convert.ToString(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = lstFilmProductionPlan[i].estimatedInitDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = lstFilmProductionPlan[i].estimatedEndDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarWidths.Index].Value = lstFilmProductionPlan[i].widths.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarLength.Index].Value = lstFilmProductionPlan[i].estimatedLength.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCustomers.Index].Value = lstFilmProductionPlan[i].productionOrder.customerLists.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarNotes.Index].Value = lstFilmProductionPlan[i].notes.ToUpper().ToString();

                    if (lstFilmProductionPlan[i].productionOrderStatusName == "En producción")
                    {
                        inProduction = true;
                        for (int j = 0; j < dgvCalendar.ColumnCount; j++)
                            dgvCalendar.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                }
                grpbLotInformation.Enabled = !inProduction;
                txtNumber.Text = "";
                txtWeight.Text = "0";
                txtFilm.Text = "";
                txtKgPerHour.Text = "0";
                txtProductionTime.Text = "0";
                cmbFormulation.SelectedIndex = -1;
                dtpInitDate.Value = DateTime.Now;
                if (inProduction == false)
                    txtNumber.Text = DateTime.Today.ToString("yy") + ((clsMachine)cmbMachine.SelectedItem).Extruder.ProductionLineNumber + clsGlobal.FillWithZeros(lotNumberSequencial.ToString(), 4);
            }
        }
        private void frmExtrusionOrder_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
            cmbMachine.Items.Clear();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMachine.Items.Add(lstMachines[i]);
            clmActions.Text = "Extruir";
            clmActions.UseColumnTextForButtonValue = true;
        }

        private void cmbMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMachineInformation();
        }

        private void dgvCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != clmActions.Index)
            {
                selectedProductionOrder = 0;
                clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
                if (inProduction == false)
                {
                    cmbFormulation.Items.Clear();
                    rowSelected = e.RowIndex;
                    selectedProductionOrder = Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarPOCodsec.Index].Value);
                    objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(selectedProductionOrder);
                    lstFormulation = clsFormulation.getListByBoppFilm(objFilmProductionPlan.productionOrder.fkBopp, true);
                    for (int i = 0; i < lstFormulation.Count; i++)
                        cmbFormulation.Items.Add(lstFormulation[i]);

                    int lotNumberSequencial;
                    lotNumberSequencial = clsFilmProductionPlan.getNextLotNumberByMachine(((clsMachine)cmbMachine.SelectedItem).codsec);
                    txtNumber.Text = DateTime.Today.ToString("yy") + ((clsMachine)cmbMachine.SelectedItem).Extruder.ProductionLineNumber + clsGlobal.FillWithZeros(lotNumberSequencial.ToString(), 4);
                    txtWeight.Text = objFilmProductionPlan.totalWeight.ToString();
                    txtFilm.Text = objFilmProductionPlan.productionOrder.Bopp.code;
                    txtKgPerHour.Text = objFilmProductionPlan.estimatedKilogramsPerHour.ToString();
                    txtProductionTime.Text = Convert.ToString(Math.Round(Convert.ToDouble((objFilmProductionPlan.totalWeight / objFilmProductionPlan.estimatedKilogramsPerHour)), 2));
                    txtWidths.Text = objFilmProductionPlan.widths;
                    txtNotes.Text = objFilmProductionPlan.notes;
                    txtLength.Text = objFilmProductionPlan.estimatedLength.ToString();
                    grpbLotInformation.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No puede crear una orden de producción para la máquina " + cmbMachine.Text + " ya que existe una orden de extrusión ejecutandose.");
                    grpbLotInformation.Enabled = false;
                }
            }
        }

        private void txtKgPerHour_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtKgPerHour.Text))
                txtProductionTime.Text = Convert.ToString(Math.Round(Convert.ToDouble((Convert.ToDouble(txtWeight.Text) / Convert.ToDouble(txtKgPerHour.Text))), 2));
            else
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtKgPerHour.Text = "0";
                txtProductionTime.Text = Convert.ToString(Math.Round(Convert.ToDouble((Convert.ToDouble(txtWeight.Text) / Convert.ToDouble(txtKgPerHour.Text))), 2));
                txtKgPerHour.SelectAll();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                DateTime initDate = DateTime.Now;
                clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
                DataGridViewRow rowToMove = dgvCalendar.Rows[rowSelected];
                dgvCalendar.Rows.RemoveAt(rowSelected);
                dgvCalendar.Rows.Insert(0, rowToMove);
                initDate = dtpInitDate.Value;
                for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = initDate.ToString();
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = initDate.AddHours(Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value) / Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value));
                    }
                    else
                    {
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = dgvCalendar.Rows[i - 1].Cells[clmMachineCalendarEndDateTime.Index].Value;
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value).AddHours(Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value) / Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value));
                    }
                }

                for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                {
                    objFilmProductionPlan = new clsFilmProductionPlan(Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value));
                    objFilmProductionPlan.codsec = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value);
                    objFilmProductionPlan.fkProductionOrder = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarPOCodsec.Index].Value);
                    objFilmProductionPlan.fkMachine = ((clsMachine)cmbMachine.SelectedItem).codsec;
                    objFilmProductionPlan.totalWeight = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value);
                    objFilmProductionPlan.estimatedInitDate = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value);
                    objFilmProductionPlan.estimatedEndDate = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value);
                    objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value);
                    objFilmProductionPlan.save();
                }

                clsFormulationByFilmProductionPlan objFormulationByProductionPlan = new clsFormulationByFilmProductionPlan();

                clsProductionOrder objProductionOrder = new clsProductionOrder(selectedProductionOrder);
                objProductionOrder.number = clsExtruder.getNextProductionOrderByExtruder(((clsMachine)cmbMachine.SelectedItem).Extruder.codsec);
                objProductionOrder.save();
                ((clsMachine)cmbMachine.SelectedItem).Extruder.increaseProductOrderSequential();

                objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(selectedProductionOrder);
                objFilmProductionPlan.setLotNumberSecuential();
                clsProductionOrder.changeOrderStatus(objFilmProductionPlan.fkProductionOrder, "En producción");

                objFilmProductionPlan.lotNumber = txtNumber.Text;
                objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(txtKgPerHour.Text);
                objFilmProductionPlan.estimatedInitDate = dtpInitDate.Value;
                objFilmProductionPlan.estimatedEndDate = dtpInitDate.Value.AddHours(Convert.ToDouble(txtProductionTime.Text));

                objFilmProductionPlan.save();

                objFormulationByProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
                objFormulationByProductionPlan.fkFormulation = ((clsFormulation)cmbFormulation.SelectedItem).codsec;
                objFormulationByProductionPlan.isActive = true;
                objFormulationByProductionPlan.createdBy = clsGlobal.LoggedUser.codsec;
                objFormulationByProductionPlan.createdDate = DateTime.Now;

                objFormulationByProductionPlan.save();
                MessageBox.Show("Se ha puesto en ejecución la orden de extrusión seleccionada.", "Ordenes de extrusión", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                getMachineInformation();
            }
        }

        private void cmbMachine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
                cmbMachine.Items.Clear();
                for (int i = 0; i < lstMachines.Count; i++)
                    cmbMachine.Items.Add(lstMachines[i]);
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmFormulationsList winFormulationsList = new frmFormulationsList();
            winFormulationsList.StartPosition = FormStartPosition.Manual;
            winFormulationsList.ShowDialog(this.MdiParent);
        }
    }
}