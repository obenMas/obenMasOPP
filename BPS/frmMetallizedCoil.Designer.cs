namespace BPS
{
    partial class frmMetallizedCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetallizedCoil));
            this.grpbCoilInfo = new System.Windows.Forms.GroupBox();
            this.tbcCoil = new System.Windows.Forms.TabControl();
            this.tbpCoilInfo = new System.Windows.Forms.TabPage();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblFulmNameLabel = new System.Windows.Forms.Label();
            this.txtDensity = new System.Windows.Forms.Label();
            this.grpbDefects = new System.Windows.Forms.GroupBox();
            this.chkDefect1 = new System.Windows.Forms.CheckBox();
            this.chkDefect2 = new System.Windows.Forms.CheckBox();
            this.chkDefect3 = new System.Windows.Forms.CheckBox();
            this.chkDefect4 = new System.Windows.Forms.CheckBox();
            this.chkDefect5 = new System.Windows.Forms.CheckBox();
            this.chkDefect6 = new System.Windows.Forms.CheckBox();
            this.chkDefect7 = new System.Windows.Forms.CheckBox();
            this.chkDefect8 = new System.Windows.Forms.CheckBox();
            this.chkDefect9 = new System.Windows.Forms.CheckBox();
            this.chkDefect10 = new System.Windows.Forms.CheckBox();
            this.chkDefect11 = new System.Windows.Forms.CheckBox();
            this.chkDefect12 = new System.Windows.Forms.CheckBox();
            this.chkDefect13 = new System.Windows.Forms.CheckBox();
            this.chkDefect14 = new System.Windows.Forms.CheckBox();
            this.chkDefect15 = new System.Windows.Forms.CheckBox();
            this.chkDefect16 = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.cmbBalance = new System.Windows.Forms.ComboBox();
            this.lblLengthLabel = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblWidthLabel = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.txtGrossWeigth = new System.Windows.Forms.TextBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.tbpLabel = new System.Windows.Forms.TabPage();
            this.crvCoilLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbCuttingOrderInfo = new System.Windows.Forms.GroupBox();
            this.txtUsedLenfth = new System.Windows.Forms.TextBox();
            this.txtMainCoilLabel = new System.Windows.Forms.TextBox();
            this.lblUsedLength = new System.Windows.Forms.Label();
            this.lblMainCoil = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.ttpMetalizedCoil = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCoilInfo.SuspendLayout();
            this.tbcCoil.SuspendLayout();
            this.tbpCoilInfo.SuspendLayout();
            this.grpbDefects.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.tbpLabel.SuspendLayout();
            this.grpbCuttingOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCoilInfo
            // 
            this.grpbCoilInfo.Controls.Add(this.tbcCoil);
            this.grpbCoilInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoilInfo.Location = new System.Drawing.Point(0, 49);
            this.grpbCoilInfo.Name = "grpbCoilInfo";
            this.grpbCoilInfo.Size = new System.Drawing.Size(748, 374);
            this.grpbCoilInfo.TabIndex = 2;
            this.grpbCoilInfo.TabStop = false;
            this.grpbCoilInfo.Text = "Información de bobina";
            // 
            // tbcCoil
            // 
            this.tbcCoil.Controls.Add(this.tbpCoilInfo);
            this.tbcCoil.Controls.Add(this.tbpLabel);
            this.tbcCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCoil.Location = new System.Drawing.Point(3, 17);
            this.tbcCoil.Name = "tbcCoil";
            this.tbcCoil.SelectedIndex = 0;
            this.tbcCoil.Size = new System.Drawing.Size(742, 354);
            this.tbcCoil.TabIndex = 0;
            // 
            // tbpCoilInfo
            // 
            this.tbpCoilInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbpCoilInfo.Controls.Add(this.cmbProduct);
            this.tbpCoilInfo.Controls.Add(this.lblFulmNameLabel);
            this.tbpCoilInfo.Controls.Add(this.txtDensity);
            this.tbpCoilInfo.Controls.Add(this.grpbDefects);
            this.tbpCoilInfo.Controls.Add(this.lblWidth);
            this.tbpCoilInfo.Controls.Add(this.lblCode);
            this.tbpCoilInfo.Controls.Add(this.lblLength);
            this.tbpCoilInfo.Controls.Add(this.lblNetWeigth);
            this.tbpCoilInfo.Controls.Add(this.cmbQuality);
            this.tbpCoilInfo.Controls.Add(this.cmbBalance);
            this.tbpCoilInfo.Controls.Add(this.lblLengthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblNetWeigthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblWidthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblGrossWeigth);
            this.tbpCoilInfo.Controls.Add(this.lblCodeLabel);
            this.tbpCoilInfo.Controls.Add(this.lblDensity);
            this.tbpCoilInfo.Controls.Add(this.lblQuality);
            this.tbpCoilInfo.Controls.Add(this.txtDiameter);
            this.tbpCoilInfo.Controls.Add(this.lblBalance);
            this.tbpCoilInfo.Controls.Add(this.lblDiameter);
            this.tbpCoilInfo.Controls.Add(this.btnBalance);
            this.tbpCoilInfo.Controls.Add(this.txtGrossWeigth);
            this.tbpCoilInfo.Controls.Add(this.grpbNotes);
            this.tbpCoilInfo.Controls.Add(this.grpbEmpty);
            this.tbpCoilInfo.Controls.Add(this.grpbMainCoilButtons);
            this.tbpCoilInfo.Location = new System.Drawing.Point(4, 24);
            this.tbpCoilInfo.Name = "tbpCoilInfo";
            this.tbpCoilInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoilInfo.Size = new System.Drawing.Size(734, 326);
            this.tbpCoilInfo.TabIndex = 1;
            this.tbpCoilInfo.Text = "Información de bobina";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(99, 16);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(350, 23);
            this.cmbProduct.TabIndex = 106;
            // 
            // lblFulmNameLabel
            // 
            this.lblFulmNameLabel.AutoSize = true;
            this.lblFulmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulmNameLabel.Location = new System.Drawing.Point(14, 19);
            this.lblFulmNameLabel.Name = "lblFulmNameLabel";
            this.lblFulmNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lblFulmNameLabel.TabIndex = 105;
            this.lblFulmNameLabel.Text = "Producto";
            // 
            // txtDensity
            // 
            this.txtDensity.BackColor = System.Drawing.SystemColors.Window;
            this.txtDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensity.Location = new System.Drawing.Point(333, 53);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(116, 26);
            this.txtDensity.TabIndex = 104;
            this.txtDensity.Tag = "clearOnReload";
            this.txtDensity.Text = "0";
            this.txtDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbDefects
            // 
            this.grpbDefects.Controls.Add(this.chkDefect1);
            this.grpbDefects.Controls.Add(this.chkDefect2);
            this.grpbDefects.Controls.Add(this.chkDefect3);
            this.grpbDefects.Controls.Add(this.chkDefect4);
            this.grpbDefects.Controls.Add(this.chkDefect5);
            this.grpbDefects.Controls.Add(this.chkDefect6);
            this.grpbDefects.Controls.Add(this.chkDefect7);
            this.grpbDefects.Controls.Add(this.chkDefect8);
            this.grpbDefects.Controls.Add(this.chkDefect9);
            this.grpbDefects.Controls.Add(this.chkDefect10);
            this.grpbDefects.Controls.Add(this.chkDefect11);
            this.grpbDefects.Controls.Add(this.chkDefect12);
            this.grpbDefects.Controls.Add(this.chkDefect13);
            this.grpbDefects.Controls.Add(this.chkDefect14);
            this.grpbDefects.Controls.Add(this.chkDefect15);
            this.grpbDefects.Controls.Add(this.chkDefect16);
            this.grpbDefects.Enabled = false;
            this.grpbDefects.Location = new System.Drawing.Point(478, 1);
            this.grpbDefects.Name = "grpbDefects";
            this.grpbDefects.Size = new System.Drawing.Size(243, 216);
            this.grpbDefects.TabIndex = 101;
            this.grpbDefects.TabStop = false;
            this.grpbDefects.Text = "Defectos";
            // 
            // chkDefect1
            // 
            this.chkDefect1.AutoSize = true;
            this.chkDefect1.Location = new System.Drawing.Point(13, 19);
            this.chkDefect1.Name = "chkDefect1";
            this.chkDefect1.Size = new System.Drawing.Size(89, 17);
            this.chkDefect1.TabIndex = 0;
            this.chkDefect1.Tag = "1";
            this.chkDefect1.Text = "Acampanado";
            this.chkDefect1.UseVisualStyleBackColor = true;
            // 
            // chkDefect2
            // 
            this.chkDefect2.AutoSize = true;
            this.chkDefect2.Location = new System.Drawing.Point(13, 43);
            this.chkDefect2.Name = "chkDefect2";
            this.chkDefect2.Size = new System.Drawing.Size(77, 17);
            this.chkDefect2.TabIndex = 1;
            this.chkDefect2.Tag = "2";
            this.chkDefect2.Text = "Acanalado";
            this.chkDefect2.UseVisualStyleBackColor = true;
            // 
            // chkDefect3
            // 
            this.chkDefect3.AutoSize = true;
            this.chkDefect3.Location = new System.Drawing.Point(13, 67);
            this.chkDefect3.Name = "chkDefect3";
            this.chkDefect3.Size = new System.Drawing.Size(62, 17);
            this.chkDefect3.TabIndex = 2;
            this.chkDefect3.Tag = "3";
            this.chkDefect3.Text = "Arrugas";
            this.chkDefect3.UseVisualStyleBackColor = true;
            // 
            // chkDefect4
            // 
            this.chkDefect4.AutoSize = true;
            this.chkDefect4.Location = new System.Drawing.Point(13, 91);
            this.chkDefect4.Name = "chkDefect4";
            this.chkDefect4.Size = new System.Drawing.Size(84, 17);
            this.chkDefect4.TabIndex = 3;
            this.chkDefect4.Tag = "4";
            this.chkDefect4.Text = "Bobina Floja";
            this.chkDefect4.UseVisualStyleBackColor = true;
            // 
            // chkDefect5
            // 
            this.chkDefect5.AutoSize = true;
            this.chkDefect5.Location = new System.Drawing.Point(13, 115);
            this.chkDefect5.Name = "chkDefect5";
            this.chkDefect5.Size = new System.Drawing.Size(65, 17);
            this.chkDefect5.TabIndex = 4;
            this.chkDefect5.Tag = "5";
            this.chkDefect5.Text = "Bloqueo";
            this.chkDefect5.UseVisualStyleBackColor = true;
            // 
            // chkDefect6
            // 
            this.chkDefect6.AutoSize = true;
            this.chkDefect6.Location = new System.Drawing.Point(13, 139);
            this.chkDefect6.Name = "chkDefect6";
            this.chkDefect6.Size = new System.Drawing.Size(79, 17);
            this.chkDefect6.TabIndex = 5;
            this.chkDefect6.Tag = "6";
            this.chkDefect6.Text = "Borde Flojo";
            this.chkDefect6.UseVisualStyleBackColor = true;
            // 
            // chkDefect7
            // 
            this.chkDefect7.AutoSize = true;
            this.chkDefect7.Location = new System.Drawing.Point(13, 163);
            this.chkDefect7.Name = "chkDefect7";
            this.chkDefect7.Size = new System.Drawing.Size(80, 17);
            this.chkDefect7.TabIndex = 6;
            this.chkDefect7.Tag = "7";
            this.chkDefect7.Text = "Punto Duro";
            this.chkDefect7.UseVisualStyleBackColor = true;
            // 
            // chkDefect8
            // 
            this.chkDefect8.AutoSize = true;
            this.chkDefect8.Location = new System.Drawing.Point(13, 187);
            this.chkDefect8.Name = "chkDefect8";
            this.chkDefect8.Size = new System.Drawing.Size(96, 17);
            this.chkDefect8.TabIndex = 7;
            this.chkDefect8.Tag = "8";
            this.chkDefect8.Text = "Contaminación";
            this.chkDefect8.UseVisualStyleBackColor = true;
            // 
            // chkDefect9
            // 
            this.chkDefect9.AutoSize = true;
            this.chkDefect9.Location = new System.Drawing.Point(130, 19);
            this.chkDefect9.Name = "chkDefect9";
            this.chkDefect9.Size = new System.Drawing.Size(72, 17);
            this.chkDefect9.TabIndex = 8;
            this.chkDefect9.Tag = "9";
            this.chkDefect9.Text = "Curvatura";
            this.chkDefect9.UseVisualStyleBackColor = true;
            // 
            // chkDefect10
            // 
            this.chkDefect10.AutoSize = true;
            this.chkDefect10.Location = new System.Drawing.Point(130, 43);
            this.chkDefect10.Name = "chkDefect10";
            this.chkDefect10.Size = new System.Drawing.Size(82, 17);
            this.chkDefect10.TabIndex = 9;
            this.chkDefect10.Tag = "10";
            this.chkDefect10.Text = "Tensionado";
            this.chkDefect10.UseVisualStyleBackColor = true;
            // 
            // chkDefect11
            // 
            this.chkDefect11.AutoSize = true;
            this.chkDefect11.Location = new System.Drawing.Point(130, 67);
            this.chkDefect11.Name = "chkDefect11";
            this.chkDefect11.Size = new System.Drawing.Size(57, 17);
            this.chkDefect11.TabIndex = 10;
            this.chkDefect11.Tag = "11";
            this.chkDefect11.Text = "Estrias";
            this.chkDefect11.UseVisualStyleBackColor = true;
            // 
            // chkDefect12
            // 
            this.chkDefect12.AutoSize = true;
            this.chkDefect12.Location = new System.Drawing.Point(130, 91);
            this.chkDefect12.Name = "chkDefect12";
            this.chkDefect12.Size = new System.Drawing.Size(83, 17);
            this.chkDefect12.TabIndex = 11;
            this.chkDefect12.Tag = "12";
            this.chkDefect12.Text = "Mal corte C.";
            this.chkDefect12.UseVisualStyleBackColor = true;
            // 
            // chkDefect13
            // 
            this.chkDefect13.AutoSize = true;
            this.chkDefect13.Location = new System.Drawing.Point(130, 115);
            this.chkDefect13.Name = "chkDefect13";
            this.chkDefect13.Size = new System.Drawing.Size(79, 17);
            this.chkDefect13.TabIndex = 12;
            this.chkDefect13.Tag = "13";
            this.chkDefect13.Text = "Orilla Caida";
            this.chkDefect13.UseVisualStyleBackColor = true;
            // 
            // chkDefect14
            // 
            this.chkDefect14.AutoSize = true;
            this.chkDefect14.Location = new System.Drawing.Point(130, 139);
            this.chkDefect14.Name = "chkDefect14";
            this.chkDefect14.Size = new System.Drawing.Size(64, 17);
            this.chkDefect14.TabIndex = 13;
            this.chkDefect14.Tag = "14";
            this.chkDefect14.Text = "Trensas";
            this.chkDefect14.UseVisualStyleBackColor = true;
            // 
            // chkDefect15
            // 
            this.chkDefect15.AutoSize = true;
            this.chkDefect15.Location = new System.Drawing.Point(130, 163);
            this.chkDefect15.Name = "chkDefect15";
            this.chkDefect15.Size = new System.Drawing.Size(69, 17);
            this.chkDefect15.TabIndex = 14;
            this.chkDefect15.Tag = "15";
            this.chkDefect15.Text = "Salientes";
            this.chkDefect15.UseVisualStyleBackColor = true;
            // 
            // chkDefect16
            // 
            this.chkDefect16.AutoSize = true;
            this.chkDefect16.Location = new System.Drawing.Point(130, 187);
            this.chkDefect16.Name = "chkDefect16";
            this.chkDefect16.Size = new System.Drawing.Size(90, 17);
            this.chkDefect16.TabIndex = 15;
            this.chkDefect16.Tag = "16";
            this.chkDefect16.Text = "Telescopiado";
            this.chkDefect16.UseVisualStyleBackColor = true;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(99, 191);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(139, 26);
            this.lblWidth.TabIndex = 99;
            this.lblWidth.Tag = "clearOnReload";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(99, 155);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(139, 26);
            this.lblCode.TabIndex = 99;
            this.lblCode.Tag = "clearOnReload";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.SystemColors.Window;
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(99, 121);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(139, 26);
            this.lblLength.TabIndex = 97;
            this.lblLength.Tag = "clearOnReload";
            this.lblLength.Text = "0";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(99, 87);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(139, 26);
            this.lblNetWeigth.TabIndex = 102;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbQuality
            // 
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(334, 158);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(115, 23);
            this.cmbQuality.TabIndex = 100;
            // 
            // cmbBalance
            // 
            this.cmbBalance.FormattingEnabled = true;
            this.cmbBalance.Location = new System.Drawing.Point(334, 125);
            this.cmbBalance.Name = "cmbBalance";
            this.cmbBalance.Size = new System.Drawing.Size(115, 23);
            this.cmbBalance.TabIndex = 98;
            // 
            // lblLengthLabel
            // 
            this.lblLengthLabel.AutoSize = true;
            this.lblLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthLabel.Location = new System.Drawing.Point(13, 124);
            this.lblLengthLabel.Name = "lblLengthLabel";
            this.lblLengthLabel.Size = new System.Drawing.Size(62, 20);
            this.lblLengthLabel.TabIndex = 95;
            this.lblLengthLabel.Text = "Metraje";
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(13, 90);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 94;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblWidthLabel
            // 
            this.lblWidthLabel.AutoSize = true;
            this.lblWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthLabel.Location = new System.Drawing.Point(13, 194);
            this.lblWidthLabel.Name = "lblWidthLabel";
            this.lblWidthLabel.Size = new System.Drawing.Size(55, 20);
            this.lblWidthLabel.TabIndex = 87;
            this.lblWidthLabel.Text = "Ancho";
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(245, 90);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 88;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(13, 158);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 87;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.Location = new System.Drawing.Point(245, 56);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(77, 20);
            this.lblDensity.TabIndex = 92;
            this.lblDensity.Text = "Densidad";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(245, 158);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(62, 20);
            this.lblQuality.TabIndex = 91;
            this.lblQuality.Text = "Calidad";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiameter.Location = new System.Drawing.Point(99, 53);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(139, 26);
            this.txtDiameter.TabIndex = 85;
            this.txtDiameter.Text = "0";
            this.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(245, 124);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 90;
            this.lblBalance.Text = "Balanza";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(13, 56);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(74, 20);
            this.lblDiameter.TabIndex = 89;
            this.lblDiameter.Text = "Diámetro";
            // 
            // btnBalance
            // 
            this.btnBalance.Image = global::BPS.Properties.Resources.balance;
            this.btnBalance.Location = new System.Drawing.Point(452, 90);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(25, 25);
            this.btnBalance.TabIndex = 96;
            this.ttpMetalizedCoil.SetToolTip(this.btnBalance, "Balanza");
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(334, 89);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(115, 26);
            this.txtGrossWeigth.TabIndex = 93;
            this.txtGrossWeigth.Text = "0";
            this.txtGrossWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(3, 215);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(728, 69);
            this.grpbNotes.TabIndex = 14;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(722, 50);
            this.txtNotes.TabIndex = 0;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(3, 279);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(642, 44);
            this.grpbEmpty.TabIndex = 14;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Controls.Add(this.btnCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(647, 279);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 15;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(55, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 2;
            this.ttpMetalizedCoil.SetToolTip(this.btnMainCoilExit, "Salir");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // btnCoilSave
            // 
            this.btnCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoilSave.BackgroundImage")));
            this.btnCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoilSave.Location = new System.Drawing.Point(5, 14);
            this.btnCoilSave.Name = "btnCoilSave";
            this.btnCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoilSave.TabIndex = 0;
            this.ttpMetalizedCoil.SetToolTip(this.btnCoilSave, "Guardar");
            this.btnCoilSave.UseVisualStyleBackColor = true;
            this.btnCoilSave.Click += new System.EventHandler(this.btnCoilSave_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(30, 14);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 1;
            this.ttpMetalizedCoil.SetToolTip(this.btnMainCoilCancel, "Cancelar");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // tbpLabel
            // 
            this.tbpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tbpLabel.Controls.Add(this.crvCoilLabel);
            this.tbpLabel.Location = new System.Drawing.Point(4, 24);
            this.tbpLabel.Name = "tbpLabel";
            this.tbpLabel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLabel.Size = new System.Drawing.Size(734, 326);
            this.tbpLabel.TabIndex = 2;
            this.tbpLabel.Text = "Etiqueta";
            // 
            // crvCoilLabel
            // 
            this.crvCoilLabel.ActiveViewIndex = -1;
            this.crvCoilLabel.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.crvCoilLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCoilLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCoilLabel.DisplayBackgroundEdge = false;
            this.crvCoilLabel.DisplayStatusBar = false;
            this.crvCoilLabel.DisplayToolbar = false;
            this.crvCoilLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCoilLabel.Location = new System.Drawing.Point(3, 3);
            this.crvCoilLabel.Name = "crvCoilLabel";
            this.crvCoilLabel.ShowCloseButton = false;
            this.crvCoilLabel.ShowExportButton = false;
            this.crvCoilLabel.ShowGotoPageButton = false;
            this.crvCoilLabel.ShowGroupTreeButton = false;
            this.crvCoilLabel.ShowPageNavigateButtons = false;
            this.crvCoilLabel.ShowRefreshButton = false;
            this.crvCoilLabel.ShowTextSearchButton = false;
            this.crvCoilLabel.ShowZoomButton = false;
            this.crvCoilLabel.Size = new System.Drawing.Size(728, 320);
            this.crvCoilLabel.TabIndex = 1;
            // 
            // grpbCuttingOrderInfo
            // 
            this.grpbCuttingOrderInfo.Controls.Add(this.txtUsedLenfth);
            this.grpbCuttingOrderInfo.Controls.Add(this.txtMainCoilLabel);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblUsedLength);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblMainCoil);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblPosition);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblPositionLabel);
            this.grpbCuttingOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCuttingOrderInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbCuttingOrderInfo.Name = "grpbCuttingOrderInfo";
            this.grpbCuttingOrderInfo.Size = new System.Drawing.Size(748, 49);
            this.grpbCuttingOrderInfo.TabIndex = 3;
            this.grpbCuttingOrderInfo.TabStop = false;
            this.grpbCuttingOrderInfo.Text = "Orden de metalizado";
            this.grpbCuttingOrderInfo.Enter += new System.EventHandler(this.grpbCuttingOrderInfo_Enter);
            // 
            // txtUsedLenfth
            // 
            this.txtUsedLenfth.Location = new System.Drawing.Point(557, 17);
            this.txtUsedLenfth.Name = "txtUsedLenfth";
            this.txtUsedLenfth.Size = new System.Drawing.Size(161, 21);
            this.txtUsedLenfth.TabIndex = 67;
            // 
            // txtMainCoilLabel
            // 
            this.txtMainCoilLabel.Location = new System.Drawing.Point(280, 17);
            this.txtMainCoilLabel.Name = "txtMainCoilLabel";
            this.txtMainCoilLabel.Size = new System.Drawing.Size(161, 21);
            this.txtMainCoilLabel.TabIndex = 67;
            // 
            // lblUsedLength
            // 
            this.lblUsedLength.AutoSize = true;
            this.lblUsedLength.Location = new System.Drawing.Point(447, 20);
            this.lblUsedLength.Name = "lblUsedLength";
            this.lblUsedLength.Size = new System.Drawing.Size(86, 15);
            this.lblUsedLength.TabIndex = 66;
            this.lblUsedLength.Text = "Metraje usado";
            // 
            // lblMainCoil
            // 
            this.lblMainCoil.AutoSize = true;
            this.lblMainCoil.Location = new System.Drawing.Point(170, 20);
            this.lblMainCoil.Name = "lblMainCoil";
            this.lblMainCoil.Size = new System.Drawing.Size(85, 15);
            this.lblMainCoil.TabIndex = 66;
            this.lblMainCoil.Text = "Rollo madre";
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.SystemColors.Window;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(82, 17);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(82, 21);
            this.lblPosition.TabIndex = 65;
            this.lblPosition.Tag = "clearOnReload";
            this.lblPosition.Text = "0";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Location = new System.Drawing.Point(12, 20);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(67, 15);
            this.lblPositionLabel.TabIndex = 63;
            this.lblPositionLabel.Text = "Orden Nro.";
            // 
            // frmMetallizedCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(748, 423);
            this.Controls.Add(this.grpbCoilInfo);
            this.Controls.Add(this.grpbCuttingOrderInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMetallizedCoil";
            this.Text = "frmMetallizedCoil";
            this.grpbCoilInfo.ResumeLayout(false);
            this.tbcCoil.ResumeLayout(false);
            this.tbpCoilInfo.ResumeLayout(false);
            this.tbpCoilInfo.PerformLayout();
            this.grpbDefects.ResumeLayout(false);
            this.grpbDefects.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.tbpLabel.ResumeLayout(false);
            this.grpbCuttingOrderInfo.ResumeLayout(false);
            this.grpbCuttingOrderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCoilInfo;
        private System.Windows.Forms.TabControl tbcCoil;
        private System.Windows.Forms.TabPage tbpCoilInfo;
        private System.Windows.Forms.Label txtDensity;
        private System.Windows.Forms.GroupBox grpbDefects;
        private System.Windows.Forms.CheckBox chkDefect1;
        private System.Windows.Forms.CheckBox chkDefect2;
        private System.Windows.Forms.CheckBox chkDefect3;
        private System.Windows.Forms.CheckBox chkDefect4;
        private System.Windows.Forms.CheckBox chkDefect5;
        private System.Windows.Forms.CheckBox chkDefect6;
        private System.Windows.Forms.CheckBox chkDefect7;
        private System.Windows.Forms.CheckBox chkDefect8;
        private System.Windows.Forms.CheckBox chkDefect9;
        private System.Windows.Forms.CheckBox chkDefect10;
        private System.Windows.Forms.CheckBox chkDefect11;
        private System.Windows.Forms.CheckBox chkDefect12;
        private System.Windows.Forms.CheckBox chkDefect13;
        private System.Windows.Forms.CheckBox chkDefect14;
        private System.Windows.Forms.CheckBox chkDefect15;
        private System.Windows.Forms.CheckBox chkDefect16;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.ComboBox cmbBalance;
        private System.Windows.Forms.Label lblLengthLabel;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblWidthLabel;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.TextBox txtGrossWeigth;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnCoilSave;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.TabPage tbpLabel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCoilLabel;
        private System.Windows.Forms.GroupBox grpbCuttingOrderInfo;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblFulmNameLabel;
        private System.Windows.Forms.TextBox txtMainCoilLabel;
        private System.Windows.Forms.Label lblMainCoil;
        private System.Windows.Forms.TextBox txtUsedLenfth;
        private System.Windows.Forms.Label lblUsedLength;
        private System.Windows.Forms.ToolTip ttpMetalizedCoil;
    }
}