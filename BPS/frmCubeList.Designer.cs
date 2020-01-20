namespace BPS
{
    partial class frmCubeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCubeList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCube = new System.Windows.Forms.DataGridView();
            this.clmcubecodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubetransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubecustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubeorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubeweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcuberowone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcuberowtwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcuberowthree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcubereuse = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmcubedelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCube)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCube);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgvCube
            // 
            this.dgvCube.AllowUserToAddRows = false;
            this.dgvCube.AllowUserToDeleteRows = false;
            this.dgvCube.AllowUserToOrderColumns = true;
            this.dgvCube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCube.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcubecodsec,
            this.clmcubenumber,
            this.clmcubetransport,
            this.clmcubecustomer,
            this.clmcubeorder,
            this.clmcubeweigth,
            this.clmcuberowone,
            this.clmcuberowtwo,
            this.clmcuberowthree,
            this.clmcubereuse,
            this.clmcubedelete});
            this.dgvCube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCube.Location = new System.Drawing.Point(3, 16);
            this.dgvCube.Name = "dgvCube";
            this.dgvCube.ReadOnly = true;
            this.dgvCube.RowHeadersWidth = 21;
            this.dgvCube.Size = new System.Drawing.Size(936, 405);
            this.dgvCube.TabIndex = 0;
            this.dgvCube.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCube_CellContentClick);
            // 
            // clmcubecodsec
            // 
            this.clmcubecodsec.HeaderText = "codsec";
            this.clmcubecodsec.Name = "clmcubecodsec";
            this.clmcubecodsec.ReadOnly = true;
            this.clmcubecodsec.Visible = false;
            // 
            // clmcubenumber
            // 
            this.clmcubenumber.HeaderText = "Nro.";
            this.clmcubenumber.Name = "clmcubenumber";
            this.clmcubenumber.ReadOnly = true;
            this.clmcubenumber.Width = 50;
            // 
            // clmcubetransport
            // 
            this.clmcubetransport.HeaderText = "Contenedor";
            this.clmcubetransport.Name = "clmcubetransport";
            this.clmcubetransport.ReadOnly = true;
            this.clmcubetransport.Width = 200;
            // 
            // clmcubecustomer
            // 
            this.clmcubecustomer.HeaderText = "Cliente";
            this.clmcubecustomer.Name = "clmcubecustomer";
            this.clmcubecustomer.ReadOnly = true;
            this.clmcubecustomer.Width = 200;
            // 
            // clmcubeorder
            // 
            this.clmcubeorder.HeaderText = "Orden";
            this.clmcubeorder.Name = "clmcubeorder";
            this.clmcubeorder.ReadOnly = true;
            this.clmcubeorder.Width = 70;
            // 
            // clmcubeweigth
            // 
            this.clmcubeweigth.HeaderText = "Peso";
            this.clmcubeweigth.Name = "clmcubeweigth";
            this.clmcubeweigth.ReadOnly = true;
            // 
            // clmcuberowone
            // 
            this.clmcuberowone.HeaderText = "Fila I";
            this.clmcuberowone.Name = "clmcuberowone";
            this.clmcuberowone.ReadOnly = true;
            this.clmcuberowone.Width = 70;
            // 
            // clmcuberowtwo
            // 
            this.clmcuberowtwo.HeaderText = "Fila II";
            this.clmcuberowtwo.Name = "clmcuberowtwo";
            this.clmcuberowtwo.ReadOnly = true;
            this.clmcuberowtwo.Width = 70;
            // 
            // clmcuberowthree
            // 
            this.clmcuberowthree.HeaderText = "Fila III";
            this.clmcuberowthree.Name = "clmcuberowthree";
            this.clmcuberowthree.ReadOnly = true;
            this.clmcuberowthree.Width = 70;
            // 
            // clmcubereuse
            // 
            this.clmcubereuse.HeaderText = "";
            this.clmcubereuse.Name = "clmcubereuse";
            this.clmcubereuse.ReadOnly = true;
            this.clmcubereuse.Width = 30;
            // 
            // clmcubedelete
            // 
            this.clmcubedelete.HeaderText = "";
            this.clmcubedelete.Name = "clmcubedelete";
            this.clmcubedelete.ReadOnly = true;
            this.clmcubedelete.Width = 30;
            // 
            // frmCubeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(942, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCubeList";
            this.Text = "Listado Cubicaje";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCube;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubecodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubetransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubecustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubeorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcubeweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcuberowone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcuberowtwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcuberowthree;
        private System.Windows.Forms.DataGridViewImageColumn clmcubereuse;
        private System.Windows.Forms.DataGridViewImageColumn clmcubedelete;
    }
}