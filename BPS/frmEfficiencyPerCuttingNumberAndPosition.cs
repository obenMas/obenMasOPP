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
    public partial class frmEfficiencyPerCuttingNumberAndPosition : Form
    {
        private bool isUpdate = false;
        private int cuttingNumber = 0, Position = 0;
        private int codsecobjCuttingStop = 0;
        private double qualityOk = 0, qualityNo = 0;
        private clsCuttingOrder objcuttingOrder = new clsCuttingOrder();
        private clsCuttingStop objcuttingStop = new clsCuttingStop();

        public frmEfficiencyPerCuttingNumberAndPosition()
        {
            InitializeComponent();
        }

        public frmEfficiencyPerCuttingNumberAndPosition(int cuttingNumber, int Position, clsCuttingOrder objCuttingOrder, clsCuttingStop objCuttingStop)
        {
            InitializeComponent();
            this.cuttingNumber = cuttingNumber;
            this.Position = Position;
            this.objcuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);
            this.objcuttingStop = objCuttingStop;
            PopulateData();
        }

        private void PopulateData()
        {
            for (int i = 0; i < objcuttingOrder.lstCuttingStop.Count; i++)
            {
                if (objcuttingOrder.lstCuttingStop[i].position == Position)
                {
                    codsecobjCuttingStop = objcuttingOrder.lstCuttingStop[i].codsec;
                    break;
                }
                else
                    codsecobjCuttingStop = 0;
            }

            clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();
            objEfficiencyCutExtruder = clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingOrder(objcuttingStop.codsec);
            if (objEfficiencyCutExtruder.codsec > 0)
            {
                txtdecrease.Text = Math.Round(objEfficiencyCutExtruder.decrease, 2, MidpointRounding.AwayFromZero).ToString();
                txtrefile.Text = Math.Round(objEfficiencyCutExtruder.refile, 2, MidpointRounding.AwayFromZero).ToString();
                txtendroller.Text = Math.Round(objEfficiencyCutExtruder.endroller, 2, MidpointRounding.AwayFromZero).ToString();
                txtconsuption.Text = Math.Round(objEfficiencyCutExtruder.consuption, 2, MidpointRounding.AwayFromZero).ToString();
                ckbisreprocess.Checked = objEfficiencyCutExtruder.isReprocess;

                txtWaste.Text = Math.Round(objEfficiencyCutExtruder.waste, 2, MidpointRounding.AwayFromZero).ToString();
                txtWasteCoil.Text = objEfficiencyCutExtruder.wasteCoil;
                txtNotes.Text = objEfficiencyCutExtruder.notes;
                ckbSplice.Checked = objEfficiencyCutExtruder.splice;
                if (objEfficiencyCutExtruder.splice)
                {
                    pnlSplice.Visible = true;
                    txtSpliceInit.Text = Math.Round(objEfficiencyCutExtruder.spliceInit, 2, MidpointRounding.AwayFromZero).ToString();
                    txtSpliceInitCoil.Text = objEfficiencyCutExtruder.spliceInitiCoil;
                    txtSpliceEnd.Text = Math.Round(objEfficiencyCutExtruder.spliceEnd, 2, MidpointRounding.AwayFromZero).ToString();
                    txtSpliceEndCoil.Text = objEfficiencyCutExtruder.spliceEndCoil;
                }
                else
                    pnlSplice.Visible = false;

                objcuttingStop = new clsCuttingStop(codsecobjCuttingStop);
                for (int i = 0; i < objcuttingStop.lstCoil.Count; i++)
                {
                    if (objcuttingStop.lstCoil[i].fkCuttingQuality == 1)
                        qualityOk += objcuttingStop.lstCoil[i].netWeight;
                    else
                        qualityNo += objcuttingStop.lstCoil[i].netWeight;
                }

                txtconsuption.Text = Math.Round(qualityOk, 2, MidpointRounding.AwayFromZero).ToString();
                txtConsuptionObs.Text = Math.Round(qualityNo, 2, MidpointRounding.AwayFromZero).ToString();

                isUpdate = true;
            }
            else
            {
                objcuttingStop = new clsCuttingStop(codsecobjCuttingStop);
                for (int i = 0; i < objcuttingStop.lstCoil.Count; i++)
                {
                    if (objcuttingStop.lstCoil[i].fkCuttingQuality == 1)
                        qualityOk += objcuttingStop.lstCoil[i].netWeight;
                    else
                        qualityNo += objcuttingStop.lstCoil[i].netWeight;
                }
                txtconsuption.Text = Math.Round(qualityOk, 2, MidpointRounding.AwayFromZero).ToString();
                txtConsuptionObs.Text = Math.Round(qualityNo, 2, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void txtdecrease_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrefile_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtendroller_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtconsuption_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();
                if (ValidateForm())
                {
                    if (!isUpdate)
                    {
                        objEfficiencyCutExtruder.decrease = Convert.ToDouble(txtdecrease.Text);
                        objEfficiencyCutExtruder.refile = Convert.ToDouble(txtrefile.Text);
                        objEfficiencyCutExtruder.endroller = Convert.ToDouble(txtendroller.Text);
                        objEfficiencyCutExtruder.consuption = Convert.ToDouble(txtconsuption.Text);
                        objEfficiencyCutExtruder.ConsuptionObs = Convert.ToDouble(txtConsuptionObs.Text);
                        objEfficiencyCutExtruder.isReprocess = ckbisreprocess.Checked;
                        objEfficiencyCutExtruder.fkCuttingOrder = objcuttingOrder.codsec;
                        objEfficiencyCutExtruder.cuttingposition = Position;
                        objEfficiencyCutExtruder.cuttingNumber = cuttingNumber;
                        objEfficiencyCutExtruder.fkStatus = objcuttingOrder.fkStatus;
                        if (objcuttingOrder.lstCuttingStop.Count > 0)
                        {
                            for (int i = 0; i < objcuttingOrder.lstCuttingStop.Count; i++)
                            {
                                if (objcuttingOrder.lstCuttingStop[i].position == Position)
                                {
                                    objEfficiencyCutExtruder.cuttingstopcodsec = objcuttingOrder.lstCuttingStop[i].codsec;
                                    break;
                                }
                                else
                                    objEfficiencyCutExtruder.cuttingstopcodsec = 0;
                            }
                        }
                        else
                            objEfficiencyCutExtruder.cuttingstopcodsec = 0;
                        
                        objEfficiencyCutExtruder.notes = txtNotes.Text;
                        objEfficiencyCutExtruder.waste = Convert.ToDouble(txtWaste.Text);
                        objEfficiencyCutExtruder.wasteCoil = txtWasteCoil.Text;
                        objEfficiencyCutExtruder.splice = ckbSplice.Checked;
                        objEfficiencyCutExtruder.spliceInit = Convert.ToDouble(txtSpliceInit.Text);
                        objEfficiencyCutExtruder.spliceInitiCoil = txtSpliceInitCoil.Text;
                        objEfficiencyCutExtruder.spliceEnd = Convert.ToDouble(txtSpliceEnd.Text);
                        objEfficiencyCutExtruder.spliceEndCoil = txtSpliceEndCoil.Text;
                        objEfficiencyCutExtruder.isLegth = rdbMeters.Checked;
                        objEfficiencyCutExtruder.isWeigth = rdbWeigth.Checked;
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.reprocessCoil += txtReprocessCoil.Text;
                            objEfficiencyCutExtruder.reprocessCoil += ";";
                            objEfficiencyCutExtruder.reprocessCoil += txtReprocessMainCoil.Text;
                        }
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.legthValues += txtMetersMainCoil.Text;
                            objEfficiencyCutExtruder.legthValues += ";";
                            objEfficiencyCutExtruder.legthValues += txtMetersWaste.Text;
                        }
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.weigthValues += txtWaste.Text;
                            objEfficiencyCutExtruder.weigthValues += ";";
                            objEfficiencyCutExtruder.weigthValues += txtWasteCoil.Text;
                        }
                        objEfficiencyCutExtruder.spliceThree = Convert.ToDouble(txtSpliceThree.Text);
                        objEfficiencyCutExtruder.spliceCoilThree = txtSpliceCoilThree.Text;
                        if (objEfficiencyCutExtruder.save())
                        {
                            MessageBox.Show("Eficiencia guardada correctamente!", "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            this.Close();
                        }
                        else
                            MessageBox.Show("La información no ha podido ser guardada -- Error al guardar eficiencia", "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        objEfficiencyCutExtruder = clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingOrder(cuttingNumber, Position);
                        objEfficiencyCutExtruder.decrease = Convert.ToDouble(txtdecrease.Text);
                        objEfficiencyCutExtruder.refile = Convert.ToDouble(txtrefile.Text);
                        objEfficiencyCutExtruder.endroller = Convert.ToDouble(txtendroller.Text);
                        objEfficiencyCutExtruder.consuption = Convert.ToDouble(txtconsuption.Text);
                        objEfficiencyCutExtruder.ConsuptionObs = Convert.ToDouble(txtConsuptionObs.Text);
                        objEfficiencyCutExtruder.isReprocess = ckbisreprocess.Checked;
                        objEfficiencyCutExtruder.fkCuttingOrder = objcuttingOrder.codsec;
                        objEfficiencyCutExtruder.cuttingposition = Position;
                        objEfficiencyCutExtruder.cuttingNumber = cuttingNumber;
                        objEfficiencyCutExtruder.fkStatus = objcuttingOrder.fkStatus;
                        if (objcuttingOrder.lstCuttingStop.Count > 0)
                        {
                            for (int i = 0; i < objcuttingOrder.lstCuttingStop.Count; i++)
                            {
                                if (objcuttingOrder.lstCuttingStop[i].position == Position)
                                {
                                    objEfficiencyCutExtruder.cuttingstopcodsec = objcuttingOrder.lstCuttingStop[i].codsec;
                                    break;
                                }
                                else
                                    objEfficiencyCutExtruder.cuttingstopcodsec = 0;
                            }
                        }
                        else
                            objEfficiencyCutExtruder.cuttingstopcodsec = 0;

                        objEfficiencyCutExtruder.notes = txtNotes.Text;
                        objEfficiencyCutExtruder.waste = Convert.ToDouble(txtWaste.Text);
                        objEfficiencyCutExtruder.wasteCoil = txtWasteCoil.Text;
                        objEfficiencyCutExtruder.splice = ckbSplice.Checked;
                        objEfficiencyCutExtruder.spliceInit = Convert.ToDouble(txtSpliceInit.Text);
                        objEfficiencyCutExtruder.spliceInitiCoil = txtSpliceInitCoil.Text;
                        objEfficiencyCutExtruder.spliceEnd = Convert.ToDouble(txtSpliceEnd.Text);
                        objEfficiencyCutExtruder.spliceEndCoil = txtSpliceEndCoil.Text;
                        objEfficiencyCutExtruder.isLegth = rdbMeters.Checked;
                        objEfficiencyCutExtruder.isWeigth = rdbWeigth.Checked;
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.reprocessCoil += txtReprocessCoil.Text;
                            objEfficiencyCutExtruder.reprocessCoil += ";";
                            objEfficiencyCutExtruder.reprocessCoil += txtReprocessMainCoil.Text;
                        }
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.legthValues += txtMetersMainCoil.Text;
                            objEfficiencyCutExtruder.legthValues += ";";
                            objEfficiencyCutExtruder.legthValues += txtMetersWaste.Text;
                        }
                        for (int i = 0; i < 1; i++)
                        {
                            objEfficiencyCutExtruder.legthValues += txtWaste.Text;
                            objEfficiencyCutExtruder.legthValues += ";";
                            objEfficiencyCutExtruder.legthValues += txtWasteCoil.Text;
                        }
                        objEfficiencyCutExtruder.spliceThree = Convert.ToDouble(txtSpliceThree.Text);
                        objEfficiencyCutExtruder.spliceCoilThree = txtSpliceCoilThree.Text;
                        if (objEfficiencyCutExtruder.save())
                        {
                            MessageBox.Show("Eficiencia guardada correctamente!", "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            isUpdate = false;
                            this.Close();
                        }
                        else
                            MessageBox.Show("La información no ha podido ser guardada -- Error al guardar eficiencia", "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show("Existen datos que no han sido llenados y son requeridos", "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtdecrease.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eficiencia Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtdecrease, ref label1, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtrefile, ref label2, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtendroller, ref label3, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtconsuption, ref label4, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWaste, ref label5, "notEmpty")) isValid = false;
            
            if (Convert.ToDouble(txtWaste.Text) > 0)
            {
                if (!clsValidation.validateField(ref txtWasteCoil, ref label11, "notEmpty")) isValid = false;
            }

            if (ckbSplice.Checked)
            {
                if (!clsValidation.validateField(ref txtSpliceInit, ref label6, "notEmpty")) isValid = false;
                if (!clsValidation.validateField(ref txtSpliceInitCoil, ref label8, "notEmpty")) isValid = false;
                if (!clsValidation.validateField(ref txtSpliceEnd, ref label10, "notEmpty")) isValid = false;
                if (!clsValidation.validateField(ref txtSpliceEndCoil, ref label9, "notEmpty")) isValid = false;
            }

            return isValid;
        }

        private void ckbSplice_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSplice.Checked)
                pnlSplice.Visible = true;
            else
                pnlSplice.Visible = false;
        }

        private void txtWaste_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSpliceInit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSpliceEnd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ckbisreprocess_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbisreprocess.Checked)
                pnlRecprocess.Visible = true;
            else
                pnlRecprocess.Visible = false;
        }

        private void txtReprocessCoil_TextChanged(object sender, EventArgs e)
        {
            if (txtReprocessCoil.Text.Length > 0)
                txtReprocessMainCoil.Text = clsCoil.getMainCoilByCoil(txtReprocessCoil.Text);
        }

        private void rdbWeigth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWeigth.Checked)
            {
                pnlWeigth.Visible = true;
                pnlWeigth.BringToFront();
                txtWaste.Focus();
            }
        }

        private void rdbMeters_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMeters.Checked)
            {
                pnlMeters.Visible = true;
                pnlMeters.BringToFront();
                txtMetersMainCoil.Focus();
            }
        }

        private void txtMetersWaste_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMetersMainCoil.Text.Length > 0 && txtMetersWaste.Text.Length > 0)
                {
                    clsMainCoil objMainCoil = new clsMainCoil();
                    objMainCoil.load(txtMetersMainCoil.Text);
                    lblAproxWeigth.Text = Math.Round(((Convert.ToDouble(txtMetersWaste.Text)) * (objMainCoil.netWeigth)) / (objMainCoil.netlength), 2, MidpointRounding.AwayFromZero).ToString();
                }
            }
            catch (Exception)
            {
                lblAproxWeigth.Text = "0";
            }
        }

        private void txtWasteCoil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtWaste.Text.Length > 0 && txtWasteCoil.Text.Length > 0)
                {
                    clsMainCoil objMainCoil = new clsMainCoil();
                    objMainCoil.load(txtWasteCoil.Text);
                    lblAproxLegth.Text = Math.Round(((Convert.ToDouble(txtWaste.Text)) * (objMainCoil.netlength)) / (objMainCoil.netWeigth), 2, MidpointRounding.AwayFromZero).ToString();
                }
            }
            catch (Exception)
            {
                lblAproxLegth.Text = "0";
            }
        }

        private void txtSpliceEndCoil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSpliceInitCoil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
