using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmFilmProductionPlan : Form
    {
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private string dragDropSource = "";
        private DateTime initDate = DateTime.Now;
        private bool hasInProductionOrder = false;

        public frmFilmProductionPlan()
        {
            InitializeComponent();
        }
        public void FillUnPlanedProductionOrders()
        {
            List<clsProductionOrder> lstProductionOrder = new List<clsProductionOrder>();
            List<clsFilter> lstFilters = new List<clsFilter>();
            lstFilters.Add(new clsFilter());
            lstFilters[lstFilters.Count-1].field = "pord_StatusName";
            lstFilters[lstFilters.Count-1].operation = "equal";
            lstFilters[lstFilters.Count-1].value = "Sin Planificar";
            lstFilters[lstFilters.Count - 1].dataType = "varchar";
            lstProductionOrder = clsProductionOrder.getListByFilter(lstFilters);
            dgvProductionOrders.Rows.Clear();

            for (int i = 0; i < lstProductionOrder.Count; i++)
            {
                dgvProductionOrders.Rows.Add();
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderCodsec.Index].Value = lstProductionOrder[i].codsec.ToString();
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderNumber.Index].Value = "---"; //lstProductionOrder[i].number.ToString();
                if (lstProductionOrder[i].fkBopp > 0)
                    dgvProductionOrders.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstProductionOrder[i].Bopp.code;
                if (lstProductionOrder[i].fkCast > 0)
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstProductionOrder[i].Cast.code;
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderWeight.Index].Value = lstProductionOrder[i].quantity.ToString();
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderCustomers.Index].Value = lstProductionOrder[i].customerLists;
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                dgvProductionOrders.Rows[i].Cells[clmProductionOrderCancel.Index].Value = global::BPS.Properties.Resources.cancel;
                if (lstProductionOrder[i].createdFromOtherOrder == true)
                {
                    for (int j = 0; j < dgvProductionOrders.ColumnCount; j++)
                        dgvProductionOrders.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                }
            }
        }

        private void frmMachineCalendar_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            dtpInitDate.CustomFormat = "dd/MM/yyyy    HH:mm:ss";
            lstMachines = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMachine.Items.Add(lstMachines[i]);
            FillUnPlanedProductionOrders();
        }

        private void fillPlanedProductionOrders()
        {
            clsFilmProductionPlan.setIddleTimeInFilmProductionPlan(((clsMachine)cmbMachine.SelectedItem).codsec);

            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            txtKPH.Text = "0";
            txtMainCoilWidth2.Text = "0";
            txtMainCoilWidth1.Text = "0";

            if (cmbMachine.SelectedIndex >= 0)
            {
                txtKPH.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.kilogramsPerHour.ToString();

                if (((clsMachine)cmbMachine.SelectedItem).Extruder.coilersNumbers.Count == 1)
                {
                    txtMainCoilWidth1.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.maxFilmWidth.ToString();
                    txtMainCoilWidth2.Text = "";
                    txtMainCoilWidth2.Enabled = false;
                    lblMaximumWidth.Enabled = false;
                }
                else
                {
                    txtMainCoilWidth1.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.maxFilmWidth.ToString();
                    txtMainCoilWidth2.Text = ((clsMachine)cmbMachine.SelectedItem).Extruder.maxFilmWidth.ToString();
                    txtMainCoilWidth2.Enabled = true;
                    lblMaximumWidth.Enabled = true;
                }
                

                lstFilmProductionPlan = clsFilmProductionPlan.getListOfActiveItemsByMachine(((clsMachine)cmbMachine.SelectedItem).codsec);

                dgvCalendar.Rows.Clear();
                hasInProductionOrder = false;
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                {
                    this.dgvCalendar.Rows.Add();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value = lstFilmProductionPlan[i].codsec.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarPONumber.Index].Value = (lstFilmProductionPlan[i].productionOrderNumber == 0) ? "---" : lstFilmProductionPlan[i].productionOrderNumber.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarPOCodsec.Index].Value = lstFilmProductionPlan[i].fkProductionOrder.ToString();
                    if (lstFilmProductionPlan[i].productionOrder.fkBopp > 0)
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarFilm.Index].Value = lstFilmProductionPlan[i].productionOrder.Bopp.code.ToString();
                    if (lstFilmProductionPlan[i].productionOrder.fkCast > 0)
                        dgvCalendar.Rows[i].Cells[clmMachineCalendarFilm.Index].Value = lstFilmProductionPlan[i].productionOrder.Cast.code.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value = lstFilmProductionPlan[i].totalWeight.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarWidths.Index].Value = lstFilmProductionPlan[i].widths;
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarLength.Index].Value = lstFilmProductionPlan[i].estimatedLength.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value = lstFilmProductionPlan[i].estimatedKilogramsPerHour.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarIdleTime.Index].Value = lstFilmProductionPlan[i].estimatedIdleTime.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarProductionTime.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour, 2));
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = lstFilmProductionPlan[i].estimatedInitDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = lstFilmProductionPlan[i].estimatedEndDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCustomers.Index].Value = lstFilmProductionPlan[i].productionOrder.customerLists.ToString();
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarPlanification.Index].Value = global::BPS.Properties.Resources.calendar_2;
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCancel.Index].Value = global::BPS.Properties.Resources.cancel;

                    if (lstFilmProductionPlan[i].productionOrderStatusName == "En producción")
                    {
                        for (int j = 0; j < dgvCalendar.ColumnCount; j++)
                        {
                            dgvCalendar.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            hasInProductionOrder = true;
                        }
                    }
                }

                if (lstFilmProductionPlan.Count > 0)
                {
                    initDate = lstFilmProductionPlan[0].estimatedInitDate;
                    dtpInitDate.Visible = false;
                    lblInitDate.Visible = false;
                }
                else
                {
                    this.dtpInitDate.Value = DateTime.Now;
                    initDate = dtpInitDate.Value;
                    dtpInitDate.Visible = true;
                    lblInitDate.Visible = true;
                }
            }
        }

        private void cmbMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPlanedProductionOrders();
        }

        private void dgvProductionOrders_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.dgvProductionOrders.DoDragDrop(this.dgvProductionOrders.CurrentRow, DragDropEffects.All);
        }

        private void dgvCalendar_DragDrop(object sender, DragEventArgs e)
        {
            clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();

            if (dragDropSource == "calendar")
            {
                Point clientPoint = dgvCalendar.PointToClient(new Point(e.X, e.Y));
                rowIndexOfItemUnderMouseToDrop = dgvCalendar.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                if ((rowIndexOfItemUnderMouseToDrop > 0 && hasInProductionOrder == true) || hasInProductionOrder == false)
                {
                    if (e.Effect == DragDropEffects.Move)
                    {
                        DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                        dgvCalendar.Rows.RemoveAt(rowIndexFromMouseDown);
                        dgvCalendar.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    }

                    for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = initDate.ToString();
                            dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = initDate.AddHours((Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value) / Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value) + Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarIdleTime.Index].Value)));
                        }
                        else
                        {
                            dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value = dgvCalendar.Rows[i - 1].Cells[clmMachineCalendarEndDateTime.Index].Value;
                            dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value).AddHours((Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value) / Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value)) + Convert.ToDouble(dgvCalendar.Rows[i].Cells[clmMachineCalendarIdleTime.Index].Value));
                        }
                    }

                    for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                    {
                        objFilmProductionPlan = new clsFilmProductionPlan(Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value));
                        objFilmProductionPlan.codsec = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value);
                        objFilmProductionPlan.fkProductionOrder = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarPOCodsec.Index].Value);
                        objFilmProductionPlan.fkMachine = ((clsMachine)cmbMachine.SelectedItem).codsec;
                        objFilmProductionPlan.totalWeight = Convert.ToInt32(Math.Round(Convert.ToDecimal(dgvCalendar.Rows[i].Cells[clmMachineCalendarWeight.Index].Value), 0));
                        objFilmProductionPlan.estimatedInitDate = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarInitDateTime.Index].Value);
                        objFilmProductionPlan.estimatedEndDate = Convert.ToDateTime(dgvCalendar.Rows[i].Cells[clmMachineCalendarEndDateTime.Index].Value);
                        objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarKilogramsPerHour.Index].Value);
                        objFilmProductionPlan.estimatedIdleTime = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarIdleTime.Index].Value);
                        objFilmProductionPlan.save();
                    }
                    fillPlanedProductionOrders();
                }
                else
                    MessageBox.Show("No se puede mover la orden seleccionada a la posición de una orden en ejecución ", "Programación de extrusión (Bopp)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
            {
                if (cmbMachine.SelectedIndex >= 0)
                {
                    DataGridViewRow row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;

                    if (row != null)
                    {
                        if (txtMainCoilWidth1.Text != "0" && txtMainCoilWidth1.Text != "")
                        {
                            this.dgvCalendar.Rows.Add();
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarCodsec.Index].Value = "0";
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarPONumber.Index].Value = row.Cells[clmProductionOrderNumber.Index].Value;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarPOCodsec.Index].Value = row.Cells[clmProductionOrderCodsec.Index].Value;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarFilm.Index].Value = row.Cells[clmProductionOrderFilm.Index].Value;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarWeight.Index].Value = row.Cells[clmProductionOrderWeight.Index].Value;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarKilogramsPerHour.Index].Value = txtKPH.Text;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarProductionTime.Index].Value = Convert.ToString(Convert.ToDouble(row.Cells[clmProductionOrderWeight.Index].Value) / Convert.ToDouble(txtKPH.Text));

                            
                            if (dgvCalendar.Rows.Count > 1)
                            {
                                TimeSpan ts = ((Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 2].Cells[clmMachineCalendarEndDateTime.Index].Value))).AddHours(Convert.ToDouble(row.Cells[clmProductionOrderWeight.Index].Value) / Convert.ToDouble(txtKPH.Text)) - (Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 2].Cells[clmMachineCalendarEndDateTime.Index].Value));
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarIdleTime.Index].Value = Math.Ceiling((ts.TotalHours / 24 * 2));
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarInitDateTime.Index].Value = (Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 2].Cells[clmMachineCalendarEndDateTime.Index].Value)).ToString();
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarEndDateTime.Index].Value = ((Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 2].Cells[clmMachineCalendarEndDateTime.Index].Value))).AddHours((Convert.ToDouble(row.Cells[clmProductionOrderWeight.Index].Value) / Convert.ToDouble(txtKPH.Text)) + Math.Ceiling((ts.TotalHours / 24 * 2)));
                                
                            }
                            else
                            {
                                TimeSpan ts = DateTime.Now.AddHours(Convert.ToDouble(row.Cells[clmProductionOrderWeight.Index].Value) / Convert.ToDouble(txtKPH.Text)) -  DateTime.Now;
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarIdleTime.Index].Value = Math.Ceiling((ts.TotalHours / 24 * 2));
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarInitDateTime.Index].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarEndDateTime.Index].Value = DateTime.Now.AddHours((Convert.ToDouble(row.Cells[clmProductionOrderWeight.Index].Value) / Convert.ToDouble(txtKPH.Text)) + Math.Ceiling((ts.TotalHours / 24 * 2)));
                            }
                            
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarCustomers.Index].Value = row.Cells[clmProductionOrderCustomers.Index].Value;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarPlanification.Index].Value = global::BPS.Properties.Resources.calendar_2;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarEdit.Index].Value = global::BPS.Properties.Resources.pencil;

                            objFilmProductionPlan.codsec = Convert.ToInt32(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarCodsec.Index].Value);
                            objFilmProductionPlan.fkProductionOrder = Convert.ToInt32(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarPOCodsec.Index].Value);
                            objFilmProductionPlan.fkMachine = ((clsMachine)cmbMachine.SelectedItem).codsec;
                            objFilmProductionPlan.totalWeight = Convert.ToInt32(Math.Round(Convert.ToDouble(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarWeight.Index].Value), 0));
                            objFilmProductionPlan.estimatedInitDate = Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarInitDateTime.Index].Value);
                            objFilmProductionPlan.estimatedEndDate = Convert.ToDateTime(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarEndDateTime.Index].Value);
                            objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarKilogramsPerHour.Index].Value);
                            objFilmProductionPlan.estimatedIdleTime = Convert.ToInt32(dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarIdleTime.Index].Value);
                            objFilmProductionPlan.widths = txtMainCoilWidth1.Text + ((txtMainCoilWidth2.Text != "") ? " + " + txtMainCoilWidth2.Text : "");
                            objFilmProductionPlan.notes = txtNotes.Text;
                            objFilmProductionPlan.estimatedLength = Convert.ToInt32(txtLength.Text);

                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarWidths.Index].Value = objFilmProductionPlan.widths;
                            dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarLength.Index].Value = objFilmProductionPlan.estimatedLength.ToString();

                            //TODO lotNumber
                            if (!objFilmProductionPlan.save())
                                dgvCalendar.Rows.RemoveAt(dgvCalendar.Rows.Count - 1);
                            else
                            {
                                dgvCalendar.Rows[dgvCalendar.Rows.Count - 1].Cells[clmMachineCalendarCodsec.Index].Value = objFilmProductionPlan.codsec.ToString();
                                clsProductionOrder.changeOrderStatus(objFilmProductionPlan.fkProductionOrder, "Planificada");
                                this.dgvProductionOrders.Rows.RemoveAt(this.dgvProductionOrders.CurrentRow.Index);
                            }

                            //   cmbMachine.SelectedIndex = -1;
                            txtKPH.Text = "0";
                            txtMainCoilWidth1.Text = "0";
                            txtMainCoilWidth2.Text = "0";
                            txtLength.Text = "0";
                            txtNotes.Text = "";
                            dtpInitDate.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar el valor de los anchos de bobinas", "Programación de extrusión (Bopp)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            txtMainCoilWidth1.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar la máquina en la que se programará la producción", "Programación de extrusión (Bopp)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    cmbMachine.Focus();
                }
            }
        }

        private void dgvCalendar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void dgvCalendar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvCalendar.DoDragDrop(dgvCalendar.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }

        private void dgvCalendar_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropSource = "calendar";
            rowIndexFromMouseDown = dgvCalendar.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {             
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvCalendar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvProductionOrders_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropSource = "productionOrders";
        }

        private void grpbProductionOrder_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMachineCalendarEdit.Index)
            {
                frmProductionOrderEdit winProductionOrderEdit = new frmProductionOrderEdit(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarPOCodsec.Index].Value));
                winProductionOrderEdit.ShowDialog();
                fillPlanedProductionOrders();
            }
            if (e.ColumnIndex == clmMachineCalendarPlanification.Index)
            {
                if (e.RowIndex == 0)
                {
                    clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarCodsec.Index].Value));
                    if (objFilmProductionPlan.productionOrderStatusName != "En producción")
                    {
                        frmFilmProductionPlanEdit winFilmProductionPlanEdit = new frmFilmProductionPlanEdit(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarCodsec.Index].Value), true);
                        winFilmProductionPlanEdit.ShowDialog();
                        fillPlanedProductionOrders();
                    }
                    else
                    {
                        frmFilmProductionPlanEdit winFilmProductionPlanEdit = new frmFilmProductionPlanEdit(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarCodsec.Index].Value), true);
                        winFilmProductionPlanEdit.ShowDialog();
                        fillPlanedProductionOrders();
                    }
                }
                else
                {
                    frmFilmProductionPlanEdit winFilmProductionPlanEdit = new frmFilmProductionPlanEdit(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarCodsec.Index].Value), false);
                    winFilmProductionPlanEdit.ShowDialog();
                    fillPlanedProductionOrders();
                }
            }
            if (e.ColumnIndex == clmMachineCalendarCancel.Index)
            {
                if (clsProductionOrder.toCheckStatus(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarPOCodsec.Index].Value)) == 19)
                {
                    MessageBox.Show("No se puede anular una orden que se encuentra en producción si desea anular dicha orden por favor comuníquese con EXTRUSION", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    fillPlanedProductionOrders();
                }
                else
                {
                    if (clsFilmProductionPlan.toCheckQuality(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarCodsec.Index].Value)) == 0)
                    {
                        if (MessageBox.Show("Esta seguro que desea anular esta orden de producción?", "Orden de producción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            clsProductionOrder.changeOrderStatus(Convert.ToInt32(dgvCalendar.Rows[e.RowIndex].Cells[clmMachineCalendarPOCodsec.Index].Value), "Anulada");
                            fillPlanedProductionOrders();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La orden que desea anular posee ya Kilos realizados por favor comuníquese con EXTRSUION", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        fillPlanedProductionOrders();
                    }
                }
            }
        }

        private void dgvProductionOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmProductionOrderEdit.Index)
            {
                frmProductionOrderEdit winProductionOrderEdit = new frmProductionOrderEdit(Convert.ToInt32(dgvProductionOrders.Rows[e.RowIndex].Cells[clmProductionOrderCodsec.Index].Value));
                winProductionOrderEdit.ShowDialog();
                FillUnPlanedProductionOrders();
            }
            if (e.ColumnIndex == clmProductionOrderCancel.Index)
            {
                if (MessageBox.Show("Esta seguro que desea anular esta orden de producción?", "Orden de producción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsProductionOrder.changeOrderStatus(Convert.ToInt32(dgvProductionOrders.Rows[e.RowIndex].Cells[clmProductionOrderCodsec.Index].Value), "Anulada");
                    FillUnPlanedProductionOrders();
                }
            }
        }

        private void cmbMachine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsMachine> lstMachines = new List<clsMachine>();
                lstMachines = clsMachine.getExtruderMachineList();
                for (int i = 0; i < lstMachines.Count; i++)
                    cmbMachine.Items.Add(lstMachines[i]); 
            }
        }

        private void grpbMachine_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCalendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}