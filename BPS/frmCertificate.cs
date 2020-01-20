using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Certificate.Report;

namespace BPS
{
    public partial class frmCertificate : Form
    {
        List<clsCertificate> cerList = new List<clsCertificate>();
        clsCertificate ObjCertificate = new clsCertificate();
        string myfilmname = string.Empty;
        string mypanelname = string.Empty;

        private void ClearData()
        {
            txtmaxthickness.Clear();
            txtminthickness.Clear();
            txtaveragethickness.Clear();
            lblparametersthickness.Text = string.Empty;
            txtmaxunit.Text = "";
            txtminunit.Text = "";
            txtaverageunit.Text = "";
            textBox10.Clear();
            textBox11.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            lblDate.Text = string.Empty;
            txtWidth.Clear();
            //txtDescription.Clear();
            lblFilm.Text = string.Empty;
            lblMainCoil.Text = string.Empty;
            lblExtruderDate.Text = string.Empty;
        }

        public frmCertificate()
        {
            InitializeComponent();
        }

        private void txtpreshipping_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter)
                PopulateHeadCertificate(txtpreshipping.Text);
        }

        private void PopulateHeadCertificate(string preshipping)
        {
            cerList = clsCertificate.getListByPreShippingNumber(preshipping);
            clearHeader();

            if (cerList.Count > 0)
            {
                var customer = cerList.Select(cus => cus.Company).Distinct().OrderBy(x => x).ToList();
                var orderNumber = cerList.Select(ord => ord.OrderNumber).Distinct().OrderBy(x => x).ToList();
                var lotNumber = cerList.Select(lt => lt.LotNumber).Distinct().ToList().OrderBy(x => x).ToList();

                FillCMB(customer, orderNumber, lotNumber);
            }
            else
            {
                cerList = clsCertificate.getListByNewPreShippingNumber(preshipping);
                clearHeader();

                if (cerList.Count > 0)
                {
                    var customer = cerList.Select(cus => cus.Company).Distinct().OrderBy(x => x).ToList();
                    var orderNumber = cerList.Select(ord => ord.OrderNumber).Distinct().OrderBy(x => x).ToList();
                    var lotNumber = cerList.Select(lt => lt.LotNumber).Distinct().ToList().OrderBy(x => x).ToList();

                    FillCMB(customer, orderNumber, lotNumber);
                }
                else
                {
                    MessageBox.Show("El pre-despacho ingresado no corresponde a ninguno pre-despacho registrado por favor vuelva a ingresar los datos ", "Certificado de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    clearFooter();
                }
                
            }
        }

        private void clearFooter()
        {
            txtpreshipping.Clear();
            txtpreshipping.Focus();
            lblExtruderDate.Text = string.Empty;
            lblFilm.Text = string.Empty;
            lblMainCoil.Text = string.Empty;
            lblDate.Text = string.Empty;
            txtWidth.Clear();
            cmbEntity.Text = string.Empty;
            cmbLot.Text = string.Empty;
            cmbOrder.Text = string.Empty;
            cmbEntity.SelectedItem = -1;
            cmbLot.SelectedItem = -1;
            cmbOrder.SelectedItem = -1;
            cmbEntity.SelectedIndex = -1;
            cmbLot.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbEntity.SelectedText = string.Empty;
            cmbLot.SelectedText = string.Empty;
            cmbOrder.SelectedText = string.Empty;
            HideAllPanel();
        }

        private void FillCMB(List<string> customer, List<string> orderNumber, List<string> lotNumber)
        {
            foreach (var item in customer)
            {
                cmbEntity.Items.Add(item);
            }
            foreach (var item in orderNumber)
            {
                cmbOrder.Items.Add(item);
            }
            foreach (var item in lotNumber)
            {
                cmbLot.Items.Add(item);
            }

            HideAllPanel();
        }

        private void clearHeader()
        {
            cmbOrder.Items.Clear();
            cmbEntity.Items.Clear();
            cmbLot.Items.Clear();
            cmbEntity.SelectedText = string.Empty;
            cmbLot.SelectedText = string.Empty;
            cmbOrder.SelectedText = string.Empty;
            cmbEntity.Text = string.Empty;
            cmbLot.Text = string.Empty;
            cmbOrder.Text = string.Empty;
        }

        private void HideAllPanel()
        {
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                if (groupBox.Name == "groupBox1")
                {
                    foreach (var panel in groupBox.Controls.OfType<Panel>())
                    {
                        // Do Something
                        panel.Hide();
                    }
                }
            }
        }

        private void cmbLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLot.SelectedIndex > -1)
            {
                lblExtruderDate.Text = clsCertificate.getExtruderDateByLotNumber(cmbLot.SelectedItem.ToString());
                var hList = clsCertificate.getRangeOfMainCoilByLotNumber(cmbLot.SelectedItem.ToString());
                lblFilm.Text = hList[1].ToString();
                lblMainCoil.Text = hList[0].ToString();
                //txtDescription.Text = string.Empty;
                lblDate.Text = DateTime.Now.Date.ToShortDateString();
                LoadPanel(hList[1].ToString());
            }
        }

        private void LoadPanel(string filmname)
        {
            /*if (filmname.StartsWith("SC"))
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlSC.Show();
                pnlSC.BringToFront();
                PopulatePanel(this.pnlSC);
            }*/
            if (filmname == "BC020TT" || filmname == "BC017TT" || filmname == "SC020TT" || filmname == "SC030TT" || filmname == "SC017TT" || filmname == "BL020TT" || filmname == "SCF020TT" || filmname == "SCF030TT" || filmname == "BC050TT")
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlSCTT.Show();
                pnlSCTT.BringToFront();
                PopulatePanel(this.pnlSCTT, filmname);
            }

            if (filmname.StartsWith("SD") || filmname == "BD020" || filmname == "BD017") 
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlSD.Show();
                pnlSD.BringToFront();
                PopulatePanel(this.pnlSD, filmname);
            }
            /*if (filmname.StartsWith("PC") || filmname.StartsWith("OC") || filmname.StartsWith("VC"))
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlPC.Show();
                pnlPC.BringToFront();
                PopulatePanel(this.pnlPC);
            }*/
            if (filmname == "BD017TT" || filmname == "BD020TT" || filmname == "ODE060TT")
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlPCX.Show();
                pnlPCX.BringToFront();
                PopulatePanel(this.pnlPCX, filmname);
            }
            else if (filmname.StartsWith("WC")
                || (filmname == "SC017" || filmname == "SC020" || filmname == "SC025" || filmname == "SC030" || filmname == "SC035" || filmname == "SC040" || filmname == "SC050")
                || filmname.StartsWith("PC") || filmname.StartsWith("PCx") || filmname.StartsWith("VCx") || filmname.StartsWith("VC")
                || (filmname == "BC017" || filmname == "BC020" || filmname == "BC025" || filmname == "BC030" || filmname == "BC045" || filmname == "BC050")
                || filmname.StartsWith("PGBT")
                || (filmname == "BL017" || filmname == "BL020" || filmname == "BL025" || filmname == "BL030" || filmname == "BL035")
                || (filmname == "BCB020")
                || (filmname == "BCM020" || filmname == "BCM025")
                || filmname.StartsWith("BF")
                || (filmname == "BMBTF017") || (filmname == "BMBTF020")) // se agrego esto, a pedido de Bruno. 
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlWC.Show();
                pnlWC.BringToFront();
                PopulatePanel(this.pnlWC, filmname);
            }
            else if (filmname == "NH017TT" || filmname == "NH020TT")
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlMCD.Show();
                pnlMCD.BringToFront();
                PopulatePanel(this.pnlMCD, filmname);
            }
            /*f (filmname.StartsWith("TH"))
             {
                 myfilmname = filmname;
                 HideAllPanel();
                 pnlTH.Show();
                 pnlTH.BringToFront();
                 PopulatePanel(this.pnlTH);
             }*/
            else if (filmname == "LH020TT" || filmname == "TH022TT")
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlLHTT.Show();
                pnlLHTT.BringToFront();
                PopulatePanel(this.pnlLHTT, filmname);
            }
            else if ((filmname == "LH017" || filmname == "LH020" || filmname == "LH022" || filmname == "LH030")
                || (filmname == "TH022" || filmname == "TH025" || filmname == "TH030"))
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlLH.Show();
                pnlLH.BringToFront();
                PopulatePanel(this.pnlLH, filmname);
            }
            else if ((filmname == "MC017" || filmname == "MC020" || filmname == "MC025" || filmname == "MC030" || filmname == "MC045" || filmname == "MC017")
                || (filmname == "ML017" || filmname == "ML020" || filmname == "ML025" || filmname == "ML030" || filmname == "ML035") || (filmname == "NF020" || filmname == "MC020TT" || filmname == "NH017TT"))
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlMC.Show();
                pnlMC.BringToFront();
                PopulatePanel(this.pnlMC, filmname);
            }
            else if ((filmname == "MC017TT")
                || (filmname == "ML020TT"))
            {
                myfilmname = filmname;
                HideAllPanel();
                pnlMCTT.Show();
                pnlMCTT.BringToFront();
                PopulatePanel(this.pnlMCTT, filmname);
            }

        }

        private void PopulatePanel(Panel panel, string filmname)
        {
            try
            {

                #region SC

                if (panel.Name == "pnlSC")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        txtmaxunit.Text = lstUnit[0].ToString();
                        txtminunit.Text = lstUnit[1].ToString();
                        txtaverageunit.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 2).ToString();
                        lblparameterunit.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    //List<double> lstOpaTra = new List<double>();
                    //lstOpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    //if (lstOpaTra.Count > 0)
                    //{
                    //txtmaxopacity.Text = lstOpaTra[0].ToString();
                    //txtminopacity.Text = lstOpaTra[1].ToString();
                    //txtaverageopacity.Text = Math.Round(Convert.ToDouble(lstOpaTra[2].ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                    lblparameteropacity.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;
                    //}

                    //Tension
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        txtaveragetension.Text = "40";
                        lblparameterstension.Text = "Min " + lstTension[1].ToString();
                    }

                    //SealCT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        txtaveragesealct.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        lblparametersealct.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        txtaverageforcect.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 3).ToString();
                        lblparametersforcect.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstSealCNT.Count > 0)
                    {
                        txtaveragesealcnt.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 0))).ToString();
                        lblparametersealcnt.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCNT
                    List<double> lstForceCNT = new List<double>();
                    lstForceCNT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstForceCNT.Count > 0)
                    {
                        txtaverageforcecnt.Text = Math.Round(Convert.ToDouble(lstForceCNT[1].ToString()), 3).ToString();
                        lblparametersforcecnt.Text = "Min " + lstForceCNT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        txtaveragecof.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 3).ToString();
                        lblparameterscof.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }

                #endregion

                #region SD
                else if (panel.Name == "pnlSD")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    //Thickness (GRAMAJE)
                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        textBox10.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label54.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance (HAZE)
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox9.Text = Math.Round(OpaTra, 1).ToString();
                    label53.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;

                    //brightness (BRILLO CARA TRATADA)
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox15.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label67.Text = "Max " + lstAcep[0].brightness.ToString();

                    //Tension (Tension superficial Cara Brillante)
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox8.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label52.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCT (Temperatura inicial Sello (Cara Mate))
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox7.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        label41.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT (Fuerza de Sello (40 PSI, 0.5 a 140 C))
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox6.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 1).ToString();
                        label48.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //SealCNT Temperatura inicial Sello (Cara Brillante)
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox5.Text = (Convert.ToInt32(Math.Round(Convert.ToDouble(lstSealCNT[1].ToString()), 1))).ToString();
                        label51.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCNT Fuerza de Sello (40 PSI, 0.5 a 140 C)
                    List<double> lstForceCNT = new List<double>();
                    lstForceCNT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstForceCNT.Count > 0)
                    {
                        textBox4.Text = Math.Round(Convert.ToDouble(lstForceCNT[1].ToString()), 3).ToString();
                        label49.Text = "Min " + lstForceCNT[0].ToString();
                    }
                    //CofCNT Cof Dinamico (Cara mate/cara mate)
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox16.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label88.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }
                #endregion

                #region PC
                else if (panel.Name == "pnlPC")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        label137.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                        textBox32.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 2).ToString();
                        label128.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    {
                        textBox31.Text = Math.Round(OpaTra, 1).ToString();
                        label127.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].tratedList[1].ToString() : string.Empty;
                    }

                    //Tension
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox30.Text = "44";
                        label126.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox29.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        label109.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox28.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 3).ToString();
                        label110.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox27.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 0))).ToString();
                        label119.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCNT
                    List<double> lstForceCNT = new List<double>();
                    lstForceCNT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstForceCNT.Count > 0)
                    {
                        textBox20.Text = Math.Round(Convert.ToDouble(lstForceCNT[1].ToString()), 3).ToString();
                        label117.Text = "Min " + lstForceCNT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox19.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 3).ToString();
                        label118.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }
                #endregion

                #region PCX
                else if (panel.Name == "pnlPCX")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        label146.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                        textBox39.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 2).ToString();
                        label145.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    {
                        textBox38.Text = Math.Round(OpaTra, 1).ToString();
                        label144.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].tratedList[1].ToString() : string.Empty;
                    }

                    //brightness
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox17.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label93.Text = "Max " + lstAcep[0].brightness.ToString();

                    //Tension 
                    List<double> lstTension = new List<double>();
                    //cara Interna Cara Brillante
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox37.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label143.Text = "Min " + lstAcep[0].tensionciList[0].ToString();
                    }
                    //cara Externa Cara Mate
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox18.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label96.Text = "Min " + lstAcep[0].tensionceList[0].ToString();
                    }
                    //Tension
                    /*
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox37.Text = "44";
                        label143.Text = "Min " + lstTension[0].ToString();
                    }*/

                    //SealCT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox36.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        label138.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox35.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 1).ToString();
                        label139.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox34.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 0))).ToString();
                        label142.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCNT
                    List<double> lstForceCNT = new List<double>();
                    lstForceCNT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstForceCNT.Count > 0)
                    {
                        textBox14.Text = Math.Round(Convert.ToDouble(lstForceCNT[1].ToString()), 3).ToString();
                        label140.Text = "Min " + lstForceCNT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox13.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 3).ToString();
                        label141.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }
                #endregion

                #region WC
                else if (panel.Name == "pnlWC")
                {

                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        label261.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                        textBox68.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label260.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox67.Text = Math.Round(OpaTra, 1).ToString();
                    if (filmname.StartsWith("SC") || filmname.StartsWith("PGBT") || filmname.StartsWith("BC") || filmname.StartsWith("BL"))

                        label259.Text = (lstAcep.Count > 0) ? "Max " + lstAcep[0].tratedList[0].ToString() : string.Empty;//1 por 0 para tomar el maximo en vez del min
                    else
                        label259.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].tratedList[1].ToString() : string.Empty;//1 por 0 para tomar el maximo en vez del min

                    //brightness
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox1.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label57.Text = "Min " + lstAcep[0].brightness.ToString();

                    //Tension
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox66.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label252.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox59.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        label241.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox64.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 1).ToString();
                        label242.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox65.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 0))).ToString();
                        label251.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCNT
                    List<double> lstForceCNT = new List<double>();
                    lstForceCNT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "-----");
                    if (lstForceCNT.Count > 0)
                    {
                        textBox58.Text = Math.Round(Convert.ToDouble(lstForceCNT[1].ToString()), 1).ToString();
                        label243.Text = "Min " + lstForceCNT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox56.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label250.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }
                #endregion

                #region MCD
                else if (panel.Name == "pnlMCD")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        textBox82.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label325.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label326.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //density Optic
                    List<double> lstOpaTra = new List<double>();
                    lstOpaTra = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Density");
                    if (lstOpaTra.Count > 0)
                    {
                        textBox81.Text = Math.Round(Convert.ToDouble(lstOpaTra[2].ToString()), 1).ToString();
                        label314.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;
                    }

                    //Tension Superficial CI
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox80.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label313.Text = "Min " + lstTension[0].ToString();
                    }

                    //Tension Superficial CE
                    List<double> lstTensionCE = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    {
                        textBox79.Text = Math.Round(Convert.ToDouble(lstTensionCE[1].ToString()), 0).ToString();
                        label296.Text = "Min " + lstTensionCE[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox73.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 1))).ToString();
                        label305.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox71.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label304.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }
                #endregion

                #region MC
                else if (panel.Name == "pnlMC")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    //Espesor
                    double Thickness = 0;
                    Thickness = clsCertificate.getThicknessAverageByLotNumberMetal(cmbLot.SelectedItem.ToString());
                    textBox25.Text = Math.Round(Convert.ToDouble(Thickness), 1).ToString();

                    //gramaje
                    List<double> lstUnit = new List<double>();
                    //lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    lstUnit = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Unit");
                    if (lstUnit.Count > 0)
                    {
                        textBox24.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label102.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label103.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //density Optic
                    List<double> lstOpaTra = new List<double>();
                    lstOpaTra = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Density");
                    if (lstOpaTra.Count > 0)
                    {
                        textBox23.Text = Math.Round(Convert.ToDouble(lstOpaTra[2].ToString()), 1).ToString();
                        label101.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;
                    }
                    //SealCNT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Seal");
                    if (lstSealCT.Count > 0)
                    {
                        textBox22.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 1))).ToString();
                        label100.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Cof");

                    if (lstCofCNT.Count > 0)
                    {
                        textBox21.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label99.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].cofdymanicList[1].ToString() + " - " + lstAcep[0].cofdymanicList[0].ToString() + ")" : string.Empty;
                        //label99.Text = "(" + lstCofCNT[1].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }

                #endregion

                #region MCTT
                else if (panel.Name == "pnlMCTT")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    //Espesor
                    double Thickness = 0;
                    Thickness = clsCertificate.getThicknessAverageByLotNumberMetal(cmbLot.SelectedItem.ToString());
                    textBox55.Text = Math.Round(Convert.ToDouble(Thickness), 1).ToString();

                    //gramaje
                    List<double> lstUnit = new List<double>();
                    //lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    lstUnit = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Unit");
                    if (lstUnit.Count > 0)
                    {
                        textBox54.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label249.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label253.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //density Optic
                    List<double> lstOpaTra = new List<double>();
                    lstOpaTra = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Density");
                    if (lstOpaTra.Count > 0)
                    {
                        textBox53.Text = Math.Round(Convert.ToDouble(lstOpaTra[2].ToString()), 1).ToString();
                        label248.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;
                    }

                    //Tension Superficial CNM
                    List<double> lstTensionCNM = new List<double>();
                    lstTensionCNM = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "TrataCI");
                    if (lstTensionCNM.Count > 0)
                    {
                        textBox49.Text = Math.Round(Convert.ToDouble(lstOpaTra[2].ToString()), 1).ToString();
                        label239.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].tensionciList[1].ToString() : string.Empty;
                    }

                    //Tension Superficial CM
                    List<double> lstTensionCM = new List<double>();
                    lstTensionCM = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "TrataCE");
                    if (lstTensionCM.Count > 0)
                    {
                        textBox52.Text = Math.Round(Convert.ToDouble(lstTensionCM[1].ToString()), 1).ToString();
                        label245.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].tensionceList[1].ToString() : string.Empty;
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Seal");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox51.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 1))).ToString();
                        //textBox22.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 1))).ToString();
                        //label100.Text = "Max " + lstSealCNT[0].ToString();
                        label247.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getMetalDataByLotNumber(cmbLot.SelectedItem.ToString(), "Cof");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox50.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        //textBox21.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label246.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].cofdymanicList[1].ToString() + " - " + lstAcep[0].cofdymanicList[0].ToString() + ")" : string.Empty;
                        //label99.Text = "(" + lstCofCNT[1].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                }

                #endregion

                #region TH
                if (panel.Name == "pnlTH")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        textBox107.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 2).ToString();
                        label359.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label364.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox105.Text = Math.Round(OpaTra, 2, MidpointRounding.AwayFromZero).ToString();
                    label358.Text = (lstAcep.Count > 0) ? "Min " + lstAcep[0].opacityList[1].ToString() : string.Empty;


                    //Tension
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox103.Text = "44";
                        label356.Text = "Min " + lstTension[0].ToString();
                    }
                }
                #endregion

                #region LH
                if (panel.Name == "pnlLH")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        textBox114.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label368.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label376.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox113.Text = Math.Round(OpaTra, 1).ToString();
                    label367.Text = (lstAcep.Count > 0) ? "Max " + lstAcep[0].opacityList[0].ToString() : string.Empty;//1 por 0 para traer el max


                    //Tension
                    List<double> lstTension = new List<double>();
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox112.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();
                        label365.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCT
                    List<double> lstSealCT = new List<double>();
                    lstSealCT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCT.Count > 0)
                    {
                        textBox97.Text = (Convert.ToInt32(Math.Round(lstSealCT[1], 0))).ToString();
                        label346.Text = "Max " + lstSealCT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox96.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 1).ToString();
                        label347.Text = "Min " + lstForceCT[0].ToString();
                    }

                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox87.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label350.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                    //brightness
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox2.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label58.Text = "Min " + lstAcep[0].brightness.ToString();

                }
                #endregion

                #region LHTT
                if (panel.Name == "pnlLHTT")
                {
                    mypanelname = panel.Name;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        textBox121.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        label394.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label395.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox120.Text = Math.Round(OpaTra, 1).ToString();
                    label387.Text = (lstAcep.Count > 0) ? "Max " + lstAcep[0].opacityList[0].ToString() : string.Empty;//1 por 0 para traer el max en vez del min


                    //Tension
                    List<double> lstTension = new List<double>();
                    //cara interna
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox85.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();

                        label378.Text = "Min " + lstTension[0].ToString();
                    }
                    //cara externa
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox118.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();

                        label349.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox116.Text = (Convert.ToInt32(Math.Round(lstSealCNT[1], 0))).ToString();
                        label385.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox94.Text = Math.Round(Convert.ToDouble(lstForceCT[1].ToString()), 3).ToString();
                        label377.Text = "Min " + lstForceCT[0].ToString();
                    }
                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox3.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label61.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }
                    //brightness
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox12.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label64.Text = "Min " + lstAcep[0].brightness.ToString();

                }
                #endregion

                #region SCTT
                if (panel.Name == "pnlSCTT")
                {
                    mypanelname = panel.Name;
                    double avrg = 0;
                    double total = 0;
                    int codsec = clsBopp.getFilmByCode(lblFilm.Text);
                    List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                    lstAcep = clsAceptationRange.getListByFilm(codsec);

                    List<double> lstUnit = new List<double>();
                    lstUnit = clsCertificate.getUniWeightByLotNumber(cmbLot.SelectedItem.ToString());
                    if (lstUnit.Count > 0)
                    {
                        for (int i = 0; i < lstUnit.Count; i++)
                        {
                            total += lstUnit[i];
                        }
                        avrg = total / lstUnit.Count;

                        //textBox47.Text = Math.Round(Convert.ToDouble(lstUnit[2].ToString()), 1).ToString();
                        textBox47.Text = Math.Round(avrg, 1).ToString();
                        label199.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].unitweightList[1].ToString() + " - " + lstAcep[0].unitweightList[0].ToString() + ")" : string.Empty;
                        label200.Text = (lstAcep.Count > 0) ? "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")" : string.Empty;
                    }

                    //opacity or trasnmitance
                    double OpaTra = 0;
                    OpaTra = clsCertificate.getOpacityOrTransmitanceByLotNumber(cmbLot.SelectedItem.ToString(), "Opacity");
                    textBox46.Text = Math.Round(OpaTra, 1).ToString();
                    label198.Text = (lstAcep.Count > 0) ? "Max " + lstAcep[0].opacityList[0].ToString() : string.Empty;//1 por 0 para traer el max en vez del min

                    //brightness
                    List<double> lstBrigth = new List<double>();
                    lstBrigth = clsCertificate.getBrightnessByLotNumber(cmbLot.SelectedItem.ToString());
                    textBox26.Text = Math.Round(Convert.ToDouble(lstBrigth[1].ToString()), 0).ToString();
                    label132.Text = "Min "+ lstAcep[0].brightness.ToString();


                    //Tension
                    List<double> lstTension = new List<double>();
                    //cara interna
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCI");
                    if (lstTension.Count > 0)
                    {
                        textBox42.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();

                        label192.Text = "Min " + lstTension[0].ToString();
                    }
                    //cara externa
                    lstTension = clsCertificate.getTensionByLotNumber(cmbLot.SelectedItem.ToString(), "TensionCE");
                    if (lstTension.Count > 0)
                    {
                        textBox45.Text = Math.Round(Convert.ToDouble(lstTension[1].ToString()), 0).ToString();

                        label195.Text = "Min " + lstTension[0].ToString();
                    }

                    //SealCNT
                    List<double> lstSealCNT = new List<double>();
                    lstSealCNT = clsCertificate.getSealByLotNumber(cmbLot.SelectedItem.ToString(), "SealCI");
                    if (lstSealCNT.Count > 0)
                    {
                        textBox44.Text = (Convert.ToDouble(Math.Round(lstSealCNT[1], 1))).ToString();
                        label197.Text = "Max " + lstSealCNT[0].ToString();
                    }

                    //ForceCT
                    List<double> lstForceCT = new List<double>();
                    lstForceCT = clsCertificate.getForceByLotNumber(cmbLot.SelectedItem.ToString(), "ForceCT");
                    if (lstForceCT.Count > 0)
                    {
                        textBox43.Text = Math.Round(Convert.ToDouble(lstForceCT[0].ToString()), 1).ToString();
                        label196.Text = "Min " + lstForceCT[0].ToString();
                    }
                    //CofCNT
                    List<double> lstCofCNT = new List<double>();
                    lstCofCNT = clsCertificate.getCofByLotNumber(cmbLot.SelectedItem.ToString(), "CofCNT");
                    if (lstCofCNT.Count > 0)
                    {
                        textBox41.Text = Math.Round(Convert.ToDouble(lstCofCNT[1].ToString()), 2).ToString();
                        label135.Text = "(" + lstCofCNT[2].ToString() + "-" + lstCofCNT[0].ToString() + ")";
                    }

                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Certificados de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLot.SelectedIndex > -1)
            {
                txtWidth.Text = clsCertificate.getWidthByOrderNumber(cmbOrder.SelectedItem.ToString(), txtpreshipping.Text);
                if(txtWidth.Text=="-----")
                {
                    txtWidth.Text = clsCertificate.getWidthByOrderNumberNewPD(cmbOrder.SelectedItem.ToString(), txtpreshipping.Text);
                }
            }
        }

        private void txtmaxunit_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            clsBopp ObjBopp = new clsBopp(codsec);
            txtmaxthickness.Text = Math.Round((Convert.ToDouble(txtmaxunit.Text) / ObjBopp.density), 1).ToString();
        }

        private void txtminunit_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            clsBopp ObjBopp = new clsBopp(codsec);
            txtminthickness.Text = Math.Round((Convert.ToDouble(txtminunit.Text) / ObjBopp.density), 1).ToString();
        }

        private void txtaverageunit_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    txtaveragethickness.Text = clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0").ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                txtaveragethickness.Text = "0";
            }
        }

        private void FillParametersThickness(int codsec, string panel)
        {
            if (panel == "pnlSC")
            {
                List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                lstAcep = clsAceptationRange.getListByFilm(codsec);
                lblparametersthickness.Text = "(" + lstAcep[1].thiknessList[0].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")";
            }
            else if (panel == "pnlSD")
            {
                List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                lstAcep = clsAceptationRange.getListByFilm(codsec);
                label55.Text = "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")";
            }
            else if (panel == "pnlMC")
            {
                List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                lstAcep = clsAceptationRange.getListByFilm(codsec);
                label103.Text = "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")";
            }

            else if (panel == "pnlSCTT")
            {
                List<clsAceptationRange> lstAcep = new List<clsAceptationRange>();
                lstAcep = clsAceptationRange.getListByFilm(codsec);
                label200.Text = "(" + lstAcep[0].thiknessList[1].ToString() + " - " + lstAcep[0].thiknessList[0].ToString() + ")";
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    ObjCertificate = new clsCertificate();
                    setThiknessValues("toSave", mypanelname);
                    setUnitValues("toSave", mypanelname);
                    setOpacityValues("toSave", mypanelname);
                    setTensionCI("toSave", mypanelname);
                    setTensionCE("toSave", mypanelname);
                    setSealCT("toSave", mypanelname);
                    setForceCT("toSave", mypanelname);
                    setSealCNT("toSave", mypanelname);
                    setForceCNT("toSave", mypanelname);
                    setCofCNT("toSave", mypanelname);
                    setBrightnessValues("toSave", mypanelname);
                    setOpticDensityValues("toSave", mypanelname);
                    ObjCertificate.Bopp = lblFilm.Text;
                    ObjCertificate.fkBopp = clsBopp.getFilmByCode(lblFilm.Text);
                    ObjCertificate.LotNumber = cmbLot.SelectedItem.ToString();
                    ObjCertificate.Company = cmbEntity.SelectedItem.ToString();
                    ObjCertificate.OrderNumber = cmbOrder.SelectedItem.ToString();
                    ObjCertificate.Width = txtWidth.Text;
                    ObjCertificate.FilmName = txtDescription.Text;
                    ObjCertificate.Maincoil = lblMainCoil.Text;
                    ObjCertificate.ExtruderDate = lblExtruderDate.Text;
                    ObjCertificate.createdDate = lblDate.Text;
                    ObjCertificate.notes = txtNotes.Text;
                    ObjCertificate.head = txtTitle.Text.ToUpper();

                    if (ObjCertificate.save())
                    {
                        MessageBox.Show("Certificado de Calidad Generado Correctamente", "Certificado de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*if (myfilmname.StartsWith("SC"))
                        {
                            frmCertificateSC winSC = new frmCertificateSC(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winSC.MdiParent = this.MdiParent;
                            winSC.StartPosition = FormStartPosition.CenterScreen;
                            winSC.Show();
                        }*/

                        if (myfilmname == "BC020TT" || myfilmname == "BC050TT" || myfilmname == "BC017TT" || myfilmname == "SC020TT" || myfilmname == "SC030TT" || myfilmname == "SC017TT" || myfilmname == "BL020TT" || myfilmname == "SCF020TT" || myfilmname == "SCF030TT")
                        {
                            frmCertificateSCTT winSC = new frmCertificateSCTT(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winSC.MdiParent = this.MdiParent;
                            winSC.StartPosition = FormStartPosition.CenterScreen;
                            winSC.Show();
                        }

                        if (myfilmname.StartsWith("SD0") || myfilmname == "BD020" || myfilmname == "BD017")
                        {
                            frmCertificateSD winSC = new frmCertificateSD(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winSC.MdiParent = this.MdiParent;
                            winSC.StartPosition = FormStartPosition.CenterScreen;
                            winSC.Show();
                        }

                        /*if (myfilmname.StartsWith("PC") || myfilmname.StartsWith("VC"))
                        {
                            frmCertificatePC winPC = new frmCertificatePC(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winPC.MdiParent = this.MdiParent;
                            winPC.StartPosition = FormStartPosition.CenterScreen;
                            winPC.Show();
                        }*/

                        if (myfilmname == "BD017TT" || myfilmname == "BD020TT" || myfilmname == "ODE060TT")//BDTT
                        {
                            frmCertificatePCX winPCX = new frmCertificatePCX(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winPCX.MdiParent = this.MdiParent;
                            winPCX.StartPosition = FormStartPosition.CenterScreen;
                            winPCX.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }

                        if (myfilmname.StartsWith("WC")
                        || (myfilmname == "SC017" || myfilmname == "SC020" || myfilmname == "SC025" || myfilmname == "SC030" || myfilmname == "SC035" || myfilmname == "SC040" || myfilmname == "SC050")
                        || myfilmname.StartsWith("PC") || myfilmname.StartsWith("PCx") || myfilmname.StartsWith("VCx") || myfilmname.StartsWith("VC")
                        || (myfilmname == "BC017" || myfilmname == "BC020" || myfilmname == "BC025" || myfilmname == "BC030" || myfilmname == "BC045" || myfilmname == "BC050")
                        || myfilmname.StartsWith("PGBT")
                        || (myfilmname == "BL017" || myfilmname == "BL020" || myfilmname == "BL025" || myfilmname == "BL030" || myfilmname == "BL035")
                        || (myfilmname == "BCB020")
                        || (myfilmname == "BCM020" || myfilmname == "BCM025")
                        || myfilmname.StartsWith("BF")
                        || (myfilmname == "BMBTF017") || (myfilmname == "BMBTF020"))
                        {
                            frmCertificateWC winWC = new frmCertificateWC(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winWC.MdiParent = this.MdiParent;
                            winWC.StartPosition = FormStartPosition.CenterScreen;
                            winWC.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }
                        else if (myfilmname.StartsWith("NH"))
                        {
                            frmCertificateMCD winMCD = new frmCertificateMCD(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winMCD.MdiParent = this.MdiParent;
                            winMCD.StartPosition = FormStartPosition.CenterScreen;
                            winMCD.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }
                        else if ((myfilmname == "MC017" || myfilmname == "MC020" || myfilmname == "MC025" || myfilmname == "MC030" || myfilmname == "MC045" || myfilmname == "MC017")
                        || (myfilmname == "ML017" || myfilmname == "ML020" || myfilmname == "ML025" || myfilmname == "ML030" || myfilmname == "ML035") || (myfilmname == "NF020" || myfilmname == "MC020TT" || myfilmname == "NH017TT"))
                        {
                            frmCertificateMC winMCD = new frmCertificateMC(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winMCD.MdiParent = this.MdiParent;
                            winMCD.StartPosition = FormStartPosition.CenterScreen;
                            winMCD.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }

                        else if ((myfilmname == "MC017TT" || myfilmname == "MC020TT")
                        || (myfilmname == "ML020TT"))
                        {
                            frmCertificateMCTT winMCTT = new frmCertificateMCTT(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winMCTT.MdiParent = this.MdiParent;
                            winMCTT.StartPosition = FormStartPosition.CenterScreen;
                            winMCTT.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }

                       /*else if (myfilmname.StartsWith("TH"))
                        {
                            frmCertificateTH winTH = new frmCertificateTH(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winTH.MdiParent = this.MdiParent;
                            winTH.StartPosition = FormStartPosition.CenterScreen;
                            winTH.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }*/
                        else if (myfilmname == "LH015TT" || myfilmname == "LH017TT" || myfilmname == "LH020TT" || myfilmname == "LH025TT" || myfilmname == "LH030TT" || myfilmname == "TH022TT")
                        {
                            frmCertificateLHTT winLHTT = new frmCertificateLHTT(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winLHTT.MdiParent = this.MdiParent;
                            winLHTT.StartPosition = FormStartPosition.CenterScreen;
                            winLHTT.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }
                        else if ((myfilmname == "LH017" || myfilmname == "LH020" || myfilmname == "LH022" || myfilmname == "LH030")
                        || (myfilmname == "TH022" || myfilmname == "TH025" || myfilmname == "TH030"))
                        {
                            frmCertificateLH winLH = new frmCertificateLH(clsCertificate.getLastCodsec(), clsGlobal.password);
                            winLH.MdiParent = this.MdiParent;
                            winLH.StartPosition = FormStartPosition.CenterScreen;
                            winLH.Show();
                            myfilmname = string.Empty;
                            mypanelname = string.Empty;
                        }

                    }
                    else
                        MessageBox.Show("!!!!!!!!!!!", "Certificado de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    myfilmname = string.Empty;
                    mypanelname = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setOpticDensityValues(string destination, string panel)
        {
            #region MC
            if (panel == "pnlMC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.opticdensity = "";
                        ObjCertificate.opticdensity += label113.Text + ";";
                        ObjCertificate.opticdensity += label125.Text + ";";
                        ObjCertificate.opticdensity += label106.Text + ";";
                        ObjCertificate.opticdensity += Math.Round(Convert.ToDouble(textBox23.Text),2).ToString() + ";";
                        ObjCertificate.opticdensity += label101.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.opticdensity = "";
                        ObjCertificate.opticdensity += label266.Text + ";";
                        ObjCertificate.opticdensity += label301.Text + ";";
                        ObjCertificate.opticdensity += label257.Text + ";";
                        ObjCertificate.opticdensity += Math.Round(Convert.ToDouble(textBox53.Text),2).ToString() + ";";
                        ObjCertificate.opticdensity += label248.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }


        private void setBrightnessValues(string destination, string panel)
        {
            #region WC
            if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label50.Text + ";";
                        ObjCertificate.brightness += label56.Text + ";";
                        ObjCertificate.brightness += Math.Round(Convert.ToDouble(textBox1.Text)).ToString() + ";";
                        ObjCertificate.brightness += label57.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label60.Text + ";";
                        ObjCertificate.brightness += label59.Text + ";";
                        ObjCertificate.brightness += Math.Round(Convert.ToDouble(textBox2.Text)).ToString() + ";";
                        ObjCertificate.brightness += label58.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label66.Text + ";";
                        ObjCertificate.brightness += label65.Text + ";";
                        ObjCertificate.brightness += Math.Round(Convert.ToDouble(textBox12.Text)).ToString() + ";";
                        ObjCertificate.brightness += label64.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label80.Text + ";";
                        ObjCertificate.brightness += label71.Text + ";";
                        ObjCertificate.brightness += Math.Round(Convert.ToDouble(textBox15.Text)).ToString() + ";";
                        ObjCertificate.brightness += label67.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region BDTT
            if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label95.Text + ";";
                        ObjCertificate.brightness += label94.Text + ";";
                        ObjCertificate.brightness += Math.Round(Convert.ToDouble(textBox17.Text)).ToString() + ";";
                        ObjCertificate.brightness += label93.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.brightness = "";
                        ObjCertificate.brightness += label134.Text + ";";
                        ObjCertificate.brightness += label217.Text + ";";
                        ObjCertificate.brightness += label133.Text + ";";
                        ObjCertificate.brightness += textBox26.Text + ";";
                        ObjCertificate.brightness += label132.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion


        }

        private void setThiknessValues(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label17.Text + ";";
                        ObjCertificate.thicknessValues += label36.Text + ";";
                        ObjCertificate.thicknessValues += txtmaxthickness.Text + ";";
                        ObjCertificate.thicknessValues += txtminthickness.Text + ";";
                        ObjCertificate.thicknessValues += txtaveragethickness.Text + ";";
                        ObjCertificate.thicknessValues += lblparametersthickness.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label85.Text + ";";
                        ObjCertificate.thicknessValues += label76.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox11.Text + ";";
                        ObjCertificate.thicknessValues += label55.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label167.Text + ";";
                        ObjCertificate.thicknessValues += label158.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox33.Text + ";";
                        ObjCertificate.thicknessValues += label137.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label186.Text + ";";
                        ObjCertificate.thicknessValues += label177.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox40.Text + ";";
                        ObjCertificate.thicknessValues += label146.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label289.Text + ";";
                        ObjCertificate.thicknessValues += label280.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox69.Text + ";";
                        ObjCertificate.thicknessValues += label261.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label340.Text + ";";
                        ObjCertificate.thicknessValues += label333.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox83.Text + ";";
                        ObjCertificate.thicknessValues += label326.Text + ";";
                        break;
                    default:
                        break;
                }
            }

            #endregion

            #region MC
            else if (panel == "pnlMC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label115.Text + ";";
                        ObjCertificate.thicknessValues += label108.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox25.Text + ";";
                        ObjCertificate.thicknessValues += label103.Text + ";";
                        break;
                    default:
                        break;
                }
            }

            #endregion

            #region TH
            else if (panel == "pnlTH")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label446.Text + ";";
                        ObjCertificate.thicknessValues += label30.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox111.Text + ";";
                        ObjCertificate.thicknessValues += label364.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label462.Text + ";";
                        ObjCertificate.thicknessValues += label453.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox115.Text + ";";
                        ObjCertificate.thicknessValues += label376.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label487.Text + ";";
                        ObjCertificate.thicknessValues += label478.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox122.Text + ";";
                        ObjCertificate.thicknessValues += label395.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label212.Text + ";";
                        ObjCertificate.thicknessValues += label225.Text + ";";
                        ObjCertificate.thicknessValues += label206.Text + ";";
                        ObjCertificate.thicknessValues += textBox48.Text + ";";
                        ObjCertificate.thicknessValues += label200.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += label268.Text + ";";
                        ObjCertificate.thicknessValues += label262.Text + ";";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += "0;";
                        ObjCertificate.thicknessValues += textBox55.Text + ";";
                        ObjCertificate.thicknessValues += label253.Text + ";";


                        ObjCertificate.thicknessValues = "";
                        ObjCertificate.thicknessValues += textBox55.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }

        private void setUnitValues(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label18.Text + ";";
                        ObjCertificate.unitValues += label35.Text + ";";
                        ObjCertificate.unitValues += txtmaxunit.Text + ";";
                        ObjCertificate.unitValues += txtminunit.Text + ";";
                        ObjCertificate.unitValues += txtaverageunit.Text + ";";
                        ObjCertificate.unitValues += lblparameterunit.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label84.Text + ";";
                        ObjCertificate.unitValues += label75.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox10.Text + ";";
                        ObjCertificate.unitValues += label54.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label166.Text + ";";
                        ObjCertificate.unitValues += label157.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox32.Text + ";";
                        ObjCertificate.unitValues += label128.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label185.Text + ";";
                        ObjCertificate.unitValues += label176.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox39.Text + ";";
                        ObjCertificate.unitValues += label145.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label288.Text + ";";
                        ObjCertificate.unitValues += label279.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox68.Text + ";";
                        ObjCertificate.unitValues += label260.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label339.Text + ";";
                        ObjCertificate.unitValues += label332.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox82.Text + ";";
                        ObjCertificate.unitValues += label325.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MC
            else if (panel == "pnlMC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label114.Text + ";";
                        ObjCertificate.unitValues += label107.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox24.Text + ";";
                        ObjCertificate.unitValues += label102.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region TH
            else if (panel == "pnlTH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label445.Text + ";";
                        ObjCertificate.unitValues += label427.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox107.Text + ";";
                        ObjCertificate.unitValues += label358.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label461.Text + ";";
                        ObjCertificate.unitValues += label450.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox114.Text + ";";
                        ObjCertificate.unitValues += label368.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label486.Text + ";";
                        ObjCertificate.unitValues += label477.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox121.Text + ";";
                        ObjCertificate.unitValues += label394.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label211.Text + ";";
                        ObjCertificate.unitValues += label224.Text + ";";
                        ObjCertificate.unitValues += label205.Text + ";";
                        ObjCertificate.unitValues += textBox47.Text + ";";
                        ObjCertificate.unitValues += label199.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.unitValues = "";
                        ObjCertificate.unitValues += label267.Text + ";";
                        ObjCertificate.unitValues += label258.Text + ";";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += "0;";
                        ObjCertificate.unitValues += textBox54.Text + ";";
                        ObjCertificate.unitValues += label249.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }

        private void setOpacityValues(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label19.Text + ";";
                        ObjCertificate.opacityValues += label34.Text + ";";
                        ObjCertificate.opacityValues += txtmaxopacity.Text + ";";
                        ObjCertificate.opacityValues += txtminopacity.Text + ";";
                        ObjCertificate.opacityValues += txtaverageopacity.Text + ";";
                        ObjCertificate.opacityValues += lblparameteropacity.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label83.Text + ";";
                        ObjCertificate.opacityValues += label74.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox9.Text + ";";
                        ObjCertificate.opacityValues += label53.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label165.Text + ";";
                        ObjCertificate.opacityValues += label156.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox31.Text + ";";
                        ObjCertificate.opacityValues += label127.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label184.Text + ";";
                        ObjCertificate.opacityValues += label175.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox38.Text + ";";
                        ObjCertificate.opacityValues += label144.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label287.Text + ";";
                        ObjCertificate.opacityValues += label278.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox67.Text + ";";
                        ObjCertificate.opacityValues += label259.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label338.Text + ";";
                        ObjCertificate.opacityValues += label331.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox81.Text + ";";
                        ObjCertificate.opacityValues += label314.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region TH
            else if (panel == "pnlTH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label444.Text + ";";
                        //ObjCertificate.opacityValues += label436.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox105.Text + ";";
                        ObjCertificate.opacityValues += label358.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label460.Text + ";";
                        ObjCertificate.opacityValues += label449.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox113.Text + ";";
                        ObjCertificate.opacityValues += label367.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label485.Text + ";";
                        ObjCertificate.opacityValues += label476.Text + ";";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += "0;";
                        ObjCertificate.opacityValues += textBox120.Text + ";";
                        ObjCertificate.opacityValues += label387.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.opacityValues = "";
                        ObjCertificate.opacityValues += label210.Text + ";";
                        ObjCertificate.opacityValues += label223.Text + ";";
                        ObjCertificate.opacityValues += label204.Text + ";";
                        ObjCertificate.opacityValues += textBox46.Text + ";";
                        ObjCertificate.opacityValues += label198.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

        }

        private void setTensionCI(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label20.Text + ";";
                        ObjCertificate.tensionciValues += label33.Text + ";";
                        ObjCertificate.tensionciValues += label40.Text + ";";
                        ObjCertificate.tensionciValues += label47.Text + ";";
                        ObjCertificate.tensionciValues += txtaveragetension.Text + ";";
                        ObjCertificate.tensionciValues += lblparameterstension.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label82.Text + ";";
                        ObjCertificate.tensionciValues += label73.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox8.Text + ";";
                        ObjCertificate.tensionciValues += label52.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label164.Text + ";";
                        ObjCertificate.tensionciValues += label155.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox30.Text + ";";
                        ObjCertificate.tensionciValues += label126.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {

                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label183.Text + ";";
                        ObjCertificate.tensionciValues += label234.Text + ";";
                        ObjCertificate.tensionciValues += label174.Text + ";";
                        ObjCertificate.tensionciValues += textBox37.Text + ";";
                        ObjCertificate.tensionciValues += label143.Text;
                        break;
                    default:
                        break;
                    
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label286.Text + ";";
                        ObjCertificate.tensionciValues += label277.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox66.Text + ";";
                        ObjCertificate.tensionciValues += label252.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label337.Text + ";";
                        ObjCertificate.tensionciValues += label330.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox80.Text + ";";
                        ObjCertificate.tensionciValues += label313.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region TH
            else if (panel == "pnlTH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label443.Text + ";";
                        ObjCertificate.tensionciValues += label421.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox103.Text + ";";
                        ObjCertificate.tensionciValues += label356.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label459.Text + ";";
                        ObjCertificate.tensionciValues += label442.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox112.Text + ";";
                        ObjCertificate.tensionciValues += label365.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label479.Text + ";";
                        ObjCertificate.tensionciValues += label470.Text + ";";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += "0;";
                        ObjCertificate.tensionciValues += textBox118.Text + ";";
                        ObjCertificate.tensionciValues += label349.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += label194.Text + ";";
                        ObjCertificate.tensionciValues += label219.Text + ";";
                        ObjCertificate.tensionciValues += label193.Text + ";";
                        ObjCertificate.tensionciValues += textBox42.Text + ";";
                        ObjCertificate.tensionciValues += label192.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionciValues = "";
                        ObjCertificate.tensionciValues += textBox49.Text;
                        ObjCertificate.tensionciValues += label239.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

        }

        private void setTensionCE(string destination, string panel)
        {

            #region MCD
            if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionceValues = "";
                        ObjCertificate.tensionceValues += label334.Text + ";";
                        ObjCertificate.tensionceValues += label327.Text + ";";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += textBox79.Text + ";";
                        ObjCertificate.tensionceValues += label296.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionceValues = "";
                        ObjCertificate.tensionceValues += label396.Text + ";";
                        ObjCertificate.tensionceValues += label386.Text + ";";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += textBox85.Text + ";";
                        ObjCertificate.tensionceValues += label378.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.tensionceValues = "";
                        ObjCertificate.tensionceValues += label207.Text + ";";
                        ObjCertificate.tensionceValues += label220.Text + ";";
                        ObjCertificate.tensionceValues += label201.Text + ";";
                        ObjCertificate.tensionceValues += textBox45.Text + ";";
                        ObjCertificate.tensionceValues += label195.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionceValues = "";
                        ObjCertificate.tensionceValues += label98.Text + ";";
                        ObjCertificate.tensionceValues += label227.Text + ";";
                        ObjCertificate.tensionceValues += label97.Text + ";";
                        ObjCertificate.tensionceValues += textBox18.Text + ";";
                        ObjCertificate.tensionceValues += label96.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionceValues= "";
                        ObjCertificate.opacityValues += textBox52.Text;
                        ObjCertificate.opacityValues += label245.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

        }

        private void setSealCT(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label27.Text + ";";
                        ObjCertificate.sealctValues += label28.Text + ";";
                        ObjCertificate.sealctValues += label23.Text + ";";
                        ObjCertificate.sealctValues += label42.Text + ";";
                        ObjCertificate.sealctValues += txtaveragesealct.Text + ";";
                        ObjCertificate.sealctValues += lblparametersealct.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label77.Text + ";";
                        ObjCertificate.sealctValues += label68.Text + ";";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += textBox7.Text + ";";
                        ObjCertificate.sealctValues += label41.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label159.Text + ";";
                        ObjCertificate.sealctValues += label150.Text + ";";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += textBox29.Text + ";";
                        ObjCertificate.sealctValues += label109.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label178.Text + ";";
                        ObjCertificate.sealctValues += label147.Text + ";";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += textBox36.Text + ";";
                        ObjCertificate.sealctValues += label138.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label281.Text + ";";
                        ObjCertificate.sealctValues += label272.Text + ";";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += "0;";
                        ObjCertificate.sealctValues += textBox65.Text + ";";
                        ObjCertificate.sealctValues += label241.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.sealctValues = "";
                        ObjCertificate.sealctValues += label209.Text + ";";
                        ObjCertificate.sealctValues += label222.Text + ";";
                        ObjCertificate.sealctValues += label203.Text + ";";
                        ObjCertificate.sealctValues += textBox44.Text + ";";
                        ObjCertificate.sealctValues += label197.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += textBox22.Text;
                        ObjCertificate.opacityValues += label100.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }

        private void setForceCT(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label26.Text + ";";
                        ObjCertificate.forcectValues += label29.Text + ";";
                        ObjCertificate.forcectValues += label24.Text + ";";
                        ObjCertificate.forcectValues += label43.Text + ";";
                        ObjCertificate.forcectValues += txtaverageforcect.Text + ";";
                        ObjCertificate.forcectValues += lblparametersforcect.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label78.Text + ";";
                        ObjCertificate.forcectValues += label69.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox6.Text + ";";
                        ObjCertificate.forcectValues += label48.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label160.Text + ";";
                        ObjCertificate.forcectValues += label151.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox28.Text + ";";
                        ObjCertificate.forcectValues += label110.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label179.Text + ";";
                        ObjCertificate.forcectValues += label148.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox35.Text + ";";
                        ObjCertificate.forcectValues += label139.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label282.Text + ";";
                        ObjCertificate.forcectValues += label273.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox64.Text + ";";
                        ObjCertificate.forcectValues += label242.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label481.Text + ";";
                        ObjCertificate.forcectValues += label472.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox94.Text + ";";
                        ObjCertificate.forcectValues += label377.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label208.Text + ";";
                        ObjCertificate.forcectValues += label221.Text + ";";
                        ObjCertificate.forcectValues += label202.Text + ";";
                        ObjCertificate.forcectValues += textBox43.Text + ";";
                        ObjCertificate.forcectValues += label196.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

        }

        private void setSealCNT(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label22.Text + ";";
                        ObjCertificate.sealcntValues += label32.Text + ";";
                        ObjCertificate.sealcntValues += label39.Text + ";";
                        ObjCertificate.sealcntValues += label46.Text + ";";
                        ObjCertificate.sealcntValues += txtaveragesealcnt.Text + ";";
                        ObjCertificate.sealcntValues += lblparametersealcnt.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label81.Text + ";";
                        ObjCertificate.sealcntValues += label72.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox5.Text + ";";
                        ObjCertificate.sealcntValues += label51.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label163.Text + ";";
                        ObjCertificate.sealcntValues += label154.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox27.Text + ";";
                        ObjCertificate.sealcntValues += label119.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label182.Text + ";";
                        ObjCertificate.sealcntValues += label171.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox34.Text + ";";
                        ObjCertificate.sealcntValues += label142.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label285.Text + ";";
                        ObjCertificate.sealcntValues += label276.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox59.Text + ";";
                        ObjCertificate.sealcntValues += label251.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label336.Text + ";";
                        ObjCertificate.sealcntValues += label329.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox73.Text + ";";
                        ObjCertificate.sealcntValues += label305.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MC
            else if (panel == "pnlMC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label112.Text + ";";
                        ObjCertificate.sealcntValues += label105.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox22.Text + ";";
                        ObjCertificate.sealcntValues += label100.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label265.Text + ";";
                        ObjCertificate.sealcntValues += label256.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox51.Text + ";";
                        ObjCertificate.sealcntValues += label247.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.tensionceValues = "";
                        ObjCertificate.tensionceValues += label454.Text + ";";
                        ObjCertificate.tensionceValues += label418.Text + ";";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += "0;";
                        ObjCertificate.tensionceValues += textBox97.Text + ";";
                        ObjCertificate.tensionceValues += label346.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label483.Text + ";";
                        ObjCertificate.sealcntValues += label474.Text + ";";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += "0;";
                        ObjCertificate.sealcntValues += textBox116.Text + ";";
                        ObjCertificate.sealcntValues += label385.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.sealcntValues = "";
                        ObjCertificate.sealcntValues += label209.Text + ";";
                        ObjCertificate.sealcntValues += label222.Text + ";";
                        ObjCertificate.sealcntValues += label203.Text + ";";
                        ObjCertificate.sealcntValues += textBox44.Text + ";";
                        ObjCertificate.sealcntValues += label197.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }

        private void setForceCNT(string destination, string panel)
        {
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label25.Text + ";";
                        ObjCertificate.forcecntValues += label30.Text + ";";
                        ObjCertificate.forcecntValues += label37.Text + ";";
                        ObjCertificate.forcecntValues += label44.Text + ";";
                        ObjCertificate.forcecntValues += txtaverageforcecnt.Text + ";";
                        ObjCertificate.forcecntValues += lblparametersforcecnt.Text;
                        break;
                    default:
                        break;
                }
            }
            else if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label79.Text + ";";
                        ObjCertificate.forcecntValues += label70.Text + ";";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += textBox4.Text + ";";
                        ObjCertificate.forcecntValues += label49.Text;
                        break;
                    default:
                        break;
                }
            }
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label161.Text + ";";
                        ObjCertificate.forcecntValues += label152.Text + ";";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += textBox20.Text + ";";
                        ObjCertificate.forcecntValues += label117.Text;
                        break;
                    default:
                        break;
                }
            }
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label180.Text + ";";
                        ObjCertificate.forcecntValues += label149.Text + ";";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += textBox14.Text + ";";
                        ObjCertificate.forcecntValues += label140.Text;
                        break;
                    default:
                        break;
                }
            }
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label283.Text + ";";
                        ObjCertificate.forcecntValues += label274.Text + ";";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += "0;";
                        ObjCertificate.forcecntValues += textBox58.Text + ";";
                        ObjCertificate.forcecntValues += label243.Text;
                        break;
                    default:
                        break;
                }
            }
            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcectValues = "";
                        ObjCertificate.forcectValues += label455.Text + ";";
                        ObjCertificate.forcectValues += label438.Text + ";";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += "0;";
                        ObjCertificate.forcectValues += textBox96.Text + ";";
                        ObjCertificate.forcectValues += label347.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.forcecntValues = "";
                        ObjCertificate.forcecntValues += label208.Text + ";";
                        ObjCertificate.forcecntValues += label221.Text + ";";
                        ObjCertificate.forcecntValues += label202.Text + ";";
                        ObjCertificate.forcecntValues += textBox43.Text + ";";
                        ObjCertificate.forcecntValues += label196.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion
            //else if (panel == "pnlMCD")
            //{
            //    switch (destination)
            //    {
            //        case "toSave":
            //            ObjCertificate.forcecntValues = "";
            //            ObjCertificate.forcecntValues += label334.Text + ";";
            //            ObjCertificate.forcecntValues += label327.Text + ";";
            //            ObjCertificate.forcecntValues += "0;";
            //            ObjCertificate.forcecntValues += "0;";
            //            ObjCertificate.forcecntValues += textBox79.Text + ";";
            //            ObjCertificate.forcecntValues += label296.Text;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else if (panel == "pnl")
            //{
            //    switch (destination)
            //    {
            //        case "toSave":
            //            ObjCertificate.forcecntValues = "";
            //            ObjCertificate.forcecntValues += label262.Text + ";";
            //            ObjCertificate.forcecntValues += label253.Text + ";";
            //            ObjCertificate.forcecntValues += "0;";
            //            ObjCertificate.forcecntValues += "0;";
            //            ObjCertificate.forcecntValues += textBox55.Text + ";";
            //            ObjCertificate.forcecntValues += label244.Text;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            else if (panel == "pnl")
            {
                switch (destination)
                {
                    case "toSave":
                        //ObjCertificate.forcecntValues = "";
                        //ObjCertificate.forcecntValues += label79.Text + ";";
                        //ObjCertificate.forcecntValues += label70.Text + ";";
                        //ObjCertificate.forcecntValues += "0;";
                        //ObjCertificate.forcecntValues += "0;";
                        //ObjCertificate.forcecntValues += textBox4.Text + ";";
                        //ObjCertificate.forcecntValues += label49.Text;
                        break;
                    default:
                        break;
                }
            }
            else if (panel == "pnl")
            {
                switch (destination)
                {
                    case "toSave":
                        //ObjCertificate.forcecntValues = "";
                        //ObjCertificate.forcecntValues += label79.Text + ";";
                        //ObjCertificate.forcecntValues += label70.Text + ";";
                        //ObjCertificate.forcecntValues += "0;";
                        //ObjCertificate.forcecntValues += "0;";
                        //ObjCertificate.forcecntValues += textBox4.Text + ";";
                        //ObjCertificate.forcecntValues += label49.Text;
                        break;
                    default:
                        break;
                }
            }
        }

        private void setCofCNT(string destination, string panel)
        {
            #region SC
            if (panel == "pnlSC")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label21.Text + ";";
                        ObjCertificate.cofdymanicValues += label31.Text + ";";
                        ObjCertificate.cofdymanicValues += label38.Text + ";";
                        ObjCertificate.cofdymanicValues += label45.Text + ";";
                        ObjCertificate.cofdymanicValues += txtaveragecof.Text + ";";
                        ObjCertificate.cofdymanicValues += lblparameterscof.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SD
            if (panel == "pnlSD")
            {
                switch (destination)
                {
                    case "toSave":

                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label92.Text + ";";
                        ObjCertificate.cofdymanicValues += label89.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox16.Text + ";";
                        ObjCertificate.cofdymanicValues += label88.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PC
            else if (panel == "pnlPC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label162.Text + ";";
                        ObjCertificate.cofdymanicValues += label153.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox19.Text + ";";
                        ObjCertificate.cofdymanicValues += label118.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region PCX
            else if (panel == "pnlPCX")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label181.Text + ";";
                        ObjCertificate.cofdymanicValues += label170.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox13.Text + ";";
                        ObjCertificate.cofdymanicValues += label141.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region WC
            else if (panel == "pnlWC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label284.Text + ";";
                        ObjCertificate.cofdymanicValues += label275.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox56.Text + ";";
                        ObjCertificate.cofdymanicValues += label250.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCD
            else if (panel == "pnlMCD")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label335.Text + ";";
                        ObjCertificate.cofdymanicValues += label328.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox71.Text + ";";
                        ObjCertificate.cofdymanicValues += label304.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MC
            else if (panel == "pnlMC")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label111.Text + ";";
                        ObjCertificate.cofdymanicValues += label123.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox21.Text + ";";
                        ObjCertificate.cofdymanicValues += label99.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LH
            else if (panel == "pnlLH")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label457.Text + ";";
                        ObjCertificate.cofdymanicValues += label440.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox87.Text + ";";
                        ObjCertificate.cofdymanicValues += label350.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region LHTT
            else if (panel == "pnlLHTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label63.Text + ";";
                        ObjCertificate.cofdymanicValues += label62.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox3.Text + ";";
                        ObjCertificate.cofdymanicValues += label61.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region SCTT
            else if (panel == "pnlSCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label191.Text + ";";
                        ObjCertificate.cofdymanicValues += label218.Text + ";";
                        ObjCertificate.cofdymanicValues += label136.Text + ";";
                        ObjCertificate.cofdymanicValues += textBox41.Text + ";";
                        ObjCertificate.cofdymanicValues += label135.Text + ";";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region MCTT
            else if (panel == "pnlMCTT")
            {
                switch (destination)
                {
                    case "toSave":
                        ObjCertificate.cofdymanicValues = "";
                        ObjCertificate.cofdymanicValues += label264.Text + ";";
                        ObjCertificate.cofdymanicValues += label299.Text + ";";
                        ObjCertificate.cofdymanicValues += "0;";
                        ObjCertificate.cofdymanicValues += textBox50.Text + ";";
                        ObjCertificate.cofdymanicValues += label246.Text;
                        break;
                    default:
                        break;
                }
            }
            #endregion

        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbLot, ref label2, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbEntity, ref label3, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbOrder, ref label7, "selected")) isValid = false;
            return isValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox11.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox11.Text = "0";
            }
        }

        private void frmCertificate_Load(object sender, EventArgs e)
        {
            HideAllPanel();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox33.Text = clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0").ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox33.Text = "0";
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox40.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox40.Text = "0";
            }
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox69.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox69.Text = "0";
            }
        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox83.Text = Math.ReferenceEquals(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox83.Text = "0";
            }
        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox111.Text = clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0").ToString();
                }
            }
            catch (Exception)
            {
                textBox111.Text = "0";
            }
        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox115.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                }
            }
            catch (Exception)
            {
                textBox115.Text = "0";
            }
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox122.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                }
            }
            catch (Exception)
            {
                textBox122.Text = "0";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox25.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox25.Text = "0";
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            int codsec = clsBopp.getFilmByCode(lblFilm.Text);
            try
            {
                if (codsec > 0)
                {
                    //clsBopp ObjBopp = new clsBopp(codsec);
                    textBox48.Text = Math.Round(clsCertificate.getThicknessAverageByLotNumber(cmbLot.Text + "0"), 1).ToString();
                    FillParametersThickness(codsec, mypanelname);
                }
            }
            catch (Exception)
            {
                textBox48.Text = "0";
            }
        }
    }
}
