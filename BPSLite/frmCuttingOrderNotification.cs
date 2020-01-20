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
    public partial class frmCuttingOrderNotification : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        DataSet DS3 = new DataSet();
        string cstop = "";
        bool starting = false;
        int metRep = 0;

        public frmCuttingOrderNotification(int cuttingordercodsec)
        {
            InitializeComponent();
            List<clsUser> lstUsers;

            if (clsGlobal.LoggedUser.RoleName == "Supervisor de corte" || clsGlobal.LoggedUser.RoleName == "Digitador de corte" || clsGlobal.LoggedUser.RoleName == "Operadores de corte" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C230" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C231" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C232")
            {
                lstUsers = clsUser.getListByRole("Supervisor de corte");
                cmbSuper.Items.Clear();
                cmbSuper.SelectedIndex = -1;
                cmbSuper.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbSuper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Supervisor Pilar");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbSuper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte");
                cmbDigit.Items.Clear();
                cmbDigit.SelectedIndex = -1;
                cmbDigit.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C230");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C231");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C232");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Digitador Pilar");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte");
                cmbOper.Items.Clear();
                cmbOper.SelectedIndex = -1;
                cmbOper.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C230");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C231");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Operadores de corte C232");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Digitador Pilar");
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
            }
            if (clsGlobal.LoggedUser.RoleName == "Digitador Pilar" || clsGlobal.LoggedUser.RoleName == "Supervisor Pilar")
            {
                lstUsers = clsUser.getListByRole("Supervisor Pilar");
                cmbSuper.Items.Clear();
                cmbSuper.SelectedIndex = -1;
                cmbSuper.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbSuper.Items.Add(lstUsers[j]);
                }
                lstUsers = clsUser.getListByRole("Digitador Pilar");
                cmbDigit.Items.Clear();
                cmbDigit.SelectedIndex = -1;
                cmbDigit.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigit.Items.Add(lstUsers[j]);
                }
                cmbOper.Items.Clear();
                cmbOper.SelectedIndex = -1;
                cmbOper.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOper.Items.Add(lstUsers[j]);
                }
            }

            txtCuttingOrder.Text = cuttingordercodsec.ToString();

            getDataSet(txtCuttingOrder.Text);


            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                cmbRepetitions.Items.Clear();
                txtCutter.Text = DS.Tables[0].Rows[0]["Cortadora"].ToString();
                for (int i = 1; i <= Convert.ToInt32(DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Repeticion"]); i++)
                {
                    cmbRepetitions.Items.Add(i);
                }
                txtTotalRep.Text = DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Repeticion"].ToString();
                txtNotes.Text = DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Observaciones"].ToString();
                txtStatus.Text = DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Estado"].ToString();
                txtFilm.Text = DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Pelicula"].ToString();
            }
        }

        public DataSet getDataSet(string codsec)
        {
            DS = clsConnection.getDataSetResult("CALL spcuttingorderdigitation("+codsec+","+clsGlobal.Company.fkCountry.ToString()+")");

            return DS;
        }

        public DataSet getMainCoils(string codsec)
        {
            DS2 = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilsdetailbycuttingstop WHERE cuttingstop=" + codsec + "");

            return DS2;
        }

        public DataSet getSecundaryCoils(string codsec)
        {
            DS3 = clsConnection.getDataSetResult("SELECT * FROM vwsecundarymaincoilsdetailbycuttingstop WHERE cuttingstop=" + codsec + "");

            return DS3;
        }

        private void filldata()
        {
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bool cont = true;
                int ind = 0;

                while (cont)
                {
                    if (ind < DS.Tables[0].Rows.Count)
                    {
                        if (cmbRepetitions.Items[cmbRepetitions.SelectedIndex].ToString() == DS.Tables[0].Rows[ind]["Repeticion"].ToString())
                        {
                            if (Convert.ToInt32(DS.Tables[0].Rows[ind]["ParadaCerrada"]) == 0)
                            {
                                txtRepStatus.Text = "Abierta";
                            }
                            else
                            {
                                txtRepStatus.Text = "Cerrada";
                            }

                            starting = true;
                            cmbOper.SelectedIndex = -1;
                            for (int i = 0; i < cmbOper.Items.Count; i++)
                            {
                                if (cmbOper.Items[i].ToString() == DS.Tables[0].Rows[ind]["Operador"].ToString())
                                {
                                    cmbOper.SelectedIndex = i;
                                }
                            }

                            cmbDigit.SelectedIndex = -1;
                            for (int i = 0; i < cmbDigit.Items.Count; i++)
                            {
                                if (cmbDigit.Items[i].ToString() == DS.Tables[0].Rows[ind]["Digitador"].ToString())
                                {
                                    cmbDigit.SelectedIndex = i;
                                }
                            }

                            cmbSuper.SelectedIndex = -1;
                            for (int i = 0; i < cmbSuper.Items.Count; i++)
                            {
                                if (cmbSuper.Items[i].ToString() == DS.Tables[0].Rows[ind]["Supervisor"].ToString())
                                {
                                    cmbSuper.SelectedIndex = i;
                                }
                            }
                            starting = false;
                            cont = false;
                        }
                    }
                    else
                    {
                        cont = false;
                    }
                    ind++;
                }

                dgvDetail.Rows.Clear();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (cmbRepetitions.Items[cmbRepetitions.SelectedIndex].ToString() == DS.Tables[0].Rows[i]["Repeticion"].ToString())
                    {
                        dgvDetail.Rows.Add();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmPosition.Index].Value = DS.Tables[0].Rows[i]["Posición"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCustomerType.Index].Value = DS.Tables[0].Rows[i]["TipoCliente"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCustomer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmOrder.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCoil.Index].Value = DS.Tables[0].Rows[i]["Bobina"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCoilLength.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Metraje"]);
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmWeigth.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmcuttingorderdetail.Index].Value = DS.Tables[0].Rows[i]["cuttingorderdetail"].ToString();
                        dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmGetWeigth.Index].Value = BPS.Lite.Properties.Resources.add_coil;
                        cstop = DS.Tables[0].Rows[i]["cuttingstop"].ToString();
                        if (DS.Tables[0].Rows[i]["Bobina"].ToString() != "N/D")
                        {
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmPosition.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCustomerType.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCustomer.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmOrder.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmProduct.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCoil.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmCoilLength.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmWeigth.Index].Style.BackColor = Color.LightGreen;
                            dgvDetail.Rows[dgvDetail.Rows.Count - 1].Cells[clmGetWeigth.Index].Style.BackColor = Color.LightGreen;
                        }
                    }
                }

                if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"])==0)
                {
                    getMainCoils(cstop);

                    dgvMainCoil.Rows.Clear();

                    metRep = 0;

                    if (DS2.Tables.Count > 0 && DS2.Tables[0].Rows.Count > 0)
                    {

                        for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                        {
                            dgvMainCoil.Rows.Add();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmMainCoilCodsec.Index].Value = DS2.Tables[0].Rows[i]["Maincoilcodsec"].ToString();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmMainCoilCode.Index].Value = DS2.Tables[0].Rows[i]["Maincoil"].ToString();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmLength.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Metraje"]);
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmDelete.Index].Value = BPS.Lite.Properties.Resources.action_delete_sharp_thin;
                            metRep += Convert.ToInt32(DS2.Tables[0].Rows[i]["Metraje"]);
                        }
                    }
                }

                if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"]) == 1)
                {
                    getSecundaryCoils(cstop);

                    dgvMainCoil.Rows.Clear();

                    metRep = 0;

                    if (DS3.Tables.Count > 0 && DS3.Tables[0].Rows.Count > 0)
                    {

                        for (int i = 0; i < DS3.Tables[0].Rows.Count; i++)
                        {
                            dgvMainCoil.Rows.Add();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmMainCoilCodsec.Index].Value = DS3.Tables[0].Rows[i]["Maincoilcodsec"].ToString();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmMainCoilCode.Index].Value = DS3.Tables[0].Rows[i]["Maincoil"].ToString();
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmLength.Index].Value = Convert.ToInt32(DS3.Tables[0].Rows[i]["Metraje"]);
                            dgvMainCoil.Rows[dgvMainCoil.Rows.Count - 1].Cells[clmDelete.Index].Value = BPS.Lite.Properties.Resources.action_delete_sharp_thin;

                            metRep += Convert.ToInt32(DS3.Tables[0].Rows[i]["Metraje"]);
                        }
                    }
                }
                
                if(txtRepStatus.Text=="Abierta")
                {
                    cmbDigit.Enabled = true;
                    cmbOper.Enabled = true;
                    cmbSuper.Enabled = true;
                    txtMainCoil.Enabled = true;
                    txtMetr.Enabled = true;
                }
                else
                {
                    cmbDigit.Enabled = false;
                    cmbOper.Enabled = false;
                    cmbSuper.Enabled = false;
                    txtMainCoil.Enabled = false;
                    txtMetr.Enabled = false;
                }
            }
        }

        private void cmbRepetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            filldata();
        }

        //Metodo para agregar consumos de bobinas/bobinas madre
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRepStatus.Text == "Abierta")
            {
                if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"]) == 0)
                {
                    clsMainCoil objMainCoil = new clsMainCoil(txtMainCoil.Text);

                    if (objMainCoil.codsec > 0)
                    {
                        if (clsGlobal.isNumeric(txtMetr.Text))
                        {
                            if (objMainCoil.BoppCode == txtFilm.Text || objMainCoil.CastCode == txtFilm.Text || objMainCoil.CoatingCode == txtFilm.Text || clsBopp.isEquivalent(objMainCoil.fkBopp,txtFilm.Text))
                            {
                                if (objMainCoil.netlength - objMainCoil.usedLength - Convert.ToDouble(txtMetr.Text) > 0)
                                {
                                    clsMainCoilByCuttingStop objMainCoilByCuttingStop = new clsMainCoilByCuttingStop();
                                    objMainCoilByCuttingStop.fkCuttingStop = Convert.ToInt32(cstop);
                                    objMainCoilByCuttingStop.fkMainCoil = objMainCoil.codsec;
                                    objMainCoilByCuttingStop.length = Convert.ToDouble(txtMetr.Text);
                                    objMainCoilByCuttingStop.save();

                                    if (objMainCoil.netlength - objMainCoil.usedLength - Convert.ToDouble(txtMetr.Text) < objMainCoil.netlength * 0.05)
                                    {
                                        if (MessageBox.Show("La bobina madre esta próxima a terminarse o ya se terminó, ¿desea cerrarla?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            objMainCoil.changeStatus("Cerrada");
                                    }
                                    else
                                    {
                                        objMainCoil.changeStatus("En proceso");
                                    }
                                }
                                else
                                {
                                    if (objMainCoil.netlength - objMainCoil.usedLength - Convert.ToDouble(txtMetr.Text) == 0)
                                    {
                                        clsMainCoilByCuttingStop objMainCoilByCuttingStop = new clsMainCoilByCuttingStop();
                                        objMainCoilByCuttingStop.fkCuttingStop = Convert.ToInt32(cstop);
                                        objMainCoilByCuttingStop.fkMainCoil = objMainCoil.codsec;
                                        objMainCoilByCuttingStop.length = Convert.ToDouble(txtMetr.Text);
                                        objMainCoilByCuttingStop.save();

                                        objMainCoil.changeStatus("Cerrada");
                                        MessageBox.Show("Se cerró la bobina madre porque se consumieron todos los metros disponibles.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pueden consumir " + txtMetr.Text + " metros, debido a que la bobina seleccionada solo tiene " + (objMainCoil.netlength - objMainCoil.usedLength).ToString()+" metros disponibles.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtMetr.Focus();
                                    }
                                }
                                
                                txtMainCoil.Text = "";
                                txtMetr.Text = "";
                                txtMainCoil.Focus();
                                getDataSet(txtCuttingOrder.Text);
                                filldata();

                            }
                            else
                            {
                                MessageBox.Show("La película de la bobina madre seleccionada no coincide con la requerida en la orden de corte.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                objMainCoil = new clsMainCoil();
                                txtMainCoil.Text = "";
                                txtMetr.Text = "0";
                                txtMainCoil.Focus();
                            }
                        }
                        else
                            MessageBox.Show("El valor debe ser numérico.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a una bobina madre.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"]) == 1)
                {
                    if (clsGlobal.isNumeric(txtMetr.Text))
                    {
                        if (txtMainCoil.Text != string.Empty)
                        {
                            clsCoil objCoil = new clsCoil();
                            objCoil = clsCoil.getDetailByCode(txtMainCoil.Text);

                            if (objCoil.codsec > 0)
                            {
                                if (objCoil.Coil_CoilCellarContainer.name == "Conversión" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso" || objCoil.Coil_CoilCellarContainer.name == "Bobinas Base y metalizado" || objCoil.Coil_CoilCellarContainer.name == "Corte, metalizado y empaque" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso Pilar" || objCoil.Coil_CoilCellarContainer.name == "Rack Metalizado")
                                {
                                    if (objCoil.statusName == "Activa")
                                    {
                                        clsProduct ObjProduct = new clsProduct(objCoil.fkProduct);

                                        if (ObjProduct.boppCode != string.Empty)
                                        {

                                            if (ObjProduct.boppCode == txtFilm.Text || clsBopp.isEquivalent(ObjProduct.fkBopp,txtFilm.Text))
                                            {
                                                clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                                if (objOriginPallet.codsec == 0)
                                                {
                                                    DataSet DS4 = new DataSet();

                                                    DS4 = clsConnection.getDataSetResult("CALL spUsedLengthByCoil(" + objCoil.codsec.ToString() + ")");

                                                    if (DS4.Tables[0].Rows.Count > 0)
                                                    {
                                                        if (objCoil.length - Convert.ToDouble(DS4.Tables[0].Rows[0]["usedLen"])-Convert.ToDouble(txtMetr.Text)>0)
                                                        {
                                                            clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                            objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(cstop);
                                                            objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                            objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtMetr.Text);
                                                            objCoilBySecundaryCuttingStop.save();

                                                            if (MessageBox.Show("Ya se usaron " + (Convert.ToDouble(DS4.Tables[0].Rows[0]["usedLen"]) + Convert.ToDouble(txtMetr.Text)).ToString() + " metros de un total de " + objCoil.length.ToString() + ". ¿Desea cerrar la bobina?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                                clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                        }
                                                        else
                                                        {
                                                            if (objCoil.length - Convert.ToDouble(DS4.Tables[0].Rows[0]["usedLen"]) - Convert.ToDouble(txtMetr.Text) == 0)
                                                            {
                                                                clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                                objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(cstop);
                                                                objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                                objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtMetr.Text);
                                                                objCoilBySecundaryCuttingStop.save();

                                                                clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                                MessageBox.Show("Se cerró la bobina madre porque se consumieron todos los metros disponibles.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("No se pueden consumir " + txtMetr.Text + " metros, debido a que la bobina seleccionada solo tiene " + (objCoil.length - Convert.ToDouble(DS4.Tables[0].Rows[0]["usedLen"])).ToString() + " metros disponibles.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                txtMetr.Focus();
                                                            }
                                                        }
                                                        
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Se produjo un error, consulte a sistemas");
                                                    }


                                                    txtMainCoil.Text = "";
                                                    txtMetr.Text = "";
                                                    txtMainCoil.Focus();
                                                    getDataSet(txtCuttingOrder.Text);
                                                    filldata();

                                                }
                                                else
                                                {
                                                    MessageBox.Show("No se puede reprocesar una bobina que este dentro de un pallet. Quite la bobina del pallet para poder reprocesar.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("La orden de corte requiere " + txtFilm.Text + " y la bobina seleccionada es " + ObjProduct.code + ". para poder reprocesar, debe ingresar una bobina con la misma película de la orden de corte", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtMainCoil.Text = string.Empty;
                                                txtMetr.Text = string.Empty;
                                                txtMainCoil.Focus();
                                            }
                                        }
                                        else if (ObjProduct.castCode != string.Empty)
                                        {

                                            if (ObjProduct.castCode == txtFilm.Text)
                                            {
                                                clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                                if (objOriginPallet.codsec == 0)
                                                {

                                                    clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                    objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(cstop);
                                                    objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                    objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtMetr.Text);
                                                    objCoilBySecundaryCuttingStop.save();

                                                    DataSet DS4 = new DataSet();

                                                    DS4 = clsConnection.getDataSetResult("CALL spUsedLengthByCoil(" + objCoil.codsec.ToString() + ")");

                                                    if (DS4.Tables[0].Rows.Count > 0)
                                                    {
                                                        if (MessageBox.Show("Ya se usaron " + DS4.Tables[0].Rows[0]["usedLen"].ToString() + " metros de un total de " + objCoil.length.ToString() + ". ¿Desea cerrar la bobina?", "Notificación de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                            clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Se produjo un error, consulte a sistemas");
                                                    }


                                                    txtMainCoil.Text = "";
                                                    txtMetr.Text = "";
                                                    txtMainCoil.Focus();
                                                    getDataSet(txtCuttingOrder.Text);
                                                    filldata();

                                                }
                                                else
                                                {
                                                    MessageBox.Show("No se puede reprocesar una bobina que este dentro de un pallet. Quite la bobina del pallet para poder reprocesar.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("La orden de corte requiere " + txtFilm.Text + " y la bobina seleccionada es " + ObjProduct.code + ". para poder reprocesar, debe ingresar una bobina con la misma película de la orden de corte", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtMainCoil.Text = string.Empty;
                                                txtMetr.Text = string.Empty;
                                                txtMainCoil.Focus();
                                            }

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtMainCoil.Text = string.Empty;
                                        txtMetr.Text = string.Empty;
                                        txtMainCoil.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La bobina seleccionada se encuentra en la bodega de " + objCoil.Coil_CoilCellarContainer.name + " es necesario que las bobinas o el pallets\r\n Se encuentre en CORTE o PRODUCTO EN PROCESO para que pueda ingresar al reproceso.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtMainCoil.Text = string.Empty;
                                    txtMetr.Text = string.Empty;
                                    txtMainCoil.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMainCoil.Text = string.Empty;
                                txtMetr.Text = string.Empty;
                                txtMainCoil.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMainCoil.Text = string.Empty;
                            txtMetr.Text = string.Empty;
                            txtMainCoil.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Para poder adicionar una bobina de reproceso debe llenar los campos de Código y Metraje.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMainCoil.Text = string.Empty;
                        txtMetr.Text = string.Empty;
                        txtMainCoil.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar una repetición cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMainCoil.Text = string.Empty;
                txtMetr.Text = string.Empty;
                txtMainCoil.Focus();

            }
            
        }

        //metodo para eliminar consumos de bobinas madre
        private void dgvMainCoil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmDelete.Index)
            {
                if (txtRepStatus.Text == "Abierta")
                {
                    if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"]) == 0)
                    {
                        if (MessageBox.Show("¿Desea deshacer el consumo de la bobina madre seleccionada?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<clsMainCoilByCuttingStop> lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(Convert.ToInt32(cstop));

                            for (int i = 0; i < lstMainCoilByCuttingStop.Count; i++)
                            {
                                if (lstMainCoilByCuttingStop[i].fkMainCoil == Convert.ToInt32(dgvMainCoil.Rows[e.RowIndex].Cells[clmMainCoilCodsec.Index].Value))
                                {
                                    clsMainCoilByCuttingStop.delete(lstMainCoilByCuttingStop[i].codsec);
                                    i = lstMainCoilByCuttingStop.Count;
                                }
                            }

                            getDataSet(txtCuttingOrder.Text);
                            filldata();
                        }
                    }

                    if (Convert.ToInt32(DS.Tables[0].Rows[0]["Secundaria"]) == 1)
                    {
                        if (MessageBox.Show("¿Desea deshacer el consumo de la bobina seleccionada?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<clsCoilBySecundaryCuttingStop> lstCoilBySecundaryCuttingStop = clsCoilBySecundaryCuttingStop.getListByCuttingStop(Convert.ToInt32(cstop));

                            for (int i = 0; i < lstCoilBySecundaryCuttingStop.Count; i++)
                            {
                                if (lstCoilBySecundaryCuttingStop[i].fkCoil == Convert.ToInt32(dgvMainCoil.Rows[e.RowIndex].Cells[clmMainCoilCodsec.Index].Value))
                                {
                                    clsCoilBySecundaryCuttingStop.delete(lstCoilBySecundaryCuttingStop[i].codsec);
                                    i = lstCoilBySecundaryCuttingStop.Count;
                                }
                            }

                            getDataSet(txtCuttingOrder.Text);
                            filldata();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar una repetición cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMainCoil.Text = string.Empty;
                    txtMetr.Text = string.Empty;
                    txtMainCoil.Focus();

                }
            }
            
        }

        private void cmbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!starting)
            {
                if (txtRepStatus.Text == "Abierta")
                {
                    if (cmbOper.SelectedIndex != -1)
                    {
                        if (cstop != "")
                        {
                            clsCuttingStop objstop = new clsCuttingStop(Convert.ToInt32(cstop));

                            if (objstop.codsec != 0)
                            {

                                clsUser oper = new clsUser(cmbOper.Items[cmbOper.SelectedIndex].ToString());

                                if (oper.codsec != 0)
                                {
                                    objstop.operatedBy = oper.codsec;
                                    objstop.save();
                                }
                            }

                        }
                    }
                }
            }
            
        }

        private void cmbDigit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!starting)
            {
                if (txtRepStatus.Text == "Abierta")
                {
                    if (cmbDigit.SelectedIndex != -1)
                    {
                        if (cstop != "")
                        {
                            clsCuttingStop objstop = new clsCuttingStop(Convert.ToInt32(cstop));

                            if (objstop.codsec != 0)
                            {

                                clsUser oper = new clsUser(cmbDigit.Items[cmbDigit.SelectedIndex].ToString());

                                if (oper.codsec != 0)
                                {
                                    objstop.digitizedBy = oper.codsec;
                                    objstop.save();
                                }
                            }
                        }
                    }

                }
            }
            
        }

        private void cmbSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!starting)
            {
                if (txtRepStatus.Text == "Abierta")
                {
                    if (cmbSuper.SelectedIndex != -1)
                    {
                        if (cstop != "")
                        {
                            clsCuttingStop objstop = new clsCuttingStop(Convert.ToInt32(cstop));

                            if (objstop.codsec != 0)
                            {

                                clsUser oper = new clsUser(cmbSuper.Items[cmbSuper.SelectedIndex].ToString());

                                if (oper.codsec != 0)
                                {
                                    objstop.supervisedBy = oper.codsec;
                                    objstop.save();
                                }


                            }
                        }
                    }

                }
            }
            
        }

        private bool stopCloseAvailable()
        {
            bool ret = true;
            bool digit = true;

            if (dgvDetail.Rows[0].Cells[clmCoil.Index].Value.ToString() == "N/D")
            {
                digit = false;
            }
            else
            {
                digit = true;
            }

            for(int i=0;i<dgvDetail.Rows.Count;i++)
            {
                if(digit)
                {
                    if(dgvDetail.Rows[i].Cells[clmCoil.Index].Value.ToString() == "N/D")
                    {
                        ret = false;
                    }
                }
                else
                {
                    if (dgvDetail.Rows[i].Cells[clmCoil.Index].Value.ToString() != "N/D")
                    {
                        ret = false;
                    }
                }
            }

            return ret;
        }

        //Metodo para cerrar la repetición
        private void button2_Click(object sender, EventArgs e)
        {
            getDataSet(txtCuttingOrder.Text);
            filldata();

            if(stopCloseAvailable())
            {
                if (txtRepStatus.Text == "Abierta")
                {
                    if (MessageBox.Show("Está a punto de cerrar la repetición, si lo hace no podrá hacer nuevas modificaciones y no podrá reabrirla. ¿Confirma que desea cerrarla?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool disp = true;

                        if (cmbOper.SelectedIndex == -1 || cmbDigit.SelectedIndex == -1 || cmbSuper.SelectedIndex == -1 || dgvMainCoil.Rows.Count == 0)
                        {
                            disp = false;
                        }

                        if (disp)
                        {
                            clsCuttingStop objstop = new clsCuttingStop(Convert.ToInt32(cstop));
                            objstop.closed = true;
                            objstop.save();
                            MessageBox.Show("Se cerró la repetición correctamente.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede cerrar la repetición si no se cargaron los siguientes datos: digitador, operador, supervisor y rollos madre.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede cerrar la repetición. Para poder cerrar tienen que estar digitadas todas las posiciones o no tiene que estar digitada ninguna.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool cuttingOrderCloseAvailable()
        {
            bool ret = true;

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["ParadaCerrada"]) != 1)
                    {
                        ret = false;
                        break;
                    }
                }
            }

            return ret;
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea suspender temporalmente la orden de corte?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsCuttingOrder objCuttingOrder = new clsCuttingOrder(Convert.ToInt32(txtCuttingOrder.Text));
                objCuttingOrder.changeStatus("En pausa");
                MessageBox.Show("La orden de corte ha sido pausada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(objCuttingOrder.fkMachine, true);
                winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                winCuttingOrderList.MdiParent = this.MdiParent;
                winCuttingOrderList.Show();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            getDataSet(txtCuttingOrder.Text);
            filldata();

            if(cuttingOrderCloseAvailable())
            {
                if (MessageBox.Show("¿Desea cerrar permanentemente la orden de corte?", "Notificación de orden de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsCuttingOrder objCuttingOrder = new clsCuttingOrder(Convert.ToInt32(txtCuttingOrder.Text));
                    objCuttingOrder.changeStatus("Cerrada");
                    MessageBox.Show("La orden de corte ha sido cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(objCuttingOrder.fkMachine, true);
                    winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    winCuttingOrderList.MdiParent = this.MdiParent;
                    winCuttingOrderList.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se puede cerrar la orden de corte. Para poder cerrarla, todas las repeticiones deben estar cerradas.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmGetWeigth.Index)
            {
                
                if(txtRepStatus.Text=="Abierta")
                {
                    if(cmbOper.SelectedIndex!=-1 && cmbDigit.SelectedIndex!=-1 && cmbSuper.SelectedIndex!=-1 && dgvMainCoil.Rows.Count>0)
                    {
                        clsMainCoil objmain = new clsMainCoil(Convert.ToInt32(dgvMainCoil.Rows[0].Cells[clmMainCoilCodsec.Index].Value));
                        string coillot;
                        string coilcode;
                        bool isImported = false;

                        if(objmain.codsec!=0)
                        {
                            coillot = objmain.lotNumber.Substring(0, objmain.lotNumber.Length - 1);
                            coilcode = objmain.code;
                        }
                        else
                        {
                            clsCoil objseccoil = new clsCoil(Convert.ToInt32(dgvMainCoil.Rows[0].Cells[clmMainCoilCodsec.Index].Value));
                            coillot = objseccoil.lotNumber;
                            coilcode = objseccoil.code;
                            isImported = Convert.ToBoolean(objseccoil.isExternalCoil); // Le manda el parametro para saber si la bobina es importada o no, para seguir manteniendo ésto y no perderlo.
                        }


                        frmNewCoilRegistration winCuttingOrderList = new frmNewCoilRegistration(txtCuttingOrder.Text, cmbRepetitions.Items[cmbRepetitions.SelectedIndex].ToString(), dgvDetail.Rows[e.RowIndex].Cells[clmPosition.Index].Value.ToString(), dgvDetail.Rows[e.RowIndex].Cells[clmCustomer.Index].Value.ToString(), dgvDetail.Rows[e.RowIndex].Cells[clmOrder.Index].Value.ToString(), dgvDetail.Rows[e.RowIndex].Cells[clmProduct.Index].Value.ToString(), metRep.ToString(), coillot, coilcode, cstop, dgvDetail.Rows[e.RowIndex].Cells[clmcuttingorderdetail.Index].Value.ToString(), isImported);
                        winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                        //winCuttingOrderList.MdiParent = this.MdiParent;
                        winCuttingOrderList.ShowDialog();
                        

                        getDataSet(txtCuttingOrder.Text);
                        filldata();
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar o digitar una repetición si no se cargaron los siguientes datos: digitador, operador, supervisor y rollos madre.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar o digitar una repetición que se encuentra cerrada.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void frmCuttingOrderNotification_Load(object sender, EventArgs e)
        {

        }

        private void txtMainCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtMetr.Focus();
            }
        }

        private void txtMetr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }
    }
}
