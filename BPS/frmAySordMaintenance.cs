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
    public partial class frmAySordMaintenance : Form
    {
        clsSalesOrderDetail obj = new clsSalesOrderDetail();
        List<int> indexlist = new List<int>();
        public frmAySordMaintenance()
        {
            InitializeComponent();
        }

        public frmAySordMaintenance(int sodcodsec)
        {
            InitializeComponent();

            obj = new clsSalesOrderDetail(sodcodsec);
            populateDataGrid();
            clsSalesOrder objSaleOrder = new clsSalesOrder(obj.fkSalesOrder);
            clsProduct objProd = new clsProduct(obj.fkProduct);

            txtOrder.Text = objSaleOrder.number.ToString();
            txtCustomer.Text = objSaleOrder.EntityName.ToString();
            txtProduct.Text = objProd.code.ToString();
            txtSolicitedQuantity.Text = obj.quantity.ToString();
        }

        public void populateDataGrid()
        {
            List<clsAymasSalesOrder> lst = new List<clsAymasSalesOrder>();

            lst=clsAymasSalesOrder.GetList(obj.codsec);
            dgvAySordMaintenance.Rows.Clear();

            for (int i = 0; i < lst.Count; i++)
            {
                dgvAySordMaintenance.Rows.Add();
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmCodsec.Index].Value = lst[i].codsec;
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmNumber.Index].Value = lst[i].number;
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmQuantity.Index].Value = lst[i].quantity;
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmUser.Index].Value = new clsUser(lst[i].fkUser).userName;
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmDate.Index].Value = lst[i].date;
                dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmStatus.Index].Value = lst[i].status;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvAySordMaintenance.Rows.Add();
            indexlist.Add(dgvAySordMaintenance.Rows.Count - 1);
            dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count -1 ].Cells[clmUser.Index].Value = clsGlobal.LoggedUser.userName;
            dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmDate.Index].Value = DateTime.Now;
            dgvAySordMaintenance.Rows[dgvAySordMaintenance.Rows.Count - 1].Cells[clmStatus.Index].Value = "Abierta";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAymasSalesOrder objSo = new clsAymasSalesOrder();
            clsUser objusr = new clsUser();
            objusr.load(clsGlobal.LoggedUser.userName.ToString());
            for(int i=0; i<indexlist.Count;i++)
            {
                objSo.fkSalesOrderDetail = obj.codsec;
                objSo.fkUser = objusr.codsec;
                objSo.date= Convert.ToDateTime(dgvAySordMaintenance.Rows[indexlist[i]].Cells[clmDate.Index].Value);
                objSo.number = Convert.ToInt32(dgvAySordMaintenance.Rows[indexlist[i]].Cells[clmNumber.Index].Value);
                objSo.quantity = Convert.ToInt32(dgvAySordMaintenance.Rows[indexlist[i]].Cells[clmQuantity.Index].Value);
                objSo.status = "Abierta";
                objSo.save();
            }

        }

        private void dgvAySordMaintenance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmStatus.Index)
            {
                clsAymasSalesOrder objso = new clsAymasSalesOrder(Convert.ToInt32(dgvAySordMaintenance.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                if(objso.status=="Abierta")
                {
                    if (objso.close())
                    {
                        MessageBox.Show("Orden de venta cerrada correctamente", "Mantenimiento de OV Aymas", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error y no se pudo cerrar la OV.", "Mantenimiento de OV Aymas", MessageBoxButtons.OK);
                    }
                }
                else if(objso.status=="Cerrada")
                {
                    if (objso.open())
                    {
                        MessageBox.Show("Orden de venta abierta correctamente", "Mantenimiento de OV Aymas", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error y no se pudo abrir la OV.", "Mantenimiento de OV Aymas", MessageBoxButtons.OK);
                    }
                }
                populateDataGrid();
            }
        }

        private void dgvAySordMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmDelete.Index)
            {
                if(Convert.ToInt32(dgvAySordMaintenance.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)==0)
                {
                    indexlist.Remove(e.RowIndex);
                    dgvAySordMaintenance.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Solo se pueden eliminar OVs nuevas. Intente cerrar la OV haciendo doble clic sobre el estado.");
                }
            }
        }





    }
}
