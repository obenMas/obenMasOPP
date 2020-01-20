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
    public partial class frmMassBalance : Form
    {
       

        public frmMassBalance()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            completarPeliculas();
            completarRackPrimario();
            completarExtrusion();
            ocultarSinDatos();
        }

        private void ocultarSinDatos()
        {
            for(int i=0;i<dgv.Rows.Count;i++)
            {
                if(!Convert.ToBoolean(dgv.Rows[i].Cells[clmTieneDatos.Index].Value))
                {
                    dgv.Rows[i].Visible = false;
                }
            }
        }

        private void completarPeliculas()
        {
            List<clsBopp> listaBopp = clsBopp.getList();
            List<string> listaBoppSt = new List<string>();

            for (int i = 0; i < listaBopp.Count; i++)
            {
                listaBoppSt.Add(listaBopp[i].code);
            }

            listaBoppSt.Sort();

            for (int i = 0; i < listaBoppSt.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaBoppSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "LOCAL";
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaBoppSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "IMPORTADO";
            }

            List<clsCast> listaCast = clsCast.getList();
            List<string> listaCastSt = new List<string>();

            for (int i = 0; i < listaCast.Count; i++)
            {
                listaCastSt.Add(listaCast[i].code);
            }

            listaCastSt.Sort();

            for (int i = 0; i < listaCastSt.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaCastSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "LOCAL";
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaCastSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "IMPORTADO";
            }

            List<clsCoating> listaCoat = clsCoating.getList();
            List<string> listaCoatSt = new List<string>();

            for (int i = 0; i < listaCoat.Count; i++)
            {
                listaCoatSt.Add(listaCoat[i].code);
            }

            listaCoatSt.Sort();

            for (int i = 0; i < listaCoatSt.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaCoatSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "LOCAL";
                dgv.Rows.Add();
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmPelicula.Index].Value = listaCoatSt[i];
                dgv.Rows[dgv.Rows.Count - 1].Cells[clmOrigen.Index].Value = "IMPORTADO";
            }
        }

        private void completarRackPrimario()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spRackHistoryReportTotal (" + dtpDesde.Value.Date.Day + "," + dtpDesde.Value.Date.Month + "," + dtpDesde.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for(int j=0;j<dgv.Rows.Count-1;j++)
                    {
                        if (dgv.Rows[j].Cells[clmPelicula.Index].Value.ToString() == DS.Tables[0].Rows[i]["Pelicula"].ToString() && dgv.Rows[j].Cells[clmOrigen.Index].Value.ToString()=="LOCAL")
                        {
                            if (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"])<1000)
                            {
                                dgv.Rows[j].Cells[clmRackPrimarioI.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]).ToString("0");
                            }
                            else
                            {
                                dgv.Rows[j].Cells[clmRackPrimarioI.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]).ToString("0,000");
                            }
                            dgv.Rows[j].Cells[clmTieneDatos.Index].Value = true;
                        }
                    }
                }
            }
            texto = "CALL spRackHistoryReportTotal (" + dtpHasta.Value.Date.Day + "," + dtpHasta.Value.Date.Month + "," + dtpHasta.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            //RackPStockFinal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        if (dgv.Rows[j].Cells[clmPelicula.Index].Value.ToString() == DS.Tables[0].Rows[i]["Pelicula"].ToString() && dgv.Rows[j].Cells[clmOrigen.Index].Value.ToString() == "LOCAL")
                        {
                            if (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) < 1000)
                            {
                                dgv.Rows[j].Cells[clmRackPrimarioF.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]).ToString("0");
                            }
                            else
                            {
                                dgv.Rows[j].Cells[clmRackPrimarioF.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]).ToString("0,000");
                            }
                            dgv.Rows[j].Cells[clmTieneDatos.Index].Value = true;
                        }
                    }
                }
            }
        }

        private void completarExtrusion()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spMainCoilReportByDateTotalizedbyFilm '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Rows.Count - 1;j++ )
                    {
                        if (DS.Tables[0].Rows[i]["pelicula"].ToString() == dgv.Rows[j].Cells[clmPelicula.Index].Value.ToString() && dgv.Rows[j].Cells[clmOrigen.Index].Value.ToString() == "LOCAL")
                        {
                            if(Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"])<1000)
                            {
                                dgv.Rows[j].Cells[clmExtrusion.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]).ToString("0");
                            }
                            else
                            {
                                dgv.Rows[j].Cells[clmExtrusion.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]).ToString("0,000");
                            }
                            dgv.Rows[j].Cells[clmTieneDatos.Index].Value = true;
                        }
                    }
                }
            }
        }
    }
}
