namespace BPS
{
    partial class frmXtraFilmEquivalence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraFilmEquivalence));
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblExternalID = new System.Windows.Forms.Label();
            this.lblExternalDescription = new System.Windows.Forms.Label();
            this.lblExternalCode = new System.Windows.Forms.Label();
            this.txtExternalID = new System.Windows.Forms.TextBox();
            this.txtExternalDescription = new System.Windows.Forms.TextBox();
            this.txtExternalCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(0, 0);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(330, 26);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExternalID
            // 
            this.lblExternalID.AutoSize = true;
            this.lblExternalID.Location = new System.Drawing.Point(29, 10);
            this.lblExternalID.Name = "lblExternalID";
            this.lblExternalID.Size = new System.Drawing.Size(50, 15);
            this.lblExternalID.TabIndex = 0;
            this.lblExternalID.Text = "ID Siigo";
            // 
            // lblExternalDescription
            // 
            this.lblExternalDescription.AutoSize = true;
            this.lblExternalDescription.Location = new System.Drawing.Point(7, 52);
            this.lblExternalDescription.Name = "lblExternalDescription";
            this.lblExternalDescription.Size = new System.Drawing.Size(72, 15);
            this.lblExternalDescription.TabIndex = 0;
            this.lblExternalDescription.Text = "Descripción";
            // 
            // lblExternalCode
            // 
            this.lblExternalCode.AutoSize = true;
            this.lblExternalCode.Location = new System.Drawing.Point(33, 94);
            this.lblExternalCode.Name = "lblExternalCode";
            this.lblExternalCode.Size = new System.Drawing.Size(46, 15);
            this.lblExternalCode.TabIndex = 0;
            this.lblExternalCode.Text = "Código";
            // 
            // txtExternalID
            // 
            this.txtExternalID.Location = new System.Drawing.Point(85, 7);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(236, 21);
            this.txtExternalID.TabIndex = 1;
            // 
            // txtExternalDescription
            // 
            this.txtExternalDescription.Location = new System.Drawing.Point(85, 49);
            this.txtExternalDescription.Name = "txtExternalDescription";
            this.txtExternalDescription.Size = new System.Drawing.Size(236, 21);
            this.txtExternalDescription.TabIndex = 2;
            // 
            // txtExternalCode
            // 
            this.txtExternalCode.Location = new System.Drawing.Point(85, 91);
            this.txtExternalCode.Name = "txtExternalCode";
            this.txtExternalCode.Size = new System.Drawing.Size(236, 21);
            this.txtExternalCode.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(275, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(302, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbSearch
            // 
            this.grpbSearch.Controls.Add(this.btnClose);
            this.grpbSearch.Controls.Add(this.btnSave);
            this.grpbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbSearch.Location = new System.Drawing.Point(0, 122);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(330, 43);
            this.grpbSearch.TabIndex = 8;
            this.grpbSearch.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(88, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ejm: 0040001000566";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(88, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ejm: PEL. TIPO SD-30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(88, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ejm: BOPP/SD/30";
            // 
            // frmXtraFilmEquivalence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(330, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.txtExternalCode);
            this.Controls.Add(this.txtExternalDescription);
            this.Controls.Add(this.txtExternalID);
            this.Controls.Add(this.lblExternalCode);
            this.Controls.Add(this.lblExternalDescription);
            this.Controls.Add(this.lblExternalID);
            this.Controls.Add(this.lblFilmName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXtraFilmEquivalence";
            this.Text = "Equivalencia de películas Siigo";
            this.Load += new System.EventHandler(this.frmXtraFilmEquivalence_Load);
            this.grpbSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblExternalID;
        private System.Windows.Forms.Label lblExternalDescription;
        private System.Windows.Forms.Label lblExternalCode;
        private System.Windows.Forms.TextBox txtExternalID;
        private System.Windows.Forms.TextBox txtExternalDescription;
        private System.Windows.Forms.TextBox txtExternalCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}