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

namespace BPS.Lite
{
    public partial class frmCompleteCoilInventory : Form
    {
        private string plantafiltrado = string.Empty;
        private string bodegafiltrado = string.Empty;
        private string clasificacionfiltrado = string.Empty;
        private string palletfiltrado = string.Empty;
        private string bobinafiltrado = string.Empty;
        private string peliculafiltrado = string.Empty;
        private string anchofiltrado = string.Empty;
        private string diametrofiltrado = string.Empty;
        private string corefiltrado = string.Empty;
        private string clientefiltrado = string.Empty;
        private string pedidofiltrado = string.Empty;
        private string posicionfiltrado = string.Empty;
        private string ultimocambio = string.Empty;
        private List<string> plantas = new List<string>();
        private List<string> bodegas = new List<string>();
        private List<string> clasificaciones = new List<string>();
        private List<string> pallets = new List<string>();
        private List<string> bobinas = new List<string>();
        private List<string> peliculas = new List<string>();
        private List<string> anchos = new List<string>();
        private List<string> diametros = new List<string>();
        private List<string> cores = new List<string>();
        private List<string> clientes = new List<string>();
        private List<string> pedidos = new List<string>();
        private List<string> posiciones = new List<string>();
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        DataSet DS3 = new DataSet();

        public frmCompleteCoilInventory()
        {
            InitializeComponent();
            ObtenerDS();
            llenardgv();
        }

        private void ObtenerDS()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwInventarioCompletoBobinas");
        }

