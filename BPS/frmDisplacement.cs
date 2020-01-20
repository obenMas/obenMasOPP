using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmDisplacement : Form
    {
        private clsTransport objTransport = new clsTransport();
        private clsBoxing objBoxing = new clsBoxing();
        private clsCube objCube = new clsCube();
        private bool isUpdateTransport = false;
        private bool isUpdateBoxing = false;
        private bool isUpdatePallet = false;
        public int myCubeCodsec = 0;

        public frmDisplacement()
        {
            InitializeComponent();
            PopulateTransport();
            PopulateCustomer();
            lblNetWeigth.Text = "0";
            lblWidthUsed.Text = "0";
        }

        public frmDisplacement(int codsec)
        {
            InitializeComponent();
            List<clsCubeData> lstCubeData = new List<clsCubeData>();
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            clsCubeData objCubeData = new clsCubeData();

            lstCubeData = clsCubeData.getListByCodsec(codsec);
            lstCubeDetail = clsCubeDetail.getListByCube(codsec);

            for (int i = 0; i < lstCubeData.Count; i++)
            {
                objCubeData = new clsCubeData();
                objCubeData.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa sin Datos").codsec;
                objCubeData.fkTransport = lstCubeData[i].fkTransport;
                objCubeData.fkCustomer = lstCubeData[i].fkCustomer;
                objCubeData.code = "ER001";
                objCubeData.shipping = lstCubeData[i].shipping;
                objCubeData.order = "ORDER---" + i.ToString();
                objCubeData.notes = lstCubeData[i].notes;
                if (!objCubeData.save())
                {
                    MessageBox.Show("Error al generar el cuaderno de borrador en Cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                    break;
                }
            }

            var codsecP = clsCubeData.getLastCodsec();

            for (int i = 0; i < lstCubeDetail.Count; i++)
            {
                clsCubeDetail objCubeDetail = new clsCubeDetail();
                objCubeDetail.fkCube = codsecP;
                objCubeDetail.fkProduct = lstCubeDetail[i].fkProduct;
                objCubeDetail.fkBoxing = lstCubeDetail[i].fkBoxing;
                objCubeDetail.fkPalletDimentions = lstCubeDetail[i].fkPalletDimentions;
                objCubeDetail.Trataiment = lstCubeDetail[i].Trataiment;
                objCubeDetail.quantity = lstCubeDetail[i].quantity;
                objCubeDetail.coil = lstCubeDetail[i].coil;
                objCubeDetail.coilweigth = lstCubeDetail[i].coilweigth;
                objCubeDetail.pallet = lstCubeDetail[i].pallet;
                objCubeDetail.palletweigth = lstCubeDetail[i].palletweigth;
                objCubeDetail.width = lstCubeDetail[i].width;
                objCubeDetail.rowOne = lstCubeDetail[i].rowOne;
                objCubeDetail.rowTwo = lstCubeDetail[i].rowTwo;
                objCubeDetail.rowThree = lstCubeDetail[i].rowThree;
                if (!objCubeDetail.save())
                {
                    MessageBox.Show("Error al generar detalles en Cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                    break;
                }
            }

            RefreshList(codsecP);

            PopulateTransport();
            PopulateCustomer();

            for (int i = 0; i < cmbTransport.Items.Count; i++)
            {
                if (((clsTransport)cmbTransport.Items[i]).codsec == lstCubeData[0].fkTransport)
                {
                    cmbTransport.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbCustomer.Items.Count; i++)
            {
                if (((clsEntity)cmbCustomer.Items[i]).codsec == lstCubeData[0].fkCustomer)
                {
                    cmbCustomer.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbTypeShipping.Items.Count; i++)
            {
                if (cmbTypeShipping.Items[i].ToString() == lstCubeData[0].shipping.ToString())
                {
                    cmbTypeShipping.SelectedIndex = i;
                    break;
                }
            }

            txtOrder.Text = objCubeData.order;
            txtObservation.Text = lstCubeData[0].notes;
            double weigth = 0, rowOne = 0;

            for (int i = 0; i < dgvCube.Rows.Count; i++)
            {
                weigth += Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubeweight.Index].Value);
                rowOne += Convert.ToDouble(dgvCube.Rows[i].Cells[clmcuberowone.Index].Value);
            }

            lblNetWeigth.Text = weigth.ToString();
            lblWidthUsed.Text = rowOne.ToString();
        }

        public frmDisplacement(string code)
        {
            InitializeComponent();
        }

        private void PopulateTransport()
        {
            List<clsTransport> lstTransport = clsTransport.getListIsVisible();
            cmbTransport.Items.Clear();
            for (int i = 0; i < lstTransport.Count; i++)
                cmbTransport.Items.Add(lstTransport[i]);
        }

        private void PopulateCustomer()
        {
            List<clsEntity> lstEntity = clsEntity.getCustomerList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomer.Items.Add(lstEntity[i]);
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransport.SelectedIndex != -1)
            {
                lblWidth.Text = ((clsTransport)cmbTransport.SelectedItem).usefulWidth.ToString();
                lblHeight.Text = ((clsTransport)cmbTransport.SelectedItem).usefulHigh.ToString();
                lblDepth.Text = ((clsTransport)cmbTransport.SelectedItem).usefulLong.ToString();
            }
            else
            {
                lblDepth.Text = string.Empty;
                lblHeight.Text = string.Empty;
                lblWidth.Text = string.Empty;
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex != -1)
                lblFrom.Text = ((clsEntity)cmbCustomer.SelectedItem).countryName.ToString();
            else
                lblFrom.Text = string.Empty;
        }


        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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


        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 1)
                PopulateSubMainAll();
            else if (tbcMain.SelectedIndex == 2)
                PopulateBoxingAll();
        }

        private void PopulateSubMainAll()
        {
            PopulateTransportAll();
        }

        private void PopulateBoxingAll()
        {
            List<clsBoxing> lstTransport = clsBoxing.getListIsVisible();
            dgvBoxing.Rows.Clear();
            if (lstTransport.Count > 0)
            {
                for (int i = 0; i < lstTransport.Count; i++)
                {
                    dgvBoxing.Rows.Add();
                    dgvBoxing.Rows[i].Cells[clmboxingcodsec.Index].Value = lstTransport[i].codsec;
                    dgvBoxing.Rows[i].Cells[clmboxingname.Index].Value = lstTransport[i].name;
                    dgvBoxing.Rows[i].Cells[clmboxingcode.Index].Value = lstTransport[i].code;
                    dgvBoxing.Rows[i].Cells[clmboxingcoil.Index].Value = lstTransport[i].coil;
                    dgvBoxing.Rows[i].Cells[clmboxingedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvBoxing.Rows[i].Cells[clmboxingdelete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
            else
            {
                MessageBox.Show("No existen embalajes ingresados", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtNameBoxing.Focus();
            }
        }

        private void PopulateTransportAll()
        {
            List<clsTransport> lstTransport = clsTransport.getListIsVisible();
            dgvTransport.Rows.Clear();
            if (lstTransport.Count > 0)
            {
                for (int i = 0; i < lstTransport.Count; i++)
                {
                    dgvTransport.Rows.Add();
                    dgvTransport.Rows[i].Cells[clmtransportcodsec.Index].Value = lstTransport[i].codsec;
                    dgvTransport.Rows[i].Cells[clmtransportname.Index].Value = lstTransport[i].name;
                    dgvTransport.Rows[i].Cells[clmtransportwidth.Index].Value = Math.Ceiling(lstTransport[i].usefulWidth);
                    dgvTransport.Rows[i].Cells[clmtransportheigth.Index].Value = Math.Ceiling(lstTransport[i].usefulHigh);
                    dgvTransport.Rows[i].Cells[clmtransportlong.Index].Value = Math.Ceiling(lstTransport[i].usefulLong);
                    dgvTransport.Rows[i].Cells[clmtransportgrossweigth.Index].Value = Math.Ceiling(lstTransport[i].GrossCapacity);
                    dgvTransport.Rows[i].Cells[clmtransportedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvTransport.Rows[i].Cells[clmtransportdelete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
            else
            {
                MessageBox.Show("No existen transportes ingresados", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtName.Focus();
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHigth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveTransport_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTransport())
                {
                    if (!isUpdateTransport)
                    {
                        objTransport = new clsTransport();
                        objTransport.name = txtName.Text;
                        objTransport.usefulWidth = Convert.ToInt32(txtWidth.Text);
                        objTransport.usefulHigh = Convert.ToInt32(txtHigth.Text);
                        objTransport.usefulLong = Convert.ToInt32(txtLong.Text);
                        objTransport.GrossCapacity = Convert.ToDouble(txtGrossWeigth.Text);
                        if (objTransport.save())
                        {
                            MessageBox.Show("Transporte Ingresado Correctamente..!!", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateTransportAll();
                            RefreshTransport();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtName.Focus();
                        }
                    }
                    else
                    {
                        objTransport.name = txtName.Text;
                        objTransport.usefulWidth = Convert.ToInt32(txtWidth.Text);
                        objTransport.usefulHigh = Convert.ToInt32(txtHigth.Text);
                        objTransport.usefulLong = Convert.ToInt32(txtLong.Text);
                        objTransport.GrossCapacity = Convert.ToDouble(txtGrossWeigth.Text);
                        if (objTransport.save())
                        {
                            MessageBox.Show("Transporte Ingresado Correctamente..!!", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateTransportAll();
                            RefreshTransport();
                            isUpdateTransport = false;
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtName.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos que se encuentran pitados de ROJO!!, llénelos y vuelva a intentar", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RefreshTransport()
        {
            txtGrossWeigth.Text = "0";
            txtHigth.Text = string.Empty;
            txtLong.Text = string.Empty;
            txtName.Text = string.Empty;
            txtWidth.Text = string.Empty;
        }

        private bool ValidateTransport()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref label9, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWidth, ref label12, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtHigth, ref label14, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLong, ref label15, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref label16, "notEmpty")) isValid = false;

            return isValid;
        }

        private void dgvTransport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmtransportedit.Index)
                {
                    objTransport = new clsTransport(Convert.ToInt32(dgvTransport.Rows[e.RowIndex].Cells[clmtransportcodsec.Index].Value));
                    txtName.Text = objTransport.name;
                    txtWidth.Text = objTransport.usefulWidth.ToString();
                    txtHigth.Text = objTransport.usefulHigh.ToString();
                    txtLong.Text = objTransport.usefulLong.ToString();
                    txtGrossWeigth.Text = Math.Round(objTransport.GrossCapacity, 2, MidpointRounding.AwayFromZero).ToString();
                    txtName.Focus();
                    isUpdateTransport = true;
                }
                else if (e.ColumnIndex == clmtransportdelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar el transporte seleccionado??", "Transportes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsTransport.toCrossTransport(Convert.ToInt32(dgvTransport.Rows[e.RowIndex].Cells[clmtransportcodsec.Index].Value)))
                        {
                            MessageBox.Show("Transporte Eliminado Correctamente..!!", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateTransportAll();
                            RefreshTransport();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser eliminada", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtName.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnSaveBoxing_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateBoxing())
                {
                    if (!isUpdateBoxing)
                    {
                        if (!clsBoxing.isUniqueCode(txtCodeBoxing.Text))
                        {
                            objBoxing = new clsBoxing();
                            objBoxing.name = txtNameBoxing.Text.ToUpper();
                            objBoxing.code = txtCodeBoxing.Text.ToUpper();
                            objBoxing.coil = Convert.ToInt32(txtCoil.Text);
                            if (objBoxing.save())
                            {
                                MessageBox.Show("Embalaje Ingresado Correctamente..!!", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateBoxingAll();
                                RefreshBoxing();
                            }
                            else
                            {
                                MessageBox.Show("La información no ha podido ser guardada", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtNameBoxing.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código que desea usar ya se encuentra utilizado por favor cambie de código para poder guardar", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCodeBoxing.Focus();
                        }
                    }
                    else
                    {
                        objBoxing.name = txtNameBoxing.Text;
                        objBoxing.code = txtCodeBoxing.Text;
                        objBoxing.coil = Convert.ToInt32(txtCoil.Text);
                        if (objBoxing.save())
                        {
                            MessageBox.Show("Embalaje Ingresado Correctamente..!!", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateBoxingAll();
                            RefreshBoxing();
                            isUpdateBoxing = false;
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtNameBoxing.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos que se encuentran pitados de ROJO!! \n\rPor favor verifique que las bobinas sean mayor que 0, llénelos y vuelva a intentar", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RefreshBoxing()
        {
            txtCoil.Text = "0";
            txtNameBoxing.Text = string.Empty;
            txtCodeBoxing.Text = string.Empty;
        }

        private bool ValidateBoxing()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtNameBoxing, ref label19, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCodeBoxing, ref label21, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCoil, ref label22, "moreThan0")) isValid = false;
            if (!clsValidation.validateField(ref txtCoil, ref label22, "notEmpty")) isValid = false;

            return isValid;
        }

        private void txtCoil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvBoxing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmboxingedit.Index)
                {
                    objBoxing = new clsBoxing(Convert.ToInt32(dgvBoxing.Rows[e.RowIndex].Cells[clmboxingcodsec.Index].Value));
                    txtNameBoxing.Text = objBoxing.name;
                    txtCodeBoxing.Text = objBoxing.code;
                    txtCoil.Text = objBoxing.coil.ToString();
                    txtNameBoxing.Focus();
                    isUpdateBoxing = true;
                }
                else if (e.ColumnIndex == clmboxingdelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar el embalaje seleccionado??", "Embalaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsBoxing.toCrossTransport(Convert.ToInt32(dgvBoxing.Rows[e.RowIndex].Cells[clmboxingcodsec.Index].Value)))
                        {
                            MessageBox.Show("Embalaje Eliminado Correctamente..!!", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateBoxingAll();
                            RefreshBoxing();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser eliminada", "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtNameBoxing.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void tbcSubMainOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcSubMainOne.SelectedIndex == 0)
                PopulateSubMainAll();
            else if (tbcSubMainOne.SelectedIndex == 1)
                PopulateBoxingAll();
            else if (tbcSubMainOne.SelectedIndex == 2)
                PopulatePalletAll();
        }

        private void PopulatePalletAll()
        {
            List<clsBoxing> lstBoxing = clsBoxing.getListIsVisible();
            cmbBoxing.Items.Clear();
            for (int i = 0; i < lstBoxing.Count; i++)
                cmbBoxing.Items.Add(lstBoxing[i]);

            List<clsPalletType> lstPallet = clsPalletType.getList();
            cmbPallet.Items.Clear();
            for (int i = 0; i < lstPallet.Count; i++)
                cmbPallet.Items.Add(lstPallet[i]);

            List<clsCube> lstCube = clsCube.getListIsVisible();
            dgvTransport.Rows.Clear();
            if (lstCube.Count > 0)
            {
                int coilCount = 0;
                string boxingCode = "", boxingName = "";
                int totalcoilByBoxing = 0;
                int lastPosition = -1;

                dgvPallet.Rows.Clear();

                for (int i = 0; i < lstCube.Count; i++)
                {
                    coilCount++;
                    if (boxingCode == "")
                    {
                        boxingCode = (lstCube.Count > 0) ? lstCube[i].code : "";
                        boxingName = (lstCube.Count > 0) ? lstCube[i].name : "";
                    }

                    if (lstCube[i].code == boxingCode)
                        totalcoilByBoxing++;
                    else
                    {
                        dgvPallet.Rows.Add();
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpalletypecode.Index].Value = boxingCode;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeboxing.Index].Value = boxingName;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeedit.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypedelete.Index].Value = global::BPS.Properties.Resources.clear;

                        for (int j = 0; j < dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvPallet.Font, FontStyle.Bold);
                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }

                        boxingCode = lstCube[i].code;
                        boxingName = lstCube[i].name;
                        totalcoilByBoxing = 1;
                    }

                    dgvPallet.Rows.Add();

                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypecodsec.Index].Value = lstCube[i].codsec;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypecoilscub.Index].Value = lstCube[i].coil;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeboxing.Index].Value = lstCube[i].name;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettype.Index].Value = lstCube[i].PalletTypeName;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypecoil.Index].Value = lstCube[i].PalletTypeCoil;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeorientation.Index].Value = lstCube[i].PalletTypeOrientation;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypefloors.Index].Value = lstCube[i].PalletTypeFloors;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettype.Index].Value = lstCube[i].PalletTypeName;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypedelete.Index].Value = global::BPS.Properties.Resources.cross;
                    lastPosition = i;
                }

                if (lastPosition > -1)
                {
                    dgvPallet.Rows.Add();
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpalletypecode.Index].Value = boxingCode;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeboxing.Index].Value = boxingName;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypeedit.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpallettypedelete.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvPallet.Font, FontStyle.Bold);
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    boxingCode = lstCube[lastPosition].code;
                    boxingName = lstCube[lastPosition].name;
                    totalcoilByBoxing = 1;
                }
            }
            else
            {
                MessageBox.Show("No existen pallet por tipo de embalaje ingresados", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbBoxing.Focus();
            }
        }

        private void btnSavePallet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePallet())
                {
                    if (!isUpdatePallet)
                    {
                        objCube = new clsCube();
                        objCube.fkTransportCub = ((clsBoxing)cmbBoxing.SelectedItem).codsec;
                        objCube.fkTransport = ((clsPalletType)cmbPallet.SelectedItem).codsec;
                        objCube.isVisible = 1;

                        if (objCube.savetransportcubbyTransport())
                        {
                            MessageBox.Show("Pallet por Tipo de Embalaje Ingresado Correctamente..!!", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulatePalletAll();
                            RefreshPallet();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbBoxing.Focus();
                        }
                    }
                    else
                    {
                        objCube.fkTransportCub = ((clsBoxing)cmbBoxing.SelectedItem).codsec;
                        objCube.fkTransport = ((clsPalletType)cmbPallet.SelectedItem).codsec;
                        objCube.isVisible = 1;
                        if (objCube.updatetransportcubbyTransport())
                        {
                            MessageBox.Show("Pallet por Tipo de Embalaje Ingresado Correctamente..!!", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulatePalletAll();
                            RefreshPallet();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbBoxing.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos que se encuentran pitados de ROJO!!", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RefreshPallet()
        {
            cmbBoxing.SelectedIndex = -1;
            cmbBoxing.SelectedItem = -1;
            cmbBoxing.Text = "";
            cmbPallet.SelectedIndex = -1;
            cmbPallet.SelectedItem = -1;
            cmbPallet.Text = "";
            cmbBoxing.Focus();
        }

        private bool ValidatePallet()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbBoxing, ref label20, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbPallet, ref label26, "selected")) isValid = false;

            return isValid;
        }

        private void dgvPallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmpallettypeedit.Index)
                {
                    objCube = new clsCube(Convert.ToInt32(dgvPallet.Rows[e.RowIndex].Cells[clmpallettypecodsec.Index].Value));

                    List<clsBoxing> lstBoxing = clsBoxing.getListIsVisible();
                    cmbBoxing.Items.Clear();
                    for (int i = 0; i < lstBoxing.Count; i++)
                        cmbBoxing.Items.Add(lstBoxing[i]);

                    List<clsPalletType> lstPallet = clsPalletType.getList();
                    cmbPallet.Items.Clear();
                    for (int i = 0; i < lstPallet.Count; i++)
                        cmbPallet.Items.Add(lstPallet[i]);

                    for (int i = 0; i < cmbBoxing.Items.Count; i++)
                    {
                        if (((clsBoxing)cmbBoxing.Items[i]).codsec == objCube.fkTransportCub)
                        {
                            cmbBoxing.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < cmbPallet.Items.Count; i++)
                    {
                        if (((clsPalletType)cmbPallet.Items[i]).codsec == objCube.fkTransport)
                        {
                            cmbPallet.SelectedIndex = i;
                            break;
                        }
                    }

                    cmbBoxing.Focus();
                    isUpdatePallet = true;
                }
                else if (e.ColumnIndex == clmpallettypedelete.Index)
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar el pallet seleccionado??", "Pallet por Tipo de Embalaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsCube.toCrossTransportCubByTransport(Convert.ToInt32(dgvPallet.Rows[e.RowIndex].Cells[clmpallettypecodsec.Index].Value)))
                        {
                            MessageBox.Show("Pallet Eliminado Correctamente..!!", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulatePalletAll();
                            RefreshPallet();
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser eliminada", "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbBoxing.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pallet por Tipo de Embalaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateCubeOptions())
                {
                    clsCubeData objCubeData = new clsCubeData(txtOrder.Text);
                    if (objCubeData.codsec == 0)
                    {
                        objCubeData = new clsCubeData();
                        objCubeData.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa sin Datos").codsec;
                        objCubeData.fkTransport = ((clsTransport)cmbTransport.SelectedItem).codsec;
                        objCubeData.fkCustomer = ((clsEntity)cmbCustomer.SelectedItem).codsec;
                        objCubeData.code = "ER001";
                        objCubeData.shipping = cmbTypeShipping.Text.ToUpper();
                        objCubeData.order = txtOrder.Text;
                        objCubeData.notes = txtObservation.Text.ToUpper();
                        if (objCubeData.save())
                        {
                            frmCubeOptionsPlus winCube = new frmCubeOptionsPlus(((clsTransport)cmbTransport.SelectedItem).codsec, clsCubeData.getLastCodsec());
                            winCube.StartPosition = FormStartPosition.CenterScreen;
                            winCube.ShowDialog(this);
                            RefreshList(clsCubeData.getLastCodsec());
                        }
                        else
                        {
                            MessageBox.Show("Error al generar el cuaderno de borrador en Cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbBoxing.Focus();
                        }
                    }
                    else
                    {
                        objCubeData.fkTransport = ((clsTransport)cmbTransport.SelectedItem).codsec;
                        objCubeData.fkCustomer = ((clsEntity)cmbCustomer.SelectedItem).codsec;
                        objCubeData.code = "ER001";
                        objCubeData.shipping = cmbTypeShipping.Text.ToUpper();
                        objCubeData.order = txtOrder.Text;
                        objCubeData.modifiedDate = DateTime.Now;
                        objCubeData.notes = txtObservation.Text.ToUpper();
                        if (objCubeData.save())
                        {
                            frmCubeOptionsPlus winCube = new frmCubeOptionsPlus(((clsTransport)cmbTransport.SelectedItem).codsec, objCubeData.codsec);
                            winCube.StartPosition = FormStartPosition.CenterScreen;
                            winCube.ShowDialog(this);
                            RefreshList(objCubeData.codsec);
                        }
                        else
                        {
                            MessageBox.Show("Error al generar el cuaderno de borrador en Cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbBoxing.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos que se encuentran pintados de ROJO!!\r\nPrevio a Cubicar", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateCubeOptions()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbTransport, ref label1, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTypeShipping, ref label5, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtOrder, ref label2, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbCustomer, ref label3, "selected")) isValid = false;
            if (txtOrder.Text.Length == 0 || txtOrder.Text == "")
                isValid = false;
            else
            {
                if (txtOrder.ForeColor == Color.Red)
                    isValid = false;
                else
                    isValid = true;
            }

            return isValid;
        }

        private void dgvCube_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmcubeedit.Index)
                {
                    var cubecodsec = Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubefkCube.Index].Value);
                    frmCubeOptions winCube = new frmCubeOptions(Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubefkCube.Index].Value), Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value), "Edit");
                    winCube.StartPosition = FormStartPosition.CenterScreen;
                    winCube.ShowDialog(this);
                    RefreshList(cubecodsec);
                }
                else if (e.ColumnIndex == clmcubedetele.Index)
                {
                    if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        var cubeCodsec = Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value);
                        if (clsCubeDetail.detele(Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value)))
                        {
                            MessageBox.Show("Material borrado con éxito!!", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            RefreshList(cubeCodsec);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido procesar la información", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            RefreshList(cubeCodsec);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void frmDisplacement_Load(object sender, EventArgs e)
        {

        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            if (!clsSalesOrder.IsUniqueSalesOrderNumber(txtOrder.Text, 0))
                txtOrder.ForeColor = Color.Red;
            else
                txtOrder.ForeColor = Color.Black;
        }

        private void RefreshList(int codsecCube)
        {
            double myweigth = 0;
            int mywidth = 0;
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            lstCubeDetail = clsCubeDetail.getListByCube(codsecCube);
            if (lstCubeDetail.Count > 0)
            {
                dgvCube.Rows.Clear();
                for (int i = 0; i < lstCubeDetail.Count; i++)
                {
                    dgvCube.Rows.Add();
                    dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value = lstCubeDetail[i].codsec;
                    dgvCube.Rows[i].Cells[clmcubenumber.Index].Value = (i == 0) ? 1 : dgvCube.Rows.Count;
                    dgvCube.Rows[i].Cells[clmcubematerial.Index].Value = lstCubeDetail[i].codeProduct;
                    dgvCube.Rows[i].Cells[clmcubeboxing.Index].Value = lstCubeDetail[i].transcodeBoxing + " [" + lstCubeDetail[i].transnameBoxing + "]";
                    dgvCube.Rows[i].Cells[clmcubedimentions.Index].Value = lstCubeDetail[i].dimentionfullDimentions;
                    dgvCube.Rows[i].Cells[clmcubecoil.Index].Value = lstCubeDetail[i].coil;
                    dgvCube.Rows[i].Cells[clmcubepallet.Index].Value = lstCubeDetail[i].pallet;
                    dgvCube.Rows[i].Cells[clmcubequantity.Index].Value = lstCubeDetail[i].quantity;
                    dgvCube.Rows[i].Cells[clmcubeweight.Index].Value = Math.Round(lstCubeDetail[i].pallet * lstCubeDetail[i].palletweigth, 2, MidpointRounding.AwayFromZero);
                    dgvCube.Rows[i].Cells[clmcubefkCube.Index].Value = lstCubeDetail[i].fkCube;
                    dgvCube.Rows[i].Cells[clmcuberowone.Index].Value = lstCubeDetail[i].rowOne;
                    dgvCube.Rows[i].Cells[clmcuberowtwo.Index].Value = lstCubeDetail[i].rowTwo;
                    dgvCube.Rows[i].Cells[clmcuberowthree.Index].Value = lstCubeDetail[i].rowThree;
                    dgvCube.Rows[i].Cells[clmcubeedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvCube.Rows[i].Cells[clmcubedetele.Index].Value = global::BPS.Properties.Resources.cross;
                }

                for (int i = 0; i < lstCubeDetail.Count; i++)
                    myweigth += Convert.ToDouble(lstCubeDetail[i].pallet * lstCubeDetail[i].palletweigth);

                for (int i = 0; i < lstCubeDetail.Count; i++)
                    mywidth = Convert.ToInt32(lstCubeDetail[i].rowOne);

                lblWidthUsed.Text = mywidth.ToString();
                lblNetWeigth.Text = Math.Round(myweigth, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                lblNetWeigth.Text = "0";
                lblWidthUsed.Text = "0";
            }
        }

        private void btnDrawin_Click(object sender, EventArgs e)
        {
            if (dgvCube.Rows.Count > 0)
            {

                myCubeCodsec = Convert.ToInt32(dgvCube.Rows[0].Cells[clmcubefkCube.Index].Value);


                frmCubeDrawin winDra = new frmCubeDrawin(myCubeCodsec);
                winDra.StartPosition = FormStartPosition.CenterScreen;
                winDra.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("No existen datos para generar el cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                btnCube.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCube.Rows.Count > 0)
            {
                int cubeCodsec = 0;

                cubeCodsec = Convert.ToInt32(dgvCube.Rows[0].Cells[clmcubefkCube.Index].Value);


                clsCubeData objCube = new clsCubeData(cubeCodsec);
                objCube.modifiedDate = DateTime.Now;
                objCube.code = "IN000" + cubeCodsec.ToString();
                objCube.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa con Datos").codsec;
                objCube.notes = txtObservation.Text.ToUpper();
                if (!objCube.save())
                {
                    MessageBox.Show("Error al momento de generar el data para el cubicaje\n **** Por favor vuelva a intentarlo??", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                }
                else
                {
                    MessageBox.Show("Cubicaje Generado Correctamente", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbBoxing.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existen datos para generar el cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                btnCube.Focus();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvCube.Rows.Count > 0)
            {
                int codsec = 0;


                codsec = Convert.ToInt32(dgvCube.Rows[0].Cells[clmcubefkCube.Index].Value);


                frmCubeReport winReport = new frmCubeReport(codsec);
                winReport.StartPosition = FormStartPosition.CenterScreen;
                winReport.Show(this);
            }
            else
            {
                MessageBox.Show("No existen datos para generar el cubicaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                btnCube.Focus();
            }
        }
    }
}
