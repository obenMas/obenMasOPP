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
    public partial class frmCellarSelector : Form
    {
        frmDeliverRawMaterial prntDeliverRawMaterial;
        frmSupplyTransfer prntDeliverSupply;
 
        string CALLerForm = "";

        public frmCellarSelector()
        {
            InitializeComponent();
        }
        public frmCellarSelector(frmDeliverRawMaterial winDeliverRawMaterial)
        {
            InitializeComponent();
            prntDeliverRawMaterial = winDeliverRawMaterial;
            CALLerForm = "DeliverRawMaterial";
           
        }
        public frmCellarSelector(frmSupplyTransfer winDeliverSupply)
        {
            InitializeComponent();
            prntDeliverSupply = winDeliverSupply;
            CALLerForm = "DeliverSupply";
        }

        public void returnCellar()
        {
            switch (CALLerForm)
            {
                case "DeliverRawMaterial":
                    prntDeliverRawMaterial.selectedCellar = Convert.ToInt32(dgvCellar.SelectedRows[0].Cells[clmCodsec.Index].Value);
                    this.Close();
                    break;

                case "DeliverSupply":
                    prntDeliverSupply.selectedCellar = Convert.ToInt32(dgvCellar.SelectedRows[0].Cells[clmCodsec.Index].Value);
                    this.Close();
                    break;
            }
        }
        

        private void frmCellarSelector_Load(object sender, EventArgs e)
        {
            switch (CALLerForm)
            {
                case "DeliverRawMaterial":
                    
                    List<clsCellarByExtruder> lstRawMaterialCellar = new List<clsCellarByExtruder>();
                    lstRawMaterialCellar.Clear();
                    lstRawMaterialCellar = clsCellarByExtruder.getListProductionCellarByExtruder(Convert.ToInt32(prntDeliverRawMaterial.MachineCodsec));
                    dgvCellar.Rows.Clear();
                    for (int i = 0; i < lstRawMaterialCellar.Count; i++)
                    {
                        dgvCellar.Rows.Add();
                        dgvCellar.Rows[i].Cells["clmCodsec"].Value = lstRawMaterialCellar[i].fkCellar.ToString();
                        dgvCellar.Rows[i].Cells["clmName"].Value = lstRawMaterialCellar[i].cellarName;
                        dgvCellar.Rows[i].Cells["clmDescription"].Value = lstRawMaterialCellar[i].extruderName;

                    }
                    break;

                case "DeliverSupply":
                    List<clsCellar> lstSupplyCellar = new List<clsCellar>();
                    lstSupplyCellar.Clear();
                    lstSupplyCellar = clsCellar.getSupplyList();
                    dgvCellar.Rows.Clear();
                    for (int i = 0; i < lstSupplyCellar.Count; i++)
                    {
                        dgvCellar.Rows.Add();
                        dgvCellar.Rows[i].Cells["clmCodsec"].Value = lstSupplyCellar[i].codsec.ToString();
                        dgvCellar.Rows[i].Cells["clmName"].Value = lstSupplyCellar[i].name;
                        dgvCellar.Rows[i].Cells["clmDescription"].Value = lstSupplyCellar[i].description;
                    }
                    break;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            returnCellar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}