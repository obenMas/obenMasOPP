using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Raw.ProcessR.Line
{
    public partial class frmFormulationRM : Form
    {
        private int fkProduction = 0, fkFilmProduction = 12765, fkFormulation = 0, fkBopp = 0;

        #region InitValue

        public frmFormulationRM()
        {
            InitializeComponent();
        }

        public frmFormulationRM(string source)
        {
            InitializeComponent();
            validateMachine(source);
            validateHead(source);
            fillRaw(source);
        }

        private void validateMachine(string source)
        {
            if (source == "DMT")
                tbcFilm.TabPages.RemoveAt(1);
            else
                tbcFilm.TabPages.RemoveAt(0);
        }

        private void validateHead(string source)
        {
            var machine = (source == "DMT") ? '2' : '1';
            var proList = clsFilmProductionPlan.getExtruderOrder(machine);

            foreach (var item in proList)
            {
                lblProductFrom.Text = item.boppcode.ToUpper();
                lblProductTo.Text = item.MachineName.ToUpper();
                lblLotNumber.Text = item.lotNumber.ToUpper();
                fkProduction = item.fkProductionOrder;
                fkFilmProduction = item.codsec;
                fkBopp = item.fkBaseFilm;
            }

            //Tengo de dar comentario a esta línea de código
            fkFilmProduction = 12765;
        }

        private void fillRaw(string source)
        {
            if (source == "DMT")
                fillDMT();
            else
                fillMW();
        }

        private void fillFormulation()
        {
            var formulation = clsFormulationByFilmProductionPlan.getListFilmProductionPlanReload(fkFilmProduction);

            if (formulation.Count > 0)
            {
                foreach (var item in formulation)
                {
                    txtFNameD.Text = item.formulationName;
                    fkFormulation = item.fkFormulation;
                }
            }
            else
                txtFNameD.Text = lblProductFrom.Text + " - " + lblProductTo.Text + " - " + lblLotNumber.Text;
        }
        #endregion

        #region DMT

        private void fillDMT()
        {
            if (fkFilmProduction != 0)
            {
                fillFormulation();
                fillLayer();
            }
        }

        private void fillLayer()
        {
            ExtPrimary();
        }

        private void ExtPrimary()
        {
            //var rawList = clsRawMaterialByFormulation.getListByFormulationExtruder(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            //dgvCLD.Rows.Clear();


            //foreach (var item in rawList)
            //{
            //    if (item.CentralLayer)
            //    {
            //        dgvCLD.Rows.Add();
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centercodsec.Index].Value = item.codsec;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerwei.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerlt.Index].Value = item.lotnumber;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerpro.Index].Value = item.material;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerCode.Index].Value = item.code;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerprovee.Index].Value = item.provider;

            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerfkRaw.Index].Value = item.fkRaw;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerIsReProcess.Index].Value = item.isReProcess;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerFkOrigin.Index].Value = item.fkOrigin;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerfkFormulation.Index].Value = item.fkFormulation;
            //        dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centeroperation.Index].Value = global::BPS.Raw.Properties.Resources.cross;
            //    }
            //}
        }

        #region Central Layer DMT
        private void txtCLD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getRaw(txtCLD.Text.ToUpper().Trim());
            }
        }

        private void getRaw(string code)
        {
            var rawOBJ = clsRawMaterial.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation();

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, "CL-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtCLD.Clear();
                        ExtPrimary();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "CL-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtCLD.Clear();
                        ExtPrimary();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void getReprocess(string code)
        {
            var reprocessOBJ = clsMillPallet.getObjMillPallet(code);

            if (reprocessOBJ.codsec > 0)
            {
                fillFormulation();

                frmMessage winM = new frmMessage(reprocessOBJ);
                winM.StartPosition = FormStartPosition.CenterScreen;
                winM.ShowDialog();

                if (winM.isValidProcess)
                {
                    MessageBox.Show("Reprocesado agregado correctamente");
                    ExtPrimary();
                }
                else
                    MessageBox.Show("No se pudo procesar el ingreso");
            }
            else
            {
                MessageBox.Show("Código del pallet no encontrado, por favor vuelva a intentarlo!!");
                txtCLD.Focus();
            }
        }

        private void dgvCLD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvCLD.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        //validar si viene de un reproceso (pallet divido)
                        if (!Convert.ToBoolean(dgvCLD.Rows[e.RowIndex].Cells[centerIsReProcess.Index].Value.ToString()))
                        {
                            if (clsRawMaterialbyCoilCellar.setDeleteTransferMR(dgvCLD.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvCLD.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(), dgvCLD.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString()))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    ExtPrimary();
                                }
                                else
                                    MessageBox.Show("Upps Transacción Reverso");
                            }
                            else
                                MessageBox.Show("Upps Transacción Reverso");
                        }
                        else
                        {
                            //reverso para el reproceso
                            clsReverseMP.processReverse(dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centercodsec.Index].Value.ToString(),
                                dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerfkRaw.Index].Value.ToString(),
                                dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerFkOrigin.Index].Value.ToString());
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvCLD.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }

        #endregion

        #endregion



        private void fillMW()
        {
            throw new NotImplementedException();
        }

    }
}
