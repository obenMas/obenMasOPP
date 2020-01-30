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
    public partial class frmNewOrdersEntry : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        string executive = string.Empty;
        string client = string.Empty;
        clsSalesOrder so = new clsSalesOrder();
        clsSalesOrderDetail sod = new clsSalesOrderDetail();
        bool retReq = false;
        frmSalesOrderControl soc;
        DateTime otif = new DateTime();
        clsProduct objproduct = new clsProduct();

        public frmNewOrdersEntry()
        {
            InitializeComponent();
            FillExecutiveList();
            if (clsGlobal.LoggedUser.RoleName == "Ejecutivo de ventas")
            {
                for(int i=0;i<cmbExecutives.Items.Count;i++)
                {
                    if(cmbExecutives.Items[i].ToString()==clsGlobal.LoggedUser.userName)
                    {
                        cmbExecutives.SelectedIndex = i;
                    }
                }
            }
            else
            {
                FillCustommersList();
            }
        }

        public  frmNewOrdersEntry(int cod, frmSalesOrderControl socon)
        {
            InitializeComponent();
            FillExecutiveList();
            if (clsGlobal.LoggedUser.RoleName == "Ejecutivo de ventas")
            {
                for (int i = 0; i < cmbExecutives.Items.Count; i++)
                {
                    if (cmbExecutives.Items[i].ToString() == clsGlobal.LoggedUser.userName)
                    {
                        cmbExecutives.SelectedIndex = i;
                    }
                }
            }
            else
            {
                FillCustommersList();
            }
            so = new clsSalesOrder(cod);
            txtOC.Text = so.purchaseOrder;
            dtpDate.Value = so.createdDate;
            dtpDeliveryDate.Value = so.compromisedate;
            clsEntity cli = new clsEntity(so.fkEntity);
            clsUser exe = new clsUser(cli.fkUser);
            for (int i = 0; i < cmbExecutives.Items.Count; i++)
            {
                if (cmbExecutives.Items[i].ToString() == exe.userName)
                {
                    cmbExecutives.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbCustommers.Items.Count; i++)
            {
                if (cmbCustommers.Items[i].ToString() == cli.companyName)
                {
                    cmbCustommers.SelectedIndex = i;
                }
            }
            populateDetail();
            this.soc = socon;
            retReq = true;
        }

        public void getDataset(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }
        
        public void FillExecutiveList()
        {
            List<string> executives = new List<string>();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwExecutivesList");

            cmbExecutives.Items.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (!executives.Contains(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString()))
                        executives.Add(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString());
                }
            }

            executives.Sort();

            for (int i = 0; i < executives.Count; i++)
            {
                cmbExecutives.Items.Add(executives[i]);
            }
            
        }

        public void FillCustommersList()
        {
            List<string> custommers = new List<string>();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwCustommerList");

            cmbCustommers.Items.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (!custommers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        custommers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                }
            }

            custommers.Sort();

            for (int i = 0; i < custommers.Count; i++)
            {
                cmbCustommers.Items.Add(custommers[i]);
            }
        }

        public void FillCustommerListByExecutive(string executive)
        {
            List<string> custommers = new List<string>();
            string querystring = "SELECT Cliente FROM vwCustommerList WHERE Usuario = '" + executive + "' ";

            getDataset(querystring);

            cmbCustommers.Items.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (!custommers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        custommers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                }
            }
            
           for (int i = 0; i < custommers.Count; i++)
           {
               cmbCustommers.Items.Add(custommers[i]);
           }

        }

        private void cmbExecutives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbExecutives.SelectedIndex!=-1)
            {
                FillCustommerListByExecutive(cmbExecutives.SelectedItem.ToString());
            }            
            else
            {
                MessageBox.Show("Debe seleccionar una ejecutiva", "Ingreso de Pedidos", MessageBoxButtons.OK);
            }

        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            if(txtProductCode.Text!=string.Empty)
            {
                string productcode = string.Empty;
                productcode = txtProductCode.Text;

                objproduct = new clsProduct(productcode);
                txtProductDescription.Text = objproduct.name;

                calcularOtif();

                if(txtPrice.Text==string.Empty)
                {
                    txtPrice.Text = "0";
                }
                if (txtTDC.Text == string.Empty)
                {
                    txtTDC.Text = "0";
                }
                txtQuantity.Focus();

                
            }
        }

        private void calcularOtif()
        {
            otif = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day).AddDays(objproduct.Bopp.leadTime);

            if(otif<dtpDeliveryDate.Value)
            {
                otif = dtpDeliveryDate.Value;
            }

            dtpOtif.Value = otif;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(validateSo() && validateSod())
            {
                saveDetail();
                txtProductCode.ResetText();
                txtProductDescription.ResetText();
                txtQuantity.ResetText();
                txtPrice.ResetText();
                txtTDC.ResetText();
                txtNotes.ResetText();
            }
            txtProductCode.Focus();
            
        }

        public void saveDetail()
        {
            if (so.codsec == 0)
            {
                so.fkEntity = new clsEntity(cmbCustommers.SelectedItem.ToString()).codsec;
                so.fkCommercialCondition = 26;
                so.fkStatus = 9;
                so.number = clsSalesOrder.GetOrdinalNumber();
                so.createdDate = dtpDate.Value;
                so.createdBy = clsGlobal.LoggedUser.codsec;
                so.modifiedBy = clsGlobal.LoggedUser.codsec;
                so.modifiedDate = DateTime.Now;
                so.compromisedate = dtpDeliveryDate.Value;
                so.fkPlant = 4; //Por defecto planta pilar 30-01-2020 NZ
                so.purchaseOrder = txtOC.Text;
                if (!so.save())
                {
                    MessageBox.Show("Ocurrió un error y no se pudo guardar la orden de venta", "Ingreso de pedidos", MessageBoxButtons.OK);
                }
                so = new clsSalesOrder(so.number);
            }

            sod.fkSalesOrder = so.codsec;
            sod.fkProduct = new clsProduct(txtProductCode.Text).codsec;
            if(sod.fkStatus==0)
            {
                sod.fkStatus = 3058;
            }
            sod.fkStatus = 3058;
            sod.quantity = Math.Round(Convert.ToDouble(txtQuantity.Text), 2);
            sod.price = Math.Round(Convert.ToDouble(txtPrice.Text), 2);
            sod.exchangerate = Math.Round(Convert.ToDouble(txtTDC.Text), 2);
            sod.notes = txtNotes.Text;
            sod.fkPlant = 4; //Por defecto planta pilar 30-01-2020 NZ
            sod.deliveryDate = dtpDeliveryDate.Value;
            sod.otifDate = dtpOtif.Value;
            if (!sod.save())
            {
                MessageBox.Show("Ocurrió un error y no se pudo guardar el detalle de la orden de venta", "Ingreso de pedidos", MessageBoxButtons.OK);
            }
            populateDetail();
            sod = new clsSalesOrderDetail();
        }
        
        public void populateDetail()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderDetailBySaleOrder WHERE sod_fkSalesOrder=" + so.codsec.ToString() + "");

            double TotalKg = 0;
            double TotalUSD = 0;
            double totalArs = 0;
            clsProduct prod = new clsProduct();
            dgvOrdersEntry.Rows.Clear();

            for(int i=0;i<DS.Tables[0].Rows.Count;i++)
            {
                prod = new clsProduct(Convert.ToInt32(DS.Tables[0].Rows[i]["prod_codsec"]));
                dgvOrdersEntry.Rows.Add();
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmProductCodsec.Index].Value = DS.Tables[0].Rows[i]["prod_codsec"];
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmProductCode.Index].Value = prod.code;
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmProductName.Index].Value = prod.description;
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmQuantity.Index].Value = DS.Tables[0].Rows[i]["CantidadSolicitada"];
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmPrice.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2);
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmExchangeRate.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2);
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmSubTotal.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2) * Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmSubtotalPesos.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2) * Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2) * Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmNotes.Index].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmStatusName.Index].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmStock.Index].Value = getAvailableStock(prod.code);
                if (Convert.ToDouble(dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmStock.Index].Value)>0)
                {
                    dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmStock.Index].Style.BackColor = Color.Green;
                }
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmEdit.Index].Value = BPS.Properties.Resources.pencil;
                dgvOrdersEntry.Rows[dgvOrdersEntry.Rows.Count - 1].Cells[clmDelete.Index].Value = BPS.Properties.Resources.cross;
                TotalKg += Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
                TotalUSD += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2) * Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
                totalArs += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2) * Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2) * Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
            }
            textBox10.Text = TotalKg.ToString();
            textBox8.Text = totalArs.ToString();
            textBox9.Text = TotalUSD.ToString();
        }

        public double getAvailableStock(string pro)
        {
            double total = 0;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockPallets '" + pro + "'");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count;i++)
                {
                    total += Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                }
            }
            return Math.Round(total,2);
        }

        private void btnAddDuplicate_Click(object sender, EventArgs e)
        {
            if(validateSo()&&validateSod())
            {
                saveDetail();
            }
            txtProductCode.Focus();
        }

        public bool validateSo()
        {
            if((cmbCustommers.SelectedItem != null))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Ingreso de pedidos", MessageBoxButtons.OK);
                return false;
            }
            
        }

        public bool validateSod()
        {   clsProduct prod = new clsProduct(txtProductCode.Text);
            bool ret = true;

            if(txtProductCode.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Producto.", "Ingreso de pedidos", MessageBoxButtons.OK);
                ret = false;
            }
            if(prod.codsec == 0)
            {
                MessageBox.Show("El código ingresado no corresponde a ningun producto.", "Ingreso de pedidos", MessageBoxButtons.OK);
                ret = false;
            }
            if(txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Cantidad.", "Ingreso de pedidos", MessageBoxButtons.OK);
                ret = false;
            }

            return ret;
        }

        private void dgvOrdersEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index && (dgvOrdersEntry.Rows[e.RowIndex].Cells[clmStatusName.Index].Value.ToString() == "Pendiente"))
            {
                clsSalesOrderDetail.delete(Convert.ToInt32(dgvOrdersEntry.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                populateDetail();
            }

            if (e.ColumnIndex == clmEdit.Index && (dgvOrdersEntry.Rows[e.RowIndex].Cells[clmStatusName.Index].Value.ToString() == "Pendiente"))
            {
                sod = new clsSalesOrderDetail(Convert.ToInt32(dgvOrdersEntry.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                txtProductCode.Text = sod.product.code;
                txtProductDescription.Text = sod.product.description;
                txtQuantity.Text = sod.quantity.ToString();
                txtPrice.Text = sod.price.ToString();
                txtTDC.Text = sod.exchangerate.ToString();
                txtNotes.Text = sod.notes;
                txtProductCode.Focus();
            }
        }

        private void frmNewOrdersEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(retReq)
            {
                soc.getDataSet();
                soc.populateDataGrid();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmbCustommers.SelectedIndex = -1;
            txtOC.ResetText();
            txtProductCode.ResetText();
            txtProductDescription.ResetText();
            txtQuantity.ResetText();
            txtPrice.ResetText();
            txtTDC.ResetText();
            txtNotes.ResetText();
            so = new clsSalesOrder();
            sod = new clsSalesOrderDetail();
            populateDetail();
            txtOC.Focus();
        }

        private void dgvOrdersEntry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmStock.Index)
            {
                frmStockPalletNewOrder form = new frmStockPalletNewOrder(dgvOrdersEntry.Rows[e.RowIndex].Cells[clmProductCode.Index].Value.ToString(), Convert.ToInt32(dgvOrdersEntry.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MaximizeBox = false;
                form.Show();
            }
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            calcularOtif();
        }
    }
}
