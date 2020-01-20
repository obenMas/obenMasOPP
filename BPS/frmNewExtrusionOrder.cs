using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS
{
    public partial class frmNewExtrusionOrder : Form
    {
        List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
        List<clsProductionOrder> lstProductionOrder = new List<clsProductionOrder>();
        clsNewFormulation objNewFormulation = new clsNewFormulation();
        public DateTime nuevafechainicio = new DateTime();
        public frmNewExtrusionOrder()
        {
            InitializeComponent();
            OrdenesSinPlanificar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNewExtrusionOrder_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
            cmbMaquinas.Items.Clear();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMaquinas.Items.Add(lstMachines[i]);
        }

        private void cmbMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            InformacionDePlan(false);
        }
        public void InformacionDePlan(bool cambios)
        {
            if (cmbMaquinas.SelectedIndex != -1)
            {
                if(cambios==false)
                    txtKgPorHora.Text = ((clsMachine)cmbMaquinas.SelectedItem).Extruder.kilogramsPerHour.ToString();
                lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(((clsMachine)cmbMaquinas.SelectedItem).codsec);
                dgv.Rows.Clear();
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[clmCodsec.Index].Value = lstFilmProductionPlan[i].codsec.ToString();
                    dgv.Rows[i].Cells[clmCodsecOrden.Index].Value = lstFilmProductionPlan[i].productionOrder.codsec;
                    dgv.Rows[i].Cells[clmPelicula.Index].Value = lstFilmProductionPlan[i].productionOrder.Bopp.code.ToString();
                    dgv.Rows[i].Cells[clmPeso.Index].Value = lstFilmProductionPlan[i].totalWeight.ToString();
                    dgv.Rows[i].Cells[clmProducido.Index].Value = clsMainCoil.getaccumulatedbyfilproductionplan(lstFilmProductionPlan[i].codsec);
                    dgv.Rows[i].Cells[clmTiempo.Index].Value = Convert.ToDouble(lstFilmProductionPlan[i].totalWeight / Convert.ToInt32(txtKgPorHora.Text)).ToString("0.0");
                    dgv.Rows[i].Cells[clmTiempoMuerto.Index].Value = Convert.ToInt32((lstFilmProductionPlan[i].totalWeight / Convert.ToInt32(txtKgPorHora.Text)) * (((100 - Convert.ToDouble(txtDispMaquina.Text))) / 100));
                    dgv.Rows[i].Cells[clmTiempoRestante.Index].Value = Convert.ToDouble((lstFilmProductionPlan[i].totalWeight - clsMainCoil.getaccumulatedbyfilproductionplan(lstFilmProductionPlan[i].codsec)) / Convert.ToInt32(txtKgPorHora.Text)).ToString("0.0");
                    dgv.Rows[i].Cells[clmFechaInicio.Index].Value = lstFilmProductionPlan[i].estimatedInitDate.ToString();
                    dgv.Rows[i].Cells[clmFechaFinal.Index].Value = lstFilmProductionPlan[i].estimatedInitDate.AddHours(((lstFilmProductionPlan[i].totalWeight - clsMainCoil.getaccumulatedbyfilproductionplan(lstFilmProductionPlan[i].codsec)) / Convert.ToInt32(txtKgPorHora.Text)) + Convert.ToInt32(dgv.Rows[i].Cells[clmTiempoMuerto.Index].Value));
                    dgv.Rows[i].Cells[clmEstado.Index].Value = ((clsStatus)new clsStatus(lstFilmProductionPlan[i].productionOrder.fkStatus)).name;
                    if (i == 0)
                        dgv.Rows[i].Cells[clmFechaFinalizacionEstimada.Index].Value = DateTime.Now.AddHours(((lstFilmProductionPlan[i].totalWeight - clsMainCoil.getaccumulatedbyfilproductionplan(lstFilmProductionPlan[i].codsec)) / Convert.ToInt32(txtKgPorHora.Text)) + lstFilmProductionPlan[i].estimatedIdleTime);
                    else
                        dgv.Rows[i].Cells[clmFechaFinalizacionEstimada.Index].Value = Convert.ToDateTime(dgv.Rows[i - 1].Cells[clmFechaFinalizacionEstimada.Index].Value).AddHours(((lstFilmProductionPlan[i].totalWeight - clsMainCoil.getaccumulatedbyfilproductionplan(lstFilmProductionPlan[i].codsec)) / Convert.ToInt32(txtKgPorHora.Text)) + lstFilmProductionPlan[i].estimatedIdleTime);
                    if (i != 0 && Convert.ToDateTime(dgv.Rows[i].Cells[clmFechaInicio.Index].Value) > Convert.ToDateTime(dgv.Rows[i - 1].Cells[clmFechaFinalizacionEstimada.Index].Value))
                        dgv.Rows[i].Cells[clmFechaFinalizacionEstimada.Index].Value = dgv.Rows[i].Cells[clmFechaFinal.Index].Value;
                    dgv.Rows[i].Cells[clmNotas.Index].Value = lstFilmProductionPlan[i].notes.ToString();
                    if (lstFilmProductionPlan[i].productionOrder.fkStatus == 19)
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    if (!objNewFormulation.CheckStandar(lstFilmProductionPlan[i].productionOrder.Bopp.codsec, ((clsMachine)cmbMaquinas.SelectedItem).codsec))
                        dgv.Rows[i].Cells[clmPelicula.Index].Style.BackColor = Color.Yellow;
                }
                for (int x = 0; x < dgvProductionOrder.Rows.Count; x++)
                    dgvProductionOrder.Rows[x].Cells[clmPOTiempoEstimado.Index].Value = Convert.ToDouble((Convert.ToDouble(dgvProductionOrder.Rows[x].Cells[clmPOPeso.Index].Value) / Convert.ToDouble(txtKgPorHora.Text))).ToString("0.0");
            }
        }
        public void OrdenesSinPlanificar()
        {
            dgvProductionOrder.Rows.Clear();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwproductionorder WHERE pord_fkStatus=17 ORDER BY pord_createdDate DESC");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                dgvProductionOrder.Rows.Add();
                int fila = dgvProductionOrder.Rows.Count - 1;
                dgvProductionOrder.Rows[fila].Cells[clmPOCodsec.Index].Value = DS.Tables[0].Rows[i]["pord_codsec"];
                dgvProductionOrder.Rows[fila].Cells[clmPOPelicula.Index].Value = DS.Tables[0].Rows[i]["pord_BoppCode"].ToString();
                dgvProductionOrder.Rows[fila].Cells[clmPOPeso.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["pord_quantity"]);
                dgvProductionOrder.Rows[fila].Cells[clmPOObs.Index].Value = DS.Tables[0].Rows[i]["pord_closeObservation"];
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<clsMaterialCost> lstmt = new List<clsMaterialCost>();
            bool bandera = true;
            if(cmbMaquinas.SelectedIndex!=-1)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[clmPelicula.Index].Style.BackColor == Color.Yellow)
                        bandera = false;
                }
                if (bandera == true)
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        clsMaterialCost obj = new clsMaterialCost();
                        obj.fkBopp = lstFilmProductionPlan[i].productionOrder.Bopp.codsec;
                        obj.subtotal = (lstFilmProductionPlan[i].totalWeight - Convert.ToDouble(dgv.Rows[i].Cells[clmProducido.Index].Value)) * (1 + ((100 - Convert.ToDouble(txtEficiencia.Text)) / 100));
                        obj.fkMachine = ((clsMachine)cmbMaquinas.SelectedItem).codsec;
                        bool existe = false;
                        for (int y = 0; y < lstmt.Count; y++)
                        {
                            if (lstmt[y].fkBopp == obj.fkBopp)
                                existe = true;
                        }
                        if (lstmt.Count == 0)
                        {
                            lstmt.Add(obj);
                        }
                        else if (lstmt.Count != 0)
                        {
                            if (existe == true)
                            {
                                for (int x = 0; x < lstmt.Count; x++)
                                    if (lstmt[x].fkBopp == obj.fkBopp)
                                        lstmt[x].subtotal += obj.subtotal;
                            }
                            else
                                lstmt.Add(obj);
                        }
                    }
                    frmCalculationMaterialCost form = new frmCalculationMaterialCost(lstmt);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Una o varias peliculas no poseen formulación estandar, por favor crear o establecer como estandar una existente", "Plan de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Por favor seleccione una máquina", "Plan de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if (dgv.Rows[e.RowIndex].Cells[clmPelicula.Index].Style.BackColor != Color.Yellow)
                {
                    clsMaterialCost obj = new clsMaterialCost();
                    obj.fkBopp = lstFilmProductionPlan[e.RowIndex].productionOrder.Bopp.codsec;
                    obj.subtotal = Convert.ToDouble((Convert.ToDouble(dgv.CurrentRow.Cells[clmPeso.Index].Value) - Convert.ToDouble(dgv.CurrentRow.Cells[clmProducido.Index].Value)) * (1 + ((100 - Convert.ToDouble(txtEficiencia.Text)) / 100)));
                    obj.fkMachine = ((clsMachine)cmbMaquinas.SelectedItem).codsec;
                    frmCalculationMaterialCost form = new frmCalculationMaterialCost(obj);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("No existe una formulación estandar, por favor crear una", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgv.Columns[clmEditarFormulacion.Index].Visible = false;
            dgv.Columns[clmCerrarOrden.Index].Visible = false;
            dgv.Columns[clmMoverASinPlanificar.Index].Visible = false;
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            sfd.Filter = "Excel WorkBook|*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgv.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dgv.Columns[clmEditarFormulacion.Index].Visible = true;
            dgv.Columns[clmCerrarOrden.Index].Visible = true;
            dgv.Columns[clmMoverASinPlanificar.Index].Visible = true;
        }
        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEditarFormulacion.Index && e.RowIndex != -1)
            {
                objNewFormulation = new clsNewFormulation();
                objNewFormulation.loadByBoppStandar(lstFilmProductionPlan[e.RowIndex].productionOrder.Bopp.codsec, ((clsMachine)cmbMaquinas.SelectedItem).codsec);
                if (objNewFormulation.Codsec != 0)
                {
                    frmFormulationBopp form = new frmFormulationBopp(objNewFormulation.Codsec, true);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("No existe una formulación estandar, por favor crear una", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmCerrarOrden.Index && e.RowIndex != -1)
            {
                clsProductionOrder objpo = new clsProductionOrder(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[clmCodsecOrden.Index].Value));
                if(objpo.fkStatus==19)
                {
                    if(MessageBox.Show("¿Está seguro que desea cerrar la orden de producción?", "Confirmación de cierre de orden de producción", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        objpo.close();
                        MessageBox.Show("La orden se cerró correctamente.", "Plan de extrusión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformacionDePlan(false);
                        OrdenesSinPlanificar();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede cerrar la orden de producción porque su estado no es 'En Producción'. Solo se puede cerrar la orden que se encuentre con estado 'En producción'.", "Cierre de ordenes de producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if(e.ColumnIndex==clmMoverASinPlanificar.Index && e.RowIndex!=-1)
            {
                clsProductionOrder objpo = new clsProductionOrder(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[clmCodsecOrden.Index].Value));
                if (objpo.fkStatus == 18)
                {
                    if (objpo.UpdateStatusToUnplanned() == false)
                    {
                        MessageBox.Show("Error al retirar del plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (clsFilmProductionPlan.DeletePlan(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                        {
                            MessageBox.Show("La orden se movio a sin planificar", "Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OrdenesSinPlanificar();
                            InformacionDePlan(false);
                        }
                        else
                            MessageBox.Show("Error al mover la orden a sin planificar", "Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede mover la orden de producción a sin planificar porque su estado no es 'Planificada'. Solo se pueden mover las ordenes con estado 'Planificada'.", "Mover a sin planificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmNewOrder form = new frmNewOrder();
            form.ShowDialog();
            InformacionDePlan(false);
            OrdenesSinPlanificar();
        }

        private void dgvProductionOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index && e.RowIndex != -1)
            {
                if(MessageBox.Show("¿Está seguro que desea eliminar esta orden?","Ordenes sin planificar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (clsProductionOrder.DeleteByCodsec(Convert.ToInt32(dgvProductionOrder.Rows[e.RowIndex].Cells[clmPOCodsec.Index].Value)))
                    {
                        MessageBox.Show("La orden se elimino correctamente!", "Ordenes sin planificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformacionDePlan(false);
                        OrdenesSinPlanificar();
                    }
                    else
                        MessageBox.Show("Error al borrar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else if(e.ColumnIndex == clmAgregarAPlan.Index && e.RowIndex!=-1)
            {
                if(cmbMaquinas.SelectedIndex!=-1)
                {
                    clsProductionOrder objpord = new clsProductionOrder(Convert.ToInt32(dgvProductionOrder.Rows[e.RowIndex].Cells[clmPOCodsec.Index].Value));
                    if (objpord.UpdateStatusToPlanned() == false)
                    {
                        MessageBox.Show("Error al agregar al plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        clsFilmProductionPlan objfpp = new clsFilmProductionPlan();
                        objfpp.fkProductionOrder = objpord.codsec;
                        objfpp.fkMachine = ((clsMachine)cmbMaquinas.SelectedItem).codsec;
                        objfpp.totalWeight = objpord.quantity;
                        if (dgv.Rows.Count - 1 != -1)
                        {
                            if (dgv.Rows[dgv.Rows.Count - 1].Cells[clmFechaFinal.Index].Value != null)
                                objfpp.estimatedInitDate = Convert.ToDateTime(dgv.Rows[dgv.Rows.Count - 1].Cells[clmFechaFinal.Index].Value);
                        }
                        else
                            objfpp.estimatedInitDate = DateTime.Now;
                        objfpp.estimatedIdleTime = Convert.ToInt32((objfpp.totalWeight / Convert.ToInt32(txtKgPorHora.Text)) * (((100 - Convert.ToDouble(txtDispMaquina.Text)))/100));
                        objfpp.estimatedEndDate = objfpp.estimatedInitDate.AddHours(objfpp.totalWeight / Convert.ToInt32(txtKgPorHora.Text)+objfpp.estimatedIdleTime);
                        objfpp.estimatedKilogramsPerHour = Convert.ToInt32(txtKgPorHora.Text);
                        objfpp.notes = "";
                        objfpp.widths = "8800";
                        if (objfpp.save() == false)
                            MessageBox.Show("Error al agregar al plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("La orden se agregó al plan correctamente", "Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformacionDePlan(false);
                        OrdenesSinPlanificar();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una máquina primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(cmbMaquinas.SelectedIndex!=-1)
            {
                if (MessageBox.Show("¿Está seguro que desea modificar la fecha de inicio? Esto afectara a la primera orden planificada, y seguidamente a las que esten debajo", "Modificar fecha de inicio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    frmDateSelector frm = new frmDateSelector(this);
                    frm.ShowDialog(this);
                    clsFilmProductionPlan objfpp = new clsFilmProductionPlan();
                    DateTime ultimafecha = new DateTime();
                    int count = 0;
                    for (int i=0;i<dgv.Rows.Count;i++)
                    {
                        if(dgv.Rows[i].Cells[clmEstado.Index].Value.ToString()!="En producción")
                        {
                            count++;
                            if (count == 1)
                            {
                                objfpp.load(Convert.ToInt32(dgv.Rows[i].Cells[clmCodsec.Index].Value));
                                objfpp.estimatedInitDate = nuevafechainicio;
                                objfpp.estimatedEndDate = nuevafechainicio.AddHours((objfpp.totalWeight / Convert.ToInt32(txtKgPorHora.Text))+objfpp.estimatedIdleTime);
                                ultimafecha = objfpp.estimatedEndDate;
                                objfpp.save();
                            }
                            else
                            {
                                objfpp.load(Convert.ToInt32(dgv.Rows[i].Cells[clmCodsec.Index].Value));
                                objfpp.estimatedInitDate = ultimafecha;
                                objfpp.estimatedEndDate = ultimafecha.AddHours((objfpp.totalWeight / Convert.ToInt32(txtKgPorHora.Text))+objfpp.estimatedIdleTime);
                                objfpp.save();
                            }
                        }
                    }
                    InformacionDePlan(false);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una máquina primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            OrdenesSinPlanificar();
            InformacionDePlan(true);
        }

        public void VisualizarCambios()
        {

        }
    }
}
