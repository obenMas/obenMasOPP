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
    public partial class frmBoppNewFormulationDetail : Form
    {
        clsNewFormulation objNewFormulation = new clsNewFormulation();
        public frmBoppNewFormulationDetail()
        {
            InitializeComponent();
        }
        public frmBoppNewFormulationDetail(int nfcodsec)
        {
            InitializeComponent();
            objNewFormulation.load(nfcodsec);
            if (objNewFormulation.ContarCapas() == 3)
                CargarDatos(3024);
            else if (objNewFormulation.ContarCapas() == 5)
                CargarDatos(11);
        }

        public void CargarDatos(int machine)
        {
            clsBopp Pelicula = new clsBopp(objNewFormulation.fkBopp);
            if(machine==3024)
            {
                pCE3.Visible = false;
                pCE4.Visible = false;
                pCE5.Visible = false;
                txtPelicula.Text = "["+Pelicula.code+"] "+Pelicula.name;
                txtNombre.Text = objNewFormulation.Name;
                txtObservaciones.Text = objNewFormulation.Description;
                txtEspesorT.Text = objNewFormulation.Thickness.ToString();
                txtEspesorCC.Text = objNewFormulation.lstLayerThickByNewFormulation[0].Thickness.ToString();
                txtEspesorCE1.Text = objNewFormulation.lstLayerThickByNewFormulation[1].Thickness.ToString();
                txtEspesorCE2.Text = objNewFormulation.lstLayerThickByNewFormulation[2].Thickness.ToString();
                for (int i = 0; i < objNewFormulation.lstNewFormulationDetail.Count; i++)
                {
                    clsRawMaterial objMaterial = new clsRawMaterial(objNewFormulation.lstNewFormulationDetail[i].fkRawMaterial);
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 2)
                    {
                        dgvCapaCentral.Rows.Add();
                        int fila = dgvCapaCentral.Rows.Count - 1;
                        dgvCapaCentral.Rows[fila].Cells[clmMateriaPrimaCC.Index].Value = objMaterial.name;
                        dgvCapaCentral.Rows[fila].Cells[clmPorcentajeCC.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 1)
                    {
                        dgvCE1.Rows.Add();
                        int fila = dgvCE1.Rows.Count - 1;
                        dgvCE1.Rows[fila].Cells[clmMateriaPrimaCE1.Index].Value = objMaterial.name;
                        dgvCE1.Rows[fila].Cells[clmPorcentajeCE1.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 3)
                    {
                        dgvCE2.Rows.Add();
                        int fila = dgvCE2.Rows.Count - 1;
                        dgvCE2.Rows[fila].Cells[clmMateriaPrimaCE2.Index].Value = objMaterial.name;
                        dgvCE2.Rows[fila].Cells[clmPorcentajeCE2.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                }
            }
            if (machine == 11)
            {
                pCE5.Visible = false;
                txtPelicula.Text = "[" + Pelicula.code + "] " + Pelicula.name;
                txtNombre.Text = objNewFormulation.Name;
                txtObservaciones.Text = objNewFormulation.Description;
                txtEspesorT.Text = objNewFormulation.Thickness.ToString();
                txtEspesorCC.Text = objNewFormulation.lstLayerThickByNewFormulation[0].Thickness.ToString();
                txtEspesorCE1.Text = objNewFormulation.lstLayerThickByNewFormulation[1].Thickness.ToString();
                txtEspesorCE2.Text = objNewFormulation.lstLayerThickByNewFormulation[2].Thickness.ToString();
                txtEspesorCE3.Text = objNewFormulation.lstLayerThickByNewFormulation[3].Thickness.ToString();
                txtEspesorCE4.Text = objNewFormulation.lstLayerThickByNewFormulation[4].Thickness.ToString();
                for(int i=0;i<objNewFormulation.lstNewFormulationDetail.Count;i++)
                {
                    clsRawMaterial objMaterial = new clsRawMaterial(objNewFormulation.lstNewFormulationDetail[i].fkRawMaterial);
                    if(objNewFormulation.lstNewFormulationDetail[i].fkLayer==6)
                    {
                        dgvCapaCentral.Rows.Add();
                        int fila = dgvCapaCentral.Rows.Count - 1;
                        dgvCapaCentral.Rows[fila].Cells[clmMateriaPrimaCC.Index].Value = objMaterial.name;
                        dgvCapaCentral.Rows[fila].Cells[clmPorcentajeCC.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 4)
                    {
                        dgvCE1.Rows.Add();
                        int fila = dgvCE1.Rows.Count - 1;
                        dgvCE1.Rows[fila].Cells[clmMateriaPrimaCE1.Index].Value = objMaterial.name;
                        dgvCE1.Rows[fila].Cells[clmPorcentajeCE1.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 5)
                    {
                        dgvCE2.Rows.Add();
                        int fila = dgvCE2.Rows.Count - 1;
                        dgvCE2.Rows[fila].Cells[clmMateriaPrimaCE2.Index].Value = objMaterial.name;
                        dgvCE2.Rows[fila].Cells[clmPorcentajeCE2.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 7)
                    {
                        dgvCE3.Rows.Add();
                        int fila = dgvCE3.Rows.Count - 1;
                        dgvCE3.Rows[fila].Cells[clmMateriaPrimaCE3.Index].Value = objMaterial.name;
                        dgvCE3.Rows[fila].Cells[clmPorcentajeCE3.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                    if (objNewFormulation.lstNewFormulationDetail[i].fkLayer == 8)
                    {
                        dgvCE4.Rows.Add();
                        int fila = dgvCE4.Rows.Count - 1;
                        dgvCE4.Rows[fila].Cells[clmMateriaPrimaCE4.Index].Value = objMaterial.name;
                        dgvCE4.Rows[fila].Cells[clmPorcentajeCE4.Index].Value = objNewFormulation.lstNewFormulationDetail[i].Percentage;
                    }
                }
            }
        }
    }
}
