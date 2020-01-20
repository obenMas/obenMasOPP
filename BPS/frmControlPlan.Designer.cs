namespace BPS
{
    partial class frmControlPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlPlan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBopp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvControlPlans = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFkBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBoppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsecFkqQalityControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQualityControlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPlans)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBopp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbBopp
            // 
            this.cmbBopp.FormattingEnabled = true;
            this.cmbBopp.Location = new System.Drawing.Point(62, 25);
            this.cmbBopp.Name = "cmbBopp";
            this.cmbBopp.Size = new System.Drawing.Size(121, 21);
            this.cmbBopp.TabIndex = 1;
            this.cmbBopp.SelectedIndexChanged += new System.EventHandler(this.cmbBopp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Película:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvControlPlans);
            this.groupBox2.Location = new System.Drawing.Point(5, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvControlPlans
            // 
            this.dgvControlPlans.AllowUserToAddRows = false;
            this.dgvControlPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmFkBopp,
            this.clmBoppCode,
            this.clmCodsecFkqQalityControl,
            this.clmQualityControlName,
            this.clmQuantityValues,
            this.clmMin,
            this.clmMax,
            this.clmEdit,
            this.clmDelete});
            this.dgvControlPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlPlans.Location = new System.Drawing.Point(3, 16);
            this.dgvControlPlans.Name = "dgvControlPlans";
            this.dgvControlPlans.Size = new System.Drawing.Size(693, 387);
            this.dgvControlPlans.TabIndex = 0;
            this.dgvControlPlans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlPlans_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Control";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(438, 472);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(126, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click_1);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmFkBopp
            // 
            this.clmFkBopp.HeaderText = "CodsecPelicula";
            this.clmFkBopp.Name = "clmFkBopp";
            this.clmFkBopp.Visible = false;
            // 
            // clmBoppCode
            // 
            this.clmBoppCode.HeaderText = "Pelicula";
            this.clmBoppCode.Name = "clmBoppCode";
            // 
            // clmCodsecFkqQalityControl
            // 
            this.clmCodsecFkqQalityControl.HeaderText = "fkQualityControl";
            this.clmCodsecFkqQalityControl.Name = "clmCodsecFkqQalityControl";
            this.clmCodsecFkqQalityControl.Visible = false;
            // 
            // clmQualityControlName
            // 
            this.clmQualityControlName.HeaderText = "Nombre Control";
            this.clmQualityControlName.Name = "clmQualityControlName";
            this.clmQualityControlName.Width = 250;
            // 
            // clmQuantityValues
            // 
            this.clmQuantityValues.HeaderText = "Cant. Val";
            this.clmQuantityValues.Name = "clmQuantityValues";
            this.clmQuantityValues.Width = 80;
            // 
            // clmMin
            // 
            this.clmMin.HeaderText = "Val Min";
            this.clmMin.Name = "clmMin";
            this.clmMin.Width = 80;
            // 
            // clmMax
            // 
            this.clmMax.HeaderText = "Val Max";
            this.clmMax.Name = "clmMax";
            this.clmMax.Width = 80;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "Editar";
            this.clmEdit.Image = global::BPS.Properties.Resources.pencil;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.Width = 80;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Eliminar";
            this.clmDelete.Image = global::BPS.Properties.Resources.cross;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 80;
            // 
            // frmControlPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 499);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControlPlan";
            this.Text = "Plan de Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPlans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvControlPlans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFkBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecFkqQalityControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQualityControlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMax;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}