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
    public partial class frmMainCoil : Form
    {
        clsDecrease objDecrease = new clsDecrease();
        public int selectedDecrease = 0;
        clsMachine objMachine = new clsMachine();
        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
        clsMainCoil objMainCoil = new clsMainCoil();

        public frmMainCoil()
        {
            InitializeComponent();
        }
        public frmMainCoil(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(machineCodsec);
        }
        
        private void calculateTotals()
        {
            lblWeigth.Text = Convert.ToString(Math.Round(((Convert.ToDouble(txtLength.Text) * (Convert.ToDouble(txtWidth.Text) / 1000) * Convert.ToDouble(txtGramaje.Text))/1000),2));

            lblNetWeigth.Text = Convert.ToString(Math.Round((Convert.ToDouble(lblWeigth.Text) - Convert.ToDouble(lblTotalDecrease.Text)), 2));

            lblNetLength.Text = Convert.ToString(Math.Round((Convert.ToDouble(lblNetWeigth.Text) * 1000) / ((Convert.ToDouble(txtWidth.Text) / 1000) * Convert.ToDouble(txtGramaje.Text)), 2));

        }
        private void initializeForm()
        {
            objMachine.load(objMachine.codsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(objMachine.codsec);

            List<clsTypeMainCoil> lstTypeMainCoil = clsTypeMainCoil.getList();
            cmbMainCoilType.Items.Clear();
            for (int i = 0; i < lstTypeMainCoil.Count; i++)
                cmbMainCoilType.Items.Add(lstTypeMainCoil[i]);

            List<clsUser> lstSupervisor = clsUser.getListByRole("Supervisor de extrusión");
            List<clsUser> lstOperator = clsUser.getListByRole("Operadores de extrusión");
            List<clsUser> lstCoiler = clsUser.getListByRole("Bobinadores");

            cmbSupervisor.Items.Clear();
            for (int i = 0; i < lstSupervisor.Count; i++)
                cmbSupervisor.Items.Add(lstSupervisor[i]);

            cmbOperator.Items.Clear();
            for (int i = 0; i < lstOperator.Count; i++)
                cmbOperator.Items.Add(lstOperator[i]);

            cmbCoiler.Items.Clear();
            for (int i = 0; i < lstCoiler.Count; i++)
                cmbCoiler.Items.Add(lstCoiler[i]);

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd  hh:mm:ss tt");

            List<clsFormulationByFilmProductionPlan> lstFormulatios = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlanByProductionOrder.fkFilmProductionPlan);
            lblVariation.Text = Convert.ToString(lstFormulatios.Count - 1);

            lblOrderNumber.Text = objFilmProductionPlanByProductionOrder.OrderNumber.ToString();
            lblQuantity.Text = Convert.ToString(Math.Round(objFilmProductionPlanByProductionOrder.Quantity, 2));
            lblFullfilledQuantity.Text =  Convert.ToString(Math.Round(objFilmProductionPlanByProductionOrder.FulfilledQuantity, 2));
            lblRemainingQuantity.Text = Convert.ToString(Math.Round((objFilmProductionPlanByProductionOrder.Quantity - objFilmProductionPlanByProductionOrder.FulfilledQuantity), 2));
            lblFilmType.Text = objFilmProductionPlanByProductionOrder.BoppCode;
            lblLot.Text = objFilmProductionPlanByProductionOrder.lotNumber.ToString() + Convert.ToString(lstFormulatios.Count - 1);
            lblMachine.Text = objMachine.Extruder.name;

            clsFormulationByFilmProductionPlan objFormulationByProductionPlan = new clsFormulationByFilmProductionPlan();
            objFormulationByProductionPlan = clsFormulationByFilmProductionPlan.getActiveFormulationByFilmProductionPlan(objFilmProductionPlanByProductionOrder.fkFilmProductionPlan);

            lblFormulation.Text = objFormulationByProductionPlan.formulationName;

            List<int> lstCoilerNumber = new List<int>();
            lstCoilerNumber = clsExtruder.getCoilersNumbersByExtruder(objMachine.Extruder.codsec);


            cmbCoilerNumber.Items.Clear();
            for (int i = 0; i < lstCoilerNumber.Count; i++)
                cmbCoilerNumber.Items.Add(lstCoilerNumber[i]);
            
            if (cmbCoilerNumber.Items.Count == 1)
                cmbCoilerNumber.SelectedIndex = 0;

            if (objFilmProductionPlanByProductionOrder.fkFilmProductionPlan == 0)
                MessageBox.Show("No existe ninguna orden de extrusión activa para esta máquina.", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCoilerNumber, ref lblCoiler, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtGramaje, ref lblMainCoilGramaje, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtKgPerHour, ref lblMainCoilKgPerHour, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLength, ref lblMainCoilGrossLength, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtVelocity, ref lblMainCoilVelocity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWidth, ref lblMainCoilWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMainCoilType, ref lblMainCoilType, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSupervisor, ref lblSupervisor, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbOperator, ref lblMainCoilUser, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCoiler, ref lblCoiler, "selected")) isValid = false;


            return isValid;
        }
        private void frmMainCoil_Load(object sender, EventArgs e)
        {
            initializeForm();
        }

        private void dgvMainCoilDecrease_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsTypeMainCoil objTypeMainCoil = new clsTypeMainCoil();
            if (e.ColumnIndex == 1)
            {
                frmDecreaseSelector winDecreaseSelector = new frmDecreaseSelector(this);
                winDecreaseSelector.ShowDialog(this);
                objDecrease.load(selectedDecrease);

                if (objDecrease.codsec > 0)
                {
                    dgvMainCoilDecrease.CurrentRow.Cells[clmDecreaseCodsec.Index].Value = objDecrease.codsec;
                    dgvMainCoilDecrease.CurrentRow.Cells[clmMainCoilDecreaseType.Index].Value = objDecrease.name;
                }
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpInitDateTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = dtpEndDateTime.Value.Subtract(dtpInitDateTime.Value);
            lblHours.Text = Convert.ToString((Math.Round(span.TotalHours,2)));
        }

        private void dtpEndDateTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = dtpEndDateTime.Value.Subtract(dtpInitDateTime.Value);
            lblHours.Text = Convert.ToString((Math.Round(span.TotalHours, 2)));
        }

        private void cmbCoilerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yearDigits, monthDigits, coilerDigit, secuencial;
            DateTime today = DateTime.Today;

            yearDigits = today.ToString("yy");
            monthDigits = today.ToString("MM");
            if (cmbCoilerNumber.SelectedIndex > -1)
                coilerDigit = cmbCoilerNumber.Text;
            else
                coilerDigit = "-";
            secuencial = clsGlobal.FillWithZeros(objMachine.Extruder.sequential.ToString(), 4);

            lblCode.Text = yearDigits + monthDigits + coilerDigit + secuencial;
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtLength.Text))
                calculateTotals();
            else
            {
                MessageBox.Show("El valor debe ser numérico", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtLength.Text = "0";
                txtLength.SelectAll();
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtWidth.Text))
                calculateTotals();
            else
            {
                MessageBox.Show("El valor debe ser numérico", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtWidth.Text = "0";
                txtWidth.SelectAll();
            }
        }

        private void txtGramaje_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtGramaje.Text))
                calculateTotals();
            else
            {
                MessageBox.Show("El valor debe ser numérico", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtGramaje.Text = "0";
                txtGramaje.SelectAll();
            }
        }

        private void dgvMainCoilDecrease_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    if (clsGlobal.isNumeric(dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString()) == false && dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        dgvMainCoilDecrease.CancelEdit();
                    }
                    else if (dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString() != "")
                    {
                        double totalDecrease = 0;
                        for (int i = 0; i < dgvMainCoilDecrease.Rows.Count; i++)
                        {
                            if (i == e.RowIndex)
                                totalDecrease += Convert.ToDouble(dgvMainCoilDecrease.CurrentCell.EditedFormattedValue);
                            else
                                totalDecrease += Convert.ToDouble(dgvMainCoilDecrease.Rows[i].Cells[clmMainCoilWeigth.Index].Value);
                        }

                        lblTotalDecrease.Text = Convert.ToString(Math.Round(totalDecrease, 2));
                        calculateTotals();
                    }
                    else if (dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString() == "")
                        dgvMainCoilDecrease.CancelEdit();
                    break;
            }
        }

        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objMainCoil.fkBopp = objFilmProductionPlanByProductionOrder.fkBopp;
                objMainCoil.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "Nueva").codsec;
                objMainCoil.fkFilmProductionPlan = objFilmProductionPlanByProductionOrder.fkFilmProductionPlan;
                objMainCoil.fkMachine = objMachine.codsec;
                objMainCoil.code = lblCode.Text;
                objMainCoil.variation = Convert.ToInt32(lblVariation.Text);
                objMainCoil.lotNumber = lblLot.Text;
                objMainCoil.grosslength = Convert.ToDouble(txtLength.Text);
                objMainCoil.netlength = Convert.ToDouble(lblNetLength.Text);
                objMainCoil.grossWeigth = Convert.ToDouble(lblWeigth.Text);
                objMainCoil.netWeigth = Convert.ToDouble(lblNetWeigth.Text);
                objMainCoil.width = Convert.ToInt32(txtWidth.Text);
                objMainCoil.gramaje = Convert.ToDouble(txtGramaje.Text);
                objMainCoil.velocity = Convert.ToInt32(txtVelocity.Text);
                objMainCoil.productionKgHr = Convert.ToDouble(txtKgPerHour.Text);
                objMainCoil.notes = txtObservations.Text;
                objMainCoil.initDate = dtpInitDateTime.Value;
                objMainCoil.endDate = dtpEndDateTime.Value;
                objMainCoil.createdDate = DateTime.Now;
                objMainCoil.modifiedDate = DateTime.Now;
                objMainCoil.createdBy = clsGlobal.LoggedUser.codsec;
                objMainCoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                objMainCoil.supervisor = ((clsUser)cmbSupervisor.SelectedItem).codsec;
                objMainCoil.Operator = ((clsUser)cmbOperator.SelectedItem).codsec;
                objMainCoil.coiler = ((clsUser)cmbCoiler.SelectedItem).codsec;

                if (objMainCoil.save())
                {
                    objMachine.Extruder.increaseSequential();

                    for (int i = 0; i < dgvMainCoilDecrease.Rows.Count; i++)
                    {
                        if (dgvMainCoilDecrease.Rows[i].Cells[clmDecreaseCodsec.Index].Value != null)
                        {
                            clsDecreaseByMainCoil objDecreaseByMainCoil = new clsDecreaseByMainCoil();
                            objDecreaseByMainCoil.fkDecrease = Convert.ToInt32(dgvMainCoilDecrease.Rows[i].Cells[clmDecreaseCodsec.Index].Value);
                            objDecreaseByMainCoil.fkMainCoil = objMainCoil.codsec;
                            objDecreaseByMainCoil.weigth = Convert.ToDouble(dgvMainCoilDecrease.Rows[i].Cells[clmMainCoilWeigth.Index].Value);
                            objDecreaseByMainCoil.save();
                        }
                    }

                    MessageBox.Show("La rollo madre se ha guardado con éxito.", "Registro de Rollo madre", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if (MessageBox.Show("Desea registrar una nueva rollo madre?", "Registro de Rollo madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        objMainCoil = new clsMainCoil();
                        clsGlobal.ClearForm(this);
                        initializeForm();
                    }
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Rollo madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            clsGlobal.ClearForm(this);
            initializeForm();
        }

        private void cmbMainCoilType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsTypeMainCoil> lstTypeMainCoil = clsTypeMainCoil.getList();
                cmbMainCoilType.Items.Clear();
                for (int i = 0; i < lstTypeMainCoil.Count; i++)
                    cmbMainCoilType.Items.Add(lstTypeMainCoil[i]); 
            }
        }

        private void cmbSupervisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstSupervisor = clsUser.getListByRole("Supervisor de extrusión");
                cmbSupervisor.Items.Clear();
                for (int i = 0; i < lstSupervisor.Count; i++)
                    cmbSupervisor.Items.Add(lstSupervisor[i]); 
            }
        }

        private void cmbOperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstOperator = clsUser.getListByRole("Operadores de extrusión");
                cmbOperator.Items.Clear();
                for (int i = 0; i < lstOperator.Count; i++)
                    cmbOperator.Items.Add(lstOperator[i]); 
            }
        }

        private void cmbCoiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstCoiler = clsUser.getListByRole("Bobinadores");
                cmbCoiler.Items.Clear();
                for (int i = 0; i < lstCoiler.Count; i++)
                    cmbCoiler.Items.Add(lstCoiler[i]); 
            }
        }
    }
}