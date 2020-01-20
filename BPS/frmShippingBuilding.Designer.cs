namespace BPS
{
    partial class frmShippingBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingBuilding));
            this.grpbFormShippingBuilding = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblnameLabel = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbDetalisShippingBuilding = new System.Windows.Forms.GroupBox();
            this.dgvShippingBuilding = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ttpShippingBuilding = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFormShippingBuilding.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.grpbDetalisShippingBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbFormShippingBuilding
            // 
            this.grpbFormShippingBuilding.Controls.Add(this.cmbCountry);
            this.grpbFormShippingBuilding.Controls.Add(this.lblCountry);
            this.grpbFormShippingBuilding.Controls.Add(this.txtname);
            this.grpbFormShippingBuilding.Controls.Add(this.lblnameLabel);
            this.grpbFormShippingBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFormShippingBuilding.Location = new System.Drawing.Point(0, 0);
            this.grpbFormShippingBuilding.Name = "grpbFormShippingBuilding";
            this.grpbFormShippingBuilding.Size = new System.Drawing.Size(502, 80);
            this.grpbFormShippingBuilding.TabIndex = 0;
            this.grpbFormShippingBuilding.TabStop = false;
            this.grpbFormShippingBuilding.Text = "Datos";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(164, 47);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(206, 23);
            this.cmbCountry.TabIndex = 3;
            this.cmbCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCountry_KeyDown);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(121, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(37, 15);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "País :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(164, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 21);
            this.txtname.TabIndex = 1;
            // 
            // lblnameLabel
            // 
            this.lblnameLabel.AutoSize = true;
            this.lblnameLabel.Location = new System.Drawing.Point(100, 23);
            this.lblnameLabel.Name = "lblnameLabel";
            this.lblnameLabel.Size = new System.Drawing.Size(58, 15);
            this.lblnameLabel.TabIndex = 0;
            this.lblnameLabel.Text = "Nombre :";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 74);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(407, 44);
            this.grpbEmpty.TabIndex = 3;
            this.grpbEmpty.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BPS.Properties.Resources.add1;
            this.btnAdd.Location = new System.Drawing.Point(5, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpShippingBuilding.SetToolTip(this.btnAdd, "Agregar");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnExit);
            this.grpbMainCoilButtons.Controls.Add(this.btnCancel);
            this.grpbMainCoilButtons.Controls.Add(this.btnAdd);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(408, 74);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(94, 44);
            this.grpbMainCoilButtons.TabIndex = 4;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(64, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.ttpShippingBuilding.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(34, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 1;
            this.ttpShippingBuilding.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbDetalisShippingBuilding
            // 
            this.grpbDetalisShippingBuilding.Controls.Add(this.dgvShippingBuilding);
            this.grpbDetalisShippingBuilding.Location = new System.Drawing.Point(0, 116);
            this.grpbDetalisShippingBuilding.Name = "grpbDetalisShippingBuilding";
            this.grpbDetalisShippingBuilding.Size = new System.Drawing.Size(502, 270);
            this.grpbDetalisShippingBuilding.TabIndex = 5;
            this.grpbDetalisShippingBuilding.TabStop = false;
            this.grpbDetalisShippingBuilding.Text = "Listado";
            // 
            // dgvShippingBuilding
            // 
            this.dgvShippingBuilding.AllowUserToAddRows = false;
            this.dgvShippingBuilding.AllowUserToDeleteRows = false;
            this.dgvShippingBuilding.AllowUserToOrderColumns = true;
            this.dgvShippingBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippingBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmname,
            this.clmCountry,
            this.clmEdit,
            this.clmDelete});
            this.dgvShippingBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShippingBuilding.Location = new System.Drawing.Point(3, 17);
            this.dgvShippingBuilding.Name = "dgvShippingBuilding";
            this.dgvShippingBuilding.ReadOnly = true;
            this.dgvShippingBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShippingBuilding.Size = new System.Drawing.Size(496, 250);
            this.dgvShippingBuilding.TabIndex = 0;
            this.dgvShippingBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShippingBuilding_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmname
            // 
            this.clmname.HeaderText = "Nombre Naviera";
            this.clmname.Name = "clmname";
            this.clmname.ReadOnly = true;
            this.clmname.Width = 200;
            // 
            // clmCountry
            // 
            this.clmCountry.HeaderText = "País Destino";
            this.clmCountry.Name = "clmCountry";
            this.clmCountry.ReadOnly = true;
            this.clmCountry.Width = 150;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 30;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 30;
            // 
            // frmShippingBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(502, 387);
            this.Controls.Add(this.grpbFormShippingBuilding);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Controls.Add(this.grpbDetalisShippingBuilding);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingBuilding";
            this.Text = "Navieras";
            this.Load += new System.EventHandler(this.frmShippingBuilding_Load);
            this.grpbFormShippingBuilding.ResumeLayout(false);
            this.grpbFormShippingBuilding.PerformLayout();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.grpbDetalisShippingBuilding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingBuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFormShippingBuilding;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblnameLabel;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbDetalisShippingBuilding;
        private System.Windows.Forms.DataGridView dgvShippingBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountry;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.ToolTip ttpShippingBuilding;
    }
}