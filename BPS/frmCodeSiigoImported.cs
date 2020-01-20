using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using System.IO;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmCodeSiigoImported : Form
    {
        List<clsImportedPallet> lstImportedPallets = new List<clsImportedPallet>();
        List<string[]> parsedData = new List<string[]>();
        List<clsFilmEquivalence> lstFilmequivalence = new List<clsFilmEquivalence>();
        bool flgCanBeProcessed = false;

        public frmCodeSiigoImported()
        {
            InitializeComponent();
        }
        public void importFromFile()
        {
            parseCSV(txtFileName.Text);

            for (int i = 1; i < parsedData.Count; i++)
            {
                //if (parsedData[i][8] == "0")
                //{
                    lstImportedPallets.Add(new clsImportedPallet());

                    lstImportedPallets[lstImportedPallets.Count - 1].Id = parsedData[i][0];
                    lstImportedPallets[lstImportedPallets.Count - 1].fkBopp = Convert.ToInt32(parsedData[i][1]);
                    lstImportedPallets[lstImportedPallets.Count - 1].fkCast = Convert.ToInt32(parsedData[i][2]);
                    lstImportedPallets[lstImportedPallets.Count - 1].description = parsedData[i][3];
                    lstImportedPallets[lstImportedPallets.Count - 1].codes = parsedData[i][4];
                //}
            }

            dgvImportedPallets.Rows.Clear();

            for (int i = 0; i < lstImportedPallets.Count; i++)
            {
                dgvImportedPallets.Rows.Add();

                int dgvPos = dgvImportedPallets.Rows.Count - 1;

                dgvImportedPallets.Rows[dgvPos].Cells[clmType.Index].Value = "P";
                dgvImportedPallets.Rows[dgvPos].Cells[clmCode.Index].Value = lstImportedPallets[i].Id;
                dgvImportedPallets.Rows[dgvPos].Cells[clmBopp.Index].Value = lstImportedPallets[i].fkBopp;
                dgvImportedPallets.Rows[dgvPos].Cells[clmOpp.Index].Value = lstImportedPallets[i].fkCast;
                dgvImportedPallets.Rows[dgvPos].Cells[clmDescription.Index].Value = lstImportedPallets[i].description;
                dgvImportedPallets.Rows[dgvPos].Cells[clmReference.Index].Value = lstImportedPallets[i].codes;
            }
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
        private void frmCodeSiigoImported_Load(object sender, EventArgs e)
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
            flgCanBeProcessed = true;

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
            try
            {
                lstFilmequivalence = new List<clsFilmEquivalence>();
                if (flgCanBeProcessed)
                {
                    for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
                    {
                        if (dgvImportedPallets.Rows[i].Cells[clmType.Index].Value.ToString() == "P")
                        {
                            lstFilmequivalence.Add(new clsFilmEquivalence());

                            lstFilmequivalence[lstFilmequivalence.Count - 1].fkBopp = Convert.ToInt32(dgvImportedPallets.Rows[i].Cells[clmBopp.Index].Value);
                            lstFilmequivalence[lstFilmequivalence.Count - 1].fkCast = Convert.ToInt32(dgvImportedPallets.Rows[i].Cells[clmOpp.Index].Value);
                            lstFilmequivalence[lstFilmequivalence.Count - 1].Id = dgvImportedPallets.Rows[i].Cells[clmCode.Index].Value.ToString();
                            lstFilmequivalence[lstFilmequivalence.Count - 1].description = dgvImportedPallets.Rows[i].Cells[clmDescription.Index].Value.ToString();
                            lstFilmequivalence[lstFilmequivalence.Count - 1].code = dgvImportedPallets.Rows[i].Cells[clmReference.Index].Value.ToString();
                        }
                    }

                    for (int i = 0; i < lstFilmequivalence.Count; i++)
                        lstFilmequivalence[i].save();

                    MessageBox.Show("Se ha realizado la importación de los pallets con éxito.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error en el proceso de importación de pallets, verifique que la información esta validada. "+ ex.Message, "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}
