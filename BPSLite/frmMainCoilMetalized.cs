using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmMainCoilMetalized : Form
    {
        //DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0";
        int codsec = 0, selectCoilProcess = 0, selectCoilPressure = 0, selectCoilDeadTime = 0;
        bool isMaquile = false;

        clsMetallizedOrder ObjMetalizedOrder = new clsMetallizedOrder();
        clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();

        clsProductionOrderMetal objProductionOrderMetal = new clsProductionOrderMetal();
        clsFilmProductionPlanMetal objFilmProductionPlanMetal = new clsFilmProductionPlanMetal();
        clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();


        public frmMainCoilMetalized()
        {
            InitializeComponent();
        }

        public frmMainCoilMetalized(int codsec, string isMaquile)
        {
            InitializeComponent();
            this.codsec = codsec;
            if (isMaquile == "Maquile")
                this.isMaquile = true;
            else
                this.isMaquile = false;
        }

        private void PopulateDeadTImeGroup()
        {
            List<clsMetalizedDeadTime> lstDeadTime = new List<clsMetalizedDeadTime>();
            lstDeadTime = clsMetalizedDeadTime.getList();
            cmbTime.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbTime.Items.Add(lstDeadTime[i]);
        }

        private void frmMetalizedOrderDetail_Load(object sender, EventArgs e)
        {
            PopulateHead(codsec);
            PopulateProcess(codsec);
            PopulatePression(codsec);
            PopulateDeadTime(codsec);
            PopulateDeadTImeGroup();
        }

        private void PopulateHead(int codsec)
        {
            if (codsec != 0)
            {
                objProductionOrderMetal = new clsProductionOrderMetal(codsec);
                lblProductFrom.Text = objProductionOrderMetal.BoppFrom;
                lblProductTo.Text = objProductionOrderMetal.BoppTo;
                lblCustomer.Text = objProductionOrderMetal.Customer;
                lblOrder.Text = objProductionOrderMetal.number.ToString();
                lblLotNumber.Text = objProductionOrderMetal.lotNumber;
                lblStatus.Text = objProductionOrderMetal.Coil.ToString();
                lblImportCoil.Text = clsMainCoilMetal.getTotalMainCoilByFilmProductionPlan(objProductionOrderMetal.codsec).ToString() + " / " + objProductionOrderMetal.Coil.ToString();
                PopulateCoil(objProductionOrderMetal.codsec);
                txtSequential.Text = clsSequential.toSequentialMainCoil().ToString();
            }
        }

        private void PopulateProcess(int codsec)
        {
            objProductionOrderMetal = new clsProductionOrderMetal(codsec);
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            lstMainCoil = clsMainCoilMetal.getListByFilmProductionPlan(objProductionOrderMetal.fkFilmProductionOrderMetal);
            dgvProcess.Rows.Clear();
            if (lstMainCoil.Count > 0)
            {
                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvProcess.Rows.Add();
                    dgvProcess.Rows[i].Cells[clmproccodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvProcess.Rows[i].Cells[clmproccode.Index].Value = lstMainCoil[i].mcode;
                    dgvProcess.Rows[i].Cells[clmproclotnumber.Index].Value = lstMainCoil[i].lotNumber;
                    dgvProcess.Rows[i].Cells[clmprocorigin.Index].Value = lstMainCoil[i].origin;
                    dgvProcess.Rows[i].Cells[clmprocwidth.Index].Value = lstMainCoil[i].width;
                    dgvProcess.Rows[i].Cells[clmprocessadd.Index].Value = global::BPS.Lite.Properties.Resources.bricks;
                    dgvProcess.Rows[i].Cells[clmproclabel.Index].Value = global::BPS.Lite.Properties.Resources.printer;
                    dgvProcess.Rows[i].Cells[clmprocclose.Index].Value = (lstMainCoil[i].fkStatus == 51) ? global::BPS.Lite.Properties.Resources.locktoclose : global::BPS.Lite.Properties.Resources.lock_open;
                }
            }
        }
        public bool ComprobarRegistro(int codsec)
        {
            if (codsec != 0)
                return true;
            else
                return false;
        }
        private void setProcessValues(string destination, int codsec)
        {
            switch (destination)
            {
                case "toUpdate":
                    objMainCoilMetal = new clsMainCoilMetal(codsec);
                    objMainCoilMetal.processValues = getValuesFromControl(grpbProcess, "textBox");
                    objMainCoilMetal.processList = clsGlobal.getStringListFromString(objMainCoilMetal.processValues);
                    objMainCoilMetal.notes = txtObservations.Text;
                    objMainCoilMetal.netlength = Convert.ToDouble(txtlength.Text);
                    objMainCoilMetal.toUpdateProcess();
                    break;
                case "toLoad":
                    if (codsec > 0)
                    {
                        objMainCoilMetal = new clsMainCoilMetal(codsec);
                        setValuesToControl(grpbProcess, "textBoxString", objMainCoilMetal.processValues);
                        txtObservations.Text = objMainCoilMetal.notes;
                        txtlength.Text = Math.Round(objMainCoilMetal.netlength, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void PopulatePression(int codsec)
        {
            objProductionOrderMetal = new clsProductionOrderMetal(codsec);
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            lstMainCoil = clsMainCoilMetal.getListByFilmProductionPlan(objProductionOrderMetal.fkFilmProductionOrderMetal);
            dgvPression.Rows.Clear();
            if (lstMainCoil.Count > 0)
            {
                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvPression.Rows.Add();
                    dgvPression.Rows[i].Cells[clmpressioncodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvPression.Rows[i].Cells[clmpressioncode.Index].Value = lstMainCoil[i].mcode;
                    dgvPression.Rows[i].Cells[clmpressionlot.Index].Value = lstMainCoil[i].lotNumber;
                    dgvPression.Rows[i].Cells[clmpressionorigin.Index].Value = lstMainCoil[i].origin;
                    dgvPression.Rows[i].Cells[clmpressionwidth.Index].Value = lstMainCoil[i].width;
                    dgvPression.Rows[i].Cells[clmpressionadd.Index].Value = global::BPS.Lite.Properties.Resources.bricks;
                }
            }
        }

        private void PopulateDeadTime(int codsec)
        {
            objProductionOrderMetal = new clsProductionOrderMetal(codsec);
            List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
            lstMainCoil = clsMainCoilMetal.getListByFilmProductionPlan(objProductionOrderMetal.fkFilmProductionOrderMetal);
            dgvDeadTimeMainCoil.Rows.Clear();
            if (lstMainCoil.Count > 0)
            {
                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvDeadTimeMainCoil.Rows.Add();
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtcodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtcode.Index].Value = lstMainCoil[i].mcode;
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtlot.Index].Value = lstMainCoil[i].lotNumber;
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtorigin.Index].Value = lstMainCoil[i].origin;
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtwidth.Index].Value = lstMainCoil[i].width;
                    dgvDeadTimeMainCoil.Rows[i].Cells[clmdeadtadd.Index].Value = global::BPS.Lite.Properties.Resources.bricks;
                }
            }
        }

        private void setValuesToControl(System.Windows.Forms.Control container, string controlType, string values)
        {
            List<System.Windows.Forms.TextBox> lstTextBox = new List<TextBox>();
            switch (controlType)
            {
                case "textBox":

                    List<double> lstDoubleValues = clsGlobal.getDoubleListFromString(values);
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            lstTextBox.Add(((TextBox)ctrl));
                    }
                    lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                    for (int i = 0; i < lstTextBox.Count; i++)
                        lstTextBox[i].Text = lstDoubleValues[i].ToString();
                    break;

                case "textBoxString":

                    List<string> lstStringValues = clsGlobal.getStringListFromString(values);
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            lstTextBox.Add(((TextBox)ctrl));
                    }

                    lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                    for (int i = 0; i < lstStringValues.Count; i++)
                        lstTextBox[i].Text = lstStringValues[i].ToString();
                    break;

                case "checkBox":

                    List<System.Windows.Forms.CheckBox> lstCheckBox = new List<CheckBox>();
                    List<bool> lstBoolValues = clsGlobal.getBooleanListFromString(values);

                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                            lstCheckBox.Add(((CheckBox)ctrl));
                    }
                    lstCheckBox.Sort(delegate(CheckBox chk1, CheckBox chk2) { return chk1.TabIndex.CompareTo(chk2.TabIndex); });
                    for (int i = 0; i < lstCheckBox.Count; i++)
                        lstCheckBox[i].Checked = lstBoolValues[i];
                    break;

                default:
                    break;
            }
        }

        private string getValuesFromControl(System.Windows.Forms.Control container, string controlType)
        {
            string result = "";
            switch (controlType)
            {
                case "textBox":

                    List<System.Windows.Forms.TextBox> lstTextBox = new List<TextBox>();
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            lstTextBox.Add(((TextBox)ctrl));
                    }
                    lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                    for (int i = 0; i < lstTextBox.Count; i++)
                        result += lstTextBox[i].Text + ((i < lstTextBox.Count - 1) ? ";" : "");
                    break;

                case "checkBox":

                    List<System.Windows.Forms.CheckBox> lstCheckBox = new List<CheckBox>();
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                            lstCheckBox.Add(((CheckBox)ctrl));
                    }
                    lstCheckBox.Sort(delegate(CheckBox chk1, CheckBox chk2) { return chk1.TabIndex.CompareTo(chk2.TabIndex); });
                    for (int i = 0; i < lstCheckBox.Count; i++)
                        result += lstCheckBox[i].Checked.ToString() + ((i < lstCheckBox.Count - 1) ? ";" : "");
                    break;

                default:
                    break;
            }
            return result;
        }

        private void btnSaveRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateProcess())
                {
                    if (selectCoilProcess != 0)
                    {
                        var metraje = Convert.ToDouble(txtlength.Text);

                        if (metraje < 1000 || metraje > 50000)
                            MessageBox.Show("El valor del metraje no debe ser menor que 1000 o mayor que 50000 y usted ingreso " + metraje.ToString(), "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        else
                        {
                            setProcessValues("toUpdate", selectCoilProcess);
                            MessageBox.Show("Proceso Guardado Correctamente", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            selectCoilProcess = 0;
                        }
                    }
                    else
                        MessageBox.Show("Debe seleccionar una bobina para registrar los valores de proceso y observaciones", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                    MessageBox.Show("Existen varios campos requeridos que no han sido llenados por favor llénelos y vuelva a intentar", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private bool ValidateProcess()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txttempceramic, ref lbltempceramic, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtspeedalumin, ref lblspeedalumin, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txttempi, ref lbltempi, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txttempii, ref lbltempii, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtspeed, ref lblspeed, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtpresioni, ref lblpressioni, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtpressionii, ref lblpressionii, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtpressioniii, ref lblpressioniii, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtceramic, ref lblceramic, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtgrafic, ref lblgrafit, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtlead, ref lbllead, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtbig, ref lblbig, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtsmall, ref lblsmall, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnAddPressure_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePression())
                {
                    if (selectCoilPressure != 0)
                    {
                        clsMetalizedPressure ObjPressure = new clsMetalizedPressure();
                        ObjPressure.Ingress = Convert.ToDouble(txtingress.Text);
                        ObjPressure.Return = Convert.ToDouble(txtreturn.Text);
                        ObjPressure.Down = Convert.ToDouble(txtdown.Text);
                        ObjPressure.Oil = Convert.ToDouble(txtoil.Text);
                        ObjPressure.Up = Convert.ToDouble(txtup.Text);
                        ObjPressure.fkOrder = selectCoilPressure;
                        if (ObjPressure.save())
                        {
                            if (MessageBox.Show("Presión Guardada Correctamente\r\nDesea generar una nueva presión?", "Proceso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                ClearPressure();
                                PopulateAfterSavePressure(selectCoilPressure);
                                txtingress.Focus();
                            }
                            else
                            {
                                ClearPressure();
                                PopulateAfterSavePressure(selectCoilPressure);
                                selectCoilPressure = 0;
                                lblMainCoilCodePression.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("Debe seleccionar una bobina para registrar los valores de proceso y observaciones", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                    MessageBox.Show("Existen varios campos requeridos que no han sido llenados por favor llénelos y vuelva a intentar", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void PopulateAfterSavePressure(int selectCoilPressure)
        {
            List<clsMetalizedPressure> lstPression = new List<clsMetalizedPressure>();
            lstPression = clsMetalizedPressure.getListByMainCoilMetal(selectCoilPressure);
            dgvPressure.Rows.Clear();
            if (lstPression.Count > 0)
            {
                for (int i = 0; i < lstPression.Count; i++)
                {
                    dgvPressure.Rows.Add();
                    dgvPressure.Rows[i].Cells[clmpressurecodsec.Index].Value = lstPression[i].codsec;
                    dgvPressure.Rows[i].Cells[clmpressuredelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    dgvPressure.Rows[i].Cells[clmpressuredown.Index].Value = lstPression[i].Down;
                    dgvPressure.Rows[i].Cells[clmpressurefkorder.Index].Value = lstPression[i].fkOrder;
                    dgvPressure.Rows[i].Cells[clmpressureingress.Index].Value = lstPression[i].Ingress;
                    dgvPressure.Rows[i].Cells[clmpressuremaincoil.Index].Value = lstPression[i].MainCoilMetal.mcode;
                    dgvPressure.Rows[i].Cells[clmpressureoil.Index].Value = lstPression[i].Oil;
                    dgvPressure.Rows[i].Cells[clmpressurereturn.Index].Value = lstPression[i].Return;
                    dgvPressure.Rows[i].Cells[clmpressureup.Index].Value = lstPression[i].Up;
                }
            }
        }

        private void PopulateAfterSaveDeadTime(int selectCoilDeadTime)
        {
            List<clsMetalizedDeadTimeValues> lstDeadTime = new List<clsMetalizedDeadTimeValues>();
            lstDeadTime = clsMetalizedDeadTimeValues.getListByMainCoilMetal(objMainCoilMetal.codsec);
            dgvDeadTime.Rows.Clear();
            if (lstDeadTime.Count > 0)
            {
                for (int i = 0; i < lstDeadTime.Count; i++)
                {
                    dgvDeadTime.Rows.Add();
                    dgvDeadTime.Rows[i].Cells[clmdeadtimecodsec.Index].Value = lstDeadTime[i].codsec;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimedelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimeend.Index].Value = lstDeadTime[i].EndDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadtimefkorder.Index].Value = lstDeadTime[i].fkOrder;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimegroup.Index].Value = lstDeadTime[i].DeadTime.deadTimeGroupName;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimeinit.Index].Value = lstDeadTime[i].InitDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadtimemaincoil.Index].Value = lstDeadTime[i].MainCoilMetal.mcode;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimename.Index].Value = lstDeadTime[i].DeadTime.deadTimeName;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimetotal.Index].Value = lstDeadTime[i].TotalDeadTimeMinutes;
                }
            }
        }

        private void ClearPressure()
        {
            txtingress.Clear();
            txtreturn.Clear();
            txtdown.Clear();
            txtoil.Clear();
            txtup.Clear();
        }

        private bool ValidatePression()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtingress, ref lblingress, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtreturn, ref lblreturn, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtdown, ref lbldown, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtoil, ref lbloil, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtup, ref lblup, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnAddDeadTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDeadTime())
                {
                    if (selectCoilDeadTime != 0)
                    {
                        if (dtpInit.Value.CompareTo(dtpEnd.Value) < 0)
                        {
                            clsMetalizedDeadTimeValues ObjDeadTime = new clsMetalizedDeadTimeValues();
                            ObjDeadTime.fkOrder = selectCoilDeadTime;
                            ObjDeadTime.fkDeadTime = ((clsMetalizedDeadTime)cmbTime.SelectedItem).codsec;
                            ObjDeadTime.InitDate = dtpInit.Value;
                            ObjDeadTime.EndDate = dtpEnd.Value;
                            ObjDeadTime.TotalDeadTimeMinutes = GetMinutesTime(dtpInit.Value, dtpEnd.Value);
                            if (ObjDeadTime.save())
                            {
                                if (MessageBox.Show("Tiempo Muerto Guardado Correctamente\r\nDesea generar un nuevo tiempo muerto?", "Tiempos Muertos - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                {
                                    ClearDeadTime();
                                    PopulateAfterSaveDeadTime(selectCoilDeadTime);
                                    cmbTime.Focus();
                                }
                                else
                                {
                                    ClearDeadTime();
                                    PopulateAfterSaveDeadTime(selectCoilDeadTime);
                                    selectCoilDeadTime = 0;
                                    lblMainCoilDeadT.Text = "";
                                }
                            }
                            else
                                MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Tiempos Muertos - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else if (dtpInit.Value.CompareTo(dtpEnd.Value) == 0)
                            MessageBox.Show("Las fechas de los tiempos muertos no pueden ser iguales por favor cambie las fechas", "Tiempos muertos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        else if (dtpInit.Value.CompareTo(dtpEnd.Value) > 0)
                            MessageBox.Show("La fecha inicio del tiempo muerto no pueden ser mayor que la fecha fin del tiempo muerto", "Tiempos muertos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("Debe seleccionar una bobina para registrar los valores de proceso y observaciones", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                    MessageBox.Show("Existen varios campos requeridos que no han sido llenados por favor llénelos y vuelva a intentar", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tiempos Muertos - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void ClearDeadTime()
        {
            cmbTime.Text = "";
            cmbTime.SelectedIndex = -1;
            cmbTime.SelectedItem = -1;
            cmbTime.SelectedText = "";
            PopulateDeadTImeGroup();
            dtpInit.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        private double GetMinutesTime(DateTime dtpinit, DateTime dtpend)
        {
            var time = dtpinit.Subtract(dtpend).Minutes;
            return Math.Abs(time);
        }

        private bool ValidateDeadTime()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbTime, ref lblTime, "selected")) isValid = false;

            return isValid;
        }

        private void dgvPressure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmpressuredelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar la presión selecciona?", "Presión - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsMetalizedPressure.toDelete(Convert.ToInt32(dgvPressure.Rows[e.RowIndex].Cells[clmpressurecodsec.Index].Value)))
                        {
                            MessageBox.Show("Presión eliminada correctamente", "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateAfterSavePressure(Convert.ToInt32(dgvPressure.Rows[e.RowIndex].Cells[clmpressurefkorder.Index].Value));
                        }
                        else
                            MessageBox.Show("La información no ha podido ser eliminada por favor verifique la información en los campos", "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        PopulateAfterSavePressure(Convert.ToInt32(dgvPressure.Rows[e.RowIndex].Cells[clmpressurefkorder.Index].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvDeadTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmdeadtimedelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar el tiempo muerto seleccionado?", "Tiempo Muerto - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsMetalizedDeadTime.toDelete(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadtimecodsec.Index].Value)))
                        {
                            MessageBox.Show("Tiempo Muerto eliminado correctamente", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateAfterSaveDeadTime(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadtimefkorder.Index].Value));
                        }
                        else
                            MessageBox.Show("La información no ha podido ser eliminada por favor verifique la información en los campos", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        PopulateAfterSaveDeadTime(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadtimefkorder.Index].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnPauseOrder_Click(object sender, EventArgs e)
        {

            try
            {
                bool isValid = true;
                if (MessageBox.Show("Esta realmente seguro que desea CERRAR la orden de Metalizado?\r\n Recuerde que una vez que la orden sea cerrada no se podrá adicionar nada mas", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    objProductionOrderMetal = new clsProductionOrderMetal(codsec);
                    if (objProductionOrderMetal.toCloseOrder())
                    {
                        for (int i = 0; i < dgvBaseCoil.Rows.Count; i++)
                        {
                            clsCoil objCoil = clsCoil.getDetailByCode(dgvBaseCoil.Rows[i].Cells[clmbasecode.Index].Value.ToString());
                            objCoil.fkStatus = 35;
                            if (!objCoil.toChangeStatus(35))
                            {
                                if (!clsCoil.IsInPallet(objCoil.codsec))
                                {
                                    if (!clsCoil.removeCoilToPallet(objCoil.codsec))
                                    {
                                        isValid = false;
                                        break;
                                    }
                                }
                            }
                        }

                        if (isValid)
                        {
                            MessageBox.Show("Orden de Metalizado, cerrada con éxito!", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            this.Close();
                        }
                        else
                            MessageBox.Show("No se pudo cerrar la orden ERROR en bobinas base cambio de estado a eliminado", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("La información no ha podido ser procesada!, debido a que existe un error al momento de cerrar la orden de metalizado", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cerrar - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }

            //if (MessageBox.Show("Esta realmente seguro que desea CERRAR la orden de Metalizado, Recuerde que ya no podrá adicionar datos?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
            //{
            //    if (clsProductionOrderMetal.toPauseOrder(codsec))
            //    {
            //        MessageBox.Show("Orden de Metalizado CERRADA Correctamente");
            //        this.Close();
            //    }
            //    else
            //        MessageBox.Show("La orden no ha podido ser cerrada por favor vuelva a intentarlo", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}
        }

        private void btnWeigth_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectCoilProcess != 0)
                {
                    frmMainCoilWegith winWiegth = new frmMainCoilWegith(selectCoilProcess);
                    winWiegth.StartPosition = FormStartPosition.CenterScreen;
                    winWiegth.ShowDialog(this.MdiParent);
                    PopulateAfterWeigth(selectCoilProcess);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una bobina para registrar los valores de proceso y observaciones", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void PopulateAfterWeigth(int selectCoilProcess)
        {
            try
            {
                objMainCoilMetal = new clsMainCoilMetal(selectCoilProcess);
                lblMetalizedCode.Text = objMainCoilMetal.mcode;
                lblMetalizedGrossWeigth.Text = Math.Round(objMainCoilMetal.grossWeigth, 1, MidpointRounding.AwayFromZero).ToString();
                lblNetWeigth.Text = Math.Round(objMainCoilMetal.netWeigth, 1, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnCloseMetalizedOrder_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                if (MessageBox.Show("Esta realmente seguro que desea CERRAR la orden de Metalizado?\r\n Recuerde que una vez que la orden sea cerrada no se podrá adicionar nada mas", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    objProductionOrderMetal = new clsProductionOrderMetal(codsec);
                    if (objProductionOrderMetal.toCloseOrder())
                    {
                        for (int i = 0; i < dgvBaseCoil.Rows.Count; i++)
                        {
                            clsCoil objCoil = clsCoil.getDetailByCode(dgvBaseCoil.Rows[i].Cells[clmbasecode.Index].Value.ToString());
                            objCoil.fkStatus = 35;
                            if (!objCoil.toChangeStatus(35))
                            {
                                if (!clsCoil.IsInPallet(objCoil.codsec))
                                {
                                    if (!clsCoil.removeCoilToPallet(objCoil.codsec))
                                    {
                                        isValid = false;
                                        break;
                                    }
                                }
                            }
                        }

                        if (isValid)
                        {
                            MessageBox.Show("Orden de Metalizado, cerrada con éxito!", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            this.Close();
                        }
                        else
                            MessageBox.Show("No se pudo cerrar la orden ERROR en bobinas base cambio de estado a eliminado", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("La información no ha podido ser procesada!, debido a que existe un error al momento de cerrar la orden de metalizado", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cerrar - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void txtCoil_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (ValidateCoil())
                    {
                        objProductionOrderMetal = new clsProductionOrderMetal(codsec);

                        if (clsMainCoilMetal.getTotalMainCoilByFilmProductionPlan(codsec) < objProductionOrderMetal.Coil)
                        {
                            clsCoil ObjCoil = new clsCoil();
                            ObjCoil = clsCoil.getDetailByCode(txtCoil.Text);
                            lblProductFromCoil.Text = ObjCoil.ProductCode;
                            lblWidth.Text = ObjCoil.width.ToString();
                            lblWeigth.Text = Math.Round(ObjCoil.netWeight, 2).ToString();
                            lblOrigin.Text = (ObjCoil.isExternalCoil == true) ? "OPP" : "BOPP";
                            txtSequential.Text = clsSequential.toSequentialMainCoil().ToString();
                            //txtpos.Text = ObjCoil.cuttingPosition.ToString();

                            if (ObjCoil.codsec > 0)
                            {
                                if (ObjCoil.fkStatus == 33 || ObjCoil.fkStatus == 34)
                                {
                                    if (ObjCoil.coilCellarContainer.codsec == 0 || ObjCoil.coilCellarContainer.codsec == 11 || ObjCoil.coilCellarContainer.codsec == 3012 || ObjCoil.coilCellarContainer.codsec == 2011 || ObjCoil.coilCellarContainer.codsec == 4014 || ObjCoil.coilCellarContainer.codsec == 4015 || ObjCoil.coilCellarContainer.codsec == 4017)
                                    {
                                        if (ObjCoil.fkBopp == objProductionOrderMetal.fkBopp)
                                        {
                                            clsProduct objProduct = new clsProduct();
                                            objProduct.load(ObjCoil.fkProduct);
                                            if (clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.Bopp.codsec, objProduct.code) > 0)
                                            {
                                                clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();
                                                objMainCoilMetal.fkBoppFrom = objProductionOrderMetal.fkBopp;
                                                objMainCoilMetal.fkProductFrom = ObjCoil.fkProduct;
                                                objMainCoilMetal.fkBoppTo = objProductionOrderMetal.fkBoppTo;
                                                objMainCoilMetal.fkProductTo = clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.Bopp.codsec, objProduct.code);
                                                objMainCoilMetal.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "En proceso").codsec;
                                                objMainCoilMetal.fkFilmProductionPlan = objProductionOrderMetal.fkFilmProductionOrderMetal;
                                                objMainCoilMetal.mcode = GenerteCode(Convert.ToInt32(txtpos.Text), ObjCoil.isExternalCoil, isMaquile);
                                                objMainCoilMetal.bcode = ObjCoil.code.ToString();
                                                objMainCoilMetal.lotNumber = objProductionOrderMetal.lotNumber;
                                                objMainCoilMetal.usedLength = ObjCoil.length;
                                                objMainCoilMetal.grossWeigth = 0;
                                                objMainCoilMetal.netWeigth = 0;
                                                objMainCoilMetal.width = Convert.ToInt32(ObjCoil.width);
                                                objMainCoilMetal.diameter = ObjCoil.diameter;
                                                objMainCoilMetal.density = ObjCoil.density;
                                                objMainCoilMetal.cuttingPosition = Convert.ToInt32(txtpos.Text);
                                                objMainCoilMetal.cuttingStop = 0;
                                                objMainCoilMetal.notes = "";
                                                objMainCoilMetal.origin = (ObjCoil.isExternalCoil == true) ? "OPP" : "BOPP";
                                                objMainCoilMetal.isMaquile = isMaquile;
                                                objMainCoilMetal.labRating = "";
                                                objMainCoilMetal.analistRating = "";
                                                objMainCoilMetal.fkorigin = ObjCoil.codsec;
                                                objMainCoilMetal.maincode = ObjCoil.mainCoilCode;
                                                objMainCoilMetal.processValues = "0;0;0;0;0;0;0;0;0;0;0;0;0";
                                                objMainCoilMetal.OriginWeigth = ObjCoil.netWeight;
                                                objMainCoilMetal.decrease = 0;
                                                if (objMainCoilMetal.save())
                                                {
                                                    MessageBox.Show("Bobina agregada Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                                    //actualMainCoilSquential = Convert.ToInt32(objMainCoilMetal.mcode.Substring(2, 3));
                                                    PopulateCoil(objProductionOrderMetal.codsec);
                                                    PopulateProcess(objProductionOrderMetal.codsec);
                                                    PopulatePression(objProductionOrderMetal.codsec);
                                                    PopulateDeadTime(objProductionOrderMetal.codsec);
                                                    txtCoil.Focus();
                                                    ObjCoil.toChangeStatus(35);
                                                    if (clsCoil.IsInPallet(ObjCoil.codsec))
                                                    {
                                                        clsPallet objPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(ObjCoil.codsec));
                                                        objPallet.deletePalletforMet();
                                                    }
                                                    
                                                }
                                                else
                                                    MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Equivalencia en Metalizado no encontrada debe crear el producto " + ObjCoil.ProductCode.Replace("B", "M").Replace("g", "") + "\r\n Por favor ingrese el material a metalizar", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                                frmProductsForm winProductForm = new frmProductsForm();
                                                winProductForm.StartPosition = FormStartPosition.CenterScreen;
                                                winProductForm.ShowDialog(this);
                                                txtCoil.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La base ingresada no corresponde al de la Orden de Metalizado\r\n Por favor ingrese una base válida, se ingreso un " + ObjCoil.ProductCode + " y la orden es " + objProductionOrderMetal.BoppFrom, "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                            txtCoil.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se puede ingresar la bobina ya que se encuentra en bodega de " + ObjCoil.Coil_CoilCellarContainer.name.ToUpper() + " y debe encontrarse en bodega de PROCESO\r\n Solicite a Bodega que liberen dicho material", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        txtCoil.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La bobina ingresada no esta activa, ya que está como " + ObjCoil.statusName + "\r\nPor favor solicite en Corte que asignen la bobina como ACTIVA", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    txtCoil.Focus();
                                }
                            }
                            else if (clsMaquile.isExistCoil(txtCoil.Text))
                            {
                                clsMaquile objMaquile = new clsMaquile();
                                objMaquile.load(txtCoil.Text);
                                lblProductFromCoil.Text = objMaquile.ProductFrom.code;
                                lblWidth.Text = objMaquile.width.ToString();
                                lblWeigth.Text = Math.Round(objMaquile.weigth, 2).ToString();
                                lblOrigin.Text = "Maquila";
                                //txtpos.Text = "7";
                                if (objMaquile.ProductFrom.fkBopp == objProductionOrderMetal.fkBopp)
                                {
                                    clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();
                                    objMainCoilMetal.fkBoppFrom = objProductionOrderMetal.fkBopp;
                                    objMainCoilMetal.fkProductFrom = objMaquile.fkProductFrom;
                                    objMainCoilMetal.fkBoppTo = objProductionOrderMetal.fkBoppTo;
                                    objMainCoilMetal.fkProductTo = objMaquile.fkProductTo;
                                    objMainCoilMetal.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas Madre", "En proceso").codsec;
                                    objMainCoilMetal.fkFilmProductionPlan = objProductionOrderMetal.fkFilmProductionOrderMetal;
                                    objMainCoilMetal.mcode = GenerteCode(Convert.ToInt32(txtpos.Text), true, isMaquile);
                                    objMainCoilMetal.bcode = "";
                                    objMainCoilMetal.lotNumber = objProductionOrderMetal.lotNumber;
                                    objMainCoilMetal.usedLength = 0;
                                    objMainCoilMetal.grossWeigth = 0;
                                    objMainCoilMetal.netWeigth = 0;
                                    objMainCoilMetal.width = Convert.ToInt32(objMaquile.width);
                                    objMainCoilMetal.diameter = 0;
                                    objMainCoilMetal.density = 0;
                                    objMainCoilMetal.cuttingPosition = Convert.ToInt32(txtpos.Text);
                                    objMainCoilMetal.cuttingStop = 0;
                                    objMainCoilMetal.notes = "";
                                    objMainCoilMetal.origin = "Maquila";
                                    objMainCoilMetal.isMaquile = isMaquile;
                                    objMainCoilMetal.labRating = "";
                                    objMainCoilMetal.analistRating = "";
                                    objMainCoilMetal.fkorigin = objMaquile.codsec;
                                    objMainCoilMetal.maincode = "EXT-COD";
                                    objMainCoilMetal.processValues = "0;0;0;0;0;0;0;0;0;0;0;0;0";
                                    objMainCoilMetal.OriginWeigth = objMaquile.weigth;
                                    objMainCoilMetal.decrease = 0;
                                    if (objMainCoilMetal.save())
                                    {
                                        MessageBox.Show("Bobina agregada Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        PopulateCoil(objProductionOrderMetal.codsec);
                                        PopulateProcess(objProductionOrderMetal.codsec);
                                        PopulatePression(objProductionOrderMetal.codsec);
                                        PopulateDeadTime(objProductionOrderMetal.codsec);
                                        txtCoil.Focus();
                                    }
                                    else
                                        MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar un Maquila igual al de la orden la orden es " + objProductionOrderMetal.BoppFrom + " y usted está ingresando una maquila " + objMaquile.ProductFrom.boppCode + "\r\n Por favor ingrese el material a metalizar", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    txtCoil.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Código ingresado es erróneo por favor vuelva a ingresar el código correcto", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoil.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sea ingresado el total de bobinas programadas\r\n Por favor verifique que las bobinas ingresadas sea las correctas", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoil.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de la posición debe ser mayor que 0, cambie el valor para poder registrar las bobinas", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoil.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bobina - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void PopulateCoil(int codsec)
        {
            try
            {
                txtSequential.Text = clsSequential.toSequentialMainCoil().ToString();
                objProductionOrderMetal = new clsProductionOrderMetal(codsec);
                lblImportCoil.Text = clsMainCoilMetal.getTotalMainCoilByFilmProductionPlan(objProductionOrderMetal.codsec).ToString() + " / " + objProductionOrderMetal.Coil.ToString();
                List<clsMainCoilMetal> lstMainCoil = new List<clsMainCoilMetal>();
                lstMainCoil = clsMainCoilMetal.getListByFilmProductionPlan(objProductionOrderMetal.fkFilmProductionOrderMetal);
                dgvBaseCoil.Rows.Clear();
                if (lstMainCoil.Count > 0)
                {
                    for (int i = 0; i < lstMainCoil.Count; i++)
                    {
                        clsBaseCoilProductionDetail objBaseCoilProductionDetail = new clsBaseCoilProductionDetail();
                        clsCoil maincoil = new clsCoil();
                        if (!lstMainCoil[i].isMaquile)
                        {
                            clsCoil objCoil = new clsCoil();
                            objCoil.load(lstMainCoil[i].fkorigin);
                            dgvBaseCoil.Rows.Add();
                            dgvBaseCoil.Rows[i].Cells[clmbasecode.Index].Value = objCoil.code;
                            dgvBaseCoil.Rows[i].Cells[clmbasecodsec.Index].Value = lstMainCoil[i].codsec;
                            dgvBaseCoil.Rows[i].Cells[clmbasedelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            dgvBaseCoil.Rows[i].Cells[clmbasefkcodsec.Index].Value = lstMainCoil[i].fkorigin;
                            dgvBaseCoil.Rows[i].Cells[clmbasegrossweigth.Index].Value = Math.Round(objCoil.grossWeight, 2);
                            dgvBaseCoil.Rows[i].Cells[clmbasenetweigth.Index].Value = Math.Round(objCoil.netWeight, 2);
                            dgvBaseCoil.Rows[i].Cells[clmbaseorigin.Index].Value = lstMainCoil[i].origin;
                            dgvBaseCoil.Rows[i].Cells[clmbaseproduct.Index].Value = objCoil.ProductCode;
                            dgvBaseCoil.Rows[i].Cells[clmbasepos.Index].Value = lstMainCoil[i].cuttingPosition;
                            dgvBaseCoil.Rows[i].Cells[clmbasemetalcode.Index].Value = lstMainCoil[i].mcode;
                            objBaseCoilProductionDetail.load(Convert.ToInt32(dgvBaseCoil.Rows[i].Cells[clmbasefkcodsec.Index].Value));
                            if (ComprobarRegistro(objBaseCoilProductionDetail.codsec))
                                dgvBaseCoil.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                        else
                        {
                            clsMaquile objMaquile = new clsMaquile();
                            objMaquile.load(lstMainCoil[i].fkorigin);
                            dgvBaseCoil.Rows.Add();
                            dgvBaseCoil.Rows[i].Cells[clmbasecode.Index].Value = objMaquile.code;
                            dgvBaseCoil.Rows[i].Cells[clmbasecodsec.Index].Value = lstMainCoil[i].codsec;
                            dgvBaseCoil.Rows[i].Cells[clmbasedelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            dgvBaseCoil.Rows[i].Cells[clmbasefkcodsec.Index].Value = lstMainCoil[i].fkorigin;
                            dgvBaseCoil.Rows[i].Cells[clmbasegrossweigth.Index].Value = Math.Round(objMaquile.weigth, 2);
                            dgvBaseCoil.Rows[i].Cells[clmbasenetweigth.Index].Value = Math.Round(objMaquile.weigth, 2);
                            dgvBaseCoil.Rows[i].Cells[clmbaseorigin.Index].Value = lstMainCoil[i].origin;
                            dgvBaseCoil.Rows[i].Cells[clmbaseproduct.Index].Value = lstMainCoil[i].ProductFromCode;
                            dgvBaseCoil.Rows[i].Cells[clmbasepos.Index].Value = lstMainCoil[i].cuttingPosition;
                            dgvBaseCoil.Rows[i].Cells[clmbasemetalcode.Index].Value = lstMainCoil[i].mcode;
                        }

                    }
                }

                txtCoil.Clear();
                txtCoil.Focus();
                txtpos.Text = "0";
                lblProductFromCoil.Text = "";
                lblWidth.Text = "";
                lblWeigth.Text = "0";
                lblOrigin.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateCoil()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtpos, ref label5, "moreThan0")) isValid = false;
            return isValid;
        }

        private string GenerteCode(int position, bool isExternalCoil, bool isMaquile)
        {
            try
            {
                if (isExternalCoil && !isMaquile)
                    return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "M" + clsGlobal.FillWithZeros(((new clsSequential().mainCoilMetal).ToString()), 4);
                else if (isExternalCoil && isMaquile)
                    return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "M" + clsGlobal.FillWithZeros(((new clsSequential().mainCoilMetal).ToString()), 4);
                else
                    return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "M" + clsGlobal.FillWithZeros(((new clsSequential().mainCoilMetal).ToString()), 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                return "";
            }
        }

        private void txtingress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtreturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtoil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void printMetalizedLabel(int mainCoilMetal)
        {
            try
            {
                objMainCoilMetal = new clsMainCoilMetal(mainCoilMetal);

                rptMetalizedCoilPL rptPalletLabel = new rptMetalizedCoilPL();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = objMainCoilMetal.codsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "codsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bobina - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void txtpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvBaseCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmbasedelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar la bobina seleccionada?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsMainCoilMetal.toCheckData(Convert.ToInt32(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasecodsec.Index].Value)) == "OK")
                        {
                            var productionOrderCodsec = clsMainCoilMetal.getProductionOrderByMainCoil(Convert.ToInt32(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasecodsec.Index].Value));

                            if (clsMainCoilMetal.toCrossCoilDelete(Convert.ToInt32(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasecodsec.Index].Value)))
                            {
                                clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasefkcodsec.Index].Value));
                                objCoil.toChangeStatus(33);
                                MessageBox.Show("Bobina eliminado con éxito!", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateCoil(productionOrderCodsec);
                                PopulateProcess(productionOrderCodsec);
                                PopulatePression(productionOrderCodsec);
                                PopulateDeadTime(productionOrderCodsec);
                                
                            }
                            else
                                MessageBox.Show("La bobina no ha podido ser eliminada!", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar la bobina seleccionada ya que existen datos asignados a esa orden en Presión y/o Tiempos Muertos", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvProcess_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value) >= 0)
            {
                objMainCoilMetal = new clsMainCoilMetal(Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value));
                lblMetalizedCode.Text = objMainCoilMetal.mcode;
                lblMetalizedWidth.Text = objMainCoilMetal.width.ToString();
                lblMetalizedGrossWeigth.Text = Math.Round(objMainCoilMetal.grossWeigth, 1, MidpointRounding.AwayFromZero).ToString();
                lblNetWeigth.Text = Math.Round(objMainCoilMetal.netWeigth, 1, MidpointRounding.AwayFromZero).ToString();
                setProcessValues("toLoad", objMainCoilMetal.codsec);
                selectCoilProcess = objMainCoilMetal.codsec;
            }
        }

        private void dgvProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmprocessadd.Index)
            {
                if (Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value) >= 0)
                {
                    objMainCoilMetal = new clsMainCoilMetal(Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value));
                    lblMetalizedCode.Text = objMainCoilMetal.mcode;
                    lblMetalizedWidth.Text = objMainCoilMetal.width.ToString();
                    lblMetalizedGrossWeigth.Text = Math.Round(objMainCoilMetal.grossWeigth, 1, MidpointRounding.AwayFromZero).ToString();
                    lblNetWeigth.Text = Math.Round(objMainCoilMetal.netWeigth, 1, MidpointRounding.AwayFromZero).ToString();
                    setProcessValues("toLoad", objMainCoilMetal.codsec);
                    selectCoilProcess = objMainCoilMetal.codsec;
                }
            }
            if (e.ColumnIndex == clmproclabel.Index)
            {
                if (MessageBox.Show("Desea imprimir la etiqueta", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    printMetalizedLabel(Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value));
            }
            if (e.ColumnIndex == clmprocclose.Index)
            {
                if (Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value) >= 0)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea cerrar la bobina seleccionada?\r\n Recuerde que una vez que la bobina sea cerrar no podrá adicionar mas datos a la misma?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        objMainCoilMetal = new clsMainCoilMetal(Convert.ToInt32(dgvProcess.Rows[e.RowIndex].Cells[clmproccodsec.Index].Value));
                        if (objMainCoilMetal.toCloseCoil())
                        {
                            MessageBox.Show("Bobina cerrada correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            dgvProcess.Rows[e.RowIndex].Cells[clmprocclose.Index].Value = global::BPS.Lite.Properties.Resources.locktoclose;
                        }
                    }
                }
            }
        }

        private void dgvDeadTimeMainCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmpressionadd.Index)
            {
                if (Convert.ToInt32(dgvDeadTimeMainCoil.Rows[e.RowIndex].Cells[clmdeadtcodsec.Index].Value) >= 0)
                {
                    objMainCoilMetal = new clsMainCoilMetal(Convert.ToInt32(dgvDeadTimeMainCoil.Rows[e.RowIndex].Cells[clmdeadtcodsec.Index].Value));
                    lblMainCoilDeadT.Text = objMainCoilMetal.mcode;
                    selectCoilDeadTime = objMainCoilMetal.codsec;
                    List<clsMetalizedDeadTimeValues> lstDeadTime = new List<clsMetalizedDeadTimeValues>();
                    lstDeadTime = clsMetalizedDeadTimeValues.getListByMainCoilMetal(objMainCoilMetal.codsec);
                    dgvDeadTime.Rows.Clear();
                    if (lstDeadTime.Count > 0)
                    {
                        for (int i = 0; i < lstDeadTime.Count; i++)
                        {
                            dgvDeadTime.Rows.Add();
                            dgvDeadTime.Rows[i].Cells[clmdeadtimecodsec.Index].Value = lstDeadTime[i].codsec;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimedelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimeend.Index].Value = lstDeadTime[i].EndDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvDeadTime.Rows[i].Cells[clmdeadtimefkorder.Index].Value = lstDeadTime[i].fkOrder;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimegroup.Index].Value = lstDeadTime[i].DeadTime.deadTimeGroupName;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimeinit.Index].Value = lstDeadTime[i].InitDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvDeadTime.Rows[i].Cells[clmdeadtimemaincoil.Index].Value = lstDeadTime[i].MainCoilMetal.mcode;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimename.Index].Value = lstDeadTime[i].DeadTime.deadTimeName;
                            dgvDeadTime.Rows[i].Cells[clmdeadtimetotal.Index].Value = lstDeadTime[i].TotalDeadTimeMinutes;
                        }
                    }
                }
            }
        }

        private void txtceramic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtgrafic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtlead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtsmall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvPression_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmpressionadd.Index)
            {
                if (Convert.ToInt32(dgvPression.Rows[e.RowIndex].Cells[clmpressioncodsec.Index].Value) >= 0)
                {
                    objMainCoilMetal = new clsMainCoilMetal(Convert.ToInt32(dgvPression.Rows[e.RowIndex].Cells[clmpressioncodsec.Index].Value));
                    lblMainCoilCodePression.Text = objMainCoilMetal.mcode;
                    selectCoilPressure = objMainCoilMetal.codsec;
                    List<clsMetalizedPressure> lstPression = new List<clsMetalizedPressure>();
                    lstPression = clsMetalizedPressure.getListByMainCoilMetal(objMainCoilMetal.codsec);
                    dgvPressure.Rows.Clear();
                    if (lstPression.Count > 0)
                    {
                        for (int i = 0; i < lstPression.Count; i++)
                        {
                            dgvPressure.Rows.Add();
                            dgvPressure.Rows[i].Cells[clmpressurecodsec.Index].Value = lstPression[i].codsec;
                            dgvPressure.Rows[i].Cells[clmpressuredelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            dgvPressure.Rows[i].Cells[clmpressuredown.Index].Value = lstPression[i].Down;
                            dgvPressure.Rows[i].Cells[clmpressurefkorder.Index].Value = lstPression[i].fkOrder;
                            dgvPressure.Rows[i].Cells[clmpressureingress.Index].Value = lstPression[i].Ingress;
                            dgvPressure.Rows[i].Cells[clmpressuremaincoil.Index].Value = lstPression[i].MainCoilMetal.mcode;
                            dgvPressure.Rows[i].Cells[clmpressureoil.Index].Value = lstPression[i].Oil;
                            dgvPressure.Rows[i].Cells[clmpressurereturn.Index].Value = lstPression[i].Return;
                            dgvPressure.Rows[i].Cells[clmpressureup.Index].Value = lstPression[i].Up;
                        }
                    }
                }
            }
        }

        private void txtSequential_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
                {
                    if (txtSequential.Text.Length > 0)
                    {
                        if (MessageBox.Show("Esta realmente seguro que desea modificar el secuencial de las bobinas metalizadas?\r\n Recuerde que el cambio significa que la bobina siguiente metalizada será " + txtSequential.Text, "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            if (clsSequential.updateSequential(Convert.ToInt32(txtSequential.Text)))
                            {
                                MessageBox.Show("Secuencial Modificado Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoil.Focus();
                            }
                            else
                            {
                                MessageBox.Show("La información no ha podido ser actualizada", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoil.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe tener al menos un valor para poder actualizar el secuencial", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoil.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void txtSequential_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvBaseCoil_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmbasecode.Index)
            {
                frmOperativeConditionsMetalized opMetal = new frmOperativeConditionsMetalized(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasefkcodsec.Index].Value.ToString(), dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasemetalcode.Index].Value.ToString());
                //opMetal.MdiParent = this.MdiParent;
                opMetal.StartPosition = FormStartPosition.CenterScreen;
                opMetal.ShowDialog();
            }
            clsBaseCoilProductionDetail objBaseCoilProductionDetail = new clsBaseCoilProductionDetail();
            objBaseCoilProductionDetail.load(Convert.ToInt32(dgvBaseCoil.Rows[e.RowIndex].Cells[clmbasefkcodsec.Index].Value));
            if (ComprobarRegistro(objBaseCoilProductionDetail.codsec))
                dgvBaseCoil.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
        }


    }
}
