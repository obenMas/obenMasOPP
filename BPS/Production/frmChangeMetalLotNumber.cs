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
    public partial class frmChangeMetalLotNumber : Form
    {
        clsFilmProductionPlanMetal objFilmProductionPlanMetal = new clsFilmProductionPlanMetal();
        clsProductionOrderMetal objProductionOrderMetal = new clsProductionOrderMetal();

        public frmChangeMetalLotNumber()
        {
            InitializeComponent();
        }

        public frmChangeMetalLotNumber(int codsec)
        {
            InitializeComponent();
            objFilmProductionPlanMetal.load(codsec);
            lblLotOld.Text = objFilmProductionPlanMetal.lotNumber.ToString();
            txtLotNew.Text = objFilmProductionPlanMetal.lotNumber.ToString();
            txtWeigth.Text = objFilmProductionPlanMetal.productionOrderMetal.quantity.ToString();
            txtCoil.Text = objFilmProductionPlanMetal.productionOrderMetal.Coil.ToString();
            txtNotes.Text = objFilmProductionPlanMetal.notes;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool flgOk = true;
                objFilmProductionPlanMetal.lotNumber = txtLotNew.Text;
                objFilmProductionPlanMetal.coilsnumber = Convert.ToInt32(txtCoil.Text);
                objFilmProductionPlanMetal.notes = txtNotes.Text;
                if (objFilmProductionPlanMetal.ChangeLotNumber())
                {
                    objFilmProductionPlanMetal.productionOrderMetal.quantity = Convert.ToDouble(txtWeigth.Text);

                    if (objFilmProductionPlanMetal.productionOrderMetal.UpdateQuality())
                    {
                        List<clsMainCoilMetal> lstMainCoilMetal = new List<clsMainCoilMetal>();
                        lstMainCoilMetal = clsMainCoilMetal.getListByFilmProductionPlan(objFilmProductionPlanMetal.codsec);
                        for (int i = 0; i < lstMainCoilMetal.Count; i++)
                        {
                            clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal(lstMainCoilMetal[i].codsec);
                            objMainCoilMetal.lotNumber = txtLotNew.Text;
                            if (!objMainCoilMetal.toUpdateLotNumber())
                            {
                                flgOk = false;
                                break;
                            }
                        }
                        if (flgOk)
                        {
                            MessageBox.Show("Cambio de lote realizado correctamente", "Cambio Lote", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            this.Close();
                        }
                        else
                            MessageBox.Show("No se han cambiado los lotes en todas las bobinas hijas", "Cambio Lote", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cambio Lote", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
