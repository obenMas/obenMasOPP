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
    public partial class frmDeletePalletsCompleteByImported : Form
    {
        public List<string> lstPallet = new List<string>();

        public frmDeletePalletsCompleteByImported()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FillPallet();
            Process();
        }

        private void Process()
        {
            bool myporcess = true;
            try
            {
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    clsPallet ObjPallet = new clsPallet();
                    int codsec = 0;
                    bool flgCoilPerSalesOrderDetail = true, flgCoilDetailByPalletDetail = true, flgCoil = true;
                    List<int> lstCoilByPallet = new List<int>();
                    ObjPallet = clsPallet.getCompleteDetailByCode(lstPallet[i]);
                    codsec = ObjPallet.codsec;

                    for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
                        lstCoilByPallet.Add(ObjPallet.lstCoil[j].codsec);

                    clsPalletbyCoilCellar ObjPalletByCellar = new clsPalletbyCoilCellar();
                    if (ObjPalletByCellar.delete(codsec))
                    {
                        if (ObjPallet.deleteSalesOrderDetail(codsec))
                        {
                            clsCoil ObjCoil = new clsCoil();
                            if (ObjCoil.deleteCoilByPallet(codsec))
                            {
                                if (ObjPallet.deletePalletDrop(codsec))
                                {
                                    for (int h = 0; h < ObjPallet.lstCoil.Count; h++)
                                    {
                                        if (!ObjCoil.deleteCoilPerSalesOrderDetail(ObjPallet.lstCoil[h].codsec))
                                        {
                                            flgCoilPerSalesOrderDetail = false;
                                            myporcess = false;
                                            break;
                                        }
                                    }
                                    if (flgCoilPerSalesOrderDetail)
                                    {
                                        for (int k = 0; k < ObjPallet.lstCoil.Count; k++)
                                        {
                                            if (!ObjCoil.deleteCoilDetailByPalletDetail(ObjPallet.lstCoil[k].codsec))
                                            {
                                                flgCoilDetailByPalletDetail = false;
                                                myporcess = false;
                                                break;
                                            }
                                        }
                                        if (flgCoilDetailByPalletDetail)
                                        {
                                            for (int u = 0; u < ObjPallet.lstCoil.Count; u++)
                                            {
                                                if (!ObjCoil.deleteCoilDrop(ObjPallet.lstCoil[u].codsec))
                                                {
                                                    flgCoil = false;
                                                    myporcess = false;
                                                    break;
                                                }
                                            }
                                            if (flgCoil)
                                                myporcess = true;
                                            else
                                                myporcess = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al borrar CoilDetail By PalletDetail");
                                            myporcess = false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al borrar Coil Per Sales Order Detail");
                                        myporcess = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error al borrar Pallet");
                                    myporcess = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al borrar Coil By Pallet");
                                myporcess = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al borrar Pallet By Sales Order Detail");
                            myporcess = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar Pallet By Cellar");
                        myporcess = false;
                    }
                }
                if (myporcess)
                    MessageBox.Show("OK");
                else
                    MessageBox.Show("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FillPallet()
        {
            lstPallet.Add("MCOO20082000023012001");
            lstPallet.Add("MCOO20082000023012002");
            lstPallet.Add("MCOO20082000023012003");
            lstPallet.Add("MCOO20091500023012001");
            lstPallet.Add("MCOO20091500023012002");
            lstPallet.Add("MCOO20091500023012003");
            lstPallet.Add("MCOO20091500023012004");
            lstPallet.Add("MCOO20091500023012005");
            lstPallet.Add("MCOO20091500023012006");
            lstPallet.Add("MCOO20091500023012007");
            lstPallet.Add("MCOO20091500023012008");
            lstPallet.Add("MCOO20091500023012009");
            lstPallet.Add("MCOO20091500023012010");
            lstPallet.Add("MCOO20091500023012011");
            lstPallet.Add("MCOO20091500023012012");
            lstPallet.Add("MCOO20091500023012013");
            lstPallet.Add("MCOO20091500023012014");
            lstPallet.Add("MCOO20091500023012015");
            lstPallet.Add("MCOO20091500023012016");
            lstPallet.Add("MCOO20091500023012017");
            lstPallet.Add("MCOO20091500023012018");
            lstPallet.Add("MCOO20091500023012019");
            lstPallet.Add("MCOO20091500023012020");
            lstPallet.Add("SCOO30119000023012019");
            lstPallet.Add("SCOO30119000023012020");
            lstPallet.Add("SCOO30119000023012021");
            lstPallet.Add("SCOO30119000023012022");
            lstPallet.Add("SCOO30119000023012023");
            lstPallet.Add("SCOO30119000023012024");
            lstPallet.Add("SCOO30119000023012025");
            lstPallet.Add("SCOO30119000023012026");
            lstPallet.Add("SCOO30119000023012027");
            lstPallet.Add("SCOO30122500023012011");
            lstPallet.Add("MCOO20082000023012004");
            lstPallet.Add("MCOO20082000023012005");
            lstPallet.Add("MCOO20082000023012006");
            lstPallet.Add("MCOO20082000023012007");
            lstPallet.Add("MCOO20082000023012008");
            lstPallet.Add("MCOO20091500023012021");
            lstPallet.Add("MCOO20091500023012022");
            lstPallet.Add("MCOO20091500023012023");
            lstPallet.Add("MCOO20091500023012024");
            lstPallet.Add("MCOO20091500023012025");
            lstPallet.Add("MCOO20091500023012026");
            lstPallet.Add("MCOO20091500023012027");
            lstPallet.Add("MCOO20091500023012028");
            lstPallet.Add("MCOO20091500023012029");
            lstPallet.Add("MCOO20091500023012030");
            lstPallet.Add("MCOO20091500023012031");
            lstPallet.Add("MCOO20091500023012032");
            lstPallet.Add("MCOO20091500023012033");
            lstPallet.Add("MCOO20091500023012034");
            lstPallet.Add("MCOO20091500023012035");
            lstPallet.Add("MCOO20091500023012036");
            lstPallet.Add("MCOO20091500023012037");
            lstPallet.Add("MCOO20091500023012038");
            lstPallet.Add("MCOO20091500023012039");
            lstPallet.Add("MCOO20091500023012040");
            lstPallet.Add("MCOO20091500023012041");
            lstPallet.Add("MCOO20091500023012042");
            lstPallet.Add("MCOO20091500023012043");
            lstPallet.Add("MCOO20091500023012044");
            lstPallet.Add("MCOO30117000023012001");
            lstPallet.Add("MCOO30117000023012002");
            lstPallet.Add("MCOO30117000023012003");
            lstPallet.Add("MCOO30117000023012004");
            lstPallet.Add("MCOO30117000023012005");
            lstPallet.Add("SCOO25091500023012058");
            lstPallet.Add("MCOO20082000023012009");
            lstPallet.Add("MCOO20082000023012010");
            lstPallet.Add("MCOO20082000023012011");
            lstPallet.Add("MCOO20082000023012012");
            lstPallet.Add("MCOO20082000023012013");
            lstPallet.Add("MCOO20082000023012014");
            lstPallet.Add("MCOO20082000023012015");
            lstPallet.Add("MCOO20091500023012045");
            lstPallet.Add("MCOO20091500023012047");
            lstPallet.Add("MCOO20091500023012048");
            lstPallet.Add("MCOO20091500023012049");
            lstPallet.Add("MCOO20091500023012050");
            lstPallet.Add("MCOO20091500023012051");
            lstPallet.Add("MCOO20091500023012052");
            lstPallet.Add("MCOO20091500023012053");
            lstPallet.Add("MCOO20091500023012054");
            lstPallet.Add("MCOO20091500023012055");
            lstPallet.Add("MCOO20091500023012056");
            lstPallet.Add("MCOO20091500023012057");
            lstPallet.Add("MCOO20091500023012058");
            lstPallet.Add("MCOO20091500023012059");
            lstPallet.Add("MCOO20091500023012060");
            lstPallet.Add("MCOO20091500023012061");
            lstPallet.Add("MCOO20091500023012062");
            lstPallet.Add("MCOO20091500023012063");
            lstPallet.Add("MCOO20091500023012064");
            lstPallet.Add("MCOO20091500023012065");
            lstPallet.Add("MCOO20091500023012066");
            lstPallet.Add("MCOO20091500023012067");
            lstPallet.Add("MCOO20091500023012068");
            lstPallet.Add("MCOO20091500023012069");
            lstPallet.Add("MCOO20091500023012070");
            lstPallet.Add("MCOO20091500023012071");
            lstPallet.Add("MCOO20091500023012072");
            lstPallet.Add("MCOO30117000023012006");
            lstPallet.Add("MCOO30117000023012007");
            lstPallet.Add("MCOO20082000023012016");
            lstPallet.Add("MCOO20082000023012017");
            lstPallet.Add("MCOO20082000023012018");
            lstPallet.Add("MCOO20082000023012019");
            lstPallet.Add("MCOO20082000023012020");
            lstPallet.Add("MCOO20091500023012073");
            lstPallet.Add("MCOO20091500023012074");
            lstPallet.Add("MCOO20091500023012075");
            lstPallet.Add("MCOO20091500023012076");
            lstPallet.Add("MCOO20091500023012077");
            lstPallet.Add("MCOO20091500023012078");
            lstPallet.Add("MCOO20091500023012079");
            lstPallet.Add("MCOO20091500023012080");
            lstPallet.Add("MCOO20091500023012081");
            lstPallet.Add("MCOO20091500023012082");
            lstPallet.Add("MCOO30117000023012008");
            lstPallet.Add("MCOO30117000023012009");
            lstPallet.Add("MCOO30117000023012010");
            lstPallet.Add("MCOO30117000023012011");
            lstPallet.Add("MCOO30117000023012012");
            lstPallet.Add("MCOO30117000023012013");
            lstPallet.Add("MCOO30117000023012014");
            lstPallet.Add("MCOO30117000023012015");
            lstPallet.Add("MCOO30117000023012016");
            lstPallet.Add("MCOO30117000023012017");
            lstPallet.Add("MCOO30117000023012018");
            lstPallet.Add("MCOO30117000023012019");
            lstPallet.Add("MCOO30117000023012020");
            lstPallet.Add("MCOO30117000023012021");
            lstPallet.Add("SCOO20080000023012029");
            lstPallet.Add("SCOO20108000023012026");
            lstPallet.Add("SCOO30071000023012046");
            lstPallet.Add("SCOO30071000023012047");
            lstPallet.Add("SCOO30119000023012028");
            lstPallet.Add("MCOO20082000023012021");
            lstPallet.Add("MCOO20082000023012022");
            lstPallet.Add("MCOO20082000023012023");
            lstPallet.Add("MCOO20082000023012024");
            lstPallet.Add("MCOO20082000023012025");
            lstPallet.Add("MCOO20082000023012026");
            lstPallet.Add("MCOO20082000023012027");
            lstPallet.Add("MCOO20082000023012028");
            lstPallet.Add("MCOO20082000023012029");
            lstPallet.Add("MCOO20091500023012083");
            lstPallet.Add("MCOO20091500023012084");
            lstPallet.Add("MCOO20091500023012085");
            lstPallet.Add("MCOO20091500023012086");
            lstPallet.Add("MCOO20091500023012087");
            lstPallet.Add("MCOO20091500023012088");
            lstPallet.Add("MCOO20091500023012089");
            lstPallet.Add("MCOO20091500023012090");
            lstPallet.Add("MCOO20091500023012091");
            lstPallet.Add("MCOO20091500023012092");
            lstPallet.Add("MCOO20091500023012093");
            lstPallet.Add("MCOO20091500023012094");
            lstPallet.Add("MCOO20091500023012095");
            lstPallet.Add("MCOO20091500023012096");
            lstPallet.Add("MCOO20091500023012097");
            lstPallet.Add("MCOO20091500023012098");
            lstPallet.Add("MCOO20091500023012099");
            lstPallet.Add("MCOO20091500023012100");
            lstPallet.Add("MCOO20091500023012101");
            lstPallet.Add("MCOO20091500023012102");
            lstPallet.Add("MCOO30117000023012022");
            lstPallet.Add("MCOO30117000023012023");
            lstPallet.Add("MCOO30117000023012024");
            lstPallet.Add("SCOO20080000023012031");
            lstPallet.Add("SCOO30091500023012041");
            lstPallet.Add("SCOO30091500023012042");
            lstPallet.Add("SCOO30091500023012043");
            lstPallet.Add("MCOO20082000023012030");
            lstPallet.Add("MCOO20082000023012031");
            lstPallet.Add("MCOO20082000023012032");
            lstPallet.Add("MCOO20091500023012046");
            lstPallet.Add("MCOO20091500023012103");
            lstPallet.Add("MCOO20091500023012104");
            lstPallet.Add("MCOO20091500023012105");
            lstPallet.Add("MCOO20091500023012106");
            lstPallet.Add("MCOO20091500023012107");
            lstPallet.Add("MCOO20091500023012108");
            lstPallet.Add("MCOO20091500023012109");
            lstPallet.Add("MCOO20091500023012110");
            lstPallet.Add("MCOO20091500023012111");
            lstPallet.Add("MCOO20091500023012112");
            lstPallet.Add("MCOO20091500023012113");
            lstPallet.Add("MCOO20091500023012114");
            lstPallet.Add("MCOO20091500023012115");
            lstPallet.Add("MCOO20091500023012122");
            lstPallet.Add("MCOO30117000023012025");
            lstPallet.Add("MCOO30117000023012026");
            lstPallet.Add("MCOO30117000023012027");
            lstPallet.Add("MCOO30117000023012028");
            lstPallet.Add("MCOO30117000023012029");
            lstPallet.Add("MCOO30117000023012030");
            lstPallet.Add("MCOO30117000023012031");
            lstPallet.Add("MCOO30117000023012032");
            lstPallet.Add("MCOO30117000023012033");
            lstPallet.Add("MCOO30117000023012034");
            lstPallet.Add("MCOO30117000023012035");
            lstPallet.Add("MCOO30117000023012036");
            lstPallet.Add("MCOO30117000023012037");
            lstPallet.Add("MCOO30117000023012038");
            lstPallet.Add("MCOO30117000023012039");
        }
    }
}
