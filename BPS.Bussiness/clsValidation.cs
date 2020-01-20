using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace BPS.Bussiness
{
    public class clsValidation
    {
        public static bool validateField(ref TextBox txtField, string validation)
        {
            Label lblField = new Label();
            return validateField(ref txtField, ref lblField, validation);
        }
        public static bool validateField(ref TextBox txtField, ref Label lblLabel, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "notEmpty":
                    if (txtField.Text == "")
                    {
                        lblLabel.ForeColor = Color.Red;
                        txtField.BackColor = Color.FromArgb(253, 230, 231);
                        result = false;
                    }
                    else
                    {
                        lblLabel.ForeColor = SystemColors.WindowText;
                        txtField.BackColor = SystemColors.Window;
                        result = true;
                    }
                    break;
                case "morethan0":
                    if (txtField.Text == "0")
                    {
                        lblLabel.ForeColor = Color.Red;
                        txtField.BackColor = Color.FromArgb(253, 230, 231);
                        result = false;
                    }
                    else
                    {
                        lblLabel.ForeColor = SystemColors.WindowText;
                        txtField.BackColor = SystemColors.Window;
                        result = true;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        public static bool validateField(ref Label lblField, ref Label lblLabel, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "moreThan0":
                    if (Convert.ToDouble(lblField.Text) <=0)
                    {
                        lblLabel.ForeColor = Color.Red;
                        lblField.BackColor = Color.FromArgb(253, 230, 231);
                        result = false;
                    }
                    else
                    {
                        lblLabel.ForeColor = SystemColors.WindowText;
                        lblField.BackColor = SystemColors.Window;
                        result = true;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        public static bool validateField(ref ComboBox cmbField, string validation)
        {
            Label lblField = new Label();
            return validateField(ref cmbField, ref lblField, validation);
        }
        public static bool validateField(ref ComboBox cmbField, ref Label lblLabel, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "selected":
                    if (cmbField.SelectedItem == null)
                    {
                        lblLabel.ForeColor = Color.Red;
                        cmbField.BackColor = Color.FromArgb(253, 230, 231);
                        result = false;
                    }
                    else
                    {
                        lblLabel.ForeColor = SystemColors.WindowText;
                        cmbField.BackColor = SystemColors.Window;
                        result = true;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        public static bool validateField(ref ListBox lstbField, string validation)
        {
            Label lblField = new Label();
            return validateField(ref lstbField, ref lblField, validation);
        }
        public static bool validateField(ref ListBox lstbField, ref Label lblLabel, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "selected":
                    if (lstbField.SelectionMode == SelectionMode.One)
                    {
                        if (lstbField.SelectedItem == null)
                        {
                            lblLabel.ForeColor = Color.Red;
                            lstbField.BackColor = Color.FromArgb(253, 230, 231);
                            result = false;
                        }
                        else
                        {
                            lblLabel.ForeColor = SystemColors.WindowText;
                            lstbField.BackColor = SystemColors.Window;
                            result = true;
                        }
                    }
                    else
                    {
                        if (lstbField.SelectedItems.Count == 0)
                        {
                            lblLabel.ForeColor = Color.Red;
                            lstbField.BackColor = Color.FromArgb(253, 230, 231);
                            result = false;
                        }
                        else
                        {
                            lblLabel.ForeColor = SystemColors.WindowText;
                            lstbField.BackColor = SystemColors.Window;
                            result = true;
                        }
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        public static bool validateField(ref DataGridView dgvField, string validation)
        {
            Label lblField = new Label();
            return validateField(ref dgvField, ref lblField, validation);
        }
        public static bool validateField(ref DataGridView dgvField, ref GroupBox grpbContainer, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "isValid":
                    if (dgvField.Rows.Count == 1 && dgvField.Rows[0].IsNewRow)
                    {
                        result = false;
                    }
                    else
                    {
                        for (int i = 0; i < dgvField.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvField.ColumnCount; j++)
                            {
                                if (dgvField.Rows[i].IsNewRow == false)
                                {
                                    if (dgvField.Rows[i].Cells[j].Value == null || dgvField.Rows[i].Cells[j].Value.ToString() == "")
                                        result = false;
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            if (result == true)
                grpbContainer.ForeColor = SystemColors.WindowText;
            else
                grpbContainer.ForeColor = Color.Red;

            return result;
        }
        public static bool validateField(ref DataGridView dgvField, ref Label lblLabel, string validation)
        {
            bool result = true;

            switch (validation)
            {
                case "isValid":
                    for (int i = 0; i < dgvField.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvField.ColumnCount; j++)
                        {
                            if (dgvField.Rows[i].IsNewRow == false)
                            {
                                if (dgvField.Rows[i].Cells[j].Value.ToString() == "")
                                    result = false;
                            }

                        }
                    }
                    break;
                default:
                    break;
            }

            if (result == true)
                lblLabel.ForeColor = SystemColors.WindowText;
            else
                lblLabel.ForeColor = Color.Red;

            return result;
        }

        public static bool validateField(string texBoxField)
        {      
            if(texBoxField == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validateCoils(clsCoil coil)
        {
            bool result = true;

            if (coil.fkStatus == 33)
            {
                double metrajeNet = coil.length - coil.getUsedLength(coil.codsec);
                
                if (metrajeNet > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
