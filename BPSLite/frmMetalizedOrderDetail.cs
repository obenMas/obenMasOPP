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
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;

namespace BPS.Lite
{
    public partial class frmMetalizedOrderDetail : Form
    {
        //DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0";
        int codsec = 0;
        bool isMaquile = false;

        clsMetallizedOrder ObjMetalizedOrder = new clsMetallizedOrder();
        clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();

        public frmMetalizedOrderDetail()
        {
            InitializeComponent();
        }

        public frmMetalizedOrderDetail(int codsec, string isMaquile)
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
            PopulateProcess(codsec, isMaquile);
            PopulatePression(codsec);
            PopulateDeadTime(codsec);
            PopulateDeadTImeGroup();
        }

        private void PopulateHead(int codsec)
        {
            if (codsec != 0)
            {
                ObjMetalizedOrder = new clsMetallizedOrder(codsec, true);
                lblProductFrom.Text = ObjMetalizedOrder.productFromName;
                lblProductTo.Text = ObjMetalizedOrder.productToName;
                lblCustomer.Text = ObjMetalizedOrder.customerto;
                lblOrder.Text = ObjMetalizedOrder.number;
                lblLotNumber.Text = ObjMetalizedOrder.lotnumber;
                lblStatus.Text = ObjMetalizedOrder.StatusName;
            }
        }

        private void PopulateProcess(int codsec, bool isMaquile)
        {
            clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();
            ObjMetalizedOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
            clsCoil ObjCoil = new clsCoil ();
            clsMaquile objMaquile = new clsMaquile();

            if (isMaquile)
            {
                if (ObjMetalizedOrderDetail.codsec > 0)
                {
                    //Maquile Data ObjOrderDetail.fkproductFrom
                    objMaquile.load(ObjMetalizedOrderDetail.fkproductFrom);
                    txtCoil.Text = objMaquile.code;
                    lblCoilProdut.Text = clsProduct.getMaquileProductFrom(objMaquile.fkProductFrom).ToString();
                    lblCoilWidth.Text = Convert.ToInt32(objMaquile.width).ToString();
                    lblCoilWeigth.Text = Math.Round(objMaquile.weigth, 2).ToString();
                    lblOrigin.Text = (objMaquile.codsec > 0) ? "Maquila" : "";

                    if (objMaquile.codsec > 0)
                    {
                        txtCoil.Enabled = false;
                        btnDropCoil.Visible = true;
                    }
                    else
                    {
                        txtCoil.Enabled = true;
                        btnDropCoil.Visible = false;
                    }


                    //Metal Data
                    lblMetalizedProduct.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.ProductTo.code : "";
                    lblMetalizedWidth.Text = Math.Round(ObjMetalizedOrderDetail.ProductTo.width, 2).ToString();
                    lblMetalizedCode.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.code : "";
                    lblMetalizedCodeMainCoil.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.mcode : "";
                    lblMetalizedGrossWeigth.Text = Math.Round(ObjMetalizedOrderDetail.grossweigth, 2).ToString();
                    lblNetWeigth.Text = Math.Round(ObjMetalizedOrderDetail.netweigth, 2).ToString();
                    lblMetalizedProduct.Text = ObjMetalizedOrderDetail.ProductTo.boppCode;
                    lblMetalizedWidth.Text = Convert.ToInt32(ObjMetalizedOrderDetail.ProductTo.width).ToString();

                    //Process Data
                    setProcessValues("toLoad", codsec);
                }
            }
            else
            {
                if (ObjMetalizedOrderDetail.codsec > 0)
                {
                    //Coil Data
                    ObjCoil.load(ObjMetalizedOrderDetail.fkproductFrom);
                    txtCoil.Text = ObjCoil.code;
                    lblCoilProdut.Text = ObjCoil.ProductCode;
                    lblCoilWidth.Text = Convert.ToInt32(ObjCoil.width).ToString();
                    lblCoilWeigth.Text = Math.Round(ObjCoil.netWeight, 2).ToString();
                    lblOrigin.Text = (ObjCoil.codsec > 0) ? (ObjCoil.isExternalCoil == true) ? "OPP" : "BOPP" : "";
                    if (ObjCoil.codsec > 0)
                    {
                        txtCoil.Enabled = false;
                        btnDropCoil.Visible = true;
                    }
                    else
                    {
                        txtCoil.Enabled = true;
                        btnDropCoil.Visible = false;
                    }


                    //Metal Data
                    lblMetalizedProduct.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.ProductTo.code : "";
                    lblMetalizedWidth.Text = Math.Round(ObjMetalizedOrderDetail.ProductTo.width, 2).ToString();
                    lblMetalizedCode.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.code : "";
                    lblMetalizedCodeMainCoil.Text = (ObjMetalizedOrderDetail.fkproductTo > 0) ? ObjMetalizedOrderDetail.mcode : "";
                    lblMetalizedGrossWeigth.Text = Math.Round(ObjMetalizedOrderDetail.grossweigth, 2).ToString();
                    lblNetWeigth.Text = Math.Round(ObjMetalizedOrderDetail.netweigth, 2).ToString();
                    lblMetalizedProduct.Text = ObjMetalizedOrderDetail.ProductTo.boppCode;
                    lblMetalizedWidth.Text = Convert.ToInt32(ObjMetalizedOrderDetail.ProductTo.width).ToString();

                    //Process Data
                    setProcessValues("toLoad", codsec);
                }
            }
        }

