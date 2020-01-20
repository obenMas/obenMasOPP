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
    public partial class frmCuttingOrderPalletType : Form
    {
        frmCuttingOrderMultiple prntCuttingOrderMultiple;
        frmCuttingOrderMultipleCast prntCuttingOrderMultipleCast;
        frmSecundaryCuttingOrderMultiple prntSecundaryCuttingOrderMultiple;
        frmSecundaryCuttingOrder prntSecundaryCuttingOrder;
        string strCaller = "";
        
        public frmCuttingOrderPalletType()
        {
            InitializeComponent();
        }
        public frmCuttingOrderPalletType(frmCuttingOrderMultiple parent)
        {
            InitializeComponent();
            prntCuttingOrderMultiple = parent;
            strCaller = "cuttingOrderBopp";
        }
        public frmCuttingOrderPalletType(frmCuttingOrderMultipleCast parent)
        {
            InitializeComponent();
            prntCuttingOrderMultipleCast = parent;
            strCaller = "cuttingOrderCast";
        }
        public frmCuttingOrderPalletType(frmSecundaryCuttingOrderMultiple parent)
        {
            InitializeComponent();
            prntSecundaryCuttingOrderMultiple = parent;
            strCaller = "secundaryCuttingOrderMultiple";
        }

        public frmCuttingOrderPalletType(frmSecundaryCuttingOrder parent)
        {
            InitializeComponent();
            prntSecundaryCuttingOrder = parent;
            strCaller = "secundaryCuttingOrder";
        }

        private void frmCuttingOrderPalletType_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (strCaller)
            {
                case "cuttingOrderBopp":
                    prntCuttingOrderMultiple.TPallet = txtNotes.Text;
                    break;
                //case "cuttingOrderCast":
                //    prntCuttingOrderMultipleCast.TPallet = txtNotes.Text;
                //    break;
                case "secundaryCuttingOrder":
                    prntSecundaryCuttingOrder.TPallet = txtNotes.Text;
                    break;
                case "secundaryCuttingOrderMultiple":
                    prntSecundaryCuttingOrderMultiple.TPallet = txtNotes.Text;
                    break;
                default:
                    break;
            }
        }

        private void frmCuttingOrderPalletType_Load(object sender, EventArgs e)
        {
            switch (strCaller)
            {
                case "cuttingOrderBopp":
                    txtNotes.Text = prntCuttingOrderMultiple.TPallet;
                    break;
                case "secundaryCuttingOrder":
                    txtNotes.Text = prntSecundaryCuttingOrder.TPallet;
                    break;
                //case "cuttingOrderCast":
                //    txtNotes.Text = prntCuttingOrderMultipleCast.TPallet;
                //    break;
                case "secundaryCuttingOrderMultiple":
                    txtNotes.Text = prntSecundaryCuttingOrderMultiple.TPallet;
                    break;
                default:
                    break;
            }                
        }
    }
}
