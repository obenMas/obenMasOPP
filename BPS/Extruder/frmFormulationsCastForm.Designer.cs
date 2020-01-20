namespace BPS
{
    partial class frmFormulationsCastForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulationsCastForm));
            this.grpbFormulationCastInfo = new System.Windows.Forms.GroupBox();
            this.cmbCastFilm = new System.Windows.Forms.ComboBox();
            this.lblFormulationCastFilm = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFormulationCastDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFormulationCastName = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.lblFormulationCastThickness = new System.Windows.Forms.Label();
            this.grpbC1 = new System.Windows.Forms.GroupBox();
            this.lblC1Percentage = new System.Windows.Forms.Label();
            this.txtC1Percentage = new System.Windows.Forms.TextBox();
            this.txtC1Thickness = new System.Windows.Forms.TextBox();
            this.lblFormulationCastC1Thickness = new System.Windows.Forms.Label();
            this.dgvC1 = new System.Windows.Forms.DataGridView();
            this.clmC1Codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1RawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1RawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC1Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCentralLayer = new System.Windows.Forms.GroupBox();
            this.lblCentralLayerPercentage = new System.Windows.Forms.Label();
            this.txtCentralLayerPercentage = new System.Windows.Forms.TextBox();
            this.txtCentralLayerThickness = new System.Windows.Forms.TextBox();
            this.lblFormulationCastCentralLayerThickness = new System.Windows.Forms.Label();
            this.dgvCentralLayer = new System.Windows.Forms.DataGridView();
            this.clmCentralLayerCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralLayerPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbC2 = new System.Windows.Forms.GroupBox();
            this.lblC2Percentage = new System.Windows.Forms.Label();
            this.txtC2Percentage = new System.Windows.Forms.TextBox();
            this.txtC2Thickness = new System.Windows.Forms.TextBox();
            this.lblFormulationCastC2Thickness = new System.Windows.Forms.Label();
            this.dgvC2 = new System.Windows.Forms.DataGridView();
            this.clmC2Codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2RawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2RawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmC2Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttpFormulationCastActive = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFormulationCastInfo.SuspendLayout();
            this.grpbC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC1)).BeginInit();
            this.grpbCentralLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentralLayer)).BeginInit();
            this.grpbC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC2)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFormulationCastInfo
            // 
            this.grpbFormulationCastInfo.Controls.Add(this.cmbCastFilm);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastFilm);
            this.grpbFormulationCastInfo.Controls.Add(this.txtDescription);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastDescription);
            this.grpbFormulationCastInfo.Controls.Add(this.txtName);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastName);
            this.grpbFormulationCastInfo.Controls.Add(this.txtThickness);
            this.grpbFormulationCastInfo.Controls.Add(this.lblFormulationCastThickness);
            this.grpbFormulationCastInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFormulationCastInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbFormulationCastInfo.Name = "grpbFormulationCastInfo";
            this.grpbFormulationCastInfo.Size = new System.Drawing.Size(784, 130);
            this.grpbFormulationCastInfo.TabIndex = 0;
            this.grpbFormulationCastInfo.TabStop = false;
            this.grpbFormulationCastInfo.Text = "Datos Generales";
            // 
            // cmbCastFilm
            // 
            this.cmbCastFilm.FormattingEnabled = true;
            this.cmbCastFilm.Location = new System.Drawing.Point(240, 15);
            this.cmbCastFilm.Name = "cmbCastFilm";
            this.cmbCastFilm.Size = new System.Drawing.Size(391, 23);
            this.cmbCastFilm.TabIndex = 0;
            this.cmbCastFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCastFilm_KeyDown);
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(240, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(391, 48);
            this.txtDescription.TabIndex = 3;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 21);
            this.txtName.TabIndex = 1;
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
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(531, 43);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(100, 21);
            this.txtThickness.TabIndex = 2;
            this.txtThickness.Text = "0";
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // grpbC1
            // 
            this.grpbC1.Controls.Add(this.lblC1Percentage);
            this.grpbC1.Controls.Add(this.txtC1Percentage);
            this.grpbC1.Controls.Add(this.txtC1Thickness);
            this.grpbC1.Controls.Add(this.lblFormulationCastC1Thickness);
            this.grpbC1.Controls.Add(this.dgvC1);
            this.grpbC1.Location = new System.Drawing.Point(0, 130);
            this.grpbC1.Name = "grpbC1";
            this.grpbC1.Size = new System.Drawing.Size(260, 157);
            this.grpbC1.TabIndex = 1;
            this.grpbC1.TabStop = false;
            this.grpbC1.Text = "Co-Extrusor 1";
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
            // txtC1Percentage
            // 
            this.txtC1Percentage.Location = new System.Drawing.Point(176, 132);
            this.txtC1Percentage.Name = "txtC1Percentage";
            this.txtC1Percentage.Size = new System.Drawing.Size(46, 21);
            this.txtC1Percentage.TabIndex = 2;
            this.txtC1Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtC1Thickness
            // 
            this.txtC1Thickness.Location = new System.Drawing.Point(70, 132);
            this.txtC1Thickness.Name = "txtC1Thickness";
            this.txtC1Thickness.Size = new System.Drawing.Size(100, 21);
            this.txtC1Thickness.TabIndex = 1;
            this.txtC1Thickness.Text = "0";
            this.txtC1Thickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmC1Codsec,
            this.clmC1RawMaterial,
            this.clmC1RawMaterialCodsec,
            this.clmC1Percentage});
            this.dgvC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvC1.Location = new System.Drawing.Point(3, 16);
            this.dgvC1.Name = "dgvC1";
            this.dgvC1.Size = new System.Drawing.Size(254, 110);
            this.dgvC1.TabIndex = 0;
            this.dgvC1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulationCastC1_CellDoubleClick);
            this.dgvC1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvC1_CellValidating);
            this.dgvC1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvC1_CellValueChanged);
            this.dgvC1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvC1_DefaultValuesNeeded);
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
            this.clmC1Percentage.Width = 60;
            // 
            // grpbCentralLayer
            // 
            this.grpbCentralLayer.Controls.Add(this.lblCentralLayerPercentage);
            this.grpbCentralLayer.Controls.Add(this.txtCentralLayerPercentage);
            this.grpbCentralLayer.Controls.Add(this.txtCentralLayerThickness);
            this.grpbCentralLayer.Controls.Add(this.lblFormulationCastCentralLayerThickness);
            this.grpbCentralLayer.Controls.Add(this.dgvCentralLayer);
            this.grpbCentralLayer.Location = new System.Drawing.Point(261, 130);
            this.grpbCentralLayer.Name = "grpbCentralLayer";
            this.grpbCentralLayer.Size = new System.Drawing.Size(260, 157);
            this.grpbCentralLayer.TabIndex = 2;
            this.grpbCentralLayer.TabStop = false;
            this.grpbCentralLayer.Text = "Capa Central";
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
            // txtCentralLayerPercentage
            // 
            this.txtCentralLayerPercentage.Location = new System.Drawing.Point(176, 132);
            this.txtCentralLayerPercentage.Name = "txtCentralLayerPercentage";
            this.txtCentralLayerPercentage.Size = new System.Drawing.Size(46, 21);
            this.txtCentralLayerPercentage.TabIndex = 4;
            this.txtCentralLayerPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCentralLayerThickness
            // 
            this.txtCentralLayerThickness.Location = new System.Drawing.Point(70, 132);
            this.txtCentralLayerThickness.Name = "txtCentralLayerThickness";
            this.txtCentralLayerThickness.Size = new System.Drawing.Size(100, 21);
            this.txtCentralLayerThickness.TabIndex = 1;
            this.txtCentralLayerThickness.Text = "0";
            this.txtCentralLayerThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvCentralLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentralLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCentralLayerCodsec,
            this.clmCentralLayerRawMaterial,
            this.clmCentralLayerRawMaterialCodsec,
            this.clmCentralLayerPercentage});
            this.dgvCentralLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCentralLayer.Location = new System.Drawing.Point(3, 16);
            this.dgvCentralLayer.Name = "dgvCentralLayer";
            this.dgvCentralLayer.Size = new System.Drawing.Size(254, 110);
            this.dgvCentralLayer.TabIndex = 0;
            this.dgvCentralLayer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulationCastCentalLayer_CellDoubleClick);
            this.dgvCentralLayer.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCentalLayer_CellValidating);
            this.dgvCentralLayer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCentalLayer_CellValueChanged);
            this.dgvCentralLayer.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCentralLayer_DefaultValuesNeeded);
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
            this.clmCentralLayerPercentage.Width = 60;
            // 
            // grpbC2
            // 
            this.grpbC2.Controls.Add(this.lblC2Percentage);
            this.grpbC2.Controls.Add(this.txtC2Percentage);
            this.grpbC2.Controls.Add(this.txtC2Thickness);
            this.grpbC2.Controls.Add(this.lblFormulationCastC2Thickness);
            this.grpbC2.Controls.Add(this.dgvC2);
            this.grpbC2.Location = new System.Drawing.Point(522, 130);
            this.grpbC2.Name = "grpbC2";
            this.grpbC2.Size = new System.Drawing.Size(260, 157);
            this.grpbC2.TabIndex = 2;
            this.grpbC2.TabStop = false;
            this.grpbC2.Text = "Co-Extrusor 2";
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
            // txtC2Percentage
            // 
            this.txtC2Percentage.Location = new System.Drawing.Point(176, 132);
            this.txtC2Percentage.Name = "txtC2Percentage";
            this.txtC2Percentage.Size = new System.Drawing.Size(46, 21);
            this.txtC2Percentage.TabIndex = 6;
            this.txtC2Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtC2Thickness
            // 
            this.txtC2Thickness.Location = new System.Drawing.Point(70, 132);
            this.txtC2Thickness.Name = "txtC2Thickness";
            this.txtC2Thickness.Size = new System.Drawing.Size(100, 21);
            this.txtC2Thickness.TabIndex = 1;
            this.txtC2Thickness.Text = "0";
            this.txtC2Thickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmC2Codsec,
            this.clmC2RawMaterial,
            this.clmC2RawMaterialCodsec,
            this.clmC2Percentage});
            this.dgvC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvC2.Location = new System.Drawing.Point(3, 16);
            this.dgvC2.Name = "dgvC2";
            this.dgvC2.Size = new System.Drawing.Size(254, 110);
            this.dgvC2.TabIndex = 0;
            this.dgvC2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulationCastC2_CellDoubleClick);
            this.dgvC2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvC2_CellValidating);
            this.dgvC2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvC2_CellValueChanged);
            this.dgvC2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvC2_DefaultValuesNeeded);
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
            this.clmC2Percentage.Width = 60;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(3, 283);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(691, 43);
            this.grpbEmpty.TabIndex = 16;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(696, 283);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(83, 43);
            this.grpbActions.TabIndex = 15;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpFormulationCastActive.SetToolTip(this.btnExit, "Salir Formulaciones Cast");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 30;
            this.ttpFormulationCastActive.SetToolTip(this.btnSave, "Guardar Formulaciones Cast");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnFormulationCastSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(29, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 31;
            this.ttpFormulationCastActive.SetToolTip(this.btnCancel, "Cancelar Formulaciones Cast");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFormulationsCastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 329);
            this.Controls.Add(this.grpbC2);
            this.Controls.Add(this.grpbCentralLayer);
            this.Controls.Add(this.grpbC1);
            this.Controls.Add(this.grpbFormulationCastInfo);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormulationsCastForm";
            this.Text = "Formulaciones Cast";
            this.Load += new System.EventHandler(this.frmFormulationsCastForm_Load);
            this.grpbFormulationCastInfo.ResumeLayout(false);
            this.grpbFormulationCastInfo.PerformLayout();
            this.grpbC1.ResumeLayout(false);
            this.grpbC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC1)).EndInit();
            this.grpbCentralLayer.ResumeLayout(false);
            this.grpbCentralLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentralLayer)).EndInit();
            this.grpbC2.ResumeLayout(false);
            this.grpbC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC2)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFormulationCastInfo;
        private System.Windows.Forms.Label lblFormulationCastThickness;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.Label lblFormulationCastDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFormulationCastName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpbC1;
        private System.Windows.Forms.DataGridView dgvC1;
        private System.Windows.Forms.Label lblFormulationCastC1Thickness;
        private System.Windows.Forms.TextBox txtC1Thickness;
        private System.Windows.Forms.ComboBox cmbCastFilm;
        private System.Windows.Forms.Label lblFormulationCastFilm;
        private System.Windows.Forms.GroupBox grpbCentralLayer;
        private System.Windows.Forms.TextBox txtCentralLayerThickness;
        private System.Windows.Forms.Label lblFormulationCastCentralLayerThickness;
        private System.Windows.Forms.DataGridView dgvCentralLayer;
        private System.Windows.Forms.GroupBox grpbC2;
        private System.Windows.Forms.TextBox txtC2Thickness;
        private System.Windows.Forms.Label lblFormulationCastC2Thickness;
        private System.Windows.Forms.DataGridView dgvC2;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1Codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1RawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1RawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC1Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralLayerPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2Codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2RawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2RawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmC2Percentage;
        private System.Windows.Forms.Label lblC1Percentage;
        private System.Windows.Forms.TextBox txtC1Percentage;
        private System.Windows.Forms.Label lblCentralLayerPercentage;
        private System.Windows.Forms.TextBox txtCentralLayerPercentage;
        private System.Windows.Forms.Label lblC2Percentage;
        private System.Windows.Forms.TextBox txtC2Percentage;
        private System.Windows.Forms.ToolTip ttpFormulationCastActive;
    }
}