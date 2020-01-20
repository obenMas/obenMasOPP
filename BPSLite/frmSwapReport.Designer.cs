namespace BPS.Lite
{
    partial class frmSwapReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwapReport));
            this.dateTPFromSwap = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateSwapRp = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToSwap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.dgvSwapInterplant = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkBobina = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clmSwapCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlantaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapInterplant)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTPFromSwap
            // 
            this.dateTPFromSwap.Location = new System.Drawing.Point(6, 15);
            this.dateTPFromSwap.Name = "dateTPFromSwap";
            this.dateTPFromSwap.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromSwap.TabIndex = 0;
            // 
            // btnGenerateSwapRp
            // 
            this.btnGenerateSwapRp.Location = new System.Drawing.Point(183, 18);
            this.btnGenerateSwapRp.Name = "btnGenerateSwapRp";
            this.btnGenerateSwapRp.Size = new System.Drawing.Size(128, 52);
            this.btnGenerateSwapRp.TabIndex = 2;
            this.btnGenerateSwapRp.Text = "Generar";
            this.btnGenerateSwapRp.UseVisualStyleBackColor = true;
            this.btnGenerateSwapRp.Click += new System.EventHandler(this.btnGenerateCuttingRp_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Desde:";
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(6, 19);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(215, 26);
            this.groupBoxFrom.TabIndex = 5;
            this.groupBoxFrom.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTPFromSwap);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(238, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 26);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(3, 7);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(53, 16);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Hasta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToSwap);
            this.groupBox3.Location = new System.Drawing.Point(238, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToSwap
            // 
            this.dateTPToSwap.Location = new System.Drawing.Point(6, 15);
            this.dateTPToSwap.Name = "dateTPToSwap";
            this.dateTPToSwap.Size = new System.Drawing.Size(200, 20);
            this.dateTPToSwap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Planta:";
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(30, 61);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(103, 21);
            this.cmbPlant.TabIndex = 10;
            // 
            // dgvSwapInterplant
            // 
            this.dgvSwapInterplant.AllowUserToAddRows = false;
            this.dgvSwapInterplant.AllowUserToDeleteRows = false;
            this.dgvSwapInterplant.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSwapInterplant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwapInterplant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwapCodsec,
            this.clmCodigo,
            this.Pelicula,
            this.Ancho,
            this.Diametro,
            this.Core,
            this.clmTipoMov,
            this.clmPeso,
            this.clmUser,
            this.clmOrigen,
            this.clmDestino,
            this.clmPlantaOrigen,
            this.clmDate,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour,
            this.clmCoilType});
            this.dgvSwapInterplant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSwapInterplant.Location = new System.Drawing.Point(3, 16);
            this.dgvSwapInterplant.Name = "dgvSwapInterplant";
            this.dgvSwapInterplant.ReadOnly = true;
            this.dgvSwapInterplant.Size = new System.Drawing.Size(1153, 385);
            this.dgvSwapInterplant.TabIndex = 11;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(317, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 51);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Exportar";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnExport, "Exportar a Excel");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSwapInterplant);
            this.groupBox4.Location = new System.Drawing.Point(2, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1159, 404);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkBobina);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnGenerateSwapRp);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Controls.Add(this.cmbPlant);
            this.groupBox5.Location = new System.Drawing.Point(470, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(473, 100);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtrar por Planta";
            // 
            // chkBobina
            // 
            this.chkBobina.AutoSize = true;
            this.chkBobina.Location = new System.Drawing.Point(244, 75);
            this.chkBobina.Name = "chkBobina";
            this.chkBobina.Size = new System.Drawing.Size(118, 17);
            this.chkBobina.TabIndex = 13;
            this.chkBobina.Text = "Reporte por Bobina";
            this.chkBobina.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBoxFrom);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Location = new System.Drawing.Point(2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 100);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtrar por Fecha";
            // 
            // clmSwapCodsec
            // 
            this.clmSwapCodsec.HeaderText = "SwapCodsec";
            this.clmSwapCodsec.Name = "clmSwapCodsec";
            this.clmSwapCodsec.ReadOnly = true;
            this.clmSwapCodsec.Visible = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código Pallet/Bobina";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 130;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            this.Pelicula.Width = 60;
            // 
            // Ancho
            // 
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 50;
            // 
            // Diametro
            // 
            this.Diametro.HeaderText = "Diam.";
            this.Diametro.Name = "Diametro";
            this.Diametro.ReadOnly = true;
            this.Diametro.Width = 40;
            // 
            // Core
            // 
            this.Core.HeaderText = "Core";
            this.Core.Name = "Core";
            this.Core.ReadOnly = true;
            this.Core.Width = 40;
            // 
            // clmTipoMov
            // 
            this.clmTipoMov.HeaderText = "Tipo Movimiento";
            this.clmTipoMov.Name = "clmTipoMov";
            this.clmTipoMov.ReadOnly = true;
            this.clmTipoMov.Width = 180;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso Neto";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            this.clmPeso.Width = 60;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            this.clmUser.Width = 80;
            // 
            // clmOrigen
            // 
            this.clmOrigen.HeaderText = "Origen";
            this.clmOrigen.Name = "clmOrigen";
            this.clmOrigen.ReadOnly = true;
            this.clmOrigen.Width = 120;
            // 
            // clmDestino
            // 
            this.clmDestino.HeaderText = "Destino";
            this.clmDestino.Name = "clmDestino";
            this.clmDestino.ReadOnly = true;
            this.clmDestino.Width = 120;
            // 
            // clmPlantaOrigen
            // 
            this.clmPlantaOrigen.HeaderText = "PlantaOrigen";
            this.clmPlantaOrigen.Name = "clmPlantaOrigen";
            this.clmPlantaOrigen.ReadOnly = true;
            this.clmPlantaOrigen.Visible = false;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 120;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "Dia";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Visible = false;
            // 
            // clmCoilType
            // 
            this.clmCoilType.HeaderText = "Tipo bobina";
            this.clmCoilType.Name = "clmCoilType";
            this.clmCoilType.ReadOnly = true;
            // 
            // frmSwapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 505);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSwapReport";
            this.Text = "Reporte de Swap Interplanta";
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapInterplant)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTPFromSwap;
        private System.Windows.Forms.Button btnGenerateSwapRp;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToSwap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.DataGridView dgvSwapInterplant;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwapCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlantaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilType;
    }
}