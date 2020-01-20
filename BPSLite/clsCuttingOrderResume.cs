using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    class clsCuttingOrderResume
    {
        //Attributes
        private GroupBox GrpbOrder;
        private GroupBox GrpbCombination;
        private List<Label> LstLblCoils;
        private List<CheckBox> LstChkSingleFace;
        private List<CheckBox> LstChkTPallet;
        private Label LblWaste1;
        private Label LblWaste2;
        private Label LblFilmName;
        private Label LblUtilWidthLabel;
        private Label LblCutterNameLabel;
        private Label LblCutterName;
        private Label LblUsedArms;
        private Label LblUsedWidth;
        private Label LblUsedWidthLabel;
        private Label LblUsedArmsLabel;
        private Label LblPercentage2;
        private Label LblWaste;
        private Label LblWasteLabel;
        private Label LblStops;
        private Label LblStopsNumber;
        private Button BtnSave;
        private Button BtnCancel;
        private Label LblStatusImage;
        private Label LblStatus;
        private Label LblSeparator;
        private Button BtnProcess;
        private Button BnRefresh;
        private NumericUpDown NudStopsNumber;
        private Label LblNotesLabel;
        private Label LblNotes;
        private ComboBox CmbCutter;
        private Button BtnChangeCutter;
                

        //Properties
        public GroupBox grpbOrder { get { return GrpbOrder; } set { GrpbOrder = value; } }

        public GroupBox grpbCombination { get { return GrpbCombination; } set { GrpbCombination = value; } }

        public List<Label> lstLblCoils { get { return LstLblCoils; } set { LstLblCoils = value; } }

        public List<CheckBox> lstChkSingleFace { get { return LstChkSingleFace; } set { LstChkSingleFace = value; } }

        public List<CheckBox> lstChkTPallet { get { return LstChkTPallet; } set { LstChkTPallet = value; } }

        public Label lblWaste1 { get { return LblWaste1; } set { LblWaste1 = value; } }

        public Label lblWaste2 { get { return LblWaste2; } set { LblWaste2 = value; } }

        public Label lblFilmName { get { return LblFilmName; } set { LblFilmName = value; } }

        public Label lblUtilWidthLabel { get { return LblUtilWidthLabel; } set { LblUtilWidthLabel = value; } }

        public Label lblCutterNameLabel { get { return LblCutterNameLabel; } set { LblCutterNameLabel = value; } }

        public Label lblCutterName { get { return LblCutterName; } set { LblCutterName = value; } }

        public Label lblUsedArms { get { return LblUsedArms; } set { LblUsedArms = value; } }

        public Label lblUsedArmsLabel { get { return LblUsedArmsLabel; } set { LblUsedArmsLabel = value; } }

        public Label lblUsedWidth { get { return LblUsedWidth; } set { LblUsedWidth = value; } }

        public Label lblUsedWidthLabel { get { return LblUsedWidthLabel; } set { LblUsedWidthLabel = value; } }

        public Label lblPercentage2 { get { return LblPercentage2; } set { LblPercentage2 = value; } }

        public Label lblWaste { get { return LblWaste; } set { LblWaste = value; } }

        public Label lblWasteLabel { get { return LblWasteLabel; } set { LblWasteLabel = value; } }

        public Label lblStops { get { return LblStops; } set { LblStops = value; } }

        public Label lblStopsNumber { get { return LblStopsNumber; } set { LblStopsNumber = value; } }

        public Button btnSave { get { return BtnSave; } set { BtnSave = value; } }

        public Button btnCancel { get { return BtnCancel; } set { BtnCancel = value; } }

        public Label lblStatusImage { get { return LblStatusImage; } set { LblStatusImage = value; } }

        public Label lblStatus { get { return LblStatus; } set { LblStatus = value; } }

        public Label lblSeparator { get { return LblSeparator; } set { LblSeparator = value; } }

        public Button btnProcess { get { return BtnProcess; } set { BtnProcess = value; } }

        public Button btnRefresh { get { return BnRefresh; } set { BnRefresh = value; } }

        public NumericUpDown nudStopsNumber { get { return NudStopsNumber; } set { NudStopsNumber = value; } }

        public Label lblNotesLabel { get { return LblNotesLabel; } set { LblNotesLabel = value; } }

        public Label lblNotes { get { return LblNotes; } set { LblNotes = value; } }

        public ComboBox cmbCutter { get { return CmbCutter; } set { CmbCutter = value; } }

        public Button btnChangeCutter { get { return BtnChangeCutter; } set { BtnChangeCutter = value; } }

        //Constructor

        public clsCuttingOrderResume()
        {
            this.grpbOrder = new GroupBox();
            this.grpbCombination = new GroupBox();
            this.lstLblCoils = new List<Label>();
            this.lstChkSingleFace = new List<CheckBox>();
            this.lstChkTPallet = new List<CheckBox>();
            this.lblWaste1 = new Label();
            this.lblWaste2 = new Label();
            this.lblFilmName = new Label();
            this.lblUtilWidthLabel = new Label();
            this.lblCutterNameLabel = new Label();
            this.lblCutterName = new Label();
            this.lblUsedArms = new Label();
            this.LblUsedWidth = new Label();
            this.lblUsedArmsLabel = new Label();
            this.lblUsedWidthLabel = new Label();
            this.lblPercentage2 = new Label();
            this.lblWaste = new Label();
            this.lblWasteLabel = new Label();
            this.lblStops = new Label();
            this.lblStopsNumber = new Label();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.LblStatusImage = new Label();
            this.LblStatus = new Label();
            this.LblSeparator = new Label();
            this.btnProcess = new Button();
            this.btnRefresh = new Button();
            this.nudStopsNumber = new NumericUpDown();
            this.lblNotes = new Label();
            this.lblNotesLabel = new Label();
            this.cmbCutter = new ComboBox();
            this.btnChangeCutter = new Button();


            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage2.Location = new System.Drawing.Point(227, 200);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage2.TabIndex = 33;
            this.lblPercentage2.Text = "%";
            // 
            // lblStopsNumber
            // 
            this.lblStopsNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStopsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopsNumber.Location = new System.Drawing.Point(185, 171);
            this.lblStopsNumber.Name = "lblStopsNumber";
            this.lblStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.lblStopsNumber.TabIndex = 32;
            this.lblStopsNumber.Tag = "clearOnReload";
            this.lblStopsNumber.Text = "0";
            this.lblStopsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWaste
            // 
            this.lblWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste.Location = new System.Drawing.Point(185, 198);
            this.lblWaste.Name = "lblWaste";
            this.lblWaste.Size = new System.Drawing.Size(41, 21);
            this.lblWaste.TabIndex = 32;
            this.lblWaste.Tag = "clearOnReload";
            this.lblWaste.Text = "0";
            this.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteLabel
            // 
            this.lblWasteLabel.AutoSize = true;
            this.lblWasteLabel.Location = new System.Drawing.Point(87, 200);
            this.lblWasteLabel.Name = "lblWasteLabel";
            this.lblWasteLabel.Size = new System.Drawing.Size(73, 15);
            this.lblWasteLabel.TabIndex = 30;
            this.lblWasteLabel.Text = "Desperdicio";
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.Location = new System.Drawing.Point(87, 174);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(95, 15);
            this.lblStops.TabIndex = 31;
            this.lblStops.Text = "Nro. de paradas";
            // 
            // lblUsedArms
            // 
            this.lblUsedArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedArms.Location = new System.Drawing.Point(372, 197);
            this.lblUsedArms.Name = "lblUsedArms";
            this.lblUsedArms.Size = new System.Drawing.Size(70, 21);
            this.lblUsedArms.TabIndex = 25;
            this.lblUsedArms.Tag = "clearOnReload";
            this.lblUsedArms.Text = "0";
            this.lblUsedArms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedWidth
            // 
            this.lblUsedWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedWidth.Location = new System.Drawing.Point(372, 171);
            this.lblUsedWidth.Name = "lblUsedWidth";
            this.lblUsedWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUsedWidth.TabIndex = 26;
            this.lblUsedWidth.Tag = "clearOnReload";
            this.lblUsedWidth.Text = "0";
            this.lblUsedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedArmsLabel
            // 
            this.lblUsedArmsLabel.AutoSize = true;
            this.lblUsedArmsLabel.Location = new System.Drawing.Point(253, 200);
            this.lblUsedArmsLabel.Name = "lblUsedArmsLabel";
            this.lblUsedArmsLabel.Size = new System.Drawing.Size(116, 15);
            this.lblUsedArmsLabel.TabIndex = 21;
            this.lblUsedArmsLabel.Text = "Número de bobinas";
            // 
            // lblUsedWidthLabel
            // 
            this.lblUsedWidthLabel.AutoSize = true;
            this.lblUsedWidthLabel.Location = new System.Drawing.Point(253, 174);
            this.lblUsedWidthLabel.Name = "lblUsedWidthLabel";
            this.lblUsedWidthLabel.Size = new System.Drawing.Size(92, 15);
            this.lblUsedWidthLabel.TabIndex = 22;
            this.lblUsedWidthLabel.Text = "Ancho Utilizado";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Location = new System.Drawing.Point(549, 20);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lblCutterNameLabel.TabIndex = 12;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblUtilWidthLabel
            // 
            this.lblUtilWidthLabel.AutoSize = true;
            this.lblUtilWidthLabel.Location = new System.Drawing.Point(268, 20);
            this.lblUtilWidthLabel.Name = "lblUtilWidthLabel";
            this.lblUtilWidthLabel.Size = new System.Drawing.Size(51, 15);
            this.lblUtilWidthLabel.TabIndex = 12;
            this.lblUtilWidthLabel.Text = "Película";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(616, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(200, 21);
            this.lblCutterName.TabIndex = 3;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(335, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(200, 21);
            this.lblFilmName.TabIndex = 3;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // lblWaste1
            // 
            this.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste1.Location = new System.Drawing.Point(16, 21);
            this.lblWaste1.Name = "lblWaste1";
            this.lblWaste1.Size = new System.Drawing.Size(20, 66);
            this.lblWaste1.TabIndex = 1;
            this.lblWaste1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaste2
            // 
            this.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste2.Location = new System.Drawing.Point(942, 21);
            this.lblWaste2.Name = "lblWaste2";
            this.lblWaste2.Size = new System.Drawing.Size(20, 66);
            this.lblWaste2.TabIndex = 2;
            this.lblWaste2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(920, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 35;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(920, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblStatusImage
            // 
            this.lblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
            this.lblStatusImage.Location = new System.Drawing.Point(29, 174);
            this.lblStatusImage.Name = "lblStatusImage";
            this.lblStatusImage.Size = new System.Drawing.Size(25, 25);
            this.lblStatusImage.TabIndex = 37;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Cortadora";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(79, 171);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 49);
            this.lblSeparator.TabIndex = 38;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcess.Location = new System.Drawing.Point(951, 171);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 39;
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Lite.Properties.Resources.arrow_refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(225, 170);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // nudStopsNumber
            // 
            this.nudStopsNumber.Location = new System.Drawing.Point(185, 171);
            this.nudStopsNumber.Name = "nudStopsNumber";
            this.nudStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.nudStopsNumber.TabIndex = 11;
            this.nudStopsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStopsNumber.Maximum = 250;
            // 
            // grpbCombination
            // 
            //this.grpbCombination.Location = new System.Drawing.Point(3, 50);
            this.grpbCombination.Location = new System.Drawing.Point(3, 38);
            this.grpbCombination.Name = "grpbCombination";
            this.grpbCombination.Size = new System.Drawing.Size(1060, 130);
            this.grpbCombination.TabIndex = 0;
            this.grpbCombination.TabStop = false;
            this.grpbCombination.Text = "Combinación";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(505, 170);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(399, 48);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotesLabel
            // 
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Location = new System.Drawing.Point(460, 173);
            this.lblNotesLabel.Name = "lblNotesLabel";
            this.lblNotesLabel.Size = new System.Drawing.Size(39, 15);
            this.lblNotesLabel.TabIndex = 12;
            this.lblNotesLabel.Text = "Notas";
            // 
            // btnChangeCutter
            // 
            this.btnChangeCutter.BackgroundImage = global::BPS.Lite.Properties.Resources.arrow_refresh;
            this.btnChangeCutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeCutter.Location = new System.Drawing.Point(823, 16);
            this.btnChangeCutter.Name = "btnChangeCutter";
            this.btnChangeCutter.Size = new System.Drawing.Size(22, 22);
            this.btnChangeCutter.TabIndex = 41;
            this.btnChangeCutter.UseVisualStyleBackColor = true;
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(616, 17);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(200, 23);
            this.cmbCutter.TabIndex = 42;
            this.cmbCutter.Visible = false;

            List<clsMachine> lstCutterMachines = clsMachine.getCutterMachineList();

            cmbCutter.Items.Clear();

            for (int i = 0; i < lstCutterMachines.Count; i++)
                cmbCutter.Items.Add(lstCutterMachines[i]);

            // 
            // grpbOrder
            // 
            this.grpbOrder.Controls.Add(this.nudStopsNumber);
            this.grpbOrder.Controls.Add(this.btnRefresh);
            this.grpbOrder.Controls.Add(this.lblPercentage2);
            this.grpbOrder.Controls.Add(this.lblSeparator);
            this.grpbOrder.Controls.Add(this.lblStopsNumber);
            this.grpbOrder.Controls.Add(this.lblWaste);
            this.grpbOrder.Controls.Add(this.lblWasteLabel);
            this.grpbOrder.Controls.Add(this.lblStops);
            this.grpbOrder.Controls.Add(this.lblUsedArms);
            this.grpbOrder.Controls.Add(this.LblUsedWidth);
            this.grpbOrder.Controls.Add(this.lblUsedArmsLabel);
            this.grpbOrder.Controls.Add(this.lblUsedWidthLabel);
            this.grpbOrder.Controls.Add(this.lblCutterNameLabel);
            this.grpbOrder.Controls.Add(this.lblUtilWidthLabel);
            this.grpbOrder.Controls.Add(this.lblCutterName);
            this.grpbOrder.Controls.Add(this.lblFilmName);
            this.grpbOrder.Controls.Add(this.grpbCombination);
            this.grpbOrder.Controls.Add(this.btnSave);
            this.grpbOrder.Controls.Add(this.btnCancel);
            this.grpbOrder.Controls.Add(this.LblStatusImage);
            this.grpbOrder.Controls.Add(this.LblStatus);
            this.grpbOrder.Controls.Add(this.btnProcess);
            this.grpbOrder.Controls.Add(this.lblNotesLabel);
            this.grpbOrder.Controls.Add(this.lblNotes);
            this.grpbOrder.Controls.Add(this.cmbCutter);
            this.grpbOrder.Controls.Add(this.btnChangeCutter);
            this.grpbOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbOrder.Name = "grpbOrder";
            this.grpbOrder.Size = new System.Drawing.Size(1074, 223);
            this.grpbOrder.TabIndex = 0;
            this.grpbOrder.TabStop = false;
        }

        public static GroupBox getCuttingOrderResumeLayoutByCuttingOrder(clsCuttingOrder objCuttingOrder, string CALLerWindow)
        {
            clsCuttingOrderResume objCuttingOrderResume =  new clsCuttingOrderResume();
            clsMachine objMachine = new clsMachine();
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            int relativePosition = 16;
            int wasteSize = objMachine.Cutter.utilWidth;
            double usedWidth = 0;

            objCuttingOrderResume.lblCutterName.Text = objCuttingOrder.machineName;
            objCuttingOrderResume.lblFilmName.Text = "";
            objCuttingOrderResume.lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
            objCuttingOrderResume.nudStopsNumber.Value = objCuttingOrder.repetitions;
            objCuttingOrderResume.lblUsedArms.Text = objCuttingOrder.positions.ToString();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

            objCuttingOrderResume.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            objCuttingOrderResume.lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            objCuttingOrderResume.lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

            objCuttingOrderResume.grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lblWaste1);

            relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2);
            
            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                objCuttingOrderResume.lstLblCoils.Add(new Label());
                objCuttingOrderResume.lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                objCuttingOrderResume.lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                objCuttingOrderResume.lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                objCuttingOrderResume.lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                objCuttingOrderResume.lstLblCoils[i].Name = "lblCoil" + i.ToString();
                objCuttingOrderResume.lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020), 66);
                objCuttingOrderResume.lstLblCoils[i].TabIndex = 0;
                if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
               
                    objCuttingOrderResume.lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail + "\r\nCliente : " + clsCuttingOrderDetail.getSalesOrderDetailCustomer(objCuttingOrder.lstCuttingOrderDetail[i].codsec) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                else
                    objCuttingOrderResume.lstLblCoils[i].Text = "Orden  : ----\r\nCliente : STOCK\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                objCuttingOrderResume.lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lstLblCoils[i]);

                objCuttingOrderResume.lstChkSingleFace.Add(new CheckBox());
                objCuttingOrderResume.lstChkSingleFace[i].AutoSize = true;
                objCuttingOrderResume.lstChkSingleFace[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                objCuttingOrderResume.lstChkSingleFace[i].Location = new System.Drawing.Point(relativePosition, 90);
                objCuttingOrderResume.lstChkSingleFace[i].Name = "chkSingleFace" + i.ToString();
                objCuttingOrderResume.lstChkSingleFace[i].Size = new System.Drawing.Size(81, 17);
                objCuttingOrderResume.lstChkSingleFace[i].TabIndex = 10;
                objCuttingOrderResume.lstChkSingleFace[i].Text = "Single Face";
                objCuttingOrderResume.lstChkSingleFace[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                objCuttingOrderResume.lstChkSingleFace[i].UseVisualStyleBackColor = true;
                objCuttingOrderResume.lstChkSingleFace[i].Checked = objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace;

                objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lstChkSingleFace[i]);

                objCuttingOrderResume.lstChkTPallet.Add(new CheckBox());
                objCuttingOrderResume.lstChkTPallet[i].AutoSize = true;
                objCuttingOrderResume.lstChkTPallet[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                objCuttingOrderResume.lstChkTPallet[i].Location = new System.Drawing.Point(relativePosition, 108);
                objCuttingOrderResume.lstChkTPallet[i].Name = "chkPalletType" + i.ToString();
                objCuttingOrderResume.lstChkTPallet[i].Size = new System.Drawing.Size(81, 17);
                objCuttingOrderResume.lstChkTPallet[i].TabIndex = 10;
                objCuttingOrderResume.lstChkTPallet[i].Text = ((objCuttingOrder.lstCuttingOrderDetail[i].pallet) == "") ? "TPallet  -----  " : "TPallet " + objCuttingOrder.lstCuttingOrderDetail[i].pallet;
                objCuttingOrderResume.lstChkTPallet[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                objCuttingOrderResume.lstChkTPallet[i].UseVisualStyleBackColor = true;
                objCuttingOrderResume.lstChkTPallet[i].Checked = ((objCuttingOrder.lstCuttingOrderDetail[i].pallet) == "") ? false : true;

                objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lstChkTPallet[i]);

                
                relativePosition += clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020);
            }

            objCuttingOrderResume.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            objCuttingOrderResume.lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize,1020)/2), 66);
            objCuttingOrderResume.lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
            objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lblWaste2);
            objCuttingOrderResume.lblNotes.Text = objCuttingOrder.notes;
            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.paste;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 24:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 25:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.applications;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 26:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.check;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 27:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.cancel1;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 31:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.Pause_Hot;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                default:
                    break;
            }
            switch (CALLerWindow)
            {
                case "cuttingOrderList":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 24:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
                            objCuttingOrderResume.btnSave.Visible = false;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = false;
                                objCuttingOrderResume.BtnCancel.Visible = true;

                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            else
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = false;
                                objCuttingOrderResume.BtnCancel.Visible = false;

                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                            objCuttingOrderResume.btnSave.Visible = false;
                            objCuttingOrderResume.BtnCancel.Visible = true;

                            objCuttingOrderResume.btnProcess.Visible = true;
                            objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            break;
                    }


                    break;
                case "cuttingOrder":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 23:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = true;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 24:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = false;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = true;
                                objCuttingOrderResume.BtnCancel.Visible = true;
                                objCuttingOrderResume.btnSave.Enabled = false;
                                objCuttingOrderResume.BtnCancel.Enabled = false;

                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = false;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                    }


                    break;
                default:
                    break;
            }

            objCuttingOrderResume.lblUsedWidth.Text = usedWidth.ToString();
            objCuttingOrderResume.lblWaste.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
            objCuttingOrderResume.lblFilmName.Text = objCuttingOrder.boppCode.Replace("-", "");
            objCuttingOrderResume.lblNotes.Text = objCuttingOrder.notes;

            return objCuttingOrderResume.grpbOrder;
        }
        public static GroupBox getSecundaryCuttingOrderResumeLayoutByCuttingOrder(clsCuttingOrder objCuttingOrder, string CALLerWindow)
        {
            clsCuttingOrderResume objCuttingOrderResume = new clsCuttingOrderResume();
            clsMachine objMachine = new clsMachine();
            clsProduct objProduct = new clsProduct(objCuttingOrder.fkProduct);
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            int relativePosition = 16;
            int wasteSize = Convert.ToInt32(objProduct.width);
            double usedWidth = 0;

            objCuttingOrderResume.lblCutterName.Text = objCuttingOrder.machineName;
            objCuttingOrderResume.lblFilmName.Text = "";
            objCuttingOrderResume.lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
            objCuttingOrderResume.nudStopsNumber.Value = objCuttingOrder.repetitions;
            objCuttingOrderResume.lblUsedArms.Text = objCuttingOrder.positions.ToString();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

            objCuttingOrderResume.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            objCuttingOrderResume.lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2), 66);
            objCuttingOrderResume.lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

            objCuttingOrderResume.grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lblWaste1);

            relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2);

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                objCuttingOrderResume.lstLblCoils.Add(new Label());
                objCuttingOrderResume.lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                objCuttingOrderResume.lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                objCuttingOrderResume.lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                objCuttingOrderResume.lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                objCuttingOrderResume.lstLblCoils[i].Name = "lblCoil" + i.ToString();
                objCuttingOrderResume.lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020), 66);
                objCuttingOrderResume.lstLblCoils[i].TabIndex = 0;
                if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    objCuttingOrderResume.lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail + "\r\nCliente : " + clsCuttingOrderDetail.getSalesOrderDetailCustomer(objCuttingOrder.lstCuttingOrderDetail[i].codsec) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                else
                    objCuttingOrderResume.lstLblCoils[i].Text = "Orden  : ----\r\nCliente : STOCK\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                objCuttingOrderResume.lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lstLblCoils[i]);

                objCuttingOrderResume.lstChkSingleFace.Add(new CheckBox());
                objCuttingOrderResume.lstChkSingleFace[i].AutoSize = true;
                objCuttingOrderResume.lstChkSingleFace[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                objCuttingOrderResume.lstChkSingleFace[i].Location = new System.Drawing.Point(relativePosition, 57);
                objCuttingOrderResume.lstChkSingleFace[i].Name = "chkSingleFace" + i.ToString();
                objCuttingOrderResume.lstChkSingleFace[i].Size = new System.Drawing.Size(81, 17);
                objCuttingOrderResume.lstChkSingleFace[i].TabIndex = 10;
                objCuttingOrderResume.lstChkSingleFace[i].Text = "Single Face";
                objCuttingOrderResume.lstChkSingleFace[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                objCuttingOrderResume.lstChkSingleFace[i].UseVisualStyleBackColor = true;
                objCuttingOrderResume.lstChkSingleFace[i].Checked = objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace;

                objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lstChkSingleFace[i]);

                relativePosition += clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020);
            }

            objCuttingOrderResume.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            objCuttingOrderResume.lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2), 66);
            objCuttingOrderResume.lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
            objCuttingOrderResume.GrpbCombination.Controls.Add(objCuttingOrderResume.lblWaste2);

            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.paste;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 24:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 25:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.applications;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 26:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.check;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 27:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.cancel1;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 31:
                    objCuttingOrderResume.LblStatusImage.Image = global::BPS.Lite.Properties.Resources.Pause_Hot;
                    objCuttingOrderResume.LblStatus.Text = objCuttingOrder.statusName;
                    break;
                default:
                    break;
            }
            switch (CALLerWindow)
            {
                case "cuttingOrderList":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 24:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
                            objCuttingOrderResume.btnSave.Visible = false;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = false;
                                objCuttingOrderResume.BtnCancel.Visible = true;

                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            else
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = false;
                                objCuttingOrderResume.BtnCancel.Visible = false;

                                objCuttingOrderResume.btnProcess.Visible = true;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                            objCuttingOrderResume.btnSave.Visible = false;
                            objCuttingOrderResume.BtnCancel.Visible = true;

                            objCuttingOrderResume.btnProcess.Visible = true;
                            objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            break;
                    }


                    break;
                case "cuttingOrder":
                    switch (objCuttingOrder.fkStatus)
                    {
                        case 23:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = true;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 24:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = false;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 25:
                            if (objCuttingOrder.beingProcessed())
                            {
                                objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                                objCuttingOrderResume.btnSave.Visible = true;
                                objCuttingOrderResume.BtnCancel.Visible = true;
                                objCuttingOrderResume.btnSave.Enabled = false;
                                objCuttingOrderResume.BtnCancel.Enabled = false;

                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                        case 31:
                            objCuttingOrderResume.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
                            objCuttingOrderResume.btnSave.Visible = true;
                            objCuttingOrderResume.BtnCancel.Visible = true;
                            objCuttingOrderResume.btnSave.Enabled = false;
                            objCuttingOrderResume.BtnCancel.Enabled = true;
                            if (objCuttingOrder.canBeProcessed())
                            {
                                objCuttingOrderResume.btnProcess.Visible = false;
                                objCuttingOrderResume.btnProcess.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                            }
                            break;
                    }


                    break;
                default:
                    break;
            }

            objCuttingOrderResume.lblUsedWidth.Text = usedWidth.ToString();
            objCuttingOrderResume.lblWaste.Text = Convert.ToString(Math.Round(((Convert.ToInt32(objProduct.width) - usedWidth) * 100 / Convert.ToInt32(objProduct.width)), 2));
            objCuttingOrderResume.lblFilmName.Text = objCuttingOrder.productCode;
            objCuttingOrderResume.lblNotes.Text = objCuttingOrder.notes;

            return objCuttingOrderResume.grpbOrder;
        }
        public static int getProportinalWidth(int maxWidth, int width, int formWidth)
        {
            return Convert.ToInt32((width * formWidth) / maxWidth);
        }
    }
}
