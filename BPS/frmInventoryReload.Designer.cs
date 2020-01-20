namespace BPS
{
    partial class frmInventoryReload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryReload));
            this.grbPallet = new System.Windows.Forms.GroupBox();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblpallet = new System.Windows.Forms.Label();
            this.txtcodepallet = new System.Windows.Forms.TextBox();
            this.grbPallet.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPallet
            // 
            this.grbPallet.Controls.Add(this.lblpallet);
            this.grbPallet.Controls.Add(this.txtcodepallet);
            this.grbPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPallet.Location = new System.Drawing.Point(0, 0);
            this.grbPallet.Name = "grbPallet";
            this.grbPallet.Size = new System.Drawing.Size(599, 73);
            this.grbPallet.TabIndex = 0;
            this.grbPallet.TabStop = false;
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnAdd);
            this.grbActions.Controls.Add(this.btnViewDetail);
            this.grbActions.Controls.Add(this.btnClose);
            this.grbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbActions.Location = new System.Drawing.Point(0, 73);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(599, 43);
            this.grbActions.TabIndex = 1;
            this.grbActions.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(518, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(543, 12);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 29;
            this.btnViewDetail.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(568, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblpallet
            // 
            this.lblpallet.AutoSize = true;
            this.lblpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpallet.Location = new System.Drawing.Point(6, 24);
            this.lblpallet.Name = "lblpallet";
            this.lblpallet.Size = new System.Drawing.Size(88, 31);
            this.lblpallet.TabIndex = 9;
            this.lblpallet.Text = "Pallet";
            // 
            // txtcodepallet
            // 
            this.txtcodepallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodepallet.Location = new System.Drawing.Point(111, 20);
            this.txtcodepallet.Name = "txtcodepallet";
            this.txtcodepallet.Size = new System.Drawing.Size(431, 40);
            this.txtcodepallet.TabIndex = 8;
            // 
            // frmInventoryReload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 116);
            this.Controls.Add(this.grbPallet);
            this.Controls.Add(this.grbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryReload";
            this.Text = "Inventario";
            this.grbPallet.ResumeLayout(false);
            this.grbPallet.PerformLayout();
            this.grbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPallet;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblpallet;
        private System.Windows.Forms.TextBox txtcodepallet;
    }
}