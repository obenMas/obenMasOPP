namespace BPS
{
    partial class frmBLDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBLDetail));
            this.dgvBLDetail = new System.Windows.Forms.DataGridView();
            this.grbBLDetail = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOCCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSolicitedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepotQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantitySecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProgramationPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeliveryPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeliveredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePlanning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePlanningDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePlanningMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePlanningYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDeliveryDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDeliveryMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDeliveryYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReventa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLDetail)).BeginInit();
            this.grbBLDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBLDetail
            // 
            this.dgvBLDetail.AllowUserToAddRows = false;
            this.dgvBLDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvBLDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBLDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrder,
            this.clmCustommer,
            this.clmOCCliente,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmSolicitedQuantity,
            this.clmDepotQuantity,
            this.clmQuantitySecond,
            this.clmQuantityDelivered,
            this.clmProgramationPending,
            this.clmCuttingPending,
            this.clmDeliveryPending,
            this.clmDateIn,
            this.clmDayIng,
            this.clmMonthIng,
            this.clmYearIng,
            this.clmDeliveredDate,
            this.clmDayEnt,
            this.clmMonthEnt,
            this.clmYearEnt,
            this.clmDatePlanning,
            this.clmDatePlanningDay,
            this.clmDatePlanningMonth,
            this.clmDatePlanningYear,
            this.clmDateDelivery,
            this.clmDateDeliveryDay,
            this.clmDateDeliveryMonth,
            this.clmDateDeliveryYear,
            this.clmObservacion,
            this.clmReventa,
            this.clmAprobado});
            this.dgvBLDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBLDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvBLDetail.Name = "dgvBLDetail";
            this.dgvBLDetail.Size = new System.Drawing.Size(1100, 401);
            this.dgvBLDetail.TabIndex = 0;
            // 
            // grbBLDetail
            // 
            this.grbBLDetail.Controls.Add(this.dgvBLDetail);
            this.grbBLDetail.Location = new System.Drawing.Point(2, -3);
            this.grbBLDetail.Name = "grbBLDetail";
            this.grbBLDetail.Size = new System.Drawing.Size(1106, 420);
            this.grbBLDetail.TabIndex = 1;
            this.grbBLDetail.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(1057, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(47, 40);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(11, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 0;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.Width = 60;
            // 
            // clmCustommer
            // 
            this.clmCustommer.HeaderText = "Cliente";
            this.clmCustommer.Name = "clmCustommer";
            this.clmCustommer.Width = 190;
            // 
            // clmOCCliente
            // 
            this.clmOCCliente.HeaderText = "OC Cliente";
            this.clmOCCliente.Name = "clmOCCliente";
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.Width = 70;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.Width = 50;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diam.";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.Width = 50;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.Width = 50;
            // 
            // clmSolicitedQuantity
            // 
            this.clmSolicitedQuantity.HeaderText = "Cant. Solicitada";
            this.clmSolicitedQuantity.Name = "clmSolicitedQuantity";
            this.clmSolicitedQuantity.Width = 70;
            // 
            // clmDepotQuantity
            // 
            this.clmDepotQuantity.HeaderText = "Cant. Depósito";
            this.clmDepotQuantity.Name = "clmDepotQuantity";
            this.clmDepotQuantity.Width = 70;
            // 
            // clmQuantitySecond
            // 
            this.clmQuantitySecond.HeaderText = "Cant. Segundas";
            this.clmQuantitySecond.Name = "clmQuantitySecond";
            this.clmQuantitySecond.Width = 70;
            // 
            // clmQuantityDelivered
            // 
            this.clmQuantityDelivered.HeaderText = "Cant. Entregada";
            this.clmQuantityDelivered.Name = "clmQuantityDelivered";
            this.clmQuantityDelivered.Width = 70;
            // 
            // clmProgramationPending
            // 
            this.clmProgramationPending.HeaderText = "Pend. Programación";
            this.clmProgramationPending.Name = "clmProgramationPending";
            this.clmProgramationPending.Width = 80;
            // 
            // clmCuttingPending
            // 
            this.clmCuttingPending.HeaderText = "Pend. Corte";
            this.clmCuttingPending.Name = "clmCuttingPending";
            this.clmCuttingPending.Width = 80;
            // 
            // clmDeliveryPending
            // 
            this.clmDeliveryPending.HeaderText = "Pend. Entrega";
            this.clmDeliveryPending.Name = "clmDeliveryPending";
            this.clmDeliveryPending.Width = 80;
            // 
            // clmDateIn
            // 
            this.clmDateIn.HeaderText = "Fecha Ingreso";
            this.clmDateIn.Name = "clmDateIn";
            this.clmDateIn.Width = 80;
            // 
            // clmDayIng
            // 
            this.clmDayIng.HeaderText = "Dia Ingreso";
            this.clmDayIng.Name = "clmDayIng";
            this.clmDayIng.Visible = false;
            // 
            // clmMonthIng
            // 
            this.clmMonthIng.HeaderText = "Mes Ingreso";
            this.clmMonthIng.Name = "clmMonthIng";
            this.clmMonthIng.Visible = false;
            // 
            // clmYearIng
            // 
            this.clmYearIng.HeaderText = "Año Ingreso";
            this.clmYearIng.Name = "clmYearIng";
            this.clmYearIng.Visible = false;
            // 
            // clmDeliveredDate
            // 
            this.clmDeliveredDate.HeaderText = "Fecha Solicitada";
            this.clmDeliveredDate.Name = "clmDeliveredDate";
            this.clmDeliveredDate.Width = 70;
            // 
            // clmDayEnt
            // 
            this.clmDayEnt.HeaderText = "Dia Solicitada";
            this.clmDayEnt.Name = "clmDayEnt";
            this.clmDayEnt.Visible = false;
            // 
            // clmMonthEnt
            // 
            this.clmMonthEnt.HeaderText = "Mes Solicitada";
            this.clmMonthEnt.Name = "clmMonthEnt";
            this.clmMonthEnt.Visible = false;
            // 
            // clmYearEnt
            // 
            this.clmYearEnt.HeaderText = "Año Solicitada";
            this.clmYearEnt.Name = "clmYearEnt";
            this.clmYearEnt.Visible = false;
            // 
            // clmDatePlanning
            // 
            this.clmDatePlanning.HeaderText = "Fecha Planning";
            this.clmDatePlanning.Name = "clmDatePlanning";
            // 
            // clmDatePlanningDay
            // 
            this.clmDatePlanningDay.HeaderText = "Día Planning";
            this.clmDatePlanningDay.Name = "clmDatePlanningDay";
            this.clmDatePlanningDay.Visible = false;
            // 
            // clmDatePlanningMonth
            // 
            this.clmDatePlanningMonth.HeaderText = "Mes Planning";
            this.clmDatePlanningMonth.Name = "clmDatePlanningMonth";
            this.clmDatePlanningMonth.Visible = false;
            // 
            // clmDatePlanningYear
            // 
            this.clmDatePlanningYear.HeaderText = "Año Planning";
            this.clmDatePlanningYear.Name = "clmDatePlanningYear";
            this.clmDatePlanningYear.Visible = false;
            // 
            // clmDateDelivery
            // 
            this.clmDateDelivery.HeaderText = "Fecha Entrega";
            this.clmDateDelivery.Name = "clmDateDelivery";
            // 
            // clmDateDeliveryDay
            // 
            this.clmDateDeliveryDay.HeaderText = "Dia Entrega";
            this.clmDateDeliveryDay.Name = "clmDateDeliveryDay";
            this.clmDateDeliveryDay.Visible = false;
            // 
            // clmDateDeliveryMonth
            // 
            this.clmDateDeliveryMonth.HeaderText = "Mes Entrega";
            this.clmDateDeliveryMonth.Name = "clmDateDeliveryMonth";
            this.clmDateDeliveryMonth.Visible = false;
            // 
            // clmDateDeliveryYear
            // 
            this.clmDateDeliveryYear.HeaderText = "Año Entrega";
            this.clmDateDeliveryYear.Name = "clmDateDeliveryYear";
            this.clmDateDeliveryYear.Visible = false;
            // 
            // clmObservacion
            // 
            this.clmObservacion.HeaderText = "Observaciones";
            this.clmObservacion.Name = "clmObservacion";
            // 
            // clmReventa
            // 
            this.clmReventa.HeaderText = "Es reventa";
            this.clmReventa.Name = "clmReventa";
            // 
            // clmAprobado
            // 
            this.clmAprobado.HeaderText = "Aprobado";
            this.clmAprobado.Name = "clmAprobado";
            // 
            // frmBLDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBLDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBLDetail";
            this.Text = "Detalle de BL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLDetail)).EndInit();
            this.grbBLDetail.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBLDetail;
        private System.Windows.Forms.GroupBox grbBLDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOCCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSolicitedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepotQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantitySecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProgramationPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeliveryPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeliveredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePlanning;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePlanningDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePlanningMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePlanningYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDeliveryDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDeliveryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDeliveryYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmReventa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAprobado;
    }
}