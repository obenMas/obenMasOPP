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
    public partial class frmCubeOptionsPlus : Form
    {
        List<stcCubeDetailVolatile> lstCube = new List<stcCubeDetailVolatile>();
        internal clsProduct objProduct = new clsProduct();
        internal clsTransport objTransport = new clsTransport();
        List<Label> lstLblCoilsLabels = new List<Label>();
        List<Label> lstLblCoils = new List<Label>();
        public int cubeCodsec = 0, cubeDetailCodsec = 0, rowOne = 0, rowTwo = 0, rowThree = 0;
        private bool isOk = true, isUpdate = false;
        

        private class stcCubeDetailVolatile
        {
            public int fkCubeDetail { get; set; }
            public int item { get; set; }
            public int fkCube { get; set; }
            public int fkProduct { get; set; }
            public string ProductName { get; set; }
            public int fkBoxing { get; set; }
            public string BoxingName { get; set; }
            public int fkPalletDimentions { get; set; }
            public string PalletDimentions { get; set; }
            public double Quantity { get; set; }
            public int Coil { get; set; }
            public double CoilWeigth { get; set; }
            public int Pallet { get; set; }
            public double PalletWeigth { get; set; }
            public int WidthContainer { get; set; }
            public int row_one { get; set; }
            public int row_two { get; set; }
            public int row_three { get; set; }
            public int containerlegth { get; set; }
            public int widthdata { get; set; }
            public int depthdata { get; set; }
        }

        public frmCubeOptionsPlus()
        {
            InitializeComponent();
        }

        public frmCubeOptionsPlus(int fktransport, int cubeCodsec)
        {
            InitializeComponent();
            PopulaTransport(fktransport);
            PopulateProduct();
            PopulateCube();
            PopulateDimentions();
            this.cubeCodsec = cubeCodsec;
            cmbProduct.Focus();
            RefreshList(cubeCodsec, isUpdate);
            CheckWidth();
        }

        public frmCubeOptionsPlus(int cubeCodsec, int cubeDetail, string data)
        {
            InitializeComponent();
            this.cubeCodsec = cubeCodsec;
            MyEdit(cubeDetail);
        }

        private void CheckWidth()
        {
            double rowOne = 0, rowTwo = 0, rowThree = 0;
            if (dgvCube.Rows.Count > 0)
            {
                for (int i = 0; i < dgvCube.Rows.Count; i++)
                {
                    rowOne = Convert.ToDouble(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                    rowTwo = Convert.ToDouble(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                    rowThree = Convert.ToDouble(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
                }

                lblRowOne.Text = (rowOne != 0) ? rowOne.ToString() : "0";
                lblRowTwo.Text = (rowTwo != 0) ? rowTwo.ToString() : "0";
                lblRowThree.Text = (rowThree != 0) ? rowThree.ToString() : "0";
            }
            else
                lblRowOne.Text = "0";
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

        public frmCubeOptionsPlus(int ProductCodsec, double quantity, string Trataiment)
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
                    GetCubeByBoxingPlus(((clsBoxing)cmbCube.SelectedItem).codsec, Convert.ToDouble(txtQuantity.Text), ((clsPalletDimentions)cmbDimentions.SelectedItem).width, ((clsPalletDimentions)cmbDimentions.SelectedItem).depth, ((clsProductDisplacement)cmbProduct.SelectedItem).codsec, isUpdate, cubeDetailCodsec);
                }
                else
                {
                    MessageBox.Show("Debe completar varios datos requeridos..", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbProduct.Focus();
                }
            }
        }

        private void GetCubeByBoxingPlus(int boxingCodsec, double quantity, int width, int height, int productCodsec, bool isUpdate, int codsecUpdate)
        {
            if (!isUpdate)
            {
                if (dgvCube.Rows.Count == 0)
                {
                    clsBoxing objBoxing = new clsBoxing(boxingCodsec);
                    var pallet = Convert.ToInt32(Convert.ToInt32(lblQuantityCoil.Text) / objBoxing.coil);
                    var palletweigth = (Convert.ToDouble(lblWeigthPerCoil.Text) * objBoxing.coil);
                    double divisibledecimal, widthUsed = 0;
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

                    lstCube.Add(new stcCubeDetailVolatile());
                    lstCube[0].fkCubeDetail = 0;
                    lstCube[0].item = 1;
                    lstCube[0].fkCube = cubeCodsec;
                    lstCube[0].fkProduct = productCodsec;
                    lstCube[0].ProductName = ((clsProductDisplacement)cmbProduct.SelectedItem).code.ToString();
                    lstCube[0].fkBoxing = objBoxing.codsec;
                    lstCube[0].BoxingName = objBoxing.code;
                    lstCube[0].fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                    lstCube[0].PalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "x" + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString();
                    lstCube[0].Quantity = quantity;
                    lstCube[0].Coil = (pallet * objBoxing.coil);
                    lstCube[0].CoilWeigth = Math.Round((pallet * objBoxing.coil) * Convert.ToDouble(lblWeigthPerCoil.Text), 1, MidpointRounding.AwayFromZero);
                    lstCube[0].Pallet = pallet;
                    lstCube[0].PalletWeigth = palletweigth;
                    lstCube[0].WidthContainer = Convert.ToInt32(widthUsed);
                    lstCube[0].widthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).width;
                    lstCube[0].depthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).depth;
                    lstCube[0].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                    lstCube[0].row_one = 0;
                    lstCube[0].row_two = 0;
                    lstCube[0].row_three = 0;
                }
                else
                {
                    clsBoxing objBoxing = new clsBoxing(boxingCodsec);
                    var pallet = Convert.ToInt32(Convert.ToInt32(lblQuantityCoil.Text) / objBoxing.coil);
                    var palletweigth = (Convert.ToDouble(lblWeigthPerCoil.Text) * objBoxing.coil);
                    double divisibledecimal, widthUsed = 0;
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

                    lstCube = new List<stcCubeDetailVolatile>();

                    for (int i = 0; i < dgvCube.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[0].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[0].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[0].Quantity = Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubequantity.Index].Value);
                            lstCube[0].Coil = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecoil.Index].Value);
                            lstCube[0].Pallet = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubepallet.Index].Value);
                            lstCube[0].widthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value);
                            lstCube[0].depthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubedepth.Index].Value);
                            lstCube[0].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[0].row_one = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                            lstCube[0].row_two = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                            lstCube[0].row_three = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
                        }
                        else
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[lstCube.Count - 1].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[lstCube.Count - 1].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[lstCube.Count - 1].Quantity = Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubequantity.Index].Value);
                            lstCube[lstCube.Count - 1].Coil = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecoil.Index].Value);
                            lstCube[lstCube.Count - 1].Pallet = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubepallet.Index].Value);
                            lstCube[lstCube.Count - 1].widthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value);
                            lstCube[lstCube.Count - 1].depthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubedepth.Index].Value);
                            lstCube[lstCube.Count - 1].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[lstCube.Count - 1].row_one = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                            lstCube[lstCube.Count - 1].row_two = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                            lstCube[lstCube.Count - 1].row_three = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
                        }
                    }

                    lstCube.Add(new stcCubeDetailVolatile());
                    lstCube[lstCube.Count - 1].fkCubeDetail = 0;
                    lstCube[lstCube.Count - 1].item = lstCube.Count;
                    lstCube[lstCube.Count - 1].fkCube = cubeCodsec;
                    lstCube[lstCube.Count - 1].fkProduct = productCodsec;
                    lstCube[lstCube.Count - 1].ProductName = ((clsProductDisplacement)cmbProduct.SelectedItem).code.ToString();
                    lstCube[lstCube.Count - 1].fkBoxing = objBoxing.codsec;
                    lstCube[lstCube.Count - 1].BoxingName = objBoxing.code;
                    lstCube[lstCube.Count - 1].fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                    lstCube[lstCube.Count - 1].PalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "x" + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString();
                    lstCube[lstCube.Count - 1].Quantity = quantity;
                    lstCube[lstCube.Count - 1].Coil = (pallet * objBoxing.coil);
                    lstCube[lstCube.Count - 1].CoilWeigth = Math.Round((pallet * objBoxing.coil) * Convert.ToDouble(lblWeigthPerCoil.Text), 1, MidpointRounding.AwayFromZero);
                    lstCube[lstCube.Count - 1].Pallet = pallet;
                    lstCube[lstCube.Count - 1].PalletWeigth = palletweigth;
                    lstCube[lstCube.Count - 1].WidthContainer = Convert.ToInt32(widthUsed);
                    lstCube[lstCube.Count - 1].widthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).width;
                    lstCube[lstCube.Count - 1].depthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).depth;
                    lstCube[lstCube.Count - 1].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                    lstCube[lstCube.Count - 1].row_one = 0;
                    lstCube[lstCube.Count - 1].row_two = 0;
                    lstCube[lstCube.Count - 1].row_three = 0;
                }
                CalculeRows(lstCube);
            }
            else
            {
                clsBoxing objBoxing = new clsBoxing(boxingCodsec);
                var pallet = Convert.ToInt32(Convert.ToInt32(lblQuantityCoil.Text) / objBoxing.coil);
                var palletweigth = (Convert.ToDouble(lblWeigthPerCoil.Text) * objBoxing.coil);
                double divisibledecimal, widthUsed = 0;
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

                lstCube = new List<stcCubeDetailVolatile>();

                for (int i = 0; i < dgvCube.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        if (Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value) == codsecUpdate)
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[0].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[0].fkCube = cubeCodsec;
                            lstCube[0].fkProduct = productCodsec;
                            lstCube[0].ProductName = ((clsProductDisplacement)cmbProduct.SelectedItem).code.ToString();
                            lstCube[0].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[0].fkBoxing = objBoxing.codsec;
                            lstCube[0].BoxingName = objBoxing.code;
                            lstCube[0].fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                            lstCube[0].PalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "x" + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString();
                            lstCube[0].Quantity = quantity;
                            lstCube[0].Coil = (pallet * objBoxing.coil);
                            lstCube[0].CoilWeigth = Math.Round((pallet * objBoxing.coil) * Convert.ToDouble(lblWeigthPerCoil.Text), 1, MidpointRounding.AwayFromZero);
                            lstCube[0].Pallet = pallet;
                            lstCube[0].PalletWeigth = palletweigth;
                            lstCube[0].WidthContainer = Convert.ToInt32(widthUsed);
                            lstCube[0].widthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).width;
                            lstCube[0].depthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).depth;
                            lstCube[0].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[0].row_one = 0;
                            lstCube[0].row_two = 0;
                            lstCube[0].row_three = 0;
                        }
                        else
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[0].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[0].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[0].Quantity = Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubequantity.Index].Value);
                            lstCube[0].Coil = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecoil.Index].Value);
                            lstCube[0].Pallet = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubepallet.Index].Value);
                            lstCube[0].widthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value);
                            lstCube[0].depthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubedepth.Index].Value);
                            lstCube[0].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[0].row_one = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                            lstCube[0].row_two = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                            lstCube[0].row_three = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value) == codsecUpdate)
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[lstCube.Count - 1].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[lstCube.Count - 1].fkCube = cubeCodsec;
                            lstCube[lstCube.Count - 1].fkProduct = productCodsec;
                            lstCube[lstCube.Count - 1].ProductName = ((clsProductDisplacement)cmbProduct.SelectedItem).code.ToString();
                            lstCube[lstCube.Count - 1].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[lstCube.Count - 1].fkBoxing = objBoxing.codsec;
                            lstCube[lstCube.Count - 1].BoxingName = objBoxing.code;
                            lstCube[lstCube.Count - 1].fkPalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                            lstCube[lstCube.Count - 1].PalletDimentions = ((clsPalletDimentions)cmbDimentions.SelectedItem).width.ToString() + "x" + ((clsPalletDimentions)cmbDimentions.SelectedItem).depth.ToString();
                            lstCube[lstCube.Count - 1].Quantity = quantity;
                            lstCube[lstCube.Count - 1].Coil = (pallet * objBoxing.coil);
                            lstCube[lstCube.Count - 1].CoilWeigth = Math.Round((pallet * objBoxing.coil) * Convert.ToDouble(lblWeigthPerCoil.Text), 1, MidpointRounding.AwayFromZero);
                            lstCube[lstCube.Count - 1].Pallet = pallet;
                            lstCube[lstCube.Count - 1].PalletWeigth = palletweigth;
                            lstCube[lstCube.Count - 1].WidthContainer = Convert.ToInt32(widthUsed);
                            lstCube[lstCube.Count - 1].widthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).width;
                            lstCube[lstCube.Count - 1].depthdata = ((clsPalletDimentions)cmbDimentions.SelectedItem).depth;
                            lstCube[lstCube.Count - 1].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[lstCube.Count - 1].row_one = 0;
                            lstCube[lstCube.Count - 1].row_two = 0;
                            lstCube[lstCube.Count - 1].row_three = 0;
                        }
                        else
                        {
                            lstCube.Add(new stcCubeDetailVolatile());
                            lstCube[lstCube.Count - 1].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                            lstCube[lstCube.Count - 1].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                            lstCube[lstCube.Count - 1].Quantity = Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubequantity.Index].Value);
                            lstCube[lstCube.Count - 1].Coil = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecoil.Index].Value);
                            lstCube[lstCube.Count - 1].Pallet = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubepallet.Index].Value);
                            lstCube[lstCube.Count - 1].widthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value);
                            lstCube[lstCube.Count - 1].depthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubedepth.Index].Value);
                            lstCube[lstCube.Count - 1].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                            lstCube[lstCube.Count - 1].row_one = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                            lstCube[lstCube.Count - 1].row_two = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                            lstCube[lstCube.Count - 1].row_three = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
                        }
                    }
                }

                
            }
            CalculeRows(lstCube);
        }

        private void CalculeRows(List<stcCubeDetailVolatile> lstCube)
        {
            List<Label> lstLblCoils = new List<Label>();
            List<Label> lstLblCoilsLabels = new List<Label>();
            bool pos = true;
            int totalUsedWidth = 0, relativePosition = 2, relativePositionY = 0, lastpositionX = 0, lastpositionY = 0, poscube = 0;
            rowOne = 0;
            rowTwo = 0; 
            rowThree = 0;

            if (lstCube.Count > 0)
            {
                totalUsedWidth = lstCube[0].containerlegth;
                lblContainer.Controls.Clear();
                for (int i = 0; i < lstCube.Count; i++)
                {
                    if (lstCube[i].widthdata == 77)
                    {
                        for (int j = 0; j < lstCube[i].Pallet; j++)
                        {
                            if (lstLblCoils.Count == 0)
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 99);
                                lstLblCoils[0].Tag = lstCube[i].depthdata;
                                lstLblCoils[0].Text = lstCube[i].widthdata.ToString();
                            }
                            else
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 99);
                                lstLblCoils[lstLblCoils.Count - 1].Tag = lstCube[i].depthdata;
                                lstLblCoils[lstLblCoils.Count - 1].Text = lstCube[i].widthdata.ToString();
                            }
                        }
                    }
                    else if (lstCube[i].widthdata == 116)
                    {
                        for (int j = 0; j < lstCube[i].Pallet; j++)
                        {
                            if (lstLblCoilsLabels.Count == 0)
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 148);
                                lstLblCoilsLabels[0].Tag = lstCube[i].depthdata;
                                lstLblCoilsLabels[0].TabIndex = lstCube[i].widthdata;
                                lstLblCoilsLabels[0].Text = "FilaI-inicio";

                            }
                            else
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 148);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Tag = lstCube[i].depthdata;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].TabIndex = lstCube[i].widthdata;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Text = "FilaII-inicio";
                            }
                        }
                    }
                }

                lblContainer.Controls.Clear();

                if (lstLblCoils.Count > 0)
                {
                    for (int i = 0; i < lstLblCoils.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoils[i]);
                            rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                            pos = true;
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                lastpositionX = lstLblCoils[i].Size.Width;
                                lastpositionY = lstLblCoils[i - 3].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i].Tag.ToString()), 796) + 1;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i - 3].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = true;
                            }
                            else
                            {
                                if (pos)
                                {
                                    relativePositionY = 102;
                                    rowTwo += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    relativePositionY = 202;
                                    rowThree += Convert.ToInt32(lstLblCoils[i].Tag);
                                }

                                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, relativePositionY);
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = false;
                            }
                        }
                    }

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[lstLblCoils.Count - 1].Tag.ToString()), 796) + 1; ;

                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
                else if (lstLblCoilsLabels.Count > 0)
                {
                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
            }
            lblContainer.Controls.Clear();
            lblRowOne.Text = rowOne.ToString();
            lblRowTwo.Text = rowTwo.ToString();
            lblRowThree.Text = rowThree.ToString();
            //MessageBox.Show("Fila I = " + rowOne.ToString() + " , Fila II = " + rowTwo.ToString() + " Fila III = " + rowThree.ToString());
            if (rowOne <= totalUsedWidth)
                isOk = true;
            else
                isOk = false;
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
            try
            {
                if (isOk)
                {
                    if (dgvCube.Rows.Count > 0)
                    {
                        if (!isUpdate)
                        {
                            if (rowOne <= Convert.ToInt32(lblDepth.Text))
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
                                objCubeDetail.rowOne = rowOne;
                                objCubeDetail.rowTwo = rowTwo;
                                objCubeDetail.rowThree = rowThree;
                                if (objCubeDetail.save())
                                {
                                    if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                    {
                                        ClearDataList();
                                        RefreshList(cubeCodsec, isUpdate);
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
                            if (rowOne <= Convert.ToInt32(lblDepth.Text))
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
                                objCubeDetail.rowOne = rowOne;
                                objCubeDetail.rowTwo = rowTwo;
                                objCubeDetail.rowThree = rowThree;
                                if (objCubeDetail.save())
                                {
                                    if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                    {
                                        ClearDataList();
                                        RefreshData(cubeCodsec);
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
                        if (rowOne <= Convert.ToInt32(lblDepth.Text))
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
                            objCubeDetail.rowOne = rowOne;
                            objCubeDetail.rowTwo = rowTwo;
                            objCubeDetail.rowThree = rowThree;
                            if (objCubeDetail.save())
                            {
                                if (MessageBox.Show("Cubicaje adicionado correctamente \n Desea generar otro cubicaje??", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                {
                                    ClearDataList();
                                    RefreshList(cubeCodsec, isUpdate);
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

        private void RefreshData(int cubeCodsec)
        {
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            List<clsCubeDetail> lstCubeDetailAux = new List<clsCubeDetail>();
            lstCubeDetail = clsCubeDetail.getListByCube(cubeCodsec);

            if (clsCubeDetail.deteleCubeDetail(cubeCodsec))
            {
 
            }
            //Delete detail
            for (int i = 0; i < lstCubeDetail.Count; i++)
            {
                if (i == 0)
                {
                    lstCubeDetailAux.Add(lstCubeDetail[i]);
                    RowsData(lstCubeDetailAux);
                }
                else
                {
                    lstCubeDetailAux.Add(lstCubeDetail[i]);
                    RowsData(lstCubeDetailAux);
                }
            }
            RefreshList(lstCubeDetail[0].fkCube, false);
        }

        private void RowsData(List<clsCubeDetail> lstCubeDetailAux)
        {
            List<Label> lstLblCoils = new List<Label>();
            List<Label> lstLblCoilsLabels = new List<Label>();
            bool pos = true;
            int totalUsedWidth = 0, relativePosition = 2, relativePositionY = 0, lastpositionX = 0, lastpositionY = 0, poscube = 0;
            rowOne = 0;
            rowTwo = 0;
            rowThree = 0;

            if (lstCubeDetailAux.Count > 0)
            {
                totalUsedWidth = lstCubeDetailAux[0].usefulLongCube;
                lblContainer.Controls.Clear();
                for (int i = 0; i < lstCubeDetailAux.Count; i++)
                {
                    if (lstCubeDetailAux[i].dimentionwidthDimentions == 77)
                    {
                        for (int j = 0; j < lstCubeDetailAux[i].pallet; j++)
                        {
                            if (lstLblCoils.Count == 0)
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetailAux[i].dimentiondepthDimentions, 796), 99);
                                lstLblCoils[0].Tag = lstCubeDetailAux[i].dimentiondepthDimentions;
                            }
                            else
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetailAux[i].dimentiondepthDimentions, 796), 99);
                                lstLblCoils[lstLblCoils.Count - 1].Tag = lstCubeDetailAux[i].dimentiondepthDimentions;
                            }
                        }
                    }
                    else if (lstCubeDetailAux[i].dimentionwidthDimentions == 116)
                    {
                        for (int j = 0; j < lstCubeDetailAux[i].pallet; j++)
                        {
                            if (lstLblCoilsLabels.Count == 0)
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetailAux[i].dimentiondepthDimentions, 796), 148);
                                lstLblCoilsLabels[0].Tag = lstCubeDetailAux[i].dimentiondepthDimentions;

                            }
                            else
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetailAux[i].dimentiondepthDimentions, 796), 148);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Tag = lstCubeDetailAux[i].dimentiondepthDimentions;
                            }
                        }
                    }
                }

                lblContainer.Controls.Clear();

                if (lstLblCoils.Count > 0)
                {
                    for (int i = 0; i < lstLblCoils.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoils[i]);
                            rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                            pos = true;
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                lastpositionX = lstLblCoils[i].Size.Width;
                                lastpositionY = lstLblCoils[i - 3].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i].Tag.ToString()), 796) + 1;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i - 3].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = true;
                            }
                            else
                            {
                                if (pos)
                                {
                                    relativePositionY = 102;
                                    rowTwo += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    relativePositionY = 202;
                                    rowThree += Convert.ToInt32(lstLblCoils[i].Tag);
                                }

                                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, relativePositionY);
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = false;
                            }
                        }
                    }

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[lstLblCoils.Count - 1].Tag.ToString()), 796) + 1; ;

                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
                else if (lstLblCoilsLabels.Count > 0)
                {
                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
            }
            lblContainer.Controls.Clear();
            clsCubeDetail objCubeDetail = new clsCubeDetail();
            objCubeDetail.fkCube = lstCubeDetailAux[lstCubeDetailAux.Count - 1].fkCube;
            objCubeDetail.fkProduct = lstCubeDetailAux[lstCubeDetailAux.Count - 1].fkProduct;
            objCubeDetail.fkBoxing = lstCubeDetailAux[lstCubeDetailAux.Count - 1].fkBoxing;
            objCubeDetail.fkPalletDimentions = lstCubeDetailAux[lstCubeDetailAux.Count - 1].fkPalletDimentions;
            objCubeDetail.Trataiment = lstCubeDetailAux[lstCubeDetailAux.Count - 1].Trataiment;
            objCubeDetail.quantity = lstCubeDetailAux[lstCubeDetailAux.Count - 1].quantity;
            objCubeDetail.coil = lstCubeDetailAux[lstCubeDetailAux.Count - 1].coil;
            objCubeDetail.coilweigth = lstCubeDetailAux[lstCubeDetailAux.Count - 1].coilweigth;
            objCubeDetail.pallet = lstCubeDetailAux[lstCubeDetailAux.Count - 1].pallet;
            objCubeDetail.palletweigth = lstCubeDetailAux[lstCubeDetailAux.Count - 1].palletweigth;
            objCubeDetail.width = lstCubeDetailAux[lstCubeDetailAux.Count - 1].width;
            objCubeDetail.rowOne = rowOne;
            objCubeDetail.rowTwo = rowTwo;
            objCubeDetail.rowThree = rowThree;
            objCubeDetail.save();
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

        private void RefreshList(int codsecCube, bool isUpdate)
        {
            if (!isUpdate)
            {
                List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
                lstCubeDetail = clsCubeDetail.getListByCube(codsecCube);
                if (lstCubeDetail.Count > 0)
                {
                    dgvCube.Rows.Clear();
                    for (int i = 0; i < lstCubeDetail.Count; i++)
                    {
                        if (i == 0)
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
                            dgvCube.Rows[i].Cells[clmrowOne.Index].Value = lstCubeDetail[i].rowOne;
                            dgvCube.Rows[i].Cells[clmrowTwo.Index].Value = lstCubeDetail[i].rowTwo;
                            dgvCube.Rows[i].Cells[clmrowThree.Index].Value = lstCubeDetail[i].rowThree;
                            dgvCube.Rows[i].Cells[clmcubedepth.Index].Value = lstCubeDetail[i].dimentiondepthDimentions;
                            dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value = lstCubeDetail[i].dimentionwidthDimentions;
                            dgvCube.Rows[i].Cells[clmcubeedit.Index].Value = global::BPS.Properties.Resources.pencil;
                            dgvCube.Rows[i].Cells[clmcubedelete.Index].Value = global::BPS.Properties.Resources.cross;
                        }
                        else
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
                            dgvCube.Rows[i].Cells[clmwidth.Index].Value = (lstCubeDetail[i - 1].rowOne == lstCubeDetail[i].rowOne) ? 0 : lstCubeDetail[i].rowOne;
                            dgvCube.Rows[i].Cells[clmrowOne.Index].Value = lstCubeDetail[i].rowOne;
                            dgvCube.Rows[i].Cells[clmrowTwo.Index].Value = lstCubeDetail[i].rowTwo;
                            dgvCube.Rows[i].Cells[clmrowThree.Index].Value = lstCubeDetail[i].rowThree;
                            dgvCube.Rows[i].Cells[clmcubedepth.Index].Value = lstCubeDetail[i].dimentiondepthDimentions;
                            dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value = lstCubeDetail[i].dimentionwidthDimentions;
                            dgvCube.Rows[i].Cells[clmcubeedit.Index].Value = global::BPS.Properties.Resources.pencil;
                            dgvCube.Rows[i].Cells[clmcubedelete.Index].Value = global::BPS.Properties.Resources.cross;
                        }
                    }
                }
            }
            else
            {
                ReOrderRowInContainer();
                isUpdate = false;
            }
        }

        private void ReOrderRowInContainer()
        {
            lstCube = new List<stcCubeDetailVolatile>();
            for (int i = 0; i < dgvCube.Rows.Count; i++)
            {
                lstCube.Add(new stcCubeDetailVolatile());
                lstCube[i].item = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubenumber.Index].Value);
                lstCube[i].fkCubeDetail = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value);
                lstCube[i].Quantity = Convert.ToDouble(dgvCube.Rows[i].Cells[clmcubequantity.Index].Value);
                lstCube[i].Coil = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubecoil.Index].Value);
                lstCube[i].Pallet = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubepallet.Index].Value);
                lstCube[i].widthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubewidthpallet.Index].Value);
                lstCube[i].depthdata = Convert.ToInt32(dgvCube.Rows[i].Cells[clmcubedepth.Index].Value);
                lstCube[i].containerlegth = Convert.ToInt32(objTransport.usefulLong);
                lstCube[i].row_one = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowOne.Index].Value);
                lstCube[i].row_two = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowTwo.Index].Value);
                lstCube[i].row_three = Convert.ToInt32(dgvCube.Rows[i].Cells[clmrowThree.Index].Value);
            }

            List<Label> lstLblCoils = new List<Label>();
            List<Label> lstLblCoilsLabels = new List<Label>();
            bool pos = true;
            int totalUsedWidth = 0, relativePosition = 2, relativePositionY = 0, lastpositionX = 0, lastpositionY = 0, poscube = 0, posPallet = 0;
            List<int> lstCodsecByPallet = new List<int>();
            rowOne = 0;
            rowTwo = 0; 
            rowThree = 0;

            if (lstCube.Count > 0)
            {
                totalUsedWidth = lstCube[0].containerlegth;
                lblContainer.Controls.Clear();
                for (int i = 0; i < lstCube.Count; i++)
                {
                    if (lstCube[i].widthdata == 77)
                    {
                        for (int j = 0; j < lstCube[i].Pallet; j++)
                        {
                            if (lstLblCoils.Count == 0)
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 99);
                                lstLblCoils[0].Tag = lstCube[i].depthdata;
                                lstLblCoils[0].Text = lstCube[i].fkCubeDetail.ToString();
                                lstCodsecByPallet.Add(lstCube[i].fkCubeDetail);
                            }
                            else
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 99);
                                lstLblCoils[lstLblCoils.Count - 1].Tag = lstCube[i].depthdata;
                                lstLblCoils[lstLblCoils.Count - 1].Text = lstCube[i].fkCubeDetail.ToString();
                                lstCodsecByPallet.Add(lstCube[i].fkCubeDetail);
                            }
                        }
                    }
                    else if (lstCube[i].widthdata == 116)
                    {
                        for (int j = 0; j < lstCube[i].Pallet; j++)
                        {
                            if (lstLblCoilsLabels.Count == 0)
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 148);
                                lstLblCoilsLabels[0].Tag = lstCube[i].depthdata;
                                lstLblCoilsLabels[0].TabIndex = lstCube[i].widthdata;
                                lstLblCoilsLabels[0].Text = lstCube[i].fkCubeDetail.ToString();
                                lstCodsecByPallet.Add(lstCube[i].fkCubeDetail);

                            }
                            else
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCube[i].depthdata, 796), 148);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Tag = lstCube[i].depthdata;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].TabIndex = lstCube[i].widthdata;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Text = lstCube[i].fkCubeDetail.ToString();
                                lstCodsecByPallet.Add(lstCube[i].fkCubeDetail);
                            }
                        }
                    }
                }

                lblContainer.Controls.Clear();

                if (lstLblCoils.Count > 0)
                {
                    for (int i = 0; i < lstLblCoils.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoils[i]);
                            rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                            pos = true;
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                lastpositionX = lstLblCoils[i].Size.Width;
                                lastpositionY = lstLblCoils[i - 3].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i].Tag.ToString()), 796) + 1;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i - 3].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                    rowOne += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = true;
                            }
                            else
                            {
                                if (pos)
                                {
                                    relativePositionY = 102;
                                    rowTwo += Convert.ToInt32(lstLblCoils[i].Tag);
                                }
                                else
                                {
                                    relativePositionY = 202;
                                    rowThree += Convert.ToInt32(lstLblCoils[i].Tag);
                                }

                                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, relativePositionY);
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = false;
                            }
                        }
                    }

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[lstLblCoils.Count - 1].Tag.ToString()), 796) + 1; ;

                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            posPallet = Convert.ToInt32(lstLblCoilsLabels[i].Text);
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        }
                        else
                        {
                            if (posPallet == 0)
                            {
                                if (i % 2 != 0)
                                {
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                    lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                    rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                }
                                else
                                {
                                    lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                    lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                    if (lastpositionX == lastpositionY)
                                    {
                                        relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                        lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                        rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                    }
                                    else
                                    {
                                        poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                        relativePosition += poscube;
                                        lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                        rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                                    }
                                    lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                                } 
                            }
                        }
                    }
                }
                else if (lstLblCoilsLabels.Count > 0)
                {
                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        for (int j = 0; j < lstCodsecByPallet.Count; j++)
                        {
                            
                        }
                        //if (i == 0)
                        //{
                        //    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                        //    lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                        //    rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        //}
                        //else
                        //{
                        //    if (i % 2 != 0)
                        //    {
                        //        lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                        //        lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                        //        rowTwo += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        //    }
                        //    else
                        //    {
                        //        lastpositionX = lstLblCoilsLabels[i].Size.Width;
                        //        lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                        //        if (lastpositionX == lastpositionY)
                        //        {
                        //            relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                        //            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                        //            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        //        }
                        //        else
                        //        {
                        //            poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                        //            relativePosition += poscube;
                        //            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                        //            rowOne += Convert.ToInt32(lstLblCoilsLabels[i].Tag);
                        //        }
                        //        lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                        //    }
                        //}
                    }
                }
            }
            lblContainer.Controls.Clear();
            lblRowOne.Text = rowOne.ToString();
            lblRowTwo.Text = rowTwo.ToString();
            lblRowThree.Text = rowThree.ToString();
            MessageBox.Show("Fila I = " + rowOne.ToString() + " , Fila II = " + rowTwo.ToString() + " Fila III = " + rowThree.ToString());
            if (rowOne <= totalUsedWidth)
                isOk = true;
            else
                isOk = false;



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
                            RefreshData(cubeCodsec);
                            CheckWidth();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido procesar la información", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            RefreshList(cubeCodsec, isUpdate);
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
            txtpalletCount.Text = objCubeDetail.pallet.ToString();
            txtpalletUnitWeight.Text = objCubeDetail.palletweigth.ToString();
            txtpalletWidth.Text = objCubeDetail.width.ToString();
            txtpalletWeight.Text = objCubeDetail.palletweigth.ToString();
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
            btnDraw_Click(new object(), new EventArgs());
            isUpdate = true;
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                frmProductsForm winProduct = new frmProductsForm();
                winProduct.ShowDialog();
                PopulateProduct();
            }
        }
    }
}
