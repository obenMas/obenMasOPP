using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Raw.ProcessR.Line
{
    public partial class frmMessageRM : Form
    {
        private clsRawMaterial rawOBJ;
        private clsMillPallet reprocessOBJ;

        private bool isRaw = true;
        private int fkFormulation = 0, fkBopp = 0, fkFilmProduction = 0;
        private string layer = string.Empty, fName = string.Empty;
        public bool isValidProcess { get; set; }

        public frmMessageRM()
        {
            InitializeComponent();
        }

        public frmMessageRM(clsRawMaterial rawOBJ, int fkBopp, int fkFilmProduction, string fName, string layer)
        {
            InitializeComponent();
            this.rawOBJ = rawOBJ;
            this.isRaw = true;
            this.fkBopp = fkBopp;
            this.fName = fName;
            this.layer = layer;
            this.fkFilmProduction = fkFilmProduction;
            fillRaw();
        }

        public frmMessageRM(clsRawMaterial rawOBJ, int fkFormulation, string layer)
        {
            InitializeComponent();
            this.rawOBJ = rawOBJ;
            this.isRaw = true;
            this.fkFormulation = fkFormulation;
            this.layer = layer;
            fillRaw();
        }

        private void fillRaw()
        {
            label1.Text = rawOBJ.RawMaterialCode.ToUpper();
            lblTmP.Text = rawOBJ.RawMaterialtypeName.ToUpper();
            lblProduct.Text = rawOBJ.code.ToUpper();
            lblLot.Text = rawOBJ.lotNumber.ToUpper();
            lblNetWeigth.Text = rawOBJ.netWeigth.ToString();
            lblGrossWeigth2.Text = rawOBJ.grossWeigth.ToString();
        }

        public frmMessageRM(clsMillPallet reprocessOBJ)
        {
            InitializeComponent();
            this.reprocessOBJ = reprocessOBJ;
            this.isRaw = false;
            fillMill();
        }

        private void fillMill()
        {
            //label1.Text = reprocessOBJ.RawMaterialCode.ToUpper();
            //lblTmP.Text = reprocessOBJ.RawMaterialtypeName.ToUpper();
            lblProduct.Text = reprocessOBJ.code.ToUpper();
            lblLot.Text = reprocessOBJ.lotNumber.ToUpper();
            lblNetWeigth.Text = reprocessOBJ.netWeigth.ToString();
            lblGrossWeigth2.Text = reprocessOBJ.grossWeigth.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isRaw)
            {
                if (fkFormulation == 0)
                {
                    //Guardar una nueva formulación
                    clsFormulation objFo = new clsFormulation();
                    objFo.fkBopp = fkBopp;
                    objFo.name = fName;
                    objFo.description = "";
                    objFo.thick = clsBopp.getThickByCodsec(fkBopp);
                    objFo.thickCentralLayer = 0;
                    objFo.thickLayerC1 = 0;
                    objFo.thickLayerC2 = 0;
                    objFo.fkCoating = fkFilmProduction;
                    var codsec = objFo.saveReload();

                    if (codsec > 0)
                        toSaveRaw(codsec);
                }
                else
                {
                    //Update de todas la formula
                    toSaveRaw(fkFormulation);
                }
            }
            else
            {
                //Guardar en la capa Reprocesado
            }
        }

        private void toSaveRaw(int fkFormulation)
        {
            clsRawMaterialByFormulation objRW = new clsRawMaterialByFormulation();
            objRW.fkRawMaterial = rawOBJ.fkRawMaterialtype;
            objRW.fkFormulation = fkFormulation;
            objRW.percentage = 0;

            if (layer == "CL-DMT")
            {
                objRW.CentralLayer = true;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
            }

            if (layer == "L1-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = true;
                objRW.layerC2 = false;
            }

            if (layer == "L2-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = true;
            }

            objRW.weigth = rawOBJ.netWeigth;
            objRW.lotnumber = rawOBJ.lotNumber;
            objRW.isSummary = false;
            objRW.fkRaw = rawOBJ.codsec;

            if (objRW.saveReaload())
            {
                //Cambiar el estado del Pallet
                if (clsRawMaterialbyCoilCellar.setTransferMR(rawOBJ.codsec.ToString()))
                    isValidProcess = true;
                else
                    isValidProcess = false;
            }
            else
                isValidProcess = false;

            //Calcular Summary

            clsSummaryRM.getSummary(objRW);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNWeight.Visible = true;
            lblNetWeigth.Visible = false;
            btnCancel.Visible = false;
            btnOk.Visible = false;

            btnOKN.BringToFront();
            txtNWeight.BringToFront();
            txtNWeight.Text = "0.0";
            txtNWeight.Focus();
        }

        private void btnOKN_Click(object sender, EventArgs e)
        {
            if (isRaw)
            {
                if (txtNWeight.Text.Length > 0 && Convert.ToDouble(txtNWeight.Text) > 0)
                {
                    if (fkFormulation == 0)
                    {
                        //Guardar una nueva formulación
                        clsFormulation objFo = new clsFormulation();
                        objFo.fkBopp = fkBopp;
                        objFo.name = fName;
                        objFo.description = "";
                        objFo.thick = clsBopp.getThickByCodsec(fkBopp);
                        objFo.thickCentralLayer = 0;
                        objFo.thickLayerC1 = 0;
                        objFo.thickLayerC2 = 0;
                        objFo.fkCoating = fkFilmProduction;
                        var codsec = objFo.saveReload();

                        if (codsec > 0)
                            toSaveReProRaw(codsec);
                    }
                    else
                    {
                        //Update de todas la formula
                        toSaveReProRaw(fkFormulation);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor mayor a 0");
                    txtNWeight.Focus();
                }
            }
        }

        private void toSaveReProRaw(int codsec)
        {
            string result = "";
            result = clsReProcessMP.toSveReProcessMP(rawOBJ, Convert.ToDouble(txtNWeight.Text), lblGrossWeigth2.Text, layer, codsec);

            if (!string.IsNullOrEmpty(result))
            {
                var message = result.Split(';');
                MessageBox.Show("Se procederá a la impresión de la etiqueta del pallet");
                clsPrintLabels.printReRawLabel(message[1].ToString());
                isValidProcess = true;
            }
            else
                isValidProcess = false;
        }

        private void txtNWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Random rdn = new Random();
                rdn.Next(17, 20);

                if (txtNWeight.Text.Length > 0)
                {
                    var al = Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()));
                    lblGrossWeigth2.Text = (Convert.ToDouble(txtNWeight.Text) + al).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
