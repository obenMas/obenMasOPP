using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmMetalizeOrderList : Form
    {
        public int codsec = 0, fkFilmProductionPlan = 0;
        public bool isAutoricet = false;
        public int plant = 0;

        public frmMetalizeOrderList()
        {
            if (CheckOrder())
            {
                isAutoricet = true;
                InitializeComponent();
            }
            else
            {
                isAutoricet = false;
                MessageBox.Show("No existen ordenes de metalizado activas", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                this.Close();
            }
        }

        public frmMetalizeOrderList(int fkplant)
        {
            plant=fkplant;
            if (CheckOrder())
            {
                isAutoricet = true;
                InitializeComponent();
            }
            else
            {
                isAutoricet = false;
                MessageBox.Show("No existen ordenes de metalizado activas", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                this.Close();
            }
        }

        private bool CheckOrder()
        {
            if(plant==0)
            {
                List<clsProductionOrderMetal> lstMetal = new List<clsProductionOrderMetal>();
                lstMetal = clsProductionOrderMetal.getActiveList();
                if (lstMetal.Count > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                List<clsProductionOrderMetal> lstMetal = new List<clsProductionOrderMetal>();
                lstMetal = clsProductionOrderMetal.getActiveList(plant);
                if (lstMetal.Count > 0)
                    return true;
                else
                    return false;
            }
            
        }

        private void frmMetalizeOrderList_Load(object sender, EventArgs e)
        {
            PopulateOrder();
        }

        private void PopulateOrder()
        {
            try
            {
                List<clsProductionOrderMetal> lstMetal = new List<clsProductionOrderMetal>();
                if(plant==0)
                {
                    lstMetal = clsProductionOrderMetal.getActiveList();
                }
                else
                {
                    lstMetal = clsProductionOrderMetal.getActiveList(plant);
                }
                
                if (lstMetal.Count > 0)
                {
                    for (int i = 0; i < lstMetal.Count; i++)
                    {
                        dgvMetalizeOrder.Rows.Add();
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecodsec.Index].Value = lstMetal[i].codsec;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproductbase.Index].Value = lstMetal[i].BoppFrom;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproductmetalize.Index].Value = lstMetal[i].BoppTo;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizewidthbase.Index].Value = lstMetal[i].widthFrom;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizewidthmetalize.Index].Value = lstMetal[i].widthTo;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeorder.Index].Value = lstMetal[i].number;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizelot.Index].Value = lstMetal[i].lotNumber;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecustomer.Index].Value = lstMetal[i].Customer;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizenotes.Index].Value = lstMetal[i].notes;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value = lstMetal[i].fkStatus;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecoilnumber.Index].Value = lstMetal[i].Coil;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedfkfilmproductionplanmetal.Index].Value = lstMetal[i].fkFilmProductionOrderMetal;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizefkstatus.Index].Value = (lstMetal[i].fkStatus == 46) ? global::BPS.Lite.Properties.Resources.MStop : (lstMetal[i].fkStatus == 1069) ? global::BPS.Lite.Properties.Resources.MPause : global::BPS.Lite.Properties.Resources.MPlay;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedviewer.Index].Value = (lstMetal[i].fkStatus == 1066) ? global::BPS.Lite.Properties.Resources.metallized : global::BPS.Lite.Properties.Resources.clear;
                        if (GetTypeOrder(lstMetal[i].BoppTo))
                            dgvMetalizeOrder.Rows[i].Cells[clmmetalizedtype.Index].Value = "Maquile";
                        else
                            dgvMetalizeOrder.Rows[i].Cells[clmmetalizedtype.Index].Value = "Coil";
                        codsec = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool GetTypeOrder(string BoppTo)
        {
            if (BoppTo.StartsWith("MPVC") || BoppTo.StartsWith("MPS") || BoppTo.StartsWith("MPE"))
                return true;
            else
                return false;
        }

        private void dgvMetalizeOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblCustomer.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecustomer.Index].Value.ToString();
                lblLotNumber.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizelot.Index].Value.ToString();
                lblOrder.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizeorder.Index].Value.ToString();
                lblStatus.Text = (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedmystated.Index].Value.ToString() == "46") ? "Planificada" : "Proceso";
                lblNotes.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizenotes.Index].Value.ToString();
                lblProductFrom.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizeproductbase.Index].Value.ToString();
                lblProductTo.Text = dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizeproductmetalize.Index].Value.ToString();
                codsec = Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value);
                fkFilmProductionPlan = Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedfkfilmproductionplanmetal.Index].Value);
            }
        }

        private void dgvMetalizeOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmmetalizedviewer.Index)
            {
                if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedmystated.Index].Value.ToString() == "1066")
                {
                    frmMainCoilMetalized winMetal = new frmMainCoilMetalized(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value), dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedtype.Index].Value.ToString());
                    winMetal.MdiParent = this.MdiParent;
                    winMetal.StartPosition = FormStartPosition.CenterScreen;
                    winMetal.Show();
                    this.Close();
                }
            }
        }

        private void btnExtruder_Click(object sender, EventArgs e)
        {
            bool flgValidateProcess = true;
            try
            {
                if (codsec != 0)
                {
                    for (int i = 0; i < dgvMetalizeOrder.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value) == 1066)
                        {
                            flgValidateProcess = false;
                            break;
                        }
                    }
                    if (flgValidateProcess)
                    {
                        if (clsProductionOrderMetal.toProcessOrder(codsec, fkFilmProductionPlan,GenerateLotNumber()))
                        {
                            clsSequential.addSequential("metallizedOrder");
                            MessageBox.Show("Orden de Metalizado puesta en Proceso Correctamente!", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            clsProductionOrderMetal objOrder = new clsProductionOrderMetal();
                            objOrder.load(codsec);
                            frmMainCoilMetalized winMetal = new frmMainCoilMetalized(objOrder.codsec, (GetTypeOrder(objOrder.BoppTo) == true) ? "Maquile" : "Coil");
                            winMetal.MdiParent = this.MdiParent;
                            winMetal.Show();
                            codsec = 0;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al poner en ejecución la orden", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            lblCustomer.Text = "";
                            lblLotNumber.Text = "";
                            lblOrder.Text = "";
                            lblStatus.Text = "";
                            lblNotes.Text = "";
                            lblProductFrom.Text = "";
                            lblProductTo.Text = "";
                            codsec = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede ejecutar mas de una sola orden\r\nPor favor CIERRE la orden que se encuentra en PROCESO, para poder ejecutar la orden seleccionada", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        lblCustomer.Text = "";
                        lblLotNumber.Text = "";
                        lblOrder.Text = "";
                        lblStatus.Text = "";
                        lblNotes.Text = "";
                        lblProductFrom.Text = "";
                        lblProductTo.Text = "";
                        codsec = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una orden de metalizado para poder ejecutar la orden?", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    lblCustomer.Text = "";
                    lblLotNumber.Text = "";
                    lblOrder.Text = "";
                    lblStatus.Text = "";
                    lblNotes.Text = "";
                    lblProductFrom.Text = "";
                    lblProductTo.Text = "";
                    codsec = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerateLotNumber()
        {
            string myreturn = "";
            myreturn = DateTime.Now.ToString("yy") + "4" + clsGlobal.FillWithZeros(((new clsSequential().metallizedOrder).ToString()), 3);
            return myreturn;
        }
    }
}
