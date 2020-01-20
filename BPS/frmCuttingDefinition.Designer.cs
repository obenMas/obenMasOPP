namespace BPS
{
    partial class frmCuttingDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingDefinition));
            this.dgvCuttingDefinition = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstimatedStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDefined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDefine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmCheckOV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmOVList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingDefinition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCuttingDefinition
            // 
            this.dgvCuttingDefinition.AllowUserToAddRows = false;
            this.dgvCuttingDefinition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingDefinition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmFilm,
            this.clmQuantity,
            this.clmMargin,
            this.clmEstimatedStart,
            this.clmStatus,
            this.clmPlant,
            this.clmDefined,
            this.clmDelete,
            this.clmDefine,
            this.clmCheckOV,
            this.clmOVList});
            this.dgvCuttingDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuttingDefinition.Location = new System.Drawing.Point(3, 16);
            this.dgvCuttingDefinition.Name = "dgvCuttingDefinition";
            this.dgvCuttingDefinition.Size = new System.Drawing.Size(1059, 295);
            this.dgvCuttingDefinition.TabIndex = 0;
            this.dgvCuttingDefinition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingDefinition_CellContentClick);
            this.dgvCuttingDefinition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingDefinition_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Nº ";
            this.clmCodsec.Name = "clmCodsec";
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Película";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFilm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmMargin
            // 
            this.clmMargin.HeaderText = "Margen";
            this.clmMargin.Name = "clmMargin";
            // 
            // clmEstimatedStart
            // 
            this.clmEstimatedStart.HeaderText = "Inicio Estimado";
            this.clmEstimatedStart.Name = "clmEstimatedStart";
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            // 
            // clmDefined
            // 
            this.clmDefined.HeaderText = "Definido";
            this.clmDefined.Name = "clmDefined";
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::BPS.Properties.Resources.cross;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Visible = false;
            // 
            // clmDefine
            // 
            this.clmDefine.HeaderText = "";
            this.clmDefine.Name = "clmDefine";
            this.clmDefine.Text = "Definir";
            this.clmDefine.UseColumnTextForButtonValue = true;
            // 
            // clmCheckOV
            // 
            this.clmCheckOV.HeaderText = "";
            this.clmCheckOV.Name = "clmCheckOV";
            this.clmCheckOV.Text = "Verificar OV";
            this.clmCheckOV.UseColumnTextForButtonValue = true;
            // 
            // clmOVList
            // 
            this.clmOVList.HeaderText = "";
            this.clmOVList.Name = "clmOVList";
            this.clmOVList.Text = "Listado OV";
            this.clmOVList.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCuttingDefinition);
            this.groupBox1.Location = new System.Drawing.Point(-1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(968, 318);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nueva";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmCuttingDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 353);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingDefinition";
            this.Text = "Definiciones de Corte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingDefinition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuttingDefinition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstimatedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDefined;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmDefine;
        private System.Windows.Forms.DataGridViewButtonColumn clmCheckOV;
        private System.Windows.Forms.DataGridViewButtonColumn clmOVList;
    }
}