        private void setProcessValues(string destination, int codsec)
        {
            switch (destination)
            {
                case "toUpdate":
                    clsMetallizedOrderDetail ObjMetalizedOrderDetailUpdate = new clsMetallizedOrderDetail();
                    ObjMetalizedOrderDetailUpdate = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                    ObjMetalizedOrderDetailUpdate.processValues = getValuesFromControl(grpbProcess, "textBox");
                    ObjMetalizedOrderDetailUpdate.processList = clsGlobal.getStringListFromString(ObjMetalizedOrderDetailUpdate.processValues);
                    ObjMetalizedOrderDetailUpdate.notes = txtObservations.Text;
                    ObjMetalizedOrderDetailUpdate.save();

                    break;
                case "toSave":
                    clsMetallizedOrderDetail ObjMetalizedOrderDetailSave = new clsMetallizedOrderDetail();
                    ObjMetalizedOrderDetailSave.processValues = getValuesFromControl(grpbProcess, "textBox");
                    ObjMetalizedOrderDetailSave.processList = clsGlobal.getStringListFromString(ObjMetalizedOrderDetailSave.processValues);
                    ObjMetalizedOrderDetailSave.fkOrder = this.codsec;
                    ObjMetalizedOrderDetailSave.notes = txtObservations.Text;
                    ObjMetalizedOrderDetailSave.save();

                    break;
                case "toLoad":
                    if (codsec > 0)
                    {
                        clsMetallizedOrderDetail ObjMetalizedOrderDetailLoad = new clsMetallizedOrderDetail();
                        ObjMetalizedOrderDetailLoad = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                        setValuesToControl(grpbProcess, "textBoxString", ObjMetalizedOrderDetailLoad.processValues);
                        txtObservations.Text = ObjMetalizedOrderDetailLoad.notes;
                    }

                    break;
                default:
                    break;
            }
        }

