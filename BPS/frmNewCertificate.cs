using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Certificate.Report;
using System.Threading;

namespace BPS
{
    public partial class frmNewCertificate : Form
    {
        List<clsCertificate> cerList = new List<clsCertificate>();
        clsCertificate ObjCertificate = new clsCertificate();
        string myfilmname = string.Empty;
        string mypanelname = string.Empty;
        string custommer = string.Empty;
        DataSet DS=new DataSet();
        DataSet DS2 = new DataSet();
        int plant = 0;

        public frmNewCertificate()
        {
            InitializeComponent();
        }

        public void getDataSet(string lotNumber)
        {
            DS = clsConnection.getDataSetResult("CALL spNewQualityCertificate(" + lotNumber.ToString() + ")");
        }

        public void getDataSet2(int preshiping)
        {
            DS2 = clsConnection.getDataSetResult("CALL spNewQualityCertificateHeader2(" + preshiping + ")");
        }


        private void txtPreShipping_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                getDataSet2(Convert.ToInt32(txtPreShipping.Text));
                PopulateHeadCertificate(txtPreShipping.Text);
            }
        }

        private void PopulateHeadCertificate(string preshipping)
        {
            cerList = clsCertificate.getListByPreShippingNumber(preshipping);

            if (cerList.Count > 0)
            {
                //var customer = cerList.Select(cus => cus.Company).Distinct().OrderBy(x => x).ToList();
                //var orderNumber = cerList.Select(ord => ord.OrderNumber).Distinct().OrderBy(x => x).ToList();
                var lotNumber = cerList.Select(lt => lt.LotNumber).Distinct().ToList().OrderBy(x => x).ToList();

                FillCMB(lotNumber);
            }
            else
            {
                MessageBox.Show("El pre-despacho ingresado no corresponde a ninguno pre-despacho registrado por favor vuelva a ingresar los datos ", "Certificado de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void FillCMB(List<string> lotNumber)
        {
            foreach (var item in lotNumber)
            {
                cmbLotNumber.Items.Add(item);
            }
        }

        private void cmbLotNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLotNumber.SelectedIndex != -1)
            {
                populateTextBox();
            }
        }

        private void populateTextBox()
        {
            //getDataSet(cmbLotNumber.SelectedItem.ToString());
            getDataSet(txtLot.Text.ToString());
            dgvCertificate.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCertificate.Rows.Add();
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmLot.Index].Value = DS.Tables[0].Rows[i]["Lote"].ToString();
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmName.Index].Value = DS.Tables[0].Rows[i]["Nombre"].ToString();
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmNorm.Index].Value = DS.Tables[0].Rows[i]["Norma"].ToString();
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmUnit.Index].Value = DS.Tables[0].Rows[i]["Unidad"].ToString();
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmAverage.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Promedio"]);
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmMax.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Mínimo"]);
                    dgvCertificate.Rows[dgvCertificate.Rows.Count - 1].Cells[clmMin.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Máximo"]);                    
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();
        }

        private void txtLot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                populateTextBox();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir el certificado de calidad?", "Certificado de calidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                Thread thrdPrint;
             
                thrdPrint = new Thread(delegate() { clsPrintLabels.printCertificate(txtLot.Text.ToString()); });
                thrdPrint.Start();
                thrdPrint.Join();
            }
            MessageBox.Show("El certificado se ha guardado con éxito.", "Certificado de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            this.Close();
        }
    }
}
