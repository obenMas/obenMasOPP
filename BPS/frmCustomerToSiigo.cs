using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmCustomerToSiigo : Form
    {
        List<clsImportedPallet> lstImportedPallets = new List<clsImportedPallet>();
        List<string[]> parsedData = new List<string[]>();
        //List<clsPallet> lstPallet = new List<clsPallet>();

        public frmCustomerToSiigo()
        {
            InitializeComponent();
        }
        public void importFromFile()
        {
            parseCSV(txtFileName.Text);

            for (int i = 0; i < parsedData.Count; i++)
            {
                if (i == 0)
                { }
                else
                {

                    lstImportedPallets.Add(new clsImportedPallet());

                    lstImportedPallets[lstImportedPallets.Count - 1].id = parsedData[i][0];
                    lstImportedPallets[lstImportedPallets.Count - 1].name = parsedData[i][1];
                    lstImportedPallets[lstImportedPallets.Count - 1].contact = parsedData[i][2];
                    lstImportedPallets[lstImportedPallets.Count - 1].adress = parsedData[i][3];
                    lstImportedPallets[lstImportedPallets.Count - 1].country = parsedData[i][4];
                    lstImportedPallets[lstImportedPallets.Count - 1].city = parsedData[i][5];
                    lstImportedPallets[lstImportedPallets.Count - 1].phone1 = parsedData[i][6];
                    lstImportedPallets[lstImportedPallets.Count - 1].phone2 = parsedData[i][7];
                    lstImportedPallets[lstImportedPallets.Count - 1].fax = parsedData[i][8];
                    lstImportedPallets[lstImportedPallets.Count - 1].email = parsedData[i][9];

                }
            }
            lblImportedPallets.Text = lstImportedPallets.Count.ToString();
            dgvImportedPallets.Rows.Clear();
            int coilCount = 0;

            for (int i = 0; i < lstImportedPallets.Count; i++)
            {
                dgvImportedPallets.Rows.Add();

                int dgvPos = dgvImportedPallets.Rows.Count - 1;

                dgvImportedPallets.Rows[dgvPos].Cells[clmType.Index].Value = "P";
                dgvImportedPallets.Rows[dgvPos].Cells[clmid.Index].Value = lstImportedPallets[i].id;
                dgvImportedPallets.Rows[dgvPos].Cells[clmname.Index].Value = lstImportedPallets[i].name;
                dgvImportedPallets.Rows[dgvPos].Cells[clmcontact.Index].Value = lstImportedPallets[i].contact;
                dgvImportedPallets.Rows[dgvPos].Cells[clmaddress.Index].Value = lstImportedPallets[i].adress; ;
                dgvImportedPallets.Rows[dgvPos].Cells[clmcountry.Index].Value = lstImportedPallets[i].country;
                dgvImportedPallets.Rows[dgvPos].Cells[clmcity.Index].Value = lstImportedPallets[i].city;
                dgvImportedPallets.Rows[dgvPos].Cells[clmphone1.Index].Value = lstImportedPallets[i].phone1;
                dgvImportedPallets.Rows[dgvPos].Cells[clmphone2.Index].Value = lstImportedPallets[i].phone2;
                dgvImportedPallets.Rows[dgvPos].Cells[clmfax.Index].Value = lstImportedPallets[i].fax;
                dgvImportedPallets.Rows[dgvPos].Cells[clmemail.Index].Value = lstImportedPallets[i].email;
            }

            lblImportedPallets.Text = lstImportedPallets.Count.ToString();
            lblImportedCoils.Text = coilCount.ToString();

        }
        public List<string[]> parseCSV(string path)
        {
            try
            {
                parsedData = new List<string[]>();

                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return parsedData;
        }
        private void frmRegisterCoilPalletsImported_Load(object sender, EventArgs e)
        {

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            opfImport.ShowDialog();
            txtFileName.Text = opfImport.FileName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            importFromFile();

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            lstEntity = clsEntity.getList();
            List<clsImportedPallet> lstNewImporter = new List<clsImportedPallet>();
            if (lstImportedPallets.Count > lstEntity.Count)
            {
                for (int i = 0; i < lstImportedPallets.Count; i++)
                {
                    for (int j = 0; j < lstEntity.Count; j++)
                    {
                        if (lstImportedPallets[i].id == lstEntity[j].id)
                        {
                            dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmname.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmcontact.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmaddress.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmcountry.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmcity.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmphone1.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmphone2.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmfax.Index].Style.ForeColor = Color.Red;
                            dgvImportedPallets.Rows[i].Cells[clmemail.Index].Style.ForeColor = Color.Red;

                            //lstNewImporter.Add(new clsImportedPallet());
                            //lstNewImporter[pos].id = dgvImportedPallets.Rows[i].Cells[clmid.Index].Value.ToString();
                            //lstNewImporter[pos].name = dgvImportedPallets.Rows[i].Cells[clmname.Index].Value.ToString();
                            //lstNewImporter[pos].contact = dgvImportedPallets.Rows[i].Cells[clmcontact.Index].Value.ToString();
                            //lstNewImporter[pos].adress = dgvImportedPallets.Rows[i].Cells[clmaddress.Index].Value.ToString();
                            //lstNewImporter[pos].country = dgvImportedPallets.Rows[i].Cells[clmcountry.Index].Value.ToString();
                            //lstNewImporter[pos].city = dgvImportedPallets.Rows[i].Cells[clmcity.Index].Value.ToString();
                            //lstNewImporter[pos].phone1 = dgvImportedPallets.Rows[i].Cells[clmphone1.Index].Value.ToString();
                            //lstNewImporter[pos].phone2 = dgvImportedPallets.Rows[i].Cells[clmphone2.Index].Value.ToString();
                            //lstNewImporter[pos].fax = dgvImportedPallets.Rows[i].Cells[clmfax.Index].Value.ToString();
                            //lstNewImporter[pos].email = dgvImportedPallets.Rows[i].Cells[clmemail.Index].Value.ToString();
                            //pos++;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }

            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmid.Index].Style.ForeColor != Color.Red)
                    dgvImportedPallets.Rows.RemoveAt(i);
            }
            lblImportedPallets.Text = dgvImportedPallets.Rows.Count.ToString();
            //dgvImportedPallets.Rows.Clear();
            //lblImportedPallets.Text = lstNewImporter.Count.ToString();

            //for (int i = 0; i < lstNewImporter.Count; i++)
            //{
            //    dgvImportedPallets.Rows.Add();

            //    int dgvPos = dgvImportedPallets.Rows.Count - 1;

            //    dgvImportedPallets.Rows[dgvPos].Cells[clmType.Index].Value = "P";
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmid.Index].Value = lstImportedPallets[i].id;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmname.Index].Value = lstImportedPallets[i].name;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmcontact.Index].Value = lstImportedPallets[i].contact;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmaddress.Index].Value = lstImportedPallets[i].adress; ;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmcountry.Index].Value = lstImportedPallets[i].country;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmcity.Index].Value = lstImportedPallets[i].city;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmphone1.Index].Value = lstImportedPallets[i].phone1;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmphone2.Index].Value = lstImportedPallets[i].phone2;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmfax.Index].Value = lstImportedPallets[i].fax;
            //    dgvImportedPallets.Rows[dgvPos].Cells[clmemail.Index].Value = lstImportedPallets[i].email;
            //}
            //flgCanBeProcessed = true;

            //for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            //{
            //    string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
            //    string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
            //    string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();

            //    string productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;

            //    clsProduct objProduct = new clsProduct();
            //    objProduct.load(productCode);

            //    if (objProduct.codsec == 0)
            //    {
            //        dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Style.ForeColor = Color.Red;
            //        flgCanBeProcessed = false;
            //    }
            //    else
            //    {
            //        dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Style.ForeColor = Color.Black;
            //    }

            //}
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bool flgValidate = true;
            try
            {
                for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                {
                    int country = 0;

                    int city = 0;
                    clsEntity ObjEntity = new clsEntity();
                    ObjEntity.load(dgvImportedPallets.Rows[i].Cells[clmid.Index].Value.ToString(), string.Empty);
                    clsEntityAddress ObjEntityAddress = new clsEntityAddress();
                    ObjEntityAddress.load(ObjEntity.codsec, string.Empty);
                    if (ObjEntityAddress.codsec == 0)
                    {
                        List<clsCountry> lstCountry = new List<clsCountry>();
                        lstCountry = clsCountry.getList();
                        for (int j = 0; j < lstCountry.Count; j++)
                        {
                            if (dgvImportedPallets.Rows[i].Cells[clmcountry.Index].Value.ToString() == lstCountry[j].name.ToUpper())
                            {
                                country = lstCountry[j].codsec;
                                break;
                            }
                            else
                                country = 65;
                        }

                        List<clsCity> lstCity = new List<clsCity>();
                        lstCity = clsCity.getListByCountry(country);
                        for (int h = 0; h < lstCity.Count; h++)
                        {
                            if (dgvImportedPallets.Rows[i].Cells[clmcity.Index].Value.ToString() == lstCity[h].name.ToUpper())
                            {
                                city = lstCity[h].codsec;
                                break;
                            }
                            else
                                city = 19;
                        }
                        ObjEntityAddress.fkEntity = ObjEntity.codsec;
                        ObjEntityAddress.fkCity = city;
                        ObjEntityAddress.name = ObjEntity.companyName;
                        ObjEntityAddress.contact = ObjEntity.contactName;
                        ObjEntityAddress.address = dgvImportedPallets.Rows[i].Cells[clmaddress.Index].Value.ToString();
                        ObjEntityAddress.phone = dgvImportedPallets.Rows[i].Cells[clmphone1.Index].Value.ToString();
                        ObjEntityAddress.phone2 = dgvImportedPallets.Rows[i].Cells[clmphone2.Index].Value.ToString();
                        ObjEntityAddress.fax = dgvImportedPallets.Rows[i].Cells[clmfax.Index].Value.ToString();
                        ObjEntityAddress.zip = string.Empty;
                        if (!ObjEntityAddress.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                }
                if (flgValidate)
                    MessageBox.Show("Direcciones Agregadas correctamente", "Siigo <> Oben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error", "Siigo <> Oben", MessageBoxButtons.OK, MessageBoxIcon.Error);




                //lstPallet = new List<clsPallet>();
                //if (flgCanBeProcessed)
                //{
                //    for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                //    {
                //        if (dgvImportedPallets.Rows[i].Cells[clmType.Index].Value.ToString() == "P")
                //        {
                //            string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
                //            string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
                //            string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();

                //            string productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;

                //            clsProduct objProduct = new clsProduct();
                //            objProduct.load(productCode);

                //            lstPallet.Add(new clsPallet());

                //            lstPallet[lstPallet.Count - 1].fkProduct = objProduct.codsec;
                //            lstPallet[lstPallet.Count - 1].fkStatus = 38;
                //            lstPallet[lstPallet.Count - 1].palletNumber = 1;
                //            lstPallet[lstPallet.Count - 1].code = dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Value.ToString();
                //            lstPallet[lstPallet.Count - 1].netWeight = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmPalletNetWeight.Index].Value);
                //            lstPallet[lstPallet.Count - 1].grossWeight = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmPalletGrossWeight.Index].Value);
                //            lstPallet[lstPallet.Count - 1].isPrinted = false;
                //            lstPallet[lstPallet.Count - 1].createdBy = clsGlobal.LoggedUser.codsec;
                //            lstPallet[lstPallet.Count - 1].modifiedBy = clsGlobal.LoggedUser.codsec;
                //        }
                //        else
                //        {
                //            string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
                //            string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
                //            string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();

                //            string productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;

                //            clsProduct objProduct = new clsProduct();
                //            objProduct.load(productCode);

                //            lstPallet[lstPallet.Count - 1].lstCoil.Add(new clsCoil());
                //            int lstPos = lstPallet[lstPallet.Count - 1].lstCoil.Count - 1;

                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkCuttingQuality = 1;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkBalance = 8;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkProduct = objProduct.codsec;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkStatus = 33;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].code = dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Value.ToString();
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].length = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmLenght.Index].Value.ToString());
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].width = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString());
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmDiameter.Index].Value.ToString());
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingPosition = 1;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingStop = 1;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmNetWeightCoil.Index].Value.ToString());
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].density = clsCoil.getCoilDensity(lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight, lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter, new clsCore(objProduct.fkCore), objProduct.width);
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].grossWeight = lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight + (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].treatmentSide = "Externo";
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].defects = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].notes = "";
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].createdBy = clsGlobal.LoggedUser.codsec;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].modifiedBy = clsGlobal.LoggedUser.codsec;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].isExternalCoil = true;
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].lotNumber = dgvImportedPallets.Rows[i].Cells[clmLotNumber.Index].Value.ToString();
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].mainCoilCode = dgvImportedPallets.Rows[i].Cells[clmMainCoilCode.Index].Value.ToString().Substring(0, 7) + "-" + dgvImportedPallets.Rows[i].Cells[clmMainCoilCode.Index].Value.ToString().Substring(8, 1);
                //            lstPallet[lstPallet.Count - 1].lstCoil[lstPos].extrusionDate = DateTime.Parse(dgvImportedPallets.Rows[i].Cells[clmExtrusionDate.Index].Value.ToString());
                //        }
                //    }

                //    for (int i = 0; i < lstPallet.Count; i++)
                //    {
                //        clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Stock Perú");

                //        clsPalletType objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(lstPallet[i].lstCoil.Count, Convert.ToInt32(Math.Ceiling((decimal)(lstPallet[i].lstCoil.Count / 2))), "Horizontal");

                //        lstPallet[i].fkPalletType = objPalletType.codsec;
                //        lstPallet[i].fkPalletDimention = 23;

                //        lstPallet[i].save();

                //        for (int j = 0; j < lstPallet[i].lstCoil.Count; j++)
                //        {
                //            lstPallet[i].lstCoil[j].save(objCoilCellar.codsec);

                //            lstPallet[i].addCoilToPallet(lstPallet[i].lstCoil[j].codsec);
                //        }

                //        clsPallet.transferTo(lstPallet[i], objCoilCellar.codsec);
                //        lstPallet[i] = new clsPallet(lstPallet[i].codsec);
                //        lstPallet[i].fkCoilCellar = objCoilCellar.codsec;
                //        clsPallet.transferTo(DateTime.Now, lstPallet[i].code, lstPallet[i].codsec, lstPallet[i].fkCoilCellar, lstPallet[i].product.code, lstPallet[i].palletNumber, lstPallet[i].customerName, lstPallet[i].salesOrderNumber, Convert.ToInt32(lstPallet[i].product.width), Math.Round(lstPallet[i].netWeight, 1), "Ingreso a bodega de stock Perú", true);
                //    }

                //    MessageBox.Show("Se ha realizado la importación de los pallets con éxito.", "Registrro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error en el proceso de importación de pallets, verifique que la información esta validada.\n" + ex.Message, "Registrro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}
