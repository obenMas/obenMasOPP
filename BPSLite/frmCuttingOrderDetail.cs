using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCuttingOrderDetail : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsMachine objMachine = new clsMachine();
        List<Label> lstLblCoils = new List<Label>();
        List<CheckBox> lstChkCoils = new List<CheckBox>();
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        public int selectedProductCodsec = 0;
        clsProduct objSelectedProduct = new clsProduct();

        public frmCuttingOrderDetail()
        {
            InitializeComponent();
        }
        public frmCuttingOrderDetail(int cuttingOrderCodsec)
        {
            InitializeComponent();
            objCuttingOrder.load(cuttingOrderCodsec);
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
        }
        private void drawCoilDistribution()
        {
            if (objCuttingOrder.isSecundaryCut == false)
            {
                int relativePosition = 14;
                int wasteSize = objMachine.Cutter.utilWidth;
                double usedWidth = 0;

                grpbCombination.Controls.Clear();

                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                    wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                lblWaste1.BackColor = System.Drawing.Color.DimGray;
                lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize / 2, grpbCombination.Width - 28)), 70);
                lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

                grpbCombination.Controls.Add(lblWaste1);

                relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize / 2, grpbCombination.Width - 28));

                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                {
                    lstLblCoils.Add(new Label());
                    lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                    lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                    lstLblCoils[i].Name = "lblCoil" + i.ToString();
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), grpbCombination.Width - 28), 70);
                    lstLblCoils[i].TabIndex = 0;
                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                        lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + " \r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nPeso Aprox: " + Convert.ToString((Math.Round(objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight, 2))) + "Kg\r\nLong. Aprox: 11300m";
                    else
                        lstLblCoils[i].Text = "Stock \r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "\r\nPeso Aprox: " + Convert.ToString((Math.Round(objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight, 2))) + "Kg\r\nLong. Aprox: 11300m";

                    if (objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace)
                        lstLblCoils[i].Text += "\r\nSingle Face : SI";
                    else
                        lstLblCoils[i].Text += "\r\nSingle Face : NO";

                    lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                    grpbCombination.Controls.Add(lstLblCoils[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), grpbCombination.Width - 28);

                }
                lblWaste2.BackColor = System.Drawing.Color.DimGray;
                lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize / 2, grpbCombination.Width - 28)), 70);
                lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
                grpbCombination.Controls.Add(lblWaste2);
            }
            else
            {
                clsProduct objProduct = new clsProduct(objCuttingOrder.fkProduct);

                int relativePosition = 14;
                int wasteSize = Convert.ToInt32(objProduct.width);
                double usedWidth = 0;

                grpbCombination.Controls.Clear();

                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                    wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                lblWaste1.BackColor = System.Drawing.Color.DimGray;
                lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize / 2, grpbCombination.Width - 28)), 70);
                lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

                grpbCombination.Controls.Add(lblWaste1);

                relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize / 2, grpbCombination.Width - 28));

                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                {
                    lstLblCoils.Add(new Label());
                    lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                    lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                    lstLblCoils[i].Name = "lblCoil" + i.ToString();
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), grpbCombination.Width - 28), 70);
                    lstLblCoils[i].TabIndex = 0;
                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                        lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + " \r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nPeso Aprox: " + Convert.ToString((Math.Round(objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight, 2))) + "Kg\r\nLong. Aprox: 11300m";
                    else
                        lstLblCoils[i].Text = "Stock \r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "\r\nPeso Aprox: " + Convert.ToString((Math.Round(objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight, 2))) + "Kg\r\nLong. Aprox: 11300m";

                    if (objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace)
                        lstLblCoils[i].Text += "\r\nSingle Face : SI";
                    else
                        lstLblCoils[i].Text += "\r\nSingle Face : NO";

                    lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                    grpbCombination.Controls.Add(lstLblCoils[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), grpbCombination.Width - 28);

                }
                lblWaste2.BackColor = System.Drawing.Color.DimGray;
                lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize / 2, grpbCombination.Width - 28)), 70);
                lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
                grpbCombination.Controls.Add(lblWaste2);
            }
        }
        private void frmCuttingOrderDetail_Load(object sender, EventArgs e)
        {
            if (objCuttingOrder.codsec > 0)
            {
                if (objCuttingOrder.isSecundaryCut == false)
                {
                    int wasteSize = objMachine.Cutter.utilWidth;
                    double usedWidth = 0;

                    lblCutterName.Text = objCuttingOrder.machineName;
                    grpbInfo.Text = "Orden de Corte # " + objCuttingOrder.number;
                    if (objCuttingOrder.fkBopp > 0)
                        lblFilmName.Text = "[" + objCuttingOrder.boppCode.Replace("-", "") + "] " + objCuttingOrder.boppName;
                    else
                        lblFilmName.Text = "[" + objCuttingOrder.castCode.Replace("-", "") + "] " + objCuttingOrder.castName;

                    lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
                    lblUsedArms.Text = objCuttingOrder.positions.ToString();
                    lblUtilWidth.Text = objMachine.Cutter.utilWidth.ToString();
                    lblTotalCoils.Text = Convert.ToString(objCuttingOrder.repetitions * objCuttingOrder.lstCuttingOrderDetail.Count);
                    lblNotes.Text = objCuttingOrder.notes;

                    for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                    {
                        dgvCoilsDetail.Rows.Add();
                        dgvCoilsDetail.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Value = i + 1;
                        dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Style.BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);

                        if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                        {
                            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                            clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                            dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = objSalesOrder.EntityName;
                            dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = objSalesOrder.number;
                        }
                        else
                        {
                            dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = "Producto en Stock";
                            dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = "---";
                        }
                        dgvCoilsDetail.Rows[i].Cells[clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                        dgvCoilsDetail.Rows[i].Cells[clmChangeProduct.Index].Value = global::BPS.Lite.Properties.Resources.arrow_refresh;
                        dgvCoilsDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                        dgvCoilsDetail.Rows[i].Cells[clmLength.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].programmedLength;
                        dgvCoilsDetail.Rows[i].Cells[clmWeigth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight;
                        usedWidth += objCuttingOrder.lstCuttingOrderDetail[i].width;
                    }

                    drawCoilDistribution();


                    switch (objCuttingOrder.fkStatus)
                    {
                        case 23:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.paste;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 24:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 25:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.Play_Hot;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 26:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.check;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 27:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.cancel1;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        default:
                            break;
                    }
                    lblUsedWidth.Text = usedWidth.ToString();
                    lblWaste.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
                }
                else
                {
                    int wasteSize = objMachine.Cutter.utilWidth;
                    double usedWidth = 0;
                    clsProduct objProduct = new clsProduct(objCuttingOrder.fkProduct);

                    lblCutterName.Text = objCuttingOrder.machineName;
                    grpbInfo.Text = "Orden de Corte # " + objCuttingOrder.number;
                    lblFilmName.Text = "[" + objCuttingOrder.productCode.Replace("-", "") + "] " + objCuttingOrder.productName;
                    lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
                    lblUsedArms.Text = objCuttingOrder.positions.ToString();
                    lblUtilWidth.Text = Convert.ToInt32(objProduct.width).ToString();
                    lblTotalCoils.Text = Convert.ToString(objCuttingOrder.repetitions * objCuttingOrder.lstCuttingOrderDetail.Count);
                    lblNotes.Text = objCuttingOrder.notes;

                    for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                    {
                        dgvCoilsDetail.Rows.Add();
                        dgvCoilsDetail.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Value = i + 1;
                        dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Style.BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);

                        if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                        {
                            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                            clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                            dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = objSalesOrder.EntityName;
                            dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = objSalesOrder.number;
                        }
                        else
                        {
                            dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = "Producto en Stock";
                            dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = "---";
                        }
                        dgvCoilsDetail.Rows[i].Cells[clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                        dgvCoilsDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmChangeProduct.Index].Value = global::BPS.Lite.Properties.Resources.arrow_refresh;
                        dgvCoilsDetail.Rows[i].Cells[clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                        dgvCoilsDetail.Rows[i].Cells[clmLength.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].programmedLength;
                        dgvCoilsDetail.Rows[i].Cells[clmWeigth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].programmedWeight;
                        usedWidth += objCuttingOrder.lstCuttingOrderDetail[i].width;
                    }

                    drawCoilDistribution();


                    switch (objCuttingOrder.fkStatus)
                    {
                        case 23:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.paste;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 24:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 25:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.Play_Hot;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 26:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.check;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        case 27:
                            lblStatusImage.Image = global::BPS.Lite.Properties.Resources.cancel1;
                            lblStatus.Text = objCuttingOrder.statusName;
                            break;
                        default:
                            break;
                    }
                    lblUsedWidth.Text = usedWidth.ToString();
                    lblWaste.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar esta orden de corte?", "Ordenes de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                objCuttingOrder.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Cancelada")).codsec;
                objCuttingOrder.save();
                MessageBox.Show("La orden de corte ha sido cancelada.", "Ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea poner en ejecución esta orden de corte?", "Ordenes de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                bool flgAllProductsCorrect = true;

                if (objCuttingOrder.allowEquivalentFilm == false)
                {
                    if (objCuttingOrder.fkProduct == 0)
                    {
                        for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                        {
                            if (objCuttingOrder.lstCuttingOrderDetail[i].product.fkBopp != objCuttingOrder.fkBopp || objCuttingOrder.lstCuttingOrderDetail[i].product.fkCast != objCuttingOrder.fkCast )
                                flgAllProductsCorrect = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                        {
                            if (objCuttingOrder.lstCuttingOrderDetail[i].product.fkBopp != (new clsProduct(objCuttingOrder.fkProduct)).Bopp.codsec || objCuttingOrder.lstCuttingOrderDetail[i].product.fkCast != (new clsProduct(objCuttingOrder.fkProduct)).Cast.codsec)
                                flgAllProductsCorrect = false;
                        }
                    }
                }
                if (flgAllProductsCorrect == true)
                {
                    if (objCuttingOrder.statusName == "Programada")
                        objCuttingOrder.number = clsCuttingOrder.getNextNumber().ToString();

                    objCuttingOrder.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Ejecutandose")).codsec;
                    objCuttingOrder.save();
                    MessageBox.Show("La orden de corte esta ahora en ejecución.", "Ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hay productos en la orden de corte que no coinciden al material que va a ser cortado. La orden de corte no puede ser puesta en ejecución", "Ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void dgvCoilsDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvCoilsDetail.DoDragDrop(dgvCoilsDetail.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }

        private void dgvCoilsDetail_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvCoilsDetail.PointToClient(new Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop = dgvCoilsDetail.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dgvCoilsDetail.Rows.RemoveAt(rowIndexFromMouseDown);
                dgvCoilsDetail.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                for (int i = 0; i < dgvCoilsDetail.Rows.Count; i++)
                {
                    clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail(Convert.ToInt32(dgvCoilsDetail.Rows[i].Cells[clmCodsec.Index].Value));
                    objCuttingOrderDetail.position = i + 1;
                    objCuttingOrderDetail.save();
                    dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Value = i + 1;
                }
                objCuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);
            }
            drawCoilDistribution();
        }

        private void dgvCoilsDetail_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void dgvCoilsDetail_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvCoilsDetail_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvCoilsDetail.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void btnReportCutinngOrder_Click(object sender, EventArgs e)
        {
            frmCuttingOrderReportView winCuttingOrderReportView = new frmCuttingOrderReportView(objCuttingOrder.codsec,objCuttingOrder.fkMachine);
            winCuttingOrderReportView.StartPosition = FormStartPosition.Manual;
            winCuttingOrderReportView.Show();
        }

        private void dgvCoilsDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmChangeProduct.Index)
            {
                selectedProductCodsec = Convert.ToInt32(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmProductCodsec.Index].Value);
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this, Convert.ToInt32(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmProductCodsec.Index].Value), true);
                winProductList.ShowDialog(this);

                objSelectedProduct.load(selectedProductCodsec);
                if (Convert.ToInt32(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmProductCodsec.Index].Value) != selectedProductCodsec)
                {
                    if (MessageBox.Show("Desea cambiar el producto?", "Ordenes de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsConnection.executeQuery("UPDATE bps_prod_cuttingOrderDetail SET cod_fkproduct = " + objSelectedProduct.codsec.ToString() + " WHERE cod_codsec = " + dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString());

                        dgvCoilsDetail.Rows[e.RowIndex].Cells[clmProductCode.Index].Value = objSelectedProduct.code;
                        dgvCoilsDetail.Rows[e.RowIndex].Cells[clmProductCodsec.Index].Value = objSelectedProduct.codsec;

                        objCuttingOrder.load(objCuttingOrder.codsec);
                    }

                }
            }
        }
    }
}