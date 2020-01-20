namespace BPS.Lite
{
    partial class frmProductionOrderClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionOrderClose));
            this.grpbClose = new System.Windows.Forms.GroupBox();
            this.lblProductionOrder = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.rdoCreateNewWithPlan = new System.Windows.Forms.RadioButton();
            this.rdoCreateNewNoPlan = new System.Windows.Forms.RadioButton();
            this.rdoClose = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpOrdenClose = new System.Windows.Forms.ToolTip(this.components);
            this.lblLot = new System.Windows.Forms.Label();
            this.grpbClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbClose
            // 
            this.grpbClose.Controls.Add(this.lblLot);
            this.grpbClose.Controls.Add(this.lblProductionOrder);
            this.grpbClose.Controls.Add(this.lblNote);
            this.grpbClose.Controls.Add(this.rdoCreateNewWithPlan);
            this.grpbClose.Controls.Add(this.rdoCreateNewNoPlan);
            this.grpbClose.Controls.Add(this.rdoClose);
            this.grpbClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbClose.Location = new System.Drawing.Point(0, 0);
            this.grpbClose.Name = "grpbClose";
            this.grpbClose.Size = new System.Drawing.Size(365, 199);
            this.grpbClose.TabIndex = 0;
            this.grpbClose.TabStop = false;
            // 
            // lblProductionOrder
            // 
            this.lblProductionOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionOrder.Location = new System.Drawing.Point(3, 17);
            this.lblProductionOrder.Name = "lblProductionOrder";
            this.lblProductionOrder.Size = new System.Drawing.Size(359, 23);
            this.lblProductionOrder.TabIndex = 2;
            this.lblProductionOrder.Text = "Orden Nro:";
            this.lblProductionOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(3, 148);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(359, 48);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Cierre definitivo de la orden de extrusión, una vez cerrada no se volvera a abrir" +
    "";
            // 
            // rdoCreateNewWithPlan
            // 
            this.rdoCreateNewWithPlan.AutoSize = true;
            this.rdoCreateNewWithPlan.Location = new System.Drawing.Point(68, 121);
            this.rdoCreateNewWithPlan.Name = "rdoCreateNewWithPlan";
            this.rdoCreateNewWithPlan.Size = new System.Drawing.Size(229, 19);
            this.rdoCreateNewWithPlan.TabIndex = 0;
            this.rdoCreateNewWithPlan.Text = "Cerrar ordern, crear y planificar nueva";
            this.rdoCreateNewWithPlan.UseVisualStyleBackColor = true;
            this.rdoCreateNewWithPlan.CheckedChanged += new System.EventHandler(this.rdoCloseAndCreate_CheckedChanged);
            // 
            // rdoCreateNewNoPlan
            // 
            this.rdoCreateNewNoPlan.AutoSize = true;
            this.rdoCreateNewNoPlan.Location = new System.Drawing.Point(68, 97);
            this.rdoCreateNewNoPlan.Name = "rdoCreateNewNoPlan";
            this.rdoCreateNewNoPlan.Size = new System.Drawing.Size(169, 19);
            this.rdoCreateNewNoPlan.TabIndex = 0;
            this.rdoCreateNewNoPlan.Text = "Cerrar orden y crear nueva";
            this.rdoCreateNewNoPlan.UseVisualStyleBackColor = true;
            this.rdoCreateNewNoPlan.CheckedChanged += new System.EventHandler(this.r_CheckedChanged);
            // 
            // rdoClose
            // 
            this.rdoClose.AutoSize = true;
            this.rdoClose.Checked = true;
            this.rdoClose.Location = new System.Drawing.Point(68, 73);
            this.rdoClose.Name = "rdoClose";
            this.rdoClose.Size = new System.Drawing.Size(107, 19);
            this.rdoClose.TabIndex = 0;
            this.rdoClose.TabStop = true;
            this.rdoClose.Text = "Cerrar la orden";
            this.rdoClose.UseVisualStyleBackColor = true;
            this.rdoClose.CheckedChanged += new System.EventHandler(this.rdoClose_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.Location = new System.Drawing.Point(150, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpOrdenClose.SetToolTip(this.btnClose, "Cerrar Orden");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLot
            // 
            this.lblLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Location = new System.Drawing.Point(3, 40);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(359, 23);
            this.lblLot.TabIndex = 3;
            this.lblLot.Text = "Lote";
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProductionOrderClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(365, 277);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionOrderClose";
            this.ShowInTaskbar = false;
            this.Text = "Cierre de orden de producción";
            this.Load += new System.EventHandler(this.frmProductionOrderClose_Load);
            this.grpbClose.ResumeLayout(false);
            this.grpbClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbClose;
        private System.Windows.Forms.RadioButton rdoClose;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RadioButton rdoCreateNewWithPlan;
        private System.Windows.Forms.RadioButton rdoCreateNewNoPlan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductionOrder;
        private System.Windows.Forms.ToolTip ttpOrdenClose;
        private System.Windows.Forms.Label lblLot;
    }
}