using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmTest : Form
    {
        private clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        private string CALLerWindow = "";

        public frmTest()
        {
            InitializeComponent();
        }

        public frmTest(int ObjCuttingOrderCodsec, string CALLerWindow)
        {
            InitializeComponent();
            objCuttingOrder = new clsCuttingOrder(ObjCuttingOrderCodsec);
            this.CALLerWindow = CALLerWindow;

            loadData();
        }
        public void loadData()
        {
            clsMachine objMachine = new clsMachine();
            List<Label> lstLblCoils = new List<Label>();
            List<CheckBox> lstChkSingleFace = new List<CheckBox>();
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            int relativePosition = 16;
            int wasteSize = objMachine.Cutter.utilWidth;
            double usedWidth = 0;

            lblCutterName.Text = objCuttingOrder.machineName;
            lblFilmName.Text = "";
            lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
            nudStopsNumber.Value = objCuttingOrder.repetitions;
            lblUsedArms.Text = objCuttingOrder.positions.ToString();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

            lblWaste1.BackColor = System.Drawing.Color.DimGray;
            lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

            grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            grpbCombination.Controls.Add(lblWaste1);

            relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2);

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                lstLblCoils.Add(new Label());
                lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                lstLblCoils[i].Name = "lblCoil" + i.ToString();
                lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020), 66);
                lstLblCoils[i].TabIndex = 0;
                if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\r\nCliente : " + clsCuttingOrderDetail.getSalesOrderDetailCustomer(objCuttingOrder.lstCuttingOrderDetail[i].codsec) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                else
                    lstLblCoils[i].Text = "Orden  : ----\r\nCliente : STOCK\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                grpbCombination.Controls.Add(lstLblCoils[i]);

                lstChkSingleFace.Add(new CheckBox());
                lstChkSingleFace[i].AutoSize = true;
                lstChkSingleFace[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstChkSingleFace[i].Location = new System.Drawing.Point(relativePosition, 92);
                lstChkSingleFace[i].Name = "chkSingleFace" + i.ToString();
                lstChkSingleFace[i].Size = new System.Drawing.Size(81, 17);
                lstChkSingleFace[i].TabIndex = 10;
                lstChkSingleFace[i].Text = "Single Face";
                lstChkSingleFace[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                lstChkSingleFace[i].UseVisualStyleBackColor = true;
                lstChkSingleFace[i].Checked = objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace;

                grpbCombination.Controls.Add(lstChkSingleFace[i]);

                relativePosition += clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020);
            }

            lblWaste2.BackColor = System.Drawing.Color.DimGray;
            lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
            grpbCombination.Controls.Add(lblWaste2);
            lblNotes.Text = objCuttingOrder.notes;
            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    lblStatusImage.Image = global::BPS.Properties.Resources.paste;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 24:
                    lblStatusImage.Image = global::BPS.Properties.Resources.calendar;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 25:
                    lblStatusImage.Image = global::BPS.Properties.Resources.applications;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 26:
                    lblStatusImage.Image = global::BPS.Properties.Resources.check;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 27:
                    lblStatusImage.Image = global::BPS.Properties.Resources.cancel1;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 31:
                    lblStatusImage.Image = global::BPS.Properties.Resources.Pause_Hot;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                default:
                    break;
            }
            switch (CALLerWindow)
            {
                case "cuttingOrderList":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 24:
                            btnSave.BackgroundImage = global::BPS.Properties.Resources.gear_16;
                            btnSave.Visible = false;
                            btnCancel.Visible = false;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                btnProcess.Visible = true;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                btnSave.BackgroundImage = global::BPS.Properties.Resources.accept;
                                btnSave.Visible = false;
                                btnCancel.Visible = false;

                                btnProcess.Visible = true;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            if (objCuttingOrder.beingProcessed())
                            {
                                btnSave.BackgroundImage = global::BPS.Properties.Resources.accept;
                                btnSave.Visible = false;
                                btnCancel.Visible = false;

                                btnProcess.Visible = true;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                    }


                    break;
                case "cuttingOrder":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 23:
                            btnSave.BackgroundImage = global::BPS.Properties.Resources.calendar_2;
                            btnSave.Visible = true;
                            btnCancel.Visible = true;
                            btnSave.Enabled = true;
                            btnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                btnProcess.Visible = false;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                        case 24:
                            btnSave.BackgroundImage = global::BPS.Properties.Resources.calendar_2;
                            btnSave.Visible = true;
                            btnCancel.Visible = true;
                            btnSave.Enabled = false;
                            btnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                btnProcess.Visible = false;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                btnSave.BackgroundImage = global::BPS.Properties.Resources.accept;
                                btnSave.Visible = true;
                                btnCancel.Visible = true;
                                btnSave.Enabled = false;
                                btnCancel.Enabled = false;

                                btnProcess.Visible = false;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            btnSave.BackgroundImage = global::BPS.Properties.Resources.gear_16;
                            btnSave.Visible = true;
                            btnCancel.Visible = true;
                            btnSave.Enabled = false;
                            btnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                btnProcess.Visible = false;
                                btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
                            }
                            break;
                    }


                    break;
                default:
                    break;
            }

            lblUsedWidth.Text = usedWidth.ToString();
            lblWaste.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
            lblFilmName.Text = objCuttingOrder.boppCode.Replace("-", "");

        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void grpbOrder_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}