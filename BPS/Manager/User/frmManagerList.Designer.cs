namespace BPS.Manager.User
{
    partial class frmManagerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRequestList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clmrequestcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequesttyperequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequeststatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestnotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestcreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestok = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestnot = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestview = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestreport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmrequestisapproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequestcreatedByCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrequeststatusCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRequestList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.AllowUserToAddRows = false;
            this.dgvRequestList.AllowUserToDeleteRows = false;
            this.dgvRequestList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmrequestcodsec,
            this.clmrequesttyperequest,
            this.clmrequeststatus,
            this.clmrequestnumber,
            this.clmrequestid,
            this.clmrequestnotes,
            this.clmrequestdate,
            this.clmrequestcreatedBy,
            this.clmrequestedit,
            this.clmrequestdelete,
            this.clmrequestok,
            this.clmrequestnot,
            this.clmrequestview,
            this.clmrequestreport,
            this.clmrequestisapproved,
            this.clmrequestcreatedByCodsec,
            this.clmrequeststatusCodsec});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequestList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestList.Location = new System.Drawing.Point(3, 16);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.ReadOnly = true;
            this.dgvRequestList.RowHeadersWidth = 21;
            this.dgvRequestList.Size = new System.Drawing.Size(876, 436);
            this.dgvRequestList.TabIndex = 0;
            this.dgvRequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestList_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(409, 14);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(110, 21);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(154, 14);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 21);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // clmrequestcodsec
            // 
            this.clmrequestcodsec.HeaderText = "codsec";
            this.clmrequestcodsec.Name = "clmrequestcodsec";
            this.clmrequestcodsec.ReadOnly = true;
            this.clmrequestcodsec.Visible = false;
            // 
            // clmrequesttyperequest
            // 
            this.clmrequesttyperequest.HeaderText = "Tipo Solicitud";
            this.clmrequesttyperequest.Name = "clmrequesttyperequest";
            this.clmrequesttyperequest.ReadOnly = true;
            // 
            // clmrequeststatus
            // 
            this.clmrequeststatus.HeaderText = "Estado";
            this.clmrequeststatus.Name = "clmrequeststatus";
            this.clmrequeststatus.ReadOnly = true;
            this.clmrequeststatus.Width = 70;
            // 
            // clmrequestnumber
            // 
            this.clmrequestnumber.HeaderText = "Nro.";
            this.clmrequestnumber.Name = "clmrequestnumber";
            this.clmrequestnumber.ReadOnly = true;
            this.clmrequestnumber.Width = 40;
            // 
            // clmrequestid
            // 
            this.clmrequestid.HeaderText = "ID";
            this.clmrequestid.Name = "clmrequestid";
            this.clmrequestid.ReadOnly = true;
            // 
            // clmrequestnotes
            // 
            this.clmrequestnotes.HeaderText = "Notes";
            this.clmrequestnotes.Name = "clmrequestnotes";
            this.clmrequestnotes.ReadOnly = true;
            this.clmrequestnotes.Width = 120;
            // 
            // clmrequestdate
            // 
            this.clmrequestdate.HeaderText = "Fecha Elaboración";
            this.clmrequestdate.Name = "clmrequestdate";
            this.clmrequestdate.ReadOnly = true;
            this.clmrequestdate.Width = 150;
            // 
            // clmrequestcreatedBy
            // 
            this.clmrequestcreatedBy.HeaderText = "Solicitado Por";
            this.clmrequestcreatedBy.Name = "clmrequestcreatedBy";
            this.clmrequestcreatedBy.ReadOnly = true;
            // 
            // clmrequestedit
            // 
            this.clmrequestedit.HeaderText = "";
            this.clmrequestedit.Name = "clmrequestedit";
            this.clmrequestedit.ReadOnly = true;
            this.clmrequestedit.Width = 30;
            // 
            // clmrequestdelete
            // 
            this.clmrequestdelete.HeaderText = "";
            this.clmrequestdelete.Name = "clmrequestdelete";
            this.clmrequestdelete.ReadOnly = true;
            this.clmrequestdelete.Width = 30;
            // 
            // clmrequestok
            // 
            this.clmrequestok.HeaderText = "";
            this.clmrequestok.Name = "clmrequestok";
            this.clmrequestok.ReadOnly = true;
            this.clmrequestok.Width = 30;
            // 
            // clmrequestnot
            // 
            this.clmrequestnot.HeaderText = "";
            this.clmrequestnot.Name = "clmrequestnot";
            this.clmrequestnot.ReadOnly = true;
            this.clmrequestnot.Width = 30;
            // 
            // clmrequestview
            // 
            this.clmrequestview.HeaderText = "";
            this.clmrequestview.Name = "clmrequestview";
            this.clmrequestview.ReadOnly = true;
            this.clmrequestview.Width = 30;
            // 
            // clmrequestreport
            // 
            this.clmrequestreport.HeaderText = "";
            this.clmrequestreport.Name = "clmrequestreport";
            this.clmrequestreport.ReadOnly = true;
            this.clmrequestreport.Width = 30;
            // 
            // clmrequestisapproved
            // 
            this.clmrequestisapproved.HeaderText = "Aprovado";
            this.clmrequestisapproved.Name = "clmrequestisapproved";
            this.clmrequestisapproved.ReadOnly = true;
            this.clmrequestisapproved.Visible = false;
            // 
            // clmrequestcreatedByCodsec
            // 
            this.clmrequestcreatedByCodsec.HeaderText = "creatorUserCodsec";
            this.clmrequestcreatedByCodsec.Name = "clmrequestcreatedByCodsec";
            this.clmrequestcreatedByCodsec.ReadOnly = true;
            this.clmrequestcreatedByCodsec.Visible = false;
            // 
            // clmrequeststatusCodsec
            // 
            this.clmrequeststatusCodsec.HeaderText = "ststatusCodsec";
            this.clmrequeststatusCodsec.Name = "clmrequeststatusCodsec";
            this.clmrequeststatusCodsec.ReadOnly = true;
            this.clmrequeststatusCodsec.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(577, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(176, 23);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(851, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmManagerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Solicitudes de Usuario";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequesttyperequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequeststatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestnotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestcreatedBy;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestedit;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestdelete;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestok;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestnot;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestview;
        private System.Windows.Forms.DataGridViewImageColumn clmrequestreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestisapproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequestcreatedByCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrequeststatusCodsec;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
    }
}