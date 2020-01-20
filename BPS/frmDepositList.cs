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
    public partial class frmDepositList : Form
    {
        List<int> sodlistC = new List<int>();
        List<int> sodlistPL = new List<int>();
        List<clsPallet> palletList = new List<clsPallet>();
        List<clsAymasDepot> palletListPL = new List<clsAymasDepot>();
        List<double> priceList = new List<double>();
        List<double> exchangeList = new List<double>();
        List<string> POList = new List<string>();
        List<string> plantList = new List<string>();
        List<string> custommerList = new List<string>();
       
        
      /* List<double> priceListPL = new List<double>();
        List<double> exchangeListPL = new List<double>();
        List<string> POListPL = new List<string>();
        List<string> plantListPL = new List<string>();
        List<string> custommerListPL = new List<string>(); */

        public frmDepositList(List<int> sodlist, List<double> prilist, List<double> exclist, List<string> purlist, List<string> plList, List<string> cstmList)
        {
            InitializeComponent();
            List<clsPallet> aux = new List<clsPallet>();
            //List<clsAymasDepot> aux2 = new List<clsAymasDepot>();
            for (int i = 0; i < sodlist.Count; i++)
            {
                aux = clsPallet.getAvailableListBySalesOrderDetail(sodlist[i]);
                //aux2 = clsAymasDepot.getAvailableListBySalesOrderDetailPL(sodlist[i]);
                for (int j = 0; j < aux.Count; j++)
                {
                        palletList.Add(aux[j]);
                        sodlistC.Add(sodlist[i]);
                        priceList.Add(prilist[i]);
                        exchangeList.Add(exclist[i]);
                        POList.Add(purlist[i]);
                        plantList.Add(plList[i]);
                        custommerList.Add(cstmList[i]);
                }
                /*for (int j = 0; j < aux2.Count; j++)
                {
                        palletListPL.Add(aux2[j]);
                        sodlistPL.Add(sodlist[i]);
                        priceListPL.Add(prilist[i]);
                        exchangeListPL.Add(exclist[i]);
                        POListPL.Add(purlist[i]);
                        plantListPL.Add(plList[i]);
                        custommerListPL.Add(cstmList[i]);
                }*/
                
            }
            populateDataGrid();
            //populateDataGridPL();
        }

        //CAMPANA 

        public void populateDataGrid()
        {
            for (int i = 0; i < palletList.Count; i++)
            {
                dgvDepositList.Rows.Add();
                int fila = dgvDepositList.Rows.Count-1;
                dgvDepositList.Rows[fila].Cells[clmCodsec.Index].Value = palletList[i].codsec;
                dgvDepositList.Rows[fila].Cells[clmOrder.Index].Value = sodlistC[i];
                dgvDepositList.Rows[fila].Cells[clmPurchaseOrder.Index].Value = POList[i];
                dgvDepositList.Rows[fila].Cells[clmPrice.Index].Value = priceList[i] * exchangeList[i];
                dgvDepositList.Rows[fila].Cells[clmPlant.Index].Value = new clsPlant(new clsCoilCellar(palletList[i].fkPalletCoilcellar).fkPlant).name;
                dgvDepositList.Rows[fila].Cells[clmCode.Index].Value = palletList[i].code;
                dgvDepositList.Rows[fila].Cells[clmFilm.Index].Value = palletList[i].product.boppCode + palletList[i].product.castCode + palletList[i].product.coatingCode;
                dgvDepositList.Rows[fila].Cells[clmWidth.Index].Value = palletList[i].product.width;
                dgvDepositList.Rows[fila].Cells[clmDiameter.Index].Value = palletList[i].product.DiameterAbbreviation;
                dgvDepositList.Rows[fila].Cells[clmCore.Index].Value = palletList[i].product.CoreName;
                dgvDepositList.Rows[fila].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].netWeight, 2);


                if (Convert.ToDouble(dgvDepositList.Rows[fila].Cells[clmNetWeight.Index].Value) > 999.99)
                {
                    dgvDepositList.Rows[fila].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].netWeight, 2).ToString("0,000.00");
                }
                else
                {
                    dgvDepositList.Rows[fila].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].netWeight, 2).ToString("00.00");
                }

                dgvDepositList.Rows[fila].Cells[clmCustomer.Index].Value = custommerList[i];
                dgvDepositList.Rows[fila].Cells[clmSaleOrder.Index].Value = sodlistC[i];
                dgvDepositList.Rows[fila].Cells[clmOrigin.Index].Value = palletList[i].origin;
                dgvDepositList.Rows[fila].Cells[clmLocation.Index].Value = palletList[i].position;
                dgvDepositList.Rows[fila].Cells[clmDate.Index].Value = palletList[i].createdDate.ToShortDateString();
                dgvDepositList.Rows[fila].Cells[clmCheck.Index].Value = true;
                if (palletList[i].fkStatus == 3073)
                    dgvDepositList.Rows[fila].DefaultCellStyle.BackColor = Color.Green;

            }
            txtTotalNetWeight.Text = CalculateTotalNetWeight().ToString();
        }

        public double CalculateTotalNetWeight()
        {
            double totalNetWeight = 0;
            for (int i = 0; i < dgvDepositList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositList.Rows[i].Cells[clmCheck.Index].Value))
                {
                    totalNetWeight += Math.Round(Convert.ToDouble(dgvDepositList.Rows[i].Cells[clmNetWeight.Index].Value), 1);

                }
            }
            return totalNetWeight;
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {

            List<String> listaFechaPallet = new List<string>();


            for (int i = 0; i < dgvDepositList.Rows.Count; i++)
            {
                listaFechaPallet.Add(dgvDepositList.Rows[i].Cells[clmDate.Index].Value.ToString());
                dgvDepositList.Rows[i].Cells[clmDate.Index].Value = Convert.ToDateTime(dgvDepositList.Rows[i].Cells[clmDate.Index].Value).ToString("MM/dd/yyyy HH:mm");
            }

            /* Se comenta esto, por que genero alto bardo al hacerles presionar 2 clicks mas, lo dejo por si en un futuro se vuelve a usar.
            string ext = string.Empty;
            dgvDepositList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
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
                dgvDepositList.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            
            dgvDepositList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            */

            // Se usa este por que la operatoria es mas """"""""facil""""""" y ademas no necesitan guardar por cada PD el documento.
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Listado de Depósito";

                for (int i = 2; i < dgvDepositList.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvDepositList.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDepositList.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDepositList.Rows[i].Cells[clmCheck.Index].Value))
                    {
                        for (int j = 1; j < dgvDepositList.Columns.Count - 1; j++)
                        {
                            if (dgvDepositList.Rows[i].Cells[j].Value != null)
                                worksheet.Cells[i + 2, j] = dgvDepositList.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < dgvDepositList.Rows.Count; i++)
            {
                dgvDepositList.Rows[i].Cells[clmDate.Index].Value = Convert.ToDateTime(listaFechaPallet[i].ToString());
            }
        }
        /*
        private void copyAlltoClipboard()
        {
            dgvDepositList.SelectAll();
            DataObject dataObj = dgvDepositList.GetClipboardContent();
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
        }*/

        private void dgvDepositList_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                double total = CalculateTotalNetWeight();
                if (total > 999.99)
                {
                    txtTotalNetWeight.Text = total.ToString("0,000.00");
                }
                else
                {
                    txtTotalNetWeight.Text = total.ToString("00.00");
                }
            }
        }


        private void dgvDepositList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                txtTotalNetWeight.Focus();
            }
        }

        private void chkSelectAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                for (int i = 0; i < dgvDepositList.Rows.Count; i++)
                {
                    dgvDepositList.Rows[i].Cells[clmCheck.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvDepositList.Rows.Count; i++)
                {
                    dgvDepositList.Rows[i].Cells[clmCheck.Index].Value = false;
                }
            }
        }

        private void btnPreshipping_Click_1(object sender, EventArgs e)
        {
            string cliente = "";
            bool error = false;
            for (int i = 0; i < dgvDepositList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositList.Rows[i].Cells[clmCheck.Index].Value))
                {
                    if(cliente!="")
                    {
                       if(cliente!=dgvDepositList.Rows[i].Cells[clmCustomer.Index].Value.ToString())
                       {
                           error = true;
                       }
                    }
                    else
                    {
                        cliente = dgvDepositList.Rows[i].Cells[clmCustomer.Index].Value.ToString();
                    }
                }
            }

            if(!error)
            {
                clsNewPreShipping pshipping = new clsNewPreShipping();
                pshipping.fkEntity = new clsEntity(cliente).codsec;
                pshipping.fkUser = clsGlobal.LoggedUser.codsec;
                pshipping.save();
                List<int> listapa = new List<int>();

                for (int i = 0; i < dgvDepositList.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDepositList.Rows[i].Cells[clmCheck.Index].Value))
                    {
                        listapa.Add(Convert.ToInt32(dgvDepositList.Rows[i].Cells[clmCodsec.Index].Value));
                    }
                }

                frmNewPreShipping winSystemConfig = new frmNewPreShipping(pshipping.number,listapa);
                winSystemConfig.StartPosition = FormStartPosition.Manual;
                winSystemConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede generar un pre-despacho con pallets asignados a distintos clientes. Seleccione pallets de un solo cliente.","Listado de deposito",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            /*clsPallet objpallet = new clsPallet();
            List<clsPallet> objPltList = new List<clsPallet>();

            for (int i = 0; i < dgvDepositList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositList.Rows[i].Cells[clmCheck.Index].Value))
                {
                    objpallet = new clsPallet(Convert.ToInt32(dgvDepositList.Rows[i].Cells[clmCodsec.Index].Value));
                    objPltList.Add(objpallet);
                }
            }
            frmPalletPreShipping winSystemConfig = new frmPalletPreShipping(objPltList);
            winSystemConfig.StartPosition = FormStartPosition.Manual;
            winSystemConfig.Show();*/

        }

        //PILAR

       /* public void populateDataGridPL()
        {
            for (int i = 0; i < palletListPL.Count; i++)
            {
                dgvDepositListPL.Rows.Add();
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletListPL[i].codsec;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmOrder.Index].Value = sodlistPL[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPurchaseOrder.Index].Value = POListPL[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPrice.Index].Value = priceListPL[i] * exchangeListPL[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPlant.Index].Value = "Pilar";
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCode.Index].Value = palletListPL[i].palletCode;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmFilm.Index].Value = palletListPL[i].film;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmWidth.Index].Value = palletListPL[i].width;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmDiameter.Index].Value = palletListPL[i].diameter;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCore.Index].Value = palletListPL[i].core;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletListPL[i].weigth, 2);
                if (Convert.ToDouble(dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value) > 999.99)
                {
                    dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletListPL[i].weigth, 2).ToString("0,000.00");
                }
                else
                {
                    dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletListPL[i].weigth, 2).ToString("00.00");
                }
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCustomer.Index].Value = custommerListPL[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = sodlistPL[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmOrigin.Index].Value = palletListPL[i].procedence;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmLocation.Index].Value = palletListPL[i].state;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmDate.Index].Value = palletListPL[i].date.ToShortDateString();
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCheck.Index].Value = true;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmQualification.Index].Value = palletListPL[i].quality;
            }
            txtTotalNetWeightPL.Text = CalculateTotalNetWeightPL().ToString();
        }

        public double CalculateTotalNetWeightPL()
        {
            double totalNetWeight = 0;
            for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                {
                    totalNetWeight += Math.Round(Convert.ToDouble(dgvDepositListPL.Rows[i].Cells[clmNetWeight.Index].Value), 2);
                }
            }
            return totalNetWeight;
        }

        private void btnExportPL_Click_1(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Listado de Depósito Pilar";

                for (int i = 2; i < dgvDepositListPL.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvDepositListPL.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                    {
                        for (int j = 1; j < dgvDepositListPL.Columns.Count - 1; j++)
                        {
                            if (dgvDepositListPL.Rows[i].Cells[j].Value != null)
                                worksheet.Cells[i + 2, j] = dgvDepositListPL.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepositListPL_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                double total = CalculateTotalNetWeightPL();
                if (total > 999.99)
                {
                    txtTotalNetWeightPL.Text = total.ToString("0,000.00");
                }
                else
                {
                    txtTotalNetWeightPL.Text = total.ToString("00.00");
                }
            }
        }
        
        private void dgvDepositListPL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                txtTotalNetWeightPL.Focus();
            }
        }

        private void chkSelectAllPL_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSelectAllPL.Checked)
            {
                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value = false;
                }
            }
        }
        
        private void btnPreshippingPL_Click_1(object sender, EventArgs e)
        {
            clsAymasDepot objpallet = new clsAymasDepot();
            List<clsAymasDepot> objPltList = new List<clsAymasDepot>();

            for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                {
                    objpallet = clsAymasDepot.getDetailByCode(dgvDepositListPL.Rows[i].Cells[clmCode.Index].Value.ToString());
                    objPltList.Add(objpallet);
                }
            }
            frmPalletPreShippingPL winSystemConfig = new frmPalletPreShippingPL(objPltList);
            winSystemConfig.StartPosition = FormStartPosition.Manual;
            winSystemConfig.Show();
        }*/
    }
}

