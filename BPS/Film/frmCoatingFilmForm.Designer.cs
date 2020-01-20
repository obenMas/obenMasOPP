namespace BPS
{
    partial class frmCoatingFilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoatingFilmForm));
            this.grpProcess = new System.Windows.Forms.GroupBox();
            this.cmbSubProcess = new System.Windows.Forms.ComboBox();
            this.lblSubProcess = new System.Windows.Forms.Label();
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.cmbCoatingStructure = new System.Windows.Forms.ComboBox();
            this.lblCoatingStructure = new System.Windows.Forms.Label();
            this.grpbTreatment = new System.Windows.Forms.GroupBox();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lstbSubstrateThickness = new System.Windows.Forms.ListBox();
            this.grpbFields = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbThickness = new System.Windows.Forms.GroupBox();
            this.lblCoatingThickness = new System.Windows.Forms.Label();
            this.lblSustrateThickness = new System.Windows.Forms.Label();
            this.lstbCoatingThikness = new System.Windows.Forms.ListBox();
            this.rdoMoreThickness = new System.Windows.Forms.RadioButton();
            this.rdoOneThickness = new System.Windows.Forms.RadioButton();
            this.grpbStructure = new System.Windows.Forms.GroupBox();
            this.cmbTerminationStructure = new System.Windows.Forms.ComboBox();
            this.lblTerminationStructure = new System.Windows.Forms.Label();
            this.lblTreatmentCode = new System.Windows.Forms.Label();
            this.lblCoatingThicknessCode = new System.Windows.Forms.Label();
            this.lblCoatingStructureCode = new System.Windows.Forms.Label();
            this.lblTerminationStructureCode = new System.Windows.Forms.Label();
            this.grpbCode = new System.Windows.Forms.GroupBox();
            this.lblSubstrateThicknessCode = new System.Windows.Forms.Label();
            this.lblSubProcessCode = new System.Windows.Forms.Label();
            this.lblProcessCode = new System.Windows.Forms.Label();
            this.lblBack1 = new System.Windows.Forms.Label();
            this.lblBack2 = new System.Windows.Forms.Label();
            this.lblBack4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ttpFilmCoating = new System.Windows.Forms.ToolTip(this.components);
            this.grpProcess.SuspendLayout();
            this.grpbTreatment.SuspendLayout();
            this.grpbFields.SuspendLayout();
            this.grpbThickness.SuspendLayout();
            this.grpbStructure.SuspendLayout();
            this.grpbCode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcess
            // 
            this.grpProcess.Controls.Add(this.cmbSubProcess);
            this.grpProcess.Controls.Add(this.lblSubProcess);
            this.grpProcess.Controls.Add(this.cmbProcess);
            this.grpProcess.Controls.Add(this.lblProcess);
            this.grpProcess.Location = new System.Drawing.Point(4, 10);
            this.grpProcess.Name = "grpProcess";
            this.grpProcess.Size = new System.Drawing.Size(486, 51);
            this.grpProcess.TabIndex = 0;
            this.grpProcess.TabStop = false;
            this.grpProcess.Text = "Proceso";
            // 
            // cmbSubProcess
            // 
            this.cmbSubProcess.FormattingEnabled = true;
            this.cmbSubProcess.Location = new System.Drawing.Point(339, 14);
            this.cmbSubProcess.Name = "cmbSubProcess";
            this.cmbSubProcess.Size = new System.Drawing.Size(121, 23);
            this.cmbSubProcess.TabIndex = 7;
            this.cmbSubProcess.SelectedIndexChanged += new System.EventHandler(this.cmbSubProcess_SelectedIndexChanged);
            this.cmbSubProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSubProcess_KeyDown);
            // 
            // lblSubProcess
            // 
            this.lblSubProcess.AutoSize = true;
            this.lblSubProcess.Location = new System.Drawing.Point(281, 17);
            this.lblSubProcess.Name = "lblSubProcess";
            this.lblSubProcess.Size = new System.Drawing.Size(52, 15);
            this.lblSubProcess.TabIndex = 6;
            this.lblSubProcess.Text = "Sustrato";
            // 
            // cmbProcess
            // 
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Location = new System.Drawing.Point(80, 14);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(121, 23);
            this.cmbProcess.TabIndex = 5;
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            this.cmbProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProcess_KeyDown);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(26, 17);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(52, 15);
            this.lblProcess.TabIndex = 4;
            this.lblProcess.Text = "Proceso";
            // 
            // cmbCoatingStructure
            // 
            this.cmbCoatingStructure.FormattingEnabled = true;
            this.cmbCoatingStructure.Location = new System.Drawing.Point(339, 14);
            this.cmbCoatingStructure.Name = "cmbCoatingStructure";
            this.cmbCoatingStructure.Size = new System.Drawing.Size(121, 23);
            this.cmbCoatingStructure.TabIndex = 7;
            this.cmbCoatingStructure.SelectedIndexChanged += new System.EventHandler(this.cmbCoatingStructure_SelectedIndexChanged);
            this.cmbCoatingStructure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCoatingStructure_KeyDown);
            // 
            // lblCoatingStructure
            // 
            this.lblCoatingStructure.AutoSize = true;
            this.lblCoatingStructure.Location = new System.Drawing.Point(245, 17);
            this.lblCoatingStructure.Name = "lblCoatingStructure";
            this.lblCoatingStructure.Size = new System.Drawing.Size(88, 15);
            this.lblCoatingStructure.TabIndex = 6;
            this.lblCoatingStructure.Text = "Recubrimiento";
            // 
            // grpbTreatment
            // 
            this.grpbTreatment.Controls.Add(this.cmbTreatment);
            this.grpbTreatment.Controls.Add(this.lblTreatment);
            this.grpbTreatment.Location = new System.Drawing.Point(4, 293);
            this.grpbTreatment.Name = "grpbTreatment";
            this.grpbTreatment.Size = new System.Drawing.Size(486, 51);
            this.grpbTreatment.TabIndex = 4;
            this.grpbTreatment.TabStop = false;
            this.grpbTreatment.Text = "Tratamiento";
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(230, 14);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(121, 23);
            this.cmbTreatment.TabIndex = 5;
            this.cmbTreatment.SelectedIndexChanged += new System.EventHandler(this.cmbTreatment_SelectedIndexChanged);
            this.cmbTreatment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTreatment_KeyDown);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(136, 17);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(88, 15);
            this.lblTreatment.TabIndex = 4;
            this.lblTreatment.Text = "Recubrimiento";
            // 
            // lstbSubstrateThickness
            // 
            this.lstbSubstrateThickness.FormattingEnabled = true;
            this.lstbSubstrateThickness.ItemHeight = 15;
            this.lstbSubstrateThickness.Location = new System.Drawing.Point(66, 69);
            this.lstbSubstrateThickness.Name = "lstbSubstrateThickness";
            this.lstbSubstrateThickness.Size = new System.Drawing.Size(148, 79);
            this.lstbSubstrateThickness.TabIndex = 2;
            this.lstbSubstrateThickness.SelectedIndexChanged += new System.EventHandler(this.lstbSubstrateThickness_SelectedIndexChanged);
            // 
            // grpbFields
            // 
            this.grpbFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbFields.Controls.Add(this.btnClear);
            this.grpbFields.Controls.Add(this.btnList);
            this.grpbFields.Controls.Add(this.btnExit);
            this.grpbFields.Controls.Add(this.btnSave);
            this.grpbFields.Controls.Add(this.btnCancel);
            this.grpbFields.Controls.Add(this.grpbTreatment);
            this.grpbFields.Controls.Add(this.grpbThickness);
            this.grpbFields.Controls.Add(this.grpbStructure);
            this.grpbFields.Controls.Add(this.grpProcess);
            this.grpbFields.Location = new System.Drawing.Point(0, 123);
            this.grpbFields.Name = "grpbFields";
            this.grpbFields.Size = new System.Drawing.Size(495, 381);
            this.grpbFields.TabIndex = 5;
            this.grpbFields.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::BPS.Properties.Resources.page;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Location = new System.Drawing.Point(415, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
            this.btnClear.TabIndex = 34;
            this.ttpFilmCoating.SetToolTip(this.btnClear, "Limpiar Pelicula Coating");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = global::BPS.Properties.Resources.script;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnList.Location = new System.Drawing.Point(440, 350);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(25, 25);
            this.btnList.TabIndex = 35;
            this.ttpFilmCoating.SetToolTip(this.btnList, "Listado Película Coating");
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(465, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 36;
            this.ttpFilmCoating.SetToolTip(this.btnExit, "Salir Película Coating");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(365, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 32;
            this.ttpFilmCoating.SetToolTip(this.btnSave, "Guardar Película Coating");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(390, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 33;
            this.ttpFilmCoating.SetToolTip(this.btnCancel, "Cancelar Película Coating");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbThickness
            // 
            this.grpbThickness.Controls.Add(this.lblCoatingThickness);
            this.grpbThickness.Controls.Add(this.lblSustrateThickness);
            this.grpbThickness.Controls.Add(this.lstbCoatingThikness);
            this.grpbThickness.Controls.Add(this.lstbSubstrateThickness);
            this.grpbThickness.Controls.Add(this.rdoMoreThickness);
            this.grpbThickness.Controls.Add(this.rdoOneThickness);
            this.grpbThickness.Location = new System.Drawing.Point(4, 124);
            this.grpbThickness.Name = "grpbThickness";
            this.grpbThickness.Size = new System.Drawing.Size(486, 163);
            this.grpbThickness.TabIndex = 3;
            this.grpbThickness.TabStop = false;
            this.grpbThickness.Text = "Espesor";
            // 
            // lblCoatingThickness
            // 
            this.lblCoatingThickness.AutoSize = true;
            this.lblCoatingThickness.Location = new System.Drawing.Point(302, 51);
            this.lblCoatingThickness.Name = "lblCoatingThickness";
            this.lblCoatingThickness.Size = new System.Drawing.Size(88, 15);
            this.lblCoatingThickness.TabIndex = 8;
            this.lblCoatingThickness.Text = "Recubrimiento";
            // 
            // lblSustrateThickness
            // 
            this.lblSustrateThickness.AutoSize = true;
            this.lblSustrateThickness.Location = new System.Drawing.Point(114, 51);
            this.lblSustrateThickness.Name = "lblSustrateThickness";
            this.lblSustrateThickness.Size = new System.Drawing.Size(52, 15);
            this.lblSustrateThickness.TabIndex = 7;
            this.lblSustrateThickness.Text = "Sustrato";
            // 
            // lstbCoatingThikness
            // 
            this.lstbCoatingThikness.FormattingEnabled = true;
            this.lstbCoatingThikness.ItemHeight = 15;
            this.lstbCoatingThikness.Location = new System.Drawing.Point(272, 69);
            this.lstbCoatingThikness.Name = "lstbCoatingThikness";
            this.lstbCoatingThikness.Size = new System.Drawing.Size(148, 79);
            this.lstbCoatingThikness.TabIndex = 3;
            this.lstbCoatingThikness.SelectedIndexChanged += new System.EventHandler(this.lstbCoatingThikness_SelectedIndexChanged);
            // 
            // rdoMoreThickness
            // 
            this.rdoMoreThickness.AutoSize = true;
            this.rdoMoreThickness.Location = new System.Drawing.Point(286, 15);
            this.rdoMoreThickness.Name = "rdoMoreThickness";
            this.rdoMoreThickness.Size = new System.Drawing.Size(106, 17);
            this.rdoMoreThickness.TabIndex = 1;
            this.rdoMoreThickness.TabStop = true;
            this.rdoMoreThickness.Text = "Varios Espesores";
            this.rdoMoreThickness.UseVisualStyleBackColor = true;
            // 
            // rdoOneThickness
            // 
            this.rdoOneThickness.AutoSize = true;
            this.rdoOneThickness.Location = new System.Drawing.Point(96, 15);
            this.rdoOneThickness.Name = "rdoOneThickness";
            this.rdoOneThickness.Size = new System.Drawing.Size(79, 17);
            this.rdoOneThickness.TabIndex = 0;
            this.rdoOneThickness.TabStop = true;
            this.rdoOneThickness.Text = "Un espesor";
            this.rdoOneThickness.UseVisualStyleBackColor = true;
            this.rdoOneThickness.CheckedChanged += new System.EventHandler(this.rdoOneThickness_CheckedChanged);
            // 
            // grpbStructure
            // 
            this.grpbStructure.Controls.Add(this.cmbCoatingStructure);
            this.grpbStructure.Controls.Add(this.lblCoatingStructure);
            this.grpbStructure.Controls.Add(this.cmbTerminationStructure);
            this.grpbStructure.Controls.Add(this.lblTerminationStructure);
            this.grpbStructure.Location = new System.Drawing.Point(4, 67);
            this.grpbStructure.Name = "grpbStructure";
            this.grpbStructure.Size = new System.Drawing.Size(486, 51);
            this.grpbStructure.TabIndex = 1;
            this.grpbStructure.TabStop = false;
            this.grpbStructure.Text = "Estructura";
            // 
            // cmbTerminationStructure
            // 
            this.cmbTerminationStructure.FormattingEnabled = true;
            this.cmbTerminationStructure.Location = new System.Drawing.Point(80, 14);
            this.cmbTerminationStructure.Name = "cmbTerminationStructure";
            this.cmbTerminationStructure.Size = new System.Drawing.Size(121, 23);
            this.cmbTerminationStructure.TabIndex = 5;
            this.cmbTerminationStructure.SelectedIndexChanged += new System.EventHandler(this.cmbTerminationStructure_SelectedIndexChanged);
            this.cmbTerminationStructure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTerminationStructure_KeyDown);
            // 
            // lblTerminationStructure
            // 
            this.lblTerminationStructure.AutoSize = true;
            this.lblTerminationStructure.Location = new System.Drawing.Point(26, 17);
            this.lblTerminationStructure.Name = "lblTerminationStructure";
            this.lblTerminationStructure.Size = new System.Drawing.Size(55, 15);
            this.lblTerminationStructure.TabIndex = 4;
            this.lblTerminationStructure.Text = "Acabado";
            // 
            // lblTreatmentCode
            // 
            this.lblTreatmentCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(118)))));
            this.lblTreatmentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTreatmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentCode.Location = new System.Drawing.Point(417, 21);
            this.lblTreatmentCode.Name = "lblTreatmentCode";
            this.lblTreatmentCode.Size = new System.Drawing.Size(40, 40);
            this.lblTreatmentCode.TabIndex = 7;
            this.lblTreatmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoatingThicknessCode
            // 
            this.lblCoatingThicknessCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoatingThicknessCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoatingThicknessCode.Location = new System.Drawing.Point(322, 21);
            this.lblCoatingThicknessCode.Name = "lblCoatingThicknessCode";
            this.lblCoatingThicknessCode.Size = new System.Drawing.Size(85, 40);
            this.lblCoatingThicknessCode.TabIndex = 6;
            this.lblCoatingThicknessCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoatingStructureCode
            // 
            this.lblCoatingStructureCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.lblCoatingStructureCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoatingStructureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoatingStructureCode.Location = new System.Drawing.Point(183, 21);
            this.lblCoatingStructureCode.Name = "lblCoatingStructureCode";
            this.lblCoatingStructureCode.Size = new System.Drawing.Size(40, 40);
            this.lblCoatingStructureCode.TabIndex = 3;
            this.lblCoatingStructureCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerminationStructureCode
            // 
            this.lblTerminationStructureCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.lblTerminationStructureCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerminationStructureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminationStructureCode.Location = new System.Drawing.Point(137, 20);
            this.lblTerminationStructureCode.Name = "lblTerminationStructureCode";
            this.lblTerminationStructureCode.Size = new System.Drawing.Size(40, 40);
            this.lblTerminationStructureCode.TabIndex = 2;
            this.lblTerminationStructureCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbCode
            // 
            this.grpbCode.BackColor = System.Drawing.SystemColors.Window;
            this.grpbCode.Controls.Add(this.lblSubstrateThicknessCode);
            this.grpbCode.Controls.Add(this.lblTreatmentCode);
            this.grpbCode.Controls.Add(this.lblCoatingThicknessCode);
            this.grpbCode.Controls.Add(this.lblCoatingStructureCode);
            this.grpbCode.Controls.Add(this.lblTerminationStructureCode);
            this.grpbCode.Controls.Add(this.lblSubProcessCode);
            this.grpbCode.Controls.Add(this.lblProcessCode);
            this.grpbCode.Controls.Add(this.lblBack1);
            this.grpbCode.Controls.Add(this.lblBack2);
            this.grpbCode.Controls.Add(this.lblBack4);
            this.grpbCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCode.Location = new System.Drawing.Point(0, 0);
            this.grpbCode.Name = "grpbCode";
            this.grpbCode.Size = new System.Drawing.Size(495, 82);
            this.grpbCode.TabIndex = 4;
            this.grpbCode.TabStop = false;
            // 
            // lblSubstrateThicknessCode
            // 
            this.lblSubstrateThicknessCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubstrateThicknessCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubstrateThicknessCode.Location = new System.Drawing.Point(233, 21);
            this.lblSubstrateThicknessCode.Name = "lblSubstrateThicknessCode";
            this.lblSubstrateThicknessCode.Size = new System.Drawing.Size(85, 40);
            this.lblSubstrateThicknessCode.TabIndex = 12;
            this.lblSubstrateThicknessCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubProcessCode
            // 
            this.lblSubProcessCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubProcessCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubProcessCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubProcessCode.Location = new System.Drawing.Point(82, 21);
            this.lblSubProcessCode.Name = "lblSubProcessCode";
            this.lblSubProcessCode.Size = new System.Drawing.Size(40, 40);
            this.lblSubProcessCode.TabIndex = 1;
            this.lblSubProcessCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessCode
            // 
            this.lblProcessCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProcessCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProcessCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProcessCode.Location = new System.Drawing.Point(36, 21);
            this.lblProcessCode.Name = "lblProcessCode";
            this.lblProcessCode.Size = new System.Drawing.Size(40, 40);
            this.lblProcessCode.TabIndex = 0;
            this.lblProcessCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBack1
            // 
            this.lblBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack1.Location = new System.Drawing.Point(31, 16);
            this.lblBack1.Name = "lblBack1";
            this.lblBack1.Size = new System.Drawing.Size(96, 50);
            this.lblBack1.TabIndex = 8;
            // 
            // lblBack2
            // 
            this.lblBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.lblBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack2.Location = new System.Drawing.Point(132, 16);
            this.lblBack2.Name = "lblBack2";
            this.lblBack2.Size = new System.Drawing.Size(96, 50);
            this.lblBack2.TabIndex = 9;
            // 
            // lblBack4
            // 
            this.lblBack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(118)))));
            this.lblBack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack4.Location = new System.Drawing.Point(412, 16);
            this.lblBack4.Name = "lblBack4";
            this.lblBack4.Size = new System.Drawing.Size(51, 50);
            this.lblBack4.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(405, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(78, 21);
            this.txtCode.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(60, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 21);
            this.txtName.TabIndex = 7;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(353, 17);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Código";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // frmCoatingFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 504);
            this.Controls.Add(this.grpbCode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFields);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoatingFilmForm";
            this.Text = "Película Coating";
            this.Load += new System.EventHandler(this.frmCoatingFilmForm_Load);
            this.grpProcess.ResumeLayout(false);
            this.grpProcess.PerformLayout();
            this.grpbTreatment.ResumeLayout(false);
            this.grpbTreatment.PerformLayout();
            this.grpbFields.ResumeLayout(false);
            this.grpbThickness.ResumeLayout(false);
            this.grpbThickness.PerformLayout();
            this.grpbStructure.ResumeLayout(false);
            this.grpbStructure.PerformLayout();
            this.grpbCode.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcess;
        private System.Windows.Forms.ComboBox cmbSubProcess;
        private System.Windows.Forms.Label lblSubProcess;
        private System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox cmbCoatingStructure;
        private System.Windows.Forms.Label lblCoatingStructure;
        private System.Windows.Forms.GroupBox grpbTreatment;
        private System.Windows.Forms.ComboBox cmbTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.ListBox lstbSubstrateThickness;
        private System.Windows.Forms.GroupBox grpbFields;
        private System.Windows.Forms.GroupBox grpbThickness;
        private System.Windows.Forms.Label lblCoatingThickness;
        private System.Windows.Forms.Label lblSustrateThickness;
        private System.Windows.Forms.ListBox lstbCoatingThikness;
        private System.Windows.Forms.RadioButton rdoMoreThickness;
        private System.Windows.Forms.RadioButton rdoOneThickness;
        private System.Windows.Forms.GroupBox grpbStructure;
        private System.Windows.Forms.ComboBox cmbTerminationStructure;
        private System.Windows.Forms.Label lblTerminationStructure;
        private System.Windows.Forms.Label lblTreatmentCode;
        private System.Windows.Forms.Label lblCoatingThicknessCode;
        private System.Windows.Forms.Label lblCoatingStructureCode;
        private System.Windows.Forms.Label lblTerminationStructureCode;
        private System.Windows.Forms.GroupBox grpbCode;
        private System.Windows.Forms.Label lblSubstrateThicknessCode;
        private System.Windows.Forms.Label lblSubProcessCode;
        private System.Windows.Forms.Label lblProcessCode;
        private System.Windows.Forms.Label lblBack1;
        private System.Windows.Forms.Label lblBack2;
        private System.Windows.Forms.Label lblBack4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip ttpFilmCoating;
    }
}