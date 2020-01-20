namespace BPS
{
    partial class frmXtraFilmEquivalenceMill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraFilmEquivalenceMill));
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblExternalID = new System.Windows.Forms.Label();
            this.lblExternalDescription = new System.Windows.Forms.Label();
            this.lblExternalCode = new System.Windows.Forms.Label();
            this.txtExternalID = new System.Windows.Forms.TextBox();
            this.txtExternalDescription = new System.Windows.Forms.TextBox();
            this.txtExternalCode = new System.Windows.Forms.TextBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(0, 0);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(458, 26);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExternalID
            // 
            this.lblExternalID.AutoSize = true;
            this.lblExternalID.Location = new System.Drawing.Point(94, 39);
            this.lblExternalID.Name = "lblExternalID";
            this.lblExternalID.Size = new System.Drawing.Size(50, 15);
            this.lblExternalID.TabIndex = 0;
            this.lblExternalID.Text = "ID Siigo";
            // 
            // lblExternalDescription
            // 
            this.lblExternalDescription.AutoSize = true;
            this.lblExternalDescription.Location = new System.Drawing.Point(72, 82);
            this.lblExternalDescription.Name = "lblExternalDescription";
            this.lblExternalDescription.Size = new System.Drawing.Size(72, 15);
            this.lblExternalDescription.TabIndex = 0;
            this.lblExternalDescription.Text = "Descripción";
            // 
            // lblExternalCode
            // 
            this.lblExternalCode.AutoSize = true;
            this.lblExternalCode.Location = new System.Drawing.Point(16, 128);
            this.lblExternalCode.Name = "lblExternalCode";
            this.lblExternalCode.Size = new System.Drawing.Size(128, 15);
            this.lblExternalCode.TabIndex = 0;
            this.lblExternalCode.Text = "Referencia de Fábrica";
            // 
            // txtExternalID
            // 
            this.txtExternalID.Location = new System.Drawing.Point(150, 36);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(236, 21);
            this.txtExternalID.TabIndex = 1;
            // 
            // txtExternalDescription
            // 
            this.txtExternalDescription.Location = new System.Drawing.Point(150, 79);
            this.txtExternalDescription.Name = "txtExternalDescription";
            this.txtExternalDescription.Size = new System.Drawing.Size(236, 21);
            this.txtExternalDescription.TabIndex = 2;
            // 
            // txtExternalCode
            // 
            this.txtExternalCode.Location = new System.Drawing.Point(150, 125);
            this.txtExternalCode.Name = "txtExternalCode";
            this.txtExternalCode.Size = new System.Drawing.Size(236, 21);
            this.txtExternalCode.TabIndex = 3;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(396, 163);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(59, 43);
            this.grpbActions.TabIndex = 7;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(29, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(3, 163);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(389, 43);
            this.grpbSearch.TabIndex = 8;
            this.grpbSearch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ejm: BOPP/SD/30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(153, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ejm: PEL. TIPO SD-30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(152, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ejm: 0040001000566";
            // 
            // frmXtraFilmEquivalenceMill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.txtExternalCode);
            this.Controls.Add(this.txtExternalDescription);
            this.Controls.Add(this.txtExternalID);
            this.Controls.Add(this.lblExternalCode);
            this.Controls.Add(this.lblExternalDescription);
            this.Controls.Add(this.lblExternalID);
            this.Controls.Add(this.lblFilmName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXtraFilmEquivalenceMill";
            this.Text = "Equivalencia de películas Siigo";
            this.Load += new System.EventHandler(this.frmXtraFilmEquivalenceMill_Load);
            this.grpbActions.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}