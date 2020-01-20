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
    public partial class frmScrapMainCoilSend : Form
    {
        clsScrap Scrap = new clsScrap();
        clsMainCoil mainCoil = new clsMainCoil();
        clsScrapByExtruderCellar scrapCellar = new clsScrapByExtruderCellar();

        public frmScrapMainCoilSend()
        {
            InitializeComponent();
        }

        private void frmScrapMainCoilSend_Load(object sender, EventArgs e)
        {
            List<clsScrap> scrapList = new List<clsScrap>();
            scrapList = clsScrap.getList();

            for (int i = 0; i < scrapList.Count; i++)
            {
                cmbTipo.Items.Add(scrapList[i].name);
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            double netlength, netweigth, usedlength, usedweigth, currentweigth;

            if (e.KeyCode == Keys.Enter)
            {
                if (cmbTipo.Text != string.Empty)
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        clsMainCoil mainCoil = new clsMainCoil(txtCodigo.Text);

                        netlength = mainCoil.netlength;
                        netweigth = mainCoil.netWeigth;
                        usedlength = mainCoil.usedLength;
                        usedweigth = 0;
                        currentweigth = 0;

                        usedweigth = ((usedlength * netweigth) / netlength);

                        currentweigth = netweigth - usedweigth;

                        if (mainCoil.codsec != 0)
                        {
                            if (mainCoil.fkStatus == 50) // Preguntar estado de bobinas madres.
                            {
                                if (currentweigth > 0)
                                {
                                    if (dgvMainCoilSend.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow row in dgvMainCoilSend.Rows)
                                        {
                                            if (mainCoil.codsec == Convert.ToInt32(row.Cells["clmCodsec"].Value))
                                            {
                                                MessageBox.Show("El codigo que intenta ingresar ya se encuentra Cargado", "¡Error!", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                dgvMainCoilSend.Rows.Add();
                                                dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmCodsec"].Value = mainCoil.codsec;
                                                dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmCodigo"].Value = mainCoil.code;
                                                dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmProducto"].Value = cmbTipo.Text;
                                                dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmFecha"].Value = Convert.ToString(DateTime.Now);
                                                dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmPeso"].Value = currentweigth;

                                                txtCodigo.ResetText();
                                                cmbTipo.ResetText();
                                                break;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        dgvMainCoilSend.Rows.Add();
                                        dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmCodsec"].Value = mainCoil.codsec;
                                        dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmCodigo"].Value = mainCoil.code;
                                        dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmProducto"].Value = cmbTipo.Text;
                                        dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmPeso"].Value = currentweigth;
                                        dgvMainCoilSend.Rows[dgvMainCoilSend.Rows.Count - 1].Cells["clmFecha"].Value = Convert.ToString(DateTime.Now);

                                        txtCodigo.ResetText();
                                        cmbTipo.ResetText();
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("La bobina madre que intenta agregar ya se consumió por completo.", "¡Error!", MessageBoxButtons.OK);

                                    txtCodigo.ResetText();
                                    cmbTipo.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("La bobina que intenta agregar ya esta dada de baja", "¡Error!", MessageBoxButtons.OK);

                                txtCodigo.ResetText();
                                cmbTipo.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La bobina madre que intenta cargar es inexistente o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);

                            txtCodigo.ResetText();
                            cmbTipo.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el código de bobina madre", "¡Error!", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Complete el tipo de merma que desea Cargar", "¡Error!", MessageBoxButtons.OK);
                }
            }
        }

        private void cmbTipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMainCoilSend.Rows.Count; i++)
            {
                Scrap = new clsScrap(dgvMainCoilSend.Rows[i].Cells[clmProducto.Index].Value.ToString());
                mainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoilSend.Rows[i].Cells[clmCodsec.Index].Value));
                mainCoil.delete(); // Este es el metodo que updatea el status.

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4022);
                    //scrapCellar.acuWeigth(Convert.ToDouble(dgvBobinaMadre.Rows[i].Cells[clmMCNetWeigth.Index].Value)); 
                }
                else
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4023);
                    //scrapCellar.acuWeigth(mainCoil.netWeigth); 

                }

                clsScrapMovements movimientos = new clsScrapMovements();


                movimientos.fkScrap = Convert.ToInt32(Scrap.codsec);
                movimientos.type = "Movimiento de Bobina Madre";
                movimientos.fkMainCoil = mainCoil.codsec;
                movimientos.fkUser = clsGlobal.LoggedUser.codsec;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    movimientos.fkDestinationCellar = 4022;
                    movimientos.fkOriginalCellar = 4022;
                }
                else
                {
                    movimientos.fkDestinationCellar = 4023;
                    movimientos.fkOriginalCellar = 4023;
                }
                movimientos.save();

            }

            if (dgvMainCoilSend.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }
            else
            {
                dgvMainCoilSend.Rows.Clear();
                MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            }
        }
    }
}
