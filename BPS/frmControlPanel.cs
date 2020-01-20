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
    public partial class frmControlPanel : Form
    {
        #region parametros
        private DataSet BKDia;
        private DataSet GBLDia;
        private DataSet GVDia;
        private DataSet CADia;
        private DataSet CTDia;
        private DataSet BKNoche;
        private DataSet GBLNoche;
        private DataSet GVNoche;
        private DataSet CANoche;
        private DataSet CTNoche;
        private DataSet RolDeTurnoA;
        private DataSet RolDeTurnoB;
        private DataSet RolDeTurnoC;
        private double totDBK=0;
        private double totDGBL = 0;
        private double totDGV = 0;
        private double totDCA = 0;
        private double totDCT = 0;
        private double totNBK = 0;
        private double totNGBL = 0;
        private double totNGV = 0;
        private double totNCA = 0;
        private double totNCT = 0;
        private clsBonus bonus = new clsBonus();
        private List<clsBonusDetail> detail = new List<clsBonusDetail>();
        private List<clsBonusParameters> parameters = new List<clsBonusParameters>();
        #endregion

        public frmControlPanel()
        {
            InitializeComponent();
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            for(int i=0;i<cmbYear.Items.Count;i++)
            {
                if(Convert.ToInt32(cmbYear.Items[i])==DateTime.Now.Year)
                {
                    cmbYear.SelectedIndex = i;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedIndex!=-1 && cmbYear.SelectedIndex!=-1)
            {
                string query = "spRolDiaExtrusion " + (cmbMonth.SelectedIndex+1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                BKDia = clsConnection.getDataSetResult(query);

                query = "spRolDiaCortePrimario " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                GBLDia = clsConnection.getDataSetResult(query);

                query = "spRolDiaMetalizado " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                GVDia = clsConnection.getDataSetResult(query);

                query = "spRolDiaCorteAtlas " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                CADia = clsConnection.getDataSetResult(query);

                query = "spRolDiaCorteTitan " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                CTDia = clsConnection.getDataSetResult(query);

                query = "spRolNocheExtrusion " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                BKNoche = clsConnection.getDataSetResult(query);

                query = "spRolNocheCortePrimario " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                GBLNoche = clsConnection.getDataSetResult(query);

                query = "spRolNocheMetalizado " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                GVNoche = clsConnection.getDataSetResult(query);

                query = "spRolNocheCorteAtlas " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                CANoche = clsConnection.getDataSetResult(query);

                query = "spRolNocheCorteTitan " + (cmbMonth.SelectedIndex + 1).ToString() + ", " + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                CTNoche = clsConnection.getDataSetResult(query);

                query = "SELECT * FROM bps_admin_turnrole WHERE tr_month=" + (cmbMonth.SelectedIndex + 1).ToString() + " AND tr_year=" + cmbYear.Items[cmbYear.SelectedIndex].ToString() + " AND tr_turn='A'";
                RolDeTurnoA = clsConnection.getDataSetResult(query);

                query = "SELECT * FROM bps_admin_turnrole WHERE tr_month=" + (cmbMonth.SelectedIndex + 1).ToString() + " AND tr_year=" + cmbYear.Items[cmbYear.SelectedIndex].ToString() + " AND tr_turn='B'";
                RolDeTurnoB = clsConnection.getDataSetResult(query);

                query = "SELECT * FROM bps_admin_turnrole WHERE tr_month=" + (cmbMonth.SelectedIndex + 1).ToString() + " AND tr_year=" + cmbYear.Items[cmbYear.SelectedIndex].ToString() + " AND tr_turn='C'";
                RolDeTurnoC = clsConnection.getDataSetResult(query);

                obtenerParametros();
                completarDatos();
            }
        }

        private void obtenerParametros()
        {
            bonus = new clsBonus(1);
            detail = bonus.getDetail();
        }

        private void completarDatos()
        {
            limpiar();

            #region bkdia
            if (BKDia.Tables.Count > 0 && BKDia.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < BKDia.Tables[0].Rows.Count; i++)
                {

                    totDBK += Math.Round(Convert.ToDouble(BKDia.Tables[0].Rows[i]["peso"]),1);

                    Control[] controldia = this.Controls.Find("txtDBK" + BKDia.Tables[0].Rows[i]["dia"], true);
                    if (controldia.Length > 0)
                    {
                        controldia[0].Text = Math.Round(Convert.ToDouble(BKDia.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region bknoche
            if (BKNoche.Tables.Count > 0 && BKNoche.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < BKNoche.Tables[0].Rows.Count; i++)
                {

                    totNBK += Math.Round(Convert.ToDouble(BKNoche.Tables[0].Rows[i]["peso"]),1);

                    Control[] controlnoche = this.Controls.Find("txtNBK" + BKNoche.Tables[0].Rows[i]["dia"], true);
                    if (controlnoche.Length > 0)
                    {
                        controlnoche[0].Text = Math.Round(Convert.ToDouble(BKNoche.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region gbldia
            if (GBLDia.Tables.Count > 0 && GBLDia.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < GBLDia.Tables[0].Rows.Count; i++)
                {

                    totDGBL += Math.Round(Convert.ToDouble(GBLDia.Tables[0].Rows[i]["peso"]),1);

                    Control[] controldia = this.Controls.Find("txtDGBL" + GBLDia.Tables[0].Rows[i]["dia"], true);
                    if (controldia.Length > 0)
                    {
                        controldia[0].Text = Math.Round(Convert.ToDouble(GBLDia.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region gblnoche
            if (GBLNoche.Tables.Count > 0 && GBLNoche.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < GBLNoche.Tables[0].Rows.Count; i++)
                {

                    totNGBL += Math.Round(Convert.ToDouble(GBLNoche.Tables[0].Rows[i]["peso"]),1);

                    Control[] controlnoche = this.Controls.Find("txtNGBL" + GBLNoche.Tables[0].Rows[i]["dia"], true);
                    if (controlnoche.Length > 0)
                    {
                        controlnoche[0].Text = Math.Round(Convert.ToDouble(GBLNoche.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region gvdia
            if (GVDia.Tables.Count > 0 && GVDia.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < GVDia.Tables[0].Rows.Count; i++)
                {

                    totDGV += Math.Round(Convert.ToDouble(GVDia.Tables[0].Rows[i]["peso"]),1);

                    Control[] controldia = this.Controls.Find("txtDGV" + GVDia.Tables[0].Rows[i]["dia"], true);
                    if (controldia.Length > 0)
                    {
                        controldia[0].Text = Math.Round(Convert.ToDouble(GVDia.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region gvnoche
            if (GVNoche.Tables.Count > 0 && GVNoche.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < GVNoche.Tables[0].Rows.Count; i++)
                {

                    totNGV += Math.Round(Convert.ToDouble(GVNoche.Tables[0].Rows[i]["peso"]),1);

                    Control[] controlnoche = this.Controls.Find("txtNGV" + GVNoche.Tables[0].Rows[i]["dia"], true);
                    if (controlnoche.Length > 0)
                    {
                        controlnoche[0].Text = Math.Round(Convert.ToDouble(GVNoche.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region cadia
            if (CADia.Tables.Count > 0 && CADia.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < CADia.Tables[0].Rows.Count; i++)
                {

                    totDCA += Math.Round(Convert.ToDouble(CADia.Tables[0].Rows[i]["peso"]),1);

                    Control[] controldia = this.Controls.Find("txtDCA" + CADia.Tables[0].Rows[i]["dia"], true);
                    if (controldia.Length > 0)
                    {
                        controldia[0].Text = Math.Round(Convert.ToDouble(CADia.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region canoche
            if (CANoche.Tables.Count > 0 && CANoche.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < CANoche.Tables[0].Rows.Count; i++)
                {

                    totNCA += Math.Round(Convert.ToDouble(CANoche.Tables[0].Rows[i]["peso"]),1);

                    Control[] controlnoche = this.Controls.Find("txtNCA" + CANoche.Tables[0].Rows[i]["dia"], true);
                    if (controlnoche.Length > 0)
                    {
                        controlnoche[0].Text = Math.Round(Convert.ToDouble(CANoche.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region ctdia
            if (CTDia.Tables.Count > 0 && CTDia.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < CTDia.Tables[0].Rows.Count; i++)
                {

                    totDCT += Math.Round(Convert.ToDouble(CTDia.Tables[0].Rows[i]["peso"]),1);

                    Control[] controldia = this.Controls.Find("txtDCT" + CTDia.Tables[0].Rows[i]["dia"], true);
                    if (controldia.Length > 0)
                    {
                        controldia[0].Text = Math.Round(Convert.ToDouble(CTDia.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region ctnoche
            if (CTNoche.Tables.Count > 0 && CTNoche.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < CTNoche.Tables[0].Rows.Count; i++)
                {

                    totNCT += Math.Round(Convert.ToDouble(CTNoche.Tables[0].Rows[i]["peso"]),1);

                    Control[] controlnoche = this.Controls.Find("txtNCT" + CTNoche.Tables[0].Rows[i]["dia"], true);
                    if (controlnoche.Length > 0)
                    {
                        controlnoche[0].Text = Math.Round(Convert.ToDouble(CTNoche.Tables[0].Rows[i]["peso"]),1).ToString();
                    }
                }
            }
            #endregion

            #region totales
            txtDBKTot.Text = totDBK.ToString();
            txtDGBLTot.Text = totDGBL.ToString();
            txtDGVTot.Text = totDGV.ToString();
            txtDCATot.Text = totDCA.ToString();
            txtDCTTot.Text = totDCT.ToString();
            txtDSUBTot.Text = (totDBK + totDGBL + totDGV + totDCA + totDCT).ToString();
            txtNBKTot.Text = totNBK.ToString();
            txtNGBLTot.Text = totNGBL.ToString();
            txtNGVTot.Text = totNGV.ToString();
            txtNCATot.Text = totNCA.ToString();
            txtNCTTot.Text = totNCT.ToString();
            txtNSUBTot.Text = (totNBK + totNGBL + totNGV + totNCA + totNCT).ToString();
            txtTotTot.Text = ((totDBK + totDGBL + totDGV + totDCA + totDCT) + (totNBK + totNGBL + totNGV + totNCA + totNCT)).ToString();

            double result = 0;
            for (int i = 1; i < 32; i++)
            {
                result = 0;
                Control[] control = this.Controls.Find("txtDBK" + i.ToString(), true);
                if (control.Length > 0)
                {
                    if (control[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(control[0].Text);
                    }
                }

                control = this.Controls.Find("txtDGBL" + i.ToString(), true);
                if (control.Length > 0)
                {
                    if (control[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(control[0].Text);
                    }
                }

                control = this.Controls.Find("txtDGV" + i.ToString(), true);
                if (control.Length > 0)
                {
                    if (control[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(control[0].Text);
                    }
                }

                control = this.Controls.Find("txtDCA" + i.ToString(), true);
                if (control.Length > 0)
                {
                    if (control[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(control[0].Text);
                    }
                }

                control = this.Controls.Find("txtDCT" + i.ToString(), true);
                if (control.Length > 0)
                {
                    if (control[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(control[0].Text);
                    }
                }

                control = this.Controls.Find("txtDSUB" + i.ToString(), true);
                if (control.Length > 0)
                {
                    control[0].Text = result.ToString();
                }

                result = 0;
                Control[] controln = this.Controls.Find("txtNBK" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    if (controln[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(controln[0].Text);
                    }
                }

                controln = this.Controls.Find("txtNGBL" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    if (controln[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(controln[0].Text);
                    }
                }

                controln = this.Controls.Find("txtNGV" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    if (controln[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(controln[0].Text);
                    }
                }

                controln = this.Controls.Find("txtNCA" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    if (controln[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(controln[0].Text);
                    }
                }

                controln = this.Controls.Find("txtNCT" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    if (controln[0].Text != string.Empty)
                    {
                        result += Convert.ToDouble(controln[0].Text);
                    }
                }

                controln = this.Controls.Find("txtNSUB" + i.ToString(), true);
                if (controln.Length > 0)
                {
                    controln[0].Text = result.ToString();
                }

                result = 0;
                control = this.Controls.Find("txtDSUB" + i.ToString(), true);
                if (control.Length > 0)
                {
                    result += Convert.ToDouble(control[0].Text);
                }
                control = this.Controls.Find("txtNSUB" + i.ToString(), true);
                if (control.Length > 0)
                {
                    result += Convert.ToDouble(control[0].Text);
                }
                control = this.Controls.Find("txtTOT" + i.ToString(), true);
                if (control.Length > 0)
                {
                    control[0].Text = result.ToString();
                }
            }


            #endregion

            #region turnoa
            if(RolDeTurnoA.Tables.Count>0 && RolDeTurnoA.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<RolDeTurnoA.Tables[0].Rows.Count;i++)
                {
                    switch (RolDeTurnoA.Tables[0].Rows[i]["tr_role"].ToString())
                    {
                        case "D":
                            Control[] controla = this.Controls.Find("txtABKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controld = this.Controls.Find("txtDBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if(controld[0].Text!=string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtAGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtAGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtACA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtACT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtASUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                controla[0].Text = controld[0].Text;
                            }

                            break;

                        case "N":
                            Control[] controla2 = this.Controls.Find("txtABKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controln = this.Controls.Find("txtNBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtAGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtAGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtACA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtACT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtASUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                controla2[0].Text = controln[0].Text;
                            }

                            break;
                    }            
                }
            }
            #endregion

            #region turnob
            if (RolDeTurnoB.Tables.Count > 0 && RolDeTurnoB.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < RolDeTurnoB.Tables[0].Rows.Count; i++)
                {
                    switch (RolDeTurnoB.Tables[0].Rows[i]["tr_role"].ToString())
                    {
                        case "D":
                            Control[] controla = this.Controls.Find("txtBBKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controld = this.Controls.Find("txtDBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text!=string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtBGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtBGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtBCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtBCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtBSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                controla[0].Text = controld[0].Text;
                            }

                            break;

                        case "N":
                            Control[] controla2 = this.Controls.Find("txtBBKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controln = this.Controls.Find("txtNBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text!=string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtBGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtBGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtBCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtBCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtBSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                controla2[0].Text = controln[0].Text;
                            }

                            break;
                    }
                }
            }
            #endregion

            #region turnoc
            if (RolDeTurnoC.Tables.Count > 0 && RolDeTurnoC.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < RolDeTurnoC.Tables[0].Rows.Count; i++)
                {
                    switch (RolDeTurnoC.Tables[0].Rows[i]["tr_role"].ToString())
                    {
                        case "D":
                            Control[] controla = this.Controls.Find("txtCBKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controld = this.Controls.Find("txtDBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text!=string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtCGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtCGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtCCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtCCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                if (controld[0].Text != string.Empty)
                                {
                                    controla[0].Text = controld[0].Text;
                                }
                                else
                                {
                                    controla[0].Text = "0";
                                }
                                controla[0].BackColor = Color.White;
                            }

                            controla = this.Controls.Find("txtCSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controld = this.Controls.Find("txtDSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla.Length > 0 && controld.Length > 0)
                            {
                                controla[0].Text = controld[0].Text;
                            }

                            break;

                        case "N":
                            Control[] controla2 = this.Controls.Find("txtCBKN" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            Control[] controln = this.Controls.Find("txtNBK" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text!=string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtCGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGBL" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtCGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNGV" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtCCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCA" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtCCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNCT" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                if (controln[0].Text != string.Empty)
                                {
                                    controla2[0].Text = controln[0].Text;
                                }
                                else
                                {
                                    controla2[0].Text = "0";
                                }
                                controla2[0].BackColor = Color.LightSteelBlue;
                            }

                            controla2 = this.Controls.Find("txtCSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            controln = this.Controls.Find("txtNSUB" + RolDeTurnoA.Tables[0].Rows[i]["tr_day"], true);
                            if (controla2.Length > 0 && controln.Length > 0)
                            {
                                controla2[0].Text = controln[0].Text;
                            }

                            break;
                    }
                }
            }
            #endregion

            #region parametrosBonus
            txtBonus.Text = bonus.reward.ToString();
            for(int i=0;i<detail.Count;i++)
            {
                dgvBonusDetail.Rows.Add();
                dgvBonusDetail.Rows[dgvBonusDetail.Rows.Count - 1].Cells[bnd_codsec.Index].Value = detail[i].codsec;
                dgvBonusDetail.Rows[dgvBonusDetail.Rows.Count - 1].Cells[bnd_fkBonus.Index].Value = detail[i].fkBonus;
                dgvBonusDetail.Rows[dgvBonusDetail.Rows.Count - 1].Cells[bnd_parameterName.Index].Value = detail[i].parameterName;
                dgvBonusDetail.Rows[dgvBonusDetail.Rows.Count - 1].Cells[bnd_percentage.Index].Value = detail[i].percentage*100;
                dgvBonusDetail.Rows[dgvBonusDetail.Rows.Count - 1].Cells[Valor.Index].Value = detail[i].percentage*bonus.reward;
                cmbParameters.Items.Add(detail[i].parameterName);
            }
            #endregion
        }

        private void limpiar()
        {
            Control[] control;
            for (int i = 1; i < 32;i++)
            {
                control = this.Controls.Find("txtDBK" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtDGBL" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtDGV" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtDCA" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtDCT" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtDSUB" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNBK" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNGBL" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNGV" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNCA" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNCT" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtNSUB" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtABKN" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtAGBL" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtAGV" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtACA" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtACT" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtASUB" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtBBKN" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtBGBL" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtBGV" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtBCA" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtBCT" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtBSUB" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }

                control = this.Controls.Find("txtCBKN" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtCGBL" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtCGV" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtCCA" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtCCT" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                    control[0].BackColor = Color.LightGray;
                }

                control = this.Controls.Find("txtCSUB" + i.ToString(), true);

                if (control.Length > 0)
                {
                    control[0].ResetText();
                }
            }
            txtDBKTot.ResetText();
            txtDGBLTot.ResetText();
            txtDGVTot.ResetText();
            txtDCATot.ResetText();
            txtDCTTot.ResetText();
            txtDSUBTot.ResetText();
            totDBK = 0;
            totDGBL = 0;
            totDGV = 0;
            totDCA = 0;
            totDCT = 0;
            txtNSUBTot.ResetText();
            totNBK = 0;
            totNGBL = 0;
            totNGV = 0;
            totNCA = 0;
            totNCT = 0;

            dgvBonusDetail.Rows.Clear();
            txtBonus.ResetText();
            cmbParameters.Items.Clear();
            cmbParameters.ResetText();
            cmbParameters.SelectedIndex = -1;
            dgvParameterDetails.Rows.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmbParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbParameters.SelectedIndex!=-1)
            {
                parameters=detail[cmbParameters.SelectedIndex].getParameters();

                for(int i=0;i<parameters.Count;i++)
                {
                    dgvParameterDetails.Rows.Add();
                    dgvParameterDetails.Rows[dgvParameterDetails.Rows.Count - 1].Cells[bnp_codsec.Index].Value = parameters[i].codsec;
                    dgvParameterDetails.Rows[dgvParameterDetails.Rows.Count - 1].Cells[bnp_fkBonusDetail.Index].Value = parameters[i].fkBonusDetail;
                    dgvParameterDetails.Rows[dgvParameterDetails.Rows.Count - 1].Cells[bnp_inferiorLimit.Index].Value = parameters[i].inferiorLimit;
                    dgvParameterDetails.Rows[dgvParameterDetails.Rows.Count - 1].Cells[bnp_superiorLimit.Index].Value = parameters[i].superiorLimit;
                    dgvParameterDetails.Rows[dgvParameterDetails.Rows.Count - 1].Cells[bnp_percentage.Index].Value = parameters[i].percentage;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
