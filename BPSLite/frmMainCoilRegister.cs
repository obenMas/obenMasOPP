using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilRegister : Form
    {
        clsDecrease objDecrease = new clsDecrease();
        public int selectedDecrease = 0;
        clsMachine objMachine = new clsMachine();
        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
        clsMainCoil objMainCoil = new clsMainCoil();
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLabel;
        BPS.Lite.Reports.rptMainCoilSimpleLabel rptMainCoilSimpleLabel1;
        bool formForEdit = false;

        private void createReport()
        {
            this.crvLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilSimpleLabel1 = new BPS.Lite.Reports.rptMainCoilSimpleLabel();

            Tables tables;

            tables = rptMainCoilSimpleLabel1.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilSimpleLabel1.ReportDefinition.Sections;
            foreach (Section section in sections)
            {
                ReportObjects reportObjects = section.ReportObjects;
                foreach (ReportObject reportObject in reportObjects)
                {
                    if (reportObject.Kind == ReportObjectKind.SubreportObject)
                    {
                        SubreportObject subreportObject = (SubreportObject)reportObject;
                        ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                        tables = subReportDocument.Database.Tables;
                        foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                        {
                            TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                            tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            this.crvLabel.ActiveViewIndex = 0;
            this.crvLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLabel.DisplayStatusBar = false;
            this.crvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLabel.Location = new System.Drawing.Point(3, 3);
            this.crvLabel.Name = "crvLabel";
            this.crvLabel.ReportSource = this.rptMainCoilSimpleLabel1;
            this.crvLabel.ShowCloseButton = false;
            this.crvLabel.ShowExportButton = false;
            this.crvLabel.ShowGotoPageButton = false;
            this.crvLabel.ShowGroupTreeButton = false;
            this.crvLabel.ShowPageNavigateButtons = false;
            this.crvLabel.ShowRefreshButton = false;
            this.crvLabel.ShowTextSearchButton = false;
            this.crvLabel.ShowZoomButton = false;
            this.crvLabel.Size = new System.Drawing.Size(646, 529);
            this.crvLabel.TabIndex = 0;
            this.crvLabel.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;

            this.tbpLabel.Controls.Add(this.crvLabel);
        }

        public frmMainCoilRegister()
        {
            InitializeComponent();
        }
        public frmMainCoilRegister(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(machineCodsec);
        }
        public frmMainCoilRegister(bool isForEdit)
        {
            InitializeComponent();
            formForEdit = true;
        }
        public frmMainCoilRegister(int mainCoilCodsec, bool isForEdit)
        {
            InitializeComponent();
            objMainCoil.load(mainCoilCodsec);
            objMachine.load(objMainCoil.fkMachine, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByFilmProductionPlan(objMainCoil.fkFilmProductionPlan);
        }
        private void initializeForm()
        {
            if (objMainCoil.codsec == 0 && formForEdit == true)
            {
                this.crvLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
                this.rptMainCoilSimpleLabel1 = new BPS.Lite.Reports.rptMainCoilSimpleLabel();

                List<clsTypeMainCoil> lstTypeMainCoil = new List<clsTypeMainCoil>();

                lstTypeMainCoil = clsTypeMainCoil.getList();
                cmbMainCoilType.Items.Clear();
                for (int i = 0; i < lstTypeMainCoil.Count; i++)
                    cmbMainCoilType.Items.Add(lstTypeMainCoil[i]);

                List<clsUser> lstSupervisor = clsUser.getListByRole("Supervisor de extrusión");
                List<clsUser> lstOperator = clsUser.getListByRole("Operadores de extrusión");
                List<clsUser> lstCoiler = clsUser.getListByRole("Bobinadores");

                cmbSupervisor.Items.Clear();
                for (int i = 0; i < lstSupervisor.Count; i++)
                    cmbSupervisor.Items.Add(lstSupervisor[i]);
                //for (int i = 0; i < lstOperator.Count; i++)
                //    cmbSupervisor.Items.Add(lstOperator[i]);

                cmbOperator.Items.Clear();
                for (int i = 0; i < lstOperator.Count; i++)
                    cmbOperator.Items.Add(lstOperator[i]);
                //for (int i = 0; i < lstSupervisor.Count; i++)
                //    cmbOperator.Items.Add(lstSupervisor[i]);

                cmbCoiler.Items.Clear();
                //for (int i = 0; i < lstOperator.Count; i++)
                //    cmbCoiler.Items.Add(lstOperator[i]);
                for (int i = 0; i < lstCoiler.Count; i++)
                    cmbCoiler.Items.Add(lstCoiler[i]);

                cmbCoilerNumber.Items.Clear();

                tbcMainCoil.TabPages.Remove(tbpLabel);

                txtMainCoilCode.Enabled = true;
                txtMainCoilCode.Visible = true;
                lblCode.Visible = false;
                txtMainCoilCode.Focus();
            }
            else
            {
                objMachine.load(objMachine.codsec, "Extruder");
                this.crvLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
                this.rptMainCoilSimpleLabel1 = new BPS.Lite.Reports.rptMainCoilSimpleLabel();

                Tables tables;
                tables = rptMainCoilSimpleLabel1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }
                Sections sections = rptMainCoilSimpleLabel1.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                List<clsTypeMainCoil> lstTypeMainCoil = new List<clsTypeMainCoil>();
                lstTypeMainCoil = clsTypeMainCoil.getList();
                cmbMainCoilType.Items.Clear();
                for (int i = 0; i < lstTypeMainCoil.Count; i++)
                    cmbMainCoilType.Items.Add(lstTypeMainCoil[i]);

                List<clsUser> lstSupervisor = clsUser.getListByRole("Supervisor de extrusión");
                List<clsUser> lstOperator = clsUser.getListByRole("Operadores de extrusión");
                List<clsUser> lstCoiler = clsUser.getListByRole("Bobinadores");

                cmbSupervisor.Items.Clear();
                for (int i = 0; i < lstSupervisor.Count; i++)
                    cmbSupervisor.Items.Add(lstSupervisor[i]);
                //for (int i = 0; i < lstOperator.Count; i++)
                //    cmbSupervisor.Items.Add(lstOperator[i]);

                cmbOperator.Items.Clear();
                for (int i = 0; i < lstOperator.Count; i++)
                    cmbOperator.Items.Add(lstOperator[i]);
                //for (int i = 0; i < lstSupervisor.Count; i++)
                //    cmbOperator.Items.Add(lstSupervisor[i]);

                cmbCoiler.Items.Clear();
                //for (int i = 0; i < lstOperator.Count; i++)
                //    cmbCoiler.Items.Add(lstOperator[i]);
                for (int i = 0; i < lstCoiler.Count; i++)
                    cmbCoiler.Items.Add(lstCoiler[i]);

                List<clsFormulationByFilmProductionPlan> lstFormulatios = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlanByProductionOrder.fkFilmProductionPlan);
                lblVariation.Text = Convert.ToString(lstFormulatios.Count - 1);

                lblOrderNumber.Text = objFilmProductionPlanByProductionOrder.OrderNumber.ToString();
                if (objFilmProductionPlanByProductionOrder.fkBopp != 0)
                    lblFilmType.Text = objFilmProductionPlanByProductionOrder.BoppCode;
                else
                    lblFilmType.Text = objFilmProductionPlanByProductionOrder.castCode;
                lblLot.Text = objFilmProductionPlanByProductionOrder.lotNumber.ToString() + Convert.ToString(lstFormulatios.Count - 1);
                lblMachine.Text = objMachine.Extruder.name;

                clsFormulationByFilmProductionPlan objFormulationByProductionPlan = new clsFormulationByFilmProductionPlan();
                objFormulationByProductionPlan = clsFormulationByFilmProductionPlan.getActiveFormulationByFilmProductionPlan(objFilmProductionPlanByProductionOrder.fkFilmProductionPlan);

                List<int> lstCoilerNumber = new List<int>();
                lstCoilerNumber = clsExtruder.getCoilersNumbersByExtruder(objMachine.Extruder.codsec);


                cmbCoilerNumber.Items.Clear();
                for (int i = 0; i < lstCoilerNumber.Count; i++)
                    cmbCoilerNumber.Items.Add(lstCoilerNumber[i]);

                if (cmbCoilerNumber.Items.Count == 1)
                    cmbCoilerNumber.SelectedIndex = 0;

                if (objFilmProductionPlanByProductionOrder.fkFilmProductionPlan == 0)
                {
                    MessageBox.Show("No existe ninguna orden de extrusión activa para esta máquina.", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }

                tbcMainCoil.TabPages.Remove(tbpLabel);

                cmbCoilerNumber.Focus();

                if (objMainCoil.codsec > 0)
                {
                    dtpInitDateTime.Value = objMainCoil.initDate;
                    dtpEndDateTime.Value = objMainCoil.endDate;
                    txtKgPerHour.Text = objMainCoil.productionKgHr.ToString();
                    txtLength.Text = objMainCoil.netlength.ToString();
                    txtVelocity.Text = objMainCoil.velocity.ToString();
                    txtWidth.Text = objMainCoil.width.ToString();
                    txtObservations.Text = objMainCoil.notes;
                    txtMainCoilCode.Text = objMainCoil.code;
                    lblCode.Text = objMainCoil.code;

                    for (int i = 0; i < cmbCoiler.Items.Count; i++)
                    {
                        if (((clsUser)cmbCoiler.Items[i]).codsec == objMainCoil.coiler)
                            cmbCoiler.SelectedIndex = i;
                    }

                    for (int i = 0; i < cmbSupervisor.Items.Count; i++)
                    {
                        if (((clsUser)cmbSupervisor.Items[i]).codsec == objMainCoil.supervisor)
                            cmbSupervisor.SelectedIndex = i;
                    }

                    for (int i = 0; i < cmbOperator.Items.Count; i++)
                    {
                        if (((clsUser)cmbOperator.Items[i]).codsec == objMainCoil.Operator)
                            cmbOperator.SelectedIndex = i;
                    }
                }
            }
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCoilerNumber, ref lblCoiler, "selected")) isValid = false;
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
        private void setReportParameters()
        {
            crvLabel.ParameterFieldInfo.Clear();

            ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
            prmMainCoilCodsec.Value = objMainCoil.codsec;

            ParameterField pfldMainCoilCodsec = new ParameterField();
            pfldMainCoilCodsec.Name = "mainCoilCodsec";
            pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
            pfldMainCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptMainCoilSimpleLabel1.ParameterFields.Count; i++)
            {
                switch (rptMainCoilSimpleLabel1.ParameterFields[i].Name)
                {
                    case "mainCoilCodsec":
                        rptMainCoilSimpleLabel1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilSimpleLabel1.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                        rptMainCoilSimpleLabel1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilSimpleLabel1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilSimpleLabel1.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);

                        break;
                    default:
                        break;
                }
                crvLabel.ParameterFieldInfo.Add(rptMainCoilSimpleLabel1.ParameterFields[i]);
            }
        }
        private void frmMainCoilRegister_Load(object sender, EventArgs e)
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
            lblHours.Text = Convert.ToString((Math.Round(span.TotalHours, 2)));
        }

        private void dtpEndDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInitDateTime.Value < dtpEndDateTime.Value)
            {
                TimeSpan span = dtpEndDateTime.Value.Subtract(dtpInitDateTime.Value);
                lblHours.Text = Convert.ToString((Math.Round(span.TotalHours, 2)));
            }
            else
            {
                MessageBox.Show("La hora de finalización no puede ser menor a la hora de inicio.", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                dtpEndDateTime.Value = dtpInitDateTime.Value.AddSeconds(1);
            }
        }

        private void cmbCoilerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formForEdit == false)
            {
                if (clsMainCoil.getLastCoilRegisteredMonthByMchine(objMachine.codsec) < DateTime.Now.Month)
                    objMachine.Extruder.resetSequential();
                else
                    objMachine.load(objMachine.codsec, "Extruder");

                string yearDigits, monthDigits, coilerDigit, secuencial;
                DateTime today = DateTime.Today;
                yearDigits = today.ToString("yy");
                monthDigits = today.ToString("MM");
                if (cmbCoilerNumber.SelectedIndex > -1)
                    coilerDigit = cmbCoilerNumber.Text;
                else
                    coilerDigit = "-";
                secuencial = clsGlobal.FillWithZeros(objMachine.Extruder.sequential.ToString(), 3);

                lblCode.Text = yearDigits.Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(monthDigits)) + coilerDigit + secuencial;
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (!clsGlobal.isNumeric(txtLength.Text))
            {
                MessageBox.Show("El valor debe ser numérico", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtLength.Text = "0";
                txtLength.SelectAll();
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (!clsGlobal.isNumeric(txtWidth.Text))
            {
                MessageBox.Show("El valor debe ser numérico", "Registro de rollos madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtWidth.Text = "0";
                txtWidth.SelectAll();
            }
        }

        private void dgvMainCoilDecrease_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    if (clsGlobal.isNumeric(dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString()) == false && dgvMainCoilDecrease.CurrentCell.EditedFormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
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
                bool closeAfterClose = false;
                objMainCoil.fkBopp = objFilmProductionPlanByProductionOrder.fkBopp;
                objMainCoil.fkCast = objFilmProductionPlanByProductionOrder.fkCast;
                objMainCoil.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "Nueva").codsec;
                objMainCoil.fkFilmProductionPlan = objFilmProductionPlanByProductionOrder.fkFilmProductionPlan;
                objMainCoil.fkMachine = objMachine.codsec;
                if (formForEdit == false)
                    objMainCoil.code = lblCode.Text;
                objMainCoil.variation = Convert.ToInt32(lblVariation.Text);
                objMainCoil.lotNumber = lblLot.Text;
                objMainCoil.grosslength = Convert.ToDouble(txtLength.Text);
                objMainCoil.netlength = Convert.ToDouble(txtLength.Text);
                objMainCoil.netWeigth = Convert.ToDouble(txtWeight.Text);
                objMainCoil.grossWeigth = Convert.ToDouble(txtWeight.Text);
                objMainCoil.width = Convert.ToInt32(txtWidth.Text);
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
                if (objMainCoil.netWeigth == 0)
                    objMainCoil.calculateWeight = true;
                else
                    objMainCoil.calculateWeight = false;

                if (objMainCoil.codsec > 0)
                    closeAfterClose = false;
                else
                    closeAfterClose = true;

                if (objMachine.Extruder.coilerRegistration != Convert.ToInt32(cmbCoilerNumber.Text) && formForEdit == true)
                    MessageBox.Show("Debe registrar las bobinas en orden.", "Registro de Rollo madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                else
                {
                    if (objMainCoil.save())
                    {
                        if (formForEdit == false)
                        {
                            if (objMachine.Extruder.coilersNumbers[objMachine.Extruder.coilersNumbers.Count - 1] == Convert.ToInt32(cmbCoilerNumber.Text))
                                objMachine.Extruder.increaseSequential();
                            else
                                objMachine.Extruder.increaseCoilerRegistration();
                        }

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

                        if (closeAfterClose == true)
                        {
                            Thread thrdPrint = new Thread(delegate() { BPS.Lite.clsPrintLabels.printMainCoilRegisterOneLabel(objMainCoil.codsec); });
                            thrdPrint.Start();

                            if (MessageBox.Show("Se imprimió la etiqueta?", "Registro de Rollo madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                if (MessageBox.Show("Desea registrar una nueva rollo madre?", "Registro de Rollo madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    objMainCoil = new clsMainCoil();
                                    objMachine.load(objMachine.codsec, "Extruder");
                                    clsGlobal.ClearForm(this);
                                    initializeForm();
                                }
                                else
                                    this.Close();
                            }
                            else
                            {
                                createReport();
                                setReportParameters();
                                crvLabel.PrintReport();
                                tbcMainCoil.TabPages.Add(tbpLabel);
                                tbpLabel.Focus();
                            }
                        }
                        else
                        {
                            if (formForEdit == false)
                                this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Rollo madre", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            clsGlobal.ClearForm(this);
            initializeForm();
        }

        private void cmbCoilerNumber_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void txtMainCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objMainCoil.load(txtMainCoilCode.Text);
                objMachine.load(objMainCoil.fkMachine, "Extruder");
                objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByFilmProductionPlan(objMainCoil.fkFilmProductionPlan);
                initializeForm();
            }
        }

        private void btnFixNumeration_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se procederá a corregir el número secuencial correspondiente al rollo madre, desea continuar?", "Registro de Rollo Madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_secuensial = ext_secuensial - 1 WHERE ext_codsec = " + objMachine.fkExtruder.ToString());

                if (clsMainCoil.getLastCoilRegisteredMonthByMchine(objMachine.codsec) < DateTime.Now.Month)
                    objMachine.Extruder.resetSequential();
                else
                    objMachine.load(objMachine.codsec, "Extruder");

                string yearDigits, monthDigits, coilerDigit, secuencial;
                DateTime today = DateTime.Today;

                yearDigits = today.ToString("yy");
                monthDigits = today.ToString("MM");
                if (cmbCoilerNumber.SelectedIndex > -1)
                    coilerDigit = cmbCoilerNumber.Text;
                else
                    coilerDigit = "-";

                secuencial = clsGlobal.FillWithZeros(objMachine.Extruder.sequential.ToString(), 3);
                lblCode.Text = yearDigits.Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(monthDigits)) + coilerDigit + secuencial;
            }
        }

        private void txtKgPerHour_Enter(object sender, EventArgs e)
        {
            txtKgPerHour.SelectAll();
        }
    }
}