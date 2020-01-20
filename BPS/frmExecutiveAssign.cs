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
    public partial class frmExecutiveAssign : Form
    {
        public frmExecutiveAssign()
        {
            InitializeComponent();
            populateDataGrid();
            
            
        }
        public void populateDataGrid()
        {
            List<string> customers = new List<string>();
            List<string> executives = new List<string>();

            dgvExecutiveAssign.Rows.Clear();
            cmbCustomer.Items.Clear();
            cmbExecutive.Items.Clear();
            cmbCustomer.ResetText();
            cmbExecutive.ResetText();

            fillExecutives();
         

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwAsignationExecutive");

            if (DS.Tables[0].Rows.Count > 0)
            {
              
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvExecutiveAssign.Rows.Add();
                    dgvExecutiveAssign.Rows[i].Cells["clmCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvExecutiveAssign.Rows[i].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvExecutiveAssign.Rows[i].Cells["clmExecutive"].Value = DS.Tables[0].Rows[i]["Ejecutiva"].ToString();

                    if (!customers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                    if (!executives.Contains(DS.Tables[0].Rows[i]["Ejecutiva"].ToString()))
                       executives.Add(DS.Tables[0].Rows[i]["Ejecutiva"].ToString());
                }
                customers.Sort();
                executives.Sort();

                for (int i = 0; i < customers.Count; i++)
                {
                    cmbCustomer.Items.Add(customers[i]);
                }

                for (int i = 0; i < executives.Count; i++)
                {
                    cmbExecutive.Items.Add(executives[i]); 
                }
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            populateDataGrid();
            cmbCustomer.ResetText();
            cmbExecutive.ResetText();
            cmbCustomer.SelectedIndex = -1;
            cmbExecutive.SelectedIndex = -1;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {   List<string> customers = new List<string>();
            List<string> executives = new List<string>();


            DataSet DS = new DataSet();
            string querystring = "SELECT * FROM vwAsignationExecutive";

            
            if(cmbCustomer.SelectedIndex != -1 && cmbExecutive.SelectedIndex == -1)
            {
                querystring += " WHERE Cliente= '" + cmbCustomer.SelectedItem.ToString() + "' ";
            }
            
            if(cmbCustomer.SelectedIndex == -1 && cmbExecutive.SelectedIndex != -1)
            {
            querystring += " WHERE Ejecutiva= '" + cmbExecutive.SelectedItem.ToString() + "' ";
            }
            if(cmbCustomer.SelectedIndex != -1 && cmbExecutive.SelectedIndex != -1)
            {
            querystring += " WHERE Cliente= '" + cmbCustomer.SelectedItem.ToString() + "' AND Ejecutiva= '" + cmbExecutive.SelectedItem.ToString() + "' ";
            }
            DS=clsConnection.getDataSetResult(querystring);

            dgvExecutiveAssign.Rows.Clear();

            
            if (DS.Tables[0].Rows.Count > 0)
            {
              
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvExecutiveAssign.Rows.Add();
                    dgvExecutiveAssign.Rows[i].Cells["clmCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvExecutiveAssign.Rows[i].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvExecutiveAssign.Rows[i].Cells["clmExecutive"].Value = DS.Tables[0].Rows[i]["Ejecutiva"].ToString();

                    if (!customers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                    if (!executives.Contains(DS.Tables[0].Rows[i]["Ejecutiva"].ToString()))
                        executives.Add(DS.Tables[0].Rows[i]["Ejecutiva"].ToString());
                }
                customers.Sort();
                executives.Sort();

                cmbCustomer.Items.Clear();
                cmbExecutive.Items.Clear();
                cmbCustomer.ResetText();
                cmbExecutive.ResetText();

                for (int i = 0; i < customers.Count; i++)
                {
                    cmbCustomer.Items.Add(customers[i]);
                }

                for (int i = 0; i < executives.Count; i++)
                {
                    cmbExecutive.Items.Add(executives[i]); 
                }

            }
        }


        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                for (int i = 0; i < dgvExecutiveAssign.Rows.Count; i++)
                {
                    dgvExecutiveAssign.Rows[i].Cells[clmCheck.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvExecutiveAssign.Rows.Count; i++)
                {
                    dgvExecutiveAssign.Rows[i].Cells[clmCheck.Index].Value = false;
                }
            }
        }

        public void fillExecutives()
        {
            DataSet DS2 = new DataSet();
            DS2 = clsConnection.getDataSetResult("CALL spSalesExecutive");
            cmbToAssignExecutive.Items.Clear();
            if (DS2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    cmbToAssignExecutive.Items.Add(DS2.Tables[0].Rows[i]["usr_userName"]);
                }
            }

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
             bool error = false;

            if(cmbToAssignExecutive.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una ejecutiva para asignar al cliente", "Asignación de Ejecutiva", MessageBoxButtons.OK);
            }
            else
            {
                for (int i = 0; i < dgvExecutiveAssign.Rows.Count; i++)
                {
                    if(Convert.ToBoolean(dgvExecutiveAssign.Rows[i].Cells[clmCheck.Index].Value))
                    {
                        clsEntity objentityname = new clsEntity(Convert.ToInt32(dgvExecutiveAssign.Rows[i].Cells[clmCodsec.Index].Value));
                        objentityname.fkUser = new clsUser(cmbToAssignExecutive.SelectedItem.ToString()).codsec;
                        error = !objentityname.save() || error;
                    }
                }
                if(!error)
                {
                    MessageBox.Show("Se guardaron los datos correctamente", "Asignación de Ejecutiva", MessageBoxButtons.OK);
                    populateDataGrid();
                    fillExecutives();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error y no se pudieron guardar todos los datos, chequee los datos ingresados e intente nuevamente en caso de ser necesario", "Asignación de Ejecutiva", MessageBoxButtons.OK);
                }
            }

            btnFilter_Click(this,new EventArgs());
            cmbToAssignExecutive.SelectedIndex = -1;
            
        }
        


        
    }
}
