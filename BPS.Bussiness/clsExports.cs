using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Data;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    public class clsExports
    {
        public static void createExcel(DataGridView dgv)
        {
            var wb = new XLWorkbook();

            var ws = wb.Worksheets.Add("Hoja 1");

            int col = 1;
            int fil = 1;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    ws.Cell(fil, col).Value = dgv.Columns[i].HeaderText;
                    col++;
                }
            }

            col = 1;
            fil = 2;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Columns[j].Visible)
                    {
                        ws.Cell(fil, col).Value = dgv.Rows[i].Cells[j].Value;
                        col++;
                    }
                }
                fil++;
                col = 1;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(sfd.FileName);
                MessageBox.Show("El archivo se creó en " + sfd.FileName, "Archivo creado correctamente", MessageBoxButtons.OK);
            }
        }

        public static void createExcelWhitCheck(DataGridView dgv)
        {
            var wb = new XLWorkbook();

            var ws = wb.Worksheets.Add("Hoja 1");

            int col = 1;
            int fil = 1;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    ws.Cell(fil, col).Value = dgv.Columns[i].HeaderText;
                    col++;
                }
            }

            col = 1;
            fil = 2;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Columns[j].Visible && Convert.ToBoolean(dgv.Rows[i].Cells[dgv.Columns.Count-1].Value))
                    {
                        ws.Cell(fil, col).Value = dgv.Rows[i].Cells[j].Value;
                        col++;
                    }                    
                }
                fil++;
                col = 1;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(sfd.FileName);
                MessageBox.Show("El archivo se creó en " + sfd.FileName, "Archivo creado correctamente", MessageBoxButtons.OK);
            }

        }
    }
}
