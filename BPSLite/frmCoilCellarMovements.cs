using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCoilCellarMovements : Form
    {
        clsPallet objPallet = new clsPallet();
        clsReturn objReturn = new clsReturn();
        clsMaquile objMaquile = new clsMaquile();
        clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();
        clsMillPalletbyCoilCellar objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
        clsMillPallet objMillPallet = new clsMillPallet();

        //Thread thrdMovementType;
        //Thread thrdPalletMovement;
        clsCoilCellar objDestinationCellar = new clsCoilCellar();
        bool flgIn = false;
        int codsec = 0;
        string movement = string.Empty;
        string myMovement = "";

        public frmCoilCellarMovements()
        {
            InitializeComponent();
            tbcMovements.TabPages.Remove(tbpPallets);
            tbcMovements.TabPages.Remove(tbpReturn);
            tbcMovements.TabPages.Remove(tbpMetalizate);
            tbcMovements.TabPages.Remove(tbpMaquile);
            tbcMovements.TabPages.Remove(tbpReProcess);
        }

        public void setMovementType()
        {
            //this.Invoke((MethodInvoker)delegate { txtMovement.Enabled = false; });
            //this.Invoke((MethodInvoker)delegate { setMovement(); });
            //this.Invoke((MethodInvoker)delegate { txtMovement.Enabled = true; });
            setMovement();
        }

        private void ProcessMovement()
        {
            for (int i = 0; i < dgvPallets.Rows.Count; i++)
            {
                try
                {
                    if (flgIn == true)
                    {
                        objPallet.load(Convert.ToInt32(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value));
                        if (Convert.ToInt32(dgvPallets.Rows[i].Cells[clmcountpallet.Index].Value) == 1 && dgvPallets.Rows[i].Cells[clmdiference.Index].Value.ToString() == "OK")
                        {
                            objPallet.updatePosition(dgvPallets.Rows[i].Cells[clmPosition.Index].Value.ToString());
                            clsCoilCellar objCoilCellar = objDestinationCellar;                                
                            clsPallet.transferTo(objPallet, objCoilCellar.codsec);
                            clsPallet.transferTo(DateTime.Now, objPallet.code, objPallet.codsec, objCoilCellar.codsec, objPallet.product.code, objPallet.palletNumber, objPallet.customerName, objPallet.salesOrderNumber, Convert.ToInt32(objPallet.product.width), objPallet.netWeight, movement, true);
                            dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.check;
                            if(objDestinationCellar.name != "Producto interplanta")
                            {
                                clsPallet.savein(objPallet);
                            }
                                
                        }
                        else
                            dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.cross;   
                    }
                    else
                    {
                        if(movement=="Cambio de ubicación")
                        {
                            objPallet.load(Convert.ToInt32(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value));
                            objPallet.updatePosition(dgvPallets.Rows[i].Cells[clmPosition.Index].Value.ToString());
                            dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.check;
                        }
                        else
                        {
                            objPallet.load(Convert.ToInt32(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value));
                            objPallet.fkCoilCellar = clsPallet.getContainerCellarByPallet(objPallet.codsec).codsec;
                            objPallet.updatePosition("0");
                            clsPallet.transferTo(objPallet, objDestinationCellar.codsec);
                            clsPallet.transferTo(DateTime.Now, objPallet.code, objPallet.codsec, objPallet.fkCoilCellar, objPallet.product.code, objPallet.palletNumber, objPallet.customerName, objPallet.salesOrderNumber, Convert.ToInt32(objPallet.product.width), objPallet.netWeight, movement, false);
                            dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.check;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ObenMas-Lite", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
            }
        }

        public void setMovement()
        {
            if(txtMovement.Text!="move")
            {
                clsCoilCellarMovement objCoilCellarMovement = clsCoilCellarMovement.getCoilCellarDetailByCode(txtMovement.Text);
                objDestinationCellar = new clsCoilCellar();

                if (objCoilCellarMovement.codsec > 0)
                {
                    objDestinationCellar = new clsCoilCellar(objCoilCellarMovement.fkCoilCellar);

                    if (objCoilCellarMovement.inputToCellar)
                    {
                        tbcMovements.TabPages.Clear();
                        tbcMovements.TabPages.Insert(0, tbpMovementType);
                        tbcMovements.TabPages.Insert(1, tbpPallets);
                        tbpPallets.Text = "Ingreso de pallet a bodega";
                        tbpPallets.ImageIndex = 0;
                        if (objCoilCellarMovement.code == "in001")
                        {
                            movement = "Ingreso a Bodega de producto terminado";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        if (objCoilCellarMovement.code == "in002")
                        {
                            movement = "Ingreso a Bodega de producto en proceso";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        if (objCoilCellarMovement.code == "in003")
                        {
                            movement = "Ingreso a Bodega de bases y metalizados";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        if (objCoilCellarMovement.code == "in004")
                        {
                            movement = "Ingreso a Bodega de producto interplanta";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        flgIn = true;
                    }
                    else
                    {
                        tbcMovements.TabPages.Clear();
                        tbcMovements.TabPages.Insert(0, tbpMovementType);
                        tbcMovements.TabPages.Insert(1, tbpPallets);
                        tbpPallets.Text = "Salida de pallet de bodega";
                        tbpPallets.ImageIndex = 1;
                        if (objCoilCellarMovement.code == "out001")
                        {
                            movement = "Salida a bodega de conversión";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        if (objCoilCellarMovement.code == "out002")
                        {
                            movement = "Salida a bodega de producto en proceso";
                            codsec = objCoilCellarMovement.fkCoilCellar;
                        }
                        flgIn = false;
                    }

                    tbcMovements.SelectedIndex = 1;
                    txtPalletCode.Text = "";
                    dgvPallets.Rows.Clear();
                    ActiveControl = txtPalletCode;
                }
                else
                {
                    //this.Invoke((MethodInvoker)delegate { txtMovement.Enabled = true; });
                    //this.Invoke((MethodInvoker)delegate { txtMovement.Text = string.Empty; });
                    txtMovement.Text = "";
                    MessageBox.Show("Código de movimiento a bodega no reconocido", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtMovement.Focus();
                    //this.Invoke((MethodInvoker)delegate { txtMovement.Focus(); });
                }
            }
            else
            {
                tbcMovements.TabPages.Clear();
                tbcMovements.TabPages.Insert(0, tbpMovementType);
                tbcMovements.TabPages.Insert(1, tbpPallets);
                tbpPallets.Text = "Cambio de ubicación";
                tbpPallets.ImageIndex = 0;
                movement = "Cambio de ubicación";
                flgIn = false;
                tbcMovements.SelectedIndex = 1;
                txtPalletCode.Text = "";
                dgvPallets.Rows.Clear();
                ActiveControl = txtPalletCode;
            }

        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPalletCode.Text == "Cancel" || txtPalletCode.Text == "BACK" || txtPalletCode.Text == "BACK ")
                    {
                        if (dgvPallets.Rows.Count > 0)
                        {
                            for (int i = 0; i < dgvPallets.Rows.Count; i++)
                            {
                                if (dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value == null || dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value.ToString() == string.Empty)
                                {
                                    if (MessageBox.Show("Está realmente seguro que desea cancelar los movimientos", "Movimientos Bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        tbpPallets.Text = "Pallets";
                                        tbpPallets.ImageIndex = -1;
                                        tbcMovements.SelectedIndex = 0;
                                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                        //this.Invoke((MethodInvoker)delegate { txtMovement.Text = string.Empty; });
                                        //this.Invoke((MethodInvoker)delegate { dgvPallets.Rows.Clear(); });
                                        txtPalletCode.Text = "";
                                        txtMovement.Text = "";
                                        dgvPallets.Rows.Clear();
                                        ActiveControl = txtMovement;
                                        break;
                                    }
                                    else
                                    {
                                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                        txtPalletCode.Text = "";
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Está realmente seguro que desea cancelar los movimientos", "Movimientos Bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        tbpPallets.Text = "Pallets";
                                        tbpPallets.ImageIndex = -1;
                                        tbcMovements.SelectedIndex = 0;
                                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                        //this.Invoke((MethodInvoker)delegate { txtMovement.Text = string.Empty; });
                                        //this.Invoke((MethodInvoker)delegate { dgvPallets.Rows.Clear(); });
                                        txtPalletCode.Text = "";
                                        txtMovement.Text = "";
                                        dgvPallets.Rows.Clear();
                                        ActiveControl = txtMovement;
                                        break;
                                    }
                                    else
                                    {
                                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                        txtPalletCode.Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Está realmente seguro que desea cancelar los movimientos", "Movimientos Bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                tbpPallets.Text = "Pallets";
                                tbpPallets.ImageIndex = -1;
                                tbcMovements.SelectedIndex = 0;
                                //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                //this.Invoke((MethodInvoker)delegate { txtMovement.Text = string.Empty; });
                                //this.Invoke((MethodInvoker)delegate { dgvPallets.Rows.Clear(); });
                                txtPalletCode.Text = "";
                                txtMovement.Text = "";
                                dgvPallets.Rows.Clear();
                                ActiveControl = txtMovement;
                            }
                            else
                            {
                                //   this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                                txtPalletCode.Text = "";
                            }
                        }
                    }
                    if (txtPalletCode.Text == "Process")
                    {
                        ProcessMovement();
                        txtPalletCode.Text = "";
                        txtPalletCode.Focus();
                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Text = string.Empty; });
                        //this.Invoke((MethodInvoker)delegate { txtPalletCode.Focus(); });
                    }
                    else if (txtPalletCode.Text != "")
                    {
                        if (flgIn || movement == "Cambio de ubicación")
                        {
                            txtPosition.Enabled = true;
                            lblPosition.Enabled = true;
                            txtPalletCode.Enabled = false;
                            lblPalletCode.Enabled = false;

                            txtPosition.Focus();
                        }
                        else
                        {

                            objPallet = clsPallet.getDetailByCodeWithAuditory(txtPalletCode.Text);
                            //objPallet.position = txtPosition.Text;

                            if (objPallet.countpallet == 1)
                            {
                                if (objPallet.diference == "OK")
                                {
                                    if (objPallet.codsec != 0)
                                    {
                                        clsSalesOrder objSalesOrder = new clsSalesOrder();

                                        objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);

                                        bool coincidence = false;

                                        for (int i = 0; i < dgvPallets.Rows.Count;i++)
                                        {
                                            if(Convert.ToInt32(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value)==objPallet.codsec)
                                            {
                                                coincidence = true;
                                            }
                                        }

                                        if(!coincidence)
                                        {
                                            dgvPallets.Rows.Add();
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPallets.Rows.Count == 1) ? 1 : dgvPallets.Rows.Count;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCodsec.Index].Value = objPallet.codsec;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = objPallet.code;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletProduct.Index].Value = objPallet.product.code;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletSalesOrder.Index].Value = objSalesOrder.ToString();
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.lstCoil.Count.ToString();
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletNetWeight.Index].Value = Math.Round(objPallet.netWeight, 1);
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 1);
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPosition.Index].Value = objPallet.position;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmdiference.Index].Value = objPallet.diference;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmcountpallet.Index].Value = objPallet.countpallet;
                                            if (objPallet.diference == "HP")
                                            {

                                                for (int j = 0; j < dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells.Count; j++)
                                                {
                                                    Font fntBold = new Font(dgvPallets.Font, FontStyle.Bold);
                                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.BackColor = Color.Red;
                                                }
                                            }
                                            else if (objPallet.countpallet != 1)
                                            {

                                                for (int j = 0; j < dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells.Count; j++)
                                                {
                                                    Font fntBold = new Font(dgvPallets.Font, FontStyle.Bold);
                                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.BackColor = Color.Orange;
                                                }
                                            }
                                        }


                                        

                                        txtPalletCode.Enabled = true;
                                        lblPalletCode.Enabled = true;
                                        txtPosition.Enabled = false;
                                        lblPosition.Enabled = false;
                                        txtPalletCode.Text = "";
                                        txtPosition.Text = "";
                                        txtPalletCode.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El código ingresado no corresponde a ningún pallet registrado. Por favor intente de nuevo.", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtPalletCode.Enabled = true;
                                        lblPalletCode.Enabled = true;
                                        txtPosition.Enabled = false;
                                        lblPosition.Enabled = false;
                                        txtPalletCode.Text = "";
                                        txtPosition.Text = "";
                                        txtPalletCode.Focus();
                                    }
                                }
                                else
                                {
                                    if (objPallet.diference == "PESOS_DIF")
                                    {
                                        MessageBox.Show("El código " + objPallet.code + "\n P.Neto :" + objPallet.netWeight + "\n P.Bruto :" + objPallet.grossWeight + "\n Este pallet no podrá ser ingresado hasta que se corrija el peso Bruto en Corte", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtPalletCode.Enabled = true;
                                        lblPalletCode.Enabled = true;
                                        txtPosition.Enabled = false;
                                        lblPosition.Enabled = false;
                                        txtPalletCode.Text = "";
                                        txtPosition.Text = "";
                                        txtPalletCode.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El código " + objPallet.code + " tiene un peso de en la paleta de P.Neto :" + objPallet.netWeight + "\n Las bobinas tienen un peso de P.Neto :" + objPallet.coilnetweigth + "\nEste pallet no podrá ser ingresado a bodega comunicar a PLANTA / SISTEMAS", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtPalletCode.Enabled = true;
                                        lblPalletCode.Enabled = true;
                                        txtPosition.Enabled = false;
                                        lblPosition.Enabled = false;
                                        txtPalletCode.Text = "";
                                        txtPosition.Text = "";
                                        txtPalletCode.Focus();
                                    }
                                }

                            }
                            else
                            {
                                if (objPallet.countpallet > 1)
                                {
                                    MessageBox.Show("El pallet " + objPallet.code + " está duplicado. Por favor comunicar a sistemas.", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    txtPalletCode.Enabled = true;
                                    lblPalletCode.Enabled = true;
                                    txtPosition.Enabled = false;
                                    lblPosition.Enabled = false;
                                    txtPalletCode.Text = "";
                                    txtPosition.Text = "";
                                    txtPalletCode.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("El pallet " + objPallet.code + " no existe. Por favor verifique el código ingresado", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    txtPalletCode.Enabled = true;
                                    lblPalletCode.Enabled = true;
                                    txtPosition.Enabled = false;
                                    lblPosition.Enabled = false;
                                    txtPalletCode.Text = "";
                                    txtPosition.Text = "";
                                    txtPalletCode.Focus();
                                }
                                
                            }

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void frmCoilCellarMovements_Load(object sender, EventArgs e)
        {
            ActiveControl = txtMovement;
            //this.Invoke((MethodInvoker)delegate { txtMovement.Text = string.Empty; });
            //this.Invoke((MethodInvoker)delegate { txtMovement.Focus(); });
            txtMovement.Text = "";
            txtMovement.Focus();
            rdbDMT.Visible = false;
            rdbMW.Visible = false;
        }

        private void txtMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //thrdMovementType = new Thread(delegate() { setMovementType(); });
                //thrdMovementType.Start();
                setMovementType();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tbpPallets.Text = "Pallets";
            tbpPallets.ImageIndex = -1;
            dgvPallets.Rows.Clear();
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = string.Empty;
            txtMovement.Focus();
            ActiveControl = txtMovement;
        }

        private void dgvPallets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmnumber.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el pallet seleccionado", "Movimientos de bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dgvPallets.Rows.RemoveAt(e.RowIndex);
                    ReCountRows();
                }
            }
        }

        private void ReCountRows()
        {
            for (int i = 0; i < dgvPallets.Rows.Count; i++)
                dgvPallets.Rows[i].Cells[clmnumber.Index].Value = (i + 1);
        }

        private void txtReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtReturn.Text != string.Empty && txtReturn.Text != "Process")
                {
                    objReturn = clsReturn.getMovementByCode(txtReturn.Text);
                    if (objReturn.codsec > 0)
                    {
                        dgvReturn.Rows.Add();
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturncodsec.Index].Value = objReturn.codsec;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturnnumber.Index].Value = (dgvReturn.Rows.Count == 1) ? 1 : dgvReturn.Rows.Count;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturncustomer.Index].Value = objReturn.customer;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturnproduct.Index].Value = objReturn.product;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturnnote.Index].Value = objReturn.notes;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturnweigth.Index].Value = objReturn.weigth;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturncode.Index].Value = objReturn.code;
                        dgvReturn.Rows[dgvReturn.Rows.Count - 1].Cells[clmreturndelete.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        txtReturn.Text = "";
                        txtReturn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No existe devolución con ese código por favor verifique el código e inténtelo nuevamente", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtReturn.Text = "";
                        txtReturn.Focus();
                    }
                }
                if (txtReturn.Text == "Process")
                    ProcessReturnMovements();
            }
        }

        private void ProcessReturnMovements()
        {
            for (int i = 0; i < dgvReturn.Rows.Count; i++)
            {
                try
                {
                    objReturn = new clsReturn();
                    objReturn.load(Convert.ToInt32(dgvReturn.Rows[i].Cells[clmreturncodsec.Index].Value.ToString()), true);
                    objReturn.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Devoluciones", "Proceso").codsec;
                    objReturn.save();
                    clsReturn ObjOutReturn = new clsReturn();
                    ObjOutReturn.code = objReturn.code;
                    ObjOutReturn.fkFilm = objReturn.fkFilm;
                    ObjOutReturn.fkProduct = objReturn.fkProduct;
                    ObjOutReturn.customer = objReturn.customer;
                    ObjOutReturn.cellarName = "Proceso";
                    ObjOutReturn.notes = objReturn.notes;
                    ObjOutReturn.weigth = objReturn.weigth;
                    ObjOutReturn.movement = "H023";
                    ObjOutReturn.cellar = "0023";
                    ObjOutReturn.ingress = false;
                    ObjOutReturn.outt = true;
                    ObjOutReturn.boppweigth = objReturn.boppweigth;
                    ObjOutReturn.oppweigth = objReturn.oppweigth;
                    ObjOutReturn.pallet = objReturn.pallet;
                    ObjOutReturn.coil = objReturn.coil;
                    ObjOutReturn.fkExport = objReturn.fkExport;
                    if (ObjOutReturn.save(true))
                        dgvReturn.Rows[i].Cells[clmreturndelete.Index].Value = global::BPS.Lite.Properties.Resources.check;
                    else
                        dgvReturn.Rows[i].Cells[clmreturndelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
                catch (Exception ex)
                {
                    dgvReturn.Rows[i].Cells[clmreturndelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    MessageBox.Show(ex.Message, "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    break;
                }
            }
        }

        private void dgvReturn_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea eliminar la devolución seleccionada", "Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvReturn.Rows.Count; i++)
                    dgvReturn.Rows[i].Cells[clmreturnnumber.Index].Value = i;
            }
        }

        private void txtMaquile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMaquile.Text != string.Empty && txtMaquile.Text != "Process")
                {
                    objMaquile = clsMaquile.getMovementByCode(txtMaquile.Text);
                    if (objMaquile.codsec > 0)
                    {
                        dgvMaquile.Rows.Add();
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecodsec.Index].Value = objMaquile.codsec;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilenumber.Index].Value = (dgvMaquile.Rows.Count == 1) ? 1 : dgvMaquile.Rows.Count;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecustomer.Index].Value = objMaquile.customer;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileproduct.Index].Value = objMaquile.product + " - " + objMaquile.name;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilenote.Index].Value = objMaquile.notes;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileweigth.Index].Value = objMaquile.weigth;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecode.Index].Value = objMaquile.code;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiledelete.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        txtMaquile.Text = "";
                        txtMaquile.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No existe maquila con ese código por favor verifique el código e inténtelo nuevamente", "Maquila", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtMaquile.Text = "";
                        txtMaquile.Focus();
                    }
                }
                if (txtMaquile.Text == "Process")
                    ProcessMaquileMovements();
            }
        }

        private void ProcessMaquileMovements()
        {
            for (int i = 0; i < dgvMaquile.Rows.Count; i++)
            {
                try
                {
                    objMaquile = new clsMaquile();
                    objMaquile.load(Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilecodsec.Index].Value.ToString()));
                    objMaquile.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Maquilas", "Proceso").codsec;
                    objMaquile.save();
                    clsMaquile ObjOutMaquile = new clsMaquile();
                    ObjOutMaquile.code = objMaquile.code;
                    ObjOutMaquile.fkProduct = objMaquile.fkProduct;
                    ObjOutMaquile.customer = objMaquile.customer;
                    ObjOutMaquile.cellarName = "Proceso";
                    ObjOutMaquile.notes = objMaquile.notes;
                    ObjOutMaquile.weigth = objMaquile.weigth;
                    ObjOutMaquile.movement = "H013";
                    ObjOutMaquile.cellar = "0019";
                    ObjOutMaquile.ingress = false;
                    ObjOutMaquile.outt = true;
                    ObjOutMaquile.boppweigth = objMaquile.boppweigth;
                    ObjOutMaquile.oppweigth = objMaquile.oppweigth;
                    ObjOutMaquile.pallet = objMaquile.pallet;
                    ObjOutMaquile.coil = objMaquile.coil;
                    ObjOutMaquile.diameter = objMaquile.diameter;
                    ObjOutMaquile.core = objMaquile.core;
                    ObjOutMaquile.width = objMaquile.width;
                    ObjOutMaquile.fkExport = 353;
                    ObjOutMaquile.fkProductFrom = objMaquile.fkProductFrom;
                    ObjOutMaquile.fkProductTo = objMaquile.fkProductTo;
                    if (ObjOutMaquile.save(true))
                        dgvMaquile.Rows[i].Cells[clmmaquiledelete.Index].Value = global::BPS.Lite.Properties.Resources.check;
                    else
                        dgvMaquile.Rows[i].Cells[clmmaquiledelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
                catch (Exception ex)
                {
                    dgvMaquile.Rows[i].Cells[clmmaquiledelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    MessageBox.Show(ex.Message, "Maquilas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbpReturn.Text = "Pallets";
            tbpReturn.ImageIndex = -1;
            dgvReturn.Rows.Clear();
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = string.Empty;
            txtMovement.Focus();
            ActiveControl = txtMovement;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbpMetalizate.Text = "Pallets";
            tbpMetalizate.ImageIndex = -1;
            dgvMaquile.Rows.Clear();
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = string.Empty;
            txtMovement.Focus();
            ActiveControl = txtMovement;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbpMetalizate.Text = "Pallets";
            tbpMetalizate.ImageIndex = -1;
            dgvMaquile.Rows.Clear();
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = string.Empty;
            txtMovement.Focus();
            ActiveControl = txtMovement;
        }

        private void txtMaquileM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMaquileM.Text != string.Empty && txtMaquileM.Text != "Process")
                {
                    //objOrderDetail = clsMetallizedOrderDetail.getDeatilByCode(txtMaquileM.Text);
                    objMainCoilMetal = new clsMainCoilMetal(txtMaquileM.Text, true);
                    if (objMainCoilMetal.codsec > 0)
                    {
                        dgvMaquileM.Rows.Add();
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemcodsec.Index].Value = objMainCoilMetal.codsec;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemfkorderdetail.Index].Value = objMainCoilMetal.fkorigin;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemnumber.Index].Value = (dgvMaquileM.Rows.Count == 1) ? 1 : dgvMaquileM.Rows.Count;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemgrossweigth.Index].Value = objMainCoilMetal.grossWeigth;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemproductTo.Index].Value = objMainCoilMetal.ProductToCode;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilembase.Index].Value = objMainCoilMetal.ProductFromCode;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemnetweigth.Index].Value = objMainCoilMetal.netWeigth;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemcode.Index].Value = objMainCoilMetal.mcode;
                        dgvMaquileM.Rows[dgvMaquileM.Rows.Count - 1].Cells[clmmaquilemview.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        txtMaquileM.Text = "";
                        txtMaquileM.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No existe maquila con ese código por favor verifique el código e inténtelo nuevamente", "Maquila", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtMaquile.Text = "";
                        txtMaquile.Focus();
                    }
                }
                if (txtMaquileM.Text == "Process")
                    ProcessMaquileMMovements();
            }
        }

        private void ProcessMaquileMMovements()
        {
            for (int i = 0; i < dgvMaquileM.Rows.Count; i++)
            {
                try
                {
                    objMaquile = new clsMaquile();
                    objMaquile.load(Convert.ToInt32(dgvMaquileM.Rows[i].Cells[clmmaquilemfkorderdetail.Index].Value.ToString()));
                    objMaquile.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Maquilas", "Metalizado").codsec;
                    objMaquile.save();

                    clsMaquile ObjOutMaquile = new clsMaquile();
                    ObjOutMaquile.code = objMaquile.code;
                    ObjOutMaquile.fkStatus = objMaquile.fkStatus;
                    ObjOutMaquile.fkProduct = objMaquile.fkProduct;
                    ObjOutMaquile.customer = objMaquile.customer;
                    ObjOutMaquile.cellarName = "Maquila - Metalizada";
                    ObjOutMaquile.notes = objMaquile.notes;
                    ObjOutMaquile.weigth = Convert.ToDouble(dgvMaquileM.Rows[i].Cells[clmmaquilemnetweigth.Index].Value);
                    ObjOutMaquile.movement = "E012";
                    ObjOutMaquile.cellar = "0019";
                    ObjOutMaquile.ingress = true;
                    ObjOutMaquile.outt = false;
                    ObjOutMaquile.boppweigth = Convert.ToDouble(dgvMaquileM.Rows[i].Cells[clmmaquilemnetweigth.Index].Value);
                    ObjOutMaquile.oppweigth = 0;
                    ObjOutMaquile.pallet = objMaquile.pallet;
                    ObjOutMaquile.coil = objMaquile.coil;
                    ObjOutMaquile.diameter = objMaquile.diameter;
                    ObjOutMaquile.core = objMaquile.core;
                    ObjOutMaquile.width = objMaquile.width;
                    ObjOutMaquile.fkExport = 353;
                    ObjOutMaquile.fkProductFrom = objMaquile.fkProductFrom;
                    ObjOutMaquile.fkProductTo = objMaquile.fkProductTo;
                    ObjOutMaquile.fkmainCoilMetal = Convert.ToInt32(dgvMaquileM.Rows[i].Cells[clmmaquilemcodsec.Index].Value);
                    ObjOutMaquile.mainCoilMetalCode = dgvMaquileM.Rows[i].Cells[clmmaquilemcode.Index].Value.ToString();
                    if (ObjOutMaquile.save("Maquile"))
                    {
                        dgvMaquileM.Rows[i].Cells[clmmaquilemview.Index].Value = global::BPS.Lite.Properties.Resources.check;
                        objMaquile = new clsMaquile();
                        ObjOutMaquile = new clsMaquile();
                    }
                    else
                        dgvMaquileM.Rows[i].Cells[clmmaquilemview.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Maquilas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    dgvMaquileM.Rows[i].Cells[clmmaquiledelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    break;
                }
            }
        }

        private void txtReProcessCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (myMovement == "In")
                {
                    if (txtReProcessCode.Text != string.Empty && txtReProcessCode.Text != "Process")
                    {
                        objMillPallet = new clsMillPallet(txtReProcessCode.Text);
                        if (objMillPallet.codsec > 0)
                        {
                            dgvReProcess.Rows.Add();
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscodsec.Index].Value = objMillPallet.codsec;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessnumber.Index].Value = (dgvReProcess.Rows.Count == 1) ? 1 : dgvReProcess.Rows.Count;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscode.Index].Value = objMillPallet.code;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscustomer.Index].Value = objMillPallet.enityName.ToUpper();
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessproduct.Index].Value = objMillPallet.ProductName + " [" + objMillPallet.ProductCode + "]";
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessproductfinally.Index].Value = objMillPallet.ProductName;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessbag.Index].Value = objMillPallet.bag;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesspalletweigth.Index].Value = Math.Round(objMillPallet.palletWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessgrossweigth.Index].Value = Math.Round(objMillPallet.grossWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessnetweigth.Index].Value = Math.Round(objMillPallet.netWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessdensity.Index].Value = Math.Round(objMillPallet.density, 4, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                            txtReProcessCode.Text = "";
                            txtReProcessCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No existe re-proceso con ese código por favor verifique el código e inténtelo nuevamente", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtReProcessCode.Text = "";
                            txtReProcessCode.Focus();
                        }
                    }
                    if (txtReProcessCode.Text == "Process")
                        ProcessReProcess("In");
                }
                else if (myMovement == "Out")
                {
                    if (txtReProcessCode.Text != string.Empty && txtReProcessCode.Text != "Process" && (rdbDMT.Checked || rdbMW.Checked))
                    {
                        objMillPallet = new clsMillPallet(txtReProcessCode.Text);
                        if (objMillPallet.codsec > 0)
                        {
                            dgvReProcess.Rows.Add();
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscodsec.Index].Value = objMillPallet.codsec;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessnumber.Index].Value = (dgvReProcess.Rows.Count == 1) ? 1 : dgvReProcess.Rows.Count;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscode.Index].Value = objMillPallet.code;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscustomer.Index].Value = objMillPallet.enityName.ToUpper();
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessproduct.Index].Value = objMillPallet.ProductName + " [" + objMillPallet.ProductCode + "]";
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessproductfinally.Index].Value = objMillPallet.ProductName;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessbag.Index].Value = objMillPallet.bag;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesspalletweigth.Index].Value = Math.Round(objMillPallet.palletWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessgrossweigth.Index].Value = Math.Round(objMillPallet.grossWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessnetweigth.Index].Value = Math.Round(objMillPallet.netWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessdensity.Index].Value = Math.Round(objMillPallet.density, 4, MidpointRounding.AwayFromZero);
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                            dgvReProcess.Rows[dgvReProcess.Rows.Count - 1].Cells[clmreprocessmachine.Index].Value = (rdbDMT.Checked == true) ? "DMT" : "MW";
                            txtReProcessCode.Text = "";
                            txtReProcessCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No existe re-proceso con ese código por favor verifique el código e inténtelo nuevamente", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtReProcessCode.Text = "";
                            txtReProcessCode.Focus();
                        }
                    }
                    else if (txtReProcessCode.Text == "Process")
                        ProcessReProcess("Out");
                    else
                    {
                        MessageBox.Show("Debe seleccionar la línea a la que desea sacar el re-procesado", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtReProcessCode.Text = "";
                        txtReProcessCode.Focus();
                    }

                }
            }
        }

        private void ProcessReProcess(string source)
        {
            if (source == "In")
            {
                for (int i = 0; i < dgvReProcess.Rows.Count; i++)
                {
                    try
                    {
                        objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                        objMillPalletbyCoilCellar.fkmillpallet = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                        objMillPalletbyCoilCellar.product = dgvReProcess.Rows[i].Cells[clmreprocessproductfinally.Index].Value.ToString();
                        objMillPalletbyCoilCellar.siigoCellar = "0020";
                        objMillPalletbyCoilCellar.siigoMovement = "E007";
                        objMillPalletbyCoilCellar.bag = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessbag.Index].Value);
                        objMillPalletbyCoilCellar.ingress = true;
                        objMillPalletbyCoilCellar.output = false;
                        objMillPalletbyCoilCellar.code = dgvReProcess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                        objMillPalletbyCoilCellar.netweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                        objMillPalletbyCoilCellar.grossweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                        objMillPalletbyCoilCellar.palletweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocesspalletweigth.Index].Value);
                        objMillPalletbyCoilCellar.order = Convert.ToInt32(objMillPalletbyCoilCellar.code.Substring((objMillPalletbyCoilCellar.code.Length - 3), 3));
                        objMillPalletbyCoilCellar.customer = dgvReProcess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString(); ;
                        objMillPalletbyCoilCellar.movement = "Ingreso de Producción Molinos";
                        objMillPalletbyCoilCellar.density = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                        objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Ingreso").codsec;
                        objMillPalletbyCoilCellar.isImport = false;
                        if (objMillPalletbyCoilCellar.save())
                        {
                            dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.check;
                            objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                        }
                        else
                            dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        break;
                    }
                }
            }
            else if (source == "Out")
            {
                for (int i = 0; i < dgvReProcess.Rows.Count; i++)
                {
                    try
                    {
                        if (dgvReProcess.Rows[i].Cells[clmreprocessmachine.Index].Value.ToString().ToUpper() == "DMT")
                        {
                            objMillPalletbyCoilCellar.loadByMillPallet(Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value));
                            objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Salida").codsec;
                            if (objMillPalletbyCoilCellar.toUpdateOutStatus())
                            {
                                objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                                objMillPalletbyCoilCellar.fkmillpallet = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                                objMillPalletbyCoilCellar.product = dgvReProcess.Rows[i].Cells[clmreprocessproductfinally.Index].Value.ToString();
                                objMillPalletbyCoilCellar.siigoCellar = "0020";
                                objMillPalletbyCoilCellar.siigoMovement = "S001";
                                objMillPalletbyCoilCellar.bag = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessbag.Index].Value);
                                objMillPalletbyCoilCellar.ingress = false;
                                objMillPalletbyCoilCellar.output = true;
                                objMillPalletbyCoilCellar.devolution = false;
                                objMillPalletbyCoilCellar.code = dgvReProcess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                                objMillPalletbyCoilCellar.netweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                                objMillPalletbyCoilCellar.grossweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                                objMillPalletbyCoilCellar.palletweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocesspalletweigth.Index].Value);
                                objMillPalletbyCoilCellar.order = Convert.ToInt32(objMillPalletbyCoilCellar.code.Substring((objMillPalletbyCoilCellar.code.Length - 3), 3));
                                objMillPalletbyCoilCellar.customer = dgvReProcess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString(); ;
                                objMillPalletbyCoilCellar.movement = "Salida a Planta DMT";
                                objMillPalletbyCoilCellar.density = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                                objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Salida").codsec;
                                objMillPalletbyCoilCellar.isImport = false;
                                if (objMillPalletbyCoilCellar.save())
                                {
                                    dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.check;
                                    objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                                }
                                else
                                    dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                            else
                            {
                                MessageBox.Show("Error --- Al momento de actualizar la salida", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                break;
                            }
                        }
                        else
                        {
                            objMillPalletbyCoilCellar.loadByMillPallet(Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value));
                            objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Salida").codsec;
                            if (objMillPalletbyCoilCellar.toUpdateOutStatus())
                            {
                                objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                                objMillPalletbyCoilCellar.fkmillpallet = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                                objMillPalletbyCoilCellar.product = dgvReProcess.Rows[i].Cells[clmreprocessproductfinally.Index].Value.ToString();
                                objMillPalletbyCoilCellar.siigoCellar = "0020";
                                objMillPalletbyCoilCellar.siigoMovement = "S026";
                                objMillPalletbyCoilCellar.bag = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessbag.Index].Value);
                                objMillPalletbyCoilCellar.ingress = false;
                                objMillPalletbyCoilCellar.output = true;
                                objMillPalletbyCoilCellar.devolution = false;
                                objMillPalletbyCoilCellar.code = dgvReProcess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                                objMillPalletbyCoilCellar.netweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                                objMillPalletbyCoilCellar.grossweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                                objMillPalletbyCoilCellar.palletweigth = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocesspalletweigth.Index].Value);
                                objMillPalletbyCoilCellar.order = Convert.ToInt32(objMillPalletbyCoilCellar.code.Substring((objMillPalletbyCoilCellar.code.Length - 3), 3));
                                objMillPalletbyCoilCellar.customer = dgvReProcess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString(); ;
                                objMillPalletbyCoilCellar.movement = "Salida a Planta MW";
                                objMillPalletbyCoilCellar.density = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                                objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Salida").codsec;
                                objMillPalletbyCoilCellar.isImport = false;
                                if (objMillPalletbyCoilCellar.save())
                                {
                                    dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.check;
                                    objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                                }
                                else
                                    dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                            else
                            {
                                MessageBox.Show("Error --- Al momento de actualizar la salida", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        break;
                    }
                }
            }
            else if (source == "Return")
            {
                //Devolución a Bodega DMT
                //Devolución a Bodega MW
                //for (int i = 0; i < dgvReProcess.Rows.Count; i++)
                //{
                //    try
                //    {
                //        objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                //        objMillPalletbyCoilCellar.fkmillpallet = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                //        objMillPalletbyCoilCellar.product = dgvReProcess.Rows[i].Cells[clmreprocessproductfinally.Index].Value.ToString();
                //        objMillPalletbyCoilCellar.siigoCellar = "0020";
                //        objMillPalletbyCoilCellar.siigoMovement = "E007";
                //        objMillPalletbyCoilCellar.bag = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessbag.Index].Value);
                //        objMillPalletbyCoilCellar.ingress = true;
                //        objMillPalletbyCoilCellar.output = false;
                //        objMillPalletbyCoilCellar.code = dgvReProcess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                //        objMillPalletbyCoilCellar.netweigth = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                //        objMillPalletbyCoilCellar.grossweigth = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                //        objMillPalletbyCoilCellar.palletweigth = Convert.ToInt32(dgvReProcess.Rows[i].Cells[clmreprocesspalletweigth.Index].Value);
                //        objMillPalletbyCoilCellar.order = Convert.ToInt32(objMillPalletbyCoilCellar.code.Substring((objMillPalletbyCoilCellar.code.Length - 3), 3));
                //        objMillPalletbyCoilCellar.customer = dgvReProcess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString(); ;
                //        objMillPalletbyCoilCellar.movement = "Ingreso Devolucion Lineas";
                //        objMillPalletbyCoilCellar.density = Convert.ToDouble(dgvReProcess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                //        objMillPalletbyCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Ingreso").codsec;
                //        objMillPalletbyCoilCellar.isImport = false;
                //        if (objMillPalletbyCoilCellar.save())
                //        {
                //            dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.check;
                //            objMillPalletbyCoilCellar = new clsMillPalletbyCoilCellar();
                //        }
                //        else
                //            dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //        dgvReProcess.Rows[i].Cells[clmreprocesscheck.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                //        break;
                //    }
                //}
            }
        }

        private void dgvReProcess_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dgvReProcess.Rows.Count; i++)
                dgvReProcess.Rows[i].Cells[clmreprocessnumber.Index].Value = (i + 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbpMetalizate.Text = "Pallets";
            tbpMetalizate.ImageIndex = -1;
            dgvMaquile.Rows.Clear();
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = string.Empty;
            txtMovement.Focus();
            ActiveControl = txtMovement;
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtPosition.Text != "" & e.KeyCode == Keys.Enter)
                {
                    objPallet = clsPallet.getDetailByCodeWithAuditory(txtPalletCode.Text);
                    objPallet.position = txtPosition.Text;

                    if (objPallet.countpallet == 1)
                    {
                        if (objPallet.diference == "OK")
                        {
                            if (objPallet.codsec != 0)
                            {
                                clsSalesOrder objSalesOrder = new clsSalesOrder();

                                objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);

                                bool coincidence = false;

                                for (int i = 0; i < dgvPallets.Rows.Count;i++)
                                {
                                    if(Convert.ToInt32(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value)==objPallet.codsec)
                                    {
                                         coincidence = true;
                                    }
                                }

                                if (!coincidence)
                                {

                                    dgvPallets.Rows.Add();
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPallets.Rows.Count == 1) ? 1 : dgvPallets.Rows.Count;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCodsec.Index].Value = objPallet.codsec;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = objPallet.code;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletProduct.Index].Value = objPallet.product.code;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletSalesOrder.Index].Value = objSalesOrder.ToString();
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.lstCoil.Count.ToString();
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletNetWeight.Index].Value = Math.Round(objPallet.netWeight, 1);
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 1);
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPosition.Index].Value = objPallet.position;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletStatus.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmdiference.Index].Value = objPallet.diference;
                                    dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmcountpallet.Index].Value = objPallet.countpallet;
                                    if (objPallet.diference == "HP")
                                    {

                                        for (int j = 0; j < dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells.Count; j++)
                                        {
                                            Font fntBold = new Font(dgvPallets.Font, FontStyle.Bold);
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.BackColor = Color.Red;
                                        }
                                    }
                                    else if (objPallet.countpallet != 1)
                                    {

                                        for (int j = 0; j < dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells.Count; j++)
                                        {
                                            Font fntBold = new Font(dgvPallets.Font, FontStyle.Bold);
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[j].Style.BackColor = Color.Orange;
                                        }
                                    }
                                }

                                txtPalletCode.Enabled = true;
                                lblPalletCode.Enabled = true;
                                txtPosition.Enabled = false;
                                lblPosition.Enabled = false;
                                txtPalletCode.Text = "";
                                txtPosition.Text = "";
                                txtPalletCode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("El código ingresado no corresponde a ningún pallet registrado. Por favor intente de nuevo.", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                txtPalletCode.Enabled = true;
                                lblPalletCode.Enabled = true;
                                txtPosition.Enabled = false;
                                lblPosition.Enabled = false;
                                txtPalletCode.Text = "";
                                txtPosition.Text = "";
                                txtPalletCode.Focus();
                            }
                        }
                        else
                        {
                            if (objPallet.diference == "PESOS_DIF")
                            {
                                MessageBox.Show("El código " + objPallet.code + "\n P.Neto :" + objPallet.netWeight + "\n P.Bruto :" + objPallet.grossWeight + "\n Este pallet no podrá ser ingresado hasta que se corrija el peso Bruto en Corte", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                txtPalletCode.Enabled = true;
                                lblPalletCode.Enabled = true;
                                txtPosition.Enabled = false;
                                lblPosition.Enabled = false;
                                txtPalletCode.Text = "";
                                txtPosition.Text = "";
                                txtPalletCode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("El código " + objPallet.code + " tiene un peso de en la paleta de P.Neto :" + objPallet.netWeight + "\n Las bobinas tienen un peso de P.Neto :" + objPallet.coilnetweigth + "\nEste pallet no podrá ser ingresado a bodega comunicar a PLANTA / SISTEMAS", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                txtPalletCode.Enabled = true;
                                lblPalletCode.Enabled = true;
                                txtPosition.Enabled = false;
                                lblPosition.Enabled = false;
                                txtPalletCode.Text = "";
                                txtPosition.Text = "";
                                txtPalletCode.Focus();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El código " + objPallet.code + " está DUPLICADO por favor comunicar URGENTE a PLANTA / SISTEMAS\nPara que realice la respectiva corrección\n Éste pallet no podrá ser ingresado a bodega", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtPalletCode.Enabled = true;
                        lblPalletCode.Enabled = true;
                        txtPosition.Enabled = false;
                        lblPosition.Enabled = false;
                        txtPalletCode.Text = "";
                        txtPosition.Text = "";
                        txtPalletCode.Focus();
                    }
                        
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos de bodega - Posición", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

       
    }
}
