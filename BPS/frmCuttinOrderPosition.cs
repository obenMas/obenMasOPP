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
    public partial class frmCuttinOrderPosition : Form
    {
        public int codsec = 0;
        public double withtotal = 0;

        List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
        clsMachine objCutterMachine = new clsMachine();


        public frmCuttinOrderPosition()
        {
            InitializeComponent();
        }

        public frmCuttinOrderPosition(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            objCutterMachine.load(codsec, "Cutter");
        }

        private void frmCuttinOrderPosition_Load(object sender, EventArgs e)
        {
            //FillCuttingListData();
            //lstCuttingOrder = new List<clsCuttingOrder>();
        }

        //private void FillCuttingListData()
        //{
        //    lstCuttingOrder = clsCuttingOrder.getCuttingOrderListByMachine(objCutterMachine.codsec);
        //    dgvCuttingOrder.Rows.Clear();
        //    for (int i = 0; i < lstCuttingOrder.Count; i++)
        //    {
        //        if (lstCuttingOrder[i].isSecundaryCut == false)
        //        {
        //            dgvCuttingOrder.Rows.Add();
        //            dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
        //            dgvCuttingOrder.Rows[i].Cells[clmmachine.Index].Value = lstCuttingOrder[i].machineName;
        //            if (lstCuttingOrder[i].fkBopp > 0)
        //                dgvCuttingOrder.Rows[i].Cells[clmfilm.Index].Value = new clsBopp(lstCuttingOrder[i].fkBopp).code.Replace("-", "");
        //            else
        //                dgvCuttingOrder.Rows[i].Cells[clmfilm.Index].Value = new clsCast(lstCuttingOrder[i].fkCast).code.Replace("-", "");
        //            dgvCuttingOrder.Rows[i].Cells[clmNumber.Index].Value = lstCuttingOrder[i].number;
        //            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
        //            for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
        //            {
        //                dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
        //                this.withtotal += Math.Round(lstCuttingOrder[i].lstCuttingOrderDetail[j].width, 2);
        //                if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
        //                    dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " + ";
        //            }
        //            dgvCuttingOrder.Rows[i].Cells[clmwidth.Index].Value = this.withtotal.ToString();
        //            this.withtotal = 0;
        //            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " ]";
        //            dgvCuttingOrder.Rows[i].Cells[clmdate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
        //            if (lstCuttingOrder[i].fkStatus == 25)
        //            {
        //                for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
        //                    dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;
        //            }
        //            dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = false;
        //        }
        //        else
        //        {
        //            dgvCuttingOrder.Rows.Add();
        //            dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
        //            dgvCuttingOrder.Rows[i].Cells[clmmachine.Index].Value = lstCuttingOrder[i].machineName;
        //            dgvCuttingOrder.Rows[i].Cells[clmfilm.Index].Value = lstCuttingOrder[i].productCode;
        //            dgvCuttingOrder.Rows[i].Cells[clmNumber.Index].Value = lstCuttingOrder[i].number;
        //            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
        //            for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
        //            {
        //                dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
        //                this.withtotal += Math.Round(lstCuttingOrder[i].lstCuttingOrderDetail[j].width, 2);
        //                if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
        //                    dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " + ";
        //            }
        //            dgvCuttingOrder.Rows[i].Cells[clmwidth.Index].Value = this.withtotal.ToString();
        //            this.withtotal = 0;
        //            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " ]";
        //            dgvCuttingOrder.Rows[i].Cells[clmdate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
        //            if (lstCuttingOrder[i].fkStatus == 25)
        //            {
        //                for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
        //                    dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;
        //            }
        //            else if (lstCuttingOrder[i].fkStatus == 24)
        //            {
        //                for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
        //                    dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);
        //            }
        //            else if (lstCuttingOrder[i].fkStatus == 31)
        //            {
        //                for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
        //                    dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);
        //            }
        //            dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = true;
        //        }
        //    }
        //}

        private void btnUnfilter_Click(object sender, EventArgs e)
        {
            dtpInitDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dgvCuttingOrder.Rows.Clear();
            //FillCuttingListData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
            {
                FillCuttingListDataByFilter(dtpInitDate.Value, dtpEndDate.Value);
            }
            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                MessageBox.Show("Las fechas de los tiempos muertos no pueden ser iguales por favor cambie las fechas", "Combinaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                MessageBox.Show("La fecha inicio del tiempo muerto no pueden ser mayor que la fecha fin del tiempo muerto", "Combinaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }   

        private void FillCuttingListDataByFilter(DateTime initdate, DateTime enddate)
        {
            lstCuttingOrder = new List<clsCuttingOrder>();
            lstCuttingOrder = clsCuttingOrder.getCuttingOrderListByMachienAndDate(objCutterMachine.codsec, dtpInitDate.Value, dtpEndDate.Value);
            dgvCuttingOrder.Rows.Clear();
            if (lstCuttingOrder.Count > 0)
            {
                for (int i = 0; i < lstCuttingOrder.Count; i++)
                {
                    if (lstCuttingOrder[i].isSecundaryCut == false)
                    {
                        dgvCuttingOrder.Rows.Add();
                        dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
                        dgvCuttingOrder.Rows[i].Cells[clmmachine.Index].Value = lstCuttingOrder[i].machineName;
                        dgvCuttingOrder.Rows[i].Cells[clmfilm.Index].Value = new clsBopp(lstCuttingOrder[i].fkBopp).code.Replace("-", "");
                        dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
                        for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
                        {
                            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
                            this.withtotal += Math.Round(lstCuttingOrder[i].lstCuttingOrderDetail[j].width, 2);
                            if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
                                dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " + ";
                        }
                        dgvCuttingOrder.Rows[i].Cells[clmwidth.Index].Value = this.withtotal.ToString();
                        this.withtotal = 0;
                        dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " ]";
                        dgvCuttingOrder.Rows[i].Cells[clmdate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
                        if (lstCuttingOrder[i].fkStatus == 25)
                        {
                            for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                                dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = false;
                    }
                    else
                    {
                        dgvCuttingOrder.Rows.Add();
                        dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrder[i].codsec;
                        dgvCuttingOrder.Rows[i].Cells[clmmachine.Index].Value = lstCuttingOrder[i].machineName;
                        dgvCuttingOrder.Rows[i].Cells[clmfilm.Index].Value = lstCuttingOrder[i].productCode;
                        dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value = " " + lstCuttingOrder[i].positions.ToString() + " [ ";
                        for (int j = 0; j < lstCuttingOrder[i].lstCuttingOrderDetail.Count; j++)
                        {
                            dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += lstCuttingOrder[i].lstCuttingOrderDetail[j].width.ToString();
                            this.withtotal += Math.Round(lstCuttingOrder[i].lstCuttingOrderDetail[j].width, 2);
                            if (j < lstCuttingOrder[i].lstCuttingOrderDetail.Count - 1)
                                dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " + ";
                        }
                        dgvCuttingOrder.Rows[i].Cells[clmwidth.Index].Value = this.withtotal.ToString();
                        this.withtotal = 0;
                        dgvCuttingOrder.Rows[i].Cells[clmpositions.Index].Value += " ]";
                        dgvCuttingOrder.Rows[i].Cells[clmdate.Index].Value = lstCuttingOrder[i].createdDate.ToShortDateString();
                        if (lstCuttingOrder[i].fkStatus == 25)
                        {
                            for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                                dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        else if (lstCuttingOrder[i].fkStatus == 24)
                        {
                            for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                                dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);
                        }
                        else if (lstCuttingOrder[i].fkStatus == 31)
                        {
                            for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                                dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(128, 255, 128);
                        }
                        dgvCuttingOrder.Rows[i].Cells[clmIsSecundaryCut.Index].Value = true;
                    }
                }
            }
            else
                MessageBox.Show("No existen datos con esa fecha", "Combinaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
