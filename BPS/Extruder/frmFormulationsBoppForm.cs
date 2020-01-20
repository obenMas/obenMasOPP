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
    public partial class frmFormulationsBoppForm : Form
    {
        int codsec = 0;
        clsFormulation objFormulation = new clsFormulation();
        clsRawMaterialByFormulation objRawmaterialByFormulation = new clsRawMaterialByFormulation();
        public int selectedRawMaterial = 0, defaultfkBopp = 0;

        public frmFormulationsBoppForm()
        {
            InitializeComponent();
            txtThickness.Enabled = true;
        }

        public frmFormulationsBoppForm(int codsec)
        {
            InitializeComponent();
            txtDescription.Focus();
            this.codsec = codsec;
            PopulateFormulation(codsec);
        }

        private void frmFormulationsBoppForm_Load(object sender, EventArgs e)
        {
            List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
            cmbBoppFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbBoppFilm.Items.Add(lstBopp[i]);
        }

        private void cmbBoppFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
                cmbBoppFilm.Items.Clear();
                for (int i = 0; i < lstBopp.Count; i++)
                    cmbBoppFilm.Items.Add(lstBopp[i]);
            }
        }

        #region C1

        private void dgvFormulationBoppC1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.loadF(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvC1.CurrentRow.Cells[clmC1codsec.Index].Value = 0;
                    dgvC1.CurrentRow.Cells[clmC1fkRawMaterial.Index].Value = objRawMaterial.codsec;
                    dgvC1.CurrentRow.Cells[clmC1RawMaterial.Index].Value = objRawMaterial.name;
                    dgvC1.CurrentRow.Cells[clmC1type.Index].Value = objRawMaterial.code;
                }
            }
        }

        private void dgvC1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvC1.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;
            switch (e.ColumnIndex)
            {
                case 5:

                    for (int i = 0; i < dgvC1.Rows.Count; i++)
                    {
                        if (dgvC1.Rows[i].Cells[clmC1weigth.Index].Value != null && dgvC1.Rows[i].Cells[clmC1weigth.Index].Value.ToString() != "")
                            total += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value);
                    }

                    for (int i = 0; i < dgvC1.Rows.Count; i++)
                    {
                        if (dgvC1.Rows[i].Cells[clmC1weigth.Index].Value != null && dgvC1.Rows[i].Cells[clmC1weigth.Index].Value.ToString() != "")
                        {
                            if (total != 0)
                                dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value)) * (100)) / total, 2).ToString();
                            else
                                dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value = 100;
                        }
                    }

                    for (int i = 0; i < dgvC1.Rows.Count; i++)
                    {
                        if (dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value != null && dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
                    }
                    txtC1Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
                    break;
            }
        }

        private void dgvC1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;


            for (int i = 0; i < dgvC1.Rows.Count; i++)
            {
                if (dgvC1.Rows[i].Cells[clmC1weigth.Index].Value != null && dgvC1.Rows[i].Cells[clmC1weigth.Index].Value.ToString() != "")
                    total += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value);
            }

            for (int i = 0; i < dgvC1.Rows.Count; i++)
            {
                if (dgvC1.Rows[i].Cells[clmC1weigth.Index].Value != null && dgvC1.Rows[i].Cells[clmC1weigth.Index].Value.ToString() != "")
                {
                    if (total != 0)
                        dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value)) * (100)) / total, 2).ToString();
                    else
                        dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value = 100;
                }
            }

            for (int i = 0; i < dgvC1.Rows.Count; i++)
            {
                if (dgvC1.Rows[i].Cells[clmC1weigth.Index].Value != null && dgvC1.Rows[i].Cells[clmC1weigth.Index].Value.ToString() != "")
                    totalPercentage += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
            }
            txtC1Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
        }

        private void dgvC1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC1fkRawMaterial.Index].Value = "0";
        }

        #endregion

        #region C3

        private void dgvFormulationBoppC3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.loadF(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvC3.CurrentRow.Cells[clmC3Codsec.Index].Value = 0;
                    dgvC3.CurrentRow.Cells[clmC3fkRawMaterial.Index].Value = objRawMaterial.codsec;
                    dgvC3.CurrentRow.Cells[clmC3Code.Index].Value = objRawMaterial.name;
                    dgvC3.CurrentRow.Cells[clmC3Type.Index].Value = objRawMaterial.code;
                }
            }
        }

        private void dgvC3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvC3.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;
            switch (e.ColumnIndex)
            {
                case 5:

                    for (int i = 0; i < dgvC3.Rows.Count; i++)
                    {
                        if (dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value.ToString() != "")
                            total += Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value);
                    }

                    for (int i = 0; i < dgvC3.Rows.Count; i++)
                    {
                        if (dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value.ToString() != "")
                        {
                            if (total != 0)
                                dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value)) * (100)) / total, 2).ToString();
                            else
                                dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value = 100;
                        }
                    }

                    for (int i = 0; i < dgvC3.Rows.Count; i++)
                    {
                        if (dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value);
                    }
                    txtC3Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
                    break;
            }
        }

        private void dgvC3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;


            for (int i = 0; i < dgvC3.Rows.Count; i++)
            {
                if (dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value.ToString() != "")
                    total += Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value);
            }

            for (int i = 0; i < dgvC3.Rows.Count; i++)
            {
                if (dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value.ToString() != "")
                {
                    if (total != 0)
                        dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value)) * (100)) / total, 2).ToString();
                    else
                        dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value = 100;
                }
            }

            for (int i = 0; i < dgvC3.Rows.Count; i++)
            {
                if (dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value != null && dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value.ToString() != "")
                    totalPercentage += Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value);
            }
            txtC3Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
        }

        private void dgvC3_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC3fkRawMaterial.Index].Value = "0";
        }

        #endregion

        #region C4

        private void dgvFormulationBoppC4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.loadF(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvC4.CurrentRow.Cells[clmC4Codsec.Index].Value = 0;
                    dgvC4.CurrentRow.Cells[clmC4fkRawMaterial.Index].Value = objRawMaterial.codsec;
                    dgvC4.CurrentRow.Cells[clmC4Code.Index].Value = objRawMaterial.name;
                    dgvC4.CurrentRow.Cells[clmC4Type.Index].Value = objRawMaterial.code;
                }
            }
        }

        private void dgvC4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvC4.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;
            switch (e.ColumnIndex)
            {
                case 5:

                    for (int i = 0; i < dgvC4.Rows.Count; i++)
                    {
                        if (dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value.ToString() != "")
                            total += Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value);
                    }

                    for (int i = 0; i < dgvC4.Rows.Count; i++)
                    {
                        if (dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value.ToString() != "")
                        {
                            if (total != 0)
                                dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value)) * (100)) / total, 2).ToString();
                            else
                                dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value = 100;
                        }
                    }

                    for (int i = 0; i < dgvC4.Rows.Count; i++)
                    {
                        if (dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value);
                    }
                    txtC4Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
                    break;
            }
        }

        private void dgvC4_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;


            for (int i = 0; i < dgvC4.Rows.Count; i++)
            {
                if (dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value.ToString() != "")
                    total += Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value);
            }

            for (int i = 0; i < dgvC4.Rows.Count; i++)
            {
                if (dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value.ToString() != "")
                {
                    if (total != 0)
                        dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value)) * (100)) / total, 2).ToString();
                    else
                        dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value = 100;
                }
            }

            for (int i = 0; i < dgvC4.Rows.Count; i++)
            {
                if (dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value != null && dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value.ToString() != "")
                    totalPercentage += Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value);
            }
            txtC4Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
        }

        private void dgvC4_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC4fkRawMaterial.Index].Value = "0";
        }

        #endregion

        #region Central Layer

        private void dgvFormulationBoppCentalLayer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.loadF(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerCodsec.Index].Value = 0;
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerfkRawMaterial.Index].Value = objRawMaterial.codsec;
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerCode.Index].Value = objRawMaterial.name;
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerType.Index].Value = objRawMaterial.code;
                }
            }
        }


        private void dgvCentalLayer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCentralLayer.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvCentalLayer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;
            switch (e.ColumnIndex)
            {
                case 5:

                    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                    {
                        if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value.ToString() != "")
                            total += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
                    }

                    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                    {
                        if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value.ToString() != "")
                        {
                            if (total != 0)
                                dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = Math.Round(((Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value)) * (100)) / total, 2).ToString();
                            else
                                dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = 100;
                        }
                    }

                    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                    {
                        if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
                    }
                    txtCentralLayerPercentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
                    break;
            }
        }

        private void dgvCentralLayer_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmCentralLayerfkRawMaterial.Index].Value = "0";
        }

        private void dgvCentralLayer_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;


            for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
            {
                if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value.ToString() != "")
                    total += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
            }

            for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
            {
                if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value.ToString() != "")
                {
                    if (total != 0)
                        dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = Math.Round(((Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value)) * (100)) / total, 2).ToString();
                    else
                        dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = 100;
                }
            }

            for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
            {
                if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value.ToString() != "")
                    totalPercentage += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
            }
            txtCentralLayerPercentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
        }

        #endregion

        #region C2

        private void dgvFormulationBoppC2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.loadF(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvC2.CurrentRow.Cells[clmC2Codsec.Index].Value = 0;
                    dgvC2.CurrentRow.Cells[clmC2fkRawMaterial.Index].Value = objRawMaterial.codsec;
                    dgvC2.CurrentRow.Cells[clmC2Type.Index].Value = objRawMaterial.code;
                    dgvC2.CurrentRow.Cells[clmC2Code.Index].Value = objRawMaterial.name;
                }
            }
        }

        private void dgvC2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvC2.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;
            switch (e.ColumnIndex)
            {
                case 5:

                    for (int i = 0; i < dgvC2.Rows.Count; i++)
                    {
                        if (dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value.ToString() != "")
                            total += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
                    }

                    for (int i = 0; i < dgvC2.Rows.Count; i++)
                    {
                        if (dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value.ToString() != "")
                        {
                            if (total != 0)
                                dgvC2.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value)) * (100)) / total, 2).ToString();
                            else
                                dgvC2.Rows[i].Cells[clmCentralLayerPercentage.Index].Value = 100;
                        }
                    }

                    for (int i = 0; i < dgvC2.Rows.Count; i++)
                    {
                        if (dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
                    }
                    txtC2Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
                    break;
            }
        }

        private void dgvC2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC2fkRawMaterial.Index].Value = "0";
        }

        private void dgvC2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double totalPercentage = 0;
            double total = 0;


            for (int i = 0; i < dgvC2.Rows.Count; i++)
            {
                if (dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value.ToString() != "")
                    total += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
            }

            for (int i = 0; i < dgvC2.Rows.Count; i++)
            {
                if (dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value.ToString() != "")
                {
                    if (total != 0)
                        dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value = Math.Round(((Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value)) * (100)) / total, 2).ToString();
                    else
                        dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value = 100;
                }
            }

            for (int i = 0; i < dgvC2.Rows.Count; i++)
            {
                if (dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value.ToString() != "")
                    totalPercentage += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
            }
            txtC2Percentage.Text = Math.Round(totalPercentage, 1, MidpointRounding.ToEven).ToString();
        }

        #endregion

        private void PopulateFormulation(int codsec)
        {
            txtThickness.Enabled = false;
            dgvC1.Rows.Clear();
            dgvC2.Rows.Clear();
            dgvC3.Rows.Clear();
            dgvC4.Rows.Clear();
            dgvCentralLayer.Rows.Clear();

            clsFormulation objFormulation = new clsFormulation();
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();
            objFormulation = clsFormulation.getFormulationBoppDetail(codsec);
            PopulateFilm(objFormulation.fkBopp);
            txtName.Text = objFormulation.name;
            txtDescription.Text = objFormulation.description;
            txtC1Thickness.Text = objFormulation.thickLayerC1.ToString();
            txtC2Thickness.Text = objFormulation.thickLayerC2.ToString();
            txtC3Thickness.Text = objFormulation.thickLayerC3.ToString();
            txtC4Thickness.Text = objFormulation.thickLayerC4.ToString();
            txtCentralLayerThickness.Text = objFormulation.thickCentralLayer.ToString();
            txtC1Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            txtC2Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            txtC3Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            txtC4Percentage.Text = objFormulation.RawMaterialPercentage.ToString();
            txtCentralLayerPercentage.Text = objFormulation.RawMaterialPercentage.ToString();
            txtThickness.Text = objFormulation.thick.ToString();

            dgvC1.AllowUserToAddRows = false;
            dgvCentralLayer.AllowUserToAddRows = false;
            dgvC2.AllowUserToAddRows = false;
            dgvC3.AllowUserToAddRows = false;
            dgvC4.AllowUserToAddRows = false;

            lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulationEdit(objFormulation.codsec);

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC1 == true)
                {
                    dgvC1.Rows.Add();
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1codsec.Index].Value = lstRawMaterialByFormulation[i].codsec;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1fkRawMaterial.Index].Value = lstRawMaterialByFormulation[i].fkRawMaterial;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1RawMaterial.Index].Value = lstRawMaterialByFormulation[i].name;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1type.Index].Value = lstRawMaterialByFormulation[i].material;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
                    dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC2 == true)
                {
                    dgvC2.Rows.Add();
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Codsec.Index].Value = lstRawMaterialByFormulation[i].codsec;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2fkRawMaterial.Index].Value = lstRawMaterialByFormulation[i].fkRawMaterial;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Type.Index].Value = lstRawMaterialByFormulation[i].material;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Code.Index].Value = lstRawMaterialByFormulation[i].name;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
                    dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC3 == true)
                {
                    dgvC2.Rows.Add();
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3Codsec.Index].Value = lstRawMaterialByFormulation[i].codsec;
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3fkRawMaterial.Index].Value = lstRawMaterialByFormulation[i].fkRawMaterial;
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3Type.Index].Value = lstRawMaterialByFormulation[i].material;
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3Code.Index].Value = lstRawMaterialByFormulation[i].name;
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
                    dgvC2.Rows[dgvC3.Rows.Count - 1].Cells[clmC3Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].layerC4 == true)
                {
                    dgvC2.Rows.Add();
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4Codsec.Index].Value = lstRawMaterialByFormulation[i].codsec;
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4fkRawMaterial.Index].Value = lstRawMaterialByFormulation[i].fkRawMaterial;
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4Type.Index].Value = lstRawMaterialByFormulation[i].material;
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4Code.Index].Value = lstRawMaterialByFormulation[i].name;
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
                    dgvC2.Rows[dgvC4.Rows.Count - 1].Cells[clmC4Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
                }
            }

            for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
            {
                if (lstRawMaterialByFormulation[i].CentralLayer == true)
                {
                    dgvCentralLayer.Rows.Add();
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerCodsec.Index].Value = lstRawMaterialByFormulation[i].codsec;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerfkRawMaterial.Index].Value = lstRawMaterialByFormulation[i].fkRawMaterial;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerCode.Index].Value = lstRawMaterialByFormulation[i].name;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerType.Index].Value = lstRawMaterialByFormulation[i].material;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerLotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
                    dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerWeigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
                }
            }

            dgvC1.AllowUserToAddRows = true;
            dgvCentralLayer.AllowUserToAddRows = true;
            dgvC2.AllowUserToAddRows = true;
            dgvC3.AllowUserToAddRows = true;
            dgvC4.AllowUserToAddRows = true;
        }

        private void PopulateFilm(int BoppCodsec)
        {
            List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
            cmbBoppFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbBoppFilm.Items.Add(lstBopp[i]);

            for (int i = 0; i < cmbBoppFilm.Items.Count; i++)
            {
                if (((clsBopp)cmbBoppFilm.Items[i]).codsec == BoppCodsec)
                {
                    cmbBoppFilm.SelectedIndex = i;
                    defaultfkBopp = BoppCodsec;
                    break;
                }
            }
        }

        private void btnFormulationBoppSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (codsec == 0)
                {
                    objFormulation.name = txtName.Text;
                    objFormulation.description = txtDescription.Text;
                    objFormulation.thick = Convert.ToDouble(txtThickness.Text);
                    objFormulation.thickLayerC1 = Convert.ToDouble(txtC1Thickness.Text);
                    objFormulation.thickLayerC2 = Convert.ToDouble(txtC2Thickness.Text);
                    objFormulation.thickLayerC3 = Convert.ToDouble(txtC3Thickness.Text);
                    objFormulation.thickLayerC4 = Convert.ToDouble(txtC4Thickness.Text);
                    objFormulation.thickCentralLayer = Convert.ToDouble(txtCentralLayerThickness.Text);
                    objFormulation.fkBopp = ((clsBopp)cmbBoppFilm.SelectedItem).codsec;

                    for (int i = 0; i < dgvC1.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1fkRawMaterial.Index].Value) != 0)
                        {
                            objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1fkRawMaterial.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC1.Rows[i].Cells[clmC1LotNumber.Index].Value.ToString();
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC1 = true;
                        }
                    }

                    for (int i = 0; i < dgvC2.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2fkRawMaterial.Index].Value) != 0)
                        {
                            objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2fkRawMaterial.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC2.Rows[i].Cells[clmC2LotNumber.Index].Value.ToString();
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC2 = true;
                        }
                    }

                    for (int i = 0; i < dgvC3.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvC3.Rows[i].Cells[clmC3fkRawMaterial.Index].Value) != 0)
                        {
                            objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC3.Rows[i].Cells[clmC3fkRawMaterial.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC3.Rows[i].Cells[clmC3LotNumber.Index].Value.ToString();
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC3 = true;
                        }
                    }

                    for (int i = 0; i < dgvC4.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvC4.Rows[i].Cells[clmC4fkRawMaterial.Index].Value) != 0)
                        {
                            objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC4.Rows[i].Cells[clmC4fkRawMaterial.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC4.Rows[i].Cells[clmC4LotNumber.Index].Value.ToString();
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC4 = true;
                        }
                    }

                    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerfkRawMaterial.Index].Value) != 0)
                        {
                            objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerfkRawMaterial.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvCentralLayer.Rows[i].Cells[clmCentralLayerLotNumber.Index].Value.ToString();
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].CentralLayer = true;
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
                            objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
                        }
                    }

                    if (objFormulation.save())
                    {
                        MessageBox.Show("La formulación se ha guardado con éxito", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    clsFormulation objFormulation = new clsFormulation(codsec);
                    objFormulation.name = txtName.Text;
                    objFormulation.description = txtDescription.Text;
                    objFormulation.thick = Convert.ToDouble(txtThickness.Text);
                    objFormulation.thickLayerC1 = Convert.ToDouble(txtC1Thickness.Text);
                    objFormulation.thickLayerC2 = Convert.ToDouble(txtC2Thickness.Text);
                    objFormulation.thickLayerC3 = Convert.ToDouble(txtC3Thickness.Text);
                    objFormulation.thickLayerC4 = Convert.ToDouble(txtC4Thickness.Text);
                    objFormulation.thickCentralLayer = Convert.ToDouble(txtCentralLayerThickness.Text);
                    objFormulation.fkBopp = ((cmbBoppFilm.SelectedItem) == null) ? defaultfkBopp : ((clsBopp)cmbBoppFilm.SelectedItem).codsec;

                    if (clsFormulation.deleteRawMaterial(codsec))
                    {
                        //
                        objFormulation.lstRawMaterialByFormulation.Clear();

                        for (int i = 0; i < dgvC1.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1fkRawMaterial.Index].Value) != 0)
                            {
                                objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].codsec = Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1codsec.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1fkRawMaterial.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC1.Rows[i].Cells[clmC1LotNumber.Index].Value.ToString().ToUpper();
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1weigth.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC1 = true;
                            }
                        }

                        for (int i = 0; i < dgvC2.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2fkRawMaterial.Index].Value) != 0)
                            {
                                objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].codsec = Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2Codsec.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2fkRawMaterial.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC2.Rows[i].Cells[clmC2LotNumber.Index].Value.ToString().ToUpper();
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC2 = true;
                            }
                        }

                        for (int i = 0; i < dgvC3.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvC3.Rows[i].Cells[clmC3fkRawMaterial.Index].Value) != 0)
                            {
                                objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].codsec = Convert.ToInt32(dgvC3.Rows[i].Cells[clmC3Codsec.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC3.Rows[i].Cells[clmC3fkRawMaterial.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC3.Rows[i].Cells[clmC3LotNumber.Index].Value.ToString().ToUpper();
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Percentage.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC3.Rows[i].Cells[clmC3Weigth.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC3 = true;
                            }
                        }

                        for (int i = 0; i < dgvC4.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvC4.Rows[i].Cells[clmC4fkRawMaterial.Index].Value) != 0)
                            {
                                objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].codsec = Convert.ToInt32(dgvC4.Rows[i].Cells[clmC4Codsec.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC4.Rows[i].Cells[clmC4fkRawMaterial.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvC4.Rows[i].Cells[clmC4LotNumber.Index].Value.ToString().ToUpper();
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Percentage.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvC4.Rows[i].Cells[clmC4Weigth.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC4 = true;
                            }
                        }

                        for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerfkRawMaterial.Index].Value) != 0)
                            {
                                objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].codsec = Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerCodsec.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerfkRawMaterial.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].lotnumber = dgvCentralLayer.Rows[i].Cells[clmCentralLayerLotNumber.Index].Value.ToString().ToUpper();
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].CentralLayer = true;
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
                                objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].weigth = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
                            }
                        }

                        if (objFormulation.save())
                        {
                            MessageBox.Show("La formulación se ha guardado con éxito", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    }
                    else
                    {
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        cmbBoppFilm.Focus();
                    }
                }
            }
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblFormulationBoppName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThickness, ref lblFormulationBoppThickness, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC1Thickness, ref lblC1Percentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCentralLayerThickness, ref lblCentralLayerPercentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC2Thickness, ref lblC2Percentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC3Thickness, ref lblC3Percentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC4Thickness, ref lblC4Percentage, "notEmpty")) isValid = false;
            if (codsec == 0)
            {
                if (!clsValidation.validateField(ref dgvC1, ref grpbC1, "isValid")) isValid = false;
                if (!clsValidation.validateField(ref dgvCentralLayer, ref grpbCentralLayer, "isValid")) isValid = false;
                if (!clsValidation.validateField(ref dgvC2, ref grpbC2, "isValid")) isValid = false;
                if (!clsValidation.validateField(ref dgvC3, ref grpbC3, "isValid")) isValid = false;
                if (!clsValidation.validateField(ref dgvC4, ref grpbC4, "isValid")) isValid = false;
                if (!clsValidation.validateField(ref cmbBoppFilm, ref lblFormulationBoppFilm, "selected")) isValid = false;
            }

            if (txtC1Percentage.Text != "100")
            {
                txtC1Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC1Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC1Percentage.BackColor = SystemColors.Window;
                lblC1Percentage.ForeColor = SystemColors.WindowText;
            }

            if (txtCentralLayerPercentage.Text != "100")
            {
                txtCentralLayerPercentage.BackColor = Color.FromArgb(253, 230, 231);
                lblCentralLayerPercentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtCentralLayerPercentage.BackColor = SystemColors.Window;
                lblCentralLayerPercentage.ForeColor = SystemColors.WindowText;
            }

            if (txtC2Percentage.Text != "100")
            {
                txtC2Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC2Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC2Percentage.BackColor = SystemColors.Window;
                lblC2Percentage.ForeColor = SystemColors.WindowText;
            }

            if (txtC3Percentage.Text != "100")
            {
                txtC3Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC3Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC3Percentage.BackColor = SystemColors.Window;
                lblC3Percentage.ForeColor = SystemColors.WindowText;
            }

            if (txtC4Percentage.Text != "100")
            {
                txtC4Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC4Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC4Percentage.BackColor = SystemColors.Window;
                lblC4Percentage.ForeColor = SystemColors.WindowText;
            }

            if (Math.Round((Convert.ToDouble(txtC1Thickness.Text) + Convert.ToDouble(txtCentralLayerThickness.Text) + Convert.ToDouble(txtC2Thickness.Text) + Convert.ToDouble(txtC3Thickness.Text) + Convert.ToDouble(txtC4Thickness.Text)), 2) != Convert.ToDouble(txtThickness.Text))
            {
                txtThickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppThickness.ForeColor = Color.Red;

                txtC1Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppC1Thickness.ForeColor = Color.Red;

                txtCentralLayerThickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppCentralLayerThickness.ForeColor = Color.Red;

                txtC2Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppC2Thickness.ForeColor = Color.Red;

                txtC3Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppC3Thickness.ForeColor = Color.Red;

                txtC4Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationBoppC4Thickness.ForeColor = Color.Red;

                isValid = false;
            }
            else
            {
                txtThickness.BackColor = SystemColors.Window;
                lblFormulationBoppThickness.ForeColor = SystemColors.WindowText;

                txtC1Thickness.BackColor = SystemColors.Window;
                lblFormulationBoppC1Thickness.ForeColor = SystemColors.WindowText;

                txtCentralLayerThickness.BackColor = SystemColors.Window;
                lblFormulationBoppCentralLayerThickness.ForeColor = SystemColors.WindowText;

                txtC2Thickness.BackColor = SystemColors.Window;
                lblFormulationBoppC2Thickness.ForeColor = SystemColors.WindowText;

                txtC3Thickness.BackColor = SystemColors.Window;
                lblFormulationBoppC3Thickness.ForeColor = SystemColors.WindowText;

                txtC4Thickness.BackColor = SystemColors.Window;
                lblFormulationBoppC4Thickness.ForeColor = SystemColors.WindowText;
            }

            return isValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpbEmpty_Enter(object sender, EventArgs e)
        {

        }
    }
}