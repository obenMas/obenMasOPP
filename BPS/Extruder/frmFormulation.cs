using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Extruder
{
    public partial class frmFormulation : Form
    {
        private int fkProduction = 0, fkFilmProduction = 0, fkFormulation = 0, fkBopp = 0;
        //fkFilmProduction = 12765

        #region InitValue

        public frmFormulation()
        {
            InitializeComponent();
        }

        public frmFormulation(string source)
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
            //cambio el codigo 2 por 11
            //var machine = (source == "DMT") ? '2' : '1';
            int machine = 11;
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
            //if (source == "DMT")
            //    fkFilmProduction = 12765;
            //else
            //    fkFilmProduction = 12785;
        }

        private void fillRaw(string source)
        {
            if (source == "DMT")
                fillDMT();
            else
                fillMW();
        }

        private void fillFormulation(string source)
        {
            var formulation = clsFormulationByFilmProductionPlan.getListFilmProductionPlanReload(fkFilmProduction);

            if (formulation.Count > 0)
            {
                if (source == "DMT")
                {
                    foreach (var item in formulation)
                    {
                        txtFNameD.Text = item.formulationName;
                        fkFormulation = item.fkFormulation;
                    }
                }
                else
                {
                    foreach (var item in formulation)
                    {
                        txtFNameMW.Text = item.formulationName;
                        fkFormulation = item.fkFormulation;
                    }
                }
            }
            else
            {
                if (source == "DMT")
                    txtFNameD.Text = lblProductFrom.Text + " - " + lblProductTo.Text + " - " + lblLotNumber.Text;
                else
                    txtFNameMW.Text = lblProductFrom.Text + " - " + lblProductTo.Text + " - " + lblLotNumber.Text;
            }
        }
        #endregion

        #region DMT

        private void fillDMT()
        {
            if (fkFilmProduction != 0)
            {
                fillFormulation("DMT");
                fillLayer();
            }
        }

        private void fillLayer()
        {
            ExtPrimary();
        }

        private void ExtPrimary()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvCLD.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.CentralLayer)
                {
                    dgvCLD.Rows.Add();
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centercodsec.Index].Value = item.codsec;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerwei.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerlt.Index].Value = item.lotnumber;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerpro.Index].Value = item.material;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerCode.Index].Value = item.code;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerprovee.Index].Value = item.provider;

                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerfkRaw.Index].Value = item.fkRaw;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerIsReProcess.Index].Value = item.isReProcess;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerFkOrigin.Index].Value = item.fkOrigin;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centerfkFormulation.Index].Value = item.fkFormulation;
                    dgvCLD.Rows[dgvCLD.Rows.Count - 1].Cells[centeroperation.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void L1DMT()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvL1.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC1)
                {
                    dgvL1.Rows.Add();
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1codsec.Index].Value = item.codsec;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1lot.Index].Value = item.lotnumber;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1pro.Index].Value = item.material;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1code.Index].Value = item.code;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1provider.Index].Value = item.provider;

                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1fkraw.Index].Value = item.fkRaw;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1isreprocess.Index].Value = item.isReProcess;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1fkorigen.Index].Value = item.fkOrigin;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1fkformulation.Index].Value = item.fkFormulation;
                    dgvL1.Rows[dgvL1.Rows.Count - 1].Cells[l1delete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void L2DMT()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvL2.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC2)
                {
                    dgvL2.Rows.Add();
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2codsec.Index].Value = item.codsec;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2lot.Index].Value = item.lotnumber;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2pro.Index].Value = item.material;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2code.Index].Value = item.code;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2prov.Index].Value = item.provider;

                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2fkraw.Index].Value = item.fkRaw;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2isrepro.Index].Value = item.isReProcess;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2fkori.Index].Value = item.fkOrigin;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2fkfor.Index].Value = item.fkFormulation;
                    dgvL2.Rows[dgvL2.Rows.Count - 1].Cells[l2del.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void L3DMT()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvL3.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC3)
                {
                    dgvL3.Rows.Add();
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3codsec.Index].Value = item.codsec;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3lot.Index].Value = item.lotnumber;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3pro.Index].Value = item.material;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3code.Index].Value = item.code;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3prov.Index].Value = item.provider;

                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3fkraw.Index].Value = item.fkRaw;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3isrepro.Index].Value = item.isReProcess;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3fkori.Index].Value = item.fkOrigin;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3fkfor.Index].Value = item.fkFormulation;
                    dgvL3.Rows[dgvL3.Rows.Count - 1].Cells[l3del.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void L4DMT()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvL4.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC4)
                {
                    dgvL4.Rows.Add();
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4codsec.Index].Value = item.codsec;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4lot.Index].Value = item.lotnumber;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4pro.Index].Value = item.material;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4code.Index].Value = item.code;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4prov.Index].Value = item.provider;

                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4fkraw.Index].Value = item.fkRaw;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4isrepro.Index].Value = item.isReProcess;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4fkori.Index].Value = item.fkOrigin;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4fkfor.Index].Value = item.fkFormulation;
                    dgvL4.Rows[dgvL4.Rows.Count - 1].Cells[l4del.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        #region Central Layer DMT
        private void txtCLD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (txtCLD.Text.ToUpper().Trim().Substring(0, 4) != "SILO")
                {
                    getRaw(txtCLD.Text.ToUpper().Trim());
                }
                else
                {
                    getSilo(txtCLD.Text.ToUpper().Trim(), "CL-DMT");
                }
            }
                

        }

        private void getSilo(string silo, string layer)
        {
            clsRawMaterialbySilo rawOBJ = new clsRawMaterialbySilo();

            switch (layer)
            {
                case "CL-DMT":
                    rawOBJ = clsRawMaterialbySilo.getFirstInBySilo(txtCLD.Text.ToUpper().Trim().Substring(4, 1));
                    break;
                case "L1-DMT":
                    rawOBJ = clsRawMaterialbySilo.getFirstInBySilo(txtL1.Text.ToUpper().Trim().Substring(4, 1));
                    break;
                case "L2-DMT":
                    rawOBJ = clsRawMaterialbySilo.getFirstInBySilo(txtL2.Text.ToUpper().Trim().Substring(4, 1));
                    break;
                case "L3-DMT":
                    rawOBJ = clsRawMaterialbySilo.getFirstInBySilo(txtL3.Text.ToUpper().Trim().Substring(4, 1));
                    break;
                case "L4-DMT":
                    rawOBJ = clsRawMaterialbySilo.getFirstInBySilo(txtL4.Text.ToUpper().Trim().Substring(4, 1));
                    break;
            }
            
            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

                if (fkFormulation == 0)
                {
                    frmMessageSilo winM = new frmMessageSilo(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, layer);
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        switch(layer)
                        {
                            case "CL-DMT": 
                                txtCLD.Clear();
                                ExtPrimary();
                                break;
                            case "L1-DMT":
                                txtL1.Clear();
                                L1DMT();
                                break;
                            case "L2-DMT":
                                txtL2.Clear();
                                L2DMT();
                                break;
                            case "L3-DMT":
                                txtL3.Clear();
                                L3DMT();
                                break;
                            case "L4-DMT":
                                txtL4.Clear();
                                L4DMT();
                                break;
                        }

                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessageSilo winM = new frmMessageSilo(rawOBJ, fkFormulation, layer);
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        switch (layer)
                        {
                            case "CL-DMT":
                                txtCLD.Clear();
                                ExtPrimary();
                                break;
                            case "L1-DMT":
                                txtL1.Clear();
                                L1DMT();
                                break;
                            case "L2-DMT":
                                txtL2.Clear();
                                L2DMT();
                                break;
                            case "L3-DMT":
                                txtL3.Clear();
                                L3DMT();
                                break;
                            case "L4-DMT":
                                txtL4.Clear();
                                L4DMT();
                                break;
                        }
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                MessageBox.Show("No se pudo procesar el ingreso");
        }

        private void getRaw(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

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
                fillFormulation("DMT");

                //    frmMessage winM = new frmMessage(reprocessOBJ);
                //    winM.StartPosition = FormStartPosition.CenterScreen;
                //    winM.ShowDialog();

                //    if (winM.isValidProcess)
                //    {
                //        MessageBox.Show("Reprocesado agregado correctamente");
                //        ExtPrimary();
                //    }
                //    else
                //        MessageBox.Show("No se pudo procesar el ingreso");
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
                        if (dgvCLD.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString().Trim().Substring(0, 4).ToUpper() != "SILO")
                        {
                            if (clsRawMaterialExtruder.setDeleteTransferMR(dgvCLD.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvCLD.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvCLD.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvCLD.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "CL"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    ExtPrimary();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                        else
                        {
                            clsRawMaterialbySilo objRaw = new clsRawMaterialbySilo(Convert.ToInt32(dgvCLD.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value));
                            objRaw.weigth = objRaw.weigth + Convert.ToInt32(dgvCLD.Rows[e.RowIndex].Cells[centerwei.Index].Value);
                            if(objRaw.toUpdateData())
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvCLD.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvCLD.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvCLD.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "CL"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    ExtPrimary();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvCLD.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 1 DMT
        private void txtL1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtL1.Text.ToUpper().Trim().Substring(0, 4) != "SILO")
                {
                    getRawL1(txtL1.Text.ToUpper().Trim());
                }
                else
                {
                    getSilo(txtL1.Text.ToUpper().Trim(), "L1-DMT");
                }
            }
                


        }

        private void getRawL1(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, "L1-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL1.Clear();
                        L1DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "L1-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL1.Clear();
                        L1DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvL1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvL1.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (dgvL1.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString().Trim().Substring(0, 4).ToUpper() != "SILO")
                        {
                            if (clsRawMaterialExtruder.setDeleteTransferMR(dgvL1.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL1.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL1.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL1.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L1"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L1DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                        else
                        {
                            clsRawMaterialbySilo objRaw = new clsRawMaterialbySilo(Convert.ToInt32(dgvL1.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value));
                            objRaw.weigth = objRaw.weigth + Convert.ToInt32(dgvL1.Rows[e.RowIndex].Cells[centerwei.Index].Value);
                            if (objRaw.toUpdateData())
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL1.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL1.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL1.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L1"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L1DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvL1.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 2 DMT
        private void txtL2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtL2.Text.ToUpper().Trim().Substring(0, 4) != "SILO")
                {
                    getRawL2(txtL2.Text.ToUpper().Trim());
                }
                else
                {
                    getSilo(txtL2.Text.ToUpper().Trim(), "L2-DMT");
                }
            }
        }

        private void getRawL2(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, "L2-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL2.Clear();
                        L2DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "L2-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL2.Clear();
                        L2DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvL2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvL2.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (dgvL2.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString().Trim().Substring(0, 4).ToUpper() != "SILO")
                        {
                            if (clsRawMaterialExtruder.setDeleteTransferMR(dgvL2.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL2.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL2.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL2.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L2"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L2DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                        else
                        {
                            clsRawMaterialbySilo objRaw = new clsRawMaterialbySilo(Convert.ToInt32(dgvL2.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value));
                            objRaw.weigth = objRaw.weigth + Convert.ToInt32(dgvL2.Rows[e.RowIndex].Cells[centerwei.Index].Value);
                            if (objRaw.toUpdateData())
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL2.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL2.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL2.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L2"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L2DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvL2.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 3 DMT
        private void txtL3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtL3.Text.ToUpper().Trim().Substring(0, 4) != "SILO")
                {
                    getRawL3(txtL3.Text.ToUpper().Trim());
                }
                else
                {
                    getSilo(txtL3.Text.ToUpper().Trim(), "L3-DMT");
                }
            }
        }

        private void getRawL3(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, "L3-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL3.Clear();
                        L3DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "L3-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL3.Clear();
                        L3DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvL3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvL3.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (dgvL3.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString().Trim().Substring(0, 4).ToUpper() != "SILO")
                        {
                            if (clsRawMaterialExtruder.setDeleteTransferMR(dgvL3.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL3.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL3.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL3.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L3"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L3DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                        else
                        {
                            clsRawMaterialbySilo objRaw = new clsRawMaterialbySilo(Convert.ToInt32(dgvL3.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value));
                            objRaw.weigth = objRaw.weigth + Convert.ToInt32(dgvL3.Rows[e.RowIndex].Cells[centerwei.Index].Value);
                            if (objRaw.toUpdateData())
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL3.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL3.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL3.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L3"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L3DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvL3.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 4 DMT
        private void txtL4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtL4.Text.ToUpper().Trim().Substring(0, 4) != "SILO")
                {
                    getRawL4(txtL4.Text.ToUpper().Trim());
                }
                else
                {
                    getSilo(txtL4.Text.ToUpper().Trim(), "L4-DMT");
                }
            }
        }

        private void getRawL4(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("DMT");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameD.Text, "L4-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL4.Clear();
                        L4DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "L4-DMT");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtL4.Clear();
                        L4DMT();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvL4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvL4.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (dgvL4.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString().Trim().Substring(0, 4).ToUpper() != "SILO")
                        {
                            if (clsRawMaterialExtruder.setDeleteTransferMR(dgvL4.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString()))
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL4.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL4.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL4.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L4"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L4DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                        else
                        {
                            clsRawMaterialbySilo objRaw = new clsRawMaterialbySilo(Convert.ToInt32(dgvL4.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value));
                            objRaw.weigth = objRaw.weigth + Convert.ToInt32(dgvL4.Rows[e.RowIndex].Cells[centerwei.Index].Value);
                            if (objRaw.toUpdateData())
                            {
                                if (clsRawMaterialByFormulation.toDeleteMPCL(dgvL4.Rows[e.RowIndex].Cells[centercodsec.Index].Value.ToString(),
                                    dgvL4.Rows[e.RowIndex].Cells[centerfkFormulation.Index].Value.ToString(),
                                    dgvL4.Rows[e.RowIndex].Cells[centerlt.Index].Value.ToString(), "L4"))
                                {
                                    MessageBox.Show("Materia Prima Eliminada correctamente");
                                    L4DMT();
                                }
                                else
                                    MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                            }
                            else
                                MessageBox.Show("Ocurrio un error, consulte con sistemas.");
                        }
                    }
                    else
                        MessageBox.Show("El pallet " + dgvL4.Rows[e.RowIndex].Cells[centerCode.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        private void btnFDMT_Click(object sender, EventArgs e)
        {
            if (fkFormulation != 0)
            {
                frmFormulationReport winF = new frmFormulationReport(fkFormulation);
                winF.Show(this);
            }
            else
                MessageBox.Show("No posee datos asociados para generar el reporte de formulación");
        }

       

        #region MW
        private void fillMW()
        {
            if (fkFilmProduction != 0)
            {
                fillFormulation("MW");
                fillLayerMW();
            }
        }

        private void fillLayerMW()
        {
            ExtPrimaryMW();
        }

        private void ExtPrimaryMW()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvCLMW.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.CentralLayer)
                {
                    dgvCLMW.Rows.Add();
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extcodsec.Index].Value = item.codsec;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extwe.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extlot.Index].Value = item.lotnumber;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extpro.Index].Value = item.material;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extcod.Index].Value = item.code;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extprov.Index].Value = item.provider;

                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extfkraw.Index].Value = item.fkRaw;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extisrepro.Index].Value = item.isReProcess;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extfkori.Index].Value = item.fkOrigin;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extfkform.Index].Value = item.fkFormulation;
                    dgvCLMW.Rows[dgvCLMW.Rows.Count - 1].Cells[extdel.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void S1MW()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvS1.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC1)
                {
                    dgvS1.Rows.Add();
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1codsec.Index].Value = item.codsec;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1lot.Index].Value = item.lotnumber;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1pro.Index].Value = item.material;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1code.Index].Value = item.code;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1prov.Index].Value = item.provider;

                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1fkraw.Index].Value = item.fkRaw;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1isreprocess.Index].Value = item.isReProcess;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1fkori.Index].Value = item.fkOrigin;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1fkfor.Index].Value = item.fkFormulation;
                    dgvS1.Rows[dgvS1.Rows.Count - 1].Cells[s1del.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void S2MW()
        {
            var rawList = clsRawMaterialByFormulation.getListByFormulationExtruderPlus(fkFilmProduction).OrderByDescending(ord => ord.codsec);

            dgvS2.Rows.Clear();

            foreach (var item in rawList)
            {
                if (item.layerC2)
                {
                    dgvS2.Rows.Add();
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2codsec.Index].Value = item.codsec;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2we.Index].Value = Math.Round(item.weigth, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2lot.Index].Value = item.lotnumber;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2pro.Index].Value = item.material;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2code.Index].Value = item.code;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2prov.Index].Value = item.provider;

                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2fkraw.Index].Value = item.fkRaw;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2isrepro.Index].Value = item.isReProcess;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2fkori.Index].Value = item.fkOrigin;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2fkform.Index].Value = item.fkFormulation;
                    dgvS2.Rows[dgvS2.Rows.Count - 1].Cells[s2del.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        #region Central Layer MW
        private void txtCLDMW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getRawMW(txtCLDMW.Text.ToUpper().Trim());
        }

        private void getRawMW(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("MW");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameMW.Text, "CL-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtCLDMW.Clear();
                        ExtPrimaryMW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "CL-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtCLDMW.Clear();
                        ExtPrimaryMW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocessMW(code);
        }

        private void getReprocessMW(string code)
        {
            var reprocessOBJ = clsMillPallet.getObjMillPallet(code);

            if (reprocessOBJ.codsec > 0)
            {
                fillFormulation("MW");

                //    frmMessage winM = new frmMessage(reprocessOBJ);
                //    winM.StartPosition = FormStartPosition.CenterScreen;
                //    winM.ShowDialog();

                //    if (winM.isValidProcess)
                //    {
                //        MessageBox.Show("Reprocesado agregado correctamente");
                //        ExtPrimary();
                //    }
                //    else
                //        MessageBox.Show("No se pudo procesar el ingreso");
            }
            else
            {
                MessageBox.Show("Código del pallet no encontrado, por favor vuelva a intentarlo!!");
                txtCLDMW.Focus();
            }
        }

        private void dgvCLMW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvCLMW.Rows[e.RowIndex].Cells[centerfkRaw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (clsRawMaterialExtruder.setDeleteTransferMR(dgvCLMW.Rows[e.RowIndex].Cells[extfkraw.Index].Value.ToString()))
                        {
                            if (clsRawMaterialByFormulation.toDeleteMPCL(dgvCLMW.Rows[e.RowIndex].Cells[extcodsec.Index].Value.ToString(),
                                dgvCLMW.Rows[e.RowIndex].Cells[extfkform.Index].Value.ToString(),
                                dgvCLMW.Rows[e.RowIndex].Cells[extlot.Index].Value.ToString(), "CL"))
                            {
                                MessageBox.Show("Materia Prima Eliminada correctamente");
                                ExtPrimaryMW();
                            }
                            else
                                MessageBox.Show("Upps Transacción Reverso");
                        }
                        else
                            MessageBox.Show("Upps Transacción Reverso");
                    }
                    else
                        MessageBox.Show("El pallet " + dgvCLMW.Rows[e.RowIndex].Cells[extcod.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 1 DMT
        private void txtS1MW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getRawS1(txtS1MW.Text.ToUpper().Trim());
        }

        private void getRawS1(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("MW");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameMW.Text, "S1-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtS1MW.Clear();
                        S1MW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "S1-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtS1MW.Clear();
                        S1MW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvS1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvS1.Rows[e.RowIndex].Cells[s1fkraw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (clsRawMaterialExtruder.setDeleteTransferMR(dgvS1.Rows[e.RowIndex].Cells[s1fkraw.Index].Value.ToString()))
                        {
                            if (clsRawMaterialByFormulation.toDeleteMPCL(dgvS1.Rows[e.RowIndex].Cells[s1codsec.Index].Value.ToString(),
                                dgvS1.Rows[e.RowIndex].Cells[s1fkfor.Index].Value.ToString(),
                                dgvS1.Rows[e.RowIndex].Cells[s1lot.Index].Value.ToString(), "L1"))
                            {
                                MessageBox.Show("Materia Prima Eliminada correctamente");
                                S1MW();
                            }
                            else
                                MessageBox.Show("Upps Transacción Reverso");
                        }
                        else
                            MessageBox.Show("Upps Transacción Reverso");
                    }
                    else
                        MessageBox.Show("El pallet " + dgvS1.Rows[e.RowIndex].Cells[s1code.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #region Layer 2 DMT
        private void txtS2MW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getRawS2(txtS2MW.Text.ToUpper().Trim());
        }

        private void getRawS2(string code)
        {
            var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            #region rawMaterialExtruder

            if (rawOBJ.codsec > 0)
            {
                fillFormulation("MW");

                if (fkFormulation == 0)
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkBopp, fkFilmProduction, txtFNameMW.Text, "S2-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtS2MW.Clear();
                        S2MW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
                else
                {
                    frmMessage winM = new frmMessage(rawOBJ, fkFormulation, "S2-MW");
                    winM.StartPosition = FormStartPosition.CenterScreen;
                    winM.ShowDialog();

                    if (winM.isValidProcess)
                    {
                        MessageBox.Show("Materia Prima agregada correctamente");
                        txtS2MW.Clear();
                        S2MW();
                    }
                    else
                        MessageBox.Show("No se pudo procesar el ingreso");
                }
            }
            #endregion
            else
                getReprocess(code);
        }

        private void dgvS2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el material seleccionado?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    //Validar que el mismo pallet no esté en otras fórmulas
                    if (clsSummaryRM.validateToDeleteRow(dgvS2.Rows[e.RowIndex].Cells[s2fkraw.Index].Value.ToString(), fkFilmProduction))
                    {
                        if (clsRawMaterialExtruder.setDeleteTransferMR(dgvS2.Rows[e.RowIndex].Cells[s2fkraw.Index].Value.ToString()))
                        {
                            if (clsRawMaterialByFormulation.toDeleteMPCL(dgvS2.Rows[e.RowIndex].Cells[s2codsec.Index].Value.ToString(),
                                dgvS2.Rows[e.RowIndex].Cells[s2fkform.Index].Value.ToString(),
                                dgvS2.Rows[e.RowIndex].Cells[s2lot.Index].Value.ToString(), "L2"))
                            {
                                MessageBox.Show("Materia Prima Eliminada correctamente");
                                L2DMT();
                            }
                            else
                                MessageBox.Show("Upps Transacción Reverso");
                        }
                        else
                            MessageBox.Show("Upps Transacción Reverso");
                    }
                    else
                        MessageBox.Show("El pallet " + dgvS2.Rows[e.RowIndex].Cells[s2code.Index].Value.ToString() + " no puede ser eliminado ya que se encuentra en otras fórmulas, Por favor comunicarse con sistemas");
                }
            }
        }
        #endregion

        #endregion

        #region Helper

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtCLD.Focus();
                ExtPrimary();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                L1DMT();
                txtL1.Focus();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                L2DMT();
                txtL2.Focus();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                L3DMT();
                txtL3.Focus();
            }
            else
            {
                L4DMT();
                txtL4.Focus();
            }

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
            {
                ExtPrimaryMW();
                txtCLDMW.Focus();
            }
            else if (tabControl2.SelectedIndex == 1)
            {
                S1MW();
                txtS1MW.Focus();
            }
            else
            {
                S2MW();
                txtS2MW.Focus();
            }

        }

        private void btnTrazaDMT_Click(object sender, EventArgs e)
        {
            frmTraza winTraza = new frmTraza();
            winTraza.ShowDialog();
        }

        private void btnTrazaMW_Click(object sender, EventArgs e)
        {
            frmTraza winTraza = new frmTraza();
            winTraza.ShowDialog();
        }

        #endregion

        private void btnFMW_Click(object sender, EventArgs e)
        {
            if (fkFormulation != 0)
            {
                frmFormulationReport winF = new frmFormulationReport(fkFormulation);
                winF.Show(this);
            }
            else
                MessageBox.Show("No posee datos asociados para generar l reporte de formulación");
        }
    }
}
