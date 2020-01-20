using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using ZedGraph;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilOutlineComparer : Form
    {
        clsMachine objMachine = new clsMachine();
        private string source = string.Empty;

        public frmMainCoilOutlineComparer()
        {
            InitializeComponent();
        }
        public frmMainCoilOutlineComparer(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
        }

        private void loadMainCoilList(string source)
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            dgvMainCoilList.Rows.Clear();

            if (source == "Date")
            {
                lstMainCoil = clsMainCoil.getMainCoilListForPerOulLine(objMachine.codsec, source, dtpInitdate.Value, dtpEnddate.Value, txtLot.Text);
                
                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvMainCoilList.Rows.Add();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListCodsec"].Value = lstMainCoil[i].codsec.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil[i].BoppCode.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoil[i].code.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoil[i].lotNumber.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoil[i].labRating.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = lstMainCoil[i].initDate.ToString();
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = lstMainCoil[i].endDate.ToString();
                }
            }
            else
            {
                if (clsMainCoil.getExistMainCoilByLotNumber(txtLot.Text))
                {
                    lstMainCoil = clsMainCoil.getMainCoilListForPerOulLine(objMachine.codsec, source, dtpInitdate.Value, dtpEnddate.Value, txtLot.Text);

                    for (int i = 0; i < lstMainCoil.Count; i++)
                    {
                        dgvMainCoilList.Rows.Add();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListCodsec"].Value = lstMainCoil[i].codsec.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil[i].BoppCode.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoil[i].code.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoil[i].lotNumber.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoil[i].labRating.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = lstMainCoil[i].initDate.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = lstMainCoil[i].endDate.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Número de Lote ingresado no existe");
                    dgvMainCoilList.Rows.Clear();
                    chkDate.Checked = false;
                }
            }
        }

        private void frmMainCoilOutlineComparer_Load(object sender, EventArgs e)
        {
            grpbDate.Enabled = false;
            grpbLot.Enabled = false;

            zgcProfile.GraphPane.YAxis.Title.Text = "Espesor";
            zgcProfile.GraphPane.XAxis.Title.Text = "";
            zgcProfile.GraphPane.Title.Text = "Perfil de rollo madre";
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalSelected = 0;

            if (Convert.ToBoolean(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListSelected.Index].Value) == true)
            {
                dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListSelected.Index].Value = !(Convert.ToBoolean(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListSelected.Index].Value));

                drawOutline();
            }
            else
            {
                for (int i = 0; i < dgvMainCoilList.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvMainCoilList.Rows[i].Cells[clmMainCoilListSelected.Index].Value) == true)
                        totalSelected++;
                }
                if (totalSelected < 5)
                {
                    if (e.ColumnIndex == clmMainCoilListSelected.Index)
                    {
                        dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListSelected.Index].Value = !(Convert.ToBoolean(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListSelected.Index].Value));
                    }
                    drawOutline();
                }
                else
                {
                    MessageBox.Show("Solo puede comparar 5 bobinas");
                }
            }
        }

        private void drawOutline()
        {
            zgcProfile.GraphPane.CurveList.Clear();
            PointPairList averagePoints = new PointPairList();
            PointPairList upDesviationPoints = new PointPairList();
            PointPairList downDesviationPoints = new PointPairList();
            int totalSelected = 0;
            int drawed = 0;
            List<Color> lstColors = new List<Color>();

            lstColors.Add(Color.Blue);
            lstColors.Add(Color.Green);
            lstColors.Add(Color.Red);
            lstColors.Add(Color.Yellow);
            lstColors.Add(Color.Black);

            for (int i = 0; i < dgvMainCoilList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvMainCoilList.Rows[i].Cells[clmMainCoilListSelected.Index].Value) == true)
                    totalSelected++;
            }

            for (int i = 0; i < dgvMainCoilList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvMainCoilList.Rows[i].Cells[clmMainCoilListSelected.Index].Value) == true)
                {
                    PointPairList points = new PointPairList();
                    clsMainCoil objMainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value));
                    clsMainCoilQuality objMainCoilQuality = clsMainCoilQuality.getQualityByMainCoil(Convert.ToInt32(dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value));

                    for (int j = 0; j < objMainCoilQuality.thiknessList.Count; j++)
                    {
                        points.Add(j + 1, objMainCoilQuality.thiknessList[j]);
                    }
                    LineItem outLineCurve = zgcProfile.GraphPane.AddCurve("", points, lstColors[drawed], SymbolType.Diamond);
                    //LineItem averageCurve = zgcProfile.GraphPane.AddCurve("", averagePoints, Color.Green, SymbolType.None);
                    //LineItem upDesviationCurve = zgcProfile.GraphPane.AddCurve("", upDesviationPoints, Color.Red, SymbolType.None);
                    //LineItem downDesviationCurve = zgcProfile.GraphPane.AddCurve("", downDesviationPoints, Color.Red, SymbolType.None);

                    zgcProfile.GraphPane.XAxis.Scale.FontSpec.Size = 30;
                    zgcProfile.GraphPane.YAxis.Scale.FontSpec.Size = 30;

                    zgcProfile.AxisChange();
                    zgcProfile.Refresh();
                    drawed++;
                }
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {
                grpbDate.Enabled = true;
                source = "Date";
            }
            else
            {
                grpbDate.Enabled = false;
                source = string.Empty;
            }
        }

        private void chkLot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLot.Checked)
            {
                grpbLot.Enabled = true;
                source = "Lot";
            }
            else
            {
                grpbLot.Enabled = false;
                source = string.Empty;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkDate.Checked = false;
            chkLot.Checked = false;
            dtpInitdate.Value = DateTime.Now;
            dtpEnddate.Value = DateTime.Now;
            txtLot.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(source))
                loadMainCoilList(source);
            else
                MessageBox.Show("No existe un criterio de búsqueda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }
    }
}
