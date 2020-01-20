namespace BPS.Lite
{
    partial class frmMillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillList));
            this.grpbOrder = new System.Windows.Forms.GroupBox();
            this.dgvMetalizeOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbMetalizeDetail = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.clmmetalizedmystated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizecodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizefkstatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmetalizemill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizeproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizeorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedpalletweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedgrossweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizednetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizenotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizededit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmetalizedprint = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmetalizeddelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetalizeOrder)).BeginInit();
            this.grpbMetalizeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbOrder
            // 
            this.grpbOrder.Controls.Add(this.dgvMetalizeOrder);
            this.grpbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbOrder.Name = "grpbOrder";
            this.grpbOrder.Size = new System.Drawing.Size(1091, 469);
            this.grpbOrder.TabIndex = 0;
            this.grpbOrder.TabStop = false;
            this.grpbOrder.Text = "Ordenes";
            // 
            // dgvMetalizeOrder
            // 
            this.dgvMetalizeOrder.AllowUserToAddRows = false;
            this.dgvMetalizeOrder.AllowUserToDeleteRows = false;
            this.dgvMetalizeOrder.AllowUserToOrderColumns = true;
            this.dgvMetalizeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetalizeOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmmetalizedmystated,
            this.clmmetalizecodsec,
            this.clmmetalizedtype,
            this.clmmetalizefkstatus,
            this.clmmetalizemill,
            this.clmmetalizeproduct,
            this.clmmetalizecode,
            this.clmmetalizeorder,
            this.clmmetalizedpalletweigth,
            this.clmmetalizedgrossweigth,
            this.clmmetalizednetweigth,
            this.clmmetalizedensity,
            this.clmmetalizenotes,
            this.clmmetalizedate,
            this.clmmetalizededit,
            this.clmmetalizedprint,
            this.clmmetalizeddelete});
            this.dgvMetalizeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMetalizeOrder.Location = new System.Drawing.Point(3, 14);
            this.dgvMetalizeOrder.Name = "dgvMetalizeOrder";
            this.dgvMetalizeOrder.ReadOnly = true;
            this.dgvMetalizeOrder.RowHeadersWidth = 21;
            this.dgvMetalizeOrder.Size = new System.Drawing.Size(1085, 452);
            this.dgvMetalizeOrder.TabIndex = 0;
            this.dgvMetalizeOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetalizeOrder_CellContentClick);
            this.dgvMetalizeOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMetalizeOrder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // grpbMetalizeDetail
            // 
            this.grpbMetalizeDetail.Controls.Add(this.txtCode);
            this.grpbMetalizeDetail.Controls.Add(this.label1);
            this.grpbMetalizeDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbMetalizeDetail.Location = new System.Drawing.Point(0, 469);
            this.grpbMetalizeDetail.Name = "grpbMetalizeDetail";
            this.grpbMetalizeDetail.Size = new System.Drawing.Size(1091, 46);
            this.grpbMetalizeDetail.TabIndex = 1;
            this.grpbMetalizeDetail.TabStop = false;
            this.grpbMetalizeDetail.Text = "Filtro";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(414, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(357, 21);
            this.txtCode.TabIndex = 15;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // clmmetalizedmystated
            // 
            this.clmmetalizedmystated.HeaderText = "mystated";
            this.clmmetalizedmystated.Name = "clmmetalizedmystated";
            this.clmmetalizedmystated.ReadOnly = true;
            this.clmmetalizedmystated.Visible = false;
            // 
            // clmmetalizecodsec
            // 
            this.clmmetalizecodsec.HeaderText = "codsec";
            this.clmmetalizecodsec.Name = "clmmetalizecodsec";
            this.clmmetalizecodsec.ReadOnly = true;
            this.clmmetalizecodsec.Visible = false;
            // 
            // clmmetalizedtype
            // 
            this.clmmetalizedtype.HeaderText = "type";
            this.clmmetalizedtype.Name = "clmmetalizedtype";
            this.clmmetalizedtype.ReadOnly = true;
            this.clmmetalizedtype.Visible = false;
            // 
            // clmmetalizefkstatus
            // 
            this.clmmetalizefkstatus.HeaderText = "";
            this.clmmetalizefkstatus.Name = "clmmetalizefkstatus";
            this.clmmetalizefkstatus.ReadOnly = true;
            this.clmmetalizefkstatus.Width = 30;
            // 
            // clmmetalizemill
            // 
            this.clmmetalizemill.FillWeight = 80F;
            this.clmmetalizemill.HeaderText = "Molino";
            this.clmmetalizemill.Name = "clmmetalizemill";
            this.clmmetalizemill.ReadOnly = true;
            this.clmmetalizemill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmmetalizemill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmmetalizemill.Width = 80;
            // 
            // clmmetalizeproduct
            // 
            this.clmmetalizeproduct.FillWeight = 80F;
            this.clmmetalizeproduct.HeaderText = "Material";
            this.clmmetalizeproduct.Name = "clmmetalizeproduct";
            this.clmmetalizeproduct.ReadOnly = true;
            this.clmmetalizeproduct.Width = 150;
            // 
            // clmmetalizecode
            // 
            this.clmmetalizecode.HeaderText = "Código";
            this.clmmetalizecode.Name = "clmmetalizecode";
            this.clmmetalizecode.ReadOnly = true;
            this.clmmetalizecode.Width = 80;
            // 
            // clmmetalizeorder
            // 
            this.clmmetalizeorder.HeaderText = "Orden";
            this.clmmetalizeorder.Name = "clmmetalizeorder";
            this.clmmetalizeorder.ReadOnly = true;
            this.clmmetalizeorder.Width = 50;
            // 
            // clmmetalizedpalletweigth
            // 
            this.clmmetalizedpalletweigth.HeaderText = "Peso P";
            this.clmmetalizedpalletweigth.Name = "clmmetalizedpalletweigth";
            this.clmmetalizedpalletweigth.ReadOnly = true;
            this.clmmetalizedpalletweigth.Width = 70;
            // 
            // clmmetalizedgrossweigth
            // 
            this.clmmetalizedgrossweigth.HeaderText = "Peso B";
            this.clmmetalizedgrossweigth.Name = "clmmetalizedgrossweigth";
            this.clmmetalizedgrossweigth.ReadOnly = true;
            this.clmmetalizedgrossweigth.Width = 70;
            // 
            // clmmetalizednetweigth
            // 
            this.clmmetalizednetweigth.HeaderText = "Peso N";
            this.clmmetalizednetweigth.Name = "clmmetalizednetweigth";
            this.clmmetalizednetweigth.ReadOnly = true;
            this.clmmetalizednetweigth.Width = 70;
            // 
            // clmmetalizedensity
            // 
            this.clmmetalizedensity.HeaderText = "Densidad";
            this.clmmetalizedensity.Name = "clmmetalizedensity";
            this.clmmetalizedensity.ReadOnly = true;
            this.clmmetalizedensity.Width = 70;
            // 
            // clmmetalizenotes
            // 
            this.clmmetalizenotes.HeaderText = "Observaciones";
            this.clmmetalizenotes.Name = "clmmetalizenotes";
            this.clmmetalizenotes.ReadOnly = true;
            this.clmmetalizenotes.Width = 170;
            // 
            // clmmetalizedate
            // 
            this.clmmetalizedate.HeaderText = "Fecha";
            this.clmmetalizedate.Name = "clmmetalizedate";
            this.clmmetalizedate.ReadOnly = true;
            // 
            // clmmetalizededit
            // 
            this.clmmetalizededit.HeaderText = "";
            this.clmmetalizededit.Name = "clmmetalizededit";
            this.clmmetalizededit.ReadOnly = true;
            this.clmmetalizededit.Width = 30;
            // 
            // clmmetalizedprint
            // 
            this.clmmetalizedprint.HeaderText = "";
            this.clmmetalizedprint.Name = "clmmetalizedprint";
            this.clmmetalizedprint.ReadOnly = true;
            this.clmmetalizedprint.Width = 30;
            // 
            // clmmetalizeddelete
            // 
            this.clmmetalizeddelete.HeaderText = "";
            this.clmmetalizeddelete.Name = "clmmetalizeddelete";
            this.clmmetalizeddelete.ReadOnly = true;
            this.clmmetalizeddelete.Width = 30;
            // 
            // frmMillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1091, 515);
            this.Controls.Add(this.grpbOrder);
            this.Controls.Add(this.grpbMetalizeDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillList";
            this.Text = "Listado de Material Reprocesado";
            this.Load += new System.EventHandler(this.frmMetalizeOrderList_Load);
            this.grpbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetalizeOrder)).EndInit();
            this.grpbMetalizeDetail.ResumeLayout(false);
            this.grpbMetalizeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbOrder;
        private System.Windows.Forms.DataGridView dgvMetalizeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbMetalizeDetail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedmystated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizecodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedtype;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizefkstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizemill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizeproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizeorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedpalletweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedgrossweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizednetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizenotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedate;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizededit;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizedprint;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizeddelete;
    }
}