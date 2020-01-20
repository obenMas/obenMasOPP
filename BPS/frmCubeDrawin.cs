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
    public partial class frmCubeDrawin : Form
    {
        //public void loadCoilLayout()
        //{
        //    List<Label> lstLblCoils = new List<Label>();
        //    List<Label> lstLblCoilsLabels = new List<Label>();
        //    int relativePosition = 2, relativePositionY = 0;
        //    double usedWidth = 0;
        //    int totalUsedWidth = 0;
        //    double length = 0;
        //    bool pos = true;
        //    //patametros
        //    int widthpallet = 110;
        //    int productCount = 6;

        //    //dibujar una caja dentro del contedor
        //    lblContainer.Controls.Clear();
        //    totalUsedWidth = 1200;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        if (i == 0)
        //        {
        //            lstLblCoils.Add(new Label());
        //            lstLblCoils[0].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //            lstLblCoils[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //            lstLblCoils[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lstLblCoils[0].Location = new System.Drawing.Point(relativePosition, 2);
        //            lstLblCoils[0].Name = "lblCoil0";
        //            lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 148);
        //            lstLblCoils[0].TabIndex = 0;
        //            lstLblCoils[0].Tag = 0;
        //            lstLblCoils[0].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //            lstLblCoils[0].Text += "Std : 116\n";
        //            lstLblCoils[0].Text += "Emb : H002\n";
        //            lstLblCoils[0].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //            lblContainer.Controls.Add(lstLblCoils[0]);
        //        }
        //        else
        //        {
        //            if (i % 2 != 0)
        //            {
        //                lstLblCoils.Add(new Label());
        //                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 152);
        //                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
        //                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 148);
        //                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : 116\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : H002\n";
        //                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
        //            }
        //            else
        //            {
        //                relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796) + 1;
        //                lstLblCoils.Add(new Label());
        //                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 2);
        //                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
        //                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 148);
        //                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : 116\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : H002\n";
        //                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
        //            }
        //        }
        //    }

        //    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796) + 1;
        //    productCount++;

        //    for (int i = 0; i < 7; i++)
        //    {
        //        if (i == 0)
        //        {
        //            lstLblCoils.Add(new Label());
        //            lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //            lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //            lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 2);
        //            lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
        //            lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 99);
        //            lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
        //            lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
        //            lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //            lstLblCoils[lstLblCoils.Count - 1].Text += "Std : 77\n";
        //            lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : ----\n";
        //            lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //            lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
        //            pos = true;
        //        }
        //        else
        //        {
        //            if (i % 3 == 0)
        //            {
        //                relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796) + 1;
        //                lstLblCoils.Add(new Label());
        //                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, 2);
        //                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
        //                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 99);
        //                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : 77\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : ----\n";
        //                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
        //                pos = true;
        //            }
        //            else
        //            {
        //                if (pos)
        //                    relativePositionY = 102;
        //                else
        //                    relativePositionY = 202;
        //                lstLblCoils.Add(new Label());
        //                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(productCount, 60);
        //                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(relativePosition, relativePositionY);
        //                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil0";
        //                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, widthpallet, 796), 99);
        //                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Tag = 0;
        //                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + widthpallet.ToString() + "\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : 77\n";
        //                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : ----\n";
        //                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //                lblContainer.Controls.Add(lstLblCoils[lstLblCoils.Count - 1]);
        //                pos = false;
        //            }
        //        }
        //    }
        //}

        int codsec = 0;
        public frmCubeDrawin()
        {
            InitializeComponent();
        }

        public frmCubeDrawin(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            Drawin(codsec);
            PopulateHead(codsec);
        }

        private void PopulateHead(int codsec)
        {
            List<clsCubeData> lstCubeData = new List<clsCubeData>();
            lstCubeData = clsCubeData.getListByCodsec(codsec);
            label3.Text = lstCubeData[0].lstTransport[0].name;
            lblWidth.Text = lstCubeData[0].lstTransport[0].usefulWidth.ToString();
            lblHeight.Text = lstCubeData[0].lstTransport[0].usefulHigh.ToString();
            lblDepth.Text = lstCubeData[0].lstTransport[0].usefulLong.ToString();
            label5.Text = lstCubeData[0].order;
            clsEntity objEntity = new clsEntity(lstCubeData[0].fkCustomer);
            label6.Text = objEntity.companyName;
            clsCountry objCountry = new clsCountry(objEntity.fkCountry);
            label7.Text = objCountry.name;
            RefreshList(codsec);
        }

        private void RefreshList(int codsecCube)
        {
            double myweigth = 0;
            int rowOne = 0, rowTwo = 0, rowThree = 0;
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            lstCubeDetail = clsCubeDetail.getListByCube(codsecCube);
            if (lstCubeDetail.Count > 0)
            {
                for (int i = 0; i < lstCubeDetail.Count; i++)
                    myweigth += Convert.ToDouble(lstCubeDetail[i].pallet * lstCubeDetail[i].palletweigth);

                for (int i = 0; i < lstCubeDetail.Count; i++)
                {
                    rowOne = Convert.ToInt32(lstCubeDetail[i].rowOne);
                    rowTwo = Convert.ToInt32(lstCubeDetail[i].rowTwo);
                    rowThree = Convert.ToInt32(lstCubeDetail[i].rowThree);
                }

                lblRowOne.Text = rowOne.ToString();
                lblRowTwo.Text = rowTwo.ToString();
                lblRowThree.Text = rowThree.ToString();
                lblNetWeigth.Text = Math.Round(myweigth, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                lblNetWeigth.Text = "0";
                lblRowOne.Text = "0";
                lblRowTwo.Text = "0";
                lblRowThree.Text = "0";
            }
        }

        private void Drawin(int codsec)
        {
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            lstCubeDetail = clsCubeDetail.getListByCubeSortMaterial(codsec);
            List<Label> lstLblCoils = new List<Label>();
            List<Label> lstLblCoilsLabels = new List<Label>();
            bool pos = true;
            int totalUsedWidth = 0, relativePosition = 2, relativePositionY = 0, lastpositionX = 0, lastpositionY = 0, poscube = 0;

            if (lstCubeDetail.Count > 0)
            {
                totalUsedWidth = lstCubeDetail[0].usefulLongCube;
                lblContainer.Controls.Clear();
                for (int i = 0; i < lstCubeDetail.Count; i++)
                {
                    if (lstCubeDetail[i].dimentionwidthDimentions == 77)
                    {
                        for (int j = 0; j < lstCubeDetail[i].pallet; j++)
                        {
                            if (lstLblCoils.Count == 0)
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[0].BackColor = clsGlobal.getColorByPosition(j + i, 60);
                                lstLblCoils[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[0].Location = new System.Drawing.Point(1, 1);
                                lstLblCoils[0].Name = "lblCoil" + i.ToString() + " pos" + j.ToString();
                                lstLblCoils[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetail[i].dimentiondepthDimentions, 796), 99);
                                lstLblCoils[0].TabIndex = 0;
                                lstLblCoils[0].Tag = lstCubeDetail[i].dimentiondepthDimentions;
                                lstLblCoils[0].Text = "Ancho : " + lstCubeDetail[i].dimentiondepthDimentions.ToString() + "\n";
                                lstLblCoils[0].Text += "Std : " + lstCubeDetail[i].dimentionwidthDimentions + "\n";
                                lstLblCoils[0].Text += "Emb : " + lstCubeDetail[i].transcodeBoxing + "\n";
                                lstLblCoils[0].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            }
                            else
                            {
                                lstLblCoils.Add(new Label());
                                lstLblCoils[lstLblCoils.Count - 1].BackColor = clsGlobal.getColorByPosition(j + i, 60);
                                lstLblCoils[lstLblCoils.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoils[lstLblCoils.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoils[lstLblCoils.Count - 1].Location = new System.Drawing.Point(1, 1);
                                lstLblCoils[lstLblCoils.Count - 1].Name = "lblCoil" + i.ToString() + " pos" + j.ToString();
                                lstLblCoils[lstLblCoils.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetail[i].dimentiondepthDimentions, 796), 99);
                                lstLblCoils[lstLblCoils.Count - 1].TabIndex = 0;
                                lstLblCoils[lstLblCoils.Count - 1].Tag = lstCubeDetail[i].dimentiondepthDimentions;
                                lstLblCoils[lstLblCoils.Count - 1].Text = "Ancho : " + lstCubeDetail[i].dimentiondepthDimentions.ToString() + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Std : " + lstCubeDetail[i].dimentionwidthDimentions + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].Text += "Emb : " + lstCubeDetail[i].transcodeBoxing + "\n";
                                lstLblCoils[lstLblCoils.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            }
                        }
                    }
                    else if (lstCubeDetail[i].dimentionwidthDimentions == 116)
                    {
                        for (int j = 0; j < lstCubeDetail[i].pallet; j++)
                        {
                            if (lstLblCoilsLabels.Count == 0)
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[0].BackColor = clsGlobal.getColorByPosition(j + i, 60);
                                lstLblCoilsLabels[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoilsLabels[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoilsLabels[0].Location = new System.Drawing.Point(1, 1);
                                lstLblCoilsLabels[0].Name = "lblCoil" + i.ToString() + " pos" + j.ToString();
                                lstLblCoilsLabels[0].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetail[i].dimentiondepthDimentions, 796), 148);
                                lstLblCoilsLabels[0].TabIndex = 0;
                                lstLblCoilsLabels[0].Tag = lstCubeDetail[i].dimentiondepthDimentions;
                                lstLblCoilsLabels[0].Text = "Ancho : " + lstCubeDetail[i].dimentiondepthDimentions.ToString() + "\n";
                                lstLblCoilsLabels[0].Text += "Std : " + lstCubeDetail[i].dimentionwidthDimentions + "\n";
                                lstLblCoilsLabels[0].Text += "Emb : " + lstCubeDetail[i].transcodeBoxing + "\n";
                                lstLblCoilsLabels[0].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            }
                            else
                            {
                                lstLblCoilsLabels.Add(new Label());
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].BackColor = clsGlobal.getColorByPosition(j + i, 60);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Location = new System.Drawing.Point(1, 1);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Name = "lblCoil0";
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, lstCubeDetail[i].dimentiondepthDimentions, 796), 148);
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].TabIndex = lstCubeDetail[i].dimentiondepthDimentions;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Tag = lstCubeDetail[i].dimentiondepthDimentions;
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Text = "Ancho : " + lstCubeDetail[i].dimentiondepthDimentions.ToString() + "\n";
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Text += "Std : " + lstCubeDetail[i].dimentionwidthDimentions + "\n";
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].Text += "Emb : " + lstCubeDetail[i].transcodeBoxing + "\n";
                                lstLblCoilsLabels[lstLblCoilsLabels.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoils[i - 3].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 2);
                                }
                                lblContainer.Controls.Add(lstLblCoils[i]);
                                pos = true;
                            }
                            else
                            {
                                if (pos)
                                    relativePositionY = 102;
                                else
                                    relativePositionY = 202;

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
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
                else if(lstLblCoilsLabels.Count > 0)
                {
                    for (int i = 0; i < lstLblCoilsLabels.Count; i++)
                    {
                        if (i == 0)
                        {
                            lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                            lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 152);
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                            else
                            {
                                lastpositionX = lstLblCoilsLabels[i].Size.Width;
                                lastpositionY = lstLblCoilsLabels[i - 2].Size.Width;
                                if (lastpositionX == lastpositionY)
                                {
                                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i].Tag.ToString()), 796) + 1;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                }
                                else
                                {
                                    poscube = clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(lstLblCoilsLabels[i - 2].Tag.ToString()), 796) + 1;
                                    relativePosition += poscube;
                                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 2);
                                }
                                lblContainer.Controls.Add(lstLblCoilsLabels[i]);
                            }
                        }
                    }
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmCubeReport winReport = new frmCubeReport(codsec);
            winReport.StartPosition = FormStartPosition.CenterScreen;
            winReport.Show(this);
        }
    }
}
