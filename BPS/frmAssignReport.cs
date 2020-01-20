using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmAssignReport : Form
    {
        public frmAssignReport()
        {
            InitializeComponent();
        }

        private void btnGenerateAssignRp_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                string texto = "CALL spReassignReport '" + dateTPFromAssign.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToAssign.Value.ToString("dd/MM/yyyy") + "';";
                DS = clsConnection.getDataSetResult(texto);

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Reporte de Asignaciones";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Reporte de asignaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reporte de asignaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

    

