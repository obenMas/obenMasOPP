namespace BPS
{
    partial class frmXtraProductCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraProductCode));
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblExternalID = new System.Windows.Forms.Label();
            this.lblExternalDescription = new System.Windows.Forms.Label();
            this.lblExternalCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtExternalDescription = new System.Windows.Forms.TextBox();
            this.txtExternalCode = new System.Windows.Forms.TextBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
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
            this.lblExternalID.Location = new System.Drawing.Point(88, 39);
            this.lblExternalID.Name = "lblExternalID";
            this.lblExternalID.Size = new System.Drawing.Size(56, 15);
            this.lblExternalID.TabIndex = 0;
            this.lblExternalID.Text = "Producto";
            // 
            // lblExternalDescription
            // 
            this.lblExternalDescription.AutoSize = true;
            this.lblExternalDescription.Location = new System.Drawing.Point(72, 70);
            this.lblExternalDescription.Name = "lblExternalDescription";
            this.lblExternalDescription.Size = new System.Drawing.Size(72, 15);
            this.lblExternalDescription.TabIndex = 0;
            this.lblExternalDescription.Text = "Descripción";
            // 
            // lblExternalCode
            // 
            this.lblExternalCode.AutoSize = true;
            this.lblExternalCode.Location = new System.Drawing.Point(98, 101);
            this.lblExternalCode.Name = "lblExternalCode";
            this.lblExternalCode.Size = new System.Drawing.Size(46, 15);
            this.lblExternalCode.TabIndex = 0;
            this.lblExternalCode.Text = "Código";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(150, 36);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(236, 21);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExternalID_KeyDown);
            // 
            // txtExternalDescription
            // 
            this.txtExternalDescription.Location = new System.Drawing.Point(150, 67);
            this.txtExternalDescription.Name = "txtExternalDescription";
            this.txtExternalDescription.Size = new System.Drawing.Size(236, 21);
            this.txtExternalDescription.TabIndex = 2;
            // 
            // txtExternalCode
            // 
            this.txtExternalCode.Location = new System.Drawing.Point(150, 98);
            this.txtExternalCode.Name = "txtExternalCode";
            this.txtExternalCode.Size = new System.Drawing.Size(236, 21);
            this.txtExternalCode.TabIndex = 3;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(396, 128);
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
            this.grpbSearch.Location = new System.Drawing.Point(3, 128);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(389, 43);
            this.grpbSearch.TabIndex = 8;
            this.grpbSearch.TabStop = false;
            // 
            // frmXtraProductCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(458, 173);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.txtExternalCode);
            this.Controls.Add(this.txtExternalDescription);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblExternalCode);
            this.Controls.Add(this.lblExternalDescription);
            this.Controls.Add(this.lblExternalID);
            this.Controls.Add(this.lblFilmName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXtraProductCode";
            this.Text = "Equivalencia de películas";
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblExternalID;
        private System.Windows.Forms.Label lblExternalDescription;
        private System.Windows.Forms.Label lblExternalCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtExternalDescription;
        private System.Windows.Forms.TextBox txtExternalCode;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbSearch;
    }
}