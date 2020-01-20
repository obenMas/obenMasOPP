namespace BPS.Lite
{
    partial class frmChangeMetalLotNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeMetalLotNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotNew = new System.Windows.Forms.TextBox();
            this.lblLotOld = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeigth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoil = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lote Actual";
            // 
            // txtLotNew
            // 
            this.txtLotNew.Enabled = false;
            this.txtLotNew.Location = new System.Drawing.Point(95, 38);
            this.txtLotNew.Name = "txtLotNew";
            this.txtLotNew.Size = new System.Drawing.Size(66, 21);
            this.txtLotNew.TabIndex = 1;
            // 
            // lblLotOld
            // 
            this.lblLotOld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLotOld.Location = new System.Drawing.Point(95, 9);
            this.lblLotOld.Name = "lblLotOld";
            this.lblLotOld.Size = new System.Drawing.Size(66, 19);
            this.lblLotOld.TabIndex = 2;
            this.lblLotOld.Text = "134091";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lote Cambio";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BPS.Lite.Properties.Resources.accept;
            this.btnOK.Location = new System.Drawing.Point(369, 88);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(25, 25);
            this.btnOK.TabIndex = 5;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peso";
            // 
            // txtWeigth
            // 
            this.txtWeigth.Location = new System.Drawing.Point(95, 65);
            this.txtWeigth.Name = "txtWeigth";
            this.txtWeigth.Size = new System.Drawing.Size(66, 21);
            this.txtWeigth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bobinas";
            // 
            // txtCoil
            // 
            this.txtCoil.Location = new System.Drawing.Point(95, 92);
            this.txtCoil.Name = "txtCoil";
            this.txtCoil.Size = new System.Drawing.Size(66, 21);
            this.txtCoil.TabIndex = 8;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(167, 9);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(227, 77);
            this.txtNotes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmChangeMetalLotNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(398, 118);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeigth);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLotOld);
            this.Controls.Add(this.txtLotNew);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeMetalLotNumber";
            this.Text = "Lote Metalizado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotNew;
        private System.Windows.Forms.Label lblLotOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeigth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoil;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
    }
}