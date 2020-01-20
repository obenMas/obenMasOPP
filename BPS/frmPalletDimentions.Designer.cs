namespace BPS
{
    partial class frmPalletDimentions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletDimentions));
            this.grpbDimensions = new System.Windows.Forms.GroupBox();
            this.btnAddDimension = new System.Windows.Forms.Button();
            this.lblResultDimensions = new System.Windows.Forms.Label();
            this.nmupdwDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.nmupdwWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.ttpDimentions = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupdwDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupdwWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbDimensions
            // 
            this.grpbDimensions.Controls.Add(this.btnAddDimension);
            this.grpbDimensions.Controls.Add(this.lblResultDimensions);
            this.grpbDimensions.Controls.Add(this.nmupdwDepth);
            this.grpbDimensions.Controls.Add(this.lblDepth);
            this.grpbDimensions.Controls.Add(this.nmupdwWidth);
            this.grpbDimensions.Controls.Add(this.lblWidth);
            this.grpbDimensions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDimensions.Location = new System.Drawing.Point(0, 0);
            this.grpbDimensions.Name = "grpbDimensions";
            this.grpbDimensions.Size = new System.Drawing.Size(256, 67);
            this.grpbDimensions.TabIndex = 0;
            this.grpbDimensions.TabStop = false;
            this.grpbDimensions.Text = "Dimensiones";
            // 
            // btnAddDimension
            // 
            this.btnAddDimension.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddDimension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDimension.Location = new System.Drawing.Point(229, 42);
            this.btnAddDimension.Name = "btnAddDimension";
            this.btnAddDimension.Size = new System.Drawing.Size(25, 25);
            this.btnAddDimension.TabIndex = 8;
            this.ttpDimentions.SetToolTip(this.btnAddDimension, "Agregar");
            this.btnAddDimension.UseVisualStyleBackColor = true;
            this.btnAddDimension.Click += new System.EventHandler(this.btnAddDimension_Click);
            // 
            // lblResultDimensions
            // 
            this.lblResultDimensions.AutoSize = true;
            this.lblResultDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDimensions.Location = new System.Drawing.Point(72, 42);
            this.lblResultDimensions.Name = "lblResultDimensions";
            this.lblResultDimensions.Size = new System.Drawing.Size(0, 18);
            this.lblResultDimensions.TabIndex = 4;
            // 
            // nmupdwDepth
            // 
            this.nmupdwDepth.Location = new System.Drawing.Point(194, 15);
            this.nmupdwDepth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmupdwDepth.Name = "nmupdwDepth";
            this.nmupdwDepth.Size = new System.Drawing.Size(50, 21);
            this.nmupdwDepth.TabIndex = 3;
            this.nmupdwDepth.ValueChanged += new System.EventHandler(this.nmupdwDepth_ValueChanged);
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(111, 17);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(77, 15);
            this.lblDepth.TabIndex = 2;
            this.lblDepth.Text = "Profundidad:";
            // 
            // nmupdwWidth
            // 
            this.nmupdwWidth.Location = new System.Drawing.Point(53, 15);
            this.nmupdwWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmupdwWidth.Name = "nmupdwWidth";
            this.nmupdwWidth.Size = new System.Drawing.Size(50, 21);
            this.nmupdwWidth.TabIndex = 1;
            this.nmupdwWidth.ValueChanged += new System.EventHandler(this.nmupdwWidth_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(3, 17);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 15);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Ancho:";
            // 
            // frmPalletDimentions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(256, 68);
            this.Controls.Add(this.grpbDimensions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletDimentions";
            this.Text = "Dimensiones";
            this.grpbDimensions.ResumeLayout(false);
            this.grpbDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupdwDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupdwWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDimensions;
        private System.Windows.Forms.NumericUpDown nmupdwDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.NumericUpDown nmupdwWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblResultDimensions;
        private System.Windows.Forms.Button btnAddDimension;
        private System.Windows.Forms.ToolTip ttpDimentions;
    }
}