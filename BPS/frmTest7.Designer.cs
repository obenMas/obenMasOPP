namespace BPS
{
    partial class frmTest7
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
            this.lblStockgross = new System.Windows.Forms.Label();
            this.lblStockGrossWeightLabel = new System.Windows.Forms.Label();
            this.grpbStockView = new System.Windows.Forms.GroupBox();
            this.rdoStockAll = new System.Windows.Forms.RadioButton();
            this.rdoStockOnlyObservation = new System.Windows.Forms.RadioButton();
            this.rdoStockOnlyFirst = new System.Windows.Forms.RadioButton();
            this.lblStockPallets = new System.Windows.Forms.Label();
            this.lblStockPalletsLabel = new System.Windows.Forms.Label();
            this.lblStockProduct = new System.Windows.Forms.Label();
            this.lblStockObservationWeight = new System.Windows.Forms.Label();
            this.lblStockUncuttedWeight = new System.Windows.Forms.Label();
            this.lblStockObservationCoils = new System.Windows.Forms.Label();
            this.lblStockMissingCoils = new System.Windows.Forms.Label();
            this.lblStockCuttedWeight = new System.Windows.Forms.Label();
            this.lblStockCuttedCoils = new System.Windows.Forms.Label();
            this.lblStockObservationWeightLabel = new System.Windows.Forms.Label();
            this.lblStockUncuttedWeightLabel = new System.Windows.Forms.Label();
            this.lblStockObservationCoilsLabel = new System.Windows.Forms.Label();
            this.lblStockMissingCoilsLabel = new System.Windows.Forms.Label();
            this.lblStockProductName = new System.Windows.Forms.Label();
            this.lblStockTotalWeight = new System.Windows.Forms.Label();
            this.lblStockTotalCoils = new System.Windows.Forms.Label();
            this.lblStockWeight = new System.Windows.Forms.Label();
            this.lblStockTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblStockCuttedWeightLabel = new System.Windows.Forms.Label();
            this.lblStockCoils = new System.Windows.Forms.Label();
            this.lblStockTotalCoilsLabel = new System.Windows.Forms.Label();
            this.lblStockCuttedCoilsLabel = new System.Windows.Forms.Label();
            this.grpbStockView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockgross
            // 
            this.lblStockgross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockgross.Location = new System.Drawing.Point(724, 78);
            this.lblStockgross.Name = "lblStockgross";
            this.lblStockgross.Size = new System.Drawing.Size(81, 24);
            this.lblStockgross.TabIndex = 41;
            // 
            // lblStockGrossWeightLabel
            // 
            this.lblStockGrossWeightLabel.AutoSize = true;
            this.lblStockGrossWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockGrossWeightLabel.Location = new System.Drawing.Point(661, 83);
            this.lblStockGrossWeightLabel.Name = "lblStockGrossWeightLabel";
            this.lblStockGrossWeightLabel.Size = new System.Drawing.Size(58, 15);
            this.lblStockGrossWeightLabel.TabIndex = 40;
            this.lblStockGrossWeightLabel.Text = "P. Bruto";
            // 
            // grpbStockView
            // 
            this.grpbStockView.Controls.Add(this.rdoStockAll);
            this.grpbStockView.Controls.Add(this.rdoStockOnlyObservation);
            this.grpbStockView.Controls.Add(this.rdoStockOnlyFirst);
            this.grpbStockView.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbStockView.Location = new System.Drawing.Point(945, 0);
            this.grpbStockView.Name = "grpbStockView";
            this.grpbStockView.Size = new System.Drawing.Size(137, 367);
            this.grpbStockView.TabIndex = 39;
            this.grpbStockView.TabStop = false;
            this.grpbStockView.Text = "Vistas";
            // 
            // rdoStockAll
            // 
            this.rdoStockAll.AutoSize = true;
            this.rdoStockAll.Location = new System.Drawing.Point(6, 64);
            this.rdoStockAll.Name = "rdoStockAll";
            this.rdoStockAll.Size = new System.Drawing.Size(70, 17);
            this.rdoStockAll.TabIndex = 15;
            this.rdoStockAll.Text = "Ver todas";
            this.rdoStockAll.UseVisualStyleBackColor = true;
            // 
            // rdoStockOnlyObservation
            // 
            this.rdoStockOnlyObservation.AutoSize = true;
            this.rdoStockOnlyObservation.Location = new System.Drawing.Point(6, 42);
            this.rdoStockOnlyObservation.Name = "rdoStockOnlyObservation";
            this.rdoStockOnlyObservation.Size = new System.Drawing.Size(109, 17);
            this.rdoStockOnlyObservation.TabIndex = 15;
            this.rdoStockOnlyObservation.Text = "Solo Observación";
            this.rdoStockOnlyObservation.UseVisualStyleBackColor = true;
            // 
            // rdoStockOnlyFirst
            // 
            this.rdoStockOnlyFirst.AutoSize = true;
            this.rdoStockOnlyFirst.Checked = true;
            this.rdoStockOnlyFirst.Location = new System.Drawing.Point(6, 20);
            this.rdoStockOnlyFirst.Name = "rdoStockOnlyFirst";
            this.rdoStockOnlyFirst.Size = new System.Drawing.Size(83, 17);
            this.rdoStockOnlyFirst.TabIndex = 15;
            this.rdoStockOnlyFirst.TabStop = true;
            this.rdoStockOnlyFirst.Text = "Solo primera";
            this.rdoStockOnlyFirst.UseVisualStyleBackColor = true;
            // 
            // lblStockPallets
            // 
            this.lblStockPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPallets.Location = new System.Drawing.Point(724, 46);
            this.lblStockPallets.Name = "lblStockPallets";
            this.lblStockPallets.Size = new System.Drawing.Size(81, 24);
            this.lblStockPallets.TabIndex = 38;
            // 
            // lblStockPalletsLabel
            // 
            this.lblStockPalletsLabel.AutoSize = true;
            this.lblStockPalletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPalletsLabel.Location = new System.Drawing.Point(661, 51);
            this.lblStockPalletsLabel.Name = "lblStockPalletsLabel";
            this.lblStockPalletsLabel.Size = new System.Drawing.Size(51, 15);
            this.lblStockPalletsLabel.TabIndex = 37;
            this.lblStockPalletsLabel.Text = "Pallets";
            // 
            // lblStockProduct
            // 
            this.lblStockProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProduct.Location = new System.Drawing.Point(238, 17);
            this.lblStockProduct.Name = "lblStockProduct";
            this.lblStockProduct.Size = new System.Drawing.Size(440, 21);
            this.lblStockProduct.TabIndex = 18;
            // 
            // lblStockObservationWeight
            // 
            this.lblStockObservationWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockObservationWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockObservationWeight.Location = new System.Drawing.Point(424, 79);
            this.lblStockObservationWeight.Name = "lblStockObservationWeight";
            this.lblStockObservationWeight.Size = new System.Drawing.Size(81, 24);
            this.lblStockObservationWeight.TabIndex = 29;
            // 
            // lblStockUncuttedWeight
            // 
            this.lblStockUncuttedWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockUncuttedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockUncuttedWeight.Location = new System.Drawing.Point(574, 79);
            this.lblStockUncuttedWeight.Name = "lblStockUncuttedWeight";
            this.lblStockUncuttedWeight.Size = new System.Drawing.Size(81, 24);
            this.lblStockUncuttedWeight.TabIndex = 32;
            // 
            // lblStockObservationCoils
            // 
            this.lblStockObservationCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockObservationCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockObservationCoils.Location = new System.Drawing.Point(424, 46);
            this.lblStockObservationCoils.Name = "lblStockObservationCoils";
            this.lblStockObservationCoils.Size = new System.Drawing.Size(81, 24);
            this.lblStockObservationCoils.TabIndex = 35;
            // 
            // lblStockMissingCoils
            // 
            this.lblStockMissingCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockMissingCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMissingCoils.Location = new System.Drawing.Point(574, 46);
            this.lblStockMissingCoils.Name = "lblStockMissingCoils";
            this.lblStockMissingCoils.Size = new System.Drawing.Size(81, 24);
            this.lblStockMissingCoils.TabIndex = 36;
            // 
            // lblStockCuttedWeight
            // 
            this.lblStockCuttedWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockCuttedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCuttedWeight.Location = new System.Drawing.Point(256, 79);
            this.lblStockCuttedWeight.Name = "lblStockCuttedWeight";
            this.lblStockCuttedWeight.Size = new System.Drawing.Size(81, 24);
            this.lblStockCuttedWeight.TabIndex = 33;
            // 
            // lblStockCuttedCoils
            // 
            this.lblStockCuttedCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockCuttedCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCuttedCoils.Location = new System.Drawing.Point(256, 46);
            this.lblStockCuttedCoils.Name = "lblStockCuttedCoils";
            this.lblStockCuttedCoils.Size = new System.Drawing.Size(81, 24);
            this.lblStockCuttedCoils.TabIndex = 34;
            // 
            // lblStockObservationWeightLabel
            // 
            this.lblStockObservationWeightLabel.AutoSize = true;
            this.lblStockObservationWeightLabel.Location = new System.Drawing.Point(343, 84);
            this.lblStockObservationWeightLabel.Name = "lblStockObservationWeightLabel";
            this.lblStockObservationWeightLabel.Size = new System.Drawing.Size(67, 13);
            this.lblStockObservationWeightLabel.TabIndex = 28;
            this.lblStockObservationWeightLabel.Text = "Observación";
            // 
            // lblStockUncuttedWeightLabel
            // 
            this.lblStockUncuttedWeightLabel.AutoSize = true;
            this.lblStockUncuttedWeightLabel.Location = new System.Drawing.Point(511, 84);
            this.lblStockUncuttedWeightLabel.Name = "lblStockUncuttedWeightLabel";
            this.lblStockUncuttedWeightLabel.Size = new System.Drawing.Size(45, 13);
            this.lblStockUncuttedWeightLabel.TabIndex = 20;
            this.lblStockUncuttedWeightLabel.Text = "Faltante";
            // 
            // lblStockObservationCoilsLabel
            // 
            this.lblStockObservationCoilsLabel.AutoSize = true;
            this.lblStockObservationCoilsLabel.Location = new System.Drawing.Point(343, 51);
            this.lblStockObservationCoilsLabel.Name = "lblStockObservationCoilsLabel";
            this.lblStockObservationCoilsLabel.Size = new System.Drawing.Size(67, 13);
            this.lblStockObservationCoilsLabel.TabIndex = 22;
            this.lblStockObservationCoilsLabel.Text = "Observación";
            // 
            // lblStockMissingCoilsLabel
            // 
            this.lblStockMissingCoilsLabel.AutoSize = true;
            this.lblStockMissingCoilsLabel.Location = new System.Drawing.Point(511, 51);
            this.lblStockMissingCoilsLabel.Name = "lblStockMissingCoilsLabel";
            this.lblStockMissingCoilsLabel.Size = new System.Drawing.Size(45, 13);
            this.lblStockMissingCoilsLabel.TabIndex = 19;
            this.lblStockMissingCoilsLabel.Text = "Faltante";
            // 
            // lblStockProductName
            // 
            this.lblStockProductName.AutoSize = true;
            this.lblStockProductName.Location = new System.Drawing.Point(130, 20);
            this.lblStockProductName.Name = "lblStockProductName";
            this.lblStockProductName.Size = new System.Drawing.Size(50, 13);
            this.lblStockProductName.TabIndex = 17;
            this.lblStockProductName.Text = "Producto";
            // 
            // lblStockTotalWeight
            // 
            this.lblStockTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotalWeight.Location = new System.Drawing.Point(113, 79);
            this.lblStockTotalWeight.Name = "lblStockTotalWeight";
            this.lblStockTotalWeight.Size = new System.Drawing.Size(81, 24);
            this.lblStockTotalWeight.TabIndex = 30;
            // 
            // lblStockTotalCoils
            // 
            this.lblStockTotalCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockTotalCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotalCoils.Location = new System.Drawing.Point(113, 46);
            this.lblStockTotalCoils.Name = "lblStockTotalCoils";
            this.lblStockTotalCoils.Size = new System.Drawing.Size(81, 24);
            this.lblStockTotalCoils.TabIndex = 31;
            // 
            // lblStockWeight
            // 
            this.lblStockWeight.AutoSize = true;
            this.lblStockWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWeight.Location = new System.Drawing.Point(3, 83);
            this.lblStockWeight.Name = "lblStockWeight";
            this.lblStockWeight.Size = new System.Drawing.Size(44, 17);
            this.lblStockWeight.TabIndex = 27;
            this.lblStockWeight.Text = "Peso";
            // 
            // lblStockTotalWeightLabel
            // 
            this.lblStockTotalWeightLabel.AutoSize = true;
            this.lblStockTotalWeightLabel.Location = new System.Drawing.Point(73, 84);
            this.lblStockTotalWeightLabel.Name = "lblStockTotalWeightLabel";
            this.lblStockTotalWeightLabel.Size = new System.Drawing.Size(31, 13);
            this.lblStockTotalWeightLabel.TabIndex = 25;
            this.lblStockTotalWeightLabel.Text = "Total";
            // 
            // lblStockCuttedWeightLabel
            // 
            this.lblStockCuttedWeightLabel.AutoSize = true;
            this.lblStockCuttedWeightLabel.Location = new System.Drawing.Point(200, 84);
            this.lblStockCuttedWeightLabel.Name = "lblStockCuttedWeightLabel";
            this.lblStockCuttedWeightLabel.Size = new System.Drawing.Size(42, 13);
            this.lblStockCuttedWeightLabel.TabIndex = 23;
            this.lblStockCuttedWeightLabel.Text = "Primera";
            // 
            // lblStockCoils
            // 
            this.lblStockCoils.AutoSize = true;
            this.lblStockCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCoils.Location = new System.Drawing.Point(3, 50);
            this.lblStockCoils.Name = "lblStockCoils";
            this.lblStockCoils.Size = new System.Drawing.Size(66, 17);
            this.lblStockCoils.TabIndex = 24;
            this.lblStockCoils.Text = "Bobinas";
            // 
            // lblStockTotalCoilsLabel
            // 
            this.lblStockTotalCoilsLabel.AutoSize = true;
            this.lblStockTotalCoilsLabel.Location = new System.Drawing.Point(73, 51);
            this.lblStockTotalCoilsLabel.Name = "lblStockTotalCoilsLabel";
            this.lblStockTotalCoilsLabel.Size = new System.Drawing.Size(31, 13);
            this.lblStockTotalCoilsLabel.TabIndex = 26;
            this.lblStockTotalCoilsLabel.Text = "Total";
            // 
            // lblStockCuttedCoilsLabel
            // 
            this.lblStockCuttedCoilsLabel.AutoSize = true;
            this.lblStockCuttedCoilsLabel.Location = new System.Drawing.Point(200, 51);
            this.lblStockCuttedCoilsLabel.Name = "lblStockCuttedCoilsLabel";
            this.lblStockCuttedCoilsLabel.Size = new System.Drawing.Size(42, 13);
            this.lblStockCuttedCoilsLabel.TabIndex = 21;
            this.lblStockCuttedCoilsLabel.Text = "Primera";
            // 
            // frmTest7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 367);
            this.Controls.Add(this.lblStockgross);
            this.Controls.Add(this.lblStockGrossWeightLabel);
            this.Controls.Add(this.grpbStockView);
            this.Controls.Add(this.lblStockPallets);
            this.Controls.Add(this.lblStockPalletsLabel);
            this.Controls.Add(this.lblStockProduct);
            this.Controls.Add(this.lblStockObservationWeight);
            this.Controls.Add(this.lblStockUncuttedWeight);
            this.Controls.Add(this.lblStockObservationCoils);
            this.Controls.Add(this.lblStockMissingCoils);
            this.Controls.Add(this.lblStockCuttedWeight);
            this.Controls.Add(this.lblStockCuttedCoils);
            this.Controls.Add(this.lblStockObservationWeightLabel);
            this.Controls.Add(this.lblStockUncuttedWeightLabel);
            this.Controls.Add(this.lblStockObservationCoilsLabel);
            this.Controls.Add(this.lblStockMissingCoilsLabel);
            this.Controls.Add(this.lblStockProductName);
            this.Controls.Add(this.lblStockTotalWeight);
            this.Controls.Add(this.lblStockTotalCoils);
            this.Controls.Add(this.lblStockWeight);
            this.Controls.Add(this.lblStockTotalWeightLabel);
            this.Controls.Add(this.lblStockCuttedWeightLabel);
            this.Controls.Add(this.lblStockCoils);
            this.Controls.Add(this.lblStockTotalCoilsLabel);
            this.Controls.Add(this.lblStockCuttedCoilsLabel);
            this.Name = "frmTest7";
            this.Text = "frmTest7";
            this.Load += new System.EventHandler(this.frmTest7_Load);
            this.grpbStockView.ResumeLayout(false);
            this.grpbStockView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockgross;
        private System.Windows.Forms.Label lblStockGrossWeightLabel;
        private System.Windows.Forms.GroupBox grpbStockView;
        private System.Windows.Forms.RadioButton rdoStockAll;
        private System.Windows.Forms.RadioButton rdoStockOnlyObservation;
        private System.Windows.Forms.RadioButton rdoStockOnlyFirst;
        private System.Windows.Forms.Label lblStockPallets;
        private System.Windows.Forms.Label lblStockPalletsLabel;
        private System.Windows.Forms.Label lblStockProduct;
        private System.Windows.Forms.Label lblStockObservationWeight;
        private System.Windows.Forms.Label lblStockUncuttedWeight;
        private System.Windows.Forms.Label lblStockObservationCoils;
        private System.Windows.Forms.Label lblStockMissingCoils;
        private System.Windows.Forms.Label lblStockCuttedWeight;
        private System.Windows.Forms.Label lblStockCuttedCoils;
        private System.Windows.Forms.Label lblStockObservationWeightLabel;
        private System.Windows.Forms.Label lblStockUncuttedWeightLabel;
        private System.Windows.Forms.Label lblStockObservationCoilsLabel;
        private System.Windows.Forms.Label lblStockMissingCoilsLabel;
        private System.Windows.Forms.Label lblStockProductName;
        private System.Windows.Forms.Label lblStockTotalWeight;
        private System.Windows.Forms.Label lblStockTotalCoils;
        private System.Windows.Forms.Label lblStockWeight;
        private System.Windows.Forms.Label lblStockTotalWeightLabel;
        private System.Windows.Forms.Label lblStockCuttedWeightLabel;
        private System.Windows.Forms.Label lblStockCoils;
        private System.Windows.Forms.Label lblStockTotalCoilsLabel;
        private System.Windows.Forms.Label lblStockCuttedCoilsLabel;



    }
}