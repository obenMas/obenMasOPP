namespace BPS
{
    partial class frmSupplyReceptionDetail
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyReceptionDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbRawMaterialReceptionButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbData = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNumberPackages = new System.Windows.Forms.TextBox();
            this.lblNumberPackages = new System.Windows.Forms.Label();
            this.txtWeigthPerUnit = new System.Windows.Forms.TextBox();
            this.lblWeigthPerUnit = new System.Windows.Forms.Label();
            this.txtUnitsPerPackage = new System.Windows.Forms.TextBox();
            this.lblUnitsPerPackage = new System.Windows.Forms.Label();
            this.txtWeigthPerPackage = new System.Windows.Forms.TextBox();
            this.lblWeigthPerPackage = new System.Windows.Forms.Label();
            this.grpbGeneralData = new System.Windows.Forms.GroupBox();
            this.txtUnit = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtSupplyName = new System.Windows.Forms.Label();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.ttpSupplyReceptionDetails = new System.Windows.Forms.ToolTip(this.components);
            this.grpbRawMaterialReceptionButtons.SuspendLayout();
            this.grpbData.SuspendLayout();
            this.grpbGeneralData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 44);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // grpbRawMaterialReceptionButtons
            // 
            this.grpbRawMaterialReceptionButtons.Controls.Add(this.btnSave);
            this.grpbRawMaterialReceptionButtons.Controls.Add(this.btnCancel);
            this.grpbRawMaterialReceptionButtons.Location = new System.Drawing.Point(247, 341);
            this.grpbRawMaterialReceptionButtons.Name = "grpbRawMaterialReceptionButtons";
            this.grpbRawMaterialReceptionButtons.Size = new System.Drawing.Size(68, 44);
            this.grpbRawMaterialReceptionButtons.TabIndex = 23;
            this.grpbRawMaterialReceptionButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(7, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 5;
            this.ttpSupplyReceptionDetails.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(35, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 6;
            this.ttpSupplyReceptionDetails.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbData
            // 
            this.grpbData.Controls.Add(this.txtTotal);
            this.grpbData.Controls.Add(this.lblTotal);
            this.grpbData.Controls.Add(this.txtNumberPackages);
            this.grpbData.Controls.Add(this.lblNumberPackages);
            this.grpbData.Controls.Add(this.txtWeigthPerUnit);
            this.grpbData.Controls.Add(this.lblWeigthPerUnit);
            this.grpbData.Controls.Add(this.txtUnitsPerPackage);
            this.grpbData.Controls.Add(this.lblUnitsPerPackage);
            this.grpbData.Controls.Add(this.txtWeigthPerPackage);
            this.grpbData.Controls.Add(this.lblWeigthPerPackage);
            this.grpbData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbData.Location = new System.Drawing.Point(0, 153);
            this.grpbData.Name = "grpbData";
            this.grpbData.Size = new System.Drawing.Size(320, 224);
            this.grpbData.TabIndex = 22;
            this.grpbData.TabStop = false;
            this.grpbData.Text = "Información";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(155, 167);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(157, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 170);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Recibido";
            // 
            // txtNumberPackages
            // 
            this.txtNumberPackages.Location = new System.Drawing.Point(154, 30);
            this.txtNumberPackages.Name = "txtNumberPackages";
            this.txtNumberPackages.Size = new System.Drawing.Size(158, 20);
            this.txtNumberPackages.TabIndex = 1;
            // 
            // lblNumberPackages
            // 
            this.lblNumberPackages.AutoSize = true;
            this.lblNumberPackages.Location = new System.Drawing.Point(9, 33);
            this.lblNumberPackages.Name = "lblNumberPackages";
            this.lblNumberPackages.Size = new System.Drawing.Size(107, 13);
            this.lblNumberPackages.TabIndex = 6;
            this.lblNumberPackages.Text = "Número de Paquetes";
            // 
            // txtWeigthPerUnit
            // 
            this.txtWeigthPerUnit.Location = new System.Drawing.Point(154, 133);
            this.txtWeigthPerUnit.Name = "txtWeigthPerUnit";
            this.txtWeigthPerUnit.Size = new System.Drawing.Size(158, 20);
            this.txtWeigthPerUnit.TabIndex = 4;
            // 
            // lblWeigthPerUnit
            // 
            this.lblWeigthPerUnit.AutoSize = true;
            this.lblWeigthPerUnit.Location = new System.Drawing.Point(9, 136);
            this.lblWeigthPerUnit.Name = "lblWeigthPerUnit";
            this.lblWeigthPerUnit.Size = new System.Drawing.Size(87, 13);
            this.lblWeigthPerUnit.TabIndex = 4;
            this.lblWeigthPerUnit.Text = "Peso Por Unidad";
            // 
            // txtUnitsPerPackage
            // 
            this.txtUnitsPerPackage.Location = new System.Drawing.Point(154, 98);
            this.txtUnitsPerPackage.Name = "txtUnitsPerPackage";
            this.txtUnitsPerPackage.Size = new System.Drawing.Size(158, 20);
            this.txtUnitsPerPackage.TabIndex = 3;
            // 
            // lblUnitsPerPackage
            // 
            this.lblUnitsPerPackage.AutoSize = true;
            this.lblUnitsPerPackage.Location = new System.Drawing.Point(9, 101);
            this.lblUnitsPerPackage.Name = "lblUnitsPerPackage";
            this.lblUnitsPerPackage.Size = new System.Drawing.Size(114, 13);
            this.lblUnitsPerPackage.TabIndex = 2;
            this.lblUnitsPerPackage.Text = "Unidades Por Paquete";
            // 
            // txtWeigthPerPackage
            // 
            this.txtWeigthPerPackage.Location = new System.Drawing.Point(154, 65);
            this.txtWeigthPerPackage.Name = "txtWeigthPerPackage";
            this.txtWeigthPerPackage.Size = new System.Drawing.Size(158, 20);
            this.txtWeigthPerPackage.TabIndex = 2;
            // 
            // lblWeigthPerPackage
            // 
            this.lblWeigthPerPackage.AutoSize = true;
            this.lblWeigthPerPackage.Location = new System.Drawing.Point(9, 68);
            this.lblWeigthPerPackage.Name = "lblWeigthPerPackage";
            this.lblWeigthPerPackage.Size = new System.Drawing.Size(93, 13);
            this.lblWeigthPerPackage.TabIndex = 1;
            this.lblWeigthPerPackage.Text = "Peso Por Paquete";
            // 
            // grpbGeneralData
            // 
            this.grpbGeneralData.Controls.Add(this.txtUnit);
            this.grpbGeneralData.Controls.Add(this.lblUnit);
            this.grpbGeneralData.Controls.Add(this.txtQuantity);
            this.grpbGeneralData.Controls.Add(this.lblQuantity);
            this.grpbGeneralData.Controls.Add(this.txtBatch);
            this.grpbGeneralData.Controls.Add(this.lblBatch);
            this.grpbGeneralData.Controls.Add(this.txtSupplyName);
            this.grpbGeneralData.Controls.Add(this.lblSupplyName);
            this.grpbGeneralData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbGeneralData.Location = new System.Drawing.Point(0, 0);
            this.grpbGeneralData.Name = "grpbGeneralData";
            this.grpbGeneralData.Size = new System.Drawing.Size(320, 153);
            this.grpbGeneralData.TabIndex = 21;
            this.grpbGeneralData.TabStop = false;
            this.grpbGeneralData.Text = "Datos Generales";
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtUnit.Location = new System.Drawing.Point(154, 82);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(158, 21);
            this.txtUnit.TabIndex = 19;
            this.txtUnit.Tag = "clearOnReload";
            this.txtUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(9, 85);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 13);
            this.lblUnit.TabIndex = 18;
            this.lblUnit.Text = "Unidad";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtQuantity.Location = new System.Drawing.Point(154, 118);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(158, 21);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.Tag = "clearOnReload";
            this.txtQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 121);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(94, 13);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Cantidad Recibida";
            // 
            // txtBatch
            // 
            this.txtBatch.BackColor = System.Drawing.SystemColors.Window;
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBatch.Location = new System.Drawing.Point(154, 18);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(104, 21);
            this.txtBatch.TabIndex = 15;
            this.txtBatch.Tag = "clearOnReload";
            this.txtBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(10, 22);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(28, 13);
            this.lblBatch.TabIndex = 14;
            this.lblBatch.Text = "Lote";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupplyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSupplyName.Location = new System.Drawing.Point(154, 49);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(158, 21);
            this.txtSupplyName.TabIndex = 13;
            this.txtSupplyName.Tag = "clearOnReload";
            this.txtSupplyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(9, 52);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(55, 13);
            this.lblSupplyName.TabIndex = 12;
            this.lblSupplyName.Text = "Suministro";
            // 
            // frmSupplyReceptionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbRawMaterialReceptionButtons);
            this.Controls.Add(this.grpbData);
            this.Controls.Add(this.grpbGeneralData);
            this.Name = "frmSupplyReceptionDetail";
            this.Text = "Detalle Recepción Suministros";
            this.Load += new System.EventHandler(this.frmSupplyReceptionDetail_Load);
            this.grpbRawMaterialReceptionButtons.ResumeLayout(false);
            this.grpbData.ResumeLayout(false);
            this.grpbData.PerformLayout();
            this.grpbGeneralData.ResumeLayout(false);
            this.grpbGeneralData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbRawMaterialReceptionButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbData;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNumberPackages;
        private System.Windows.Forms.Label lblNumberPackages;
        private System.Windows.Forms.TextBox txtWeigthPerUnit;
        private System.Windows.Forms.Label lblWeigthPerUnit;
        private System.Windows.Forms.TextBox txtUnitsPerPackage;
        private System.Windows.Forms.Label lblUnitsPerPackage;
        private System.Windows.Forms.TextBox txtWeigthPerPackage;
        private System.Windows.Forms.Label lblWeigthPerPackage;
        private System.Windows.Forms.GroupBox grpbGeneralData;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label txtBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label txtSupplyName;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Label txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ToolTip ttpSupplyReceptionDetails;
    }
}