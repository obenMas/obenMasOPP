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


namespace BPS.Lite
{
    public partial class frmNewPreShippingList : Form
    {
        public List<string> filtrocreaciones = new List<string>();
        public List<string> filtronumeros = new List<string>();
        public List<string> filtroclientes = new List<string>();
        public List<string> filtrousuarios = new List<string>();
        public List<string> filtroplantas = new List<string>();
        public List<string> filtroestados = new List<string>();
        public List<string> filtrodespachos = new List<string>();
        public string ultimocambio = string.Empty;
        public string creacionfiltrado = string.Empty;
        public string numerofiltrado = string.Empty;
        public string clientefiltrado = string.Empty;
        public string usuariofiltrado = string.Empty;
        public string plantafiltrado = string.Empty;
        public string estadofiltrado = string.Empty;
        public string despachofiltrado = string.Empty;

        public frmNewPreShippingList()
        {
            InitializeComponent();
            txtObj.Text = "100";
            if(clsGlobal.LoggedUser.fkRole==2036)
            {
                dgv.Columns[clmAproved.Index].ReadOnly = false;
                dgv.Columns[FechaPago.Index].ReadOnly = false;
                dgv.Columns[clmValor.Index].Visible = true;
                dgv.Columns[FechaPago.Index].Visible = true;
            }
            if (clsGlobal.LoggedUser.fkRole == 2032)
            {
                dgv.Columns[remito.Index].ReadOnly = false;
            }
            llenarDgv();
        }

