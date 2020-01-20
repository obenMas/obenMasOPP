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
    public partial class frmCalculationMaterialCost : Form
    {
        clsNewFormulation objNewFormulation = new clsNewFormulation();
        clsRawMaterial rawmaterial = new clsRawMaterial();
        DataSet DS = new DataSet();
        public frmCalculationMaterialCost()
        {
            InitializeComponent();
        }
        public frmCalculationMaterialCost(List<clsMaterialCost> lstmt)
        {
            InitializeComponent();
            bool primero = true;
            for (int z = 0; z < lstmt.Count;z++ )
            {
                #region BRUCKNER
                if (lstmt[z].fkMachine==3024)
                {
                    clsNewFormulation objnf = new clsNewFormulation();
                    objnf.loadByBoppStandar(lstmt[z].fkBopp, lstmt[z].fkMachine);
                    float PCapaCentral = 0; float PCE1 = 0; float PCE2 = 0;
                    for (int i = 0; i < objnf.lstLayerThickByNewFormulation.Count; i++)
                    {
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 2) PCapaCentral = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 1) PCE1 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 3) PCE2 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    }
                    for (int x = 0; x < objnf.lstNewFormulationDetail.Count; x++)
                    {
                        clsRawMaterial mat;
                        if (x == 0 && primero == true)
                        {
                            mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                            dgv.Rows.Add();
                            int fila = dgv.Rows.Count - 1;
                            dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                            dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                            dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                            dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            primero = false;
                        }
                        else
                        {
                            mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                            bool existe = false; int matindex = 0;
                            for (int i = 0; i < dgv.Rows.Count; i++)
                                if (Convert.ToInt32(dgv.Rows[i].Cells[clmCodsecMaterial.Index].Value) == objnf.lstNewFormulationDetail[x].fkRawMaterial)
                                {
                                    existe = true;
                                    matindex = i;
                                }
                            if (existe == false)
                            {
                                dgv.Rows.Add();
                                int fila = dgv.Rows.Count - 1;
                                dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                                dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                                dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                                dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            }
                            else
                            {
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            }
                        }
                    }
                }
                #endregion
                #region DTM
                if (lstmt[z].fkMachine == 11)
                {
                    clsNewFormulation objnf = new clsNewFormulation();
                    objnf.loadByBoppStandar(lstmt[z].fkBopp, lstmt[z].fkMachine);
                    float PCapaCentral = 0; float PCE1 = 0; float PCE2 = 0; float PCE3 = 0; float PCE4 = 0;
                    for (int i = 0; i < objnf.lstLayerThickByNewFormulation.Count; i++)
                    {
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 6) PCapaCentral = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 4) PCE1 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 5) PCE2 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 7) PCE3 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                        if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 8) PCE4 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    }
                    for (int x = 0; x < objnf.lstNewFormulationDetail.Count; x++)
                    {
                        clsRawMaterial mat;
                        if (x == 0 && primero == true)
                        {
                            mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                            dgv.Rows.Add();
                            int fila = dgv.Rows.Count - 1;
                            dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                            dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                            dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                            dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[x].subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            primero = false;
                        }
                        else
                        {
                            mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                            bool existe = false; int matindex = 0;
                            for (int i = 0; i < dgv.Rows.Count; i++)
                                if (Convert.ToInt32(dgv.Rows[i].Cells[clmCodsecMaterial.Index].Value) == objnf.lstNewFormulationDetail[x].fkRawMaterial)
                                {
                                    existe = true;
                                    matindex = i;
                                }
                            if (existe == false)
                            {
                                dgv.Rows.Add();
                                int fila = dgv.Rows.Count - 1;
                                dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                                dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                                dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                                dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                                    dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((lstmt[z].subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            }
                            else
                            {
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                                if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                                    dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((lstmt[z].subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            }
                        }
                    }
                }
                #endregion
            }
        }
        public frmCalculationMaterialCost(clsMaterialCost obj)
        {
            InitializeComponent();
            clsNewFormulation objnf = new clsNewFormulation();
            objnf.loadByBoppStandar(obj.fkBopp,obj.fkMachine);
            #region BRUCKNER
            if (objnf.fkMachine==3024)
            {
                float PCapaCentral = 0; float PCE1 = 0; float PCE2 = 0;
                for (int i = 0; i < objnf.lstLayerThickByNewFormulation.Count; i++)
                {
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 2) PCapaCentral = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 1) PCE1 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 3) PCE2 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                }
                for (int x = 0; x < objnf.lstNewFormulationDetail.Count; x++)
                {
                    clsRawMaterial mat;
                    if (x == 0)
                    {
                        mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                        dgv.Rows.Add();
                        int fila = dgv.Rows.Count - 1;
                        dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                        dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                        dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                        dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                    }
                    else
                    {
                        mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                        bool existe = false; int matindex = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                            if (Convert.ToInt32(dgv.Rows[i].Cells[clmCodsecMaterial.Index].Value) == objnf.lstNewFormulationDetail[x].fkRawMaterial)
                            {
                                existe = true;
                                matindex = i;
                            }
                        if (existe == false)
                        {
                            dgv.Rows.Add();
                            int fila = dgv.Rows.Count - 1;
                            dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                            dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                            dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                            dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        }
                        else
                        {
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 2)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 1)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 3)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        }
                    }
                }
            }
            #endregion
            #region DTM
            if (objnf.fkMachine == 11)
            {
                float PCapaCentral = 0; float PCE1 = 0; float PCE2 = 0; float PCE3 = 0; float PCE4 = 0;
                for (int i = 0; i < objnf.lstLayerThickByNewFormulation.Count; i++)
                {
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 6) PCapaCentral = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 4) PCE1 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 5) PCE2 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 7) PCE3 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                    if (objnf.lstLayerThickByNewFormulation[i].fkLayer == 8) PCE4 = ((objnf.lstLayerThickByNewFormulation[i].Thickness * 100) / objnf.Thickness) / 100;
                }
                for (int x = 0; x < objnf.lstNewFormulationDetail.Count; x++)
                {
                    clsRawMaterial mat;
                    if (x == 0)
                    {
                        mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                        dgv.Rows.Add();
                        int fila = dgv.Rows.Count - 1;
                        dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                        dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                        dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                        dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                            dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                    }
                    else
                    {
                        mat = new clsRawMaterial(objnf.lstNewFormulationDetail[x].fkRawMaterial);
                        bool existe = false; int matindex = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                            if (Convert.ToInt32(dgv.Rows[i].Cells[clmCodsecMaterial.Index].Value) == objnf.lstNewFormulationDetail[x].fkRawMaterial)
                            {
                                existe = true;
                                matindex = i;
                            }
                        if (existe == false)
                        {
                            dgv.Rows.Add();
                            int fila = dgv.Rows.Count - 1;
                            dgv.Rows[fila].Cells[clmCodsecMaterial.Index].Value = mat.codsec;
                            dgv.Rows[fila].Cells[clmNombreMaterial.Index].Value = mat.name;
                            dgv.Rows[fila].Cells[clmTipo.Index].Value = mat.RawMaterialtypeName;
                            dgv.Rows[fila].Cells[clmStock.Index].Value = DeterminarStock(mat.codsec);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                                dgv.Rows[fila].Cells[clmCantidad.Index].Value = Math.Round((obj.subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        }
                        else
                        {
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 6)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCapaCentral) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 4)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE1) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 5)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE2) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 7)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE3) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                            if (objnf.lstNewFormulationDetail[x].fkLayer == 8)
                                dgv.Rows[matindex].Cells[clmCantidad.Index].Value = Convert.ToDouble(dgv.Rows[matindex].Cells[clmCantidad.Index].Value) + Math.Round((obj.subtotal * PCE4) * (objnf.lstNewFormulationDetail[x].Percentage / 100), MidpointRounding.ToEven);
                        }
                    }
                }
            }
            #endregion
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public float DeterminarStock(int fkraw)
        {
            DS = clsConnection.getDataSetResult("CALL spRawPalletInCoilCellarStockTotalizedByRaw(" + fkraw.ToString() + ")");
            if (DS.Tables[0].Rows.Count > 0)
                return float.Parse(DS.Tables[0].Rows[0]["Peso"].ToString());
            else
                return 0;
        }

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
    }
}
