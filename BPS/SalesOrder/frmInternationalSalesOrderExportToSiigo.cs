using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmInternationalSalesOrderExportToSiigo : Form
    {
        List<string> lstSalesOrder = new List<string>();
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        public List<string> resultExportData = new List<string>();
        clsEntity objCustomer = new clsEntity();
        string mydata = string.Empty, OrderNumberValidator = string.Empty;

        public frmInternationalSalesOrderExportToSiigo()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdSiigo.ShowDialog();
            txtFileName.Text = ofdSiigo.FileName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            importFromFile();
        }

        public void importFromFile()
        {
            Microsoft.Office.Interop.Excel._Application xlApp;
            Microsoft.Office.Interop.Excel._Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel._Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Open(txtFileName.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlRange = xlWorkSheet.UsedRange;

            for (int i = 8; i < xlRange.Rows.Count + 1; i++)
            {
                for (int j = 3; j < 19; j++)
                {
                    if (j == 6)
                        mydata += (xlRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value.ToString().Trim().Replace(" 0:00:00", "") + ",";
                    else if (j == 7 || j == 8 || j == 10 || j == 11)
                    {

                    }
                    else
                        mydata += (xlRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString().Trim() + ",";
                }
                lstSalesOrder.Add(mydata);
                mydata = string.Empty;
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            PopulateData(lstSalesOrder);
        }

        private void PopulateData(List<string> lstSalesOrder)
        {
            int totalItemsByOrder = 0;
            int lastPosition = -1;
            OrderNumberValidator = string.Empty;
            dgvImportedPallets.Rows.Clear();
            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                string[] parts = lstSalesOrder[i].Split(',');
                List<string> myList = new List<string>(parts);
                if (OrderNumberValidator == string.Empty)
                    OrderNumberValidator = (myList.Count > 0) ? OrderNumber(myList[0].ToString()) : string.Empty;
                if (OrderNumber(myList[0].ToString()) == OrderNumberValidator)
                    totalItemsByOrder++;
                else
                {
                    dgvImportedPallets.Rows.Add();
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmNumber.Index].Value = OrderNumberValidator;
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductDescription.Index].Value = totalItemsByOrder;
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmQuantity.Index].Value = CalculeQuantiy(OrderNumberValidator);
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmSubTotal.Index].Value = CalculeValue(OrderNumberValidator);
                    for (int j = 0; j < dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells.Count; j++)
                    {
                        System.Drawing.Font fntBold = new System.Drawing.Font(dgvImportedPallets.Font, FontStyle.Bold);
                        dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }
                    OrderNumberValidator = OrderNumber(myList[0].ToString());
                    totalItemsByOrder = 1;

                }
                dgvImportedPallets.Rows.Add();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmNumber.Index].Value = OrderNumber(myList[0].ToString());
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmMicrons.Index].Value = CalculateMicrons(myList[2].ToString());
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDescription.Index].Value = myList[2].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDate.Index].Value = myList[3].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmIdentify.Index].Value = myList[4].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmName.Index].Value = myList[5].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductCode.Index].Value = myList[6].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDescriptionII.Index].Value = myList[7].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmReference.Index].Value = myList[8].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmPrice.Index].Value = myList[9].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmQuantity.Index].Value = myList[10].ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmSubTotal.Index].Value = ((Convert.ToDouble(myList[9])) * (Convert.ToDouble(myList[10]))).ToString();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmfkEntity.Index].Value = FindCustomer(myList[4].ToString(), myList[5].ToString());
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmfkProduct.Index].Value = clsProduct.getExternalEquivalenceToSIIGO(myList[2].ToString(), myList[6].ToString(), myList[8].ToString(), myList[7].ToString(), CalculateMicrons(myList[2].ToString()));

                if (Convert.ToInt32(dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmfkProduct.Index].Value) == 0)
                {
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductDescription.Index].Style.BackColor = Color.Red;
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductDescription.Index].Value = "-----";
                }
                else
                {
                    clsProduct ObjProduct = new clsProduct(Convert.ToInt32(dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmfkProduct.Index].Value));
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductDescription.Index].Value = ObjProduct.code;
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductDescription.Index].Style.BackColor = Color.White;
                }

                if (FindCustomer(myList[4].ToString(), myList[5].ToString()) == 0)
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmName.Index].Style.BackColor = Color.Red;
                else
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmName.Index].Style.BackColor = Color.White;

                lastPosition = i;
                if (lastPosition > -1)
                    OrderNumberValidator = dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmNumber.Index].Value.ToString();
            }
        }

        private int FindCustomer(string identify, string customerName)
        {
            clsEntity ObjEntity = new clsEntity();
            ObjEntity.load(identify, string.Empty);
            if (ObjEntity.codsec > 0)
                return ObjEntity.codsec;
            else
            {
                ObjEntity = new clsEntity();
                ObjEntity.load(string.Empty, customerName, string.Empty);
                if (ObjEntity.codsec > 0)
                    return ObjEntity.codsec;
                else
                    return 0;
            }
        }

        private double CalculeValue(string OrderNumberValidator)
        {
            double value = 0;
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmNumber.Index].Value.ToString() == OrderNumberValidator)
                    value += Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmSubTotal.Index].Value);
            }
            return value;
        }

        private double CalculeQuantiy(string OrderNumberValidator)
        {
            double value = 0;
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmNumber.Index].Value.ToString() == OrderNumberValidator)
                    value += Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmQuantity.Index].Value);
            }
            return value;
        }

        private string OrderNumber(string number)
        {
            string mydata = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString() != "0")
                {
                    for (int j = i; j < number.Length; j++)
                        mydata += number[j].ToString();
                    break;
                }
            }
            return mydata;
        }

        private string CalculateMicrons(string number)
        {
            string mydata = string.Empty;
            if (number.LastIndexOf("MM") > 0)
            {
                for (int i = (number.LastIndexOf("MM") - 1); i < number.Length; i--)
                {
                    if (number[i].ToString() != "-")
                        mydata += number[i].ToString();
                    else
                        break;
                }
                number = mydata;
                mydata = string.Empty;
                for (int i = 0; i < number.Length; i++)
                    mydata = number[i] + mydata;
            }
            else
                mydata = "-----";
            return mydata;
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
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgvImportedPallets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmProductDescription.Index && dgvImportedPallets.Rows[e.RowIndex].Cells[clmProductDescription.Index].Style.BackColor == Color.Red && dgvImportedPallets.Rows[e.RowIndex].Cells[clmProductDescription.Index].Value.ToString() == "-----")
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this);
                winProductList.ShowDialog(this);
                if (selectedProductCodsec > 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvImportedPallets.CurrentRow.Cells[clmfkProduct.Index].Value = objSelectedProduct.codsec;
                    dgvImportedPallets.CurrentRow.Cells[clmProductDescription.Index].Value = objSelectedProduct.code;
                    dgvImportedPallets.CurrentRow.Cells[clmProductDescription.Index].Style.BackColor = Color.White;
                }
            }
            else if (e.ColumnIndex == clmName.Index && dgvImportedPallets.Rows[e.RowIndex].Cells[clmName.Index].Style.BackColor == Color.Red)
            {
                var ordernumber = dgvImportedPallets.Rows[e.RowIndex].Cells[clmNumber.Index].Value.ToString();
                objCustomer = new clsEntity();
                frmCustomerList winCustomerList = new frmCustomerList(this);
                winCustomerList.ShowDialog(this);
                objCustomer.load(selectedCustomerCodsec);
                for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                {
                    if ((dgvImportedPallets.Rows[i].Cells[clmNumber.Index].Value.ToString() == ordernumber) && dgvImportedPallets.Rows[i].Cells[clmDescription.Index].Value != null)
                    {
                        dgvImportedPallets.Rows[i].Cells[clmName.Index].Value = objCustomer.companyName;
                        dgvImportedPallets.Rows[i].Cells[clmfkEntity.Index].Value = objCustomer.codsec;
                        dgvImportedPallets.Rows[i].Cells[clmName.Index].Style.BackColor = Color.White;
                    }
                }
            }
            else if (e.ColumnIndex == clmComercialCondition.Index)
            {
                List<string> lstOrder = new List<string>();
                for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                    lstOrder.Add(dgvImportedPallets.Rows[i].Cells[clmNumber.Index].Value.ToString());

                lstOrder = lstOrder.Distinct().ToList();
                lstOrder.Sort();

                frmExportDataInternationalSalesOrder winExport = new frmExportDataInternationalSalesOrder(this, "ComercialCondition", lstOrder);
                winExport.ShowDialog(this);

            }
        }

        private void dgvImportedPallets_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvImportedPallets.CurrentCell.ColumnIndex == 2 && e.KeyCode == Keys.F4)
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this);
                winProductList.ShowDialog(this);
                if (selectedProductCodsec > 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvImportedPallets.CurrentRow.Cells[clmfkProduct.Index].Value = objSelectedProduct.codsec;
                    dgvImportedPallets.CurrentRow.Cells[clmProductDescription.Index].Value = objSelectedProduct.code;
                    dgvImportedPallets.CurrentRow.Cells[clmProductDescription.Index].Style.BackColor = Color.White;
                }
            }
            else if (dgvImportedPallets.CurrentCell.ColumnIndex == 4 && e.KeyCode == Keys.F4)
            {
                var ordernumber = dgvImportedPallets.CurrentRow.Cells[clmNumber.Index].Value.ToString();
                objCustomer = new clsEntity();
                frmCustomerList winCustomerList = new frmCustomerList(this);
                winCustomerList.ShowDialog(this);
                objCustomer.load(selectedCustomerCodsec);
                for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                {
                    if ((dgvImportedPallets.Rows[i].Cells[clmNumber.Index].Value.ToString() == ordernumber) && dgvImportedPallets.Rows[i].Cells[clmDescription.Index].Value != null)
                    {
                        dgvImportedPallets.Rows[i].Cells[clmName.Index].Value = objCustomer.companyName;
                        dgvImportedPallets.Rows[i].Cells[clmfkEntity.Index].Value = objCustomer.codsec;
                        dgvImportedPallets.Rows[i].Cells[clmName.Index].Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
