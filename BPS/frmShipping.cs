using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmShipping : Form
    {
        public DateTime selectedestimateddate = DateTime.Now;
        public DateTime selectedreleasedate = DateTime.Now;
        public DateTime selectedpledge = DateTime.Now;
        public DateTime selectedvapor = DateTime.Now;
        public DateTime selectedthermal = DateTime.Now;
        public int shippingbuilding = 0;
        List<clsShiping> lstShipping = new List<clsShiping>();
        List<clsShiping> lstShippingValidate = new List<clsShiping>();
        List<clsShiping> lstShippingData = new List<clsShiping>();
        clsVapor ObjVapor = new clsVapor();
        clsShiping ObjShipping = new clsShiping();
        clsSalesOrder ObjSalesOrder = new clsSalesOrder();
        public int selectedcodsecvapor = 0;

        public frmShipping()
        {
            InitializeComponent();
        }

        private void frmShipping_Load(object sender, EventArgs e)
        {
            FilldData();
        }

        private void FilldData()
        {
            lstShipping = clsShiping.getActiveListCompleteInternationalSalesOrder();
            dgvInternatinalSales.Rows.Clear();
            if (lstShipping.Count > 0)
            {
                for (int i = 0; i < lstShipping.Count; i++)
                {
                    dgvInternatinalSales.Rows.Add();
                    dgvInternatinalSales.Rows[i].Cells[clmcodsec.Index].Value = lstShipping[i].codsec.ToString();
                    dgvInternatinalSales.Rows[i].Cells[clmcontinernumber.Index].Value = lstShipping[i].containernum.ToString();
                    dgvInternatinalSales.Rows[i].Cells[clmvalidateshipping.Index].Value = 0;
                    dgvInternatinalSales.Rows[i].Cells[clmdatecustomer.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmdateshop.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmdatethermal.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmdatevapor.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmentity.Index].Value = lstShipping[i].name.ToString();
                    dgvInternatinalSales.Rows[i].Cells[clmestimatedate.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmnumber.Index].Value = lstShipping[i].salesnumber.ToString();
                    dgvInternatinalSales.Rows[i].Cells[clmshippingbuilding.Index].Value = "";
                    dgvInternatinalSales.Rows[i].Cells[clmvalidate.Index].Value = 0;
                    dgvInternatinalSales.Rows[i].Cells[clmcontainer.Index].Value = lstShipping[i].salestransport.ToString();
                    if (lstShipping[i].shippinghide == false)
                    {
                        dgvInternatinalSales.Rows[i].Cells[clmenable.Index].Value = global::BPS.Properties.Resources.bullet_green;
                        dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value = 0;
                    }
                }

                for (int i = 0; i < lstShipping.Count; i++)
                {
                    lstShippingValidate = clsShiping.getCompareList(lstShipping[i].codsec);
                    if (lstShippingValidate.Count > 0)
                    {

                        dgvInternatinalSales.Rows[i].Cells[clmvalidateshipping.Index].Value = lstShippingValidate[0].codsec;
                        dgvInternatinalSales.Rows[i].Cells[clmestimatedate.Index].Value = lstShippingValidate[0].estimatedate.ToString("dd/MM/yyyy");
                        dgvInternatinalSales.Rows[i].Cells[clmdateshop.Index].Value = lstShippingValidate[0].releasedate.ToString("dd/MM/yyyy");
                        dgvInternatinalSales.Rows[i].Cells[clmdatecustomer.Index].Value = lstShippingValidate[0].customerdate.ToString("dd/MM/yyyy");
                        dgvInternatinalSales.Rows[i].Cells[clmdatevapor.Index].Value = lstShippingValidate[0].vapor.ToString("dd/MM/yyyy");
                        dgvInternatinalSales.Rows[i].Cells[clmdatethermal.Index].Value = lstShippingValidate[0].thermal.ToString("dd/MM/yyyy");
                        dgvInternatinalSales.Rows[i].Cells[clmshippingbuilding.Index].Value = lstShippingValidate[0].vaporname;
                        dgvInternatinalSales.Rows[i].Cells[clmshippingvaporcodsec.Index].Value = lstShippingValidate[0].fkvapor;
                        dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value = lstShippingValidate[0].shippinghide;

                        for (int h = 0; h < dgvInternatinalSales.ColumnCount - 4; h++)
                            dgvInternatinalSales.Rows[i].Cells[h].Style.BackColor = Color.LightGreen;


                    }
                }
            }
        }

        private void dgvInternatinalSales_KeyDown(object sender, KeyEventArgs e)
        {
            if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 4) && e.KeyCode == Keys.F4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "estimateddate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmestimatedate.Index].Value = selectedestimateddate.ToString("dd/MM/yyyy");
            }
            else if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 5) && e.KeyCode == Keys.F4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "releasedate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdateshop.Index].Value = selectedreleasedate.ToString("dd/MM/yyyy");
            }
            else if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 6) && e.KeyCode == Keys.F4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "pledgedate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatecustomer.Index].Value = selectedpledge.ToString("dd/MM/yyyy");
            }
            else if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 9) && e.KeyCode == Keys.F4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "vapordate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatevapor.Index].Value = selectedvapor.ToString("dd/MM/yyyy");
            }
            else if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 10) && e.KeyCode == Keys.F4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "thermaldate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatethermal.Index].Value = selectedthermal.ToString("dd/MM/yyyy");
            }
            else if ((dgvInternatinalSales.CurrentCell.ColumnIndex == 11) && e.KeyCode == Keys.F4)
            {
                ObjVapor = new clsVapor();
                frmVaporesComplete winVaporesComplete = new frmVaporesComplete(this);
                winVaporesComplete.ShowDialog(this);
                if (selectedcodsecvapor != 0)
                {
                    ObjVapor.load(selectedcodsecvapor);
                    dgvInternatinalSales.CurrentRow.Cells[clmshippingbuilding.Index].Value = ObjVapor.shippingbuilding;
                    lstShipping[dgvInternatinalSales.CurrentRow.Index].fkvapor = ObjVapor.codsec;
                    dgvInternatinalSales.CurrentRow.Cells[clmdatevapor.Index].Value = ObjVapor.estimatedate.ToString("dd/MM/yyyy");
                }
                else
                {
                    dgvInternatinalSales.CurrentRow.Cells[clmshippingbuilding.Index].Value = "No seleccionado";
                    lstShipping[dgvInternatinalSales.CurrentRow.Index].fkvapor = 0;
                    MessageBox.Show("Debe seleccionar una naviera", "Navieras -  Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvInternatinalSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmCalendar winCalendar = new frmCalendar(this, "estimateddate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmestimatedate.Index].Value = selectedestimateddate.ToString("dd/MM/yyyy");
            }
            else if (e.ColumnIndex == 5)
            {
                frmCalendar winCalendar = new frmCalendar(this, "releasedate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdateshop.Index].Value = selectedreleasedate.ToString("dd/MM/yyyy");
            }
            else if (e.ColumnIndex == 6)
            {
                frmCalendar winCalendar = new frmCalendar(this, "pledgedate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatecustomer.Index].Value = selectedpledge.ToString("dd/MM/yyyy");
            }
            else if (e.ColumnIndex == 9)
            {
                frmCalendar winCalendar = new frmCalendar(this, "vapordate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatevapor.Index].Value = selectedvapor.ToString("dd/MM/yyyy");
            }
            else if (e.ColumnIndex == 10)
            {
                frmCalendar winCalendar = new frmCalendar(this, "thermaldate");
                winCalendar.ShowDialog(this);
                dgvInternatinalSales.CurrentRow.Cells[clmdatethermal.Index].Value = selectedthermal.ToString("dd/MM/yyyy");
            }
            else if (e.ColumnIndex == 11)
            {
                ObjVapor = new clsVapor();
                frmVaporesComplete winVaporesComplete = new frmVaporesComplete(this);
                winVaporesComplete.ShowDialog(this);
                if (selectedcodsecvapor != 0)
                {
                    ObjVapor.load(selectedcodsecvapor);
                    dgvInternatinalSales.CurrentRow.Cells[clmshippingbuilding.Index].Value = ObjVapor.shippingbuilding;
                    lstShipping[dgvInternatinalSales.CurrentRow.Index].fkvapor = ObjVapor.codsec;
                    dgvInternatinalSales.CurrentRow.Cells[clmdatevapor.Index].Value = ObjVapor.estimatedate.ToString("dd/MM/yyyy");
                }
                else
                {
                    dgvInternatinalSales.CurrentRow.Cells[clmshippingbuilding.Index].Value = "No seleccionado";
                    lstShipping[dgvInternatinalSales.CurrentRow.Index].fkvapor = 0;
                    MessageBox.Show("Debe seleccionar una naviera", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (e.ColumnIndex == 12)
            {
                if (dgvInternatinalSales.Rows[e.RowIndex].Cells[clmestimatedate.Index].Value.ToString() != "" && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdateshop.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatecustomer.Index].Value.ToString() != "" && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatevapor.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatethermal.Index].Value.ToString() != string.Empty && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmshippingbuilding.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmshippingbuilding.Index].Value.ToString() != "No seleccionado")
                {
                    if (Convert.ToInt32(dgvInternatinalSales.CurrentRow.Cells[clmenablevalidation.Index].Value) == 0)
                    {
                        dgvInternatinalSales.CurrentRow.Cells[clmenable.Index].Value = global::BPS.Properties.Resources.bullet_red;
                        dgvInternatinalSales.CurrentRow.Cells[clmenablevalidation.Index].Value = 1;
                    }
                    else
                    {
                        dgvInternatinalSales.CurrentRow.Cells[clmenable.Index].Value = global::BPS.Properties.Resources.bullet_green;
                        dgvInternatinalSales.CurrentRow.Cells[clmenablevalidation.Index].Value = 0;
                    }
                }
                else
                    MessageBox.Show("Debe llenar todos los campos requeridos", "Naviera - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInternatinalSales_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvInternatinalSales.ColumnCount; i++)
            {
                if (dgvInternatinalSales.Rows[e.RowIndex].Cells[clmestimatedate.Index].Value.ToString() != "" && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdateshop.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatecustomer.Index].Value.ToString() != "" && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatevapor.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmdatethermal.Index].Value.ToString() != string.Empty && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmshippingbuilding.Index].Value.ToString() != ""
                    && dgvInternatinalSales.Rows[e.RowIndex].Cells[clmshippingbuilding.Index].Value.ToString() != "No seleccionado")
                {
                    dgvInternatinalSales.Rows[e.RowIndex].Cells[clmvalidate.Index].Value = 1;
                    break;
                }
            }
        }

        private void btnSaveShipping_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInternatinalSales.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value) == 1)
                {
                    MessageBox.Show("Las ordenes que se encuentran con color rojo se cerrar automáticamente no se volverán a mostrar", "Navieras -  Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
            }

            for (int i = 0; i < dgvInternatinalSales.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmvalidate.Index].Value) == 1 && (Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmvalidateshipping.Index].Value) == 0))
                {
                    //save
                    ObjShipping.fksalesorder = Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmcodsec.Index].Value);
                    ObjShipping.fkvapor = lstShipping[i].fkvapor;
                    ObjShipping.estimatedate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmestimatedate.Index].Value);
                    ObjShipping.releasedate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdateshop.Index].Value);
                    ObjShipping.customerdate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatecustomer.Index].Value);
                    ObjShipping.vapor = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatevapor.Index].Value);
                    ObjShipping.thermal = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatethermal.Index].Value);
                    ObjShipping.shippinghide = Convert.ToBoolean(dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value);
                    if (!ObjShipping.save())
                    {
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                    }
                }
                else if (Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmvalidate.Index].Value) == 1 && (Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmvalidateshipping.Index].Value) != 0))
                {
                    //update
                    ObjShipping.codsec = Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmvalidateshipping.Index].Value);
                    ObjShipping.fksalesorder = Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmcodsec.Index].Value);
                    ObjShipping.fkvapor = Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmshippingvaporcodsec.Index].Value);
                    ObjShipping.estimatedate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmestimatedate.Index].Value);
                    ObjShipping.releasedate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdateshop.Index].Value);
                    ObjShipping.customerdate = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatecustomer.Index].Value);
                    ObjShipping.vapor = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatevapor.Index].Value);
                    ObjShipping.thermal = Convert.ToDateTime(dgvInternatinalSales.Rows[i].Cells[clmdatethermal.Index].Value);
                    if (Convert.ToBoolean(dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value) == false)
                        ObjShipping.shippinghide = Convert.ToBoolean(dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value);
                    else
                    {
                        ObjShipping.shippinghide = Convert.ToBoolean(dgvInternatinalSales.Rows[i].Cells[clmenablevalidation.Index].Value);
                        ObjSalesOrder.loadWithoutShipping(Convert.ToInt32(dgvInternatinalSales.Rows[i].Cells[clmcodsec.Index].Value));
                        ObjSalesOrder.fkStatus = 12;
                        ObjSalesOrder.hide = true;
                        if (!ObjSalesOrder.updateforshipping())
                        {
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            break;
                        }
                    }
                    if (!ObjShipping.save())
                    {
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            MessageBox.Show("Datos guardados correctamente", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FilldData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvInternatinalSales.Rows.Count > 0)
            {
                frmShippingReportOLD winShipping = new frmShippingReportOLD();
                winShipping.StartPosition = FormStartPosition.Manual;
                winShipping.MdiParent = this.MdiParent;
                winShipping.Show();
            }
            else
                MessageBox.Show("No existen Ordenes Internacionales pendientes", "Navieras - Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
