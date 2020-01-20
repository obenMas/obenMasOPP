using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using System.IO;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmDatabaseConfig : Form
    {
        string originalDBE = clsGlobal.DataBaseEngine;
        public frmDatabaseConfig()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (clsConnection.validateConnection(txtServer.Text, txtDataBase.Text, txtUser.Text, txtDBPassword.Text, cmbDatabaseEngine.Text))
            {
                MessageBox.Show("Configuración de conexión válida.", "Conexion a base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Configuración de conexión válida.", "Conexion a base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder newFile = new StringBuilder();

            string fileName = "";

            if (File.Exists("config.xml"))
                fileName = "config.xml";
            else if (File.Exists("../../config.xml"))
                fileName = "../../config.xml";

            string temp = "";

            string[] file = File.ReadAllLines(fileName);

            foreach (string line in file)
            {

                if (line.Contains("server value"))
                {
                    temp = "<server value=\"" + txtServer.Text + "\" />";
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                else if (line.Contains("database value"))
                {
                    temp = "<database value=\"" + txtDataBase.Text + "\" />";
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                else if (line.Contains("userName value"))
                {
                    temp = "<userName value=\"" + txtUser.Text + "\" />";
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                else if (line.Contains("password value"))
                {
                    temp = "<password value=\"" + txtDBPassword.Text + "\" />";
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                newFile.Append(line + "\r\n");
            }

            File.WriteAllText(fileName, newFile.ToString());

            clsGlobal.DataBaseEngine = cmbDatabaseEngine.Text;
            clsGlobal.server = txtServer.Text;
            clsGlobal.database = txtDataBase.Text;
            clsGlobal.password = txtDBPassword.Text;
            clsGlobal.databaseUser = txtUser.Text;

            MessageBox.Show("Configuración de conexión guardada con éxito.", "Conexion a base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            this.Close();
        }

        private void txtDBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDatabaseConfig_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbDatabaseEngine.Items.Count; i++)
            {
                if (cmbDatabaseEngine.Items[i].ToString() == clsGlobal.DataBaseEngine)
                    cmbDatabaseEngine.SelectedIndex = i;
            }
        }
    }
}
