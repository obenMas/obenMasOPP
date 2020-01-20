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
    public partial class frmEfficiencyDetails : Form
    {
        clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();
        private double consuptionP = 0, consuptionObs = 0;

        public frmEfficiencyDetails()
        {
            InitializeComponent();
        }

        public frmEfficiencyDetails(int codsec, string maincoil, double maincoilweigth)
        {
            InitializeComponent();
            objEfficiencyCutExtruder.load(codsec);
            lblmaincoilcode.Text = maincoil.ToUpper();
            lblmaincoilnetweigth.Text = Math.Round(maincoilweigth, 2, MidpointRounding.AwayFromZero).ToString();
            Populate(objEfficiencyCutExtruder);
        }

        private void Populate(clsEfficiencyCutExtruder objEfficiencyCutExtruder)
        {
            lbldecrease.Text = Math.Round(objEfficiencyCutExtruder.decrease, 2, MidpointRounding.AwayFromZero).ToString();
            lblrefile.Text = Math.Round(objEfficiencyCutExtruder.refile, 2, MidpointRounding.AwayFromZero).ToString();
            lblendrollo.Text = Math.Round(objEfficiencyCutExtruder.endroller, 2, MidpointRounding.AwayFromZero).ToString();
            for (int i = 0; i < objEfficiencyCutExtruder.coilList.Count; i++)
            {
                clsCoil objCoil = new clsCoil();
                objCoil.load(objEfficiencyCutExtruder.coilList[i]);
                dgvCoil.Rows.Add();
                dgvCoil.Rows[i].Cells[clmcodsec.Index].Value = objCoil.codsec;
                dgvCoil.Rows[i].Cells[clmcode.Index].Value = objCoil.code;
                dgvCoil.Rows[i].Cells[clmcutingposition.Index].Value = objCoil.cuttingPosition;
                dgvCoil.Rows[i].Cells[clmcuttingsto.Index].Value = objCoil.cuttingStop;
                dgvCoil.Rows[i].Cells[clmnetweigth.Index].Value = Math.Round(objCoil.netWeight, 2, MidpointRounding.AwayFromZero).ToString();
                dgvCoil.Rows[i].Cells[clmcutting.Index].Value = objCoil.cuttingDate.ToString("dd/MM/yyyy HH:mm:ss");
                dgvCoil.Rows[i].Cells[clmmaincoil.Index].Value = objCoil.mainCoilCode;
                dgvCoil.Rows[i].Cells[clmlotnumber.Index].Value = objCoil.lotNumber;
                dgvCoil.Rows[i].Cells[clmviewp.Index].Value = global::BPS.Properties.Resources.eye;

                if (objCoil.fkCuttingQuality == 1)
                {
                    consuptionP += objCoil.netWeight;
                    for (int j = 0; j < dgvCoil.Columns.Count; j++)
                        dgvCoil.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                }
                else
                {
                    consuptionObs += objCoil.netWeight;
                    for (int j = 0; j < dgvCoil.Columns.Count; j++)
                        dgvCoil.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                }
            }

            lblconsuption.Text = Math.Round(consuptionP, 2, MidpointRounding.AwayFromZero).ToString();
            lblconsuption.BackColor = Color.FromArgb(207, 234, 254);
            lblconsuptionobs.Text = Math.Round(consuptionObs, 2, MidpointRounding.AwayFromZero).ToString();
            lblconsuptionobs.BackColor = Color.FromArgb(232, 202, 244);

            if (objEfficiencyCutExtruder.splice == true)
            {
                lblmaincoilone.Text = objEfficiencyCutExtruder.spliceInitiCoil.ToUpper();
                lblmaincoiltwo.Text = objEfficiencyCutExtruder.spliceEndCoil.ToUpper();
                lblmaincoilthree.Text = objEfficiencyCutExtruder.spliceCoilThree.ToUpper();

                lbllegthone.Text = Math.Round(objEfficiencyCutExtruder.spliceInit, 2, MidpointRounding.AwayFromZero).ToString();
                lbllegthtwo.Text = Math.Round(objEfficiencyCutExtruder.spliceEnd, 2, MidpointRounding.AwayFromZero).ToString();
                lbllegththree.Text = Math.Round(objEfficiencyCutExtruder.spliceThree, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                groupBox3.Enabled = false;
                groupBox3.Visible = false;
            }

            if (objEfficiencyCutExtruder.waste > 0)
            {
                lblwastecoil.Text = objEfficiencyCutExtruder.wasteCoil.ToUpper();
                lblwastelegth.Text = Math.Round(objEfficiencyCutExtruder.waste, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                groupBox4.Enabled = false;
                groupBox4.Visible = false;
            }
        }

        private void dgvCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmviewp.Index)
            {
                frmCoilTraceability winCoil = new frmCoilTraceability(Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcodsec.Index].Value));
                winCoil.ShowDialog();
            }
        }
    }
}
