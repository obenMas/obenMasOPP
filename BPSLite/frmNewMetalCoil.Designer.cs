namespace BPS.Lite
{
    partial class frmNewMetalCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMetalCoil));
            this.grpAddBase = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddBase = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodBob = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtCodigoBase = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBaseConsuption = new System.Windows.Forms.DataGridView();
            this.dgvCoilsToCharge = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodeBob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValidar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMetalizado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOrdenMet = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clmBobBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAddBase.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseConsuption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsToCharge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddBase
            // 
            this.grpAddBase.Controls.Add(this.groupBox5);
            this.grpAddBase.Controls.Add(this.label11);
            this.grpAddBase.Controls.Add(this.label1);
            this.grpAddBase.Controls.Add(this.lblCodBob);
            this.grpAddBase.Controls.Add(this.txtMetros);
            this.grpAddBase.Controls.Add(this.txtCodigoBase);
            this.grpAddBase.Controls.Add(this.groupBox4);
            this.grpAddBase.Location = new System.Drawing.Point(5, 104);
            this.grpAddBase.Name = "grpAddBase";
            this.grpAddBase.Size = new System.Drawing.Size(844, 131);
            this.grpAddBase.TabIndex = 0;
            this.grpAddBase.TabStop = false;
            this.grpAddBase.Text = "Datos Bobina";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddBase);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(372, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(76, 67);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnAddBase
            // 
            this.btnAddBase.Image = global::BPS.Lite.Properties.Resources.add1;
            this.btnAddBase.Location = new System.Drawing.Point(16, 21);
            this.btnAddBase.Name = "btnAddBase";
            this.btnAddBase.Size = new System.Drawing.Size(44, 37);
            this.btnAddBase.TabIndex = 5;
            this.btnAddBase.UseVisualStyleBackColor = true;
            this.btnAddBase.Click += new System.EventHandler(this.btnAddBase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Agregar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "mts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metros a Consumir";
            // 
            // lblCodBob
            // 
            this.lblCodBob.AutoSize = true;
            this.lblCodBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBob.Location = new System.Drawing.Point(29, 35);
            this.lblCodBob.Name = "lblCodBob";
            this.lblCodBob.Size = new System.Drawing.Size(87, 16);
            this.lblCodBob.TabIndex = 3;
            this.lblCodBob.Text = "Código Base";
            // 
            // txtMetros
            // 
            this.txtMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetros.Location = new System.Drawing.Point(172, 74);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(122, 22);
            this.txtMetros.TabIndex = 2;
            // 
            // txtCodigoBase
            // 
            this.txtCodigoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBase.Location = new System.Drawing.Point(172, 30);
            this.txtCodigoBase.Name = "txtCodigoBase";
            this.txtCodigoBase.Size = new System.Drawing.Size(254, 22);
            this.txtCodigoBase.TabIndex = 1;
            this.txtCodigoBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBase_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvBaseConsuption);
            this.groupBox4.Location = new System.Drawing.Point(454, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 108);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consumo de Bobina Base";
            // 
            // dgvBaseConsuption
            // 
            this.dgvBaseConsuption.AllowUserToAddRows = false;
            this.dgvBaseConsuption.AllowUserToDeleteRows = false;
            this.dgvBaseConsuption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBaseConsuption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseConsuption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBobBase,
            this.clmConsumo});
            this.dgvBaseConsuption.Location = new System.Drawing.Point(9, 16);
            this.dgvBaseConsuption.Name = "dgvBaseConsuption";
            this.dgvBaseConsuption.ReadOnly = true;
            this.dgvBaseConsuption.Size = new System.Drawing.Size(368, 86);
            this.dgvBaseConsuption.TabIndex = 0;
            // 
            // dgvCoilsToCharge
            // 
            this.dgvCoilsToCharge.AllowUserToAddRows = false;
            this.dgvCoilsToCharge.AllowUserToDeleteRows = false;
            this.dgvCoilsToCharge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCoilsToCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilsToCharge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodBase,
            this.clmCodeBob,
            this.clmNetWeigth,
            this.clmProducto,
            this.clmAncho,
            this.clmFilmInit,
            this.clmFilmFinal,
            this.clmValidar});
            this.dgvCoilsToCharge.Location = new System.Drawing.Point(6, 19);
            this.dgvCoilsToCharge.Name = "dgvCoilsToCharge";
            this.dgvCoilsToCharge.ReadOnly = true;
            this.dgvCoilsToCharge.Size = new System.Drawing.Size(833, 367);
            this.dgvCoilsToCharge.TabIndex = 0;
            this.dgvCoilsToCharge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoilsToCharge_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 68;
            // 
            // clmCodBase
            // 
            this.clmCodBase.HeaderText = "Código de Bobina Base";
            this.clmCodBase.Name = "clmCodBase";
            this.clmCodBase.ReadOnly = true;
            this.clmCodBase.Width = 109;
            // 
            // clmCodeBob
            // 
            this.clmCodeBob.HeaderText = "Código Bobina Metalizada";
            this.clmCodeBob.Name = "clmCodeBob";
            this.clmCodeBob.ReadOnly = true;
            this.clmCodeBob.Width = 141;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Bobina";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            this.clmNetWeigth.Width = 85;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            this.clmProducto.Width = 75;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 63;
            // 
            // clmFilmInit
            // 
            this.clmFilmInit.HeaderText = "Film Inicial";
            this.clmFilmInit.Name = "clmFilmInit";
            this.clmFilmInit.ReadOnly = true;
            this.clmFilmInit.Width = 74;
            // 
            // clmFilmFinal
            // 
            this.clmFilmFinal.HeaderText = "Film Final";
            this.clmFilmFinal.Name = "clmFilmFinal";
            this.clmFilmFinal.ReadOnly = true;
            this.clmFilmFinal.Width = 69;
            // 
            // clmValidar
            // 
            this.clmValidar.HeaderText = "Validar";
            this.clmValidar.Image = global::BPS.Lite.Properties.Resources.accept;
            this.clmValidar.Name = "clmValidar";
            this.clmValidar.ReadOnly = true;
            this.clmValidar.Width = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCoilsToCharge);
            this.groupBox2.Location = new System.Drawing.Point(5, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bobinas Metalizadas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblMetalizado);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblOrdenMet);
            this.groupBox3.Controls.Add(this.lblEstado);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnPlayStop);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Orden";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(387, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "18M29291";
            // 
            // lblMetalizado
            // 
            this.lblMetalizado.AutoSize = true;
            this.lblMetalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalizado.Location = new System.Drawing.Point(387, 26);
            this.lblMetalizado.Name = "lblMetalizado";
            this.lblMetalizado.Size = new System.Drawing.Size(47, 16);
            this.lblMetalizado.TabIndex = 15;
            this.lblMetalizado.Text = "ML020";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "BL020";
            // 
            // lblOrdenMet
            // 
            this.lblOrdenMet.AutoSize = true;
            this.lblOrdenMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenMet.Location = new System.Drawing.Point(157, 63);
            this.lblOrdenMet.Name = "lblOrdenMet";
            this.lblOrdenMet.Size = new System.Drawing.Size(29, 16);
            this.lblOrdenMet.TabIndex = 13;
            this.lblOrdenMet.Text = "001";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(553, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 16);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Proceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Image = global::BPS.Lite.Properties.Resources.Pause_Hot;
            this.btnPlayStop.Location = new System.Drawing.Point(650, 19);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(75, 57);
            this.btnPlayStop.TabIndex = 9;
            this.btnPlayStop.Text = "Play";
            this.btnPlayStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.Location = new System.Drawing.Point(731, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 57);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto Metalizado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "N° de Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto Base";
            // 
            // clmBobBase
            // 
            this.clmBobBase.HeaderText = "Código Base";
            this.clmBobBase.Name = "clmBobBase";
            this.clmBobBase.ReadOnly = true;
            this.clmBobBase.Width = 92;
            // 
            // clmConsumo
            // 
            this.clmConsumo.HeaderText = "Consumo [mts]";
            this.clmConsumo.Name = "clmConsumo";
            this.clmConsumo.ReadOnly = true;
            this.clmConsumo.Width = 101;
            // 
            // frmNewMetalCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 637);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAddBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewMetalCoil";
            this.Text = "Metalizador";
            this.Load += new System.EventHandler(this.frmNewMetalCoil_Load);
            this.grpAddBase.ResumeLayout(false);
            this.grpAddBase.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseConsuption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsToCharge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddBase;
        private System.Windows.Forms.DataGridView dgvCoilsToCharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodBob;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtCodigoBase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvBaseConsuption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMetalizado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOrdenMet;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodeBob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmFinal;
        private System.Windows.Forms.DataGridViewImageColumn clmValidar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBobBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConsumo;
    }
}