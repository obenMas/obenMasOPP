using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using BPS.Bussiness;
using System.Windows.Forms.DataVisualization.Charting;


namespace BPS
{
    public partial class frmKpis : Form
    {
        List<clsPlant> lstPlant = new List<clsPlant>();
        clsPlant planta = new clsPlant();
        double Cons1Sem = 0;
        double Cons2Sem = 0;
        double Cons3Sem = 0;
        double Cons4Sem = 0;
        double Cons5Sem = 0;
        double Cons6Sem = 0;
        int machine = 0;
        int primcutter = 0;
        int seccutter = 0;
        int metallizer = 0;

        //Declara globalmente los Delegados
        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;
        
        // Declara globalmente los 2 metodos a usar por los delegados. 
        // Uno se utiliza para mostrar el panel de cargando y el otro para esconder el panel de cargando. 
        private void showLoadingDelegate() //Muestro Cargando...
        {
            pnlProcess.Visible = true;
            pnlProcess.BringToFront();
            pctBoxImage.Visible = true;
            pctBoxImage.BringToFront();
         
        }

        private void hideLoadingDelegate() //Escondo Cargando...
        {
            pnlProcess.Visible = false;
            pnlProcess.SendToBack();
            pctBoxImage.Visible = false;
            //pctBoxImage.SendToBack();
            MessageBox.Show("Se ha realizado el calculo de los KPI's con éxito.", "KPI's Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }


        public frmKpis()
        {
            InitializeComponent();
            limpiarLabel();
            llenarCombo();
            ponertodoEnCero();
            cambiarEstetica();
        }


        private void llenarCombo()
        {
            for (int i = 1; i <= 12; i++)
            {           
                DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;                
                string mes = dtinfo.GetMonthName(i).ToString().ToUpper();
                cmbMes.Items.Add(mes);
            }

            for (int i = 0; i < 20; i++)
            {
                int año = 2017 + i;
                cmbYear.Items.Add(año.ToString());
            }

            lstPlant = clsPlant.getList();

            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbPlanta.Items.Add(lstPlant[i].name);
            }

            cmbYear.SelectedIndex = 0;

            cmbMes.SelectedIndex = 0;

        }

        #region Pongo todos los txtbox en 0
        
     
        private void ponertodoEnCero()
        {
            #region Solapa Extrusión
            txtSem1Prod.Text = "0";
            txtSem2Prod.Text = "0";
            txtSem3Prod.Text = "0";
            txtSem4Prod.Text = "0";
            txtSem5Prod.Text = "0";
            txtSem6Prod.Text = "0";
            txtSem1ConsRec.Text = "0";
            txtSem2ConsRec.Text = "0";
            txtSem3ConsRec.Text = "0";
            txtSem4ConsRec.Text = "0";
            txtSem5ConsRec.Text = "0";
            txtSem6ConsRec.Text = "0";
            txtSem1Efi.Text = "0";
            txtSem2Efi.Text = "0";
            txtSem3Efi.Text = "0";
            txtSem4Efi.Text = "0";
            txtSem5Efi.Text = "0";
            txtSem6Efi.Text = "0";
            txtSem1EfiV.Text = "0";
            txtSem2EfiV.Text = "0";
            txtSem3EfiV.Text = "0";
            txtSem4EfiV.Text = "0";
            txtSem5EfiV.Text = "0";
            txtSem6EfiV.Text = "0";
            txtSem1Lote.Text = "0";
            txtSem1Merma.Text = "0";
            txtSem2Merma.Text = "0";
            txtSem3Merma.Text = "0";
            txtSem4Merma.Text = "0";
            txtSem5Merma.Text = "0";
            txtSem6Merma.Text = "0";
            txtSem1PorcRecu.Text = "0";
            txtSem1Lote.Text = "0";
            txtSem2Lote.Text = "0";
            txtSem3Lote.Text = "0";
            txtSem4Lote.Text = "0";
            txtSem5Lote.Text = "0";
            txtSem6Lote.Text = "0";
            txtSem1Camb.Text = "0";
            txtSem2Camb.Text = "0";
            txtSem3Camb.Text = "0";
            txtSem4Camb.Text = "0";
            txtSem5Camb.Text = "0";
            txtSem6Camb.Text = "0";
            txtSem1PorcRecu.Text = "0";
            txtSem2PorcRecu.Text = "0";
            txtSem3PorcRecu.Text = "0";
            txtSem4PorcRecu.Text = "0";
            txtSem5PorcRecu.Text = "0";
            txtSem6PorcRecu.Text = "0";
            txtSem1RecV.Text = "0";
            txtSem2RecV.Text = "0";
            txtSem3RecV.Text = "0";
            txtSem4RecV.Text = "0";
            txtSem5RecV.Text = "0";
            txtSem6RecV.Text = "0";
            txtObjetivoProd.Text = "0";
            txtObjetivoCambios.Text = "0";
            txtObjetivoLote.Text = "0";
            txtObjetivoMerma.Text = "0";
            txtObjetivoEf.Text = "0";
            txtObjetivoRecup.Text = "0";
            txtObjetivoPorRecup.Text = "0";
            txtObjEfiV.Text = "0";
            txtObjRecV.Text = "0";
            txtTotEfiV.Text = "0";
            txtPorcCumpV.Text = "0";
            txtTotRecV.Text = "0";
            txtRecCumpV.Text = "0";
            txtTotalProd.Text = "0";
            txtTotalCambios.Text = "0";
            txtTotalLote.Text = "0";
            txtTotalMerma.Text = "0";
            txtTotalEfi.Text = "0";
            txtTotalConsRecu.Text = "0";
            txtTotalRecu.Text = "0";
            txtCumpProd.Text = "0";
            txtCumpCambios.Text = "0";
            txtCumpLote.Text = "0";
            txtCumpMerma.Text = "0";
            txtCumpEfi.Text = "0";
            txtCumpConRecu.Text = "0";
            txtCumpRecup.Text = "0";

            #endregion 

            #region Solapa Corte Primario

            txtObjProdCP.Text = "0";
            txtObjRepPromCP.Text = "0";
            txtObjMermaCP.Text = "0";
            txtObjEfiCP.Text = "0";
            txtObjEfiCPV.Text = "0";
            txtSem1PCP.Text ="0";
            txtSem2PCP.Text = "0";
            txtSem3PCP.Text = "0";
            txtSem4PCP.Text = "0";
            txtSem5PCP.Text = "0";
            txtSem6PCP.Text = "0";
            txtSem1RepPromCP.Text = "0";
            txtSem2RepPromCP.Text = "0";
            txtSem3RepPromCP.Text = "0";
            txtSem4RepPromCP.Text = "0";
            txtSem5RepPromCP.Text = "0";
            txtSem6RepPromCP.Text = "0";
            txtSem1MermCP.Text = "0";
            txtSem2MermCP.Text = "0";
            txtSem3MermCP.Text = "0";
            txtSem4MermCP.Text = "0";
            txtSem5MermCP.Text = "0";
            txtSem6MermCP.Text = "0";
            txtSem1EfiCP.Text = "0";
            txtSem2EfiCP.Text = "0";
            txtSem3EfiCP.Text = "0";
            txtSem4EfiCP.Text = "0";
            txtSem5EfiCP.Text = "0";
            txtSem6EfiCP.Text = "0";
            txtSem1EfiCPV.Text = "0";
            txtSem2EfiCPV.Text = "0";
            txtSem3EfiCPV.Text = "0";
            txtSem4EfiCPV.Text = "0";
            txtSem5EfiCPV.Text = "0";
            txtSem6EfiCPV.Text = "0";
            txtTotProdCP.Text = "0";
            txtTotRepPromCP.Text = "0";
            txtTotMermaCP.Text = "0";
            txtTotEfiCP.Text = "0";
            txtTotEfiCPV.Text = "0";
            txtCumpProdCP.Text = "0";
            txtCumpEfiCPV.Text = "0";
            txtCumpRepPromCP.Text = "0";
            txtCumpMermaCP.Text = "0";
            txtCumpEfiCP.Text = "0";

            #endregion

            #region Solapa Metalizado

            txtObjProdM.Text  = "0";
            txtObjCantBobM.Text  = "0";
            txtObjBPromM.Text  = "0";
            txtObjMermM.Text  = "0";
            txtObjEfiM.Text  = "0";
            txtObjProdMM.Text  = "0";
            txtObjMermMM.Text  = "0";
            txtObjEfiMM.Text  = "0";
            txtObjTotMerMM.Text  = "0";
            txtObjEfiMetM.Text  = "0";
            txtSem1ProdGrlM.Text  = "0";
            txtSem2ProdGrlM.Text = "0";
            txtSem3ProdGrlM.Text = "0";
            txtSem4ProdGrlM.Text = "0";
            txtSem5ProdGrlM.Text = "0";
            txtSem6ProdGrlM.Text = "0";
            txtSem1CantBobM.Text  = "0";
            txtSem2CantBobM.Text = "0";
            txtSem3CantBobM.Text = "0";
            txtSem4CantBobM.Text = "0";
            txtSem5CantBobM.Text = "0";
            txtSem6CantBobM.Text = "0";
            txtSem1BobPromM.Text  = "0";
            txtSem2BobPromM.Text = "0";
            txtSem3BobPromM.Text = "0";
            txtSem4BobPromM.Text = "0";
            txtSem5BobPromM.Text = "0";
            txtSem6BobPromM.Text = "0";
            txtSem1MermGrlM.Text  = "0";
            txtSem2MermGrlM.Text = "0";
            txtSem3MermGrlM.Text = "0";
            txtSem4MermGrlM.Text = "0";
            txtSem5MermGrlM.Text = "0";
            txtSem6MermGrlM.Text = "0";
            txtSem1EfiM.Text  = "0";
            txtSem2EfiM.Text = "0";
            txtSem3EfiM.Text = "0";
            txtSem4EfiM.Text = "0";
            txtSem5EfiM.Text = "0";
            txtSem6EfiM.Text = "0";
            txtSem1EfiMV.Text = "0";
            txtSem2EfiMV.Text = "0";
            txtSem3EfiMV.Text = "0";
            txtSem4EfiMV.Text = "0";
            txtSem5EfiMV.Text = "0";
            txtSem6EfiMV.Text = "0";
            txtSem1ProdMM.Text  = "0";
            txtSem2ProdMM.Text = "0";
            txtSem3ProdMM.Text = "0";
            txtSem4ProdMM.Text = "0";
            txtSem5ProdMM.Text = "0";
            txtSem6ProdMM.Text = "0";
            txtSem1MermMM.Text  = "0";
            txtSem2MermMM.Text = "0";
            txtSem3MermMM.Text = "0";
            txtSem4MermMM.Text = "0";
            txtSem5MermMM.Text = "0";
            txtSem6MermMM.Text = "0";
            txtSem1EfiMetM.Text  = "0";
            txtSem2EfiMetM.Text = "0";
            txtSem3EfiMetM.Text = "0";
            txtSem4EfiMetM.Text = "0";
            txtSem5EfiMetM.Text = "0";
            txtSem6EfiMetM.Text = "0";
            txtSem1EfiMetMV.Text = "0";
            txtSem2EfiMetMV.Text = "0";
            txtSem3EfiMetMV.Text = "0";
            txtSem4EfiMetMV.Text = "0";
            txtSem5EfiMetMV.Text = "0";
            txtSem6EfiMetMV.Text = "0";
            txtSem1TotMermMM.Text  = "0";
            txtSem2TotMermMM.Text = "0";
            txtSem3TotMermMM.Text = "0";
            txtSem4TotMermMM.Text = "0";
            txtSem5TotMermMM.Text = "0";
            txtSem6TotMermMM.Text = "0";
            txtSem1TotEfiMetM.Text  = "0";
            txtSem2TotEfiMetM.Text = "0";
            txtSem3TotEfiMetM.Text = "0";
            txtSem4TotEfiMetM.Text = "0";
            txtSem5TotEfiMetM.Text = "0";
            txtSem6TotEfiMetM.Text = "0";
            txtSem1TotEfiMetMV.Text = "0";
            txtSem2TotEfiMetMV.Text = "0";
            txtSem3TotEfiMetMV.Text = "0";
            txtSem4TotEfiMetMV.Text = "0";
            txtSem5TotEfiMetMV.Text = "0";
            txtSem6TotEfiMetMV.Text = "0";
            txtTotProdGrl.Text  = "0";
            txtTotCantBobM.Text  = "0";
            txtTotBobPromM.Text  = "0";
            txtTotMermGrlM.Text  = "0";
            txtTotEfiM.Text  = "0";
            txtTotEfiMV.Text = "0";
            txtTotPromMetM.Text  = "0";
            txtObjEfiMV.Text = "0";
            txtObjEfiMMV.Text = "0";
            txtObjEfiMetMV.Text = "0";
            txtMermMetM.Text  = "0";
            txtTotEfiMetM.Text  = "0";
            txtTotEfiMetMV.Text = "0";
            txtTotTotMermM.Text  = "0";
            txtTotEfiMetMetMM.Text  = "0";
            txtTotEfiMetMetMMV.Text = "0";
            txtCumpProdGnrlM.Text  = "0";
            txtCumpCantBobM.Text  = "0";
            txtCumpBobPromM.Text  = "0";
            txtCumpMermGrnlM.Text  = "0";
            txtCumpEfiM.Text  = "0";
            txtCumpEfiMV.Text = "0";
            txtCumpProdMetM.Text  = "0";
            txtCumpMermMetM.Text  = "0";
            txtCumpEfiMetM.Text  = "0";
            txtCumpEfiMetMV.Text = "0";
            txtCumpTotMermMetM.Text  = "0";
            txtCumpTotEfiMetM.Text = "0";
            txtCumpTotEfiMetMV.Text = "0";

            #endregion

            #region Solapa Corte Secundario 
            txtObjProdCS.Text= "0";
            txtObjMermCS.Text= "0";
            txtObjEfiCS.Text= "0";
            txtObjTotMermCS.Text= "0";
            txtObjEfiP2CS.Text= "0";
            txtObjOptRecCS.Text= "0";
            txtObjProdOP1CS.Text= "0";
            txtObjProdPPCS.Text= "0";
            txtObjPorcOp1CS.Text= "0";
            txtObjPorcPPCS.Text= "0";
            txtSem1ProdCS.Text = "0";
            txtSem2ProdCS.Text = "0";
            txtSem3ProdCS.Text = "0";
            txtSem4ProdCS.Text = "0";
            txtSem5ProdCS.Text = "0";
            txtSem6ProdCS.Text = "0";
            txtSem1MermCS.Text = "0";
            txtSem2MermCS.Text = "0";
            txtSem3MermCS.Text = "0";
            txtSem4MermCS.Text = "0";
            txtSem5MermCS.Text = "0";
            txtSem6MermCS.Text = "0";
            txtSem1EfiCS.Text= "0";
            txtSem2EfiCS.Text = "0";
            txtSem3EfiCS.Text = "0";
            txtSem4EfiCS.Text = "0";
            txtSem5EfiCS.Text = "0";
            txtSem6EfiCS.Text = "0";
            txtSem1EfiCSV.Text = "0";
            txtSem2EfiCSV.Text = "0";
            txtSem3EfiCSV.Text = "0";
            txtSem4EfiCSV.Text = "0";
            txtSem5EfiCSV.Text = "0";
            txtSem6EfiCSV.Text = "0";
            txtSem1TotMermP2CS.Text= "0";
            txtSem2TotMermP2CS.Text = "0";
            txtSem3TotMermP2CS.Text = "0";
            txtSem4TotMermP2CS.Text = "0";
            txtSem5TotMermP2CS.Text = "0";
            txtSem6TotMermP2CS.Text = "0";
            txtSem1EfiP2CS.Text= "0";
            txtSem2EfiP2CS.Text = "0";
            txtSem3EfiP2CS.Text = "0";
            txtSem4EfiP2CS.Text = "0";
            txtSem5EfiP2CS.Text = "0";
            txtSem6EfiP2CS.Text = "0";
            txtSem1EfiP2CSV.Text = "0";
            txtSem2EfiP2CSV.Text = "0";
            txtSem3EfiP2CSV.Text = "0";
            txtSem4EfiP2CSV.Text = "0";
            txtSem5EfiP2CSV.Text = "0";
            txtSem6EfiP2CSV.Text = "0";
            txtSem1OptRecCS.Text= "0";
            txtSem2OptRecCS.Text = "0";
            txtSem3OptRecCS.Text = "0";
            txtSem4OptRecCS.Text = "0";
            txtSem5OptRecCS.Text = "0";
            txtSem6OptRecCS.Text = "0";
            txtSem1ProdOp1CS.Text= "0";
            txtSem2ProdOp1CS.Text = "0";
            txtSem3ProdOp1CS.Text = "0";
            txtSem4ProdOp1CS.Text = "0";
            txtSem5ProdOp1CS.Text = "0";
            txtSem6ProdOp1CS.Text = "0";
            txtSem1ProdPPCS.Text= "0";
            txtSem2ProdPPCS.Text = "0";
            txtSem3ProdPPCS.Text = "0";
            txtSem4ProdPPCS.Text = "0";
            txtSem5ProdPPCS.Text = "0";
            txtSem6ProdPPCS.Text = "0";
            txtSem1Op1CS.Text= "0";
            txtSem2Op1CS.Text = "0";
            txtSem3Op1CS.Text = "0";
            txtSem4Op1CS.Text = "0";
            txtSem5Op1CS.Text = "0";
            txtSem6Op1CS.Text = "0";
            txtSem1Op1CSV.Text = "0";
            txtSem2Op1CSV.Text = "0";
            txtSem3Op1CSV.Text = "0";
            txtSem4Op1CSV.Text = "0";
            txtSem5Op1CSV.Text = "0";
            txtSem6Op1CSV.Text = "0";
            txtSem1PPCS.Text= "0";
            txtSem2PPCS.Text = "0";
            txtSem3PPCS.Text = "0";
            txtSem4PPCS.Text = "0";
            txtSem5PPCS.Text = "0";
            txtSem6PPCS.Text = "0";
            txtSem1PPCSV.Text = "0";
            txtSem2PPCSV.Text = "0";
            txtSem3PPCSV.Text = "0";
            txtSem4PPCSV.Text = "0";
            txtSem5PPCSV.Text = "0";
            txtSem6PPCSV.Text = "0";
            txtTotProdCS.Text= "0";
            txtTotMermaCS.Text= "0";
            txtTotEfiCS.Text= "0";
            txtTotEfiCSV.Text = "0";
            txtTotMermaP2CS.Text= "0";
            txtTotEfiP2CS.Text= "0";
            txtTotEfiP2CSV.Text = "0";
            txtTotOptRecCS.Text= "0";
            txtTotProdOP1CS.Text= "0";
            txtTotProdPPCS.Text= "0";
            txtTotOP1CS.Text= "0";
            txtTotOP1CSV.Text = "0";
            txtTotPPCS.Text= "0";
            txtTotPPCSV.Text = "0";
            txtCumpProdCS.Text= "0";
            txtCumpMermaCS.Text= "0";
            txtCumpEfiCS.Text= "0";
            txtCumpEfiCSV.Text = "0";
            txtCumpTotMermP2CS.Text= "0";
            txtCumpEfiP2CS.Text= "0";
            txtCumpEfiP2CSV.Text = "0";
            txtCumpOptRecCS.Text= "0";
            txtCumpProdOPCS.Text= "0";
            txtCumpProdPPCS.Text= "0";
            txtCumpPOPCS.Text= "0";
            txtCumpPOPCSV.Text = "0";
            txtCumpPPCS.Text= "0";
            txtCumpPPCSV.Text = "0";


            #endregion

            #region Solapa Deposito & Logistica.
            txtObjProdLocDL.Text ="0";
            txtObjInvRevDL.Text ="0";
            txtObjTotInvDL.Text ="0";
            txtObjAgePromLocDL.Text ="0";
            txtObjAgePromRevDL.Text ="0";
            txtObjDespPTLDL.Text ="0";
            txtObjDispatchPTIDL.Text ="0";
            txtObjIndRotPTLDL.Text ="0";
            txtObjIndRotPTIDL.Text ="0";
            txtSem1ProdLocDL.Text ="0";
            txtSem2ProdLocDL.Text = "0";
            txtSem3ProdLocDL.Text = "0";
            txtSem4ProdLocDL.Text = "0";
            txtSem5ProdLocDL.Text = "0";
            txtSem6ProdLocDL.Text = "0";
            txtSem1InvRevDL.Text ="0";
            txtSem2InvRevDL.Text = "0";
            txtSem3InvRevDL.Text = "0";
            txtSem4InvRevDL.Text = "0";
            txtSem5InvRevDL.Text = "0";
            txtSem6InvRevDL.Text = "0";
            txtSem1TotInvDL.Text ="0";
            txtSem2TotInvDL.Text = "0";
            txtSem3TotInvDL.Text = "0";
            txtSem4TotInvDL.Text = "0";
            txtSem5TotInvDL.Text = "0";
            txtSem6TotInvDL.Text = "0";
            txtSem1AgePromDL.Text ="0";
            txtSem2AgePromDL.Text = "0";
            txtSem3AgePromDL.Text = "0";
            txtSem4AgePromDL.Text = "0";
            txtSem5AgePromDL.Text = "0";
            txtSem6AgePromDL.Text = "0";
            txtSem1AgePromRev.Text ="0";
            txtSem2AgePromRev.Text = "0";
            txtSem3AgePromRev.Text = "0";
            txtSem4AgePromRev.Text = "0";
            txtSem5AgePromRev.Text = "0";
            txtSem6AgePromRev.Text = "0";
            txtSem1DispPTL.Text ="0";
            txtSem2DispPTL.Text = "0";
            txtSem3DispPTL.Text = "0";
            txtSem4DispPTL.Text = "0";
            txtSem5DispPTL.Text = "0";
            txtSem6DispPTL.Text = "0";
            txtSem1DispPTI.Text ="0";
            txtSem2DispPTI.Text = "0";
            txtSem3DispPTI.Text = "0";
            txtSem4DispPTI.Text = "0";
            txtSem5DispPTI.Text = "0";
            txtSem6DispPTI.Text = "0";
            txtSem1IndRotPTL.Text ="0";
            txtSem2IndRotPTL.Text = "0";
            txtSem3IndRotPTL.Text = "0";
            txtSem4IndRotPTL.Text = "0";
            txtSem5IndRotPTL.Text = "0";
            txtSem6IndRotPTL.Text = "0";
            txtSem1IndRotPTI.Text ="0";
            txtSem2IndRotPTI.Text = "0";
            txtSem3IndRotPTI.Text = "0";
            txtSem4IndRotPTI.Text = "0";
            txtSem5IndRotPTI.Text = "0";
            txtSem6IndRotPTI.Text = "0";
            txtTotProdLocDL.Text ="0";
            txtTotInvRevDL.Text ="0";
            txtTotTotInvDL.Text ="0";
            txtTotPromAgeDL.Text ="0";
            txtTotAgePromDL.Text ="0";
            txtTotDespPTLDL.Text ="0";
            txtTotDespPTIDL.Text ="0";
            txtTotIndRotPTLDL.Text ="0";
            txtTotIndRotPTIDL.Text ="0";
            txtCumpInvProdLocDL.Text ="0";
            txtCumpInvRevDL.Text ="0";
            txtCumpTotInvDL.Text ="0";
            txtCumpPromAgeLDL.Text ="0";
            txtCumpAgePromRDL.Text ="0";
            txtCumpDespPTL.Text ="0";
            txtCumpDespPTI.Text ="0";
            txtCumpRotPTLDL.Text ="0";
            txtCumpIndRotPTIDL.Text ="0";

            #endregion

            #region Gesiton de Calidad
            txtObjRecIngGdC.Text ="0";
            txtObjKgRecIngGdC.Text ="0";
            txtObjRecAprbGdC.Text ="0";
            txtObjKgRecAprbGdC.Text ="0";
            txtObjPorcRecAprbGdC.Text ="0";
            txtObjDevIngBPTGdc.Text ="0";
            txtSem1RecIngGdc.Text ="0";
            txtSem2RecIngGdc.Text = "0";
            txtSem3RecIngGdc.Text = "0";
            txtSem4RecIngGdc.Text = "0";
            txtSem5RecIngGdc.Text = "0";
            txtSem6RecIngGdc.Text = "0";
            txtSem1KgRecIngGdC.Text ="0";
            txtSem2KgRecIngGdC.Text = "0";
            txtSem3KgRecIngGdC.Text = "0";
            txtSem4KgRecIngGdC.Text = "0";
            txtSem5KgRecIngGdC.Text = "0";
            txtSem6KgRecIngGdC.Text = "0";
            txtSem1RecAprbGdc.Text ="0";
            txtSem2RecAprbGdc.Text = "0";
            txtSem3RecAprbGdc.Text = "0";
            txtSem4RecAprbGdc.Text = "0";
            txtSem5RecAprbGdc.Text = "0";
            txtSem6RecAprbGdc.Text = "0";
            txtSem1KgRecAprb.Text ="0";
            txtSem2KgRecAprb.Text = "0";
            txtSem3KgRecAprb.Text = "0";
            txtSem4KgRecAprb.Text = "0";
            txtSem5KgRecAprb.Text = "0";
            txtSem6KgRecAprb.Text = "0";
            txtSem1RecAprb.Text ="0";
            txtSem2RecAprb.Text = "0";
            txtSem3RecAprb.Text = "0";
            txtSem4RecAprb.Text = "0";
            txtSem5RecAprb.Text = "0";
            txtSem6RecAprb.Text = "0";
            txtSem1RecAprbV.Text = "0";
            txtSem2RecAprbV.Text = "0";
            txtSem3RecAprbV.Text = "0";
            txtSem4RecAprbV.Text = "0";
            txtSem5RecAprbV.Text = "0";
            txtSem6RecAprbV.Text = "0";
            txtSem1DevIngBpt.Text ="0";
            txtSem2DevIngBpt.Text = "0";
            txtSem3DevIngBpt.Text = "0";
            txtSem4DevIngBpt.Text = "0";
            txtSem5DevIngBpt.Text = "0";
            txtSem6DevIngBpt.Text = "0";
            txtTotRecIng.Text ="0";
            txtTotKgRecIng.Text ="0";
            txtTotRecAprb.Text ="0";
            txtTotKgRecAprb.Text ="0";
            txtTotRecAprbGdC.Text = "0";
            txtTotRecAprbGdCV.Text = "0";
            txtTotDevIngBPT.Text = "0";
            txtCumpRecIngGdC.Text = "0";
            txtCumpKgRecIngGdC.Text = "0";
            txtCumpRecAprbGdC.Text = "0";
            txtCumpKgRecAprbGdC.Text = "0";
            txtCumpPorcRecAprbGdC.Text ="0";
            txtCumpPorcRecAprbGdCV.Text = "0";
            txtCumpDevIngBPTGdC.Text = "0";

            #endregion

        }

        #endregion

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblMes.Text = cmbMes.SelectedItem.ToString();
            lblAño.Text = cmbYear.SelectedItem.ToString();
            DateTime date = DateTime.Now;
            DataSet DS = new DataSet();

            ponertodoEnCero();
            limpiarCharts();

            if (cmbPlanta.SelectedIndex != -1)
            {
                this.planta = new clsPlant(cmbPlanta.SelectedItem.ToString());
            }

            if (planta.codsec == 3)
            {
                machine = 11;
                primcutter = 10;
                seccutter = 3012;
                metallizer = 2011;
            }
            else if (planta.codsec != 0)
            {
                machine = 3024;
                primcutter = 3025;
                seccutter = 3026;
                metallizer = 3028;
            }

            //Se puede optimizar simplemente calculandolo una sola vez. Y despues es todo asignacion a las demas labels. (creo que es mas barato)

            if(cmbMes.SelectedIndex != -1 && cmbYear.SelectedIndex != -1) // Este es if1
            {
                //limpiarSemanas();

                calculoDeFecha();

                if (cmbPlanta.SelectedIndex != -1)
                {
                    string queryString = "";

                    if (lbl61.Text != string.Empty)
                    {
                        queryString = "SELECT * FROM bps_prod_kpis WHERE kpi_fkPlant =" + planta.codsec.ToString() + " AND kpi_date BETWEEN '" + lbl1.Text + "' AND '" + lbl62.Text + "' ORDER BY kpi_codsec ASC";
                    }
                    else
                    {
                        queryString = "SELECT * FROM bps_prod_kpis WHERE kpi_fkPlant =" + planta.codsec.ToString() + " AND kpi_date BETWEEN '" + lbl1.Text + "' AND '" + lbl10.Text + "' ORDER BY kpi_codsec ASC";
                       
                    }

                    DS = clsConnection.getDataSetResult(queryString);

                    if (cmbPlanta.SelectedIndex != -1 && DS.Tables[0].Rows.Count < 1 && DS.Tables.Count > 0)
                    {
                        this.Invoke(showLoadImage);
                        calculoTodo();
                        this.Invoke(hideLoadImage);
                    }
                    else
                    {
                        if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                        {

                            #region Carga a partir de la consulta

                            //Semana 1
                            txtObjetivoProd.Text = DS.Tables[0].Rows[0]["kpi_objProd"].ToString();
                            txtObjetivoCambios.Text = DS.Tables[0].Rows[0]["kpi_objCamb"].ToString();
                            txtObjetivoMerma.Text = DS.Tables[0].Rows[0]["kpi_objEfiExt"].ToString();
                            txtObjetivoRecup.Text = DS.Tables[0].Rows[0]["kpi_objPorcRecExt"].ToString();
                            txtObjProdCP.Text = DS.Tables[0].Rows[0]["kpi_objProdCP"].ToString();
                            txtObjRepPromCP.Text = DS.Tables[0].Rows[0]["kpi_objRepPromCP"].ToString();
                            txtObjEfiCPV.Text = DS.Tables[0].Rows[0]["kpi_objEfiCP"].ToString();
                            txtObjProdM.Text = DS.Tables[0].Rows[0]["kpi_objProdM"].ToString();
                            txtObjBPromM.Text = DS.Tables[0].Rows[0]["kpi_objBProM"].ToString();
                            txtObjEfiMV.Text = DS.Tables[0].Rows[0]["kpi_objEfiM"].ToString();
                            txtObjProdMM.Text = DS.Tables[0].Rows[0]["kpi_objProdMM"].ToString();
                            txtObjProdCS.Text = DS.Tables[0].Rows[0]["kpi_objProdCS"].ToString();
                            txtObjEfiCS.Text = DS.Tables[0].Rows[0]["kpi_objEfiCS"].ToString();
                            txtObjOptRecCS.Text = DS.Tables[0].Rows[0]["kpi_objOptRecCS"].ToString();
                            txtObjPorcOp1CS.Text = DS.Tables[0].Rows[0]["kpi_objPorcOP1CS"].ToString();
                            txtObjPorcPPCS.Text = DS.Tables[0].Rows[0]["kpi_objPorcPPCS"].ToString();
                            txtObjProdLocDL.Text = DS.Tables[0].Rows[0]["kpi_objProdLocDL"].ToString();
                            txtObjInvRevDL.Text = DS.Tables[0].Rows[0]["kpi_objInvRevDL"].ToString();
                            txtObjAgePromLocDL.Text = DS.Tables[0].Rows[0]["kpi_objAgePromLocDL"].ToString();
                            txtObjAgePromRevDL.Text = DS.Tables[0].Rows[0]["kpi_objAgeProvRevDL"].ToString();
                            txtObjDespPTLDL.Text = DS.Tables[0].Rows[0]["kpi_objDespPTLDL"].ToString();
                            txtObjDispatchPTIDL.Text = DS.Tables[0].Rows[0]["kpi_objDespPTIDL"].ToString();
                            txtObjIndRotPTLDL.Text = DS.Tables[0].Rows[0]["kpi_objIndRotPTLDL"].ToString();
                            txtObjIndRotPTIDL.Text = DS.Tables[0].Rows[0]["kpi_objIndRotPTIDL"].ToString();
                            txtObjRecIngGdC.Text = DS.Tables[0].Rows[0]["kpi_objRecIngGdC"].ToString();
                            txtObjKgRecIngGdC.Text = DS.Tables[0].Rows[0]["kpi_objKgRecIngGdC"].ToString();
                            txtObjKgRecAprbGdC.Text = DS.Tables[0].Rows[0]["kpi_objRecAprbGdc"].ToString();
                            txtObjPorcRecAprbGdC.Text = DS.Tables[0].Rows[0]["kpi_objPorcRecAprb"].ToString();
                            txtObjDevIngBPTGdc.Text = DS.Tables[0].Rows[0]["kpi_objDevIngBPTGdc"].ToString();
                            txtSem1Prod.Text = DS.Tables[0].Rows[0]["kpi_prodExt"].ToString();
                            txtSem1Camb.Text = DS.Tables[0].Rows[0]["kpi_changes"].ToString();
                            txtSem1Merma.Text = DS.Tables[0].Rows[0]["kpi_scrap"].ToString();
                            txtSem1ConsRec.Text = DS.Tables[0].Rows[0]["kpi_recupCons"].ToString();
                            txtSem1PCP.Text = DS.Tables[0].Rows[0]["kpi_prodPrimary"].ToString();
                            txtSem1RepPromCP.Text = DS.Tables[0].Rows[0]["kpi_repProm"].ToString();
                            txtSem1MermCP.Text = DS.Tables[0].Rows[0]["kpi_scrapAtlas"].ToString();
                            txtSem1ProdGrlM.Text = DS.Tables[0].Rows[0]["kpi_prodGnrl"].ToString();
                            txtSem1CantBobM.Text = DS.Tables[0].Rows[0]["kpi_coilQuantity"].ToString();
                            txtSem1BobPromM.Text = DS.Tables[0].Rows[0]["kpi_coilProm"].ToString();
                            txtSem1MermGrlM.Text = DS.Tables[0].Rows[0]["kpi_scrapGnrl"].ToString();
                            txtSem1ProdMM.Text = DS.Tables[0].Rows[0]["kpi_prodMetal"].ToString();
                            txtSem1MermMM.Text = DS.Tables[0].Rows[0]["kpi_scrapMetal"].ToString();
                            txtSem1ProdCS.Text = DS.Tables[0].Rows[0]["kpi_prodSecund"].ToString();
                            txtSem1MermCS.Text = DS.Tables[0].Rows[0]["kpi_scrapSecun"].ToString();
                            txtSem1ProdLocDL.Text = DS.Tables[0].Rows[0]["kpi_invLocal"].ToString();
                            txtSem1InvRevDL.Text = DS.Tables[0].Rows[0]["kpi_invRev"].ToString();
                            txtSem1AgePromDL.Text = DS.Tables[0].Rows[0]["kpi_ageProm"].ToString();
                            txtSem1AgePromRev.Text = DS.Tables[0].Rows[0]["kpi_agePromRev"].ToString();
                            txtSem1DispPTL.Text = DS.Tables[0].Rows[0]["kpi_dispatchPTL"].ToString();
                            txtSem1DispPTI.Text = DS.Tables[0].Rows[0]["kpi_dispatchPTI"].ToString();
                            txtSem1IndRotPTL.Text = DS.Tables[0].Rows[0]["kpi_rotationPTL"].ToString();
                            txtSem1IndRotPTI.Text = DS.Tables[0].Rows[0]["kpi_rotationPTI"].ToString();
                            txtSem1RecIngGdc.Text = DS.Tables[0].Rows[0]["kpi_complaints"].ToString();
                            txtSem1KgRecIngGdC.Text = DS.Tables[0].Rows[0]["kpi_kgComplaints"].ToString();
                            txtSem1RecAprbGdc.Text = DS.Tables[0].Rows[0]["kpi_ApprvedComplaints"].ToString();
                            txtSem1KgRecAprb.Text = DS.Tables[0].Rows[0]["kpi_kgApprvComplaints"].ToString();

                            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 1)
                            {
                                //Semana 2.    

                                txtSem2Prod.Text = DS.Tables[0].Rows[1]["kpi_prodExt"].ToString();
                                txtSem2Camb.Text = DS.Tables[0].Rows[1]["kpi_changes"].ToString();
                                txtSem2Merma.Text = DS.Tables[0].Rows[1]["kpi_scrap"].ToString();
                                txtSem2ConsRec.Text = DS.Tables[0].Rows[1]["kpi_recupCons"].ToString();
                                txtSem2PCP.Text = DS.Tables[0].Rows[1]["kpi_prodPrimary"].ToString();
                                txtSem2RepPromCP.Text = DS.Tables[0].Rows[1]["kpi_repProm"].ToString();
                                txtSem2MermCP.Text = DS.Tables[0].Rows[1]["kpi_scrapAtlas"].ToString();
                                txtSem2ProdGrlM.Text = DS.Tables[0].Rows[1]["kpi_prodGnrl"].ToString();
                                txtSem2CantBobM.Text = DS.Tables[0].Rows[1]["kpi_coilQuantity"].ToString();
                                txtSem2BobPromM.Text = DS.Tables[0].Rows[1]["kpi_coilProm"].ToString();
                                txtSem2MermGrlM.Text = DS.Tables[0].Rows[1]["kpi_scrapGnrl"].ToString();
                                txtSem2ProdMM.Text = DS.Tables[0].Rows[1]["kpi_prodMetal"].ToString();
                                txtSem2MermMM.Text = DS.Tables[0].Rows[1]["kpi_scrapMetal"].ToString();
                                txtSem2ProdCS.Text = DS.Tables[0].Rows[1]["kpi_prodSecund"].ToString();
                                txtSem2MermCS.Text = DS.Tables[0].Rows[1]["kpi_scrapSecun"].ToString();
                                txtSem2ProdLocDL.Text = DS.Tables[0].Rows[1]["kpi_invLocal"].ToString();
                                txtSem2InvRevDL.Text = DS.Tables[0].Rows[1]["kpi_invRev"].ToString();
                                txtSem2AgePromDL.Text = DS.Tables[0].Rows[1]["kpi_ageProm"].ToString();
                                txtSem2AgePromRev.Text = DS.Tables[0].Rows[1]["kpi_agePromRev"].ToString();
                                txtSem2DispPTL.Text = DS.Tables[0].Rows[1]["kpi_dispatchPTL"].ToString();
                                txtSem2DispPTI.Text = DS.Tables[0].Rows[1]["kpi_dispatchPTI"].ToString();
                                txtSem2IndRotPTL.Text = DS.Tables[0].Rows[1]["kpi_rotationPTL"].ToString();
                                txtSem2IndRotPTI.Text = DS.Tables[0].Rows[1]["kpi_rotationPTI"].ToString();
                                txtSem2RecIngGdc.Text = DS.Tables[0].Rows[1]["kpi_complaints"].ToString();
                                txtSem2KgRecIngGdC.Text = DS.Tables[0].Rows[1]["kpi_kgComplaints"].ToString();
                                txtSem2RecAprbGdc.Text = DS.Tables[0].Rows[1]["kpi_ApprvedComplaints"].ToString();
                                txtSem2KgRecAprb.Text = DS.Tables[0].Rows[1]["kpi_kgApprvComplaints"].ToString();
    
                            }

                            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 2)
                            {
                                //Semana 3
                                txtSem3Prod.Text = DS.Tables[0].Rows[2]["kpi_prodExt"].ToString();
                                txtSem3Camb.Text = DS.Tables[0].Rows[2]["kpi_changes"].ToString();
                                txtSem3Merma.Text = DS.Tables[0].Rows[2]["kpi_scrap"].ToString();
                                txtSem3ConsRec.Text = DS.Tables[0].Rows[2]["kpi_recupCons"].ToString();
                                txtSem3PCP.Text = DS.Tables[0].Rows[2]["kpi_prodPrimary"].ToString();
                                txtSem3RepPromCP.Text = DS.Tables[0].Rows[2]["kpi_repProm"].ToString();
                                txtSem3MermCP.Text = DS.Tables[0].Rows[2]["kpi_scrapAtlas"].ToString();
                                txtSem3ProdGrlM.Text = DS.Tables[0].Rows[2]["kpi_prodGnrl"].ToString();
                                txtSem3CantBobM.Text = DS.Tables[0].Rows[2]["kpi_coilQuantity"].ToString();
                                txtSem3BobPromM.Text = DS.Tables[0].Rows[2]["kpi_coilProm"].ToString();
                                txtSem3MermGrlM.Text = DS.Tables[0].Rows[2]["kpi_scrapGnrl"].ToString();
                                txtSem3ProdMM.Text = DS.Tables[0].Rows[2]["kpi_prodMetal"].ToString();
                                txtSem3MermMM.Text = DS.Tables[0].Rows[2]["kpi_scrapMetal"].ToString();
                                txtSem3ProdCS.Text = DS.Tables[0].Rows[2]["kpi_prodSecund"].ToString();
                                txtSem3MermCS.Text = DS.Tables[0].Rows[2]["kpi_scrapSecun"].ToString();
                                txtSem3ProdLocDL.Text = DS.Tables[0].Rows[2]["kpi_invLocal"].ToString();
                                txtSem3InvRevDL.Text = DS.Tables[0].Rows[2]["kpi_invRev"].ToString();
                                txtSem3AgePromDL.Text = DS.Tables[0].Rows[2]["kpi_ageProm"].ToString();
                                txtSem3AgePromRev.Text = DS.Tables[0].Rows[2]["kpi_agePromRev"].ToString();
                                txtSem3DispPTL.Text = DS.Tables[0].Rows[2]["kpi_dispatchPTL"].ToString();
                                txtSem3DispPTI.Text = DS.Tables[0].Rows[2]["kpi_dispatchPTI"].ToString();
                                txtSem3IndRotPTL.Text = DS.Tables[0].Rows[2]["kpi_rotationPTL"].ToString();
                                txtSem3IndRotPTI.Text = DS.Tables[0].Rows[2]["kpi_rotationPTI"].ToString();
                                txtSem3RecIngGdc.Text = DS.Tables[0].Rows[2]["kpi_complaints"].ToString();
                                txtSem3KgRecIngGdC.Text = DS.Tables[0].Rows[2]["kpi_kgComplaints"].ToString();
                                txtSem3RecAprbGdc.Text = DS.Tables[0].Rows[2]["kpi_ApprvedComplaints"].ToString();
                                txtSem3KgRecAprb.Text = DS.Tables[0].Rows[2]["kpi_kgApprvComplaints"].ToString();
                            }

                            if (DS.Tables[0].Rows.Count > 3)
                            {
                                // Semana 4 
                                txtSem4Prod.Text = DS.Tables[0].Rows[3]["kpi_prodExt"].ToString();
                                txtSem4Camb.Text = DS.Tables[0].Rows[3]["kpi_changes"].ToString();
                                txtSem4Merma.Text = DS.Tables[0].Rows[3]["kpi_scrap"].ToString();
                                txtSem4ConsRec.Text = DS.Tables[0].Rows[3]["kpi_recupCons"].ToString();
                                txtSem4PCP.Text = DS.Tables[0].Rows[3]["kpi_prodPrimary"].ToString();
                                txtSem4RepPromCP.Text = DS.Tables[0].Rows[3]["kpi_repProm"].ToString();
                                txtSem4MermCP.Text = DS.Tables[0].Rows[3]["kpi_scrapAtlas"].ToString();
                                txtSem4ProdGrlM.Text = DS.Tables[0].Rows[3]["kpi_prodGnrl"].ToString();
                                txtSem4CantBobM.Text = DS.Tables[0].Rows[3]["kpi_coilQuantity"].ToString();
                                txtSem4BobPromM.Text = DS.Tables[0].Rows[3]["kpi_coilProm"].ToString();
                                txtSem4MermGrlM.Text = DS.Tables[0].Rows[3]["kpi_scrapGnrl"].ToString();
                                txtSem4ProdMM.Text = DS.Tables[0].Rows[3]["kpi_prodMetal"].ToString();
                                txtSem4MermMM.Text = DS.Tables[0].Rows[3]["kpi_scrapMetal"].ToString();
                                txtSem4ProdCS.Text = DS.Tables[0].Rows[3]["kpi_prodSecund"].ToString();
                                txtSem4MermCS.Text = DS.Tables[0].Rows[3]["kpi_scrapSecun"].ToString();
                                txtSem4ProdLocDL.Text = DS.Tables[0].Rows[3]["kpi_invLocal"].ToString();
                                txtSem4InvRevDL.Text = DS.Tables[0].Rows[3]["kpi_invRev"].ToString();
                                txtSem4AgePromDL.Text = DS.Tables[0].Rows[3]["kpi_ageProm"].ToString();
                                txtSem4AgePromRev.Text = DS.Tables[0].Rows[3]["kpi_agePromRev"].ToString();
                                txtSem4DispPTL.Text = DS.Tables[0].Rows[3]["kpi_dispatchPTL"].ToString();
                                txtSem4DispPTI.Text = DS.Tables[0].Rows[3]["kpi_dispatchPTI"].ToString();
                                txtSem4IndRotPTL.Text = DS.Tables[0].Rows[3]["kpi_rotationPTL"].ToString();
                                txtSem4IndRotPTI.Text = DS.Tables[0].Rows[3]["kpi_rotationPTI"].ToString();
                                txtSem4RecIngGdc.Text = DS.Tables[0].Rows[3]["kpi_complaints"].ToString();
                                txtSem4KgRecIngGdC.Text = DS.Tables[0].Rows[3]["kpi_kgComplaints"].ToString();
                                txtSem4RecAprbGdc.Text = DS.Tables[0].Rows[3]["kpi_ApprvedComplaints"].ToString();
                                txtSem4KgRecAprb.Text = DS.Tables[0].Rows[3]["kpi_kgApprvComplaints"].ToString();
                            }

                            if (DS.Tables[0].Rows.Count > 4)
                            {
                                // Semana 5
                                txtSem5Prod.Text = DS.Tables[0].Rows[4]["kpi_prodExt"].ToString();
                                txtSem5Camb.Text = DS.Tables[0].Rows[4]["kpi_changes"].ToString();
                                txtSem5Merma.Text = DS.Tables[0].Rows[4]["kpi_scrap"].ToString();
                                txtSem5ConsRec.Text = DS.Tables[0].Rows[4]["kpi_recupCons"].ToString();
                                txtSem5PCP.Text = DS.Tables[0].Rows[4]["kpi_prodPrimary"].ToString();
                                txtSem5RepPromCP.Text = DS.Tables[0].Rows[4]["kpi_repProm"].ToString();
                                txtSem5MermCP.Text = DS.Tables[0].Rows[4]["kpi_scrapAtlas"].ToString();
                                txtSem5ProdGrlM.Text = DS.Tables[0].Rows[4]["kpi_prodGnrl"].ToString();
                                txtSem5CantBobM.Text = DS.Tables[0].Rows[4]["kpi_coilQuantity"].ToString();
                                txtSem5BobPromM.Text = DS.Tables[0].Rows[4]["kpi_coilProm"].ToString();
                                txtSem5MermGrlM.Text = DS.Tables[0].Rows[4]["kpi_scrapGnrl"].ToString();
                                txtSem5ProdMM.Text = DS.Tables[0].Rows[4]["kpi_prodMetal"].ToString();
                                txtSem5MermMM.Text = DS.Tables[0].Rows[4]["kpi_scrapMetal"].ToString();
                                txtSem5ProdCS.Text = DS.Tables[0].Rows[4]["kpi_prodSecund"].ToString();
                                txtSem5MermCS.Text = DS.Tables[0].Rows[4]["kpi_scrapSecun"].ToString();
                                txtSem5ProdLocDL.Text = DS.Tables[0].Rows[4]["kpi_invLocal"].ToString();
                                txtSem5InvRevDL.Text = DS.Tables[0].Rows[4]["kpi_invRev"].ToString();
                                txtSem5AgePromDL.Text = DS.Tables[0].Rows[4]["kpi_ageProm"].ToString();
                                txtSem5AgePromRev.Text = DS.Tables[0].Rows[4]["kpi_agePromRev"].ToString();
                                txtSem5DispPTL.Text = DS.Tables[0].Rows[4]["kpi_dispatchPTL"].ToString();
                                txtSem5DispPTI.Text = DS.Tables[0].Rows[4]["kpi_dispatchPTI"].ToString();
                                txtSem5IndRotPTL.Text = DS.Tables[0].Rows[4]["kpi_rotationPTL"].ToString();
                                txtSem5IndRotPTI.Text = DS.Tables[0].Rows[4]["kpi_rotationPTI"].ToString();
                                txtSem5RecIngGdc.Text = DS.Tables[0].Rows[4]["kpi_complaints"].ToString();
                                txtSem5KgRecIngGdC.Text = DS.Tables[0].Rows[4]["kpi_kgComplaints"].ToString();
                                txtSem5RecAprbGdc.Text = DS.Tables[0].Rows[4]["kpi_ApprvedComplaints"].ToString();
                                txtSem5KgRecAprb.Text = DS.Tables[0].Rows[4]["kpi_kgApprvComplaints"].ToString();

                            }

                            if (DS.Tables[0].Rows.Count > 5)
                            {
                                // Semana 6 (Si existe.)
                                txtSem6Prod.Text = DS.Tables[0].Rows[4]["kpi_prodExt"].ToString();
                                txtSem6Camb.Text = DS.Tables[0].Rows[4]["kpi_changes"].ToString();
                                txtSem6Merma.Text = DS.Tables[0].Rows[4]["kpi_scrap"].ToString();
                                txtSem6ConsRec.Text = DS.Tables[0].Rows[4]["kpi_recupCons"].ToString();
                                txtSem6PCP.Text = DS.Tables[0].Rows[4]["kpi_prodPrimary"].ToString();
                                txtSem6RepPromCP.Text = DS.Tables[0].Rows[4]["kpi_repProm"].ToString();
                                txtSem6MermCP.Text = DS.Tables[0].Rows[4]["kpi_scrapAtlas"].ToString();
                                txtSem6ProdGrlM.Text = DS.Tables[0].Rows[4]["kpi_prodGnrl"].ToString();
                                txtSem6CantBobM.Text = DS.Tables[0].Rows[4]["kpi_coilQuantity"].ToString();
                                txtSem6BobPromM.Text = DS.Tables[0].Rows[4]["kpi_coilProm"].ToString();
                                txtSem6MermGrlM.Text = DS.Tables[0].Rows[4]["kpi_scrapGnrl"].ToString();
                                txtSem6ProdMM.Text = DS.Tables[0].Rows[4]["kpi_prodMetal"].ToString();
                                txtSem6MermMM.Text = DS.Tables[0].Rows[4]["kpi_scrapMetal"].ToString();
                                txtSem6ProdCS.Text = DS.Tables[0].Rows[4]["kpi_prodSecund"].ToString();
                                txtSem6MermCS.Text = DS.Tables[0].Rows[4]["kpi_scrapSecun"].ToString();
                                txtSem6ProdLocDL.Text = DS.Tables[0].Rows[4]["kpi_invLocal"].ToString();
                                txtSem6InvRevDL.Text = DS.Tables[0].Rows[4]["kpi_invRev"].ToString();
                                txtSem6AgePromDL.Text = DS.Tables[0].Rows[4]["kpi_ageProm"].ToString();
                                txtSem6AgePromRev.Text = DS.Tables[0].Rows[4]["kpi_agePromRev"].ToString();
                                txtSem6DispPTL.Text = DS.Tables[0].Rows[4]["kpi_dispatchPTL"].ToString();
                                txtSem6DispPTI.Text = DS.Tables[0].Rows[4]["kpi_dispatchPTI"].ToString();
                                txtSem6IndRotPTL.Text = DS.Tables[0].Rows[4]["kpi_rotationPTL"].ToString();
                                txtSem6IndRotPTI.Text = DS.Tables[0].Rows[4]["kpi_rotationPTI"].ToString();
                                txtSem6RecIngGdc.Text = DS.Tables[0].Rows[4]["kpi_complaints"].ToString();
                                txtSem6KgRecIngGdC.Text = DS.Tables[0].Rows[4]["kpi_kgComplaints"].ToString();
                                txtSem6RecAprbGdc.Text = DS.Tables[0].Rows[4]["kpi_ApprvedComplaints"].ToString();
                                txtSem6KgRecAprb.Text = DS.Tables[0].Rows[4]["kpi_kgApprvComplaints"].ToString();
                            }
                           

                            #endregion

                            CargarCharts();
                            this.Invoke(hideLoadImage);

                        }
                    }
                }
            }
        }
    

        #region Calcular Consumo Extrusión

        private double calculatingConsume(clsPlant plant, DateTime from, DateTime to)
        {

            DataSet InitMPDepot = new DataSet();
            DataSet RawIn = new DataSet();
            DataSet Mill = new DataSet();
            DataSet RawPosSwap = new DataSet();
            DataSet RawNegSwap = new DataSet();
            DataSet FinalMPDepot = new DataSet();

            InitMPDepot = clsConnection.getDataSetResult("CALL spDepotMPByDate('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawIn = clsConnection.getDataSetResult("CALL spRawInByDate('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            Mill = clsConnection.getDataSetResult("CALL spMillProductionTotalized('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawPosSwap = clsConnection.getDataSetResult("CALL spRawPosSwapByDate('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawNegSwap = clsConnection.getDataSetResult("CALL spRawNegSwapByDate('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            FinalMPDepot = clsConnection.getDataSetResult("CALL spDepotMPByDate('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");
              
            // Tengo que hacer esta funcion pero de manera mas resumida.

            double Total = Math.Round(Convert.ToDouble(InitMPDepot.Tables[0].Rows[0]["TotalDepot"]) +  Convert.ToDouble(RawIn.Tables[0].Rows[0]["IngTotal"]) + Convert.ToDouble(Mill.Tables[0].Rows[0]["ProdTotal"]) + Convert.ToDouble(RawPosSwap.Tables[0].Rows[0]["SwapTotal"]) - Convert.ToDouble(RawNegSwap.Tables[0].Rows[0]["SwapTotal"]) - Convert.ToDouble(FinalMPDepot.Tables[0].Rows[0]["TotalDepot"]),2);

            return Total;
        }

        #endregion

        #region Calcular Merma de Metalizado.
        
        private double calcularMermaM(string label1, string label2, clsPlant plant)
        {
            DataSet DS = new DataSet();
            double initbRack = 0;
            double cutterBmProd = 0;
            double bswappos = 0;
            double bpmswapneg = 0;
            double finalrack = 0;
            double metalized = 0;
            double finalScrap = 0;

            // Calculo todo lo de la semana 1.

            DS = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDate('" + label1 + "', " + plant.codsec.ToString() + ")");

            initbRack = (Convert.ToDouble(DS.Tables[0].Rows[0]["RackTotal"]) / 1000);

            DS = clsConnection.getDataSetResult("CALL spCuttingReportBMTotalized('" + label1 + "', '" +  label2 + "', " + plant.codsec.ToString() + ")");

            cutterBmProd = (Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000);

            DS = clsConnection.getDataSetResult("CALL spBPMPosSwapByDate '" + label1 + "', '" + label2 + "', " + plant.codsec.ToString() + ")");

            bswappos = Convert.ToDouble(DS.Tables[0].Rows[0]["SwapTotal"]);

            DS = clsConnection.getDataSetResult("CALL spBPMNegSwapByDate ('" + label1 + "', '" + label2 + "', " + plant.codsec.ToString() + ")");

            bpmswapneg = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["SwapTotal"]),2) / 1000;

            DS = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDate('" + label1 + "', " + plant.codsec.ToString() + ")");

            finalrack = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["RackTotal"]),2) / 1000;

            DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + label1 + "', '" + label2 + "', " + plant.codsec.ToString() + ")");

            metalized = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]),2) / 1000;

            return finalScrap = ((initbRack + cutterBmProd + bswappos - bpmswapneg - finalrack) - metalized);

            // Termino primer semana. 

        }
        
        #endregion

        #region Calcular Repeticiones promedio
        private double calcularReps(string label1, string label2, int primcutter, int seccutter)
        {

            DataSet DS = new DataSet();
            DataSet DS2 = new DataSet();
            double repprom = 0;
            double cantParadas = 0;
            double cantOrdCort = 0;
            double cantParadas2 = 0;
            double cantOrdCort2 = 0;

            
            DS = clsConnection.getDataSetResult("CALL spCuttingStopByDateAndMachine('" + label1 + "','" + label2 + "'," + primcutter + ")");
            cantParadas = Convert.ToDouble(DS.Tables[0].Rows[0]["cantParada"]);
            cantOrdCort = Convert.ToDouble(DS.Tables[0].Rows[0]["CantOrd"]);

            DS2 = clsConnection.getDataSetResult("CALL spCuttingStopByDateAndMachine('" + label1 + "','" + label2 + "'," + seccutter + ")");
            cantParadas2 = Convert.ToDouble(DS2.Tables[0].Rows[0]["cantParada"]);
            cantOrdCort2 = Convert.ToDouble(DS2.Tables[0].Rows[0]["CantOrd"]);

            if (cantOrdCort != 0 && cantOrdCort2 != 0)
            {
                repprom = (cantParadas + cantParadas2) / (cantOrdCort + cantOrdCort2);   
            }
            return repprom;

        }

        #endregion

        #region Conseguir Dias
        public static DateTime GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day == DayOfWeek.Monday)
            {
                time = time.AddDays(6);
            }
            else if (day == DayOfWeek.Tuesday)
            {
                time = time.AddDays(5);
            }
            else if (day == DayOfWeek.Wednesday)
            {
                time = time.AddDays(4);
            }
            else if (day == DayOfWeek.Thursday)
            {
                time = time.AddDays(3);
            }
            else if (day == DayOfWeek.Friday)
            {
                time = time.AddDays(2);
            }
            else if (day == DayOfWeek.Saturday)
            {
                time = time.AddDays(1);
            }

            return time;
        }
        #endregion

        #region Boton Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            DataSet DS = new DataSet();

            query = "SELECT * FROM bps_prod_kpis WHERE kpi_fkPlant = " + planta.codsec.ToString() + " AND kpi_date BETWEEN '" + lbl1.Text + "' AND '" + lbl10.Text + "' ORDER BY kpi_codsec ASC";
            DS = clsConnection.getDataSetResult(query);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem1Prod.Text + ",kpi_changes =" + txtSem1Camb.Text + ",kpi_scrap =" + txtSem1Merma.Text + ",kpi_recupCons = " + txtSem1ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem1PCP.Text + ",kpi_repProm =" + txtSem1RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem1MermCP.Text + ",kpi_prodGnrl=" + txtSem1ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem1CantBobM.Text + ",kpi_coilProm = " + txtSem1BobPromM.Text + ",kpi_scrapGnrl = " + txtSem1MermGrlM.Text + ",kpi_prodMetal =" + txtSem1ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem1MermMM.Text + ",kpi_prodSecund = " + txtSem1ProdCS.Text + ",kpi_scrapSecun =" + txtSem1MermCS.Text + ",kpi_invLocal =" + txtSem1ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem1InvRevDL.Text + ",kpi_ageProm =" + txtSem1AgePromDL.Text + ",kpi_agePromRev =" + txtSem1AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem1DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem1DispPTI.Text + ",kpi_rotationPTL = " + txtSem1IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem1IndRotPTI.Text + ",kpi_complaints = " + txtSem1RecIngGdc.Text;
                query += ",kpi_kgComplaints = " + txtSem1KgRecIngGdC.Text + ",kpi_ApprvedComplaints =" + txtSem1RecAprbGdc.Text + ",kpi_kgApprvComplaints =" + txtSem1KgRecAprb.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl1.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem2Prod.Text + ",kpi_changes =" + txtSem2Camb.Text + ",kpi_scrap =" + txtSem2Merma.Text + ",kpi_recupCons = " + txtSem2ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem2PCP.Text + ",kpi_repProm =" + txtSem2RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem2MermCP.Text + ",kpi_prodGnrl=" + txtSem2ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem2CantBobM.Text + ",kpi_coilProm = " + txtSem2BobPromM.Text + ",kpi_scrapGnrl = " + txtSem2MermGrlM.Text + ",kpi_prodMetal =" + txtSem2ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem2MermMM.Text + ",kpi_prodSecund = " + txtSem2ProdCS.Text + ",kpi_scrapSecun =" + txtSem2MermCS.Text + ",kpi_invLocal =" + txtSem2ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem2InvRevDL.Text + ",kpi_ageProm =" + txtSem2AgePromDL.Text + ",kpi_agePromRev =" + txtSem2AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem2DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem2DispPTI.Text + ",kpi_rotationPTL = " + txtSem2IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem2IndRotPTI.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl2.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem3Prod.Text + ",kpi_changes =" + txtSem3Camb.Text + ",kpi_scrap =" + txtSem3Merma.Text + ",kpi_recupCons = " + txtSem3ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem3PCP.Text + ",kpi_repProm =" + txtSem3RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem3MermCP.Text + ",kpi_prodGnrl=" + txtSem3ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem3CantBobM.Text + ",kpi_coilProm = " + txtSem3BobPromM.Text + ",kpi_scrapGnrl = " + txtSem3MermGrlM.Text + ",kpi_prodMetal =" + txtSem3ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem3MermMM.Text + ",kpi_prodSecund = " + txtSem3ProdCS.Text + ",kpi_scrapSecun =" + txtSem3MermCS.Text + ",kpi_invLocal =" + txtSem3ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem3InvRevDL.Text + ",kpi_ageProm =" + txtSem3AgePromDL.Text + ",kpi_agePromRev =" + txtSem3AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem3DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem3DispPTI.Text + ",kpi_rotationPTL = " + txtSem3IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem3IndRotPTI.Text + ",kpi_complaints = " + txtSem3RecIngGdc.Text;
                query += ",kpi_kgComplaints = " + txtSem3KgRecIngGdC.Text + ",kpi_ApprvedComplaints =" + txtSem3RecAprbGdc.Text + ",kpi_kgApprvComplaints =" + txtSem3KgRecAprb.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl3.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem4Prod.Text + ",kpi_changes =" + txtSem4Camb.Text + ",kpi_scrap =" + txtSem4Merma.Text + ",kpi_recupCons = " + txtSem4ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem4PCP.Text + ",kpi_repProm =" + txtSem4RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem4MermCP.Text + ",kpi_prodGnrl=" + txtSem4ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem4CantBobM.Text + ",kpi_coilProm = " + txtSem4BobPromM.Text + ",kpi_scrapGnrl = " + txtSem4MermGrlM.Text + ",kpi_prodMetal =" + txtSem4ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem4MermMM.Text + ",kpi_prodSecund = " + txtSem4ProdCS.Text + ",kpi_scrapSecun =" + txtSem4MermCS.Text + ",kpi_invLocal =" + txtSem4ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem4InvRevDL.Text + ",kpi_ageProm =" + txtSem4AgePromDL.Text + ",kpi_agePromRev =" + txtSem4AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem4DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem4DispPTI.Text + ",kpi_rotationPTL = " + txtSem4IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem4IndRotPTI.Text + ",kpi_complaints = " + txtSem4RecIngGdc.Text;
                query += ",kpi_kgComplaints = " + txtSem4KgRecIngGdC.Text + ",kpi_ApprvedComplaints =" + txtSem4RecAprbGdc.Text + ",kpi_kgApprvComplaints =" + txtSem4KgRecAprb.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl4.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem5Prod.Text + ",kpi_changes =" + txtSem5Camb.Text + ",kpi_scrap =" + txtSem5Merma.Text + ",kpi_recupCons = " + txtSem5ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem5PCP.Text + ",kpi_repProm =" + txtSem5RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem5MermCP.Text + ",kpi_prodGnrl=" + txtSem5ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem5CantBobM.Text + ",kpi_coilProm = " + txtSem5BobPromM.Text + ",kpi_scrapGnrl = " + txtSem5MermGrlM.Text + ",kpi_prodMetal =" + txtSem5ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem5MermMM.Text + ",kpi_prodSecund = " + txtSem5ProdCS.Text + ",kpi_scrapSecun =" + txtSem5MermCS.Text + ",kpi_invLocal =" + txtSem5ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem5InvRevDL.Text + ",kpi_ageProm =" + txtSem5AgePromDL.Text + ",kpi_agePromRev =" + txtSem5AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem5DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem5DispPTI.Text + ",kpi_rotationPTL = " + txtSem5IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem5IndRotPTI.Text + ",kpi_complaints = " + txtSem5RecIngGdc.Text;
                query += ",kpi_kgComplaints = " + txtSem5KgRecIngGdC.Text + ",kpi_ApprvedComplaints =" + txtSem5RecAprbGdc.Text + ",kpi_kgApprvComplaints =" + txtSem5KgRecAprb.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl5.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

                query = "UPDATE bps_prod_kpis"; // Terminar esto. 
                query += " SET kpi_prodExt =" + txtSem6Prod.Text + ",kpi_changes =" + txtSem6Camb.Text + ",kpi_scrap =" + txtSem6Merma.Text + ",kpi_recupCons = " + txtSem6ConsRec.Text;
                query += ",kpi_prodPrimary = " + txtSem6PCP.Text + ",kpi_repProm =" + txtSem6RepPromCP.Text + ",kpi_scrapAtlas =" + txtSem6MermCP.Text + ",kpi_prodGnrl=" + txtSem6ProdGrlM.Text;
                query += ",kpi_coilQuantity = " + txtSem6CantBobM.Text + ",kpi_coilProm = " + txtSem6BobPromM.Text + ",kpi_scrapGnrl = " + txtSem6MermGrlM.Text + ",kpi_prodMetal =" + txtSem6ProdMM.Text;
                query += ",kpi_scrapMetal = " + txtSem6MermMM.Text + ",kpi_prodSecund = " + txtSem6ProdCS.Text + ",kpi_scrapSecun =" + txtSem6MermCS.Text + ",kpi_invLocal =" + txtSem6ProdLocDL.Text;
                query += ",kpi_invRev =" + txtSem6InvRevDL.Text + ",kpi_ageProm =" + txtSem6AgePromDL.Text + ",kpi_agePromRev =" + txtSem6AgePromRev.Text + ",kpi_dispatchPTL =" + txtSem6DispPTL.Text;
                query += ",kpi_dispatchPTI = " + txtSem6DispPTI.Text + ",kpi_rotationPTL = " + txtSem6IndRotPTL.Text + ",kpi_rotationPTI = " + txtSem6IndRotPTI.Text + ",kpi_complaints = " + txtSem6RecIngGdc.Text;
                query += ",kpi_kgComplaints = " + txtSem6KgRecIngGdC.Text + ",kpi_ApprvedComplaints =" + txtSem6RecAprbGdc.Text + ",kpi_kgApprvComplaints =" + txtSem6KgRecAprb.Text + ",kpi_objProd = " + txtObjetivoProd.Text;
                query += ",kpi_objCamb = " + txtObjetivoCambios.Text + ",kpi_objEfiExt = " + txtObjetivoEf.Text + ",kpi_objPorcRecExt =" + txtObjetivoPorRecup.Text + ",kpi_objProdCP =" + txtObjProdCP.Text;
                query += ",kpi_objRepPromCP = " + txtObjRepPromCP.Text + ",kpi_objEfiCP =" + txtObjEfiCP.Text + ",kpi_objProdM = " + txtObjProdM.Text + ",kpi_objBProM =" + txtObjBPromM.Text + ",kpi_objEfiM =" + txtObjEfiM.Text;
                query += ",kpi_objProdMM =" + txtObjProdMM.Text + ",kpi_objProdCS =" + txtObjProdCS.Text + ",kpi_objEfiCS = " + txtObjEfiCS.Text + ",kpi_objOptRecCS = " + txtObjOptRecCS.Text + ",kpi_objPorcOP1CS =" + txtObjPorcOp1CS.Text;
                query += ",kpi_objPorcPPCS = " + txtObjPorcPPCS.Text + ",kpi_objProdLocDL = " + txtObjProdLocDL.Text + ",kpi_objInvRevDL = " + txtObjInvRevDL.Text + ",kpi_objAgePromLocDL = " + txtObjAgePromLocDL.Text;
                query += ",kpi_objAgeProvRevDL = " + txtObjAgePromRevDL.Text + ",kpi_objDespPTLDL = " + txtObjDespPTLDL.Text + ",kpi_objDespPTIDL = " + txtObjDispatchPTIDL.Text + ",kpi_objIndRotPTLDL = " + txtObjIndRotPTLDL.Text;
                query += ",kpi_objIndRotPTIDL = " + txtObjIndRotPTIDL.Text + ",kpi_objRecIngGdc = " + txtObjRecIngGdC.Text + ",kpi_objKgRecIngGdc = " + txtObjKgRecIngGdC.Text + ",kpi_objRecAprbGdc = " + txtObjRecAprbGdC.Text;
                query += ",kpi_objPorcRecAprb = " + txtObjPorcRecAprbGdC.Text + ",kpi_objDevIngBPTGdc = " + txtObjDevIngBPTGdc.Text + ",kpi_date ='" + lbl61.Text + "'" + ",kpi_fkPlant = " + planta.codsec.ToString();

                clsConnection.executeQuery(query);

            }
            else
            {
                 
                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem1Prod.Text + "," + txtSem1Camb.Text + "," + txtSem1Merma.Text + "," + txtSem1ConsRec.Text;
                query += "," + txtSem1PCP.Text + "," + txtSem1RepPromCP.Text + "," + txtSem1MermCP.Text + "," + txtSem1ProdGrlM.Text + "," + txtSem1CantBobM.Text + "," + txtSem1BobPromM.Text;
                query += "," + txtSem1MermGrlM.Text + "," + txtSem1ProdMM.Text + "," + txtSem1MermMM.Text + "," + txtSem1ProdCS.Text + "," + txtSem1MermCS.Text + "," + txtSem1ProdLocDL.Text;
                query += "," + txtSem1InvRevDL.Text + "," + txtSem1AgePromDL.Text + "," + txtSem1AgePromRev.Text + "," + txtSem1DispPTL.Text + "," + txtSem1DispPTI.Text + "," + txtSem1IndRotPTL.Text + "," + txtSem1IndRotPTI.Text;
                query += "," + txtSem1RecIngGdc.Text + "," + txtSem1KgRecIngGdC.Text + "," + txtSem1RecAprbGdc.Text + "," + txtSem1KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl1.Text + "'," + planta.codsec.ToString() + ")";

                clsConnection.executeQuery(query);

                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem2Prod.Text + "," + txtSem2Camb.Text + "," + txtSem2Merma.Text + "," + txtSem2ConsRec.Text;
                query += "," + txtSem2PCP.Text + "," + txtSem2RepPromCP.Text + "," + txtSem2MermCP.Text + "," + txtSem2ProdGrlM.Text + "," + txtSem2CantBobM.Text + "," + txtSem2BobPromM.Text;
                query += "," + txtSem2MermGrlM.Text + "," + txtSem2ProdMM.Text + "," + txtSem2MermMM.Text + "," + txtSem2ProdCS.Text + "," + txtSem2MermCS.Text + "," + txtSem2ProdLocDL.Text;
                query += "," + txtSem2InvRevDL.Text + "," + txtSem2AgePromDL.Text + "," + txtSem2AgePromRev.Text + "," + txtSem2DispPTL.Text + "," + txtSem2DispPTI.Text + "," + txtSem2IndRotPTL.Text + "," + txtSem2IndRotPTI.Text;
                query += "," + txtSem2RecIngGdc.Text + "," + txtSem2KgRecIngGdC.Text + "," + txtSem2RecAprbGdc.Text + "," + txtSem2KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl2.Text + "'," + planta.codsec.ToString() + ")";


                clsConnection.executeQuery(query);

                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem3Prod.Text + "," + txtSem3Camb.Text + "," + txtSem3Merma.Text + "," + txtSem3ConsRec.Text;
                query += "," + txtSem3PCP.Text + "," + txtSem3RepPromCP.Text + "," + txtSem3MermCP.Text + "," + txtSem3ProdGrlM.Text + "," + txtSem3CantBobM.Text + "," + txtSem3BobPromM.Text;
                query += "," + txtSem3MermGrlM.Text + "," + txtSem3ProdMM.Text + "," + txtSem3MermMM.Text + "," + txtSem3ProdCS.Text + "," + txtSem3MermCS.Text + "," + txtSem3ProdLocDL.Text;
                query += "," + txtSem3InvRevDL.Text + "," + txtSem3AgePromDL.Text + "," + txtSem3AgePromRev.Text + "," + txtSem3DispPTL.Text + "," + txtSem3DispPTI.Text + "," + txtSem3IndRotPTL.Text + "," + txtSem3IndRotPTI.Text;
                query += "," + txtSem3RecIngGdc.Text + "," + txtSem3KgRecIngGdC.Text + "," + txtSem3RecAprbGdc.Text + "," + txtSem3KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl3.Text + "'," + planta.codsec.ToString() + ")";

                clsConnection.executeQuery(query);

                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem4Prod.Text + "," + txtSem4Camb.Text + "," + txtSem4Merma.Text + "," + txtSem4ConsRec.Text;
                query += "," + txtSem4PCP.Text + "," + txtSem4RepPromCP.Text + "," + txtSem4MermCP.Text + "," + txtSem4ProdGrlM.Text + "," + txtSem4CantBobM.Text + "," + txtSem4BobPromM.Text;
                query += "," + txtSem4MermGrlM.Text + "," + txtSem4ProdMM.Text + "," + txtSem4MermMM.Text + "," + txtSem4ProdCS.Text + "," + txtSem4MermCS.Text + "," + txtSem4ProdLocDL.Text;
                query += "," + txtSem4InvRevDL.Text + "," + txtSem4AgePromDL.Text + "," + txtSem4AgePromRev.Text + "," + txtSem4DispPTL.Text + "," + txtSem4DispPTI.Text + "," + txtSem4IndRotPTL.Text + "," + txtSem4IndRotPTI.Text;
                query += "," + txtSem4RecIngGdc.Text + "," + txtSem4KgRecIngGdC.Text + "," + txtSem4RecAprbGdc.Text + "," + txtSem4KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl4.Text + "'," + planta.codsec.ToString() + ")";


                clsConnection.executeQuery(query);


                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem5Prod.Text + "," + txtSem5Camb.Text + "," + txtSem5Merma.Text + "," + txtSem5ConsRec.Text;
                query += "," + txtSem5PCP.Text + "," + txtSem5RepPromCP.Text + "," + txtSem5MermCP.Text + "," + txtSem5ProdGrlM.Text + "," + txtSem5CantBobM.Text + "," + txtSem5BobPromM.Text;
                query += "," + txtSem5MermGrlM.Text + "," + txtSem5ProdMM.Text + "," + txtSem5MermMM.Text + "," + txtSem5ProdCS.Text + "," + txtSem5MermCS.Text + "," + txtSem5ProdLocDL.Text;
                query += "," + txtSem5InvRevDL.Text + "," + txtSem5AgePromDL.Text + "," + txtSem5AgePromRev.Text + "," + txtSem5DispPTL.Text + "," + txtSem5DispPTI.Text + "," + txtSem5IndRotPTL.Text + "," + txtSem5IndRotPTI.Text;
                query += "," + txtSem5RecIngGdc.Text + "," + txtSem5KgRecIngGdC.Text + "," + txtSem5RecAprbGdc.Text + "," + txtSem5KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl5.Text + "'," + planta.codsec.ToString() + ")";

                clsConnection.executeQuery(query);

                query = "INSERT INTO bps_prod_kpis(kpi_prodExt,kpi_changes,kpi_scrap,kpi_recupCons,kpi_prodPrimary,kpi_repProm,kpi_scrapAtlas,kpi_prodGnrl,kpi_coilQuantity,kpi_coilProm,";
                query += "kpi_scrapGnrl,kpi_prodMetal,kpi_scrapMetal,kpi_prodSecund,kpi_scrapSecun,kpi_invLocal,kpi_invRev,kpi_ageProm,kpi_agePromRev,kpi_dispatchPTL,kpi_dispatchPTI,";
                query += "kpi_rotationPTL,kpi_rotationPTI,kpi_complaints,kpi_kgComplaints,kpi_ApprvedComplaints,kpi_kgApprvComplaints,kpi_objProd";
                query += ",kpi_objCamb,kpi_objEfiExt,kpi_objPorcRecExt,kpi_objProdCP,kpi_objRepPromCP,kpi_objEfiCP,kpi_objProdM,kpi_objBProM,kpi_objEfiM,kpi_objProdMM,kpi_objProdCS,kpi_objEfiCS,kpi_objOptRecCS,kpi_objPorcOP1CS";
                query += ",kpi_objPorcPPCS,kpi_objProdLocDL,kpi_objInvRevDL,kpi_objAgePromLocDL,kpi_objAgeProvRevDL,kpi_objDespPTLDL,kpi_objDespPTIDL,kpi_objIndRotPTLDL";
                query += ",kpi_objIndRotPTIDL,kpi_objRecIngGdc,kpi_objKgRecIngGdc,kpi_objRecAprbGdc,kpi_objPorcRecAprb,kpi_objDevIngBPTGdc,kpi_date,kpi_fkPlant)"; //28
                query += "VALUES(" + txtSem6Prod.Text + "," + txtSem6Camb.Text + "," + txtSem6Merma.Text + "," + txtSem6ConsRec.Text;
                query += "," + txtSem6PCP.Text + "," + txtSem6RepPromCP.Text + "," + txtSem6MermCP.Text + "," + txtSem6ProdGrlM.Text + "," + txtSem6CantBobM.Text + "," + txtSem6BobPromM.Text;
                query += "," + txtSem6MermGrlM.Text + "," + txtSem6ProdMM.Text + "," + txtSem6MermMM.Text + "," + txtSem6ProdCS.Text + "," + txtSem6MermCS.Text + "," + txtSem6ProdLocDL.Text;
                query += "," + txtSem6InvRevDL.Text + "," + txtSem6AgePromDL.Text + "," + txtSem6AgePromRev.Text + "," + txtSem6DispPTL.Text + "," + txtSem6DispPTI.Text + "," + txtSem6IndRotPTL.Text + "," + txtSem6IndRotPTI.Text;
                query += "," + txtSem6RecIngGdc.Text + "," + txtSem6KgRecIngGdC.Text + "," + txtSem6RecAprbGdc.Text + "," + txtSem6KgRecAprb.Text;
                query += "," + txtObjetivoProd.Text + "," + txtObjetivoCambios.Text + "," + txtObjetivoEf.Text + "," + txtObjetivoPorRecup.Text + "," + txtObjProdCP.Text + "," + txtObjRepPromCP.Text + "," + txtObjEfiCP.Text;
                query += "," + txtObjProdM.Text + "," + txtObjBPromM.Text + "," + txtObjEfiM.Text + "," + txtObjProdMM.Text + "," + txtObjProdCS.Text + "," + txtObjEfiCS.Text + "," + txtObjOptRecCS.Text + "," + txtObjPorcOp1CS.Text;
                query += "," + txtObjPorcPPCS.Text + "," + txtObjProdLocDL.Text + "," + txtObjInvRevDL.Text + "," + txtObjAgePromLocDL.Text + "," + txtObjAgePromRevDL.Text + "," + txtObjDespPTLDL.Text + "," + txtObjDispatchPTIDL.Text;
                query += "," + txtObjIndRotPTLDL.Text + "," + txtObjIndRotPTIDL.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecIngGdC.Text + "," + txtObjRecAprbGdC.Text + "," + txtObjPorcRecAprbGdC.Text + "," + txtObjDevIngBPTGdc.Text;
                query += ",'" + lbl61.Text + "'," + planta.codsec.ToString() + ")";

                clsConnection.executeQuery(query);
            }

        }

        #endregion

        #region Cargar Charts
        private void CargarCharts()
        {

            #region Cargo el chart de Extrusión
            string[] seriesArrayExt = { "Producción", "Cambios", "Lote Prom.", "Merma", "Consumo Recup" };
            double[] Semana1Ext = { Convert.ToDouble(txtSem1Prod.Text), Convert.ToDouble(txtSem1Camb.Text), Convert.ToDouble(txtSem1Lote.Text), Convert.ToDouble(txtSem1Merma.Text), Convert.ToDouble(txtSem1ConsRec.Text) };
            double[] Semana2Ext = { Convert.ToDouble(txtSem2Prod.Text), Convert.ToDouble(txtSem2Camb.Text), Convert.ToDouble(txtSem2Lote.Text), Convert.ToDouble(txtSem2Merma.Text), Convert.ToDouble(txtSem2ConsRec.Text) };
            double[] Semana3Ext = { Convert.ToDouble(txtSem3Prod.Text), Convert.ToDouble(txtSem3Camb.Text), Convert.ToDouble(txtSem3Lote.Text), Convert.ToDouble(txtSem3Merma.Text), Convert.ToDouble(txtSem3ConsRec.Text) };
            double[] Semana4Ext = { Convert.ToDouble(txtSem4Prod.Text), Convert.ToDouble(txtSem4Camb.Text), Convert.ToDouble(txtSem4Lote.Text), Convert.ToDouble(txtSem4Merma.Text), Convert.ToDouble(txtSem4ConsRec.Text) };
            double[] Semana5Ext = { Convert.ToDouble(txtSem5Prod.Text), Convert.ToDouble(txtSem5Camb.Text), Convert.ToDouble(txtSem5Lote.Text), Convert.ToDouble(txtSem5Merma.Text), Convert.ToDouble(txtSem5ConsRec.Text) };

            for (int i = 0; i < seriesArrayExt.Length; i++)
            {
                chrExt.Series.Add(seriesArrayExt[i]);
                chrExt.Series[i].Points.Add(Semana1Ext[i]);
                chrExt.Series[i].Points.Add(Semana2Ext[i]);
                chrExt.Series[i].Points.Add(Semana3Ext[i]);
                chrExt.Series[i].Points.Add(Semana4Ext[i]);
                chrExt.Series[i].Points.Add(Semana5Ext[i]);

                this.chrExt.Legends.Add(seriesArrayExt[i].ToString());
                chrExt.Legends[i].Docking = Docking.Top;
                chrExt.Legends[i].Alignment = StringAlignment.Center;
                chrExt.Legends[i].MaximumAutoSize = 15;
            }

            #endregion

            #region Cargo el Chart de Corte Primario

            string[] seriesArrayCP = { "Producción CP", "Rep. Promeido", "Merma" };
            double[] Semana1CP = { Convert.ToDouble(txtSem1PCP.Text), Convert.ToDouble(txtSem1RepPromCP.Text), Convert.ToDouble(txtSem1MermCP.Text) };
            double[] Semana2CP = { Convert.ToDouble(txtSem2PCP.Text), Convert.ToDouble(txtSem2RepPromCP.Text), Convert.ToDouble(txtSem2MermCP.Text) };
            double[] Semana3CP = { Convert.ToDouble(txtSem3PCP.Text), Convert.ToDouble(txtSem3RepPromCP.Text), Convert.ToDouble(txtSem3MermCP.Text) };
            double[] Semana4CP = { Convert.ToDouble(txtSem4PCP.Text), Convert.ToDouble(txtSem4RepPromCP.Text), Convert.ToDouble(txtSem4MermCP.Text) };
            double[] Semana5CP = { Convert.ToDouble(txtSem5PCP.Text), Convert.ToDouble(txtSem5RepPromCP.Text), Convert.ToDouble(txtSem5MermCP.Text) };
            double[] Semana6CP = { Convert.ToDouble(txtSem6PCP.Text), Convert.ToDouble(txtSem6RepPromCP.Text), Convert.ToDouble(txtSem6MermCP.Text) };

            for (int i = 0; i < seriesArrayCP.Length; i++)
            {
                chrCP.Series.Add(seriesArrayCP[i]);
                chrCP.Series[i].Points.Add(Semana1CP[i]);
                chrCP.Series[i].Points.Add(Semana2CP[i]);
                chrCP.Series[i].Points.Add(Semana3CP[i]);
                chrCP.Series[i].Points.Add(Semana4CP[i]);
                chrCP.Series[i].Points.Add(Semana5CP[i]);

                this.chrCP.Legends.Add(seriesArrayCP[i].ToString());
                chrCP.Legends[i].Docking = Docking.Top;
                chrCP.Legends[i].Alignment = StringAlignment.Center;
                chrCP.Legends[i].MaximumAutoSize = 15;
            }

            #endregion

            #region Cargo el Chart de Metalizado

            string[] seriesArrayMetalizado = { "Producción Met.", "Cant. Bobinas", "Merma Gnrl", "Producción Metal", "Merma Metal" };
            double[] Semana1Met = { Convert.ToDouble(txtSem1ProdGrlM.Text), Convert.ToDouble(txtSem1CantBobM.Text), Convert.ToDouble(txtSem1MermGrlM.Text), Convert.ToDouble(txtSem1ProdMM.Text), Convert.ToDouble(txtSem1MermMM.Text) };
            double[] Semana2Met = { Convert.ToDouble(txtSem2ProdGrlM.Text), Convert.ToDouble(txtSem2CantBobM.Text), Convert.ToDouble(txtSem2MermGrlM.Text), Convert.ToDouble(txtSem2ProdMM.Text), Convert.ToDouble(txtSem2MermMM.Text) };
            double[] Semana3Met = { Convert.ToDouble(txtSem3ProdGrlM.Text), Convert.ToDouble(txtSem3CantBobM.Text), Convert.ToDouble(txtSem3MermGrlM.Text), Convert.ToDouble(txtSem3ProdMM.Text), Convert.ToDouble(txtSem3MermMM.Text) };
            double[] Semana4Met = { Convert.ToDouble(txtSem4ProdGrlM.Text), Convert.ToDouble(txtSem4CantBobM.Text), Convert.ToDouble(txtSem4MermGrlM.Text), Convert.ToDouble(txtSem4ProdMM.Text), Convert.ToDouble(txtSem4MermMM.Text) };
            double[] Semana5Met = { Convert.ToDouble(txtSem5ProdGrlM.Text), Convert.ToDouble(txtSem5CantBobM.Text), Convert.ToDouble(txtSem5MermGrlM.Text), Convert.ToDouble(txtSem5ProdMM.Text), Convert.ToDouble(txtSem5MermMM.Text) };
            double[] Semana6Met = { Convert.ToDouble(txtSem6ProdGrlM.Text), Convert.ToDouble(txtSem6CantBobM.Text), Convert.ToDouble(txtSem6MermGrlM.Text), Convert.ToDouble(txtSem6ProdMM.Text), Convert.ToDouble(txtSem6MermMM.Text) };

            for (int i = 0; i < seriesArrayMetalizado.Length; i++)
            {
                chrMet.Series.Add(seriesArrayMetalizado[i]);
                chrMet.Series[i].Points.Add(Semana1Met[i]);
                chrMet.Series[i].Points.Add(Semana2Met[i]);
                chrMet.Series[i].Points.Add(Semana3Met[i]);
                chrMet.Series[i].Points.Add(Semana4Met[i]);
                chrMet.Series[i].Points.Add(Semana5Met[i]);
                chrMet.Series[i].Points.Add(Semana6Met[i]);

                this.chrMet.Legends.Add(seriesArrayMetalizado[i].ToString());
                chrMet.Legends[i].Docking = Docking.Top;
                chrMet.Legends[i].Alignment = StringAlignment.Center;
                chrMet.Legends[i].MaximumAutoSize = 15;
            }

            #endregion

            #region Cargo el Chart de Corte Secundario.

            string[] SeriesArrayCS = { "Producción", "Merma" };
            double[] Semana1CS = { Convert.ToDouble(txtSem1ProdCS.Text), Convert.ToDouble(txtSem1MermCS.Text) };
            double[] Semana2CS = { Convert.ToDouble(txtSem2ProdCS.Text), Convert.ToDouble(txtSem2MermCS.Text), Convert.ToDouble(txtSem2TotMermP2CS.Text), Convert.ToDouble(txtSem2OptRecCS.Text), Convert.ToDouble(txtSem2ProdOp1CS.Text), Convert.ToDouble(txtSem2ProdPPCS.Text) };
            double[] Semana3CS = { Convert.ToDouble(txtSem3ProdCS.Text), Convert.ToDouble(txtSem3MermCS.Text), Convert.ToDouble(txtSem3TotMermP2CS.Text), Convert.ToDouble(txtSem3OptRecCS.Text), Convert.ToDouble(txtSem3ProdOp1CS.Text), Convert.ToDouble(txtSem3ProdPPCS.Text) };
            double[] Semana4CS = { Convert.ToDouble(txtSem4ProdCS.Text), Convert.ToDouble(txtSem4MermCS.Text), Convert.ToDouble(txtSem4TotMermP2CS.Text), Convert.ToDouble(txtSem4OptRecCS.Text), Convert.ToDouble(txtSem4ProdOp1CS.Text), Convert.ToDouble(txtSem4ProdPPCS.Text) };
            double[] Semana5CS = { Convert.ToDouble(txtSem5ProdCS.Text), Convert.ToDouble(txtSem5MermCS.Text), Convert.ToDouble(txtSem5TotMermP2CS.Text), Convert.ToDouble(txtSem5OptRecCS.Text), Convert.ToDouble(txtSem5ProdOp1CS.Text), Convert.ToDouble(txtSem5ProdPPCS.Text) };
            double[] Semana6CS = { Convert.ToDouble(txtSem6ProdCS.Text), Convert.ToDouble(txtSem6MermCS.Text), Convert.ToDouble(txtSem6TotMermP2CS.Text), Convert.ToDouble(txtSem6OptRecCS.Text), Convert.ToDouble(txtSem6ProdOp1CS.Text), Convert.ToDouble(txtSem6ProdPPCS.Text) };

            for (int i = 0; i < SeriesArrayCS.Length; i++)
            {
                chrCS.Series.Add(SeriesArrayCS[i]);
                chrCS.Series[i].Points.Add(Semana1CS[i]);
                chrCS.Series[i].Points.Add(Semana2CS[i]);
                chrCS.Series[i].Points.Add(Semana3CS[i]);
                chrCS.Series[i].Points.Add(Semana4CS[i]);
                chrCS.Series[i].Points.Add(Semana5CS[i]);
                chrCS.Series[i].Points.Add(Semana6CS[i]);

                this.chrCS.Legends.Add(SeriesArrayCS[i].ToString());
                chrCS.Legends[i].Docking = Docking.Top;
                chrCS.Legends[i].Alignment = StringAlignment.Center;
                chrCS.Legends[i].MaximumAutoSize = 15;
            }

            #endregion

            #region Cargo el Chart de Logistica.

            string[] SeriesArrayDL = { "Inv.Prod Local", "Inv. Reventa", "Total Inv.", "Edad Prom. Local", "Edad Prom. Reventa", "Despachos PTL", "Despachos PTI", "Indice Rotacion PTL", "Indice Rotacion PTI" };
            double[] Semana1DL = { Convert.ToDouble(txtSem1ProdLocDL.Text), Convert.ToDouble(txtSem1InvRevDL.Text), Convert.ToDouble(txtSem1TotInvDL.Text), Convert.ToDouble(txtSem1AgePromDL.Text), Convert.ToDouble(txtSem1AgePromRev.Text), Convert.ToDouble(txtSem1DispPTL.Text), Convert.ToDouble(txtSem1DispPTI.Text), Convert.ToDouble(txtSem1IndRotPTL.Text), Convert.ToDouble(txtSem1IndRotPTI.Text) };
            double[] Semana2DL = { Convert.ToDouble(txtSem2ProdLocDL.Text), Convert.ToDouble(txtSem2InvRevDL.Text), Convert.ToDouble(txtSem2TotInvDL.Text), Convert.ToDouble(txtSem2AgePromDL.Text), Convert.ToDouble(txtSem2AgePromRev.Text), Convert.ToDouble(txtSem2DispPTL.Text), Convert.ToDouble(txtSem2DispPTI.Text), Convert.ToDouble(txtSem2IndRotPTL.Text), Convert.ToDouble(txtSem2IndRotPTI.Text) };
            double[] Semana3DL = { Convert.ToDouble(txtSem3ProdLocDL.Text), Convert.ToDouble(txtSem3InvRevDL.Text), Convert.ToDouble(txtSem3TotInvDL.Text), Convert.ToDouble(txtSem3AgePromDL.Text), Convert.ToDouble(txtSem3AgePromRev.Text), Convert.ToDouble(txtSem3DispPTL.Text), Convert.ToDouble(txtSem3DispPTI.Text), Convert.ToDouble(txtSem3IndRotPTL.Text), Convert.ToDouble(txtSem3IndRotPTI.Text) };
            double[] Semana4DL = { Convert.ToDouble(txtSem4ProdLocDL.Text), Convert.ToDouble(txtSem4InvRevDL.Text), Convert.ToDouble(txtSem4TotInvDL.Text), Convert.ToDouble(txtSem4AgePromDL.Text), Convert.ToDouble(txtSem4AgePromRev.Text), Convert.ToDouble(txtSem4DispPTL.Text), Convert.ToDouble(txtSem4DispPTI.Text), Convert.ToDouble(txtSem4IndRotPTL.Text), Convert.ToDouble(txtSem4IndRotPTI.Text) };
            double[] Semana5DL = { Convert.ToDouble(txtSem5ProdLocDL.Text), Convert.ToDouble(txtSem5InvRevDL.Text), Convert.ToDouble(txtSem5TotInvDL.Text), Convert.ToDouble(txtSem5AgePromDL.Text), Convert.ToDouble(txtSem5AgePromRev.Text), Convert.ToDouble(txtSem5DispPTL.Text), Convert.ToDouble(txtSem5DispPTI.Text), Convert.ToDouble(txtSem5IndRotPTL.Text), Convert.ToDouble(txtSem5IndRotPTI.Text) };
            double[] Semana6DL = { Convert.ToDouble(txtSem6ProdLocDL.Text), Convert.ToDouble(txtSem6InvRevDL.Text), Convert.ToDouble(txtSem6TotInvDL.Text), Convert.ToDouble(txtSem6AgePromDL.Text), Convert.ToDouble(txtSem6AgePromRev.Text), Convert.ToDouble(txtSem6DispPTL.Text), Convert.ToDouble(txtSem6DispPTI.Text), Convert.ToDouble(txtSem6IndRotPTL.Text), Convert.ToDouble(txtSem6IndRotPTI.Text) };

            for (int i = 0; i < SeriesArrayDL.Length; i++)
            {
                chrDL.Series.Add(SeriesArrayDL[i]);
                chrDL.Series[i].Points.Add(Semana1DL[i]);
                chrDL.Series[i].Points.Add(Semana2DL[i]);
                chrDL.Series[i].Points.Add(Semana3DL[i]);
                chrDL.Series[i].Points.Add(Semana4DL[i]);
                chrDL.Series[i].Points.Add(Semana5DL[i]);
                chrDL.Series[i].Points.Add(Semana6DL[i]);

                this.chrDL.Legends.Add(SeriesArrayDL[i].ToString());
                chrDL.Legends[i].Docking = Docking.Top;
                chrDL.Legends[i].Alignment = StringAlignment.Center;
                chrDL.Legends[i].MaximumAutoSize = 15;
            }

            #endregion

            #region Chart Totales 
            string[] SeriesArrayTotPlanta = { "Tot. Merma P2", "Optim. uso Recup.", "Produccion Op1", "Producción PP" };
            double[] Semana1TotPlanta = { Convert.ToDouble(txtSem1TotMermP2CS.Text), Convert.ToDouble(txtSem1OptRecCS.Text), Convert.ToDouble(txtSem1ProdOp1CS.Text), Convert.ToDouble(txtSem1ProdPPCS.Text) };
            double[] Semana2TotPlanta = { Convert.ToDouble(txtSem2TotMermP2CS.Text), Convert.ToDouble(txtSem2OptRecCS.Text), Convert.ToDouble(txtSem2ProdOp1CS.Text), Convert.ToDouble(txtSem2ProdPPCS.Text) };
            double[] Semana3TotPlanta = { Convert.ToDouble(txtSem3TotMermP2CS.Text), Convert.ToDouble(txtSem3OptRecCS.Text), Convert.ToDouble(txtSem3ProdOp1CS.Text), Convert.ToDouble(txtSem3ProdPPCS.Text) };
            double[] Semana4TotPlanta = { Convert.ToDouble(txtSem4TotMermP2CS.Text), Convert.ToDouble(txtSem4OptRecCS.Text), Convert.ToDouble(txtSem4ProdOp1CS.Text), Convert.ToDouble(txtSem4ProdPPCS.Text) };
            double[] Semana5TotPlanta = { Convert.ToDouble(txtSem5TotMermP2CS.Text), Convert.ToDouble(txtSem5OptRecCS.Text), Convert.ToDouble(txtSem5ProdOp1CS.Text), Convert.ToDouble(txtSem5ProdPPCS.Text) };
            double[] Semana6TotPlanta = { Convert.ToDouble(txtSem6TotMermP2CS.Text), Convert.ToDouble(txtSem6OptRecCS.Text), Convert.ToDouble(txtSem6ProdOp1CS.Text), Convert.ToDouble(txtSem6ProdPPCS.Text) };

            for (int i = 0; i < SeriesArrayTotPlanta.Length; i++)
            {
                chrTotPlanta.Series.Add(SeriesArrayTotPlanta[i]);
                chrTotPlanta.Series[i].Points.Add(Semana1TotPlanta[i]);
                chrTotPlanta.Series[i].Points.Add(Semana2TotPlanta[i]);
                chrTotPlanta.Series[i].Points.Add(Semana3TotPlanta[i]);
                chrTotPlanta.Series[i].Points.Add(Semana4TotPlanta[i]);
                chrTotPlanta.Series[i].Points.Add(Semana5TotPlanta[i]);

                this.chrTotPlanta.Legends.Add(SeriesArrayTotPlanta[i].ToString());
                chrTotPlanta.Legends[i].Docking = Docking.Top;
                chrTotPlanta.Legends[i].Alignment = StringAlignment.Center;
                chrTotPlanta.Legends[i].MaximumAutoSize = 15;
            }


            #endregion

        }
        #endregion

        #region Calcular Fechas.
        private void calculoDeFecha()
        {
            DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
            Calendar calendar = info.Calendar;
            if (cmbMes.SelectedIndex < 9)
            {
                lbl1.Text = "01/" + "0" + (Convert.ToInt32(cmbMes.SelectedIndex) + 1).ToString() + "/" + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                lbl11.Text = lbl1.Text;
                lbl21.Text = lbl1.Text;
                lbl31.Text = lbl1.Text;
                lbl41.Text = lbl1.Text;
                lbl51.Text = lbl1.Text;
                lbl71.Text = lbl1.Text;
            }
            else
            {
                lbl1.Text = "01/" + (Convert.ToInt32(cmbMes.SelectedIndex) + 1).ToString() + "/" + cmbYear.Items[cmbYear.SelectedIndex].ToString();
                lbl11.Text = lbl1.Text;
                lbl21.Text = lbl1.Text;
                lbl31.Text = lbl1.Text;
                lbl41.Text = lbl1.Text;
                lbl51.Text = lbl1.Text;
                lbl71.Text = lbl1.Text;
            }
            
            lblSem1Ext.Text = calendar.GetWeekOfYear(Convert.ToDateTime(lbl1.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            lblSem1CP.Text = lblSem1Ext.Text;
            lblSem1CS.Text = lblSem1Ext.Text;
            lblSem1DL.Text = lblSem1Ext.Text;
            lblSem1GdL.Text = lblSem1Ext.Text;
            lblSem1Met.Text = lblSem1Ext.Text;
            lblSem1TotPlant.Text = lblSem1Ext.Text;
            
        }

        private void lblSem1Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem1Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl1.Text);
                int sem = Convert.ToInt32(lblSem1Ext.Text);

                while (sem == Convert.ToInt32(lblSem1Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl2.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl12.Text = lbl2.Text;
                lbl22.Text = lbl2.Text;
                lbl32.Text = lbl2.Text;
                lbl42.Text = lbl2.Text;
                lbl52.Text = lbl2.Text;
                lbl72.Text = lbl2.Text;
                lbl3.Text = fec.ToString("dd/MM/yyyy");
                lbl13.Text = lbl3.Text;
                lbl23.Text = lbl3.Text;
                lbl33.Text = lbl3.Text;
                lbl43.Text = lbl3.Text;
                lbl53.Text = lbl3.Text;
                lbl73.Text = lbl3.Text;
            }
        }
    

        private void lbl3_TextChanged(object sender, EventArgs e)
        {
            if (lbl3.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                lblSem2Ext.Text = cal.GetWeekOfYear(Convert.ToDateTime(lbl3.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
                lblSem2CP.Text = lblSem2Ext.Text;
                lblSem2CS.Text = lblSem2Ext.Text;
                lblSem2DL.Text = lblSem2Ext.Text;
                lblSem2GdL.Text = lblSem2Ext.Text;
                lblSem2Met.Text = lblSem2Ext.Text;
                lblSem2TotPlant.Text = lblSem2Ext.Text;
            }
        }

        private void lblSem2Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem2Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl3.Text);
                int sem = Convert.ToInt32(lblSem2Ext.Text);
                while (sem == Convert.ToInt32(lblSem2Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl4.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl14.Text = lbl4.Text;
                lbl24.Text = lbl4.Text;
                lbl34.Text = lbl4.Text;
                lbl44.Text = lbl4.Text;
                lbl54.Text = lbl4.Text;
                lbl74.Text = lbl4.Text;
                lbl5.Text = fec.ToString("dd/MM/yyyy");
                lbl15.Text = lbl5.Text;
                lbl25.Text = lbl5.Text;
                lbl35.Text = lbl5.Text;
                lbl45.Text = lbl5.Text;
                lbl55.Text = lbl5.Text;
                lbl75.Text = lbl5.Text;
            }
        }

        private void lbl5_TextChanged(object sender, EventArgs e)
        {
            if (lbl5.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                lblSem3Ext.Text = cal.GetWeekOfYear(Convert.ToDateTime(lbl5.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
                lblSem3CP.Text = lblSem3Ext.Text;
                lblSem3CS.Text = lblSem3Ext.Text;
                lblSem3DL.Text = lblSem3Ext.Text;
                lblSem3GdL.Text = lblSem3Ext.Text;
                lblSem3Met.Text = lblSem3Ext.Text;
                lblSem3TotPlant.Text = lblSem3Ext.Text;
            }
        }

        private void lblSem3Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem3Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl5.Text);
                int sem = Convert.ToInt32(lblSem3Ext.Text);
                while (sem == Convert.ToInt32(lblSem3Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl6.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl16.Text = lbl6.Text;
                lbl26.Text = lbl6.Text;
                lbl36.Text = lbl6.Text;
                lbl46.Text = lbl6.Text;
                lbl56.Text = lbl6.Text;
                lbl76.Text = lbl6.Text;
                lbl7.Text = fec.ToString("dd/MM/yyyy");
                lbl17.Text = lbl7.Text;
                lbl27.Text = lbl7.Text;
                lbl37.Text = lbl7.Text;
                lbl47.Text = lbl7.Text;
                lbl57.Text = lbl7.Text;
                lbl77.Text = lbl7.Text;
            }
        }

        private void lbl7_TextChanged(object sender, EventArgs e)
        {
            if (lbl7.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                lblSem4Ext.Text = cal.GetWeekOfYear(Convert.ToDateTime(lbl7.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
                lblSem4CP.Text = lblSem4Ext.Text;
                lblSem4CS.Text = lblSem4Ext.Text;
                lblSem4DL.Text = lblSem4Ext.Text;
                lblSem4GdL.Text = lblSem4Ext.Text;
                lblSem4Met.Text = lblSem4Ext.Text;
                lblSem4TotPlant.Text = lblSem4Ext.Text;
            }
        }

        private void lblSem4Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem4Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl7.Text);
                int sem = Convert.ToInt32(lblSem4Ext.Text);
                while (sem == Convert.ToInt32(lblSem4Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl8.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl18.Text = lbl8.Text;
                lbl28.Text = lbl8.Text;
                lbl38.Text = lbl8.Text;
                lbl48.Text = lbl8.Text;
                lbl58.Text = lbl8.Text;
                lbl78.Text = lbl8.Text;
                lbl9.Text = fec.ToString("dd/MM/yyyy");
                lbl19.Text = lbl9.Text;
                lbl29.Text = lbl9.Text;
                lbl39.Text = lbl9.Text;
                lbl49.Text = lbl9.Text;
                lbl59.Text = lbl9.Text;
                lbl79.Text = lbl9.Text;
            }
        }

        private void lbl9_TextChanged(object sender, EventArgs e)
        {
            if (lbl9.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                lblSem5Ext.Text =  cal.GetWeekOfYear(Convert.ToDateTime(lbl9.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
                lblSem5CP.Text = lblSem5Ext.Text;
                lblSem5CS.Text = lblSem5Ext.Text;
                lblSem5DL.Text = lblSem5Ext.Text;
                lblSem5GdL.Text = lblSem5Ext.Text;
                lblSem5Met.Text = lblSem5Ext.Text;
                lblSem5TotPlant.Text = lblSem5Ext.Text;
            }
        }

        private void lblSem5Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem5Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl9.Text);
                int sem = Convert.ToInt32(lblSem5Ext.Text);
                while (sem == Convert.ToInt32(lblSem5Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl10.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl110.Text = lbl10.Text;
                lbl210.Text = lbl10.Text;
                lbl310.Text = lbl10.Text;
                lbl410.Text = lbl10.Text;
                lbl510.Text = lbl10.Text;
                lbl710.Text = lbl10.Text;

                if ((Convert.ToInt32(cmbMes.SelectedIndex)+1)==fec.Month)
                {
                    lbl61.Text = fec.ToString("dd/MM/yyyy");
                    lbl63.Text = fec.ToString("dd/MM/yyyy");
                    lbl65.Text = fec.ToString("dd/MM/yyyy");
                    lbl67.Text = fec.ToString("dd/MM/yyyy");
                    lbl69.Text = fec.ToString("dd/MM/yyyy");
                    lbl611.Text = fec.ToString("dd/MM/yyyy");
                    lbl711.Text = fec.ToString("dd/MM/yyyy");
                    lblAExt.Text = "a";
                    lblACP.Text = lblAExt.Text;
                    lblACS.Text = lblAExt.Text;
                    lblADL.Text = lblAExt.Text;
                    lblAGdL.Text = lblAExt.Text;
                    lblAMet.Text = lblAExt.Text;
                }
                else
                {
                    lblSem6Ext.Text = string.Empty;
                    lblSem6CP.Text = string.Empty;
                    lblSem6CS.Text = string.Empty;
                    lblSem6DL.Text = string.Empty;
                    lblSem6GdL.Text = string.Empty;
                    lblSem6Met.Text = string.Empty;
                    lblSem6TotPlant.Text = string.Empty;
                    lbl61.Text = string.Empty;
                    lbl62.Text = string.Empty;
                    lbl63.Text = string.Empty;
                    lbl64.Text = string.Empty;
                    lbl65.Text = string.Empty;
                    lbl66.Text = string.Empty;
                    lbl67.Text = string.Empty;
                    lbl68.Text = string.Empty;
                    lbl69.Text = string.Empty;
                    lbl610.Text = string.Empty;
                    lbl611.Text = string.Empty;
                    lbl612.Text = string.Empty;
                    lbl711.Text = string.Empty;
                    lbl712.Text = string.Empty;
                    label63.Text = string.Empty;
                    lblAExt.Text = string.Empty;
                    lblACP.Text = string.Empty;
                    lblACS.Text = string.Empty;
                    lblADL.Text = string.Empty;
                    lblAGdL.Text = string.Empty;
                    lblAMet.Text = string.Empty;
                }
            }
        }

        private void lbl61_TextChanged(object sender, EventArgs e)
        {
            if (lbl61.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                lblSem6Ext.Text = cal.GetWeekOfYear(Convert.ToDateTime(lbl61.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
                lblSem6CP.Text = lblSem6Ext.Text;
                lblSem6CS.Text = lblSem6Ext.Text;
                lblSem6DL.Text = lblSem6Ext.Text;
                lblSem6GdL.Text = lblSem6Ext.Text;
                lblSem6Met.Text = lblSem6Ext.Text;
                lblSem6TotPlant.Text = lblSem6Ext.Text;
            }
        }

        private void lblSem6Ext_TextChanged(object sender, EventArgs e)
        {
            if (lblSem6Ext.Text != string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(lbl61.Text);
                int sem = Convert.ToInt32(lblSem6Ext.Text);
                while (sem == Convert.ToInt32(lblSem6Ext.Text) && (Convert.ToInt32(cmbMes.SelectedIndex.ToString()) + 1) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                lbl62.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl64.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl66.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl68.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl610.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl612.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
                lbl712.Text = fec.AddDays(-1).ToString("dd/MM/yyyy");
            }
        }

        private void limpiarLabel()
        {
            lbl1.Text = string.Empty;
            lbl2.Text = string.Empty;
            lbl3.Text = string.Empty;
            lbl4.Text = string.Empty;
            lbl5.Text = string.Empty;
            lbl6.Text = string.Empty;
            lbl7.Text = string.Empty;
            lbl8.Text = string.Empty;
            lbl9.Text = string.Empty;
            lbl10.Text = string.Empty;
            lbl61.Text = string.Empty;
            lbl62.Text = string.Empty;
            lblSem1Ext.Text = string.Empty;
            lblSem2Ext.Text = string.Empty;
            lblSem3Ext.Text = string.Empty;
            lblSem4Ext.Text = string.Empty;
            lblSem5Ext.Text = string.Empty;
            lblSem6Ext.Text = string.Empty;
            lblSem6TotPlant.Text = string.Empty;
        }
        #endregion

        #region Calculo de Totales
        private void CalculoTotales()
        {
            #region Totales de Extrusion

            txtTotalMerma.Text = Math.Round((Convert.ToDouble(txtSem1Merma.Text) + Convert.ToDouble(txtSem2Merma.Text) + Convert.ToDouble(txtSem3Merma.Text) + Convert.ToDouble(txtSem4Merma.Text) + Convert.ToDouble(txtSem5Merma.Text) + Convert.ToDouble(txtSem6Merma.Text))).ToString();
            txtTotalCambios.Text = Math.Round((Convert.ToDouble(txtSem1Camb.Text) + Convert.ToDouble(txtSem2Camb.Text) + Convert.ToDouble(txtSem3Camb.Text) + Convert.ToDouble(txtSem4Camb.Text) + Convert.ToDouble(txtSem5Camb.Text) + Convert.ToDouble(txtSem6Camb.Text))).ToString();
            txtTotalLote.Text = Math.Round((Convert.ToDouble(txtSem1Lote.Text) + Convert.ToDouble(txtSem2Lote.Text) + Convert.ToDouble(txtSem3Lote.Text) + Convert.ToDouble(txtSem4Lote.Text) + Convert.ToDouble(txtSem5Lote.Text) + Convert.ToDouble(txtSem6Lote.Text))).ToString();
            txtTotalConsRecu.Text = Math.Round((Convert.ToDouble(txtSem1ConsRec.Text) + Convert.ToDouble(txtSem2ConsRec.Text) + Convert.ToDouble(txtSem3ConsRec.Text) + Convert.ToDouble(txtSem4ConsRec.Text) + Convert.ToDouble(txtSem5ConsRec.Text) + Convert.ToDouble(txtSem6ConsRec.Text))).ToString();
            
            if (txtTotalProd.Text != "0")
            {
                txtTotalRecu.Text = Math.Round((Convert.ToDouble(txtTotalMerma.Text) / Convert.ToDouble(txtTotalProd.Text))).ToString();
                
            }
          
            
            if (txtTotalMerma.Text != "0" && txtTotalProd.Text != "0")
            {
                txtTotalEfi.Text = Math.Round((1 - (Convert.ToDouble(txtTotalMerma.Text) / (Convert.ToDouble(txtTotalMerma.Text) + Convert.ToDouble(txtTotalProd.Text))))).ToString();
                txtTotEfiV.Text = Math.Round((1 - (Convert.ToDouble(txtTotalMerma.Text) / (Convert.ToDouble(txtTotalMerma.Text) + Convert.ToDouble(txtTotalProd.Text))))).ToString("0.00%");
            }

     
            #endregion

            #region Totales de Corte Primario
            // ok
            txtTotProdCP.Text = Math.Round(Convert.ToDouble(txtSem1PCP.Text) + Convert.ToDouble(txtSem2PCP.Text) + Convert.ToDouble(txtSem3PCP.Text) + Convert.ToDouble(txtSem4PCP.Text) + Convert.ToDouble(txtSem5PCP.Text) + Convert.ToDouble(txtSem6PCP.Text)).ToString();
            // ok
            txtTotRepPromCP.Text = Math.Round(((Convert.ToDouble(txtSem1RepPromCP.Text) * Convert.ToDouble(txtSem1PCP.Text)) + (Convert.ToDouble(txtSem2RepPromCP.Text) * Convert.ToDouble(txtSem2PCP.Text)) + (Convert.ToDouble(txtSem3RepPromCP.Text) * Convert.ToDouble(txtSem3PCP.Text)) + (Convert.ToDouble(txtSem4RepPromCP.Text) * Convert.ToDouble(txtSem4PCP.Text)) + (Convert.ToDouble(txtSem5RepPromCP.Text) * Convert.ToDouble(txtSem5PCP.Text)) + (Convert.ToDouble(txtSem6RepPromCP.Text) * Convert.ToDouble(txtSem6PCP.Text))) / Convert.ToDouble(txtTotProdCP.Text)).ToString();
            // ok
            txtTotMermaCP.Text = Math.Round(Convert.ToDouble(txtSem1MermCP.Text) + Convert.ToDouble(txtSem2MermCP.Text) + Convert.ToDouble(txtSem3MermCP.Text) + Convert.ToDouble(txtSem4MermCP.Text) + Convert.ToDouble(txtSem5MermCP.Text) + Convert.ToDouble(txtSem6MermCP.Text)).ToString();

            if (txtTotProdCP.Text != "0" && (txtTotMermaCP.Text != "0" || txtTotProdOP1CS.Text != "0"))
            {
                txtTotEfiCP.Text = Math.Round(1 - ((Convert.ToDouble(txtTotMermaCP.Text) + Convert.ToDouble(txtTotProdOP1CS.Text)) / Convert.ToDouble(txtTotProdCP.Text))).ToString();
                txtTotEfiCPV.Text = Math.Round(1 - ((Convert.ToDouble(txtTotMermaCP.Text) + Convert.ToDouble(txtTotProdOP1CS.Text)) / Convert.ToDouble(txtTotProdCP.Text))).ToString("0.00%");
            }
            else
            {
                txtTotEfiCP.Text = "0";
                txtTotEfiCPV.Text = "0";
            }
            #endregion

            #region Totales Metalizado

            txtTotProdGrl.Text = Math.Round(Convert.ToDouble(txtSem1ProdGrlM.Text) + Convert.ToDouble(txtSem2ProdGrlM.Text) + Convert.ToDouble(txtSem3ProdGrlM.Text) + Convert.ToDouble(txtSem4ProdGrlM.Text) + Convert.ToDouble(txtSem5ProdGrlM.Text) + Convert.ToDouble(txtSem6ProdGrlM.Text)).ToString();
            txtTotCantBobM.Text = Math.Round(Convert.ToDouble(txtSem1CantBobM.Text) + Convert.ToDouble(txtSem2CantBobM.Text) + Convert.ToDouble(txtSem3CantBobM.Text) + Convert.ToDouble(txtSem4CantBobM.Text) + Convert.ToDouble(txtSem5CantBobM.Text) + Convert.ToDouble(txtSem6CantBobM.Text)).ToString();

            if (txtTotCantBobM.Text != "0")
            {
                txtTotBobPromM.Text = Math.Round(Convert.ToDouble(txtTotProdGrl.Text) / Convert.ToDouble(txtTotCantBobM.Text)).ToString();
            }
           
            txtTotMermGrlM.Text = Math.Round(Convert.ToDouble(txtSem1MermGrlM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text)).ToString();
            if (txtTotProdGrl.Text != "0")
            {
                txtTotEfiM.Text = Math.Round(1 - Convert.ToDouble(txtTotMermGrlM.Text) / Convert.ToDouble(txtTotProdGrl.Text)).ToString();
                txtTotEfiMV.Text = Math.Round(1 - Convert.ToDouble(txtTotMermGrlM.Text) / Convert.ToDouble(txtTotProdGrl.Text)).ToString("0.00%");
            }
            else
            {
                txtTotEfiM.Text = "0";
                txtTotEfiMV.Text = "0";
            }
           
            txtTotPromMetM.Text = Math.Round(Convert.ToDouble(txtSem1ProdMM.Text) + Convert.ToDouble(txtSem2ProdMM.Text) + Convert.ToDouble(txtSem3ProdMM.Text) + Convert.ToDouble(txtSem4ProdMM.Text) + Convert.ToDouble(txtSem5ProdMM.Text) + Convert.ToDouble(txtSem6ProdMM.Text)).ToString();
            txtMermMetM.Text = Math.Round(Convert.ToDouble(txtSem1MermMM.Text) + Convert.ToDouble(txtSem2MermMM.Text) + Convert.ToDouble(txtSem3MermMM.Text) + Convert.ToDouble(txtSem4MermMM.Text) + Convert.ToDouble(txtSem5MermMM.Text) + Convert.ToDouble(txtSem6MermMM.Text)).ToString(); ;

            if (txtTotPromMetM.Text != "0" && txtTotEfiM.Text != "0")
            {
                txtTotEfiMetM.Text = Math.Round(1 - Convert.ToDouble(txtTotEfiM.Text) / Convert.ToDouble(txtTotPromMetM.Text)).ToString();
                txtTotEfiMetMV.Text = Math.Round(1 - Convert.ToDouble(txtTotEfiM.Text) / Convert.ToDouble(txtTotPromMetM.Text)).ToString("0.00%");
            }
            else
            {
                txtTotEfiMetM.Text = "0";
                txtTotEfiMetMV.Text = "0";
            }
            
            txtTotTotMermM.Text = Math.Round(Convert.ToDouble(txtSem1TotMermMM.Text) + Convert.ToDouble(txtSem2TotMermMM.Text) + Convert.ToDouble(txtSem3TotMermMM.Text) + Convert.ToDouble(txtSem4TotMermMM.Text) + Convert.ToDouble(txtSem5TotMermMM.Text) + Convert.ToDouble(txtSem6TotMermMM.Text)).ToString();

            if (txtTotProdGrl.Text != "0")
            {
                txtTotEfiMetMetMM.Text = Math.Round(Convert.ToDouble(txtTotTotMermM.Text) / Convert.ToDouble(txtTotProdGrl.Text)).ToString();
                txtTotEfiMetMetMMV.Text = Math.Round(Convert.ToDouble(txtTotTotMermM.Text) / Convert.ToDouble(txtTotProdGrl.Text)).ToString("0.00%");    
            }    
            else
            {
                txtTotEfiMetMetMM.Text = "0";
                txtTotEfiMetMetMMV.Text = "0";
            }    
            

            #endregion

            #region Totales Corte Secundario

            txtTotProdCS.Text = Math.Round(Convert.ToDouble(txtSem1ProdCS.Text) + Convert.ToDouble(txtSem2ProdCS.Text) + Convert.ToDouble(txtSem3ProdCS.Text) + Convert.ToDouble(txtSem4ProdCS.Text) + Convert.ToDouble(txtSem5ProdCS.Text) + Convert.ToDouble(txtSem6ProdCS.Text)).ToString();
            txtTotMermaCS.Text = Math.Round(Convert.ToDouble(txtSem1MermCS.Text) + Convert.ToDouble(txtSem2MermCS.Text) + Convert.ToDouble(txtSem3MermCS.Text) + Convert.ToDouble(txtSem4MermCS.Text) + Convert.ToDouble(txtSem5MermCS.Text) + Convert.ToDouble(txtSem6MermCS.Text)).ToString(); 
            if (txtTotProdCS.Text != "0")
	        {
		        txtTotEfiCS.Text = Math.Round(1-(Convert.ToDouble(txtTotMermaCS.Text) / Convert.ToDouble(txtTotProdCS.Text))).ToString();
                txtTotEfiCSV.Text = Math.Round(1 - (Convert.ToDouble(txtTotMermaCS.Text) / Convert.ToDouble(txtTotProdCS.Text))).ToString("0.00%");
	        }
            else
            {
                txtTotEfiCS.Text = "0";
                txtTotEfiCSV.Text = "0";
            }


            txtTotMermaP2CS.Text = Math.Round(Convert.ToDouble(txtSem1EfiCS.Text) + Convert.ToDouble(txtSem2EfiCS.Text) + Convert.ToDouble(txtSem3EfiCS.Text) + Convert.ToDouble(txtSem4EfiCS.Text) + Convert.ToDouble(txtSem5EfiCS.Text) + Convert.ToDouble(txtSem6EfiCS.Text)).ToString(); 
            
            if (txtTotalProd.Text != "0" || txtTotalMerma.Text != "0")
            {
                txtTotEfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtTotMermaP2CS.Text) / Convert.ToDouble(txtTotalProd.Text) + Convert.ToDouble(txtTotalMerma.Text))).ToString();
                txtTotEfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtTotMermaP2CS.Text) / Convert.ToDouble(txtTotalProd.Text) + Convert.ToDouble(txtTotalMerma.Text))).ToString("0.00%");
            }
            else
            {
                txtTotEfiP2CSV.Text = "0";
                txtTotEfiP2CS.Text = "0";
            }

            if (txtTotalConsRecu.Text != "0")
            {
                txtTotOptRecCS.Text = Math.Round(Convert.ToDouble(txtTotalConsRecu.Text) / Convert.ToDouble(txtTotMermaP2CS.Text)).ToString();
            }
            else
            {
                txtTotOptRecCS.Text = "0";
            }


            txtTotProdOP1CS.Text = Math.Round(Convert.ToDouble(txtSem1ProdOp1CS.Text) + Convert.ToDouble(txtSem2ProdOp1CS.Text) + Convert.ToDouble(txtSem3ProdOp1CS.Text) + Convert.ToDouble(txtSem4ProdOp1CS.Text) + Convert.ToDouble(txtSem5ProdOp1CS.Text) + Convert.ToDouble(txtSem6ProdOp1CS.Text)).ToString();
            txtTotProdPPCS.Text = Math.Round(Convert.ToDouble(txtSem1ProdPPCS.Text) + Convert.ToDouble(txtSem2ProdPPCS.Text) + Convert.ToDouble(txtSem3ProdPPCS.Text) + Convert.ToDouble(txtSem4ProdPPCS.Text) + Convert.ToDouble(txtSem5ProdPPCS.Text) + Convert.ToDouble(txtSem6ProdPPCS.Text)).ToString();

            if (txtTotProdCP.Text != "0")
            {
                txtTotOP1CS.Text = Math.Round(Convert.ToDouble(txtTotProdOP1CS.Text) / Convert.ToDouble(txtTotProdCP.Text)).ToString();
            }
            else
            {
                txtTotOP1CS.Text = "0";
            }

            if (txtTotProdCP.Text != "0")
            {
                txtTotPPCS.Text = Math.Round(Convert.ToDouble(txtTotProdPPCS.Text) / Convert.ToDouble(txtTotProdCP.Text)).ToString();
                txtTotPPCSV.Text = Math.Round(Convert.ToDouble(txtTotProdPPCS.Text) / Convert.ToDouble(txtTotProdCP.Text)).ToString("0.00%");
            }
            else
            {
                txtTotPPCS.Text = "0";
                txtTotPPCSV.Text = "0";
            }
           
            #endregion

            #region Totales Deposito y Logistica
            txtTotProdLocDL.Text = "0";
            txtTotInvRevDL.Text = "0";
            txtTotTotInvDL.Text = "0";
            txtTotPromAgeDL.Text = "0";
            txtTotAgePromDL.Text = "0";


            txtTotDespPTLDL.Text = Math.Round(Convert.ToDouble(txtSem1DispPTL.Text) + Convert.ToDouble(txtSem2DispPTL.Text) + Convert.ToDouble(txtSem3DispPTL.Text) + Convert.ToDouble(txtSem4DispPTL.Text) + Convert.ToDouble(txtSem5DispPTL.Text) + Convert.ToDouble(txtSem6DispPTL.Text)).ToString();
            txtTotDespPTIDL.Text = Math.Round(Convert.ToDouble(txtSem1DispPTI.Text) + Convert.ToDouble(txtSem2DispPTI.Text) + Convert.ToDouble(txtSem3DispPTI.Text) + Convert.ToDouble(txtSem4DispPTI.Text) + Convert.ToDouble(txtSem5DispPTI.Text) + Convert.ToDouble(txtSem6DispPTI.Text)).ToString(); ;
            txtTotIndRotPTLDL.Text = "0";
            txtTotIndRotPTIDL.Text = "0";
            #endregion
      
            #region Totales Gestion de Calidad
            txtTotRecIng.Text = "0";
            txtTotKgRecIng.Text = "0";
            txtTotRecAprb.Text = "0";
            txtTotKgRecAprb.Text = "0";
            txtTotRecAprbGdC.Text = "0";
            txtTotDevIngBPT.Text = "0";
            #endregion
        }
        #endregion  

        #region Calculo Todo
        private void calculoTodo()
        {
            DataSet DS = new DataSet();

            #region Carga de Textbox Y charts


                #region Solapa Extrusión Estarian todas las cargas.

                #region Consumo de Extrusión
                /* Esto se comenta, se cambio para que se cargue manual. En un futuro borrarlo si no se volvio a cambiar. 
               
                Cons1Sem = calculatingConsume(planta, Convert.ToDateTime(lbl1.Text), Convert.ToDateTime(lbl2.Text));
                txtSem1ConsRec.Text = Math.Round(Cons1Sem).ToString();

                Cons2Sem = calculatingConsume(planta, Convert.ToDateTime(lbl3.Text), Convert.ToDateTime(lbl4.Text));
                txtSem2ConsRec.Text = Math.Round(Cons2Sem).ToString();

                Cons3Sem = calculatingConsume(planta, Convert.ToDateTime(lbl5.Text), Convert.ToDateTime(lbl6.Text));
                txtSem3ConsRec.Text = Math.Round(Cons3Sem).ToString();

                Cons4Sem = calculatingConsume(planta, Convert.ToDateTime(lbl7.Text), Convert.ToDateTime(lbl8.Text));
                txtSem4ConsRec.Text = Math.Round(Cons4Sem).ToString();

                Cons5Sem = calculatingConsume(planta, Convert.ToDateTime(lbl9.Text), Convert.ToDateTime(lbl10.Text));
                txtSem5ConsRec.Text = Math.Round(Cons5Sem).ToString();

                if (lbl61.Text != "")
                {
                    Cons6Sem = calculatingConsume(planta, Convert.ToDateTime(lbl61.Text), Convert.ToDateTime(lbl62.Text));
                    txtSem6ConsRec.Text = Math.Round(Cons6Sem).ToString();
                }
            
                 */
                #endregion

                #region Merma de Extrusión

                // Llenado de Recuperado
                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl1.Text + "', '" + lbl2.Text + "', " + planta.codsec.ToString() + ")");

                txtSem1Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl3.Text + "', '" + lbl4.Text + "', " + planta.codsec.ToString() + ")");

                txtSem2Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl5.Text + "', '" + lbl6.Text + "', " + planta.codsec.ToString() + ")");

                txtSem3Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl7.Text + "', '" + lbl8.Text + "', " + planta.codsec.ToString() + ")");

                txtSem4Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl9.Text + "', '" + lbl10.Text + "', " + planta.codsec.ToString() + ")");

                txtSem5Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spRecRawByDate '" + lbl61.Text + "','" + lbl62.Text + "', " + planta.codsec.ToString() + ")");

                txtSem6Merma.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["MPTotal"]) / 1000).ToString();

                #endregion

                #region Producción de Extrusión

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl1.Text + "','" + lbl2.Text + "'," + planta.codsec + ")");

                txtSem1Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl3.Text + "','" + lbl4.Text + "'," + planta.codsec + ")");

                txtSem2Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl5.Text + "','" + lbl6.Text + "'," + planta.codsec + ")");

                txtSem3Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl7.Text + "','" + lbl8.Text + "'," + planta.codsec + ")");

                txtSem4Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl9.Text + "','" + lbl10.Text + "'," + planta.codsec + ")");

                txtSem5Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                DS = clsConnection.getDataSetResult("CALL spMainCoilReportTotalized('" + lbl61.Text + "','" + lbl62.Text + "'," + planta.codsec + ")");

                txtSem6Prod.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ProduccionTotal"]) / 1000)).ToString();

                txtTotalProd.Text = Math.Round((Convert.ToDouble(txtSem1Prod.Text) + Convert.ToDouble(txtSem2Prod.Text) + Convert.ToDouble(txtSem3Prod.Text) + Convert.ToDouble(txtSem4Prod.Text) + Convert.ToDouble(txtSem5Prod.Text) + Convert.ToDouble(txtSem6Prod.Text))).ToString();

                #endregion

                #region Cambios Extrusión

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl1.Text + "','" + lbl2.Text + "'," + planta.codsec);

                txtSem1Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl3.Text + "','" + lbl4.Text + "'," + planta.codsec);

                txtSem2Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl5.Text + "','" + lbl6.Text + "'," + planta.codsec);

                txtSem3Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl7.Text + "','" + lbl8.Text + "'," + planta.codsec);

                txtSem4Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl9.Text + "','" + lbl10.Text + "'," + planta.codsec);

                txtSem5Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();

                DS = clsConnection.getDataSetResult("CALL spFilmProductionCountByDate('" + lbl61.Text + "','" + lbl62.Text + "'," + planta.codsec);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6Camb.Text = DS.Tables[0].Rows[0]["cambios"].ToString();
                }


                #endregion

                #region Lotes Extrusión.

                if (txtSem1Camb.Text != "0")
                {
                    txtSem1Lote.Text = Math.Round((Convert.ToDouble(txtSem1Prod.Text) / Convert.ToDouble(txtSem1Camb.Text))).ToString();
                }
                else
                {
                    txtSem1Lote.Text = "0";
                }

                if (txtSem2Camb.Text != "0")
                {
                    txtSem2Lote.Text = Math.Round((Convert.ToDouble(txtSem2Prod.Text) / Convert.ToDouble(txtSem2Camb.Text))).ToString();
                }
                else
                {
                    txtSem2Lote.Text = "0";
                }

                if (txtSem3Camb.Text != "0")
                {
                    txtSem3Lote.Text = Math.Round((Convert.ToDouble(txtSem3Prod.Text) / Convert.ToDouble(txtSem3Camb.Text))).ToString();
                }
                else
                {
                    txtSem3Lote.Text = "0";
                }

                if (txtSem4Camb.Text != "0")
                {
                    txtSem4Lote.Text = Math.Round((Convert.ToDouble(txtSem4Prod.Text) / Convert.ToDouble(txtSem4Camb.Text))).ToString();
                }
                else
                {
                    txtSem4Lote.Text = "0";
                }

                if (txtSem5Camb.Text != "0")
                {
                    txtSem5Lote.Text = Math.Round((Convert.ToDouble(txtSem5Prod.Text) / Convert.ToDouble(txtSem5Camb.Text))).ToString();
                }
                else
                {
                    txtSem5Lote.Text = "0";
                }

                if (txtSem6Camb.Text != "0")
                {
                    txtSem6Lote.Text = Math.Round((Convert.ToDouble(txtSem6Prod.Text) / Convert.ToDouble(txtSem6Camb.Text))).ToString();
                }
                else
                {
                    txtSem6Lote.Text = "0";
                }
                #endregion

                #region % de Eficiencia
                // Calculo de los % de Eficiencia.

                if (txtSem1Prod.Text != "0" && txtSem1Merma.Text != "0" && txtSem1Prod.Text != "0")
                {
                    txtSem1Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem1Prod.Text) / (Convert.ToDouble(txtSem1Prod.Text) + Convert.ToDouble(txtSem1Merma.Text)))) * 100).ToString();
                    txtSem1EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem1Prod.Text) / (Convert.ToDouble(txtSem1Prod.Text) + Convert.ToDouble(txtSem1Merma.Text)))) * 100).ToString("0.00%");
                }

                if (txtSem2Prod.Text != "0" && txtSem2Merma.Text != "0" && txtSem2Prod.Text != "0")
                {
                    txtSem2Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem2Prod.Text) / (Convert.ToDouble(txtSem2Prod.Text) + Convert.ToDouble(txtSem2Merma.Text)))) * 100).ToString();
                    txtSem2EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem2Prod.Text) / (Convert.ToDouble(txtSem2Prod.Text) + Convert.ToDouble(txtSem2Merma.Text)))) * 100).ToString("0.00%");
                }

                if (txtSem3Prod.Text != "0" && txtSem3Merma.Text != "0" && txtSem3Prod.Text != "0")
                {
                    txtSem3Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem3Prod.Text) / (Convert.ToDouble(txtSem3Prod.Text) + Convert.ToDouble(txtSem3Merma.Text)))) * 100).ToString();
                    txtSem3EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem3Prod.Text) / (Convert.ToDouble(txtSem3Prod.Text) + Convert.ToDouble(txtSem3Merma.Text)))) * 100).ToString("0.00%");
                }

                if (txtSem4Prod.Text != "0" && txtSem4Merma.Text != "0" && txtSem4Prod.Text != "0")
                {
                    txtSem4Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem4Prod.Text) / (Convert.ToDouble(txtSem4Prod.Text) + Convert.ToDouble(txtSem4Merma.Text)))) * 100).ToString();
                    txtSem4EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem4Prod.Text) / (Convert.ToDouble(txtSem4Prod.Text) + Convert.ToDouble(txtSem4Merma.Text)))) * 100).ToString("0.00%");
                }

                if (txtSem5Prod.Text != "0" && txtSem5Merma.Text != "0" && txtSem5Prod.Text != "0")
                {
                    txtSem5Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem5Prod.Text) / (Convert.ToDouble(txtSem5Prod.Text) + Convert.ToDouble(txtSem5Merma.Text)))) * 100).ToString();
                    txtSem5EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem5Prod.Text) / (Convert.ToDouble(txtSem5Prod.Text) + Convert.ToDouble(txtSem5Merma.Text)))) * 100).ToString("0.00%");
                }

                if (txtSem6Prod.Text != "0" && txtSem6Merma.Text != "0" && txtSem6Prod.Text != "0")
                {
                    txtSem6Efi.Text = Math.Round((1 - (Convert.ToDouble(txtSem6Prod.Text) / (Convert.ToDouble(txtSem6Prod.Text) + Convert.ToDouble(txtSem6Merma.Text)))) * 100).ToString();
                    txtSem6EfiV.Text = Math.Round((1 - (Convert.ToDouble(txtSem6Prod.Text) / (Convert.ToDouble(txtSem6Prod.Text) + Convert.ToDouble(txtSem6Merma.Text)))) * 100).ToString("0.00%");
                }

                #endregion

                #region % de Recuperado Extrusión

                // Calculo % de Recuperado

                if (txtSem1Prod.Text != "0")
                {
                    txtSem1PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem1Merma.Text) / Convert.ToDouble(txtSem1Prod.Text))).ToString();
                }
                if (txtSem2Prod.Text != "0")
                {
                    txtSem2PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem2Merma.Text) / Convert.ToDouble(txtSem2Prod.Text))).ToString();
                }
                if (txtSem3Prod.Text != "0")
                {
                    txtSem3PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem3Merma.Text) / Convert.ToDouble(txtSem3Prod.Text))).ToString();
                }
                if (txtSem4Prod.Text != "0")
                {
                    txtSem4PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem4Merma.Text) / Convert.ToDouble(txtSem4Prod.Text))).ToString();
                }
                if (txtSem5Prod.Text != "0")
                {
                    txtSem5PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem5Merma.Text) / Convert.ToDouble(txtSem5Prod.Text))).ToString();
                }
                if (txtSem6Prod.Text != "0")
                {
                    txtSem6PorcRecu.Text = Math.Round((Convert.ToDouble(txtSem6Merma.Text) / Convert.ToDouble(txtSem6Prod.Text))).ToString();
                }
                #endregion

                #region Calculo Totales Extrusión
                //txtTotalProd.Text = Convert.ToString(Math.Round((Cons1Sem + Cons2Sem + Cons3Sem + Cons4Sem + Cons5Sem + Cons6Sem) / 1000));
                
                #endregion

                #endregion

                #region Solapa Corte Primario

                #region Corte Primario Producción

                // Primer semana. 
                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl11.Text + "', '" + lbl12.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem1PCP.Text = "0";
                }

                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl13.Text + "', '" + lbl14.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem2PCP.Text = "0";
                }

                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl15.Text + "', '" + lbl16.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem3PCP.Text = "0";
                }

                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl17.Text + "', '" + lbl18.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem4PCP.Text = "0";
                }

                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl19.Text + "', '" + lbl110.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem5PCP.Text = "0";
                }

                DS = clsConnection.getDataSetResult("CALL spPrimaryCoilByCuttingOrderDateAndPlant '" + lbl63.Text + "', '" + lbl64.Text + "', " + primcutter);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6PCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["totPeso"]) / 1000)).ToString();
                }
                else
                {
                    txtSem6PCP.Text = "0";
                }

                #endregion

                #region Repeticiones Prom
                

                txtSem1RepPromCP.Text = Math.Round(calcularReps(lbl11.Text, lbl12.Text, primcutter, seccutter)).ToString();

                txtSem2RepPromCP.Text = Math.Round(calcularReps(lbl13.Text, lbl14.Text, primcutter, seccutter)).ToString();

                txtSem3RepPromCP.Text = Math.Round(calcularReps(lbl15.Text, lbl16.Text, primcutter, seccutter)).ToString();

                txtSem4RepPromCP.Text = Math.Round(calcularReps(lbl17.Text, lbl18.Text, primcutter, seccutter)).ToString();

                txtSem5RepPromCP.Text = Math.Round(calcularReps(lbl19.Text, lbl110.Text, primcutter, seccutter)).ToString();

                txtSem6RepPromCP.Text = Math.Round(calcularReps(lbl63.Text, lbl64.Text, primcutter, seccutter)).ToString();

                #endregion

                #region Merma

                string query = "CALL spScrapByMachineByDateTotalized('" + lbl11.Text + "','" + lbl12.Text + "'," + primcutter.ToString() + ")";
                DS = clsConnection.getDataSetResult(query);

                if (DS.Tables.Count > 0)
                {
                    txtSem1MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spScrapByMachineByDateTotalized('" + lbl13.Text + "','" + lbl14.Text + "'," + primcutter.ToString() + ")");

                if (DS.Tables.Count > 0)
                {
                    txtSem2MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult(" CALL spScrapByMachineByDateTotalized('" + lbl15.Text + "','" + lbl16.Text + "'," + primcutter.ToString() + ")");

                if (DS.Tables.Count > 0)
                {
                    txtSem3MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spScrapByMachineByDateTotalized('" + lbl17.Text + "','" + lbl12.Text + "'," + primcutter.ToString() + ")");

                if (DS.Tables.Count > 0)
                {
                    txtSem4MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spScrapByMachineByDateTotalized('" + lbl11.Text + "','" + lbl12.Text + "'," + primcutter.ToString() + ")");

                if (DS.Tables.Count > 0)
                {
                    txtSem5MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spScrapByMachineByDateTotalized('" + lbl63.Text + "','" + lbl64.Text + "'," + primcutter.ToString() + ")");

                if (DS.Tables.Count > 0)
                {
                    txtSem6MermCP.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000)).ToString();
                }
                #endregion

                #region % de Eficiencia

                if (txtSem1PCP.Text != "0" && (txtSem1MermCP.Text != "0" || txtSem1ProdOp1CS.Text != "0"))
                {
                    txtSem1EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem1MermCP.Text) + Convert.ToDouble(txtSem1ProdOp1CS.Text)) / Convert.ToDouble(txtSem1PCP.Text)))).ToString();
                    txtSem1EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem1MermCP.Text) + Convert.ToDouble(txtSem1ProdOp1CS.Text)) / Convert.ToDouble(txtSem1PCP.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem1EfiCP.Text = "0";
                    txtSem1EfiCPV.Text = "0";
                }

                if (txtSem2PCP.Text != "0" && (txtSem2MermCP.Text != "0" || txtSem2ProdOp1CS.Text != "0"))
                {
                    txtSem2EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem2MermCP.Text) + Convert.ToDouble(txtSem2ProdOp1CS.Text))) / Convert.ToDouble(txtSem2PCP.Text))).ToString();
                    txtSem2EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem2MermCP.Text) + Convert.ToDouble(txtSem2ProdOp1CS.Text))) / Convert.ToDouble(txtSem2PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem2EfiCP.Text = "0";
                    txtSem2EfiCPV.Text = "0";
                }

                if (txtSem3PCP.Text != "0" && (txtSem3MermCP.Text != "0" || txtSem3ProdOp1CS.Text != "0"))
                {
                    txtSem3EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem3MermCP.Text) + Convert.ToDouble(txtSem3ProdOp1CS.Text))) / Convert.ToDouble(txtSem3PCP.Text))).ToString();
                    txtSem3EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem3MermCP.Text) + Convert.ToDouble(txtSem3ProdOp1CS.Text))) / Convert.ToDouble(txtSem3PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem3EfiCP.Text = "0";
                    txtSem3EfiCPV.Text = "0";
                }

                if (txtSem4PCP.Text != "0" && (txtSem4MermCP.Text != "0" || txtSem4ProdOp1CS.Text != "0"))
                {
                    txtSem4EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem4MermCP.Text) + Convert.ToDouble(txtSem4ProdOp1CS.Text))) / Convert.ToDouble(txtSem4PCP.Text))).ToString();
                    txtSem4EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem4MermCP.Text) + Convert.ToDouble(txtSem4ProdOp1CS.Text))) / Convert.ToDouble(txtSem4PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem4EfiCP.Text = "0";
                    txtSem4EfiCPV.Text = "0";
                }

                if (txtSem5PCP.Text != "0" && (txtSem5MermCP.Text != "0" || txtSem5ProdOp1CS.Text != "0"))
                {
                    txtSem5EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem5MermCP.Text) + Convert.ToDouble(txtSem5ProdOp1CS.Text))) / Convert.ToDouble(txtSem5PCP.Text))).ToString();
                    txtSem5EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem5MermCP.Text) + Convert.ToDouble(txtSem5ProdOp1CS.Text))) / Convert.ToDouble(txtSem5PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem5EfiCP.Text = "0";
                    txtSem5EfiCPV.Text = "0";
                }


                if (txtSem6PCP.Text != "0" && (txtSem6MermCP.Text != "0" || txtSem6ProdOp1CS.Text != "0"))
                {
                    txtSem6EfiCP.Text = Math.Round((1 - ((Convert.ToDouble(txtSem6MermCP.Text) + Convert.ToDouble(txtSem6ProdOp1CS.Text))) / Convert.ToDouble(txtSem6PCP.Text))).ToString();
                    txtSem6EfiCPV.Text = Math.Round((1 - ((Convert.ToDouble(txtSem6MermCP.Text) + Convert.ToDouble(txtSem6ProdOp1CS.Text))) / Convert.ToDouble(txtSem6PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem6EfiCP.Text = "0";
                    txtSem6EfiCPV.Text = "0";
                }

                #endregion

                #endregion

                #region Solapa de Metalizado.

                #region Produccion Gnrl

                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl21.Text + "', '" + lbl22.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl23.Text + "', '" + lbl24.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl25.Text + "', '" + lbl26.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }


                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl27.Text + "', '" + lbl28.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl29.Text + "', '" + lbl210.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalized '" + lbl65.Text + "', '" + lbl66.Text + "', " + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6ProdGrlM.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000)).ToString();
                }
                #endregion

                #region Cantidad de Bobinas
                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl21.Text + "','" + lbl22.Text + "'," + metallizer);
                txtSem1CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl23.Text + "','" + lbl24.Text + "'," + metallizer);
                txtSem2CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl25.Text + "','" + lbl26.Text + "'," + metallizer);
                txtSem3CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl27.Text + "','" + lbl28.Text + "'," + metallizer);
                txtSem4CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl29.Text + "','" + lbl210.Text + "'," + metallizer);
                txtSem5CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                DS = clsConnection.getDataSetResult("CALL spMetallizedCoilsCount('" + lbl65.Text + "','" + lbl66.Text + "'," + metallizer);
                txtSem5CantBobM.Text = Convert.ToString(DS.Tables[0].Rows[0]["cantBobMet"]);

                #endregion

                #region Bobinas Promedio

                if (txtSem1CantBobM.Text != "0")
                {
                    txtSem1BobPromM.Text = Math.Round(Convert.ToDouble(txtSem1CantBobM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)).ToString();
                }

                if (txtSem2CantBobM.Text != "0")
                {
                    txtSem2BobPromM.Text = Math.Round(Convert.ToDouble(txtSem2CantBobM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)).ToString();
                }
                
                if (txtSem3CantBobM.Text != "0")
                {
                    txtSem3BobPromM.Text = Math.Round(Convert.ToDouble(txtSem3CantBobM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)).ToString();
                }

                if (txtSem4CantBobM.Text != "0")
                {
                    txtSem4BobPromM.Text = Math.Round(Convert.ToDouble(txtSem4CantBobM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)).ToString();
                }

                if (txtSem5CantBobM.Text != "0")
                {
                    txtSem5BobPromM.Text = Math.Round(Convert.ToDouble(txtSem5CantBobM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)).ToString();
                }

                if (txtSem5CantBobM.Text != "0")
                {
                    txtSem6BobPromM.Text = Math.Round(Convert.ToDouble(txtSem6CantBobM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)).ToString();
                }
                #endregion

                #region Merma Gnrl

                txtSem1MermGrlM.Text = Math.Round(calcularMermaM(lbl21.Text, lbl22.Text, planta) / 1000).ToString();

                txtSem2MermGrlM.Text = Math.Round(calcularMermaM(lbl23.Text, lbl24.Text, planta) / 1000).ToString();

                txtSem3MermGrlM.Text = Math.Round(calcularMermaM(lbl25.Text, lbl26.Text, planta) / 1000).ToString();

                //Tarda un termino medio
                txtSem4MermGrlM.Text = Math.Round(calcularMermaM(lbl27.Text, lbl28.Text, planta) / 1000).ToString();

                txtSem5MermGrlM.Text = Math.Round(calcularMermaM(lbl29.Text, lbl210.Text, planta) / 1000).ToString();

                txtSem5MermGrlM.Text = Math.Round(calcularMermaM(lbl65.Text, lbl66.Text, planta) / 1000).ToString();

                #endregion

                #region % de Eficiencia

                if (txtSem1ProdGrlM.Text != "0" && txtSem1MermGrlM.Text != "0")
                {
                    txtSem1EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermGrlM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString();
                    txtSem1EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermGrlM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem1EfiM.Text = "0";
                    txtSem1EfiMV.Text = "0";
                }

                if (txtSem2ProdGrlM.Text != "0" && txtSem2MermGrlM.Text != "0")
                {
                    txtSem2EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermGrlM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString();
                    txtSem2EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermGrlM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem2EfiM.Text = "0";
                    txtSem2EfiMV.Text = "0";
                }

                if (txtSem3ProdGrlM.Text != "0" && txtSem3MermGrlM.Text != "0")
                {
                    txtSem3EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermGrlM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString();
                    txtSem3EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermGrlM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem3EfiM.Text = "0";
                    txtSem3EfiMV.Text = "0";
                }

                if (txtSem4ProdGrlM.Text != "0" && txtSem4MermGrlM.Text != "0")
                {
                    txtSem4EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermGrlM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString();
                    txtSem4EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermGrlM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem4EfiM.Text = "0";
                    txtSem4EfiMV.Text = "0";
                }
                if (txtSem5ProdGrlM.Text != "0" && txtSem5MermGrlM.Text != "0")
                {
                    txtSem5EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermGrlM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString();
                    txtSem5EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermGrlM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem5EfiM.Text = "0";
                    txtSem5EfiMV.Text = "0";
                }

                if (txtSem6ProdGrlM.Text != "0" && txtSem6MermGrlM.Text != "0")
                {
                    txtSem6EfiM.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermGrlM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString();
                    txtSem6EfiMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermGrlM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem6EfiM.Text = "0";
                    txtSem6EfiMV.Text = "0";
                }

                #endregion

                #region Produccion Metal

                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl21.Text + "', '" + lbl22.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }


                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl23.Text + "', '" + lbl24.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl25.Text + "', '" + lbl26.Text + "', " + planta.codsec.ToString());

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                // Ver esta consulta tambien tarda un termino medio. NO SE PUEDE TOCAR.
                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl27.Text + "', '" + lbl28.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl29.Text + "', '" + lbl210.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalized '" + lbl65.Text + "', '" + lbl66.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6ProdMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                #endregion

                #region Merma Metal

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl21.Text + "', '" + lbl22.Text + "', " + seccutter.ToString() + ", 2");
                txtSem1MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl23.Text + "', '" + lbl24.Text + "', " + seccutter.ToString() + ", 2");
                txtSem2MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl25.Text + "', '" + lbl26.Text + "', " + seccutter.ToString() + ", 2");
                txtSem3MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl27.Text + "', '" + lbl28.Text + "', " + seccutter.ToString() + ", 2");
                txtSem4MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl29.Text + "', '" + lbl210.Text + "', " + seccutter.ToString() + ", 2");
                txtSem5MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalized '" + lbl65.Text + "', '" + lbl66.Text + "', " + seccutter.ToString() + ", 2");
                txtSem6MermMM.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                #endregion

                #region % Eficiencia Metal
                if (txtSem1ProdGrlM.Text != "0" && txtSem1MermMM.Text != "0")
                {
                    txtSem1EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermMM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString();
                    txtSem1EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermMM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem1EfiMetM.Text = "0";
                    txtSem1EfiMetMV.Text = "0";
                }

                if (txtSem2ProdGrlM.Text != "0" && txtSem2MermMM.Text != "0")
                {
                    txtSem2EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermMM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString();
                    txtSem2EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermMM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem2EfiMetM.Text = "0";
                    txtSem2EfiMetMV.Text = "0";
                }

                if (txtSem3ProdGrlM.Text != "0" && txtSem3MermMM.Text != "0")
                {
                    txtSem3EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermMM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString();
                    txtSem3EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermMM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem3EfiMetM.Text = "0";
                    txtSem3EfiMetMV.Text = "0";
                }

                if (txtSem4ProdGrlM.Text != "0" && txtSem4MermMM.Text != "0")
                {
                    txtSem4EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermMM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString();
                    txtSem4EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermMM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem4EfiMetM.Text = "0";
                    txtSem4EfiMetMV.Text = "0";
                }

                if (txtSem5ProdGrlM.Text != "0" && txtSem5MermMM.Text != "0")
                {
                    txtSem5EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermMM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString();
                    txtSem5EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermMM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem5EfiMetM.Text = "0";
                    txtSem5EfiMetMV.Text = "0";
                }

                if (txtSem6ProdGrlM.Text != "0" && txtSem6MermMM.Text != "0")
                {
                    txtSem6EfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermMM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString();
                    txtSem6EfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermMM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem6EfiMetM.Text = "0";
                    txtSem6EfiMetMV.Text = "0";
                }
                #endregion

                #region Total Merma Metal.

                txtSem1TotMermMM.Text = Math.Round(Convert.ToDouble(txtSem1MermMM.Text) + Convert.ToDouble(txtSem1MermGrlM.Text) / 1000).ToString();

                txtSem2TotMermMM.Text = Math.Round(Convert.ToDouble(txtSem2MermMM.Text) + Convert.ToDouble(txtSem2MermGrlM.Text) / 1000).ToString();

                txtSem3TotMermMM.Text = Math.Round(Convert.ToDouble(txtSem3MermMM.Text) + Convert.ToDouble(txtSem3MermGrlM.Text) / 1000).ToString();

                txtSem4TotMermMM.Text = Math.Round(Convert.ToDouble(txtSem4MermMM.Text) + Convert.ToDouble(txtSem4MermGrlM.Text) / 1000).ToString();

                txtSem5TotMermMM.Text = Math.Round(Convert.ToDouble(txtSem5MermMM.Text) + Convert.ToDouble(txtSem5MermGrlM.Text) / 1000).ToString();

                txtSem6TotMermMM.Text = Math.Round((Convert.ToDouble(txtSem6MermMM.Text) + Convert.ToDouble(txtSem6MermGrlM.Text)) /1000 ).ToString();
                #endregion

                #region % de Eficiencia Total Metal

                if (txtSem1ProdGrlM.Text != "0" && txtSem1TotMermMM.Text != "0")
                {
                    txtSem1TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem1TotMermMM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString();
                    txtSem1TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem1TotMermMM.Text) / Convert.ToDouble(txtSem1ProdGrlM.Text)))).ToString("0.00%");
                }

                if (txtSem2ProdGrlM.Text != "0" && txtSem2TotMermMM.Text != "0")
                {
                    txtSem2TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem2TotMermMM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString();
                    txtSem2TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem2TotMermMM.Text) / Convert.ToDouble(txtSem2ProdGrlM.Text)))).ToString("0.00%");
                }

                if (txtSem3ProdGrlM.Text != "0" && txtSem3TotMermMM.Text != "0")
                {
                    txtSem3TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem3TotMermMM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString();
                    txtSem3TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem3TotMermMM.Text) / Convert.ToDouble(txtSem3ProdGrlM.Text)))).ToString("0.00%");
                }

                if (txtSem4ProdGrlM.Text != "0" && txtSem4TotMermMM.Text != "0")
                {
                    txtSem4TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem4TotMermMM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString();
                    txtSem4TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem4TotMermMM.Text) / Convert.ToDouble(txtSem4ProdGrlM.Text)))).ToString("0.00%");
                }

                if (txtSem5ProdGrlM.Text != "0" && txtSem5TotMermMM.Text != "0")
                {
                    txtSem5TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem5TotMermMM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString();
                    txtSem5TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem5TotMermMM.Text) / Convert.ToDouble(txtSem5ProdGrlM.Text)))).ToString("0.0%");
                }

                if (txtSem6ProdGrlM.Text != "0" && txtSem6TotMermMM.Text != "0")
                {
                    txtSem6TotEfiMetM.Text = Math.Round((1 - (Convert.ToDouble(txtSem6TotMermMM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString();
                    txtSem6TotEfiMetMV.Text = Math.Round((1 - (Convert.ToDouble(txtSem6TotMermMM.Text) / Convert.ToDouble(txtSem6ProdGrlM.Text)))).ToString("0.00%");
                }
                #endregion

                #endregion

                #region Solapa Corte Secundario

                #region Producción Corte Secundario

                //DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl31.Text + "', '" + lbl32.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl31.Text + "', '" + lbl32.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                // Posible cambio por spSecundaryCuttingReportTotalized 
                //DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl33.Text + "', '" + lbl34.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl33.Text + "', '" + lbl34.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                //DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl35.Text + "', '" + lbl36.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl35.Text + "', '" + lbl36.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                //DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl37.Text + "', '" + lbl38.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl37.Text + "', '" + lbl38.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                //DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl39.Text + "', '" + lbl310.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl39.Text + "', '" + lbl310.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

               // DS = clsConnection.getDataSetResult("CALL spSecundaryCoilByCuttingOrderDateAndPlant '" + lbl67.Text + "', '" + lbl68.Text + "', " + seccutter);
                DS = clsConnection.getDataSetResult("CALL spSecundaryCuttingReportTotalized '" + lbl67.Text + "', '" + lbl68.Text + "', " + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6ProdCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["CorteTotal"]) / 1000).ToString();
                }

                #endregion

                #region Merma Corte Secundario

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl31.Text + "', '" + lbl32.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem1MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl33.Text + "', '" + lbl34.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem2MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl35.Text + "', '" + lbl36.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem3MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl37.Text + "', '" + lbl38.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem4MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl39.Text + "', '" + lbl310.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem5MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                DS = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + lbl67.Text + "', '" + lbl68.Text + "', " + planta.codsec.ToString() + ", 2");
                txtSem6MermCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["ScrapTotal"]) / 1000).ToString();

                #endregion

                #region Eficiencia
                if (txtSem1ProdCS.Text != "0" && txtSem1MermCS.Text != "0")
                {
                    txtSem1EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermCS.Text) / Convert.ToDouble(txtSem1ProdCS.Text)))).ToString();
                    txtSem1EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem1MermCS.Text) / Convert.ToDouble(txtSem1ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem1EfiCS.Text = "0";
                    txtSem1EfiCSV.Text = "0";
                }

                if (txtSem2ProdCS.Text != "0" && txtSem2MermCS.Text != "0")
                {
                    txtSem2EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermCS.Text) / Convert.ToDouble(txtSem2ProdCS.Text)))).ToString();
                    txtSem2EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem2MermCS.Text) / Convert.ToDouble(txtSem2ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem2EfiCS.Text = "0";
                    txtSem2EfiCSV.Text = "0";
                }

                if (txtSem3ProdCS.Text != "0" && txtSem3MermCS.Text != "0")
                {
                    txtSem3EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermCS.Text) / Convert.ToDouble(txtSem3ProdCS.Text)))).ToString();
                    txtSem3EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem3MermCS.Text) / Convert.ToDouble(txtSem3ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem3EfiCS.Text = "0";
                    txtSem3EfiCSV.Text = "0";
                }

                if (txtSem4ProdCS.Text != "0" && txtSem4MermCS.Text != "0")
                {
                    txtSem4EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermCS.Text) / Convert.ToDouble(txtSem4ProdCS.Text)))).ToString();
                    txtSem4EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem4MermCS.Text) / Convert.ToDouble(txtSem4ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem4EfiCSV.Text = "0";
                    txtSem4EfiCS.Text = "0";
                }

                if (txtSem5ProdCS.Text != "0" && txtSem5MermCS.Text != "0")
                {
                    txtSem5EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermCS.Text) / Convert.ToDouble(txtSem5ProdCS.Text)))).ToString();
                    txtSem5EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem5MermCS.Text) / Convert.ToDouble(txtSem5ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem5EfiCS.Text = "0";
                    txtSem5EfiCSV.Text = "0";
                }

                if (txtSem6ProdCS.Text != "0" && txtSem6MermCS.Text != "0")
                {
                    txtSem6EfiCS.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermCS.Text) / Convert.ToDouble(txtSem6ProdCS.Text)))).ToString();
                    txtSem6EfiCSV.Text = Math.Round((1 - (Convert.ToDouble(txtSem6MermCS.Text) / Convert.ToDouble(txtSem6ProdCS.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem6EfiCS.Text = "0";
                    txtSem6EfiCSV.Text = "0";
                }
                #endregion

                #region Tot. Merma P2

                txtSem1TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem1TotMermMM.Text) + Convert.ToDouble(txtSem1MermCP.Text) + Convert.ToDouble(txtSem1Merma.Text) + Convert.ToDouble(txtSem1MermCS.Text))).ToString();

                txtSem2TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem2TotMermMM.Text) + Convert.ToDouble(txtSem2MermCP.Text) + Convert.ToDouble(txtSem2Merma.Text) + Convert.ToDouble(txtSem2MermCS.Text))).ToString();

                txtSem3TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem3TotMermMM.Text) + Convert.ToDouble(txtSem3MermCP.Text) + Convert.ToDouble(txtSem3Merma.Text) + Convert.ToDouble(txtSem3MermCS.Text))).ToString();

                txtSem4TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem4TotMermMM.Text) + Convert.ToDouble(txtSem4MermCP.Text) + Convert.ToDouble(txtSem4Merma.Text) + Convert.ToDouble(txtSem4MermCS.Text))).ToString();

                txtSem5TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem5TotMermMM.Text) + Convert.ToDouble(txtSem5MermCP.Text) + Convert.ToDouble(txtSem5Merma.Text) + Convert.ToDouble(txtSem5MermCS.Text))).ToString();

                txtSem6TotMermP2CS.Text = Math.Round((Convert.ToDouble(txtSem6TotMermMM.Text) + Convert.ToDouble(txtSem6MermCP.Text) + Convert.ToDouble(txtSem6Merma.Text) + Convert.ToDouble(txtSem6MermCS.Text))).ToString();

                #endregion

                #region % De Eficiencia P2

                if ((txtSem1Prod.Text != "0" || txtSem1Merma.Text != "0") && txtSem1TotMermP2CS.Text != "0")
                {
                    txtSem1EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem1TotMermP2CS.Text) / (Convert.ToDouble(txtSem1Prod.Text) + Convert.ToDouble(txtSem1Merma.Text)))).ToString();
                    txtSem1EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem1TotMermP2CS.Text) / (Convert.ToDouble(txtSem1Prod.Text) + Convert.ToDouble(txtSem1Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem1EfiP2CS.Text = "0";
                    txtSem1EfiP2CSV.Text = "0";
                }

                if ((txtSem2Prod.Text != "0" || txtSem2Merma.Text != "0") && txtSem2TotMermP2CS.Text != "0")
                {
                    txtSem2EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem2TotMermP2CS.Text) / (Convert.ToDouble(txtSem2Prod.Text) + Convert.ToDouble(txtSem2Merma.Text)))).ToString();
                    txtSem2EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem2TotMermP2CS.Text) / (Convert.ToDouble(txtSem2Prod.Text) + Convert.ToDouble(txtSem2Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem2EfiP2CS.Text = "0";
                    txtSem2EfiP2CSV.Text = "0";
                }


                if ((txtSem3Prod.Text != "0" || txtSem3Merma.Text != "0") && txtSem3TotMermP2CS.Text != "0")
                {
                    txtSem3EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem3TotMermP2CS.Text) / (Convert.ToDouble(txtSem3Prod.Text) + Convert.ToDouble(txtSem3Merma.Text)))).ToString();
                    txtSem3EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem3TotMermP2CS.Text) / (Convert.ToDouble(txtSem3Prod.Text) + Convert.ToDouble(txtSem3Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem3EfiP2CS.Text = "0";
                    txtSem3EfiP2CSV.Text = "0";
                }


                if ((txtSem4Prod.Text != "0" || txtSem4Merma.Text != "0") && txtSem4TotMermP2CS.Text != "0")
                {
                    txtSem4EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem4TotMermP2CS.Text) / (Convert.ToDouble(txtSem4Prod.Text) + Convert.ToDouble(txtSem4Merma.Text)))).ToString();
                    txtSem4EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem4TotMermP2CS.Text) / (Convert.ToDouble(txtSem4Prod.Text) + Convert.ToDouble(txtSem4Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem4EfiP2CS.Text = "0";
                    txtSem4EfiP2CSV.Text = "0";
                }


                if ((txtSem5Prod.Text != "0" || txtSem5Merma.Text != "0") && txtSem5TotMermP2CS.Text != "0")
                {
                    txtSem5EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem5TotMermP2CS.Text) / (Convert.ToDouble(txtSem5Prod.Text) + Convert.ToDouble(txtSem5Merma.Text)))).ToString();
                    txtSem5EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem5TotMermP2CS.Text) / (Convert.ToDouble(txtSem5Prod.Text) + Convert.ToDouble(txtSem5Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem5EfiP2CS.Text = "0";
                    txtSem5EfiP2CSV.Text = "0";
                }

                if ((txtSem6Prod.Text != "0" || txtSem6Merma.Text != "0") && txtSem6TotMermP2CS.Text != "0")
                {
                    txtSem6EfiP2CS.Text = Math.Round(1 - (Convert.ToDouble(txtSem6TotMermP2CS.Text) / (Convert.ToDouble(txtSem6Prod.Text) + Convert.ToDouble(txtSem6Merma.Text)))).ToString();
                    txtSem6EfiP2CSV.Text = Math.Round(1 - (Convert.ToDouble(txtSem6TotMermP2CS.Text) / (Convert.ToDouble(txtSem6Prod.Text) + Convert.ToDouble(txtSem6Merma.Text)))).ToString("0.00%");
                }
                else
                {
                    txtSem6EfiP2CS.Text = "0";
                    txtSem6EfiP2CSV.Text = "0";
                }

                #endregion

                #region Optimizacion uso de Rec.

                if (txtSem1TotMermP2CS.Text != "0")
                {
                    txtSem1OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem1ConsRec.Text) / Convert.ToDouble(txtSem1TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem1OptRecCS.Text = "0";
                }

                if (txtSem2TotMermP2CS.Text != "0")
                {
                    txtSem2OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem2ConsRec.Text) / Convert.ToDouble(txtSem2TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem2OptRecCS.Text = "0";
                }

                if (txtSem3TotMermP2CS.Text != "0")
                {
                    txtSem3OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem3ConsRec.Text) / Convert.ToDouble(txtSem3TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem3OptRecCS.Text = "0";
                }

                if (txtSem4TotMermP2CS.Text != "0")
                {
                    txtSem4OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem4ConsRec.Text) / Convert.ToDouble(txtSem4TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem4OptRecCS.Text = "0";
                }

                if (txtSem5TotMermP2CS.Text != "0")
                {
                    txtSem5OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem5ConsRec.Text) / Convert.ToDouble(txtSem5TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem5OptRecCS.Text = "0";
                }

                if (txtSem6TotMermP2CS.Text != "0")
                {
                    txtSem6OptRecCS.Text = Math.Round((Convert.ToDouble(txtSem6ConsRec.Text) / Convert.ToDouble(txtSem6TotMermP2CS.Text))).ToString();
                }
                else
                {
                    txtSem6OptRecCS.Text = "0";
                }


                #endregion

                #region Produccion OP-1
                // Ver bien este tema, estamos considerando pallets de calidad segunda, en producto terminado   

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl31.Text + "','" + lbl32.Text + "'," + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl33.Text + "','" + lbl34.Text + "'," + planta.codsec.ToString());

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl35.Text + "','" + lbl36.Text + "'," + planta.codsec.ToString());
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl37.Text + "','" + lbl38.Text + "'," + planta.codsec.ToString());

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl39.Text + "','" + lbl310.Text + "'," + planta.codsec.ToString());

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spDepotOP1ByDateSubTotalized('" + lbl67.Text + "','" + lbl68.Text + "'," + planta.codsec.ToString());

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6ProdOp1CS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["TotalDepot"]) / 1000)).ToString();
                }

                #endregion

                #region Producción PP

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl31.Text + "','" + lbl32.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem1ProdPPCS.Text = Math.Round((Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"])) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl33.Text + "','" + lbl34.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem2ProdPPCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl35.Text + "','" + lbl36.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem3ProdPPCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl37.Text + "','" + lbl38.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem4ProdPPCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl39.Text + "','" + lbl310.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem5ProdPPCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"]) / 1000).ToString();
                }

                DS = clsConnection.getDataSetResult("CALL spPalletsInPPByDateByPlant('" + lbl67.Text + "','" + lbl68.Text + "'," + planta.codsec.ToString() + ")");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtSem6ProdPPCS.Text = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["pesos"]) / 1000).ToString();
                }

                #endregion

                #region % OP1

                if (txtSem1PCP.Text != "0")
                {
                    txtSem1Op1CS.Text = Math.Round((Convert.ToDouble(txtSem1ProdOp1CS.Text) / Convert.ToDouble(txtSem1PCP.Text))).ToString();
                    txtSem1Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem1ProdOp1CS.Text) / Convert.ToDouble(txtSem1PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem1Op1CS.Text = "0";
                    txtSem1Op1CSV.Text = "0";
                }


                if (txtSem2PCP.Text != "0")
                {
                    txtSem2Op1CS.Text = Math.Round((Convert.ToDouble(txtSem2ProdOp1CS.Text) / Convert.ToDouble(txtSem2PCP.Text))).ToString();
                    txtSem2Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem2ProdOp1CS.Text) / Convert.ToDouble(txtSem2PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem2Op1CS.Text = "0";
                    txtSem2Op1CSV.Text = "0";
                }

                if (txtSem3PCP.Text != "0")
                {
                    txtSem3Op1CS.Text = Math.Round((Convert.ToDouble(txtSem3ProdOp1CS.Text) / Convert.ToDouble(txtSem3PCP.Text))).ToString();
                    txtSem3Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem3ProdOp1CS.Text) / Convert.ToDouble(txtSem3PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem3Op1CS.Text = "0";
                    txtSem3Op1CSV.Text = "0";
                }

                if (txtSem4PCP.Text != "0")
                {
                    txtSem4Op1CS.Text = Math.Round((Convert.ToDouble(txtSem4ProdOp1CS.Text) / Convert.ToDouble(txtSem4PCP.Text))).ToString();
                    txtSem4Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem4ProdOp1CS.Text) / Convert.ToDouble(txtSem4PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem4Op1CS.Text = "0";
                    txtSem4Op1CSV.Text = "0";
                }

                if (txtSem5PCP.Text != "0")
                {
                    txtSem5Op1CS.Text = Math.Round((Convert.ToDouble(txtSem5ProdOp1CS.Text) / Convert.ToDouble(txtSem5PCP.Text))).ToString();
                    txtSem5Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem5ProdOp1CS.Text) / Convert.ToDouble(txtSem5PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem5Op1CS.Text = "0";
                    txtSem5Op1CSV.Text = "0";
                }

                if (txtSem6PCP.Text != "0")
                {
                    txtSem6Op1CS.Text = Math.Round((Convert.ToDouble(txtSem6ProdOp1CS.Text) / Convert.ToDouble(txtSem6PCP.Text))).ToString();
                    txtSem6Op1CSV.Text = Math.Round((Convert.ToDouble(txtSem6ProdOp1CS.Text) / Convert.ToDouble(txtSem6PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem6Op1CS.Text = "0";
                    txtSem6Op1CSV.Text = "0";
                }

                #endregion

                #region % PP
                if (txtSem1PCP.Text != "0")
                {
                    txtSem1PPCS.Text = Math.Round((Convert.ToDouble(txtSem1ProdPPCS.Text) / Convert.ToDouble(txtSem1PCP.Text))).ToString();
                    txtSem1PPCSV.Text = Math.Round((Convert.ToDouble(txtSem1ProdPPCS.Text) / Convert.ToDouble(txtSem1PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem1PPCS.Text = "0";
                    txtSem1PPCSV.Text = "0";
                }

                if (txtSem2PCP.Text != "0")
                {
                    txtSem2PPCS.Text = Math.Round((Convert.ToDouble(txtSem2ProdPPCS.Text) / Convert.ToDouble(txtSem2PCP.Text))).ToString();
                    txtSem2PPCSV.Text = Math.Round((Convert.ToDouble(txtSem2ProdPPCS.Text) / Convert.ToDouble(txtSem2PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem2PPCS.Text = "0";
                    txtSem2PPCSV.Text = "0";
                }

                if (txtSem3PCP.Text != "0")
                {
                    txtSem3PPCS.Text = Math.Round((Convert.ToDouble(txtSem3ProdPPCS.Text) / Convert.ToDouble(txtSem3PCP.Text))).ToString();
                    txtSem3PPCSV.Text = Math.Round((Convert.ToDouble(txtSem3ProdPPCS.Text) / Convert.ToDouble(txtSem3PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem3PPCS.Text = "0";
                    txtSem3PPCSV.Text = "0";
                }

                if (txtSem4PCP.Text != "0")
                {
                    txtSem4PPCS.Text = Math.Round((Convert.ToDouble(txtSem4ProdPPCS.Text) / Convert.ToDouble(txtSem4PCP.Text))).ToString();
                    txtSem4PPCSV.Text = Math.Round((Convert.ToDouble(txtSem4ProdPPCS.Text) / Convert.ToDouble(txtSem4PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem4PPCS.Text = "0";
                    txtSem4PPCSV.Text = "0";
                }

                if (txtSem5PCP.Text != "0")
                {
                    txtSem5PPCS.Text = Math.Round((Convert.ToDouble(txtSem5ProdPPCS.Text) / Convert.ToDouble(txtSem5PCP.Text))).ToString();
                    txtSem5PPCSV.Text = Math.Round((Convert.ToDouble(txtSem5ProdPPCS.Text) / Convert.ToDouble(txtSem5PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem5PPCS.Text = "0";
                    txtSem5PPCSV.Text = "0";
                }

                if (txtSem6PCP.Text != "0")
                {
                    txtSem6PPCS.Text = Math.Round((Convert.ToDouble(txtSem6ProdPPCS.Text) / Convert.ToDouble(txtSem6PCP.Text))).ToString();
                    txtSem6PPCSV.Text = Math.Round((Convert.ToDouble(txtSem6ProdPPCS.Text) / Convert.ToDouble(txtSem6PCP.Text))).ToString("0.00%");
                }
                else
                {
                    txtSem6PPCSV.Text = "0";
                    txtSem6PPCS.Text = "0";
                }
                #endregion

                #endregion

                #region Solapa Depósito & Logistica

                txtSem1TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem1InvRevDL.Text) + Convert.ToDouble(txtSem1ProdLocDL.Text)) / 1000).ToString();

                txtSem2TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem2InvRevDL.Text) + Convert.ToDouble(txtSem2ProdLocDL.Text)) / 1000).ToString();

                txtSem3TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem3InvRevDL.Text) + Convert.ToDouble(txtSem3ProdLocDL.Text)) / 1000).ToString();

                txtSem4TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem4InvRevDL.Text) + Convert.ToDouble(txtSem4ProdLocDL.Text)) / 1000).ToString();

                txtSem5TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem5InvRevDL.Text) + Convert.ToDouble(txtSem5ProdLocDL.Text)) / 1000).ToString();

                txtSem6TotInvDL.Text = Math.Round((Convert.ToDouble(txtSem6InvRevDL.Text) + Convert.ToDouble(txtSem6ProdLocDL.Text)) / 1000).ToString();

                // Termina. 

                // Calculo del indice de rotacion de PTL
                if (txtSem1ProdLocDL.Text != "0" && txtSem1DispPTL.Text != "0")
                {
                    txtSem1IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem1DispPTL.Text) / Convert.ToDouble(txtSem1ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem1IndRotPTL.Text = "0";
                }


                if (txtSem2ProdLocDL.Text != "0" && txtSem2DispPTL.Text != "0")
                {
                    txtSem2IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem2DispPTL.Text) / Convert.ToDouble(txtSem2ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem2IndRotPTL.Text = "0";
                }

                if (txtSem3ProdLocDL.Text != "0" && txtSem3DispPTL.Text != "0")
                {
                    txtSem3IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem3DispPTL.Text) / Convert.ToDouble(txtSem3ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem3IndRotPTL.Text = "0";
                }

                if (txtSem4ProdLocDL.Text != "0" && txtSem4DispPTL.Text != "0")
                {
                    txtSem4IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem4DispPTL.Text) / Convert.ToDouble(txtSem4ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem4IndRotPTL.Text = "0";
                }

                if (txtSem5ProdLocDL.Text != "0" && txtSem5DispPTL.Text != "0")
                {
                    txtSem5IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem5DispPTL.Text) / Convert.ToDouble(txtSem5ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem5IndRotPTL.Text = "0";
                }

                if (txtSem6ProdLocDL.Text != "0" && txtSem6DispPTL.Text != "0")
                {
                    txtSem6IndRotPTL.Text = Math.Round((Convert.ToDouble(txtSem6DispPTL.Text) / Convert.ToDouble(txtSem6ProdLocDL.Text))).ToString();
                }
                else
                {
                    txtSem6IndRotPTL.Text = "0";
                }

                // Calculo el indice de rotacion de PTI

                if (txtSem1InvRevDL.Text != "0" && txtSem1DispPTI.Text != "0")
                {
                    txtSem1IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem1DispPTI.Text) / Convert.ToDouble(txtSem1InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem1IndRotPTI.Text = "0";
                }

                if (txtSem2InvRevDL.Text != "0" && txtSem2DispPTI.Text != "0")
                {
                    txtSem2IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem2DispPTI.Text) / Convert.ToDouble(txtSem2InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem2IndRotPTI.Text = "0";
                }

                if (txtSem3InvRevDL.Text != "0" && txtSem3DispPTI.Text != "0")
                {
                    txtSem3IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem3DispPTI.Text) / Convert.ToDouble(txtSem3InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem3IndRotPTI.Text = "0";
                }
                if (txtSem4InvRevDL.Text != "0" && txtSem4DispPTI.Text != "0")
                {
                    txtSem4IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem4DispPTI.Text) / Convert.ToDouble(txtSem4InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem4IndRotPTI.Text = "0";
                }

                if (txtSem5InvRevDL.Text != "0" && txtSem5DispPTI.Text != "0")
                {
                    txtSem5IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem5DispPTI.Text) / Convert.ToDouble(txtSem5InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem5IndRotPTI.Text = "0";
                }

                if (txtSem6InvRevDL.Text != "0" && txtSem6DispPTI.Text != "0")
                {
                    txtSem6IndRotPTI.Text = Math.Round((Convert.ToDouble(txtSem6DispPTI.Text) / Convert.ToDouble(txtSem6InvRevDL.Text))).ToString();
                }
                else
                {
                    txtSem6IndRotPTI.Text = "0";
                }

                #endregion

                #region Gestión de Calidad
                if (txtSem1MermCP.Text != "0")
                {
                    txtSem1RecAprb.Text = Math.Round((Convert.ToDouble(txtSem1KgRecAprb.Text) / Convert.ToDouble(txtSem1MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem1RecAprb.Text = "0";
                }

                if (txtSem2MermCP.Text != "0")
                {
                    txtSem2RecAprb.Text = Math.Round((Convert.ToDouble(txtSem2KgRecAprb.Text) / Convert.ToDouble(txtSem2MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem2RecAprb.Text = "0";
                }

                if (txtSem3MermCP.Text != "0")
                {
                    txtSem3RecAprb.Text = Math.Round((Convert.ToDouble(txtSem3KgRecAprb.Text) / Convert.ToDouble(txtSem3MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem3RecAprb.Text = "0";
                }

                if (txtSem4MermCP.Text != "0")
                {
                    txtSem4RecAprb.Text = Math.Round((Convert.ToDouble(txtSem4KgRecAprb.Text) / Convert.ToDouble(txtSem4MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem4RecAprb.Text = "0";
                }

                if (txtSem5MermCP.Text != "0")
                {
                    txtSem5RecAprb.Text = Math.Round((Convert.ToDouble(txtSem5KgRecAprb.Text) / Convert.ToDouble(txtSem5MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem5RecAprb.Text = "0";
                }

                if (txtSem6MermCP.Text != "0")
                {
                    txtSem6RecAprb.Text = Math.Round((Convert.ToDouble(txtSem6KgRecAprb.Text) / Convert.ToDouble(txtSem6MermCP.Text) * 100)).ToString();
                }
                else
                {
                    txtSem6RecAprb.Text = "0";
                }

                #endregion

                CargarCharts();

                CalculoTotales();

            #endregion
        }

        #endregion

        #region Boton Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiarCharts();
            calculoTodo();
        }
        #endregion

        #region Limpiar Charts
        private void limpiarCharts()
        {

            chrExt.Series.Clear();
            chrExt.Legends.Clear();
            chrCP.Series.Clear();
            chrCP.Legends.Clear();
            chrDL.Series.Clear();
            chrDL.Legends.Clear();
            chrGdC.Series.Clear();
            chrGdC.Legends.Clear();
            chrCS.Series.Clear();
            chrCS.Legends.Clear();
            chrMet.Series.Clear();
            chrMet.Legends.Clear();
            chrTotPlanta.Series.Clear();
            chrTotPlanta.Legends.Clear();

        }
        #endregion

        #region Cambio de mes por cambio de año
        
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex == 0)
            {
                cmbMes.SelectedIndex = 1;
                cmbMes.SelectedIndex = 0;
            }
            else
            {
                cmbMes.SelectedIndex = 0;
            }
        }
        #endregion

        #region Calculo de % Cumplimiento
        private void cumplimiento()
        {

            #region Solapa Extrusión
            // Cumplimieto de Producción.
            if (Convert.ToDouble(txtObjetivoProd.Text) > Convert.ToDouble(txtTotalProd.Text))
	        {
                txtCumpProd.Text = Math.Round(Convert.ToDouble(txtTotalProd.Text) / Convert.ToDouble(txtObjetivoProd.Text)).ToString();
            }
            else
            {
                txtCumpProd.Text = Math.Round(Convert.ToDouble(txtObjetivoProd.Text) / Convert.ToDouble(txtTotalProd.Text)).ToString();
            }

            // Cumplimiento de Cambios. 

            if (Convert.ToDouble(txtTotalCambios.Text) > Convert.ToDouble(txtObjetivoCambios.Text))
            {
                txtCumpCambios.Text = Math.Round(Convert.ToDouble(txtTotalCambios.Text) / Convert.ToDouble(txtObjetivoCambios.Text)).ToString();
            }
            else
            {
                txtCumpCambios.Text = Math.Round(Convert.ToDouble(txtObjetivoCambios.Text) / Convert.ToDouble(txtTotalCambios.Text)).ToString();
            }

            // Cumplimiento de Lote Promedio
            if (Convert.ToDouble(txtTotalLote.Text) > Convert.ToDouble(txtObjetivoLote.Text))
            {
                txtCumpCambios.Text = Math.Round(Convert.ToDouble(txtTotalLote.Text) / Convert.ToDouble(txtObjetivoLote.Text)).ToString();
            }
            else
            {
                txtCumpCambios.Text = Math.Round(Convert.ToDouble(txtObjetivoLote.Text) / Convert.ToDouble(txtTotalLote.Text)).ToString();
            }

            // Cumplimiento de Total Merma.
            if (Convert.ToDouble(txtTotalMerma.Text) > Convert.ToDouble(txtObjetivoMerma.Text))
            {
                txtCumpMerma.Text = (Convert.ToDouble(txtObjetivoMerma.Text) / Convert.ToDouble(txtTotalMerma.Text)).ToString();
            }
            else
            {
                txtCumpMerma.Text = (Convert.ToDouble(txtTotalMerma.Text) / Convert.ToDouble(txtObjetivoMerma.Text)).ToString();
            }

            // Cumplimiento de % de EFiciencia. 

            if (Convert.ToDouble(txtTotalEfi.Text) > Convert.ToDouble(txtObjetivoEf.Text))
            {
                txtCumpEfi.Text = (Convert.ToDouble(txtTotalEfi.Text) / Convert.ToDouble(txtObjetivoEf.Text)).ToString();
                txtPorcCumpV.Text = (Convert.ToDouble(txtTotalEfi.Text) / Convert.ToDouble(txtObjetivoEf.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpEfi.Text = (Convert.ToDouble(txtObjetivoEf.Text) / Convert.ToDouble(txtTotalEfi.Text)).ToString();
                txtPorcCumpV.Text = (Convert.ToDouble(txtTotalEfi.Text) / Convert.ToDouble(txtObjetivoEf.Text)).ToString("0.00%");
            }

            // Cumplmiento de Consumo de Recuperado. 

            if (Convert.ToDouble(txtTotalConsRecu.Text) > Convert.ToDouble(txtObjetivoRecup.Text))
            {
                txtCumpConRecu.Text = (Convert.ToDouble(txtTotalConsRecu.Text) / Convert.ToDouble(txtObjetivoRecup.Text)).ToString();
            }
            else
            {
                txtCumpConRecu.Text = (Convert.ToDouble(txtObjetivoRecup.Text) / Convert.ToDouble(txtTotalConsRecu.Text)).ToString();
            }

            // Cumplimiento de % de recuperado

            if (Convert.ToDouble(txtTotalRecu.Text) > Convert.ToDouble(txtObjetivoPorRecup.Text))
            {
                txtCumpRecup.Text = (Convert.ToDouble(txtTotalRecu.Text) / Convert.ToDouble(txtObjetivoPorRecup.Text)).ToString();
                txtRecCumpV.Text = (Convert.ToDouble(txtTotalRecu.Text) / Convert.ToDouble(txtObjetivoPorRecup.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpRecup.Text = (Convert.ToDouble(txtObjetivoPorRecup.Text) / Convert.ToDouble(txtTotalRecu.Text)).ToString();
                txtRecCumpV.Text = (Convert.ToDouble(txtObjetivoPorRecup.Text) / Convert.ToDouble(txtTotalRecu.Text)).ToString("0.00%");
            }
            #endregion

            #region Solapa Corte Primario

            // Produccion
            if (Convert.ToDouble(txtTotProdCP.Text) > Convert.ToDouble(txtObjProdCP.Text))
            {
                txtCumpProdCP.Text = (Convert.ToDouble(txtTotProdCP.Text) / Convert.ToDouble(txtObjProdCP.Text)).ToString();
            }
            else
            {
                txtCumpProdCP.Text = (Convert.ToDouble(txtObjProdCP.Text) / Convert.ToDouble(txtTotProdCP.Text)).ToString();
            }

            // Repeticiones Promedio
            if (Convert.ToDouble(txtTotRepPromCP.Text) > Convert.ToDouble(txtObjRepPromCP.Text))
            {
                txtCumpRepPromCP.Text = (Convert.ToDouble(txtTotRepPromCP.Text) / Convert.ToDouble(txtObjRepPromCP.Text)).ToString();
            }
            else
            {
                txtCumpRepPromCP.Text = (Convert.ToDouble(txtObjRepPromCP.Text) / Convert.ToDouble(txtTotRepPromCP.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotMermaCP.Text) > Convert.ToDouble(txtObjMermaCP.Text))
            {
                txtCumpMermaCP.Text = (Convert.ToDouble(txtTotMermaCP.Text) / Convert.ToDouble(txtObjMermaCP.Text)).ToString();
            }
            else
            {
                txtCumpMermaCP.Text = (Convert.ToDouble(txtObjMermaCP.Text) / Convert.ToDouble(txtTotMermaCP.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiCP.Text) > Convert.ToDouble(txtObjEfiCP.Text))
            {
                txtCumpEfiCP.Text = (Convert.ToDouble(txtTotEfiCP.Text) / Convert.ToDouble(txtObjEfiCP.Text)).ToString();
                txtCumpEfiCPV.Text = (Convert.ToDouble(txtTotEfiCP.Text) / Convert.ToDouble(txtObjEfiCP.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpEfiCP.Text = (Convert.ToDouble(txtObjEfiCP.Text) / Convert.ToDouble(txtTotEfiCP.Text)).ToString();
                txtCumpEfiCPV.Text = (Convert.ToDouble(txtObjEfiCP.Text) / Convert.ToDouble(txtTotEfiCP.Text)).ToString("0.00%");
            }
            #endregion

            #region Solapa Metalizado
            if (Convert.ToDouble(txtTotProdGrl.Text) > Convert.ToDouble(txtObjProdM.Text))
            {
                txtCumpProdGnrlM.Text = (Convert.ToDouble(txtTotProdGrl.Text) / Convert.ToDouble(txtObjProdM.Text)).ToString();
            }
            else
            {
                txtCumpProdGnrlM.Text = (Convert.ToDouble(txtObjProdM.Text) / Convert.ToDouble(txtTotProdGrl.Text)).ToString();
            }


            if (Convert.ToDouble(txtTotCantBobM.Text) > Convert.ToDouble(txtObjCantBobM.Text))
            {
                txtCumpCantBobM.Text = (Convert.ToDouble(txtTotCantBobM.Text) / Convert.ToDouble(txtObjCantBobM.Text)).ToString();
            }
            else
            {
                txtCumpCantBobM.Text = (Convert.ToDouble(txtObjCantBobM.Text) / Convert.ToDouble(txtTotCantBobM.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotBobPromM.Text) > Convert.ToDouble(txtObjBPromM.Text))
            {
                txtCumpBobPromM.Text = (Convert.ToDouble(txtTotBobPromM.Text) / Convert.ToDouble(txtObjBPromM.Text)).ToString();
            }
            else
            {
                txtCumpBobPromM.Text = (Convert.ToDouble(txtObjBPromM.Text) / Convert.ToDouble(txtTotBobPromM.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotMermGrlM.Text) > Convert.ToDouble(txtObjMermM.Text))
            {
                txtCumpMermGrnlM.Text = (Convert.ToDouble(txtTotMermGrlM.Text) / Convert.ToDouble(txtObjMermM.Text)).ToString();
            }
            else
            {
                txtCumpMermGrnlM.Text = (Convert.ToDouble(txtObjMermM.Text) / Convert.ToDouble(txtTotMermGrlM.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiM.Text) > Convert.ToDouble(txtObjEfiM.Text))
            {
                txtCumpEfiM.Text = (Convert.ToDouble(txtTotEfiM.Text) / Convert.ToDouble(txtObjEfiM.Text)).ToString();
                txtCumpEfiMV.Text = (Convert.ToDouble(txtTotEfiM.Text) / Convert.ToDouble(txtObjEfiM.Text)).ToString("0.00%"); 
            }
            else
            {
                txtCumpEfiM.Text = (Convert.ToDouble(txtObjEfiM.Text) / Convert.ToDouble(txtTotEfiM.Text)).ToString();
                txtCumpEfiMV.Text = (Convert.ToDouble(txtObjEfiM.Text) / Convert.ToDouble(txtTotEfiM.Text)).ToString("0.00%");
            }


            if (Convert.ToDouble(txtTotPromMetM.Text) > Convert.ToDouble(txtObjProdMM.Text))
            {
                txtCumpProdMetM.Text = (Convert.ToDouble(txtTotPromMetM.Text) / Convert.ToDouble(txtObjProdMM.Text)).ToString();
            }
            else
            {
                txtCumpProdMetM.Text = (Convert.ToDouble(txtObjProdMM.Text) > Convert.ToDouble(txtTotPromMetM.Text)).ToString();
            }

            if (Convert.ToDouble(txtMermMetM.Text) > Convert.ToDouble(txtObjMermMM.Text))
            {
                txtCumpMermMetM.Text = (Convert.ToDouble(txtMermMetM.Text) / Convert.ToDouble(txtObjMermMM.Text)).ToString();
            }
            else
            {
                txtCumpMermMetM.Text = (Convert.ToDouble(txtObjMermMM.Text) / Convert.ToDouble(txtMermMetM.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiMetM.Text) > Convert.ToDouble(txtObjEfiMM.Text))
            {
                txtCumpEfiMetM.Text = (Convert.ToDouble(txtTotEfiMetM.Text) / Convert.ToDouble(txtObjEfiMM.Text)).ToString();
                txtCumpEfiMetMV.Text = (Convert.ToDouble(txtTotEfiMetM.Text) / Convert.ToDouble(txtObjEfiMM.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpEfiMetM.Text = (Convert.ToDouble(txtObjEfiMM.Text) / Convert.ToDouble(txtTotEfiMetM.Text)).ToString();
                txtCumpEfiMetMV.Text = (Convert.ToDouble(txtObjEfiMM.Text) / Convert.ToDouble(txtTotEfiMetM.Text)).ToString("0.00%");
            }

            if (Convert.ToDouble(txtTotTotMermM.Text) > Convert.ToDouble(txtObjTotMerMM.Text))
            {
                txtCumpTotMermMetM.Text = (Convert.ToDouble(txtTotTotMermM.Text) / Convert.ToDouble(txtObjTotMerMM.Text)).ToString();
            }
            else
            {
                txtCumpTotMermMetM.Text = (Convert.ToDouble(txtObjTotMerMM.Text) / Convert.ToDouble(txtTotTotMermM.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiMetMetMM.Text) > Convert.ToDouble(txtObjEfiMetM.Text))
            {
                txtCumpTotEfiMetM.Text = (Convert.ToDouble(txtTotEfiMetMetMM.Text) / Convert.ToDouble(txtObjEfiMetM.Text)).ToString();
                txtCumpTotEfiMetMV.Text = (Convert.ToDouble(txtTotEfiMetMetMM.Text) / Convert.ToDouble(txtObjEfiMetM.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpTotEfiMetM.Text = (Convert.ToDouble(txtObjEfiMetM.Text) / Convert.ToDouble(txtTotEfiMetMetMM.Text)).ToString();
                txtCumpTotEfiMetMV.Text = (Convert.ToDouble(txtObjEfiMetM.Text) / Convert.ToDouble(txtTotEfiMetMetMM.Text)).ToString("0.00%");
            }


            #endregion

            #region Solapa Corte Secundario

            if (Convert.ToDouble(txtTotProdCS.Text) > Convert.ToDouble(txtObjProdCS.Text))
            {
                txtCumpProdCS.Text = (Convert.ToDouble(txtTotProdCS.Text) / Convert.ToDouble(txtObjProdCS.Text)).ToString();
            }
            else
            {
                txtCumpProdCS.Text = (Convert.ToDouble(txtObjProdCS.Text) / Convert.ToDouble(txtTotProdCS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotMermaCS.Text) > Convert.ToDouble(txtObjMermCS.Text))
            {
                txtCumpMermaCS.Text = (Convert.ToDouble(txtTotMermaCS.Text) / Convert.ToDouble(txtObjMermCS.Text)).ToString();
            }
            else
            {
                txtCumpMermaCS.Text = (Convert.ToDouble(txtObjMermCS.Text) > Convert.ToDouble(txtTotMermaCS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiCS.Text) > Convert.ToDouble(txtObjEfiCS.Text))
            {
                txtCumpEfiCS.Text = (Convert.ToDouble(txtTotEfiCS.Text) / Convert.ToDouble(txtObjEfiCS.Text)).ToString();
                txtCumpEfiCSV.Text = (Convert.ToDouble(txtTotEfiCS.Text) / Convert.ToDouble(txtObjEfiCS.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpEfiCS.Text = (Convert.ToDouble(txtObjEfiCS.Text) / Convert.ToDouble(txtTotEfiCS.Text)).ToString();
                txtCumpEfiCSV.Text = (Convert.ToDouble(txtObjEfiCS.Text) / Convert.ToDouble(txtTotEfiCS.Text)).ToString("0.00%");
            }

            if (Convert.ToDouble(txtTotMermaP2CS.Text) > Convert.ToDouble(txtObjTotMermCS.Text))
            {
                txtCumpTotMermP2CS.Text = (Convert.ToDouble(txtTotMermaP2CS.Text) / Convert.ToDouble(txtObjTotMermCS.Text)).ToString();
            }
            else
            {
                txtCumpTotMermP2CS.Text = (Convert.ToDouble(txtObjTotMermCS.Text) / Convert.ToDouble(txtTotMermaP2CS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotEfiP2CS.Text) > Convert.ToDouble(txtObjEfiP2CS.Text))
            {
                txtCumpEfiP2CS.Text = (Convert.ToDouble(txtTotEfiP2CS.Text) / Convert.ToDouble(txtObjEfiP2CS.Text)).ToString();
                txtCumpEfiP2CSV.Text = (Convert.ToDouble(txtTotEfiP2CS.Text) / Convert.ToDouble(txtObjEfiP2CS.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpEfiP2CS.Text = (Convert.ToDouble(txtObjEfiP2CS.Text) / Convert.ToDouble(txtTotEfiP2CS.Text)).ToString();
                txtCumpEfiP2CSV.Text = (Convert.ToDouble(txtObjEfiP2CS.Text) / Convert.ToDouble(txtTotEfiP2CS.Text)).ToString("0.00%");
            }


            if (Convert.ToDouble(txtTotOptRecCS.Text) > Convert.ToDouble(txtObjOptRecCS.Text))
            {
                txtCumpOptRecCS.Text = (Convert.ToDouble(txtTotOptRecCS.Text) / Convert.ToDouble(txtObjOptRecCS.Text)).ToString();
            }
            else
            {
                txtCumpOptRecCS.Text = (Convert.ToDouble(txtObjOptRecCS.Text) / Convert.ToDouble(txtTotOptRecCS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotProdOP1CS.Text) > Convert.ToDouble(txtObjProdOP1CS.Text))
            {
                txtCumpProdOPCS.Text = (Convert.ToDouble(txtTotProdOP1CS.Text) / Convert.ToDouble(txtObjProdOP1CS.Text)).ToString();
            }
            else
            {
                txtCumpProdOPCS.Text = (Convert.ToDouble(txtObjProdOP1CS.Text) / Convert.ToDouble(txtTotProdOP1CS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotProdPPCS.Text) > Convert.ToDouble(txtObjProdPPCS.Text))
            {
                txtCumpProdPPCS.Text = (Convert.ToDouble(txtTotProdPPCS.Text) / Convert.ToDouble(txtObjProdPPCS.Text)).ToString();
            }
            else
            {
                txtCumpProdPPCS.Text = (Convert.ToDouble(txtObjProdPPCS.Text) / Convert.ToDouble(txtTotProdPPCS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotOP1CS.Text) > Convert.ToDouble(txtObjPorcOp1CS.Text))
            {
                txtCumpPOPCS.Text = (Convert.ToDouble(txtTotOP1CS.Text) / Convert.ToDouble(txtObjPorcOp1CS.Text)).ToString();
            }
            else
            {
                txtCumpPOPCS.Text = (Convert.ToDouble(txtObjPorcOp1CS.Text) / Convert.ToDouble(txtTotOP1CS.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotPPCS.Text) > Convert.ToDouble(txtObjPorcPPCS.Text))
            {
                txtCumpPPCS.Text = (Convert.ToDouble(txtTotPPCS.Text) / Convert.ToDouble(txtObjPorcPPCS.Text)).ToString();
                txtCumpPPCSV.Text = (Convert.ToDouble(txtTotPPCS.Text) / Convert.ToDouble(txtObjPorcPPCS.Text)).ToString("0.00%");
            }
            else
            {
                txtCumpPPCS.Text = (Convert.ToDouble(txtObjPorcPPCS.Text) / Convert.ToDouble(txtTotPPCS.Text)).ToString();
                txtCumpPPCSV.Text = (Convert.ToDouble(txtObjPorcPPCS.Text) / Convert.ToDouble(txtTotPPCS.Text)).ToString("0.00%");
            }

            #endregion

            #region Solapa Depósito & Logística

            if (Convert.ToDouble(txtTotProdLocDL.Text) > Convert.ToDouble(txtObjProdLocDL.Text))
            {
                txtCumpInvProdLocDL.Text = (Convert.ToDouble(txtTotProdLocDL.Text) / Convert.ToDouble(txtObjProdLocDL.Text)).ToString();
            }
            else
            {
                txtCumpInvProdLocDL.Text = (Convert.ToDouble(txtObjProdLocDL.Text) / Convert.ToDouble(txtTotProdLocDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotInvRevDL.Text) > Convert.ToDouble(txtObjInvRevDL.Text))
            {
                txtCumpInvRevDL.Text = (Convert.ToDouble(txtTotInvRevDL.Text) / Convert.ToDouble(txtObjInvRevDL.Text)).ToString();
            }
            else
            {
                txtCumpInvRevDL.Text = (Convert.ToDouble(txtObjInvRevDL.Text) / Convert.ToDouble(txtTotInvRevDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotTotInvDL.Text) > Convert.ToDouble(txtObjTotInvDL.Text))
            {
                txtCumpTotInvDL.Text = (Convert.ToDouble(txtTotTotInvDL.Text) / Convert.ToDouble(txtObjTotInvDL.Text)).ToString();
            }
            else
            {
                txtCumpTotInvDL.Text = (Convert.ToDouble(txtObjTotInvDL.Text) / Convert.ToDouble(txtTotTotInvDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotPromAgeDL.Text) > Convert.ToDouble(txtObjAgePromLocDL.Text))
            {
                txtCumpPromAgeLDL.Text = (Convert.ToDouble(txtTotPromAgeDL.Text) / Convert.ToDouble(txtObjAgePromLocDL.Text)).ToString();
            }
            else
            {
                txtCumpPromAgeLDL.Text = (Convert.ToDouble(txtObjAgePromLocDL.Text) / Convert.ToDouble(txtTotPromAgeDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotAgePromDL.Text) > Convert.ToDouble(txtObjAgePromRevDL.Text))
            {
                txtCumpAgePromRDL.Text = (Convert.ToDouble(txtTotAgePromDL.Text) / Convert.ToDouble(txtObjAgePromRevDL.Text)).ToString();
            }
            else
            {
                txtCumpAgePromRDL.Text = (Convert.ToDouble(txtObjAgePromRevDL.Text) / Convert.ToDouble(txtTotAgePromDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotDespPTLDL.Text) > Convert.ToDouble(txtObjDespPTLDL.Text))
            {
                txtCumpDespPTL.Text = (Convert.ToDouble(txtTotDespPTLDL.Text) / Convert.ToDouble(txtObjDespPTLDL.Text)).ToString();
            }
            else
            {
                txtCumpDespPTL.Text = (Convert.ToDouble(txtObjDespPTLDL.Text) / Convert.ToDouble(txtTotDespPTLDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotDespPTIDL.Text) > Convert.ToDouble(txtObjDispatchPTIDL.Text))
            {
                txtCumpDespPTI.Text = (Convert.ToDouble(txtTotDespPTIDL.Text) / Convert.ToDouble(txtObjDispatchPTIDL.Text)).ToString();
            }
            else
            {
                txtCumpDespPTI.Text = (Convert.ToDouble(txtObjDispatchPTIDL.Text) / Convert.ToDouble(txtTotDespPTIDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotIndRotPTLDL.Text) > Convert.ToDouble(txtObjDispatchPTIDL.Text))
            {
                txtCumpRotPTLDL.Text = (Convert.ToDouble(txtTotIndRotPTLDL.Text) / Convert.ToDouble(txtObjIndRotPTLDL.Text)).ToString();
            }
            else
            {
                txtCumpRotPTLDL.Text = (Convert.ToDouble(txtObjIndRotPTLDL.Text) / Convert.ToDouble(txtTotIndRotPTLDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotIndRotPTIDL.Text) > Convert.ToDouble(txtObjIndRotPTIDL.Text))
            {
                txtCumpIndRotPTIDL.Text = (Convert.ToDouble(txtTotIndRotPTIDL.Text) / Convert.ToDouble(txtObjIndRotPTIDL.Text)).ToString();
            }
            else
            {
                txtCumpIndRotPTIDL.Text = (Convert.ToDouble(txtObjIndRotPTIDL.Text) / Convert.ToDouble(txtTotIndRotPTIDL.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotIndRotPTIDL.Text) > Convert.ToDouble(txtObjIndRotPTIDL.Text))
            {
                txtCumpIndRotPTIDL.Text = (Convert.ToDouble(txtTotIndRotPTIDL.Text) / Convert.ToDouble(txtObjIndRotPTIDL.Text)).ToString();
            }
            else
            {
                txtCumpIndRotPTIDL.Text = (Convert.ToDouble(txtObjIndRotPTIDL.Text) / Convert.ToDouble(txtTotIndRotPTIDL.Text)).ToString();
            }

            #endregion

            #region Solapa Gestión de Calidad
            if (Convert.ToDouble(txtTotRecIng.Text) > Convert.ToDouble(txtObjRecIngGdC.Text))
            {
                txtCumpRecIngGdC.Text = (Convert.ToDouble(txtTotRecIng.Text) / Convert.ToDouble(txtObjRecIngGdC.Text)).ToString();
            }
            else
            {
                txtCumpRecIngGdC.Text = (Convert.ToDouble(txtObjRecIngGdC.Text) / Convert.ToDouble(txtTotRecIng.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotKgRecIng.Text) > Convert.ToDouble(txtObjKgRecIngGdC.Text))
            {
                txtCumpKgRecIngGdC.Text = (Convert.ToDouble(txtTotKgRecIng.Text) / Convert.ToDouble(txtObjKgRecIngGdC.Text)).ToString();
            }
            else
            {
                txtCumpKgRecIngGdC.Text = (Convert.ToDouble(txtObjKgRecIngGdC.Text) / Convert.ToDouble(txtTotKgRecIng.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotRecAprb.Text) > Convert.ToDouble(txtObjRecAprbGdC.Text))
            {
                txtCumpRecAprbGdC.Text = (Convert.ToDouble(txtTotRecAprb.Text) / Convert.ToDouble(txtObjRecAprbGdC.Text)).ToString();
            }
            else
            {
                txtCumpRecAprbGdC.Text = (Convert.ToDouble(txtObjRecAprbGdC.Text) / Convert.ToDouble(txtTotRecAprb.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotKgRecAprb.Text) > Convert.ToDouble(txtObjKgRecAprbGdC.Text))
            {
                txtCumpKgRecAprbGdC.Text = (Convert.ToDouble(txtTotKgRecAprb.Text) / Convert.ToDouble(txtObjKgRecAprbGdC.Text)).ToString();
            }
            else
            {
                txtCumpKgRecAprbGdC.Text = (Convert.ToDouble(txtObjKgRecAprbGdC.Text) / Convert.ToDouble(txtTotKgRecAprb.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotRecAprbGdC.Text) > Convert.ToDouble(txtObjPorcRecAprbGdC.Text))
            {
                txtCumpPorcRecAprbGdC.Text = (Convert.ToDouble(txtTotRecAprbGdC.Text) / Convert.ToDouble(txtObjPorcRecAprbGdC.Text)).ToString();
            }
            else
            {
                txtCumpPorcRecAprbGdC.Text = (Convert.ToDouble(txtObjPorcRecAprbGdC.Text) / Convert.ToDouble(txtTotRecAprbGdC.Text)).ToString();
            }

            if (Convert.ToDouble(txtTotDevIngBPT.Text) > Convert.ToDouble(txtObjDevIngBPTGdc.Text))
            {
                txtCumpDevIngBPTGdC.Text = (Convert.ToDouble(txtTotDevIngBPT.Text) / Convert.ToDouble(txtObjDevIngBPTGdc.Text)).ToString();
            }
            else
            {
                txtCumpDevIngBPTGdC.Text = (Convert.ToDouble(txtObjDevIngBPTGdc.Text) / Convert.ToDouble(txtTotDevIngBPT.Text)).ToString();
            }
            #endregion
        }

        #endregion

        #region Cambio de Estetica
        private void cambiarEstetica()
        {
            txtObjetivoCambios.BackColor = Color.LightGray;
            txtObjetivoEf.BackColor = Color.LightGray;
            txtObjetivoLote.BackColor = Color.LightGray;
            txtObjetivoMerma.BackColor = Color.LightGray;
            txtObjetivoPorRecup.BackColor = Color.LightGray;
            txtObjetivoProd.BackColor = Color.LightGray;
            txtObjetivoRecup.BackColor = Color.LightGray;
            txtObjAgePromLocDL.BackColor = Color.LightGray;
            txtObjAgePromRevDL.BackColor = Color.LightGray;
            txtObjRecV.BackColor = Color.LightGray;
            txtObjEfiV.BackColor = Color.LightGray;
            txtObjBPromM.BackColor = Color.LightGray;
            txtObjCantBobM.BackColor = Color.LightGray;
            txtObjDespPTLDL.BackColor = Color.LightGray;
            txtObjDevIngBPTGdc.BackColor = Color.LightGray;
            txtObjProdCS.BackColor = Color.LightGray;
            txtObjDispatchPTIDL.BackColor = Color.LightGray;
            txtObjEfiCP.BackColor = Color.LightGray;
            txtObjEfiCS.BackColor = Color.LightGray;
            txtObjEfiM.BackColor = Color.LightGray;
            txtObjEfiMetM.BackColor = Color.LightGray;
            txtObjEfiMM.BackColor = Color.LightGray;
            txtObjEfiP2CS.BackColor = Color.LightGray;
            txtObjIndRotPTIDL.BackColor = Color.LightGray;
            txtObjIndRotPTLDL.BackColor = Color.LightGray;
            txtObjInvRevDL.BackColor = Color.LightGray;
            txtObjKgRecAprbGdC.BackColor = Color.LightGray;
            txtObjKgRecIngGdC.BackColor = Color.LightGray;
            txtObjMermaCP.BackColor = Color.LightGray;
            txtObjMermCS.BackColor = Color.LightGray;
            txtObjMermM.BackColor = Color.LightGray;
            txtObjMermMM.BackColor = Color.LightGray;
            txtObjOptRecCS.BackColor = Color.LightGray;
            txtObjPorcOp1CS.BackColor = Color.LightGray;
            txtObjPorcPPCS.BackColor = Color.LightGray;
            txtObjPorcRecAprbGdC.BackColor = Color.LightGray;
            txtObjProdCP.BackColor = Color.LightGray;
            txtObjProdLocDL.BackColor = Color.LightGray;
            txtObjProdM.BackColor = Color.LightGray;
            txtObjProdMM.BackColor = Color.LightGray;
            txtObjProdOP1CS.BackColor = Color.LightGray;
            txtObjProdPPCS.BackColor = Color.LightGray;
            txtObjRecAprbGdC.BackColor = Color.LightGray;
            txtObjRecIngGdC.BackColor = Color.LightGray;
            txtObjTotInvDL.BackColor = Color.LightGray;
            txtObjTotMermCS.BackColor = Color.LightGray;
            txtObjTotMerMM.BackColor = Color.LightGray;
            txtObjRepPromCP.BackColor = Color.LightGray;
            txtObjEfiCPV.BackColor = Color.LightGray;
            txtObjEfiMetMV.BackColor = Color.LightGray;
            txtObjEfiMMV.BackColor = Color.LightGray;
            txtObjEfiMetMV.BackColor = Color.LightGray;
            txtObjEfiMV.BackColor = Color.LightGray;
            txtTotalCambios.BackColor = Color.LightGoldenrodYellow;
            txtTotalConsRecu.BackColor = Color.LightGoldenrodYellow;
            txtPorcCumpV.BackColor = Color.LightGoldenrodYellow;
            txtTotRecV.BackColor = Color.LightGoldenrodYellow;
            txtRecCumpV.BackColor = Color.LightGoldenrodYellow;
            txtTotalEfi.BackColor = Color.LightGoldenrodYellow;
            txtTotalLote.BackColor = Color.LightGoldenrodYellow;
            txtTotalMerma.BackColor = Color.LightGoldenrodYellow;
            txtTotalProd.BackColor = Color.LightGoldenrodYellow;
            txtTotalRecu.BackColor = Color.LightGoldenrodYellow;
            txtTotProdCP.BackColor = Color.LightGoldenrodYellow;
            txtTotAgePromDL.BackColor = Color.LightGoldenrodYellow;
            txtTotBobPromM.BackColor = Color.LightGoldenrodYellow;
            txtTotCantBobM.BackColor = Color.LightGoldenrodYellow;
            txtTotDespPTIDL.BackColor = Color.LightGoldenrodYellow;
            txtTotDespPTLDL.BackColor = Color.LightGoldenrodYellow;
            txtTotDevIngBPT.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiCPV.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiCPV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiCP.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiCS.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiCSV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiM.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiMetM.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiMetMetMMV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiMetMetMM.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiP2CS.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiP2CSV.BackColor = Color.LightGoldenrodYellow;
            txtTotIndRotPTIDL.BackColor = Color.LightGoldenrodYellow;
            txtTotIndRotPTLDL.BackColor = Color.LightGoldenrodYellow;
            txtTotInvRevDL.BackColor = Color.LightGoldenrodYellow;
            txtTotKgRecAprb.BackColor = Color.LightGoldenrodYellow;
            txtTotKgRecIng.BackColor = Color.LightGoldenrodYellow;
            txtTotMermaCP.BackColor = Color.LightGoldenrodYellow;
            txtTotMermaCS.BackColor = Color.LightGoldenrodYellow;
            txtTotMermaP2CS.BackColor = Color.LightGoldenrodYellow;
            txtTotMermGrlM.BackColor = Color.LightGoldenrodYellow;
            txtTotOP1CS.BackColor = Color.LightGoldenrodYellow;
            txtTotOP1CSV.BackColor = Color.LightGoldenrodYellow;
            txtTotOptRecCS.BackColor = Color.LightGoldenrodYellow;
            txtTotPPCS.BackColor = Color.LightGoldenrodYellow;
            txtTotPPCSV.BackColor = Color.LightGoldenrodYellow;
            txtTotProdCP.BackColor = Color.LightGoldenrodYellow;
            txtMermMetM.BackColor = Color.LightGoldenrodYellow;
            txtTotProdCS.BackColor = Color.LightGoldenrodYellow;
            txtTotProdGrl.BackColor = Color.LightGoldenrodYellow;
            txtTotProdLocDL.BackColor = Color.LightGoldenrodYellow;
            txtTotProdOP1CS.BackColor = Color.LightGoldenrodYellow;
            txtTotProdPPCS.BackColor = Color.LightGoldenrodYellow;
            txtTotPromAgeDL.BackColor = Color.LightGoldenrodYellow;
            txtTotPromMetM.BackColor = Color.LightGoldenrodYellow;
            txtTotRecAprb.BackColor = Color.LightGoldenrodYellow;
            txtTotRecAprbGdC.BackColor = Color.LightGoldenrodYellow;
            txtTotRecAprbGdCV.BackColor = Color.LightGoldenrodYellow;
            txtTotRecIng.BackColor = Color.LightGoldenrodYellow;
            txtTotRepPromCP.BackColor = Color.LightGoldenrodYellow;
            txtTotTotInvDL.BackColor = Color.LightGoldenrodYellow;
            txtTotTotMermM.BackColor = Color.LightGoldenrodYellow;
            txtCumpProd.BackColor = Color.LightGoldenrodYellow;
            txtCumpCambios.BackColor = Color.LightGoldenrodYellow;
            txtCumpLote.BackColor = Color.LightGoldenrodYellow;
            txtCumpAgePromRDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpBobPromM.BackColor = Color.LightGoldenrodYellow;
            txtCumpCambios.BackColor = Color.LightGoldenrodYellow;
            txtCumpCantBobM.BackColor = Color.LightGoldenrodYellow;
            txtCumpConRecu.BackColor = Color.LightGoldenrodYellow;
            txtCumpDespPTI.BackColor = Color.LightGoldenrodYellow;
            txtCumpDespPTL.BackColor = Color.LightGoldenrodYellow;
            txtCumpDevIngBPTGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfi.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiCP.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiCSV.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiM.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiMV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiMV.BackColor = Color.LightGoldenrodYellow;
            txtCumpTotEfiMetMV.BackColor = Color.LightGoldenrodYellow;
            txtTotEfiMetMV.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiMetMV.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiMetM.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiP2CS.BackColor = Color.LightGoldenrodYellow;
            txtCumpEfiP2CSV.BackColor = Color.LightGoldenrodYellow;
            txtCumpIndRotPTIDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpInvProdLocDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpInvRevDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpKgRecAprbGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpKgRecIngGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpLote.BackColor = Color.LightGoldenrodYellow;
            txtCumpMerma.BackColor = Color.LightGoldenrodYellow;
            txtCumpMermaCP.BackColor = Color.LightGoldenrodYellow;
            txtCumpMermaCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpMermGrnlM.BackColor = Color.LightGoldenrodYellow;
            txtCumpMermMetM.BackColor = Color.LightGoldenrodYellow;
            txtCumpOptRecCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpPOPCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpPOPCSV.BackColor = Color.LightGoldenrodYellow;
            txtCumpPorcRecAprbGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpPorcRecAprbGdCV.BackColor = Color.LightGoldenrodYellow;
            txtCumpPPCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpPPCSV.BackColor = Color.LightGoldenrodYellow;
            txtCumpProd.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdCP.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdGnrlM.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdMetM.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdOPCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpProdPPCS.BackColor = Color.LightGoldenrodYellow;
            txtCumpPromAgeLDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpRecAprbGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpRecIngGdC.BackColor = Color.LightGoldenrodYellow;
            txtCumpRecup.BackColor = Color.LightGoldenrodYellow;
            txtCumpRepPromCP.BackColor = Color.LightGoldenrodYellow;
            txtCumpRotPTLDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpTotEfiMetM.BackColor = Color.LightGoldenrodYellow;
            txtCumpTotInvDL.BackColor = Color.LightGoldenrodYellow;
            txtCumpTotMermMetM.BackColor = Color.LightGoldenrodYellow;
            txtCumpTotMermP2CS.BackColor = Color.LightGoldenrodYellow;


        }
        #endregion

        #region Instanciar Delegados
        private void InstancioDelegados()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        #endregion

        private void frmKpis_Load(object sender, EventArgs e)
        {
            InstancioDelegados();
        }

        private void txtSem1ProdLocDL_TextChanged(object sender, EventArgs e)
        {
           // CargarCharts();
        }

        private void txtSem1ProdLocDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtObjEfiV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjEfiV.Text.EndsWith("%"))
            {
                txtObjetivoEf.Text = "";
                char delimitador = '%';
                string[] substring = txtObjEfiV.Text.Split(delimitador);
                txtObjetivoEf.Text = substring[0];
            }
            else
            {
                txtObjetivoEf.Text = "0";
            }
        }

        private void txtObjRecV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjRecV.Text.EndsWith("%"))
            {
                txtObjetivoPorRecup.Text = "";
                char delimitador = '%';
                string[] substring = txtObjRecV.Text.Split(delimitador);
                txtObjetivoPorRecup.Text = substring[0];
            }
            else
            {
                txtObjetivoPorRecup.Text = "0";
            }
        }

        private void txtObjEfiCPV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjEfiCPV.Text.EndsWith("%"))
            {
                txtObjEfiCP.Text = "";
                char delimitador = '%';
                string[] substring = txtObjEfiCPV.Text.Split(delimitador);
                txtObjEfiCP.Text = substring[0];
            }
            else
            {
                txtObjEfiCP.Text = "0";
            }
        }

        private void txtObjEfiMV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjEfiMV.Text.EndsWith("%"))
            {
                txtObjEfiM.Text = "";
                char delimitador = '%';
                string[] substring = txtObjEfiMV.Text.Split(delimitador);
                txtObjEfiM.Text = substring[0];
            }
            else
            {
                txtObjEfiM.Text = "0";
            }
        }

        private void txtObjEfiMetMV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjEfiMetMV.Text.EndsWith("%"))
            {
                txtObjEfiMetM.Text = "";
                char delimitador = '%';
                string[] substring = txtObjEfiMetMV.Text.Split(delimitador);
                txtObjEfiMetM.Text = substring[0];
            }
            else
            {
                txtObjEfiMetM.Text = "0";
            }
        }

        private void txtObjEfiMMV_TextChanged(object sender, EventArgs e)
        {
            if (txtObjEfiMMV.Text.EndsWith("%"))
            {
                txtObjEfiMM.Text = "";
                char delimitador = '%';
                string[] substring = txtObjEfiMMV.Text.Split(delimitador);
                txtObjEfiMM.Text = substring[0];
            }
            else
            {
                txtObjEfiMM.Text = "0";
            }
        }
    }
}

    