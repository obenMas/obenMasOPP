namespace BPS.Lite
{
    partial class frmCustomizedMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomizedMessageBox));
            this.lblCerrar = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pctConfirm = new System.Windows.Forms.PictureBox();
            this.picError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.lblCerrar.ForeColor = System.Drawing.Color.Red;
            this.lblCerrar.Location = new System.Drawing.Point(298, 152);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(283, 16);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "Este mensaje se cerrara luego de 3 segundos";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(131, 9);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(450, 200);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMensaje.Size = new System.Drawing.Size(450, 48);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.UseMnemonic = false;
            // 
            // pctConfirm
            // 
            this.pctConfirm.Image = ((System.Drawing.Image)(resources.GetObject("pctConfirm.Image")));
            this.pctConfirm.Location = new System.Drawing.Point(19, 36);
            this.pctConfirm.MaximumSize = new System.Drawing.Size(150, 150);
            this.pctConfirm.Name = "pctConfirm";
            this.pctConfirm.Size = new System.Drawing.Size(100, 100);
            this.pctConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctConfirm.TabIndex = 2;
            this.pctConfirm.TabStop = false;
            // 
            // picError
            // 
            this.picError.Image = ((System.Drawing.Image)(resources.GetObject("picError.Image")));
            this.picError.Location = new System.Drawing.Point(19, 36);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(100, 100);
            this.picError.TabIndex = 3;
            this.picError.TabStop = false;
            // 
            // frmCustomizedMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 173);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.pctConfirm);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomizedMessageBox";
            this.Text = "Mensaje de Error";
            this.Shown += new System.EventHandler(this.frmCustomizedMessageBox_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pctConfirm;
        private System.Windows.Forms.PictureBox picError;
    }
}