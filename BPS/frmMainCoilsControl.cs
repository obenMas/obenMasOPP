using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Business;

namespace BPS
{
    public partial class frmMainCoilsControl : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        DataSet DS3 = new DataSet();

        public frmMainCoilsControl()
        {
            InitializeComponent();
            PopulateComboMainCoils();
        }

        public void getDataSet(string maincoilcode)
        {
            DS = clsConnection.getDataSetResult("CALL spMainCoilQualityControlsDetail('" + maincoilcode.ToString() +"')");
        }

        public void getDataSet2(string bopcode)
        {
            DS2 = clsConnection.getDataSetResult("CALL spQualityControlsByFilmByBoppCode('" + bopcode.ToString() + "')");
        }

        public void getDataSet3(string mainCoilCode)
        {
            DS3 = clsConnection.getDataSetResult("SELECT CantMed FROM vwQCCountByMainCoil where BM = '" + mainCoilCode + "'");
        }


        public void PopulateDgv(string boppcode,string mainCoilCode)
        {
            getDataSet2(boppcode);  
            dgvMainCoilsControl.Rows.Clear();
            if (DS2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    dgvMainCoilsControl.Rows.Add();
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_codsec"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmControlName.Index].Value = DS2.Tables[0].Rows[i]["qc_name"].ToString();
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMedNec.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_valuesquantity"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCantMed.Index].Value = QuantityMeditions(mainCoilCode, DS2.Tables[0].Rows[i]["qc_name"].ToString());
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMax.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_maximum"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMin.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_minimum"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmfkBopp.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_fkBopp"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmBopCode.Index].Value = DS2.Tables[0].Rows[i]["bopp_code"].ToString();
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmTypeControl.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qct_codsec"]);
                    
                    if (Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_valuesquantity"]) == QuantityMeditions(mainCoilCode, DS2.Tables[0].Rows[i]["qc_name"].ToString())) 
                    {
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCodsec.Index].Style.BackColor = Color.LightGreen;
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmControlName.Index].Style.BackColor = Color.LightGreen;
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMedNec.Index].Style.BackColor = Color.LightGreen;
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCantMed.Index].Style.BackColor = Color.LightGreen;
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMax.Index].Style.BackColor = Color.LightGreen;
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMin.Index].Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        public void PopulateComboMainCoils()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            lstMainCoil = clsMainCoil.getMainCoilCodeList();

            for (int i = 0; i < lstMainCoil.Count; i++)
            {
                cmbMainCoils.Items.Add(lstMainCoil[i].code);
            }
        }

        private void cmbCoils_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataSet(cmbMainCoils.SelectedItem.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    txtBopp.Text = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    txtIniDate.Text = Convert.ToDateTime(DS.Tables[0].Rows[i]["Inicio"]).ToString();
                    txtEndDate.Text = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fin"]).ToString();
                    txtLotNumber.Text = DS.Tables[0].Rows[i]["Lote"].ToString();
                    txtNetWeight.Text = Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]).ToString();
                }
            }
            PopulateDgv(txtBopp.Text,cmbMainCoils.SelectedItem.ToString());
        }

        private void txtMainCoil_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 getDataSet(txtMainCoil.Text.ToString());

                 if (DS.Tables[0].Rows.Count > 0)
                 {
                     for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                     {
                         txtBopp.Text = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                         txtIniDate.Text = Convert.ToDateTime(DS.Tables[0].Rows[i]["Inicio"]).ToString();
                         txtEndDate.Text = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fin"]).ToString();
                         txtLotNumber.Text = DS.Tables[0].Rows[i]["Lote"].ToString();
                         txtNetWeight.Text = Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]).ToString();
                     }
                 }
             }
             PopulateDgv(txtBopp.Text, txtMainCoil.Text);
        }

        public int QuantityMeditions(string mainCoilCode,string controlname)
        {
            DS3 = clsConnection.getDataSetResult("SELECT CantMed FROM vwQCCountByMainCoil where BM = '" + mainCoilCode + "' AND QControl='"+controlname+"'");
            int cantMed = 0;

            if (DS3.Tables.Count>0 && DS3.Tables[0].Rows.Count>0)
            {
                cantMed = Convert.ToInt32(DS3.Tables[0].Rows[0]["CantMed"]);
            }
            
            return cantMed;
        }

        private void dgvMainCoilsControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fkControl = 0;
            int fkMainCoil = 0;
            int quantityMed = 0;
            int medNecesarias = 0;
            int fkCodsec = 0;
            string type;
            string mainCcode = string.Empty;

            clsQualityControls objControlType = new clsQualityControls();

            if(txtMainCoil.Text == string.Empty && cmbMainCoils.SelectedIndex != -1)
            {
                fkMainCoil = clsMainCoil.getMainCoilCodsecByCode(cmbMainCoils.SelectedItem.ToString());
            }
            if (txtMainCoil.Text != string.Empty && cmbMainCoils.SelectedIndex == -1)
            {
                fkMainCoil = clsMainCoil.getMainCoilCodsecByCode(txtMainCoil.Text);
            }

            mainCcode = clsMainCoil.getMainCoilCodeByCodsec(fkMainCoil);

            fkControl = clsQualityControls.codsecByQualityControlName(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmControlName.Index].Value.ToString());

            quantityMed = Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCantMed.Index].Value);

            medNecesarias = Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmMedNec.Index].Value);

            fkCodsec = Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value);

            type = getQualityControlTypeByQCbyFilmCodsec(Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));

            if(e.ColumnIndex == clmNew.Index)
            {
                    if (type == "Valor SI/NO")
                    {
                        frmQualityControlsMainCoilsBoolean winCuttingOrderList = new frmQualityControlsMainCoilsBoolean(fkMainCoil, fkControl, quantityMed, medNecesarias,fkCodsec);
                        winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                        winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                    }
                    else if (type == "Texto")
                    {

                        frmQualityControlsMainCoilsText winCuttingOrderList = new frmQualityControlsMainCoilsText(fkMainCoil, fkControl, quantityMed, medNecesarias, fkCodsec);
                        winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                        winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                    }
                    else if (type == "Valor numerico")
                    {
                        frmQualityControlsMainCoilsNumber winCuttingOrderList = new frmQualityControlsMainCoilsNumber(fkMainCoil, fkControl, quantityMed, medNecesarias, fkCodsec);
                        winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                        winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                    }
            }

            if (e.ColumnIndex == clmReport.Index) 
            {
                if (Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmTypeControl.Index].Value) == 1)//valor Numerico
                {
                    frmQControlNumber winCuttingOrderList = new frmQControlNumber(fkMainCoil,Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), mainCcode); //(int mainCoilCodsec, int fkQCByFilm, string mainCCode)
                    winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                }
                else if(Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmTypeControl.Index].Value) == 2)//valor SI/No
                {
                    //frmQControlNumber winCuttingOrderList = new frmQControlNumber(fkMainCoil,Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), mainCcode); //(int mainCoilCodsec, int fkQCByFilm, string mainCCode)
                    //winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    //winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                }
                else // 3= Texto
                {
                    frmQControlText winCuttingOrderList = new frmQControlText(fkMainCoil, Convert.ToInt32(dgvMainCoilsControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), mainCcode); //(int mainCoilCodsec, int fkQCByFilm, string mainCCode)
                    winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    winCuttingOrderList.ShowDialog(); //abrir frm de forma modal 
                }
            
            }


            if (txtMainCoil.Text == string.Empty && cmbMainCoils.SelectedIndex != -1)
            {
                PopulateDgv(txtBopp.Text, cmbMainCoils.SelectedItem.ToString());
            }
            else
            {
                PopulateDgv(txtBopp.Text, txtMainCoil.Text);
            }
        }

        public string getQualityControlTypeByQCbyFilmCodsec(int qualityCtrlByFilmCodsec)
        {
            DataSet DS = new DataSet();
            string nameControl = string.Empty;

            DS = clsConnection.getDataSetResult("SELECT qct_name as ControlName FROM  bps_prod_qualitycontrolsbyfilm LEFT JOIN  bps_prod_qualitycontrols ON(bps_prod_qualitycontrols.qc_codsec = bps_prod_qualitycontrolsbyfilm.qcbf_fkqualitycontrol) LEFT JOIN bps_prod_qualityControlsTypes ON(bps_prod_qualityControlsTypes.qct_codsec = bps_prod_qualitycontrols.qc_fkQualityControlType) WHERE  qcbf_codsec = " + qualityCtrlByFilmCodsec);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                nameControl = DS.Tables[0].Rows[i]["ControlName"].ToString();
            }
            return nameControl;
        }
    }
}
