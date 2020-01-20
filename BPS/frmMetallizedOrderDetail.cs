using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMetallizedOrderDetail : Form
    {
        clsMetallizedOrder objMetallizedOrder = new clsMetallizedOrder();
        List<clsCoil> lstCoilBopp = new List<clsCoil>();
        List<clsCoil> lstCoilMetalizedBopp = new List<clsCoil>();
        List<clsCoil> lstCoilCast = new List<clsCoil>();
        List<clsCoil> lstCoilMetalizedCast = new List<clsCoil>();
        //List<clsCoilByCoil> lstCoilByCoil = new List<clsCoilByCoil>();
        clsCoil objCoil = new clsCoil();

        /* SE COMENTO TODO POR QUE EN TEORIA ESTO NO SE ESTA USANDO, Y SE REUTILIZÓ LA CLASSE COILBYCOIL QUE LA TABLA ESTABA VACIA. 
         * 
         * void loadOrderData()
        {
            btnAdd.Enabled = false;
            btnClose.Enabled = false;

            if (objMetallizedOrder.fkStatus != 46)
            {
                lblNumber.Text = objMetallizedOrder.number;
                lblMachine.Text = objMetallizedOrder.MachineName;
                lblOpticDensity.Text = Math.Round(objMetallizedOrder.opticDensity, 2).ToString();
                lblProductFrom.Text = objMetallizedOrder.productFromCode;
                lblProductTo.Text = objMetallizedOrder.productToCode;
                lblquantityCoils.Text = objMetallizedOrder.quantityCoils.ToString();
               // lstCoilByCoil = clsCoilByCoil.getDetailByMetallizedOrder(objMetallizedOrder.codsec);


                if (lstCoilByCoil.Count == 0)
                    lblquantityCoilsMetalized.Text = "0";
                else
                    lblquantityCoilsMetalized.Text = lstCoilByCoil[0].quantityMetallizedCoils.ToString();


                if (objMetallizedOrder.prodfkBoppFrom != 0)
                    lstCoilMetalizedBopp = clsCoil.getListByMetalizedOrder(objMetallizedOrder.codsec);
                else
                    lstCoilMetalizedCast = clsCoil.getListByCastMetalizedOrder(objMetallizedOrder.codsec);


                if (lstCoilBopp.Count != 0 & objMetallizedOrder.prodfkBoppFrom != 0)
                {                    
                    dgvToMetallize.Rows.Clear();
                    for (int i = 0; i < lstCoilMetalizedBopp.Count; i++)
                    {
                        dgvToMetallize.Rows.Add();
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedBopp[i].codsec.ToString();
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedBopp[i].code;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedBopp[i].ProductCode;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedBopp[i].width;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedBopp[i].netWeight, 2);
                        dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedBopp[i].length;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedBopp[i].coilCellarContainer;

                    }
                    //nuevo
                }
                else
                {
                    if (objMetallizedOrder.prodfkBoppFrom != 0)
                    {
                        dgvToMetallize.Rows.Clear();
                        for (int i = 0; i < lstCoilMetalizedBopp.Count; i++)
                        {
                            dgvToMetallize.Rows.Add();
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedBopp[i].codsec.ToString();
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedBopp[i].code;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedBopp[i].ProductCode;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedBopp[i].width;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedBopp[i].netWeight, 2);
                            dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedBopp[i].length;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedBopp[i].coilCellarContainer;

                        }
                    }
                    else
                    {
                        if (lstCoilBopp.Count == 0)
                        {


                            if (lstCoilCast.Count != 0 & objMetallizedOrder.prodfkCastFrom != 0)
                            {
                                dgvToMetallize.Rows.Clear();
                                for (int i = 0; i < lstCoilMetalizedCast.Count; i++)
                                {
                                    dgvToMetallize.Rows.Add();
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedCast[i].codsec.ToString();
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedCast[i].code;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedCast[i].ProductCode;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedCast[i].width;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedCast[i].netWeight, 2);
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedCast[i].length;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedCast[i].coilCellarContainer;

                                }
                            }
                            else
                            {
                                if (objMetallizedOrder.prodfkBoppFrom != 0)
                                {
                                    dgvToMetallize.Rows.Clear();

                                    for (int i = 0; i < lstCoilMetalizedCast.Count; i++)
                                    {
                                        dgvToMetallize.Rows.Add();
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedCast[i].codsec.ToString();
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedCast[i].code;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedCast[i].ProductCode;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedCast[i].width;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedCast[i].netWeight, 2);
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedCast[i].length;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedCast[i].coilCellarContainer;

                                    }
                                }
                            }

                        }
                    }

                }
            }
            else
            {

                btnAdd.Enabled = true;
                btnClose.Enabled = true;

                lblNumber.Text = objMetallizedOrder.number;
                lblMachine.Text = objMetallizedOrder.MachineName;
                lblOpticDensity.Text = Math.Round(objMetallizedOrder.opticDensity, 2).ToString();
                lblProductFrom.Text = objMetallizedOrder.productFromCode;
                lblProductTo.Text = objMetallizedOrder.productToCode;
                lblquantityCoils.Text = objMetallizedOrder.quantityCoils.ToString();
                lstCoilByCoil = clsCoilByCoil.getDetailByMetallizedOrder(objMetallizedOrder.codsec);


                if (lstCoilByCoil.Count == 0)
                    lblquantityCoilsMetalized.Text = "0";
                else
                    lblquantityCoilsMetalized.Text = lstCoilByCoil[0].quantityMetallizedCoils.ToString();


                if (objMetallizedOrder.prodfkBoppFrom != 0)
                    lstCoilMetalizedBopp = clsCoil.getListByMetalizedOrder(objMetallizedOrder.codsec);
                else
                    lstCoilMetalizedCast = clsCoil.getListByCastMetalizedOrder(objMetallizedOrder.codsec);

                if (lstCoilBopp.Count != 0 & objMetallizedOrder.prodfkBoppFrom != 0)
                {
                    dgvToMetallize.Rows.Clear();
                    for (int i = 0; i < lstCoilMetalizedBopp.Count; i++)
                    {
                        dgvToMetallize.Rows.Add();
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedBopp[i].codsec.ToString();
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedBopp[i].code;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedBopp[i].ProductCode;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedBopp[i].width;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedBopp[i].netWeight, 2);
                        dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedBopp[i].length;
                        dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedBopp[i].coilCellarContainer;

                    }
                    //nuevo
                }
                else
                {
                    if (objMetallizedOrder.prodfkBoppFrom != 0)
                    {
                        dgvToMetallize.Rows.Clear();
                        for (int i = 0; i < lstCoilMetalizedBopp.Count; i++)
                        {
                            dgvToMetallize.Rows.Add();
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedBopp[i].codsec.ToString();
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedBopp[i].code;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedBopp[i].ProductCode;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedBopp[i].width;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedBopp[i].netWeight, 2);
                            dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedBopp[i].length;
                            dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedBopp[i].coilCellarContainer;

                        }
                    }
                    else
                    {
                        if (lstCoilBopp.Count == 0)
                        {


                            if (lstCoilCast.Count != 0 & objMetallizedOrder.prodfkCastFrom != 0)
                            {
                                dgvToMetallize.Rows.Clear();
                                for (int i = 0; i < lstCoilMetalizedCast.Count; i++)
                                {
                                    dgvToMetallize.Rows.Add();
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedCast[i].codsec.ToString();
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedCast[i].code;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedCast[i].ProductCode;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedCast[i].width;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedCast[i].netWeight, 2);
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedCast[i].length;
                                    dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedCast[i].coilCellarContainer;

                                }
                            }
                            else
                            {
                                if (objMetallizedOrder.prodfkBoppFrom != 0)
                                {
                                    dgvToMetallize.Rows.Clear();
                                    for (int i = 0; i < lstCoilMetalizedCast.Count; i++)
                                    {
                                        dgvToMetallize.Rows.Add();
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCodsec.Index].Value = lstCoilMetalizedCast[i].codsec.ToString();
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCode.Index].Value = lstCoilMetalizedCast[i].code;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedProduct.Index].Value = lstCoilMetalizedCast[i].ProductCode;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedWidth.Index].Value = lstCoilMetalizedCast[i].width;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedWeigth.Index].Value = Math.Round(lstCoilMetalizedCast[i].netWeight, 2);
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedLength.Index].Value = lstCoilMetalizedCast[i].length;
                                        dgvToMetallize.Rows[i].Cells[clmMetallizedCellar.Index].Value = lstCoilMetalizedCast[i].coilCellarContainer;

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
                */
        public frmMetallizedOrderDetail()
        {
            InitializeComponent();
        }
        public frmMetallizedOrderDetail(int metallizedOrderCodsec)
        {
            InitializeComponent();
            objMetallizedOrder.load(metallizedOrderCodsec);
        }
        private void frmMetallizedOrderDetail_Load(object sender, EventArgs e)
        {
            //loadOrderData();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetalizedCoilRegistration winMetalizedCoilRegistration = new frmMetalizedCoilRegistration((Convert.ToInt32(objMetallizedOrder.codsec.ToString())));
            winMetalizedCoilRegistration.StartPosition = FormStartPosition.Manual;
            //winMetalizedCoilRegistration.MdiParent = this.MdiParent;
            winMetalizedCoilRegistration.ShowDialog(this);
            //loadOrderData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clsStatus objStatus = new clsStatus();
            objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Cerrada");
            objMetallizedOrder.load(objMetallizedOrder.codsec);
            objMetallizedOrder.fkStatus = objStatus.codsec;
            objMetallizedOrder.save();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
