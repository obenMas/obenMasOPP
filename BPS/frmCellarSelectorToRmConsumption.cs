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
    public partial class frmCellarSelectorToRmConsumption : Form
    {

        frmRawMaterialConsumptionByOrderProduction prntCellarSelectorToRmConsumption;

        string CALLerForm = "";

        public frmCellarSelectorToRmConsumption()
        {
            InitializeComponent();
        }

        public frmCellarSelectorToRmConsumption(frmRawMaterialConsumptionByOrderProduction winCellarSelectorToRmConsumption)
        {
            InitializeComponent();
            prntCellarSelectorToRmConsumption = winCellarSelectorToRmConsumption;
            CALLerForm = "CellarSelectorToRmConsumption";
        }


        public void returnCellar()
        {
            switch (CALLerForm)
            {
                case "CellarSelectorToRmConsumption":
                    prntCellarSelectorToRmConsumption.selectedCellar = Convert.ToInt32(dgvCellar.SelectedRows[0].Cells[clmCodsec.Index].Value);
                    this.Close();
                    break;
            }
        }


        private void frmCellarSelectorToRmConsumption_Load_1(object sender, EventArgs e)
        {
            List<clsCellar> lstCellar = new List<clsCellar>();
            lstCellar.Clear();
            lstCellar = clsCellar.getList();
            dgvCellar.Rows.Clear();
            for (int i = 0; i < lstCellar.Count; i++)
            {
                dgvCellar.Rows.Add();
                dgvCellar.Rows[i].Cells["clmCodsec"].Value = lstCellar[i].codsec.ToString();
                dgvCellar.Rows[i].Cells["clmName"].Value = lstCellar[i].name;
                dgvCellar.Rows[i].Cells["clmDescription"].Value = lstCellar[i].description;
            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            returnCellar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}