        public void llenarDgv()
        {
            DataSet DS = clsNewPreShipping.getControlList(Convert.ToInt32(txtObj.Text));

            dgv.Rows.Clear();

            if (ultimocambio != "creacion")
            {
                cmbFiltroCreacion.Items.Clear();
            }
            if (ultimocambio != "numero")
            {
                cmbFiltroNumero.Items.Clear();
            }
            if (ultimocambio != "cliente")
            {
                cmbFiltroCliente.Items.Clear();
            }
            if (ultimocambio != "usuario")
            {
                cmbFiltroUsuario.Items.Clear();
            }
            if (ultimocambio != "planta")
            {
                cmbFiltroPlanta.Items.Clear();
            }
            if (ultimocambio != "estado")
            {
                cmbFiltroEstado.Items.Clear();
            }
            if (ultimocambio != "despacho")
            {
                cmbFiltroDespacho.Items.Clear();
            }

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    string concat = creacionfiltrado + numerofiltrado + clientefiltrado + usuariofiltrado + plantafiltrado + estadofiltrado + despachofiltrado;
                    string concat2 = string.Empty;

                    if(creacionfiltrado != string.Empty)
                    {
                        concat2 += Convert.ToDateTime(DS.Tables[0].Rows[i]["createdDate"]).ToString("dd/MM/yyyy");
                    }
                    if (numerofiltrado != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["number"].ToString();
                    }
                    if (clientefiltrado != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["companyName"].ToString();
                    }
                    if (usuariofiltrado != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["userName"].ToString();
                    }
                    if (plantafiltrado != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plant"].ToString();
                    }
                    if (estadofiltrado != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["status"].ToString();
                    }
                    if (despachofiltrado != string.Empty)
                    {
                        if (DS.Tables[0].Rows[i]["status"].ToString() == "Programado")
                        {
                            concat2 += Convert.ToDateTime(DS.Tables[0].Rows[i]["shippingDate"]).ToString("dd/MM/yyyy");
                        }
                    }

                    if(concat==concat2)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[codsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[creado.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["createdDate"]).ToString("dd/MM/yyyy");
                        dgv.Rows[dgv.Rows.Count - 1].Cells[numero.Index].Value = DS.Tables[0].Rows[i]["number"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[cliente.Index].Value = DS.Tables[0].Rows[i]["companyName"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[usuario.Index].Value = DS.Tables[0].Rows[i]["userName"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[planta.Index].Value = DS.Tables[0].Rows[i]["plant"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[unidades.Index].Value = DS.Tables[0].Rows[i]["units"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[remito.Index].Value = DS.Tables[0].Rows[i]["Rnumber"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmAproved.Index].Value = Convert.ToBoolean(DS.Tables[0].Rows[i]["aproved"]);
                        if(Convert.ToBoolean(DS.Tables[0].Rows[i]["aproved"]))
                        {
                            dgv.Rows[dgv.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (Convert.ToDouble(DS.Tables[0].Rows[i]["weight"]) < 1000)
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[kilos.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["weight"]).ToString("0.00");
                        }
                        else
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[kilos.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["weight"]).ToString("0,000.00");
                        }
                        if (Convert.ToDouble(DS.Tables[0].Rows[i]["value"]) < 1000)
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[clmValor.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["value"]).ToString("0.00");
                        }
                        else
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[clmValor.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["value"]).ToString("0,000.00");
                        }
                        dgv.Rows[dgv.Rows.Count - 1].Cells[estado.Index].Value = DS.Tables[0].Rows[i]["status"];
                        if (DS.Tables[0].Rows[i]["status"].ToString() == "Programado" || DS.Tables[0].Rows[i]["status"].ToString() == "Despachado")
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[programado.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["shippingDate"]).ToString("dd/MM/yyyy");
                        }
                        if(Convert.ToDateTime(DS.Tables[0].Rows[i]["shippedDate"]).ToString("dd/MM/yyyy")!="01/01/1900")
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[despachado.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["shippedDate"]).ToString("dd/MM/yyyy");
                        }
                        if (Convert.ToDateTime(DS.Tables[0].Rows[i]["paymentDate"]).ToString("dd/MM/yyyy") != "01/01/1900")
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[FechaPago.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["paymentDate"]).ToString("dd/MM/yyyy");
                        }

                        if (!filtrocreaciones.Contains(Convert.ToDateTime(DS.Tables[0].Rows[i]["createdDate"]).ToString("dd/MM/yyyy")))
                            filtrocreaciones.Add(Convert.ToDateTime(DS.Tables[0].Rows[i]["createdDate"]).ToString("dd/MM/yyyy"));

                        if (!filtronumeros.Contains(DS.Tables[0].Rows[i]["number"].ToString()))
                            filtronumeros.Add(DS.Tables[0].Rows[i]["number"].ToString());

                        if (!filtroclientes.Contains(DS.Tables[0].Rows[i]["companyName"].ToString()))
                            filtroclientes.Add(DS.Tables[0].Rows[i]["companyName"].ToString());

                        if (!filtrousuarios.Contains(DS.Tables[0].Rows[i]["userName"].ToString()))
                            filtrousuarios.Add(DS.Tables[0].Rows[i]["userName"].ToString());

                        if (!filtroplantas.Contains(DS.Tables[0].Rows[i]["plant"].ToString()))
                            filtroplantas.Add(DS.Tables[0].Rows[i]["plant"].ToString());

                        if (!filtroestados.Contains(DS.Tables[0].Rows[i]["status"].ToString()))
                            filtroestados.Add(DS.Tables[0].Rows[i]["status"].ToString());

                        if (DS.Tables[0].Rows[i]["status"].ToString() == "Programado")
                        {
                            if (!filtrodespachos.Contains(Convert.ToDateTime(DS.Tables[0].Rows[i]["shippingDate"]).ToString("dd/MM/yyyy")))
                                filtrodespachos.Add(Convert.ToDateTime(DS.Tables[0].Rows[i]["shippingDate"]).ToString("dd/MM/yyyy"));
                        }
                        
                    }
                }
                txtTot.Text = DS.Tables[0].Rows.Count.ToString();
            }
            else
            {
                txtTot.Text = "0";
            }

            filtrocreaciones.Sort();
            filtronumeros.Sort();
            filtroclientes.Sort();
            filtrousuarios.Sort();
            filtroplantas.Sort();
            filtroestados.Sort();
            filtrodespachos.Sort();

            if (ultimocambio != "creacion")
            {
                for (int i = 0; i < filtrocreaciones.Count; i++)
                {
                    cmbFiltroCreacion.Items.Add(filtrocreaciones[i]);
                }
            }

