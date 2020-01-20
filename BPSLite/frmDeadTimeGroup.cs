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
    public partial class frmDeadTimeGroup : Form
    {
        public frmDeadTimeGroup()
        {
            InitializeComponent();
            PopulateDeadTime();
            PopulateDeadTimeSecond();
        }

        private void PopulateDeadTimeSecond()
        {
            List<clsDeadTimeGroup> lstDeadTime = new List<clsDeadTimeGroup>();
            lstDeadTime = clsDeadTimeGroup.getList();
            cmbtype.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbtype.Items.Add(lstDeadTime[i]);
        }

        private void PopulateDeadTime()
        {
            List<clsDeadTimeGroup> lstDeadTime = new List<clsDeadTimeGroup>();
            lstDeadTime = clsDeadTimeGroup.getList();
            cmbDeadTime.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbDeadTime.Items.Add(lstDeadTime[i]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    clsDeadTimeType objDeadTime = new clsDeadTimeType();
                    objDeadTime.fkDeadTimeGroup = ((clsDeadTimeGroup)cmbDeadTime.SelectedItem).codsec;
                    objDeadTime.deadTimeName = txtDescription.Text;
                    objDeadTime.descrition = txtDescription.Text;
                    if (objDeadTime.save())
                    {
                        if (MessageBox.Show("Tiempo Muerto generado correctamente..\r\n Desea Generar un Nuevo Tiempo Muerto?", "Tiempo Muerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            ClearForm();
                        else
                            this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Para poder guardar debe llenar todos los datos pintados de ROJO", "Tiempo Muerto", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tiempo Muerto", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbDeadTime.Focus();
            }
        }

        private void ClearForm()
        {
            cmbDeadTime.Text = "";
            cmbDeadTime.SelectedIndex = -1;
            txtDescription.Clear();
            cmbDeadTime.Focus();
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbDeadTime, ref label1, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtDescription, ref label2, "notEmpty")) isValid = false;
            return isValid;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFormDT())
                {
                    if (clsDeadTimeType.checkDeadTimeName(txtname.Text))
                    {
                        clsDeadTimeType objDeadTime = new clsDeadTimeType();
                        objDeadTime.fkDeadTimeGroup = ((clsDeadTimeGroup)cmbtype.SelectedItem).codsec;
                        objDeadTime.deadTimeName = txtname.Text;
                        objDeadTime.descrition = (string.IsNullOrEmpty(txtnotes.Text)) ? txtname.Text : txtnotes.Text;
                        objDeadTime.days = Convert.ToInt32(numday.Value);
                        TimeSpan hour = new TimeSpan(Convert.ToInt32(numday.Value), Convert.ToInt32(numminutes.Value), 0);
                        objDeadTime.standartTime = hour;
                        objDeadTime.isEnable = chkisEnable.Checked;
                        objDeadTime.isVisible = true;
                        if (objDeadTime.saveStandart())
                        {
                            if (MessageBox.Show("Tiempo Muerto generado correctamente..\r\n Desea Generar un Nuevo Tiempo Muerto?", "Tiempo Muerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                ClearForm();
                            else
                                this.Close();
                        }
                        else
                            MessageBox.Show("Se ha producido un error al momento de Guardar el tiempo muerto", "Tiempo Muerto", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        MessageBox.Show("Usted no puede ingresar dicho tiempo muerto debido a que ya está registrado", "Tiempo Muerto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        cmbDeadTime.Focus();
                    }
                }
                else
                    MessageBox.Show("Para poder guardar debe llenar todos los datos pintados de ROJO o los valores de estándar deben ser mayores que 0", "Tiempo Muerto", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tiempo Muerto", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbDeadTime.Focus();
            }
        }

        private bool ValidateFormDT()
        {
            bool isValid = true;
            if (chkisEnable.Checked)
            {
                if (!clsValidation.validateField(ref cmbtype, ref lbltype, "selected")) isValid = false;
                if (!clsValidation.validateField(ref txtname, ref label4, "notEmpty")) isValid = false;
                if (numday.Value == 0 && numminutes.Value == 0)
                    isValid = false;
                else if (numday.Value < 0 && numminutes.Value < 0)
                    isValid = false;
                return isValid; 
            }
            else
            {
                if (!clsValidation.validateField(ref cmbtype, ref lbltype, "selected")) isValid = false;
                if (!clsValidation.validateField(ref txtname, ref label4, "notEmpty")) isValid = false;
                return isValid;
            }
        }

        private void frmDeadTimeGroup_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tbpDeadTime);
        }
    }
}
