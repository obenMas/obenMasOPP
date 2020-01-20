using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Business;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS
{
    public partial class frmQualityControls : Form
    {
        DataSet DS = new DataSet();
        clsQualityControls objqctrl = new clsQualityControls();
        clsQualityControlsTypes objQCTypes = new clsQualityControlsTypes();

        public frmQualityControls()
        {
            InitializeComponent();
            PopulateCombo();
            getDataSet();
            PopulateDgv();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("CALL spQualityControls");
        }

        public void PopulateDgv()
        {
            dgvQualityControls.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvQualityControls.Rows.Add();
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qc_codsec"]);
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmFkQualityControlType.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qc_fkQualityControlType"]);
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmQualityControlType.Index].Value = DS.Tables[0].Rows[i]["qct_name"].ToString();
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmName.Index].Value = DS.Tables[0].Rows[i]["qc_name"].ToString();
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmUnit.Index].Value = DS.Tables[0].Rows[i]["qc_unit"].ToString();
                    dgvQualityControls.Rows[dgvQualityControls.Rows.Count - 1].Cells[clmNorm.Index].Value = DS.Tables[0].Rows[i]["qc_norm"].ToString();
                }
            }
        }

        public void PopulateCombo()
        {
            List<clsQualityControlsTypes> lstQltControl = new List<clsQualityControlsTypes>();
            lstQltControl = clsQualityControlsTypes.getList();

            for (int i = 0; i < lstQltControl.Count; i++)
            {
                cmbTypes.Items.Add(lstQltControl[i].name);
            }
        }

        private void dgvQualityControls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if(deleteValidate(Convert.ToInt32(dgvQualityControls.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                {
                    if (clsQualityControls.delete(Convert.ToInt32(dgvQualityControls.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                    {
                        dgvQualityControls.Rows.RemoveAt(e.RowIndex);
                    }
                    txtName.ResetText();
                    cmbTypes.SelectedIndex = -1;
                    txtUnity.ResetText();
                    txtNorm.ResetText();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar. Para poder hacerlo, no deben existir planes de control asociados al control de calidad que intenta eliminar.", "Eliminar Control de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            if (e.ColumnIndex == clmEdit.Index)
            {
                txtName.Text = dgvQualityControls.Rows[e.RowIndex].Cells[clmName.Index].Value.ToString();
                for (int i = 0; i < cmbTypes.Items.Count; i++)
                {
                    if (dgvQualityControls.Rows[e.RowIndex].Cells[clmQualityControlType.Index].Value.ToString() == cmbTypes.Items[i].ToString())
                    {
                        cmbTypes.SelectedIndex = i;
                    }
                }
                txtUnity.Text = dgvQualityControls.Rows[e.RowIndex].Cells[clmUnit.Index].Value.ToString();
                txtNorm.Text = dgvQualityControls.Rows[e.RowIndex].Cells[clmNorm.Index].Value.ToString();

                 this.objqctrl = new clsQualityControls(Convert.ToInt32(dgvQualityControls.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
            }
            getDataSet();
            PopulateDgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objqctrl.name = txtName.Text.ToString();
            objqctrl.fkQualityControlType = objQCTypes.QualityControlTypeCodsecByName(cmbTypes.SelectedItem.ToString());
            objqctrl.unity = txtUnity.Text.ToString();
            objqctrl.norm = txtNorm.Text.ToString();
            objqctrl.save();

            getDataSet();
            PopulateDgv();

            txtName.ResetText();
            cmbTypes.SelectedIndex = -1;
            txtUnity.ResetText();
            txtNorm.ResetText();
            this.objqctrl = new clsQualityControls();
        }

        public bool deleteValidate(int codsec)
        {

            int qualityCTCodsec = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT CCBF.qcbf_fkqualitycontrol AS CodsecQualityControl FROM bps_prod_qualitycontrolsbyfilm AS CCBF LEFT JOIN bps_prod_qualitycontrols ON(bps_prod_qualitycontrols.qc_codsec = CCBF.qcbf_fkqualitycontrol) WHERE  bps_prod_qualitycontrols.qc_codsec = " + codsec);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                qualityCTCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["CodsecQualityControl"]);
            }

            if (qualityCTCodsec > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvQualityControls.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvQualityControls.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgvQualityControls.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvQualityControls.SelectAll();
            DataObject dataObj = dgvQualityControls.GetClipboardContent();
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
    }
}