        private void llenardgv()
        {
            int cantbobNP = 0;
            int cantbobP = 0;
            double pesos = 0;
            dgv.Rows.Clear();
            plantas = new List<string>();
            bodegas = new List<string>();
            clasificaciones = new List<string>();
            pallets = new List<string>();
            bobinas = new List<string>();
            peliculas = new List<string>();
            anchos = new List<string>();
            diametros = new List<string>();
            cores = new List<string>();
            clientes = new List<string>();
            pedidos = new List<string>();
            posiciones = new List<string>();

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    string concat = plantafiltrado + bodegafiltrado + clasificacionfiltrado + palletfiltrado + bobinafiltrado + peliculafiltrado + anchofiltrado + diametrofiltrado + corefiltrado + clientefiltrado + pedidofiltrado + posicionfiltrado;
                    string concat2 = string.Empty;

                    if (plantafiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Planta"]);
                    }
                    if (bodegafiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Bodega"]);
                    }
                    if (clasificacionfiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Clasificación"]);
                    }
                    if (palletfiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Pallet"]);
                    }
                    if (bobinafiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Bobina"]);
                    }
                    if (peliculafiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Pelicula"]);
                    }
                    if (anchofiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Ancho"]);
                    }
                    if (diametrofiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Diametro"]);
                    }
                    if (corefiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Core"]);
                    }
                    if (clientefiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Cliente"]);
                    }
                    if (pedidofiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Pedido"]);
                    }
                    if (posicionfiltrado != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Posicion"]);
                    }
                    if(concat==concat2)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToShortDateString();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Planta.Index].Value = DS.Tables[0].Rows[i]["Planta"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Bodega.Index].Value = DS.Tables[0].Rows[i]["Bodega"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Clasificacion.Index].Value = DS.Tables[0].Rows[i]["Clasificación"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Origen.Index].Value = DS.Tables[0].Rows[i]["Origen"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Pallet.Index].Value = DS.Tables[0].Rows[i]["Pallet"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Bobina.Index].Value = DS.Tables[0].Rows[i]["Bobina"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Pelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Core.Index].Value = DS.Tables[0].Rows[i]["Core"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Cliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Pedido.Index].Value = DS.Tables[0].Rows[i]["Pedido"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[PesoNeto.Index].Value = DS.Tables[0].Rows[i]["PesoNetoActual"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Calificacion.Index].Value = DS.Tables[0].Rows[i]["Calificación"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Estado.Index].Value = DS.Tables[0].Rows[i]["Estado"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Observaciones.Index].Value = DS.Tables[0].Rows[i]["Observaciones"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Posicion.Index].Value = DS.Tables[0].Rows[i]["Posicion"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Destino.Index].Value = DS.Tables[0].Rows[i]["DestinoRevision"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[Reproceso.Index].Value = DS.Tables[0].Rows[i]["Reproceso"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[AnchoUtil.Index].Value = DS.Tables[0].Rows[i]["AnchoUtil"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[DetalleRevision.Index].Value = DS.Tables[0].Rows[i]["DetalleRevision"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[UsuarioRevision.Index].Value = DS.Tables[0].Rows[i]["UsuarioRevision"];
                        dgv.Rows[dgv.Rows.Count - 1].Cells[FechaRevision.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaRevision"]).ToShortDateString();
                        dgv.Rows[dgv.Rows.Count - 1].Cells[PesoTeorico.Index].Value = DS.Tables[0].Rows[i]["PesoTeorico"];

                        if (!plantas.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                        {
                            plantas.Add(DS.Tables[0].Rows[i]["Planta"].ToString());
                        }
                        if (!bodegas.Contains(DS.Tables[0].Rows[i]["Bodega"].ToString()))
                        {
                            bodegas.Add(DS.Tables[0].Rows[i]["Bodega"].ToString());
                        }
                        if (!clasificaciones.Contains(DS.Tables[0].Rows[i]["Clasificación"].ToString()))
                        {
                            clasificaciones.Add(DS.Tables[0].Rows[i]["Clasificación"].ToString());
                        }
                        if (!pallets.Contains(DS.Tables[0].Rows[i]["Pallet"].ToString()))
                        {
                            pallets.Add(DS.Tables[0].Rows[i]["Pallet"].ToString());
                        }
                        if (!bobinas.Contains(DS.Tables[0].Rows[i]["Bobina"].ToString()))
                        {
                            bobinas.Add(DS.Tables[0].Rows[i]["Bobina"].ToString());
                        }
                        if (!peliculas.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        {
                            peliculas.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());
                        }
                        if (!anchos.Contains(DS.Tables[0].Rows[i]["Ancho"].ToString()))
                        {
                            anchos.Add(DS.Tables[0].Rows[i]["Ancho"].ToString());
                        }
                        if (!diametros.Contains(DS.Tables[0].Rows[i]["Diametro"].ToString()))
                        {
                            diametros.Add(DS.Tables[0].Rows[i]["Diametro"].ToString());
                        }
                        if (!cores.Contains(DS.Tables[0].Rows[i]["Core"].ToString()))
                        {
                            cores.Add(DS.Tables[0].Rows[i]["Core"].ToString());
                        }
                        if (!clientes.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        {
                            clientes.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                        }
                        if (!pedidos.Contains(DS.Tables[0].Rows[i]["Pedido"].ToString()))
                        {
                            pedidos.Add(DS.Tables[0].Rows[i]["Pedido"].ToString());
                        }
                        if (!posiciones.Contains(DS.Tables[0].Rows[i]["Posicion"].ToString()))
                        {
                            posiciones.Add(DS.Tables[0].Rows[i]["Posicion"].ToString());
                        }
                    }
                }      
            }

            plantas.Sort();
            bodegas.Sort();
            clasificaciones.Sort();
            pallets.Sort();
            bobinas.Sort();
            peliculas.Sort();
            anchos.Sort();
            diametros.Sort();
            cores.Sort();
            clientes.Sort();
            pedidos.Sort();
            posiciones.Sort();

            if (ultimocambio != "planta")
            {
                cmbFiltroPlanta.Items.Clear();
                for (int i = 0; i < plantas.Count; i++)
                {
                    cmbFiltroPlanta.Items.Add(plantas[i]);
                }
            }
            if (ultimocambio != "bodega")
            {
                cmbFiltroBodega.Items.Clear();
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbFiltroBodega.Items.Add(bodegas[i]);
                }
            }
            if (ultimocambio != "clasificacion")
            {
                cmbFiltroClasificacion.Items.Clear();
                for (int i = 0; i < clasificaciones.Count; i++)
                {
                    cmbFiltroClasificacion.Items.Add(clasificaciones[i]);
                }
            }
            if (ultimocambio != "pallet")
            {
                cmbFiltroPallet.Items.Clear();
                for (int i = 0; i < pallets.Count; i++)
                {
                    cmbFiltroPallet.Items.Add(pallets[i]);
                }
            }
            if (ultimocambio != "bobina")
            {
                cmbFiltroBobina.Items.Clear();
                for (int i = 0; i < bobinas.Count; i++)
                {
                    cmbFiltroBobina.Items.Add(bobinas[i]);
                }
            }
            if (ultimocambio != "pelicula")
            {
                cmbFiltroPelicula.Items.Clear();
                for (int i = 0; i < peliculas.Count; i++)
                {
                    cmbFiltroPelicula.Items.Add(peliculas[i]);
                }
            }
            if (ultimocambio != "ancho")
            {
                cmbFiltroAncho.Items.Clear();
                for (int i = 0; i < anchos.Count; i++)
                {
                    cmbFiltroAncho.Items.Add(anchos[i]);
                }
            }
            if (ultimocambio != "diametro")
            {
                cmbFiltroDiametro.Items.Clear();
                for (int i = 0; i < diametros.Count; i++)
                {
                    cmbFiltroDiametro.Items.Add(diametros[i]);
                }
            }
            if (ultimocambio != "core")
            {
                cmbFiltroCore.Items.Clear();
                for (int i = 0; i < cores.Count; i++)
                {
                    cmbFiltroCore.Items.Add(cores[i]);
                }
            }
            if (ultimocambio != "cliente")
            {
                cmbFiltroCliente.Items.Clear();
                for (int i = 0; i < clientes.Count; i++)
                {
                    cmbFiltroCliente.Items.Add(clientes[i]);
                }
            }
            if (ultimocambio != "pedido")
            {
                cmbFiltroPedido.Items.Clear();
                for (int i = 0; i < pedidos.Count; i++)
                {
                    cmbFiltroPedido.Items.Add(pedidos[i]);
                }
            }
            if (ultimocambio != "posicion")
            {
                cmbFiltroPosicion.Items.Clear();
                for (int i = 0; i < posiciones.Count; i++)
                {
                    cmbFiltroPosicion.Items.Add(posiciones[i]);
                }
            }

            // Agrego el totalizador
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[Pallet.Index].Value.ToString() != "-")
                {
                    cantbobP++;
                }
                else
                {
                    cantbobNP++;
                }
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[PesoNeto.Index].Value);
                txtPesosTot.Text = Math.Round(pesos, 2).ToString();
            }

            txtCantBobP.Text = cantbobP.ToString();
            txtBobNP.Text = cantbobNP.ToString();

        }

