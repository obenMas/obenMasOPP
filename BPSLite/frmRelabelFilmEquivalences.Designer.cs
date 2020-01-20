namespace BPS.Lite
{
    partial class frmRelabelFilmEquivalences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelabelFilmEquivalences));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbNylon = new System.Windows.Forms.RadioButton();
            this.rbCoating = new System.Windows.Forms.RadioButton();
            this.rbCast = new System.Windows.Forms.RadioButton();
            this.rbBOPP = new System.Windows.Forms.RadioButton();
            this.btnGuardarPallet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEquiv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbCoatingCoil = new System.Windows.Forms.RadioButton();
            this.rbCastCoil = new System.Windows.Forms.RadioButton();
            this.rbBOPPCoil = new System.Windows.Forms.RadioButton();
            this.btnProcesarBobina = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCoilEquivalence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnGuardarPallet);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pallets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbNylon);
            this.groupBox5.Controls.Add(this.rbCoating);
            this.groupBox5.Controls.Add(this.rbCast);
            this.groupBox5.Controls.Add(this.rbBOPP);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 65);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de Producto";
            // 
            // rbNylon
            // 
            this.rbNylon.AutoSize = true;
            this.rbNylon.Location = new System.Drawing.Point(313, 28);
            this.rbNylon.Name = "rbNylon";
            this.rbNylon.Size = new System.Drawing.Size(93, 17);
            this.rbNylon.TabIndex = 3;
            this.rbNylon.TabStop = true;
            this.rbNylon.Text = "PelÍcula Nylon";
            this.rbNylon.UseVisualStyleBackColor = true;
            // 
            // rbCoating
            // 
            this.rbCoating.AutoSize = true;
            this.rbCoating.Location = new System.Drawing.Point(205, 28);
            this.rbCoating.Name = "rbCoating";
            this.rbCoating.Size = new System.Drawing.Size(102, 17);
            this.rbCoating.TabIndex = 2;
            this.rbCoating.TabStop = true;
            this.rbCoating.Text = "PelÍcula Coating";
            this.rbCoating.UseVisualStyleBackColor = true;
            // 
            // rbCast
            // 
            this.rbCast.AutoSize = true;
            this.rbCast.Location = new System.Drawing.Point(112, 28);
            this.rbCast.Name = "rbCast";
            this.rbCast.Size = new System.Drawing.Size(87, 17);
            this.rbCast.TabIndex = 1;
            this.rbCast.TabStop = true;
            this.rbCast.Text = "PelÍcula Cast";
            this.rbCast.UseVisualStyleBackColor = true;
            // 
            // rbBOPP
            // 
            this.rbBOPP.AutoSize = true;
            this.rbBOPP.Location = new System.Drawing.Point(12, 28);
            this.rbBOPP.Name = "rbBOPP";
            this.rbBOPP.Size = new System.Drawing.Size(95, 17);
            this.rbBOPP.TabIndex = 0;
            this.rbBOPP.TabStop = true;
            this.rbBOPP.Text = "PelÍcula BOPP";
            this.rbBOPP.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPallet
            // 
            this.btnGuardarPallet.Image = global::BPS.Lite.Properties.Resources.disk;
            this.btnGuardarPallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPallet.Location = new System.Drawing.Point(359, 240);
            this.btnGuardarPallet.Name = "btnGuardarPallet";
            this.btnGuardarPallet.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPallet.TabIndex = 5;
            this.btnGuardarPallet.Text = "      Guardar";
            this.btnGuardarPallet.UseVisualStyleBackColor = true;
            this.btnGuardarPallet.Click += new System.EventHandler(this.btnGuardarPallet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEquiv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Pallet";
            // 
            // cmbEquiv
            // 
            this.cmbEquiv.FormattingEnabled = true;
            this.cmbEquiv.Location = new System.Drawing.Point(163, 36);
            this.cmbEquiv.Name = "cmbEquiv";
            this.cmbEquiv.Size = new System.Drawing.Size(185, 21);
            this.cmbEquiv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peliculas Equivalentes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de Pallet";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCode.Location = new System.Drawing.Point(163, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 26);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Pallet";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.btnProcesarBobina);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bobinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbCoatingCoil);
            this.groupBox6.Controls.Add(this.rbCastCoil);
            this.groupBox6.Controls.Add(this.rbBOPPCoil);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 65);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Producto";
            // 
            // rbCoatingCoil
            // 
            this.rbCoatingCoil.AutoSize = true;
            this.rbCoatingCoil.Location = new System.Drawing.Point(270, 28);
            this.rbCoatingCoil.Name = "rbCoatingCoil";
            this.rbCoatingCoil.Size = new System.Drawing.Size(102, 17);
            this.rbCoatingCoil.TabIndex = 2;
            this.rbCoatingCoil.TabStop = true;
            this.rbCoatingCoil.Text = "PelÍcula Coating";
            this.rbCoatingCoil.UseVisualStyleBackColor = true;
            // 
            // rbCastCoil
            // 
            this.rbCastCoil.AutoSize = true;
            this.rbCastCoil.Location = new System.Drawing.Point(155, 28);
            this.rbCastCoil.Name = "rbCastCoil";
            this.rbCastCoil.Size = new System.Drawing.Size(87, 17);
            this.rbCastCoil.TabIndex = 1;
            this.rbCastCoil.TabStop = true;
            this.rbCastCoil.Text = "PelÍcula Cast";
            this.rbCastCoil.UseVisualStyleBackColor = true;
            // 
            // rbBOPPCoil
            // 
            this.rbBOPPCoil.AutoSize = true;
            this.rbBOPPCoil.Location = new System.Drawing.Point(29, 28);
            this.rbBOPPCoil.Name = "rbBOPPCoil";
            this.rbBOPPCoil.Size = new System.Drawing.Size(95, 17);
            this.rbBOPPCoil.TabIndex = 0;
            this.rbBOPPCoil.TabStop = true;
            this.rbBOPPCoil.Text = "PelÍcula BOPP";
            this.rbBOPPCoil.UseVisualStyleBackColor = true;
            // 
            // btnProcesarBobina
            // 
            this.btnProcesarBobina.Image = global::BPS.Lite.Properties.Resources.disk;
            this.btnProcesarBobina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesarBobina.Location = new System.Drawing.Point(358, 240);
            this.btnProcesarBobina.Name = "btnProcesarBobina";
            this.btnProcesarBobina.Size = new System.Drawing.Size(75, 23);
            this.btnProcesarBobina.TabIndex = 1;
            this.btnProcesarBobina.Text = "      Guardar";
            this.btnProcesarBobina.UseVisualStyleBackColor = true;
            this.btnProcesarBobina.Click += new System.EventHandler(this.btnProcesarBobina_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCoilEquivalence);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(9, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 80);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de bobina";
            // 
            // cmbCoilEquivalence
            // 
            this.cmbCoilEquivalence.FormattingEnabled = true;
            this.cmbCoilEquivalence.Location = new System.Drawing.Point(169, 35);
            this.cmbCoilEquivalence.Name = "cmbCoilEquivalence";
            this.cmbCoilEquivalence.Size = new System.Drawing.Size(185, 21);
            this.cmbCoilEquivalence.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pelicula Equivalente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCoilCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Código de Bobina";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCoilCode.Location = new System.Drawing.Point(169, 24);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(185, 26);
            this.txtCoilCode.TabIndex = 1;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código de Bobina";
            // 
            // frmRelabelFilmEquivalences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 297);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelabelFilmEquivalences";
            this.Text = "Re-etiquetado de peliculas Equivalentes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbEquiv;
        private System.Windows.Forms.Button btnGuardarPallet;
        private System.Windows.Forms.Button btnProcesarBobina;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCoilEquivalence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbNylon;
        private System.Windows.Forms.RadioButton rbCoating;
        private System.Windows.Forms.RadioButton rbCast;
        private System.Windows.Forms.RadioButton rbBOPP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbCoatingCoil;
        private System.Windows.Forms.RadioButton rbCastCoil;
        private System.Windows.Forms.RadioButton rbBOPPCoil;
    }
}