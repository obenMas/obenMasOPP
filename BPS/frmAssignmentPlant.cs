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
    public partial class frmAssignmentPlant : Form
    {
        DataSet DS = new DataSet();

        public frmAssignmentPlant()
        {
            InitializeComponent();
            fillPlants();
            getDataSet();
            populateDataGrid();
        }

        public void fillPlants()
        {
            DataSet DS2 = new DataSet();
            DS2 = clsConnection.getDataSetResult("SELECT plant_name FROM bps_admin_plant ORDER BY plant_name");
            cmbToAssignPlant.Items.Clear();
            if(DS2.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS2.Tables[0].Rows.Count;i++)
                {
                    cmbToAssignPlant.Items.Add(DS2.Tables[0].Rows[i]["plant_name"]);
                }
            }
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderControl");
        }

        public void getDataSet(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }

        public void populateDataGrid()
        {
            List<string> customers = new List<string>();
            List<string> saleorder = new List<string>();
            List<string> films = new List<string>();
            List<int> widths = new List<int>();
            List<string> diameters = new List<string>();
            List<string> cores = new List<string>();
            List<string> plants = new List<string>();

            dgvAssignmentPlant.Rows.Clear();
            cmbCustomer.Items.Clear();
            cmbSaleOrder.Items.Clear();
            cmbFilm.Items.Clear();
            cmbWidth.Items.Clear();
            cmbDiameter.Items.Clear();
            cmbCore.Items.Clear();
            cmbPlant.Items.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvAssignmentPlant.Rows.Add();
                    dgvAssignmentPlant.Rows[i].Cells["clmCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    dgvAssignmentPlant.Rows[i].Cells["clmOrder"].Value = DS.Tables[0].Rows[i]["codsec"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmCreatedDay"].Value =Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"]).ToShortDateString();
                    dgvAssignmentPlant.Rows[i].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmClientOC"].Value = DS.Tables[0].Rows[i]["OCCliente"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmWidth"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    dgvAssignmentPlant.Rows[i].Cells["clmDiameter"].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmCore"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                    dgvAssignmentPlant.Rows[i].Cells["clmCuttingPending"].Value =Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteCorte"]),2);
                    dgvAssignmentPlant.Rows[i].Cells["clmNotes"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmCompromiseDay"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega"]).ToShortDateString();
                    dgvAssignmentPlant.Rows[i].Cells["clmAntiquityDays"].Value = (DateTime.Now - Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"])).Days;
                    dgvAssignmentPlant.Rows[i].Cells["clmStatus"].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmPlant"].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvAssignmentPlant.Rows[i].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]),2);

                    if (!customers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                    if (!saleorder.Contains(DS.Tables[0].Rows[i]["codsec"].ToString()))
                        saleorder.Add(DS.Tables[0].Rows[i]["codsec"].ToString());
                    if (!films.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        films.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());
                    if (!widths.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"])))
                        widths.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]));
                    if (!diameters.Contains(DS.Tables[0].Rows[i]["Diametro"].ToString()))
                        diameters.Add(DS.Tables[0].Rows[i]["Diametro"].ToString());
                    if (!cores.Contains(DS.Tables[0].Rows[i]["Core"].ToString()))
                        cores.Add(DS.Tables[0].Rows[i]["Core"].ToString());
                    if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                        plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());
                }

                customers.Sort();
                saleorder.Sort();
                films.Sort();
                widths.Sort();
                diameters.Sort();
                cores.Sort();
                plants.Sort();

                for(int i=0;i<customers.Count;i++)
                {
                    cmbCustomer.Items.Add(customers[i]);
                }

                for (int i = 0; i < saleorder.Count; i++)
                {
                    cmbSaleOrder.Items.Add(saleorder[i]);
                }

                for (int i = 0; i < films.Count; i++)
                {
                    cmbFilm.Items.Add(films[i]);
                }

                for (int i = 0; i < widths.Count; i++)
                {
                    cmbWidth.Items.Add(widths[i]);
                }

                for (int i = 0; i < diameters.Count; i++)
                {
                    cmbDiameter.Items.Add(diameters[i]);
                }

                for (int i = 0; i < cores.Count; i++)
                {
                    cmbCore.Items.Add(cores[i]);
                }

                for (int i = 0; i < plants.Count; i++)
                {
                    cmbPlant.Items.Add(plants[i]);
                }

                if (cmbCustomer.Text != string.Empty)
                    cmbCustomer.SelectedIndex = 0;

                if (cmbSaleOrder.Text != string.Empty)
                    cmbSaleOrder.SelectedIndex = 0;

                if (cmbFilm.Text != string.Empty)
                    cmbFilm.SelectedIndex = 0;

                if (cmbWidth.Text != string.Empty)
                    cmbWidth.SelectedIndex = 0;

                if (cmbDiameter.Text != string.Empty)
                    cmbDiameter.SelectedIndex = 0;

                if (cmbCore.Text != string.Empty)
                    cmbCore.SelectedIndex = 0;

                if (cmbAntiquityDays.Text != string.Empty)
                {
                    switch(cmbAntiquityDays.Text)
                    {
                        case "0-14":
                            cmbAntiquityDays.SelectedIndex = 0;
                            break;
                        case "15-21":
                            cmbAntiquityDays.SelectedIndex = 1;
                            break;
                        case "22-30":
                            cmbAntiquityDays.SelectedIndex = 2;
                            break;
                        case "+30":
                            cmbAntiquityDays.SelectedIndex = 3;
                            break;
                    }
                }

                if (cmbPlant.Text != string.Empty)
                    cmbPlant.SelectedIndex = 0;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool first = false;
            string querystring = "SELECT * FROM vwSalesOrderControl";

            if (cmbCustomer.SelectedIndex != -1)
            {
                first = true;
                querystring += " WHERE Cliente ='" + cmbCustomer.SelectedItem.ToString() + "' ";
            }

            if (cmbSaleOrder.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "codsec ='" + cmbSaleOrder.SelectedItem.ToString() + "' ";
            }

            if (cmbFilm.SelectedIndex != -1)
            {
                if(!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Pelicula ='" + cmbFilm.SelectedItem.ToString() + "' ";
            }

            if (cmbWidth.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Ancho =" + cmbWidth.SelectedItem.ToString() + " ";
            }

            if (cmbDiameter.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Diametro ='" + cmbDiameter.SelectedItem.ToString() + "' ";
            }

            if (cmbCore.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Core ='" + cmbCore.SelectedItem.ToString() + "' ";
            }

            if (cmbAntiquityDays.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                switch(cmbAntiquityDays.SelectedItem.ToString())
                {
                    case "0-14":
                        querystring += "FechaIngreso BETWEEN '" + DateTime.Today.Subtract(TimeSpan.FromDays(14)).ToShortDateString() + "' AND '" + DateTime.Today.ToShortDateString() + "' ";
                        break;
                    case "15-21":
                        querystring += "FechaIngreso BETWEEN '" + DateTime.Today.Subtract(TimeSpan.FromDays(21)).ToShortDateString() + "' AND '" + DateTime.Today.Subtract(TimeSpan.FromDays(15)).ToShortDateString() + "' ";
                        break;
                    case "22-30":
                        querystring += "FechaIngreso BETWEEN '" + DateTime.Today.Subtract(TimeSpan.FromDays(30)).ToShortDateString() + "' AND '" + DateTime.Today.Subtract(TimeSpan.FromDays(22)).ToShortDateString() + "' ";
                        break;
                    case "+30":
                        querystring += "FechaIngreso < '" + DateTime.Today.Subtract(TimeSpan.FromDays(31)).ToShortDateString() + "'";
                        break;
                }
                
            }

            if (cmbPlant.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Planta ='" + cmbPlant.SelectedItem.ToString() + "' ";
            }

            getDataSet(querystring);
            populateDataGrid();
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            getDataSet();
            populateDataGrid();
            cmbCustomer.ResetText();
            cmbSaleOrder.ResetText();
            cmbFilm.ResetText();
            cmbWidth.ResetText();
            cmbDiameter.ResetText();
            cmbCore.ResetText();
            cmbAntiquityDays.ResetText();
            cmbPlant.ResetText();
            cmbCustomer.SelectedIndex =-1;
            cmbSaleOrder.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbCore.SelectedIndex = -1;
            cmbAntiquityDays.SelectedIndex = -1;
            cmbPlant.SelectedIndex = -1;
        }

        private void chkSelected_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSelected.Checked)
            {
                for(int i=0;i<dgvAssignmentPlant.Rows.Count;i++)
                {
                    dgvAssignmentPlant.Rows[i].Cells[clmSelcted.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvAssignmentPlant.Rows.Count; i++)
                {
                    dgvAssignmentPlant.Rows[i].Cells[clmSelcted.Index].Value = false;
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            bool error = false;

            if(cmbToAssignPlant.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la planta de destino", "Asignación de planta", MessageBoxButtons.OK);
            }
            else
            {
                for (int i = 0; i < dgvAssignmentPlant.Rows.Count; i++)
                {
                    if(Convert.ToBoolean(dgvAssignmentPlant.Rows[i].Cells[clmSelcted.Index].Value))
                    {
                        clsSalesOrderDetail objsod = new clsSalesOrderDetail(Convert.ToInt32(dgvAssignmentPlant.Rows[i].Cells[clmCodsec.Index].Value));
                        objsod.fkPlant = new clsPlant(cmbToAssignPlant.SelectedItem.ToString()).codsec;
                        error = !objsod.save() || error;
                    }
                }
                if(!error)
                {
                    MessageBox.Show("Se guardaron los datos correctamente", "Asignación de planta", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error y no se pudieron guardar todos los datos, chequee los datos ingresados e intente nuevamente en caso de ser necesario", "Asignación de planta", MessageBoxButtons.OK);
                }
            }

            btnFilter_Click(this,new EventArgs());
        }


    }
}
