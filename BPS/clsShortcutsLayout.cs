using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    class clsShortcutsLayout
    {
        //Attibutes

        private Panel scl_pnlShortcuts;
        private List<Button> scl_lstBtnShortCuts;
        private List<Label> scl_lstLblShortCutsLabels;

        //Properties
        public Panel pnlShortcuts { get { return scl_pnlShortcuts; } set { scl_pnlShortcuts = value; } }

        public List<Button> lstBtnShorcuts { get { return scl_lstBtnShortCuts; } set { scl_lstBtnShortCuts = value; } }

        public List<Label> lstLblShortcutLabels { get { return scl_lstLblShortCutsLabels; } set { scl_lstLblShortCutsLabels = value; } }

        //Constructor

        public clsShortcutsLayout()
        {
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 0);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Size = new System.Drawing.Size(95, 458);
            this.pnlShortcuts.TabIndex = 0;
            this.pnlShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lstBtnShorcuts = new List<Button>();
            this.lstLblShortcutLabels = new List<Label>();
        }

        public void addButton(int codsec, string label, string function)
        {
            Button btnShortCut = new Button();
            Label lblShortcutLabel = new Label();

            // 
            // btnMainCoilRegistration
            // 
            btnShortCut.Image = global::BPS.Properties.Resources.mainCoil1;
            btnShortCut.Location = new System.Drawing.Point(27, 12 + (lstBtnShorcuts.Count * 63));
            btnShortCut.Name = "btnShortCut" + lstBtnShorcuts.Count.ToString();
            btnShortCut.Size = new System.Drawing.Size(40, 40);
            btnShortCut.TabIndex = lstBtnShorcuts.Count;
            btnShortCut.UseVisualStyleBackColor = true;
            btnShortCut.Tag = function + " " + codsec.ToString();
            // 
            // lblMachineName
            // 
            lblShortcutLabel.Location = new System.Drawing.Point(12, 55 + (lstBtnShorcuts.Count * 63));
            lblShortcutLabel.Name = "lblShortcutLabel" + lstBtnShorcuts.Count.ToString();
            lblShortcutLabel.Size = new System.Drawing.Size(70, 17);
            lblShortcutLabel.TabIndex = 1;
            lblShortcutLabel.Text = label;
            lblShortcutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lstBtnShorcuts.Add(btnShortCut);
            lstLblShortcutLabels.Add(lblShortcutLabel);
        }

        public void addCuttingButton(int codsec, string label, string function)
        {
            Button btnShortCut = new Button();
            Label lblShortcutLabel = new Label();
            Label lblSeparator = new Label();
            Label lblTitle = new Label();


            if (function == "coilRegistration")
            {
                lblTitle.Location = new System.Drawing.Point(6, (lstBtnShorcuts.Count * 85));
                lblTitle.Name = "lblTitle" + lstBtnShorcuts.Count.ToString();
                lblTitle.Size = new System.Drawing.Size(80, 17);
                lblTitle.TabIndex = 1;
                lblTitle.Text = label;
                lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                lstLblShortcutLabels.Add(lblTitle);
            }

            // 
            // btnMainCoilRegistration
            // 
            if (function == "coilRegistration")
            {
                btnShortCut.Image = global::BPS.Properties.Resources.add_coil24;
                lblShortcutLabel.Text = "Bobinas";
            }
            else
            {
                btnShortCut.Image = global::BPS.Properties.Resources.pallet_24;
                lblShortcutLabel.Text = "Pallets";
            }
            btnShortCut.Location = new System.Drawing.Point(27, 17 + (lstBtnShorcuts.Count * 85));
            btnShortCut.Name = "btnShortCut" + lstBtnShorcuts.Count.ToString();
            btnShortCut.Size = new System.Drawing.Size(40, 40);
            btnShortCut.TabIndex = lstBtnShorcuts.Count;
            btnShortCut.UseVisualStyleBackColor = true;
            btnShortCut.Tag = function + " " + codsec.ToString();
            // 
            // lblMachineName
            // 
            lblShortcutLabel.Location = new System.Drawing.Point(12, 60 + (lstBtnShorcuts.Count * 85));
            lblShortcutLabel.Name = "lblShortcutLabel" + lstBtnShorcuts.Count.ToString();
            lblShortcutLabel.Size = new System.Drawing.Size(70, 17);
            lblShortcutLabel.TabIndex = 1;
            lblShortcutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lstBtnShorcuts.Add(btnShortCut);
            lstLblShortcutLabels.Add(lblShortcutLabel);

            if (function == "palletRegistration")
            {
                lblSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                lblSeparator.Location = new System.Drawing.Point(6, -5 + (lstBtnShorcuts.Count * 85));
                lblSeparator.Name = "lblSeparator" + lstBtnShorcuts.Count.ToString();
                lblSeparator.Size = new System.Drawing.Size(80, 4);
                lblSeparator.TabIndex = 2;
                lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                lstLblShortcutLabels.Add(lblSeparator);
            }
        }

        public void addButtonsAndLabelsToPanel()
        {
            for (int i = 0; i < lstLblShortcutLabels.Count; i++)
            {
                this.pnlShortcuts.Controls.Add(this.lstLblShortcutLabels[i]);
            }
            for (int i = 0; i < lstBtnShorcuts.Count; i++)
            {
                this.pnlShortcuts.Controls.Add(this.lstBtnShorcuts[i]);
            }
        }

        public static Panel getMainCoilRegistrationShortCuts()
        {
            clsShortcutsLayout objShortCutsLayout = new clsShortcutsLayout();
            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();

            for (int i = 0; i < lstMachine.Count; i++)
                objShortCutsLayout.addButton(lstMachine[i].codsec, lstMachine[i].Extruder.name, "mainCoilRegistration");

            objShortCutsLayout.addButtonsAndLabelsToPanel();


            return objShortCutsLayout.pnlShortcuts;
        }

        public static Panel getMainCoilRegistrationShortCuts(int fkplant)
        {
            clsShortcutsLayout objShortCutsLayout = new clsShortcutsLayout();
            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();

            for (int i = 0; i < lstMachine.Count; i++)
            {
                if(new clsSector(lstMachine[i].fkSector).fkPlant==fkplant)
                {
                    objShortCutsLayout.addButton(lstMachine[i].codsec, lstMachine[i].Extruder.name, "mainCoilRegistration");
                }
            }
                

            objShortCutsLayout.addButtonsAndLabelsToPanel();


            return objShortCutsLayout.pnlShortcuts;
        }

        public static Panel getCuttingRegistrationShortCuts()
        {
            clsShortcutsLayout objShortCutsLayout = new clsShortcutsLayout();
            List<clsMachine> lstMachine = clsMachine.getCutterMachineList();

            for (int i = 0; i < lstMachine.Count; i++)
            {
                objShortCutsLayout.addCuttingButton(lstMachine[i].codsec, lstMachine[i].Cutter.name, "coilRegistration");
                objShortCutsLayout.addCuttingButton(lstMachine[i].codsec, lstMachine[i].Cutter.name, "palletRegistration");
            }

            objShortCutsLayout.addButtonsAndLabelsToPanel();


            return objShortCutsLayout.pnlShortcuts;
        }
        public static void mainCoilRegistration(int machineCodsec)
        {
            frmMainCoil winMainCoil = new frmMainCoil(machineCodsec);
            winMainCoil.Show();
        }
    }
}