        private void cmbFiltroPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPlanta.SelectedIndex != -1)
            {
                if (plantafiltrado != cmbFiltroPlanta.SelectedItem.ToString())
                {
                    plantafiltrado = cmbFiltroPlanta.SelectedItem.ToString();
                    ultimocambio = "planta";
                    llenardgv();
                }
            }
            else
            {
                plantafiltrado = string.Empty;
            }
        }

        private void cmbFiltroBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroBodega.SelectedIndex != -1)
            {
                if (bodegafiltrado != cmbFiltroBodega.SelectedItem.ToString())
                {
                    bodegafiltrado = cmbFiltroBodega.SelectedItem.ToString();
                    ultimocambio = "bodega";
                    llenardgv();
                }
            }
            else
            {
                bodegafiltrado = string.Empty;
            }
        }

        private void cmbFiltroOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroClasificacion.SelectedIndex != -1)
            {
                if (clasificacionfiltrado != cmbFiltroClasificacion.SelectedItem.ToString())
                {
                    clasificacionfiltrado = cmbFiltroClasificacion.SelectedItem.ToString();
                    ultimocambio = "clasificacion";
                    llenardgv();
                }
            }
            else
            {
                clasificacionfiltrado = string.Empty;
            }
        }

        private void cmbFiltroPallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPallet.SelectedIndex != -1)
            {
                if (palletfiltrado != cmbFiltroPallet.SelectedItem.ToString())
                {
                    palletfiltrado = cmbFiltroPallet.SelectedItem.ToString();
                    ultimocambio = "pallet";
                    llenardgv();
                }
            }
            else
            {
                palletfiltrado = string.Empty;
            }
        }

        private void cmbFiltroBobina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroBobina.SelectedIndex != -1)
            {
                if (bobinafiltrado != cmbFiltroBobina.SelectedItem.ToString())
                {
                    bobinafiltrado = cmbFiltroBobina.SelectedItem.ToString();
                    ultimocambio = "bobina";
                    llenardgv();
                }
            }
            else
            {
                bobinafiltrado = string.Empty;
            }
        }

        private void cmbFiltroPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPelicula.SelectedIndex != -1)
            {
                if (peliculafiltrado != cmbFiltroPelicula.SelectedItem.ToString())
                {
                    peliculafiltrado = cmbFiltroPelicula.SelectedItem.ToString();
                    ultimocambio = "pelicula";
                    llenardgv();
                }
            }
            else
            {
                peliculafiltrado = string.Empty;
            }
        }

        private void cmbFiltroAncho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroAncho.SelectedIndex != -1)
            {
                if (anchofiltrado != cmbFiltroAncho.SelectedItem.ToString())
                {
                    anchofiltrado = cmbFiltroAncho.SelectedItem.ToString();
                    ultimocambio = "ancho";
                    llenardgv();
                }
            }
            else
            {
                anchofiltrado = string.Empty;
            }
        }

        private void cmbFiltroDiametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroDiametro.SelectedIndex != -1)
            {
                if (diametrofiltrado != cmbFiltroDiametro.SelectedItem.ToString())
                {
                    diametrofiltrado = cmbFiltroDiametro.SelectedItem.ToString();
                    ultimocambio = "diametro";
                    llenardgv();
                }
            }
            else
            {
                diametrofiltrado = string.Empty;
            }
        }

        private void cmbFiltroCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCore.SelectedIndex != -1)
            {
                if (corefiltrado != cmbFiltroCore.SelectedItem.ToString())
                {
                    corefiltrado = cmbFiltroCore.SelectedItem.ToString();
                    ultimocambio = "core";
                    llenardgv();
                }
            }
            else
            {
                corefiltrado = string.Empty;
            }
        }

        private void cmbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCliente.SelectedIndex != -1)
            {
                if (clientefiltrado != cmbFiltroCliente.SelectedItem.ToString())
                {
                    clientefiltrado = cmbFiltroCliente.SelectedItem.ToString();
                    ultimocambio = "cliente";
                    llenardgv();
                }
            }
            else
            {
                clientefiltrado = string.Empty;
            }
        }

        private void cmbFiltroPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPedido.SelectedIndex != -1)
            {
                if (pedidofiltrado != cmbFiltroPedido.SelectedItem.ToString())
                {
                    pedidofiltrado = cmbFiltroPedido.SelectedItem.ToString();
                    ultimocambio = "pedido";
                    llenardgv();
                }
            }
            else
            {
                pedidofiltrado = string.Empty;
            }
        }

        private void cmbFiltroPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroPosicion.SelectedIndex != -1)
            {
                if (posicionfiltrado != cmbFiltroPosicion.SelectedItem.ToString())
                {
                    posicionfiltrado = cmbFiltroPosicion.SelectedItem.ToString();
                    ultimocambio = "posicion";
                    llenardgv();
                }
            }
            else
            {
                posicionfiltrado = string.Empty;
            }
        }

        private void cmbFiltroPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPlanta.ResetText();
                plantafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroBodega.ResetText();
                bodegafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroClasificacion.ResetText();
                clasificacionfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPallet.ResetText();
                palletfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroBobina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroBobina.ResetText();
                bobinafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroPelicula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPelicula.ResetText();
                peliculafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroAncho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroAncho.ResetText();
                anchofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroDiametro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroDiametro.ResetText();
                diametrofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroCore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroCore.ResetText();
                corefiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroCliente.ResetText();
                clientefiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPedido.ResetText();
                pedidofiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbFiltroPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroPosicion.ResetText();
                posicionfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            plantafiltrado = string.Empty;
            bodegafiltrado = string.Empty;
            clasificacionfiltrado = string.Empty;
            palletfiltrado = string.Empty;
            bobinafiltrado = string.Empty;
            peliculafiltrado = string.Empty;
            anchofiltrado = string.Empty;
            diametrofiltrado = string.Empty;
            corefiltrado = string.Empty;
            clientefiltrado = string.Empty;
            pedidofiltrado = string.Empty;
            posicionfiltrado = string.Empty;

            cmbFiltroPlanta.ResetText();
            cmbFiltroPlanta.SelectedIndex = -1;
            cmbFiltroBodega.ResetText();
            cmbFiltroBodega.SelectedIndex = -1;
            cmbFiltroClasificacion.ResetText();
            cmbFiltroClasificacion.SelectedIndex = -1;
            cmbFiltroPallet.ResetText();
            cmbFiltroPallet.SelectedIndex = -1;
            cmbFiltroBobina.ResetText();
            cmbFiltroBobina.SelectedIndex = -1;
            cmbFiltroPelicula.ResetText();
            cmbFiltroPelicula.SelectedIndex = -1;
            cmbFiltroAncho.ResetText();
            cmbFiltroAncho.SelectedIndex = -1;
            cmbFiltroDiametro.ResetText();
            cmbFiltroDiametro.SelectedIndex = -1;
            cmbFiltroCore.ResetText();
            cmbFiltroCore.SelectedIndex = -1;
            cmbFiltroCliente.ResetText();
            cmbFiltroCliente.SelectedIndex = -1;
            cmbFiltroPedido.ResetText();
            cmbFiltroPedido.SelectedIndex = -1;
            cmbFiltroPosicion.ResetText();
            cmbFiltroPosicion.SelectedIndex = -1;

            ObtenerDS();
            llenardgv();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
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

        

        
    }
}
