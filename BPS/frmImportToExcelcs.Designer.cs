namespace BPS
{
    partial class frmImportToExcelcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportToExcelcs));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblpathLabel = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.lblsheet = new System.Windows.Forms.Label();
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(961, 383);
            this.dgvData.TabIndex = 0;
            // 
            // lblpathLabel
            // 
            this.lblpathLabel.AutoSize = true;
            this.lblpathLabel.Location = new System.Drawing.Point(202, 24);
            this.lblpathLabel.Name = "lblpathLabel";
            this.lblpathLabel.Size = new System.Drawing.Size(55, 15);
            this.lblpathLabel.TabIndex = 1;
            this.lblpathLabel.Text = "Destino :";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BPS.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(734, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(263, 24);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(30, 15);
            this.lblConnectionString.TabIndex = 3;
            this.lblConnectionString.Text = "Test";
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.btnProcess);
            this.grpbInfo.Controls.Add(this.txtSheet);
            this.grpbInfo.Controls.Add(this.lblsheet);
            this.grpbInfo.Controls.Add(this.lblConnectionString);
            this.grpbInfo.Controls.Add(this.btnSearch);
            this.grpbInfo.Controls.Add(this.lblpathLabel);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbInfo.Location = new System.Drawing.Point(0, 379);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(961, 100);
            this.grpbInfo.TabIndex = 4;
            this.grpbInfo.TabStop = false;
            // 
            // lblsheet
            // 
            this.lblsheet.AutoSize = true;
            this.lblsheet.Location = new System.Drawing.Point(218, 49);
            this.lblsheet.Name = "lblsheet";
            this.lblsheet.Size = new System.Drawing.Size(39, 15);
            this.lblsheet.TabIndex = 4;
            this.lblsheet.Text = "Hoja :";
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(263, 49);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(450, 21);
            this.txtSheet.TabIndex = 5;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Properties.Resources.lightning;
            this.btnProcess.Location = new System.Drawing.Point(734, 47);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(25, 25);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmImportToExcelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(961, 479);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportToExcelcs";
            this.Text = "Pallets OppFilm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblpathLabel;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.TextBox txtSheet;
        private System.Windows.Forms.Label lblsheet;
        private System.Windows.Forms.Button btnProcess;
    }
}