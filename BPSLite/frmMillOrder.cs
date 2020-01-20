using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmMillOrder : Form
    {
        int codsec = 0, lastMillPallet = 0;
        bool isProcess = false, isUpdate = false;

        clsMillPallet objMillPallet = new clsMillPallet();
        
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        volatile bool continueReading = true;

        public frmMillOrder()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            btnCloseMetalizedOrder.Enabled = false;
            btnprint.Enabled = false;
            PopulateMill();
            PopulateDeadTime();
            PopulateCustomer();
            PopulateProduct();
            txtSequiential.Text = clsSequential.toSequentialMillPallet().ToString();
            lblDensity.Text = "0";
            for (int i = 0; i < cmbEntity.Items.Count; i++)
            {
                if (((clsEntity)cmbEntity.Items[i]).codsec == 119)
                {
                    cmbEntity.SelectedIndex = i;
                    break;
                }
            }
            if (clsGlobal.LoggedUser.codsec == 1102)
                txtMyDensity.Visible = true;
            else
                txtMyDensity.Visible = false;
        }

        public frmMillOrder(int codsec)
        {
            InitializeComponent();
            PopulateMill();
            PopulateDeadTime();
            PopulateCustomer();
            PopulateProduct();
            objMillPallet.load(codsec);
            PopulateHead(objMillPallet);
            txtSequiential.Text = objMillPallet.order.ToString();
            txtSequiential.Enabled = false;
            lblDensity.Text = Math.Round(objMillPallet.density, 4, MidpointRounding.AwayFromZero).ToString();
            txtBag.Text = objMillPallet.bag.ToString();
            txtObservations.Text = objMillPallet.notes;
            txtpallet.Text = Math.Round(objMillPallet.palletWeigth, 1).ToString();
            txtgrossweigth.Text = Math.Round(objMillPallet.grossWeigth, 1).ToString();
            lblNetWeigth.Text = Math.Round(objMillPallet.netWeigth, 1).ToString();
            PopulateAfterSaveDeadTime(objMillPallet.codsec);
            this.codsec = codsec;
            lastMillPallet = codsec;
            isUpdate = true;
            if (lblDensity.Text != "0")
                btnCloseMetalizedOrder.Enabled = true;
            else
                btnCloseMetalizedOrder.Enabled = false;
        }

        private void PopulateHead(clsMillPallet objMillPallet)
        {
            cmbOper.SelectedItem = objMillPallet.OperatorM;

            for (int i = 0; i < cmbMill.Items.Count; i++)
            {
                if (((clsMill)cmbMill.Items[i]).codsec == objMillPallet.fkMill)
                {
                    cmbMill.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbEntity.Items.Count; i++)
            {
                if (((clsEntity)cmbEntity.Items[i]).codsec == objMillPallet.fkEntity)
                {
                    cmbEntity.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbMilProduct.Items.Count; i++)
            {
                if (((clsMillProduct)cmbMilProduct.Items[i]).codsec == objMillPallet.ProductCodsec)
                {
                    cmbMilProduct.SelectedIndex = i;
                    break;
                }
            }
        }

        private void PopulateDeadTime()
        {
            List<clsMetalizedDeadTime> lstDeadTime = new List<clsMetalizedDeadTime>();
            lstDeadTime = clsMetalizedDeadTime.getListMill();
            cmbDeadTime.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbDeadTime.Items.Add(lstDeadTime[i]);
        }

        private void PopulateMill()
        {
            List<clsMill> lstDeadTime = new List<clsMill>();
            lstDeadTime = clsMill.getListMill();
            cmbMill.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbMill.Items.Add(lstDeadTime[i]);
        }

        private void PopulateCustomer()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            lstEntity = clsEntity.getCustomerList();
            cmbEntity.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbEntity.Items.Add(lstEntity[i]);
        }

        private void PopulateProduct()
        {
            List<clsMillProduct> lstProduct = new List<clsMillProduct>();
            lstProduct = clsMillProduct.getList();
            cmbMilProduct.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbMilProduct.Items.Add(lstProduct[i]);
        }

        private void btnAddDeadTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDeadTime())
                {
                    if (!isUpdate)
                    {
                        if (lastMillPallet != 0)
                        {
                            if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                            {
                                clsMetalizedDeadTimeValues ObjDeadTime = new clsMetalizedDeadTimeValues();
                                ObjDeadTime.fkOrder = lastMillPallet;
                                ObjDeadTime.fkDeadTime = ((clsMetalizedDeadTime)cmbDeadTime.SelectedItem).codsec;
                                ObjDeadTime.InitDate = dtpInitDate.Value;
                                ObjDeadTime.EndDate = dtpEndDate.Value;
                                ObjDeadTime.TotalDeadTimeMinutes = GetMinutesTime(dtpInitDate.Value, dtpEndDate.Value);
                                if (ObjDeadTime.saveMill())
                                {
                                    if (MessageBox.Show("Tiempo Muerto Guardado Correctamente\r\nDesea generar un nuevo tiempo muerto?", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                    {
                                        ClearDeadTime();
                                        PopulateAfterSaveDeadTime(lastMillPallet);
                                        cmbDeadTime.Focus();
                                    }
                                    else
                                    {
                                        ClearDeadTime();
                                        PopulateAfterSaveDeadTime(lastMillPallet);
                                    }
                                }
                                else
                                    MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                                MessageBox.Show("Las fechas de los tiempos muertos no pueden ser iguales por favor cambie las fechas", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                                MessageBox.Show("La fecha inicio del tiempo muerto no pueden ser mayor que la fecha fin del tiempo muerto", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else
                            MessageBox.Show("No se puede registrar el tiempo muerto ya que no se ejecuto correctamente el Re-Proceso CODSEC 0", "Proceso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                        {
                            clsMetalizedDeadTimeValues ObjDeadTime = new clsMetalizedDeadTimeValues();
                            ObjDeadTime.fkOrder = objMillPallet.codsec;
                            ObjDeadTime.fkDeadTime = ((clsMetalizedDeadTime)cmbDeadTime.SelectedItem).codsec;
                            ObjDeadTime.InitDate = dtpInitDate.Value;
                            ObjDeadTime.EndDate = dtpEndDate.Value;
                            ObjDeadTime.TotalDeadTimeMinutes = GetMinutesTime(dtpInitDate.Value, dtpEndDate.Value);
                            if (ObjDeadTime.saveMill())
                            {
                                if (MessageBox.Show("Tiempo Muerto Guardado Correctamente\r\nDesea generar un nuevo tiempo muerto?", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                {
                                    ClearDeadTime();
                                    PopulateAfterSaveDeadTime(objMillPallet.codsec);
                                    cmbDeadTime.Focus();
                                }
                                else
                                {
                                    ClearDeadTime();
                                    PopulateAfterSaveDeadTime(objMillPallet.codsec);
                                }
                            }
                            else
                                MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                            MessageBox.Show("Las fechas de los tiempos muertos no pueden ser iguales por favor cambie las fechas", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                            MessageBox.Show("La fecha inicio del tiempo muerto no pueden ser mayor que la fecha fin del tiempo muerto", "Tiempos Muertos - Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
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
            cmbDeadTime.Text = "";
            cmbDeadTime.SelectedIndex = -1;
            cmbDeadTime.SelectedItem = -1;
            cmbDeadTime.SelectedText = "";
            PopulateDeadTime();
            dtpInitDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void PopulateAfterSaveDeadTime(int millpallet)
        {
            List<clsMetalizedDeadTimeMillPallet> lstDeadTime = new List<clsMetalizedDeadTimeMillPallet>();
            lstDeadTime = clsMetalizedDeadTimeMillPallet.getListByMillPallet(millpallet);
            dgvDeadTime.Rows.Clear();
            if (lstDeadTime.Count > 0)
            {
                for (int i = 0; i < lstDeadTime.Count; i++)
                {
                    dgvDeadTime.Rows.Add();
                    dgvDeadTime.Rows[i].Cells[clmdeadcodsec.Index].Value = lstDeadTime[i].codsec;
                    dgvDeadTime.Rows[i].Cells[clmdeaddetele.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    dgvDeadTime.Rows[i].Cells[clmdeadenddate.Index].Value = lstDeadTime[i].EndDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadfkOrder.Index].Value = lstDeadTime[i].fkOrder;
                    dgvDeadTime.Rows[i].Cells[clmdeadgroup.Index].Value = "Molinos";
                    dgvDeadTime.Rows[i].Cells[clmdeadinitdate.Index].Value = lstDeadTime[i].InitDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvDeadTime.Rows[i].Cells[clmdeadcode.Index].Value = lstDeadTime[i].Order.code;
                    dgvDeadTime.Rows[i].Cells[clmdeadname.Index].Value = lstDeadTime[i].DeadTime.deadTimeName;
                    dgvDeadTime.Rows[i].Cells[clmdeadtotal.Index].Value = lstDeadTime[i].TotalDeadTimeMinutes;
                }
            }
        }

        private bool ValidateDeadTime()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbDeadTime, ref label5, "selected")) isValid = false;

            return isValid;
        }

        private double GetMinutesTime(DateTime dtpinit, DateTime dtpend)
        {
            var time = dtpinit.Subtract(dtpend).Minutes;
            return Math.Abs(time);
        }

        private void dgvDeadTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmdeaddetele.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar el tiempo muerto seleccionado?", "Tiempo Muerto - Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsMetalizedDeadTimeMillPallet.toDelete(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadcodsec.Index].Value)))
                        {
                            MessageBox.Show("Tiempo Muerto eliminado correctamente", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateAfterSaveDeadTime(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadfkOrder.Index].Value));
                        }
                        else
                            MessageBox.Show("La información no ha podido ser eliminada por favor verifique la información en los campos", "Tiempo Muerto - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        PopulateAfterSaveDeadTime(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadfkOrder.Index].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Presión - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnWeigth_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateProcess())
                {
                    if (!isUpdate)
                    {
                        clsMillPallet objMillPallet = new clsMillPallet();
                        objMillPallet.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Activa").codsec;
                        objMillPallet.fkMill = ((clsMill)cmbMill.SelectedItem).codsec;
                        objMillPallet.fkProduct = ((clsMillProduct)cmbMilProduct.SelectedItem).codsec;
                        objMillPallet.fkEntity = ((clsEntity)cmbEntity.SelectedItem).codsec;
                        objMillPallet.Product = cmbMilProduct.SelectedItem.ToString();
                        objMillPallet.code = GenerteCode(objMillPallet.fkMill);
                        objMillPallet.lotNumber = objMillPallet.code;
                        objMillPallet.bag = (this.txtBag.Text.Length > 0) ? Convert.ToInt32(txtBag.Text) : 40;
                        objMillPallet.order = Convert.ToInt32(txtSequiential.Text);
                        objMillPallet.palletWeigth = Convert.ToDouble(txtpallet.Text);
                        objMillPallet.grossWeigth = Convert.ToDouble(txtgrossweigth.Text);
                        objMillPallet.netWeigth = Convert.ToDouble(lblNetWeigth.Text);
                        objMillPallet.density = (txtMyDensity.Visible == true) ? Convert.ToDouble(txtMyDensity.Text) : 0;
                        objMillPallet.notes = txtObservations.Text;
                        objMillPallet.customer = cmbEntity.SelectedItem.ToString().ToUpper();
                        objMillPallet.OperatorM = (cmbOper.SelectedIndex > -1) ? cmbOper.SelectedItem.ToString() : "";
                        if (objMillPallet.save())
                        {
                            MessageBox.Show("Re-Proceso Guardado Correctamente\r\nPor favor ingrese los tiempos muertos?", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            lastMillPallet = clsMillPallet.getLastSavedCodsec();
                            groupBox1.Visible = true;
                            isProcess = true;
                            cmbDeadTime.Focus();
                            if (lblDensity.Text != "0")
                                btnCloseMetalizedOrder.Enabled = true;

                            if (isProcess)
                                btnWeigth.Enabled = false;
                        }
                        else
                            MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        objMillPallet.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Activa").codsec;
                        objMillPallet.fkMill = ((clsMill)cmbMill.SelectedItem).codsec;
                        objMillPallet.fkProduct = ((clsMillProduct)cmbMilProduct.SelectedItem).codsec;
                        objMillPallet.fkEntity = ((clsEntity)cmbEntity.SelectedItem).codsec;
                        objMillPallet.Product = cmbMilProduct.SelectedItem.ToString();
                        objMillPallet.bag = (this.txtBag.Text.Length > 0) ? Convert.ToInt32(txtBag.Text) : 40;
                        objMillPallet.order = Convert.ToInt32(txtSequiential.Text);
                        objMillPallet.palletWeigth = Convert.ToDouble(txtpallet.Text);
                        objMillPallet.grossWeigth = Convert.ToDouble(txtgrossweigth.Text);
                        objMillPallet.netWeigth = Convert.ToDouble(lblNetWeigth.Text);
                        objMillPallet.notes = txtObservations.Text;
                        objMillPallet.customer = cmbEntity.SelectedItem.ToString().ToUpper();
                        objMillPallet.OperatorM = (cmbOper.SelectedIndex > -1) ? cmbOper.SelectedItem.ToString() : "";
                        if (objMillPallet.save())
                        {
                            MessageBox.Show("Re-Proceso Guardado Correctamente?", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            if (lblDensity.Text != "0")
                                btnCloseMetalizedOrder.Enabled = true;
                        }
                        else
                            MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                    MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos\r\nRecuerde que debe llenar todos los campos que se encuentre de color rojo!", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateProcess()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtpallet, ref label6, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtgrossweigth, ref label12, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtObservations, ref label12, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMilProduct, ref label3, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbMill, ref label2, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbEntity, ref label8, "selected")) isValid = false;

            return isValid;
        }

        private void btnCloseMetalizedOrder_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cerrar - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerteCode(int mill)
        {
            try
            {
                if (mill == 1)
                    return DateTime.Now.ToString("yy").Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + mill.ToString() + clsGlobal.FillWithZeros(((new clsSequential().millPallet).ToString()), 4);
                else if (mill == 3)
                    return DateTime.Now.ToString("yy").Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "2" + clsGlobal.FillWithZeros(((new clsSequential().millPallet).ToString()), 4);
                else if (mill == 4)
                    return DateTime.Now.ToString("yy").Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "3" + clsGlobal.FillWithZeros(((new clsSequential().millPallet).ToString()), 4);
                else if (mill == 1003)
                    return DateTime.Now.ToString("yy").Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "4" + clsGlobal.FillWithZeros(((new clsSequential().millPallet).ToString()), 4);
                else
                    return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                return "";
            }
        }

        private void txtpallet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSequiential_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
                {
                    if (txtSequiential.Text.Length > 0)
                    {
                        if (MessageBox.Show("Esta realmente seguro que desea modificar el secuencial de re-proceso?\r\n Recuerde que el cambio significa que el próximo re-proceso será " + txtSequiential.Text, "Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            if (clsSequential.updateSequentialMillPallet(Convert.ToInt32(txtSequiential.Text)))
                            {
                                MessageBox.Show("Secuencial Modificado Correctamente", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                cmbMilProduct.Focus();
                            }
                            else
                            {
                                MessageBox.Show("La información no ha podido ser actualizada", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                cmbMilProduct.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe tener al menos un valor para poder actualizar el secuencial", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtSequiential.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void cmbMilProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMilProduct.SelectedIndex > -1)
            {
                if (cmbMilProduct.SelectedIndex == 0)
                {
                    lblIdenty.BackColor = Color.LightBlue;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightBlue;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 1)
                {
                    lblIdenty.BackColor = Color.LightSkyBlue;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightSkyBlue;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 2)
                {
                    lblIdenty.BackColor = Color.LightCyan;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightCyan;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 3)
                {
                    lblIdenty.BackColor = Color.LightGray;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightGray;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 4)
                {
                    lblIdenty.BackColor = Color.LightPink;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightPink;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 5)
                {
                    lblIdenty.BackColor = Color.LawnGreen;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LawnGreen;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 6)
                {
                    lblIdenty.BackColor = Color.LightCoral;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightCoral;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 7)
                {
                    lblIdenty.BackColor = Color.LightSalmon;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightSalmon;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 8)
                {
                    lblIdenty.BackColor = Color.LightGoldenrodYellow;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightGoldenrodYellow;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 9)
                {
                    lblIdenty.BackColor = Color.LightSeaGreen;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightSeaGreen;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
                else if (cmbMilProduct.SelectedIndex == 10)
                {
                    lblIdenty.BackColor = Color.LightSkyBlue;
                    lblIdenty.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).name;
                    lblCode.BackColor = Color.LightSkyBlue;
                    lblCode.Text = ((clsMillProduct)cmbMilProduct.SelectedItem).code;
                }
            }
            else
                ptbMill.Image = null;
        }

        private void txtgrossweigth_TextChanged(object sender, EventArgs e)
        {
            if (txtgrossweigth.Text.Length > 0)
            {
                if (txtpallet.Text.Length > 0)
                    lblNetWeigth.Text = Convert.ToString(Convert.ToDouble(txtgrossweigth.Text) - Convert.ToDouble(txtpallet.Text));
                else
                    lblNetWeigth.Text = "0";
            }
            else
                lblNetWeigth.Text = "0";
        }

        private void txtgrossweigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtpallet_TextChanged(object sender, EventArgs e)
        {
            if (txtpallet.Text.Length > 0)
            {
                if (txtgrossweigth.Text.Length > 0)
                    lblNetWeigth.Text = Convert.ToString(Convert.ToDouble(txtgrossweigth.Text) - Convert.ToDouble(txtpallet.Text));
                else
                    lblNetWeigth.Text = "0";
            }
            else
                lblNetWeigth.Text = "0";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (lastMillPallet != 0)
            {
                objMillPallet = new clsMillPallet();
                objMillPallet.load(lastMillPallet);
                if (objMillPallet.density > 0)
                {
                    if (objMillPallet.fkMill != 3)
                        printMetalizedLabel(lastMillPallet);
                }
                else
                {
                    if (objMillPallet.fkMill == 3 || objMillPallet.fkMill == 1 || objMillPallet.fkMill == 4 || objMillPallet.fkMill == 1003 || objMillPallet.fkMill == 1004 || objMillPallet.fkMill == 1005)
                        printMetalizedLabel(lastMillPallet);
                    else
                        MessageBox.Show("La etiqueta no puede ser impresa ya que no posee DENSIDAD?", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void printMetalizedLabel(int mainCoilMetal)
        {
            try
            {
                rptMillPallet rptPalletLabel = new rptMillPallet();
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
                prmPalletCodsec.Value = mainCoilMetal;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "codsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
                prmOperation.Value = "MillPalletReportByCodsec";

                ParameterField pfldOperation = new ParameterField();
                pfldOperation.Name = "operation";
                pfldOperation.CurrentValues.Add(prmOperation);
                pfldOperation.HasCurrentValue = true;

                ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
                prmCode.Value = "Erwin";

                ParameterField pfldCode = new ParameterField();
                pfldCode.Name = "code";
                pfldCode.CurrentValues.Add(prmCode);
                pfldCode.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initdate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "enddate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

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

                        case "operation":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmOperation);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmOperation);
                            break;

                        case "code":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;

                        case "initdate":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "enddate":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void cmbMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMill.SelectedIndex > -1)
            {
                if (cmbMill.SelectedIndex == 0)
                {
                    ptbMill.Image = imgList.Images[0];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.LightGray;
                    lblMillDrow.Text = "EREMA";
                }
                else if (cmbMill.SelectedIndex == 1)
                {
                    ptbMill.Image = imgList.Images[1];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.Yellow;
                    lblMillDrow.Text = "Molino 2";
                }
                else if (cmbMill.SelectedIndex == 2)
                {
                    ptbMill.Image = imgList.Images[2];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.Red;
                    lblMillDrow.Text = "Molino 3";
                }
                else if (cmbMill.SelectedIndex == 3)
                {
                    ptbMill.Image = imgList.Images[3];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.Pink;
                    lblMillDrow.Text = "Extrusoras";
                }
                else if (cmbMill.SelectedIndex == 4)
                {
                    ptbMill.Image = imgList.Images[4];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.LightBlue;
                    lblMillDrow.Text = "Tortas";
                }
                else if (cmbMill.SelectedIndex == 5)
                {
                    ptbMill.Image = imgList.Images[5];
                    ptbMill.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMillDrow.BackColor = Color.Magenta;
                    lblMillDrow.Text = "Celdas";
                }
            }
            else
                ptbMill.Image = null;
        }

        private void frmMillOrder_Load(object sender, EventArgs e)
        {
            try
            {
                thrdWeigth = new Thread(delegate() { getWeigth(); });

                if (sprtBalance.IsOpen)
                {
                    stopGettingWeigth();
                    sprtBalance.Close();
                }

                sprtBalance.PortName = "COM5";
                sprtBalance.ReadTimeout = 5000;
                sprtBalance.Open();
                continueReading = true;

                thrdWeigth.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.\n Por favor revise si el puerto COM esta en 5 COM5 \n\r" + ex.Message, "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                chkManualWeight.Checked = true;
                chkManualWeight.Enabled = false;
            }
        }

        private void getWeigth()
        {
            try
            {
                while (continueReading)
                {
                    if (sprtBalance.IsOpen == false)
                    {
                        sprtBalance.PortName = "COM5";
                        sprtBalance.Open();
                    }

                    string strReceivedData = sprtBalance.ReadLine();

                    if (strReceivedData != "\r")
                    {
                        if (strReceivedData.EndsWith("?\r"))
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 2)))
                            {
                                this.Invoke((MethodInvoker)delegate { txtgrossweigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 2)), 1, MidpointRounding.AwayFromZero).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { txtgrossweigth.ForeColor = Color.Red; });
                            }
                        }
                        else
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 1)))
                            {
                                this.Invoke((MethodInvoker)delegate { txtgrossweigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 1)), 1, MidpointRounding.AwayFromZero).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { txtgrossweigth.ForeColor = Color.Black; });
                            }
                        }
                    }
                }

                if (continueReading == false)
                    sprtBalance.Close();
            }
            catch (Exception)
            {
                continueReading = false;
                sprtBalance.Close();
            }
        }

        public void stopGettingWeigth()
        {
            continueReading = false;
        }

        private void chkManualWeight_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkManualWeight.Checked == true)
                {
                    stopGettingWeigth();
                    txtgrossweigth.Focus();
                }
                else
                {
                    thrdWeigth = new Thread(delegate() { getWeigth(); });
                    if (sprtBalance.IsOpen)
                    {
                        stopGettingWeigth();
                        sprtBalance.Close();
                    }
                    sprtBalance.PortName = "COM5";
                    sprtBalance.ReadTimeout = 5000;
                    sprtBalance.Open();
                    continueReading = true;

                    thrdWeigth.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.\n\r" + ex.Message, "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                chkManualWeight.Checked = true;
                chkManualWeight.Enabled = false;
            }
        }
    }
}