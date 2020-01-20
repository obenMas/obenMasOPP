using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BPS.Raw.ProcessR.Aditive
{
    public partial class frmAditive : Form
    {
        clsRawMaterialExtruder rwO = new clsRawMaterialExtruder();

        public frmAditive()
        {
            InitializeComponent();
        }

        private void txtPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getRaw(txtPallet.Text.ToUpper().Trim());
        }

        private void getRaw(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruderAdt(code);

            if (rawOBJ.codsec > 0)
            {
                lblTmP.Text = rawOBJ.MaterialName.ToUpper();
                lblProduct.Text = rawOBJ.MaterialCode.ToUpper();
                lblLot.Text = rawOBJ.lotNumber.ToUpper();
                label3.Text = rawOBJ.bag.ToString();
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                rwO = rawOBJ;
            }
            else
            {
                MessageBox.Show("El pallet ingresado no se puede procesar debido a las siguientes causas :\n El pallet no es un aditivo\n" +
                    " El pallet ya fue procesado con anterioridad \n" +
                    " El código ingresado no corresponde a ningún pallet registrado" +
                    "");

                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var num = clsSequential.SequentialList("extRM");
            var nWeight = rwO.netWeigth / rwO.bag;

            dgvAdt.Rows.Clear();

            for (int i = 0; i < rwO.bag; i++)
            {
                dgvAdt.Rows.Add();
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmm.Index].Value = i + 1;
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmtmp.Index].Value = rwO.MaterialName.ToUpper();
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmproduct.Index].Value = rwO.MaterialCode.ToUpper();
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmbag.Index].Value = 1;
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmlotnumber.Index].Value = rwO.lotNumber;
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmweight.Index].Value = Math.Round(nWeight, 2, MidpointRounding.AwayFromZero).ToString();
                dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmcode.Index].Value = GenerateCode(num + i);
            }

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.BringToFront();
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Visible = true;
            btnProcess.Visible = false;
            btnSave.BringToFront();
            btnSave.Visible = true;
        }

        private string GenerateCode(int num)
        {
            string code = "EXT" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + clsGlobal.FillWithZeros(((num).ToString()), 5);
            return code;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string vcodes = string.Empty;

            if (MessageBox.Show("Esta realmente seguro que desea guardar los datos?", "Aditivos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvAdt.Rows.Count; i++)
                {
                    clsRawMaterialExtruder rwmOBJ = new clsRawMaterialExtruder();
                    rwmOBJ.fkRaw = rwO.fkRaw;
                    rwmOBJ.fkMaterial = rwO.fkMaterial;
                    rwmOBJ.lotNumber = rwO.lotNumber;
                    rwmOBJ.bag = 1;
                    rwmOBJ.code = GenerateCode();
                    rwmOBJ.netWeigth = Convert.ToDouble(dgvAdt.Rows[dgvAdt.Rows.Count - 1].Cells[clmweight.Index].Value);
                    rwmOBJ.isParent = false;
                    rwmOBJ.isSon = true;
                    rwmOBJ.isProcess = false;
                    vcodes += rwmOBJ.code + ";";

                    if (!rwmOBJ.save())
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    if (clsRawMaterialExtruder.setAditive(rwO.codsec.ToString()))
                    {
                        MessageBox.Show("Aditivos ingresados correctamente,\nSe procederá a la impresión de la etiquetas!!");
                        PrintLabes(vcodes);
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso, Error en cambio origen", "Aditivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No se pudo procesar el ingreso, Error en adicionar fracción no se elimina Origen", "Aditivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintLabes(string vcodes)
        {
            var splitCode = vcodes.Split(';');

            foreach (var item in splitCode)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReAdtLabel(item, clsGlobal.password); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                }
            }
        }

        private static string GenerateCode()
        {
            var number = clsSequential.SequentialList("extRM");
            string code = "EXT" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + clsGlobal.FillWithZeros(((number).ToString()), 5);
            clsSequential.addSequential("extRM");
            return code;
        }
    }
}
