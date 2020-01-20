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
    public partial class frmExportDataInternationalSalesOrder : Form
    {
        //frmInternationalSalesOrderExportToSiigo prntInternationalSalesOrderExportToSiigo;
        List<string> lstFullDataConext = new List<string>();
        List<string> lstOrder = new List<string>();
        string element = string.Empty;
        string CallForm = "";

        public frmExportDataInternationalSalesOrder()
        {
            InitializeComponent();
            PopulateComercialCondition();
        }

        //public frmExportDataInternationalSalesOrder(frmInternationalSalesOrderExportToSiigo winInternationalSalesOrderExport, string element, List<string> lstOrder)
        //{
        //    InitializeComponent();
        //    lstbOrders.SelectionMode = SelectionMode.MultiSimple;
        //    prntInternationalSalesOrderExportToSiigo = winInternationalSalesOrderExport;
        //    CallForm = "InternationalSalesOrderExportToSiigo";
        //    this.lstOrder = lstOrder;
        //    this.element = element;
        //    PopulateComercialCondition();
        //    PopulateOrders(element, lstOrder);
        //}

        private void PopulateOrders(string element, List<string> lstOrder)
        {
            switch (element)
            {
                case "ComercialCondition":
                    for (int i = 0; i < lstOrder.Count; i++)
                        lstbOrders.Items.Add(lstOrder[i]);
                    break;

                default:
                    break;
            }
        }

        private void PopulateComercialCondition()
        {
            List<clsCommercialCondition> lstCommercialCondition = clsCommercialCondition.getList();
            cmbComercialCondition.Items.Clear();
            for (int i = 0; i < lstCommercialCondition.Count; i++)
                cmbComercialCondition.Items.Add(lstCommercialCondition[i]);
        }

        private void chkbOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbOrders.Checked == true)
            {
                lstbOrders.SelectionMode = SelectionMode.MultiSimple;
                for (int i = 0; i < lstbOrders.Items.Count; i++)
                    lstbOrders.SelectedIndices.Add(i);
            }
            else if (chkbOrders.Checked == false)
            {
                lstbOrders.ClearSelected();
                txtComercialConditionNotes.Text = string.Empty;
            }
        }

        public void returnCustomer()
        {
            switch (CallForm)
            {
                case "InternationalSalesOrderExportToSiigo":
                    //prntInternationalSalesOrderExportToSiigo.resultExportData = lstFullDataConext;
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void lstbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbOrders.SelectedItems.Count > 0 && cmbComercialCondition.SelectedIndex > -1)
            {
                txtComercialConditionNotes.Text += "A seleccionado la Orden " + lstbOrders.SelectedItem.ToString() + " con una condición comercial " + cmbComercialCondition.SelectedItem.ToString() + "," + "\r\n";
            }
            else
            {
                if (cmbComercialCondition.SelectedIndex > -1 || cmbComercialCondition.Text != string.Empty)
                {
                    for (int i = 0; i < lstbOrders.SelectedItems.Count; i++)
                    {

                    }
                    txtComercialConditionNotes.Text += "A seleccionado la Orden " + lstbOrders.SelectedItem.ToString() + " con una condición comercial " + cmbComercialCondition.SelectedText.ToString() + "," + "\r\n";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar primero una condición comercial para asignar a una orden", "Export Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstbOrders.ClearSelected();
                }
            }
        }
    }
}
