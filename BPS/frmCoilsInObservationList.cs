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
    public partial class frmCoilsInObservationList : Form
    {

        private string getDefects(List<bool> lstDefects)
        {
            string strDefects = "";
            List<string> lstDefectNames = new List<string>()	
            {
	            "Acampanada",
	            "Acanalada",
	            "Arrugas",
	            "Bobina Floja",
	            "Bloqueo",
	            "Borde Flojo",
	            "Punto Duro",
	            "Contaminación",
	            "Curvatura",
	            "Tensionado",
	            "Estrias",
	            "Mal corte c.",
	            "Orilla caida",
	            "Trensas",
	            "Salientes",
	            "Telescopiado"
            };

            for (int i = 0; i < lstDefects.Count; i++)
            {
                if (lstDefects[i])
                    strDefects += lstDefectNames[i] + "; ";
            }

            if (strDefects.Length > 0)
                strDefects = strDefects.Substring(0, strDefects.Length - 2);

            return strDefects;
        }

        public frmCoilsInObservationList()
        {
            InitializeComponent();
        }

        private void loadCoilGrid()
        {
            List<clsCoil> lstCoil = clsCoil.getObservationCoilList();

            dgvCoils.Rows.Clear();

            for (int i = 0; i < lstCoil.Count; i++)
            {
                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = lstCoil[i].codsec;
                dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = lstCoil[i].code;
                dgvCoils.Rows[i].Cells[clmCoilProduct.Index].Value = lstCoil[i].ProductCode.Replace("-", "");
                dgvCoils.Rows[i].Cells[clmCoilDestination.Index].Value = lstCoil[i].customerName + "[" + lstCoil[i].salesOrderNumber + "]";
                dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = lstCoil[i].length;
                dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = lstCoil[i].width;
                dgvCoils.Rows[i].Cells[clmCoilNetWeigth.Index].Value = Math.Round(lstCoil[i].netWeight, 2);
                dgvCoils.Rows[i].Cells[clmCoilDensity.Index].Value = Math.Round(lstCoil[i].density, 3);
                dgvCoils.Rows[i].Cells[clmCoilQuality.Index].Value = lstCoil[i].CuttingQualityName;
                dgvCoils.Rows[i].Cells[clmCoilDefects.Index].Value = getDefects(lstCoil[i].lstDefects);

                if (lstCoil[i].wasAuthorized)
                    dgvCoils.Rows[i].Cells[clmCoilApprove.Index].Value = global::BPS.Properties.Resources.accept;
                else
                    dgvCoils.Rows[i].Cells[clmCoilApprove.Index].Value = global::BPS.Properties.Resources.clear;

                if (lstCoil[i].wasCutted)
                    dgvCoils.Rows[i].Cells[clmCoilSecundaryCut.Index].Value = global::BPS.Properties.Resources.coilSecundaryCut;
                else
                    dgvCoils.Rows[i].Cells[clmCoilSecundaryCut.Index].Value = global::BPS.Properties.Resources.clear;

                if(lstCoil[i].wasRewined)
                    dgvCoils.Rows[i].Cells[clmCoilRewind.Index].Value = global::BPS.Properties.Resources.rewind;
                else
                    dgvCoils.Rows[i].Cells[clmCoilRewind.Index].Value = global::BPS.Properties.Resources.clear;

                if (lstCoil[i].wasMilled)
                    dgvCoils.Rows[i].Cells[clmCoilMill.Index].Value = global::BPS.Properties.Resources.coilMill1;
                else
                    dgvCoils.Rows[i].Cells[clmCoilMill.Index].Value = global::BPS.Properties.Resources.clear;

            }

        }

        private void frmCoilsInObservationList_Load(object sender, EventArgs e)
        {
            loadCoilGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCoils_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                    dgvCoils.Rows[e.RowIndex].Cells[clmCoilApprove.Index].Value = global::BPS.Properties.Resources.accept;

                    if (MessageBox.Show("Desea aprobar el cambio de calidad de la bobina?\n\nAl aprobar el cambio de calidad se enviará automáticamente la bobina a la bodega de empaque.", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));

                        objCoil.fkCuttingQuality = clsCuttingQuality.getQualityByName("Primera").codsec;
                        objCoil.save();

                        if (clsCoil.ChangeQuality(objCoil.codsec))
                        {
                            clsCoil.transferCoilTo(objCoil.codsec, clsCoilCellar.getCellarByName("Empaque").codsec);
                        }

                        loadCoilGrid();

                        MessageBox.Show("La bobina ha sido autorizada para empaque", "Detalle de bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                    {
                        dgvCoils.Rows[e.RowIndex].Cells[clmCoilApprove.Index].Value = global::BPS.Properties.Resources.clear;
                    }
                    break;
                case 11:
                    dgvCoils.Rows[e.RowIndex].Cells[clmCoilSecundaryCut.Index].Value = global::BPS.Properties.Resources.coilSecundaryCut;

                    if (MessageBox.Show("Desea destinar la bobina para corte secundario?", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsCoil.setCoilReprocess(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value), false, true, false);
                        loadCoilGrid();
                    }
                    else
                    {
                        dgvCoils.Rows[e.RowIndex].Cells[clmCoilSecundaryCut.Index].Value = global::BPS.Properties.Resources.clear;
                    }
                    break;
                case 13:
                    dgvCoils.Rows[e.RowIndex].Cells[clmCoilRewind.Index].Value = global::BPS.Properties.Resources.rewind;

                    if (MessageBox.Show("Desea destinar la bobina para ser rebobinada?", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsCoil.setCoilReprocess(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value), true, false, false);
                        loadCoilGrid();
                    }
                    else
                    {
                        dgvCoils.Rows[e.RowIndex].Cells[clmCoilRewind.Index].Value = global::BPS.Properties.Resources.clear;
                    }
                    break;
                case 15:
                    dgvCoils.Rows[e.RowIndex].Cells[clmCoilMill.Index].Value = global::BPS.Properties.Resources.coilMill1;

                    if (MessageBox.Show("Desea destinar la bobina a ser enviada al molino?.", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsCoil.setCoilReprocess(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value), false, false, true);
                        loadCoilGrid();
                    }
                    else
                    {
                        dgvCoils.Rows[e.RowIndex].Cells[clmCoilMill.Index].Value = global::BPS.Properties.Resources.clear;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
