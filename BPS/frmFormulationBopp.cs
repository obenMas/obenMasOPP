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
    public partial class frmFormulationBopp : Form
    {
        clsNewFormulation objNewFormulation = new clsNewFormulation();
        List<clsLayer> lstLayer;
        List<TabPage> AllTabPages = new List<TabPage>(); List<TabPage> CompleteTabPages = new List<TabPage>();
        public int selectedRawMaterial = 0; List<int> LstMaterialesAEliminar = new List<int>();
        List<int> lstCapasAReemplazar = new List<int>(6);
        bool editando = false;
        int maquina = 0;
        public frmFormulationBopp()
        {
            InitializeComponent();
            Cargarcmb();
        }

        public frmFormulationBopp(int codsec, bool edit)
        {
            InitializeComponent();
            editando = edit;
            objNewFormulation.load(codsec);
            Cargarcmb();
            InicializarListaEn0();
            if (objNewFormulation.ContarCapas() == 3)
            {
                //HideTabPage(tbpCoExtrusor3);
                //HideTabPage(tbpCoExtrusor4);
                //HideTabPage(tbpCoExtrusor5);
                //p4.Visible = false;
                //p5.Visible = false;
                //p6.Visible = false;
                lstLayer = clsLayer.getListByMachine(3024);
                CargarDatos(objNewFormulation, 3024);
                maquina = 3024;
            }
            if (objNewFormulation.ContarCapas() == 5)
            {
                //HideTabPage(tbpCoExtrusor5);
                //p6.Visible = false;
                lstLayer = clsLayer.getListByMachine(11);
                CargarDatos(objNewFormulation, 11);
                maquina = 11;
            }

        }

        private void frmFormulationBopp_Load(object sender, EventArgs e)
        {
            dgvCapaCentral.Rows[0].Cells[clmEliminarCC.Index].Value = global::BPS.Properties.Resources.cross;
            dgvCE1.Rows[0].Cells[clmEliminarCE1.Index].Value = global::BPS.Properties.Resources.cross;
            dgvCE2.Rows[0].Cells[clmEliminarCE2.Index].Value = global::BPS.Properties.Resources.cross;
            dgvCE3.Rows[0].Cells[clmEliminarCE3.Index].Value = global::BPS.Properties.Resources.cross;
            dgvCE4.Rows[0].Cells[clmEliminarCE4.Index].Value = global::BPS.Properties.Resources.cross;
            dgvCE5.Rows[0].Cells[clmEliminarCE5.Index].Value = global::BPS.Properties.Resources.cross;
            LoadTabPages();
        }

        public void Cargarcmb()
        {
            List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
            cmbBoppFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbBoppFilm.Items.Add(lstBopp[i]);

            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();
            cmbMaquina.Items.Clear();
            for (int i = 0; i < lstMachine.Count; i++)
                cmbMaquina.Items.Add(lstMachine[i]);
        }

        public void InicializarListaEn0()
        {
            for (int i = 0; i < 6; i++)
                lstCapasAReemplazar.Add(0);
        }
        public void HideTabPage(TabPage tb)
        {
            if (tabControl1.Contains(tb))
            {
                foreach (TabPage t in tabControl1.TabPages)
                {
                    if (!AllTabPages.Contains(t))
                        AllTabPages.Add(t);
                }
                tabControl1.Controls.Remove(tb);
            }
        }
        public void ShowTabPage()
        {
            AllTabPages = new List<TabPage>();
            foreach (TabPage t in tabControl1.TabPages)
            {
                AllTabPages.Add(t);
                tabControl1.Controls.Remove(t);
            }
            for (int i = 0; i < CompleteTabPages.Count; i++)
                tabControl1.Controls.Add(CompleteTabPages[i]);
            //for (int i = 0; i < AllTabPages.Count; i++)
            //    tabControl1.Controls.Add(AllTabPages[i]);
        }
        public void LoadTabPages()
        {
            foreach (TabPage t in tabControl1.TabPages)
                CompleteTabPages.Add(t);
        }
        #region Estetico
        public void ReiniciarColores()
        {
            pCC.BackColor = Color.LightGray;
            pCE1.BackColor = Color.LightGray;
            pCE2.BackColor = Color.LightGray;
            pCE3.BackColor = Color.LightGray;
            pCE4.BackColor = Color.LightGray;
            pCE5.BackColor = Color.LightGray;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    ReiniciarColores();
                    pCC.BackColor = Color.LimeGreen;
                    break;
                case 1:
                    ReiniciarColores();
                    pCE1.BackColor = Color.LimeGreen;
                    break;
                case 2:
                    ReiniciarColores();
                    pCE2.BackColor = Color.LimeGreen;
                    break;
                case 3:
                    ReiniciarColores();
                    pCE3.BackColor = Color.LimeGreen;
                    break;
                case 4:
                    ReiniciarColores();
                    pCE4.BackColor = Color.LimeGreen;
                    break;
                case 5:
                    ReiniciarColores();
                    pCE5.BackColor = Color.LimeGreen;
                    break;
            }
        }

        public void Recalcular()
        {
            txtEspesor.Text = "0";
            if (txtEspesorCC.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCC.Text) + float.Parse(txtEspesor.Text));
            if (txtEspesorCE1.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCE1.Text) + float.Parse(txtEspesor.Text));
            if (txtEspesorCE2.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCE2.Text) + float.Parse(txtEspesor.Text));
            if (txtEspesorCE3.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCE3.Text) + float.Parse(txtEspesor.Text));
            if (txtEspesorCE4.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCE4.Text) + float.Parse(txtEspesor.Text));
            if (txtEspesorCE5.Text != "")
                txtEspesor.Text = Convert.ToString(float.Parse(txtEspesorCE5.Text) + float.Parse(txtEspesor.Text));
            txtEspesor.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtEspesor.Text), 2));
        }

        public void ChequearFilas(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
                if(dgv.Rows[i].Cells[3].Value!=null)
                {
                    if (dgv.Rows[i].Cells[6].Value == null)
                        dgv.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    else
                        dgv.Rows[i].Cells[6].Style.BackColor = Color.White;
                }
        }

        public void ControlarPorcentaje(DataGridView dgv)
        {
            double subtotal = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                subtotal += Convert.ToDouble(dgv.Rows[i].Cells[6].Value);
                if (subtotal!=100)
                    dgv.Columns[6].HeaderCell.Style.BackColor = Color.Red;
                else
                    dgv.Columns[6].HeaderCell.Style.BackColor = SystemColors.Control;
            }
        }

        public bool Validar()
        {
            bool bandera = true;
            if (!ChequearTxt())
                bandera = false;
            if (!ChequearPorcentajeTotal())
                bandera = false;
            if (!ChequearMaterial())
                bandera = false;
            if (!ControlarPorcentajeSinMaterial())
                bandera = false;
            if (!ControlarFilasSinCompletar())
                bandera = false;
            if (cmbBoppFilm.SelectedIndex == -1)
            {
                bandera = false;
                lblPelicula.ForeColor = Color.Red;
            }
            if (cmbMaquina.SelectedIndex == -1)
            {
                bandera = false;
                lblMaquina.ForeColor = Color.Red;
            }

            return bandera;
        }
        public bool ChequearTxt()
        {
            bool bandera = true;
            if (maquina == 3024)
            {
                if (txtEspesorCC.Text == "0")
                {
                    bandera = false;
                    txtEspesorCC.BackColor = Color.Red;
                }
                if (txtEspesorCE1.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE1.BackColor = Color.Red;
                }
                if (txtEspesorCE2.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE2.BackColor = Color.Red;
                }
            }
            if (maquina == 11)
            {
                if (txtEspesorCC.Text == "0")
                {
                    bandera = false;
                    txtEspesorCC.BackColor = Color.Red;
                }
                if (txtEspesorCE1.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE1.BackColor = Color.Red;
                }
                if (txtEspesorCE2.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE2.BackColor = Color.Red;
                }
                if (txtEspesorCE3.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE3.BackColor = Color.Red;
                }
                if (txtEspesorCE4.Text == "0")
                {
                    bandera = false;
                    txtEspesorCE4.BackColor = Color.Red;
                }
            }
            if (txtNombre.Text == string.Empty)
            {
                bandera = false;
                txtNombre.BackColor = Color.Red;
            }
            return bandera;
        }
        public bool ChequearPorcentajeTotal()
        {
            bool bandera = true;
            double subtotal = 0;
            if (maquina == 3024)
            {
                for (int i = 0; i < dgvCapaCentral.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCapaCentral.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal,2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE1.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE1.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE2.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE2.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
            }
            if (maquina == 11)
            {
                for (int i = 0; i < dgvCapaCentral.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCapaCentral.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE1.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE1.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE2.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE2.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE3.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE3.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
                subtotal = 0;

                for (int i = 0; i < dgvCE4.Rows.Count - 1; i++)
                    subtotal += Convert.ToDouble(dgvCE4.Rows[i].Cells[6].Value);
                if (Math.Round(subtotal, 2) != 100)
                    bandera = false;
            }
            return bandera;
        }
        public bool ControlarPorcentajeSinMaterial()
        {
            bool bandera = true;
            if(maquina==3024)
            {
                if (!ChequearFilaVaciaConPorcentaje(dgvCapaCentral))
                    bandera = false;
            }
            return bandera;
        }
        public bool ChequearFilaVaciaConPorcentaje(DataGridView dgv)
        {
            bool bandera = true;
            for (int i = 0; i<dgv.Rows.Count; i++)
            {
                if(dgv.Rows[i].Cells[6].Value!=null && dgv.Rows[i].Cells[3].Value==null)
                {
                    dgv.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    bandera = false;
                }
            }
            if (bandera == false)
                MessageBox.Show("Hay un porcentaje que no posee material, por favor seleccione uno o eliminelo", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return bandera;
        }
        public bool ControlarFilasSinCompletar()
        {
            bool bandera = true;
            if(maquina==3024)
            {
                for (int i = 0; i < dgvCapaCentral.Rows.Count; i++)
                    if (dgvCapaCentral.Rows[i].Cells[6].Value == null && dgvCapaCentral.Rows[i].Cells[3].Value!=null)
                        bandera = false;
                for (int i = 0; i < dgvCE1.Rows.Count; i++)
                    if (dgvCE1.Rows[i].Cells[6].Value == null && dgvCE1.Rows[i].Cells[3].Value != null)
                        bandera = false;
                for (int i = 0; i < dgvCE2.Rows.Count; i++)
                    if (dgvCE2.Rows[i].Cells[6].Value == null && dgvCE2.Rows[i].Cells[3].Value != null)
                        bandera = false;
            }
            if(maquina==11)
            {
                for (int i = 0; i < dgvCapaCentral.Rows.Count-1; i++)
                    if (dgvCapaCentral.Rows[i].Cells[6].Value == null && dgvCapaCentral.Rows[i].Cells[3].Value != null)
                        bandera = false;
                for (int i = 0; i < dgvCE1.Rows.Count-1; i++)
                    if (dgvCE1.Rows[i].Cells[6].Value == null && dgvCE1.Rows[i].Cells[3].Value != null)
                        bandera = false;
                for (int i = 0; i < dgvCE2.Rows.Count-1; i++)
                    if (dgvCE2.Rows[i].Cells[6].Value == null && dgvCE2.Rows[i].Cells[3].Value != null)
                        bandera = false;
                for (int i = 0; i < dgvCE3.Rows.Count-1; i++)
                    if (dgvCE3.Rows[i].Cells[6].Value == null && dgvCE3.Rows[i].Cells[3].Value != null)
                        bandera = false;
                for (int i = 0; i < dgvCE4.Rows.Count-1; i++)
                    if (dgvCE4.Rows[i].Cells[6].Value == null && dgvCE4.Rows[i].Cells[3].Value != null)
                        bandera = false;
            }
            return bandera;
        }
        #endregion

        #region CapaCentral
        private void dgvCapaCentral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1=Convert.ToInt32(dgvCapaCentral.CurrentRow.Cells[codsecCC.Index].Value);
                    dgvCapaCentral.CurrentRow.Cells[codsecCC.Index].Value = codsec1;
                    dgvCapaCentral.CurrentRow.Cells[clmfkRawMaterialCC.Index].Value = objRawMaterial.codsec;
                    dgvCapaCentral.CurrentRow.Cells[clmNombreCC.Index].Value = objRawMaterial.name;
                    dgvCapaCentral.CurrentRow.Cells[clmMateriaPrimaCC.Index].Value = objRawMaterial.code;
                    dgvCapaCentral.CurrentRow.Cells[clmTipoCC.Index].Value = objRawMaterial.RawMaterialtypeName;
                    dgvCapaCentral.CurrentRow.Cells[clmEliminarCC.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
            ChequearFilas(dgvCapaCentral);
            if(dgvCapaCentral.Rows.Count-1!=0)
                ControlarPorcentaje(dgvCapaCentral);
        }

        private void dgvCapaCentral_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCapaCentral.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvCapaCentral_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCapaCentral.CurrentRow.Cells[6].Value != null)
                dgvCapaCentral.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCapaCentral.CurrentRow.Cells[6].Value == null && dgvCapaCentral.CurrentRow.Cells[3].Value == null)
                dgvCapaCentral.Rows.Remove(dgvCapaCentral.CurrentRow);
            else
                dgvCapaCentral.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCapaCentral);
            ChequearFilaVaciaConPorcentaje(dgvCapaCentral);
        }

        private void dgvCapaCentral_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCapaCentral.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCapaCentral_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCapaCentral.Rows[dgvCapaCentral.Rows.Count - 1].Cells[clmEliminarCC.Index].Tag == null)
                dgvCapaCentral.Rows[dgvCapaCentral.Rows.Count - 1].Cells[clmEliminarCC.Index].Value = global::BPS.Properties.Resources.cross;
        }
        #endregion

        #region CE1
        private void dgvCE1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1 = Convert.ToInt32(dgvCE1.CurrentRow.Cells[codsecCE1.Index].Value);
                    dgvCE1.CurrentRow.Cells[codsecCE1.Index].Value = codsec1;
                    dgvCE1.CurrentRow.Cells[clmfkRawMaterialCE1.Index].Value = objRawMaterial.codsec;
                    dgvCE1.CurrentRow.Cells[clmNombreCE1.Index].Value = objRawMaterial.name;
                    dgvCE1.CurrentRow.Cells[clmMateriaPrimaCE1.Index].Value = objRawMaterial.code;
                    dgvCE1.CurrentRow.Cells[clmTipoCE1.Index].Value = objRawMaterial.RawMaterialtypeName;
                }
            }
            ChequearFilas(dgvCE1);
            if(dgvCE1.Rows.Count-1!=0)
            ControlarPorcentaje(dgvCE1);
        }

        private void dgvCE1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCE1.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCE1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCE1.CurrentRow.Cells[6].Value != null)
                dgvCE1.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCE1.CurrentRow.Cells[6].Value == null && dgvCE1.CurrentRow.Cells[3].Value == null)
                dgvCE1.Rows.Remove(dgvCE1.CurrentRow);
            else
                dgvCE1.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCE1);
            ChequearFilaVaciaConPorcentaje(dgvCE1);
        }

        private void dgvCE1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCE1.CancelEdit();
                    }
                    break;
            }
        }
        #endregion

        #region CE2
        private void dgvCE2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1 = Convert.ToInt32(dgvCE2.CurrentRow.Cells[codsecCE2.Index].Value);
                    dgvCE2.CurrentRow.Cells[codsecCE2.Index].Value = codsec1;
                    dgvCE2.CurrentRow.Cells[clmfkRawMaterialCE2.Index].Value = objRawMaterial.codsec;
                    dgvCE2.CurrentRow.Cells[clmNombreCE2.Index].Value = objRawMaterial.name;
                    dgvCE2.CurrentRow.Cells[clmMateriaPrimaCE2.Index].Value = objRawMaterial.code;
                    dgvCE2.CurrentRow.Cells[clmTipoCE2.Index].Value = objRawMaterial.RawMaterialtypeName;
                }
            }
            ChequearFilas(dgvCE2);
            if(dgvCE2.Rows.Count-1!=0)
            ControlarPorcentaje(dgvCE2);
        }

        private void dgvCE2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCE2.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCE2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCE2.CurrentRow.Cells[6].Value != null)
                dgvCE2.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCE2.CurrentRow.Cells[6].Value == null && dgvCE2.CurrentRow.Cells[3].Value == null)
                dgvCE2.Rows.Remove(dgvCE2.CurrentRow);
            else
                dgvCE2.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCE2);
            ChequearFilaVaciaConPorcentaje(dgvCE2);
        }

        private void dgvCE2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCE2.CancelEdit();
                    }
                    break;
            }
        }
        #endregion

        #region CE3
        private void dgvCE3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1 = Convert.ToInt32(dgvCE3.CurrentRow.Cells[codsecCE3.Index].Value);
                    dgvCE3.CurrentRow.Cells[codsecCE3.Index].Value = codsec1;
                    dgvCE3.CurrentRow.Cells[clmfkRawMaterialCE3.Index].Value = objRawMaterial.codsec;
                    dgvCE3.CurrentRow.Cells[clmNombreCE3.Index].Value = objRawMaterial.name;
                    dgvCE3.CurrentRow.Cells[clmMateriaPrimaCE3.Index].Value = objRawMaterial.code;
                    dgvCE3.CurrentRow.Cells[clmTipoCE3.Index].Value = objRawMaterial.RawMaterialtypeName;
                }
            }
            ChequearFilas(dgvCE3);
            if(dgvCE3.Rows.Count-1!=0)
            ControlarPorcentaje(dgvCE3);
        }

        private void dgvCE3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCE3.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCE3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCE3.CurrentRow.Cells[6].Value != null)
                dgvCE3.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCE3.CurrentRow.Cells[6].Value == null && dgvCE3.CurrentRow.Cells[3].Value == null)
                dgvCE3.Rows.Remove(dgvCE3.CurrentRow);
            else
                dgvCE3.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCE3);
            ChequearFilaVaciaConPorcentaje(dgvCE3);
        }

        private void dgvCE3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCE3.CancelEdit();
                    }
                    break;
            }
        }
        #endregion

        #region CE4
        private void dgvCE4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1 = Convert.ToInt32(dgvCE4.CurrentRow.Cells[codsecCE4.Index].Value);
                    dgvCE4.CurrentRow.Cells[codsecCE4.Index].Value = codsec1;
                    dgvCE4.CurrentRow.Cells[clmfkRawMaterialCE4.Index].Value = objRawMaterial.codsec;
                    dgvCE4.CurrentRow.Cells[clmNombreCE4.Index].Value = objRawMaterial.name;
                    dgvCE4.CurrentRow.Cells[clmMateriaPrimaCE4.Index].Value = objRawMaterial.code;
                    dgvCE4.CurrentRow.Cells[clmTipoCE4.Index].Value = objRawMaterial.RawMaterialtypeName;
                }
            }
            ChequearFilas(dgvCE4);
            if(dgvCE4.Rows.Count-1!=0)
            ControlarPorcentaje(dgvCE4);
        }

        private void dgvCE4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCE4.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCE4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCE4.CurrentRow.Cells[6].Value != null)
                dgvCE4.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCE4.CurrentRow.Cells[6].Value == null && dgvCE4.CurrentRow.Cells[3].Value == null)
                dgvCE4.Rows.Remove(dgvCE4.CurrentRow);
            else
                dgvCE4.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCE4);
            ChequearFilaVaciaConPorcentaje(dgvCE4);
        }

        private void dgvCE4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCE4.CancelEdit();
                    }
                    break;
            }
        }
        #endregion

        #region CE5
        private void dgvCE5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    int codsec1 = Convert.ToInt32(dgvCE5.CurrentRow.Cells[codsecCE5.Index].Value);
                    dgvCE5.CurrentRow.Cells[codsecCE5.Index].Value = codsec1;
                    dgvCE5.CurrentRow.Cells[clmfkRawMaterialCE5.Index].Value = objRawMaterial.codsec;
                    dgvCE5.CurrentRow.Cells[clmNombreCE5.Index].Value = objRawMaterial.name;
                    dgvCE5.CurrentRow.Cells[clmMateriaPrimaCE5.Index].Value = objRawMaterial.code;
                    dgvCE5.CurrentRow.Cells[clmTipoCE5.Index].Value = objRawMaterial.RawMaterialtypeName;
                }
            }
            ChequearFilas(dgvCE5);
            if(dgvCE5.Rows.Count-1!=0)
            ControlarPorcentaje(dgvCE5);
        }

        private void dgvCE5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCE5.CurrentRow.Cells[6].Style.BackColor = Color.White;
        }

        private void dgvCE5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCE5.CurrentRow.Cells[6].Value != null)
                dgvCE5.CurrentRow.Cells[6].Style.BackColor = Color.White;
            else if (dgvCE5.CurrentRow.Cells[6].Value == null && dgvCE5.CurrentRow.Cells[3].Value == null)
                dgvCE5.Rows.Remove(dgvCE5.CurrentRow);
            else
                dgvCE5.CurrentRow.Cells[6].Style.BackColor = Color.Red;
            ControlarPorcentaje(dgvCE5);
            ChequearFilaVaciaConPorcentaje(dgvCE5);
        }

        private void dgvCE5_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCE5.CancelEdit();
                    }
                    break;
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                objNewFormulation.Name = txtNombre.Text;
                objNewFormulation.Description = txtDescripcion.Text;
                objNewFormulation.Thickness = float.Parse(txtEspesor.Text);
                objNewFormulation.fkBopp = ((clsBopp)cmbBoppFilm.SelectedItem).codsec;
                objNewFormulation.fkMachine = maquina;
                if (cbEstandar.Checked == true)
                {
                    if (objNewFormulation.CheckStandar(objNewFormulation.fkBopp,maquina))
                    {
                        if (objNewFormulation.GetCodsecStandar(objNewFormulation.fkBopp,maquina) != objNewFormulation.Codsec)
                            if (MessageBox.Show("Ya existe una formulación estandar de esta pelicula, ¿Desea establecer esta como estandar?", "Formulaciones", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                clsNewFormulation.EstablecerNoEstandar(objNewFormulation.fkBopp,maquina);
                                objNewFormulation.isStandar = true;
                            }
                    }
                    else
                        objNewFormulation.isStandar = true;
                }
                else
                    objNewFormulation.isStandar = cbEstandar.Checked;

                #region Carga objNewFormulation
                if (editando == true)
                {
                    objNewFormulation.lstLayerThickByNewFormulation.Clear();
                    objNewFormulation.lstNewFormulationDetail.Clear();
                }
                if (dgvCapaCentral.Rows.Count-1>0)
                {
                    if (editando == true && lstCapasAReemplazar[0]!=0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[0]));
                    else
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCapaCentral.Rows[0].Cells[clmLayerCodsecCC.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[0].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCC.Text);
                    for (int i = 0; i < dgvCapaCentral.Rows.Count - 1; i++)
                    {
                        if(Convert.ToInt32(dgvCapaCentral.Rows[i].Cells[clmfkRawMaterialCC.Index].Value)!=0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCapaCentral.Rows[i].Cells[codsecCC.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[0].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCapaCentral.Rows[i].Cells[clmfkRawMaterialCC.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCapaCentral.Rows[i].Cells[clmPorcentajeCC.Index].Value.ToString());
                        }
                    }
                }
                if (dgvCE1.Rows.Count-1 > 0)
                {
                    if (editando == true && lstCapasAReemplazar[1] != 0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[1]));
                    else
                    objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCE1.Rows[0].Cells[clmLayerCodsecCE1.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[1].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCE1.Text);
                    for (int i = 0; i < dgvCE1.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvCE1.Rows[i].Cells[clmfkRawMaterialCE1.Index].Value) != 0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCE1.Rows[i].Cells[codsecCE1.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[1].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCE1.Rows[i].Cells[clmfkRawMaterialCE1.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCE1.Rows[i].Cells[clmPorcentajeCE1.Index].Value.ToString());
                        }
                    }
                }
                if (dgvCE2.Rows.Count-1 > 0)
                {
                    if (editando == true && lstCapasAReemplazar[2] != 0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[2]));
                    else
                    objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCE2.Rows[0].Cells[clmLayerCodsecCE2.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[2].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCE2.Text);
                    for (int i = 0; i < dgvCE2.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvCE2.Rows[i].Cells[clmfkRawMaterialCE2.Index].Value) != 0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCE2.Rows[i].Cells[codsecCE2.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[2].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCE2.Rows[i].Cells[clmfkRawMaterialCE2.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCE2.Rows[i].Cells[clmPorcentajeCE2.Index].Value.ToString());
                        }
                    }
                }
                if (dgvCE3.Rows.Count-1 > 0)
                {
                    if (editando == true && lstCapasAReemplazar[3] != 0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[3]));
                    else
                    objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCE3.Rows[0].Cells[clmLayerCodsecCE3.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[3].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCE3.Text);
                    for (int i = 0; i < dgvCE3.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvCE3.Rows[i].Cells[clmfkRawMaterialCE3.Index].Value) != 0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCE3.Rows[i].Cells[codsecCE3.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[3].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCE3.Rows[i].Cells[clmfkRawMaterialCE3.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCE3.Rows[i].Cells[clmPorcentajeCE3.Index].Value.ToString());
                        }
                    }
                }
                if (dgvCE4.Rows.Count-1 > 0)
                {
                    if (editando == true && lstCapasAReemplazar[4] != 0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[4]));
                    else
                    objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCE4.Rows[0].Cells[clmLayerCodsecCE4.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[4].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCE4.Text);
                    for (int i = 0; i < dgvCE4.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvCE4.Rows[i].Cells[clmfkRawMaterialCE4.Index].Value) != 0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCE4.Rows[i].Cells[codsecCE4.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[4].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCE4.Rows[i].Cells[clmfkRawMaterialCE4.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCE4.Rows[i].Cells[clmPorcentajeCE4.Index].Value.ToString());
                        }
                    }
                }
                if (dgvCE5.Rows.Count-1 > 0)
                {
                    if (editando == true && lstCapasAReemplazar[5] != 0)
                        objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(lstCapasAReemplazar[5]));
                    else
                    objNewFormulation.lstLayerThickByNewFormulation.Add(new clsLayerThickByNewFormulation(Convert.ToInt32(dgvCE5.Rows[0].Cells[clmLayerCodsecCE5.Index].Value)));
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].fkLayer = lstLayer[5].codsec;
                    objNewFormulation.lstLayerThickByNewFormulation[objNewFormulation.lstLayerThickByNewFormulation.Count - 1].Thickness = float.Parse(txtEspesorCE5.Text);
                    for (int i = 0; i < dgvCE5.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvCE5.Rows[i].Cells[clmfkRawMaterialCE5.Index].Value) != 0)
                        {
                            objNewFormulation.lstNewFormulationDetail.Add(new clsNewFormulationDetail(Convert.ToInt32(dgvCE5.Rows[i].Cells[codsecCE5.Index].Value)));
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkLayer = lstLayer[5].codsec;
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCE5.Rows[i].Cells[clmfkRawMaterialCE5.Index].Value);
                            objNewFormulation.lstNewFormulationDetail[objNewFormulation.lstNewFormulationDetail.Count - 1].Percentage = float.Parse(dgvCE5.Rows[i].Cells[clmPorcentajeCE5.Index].Value.ToString());
                        }
                    }
                }
                #endregion
                if (LstMaterialesAEliminar.Count > 0)
                    for (int i = 0; i < LstMaterialesAEliminar.Count; i++)
                        clsNewFormulationDetail.Delete(LstMaterialesAEliminar[i]);
                    if (objNewFormulation.save())
                    {
                        MessageBox.Show("La formulación se ha guardado con éxito", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error al guardar la formulación", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los errores pueden ser los siguientes:\n-La suma de los porcentajes debe ser igual a 100 \n-Los espesores deben ser mayor a 0\n-Debe de haber como minimo un material por capa\n-Hay un material sin porcentaje", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public bool ChequearMaterial()
        {
            bool bandera = true;
            if(maquina==3024)
            {
                if (dgvCapaCentral.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE1.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE2.Rows.Count - 1 == 0)
                    bandera = false;
            }
            if(maquina==11)
            {
                if (dgvCapaCentral.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE1.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE2.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE3.Rows.Count - 1 == 0)
                    bandera = false;
                if (dgvCE4.Rows.Count - 1 == 0)
                    bandera = false;
            }
            return bandera;
        }

        public int ControlarFilaVaciaDGV(DataGridView dgv)
        {
            if (dgv.Rows[dgv.Rows.Count - 1].Cells[2].Value != null)
                return dgv.Rows.Count;
            else
                return dgv.Rows.Count-1;
        }

        private void txtEspesorCC_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCC.Text.ToString()) == false && txtEspesorCC.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCC.Text = "0";
            }
            else if (txtEspesorCC.Text == string.Empty)
                txtEspesorCC.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE1_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCE1.Text) == false && txtEspesorCE1.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCE1.Text = "0";
            }
            else if (txtEspesorCE1.Text == string.Empty)
                txtEspesorCE1.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE2_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCE2.Text) == false && txtEspesorCE2.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCE2.Text = "0";
            }
            else if (txtEspesorCE2.Text == string.Empty)
                txtEspesorCE2.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE3_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCE3.Text) == false && txtEspesorCE3.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCE3.Text = "0";
            }
            else if (txtEspesorCE3.Text == string.Empty)
                txtEspesorCE3.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE4_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCE4.Text) == false && txtEspesorCE4.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCE4.Text = "0";
            }
            else if (txtEspesorCE4.Text == string.Empty)
                txtEspesorCE4.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE5_Leave(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtEspesorCE5.Text) == false && txtEspesorCE5.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtEspesorCE5.Text = "0";
            }
            else if (txtEspesorCE5.Text == string.Empty)
                txtEspesorCE5.Text = "0";
            Recalcular();
        }

        private void txtEspesorCE2_MouseClick(object sender, MouseEventArgs e)
        {
            txtEspesorCE2.BackColor = Color.White;
        }

        private void txtEspesorCC_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCC.BackColor = Color.White;
        }

        private void txtEspesorCE1_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCE1.BackColor = Color.White;
        }

        private void txtEspesorCE2_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCE2.BackColor = Color.White;
        }

        private void txtEspesorCE3_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCE3.BackColor = Color.White;
        }

        private void txtEspesorCE5_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCE5.BackColor = Color.White;
        }

        private void txtEspesorCE4_MouseEnter(object sender, EventArgs e)
        {
            txtEspesorCE4.BackColor = Color.White;
        }

        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void cmbBoppFilm_MouseEnter(object sender, EventArgs e)
        {
            lblPelicula.ForeColor=SystemColors.ControlText;
        }

        public void CargarDatos(clsNewFormulation obj, int machine)
        {
            if(machine==3024)
            {
                dgvCapaCentral.AllowUserToAddRows = false;
                dgvCE1.AllowUserToAddRows = false;
                dgvCE2.AllowUserToAddRows = false;
                for (int i = 0;i< cmbBoppFilm.Items.Count; i++)
                    if (((clsBopp)cmbBoppFilm.Items[i]).codsec == obj.fkBopp)
                        cmbBoppFilm.SelectedIndex = i;
                for (int i = 0; i < cmbMaquina.Items.Count; i++)
                    if (((clsMachine)cmbMaquina.Items[i]).codsec == obj.fkMachine)
                        cmbMaquina.SelectedIndex = i;
                txtNombre.Text = obj.Name;
                txtDescripcion.Text = obj.Description;
                cbEstandar.Checked = obj.isStandar;
                txtEspesor.Text = obj.Thickness.ToString();
                txtEspesorCC.Text = obj.lstLayerThickByNewFormulation[0].Thickness.ToString();
                txtEspesorCE1.Text = obj.lstLayerThickByNewFormulation[1].Thickness.ToString();
                txtEspesorCE2.Text = obj.lstLayerThickByNewFormulation[2].Thickness.ToString();
                for(int i=0;i<obj.lstNewFormulationDetail.Count;i++)
                {
                    clsRawMaterial objRawMaterial = new clsRawMaterial(obj.lstNewFormulationDetail[i].fkRawMaterial);
                    if(obj.lstNewFormulationDetail[i].fkLayer==2)
                    {
                        dgvCapaCentral.Rows.Add();
                        int fila = dgvCapaCentral.Rows.Count-1;
                        dgvCapaCentral.Rows[fila].Cells[codsecCC.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmLayerCodsecCC.Index].Value = obj.lstLayerThickByNewFormulation[0].Codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmfkRawMaterialCC.Index].Value = objRawMaterial.codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmNombreCC.Index].Value = objRawMaterial.name;
                        dgvCapaCentral.Rows[fila].Cells[clmMateriaPrimaCC.Index].Value = objRawMaterial.code;
                        dgvCapaCentral.Rows[fila].Cells[clmTipoCC.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCapaCentral.Rows[fila].Cells[clmPorcentajeCC.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer==1)
                    {
                        dgvCE1.Rows.Add();
                        int fila = dgvCE1.Rows.Count - 1;
                        dgvCE1.Rows[fila].Cells[codsecCE1.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE1.Rows[fila].Cells[clmLayerCodsecCE1.Index].Value = obj.lstLayerThickByNewFormulation[1].Codsec;
                        dgvCE1.Rows[fila].Cells[clmfkRawMaterialCE1.Index].Value = objRawMaterial.codsec;
                        dgvCE1.Rows[fila].Cells[clmNombreCE1.Index].Value = objRawMaterial.name;
                        dgvCE1.Rows[fila].Cells[clmMateriaPrimaCE1.Index].Value = objRawMaterial.code;
                        dgvCE1.Rows[fila].Cells[clmTipoCE1.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE1.Rows[fila].Cells[clmPorcentajeCE1.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer==3)
                    {
                        dgvCE2.Rows.Add();
                        int fila = dgvCE2.Rows.Count - 1;
                        dgvCE2.Rows[fila].Cells[codsecCE2.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE2.Rows[fila].Cells[clmLayerCodsecCE2.Index].Value = obj.lstLayerThickByNewFormulation[2].Codsec;
                        dgvCE2.Rows[fila].Cells[clmfkRawMaterialCE2.Index].Value = objRawMaterial.codsec;
                        dgvCE2.Rows[fila].Cells[clmNombreCE2.Index].Value = objRawMaterial.name;
                        dgvCE2.Rows[fila].Cells[clmMateriaPrimaCE2.Index].Value = objRawMaterial.code;
                        dgvCE2.Rows[fila].Cells[clmTipoCE2.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE2.Rows[fila].Cells[clmPorcentajeCE2.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                }
                dgvCapaCentral.AllowUserToAddRows = true;
                dgvCE1.AllowUserToAddRows = true;
                dgvCE2.AllowUserToAddRows = true;
            }
            if(machine==11)
            {
                dgvCapaCentral.AllowUserToAddRows = false;
                dgvCE1.AllowUserToAddRows = false;
                dgvCE2.AllowUserToAddRows = false;
                dgvCE3.AllowUserToAddRows = false;
                dgvCE4.AllowUserToAddRows = false;
                for (int i = 0; i < cmbBoppFilm.Items.Count; i++)
                    if (((clsBopp)cmbBoppFilm.Items[i]).codsec == obj.fkBopp)
                        cmbBoppFilm.SelectedIndex = i;
                for (int i = 0; i < cmbMaquina.Items.Count; i++)
                    if (((clsMachine)cmbMaquina.Items[i]).codsec == obj.fkMachine)
                        cmbMaquina.SelectedIndex = i;
                txtNombre.Text = obj.Name;
                txtDescripcion.Text = obj.Description;
                cbEstandar.Checked = obj.isStandar;
                txtEspesor.Text = obj.Thickness.ToString();
                txtEspesorCC.Text = obj.lstLayerThickByNewFormulation[0].Thickness.ToString();
                txtEspesorCE1.Text = obj.lstLayerThickByNewFormulation[1].Thickness.ToString();
                txtEspesorCE2.Text = obj.lstLayerThickByNewFormulation[2].Thickness.ToString();
                txtEspesorCE3.Text = obj.lstLayerThickByNewFormulation[3].Thickness.ToString();
                txtEspesorCE4.Text = obj.lstLayerThickByNewFormulation[4].Thickness.ToString();
                for (int i = 0; i < obj.lstNewFormulationDetail.Count; i++)
                {
                    clsRawMaterial objRawMaterial = new clsRawMaterial(obj.lstNewFormulationDetail[i].fkRawMaterial);
                    if (obj.lstNewFormulationDetail[i].fkLayer == 6)
                    {
                        dgvCapaCentral.Rows.Add();
                        int fila = dgvCapaCentral.Rows.Count - 1;
                        dgvCapaCentral.Rows[fila].Cells[codsecCC.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmLayerCodsecCC.Index].Value = obj.lstLayerThickByNewFormulation[0].Codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmfkRawMaterialCC.Index].Value = objRawMaterial.codsec;
                        dgvCapaCentral.Rows[fila].Cells[clmNombreCC.Index].Value = objRawMaterial.name;
                        dgvCapaCentral.Rows[fila].Cells[clmMateriaPrimaCC.Index].Value = objRawMaterial.code;
                        dgvCapaCentral.Rows[fila].Cells[clmTipoCC.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCapaCentral.Rows[fila].Cells[clmPorcentajeCC.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer == 4)
                    {
                        dgvCE1.Rows.Add();
                        int fila = dgvCE1.Rows.Count - 1;
                        dgvCE1.Rows[fila].Cells[codsecCE1.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE1.Rows[fila].Cells[clmLayerCodsecCE1.Index].Value = obj.lstLayerThickByNewFormulation[1].Codsec;
                        dgvCE1.Rows[fila].Cells[clmfkRawMaterialCE1.Index].Value = objRawMaterial.codsec;
                        dgvCE1.Rows[fila].Cells[clmNombreCE1.Index].Value = objRawMaterial.name;
                        dgvCE1.Rows[fila].Cells[clmMateriaPrimaCE1.Index].Value = objRawMaterial.code;
                        dgvCE1.Rows[fila].Cells[clmTipoCE1.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE1.Rows[fila].Cells[clmPorcentajeCE1.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer == 5)
                    {
                        dgvCE2.Rows.Add();
                        int fila = dgvCE2.Rows.Count - 1;
                        dgvCE2.Rows[fila].Cells[codsecCE2.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE2.Rows[fila].Cells[clmLayerCodsecCE2.Index].Value = obj.lstLayerThickByNewFormulation[2].Codsec;
                        dgvCE2.Rows[fila].Cells[clmfkRawMaterialCE2.Index].Value = objRawMaterial.codsec;
                        dgvCE2.Rows[fila].Cells[clmNombreCE2.Index].Value = objRawMaterial.name;
                        dgvCE2.Rows[fila].Cells[clmMateriaPrimaCE2.Index].Value = objRawMaterial.code;
                        dgvCE2.Rows[fila].Cells[clmTipoCE2.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE2.Rows[fila].Cells[clmPorcentajeCE2.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer == 7)
                    {
                        dgvCE3.Rows.Add();
                        int fila = dgvCE3.Rows.Count - 1;
                        dgvCE3.Rows[fila].Cells[codsecCE3.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE3.Rows[fila].Cells[clmLayerCodsecCE3.Index].Value = obj.lstLayerThickByNewFormulation[3].Codsec;
                        dgvCE3.Rows[fila].Cells[clmfkRawMaterialCE3.Index].Value = objRawMaterial.codsec;
                        dgvCE3.Rows[fila].Cells[clmNombreCE3.Index].Value = objRawMaterial.name;
                        dgvCE3.Rows[fila].Cells[clmMateriaPrimaCE3.Index].Value = objRawMaterial.code;
                        dgvCE3.Rows[fila].Cells[clmTipoCE3.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE3.Rows[fila].Cells[clmPorcentajeCE3.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                    if (obj.lstNewFormulationDetail[i].fkLayer == 8)
                    {
                        dgvCE4.Rows.Add();
                        int fila = dgvCE4.Rows.Count - 1;
                        dgvCE4.Rows[fila].Cells[codsecCE4.Index].Value = obj.lstNewFormulationDetail[i].Codsec;
                        dgvCE4.Rows[fila].Cells[clmLayerCodsecCE4.Index].Value = obj.lstLayerThickByNewFormulation[4].Codsec;
                        dgvCE4.Rows[fila].Cells[clmfkRawMaterialCE4.Index].Value = objRawMaterial.codsec;
                        dgvCE4.Rows[fila].Cells[clmNombreCE4.Index].Value = objRawMaterial.name;
                        dgvCE4.Rows[fila].Cells[clmMateriaPrimaCE4.Index].Value = objRawMaterial.code;
                        dgvCE4.Rows[fila].Cells[clmTipoCE4.Index].Value = objRawMaterial.RawMaterialtypeName;
                        dgvCE4.Rows[fila].Cells[clmPorcentajeCE4.Index].Value = obj.lstNewFormulationDetail[i].Percentage;
                    }
                }
                dgvCapaCentral.AllowUserToAddRows = true;
                dgvCE1.AllowUserToAddRows = true;
                dgvCE2.AllowUserToAddRows = true;
                dgvCE3.AllowUserToAddRows = true;
                dgvCE4.AllowUserToAddRows = true;
            }
        }

        private void dgvCE5_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCE5.Rows[dgvCE5.Rows.Count - 1].Cells[clmEliminarCE5.Index].Tag == null)
                dgvCE5.Rows[dgvCE5.Rows.Count - 1].Cells[clmEliminarCE5.Index].Value = global::BPS.Properties.Resources.cross;
        }
        private void dgvCE1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCE1.Rows[dgvCE1.Rows.Count - 1].Cells[clmEliminarCE1.Index].Tag == null)
                dgvCE1.Rows[dgvCE1.Rows.Count - 1].Cells[clmEliminarCE1.Index].Value = global::BPS.Properties.Resources.cross;
        }

        private void dgvCE2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCE2.Rows[dgvCE2.Rows.Count - 1].Cells[clmEliminarCE2.Index].Tag == null)
                dgvCE2.Rows[dgvCE2.Rows.Count - 1].Cells[clmEliminarCE2.Index].Value = global::BPS.Properties.Resources.cross;
        }

        private void dgvCE3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           if (dgvCE3.Rows[dgvCE3.Rows.Count - 1].Cells[clmEliminarCE3.Index].Tag == null)
                dgvCE3.Rows[dgvCE3.Rows.Count - 1].Cells[clmEliminarCE3.Index].Value = global::BPS.Properties.Resources.cross;
        }

        private void dgvCE4_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCE4.Rows[dgvCE4.Rows.Count - 1].Cells[clmEliminarCE4.Index].Tag == null)
                dgvCE4.Rows[dgvCE4.Rows.Count - 1].Cells[clmEliminarCE4.Index].Value = global::BPS.Properties.Resources.cross;
        }

        private void cmbBoppFilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCapaCentral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCC.Index && editando == false)
            {
                if (dgvCapaCentral.CurrentRow.Cells[clmPorcentajeCC.Index].Value != null)
                    dgvCapaCentral.Rows.Remove(dgvCapaCentral.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCC.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCapaCentral.CurrentRow.Cells[codsecCC.Index].Value) == 0 && dgvCapaCentral.CurrentRow.Cells[clmPorcentajeCC.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCapaCentral.CurrentRow.Cells[clmPorcentajeCC.Index].Value != null)
                            dgvCapaCentral.Rows.Remove(dgvCapaCentral.CurrentRow);
                }
                else if (dgvCapaCentral.CurrentRow.Cells[clmPorcentajeCC.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCapaCentral.CurrentRow.Cells[codsecCC.Index].Value));
                        lstCapasAReemplazar[0] = Convert.ToInt32(dgvCapaCentral.CurrentRow.Cells[clmLayerCodsecCC.Index].Value);
                        dgvCapaCentral.Rows.Remove(dgvCapaCentral.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCapaCentral);
            if (dgvCapaCentral.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCapaCentral);
        }

        private void dgvCE1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCE1.Index && editando == false)
            {
                if (dgvCE1.CurrentRow.Cells[clmPorcentajeCE1.Index].Value != null)
                    dgvCE1.Rows.Remove(dgvCE1.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCE1.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCE1.CurrentRow.Cells[codsecCE1.Index].Value) == 0 && dgvCE1.CurrentRow.Cells[clmPorcentajeCE1.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCE1.CurrentRow.Cells[clmPorcentajeCE1.Index].Value != null)
                            dgvCE1.Rows.Remove(dgvCE1.CurrentRow);
                }
                else if (dgvCE1.CurrentRow.Cells[clmPorcentajeCE1.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCE1.CurrentRow.Cells[codsecCE1.Index].Value));
                        lstCapasAReemplazar[1] = Convert.ToInt32(dgvCE1.CurrentRow.Cells[clmLayerCodsecCE1.Index].Value);
                        dgvCE1.Rows.Remove(dgvCE1.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCE1);
            if (dgvCE1.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCE1);
        }

        private void dgvCE2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCE2.Index && editando == false)
            {
                if (dgvCE2.CurrentRow.Cells[clmPorcentajeCE2.Index].Value != null)
                    dgvCE2.Rows.Remove(dgvCE2.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCE2.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCE2.CurrentRow.Cells[codsecCE2.Index].Value) == 0 && dgvCE2.CurrentRow.Cells[clmPorcentajeCE2.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCE2.CurrentRow.Cells[clmPorcentajeCE2.Index].Value != null)
                            dgvCE2.Rows.Remove(dgvCE2.CurrentRow);
                }
                else if (dgvCE2.CurrentRow.Cells[clmPorcentajeCE2.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCE2.CurrentRow.Cells[codsecCE2.Index].Value));
                        lstCapasAReemplazar[2] = Convert.ToInt32(dgvCE2.CurrentRow.Cells[clmLayerCodsecCE2.Index].Value);
                        dgvCE2.Rows.Remove(dgvCE2.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCE2);
            if (dgvCE2.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCE2);
        }

        private void dgvCE3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCE3.Index && editando == false)
            {
                if (dgvCE3.CurrentRow.Cells[clmPorcentajeCE3.Index].Value != null)
                    dgvCE3.Rows.Remove(dgvCE3.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCE3.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCE3.CurrentRow.Cells[codsecCE3.Index].Value) == 0 && dgvCE3.CurrentRow.Cells[clmPorcentajeCE3.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCE3.CurrentRow.Cells[clmPorcentajeCE3.Index].Value != null)
                            dgvCE3.Rows.Remove(dgvCE3.CurrentRow);
                }
                else if (dgvCE3.CurrentRow.Cells[clmPorcentajeCE3.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCE3.CurrentRow.Cells[codsecCE3.Index].Value));
                        lstCapasAReemplazar[3] = Convert.ToInt32(dgvCE3.CurrentRow.Cells[clmLayerCodsecCE3.Index].Value);
                        dgvCE3.Rows.Remove(dgvCE3.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCE3);
            if (dgvCE3.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCE3);
        }

        private void dgvCE4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCE4.Index && editando == false)
            {
                if (dgvCE4.CurrentRow.Cells[clmPorcentajeCE4.Index].Value != null)
                    dgvCE4.Rows.Remove(dgvCE4.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCE4.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCE4.CurrentRow.Cells[codsecCE4.Index].Value) == 0 && dgvCE4.CurrentRow.Cells[clmPorcentajeCE4.Index].Value != null)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCE4.CurrentRow.Cells[clmPorcentajeCE4.Index].Value != null)
                            dgvCE4.Rows.Remove(dgvCE4.CurrentRow);
                }
                else if (dgvCE4.CurrentRow.Cells[clmPorcentajeCE4.Index].Value != null)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCE4.CurrentRow.Cells[codsecCE4.Index].Value));
                        lstCapasAReemplazar[4] = Convert.ToInt32(dgvCE4.CurrentRow.Cells[clmLayerCodsecCE4.Index].Value);
                        dgvCE4.Rows.Remove(dgvCE4.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCE4);
            if (dgvCE4.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCE4);
        }

        private void dgvCE5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarCE5.Index && editando == false)
            {
                if (dgvCE5.CurrentRow.Cells[clmPorcentajeCE5.Index].Value != null)
                    dgvCE5.Rows.Remove(dgvCE5.CurrentRow);
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.ColumnIndex == clmEliminarCE5.Index && editando == true)
            {
                if (Convert.ToInt32(dgvCE5.CurrentRow.Cells[codsecCE5.Index].Value) == 0 && dgvCE5.CurrentRow.Cells[clmPorcentajeCE5.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (dgvCE5.CurrentRow.Cells[clmPorcentajeCE5.Index].Value != null)
                            dgvCE5.Rows.Remove(dgvCE5.CurrentRow);
                }
                else if (dgvCE5.CurrentRow.Cells[clmPorcentajeCE5.Index].Value != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el material?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LstMaterialesAEliminar.Add(Convert.ToInt32(dgvCE5.CurrentRow.Cells[codsecCE5.Index].Value));
                        lstCapasAReemplazar[5] = Convert.ToInt32(dgvCE5.CurrentRow.Cells[clmLayerCodsecCE5.Index].Value);
                        dgvCE5.Rows.Remove(dgvCE5.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Para eliminar la fila, primero debe completarla", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequearFilas(dgvCE5);
            if (dgvCE5.Rows.Count - 1 != 0)
                ControlarPorcentaje(dgvCE5);
        }

        private void cmbMaquina_MouseEnter(object sender, EventArgs e)
        {
            lblMaquina.ForeColor = SystemColors.ControlText;
        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(editando!=true)
            {
                ShowTabPage();
                maquina = ((clsMachine)cmbMaquina.SelectedItem).codsec;
                lstLayer = clsLayer.getListByMachine(maquina);
                if (maquina == 3024)
                {
                    HideTabPage(tbpCoExtrusor3);
                    HideTabPage(tbpCoExtrusor4);
                    HideTabPage(tbpCoExtrusor5);
                    p4.Visible = false;
                    p5.Visible = false;
                    p6.Visible = false;
                }
                else if (maquina == 11)
                {
                    p4.Visible = true;
                    p5.Visible = true;
                    HideTabPage(tbpCoExtrusor5);
                    p6.Visible = false;
                }
            }
            else
            {
                cmbMaquina.Enabled = false;
                if (((clsMachine)cmbMaquina.SelectedItem).codsec == 3024)
                {
                    HideTabPage(tbpCoExtrusor3);
                    HideTabPage(tbpCoExtrusor4);
                    HideTabPage(tbpCoExtrusor5);
                    p4.Visible = false;
                    p5.Visible = false;
                    p6.Visible = false;
                }
                else if (((clsMachine)cmbMaquina.SelectedItem).codsec == 11)
                {
                    HideTabPage(tbpCoExtrusor5);
                    p6.Visible = false;
                }
            }
        }
    }
}
