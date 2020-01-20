using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCoilDefects : Form
    {
        frmCuttingStopRegistration winCuttingStopRegistration = new frmCuttingStopRegistration();
        string defectsValues = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
        string defectsNames = "";

        public frmCoilDefects()
        {
            InitializeComponent();
        }
        public frmCoilDefects(frmCuttingStopRegistration parentForm)
        {
            InitializeComponent();
            winCuttingStopRegistration = parentForm;
        }

        private void frmCoilDefects_Load(object sender, EventArgs e)
        {
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);

            for (int i = 0; i < grpbDefects.Controls.Count; i++)
            {
                ((CheckBox)grpbDefects.Controls[i]).Checked = Convert.ToBoolean(defectsValues.Split(new char[] { ';' })[i]);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            int qualityCodsec = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
            string qualityName = ((clsCuttingQuality)cmbQuality.SelectedItem).name;
            defectsValues = "";
            defectsNames = "";


            for (int i = 0; i < grpbDefects.Controls.Count; i++)
            {
                defectsValues += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                defectsValues += (i < grpbDefects.Controls.Count - 1) ? ";" : "";

                defectsNames += (((CheckBox)grpbDefects.Controls[i]).Checked) ? ((CheckBox)grpbDefects.Controls[i]).Text : "";
                defectsNames += (((CheckBox)grpbDefects.Controls[i]).Checked) ? (i < grpbDefects.Controls.Count - 1) ? ";" : "" : "";
            }

            winCuttingStopRegistration.defectsValues = defectsValues;
            winCuttingStopRegistration.defectsNames = defectsNames;
            winCuttingStopRegistration.qualityCodsec = qualityCodsec;
            winCuttingStopRegistration.qualityName = qualityName;

            this.Close();
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.Text == "Observación")
                grpbDefects.Enabled = true;
            else
                grpbDefects.Enabled = false;
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
                cmbQuality.Items.Clear();
                for (int i = 0; i < lstCuttingQuality.Count; i++)
                    cmbQuality.Items.Add(lstCuttingQuality[i]);
            }
        }
    }
}
