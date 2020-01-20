namespace BPS
{
    partial class frmEquivalenceMontana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquivalenceMontana));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFilmBopp = new System.Windows.Forms.Label();
            this.lblFilmOpp = new System.Windows.Forms.Label();
            this.cmbBopp = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cmbOpp = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.cmbOpp);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.cmbBopp);
            this.groupBox1.Controls.Add(this.lblFilmOpp);
            this.groupBox1.Controls.Add(this.lblFilmBopp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignación de Películas";
            // 
            // lblFilmBopp
            // 
            this.lblFilmBopp.AutoSize = true;
            this.lblFilmBopp.Location = new System.Drawing.Point(41, 26);
            this.lblFilmBopp.Name = "lblFilmBopp";
            this.lblFilmBopp.Size = new System.Drawing.Size(89, 15);
            this.lblFilmBopp.TabIndex = 0;
            this.lblFilmBopp.Text = "Películas Bopp";
            // 
            // lblFilmOpp
            // 
            this.lblFilmOpp.AutoSize = true;
            this.lblFilmOpp.Location = new System.Drawing.Point(47, 59);
            this.lblFilmOpp.Name = "lblFilmOpp";
            this.lblFilmOpp.Size = new System.Drawing.Size(83, 15);
            this.lblFilmOpp.TabIndex = 1;
            this.lblFilmOpp.Text = "Películas Opp";
            // 
            // cmbBopp
            // 
            this.cmbBopp.FormattingEnabled = true;
            this.cmbBopp.Location = new System.Drawing.Point(136, 23);
            this.cmbBopp.Name = "cmbBopp";
            this.cmbBopp.Size = new System.Drawing.Size(223, 23);
            this.cmbBopp.TabIndex = 2;
            this.cmbBopp.SelectedIndexChanged += new System.EventHandler(this.cmbBopp_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(136, 85);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(223, 52);
            this.txtNotes.TabIndex = 3;
            // 
            // cmbOpp
            // 
            this.cmbOpp.FormattingEnabled = true;
            this.cmbOpp.Location = new System.Drawing.Point(136, 56);
            this.cmbOpp.Name = "cmbOpp";
            this.cmbOpp.Size = new System.Drawing.Size(223, 23);
            this.cmbOpp.TabIndex = 4;
            this.cmbOpp.SelectedIndexChanged += new System.EventHandler(this.cmbOpp_SelectedIndexChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 88);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(124, 15);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Descripción Montana";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(334, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEquivalenceMontana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(364, 173);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquivalenceMontana";
            this.Text = "Equivalencia de Películas en Monatana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbOpp;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbBopp;
        private System.Windows.Forms.Label lblFilmOpp;
        private System.Windows.Forms.Label lblFilmBopp;
        private System.Windows.Forms.Button btnSave;
    }
}