        private void PopulatePression(int codsec)
        {
            List<clsMetalizedPressure> lstPressure = new List<clsMetalizedPressure> ();
            lstPressure = clsMetalizedPressure.getListByOrder(codsec);
            dgvPressure.Rows.Clear();
            if (lstPressure.Count > 0)
            {
                for (int i = 0; i < lstPressure.Count; i++)
                {
                    dgvPressure.Rows.Add();
                    dgvPressure.Rows[i].Cells[clmpressurecodsec.Index].Value = lstPressure[i].codsec;
                    dgvPressure.Rows[i].Cells[clmpressurefkorder.Index].Value = lstPressure[i].fkOrder;
                    dgvPressure.Rows[i].Cells[clmpressureingress.Index].Value = lstPressure[i].Ingress;
                    dgvPressure.Rows[i].Cells[clmpressurereturn.Index].Value = lstPressure[i].Return;
                    dgvPressure.Rows[i].Cells[clmpressuredown.Index].Value = lstPressure[i].Down;
                    dgvPressure.Rows[i].Cells[clmpressureoil.Index].Value = lstPressure[i].Oil;
                    dgvPressure.Rows[i].Cells[clmpressureup.Index].Value = lstPressure[i].Up;
                    dgvPressure.Rows[i].Cells[clmpressuredelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
            }
        }

        private void PopulateDeadTime(int codsec)
        {
            List<clsMetalizedDeadTimeValues> lstDeadTime = new List<clsMetalizedDeadTimeValues>();
            lstDeadTime = clsMetalizedDeadTimeValues.getListByOrder(codsec);
            dgvDeadTime.Rows.Clear();
            if (lstDeadTime.Count > 0)
            {
                for (int i = 0; i < lstDeadTime.Count; i++)
                {
                    dgvDeadTime.Rows.Add();
                    dgvDeadTime.Rows[i].Cells[clmdeadtimecodsec.Index].Value = lstDeadTime[i].codsec;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimefkorder.Index].Value = lstDeadTime[i].fkOrder;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimegroup.Index].Value = lstDeadTime[i].DeadTime.deadTimeGroupName;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimename.Index].Value = lstDeadTime[i].DeadTime.deadTimeName;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimeinit.Index].Value = lstDeadTime[i].InitDate.ToString("dd/MM/yyyy hh:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadtimeend.Index].Value = lstDeadTime[i].EndDate.ToString("dd/MM/yyyy hh:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadtimetotal.Index].Value = lstDeadTime[i].TotalDeadTimeMinutes;
                    dgvDeadTime.Rows[i].Cells[clmdeadtimedelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
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
                    clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();
                    ObjMetalizedOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                    if (ObjMetalizedOrderDetail.codsec > 0)
                    {
                        //Update
                        setProcessValues("toUpdate", ObjMetalizedOrderDetail.fkOrder);
                        MessageBox.Show("Proceso Guardado Correctamente", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        //Insert
                        setProcessValues("toSave", ObjMetalizedOrderDetail.codsec);
                        MessageBox.Show("Proceso Guardado Correctamente", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    } 
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
                    clsMetalizedPressure ObjPressure = new clsMetalizedPressure();
                    ObjPressure.Ingress = Convert.ToDouble(txtingress.Text);
                    ObjPressure.Return = Convert.ToDouble(txtreturn.Text);
                    ObjPressure.Down = Convert.ToDouble(txtdown.Text);
                    ObjPressure.Oil = Convert.ToDouble(txtoil.Text);
                    ObjPressure.Up = Convert.ToDouble(txtup.Text);
                    ObjPressure.fkOrder = codsec;
                    if (ObjPressure.save())
                    {
                        if (MessageBox.Show("Presión Guardada Correctamente\r\nDesea generar una nueva presión?", "Proceso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            ClearPressure();
                            PopulatePression(codsec);
                            txtingress.Focus();
                        }
                        else
                            PopulatePression(codsec);
                    }
                    else
                        MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                    if (dtpInit.Value.CompareTo(dtpEnd.Value) < 0)
                    {
                        clsMetalizedDeadTimeValues ObjDeadTime = new clsMetalizedDeadTimeValues();
                        ObjDeadTime.fkOrder = codsec;
                        ObjDeadTime.fkDeadTime = ((clsMetalizedDeadTime)cmbTime.SelectedItem).codsec;
                        ObjDeadTime.InitDate = dtpInit.Value;
                        ObjDeadTime.EndDate = dtpEnd.Value;
                        ObjDeadTime.TotalDeadTimeMinutes = GetMinutesTime(dtpInit.Value, dtpEnd.Value);
                        if (ObjDeadTime.save())
                        {
                            if (MessageBox.Show("Tiempo Muerto Guardado Correctamente\r\nDesea generar un nuevo tiempo muerto?", "Tiempos Muertos - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                ClearDeadTime();
                                PopulateDeadTime(codsec);
                                cmbTime.Focus();
                            }
                            else
                                PopulateDeadTime(codsec);
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
                            PopulatePression(codsec);
                        }
                        else
                            MessageBox.Show("La información no ha podido ser eliminada por favor verifique la información en los campos", "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        PopulatePression(codsec);
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
                            PopulateDeadTime(codsec);
                        }
                        else
                            MessageBox.Show("La información no ha podido ser eliminada por favor verifique la información en los campos", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        PopulateDeadTime(codsec);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnPauseOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea PAUSAR la orden de Metalizado?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
            {
                if (clsMetallizedOrder.toPauseOrder(codsec))
                {
                    MessageBox.Show("Orden de Metalizado PAUSADA Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    this.Close();
                }
                else
                    MessageBox.Show("La orden no ha podido ser pausada por favor vuelva a intentarlo", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnWeigth_Click(object sender, EventArgs e)
        {
            try
            {
                clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();
                ObjMetalizedOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                clsMaquile objMaquile = new clsMaquile();
                objMaquile.load(ObjMetalizedOrderDetail.fkproductFrom);

                if(objMaquile.codsec > 0)
                    isMaquile = true;
                else
                    isMaquile=false;

                if (ObjMetalizedOrderDetail.fkproductFrom > 0)
                {
                    frmMetalizedWegithRegistration winWiegth = new frmMetalizedWegithRegistration(codsec, ObjMetalizedOrder.fkproductTo, isMaquile);
                    winWiegth.StartPosition = FormStartPosition.CenterScreen;
                    winWiegth.ShowDialog(this.MdiParent);
                    PopulateProcess(codsec, isMaquile);
                }
                else
                {
                    MessageBox.Show("Debe primero asignar una BASE para poder registrar el peso de la bobina metalizada", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtCoil.Focus();
                }
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
                if (MessageBox.Show("Esta realmente seguro que desea CERRAR la orden de Metalizado?\r\n Recuerde que una vez que la orden sea cerrada no se podrá adicionar nada mas", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    clsMetallizedOrderDetail ObjMetalizedOrderDetail = new clsMetallizedOrderDetail();
                    ObjMetalizedOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                    if (!clsCoil.isUnique(ObjMetalizedOrderDetail.code))
                    {
                        clsCoil objCoil = new clsCoil();
                        clsCoil objCoilFrom = new clsCoil();
                        objCoilFrom.load(ObjMetalizedOrderDetail.fkproductFrom);
                        objCoil.fkBalance = 1;
                        objCoil.fkCuttingQuality = 1;
                        objCoil.fkProduct = ObjMetalizedOrderDetail.fkproductTo;
                        objCoil.code = ObjMetalizedOrderDetail.code;
                        objCoil.length = objCoilFrom.length;
                        objCoil.width = objCoilFrom.width;
                        objCoil.diameter = objCoilFrom.diameter;
                        objCoil.density = objCoilFrom.density;
                        objCoil.netWeight = ObjMetalizedOrderDetail.netweigth;
                        objCoil.grossWeight = ObjMetalizedOrderDetail.grossweigth;
                        objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                        objCoil.treatmentSide = objCoilFrom.treatmentSide;
                        objCoil.notes = "Metalizado From";
                        objCoil.cuttingDate = DateTime.Now;
                        objCoil.createdDate = DateTime.Now;
                        objCoil.modifiedDate = DateTime.Now;
                        objCoil.createdBy = clsGlobal.LoggedUser.codsec;
                        objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                        objCoil.isExternalCoil = objCoilFrom.isExternalCoil;
                        objCoil.mainCoilCode = ObjMetalizedOrderDetail.mcode;
                        objCoil.lotNumber = ObjMetalizedOrderDetail.Order.lotnumber;
                        if (objCoil.save())
                        {
                            if (clsMetallizedOrder.toCloseOrder(codsec))
                            {
                                MessageBox.Show("Orden de Metalizado CERRADA Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                this.Close();
                            }
                            else
                                MessageBox.Show("La orden no ha podido ser pausada por favor vuelva a intentarlo", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else
                            MessageBox.Show("La orden no ha podido ser pausada por favor vuelva a intentarlo / Error al generar la Bobina metalizada", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("La orden no ha podido ser pausada por favor vuelva a intentarlo / Código de Bobina duplicado", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                    clsCoil ObjCoil = new clsCoil();
                    ObjCoil = clsCoil.getDetailByCode(txtCoil.Text);
                    if (ObjCoil.codsec > 0)
                    {
                        if (!clsMetallizedOrderDetail.getCoilByCode(ObjCoil.codsec))
                        {
                            if (ObjCoil.fkProduct == ObjMetalizedOrder.fkproductFrom)
                            {
                                clsProduct objProduct = new clsProduct ();
                                objProduct.load(ObjCoil.fkProduct);
                                if (clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.Bopp.codsec, objProduct.code) > 0)
                                {
                                    clsMetallizedOrderDetail ObjOrderDetail = new clsMetallizedOrderDetail();
                                    ObjOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                                    ObjOrderDetail.fkOrder = this.codsec;
                                    ObjOrderDetail.fkproductFrom = ObjCoil.codsec;
                                    ObjOrderDetail.fkproductTo = clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.Bopp.codsec, objProduct.code);
                                    ObjOrderDetail.mcode = GenerteCode(ObjCoil.cuttingPosition, ObjCoil.isExternalCoil, false);
                                    if (ObjOrderDetail.save())
                                    {
                                        MessageBox.Show("Bobina agregada Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        PopulateMaterialMetalized(clsMetallizedOrderDetail.getLastSavedCodsec(),false);
                                        txtCoil.Focus();
                                    }
                                    else
                                        MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                                else
                                {
                                    MessageBox.Show("Equivalencia en Metalizado no encontrada\r\n Por favor ingrese un Material válido igual al de la Orden de Metalizado tanto en Ancho - Diámetro", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    txtCoil.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Material Ingresado no corresponde al Material de la Orden de Metalizado\r\n Por favor ingrese un Material válido o igual al de la Orden de Metalizado tanto en Ancho - Diámetro", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoil.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Código ingresado ya fue metalizado, por favor ingrese un código válido", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoil.Focus();
                        }
                    }
                    else if (clsMaquile.isExistCoil(txtCoil.Text))
                    {
                        clsMaquile objMaquile = new clsMaquile();
                        objMaquile.load(txtCoil.Text);
                        //Verificar si ya fue metalizada la Maquila
                        if (clsMetallizedOrderDetail.wasMetalized(objMaquile.codsec))
                        {
                            clsMetallizedOrderDetail ObjOrderDetail = new clsMetallizedOrderDetail();
                            ObjOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
                            ObjOrderDetail.fkOrder = this.codsec;
                            ObjOrderDetail.fkproductFrom = objMaquile.codsec;
                            ObjOrderDetail.fkproductTo = ObjMetalizedOrder.fkproductTo;
                            ObjOrderDetail.mcode = GenerteCode(0, true, true);
                            if (ObjOrderDetail.save())
                            {
                                MessageBox.Show("Maquila agregada Correctamente", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateMaterialMetalized(clsMetallizedOrderDetail.getLastSavedCodsec(), true);
                                txtCoil.Focus();
                            }
                            else
                                MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else
                        {
                            MessageBox.Show("La Maquila ya fue metalizada por favor seleccione otra maquila y vuelva a intentarlo", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoil.Focus();
                        }
                    }
                    else
                    {

                        //Verifica si es una maquila
                        //caso contrario no existe ese código
                        MessageBox.Show("Código ingresado es erróneo por favor vuelva a ingresar el código correcto", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoil.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bobina - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void PopulateMaterialMetalized(int codsecdetail, bool isMaquile)
        {
            if (!isMaquile)
            {
                clsMetallizedOrderDetail ObjOrderDetail = new clsMetallizedOrderDetail();
                ObjOrderDetail.Loader(codsecdetail);
                clsCoil ObjCoil = new clsCoil();
                ObjCoil.load(ObjOrderDetail.fkCoil);
                txtCoil.Text = ObjCoil.code;
                lblCoilProdut.Text = ObjCoil.ProductCode;
                lblCoilWidth.Text = Convert.ToInt32(ObjCoil.width).ToString();
                lblCoilWeigth.Text = Math.Round(ObjCoil.netWeight, 2).ToString();
                lblOrigin.Text = (ObjCoil.isExternalCoil == true) ? "OPP" : "BOPP";
                if (ObjCoil.codsec > 0)
                {
                    txtCoil.Enabled = false;
                    btnDropCoil.Visible = true;
                }
                else
                {
                    txtCoil.Enabled = true;
                    btnDropCoil.Visible = false;
                }

                lblMetalizedCode.Text = ObjOrderDetail.code;
                lblMetalizedCodeMainCoil.Text = ObjOrderDetail.mcode;
                lblMetalizedGrossWeigth.Text = Math.Round(ObjOrderDetail.grossweigth, 2).ToString();
                lblNetWeigth.Text = Math.Round(ObjOrderDetail.netweigth, 2).ToString();
                lblMetalizedProduct.Text = ObjOrderDetail.ProductTo.code;
                lblMetalizedWidth.Text = Convert.ToInt32(ObjOrderDetail.ProductTo.width).ToString();
            }
            else
            {
                clsMetallizedOrderDetail ObjOrderDetail = new clsMetallizedOrderDetail();
                ObjOrderDetail.Loader(codsecdetail);
                clsMaquile ObjMaquile = new clsMaquile();
                ObjMaquile.load(ObjOrderDetail.fkCoil);
                txtCoil.Text = ObjMaquile.code;
                lblCoilProdut.Text = clsProduct.getMaquileProductFrom(ObjMaquile.fkProductFrom);
                lblCoilWidth.Text = Convert.ToInt32(ObjMaquile.width).ToString();
                lblCoilWeigth.Text = Math.Round(ObjMaquile.weigth, 2).ToString();
                lblOrigin.Text = "Maquila";
                if (ObjMaquile.codsec > 0)
                {
                    txtCoil.Enabled = false;
                    btnDropCoil.Visible = true;
                }
                else
                {
                    txtCoil.Enabled = true;
                    btnDropCoil.Visible = false;
                }

                lblMetalizedCode.Text = ObjOrderDetail.code;
                lblMetalizedCodeMainCoil.Text = ObjOrderDetail.mcode;
                lblMetalizedGrossWeigth.Text = Math.Round(ObjOrderDetail.grossweigth, 2).ToString();
                lblNetWeigth.Text = Math.Round(ObjOrderDetail.netweigth, 2).ToString();
                lblMetalizedProduct.Text = ObjOrderDetail.ProductTo.code;
                lblMetalizedWidth.Text = Convert.ToInt32(ObjOrderDetail.ProductTo.width).ToString();
            }
        }

        private string GenerteCode(int position, bool isExternalCoil, bool isMaquile)
        {
            if (isExternalCoil && !isMaquile)
                return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "5" + "3" + clsGlobal.FillWithZeros((ObjMetalizedOrder.number.ToString()), 4) + "-" + position;
            else if (isExternalCoil && isMaquile)
                return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "5" + "5" + clsGlobal.FillWithZeros((ObjMetalizedOrder.number.ToString()), 4) + "-" + position;
            else 
                return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "5" + "4" + clsGlobal.FillWithZeros((ObjMetalizedOrder.number.ToString()), 4) + "-" + position;
        }

        private void btnDropCoil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar la bobina de la Orden de Metalizado?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (clsMetallizedOrderDetail.toDeleteCoil(codsec))
                    {
                        MessageBox.Show("Bobina eliminado con éxito!", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateProcess(ObjMetalizedOrder.codsec, isMaquile);
                    }
                    else
                        MessageBox.Show("La bobina no ha podido ser eliminada!", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isMaquile)
                    printMetalizedLabel(codsec);
                else
                    printMaquileLabel(codsec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void printMetalizedLabel(int metalizedOrder)
        {
            rptMetalizedCoil rptPalletLabel = new rptMetalizedCoil();
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
            prmPalletCodsec.Value = metalizedOrder;

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
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);
        }

        private void printMaquileLabel(int metalizedOrder)
        {
            rptMaquileLabel rptPalletLabel = new rptMaquileLabel();
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
            prmPalletCodsec.Value = metalizedOrder;

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
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);
        }
    }
}
