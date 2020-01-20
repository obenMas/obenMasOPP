using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;


namespace BPS.Lite
{
    public partial class frmInProcessCoils : Form
    {
        clsCoil coil = new clsCoil();
        List<string> list = new List<string>();

        public frmInProcessCoils()
        {
            InitializeComponent();
            populateDataGrid();

        }

        public void populateDataGrid()
        {
            dgvInProcessCoils.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spInProcessCoils");

            if (DS.Tables[0].Rows.Count > 0)
            {
                list.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvInProcessCoils.Rows.Add();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCoilCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCode"].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessProduct"].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessLength"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Metraje"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWitdth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessObservations"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessDestination"].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRework"].Value = DS.Tables[0].Rows[i]["Retrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessReworkDetail"].Value = DS.Tables[0].Rows[i]["DetalleRetrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessUsefulWidth"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFkuser"].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRevisiondate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaRevisión"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    if (!list.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        list.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                }
                populateCombo();
            }
        }

        private void dgvInProcessCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex>-1)
            {
                txtInProcessCode.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessCode"].Value.ToString();
                txtInProcessProduct.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessProduct"].Value.ToString();
                txtInProcessCustomer.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessCustomer"].Value.ToString();
                txtInProcessLength.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessLength"].Value.ToString();
                txtInProcessWitdth.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessWitdth"].Value.ToString();
                txtInProcessWeight.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessWeight"].Value.ToString();
                txtInProcessObservations.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessObservations"].Value.ToString();
                txtInProcessReworkDetail.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessReworkDetail"].Value.ToString();
                txtInProcessUsefulWidth.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessUsefulWidth"].Value.ToString();
                cmbInProcessDestination.SelectedIndex = -1;
                cmbInProcessRework.SelectedIndex = -1;

                for (int i = 0; i < cmbInProcessDestination.Items.Count; i++)
                {
                    if (cmbInProcessDestination.Items[i].ToString() == dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessDestination"].Value.ToString())
                    {
                        cmbInProcessDestination.SelectedIndex = i;
                    }


                }
                for (int i = 0; i < cmbInProcessRework.Items.Count; i++)
                {
                    if (cmbInProcessRework.Items[i].ToString() == dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessRework"].Value.ToString())
                    {
                        cmbInProcessRework.SelectedIndex = i;
                    }
                }




                coil = new clsCoil(Convert.ToInt32(dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessCoilCodsec"].Value));
            }
        }

        public void clearInProcessCoilsDetail()
        {
            txtInProcessCode.Text = string.Empty;
            txtInProcessProduct.Text = string.Empty;
            txtInProcessCustomer.Text = string.Empty;
            txtInProcessLength.Text = string.Empty;
            txtInProcessWitdth.Text = string.Empty;
            txtInProcessWeight.Text = string.Empty;
            txtInProcessObservations.Text = string.Empty;
            txtInProcessReworkDetail.Text = string.Empty;
            txtInProcessUsefulWidth.Text = string.Empty;
            cmbInProcessDestination.SelectedIndex = -1;
            cmbInProcessRework.SelectedIndex = -1;

        }

        public bool validateInProcessCoilsInfo()
        {
            bool flag = false;
            if (cmbInProcessDestination.SelectedIndex == -1)
            {
                flag = true;
            }
            if (cmbInProcessRework.SelectedIndex == -1)
            {
                flag = true;
            }
            if (txtInProcessUsefulWidth.Text == string.Empty)
            {
                flag = true;
            }
            if (cmbInProcessDestination.SelectedIndex == 1 && txtInProcessUsefulWidth.Text == "0")
            {
                flag = true;
            }

            return flag;
        }

        private void cmbInProcessDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInProcessDestination.SelectedIndex)
            {
                case 0:
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = txtInProcessWitdth.Text;
                    break;

                case 1:
                    txtInProcessUsefulWidth.Focus();
                    break;

                case 2:
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = "0";
                    break;

            }
        }

        private void txtInProcessCoilsCode_Leave(object sender, EventArgs e)
        {
            if (txtInProcessCoilsCode.Text != string.Empty)
                cmbInProcessCoilsFilm.SelectedIndex = -1;


        }

        private void cmbInProcessCoilsFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInProcessCoilsFilm.SelectedIndex > -1)
                txtInProcessCoilsCode.Text = string.Empty;

        }

        private void btnInProcessFilter_Click(object sender, EventArgs e)
        {
            if (txtInProcessCoilsCode.Text != string.Empty)
            {
                populateCode();
            }
            if (cmbInProcessCoilsFilm.SelectedIndex > -1)
            {
                populateFilm();
            }
        }

        public void populateCode()
        {
            dgvInProcessCoils.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spInProcessCoilsByCode '" + txtInProcessCoilsCode.Text + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                list.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvInProcessCoils.Rows.Add();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCoilCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCode"].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessProduct"].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessLength"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Metraje"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWitdth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessObservations"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessDestination"].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRework"].Value = DS.Tables[0].Rows[i]["Retrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessReworkDetail"].Value = DS.Tables[0].Rows[i]["DetalleRetrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessUsefulWidth"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFkuser"].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRevisiondate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaRevisión"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    if (!list.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        list.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                }
                populateCombo();

            }
        }

        public void populateFilm()
        {
            dgvInProcessCoils.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spInProcessCoilsByFilm '" + cmbInProcessCoilsFilm.SelectedItem.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                list.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvInProcessCoils.Rows.Add();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCoilCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCode"].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessProduct"].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessLength"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Metraje"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWitdth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessObservations"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessDestination"].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRework"].Value = DS.Tables[0].Rows[i]["Retrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessReworkDetail"].Value = DS.Tables[0].Rows[i]["DetalleRetrabajo"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessUsefulWidth"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFkuser"].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessRevisiondate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaRevisión"]);
                    dgvInProcessCoils.Rows[i].Cells["clmInProcessFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    if (!list.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        list.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                }
                populateCombo();
            }
        }

        private void btnInProcessNoFilter_Click(object sender, EventArgs e)
        {
            txtInProcessCoilsCode.Text = string.Empty;
            cmbInProcessCoilsFilm.SelectedIndex = -1;
            populateDataGrid();
        }

        public void populateCombo()
        {
            cmbInProcessCoilsFilm.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                cmbInProcessCoilsFilm.Items.Add(list[i].ToString());

            }
        }

        private void btnInProcessCoilsExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Bobinas en Proceso";

                for (int i = 2; i < dgvInProcessCoils.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvInProcessCoils.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvInProcessCoils.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvInProcessCoils.Columns.Count; j++)
                    {
                        if (dgvInProcessCoils.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvInProcessCoils.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Bobinas en proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bobinas en proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void dgvInProcessCoils_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCoilEditor winCoil = new frmCoilEditor(Convert.ToInt32(dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessCoilCodsec"].Value),this);
            winCoil.StartPosition = FormStartPosition.CenterScreen;
            winCoil.Show();
        }
    }
}
