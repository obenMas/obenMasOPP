namespace BPS
{
    partial class frmCastFormulationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCastFormulationDetails));
            this.tbcCastFormulation = new System.Windows.Forms.TabControl();
            this.tbpFormulation = new System.Windows.Forms.TabPage();
            this.grpbFormulationC2 = new System.Windows.Forms.GroupBox();
            this.lblFormulationC2Percentage = new System.Windows.Forms.Label();
            this.lblC2Percentage = new System.Windows.Forms.Label();
            this.lblFormulationC2Thickness = new System.Windows.Forms.Label();
            this.lblFormulationCastC2Thickness = new System.Windows.Forms.Label();
            this.dgvC2 = new System.Windows.Forms.DataGridView();
            this.clmC2Codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2RawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2RawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFormulationCentralLayer = new System.Windows.Forms.GroupBox();
            this.lblFormulationCentralLayerPercentage = new System.Windows.Forms.Label();
            this.lblCentralLayerPercentage = new System.Windows.Forms.Label();
            this.lblFormulationCentralLayerThickness = new System.Windows.Forms.Label();
            this.lblFormulationCastCentralLayerThickness = new System.Windows.Forms.Label();
            this.dgvCentralLayer = new System.Windows.Forms.DataGridView();
            this.clmCentralLayerCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFormulationC1 = new System.Windows.Forms.GroupBox();
            this.lblFormulationC1Percentage = new System.Windows.Forms.Label();
            this.lblFormulationC1Thickness = new System.Windows.Forms.Label();
            this.lblC1Percentage = new System.Windows.Forms.Label();
            this.lblFormulationCastC1Thickness = new System.Windows.Forms.Label();
            this.dgvC1 = new System.Windows.Forms.DataGridView();
            this.clmC1Codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1RawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1RawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFormulationCastInfo = new System.Windows.Forms.GroupBox();
            this.lblCastFormulationDescription = new System.Windows.Forms.Label();
            this.lblCastFormulationThick = new System.Windows.Forms.Label();
            this.lblCastFormulationName = new System.Windows.Forms.Label();
            this.lblCastFormulationCode = new System.Windows.Forms.Label();
            this.lblFormulationCastFilm = new System.Windows.Forms.Label();
            this.lblFormulationCastDescription = new System.Windows.Forms.Label();
            this.lblFormulationCastName = new System.Windows.Forms.Label();
            this.lblFormulationCastThickness = new System.Windows.Forms.Label();
            this.tbpRawMaterialPrediction = new System.Windows.Forms.TabPage();
            this.grpbPredictorRawMaterial = new System.Windows.Forms.GroupBox();
            this.btnFormulationPredictor = new System.Windows.Forms.Button();
            this.txtFormulationPredictorPercentage = new System.Windows.Forms.TextBox();
            this.lblFormulationPredictorPercentage = new System.Windows.Forms.Label();
            this.txtFormulationPredictorQuantity = new System.Windows.Forms.TextBox();
            this.lblFormulationPredictorQuantity = new System.Windows.Forms.Label();
            this.grpbPredictorResultRawMaterial = new System.Windows.Forms.GroupBox();
            this.dgvFormulationPredictor = new System.Windows.Forms.DataGridView();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationTheoryPrediction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationPrediction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnCastFormulationExit = new System.Windows.Forms.Button();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.ttpDetailFormulationCast = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCastFormulation.SuspendLayout();
            this.tbpFormulation.SuspendLayout();
            this.grpbFormulationC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC2)).BeginInit();
            this.grpbFormulationCentralLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentralLayer)).BeginInit();
            this.grpbFormulationC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC1)).BeginInit();
            this.grpbFormulationCastInfo.SuspendLayout();
            this.tbpRawMaterialPrediction.SuspendLayout();
            this.grpbPredictorRawMaterial.SuspendLayout();
            this.grpbPredictorResultRawMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationPredictor)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCastFormulation
            // 
            this.tbcCastFormulation.Controls.Add(this.tbpFormulation);
            this.tbcCastFormulation.Controls.Add(this.tbpRawMaterialPrediction);
            this.tbcCastFormulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcCastFormulation.Location = new System.Drawing.Point(0, 0);
            this.tbcCastFormulation.Name = "tbcCastFormulation";
            this.tbcCastFormulation.SelectedIndex = 0;
            this.tbcCastFormulation.Size = new System.Drawing.Size(784, 333);
            this.tbcCastFormulation.TabIndex = 0;
            // 
            // tbpFormulation
            // 
            this.tbpFormulation.Controls.Add(this.grpbFormulationC2);
            this.tbpFormulation.Controls.Add(this.grpbFormulationCentralLayer);
            this.tbpFormulation.Controls.Add(this.grpbFormulationC1);
            this.tbpFormulation.Controls.Add(this.grpbFormulationCastInfo);
            this.tbpFormulation.Location = new System.Drawing.Point(4, 24);
            this.tbpFormulation.Name = "tbpFormulation";
            this.tbpFormulation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormulation.Size = new System.Drawing.Size(776, 305);
            this.tbpFormulation.TabIndex = 0;
            this.tbpFormulation.Text = "Formulación";
            this.tbpFormulation.UseVisualStyleBackColor = true;
            // 
            // grpbFormulationC2
            // 
            this.grpbFormulationC2.Controls.Add(this.lblFormulationC2Percentage);
            this.grpbFormulationC2.Controls.Add(this.lblC2Percentage);
            this.grpbFormulationC2.Controls.Add(this.lblFormulationC2Thickness);
            this.grpbFormulationC2.Controls.Add(this.lblFormulationCastC2Thickness);
            this.grpbFormulationC2.Controls.Add(this.dgvC2);
            this.grpbFormulationC2.Location = new System.Drawing.Point(519, 140);
            this.grpbFormulationC2.Name = "grpbFormulationC2";
            this.grpbFormulationC2.Size = new System.Drawing.Size(260, 157);
            this.grpbFormulationC2.TabIndex = 19;
            this.grpbFormulationC2.TabStop = false;
            this.grpbFormulationC2.Text = "Co-Extrusor 2";
            // 
            // lblFormulationC2Percentage
            // 
            this.lblFormulationC2Percentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationC2Percentage.Location = new System.Drawing.Point(176, 132);
            this.lblFormulationC2Percentage.Name = "lblFormulationC2Percentage";
            this.lblFormulationC2Percentage.Size = new System.Drawing.Size(41, 18);
            this.lblFormulationC2Percentage.TabIndex = 9;
            // 
            // lblC2Percentage
            // 
            this.lblC2Percentage.AutoSize = true;
            this.lblC2Percentage.Location = new System.Drawing.Point(223, 135);
            this.lblC2Percentage.Name = "lblC2Percentage";
            this.lblC2Percentage.Size = new System.Drawing.Size(18, 15);
            this.lblC2Percentage.TabIndex = 7;
            this.lblC2Percentage.Text = "%";
            // 
            // lblFormulationC2Thickness
            // 
            this.lblFormulationC2Thickness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationC2Thickness.Location = new System.Drawing.Point(77, 132);
            this.lblFormulationC2Thickness.Name = "lblFormulationC2Thickness";
            this.lblFormulationC2Thickness.Size = new System.Drawing.Size(93, 20);
            this.lblFormulationC2Thickness.TabIndex = 8;
            // 
            // lblFormulationCastC2Thickness
            // 
            this.lblFormulationCastC2Thickness.AutoSize = true;
            this.lblFormulationCastC2Thickness.Location = new System.Drawing.Point(19, 135);
            this.lblFormulationCastC2Thickness.Name = "lblFormulationCastC2Thickness";
            this.lblFormulationCastC2Thickness.Size = new System.Drawing.Size(52, 15);
            this.lblFormulationCastC2Thickness.TabIndex = 1;
            this.lblFormulationCastC2Thickness.Text = "Espesor";
            // 
            // dgvC2
            // 
            this.dgvC2.AllowUserToAddRows = false;
            this.dgvC2.AllowUserToDeleteRows = false;
            this.dgvC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmC2Codsec,
            this.clmC2RawMaterial,
            this.clmC2RawMaterialCodsec,
            this.clmC2Percentage});
            this.dgvC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvC2.Location = new System.Drawing.Point(3, 16);
            this.dgvC2.Name = "dgvC2";
            this.dgvC2.ReadOnly = true;
            this.dgvC2.Size = new System.Drawing.Size(254, 110);
            this.dgvC2.TabIndex = 0;
            // 
            // clmC2Codsec
            // 
            this.clmC2Codsec.HeaderText = "Codsec";
            this.clmC2Codsec.Name = "clmC2Codsec";
            this.clmC2Codsec.ReadOnly = true;
            this.clmC2Codsec.Visible = false;
            // 
            // clmC2RawMaterial
            // 
            this.clmC2RawMaterial.HeaderText = "Materia Prima";
            this.clmC2RawMaterial.Name = "clmC2RawMaterial";
            this.clmC2RawMaterial.ReadOnly = true;
            this.clmC2RawMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmC2RawMaterial.Width = 140;
            // 
            // clmC2RawMaterialCodsec
            // 
            this.clmC2RawMaterialCodsec.HeaderText = "codsec materia prima";
            this.clmC2RawMaterialCodsec.Name = "clmC2RawMaterialCodsec";
            this.clmC2RawMaterialCodsec.ReadOnly = true;
            this.clmC2RawMaterialCodsec.Visible = false;
            // 
            // clmC2Percentage
            // 
            this.clmC2Percentage.HeaderText = "%";
            this.clmC2Percentage.Name = "clmC2Percentage";
            this.clmC2Percentage.ReadOnly = true;
            this.clmC2Percentage.Width = 60;
            // 
            // grpbFormulationCentralLayer
            // 
            this.grpbFormulationCentralLayer.Controls.Add(this.lblFormulationCentralLayerPercentage);
            this.grpbFormulationCentralLayer.Controls.Add(this.lblCentralLayerPercentage);
            this.grpbFormulationCentralLayer.Controls.Add(this.lblFormulationCentralLayerThickness);
            this.grpbFormulationCentralLayer.Controls.Add(this.lblFormulationCastCentralLayerThickness);
            this.grpbFormulationCentralLayer.Controls.Add(this.dgvCentralLayer);
            this.grpbFormulationCentralLayer.Location = new System.Drawing.Point(258, 140);
            this.grpbFormulationCentralLayer.Name = "grpbFormulationCentralLayer";
            this.grpbFormulationCentralLayer.Size = new System.Drawing.Size(260, 157);
            this.grpbFormulationCentralLayer.TabIndex = 20;
            this.grpbFormulationCentralLayer.TabStop = false;
            this.grpbFormulationCentralLayer.Text = "Capa Central";
            // 
            // lblFormulationCentralLayerPercentage
            // 
            this.lblFormulationCentralLayerPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationCentralLayerPercentage.Location = new System.Drawing.Point(176, 132);
            this.lblFormulationCentralLayerPercentage.Name = "lblFormulationCentralLayerPercentage";
            this.lblFormulationCentralLayerPercentage.Size = new System.Drawing.Size(41, 18);
            this.lblFormulationCentralLayerPercentage.TabIndex = 7;
            // 
            // lblCentralLayerPercentage
            // 
            this.lblCentralLayerPercentage.AutoSize = true;
            this.lblCentralLayerPercentage.Location = new System.Drawing.Point(223, 135);
            this.lblCentralLayerPercentage.Name = "lblCentralLayerPercentage";
            this.lblCentralLayerPercentage.Size = new System.Drawing.Size(18, 15);
            this.lblCentralLayerPercentage.TabIndex = 5;
            this.lblCentralLayerPercentage.Text = "%";
            // 
            // lblFormulationCentralLayerThickness
            // 
            this.lblFormulationCentralLayerThickness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationCentralLayerThickness.Location = new System.Drawing.Point(77, 132);
            this.lblFormulationCentralLayerThickness.Name = "lblFormulationCentralLayerThickness";
            this.lblFormulationCentralLayerThickness.Size = new System.Drawing.Size(93, 20);
            this.lblFormulationCentralLayerThickness.TabIndex = 6;
            // 
            // lblFormulationCastCentralLayerThickness
            // 
            this.lblFormulationCastCentralLayerThickness.AutoSize = true;
            this.lblFormulationCastCentralLayerThickness.Location = new System.Drawing.Point(19, 135);
            this.lblFormulationCastCentralLayerThickness.Name = "lblFormulationCastCentralLayerThickness";
            this.lblFormulationCastCentralLayerThickness.Size = new System.Drawing.Size(52, 15);
            this.lblFormulationCastCentralLayerThickness.TabIndex = 1;
            this.lblFormulationCastCentralLayerThickness.Text = "Espesor";
            // 
            // dgvCentralLayer
            // 
            this.dgvCentralLayer.AllowUserToAddRows = false;
            this.dgvCentralLayer.AllowUserToDeleteRows = false;
            this.dgvCentralLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentralLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCentralLayerCodsec,
            this.clmCentralLayerRawMaterial,
            this.clmCentralLayerRawMaterialCodsec,
            this.clmCentralLayerPercentage});
            this.dgvCentralLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCentralLayer.Location = new System.Drawing.Point(3, 16);
            this.dgvCentralLayer.Name = "dgvCentralLayer";
            this.dgvCentralLayer.ReadOnly = true;
            this.dgvCentralLayer.Size = new System.Drawing.Size(254, 110);
            this.dgvCentralLayer.TabIndex = 0;
            // 
            // clmCentralLayerCodsec
            // 
            this.clmCentralLayerCodsec.HeaderText = "Codsec";
            this.clmCentralLayerCodsec.Name = "clmCentralLayerCodsec";
            this.clmCentralLayerCodsec.ReadOnly = true;
            this.clmCentralLayerCodsec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCentralLayerCodsec.Visible = false;
            // 
            // clmCentralLayerRawMaterial
            // 
            this.clmCentralLayerRawMaterial.HeaderText = "Materia Prima";
            this.clmCentralLayerRawMaterial.Name = "clmCentralLayerRawMaterial";
            this.clmCentralLayerRawMaterial.ReadOnly = true;
            this.clmCentralLayerRawMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCentralLayerRawMaterial.Width = 140;
            // 
            // clmCentralLayerRawMaterialCodsec
            // 
            this.clmCentralLayerRawMaterialCodsec.HeaderText = "codsec materia prima";
            this.clmCentralLayerRawMaterialCodsec.Name = "clmCentralLayerRawMaterialCodsec";
            this.clmCentralLayerRawMaterialCodsec.ReadOnly = true;
            this.clmCentralLayerRawMaterialCodsec.Visible = false;
            // 
            // clmCentralLayerPercentage
            // 
            this.clmCentralLayerPercentage.HeaderText = "%";
            this.clmCentralLayerPercentage.Name = "clmCentralLayerPercentage";
            this.clmCentralLayerPercentage.ReadOnly = true;
            this.clmCentralLayerPercentage.Width = 60;
            // 
            // grpbFormulationC1
            // 
            this.grpbFormulationC1.Controls.Add(this.lblFormulationC1Percentage);
            this.grpbFormulationC1.Controls.Add(this.lblFormulationC1Thickness);
            this.grpbFormulationC1.Controls.Add(this.lblC1Percentage);
            this.grpbFormulationC1.Controls.Add(this.lblFormulationCastC1Thickness);
            this.grpbFormulationC1.Controls.Add(this.dgvC1);
            this.grpbFormulationC1.Location = new System.Drawing.Point(-3, 140);
            this.grpbFormulationC1.Name = "grpbFormulationC1";
            this.grpbFormulationC1.Size = new System.Drawing.Size(260, 157);
            this.grpbFormulationC1.TabIndex = 18;
            this.grpbFormulationC1.TabStop = false;
            this.grpbFormulationC1.Text = "Co-Extrusor 1";
            // 
            // lblFormulationC1Percentage
            // 
            this.lblFormulationC1Percentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationC1Percentage.Location = new System.Drawing.Point(176, 132);
            this.lblFormulationC1Percentage.Name = "lblFormulationC1Percentage";
            this.lblFormulationC1Percentage.Size = new System.Drawing.Size(41, 18);
            this.lblFormulationC1Percentage.TabIndex = 5;
            // 
            // lblFormulationC1Thickness
            // 
            this.lblFormulationC1Thickness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulationC1Thickness.Location = new System.Drawing.Point(77, 132);
            this.lblFormulationC1Thickness.Name = "lblFormulationC1Thickness";
            this.lblFormulationC1Thickness.Size = new System.Drawing.Size(93, 20);
            this.lblFormulationC1Thickness.TabIndex = 4;
            // 
            // lblC1Percentage
            // 
            this.lblC1Percentage.AutoSize = true;
            this.lblC1Percentage.Location = new System.Drawing.Point(223, 135);
            this.lblC1Percentage.Name = "lblC1Percentage";
            this.lblC1Percentage.Size = new System.Drawing.Size(18, 15);
            this.lblC1Percentage.TabIndex = 3;
            this.lblC1Percentage.Text = "%";
            // 
            // lblFormulationCastC1Thickness
            // 
            this.lblFormulationCastC1Thickness.AutoSize = true;
            this.lblFormulationCastC1Thickness.Location = new System.Drawing.Point(19, 135);
            this.lblFormulationCastC1Thickness.Name = "lblFormulationCastC1Thickness";
            this.lblFormulationCastC1Thickness.Size = new System.Drawing.Size(52, 15);
            this.lblFormulationCastC1Thickness.TabIndex = 1;
            this.lblFormulationCastC1Thickness.Text = "Espesor";
            // 
            // dgvC1
            // 
            this.dgvC1.AllowUserToAddRows = false;
            this.dgvC1.AllowUserToDeleteRows = false;
            this.dgvC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmC1Codsec,
            this.clmC1RawMaterial,
            this.clmC1RawMaterialCodsec,
            this.clmC1Percentage});
            this.dgvC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvC1.Location = new System.Drawing.Point(3, 16);
            this.dgvC1.Name = "dgvC1";
            this.dgvC1.ReadOnly = true;
            this.dgvC1.Size = new System.Drawing.Size(254, 110);
            this.dgvC1.TabIndex = 0;
            // 
            // clmC1Codsec
            // 
            this.clmC1Codsec.HeaderText = "Codsec";
            this.clmC1Codsec.Name = "clmC1Codsec";
            this.clmC1Codsec.ReadOnly = true;
            this.clmC1Codsec.Visible = false;
            // 
            // clmC1RawMaterial
            // 
            this.clmC1RawMaterial.HeaderText = "Materia Prima";
            this.clmC1RawMaterial.Name = "clmC1RawMaterial";
            this.clmC1RawMaterial.ReadOnly = true;
            this.clmC1RawMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmC1RawMaterial.Width = 140;
            // 
            // clmC1RawMaterialCodsec
            // 
            this.clmC1RawMaterialCodsec.HeaderText = "codsec Materia Prima";
            this.clmC1RawMaterialCodsec.Name = "clmC1RawMaterialCodsec";
            this.clmC1RawMaterialCodsec.ReadOnly = true;
            this.clmC1RawMaterialCodsec.Visible = false;
            // 
            // clmC1Percentage
            // 
            this.clmC1Percentage.HeaderText = "%";
            this.clmC1Percentage.Name = "clmC1Percentage";
            this.clmC1Percentage.ReadOnly = true;
            this.clmC1Percentage.Width = 60;
            // 
            // grpbFormulationCastInfo
            // 
            this.grpbFormulationCastInfo.Controls.Add(this.lblCastFormulationDescription);
            this.grpbFormulationCastInfo.Controls.Add(this.lblCastFormulationThick);
            this.grpbFormulationCastInfo.Controls.Add(this.lblCastFormulationName);
            this.grpbFormulationCastInfo.Controls.Add(this.lblCastFormulationCode);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastFilm);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastDescription);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastName);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastThickness);
            this.grpbFormulationCastInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFormulationCastInfo.Location = new System.Drawing.Point(3, 3);
            this.grpbFormulationCastInfo.Name = "grpbFormulationCastInfo";
            this.grpbFormulationCastInfo.Size = new System.Drawing.Size(770, 130);
            this.grpbFormulationCastInfo.TabIndex = 17;
            this.grpbFormulationCastInfo.TabStop = false;
            this.grpbFormulationCastInfo.Text = "Datos Generales";
            // 
            // lblCastFormulationDescription
            // 
            this.lblCastFormulationDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastFormulationDescription.Location = new System.Drawing.Point(240, 72);
            this.lblCastFormulationDescription.Name = "lblCastFormulationDescription";
            this.lblCastFormulationDescription.Size = new System.Drawing.Size(391, 45);
            this.lblCastFormulationDescription.TabIndex = 10;
            // 
            // lblCastFormulationThick
            // 
            this.lblCastFormulationThick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastFormulationThick.Location = new System.Drawing.Point(538, 47);
            this.lblCastFormulationThick.Name = "lblCastFormulationThick";
            this.lblCastFormulationThick.Size = new System.Drawing.Size(93, 17);
            this.lblCastFormulationThick.TabIndex = 9;
            // 
            // lblCastFormulationName
            // 
            this.lblCastFormulationName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastFormulationName.Location = new System.Drawing.Point(240, 46);
            this.lblCastFormulationName.Name = "lblCastFormulationName";
            this.lblCastFormulationName.Size = new System.Drawing.Size(231, 21);
            this.lblCastFormulationName.TabIndex = 8;
            // 
            // lblCastFormulationCode
            // 
            this.lblCastFormulationCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastFormulationCode.Location = new System.Drawing.Point(240, 19);
            this.lblCastFormulationCode.Name = "lblCastFormulationCode";
            this.lblCastFormulationCode.Size = new System.Drawing.Size(231, 21);
            this.lblCastFormulationCode.TabIndex = 7;
            // 
            // lblFormulationCastFilm
            // 
            this.lblFormulationCastFilm.AutoSize = true;
            this.lblFormulationCastFilm.Location = new System.Drawing.Point(154, 19);
            this.lblFormulationCastFilm.Name = "lblFormulationCastFilm";
            this.lblFormulationCastFilm.Size = new System.Drawing.Size(83, 15);
            this.lblFormulationCastFilm.TabIndex = 6;
            this.lblFormulationCastFilm.Text = "Película Cast";
            // 
            // lblFormulationCastDescription
            // 
            this.lblFormulationCastDescription.AutoSize = true;
            this.lblFormulationCastDescription.Location = new System.Drawing.Point(154, 72);
            this.lblFormulationCastDescription.Name = "lblFormulationCastDescription";
            this.lblFormulationCastDescription.Size = new System.Drawing.Size(72, 15);
            this.lblFormulationCastDescription.TabIndex = 5;
            this.lblFormulationCastDescription.Text = "Descripción";
            // 
            // lblFormulationCastName
            // 
            this.lblFormulationCastName.AutoSize = true;
            this.lblFormulationCastName.Location = new System.Drawing.Point(154, 46);
            this.lblFormulationCastName.Name = "lblFormulationCastName";
            this.lblFormulationCastName.Size = new System.Drawing.Size(52, 15);
            this.lblFormulationCastName.TabIndex = 3;
            this.lblFormulationCastName.Text = "Nombre";
            // 
            // lblFormulationCastThickness
            // 
            this.lblFormulationCastThickness.AutoSize = true;
            this.lblFormulationCastThickness.Location = new System.Drawing.Point(474, 46);
            this.lblFormulationCastThickness.Name = "lblFormulationCastThickness";
            this.lblFormulationCastThickness.Size = new System.Drawing.Size(52, 15);
            this.lblFormulationCastThickness.TabIndex = 2;
            this.lblFormulationCastThickness.Text = "Espesor";
            // 
            // tbpRawMaterialPrediction
            // 
            this.tbpRawMaterialPrediction.Controls.Add(this.grpbPredictorRawMaterial);
            this.tbpRawMaterialPrediction.Location = new System.Drawing.Point(4, 24);
            this.tbpRawMaterialPrediction.Name = "tbpRawMaterialPrediction";
            this.tbpRawMaterialPrediction.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRawMaterialPrediction.Size = new System.Drawing.Size(776, 305);
            this.tbpRawMaterialPrediction.TabIndex = 1;
            this.tbpRawMaterialPrediction.Text = "Calculadora de Consumo Materia Prima";
            this.tbpRawMaterialPrediction.UseVisualStyleBackColor = true;
            // 
            // grpbPredictorRawMaterial
            // 
            this.grpbPredictorRawMaterial.Controls.Add(this.btnFormulationPredictor);
            this.grpbPredictorRawMaterial.Controls.Add(this.txtFormulationPredictorPercentage);
            this.grpbPredictorRawMaterial.Controls.Add(this.lblFormulationPredictorPercentage);
            this.grpbPredictorRawMaterial.Controls.Add(this.txtFormulationPredictorQuantity);
            this.grpbPredictorRawMaterial.Controls.Add(this.lblFormulationPredictorQuantity);
            this.grpbPredictorRawMaterial.Controls.Add(this.grpbPredictorResultRawMaterial);
            this.grpbPredictorRawMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPredictorRawMaterial.Location = new System.Drawing.Point(3, 3);
            this.grpbPredictorRawMaterial.Name = "grpbPredictorRawMaterial";
            this.grpbPredictorRawMaterial.Size = new System.Drawing.Size(770, 286);
            this.grpbPredictorRawMaterial.TabIndex = 25;
            this.grpbPredictorRawMaterial.TabStop = false;
            // 
            // btnFormulationPredictor
            // 
            this.btnFormulationPredictor.Location = new System.Drawing.Point(593, 30);
            this.btnFormulationPredictor.Name = "btnFormulationPredictor";
            this.btnFormulationPredictor.Size = new System.Drawing.Size(75, 23);
            this.btnFormulationPredictor.TabIndex = 5;
            this.btnFormulationPredictor.Text = "Calcular Consumo Materia Prima";
            this.ttpDetailFormulationCast.SetToolTip(this.btnFormulationPredictor, "Calcular Extrusión");
            this.btnFormulationPredictor.UseVisualStyleBackColor = true;
            this.btnFormulationPredictor.Click += new System.EventHandler(this.btnFormulationPredictor_Click);
            // 
            // txtFormulationPredictorPercentage
            // 
            this.txtFormulationPredictorPercentage.Location = new System.Drawing.Point(466, 31);
            this.txtFormulationPredictorPercentage.Name = "txtFormulationPredictorPercentage";
            this.txtFormulationPredictorPercentage.Size = new System.Drawing.Size(100, 21);
            this.txtFormulationPredictorPercentage.TabIndex = 4;
            // 
            // lblFormulationPredictorPercentage
            // 
            this.lblFormulationPredictorPercentage.AutoSize = true;
            this.lblFormulationPredictorPercentage.Location = new System.Drawing.Point(344, 34);
            this.lblFormulationPredictorPercentage.Name = "lblFormulationPredictorPercentage";
            this.lblFormulationPredictorPercentage.Size = new System.Drawing.Size(107, 15);
            this.lblFormulationPredictorPercentage.TabIndex = 3;
            this.lblFormulationPredictorPercentage.Text = "Cantidad a Extruir ";
            // 
            // txtFormulationPredictorQuantity
            // 
            this.txtFormulationPredictorQuantity.Location = new System.Drawing.Point(224, 31);
            this.txtFormulationPredictorQuantity.Name = "txtFormulationPredictorQuantity";
            this.txtFormulationPredictorQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtFormulationPredictorQuantity.TabIndex = 2;
            // 
            // lblFormulationPredictorQuantity
            // 
            this.lblFormulationPredictorQuantity.AutoSize = true;
            this.lblFormulationPredictorQuantity.Location = new System.Drawing.Point(102, 34);
            this.lblFormulationPredictorQuantity.Name = "lblFormulationPredictorQuantity";
            this.lblFormulationPredictorQuantity.Size = new System.Drawing.Size(107, 15);
            this.lblFormulationPredictorQuantity.TabIndex = 1;
            this.lblFormulationPredictorQuantity.Text = "Cantidad a Extruir ";
            // 
            // grpbPredictorResultRawMaterial
            // 
            this.grpbPredictorResultRawMaterial.Controls.Add(this.dgvFormulationPredictor);
            this.grpbPredictorResultRawMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbPredictorResultRawMaterial.Location = new System.Drawing.Point(3, 70);
            this.grpbPredictorResultRawMaterial.Name = "grpbPredictorResultRawMaterial";
            this.grpbPredictorResultRawMaterial.Size = new System.Drawing.Size(764, 213);
            this.grpbPredictorResultRawMaterial.TabIndex = 0;
            this.grpbPredictorResultRawMaterial.TabStop = false;
            this.grpbPredictorResultRawMaterial.Text = "Cálculo";
            // 
            // dgvFormulationPredictor
            // 
            this.dgvFormulationPredictor.AllowUserToAddRows = false;
            this.dgvFormulationPredictor.AllowUserToDeleteRows = false;
            this.dgvFormulationPredictor.AllowUserToOrderColumns = true;
            this.dgvFormulationPredictor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulationPredictor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterial,
            this.clmFormulationPercentage,
            this.clmFormulationTheoryPrediction,
            this.clmFormulationPrediction});
            this.dgvFormulationPredictor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulationPredictor.Location = new System.Drawing.Point(3, 17);
            this.dgvFormulationPredictor.Name = "dgvFormulationPredictor";
            this.dgvFormulationPredictor.ReadOnly = true;
            this.dgvFormulationPredictor.Size = new System.Drawing.Size(758, 193);
            this.dgvFormulationPredictor.TabIndex = 0;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.ReadOnly = true;
            this.clmRawMaterial.Width = 150;
            // 
            // clmFormulationPercentage
            // 
            this.clmFormulationPercentage.HeaderText = "%";
            this.clmFormulationPercentage.Name = "clmFormulationPercentage";
            this.clmFormulationPercentage.ReadOnly = true;
            this.clmFormulationPercentage.Width = 80;
            // 
            // clmFormulationTheoryPrediction
            // 
            this.clmFormulationTheoryPrediction.HeaderText = "Consumo Teórico";
            this.clmFormulationTheoryPrediction.Name = "clmFormulationTheoryPrediction";
            this.clmFormulationTheoryPrediction.ReadOnly = true;
            this.clmFormulationTheoryPrediction.Width = 150;
            // 
            // clmFormulationPrediction
            // 
            this.clmFormulationPrediction.HeaderText = "Consumo + 2 %";
            this.clmFormulationPrediction.Name = "clmFormulationPrediction";
            this.clmFormulationPrediction.ReadOnly = true;
            this.clmFormulationPrediction.Width = 150;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnCastFormulationExit);
            this.grpbActions.Location = new System.Drawing.Point(745, 328);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(39, 43);
            this.grpbActions.TabIndex = 23;
            this.grpbActions.TabStop = false;
            // 
            // btnCastFormulationExit
            // 
            this.btnCastFormulationExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnCastFormulationExit.Location = new System.Drawing.Point(6, 13);
            this.btnCastFormulationExit.Name = "btnCastFormulationExit";
            this.btnCastFormulationExit.Size = new System.Drawing.Size(25, 25);
            this.btnCastFormulationExit.TabIndex = 32;
            this.ttpDetailFormulationCast.SetToolTip(this.btnCastFormulationExit, "Salir");
            this.btnCastFormulationExit.UseVisualStyleBackColor = true;
            this.btnCastFormulationExit.Click += new System.EventHandler(this.btnCastFormulationExit_Click);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(1, 328);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(742, 43);
            this.grpbEmpty.TabIndex = 24;
            this.grpbEmpty.TabStop = false;
            // 
            // frmCastFormulationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 373);
            this.Controls.Add(this.tbcCastFormulation);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCastFormulationDetails";
            this.Text = "Detalle Formulación Cast";
            this.Load += new System.EventHandler(this.frmCastFormulationDetails_Load);
            this.tbcCastFormulation.ResumeLayout(false);
            this.tbpFormulation.ResumeLayout(false);
            this.grpbFormulationC2.ResumeLayout(false);
            this.grpbFormulationC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC2)).EndInit();
            this.grpbFormulationCentralLayer.ResumeLayout(false);
            this.grpbFormulationCentralLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentralLayer)).EndInit();
            this.grpbFormulationC1.ResumeLayout(false);
            this.grpbFormulationC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC1)).EndInit();
            this.grpbFormulationCastInfo.ResumeLayout(false);
            this.grpbFormulationCastInfo.PerformLayout();
            this.tbpRawMaterialPrediction.ResumeLayout(false);
            this.grpbPredictorRawMaterial.ResumeLayout(false);
            this.grpbPredictorRawMaterial.PerformLayout();
            this.grpbPredictorResultRawMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationPredictor)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCastFormulation;
        private System.Windows.Forms.TabPage tbpRawMaterialPrediction;
        private System.Windows.Forms.TabPage tbpFormulation;
        private System.Windows.Forms.GroupBox grpbFormulationC2;
        private System.Windows.Forms.Label lblC2Percentage;
        private System.Windows.Forms.Label lblFormulationCastC2Thickness;
        private System.Windows.Forms.DataGridView dgvC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2Codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2RawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2RawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2Percentage;
        private System.Windows.Forms.GroupBox grpbFormulationCentralLayer;
        private System.Windows.Forms.Label lblCentralLayerPercentage;
        private System.Windows.Forms.Label lblFormulationCastCentralLayerThickness;
        private System.Windows.Forms.DataGridView dgvCentralLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerPercentage;
        private System.Windows.Forms.GroupBox grpbFormulationC1;
        private System.Windows.Forms.Label lblC1Percentage;
        private System.Windows.Forms.Label lblFormulationCastC1Thickness;
        private System.Windows.Forms.DataGridView dgvC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1Codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1RawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1RawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1Percentage;
        private System.Windows.Forms.GroupBox grpbFormulationCastInfo;
        private System.Windows.Forms.Label lblCastFormulationName;
        private System.Windows.Forms.Label lblCastFormulationCode;
        private System.Windows.Forms.Label lblFormulationCastFilm;
        private System.Windows.Forms.Label lblFormulationCastDescription;
        private System.Windows.Forms.Label lblFormulationCastName;
        private System.Windows.Forms.Label lblFormulationCastThickness;
        private System.Windows.Forms.Label lblCastFormulationThick;
        private System.Windows.Forms.Label lblCastFormulationDescription;
        private System.Windows.Forms.Label lblFormulationC2Percentage;
        private System.Windows.Forms.Label lblFormulationC2Thickness;
        private System.Windows.Forms.Label lblFormulationCentralLayerPercentage;
        private System.Windows.Forms.Label lblFormulationCentralLayerThickness;
        private System.Windows.Forms.Label lblFormulationC1Percentage;
        private System.Windows.Forms.Label lblFormulationC1Thickness;
        private System.Windows.Forms.GroupBox grpbPredictorResultRawMaterial;
        private System.Windows.Forms.DataGridView dgvFormulationPredictor;
        private System.Windows.Forms.GroupBox grpbPredictorRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationTheoryPrediction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationPrediction;
        private System.Windows.Forms.Label lblFormulationPredictorQuantity;
        private System.Windows.Forms.TextBox txtFormulationPredictorQuantity;
        private System.Windows.Forms.TextBox txtFormulationPredictorPercentage;
        private System.Windows.Forms.Label lblFormulationPredictorPercentage;
        private System.Windows.Forms.Button btnFormulationPredictor;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnCastFormulationExit;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.ToolTip ttpDetailFormulationCast;
    }
}