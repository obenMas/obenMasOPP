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
    public struct rawMaterialConsumption
    {
        private string RawMaterialName;
        private double RawMaterialPercentage;
        private double Consumption;
        private double ConsumptionPercentage;

        public string rawMaterialName { get { return RawMaterialName; } set { RawMaterialName = value; } }

        public double rawMaterialPercentage { get { return RawMaterialPercentage; } set { RawMaterialPercentage = value; } }

        public double consumption { get { return Consumption; } set { Consumption = value; } }

        public double consumptionPercentage { get { return ConsumptionPercentage; } set { ConsumptionPercentage = value; } }


        public rawMaterialConsumption(string name, double percentage, double consumprionValue, double consumptionPercentageValue)
        {
            RawMaterialName = name;
            RawMaterialPercentage = percentage;
            Consumption = consumprionValue;
            ConsumptionPercentage = consumptionPercentageValue;
        }
    }

    public partial class frmBoppFormulationDetails : Form
    {
        private double C1Percentage = 0;
        private double C2Percentage = 0;
        private double CentralLayerPercentage = 0;
        private double TotalPercentage = 0;

        clsFormulation objFormulation = new clsFormulation();
        List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();

        public frmBoppFormulationDetails()
        {
            InitializeComponent();
        }
        public frmBoppFormulationDetails(int codsec)
        {
            InitializeComponent();

            objFormulation = clsFormulation.getFormulationBoppDetail(codsec);
        }

        private void frmBoppFormulationDetails_Load(object sender, EventArgs e)
        {
            lblBoppFormulationCode.Text = objFormulation.BoppCode;
            lblBoppFormulationName.Text = objFormulation.name;
            lblBoppFormulationDescription.Text = objFormulation.description;
            lblFormulationC1Thickness.Text = objFormulation.thickLayerC1.ToString();
            lblFormulationC2Thickness.Text = objFormulation.thickLayerC2.ToString();
            lblFormulationCentralLayerThickness.Text = objFormulation.thickCentralLayer.ToString();
            lblFormulationC1Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            lblFormulationC2Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            lblFormulationCentralLayerPercentage.Text = objFormulation.RawMaterialPercentage.ToString();
            lblBoppFormulationThick.Text = objFormulation.thick.ToString();

            lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objFormulation.codsec);

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC1 == true)
                {
                    dgvC1.Rows.Add();
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells["clmC1RawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells["clmC1Percentage"].Value = lstRawMaterialByFormulation[i].percentage;
                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC2 == true)
                {
                    dgvC2.Rows.Add();
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells["clmC2RawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells["clmC2Percentage"].Value = lstRawMaterialByFormulation[i].percentage;
                }
            }


            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].CentralLayer == true)
                {
                    dgvCentralLayer.Rows.Add();
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells["clmCentralLayerRawMaterial"].Value = lstRawMaterialByFormulation[i].name;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells["clmCentralLayerPercentage"].Value = lstRawMaterialByFormulation[i].percentage;
                }
            }
        }

        private void btnFormulationPredictor_Click(object sender, EventArgs e)
        {

            C1Percentage = (Convert.ToDouble(objFormulation.thickLayerC1) * 100) / Convert.ToDouble(objFormulation.thick);
            C2Percentage = (Convert.ToDouble(objFormulation.thickLayerC2) * 100) / Convert.ToDouble(objFormulation.thick);
            CentralLayerPercentage = (Convert.ToDouble(objFormulation.thickCentralLayer) * 100) / Convert.ToDouble(objFormulation.thick);
            TotalPercentage = C1Percentage + C2Percentage + CentralLayerPercentage;
            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC1 == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage * C1Percentage / 100);
                }
                else if (lstRawMaterialByFormulation[i].layerC2 == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage * C2Percentage / 100);
                }
                else if (lstRawMaterialByFormulation[i].CentralLayer == true)
                {
                    lstRawMaterialByFormulation[i].globalPercentage = (lstRawMaterialByFormulation[i].percentage *  CentralLayerPercentage/ 100);
                }
            }

            List<rawMaterialConsumption> lstRawMaterialConsumption = new List<rawMaterialConsumption>();

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                bool isInArray = false;
                int inArrayIndex = -1;
                for (int j = 0; j < lstRawMaterialConsumption.Count; j++)
                {
                    if (lstRawMaterialByFormulation[i].name == lstRawMaterialConsumption[j].rawMaterialName)
                    {
                        isInArray = true;
                        inArrayIndex = j;
                    }
                }
                if (isInArray == true)
                {
                    rawMaterialConsumption item = lstRawMaterialConsumption[inArrayIndex];
                    item.consumption += (lstRawMaterialByFormulation[i].globalPercentage/100) * Convert.ToDouble(txtFormulationPredictorQuantity.Text);
                    item.consumptionPercentage += (lstRawMaterialByFormulation[i].globalPercentage / 100) * (((100 + Convert.ToDouble(txtFormulationPredictorPercentage.Text)) * Convert.ToDouble(txtFormulationPredictorQuantity.Text))/100);
                    item.rawMaterialPercentage += lstRawMaterialByFormulation[i].globalPercentage;
                    lstRawMaterialConsumption[inArrayIndex] = item;
                }
                else
                {
                    lstRawMaterialConsumption.Add(new rawMaterialConsumption());

                    rawMaterialConsumption item = lstRawMaterialConsumption[lstRawMaterialConsumption.Count - 1];
                    item.rawMaterialName = lstRawMaterialByFormulation[i].name;
                    item.consumption = (lstRawMaterialByFormulation[i].globalPercentage/100) * Convert.ToDouble(txtFormulationPredictorQuantity.Text);
                    item.consumptionPercentage += (lstRawMaterialByFormulation[i].globalPercentage / 100) * (((100 + Convert.ToDouble(txtFormulationPredictorPercentage.Text)) * Convert.ToDouble(txtFormulationPredictorQuantity.Text)) / 100);
                    item.rawMaterialPercentage = lstRawMaterialByFormulation[i].globalPercentage;
                    lstRawMaterialConsumption[lstRawMaterialConsumption.Count - 1] = item;
                }
            }
            for (int i = 0; i < lstRawMaterialConsumption.Count; i++)
            {
                dgvFormulationPredictor.Rows.Add(); 
                dgvFormulationPredictor.Rows[i].Cells["clmRawMaterial"].Value = lstRawMaterialConsumption[i].rawMaterialName;
                dgvFormulationPredictor.Rows[i].Cells["clmFormulationPercentage"].Value = lstRawMaterialConsumption[i].rawMaterialPercentage;
                dgvFormulationPredictor.Rows[i].Cells["clmFormulationTheoryPrediction"].Value = lstRawMaterialConsumption[i].consumption;
                dgvFormulationPredictor.Rows[i].Cells["clmFormulationPrediction"].Value = lstRawMaterialConsumption[i].consumptionPercentage;  
            }
        }

        private void btnBoppFormulationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
