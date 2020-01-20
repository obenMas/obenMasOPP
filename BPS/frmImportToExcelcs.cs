using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Data.OleDb;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmImportToExcelcs : Form
    {
        string path = string.Empty;
        string strConnectionOle = string.Empty;
        

        public frmImportToExcelcs()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Title = "Backload de OppFilm Perú";
            oFile.Filter = "Excel Files|*.*";
            oFile.InitialDirectory = @"C:\";

            if (oFile.ShowDialog() == DialogResult.OK)
            {
                path = oFile.FileName;
                 strConnectionOle = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=" + path + ";" +
                    @"Extended Properties=" + '"' + "Excel 12.0 Xml;HDR=YES" + '"';
                 lblConnectionString.Text = path;
                //gerenciablc@andinanet.net
                //blc_ns@yahoo.es

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (txtSheet.Text != string.Empty)
            {
                OleDbConnection con = new OleDbConnection(strConnectionOle);

                try
                {
                    con.Open();
                    string sqlExcel = "Select * From [" + txtSheet.Text + "$]";
                    OleDbCommand cmd = new OleDbCommand(sqlExcel, con);
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                    DataTable Ds = new DataTable();
                    DA.Fill(Ds);
                    dgvData.DataSource = Ds;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Impotación pallets OppFilm Perú", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Debe ingresar al hoja que desea importar", "Impotación pallets OppFilm Perú", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
