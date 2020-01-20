namespace BPS.Raw
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlShortCut = new System.Windows.Forms.Panel();
            this.btnReportDay = new System.Windows.Forms.Button();
            this.btnMW = new System.Windows.Forms.Button();
            this.btnSilo = new System.Windows.Forms.Button();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnDMT = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.sttsFooter = new System.Windows.Forms.StatusStrip();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlShortCut.SuspendLayout();
            this.sttsFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShortCut
            // 
            this.pnlShortCut.BackColor = System.Drawing.SystemColors.Window;
            this.pnlShortCut.Controls.Add(this.btnReportDay);
            this.pnlShortCut.Controls.Add(this.btnMW);
            this.pnlShortCut.Controls.Add(this.btnSilo);
            this.pnlShortCut.Controls.Add(this.btnAd);
            this.pnlShortCut.Controls.Add(this.btnDMT);
            this.pnlShortCut.Controls.Add(this.btnReturn);
            this.pnlShortCut.Controls.Add(this.btnOut);
            this.pnlShortCut.Controls.Add(this.btnStock);
            this.pnlShortCut.Controls.Add(this.btnIn);
            this.pnlShortCut.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortCut.Location = new System.Drawing.Point(0, 0);
            this.pnlShortCut.Name = "pnlShortCut";
            this.pnlShortCut.Size = new System.Drawing.Size(144, 490);
            this.pnlShortCut.TabIndex = 1;
            // 
            // btnReportDay
            // 
            this.btnReportDay.Image = global::BPS.Raw.Properties.Resources.pro_1;
            this.btnReportDay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportDay.Location = new System.Drawing.Point(15, 312);
            this.btnReportDay.Name = "btnReportDay";
            this.btnReportDay.Size = new System.Drawing.Size(114, 87);
            this.btnReportDay.TabIndex = 9;
            this.btnReportDay.Text = "Reporte\r\nDiario";
            this.btnReportDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportDay.UseVisualStyleBackColor = true;
            this.btnReportDay.Visible = false;
            this.btnReportDay.Click += new System.EventHandler(this.btnReportDay_Click);
            // 
            // btnMW
            // 
            this.btnMW.Image = global::BPS.Raw.Properties.Resources.MW;
            this.btnMW.Location = new System.Drawing.Point(15, 218);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(114, 87);
            this.btnMW.TabIndex = 6;
            this.btnMW.Text = "MW";
            this.btnMW.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMW.UseVisualStyleBackColor = true;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // btnSilo
            // 
            this.btnSilo.Image = global::BPS.Raw.Properties.Resources.adt;
            this.btnSilo.Location = new System.Drawing.Point(15, 407);
            this.btnSilo.Name = "btnSilo";
            this.btnSilo.Size = new System.Drawing.Size(114, 87);
            this.btnSilo.TabIndex = 8;
            this.btnSilo.Text = "Stock en Silos";
            this.btnSilo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSilo.UseVisualStyleBackColor = true;
            this.btnSilo.Click += new System.EventHandler(this.btnSilo_Click);
            // 
            // btnAd
            // 
            this.btnAd.Image = global::BPS.Raw.Properties.Resources.ret_1;
            this.btnAd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAd.Location = new System.Drawing.Point(15, 312);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(114, 87);
            this.btnAd.TabIndex = 7;
            this.btnAd.Text = "Stock en deposito";
            this.btnAd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnDMT
            // 
            this.btnDMT.Image = global::BPS.Raw.Properties.Resources.DMT;
            this.btnDMT.Location = new System.Drawing.Point(15, 123);
            this.btnDMT.Name = "btnDMT";
            this.btnDMT.Size = new System.Drawing.Size(114, 87);
            this.btnDMT.TabIndex = 5;
            this.btnDMT.Text = "Consumo";
            this.btnDMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDMT.UseVisualStyleBackColor = true;
            this.btnDMT.Click += new System.EventHandler(this.btnDMT_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Image = global::BPS.Raw.Properties.Resources.ret_2;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(15, 217);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 87);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Devolución\r\nMP";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Image = global::BPS.Raw.Properties.Resources.out_1;
            this.btnOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOut.Location = new System.Drawing.Point(15, 122);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(114, 87);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Egreso\r\nMP";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnStock
            // 
            this.btnStock.Image = global::BPS.Raw.Properties.Resources.stockR;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.Location = new System.Drawing.Point(15, 28);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(114, 87);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock ";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BPS.Raw.Properties.Resources.in_1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIn.Location = new System.Drawing.Point(15, 27);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(114, 87);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "Ingreso\r\nMP";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.SystemColors.Window;
            this.mnu.Location = new System.Drawing.Point(144, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(1047, 24);
            this.mnu.TabIndex = 3;
            this.mnu.Text = "menuStrip1";
            // 
            // sttsFooter
            // 
            this.sttsFooter.BackColor = System.Drawing.SystemColors.Window;
            this.sttsFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDatabase,
            this.tsslUserNameLabel,
            this.tsslUserName,
            this.tsslVersionLabel,
            this.tsslVersion});
            this.sttsFooter.Location = new System.Drawing.Point(144, 468);
            this.sttsFooter.Name = "sttsFooter";
            this.sttsFooter.Size = new System.Drawing.Size(1047, 22);
            this.sttsFooter.TabIndex = 5;
            this.sttsFooter.Text = "statusStrip1";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = global::BPS.Raw.Properties.Resources.sqlserver;
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(16, 17);
            // 
            // tsslUserNameLabel
            // 
            this.tsslUserNameLabel.Name = "tsslUserNameLabel";
            this.tsslUserNameLabel.Size = new System.Drawing.Size(53, 17);
            this.tsslUserNameLabel.Text = "Usuario :";
            // 
            // tsslUserName
            // 
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslVersionLabel
            // 
            this.tsslVersionLabel.Name = "tsslVersionLabel";
            this.tsslVersionLabel.Size = new System.Drawing.Size(52, 17);
            this.tsslVersionLabel.Text = "Versión :";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BPS.Raw.Properties.Resources.obenMas_v3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 490);
            this.Controls.Add(this.sttsFooter);
            this.Controls.Add(this.mnu);
            this.Controls.Add(this.pnlShortCut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu;
            this.Name = "frmMain";
            this.Text = "ObenMas - Materia Prima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlShortCut.ResumeLayout(false);
            this.sttsFooter.ResumeLayout(false);
            this.sttsFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShortCut;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.StatusStrip sttsFooter;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersionLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnMW;
        private System.Windows.Forms.Button btnDMT;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnSilo;
        private System.Windows.Forms.Button btnReportDay;
    }
}

