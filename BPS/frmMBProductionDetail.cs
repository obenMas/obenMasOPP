using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace BPS
{
    public partial class frmMBProductionDetail : Form
    {
        int machine = 0;
        int primcutter = 0;
        int seccutter = 0;
        clsRawMaterial rawMat = new clsRawMaterial();


        public frmMBProductionDetail()
        {
            InitializeComponent();
        }

        public frmMBProductionDetail(clsPlant plant, DateTime from, DateTime to, string identifier)
        {
            InitializeComponent();

            cmbPlant.Items.Add(plant.name);
            cmbPlant.SelectedIndex = 0;

            dtpFrom.Value = from;
            dtpTo.Value = to;

            hideAll();
            populateDatagrid(plant,from,to,identifier);
        }

        private void populateDatagrid(clsPlant plant, DateTime from, DateTime to, string identifier)
        {
            double total = 0;

            if (plant.codsec == 3)
            {
                machine = 11;
                primcutter = 10;
                seccutter = 3012;
            }
            else
            {
                machine = 3024;
                primcutter = 3025;
                seccutter = 3026;
            }

            #region Produccion de Extrusion
            if (identifier == "prodExtru")
            {
                this.Text = "Detalle de Producción de Extrusión";
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                string querystring = "EXECUTE spMainCoilReportByDateAndPlantTotalizedbyFilm '" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + "";
                DataSet DS = clsConnection.getDataSetResult(querystring);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = DS.Tables[0].Rows[i]["Extrusora"].ToString();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000;
                    }
                }

                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Scrap Extrusion Teorico
            else if (identifier == "scrapTeoExtru")
            {
                dgv.Columns[clmScrap.Index].Visible = true;

                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = "ACA NO PUEDO PONER NADA POR AHORA, POR QUE NO SE COMO RESTAR MP A FILMS";
                //Aca no hacemos nada ya que no tengo absolutamente ninguna manera de poder descontar MP de un film.
            }
            #endregion

            #region % de Recuperado Extrusion
            else if (identifier == "porcentScrap")
            {
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Porcentaje de recuperado Extrusión";

                DataSet CExtrusion = new DataSet();
                DataSet Recu = new DataSet();

                Recu = clsConnection.getDataSetResult("CALL spRecRawByDateByRaw('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");
                CExtrusion = calculatingConsume(plant, from, to);


                for (int i = 0; i < Recu.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < CExtrusion.Tables[0].Rows.Count; j++)
                    {
                        if (CExtrusion.Tables[0].Rows[j]["codRaw"].ToString() == Recu.Tables[0].Rows[i]["codeMP"].ToString())
                        {
                            Recu.Tables[0].Rows[i]["MPTotal"] = Math.Round(Convert.ToDouble(Recu.Tables[0].Rows[i]["MPTotal"]) / Convert.ToDouble(CExtrusion.Tables[0].Rows[j]["TotalDepot"]), 2);
                        }
                    }
                }

                if (Recu.Tables.Count > 0 && Recu.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Recu.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = Recu.Tables[0].Rows[i]["codeMP"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(Recu.Tables[0].Rows[i]["MPTotal"]) / 100).ToString("0.00");
                        total += Convert.ToDouble(Recu.Tables[0].Rows[i]["MPTotal"]);
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Consumo Extrusión
            else if (identifier == "consumoExtrusion")
            {
                this.Text = "Detalle de Consumo de Extrusión";
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                string machine = "";

                DataSet InitMPDepot = new DataSet();
                if (plant.codsec == 4)
                {
                  machine = new clsExtruder(4).name.ToString();
      
                }
                else
                {
                  machine = new clsExtruder(3).name.ToString();
                }
             
                InitMPDepot = calculatingConsume(plant, from, to);

                if (InitMPDepot.Tables.Count > 0 && InitMPDepot.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < InitMPDepot.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = InitMPDepot.Tables[0].Rows[i]["codRaw"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = machine;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(InitMPDepot.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(InitMPDepot.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Produccion de Molino
            else if (identifier == "prodMolino")
            {
                this.Text = "Detalle de Producción de Molino";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spMillProductionSubTotalized ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {

                        rawMat = clsRawMaterial.getObjByCode(DS.Tables[0].Rows[i]["codMP"].ToString());
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = rawMat.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Produccion Scrap Molino
            else if (identifier == "scrapMolino")
            {
                this.Text = "Detalle de Producción de Scrap de Molino";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmScrap.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spMillProductionSubTotalizedByScrap ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["TipoMP"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Consumo Primario
            else if (identifier == "consumoPrimaria")
            {
                this.Text = "Detalle de Consumo Primario";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet InitRack = new DataSet();

                InitRack = calculatePrimaryConsume(plant, from, to);

                if (InitRack.Tables.Count > 0 && InitRack.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < InitRack.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = InitRack.Tables[0].Rows[i]["codeFilm"];
                        if (machine == 11)
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = "DMT";
                        }
                        else
                        {
                            dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = "BRUCKNER";
                        }
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(InitRack.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(InitRack.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
                dgv.Sort(clmFilm, ListSortDirection.Ascending);
            }
            #endregion

            #region Corte Primario Sin Bases
            else if (identifier == "cortePrimarioSinBases")
            {
                this.Text = "Detalle de Corte Primario sin Bases";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalByFilm ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Corte Primario Bases
            else if (identifier == "cortePrimarioBases")
            {
                this.Text = "Detalle de Corte Primario de Bases";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalByBaseFilm ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Corte Primario Total
            else if (identifier == "cortePrimarioTotal")
            {
                this.Text = "Detalle de Corte Primario Total";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmExtruder.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSubTotal ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmExtruder.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Scrap Teorico Corte Primario
            else if (identifier == "scrapTeoricoCorte")
            {
                // Ver bien este tema. Por que el detalle vdebria de mostrar negativos. 

                dgv.Columns[clmScrap.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet ConsuPrim = new DataSet();
                DataSet TotalCut = new DataSet();

                TotalCut = clsConnection.getDataSetResult("CALL spCuttingReportSubTotal ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");
                ConsuPrim = calculatePrimaryConsume(plant, from, to);



                for (int i = 0; i < TotalCut.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ConsuPrim.Tables[0].Rows.Count; j++)
                    {
                        if (ConsuPrim.Tables[0].Rows[j]["codeFilm"].ToString() == TotalCut.Tables[0].Rows[i]["codeFilm"].ToString())
                        {
                            ConsuPrim.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(ConsuPrim.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(TotalCut.Tables[0].Rows[i]["CorteTotal"]);
                            break;
                        }
                        else if (j + 1 == ConsuPrim.Tables[0].Rows.Count)
                        {
                            DataRow newConsumPrim = ConsuPrim.Tables[0].NewRow();
                            newConsumPrim["codeFilm"] = TotalCut.Tables[0].Rows[i]["codeFilm"];
                            newConsumPrim["RackTotal"] = -1 * Convert.ToDouble(TotalCut.Tables[0].Rows[i]["CorteTotal"]);
                            ConsuPrim.Tables[0].Rows.Add(newConsumPrim);

                            ConsuPrim.Tables[0].DefaultView.Sort = "codeFilm DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < ConsuPrim.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmScrap.Index].Value = ConsuPrim.Tables[0].Rows[i]["codeFilm"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(ConsuPrim.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(ConsuPrim.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");

            }
            #endregion

            #region Scrap Pesado Corte Primario
            else if (identifier == "scrapPesCortePrim")
            {
                this.Text = "Detalle de Scrap Pesado en Corte Primario";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                dgv.Columns[clmScrap.Index].Visible = true;

                DataSet scrap = new DataSet();

                scrap = clsConnection.getDataSetResult("CALL spScrapByMachineByDateTotalizedByScrap('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '" + dtpTo.Value.ToString("dd/MM/yyyy") + "', " + primcutter.ToString() + ")");

                if (scrap.Tables.Count > 0 && scrap.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < scrap.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmScrap.Index].Value = scrap.Tables[0].Rows[i]["scrapName"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(scrap.Tables[0].Rows[i]["ScrapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(scrap.Tables[0].Rows[i]["ScrapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
                
            }
            #endregion

            #region Ingreso Materias Primas
            else if (identifier == "ingMP")
            {
                this.Text = "Detalle Ingreso de Materias Primas";

                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet ingMP = new DataSet();

                ingMP = clsConnection.getDataSetResult("CALL spRawInByDateByRaw('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString());

                for (int i = 0; i < ingMP.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = ingMP.Tables[0].Rows[i]["codRaw"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(ingMP.Tables[0].Rows[i]["IngTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(ingMP.Tables[0].Rows[i]["IngTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Stock Inicial de MP
            else if (identifier == "stockInitMP")
            {
                this.Text = "Detalle Stock Inicial de Materias Primas";

                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet stockMP = new DataSet();

                stockMP = clsConnection.getDataSetResult("CALL spDepotMPByDateByRaw('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < stockMP.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = stockMP.Tables[0].Rows[i]["rawMP"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(stockMP.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(stockMP.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Stock Final de MP
            else if (identifier == "stockFinalMP")
            {
                this.Text = "Detalle de Stock Final de Materias Primas";

                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet stockMP = new DataSet();

                stockMP = clsConnection.getDataSetResult("CALL spDepotMPByDateByRaw('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < stockMP.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = stockMP.Tables[0].Rows[i]["rawMP"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(stockMP.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(stockMP.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Importaciones
            else if (identifier == "importaciones")
            {
                this.Text = "Detalle de Importaciones";

                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet impos = new DataSet();

                impos = clsConnection.getDataSetResult("CALL spImportacionesByProduct('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < impos.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = impos.Tables[0].Rows[i]["codCoil"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(impos.Tables[0].Rows[i]["ImpoTotal"]) / 1000).ToString("0.00");
                    total += (Convert.ToDouble(impos.Tables[0].Rows[i]["ImpoTotal"]) / 1000);
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Swap Producto Terminado && Producto en Proceso +
            else if (identifier == "swapPPPT")
            {
                this.Text = "Detalle de Swap Producto Terminado y Producto en Proceso positivo";

                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet SwapPPPT = new DataSet();

                SwapPPPT = clsConnection.getDataSetResult("CALL spPTPosSwapByDateByFilm('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < SwapPPPT.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = SwapPPPT.Tables[0].Rows[i]["codFilm"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(SwapPPPT.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(SwapPPPT.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Swap Producto Terminado && Producto en Proceso -

            else if (identifier == "swapPPPTNeg")
            {

                this.Text = "Detalle de Swap Producto Terminado y Producto en Proceso Negativo";

                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet SwapPPPT = new DataSet();

                SwapPPPT = clsConnection.getDataSetResult("CALL spPTNegSwapByDateByFilm('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < SwapPPPT.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = SwapPPPT.Tables[0].Rows[i]["codFilm"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(SwapPPPT.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(SwapPPPT.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Devoluciones
            else if (identifier == "devoluciones")
            {

                this.Text = "Detalle de Devoluciones";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet Devs = new DataSet();

                Devs = clsConnection.getDataSetResult("CALL spReturnsReportTotalizedByFilm('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < Devs.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = Devs.Tables[0].Rows[i]["producto"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(Devs.Tables[0].Rows[i]["DevTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(Devs.Tables[0].Rows[i]["DevTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Despachos
            else if (identifier == "despachos")
            {

                this.Text = "Detalle de despachos";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet Despachos = new DataSet();

                Despachos = clsConnection.getDataSetResult("CALL spShippingsReportTotalizedByProduct('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < Despachos.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = Despachos.Tables[0].Rows[i]["CodProd"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(Despachos.Tables[0].Rows[i]["EntTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(Despachos.Tables[0].Rows[i]["EntTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Producto Terminado Primario Inicial
            else if (identifier == "PTPrimInicial")
            {

                this.Text = "Detalle de Producto terminado Primario Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet PTStockInit = new DataSet();
                string query = "CALL spDepotPTPrimeByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockInit = clsConnection.getDataSetResult(query);

                for (int i = 0; i < PTStockInit.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = PTStockInit.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Producto Terminado Primario Final

            else if (identifier == "PTPrimFinal")
            {
                this.Text = "Detalle Producto Terminado Primario Final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet PTStockFinal = new DataSet();
                string query = "CALL spDepotPTPrimeByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockFinal = clsConnection.getDataSetResult(query);

                for (int i = 0; i < PTStockFinal.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = PTStockFinal.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(PTStockFinal.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(PTStockFinal.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Producto Terminado en OP1 Inicial

            else if (identifier == "PTOp1Init")
            {
                this.Text = "Detalle de Producto Terminado en OP1 Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();

                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTOP1.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Producto terminado en OP1 Final
            else if (identifier == "PTOp1Fin")
            {
                this.Text = "Detalle de Producto terminado en OP1 Final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();

                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTOP1.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Producto terminado Primario + Producto OP1 Inicial
            else if (identifier == "PTOP1Total")
            {
                this.Text = "Detalle de suma de producto terminado Primario y producto OP1 Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();
                DataSet PTStockInit = new DataSet();

                string query = "CALL spDepotPTPrimeByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockInit = clsConnection.getDataSetResult(query);
                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < PTStockInit.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == PTStockInit.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]);
                            break;
                        }
                        else if (DepotPTOP1.Tables[0].Rows.Count == j + 1)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = PTStockInit.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = PTStockInit.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTOP1.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");


            }
            #endregion

            #region Producto terminado Primario + Producto OP1 Final

            else if (identifier == "PTOP1TotalFinal")
            {
                this.Text = "Detalle de suma de producto terminado Primario y producto OP1 Final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();
                DataSet PTStockInit = new DataSet();

                string query = "CALL spDepotPTPrimeByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockInit = clsConnection.getDataSetResult(query);
                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < PTStockInit.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == PTStockInit.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]);
                            break;
                        }
                        else if (DepotPTOP1.Tables[0].Rows.Count == j + 1)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = PTStockInit.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = PTStockInit.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTOP1.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");

            }
            #endregion

            #region Producto en Proceso Total Inicial
            else if (identifier == "PPTotalInit")
            {
                this.Text = "Detalle de Producto en Proceso Total Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;


                DataSet DepotPTTot = new DataSet();
                DataSet DepotPPallet = new DataSet();

                DepotPTTot = clsConnection.getDataSetResult("CALL spDepotPPByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPallet = clsConnection.getDataSetResult("CALL spDepotPPPalletByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPallet.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPPallet.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPallet.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                            DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTTot.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTTot.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");

            }
            #endregion

            #region Producto en Proceso Total Final
            else if (identifier == "PPTotalFinal")
            {
                this.Text = "Detalle Producto en Proceso total final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTTot = new DataSet();
                DataSet DepotPPallet = new DataSet();

                DepotPTTot = clsConnection.getDataSetResult("CALL spDepotPPByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPallet = clsConnection.getDataSetResult("CALL spDepotPPPalletByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPallet.Tables[0].Rows.Count; i++)
                {
                    if (DepotPTTot.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                        {
                            if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPPallet.Tables[0].Rows[i]["film"].ToString())
                            {
                                DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPallet.Tables[0].Rows[i]["TotalDepot"]);
                                break;

                            }
                            else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                            {
                                DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                                newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                                newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                                DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                                DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                        newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                        newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                        DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                        DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                    }
                }

                for (int i = 0; i < DepotPTTot.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTTot.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Deposito Total Total Inicial
            else if (identifier == "TotalTotalInit")
            {
                this.Text = "Detalle de Deposito Total Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTTot = new DataSet();
                DataSet DepotPPallet = new DataSet();
                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();
                DataSet PTStockInit = new DataSet();

                string query = "CALL spDepotPTPrimeByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockInit = clsConnection.getDataSetResult(query);
                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                DepotPTTot = clsConnection.getDataSetResult("CALL spDepotPPByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPallet = clsConnection.getDataSetResult("CALL spDepotPPPalletByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPallet.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPPallet.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPallet.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                            DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                } // Aca termina la primera que se va sumar

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < PTStockInit.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == PTStockInit.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]);
                            break;
                        }
                        else if (DepotPTOP1.Tables[0].Rows.Count == j + 1)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = PTStockInit.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = PTStockInit.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                } // Aca se termina el segundo. 

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPTOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;
                        }
                        else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPTOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPTOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                            DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < DepotPTTot.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTTot.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Deposito Total Total Final
            else if (identifier == "TotalTotalFinal")
            {
                this.Text = "Detalle de deposito total final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet DepotPTTot = new DataSet();
                DataSet DepotPPallet = new DataSet();
                DataSet DepotPTOP1 = new DataSet();
                DataSet DepotPPOP1 = new DataSet();
                DataSet PTStockInit = new DataSet();

                string query = "CALL spDepotPTPrimeByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec + ")";

                PTStockInit = clsConnection.getDataSetResult(query);
                DepotPTOP1 = clsConnection.getDataSetResult("CALL spDepotPTOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPOP1 = clsConnection.getDataSetResult("CALL spDepotPPOP1ByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                DepotPTTot = clsConnection.getDataSetResult("CALL spDepotPPByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);
                DepotPPallet = clsConnection.getDataSetResult("CALL spDepotPPPalletByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec);

                for (int i = 0; i < DepotPPallet.Tables[0].Rows.Count; i++)
                {
                    if (DepotPTTot.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                        {
                            if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPPallet.Tables[0].Rows[i]["film"].ToString())
                            {
                                DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPallet.Tables[0].Rows[i]["TotalDepot"]);
                                break;

                            }
                            else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                            {
                                DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                                newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                                newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                                DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                                DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                        newDepotPT["film"] = DepotPPallet.Tables[0].Rows[i]["film"];
                        newDepotPT["TotalDepot"] = DepotPPallet.Tables[0].Rows[i]["TotalDepot"];
                        DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                        DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                    }
                } // Aca termina la primera que se va sumar

                for (int i = 0; i < DepotPPOP1.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                    {
                        if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == DepotPPOP1.Tables[0].Rows[i]["film"].ToString())
                        {
                            DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPPOP1.Tables[0].Rows[i]["TotalDepot"]);
                            break;

                        }
                        else if (j + 1 == DepotPTOP1.Tables[0].Rows.Count)
                        {
                            DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                            newDepotPT["film"] = DepotPPOP1.Tables[0].Rows[i]["film"];
                            newDepotPT["TotalDepot"] = DepotPPOP1.Tables[0].Rows[i]["TotalDepot"];
                            DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                            DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                            break;
                        }
                    }
                }

                for (int i = 0; i < PTStockInit.Tables[0].Rows.Count; i++)
                {
                    if (DepotPTOP1.Tables[0].Rows.Count > 0)
                    {

                        for (int j = 0; j < DepotPTOP1.Tables[0].Rows.Count; j++)
                        {
                            if (DepotPTOP1.Tables[0].Rows[j]["film"].ToString() == PTStockInit.Tables[0].Rows[i]["film"].ToString())
                            {
                                DepotPTOP1.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTOP1.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(PTStockInit.Tables[0].Rows[i]["TotalDepot"]);
                                break;
                            }
                            else if (DepotPTOP1.Tables[0].Rows.Count == j + 1)
                            {
                                DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                                newDepotPT["film"] = PTStockInit.Tables[0].Rows[i]["film"];
                                newDepotPT["TotalDepot"] = PTStockInit.Tables[0].Rows[i]["TotalDepot"];
                                DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                                DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newDepotPT = DepotPTOP1.Tables[0].NewRow();
                        newDepotPT["film"] = PTStockInit.Tables[0].Rows[i]["film"];
                        newDepotPT["TotalDepot"] = PTStockInit.Tables[0].Rows[i]["TotalDepot"];
                        DepotPTOP1.Tables[0].Rows.Add(newDepotPT);

                        DepotPTOP1.Tables[0].DefaultView.Sort = "film DESC";
                    }
                } // Aca se termina el segundo. 

                for (int i = 0; i < DepotPTOP1.Tables[0].Rows.Count; i++)
                {
                    if (DepotPTTot.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < DepotPTTot.Tables[0].Rows.Count; j++)
                        {
                            if (DepotPTTot.Tables[0].Rows[j]["film"].ToString() == DepotPTOP1.Tables[0].Rows[i]["film"].ToString())
                            {
                                DepotPTTot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(DepotPTTot.Tables[0].Rows[j]["TotalDepot"]) + Convert.ToDouble(DepotPTOP1.Tables[0].Rows[i]["TotalDepot"]);
                                break;
                            }
                            else if (j + 1 == DepotPTTot.Tables[0].Rows.Count)
                            {
                                DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                                newDepotPT["film"] = DepotPTOP1.Tables[0].Rows[i]["film"];
                                newDepotPT["TotalDepot"] = DepotPTOP1.Tables[0].Rows[i]["TotalDepot"];
                                DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                                DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newDepotPT = DepotPTTot.Tables[0].NewRow();
                        newDepotPT["film"] = DepotPTOP1.Tables[0].Rows[i]["film"];
                        newDepotPT["TotalDepot"] = DepotPTOP1.Tables[0].Rows[i]["TotalDepot"];
                        DepotPTTot.Tables[0].Rows.Add(newDepotPT);

                        DepotPTTot.Tables[0].DefaultView.Sort = "film DESC";
                    }
                }

                for (int i = 0; i < DepotPTTot.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = DepotPTTot.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(DepotPTTot.Tables[0].Rows[i]["TotalDepot"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Rack Primario Inicial
            else if (identifier == "RackPrimarioInit")
            {
                this.Text = "Detalle de Rack Primario Inicial";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet RackInit = new DataSet();

                RackInit = clsConnection.getDataSetResult("CALL spPrimaryRackByDateByFilm('" + from.ToString("dd/MM/yyyy") + "'," + machine);

                for (int i = 0; i < RackInit.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = RackInit.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(RackInit.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(RackInit.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }

                txtTotal.Text = total.ToString("0.00");

            }
            #endregion

            #region Rack Primario Final
            else if (identifier == "RackPrimarioFinal")
            {
                this.Text = "Detalle de Rack Primario Final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet RackInit = new DataSet();

                RackInit = clsConnection.getDataSetResult("CALL spPrimaryRackByDateByFilm('" + to.ToString("dd/MM/yyyy") + "'," + machine);

                for (int i = 0; i < RackInit.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = RackInit.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(RackInit.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(RackInit.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }

                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Swap Positivo de Materia Prima
            else if (identifier == "swapPosMP")
            {
                this.Text = "Detalle de Swap positivo de materia prima";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet rawMat = new DataSet();

                rawMat = clsConnection.getDataSetResult("CALL spRawPosSwapByDateByRaw ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                if (rawMat.Tables.Count > 0 && rawMat.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < rawMat.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = rawMat.Tables[0].Rows[i]["rawCode"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(rawMat.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(rawMat.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Swap Negativo de Materia Prima
            else if (identifier == "swapNegMP")
            {
                this.Text = "Detalle de Swap Negativo de Materia Prima";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet rawMat = new DataSet();

                string query = "CALL spRawNegSwapByDateByRaw ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")";

                rawMat = clsConnection.getDataSetResult(query);

                if (rawMat.Tables.Count > 0 && rawMat.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < rawMat.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = rawMat.Tables[0].Rows[i]["rawCode"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(rawMat.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(rawMat.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Swap Positivo de Base Sin Metalizar
            else if (identifier == "swapPosBaseSM")
            {
                this.Text = "Detale de Swap Positivo de Base Sin Metalizar";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet baseSM = new DataSet();

                baseSM = clsConnection.getDataSetResult("CALL spBPMPosSwapByDateByBaseSM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                if (baseSM.Tables.Count > 0 && baseSM.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < baseSM.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = baseSM.Tables[0].Rows[i]["codBase"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(baseSM.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(baseSM.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Swap Negativo de Base Sin Metalizar
            else if (identifier == "swapNegBaseSM")
            {
                this.Text = "Detalle de Swap Negativo de Base Sin Metalizar";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet baseSM = new DataSet();

                baseSM = clsConnection.getDataSetResult("CALL spBPMNegSwapByDateByBaseSM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                if (baseSM.Tables.Count > 0 && baseSM.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < baseSM.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = baseSM.Tables[0].Rows[i]["codBase"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(baseSM.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(baseSM.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Swap Positivo de Base Metalizada.
            else if (identifier == "swapPosBaseM")
            {
                this.Text = "Detalle de Swap Negativo de Base Metalizada";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet baseM = new DataSet();

                baseM = clsConnection.getDataSetResult("CALL spBMPosSwapByDateByBaseM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                if (baseM.Tables.Count > 0 && baseM.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < baseM.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = baseM.Tables[0].Rows[i]["codBase"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(baseM.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(baseM.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Swap Negativo de Base Metalizada.
            else if (identifier == "swapNegBaseM")
            {
                this.Text = "Detalle de Swap Negativo de Base Metalizada";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;


                DataSet baseM = new DataSet();

                baseM = clsConnection.getDataSetResult("CALL spBMNegSwapByDateByBaseM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                if (baseM.Tables.Count > 0 && baseM.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < baseM.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = baseM.Tables[0].Rows[i]["codBase"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(baseM.Tables[0].Rows[i]["SwapTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(baseM.Tables[0].Rows[i]["SwapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Inicial Bases.
            else if (identifier == "rackInitB")
            {
                this.Text = "Detalle de Rack Inicial Bases.";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet Base = new DataSet();

                Base = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                if (Base.Tables.Count > 0 && Base.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Base.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = Base.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(Base.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(Base.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Inicial de Metalizados
            else if (identifier == "rackInitM")
            {
                this.Text = "Detalle de Rack Inicial de Metalizados";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet metalDS = new DataSet();

                metalDS = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                if (metalDS.Tables.Count > 0 && metalDS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < metalDS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = metalDS.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Total de Base y Metalizados Iniciales.
            else if (identifier == "rackTotalByM")
            {
                this.Text = "Detalle de Rack Total de Base y metalizados inciales";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet Base = new DataSet();
                DataSet metalDS = new DataSet();

                Base = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                metalDS = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                for (int i = 0; i < metalDS.Tables[0].Rows.Count; i++)
                {
                    if (Base.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < Base.Tables[0].Rows.Count; j++)
                        {
                            if (Convert.ToString(Base.Tables[0].Rows[j]["film"]) == Convert.ToString(metalDS.Tables[0].Rows[i]["film"]))
                            {
                                Base.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(Base.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]);
                                break;
                            }
                            else if (j + 1 == Base.Tables[0].Rows.Count)
                            {
                                DataRow newBase = Base.Tables[0].NewRow();
                                newBase["film"] = metalDS.Tables[0].Rows[i]["film"];
                                newBase["RackTotal"] = metalDS.Tables[0].Rows[i]["RackTotal"];
                                Base.Tables[0].Rows.Add(newBase);

                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newBase = Base.Tables[0].NewRow();
                        newBase["film"] = metalDS.Tables[0].Rows[i]["film"];
                        newBase["RackTotal"] = metalDS.Tables[0].Rows[i]["RackTotal"];
                        Base.Tables[0].Rows.Add(newBase);
                    }
                }

                if (Base.Tables.Count > 0 && Base.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Base.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = Base.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(Base.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(Base.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Final Bases
            else if (identifier == "rackFinalB")
            {
                this.Text = "Detalle de Rack Final de Bases";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet finalBase = new DataSet();

                finalBase = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                if (finalBase.Tables.Count > 0 && finalBase.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < finalBase.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = finalBase.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(finalBase.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(finalBase.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Final Metalizados

            else if (identifier == "rackFinalM")
            {
                this.Text = "Detalle de Rack Final Metalizados";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;


                DataSet metalDS = new DataSet();

                metalDS = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                if (metalDS.Tables.Count > 0 && metalDS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < metalDS.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = metalDS.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Rack Total de Bases y Metalizados Final.

            else if (identifier == "rackTotalByMFinal")
            {
                this.Text = "Detalle de Rack Total de bases y metalizados final";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet finalBase = new DataSet();
                DataSet metalDS = new DataSet();

                finalBase = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                metalDS = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                for (int i = 0; i < metalDS.Tables[0].Rows.Count; i++)
                {
                    if (finalBase.Tables.Count > 0 && finalBase.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < finalBase.Tables[0].Rows.Count; j++)
                        {
                            if (finalBase.Tables[0].Rows[j]["RackTotal"].ToString() == metalDS.Tables[0].Rows[i]["RackTotal"].ToString())
                            {
                                finalBase.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(finalBase.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(metalDS.Tables[0].Rows[i]["RackTotal"]);
                                break;
                            }
                            else if (j + 1 == finalBase.Tables[0].Rows.Count)
                            {
                                DataRow newFinalBase = finalBase.Tables[0].NewRow();
                                newFinalBase["film"] = metalDS.Tables[0].Rows[i]["film"];
                                newFinalBase["RackTotal"] = metalDS.Tables[0].Rows[i]["RackTotal"];
                                finalBase.Tables[0].Rows.Add(newFinalBase);

                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newFinalBase = finalBase.Tables[0].NewRow();
                        newFinalBase["film"] = metalDS.Tables[0].Rows[i]["film"];
                        newFinalBase["RackTotal"] = metalDS.Tables[0].Rows[i]["RackTotal"];
                        finalBase.Tables[0].Rows.Add(newFinalBase);
                    }
                }

                for (int i = 0; i < finalBase.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = finalBase.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(finalBase.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(finalBase.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Consumo de Bases de Metalizadora.
            else if (identifier == "consumoBaseMetalizadora")
            {
                this.Text = "Detalle de consumo de Bases para metalizadora";

                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet ConsumoBases = new DataSet();

                ConsumoBases = calcularConsumBase(plant, from, to);

                for (int i = 0; i < ConsumoBases.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = ConsumoBases.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(ConsumoBases.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(ConsumoBases.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Metalizado Producido
            else if (identifier == "metalizado")
            {
                this.Text = "Detalle de Metalizado";
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;

                DataSet metalizado = new DataSet();

                metalizado = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

                for (int i = 0; i < metalizado.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = metalizado.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(metalizado.Tables[0].Rows[i]["MetalTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(metalizado.Tables[0].Rows[i]["MetalTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Scrap De la Metalizadora
            else if (identifier == "scrapMetalizado")
            {
                this.Text = "Detalle de scrap Metalizado";
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                dgv.Columns[clmScrap.Index].Visible = true;

                DataSet metalizado = new DataSet();
                DataSet ConsumoBases = new DataSet();

                metalizado = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");
                ConsumoBases = calcularConsumBase(plant, from, to);

                for (int i = 0; i < metalizado.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ConsumoBases.Tables[0].Rows.Count; j++)
                    {
                        if (metalizado.Tables[0].Rows[i]["film"].ToString() == ConsumoBases.Tables[0].Rows[j]["film"].ToString())
                        {
                            ConsumoBases.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(ConsumoBases.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(metalizado.Tables[0].Rows[i]["MetalTotal"]);
                        }
                        else if (j + 1 == ConsumoBases.Tables[0].Rows.Count)
                        {
                            DataRow newBase = ConsumoBases.Tables[0].NewRow();
                            newBase["film"] = metalizado.Tables[0].Rows[i]["film"];
                            newBase["RackTotal"] = -1* Convert.ToDouble(metalizado.Tables[0].Rows[i]["MetalTotal"]);
                            ConsumoBases.Tables[0].Rows.Add(newBase);
                            break;
                        }
                    }
                }

                for (int i = 0; i < ConsumoBases.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmScrap.Index].Value = ConsumoBases.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(ConsumoBases.Tables[0].Rows[i]["RackTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(ConsumoBases.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Consumo de Metalizado para Corte
            else if (identifier == "consumoMetalizadora")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Consumo de la metalizadora";

                DataSet consumoMetal = new DataSet();

                consumoMetal = calclularMetalizadora(plant, from, to);

                for (int i = 0; i < consumoMetal.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = consumoMetal.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(consumoMetal.Tables[0].Rows[i]["RackTotal"])/1000).ToString("0.00");
                    total += Convert.ToDouble(consumoMetal.Tables[0].Rows[i]["RackTotal"])/1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Corte de Metalizado
            else if (identifier == "corteMetalizado")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Corte de la metalizadora";

                DataSet cMet = new DataSet();
                cMet = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                if (cMet.Tables.Count > 0 && cMet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < cMet.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = cMet.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(cMet.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(cMet.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }

            #endregion

            #region Scrap Teorico de Metalizadora
            else if (identifier == "scrapMetTeorico")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Scrap Teorico de Metalizadora";

                DataSet consumoMetal = new DataSet();
                DataSet corteMetal = new DataSet();

                consumoMetal = calclularMetalizadora(plant, from, to);
                corteMetal = clsConnection.getDataSetResult("CALL spCuttingReportMetTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

                for (int i = 0; i < corteMetal.Tables[0].Rows.Count; i++)
                {
                    if (corteMetal.Tables.Count > 0 && corteMetal.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < consumoMetal.Tables[0].Rows.Count; j++)
                        {
                            if (consumoMetal.Tables[0].Rows[j]["film"].ToString() == corteMetal.Tables[0].Rows[i]["film"].ToString())
                            {
                                consumoMetal.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(consumoMetal.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(corteMetal.Tables[0].Rows[i]["CorteTotal"]);
                                break;
                            }
                            else if (j + 1 == consumoMetal.Tables[0].Rows.Count)
                            {
                                DataRow newBase = consumoMetal.Tables[0].NewRow();
                                newBase["film"] = corteMetal.Tables[0].Rows[i]["film"];
                                newBase["RackTotal"] = -1 * Convert.ToDouble(corteMetal.Tables[0].Rows[i]["CorteTotal"]);
                                consumoMetal.Tables[0].Rows.Add(newBase);
                                break;
                            }
                        }
                    }
                    else
                    {
                        DataRow newBase = consumoMetal.Tables[0].NewRow();
                        newBase["film"] = corteMetal.Tables[0].Rows[i]["film"];
                        newBase["RackTotal"] = -1 * Convert.ToDouble(corteMetal.Tables[0].Rows[i]["CorteTotal"]);
                        consumoMetal.Tables[0].Rows.Add(newBase);
                    }
                }

                for (int i = 0; i < consumoMetal.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = consumoMetal.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(consumoMetal.Tables[0].Rows[i]["RackTotal"])/1000).ToString("0.00");
                    total += Convert.ToDouble(consumoMetal.Tables[0].Rows[i]["RackTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Scrap pesado de Metalizadora
            else if (identifier == "scrapMetPesado")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Scrap de la metalizadora Pesado";

                DataSet scrap = new DataSet();

                scrap = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedByScrap('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '" + dtpTo.Value.ToString("dd/MM/yyyy") + "', " + seccutter.ToString() + ", 2" + ")");

                for (int i = 0; i < scrap.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = scrap.Tables[0].Rows[i]["scrapName"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(scrap.Tables[0].Rows[i]["ScrapTotal"]) / 1000).ToString("0.00");
                    total += Convert.ToDouble(scrap.Tables[0].Rows[i]["ScrapTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Consumo Secundaria
            else if (identifier == "consumoSecu")
            {

            }
            #endregion

            #region Corte Secundaria
            else if (identifier == "corteSecundaria")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Cortadora Secundaria";

                DataSet corteSecu = new DataSet();
               
                string query = "CALL spSecundaryCuttingReportTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")";
                corteSecu = clsConnection.getDataSetResult(query);

                for (int i = 0; i < corteSecu.Tables[0].Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = corteSecu.Tables[0].Rows[i]["film"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(corteSecu.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                    dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                    total += Convert.ToDouble(corteSecu.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Scrap Teorico Secundaria
            else if (identifier == "scrapTeoSecundaria")
            {
                dgv.Columns[clmFilm.Index].Visible = true;
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;


            }
            #endregion

            #region Scrap Pesado Secundaria
            else if (identifier == "scrapPesSecundaria")
            {
                DataSet scrapPes = new DataSet();

                scrapPes = clsConnection.getDataSetResult("CALL spScrapByTypeByDateTotalizedSecundary '" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '" + dtpTo.Value.ToString("dd/MM/yyyy") + "', " + plant.ToString() + ", 2");

                if (scrapPes.Tables.Count > 0 && scrapPes.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < scrapPes.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmFilm.Index].Value = scrapPes.Tables[0].Rows[i]["film"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(scrapPes.Tables[0].Rows[i]["ScrapTotal"])/1000).ToString("0.00");
                        total += Convert.ToDouble(scrapPes.Tables[0].Rows[i]["ScrapTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion

            #region Venta de Materias Primas
            else if (identifier == "ventaDeMP")
            {
                dgv.Columns[clmPlanta.Index].Visible = true;
                dgv.Columns[clmRawMaterial.Index].Visible = true;
                dgv.Columns[clmWeigth.Index].Visible = true;
                this.Text = "Detalle de Venta de Materias Primas";

                DataSet VentaMP = new DataSet();

                VentaMP = clsConnection.getDataSetResult("CALL spRawSoldByDateByRaw('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '" + dtpTo.Value.ToString("dd/MM/yyyy") + "', " + plant.ToString() + ")");
                if (VentaMP.Tables.Count > 0 && VentaMP.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < VentaMP.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = VentaMP.Tables[0].Rows[i]["codMP"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[clmWeigth.Index].Value = (Convert.ToDouble(VentaMP.Tables[0].Rows[i]["MPTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(VentaMP.Tables[0].Rows[i]["MPTotal"]) / 1000;
                    }
                    txtTotal.Text = total.ToString("0.00");
                }
            }
            #endregion


        }// Aca termina el procedimiento de muestra


        #region Escondo todas las Columnas

        private void hideAll()
        {
            dgv.Columns[clmExtruder.Index].Visible = false;
            dgv.Columns[clmFilm.Index].Visible = false;
            dgv.Columns[clmPlanta.Index].Visible = false;
            dgv.Columns[clmRawMaterial.Index].Visible = false;
            dgv.Columns[clmWeigth.Index].Visible = false;
            dgv.Columns[clmScrap.Index].Visible = false;
        }

        #endregion

        #region Exportar a Excel
        private void btnExcel_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgv.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }
        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        #region Calcular Consumo Extrusión
        
        private DataSet calculatingConsume(clsPlant plant, DateTime from, DateTime to)
        {

            DataSet InitMPDepot = new DataSet();
            DataSet RawIn = new DataSet();
            DataSet Mill = new DataSet();
            DataSet RawPosSwap = new DataSet();
            DataSet RawNegSwap = new DataSet();
            DataSet FinalMPDepot = new DataSet();

            InitMPDepot = clsConnection.getDataSetResult("CALL spRawDepotHistorySubtotalizedByRaw('" + from.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawIn = clsConnection.getDataSetResult("CALL spRawInByDateByRaw('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            Mill = clsConnection.getDataSetResult("CALL spMillProductionSubTotalized('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawPosSwap = clsConnection.getDataSetResult("CALL spRawPosSwapByDateByRaw('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            RawNegSwap = clsConnection.getDataSetResult("CALL spRawNegSwapByDateByRaw('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            FinalMPDepot = clsConnection.getDataSetResult("CALL spRawDepotHistorySubtotalizedByRaw('" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            for (int i = 0; i < RawIn.Tables[0].Rows.Count; i++)
            {
                bool encontro = false;
                if (InitMPDepot.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < InitMPDepot.Tables[0].Rows.Count; j++)
                    {
                        if (InitMPDepot.Tables[0].Rows[j]["codRaw"].ToString() == RawIn.Tables[0].Rows[i]["codRaw"].ToString())
                        {
                            InitMPDepot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(RawIn.Tables[0].Rows[i]["IngTotal"]) + Convert.ToDouble(InitMPDepot.Tables[0].Rows[j]["TotalDepot"]);
                            encontro = true;
                        }
                        else if (encontro != true && (j + 1 == InitMPDepot.Tables[0].Rows.Count))
                        {
                            DataRow newInitMPDepot = InitMPDepot.Tables[0].NewRow();
                            newInitMPDepot["codRaw"] = RawIn.Tables[0].Rows[i]["codRaw"];
                            newInitMPDepot["TotalDepot"] = RawIn.Tables[0].Rows[i]["IngTotal"];
                            InitMPDepot.Tables[0].Rows.Add(newInitMPDepot);

                            InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitMPDepot = InitMPDepot.Tables[0].NewRow();
                    newInitMPDepot["codRaw"] = RawIn.Tables[0].Rows[i]["codRaw"];
                    newInitMPDepot["TotalDepot"] = RawIn.Tables[0].Rows[i]["IngTotal"];
                    InitMPDepot.Tables[0].Rows.Add(newInitMPDepot);

                    InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                }
            }


            for (int i = 0; i < Mill.Tables[0].Rows.Count; i++)
            {
                bool encontro = false;
                if (InitMPDepot.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < InitMPDepot.Tables[0].Rows.Count; j++)
                    {
                        if (InitMPDepot.Tables[0].Rows[j]["codRaw"].ToString() == Mill.Tables[0].Rows[i]["codMP"].ToString())
                        {
                            InitMPDepot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(Mill.Tables[0].Rows[i]["Peso"]) + Convert.ToDouble(InitMPDepot.Tables[0].Rows[j]["TotalDepot"]);
                            encontro = true;
                        }
                        else if (encontro != true && (j + 1 == InitMPDepot.Tables[0].Rows.Count))
                        {
                            DataRow newRawIn = InitMPDepot.Tables[0].NewRow();
                            newRawIn["codRaw"] = Mill.Tables[0].Rows[i]["codMP"];
                            newRawIn["TotalDepot"] = Mill.Tables[0].Rows[i]["Peso"];
                            InitMPDepot.Tables[0].Rows.Add(newRawIn);

                            InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                            break;
                        }
                    }
                }
                else
                {
                    DataRow newRawIn = InitMPDepot.Tables[0].NewRow();
                    newRawIn["codRaw"] = Mill.Tables[0].Rows[i]["codMP"];
                    newRawIn["TotalDepot"] = Mill.Tables[0].Rows[i]["Peso"];
                    InitMPDepot.Tables[0].Rows.Add(newRawIn);

                    InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                }
            }

            for (int i = 0; i < RawPosSwap.Tables[0].Rows.Count; i++)
            {
                bool encontro = false;
                if (InitMPDepot.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < InitMPDepot.Tables[0].Rows.Count; j++)
                    {
                        if (InitMPDepot.Tables[0].Rows[j]["codRaw"].ToString() == RawPosSwap.Tables[0].Rows[i]["rawCode"].ToString())
                        {
                            InitMPDepot.Tables[0].Rows[j]["TotalDepot"] = Convert.ToDouble(RawPosSwap.Tables[0].Rows[i]["SwapTotal"]) + Convert.ToDouble(InitMPDepot.Tables[0].Rows[j]["TotalDepot"]);
                            encontro = true;
                        }
                        else if (encontro != true && (j + 1 == InitMPDepot.Tables[0].Rows.Count))
                        {
                            DataRow newRawIn = InitMPDepot.Tables[0].NewRow();
                            newRawIn["codRaw"] = RawPosSwap.Tables[0].Rows[i]["rawCode"];
                            newRawIn["TotalDepot"] = RawPosSwap.Tables[0].Rows[i]["SwapTotal"];
                            InitMPDepot.Tables[0].Rows.Add(newRawIn);

                            InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                            break;
                        }
                    }
                }
                else
                {
                    DataRow newRawIn = InitMPDepot.Tables[0].NewRow();
                    newRawIn["codRaw"] = RawPosSwap.Tables[0].Rows[i]["rawCode"];
                    newRawIn["TotalDepot"] = RawPosSwap.Tables[0].Rows[i]["SwapTotal"];
                    InitMPDepot.Tables[0].Rows.Add(newRawIn);

                    InitMPDepot.Tables[0].DefaultView.Sort = "codRaw DESC";
                }
            }

            // Aca comienza la resta de los Materiales.

            for (int i = 0; i < InitMPDepot.Tables[0].Rows.Count; i++)
            {

                if (RawNegSwap.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < RawNegSwap.Tables[0].Rows.Count; j++)
                    {
                        if (Convert.ToString(InitMPDepot.Tables[0].Rows[i]["codRaw"]) == Convert.ToString(RawNegSwap.Tables[0].Rows[j]["rawCode"]))
                        {
                            InitMPDepot.Tables[0].Rows[i]["TotalDepot"] = Math.Round(Convert.ToDouble(InitMPDepot.Tables[0].Rows[i]["TotalDepot"]), 2) - Math.Round(Convert.ToDouble(RawNegSwap.Tables[0].Rows[j]["SwapTotal"]), 2);
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < InitMPDepot.Tables[0].Rows.Count; i++)
            {
                if (FinalMPDepot.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < FinalMPDepot.Tables[0].Rows.Count; j++)
                    {
                        if (Convert.ToString(InitMPDepot.Tables[0].Rows[i]["codRaw"]) == Convert.ToString(FinalMPDepot.Tables[0].Rows[j]["codRaw"]))
                        {
                            InitMPDepot.Tables[0].Rows[i]["TotalDepot"] = Math.Round(Convert.ToDouble(InitMPDepot.Tables[0].Rows[i]["TotalDepot"]), 2) - Math.Round(Convert.ToDouble(FinalMPDepot.Tables[0].Rows[j]["TotalDepot"]), 2);
                            break;
                        }
                    }
                }
            }
            return InitMPDepot;
        }
            
        #endregion

        #region Calcular Consumo Primaria

        private DataSet calculatePrimaryConsume(clsPlant plant,DateTime from, DateTime to)
        {
            DataSet InitRack = new DataSet();
            DataSet FinalRack = new DataSet();
            DataSet Prod = new DataSet();

            Prod = clsConnection.getDataSetResult("CALL spMainCoilReportByDateAndPlantTotalizedbyFilm ('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "'," + plant.codsec.ToString() + ")");

            InitRack = clsConnection.getDataSetResult("CALL spCuttingConsumePrimaryByFilm('" + from.ToString("dd/MM/yyyy") + "'," + machine + ")");

            FinalRack = clsConnection.getDataSetResult("CALL spCuttingConsumePrimaryByFilm('" + to.ToString("dd/MM/yyyy") + "'," + machine + ")");

            // Se puede poner logica de Bandera. 
            for (int i = 0; i < Prod.Tables[0].Rows.Count; i++)
            {
                bool encontro = false;

                for (int j = 0; j < InitRack.Tables[0].Rows.Count; j++)
                {
                    if (Convert.ToString(Prod.Tables[0].Rows[i]["pelicula"]) == Convert.ToString(InitRack.Tables[0].Rows[j]["codeFilm"]))
                    {
                        InitRack.Tables[0].Rows[j]["RackTotal"] = Math.Round(Convert.ToDouble(Prod.Tables[0].Rows[i]["PesoNeto"]), 2) + Math.Round(Convert.ToDouble(InitRack.Tables[0].Rows[j]["RackTotal"]), 2);
                        encontro = true;
                    }
                    else if (encontro != true && j + 1 == InitRack.Tables[0].Rows.Count)
                    {
                        DataRow newInitRowRack = InitRack.Tables[0].NewRow();
                        newInitRowRack["codeFilm"] = Prod.Tables[0].Rows[i]["pelicula"];
                        newInitRowRack["RackTotal"] = Prod.Tables[0].Rows[i]["PesoNeto"];
                        InitRack.Tables[0].Rows.Add(newInitRowRack);

                        InitRack.Tables[0].DefaultView.Sort = "codeFilm DESC";
                        break;
                    }
                }

            }

            for (int i = 0; i < InitRack.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < FinalRack.Tables[0].Rows.Count; j++)
                {
                    if (Convert.ToString(InitRack.Tables[0].Rows[i]["codeFilm"]) == Convert.ToString(FinalRack.Tables[0].Rows[j]["codeFilm"]))
                    {
                        InitRack.Tables[0].Rows[i]["RackTotal"] = Math.Round(Convert.ToDouble(InitRack.Tables[0].Rows[i]["RackTotal"]), 2) - Math.Round(Convert.ToDouble(FinalRack.Tables[0].Rows[j]["RackTotal"]), 2);
                    }
                }
            }
            return InitRack;
        }
                
        #endregion

        #region Calcular Consumo de Bases
        private DataSet calcularConsumBase(clsPlant plant, DateTime from, DateTime to)
        {
            DataSet rackInitB = new DataSet();
            DataSet cutterBMProd = new DataSet();
            DataSet swapPosBase = new DataSet();
            DataSet rackFinalB = new DataSet();
            DataSet baseSM = new DataSet();

            rackInitB = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            cutterBMProd = clsConnection.getDataSetResult("CALL spCuttingReportBMTotalizedByProduct('" + from.ToString("dd/MM/yyyy") + "','" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            swapPosBase = clsConnection.getDataSetResult("CALL spBPMPosSwapByDateByBaseSM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            rackFinalB = clsConnection.getDataSetResult("CALL spSecundaryRackBaseByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            baseSM = clsConnection.getDataSetResult("CALL spBPMNegSwapByDateByBaseSM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            for (int i = 0; i < cutterBMProd.Tables[0].Rows.Count; i++)
            {
                if (rackInitB.Tables.Count > 0 && rackInitB.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < rackInitB.Tables[0].Rows.Count; j++)
                    {
                        if (rackInitB.Tables[0].Rows[j]["film"].ToString() == cutterBMProd.Tables[0].Rows[i]["film"].ToString())
                        {
                            rackInitB.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInitB.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(cutterBMProd.Tables[0].Rows[i]["CorteTotal"]);
                        }
                        else if (j + 1 == rackInitB.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                            newInitRowRack["film"] = cutterBMProd.Tables[0].Rows[i]["film"];
                            newInitRowRack["RackTotal"] = cutterBMProd.Tables[0].Rows[i]["CorteTotal"];
                            rackInitB.Tables[0].Rows.Add(newInitRowRack);

                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                    newInitRowRack["film"] = cutterBMProd.Tables[0].Rows[i]["film"];
                    newInitRowRack["RackTotal"] = cutterBMProd.Tables[0].Rows[i]["CorteTotal"];
                    rackInitB.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            for (int i = 0; i < swapPosBase.Tables[0].Rows.Count; i++)
            {
                if (rackInitB.Tables.Count > 0 && rackInitB.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < rackInitB.Tables[0].Rows.Count; j++)
                    {
                        if (rackInitB.Tables[0].Rows[j]["film"].ToString() == swapPosBase.Tables[0].Rows[i]["codBase"].ToString())
                        {
                            rackInitB.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInitB.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(swapPosBase.Tables[0].Rows[i]["SwapTotal"]);
                            break;
                        }
                        else if (j + 1 == rackInitB.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                            newInitRowRack["film"] = swapPosBase.Tables[0].Rows[i]["codBase"];
                            newInitRowRack["RackTotal"] = swapPosBase.Tables[0].Rows[i]["SwapTotal"];
                            rackInitB.Tables[0].Rows.Add(newInitRowRack);
                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                    newInitRowRack["film"] = swapPosBase.Tables[0].Rows[i]["codBase"];
                    newInitRowRack["RackTotal"] = swapPosBase.Tables[0].Rows[i]["SwapTotal"];
                    rackInitB.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            for (int i = 0; i < rackFinalB.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < rackInitB.Tables[0].Rows.Count; j++)
                {
                    if (rackInitB.Tables[0].Rows[j]["film"].ToString() == rackFinalB.Tables[0].Rows[i]["film"].ToString())
                    {
                        rackInitB.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInitB.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(rackFinalB.Tables[0].Rows[i]["RackTotal"]);
                        break;
                    }
                    else if (j + 1 == rackInitB.Tables[0].Rows.Count)
                    {
                        DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                        newInitRowRack["film"] = rackFinalB.Tables[0].Rows[i]["film"];
                        newInitRowRack["RackTotal"] = -1 * Convert.ToDouble(rackFinalB.Tables[0].Rows[i]["RackTotal"]);
                        rackInitB.Tables[0].Rows.Add(newInitRowRack);
                        break;
                    }
                }
            }

            for (int i = 0; i < baseSM.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < rackInitB.Tables[0].Rows.Count; j++)
                {
                    if (rackInitB.Tables[0].Rows[j]["film"].ToString() == baseSM.Tables[0].Rows[i]["codBase"].ToString())
                    {
                        rackInitB.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInitB.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(baseSM.Tables[0].Rows[i]["SwapTotal"]);
                    }
                    else if (j + 1 == rackInitB.Tables[0].Rows.Count)
                    {
                        DataRow newInitRowRack = rackInitB.Tables[0].NewRow();
                        newInitRowRack["film"] = rackFinalB.Tables[0].Rows[i]["codBase"];
                        newInitRowRack["RackTotal"] = -1 * Convert.ToDouble(rackFinalB.Tables[0].Rows[i]["SwapTotal"]);
                        rackInitB.Tables[0].Rows.Add(newInitRowRack);
                        break;
                    }
                }
            }
            return rackInitB;
        }
        #endregion

        #region Calcular Consumo Metalizadora
        private DataSet calclularMetalizadora(clsPlant plant, DateTime from, DateTime to)
        {
            DataSet rackInit = new DataSet();
            DataSet rackFinal = new DataSet();
            DataSet metalizado = new DataSet();
            DataSet swapPosSM = new DataSet();
            DataSet swapNegSM = new DataSet();

            swapNegSM = clsConnection.getDataSetResult("CALL spBMNegSwapByDateByBaseM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            swapPosSM = clsConnection.getDataSetResult("CALL spBMPosSwapByDateByBaseM ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            metalizado = clsConnection.getDataSetResult("CALL spMetalizedReportByPlantTotalizedByFilm ('" + from.ToString("dd/MM/yyyy") + "', '" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            rackInit = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + from.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            rackFinal = clsConnection.getDataSetResult("CALL spSecundaryRackMetalByDateByFilm ('" + to.ToString("dd/MM/yyyy") + "', " + plant.codsec.ToString() + ")");

            for (int i = 0; i < metalizado.Tables[0].Rows.Count; i++)
            {
                if (metalizado.Tables.Count > 0 && metalizado.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < rackInit.Tables[0].Rows.Count; j++)
                    {
                        if (rackInit.Tables[0].Rows[j]["film"].ToString() == metalizado.Tables[0].Rows[i]["film"].ToString())
                        {
                            rackInit.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInit.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(metalizado.Tables[0].Rows[i]["MetalTotal"]);
                            break;
                        }
                        else if (j + 1 == rackInit.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                            newInitRowRack["film"] = metalizado.Tables[0].Rows[i]["film"];
                            newInitRowRack["RackTotal"] = metalizado.Tables[0].Rows[i]["MetalTotal"];
                            rackInit.Tables[0].Rows.Add(newInitRowRack);

                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                    newInitRowRack["film"] = metalizado.Tables[0].Rows[i]["film"];
                    newInitRowRack["RackTotal"] = metalizado.Tables[0].Rows[i]["MetalTotal"];
                    rackInit.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            for (int i = 0; i < swapPosSM.Tables[0].Rows.Count; i++)
            {
                if (swapPosSM.Tables.Count > 0 && swapPosSM.Tables[0].Rows.Count > 0)
                {

                    for (int j = 0; j < rackInit.Tables[0].Rows.Count; j++)
                    {
                        if (rackInit.Tables[0].Rows[j]["film"].ToString() == swapPosSM.Tables[0].Rows[i]["codBase"].ToString())
                        {
                            rackInit.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInit.Tables[0].Rows[j]["RackTotal"]) + Convert.ToDouble(swapPosSM.Tables[0].Rows[i]["SwapTotal"]);
                            break;
                        }
                        else if (j + 1 == rackInit.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                            newInitRowRack["film"] = swapPosSM.Tables[0].Rows[i]["codBase"];
                            newInitRowRack["RackTotal"] = swapPosSM.Tables[0].Rows[i]["SwapTotal"];
                            rackInit.Tables[0].Rows.Add(newInitRowRack);
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                    newInitRowRack["film"] = swapPosSM.Tables[0].Rows[i]["codBase"];
                    newInitRowRack["RackTotal"] = swapPosSM.Tables[0].Rows[i]["SwapTotal"];
                    rackInit.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            for (int i = 0; i < swapNegSM.Tables[0].Rows.Count; i++)
            {
                if (swapNegSM.Tables.Count > 0 && swapNegSM.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < rackInit.Tables[0].Rows.Count; j++)
                    {
                        if (rackInit.Tables[0].Rows[j]["film"].ToString() == swapNegSM.Tables[0].Rows[i]["codBase"].ToString())
                        {
                            rackInit.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInit.Tables[0].Rows[j]["RackTotal"]) - Math.Abs(Convert.ToDouble(swapNegSM.Tables[0].Rows[i]["SwapTotal"]));
                            break;
                        }
                        else if (j + 1 == rackInit.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                            newInitRowRack["film"] = swapNegSM.Tables[0].Rows[i]["codBase"];
                            newInitRowRack["RackTotal"] = swapNegSM.Tables[0].Rows[i]["SwapTotal"];
                            rackInit.Tables[0].Rows.Add(newInitRowRack);

                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                    newInitRowRack["film"] = swapNegSM.Tables[0].Rows[i]["codBase"];
                    newInitRowRack["RackTotal"] = -1 * Convert.ToDouble(swapNegSM.Tables[0].Rows[i]["SwapTotal"]);
                    rackInit.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            for (int i = 0; i < rackFinal.Tables[0].Rows.Count; i++)
            {
                if (rackFinal.Tables.Count > 0 && rackFinal.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < rackInit.Tables[0].Rows.Count; j++)
                    {
                        if (rackInit.Tables[0].Rows[j]["film"].ToString() == rackFinal.Tables[0].Rows[i]["film"].ToString())
                        {
                            rackInit.Tables[0].Rows[j]["RackTotal"] = Convert.ToDouble(rackInit.Tables[0].Rows[j]["RackTotal"]) - Convert.ToDouble(rackFinal.Tables[0].Rows[i]["RackTotal"]);
                            break;
                        }
                        else if (j + 1 == rackInit.Tables[0].Rows.Count)
                        {
                            DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                            newInitRowRack["film"] = rackFinal.Tables[0].Rows[i]["film"];
                            newInitRowRack["RackTotal"] = rackFinal.Tables[0].Rows[i]["RackTotal"];
                            rackInit.Tables[0].Rows.Add(newInitRowRack);
                            break;
                        }
                    }
                }
                else
                {
                    DataRow newInitRowRack = rackInit.Tables[0].NewRow();
                    newInitRowRack["film"] = rackFinal.Tables[0].Rows[i]["film"];
                    newInitRowRack["RackTotal"] = -1 * Convert.ToDouble(rackFinal.Tables[0].Rows[i]["RackTotal"]);
                    rackInit.Tables[0].Rows.Add(newInitRowRack);
                }
            }

            return rackInit;
        }
        #endregion

    }
}   