            if (ultimocambio != "numero")
            {
                for (int i = 0; i < filtronumeros.Count; i++)
                {
                    cmbFiltroNumero.Items.Add(filtronumeros[i]);
                }
            }

            if (ultimocambio != "cliente")
            {
                for (int i = 0; i < filtroclientes.Count; i++)
                {
                    cmbFiltroCliente.Items.Add(filtroclientes[i]);
                }
            }

            if (ultimocambio != "usuario")
            {
                for (int i = 0; i < filtrousuarios.Count; i++)
                {
                    cmbFiltroUsuario.Items.Add(filtrousuarios[i]);
                }
            }

            if (ultimocambio != "planta")
            {
                for (int i = 0; i < filtroplantas.Count; i++)
                {
                    cmbFiltroPlanta.Items.Add(filtroplantas[i]);
                }
            }

            if (ultimocambio != "estado")
            {
                for (int i = 0; i < filtroestados.Count; i++)
                {
                    cmbFiltroEstado.Items.Add(filtroestados[i]);
                }
            }

            if (ultimocambio != "despacho")
            {
                for (int i = 0; i < filtrodespachos.Count; i++)
                {
                    cmbFiltroDespacho.Items.Add(filtrodespachos[i]);
                }
            }
        }

        private void cmbFiltroCreacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCreacion.SelectedIndex != -1)
            {
                if (creacionfiltrado != cmbFiltroCreacion.Items[cmbFiltroCreacion.SelectedIndex].ToString())
                {
                    creacionfiltrado = cmbFiltroCreacion.Items[cmbFiltroCreacion.SelectedIndex].ToString();
                    ultimocambio = "creacion";
                    llenarDgv();
                }
            }
            else
            {
                creacionfiltrado = string.Empty;
            }
        }

        private void cmbFiltroNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroNumero.SelectedIndex != -1)
            {
                if (numerofiltrado != cmbFiltroNumero.Items[cmbFiltroNumero.SelectedIndex].ToString())
                {
                    numerofiltrado = cmbFiltroNumero.Items[cmbFiltroNumero.SelectedIndex].ToString();
                    ultimocambio = "numero";
                    llenarDgv();
                }
            }
            else
            {
                numerofiltrado = string.Empty;
            }
        }

        private void cmbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCliente.SelectedIndex != -1)
            {
                if (clientefiltrado != cmbFiltroCliente.Items[cmbFiltroCliente.SelectedIndex].ToString())
                {
                    clientefiltrado = cmbFiltroCliente.Items[cmbFiltroCliente.SelectedIndex].ToString();
                    ultimocambio = "cliente";
                    llenarDgv();
                }
            }
            else
            {
                clientefiltrado = string.Empty;
            }
        }

        private void cmbFiltroUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroUsuario.SelectedIndex != -1)
            {
                if (usuariofiltrado != cmbFiltroUsuario.Items[cmbFiltroUsuario.SelectedIndex].ToString())
                {
                    usuariofiltrado = cmbFiltroUsuario.Items[cmbFiltroUsuario.SelectedIndex].ToString();
                    ultimocambio = "usuario";
                    llenarDgv();
                }
            }
            else
            {
                usuariofiltrado = string.Empty;
            }
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroEstado.SelectedIndex != -1)
            {
                if (estadofiltrado != cmbFiltroEstado.Items[cmbFiltroEstado.SelectedIndex].ToString())
                {
                    estadofiltrado = cmbFiltroEstado.Items[cmbFiltroEstado.SelectedIndex].ToString();
                    ultimocambio = "estado";
                    llenarDgv();
                }
            }
            else
            {
                estadofiltrado = string.Empty;
            }
        }

        private void cmbFiltroDespacho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroDespacho.SelectedIndex != -1)
            {
                if (despachofiltrado != cmbFiltroDespacho.Items[cmbFiltroDespacho.SelectedIndex].ToString())
                {
                    despachofiltrado = cmbFiltroDespacho.Items[cmbFiltroDespacho.SelectedIndex].ToString();
                    ultimocambio = "despacho";
                    llenarDgv();
                }
            }
            else
            {
                despachofiltrado = string.Empty;
            }
        }

        private void cmbFiltroCreacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroCreacion.ResetText();
                creacionfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void cmbFiltroNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroNumero.ResetText();
                numerofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void cmbFiltroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroCliente.ResetText();
                clientefiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void cmbFiltroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroUsuario.ResetText();
                usuariofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void cmbFiltroEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroEstado.ResetText();
                estadofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void cmbFiltroDespacho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroDespacho.ResetText();
                despachofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void txtObj_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(clsGlobal.isNumeric(txtObj.Text))
                {
                    llenarDgv();
                }
                else
                {
                    txtObj.Text = "100";
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==preparar.Index)
            {
                if(e.RowIndex!=-1)
                {
                    clsPrintLabels.printNewPreShippingReport(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[codsec.Index].Value));
                }
            }

            if (e.ColumnIndex == listaemp.Index)
            {
                if (e.RowIndex != -1)
                {
                    clsPrintLabels.printNewPackingListReport(dgv.Rows[e.RowIndex].Cells[numero.Index].Value.ToString());
                }
            }
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == remito.Index)
            {
                if (e.RowIndex != -1)
                {
                    if(dgv.Rows[e.RowIndex].Cells[remito.Index].Value!=null)
                    {
                        clsNewPreShipping nps = new clsNewPreShipping(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[codsec.Index].Value));
                        if (!nps.setRnumber(dgv.Rows[e.RowIndex].Cells[remito.Index].Value.ToString()))
                        {
                            MessageBox.Show("Ocurrió un error y no se pudo grabar el numero de remito. Consulte con el administrador del sistema.", "Listado de pre-despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    llenarDgv();
                }
            }

            if (e.ColumnIndex == clmAproved.Index)
            {
                if (e.RowIndex != -1)
                {
                    if (Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[clmAproved.Index].Value))
                    {
                        clsNewPreShipping nps = new clsNewPreShipping(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[codsec.Index].Value));
                        if (!nps.setAsAproved())
                        {
                            MessageBox.Show("Ocurrió un error y no se pudo grabar la modificación. Consulte con el administrador del sistema.", "Listado de pre-despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        clsNewPreShipping nps = new clsNewPreShipping(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[codsec.Index].Value));
                        if (!nps.setAsNotAproved())
                        {
                            MessageBox.Show("Ocurrió un error y no se pudo grabar la modificación. Consulte con el administrador del sistema.", "Listado de pre-despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    //llenarDgv();
                }
            }

            if (e.ColumnIndex == FechaPago.Index)
            {
                if (e.RowIndex != -1)
                {
                    clsNewPreShipping nps = new clsNewPreShipping(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[codsec.Index].Value));
                    if (dgv.Rows[e.RowIndex].Cells[FechaPago.Index].Value != null)
                    {
                        try
                        {
                            if(nps.setPaymentDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells[FechaPago.Index].Value)))
                            {
                                MessageBox.Show("Cambios guardados correctamente", "Listado de pre-despachos", MessageBoxButtons.OK);
                            }
                            else
                            {                                
                                MessageBox.Show("Ocurrió un error y no se pudo grabar la modificación. Consulte con el administrador del sistema.", "Listado de pre-despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (FormatException ex)
                        {
                            clsLog.addLog(ex, 1, "paymentdate.edit");
                            MessageBox.Show("El valor ingresado no puede ser reconocido como una fecha", "Fecha no reconocida", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        nps.setPaymentDate(new DateTime(1900, 01, 01));
                    }
                    //llenarDgv();
                }
            }
        }

        private void cmbFiltroPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPlanta.SelectedIndex != -1)
            {
                if (plantafiltrado != cmbFiltroPlanta.Items[cmbFiltroPlanta.SelectedIndex].ToString())
                {
                    plantafiltrado = cmbFiltroPlanta.Items[cmbFiltroPlanta.SelectedIndex].ToString();
                    ultimocambio = "planta";
                    llenarDgv();
                }
            }
            else
            {
                plantafiltrado = string.Empty;
            }
        }

        private void cmbFiltroPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPlanta.ResetText();
                plantafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenarDgv();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<string> listaFechas = new List<string>();

            string ext = string.Empty;

            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgv.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
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
