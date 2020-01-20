using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmNewCoil : Form
    {
        clsProduct objProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        bool flgIsChangingNewWeigth = false;
        List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();
        clsSalesOrderDetail objSod =new clsSalesOrderDetail();
        bool isMetalProcess = false;

        clsCoil objCoil = new clsCoil();

        public frmNewCoil()
        {
            InitializeComponent();
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCoilCellar, ref lblCoilCellar, "selected")) isValid = false;

            return isValid;
        }
        private void clearForm()
        {
            objProduct = new clsProduct();
            lblFilmName.Text = "";
            txtCode.Text = "";
            txtDiameter.Text = "0";
            txtNewWeigth.Text = "0";
            txtGrossWeigth.Text = "0";
            lblDensity.Text = "0";
            txtLength.Text = "0";
            lblWidth.Text = "0";
            cmbCoilCellar.SelectedIndex = -1;
            cmbQuality.SelectedIndex = -1;
            rdoTreatmentExternal.Checked = true;
            chkIsExternalCoil.Checked = false;
            grpbDefects.Enabled = false;
            txtNotes.Text = "";
            chkDefect1.Checked = false;
            chkDefect2.Checked = false;
            chkDefect3.Checked = false;
            chkDefect4.Checked = false;
            chkDefect5.Checked = false;
            chkDefect6.Checked = false;
            chkDefect7.Checked = false;
            chkDefect8.Checked = false;
            chkDefect9.Checked = false;
            chkDefect10.Checked = false;
            chkDefect11.Checked = false;
            chkDefect12.Checked = false;
            chkDefect13.Checked = false;
            chkDefect14.Checked = false;
            chkDefect15.Checked = false;
            chkDefect16.Checked = false;
            btnSearchProduct.Focus();
        }
        private void frmCoil_Load(object sender, EventArgs e)
        {
            clsMachine objMachine = new clsMachine();
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();

            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);


            for (int i = 0; i < lstCoilCellar.Count; i++)
                cmbCoilCellar.Items.Add(lstCoilCellar[i]);

            
            
            lstSalesOrder = clsSalesOrder.getActiveList();
            cmbSalesOrder.Items.Clear();

            cmbSalesOrder.Items.Add(new clsSalesOrder());

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                cmbSalesOrder.Items.Add(lstSalesOrder[i]);
            }
        }
        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                clsCoil objPrevCoil = clsCoil.getDetailByCode(txtCode.Text);

                if (objPrevCoil.isExternalCoil) // Se fija que la bobina que pusieron era de impo.
                {
                    chkIsExternalCoil.Checked = true;
                }
                else
                {
                    chkIsExternalCoil.Checked = false;
                }

                if (objPrevCoil.codsec == 0)
                {
                    objCoil.fkBalance = 3019;
                    objCoil.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                    objCoil.fkProduct = objProduct.codsec;
                    objCoil.code = txtCode.Text;
                    objCoil.length = Convert.ToDouble(txtLength.Text);
                    objCoil.width = objProduct.width;
                    objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                    objCoil.density = Convert.ToDouble(lblDensity.Text);
                    objCoil.netWeight = Convert.ToDouble(txtNewWeigth.Text);
                    objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                    if (cmbQuality.Text != "Observación")
                    {
                        objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                    }
                    else
                    {
                        objCoil.defects = "";
                        for (int i = 0; i < grpbDefects.Controls.Count; i++)
                        {
                            objCoil.defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                            objCoil.defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                        }
                    }

                    if (rdoTreatmentExternal.Checked == true)
                        objCoil.treatmentSide = "Externo";
                    else if (rdoTreatmentInner.Checked == true)
                        objCoil.treatmentSide = "Interno";
                    else if (rdoTreatmentDouble.Checked == true)
                        objCoil.treatmentSide = "Doble";
                    else if (rdoTT.Checked == true)
                        objCoil.treatmentSide = "TT";
                    else if (rdoQ.Checked == true)
                        objCoil.treatmentSide = "";
                    else
                        objCoil.treatmentSide = "Sin tratamiento";

                    objCoil.notes = txtNotes.Text;
                    objCoil.cuttingDate = DateTime.Now;
                    objCoil.createdDate = DateTime.Now;
                    objCoil.modifiedDate = DateTime.Now;
                    objCoil.createdBy = clsGlobal.LoggedUser.codsec;
                    objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                    objCoil.isExternalCoil = chkIsExternalCoil.Checked;
                    objCoil.mainCoilCode = txtMainCoilCode.Text;
                    objCoil.lotNumber = txtLotNumber.Text;
                    objCoil.cellar = new clsCoilCellar(cmbCoilCellar.Items[cmbCoilCellar.SelectedIndex].ToString()).codsec;

                    if (objCoil.save(((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec))
                    {
                        if (cmbSalesOrder.SelectedIndex != -1)
                        {
                            if (((clsSalesOrder)cmbSalesOrder.SelectedItem).codsec != 0)
                            {
                                clsSalesOrder objSalesOrder = new clsSalesOrder(((clsSalesOrder)cmbSalesOrder.SelectedItem).codsec);

                                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                                {
                                    clsProduct objSalesOrderProduct = new clsProduct(objSalesOrder.lstSalesOrderDetail[i].fkProduct);

                                    if (objProduct.fkBopp == objSalesOrderProduct.fkBopp && objProduct.fkCast == objSalesOrderProduct.fkCast && objProduct.width == objSalesOrderProduct.width)
                                    {
                                        clsCoil.assignToSalesOrder(objCoil.codsec, objSalesOrder.lstSalesOrderDetail[i].codsec);
                                        break;
                                    }
                                }
                            }
                        }

                        MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        objCoil = new clsCoil();
                        clearForm();
                    }
                    else
                    {
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado ya pertenece a una bobina previamente registrada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.Text == "Observación")
                grpbDefects.Enabled = true;
            else
                grpbDefects.Enabled = false;
        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == false)
            {
                if (!isMetalProcess)
                {
                    if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                    {
                        double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                        txtNewWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));

                        lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNewWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                    }
                    else
                    {
                        MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNewWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
            }
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
                for (int i = 0; i < lstCuttingQuality.Count; i++)
                    cmbQuality.Items.Add(lstCuttingQuality[i]);
            }
        }

        private void cmbCoilCellar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            objProduct = new clsProduct();
            frmProductList winProductList = new frmProductList(this);
            winProductList.ShowDialog(this);
            objProduct.load(selectedProductCodsec);
            lblFilmName.Text = objProduct.ToString();
            lblWidth.Text = objProduct.width.ToString();
            txtCode.Focus();
            txtCode.SelectAll();
        }

        private void txtNewWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == true)
            {
                if (!isMetalProcess)
                {
                    if (clsGlobal.isNumeric(txtNewWeigth.Text))
                    {
                        double grossWeigth = Convert.ToDouble(txtNewWeigth.Text) + (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                        txtGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 2));

                        lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNewWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                    }
                    else
                    {
                        MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNewWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
            }
        }

        private void txtNewWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = true;
        }

        private void txtGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = false;
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void grpbCoilInfo_Enter(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clsMainCoilMetal.toCheckMainCoilData(txtCode.Text).codsec > 0)
                {
                    isMetalProcess = true;
                    clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();

                    objMainCoilMetal = clsMainCoilMetal.toCheckMainCoilData(txtCode.Text);

                    objProduct.load(objMainCoilMetal.fkProductTo);
                    lblFilmName.Text = objProduct.ToString();
                    lblWidth.Text = objProduct.width.ToString();
                    txtDiameter.Text = objMainCoilMetal.diameter.ToString();
                    txtNewWeigth.Text = objMainCoilMetal.netWeigth.ToString();
                    txtGrossWeigth.Text = objMainCoilMetal.grossWeigth.ToString();
                    txtLength.Text = objMainCoilMetal.netlength.ToString();
                    txtLotNumber.Text = objMainCoilMetal.lotNumber;
                    txtMainCoilCode.Text = objMainCoilMetal.mcode;
                    txtNotes.Text = objMainCoilMetal.notes;
                    cmbCoilCellar.SelectedIndex = 0;
                    cmbSalesOrder.SelectedIndex = -1;
                }
            }
        }
    }
}