using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using BPS.Manager.User;

namespace BPS
{
    public partial class frmCuttingOrderNotes : Form
    {
        frmCuttingOrderMultiple prntCuttingOrderMultiple;
        frmCuttingOrderMultipleCast prntCuttingOrderMultipleCast;
        frmSecundaryCuttingOrderMultiple prntSecundaryCuttingOrderMultiple;
        frmManagerList prntManagerList;
        frmProductionOrderDetails prntProductionOrderDetails;

        string strCaller = "";
        
        public frmCuttingOrderNotes()
        {
            InitializeComponent();
        }
        public frmCuttingOrderNotes(frmCuttingOrderMultiple parent)
        {
            InitializeComponent();
            prntCuttingOrderMultiple = parent;
            strCaller = "cuttingOrderBopp";
        }
        public frmCuttingOrderNotes(frmCuttingOrderMultipleCast parent)
        {
            InitializeComponent();
            prntCuttingOrderMultipleCast = parent;
            strCaller = "cuttingOrderCast";
        }
        public frmCuttingOrderNotes(frmSecundaryCuttingOrderMultiple parent)
        {
            InitializeComponent();
            prntSecundaryCuttingOrderMultiple = parent;
            strCaller = "secundaryCuttingOrder";
        }
        public frmCuttingOrderNotes(frmManagerList parent)
        {
            InitializeComponent();
            prntManagerList = parent;
            strCaller = "managerUserList";
        }

        public frmCuttingOrderNotes(frmProductionOrderDetails parent)
        {
            InitializeComponent();
            prntProductionOrderDetails = parent;
            strCaller = "productionOrderDetails";
        }

        private void frmCuttingOrderNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (strCaller)
            {
                case "cuttingOrderBopp":
                    prntCuttingOrderMultiple.Notes = txtNotes.Text;
                    break;
                case "cuttingOrderCast":
                    prntCuttingOrderMultipleCast.Notes = txtNotes.Text;
                    break;
                case "secundaryCuttingOrder":
                    prntSecundaryCuttingOrderMultiple.Notes = txtNotes.Text;
                    break;
                case "managerUserList":
                    prntManagerList.Notes = txtNotes.Text;
                    break;
                case "productionOrderDetails":
                    prntProductionOrderDetails.notesfull = txtNotes.Text;
                    break;
                default:
                    break;
            }
        }

        private void frmCuttingOrderNotes_Load(object sender, EventArgs e)
        {
            switch (strCaller)
            {
                case "cuttingOrderBopp":
                    txtNotes.Text = prntCuttingOrderMultiple.Notes;
                    break;
                case "cuttingOrderCast":
                    txtNotes.Text = prntCuttingOrderMultipleCast.Notes;
                    break;
                case "secundaryCuttingOrder":
                    txtNotes.Text = prntSecundaryCuttingOrderMultiple.Notes;
                    break;
                case "productionOrderDetails":
                    txtNotes.Text = prntProductionOrderDetails.notesfull;
                    break;
                default:
                    break;
            }                
        }
    }
}
