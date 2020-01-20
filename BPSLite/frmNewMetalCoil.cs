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
    public partial class frmNewMetalCoil : Form
    {
        clsCoil coil = new clsCoil();   
        clsNewProductionOrderMetal npom = new clsNewProductionOrderMetal();
        clsNewProductionOrderMetalDetail npomdetail = new clsNewProductionOrderMetalDetail();
        clsCoilByBaseConsuption consumo = new clsCoilByBaseConsuption();
        List<string> lstBobinasNV = new List<string>();
        string mensajeErrorNV;
        clsCoilByBaseConsuption consumoBase = new clsCoilByBaseConsuption();


        clsCoil bobBase = new clsCoil();
        clsMainCoilMetal coilmetal = new clsMainCoilMetal();

        string Lote;
        int orden;

        public frmNewMetalCoil(string lote)
        {
            InitializeComponent();
            Lote = lote;
            npom = new clsNewProductionOrderMetal(lote);
            orden = npom.codsec;
            cargarDGv();
        }

        private void cargarDGv()
        {
            DataSet DS = new DataSet();

            DS = clsNewProductionOrderMetal.getDetailByOrder(orden);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0 )
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCoilsToCharge.Rows.Add();
                    dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["ancho"].ToString();
                    dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmCodBase.Index].Value = DS.Tables[0].Rows[i]["bcode"].ToString();
                    dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmCodeBob.Index].Value = DS.Tables[0].Rows[i]["codigo"].ToString();
                    dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmProducto.Index].Value = DS.Tables[0].Rows[i]["codigoProd"].ToString();
                    dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = DS.Tables[0].Rows[i]["pesoBobina"].ToString(); 
                }
            }
        }

        private void btnAddBase_Click(object sender, EventArgs e)
        {
            if (npom.fkStatus == 1066)
            {
                if (txtCodigoBase.Text != string.Empty && txtMetros.Text != string.Empty)
                {
                    coil = clsCoil.getDetailByCode(txtCodigoBase.Text);
                    if (coil.codsec != 0)
                    {
                        if (coil.fkCoilCellar == 11 || coil.fkCoilCellar == 3012 || coil.fkCoilCellar == 2011 || coil.fkCoilCellar == 4014 || coil.fkCoilCellar == 4015 || coil.fkCoilCellar == 4017)
                        {
                            if (coil.fkStatus == 33 || coil.fkStatus == 34)
                            {
                                if (sepuedeConsumir(coil,Convert.ToInt32(txtMetros.Text)))
                                {
                                    consumoBase.fkCoil = coil.codsec;
                                    consumoBase.fkNewMetalOrder = npom.codsec;
                                    consumoBase.length = Convert.ToInt32(txtMetros.Text);

                                    if (consumoBase.save())
                                    {
                                        dgvBaseConsuption.Rows.Add();
                                        dgvBaseConsuption.Rows[dgvBaseConsuption.Rows.Count - 1].Cells[clmBobBase.Index].Value = txtCodigoBase.Text;
                                        dgvBaseConsuption.Rows[dgvBaseConsuption.Rows.Count - 1].Cells[clmConsumo.Index].Value = txtMetros.Text;

                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmCodeBob.Index].Value = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + "M" + clsGlobal.FillWithZeros(((new clsSequential().mainCoilMetal).ToString()), 4); ;
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmBobBase.Index].Value = txtCodigoBase.Text;
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = coil.netWeight;
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmProducto.Index].Value = new clsProduct(coil.fkProduct).code.ToString();
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmFilmInit.Index].Value = new clsBopp(coil.fkBopp).code;
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmFilmFinal.Index].Value = lblMetalizado.Text;
                                        dgvCoilsToCharge.Rows[dgvCoilsToCharge.Rows.Count - 1].Cells[clmAncho.Index].Value = coil.width;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo cargar el consumo debido algun error del sistema. Por favor contacte al Administrador.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se puede consumir mas de lo que tiene la bobina.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La bobina debe encontrarse en estado activo para poder metalizarla.", "Advertecia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede ingresar la bobina ya que se encuentra en bodega de " + new clsCoilCellar(coil.fkCoilCellar).name + " y debe encontrarse en bodega de PROCESO\r\n Solicite a Bodega que liberen dicho material", "Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código de Bobina ingresado es erroneo o no existe. Por favor, contacte con el Administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos solicitados para cargar la base.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
        
        private void txtCodigoBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigoBase.Text != string.Empty)
                {
                    coil = clsCoil.getDetailByCode(txtCodigoBase.Text);

                    if (coil.fkStatus == 33)
                    {
                        double metACons = coil.length - coil.getUsedLength(coil.codsec);
                        txtMetros.Text = metACons.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La bobina se debe encontrar activa para poder realizar consumos de metalizado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete el código de bobina base.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (npom.fkStatus == 1066)
            {
                dgvBaseConsuption.Enabled = false;
                dgvCoilsToCharge.Enabled = false;
                btnAddBase.Enabled = false;

                npom.fkStatus = 1069;
                if(npom.save())
                {
                    btnPlayStop.Image = Properties.Resources.Play_Hot;
                    btnPlayStop.Text = "Play";
                }

            }
            else if (npom.fkStatus == 1069)
            {
                btnAddBase.Enabled = true;
                dgvBaseConsuption.Enabled = true;
                dgvCoilsToCharge.Enabled = true;

                npom.fkStatus = 1066;

                if (npom.save())
                {
                    btnPlayStop.Image = Properties.Resources.Pause_Hot;
                    btnPlayStop.Text = "Stop";
                }
            }
        }

        private void frmNewMetalCoil_Load(object sender, EventArgs e)
        {
            if (npom.fkStatus == 1066)
            {
                btnPlayStop.Image = Properties.Resources.Pause_Hot;
                btnPlayStop.Text = "Stop";
                grpAddBase.Enabled = true;
                dgvCoilsToCharge.Enabled = true;
            }
            else if (npom.fkStatus == 1069)
            {
                btnPlayStop.Image = Properties.Resources.Play_Hot;
                btnPlayStop.Text = "Play";
                grpAddBase.Enabled = false;
                dgvCoilsToCharge.Enabled = false;
            }
          
        }   

        private int encontrarCodigo(string codigo)
        {
            int rowIndex = 0;

            for (int i = 0; i < dgvCoilsToCharge.Rows.Count; i++)
            {
                if (codigo == dgvCoilsToCharge.Rows[i].Cells[clmCodBase.Index].Value.ToString())
                {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }

        private void dgvCoilsToCharge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmValidar.Index)
            {

                bobBase = clsCoil.getDetailByCode(dgvCoilsToCharge.Rows[e.RowIndex].Cells[clmCodBase.Index].Value.ToString());

                coilmetal = new clsMainCoilMetal();

                coilmetal.bcode = bobBase.code;
                coilmetal.createdBy = clsGlobal.LoggedUser.codsec;
                coilmetal.createdDate = DateTime.Now;
                coilmetal.fkBoppFrom = npom.fkFilmInit;
                coilmetal.fkBoppTo = npom.fkMachine;
                coilmetal.fkProductFrom = bobBase.fkProduct;
                coilmetal.fkProductionOrder = npom.codsec;
                coilmetal.fkProductTo = new clsProduct(new clsBopp(npom.fkFilmFin).code + "x" + bobBase.width.ToString() + bobBase.diameter.ToString()).codsec;
                //coilmetal.fkStatus = 

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwNewProdOrdMetKgByOrder WHERE codsecnpom = " + npom.codsec);

            if (Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadAProducir"]) > Convert.ToDouble(DS.Tables[0].Rows[0]["pesoProducido"]))
            {
                var reslt = MessageBox.Show("Esta a punto de cerrar una orden incompleta. \n ¿Está segúro de realizar esta acción?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (reslt)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        
                        if (validaronLasBobs())
                        {
                            npom.fkStatus = 47;

                            if (npom.save())
                            {
                                MessageBox.Show("La orden " + npom.lote + " fue cerrada conexito. Recuerde que no podra re-abrirla.", "Exito", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cerrar la orden debido a un error de sistema. Por favor, contacte con el Administrador del Sistema.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            var resultado = MessageBox.Show(mensajeErrorNV + " ¿Esta seguro de realizar esta acción?","Advertencia",MessageBoxButtons.YesNo);

                            switch (resultado)
                            {
                                case DialogResult.No:

                                    break;
                                case DialogResult.Yes:
                                    quitarbobinasNV();

                                    if (validaronLasBobs() && validarBases())
                                    {
                                        npom.fkStatus = 47;

                                        if (npom.save())
                                        {
                                            MessageBox.Show("La orden " + npom.lote + " fue cerrada conexito. Recuerde que no podra re-abrirla.", "Exito", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo cerrar la orden debido a un error de sistema. Por favor, contacte con el Administrador del Sistema.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            
            }
            else if (Convert.ToDouble(DS.Tables[0].Rows[0]["CantidadAProducir"]) <= Convert.ToDouble(DS.Tables[0].Rows[0]["pesoProducido"]))
            {
               var reslt = MessageBox.Show("Esta a punto de cerrar una orden completa. \n ¿Está segúro de realizar esta acción?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }

        #region Funciones privadas

        private bool validaronLasBobs()
        {
            bool valida = true;

            foreach (DataGridViewRow row in dgvCoilsToCharge.Rows)
            {
                if (row.Cells[clmCodeBob.Index].Value.ToString() == "N/V")
                {
                    mensajeErrorNV += "Las siguientes bobinas se van a liberar a stock debido a que no fueron validadas y esta por cerrar la orden " + row.Cells[clmCodBase.Index].Value.ToString() + "\n";
                    lstBobinasNV.Add(row.Cells[clmCodBase.Index].Value.ToString());
                    valida = false;
                }
            }

            return valida;
        }

        private bool validarBases()
        {
            bool novalidoBases = true;

            foreach (DataGridViewRow rows in dgvBaseConsuption.Rows)
            {
                for (int i = 0; i < lstBobinasNV.Count; i++)
                {
                    if (rows.Cells[clmCodBase.Index].Value.ToString() == lstBobinasNV[i])
                    {
                        novalidoBases = false;
                    }
                }
            }
            return novalidoBases;
        }

        private void quitarbobinasNV()
        {
            for (int i = 0; i < dgvBaseConsuption.Rows.Count; i++)
            {
                for (int j = 0; j < lstBobinasNV.Count; i++)
			    {
                    if (dgvBaseConsuption.Rows[i].Cells[clmCodBase.Index].Value.ToString() == lstBobinasNV[j])
                    {
                        dgvBaseConsuption.Rows.RemoveAt(i);
                    }
			    }
            }

            for (int i = 0; i < dgvCoilsToCharge.Rows.Count; i++)
            {
                for (int j = 0; j < lstBobinasNV.Count; i++)
                {
                    if (dgvCoilsToCharge.Rows[i].Cells[clmCodBase.Index].Value.ToString() == lstBobinasNV[j])
                    {
                        dgvCoilsToCharge.Rows.RemoveAt(i);
                        lstBobinasNV.RemoveAt(j);
                    }
                }
            }
        }

        private bool sepuedeConsumir(clsCoil coil,int cantidadAConsumir)
        {
            bool sepuede = false;
            double metrosRestantes;

            metrosRestantes = Convert.ToDouble(coil.length) - Convert.ToDouble(coil.getUsedLength(coil.codsec)) - cantidadAConsumir;

            if (metrosRestantes >= 0)
            {
                sepuede = true;
            }

            return sepuede;
        }

        #endregion

    }

}
