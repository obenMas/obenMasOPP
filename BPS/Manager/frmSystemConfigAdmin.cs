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
    public partial class frmSystemConfigAdmin : Form
    {
        public bool isAutoricet = false;
        List<CheckBox> lstCheckBox = new List<CheckBox>();

        public frmSystemConfigAdmin()
        {
            frmCellarLogin winLogin = new frmCellarLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
                InitializeComponent();
            else
                this.Close();
        }

        private void frmSystemConfigAdmin_Load(object sender, EventArgs e)
        {
            PopulateRole();
        }

        private void PopulateRole()
        {
            List<clsRole> lstRole = new List<clsRole>();
            lstRole = clsRole.getList();
            cmbRole.Items.Clear();
            for (int i = 0; i < lstRole.Count; i++)
                cmbRole.Items.Add(lstRole[i]);
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmMain main = new frmMain();
            //validateByUserRole(frmMain.m.Items, ((clsRole)cmbRole.SelectedItem).codsec);
        }

        public void validateByUserRole(ToolStripItemCollection objToolStripItemCollection, int user)
        {
            for (int i = 0; i < objToolStripItemCollection.Count; i++)
            {
                lstCheckBox.Add(new CheckBox());
                lstCheckBox[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstCheckBox[i].Location = new System.Drawing.Point(6, 19 + i);
                lstCheckBox[i].Name = objToolStripItemCollection[i].Name;
                lstCheckBox[i].Size = new System.Drawing.Size(140, 17);
                lstCheckBox[i].Text = objToolStripItemCollection[i].Text;
                lstCheckBox[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                //if (object.ReferenceEquals(objToolStripItemCollection[i].GetType(), typeof(System.Windows.Forms.ToolStripMenuItem)))
                //{
                //    //clsSystemMenuByUserRole objSystemMenuByUserRole = clsSystemMenuByUserRole.getDetailByUserRoleAndControlName(user, objToolStripItemCollection[i].Name);
                //    //if (objSystemMenuByUserRole.codsec > 0)
                //    //{
                //    //    objToolStripItemCollection[i].Enabled = objSystemMenuByUserRole.enabled;
                //    //    objToolStripItemCollection[i].Visible = objSystemMenuByUserRole.visible;
                //    //    CheckBox chkBox = new CheckBox();
                //    //    chkBox.Checked = true;
                //    //    chkBox.Tag = objSystemMenuByUserRole.codsec;
                //    //    chkBox.Text = objToolStripItemCollection[i].Text;
                //    //}
                //    //validateByUserRole(((System.Windows.Forms.ToolStripDropDownItem)(((ToolStripMenuItem)objToolStripItemCollection[i]))).DropDownItems);
                //}
                groupBox2.Controls.Add(lstCheckBox[i]);
            }
        }
    }
}
