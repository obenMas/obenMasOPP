namespace BPS
{
    partial class frmExportDataInternationalSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportDataInternationalSalesOrder));
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbpComercialCondition = new System.Windows.Forms.TabPage();
            this.cmbComercialCondition = new System.Windows.Forms.ComboBox();
            this.grpbOrder = new System.Windows.Forms.GroupBox();
            this.lstbOrders = new System.Windows.Forms.ListBox();
            this.chkbOrders = new System.Windows.Forms.CheckBox();
            this.lblComercialConditionLabel = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbComercialConditionMain = new System.Windows.Forms.GroupBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtComercialConditionNotes = new System.Windows.Forms.TextBox();
            this.tbcMain.SuspendLayout();
            this.tbpComercialCondition.SuspendLayout();
            this.grpbOrder.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.grpbComercialConditionMain.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpComercialCondition);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(858, 237);
            this.tbcMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbpComercialCondition
            // 
            this.tbpComercialCondition.Controls.Add(this.grpbNotes);
            this.tbpComercialCondition.Controls.Add(this.grpbComercialConditionMain);
            this.tbpComercialCondition.Controls.Add(this.grpbOrder);
            this.tbpComercialCondition.Location = new System.Drawing.Point(4, 24);
            this.tbpComercialCondition.Name = "tbpComercialCondition";
            this.tbpComercialCondition.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComercialCondition.Size = new System.Drawing.Size(850, 209);
            this.tbpComercialCondition.TabIndex = 0;
            this.tbpComercialCondition.Text = "Condición Comercial";
            this.tbpComercialCondition.UseVisualStyleBackColor = true;
            // 
            // cmbComercialCondition
            // 
            this.cmbComercialCondition.FormattingEnabled = true;
            this.cmbComercialCondition.Location = new System.Drawing.Point(304, 14);
            this.cmbComercialCondition.Name = "cmbComercialCondition";
            this.cmbComercialCondition.Size = new System.Drawing.Size(228, 23);
            this.cmbComercialCondition.TabIndex = 0;
            // 
            // grpbOrder
            // 
            this.grpbOrder.Controls.Add(this.lstbOrders);
            this.grpbOrder.Controls.Add(this.chkbOrders);
            this.grpbOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbOrder.Location = new System.Drawing.Point(711, 3);
            this.grpbOrder.Name = "grpbOrder";
            this.grpbOrder.Size = new System.Drawing.Size(136, 203);
            this.grpbOrder.TabIndex = 3;
            this.grpbOrder.TabStop = false;
            this.grpbOrder.Text = "Ordenes Disponibles";
            // 
            // lstbOrders
            // 
            this.lstbOrders.FormattingEnabled = true;
            this.lstbOrders.ItemHeight = 15;
            this.lstbOrders.Location = new System.Drawing.Point(6, 41);
            this.lstbOrders.Name = "lstbOrders";
            this.lstbOrders.Size = new System.Drawing.Size(125, 154);
            this.lstbOrders.TabIndex = 2;
            this.lstbOrders.SelectedIndexChanged += new System.EventHandler(this.lstbOrders_SelectedIndexChanged);
            // 
            // chkbOrders
            // 
            this.chkbOrders.AutoSize = true;
            this.chkbOrders.Location = new System.Drawing.Point(6, 20);
            this.chkbOrders.Name = "chkbOrders";
            this.chkbOrders.Size = new System.Drawing.Size(60, 19);
            this.chkbOrders.TabIndex = 1;
            this.chkbOrders.Text = "Todas";
            this.chkbOrders.UseVisualStyleBackColor = true;
            this.chkbOrders.CheckedChanged += new System.EventHandler(this.chkbOrders_CheckedChanged);
            // 
            // lblComercialConditionLabel
            // 
            this.lblComercialConditionLabel.AutoSize = true;
            this.lblComercialConditionLabel.Location = new System.Drawing.Point(177, 17);
            this.lblComercialConditionLabel.Name = "lblComercialConditionLabel";
            this.lblComercialConditionLabel.Size = new System.Drawing.Size(121, 15);
            this.lblComercialConditionLabel.TabIndex = 2;
            this.lblComercialConditionLabel.Text = "Condición Comercial";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 237);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(858, 40);
            this.grpbActions.TabIndex = 1;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(829, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpbComercialConditionMain
            // 
            this.grpbComercialConditionMain.Controls.Add(this.cmbComercialCondition);
            this.grpbComercialConditionMain.Controls.Add(this.lblComercialConditionLabel);
            this.grpbComercialConditionMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbComercialConditionMain.Location = new System.Drawing.Point(3, 3);
            this.grpbComercialConditionMain.Name = "grpbComercialConditionMain";
            this.grpbComercialConditionMain.Size = new System.Drawing.Size(708, 46);
            this.grpbComercialConditionMain.TabIndex = 4;
            this.grpbComercialConditionMain.TabStop = false;
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtComercialConditionNotes);
            this.grpbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbNotes.Location = new System.Drawing.Point(3, 49);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(708, 157);
            this.grpbNotes.TabIndex = 5;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Información de Selección";
            // 
            // txtComercialConditionNotes
            // 
            this.txtComercialConditionNotes.Enabled = false;
            this.txtComercialConditionNotes.Location = new System.Drawing.Point(6, 20);
            this.txtComercialConditionNotes.Multiline = true;
            this.txtComercialConditionNotes.Name = "txtComercialConditionNotes";
            this.txtComercialConditionNotes.Size = new System.Drawing.Size(696, 129);
            this.txtComercialConditionNotes.TabIndex = 0;
            // 
            // frmExportDataInternationalSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(858, 277);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportDataInternationalSalesOrder";
            this.Text = "Exportación Ordenes Internacionales";
            this.tbcMain.ResumeLayout(false);
            this.tbpComercialCondition.ResumeLayout(false);
            this.grpbOrder.ResumeLayout(false);
            this.grpbOrder.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.grpbComercialConditionMain.ResumeLayout(false);
            this.grpbComercialConditionMain.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpComercialCondition;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbComercialCondition;
        private System.Windows.Forms.GroupBox grpbOrder;
        private System.Windows.Forms.CheckBox chkbOrders;
        private System.Windows.Forms.Label lblComercialConditionLabel;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.ListBox lstbOrders;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.GroupBox grpbComercialConditionMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComercialConditionNotes;
    }
}