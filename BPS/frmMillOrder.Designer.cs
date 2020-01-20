namespace BPS
{
    partial class frmMillOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillOrder));
            this.tbcMetalized = new System.Windows.Forms.TabControl();
            this.tbpCoil = new System.Windows.Forms.TabPage();
            this.grpbCoilWeigth = new System.Windows.Forms.GroupBox();
            this.txtgrossweigth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblMetalizedNetWeigth = new System.Windows.Forms.Label();
            this.txtpallet = new System.Windows.Forms.TextBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWeigth = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSequiential = new System.Windows.Forms.TextBox();
            this.cmbMill = new System.Windows.Forms.ComboBox();
            this.cmbMilProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcMetalized.SuspendLayout();
            this.tbpCoil.SuspendLayout();
            this.grpbCoilWeigth.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMetalized
            // 
            this.tbcMetalized.Controls.Add(this.tbpCoil);
            this.tbcMetalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMetalized.Location = new System.Drawing.Point(0, 0);
            this.tbcMetalized.Name = "tbcMetalized";
            this.tbcMetalized.SelectedIndex = 0;
            this.tbcMetalized.Size = new System.Drawing.Size(591, 226);
            this.tbcMetalized.TabIndex = 0;
            // 
            // tbpCoil
            // 
            this.tbpCoil.Controls.Add(this.grpbCoilWeigth);
            this.tbpCoil.Location = new System.Drawing.Point(4, 24);
            this.tbpCoil.Name = "tbpCoil";
            this.tbpCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoil.Size = new System.Drawing.Size(583, 198);
            this.tbpCoil.TabIndex = 0;
            this.tbpCoil.Text = "Material Reproceso";
            this.tbpCoil.UseVisualStyleBackColor = true;
            // 
            // grpbCoilWeigth
            // 
            this.grpbCoilWeigth.Controls.Add(this.txtgrossweigth);
            this.grpbCoilWeigth.Controls.Add(this.label6);
            this.grpbCoilWeigth.Controls.Add(this.label12);
            this.grpbCoilWeigth.Controls.Add(this.lblNetWeigth);
            this.grpbCoilWeigth.Controls.Add(this.lblMetalizedNetWeigth);
            this.grpbCoilWeigth.Controls.Add(this.txtpallet);
            this.grpbCoilWeigth.Controls.Add(this.txtDensity);
            this.grpbCoilWeigth.Controls.Add(this.label8);
            this.grpbCoilWeigth.Controls.Add(this.btnWeigth);
            this.grpbCoilWeigth.Controls.Add(this.txtCustomer);
            this.grpbCoilWeigth.Controls.Add(this.label4);
            this.grpbCoilWeigth.Controls.Add(this.grpbNotes);
            this.grpbCoilWeigth.Controls.Add(this.label1);
            this.grpbCoilWeigth.Controls.Add(this.txtSequiential);
            this.grpbCoilWeigth.Controls.Add(this.cmbMill);
            this.grpbCoilWeigth.Controls.Add(this.cmbMilProduct);
            this.grpbCoilWeigth.Controls.Add(this.label3);
            this.grpbCoilWeigth.Controls.Add(this.label2);
            this.grpbCoilWeigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoilWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCoilWeigth.Location = new System.Drawing.Point(3, 3);
            this.grpbCoilWeigth.Name = "grpbCoilWeigth";
            this.grpbCoilWeigth.Size = new System.Drawing.Size(577, 192);
            this.grpbCoilWeigth.TabIndex = 1;
            this.grpbCoilWeigth.TabStop = false;
            this.grpbCoilWeigth.Text = "Reprocesado";
            // 
            // txtgrossweigth
            // 
            this.txtgrossweigth.Location = new System.Drawing.Point(259, 66);
            this.txtgrossweigth.Name = "txtgrossweigth";
            this.txtgrossweigth.Size = new System.Drawing.Size(107, 20);
            this.txtgrossweigth.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Peso Pallet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Peso Bruto";
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(70, 89);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(100, 26);
            this.lblNetWeigth.TabIndex = 52;
            this.lblNetWeigth.Text = "0";
            // 
            // lblMetalizedNetWeigth
            // 
            this.lblMetalizedNetWeigth.AutoSize = true;
            this.lblMetalizedNetWeigth.Location = new System.Drawing.Point(8, 98);
            this.lblMetalizedNetWeigth.Name = "lblMetalizedNetWeigth";
            this.lblMetalizedNetWeigth.Size = new System.Drawing.Size(57, 13);
            this.lblMetalizedNetWeigth.TabIndex = 51;
            this.lblMetalizedNetWeigth.Text = "Peso Neto";
            // 
            // txtpallet
            // 
            this.txtpallet.Location = new System.Drawing.Point(70, 66);
            this.txtpallet.Name = "txtpallet";
            this.txtpallet.Size = new System.Drawing.Size(107, 20);
            this.txtpallet.TabIndex = 50;
            // 
            // txtDensity
            // 
            this.txtDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensity.Location = new System.Drawing.Point(460, 13);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(112, 47);
            this.txtDensity.TabIndex = 49;
            this.txtDensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDensity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cliente";
            // 
            // btnWeigth
            // 
            this.btnWeigth.Image = global::BPS.Properties.Resources.add_coil24;
            this.btnWeigth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWeigth.Location = new System.Drawing.Point(485, 66);
            this.btnWeigth.Name = "btnWeigth";
            this.btnWeigth.Size = new System.Drawing.Size(75, 50);
            this.btnWeigth.TabIndex = 27;
            this.btnWeigth.Text = "Re-Proceso";
            this.btnWeigth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWeigth.UseVisualStyleBackColor = true;
            this.btnWeigth.Click += new System.EventHandler(this.btnWeigth_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(71, 14);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(110, 20);
            this.txtCustomer.TabIndex = 47;
            this.txtCustomer.Text = "BOPP CALDERON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Densidad";
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtObservations);
            this.grpbNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbNotes.Location = new System.Drawing.Point(3, 117);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(571, 72);
            this.grpbNotes.TabIndex = 32;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservations.Location = new System.Drawing.Point(3, 16);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(565, 53);
            this.txtObservations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Orden";
            // 
            // txtSequiential
            // 
            this.txtSequiential.Location = new System.Drawing.Point(70, 40);
            this.txtSequiential.Name = "txtSequiential";
            this.txtSequiential.Size = new System.Drawing.Size(107, 20);
            this.txtSequiential.TabIndex = 32;
            // 
            // cmbMill
            // 
            this.cmbMill.FormattingEnabled = true;
            this.cmbMill.Items.AddRange(new object[] {
            "Transparente",
            "Perlado",
            "Metalizado",
            "Master Batch / MAS 15",
            "Mz"});
            this.cmbMill.Location = new System.Drawing.Point(259, 39);
            this.cmbMill.Name = "cmbMill";
            this.cmbMill.Size = new System.Drawing.Size(142, 21);
            this.cmbMill.TabIndex = 43;
            // 
            // cmbMilProduct
            // 
            this.cmbMilProduct.FormattingEnabled = true;
            this.cmbMilProduct.Items.AddRange(new object[] {
            "Transparente",
            "Perlado",
            "Metalizado",
            "Master Batch / MAS 15",
            "Mz"});
            this.cmbMilProduct.Location = new System.Drawing.Point(259, 13);
            this.cmbMilProduct.Name = "cmbMilProduct";
            this.cmbMilProduct.Size = new System.Drawing.Size(142, 21);
            this.cmbMilProduct.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Molino";
            // 
            // frmMillOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(591, 226);
            this.Controls.Add(this.tbcMetalized);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillOrder";
            this.Text = "Orden De Molinos - Detalles";
            this.tbcMetalized.ResumeLayout(false);
            this.tbpCoil.ResumeLayout(false);
            this.grpbCoilWeigth.ResumeLayout(false);
            this.grpbCoilWeigth.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMetalized;
        private System.Windows.Forms.TabPage tbpCoil;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.GroupBox grpbCoilWeigth;
        private System.Windows.Forms.Button btnWeigth;
        private System.Windows.Forms.ComboBox cmbMill;
        private System.Windows.Forms.ComboBox cmbMilProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSequiential;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.TextBox txtgrossweigth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblMetalizedNetWeigth;
        private System.Windows.Forms.TextBox txtpallet;
    }
}