using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Extruder
{
    public partial class frmMessage : Form
    {
        private clsRawMaterialExtruder rawOBJ;

        private bool isRaw = true;
        private int fkFormulation = 0, fkBopp = 0, fkFilmProduction = 0;
        private string layer = string.Empty, fName = string.Empty;
        public bool isValidProcess { get; set; }

        #region Inicio Raw Material Extruder
        public frmMessage()
        {
            InitializeComponent();
        }

        public frmMessage(clsRawMaterialExtruder rawOBJ, int fkBopp, int fkFilmProduction, string fName, string layer)
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

        public frmMessage(clsRawMaterialExtruder rawOBJ, int fkFormulation, string layer)
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
            label1.Text = rawOBJ.MaterialCode.ToUpper();
            lblTmP.Text = rawOBJ.MaterialName.ToUpper();
            lblProduct.Text = rawOBJ.code.ToUpper();
            lblLot.Text = rawOBJ.lotNumber.ToUpper();
            lblNetWeigth.Text = rawOBJ.netWeigth.ToString();
        }
        #endregion

        #region Consumir todo el pallet
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
                    //Update de todas la formula
                    toSaveRaw(fkFormulation);
            }
            else
            {
                //Guardar en la capa Reprocesado
            }

          
        }

        private void toSaveRaw(int fkFormulation)
        {
            clsRawMaterialByFormulation objRW = new clsRawMaterialByFormulation();
            objRW.fkRawMaterial = rawOBJ.fkMaterial;
            objRW.fkFormulation = fkFormulation;
            objRW.percentage = 0;

            if (layer == "CL-DMT" || layer == "CL-MW")
            {
                objRW.CentralLayer = true;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (layer == "L1-DMT" || layer == "S1-MW")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = true;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (layer == "L2-DMT" || layer == "S2-MW")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = true;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (layer == "L3-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = false; 
                objRW.layerC3 = true;
                objRW.layerC4 = false;
            }

            if (layer == "L4-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = true;
            }

            objRW.weigth = rawOBJ.netWeigth;
            objRW.lotnumber = rawOBJ.lotNumber;
            objRW.isSummary = false;
            objRW.fkRaw = rawOBJ.codsec;

            if (objRW.saveReaload())
            {
                //Cambiar el estado del Pallet
                if (clsRawMaterialExtruder.setTransferMR(rawOBJ.codsec.ToString()))
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

        #endregion

        #region Consumir el pallet parcial
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
                        objFo.thickLayerC3 = 0;
                        objFo.thickLayerC4 = 0;
                        objFo.fkCoating = fkFilmProduction;
                        var codsec = objFo.saveReload();

                        if (codsec > 0)
                            toSaveReProRaw(codsec);
                    }
                    else
                        //Update de todas la formula
                        toSaveReProRaw(fkFormulation);

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
            result = clsReProcessMP.toSaveReProcessMP(rawOBJ, Convert.ToDouble(txtNWeight.Text), layer, codsec);

            if (!string.IsNullOrEmpty(result))
            {
                //MessageBox.Show("Se procederá a la impresión de la Etiqueta del Pallet Parcial");
                //clsPrintLabels.printReRawLabel(result.ToString());
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
        #endregion
    }
}
