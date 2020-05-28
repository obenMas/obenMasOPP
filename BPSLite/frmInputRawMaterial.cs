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
    public partial class frmInputRawMaterial : Form
    {
        public frmInputRawMaterial()
        {
            InitializeComponent();
        }

        private void Importar_Click(object sender, EventArgs e)
        {
            DataTable accesTabla = new DataTable(); // Declaro la variable donde voy a meter la tabla.

            if (clsGlobal.LoggedUser.fkRole == 2032)
            {
                accesTabla = clsConnectionAccess.getINGP0(); //Recordar preguntar como se hardcodea esto. 
            }
            else
            {
                accesTabla = clsConnectionAccess.getINGP1();
            }
            
            dgvEntradaMaterPrima.AutoGenerateColumns = false;

            dgvEntradaMaterPrima.DataSource = accesTabla;

            dgvEntradaMaterPrima.Sort(clmFecha, System.ComponentModel.ListSortDirection.Descending);
        }

        private void dgvEntradaMaterPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == clmPallets.Index)
            {
                clsRawMaterial rawMat = new clsRawMaterial();
                rawMat = clsRawMaterial.getObjByCode(Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[0].Value));

                if (rawMat.codsec != 0)
                {
                    string codigo = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[0].Value);
                    string cantidad = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[1].Value);
                    string partida = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[2].Value);
                    string proveedor = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[3].Value);
                    string nombreEmpresa = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[5].Value);
                    string refe = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[7].Value);

                    frmImportRawMaterial importRaw = new frmImportRawMaterial(codigo, cantidad, partida, proveedor, nombreEmpresa,refe);
                    importRaw.Show();
                }
                else
                {
                    MessageBox.Show("La materia prima que intenta ingresar no se encuentra en existencia.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

           if (e.ColumnIndex == clmGranel.Index)
           {
               clsRawMaterial rawMat = new clsRawMaterial();
               rawMat = clsRawMaterial.getObjByCode(Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[0].Value));

               if (rawMat.codsec != 0)
               {
                   string codigo = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[0].Value);
                   string cantidad = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[1].Value);
                   string partida = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[2].Value);
                   string proveedor = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[3].Value);
                   string nombreEmpresa = Convert.ToString(dgvEntradaMaterPrima.Rows[dgvEntradaMaterPrima.CurrentRow.Index].Cells[5].Value);

                   frmImportRawMaterialGranel importRaw = new frmImportRawMaterialGranel(codigo, cantidad, partida, proveedor, nombreEmpresa);
                   importRaw.Show();
               }
               else
               {
                   MessageBox.Show("La materia prima que intenta ingresar no se encuentra en existencia.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               } 
           }
        }
    }
}
