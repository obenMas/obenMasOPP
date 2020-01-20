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
    public partial class frmListaEmpaque : Form
    {
        public frmListaEmpaque()
        {
            InitializeComponent();
            llenarClientes();
        }

        private void llenarClientes()
        {
            List<clsEntity> listaClientes = clsEntity.getCustomerList();

            cmbCliente.Items.Clear();

            for(int i=0;i<listaClientes.Count;i++)
            {
                cmbCliente.Items.Add(listaClientes[i].companyName);
            }
        }

        private void llenarOrdenes()
        {
            DataSet DS = clsConnection.getDataSetResult("spListaDeOC '"+cmbCliente.Items[cmbCliente.SelectedIndex].ToString()+"'");

            cmbOrden.Items.Clear();

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    cmbOrden.Items.Add(DS.Tables[0].Rows[i]["OC"]);
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarOrdenes();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            if(cmbCliente.SelectedIndex!=-1&&cmbOrden.SelectedIndex!=-1)
            {
                dgv.Rows.Clear();
                string pal = "";
                double totpal = 0;
                double totbob = 0;
                double totnet = 0;
                double totbrut = 0;
                txtBobinas.ResetText();
                txtPallets.ResetText();
                txtNeto.ResetText();
                txtBruto.ResetText();

                DataSet DS = clsConnection.getDataSetResult("spListaDeEmpaque '" + cmbCliente.Items[cmbCliente.SelectedIndex].ToString() + "', '" + cmbOrden.Items[cmbOrden.SelectedIndex].ToString()+"'");
                
                if (DS.Tables.Count > 0)
                {
                    if(DS.Tables[0].Rows.Count>0)
                    {
                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            if(DS.Tables[0].Rows[i]["CodeBarPallet"].ToString()==pal)
                            {
                                dgv.Rows.Add();
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Orden.Index].Value = DS.Tables[0].Rows[i]["Orden"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Codigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[DiamCore.Index].Value = DS.Tables[0].Rows[i]["DiamCore"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletBto.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletNeto.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PNetoBobina.Index].Value = DS.Tables[0].Rows[i]["PNetoBobina"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodeBarBobina.Index].Value = DS.Tables[0].Rows[i]["CodeBarBobina"];
                                totbob++;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Metraje.Index].Value = DS.Tables[0].Rows[i]["Metraje"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodInterno.Index].Value = DS.Tables[0].Rows[i]["CodInterno"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[LoteExtrusion.Index].Value = DS.Tables[0].Rows[i]["LoteExtrusion"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodeRMadre.Index].Value = DS.Tables[0].Rows[i]["CodeRMadre"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[FecFabricacionRMadre.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FecFabricacionRMadre"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                dgv.Rows.Add();
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Orden.Index].Value = DS.Tables[0].Rows[i]["Orden"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Codigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[DiamCore.Index].Value = DS.Tables[0].Rows[i]["DiamCore"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodeBarPallet.Index].Value = DS.Tables[0].Rows[i]["CodeBarPallet"];
                                pal = DS.Tables[0].Rows[i]["CodeBarPallet"].ToString();
                                totpal++;
                                totnet += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoPalletNeto"]);
                                totbrut+= Convert.ToDouble(DS.Tables[0].Rows[i]["PesoPalletBto"]);
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletBto.Index].Value = DS.Tables[0].Rows[i]["PesoPalletBto"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletNeto.Index].Value = DS.Tables[0].Rows[i]["PesoPalletNeto"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PNetoBobina.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Metraje.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[FecFabricacionRMadre.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FecFabricacionRMadre"]).ToString("dd/MM/yyyy");
                                dgv.Rows.Add();
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Orden.Index].Value = DS.Tables[0].Rows[i]["Orden"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Codigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[DiamCore.Index].Value = DS.Tables[0].Rows[i]["DiamCore"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletBto.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletNeto.Index].Value = 0;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                                dgv.Rows[dgv.Rows.Count - 1].Cells[PNetoBobina.Index].Value = DS.Tables[0].Rows[i]["PNetoBobina"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodeBarBobina.Index].Value = DS.Tables[0].Rows[i]["CodeBarBobina"];
                                totbob++;
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Metraje.Index].Value = DS.Tables[0].Rows[i]["Metraje"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodInterno.Index].Value = DS.Tables[0].Rows[i]["CodInterno"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[LoteExtrusion.Index].Value = DS.Tables[0].Rows[i]["LoteExtrusion"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[CodeRMadre.Index].Value = DS.Tables[0].Rows[i]["CodeRMadre"];
                                dgv.Rows[dgv.Rows.Count - 1].Cells[FecFabricacionRMadre.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FecFabricacionRMadre"]).ToString("dd/MM/yyyy");
                            }
                        }

                        txtBobinas.Text = totbob.ToString();
                        txtPallets.Text = totpal.ToString();
                        txtNeto.Text = totnet.ToString("0.0");
                        txtBruto.Text = totbrut.ToString("0.0");
                    }
                    
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel WorkBook|*.xlsx";
            sfd.FileName = cmbCliente.Items[cmbCliente.SelectedIndex].ToString().Replace(".", "") +" "+ cmbOrden.Items[cmbOrden.SelectedIndex].ToString().Replace(".", "");
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
    }
}
