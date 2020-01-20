namespace BPS
{
    partial class frmValidatePackingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidatePackingList));
            this.ttpThermProdcut = new System.Windows.Forms.ToolTip(this.components);
            this.grpbHead = new System.Windows.Forms.GroupBox();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPallet = new System.Windows.Forms.Label();
            this.lblCoil = new System.Windows.Forms.Label();
            this.dgvPackingList = new System.Windows.Forms.DataGridView();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpalletnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcoilnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbHead.SuspendLayout();
            this.grpbFooter.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackingList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbHead
            // 
            this.grpbHead.Controls.Add(this.label1);
            this.grpbHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbHead.Location = new System.Drawing.Point(0, 0);
            this.grpbHead.Name = "grpbHead";
            this.grpbHead.Size = new System.Drawing.Size(537, 29);
            this.grpbHead.TabIndex = 0;
            this.grpbHead.TabStop = false;
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.lblCoil);
            this.grpbFooter.Controls.Add(this.lblPallet);
            this.grpbFooter.Controls.Add(this.label3);
            this.grpbFooter.Controls.Add(this.label2);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 198);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(537, 46);
            this.grpbFooter.TabIndex = 1;
            this.grpbFooter.TabStop = false;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvPackingList);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 29);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(537, 169);
            this.grpbDetail.TabIndex = 2;
            this.grpbDetail.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiene una diferencia en pesos por favor corregir antes de cerrar el pedido y gene" +
    "rar el PackingList";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pallet Peso Neto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bobinas Peso Neto";
            // 
            // lblPallet
            // 
            this.lblPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPallet.Location = new System.Drawing.Point(108, 13);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(144, 26);
            this.lblPallet.TabIndex = 2;
            // 
            // lblCoil
            // 
            this.lblCoil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoil.Location = new System.Drawing.Point(389, 13);
            this.lblCoil.Name = "lblCoil";
            this.lblCoil.Size = new System.Drawing.Size(144, 26);
            this.lblCoil.TabIndex = 3;
            // 
            // dgvPackingList
            // 
            this.dgvPackingList.AllowUserToAddRows = false;
            this.dgvPackingList.AllowUserToDeleteRows = false;
            this.dgvPackingList.AllowUserToOrderColumns = true;
            this.dgvPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcode,
            this.clmpalletnet,
            this.clmcoilnet,
            this.clminfo});
            this.dgvPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackingList.Location = new System.Drawing.Point(3, 16);
            this.dgvPackingList.Name = "dgvPackingList";
            this.dgvPackingList.ReadOnly = true;
            this.dgvPackingList.RowHeadersWidth = 21;
            this.dgvPackingList.Size = new System.Drawing.Size(531, 150);
            this.dgvPackingList.TabIndex = 0;
            // 
            // clmcode
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmcode.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmcode.HeaderText = "Código";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            this.clmcode.Width = 150;
            // 
            // clmpalletnet
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmpalletnet.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmpalletnet.HeaderText = "Peso Neto Pallet";
            this.clmpalletnet.Name = "clmpalletnet";
            this.clmpalletnet.ReadOnly = true;
            this.clmpalletnet.Width = 130;
            // 
            // clmcoilnet
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmcoilnet.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmcoilnet.HeaderText = "Peso Neto Coil";
            this.clmcoilnet.Name = "clmcoilnet";
            this.clmcoilnet.ReadOnly = true;
            this.clmcoilnet.Width = 120;
            // 
            // clminfo
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clminfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.clminfo.HeaderText = "Información";
            this.clminfo.Name = "clminfo";
            this.clminfo.ReadOnly = true;
            // 
            // frmValidatePackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(537, 244);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFooter);
            this.Controls.Add(this.grpbHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmValidatePackingList";
            this.Text = "Validación de Packing List";
            this.grpbHead.ResumeLayout(false);
            this.grpbHead.PerformLayout();
            this.grpbFooter.ResumeLayout(false);
            this.grpbFooter.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpThermProdcut;
        private System.Windows.Forms.GroupBox grpbHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbFooter;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.Label lblCoil;
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPackingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpalletnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcoilnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminfo;
    }
}