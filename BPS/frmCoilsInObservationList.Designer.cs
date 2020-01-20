namespace BPS
{
    partial class frmCoilsInObservationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilsInObservationList));
            this.grpbCoilList = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDefects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilApprove = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilSecundaryCut = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilIsSecundaryCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilRewind = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilIsRewind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilMill = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilIsMill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCoilList
            // 
            this.grpbCoilList.Controls.Add(this.dgvCoils);
            this.grpbCoilList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilList.Location = new System.Drawing.Point(0, 0);
            this.grpbCoilList.Name = "grpbCoilList";
            this.grpbCoilList.Size = new System.Drawing.Size(1188, 377);
            this.grpbCoilList.TabIndex = 0;
            this.grpbCoilList.TabStop = false;
            this.grpbCoilList.Text = "Bobinas en observación";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilProduct,
            this.clmCoilDestination,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilNetWeigth,
            this.clmCoilDensity,
            this.clmCoilQuality,
            this.clmCoilDefects,
            this.clmCoilApprove,
            this.clmCoilSecundaryCut,
            this.clmCoilIsSecundaryCut,
            this.clmCoilRewind,
            this.clmCoilIsRewind,
            this.clmCoilMill,
            this.clmCoilIsMill});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 15;
            this.dgvCoils.Size = new System.Drawing.Size(1182, 357);
            this.dgvCoils.TabIndex = 1;
            this.dgvCoils.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoils_CellMouseDoubleClick);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 372);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1150, 44);
            this.grpbEmpty.TabIndex = 4;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnExit);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(1153, 372);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(35, 44);
            this.grpbMainCoilButtons.TabIndex = 3;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(5, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clmCoilCodsec
            // 
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 130;
            // 
            // clmCoilProduct
            // 
            this.clmCoilProduct.HeaderText = "Producto";
            this.clmCoilProduct.Name = "clmCoilProduct";
            this.clmCoilProduct.ReadOnly = true;
            this.clmCoilProduct.Width = 110;
            // 
            // clmCoilDestination
            // 
            this.clmCoilDestination.HeaderText = "Destino";
            this.clmCoilDestination.Name = "clmCoilDestination";
            this.clmCoilDestination.ReadOnly = true;
            this.clmCoilDestination.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 70;
            // 
            // clmCoilWidth
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCoilWidth.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 70;
            // 
            // clmCoilNetWeigth
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCoilNetWeigth.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilNetWeigth.HeaderText = "Peso";
            this.clmCoilNetWeigth.Name = "clmCoilNetWeigth";
            this.clmCoilNetWeigth.ReadOnly = true;
            this.clmCoilNetWeigth.Width = 70;
            // 
            // clmCoilDensity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCoilDensity.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCoilDensity.HeaderText = "Densidad";
            this.clmCoilDensity.Name = "clmCoilDensity";
            this.clmCoilDensity.ReadOnly = true;
            this.clmCoilDensity.Width = 70;
            // 
            // clmCoilQuality
            // 
            this.clmCoilQuality.HeaderText = "Calidad";
            this.clmCoilQuality.Name = "clmCoilQuality";
            this.clmCoilQuality.ReadOnly = true;
            this.clmCoilQuality.Width = 70;
            // 
            // clmCoilDefects
            // 
            this.clmCoilDefects.HeaderText = "Defectos";
            this.clmCoilDefects.Name = "clmCoilDefects";
            this.clmCoilDefects.ReadOnly = true;
            this.clmCoilDefects.Width = 180;
            // 
            // clmCoilApprove
            // 
            this.clmCoilApprove.HeaderText = "Aprobar";
            this.clmCoilApprove.Name = "clmCoilApprove";
            this.clmCoilApprove.ReadOnly = true;
            this.clmCoilApprove.Width = 60;
            // 
            // clmCoilSecundaryCut
            // 
            this.clmCoilSecundaryCut.HeaderText = "C. Secundario";
            this.clmCoilSecundaryCut.Name = "clmCoilSecundaryCut";
            this.clmCoilSecundaryCut.ReadOnly = true;
            this.clmCoilSecundaryCut.Width = 60;
            // 
            // clmCoilIsSecundaryCut
            // 
            this.clmCoilIsSecundaryCut.HeaderText = "";
            this.clmCoilIsSecundaryCut.Name = "clmCoilIsSecundaryCut";
            this.clmCoilIsSecundaryCut.ReadOnly = true;
            this.clmCoilIsSecundaryCut.Visible = false;
            // 
            // clmCoilRewind
            // 
            this.clmCoilRewind.HeaderText = "Rebobinado";
            this.clmCoilRewind.Name = "clmCoilRewind";
            this.clmCoilRewind.ReadOnly = true;
            this.clmCoilRewind.Width = 60;
            // 
            // clmCoilIsRewind
            // 
            this.clmCoilIsRewind.HeaderText = "";
            this.clmCoilIsRewind.Name = "clmCoilIsRewind";
            this.clmCoilIsRewind.ReadOnly = true;
            this.clmCoilIsRewind.Visible = false;
            // 
            // clmCoilMill
            // 
            this.clmCoilMill.HeaderText = "Molino";
            this.clmCoilMill.Name = "clmCoilMill";
            this.clmCoilMill.ReadOnly = true;
            this.clmCoilMill.Width = 60;
            // 
            // clmCoilIsMill
            // 
            this.clmCoilIsMill.HeaderText = "";
            this.clmCoilIsMill.Name = "clmCoilIsMill";
            this.clmCoilIsMill.ReadOnly = true;
            this.clmCoilIsMill.Visible = false;
            // 
            // frmCoilsInObservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1188, 416);
            this.Controls.Add(this.grpbCoilList);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilsInObservationList";
            this.Text = "Listado de bobinas en observación";
            this.Load += new System.EventHandler(this.frmCoilsInObservationList_Load);
            this.grpbCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCoilList;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDefects;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilApprove;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilSecundaryCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilIsSecundaryCut;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilRewind;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilIsRewind;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilMill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilIsMill;
    }
}