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
    public partial class frmCubeOptions : Form
    {
        internal clsProduct objProduct = new clsProduct();
        internal clsTransport objTransport = new clsTransport();
        List<Label> lstLblCoilsLabels = new List<Label>();
        List<Label> lstLblCoils = new List<Label>();
        public int cubeCodsec = 0, cubeDetailCodsec = 0;
        private bool isOk = true, isUpdate = false;

        public frmCubeOptions()
        {
            InitializeComponent();
        }

        public frmCubeOptions(int fktransport, int cubeCodsec)
        {
            InitializeComponent();
            PopulaTransport(fktransport);
            PopulateProduct();
            PopulateCube();
            PopulateDimentions();
            this.cubeCodsec = cubeCodsec;
            cmbProduct.Focus();
            RefreshList(cubeCodsec);
            CheckWidth();
        }

        public frmCubeOptions(int cubeCodsec, int cubeDetail, string data)
        {
            InitializeComponent();
            this.cubeCodsec = cubeCodsec;
            MyEdit(cubeDetail);
        }

        private void CheckWidth()
        {
            double width = 0;
            if (dgvCube.Rows.Count > 0)
            {
                for (int i = 0; i < dgvCube.Rows.Count; i++)
                    width += Convert.ToDouble(dgvCube.Rows[i].Cells[clmwidth.Index].Value);

                lblmyWidthContainer.Text = width.ToString();
            }
            else
                lblmyWidthContainer.Text = "0";
        }

        private void PopulateDimentions()
        {
            List<clsPalletDimentions> lstPalletDimentions = clsPalletDimentions.getList();
            cmbDimentions.Items.Clear();
            for (int i = 0; i < lstPalletDimentions.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimentions[i]);
        }

        private void PopulateCube()
        {
            List<clsBoxing> lstPalletDimentions = clsBoxing.getListIsVisible();
            cmbCube.Items.Clear();
            for (int i = 0; i < lstPalletDimentions.Count; i++)
                cmbCube.Items.Add(lstPalletDimentions[i]);
        }

        private void PopulaTransport(int fktransport)
        {
            objTransport = new clsTransport(fktransport);
            label3.Text = objTransport.name;
            lblWidth.Text = objTransport.usefulWidth.ToString();
            lblHeight.Text = objTransport.usefulHigh.ToString();
            lblDepth.Text = objTransport.usefulLong.ToString();
        }

        private void PopulateProduct()
        {
            List<clsProductDisplacement> lstProduct = clsProductDisplacement.getProductListComplete();
            cmbProduct.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbProduct.Items.Add(lstProduct[i]);
        }

        public frmCubeOptions(int ProductCodsec, double quantity, string Trataiment)
        {
            InitializeComponent();
            PopulateDimentions();
            PopulateProduct();
            PopulateTrataimet(Trataiment);
            PopulateHead(ProductCodsec);
        }

        private void PopulateTrataimet(string data)
        {
            for (int i = 0; i < cmbTrataiment.Items.Count; i++)
            {
                if (cmbTrataiment.Items[i].ToString().ToUpper() == data.ToUpper())
                {
                    cmbTrataiment.SelectedIndex = i;
                    break;
                }
            }
        }    

        private void PopulateHead(int ProductCodsec)
        {
            objProduct = new clsProduct(ProductCodsec);
            
            if (clsCube.toCalculeDimentionsPallet(objProduct) > 0)
            {
                for (int i = 0; i < cmbDimentions.Items.Count; i++)
                {
                    if (((clsPalletDimentions)cmbDimentions.Items[i]).codsec == clsCube.toCalculeDimentionsPallet(objProduct))
                    {
                        cmbDimentions.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la referencia para generar la dimensión de los pallets", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbProduct.Focus();
            }
        }

        private void CalculeDimentions(clsProduct objProduct)
        {
            lblWidthProduct.Text = ((clsProductDisplacement)cmbProduct.SelectedItem).width.ToString();
            lblQuantityCoil.Text = clsParameters.getCoilNumber(((clsProductDisplacement)cmbProduct.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text)).ToString();
            lblWeigthPerCoil.Text = clsParameters.getWeigthByProduct(((clsProductDisplacement)cmbProduct.SelectedItem).codsec).ToString();
            lblWeigthAproximate.Text = Convert.ToString(Convert.ToDouble(lblQuantityCoil.Text) * Convert.ToDouble(lblWeigthPerCoil.Text));
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text.Length > 0 && cmbProduct.SelectedIndex > -1 && cmbCube.SelectedIndex > -1)
                {
                    lblQuantityCoil.Text = clsParameters.getCoilNumber(((clsProductDisplacement)cmbProduct.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text)).ToString();
                    lblWeigthPerCoil.Text = clsParameters.getWeigthByProduct(((clsProductDisplacement)cmbProduct.SelectedItem).codsec).ToString();
                    lblWeigthAproximate.Text = Convert.ToString(Convert.ToDouble(lblQuantityCoil.Text) * Convert.ToDouble(lblWeigthPerCoil.Text));
                    GetCubeByBoxing(((clsBoxing)cmbCube.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, ((clsProductDisplacement)cmbProduct.SelectedItem).codsec);
                }
                else
                {
                    MessageBox.Show("Debe completar varios datos requeridos..", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbProduct.Focus();
                }
            }
        }

        private void GetCubeByBoxing(int boxingCodsec, double quantity, int width, int height, int productCodsec)
        {
            clsBoxing objBoxing = new clsBoxing(boxingCodsec);
            var pallet = Convert.ToInt32(Convert.ToInt32(lblQuantityCoil.Text) / objBoxing.coil);
            var palletweigth = (Convert.ToDouble(lblWeigthPerCoil.Text) * objBoxing.coil);
            double divisibledecimal, widthUsed =0;
            objProduct.load(productCodsec);
            if (objProduct.diameterName == "Normal")
                widthUsed = Math.Round((Convert.ToDouble(pallet) / 2), 0, MidpointRounding.AwayFromZero) * height;
            else
            {
                divisibledecimal = pallet / 3.0;
                int intpart = (int)divisibledecimal;
                double decpart = divisibledecimal - intpart;
                
                if (decpart < 0.5 && decpart > 0.0)
                    decpart += 0.3;

                divisibledecimal = intpart + decpart;
                widthUsed = Math.Round((Convert.ToDouble(divisibledecimal)), 0, MidpointRounding.AwayFromZero) * height;
                    
            }

            if ((pallet * objBoxing.coil) != Convert.ToInt32(lblQuantityCoil.Text))
            {
                lblQuantityCoil.Text = (pallet * objBoxing.coil).ToString();
                lblWeigthAproximate.Text = Math.Round(Convert.ToDouble(lblQuantityCoil.Text) * Convert.ToDouble(lblWeigthPerCoil.Text), 1, MidpointRounding.AwayFromZero).ToString();
            }
            
            txtpalletCount.Text = pallet.ToString();
            txtpalletUnitWeight.Text = Math.Round(palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
            txtpalletWidth.Text = Convert.ToInt32(widthUsed).ToString();
            txtpalletWeight.Text = Math.Round((pallet * palletweigth), 1, MidpointRounding.AwayFromZero).ToString();
            if (objTransport.usefulLong == 0)
                objTransport.usefulLong = Convert.ToInt32(lblDepth.Text);
            isOk = true;
            
            if (Convert.ToInt32(widthUsed) > objTransport.usefulLong)
            {
                MessageBox.Show("Usted no puede cubicar esta acción ya que pueden existir varios errores\n * Por favor verifique que la cantidad no sobrepase el peso del contendor seleccionado \n * Por favor cambie el embalaje para una mejor distribución", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbCube.Focus();
                isOk = false;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex != -1)
            {
                PopulateHead(((clsProductDisplacement)cmbProduct.SelectedItem).codsec);
                lblWidthProduct.Text = ((clsProductDisplacement)cmbProduct.SelectedItem).width.ToString();
                if (txtQuantity.Text.Length > 0)
                {
                    lblQuantityCoil.Text = clsParameters.getCoilNumber(((clsProductDisplacement)cmbProduct.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text)).ToString();
                    lblWeigthPerCoil.Text = clsParameters.getWeigthByProduct(((clsProductDisplacement)cmbProduct.SelectedItem).codsec).ToString();
                    lblWeigthAproximate.Text = Convert.ToString(Convert.ToDouble(lblQuantityCoil.Text) * Convert.ToDouble(lblWeigthPerCoil.Text));
                }
            }
            else
                lblWidthProduct.Text = string.Empty;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1 && cmbCube.SelectedIndex > -1)
            {
                if (objProduct.diameterName == "Normal")
                {
                    lblContainer.Controls.Clear();
                    lstLblCoils = new List<Label>();
                    lstLblCoilsLabels = new List<Label>();
                    int relativePosition = 2, palletcontrol = 0;
                    bool isdouble = false;
                    if (((clsBoxing)cmbCube.SelectedItem).code == "HD06" || ((clsBoxing)cmbCube.SelectedItem).code == "HD07" || ((clsBoxing)cmbCube.SelectedItem).code == "HD08")
                    {
                        if (Convert.ToInt32(txtpalletCount.Text) % 2 == 0)
                        {
                            palletcontrol = Convert.ToInt32(txtpalletCount.Text) / 2;
                            isdouble = true;
                        }
                        else
                        {
                            palletcontrol = Convert.ToInt32(txtpalletCount.Text);
                            isdouble = false;
                        }
                    }
                    else
                        palletcontrol = Convert.ToInt32(txtpalletCount.Text);

                    for (int i = 0; i < palletcontrol; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoils.Add(new Label());
                            lstLblCoils[0].BackColor = clsGlobal.getColorByPosition(i, 60);
                            lstLblCoils[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            lstLblCoils[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            lstLblCoils[0].Location = new System.Drawing.Point(relativePosition, 2);
                            lstLblCoils[0].Name = "lblCube" + i.ToString();
                            lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, 746), 118);
                            lstLblCoils[0].TabIndex = 0;
                            lstLblCoils[0].Tag = 0;
                            lstLblCoils[0].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                            lstLblCoils[0].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                            lstLblCoils[0].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                            if (isdouble)
                                lstLblCoils[0].Text += "PDo : D\n";
                            lstLblCoils[0].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            lblContainer.Controls.Add(lstLblCoils[0]);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(i, 60);
                                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 121);
                                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCube" + i.ToString();
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, 746), 118);
                                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                                if (isdouble)
                                    lstLblCoils[lstLblCoils.Count - 1].Text += "PDo : D\n";
                                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
                            }
                            else
                            {
                                relativePosition += clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, 746) + 1;
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(i, 60);
                                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 2);
                                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, 746), 118);
                                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                                if (isdouble)
                                    lstLblCoils[lstLblCoils.Count - 1].Text += "PDo : D\n";
                                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
                            }
                        }
                    }
                }
                else
                {
                    lblContainer.Controls.Clear();
                    lstLblCoils = new List<Label>();
                    lstLblCoilsLabels = new List<Label>();
                    int relativePosition = 2, relativePositionY = 0;
                    bool pos = true;

                    for (int i = 0; i < Convert.ToInt32(txtpalletCount.Text); i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoils.Add(new Label());
                            lstLblCoils[0].BackColor = clsGlobal.getColorByPosition(i, 60);
                            lstLblCoils[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            lstLblCoils[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            lstLblCoils[0].Location = new System.Drawing.Point(relativePosition, 2);
                            lstLblCoils[0].Name = "lblCoil0";
                            lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, 746), 78);
                            lstLblCoils[0].TabIndex = 0;
                            lstLblCoils[0].Tag = 0;
                            lstLblCoils[0].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                            lstLblCoils[0].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                            lstLblCoils[0].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                            lstLblCoils[0].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            lblContainer.Controls.Add(lstLblCoils[0]);
                            pos = true;
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                relativePosition += clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, 746) + 1;
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(i, 60);
                                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 2);
                                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, 746), 78);
                                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
                                pos = true;
                            }
                            else
                            {
                                if (pos)
                                    relativePositionY = 81;
                                else
                                    relativePositionY = 160;

                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(i, 60);
                                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, relativePositionY);
                                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(lblDepth.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, 746), 78);
                                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : " + ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : " + ((clsBoxing)cmbCube.SelectedItem).code.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
                                pos = false;
                            }
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un producto para poder graficar el cubicaje y debe seleccionar al menos un tipo de embalaje", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbProduct.Focus();
                isOk = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double width = 0;

            try
            {
                if (isOk)
                {
                    if (dgvCube.Rows.Count > 0)
                    {
                        if (!isUpdate)
                        {
                            for (int i = 0; i < dgvCube.Rows.Count; i++)
                                width += Convert.ToInt32(dgvCube.Rows[i].Cells[clmwidth.Index].Value);

                            width += (txtpalletWidth.Text.Length > 0) ? Convert.ToInt32(txtpalletWidth.Text) : 0;

                            if (width <= Convert.ToInt32(lblDepth.Text))
                            {
                                isUpdate = false;
                                clsCubeDetail objCubeDetail = new clsCubeDetail();
                                objCubeDetail.fkCube = cubeCodsec;
                                objCubeDetail.fkProduct = ((clsProductDisplacement)cmbProduct.SelectedItem).codsec;
                                objCubeDetail.fkBoxing = ((clsBoxing)cmbCube.SelectedItem).codsec;
                                objCubeDetail.fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                                objCubeDetail.Trataiment = cmbTrataiment.Text.ToUpper();
                                objCubeDetail.quantity = Convert.ToDouble(txtQuantity.Text);
                                objCubeDetail.coil = Convert.ToInt32(lblQuantityCoil.Text);
                                objCubeDetail.coilweigth = Convert.ToDouble(lblWeigthPerCoil.Text);
                                objCubeDetail.pallet = Convert.ToInt32(txtpalletCount.Text);
                                objCubeDetail.palletweigth = Convert.ToDouble(txtpalletUnitWeight.Text);
                                objCubeDetail.width = Convert.ToInt32(txtpalletWidth.Text);
                                if (objCubeDetail.save())
                                {
                                    if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                    {
                                        ClearDataList();
                                        RefreshList(cubeCodsec);
                                        CheckWidth();
                                    }
                                    else
                                        this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usted no puede ingresar dicho material ya que sobrepasa el ancho máximo permitido del contenedor seleccionado\n\n ** Por favor cambie de contenedor para poder generar mas ingresos o modifique los actuales", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                cmbProduct.Focus();
                            }
                        }
                        else
                        {
                            //Re-calcular Ancho
                            for (int i = 0; i < dgvCube.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value) == cubeDetailCodsec)
                                    width += (txtpalletWidth.Text.Length > 0) ? Convert.ToInt32(txtpalletWidth.Text) : 0;
                                else
                                    width += Convert.ToInt32(dgvCube.Rows[i].Cells[clmwidth.Index].Value);
                            }
                            if (width <= Convert.ToInt32(lblDepth.Text))
                            {
                                clsCubeDetail objCubeDetail = new clsCubeDetail(cubeDetailCodsec);
                                objCubeDetail.fkProduct = ((clsProductDisplacement)cmbProduct.SelectedItem).codsec;
                                objCubeDetail.fkBoxing = ((clsBoxing)cmbCube.SelectedItem).codsec;
                                objCubeDetail.fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                                objCubeDetail.Trataiment = cmbTrataiment.Text.ToUpper();
                                objCubeDetail.quantity = Convert.ToDouble(txtQuantity.Text);
                                objCubeDetail.coil = Convert.ToInt32(lblQuantityCoil.Text);
                                objCubeDetail.coilweigth = Convert.ToDouble(lblWeigthPerCoil.Text);
                                objCubeDetail.pallet = Convert.ToInt32(txtpalletCount.Text);
                                objCubeDetail.palletweigth = Convert.ToDouble(txtpalletUnitWeight.Text);
                                objCubeDetail.width = Convert.ToInt32(txtpalletWidth.Text);
                                if (objCubeDetail.save())
                                {
                                    if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                    {
                                        ClearDataList();
                                        RefreshList(cubeCodsec);
                                        CheckWidth();
                                    }
                                    else
                                        this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usted no puede ingresar dicho material ya que sobrepasa el ancho máximo permitido del contenedor seleccionado\n\n ** Por favor cambie de contenedor para poder generar mas ingresos o modifique los actuales", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                cmbProduct.Focus();
                            }
                            isUpdate = false;
                        }
                    }
                    else
                    {
                        lblmyWidthContainer.Text = "0";

                        width += (txtpalletWidth.Text.Length > 0) ? Convert.ToInt32(txtpalletWidth.Text) : 0;

                        if (width <= Convert.ToInt32(lblDepth.Text))
                        {
                            isUpdate = false;
                            clsCubeDetail objCubeDetail = new clsCubeDetail();
                            objCubeDetail.fkCube = cubeCodsec;
                            objCubeDetail.fkProduct = ((clsProductDisplacement)cmbProduct.SelectedItem).codsec;
                            objCubeDetail.fkBoxing = ((clsBoxing)cmbCube.SelectedItem).codsec;
                            objCubeDetail.fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                            objCubeDetail.Trataiment = cmbTrataiment.Text.ToUpper();
                            objCubeDetail.quantity = Convert.ToDouble(txtQuantity.Text);
                            objCubeDetail.coil = Convert.ToInt32(lblQuantityCoil.Text);
                            objCubeDetail.coilweigth = Convert.ToDouble(lblWeigthPerCoil.Text);
                            objCubeDetail.pallet = Convert.ToInt32(txtpalletCount.Text);
                            objCubeDetail.palletweigth = Convert.ToDouble(txtpalletUnitWeight.Text);
                            objCubeDetail.width = Convert.ToInt32(txtpalletWidth.Text);
                            if (objCubeDetail.save())
                            {
                                if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                {
                                    ClearDataList();
                                    RefreshList(cubeCodsec);
                                    CheckWidth();
                                }
                                else
                                    this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al momento de generar el data para el cubicaje\n **** Por favor vuelva a intentarlo??", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                cmbProduct.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no puede ingresar dicho material ya que sobrepasa el ancho máximo permitido del contenedor seleccionado\n\n ** Por favor cambie de contenedor para poder generar mas ingresos o modifique los actuales", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbProduct.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos que almacenar por favor ingréselos y vuelva a intentarlo ", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbProduct.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ClearDataList()
        {
            lblContainer.Controls.Clear();
            txtpalletCount.Text = "0";
            txtpalletUnitWeight.Text = "0";
            txtpalletWeight.Text = "0";
            txtpalletWidth.Text = "0";
            txtQuantity.Text = "0";
            lblWeigthAproximate.Text = "0";
            lblWeigthPerCoil.Text = "0";
            lblQuantityCoil.Text = "0";
            lblWidthProduct.Text = "0";
            cmbDimentions.SelectedIndex = -1;
            cmbDimentions.Text = "";
            cmbProduct.SelectedIndex = -1;
            cmbProduct.Text = "";
            cmbCube.SelectedIndex = -1;
            cmbCube.Text = "";
            cmbTrataiment.SelectedIndex = -1;
            cmbTrataiment.Text = "";
            cmbProduct.Focus();
        }

        private void RefreshList(int codsecCube)
        {
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            lstCubeDetail = clsCubeDetail.getListByCube(codsecCube);
            if (lstCubeDetail.Count > 0)
            {
                dgvCube.Rows.Clear();
                for (int i = 0; i < lstCubeDetail.Count; i++)
                {
                    dgvCube.Rows.Add();
                    dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value = lstCubeDetail[i].codsec;
                    dgvCube.Rows[i].Cells[clmcubenumber.Index].Value = (i == 0) ? 1 : dgvCube.Rows.Count;
                    dgvCube.Rows[i].Cells[clmcubematerial.Index].Value = lstCubeDetail[i].codeProduct;
                    dgvCube.Rows[i].Cells[clmcubeboxing.Index].Value = lstCubeDetail[i].transcodeBoxing + " [" + lstCubeDetail[i].transnameBoxing + "]";
                    dgvCube.Rows[i].Cells[clmcubeDimentions.Index].Value = lstCubeDetail[i].dimentionfullDimentions;
                    dgvCube.Rows[i].Cells[clmcubecoil.Index].Value = lstCubeDetail[i].coil;
                    dgvCube.Rows[i].Cells[clmcubepallet.Index].Value = lstCubeDetail[i].pallet;
                    dgvCube.Rows[i].Cells[clmcubequantity.Index].Value = lstCubeDetail[i].quantity;
                    dgvCube.Rows[i].Cells[clmweigth.Index].Value = Math.Round(lstCubeDetail[i].pallet * lstCubeDetail[i].palletweigth, 2, MidpointRounding.AwayFromZero);
                    dgvCube.Rows[i].Cells[clmwidth.Index].Value = lstCubeDetail[i].width;
                    dgvCube.Rows[i].Cells[clmcubeedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvCube.Rows[i].Cells[clmcubedelete.Index].Value = global::BPS.Properties.Resources.cross;
                }

            }
        }

        private void dgvCube_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmcubeedit.Index)
                {
                    MyEdit(Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value));
                }
                else if (e.ColumnIndex == clmcubedelete.Index)
                {
                    if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsCubeDetail.detele(Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value)))
                        {
                            MessageBox.Show("Material borrado con éxito!!", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            RefreshList(cubeCodsec);
                            CheckWidth();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido procesar la información", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            RefreshList(cubeCodsec);
                            CheckWidth();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void MyEdit(int codsec)
        {
            cubeDetailCodsec = codsec;
            clsCubeDetail objCubeDetail = new clsCubeDetail(codsec);
            label3.Text = objCubeDetail.lstCube[0].lstTransport[0].name;
            lblWidth.Text = objCubeDetail.lstCube[0].lstTransport[0].usefulWidth.ToString();
            lblHeight.Text = objCubeDetail.lstCube[0].lstTransport[0].usefulHigh.ToString();
            lblDepth.Text = objCubeDetail.lstCube[0].lstTransport[0].usefulLong.ToString();
            PopulateProduct();
            for (int i = 0; i < cmbProduct.Items.Count; i++)
            {
                if (((clsProductDisplacement)cmbProduct.Items[i]).codsec == objCubeDetail.fkProduct)
                {
                    cmbProduct.SelectedIndex = i;
                    break;
                }
            }
            PopulateTrataimet(objCubeDetail.Trataiment);
            lblWidthProduct.Text = ((clsProductDisplacement)cmbProduct.SelectedItem).width.ToString();
            PopulateCube();
            for (int i = 0; i < cmbCube.Items.Count; i++)
            {
                if (((clsBoxing)cmbCube.Items[i]).codsec == objCubeDetail.fkBoxing)
                {
                    cmbCube.SelectedIndex = i;
                    break;
                }
            }
            PopulateDimentions();
            for (int i = 0; i < cmbDimentions.Items.Count; i++)
            {
                if (((clsPalletDimentions)cmbDimentions.Items[i]).codsec == objCubeDetail.fkPalletDimentions)
                {
                    cmbDimentions.SelectedIndex = i;
                    break;
                }
            }
            txtQuantity.Text = objCubeDetail.quantity.ToString();
            lblQuantityCoil.Text = clsParameters.getCoilNumber(((clsProductDisplacement)cmbProduct.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text)).ToString();
            lblWeigthPerCoil.Text = clsParameters.getWeigthByProduct(((clsProductDisplacement)cmbProduct.SelectedItem).codsec).ToString();
            lblWeigthAproximate.Text = Convert.ToString(Convert.ToDouble(lblQuantityCoil.Text) * Convert.ToDouble(lblWeigthPerCoil.Text));
            GetCubeByBoxing(((clsBoxing)cmbCube.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, ((clsProductDisplacement)cmbProduct.SelectedItem).codsec);
            btnDraw_Click(new object(), new EventArgs());
            isUpdate = true;
        }
    }
}
