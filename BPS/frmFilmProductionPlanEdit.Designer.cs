namespace BPS
{
    partial class frmFilmProductionPlanEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmProductionPlanEdit));
            this.txtKPH = new System.Windows.Forms.TextBox();
            this.lblKPH = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblProductionOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.grpbActionsPO = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch2 = new System.Windows.Forms.GroupBox();
            this.lblProductionOrderNumber = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.lblTotalWeigthLabel = new System.Windows.Forms.Label();
            this.lblIdleTime = new System.Windows.Forms.Label();
            this.txtIdleTime = new System.Windows.Forms.TextBox();
            this.txtWidths = new System.Windows.Forms.TextBox();
            this.lblWidths = new System.Windows.Forms.Label();
            this.ttpProgramationExtruction = new System.Windows.Forms.ToolTip(this.components);
            this.txtTotalWeigth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpbActionsPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKPH
            // 
            this.txtKPH.Location = new System.Drawing.Point(150, 108);
            this.txtKPH.Name = "txtKPH";
            this.txtKPH.Size = new System.Drawing.Size(116, 21);
            this.txtKPH.TabIndex = 7;
            this.txtKPH.TextChanged += new System.EventHandler(this.txtKPH_TextChanged);
            // 
            // lblKPH
            // 
            this.lblKPH.AutoSize = true;
            this.lblKPH.Location = new System.Drawing.Point(18, 111);
            this.lblKPH.Name = "lblKPH";
            this.lblKPH.Size = new System.Drawing.Size(44, 15);
            this.lblKPH.TabIndex = 6;
            this.lblKPH.Text = "Kg./Hr.";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(18, 49);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 2;
            this.lblMachine.Text = "Máquina";
            // 
            // lblProductionOrderNumberLabel
            // 
            this.lblProductionOrderNumberLabel.AutoSize = true;
            this.lblProductionOrderNumberLabel.Location = new System.Drawing.Point(18, 18);
            this.lblProductionOrderNumberLabel.Name = "lblProductionOrderNumberLabel";
            this.lblProductionOrderNumberLabel.Size = new System.Drawing.Size(100, 15);
            this.lblProductionOrderNumberLabel.TabIndex = 0;
            this.lblProductionOrderNumberLabel.Text = "O. de producción";
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(18, 173);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(126, 15);
            this.lblInitDate.TabIndex = 10;
            this.lblInitDate.Text = "Fecha y hora de inicio";
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(150, 170);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(204, 21);
            this.dtpInitDate.TabIndex = 11;
            this.dtpInitDate.ValueChanged += new System.EventHandler(this.dtpInitDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(18, 204);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 15);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "Fecha y hora fin";
            // 
            // grpbActionsPO
            // 
            this.grpbActionsPO.Controls.Add(this.btnSave);
            this.grpbActionsPO.Controls.Add(this.btnClose);
            this.grpbActionsPO.Location = new System.Drawing.Point(317, 375);
            this.grpbActionsPO.Name = "grpbActionsPO";
            this.grpbActionsPO.Size = new System.Drawing.Size(54, 43);
            this.grpbActionsPO.TabIndex = 22;
            this.grpbActionsPO.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(2, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 0;
            this.ttpProgramationExtruction.SetToolTip(this.btnSave, "Guardar Programación de Extrusión");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(27, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.ttpProgramationExtruction.SetToolTip(this.btnClose, "Salir Programación de Extrusión");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbSearch2
            // 
            this.grpbSearch2.Location = new System.Drawing.Point(3, 375);
            this.grpbSearch2.Name = "grpbSearch2";
            this.grpbSearch2.Size = new System.Drawing.Size(312, 43);
            this.grpbSearch2.TabIndex = 21;
            this.grpbSearch2.TabStop = false;
            // 
            // lblProductionOrderNumber
            // 
            this.lblProductionOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblProductionOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductionOrderNumber.Location = new System.Drawing.Point(150, 15);
            this.lblProductionOrderNumber.Name = "lblProductionOrderNumber";
            this.lblProductionOrderNumber.Size = new System.Drawing.Size(116, 21);
            this.lblProductionOrderNumber.TabIndex = 1;
            this.lblProductionOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMachineName
            // 
            this.lblMachineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachineName.Location = new System.Drawing.Point(150, 46);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(204, 21);
            this.lblMachineName.TabIndex = 3;
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(23, 335);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(327, 39);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "Nota: Las fechas de las ordenes que estan planificadas \r\n         a continuación " +
    "de la presente serán cambiadas \r\n         automaticamente\r\n";
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.BackColor = System.Drawing.SystemColors.Window;
            this.lblEndDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndDateTime.Location = new System.Drawing.Point(150, 201);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(204, 21);
            this.lblEndDateTime.TabIndex = 13;
            this.lblEndDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalWeigthLabel
            // 
            this.lblTotalWeigthLabel.AutoSize = true;
            this.lblTotalWeigthLabel.Location = new System.Drawing.Point(18, 80);
            this.lblTotalWeigthLabel.Name = "lblTotalWeigthLabel";
            this.lblTotalWeigthLabel.Size = new System.Drawing.Size(81, 15);
            this.lblTotalWeigthLabel.TabIndex = 4;
            this.lblTotalWeigthLabel.Text = "Total a extruir";
            // 
            // lblIdleTime
            // 
            this.lblIdleTime.AutoSize = true;
            this.lblIdleTime.Location = new System.Drawing.Point(18, 142);
            this.lblIdleTime.Name = "lblIdleTime";
            this.lblIdleTime.Size = new System.Drawing.Size(91, 15);
            this.lblIdleTime.TabIndex = 8;
            this.lblIdleTime.Text = "Tiempo Muerto";
            // 
            // txtIdleTime
            // 
            this.txtIdleTime.Location = new System.Drawing.Point(150, 139);
            this.txtIdleTime.Name = "txtIdleTime";
            this.txtIdleTime.Size = new System.Drawing.Size(116, 21);
            this.txtIdleTime.TabIndex = 9;
            this.txtIdleTime.TextChanged += new System.EventHandler(this.txtIdleTime_TextChanged);
            // 
            // txtWidths
            // 
            this.txtWidths.Location = new System.Drawing.Point(150, 232);
            this.txtWidths.Name = "txtWidths";
            this.txtWidths.Size = new System.Drawing.Size(204, 21);
            this.txtWidths.TabIndex = 15;
            // 
            // lblWidths
            // 
            this.lblWidths.AutoSize = true;
            this.lblWidths.Location = new System.Drawing.Point(18, 235);
            this.lblWidths.Name = "lblWidths";
            this.lblWidths.Size = new System.Drawing.Size(108, 15);
            this.lblWidths.TabIndex = 14;
            this.lblWidths.Text = "Anchos solicitados";
            // 
            // txtTotalWeigth
            // 
            this.txtTotalWeigth.Location = new System.Drawing.Point(150, 77);
            this.txtTotalWeigth.Name = "txtTotalWeigth";
            this.txtTotalWeigth.Size = new System.Drawing.Size(116, 21);
            this.txtTotalWeigth.TabIndex = 5;
            this.txtTotalWeigth.TextChanged += new System.EventHandler(this.txtTotalWeigth_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(18, 266);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 15);
            this.lblLength.TabIndex = 16;
            this.lblLength.Text = "Metraje";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(150, 263);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(204, 21);
            this.txtLength.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Observaciones";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(150, 294);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(204, 21);
            this.txtNotes.TabIndex = 19;
            // 
            // frmFilmProductionPlanEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 418);
            this.Controls.Add(this.txtTotalWeigth);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtWidths);
            this.Controls.Add(this.lblWidths);
            this.Controls.Add(this.lblTotalWeigthLabel);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblEndDateTime);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.lblProductionOrderNumber);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblInitDate);
            this.Controls.Add(this.dtpInitDate);
            this.Controls.Add(this.lblProductionOrderNumberLabel);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.txtIdleTime);
            this.Controls.Add(this.lblIdleTime);
            this.Controls.Add(this.txtKPH);
            this.Controls.Add(this.lblKPH);
            this.Controls.Add(this.grpbActionsPO);
            this.Controls.Add(this.grpbSearch2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilmProductionPlanEdit";
            this.ShowInTaskbar = false;
            this.Text = "Programación de extrusión";
            this.Load += new System.EventHandler(this.frmFilmProductionPlanEdit_Load);
            this.grpbActionsPO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKPH;
        private System.Windows.Forms.Label lblKPH;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblProductionOrderNumberLabel;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.GroupBox grpbActionsPO;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbSearch2;
        private System.Windows.Forms.Label lblProductionOrderNumber;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblEndDateTime;
        private System.Windows.Forms.Label lblTotalWeigthLabel;
        private System.Windows.Forms.Label lblIdleTime;
        private System.Windows.Forms.TextBox txtIdleTime;
        private System.Windows.Forms.TextBox txtWidths;
        private System.Windows.Forms.Label lblWidths;
        private System.Windows.Forms.ToolTip ttpProgramationExtruction;
        private System.Windows.Forms.TextBox txtTotalWeigth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
    }
}