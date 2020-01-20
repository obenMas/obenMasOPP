namespace BPS
{
    partial class frmSystemConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemConfig));
            this.sptcConfig = new System.Windows.Forms.SplitContainer();
            this.trvConfigs = new System.Windows.Forms.TreeView();
            this.pnlMetallizer = new System.Windows.Forms.Panel();
            this.grpbMetallizerForm = new System.Windows.Forms.GroupBox();
            this.txtMetalizedNumber = new System.Windows.Forms.TextBox();
            this.lblMetalizedNumber = new System.Windows.Forms.Label();
            this.txtMetallizerMaxDiameter = new System.Windows.Forms.TextBox();
            this.lblMetallizerMaxDiameter = new System.Windows.Forms.Label();
            this.txtMetallizerMaxFilmWidth = new System.Windows.Forms.TextBox();
            this.lblMetallizerMaxFilmWidth = new System.Windows.Forms.Label();
            this.cmbMetallizerLine = new System.Windows.Forms.ComboBox();
            this.lblMetallizerLine = new System.Windows.Forms.Label();
            this.cmbxMetallizerPlant = new System.Windows.Forms.ComboBox();
            this.lblMetallizerPlant = new System.Windows.Forms.Label();
            this.cmbxMetallizerStatus = new System.Windows.Forms.ComboBox();
            this.lblMetallizerStatus = new System.Windows.Forms.Label();
            this.cmbxMetallizerSector = new System.Windows.Forms.ComboBox();
            this.lblMetallizerSector = new System.Windows.Forms.Label();
            this.btnMetallizerCancel = new System.Windows.Forms.Button();
            this.btnMetallizerSave = new System.Windows.Forms.Button();
            this.txtMetallizerMaxVelocity = new System.Windows.Forms.TextBox();
            this.txtMetallizerMinFilmWidth = new System.Windows.Forms.TextBox();
            this.lblMetallizerMaxVelocity = new System.Windows.Forms.Label();
            this.lblMetallizerMinFilmWidth = new System.Windows.Forms.Label();
            this.lblMetallizerName = new System.Windows.Forms.Label();
            this.txtMetallizerName = new System.Windows.Forms.TextBox();
            this.grpbMetallizerList = new System.Windows.Forms.GroupBox();
            this.dgvMetallizer = new System.Windows.Forms.DataGridView();
            this.clmMetallizerCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerMinFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerMaxFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerMaxVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerMaxDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMetallizerDelete = new System.Windows.Forms.Button();
            this.btnMetallizerAdd = new System.Windows.Forms.Button();
            this.btnMetallizerEdit = new System.Windows.Forms.Button();
            this.pnlCellarByExtruder = new System.Windows.Forms.Panel();
            this.grpbCellarByExtruderList = new System.Windows.Forms.GroupBox();
            this.btnCellarByExtDelete = new System.Windows.Forms.Button();
            this.btnCellarByExtAdd = new System.Windows.Forms.Button();
            this.btnCellarByExtEdit = new System.Windows.Forms.Button();
            this.dgvCellarbyMachine = new System.Windows.Forms.DataGridView();
            this.clmCellarByExtruderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarByExtruderCellarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarByExtruderExtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCellarByExtruderForm = new System.Windows.Forms.GroupBox();
            this.cmbCellarByExtLineName = new System.Windows.Forms.ComboBox();
            this.lblCellarByExtLineName = new System.Windows.Forms.Label();
            this.cmbCellarByExtCellarName = new System.Windows.Forms.ComboBox();
            this.lblCellarByExtCellarName = new System.Windows.Forms.Label();
            this.btnCellarByExtCancel = new System.Windows.Forms.Button();
            this.btnCellarByExtSave = new System.Windows.Forms.Button();
            this.pnlExtruders = new System.Windows.Forms.Panel();
            this.grpbExtruderList = new System.Windows.Forms.GroupBox();
            this.btnExtruderDelete = new System.Windows.Forms.Button();
            this.btnExtruderAdd = new System.Windows.Forms.Button();
            this.btnExtruderEdit = new System.Windows.Forms.Button();
            this.dgvExtruder = new System.Windows.Forms.DataGridView();
            this.clmExtruderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderminFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtrudermaxFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtrudermaxVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderCoilNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderKilogramsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderProductionLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbExtruderForm = new System.Windows.Forms.GroupBox();
            this.cmbExtruderLine = new System.Windows.Forms.ComboBox();
            this.lblExtruderLine = new System.Windows.Forms.Label();
            this.txtExtruderMaxVelocity = new System.Windows.Forms.TextBox();
            this.lblExtruderMaxVelocity = new System.Windows.Forms.Label();
            this.txtExtruderMaxFilmWidth = new System.Windows.Forms.TextBox();
            this.lblExtruderMaxFilmWidth = new System.Windows.Forms.Label();
            this.cmbxExtruderPlant = new System.Windows.Forms.ComboBox();
            this.lblExtruderPlant = new System.Windows.Forms.Label();
            this.cmbxExtruderStatus = new System.Windows.Forms.ComboBox();
            this.lblExtruderStatus = new System.Windows.Forms.Label();
            this.cmbxExtruderSector = new System.Windows.Forms.ComboBox();
            this.lblExtruderSector = new System.Windows.Forms.Label();
            this.btnExtruderCancel = new System.Windows.Forms.Button();
            this.btnExtruderSave = new System.Windows.Forms.Button();
            this.txtExtruderKilogramsPerHour = new System.Windows.Forms.TextBox();
            this.txtExtruderMinFilmWidth = new System.Windows.Forms.TextBox();
            this.txtExtruderCoilNumber = new System.Windows.Forms.TextBox();
            this.txtExtruderName = new System.Windows.Forms.TextBox();
            this.lblExtruderKilogramsPerHour = new System.Windows.Forms.Label();
            this.lblExtruderCoilNumber = new System.Windows.Forms.Label();
            this.lblExtruderMinFilmWidth = new System.Windows.Forms.Label();
            this.lblExtruderName = new System.Windows.Forms.Label();
            this.pnlMold = new System.Windows.Forms.Panel();
            this.grpbMoldView = new System.Windows.Forms.GroupBox();
            this.btnMoldDelete = new System.Windows.Forms.Button();
            this.btnMoldAdd = new System.Windows.Forms.Button();
            this.btnMoldEdit = new System.Windows.Forms.Button();
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.clmMoldCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoldDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoldProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoldCavityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbMoldForm = new System.Windows.Forms.GroupBox();
            this.cmbMoldProduct = new System.Windows.Forms.ComboBox();
            this.txtMoldDescription = new System.Windows.Forms.TextBox();
            this.lblMoldDescription = new System.Windows.Forms.Label();
            this.txtMoldCavityNumber = new System.Windows.Forms.TextBox();
            this.lblMoldCavityNumber = new System.Windows.Forms.Label();
            this.btnMoldCancel = new System.Windows.Forms.Button();
            this.btnMoldSave = new System.Windows.Forms.Button();
            this.txtMoldName = new System.Windows.Forms.TextBox();
            this.lblMoldProduct = new System.Windows.Forms.Label();
            this.lblMoldName = new System.Windows.Forms.Label();
            this.pnlThermExtruder = new System.Windows.Forms.Panel();
            this.grpbThermExtruderView = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThermExtruderAdd = new System.Windows.Forms.Button();
            this.btnThermExtruderEdit = new System.Windows.Forms.Button();
            this.dgvThermExtruder = new System.Windows.Forms.DataGridView();
            this.clmThermExtruderCodesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderMinFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderMaxFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderMaxVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderCoilNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermExtruderKgPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbThermExtruderForm = new System.Windows.Forms.GroupBox();
            this.txtThermExtruderKgPerHour = new System.Windows.Forms.TextBox();
            this.txtThermExtruderCoilNumbers = new System.Windows.Forms.TextBox();
            this.lblThermExtruderKgPerHour = new System.Windows.Forms.Label();
            this.lblThermExtruderCoilNumbers = new System.Windows.Forms.Label();
            this.txtThermExtruderMaxVelocity = new System.Windows.Forms.TextBox();
            this.txtThermExtruderMaxFilmWidth = new System.Windows.Forms.TextBox();
            this.lblThermExtruderMaxVelocity = new System.Windows.Forms.Label();
            this.lblThermExtruderMaxFilmWidth = new System.Windows.Forms.Label();
            this.txtThermExtruderMinFilmWidth = new System.Windows.Forms.TextBox();
            this.btnThermExtruderCancel = new System.Windows.Forms.Button();
            this.btnThermExtruderSave = new System.Windows.Forms.Button();
            this.txtThermExtruderName = new System.Windows.Forms.TextBox();
            this.lblThermExtruderMinFilmWidth = new System.Windows.Forms.Label();
            this.lblThermExtruderName = new System.Windows.Forms.Label();
            this.pnlThermByExtruder = new System.Windows.Forms.Panel();
            this.pnlThermDefects = new System.Windows.Forms.Panel();
            this.grpbThermDefectsView = new System.Windows.Forms.GroupBox();
            this.btnThermDefectsDelete = new System.Windows.Forms.Button();
            this.btnThermDefectsAdd = new System.Windows.Forms.Button();
            this.btnThermDefectsEdit = new System.Windows.Forms.Button();
            this.dgvThermDefect = new System.Windows.Forms.DataGridView();
            this.clmThermDefectsCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermDefectsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermDefectsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbThermDefectsForm = new System.Windows.Forms.GroupBox();
            this.txtThermDefectDescription = new System.Windows.Forms.TextBox();
            this.lblThermDefectDescription = new System.Windows.Forms.Label();
            this.btnThermDefectsCancel = new System.Windows.Forms.Button();
            this.btnThermDefectsSave = new System.Windows.Forms.Button();
            this.txtThermDefectName = new System.Windows.Forms.TextBox();
            this.lblThermDefectName = new System.Windows.Forms.Label();
            this.pnlSupply = new System.Windows.Forms.Panel();
            this.grpbSupply = new System.Windows.Forms.GroupBox();
            this.btnSupplyAdd = new System.Windows.Forms.Button();
            this.btnSupplyEdit = new System.Windows.Forms.Button();
            this.btnSupplyDelete = new System.Windows.Forms.Button();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.clmSupplyCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSupplyForm = new System.Windows.Forms.GroupBox();
            this.btnSupplyCancel = new System.Windows.Forms.Button();
            this.btnSupplySave = new System.Windows.Forms.Button();
            this.txtSupplyNotes = new System.Windows.Forms.TextBox();
            this.lblSupplyNotes = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtSupplyCode = new System.Windows.Forms.TextBox();
            this.lblSupplyCode = new System.Windows.Forms.Label();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.cmbSupplyEntity = new System.Windows.Forms.ComboBox();
            this.lblSupplyEntity = new System.Windows.Forms.Label();
            this.pnlThermoformed = new System.Windows.Forms.Panel();
            this.grpbThermoformedDetail = new System.Windows.Forms.GroupBox();
            this.btnThermoformedDelete = new System.Windows.Forms.Button();
            this.btnThermoformedAdd = new System.Windows.Forms.Button();
            this.btnThermoformedEdit = new System.Windows.Forms.Button();
            this.dgvThermoformed = new System.Windows.Forms.DataGridView();
            this.clmThermoformedCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermoformedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermoformedFilmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermoformedMinHitsPerMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermoformedMaxHitsPerMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThermoformedIncludeExtruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbThermoformedForm = new System.Windows.Forms.GroupBox();
            this.chbxThermoformedIncludeExtruder = new System.Windows.Forms.CheckBox();
            this.txtThermoformedMaxHitsPerMinute = new System.Windows.Forms.TextBox();
            this.lblThermoformedMaxHitsPerMinute = new System.Windows.Forms.Label();
            this.txtThermoformedMinHitsPerMinute = new System.Windows.Forms.TextBox();
            this.lblThermoformedMinHitsPerMinute = new System.Windows.Forms.Label();
            this.btnThermoformedCancel = new System.Windows.Forms.Button();
            this.btnThermoformedSave = new System.Windows.Forms.Button();
            this.txtThermoformedFilmWidth = new System.Windows.Forms.TextBox();
            this.txtThermoformedName = new System.Windows.Forms.TextBox();
            this.lblThermoformedFilmWidth = new System.Windows.Forms.Label();
            this.lblThermoformedName = new System.Windows.Forms.Label();
            this.pnlOunce = new System.Windows.Forms.Panel();
            this.grpbOunceForm = new System.Windows.Forms.GroupBox();
            this.btnOunceCancel = new System.Windows.Forms.Button();
            this.btnOunceSave = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.grpbOunceView = new System.Windows.Forms.GroupBox();
            this.btnOunceAdd = new System.Windows.Forms.Button();
            this.dgvOunce = new System.Windows.Forms.DataGridView();
            this.clmOunceCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOunceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOunceEdit = new System.Windows.Forms.Button();
            this.btnOunceDelete = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.grpbColorForm = new System.Windows.Forms.GroupBox();
            this.btnColorCancel = new System.Windows.Forms.Button();
            this.btnColorSave = new System.Windows.Forms.Button();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.lblColorName = new System.Windows.Forms.Label();
            this.grpbColorView = new System.Windows.Forms.GroupBox();
            this.btnColorAdd = new System.Windows.Forms.Button();
            this.dgvColorDetail = new System.Windows.Forms.DataGridView();
            this.clmColorCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnColorEdit = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.pnlCore = new System.Windows.Forms.Panel();
            this.grpbCoreForm = new System.Windows.Forms.GroupBox();
            this.btnCoreCancel = new System.Windows.Forms.Button();
            this.btnCoreSave = new System.Windows.Forms.Button();
            this.txtCoreValue = new System.Windows.Forms.TextBox();
            this.txtCoreName = new System.Windows.Forms.TextBox();
            this.lblCoreValue = new System.Windows.Forms.Label();
            this.lblCoreName = new System.Windows.Forms.Label();
            this.grpbCoreList = new System.Windows.Forms.GroupBox();
            this.btnCoreAdd = new System.Windows.Forms.Button();
            this.dgvCore = new System.Windows.Forms.DataGridView();
            this.clmCoreCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCoreEdit = new System.Windows.Forms.Button();
            this.btnCoreDelete = new System.Windows.Forms.Button();
            this.pnlBopp = new System.Windows.Forms.Panel();
            this.tctrlBoppFilm = new System.Windows.Forms.TabControl();
            this.tbpFamily = new System.Windows.Forms.TabPage();
            this.grpbFamilyList = new System.Windows.Forms.GroupBox();
            this.btnBoppFamilyAdd = new System.Windows.Forms.Button();
            this.btnBoppFamilyEdit = new System.Windows.Forms.Button();
            this.btnBoppFamilyDelete = new System.Windows.Forms.Button();
            this.dgvFamily = new System.Windows.Forms.DataGridView();
            this.clmFamilyCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFamilyForm = new System.Windows.Forms.GroupBox();
            this.btnBoppFamilySave = new System.Windows.Forms.Button();
            this.btnBoppFamilyCancel = new System.Windows.Forms.Button();
            this.txtBoppFamilyAbbreviation = new System.Windows.Forms.TextBox();
            this.txtBoppFamilyName = new System.Windows.Forms.TextBox();
            this.lblBoppFamilyAvbreviation = new System.Windows.Forms.Label();
            this.lblBoppFamilyName = new System.Windows.Forms.Label();
            this.tbpSeal = new System.Windows.Forms.TabPage();
            this.grpbSealList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBoppSealAdd = new System.Windows.Forms.Button();
            this.btnBoppSealEdit = new System.Windows.Forms.Button();
            this.btnBoppSealDelete = new System.Windows.Forms.Button();
            this.dgvSeal = new System.Windows.Forms.DataGridView();
            this.clmSealCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSealAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSealForm = new System.Windows.Forms.GroupBox();
            this.txtSealName = new System.Windows.Forms.TextBox();
            this.txtSealAbbreviation = new System.Windows.Forms.TextBox();
            this.lblSealAbbreviation = new System.Windows.Forms.Label();
            this.lblSealName = new System.Windows.Forms.Label();
            this.btnBoppSealSave = new System.Windows.Forms.Button();
            this.btnBoppSealCancel = new System.Windows.Forms.Button();
            this.tbpBoppAdditivation = new System.Windows.Forms.TabPage();
            this.grpbAdditivationList = new System.Windows.Forms.GroupBox();
            this.btnBoppAdditivationDelete = new System.Windows.Forms.Button();
            this.btnBoppAdditivationEdit = new System.Windows.Forms.Button();
            this.btnBoppAdditivationAdd = new System.Windows.Forms.Button();
            this.dgvAdditivation = new System.Windows.Forms.DataGridView();
            this.clmAdditivationCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdditivationAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdditivationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdditivationForBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdditivationForCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbAdditivationForm = new System.Windows.Forms.GroupBox();
            this.chbxCastAdditivation = new System.Windows.Forms.CheckBox();
            this.chbxBoppAdditivation = new System.Windows.Forms.CheckBox();
            this.btnBoppAdditivationCancel = new System.Windows.Forms.Button();
            this.btnBoppAdditivationSave = new System.Windows.Forms.Button();
            this.txtAdditivationName = new System.Windows.Forms.TextBox();
            this.txtAdditivationAbbreviation = new System.Windows.Forms.TextBox();
            this.lblAdditivationAbbreviation = new System.Windows.Forms.Label();
            this.lblAdditivationName = new System.Windows.Forms.Label();
            this.tbpBoppThickness = new System.Windows.Forms.TabPage();
            this.grpbThicknessForm = new System.Windows.Forms.GroupBox();
            this.btnBoppThicknessCancel = new System.Windows.Forms.Button();
            this.btnBoppThicknessSave = new System.Windows.Forms.Button();
            this.txtThicknessValue = new System.Windows.Forms.TextBox();
            this.lblThicknessValue = new System.Windows.Forms.Label();
            this.grpbox2 = new System.Windows.Forms.GroupBox();
            this.grpbThicknessList = new System.Windows.Forms.GroupBox();
            this.btnBoppThicknessDelete = new System.Windows.Forms.Button();
            this.btnBoppThicknessEdit = new System.Windows.Forms.Button();
            this.btnBoppThicknessAdd = new System.Windows.Forms.Button();
            this.dgvThickness = new System.Windows.Forms.DataGridView();
            this.clmThicknessCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThicknessValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpBoppTreatment = new System.Windows.Forms.TabPage();
            this.grpbTreatmentForm = new System.Windows.Forms.GroupBox();
            this.txtTreatmentAbbreviation = new System.Windows.Forms.TextBox();
            this.chbxCoatingTreatment = new System.Windows.Forms.CheckBox();
            this.chbxCastTreatment = new System.Windows.Forms.CheckBox();
            this.chbxBoppTreatment = new System.Windows.Forms.CheckBox();
            this.txtTreatmentName = new System.Windows.Forms.TextBox();
            this.lblTreatmentAbbreviation = new System.Windows.Forms.Label();
            this.lblTreatmentName = new System.Windows.Forms.Label();
            this.btnBoppTreatmentCancel = new System.Windows.Forms.Button();
            this.btnBoppTreatmentSave = new System.Windows.Forms.Button();
            this.grpbTreatmentList = new System.Windows.Forms.GroupBox();
            this.btnBoppTreatmentDelete = new System.Windows.Forms.Button();
            this.btnBoppTreatmentEdit = new System.Windows.Forms.Button();
            this.btnBoppTreatmentAdd = new System.Windows.Forms.Button();
            this.dgvTreatment = new System.Windows.Forms.DataGridView();
            this.clmTreatmentCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInning = new System.Windows.Forms.Panel();
            this.grpbInningForm = new System.Windows.Forms.GroupBox();
            this.btnInningCancel = new System.Windows.Forms.Button();
            this.btnInningSave = new System.Windows.Forms.Button();
            this.txtInningDescription = new System.Windows.Forms.TextBox();
            this.lblInningDescription = new System.Windows.Forms.Label();
            this.txtInningName = new System.Windows.Forms.TextBox();
            this.lblInningName = new System.Windows.Forms.Label();
            this.grpbInningList = new System.Windows.Forms.GroupBox();
            this.btnInningDelete = new System.Windows.Forms.Button();
            this.btnInningEdit = new System.Windows.Forms.Button();
            this.btnInningAdd = new System.Windows.Forms.Button();
            this.dgvInning = new System.Windows.Forms.DataGridView();
            this.clmInningCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInningName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInningDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRole = new System.Windows.Forms.Panel();
            this.grpbRoleForm = new System.Windows.Forms.GroupBox();
            this.btnRoleCancel = new System.Windows.Forms.Button();
            this.btnRoleSave = new System.Windows.Forms.Button();
            this.txtRoleDescription = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleDescription = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.grpbRoleList = new System.Windows.Forms.GroupBox();
            this.btnRoleDelete = new System.Windows.Forms.Button();
            this.btnRoleEdit = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.clmRoleCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRawMaterial = new System.Windows.Forms.Panel();
            this.grpbRawMaterialForm = new System.Windows.Forms.GroupBox();
            this.btnRawMaterialCancel = new System.Windows.Forms.Button();
            this.btnRawMaterialSave = new System.Windows.Forms.Button();
            this.txtRawMaterialNote = new System.Windows.Forms.TextBox();
            this.lblRawMaterialNote = new System.Windows.Forms.Label();
            this.cmbPackagingType = new System.Windows.Forms.ComboBox();
            this.lblPackagingType = new System.Windows.Forms.Label();
            this.cmbRawMaterialUnit = new System.Windows.Forms.ComboBox();
            this.lblRawMaterialUnit = new System.Windows.Forms.Label();
            this.txtRawMaterialCode = new System.Windows.Forms.TextBox();
            this.lblRawMaterialCode = new System.Windows.Forms.Label();
            this.txtRawMaterialName = new System.Windows.Forms.TextBox();
            this.lblRawMaterialName = new System.Windows.Forms.Label();
            this.cmbRawMaterialType = new System.Windows.Forms.ComboBox();
            this.lblRawMaterialType = new System.Windows.Forms.Label();
            this.cmbRawMaterialEntity = new System.Windows.Forms.ComboBox();
            this.lblRawMaterialEntity = new System.Windows.Forms.Label();
            this.grpbRawMaterialList = new System.Windows.Forms.GroupBox();
            this.btnRawMaterialAdd = new System.Windows.Forms.Button();
            this.btnRawMaterialEdit = new System.Windows.Forms.Button();
            this.btnRawMaterialDelete = new System.Windows.Forms.Button();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialPackagingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCreatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialModificatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUnit = new System.Windows.Forms.Panel();
            this.grpbUnitForm = new System.Windows.Forms.GroupBox();
            this.btnUnitCancel = new System.Windows.Forms.Button();
            this.btnUnitSave = new System.Windows.Forms.Button();
            this.txtUnitSymbol = new System.Windows.Forms.TextBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitSymbol = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.grpbUnitList = new System.Windows.Forms.GroupBox();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.btnUnitEdit = new System.Windows.Forms.Button();
            this.btnUnitDelete = new System.Windows.Forms.Button();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.clmUnitCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCast = new System.Windows.Forms.Panel();
            this.tctrlCastFilm = new System.Windows.Forms.TabControl();
            this.tbpProcess = new System.Windows.Forms.TabPage();
            this.grpbProcessForm = new System.Windows.Forms.GroupBox();
            this.chbxProcessCoating = new System.Windows.Forms.CheckBox();
            this.chbxProcessCast = new System.Windows.Forms.CheckBox();
            this.btnCastProcessCancel = new System.Windows.Forms.Button();
            this.btnCastProcessSave = new System.Windows.Forms.Button();
            this.txtProcessAbbreviation = new System.Windows.Forms.TextBox();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lblProcessAbbreviation = new System.Windows.Forms.Label();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.grpbProcessList = new System.Windows.Forms.GroupBox();
            this.btnCastProcessAdd = new System.Windows.Forms.Button();
            this.btnCastProcessDelete = new System.Windows.Forms.Button();
            this.btnCastProcessEdit = new System.Windows.Forms.Button();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.clmProcessCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcessAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcessCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcessCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpStructure = new System.Windows.Forms.TabPage();
            this.grpbStructureForm = new System.Windows.Forms.GroupBox();
            this.chbxStructureCoating = new System.Windows.Forms.CheckBox();
            this.chbxStructureCast = new System.Windows.Forms.CheckBox();
            this.btnCastStructureCancel = new System.Windows.Forms.Button();
            this.btnCastStructureSave = new System.Windows.Forms.Button();
            this.txtStructureAbbreviation = new System.Windows.Forms.TextBox();
            this.txtStructureName = new System.Windows.Forms.TextBox();
            this.lblStructureAbbreviation = new System.Windows.Forms.Label();
            this.lblStructureName = new System.Windows.Forms.Label();
            this.grpbStructureList = new System.Windows.Forms.GroupBox();
            this.btnCastStructureDelete = new System.Windows.Forms.Button();
            this.btnCastStructureEdit = new System.Windows.Forms.Button();
            this.btnCastStructureAdd = new System.Windows.Forms.Button();
            this.dgvStructure = new System.Windows.Forms.DataGridView();
            this.clmStructureCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCastAdditivations = new System.Windows.Forms.TabPage();
            this.grpbCastAdditivationForm = new System.Windows.Forms.GroupBox();
            this.btnCastAdditivationCancel = new System.Windows.Forms.Button();
            this.btnCastAdditivationSave = new System.Windows.Forms.Button();
            this.chbxAdditivationCast = new System.Windows.Forms.CheckBox();
            this.chbxAdditivationBopp = new System.Windows.Forms.CheckBox();
            this.txtCastAdditivationAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCastAdditivationName = new System.Windows.Forms.TextBox();
            this.lblCastAdditivationAbbreviation = new System.Windows.Forms.Label();
            this.lblCastAdditivationName = new System.Windows.Forms.Label();
            this.grpbCastAdditivationList = new System.Windows.Forms.GroupBox();
            this.btnCastAdditivationDelete = new System.Windows.Forms.Button();
            this.btnCastAdditivationEdit = new System.Windows.Forms.Button();
            this.btnCastAdditivationAdd = new System.Windows.Forms.Button();
            this.dgvCastAdditivation = new System.Windows.Forms.DataGridView();
            this.clmCastAdditivationCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastAdditivationAbreviattion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastAdditivationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastAdditivationBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastAdditivationCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCastThickness = new System.Windows.Forms.TabPage();
            this.grpbThicknessCastForm = new System.Windows.Forms.GroupBox();
            this.txtThicknessCastValue = new System.Windows.Forms.TextBox();
            this.btnCastThicknessCancel = new System.Windows.Forms.Button();
            this.btnCastThicknessSave = new System.Windows.Forms.Button();
            this.lblThicknessCastValue = new System.Windows.Forms.Label();
            this.grpbThicknessCastList = new System.Windows.Forms.GroupBox();
            this.btnCastThicknessDelete = new System.Windows.Forms.Button();
            this.btnCastThicknessEdit = new System.Windows.Forms.Button();
            this.btnCastThicknessAdd = new System.Windows.Forms.Button();
            this.dgvThicknessCast = new System.Windows.Forms.DataGridView();
            this.clmThicknessCastCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThicknessCastValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCastTreatments = new System.Windows.Forms.TabPage();
            this.grpbTreatmentCastForm = new System.Windows.Forms.GroupBox();
            this.btnCastTreatmentCancel = new System.Windows.Forms.Button();
            this.btnCastTreatmentSave = new System.Windows.Forms.Button();
            this.chbxTreatmentCastCoating = new System.Windows.Forms.CheckBox();
            this.chbxTreatmentCastCast = new System.Windows.Forms.CheckBox();
            this.chbxTreatmentCastBopp = new System.Windows.Forms.CheckBox();
            this.txtTreatmentCastAbbreviation = new System.Windows.Forms.TextBox();
            this.txtTreatmentCastName = new System.Windows.Forms.TextBox();
            this.lblTreatmentCastAbbreviation = new System.Windows.Forms.Label();
            this.lblTreatmentCastName = new System.Windows.Forms.Label();
            this.grpbTreatmentCastList = new System.Windows.Forms.GroupBox();
            this.btnCastTreatmentDelete = new System.Windows.Forms.Button();
            this.btnCastTreatmentEdit = new System.Windows.Forms.Button();
            this.btnCastTreatmentAdd = new System.Windows.Forms.Button();
            this.dgvTreatmentCast = new System.Windows.Forms.DataGridView();
            this.clmTreatmenCastCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmenCastAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmenCastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmenCastBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmenCastCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmenCastCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSupplyByentity = new System.Windows.Forms.Panel();
            this.grpbSubbplyByEntityDetail = new System.Windows.Forms.GroupBox();
            this.btnSupplyByEntityAdd = new System.Windows.Forms.Button();
            this.btnSupplyByEntityEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSupplyByEntity = new System.Windows.Forms.DataGridView();
            this.clmSupplyByEntityCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyByEntityfkEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyByEntityEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyByEntityfkSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyByEntitySupplyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSubbplyByEntityForm = new System.Windows.Forms.GroupBox();
            this.cmbSupplyByentitySupply = new System.Windows.Forms.ComboBox();
            this.lblSupplyByentitySupply = new System.Windows.Forms.Label();
            this.btnSupplyByEntityCancel = new System.Windows.Forms.Button();
            this.btnSupplyByEntitySave = new System.Windows.Forms.Button();
            this.cmbSupplyByentityEntity = new System.Windows.Forms.ComboBox();
            this.lblSupplyByentityEntity = new System.Windows.Forms.Label();
            this.pnlRawMaterialTypeByEntity = new System.Windows.Forms.Panel();
            this.grpbRawMaterialTypeByEntityForm = new System.Windows.Forms.GroupBox();
            this.lstbTypes = new System.Windows.Forms.ListBox();
            this.rdoManyTypes = new System.Windows.Forms.RadioButton();
            this.rdoOneType = new System.Windows.Forms.RadioButton();
            this.btnRMTypeByEntityCancel = new System.Windows.Forms.Button();
            this.btnRMTypeByEntitySave = new System.Windows.Forms.Button();
            this.cmbRawMaterialTypeByEntityEntityName = new System.Windows.Forms.ComboBox();
            this.lblRawMaterialTypeByEntityEntityName = new System.Windows.Forms.Label();
            this.grpbRawMaterialTypeByEntityList = new System.Windows.Forms.GroupBox();
            this.btnRMTypeByEntityAdd = new System.Windows.Forms.Button();
            this.btnRMTypeByEntityEdit = new System.Windows.Forms.Button();
            this.btnRMTypeByEntityDelete = new System.Windows.Forms.Button();
            this.dgvRawMaterialTypeByEntity = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialTypeByEntityCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeByEntityModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCellar = new System.Windows.Forms.Panel();
            this.grpbCellarList = new System.Windows.Forms.GroupBox();
            this.btnAddCellar = new System.Windows.Forms.Button();
            this.btnDeleteCellar = new System.Windows.Forms.Button();
            this.btnEditCellar = new System.Windows.Forms.Button();
            this.dgvCellar = new System.Windows.Forms.DataGridView();
            this.clmCellarCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCellarForm = new System.Windows.Forms.GroupBox();
            this.txtCellarDescription = new System.Windows.Forms.TextBox();
            this.lblCellarDescription = new System.Windows.Forms.Label();
            this.btnCancelCellar = new System.Windows.Forms.Button();
            this.txtCellarName = new System.Windows.Forms.TextBox();
            this.btnSaveCellar = new System.Windows.Forms.Button();
            this.lblCellarName = new System.Windows.Forms.Label();
            this.pnlStatusGroup = new System.Windows.Forms.Panel();
            this.grpbStatusGroupForm = new System.Windows.Forms.GroupBox();
            this.btnStatusGroupCancel = new System.Windows.Forms.Button();
            this.txtStatusGroupName = new System.Windows.Forms.TextBox();
            this.btnStatusGroupSave = new System.Windows.Forms.Button();
            this.lblStatusGroupName = new System.Windows.Forms.Label();
            this.grpbStatusGroupList = new System.Windows.Forms.GroupBox();
            this.btnStatusGroupAdd = new System.Windows.Forms.Button();
            this.btnStatusGroupDelete = new System.Windows.Forms.Button();
            this.btnStatusGroupEdit = new System.Windows.Forms.Button();
            this.dgvStatusGroup = new System.Windows.Forms.DataGridView();
            this.clmStatusGroupCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMill = new System.Windows.Forms.Panel();
            this.grpbMillForm = new System.Windows.Forms.GroupBox();
            this.cmbxMillPlant = new System.Windows.Forms.ComboBox();
            this.lblMillPlant = new System.Windows.Forms.Label();
            this.btnMillCancel = new System.Windows.Forms.Button();
            this.btnMillSave = new System.Windows.Forms.Button();
            this.cmbxMillStatus = new System.Windows.Forms.ComboBox();
            this.cmbxMillSector = new System.Windows.Forms.ComboBox();
            this.lblMillStatus = new System.Windows.Forms.Label();
            this.lblMillSector = new System.Windows.Forms.Label();
            this.txtMillKilogramsPerHour = new System.Windows.Forms.TextBox();
            this.lblMillKilogramsPerHour = new System.Windows.Forms.Label();
            this.txtMillName = new System.Windows.Forms.TextBox();
            this.lblMillName = new System.Windows.Forms.Label();
            this.grpbMillList = new System.Windows.Forms.GroupBox();
            this.btnMillDelete = new System.Windows.Forms.Button();
            this.btnMillAdd = new System.Windows.Forms.Button();
            this.btnMillEdit = new System.Windows.Forms.Button();
            this.dgvMill = new System.Windows.Forms.DataGridView();
            this.clmMillCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMillKilogramsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMillSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMillPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCutter = new System.Windows.Forms.Panel();
            this.grpbCutterForm = new System.Windows.Forms.GroupBox();
            this.cmbCutterLine = new System.Windows.Forms.ComboBox();
            this.lblCutterLine = new System.Windows.Forms.Label();
            this.cmbxCutterPlant = new System.Windows.Forms.ComboBox();
            this.lblCutterPlant = new System.Windows.Forms.Label();
            this.cmbxCutterStatus = new System.Windows.Forms.ComboBox();
            this.lblCutterStatus = new System.Windows.Forms.Label();
            this.cmbxCutterSector = new System.Windows.Forms.ComboBox();
            this.lblCutterSector = new System.Windows.Forms.Label();
            this.btnCutterCancel = new System.Windows.Forms.Button();
            this.btnCutterSave = new System.Windows.Forms.Button();
            this.txtCutterMaxVelocity = new System.Windows.Forms.TextBox();
            this.lblCutterMaxVelocity = new System.Windows.Forms.Label();
            this.txtCutterArms = new System.Windows.Forms.TextBox();
            this.lblCutterArms = new System.Windows.Forms.Label();
            this.txtCutterFilmWidth = new System.Windows.Forms.TextBox();
            this.txtCutterName = new System.Windows.Forms.TextBox();
            this.lblCutterFilmWidth = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.grpbCutterList = new System.Windows.Forms.GroupBox();
            this.btnCutterDelete = new System.Windows.Forms.Button();
            this.btnCutterAdd = new System.Windows.Forms.Button();
            this.btnCutterEdit = new System.Windows.Forms.Button();
            this.dgvCutter = new System.Windows.Forms.DataGridView();
            this.clmCutterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterArms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterUtilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterMaxVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterProductionLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutterStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.tctrlCompany = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.cmbCurrencyMoney = new System.Windows.Forms.ComboBox();
            this.cmbCountryCompany = new System.Windows.Forms.ComboBox();
            this.rdoDistrib = new System.Windows.Forms.RadioButton();
            this.rdoPlant = new System.Windows.Forms.RadioButton();
            this.txtDescriptionCompany = new System.Windows.Forms.TextBox();
            this.txtNameCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCmpDescription = new System.Windows.Forms.Label();
            this.lblCmyCountry = new System.Windows.Forms.Label();
            this.lblCmpName = new System.Windows.Forms.Label();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnCancelCompany = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCompanyAddressSave = new System.Windows.Forms.Button();
            this.btnCompanyAddressEdit = new System.Windows.Forms.Button();
            this.btnCompanyAddressCancel = new System.Windows.Forms.Button();
            this.grpbAddressList = new System.Windows.Forms.GroupBox();
            this.dgvCompanyAddress = new System.Windows.Forms.DataGridView();
            this.IsDefault = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbAddressInfo = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCompanyCity = new System.Windows.Forms.ComboBox();
            this.cmbCompanyCountry = new System.Windows.Forms.ComboBox();
            this.cmbCompanyState = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkIsDefaultAddress = new System.Windows.Forms.CheckBox();
            this.txtCompanyFax = new System.Windows.Forms.TextBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyZip = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone2 = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyContact = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.grpbUserForm = new System.Windows.Forms.GroupBox();
            this.cmbUserStatus = new System.Windows.Forms.ComboBox();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.chbxPasswordChange = new System.Windows.Forms.CheckBox();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.cmbUserInning = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserInning = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserUserName = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserUserName = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpbUserList = new System.Windows.Forms.GroupBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.clmUserCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserInningName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserCreatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserModificatorDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserModificatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.btnStatusDelete = new System.Windows.Forms.Button();
            this.btnStatusAdd = new System.Windows.Forms.Button();
            this.btnStatusEdit = new System.Windows.Forms.Button();
            this.grpbStatusForm = new System.Windows.Forms.GroupBox();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.txtStatusDescription = new System.Windows.Forms.TextBox();
            this.btnStatusSave = new System.Windows.Forms.Button();
            this.lblStatusDescription = new System.Windows.Forms.Label();
            this.cmbStatusGroup = new System.Windows.Forms.ComboBox();
            this.lblStatusGroup = new System.Windows.Forms.Label();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.lblStatusName = new System.Windows.Forms.Label();
            this.grpbStatusList = new System.Windows.Forms.GroupBox();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.clmStatusCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusStatusGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusUserCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusModificatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRawMaterialType = new System.Windows.Forms.Panel();
            this.grpbRawMaterialTypeForm = new System.Windows.Forms.GroupBox();
            this.btnRawMaterialTypeCancel = new System.Windows.Forms.Button();
            this.btnRawMaterialTypeSave = new System.Windows.Forms.Button();
            this.txtRawMaterialTypeName = new System.Windows.Forms.TextBox();
            this.lblRawMaterialTypeName = new System.Windows.Forms.Label();
            this.grpbRawMaterialTypeList = new System.Windows.Forms.GroupBox();
            this.btnRawMaterialTypeDelete = new System.Windows.Forms.Button();
            this.btnRawMaterialTypeAdd = new System.Windows.Forms.Button();
            this.btnRawMaterialTypeEdit = new System.Windows.Forms.Button();
            this.dgvRawMaterialType = new System.Windows.Forms.DataGridView();
            this.clmRawMaterilaTypeCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterilaTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterilaTypeCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeCreatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeModificatorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCoating = new System.Windows.Forms.Panel();
            this.tctrlCoatingFilm = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpbProcessCoatingForm = new System.Windows.Forms.GroupBox();
            this.btnCoatingProcessCancel = new System.Windows.Forms.Button();
            this.btnCoatingProcessSave = new System.Windows.Forms.Button();
            this.chbxProcessCoatingCoating = new System.Windows.Forms.CheckBox();
            this.chbxProcessCoatingCast = new System.Windows.Forms.CheckBox();
            this.txtProcessCoatingAbbreviation = new System.Windows.Forms.TextBox();
            this.txtProcessCoatingName = new System.Windows.Forms.TextBox();
            this.lblProcessCoatingAbbreviation = new System.Windows.Forms.Label();
            this.lblProcessCoatingName = new System.Windows.Forms.Label();
            this.grpbProcessCoatingList = new System.Windows.Forms.GroupBox();
            this.btnCoatingProcessDelete = new System.Windows.Forms.Button();
            this.btnCoatingProcessAdd = new System.Windows.Forms.Button();
            this.btnCoatingProcessEdit = new System.Windows.Forms.Button();
            this.dgvCoatingProcess = new System.Windows.Forms.DataGridView();
            this.clmCoatingCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingProcessAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingProcessCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingProcessCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpbStructureCoatingForm = new System.Windows.Forms.GroupBox();
            this.btnCoatingStructureCancel = new System.Windows.Forms.Button();
            this.btnCoatingStructureSave = new System.Windows.Forms.Button();
            this.chbxCoatingStructureCoating = new System.Windows.Forms.CheckBox();
            this.chbxCoatingStructureCast = new System.Windows.Forms.CheckBox();
            this.txtCoatingStructureAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCoatingStructureName = new System.Windows.Forms.TextBox();
            this.lblCoatingStructureAbbreviation = new System.Windows.Forms.Label();
            this.lblCoatingStructureName = new System.Windows.Forms.Label();
            this.grpbStructureCoatingList = new System.Windows.Forms.GroupBox();
            this.btnCoatingStructureDelete = new System.Windows.Forms.Button();
            this.btnCoatingStructureAdd = new System.Windows.Forms.Button();
            this.btnCoatingStructureEdit = new System.Windows.Forms.Button();
            this.dgvCoatingStructure = new System.Windows.Forms.DataGridView();
            this.clmStructureCoatingCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCoatingAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCoatingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCoatingCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStructureCoatingCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grpbThicknessCoatingForm = new System.Windows.Forms.GroupBox();
            this.btnCoatingThicknessCancel = new System.Windows.Forms.Button();
            this.btnCoatingThicknessSave = new System.Windows.Forms.Button();
            this.txtThicknessCoating = new System.Windows.Forms.TextBox();
            this.lblThicknessCoating = new System.Windows.Forms.Label();
            this.grpbThicknessCoatingList = new System.Windows.Forms.GroupBox();
            this.btnCoatingThicknessDelete = new System.Windows.Forms.Button();
            this.btnCoatingThicknessAdd = new System.Windows.Forms.Button();
            this.btnCoatingThicknessEdit = new System.Windows.Forms.Button();
            this.dgvCoatingThickness = new System.Windows.Forms.DataGridView();
            this.clmThicknessCoatingCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThicknessCoatingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grpbTreatmentCoatingForm = new System.Windows.Forms.GroupBox();
            this.btnCoatingTreatmentCancel = new System.Windows.Forms.Button();
            this.btnCoatingTreatmentSave = new System.Windows.Forms.Button();
            this.txtCoatingTreatmentAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCoatingTreatmentName = new System.Windows.Forms.TextBox();
            this.chbxCoatingTreatmentCoating = new System.Windows.Forms.CheckBox();
            this.chbxCoatingTreatmentCast = new System.Windows.Forms.CheckBox();
            this.chbxCoatingTreatmentBopp = new System.Windows.Forms.CheckBox();
            this.lblCoatingTreatmentAbbreviation = new System.Windows.Forms.Label();
            this.lblCoatingTreatmentName = new System.Windows.Forms.Label();
            this.grpbTreatmentCoatingList = new System.Windows.Forms.GroupBox();
            this.btnCoatingTreatmentDelete = new System.Windows.Forms.Button();
            this.btnCoatingTreatmentAdd = new System.Windows.Forms.Button();
            this.btnCoatingTreatmentEdit = new System.Windows.Forms.Button();
            this.dgvCoatingTreatment = new System.Windows.Forms.DataGridView();
            this.clmCoatingTreatmentCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingTreatmentAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingTreatmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingTreatmentBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingTreatmentCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingTreatmentCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSector = new System.Windows.Forms.Panel();
            this.grpbSectorForm = new System.Windows.Forms.GroupBox();
            this.rdoMorePlant = new System.Windows.Forms.RadioButton();
            this.rdoOnePlant = new System.Windows.Forms.RadioButton();
            this.lstbPlant = new System.Windows.Forms.ListBox();
            this.btnSectorCancel = new System.Windows.Forms.Button();
            this.btnSectorSave = new System.Windows.Forms.Button();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            this.lblSectorName = new System.Windows.Forms.Label();
            this.grpbSectorList = new System.Windows.Forms.GroupBox();
            this.btnSectorAdd = new System.Windows.Forms.Button();
            this.btnSectorEdit = new System.Windows.Forms.Button();
            this.btnSectorDelete = new System.Windows.Forms.Button();
            this.dgvSector = new System.Windows.Forms.DataGridView();
            this.clmSectorCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSectorPlantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPlant = new System.Windows.Forms.Panel();
            this.grpbPlantForm = new System.Windows.Forms.GroupBox();
            this.btnPlantCancel = new System.Windows.Forms.Button();
            this.btnPlantSave = new System.Windows.Forms.Button();
            this.txtPlantName = new System.Windows.Forms.TextBox();
            this.lblPlantName = new System.Windows.Forms.Label();
            this.grpbPlantList = new System.Windows.Forms.GroupBox();
            this.btnPlantAdd = new System.Windows.Forms.Button();
            this.btnPlantEdit = new System.Windows.Forms.Button();
            this.btnPlantDelete = new System.Windows.Forms.Button();
            this.dgvPlant = new System.Windows.Forms.DataGridView();
            this.clmPlantCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIdType = new System.Windows.Forms.Panel();
            this.grpbidtypeForm = new System.Windows.Forms.GroupBox();
            this.btnIdTypeCancel = new System.Windows.Forms.Button();
            this.btnIdTypeSave = new System.Windows.Forms.Button();
            this.txtIdtypeName = new System.Windows.Forms.TextBox();
            this.lblIdtypeName = new System.Windows.Forms.Label();
            this.grpbidtypeList = new System.Windows.Forms.GroupBox();
            this.btnIdTypeAdd = new System.Windows.Forms.Button();
            this.btnIdTypeEdit = new System.Windows.Forms.Button();
            this.btnIdTypeDelete = new System.Windows.Forms.Button();
            this.dgvIdType = new System.Windows.Forms.DataGridView();
            this.clmIdTypeCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.grpbLanguageForm = new System.Windows.Forms.GroupBox();
            this.btnLanguageSave = new System.Windows.Forms.Button();
            this.btnLanguageCancel = new System.Windows.Forms.Button();
            this.txtLanguageAbbreviation = new System.Windows.Forms.TextBox();
            this.txtLanguageName = new System.Windows.Forms.TextBox();
            this.lblLanguageAbbreviation = new System.Windows.Forms.Label();
            this.lblLanguageName = new System.Windows.Forms.Label();
            this.grpbLanguageList = new System.Windows.Forms.GroupBox();
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.btnLanguageEdit = new System.Windows.Forms.Button();
            this.btnLanguageDelete = new System.Windows.Forms.Button();
            this.dgvLanguage = new System.Windows.Forms.DataGridView();
            this.clmLanguageCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanguageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanguageAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.grpbCurrencyForm = new System.Windows.Forms.GroupBox();
            this.btnCurrencySave = new System.Windows.Forms.Button();
            this.btnCurrencyCancel = new System.Windows.Forms.Button();
            this.txtCurrencyDecimal = new System.Windows.Forms.TextBox();
            this.txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.lblCurrencyDecimal = new System.Windows.Forms.Label();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.grpbCurrencyList = new System.Windows.Forms.GroupBox();
            this.btnCurrencyAdd = new System.Windows.Forms.Button();
            this.btnCurrencyEdit = new System.Windows.Forms.Button();
            this.btnCurrencyDelete = new System.Windows.Forms.Button();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrencySymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrencyDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGeographic = new System.Windows.Forms.Panel();
            this.gpbInfoCity = new System.Windows.Forms.GroupBox();
            this.btnCancelCity = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveCity = new System.Windows.Forms.Button();
            this.gpbInfoState = new System.Windows.Forms.GroupBox();
            this.btnCancelState = new System.Windows.Forms.Button();
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveState = new System.Windows.Forms.Button();
            this.gpbInfoCountry = new System.Windows.Forms.GroupBox();
            this.btnCancelCountry = new System.Windows.Forms.Button();
            this.txtcountryAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCountry = new System.Windows.Forms.Button();
            this.gpbActionsCity = new System.Windows.Forms.GroupBox();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.gpbActionsState = new System.Windows.Forms.GroupBox();
            this.btnDeleteState = new System.Windows.Forms.Button();
            this.btnEditState = new System.Windows.Forms.Button();
            this.btnAddState = new System.Windows.Forms.Button();
            this.gpbActionsCountry = new System.Windows.Forms.GroupBox();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lstbCity = new System.Windows.Forms.ListBox();
            this.lstbState = new System.Windows.Forms.ListBox();
            this.lstbCountry = new System.Windows.Forms.ListBox();
            this.pnlCoiler = new System.Windows.Forms.Panel();
            this.grpbCoilers = new System.Windows.Forms.GroupBox();
            this.dgvCoilers = new System.Windows.Forms.DataGridView();
            this.clmCoilerExtruderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilerMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveCoiler = new System.Windows.Forms.Button();
            this.pnlPackagingType = new System.Windows.Forms.Panel();
            this.grpbPackagingForm = new System.Windows.Forms.GroupBox();
            this.cmbPackagingTypeUnit = new System.Windows.Forms.ComboBox();
            this.lblPackagingTypeUnit = new System.Windows.Forms.Label();
            this.btnPackagingTypeCancel = new System.Windows.Forms.Button();
            this.btnPackagingTypeSave = new System.Windows.Forms.Button();
            this.txtPackagingTypeInitial = new System.Windows.Forms.TextBox();
            this.txtPackagingTypeName = new System.Windows.Forms.TextBox();
            this.lblPackagingTypeInitial = new System.Windows.Forms.Label();
            this.lblPackagingTypeName = new System.Windows.Forms.Label();
            this.grpbPackagingList = new System.Windows.Forms.GroupBox();
            this.btnPackagingTypeAdd = new System.Windows.Forms.Button();
            this.btnPackagingTypeEdit = new System.Windows.Forms.Button();
            this.btnPackagingTypeDelete = new System.Windows.Forms.Button();
            this.dgvPackagingType = new System.Windows.Forms.DataGridView();
            this.clmPackagingTypeCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPackagingTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPackagingTypeUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPackagingTypeInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTypeMainCoil = new System.Windows.Forms.Panel();
            this.grpbMainCoilTypeForm = new System.Windows.Forms.GroupBox();
            this.btnMainCoilTypeCancel = new System.Windows.Forms.Button();
            this.btnMainCoilTypeSave = new System.Windows.Forms.Button();
            this.txtMainCoilTypeDescription = new System.Windows.Forms.TextBox();
            this.txtMainCoilTypeName = new System.Windows.Forms.TextBox();
            this.lblMainCoilTypeDescription = new System.Windows.Forms.Label();
            this.lblMainCoilTypeName = new System.Windows.Forms.Label();
            this.grpbMainCoilTypeList = new System.Windows.Forms.GroupBox();
            this.btnMainCoilTypeDelete = new System.Windows.Forms.Button();
            this.btnMainCoilTypeAdd = new System.Windows.Forms.Button();
            this.btnMainCoilTypeEdit = new System.Windows.Forms.Button();
            this.dgvMainCoilType = new System.Windows.Forms.DataGridView();
            this.clmMainCoilTypeCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDecrease = new System.Windows.Forms.Panel();
            this.grpbDecreasForm = new System.Windows.Forms.GroupBox();
            this.btnDecreaseCancel = new System.Windows.Forms.Button();
            this.btnDecreaseSave = new System.Windows.Forms.Button();
            this.txtDecreaseDescription = new System.Windows.Forms.TextBox();
            this.txtDecreaseName = new System.Windows.Forms.TextBox();
            this.lblDecreaseDescription = new System.Windows.Forms.Label();
            this.lblDecreaseName = new System.Windows.Forms.Label();
            this.grpbDecreasList = new System.Windows.Forms.GroupBox();
            this.btnDecreaseDelete = new System.Windows.Forms.Button();
            this.btnDecreaseAdd = new System.Windows.Forms.Button();
            this.btnDecreaseEdit = new System.Windows.Forms.Button();
            this.dgvDecrease = new System.Windows.Forms.DataGridView();
            this.clmDecreaseCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTransport = new System.Windows.Forms.Panel();
            this.grpbTransportForm = new System.Windows.Forms.GroupBox();
            this.btnTransportCancel = new System.Windows.Forms.Button();
            this.btnTransportSave = new System.Windows.Forms.Button();
            this.txtTransportGrossCapacity = new System.Windows.Forms.TextBox();
            this.lblTransportGrossCapacity = new System.Windows.Forms.Label();
            this.txtTransportusefulLong = new System.Windows.Forms.TextBox();
            this.lblTransportusefulLong = new System.Windows.Forms.Label();
            this.txtTransportusefulHigh = new System.Windows.Forms.TextBox();
            this.lblTransportusefulHigh = new System.Windows.Forms.Label();
            this.txtTransportusefulWidth = new System.Windows.Forms.TextBox();
            this.lblTransportusefulWidth = new System.Windows.Forms.Label();
            this.txtTransportName = new System.Windows.Forms.TextBox();
            this.lblTransportName = new System.Windows.Forms.Label();
            this.grpbTransportList = new System.Windows.Forms.GroupBox();
            this.btnTransportAdd = new System.Windows.Forms.Button();
            this.btnTransportEdit = new System.Windows.Forms.Button();
            this.btnTransportDelete = new System.Windows.Forms.Button();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.clmTransportCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportusefulWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportusefulHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportusefulLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportGrossCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLayer = new System.Windows.Forms.Panel();
            this.grpbLayerForm = new System.Windows.Forms.GroupBox();
            this.btnLayerCancel = new System.Windows.Forms.Button();
            this.btnLayerSave = new System.Windows.Forms.Button();
            this.txtLayerDescription = new System.Windows.Forms.TextBox();
            this.lblLayerDescription = new System.Windows.Forms.Label();
            this.txtLayerName = new System.Windows.Forms.TextBox();
            this.lblLayerName = new System.Windows.Forms.Label();
            this.grpbLayerList = new System.Windows.Forms.GroupBox();
            this.btnLayerAdd = new System.Windows.Forms.Button();
            this.btnLayerEdit = new System.Windows.Forms.Button();
            this.btnLayerDelete = new System.Windows.Forms.Button();
            this.dgvLayer = new System.Windows.Forms.DataGridView();
            this.clmLayerCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLayerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDiameter = new System.Windows.Forms.Panel();
            this.grpbDiameterForm = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDiameterSave = new System.Windows.Forms.Button();
            this.txtDiameterValue = new System.Windows.Forms.TextBox();
            this.txtDiameterInitial = new System.Windows.Forms.TextBox();
            this.txtDiameterName = new System.Windows.Forms.TextBox();
            this.lblDiameterValue = new System.Windows.Forms.Label();
            this.lblDiameterInitial = new System.Windows.Forms.Label();
            this.lblDiameterName = new System.Windows.Forms.Label();
            this.grpbDiameterList = new System.Windows.Forms.GroupBox();
            this.btnDiameterAdd = new System.Windows.Forms.Button();
            this.btnDiameterEdit = new System.Windows.Forms.Button();
            this.btnDiameterDelete = new System.Windows.Forms.Button();
            this.dgvDiameter = new System.Windows.Forms.DataGridView();
            this.clmDiameterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIncoterms = new System.Windows.Forms.Panel();
            this.grpbIncotermsForm = new System.Windows.Forms.GroupBox();
            this.btnIncotermsCancel = new System.Windows.Forms.Button();
            this.btnIncotermsSave = new System.Windows.Forms.Button();
            this.txtIncotermsDescription = new System.Windows.Forms.TextBox();
            this.lblIncotermsDescription = new System.Windows.Forms.Label();
            this.txtIncotermsAbbreviation = new System.Windows.Forms.TextBox();
            this.lblIncotermsAbbreviation = new System.Windows.Forms.Label();
            this.txtIncotermsName = new System.Windows.Forms.TextBox();
            this.lblIncotermsName = new System.Windows.Forms.Label();
            this.grpbIncotermsList = new System.Windows.Forms.GroupBox();
            this.btnIncotermsAdd = new System.Windows.Forms.Button();
            this.btnIncotermsEdit = new System.Windows.Forms.Button();
            this.btnIncotermsDelete = new System.Windows.Forms.Button();
            this.dgvIncoterms = new System.Windows.Forms.DataGridView();
            this.clmIncotermsCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIncotermsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIncotermsAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIncotermsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlProductionLine = new System.Windows.Forms.Panel();
            this.grpbProductionLineForm = new System.Windows.Forms.GroupBox();
            this.btnProductionLineCancel = new System.Windows.Forms.Button();
            this.btnProductionLineSave = new System.Windows.Forms.Button();
            this.txtProductionLineDescription = new System.Windows.Forms.TextBox();
            this.lblProductionLineDescription = new System.Windows.Forms.Label();
            this.txtProductionLineName = new System.Windows.Forms.TextBox();
            this.lblProductionLineName = new System.Windows.Forms.Label();
            this.txtProductionLineLine = new System.Windows.Forms.TextBox();
            this.lblProductionLineLine = new System.Windows.Forms.Label();
            this.cmbProductionLinePlant = new System.Windows.Forms.ComboBox();
            this.lblProductionLinePlant = new System.Windows.Forms.Label();
            this.grpbProductionLineList = new System.Windows.Forms.GroupBox();
            this.btnProductionLineDelete = new System.Windows.Forms.Button();
            this.btnProductionLineAdd = new System.Windows.Forms.Button();
            this.btnProductionLineEdit = new System.Windows.Forms.Button();
            this.dgvProductionLine = new System.Windows.Forms.DataGridView();
            this.clmProductionLineCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionLinePlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionLineNumberLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionLineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionLineDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.grpbBalanceForm = new System.Windows.Forms.GroupBox();
            this.cmbBalanceStatus = new System.Windows.Forms.ComboBox();
            this.lblBalanceStatus = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblBalanceSector = new System.Windows.Forms.Label();
            this.cmbBalancePlant = new System.Windows.Forms.ComboBox();
            this.lblBalancePlant = new System.Windows.Forms.Label();
            this.btnBalanceSave = new System.Windows.Forms.Button();
            this.btnBalanceCancel = new System.Windows.Forms.Button();
            this.txtBalanceCommand = new System.Windows.Forms.TextBox();
            this.lblBalanceCommand = new System.Windows.Forms.Label();
            this.txtBalanceComm = new System.Windows.Forms.TextBox();
            this.lblBalanceComm = new System.Windows.Forms.Label();
            this.txtBalanceDelimeterTwo = new System.Windows.Forms.TextBox();
            this.lblBalanceDelimeterTwo = new System.Windows.Forms.Label();
            this.txtBalanceDelimeterOne = new System.Windows.Forms.TextBox();
            this.lblBalanceDelimeterOne = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblBalanceCapacity = new System.Windows.Forms.Label();
            this.cmbBalanceunit = new System.Windows.Forms.ComboBox();
            this.lblBalanceUnit = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblBalanceName = new System.Windows.Forms.Label();
            this.grpbBalanceList = new System.Windows.Forms.GroupBox();
            this.btnBalanceDelete = new System.Windows.Forms.Button();
            this.btnBalanceAdd = new System.Windows.Forms.Button();
            this.btnBalanceEdit = new System.Windows.Forms.Button();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.clmBalanceCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceDelimeterOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceDelimeterTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceComm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalancePlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCommercialCondition = new System.Windows.Forms.Panel();
            this.grpbCommercialConditionForm = new System.Windows.Forms.GroupBox();
            this.btnCommercialConditionCancel = new System.Windows.Forms.Button();
            this.btnCommercialConditionSave = new System.Windows.Forms.Button();
            this.txtCommercialConditionDescription = new System.Windows.Forms.TextBox();
            this.txtCommercialConditionName = new System.Windows.Forms.TextBox();
            this.lblCommercialConditionDescription = new System.Windows.Forms.Label();
            this.lblCommercialConditionName = new System.Windows.Forms.Label();
            this.grpbCommercialConditionList = new System.Windows.Forms.GroupBox();
            this.btnCommercialConditionDelete = new System.Windows.Forms.Button();
            this.btnCommercialConditionEdit = new System.Windows.Forms.Button();
            this.btnCommercialConditionAdd = new System.Windows.Forms.Button();
            this.dgvCommercialCondition = new System.Windows.Forms.DataGridView();
            this.clmCommercialConditionCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCommercialConditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCommercialConditionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel39 = new System.Windows.Forms.Panel();
            this.Panel40 = new System.Windows.Forms.Panel();
            this.ttpSystemConfig = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sptcConfig)).BeginInit();
            this.sptcConfig.Panel1.SuspendLayout();
            this.sptcConfig.Panel2.SuspendLayout();
            this.sptcConfig.SuspendLayout();
            this.pnlMetallizer.SuspendLayout();
            this.grpbMetallizerForm.SuspendLayout();
            this.grpbMetallizerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetallizer)).BeginInit();
            this.pnlCellarByExtruder.SuspendLayout();
            this.grpbCellarByExtruderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellarbyMachine)).BeginInit();
            this.grpbCellarByExtruderForm.SuspendLayout();
            this.pnlExtruders.SuspendLayout();
            this.grpbExtruderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtruder)).BeginInit();
            this.grpbExtruderForm.SuspendLayout();
            this.pnlMold.SuspendLayout();
            this.grpbMoldView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.grpbMoldForm.SuspendLayout();
            this.pnlThermExtruder.SuspendLayout();
            this.grpbThermExtruderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermExtruder)).BeginInit();
            this.grpbThermExtruderForm.SuspendLayout();
            this.pnlThermDefects.SuspendLayout();
            this.grpbThermDefectsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermDefect)).BeginInit();
            this.grpbThermDefectsForm.SuspendLayout();
            this.pnlSupply.SuspendLayout();
            this.grpbSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            this.grpbSupplyForm.SuspendLayout();
            this.pnlThermoformed.SuspendLayout();
            this.grpbThermoformedDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermoformed)).BeginInit();
            this.grpbThermoformedForm.SuspendLayout();
            this.pnlOunce.SuspendLayout();
            this.grpbOunceForm.SuspendLayout();
            this.grpbOunceView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOunce)).BeginInit();
            this.pnlColor.SuspendLayout();
            this.grpbColorForm.SuspendLayout();
            this.grpbColorView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorDetail)).BeginInit();
            this.pnlCore.SuspendLayout();
            this.grpbCoreForm.SuspendLayout();
            this.grpbCoreList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCore)).BeginInit();
            this.pnlBopp.SuspendLayout();
            this.tctrlBoppFilm.SuspendLayout();
            this.tbpFamily.SuspendLayout();
            this.grpbFamilyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
            this.grpbFamilyForm.SuspendLayout();
            this.tbpSeal.SuspendLayout();
            this.grpbSealList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeal)).BeginInit();
            this.grpbSealForm.SuspendLayout();
            this.tbpBoppAdditivation.SuspendLayout();
            this.grpbAdditivationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditivation)).BeginInit();
            this.grpbAdditivationForm.SuspendLayout();
            this.tbpBoppThickness.SuspendLayout();
            this.grpbThicknessForm.SuspendLayout();
            this.grpbThicknessList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThickness)).BeginInit();
            this.tbpBoppTreatment.SuspendLayout();
            this.grpbTreatmentForm.SuspendLayout();
            this.grpbTreatmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).BeginInit();
            this.pnlInning.SuspendLayout();
            this.grpbInningForm.SuspendLayout();
            this.grpbInningList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInning)).BeginInit();
            this.pnlRole.SuspendLayout();
            this.grpbRoleForm.SuspendLayout();
            this.grpbRoleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.pnlRawMaterial.SuspendLayout();
            this.grpbRawMaterialForm.SuspendLayout();
            this.grpbRawMaterialList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            this.pnlUnit.SuspendLayout();
            this.grpbUnitForm.SuspendLayout();
            this.grpbUnitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.pnlCast.SuspendLayout();
            this.tctrlCastFilm.SuspendLayout();
            this.tbpProcess.SuspendLayout();
            this.grpbProcessForm.SuspendLayout();
            this.grpbProcessList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.tbpStructure.SuspendLayout();
            this.grpbStructureForm.SuspendLayout();
            this.grpbStructureList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructure)).BeginInit();
            this.tbpCastAdditivations.SuspendLayout();
            this.grpbCastAdditivationForm.SuspendLayout();
            this.grpbCastAdditivationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCastAdditivation)).BeginInit();
            this.tbpCastThickness.SuspendLayout();
            this.grpbThicknessCastForm.SuspendLayout();
            this.grpbThicknessCastList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThicknessCast)).BeginInit();
            this.tbpCastTreatments.SuspendLayout();
            this.grpbTreatmentCastForm.SuspendLayout();
            this.grpbTreatmentCastList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentCast)).BeginInit();
            this.pnlSupplyByentity.SuspendLayout();
            this.grpbSubbplyByEntityDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyByEntity)).BeginInit();
            this.grpbSubbplyByEntityForm.SuspendLayout();
            this.pnlRawMaterialTypeByEntity.SuspendLayout();
            this.grpbRawMaterialTypeByEntityForm.SuspendLayout();
            this.grpbRawMaterialTypeByEntityList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialTypeByEntity)).BeginInit();
            this.pnlCellar.SuspendLayout();
            this.grpbCellarList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellar)).BeginInit();
            this.grpbCellarForm.SuspendLayout();
            this.pnlStatusGroup.SuspendLayout();
            this.grpbStatusGroupForm.SuspendLayout();
            this.grpbStatusGroupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusGroup)).BeginInit();
            this.pnlMill.SuspendLayout();
            this.grpbMillForm.SuspendLayout();
            this.grpbMillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMill)).BeginInit();
            this.pnlCutter.SuspendLayout();
            this.grpbCutterForm.SuspendLayout();
            this.grpbCutterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutter)).BeginInit();
            this.pnlCompany.SuspendLayout();
            this.tctrlCompany.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbCompanyInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpbAddressList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyAddress)).BeginInit();
            this.grpbAddressInfo.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.grpbUserForm.SuspendLayout();
            this.grpbUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.grpbStatusForm.SuspendLayout();
            this.grpbStatusList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.pnlRawMaterialType.SuspendLayout();
            this.grpbRawMaterialTypeForm.SuspendLayout();
            this.grpbRawMaterialTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialType)).BeginInit();
            this.pnlCoating.SuspendLayout();
            this.tctrlCoatingFilm.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpbProcessCoatingForm.SuspendLayout();
            this.grpbProcessCoatingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingProcess)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpbStructureCoatingForm.SuspendLayout();
            this.grpbStructureCoatingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingStructure)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.grpbThicknessCoatingForm.SuspendLayout();
            this.grpbThicknessCoatingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingThickness)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.grpbTreatmentCoatingForm.SuspendLayout();
            this.grpbTreatmentCoatingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingTreatment)).BeginInit();
            this.pnlSector.SuspendLayout();
            this.grpbSectorForm.SuspendLayout();
            this.grpbSectorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).BeginInit();
            this.pnlPlant.SuspendLayout();
            this.grpbPlantForm.SuspendLayout();
            this.grpbPlantList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlant)).BeginInit();
            this.pnlIdType.SuspendLayout();
            this.grpbidtypeForm.SuspendLayout();
            this.grpbidtypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdType)).BeginInit();
            this.pnlLanguage.SuspendLayout();
            this.grpbLanguageForm.SuspendLayout();
            this.grpbLanguageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).BeginInit();
            this.pnlCurrency.SuspendLayout();
            this.grpbCurrencyForm.SuspendLayout();
            this.grpbCurrencyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.pnlGeographic.SuspendLayout();
            this.gpbInfoCity.SuspendLayout();
            this.gpbInfoState.SuspendLayout();
            this.gpbInfoCountry.SuspendLayout();
            this.gpbActionsCity.SuspendLayout();
            this.gpbActionsState.SuspendLayout();
            this.gpbActionsCountry.SuspendLayout();
            this.pnlCoiler.SuspendLayout();
            this.grpbCoilers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilers)).BeginInit();
            this.pnlPackagingType.SuspendLayout();
            this.grpbPackagingForm.SuspendLayout();
            this.grpbPackagingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).BeginInit();
            this.pnlTypeMainCoil.SuspendLayout();
            this.grpbMainCoilTypeForm.SuspendLayout();
            this.grpbMainCoilTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilType)).BeginInit();
            this.pnlDecrease.SuspendLayout();
            this.grpbDecreasForm.SuspendLayout();
            this.grpbDecreasList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).BeginInit();
            this.pnlTransport.SuspendLayout();
            this.grpbTransportForm.SuspendLayout();
            this.grpbTransportList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.pnlLayer.SuspendLayout();
            this.grpbLayerForm.SuspendLayout();
            this.grpbLayerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayer)).BeginInit();
            this.pnlDiameter.SuspendLayout();
            this.grpbDiameterForm.SuspendLayout();
            this.grpbDiameterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiameter)).BeginInit();
            this.pnlIncoterms.SuspendLayout();
            this.grpbIncotermsForm.SuspendLayout();
            this.grpbIncotermsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncoterms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlProductionLine.SuspendLayout();
            this.grpbProductionLineForm.SuspendLayout();
            this.grpbProductionLineList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionLine)).BeginInit();
            this.pnlBalance.SuspendLayout();
            this.grpbBalanceForm.SuspendLayout();
            this.grpbBalanceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.pnlCommercialCondition.SuspendLayout();
            this.grpbCommercialConditionForm.SuspendLayout();
            this.grpbCommercialConditionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommercialCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // sptcConfig
            // 
            this.sptcConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptcConfig.Location = new System.Drawing.Point(0, 0);
            this.sptcConfig.Margin = new System.Windows.Forms.Padding(4);
            this.sptcConfig.Name = "sptcConfig";
            // 
            // sptcConfig.Panel1
            // 
            this.sptcConfig.Panel1.Controls.Add(this.trvConfigs);
            // 
            // sptcConfig.Panel2
            // 
            this.sptcConfig.Panel2.Controls.Add(this.pnlRawMaterial);
            this.sptcConfig.Panel2.Controls.Add(this.pnlMetallizer);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCellarByExtruder);
            this.sptcConfig.Panel2.Controls.Add(this.pnlExtruders);
            this.sptcConfig.Panel2.Controls.Add(this.pnlMold);
            this.sptcConfig.Panel2.Controls.Add(this.pnlThermExtruder);
            this.sptcConfig.Panel2.Controls.Add(this.pnlThermByExtruder);
            this.sptcConfig.Panel2.Controls.Add(this.pnlThermDefects);
            this.sptcConfig.Panel2.Controls.Add(this.pnlSupply);
            this.sptcConfig.Panel2.Controls.Add(this.pnlThermoformed);
            this.sptcConfig.Panel2.Controls.Add(this.pnlOunce);
            this.sptcConfig.Panel2.Controls.Add(this.pnlColor);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCore);
            this.sptcConfig.Panel2.Controls.Add(this.pnlBopp);
            this.sptcConfig.Panel2.Controls.Add(this.pnlInning);
            this.sptcConfig.Panel2.Controls.Add(this.pnlRole);
            this.sptcConfig.Panel2.Controls.Add(this.pnlUnit);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCast);
            this.sptcConfig.Panel2.Controls.Add(this.pnlSupplyByentity);
            this.sptcConfig.Panel2.Controls.Add(this.pnlRawMaterialTypeByEntity);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCellar);
            this.sptcConfig.Panel2.Controls.Add(this.pnlStatusGroup);
            this.sptcConfig.Panel2.Controls.Add(this.pnlMill);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCutter);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCompany);
            this.sptcConfig.Panel2.Controls.Add(this.pnlUser);
            this.sptcConfig.Panel2.Controls.Add(this.pnlStatus);
            this.sptcConfig.Panel2.Controls.Add(this.pnlRawMaterialType);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCoating);
            this.sptcConfig.Panel2.Controls.Add(this.pnlSector);
            this.sptcConfig.Panel2.Controls.Add(this.pnlPlant);
            this.sptcConfig.Panel2.Controls.Add(this.pnlIdType);
            this.sptcConfig.Panel2.Controls.Add(this.pnlLanguage);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCurrency);
            this.sptcConfig.Panel2.Controls.Add(this.pnlGeographic);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCoiler);
            this.sptcConfig.Panel2.Controls.Add(this.pnlPackagingType);
            this.sptcConfig.Panel2.Controls.Add(this.pnlTypeMainCoil);
            this.sptcConfig.Panel2.Controls.Add(this.pnlDecrease);
            this.sptcConfig.Panel2.Controls.Add(this.pnlTransport);
            this.sptcConfig.Panel2.Controls.Add(this.pnlLayer);
            this.sptcConfig.Panel2.Controls.Add(this.pnlDiameter);
            this.sptcConfig.Panel2.Controls.Add(this.pnlIncoterms);
            this.sptcConfig.Panel2.Controls.Add(this.pnlProductionLine);
            this.sptcConfig.Panel2.Controls.Add(this.pnlBalance);
            this.sptcConfig.Panel2.Controls.Add(this.pnlCommercialCondition);
            this.sptcConfig.Panel2.Controls.Add(this.Panel39);
            this.sptcConfig.Panel2.Controls.Add(this.Panel40);
            this.sptcConfig.Size = new System.Drawing.Size(934, 524);
            this.sptcConfig.SplitterDistance = 264;
            this.sptcConfig.TabIndex = 1;
            // 
            // trvConfigs
            // 
            this.trvConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvConfigs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.trvConfigs.Location = new System.Drawing.Point(0, 0);
            this.trvConfigs.Margin = new System.Windows.Forms.Padding(4);
            this.trvConfigs.Name = "trvConfigs";
            this.trvConfigs.Size = new System.Drawing.Size(264, 524);
            this.trvConfigs.TabIndex = 0;
            this.trvConfigs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvConfigs_AfterSelect);
            // 
            // pnlMetallizer
            // 
            this.pnlMetallizer.Controls.Add(this.grpbMetallizerForm);
            this.pnlMetallizer.Controls.Add(this.grpbMetallizerList);
            this.pnlMetallizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetallizer.Location = new System.Drawing.Point(0, 0);
            this.pnlMetallizer.Name = "pnlMetallizer";
            this.pnlMetallizer.Size = new System.Drawing.Size(666, 524);
            this.pnlMetallizer.TabIndex = 1;
            // 
            // grpbMetallizerForm
            // 
            this.grpbMetallizerForm.Controls.Add(this.txtMetalizedNumber);
            this.grpbMetallizerForm.Controls.Add(this.lblMetalizedNumber);
            this.grpbMetallizerForm.Controls.Add(this.txtMetallizerMaxDiameter);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerMaxDiameter);
            this.grpbMetallizerForm.Controls.Add(this.txtMetallizerMaxFilmWidth);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerMaxFilmWidth);
            this.grpbMetallizerForm.Controls.Add(this.cmbMetallizerLine);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerLine);
            this.grpbMetallizerForm.Controls.Add(this.cmbxMetallizerPlant);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerPlant);
            this.grpbMetallizerForm.Controls.Add(this.cmbxMetallizerStatus);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerStatus);
            this.grpbMetallizerForm.Controls.Add(this.cmbxMetallizerSector);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerSector);
            this.grpbMetallizerForm.Controls.Add(this.btnMetallizerCancel);
            this.grpbMetallizerForm.Controls.Add(this.btnMetallizerSave);
            this.grpbMetallizerForm.Controls.Add(this.txtMetallizerMaxVelocity);
            this.grpbMetallizerForm.Controls.Add(this.txtMetallizerMinFilmWidth);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerMaxVelocity);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerMinFilmWidth);
            this.grpbMetallizerForm.Controls.Add(this.lblMetallizerName);
            this.grpbMetallizerForm.Controls.Add(this.txtMetallizerName);
            this.grpbMetallizerForm.Location = new System.Drawing.Point(3, 253);
            this.grpbMetallizerForm.Name = "grpbMetallizerForm";
            this.grpbMetallizerForm.Size = new System.Drawing.Size(660, 264);
            this.grpbMetallizerForm.TabIndex = 1;
            this.grpbMetallizerForm.TabStop = false;
            // 
            // txtMetalizedNumber
            // 
            this.txtMetalizedNumber.Location = new System.Drawing.Point(418, 173);
            this.txtMetalizedNumber.Name = "txtMetalizedNumber";
            this.txtMetalizedNumber.Size = new System.Drawing.Size(121, 21);
            this.txtMetalizedNumber.TabIndex = 53;
            // 
            // lblMetalizedNumber
            // 
            this.lblMetalizedNumber.AutoSize = true;
            this.lblMetalizedNumber.Location = new System.Drawing.Point(292, 176);
            this.lblMetalizedNumber.Name = "lblMetalizedNumber";
            this.lblMetalizedNumber.Size = new System.Drawing.Size(52, 15);
            this.lblMetalizedNumber.TabIndex = 52;
            this.lblMetalizedNumber.Text = "Número";
            // 
            // txtMetallizerMaxDiameter
            // 
            this.txtMetallizerMaxDiameter.Location = new System.Drawing.Point(133, 96);
            this.txtMetallizerMaxDiameter.Name = "txtMetallizerMaxDiameter";
            this.txtMetallizerMaxDiameter.Size = new System.Drawing.Size(121, 21);
            this.txtMetallizerMaxDiameter.TabIndex = 5;
            // 
            // lblMetallizerMaxDiameter
            // 
            this.lblMetallizerMaxDiameter.AutoSize = true;
            this.lblMetallizerMaxDiameter.Location = new System.Drawing.Point(3, 100);
            this.lblMetallizerMaxDiameter.Name = "lblMetallizerMaxDiameter";
            this.lblMetallizerMaxDiameter.Size = new System.Drawing.Size(106, 15);
            this.lblMetallizerMaxDiameter.TabIndex = 51;
            this.lblMetallizerMaxDiameter.Text = "Diámetro Máximo";
            // 
            // txtMetallizerMaxFilmWidth
            // 
            this.txtMetallizerMaxFilmWidth.Location = new System.Drawing.Point(133, 55);
            this.txtMetallizerMaxFilmWidth.Name = "txtMetallizerMaxFilmWidth";
            this.txtMetallizerMaxFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtMetallizerMaxFilmWidth.TabIndex = 3;
            // 
            // lblMetallizerMaxFilmWidth
            // 
            this.lblMetallizerMaxFilmWidth.AutoSize = true;
            this.lblMetallizerMaxFilmWidth.Location = new System.Drawing.Point(3, 61);
            this.lblMetallizerMaxFilmWidth.Name = "lblMetallizerMaxFilmWidth";
            this.lblMetallizerMaxFilmWidth.Size = new System.Drawing.Size(113, 15);
            this.lblMetallizerMaxFilmWidth.TabIndex = 49;
            this.lblMetallizerMaxFilmWidth.Text = "Ancho Máx. Bobina";
            // 
            // cmbMetallizerLine
            // 
            this.cmbMetallizerLine.FormattingEnabled = true;
            this.cmbMetallizerLine.Location = new System.Drawing.Point(418, 134);
            this.cmbMetallizerLine.Name = "cmbMetallizerLine";
            this.cmbMetallizerLine.Size = new System.Drawing.Size(121, 23);
            this.cmbMetallizerLine.TabIndex = 8;
            // 
            // lblMetallizerLine
            // 
            this.lblMetallizerLine.AutoSize = true;
            this.lblMetallizerLine.Location = new System.Drawing.Point(292, 137);
            this.lblMetallizerLine.Name = "lblMetallizerLine";
            this.lblMetallizerLine.Size = new System.Drawing.Size(38, 15);
            this.lblMetallizerLine.TabIndex = 47;
            this.lblMetallizerLine.Text = "Línea";
            // 
            // cmbxMetallizerPlant
            // 
            this.cmbxMetallizerPlant.FormattingEnabled = true;
            this.cmbxMetallizerPlant.Location = new System.Drawing.Point(418, 96);
            this.cmbxMetallizerPlant.Name = "cmbxMetallizerPlant";
            this.cmbxMetallizerPlant.Size = new System.Drawing.Size(121, 23);
            this.cmbxMetallizerPlant.TabIndex = 6;
            this.cmbxMetallizerPlant.SelectedIndexChanged += new System.EventHandler(this.cmbxMetallizerPlant_SelectedIndexChanged);
            // 
            // lblMetallizerPlant
            // 
            this.lblMetallizerPlant.AutoSize = true;
            this.lblMetallizerPlant.Location = new System.Drawing.Point(292, 100);
            this.lblMetallizerPlant.Name = "lblMetallizerPlant";
            this.lblMetallizerPlant.Size = new System.Drawing.Size(42, 15);
            this.lblMetallizerPlant.TabIndex = 46;
            this.lblMetallizerPlant.Text = "Planta";
            // 
            // cmbxMetallizerStatus
            // 
            this.cmbxMetallizerStatus.FormattingEnabled = true;
            this.cmbxMetallizerStatus.Location = new System.Drawing.Point(133, 172);
            this.cmbxMetallizerStatus.Name = "cmbxMetallizerStatus";
            this.cmbxMetallizerStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbxMetallizerStatus.TabIndex = 9;
            // 
            // lblMetallizerStatus
            // 
            this.lblMetallizerStatus.AutoSize = true;
            this.lblMetallizerStatus.Location = new System.Drawing.Point(4, 176);
            this.lblMetallizerStatus.Name = "lblMetallizerStatus";
            this.lblMetallizerStatus.Size = new System.Drawing.Size(45, 15);
            this.lblMetallizerStatus.TabIndex = 45;
            this.lblMetallizerStatus.Text = "Estado";
            // 
            // cmbxMetallizerSector
            // 
            this.cmbxMetallizerSector.FormattingEnabled = true;
            this.cmbxMetallizerSector.Location = new System.Drawing.Point(133, 134);
            this.cmbxMetallizerSector.Name = "cmbxMetallizerSector";
            this.cmbxMetallizerSector.Size = new System.Drawing.Size(121, 23);
            this.cmbxMetallizerSector.TabIndex = 7;
            // 
            // lblMetallizerSector
            // 
            this.lblMetallizerSector.AutoSize = true;
            this.lblMetallizerSector.Location = new System.Drawing.Point(2, 137);
            this.lblMetallizerSector.Name = "lblMetallizerSector";
            this.lblMetallizerSector.Size = new System.Drawing.Size(42, 15);
            this.lblMetallizerSector.TabIndex = 43;
            this.lblMetallizerSector.Text = "Sector";
            // 
            // btnMetallizerCancel
            // 
            this.btnMetallizerCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMetallizerCancel.BackgroundImage")));
            this.btnMetallizerCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMetallizerCancel.Location = new System.Drawing.Point(622, 233);
            this.btnMetallizerCancel.Name = "btnMetallizerCancel";
            this.btnMetallizerCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMetallizerCancel.TabIndex = 42;
            this.btnMetallizerCancel.UseVisualStyleBackColor = true;
            this.btnMetallizerCancel.Click += new System.EventHandler(this.btnMetallizerCancel_Click);
            // 
            // btnMetallizerSave
            // 
            this.btnMetallizerSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMetallizerSave.BackgroundImage")));
            this.btnMetallizerSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMetallizerSave.Location = new System.Drawing.Point(597, 233);
            this.btnMetallizerSave.Name = "btnMetallizerSave";
            this.btnMetallizerSave.Size = new System.Drawing.Size(25, 25);
            this.btnMetallizerSave.TabIndex = 41;
            this.btnMetallizerSave.UseVisualStyleBackColor = true;
            this.btnMetallizerSave.Click += new System.EventHandler(this.btnMetallizerSave_Click);
            // 
            // txtMetallizerMaxVelocity
            // 
            this.txtMetallizerMaxVelocity.Location = new System.Drawing.Point(418, 55);
            this.txtMetallizerMaxVelocity.Name = "txtMetallizerMaxVelocity";
            this.txtMetallizerMaxVelocity.Size = new System.Drawing.Size(121, 21);
            this.txtMetallizerMaxVelocity.TabIndex = 4;
            // 
            // txtMetallizerMinFilmWidth
            // 
            this.txtMetallizerMinFilmWidth.Location = new System.Drawing.Point(418, 14);
            this.txtMetallizerMinFilmWidth.Name = "txtMetallizerMinFilmWidth";
            this.txtMetallizerMinFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtMetallizerMinFilmWidth.TabIndex = 2;
            // 
            // lblMetallizerMaxVelocity
            // 
            this.lblMetallizerMaxVelocity.AutoSize = true;
            this.lblMetallizerMaxVelocity.Location = new System.Drawing.Point(294, 60);
            this.lblMetallizerMaxVelocity.Name = "lblMetallizerMaxVelocity";
            this.lblMetallizerMaxVelocity.Size = new System.Drawing.Size(109, 15);
            this.lblMetallizerMaxVelocity.TabIndex = 3;
            this.lblMetallizerMaxVelocity.Text = "Velocidad Máxima";
            // 
            // lblMetallizerMinFilmWidth
            // 
            this.lblMetallizerMinFilmWidth.AutoSize = true;
            this.lblMetallizerMinFilmWidth.Location = new System.Drawing.Point(292, 17);
            this.lblMetallizerMinFilmWidth.Name = "lblMetallizerMinFilmWidth";
            this.lblMetallizerMinFilmWidth.Size = new System.Drawing.Size(110, 15);
            this.lblMetallizerMinFilmWidth.TabIndex = 2;
            this.lblMetallizerMinFilmWidth.Text = "Ancho Mín. Bobina";
            // 
            // lblMetallizerName
            // 
            this.lblMetallizerName.AutoSize = true;
            this.lblMetallizerName.Location = new System.Drawing.Point(3, 17);
            this.lblMetallizerName.Name = "lblMetallizerName";
            this.lblMetallizerName.Size = new System.Drawing.Size(52, 15);
            this.lblMetallizerName.TabIndex = 1;
            this.lblMetallizerName.Text = "Nombre";
            // 
            // txtMetallizerName
            // 
            this.txtMetallizerName.Location = new System.Drawing.Point(133, 14);
            this.txtMetallizerName.Name = "txtMetallizerName";
            this.txtMetallizerName.Size = new System.Drawing.Size(121, 21);
            this.txtMetallizerName.TabIndex = 1;
            // 
            // grpbMetallizerList
            // 
            this.grpbMetallizerList.Controls.Add(this.dgvMetallizer);
            this.grpbMetallizerList.Controls.Add(this.btnMetallizerDelete);
            this.grpbMetallizerList.Controls.Add(this.btnMetallizerAdd);
            this.grpbMetallizerList.Controls.Add(this.btnMetallizerEdit);
            this.grpbMetallizerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMetallizerList.Location = new System.Drawing.Point(0, 0);
            this.grpbMetallizerList.Name = "grpbMetallizerList";
            this.grpbMetallizerList.Size = new System.Drawing.Size(666, 253);
            this.grpbMetallizerList.TabIndex = 0;
            this.grpbMetallizerList.TabStop = false;
            // 
            // dgvMetallizer
            // 
            this.dgvMetallizer.AllowUserToAddRows = false;
            this.dgvMetallizer.AllowUserToDeleteRows = false;
            this.dgvMetallizer.AllowUserToOrderColumns = true;
            this.dgvMetallizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetallizer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMetallizerCodsec,
            this.clmMetallizerName,
            this.clmMetallizerNumber,
            this.clmMetallizerMinFilmWidth,
            this.clmMetallizerMaxFilmWidth,
            this.clmMetallizerMaxVelocity,
            this.clmMetallizerMaxDiameter,
            this.clmMetallizerPlant,
            this.clmMetallizerLine,
            this.clmMetallizerSector,
            this.clmMetallizerStatus});
            this.dgvMetallizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMetallizer.Location = new System.Drawing.Point(3, 17);
            this.dgvMetallizer.Name = "dgvMetallizer";
            this.dgvMetallizer.ReadOnly = true;
            this.dgvMetallizer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetallizer.Size = new System.Drawing.Size(660, 198);
            this.dgvMetallizer.TabIndex = 0;
            // 
            // clmMetallizerCodsec
            // 
            this.clmMetallizerCodsec.HeaderText = "Codsec";
            this.clmMetallizerCodsec.Name = "clmMetallizerCodsec";
            this.clmMetallizerCodsec.ReadOnly = true;
            this.clmMetallizerCodsec.Visible = false;
            // 
            // clmMetallizerName
            // 
            this.clmMetallizerName.HeaderText = "Nombre";
            this.clmMetallizerName.Name = "clmMetallizerName";
            this.clmMetallizerName.ReadOnly = true;
            this.clmMetallizerName.Width = 150;
            // 
            // clmMetallizerNumber
            // 
            this.clmMetallizerNumber.HeaderText = "Número";
            this.clmMetallizerNumber.Name = "clmMetallizerNumber";
            this.clmMetallizerNumber.ReadOnly = true;
            // 
            // clmMetallizerMinFilmWidth
            // 
            this.clmMetallizerMinFilmWidth.HeaderText = "Ancho Mín. Película";
            this.clmMetallizerMinFilmWidth.Name = "clmMetallizerMinFilmWidth";
            this.clmMetallizerMinFilmWidth.ReadOnly = true;
            this.clmMetallizerMinFilmWidth.Width = 150;
            // 
            // clmMetallizerMaxFilmWidth
            // 
            this.clmMetallizerMaxFilmWidth.HeaderText = "Ancho Máx.";
            this.clmMetallizerMaxFilmWidth.Name = "clmMetallizerMaxFilmWidth";
            this.clmMetallizerMaxFilmWidth.ReadOnly = true;
            // 
            // clmMetallizerMaxVelocity
            // 
            this.clmMetallizerMaxVelocity.HeaderText = "Velocidad Máx.";
            this.clmMetallizerMaxVelocity.Name = "clmMetallizerMaxVelocity";
            this.clmMetallizerMaxVelocity.ReadOnly = true;
            // 
            // clmMetallizerMaxDiameter
            // 
            this.clmMetallizerMaxDiameter.HeaderText = "Diámetro Máx.";
            this.clmMetallizerMaxDiameter.Name = "clmMetallizerMaxDiameter";
            this.clmMetallizerMaxDiameter.ReadOnly = true;
            // 
            // clmMetallizerPlant
            // 
            this.clmMetallizerPlant.HeaderText = "Planta";
            this.clmMetallizerPlant.Name = "clmMetallizerPlant";
            this.clmMetallizerPlant.ReadOnly = true;
            // 
            // clmMetallizerLine
            // 
            this.clmMetallizerLine.HeaderText = "Línea";
            this.clmMetallizerLine.Name = "clmMetallizerLine";
            this.clmMetallizerLine.ReadOnly = true;
            // 
            // clmMetallizerSector
            // 
            this.clmMetallizerSector.HeaderText = "Sector";
            this.clmMetallizerSector.Name = "clmMetallizerSector";
            this.clmMetallizerSector.ReadOnly = true;
            // 
            // clmMetallizerStatus
            // 
            this.clmMetallizerStatus.HeaderText = "Estado";
            this.clmMetallizerStatus.Name = "clmMetallizerStatus";
            this.clmMetallizerStatus.ReadOnly = true;
            // 
            // btnMetallizerDelete
            // 
            this.btnMetallizerDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnMetallizerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMetallizerDelete.Location = new System.Drawing.Point(630, 221);
            this.btnMetallizerDelete.Name = "btnMetallizerDelete";
            this.btnMetallizerDelete.Size = new System.Drawing.Size(25, 25);
            this.btnMetallizerDelete.TabIndex = 44;
            this.btnMetallizerDelete.UseVisualStyleBackColor = true;
            // 
            // btnMetallizerAdd
            // 
            this.btnMetallizerAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnMetallizerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMetallizerAdd.Location = new System.Drawing.Point(578, 221);
            this.btnMetallizerAdd.Name = "btnMetallizerAdd";
            this.btnMetallizerAdd.Size = new System.Drawing.Size(25, 25);
            this.btnMetallizerAdd.TabIndex = 42;
            this.btnMetallizerAdd.UseVisualStyleBackColor = true;
            this.btnMetallizerAdd.Click += new System.EventHandler(this.btnMetallizerAdd_Click);
            // 
            // btnMetallizerEdit
            // 
            this.btnMetallizerEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnMetallizerEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMetallizerEdit.Location = new System.Drawing.Point(604, 221);
            this.btnMetallizerEdit.Name = "btnMetallizerEdit";
            this.btnMetallizerEdit.Size = new System.Drawing.Size(25, 25);
            this.btnMetallizerEdit.TabIndex = 43;
            this.btnMetallizerEdit.UseVisualStyleBackColor = true;
            this.btnMetallizerEdit.Click += new System.EventHandler(this.btnMetallizerEdit_Click);
            // 
            // pnlCellarByExtruder
            // 
            this.pnlCellarByExtruder.Controls.Add(this.grpbCellarByExtruderList);
            this.pnlCellarByExtruder.Controls.Add(this.grpbCellarByExtruderForm);
            this.pnlCellarByExtruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCellarByExtruder.Location = new System.Drawing.Point(0, 0);
            this.pnlCellarByExtruder.Name = "pnlCellarByExtruder";
            this.pnlCellarByExtruder.Size = new System.Drawing.Size(666, 524);
            this.pnlCellarByExtruder.TabIndex = 1;
            // 
            // grpbCellarByExtruderList
            // 
            this.grpbCellarByExtruderList.Controls.Add(this.btnCellarByExtDelete);
            this.grpbCellarByExtruderList.Controls.Add(this.btnCellarByExtAdd);
            this.grpbCellarByExtruderList.Controls.Add(this.btnCellarByExtEdit);
            this.grpbCellarByExtruderList.Controls.Add(this.dgvCellarbyMachine);
            this.grpbCellarByExtruderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCellarByExtruderList.Location = new System.Drawing.Point(0, 0);
            this.grpbCellarByExtruderList.Name = "grpbCellarByExtruderList";
            this.grpbCellarByExtruderList.Size = new System.Drawing.Size(666, 253);
            this.grpbCellarByExtruderList.TabIndex = 2;
            this.grpbCellarByExtruderList.TabStop = false;
            // 
            // btnCellarByExtDelete
            // 
            this.btnCellarByExtDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCellarByExtDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCellarByExtDelete.Location = new System.Drawing.Point(630, 221);
            this.btnCellarByExtDelete.Name = "btnCellarByExtDelete";
            this.btnCellarByExtDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCellarByExtDelete.TabIndex = 38;
            this.btnCellarByExtDelete.UseVisualStyleBackColor = true;
            // 
            // btnCellarByExtAdd
            // 
            this.btnCellarByExtAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCellarByExtAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCellarByExtAdd.Location = new System.Drawing.Point(578, 221);
            this.btnCellarByExtAdd.Name = "btnCellarByExtAdd";
            this.btnCellarByExtAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCellarByExtAdd.TabIndex = 36;
            this.btnCellarByExtAdd.UseVisualStyleBackColor = true;
            this.btnCellarByExtAdd.Click += new System.EventHandler(this.btnCellarByExtAdd_Click);
            // 
            // btnCellarByExtEdit
            // 
            this.btnCellarByExtEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCellarByExtEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCellarByExtEdit.Location = new System.Drawing.Point(604, 221);
            this.btnCellarByExtEdit.Name = "btnCellarByExtEdit";
            this.btnCellarByExtEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCellarByExtEdit.TabIndex = 37;
            this.btnCellarByExtEdit.UseVisualStyleBackColor = true;
            this.btnCellarByExtEdit.Click += new System.EventHandler(this.btnCellarByExtEdit_Click);
            // 
            // dgvCellarbyMachine
            // 
            this.dgvCellarbyMachine.AllowUserToAddRows = false;
            this.dgvCellarbyMachine.AllowUserToDeleteRows = false;
            this.dgvCellarbyMachine.AllowUserToOrderColumns = true;
            this.dgvCellarbyMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCellarbyMachine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCellarByExtruderCodsec,
            this.clmCellarByExtruderCellarName,
            this.clmCellarByExtruderExtName});
            this.dgvCellarbyMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCellarbyMachine.Location = new System.Drawing.Point(3, 17);
            this.dgvCellarbyMachine.Name = "dgvCellarbyMachine";
            this.dgvCellarbyMachine.ReadOnly = true;
            this.dgvCellarbyMachine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCellarbyMachine.Size = new System.Drawing.Size(660, 198);
            this.dgvCellarbyMachine.TabIndex = 0;
            // 
            // clmCellarByExtruderCodsec
            // 
            this.clmCellarByExtruderCodsec.HeaderText = "Codsec";
            this.clmCellarByExtruderCodsec.Name = "clmCellarByExtruderCodsec";
            this.clmCellarByExtruderCodsec.ReadOnly = true;
            this.clmCellarByExtruderCodsec.Visible = false;
            // 
            // clmCellarByExtruderCellarName
            // 
            this.clmCellarByExtruderCellarName.HeaderText = "Bodega";
            this.clmCellarByExtruderCellarName.Name = "clmCellarByExtruderCellarName";
            this.clmCellarByExtruderCellarName.ReadOnly = true;
            this.clmCellarByExtruderCellarName.Width = 200;
            // 
            // clmCellarByExtruderExtName
            // 
            this.clmCellarByExtruderExtName.HeaderText = "Linea";
            this.clmCellarByExtruderExtName.Name = "clmCellarByExtruderExtName";
            this.clmCellarByExtruderExtName.ReadOnly = true;
            this.clmCellarByExtruderExtName.Width = 200;
            // 
            // grpbCellarByExtruderForm
            // 
            this.grpbCellarByExtruderForm.Controls.Add(this.cmbCellarByExtLineName);
            this.grpbCellarByExtruderForm.Controls.Add(this.lblCellarByExtLineName);
            this.grpbCellarByExtruderForm.Controls.Add(this.cmbCellarByExtCellarName);
            this.grpbCellarByExtruderForm.Controls.Add(this.lblCellarByExtCellarName);
            this.grpbCellarByExtruderForm.Controls.Add(this.btnCellarByExtCancel);
            this.grpbCellarByExtruderForm.Controls.Add(this.btnCellarByExtSave);
            this.grpbCellarByExtruderForm.Location = new System.Drawing.Point(3, 257);
            this.grpbCellarByExtruderForm.Name = "grpbCellarByExtruderForm";
            this.grpbCellarByExtruderForm.Size = new System.Drawing.Size(660, 264);
            this.grpbCellarByExtruderForm.TabIndex = 3;
            this.grpbCellarByExtruderForm.TabStop = false;
            // 
            // cmbCellarByExtLineName
            // 
            this.cmbCellarByExtLineName.FormattingEnabled = true;
            this.cmbCellarByExtLineName.Location = new System.Drawing.Point(145, 60);
            this.cmbCellarByExtLineName.Name = "cmbCellarByExtLineName";
            this.cmbCellarByExtLineName.Size = new System.Drawing.Size(196, 23);
            this.cmbCellarByExtLineName.TabIndex = 9;
            // 
            // lblCellarByExtLineName
            // 
            this.lblCellarByExtLineName.AutoSize = true;
            this.lblCellarByExtLineName.Location = new System.Drawing.Point(3, 68);
            this.lblCellarByExtLineName.Name = "lblCellarByExtLineName";
            this.lblCellarByExtLineName.Size = new System.Drawing.Size(38, 15);
            this.lblCellarByExtLineName.TabIndex = 47;
            this.lblCellarByExtLineName.Text = "Linea";
            // 
            // cmbCellarByExtCellarName
            // 
            this.cmbCellarByExtCellarName.FormattingEnabled = true;
            this.cmbCellarByExtCellarName.Location = new System.Drawing.Point(145, 26);
            this.cmbCellarByExtCellarName.Name = "cmbCellarByExtCellarName";
            this.cmbCellarByExtCellarName.Size = new System.Drawing.Size(196, 23);
            this.cmbCellarByExtCellarName.TabIndex = 7;
            // 
            // lblCellarByExtCellarName
            // 
            this.lblCellarByExtCellarName.AutoSize = true;
            this.lblCellarByExtCellarName.Location = new System.Drawing.Point(3, 28);
            this.lblCellarByExtCellarName.Name = "lblCellarByExtCellarName";
            this.lblCellarByExtCellarName.Size = new System.Drawing.Size(50, 15);
            this.lblCellarByExtCellarName.TabIndex = 43;
            this.lblCellarByExtCellarName.Text = "Bodega";
            // 
            // btnCellarByExtCancel
            // 
            this.btnCellarByExtCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCellarByExtCancel.BackgroundImage")));
            this.btnCellarByExtCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCellarByExtCancel.Location = new System.Drawing.Point(622, 233);
            this.btnCellarByExtCancel.Name = "btnCellarByExtCancel";
            this.btnCellarByExtCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCellarByExtCancel.TabIndex = 38;
            this.btnCellarByExtCancel.UseVisualStyleBackColor = true;
            this.btnCellarByExtCancel.Click += new System.EventHandler(this.btnCellarByExtCancel_Click);
            // 
            // btnCellarByExtSave
            // 
            this.btnCellarByExtSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCellarByExtSave.BackgroundImage")));
            this.btnCellarByExtSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCellarByExtSave.Location = new System.Drawing.Point(597, 233);
            this.btnCellarByExtSave.Name = "btnCellarByExtSave";
            this.btnCellarByExtSave.Size = new System.Drawing.Size(25, 25);
            this.btnCellarByExtSave.TabIndex = 37;
            this.btnCellarByExtSave.UseVisualStyleBackColor = true;
            this.btnCellarByExtSave.Click += new System.EventHandler(this.btnCellarByExtSave_Click);
            // 
            // pnlExtruders
            // 
            this.pnlExtruders.Controls.Add(this.grpbExtruderList);
            this.pnlExtruders.Controls.Add(this.grpbExtruderForm);
            this.pnlExtruders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExtruders.Location = new System.Drawing.Point(0, 0);
            this.pnlExtruders.Name = "pnlExtruders";
            this.pnlExtruders.Size = new System.Drawing.Size(666, 524);
            this.pnlExtruders.TabIndex = 1;
            // 
            // grpbExtruderList
            // 
            this.grpbExtruderList.Controls.Add(this.btnExtruderDelete);
            this.grpbExtruderList.Controls.Add(this.btnExtruderAdd);
            this.grpbExtruderList.Controls.Add(this.btnExtruderEdit);
            this.grpbExtruderList.Controls.Add(this.dgvExtruder);
            this.grpbExtruderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbExtruderList.Location = new System.Drawing.Point(0, 0);
            this.grpbExtruderList.Name = "grpbExtruderList";
            this.grpbExtruderList.Size = new System.Drawing.Size(666, 253);
            this.grpbExtruderList.TabIndex = 0;
            this.grpbExtruderList.TabStop = false;
            // 
            // btnExtruderDelete
            // 
            this.btnExtruderDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnExtruderDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExtruderDelete.Location = new System.Drawing.Point(630, 221);
            this.btnExtruderDelete.Name = "btnExtruderDelete";
            this.btnExtruderDelete.Size = new System.Drawing.Size(25, 25);
            this.btnExtruderDelete.TabIndex = 38;
            this.btnExtruderDelete.UseVisualStyleBackColor = true;
            // 
            // btnExtruderAdd
            // 
            this.btnExtruderAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnExtruderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExtruderAdd.Location = new System.Drawing.Point(578, 221);
            this.btnExtruderAdd.Name = "btnExtruderAdd";
            this.btnExtruderAdd.Size = new System.Drawing.Size(25, 25);
            this.btnExtruderAdd.TabIndex = 36;
            this.btnExtruderAdd.UseVisualStyleBackColor = true;
            this.btnExtruderAdd.Click += new System.EventHandler(this.btnExtruderAdd_Click);
            // 
            // btnExtruderEdit
            // 
            this.btnExtruderEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnExtruderEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExtruderEdit.Location = new System.Drawing.Point(604, 221);
            this.btnExtruderEdit.Name = "btnExtruderEdit";
            this.btnExtruderEdit.Size = new System.Drawing.Size(25, 25);
            this.btnExtruderEdit.TabIndex = 37;
            this.btnExtruderEdit.UseVisualStyleBackColor = true;
            this.btnExtruderEdit.Click += new System.EventHandler(this.btnExtruderEdit_Click);
            // 
            // dgvExtruder
            // 
            this.dgvExtruder.AllowUserToAddRows = false;
            this.dgvExtruder.AllowUserToDeleteRows = false;
            this.dgvExtruder.AllowUserToOrderColumns = true;
            this.dgvExtruder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtruder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExtruderCodsec,
            this.clmExtruderName,
            this.clmExtruderminFilmWidth,
            this.clmExtrudermaxFilmWidth,
            this.clmExtrudermaxVelocity,
            this.clmExtruderCoilNumber,
            this.clmExtruderKilogramsPerHour,
            this.clmExtruderPlant,
            this.clmExtruderProductionLine,
            this.clmExtruderSector,
            this.clmExtruderStatus});
            this.dgvExtruder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExtruder.Location = new System.Drawing.Point(3, 17);
            this.dgvExtruder.Name = "dgvExtruder";
            this.dgvExtruder.ReadOnly = true;
            this.dgvExtruder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtruder.Size = new System.Drawing.Size(660, 198);
            this.dgvExtruder.TabIndex = 0;
            // 
            // clmExtruderCodsec
            // 
            this.clmExtruderCodsec.HeaderText = "Codsec";
            this.clmExtruderCodsec.Name = "clmExtruderCodsec";
            this.clmExtruderCodsec.ReadOnly = true;
            this.clmExtruderCodsec.Visible = false;
            // 
            // clmExtruderName
            // 
            this.clmExtruderName.HeaderText = "Nombre";
            this.clmExtruderName.Name = "clmExtruderName";
            this.clmExtruderName.ReadOnly = true;
            this.clmExtruderName.Width = 150;
            // 
            // clmExtruderminFilmWidth
            // 
            this.clmExtruderminFilmWidth.HeaderText = "Ancho Mínimo";
            this.clmExtruderminFilmWidth.Name = "clmExtruderminFilmWidth";
            this.clmExtruderminFilmWidth.ReadOnly = true;
            // 
            // clmExtrudermaxFilmWidth
            // 
            this.clmExtrudermaxFilmWidth.HeaderText = "Ancho Máximo";
            this.clmExtrudermaxFilmWidth.Name = "clmExtrudermaxFilmWidth";
            this.clmExtrudermaxFilmWidth.ReadOnly = true;
            // 
            // clmExtrudermaxVelocity
            // 
            this.clmExtrudermaxVelocity.HeaderText = "Velocidad Máxima";
            this.clmExtrudermaxVelocity.Name = "clmExtrudermaxVelocity";
            this.clmExtrudermaxVelocity.ReadOnly = true;
            // 
            // clmExtruderCoilNumber
            // 
            this.clmExtruderCoilNumber.HeaderText = "Número Bobinas";
            this.clmExtruderCoilNumber.Name = "clmExtruderCoilNumber";
            this.clmExtruderCoilNumber.ReadOnly = true;
            this.clmExtruderCoilNumber.Width = 150;
            // 
            // clmExtruderKilogramsPerHour
            // 
            this.clmExtruderKilogramsPerHour.HeaderText = "Kg/Hr";
            this.clmExtruderKilogramsPerHour.Name = "clmExtruderKilogramsPerHour";
            this.clmExtruderKilogramsPerHour.ReadOnly = true;
            // 
            // clmExtruderPlant
            // 
            this.clmExtruderPlant.HeaderText = "Planta";
            this.clmExtruderPlant.Name = "clmExtruderPlant";
            this.clmExtruderPlant.ReadOnly = true;
            // 
            // clmExtruderProductionLine
            // 
            this.clmExtruderProductionLine.HeaderText = "Linea";
            this.clmExtruderProductionLine.Name = "clmExtruderProductionLine";
            this.clmExtruderProductionLine.ReadOnly = true;
            // 
            // clmExtruderSector
            // 
            this.clmExtruderSector.HeaderText = "Sector";
            this.clmExtruderSector.Name = "clmExtruderSector";
            this.clmExtruderSector.ReadOnly = true;
            // 
            // clmExtruderStatus
            // 
            this.clmExtruderStatus.HeaderText = "Estado";
            this.clmExtruderStatus.Name = "clmExtruderStatus";
            this.clmExtruderStatus.ReadOnly = true;
            // 
            // grpbExtruderForm
            // 
            this.grpbExtruderForm.Controls.Add(this.cmbExtruderLine);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderLine);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderMaxVelocity);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderMaxVelocity);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderMaxFilmWidth);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderMaxFilmWidth);
            this.grpbExtruderForm.Controls.Add(this.cmbxExtruderPlant);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderPlant);
            this.grpbExtruderForm.Controls.Add(this.cmbxExtruderStatus);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderStatus);
            this.grpbExtruderForm.Controls.Add(this.cmbxExtruderSector);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderSector);
            this.grpbExtruderForm.Controls.Add(this.btnExtruderCancel);
            this.grpbExtruderForm.Controls.Add(this.btnExtruderSave);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderKilogramsPerHour);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderMinFilmWidth);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderCoilNumber);
            this.grpbExtruderForm.Controls.Add(this.txtExtruderName);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderKilogramsPerHour);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderCoilNumber);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderMinFilmWidth);
            this.grpbExtruderForm.Controls.Add(this.lblExtruderName);
            this.grpbExtruderForm.Location = new System.Drawing.Point(3, 253);
            this.grpbExtruderForm.Name = "grpbExtruderForm";
            this.grpbExtruderForm.Size = new System.Drawing.Size(660, 264);
            this.grpbExtruderForm.TabIndex = 1;
            this.grpbExtruderForm.TabStop = false;
            // 
            // cmbExtruderLine
            // 
            this.cmbExtruderLine.FormattingEnabled = true;
            this.cmbExtruderLine.Location = new System.Drawing.Point(145, 179);
            this.cmbExtruderLine.Name = "cmbExtruderLine";
            this.cmbExtruderLine.Size = new System.Drawing.Size(121, 23);
            this.cmbExtruderLine.TabIndex = 9;
            // 
            // lblExtruderLine
            // 
            this.lblExtruderLine.AutoSize = true;
            this.lblExtruderLine.Location = new System.Drawing.Point(3, 187);
            this.lblExtruderLine.Name = "lblExtruderLine";
            this.lblExtruderLine.Size = new System.Drawing.Size(38, 15);
            this.lblExtruderLine.TabIndex = 47;
            this.lblExtruderLine.Text = "Linea";
            // 
            // txtExtruderMaxVelocity
            // 
            this.txtExtruderMaxVelocity.Location = new System.Drawing.Point(472, 73);
            this.txtExtruderMaxVelocity.Name = "txtExtruderMaxVelocity";
            this.txtExtruderMaxVelocity.Size = new System.Drawing.Size(121, 21);
            this.txtExtruderMaxVelocity.TabIndex = 4;
            // 
            // lblExtruderMaxVelocity
            // 
            this.lblExtruderMaxVelocity.AutoSize = true;
            this.lblExtruderMaxVelocity.Location = new System.Drawing.Point(324, 74);
            this.lblExtruderMaxVelocity.Name = "lblExtruderMaxVelocity";
            this.lblExtruderMaxVelocity.Size = new System.Drawing.Size(109, 15);
            this.lblExtruderMaxVelocity.TabIndex = 46;
            this.lblExtruderMaxVelocity.Text = "Velocidad Máxima";
            // 
            // txtExtruderMaxFilmWidth
            // 
            this.txtExtruderMaxFilmWidth.Location = new System.Drawing.Point(145, 72);
            this.txtExtruderMaxFilmWidth.Name = "txtExtruderMaxFilmWidth";
            this.txtExtruderMaxFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtExtruderMaxFilmWidth.TabIndex = 3;
            // 
            // lblExtruderMaxFilmWidth
            // 
            this.lblExtruderMaxFilmWidth.AutoSize = true;
            this.lblExtruderMaxFilmWidth.Location = new System.Drawing.Point(3, 74);
            this.lblExtruderMaxFilmWidth.Name = "lblExtruderMaxFilmWidth";
            this.lblExtruderMaxFilmWidth.Size = new System.Drawing.Size(134, 15);
            this.lblExtruderMaxFilmWidth.TabIndex = 44;
            this.lblExtruderMaxFilmWidth.Text = "Ancho Máximo Bobina ";
            // 
            // cmbxExtruderPlant
            // 
            this.cmbxExtruderPlant.FormattingEnabled = true;
            this.cmbxExtruderPlant.Location = new System.Drawing.Point(145, 145);
            this.cmbxExtruderPlant.Name = "cmbxExtruderPlant";
            this.cmbxExtruderPlant.Size = new System.Drawing.Size(121, 23);
            this.cmbxExtruderPlant.TabIndex = 7;
            this.cmbxExtruderPlant.SelectedIndexChanged += new System.EventHandler(this.cmbxExtruderPlant_SelectedIndexChanged);
            // 
            // lblExtruderPlant
            // 
            this.lblExtruderPlant.AutoSize = true;
            this.lblExtruderPlant.Location = new System.Drawing.Point(3, 147);
            this.lblExtruderPlant.Name = "lblExtruderPlant";
            this.lblExtruderPlant.Size = new System.Drawing.Size(42, 15);
            this.lblExtruderPlant.TabIndex = 43;
            this.lblExtruderPlant.Text = "Planta";
            // 
            // cmbxExtruderStatus
            // 
            this.cmbxExtruderStatus.FormattingEnabled = true;
            this.cmbxExtruderStatus.Location = new System.Drawing.Point(471, 178);
            this.cmbxExtruderStatus.Name = "cmbxExtruderStatus";
            this.cmbxExtruderStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbxExtruderStatus.TabIndex = 10;
            // 
            // lblExtruderStatus
            // 
            this.lblExtruderStatus.AutoSize = true;
            this.lblExtruderStatus.Location = new System.Drawing.Point(324, 186);
            this.lblExtruderStatus.Name = "lblExtruderStatus";
            this.lblExtruderStatus.Size = new System.Drawing.Size(45, 15);
            this.lblExtruderStatus.TabIndex = 41;
            this.lblExtruderStatus.Text = "Estado";
            // 
            // cmbxExtruderSector
            // 
            this.cmbxExtruderSector.FormattingEnabled = true;
            this.cmbxExtruderSector.Location = new System.Drawing.Point(472, 144);
            this.cmbxExtruderSector.Name = "cmbxExtruderSector";
            this.cmbxExtruderSector.Size = new System.Drawing.Size(121, 23);
            this.cmbxExtruderSector.TabIndex = 8;
            // 
            // lblExtruderSector
            // 
            this.lblExtruderSector.AutoSize = true;
            this.lblExtruderSector.Location = new System.Drawing.Point(324, 149);
            this.lblExtruderSector.Name = "lblExtruderSector";
            this.lblExtruderSector.Size = new System.Drawing.Size(42, 15);
            this.lblExtruderSector.TabIndex = 39;
            this.lblExtruderSector.Text = "Sector";
            // 
            // btnExtruderCancel
            // 
            this.btnExtruderCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtruderCancel.BackgroundImage")));
            this.btnExtruderCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExtruderCancel.Location = new System.Drawing.Point(622, 233);
            this.btnExtruderCancel.Name = "btnExtruderCancel";
            this.btnExtruderCancel.Size = new System.Drawing.Size(25, 25);
            this.btnExtruderCancel.TabIndex = 38;
            this.btnExtruderCancel.UseVisualStyleBackColor = true;
            this.btnExtruderCancel.Click += new System.EventHandler(this.btnExtruderCancel_Click);
            // 
            // btnExtruderSave
            // 
            this.btnExtruderSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtruderSave.BackgroundImage")));
            this.btnExtruderSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExtruderSave.Location = new System.Drawing.Point(597, 233);
            this.btnExtruderSave.Name = "btnExtruderSave";
            this.btnExtruderSave.Size = new System.Drawing.Size(25, 25);
            this.btnExtruderSave.TabIndex = 37;
            this.btnExtruderSave.UseVisualStyleBackColor = true;
            this.btnExtruderSave.Click += new System.EventHandler(this.btnExtruderSave_Click);
            // 
            // txtExtruderKilogramsPerHour
            // 
            this.txtExtruderKilogramsPerHour.Location = new System.Drawing.Point(472, 109);
            this.txtExtruderKilogramsPerHour.Name = "txtExtruderKilogramsPerHour";
            this.txtExtruderKilogramsPerHour.Size = new System.Drawing.Size(121, 21);
            this.txtExtruderKilogramsPerHour.TabIndex = 6;
            // 
            // txtExtruderMinFilmWidth
            // 
            this.txtExtruderMinFilmWidth.Location = new System.Drawing.Point(472, 31);
            this.txtExtruderMinFilmWidth.Name = "txtExtruderMinFilmWidth";
            this.txtExtruderMinFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtExtruderMinFilmWidth.TabIndex = 2;
            // 
            // txtExtruderCoilNumber
            // 
            this.txtExtruderCoilNumber.Location = new System.Drawing.Point(145, 108);
            this.txtExtruderCoilNumber.Name = "txtExtruderCoilNumber";
            this.txtExtruderCoilNumber.Size = new System.Drawing.Size(121, 21);
            this.txtExtruderCoilNumber.TabIndex = 5;
            // 
            // txtExtruderName
            // 
            this.txtExtruderName.Location = new System.Drawing.Point(145, 30);
            this.txtExtruderName.Name = "txtExtruderName";
            this.txtExtruderName.Size = new System.Drawing.Size(141, 21);
            this.txtExtruderName.TabIndex = 1;
            // 
            // lblExtruderKilogramsPerHour
            // 
            this.lblExtruderKilogramsPerHour.AutoSize = true;
            this.lblExtruderKilogramsPerHour.Location = new System.Drawing.Point(324, 111);
            this.lblExtruderKilogramsPerHour.Name = "lblExtruderKilogramsPerHour";
            this.lblExtruderKilogramsPerHour.Size = new System.Drawing.Size(41, 15);
            this.lblExtruderKilogramsPerHour.TabIndex = 3;
            this.lblExtruderKilogramsPerHour.Text = "Kg/Hr.";
            // 
            // lblExtruderCoilNumber
            // 
            this.lblExtruderCoilNumber.AutoSize = true;
            this.lblExtruderCoilNumber.Location = new System.Drawing.Point(3, 111);
            this.lblExtruderCoilNumber.Name = "lblExtruderCoilNumber";
            this.lblExtruderCoilNumber.Size = new System.Drawing.Size(100, 15);
            this.lblExtruderCoilNumber.TabIndex = 2;
            this.lblExtruderCoilNumber.Text = "Número Bobinas";
            // 
            // lblExtruderMinFilmWidth
            // 
            this.lblExtruderMinFilmWidth.AutoSize = true;
            this.lblExtruderMinFilmWidth.Location = new System.Drawing.Point(324, 33);
            this.lblExtruderMinFilmWidth.Name = "lblExtruderMinFilmWidth";
            this.lblExtruderMinFilmWidth.Size = new System.Drawing.Size(128, 15);
            this.lblExtruderMinFilmWidth.TabIndex = 1;
            this.lblExtruderMinFilmWidth.Text = "Ancho Minimo Bobina";
            // 
            // lblExtruderName
            // 
            this.lblExtruderName.AutoSize = true;
            this.lblExtruderName.Location = new System.Drawing.Point(3, 33);
            this.lblExtruderName.Name = "lblExtruderName";
            this.lblExtruderName.Size = new System.Drawing.Size(52, 15);
            this.lblExtruderName.TabIndex = 0;
            this.lblExtruderName.Text = "Nombre";
            // 
            // pnlMold
            // 
            this.pnlMold.Controls.Add(this.grpbMoldView);
            this.pnlMold.Controls.Add(this.grpbMoldForm);
            this.pnlMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMold.Location = new System.Drawing.Point(0, 0);
            this.pnlMold.Name = "pnlMold";
            this.pnlMold.Size = new System.Drawing.Size(666, 524);
            this.pnlMold.TabIndex = 1;
            // 
            // grpbMoldView
            // 
            this.grpbMoldView.Controls.Add(this.btnMoldDelete);
            this.grpbMoldView.Controls.Add(this.btnMoldAdd);
            this.grpbMoldView.Controls.Add(this.btnMoldEdit);
            this.grpbMoldView.Controls.Add(this.dgvMold);
            this.grpbMoldView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMoldView.Location = new System.Drawing.Point(0, 0);
            this.grpbMoldView.Name = "grpbMoldView";
            this.grpbMoldView.Size = new System.Drawing.Size(666, 253);
            this.grpbMoldView.TabIndex = 4;
            this.grpbMoldView.TabStop = false;
            // 
            // btnMoldDelete
            // 
            this.btnMoldDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnMoldDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoldDelete.Location = new System.Drawing.Point(630, 221);
            this.btnMoldDelete.Name = "btnMoldDelete";
            this.btnMoldDelete.Size = new System.Drawing.Size(25, 25);
            this.btnMoldDelete.TabIndex = 10;
            this.ttpSystemConfig.SetToolTip(this.btnMoldDelete, "Eliminar");
            this.btnMoldDelete.UseVisualStyleBackColor = true;
            // 
            // btnMoldAdd
            // 
            this.btnMoldAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnMoldAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoldAdd.Location = new System.Drawing.Point(578, 221);
            this.btnMoldAdd.Name = "btnMoldAdd";
            this.btnMoldAdd.Size = new System.Drawing.Size(25, 25);
            this.btnMoldAdd.TabIndex = 1;
            this.ttpSystemConfig.SetToolTip(this.btnMoldAdd, "Agregar");
            this.btnMoldAdd.UseVisualStyleBackColor = true;
            this.btnMoldAdd.Click += new System.EventHandler(this.btnMoldAdd_Click);
            // 
            // btnMoldEdit
            // 
            this.btnMoldEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnMoldEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoldEdit.Location = new System.Drawing.Point(604, 221);
            this.btnMoldEdit.Name = "btnMoldEdit";
            this.btnMoldEdit.Size = new System.Drawing.Size(25, 25);
            this.btnMoldEdit.TabIndex = 8;
            this.ttpSystemConfig.SetToolTip(this.btnMoldEdit, "Editar");
            this.btnMoldEdit.UseVisualStyleBackColor = true;
            this.btnMoldEdit.Click += new System.EventHandler(this.btnMoldEdit_Click);
            // 
            // dgvMold
            // 
            this.dgvMold.AllowUserToAddRows = false;
            this.dgvMold.AllowUserToDeleteRows = false;
            this.dgvMold.AllowUserToOrderColumns = true;
            this.dgvMold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMoldCodsec,
            this.clmMoldName,
            this.clmMoldDescription,
            this.clmMoldProduct,
            this.clmMoldCavityNumber});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMold.Location = new System.Drawing.Point(3, 17);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMold.Size = new System.Drawing.Size(660, 198);
            this.dgvMold.TabIndex = 0;
            // 
            // clmMoldCodsec
            // 
            this.clmMoldCodsec.HeaderText = "Codsec";
            this.clmMoldCodsec.Name = "clmMoldCodsec";
            this.clmMoldCodsec.ReadOnly = true;
            this.clmMoldCodsec.Visible = false;
            // 
            // clmMoldName
            // 
            this.clmMoldName.HeaderText = "Nombre";
            this.clmMoldName.Name = "clmMoldName";
            this.clmMoldName.ReadOnly = true;
            this.clmMoldName.Width = 150;
            // 
            // clmMoldDescription
            // 
            this.clmMoldDescription.HeaderText = "Descripción";
            this.clmMoldDescription.Name = "clmMoldDescription";
            this.clmMoldDescription.ReadOnly = true;
            this.clmMoldDescription.Width = 150;
            // 
            // clmMoldProduct
            // 
            this.clmMoldProduct.HeaderText = "Producto";
            this.clmMoldProduct.Name = "clmMoldProduct";
            this.clmMoldProduct.ReadOnly = true;
            this.clmMoldProduct.Width = 150;
            // 
            // clmMoldCavityNumber
            // 
            this.clmMoldCavityNumber.HeaderText = "Número Cavidades";
            this.clmMoldCavityNumber.Name = "clmMoldCavityNumber";
            this.clmMoldCavityNumber.ReadOnly = true;
            // 
            // grpbMoldForm
            // 
            this.grpbMoldForm.Controls.Add(this.cmbMoldProduct);
            this.grpbMoldForm.Controls.Add(this.txtMoldDescription);
            this.grpbMoldForm.Controls.Add(this.lblMoldDescription);
            this.grpbMoldForm.Controls.Add(this.txtMoldCavityNumber);
            this.grpbMoldForm.Controls.Add(this.lblMoldCavityNumber);
            this.grpbMoldForm.Controls.Add(this.btnMoldCancel);
            this.grpbMoldForm.Controls.Add(this.btnMoldSave);
            this.grpbMoldForm.Controls.Add(this.txtMoldName);
            this.grpbMoldForm.Controls.Add(this.lblMoldProduct);
            this.grpbMoldForm.Controls.Add(this.lblMoldName);
            this.grpbMoldForm.Location = new System.Drawing.Point(3, 259);
            this.grpbMoldForm.Name = "grpbMoldForm";
            this.grpbMoldForm.Size = new System.Drawing.Size(660, 264);
            this.grpbMoldForm.TabIndex = 5;
            this.grpbMoldForm.TabStop = false;
            // 
            // cmbMoldProduct
            // 
            this.cmbMoldProduct.FormattingEnabled = true;
            this.cmbMoldProduct.Location = new System.Drawing.Point(415, 28);
            this.cmbMoldProduct.Name = "cmbMoldProduct";
            this.cmbMoldProduct.Size = new System.Drawing.Size(221, 23);
            this.cmbMoldProduct.TabIndex = 3;
            // 
            // txtMoldDescription
            // 
            this.txtMoldDescription.Location = new System.Drawing.Point(413, 73);
            this.txtMoldDescription.Name = "txtMoldDescription";
            this.txtMoldDescription.Size = new System.Drawing.Size(224, 21);
            this.txtMoldDescription.TabIndex = 5;
            // 
            // lblMoldDescription
            // 
            this.lblMoldDescription.AutoSize = true;
            this.lblMoldDescription.Location = new System.Drawing.Point(321, 74);
            this.lblMoldDescription.Name = "lblMoldDescription";
            this.lblMoldDescription.Size = new System.Drawing.Size(72, 15);
            this.lblMoldDescription.TabIndex = 46;
            this.lblMoldDescription.Text = "Descripción";
            // 
            // txtMoldCavityNumber
            // 
            this.txtMoldCavityNumber.Location = new System.Drawing.Point(142, 70);
            this.txtMoldCavityNumber.Name = "txtMoldCavityNumber";
            this.txtMoldCavityNumber.Size = new System.Drawing.Size(121, 21);
            this.txtMoldCavityNumber.TabIndex = 4;
            // 
            // lblMoldCavityNumber
            // 
            this.lblMoldCavityNumber.AutoSize = true;
            this.lblMoldCavityNumber.Location = new System.Drawing.Point(18, 74);
            this.lblMoldCavityNumber.Name = "lblMoldCavityNumber";
            this.lblMoldCavityNumber.Size = new System.Drawing.Size(112, 15);
            this.lblMoldCavityNumber.TabIndex = 44;
            this.lblMoldCavityNumber.Text = "Número Cavidades";
            // 
            // btnMoldCancel
            // 
            this.btnMoldCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoldCancel.BackgroundImage")));
            this.btnMoldCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoldCancel.Location = new System.Drawing.Point(627, 233);
            this.btnMoldCancel.Name = "btnMoldCancel";
            this.btnMoldCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMoldCancel.TabIndex = 7;
            this.ttpSystemConfig.SetToolTip(this.btnMoldCancel, "Cancelar");
            this.btnMoldCancel.UseVisualStyleBackColor = true;
            this.btnMoldCancel.Click += new System.EventHandler(this.btnMoldCancel_Click);
            // 
            // btnMoldSave
            // 
            this.btnMoldSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoldSave.BackgroundImage")));
            this.btnMoldSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoldSave.Location = new System.Drawing.Point(602, 233);
            this.btnMoldSave.Name = "btnMoldSave";
            this.btnMoldSave.Size = new System.Drawing.Size(25, 25);
            this.btnMoldSave.TabIndex = 6;
            this.ttpSystemConfig.SetToolTip(this.btnMoldSave, "Guardar");
            this.btnMoldSave.UseVisualStyleBackColor = true;
            this.btnMoldSave.Click += new System.EventHandler(this.btnMoldSave_Click);
            // 
            // txtMoldName
            // 
            this.txtMoldName.Location = new System.Drawing.Point(142, 30);
            this.txtMoldName.Name = "txtMoldName";
            this.txtMoldName.Size = new System.Drawing.Size(121, 21);
            this.txtMoldName.TabIndex = 2;
            // 
            // lblMoldProduct
            // 
            this.lblMoldProduct.AutoSize = true;
            this.lblMoldProduct.Location = new System.Drawing.Point(321, 33);
            this.lblMoldProduct.Name = "lblMoldProduct";
            this.lblMoldProduct.Size = new System.Drawing.Size(56, 15);
            this.lblMoldProduct.TabIndex = 1;
            this.lblMoldProduct.Text = "Producto";
            // 
            // lblMoldName
            // 
            this.lblMoldName.AutoSize = true;
            this.lblMoldName.Location = new System.Drawing.Point(18, 33);
            this.lblMoldName.Name = "lblMoldName";
            this.lblMoldName.Size = new System.Drawing.Size(52, 15);
            this.lblMoldName.TabIndex = 0;
            this.lblMoldName.Text = "Nombre";
            // 
            // pnlThermExtruder
            // 
            this.pnlThermExtruder.Controls.Add(this.grpbThermExtruderView);
            this.pnlThermExtruder.Controls.Add(this.grpbThermExtruderForm);
            this.pnlThermExtruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThermExtruder.Location = new System.Drawing.Point(0, 0);
            this.pnlThermExtruder.Name = "pnlThermExtruder";
            this.pnlThermExtruder.Size = new System.Drawing.Size(666, 524);
            this.pnlThermExtruder.TabIndex = 1;
            // 
            // grpbThermExtruderView
            // 
            this.grpbThermExtruderView.Controls.Add(this.button1);
            this.grpbThermExtruderView.Controls.Add(this.btnThermExtruderAdd);
            this.grpbThermExtruderView.Controls.Add(this.btnThermExtruderEdit);
            this.grpbThermExtruderView.Controls.Add(this.dgvThermExtruder);
            this.grpbThermExtruderView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThermExtruderView.Location = new System.Drawing.Point(0, 0);
            this.grpbThermExtruderView.Name = "grpbThermExtruderView";
            this.grpbThermExtruderView.Size = new System.Drawing.Size(666, 253);
            this.grpbThermExtruderView.TabIndex = 6;
            this.grpbThermExtruderView.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(630, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThermExtruderAdd
            // 
            this.btnThermExtruderAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnThermExtruderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermExtruderAdd.Location = new System.Drawing.Point(578, 221);
            this.btnThermExtruderAdd.Name = "btnThermExtruderAdd";
            this.btnThermExtruderAdd.Size = new System.Drawing.Size(25, 25);
            this.btnThermExtruderAdd.TabIndex = 1;
            this.btnThermExtruderAdd.UseVisualStyleBackColor = true;
            this.btnThermExtruderAdd.Click += new System.EventHandler(this.btnThermExtruderAdd_Click);
            // 
            // btnThermExtruderEdit
            // 
            this.btnThermExtruderEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnThermExtruderEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermExtruderEdit.Location = new System.Drawing.Point(604, 221);
            this.btnThermExtruderEdit.Name = "btnThermExtruderEdit";
            this.btnThermExtruderEdit.Size = new System.Drawing.Size(25, 25);
            this.btnThermExtruderEdit.TabIndex = 10;
            this.btnThermExtruderEdit.UseVisualStyleBackColor = true;
            this.btnThermExtruderEdit.Click += new System.EventHandler(this.btnThermExtruderEdit_Click);
            // 
            // dgvThermExtruder
            // 
            this.dgvThermExtruder.AllowUserToAddRows = false;
            this.dgvThermExtruder.AllowUserToDeleteRows = false;
            this.dgvThermExtruder.AllowUserToOrderColumns = true;
            this.dgvThermExtruder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThermExtruder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThermExtruderCodesc,
            this.clmThermExtruderName,
            this.clmThermExtruderMinFilmWidth,
            this.clmThermExtruderMaxFilmWidth,
            this.clmThermExtruderMaxVelocity,
            this.clmThermExtruderCoilNumber,
            this.clmThermExtruderKgPerHour});
            this.dgvThermExtruder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThermExtruder.Location = new System.Drawing.Point(3, 17);
            this.dgvThermExtruder.Name = "dgvThermExtruder";
            this.dgvThermExtruder.ReadOnly = true;
            this.dgvThermExtruder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThermExtruder.Size = new System.Drawing.Size(660, 198);
            this.dgvThermExtruder.TabIndex = 0;
            // 
            // clmThermExtruderCodesc
            // 
            this.clmThermExtruderCodesc.HeaderText = "Codsec";
            this.clmThermExtruderCodesc.Name = "clmThermExtruderCodesc";
            this.clmThermExtruderCodesc.ReadOnly = true;
            this.clmThermExtruderCodesc.Visible = false;
            this.clmThermExtruderCodesc.Width = 80;
            // 
            // clmThermExtruderName
            // 
            this.clmThermExtruderName.HeaderText = "Nombre";
            this.clmThermExtruderName.Name = "clmThermExtruderName";
            this.clmThermExtruderName.ReadOnly = true;
            this.clmThermExtruderName.Width = 120;
            // 
            // clmThermExtruderMinFilmWidth
            // 
            this.clmThermExtruderMinFilmWidth.HeaderText = "Ancho Mín. Película";
            this.clmThermExtruderMinFilmWidth.Name = "clmThermExtruderMinFilmWidth";
            this.clmThermExtruderMinFilmWidth.ReadOnly = true;
            // 
            // clmThermExtruderMaxFilmWidth
            // 
            this.clmThermExtruderMaxFilmWidth.HeaderText = "Ancho Máx. Película";
            this.clmThermExtruderMaxFilmWidth.Name = "clmThermExtruderMaxFilmWidth";
            this.clmThermExtruderMaxFilmWidth.ReadOnly = true;
            // 
            // clmThermExtruderMaxVelocity
            // 
            this.clmThermExtruderMaxVelocity.HeaderText = "Velocidad Máx.";
            this.clmThermExtruderMaxVelocity.Name = "clmThermExtruderMaxVelocity";
            this.clmThermExtruderMaxVelocity.ReadOnly = true;
            // 
            // clmThermExtruderCoilNumber
            // 
            this.clmThermExtruderCoilNumber.HeaderText = "Nro. Bobinas";
            this.clmThermExtruderCoilNumber.Name = "clmThermExtruderCoilNumber";
            this.clmThermExtruderCoilNumber.ReadOnly = true;
            // 
            // clmThermExtruderKgPerHour
            // 
            this.clmThermExtruderKgPerHour.HeaderText = "Kg / Hr";
            this.clmThermExtruderKgPerHour.Name = "clmThermExtruderKgPerHour";
            this.clmThermExtruderKgPerHour.ReadOnly = true;
            // 
            // grpbThermExtruderForm
            // 
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderKgPerHour);
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderCoilNumbers);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderKgPerHour);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderCoilNumbers);
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderMaxVelocity);
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderMaxFilmWidth);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderMaxVelocity);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderMaxFilmWidth);
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderMinFilmWidth);
            this.grpbThermExtruderForm.Controls.Add(this.btnThermExtruderCancel);
            this.grpbThermExtruderForm.Controls.Add(this.btnThermExtruderSave);
            this.grpbThermExtruderForm.Controls.Add(this.txtThermExtruderName);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderMinFilmWidth);
            this.grpbThermExtruderForm.Controls.Add(this.lblThermExtruderName);
            this.grpbThermExtruderForm.Location = new System.Drawing.Point(3, 260);
            this.grpbThermExtruderForm.Name = "grpbThermExtruderForm";
            this.grpbThermExtruderForm.Size = new System.Drawing.Size(660, 264);
            this.grpbThermExtruderForm.TabIndex = 7;
            this.grpbThermExtruderForm.TabStop = false;
            // 
            // txtThermExtruderKgPerHour
            // 
            this.txtThermExtruderKgPerHour.Location = new System.Drawing.Point(480, 126);
            this.txtThermExtruderKgPerHour.Name = "txtThermExtruderKgPerHour";
            this.txtThermExtruderKgPerHour.Size = new System.Drawing.Size(100, 21);
            this.txtThermExtruderKgPerHour.TabIndex = 7;
            // 
            // txtThermExtruderCoilNumbers
            // 
            this.txtThermExtruderCoilNumbers.Location = new System.Drawing.Point(154, 126);
            this.txtThermExtruderCoilNumbers.Name = "txtThermExtruderCoilNumbers";
            this.txtThermExtruderCoilNumbers.Size = new System.Drawing.Size(152, 21);
            this.txtThermExtruderCoilNumbers.TabIndex = 6;
            // 
            // lblThermExtruderKgPerHour
            // 
            this.lblThermExtruderKgPerHour.AutoSize = true;
            this.lblThermExtruderKgPerHour.Location = new System.Drawing.Point(349, 129);
            this.lblThermExtruderKgPerHour.Name = "lblThermExtruderKgPerHour";
            this.lblThermExtruderKgPerHour.Size = new System.Drawing.Size(106, 15);
            this.lblThermExtruderKgPerHour.TabIndex = 53;
            this.lblThermExtruderKgPerHour.Text = "Kilogramos / Hora";
            // 
            // lblThermExtruderCoilNumbers
            // 
            this.lblThermExtruderCoilNumbers.AutoSize = true;
            this.lblThermExtruderCoilNumbers.Location = new System.Drawing.Point(30, 129);
            this.lblThermExtruderCoilNumbers.Name = "lblThermExtruderCoilNumbers";
            this.lblThermExtruderCoilNumbers.Size = new System.Drawing.Size(103, 15);
            this.lblThermExtruderCoilNumbers.TabIndex = 52;
            this.lblThermExtruderCoilNumbers.Text = "Número Bobinas ";
            // 
            // txtThermExtruderMaxVelocity
            // 
            this.txtThermExtruderMaxVelocity.Location = new System.Drawing.Point(479, 76);
            this.txtThermExtruderMaxVelocity.Name = "txtThermExtruderMaxVelocity";
            this.txtThermExtruderMaxVelocity.Size = new System.Drawing.Size(100, 21);
            this.txtThermExtruderMaxVelocity.TabIndex = 5;
            // 
            // txtThermExtruderMaxFilmWidth
            // 
            this.txtThermExtruderMaxFilmWidth.Location = new System.Drawing.Point(154, 76);
            this.txtThermExtruderMaxFilmWidth.Name = "txtThermExtruderMaxFilmWidth";
            this.txtThermExtruderMaxFilmWidth.Size = new System.Drawing.Size(151, 21);
            this.txtThermExtruderMaxFilmWidth.TabIndex = 4;
            // 
            // lblThermExtruderMaxVelocity
            // 
            this.lblThermExtruderMaxVelocity.AutoSize = true;
            this.lblThermExtruderMaxVelocity.Location = new System.Drawing.Point(348, 79);
            this.lblThermExtruderMaxVelocity.Name = "lblThermExtruderMaxVelocity";
            this.lblThermExtruderMaxVelocity.Size = new System.Drawing.Size(109, 15);
            this.lblThermExtruderMaxVelocity.TabIndex = 49;
            this.lblThermExtruderMaxVelocity.Text = "Velocidad Máxima";
            // 
            // lblThermExtruderMaxFilmWidth
            // 
            this.lblThermExtruderMaxFilmWidth.AutoSize = true;
            this.lblThermExtruderMaxFilmWidth.Location = new System.Drawing.Point(29, 79);
            this.lblThermExtruderMaxFilmWidth.Name = "lblThermExtruderMaxFilmWidth";
            this.lblThermExtruderMaxFilmWidth.Size = new System.Drawing.Size(118, 15);
            this.lblThermExtruderMaxFilmWidth.TabIndex = 48;
            this.lblThermExtruderMaxFilmWidth.Text = "Ancho Máx. Película";
            // 
            // txtThermExtruderMinFilmWidth
            // 
            this.txtThermExtruderMinFilmWidth.Location = new System.Drawing.Point(479, 30);
            this.txtThermExtruderMinFilmWidth.Name = "txtThermExtruderMinFilmWidth";
            this.txtThermExtruderMinFilmWidth.Size = new System.Drawing.Size(100, 21);
            this.txtThermExtruderMinFilmWidth.TabIndex = 3;
            // 
            // btnThermExtruderCancel
            // 
            this.btnThermExtruderCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermExtruderCancel.BackgroundImage")));
            this.btnThermExtruderCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermExtruderCancel.Location = new System.Drawing.Point(627, 233);
            this.btnThermExtruderCancel.Name = "btnThermExtruderCancel";
            this.btnThermExtruderCancel.Size = new System.Drawing.Size(25, 25);
            this.btnThermExtruderCancel.TabIndex = 9;
            this.btnThermExtruderCancel.UseVisualStyleBackColor = true;
            this.btnThermExtruderCancel.Click += new System.EventHandler(this.btnThermExtruderCancel_Click);
            // 
            // btnThermExtruderSave
            // 
            this.btnThermExtruderSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermExtruderSave.BackgroundImage")));
            this.btnThermExtruderSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermExtruderSave.Location = new System.Drawing.Point(602, 233);
            this.btnThermExtruderSave.Name = "btnThermExtruderSave";
            this.btnThermExtruderSave.Size = new System.Drawing.Size(25, 25);
            this.btnThermExtruderSave.TabIndex = 8;
            this.btnThermExtruderSave.UseVisualStyleBackColor = true;
            this.btnThermExtruderSave.Click += new System.EventHandler(this.btnThermExtruderSave_Click);
            // 
            // txtThermExtruderName
            // 
            this.txtThermExtruderName.Location = new System.Drawing.Point(103, 30);
            this.txtThermExtruderName.Name = "txtThermExtruderName";
            this.txtThermExtruderName.Size = new System.Drawing.Size(202, 21);
            this.txtThermExtruderName.TabIndex = 2;
            // 
            // lblThermExtruderMinFilmWidth
            // 
            this.lblThermExtruderMinFilmWidth.AutoSize = true;
            this.lblThermExtruderMinFilmWidth.Location = new System.Drawing.Point(348, 33);
            this.lblThermExtruderMinFilmWidth.Name = "lblThermExtruderMinFilmWidth";
            this.lblThermExtruderMinFilmWidth.Size = new System.Drawing.Size(115, 15);
            this.lblThermExtruderMinFilmWidth.TabIndex = 1;
            this.lblThermExtruderMinFilmWidth.Text = "Ancho Mín. Película";
            // 
            // lblThermExtruderName
            // 
            this.lblThermExtruderName.AutoSize = true;
            this.lblThermExtruderName.Location = new System.Drawing.Point(29, 33);
            this.lblThermExtruderName.Name = "lblThermExtruderName";
            this.lblThermExtruderName.Size = new System.Drawing.Size(52, 15);
            this.lblThermExtruderName.TabIndex = 0;
            this.lblThermExtruderName.Text = "Nombre";
            // 
            // pnlThermByExtruder
            // 
            this.pnlThermByExtruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThermByExtruder.Location = new System.Drawing.Point(0, 0);
            this.pnlThermByExtruder.Name = "pnlThermByExtruder";
            this.pnlThermByExtruder.Size = new System.Drawing.Size(666, 524);
            this.pnlThermByExtruder.TabIndex = 1;
            // 
            // pnlThermDefects
            // 
            this.pnlThermDefects.Controls.Add(this.grpbThermDefectsView);
            this.pnlThermDefects.Controls.Add(this.grpbThermDefectsForm);
            this.pnlThermDefects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThermDefects.Location = new System.Drawing.Point(0, 0);
            this.pnlThermDefects.Name = "pnlThermDefects";
            this.pnlThermDefects.Size = new System.Drawing.Size(666, 524);
            this.pnlThermDefects.TabIndex = 1;
            // 
            // grpbThermDefectsView
            // 
            this.grpbThermDefectsView.Controls.Add(this.btnThermDefectsDelete);
            this.grpbThermDefectsView.Controls.Add(this.btnThermDefectsAdd);
            this.grpbThermDefectsView.Controls.Add(this.btnThermDefectsEdit);
            this.grpbThermDefectsView.Controls.Add(this.dgvThermDefect);
            this.grpbThermDefectsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThermDefectsView.Location = new System.Drawing.Point(0, 0);
            this.grpbThermDefectsView.Name = "grpbThermDefectsView";
            this.grpbThermDefectsView.Size = new System.Drawing.Size(666, 253);
            this.grpbThermDefectsView.TabIndex = 8;
            this.grpbThermDefectsView.TabStop = false;
            // 
            // btnThermDefectsDelete
            // 
            this.btnThermDefectsDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnThermDefectsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermDefectsDelete.Location = new System.Drawing.Point(630, 221);
            this.btnThermDefectsDelete.Name = "btnThermDefectsDelete";
            this.btnThermDefectsDelete.Size = new System.Drawing.Size(25, 25);
            this.btnThermDefectsDelete.TabIndex = 7;
            this.btnThermDefectsDelete.UseVisualStyleBackColor = true;
            // 
            // btnThermDefectsAdd
            // 
            this.btnThermDefectsAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnThermDefectsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermDefectsAdd.Location = new System.Drawing.Point(578, 221);
            this.btnThermDefectsAdd.Name = "btnThermDefectsAdd";
            this.btnThermDefectsAdd.Size = new System.Drawing.Size(25, 25);
            this.btnThermDefectsAdd.TabIndex = 1;
            this.btnThermDefectsAdd.UseVisualStyleBackColor = true;
            this.btnThermDefectsAdd.Click += new System.EventHandler(this.btnThermDefectsAdd_Click);
            // 
            // btnThermDefectsEdit
            // 
            this.btnThermDefectsEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnThermDefectsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermDefectsEdit.Location = new System.Drawing.Point(604, 221);
            this.btnThermDefectsEdit.Name = "btnThermDefectsEdit";
            this.btnThermDefectsEdit.Size = new System.Drawing.Size(25, 25);
            this.btnThermDefectsEdit.TabIndex = 6;
            this.btnThermDefectsEdit.UseVisualStyleBackColor = true;
            this.btnThermDefectsEdit.Click += new System.EventHandler(this.btnThermDefectsEdit_Click);
            // 
            // dgvThermDefect
            // 
            this.dgvThermDefect.AllowUserToAddRows = false;
            this.dgvThermDefect.AllowUserToDeleteRows = false;
            this.dgvThermDefect.AllowUserToOrderColumns = true;
            this.dgvThermDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThermDefect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThermDefectsCodsec,
            this.clmThermDefectsName,
            this.clmThermDefectsDescription});
            this.dgvThermDefect.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThermDefect.Location = new System.Drawing.Point(3, 17);
            this.dgvThermDefect.Name = "dgvThermDefect";
            this.dgvThermDefect.ReadOnly = true;
            this.dgvThermDefect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThermDefect.Size = new System.Drawing.Size(660, 198);
            this.dgvThermDefect.TabIndex = 0;
            // 
            // clmThermDefectsCodsec
            // 
            this.clmThermDefectsCodsec.HeaderText = "Codsec";
            this.clmThermDefectsCodsec.Name = "clmThermDefectsCodsec";
            this.clmThermDefectsCodsec.ReadOnly = true;
            this.clmThermDefectsCodsec.Visible = false;
            this.clmThermDefectsCodsec.Width = 80;
            // 
            // clmThermDefectsName
            // 
            this.clmThermDefectsName.HeaderText = "Nombre";
            this.clmThermDefectsName.Name = "clmThermDefectsName";
            this.clmThermDefectsName.ReadOnly = true;
            this.clmThermDefectsName.Width = 120;
            // 
            // clmThermDefectsDescription
            // 
            this.clmThermDefectsDescription.HeaderText = "Descripción";
            this.clmThermDefectsDescription.Name = "clmThermDefectsDescription";
            this.clmThermDefectsDescription.ReadOnly = true;
            this.clmThermDefectsDescription.Width = 250;
            // 
            // grpbThermDefectsForm
            // 
            this.grpbThermDefectsForm.Controls.Add(this.txtThermDefectDescription);
            this.grpbThermDefectsForm.Controls.Add(this.lblThermDefectDescription);
            this.grpbThermDefectsForm.Controls.Add(this.btnThermDefectsCancel);
            this.grpbThermDefectsForm.Controls.Add(this.btnThermDefectsSave);
            this.grpbThermDefectsForm.Controls.Add(this.txtThermDefectName);
            this.grpbThermDefectsForm.Controls.Add(this.lblThermDefectName);
            this.grpbThermDefectsForm.Location = new System.Drawing.Point(3, 260);
            this.grpbThermDefectsForm.Name = "grpbThermDefectsForm";
            this.grpbThermDefectsForm.Size = new System.Drawing.Size(660, 264);
            this.grpbThermDefectsForm.TabIndex = 9;
            this.grpbThermDefectsForm.TabStop = false;
            // 
            // txtThermDefectDescription
            // 
            this.txtThermDefectDescription.Location = new System.Drawing.Point(112, 74);
            this.txtThermDefectDescription.Name = "txtThermDefectDescription";
            this.txtThermDefectDescription.Size = new System.Drawing.Size(529, 21);
            this.txtThermDefectDescription.TabIndex = 3;
            // 
            // lblThermDefectDescription
            // 
            this.lblThermDefectDescription.AutoSize = true;
            this.lblThermDefectDescription.Location = new System.Drawing.Point(29, 79);
            this.lblThermDefectDescription.Name = "lblThermDefectDescription";
            this.lblThermDefectDescription.Size = new System.Drawing.Size(72, 15);
            this.lblThermDefectDescription.TabIndex = 48;
            this.lblThermDefectDescription.Text = "Descripción";
            // 
            // btnThermDefectsCancel
            // 
            this.btnThermDefectsCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermDefectsCancel.BackgroundImage")));
            this.btnThermDefectsCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermDefectsCancel.Location = new System.Drawing.Point(627, 233);
            this.btnThermDefectsCancel.Name = "btnThermDefectsCancel";
            this.btnThermDefectsCancel.Size = new System.Drawing.Size(25, 25);
            this.btnThermDefectsCancel.TabIndex = 5;
            this.btnThermDefectsCancel.UseVisualStyleBackColor = true;
            this.btnThermDefectsCancel.Click += new System.EventHandler(this.btnThermDefectsCancel_Click);
            // 
            // btnThermDefectsSave
            // 
            this.btnThermDefectsSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermDefectsSave.BackgroundImage")));
            this.btnThermDefectsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermDefectsSave.Location = new System.Drawing.Point(602, 233);
            this.btnThermDefectsSave.Name = "btnThermDefectsSave";
            this.btnThermDefectsSave.Size = new System.Drawing.Size(25, 25);
            this.btnThermDefectsSave.TabIndex = 4;
            this.btnThermDefectsSave.UseVisualStyleBackColor = true;
            this.btnThermDefectsSave.Click += new System.EventHandler(this.btnThermDefectsSave_Click);
            // 
            // txtThermDefectName
            // 
            this.txtThermDefectName.Location = new System.Drawing.Point(112, 30);
            this.txtThermDefectName.Name = "txtThermDefectName";
            this.txtThermDefectName.Size = new System.Drawing.Size(202, 21);
            this.txtThermDefectName.TabIndex = 2;
            // 
            // lblThermDefectName
            // 
            this.lblThermDefectName.AutoSize = true;
            this.lblThermDefectName.Location = new System.Drawing.Point(29, 33);
            this.lblThermDefectName.Name = "lblThermDefectName";
            this.lblThermDefectName.Size = new System.Drawing.Size(52, 15);
            this.lblThermDefectName.TabIndex = 0;
            this.lblThermDefectName.Text = "Nombre";
            // 
            // pnlSupply
            // 
            this.pnlSupply.Controls.Add(this.grpbSupply);
            this.pnlSupply.Controls.Add(this.grpbSupplyForm);
            this.pnlSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupply.Location = new System.Drawing.Point(0, 0);
            this.pnlSupply.Name = "pnlSupply";
            this.pnlSupply.Size = new System.Drawing.Size(666, 524);
            this.pnlSupply.TabIndex = 1;
            // 
            // grpbSupply
            // 
            this.grpbSupply.Controls.Add(this.btnSupplyAdd);
            this.grpbSupply.Controls.Add(this.btnSupplyEdit);
            this.grpbSupply.Controls.Add(this.btnSupplyDelete);
            this.grpbSupply.Controls.Add(this.dgvSupply);
            this.grpbSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSupply.Location = new System.Drawing.Point(0, 0);
            this.grpbSupply.Name = "grpbSupply";
            this.grpbSupply.Size = new System.Drawing.Size(666, 253);
            this.grpbSupply.TabIndex = 2;
            this.grpbSupply.TabStop = false;
            // 
            // btnSupplyAdd
            // 
            this.btnSupplyAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyAdd.BackgroundImage")));
            this.btnSupplyAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyAdd.Location = new System.Drawing.Point(578, 221);
            this.btnSupplyAdd.Name = "btnSupplyAdd";
            this.btnSupplyAdd.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyAdd.TabIndex = 48;
            this.btnSupplyAdd.UseVisualStyleBackColor = true;
            this.btnSupplyAdd.Click += new System.EventHandler(this.btnSupplyAdd_Click);
            // 
            // btnSupplyEdit
            // 
            this.btnSupplyEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyEdit.BackgroundImage")));
            this.btnSupplyEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyEdit.Location = new System.Drawing.Point(604, 221);
            this.btnSupplyEdit.Name = "btnSupplyEdit";
            this.btnSupplyEdit.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyEdit.TabIndex = 46;
            this.btnSupplyEdit.UseVisualStyleBackColor = true;
            this.btnSupplyEdit.Click += new System.EventHandler(this.btnSupplyEdit_Click);
            // 
            // btnSupplyDelete
            // 
            this.btnSupplyDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyDelete.BackgroundImage")));
            this.btnSupplyDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyDelete.Location = new System.Drawing.Point(630, 221);
            this.btnSupplyDelete.Name = "btnSupplyDelete";
            this.btnSupplyDelete.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyDelete.TabIndex = 47;
            this.btnSupplyDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSupply
            // 
            this.dgvSupply.AllowUserToAddRows = false;
            this.dgvSupply.AllowUserToDeleteRows = false;
            this.dgvSupply.AllowUserToOrderColumns = true;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSupplyCodsec,
            this.clmSupplyEntity,
            this.clmSupplyName,
            this.clmSupplyCode,
            this.clmSupplyUnit,
            this.clmSupplyCreatedDate,
            this.clmSupplyCreatedBy,
            this.clmSupplyModifiedDate,
            this.clmSupplyModifiedBy});
            this.dgvSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSupply.Location = new System.Drawing.Point(3, 17);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.ReadOnly = true;
            this.dgvSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupply.Size = new System.Drawing.Size(660, 198);
            this.dgvSupply.TabIndex = 0;
            // 
            // clmSupplyCodsec
            // 
            this.clmSupplyCodsec.HeaderText = "Codsec";
            this.clmSupplyCodsec.Name = "clmSupplyCodsec";
            this.clmSupplyCodsec.ReadOnly = true;
            this.clmSupplyCodsec.Visible = false;
            // 
            // clmSupplyEntity
            // 
            this.clmSupplyEntity.HeaderText = "Proveedor";
            this.clmSupplyEntity.Name = "clmSupplyEntity";
            this.clmSupplyEntity.ReadOnly = true;
            // 
            // clmSupplyName
            // 
            this.clmSupplyName.HeaderText = "Nombre";
            this.clmSupplyName.Name = "clmSupplyName";
            this.clmSupplyName.ReadOnly = true;
            // 
            // clmSupplyCode
            // 
            this.clmSupplyCode.HeaderText = "Código";
            this.clmSupplyCode.Name = "clmSupplyCode";
            this.clmSupplyCode.ReadOnly = true;
            // 
            // clmSupplyUnit
            // 
            this.clmSupplyUnit.HeaderText = "Unidad";
            this.clmSupplyUnit.Name = "clmSupplyUnit";
            this.clmSupplyUnit.ReadOnly = true;
            // 
            // clmSupplyCreatedDate
            // 
            this.clmSupplyCreatedDate.HeaderText = "Fecha Creación";
            this.clmSupplyCreatedDate.Name = "clmSupplyCreatedDate";
            this.clmSupplyCreatedDate.ReadOnly = true;
            // 
            // clmSupplyCreatedBy
            // 
            this.clmSupplyCreatedBy.HeaderText = "Creado Por";
            this.clmSupplyCreatedBy.Name = "clmSupplyCreatedBy";
            this.clmSupplyCreatedBy.ReadOnly = true;
            // 
            // clmSupplyModifiedDate
            // 
            this.clmSupplyModifiedDate.HeaderText = "Fecha Modificado";
            this.clmSupplyModifiedDate.Name = "clmSupplyModifiedDate";
            this.clmSupplyModifiedDate.ReadOnly = true;
            // 
            // clmSupplyModifiedBy
            // 
            this.clmSupplyModifiedBy.HeaderText = "Modificado Por";
            this.clmSupplyModifiedBy.Name = "clmSupplyModifiedBy";
            this.clmSupplyModifiedBy.ReadOnly = true;
            // 
            // grpbSupplyForm
            // 
            this.grpbSupplyForm.Controls.Add(this.btnSupplyCancel);
            this.grpbSupplyForm.Controls.Add(this.btnSupplySave);
            this.grpbSupplyForm.Controls.Add(this.txtSupplyNotes);
            this.grpbSupplyForm.Controls.Add(this.lblSupplyNotes);
            this.grpbSupplyForm.Controls.Add(this.cmbUnit);
            this.grpbSupplyForm.Controls.Add(this.lblUnit);
            this.grpbSupplyForm.Controls.Add(this.txtSupplyCode);
            this.grpbSupplyForm.Controls.Add(this.lblSupplyCode);
            this.grpbSupplyForm.Controls.Add(this.txtSupplyName);
            this.grpbSupplyForm.Controls.Add(this.lblSupplyName);
            this.grpbSupplyForm.Controls.Add(this.cmbSupplyEntity);
            this.grpbSupplyForm.Controls.Add(this.lblSupplyEntity);
            this.grpbSupplyForm.Location = new System.Drawing.Point(3, 257);
            this.grpbSupplyForm.Name = "grpbSupplyForm";
            this.grpbSupplyForm.Size = new System.Drawing.Size(660, 264);
            this.grpbSupplyForm.TabIndex = 3;
            this.grpbSupplyForm.TabStop = false;
            // 
            // btnSupplyCancel
            // 
            this.btnSupplyCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnSupplyCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyCancel.Location = new System.Drawing.Point(627, 233);
            this.btnSupplyCancel.Name = "btnSupplyCancel";
            this.btnSupplyCancel.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyCancel.TabIndex = 43;
            this.btnSupplyCancel.UseVisualStyleBackColor = true;
            this.btnSupplyCancel.Click += new System.EventHandler(this.btnSupplyCancel_Click);
            // 
            // btnSupplySave
            // 
            this.btnSupplySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplySave.BackgroundImage")));
            this.btnSupplySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplySave.Location = new System.Drawing.Point(602, 233);
            this.btnSupplySave.Name = "btnSupplySave";
            this.btnSupplySave.Size = new System.Drawing.Size(25, 25);
            this.btnSupplySave.TabIndex = 42;
            this.btnSupplySave.UseVisualStyleBackColor = true;
            this.btnSupplySave.Click += new System.EventHandler(this.btnSupplySave_Click);
            // 
            // txtSupplyNotes
            // 
            this.txtSupplyNotes.Location = new System.Drawing.Point(91, 121);
            this.txtSupplyNotes.Name = "txtSupplyNotes";
            this.txtSupplyNotes.Size = new System.Drawing.Size(350, 21);
            this.txtSupplyNotes.TabIndex = 5;
            // 
            // lblSupplyNotes
            // 
            this.lblSupplyNotes.AutoSize = true;
            this.lblSupplyNotes.Location = new System.Drawing.Point(3, 125);
            this.lblSupplyNotes.Name = "lblSupplyNotes";
            this.lblSupplyNotes.Size = new System.Drawing.Size(39, 15);
            this.lblSupplyNotes.TabIndex = 12;
            this.lblSupplyNotes.Text = "Notas";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(425, 71);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 23);
            this.cmbUnit.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(289, 77);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(47, 15);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unidad";
            // 
            // txtSupplyCode
            // 
            this.txtSupplyCode.Location = new System.Drawing.Point(91, 75);
            this.txtSupplyCode.Name = "txtSupplyCode";
            this.txtSupplyCode.Size = new System.Drawing.Size(121, 21);
            this.txtSupplyCode.TabIndex = 3;
            // 
            // lblSupplyCode
            // 
            this.lblSupplyCode.AutoSize = true;
            this.lblSupplyCode.Location = new System.Drawing.Point(3, 77);
            this.lblSupplyCode.Name = "lblSupplyCode";
            this.lblSupplyCode.Size = new System.Drawing.Size(46, 15);
            this.lblSupplyCode.TabIndex = 6;
            this.lblSupplyCode.Text = "Código";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Location = new System.Drawing.Point(425, 32);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(121, 21);
            this.txtSupplyName.TabIndex = 2;
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(289, 35);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(52, 15);
            this.lblSupplyName.TabIndex = 4;
            this.lblSupplyName.Text = "Nombre";
            // 
            // cmbSupplyEntity
            // 
            this.cmbSupplyEntity.FormattingEnabled = true;
            this.cmbSupplyEntity.Location = new System.Drawing.Point(91, 32);
            this.cmbSupplyEntity.Name = "cmbSupplyEntity";
            this.cmbSupplyEntity.Size = new System.Drawing.Size(121, 23);
            this.cmbSupplyEntity.TabIndex = 1;
            // 
            // lblSupplyEntity
            // 
            this.lblSupplyEntity.AutoSize = true;
            this.lblSupplyEntity.Location = new System.Drawing.Point(3, 35);
            this.lblSupplyEntity.Name = "lblSupplyEntity";
            this.lblSupplyEntity.Size = new System.Drawing.Size(63, 15);
            this.lblSupplyEntity.TabIndex = 0;
            this.lblSupplyEntity.Text = "Proveedor";
            // 
            // pnlThermoformed
            // 
            this.pnlThermoformed.Controls.Add(this.grpbThermoformedDetail);
            this.pnlThermoformed.Controls.Add(this.grpbThermoformedForm);
            this.pnlThermoformed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThermoformed.Location = new System.Drawing.Point(0, 0);
            this.pnlThermoformed.Name = "pnlThermoformed";
            this.pnlThermoformed.Size = new System.Drawing.Size(666, 524);
            this.pnlThermoformed.TabIndex = 1;
            // 
            // grpbThermoformedDetail
            // 
            this.grpbThermoformedDetail.Controls.Add(this.btnThermoformedDelete);
            this.grpbThermoformedDetail.Controls.Add(this.btnThermoformedAdd);
            this.grpbThermoformedDetail.Controls.Add(this.btnThermoformedEdit);
            this.grpbThermoformedDetail.Controls.Add(this.dgvThermoformed);
            this.grpbThermoformedDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThermoformedDetail.Location = new System.Drawing.Point(0, 0);
            this.grpbThermoformedDetail.Name = "grpbThermoformedDetail";
            this.grpbThermoformedDetail.Size = new System.Drawing.Size(666, 253);
            this.grpbThermoformedDetail.TabIndex = 2;
            this.grpbThermoformedDetail.TabStop = false;
            // 
            // btnThermoformedDelete
            // 
            this.btnThermoformedDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnThermoformedDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermoformedDelete.Location = new System.Drawing.Point(630, 221);
            this.btnThermoformedDelete.Name = "btnThermoformedDelete";
            this.btnThermoformedDelete.Size = new System.Drawing.Size(25, 25);
            this.btnThermoformedDelete.TabIndex = 10;
            this.btnThermoformedDelete.UseVisualStyleBackColor = true;
            // 
            // btnThermoformedAdd
            // 
            this.btnThermoformedAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnThermoformedAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermoformedAdd.Location = new System.Drawing.Point(578, 221);
            this.btnThermoformedAdd.Name = "btnThermoformedAdd";
            this.btnThermoformedAdd.Size = new System.Drawing.Size(25, 25);
            this.btnThermoformedAdd.TabIndex = 8;
            this.btnThermoformedAdd.UseVisualStyleBackColor = true;
            this.btnThermoformedAdd.Click += new System.EventHandler(this.btnThermoformedAdd_Click);
            // 
            // btnThermoformedEdit
            // 
            this.btnThermoformedEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnThermoformedEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermoformedEdit.Location = new System.Drawing.Point(604, 221);
            this.btnThermoformedEdit.Name = "btnThermoformedEdit";
            this.btnThermoformedEdit.Size = new System.Drawing.Size(25, 25);
            this.btnThermoformedEdit.TabIndex = 9;
            this.btnThermoformedEdit.UseVisualStyleBackColor = true;
            this.btnThermoformedEdit.Click += new System.EventHandler(this.btnThermoformedEdit_Click);
            // 
            // dgvThermoformed
            // 
            this.dgvThermoformed.AllowUserToAddRows = false;
            this.dgvThermoformed.AllowUserToDeleteRows = false;
            this.dgvThermoformed.AllowUserToOrderColumns = true;
            this.dgvThermoformed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThermoformed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThermoformedCodsec,
            this.clmThermoformedName,
            this.clmThermoformedFilmWidth,
            this.clmThermoformedMinHitsPerMinute,
            this.clmThermoformedMaxHitsPerMinute,
            this.clmThermoformedIncludeExtruder});
            this.dgvThermoformed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThermoformed.Location = new System.Drawing.Point(3, 17);
            this.dgvThermoformed.Name = "dgvThermoformed";
            this.dgvThermoformed.ReadOnly = true;
            this.dgvThermoformed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThermoformed.Size = new System.Drawing.Size(660, 198);
            this.dgvThermoformed.TabIndex = 0;
            // 
            // clmThermoformedCodsec
            // 
            this.clmThermoformedCodsec.HeaderText = "Codsec";
            this.clmThermoformedCodsec.Name = "clmThermoformedCodsec";
            this.clmThermoformedCodsec.ReadOnly = true;
            this.clmThermoformedCodsec.Visible = false;
            // 
            // clmThermoformedName
            // 
            this.clmThermoformedName.HeaderText = "Nombre";
            this.clmThermoformedName.Name = "clmThermoformedName";
            this.clmThermoformedName.ReadOnly = true;
            this.clmThermoformedName.Width = 150;
            // 
            // clmThermoformedFilmWidth
            // 
            this.clmThermoformedFilmWidth.HeaderText = "Ancho Película";
            this.clmThermoformedFilmWidth.Name = "clmThermoformedFilmWidth";
            this.clmThermoformedFilmWidth.ReadOnly = true;
            // 
            // clmThermoformedMinHitsPerMinute
            // 
            this.clmThermoformedMinHitsPerMinute.HeaderText = "Min. Golpes Por Minuto";
            this.clmThermoformedMinHitsPerMinute.Name = "clmThermoformedMinHitsPerMinute";
            this.clmThermoformedMinHitsPerMinute.ReadOnly = true;
            // 
            // clmThermoformedMaxHitsPerMinute
            // 
            this.clmThermoformedMaxHitsPerMinute.HeaderText = "Max. Golpes por Minuto";
            this.clmThermoformedMaxHitsPerMinute.Name = "clmThermoformedMaxHitsPerMinute";
            this.clmThermoformedMaxHitsPerMinute.ReadOnly = true;
            // 
            // clmThermoformedIncludeExtruder
            // 
            this.clmThermoformedIncludeExtruder.HeaderText = "Incluye Extrusora";
            this.clmThermoformedIncludeExtruder.Name = "clmThermoformedIncludeExtruder";
            this.clmThermoformedIncludeExtruder.ReadOnly = true;
            this.clmThermoformedIncludeExtruder.Width = 150;
            // 
            // grpbThermoformedForm
            // 
            this.grpbThermoformedForm.Controls.Add(this.chbxThermoformedIncludeExtruder);
            this.grpbThermoformedForm.Controls.Add(this.txtThermoformedMaxHitsPerMinute);
            this.grpbThermoformedForm.Controls.Add(this.lblThermoformedMaxHitsPerMinute);
            this.grpbThermoformedForm.Controls.Add(this.txtThermoformedMinHitsPerMinute);
            this.grpbThermoformedForm.Controls.Add(this.lblThermoformedMinHitsPerMinute);
            this.grpbThermoformedForm.Controls.Add(this.btnThermoformedCancel);
            this.grpbThermoformedForm.Controls.Add(this.btnThermoformedSave);
            this.grpbThermoformedForm.Controls.Add(this.txtThermoformedFilmWidth);
            this.grpbThermoformedForm.Controls.Add(this.txtThermoformedName);
            this.grpbThermoformedForm.Controls.Add(this.lblThermoformedFilmWidth);
            this.grpbThermoformedForm.Controls.Add(this.lblThermoformedName);
            this.grpbThermoformedForm.Location = new System.Drawing.Point(3, 257);
            this.grpbThermoformedForm.Name = "grpbThermoformedForm";
            this.grpbThermoformedForm.Size = new System.Drawing.Size(660, 264);
            this.grpbThermoformedForm.TabIndex = 3;
            this.grpbThermoformedForm.TabStop = false;
            // 
            // chbxThermoformedIncludeExtruder
            // 
            this.chbxThermoformedIncludeExtruder.AutoSize = true;
            this.chbxThermoformedIncludeExtruder.Location = new System.Drawing.Point(472, 118);
            this.chbxThermoformedIncludeExtruder.Name = "chbxThermoformedIncludeExtruder";
            this.chbxThermoformedIncludeExtruder.Size = new System.Drawing.Size(107, 17);
            this.chbxThermoformedIncludeExtruder.TabIndex = 5;
            this.chbxThermoformedIncludeExtruder.Text = "Incluye Extrusora";
            this.chbxThermoformedIncludeExtruder.UseVisualStyleBackColor = true;
            // 
            // txtThermoformedMaxHitsPerMinute
            // 
            this.txtThermoformedMaxHitsPerMinute.Location = new System.Drawing.Point(472, 73);
            this.txtThermoformedMaxHitsPerMinute.Name = "txtThermoformedMaxHitsPerMinute";
            this.txtThermoformedMaxHitsPerMinute.Size = new System.Drawing.Size(121, 21);
            this.txtThermoformedMaxHitsPerMinute.TabIndex = 4;
            // 
            // lblThermoformedMaxHitsPerMinute
            // 
            this.lblThermoformedMaxHitsPerMinute.AutoSize = true;
            this.lblThermoformedMaxHitsPerMinute.Location = new System.Drawing.Point(324, 74);
            this.lblThermoformedMaxHitsPerMinute.Name = "lblThermoformedMaxHitsPerMinute";
            this.lblThermoformedMaxHitsPerMinute.Size = new System.Drawing.Size(139, 15);
            this.lblThermoformedMaxHitsPerMinute.TabIndex = 46;
            this.lblThermoformedMaxHitsPerMinute.Text = "Máx. Golpes Por Minuto";
            // 
            // txtThermoformedMinHitsPerMinute
            // 
            this.txtThermoformedMinHitsPerMinute.Location = new System.Drawing.Point(144, 70);
            this.txtThermoformedMinHitsPerMinute.Name = "txtThermoformedMinHitsPerMinute";
            this.txtThermoformedMinHitsPerMinute.Size = new System.Drawing.Size(121, 21);
            this.txtThermoformedMinHitsPerMinute.TabIndex = 3;
            // 
            // lblThermoformedMinHitsPerMinute
            // 
            this.lblThermoformedMinHitsPerMinute.AutoSize = true;
            this.lblThermoformedMinHitsPerMinute.Location = new System.Drawing.Point(3, 74);
            this.lblThermoformedMinHitsPerMinute.Name = "lblThermoformedMinHitsPerMinute";
            this.lblThermoformedMinHitsPerMinute.Size = new System.Drawing.Size(136, 15);
            this.lblThermoformedMinHitsPerMinute.TabIndex = 44;
            this.lblThermoformedMinHitsPerMinute.Text = "Min. Golpes Por Minuto";
            // 
            // btnThermoformedCancel
            // 
            this.btnThermoformedCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermoformedCancel.BackgroundImage")));
            this.btnThermoformedCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermoformedCancel.Location = new System.Drawing.Point(622, 233);
            this.btnThermoformedCancel.Name = "btnThermoformedCancel";
            this.btnThermoformedCancel.Size = new System.Drawing.Size(25, 25);
            this.btnThermoformedCancel.TabIndex = 7;
            this.btnThermoformedCancel.UseVisualStyleBackColor = true;
            this.btnThermoformedCancel.Click += new System.EventHandler(this.btnThermoformedCancel_Click);
            // 
            // btnThermoformedSave
            // 
            this.btnThermoformedSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThermoformedSave.BackgroundImage")));
            this.btnThermoformedSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThermoformedSave.Location = new System.Drawing.Point(597, 233);
            this.btnThermoformedSave.Name = "btnThermoformedSave";
            this.btnThermoformedSave.Size = new System.Drawing.Size(25, 25);
            this.btnThermoformedSave.TabIndex = 6;
            this.btnThermoformedSave.UseVisualStyleBackColor = true;
            this.btnThermoformedSave.Click += new System.EventHandler(this.btnThermoformedSave_Click);
            // 
            // txtThermoformedFilmWidth
            // 
            this.txtThermoformedFilmWidth.Location = new System.Drawing.Point(472, 31);
            this.txtThermoformedFilmWidth.Name = "txtThermoformedFilmWidth";
            this.txtThermoformedFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtThermoformedFilmWidth.TabIndex = 2;
            // 
            // txtThermoformedName
            // 
            this.txtThermoformedName.Location = new System.Drawing.Point(144, 30);
            this.txtThermoformedName.Name = "txtThermoformedName";
            this.txtThermoformedName.Size = new System.Drawing.Size(141, 21);
            this.txtThermoformedName.TabIndex = 1;
            // 
            // lblThermoformedFilmWidth
            // 
            this.lblThermoformedFilmWidth.AutoSize = true;
            this.lblThermoformedFilmWidth.Location = new System.Drawing.Point(324, 33);
            this.lblThermoformedFilmWidth.Name = "lblThermoformedFilmWidth";
            this.lblThermoformedFilmWidth.Size = new System.Drawing.Size(88, 15);
            this.lblThermoformedFilmWidth.TabIndex = 1;
            this.lblThermoformedFilmWidth.Text = "Ancho Película";
            // 
            // lblThermoformedName
            // 
            this.lblThermoformedName.AutoSize = true;
            this.lblThermoformedName.Location = new System.Drawing.Point(3, 33);
            this.lblThermoformedName.Name = "lblThermoformedName";
            this.lblThermoformedName.Size = new System.Drawing.Size(52, 15);
            this.lblThermoformedName.TabIndex = 0;
            this.lblThermoformedName.Text = "Nombre";
            // 
            // pnlOunce
            // 
            this.pnlOunce.Controls.Add(this.grpbOunceForm);
            this.pnlOunce.Controls.Add(this.grpbOunceView);
            this.pnlOunce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOunce.Location = new System.Drawing.Point(0, 0);
            this.pnlOunce.Name = "pnlOunce";
            this.pnlOunce.Size = new System.Drawing.Size(666, 524);
            this.pnlOunce.TabIndex = 1;
            // 
            // grpbOunceForm
            // 
            this.grpbOunceForm.Controls.Add(this.btnOunceCancel);
            this.grpbOunceForm.Controls.Add(this.btnOunceSave);
            this.grpbOunceForm.Controls.Add(this.txtValue);
            this.grpbOunceForm.Controls.Add(this.lblValue);
            this.grpbOunceForm.Location = new System.Drawing.Point(3, 259);
            this.grpbOunceForm.Name = "grpbOunceForm";
            this.grpbOunceForm.Size = new System.Drawing.Size(660, 264);
            this.grpbOunceForm.TabIndex = 5;
            this.grpbOunceForm.TabStop = false;
            // 
            // btnOunceCancel
            // 
            this.btnOunceCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnOunceCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOunceCancel.Location = new System.Drawing.Point(628, 233);
            this.btnOunceCancel.Name = "btnOunceCancel";
            this.btnOunceCancel.Size = new System.Drawing.Size(25, 25);
            this.btnOunceCancel.TabIndex = 39;
            this.btnOunceCancel.UseVisualStyleBackColor = true;
            this.btnOunceCancel.Click += new System.EventHandler(this.btnOunceCancel_Click);
            // 
            // btnOunceSave
            // 
            this.btnOunceSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOunceSave.BackgroundImage")));
            this.btnOunceSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOunceSave.Location = new System.Drawing.Point(603, 233);
            this.btnOunceSave.Name = "btnOunceSave";
            this.btnOunceSave.Size = new System.Drawing.Size(25, 25);
            this.btnOunceSave.TabIndex = 38;
            this.btnOunceSave.UseVisualStyleBackColor = true;
            this.btnOunceSave.Click += new System.EventHandler(this.btnOunceSave_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(80, 41);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 21);
            this.txtValue.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(3, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(35, 15);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Valor";
            // 
            // grpbOunceView
            // 
            this.grpbOunceView.Controls.Add(this.btnOunceAdd);
            this.grpbOunceView.Controls.Add(this.dgvOunce);
            this.grpbOunceView.Controls.Add(this.btnOunceEdit);
            this.grpbOunceView.Controls.Add(this.btnOunceDelete);
            this.grpbOunceView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOunceView.Location = new System.Drawing.Point(0, 0);
            this.grpbOunceView.Name = "grpbOunceView";
            this.grpbOunceView.Size = new System.Drawing.Size(666, 253);
            this.grpbOunceView.TabIndex = 4;
            this.grpbOunceView.TabStop = false;
            // 
            // btnOunceAdd
            // 
            this.btnOunceAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOunceAdd.BackgroundImage")));
            this.btnOunceAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOunceAdd.Location = new System.Drawing.Point(578, 222);
            this.btnOunceAdd.Name = "btnOunceAdd";
            this.btnOunceAdd.Size = new System.Drawing.Size(25, 25);
            this.btnOunceAdd.TabIndex = 42;
            this.btnOunceAdd.UseVisualStyleBackColor = true;
            this.btnOunceAdd.Click += new System.EventHandler(this.btnOunceAdd_Click);
            // 
            // dgvOunce
            // 
            this.dgvOunce.AllowUserToAddRows = false;
            this.dgvOunce.AllowUserToDeleteRows = false;
            this.dgvOunce.AllowUserToOrderColumns = true;
            this.dgvOunce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOunce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOunceCodsec,
            this.clmOunceValue});
            this.dgvOunce.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOunce.Location = new System.Drawing.Point(3, 17);
            this.dgvOunce.Name = "dgvOunce";
            this.dgvOunce.ReadOnly = true;
            this.dgvOunce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOunce.Size = new System.Drawing.Size(660, 198);
            this.dgvOunce.TabIndex = 0;
            // 
            // clmOunceCodsec
            // 
            this.clmOunceCodsec.HeaderText = "Codsec";
            this.clmOunceCodsec.Name = "clmOunceCodsec";
            this.clmOunceCodsec.ReadOnly = true;
            this.clmOunceCodsec.Visible = false;
            // 
            // clmOunceValue
            // 
            this.clmOunceValue.HeaderText = "Valor";
            this.clmOunceValue.Name = "clmOunceValue";
            this.clmOunceValue.ReadOnly = true;
            this.clmOunceValue.Width = 250;
            // 
            // btnOunceEdit
            // 
            this.btnOunceEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOunceEdit.BackgroundImage")));
            this.btnOunceEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOunceEdit.Location = new System.Drawing.Point(604, 222);
            this.btnOunceEdit.Name = "btnOunceEdit";
            this.btnOunceEdit.Size = new System.Drawing.Size(25, 25);
            this.btnOunceEdit.TabIndex = 40;
            this.btnOunceEdit.UseVisualStyleBackColor = true;
            this.btnOunceEdit.Click += new System.EventHandler(this.btnOunceEdit_Click);
            // 
            // btnOunceDelete
            // 
            this.btnOunceDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOunceDelete.BackgroundImage")));
            this.btnOunceDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOunceDelete.Location = new System.Drawing.Point(630, 222);
            this.btnOunceDelete.Name = "btnOunceDelete";
            this.btnOunceDelete.Size = new System.Drawing.Size(25, 25);
            this.btnOunceDelete.TabIndex = 41;
            this.btnOunceDelete.UseVisualStyleBackColor = true;
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.grpbColorForm);
            this.pnlColor.Controls.Add(this.grpbColorView);
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(666, 524);
            this.pnlColor.TabIndex = 1;
            // 
            // grpbColorForm
            // 
            this.grpbColorForm.Controls.Add(this.btnColorCancel);
            this.grpbColorForm.Controls.Add(this.btnColorSave);
            this.grpbColorForm.Controls.Add(this.txtColorCode);
            this.grpbColorForm.Controls.Add(this.txtColorName);
            this.grpbColorForm.Controls.Add(this.lblColorCode);
            this.grpbColorForm.Controls.Add(this.lblColorName);
            this.grpbColorForm.Location = new System.Drawing.Point(3, 257);
            this.grpbColorForm.Name = "grpbColorForm";
            this.grpbColorForm.Size = new System.Drawing.Size(660, 264);
            this.grpbColorForm.TabIndex = 3;
            this.grpbColorForm.TabStop = false;
            // 
            // btnColorCancel
            // 
            this.btnColorCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnColorCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColorCancel.Location = new System.Drawing.Point(622, 233);
            this.btnColorCancel.Name = "btnColorCancel";
            this.btnColorCancel.Size = new System.Drawing.Size(25, 25);
            this.btnColorCancel.TabIndex = 39;
            this.btnColorCancel.UseVisualStyleBackColor = true;
            this.btnColorCancel.Click += new System.EventHandler(this.btnColorCancel_Click);
            // 
            // btnColorSave
            // 
            this.btnColorSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorSave.BackgroundImage")));
            this.btnColorSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColorSave.Location = new System.Drawing.Point(597, 233);
            this.btnColorSave.Name = "btnColorSave";
            this.btnColorSave.Size = new System.Drawing.Size(25, 25);
            this.btnColorSave.TabIndex = 38;
            this.btnColorSave.UseVisualStyleBackColor = true;
            this.btnColorSave.Click += new System.EventHandler(this.btnColorSave_Click);
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(80, 82);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(121, 21);
            this.txtColorCode.TabIndex = 3;
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(80, 41);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(121, 21);
            this.txtColorName.TabIndex = 2;
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Location = new System.Drawing.Point(3, 85);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(46, 15);
            this.lblColorCode.TabIndex = 1;
            this.lblColorCode.Text = "Código";
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Location = new System.Drawing.Point(3, 43);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(52, 15);
            this.lblColorName.TabIndex = 0;
            this.lblColorName.Text = "Nombre";
            // 
            // grpbColorView
            // 
            this.grpbColorView.Controls.Add(this.btnColorAdd);
            this.grpbColorView.Controls.Add(this.dgvColorDetail);
            this.grpbColorView.Controls.Add(this.btnColorEdit);
            this.grpbColorView.Controls.Add(this.btnColorDelete);
            this.grpbColorView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbColorView.Location = new System.Drawing.Point(0, 0);
            this.grpbColorView.Name = "grpbColorView";
            this.grpbColorView.Size = new System.Drawing.Size(666, 253);
            this.grpbColorView.TabIndex = 2;
            this.grpbColorView.TabStop = false;
            // 
            // btnColorAdd
            // 
            this.btnColorAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorAdd.BackgroundImage")));
            this.btnColorAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColorAdd.Location = new System.Drawing.Point(578, 222);
            this.btnColorAdd.Name = "btnColorAdd";
            this.btnColorAdd.Size = new System.Drawing.Size(25, 25);
            this.btnColorAdd.TabIndex = 42;
            this.btnColorAdd.UseVisualStyleBackColor = true;
            this.btnColorAdd.Click += new System.EventHandler(this.btnColorAdd_Click);
            // 
            // dgvColorDetail
            // 
            this.dgvColorDetail.AllowUserToAddRows = false;
            this.dgvColorDetail.AllowUserToDeleteRows = false;
            this.dgvColorDetail.AllowUserToOrderColumns = true;
            this.dgvColorDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColorDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmColorCodsec,
            this.clmColorName,
            this.clmColorCode});
            this.dgvColorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvColorDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvColorDetail.Name = "dgvColorDetail";
            this.dgvColorDetail.ReadOnly = true;
            this.dgvColorDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColorDetail.Size = new System.Drawing.Size(660, 198);
            this.dgvColorDetail.TabIndex = 0;
            // 
            // clmColorCodsec
            // 
            this.clmColorCodsec.HeaderText = "Codsec";
            this.clmColorCodsec.Name = "clmColorCodsec";
            this.clmColorCodsec.ReadOnly = true;
            this.clmColorCodsec.Visible = false;
            // 
            // clmColorName
            // 
            this.clmColorName.HeaderText = "Nombre";
            this.clmColorName.Name = "clmColorName";
            this.clmColorName.ReadOnly = true;
            this.clmColorName.Width = 250;
            // 
            // clmColorCode
            // 
            this.clmColorCode.HeaderText = "Código";
            this.clmColorCode.Name = "clmColorCode";
            this.clmColorCode.ReadOnly = true;
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorEdit.BackgroundImage")));
            this.btnColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColorEdit.Location = new System.Drawing.Point(604, 222);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(25, 25);
            this.btnColorEdit.TabIndex = 40;
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorDelete.BackgroundImage")));
            this.btnColorDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColorDelete.Location = new System.Drawing.Point(630, 222);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(25, 25);
            this.btnColorDelete.TabIndex = 41;
            this.btnColorDelete.UseVisualStyleBackColor = true;
            // 
            // pnlCore
            // 
            this.pnlCore.Controls.Add(this.grpbCoreForm);
            this.pnlCore.Controls.Add(this.grpbCoreList);
            this.pnlCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCore.Location = new System.Drawing.Point(0, 0);
            this.pnlCore.Name = "pnlCore";
            this.pnlCore.Size = new System.Drawing.Size(666, 524);
            this.pnlCore.TabIndex = 1;
            // 
            // grpbCoreForm
            // 
            this.grpbCoreForm.Controls.Add(this.btnCoreCancel);
            this.grpbCoreForm.Controls.Add(this.btnCoreSave);
            this.grpbCoreForm.Controls.Add(this.txtCoreValue);
            this.grpbCoreForm.Controls.Add(this.txtCoreName);
            this.grpbCoreForm.Controls.Add(this.lblCoreValue);
            this.grpbCoreForm.Controls.Add(this.lblCoreName);
            this.grpbCoreForm.Location = new System.Drawing.Point(3, 253);
            this.grpbCoreForm.Name = "grpbCoreForm";
            this.grpbCoreForm.Size = new System.Drawing.Size(660, 264);
            this.grpbCoreForm.TabIndex = 1;
            this.grpbCoreForm.TabStop = false;
            // 
            // btnCoreCancel
            // 
            this.btnCoreCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCoreCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoreCancel.Location = new System.Drawing.Point(622, 233);
            this.btnCoreCancel.Name = "btnCoreCancel";
            this.btnCoreCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCoreCancel.TabIndex = 39;
            this.btnCoreCancel.UseVisualStyleBackColor = true;
            this.btnCoreCancel.Click += new System.EventHandler(this.btnCoreCancel_Click);
            // 
            // btnCoreSave
            // 
            this.btnCoreSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoreSave.BackgroundImage")));
            this.btnCoreSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoreSave.Location = new System.Drawing.Point(597, 233);
            this.btnCoreSave.Name = "btnCoreSave";
            this.btnCoreSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoreSave.TabIndex = 38;
            this.btnCoreSave.UseVisualStyleBackColor = true;
            this.btnCoreSave.Click += new System.EventHandler(this.btnCoreSave_Click);
            // 
            // txtCoreValue
            // 
            this.txtCoreValue.Location = new System.Drawing.Point(80, 82);
            this.txtCoreValue.Name = "txtCoreValue";
            this.txtCoreValue.Size = new System.Drawing.Size(121, 21);
            this.txtCoreValue.TabIndex = 3;
            // 
            // txtCoreName
            // 
            this.txtCoreName.Location = new System.Drawing.Point(80, 41);
            this.txtCoreName.Name = "txtCoreName";
            this.txtCoreName.Size = new System.Drawing.Size(121, 21);
            this.txtCoreName.TabIndex = 2;
            // 
            // lblCoreValue
            // 
            this.lblCoreValue.AutoSize = true;
            this.lblCoreValue.Location = new System.Drawing.Point(3, 85);
            this.lblCoreValue.Name = "lblCoreValue";
            this.lblCoreValue.Size = new System.Drawing.Size(35, 15);
            this.lblCoreValue.TabIndex = 1;
            this.lblCoreValue.Text = "Valor";
            // 
            // lblCoreName
            // 
            this.lblCoreName.AutoSize = true;
            this.lblCoreName.Location = new System.Drawing.Point(3, 43);
            this.lblCoreName.Name = "lblCoreName";
            this.lblCoreName.Size = new System.Drawing.Size(52, 15);
            this.lblCoreName.TabIndex = 0;
            this.lblCoreName.Text = "Nombre";
            // 
            // grpbCoreList
            // 
            this.grpbCoreList.Controls.Add(this.btnCoreAdd);
            this.grpbCoreList.Controls.Add(this.dgvCore);
            this.grpbCoreList.Controls.Add(this.btnCoreEdit);
            this.grpbCoreList.Controls.Add(this.btnCoreDelete);
            this.grpbCoreList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoreList.Location = new System.Drawing.Point(0, 0);
            this.grpbCoreList.Name = "grpbCoreList";
            this.grpbCoreList.Size = new System.Drawing.Size(666, 253);
            this.grpbCoreList.TabIndex = 0;
            this.grpbCoreList.TabStop = false;
            // 
            // btnCoreAdd
            // 
            this.btnCoreAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoreAdd.BackgroundImage")));
            this.btnCoreAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoreAdd.Location = new System.Drawing.Point(578, 222);
            this.btnCoreAdd.Name = "btnCoreAdd";
            this.btnCoreAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCoreAdd.TabIndex = 42;
            this.btnCoreAdd.UseVisualStyleBackColor = true;
            this.btnCoreAdd.Click += new System.EventHandler(this.btnCoreAdd_Click);
            // 
            // dgvCore
            // 
            this.dgvCore.AllowUserToAddRows = false;
            this.dgvCore.AllowUserToDeleteRows = false;
            this.dgvCore.AllowUserToOrderColumns = true;
            this.dgvCore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoreCodsec,
            this.clmCoreName,
            this.clmCoreValue});
            this.dgvCore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCore.Location = new System.Drawing.Point(3, 17);
            this.dgvCore.Name = "dgvCore";
            this.dgvCore.ReadOnly = true;
            this.dgvCore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCore.Size = new System.Drawing.Size(660, 198);
            this.dgvCore.TabIndex = 0;
            // 
            // clmCoreCodsec
            // 
            this.clmCoreCodsec.HeaderText = "Codsec";
            this.clmCoreCodsec.Name = "clmCoreCodsec";
            this.clmCoreCodsec.ReadOnly = true;
            this.clmCoreCodsec.Visible = false;
            // 
            // clmCoreName
            // 
            this.clmCoreName.HeaderText = "Nombre";
            this.clmCoreName.Name = "clmCoreName";
            this.clmCoreName.ReadOnly = true;
            this.clmCoreName.Width = 250;
            // 
            // clmCoreValue
            // 
            this.clmCoreValue.HeaderText = "Valor";
            this.clmCoreValue.Name = "clmCoreValue";
            this.clmCoreValue.ReadOnly = true;
            // 
            // btnCoreEdit
            // 
            this.btnCoreEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoreEdit.BackgroundImage")));
            this.btnCoreEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoreEdit.Location = new System.Drawing.Point(604, 222);
            this.btnCoreEdit.Name = "btnCoreEdit";
            this.btnCoreEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCoreEdit.TabIndex = 40;
            this.btnCoreEdit.UseVisualStyleBackColor = true;
            this.btnCoreEdit.Click += new System.EventHandler(this.btnCoreEdit_Click);
            // 
            // btnCoreDelete
            // 
            this.btnCoreDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoreDelete.BackgroundImage")));
            this.btnCoreDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoreDelete.Location = new System.Drawing.Point(630, 222);
            this.btnCoreDelete.Name = "btnCoreDelete";
            this.btnCoreDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCoreDelete.TabIndex = 41;
            this.btnCoreDelete.UseVisualStyleBackColor = true;
            // 
            // pnlBopp
            // 
            this.pnlBopp.Controls.Add(this.tctrlBoppFilm);
            this.pnlBopp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBopp.Location = new System.Drawing.Point(0, 0);
            this.pnlBopp.Name = "pnlBopp";
            this.pnlBopp.Size = new System.Drawing.Size(666, 524);
            this.pnlBopp.TabIndex = 1;
            // 
            // tctrlBoppFilm
            // 
            this.tctrlBoppFilm.Controls.Add(this.tbpFamily);
            this.tctrlBoppFilm.Controls.Add(this.tbpSeal);
            this.tctrlBoppFilm.Controls.Add(this.tbpBoppAdditivation);
            this.tctrlBoppFilm.Controls.Add(this.tbpBoppThickness);
            this.tctrlBoppFilm.Controls.Add(this.tbpBoppTreatment);
            this.tctrlBoppFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlBoppFilm.Location = new System.Drawing.Point(0, 0);
            this.tctrlBoppFilm.Name = "tctrlBoppFilm";
            this.tctrlBoppFilm.SelectedIndex = 0;
            this.tctrlBoppFilm.Size = new System.Drawing.Size(666, 524);
            this.tctrlBoppFilm.TabIndex = 0;
            // 
            // tbpFamily
            // 
            this.tbpFamily.BackColor = System.Drawing.SystemColors.Control;
            this.tbpFamily.Controls.Add(this.grpbFamilyList);
            this.tbpFamily.Controls.Add(this.grpbFamilyForm);
            this.tbpFamily.Location = new System.Drawing.Point(4, 24);
            this.tbpFamily.Name = "tbpFamily";
            this.tbpFamily.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFamily.Size = new System.Drawing.Size(658, 496);
            this.tbpFamily.TabIndex = 0;
            this.tbpFamily.Text = "Familias";
            // 
            // grpbFamilyList
            // 
            this.grpbFamilyList.Controls.Add(this.btnBoppFamilyAdd);
            this.grpbFamilyList.Controls.Add(this.btnBoppFamilyEdit);
            this.grpbFamilyList.Controls.Add(this.btnBoppFamilyDelete);
            this.grpbFamilyList.Controls.Add(this.dgvFamily);
            this.grpbFamilyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFamilyList.Location = new System.Drawing.Point(3, 3);
            this.grpbFamilyList.Name = "grpbFamilyList";
            this.grpbFamilyList.Size = new System.Drawing.Size(652, 253);
            this.grpbFamilyList.TabIndex = 0;
            this.grpbFamilyList.TabStop = false;
            // 
            // btnBoppFamilyAdd
            // 
            this.btnBoppFamilyAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBoppFamilyAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppFamilyAdd.Location = new System.Drawing.Point(566, 221);
            this.btnBoppFamilyAdd.Name = "btnBoppFamilyAdd";
            this.btnBoppFamilyAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBoppFamilyAdd.TabIndex = 27;
            this.btnBoppFamilyAdd.UseVisualStyleBackColor = true;
            this.btnBoppFamilyAdd.Click += new System.EventHandler(this.btnBoppFamilyAdd_Click);
            // 
            // btnBoppFamilyEdit
            // 
            this.btnBoppFamilyEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBoppFamilyEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppFamilyEdit.Location = new System.Drawing.Point(592, 221);
            this.btnBoppFamilyEdit.Name = "btnBoppFamilyEdit";
            this.btnBoppFamilyEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBoppFamilyEdit.TabIndex = 25;
            this.btnBoppFamilyEdit.UseVisualStyleBackColor = true;
            this.btnBoppFamilyEdit.Click += new System.EventHandler(this.btnBoppFamilyEdit_Click);
            // 
            // btnBoppFamilyDelete
            // 
            this.btnBoppFamilyDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBoppFamilyDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppFamilyDelete.Location = new System.Drawing.Point(618, 221);
            this.btnBoppFamilyDelete.Name = "btnBoppFamilyDelete";
            this.btnBoppFamilyDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBoppFamilyDelete.TabIndex = 26;
            this.btnBoppFamilyDelete.UseVisualStyleBackColor = true;
            // 
            // dgvFamily
            // 
            this.dgvFamily.AllowUserToAddRows = false;
            this.dgvFamily.AllowUserToDeleteRows = false;
            this.dgvFamily.AllowUserToOrderColumns = true;
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFamilyCodsec,
            this.clmFamilyAbbreviation,
            this.clmFamilyName});
            this.dgvFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFamily.Location = new System.Drawing.Point(3, 17);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.ReadOnly = true;
            this.dgvFamily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamily.Size = new System.Drawing.Size(646, 198);
            this.dgvFamily.TabIndex = 0;
            // 
            // clmFamilyCodsec
            // 
            this.clmFamilyCodsec.HeaderText = "codsec";
            this.clmFamilyCodsec.Name = "clmFamilyCodsec";
            this.clmFamilyCodsec.ReadOnly = true;
            this.clmFamilyCodsec.Visible = false;
            // 
            // clmFamilyAbbreviation
            // 
            this.clmFamilyAbbreviation.HeaderText = "Abrev.";
            this.clmFamilyAbbreviation.Name = "clmFamilyAbbreviation";
            this.clmFamilyAbbreviation.ReadOnly = true;
            this.clmFamilyAbbreviation.Width = 60;
            // 
            // clmFamilyName
            // 
            this.clmFamilyName.HeaderText = "Nombre";
            this.clmFamilyName.Name = "clmFamilyName";
            this.clmFamilyName.ReadOnly = true;
            this.clmFamilyName.Width = 400;
            // 
            // grpbFamilyForm
            // 
            this.grpbFamilyForm.Controls.Add(this.btnBoppFamilySave);
            this.grpbFamilyForm.Controls.Add(this.btnBoppFamilyCancel);
            this.grpbFamilyForm.Controls.Add(this.txtBoppFamilyAbbreviation);
            this.grpbFamilyForm.Controls.Add(this.txtBoppFamilyName);
            this.grpbFamilyForm.Controls.Add(this.lblBoppFamilyAvbreviation);
            this.grpbFamilyForm.Controls.Add(this.lblBoppFamilyName);
            this.grpbFamilyForm.Enabled = false;
            this.grpbFamilyForm.Location = new System.Drawing.Point(3, 253);
            this.grpbFamilyForm.Name = "grpbFamilyForm";
            this.grpbFamilyForm.Size = new System.Drawing.Size(650, 240);
            this.grpbFamilyForm.TabIndex = 1;
            this.grpbFamilyForm.TabStop = false;
            // 
            // btnBoppFamilySave
            // 
            this.btnBoppFamilySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoppFamilySave.BackgroundImage")));
            this.btnBoppFamilySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppFamilySave.Location = new System.Drawing.Point(593, 208);
            this.btnBoppFamilySave.Name = "btnBoppFamilySave";
            this.btnBoppFamilySave.Size = new System.Drawing.Size(25, 25);
            this.btnBoppFamilySave.TabIndex = 3;
            this.btnBoppFamilySave.UseVisualStyleBackColor = true;
            this.btnBoppFamilySave.Click += new System.EventHandler(this.btnFamilySave_Click);
            // 
            // btnBoppFamilyCancel
            // 
            this.btnBoppFamilyCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBoppFamilyCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppFamilyCancel.Location = new System.Drawing.Point(618, 208);
            this.btnBoppFamilyCancel.Name = "btnBoppFamilyCancel";
            this.btnBoppFamilyCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBoppFamilyCancel.TabIndex = 4;
            this.btnBoppFamilyCancel.UseVisualStyleBackColor = true;
            this.btnBoppFamilyCancel.Click += new System.EventHandler(this.btnBoppFamilyCancel_Click);
            // 
            // txtBoppFamilyAbbreviation
            // 
            this.txtBoppFamilyAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtBoppFamilyAbbreviation.Name = "txtBoppFamilyAbbreviation";
            this.txtBoppFamilyAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtBoppFamilyAbbreviation.TabIndex = 2;
            // 
            // txtBoppFamilyName
            // 
            this.txtBoppFamilyName.Location = new System.Drawing.Point(79, 24);
            this.txtBoppFamilyName.Name = "txtBoppFamilyName";
            this.txtBoppFamilyName.Size = new System.Drawing.Size(462, 21);
            this.txtBoppFamilyName.TabIndex = 1;
            // 
            // lblBoppFamilyAvbreviation
            // 
            this.lblBoppFamilyAvbreviation.AutoSize = true;
            this.lblBoppFamilyAvbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblBoppFamilyAvbreviation.Name = "lblBoppFamilyAvbreviation";
            this.lblBoppFamilyAvbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblBoppFamilyAvbreviation.TabIndex = 1;
            this.lblBoppFamilyAvbreviation.Text = "Abreviación";
            // 
            // lblBoppFamilyName
            // 
            this.lblBoppFamilyName.AutoSize = true;
            this.lblBoppFamilyName.Location = new System.Drawing.Point(3, 27);
            this.lblBoppFamilyName.Name = "lblBoppFamilyName";
            this.lblBoppFamilyName.Size = new System.Drawing.Size(52, 15);
            this.lblBoppFamilyName.TabIndex = 0;
            this.lblBoppFamilyName.Text = "Nombre";
            // 
            // tbpSeal
            // 
            this.tbpSeal.Controls.Add(this.grpbSealList);
            this.tbpSeal.Controls.Add(this.grpbSealForm);
            this.tbpSeal.Location = new System.Drawing.Point(4, 22);
            this.tbpSeal.Name = "tbpSeal";
            this.tbpSeal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSeal.Size = new System.Drawing.Size(658, 498);
            this.tbpSeal.TabIndex = 1;
            this.tbpSeal.Text = "Sellos";
            this.tbpSeal.UseVisualStyleBackColor = true;
            // 
            // grpbSealList
            // 
            this.grpbSealList.BackColor = System.Drawing.SystemColors.Control;
            this.grpbSealList.Controls.Add(this.groupBox1);
            this.grpbSealList.Controls.Add(this.btnBoppSealAdd);
            this.grpbSealList.Controls.Add(this.btnBoppSealEdit);
            this.grpbSealList.Controls.Add(this.btnBoppSealDelete);
            this.grpbSealList.Controls.Add(this.dgvSeal);
            this.grpbSealList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSealList.Location = new System.Drawing.Point(3, 3);
            this.grpbSealList.Name = "grpbSealList";
            this.grpbSealList.Size = new System.Drawing.Size(652, 253);
            this.grpbSealList.TabIndex = 0;
            this.grpbSealList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnBoppSealAdd
            // 
            this.btnBoppSealAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBoppSealAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppSealAdd.Location = new System.Drawing.Point(569, 221);
            this.btnBoppSealAdd.Name = "btnBoppSealAdd";
            this.btnBoppSealAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBoppSealAdd.TabIndex = 30;
            this.btnBoppSealAdd.UseVisualStyleBackColor = true;
            this.btnBoppSealAdd.Click += new System.EventHandler(this.btnBoppSealAdd_Click);
            // 
            // btnBoppSealEdit
            // 
            this.btnBoppSealEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBoppSealEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppSealEdit.Location = new System.Drawing.Point(595, 221);
            this.btnBoppSealEdit.Name = "btnBoppSealEdit";
            this.btnBoppSealEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBoppSealEdit.TabIndex = 28;
            this.btnBoppSealEdit.UseVisualStyleBackColor = true;
            this.btnBoppSealEdit.Click += new System.EventHandler(this.btnBoppSealEdit_Click);
            // 
            // btnBoppSealDelete
            // 
            this.btnBoppSealDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBoppSealDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppSealDelete.Location = new System.Drawing.Point(621, 221);
            this.btnBoppSealDelete.Name = "btnBoppSealDelete";
            this.btnBoppSealDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBoppSealDelete.TabIndex = 29;
            this.btnBoppSealDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSeal
            // 
            this.dgvSeal.AllowUserToAddRows = false;
            this.dgvSeal.AllowUserToDeleteRows = false;
            this.dgvSeal.AllowUserToOrderColumns = true;
            this.dgvSeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSealCodsec,
            this.clmSealAbbreviation,
            this.clmSealName});
            this.dgvSeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSeal.Location = new System.Drawing.Point(3, 17);
            this.dgvSeal.Name = "dgvSeal";
            this.dgvSeal.ReadOnly = true;
            this.dgvSeal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeal.Size = new System.Drawing.Size(646, 198);
            this.dgvSeal.TabIndex = 0;
            // 
            // clmSealCodsec
            // 
            this.clmSealCodsec.HeaderText = "Codsec";
            this.clmSealCodsec.Name = "clmSealCodsec";
            this.clmSealCodsec.ReadOnly = true;
            this.clmSealCodsec.Visible = false;
            // 
            // clmSealAbbreviation
            // 
            this.clmSealAbbreviation.HeaderText = "Abrev.";
            this.clmSealAbbreviation.Name = "clmSealAbbreviation";
            this.clmSealAbbreviation.ReadOnly = true;
            this.clmSealAbbreviation.Width = 60;
            // 
            // clmSealName
            // 
            this.clmSealName.HeaderText = "Nombre";
            this.clmSealName.Name = "clmSealName";
            this.clmSealName.ReadOnly = true;
            this.clmSealName.Width = 400;
            // 
            // grpbSealForm
            // 
            this.grpbSealForm.BackColor = System.Drawing.SystemColors.Control;
            this.grpbSealForm.Controls.Add(this.txtSealName);
            this.grpbSealForm.Controls.Add(this.txtSealAbbreviation);
            this.grpbSealForm.Controls.Add(this.lblSealAbbreviation);
            this.grpbSealForm.Controls.Add(this.lblSealName);
            this.grpbSealForm.Controls.Add(this.btnBoppSealSave);
            this.grpbSealForm.Controls.Add(this.btnBoppSealCancel);
            this.grpbSealForm.Location = new System.Drawing.Point(3, 253);
            this.grpbSealForm.Name = "grpbSealForm";
            this.grpbSealForm.Size = new System.Drawing.Size(650, 240);
            this.grpbSealForm.TabIndex = 1;
            this.grpbSealForm.TabStop = false;
            // 
            // txtSealName
            // 
            this.txtSealName.Location = new System.Drawing.Point(79, 26);
            this.txtSealName.Name = "txtSealName";
            this.txtSealName.Size = new System.Drawing.Size(462, 21);
            this.txtSealName.TabIndex = 1;
            // 
            // txtSealAbbreviation
            // 
            this.txtSealAbbreviation.Location = new System.Drawing.Point(79, 65);
            this.txtSealAbbreviation.Name = "txtSealAbbreviation";
            this.txtSealAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtSealAbbreviation.TabIndex = 2;
            // 
            // lblSealAbbreviation
            // 
            this.lblSealAbbreviation.AutoSize = true;
            this.lblSealAbbreviation.Location = new System.Drawing.Point(3, 68);
            this.lblSealAbbreviation.Name = "lblSealAbbreviation";
            this.lblSealAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblSealAbbreviation.TabIndex = 32;
            this.lblSealAbbreviation.Text = "Abreviación";
            // 
            // lblSealName
            // 
            this.lblSealName.AutoSize = true;
            this.lblSealName.Location = new System.Drawing.Point(3, 29);
            this.lblSealName.Name = "lblSealName";
            this.lblSealName.Size = new System.Drawing.Size(52, 15);
            this.lblSealName.TabIndex = 31;
            this.lblSealName.Text = "Nombre";
            // 
            // btnBoppSealSave
            // 
            this.btnBoppSealSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoppSealSave.BackgroundImage")));
            this.btnBoppSealSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppSealSave.Location = new System.Drawing.Point(596, 209);
            this.btnBoppSealSave.Name = "btnBoppSealSave";
            this.btnBoppSealSave.Size = new System.Drawing.Size(25, 25);
            this.btnBoppSealSave.TabIndex = 3;
            this.btnBoppSealSave.UseVisualStyleBackColor = true;
            this.btnBoppSealSave.Click += new System.EventHandler(this.btnBoppSealSave_Click);
            // 
            // btnBoppSealCancel
            // 
            this.btnBoppSealCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBoppSealCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppSealCancel.Location = new System.Drawing.Point(621, 209);
            this.btnBoppSealCancel.Name = "btnBoppSealCancel";
            this.btnBoppSealCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBoppSealCancel.TabIndex = 4;
            this.btnBoppSealCancel.UseVisualStyleBackColor = true;
            this.btnBoppSealCancel.Click += new System.EventHandler(this.btnBoppSealCancel_Click);
            // 
            // tbpBoppAdditivation
            // 
            this.tbpBoppAdditivation.Controls.Add(this.grpbAdditivationList);
            this.tbpBoppAdditivation.Controls.Add(this.grpbAdditivationForm);
            this.tbpBoppAdditivation.Location = new System.Drawing.Point(4, 22);
            this.tbpBoppAdditivation.Name = "tbpBoppAdditivation";
            this.tbpBoppAdditivation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBoppAdditivation.Size = new System.Drawing.Size(658, 498);
            this.tbpBoppAdditivation.TabIndex = 2;
            this.tbpBoppAdditivation.Text = "Aditivaciones";
            this.tbpBoppAdditivation.UseVisualStyleBackColor = true;
            // 
            // grpbAdditivationList
            // 
            this.grpbAdditivationList.BackColor = System.Drawing.SystemColors.Control;
            this.grpbAdditivationList.Controls.Add(this.btnBoppAdditivationDelete);
            this.grpbAdditivationList.Controls.Add(this.btnBoppAdditivationEdit);
            this.grpbAdditivationList.Controls.Add(this.btnBoppAdditivationAdd);
            this.grpbAdditivationList.Controls.Add(this.dgvAdditivation);
            this.grpbAdditivationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbAdditivationList.Location = new System.Drawing.Point(3, 3);
            this.grpbAdditivationList.Name = "grpbAdditivationList";
            this.grpbAdditivationList.Size = new System.Drawing.Size(652, 253);
            this.grpbAdditivationList.TabIndex = 0;
            this.grpbAdditivationList.TabStop = false;
            // 
            // btnBoppAdditivationDelete
            // 
            this.btnBoppAdditivationDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBoppAdditivationDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppAdditivationDelete.Location = new System.Drawing.Point(623, 221);
            this.btnBoppAdditivationDelete.Name = "btnBoppAdditivationDelete";
            this.btnBoppAdditivationDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBoppAdditivationDelete.TabIndex = 33;
            this.btnBoppAdditivationDelete.UseVisualStyleBackColor = true;
            // 
            // btnBoppAdditivationEdit
            // 
            this.btnBoppAdditivationEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBoppAdditivationEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppAdditivationEdit.Location = new System.Drawing.Point(597, 221);
            this.btnBoppAdditivationEdit.Name = "btnBoppAdditivationEdit";
            this.btnBoppAdditivationEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBoppAdditivationEdit.TabIndex = 32;
            this.btnBoppAdditivationEdit.UseVisualStyleBackColor = true;
            this.btnBoppAdditivationEdit.Click += new System.EventHandler(this.btnBoppAdditivationEdit_Click);
            // 
            // btnBoppAdditivationAdd
            // 
            this.btnBoppAdditivationAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBoppAdditivationAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppAdditivationAdd.Location = new System.Drawing.Point(571, 221);
            this.btnBoppAdditivationAdd.Name = "btnBoppAdditivationAdd";
            this.btnBoppAdditivationAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBoppAdditivationAdd.TabIndex = 31;
            this.btnBoppAdditivationAdd.UseVisualStyleBackColor = true;
            this.btnBoppAdditivationAdd.Click += new System.EventHandler(this.btnBoppAdditivationAdd_Click);
            // 
            // dgvAdditivation
            // 
            this.dgvAdditivation.AllowUserToAddRows = false;
            this.dgvAdditivation.AllowUserToDeleteRows = false;
            this.dgvAdditivation.AllowUserToOrderColumns = true;
            this.dgvAdditivation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditivation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAdditivationCodsec,
            this.clmAdditivationAbbreviation,
            this.clmAdditivationName,
            this.clmAdditivationForBopp,
            this.clmAdditivationForCast});
            this.dgvAdditivation.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAdditivation.Location = new System.Drawing.Point(3, 17);
            this.dgvAdditivation.Name = "dgvAdditivation";
            this.dgvAdditivation.ReadOnly = true;
            this.dgvAdditivation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdditivation.Size = new System.Drawing.Size(646, 198);
            this.dgvAdditivation.TabIndex = 0;
            // 
            // clmAdditivationCodsec
            // 
            this.clmAdditivationCodsec.HeaderText = "AdditivationCodsec";
            this.clmAdditivationCodsec.Name = "clmAdditivationCodsec";
            this.clmAdditivationCodsec.ReadOnly = true;
            this.clmAdditivationCodsec.Visible = false;
            // 
            // clmAdditivationAbbreviation
            // 
            this.clmAdditivationAbbreviation.HeaderText = "Abrev.";
            this.clmAdditivationAbbreviation.Name = "clmAdditivationAbbreviation";
            this.clmAdditivationAbbreviation.ReadOnly = true;
            this.clmAdditivationAbbreviation.Width = 60;
            // 
            // clmAdditivationName
            // 
            this.clmAdditivationName.HeaderText = "Nombre";
            this.clmAdditivationName.Name = "clmAdditivationName";
            this.clmAdditivationName.ReadOnly = true;
            this.clmAdditivationName.Width = 300;
            // 
            // clmAdditivationForBopp
            // 
            this.clmAdditivationForBopp.HeaderText = "Bopp";
            this.clmAdditivationForBopp.Name = "clmAdditivationForBopp";
            this.clmAdditivationForBopp.ReadOnly = true;
            this.clmAdditivationForBopp.Width = 60;
            // 
            // clmAdditivationForCast
            // 
            this.clmAdditivationForCast.HeaderText = "Cast";
            this.clmAdditivationForCast.Name = "clmAdditivationForCast";
            this.clmAdditivationForCast.ReadOnly = true;
            this.clmAdditivationForCast.Width = 60;
            // 
            // grpbAdditivationForm
            // 
            this.grpbAdditivationForm.BackColor = System.Drawing.SystemColors.Control;
            this.grpbAdditivationForm.Controls.Add(this.chbxCastAdditivation);
            this.grpbAdditivationForm.Controls.Add(this.chbxBoppAdditivation);
            this.grpbAdditivationForm.Controls.Add(this.btnBoppAdditivationCancel);
            this.grpbAdditivationForm.Controls.Add(this.btnBoppAdditivationSave);
            this.grpbAdditivationForm.Controls.Add(this.txtAdditivationName);
            this.grpbAdditivationForm.Controls.Add(this.txtAdditivationAbbreviation);
            this.grpbAdditivationForm.Controls.Add(this.lblAdditivationAbbreviation);
            this.grpbAdditivationForm.Controls.Add(this.lblAdditivationName);
            this.grpbAdditivationForm.Location = new System.Drawing.Point(3, 253);
            this.grpbAdditivationForm.Name = "grpbAdditivationForm";
            this.grpbAdditivationForm.Size = new System.Drawing.Size(655, 241);
            this.grpbAdditivationForm.TabIndex = 1;
            this.grpbAdditivationForm.TabStop = false;
            // 
            // chbxCastAdditivation
            // 
            this.chbxCastAdditivation.AutoSize = true;
            this.chbxCastAdditivation.Location = new System.Drawing.Point(111, 101);
            this.chbxCastAdditivation.Name = "chbxCastAdditivation";
            this.chbxCastAdditivation.Size = new System.Drawing.Size(47, 17);
            this.chbxCastAdditivation.TabIndex = 4;
            this.chbxCastAdditivation.Text = "Cast";
            this.chbxCastAdditivation.UseVisualStyleBackColor = true;
            // 
            // chbxBoppAdditivation
            // 
            this.chbxBoppAdditivation.AutoSize = true;
            this.chbxBoppAdditivation.Location = new System.Drawing.Point(8, 101);
            this.chbxBoppAdditivation.Name = "chbxBoppAdditivation";
            this.chbxBoppAdditivation.Size = new System.Drawing.Size(51, 17);
            this.chbxBoppAdditivation.TabIndex = 3;
            this.chbxBoppAdditivation.Text = "Bopp";
            this.chbxBoppAdditivation.UseVisualStyleBackColor = true;
            // 
            // btnBoppAdditivationCancel
            // 
            this.btnBoppAdditivationCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBoppAdditivationCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppAdditivationCancel.Location = new System.Drawing.Point(623, 211);
            this.btnBoppAdditivationCancel.Name = "btnBoppAdditivationCancel";
            this.btnBoppAdditivationCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBoppAdditivationCancel.TabIndex = 6;
            this.btnBoppAdditivationCancel.UseVisualStyleBackColor = true;
            this.btnBoppAdditivationCancel.Click += new System.EventHandler(this.btnBoppAdditivationCancel_Click);
            // 
            // btnBoppAdditivationSave
            // 
            this.btnBoppAdditivationSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoppAdditivationSave.BackgroundImage")));
            this.btnBoppAdditivationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppAdditivationSave.Location = new System.Drawing.Point(598, 211);
            this.btnBoppAdditivationSave.Name = "btnBoppAdditivationSave";
            this.btnBoppAdditivationSave.Size = new System.Drawing.Size(25, 25);
            this.btnBoppAdditivationSave.TabIndex = 5;
            this.btnBoppAdditivationSave.UseVisualStyleBackColor = true;
            this.btnBoppAdditivationSave.Click += new System.EventHandler(this.btnBoppAdditivationSave_Click);
            // 
            // txtAdditivationName
            // 
            this.txtAdditivationName.Location = new System.Drawing.Point(79, 24);
            this.txtAdditivationName.Name = "txtAdditivationName";
            this.txtAdditivationName.Size = new System.Drawing.Size(462, 21);
            this.txtAdditivationName.TabIndex = 1;
            // 
            // txtAdditivationAbbreviation
            // 
            this.txtAdditivationAbbreviation.Location = new System.Drawing.Point(79, 63);
            this.txtAdditivationAbbreviation.Name = "txtAdditivationAbbreviation";
            this.txtAdditivationAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtAdditivationAbbreviation.TabIndex = 2;
            // 
            // lblAdditivationAbbreviation
            // 
            this.lblAdditivationAbbreviation.AutoSize = true;
            this.lblAdditivationAbbreviation.Location = new System.Drawing.Point(3, 66);
            this.lblAdditivationAbbreviation.Name = "lblAdditivationAbbreviation";
            this.lblAdditivationAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblAdditivationAbbreviation.TabIndex = 1;
            this.lblAdditivationAbbreviation.Text = "Abreviación";
            // 
            // lblAdditivationName
            // 
            this.lblAdditivationName.AutoSize = true;
            this.lblAdditivationName.Location = new System.Drawing.Point(3, 27);
            this.lblAdditivationName.Name = "lblAdditivationName";
            this.lblAdditivationName.Size = new System.Drawing.Size(52, 15);
            this.lblAdditivationName.TabIndex = 0;
            this.lblAdditivationName.Text = "Nombre";
            // 
            // tbpBoppThickness
            // 
            this.tbpBoppThickness.Controls.Add(this.grpbThicknessForm);
            this.tbpBoppThickness.Controls.Add(this.grpbThicknessList);
            this.tbpBoppThickness.Location = new System.Drawing.Point(4, 22);
            this.tbpBoppThickness.Name = "tbpBoppThickness";
            this.tbpBoppThickness.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBoppThickness.Size = new System.Drawing.Size(658, 498);
            this.tbpBoppThickness.TabIndex = 3;
            this.tbpBoppThickness.Text = "Espesores";
            this.tbpBoppThickness.UseVisualStyleBackColor = true;
            // 
            // grpbThicknessForm
            // 
            this.grpbThicknessForm.BackColor = System.Drawing.SystemColors.Control;
            this.grpbThicknessForm.Controls.Add(this.btnBoppThicknessCancel);
            this.grpbThicknessForm.Controls.Add(this.btnBoppThicknessSave);
            this.grpbThicknessForm.Controls.Add(this.txtThicknessValue);
            this.grpbThicknessForm.Controls.Add(this.lblThicknessValue);
            this.grpbThicknessForm.Controls.Add(this.grpbox2);
            this.grpbThicknessForm.Location = new System.Drawing.Point(3, 253);
            this.grpbThicknessForm.Name = "grpbThicknessForm";
            this.grpbThicknessForm.Size = new System.Drawing.Size(652, 244);
            this.grpbThicknessForm.TabIndex = 1;
            this.grpbThicknessForm.TabStop = false;
            // 
            // btnBoppThicknessCancel
            // 
            this.btnBoppThicknessCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBoppThicknessCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppThicknessCancel.Location = new System.Drawing.Point(622, 210);
            this.btnBoppThicknessCancel.Name = "btnBoppThicknessCancel";
            this.btnBoppThicknessCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBoppThicknessCancel.TabIndex = 3;
            this.btnBoppThicknessCancel.UseVisualStyleBackColor = true;
            this.btnBoppThicknessCancel.Click += new System.EventHandler(this.btnBoppThicknessCancel_Click);
            // 
            // btnBoppThicknessSave
            // 
            this.btnBoppThicknessSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoppThicknessSave.BackgroundImage")));
            this.btnBoppThicknessSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppThicknessSave.Location = new System.Drawing.Point(597, 210);
            this.btnBoppThicknessSave.Name = "btnBoppThicknessSave";
            this.btnBoppThicknessSave.Size = new System.Drawing.Size(25, 25);
            this.btnBoppThicknessSave.TabIndex = 2;
            this.btnBoppThicknessSave.UseVisualStyleBackColor = true;
            this.btnBoppThicknessSave.Click += new System.EventHandler(this.btnBoppThicknessSave_Click);
            // 
            // txtThicknessValue
            // 
            this.txtThicknessValue.Location = new System.Drawing.Point(79, 34);
            this.txtThicknessValue.Name = "txtThicknessValue";
            this.txtThicknessValue.Size = new System.Drawing.Size(100, 21);
            this.txtThicknessValue.TabIndex = 1;
            // 
            // lblThicknessValue
            // 
            this.lblThicknessValue.AutoSize = true;
            this.lblThicknessValue.Location = new System.Drawing.Point(3, 34);
            this.lblThicknessValue.Name = "lblThicknessValue";
            this.lblThicknessValue.Size = new System.Drawing.Size(35, 15);
            this.lblThicknessValue.TabIndex = 1;
            this.lblThicknessValue.Text = "Valor";
            // 
            // grpbox2
            // 
            this.grpbox2.Location = new System.Drawing.Point(3, 253);
            this.grpbox2.Name = "grpbox2";
            this.grpbox2.Size = new System.Drawing.Size(555, 106);
            this.grpbox2.TabIndex = 0;
            this.grpbox2.TabStop = false;
            // 
            // grpbThicknessList
            // 
            this.grpbThicknessList.BackColor = System.Drawing.SystemColors.Control;
            this.grpbThicknessList.Controls.Add(this.btnBoppThicknessDelete);
            this.grpbThicknessList.Controls.Add(this.btnBoppThicknessEdit);
            this.grpbThicknessList.Controls.Add(this.btnBoppThicknessAdd);
            this.grpbThicknessList.Controls.Add(this.dgvThickness);
            this.grpbThicknessList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThicknessList.Location = new System.Drawing.Point(3, 3);
            this.grpbThicknessList.Name = "grpbThicknessList";
            this.grpbThicknessList.Size = new System.Drawing.Size(652, 253);
            this.grpbThicknessList.TabIndex = 0;
            this.grpbThicknessList.TabStop = false;
            // 
            // btnBoppThicknessDelete
            // 
            this.btnBoppThicknessDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBoppThicknessDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppThicknessDelete.Location = new System.Drawing.Point(622, 223);
            this.btnBoppThicknessDelete.Name = "btnBoppThicknessDelete";
            this.btnBoppThicknessDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBoppThicknessDelete.TabIndex = 34;
            this.btnBoppThicknessDelete.UseVisualStyleBackColor = true;
            // 
            // btnBoppThicknessEdit
            // 
            this.btnBoppThicknessEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBoppThicknessEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppThicknessEdit.Location = new System.Drawing.Point(596, 223);
            this.btnBoppThicknessEdit.Name = "btnBoppThicknessEdit";
            this.btnBoppThicknessEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBoppThicknessEdit.TabIndex = 33;
            this.btnBoppThicknessEdit.UseVisualStyleBackColor = true;
            this.btnBoppThicknessEdit.Click += new System.EventHandler(this.btnBoppThicknessEdit_Click);
            // 
            // btnBoppThicknessAdd
            // 
            this.btnBoppThicknessAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBoppThicknessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppThicknessAdd.Location = new System.Drawing.Point(570, 223);
            this.btnBoppThicknessAdd.Name = "btnBoppThicknessAdd";
            this.btnBoppThicknessAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBoppThicknessAdd.TabIndex = 32;
            this.btnBoppThicknessAdd.UseVisualStyleBackColor = true;
            this.btnBoppThicknessAdd.Click += new System.EventHandler(this.btnBoppThicknessAdd_Click);
            // 
            // dgvThickness
            // 
            this.dgvThickness.AllowUserToAddRows = false;
            this.dgvThickness.AllowUserToDeleteRows = false;
            this.dgvThickness.AllowUserToOrderColumns = true;
            this.dgvThickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThickness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThicknessCodsec,
            this.clmThicknessValue});
            this.dgvThickness.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThickness.Location = new System.Drawing.Point(3, 17);
            this.dgvThickness.Name = "dgvThickness";
            this.dgvThickness.ReadOnly = true;
            this.dgvThickness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThickness.Size = new System.Drawing.Size(646, 198);
            this.dgvThickness.TabIndex = 0;
            // 
            // clmThicknessCodsec
            // 
            this.clmThicknessCodsec.HeaderText = "Codsec";
            this.clmThicknessCodsec.Name = "clmThicknessCodsec";
            this.clmThicknessCodsec.ReadOnly = true;
            this.clmThicknessCodsec.Visible = false;
            // 
            // clmThicknessValue
            // 
            this.clmThicknessValue.HeaderText = "Valor";
            this.clmThicknessValue.Name = "clmThicknessValue";
            this.clmThicknessValue.ReadOnly = true;
            this.clmThicknessValue.Width = 150;
            // 
            // tbpBoppTreatment
            // 
            this.tbpBoppTreatment.BackColor = System.Drawing.SystemColors.Control;
            this.tbpBoppTreatment.Controls.Add(this.grpbTreatmentForm);
            this.tbpBoppTreatment.Controls.Add(this.grpbTreatmentList);
            this.tbpBoppTreatment.Location = new System.Drawing.Point(4, 22);
            this.tbpBoppTreatment.Name = "tbpBoppTreatment";
            this.tbpBoppTreatment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBoppTreatment.Size = new System.Drawing.Size(658, 498);
            this.tbpBoppTreatment.TabIndex = 4;
            this.tbpBoppTreatment.Text = "Tratamientos";
            // 
            // grpbTreatmentForm
            // 
            this.grpbTreatmentForm.Controls.Add(this.txtTreatmentAbbreviation);
            this.grpbTreatmentForm.Controls.Add(this.chbxCoatingTreatment);
            this.grpbTreatmentForm.Controls.Add(this.chbxCastTreatment);
            this.grpbTreatmentForm.Controls.Add(this.chbxBoppTreatment);
            this.grpbTreatmentForm.Controls.Add(this.txtTreatmentName);
            this.grpbTreatmentForm.Controls.Add(this.lblTreatmentAbbreviation);
            this.grpbTreatmentForm.Controls.Add(this.lblTreatmentName);
            this.grpbTreatmentForm.Controls.Add(this.btnBoppTreatmentCancel);
            this.grpbTreatmentForm.Controls.Add(this.btnBoppTreatmentSave);
            this.grpbTreatmentForm.Location = new System.Drawing.Point(3, 253);
            this.grpbTreatmentForm.Name = "grpbTreatmentForm";
            this.grpbTreatmentForm.Size = new System.Drawing.Size(652, 241);
            this.grpbTreatmentForm.TabIndex = 1;
            this.grpbTreatmentForm.TabStop = false;
            // 
            // txtTreatmentAbbreviation
            // 
            this.txtTreatmentAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtTreatmentAbbreviation.Name = "txtTreatmentAbbreviation";
            this.txtTreatmentAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtTreatmentAbbreviation.TabIndex = 2;
            // 
            // chbxCoatingTreatment
            // 
            this.chbxCoatingTreatment.AutoSize = true;
            this.chbxCoatingTreatment.Location = new System.Drawing.Point(214, 103);
            this.chbxCoatingTreatment.Name = "chbxCoatingTreatment";
            this.chbxCoatingTreatment.Size = new System.Drawing.Size(62, 17);
            this.chbxCoatingTreatment.TabIndex = 5;
            this.chbxCoatingTreatment.Text = "Coating";
            this.chbxCoatingTreatment.UseVisualStyleBackColor = true;
            // 
            // chbxCastTreatment
            // 
            this.chbxCastTreatment.AutoSize = true;
            this.chbxCastTreatment.Location = new System.Drawing.Point(111, 103);
            this.chbxCastTreatment.Name = "chbxCastTreatment";
            this.chbxCastTreatment.Size = new System.Drawing.Size(47, 17);
            this.chbxCastTreatment.TabIndex = 4;
            this.chbxCastTreatment.Text = "Cast";
            this.chbxCastTreatment.UseVisualStyleBackColor = true;
            // 
            // chbxBoppTreatment
            // 
            this.chbxBoppTreatment.AutoSize = true;
            this.chbxBoppTreatment.Location = new System.Drawing.Point(8, 103);
            this.chbxBoppTreatment.Name = "chbxBoppTreatment";
            this.chbxBoppTreatment.Size = new System.Drawing.Size(51, 17);
            this.chbxBoppTreatment.TabIndex = 3;
            this.chbxBoppTreatment.Text = "Bopp";
            this.chbxBoppTreatment.UseVisualStyleBackColor = true;
            // 
            // txtTreatmentName
            // 
            this.txtTreatmentName.Location = new System.Drawing.Point(79, 24);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(462, 21);
            this.txtTreatmentName.TabIndex = 1;
            // 
            // lblTreatmentAbbreviation
            // 
            this.lblTreatmentAbbreviation.AutoSize = true;
            this.lblTreatmentAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblTreatmentAbbreviation.Name = "lblTreatmentAbbreviation";
            this.lblTreatmentAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblTreatmentAbbreviation.TabIndex = 36;
            this.lblTreatmentAbbreviation.Text = "Abreviación";
            // 
            // lblTreatmentName
            // 
            this.lblTreatmentName.AutoSize = true;
            this.lblTreatmentName.Location = new System.Drawing.Point(3, 27);
            this.lblTreatmentName.Name = "lblTreatmentName";
            this.lblTreatmentName.Size = new System.Drawing.Size(52, 15);
            this.lblTreatmentName.TabIndex = 35;
            this.lblTreatmentName.Text = "Nombre";
            // 
            // btnBoppTreatmentCancel
            // 
            this.btnBoppTreatmentCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBoppTreatmentCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppTreatmentCancel.Location = new System.Drawing.Point(620, 210);
            this.btnBoppTreatmentCancel.Name = "btnBoppTreatmentCancel";
            this.btnBoppTreatmentCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBoppTreatmentCancel.TabIndex = 7;
            this.btnBoppTreatmentCancel.UseVisualStyleBackColor = true;
            this.btnBoppTreatmentCancel.Click += new System.EventHandler(this.btnBoppTreatmentCancel_Click_1);
            // 
            // btnBoppTreatmentSave
            // 
            this.btnBoppTreatmentSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoppTreatmentSave.BackgroundImage")));
            this.btnBoppTreatmentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppTreatmentSave.Location = new System.Drawing.Point(595, 210);
            this.btnBoppTreatmentSave.Name = "btnBoppTreatmentSave";
            this.btnBoppTreatmentSave.Size = new System.Drawing.Size(25, 25);
            this.btnBoppTreatmentSave.TabIndex = 6;
            this.btnBoppTreatmentSave.UseVisualStyleBackColor = true;
            this.btnBoppTreatmentSave.Click += new System.EventHandler(this.btnBoppTreatmentSave_Click_1);
            // 
            // grpbTreatmentList
            // 
            this.grpbTreatmentList.Controls.Add(this.btnBoppTreatmentDelete);
            this.grpbTreatmentList.Controls.Add(this.btnBoppTreatmentEdit);
            this.grpbTreatmentList.Controls.Add(this.btnBoppTreatmentAdd);
            this.grpbTreatmentList.Controls.Add(this.dgvTreatment);
            this.grpbTreatmentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTreatmentList.Location = new System.Drawing.Point(3, 3);
            this.grpbTreatmentList.Name = "grpbTreatmentList";
            this.grpbTreatmentList.Size = new System.Drawing.Size(652, 253);
            this.grpbTreatmentList.TabIndex = 0;
            this.grpbTreatmentList.TabStop = false;
            // 
            // btnBoppTreatmentDelete
            // 
            this.btnBoppTreatmentDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBoppTreatmentDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppTreatmentDelete.Location = new System.Drawing.Point(620, 223);
            this.btnBoppTreatmentDelete.Name = "btnBoppTreatmentDelete";
            this.btnBoppTreatmentDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBoppTreatmentDelete.TabIndex = 35;
            this.btnBoppTreatmentDelete.UseVisualStyleBackColor = true;
            // 
            // btnBoppTreatmentEdit
            // 
            this.btnBoppTreatmentEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBoppTreatmentEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppTreatmentEdit.Location = new System.Drawing.Point(594, 223);
            this.btnBoppTreatmentEdit.Name = "btnBoppTreatmentEdit";
            this.btnBoppTreatmentEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBoppTreatmentEdit.TabIndex = 34;
            this.btnBoppTreatmentEdit.UseVisualStyleBackColor = true;
            this.btnBoppTreatmentEdit.Click += new System.EventHandler(this.btnBoppTreatmentEdit_Click_1);
            // 
            // btnBoppTreatmentAdd
            // 
            this.btnBoppTreatmentAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBoppTreatmentAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoppTreatmentAdd.Location = new System.Drawing.Point(568, 223);
            this.btnBoppTreatmentAdd.Name = "btnBoppTreatmentAdd";
            this.btnBoppTreatmentAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBoppTreatmentAdd.TabIndex = 33;
            this.btnBoppTreatmentAdd.UseVisualStyleBackColor = true;
            this.btnBoppTreatmentAdd.Click += new System.EventHandler(this.btnBoppTreatmentAdd_Click_1);
            // 
            // dgvTreatment
            // 
            this.dgvTreatment.AllowUserToAddRows = false;
            this.dgvTreatment.AllowUserToDeleteRows = false;
            this.dgvTreatment.AllowUserToOrderColumns = true;
            this.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTreatmentCodsec,
            this.clmTreatmentAbbreviation,
            this.clmTreatmentName,
            this.clmTreatmentBopp,
            this.clmTreatmentCast,
            this.clmTreatmentCoating});
            this.dgvTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTreatment.Location = new System.Drawing.Point(3, 17);
            this.dgvTreatment.Name = "dgvTreatment";
            this.dgvTreatment.ReadOnly = true;
            this.dgvTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatment.Size = new System.Drawing.Size(646, 198);
            this.dgvTreatment.TabIndex = 0;
            // 
            // clmTreatmentCodsec
            // 
            this.clmTreatmentCodsec.HeaderText = "Codsec";
            this.clmTreatmentCodsec.Name = "clmTreatmentCodsec";
            this.clmTreatmentCodsec.ReadOnly = true;
            this.clmTreatmentCodsec.Visible = false;
            // 
            // clmTreatmentAbbreviation
            // 
            this.clmTreatmentAbbreviation.HeaderText = "Abrev.";
            this.clmTreatmentAbbreviation.Name = "clmTreatmentAbbreviation";
            this.clmTreatmentAbbreviation.ReadOnly = true;
            // 
            // clmTreatmentName
            // 
            this.clmTreatmentName.HeaderText = "Nombre";
            this.clmTreatmentName.Name = "clmTreatmentName";
            this.clmTreatmentName.ReadOnly = true;
            // 
            // clmTreatmentBopp
            // 
            this.clmTreatmentBopp.HeaderText = "Bopp";
            this.clmTreatmentBopp.Name = "clmTreatmentBopp";
            this.clmTreatmentBopp.ReadOnly = true;
            // 
            // clmTreatmentCast
            // 
            this.clmTreatmentCast.HeaderText = "Cast";
            this.clmTreatmentCast.Name = "clmTreatmentCast";
            this.clmTreatmentCast.ReadOnly = true;
            // 
            // clmTreatmentCoating
            // 
            this.clmTreatmentCoating.HeaderText = "Coating";
            this.clmTreatmentCoating.Name = "clmTreatmentCoating";
            this.clmTreatmentCoating.ReadOnly = true;
            // 
            // pnlInning
            // 
            this.pnlInning.Controls.Add(this.grpbInningForm);
            this.pnlInning.Controls.Add(this.grpbInningList);
            this.pnlInning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInning.Location = new System.Drawing.Point(0, 0);
            this.pnlInning.Name = "pnlInning";
            this.pnlInning.Size = new System.Drawing.Size(666, 524);
            this.pnlInning.TabIndex = 1;
            // 
            // grpbInningForm
            // 
            this.grpbInningForm.Controls.Add(this.btnInningCancel);
            this.grpbInningForm.Controls.Add(this.btnInningSave);
            this.grpbInningForm.Controls.Add(this.txtInningDescription);
            this.grpbInningForm.Controls.Add(this.lblInningDescription);
            this.grpbInningForm.Controls.Add(this.txtInningName);
            this.grpbInningForm.Controls.Add(this.lblInningName);
            this.grpbInningForm.Location = new System.Drawing.Point(0, 253);
            this.grpbInningForm.Name = "grpbInningForm";
            this.grpbInningForm.Size = new System.Drawing.Size(662, 267);
            this.grpbInningForm.TabIndex = 1;
            this.grpbInningForm.TabStop = false;
            // 
            // btnInningCancel
            // 
            this.btnInningCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInningCancel.BackgroundImage")));
            this.btnInningCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInningCancel.Location = new System.Drawing.Point(634, 233);
            this.btnInningCancel.Name = "btnInningCancel";
            this.btnInningCancel.Size = new System.Drawing.Size(25, 25);
            this.btnInningCancel.TabIndex = 43;
            this.btnInningCancel.UseVisualStyleBackColor = true;
            this.btnInningCancel.Click += new System.EventHandler(this.btnInningCancel_Click);
            // 
            // btnInningSave
            // 
            this.btnInningSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInningSave.BackgroundImage")));
            this.btnInningSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInningSave.Location = new System.Drawing.Point(609, 233);
            this.btnInningSave.Name = "btnInningSave";
            this.btnInningSave.Size = new System.Drawing.Size(25, 25);
            this.btnInningSave.TabIndex = 42;
            this.btnInningSave.UseVisualStyleBackColor = true;
            this.btnInningSave.Click += new System.EventHandler(this.btnInningSave_Click);
            // 
            // txtInningDescription
            // 
            this.txtInningDescription.Location = new System.Drawing.Point(79, 65);
            this.txtInningDescription.Name = "txtInningDescription";
            this.txtInningDescription.Size = new System.Drawing.Size(462, 21);
            this.txtInningDescription.TabIndex = 3;
            // 
            // lblInningDescription
            // 
            this.lblInningDescription.AutoSize = true;
            this.lblInningDescription.Location = new System.Drawing.Point(3, 68);
            this.lblInningDescription.Name = "lblInningDescription";
            this.lblInningDescription.Size = new System.Drawing.Size(69, 15);
            this.lblInningDescription.TabIndex = 2;
            this.lblInningDescription.Text = "Descrpción";
            // 
            // txtInningName
            // 
            this.txtInningName.Location = new System.Drawing.Point(79, 24);
            this.txtInningName.Name = "txtInningName";
            this.txtInningName.Size = new System.Drawing.Size(462, 21);
            this.txtInningName.TabIndex = 1;
            // 
            // lblInningName
            // 
            this.lblInningName.AutoSize = true;
            this.lblInningName.Location = new System.Drawing.Point(3, 27);
            this.lblInningName.Name = "lblInningName";
            this.lblInningName.Size = new System.Drawing.Size(52, 15);
            this.lblInningName.TabIndex = 0;
            this.lblInningName.Text = "Nombre";
            // 
            // grpbInningList
            // 
            this.grpbInningList.Controls.Add(this.btnInningDelete);
            this.grpbInningList.Controls.Add(this.btnInningEdit);
            this.grpbInningList.Controls.Add(this.btnInningAdd);
            this.grpbInningList.Controls.Add(this.dgvInning);
            this.grpbInningList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInningList.Location = new System.Drawing.Point(0, 0);
            this.grpbInningList.Name = "grpbInningList";
            this.grpbInningList.Size = new System.Drawing.Size(666, 253);
            this.grpbInningList.TabIndex = 0;
            this.grpbInningList.TabStop = false;
            // 
            // btnInningDelete
            // 
            this.btnInningDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInningDelete.BackgroundImage")));
            this.btnInningDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInningDelete.Location = new System.Drawing.Point(634, 221);
            this.btnInningDelete.Name = "btnInningDelete";
            this.btnInningDelete.Size = new System.Drawing.Size(25, 25);
            this.btnInningDelete.TabIndex = 42;
            this.btnInningDelete.UseVisualStyleBackColor = true;
            // 
            // btnInningEdit
            // 
            this.btnInningEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInningEdit.BackgroundImage")));
            this.btnInningEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInningEdit.Location = new System.Drawing.Point(608, 221);
            this.btnInningEdit.Name = "btnInningEdit";
            this.btnInningEdit.Size = new System.Drawing.Size(25, 25);
            this.btnInningEdit.TabIndex = 41;
            this.btnInningEdit.UseVisualStyleBackColor = true;
            this.btnInningEdit.Click += new System.EventHandler(this.btnInningEdit_Click);
            // 
            // btnInningAdd
            // 
            this.btnInningAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInningAdd.BackgroundImage")));
            this.btnInningAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInningAdd.Location = new System.Drawing.Point(582, 221);
            this.btnInningAdd.Name = "btnInningAdd";
            this.btnInningAdd.Size = new System.Drawing.Size(25, 25);
            this.btnInningAdd.TabIndex = 40;
            this.btnInningAdd.UseVisualStyleBackColor = true;
            this.btnInningAdd.Click += new System.EventHandler(this.btnInningAdd_Click);
            // 
            // dgvInning
            // 
            this.dgvInning.AllowUserToAddRows = false;
            this.dgvInning.AllowUserToDeleteRows = false;
            this.dgvInning.AllowUserToOrderColumns = true;
            this.dgvInning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmInningCodsec,
            this.clmInningName,
            this.clmInningDescription});
            this.dgvInning.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInning.Location = new System.Drawing.Point(3, 17);
            this.dgvInning.Name = "dgvInning";
            this.dgvInning.ReadOnly = true;
            this.dgvInning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInning.Size = new System.Drawing.Size(660, 198);
            this.dgvInning.TabIndex = 0;
            // 
            // clmInningCodsec
            // 
            this.clmInningCodsec.HeaderText = "Codsec";
            this.clmInningCodsec.Name = "clmInningCodsec";
            this.clmInningCodsec.ReadOnly = true;
            this.clmInningCodsec.Visible = false;
            // 
            // clmInningName
            // 
            this.clmInningName.HeaderText = "Nombre";
            this.clmInningName.Name = "clmInningName";
            this.clmInningName.ReadOnly = true;
            this.clmInningName.Width = 150;
            // 
            // clmInningDescription
            // 
            this.clmInningDescription.HeaderText = "Descripción";
            this.clmInningDescription.Name = "clmInningDescription";
            this.clmInningDescription.ReadOnly = true;
            this.clmInningDescription.Width = 350;
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.grpbRoleForm);
            this.pnlRole.Controls.Add(this.grpbRoleList);
            this.pnlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRole.Location = new System.Drawing.Point(0, 0);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(666, 524);
            this.pnlRole.TabIndex = 1;
            // 
            // grpbRoleForm
            // 
            this.grpbRoleForm.Controls.Add(this.btnRoleCancel);
            this.grpbRoleForm.Controls.Add(this.btnRoleSave);
            this.grpbRoleForm.Controls.Add(this.txtRoleDescription);
            this.grpbRoleForm.Controls.Add(this.txtRoleName);
            this.grpbRoleForm.Controls.Add(this.lblRoleDescription);
            this.grpbRoleForm.Controls.Add(this.lblRoleName);
            this.grpbRoleForm.Location = new System.Drawing.Point(3, 253);
            this.grpbRoleForm.Name = "grpbRoleForm";
            this.grpbRoleForm.Size = new System.Drawing.Size(657, 265);
            this.grpbRoleForm.TabIndex = 1;
            this.grpbRoleForm.TabStop = false;
            // 
            // btnRoleCancel
            // 
            this.btnRoleCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleCancel.BackgroundImage")));
            this.btnRoleCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoleCancel.Location = new System.Drawing.Point(623, 232);
            this.btnRoleCancel.Name = "btnRoleCancel";
            this.btnRoleCancel.Size = new System.Drawing.Size(25, 25);
            this.btnRoleCancel.TabIndex = 4;
            this.btnRoleCancel.UseVisualStyleBackColor = true;
            this.btnRoleCancel.Click += new System.EventHandler(this.btnRoleCancel_Click);
            // 
            // btnRoleSave
            // 
            this.btnRoleSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleSave.BackgroundImage")));
            this.btnRoleSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoleSave.Location = new System.Drawing.Point(598, 232);
            this.btnRoleSave.Name = "btnRoleSave";
            this.btnRoleSave.Size = new System.Drawing.Size(25, 25);
            this.btnRoleSave.TabIndex = 3;
            this.btnRoleSave.UseVisualStyleBackColor = true;
            this.btnRoleSave.Click += new System.EventHandler(this.btnRoleSave_Click);
            // 
            // txtRoleDescription
            // 
            this.txtRoleDescription.Location = new System.Drawing.Point(79, 65);
            this.txtRoleDescription.Name = "txtRoleDescription";
            this.txtRoleDescription.Size = new System.Drawing.Size(462, 21);
            this.txtRoleDescription.TabIndex = 2;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(79, 24);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(462, 21);
            this.txtRoleName.TabIndex = 1;
            // 
            // lblRoleDescription
            // 
            this.lblRoleDescription.AutoSize = true;
            this.lblRoleDescription.Location = new System.Drawing.Point(3, 68);
            this.lblRoleDescription.Name = "lblRoleDescription";
            this.lblRoleDescription.Size = new System.Drawing.Size(72, 15);
            this.lblRoleDescription.TabIndex = 1;
            this.lblRoleDescription.Text = "Descripción";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(3, 27);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(52, 15);
            this.lblRoleName.TabIndex = 0;
            this.lblRoleName.Text = "Nombre";
            // 
            // grpbRoleList
            // 
            this.grpbRoleList.Controls.Add(this.btnRoleDelete);
            this.grpbRoleList.Controls.Add(this.btnRoleEdit);
            this.grpbRoleList.Controls.Add(this.btnRoleAdd);
            this.grpbRoleList.Controls.Add(this.dgvRole);
            this.grpbRoleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRoleList.Location = new System.Drawing.Point(0, 0);
            this.grpbRoleList.Name = "grpbRoleList";
            this.grpbRoleList.Size = new System.Drawing.Size(666, 253);
            this.grpbRoleList.TabIndex = 0;
            this.grpbRoleList.TabStop = false;
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleDelete.BackgroundImage")));
            this.btnRoleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoleDelete.Location = new System.Drawing.Point(632, 221);
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Size = new System.Drawing.Size(25, 25);
            this.btnRoleDelete.TabIndex = 39;
            this.btnRoleDelete.UseVisualStyleBackColor = true;
            // 
            // btnRoleEdit
            // 
            this.btnRoleEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleEdit.BackgroundImage")));
            this.btnRoleEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoleEdit.Location = new System.Drawing.Point(606, 221);
            this.btnRoleEdit.Name = "btnRoleEdit";
            this.btnRoleEdit.Size = new System.Drawing.Size(25, 25);
            this.btnRoleEdit.TabIndex = 38;
            this.btnRoleEdit.UseVisualStyleBackColor = true;
            this.btnRoleEdit.Click += new System.EventHandler(this.btnRoleEdit_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleAdd.BackgroundImage")));
            this.btnRoleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoleAdd.Location = new System.Drawing.Point(580, 221);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(25, 25);
            this.btnRoleAdd.TabIndex = 37;
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToOrderColumns = true;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRoleCodsec,
            this.clmRoleName,
            this.clmRoleDescription});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRole.Location = new System.Drawing.Point(3, 17);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(660, 198);
            this.dgvRole.TabIndex = 0;
            // 
            // clmRoleCodsec
            // 
            this.clmRoleCodsec.HeaderText = "Codsec";
            this.clmRoleCodsec.Name = "clmRoleCodsec";
            this.clmRoleCodsec.ReadOnly = true;
            this.clmRoleCodsec.Visible = false;
            // 
            // clmRoleName
            // 
            this.clmRoleName.HeaderText = "Nombre";
            this.clmRoleName.Name = "clmRoleName";
            this.clmRoleName.ReadOnly = true;
            this.clmRoleName.Width = 150;
            // 
            // clmRoleDescription
            // 
            this.clmRoleDescription.HeaderText = "Descripción";
            this.clmRoleDescription.Name = "clmRoleDescription";
            this.clmRoleDescription.ReadOnly = true;
            this.clmRoleDescription.Width = 350;
            // 
            // pnlRawMaterial
            // 
            this.pnlRawMaterial.Controls.Add(this.grpbRawMaterialForm);
            this.pnlRawMaterial.Controls.Add(this.grpbRawMaterialList);
            this.pnlRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRawMaterial.Location = new System.Drawing.Point(0, 0);
            this.pnlRawMaterial.Name = "pnlRawMaterial";
            this.pnlRawMaterial.Size = new System.Drawing.Size(666, 524);
            this.pnlRawMaterial.TabIndex = 1;
            // 
            // grpbRawMaterialForm
            // 
            this.grpbRawMaterialForm.Controls.Add(this.btnRawMaterialCancel);
            this.grpbRawMaterialForm.Controls.Add(this.btnRawMaterialSave);
            this.grpbRawMaterialForm.Controls.Add(this.txtRawMaterialNote);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialNote);
            this.grpbRawMaterialForm.Controls.Add(this.cmbPackagingType);
            this.grpbRawMaterialForm.Controls.Add(this.lblPackagingType);
            this.grpbRawMaterialForm.Controls.Add(this.cmbRawMaterialUnit);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialUnit);
            this.grpbRawMaterialForm.Controls.Add(this.txtRawMaterialCode);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialCode);
            this.grpbRawMaterialForm.Controls.Add(this.txtRawMaterialName);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialName);
            this.grpbRawMaterialForm.Controls.Add(this.cmbRawMaterialType);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialType);
            this.grpbRawMaterialForm.Controls.Add(this.cmbRawMaterialEntity);
            this.grpbRawMaterialForm.Controls.Add(this.lblRawMaterialEntity);
            this.grpbRawMaterialForm.Location = new System.Drawing.Point(3, 253);
            this.grpbRawMaterialForm.Name = "grpbRawMaterialForm";
            this.grpbRawMaterialForm.Size = new System.Drawing.Size(660, 264);
            this.grpbRawMaterialForm.TabIndex = 1;
            this.grpbRawMaterialForm.TabStop = false;
            // 
            // btnRawMaterialCancel
            // 
            this.btnRawMaterialCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnRawMaterialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialCancel.Location = new System.Drawing.Point(627, 233);
            this.btnRawMaterialCancel.Name = "btnRawMaterialCancel";
            this.btnRawMaterialCancel.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialCancel.TabIndex = 43;
            this.btnRawMaterialCancel.UseVisualStyleBackColor = true;
            this.btnRawMaterialCancel.Click += new System.EventHandler(this.btnRawMaterialCancel_Click);
            // 
            // btnRawMaterialSave
            // 
            this.btnRawMaterialSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialSave.BackgroundImage")));
            this.btnRawMaterialSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialSave.Location = new System.Drawing.Point(602, 233);
            this.btnRawMaterialSave.Name = "btnRawMaterialSave";
            this.btnRawMaterialSave.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialSave.TabIndex = 42;
            this.btnRawMaterialSave.UseVisualStyleBackColor = true;
            this.btnRawMaterialSave.Click += new System.EventHandler(this.btnRawMaterialSave_Click);
            // 
            // txtRawMaterialNote
            // 
            this.txtRawMaterialNote.Location = new System.Drawing.Point(91, 161);
            this.txtRawMaterialNote.Name = "txtRawMaterialNote";
            this.txtRawMaterialNote.Size = new System.Drawing.Size(350, 21);
            this.txtRawMaterialNote.TabIndex = 7;
            // 
            // lblRawMaterialNote
            // 
            this.lblRawMaterialNote.AutoSize = true;
            this.lblRawMaterialNote.Location = new System.Drawing.Point(3, 161);
            this.lblRawMaterialNote.Name = "lblRawMaterialNote";
            this.lblRawMaterialNote.Size = new System.Drawing.Size(39, 15);
            this.lblRawMaterialNote.TabIndex = 12;
            this.lblRawMaterialNote.Text = "Notas";
            // 
            // cmbPackagingType
            // 
            this.cmbPackagingType.FormattingEnabled = true;
            this.cmbPackagingType.Location = new System.Drawing.Point(425, 115);
            this.cmbPackagingType.Name = "cmbPackagingType";
            this.cmbPackagingType.Size = new System.Drawing.Size(121, 23);
            this.cmbPackagingType.TabIndex = 6;
            // 
            // lblPackagingType
            // 
            this.lblPackagingType.AutoSize = true;
            this.lblPackagingType.Location = new System.Drawing.Point(289, 119);
            this.lblPackagingType.Name = "lblPackagingType";
            this.lblPackagingType.Size = new System.Drawing.Size(88, 15);
            this.lblPackagingType.TabIndex = 10;
            this.lblPackagingType.Text = "Tipo Empaque";
            // 
            // cmbRawMaterialUnit
            // 
            this.cmbRawMaterialUnit.FormattingEnabled = true;
            this.cmbRawMaterialUnit.Location = new System.Drawing.Point(91, 117);
            this.cmbRawMaterialUnit.Name = "cmbRawMaterialUnit";
            this.cmbRawMaterialUnit.Size = new System.Drawing.Size(121, 23);
            this.cmbRawMaterialUnit.TabIndex = 5;
            // 
            // lblRawMaterialUnit
            // 
            this.lblRawMaterialUnit.AutoSize = true;
            this.lblRawMaterialUnit.Location = new System.Drawing.Point(3, 119);
            this.lblRawMaterialUnit.Name = "lblRawMaterialUnit";
            this.lblRawMaterialUnit.Size = new System.Drawing.Size(47, 15);
            this.lblRawMaterialUnit.TabIndex = 8;
            this.lblRawMaterialUnit.Text = "Unidad";
            // 
            // txtRawMaterialCode
            // 
            this.txtRawMaterialCode.Location = new System.Drawing.Point(425, 77);
            this.txtRawMaterialCode.Name = "txtRawMaterialCode";
            this.txtRawMaterialCode.Size = new System.Drawing.Size(121, 21);
            this.txtRawMaterialCode.TabIndex = 4;
            // 
            // lblRawMaterialCode
            // 
            this.lblRawMaterialCode.AutoSize = true;
            this.lblRawMaterialCode.Location = new System.Drawing.Point(289, 77);
            this.lblRawMaterialCode.Name = "lblRawMaterialCode";
            this.lblRawMaterialCode.Size = new System.Drawing.Size(46, 15);
            this.lblRawMaterialCode.TabIndex = 6;
            this.lblRawMaterialCode.Text = "Código";
            // 
            // txtRawMaterialName
            // 
            this.txtRawMaterialName.Location = new System.Drawing.Point(91, 77);
            this.txtRawMaterialName.Name = "txtRawMaterialName";
            this.txtRawMaterialName.Size = new System.Drawing.Size(121, 21);
            this.txtRawMaterialName.TabIndex = 3;
            // 
            // lblRawMaterialName
            // 
            this.lblRawMaterialName.AutoSize = true;
            this.lblRawMaterialName.Location = new System.Drawing.Point(3, 77);
            this.lblRawMaterialName.Name = "lblRawMaterialName";
            this.lblRawMaterialName.Size = new System.Drawing.Size(52, 15);
            this.lblRawMaterialName.TabIndex = 4;
            this.lblRawMaterialName.Text = "Nombre";
            // 
            // cmbRawMaterialType
            // 
            this.cmbRawMaterialType.FormattingEnabled = true;
            this.cmbRawMaterialType.Location = new System.Drawing.Point(425, 32);
            this.cmbRawMaterialType.Name = "cmbRawMaterialType";
            this.cmbRawMaterialType.Size = new System.Drawing.Size(121, 23);
            this.cmbRawMaterialType.TabIndex = 2;
            // 
            // lblRawMaterialType
            // 
            this.lblRawMaterialType.AutoSize = true;
            this.lblRawMaterialType.Location = new System.Drawing.Point(289, 36);
            this.lblRawMaterialType.Name = "lblRawMaterialType";
            this.lblRawMaterialType.Size = new System.Drawing.Size(112, 15);
            this.lblRawMaterialType.TabIndex = 2;
            this.lblRawMaterialType.Text = "Tipo Materia Prima";
            // 
            // cmbRawMaterialEntity
            // 
            this.cmbRawMaterialEntity.FormattingEnabled = true;
            this.cmbRawMaterialEntity.Location = new System.Drawing.Point(91, 32);
            this.cmbRawMaterialEntity.Name = "cmbRawMaterialEntity";
            this.cmbRawMaterialEntity.Size = new System.Drawing.Size(121, 23);
            this.cmbRawMaterialEntity.TabIndex = 1;
            this.cmbRawMaterialEntity.SelectedIndexChanged += new System.EventHandler(this.cmbRawMaterialEntity_SelectedIndexChanged);
            // 
            // lblRawMaterialEntity
            // 
            this.lblRawMaterialEntity.AutoSize = true;
            this.lblRawMaterialEntity.Location = new System.Drawing.Point(3, 35);
            this.lblRawMaterialEntity.Name = "lblRawMaterialEntity";
            this.lblRawMaterialEntity.Size = new System.Drawing.Size(63, 15);
            this.lblRawMaterialEntity.TabIndex = 0;
            this.lblRawMaterialEntity.Text = "Proveedor";
            // 
            // grpbRawMaterialList
            // 
            this.grpbRawMaterialList.Controls.Add(this.btnRawMaterialAdd);
            this.grpbRawMaterialList.Controls.Add(this.btnRawMaterialEdit);
            this.grpbRawMaterialList.Controls.Add(this.btnRawMaterialDelete);
            this.grpbRawMaterialList.Controls.Add(this.dgvRawMaterial);
            this.grpbRawMaterialList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialList.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialList.Name = "grpbRawMaterialList";
            this.grpbRawMaterialList.Size = new System.Drawing.Size(666, 253);
            this.grpbRawMaterialList.TabIndex = 0;
            this.grpbRawMaterialList.TabStop = false;
            // 
            // btnRawMaterialAdd
            // 
            this.btnRawMaterialAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialAdd.BackgroundImage")));
            this.btnRawMaterialAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialAdd.Location = new System.Drawing.Point(578, 221);
            this.btnRawMaterialAdd.Name = "btnRawMaterialAdd";
            this.btnRawMaterialAdd.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialAdd.TabIndex = 48;
            this.btnRawMaterialAdd.UseVisualStyleBackColor = true;
            this.btnRawMaterialAdd.Click += new System.EventHandler(this.btnRawMaterialAdd_Click);
            // 
            // btnRawMaterialEdit
            // 
            this.btnRawMaterialEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialEdit.BackgroundImage")));
            this.btnRawMaterialEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialEdit.Location = new System.Drawing.Point(604, 221);
            this.btnRawMaterialEdit.Name = "btnRawMaterialEdit";
            this.btnRawMaterialEdit.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialEdit.TabIndex = 46;
            this.btnRawMaterialEdit.UseVisualStyleBackColor = true;
            this.btnRawMaterialEdit.Click += new System.EventHandler(this.btnRawMaterialEdit_Click);
            // 
            // btnRawMaterialDelete
            // 
            this.btnRawMaterialDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialDelete.BackgroundImage")));
            this.btnRawMaterialDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialDelete.Location = new System.Drawing.Point(630, 221);
            this.btnRawMaterialDelete.Name = "btnRawMaterialDelete";
            this.btnRawMaterialDelete.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialDelete.TabIndex = 47;
            this.btnRawMaterialDelete.UseVisualStyleBackColor = true;
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToDeleteRows = false;
            this.dgvRawMaterial.AllowUserToOrderColumns = true;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialCodsec,
            this.clmRawMaterialType,
            this.clmRawMaterialEntity,
            this.clmRawMaterialName,
            this.clmRawMaterialCode,
            this.clmRawMaterialUnit,
            this.clmRawMaterialPackagingType,
            this.clmRawMaterialCreatedDate,
            this.clmRawMaterialCreatorUser,
            this.clmRawMaterialModifiedDate,
            this.clmRawMaterialModificatorUser});
            this.dgvRawMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRawMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.ReadOnly = true;
            this.dgvRawMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterial.Size = new System.Drawing.Size(660, 198);
            this.dgvRawMaterial.TabIndex = 0;
            // 
            // clmRawMaterialCodsec
            // 
            this.clmRawMaterialCodsec.HeaderText = "Codsec";
            this.clmRawMaterialCodsec.Name = "clmRawMaterialCodsec";
            this.clmRawMaterialCodsec.ReadOnly = true;
            this.clmRawMaterialCodsec.Visible = false;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            // 
            // clmRawMaterialEntity
            // 
            this.clmRawMaterialEntity.HeaderText = "Proveedor";
            this.clmRawMaterialEntity.Name = "clmRawMaterialEntity";
            this.clmRawMaterialEntity.ReadOnly = true;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            // 
            // clmRawMaterialUnit
            // 
            this.clmRawMaterialUnit.HeaderText = "Unidad";
            this.clmRawMaterialUnit.Name = "clmRawMaterialUnit";
            this.clmRawMaterialUnit.ReadOnly = true;
            // 
            // clmRawMaterialPackagingType
            // 
            this.clmRawMaterialPackagingType.HeaderText = "Tipo Empaque";
            this.clmRawMaterialPackagingType.Name = "clmRawMaterialPackagingType";
            this.clmRawMaterialPackagingType.ReadOnly = true;
            // 
            // clmRawMaterialCreatedDate
            // 
            this.clmRawMaterialCreatedDate.HeaderText = "Fecha Creación";
            this.clmRawMaterialCreatedDate.Name = "clmRawMaterialCreatedDate";
            this.clmRawMaterialCreatedDate.ReadOnly = true;
            // 
            // clmRawMaterialCreatorUser
            // 
            this.clmRawMaterialCreatorUser.HeaderText = "Creado Por";
            this.clmRawMaterialCreatorUser.Name = "clmRawMaterialCreatorUser";
            this.clmRawMaterialCreatorUser.ReadOnly = true;
            // 
            // clmRawMaterialModifiedDate
            // 
            this.clmRawMaterialModifiedDate.HeaderText = "Fecha Modificado";
            this.clmRawMaterialModifiedDate.Name = "clmRawMaterialModifiedDate";
            this.clmRawMaterialModifiedDate.ReadOnly = true;
            // 
            // clmRawMaterialModificatorUser
            // 
            this.clmRawMaterialModificatorUser.HeaderText = "Modificado Por";
            this.clmRawMaterialModificatorUser.Name = "clmRawMaterialModificatorUser";
            this.clmRawMaterialModificatorUser.ReadOnly = true;
            // 
            // pnlUnit
            // 
            this.pnlUnit.Controls.Add(this.grpbUnitForm);
            this.pnlUnit.Controls.Add(this.grpbUnitList);
            this.pnlUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnit.Location = new System.Drawing.Point(0, 0);
            this.pnlUnit.Name = "pnlUnit";
            this.pnlUnit.Size = new System.Drawing.Size(666, 524);
            this.pnlUnit.TabIndex = 1;
            // 
            // grpbUnitForm
            // 
            this.grpbUnitForm.Controls.Add(this.btnUnitCancel);
            this.grpbUnitForm.Controls.Add(this.btnUnitSave);
            this.grpbUnitForm.Controls.Add(this.txtUnitSymbol);
            this.grpbUnitForm.Controls.Add(this.txtUnitName);
            this.grpbUnitForm.Controls.Add(this.lblUnitSymbol);
            this.grpbUnitForm.Controls.Add(this.lblUnitName);
            this.grpbUnitForm.Location = new System.Drawing.Point(3, 253);
            this.grpbUnitForm.Name = "grpbUnitForm";
            this.grpbUnitForm.Size = new System.Drawing.Size(660, 264);
            this.grpbUnitForm.TabIndex = 1;
            this.grpbUnitForm.TabStop = false;
            // 
            // btnUnitCancel
            // 
            this.btnUnitCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnUnitCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitCancel.Location = new System.Drawing.Point(622, 233);
            this.btnUnitCancel.Name = "btnUnitCancel";
            this.btnUnitCancel.Size = new System.Drawing.Size(25, 25);
            this.btnUnitCancel.TabIndex = 37;
            this.btnUnitCancel.UseVisualStyleBackColor = true;
            this.btnUnitCancel.Click += new System.EventHandler(this.btnUnitCancel_Click);
            // 
            // btnUnitSave
            // 
            this.btnUnitSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnitSave.BackgroundImage")));
            this.btnUnitSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitSave.Location = new System.Drawing.Point(597, 233);
            this.btnUnitSave.Name = "btnUnitSave";
            this.btnUnitSave.Size = new System.Drawing.Size(25, 25);
            this.btnUnitSave.TabIndex = 36;
            this.btnUnitSave.UseVisualStyleBackColor = true;
            this.btnUnitSave.Click += new System.EventHandler(this.btnUnitSave_Click);
            // 
            // txtUnitSymbol
            // 
            this.txtUnitSymbol.Location = new System.Drawing.Point(80, 86);
            this.txtUnitSymbol.Name = "txtUnitSymbol";
            this.txtUnitSymbol.Size = new System.Drawing.Size(121, 21);
            this.txtUnitSymbol.TabIndex = 3;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(80, 41);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(121, 21);
            this.txtUnitName.TabIndex = 1;
            // 
            // lblUnitSymbol
            // 
            this.lblUnitSymbol.AutoSize = true;
            this.lblUnitSymbol.Location = new System.Drawing.Point(3, 88);
            this.lblUnitSymbol.Name = "lblUnitSymbol";
            this.lblUnitSymbol.Size = new System.Drawing.Size(53, 15);
            this.lblUnitSymbol.TabIndex = 1;
            this.lblUnitSymbol.Text = "Símbolo";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(3, 43);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(52, 15);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "Nombre";
            // 
            // grpbUnitList
            // 
            this.grpbUnitList.Controls.Add(this.btnUnitAdd);
            this.grpbUnitList.Controls.Add(this.btnUnitEdit);
            this.grpbUnitList.Controls.Add(this.btnUnitDelete);
            this.grpbUnitList.Controls.Add(this.dgvUnit);
            this.grpbUnitList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbUnitList.Location = new System.Drawing.Point(0, 0);
            this.grpbUnitList.Name = "grpbUnitList";
            this.grpbUnitList.Size = new System.Drawing.Size(666, 253);
            this.grpbUnitList.TabIndex = 0;
            this.grpbUnitList.TabStop = false;
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnitAdd.BackgroundImage")));
            this.btnUnitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitAdd.Location = new System.Drawing.Point(578, 221);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(25, 25);
            this.btnUnitAdd.TabIndex = 39;
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // btnUnitEdit
            // 
            this.btnUnitEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnitEdit.BackgroundImage")));
            this.btnUnitEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitEdit.Location = new System.Drawing.Point(604, 221);
            this.btnUnitEdit.Name = "btnUnitEdit";
            this.btnUnitEdit.Size = new System.Drawing.Size(25, 25);
            this.btnUnitEdit.TabIndex = 37;
            this.btnUnitEdit.UseVisualStyleBackColor = true;
            this.btnUnitEdit.Click += new System.EventHandler(this.btnUnitEdit_Click);
            // 
            // btnUnitDelete
            // 
            this.btnUnitDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnitDelete.BackgroundImage")));
            this.btnUnitDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitDelete.Location = new System.Drawing.Point(630, 221);
            this.btnUnitDelete.Name = "btnUnitDelete";
            this.btnUnitDelete.Size = new System.Drawing.Size(25, 25);
            this.btnUnitDelete.TabIndex = 38;
            this.btnUnitDelete.UseVisualStyleBackColor = true;
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            this.dgvUnit.AllowUserToOrderColumns = true;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUnitCodsec,
            this.clmUnitName,
            this.clmUnitSymbol});
            this.dgvUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUnit.Location = new System.Drawing.Point(3, 17);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(660, 198);
            this.dgvUnit.TabIndex = 0;
            // 
            // clmUnitCodsec
            // 
            this.clmUnitCodsec.HeaderText = "Codsec";
            this.clmUnitCodsec.Name = "clmUnitCodsec";
            this.clmUnitCodsec.ReadOnly = true;
            this.clmUnitCodsec.Visible = false;
            // 
            // clmUnitName
            // 
            this.clmUnitName.HeaderText = "Nombre";
            this.clmUnitName.Name = "clmUnitName";
            this.clmUnitName.ReadOnly = true;
            this.clmUnitName.Width = 250;
            // 
            // clmUnitSymbol
            // 
            this.clmUnitSymbol.HeaderText = "Simbolo";
            this.clmUnitSymbol.Name = "clmUnitSymbol";
            this.clmUnitSymbol.ReadOnly = true;
            // 
            // pnlCast
            // 
            this.pnlCast.Controls.Add(this.tctrlCastFilm);
            this.pnlCast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCast.Location = new System.Drawing.Point(0, 0);
            this.pnlCast.Name = "pnlCast";
            this.pnlCast.Size = new System.Drawing.Size(666, 524);
            this.pnlCast.TabIndex = 1;
            // 
            // tctrlCastFilm
            // 
            this.tctrlCastFilm.Controls.Add(this.tbpProcess);
            this.tctrlCastFilm.Controls.Add(this.tbpStructure);
            this.tctrlCastFilm.Controls.Add(this.tbpCastAdditivations);
            this.tctrlCastFilm.Controls.Add(this.tbpCastThickness);
            this.tctrlCastFilm.Controls.Add(this.tbpCastTreatments);
            this.tctrlCastFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlCastFilm.Location = new System.Drawing.Point(0, 0);
            this.tctrlCastFilm.Name = "tctrlCastFilm";
            this.tctrlCastFilm.SelectedIndex = 0;
            this.tctrlCastFilm.Size = new System.Drawing.Size(666, 524);
            this.tctrlCastFilm.TabIndex = 1;
            // 
            // tbpProcess
            // 
            this.tbpProcess.BackColor = System.Drawing.SystemColors.Control;
            this.tbpProcess.Controls.Add(this.grpbProcessForm);
            this.tbpProcess.Controls.Add(this.grpbProcessList);
            this.tbpProcess.Location = new System.Drawing.Point(4, 24);
            this.tbpProcess.Name = "tbpProcess";
            this.tbpProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcess.Size = new System.Drawing.Size(658, 496);
            this.tbpProcess.TabIndex = 0;
            this.tbpProcess.Text = "Procesos";
            // 
            // grpbProcessForm
            // 
            this.grpbProcessForm.Controls.Add(this.chbxProcessCoating);
            this.grpbProcessForm.Controls.Add(this.chbxProcessCast);
            this.grpbProcessForm.Controls.Add(this.btnCastProcessCancel);
            this.grpbProcessForm.Controls.Add(this.btnCastProcessSave);
            this.grpbProcessForm.Controls.Add(this.txtProcessAbbreviation);
            this.grpbProcessForm.Controls.Add(this.txtProcessName);
            this.grpbProcessForm.Controls.Add(this.lblProcessAbbreviation);
            this.grpbProcessForm.Controls.Add(this.lblProcessName);
            this.grpbProcessForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProcessForm.Location = new System.Drawing.Point(3, 256);
            this.grpbProcessForm.Name = "grpbProcessForm";
            this.grpbProcessForm.Size = new System.Drawing.Size(652, 237);
            this.grpbProcessForm.TabIndex = 1;
            this.grpbProcessForm.TabStop = false;
            // 
            // chbxProcessCoating
            // 
            this.chbxProcessCoating.AutoSize = true;
            this.chbxProcessCoating.Location = new System.Drawing.Point(111, 101);
            this.chbxProcessCoating.Name = "chbxProcessCoating";
            this.chbxProcessCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxProcessCoating.TabIndex = 4;
            this.chbxProcessCoating.Text = "Coating";
            this.chbxProcessCoating.UseVisualStyleBackColor = true;
            // 
            // chbxProcessCast
            // 
            this.chbxProcessCast.AutoSize = true;
            this.chbxProcessCast.Location = new System.Drawing.Point(8, 101);
            this.chbxProcessCast.Name = "chbxProcessCast";
            this.chbxProcessCast.Size = new System.Drawing.Size(47, 17);
            this.chbxProcessCast.TabIndex = 3;
            this.chbxProcessCast.Text = "Cast";
            this.chbxProcessCast.UseVisualStyleBackColor = true;
            // 
            // btnCastProcessCancel
            // 
            this.btnCastProcessCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCastProcessCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastProcessCancel.Location = new System.Drawing.Point(624, 206);
            this.btnCastProcessCancel.Name = "btnCastProcessCancel";
            this.btnCastProcessCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCastProcessCancel.TabIndex = 6;
            this.btnCastProcessCancel.UseVisualStyleBackColor = true;
            this.btnCastProcessCancel.Click += new System.EventHandler(this.btnCastProcessCancel_Click);
            // 
            // btnCastProcessSave
            // 
            this.btnCastProcessSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastProcessSave.BackgroundImage")));
            this.btnCastProcessSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastProcessSave.Location = new System.Drawing.Point(599, 206);
            this.btnCastProcessSave.Name = "btnCastProcessSave";
            this.btnCastProcessSave.Size = new System.Drawing.Size(25, 25);
            this.btnCastProcessSave.TabIndex = 5;
            this.btnCastProcessSave.UseVisualStyleBackColor = true;
            this.btnCastProcessSave.Click += new System.EventHandler(this.btnCastProcessSave_Click);
            // 
            // txtProcessAbbreviation
            // 
            this.txtProcessAbbreviation.Location = new System.Drawing.Point(79, 63);
            this.txtProcessAbbreviation.Name = "txtProcessAbbreviation";
            this.txtProcessAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtProcessAbbreviation.TabIndex = 2;
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(79, 24);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(462, 21);
            this.txtProcessName.TabIndex = 1;
            // 
            // lblProcessAbbreviation
            // 
            this.lblProcessAbbreviation.AutoSize = true;
            this.lblProcessAbbreviation.Location = new System.Drawing.Point(3, 66);
            this.lblProcessAbbreviation.Name = "lblProcessAbbreviation";
            this.lblProcessAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblProcessAbbreviation.TabIndex = 1;
            this.lblProcessAbbreviation.Text = "Abreviación";
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(3, 27);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(52, 15);
            this.lblProcessName.TabIndex = 0;
            this.lblProcessName.Text = "Nombre";
            // 
            // grpbProcessList
            // 
            this.grpbProcessList.Controls.Add(this.btnCastProcessAdd);
            this.grpbProcessList.Controls.Add(this.btnCastProcessDelete);
            this.grpbProcessList.Controls.Add(this.btnCastProcessEdit);
            this.grpbProcessList.Controls.Add(this.dgvProcess);
            this.grpbProcessList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProcessList.Location = new System.Drawing.Point(3, 3);
            this.grpbProcessList.Name = "grpbProcessList";
            this.grpbProcessList.Size = new System.Drawing.Size(652, 253);
            this.grpbProcessList.TabIndex = 0;
            this.grpbProcessList.TabStop = false;
            // 
            // btnCastProcessAdd
            // 
            this.btnCastProcessAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCastProcessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastProcessAdd.Location = new System.Drawing.Point(572, 221);
            this.btnCastProcessAdd.Name = "btnCastProcessAdd";
            this.btnCastProcessAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCastProcessAdd.TabIndex = 31;
            this.btnCastProcessAdd.UseVisualStyleBackColor = true;
            this.btnCastProcessAdd.Click += new System.EventHandler(this.btnCastProcessAdd_Click);
            // 
            // btnCastProcessDelete
            // 
            this.btnCastProcessDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCastProcessDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastProcessDelete.Location = new System.Drawing.Point(624, 221);
            this.btnCastProcessDelete.Name = "btnCastProcessDelete";
            this.btnCastProcessDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCastProcessDelete.TabIndex = 33;
            this.btnCastProcessDelete.UseVisualStyleBackColor = true;
            // 
            // btnCastProcessEdit
            // 
            this.btnCastProcessEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCastProcessEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastProcessEdit.Location = new System.Drawing.Point(598, 221);
            this.btnCastProcessEdit.Name = "btnCastProcessEdit";
            this.btnCastProcessEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCastProcessEdit.TabIndex = 32;
            this.btnCastProcessEdit.UseVisualStyleBackColor = true;
            this.btnCastProcessEdit.Click += new System.EventHandler(this.btnCastProcessEdit_Click);
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.AllowUserToOrderColumns = true;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProcessCodsec,
            this.clmProcessAbbreviation,
            this.clmProcessName,
            this.clmProcessCast,
            this.clmProcessCoating});
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProcess.Location = new System.Drawing.Point(3, 17);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcess.Size = new System.Drawing.Size(646, 198);
            this.dgvProcess.TabIndex = 0;
            // 
            // clmProcessCodsec
            // 
            this.clmProcessCodsec.HeaderText = "ProcessCodsec";
            this.clmProcessCodsec.Name = "clmProcessCodsec";
            this.clmProcessCodsec.ReadOnly = true;
            this.clmProcessCodsec.Visible = false;
            // 
            // clmProcessAbbreviation
            // 
            this.clmProcessAbbreviation.HeaderText = "Abrev.";
            this.clmProcessAbbreviation.Name = "clmProcessAbbreviation";
            this.clmProcessAbbreviation.ReadOnly = true;
            this.clmProcessAbbreviation.Width = 60;
            // 
            // clmProcessName
            // 
            this.clmProcessName.HeaderText = "Nombre";
            this.clmProcessName.Name = "clmProcessName";
            this.clmProcessName.ReadOnly = true;
            this.clmProcessName.Width = 200;
            // 
            // clmProcessCast
            // 
            this.clmProcessCast.HeaderText = "Cast";
            this.clmProcessCast.Name = "clmProcessCast";
            this.clmProcessCast.ReadOnly = true;
            // 
            // clmProcessCoating
            // 
            this.clmProcessCoating.HeaderText = "Coating";
            this.clmProcessCoating.Name = "clmProcessCoating";
            this.clmProcessCoating.ReadOnly = true;
            // 
            // tbpStructure
            // 
            this.tbpStructure.BackColor = System.Drawing.SystemColors.Control;
            this.tbpStructure.Controls.Add(this.grpbStructureForm);
            this.tbpStructure.Controls.Add(this.grpbStructureList);
            this.tbpStructure.Location = new System.Drawing.Point(4, 22);
            this.tbpStructure.Name = "tbpStructure";
            this.tbpStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStructure.Size = new System.Drawing.Size(658, 498);
            this.tbpStructure.TabIndex = 1;
            this.tbpStructure.Text = "Estructuras";
            // 
            // grpbStructureForm
            // 
            this.grpbStructureForm.Controls.Add(this.chbxStructureCoating);
            this.grpbStructureForm.Controls.Add(this.chbxStructureCast);
            this.grpbStructureForm.Controls.Add(this.btnCastStructureCancel);
            this.grpbStructureForm.Controls.Add(this.btnCastStructureSave);
            this.grpbStructureForm.Controls.Add(this.txtStructureAbbreviation);
            this.grpbStructureForm.Controls.Add(this.txtStructureName);
            this.grpbStructureForm.Controls.Add(this.lblStructureAbbreviation);
            this.grpbStructureForm.Controls.Add(this.lblStructureName);
            this.grpbStructureForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStructureForm.Location = new System.Drawing.Point(3, 256);
            this.grpbStructureForm.Name = "grpbStructureForm";
            this.grpbStructureForm.Size = new System.Drawing.Size(652, 237);
            this.grpbStructureForm.TabIndex = 1;
            this.grpbStructureForm.TabStop = false;
            // 
            // chbxStructureCoating
            // 
            this.chbxStructureCoating.AutoSize = true;
            this.chbxStructureCoating.Location = new System.Drawing.Point(111, 102);
            this.chbxStructureCoating.Name = "chbxStructureCoating";
            this.chbxStructureCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxStructureCoating.TabIndex = 4;
            this.chbxStructureCoating.Text = "Coating";
            this.chbxStructureCoating.UseVisualStyleBackColor = true;
            // 
            // chbxStructureCast
            // 
            this.chbxStructureCast.AutoSize = true;
            this.chbxStructureCast.Location = new System.Drawing.Point(8, 102);
            this.chbxStructureCast.Name = "chbxStructureCast";
            this.chbxStructureCast.Size = new System.Drawing.Size(47, 17);
            this.chbxStructureCast.TabIndex = 3;
            this.chbxStructureCast.Text = "Cast";
            this.chbxStructureCast.UseVisualStyleBackColor = true;
            // 
            // btnCastStructureCancel
            // 
            this.btnCastStructureCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCastStructureCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastStructureCancel.Location = new System.Drawing.Point(619, 206);
            this.btnCastStructureCancel.Name = "btnCastStructureCancel";
            this.btnCastStructureCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCastStructureCancel.TabIndex = 6;
            this.btnCastStructureCancel.UseVisualStyleBackColor = true;
            this.btnCastStructureCancel.Click += new System.EventHandler(this.btnCastStructureCancel_Click);
            // 
            // btnCastStructureSave
            // 
            this.btnCastStructureSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastStructureSave.BackgroundImage")));
            this.btnCastStructureSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastStructureSave.Location = new System.Drawing.Point(594, 206);
            this.btnCastStructureSave.Name = "btnCastStructureSave";
            this.btnCastStructureSave.Size = new System.Drawing.Size(25, 25);
            this.btnCastStructureSave.TabIndex = 5;
            this.btnCastStructureSave.UseVisualStyleBackColor = true;
            this.btnCastStructureSave.Click += new System.EventHandler(this.btnCastStructureSave_Click);
            // 
            // txtStructureAbbreviation
            // 
            this.txtStructureAbbreviation.Location = new System.Drawing.Point(79, 63);
            this.txtStructureAbbreviation.Name = "txtStructureAbbreviation";
            this.txtStructureAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtStructureAbbreviation.TabIndex = 2;
            // 
            // txtStructureName
            // 
            this.txtStructureName.Location = new System.Drawing.Point(79, 24);
            this.txtStructureName.Name = "txtStructureName";
            this.txtStructureName.Size = new System.Drawing.Size(462, 21);
            this.txtStructureName.TabIndex = 1;
            // 
            // lblStructureAbbreviation
            // 
            this.lblStructureAbbreviation.AutoSize = true;
            this.lblStructureAbbreviation.Location = new System.Drawing.Point(3, 66);
            this.lblStructureAbbreviation.Name = "lblStructureAbbreviation";
            this.lblStructureAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblStructureAbbreviation.TabIndex = 1;
            this.lblStructureAbbreviation.Text = "Abreviación";
            // 
            // lblStructureName
            // 
            this.lblStructureName.AutoSize = true;
            this.lblStructureName.Location = new System.Drawing.Point(3, 27);
            this.lblStructureName.Name = "lblStructureName";
            this.lblStructureName.Size = new System.Drawing.Size(52, 15);
            this.lblStructureName.TabIndex = 0;
            this.lblStructureName.Text = "Nombre";
            // 
            // grpbStructureList
            // 
            this.grpbStructureList.Controls.Add(this.btnCastStructureDelete);
            this.grpbStructureList.Controls.Add(this.btnCastStructureEdit);
            this.grpbStructureList.Controls.Add(this.btnCastStructureAdd);
            this.grpbStructureList.Controls.Add(this.dgvStructure);
            this.grpbStructureList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStructureList.Location = new System.Drawing.Point(3, 3);
            this.grpbStructureList.Name = "grpbStructureList";
            this.grpbStructureList.Size = new System.Drawing.Size(652, 253);
            this.grpbStructureList.TabIndex = 0;
            this.grpbStructureList.TabStop = false;
            // 
            // btnCastStructureDelete
            // 
            this.btnCastStructureDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCastStructureDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastStructureDelete.Location = new System.Drawing.Point(619, 221);
            this.btnCastStructureDelete.Name = "btnCastStructureDelete";
            this.btnCastStructureDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCastStructureDelete.TabIndex = 34;
            this.btnCastStructureDelete.UseVisualStyleBackColor = true;
            // 
            // btnCastStructureEdit
            // 
            this.btnCastStructureEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCastStructureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastStructureEdit.Location = new System.Drawing.Point(593, 221);
            this.btnCastStructureEdit.Name = "btnCastStructureEdit";
            this.btnCastStructureEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCastStructureEdit.TabIndex = 33;
            this.btnCastStructureEdit.UseVisualStyleBackColor = true;
            this.btnCastStructureEdit.Click += new System.EventHandler(this.btnCastStructureEdit_Click);
            // 
            // btnCastStructureAdd
            // 
            this.btnCastStructureAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCastStructureAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastStructureAdd.Location = new System.Drawing.Point(567, 221);
            this.btnCastStructureAdd.Name = "btnCastStructureAdd";
            this.btnCastStructureAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCastStructureAdd.TabIndex = 32;
            this.btnCastStructureAdd.UseVisualStyleBackColor = true;
            this.btnCastStructureAdd.Click += new System.EventHandler(this.btnCastStructureAdd_Click);
            // 
            // dgvStructure
            // 
            this.dgvStructure.AllowUserToAddRows = false;
            this.dgvStructure.AllowUserToDeleteRows = false;
            this.dgvStructure.AllowUserToOrderColumns = true;
            this.dgvStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStructure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStructureCodsec,
            this.clmStructureAbbreviation,
            this.clmStructureName,
            this.clmStructureCast,
            this.clmStructureCoating});
            this.dgvStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStructure.Location = new System.Drawing.Point(3, 17);
            this.dgvStructure.Name = "dgvStructure";
            this.dgvStructure.ReadOnly = true;
            this.dgvStructure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStructure.Size = new System.Drawing.Size(646, 198);
            this.dgvStructure.TabIndex = 0;
            // 
            // clmStructureCodsec
            // 
            this.clmStructureCodsec.HeaderText = "StructureCodsec";
            this.clmStructureCodsec.Name = "clmStructureCodsec";
            this.clmStructureCodsec.ReadOnly = true;
            this.clmStructureCodsec.Visible = false;
            // 
            // clmStructureAbbreviation
            // 
            this.clmStructureAbbreviation.HeaderText = "Abrev.";
            this.clmStructureAbbreviation.Name = "clmStructureAbbreviation";
            this.clmStructureAbbreviation.ReadOnly = true;
            this.clmStructureAbbreviation.Width = 60;
            // 
            // clmStructureName
            // 
            this.clmStructureName.HeaderText = "Nombre";
            this.clmStructureName.Name = "clmStructureName";
            this.clmStructureName.ReadOnly = true;
            this.clmStructureName.Width = 200;
            // 
            // clmStructureCast
            // 
            this.clmStructureCast.HeaderText = "Cast";
            this.clmStructureCast.Name = "clmStructureCast";
            this.clmStructureCast.ReadOnly = true;
            // 
            // clmStructureCoating
            // 
            this.clmStructureCoating.HeaderText = "Coating";
            this.clmStructureCoating.Name = "clmStructureCoating";
            this.clmStructureCoating.ReadOnly = true;
            // 
            // tbpCastAdditivations
            // 
            this.tbpCastAdditivations.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCastAdditivations.Controls.Add(this.grpbCastAdditivationForm);
            this.tbpCastAdditivations.Controls.Add(this.grpbCastAdditivationList);
            this.tbpCastAdditivations.Location = new System.Drawing.Point(4, 22);
            this.tbpCastAdditivations.Name = "tbpCastAdditivations";
            this.tbpCastAdditivations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCastAdditivations.Size = new System.Drawing.Size(658, 498);
            this.tbpCastAdditivations.TabIndex = 2;
            this.tbpCastAdditivations.Text = "Aditivaciones";
            // 
            // grpbCastAdditivationForm
            // 
            this.grpbCastAdditivationForm.Controls.Add(this.btnCastAdditivationCancel);
            this.grpbCastAdditivationForm.Controls.Add(this.btnCastAdditivationSave);
            this.grpbCastAdditivationForm.Controls.Add(this.chbxAdditivationCast);
            this.grpbCastAdditivationForm.Controls.Add(this.chbxAdditivationBopp);
            this.grpbCastAdditivationForm.Controls.Add(this.txtCastAdditivationAbbreviation);
            this.grpbCastAdditivationForm.Controls.Add(this.txtCastAdditivationName);
            this.grpbCastAdditivationForm.Controls.Add(this.lblCastAdditivationAbbreviation);
            this.grpbCastAdditivationForm.Controls.Add(this.lblCastAdditivationName);
            this.grpbCastAdditivationForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCastAdditivationForm.Location = new System.Drawing.Point(3, 256);
            this.grpbCastAdditivationForm.Name = "grpbCastAdditivationForm";
            this.grpbCastAdditivationForm.Size = new System.Drawing.Size(652, 237);
            this.grpbCastAdditivationForm.TabIndex = 1;
            this.grpbCastAdditivationForm.TabStop = false;
            // 
            // btnCastAdditivationCancel
            // 
            this.btnCastAdditivationCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCastAdditivationCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastAdditivationCancel.Location = new System.Drawing.Point(622, 205);
            this.btnCastAdditivationCancel.Name = "btnCastAdditivationCancel";
            this.btnCastAdditivationCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCastAdditivationCancel.TabIndex = 6;
            this.btnCastAdditivationCancel.UseVisualStyleBackColor = true;
            this.btnCastAdditivationCancel.Click += new System.EventHandler(this.btnCastAdditivationCancel_Click);
            // 
            // btnCastAdditivationSave
            // 
            this.btnCastAdditivationSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastAdditivationSave.BackgroundImage")));
            this.btnCastAdditivationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastAdditivationSave.Location = new System.Drawing.Point(597, 205);
            this.btnCastAdditivationSave.Name = "btnCastAdditivationSave";
            this.btnCastAdditivationSave.Size = new System.Drawing.Size(25, 25);
            this.btnCastAdditivationSave.TabIndex = 5;
            this.btnCastAdditivationSave.UseVisualStyleBackColor = true;
            this.btnCastAdditivationSave.Click += new System.EventHandler(this.btnCastAdditivationSave_Click);
            // 
            // chbxAdditivationCast
            // 
            this.chbxAdditivationCast.AutoSize = true;
            this.chbxAdditivationCast.Location = new System.Drawing.Point(111, 103);
            this.chbxAdditivationCast.Name = "chbxAdditivationCast";
            this.chbxAdditivationCast.Size = new System.Drawing.Size(47, 17);
            this.chbxAdditivationCast.TabIndex = 4;
            this.chbxAdditivationCast.Text = "Cast";
            this.chbxAdditivationCast.UseVisualStyleBackColor = true;
            // 
            // chbxAdditivationBopp
            // 
            this.chbxAdditivationBopp.AutoSize = true;
            this.chbxAdditivationBopp.Location = new System.Drawing.Point(8, 103);
            this.chbxAdditivationBopp.Name = "chbxAdditivationBopp";
            this.chbxAdditivationBopp.Size = new System.Drawing.Size(51, 17);
            this.chbxAdditivationBopp.TabIndex = 3;
            this.chbxAdditivationBopp.Text = "Bopp";
            this.chbxAdditivationBopp.UseVisualStyleBackColor = true;
            // 
            // txtCastAdditivationAbbreviation
            // 
            this.txtCastAdditivationAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtCastAdditivationAbbreviation.Name = "txtCastAdditivationAbbreviation";
            this.txtCastAdditivationAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtCastAdditivationAbbreviation.TabIndex = 2;
            // 
            // txtCastAdditivationName
            // 
            this.txtCastAdditivationName.Location = new System.Drawing.Point(75, 24);
            this.txtCastAdditivationName.Name = "txtCastAdditivationName";
            this.txtCastAdditivationName.Size = new System.Drawing.Size(462, 21);
            this.txtCastAdditivationName.TabIndex = 1;
            // 
            // lblCastAdditivationAbbreviation
            // 
            this.lblCastAdditivationAbbreviation.AutoSize = true;
            this.lblCastAdditivationAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblCastAdditivationAbbreviation.Name = "lblCastAdditivationAbbreviation";
            this.lblCastAdditivationAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblCastAdditivationAbbreviation.TabIndex = 1;
            this.lblCastAdditivationAbbreviation.Text = "Abreviación";
            // 
            // lblCastAdditivationName
            // 
            this.lblCastAdditivationName.AutoSize = true;
            this.lblCastAdditivationName.Location = new System.Drawing.Point(3, 27);
            this.lblCastAdditivationName.Name = "lblCastAdditivationName";
            this.lblCastAdditivationName.Size = new System.Drawing.Size(52, 15);
            this.lblCastAdditivationName.TabIndex = 0;
            this.lblCastAdditivationName.Text = "Nombre";
            // 
            // grpbCastAdditivationList
            // 
            this.grpbCastAdditivationList.Controls.Add(this.btnCastAdditivationDelete);
            this.grpbCastAdditivationList.Controls.Add(this.btnCastAdditivationEdit);
            this.grpbCastAdditivationList.Controls.Add(this.btnCastAdditivationAdd);
            this.grpbCastAdditivationList.Controls.Add(this.dgvCastAdditivation);
            this.grpbCastAdditivationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCastAdditivationList.Location = new System.Drawing.Point(3, 3);
            this.grpbCastAdditivationList.Name = "grpbCastAdditivationList";
            this.grpbCastAdditivationList.Size = new System.Drawing.Size(652, 253);
            this.grpbCastAdditivationList.TabIndex = 0;
            this.grpbCastAdditivationList.TabStop = false;
            // 
            // btnCastAdditivationDelete
            // 
            this.btnCastAdditivationDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCastAdditivationDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastAdditivationDelete.Location = new System.Drawing.Point(623, 221);
            this.btnCastAdditivationDelete.Name = "btnCastAdditivationDelete";
            this.btnCastAdditivationDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCastAdditivationDelete.TabIndex = 37;
            this.btnCastAdditivationDelete.UseVisualStyleBackColor = true;
            // 
            // btnCastAdditivationEdit
            // 
            this.btnCastAdditivationEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCastAdditivationEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastAdditivationEdit.Location = new System.Drawing.Point(597, 221);
            this.btnCastAdditivationEdit.Name = "btnCastAdditivationEdit";
            this.btnCastAdditivationEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCastAdditivationEdit.TabIndex = 36;
            this.btnCastAdditivationEdit.UseVisualStyleBackColor = true;
            this.btnCastAdditivationEdit.Click += new System.EventHandler(this.btnCastAdditivationEdit_Click);
            // 
            // btnCastAdditivationAdd
            // 
            this.btnCastAdditivationAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCastAdditivationAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastAdditivationAdd.Location = new System.Drawing.Point(571, 221);
            this.btnCastAdditivationAdd.Name = "btnCastAdditivationAdd";
            this.btnCastAdditivationAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCastAdditivationAdd.TabIndex = 35;
            this.btnCastAdditivationAdd.UseVisualStyleBackColor = true;
            this.btnCastAdditivationAdd.Click += new System.EventHandler(this.btnCastAdditivationAdd_Click);
            // 
            // dgvCastAdditivation
            // 
            this.dgvCastAdditivation.AllowUserToAddRows = false;
            this.dgvCastAdditivation.AllowUserToDeleteRows = false;
            this.dgvCastAdditivation.AllowUserToOrderColumns = true;
            this.dgvCastAdditivation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCastAdditivation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCastAdditivationCodsec,
            this.clmCastAdditivationAbreviattion,
            this.clmCastAdditivationName,
            this.clmCastAdditivationBopp,
            this.clmCastAdditivationCast});
            this.dgvCastAdditivation.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCastAdditivation.Location = new System.Drawing.Point(3, 17);
            this.dgvCastAdditivation.Name = "dgvCastAdditivation";
            this.dgvCastAdditivation.ReadOnly = true;
            this.dgvCastAdditivation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCastAdditivation.Size = new System.Drawing.Size(646, 198);
            this.dgvCastAdditivation.TabIndex = 0;
            // 
            // clmCastAdditivationCodsec
            // 
            this.clmCastAdditivationCodsec.HeaderText = "AdditivationCodsec";
            this.clmCastAdditivationCodsec.Name = "clmCastAdditivationCodsec";
            this.clmCastAdditivationCodsec.ReadOnly = true;
            this.clmCastAdditivationCodsec.Visible = false;
            // 
            // clmCastAdditivationAbreviattion
            // 
            this.clmCastAdditivationAbreviattion.HeaderText = "Abrev.";
            this.clmCastAdditivationAbreviattion.Name = "clmCastAdditivationAbreviattion";
            this.clmCastAdditivationAbreviattion.ReadOnly = true;
            // 
            // clmCastAdditivationName
            // 
            this.clmCastAdditivationName.HeaderText = "Nombre";
            this.clmCastAdditivationName.Name = "clmCastAdditivationName";
            this.clmCastAdditivationName.ReadOnly = true;
            this.clmCastAdditivationName.Width = 200;
            // 
            // clmCastAdditivationBopp
            // 
            this.clmCastAdditivationBopp.HeaderText = "Bopp";
            this.clmCastAdditivationBopp.Name = "clmCastAdditivationBopp";
            this.clmCastAdditivationBopp.ReadOnly = true;
            // 
            // clmCastAdditivationCast
            // 
            this.clmCastAdditivationCast.HeaderText = "Cast";
            this.clmCastAdditivationCast.Name = "clmCastAdditivationCast";
            this.clmCastAdditivationCast.ReadOnly = true;
            // 
            // tbpCastThickness
            // 
            this.tbpCastThickness.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCastThickness.Controls.Add(this.grpbThicknessCastForm);
            this.tbpCastThickness.Controls.Add(this.grpbThicknessCastList);
            this.tbpCastThickness.Location = new System.Drawing.Point(4, 22);
            this.tbpCastThickness.Name = "tbpCastThickness";
            this.tbpCastThickness.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCastThickness.Size = new System.Drawing.Size(658, 498);
            this.tbpCastThickness.TabIndex = 3;
            this.tbpCastThickness.Text = "Espesores";
            // 
            // grpbThicknessCastForm
            // 
            this.grpbThicknessCastForm.Controls.Add(this.txtThicknessCastValue);
            this.grpbThicknessCastForm.Controls.Add(this.btnCastThicknessCancel);
            this.grpbThicknessCastForm.Controls.Add(this.btnCastThicknessSave);
            this.grpbThicknessCastForm.Controls.Add(this.lblThicknessCastValue);
            this.grpbThicknessCastForm.Location = new System.Drawing.Point(3, 253);
            this.grpbThicknessCastForm.Name = "grpbThicknessCastForm";
            this.grpbThicknessCastForm.Size = new System.Drawing.Size(650, 241);
            this.grpbThicknessCastForm.TabIndex = 1;
            this.grpbThicknessCastForm.TabStop = false;
            // 
            // txtThicknessCastValue
            // 
            this.txtThicknessCastValue.Location = new System.Drawing.Point(79, 34);
            this.txtThicknessCastValue.Name = "txtThicknessCastValue";
            this.txtThicknessCastValue.Size = new System.Drawing.Size(100, 21);
            this.txtThicknessCastValue.TabIndex = 1;
            // 
            // btnCastThicknessCancel
            // 
            this.btnCastThicknessCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCastThicknessCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastThicknessCancel.Location = new System.Drawing.Point(620, 209);
            this.btnCastThicknessCancel.Name = "btnCastThicknessCancel";
            this.btnCastThicknessCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCastThicknessCancel.TabIndex = 3;
            this.btnCastThicknessCancel.UseVisualStyleBackColor = true;
            this.btnCastThicknessCancel.Click += new System.EventHandler(this.btnCastThicknessCancel_Click);
            // 
            // btnCastThicknessSave
            // 
            this.btnCastThicknessSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastThicknessSave.BackgroundImage")));
            this.btnCastThicknessSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastThicknessSave.Location = new System.Drawing.Point(595, 209);
            this.btnCastThicknessSave.Name = "btnCastThicknessSave";
            this.btnCastThicknessSave.Size = new System.Drawing.Size(25, 25);
            this.btnCastThicknessSave.TabIndex = 2;
            this.btnCastThicknessSave.UseVisualStyleBackColor = true;
            this.btnCastThicknessSave.Click += new System.EventHandler(this.btnCastThicknessSave_Click);
            // 
            // lblThicknessCastValue
            // 
            this.lblThicknessCastValue.AutoSize = true;
            this.lblThicknessCastValue.Location = new System.Drawing.Point(3, 34);
            this.lblThicknessCastValue.Name = "lblThicknessCastValue";
            this.lblThicknessCastValue.Size = new System.Drawing.Size(35, 15);
            this.lblThicknessCastValue.TabIndex = 4;
            this.lblThicknessCastValue.Text = "Valor";
            // 
            // grpbThicknessCastList
            // 
            this.grpbThicknessCastList.Controls.Add(this.btnCastThicknessDelete);
            this.grpbThicknessCastList.Controls.Add(this.btnCastThicknessEdit);
            this.grpbThicknessCastList.Controls.Add(this.btnCastThicknessAdd);
            this.grpbThicknessCastList.Controls.Add(this.dgvThicknessCast);
            this.grpbThicknessCastList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThicknessCastList.Location = new System.Drawing.Point(3, 3);
            this.grpbThicknessCastList.Name = "grpbThicknessCastList";
            this.grpbThicknessCastList.Size = new System.Drawing.Size(652, 253);
            this.grpbThicknessCastList.TabIndex = 0;
            this.grpbThicknessCastList.TabStop = false;
            // 
            // btnCastThicknessDelete
            // 
            this.btnCastThicknessDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCastThicknessDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastThicknessDelete.Location = new System.Drawing.Point(621, 223);
            this.btnCastThicknessDelete.Name = "btnCastThicknessDelete";
            this.btnCastThicknessDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCastThicknessDelete.TabIndex = 40;
            this.btnCastThicknessDelete.UseVisualStyleBackColor = true;
            // 
            // btnCastThicknessEdit
            // 
            this.btnCastThicknessEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCastThicknessEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastThicknessEdit.Location = new System.Drawing.Point(595, 223);
            this.btnCastThicknessEdit.Name = "btnCastThicknessEdit";
            this.btnCastThicknessEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCastThicknessEdit.TabIndex = 39;
            this.btnCastThicknessEdit.UseVisualStyleBackColor = true;
            this.btnCastThicknessEdit.Click += new System.EventHandler(this.btnCastThicknessEdit_Click);
            // 
            // btnCastThicknessAdd
            // 
            this.btnCastThicknessAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCastThicknessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastThicknessAdd.Location = new System.Drawing.Point(569, 223);
            this.btnCastThicknessAdd.Name = "btnCastThicknessAdd";
            this.btnCastThicknessAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCastThicknessAdd.TabIndex = 38;
            this.btnCastThicknessAdd.UseVisualStyleBackColor = true;
            this.btnCastThicknessAdd.Click += new System.EventHandler(this.btnCastThicknessAdd_Click);
            // 
            // dgvThicknessCast
            // 
            this.dgvThicknessCast.AllowUserToAddRows = false;
            this.dgvThicknessCast.AllowUserToDeleteRows = false;
            this.dgvThicknessCast.AllowUserToOrderColumns = true;
            this.dgvThicknessCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThicknessCast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThicknessCastCodsec,
            this.clmThicknessCastValue});
            this.dgvThicknessCast.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThicknessCast.Location = new System.Drawing.Point(3, 17);
            this.dgvThicknessCast.Name = "dgvThicknessCast";
            this.dgvThicknessCast.ReadOnly = true;
            this.dgvThicknessCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThicknessCast.Size = new System.Drawing.Size(646, 198);
            this.dgvThicknessCast.TabIndex = 0;
            // 
            // clmThicknessCastCodsec
            // 
            this.clmThicknessCastCodsec.HeaderText = "CastCodsec";
            this.clmThicknessCastCodsec.Name = "clmThicknessCastCodsec";
            this.clmThicknessCastCodsec.ReadOnly = true;
            this.clmThicknessCastCodsec.Visible = false;
            // 
            // clmThicknessCastValue
            // 
            this.clmThicknessCastValue.HeaderText = "Valor";
            this.clmThicknessCastValue.Name = "clmThicknessCastValue";
            this.clmThicknessCastValue.ReadOnly = true;
            this.clmThicknessCastValue.Width = 250;
            // 
            // tbpCastTreatments
            // 
            this.tbpCastTreatments.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCastTreatments.Controls.Add(this.grpbTreatmentCastForm);
            this.tbpCastTreatments.Controls.Add(this.grpbTreatmentCastList);
            this.tbpCastTreatments.Location = new System.Drawing.Point(4, 22);
            this.tbpCastTreatments.Name = "tbpCastTreatments";
            this.tbpCastTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCastTreatments.Size = new System.Drawing.Size(658, 498);
            this.tbpCastTreatments.TabIndex = 4;
            this.tbpCastTreatments.Text = "Tratamientos";
            // 
            // grpbTreatmentCastForm
            // 
            this.grpbTreatmentCastForm.Controls.Add(this.btnCastTreatmentCancel);
            this.grpbTreatmentCastForm.Controls.Add(this.btnCastTreatmentSave);
            this.grpbTreatmentCastForm.Controls.Add(this.chbxTreatmentCastCoating);
            this.grpbTreatmentCastForm.Controls.Add(this.chbxTreatmentCastCast);
            this.grpbTreatmentCastForm.Controls.Add(this.chbxTreatmentCastBopp);
            this.grpbTreatmentCastForm.Controls.Add(this.txtTreatmentCastAbbreviation);
            this.grpbTreatmentCastForm.Controls.Add(this.txtTreatmentCastName);
            this.grpbTreatmentCastForm.Controls.Add(this.lblTreatmentCastAbbreviation);
            this.grpbTreatmentCastForm.Controls.Add(this.lblTreatmentCastName);
            this.grpbTreatmentCastForm.Location = new System.Drawing.Point(3, 255);
            this.grpbTreatmentCastForm.Name = "grpbTreatmentCastForm";
            this.grpbTreatmentCastForm.Size = new System.Drawing.Size(649, 239);
            this.grpbTreatmentCastForm.TabIndex = 1;
            this.grpbTreatmentCastForm.TabStop = false;
            // 
            // btnCastTreatmentCancel
            // 
            this.btnCastTreatmentCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCastTreatmentCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastTreatmentCancel.Location = new System.Drawing.Point(620, 210);
            this.btnCastTreatmentCancel.Name = "btnCastTreatmentCancel";
            this.btnCastTreatmentCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCastTreatmentCancel.TabIndex = 7;
            this.btnCastTreatmentCancel.UseVisualStyleBackColor = true;
            this.btnCastTreatmentCancel.Click += new System.EventHandler(this.btnCastTreatmentCancel_Click);
            // 
            // btnCastTreatmentSave
            // 
            this.btnCastTreatmentSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastTreatmentSave.BackgroundImage")));
            this.btnCastTreatmentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastTreatmentSave.Location = new System.Drawing.Point(595, 210);
            this.btnCastTreatmentSave.Name = "btnCastTreatmentSave";
            this.btnCastTreatmentSave.Size = new System.Drawing.Size(25, 25);
            this.btnCastTreatmentSave.TabIndex = 6;
            this.btnCastTreatmentSave.UseVisualStyleBackColor = true;
            this.btnCastTreatmentSave.Click += new System.EventHandler(this.btnCastTreatmentSave_Click);
            // 
            // chbxTreatmentCastCoating
            // 
            this.chbxTreatmentCastCoating.AutoSize = true;
            this.chbxTreatmentCastCoating.Location = new System.Drawing.Point(214, 103);
            this.chbxTreatmentCastCoating.Name = "chbxTreatmentCastCoating";
            this.chbxTreatmentCastCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxTreatmentCastCoating.TabIndex = 5;
            this.chbxTreatmentCastCoating.Text = "Coating";
            this.chbxTreatmentCastCoating.UseVisualStyleBackColor = true;
            // 
            // chbxTreatmentCastCast
            // 
            this.chbxTreatmentCastCast.AutoSize = true;
            this.chbxTreatmentCastCast.Location = new System.Drawing.Point(111, 103);
            this.chbxTreatmentCastCast.Name = "chbxTreatmentCastCast";
            this.chbxTreatmentCastCast.Size = new System.Drawing.Size(47, 17);
            this.chbxTreatmentCastCast.TabIndex = 4;
            this.chbxTreatmentCastCast.Text = "Cast";
            this.chbxTreatmentCastCast.UseVisualStyleBackColor = true;
            // 
            // chbxTreatmentCastBopp
            // 
            this.chbxTreatmentCastBopp.AutoSize = true;
            this.chbxTreatmentCastBopp.Location = new System.Drawing.Point(8, 103);
            this.chbxTreatmentCastBopp.Name = "chbxTreatmentCastBopp";
            this.chbxTreatmentCastBopp.Size = new System.Drawing.Size(51, 17);
            this.chbxTreatmentCastBopp.TabIndex = 3;
            this.chbxTreatmentCastBopp.Text = "Bopp";
            this.chbxTreatmentCastBopp.UseVisualStyleBackColor = true;
            // 
            // txtTreatmentCastAbbreviation
            // 
            this.txtTreatmentCastAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtTreatmentCastAbbreviation.Name = "txtTreatmentCastAbbreviation";
            this.txtTreatmentCastAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtTreatmentCastAbbreviation.TabIndex = 2;
            // 
            // txtTreatmentCastName
            // 
            this.txtTreatmentCastName.Location = new System.Drawing.Point(79, 24);
            this.txtTreatmentCastName.Name = "txtTreatmentCastName";
            this.txtTreatmentCastName.Size = new System.Drawing.Size(462, 21);
            this.txtTreatmentCastName.TabIndex = 1;
            // 
            // lblTreatmentCastAbbreviation
            // 
            this.lblTreatmentCastAbbreviation.AutoSize = true;
            this.lblTreatmentCastAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblTreatmentCastAbbreviation.Name = "lblTreatmentCastAbbreviation";
            this.lblTreatmentCastAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblTreatmentCastAbbreviation.TabIndex = 1;
            this.lblTreatmentCastAbbreviation.Text = "Abreviación";
            // 
            // lblTreatmentCastName
            // 
            this.lblTreatmentCastName.AutoSize = true;
            this.lblTreatmentCastName.Location = new System.Drawing.Point(3, 27);
            this.lblTreatmentCastName.Name = "lblTreatmentCastName";
            this.lblTreatmentCastName.Size = new System.Drawing.Size(52, 15);
            this.lblTreatmentCastName.TabIndex = 0;
            this.lblTreatmentCastName.Text = "Nombre";
            // 
            // grpbTreatmentCastList
            // 
            this.grpbTreatmentCastList.Controls.Add(this.btnCastTreatmentDelete);
            this.grpbTreatmentCastList.Controls.Add(this.btnCastTreatmentEdit);
            this.grpbTreatmentCastList.Controls.Add(this.btnCastTreatmentAdd);
            this.grpbTreatmentCastList.Controls.Add(this.dgvTreatmentCast);
            this.grpbTreatmentCastList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTreatmentCastList.Location = new System.Drawing.Point(3, 3);
            this.grpbTreatmentCastList.Name = "grpbTreatmentCastList";
            this.grpbTreatmentCastList.Size = new System.Drawing.Size(652, 251);
            this.grpbTreatmentCastList.TabIndex = 0;
            this.grpbTreatmentCastList.TabStop = false;
            this.grpbTreatmentCastList.Text = "a";
            // 
            // btnCastTreatmentDelete
            // 
            this.btnCastTreatmentDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCastTreatmentDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastTreatmentDelete.Location = new System.Drawing.Point(620, 219);
            this.btnCastTreatmentDelete.Name = "btnCastTreatmentDelete";
            this.btnCastTreatmentDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCastTreatmentDelete.TabIndex = 43;
            this.btnCastTreatmentDelete.UseVisualStyleBackColor = true;
            // 
            // btnCastTreatmentEdit
            // 
            this.btnCastTreatmentEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCastTreatmentEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastTreatmentEdit.Location = new System.Drawing.Point(594, 219);
            this.btnCastTreatmentEdit.Name = "btnCastTreatmentEdit";
            this.btnCastTreatmentEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCastTreatmentEdit.TabIndex = 42;
            this.btnCastTreatmentEdit.UseVisualStyleBackColor = true;
            this.btnCastTreatmentEdit.Click += new System.EventHandler(this.btnCastTreatmentEdit_Click);
            // 
            // btnCastTreatmentAdd
            // 
            this.btnCastTreatmentAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCastTreatmentAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCastTreatmentAdd.Location = new System.Drawing.Point(568, 219);
            this.btnCastTreatmentAdd.Name = "btnCastTreatmentAdd";
            this.btnCastTreatmentAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCastTreatmentAdd.TabIndex = 41;
            this.btnCastTreatmentAdd.UseVisualStyleBackColor = true;
            this.btnCastTreatmentAdd.Click += new System.EventHandler(this.btnCastTreatmentAdd_Click);
            // 
            // dgvTreatmentCast
            // 
            this.dgvTreatmentCast.AllowUserToAddRows = false;
            this.dgvTreatmentCast.AllowUserToDeleteRows = false;
            this.dgvTreatmentCast.AllowUserToOrderColumns = true;
            this.dgvTreatmentCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatmentCast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTreatmenCastCodsec,
            this.clmTreatmenCastAbbreviation,
            this.clmTreatmenCastName,
            this.clmTreatmenCastBopp,
            this.clmTreatmenCastCast,
            this.clmTreatmenCastCoating});
            this.dgvTreatmentCast.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTreatmentCast.Location = new System.Drawing.Point(3, 17);
            this.dgvTreatmentCast.Name = "dgvTreatmentCast";
            this.dgvTreatmentCast.ReadOnly = true;
            this.dgvTreatmentCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatmentCast.Size = new System.Drawing.Size(646, 198);
            this.dgvTreatmentCast.TabIndex = 0;
            // 
            // clmTreatmenCastCodsec
            // 
            this.clmTreatmenCastCodsec.HeaderText = "TreatmentCodsec";
            this.clmTreatmenCastCodsec.Name = "clmTreatmenCastCodsec";
            this.clmTreatmenCastCodsec.ReadOnly = true;
            this.clmTreatmenCastCodsec.Visible = false;
            // 
            // clmTreatmenCastAbbreviation
            // 
            this.clmTreatmenCastAbbreviation.HeaderText = "Abrev.";
            this.clmTreatmenCastAbbreviation.Name = "clmTreatmenCastAbbreviation";
            this.clmTreatmenCastAbbreviation.ReadOnly = true;
            // 
            // clmTreatmenCastName
            // 
            this.clmTreatmenCastName.HeaderText = "Nombre";
            this.clmTreatmenCastName.Name = "clmTreatmenCastName";
            this.clmTreatmenCastName.ReadOnly = true;
            // 
            // clmTreatmenCastBopp
            // 
            this.clmTreatmenCastBopp.HeaderText = "Bopp";
            this.clmTreatmenCastBopp.Name = "clmTreatmenCastBopp";
            this.clmTreatmenCastBopp.ReadOnly = true;
            // 
            // clmTreatmenCastCast
            // 
            this.clmTreatmenCastCast.HeaderText = "Cast";
            this.clmTreatmenCastCast.Name = "clmTreatmenCastCast";
            this.clmTreatmenCastCast.ReadOnly = true;
            // 
            // clmTreatmenCastCoating
            // 
            this.clmTreatmenCastCoating.HeaderText = "Coating";
            this.clmTreatmenCastCoating.Name = "clmTreatmenCastCoating";
            this.clmTreatmenCastCoating.ReadOnly = true;
            // 
            // pnlSupplyByentity
            // 
            this.pnlSupplyByentity.Controls.Add(this.grpbSubbplyByEntityDetail);
            this.pnlSupplyByentity.Controls.Add(this.grpbSubbplyByEntityForm);
            this.pnlSupplyByentity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupplyByentity.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplyByentity.Name = "pnlSupplyByentity";
            this.pnlSupplyByentity.Size = new System.Drawing.Size(666, 524);
            this.pnlSupplyByentity.TabIndex = 1;
            // 
            // grpbSubbplyByEntityDetail
            // 
            this.grpbSubbplyByEntityDetail.Controls.Add(this.btnSupplyByEntityAdd);
            this.grpbSubbplyByEntityDetail.Controls.Add(this.btnSupplyByEntityEdit);
            this.grpbSubbplyByEntityDetail.Controls.Add(this.button3);
            this.grpbSubbplyByEntityDetail.Controls.Add(this.dgvSupplyByEntity);
            this.grpbSubbplyByEntityDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSubbplyByEntityDetail.Location = new System.Drawing.Point(0, 0);
            this.grpbSubbplyByEntityDetail.Name = "grpbSubbplyByEntityDetail";
            this.grpbSubbplyByEntityDetail.Size = new System.Drawing.Size(666, 253);
            this.grpbSubbplyByEntityDetail.TabIndex = 2;
            this.grpbSubbplyByEntityDetail.TabStop = false;
            // 
            // btnSupplyByEntityAdd
            // 
            this.btnSupplyByEntityAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyByEntityAdd.BackgroundImage")));
            this.btnSupplyByEntityAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyByEntityAdd.Location = new System.Drawing.Point(578, 221);
            this.btnSupplyByEntityAdd.Name = "btnSupplyByEntityAdd";
            this.btnSupplyByEntityAdd.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyByEntityAdd.TabIndex = 36;
            this.btnSupplyByEntityAdd.UseVisualStyleBackColor = true;
            this.btnSupplyByEntityAdd.Click += new System.EventHandler(this.btnSupplyByEntityAdd_Click);
            // 
            // btnSupplyByEntityEdit
            // 
            this.btnSupplyByEntityEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyByEntityEdit.BackgroundImage")));
            this.btnSupplyByEntityEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyByEntityEdit.Location = new System.Drawing.Point(604, 221);
            this.btnSupplyByEntityEdit.Name = "btnSupplyByEntityEdit";
            this.btnSupplyByEntityEdit.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyByEntityEdit.TabIndex = 34;
            this.btnSupplyByEntityEdit.UseVisualStyleBackColor = true;
            this.btnSupplyByEntityEdit.Click += new System.EventHandler(this.btnSupplyByEntityEdit_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(630, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvSupplyByEntity
            // 
            this.dgvSupplyByEntity.AllowUserToAddRows = false;
            this.dgvSupplyByEntity.AllowUserToDeleteRows = false;
            this.dgvSupplyByEntity.AllowUserToOrderColumns = true;
            this.dgvSupplyByEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplyByEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSupplyByEntityCodsec,
            this.clmSupplyByEntityfkEntity,
            this.clmSupplyByEntityEntityName,
            this.clmSupplyByEntityfkSupply,
            this.clmSupplyByEntitySupplyName});
            this.dgvSupplyByEntity.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSupplyByEntity.Location = new System.Drawing.Point(3, 17);
            this.dgvSupplyByEntity.Name = "dgvSupplyByEntity";
            this.dgvSupplyByEntity.ReadOnly = true;
            this.dgvSupplyByEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplyByEntity.Size = new System.Drawing.Size(660, 198);
            this.dgvSupplyByEntity.TabIndex = 0;
            // 
            // clmSupplyByEntityCodsec
            // 
            this.clmSupplyByEntityCodsec.HeaderText = "codsec";
            this.clmSupplyByEntityCodsec.Name = "clmSupplyByEntityCodsec";
            this.clmSupplyByEntityCodsec.ReadOnly = true;
            this.clmSupplyByEntityCodsec.Visible = false;
            // 
            // clmSupplyByEntityfkEntity
            // 
            this.clmSupplyByEntityfkEntity.HeaderText = "fkEntity";
            this.clmSupplyByEntityfkEntity.Name = "clmSupplyByEntityfkEntity";
            this.clmSupplyByEntityfkEntity.ReadOnly = true;
            this.clmSupplyByEntityfkEntity.Visible = false;
            // 
            // clmSupplyByEntityEntityName
            // 
            this.clmSupplyByEntityEntityName.HeaderText = "Proveedor";
            this.clmSupplyByEntityEntityName.Name = "clmSupplyByEntityEntityName";
            this.clmSupplyByEntityEntityName.ReadOnly = true;
            this.clmSupplyByEntityEntityName.Width = 200;
            // 
            // clmSupplyByEntityfkSupply
            // 
            this.clmSupplyByEntityfkSupply.HeaderText = "fkSupply";
            this.clmSupplyByEntityfkSupply.Name = "clmSupplyByEntityfkSupply";
            this.clmSupplyByEntityfkSupply.ReadOnly = true;
            this.clmSupplyByEntityfkSupply.Visible = false;
            // 
            // clmSupplyByEntitySupplyName
            // 
            this.clmSupplyByEntitySupplyName.HeaderText = "Suministro";
            this.clmSupplyByEntitySupplyName.Name = "clmSupplyByEntitySupplyName";
            this.clmSupplyByEntitySupplyName.ReadOnly = true;
            this.clmSupplyByEntitySupplyName.Width = 250;
            // 
            // grpbSubbplyByEntityForm
            // 
            this.grpbSubbplyByEntityForm.Controls.Add(this.cmbSupplyByentitySupply);
            this.grpbSubbplyByEntityForm.Controls.Add(this.lblSupplyByentitySupply);
            this.grpbSubbplyByEntityForm.Controls.Add(this.btnSupplyByEntityCancel);
            this.grpbSubbplyByEntityForm.Controls.Add(this.btnSupplyByEntitySave);
            this.grpbSubbplyByEntityForm.Controls.Add(this.cmbSupplyByentityEntity);
            this.grpbSubbplyByEntityForm.Controls.Add(this.lblSupplyByentityEntity);
            this.grpbSubbplyByEntityForm.Location = new System.Drawing.Point(3, 257);
            this.grpbSubbplyByEntityForm.Name = "grpbSubbplyByEntityForm";
            this.grpbSubbplyByEntityForm.Size = new System.Drawing.Size(660, 264);
            this.grpbSubbplyByEntityForm.TabIndex = 3;
            this.grpbSubbplyByEntityForm.TabStop = false;
            // 
            // cmbSupplyByentitySupply
            // 
            this.cmbSupplyByentitySupply.FormattingEnabled = true;
            this.cmbSupplyByentitySupply.Location = new System.Drawing.Point(80, 68);
            this.cmbSupplyByentitySupply.Name = "cmbSupplyByentitySupply";
            this.cmbSupplyByentitySupply.Size = new System.Drawing.Size(196, 23);
            this.cmbSupplyByentitySupply.TabIndex = 42;
            // 
            // lblSupplyByentitySupply
            // 
            this.lblSupplyByentitySupply.AutoSize = true;
            this.lblSupplyByentitySupply.Location = new System.Drawing.Point(7, 73);
            this.lblSupplyByentitySupply.Name = "lblSupplyByentitySupply";
            this.lblSupplyByentitySupply.Size = new System.Drawing.Size(66, 15);
            this.lblSupplyByentitySupply.TabIndex = 41;
            this.lblSupplyByentitySupply.Text = "Suministro";
            // 
            // btnSupplyByEntityCancel
            // 
            this.btnSupplyByEntityCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyByEntityCancel.BackgroundImage")));
            this.btnSupplyByEntityCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyByEntityCancel.Location = new System.Drawing.Point(622, 233);
            this.btnSupplyByEntityCancel.Name = "btnSupplyByEntityCancel";
            this.btnSupplyByEntityCancel.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyByEntityCancel.TabIndex = 40;
            this.btnSupplyByEntityCancel.UseVisualStyleBackColor = true;
            this.btnSupplyByEntityCancel.Click += new System.EventHandler(this.btnSupplyByEntityCancel_Click);
            // 
            // btnSupplyByEntitySave
            // 
            this.btnSupplyByEntitySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplyByEntitySave.BackgroundImage")));
            this.btnSupplyByEntitySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplyByEntitySave.Location = new System.Drawing.Point(597, 233);
            this.btnSupplyByEntitySave.Name = "btnSupplyByEntitySave";
            this.btnSupplyByEntitySave.Size = new System.Drawing.Size(25, 25);
            this.btnSupplyByEntitySave.TabIndex = 39;
            this.btnSupplyByEntitySave.UseVisualStyleBackColor = true;
            this.btnSupplyByEntitySave.Click += new System.EventHandler(this.btnSupplyByEntitySave_Click);
            // 
            // cmbSupplyByentityEntity
            // 
            this.cmbSupplyByentityEntity.FormattingEnabled = true;
            this.cmbSupplyByentityEntity.Location = new System.Drawing.Point(80, 23);
            this.cmbSupplyByentityEntity.Name = "cmbSupplyByentityEntity";
            this.cmbSupplyByentityEntity.Size = new System.Drawing.Size(196, 23);
            this.cmbSupplyByentityEntity.TabIndex = 1;
            // 
            // lblSupplyByentityEntity
            // 
            this.lblSupplyByentityEntity.AutoSize = true;
            this.lblSupplyByentityEntity.Location = new System.Drawing.Point(8, 26);
            this.lblSupplyByentityEntity.Name = "lblSupplyByentityEntity";
            this.lblSupplyByentityEntity.Size = new System.Drawing.Size(63, 15);
            this.lblSupplyByentityEntity.TabIndex = 0;
            this.lblSupplyByentityEntity.Text = "Proveedor";
            // 
            // pnlRawMaterialTypeByEntity
            // 
            this.pnlRawMaterialTypeByEntity.Controls.Add(this.grpbRawMaterialTypeByEntityForm);
            this.pnlRawMaterialTypeByEntity.Controls.Add(this.grpbRawMaterialTypeByEntityList);
            this.pnlRawMaterialTypeByEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRawMaterialTypeByEntity.Location = new System.Drawing.Point(0, 0);
            this.pnlRawMaterialTypeByEntity.Name = "pnlRawMaterialTypeByEntity";
            this.pnlRawMaterialTypeByEntity.Size = new System.Drawing.Size(666, 524);
            this.pnlRawMaterialTypeByEntity.TabIndex = 1;
            // 
            // grpbRawMaterialTypeByEntityForm
            // 
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.lstbTypes);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.rdoManyTypes);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.rdoOneType);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.btnRMTypeByEntityCancel);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.btnRMTypeByEntitySave);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.cmbRawMaterialTypeByEntityEntityName);
            this.grpbRawMaterialTypeByEntityForm.Controls.Add(this.lblRawMaterialTypeByEntityEntityName);
            this.grpbRawMaterialTypeByEntityForm.Location = new System.Drawing.Point(3, 253);
            this.grpbRawMaterialTypeByEntityForm.Name = "grpbRawMaterialTypeByEntityForm";
            this.grpbRawMaterialTypeByEntityForm.Size = new System.Drawing.Size(660, 264);
            this.grpbRawMaterialTypeByEntityForm.TabIndex = 1;
            this.grpbRawMaterialTypeByEntityForm.TabStop = false;
            // 
            // lstbTypes
            // 
            this.lstbTypes.FormattingEnabled = true;
            this.lstbTypes.ItemHeight = 15;
            this.lstbTypes.Location = new System.Drawing.Point(332, 23);
            this.lstbTypes.Name = "lstbTypes";
            this.lstbTypes.Size = new System.Drawing.Size(120, 94);
            this.lstbTypes.TabIndex = 43;
            // 
            // rdoManyTypes
            // 
            this.rdoManyTypes.AutoSize = true;
            this.rdoManyTypes.Location = new System.Drawing.Point(223, 49);
            this.rdoManyTypes.Name = "rdoManyTypes";
            this.rdoManyTypes.Size = new System.Drawing.Size(83, 17);
            this.rdoManyTypes.TabIndex = 42;
            this.rdoManyTypes.TabStop = true;
            this.rdoManyTypes.Text = "Varios Tipos";
            this.rdoManyTypes.UseVisualStyleBackColor = true;
            this.rdoManyTypes.CheckedChanged += new System.EventHandler(this.rdoManyTypes_CheckedChanged);
            // 
            // rdoOneType
            // 
            this.rdoOneType.AutoSize = true;
            this.rdoOneType.Location = new System.Drawing.Point(223, 24);
            this.rdoOneType.Name = "rdoOneType";
            this.rdoOneType.Size = new System.Drawing.Size(63, 17);
            this.rdoOneType.TabIndex = 41;
            this.rdoOneType.TabStop = true;
            this.rdoOneType.Text = "Un Tipo";
            this.rdoOneType.UseVisualStyleBackColor = true;
            // 
            // btnRMTypeByEntityCancel
            // 
            this.btnRMTypeByEntityCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMTypeByEntityCancel.BackgroundImage")));
            this.btnRMTypeByEntityCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRMTypeByEntityCancel.Location = new System.Drawing.Point(622, 233);
            this.btnRMTypeByEntityCancel.Name = "btnRMTypeByEntityCancel";
            this.btnRMTypeByEntityCancel.Size = new System.Drawing.Size(25, 25);
            this.btnRMTypeByEntityCancel.TabIndex = 40;
            this.btnRMTypeByEntityCancel.UseVisualStyleBackColor = true;
            // 
            // btnRMTypeByEntitySave
            // 
            this.btnRMTypeByEntitySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMTypeByEntitySave.BackgroundImage")));
            this.btnRMTypeByEntitySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRMTypeByEntitySave.Location = new System.Drawing.Point(597, 233);
            this.btnRMTypeByEntitySave.Name = "btnRMTypeByEntitySave";
            this.btnRMTypeByEntitySave.Size = new System.Drawing.Size(25, 25);
            this.btnRMTypeByEntitySave.TabIndex = 39;
            this.btnRMTypeByEntitySave.UseVisualStyleBackColor = true;
            this.btnRMTypeByEntitySave.Click += new System.EventHandler(this.btnRMTypeByEntitySave_Click);
            // 
            // cmbRawMaterialTypeByEntityEntityName
            // 
            this.cmbRawMaterialTypeByEntityEntityName.FormattingEnabled = true;
            this.cmbRawMaterialTypeByEntityEntityName.Location = new System.Drawing.Point(80, 23);
            this.cmbRawMaterialTypeByEntityEntityName.Name = "cmbRawMaterialTypeByEntityEntityName";
            this.cmbRawMaterialTypeByEntityEntityName.Size = new System.Drawing.Size(121, 23);
            this.cmbRawMaterialTypeByEntityEntityName.TabIndex = 1;
            // 
            // lblRawMaterialTypeByEntityEntityName
            // 
            this.lblRawMaterialTypeByEntityEntityName.AutoSize = true;
            this.lblRawMaterialTypeByEntityEntityName.Location = new System.Drawing.Point(8, 26);
            this.lblRawMaterialTypeByEntityEntityName.Name = "lblRawMaterialTypeByEntityEntityName";
            this.lblRawMaterialTypeByEntityEntityName.Size = new System.Drawing.Size(63, 15);
            this.lblRawMaterialTypeByEntityEntityName.TabIndex = 0;
            this.lblRawMaterialTypeByEntityEntityName.Text = "Proveedor";
            // 
            // grpbRawMaterialTypeByEntityList
            // 
            this.grpbRawMaterialTypeByEntityList.Controls.Add(this.btnRMTypeByEntityAdd);
            this.grpbRawMaterialTypeByEntityList.Controls.Add(this.btnRMTypeByEntityEdit);
            this.grpbRawMaterialTypeByEntityList.Controls.Add(this.btnRMTypeByEntityDelete);
            this.grpbRawMaterialTypeByEntityList.Controls.Add(this.dgvRawMaterialTypeByEntity);
            this.grpbRawMaterialTypeByEntityList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialTypeByEntityList.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialTypeByEntityList.Name = "grpbRawMaterialTypeByEntityList";
            this.grpbRawMaterialTypeByEntityList.Size = new System.Drawing.Size(666, 253);
            this.grpbRawMaterialTypeByEntityList.TabIndex = 0;
            this.grpbRawMaterialTypeByEntityList.TabStop = false;
            // 
            // btnRMTypeByEntityAdd
            // 
            this.btnRMTypeByEntityAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMTypeByEntityAdd.BackgroundImage")));
            this.btnRMTypeByEntityAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRMTypeByEntityAdd.Location = new System.Drawing.Point(578, 221);
            this.btnRMTypeByEntityAdd.Name = "btnRMTypeByEntityAdd";
            this.btnRMTypeByEntityAdd.Size = new System.Drawing.Size(25, 25);
            this.btnRMTypeByEntityAdd.TabIndex = 36;
            this.btnRMTypeByEntityAdd.UseVisualStyleBackColor = true;
            this.btnRMTypeByEntityAdd.Click += new System.EventHandler(this.btnRMTypeByEntityAdd_Click);
            // 
            // btnRMTypeByEntityEdit
            // 
            this.btnRMTypeByEntityEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMTypeByEntityEdit.BackgroundImage")));
            this.btnRMTypeByEntityEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRMTypeByEntityEdit.Location = new System.Drawing.Point(604, 221);
            this.btnRMTypeByEntityEdit.Name = "btnRMTypeByEntityEdit";
            this.btnRMTypeByEntityEdit.Size = new System.Drawing.Size(25, 25);
            this.btnRMTypeByEntityEdit.TabIndex = 34;
            this.btnRMTypeByEntityEdit.UseVisualStyleBackColor = true;
            this.btnRMTypeByEntityEdit.Click += new System.EventHandler(this.btnRMTypeByEntityEdit_Click);
            // 
            // btnRMTypeByEntityDelete
            // 
            this.btnRMTypeByEntityDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMTypeByEntityDelete.BackgroundImage")));
            this.btnRMTypeByEntityDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRMTypeByEntityDelete.Location = new System.Drawing.Point(630, 221);
            this.btnRMTypeByEntityDelete.Name = "btnRMTypeByEntityDelete";
            this.btnRMTypeByEntityDelete.Size = new System.Drawing.Size(25, 25);
            this.btnRMTypeByEntityDelete.TabIndex = 35;
            this.btnRMTypeByEntityDelete.UseVisualStyleBackColor = true;
            // 
            // dgvRawMaterialTypeByEntity
            // 
            this.dgvRawMaterialTypeByEntity.AllowUserToAddRows = false;
            this.dgvRawMaterialTypeByEntity.AllowUserToDeleteRows = false;
            this.dgvRawMaterialTypeByEntity.AllowUserToOrderColumns = true;
            this.dgvRawMaterialTypeByEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterialTypeByEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialTypeByEntityCodsec,
            this.clmRawMaterialTypeByEntityEntityName,
            this.clmRawMaterialTypeByEntityName,
            this.clmRawMaterialTypeByEntityCreatedDate,
            this.clmRawMaterialTypeByEntityCreatedBy,
            this.clmRawMaterialTypeByEntityModifiedDate,
            this.clmRawMaterialTypeByEntityModifiedBy});
            this.dgvRawMaterialTypeByEntity.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRawMaterialTypeByEntity.Location = new System.Drawing.Point(3, 17);
            this.dgvRawMaterialTypeByEntity.Name = "dgvRawMaterialTypeByEntity";
            this.dgvRawMaterialTypeByEntity.ReadOnly = true;
            this.dgvRawMaterialTypeByEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterialTypeByEntity.Size = new System.Drawing.Size(660, 198);
            this.dgvRawMaterialTypeByEntity.TabIndex = 0;
            // 
            // clmRawMaterialTypeByEntityCodsec
            // 
            this.clmRawMaterialTypeByEntityCodsec.HeaderText = "Codsec";
            this.clmRawMaterialTypeByEntityCodsec.Name = "clmRawMaterialTypeByEntityCodsec";
            this.clmRawMaterialTypeByEntityCodsec.ReadOnly = true;
            this.clmRawMaterialTypeByEntityCodsec.Visible = false;
            // 
            // clmRawMaterialTypeByEntityEntityName
            // 
            this.clmRawMaterialTypeByEntityEntityName.HeaderText = "Proveedor";
            this.clmRawMaterialTypeByEntityEntityName.Name = "clmRawMaterialTypeByEntityEntityName";
            this.clmRawMaterialTypeByEntityEntityName.ReadOnly = true;
            // 
            // clmRawMaterialTypeByEntityName
            // 
            this.clmRawMaterialTypeByEntityName.HeaderText = "Tipo Materia Prima";
            this.clmRawMaterialTypeByEntityName.Name = "clmRawMaterialTypeByEntityName";
            this.clmRawMaterialTypeByEntityName.ReadOnly = true;
            // 
            // clmRawMaterialTypeByEntityCreatedDate
            // 
            this.clmRawMaterialTypeByEntityCreatedDate.HeaderText = "Fecha Creacion";
            this.clmRawMaterialTypeByEntityCreatedDate.Name = "clmRawMaterialTypeByEntityCreatedDate";
            this.clmRawMaterialTypeByEntityCreatedDate.ReadOnly = true;
            // 
            // clmRawMaterialTypeByEntityCreatedBy
            // 
            this.clmRawMaterialTypeByEntityCreatedBy.HeaderText = "Creado Por";
            this.clmRawMaterialTypeByEntityCreatedBy.Name = "clmRawMaterialTypeByEntityCreatedBy";
            this.clmRawMaterialTypeByEntityCreatedBy.ReadOnly = true;
            // 
            // clmRawMaterialTypeByEntityModifiedDate
            // 
            this.clmRawMaterialTypeByEntityModifiedDate.HeaderText = "Fecha Modificado";
            this.clmRawMaterialTypeByEntityModifiedDate.Name = "clmRawMaterialTypeByEntityModifiedDate";
            this.clmRawMaterialTypeByEntityModifiedDate.ReadOnly = true;
            // 
            // clmRawMaterialTypeByEntityModifiedBy
            // 
            this.clmRawMaterialTypeByEntityModifiedBy.HeaderText = "Modificado Por";
            this.clmRawMaterialTypeByEntityModifiedBy.Name = "clmRawMaterialTypeByEntityModifiedBy";
            this.clmRawMaterialTypeByEntityModifiedBy.ReadOnly = true;
            // 
            // pnlCellar
            // 
            this.pnlCellar.Controls.Add(this.grpbCellarList);
            this.pnlCellar.Controls.Add(this.grpbCellarForm);
            this.pnlCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCellar.Location = new System.Drawing.Point(0, 0);
            this.pnlCellar.Name = "pnlCellar";
            this.pnlCellar.Size = new System.Drawing.Size(666, 524);
            this.pnlCellar.TabIndex = 1;
            // 
            // grpbCellarList
            // 
            this.grpbCellarList.Controls.Add(this.btnAddCellar);
            this.grpbCellarList.Controls.Add(this.btnDeleteCellar);
            this.grpbCellarList.Controls.Add(this.btnEditCellar);
            this.grpbCellarList.Controls.Add(this.dgvCellar);
            this.grpbCellarList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCellarList.Location = new System.Drawing.Point(0, 0);
            this.grpbCellarList.Name = "grpbCellarList";
            this.grpbCellarList.Size = new System.Drawing.Size(666, 253);
            this.grpbCellarList.TabIndex = 2;
            this.grpbCellarList.TabStop = false;
            // 
            // btnAddCellar
            // 
            this.btnAddCellar.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddCellar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCellar.Location = new System.Drawing.Point(581, 221);
            this.btnAddCellar.Name = "btnAddCellar";
            this.btnAddCellar.Size = new System.Drawing.Size(25, 25);
            this.btnAddCellar.TabIndex = 34;
            this.btnAddCellar.UseVisualStyleBackColor = true;
            this.btnAddCellar.Click += new System.EventHandler(this.btnAddCellar_Click);
            // 
            // btnDeleteCellar
            // 
            this.btnDeleteCellar.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDeleteCellar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCellar.Location = new System.Drawing.Point(633, 221);
            this.btnDeleteCellar.Name = "btnDeleteCellar";
            this.btnDeleteCellar.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteCellar.TabIndex = 36;
            this.btnDeleteCellar.UseVisualStyleBackColor = true;
            // 
            // btnEditCellar
            // 
            this.btnEditCellar.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCellar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCellar.Location = new System.Drawing.Point(607, 221);
            this.btnEditCellar.Name = "btnEditCellar";
            this.btnEditCellar.Size = new System.Drawing.Size(25, 25);
            this.btnEditCellar.TabIndex = 35;
            this.btnEditCellar.UseVisualStyleBackColor = true;
            this.btnEditCellar.Click += new System.EventHandler(this.btnEditCellar_Click);
            // 
            // dgvCellar
            // 
            this.dgvCellar.AllowUserToAddRows = false;
            this.dgvCellar.AllowUserToDeleteRows = false;
            this.dgvCellar.AllowUserToOrderColumns = true;
            this.dgvCellar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCellar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCellarCodsec,
            this.clmCellarNombre,
            this.clmCellarDescription});
            this.dgvCellar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCellar.Location = new System.Drawing.Point(3, 17);
            this.dgvCellar.Name = "dgvCellar";
            this.dgvCellar.ReadOnly = true;
            this.dgvCellar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCellar.Size = new System.Drawing.Size(660, 198);
            this.dgvCellar.TabIndex = 0;
            // 
            // clmCellarCodsec
            // 
            this.clmCellarCodsec.HeaderText = "Codsec";
            this.clmCellarCodsec.Name = "clmCellarCodsec";
            this.clmCellarCodsec.ReadOnly = true;
            this.clmCellarCodsec.Visible = false;
            // 
            // clmCellarNombre
            // 
            this.clmCellarNombre.HeaderText = "Nombre";
            this.clmCellarNombre.Name = "clmCellarNombre";
            this.clmCellarNombre.ReadOnly = true;
            this.clmCellarNombre.Width = 250;
            // 
            // clmCellarDescription
            // 
            this.clmCellarDescription.HeaderText = "Descripción";
            this.clmCellarDescription.Name = "clmCellarDescription";
            this.clmCellarDescription.ReadOnly = true;
            this.clmCellarDescription.Width = 350;
            // 
            // grpbCellarForm
            // 
            this.grpbCellarForm.Controls.Add(this.txtCellarDescription);
            this.grpbCellarForm.Controls.Add(this.lblCellarDescription);
            this.grpbCellarForm.Controls.Add(this.btnCancelCellar);
            this.grpbCellarForm.Controls.Add(this.txtCellarName);
            this.grpbCellarForm.Controls.Add(this.btnSaveCellar);
            this.grpbCellarForm.Controls.Add(this.lblCellarName);
            this.grpbCellarForm.Location = new System.Drawing.Point(3, 256);
            this.grpbCellarForm.Name = "grpbCellarForm";
            this.grpbCellarForm.Size = new System.Drawing.Size(659, 265);
            this.grpbCellarForm.TabIndex = 3;
            this.grpbCellarForm.TabStop = false;
            // 
            // txtCellarDescription
            // 
            this.txtCellarDescription.Location = new System.Drawing.Point(101, 92);
            this.txtCellarDescription.Multiline = true;
            this.txtCellarDescription.Name = "txtCellarDescription";
            this.txtCellarDescription.Size = new System.Drawing.Size(462, 81);
            this.txtCellarDescription.TabIndex = 2;
            // 
            // lblCellarDescription
            // 
            this.lblCellarDescription.AutoSize = true;
            this.lblCellarDescription.Location = new System.Drawing.Point(4, 96);
            this.lblCellarDescription.Name = "lblCellarDescription";
            this.lblCellarDescription.Size = new System.Drawing.Size(72, 15);
            this.lblCellarDescription.TabIndex = 4;
            this.lblCellarDescription.Text = "Descripción";
            // 
            // btnCancelCellar
            // 
            this.btnCancelCellar.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelCellar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelCellar.Location = new System.Drawing.Point(631, 232);
            this.btnCancelCellar.Name = "btnCancelCellar";
            this.btnCancelCellar.Size = new System.Drawing.Size(25, 25);
            this.btnCancelCellar.TabIndex = 4;
            this.btnCancelCellar.UseVisualStyleBackColor = true;
            this.btnCancelCellar.Click += new System.EventHandler(this.btnCancelCellar_Click);
            // 
            // txtCellarName
            // 
            this.txtCellarName.Location = new System.Drawing.Point(101, 48);
            this.txtCellarName.Name = "txtCellarName";
            this.txtCellarName.Size = new System.Drawing.Size(462, 21);
            this.txtCellarName.TabIndex = 1;
            // 
            // btnSaveCellar
            // 
            this.btnSaveCellar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCellar.BackgroundImage")));
            this.btnSaveCellar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveCellar.Location = new System.Drawing.Point(606, 232);
            this.btnSaveCellar.Name = "btnSaveCellar";
            this.btnSaveCellar.Size = new System.Drawing.Size(25, 25);
            this.btnSaveCellar.TabIndex = 3;
            this.btnSaveCellar.UseVisualStyleBackColor = true;
            this.btnSaveCellar.Click += new System.EventHandler(this.btnSaveCellar_Click);
            // 
            // lblCellarName
            // 
            this.lblCellarName.AutoSize = true;
            this.lblCellarName.Location = new System.Drawing.Point(3, 51);
            this.lblCellarName.Name = "lblCellarName";
            this.lblCellarName.Size = new System.Drawing.Size(52, 15);
            this.lblCellarName.TabIndex = 0;
            this.lblCellarName.Text = "Nombre";
            // 
            // pnlStatusGroup
            // 
            this.pnlStatusGroup.Controls.Add(this.grpbStatusGroupForm);
            this.pnlStatusGroup.Controls.Add(this.grpbStatusGroupList);
            this.pnlStatusGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatusGroup.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusGroup.Name = "pnlStatusGroup";
            this.pnlStatusGroup.Size = new System.Drawing.Size(666, 524);
            this.pnlStatusGroup.TabIndex = 1;
            // 
            // grpbStatusGroupForm
            // 
            this.grpbStatusGroupForm.Controls.Add(this.btnStatusGroupCancel);
            this.grpbStatusGroupForm.Controls.Add(this.txtStatusGroupName);
            this.grpbStatusGroupForm.Controls.Add(this.btnStatusGroupSave);
            this.grpbStatusGroupForm.Controls.Add(this.lblStatusGroupName);
            this.grpbStatusGroupForm.Location = new System.Drawing.Point(3, 253);
            this.grpbStatusGroupForm.Name = "grpbStatusGroupForm";
            this.grpbStatusGroupForm.Size = new System.Drawing.Size(659, 265);
            this.grpbStatusGroupForm.TabIndex = 1;
            this.grpbStatusGroupForm.TabStop = false;
            // 
            // btnStatusGroupCancel
            // 
            this.btnStatusGroupCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnStatusGroupCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusGroupCancel.Location = new System.Drawing.Point(631, 232);
            this.btnStatusGroupCancel.Name = "btnStatusGroupCancel";
            this.btnStatusGroupCancel.Size = new System.Drawing.Size(25, 25);
            this.btnStatusGroupCancel.TabIndex = 3;
            this.btnStatusGroupCancel.UseVisualStyleBackColor = true;
            this.btnStatusGroupCancel.Click += new System.EventHandler(this.btnStatusGroupCancel_Click);
            // 
            // txtStatusGroupName
            // 
            this.txtStatusGroupName.Location = new System.Drawing.Point(79, 48);
            this.txtStatusGroupName.Name = "txtStatusGroupName";
            this.txtStatusGroupName.Size = new System.Drawing.Size(462, 21);
            this.txtStatusGroupName.TabIndex = 1;
            // 
            // btnStatusGroupSave
            // 
            this.btnStatusGroupSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatusGroupSave.BackgroundImage")));
            this.btnStatusGroupSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusGroupSave.Location = new System.Drawing.Point(606, 232);
            this.btnStatusGroupSave.Name = "btnStatusGroupSave";
            this.btnStatusGroupSave.Size = new System.Drawing.Size(25, 25);
            this.btnStatusGroupSave.TabIndex = 2;
            this.btnStatusGroupSave.UseVisualStyleBackColor = true;
            this.btnStatusGroupSave.Click += new System.EventHandler(this.btnStatusGroupSave_Click);
            // 
            // lblStatusGroupName
            // 
            this.lblStatusGroupName.AutoSize = true;
            this.lblStatusGroupName.Location = new System.Drawing.Point(3, 51);
            this.lblStatusGroupName.Name = "lblStatusGroupName";
            this.lblStatusGroupName.Size = new System.Drawing.Size(52, 15);
            this.lblStatusGroupName.TabIndex = 0;
            this.lblStatusGroupName.Text = "Nombre";
            // 
            // grpbStatusGroupList
            // 
            this.grpbStatusGroupList.Controls.Add(this.btnStatusGroupAdd);
            this.grpbStatusGroupList.Controls.Add(this.btnStatusGroupDelete);
            this.grpbStatusGroupList.Controls.Add(this.btnStatusGroupEdit);
            this.grpbStatusGroupList.Controls.Add(this.dgvStatusGroup);
            this.grpbStatusGroupList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStatusGroupList.Location = new System.Drawing.Point(0, 0);
            this.grpbStatusGroupList.Name = "grpbStatusGroupList";
            this.grpbStatusGroupList.Size = new System.Drawing.Size(666, 253);
            this.grpbStatusGroupList.TabIndex = 0;
            this.grpbStatusGroupList.TabStop = false;
            // 
            // btnStatusGroupAdd
            // 
            this.btnStatusGroupAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnStatusGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusGroupAdd.Location = new System.Drawing.Point(581, 221);
            this.btnStatusGroupAdd.Name = "btnStatusGroupAdd";
            this.btnStatusGroupAdd.Size = new System.Drawing.Size(25, 25);
            this.btnStatusGroupAdd.TabIndex = 34;
            this.btnStatusGroupAdd.UseVisualStyleBackColor = true;
            this.btnStatusGroupAdd.Click += new System.EventHandler(this.btnStatusGroupAdd_Click);
            // 
            // btnStatusGroupDelete
            // 
            this.btnStatusGroupDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnStatusGroupDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusGroupDelete.Location = new System.Drawing.Point(633, 221);
            this.btnStatusGroupDelete.Name = "btnStatusGroupDelete";
            this.btnStatusGroupDelete.Size = new System.Drawing.Size(25, 25);
            this.btnStatusGroupDelete.TabIndex = 36;
            this.btnStatusGroupDelete.UseVisualStyleBackColor = true;
            // 
            // btnStatusGroupEdit
            // 
            this.btnStatusGroupEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnStatusGroupEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusGroupEdit.Location = new System.Drawing.Point(607, 221);
            this.btnStatusGroupEdit.Name = "btnStatusGroupEdit";
            this.btnStatusGroupEdit.Size = new System.Drawing.Size(25, 25);
            this.btnStatusGroupEdit.TabIndex = 35;
            this.btnStatusGroupEdit.UseVisualStyleBackColor = true;
            this.btnStatusGroupEdit.Click += new System.EventHandler(this.btnStatusGroupEdit_Click);
            // 
            // dgvStatusGroup
            // 
            this.dgvStatusGroup.AllowUserToAddRows = false;
            this.dgvStatusGroup.AllowUserToDeleteRows = false;
            this.dgvStatusGroup.AllowUserToOrderColumns = true;
            this.dgvStatusGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStatusGroupCodsec,
            this.clmStatusGroupName});
            this.dgvStatusGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStatusGroup.Location = new System.Drawing.Point(3, 17);
            this.dgvStatusGroup.Name = "dgvStatusGroup";
            this.dgvStatusGroup.ReadOnly = true;
            this.dgvStatusGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusGroup.Size = new System.Drawing.Size(660, 198);
            this.dgvStatusGroup.TabIndex = 0;
            // 
            // clmStatusGroupCodsec
            // 
            this.clmStatusGroupCodsec.HeaderText = "Codsec";
            this.clmStatusGroupCodsec.Name = "clmStatusGroupCodsec";
            this.clmStatusGroupCodsec.ReadOnly = true;
            this.clmStatusGroupCodsec.Visible = false;
            // 
            // clmStatusGroupName
            // 
            this.clmStatusGroupName.HeaderText = "Nombre";
            this.clmStatusGroupName.Name = "clmStatusGroupName";
            this.clmStatusGroupName.ReadOnly = true;
            this.clmStatusGroupName.Width = 350;
            // 
            // pnlMill
            // 
            this.pnlMill.Controls.Add(this.grpbMillForm);
            this.pnlMill.Controls.Add(this.grpbMillList);
            this.pnlMill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMill.Location = new System.Drawing.Point(0, 0);
            this.pnlMill.Name = "pnlMill";
            this.pnlMill.Size = new System.Drawing.Size(666, 524);
            this.pnlMill.TabIndex = 1;
            // 
            // grpbMillForm
            // 
            this.grpbMillForm.Controls.Add(this.cmbxMillPlant);
            this.grpbMillForm.Controls.Add(this.lblMillPlant);
            this.grpbMillForm.Controls.Add(this.btnMillCancel);
            this.grpbMillForm.Controls.Add(this.btnMillSave);
            this.grpbMillForm.Controls.Add(this.cmbxMillStatus);
            this.grpbMillForm.Controls.Add(this.cmbxMillSector);
            this.grpbMillForm.Controls.Add(this.lblMillStatus);
            this.grpbMillForm.Controls.Add(this.lblMillSector);
            this.grpbMillForm.Controls.Add(this.txtMillKilogramsPerHour);
            this.grpbMillForm.Controls.Add(this.lblMillKilogramsPerHour);
            this.grpbMillForm.Controls.Add(this.txtMillName);
            this.grpbMillForm.Controls.Add(this.lblMillName);
            this.grpbMillForm.Location = new System.Drawing.Point(3, 253);
            this.grpbMillForm.Name = "grpbMillForm";
            this.grpbMillForm.Size = new System.Drawing.Size(658, 265);
            this.grpbMillForm.TabIndex = 1;
            this.grpbMillForm.TabStop = false;
            // 
            // cmbxMillPlant
            // 
            this.cmbxMillPlant.FormattingEnabled = true;
            this.cmbxMillPlant.Location = new System.Drawing.Point(79, 70);
            this.cmbxMillPlant.Name = "cmbxMillPlant";
            this.cmbxMillPlant.Size = new System.Drawing.Size(135, 23);
            this.cmbxMillPlant.TabIndex = 3;
            this.cmbxMillPlant.SelectedIndexChanged += new System.EventHandler(this.cmbxMillPlant_SelectedIndexChanged);
            // 
            // lblMillPlant
            // 
            this.lblMillPlant.AutoSize = true;
            this.lblMillPlant.Location = new System.Drawing.Point(4, 73);
            this.lblMillPlant.Name = "lblMillPlant";
            this.lblMillPlant.Size = new System.Drawing.Size(42, 15);
            this.lblMillPlant.TabIndex = 43;
            this.lblMillPlant.Text = "Planta";
            // 
            // btnMillCancel
            // 
            this.btnMillCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMillCancel.BackgroundImage")));
            this.btnMillCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMillCancel.Location = new System.Drawing.Point(629, 233);
            this.btnMillCancel.Name = "btnMillCancel";
            this.btnMillCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMillCancel.TabIndex = 7;
            this.btnMillCancel.UseVisualStyleBackColor = true;
            this.btnMillCancel.Click += new System.EventHandler(this.btnMillCancel_Click);
            // 
            // btnMillSave
            // 
            this.btnMillSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMillSave.BackgroundImage")));
            this.btnMillSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMillSave.Location = new System.Drawing.Point(604, 233);
            this.btnMillSave.Name = "btnMillSave";
            this.btnMillSave.Size = new System.Drawing.Size(25, 25);
            this.btnMillSave.TabIndex = 6;
            this.btnMillSave.UseVisualStyleBackColor = true;
            this.btnMillSave.Click += new System.EventHandler(this.btnMillSave_Click);
            // 
            // cmbxMillStatus
            // 
            this.cmbxMillStatus.FormattingEnabled = true;
            this.cmbxMillStatus.Location = new System.Drawing.Point(79, 117);
            this.cmbxMillStatus.Name = "cmbxMillStatus";
            this.cmbxMillStatus.Size = new System.Drawing.Size(135, 23);
            this.cmbxMillStatus.TabIndex = 5;
            // 
            // cmbxMillSector
            // 
            this.cmbxMillSector.FormattingEnabled = true;
            this.cmbxMillSector.Location = new System.Drawing.Point(356, 73);
            this.cmbxMillSector.Name = "cmbxMillSector";
            this.cmbxMillSector.Size = new System.Drawing.Size(135, 23);
            this.cmbxMillSector.TabIndex = 4;
            // 
            // lblMillStatus
            // 
            this.lblMillStatus.AutoSize = true;
            this.lblMillStatus.Location = new System.Drawing.Point(4, 120);
            this.lblMillStatus.Name = "lblMillStatus";
            this.lblMillStatus.Size = new System.Drawing.Size(45, 15);
            this.lblMillStatus.TabIndex = 4;
            this.lblMillStatus.Text = "Estado";
            // 
            // lblMillSector
            // 
            this.lblMillSector.AutoSize = true;
            this.lblMillSector.Location = new System.Drawing.Point(280, 76);
            this.lblMillSector.Name = "lblMillSector";
            this.lblMillSector.Size = new System.Drawing.Size(42, 15);
            this.lblMillSector.TabIndex = 3;
            this.lblMillSector.Text = "Sector";
            // 
            // txtMillKilogramsPerHour
            // 
            this.txtMillKilogramsPerHour.Location = new System.Drawing.Point(356, 27);
            this.txtMillKilogramsPerHour.Name = "txtMillKilogramsPerHour";
            this.txtMillKilogramsPerHour.Size = new System.Drawing.Size(135, 21);
            this.txtMillKilogramsPerHour.TabIndex = 2;
            // 
            // lblMillKilogramsPerHour
            // 
            this.lblMillKilogramsPerHour.AutoSize = true;
            this.lblMillKilogramsPerHour.Location = new System.Drawing.Point(280, 30);
            this.lblMillKilogramsPerHour.Name = "lblMillKilogramsPerHour";
            this.lblMillKilogramsPerHour.Size = new System.Drawing.Size(47, 15);
            this.lblMillKilogramsPerHour.TabIndex = 2;
            this.lblMillKilogramsPerHour.Text = "Kg / Hr.";
            // 
            // txtMillName
            // 
            this.txtMillName.Location = new System.Drawing.Point(79, 27);
            this.txtMillName.Name = "txtMillName";
            this.txtMillName.Size = new System.Drawing.Size(135, 21);
            this.txtMillName.TabIndex = 1;
            // 
            // lblMillName
            // 
            this.lblMillName.AutoSize = true;
            this.lblMillName.Location = new System.Drawing.Point(3, 30);
            this.lblMillName.Name = "lblMillName";
            this.lblMillName.Size = new System.Drawing.Size(52, 15);
            this.lblMillName.TabIndex = 0;
            this.lblMillName.Text = "Nombre";
            // 
            // grpbMillList
            // 
            this.grpbMillList.Controls.Add(this.btnMillDelete);
            this.grpbMillList.Controls.Add(this.btnMillAdd);
            this.grpbMillList.Controls.Add(this.btnMillEdit);
            this.grpbMillList.Controls.Add(this.dgvMill);
            this.grpbMillList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMillList.Location = new System.Drawing.Point(0, 0);
            this.grpbMillList.Name = "grpbMillList";
            this.grpbMillList.Size = new System.Drawing.Size(666, 253);
            this.grpbMillList.TabIndex = 0;
            this.grpbMillList.TabStop = false;
            // 
            // btnMillDelete
            // 
            this.btnMillDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnMillDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMillDelete.Location = new System.Drawing.Point(632, 221);
            this.btnMillDelete.Name = "btnMillDelete";
            this.btnMillDelete.Size = new System.Drawing.Size(25, 25);
            this.btnMillDelete.TabIndex = 47;
            this.btnMillDelete.UseVisualStyleBackColor = true;
            // 
            // btnMillAdd
            // 
            this.btnMillAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnMillAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMillAdd.Location = new System.Drawing.Point(580, 221);
            this.btnMillAdd.Name = "btnMillAdd";
            this.btnMillAdd.Size = new System.Drawing.Size(25, 25);
            this.btnMillAdd.TabIndex = 45;
            this.btnMillAdd.UseVisualStyleBackColor = true;
            this.btnMillAdd.Click += new System.EventHandler(this.btnMillAdd_Click);
            // 
            // btnMillEdit
            // 
            this.btnMillEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnMillEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMillEdit.Location = new System.Drawing.Point(606, 221);
            this.btnMillEdit.Name = "btnMillEdit";
            this.btnMillEdit.Size = new System.Drawing.Size(25, 25);
            this.btnMillEdit.TabIndex = 46;
            this.btnMillEdit.UseVisualStyleBackColor = true;
            this.btnMillEdit.Click += new System.EventHandler(this.btnMillEdit_Click);
            // 
            // dgvMill
            // 
            this.dgvMill.AllowUserToAddRows = false;
            this.dgvMill.AllowUserToDeleteRows = false;
            this.dgvMill.AllowUserToOrderColumns = true;
            this.dgvMill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMillCodsec,
            this.clmMillName,
            this.clmMillKilogramsPerHour,
            this.clmMillSector,
            this.clmMillPlant,
            this.clmMillStatus});
            this.dgvMill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMill.Location = new System.Drawing.Point(3, 17);
            this.dgvMill.Name = "dgvMill";
            this.dgvMill.ReadOnly = true;
            this.dgvMill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMill.Size = new System.Drawing.Size(660, 198);
            this.dgvMill.TabIndex = 0;
            // 
            // clmMillCodsec
            // 
            this.clmMillCodsec.HeaderText = "Codsec";
            this.clmMillCodsec.Name = "clmMillCodsec";
            this.clmMillCodsec.ReadOnly = true;
            this.clmMillCodsec.Visible = false;
            // 
            // clmMillName
            // 
            this.clmMillName.HeaderText = "Nombre";
            this.clmMillName.Name = "clmMillName";
            this.clmMillName.ReadOnly = true;
            this.clmMillName.Width = 150;
            // 
            // clmMillKilogramsPerHour
            // 
            this.clmMillKilogramsPerHour.HeaderText = "Kg / Hr.";
            this.clmMillKilogramsPerHour.Name = "clmMillKilogramsPerHour";
            this.clmMillKilogramsPerHour.ReadOnly = true;
            this.clmMillKilogramsPerHour.Width = 90;
            // 
            // clmMillSector
            // 
            this.clmMillSector.HeaderText = "Sector";
            this.clmMillSector.Name = "clmMillSector";
            this.clmMillSector.ReadOnly = true;
            this.clmMillSector.Width = 120;
            // 
            // clmMillPlant
            // 
            this.clmMillPlant.HeaderText = "Planta";
            this.clmMillPlant.Name = "clmMillPlant";
            this.clmMillPlant.ReadOnly = true;
            this.clmMillPlant.Width = 120;
            // 
            // clmMillStatus
            // 
            this.clmMillStatus.HeaderText = "Estado";
            this.clmMillStatus.Name = "clmMillStatus";
            this.clmMillStatus.ReadOnly = true;
            this.clmMillStatus.Width = 150;
            // 
            // pnlCutter
            // 
            this.pnlCutter.Controls.Add(this.grpbCutterForm);
            this.pnlCutter.Controls.Add(this.grpbCutterList);
            this.pnlCutter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCutter.Location = new System.Drawing.Point(0, 0);
            this.pnlCutter.Name = "pnlCutter";
            this.pnlCutter.Size = new System.Drawing.Size(666, 524);
            this.pnlCutter.TabIndex = 1;
            // 
            // grpbCutterForm
            // 
            this.grpbCutterForm.Controls.Add(this.cmbCutterLine);
            this.grpbCutterForm.Controls.Add(this.lblCutterLine);
            this.grpbCutterForm.Controls.Add(this.cmbxCutterPlant);
            this.grpbCutterForm.Controls.Add(this.lblCutterPlant);
            this.grpbCutterForm.Controls.Add(this.cmbxCutterStatus);
            this.grpbCutterForm.Controls.Add(this.lblCutterStatus);
            this.grpbCutterForm.Controls.Add(this.cmbxCutterSector);
            this.grpbCutterForm.Controls.Add(this.lblCutterSector);
            this.grpbCutterForm.Controls.Add(this.btnCutterCancel);
            this.grpbCutterForm.Controls.Add(this.btnCutterSave);
            this.grpbCutterForm.Controls.Add(this.txtCutterMaxVelocity);
            this.grpbCutterForm.Controls.Add(this.lblCutterMaxVelocity);
            this.grpbCutterForm.Controls.Add(this.txtCutterArms);
            this.grpbCutterForm.Controls.Add(this.lblCutterArms);
            this.grpbCutterForm.Controls.Add(this.txtCutterFilmWidth);
            this.grpbCutterForm.Controls.Add(this.txtCutterName);
            this.grpbCutterForm.Controls.Add(this.lblCutterFilmWidth);
            this.grpbCutterForm.Controls.Add(this.lblCutterName);
            this.grpbCutterForm.Location = new System.Drawing.Point(3, 253);
            this.grpbCutterForm.Name = "grpbCutterForm";
            this.grpbCutterForm.Size = new System.Drawing.Size(659, 267);
            this.grpbCutterForm.TabIndex = 1;
            this.grpbCutterForm.TabStop = false;
            // 
            // cmbCutterLine
            // 
            this.cmbCutterLine.FormattingEnabled = true;
            this.cmbCutterLine.Location = new System.Drawing.Point(84, 126);
            this.cmbCutterLine.Name = "cmbCutterLine";
            this.cmbCutterLine.Size = new System.Drawing.Size(121, 23);
            this.cmbCutterLine.TabIndex = 7;
            // 
            // lblCutterLine
            // 
            this.lblCutterLine.AutoSize = true;
            this.lblCutterLine.Location = new System.Drawing.Point(3, 129);
            this.lblCutterLine.Name = "lblCutterLine";
            this.lblCutterLine.Size = new System.Drawing.Size(38, 15);
            this.lblCutterLine.TabIndex = 45;
            this.lblCutterLine.Text = "Línea";
            // 
            // cmbxCutterPlant
            // 
            this.cmbxCutterPlant.FormattingEnabled = true;
            this.cmbxCutterPlant.Location = new System.Drawing.Point(84, 83);
            this.cmbxCutterPlant.Name = "cmbxCutterPlant";
            this.cmbxCutterPlant.Size = new System.Drawing.Size(121, 23);
            this.cmbxCutterPlant.TabIndex = 5;
            this.cmbxCutterPlant.SelectedIndexChanged += new System.EventHandler(this.cmbxCutterPlant_SelectedIndexChanged);
            // 
            // lblCutterPlant
            // 
            this.lblCutterPlant.AutoSize = true;
            this.lblCutterPlant.Location = new System.Drawing.Point(3, 88);
            this.lblCutterPlant.Name = "lblCutterPlant";
            this.lblCutterPlant.Size = new System.Drawing.Size(42, 15);
            this.lblCutterPlant.TabIndex = 44;
            this.lblCutterPlant.Text = "Planta";
            // 
            // cmbxCutterStatus
            // 
            this.cmbxCutterStatus.FormattingEnabled = true;
            this.cmbxCutterStatus.Location = new System.Drawing.Point(412, 121);
            this.cmbxCutterStatus.Name = "cmbxCutterStatus";
            this.cmbxCutterStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbxCutterStatus.TabIndex = 8;
            // 
            // lblCutterStatus
            // 
            this.lblCutterStatus.AutoSize = true;
            this.lblCutterStatus.Location = new System.Drawing.Point(290, 129);
            this.lblCutterStatus.Name = "lblCutterStatus";
            this.lblCutterStatus.Size = new System.Drawing.Size(45, 15);
            this.lblCutterStatus.TabIndex = 43;
            this.lblCutterStatus.Text = "Estado";
            // 
            // cmbxCutterSector
            // 
            this.cmbxCutterSector.FormattingEnabled = true;
            this.cmbxCutterSector.Location = new System.Drawing.Point(412, 83);
            this.cmbxCutterSector.Name = "cmbxCutterSector";
            this.cmbxCutterSector.Size = new System.Drawing.Size(121, 23);
            this.cmbxCutterSector.TabIndex = 6;
            // 
            // lblCutterSector
            // 
            this.lblCutterSector.AutoSize = true;
            this.lblCutterSector.Location = new System.Drawing.Point(290, 87);
            this.lblCutterSector.Name = "lblCutterSector";
            this.lblCutterSector.Size = new System.Drawing.Size(42, 15);
            this.lblCutterSector.TabIndex = 41;
            this.lblCutterSector.Text = "Sector";
            // 
            // btnCutterCancel
            // 
            this.btnCutterCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCutterCancel.BackgroundImage")));
            this.btnCutterCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutterCancel.Location = new System.Drawing.Point(627, 236);
            this.btnCutterCancel.Name = "btnCutterCancel";
            this.btnCutterCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCutterCancel.TabIndex = 40;
            this.btnCutterCancel.UseVisualStyleBackColor = true;
            this.btnCutterCancel.Click += new System.EventHandler(this.btnCutterCancel_Click);
            // 
            // btnCutterSave
            // 
            this.btnCutterSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCutterSave.BackgroundImage")));
            this.btnCutterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutterSave.Location = new System.Drawing.Point(602, 236);
            this.btnCutterSave.Name = "btnCutterSave";
            this.btnCutterSave.Size = new System.Drawing.Size(25, 25);
            this.btnCutterSave.TabIndex = 39;
            this.btnCutterSave.UseVisualStyleBackColor = true;
            this.btnCutterSave.Click += new System.EventHandler(this.btnCutterSave_Click);
            // 
            // txtCutterMaxVelocity
            // 
            this.txtCutterMaxVelocity.Location = new System.Drawing.Point(414, 46);
            this.txtCutterMaxVelocity.Name = "txtCutterMaxVelocity";
            this.txtCutterMaxVelocity.Size = new System.Drawing.Size(121, 21);
            this.txtCutterMaxVelocity.TabIndex = 4;
            // 
            // lblCutterMaxVelocity
            // 
            this.lblCutterMaxVelocity.AutoSize = true;
            this.lblCutterMaxVelocity.Location = new System.Drawing.Point(291, 49);
            this.lblCutterMaxVelocity.Name = "lblCutterMaxVelocity";
            this.lblCutterMaxVelocity.Size = new System.Drawing.Size(109, 15);
            this.lblCutterMaxVelocity.TabIndex = 5;
            this.lblCutterMaxVelocity.Text = "Velocidad Máxima";
            // 
            // txtCutterArms
            // 
            this.txtCutterArms.Location = new System.Drawing.Point(412, 14);
            this.txtCutterArms.Name = "txtCutterArms";
            this.txtCutterArms.Size = new System.Drawing.Size(121, 21);
            this.txtCutterArms.TabIndex = 2;
            // 
            // lblCutterArms
            // 
            this.lblCutterArms.AutoSize = true;
            this.lblCutterArms.Location = new System.Drawing.Point(290, 17);
            this.lblCutterArms.Name = "lblCutterArms";
            this.lblCutterArms.Size = new System.Drawing.Size(45, 15);
            this.lblCutterArms.TabIndex = 4;
            this.lblCutterArms.Text = "Brazos";
            // 
            // txtCutterFilmWidth
            // 
            this.txtCutterFilmWidth.Location = new System.Drawing.Point(84, 46);
            this.txtCutterFilmWidth.Name = "txtCutterFilmWidth";
            this.txtCutterFilmWidth.Size = new System.Drawing.Size(121, 21);
            this.txtCutterFilmWidth.TabIndex = 3;
            // 
            // txtCutterName
            // 
            this.txtCutterName.Location = new System.Drawing.Point(84, 14);
            this.txtCutterName.Name = "txtCutterName";
            this.txtCutterName.Size = new System.Drawing.Size(121, 21);
            this.txtCutterName.TabIndex = 1;
            // 
            // lblCutterFilmWidth
            // 
            this.lblCutterFilmWidth.AutoSize = true;
            this.lblCutterFilmWidth.Location = new System.Drawing.Point(3, 49);
            this.lblCutterFilmWidth.Name = "lblCutterFilmWidth";
            this.lblCutterFilmWidth.Size = new System.Drawing.Size(62, 15);
            this.lblCutterFilmWidth.TabIndex = 1;
            this.lblCutterFilmWidth.Text = "Ancho Util";
            // 
            // lblCutterName
            // 
            this.lblCutterName.AutoSize = true;
            this.lblCutterName.Location = new System.Drawing.Point(3, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(52, 15);
            this.lblCutterName.TabIndex = 0;
            this.lblCutterName.Text = "Nombre";
            // 
            // grpbCutterList
            // 
            this.grpbCutterList.Controls.Add(this.btnCutterDelete);
            this.grpbCutterList.Controls.Add(this.btnCutterAdd);
            this.grpbCutterList.Controls.Add(this.btnCutterEdit);
            this.grpbCutterList.Controls.Add(this.dgvCutter);
            this.grpbCutterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCutterList.Location = new System.Drawing.Point(0, 0);
            this.grpbCutterList.Name = "grpbCutterList";
            this.grpbCutterList.Size = new System.Drawing.Size(666, 253);
            this.grpbCutterList.TabIndex = 0;
            this.grpbCutterList.TabStop = false;
            // 
            // btnCutterDelete
            // 
            this.btnCutterDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCutterDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutterDelete.Location = new System.Drawing.Point(630, 221);
            this.btnCutterDelete.Name = "btnCutterDelete";
            this.btnCutterDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCutterDelete.TabIndex = 41;
            this.btnCutterDelete.UseVisualStyleBackColor = true;
            // 
            // btnCutterAdd
            // 
            this.btnCutterAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCutterAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutterAdd.Location = new System.Drawing.Point(578, 221);
            this.btnCutterAdd.Name = "btnCutterAdd";
            this.btnCutterAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCutterAdd.TabIndex = 39;
            this.btnCutterAdd.UseVisualStyleBackColor = true;
            this.btnCutterAdd.Click += new System.EventHandler(this.btnCutterAdd_Click);
            // 
            // btnCutterEdit
            // 
            this.btnCutterEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCutterEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutterEdit.Location = new System.Drawing.Point(604, 221);
            this.btnCutterEdit.Name = "btnCutterEdit";
            this.btnCutterEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCutterEdit.TabIndex = 40;
            this.btnCutterEdit.UseVisualStyleBackColor = true;
            this.btnCutterEdit.Click += new System.EventHandler(this.btnCutterEdit_Click);
            // 
            // dgvCutter
            // 
            this.dgvCutter.AllowUserToAddRows = false;
            this.dgvCutter.AllowUserToDeleteRows = false;
            this.dgvCutter.AllowUserToOrderColumns = true;
            this.dgvCutter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCutter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCutterCodsec,
            this.clmCutterName,
            this.clmCutterArms,
            this.clmCutterUtilWidth,
            this.clmCutterMaxVelocity,
            this.clmCutterPlant,
            this.clmCutterProductionLine,
            this.clmCutterSector,
            this.clmCutterStatus});
            this.dgvCutter.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCutter.Location = new System.Drawing.Point(3, 17);
            this.dgvCutter.Name = "dgvCutter";
            this.dgvCutter.ReadOnly = true;
            this.dgvCutter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCutter.Size = new System.Drawing.Size(660, 198);
            this.dgvCutter.TabIndex = 0;
            // 
            // clmCutterCodsec
            // 
            this.clmCutterCodsec.HeaderText = "Codsec";
            this.clmCutterCodsec.Name = "clmCutterCodsec";
            this.clmCutterCodsec.ReadOnly = true;
            this.clmCutterCodsec.Visible = false;
            // 
            // clmCutterName
            // 
            this.clmCutterName.HeaderText = "Nombre";
            this.clmCutterName.Name = "clmCutterName";
            this.clmCutterName.ReadOnly = true;
            this.clmCutterName.Width = 150;
            // 
            // clmCutterArms
            // 
            this.clmCutterArms.HeaderText = "Brazos";
            this.clmCutterArms.Name = "clmCutterArms";
            this.clmCutterArms.ReadOnly = true;
            this.clmCutterArms.Width = 90;
            // 
            // clmCutterUtilWidth
            // 
            this.clmCutterUtilWidth.HeaderText = "Ancho Util";
            this.clmCutterUtilWidth.Name = "clmCutterUtilWidth";
            this.clmCutterUtilWidth.ReadOnly = true;
            this.clmCutterUtilWidth.Width = 90;
            // 
            // clmCutterMaxVelocity
            // 
            this.clmCutterMaxVelocity.HeaderText = "Velocidad Máxima";
            this.clmCutterMaxVelocity.Name = "clmCutterMaxVelocity";
            this.clmCutterMaxVelocity.ReadOnly = true;
            // 
            // clmCutterPlant
            // 
            this.clmCutterPlant.HeaderText = "Planta";
            this.clmCutterPlant.Name = "clmCutterPlant";
            this.clmCutterPlant.ReadOnly = true;
            this.clmCutterPlant.Width = 120;
            // 
            // clmCutterProductionLine
            // 
            this.clmCutterProductionLine.HeaderText = "Línea";
            this.clmCutterProductionLine.Name = "clmCutterProductionLine";
            this.clmCutterProductionLine.ReadOnly = true;
            // 
            // clmCutterSector
            // 
            this.clmCutterSector.HeaderText = "Sector";
            this.clmCutterSector.Name = "clmCutterSector";
            this.clmCutterSector.ReadOnly = true;
            this.clmCutterSector.Width = 120;
            // 
            // clmCutterStatus
            // 
            this.clmCutterStatus.HeaderText = "Estado";
            this.clmCutterStatus.Name = "clmCutterStatus";
            this.clmCutterStatus.ReadOnly = true;
            this.clmCutterStatus.Width = 150;
            // 
            // pnlCompany
            // 
            this.pnlCompany.Controls.Add(this.tctrlCompany);
            this.pnlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(666, 524);
            this.pnlCompany.TabIndex = 0;
            // 
            // tctrlCompany
            // 
            this.tctrlCompany.Controls.Add(this.tabPage1);
            this.tctrlCompany.Controls.Add(this.tabPage2);
            this.tctrlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlCompany.Location = new System.Drawing.Point(0, 0);
            this.tctrlCompany.Name = "tctrlCompany";
            this.tctrlCompany.SelectedIndex = 0;
            this.tctrlCompany.Size = new System.Drawing.Size(666, 524);
            this.tctrlCompany.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.grpbCompanyInfo);
            this.tabPage1.Controls.Add(this.btnSaveCompany);
            this.tabPage1.Controls.Add(this.btnEditCompany);
            this.tabPage1.Controls.Add(this.btnCancelCompany);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información";
            // 
            // grpbCompanyInfo
            // 
            this.grpbCompanyInfo.Controls.Add(this.cmbCurrencyMoney);
            this.grpbCompanyInfo.Controls.Add(this.cmbCountryCompany);
            this.grpbCompanyInfo.Controls.Add(this.rdoDistrib);
            this.grpbCompanyInfo.Controls.Add(this.rdoPlant);
            this.grpbCompanyInfo.Controls.Add(this.txtDescriptionCompany);
            this.grpbCompanyInfo.Controls.Add(this.txtNameCompany);
            this.grpbCompanyInfo.Controls.Add(this.label8);
            this.grpbCompanyInfo.Controls.Add(this.lblCmpDescription);
            this.grpbCompanyInfo.Controls.Add(this.lblCmyCountry);
            this.grpbCompanyInfo.Controls.Add(this.lblCmpName);
            this.grpbCompanyInfo.Enabled = false;
            this.grpbCompanyInfo.Location = new System.Drawing.Point(11, 13);
            this.grpbCompanyInfo.Name = "grpbCompanyInfo";
            this.grpbCompanyInfo.Size = new System.Drawing.Size(635, 336);
            this.grpbCompanyInfo.TabIndex = 21;
            this.grpbCompanyInfo.TabStop = false;
            // 
            // cmbCurrencyMoney
            // 
            this.cmbCurrencyMoney.FormattingEnabled = true;
            this.cmbCurrencyMoney.Location = new System.Drawing.Point(365, 253);
            this.cmbCurrencyMoney.Name = "cmbCurrencyMoney";
            this.cmbCurrencyMoney.Size = new System.Drawing.Size(121, 23);
            this.cmbCurrencyMoney.TabIndex = 27;
            // 
            // cmbCountryCompany
            // 
            this.cmbCountryCompany.FormattingEnabled = true;
            this.cmbCountryCompany.Location = new System.Drawing.Point(86, 253);
            this.cmbCountryCompany.Name = "cmbCountryCompany";
            this.cmbCountryCompany.Size = new System.Drawing.Size(121, 23);
            this.cmbCountryCompany.TabIndex = 26;
            // 
            // rdoDistrib
            // 
            this.rdoDistrib.AutoSize = true;
            this.rdoDistrib.Location = new System.Drawing.Point(316, 209);
            this.rdoDistrib.Name = "rdoDistrib";
            this.rdoDistrib.Size = new System.Drawing.Size(83, 17);
            this.rdoDistrib.TabIndex = 25;
            this.rdoDistrib.TabStop = true;
            this.rdoDistrib.Text = "Distribuidora";
            this.rdoDistrib.UseVisualStyleBackColor = true;
            // 
            // rdoPlant
            // 
            this.rdoPlant.AutoSize = true;
            this.rdoPlant.Location = new System.Drawing.Point(124, 209);
            this.rdoPlant.Name = "rdoPlant";
            this.rdoPlant.Size = new System.Drawing.Size(55, 17);
            this.rdoPlant.TabIndex = 24;
            this.rdoPlant.TabStop = true;
            this.rdoPlant.Text = "Planta";
            this.rdoPlant.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionCompany
            // 
            this.txtDescriptionCompany.Location = new System.Drawing.Point(8, 96);
            this.txtDescriptionCompany.Multiline = true;
            this.txtDescriptionCompany.Name = "txtDescriptionCompany";
            this.txtDescriptionCompany.Size = new System.Drawing.Size(524, 96);
            this.txtDescriptionCompany.TabIndex = 23;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.Location = new System.Drawing.Point(8, 49);
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.Size = new System.Drawing.Size(524, 21);
            this.txtNameCompany.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Moneda";
            // 
            // lblCmpDescription
            // 
            this.lblCmpDescription.AutoSize = true;
            this.lblCmpDescription.Location = new System.Drawing.Point(5, 78);
            this.lblCmpDescription.Name = "lblCmpDescription";
            this.lblCmpDescription.Size = new System.Drawing.Size(72, 15);
            this.lblCmpDescription.TabIndex = 20;
            this.lblCmpDescription.Text = "Descripción";
            // 
            // lblCmyCountry
            // 
            this.lblCmyCountry.AutoSize = true;
            this.lblCmyCountry.Location = new System.Drawing.Point(49, 256);
            this.lblCmyCountry.Name = "lblCmyCountry";
            this.lblCmyCountry.Size = new System.Drawing.Size(31, 15);
            this.lblCmyCountry.TabIndex = 19;
            this.lblCmyCountry.Text = "País";
            // 
            // lblCmpName
            // 
            this.lblCmpName.AutoSize = true;
            this.lblCmpName.Location = new System.Drawing.Point(5, 31);
            this.lblCmpName.Name = "lblCmpName";
            this.lblCmpName.Size = new System.Drawing.Size(52, 15);
            this.lblCmpName.TabIndex = 18;
            this.lblCmpName.Text = "Nombre";
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCompany.BackgroundImage")));
            this.btnSaveCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveCompany.Location = new System.Drawing.Point(596, 464);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(25, 25);
            this.btnSaveCompany.TabIndex = 19;
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(571, 464);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 18;
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnCancelCompany
            // 
            this.btnCancelCompany.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelCompany.Enabled = false;
            this.btnCancelCompany.Location = new System.Drawing.Point(621, 464);
            this.btnCancelCompany.Name = "btnCancelCompany";
            this.btnCancelCompany.Size = new System.Drawing.Size(25, 25);
            this.btnCancelCompany.TabIndex = 20;
            this.btnCancelCompany.UseVisualStyleBackColor = true;
            this.btnCancelCompany.Click += new System.EventHandler(this.btnCancelCompany_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnCompanyAddressSave);
            this.tabPage2.Controls.Add(this.btnCompanyAddressEdit);
            this.tabPage2.Controls.Add(this.btnCompanyAddressCancel);
            this.tabPage2.Controls.Add(this.grpbAddressList);
            this.tabPage2.Controls.Add(this.grpbAddressInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Direcciones";
            // 
            // btnCompanyAddressSave
            // 
            this.btnCompanyAddressSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompanyAddressSave.BackgroundImage")));
            this.btnCompanyAddressSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompanyAddressSave.Location = new System.Drawing.Point(594, 461);
            this.btnCompanyAddressSave.Name = "btnCompanyAddressSave";
            this.btnCompanyAddressSave.Size = new System.Drawing.Size(25, 25);
            this.btnCompanyAddressSave.TabIndex = 13;
            this.btnCompanyAddressSave.UseVisualStyleBackColor = true;
            this.btnCompanyAddressSave.Click += new System.EventHandler(this.btnCompanyAddressSave_Click);
            // 
            // btnCompanyAddressEdit
            // 
            this.btnCompanyAddressEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCompanyAddressEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompanyAddressEdit.Location = new System.Drawing.Point(569, 461);
            this.btnCompanyAddressEdit.Name = "btnCompanyAddressEdit";
            this.btnCompanyAddressEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCompanyAddressEdit.TabIndex = 15;
            this.btnCompanyAddressEdit.UseVisualStyleBackColor = true;
            // 
            // btnCompanyAddressCancel
            // 
            this.btnCompanyAddressCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCompanyAddressCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompanyAddressCancel.Enabled = false;
            this.btnCompanyAddressCancel.Location = new System.Drawing.Point(619, 461);
            this.btnCompanyAddressCancel.Name = "btnCompanyAddressCancel";
            this.btnCompanyAddressCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCompanyAddressCancel.TabIndex = 14;
            this.btnCompanyAddressCancel.UseVisualStyleBackColor = true;
            // 
            // grpbAddressList
            // 
            this.grpbAddressList.Controls.Add(this.dgvCompanyAddress);
            this.grpbAddressList.Location = new System.Drawing.Point(3, 3);
            this.grpbAddressList.Name = "grpbAddressList";
            this.grpbAddressList.Size = new System.Drawing.Size(641, 175);
            this.grpbAddressList.TabIndex = 0;
            this.grpbAddressList.TabStop = false;
            this.grpbAddressList.Text = "Registro de direcciones";
            // 
            // dgvCompanyAddress
            // 
            this.dgvCompanyAddress.AllowUserToAddRows = false;
            this.dgvCompanyAddress.AllowUserToDeleteRows = false;
            this.dgvCompanyAddress.AllowUserToOrderColumns = true;
            this.dgvCompanyAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsDefault,
            this.clmName,
            this.clmCity,
            this.clmAddress});
            this.dgvCompanyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompanyAddress.Location = new System.Drawing.Point(3, 17);
            this.dgvCompanyAddress.Name = "dgvCompanyAddress";
            this.dgvCompanyAddress.ReadOnly = true;
            this.dgvCompanyAddress.Size = new System.Drawing.Size(635, 155);
            this.dgvCompanyAddress.TabIndex = 0;
            // 
            // IsDefault
            // 
            this.IsDefault.HeaderText = "";
            this.IsDefault.Name = "IsDefault";
            this.IsDefault.ReadOnly = true;
            this.IsDefault.Width = 30;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "Ciudad";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            this.clmCity.Width = 150;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Dirección";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 300;
            // 
            // grpbAddressInfo
            // 
            this.grpbAddressInfo.Controls.Add(this.label15);
            this.grpbAddressInfo.Controls.Add(this.label14);
            this.grpbAddressInfo.Controls.Add(this.cmbCompanyCity);
            this.grpbAddressInfo.Controls.Add(this.cmbCompanyCountry);
            this.grpbAddressInfo.Controls.Add(this.cmbCompanyState);
            this.grpbAddressInfo.Controls.Add(this.label9);
            this.grpbAddressInfo.Controls.Add(this.chkIsDefaultAddress);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyFax);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyEmail);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyZip);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyPhone2);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyPhone);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyAddress);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyContact);
            this.grpbAddressInfo.Controls.Add(this.txtCompanyName);
            this.grpbAddressInfo.Controls.Add(this.label13);
            this.grpbAddressInfo.Controls.Add(this.label12);
            this.grpbAddressInfo.Controls.Add(this.label11);
            this.grpbAddressInfo.Controls.Add(this.label10);
            this.grpbAddressInfo.Controls.Add(this.label7);
            this.grpbAddressInfo.Controls.Add(this.label6);
            this.grpbAddressInfo.Controls.Add(this.label5);
            this.grpbAddressInfo.Location = new System.Drawing.Point(3, 182);
            this.grpbAddressInfo.Name = "grpbAddressInfo";
            this.grpbAddressInfo.Size = new System.Drawing.Size(638, 271);
            this.grpbAddressInfo.TabIndex = 1;
            this.grpbAddressInfo.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ciudad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Estado";
            // 
            // cmbCompanyCity
            // 
            this.cmbCompanyCity.FormattingEnabled = true;
            this.cmbCompanyCity.Location = new System.Drawing.Point(430, 47);
            this.cmbCompanyCity.Name = "cmbCompanyCity";
            this.cmbCompanyCity.Size = new System.Drawing.Size(116, 23);
            this.cmbCompanyCity.TabIndex = 5;
            // 
            // cmbCompanyCountry
            // 
            this.cmbCompanyCountry.FormattingEnabled = true;
            this.cmbCompanyCountry.Location = new System.Drawing.Point(69, 47);
            this.cmbCompanyCountry.Name = "cmbCompanyCountry";
            this.cmbCompanyCountry.Size = new System.Drawing.Size(116, 23);
            this.cmbCompanyCountry.TabIndex = 3;
            this.cmbCompanyCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyCountry_SelectedIndexChanged);
            // 
            // cmbCompanyState
            // 
            this.cmbCompanyState.FormattingEnabled = true;
            this.cmbCompanyState.Location = new System.Drawing.Point(247, 47);
            this.cmbCompanyState.Name = "cmbCompanyState";
            this.cmbCompanyState.Size = new System.Drawing.Size(116, 23);
            this.cmbCompanyState.TabIndex = 4;
            this.cmbCompanyState.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyState_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "País";
            // 
            // chkIsDefaultAddress
            // 
            this.chkIsDefaultAddress.AutoSize = true;
            this.chkIsDefaultAddress.Location = new System.Drawing.Point(69, 172);
            this.chkIsDefaultAddress.Name = "chkIsDefaultAddress";
            this.chkIsDefaultAddress.Size = new System.Drawing.Size(113, 17);
            this.chkIsDefaultAddress.TabIndex = 12;
            this.chkIsDefaultAddress.Text = "Dirección principal";
            this.chkIsDefaultAddress.UseVisualStyleBackColor = true;
            // 
            // txtCompanyFax
            // 
            this.txtCompanyFax.Location = new System.Drawing.Point(393, 110);
            this.txtCompanyFax.Name = "txtCompanyFax";
            this.txtCompanyFax.Size = new System.Drawing.Size(153, 21);
            this.txtCompanyFax.TabIndex = 9;
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Location = new System.Drawing.Point(69, 144);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(293, 21);
            this.txtCompanyEmail.TabIndex = 10;
            // 
            // txtCompanyZip
            // 
            this.txtCompanyZip.Location = new System.Drawing.Point(393, 144);
            this.txtCompanyZip.Name = "txtCompanyZip";
            this.txtCompanyZip.Size = new System.Drawing.Size(153, 21);
            this.txtCompanyZip.TabIndex = 11;
            // 
            // txtCompanyPhone2
            // 
            this.txtCompanyPhone2.Location = new System.Drawing.Point(217, 111);
            this.txtCompanyPhone2.Name = "txtCompanyPhone2";
            this.txtCompanyPhone2.Size = new System.Drawing.Size(142, 21);
            this.txtCompanyPhone2.TabIndex = 8;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(69, 111);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(142, 21);
            this.txtCompanyPhone.TabIndex = 7;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(69, 80);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(477, 21);
            this.txtCompanyAddress.TabIndex = 6;
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.Location = new System.Drawing.Point(352, 16);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.Size = new System.Drawing.Size(194, 21);
            this.txtCompanyContact.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(69, 16);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(194, 21);
            this.txtCompanyName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Fax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dirección";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Zip";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teléfonos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.grpbUserForm);
            this.pnlUser.Controls.Add(this.grpbUserList);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(666, 524);
            this.pnlUser.TabIndex = 1;
            // 
            // grpbUserForm
            // 
            this.grpbUserForm.Controls.Add(this.cmbUserStatus);
            this.grpbUserForm.Controls.Add(this.lblUserStatus);
            this.grpbUserForm.Controls.Add(this.chbxPasswordChange);
            this.grpbUserForm.Controls.Add(this.btnUserCancel);
            this.grpbUserForm.Controls.Add(this.btnUserSave);
            this.grpbUserForm.Controls.Add(this.cmbUserRole);
            this.grpbUserForm.Controls.Add(this.cmbUserInning);
            this.grpbUserForm.Controls.Add(this.lblUserRole);
            this.grpbUserForm.Controls.Add(this.lblUserInning);
            this.grpbUserForm.Controls.Add(this.txtUserPassword);
            this.grpbUserForm.Controls.Add(this.txtUserUserName);
            this.grpbUserForm.Controls.Add(this.txtUserLastName);
            this.grpbUserForm.Controls.Add(this.txtUserName);
            this.grpbUserForm.Controls.Add(this.lblUserPassword);
            this.grpbUserForm.Controls.Add(this.lblUserUserName);
            this.grpbUserForm.Controls.Add(this.lblUserLastName);
            this.grpbUserForm.Controls.Add(this.lblUserName);
            this.grpbUserForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbUserForm.Location = new System.Drawing.Point(0, 247);
            this.grpbUserForm.Name = "grpbUserForm";
            this.grpbUserForm.Size = new System.Drawing.Size(666, 274);
            this.grpbUserForm.TabIndex = 1;
            this.grpbUserForm.TabStop = false;
            // 
            // cmbUserStatus
            // 
            this.cmbUserStatus.FormattingEnabled = true;
            this.cmbUserStatus.Location = new System.Drawing.Point(347, 100);
            this.cmbUserStatus.Name = "cmbUserStatus";
            this.cmbUserStatus.Size = new System.Drawing.Size(130, 23);
            this.cmbUserStatus.TabIndex = 41;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(290, 103);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(45, 15);
            this.lblUserStatus.TabIndex = 40;
            this.lblUserStatus.Text = "Estado";
            // 
            // chbxPasswordChange
            // 
            this.chbxPasswordChange.AutoSize = true;
            this.chbxPasswordChange.Location = new System.Drawing.Point(246, 142);
            this.chbxPasswordChange.Name = "chbxPasswordChange";
            this.chbxPasswordChange.Size = new System.Drawing.Size(121, 17);
            this.chbxPasswordChange.TabIndex = 39;
            this.chbxPasswordChange.Text = "Cambiar Contraseña";
            this.chbxPasswordChange.UseVisualStyleBackColor = true;
            this.chbxPasswordChange.CheckedChanged += new System.EventHandler(this.chbxPasswordChange_CheckedChanged);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserCancel.BackgroundImage")));
            this.btnUserCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserCancel.Location = new System.Drawing.Point(632, 241);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(25, 25);
            this.btnUserCancel.TabIndex = 38;
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserSave.BackgroundImage")));
            this.btnUserSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserSave.Location = new System.Drawing.Point(607, 241);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(25, 25);
            this.btnUserSave.TabIndex = 37;
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(347, 63);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(130, 23);
            this.cmbUserRole.TabIndex = 11;
            // 
            // cmbUserInning
            // 
            this.cmbUserInning.FormattingEnabled = true;
            this.cmbUserInning.Location = new System.Drawing.Point(347, 25);
            this.cmbUserInning.Name = "cmbUserInning";
            this.cmbUserInning.Size = new System.Drawing.Size(130, 23);
            this.cmbUserInning.TabIndex = 10;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(290, 67);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(26, 15);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "Rol";
            // 
            // lblUserInning
            // 
            this.lblUserInning.AutoSize = true;
            this.lblUserInning.Location = new System.Drawing.Point(290, 28);
            this.lblUserInning.Name = "lblUserInning";
            this.lblUserInning.Size = new System.Drawing.Size(39, 15);
            this.lblUserInning.TabIndex = 8;
            this.lblUserInning.Text = "Turno";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(79, 140);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(150, 21);
            this.txtUserPassword.TabIndex = 7;
            // 
            // txtUserUserName
            // 
            this.txtUserUserName.Location = new System.Drawing.Point(79, 104);
            this.txtUserUserName.Name = "txtUserUserName";
            this.txtUserUserName.Size = new System.Drawing.Size(150, 21);
            this.txtUserUserName.TabIndex = 6;
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(79, 64);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(200, 21);
            this.txtUserLastName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 24);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(3, 143);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(70, 15);
            this.lblUserPassword.TabIndex = 3;
            this.lblUserPassword.Text = "Contraseña";
            // 
            // lblUserUserName
            // 
            this.lblUserUserName.AutoSize = true;
            this.lblUserUserName.Location = new System.Drawing.Point(3, 107);
            this.lblUserUserName.Name = "lblUserUserName";
            this.lblUserUserName.Size = new System.Drawing.Size(50, 15);
            this.lblUserUserName.TabIndex = 2;
            this.lblUserUserName.Text = "Usuario";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Location = new System.Drawing.Point(3, 67);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(51, 15);
            this.lblUserLastName.TabIndex = 1;
            this.lblUserLastName.Text = "Apellido";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nombre";
            // 
            // grpbUserList
            // 
            this.grpbUserList.Controls.Add(this.btnUserAdd);
            this.grpbUserList.Controls.Add(this.btnUserEdit);
            this.grpbUserList.Controls.Add(this.btnUserDelete);
            this.grpbUserList.Controls.Add(this.dgvUser);
            this.grpbUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbUserList.Location = new System.Drawing.Point(0, 0);
            this.grpbUserList.Name = "grpbUserList";
            this.grpbUserList.Size = new System.Drawing.Size(666, 247);
            this.grpbUserList.TabIndex = 0;
            this.grpbUserList.TabStop = false;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserAdd.Location = new System.Drawing.Point(582, 218);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(25, 25);
            this.btnUserAdd.TabIndex = 30;
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnUserEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserEdit.Location = new System.Drawing.Point(608, 218);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(25, 25);
            this.btnUserEdit.TabIndex = 28;
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserDelete.Location = new System.Drawing.Point(634, 218);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(25, 25);
            this.btnUserDelete.TabIndex = 29;
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserCodsec,
            this.clmUserName,
            this.clmUserLastName,
            this.clmUserUserName,
            this.clmUserRole,
            this.clmUserInningName,
            this.clmUserStatus,
            this.clmUserCreatedDate,
            this.clmUserCreatorUser,
            this.clmUserModificatorDate,
            this.clmUserModificatorUser});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUser.Location = new System.Drawing.Point(3, 17);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(660, 198);
            this.dgvUser.TabIndex = 0;
            // 
            // clmUserCodsec
            // 
            this.clmUserCodsec.HeaderText = "Codsec";
            this.clmUserCodsec.Name = "clmUserCodsec";
            this.clmUserCodsec.ReadOnly = true;
            this.clmUserCodsec.Visible = false;
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "Nombre";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmUserLastName
            // 
            this.clmUserLastName.HeaderText = "Apellido";
            this.clmUserLastName.Name = "clmUserLastName";
            this.clmUserLastName.ReadOnly = true;
            // 
            // clmUserUserName
            // 
            this.clmUserUserName.HeaderText = "Usuario";
            this.clmUserUserName.Name = "clmUserUserName";
            this.clmUserUserName.ReadOnly = true;
            // 
            // clmUserRole
            // 
            this.clmUserRole.HeaderText = "Rol";
            this.clmUserRole.Name = "clmUserRole";
            this.clmUserRole.ReadOnly = true;
            // 
            // clmUserInningName
            // 
            this.clmUserInningName.HeaderText = "Turno";
            this.clmUserInningName.Name = "clmUserInningName";
            this.clmUserInningName.ReadOnly = true;
            // 
            // clmUserStatus
            // 
            this.clmUserStatus.HeaderText = "Estado";
            this.clmUserStatus.Name = "clmUserStatus";
            this.clmUserStatus.ReadOnly = true;
            // 
            // clmUserCreatedDate
            // 
            this.clmUserCreatedDate.HeaderText = "Fecha Creacion";
            this.clmUserCreatedDate.Name = "clmUserCreatedDate";
            this.clmUserCreatedDate.ReadOnly = true;
            // 
            // clmUserCreatorUser
            // 
            this.clmUserCreatorUser.HeaderText = "Creado Por";
            this.clmUserCreatorUser.Name = "clmUserCreatorUser";
            this.clmUserCreatorUser.ReadOnly = true;
            // 
            // clmUserModificatorDate
            // 
            this.clmUserModificatorDate.HeaderText = "Fecha Modificacion";
            this.clmUserModificatorDate.Name = "clmUserModificatorDate";
            this.clmUserModificatorDate.ReadOnly = true;
            // 
            // clmUserModificatorUser
            // 
            this.clmUserModificatorUser.HeaderText = "Modificado por";
            this.clmUserModificatorUser.Name = "clmUserModificatorUser";
            this.clmUserModificatorUser.ReadOnly = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.btnStatusDelete);
            this.pnlStatus.Controls.Add(this.btnStatusAdd);
            this.pnlStatus.Controls.Add(this.btnStatusEdit);
            this.pnlStatus.Controls.Add(this.grpbStatusForm);
            this.pnlStatus.Controls.Add(this.grpbStatusList);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(666, 524);
            this.pnlStatus.TabIndex = 1;
            // 
            // btnStatusDelete
            // 
            this.btnStatusDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnStatusDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusDelete.Location = new System.Drawing.Point(630, 221);
            this.btnStatusDelete.Name = "btnStatusDelete";
            this.btnStatusDelete.Size = new System.Drawing.Size(25, 25);
            this.btnStatusDelete.TabIndex = 38;
            this.btnStatusDelete.UseVisualStyleBackColor = true;
            // 
            // btnStatusAdd
            // 
            this.btnStatusAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnStatusAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusAdd.Location = new System.Drawing.Point(578, 221);
            this.btnStatusAdd.Name = "btnStatusAdd";
            this.btnStatusAdd.Size = new System.Drawing.Size(25, 25);
            this.btnStatusAdd.TabIndex = 36;
            this.btnStatusAdd.UseVisualStyleBackColor = true;
            this.btnStatusAdd.Click += new System.EventHandler(this.btnStatusAdd_Click);
            // 
            // btnStatusEdit
            // 
            this.btnStatusEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnStatusEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusEdit.Location = new System.Drawing.Point(604, 221);
            this.btnStatusEdit.Name = "btnStatusEdit";
            this.btnStatusEdit.Size = new System.Drawing.Size(25, 25);
            this.btnStatusEdit.TabIndex = 37;
            this.btnStatusEdit.UseVisualStyleBackColor = true;
            this.btnStatusEdit.Click += new System.EventHandler(this.btnStatusEdit_Click);
            // 
            // grpbStatusForm
            // 
            this.grpbStatusForm.Controls.Add(this.btnStatusCancel);
            this.grpbStatusForm.Controls.Add(this.txtStatusDescription);
            this.grpbStatusForm.Controls.Add(this.btnStatusSave);
            this.grpbStatusForm.Controls.Add(this.lblStatusDescription);
            this.grpbStatusForm.Controls.Add(this.cmbStatusGroup);
            this.grpbStatusForm.Controls.Add(this.lblStatusGroup);
            this.grpbStatusForm.Controls.Add(this.txtStatusName);
            this.grpbStatusForm.Controls.Add(this.lblStatusName);
            this.grpbStatusForm.Location = new System.Drawing.Point(3, 253);
            this.grpbStatusForm.Name = "grpbStatusForm";
            this.grpbStatusForm.Size = new System.Drawing.Size(660, 268);
            this.grpbStatusForm.TabIndex = 1;
            this.grpbStatusForm.TabStop = false;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnStatusCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusCancel.Location = new System.Drawing.Point(627, 235);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(25, 25);
            this.btnStatusCancel.TabIndex = 5;
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // txtStatusDescription
            // 
            this.txtStatusDescription.Location = new System.Drawing.Point(95, 106);
            this.txtStatusDescription.Name = "txtStatusDescription";
            this.txtStatusDescription.Size = new System.Drawing.Size(380, 21);
            this.txtStatusDescription.TabIndex = 3;
            // 
            // btnStatusSave
            // 
            this.btnStatusSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatusSave.BackgroundImage")));
            this.btnStatusSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatusSave.Location = new System.Drawing.Point(602, 235);
            this.btnStatusSave.Name = "btnStatusSave";
            this.btnStatusSave.Size = new System.Drawing.Size(25, 25);
            this.btnStatusSave.TabIndex = 4;
            this.btnStatusSave.UseVisualStyleBackColor = true;
            this.btnStatusSave.Click += new System.EventHandler(this.btnStatusSave_Click);
            // 
            // lblStatusDescription
            // 
            this.lblStatusDescription.AutoSize = true;
            this.lblStatusDescription.Location = new System.Drawing.Point(3, 109);
            this.lblStatusDescription.Name = "lblStatusDescription";
            this.lblStatusDescription.Size = new System.Drawing.Size(72, 15);
            this.lblStatusDescription.TabIndex = 3;
            this.lblStatusDescription.Text = "Descripción";
            // 
            // cmbStatusGroup
            // 
            this.cmbStatusGroup.FormattingEnabled = true;
            this.cmbStatusGroup.Location = new System.Drawing.Point(95, 63);
            this.cmbStatusGroup.Name = "cmbStatusGroup";
            this.cmbStatusGroup.Size = new System.Drawing.Size(121, 23);
            this.cmbStatusGroup.TabIndex = 2;
            // 
            // lblStatusGroup
            // 
            this.lblStatusGroup.AutoSize = true;
            this.lblStatusGroup.Location = new System.Drawing.Point(3, 68);
            this.lblStatusGroup.Name = "lblStatusGroup";
            this.lblStatusGroup.Size = new System.Drawing.Size(82, 15);
            this.lblStatusGroup.TabIndex = 2;
            this.lblStatusGroup.Text = "Grupo Estado";
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(95, 24);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(450, 21);
            this.txtStatusName.TabIndex = 1;
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.Location = new System.Drawing.Point(3, 27);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(52, 15);
            this.lblStatusName.TabIndex = 0;
            this.lblStatusName.Text = "Nombre";
            // 
            // grpbStatusList
            // 
            this.grpbStatusList.Controls.Add(this.dgvStatus);
            this.grpbStatusList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStatusList.Location = new System.Drawing.Point(0, 0);
            this.grpbStatusList.Name = "grpbStatusList";
            this.grpbStatusList.Size = new System.Drawing.Size(666, 253);
            this.grpbStatusList.TabIndex = 0;
            this.grpbStatusList.TabStop = false;
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.AllowUserToOrderColumns = true;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStatusCodsec,
            this.clmStatusName,
            this.clmStatusStatusGroup,
            this.clmStatusDescription,
            this.clmStatusCreatedDate,
            this.clmStatusUserCreator,
            this.clmStatusModifiedDate,
            this.clmStatusModificatorUser});
            this.dgvStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStatus.Location = new System.Drawing.Point(3, 17);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(660, 198);
            this.dgvStatus.TabIndex = 0;
            // 
            // clmStatusCodsec
            // 
            this.clmStatusCodsec.HeaderText = "Codsec";
            this.clmStatusCodsec.Name = "clmStatusCodsec";
            this.clmStatusCodsec.ReadOnly = true;
            this.clmStatusCodsec.Visible = false;
            // 
            // clmStatusName
            // 
            this.clmStatusName.HeaderText = "Nombre";
            this.clmStatusName.Name = "clmStatusName";
            this.clmStatusName.ReadOnly = true;
            // 
            // clmStatusStatusGroup
            // 
            this.clmStatusStatusGroup.HeaderText = "Grupo Estados";
            this.clmStatusStatusGroup.Name = "clmStatusStatusGroup";
            this.clmStatusStatusGroup.ReadOnly = true;
            // 
            // clmStatusDescription
            // 
            this.clmStatusDescription.HeaderText = "Descripción";
            this.clmStatusDescription.Name = "clmStatusDescription";
            this.clmStatusDescription.ReadOnly = true;
            // 
            // clmStatusCreatedDate
            // 
            this.clmStatusCreatedDate.HeaderText = "Fecha Creacion";
            this.clmStatusCreatedDate.Name = "clmStatusCreatedDate";
            this.clmStatusCreatedDate.ReadOnly = true;
            // 
            // clmStatusUserCreator
            // 
            this.clmStatusUserCreator.HeaderText = "Creado Por";
            this.clmStatusUserCreator.Name = "clmStatusUserCreator";
            this.clmStatusUserCreator.ReadOnly = true;
            // 
            // clmStatusModifiedDate
            // 
            this.clmStatusModifiedDate.HeaderText = "Fecha Modificado";
            this.clmStatusModifiedDate.Name = "clmStatusModifiedDate";
            this.clmStatusModifiedDate.ReadOnly = true;
            // 
            // clmStatusModificatorUser
            // 
            this.clmStatusModificatorUser.HeaderText = "Modificado por";
            this.clmStatusModificatorUser.Name = "clmStatusModificatorUser";
            this.clmStatusModificatorUser.ReadOnly = true;
            // 
            // pnlRawMaterialType
            // 
            this.pnlRawMaterialType.Controls.Add(this.grpbRawMaterialTypeForm);
            this.pnlRawMaterialType.Controls.Add(this.grpbRawMaterialTypeList);
            this.pnlRawMaterialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRawMaterialType.Location = new System.Drawing.Point(0, 0);
            this.pnlRawMaterialType.Name = "pnlRawMaterialType";
            this.pnlRawMaterialType.Size = new System.Drawing.Size(666, 524);
            this.pnlRawMaterialType.TabIndex = 1;
            // 
            // grpbRawMaterialTypeForm
            // 
            this.grpbRawMaterialTypeForm.Controls.Add(this.btnRawMaterialTypeCancel);
            this.grpbRawMaterialTypeForm.Controls.Add(this.btnRawMaterialTypeSave);
            this.grpbRawMaterialTypeForm.Controls.Add(this.txtRawMaterialTypeName);
            this.grpbRawMaterialTypeForm.Controls.Add(this.lblRawMaterialTypeName);
            this.grpbRawMaterialTypeForm.Location = new System.Drawing.Point(3, 253);
            this.grpbRawMaterialTypeForm.Name = "grpbRawMaterialTypeForm";
            this.grpbRawMaterialTypeForm.Size = new System.Drawing.Size(659, 265);
            this.grpbRawMaterialTypeForm.TabIndex = 1;
            this.grpbRawMaterialTypeForm.TabStop = false;
            // 
            // btnRawMaterialTypeCancel
            // 
            this.btnRawMaterialTypeCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialTypeCancel.BackgroundImage")));
            this.btnRawMaterialTypeCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialTypeCancel.Location = new System.Drawing.Point(628, 233);
            this.btnRawMaterialTypeCancel.Name = "btnRawMaterialTypeCancel";
            this.btnRawMaterialTypeCancel.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialTypeCancel.TabIndex = 3;
            this.btnRawMaterialTypeCancel.UseVisualStyleBackColor = true;
            this.btnRawMaterialTypeCancel.Click += new System.EventHandler(this.btnRawMaterialTypeCancel_Click);
            // 
            // btnRawMaterialTypeSave
            // 
            this.btnRawMaterialTypeSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRawMaterialTypeSave.BackgroundImage")));
            this.btnRawMaterialTypeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialTypeSave.Location = new System.Drawing.Point(603, 233);
            this.btnRawMaterialTypeSave.Name = "btnRawMaterialTypeSave";
            this.btnRawMaterialTypeSave.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialTypeSave.TabIndex = 2;
            this.btnRawMaterialTypeSave.UseVisualStyleBackColor = true;
            this.btnRawMaterialTypeSave.Click += new System.EventHandler(this.btnRawMaterialTypeSave_Click);
            // 
            // txtRawMaterialTypeName
            // 
            this.txtRawMaterialTypeName.Location = new System.Drawing.Point(79, 48);
            this.txtRawMaterialTypeName.Name = "txtRawMaterialTypeName";
            this.txtRawMaterialTypeName.Size = new System.Drawing.Size(300, 21);
            this.txtRawMaterialTypeName.TabIndex = 1;
            // 
            // lblRawMaterialTypeName
            // 
            this.lblRawMaterialTypeName.AutoSize = true;
            this.lblRawMaterialTypeName.Location = new System.Drawing.Point(3, 51);
            this.lblRawMaterialTypeName.Name = "lblRawMaterialTypeName";
            this.lblRawMaterialTypeName.Size = new System.Drawing.Size(52, 15);
            this.lblRawMaterialTypeName.TabIndex = 0;
            this.lblRawMaterialTypeName.Text = "Nombre";
            // 
            // grpbRawMaterialTypeList
            // 
            this.grpbRawMaterialTypeList.Controls.Add(this.btnRawMaterialTypeDelete);
            this.grpbRawMaterialTypeList.Controls.Add(this.btnRawMaterialTypeAdd);
            this.grpbRawMaterialTypeList.Controls.Add(this.btnRawMaterialTypeEdit);
            this.grpbRawMaterialTypeList.Controls.Add(this.dgvRawMaterialType);
            this.grpbRawMaterialTypeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialTypeList.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialTypeList.Name = "grpbRawMaterialTypeList";
            this.grpbRawMaterialTypeList.Size = new System.Drawing.Size(666, 253);
            this.grpbRawMaterialTypeList.TabIndex = 0;
            this.grpbRawMaterialTypeList.TabStop = false;
            // 
            // btnRawMaterialTypeDelete
            // 
            this.btnRawMaterialTypeDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnRawMaterialTypeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialTypeDelete.Location = new System.Drawing.Point(631, 221);
            this.btnRawMaterialTypeDelete.Name = "btnRawMaterialTypeDelete";
            this.btnRawMaterialTypeDelete.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialTypeDelete.TabIndex = 50;
            this.btnRawMaterialTypeDelete.UseVisualStyleBackColor = true;
            // 
            // btnRawMaterialTypeAdd
            // 
            this.btnRawMaterialTypeAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnRawMaterialTypeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialTypeAdd.Location = new System.Drawing.Point(579, 221);
            this.btnRawMaterialTypeAdd.Name = "btnRawMaterialTypeAdd";
            this.btnRawMaterialTypeAdd.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialTypeAdd.TabIndex = 48;
            this.btnRawMaterialTypeAdd.UseVisualStyleBackColor = true;
            this.btnRawMaterialTypeAdd.Click += new System.EventHandler(this.btnRawMaterialTypeAdd_Click);
            // 
            // btnRawMaterialTypeEdit
            // 
            this.btnRawMaterialTypeEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnRawMaterialTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRawMaterialTypeEdit.Location = new System.Drawing.Point(605, 221);
            this.btnRawMaterialTypeEdit.Name = "btnRawMaterialTypeEdit";
            this.btnRawMaterialTypeEdit.Size = new System.Drawing.Size(25, 25);
            this.btnRawMaterialTypeEdit.TabIndex = 49;
            this.btnRawMaterialTypeEdit.UseVisualStyleBackColor = true;
            this.btnRawMaterialTypeEdit.Click += new System.EventHandler(this.btnRawMaterialTypeEdit_Click);
            // 
            // dgvRawMaterialType
            // 
            this.dgvRawMaterialType.AllowUserToAddRows = false;
            this.dgvRawMaterialType.AllowUserToDeleteRows = false;
            this.dgvRawMaterialType.AllowUserToOrderColumns = true;
            this.dgvRawMaterialType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterialType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterilaTypeCodsec,
            this.clmRawMaterilaTypeName,
            this.clmRawMaterilaTypeCreatedDate,
            this.clmRawMaterialTypeCreatorUser,
            this.clmRawMaterialTypeModifiedDate,
            this.clmRawMaterialTypeModificatorUser});
            this.dgvRawMaterialType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRawMaterialType.Location = new System.Drawing.Point(3, 17);
            this.dgvRawMaterialType.Name = "dgvRawMaterialType";
            this.dgvRawMaterialType.ReadOnly = true;
            this.dgvRawMaterialType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterialType.Size = new System.Drawing.Size(660, 198);
            this.dgvRawMaterialType.TabIndex = 0;
            // 
            // clmRawMaterilaTypeCodsec
            // 
            this.clmRawMaterilaTypeCodsec.HeaderText = "Codsec";
            this.clmRawMaterilaTypeCodsec.Name = "clmRawMaterilaTypeCodsec";
            this.clmRawMaterilaTypeCodsec.ReadOnly = true;
            this.clmRawMaterilaTypeCodsec.Visible = false;
            // 
            // clmRawMaterilaTypeName
            // 
            this.clmRawMaterilaTypeName.HeaderText = "Nombre";
            this.clmRawMaterilaTypeName.Name = "clmRawMaterilaTypeName";
            this.clmRawMaterilaTypeName.ReadOnly = true;
            this.clmRawMaterilaTypeName.Width = 150;
            // 
            // clmRawMaterilaTypeCreatedDate
            // 
            this.clmRawMaterilaTypeCreatedDate.HeaderText = "Fecha Creación";
            this.clmRawMaterilaTypeCreatedDate.Name = "clmRawMaterilaTypeCreatedDate";
            this.clmRawMaterilaTypeCreatedDate.ReadOnly = true;
            this.clmRawMaterilaTypeCreatedDate.Width = 150;
            // 
            // clmRawMaterialTypeCreatorUser
            // 
            this.clmRawMaterialTypeCreatorUser.HeaderText = "Creado por";
            this.clmRawMaterialTypeCreatorUser.Name = "clmRawMaterialTypeCreatorUser";
            this.clmRawMaterialTypeCreatorUser.ReadOnly = true;
            this.clmRawMaterialTypeCreatorUser.Width = 150;
            // 
            // clmRawMaterialTypeModifiedDate
            // 
            this.clmRawMaterialTypeModifiedDate.HeaderText = "Fecha Modificacion";
            this.clmRawMaterialTypeModifiedDate.Name = "clmRawMaterialTypeModifiedDate";
            this.clmRawMaterialTypeModifiedDate.ReadOnly = true;
            this.clmRawMaterialTypeModifiedDate.Width = 150;
            // 
            // clmRawMaterialTypeModificatorUser
            // 
            this.clmRawMaterialTypeModificatorUser.HeaderText = "Modificado por";
            this.clmRawMaterialTypeModificatorUser.Name = "clmRawMaterialTypeModificatorUser";
            this.clmRawMaterialTypeModificatorUser.ReadOnly = true;
            this.clmRawMaterialTypeModificatorUser.Width = 150;
            // 
            // pnlCoating
            // 
            this.pnlCoating.Controls.Add(this.tctrlCoatingFilm);
            this.pnlCoating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoating.Location = new System.Drawing.Point(0, 0);
            this.pnlCoating.Name = "pnlCoating";
            this.pnlCoating.Size = new System.Drawing.Size(666, 524);
            this.pnlCoating.TabIndex = 1;
            // 
            // tctrlCoatingFilm
            // 
            this.tctrlCoatingFilm.Controls.Add(this.tabPage3);
            this.tctrlCoatingFilm.Controls.Add(this.tabPage4);
            this.tctrlCoatingFilm.Controls.Add(this.tabPage6);
            this.tctrlCoatingFilm.Controls.Add(this.tabPage7);
            this.tctrlCoatingFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlCoatingFilm.Location = new System.Drawing.Point(0, 0);
            this.tctrlCoatingFilm.Name = "tctrlCoatingFilm";
            this.tctrlCoatingFilm.SelectedIndex = 0;
            this.tctrlCoatingFilm.Size = new System.Drawing.Size(666, 524);
            this.tctrlCoatingFilm.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.grpbProcessCoatingForm);
            this.tabPage3.Controls.Add(this.grpbProcessCoatingList);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 496);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Procesos";
            // 
            // grpbProcessCoatingForm
            // 
            this.grpbProcessCoatingForm.Controls.Add(this.btnCoatingProcessCancel);
            this.grpbProcessCoatingForm.Controls.Add(this.btnCoatingProcessSave);
            this.grpbProcessCoatingForm.Controls.Add(this.chbxProcessCoatingCoating);
            this.grpbProcessCoatingForm.Controls.Add(this.chbxProcessCoatingCast);
            this.grpbProcessCoatingForm.Controls.Add(this.txtProcessCoatingAbbreviation);
            this.grpbProcessCoatingForm.Controls.Add(this.txtProcessCoatingName);
            this.grpbProcessCoatingForm.Controls.Add(this.lblProcessCoatingAbbreviation);
            this.grpbProcessCoatingForm.Controls.Add(this.lblProcessCoatingName);
            this.grpbProcessCoatingForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProcessCoatingForm.Location = new System.Drawing.Point(3, 256);
            this.grpbProcessCoatingForm.Name = "grpbProcessCoatingForm";
            this.grpbProcessCoatingForm.Size = new System.Drawing.Size(652, 237);
            this.grpbProcessCoatingForm.TabIndex = 1;
            this.grpbProcessCoatingForm.TabStop = false;
            // 
            // btnCoatingProcessCancel
            // 
            this.btnCoatingProcessCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCoatingProcessCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingProcessCancel.Location = new System.Drawing.Point(622, 206);
            this.btnCoatingProcessCancel.Name = "btnCoatingProcessCancel";
            this.btnCoatingProcessCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingProcessCancel.TabIndex = 6;
            this.btnCoatingProcessCancel.UseVisualStyleBackColor = true;
            this.btnCoatingProcessCancel.Click += new System.EventHandler(this.btnCoatingProcessCancel_Click);
            // 
            // btnCoatingProcessSave
            // 
            this.btnCoatingProcessSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoatingProcessSave.BackgroundImage")));
            this.btnCoatingProcessSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingProcessSave.Location = new System.Drawing.Point(597, 206);
            this.btnCoatingProcessSave.Name = "btnCoatingProcessSave";
            this.btnCoatingProcessSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingProcessSave.TabIndex = 5;
            this.btnCoatingProcessSave.UseVisualStyleBackColor = true;
            this.btnCoatingProcessSave.Click += new System.EventHandler(this.btnCoatingProcessSave_Click);
            // 
            // chbxProcessCoatingCoating
            // 
            this.chbxProcessCoatingCoating.AutoSize = true;
            this.chbxProcessCoatingCoating.Location = new System.Drawing.Point(111, 103);
            this.chbxProcessCoatingCoating.Name = "chbxProcessCoatingCoating";
            this.chbxProcessCoatingCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxProcessCoatingCoating.TabIndex = 4;
            this.chbxProcessCoatingCoating.Text = "Coating";
            this.chbxProcessCoatingCoating.UseVisualStyleBackColor = true;
            // 
            // chbxProcessCoatingCast
            // 
            this.chbxProcessCoatingCast.AutoSize = true;
            this.chbxProcessCoatingCast.Location = new System.Drawing.Point(8, 103);
            this.chbxProcessCoatingCast.Name = "chbxProcessCoatingCast";
            this.chbxProcessCoatingCast.Size = new System.Drawing.Size(47, 17);
            this.chbxProcessCoatingCast.TabIndex = 3;
            this.chbxProcessCoatingCast.Text = "Cast";
            this.chbxProcessCoatingCast.UseVisualStyleBackColor = true;
            // 
            // txtProcessCoatingAbbreviation
            // 
            this.txtProcessCoatingAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtProcessCoatingAbbreviation.Name = "txtProcessCoatingAbbreviation";
            this.txtProcessCoatingAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtProcessCoatingAbbreviation.TabIndex = 2;
            // 
            // txtProcessCoatingName
            // 
            this.txtProcessCoatingName.Location = new System.Drawing.Point(79, 24);
            this.txtProcessCoatingName.Name = "txtProcessCoatingName";
            this.txtProcessCoatingName.Size = new System.Drawing.Size(462, 21);
            this.txtProcessCoatingName.TabIndex = 1;
            // 
            // lblProcessCoatingAbbreviation
            // 
            this.lblProcessCoatingAbbreviation.AutoSize = true;
            this.lblProcessCoatingAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblProcessCoatingAbbreviation.Name = "lblProcessCoatingAbbreviation";
            this.lblProcessCoatingAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblProcessCoatingAbbreviation.TabIndex = 1;
            this.lblProcessCoatingAbbreviation.Text = "Abreviación";
            // 
            // lblProcessCoatingName
            // 
            this.lblProcessCoatingName.AutoSize = true;
            this.lblProcessCoatingName.Location = new System.Drawing.Point(3, 27);
            this.lblProcessCoatingName.Name = "lblProcessCoatingName";
            this.lblProcessCoatingName.Size = new System.Drawing.Size(52, 15);
            this.lblProcessCoatingName.TabIndex = 0;
            this.lblProcessCoatingName.Text = "Nombre";
            // 
            // grpbProcessCoatingList
            // 
            this.grpbProcessCoatingList.Controls.Add(this.btnCoatingProcessDelete);
            this.grpbProcessCoatingList.Controls.Add(this.btnCoatingProcessAdd);
            this.grpbProcessCoatingList.Controls.Add(this.btnCoatingProcessEdit);
            this.grpbProcessCoatingList.Controls.Add(this.dgvCoatingProcess);
            this.grpbProcessCoatingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProcessCoatingList.Location = new System.Drawing.Point(3, 3);
            this.grpbProcessCoatingList.Name = "grpbProcessCoatingList";
            this.grpbProcessCoatingList.Size = new System.Drawing.Size(652, 253);
            this.grpbProcessCoatingList.TabIndex = 0;
            this.grpbProcessCoatingList.TabStop = false;
            // 
            // btnCoatingProcessDelete
            // 
            this.btnCoatingProcessDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCoatingProcessDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingProcessDelete.Location = new System.Drawing.Point(622, 221);
            this.btnCoatingProcessDelete.Name = "btnCoatingProcessDelete";
            this.btnCoatingProcessDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingProcessDelete.TabIndex = 35;
            this.btnCoatingProcessDelete.UseVisualStyleBackColor = true;
            // 
            // btnCoatingProcessAdd
            // 
            this.btnCoatingProcessAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCoatingProcessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingProcessAdd.Location = new System.Drawing.Point(570, 221);
            this.btnCoatingProcessAdd.Name = "btnCoatingProcessAdd";
            this.btnCoatingProcessAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingProcessAdd.TabIndex = 33;
            this.btnCoatingProcessAdd.UseVisualStyleBackColor = true;
            this.btnCoatingProcessAdd.Click += new System.EventHandler(this.btnCoatingProcessAdd_Click);
            // 
            // btnCoatingProcessEdit
            // 
            this.btnCoatingProcessEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCoatingProcessEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingProcessEdit.Location = new System.Drawing.Point(596, 221);
            this.btnCoatingProcessEdit.Name = "btnCoatingProcessEdit";
            this.btnCoatingProcessEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingProcessEdit.TabIndex = 34;
            this.btnCoatingProcessEdit.UseVisualStyleBackColor = true;
            this.btnCoatingProcessEdit.Click += new System.EventHandler(this.btnCoatingProcessEdit_Click);
            // 
            // dgvCoatingProcess
            // 
            this.dgvCoatingProcess.AllowUserToAddRows = false;
            this.dgvCoatingProcess.AllowUserToDeleteRows = false;
            this.dgvCoatingProcess.AllowUserToOrderColumns = true;
            this.dgvCoatingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoatingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoatingCodsec,
            this.clmCoatingProcessAbbreviation,
            this.clmCoatingProcessName,
            this.clmCoatingProcessCast,
            this.clmCoatingProcessCoating});
            this.dgvCoatingProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoatingProcess.Location = new System.Drawing.Point(3, 17);
            this.dgvCoatingProcess.Name = "dgvCoatingProcess";
            this.dgvCoatingProcess.ReadOnly = true;
            this.dgvCoatingProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoatingProcess.Size = new System.Drawing.Size(646, 198);
            this.dgvCoatingProcess.TabIndex = 0;
            // 
            // clmCoatingCodsec
            // 
            this.clmCoatingCodsec.HeaderText = "Codsec";
            this.clmCoatingCodsec.Name = "clmCoatingCodsec";
            this.clmCoatingCodsec.ReadOnly = true;
            this.clmCoatingCodsec.Visible = false;
            // 
            // clmCoatingProcessAbbreviation
            // 
            this.clmCoatingProcessAbbreviation.HeaderText = "Abrev.";
            this.clmCoatingProcessAbbreviation.Name = "clmCoatingProcessAbbreviation";
            this.clmCoatingProcessAbbreviation.ReadOnly = true;
            // 
            // clmCoatingProcessName
            // 
            this.clmCoatingProcessName.HeaderText = "Nombre";
            this.clmCoatingProcessName.Name = "clmCoatingProcessName";
            this.clmCoatingProcessName.ReadOnly = true;
            this.clmCoatingProcessName.Width = 200;
            // 
            // clmCoatingProcessCast
            // 
            this.clmCoatingProcessCast.HeaderText = "Cast";
            this.clmCoatingProcessCast.Name = "clmCoatingProcessCast";
            this.clmCoatingProcessCast.ReadOnly = true;
            // 
            // clmCoatingProcessCoating
            // 
            this.clmCoatingProcessCoating.HeaderText = "Coating";
            this.clmCoatingProcessCoating.Name = "clmCoatingProcessCoating";
            this.clmCoatingProcessCoating.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.grpbStructureCoatingForm);
            this.tabPage4.Controls.Add(this.grpbStructureCoatingList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(658, 498);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Estructuras";
            // 
            // grpbStructureCoatingForm
            // 
            this.grpbStructureCoatingForm.Controls.Add(this.btnCoatingStructureCancel);
            this.grpbStructureCoatingForm.Controls.Add(this.btnCoatingStructureSave);
            this.grpbStructureCoatingForm.Controls.Add(this.chbxCoatingStructureCoating);
            this.grpbStructureCoatingForm.Controls.Add(this.chbxCoatingStructureCast);
            this.grpbStructureCoatingForm.Controls.Add(this.txtCoatingStructureAbbreviation);
            this.grpbStructureCoatingForm.Controls.Add(this.txtCoatingStructureName);
            this.grpbStructureCoatingForm.Controls.Add(this.lblCoatingStructureAbbreviation);
            this.grpbStructureCoatingForm.Controls.Add(this.lblCoatingStructureName);
            this.grpbStructureCoatingForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStructureCoatingForm.Location = new System.Drawing.Point(3, 256);
            this.grpbStructureCoatingForm.Name = "grpbStructureCoatingForm";
            this.grpbStructureCoatingForm.Size = new System.Drawing.Size(652, 237);
            this.grpbStructureCoatingForm.TabIndex = 1;
            this.grpbStructureCoatingForm.TabStop = false;
            // 
            // btnCoatingStructureCancel
            // 
            this.btnCoatingStructureCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCoatingStructureCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingStructureCancel.Location = new System.Drawing.Point(622, 207);
            this.btnCoatingStructureCancel.Name = "btnCoatingStructureCancel";
            this.btnCoatingStructureCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingStructureCancel.TabIndex = 6;
            this.btnCoatingStructureCancel.UseVisualStyleBackColor = true;
            this.btnCoatingStructureCancel.Click += new System.EventHandler(this.btnCoatingStructureCancel_Click);
            // 
            // btnCoatingStructureSave
            // 
            this.btnCoatingStructureSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoatingStructureSave.BackgroundImage")));
            this.btnCoatingStructureSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingStructureSave.Location = new System.Drawing.Point(597, 207);
            this.btnCoatingStructureSave.Name = "btnCoatingStructureSave";
            this.btnCoatingStructureSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingStructureSave.TabIndex = 5;
            this.btnCoatingStructureSave.UseVisualStyleBackColor = true;
            this.btnCoatingStructureSave.Click += new System.EventHandler(this.btnCoatingStructureSave_Click);
            // 
            // chbxCoatingStructureCoating
            // 
            this.chbxCoatingStructureCoating.AutoSize = true;
            this.chbxCoatingStructureCoating.Location = new System.Drawing.Point(111, 104);
            this.chbxCoatingStructureCoating.Name = "chbxCoatingStructureCoating";
            this.chbxCoatingStructureCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxCoatingStructureCoating.TabIndex = 4;
            this.chbxCoatingStructureCoating.Text = "Coating";
            this.chbxCoatingStructureCoating.UseVisualStyleBackColor = true;
            // 
            // chbxCoatingStructureCast
            // 
            this.chbxCoatingStructureCast.AutoSize = true;
            this.chbxCoatingStructureCast.Location = new System.Drawing.Point(8, 104);
            this.chbxCoatingStructureCast.Name = "chbxCoatingStructureCast";
            this.chbxCoatingStructureCast.Size = new System.Drawing.Size(47, 17);
            this.chbxCoatingStructureCast.TabIndex = 3;
            this.chbxCoatingStructureCast.Text = "Cast";
            this.chbxCoatingStructureCast.UseVisualStyleBackColor = true;
            // 
            // txtCoatingStructureAbbreviation
            // 
            this.txtCoatingStructureAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtCoatingStructureAbbreviation.Name = "txtCoatingStructureAbbreviation";
            this.txtCoatingStructureAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtCoatingStructureAbbreviation.TabIndex = 2;
            // 
            // txtCoatingStructureName
            // 
            this.txtCoatingStructureName.Location = new System.Drawing.Point(79, 24);
            this.txtCoatingStructureName.Name = "txtCoatingStructureName";
            this.txtCoatingStructureName.Size = new System.Drawing.Size(462, 21);
            this.txtCoatingStructureName.TabIndex = 1;
            // 
            // lblCoatingStructureAbbreviation
            // 
            this.lblCoatingStructureAbbreviation.AutoSize = true;
            this.lblCoatingStructureAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblCoatingStructureAbbreviation.Name = "lblCoatingStructureAbbreviation";
            this.lblCoatingStructureAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblCoatingStructureAbbreviation.TabIndex = 1;
            this.lblCoatingStructureAbbreviation.Text = "Abreviacion";
            // 
            // lblCoatingStructureName
            // 
            this.lblCoatingStructureName.AutoSize = true;
            this.lblCoatingStructureName.Location = new System.Drawing.Point(3, 27);
            this.lblCoatingStructureName.Name = "lblCoatingStructureName";
            this.lblCoatingStructureName.Size = new System.Drawing.Size(52, 15);
            this.lblCoatingStructureName.TabIndex = 0;
            this.lblCoatingStructureName.Text = "Nombre";
            // 
            // grpbStructureCoatingList
            // 
            this.grpbStructureCoatingList.Controls.Add(this.btnCoatingStructureDelete);
            this.grpbStructureCoatingList.Controls.Add(this.btnCoatingStructureAdd);
            this.grpbStructureCoatingList.Controls.Add(this.btnCoatingStructureEdit);
            this.grpbStructureCoatingList.Controls.Add(this.dgvCoatingStructure);
            this.grpbStructureCoatingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStructureCoatingList.Location = new System.Drawing.Point(3, 3);
            this.grpbStructureCoatingList.Name = "grpbStructureCoatingList";
            this.grpbStructureCoatingList.Size = new System.Drawing.Size(652, 253);
            this.grpbStructureCoatingList.TabIndex = 0;
            this.grpbStructureCoatingList.TabStop = false;
            // 
            // btnCoatingStructureDelete
            // 
            this.btnCoatingStructureDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCoatingStructureDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingStructureDelete.Location = new System.Drawing.Point(622, 221);
            this.btnCoatingStructureDelete.Name = "btnCoatingStructureDelete";
            this.btnCoatingStructureDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingStructureDelete.TabIndex = 38;
            this.btnCoatingStructureDelete.UseVisualStyleBackColor = true;
            // 
            // btnCoatingStructureAdd
            // 
            this.btnCoatingStructureAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCoatingStructureAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingStructureAdd.Location = new System.Drawing.Point(570, 221);
            this.btnCoatingStructureAdd.Name = "btnCoatingStructureAdd";
            this.btnCoatingStructureAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingStructureAdd.TabIndex = 36;
            this.btnCoatingStructureAdd.UseVisualStyleBackColor = true;
            this.btnCoatingStructureAdd.Click += new System.EventHandler(this.btnCoatingStructureAdd_Click);
            // 
            // btnCoatingStructureEdit
            // 
            this.btnCoatingStructureEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCoatingStructureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingStructureEdit.Location = new System.Drawing.Point(596, 221);
            this.btnCoatingStructureEdit.Name = "btnCoatingStructureEdit";
            this.btnCoatingStructureEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingStructureEdit.TabIndex = 37;
            this.btnCoatingStructureEdit.UseVisualStyleBackColor = true;
            this.btnCoatingStructureEdit.Click += new System.EventHandler(this.btnCoatingStructureEdit_Click);
            // 
            // dgvCoatingStructure
            // 
            this.dgvCoatingStructure.AllowUserToAddRows = false;
            this.dgvCoatingStructure.AllowUserToDeleteRows = false;
            this.dgvCoatingStructure.AllowUserToOrderColumns = true;
            this.dgvCoatingStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoatingStructure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStructureCoatingCodsec,
            this.clmStructureCoatingAbbreviation,
            this.clmStructureCoatingName,
            this.clmStructureCoatingCast,
            this.clmStructureCoatingCoating});
            this.dgvCoatingStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoatingStructure.Location = new System.Drawing.Point(3, 17);
            this.dgvCoatingStructure.Name = "dgvCoatingStructure";
            this.dgvCoatingStructure.ReadOnly = true;
            this.dgvCoatingStructure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoatingStructure.Size = new System.Drawing.Size(646, 198);
            this.dgvCoatingStructure.TabIndex = 0;
            // 
            // clmStructureCoatingCodsec
            // 
            this.clmStructureCoatingCodsec.HeaderText = "Codsec";
            this.clmStructureCoatingCodsec.Name = "clmStructureCoatingCodsec";
            this.clmStructureCoatingCodsec.ReadOnly = true;
            this.clmStructureCoatingCodsec.Visible = false;
            // 
            // clmStructureCoatingAbbreviation
            // 
            this.clmStructureCoatingAbbreviation.HeaderText = "Abrev.";
            this.clmStructureCoatingAbbreviation.Name = "clmStructureCoatingAbbreviation";
            this.clmStructureCoatingAbbreviation.ReadOnly = true;
            // 
            // clmStructureCoatingName
            // 
            this.clmStructureCoatingName.HeaderText = "Nombre";
            this.clmStructureCoatingName.Name = "clmStructureCoatingName";
            this.clmStructureCoatingName.ReadOnly = true;
            this.clmStructureCoatingName.Width = 200;
            // 
            // clmStructureCoatingCast
            // 
            this.clmStructureCoatingCast.HeaderText = "Cast";
            this.clmStructureCoatingCast.Name = "clmStructureCoatingCast";
            this.clmStructureCoatingCast.ReadOnly = true;
            // 
            // clmStructureCoatingCoating
            // 
            this.clmStructureCoatingCoating.HeaderText = "Coating";
            this.clmStructureCoatingCoating.Name = "clmStructureCoatingCoating";
            this.clmStructureCoatingCoating.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.grpbThicknessCoatingForm);
            this.tabPage6.Controls.Add(this.grpbThicknessCoatingList);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(658, 498);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Espesores";
            // 
            // grpbThicknessCoatingForm
            // 
            this.grpbThicknessCoatingForm.Controls.Add(this.btnCoatingThicknessCancel);
            this.grpbThicknessCoatingForm.Controls.Add(this.btnCoatingThicknessSave);
            this.grpbThicknessCoatingForm.Controls.Add(this.txtThicknessCoating);
            this.grpbThicknessCoatingForm.Controls.Add(this.lblThicknessCoating);
            this.grpbThicknessCoatingForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThicknessCoatingForm.Location = new System.Drawing.Point(3, 256);
            this.grpbThicknessCoatingForm.Name = "grpbThicknessCoatingForm";
            this.grpbThicknessCoatingForm.Size = new System.Drawing.Size(652, 237);
            this.grpbThicknessCoatingForm.TabIndex = 1;
            this.grpbThicknessCoatingForm.TabStop = false;
            // 
            // btnCoatingThicknessCancel
            // 
            this.btnCoatingThicknessCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCoatingThicknessCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingThicknessCancel.Location = new System.Drawing.Point(619, 205);
            this.btnCoatingThicknessCancel.Name = "btnCoatingThicknessCancel";
            this.btnCoatingThicknessCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingThicknessCancel.TabIndex = 3;
            this.btnCoatingThicknessCancel.UseVisualStyleBackColor = true;
            this.btnCoatingThicknessCancel.Click += new System.EventHandler(this.btnCoatingThicknessCancel_Click);
            // 
            // btnCoatingThicknessSave
            // 
            this.btnCoatingThicknessSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoatingThicknessSave.BackgroundImage")));
            this.btnCoatingThicknessSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingThicknessSave.Location = new System.Drawing.Point(594, 205);
            this.btnCoatingThicknessSave.Name = "btnCoatingThicknessSave";
            this.btnCoatingThicknessSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingThicknessSave.TabIndex = 2;
            this.btnCoatingThicknessSave.UseVisualStyleBackColor = true;
            this.btnCoatingThicknessSave.Click += new System.EventHandler(this.btnCoatingThicknessSave_Click);
            // 
            // txtThicknessCoating
            // 
            this.txtThicknessCoating.Location = new System.Drawing.Point(79, 34);
            this.txtThicknessCoating.Name = "txtThicknessCoating";
            this.txtThicknessCoating.Size = new System.Drawing.Size(100, 21);
            this.txtThicknessCoating.TabIndex = 1;
            // 
            // lblThicknessCoating
            // 
            this.lblThicknessCoating.AutoSize = true;
            this.lblThicknessCoating.Location = new System.Drawing.Point(3, 34);
            this.lblThicknessCoating.Name = "lblThicknessCoating";
            this.lblThicknessCoating.Size = new System.Drawing.Size(35, 15);
            this.lblThicknessCoating.TabIndex = 0;
            this.lblThicknessCoating.Text = "Valor";
            // 
            // grpbThicknessCoatingList
            // 
            this.grpbThicknessCoatingList.Controls.Add(this.btnCoatingThicknessDelete);
            this.grpbThicknessCoatingList.Controls.Add(this.btnCoatingThicknessAdd);
            this.grpbThicknessCoatingList.Controls.Add(this.btnCoatingThicknessEdit);
            this.grpbThicknessCoatingList.Controls.Add(this.dgvCoatingThickness);
            this.grpbThicknessCoatingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThicknessCoatingList.Location = new System.Drawing.Point(3, 3);
            this.grpbThicknessCoatingList.Name = "grpbThicknessCoatingList";
            this.grpbThicknessCoatingList.Size = new System.Drawing.Size(652, 253);
            this.grpbThicknessCoatingList.TabIndex = 0;
            this.grpbThicknessCoatingList.TabStop = false;
            // 
            // btnCoatingThicknessDelete
            // 
            this.btnCoatingThicknessDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCoatingThicknessDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingThicknessDelete.Location = new System.Drawing.Point(619, 221);
            this.btnCoatingThicknessDelete.Name = "btnCoatingThicknessDelete";
            this.btnCoatingThicknessDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingThicknessDelete.TabIndex = 41;
            this.btnCoatingThicknessDelete.UseVisualStyleBackColor = true;
            // 
            // btnCoatingThicknessAdd
            // 
            this.btnCoatingThicknessAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCoatingThicknessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingThicknessAdd.Location = new System.Drawing.Point(567, 221);
            this.btnCoatingThicknessAdd.Name = "btnCoatingThicknessAdd";
            this.btnCoatingThicknessAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingThicknessAdd.TabIndex = 39;
            this.btnCoatingThicknessAdd.UseVisualStyleBackColor = true;
            this.btnCoatingThicknessAdd.Click += new System.EventHandler(this.btnCoatingThicknessAdd_Click);
            // 
            // btnCoatingThicknessEdit
            // 
            this.btnCoatingThicknessEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCoatingThicknessEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingThicknessEdit.Location = new System.Drawing.Point(593, 221);
            this.btnCoatingThicknessEdit.Name = "btnCoatingThicknessEdit";
            this.btnCoatingThicknessEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingThicknessEdit.TabIndex = 40;
            this.btnCoatingThicknessEdit.UseVisualStyleBackColor = true;
            this.btnCoatingThicknessEdit.Click += new System.EventHandler(this.btnCoatingThicknessEdit_Click);
            // 
            // dgvCoatingThickness
            // 
            this.dgvCoatingThickness.AllowUserToAddRows = false;
            this.dgvCoatingThickness.AllowUserToDeleteRows = false;
            this.dgvCoatingThickness.AllowUserToOrderColumns = true;
            this.dgvCoatingThickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoatingThickness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmThicknessCoatingCodsec,
            this.clmThicknessCoatingValue});
            this.dgvCoatingThickness.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoatingThickness.Location = new System.Drawing.Point(3, 17);
            this.dgvCoatingThickness.Name = "dgvCoatingThickness";
            this.dgvCoatingThickness.ReadOnly = true;
            this.dgvCoatingThickness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoatingThickness.Size = new System.Drawing.Size(646, 198);
            this.dgvCoatingThickness.TabIndex = 0;
            // 
            // clmThicknessCoatingCodsec
            // 
            this.clmThicknessCoatingCodsec.HeaderText = "Codsec";
            this.clmThicknessCoatingCodsec.Name = "clmThicknessCoatingCodsec";
            this.clmThicknessCoatingCodsec.ReadOnly = true;
            this.clmThicknessCoatingCodsec.Visible = false;
            // 
            // clmThicknessCoatingValue
            // 
            this.clmThicknessCoatingValue.HeaderText = "Valor";
            this.clmThicknessCoatingValue.Name = "clmThicknessCoatingValue";
            this.clmThicknessCoatingValue.ReadOnly = true;
            this.clmThicknessCoatingValue.Width = 250;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.grpbTreatmentCoatingForm);
            this.tabPage7.Controls.Add(this.grpbTreatmentCoatingList);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(658, 498);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Tratamientos";
            // 
            // grpbTreatmentCoatingForm
            // 
            this.grpbTreatmentCoatingForm.Controls.Add(this.btnCoatingTreatmentCancel);
            this.grpbTreatmentCoatingForm.Controls.Add(this.btnCoatingTreatmentSave);
            this.grpbTreatmentCoatingForm.Controls.Add(this.txtCoatingTreatmentAbbreviation);
            this.grpbTreatmentCoatingForm.Controls.Add(this.txtCoatingTreatmentName);
            this.grpbTreatmentCoatingForm.Controls.Add(this.chbxCoatingTreatmentCoating);
            this.grpbTreatmentCoatingForm.Controls.Add(this.chbxCoatingTreatmentCast);
            this.grpbTreatmentCoatingForm.Controls.Add(this.chbxCoatingTreatmentBopp);
            this.grpbTreatmentCoatingForm.Controls.Add(this.lblCoatingTreatmentAbbreviation);
            this.grpbTreatmentCoatingForm.Controls.Add(this.lblCoatingTreatmentName);
            this.grpbTreatmentCoatingForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTreatmentCoatingForm.Location = new System.Drawing.Point(3, 256);
            this.grpbTreatmentCoatingForm.Name = "grpbTreatmentCoatingForm";
            this.grpbTreatmentCoatingForm.Size = new System.Drawing.Size(652, 237);
            this.grpbTreatmentCoatingForm.TabIndex = 1;
            this.grpbTreatmentCoatingForm.TabStop = false;
            // 
            // btnCoatingTreatmentCancel
            // 
            this.btnCoatingTreatmentCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCoatingTreatmentCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingTreatmentCancel.Location = new System.Drawing.Point(621, 206);
            this.btnCoatingTreatmentCancel.Name = "btnCoatingTreatmentCancel";
            this.btnCoatingTreatmentCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingTreatmentCancel.TabIndex = 7;
            this.btnCoatingTreatmentCancel.UseVisualStyleBackColor = true;
            this.btnCoatingTreatmentCancel.Click += new System.EventHandler(this.btnCoatingTreatmentCancel_Click);
            // 
            // btnCoatingTreatmentSave
            // 
            this.btnCoatingTreatmentSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoatingTreatmentSave.BackgroundImage")));
            this.btnCoatingTreatmentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingTreatmentSave.Location = new System.Drawing.Point(596, 206);
            this.btnCoatingTreatmentSave.Name = "btnCoatingTreatmentSave";
            this.btnCoatingTreatmentSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingTreatmentSave.TabIndex = 6;
            this.btnCoatingTreatmentSave.UseVisualStyleBackColor = true;
            this.btnCoatingTreatmentSave.Click += new System.EventHandler(this.btnCoatingTreatmentSave_Click);
            // 
            // txtCoatingTreatmentAbbreviation
            // 
            this.txtCoatingTreatmentAbbreviation.Location = new System.Drawing.Point(79, 64);
            this.txtCoatingTreatmentAbbreviation.Name = "txtCoatingTreatmentAbbreviation";
            this.txtCoatingTreatmentAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtCoatingTreatmentAbbreviation.TabIndex = 2;
            // 
            // txtCoatingTreatmentName
            // 
            this.txtCoatingTreatmentName.Location = new System.Drawing.Point(79, 24);
            this.txtCoatingTreatmentName.Name = "txtCoatingTreatmentName";
            this.txtCoatingTreatmentName.Size = new System.Drawing.Size(462, 21);
            this.txtCoatingTreatmentName.TabIndex = 1;
            // 
            // chbxCoatingTreatmentCoating
            // 
            this.chbxCoatingTreatmentCoating.AutoSize = true;
            this.chbxCoatingTreatmentCoating.Location = new System.Drawing.Point(214, 104);
            this.chbxCoatingTreatmentCoating.Name = "chbxCoatingTreatmentCoating";
            this.chbxCoatingTreatmentCoating.Size = new System.Drawing.Size(62, 17);
            this.chbxCoatingTreatmentCoating.TabIndex = 5;
            this.chbxCoatingTreatmentCoating.Text = "Coating";
            this.chbxCoatingTreatmentCoating.UseVisualStyleBackColor = true;
            // 
            // chbxCoatingTreatmentCast
            // 
            this.chbxCoatingTreatmentCast.AutoSize = true;
            this.chbxCoatingTreatmentCast.Location = new System.Drawing.Point(111, 104);
            this.chbxCoatingTreatmentCast.Name = "chbxCoatingTreatmentCast";
            this.chbxCoatingTreatmentCast.Size = new System.Drawing.Size(47, 17);
            this.chbxCoatingTreatmentCast.TabIndex = 4;
            this.chbxCoatingTreatmentCast.Text = "Cast";
            this.chbxCoatingTreatmentCast.UseVisualStyleBackColor = true;
            // 
            // chbxCoatingTreatmentBopp
            // 
            this.chbxCoatingTreatmentBopp.AutoSize = true;
            this.chbxCoatingTreatmentBopp.Location = new System.Drawing.Point(8, 104);
            this.chbxCoatingTreatmentBopp.Name = "chbxCoatingTreatmentBopp";
            this.chbxCoatingTreatmentBopp.Size = new System.Drawing.Size(51, 17);
            this.chbxCoatingTreatmentBopp.TabIndex = 3;
            this.chbxCoatingTreatmentBopp.Text = "Bopp";
            this.chbxCoatingTreatmentBopp.UseVisualStyleBackColor = true;
            // 
            // lblCoatingTreatmentAbbreviation
            // 
            this.lblCoatingTreatmentAbbreviation.AutoSize = true;
            this.lblCoatingTreatmentAbbreviation.Location = new System.Drawing.Point(3, 67);
            this.lblCoatingTreatmentAbbreviation.Name = "lblCoatingTreatmentAbbreviation";
            this.lblCoatingTreatmentAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblCoatingTreatmentAbbreviation.TabIndex = 1;
            this.lblCoatingTreatmentAbbreviation.Text = "Abreviacion";
            // 
            // lblCoatingTreatmentName
            // 
            this.lblCoatingTreatmentName.AutoSize = true;
            this.lblCoatingTreatmentName.Location = new System.Drawing.Point(3, 27);
            this.lblCoatingTreatmentName.Name = "lblCoatingTreatmentName";
            this.lblCoatingTreatmentName.Size = new System.Drawing.Size(52, 15);
            this.lblCoatingTreatmentName.TabIndex = 0;
            this.lblCoatingTreatmentName.Text = "Nombre";
            // 
            // grpbTreatmentCoatingList
            // 
            this.grpbTreatmentCoatingList.Controls.Add(this.btnCoatingTreatmentDelete);
            this.grpbTreatmentCoatingList.Controls.Add(this.btnCoatingTreatmentAdd);
            this.grpbTreatmentCoatingList.Controls.Add(this.btnCoatingTreatmentEdit);
            this.grpbTreatmentCoatingList.Controls.Add(this.dgvCoatingTreatment);
            this.grpbTreatmentCoatingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTreatmentCoatingList.Location = new System.Drawing.Point(3, 3);
            this.grpbTreatmentCoatingList.Name = "grpbTreatmentCoatingList";
            this.grpbTreatmentCoatingList.Size = new System.Drawing.Size(652, 253);
            this.grpbTreatmentCoatingList.TabIndex = 0;
            this.grpbTreatmentCoatingList.TabStop = false;
            // 
            // btnCoatingTreatmentDelete
            // 
            this.btnCoatingTreatmentDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCoatingTreatmentDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingTreatmentDelete.Location = new System.Drawing.Point(621, 221);
            this.btnCoatingTreatmentDelete.Name = "btnCoatingTreatmentDelete";
            this.btnCoatingTreatmentDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingTreatmentDelete.TabIndex = 44;
            this.btnCoatingTreatmentDelete.UseVisualStyleBackColor = true;
            // 
            // btnCoatingTreatmentAdd
            // 
            this.btnCoatingTreatmentAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCoatingTreatmentAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingTreatmentAdd.Location = new System.Drawing.Point(569, 221);
            this.btnCoatingTreatmentAdd.Name = "btnCoatingTreatmentAdd";
            this.btnCoatingTreatmentAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingTreatmentAdd.TabIndex = 42;
            this.btnCoatingTreatmentAdd.UseVisualStyleBackColor = true;
            this.btnCoatingTreatmentAdd.Click += new System.EventHandler(this.btnCoatingTreatmentAdd_Click);
            // 
            // btnCoatingTreatmentEdit
            // 
            this.btnCoatingTreatmentEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCoatingTreatmentEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoatingTreatmentEdit.Location = new System.Drawing.Point(595, 221);
            this.btnCoatingTreatmentEdit.Name = "btnCoatingTreatmentEdit";
            this.btnCoatingTreatmentEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCoatingTreatmentEdit.TabIndex = 43;
            this.btnCoatingTreatmentEdit.UseVisualStyleBackColor = true;
            this.btnCoatingTreatmentEdit.Click += new System.EventHandler(this.btnCoatingTreatmentEdit_Click);
            // 
            // dgvCoatingTreatment
            // 
            this.dgvCoatingTreatment.AllowUserToAddRows = false;
            this.dgvCoatingTreatment.AllowUserToDeleteRows = false;
            this.dgvCoatingTreatment.AllowUserToOrderColumns = true;
            this.dgvCoatingTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoatingTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoatingTreatmentCodsec,
            this.clmCoatingTreatmentAbbreviation,
            this.clmCoatingTreatmentName,
            this.clmCoatingTreatmentBopp,
            this.clmCoatingTreatmentCast,
            this.clmCoatingTreatmentCoating});
            this.dgvCoatingTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoatingTreatment.Location = new System.Drawing.Point(3, 17);
            this.dgvCoatingTreatment.Name = "dgvCoatingTreatment";
            this.dgvCoatingTreatment.ReadOnly = true;
            this.dgvCoatingTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoatingTreatment.Size = new System.Drawing.Size(646, 198);
            this.dgvCoatingTreatment.TabIndex = 0;
            // 
            // clmCoatingTreatmentCodsec
            // 
            this.clmCoatingTreatmentCodsec.HeaderText = "Codsec";
            this.clmCoatingTreatmentCodsec.Name = "clmCoatingTreatmentCodsec";
            this.clmCoatingTreatmentCodsec.ReadOnly = true;
            this.clmCoatingTreatmentCodsec.Visible = false;
            // 
            // clmCoatingTreatmentAbbreviation
            // 
            this.clmCoatingTreatmentAbbreviation.HeaderText = "Abrev.";
            this.clmCoatingTreatmentAbbreviation.Name = "clmCoatingTreatmentAbbreviation";
            this.clmCoatingTreatmentAbbreviation.ReadOnly = true;
            // 
            // clmCoatingTreatmentName
            // 
            this.clmCoatingTreatmentName.HeaderText = "Nombre";
            this.clmCoatingTreatmentName.Name = "clmCoatingTreatmentName";
            this.clmCoatingTreatmentName.ReadOnly = true;
            // 
            // clmCoatingTreatmentBopp
            // 
            this.clmCoatingTreatmentBopp.HeaderText = "Bopp";
            this.clmCoatingTreatmentBopp.Name = "clmCoatingTreatmentBopp";
            this.clmCoatingTreatmentBopp.ReadOnly = true;
            // 
            // clmCoatingTreatmentCast
            // 
            this.clmCoatingTreatmentCast.HeaderText = "Cast";
            this.clmCoatingTreatmentCast.Name = "clmCoatingTreatmentCast";
            this.clmCoatingTreatmentCast.ReadOnly = true;
            // 
            // clmCoatingTreatmentCoating
            // 
            this.clmCoatingTreatmentCoating.HeaderText = "Coating";
            this.clmCoatingTreatmentCoating.Name = "clmCoatingTreatmentCoating";
            this.clmCoatingTreatmentCoating.ReadOnly = true;
            // 
            // pnlSector
            // 
            this.pnlSector.Controls.Add(this.grpbSectorForm);
            this.pnlSector.Controls.Add(this.grpbSectorList);
            this.pnlSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSector.Location = new System.Drawing.Point(0, 0);
            this.pnlSector.Name = "pnlSector";
            this.pnlSector.Size = new System.Drawing.Size(666, 524);
            this.pnlSector.TabIndex = 1;
            // 
            // grpbSectorForm
            // 
            this.grpbSectorForm.Controls.Add(this.rdoMorePlant);
            this.grpbSectorForm.Controls.Add(this.rdoOnePlant);
            this.grpbSectorForm.Controls.Add(this.lstbPlant);
            this.grpbSectorForm.Controls.Add(this.btnSectorCancel);
            this.grpbSectorForm.Controls.Add(this.btnSectorSave);
            this.grpbSectorForm.Controls.Add(this.txtSectorName);
            this.grpbSectorForm.Controls.Add(this.lblSectorName);
            this.grpbSectorForm.Location = new System.Drawing.Point(3, 253);
            this.grpbSectorForm.Name = "grpbSectorForm";
            this.grpbSectorForm.Size = new System.Drawing.Size(658, 265);
            this.grpbSectorForm.TabIndex = 1;
            this.grpbSectorForm.TabStop = false;
            // 
            // rdoMorePlant
            // 
            this.rdoMorePlant.AutoSize = true;
            this.rdoMorePlant.Location = new System.Drawing.Point(3, 103);
            this.rdoMorePlant.Name = "rdoMorePlant";
            this.rdoMorePlant.Size = new System.Drawing.Size(92, 17);
            this.rdoMorePlant.TabIndex = 45;
            this.rdoMorePlant.TabStop = true;
            this.rdoMorePlant.Text = "Varias Plantas";
            this.rdoMorePlant.UseVisualStyleBackColor = true;
            // 
            // rdoOnePlant
            // 
            this.rdoOnePlant.AutoSize = true;
            this.rdoOnePlant.Location = new System.Drawing.Point(3, 67);
            this.rdoOnePlant.Name = "rdoOnePlant";
            this.rdoOnePlant.Size = new System.Drawing.Size(78, 17);
            this.rdoOnePlant.TabIndex = 44;
            this.rdoOnePlant.TabStop = true;
            this.rdoOnePlant.Text = "Una Planta";
            this.rdoOnePlant.UseVisualStyleBackColor = true;
            this.rdoOnePlant.CheckedChanged += new System.EventHandler(this.rdoOnePlant_CheckedChanged);
            // 
            // lstbPlant
            // 
            this.lstbPlant.FormattingEnabled = true;
            this.lstbPlant.ItemHeight = 15;
            this.lstbPlant.Location = new System.Drawing.Point(120, 59);
            this.lstbPlant.Name = "lstbPlant";
            this.lstbPlant.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbPlant.Size = new System.Drawing.Size(156, 154);
            this.lstbPlant.TabIndex = 43;
            // 
            // btnSectorCancel
            // 
            this.btnSectorCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSectorCancel.BackgroundImage")));
            this.btnSectorCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectorCancel.Location = new System.Drawing.Point(632, 235);
            this.btnSectorCancel.Name = "btnSectorCancel";
            this.btnSectorCancel.Size = new System.Drawing.Size(25, 25);
            this.btnSectorCancel.TabIndex = 41;
            this.btnSectorCancel.UseVisualStyleBackColor = true;
            this.btnSectorCancel.Click += new System.EventHandler(this.btnSectorCancel_Click);
            // 
            // btnSectorSave
            // 
            this.btnSectorSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSectorSave.BackgroundImage")));
            this.btnSectorSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectorSave.Location = new System.Drawing.Point(607, 235);
            this.btnSectorSave.Name = "btnSectorSave";
            this.btnSectorSave.Size = new System.Drawing.Size(25, 25);
            this.btnSectorSave.TabIndex = 40;
            this.btnSectorSave.UseVisualStyleBackColor = true;
            this.btnSectorSave.Click += new System.EventHandler(this.btnSectorSave_Click);
            // 
            // txtSectorName
            // 
            this.txtSectorName.Location = new System.Drawing.Point(79, 22);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.Size = new System.Drawing.Size(300, 21);
            this.txtSectorName.TabIndex = 1;
            // 
            // lblSectorName
            // 
            this.lblSectorName.AutoSize = true;
            this.lblSectorName.Location = new System.Drawing.Point(3, 25);
            this.lblSectorName.Name = "lblSectorName";
            this.lblSectorName.Size = new System.Drawing.Size(52, 15);
            this.lblSectorName.TabIndex = 0;
            this.lblSectorName.Text = "Nombre";
            // 
            // grpbSectorList
            // 
            this.grpbSectorList.Controls.Add(this.btnSectorAdd);
            this.grpbSectorList.Controls.Add(this.btnSectorEdit);
            this.grpbSectorList.Controls.Add(this.btnSectorDelete);
            this.grpbSectorList.Controls.Add(this.dgvSector);
            this.grpbSectorList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSectorList.Location = new System.Drawing.Point(0, 0);
            this.grpbSectorList.Name = "grpbSectorList";
            this.grpbSectorList.Size = new System.Drawing.Size(666, 253);
            this.grpbSectorList.TabIndex = 0;
            this.grpbSectorList.TabStop = false;
            // 
            // btnSectorAdd
            // 
            this.btnSectorAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSectorAdd.BackgroundImage")));
            this.btnSectorAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectorAdd.Location = new System.Drawing.Point(583, 221);
            this.btnSectorAdd.Name = "btnSectorAdd";
            this.btnSectorAdd.Size = new System.Drawing.Size(25, 25);
            this.btnSectorAdd.TabIndex = 33;
            this.btnSectorAdd.UseVisualStyleBackColor = true;
            this.btnSectorAdd.Click += new System.EventHandler(this.btnSectorAdd_Click);
            // 
            // btnSectorEdit
            // 
            this.btnSectorEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSectorEdit.BackgroundImage")));
            this.btnSectorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectorEdit.Location = new System.Drawing.Point(609, 221);
            this.btnSectorEdit.Name = "btnSectorEdit";
            this.btnSectorEdit.Size = new System.Drawing.Size(25, 25);
            this.btnSectorEdit.TabIndex = 31;
            this.btnSectorEdit.UseVisualStyleBackColor = true;
            this.btnSectorEdit.Click += new System.EventHandler(this.btnSectorEdit_Click);
            // 
            // btnSectorDelete
            // 
            this.btnSectorDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSectorDelete.BackgroundImage")));
            this.btnSectorDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectorDelete.Location = new System.Drawing.Point(635, 221);
            this.btnSectorDelete.Name = "btnSectorDelete";
            this.btnSectorDelete.Size = new System.Drawing.Size(25, 25);
            this.btnSectorDelete.TabIndex = 32;
            this.btnSectorDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSector
            // 
            this.dgvSector.AllowUserToAddRows = false;
            this.dgvSector.AllowUserToDeleteRows = false;
            this.dgvSector.AllowUserToOrderColumns = true;
            this.dgvSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSectorCodsec,
            this.clmSectorName,
            this.clmSectorPlantName});
            this.dgvSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSector.Location = new System.Drawing.Point(3, 17);
            this.dgvSector.Name = "dgvSector";
            this.dgvSector.ReadOnly = true;
            this.dgvSector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSector.Size = new System.Drawing.Size(660, 198);
            this.dgvSector.TabIndex = 0;
            // 
            // clmSectorCodsec
            // 
            this.clmSectorCodsec.HeaderText = "Codsec";
            this.clmSectorCodsec.Name = "clmSectorCodsec";
            this.clmSectorCodsec.ReadOnly = true;
            this.clmSectorCodsec.Visible = false;
            // 
            // clmSectorName
            // 
            this.clmSectorName.HeaderText = "Nombre";
            this.clmSectorName.Name = "clmSectorName";
            this.clmSectorName.ReadOnly = true;
            this.clmSectorName.Width = 250;
            // 
            // clmSectorPlantName
            // 
            this.clmSectorPlantName.HeaderText = "Planta";
            this.clmSectorPlantName.Name = "clmSectorPlantName";
            this.clmSectorPlantName.ReadOnly = true;
            this.clmSectorPlantName.Width = 250;
            // 
            // pnlPlant
            // 
            this.pnlPlant.Controls.Add(this.grpbPlantForm);
            this.pnlPlant.Controls.Add(this.grpbPlantList);
            this.pnlPlant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlant.Location = new System.Drawing.Point(0, 0);
            this.pnlPlant.Name = "pnlPlant";
            this.pnlPlant.Size = new System.Drawing.Size(666, 524);
            this.pnlPlant.TabIndex = 1;
            // 
            // grpbPlantForm
            // 
            this.grpbPlantForm.Controls.Add(this.btnPlantCancel);
            this.grpbPlantForm.Controls.Add(this.btnPlantSave);
            this.grpbPlantForm.Controls.Add(this.txtPlantName);
            this.grpbPlantForm.Controls.Add(this.lblPlantName);
            this.grpbPlantForm.Location = new System.Drawing.Point(3, 253);
            this.grpbPlantForm.Name = "grpbPlantForm";
            this.grpbPlantForm.Size = new System.Drawing.Size(660, 265);
            this.grpbPlantForm.TabIndex = 1;
            this.grpbPlantForm.TabStop = false;
            // 
            // btnPlantCancel
            // 
            this.btnPlantCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnPlantCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlantCancel.Location = new System.Drawing.Point(633, 233);
            this.btnPlantCancel.Name = "btnPlantCancel";
            this.btnPlantCancel.Size = new System.Drawing.Size(25, 25);
            this.btnPlantCancel.TabIndex = 3;
            this.btnPlantCancel.UseVisualStyleBackColor = true;
            this.btnPlantCancel.Click += new System.EventHandler(this.btnPlantCancel_Click);
            // 
            // btnPlantSave
            // 
            this.btnPlantSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlantSave.BackgroundImage")));
            this.btnPlantSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlantSave.Location = new System.Drawing.Point(608, 233);
            this.btnPlantSave.Name = "btnPlantSave";
            this.btnPlantSave.Size = new System.Drawing.Size(25, 25);
            this.btnPlantSave.TabIndex = 2;
            this.btnPlantSave.UseVisualStyleBackColor = true;
            this.btnPlantSave.Click += new System.EventHandler(this.btnPlantSave_Click);
            // 
            // txtPlantName
            // 
            this.txtPlantName.Location = new System.Drawing.Point(79, 48);
            this.txtPlantName.Name = "txtPlantName";
            this.txtPlantName.Size = new System.Drawing.Size(350, 21);
            this.txtPlantName.TabIndex = 1;
            // 
            // lblPlantName
            // 
            this.lblPlantName.AutoSize = true;
            this.lblPlantName.Location = new System.Drawing.Point(3, 51);
            this.lblPlantName.Name = "lblPlantName";
            this.lblPlantName.Size = new System.Drawing.Size(52, 15);
            this.lblPlantName.TabIndex = 0;
            this.lblPlantName.Text = "Nombre";
            // 
            // grpbPlantList
            // 
            this.grpbPlantList.Controls.Add(this.btnPlantAdd);
            this.grpbPlantList.Controls.Add(this.btnPlantEdit);
            this.grpbPlantList.Controls.Add(this.btnPlantDelete);
            this.grpbPlantList.Controls.Add(this.dgvPlant);
            this.grpbPlantList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPlantList.Location = new System.Drawing.Point(0, 0);
            this.grpbPlantList.Name = "grpbPlantList";
            this.grpbPlantList.Size = new System.Drawing.Size(666, 253);
            this.grpbPlantList.TabIndex = 0;
            this.grpbPlantList.TabStop = false;
            // 
            // btnPlantAdd
            // 
            this.btnPlantAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnPlantAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlantAdd.Location = new System.Drawing.Point(584, 221);
            this.btnPlantAdd.Name = "btnPlantAdd";
            this.btnPlantAdd.Size = new System.Drawing.Size(25, 25);
            this.btnPlantAdd.TabIndex = 30;
            this.btnPlantAdd.UseVisualStyleBackColor = true;
            this.btnPlantAdd.Click += new System.EventHandler(this.btnPlantAdd_Click);
            // 
            // btnPlantEdit
            // 
            this.btnPlantEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnPlantEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlantEdit.Location = new System.Drawing.Point(610, 221);
            this.btnPlantEdit.Name = "btnPlantEdit";
            this.btnPlantEdit.Size = new System.Drawing.Size(25, 25);
            this.btnPlantEdit.TabIndex = 28;
            this.btnPlantEdit.UseVisualStyleBackColor = true;
            this.btnPlantEdit.Click += new System.EventHandler(this.btnPlantEdit_Click);
            // 
            // btnPlantDelete
            // 
            this.btnPlantDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnPlantDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlantDelete.Location = new System.Drawing.Point(636, 221);
            this.btnPlantDelete.Name = "btnPlantDelete";
            this.btnPlantDelete.Size = new System.Drawing.Size(25, 25);
            this.btnPlantDelete.TabIndex = 29;
            this.btnPlantDelete.UseVisualStyleBackColor = true;
            // 
            // dgvPlant
            // 
            this.dgvPlant.AllowUserToAddRows = false;
            this.dgvPlant.AllowUserToDeleteRows = false;
            this.dgvPlant.AllowUserToOrderColumns = true;
            this.dgvPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPlantCodsec,
            this.clmPlantName});
            this.dgvPlant.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPlant.Location = new System.Drawing.Point(3, 17);
            this.dgvPlant.Name = "dgvPlant";
            this.dgvPlant.ReadOnly = true;
            this.dgvPlant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlant.Size = new System.Drawing.Size(660, 198);
            this.dgvPlant.TabIndex = 0;
            // 
            // clmPlantCodsec
            // 
            this.clmPlantCodsec.HeaderText = "Codsec";
            this.clmPlantCodsec.Name = "clmPlantCodsec";
            this.clmPlantCodsec.ReadOnly = true;
            this.clmPlantCodsec.Visible = false;
            // 
            // clmPlantName
            // 
            this.clmPlantName.HeaderText = "Nombre";
            this.clmPlantName.Name = "clmPlantName";
            this.clmPlantName.ReadOnly = true;
            this.clmPlantName.Width = 350;
            // 
            // pnlIdType
            // 
            this.pnlIdType.Controls.Add(this.grpbidtypeForm);
            this.pnlIdType.Controls.Add(this.grpbidtypeList);
            this.pnlIdType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIdType.Location = new System.Drawing.Point(0, 0);
            this.pnlIdType.Name = "pnlIdType";
            this.pnlIdType.Size = new System.Drawing.Size(666, 524);
            this.pnlIdType.TabIndex = 1;
            // 
            // grpbidtypeForm
            // 
            this.grpbidtypeForm.Controls.Add(this.btnIdTypeCancel);
            this.grpbidtypeForm.Controls.Add(this.btnIdTypeSave);
            this.grpbidtypeForm.Controls.Add(this.txtIdtypeName);
            this.grpbidtypeForm.Controls.Add(this.lblIdtypeName);
            this.grpbidtypeForm.Location = new System.Drawing.Point(3, 253);
            this.grpbidtypeForm.Name = "grpbidtypeForm";
            this.grpbidtypeForm.Size = new System.Drawing.Size(658, 265);
            this.grpbidtypeForm.TabIndex = 1;
            this.grpbidtypeForm.TabStop = false;
            // 
            // btnIdTypeCancel
            // 
            this.btnIdTypeCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdTypeCancel.BackgroundImage")));
            this.btnIdTypeCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdTypeCancel.Location = new System.Drawing.Point(628, 233);
            this.btnIdTypeCancel.Name = "btnIdTypeCancel";
            this.btnIdTypeCancel.Size = new System.Drawing.Size(25, 25);
            this.btnIdTypeCancel.TabIndex = 39;
            this.btnIdTypeCancel.UseVisualStyleBackColor = true;
            this.btnIdTypeCancel.Click += new System.EventHandler(this.btnIdTypeCancel_Click);
            // 
            // btnIdTypeSave
            // 
            this.btnIdTypeSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdTypeSave.BackgroundImage")));
            this.btnIdTypeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdTypeSave.Location = new System.Drawing.Point(603, 233);
            this.btnIdTypeSave.Name = "btnIdTypeSave";
            this.btnIdTypeSave.Size = new System.Drawing.Size(25, 25);
            this.btnIdTypeSave.TabIndex = 38;
            this.btnIdTypeSave.UseVisualStyleBackColor = true;
            this.btnIdTypeSave.Click += new System.EventHandler(this.btnIdTypeSave_Click);
            // 
            // txtIdtypeName
            // 
            this.txtIdtypeName.Location = new System.Drawing.Point(79, 48);
            this.txtIdtypeName.Name = "txtIdtypeName";
            this.txtIdtypeName.Size = new System.Drawing.Size(300, 21);
            this.txtIdtypeName.TabIndex = 1;
            // 
            // lblIdtypeName
            // 
            this.lblIdtypeName.AutoSize = true;
            this.lblIdtypeName.Location = new System.Drawing.Point(3, 51);
            this.lblIdtypeName.Name = "lblIdtypeName";
            this.lblIdtypeName.Size = new System.Drawing.Size(52, 15);
            this.lblIdtypeName.TabIndex = 0;
            this.lblIdtypeName.Text = "Nombre";
            // 
            // grpbidtypeList
            // 
            this.grpbidtypeList.Controls.Add(this.btnIdTypeAdd);
            this.grpbidtypeList.Controls.Add(this.btnIdTypeEdit);
            this.grpbidtypeList.Controls.Add(this.btnIdTypeDelete);
            this.grpbidtypeList.Controls.Add(this.dgvIdType);
            this.grpbidtypeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbidtypeList.Location = new System.Drawing.Point(0, 0);
            this.grpbidtypeList.Name = "grpbidtypeList";
            this.grpbidtypeList.Size = new System.Drawing.Size(666, 253);
            this.grpbidtypeList.TabIndex = 0;
            this.grpbidtypeList.TabStop = false;
            // 
            // btnIdTypeAdd
            // 
            this.btnIdTypeAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdTypeAdd.BackgroundImage")));
            this.btnIdTypeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdTypeAdd.Location = new System.Drawing.Point(579, 221);
            this.btnIdTypeAdd.Name = "btnIdTypeAdd";
            this.btnIdTypeAdd.Size = new System.Drawing.Size(25, 25);
            this.btnIdTypeAdd.TabIndex = 30;
            this.btnIdTypeAdd.UseVisualStyleBackColor = true;
            this.btnIdTypeAdd.Click += new System.EventHandler(this.btnIdTypeAdd_Click);
            // 
            // btnIdTypeEdit
            // 
            this.btnIdTypeEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdTypeEdit.BackgroundImage")));
            this.btnIdTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdTypeEdit.Location = new System.Drawing.Point(605, 221);
            this.btnIdTypeEdit.Name = "btnIdTypeEdit";
            this.btnIdTypeEdit.Size = new System.Drawing.Size(25, 25);
            this.btnIdTypeEdit.TabIndex = 28;
            this.btnIdTypeEdit.UseVisualStyleBackColor = true;
            this.btnIdTypeEdit.Click += new System.EventHandler(this.btnIdTypeEdit_Click);
            // 
            // btnIdTypeDelete
            // 
            this.btnIdTypeDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdTypeDelete.BackgroundImage")));
            this.btnIdTypeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdTypeDelete.Location = new System.Drawing.Point(631, 221);
            this.btnIdTypeDelete.Name = "btnIdTypeDelete";
            this.btnIdTypeDelete.Size = new System.Drawing.Size(25, 25);
            this.btnIdTypeDelete.TabIndex = 29;
            this.btnIdTypeDelete.UseVisualStyleBackColor = true;
            // 
            // dgvIdType
            // 
            this.dgvIdType.AllowUserToAddRows = false;
            this.dgvIdType.AllowUserToDeleteRows = false;
            this.dgvIdType.AllowUserToOrderColumns = true;
            this.dgvIdType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdTypeCodsec,
            this.clmIdTypeName});
            this.dgvIdType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvIdType.Location = new System.Drawing.Point(3, 17);
            this.dgvIdType.Name = "dgvIdType";
            this.dgvIdType.ReadOnly = true;
            this.dgvIdType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIdType.Size = new System.Drawing.Size(660, 198);
            this.dgvIdType.TabIndex = 0;
            // 
            // clmIdTypeCodsec
            // 
            this.clmIdTypeCodsec.HeaderText = "Codsec";
            this.clmIdTypeCodsec.Name = "clmIdTypeCodsec";
            this.clmIdTypeCodsec.ReadOnly = true;
            this.clmIdTypeCodsec.Visible = false;
            // 
            // clmIdTypeName
            // 
            this.clmIdTypeName.HeaderText = "Nombre";
            this.clmIdTypeName.Name = "clmIdTypeName";
            this.clmIdTypeName.ReadOnly = true;
            this.clmIdTypeName.Width = 250;
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.Controls.Add(this.grpbLanguageForm);
            this.pnlLanguage.Controls.Add(this.grpbLanguageList);
            this.pnlLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLanguage.Location = new System.Drawing.Point(0, 0);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(666, 524);
            this.pnlLanguage.TabIndex = 1;
            // 
            // grpbLanguageForm
            // 
            this.grpbLanguageForm.Controls.Add(this.btnLanguageSave);
            this.grpbLanguageForm.Controls.Add(this.btnLanguageCancel);
            this.grpbLanguageForm.Controls.Add(this.txtLanguageAbbreviation);
            this.grpbLanguageForm.Controls.Add(this.txtLanguageName);
            this.grpbLanguageForm.Controls.Add(this.lblLanguageAbbreviation);
            this.grpbLanguageForm.Controls.Add(this.lblLanguageName);
            this.grpbLanguageForm.Location = new System.Drawing.Point(3, 253);
            this.grpbLanguageForm.Name = "grpbLanguageForm";
            this.grpbLanguageForm.Size = new System.Drawing.Size(660, 265);
            this.grpbLanguageForm.TabIndex = 1;
            this.grpbLanguageForm.TabStop = false;
            // 
            // btnLanguageSave
            // 
            this.btnLanguageSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLanguageSave.BackgroundImage")));
            this.btnLanguageSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLanguageSave.Location = new System.Drawing.Point(603, 232);
            this.btnLanguageSave.Name = "btnLanguageSave";
            this.btnLanguageSave.Size = new System.Drawing.Size(25, 25);
            this.btnLanguageSave.TabIndex = 3;
            this.btnLanguageSave.UseVisualStyleBackColor = true;
            this.btnLanguageSave.Click += new System.EventHandler(this.btnLanguageSave_Click);
            // 
            // btnLanguageCancel
            // 
            this.btnLanguageCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnLanguageCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLanguageCancel.Location = new System.Drawing.Point(628, 232);
            this.btnLanguageCancel.Name = "btnLanguageCancel";
            this.btnLanguageCancel.Size = new System.Drawing.Size(25, 25);
            this.btnLanguageCancel.TabIndex = 4;
            this.btnLanguageCancel.UseVisualStyleBackColor = true;
            this.btnLanguageCancel.Click += new System.EventHandler(this.btnLanguageCancel_Click);
            // 
            // txtLanguageAbbreviation
            // 
            this.txtLanguageAbbreviation.Location = new System.Drawing.Point(79, 72);
            this.txtLanguageAbbreviation.Name = "txtLanguageAbbreviation";
            this.txtLanguageAbbreviation.Size = new System.Drawing.Size(100, 21);
            this.txtLanguageAbbreviation.TabIndex = 2;
            // 
            // txtLanguageName
            // 
            this.txtLanguageName.Location = new System.Drawing.Point(79, 27);
            this.txtLanguageName.Name = "txtLanguageName";
            this.txtLanguageName.Size = new System.Drawing.Size(462, 21);
            this.txtLanguageName.TabIndex = 1;
            // 
            // lblLanguageAbbreviation
            // 
            this.lblLanguageAbbreviation.AutoSize = true;
            this.lblLanguageAbbreviation.Location = new System.Drawing.Point(3, 75);
            this.lblLanguageAbbreviation.Name = "lblLanguageAbbreviation";
            this.lblLanguageAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblLanguageAbbreviation.TabIndex = 1;
            this.lblLanguageAbbreviation.Text = "Abreviación";
            // 
            // lblLanguageName
            // 
            this.lblLanguageName.AutoSize = true;
            this.lblLanguageName.Location = new System.Drawing.Point(3, 30);
            this.lblLanguageName.Name = "lblLanguageName";
            this.lblLanguageName.Size = new System.Drawing.Size(52, 15);
            this.lblLanguageName.TabIndex = 0;
            this.lblLanguageName.Text = "Nombre";
            // 
            // grpbLanguageList
            // 
            this.grpbLanguageList.Controls.Add(this.btnLanguageAdd);
            this.grpbLanguageList.Controls.Add(this.btnLanguageEdit);
            this.grpbLanguageList.Controls.Add(this.btnLanguageDelete);
            this.grpbLanguageList.Controls.Add(this.dgvLanguage);
            this.grpbLanguageList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbLanguageList.Location = new System.Drawing.Point(0, 0);
            this.grpbLanguageList.Name = "grpbLanguageList";
            this.grpbLanguageList.Size = new System.Drawing.Size(666, 253);
            this.grpbLanguageList.TabIndex = 0;
            this.grpbLanguageList.TabStop = false;
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnLanguageAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLanguageAdd.Location = new System.Drawing.Point(584, 221);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(25, 25);
            this.btnLanguageAdd.TabIndex = 33;
            this.btnLanguageAdd.UseVisualStyleBackColor = true;
            this.btnLanguageAdd.Click += new System.EventHandler(this.btnLanguageAdd_Click);
            // 
            // btnLanguageEdit
            // 
            this.btnLanguageEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnLanguageEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLanguageEdit.Location = new System.Drawing.Point(610, 221);
            this.btnLanguageEdit.Name = "btnLanguageEdit";
            this.btnLanguageEdit.Size = new System.Drawing.Size(25, 25);
            this.btnLanguageEdit.TabIndex = 31;
            this.btnLanguageEdit.UseVisualStyleBackColor = true;
            this.btnLanguageEdit.Click += new System.EventHandler(this.btnLanguageEdit_Click);
            // 
            // btnLanguageDelete
            // 
            this.btnLanguageDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnLanguageDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLanguageDelete.Location = new System.Drawing.Point(636, 221);
            this.btnLanguageDelete.Name = "btnLanguageDelete";
            this.btnLanguageDelete.Size = new System.Drawing.Size(25, 25);
            this.btnLanguageDelete.TabIndex = 32;
            this.btnLanguageDelete.UseVisualStyleBackColor = true;
            // 
            // dgvLanguage
            // 
            this.dgvLanguage.AllowUserToAddRows = false;
            this.dgvLanguage.AllowUserToDeleteRows = false;
            this.dgvLanguage.AllowUserToOrderColumns = true;
            this.dgvLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLanguageCodsec,
            this.clmLanguageName,
            this.clmLanguageAbbreviation});
            this.dgvLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLanguage.Location = new System.Drawing.Point(3, 17);
            this.dgvLanguage.Name = "dgvLanguage";
            this.dgvLanguage.ReadOnly = true;
            this.dgvLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLanguage.Size = new System.Drawing.Size(660, 198);
            this.dgvLanguage.TabIndex = 0;
            // 
            // clmLanguageCodsec
            // 
            this.clmLanguageCodsec.HeaderText = "Codsec";
            this.clmLanguageCodsec.Name = "clmLanguageCodsec";
            this.clmLanguageCodsec.ReadOnly = true;
            this.clmLanguageCodsec.Visible = false;
            // 
            // clmLanguageName
            // 
            this.clmLanguageName.HeaderText = "Nombre";
            this.clmLanguageName.Name = "clmLanguageName";
            this.clmLanguageName.ReadOnly = true;
            // 
            // clmLanguageAbbreviation
            // 
            this.clmLanguageAbbreviation.HeaderText = "Abrev.";
            this.clmLanguageAbbreviation.Name = "clmLanguageAbbreviation";
            this.clmLanguageAbbreviation.ReadOnly = true;
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.grpbCurrencyForm);
            this.pnlCurrency.Controls.Add(this.grpbCurrencyList);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 0);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(666, 524);
            this.pnlCurrency.TabIndex = 1;
            // 
            // grpbCurrencyForm
            // 
            this.grpbCurrencyForm.Controls.Add(this.btnCurrencySave);
            this.grpbCurrencyForm.Controls.Add(this.btnCurrencyCancel);
            this.grpbCurrencyForm.Controls.Add(this.txtCurrencyDecimal);
            this.grpbCurrencyForm.Controls.Add(this.txtCurrencySymbol);
            this.grpbCurrencyForm.Controls.Add(this.txtCurrencyName);
            this.grpbCurrencyForm.Controls.Add(this.lblCurrencyDecimal);
            this.grpbCurrencyForm.Controls.Add(this.lblCurrencySymbol);
            this.grpbCurrencyForm.Controls.Add(this.lblCurrencyName);
            this.grpbCurrencyForm.Location = new System.Drawing.Point(3, 253);
            this.grpbCurrencyForm.Name = "grpbCurrencyForm";
            this.grpbCurrencyForm.Size = new System.Drawing.Size(659, 264);
            this.grpbCurrencyForm.TabIndex = 1;
            this.grpbCurrencyForm.TabStop = false;
            // 
            // btnCurrencySave
            // 
            this.btnCurrencySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurrencySave.BackgroundImage")));
            this.btnCurrencySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCurrencySave.Location = new System.Drawing.Point(601, 228);
            this.btnCurrencySave.Name = "btnCurrencySave";
            this.btnCurrencySave.Size = new System.Drawing.Size(25, 25);
            this.btnCurrencySave.TabIndex = 4;
            this.btnCurrencySave.UseVisualStyleBackColor = true;
            this.btnCurrencySave.Click += new System.EventHandler(this.btnCurrencySave_Click);
            // 
            // btnCurrencyCancel
            // 
            this.btnCurrencyCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCurrencyCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCurrencyCancel.Location = new System.Drawing.Point(626, 228);
            this.btnCurrencyCancel.Name = "btnCurrencyCancel";
            this.btnCurrencyCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCurrencyCancel.TabIndex = 5;
            this.btnCurrencyCancel.UseVisualStyleBackColor = true;
            this.btnCurrencyCancel.Click += new System.EventHandler(this.btnCurrencyCancel_Click);
            // 
            // txtCurrencyDecimal
            // 
            this.txtCurrencyDecimal.Location = new System.Drawing.Point(79, 102);
            this.txtCurrencyDecimal.Name = "txtCurrencyDecimal";
            this.txtCurrencyDecimal.Size = new System.Drawing.Size(100, 21);
            this.txtCurrencyDecimal.TabIndex = 3;
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.Location = new System.Drawing.Point(79, 63);
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(100, 21);
            this.txtCurrencySymbol.TabIndex = 2;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(79, 24);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(462, 21);
            this.txtCurrencyName.TabIndex = 1;
            // 
            // lblCurrencyDecimal
            // 
            this.lblCurrencyDecimal.AutoSize = true;
            this.lblCurrencyDecimal.Location = new System.Drawing.Point(3, 105);
            this.lblCurrencyDecimal.Name = "lblCurrencyDecimal";
            this.lblCurrencyDecimal.Size = new System.Drawing.Size(53, 15);
            this.lblCurrencyDecimal.TabIndex = 2;
            this.lblCurrencyDecimal.Text = "Decimal";
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(3, 66);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(53, 15);
            this.lblCurrencySymbol.TabIndex = 1;
            this.lblCurrencySymbol.Text = "Símbolo";
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.Location = new System.Drawing.Point(3, 27);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(52, 15);
            this.lblCurrencyName.TabIndex = 0;
            this.lblCurrencyName.Text = "Nombre";
            // 
            // grpbCurrencyList
            // 
            this.grpbCurrencyList.Controls.Add(this.btnCurrencyAdd);
            this.grpbCurrencyList.Controls.Add(this.btnCurrencyEdit);
            this.grpbCurrencyList.Controls.Add(this.btnCurrencyDelete);
            this.grpbCurrencyList.Controls.Add(this.dgvCurrency);
            this.grpbCurrencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCurrencyList.Location = new System.Drawing.Point(0, 0);
            this.grpbCurrencyList.Name = "grpbCurrencyList";
            this.grpbCurrencyList.Size = new System.Drawing.Size(666, 253);
            this.grpbCurrencyList.TabIndex = 0;
            this.grpbCurrencyList.TabStop = false;
            // 
            // btnCurrencyAdd
            // 
            this.btnCurrencyAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnCurrencyAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCurrencyAdd.Location = new System.Drawing.Point(577, 221);
            this.btnCurrencyAdd.Name = "btnCurrencyAdd";
            this.btnCurrencyAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCurrencyAdd.TabIndex = 30;
            this.btnCurrencyAdd.UseVisualStyleBackColor = true;
            this.btnCurrencyAdd.Click += new System.EventHandler(this.btnCurrencyAdd_Click);
            // 
            // btnCurrencyEdit
            // 
            this.btnCurrencyEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnCurrencyEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCurrencyEdit.Location = new System.Drawing.Point(603, 221);
            this.btnCurrencyEdit.Name = "btnCurrencyEdit";
            this.btnCurrencyEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCurrencyEdit.TabIndex = 28;
            this.btnCurrencyEdit.UseVisualStyleBackColor = true;
            this.btnCurrencyEdit.Click += new System.EventHandler(this.btnCurrencyEdit_Click);
            // 
            // btnCurrencyDelete
            // 
            this.btnCurrencyDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnCurrencyDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCurrencyDelete.Location = new System.Drawing.Point(629, 221);
            this.btnCurrencyDelete.Name = "btnCurrencyDelete";
            this.btnCurrencyDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCurrencyDelete.TabIndex = 29;
            this.btnCurrencyDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AllowUserToDeleteRows = false;
            this.dgvCurrency.AllowUserToOrderColumns = true;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCurrencyName,
            this.clmCurrencySymbol,
            this.clmCurrencyDecimal});
            this.dgvCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCurrency.Location = new System.Drawing.Point(3, 17);
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrency.Size = new System.Drawing.Size(660, 198);
            this.dgvCurrency.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCurrencyName
            // 
            this.clmCurrencyName.HeaderText = "Moneda";
            this.clmCurrencyName.Name = "clmCurrencyName";
            this.clmCurrencyName.ReadOnly = true;
            this.clmCurrencyName.Width = 200;
            // 
            // clmCurrencySymbol
            // 
            this.clmCurrencySymbol.HeaderText = "Simbolo";
            this.clmCurrencySymbol.Name = "clmCurrencySymbol";
            this.clmCurrencySymbol.ReadOnly = true;
            // 
            // clmCurrencyDecimal
            // 
            this.clmCurrencyDecimal.HeaderText = "Decimal";
            this.clmCurrencyDecimal.Name = "clmCurrencyDecimal";
            this.clmCurrencyDecimal.ReadOnly = true;
            // 
            // pnlGeographic
            // 
            this.pnlGeographic.Controls.Add(this.gpbInfoCity);
            this.pnlGeographic.Controls.Add(this.gpbInfoState);
            this.pnlGeographic.Controls.Add(this.gpbInfoCountry);
            this.pnlGeographic.Controls.Add(this.gpbActionsCity);
            this.pnlGeographic.Controls.Add(this.gpbActionsState);
            this.pnlGeographic.Controls.Add(this.gpbActionsCountry);
            this.pnlGeographic.Controls.Add(this.lblTitle);
            this.pnlGeographic.Controls.Add(this.LblCity);
            this.pnlGeographic.Controls.Add(this.lblState);
            this.pnlGeographic.Controls.Add(this.lblCountry);
            this.pnlGeographic.Controls.Add(this.lstbCity);
            this.pnlGeographic.Controls.Add(this.lstbState);
            this.pnlGeographic.Controls.Add(this.lstbCountry);
            this.pnlGeographic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeographic.Location = new System.Drawing.Point(0, 0);
            this.pnlGeographic.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGeographic.Name = "pnlGeographic";
            this.pnlGeographic.Size = new System.Drawing.Size(666, 524);
            this.pnlGeographic.TabIndex = 0;
            // 
            // gpbInfoCity
            // 
            this.gpbInfoCity.Controls.Add(this.btnCancelCity);
            this.gpbInfoCity.Controls.Add(this.txtCityName);
            this.gpbInfoCity.Controls.Add(this.label4);
            this.gpbInfoCity.Controls.Add(this.btnSaveCity);
            this.gpbInfoCity.Enabled = false;
            this.gpbInfoCity.Location = new System.Drawing.Point(375, 360);
            this.gpbInfoCity.Name = "gpbInfoCity";
            this.gpbInfoCity.Size = new System.Drawing.Size(173, 103);
            this.gpbInfoCity.TabIndex = 9;
            this.gpbInfoCity.TabStop = false;
            this.gpbInfoCity.Text = "Información";
            // 
            // btnCancelCity
            // 
            this.btnCancelCity.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelCity.Location = new System.Drawing.Point(142, 72);
            this.btnCancelCity.Name = "btnCancelCity";
            this.btnCancelCity.Size = new System.Drawing.Size(25, 25);
            this.btnCancelCity.TabIndex = 11;
            this.btnCancelCity.UseVisualStyleBackColor = true;
            this.btnCancelCity.Click += new System.EventHandler(this.btnCancelCity_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(67, 19);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 21);
            this.txtCityName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // btnSaveCity
            // 
            this.btnSaveCity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCity.BackgroundImage")));
            this.btnSaveCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveCity.Location = new System.Drawing.Point(117, 72);
            this.btnSaveCity.Name = "btnSaveCity";
            this.btnSaveCity.Size = new System.Drawing.Size(25, 25);
            this.btnSaveCity.TabIndex = 2;
            this.btnSaveCity.UseVisualStyleBackColor = true;
            this.btnSaveCity.Click += new System.EventHandler(this.btnSaveCity_Click);
            // 
            // gpbInfoState
            // 
            this.gpbInfoState.Controls.Add(this.btnCancelState);
            this.gpbInfoState.Controls.Add(this.txtStateName);
            this.gpbInfoState.Controls.Add(this.label3);
            this.gpbInfoState.Controls.Add(this.btnSaveState);
            this.gpbInfoState.Enabled = false;
            this.gpbInfoState.Location = new System.Drawing.Point(196, 360);
            this.gpbInfoState.Name = "gpbInfoState";
            this.gpbInfoState.Size = new System.Drawing.Size(173, 103);
            this.gpbInfoState.TabIndex = 8;
            this.gpbInfoState.TabStop = false;
            this.gpbInfoState.Text = "Información";
            // 
            // btnCancelState
            // 
            this.btnCancelState.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelState.Location = new System.Drawing.Point(142, 72);
            this.btnCancelState.Name = "btnCancelState";
            this.btnCancelState.Size = new System.Drawing.Size(25, 25);
            this.btnCancelState.TabIndex = 7;
            this.btnCancelState.UseVisualStyleBackColor = true;
            this.btnCancelState.Click += new System.EventHandler(this.btnCancelState_Click);
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(67, 19);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(100, 21);
            this.txtStateName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // btnSaveState
            // 
            this.btnSaveState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveState.BackgroundImage")));
            this.btnSaveState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveState.Location = new System.Drawing.Point(117, 72);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(25, 25);
            this.btnSaveState.TabIndex = 2;
            this.btnSaveState.UseVisualStyleBackColor = true;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // gpbInfoCountry
            // 
            this.gpbInfoCountry.Controls.Add(this.btnCancelCountry);
            this.gpbInfoCountry.Controls.Add(this.txtcountryAbbreviation);
            this.gpbInfoCountry.Controls.Add(this.txtCountryName);
            this.gpbInfoCountry.Controls.Add(this.label2);
            this.gpbInfoCountry.Controls.Add(this.label1);
            this.gpbInfoCountry.Controls.Add(this.btnSaveCountry);
            this.gpbInfoCountry.Enabled = false;
            this.gpbInfoCountry.Location = new System.Drawing.Point(15, 360);
            this.gpbInfoCountry.Name = "gpbInfoCountry";
            this.gpbInfoCountry.Size = new System.Drawing.Size(173, 103);
            this.gpbInfoCountry.TabIndex = 7;
            this.gpbInfoCountry.TabStop = false;
            this.gpbInfoCountry.Text = "Información";
            // 
            // btnCancelCountry
            // 
            this.btnCancelCountry.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelCountry.Location = new System.Drawing.Point(142, 72);
            this.btnCancelCountry.Name = "btnCancelCountry";
            this.btnCancelCountry.Size = new System.Drawing.Size(25, 25);
            this.btnCancelCountry.TabIndex = 6;
            this.btnCancelCountry.UseVisualStyleBackColor = true;
            this.btnCancelCountry.Click += new System.EventHandler(this.btnCancelCountry_Click);
            // 
            // txtcountryAbbreviation
            // 
            this.txtcountryAbbreviation.Location = new System.Drawing.Point(117, 46);
            this.txtcountryAbbreviation.Name = "txtcountryAbbreviation";
            this.txtcountryAbbreviation.Size = new System.Drawing.Size(50, 21);
            this.txtcountryAbbreviation.TabIndex = 5;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(67, 19);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 21);
            this.txtCountryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abreviatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnSaveCountry
            // 
            this.btnSaveCountry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCountry.BackgroundImage")));
            this.btnSaveCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveCountry.Location = new System.Drawing.Point(117, 72);
            this.btnSaveCountry.Name = "btnSaveCountry";
            this.btnSaveCountry.Size = new System.Drawing.Size(25, 25);
            this.btnSaveCountry.TabIndex = 1;
            this.btnSaveCountry.UseVisualStyleBackColor = true;
            this.btnSaveCountry.Click += new System.EventHandler(this.btnSaveCountry_Click);
            // 
            // gpbActionsCity
            // 
            this.gpbActionsCity.Controls.Add(this.btnDeleteCity);
            this.gpbActionsCity.Controls.Add(this.btnEditCity);
            this.gpbActionsCity.Controls.Add(this.btnAddCity);
            this.gpbActionsCity.Location = new System.Drawing.Point(375, 454);
            this.gpbActionsCity.Name = "gpbActionsCity";
            this.gpbActionsCity.Size = new System.Drawing.Size(173, 52);
            this.gpbActionsCity.TabIndex = 15;
            this.gpbActionsCity.TabStop = false;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDeleteCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCity.Location = new System.Drawing.Point(142, 15);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteCity.TabIndex = 8;
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            // 
            // btnEditCity
            // 
            this.btnEditCity.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCity.Location = new System.Drawing.Point(117, 15);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(25, 25);
            this.btnEditCity.TabIndex = 7;
            this.btnEditCity.UseVisualStyleBackColor = true;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCity.Location = new System.Drawing.Point(92, 15);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(25, 25);
            this.btnAddCity.TabIndex = 6;
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // gpbActionsState
            // 
            this.gpbActionsState.Controls.Add(this.btnDeleteState);
            this.gpbActionsState.Controls.Add(this.btnEditState);
            this.gpbActionsState.Controls.Add(this.btnAddState);
            this.gpbActionsState.Location = new System.Drawing.Point(196, 454);
            this.gpbActionsState.Name = "gpbActionsState";
            this.gpbActionsState.Size = new System.Drawing.Size(173, 52);
            this.gpbActionsState.TabIndex = 14;
            this.gpbActionsState.TabStop = false;
            // 
            // btnDeleteState
            // 
            this.btnDeleteState.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDeleteState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteState.Location = new System.Drawing.Point(142, 15);
            this.btnDeleteState.Name = "btnDeleteState";
            this.btnDeleteState.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteState.TabIndex = 8;
            this.btnDeleteState.UseVisualStyleBackColor = true;
            // 
            // btnEditState
            // 
            this.btnEditState.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditState.Location = new System.Drawing.Point(117, 15);
            this.btnEditState.Name = "btnEditState";
            this.btnEditState.Size = new System.Drawing.Size(25, 25);
            this.btnEditState.TabIndex = 7;
            this.btnEditState.UseVisualStyleBackColor = true;
            this.btnEditState.Click += new System.EventHandler(this.btnEditState_Click);
            // 
            // btnAddState
            // 
            this.btnAddState.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddState.Location = new System.Drawing.Point(92, 15);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(25, 25);
            this.btnAddState.TabIndex = 6;
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // gpbActionsCountry
            // 
            this.gpbActionsCountry.Controls.Add(this.btnDeleteCountry);
            this.gpbActionsCountry.Controls.Add(this.btnEditCountry);
            this.gpbActionsCountry.Controls.Add(this.btnAddCountry);
            this.gpbActionsCountry.Location = new System.Drawing.Point(15, 454);
            this.gpbActionsCountry.Name = "gpbActionsCountry";
            this.gpbActionsCountry.Size = new System.Drawing.Size(173, 52);
            this.gpbActionsCountry.TabIndex = 13;
            this.gpbActionsCountry.TabStop = false;
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDeleteCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCountry.Location = new System.Drawing.Point(142, 15);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteCountry.TabIndex = 2;
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCountry.Location = new System.Drawing.Point(117, 15);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(25, 25);
            this.btnEditCountry.TabIndex = 1;
            this.btnEditCountry.UseVisualStyleBackColor = true;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCountry.Location = new System.Drawing.Point(92, 15);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(25, 25);
            this.btnAddCountry.TabIndex = 0;
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Información geográfica";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(371, 55);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(46, 15);
            this.LblCity.TabIndex = 5;
            this.LblCity.Text = "Ciudad";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(192, 55);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(142, 15);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "Provincia /Departamento";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(11, 55);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 15);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "País";
            // 
            // lstbCity
            // 
            this.lstbCity.FormattingEnabled = true;
            this.lstbCity.ItemHeight = 15;
            this.lstbCity.Location = new System.Drawing.Point(374, 74);
            this.lstbCity.Margin = new System.Windows.Forms.Padding(4);
            this.lstbCity.Name = "lstbCity";
            this.lstbCity.Size = new System.Drawing.Size(172, 244);
            this.lstbCity.TabIndex = 2;
            this.lstbCity.SelectedIndexChanged += new System.EventHandler(this.lstbCity_SelectedIndexChanged);
            // 
            // lstbState
            // 
            this.lstbState.FormattingEnabled = true;
            this.lstbState.ItemHeight = 15;
            this.lstbState.Location = new System.Drawing.Point(195, 74);
            this.lstbState.Margin = new System.Windows.Forms.Padding(4);
            this.lstbState.Name = "lstbState";
            this.lstbState.Size = new System.Drawing.Size(172, 244);
            this.lstbState.TabIndex = 1;
            this.lstbState.SelectedIndexChanged += new System.EventHandler(this.lstbState_SelectedIndexChanged);
            // 
            // lstbCountry
            // 
            this.lstbCountry.FormattingEnabled = true;
            this.lstbCountry.ItemHeight = 15;
            this.lstbCountry.Location = new System.Drawing.Point(15, 74);
            this.lstbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.lstbCountry.Name = "lstbCountry";
            this.lstbCountry.Size = new System.Drawing.Size(172, 244);
            this.lstbCountry.TabIndex = 0;
            this.lstbCountry.SelectedIndexChanged += new System.EventHandler(this.lstbCountry_SelectedIndexChanged);
            // 
            // pnlCoiler
            // 
            this.pnlCoiler.Controls.Add(this.grpbCoilers);
            this.pnlCoiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoiler.Location = new System.Drawing.Point(0, 0);
            this.pnlCoiler.Name = "pnlCoiler";
            this.pnlCoiler.Size = new System.Drawing.Size(666, 524);
            this.pnlCoiler.TabIndex = 1;
            // 
            // grpbCoilers
            // 
            this.grpbCoilers.Controls.Add(this.dgvCoilers);
            this.grpbCoilers.Controls.Add(this.btnSaveCoiler);
            this.grpbCoilers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoilers.Location = new System.Drawing.Point(0, 0);
            this.grpbCoilers.Name = "grpbCoilers";
            this.grpbCoilers.Size = new System.Drawing.Size(666, 524);
            this.grpbCoilers.TabIndex = 1;
            this.grpbCoilers.TabStop = false;
            // 
            // dgvCoilers
            // 
            this.dgvCoilers.AllowUserToAddRows = false;
            this.dgvCoilers.AllowUserToDeleteRows = false;
            this.dgvCoilers.AllowUserToOrderColumns = true;
            this.dgvCoilers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilerExtruderCodsec,
            this.clmCoilerMachineName,
            this.clmCoilerNumber});
            this.dgvCoilers.Location = new System.Drawing.Point(145, 163);
            this.dgvCoilers.Name = "dgvCoilers";
            this.dgvCoilers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCoilers.Size = new System.Drawing.Size(377, 198);
            this.dgvCoilers.TabIndex = 39;
            // 
            // clmCoilerExtruderCodsec
            // 
            this.clmCoilerExtruderCodsec.HeaderText = "extruderCodsec";
            this.clmCoilerExtruderCodsec.Name = "clmCoilerExtruderCodsec";
            this.clmCoilerExtruderCodsec.ReadOnly = true;
            this.clmCoilerExtruderCodsec.Visible = false;
            // 
            // clmCoilerMachineName
            // 
            this.clmCoilerMachineName.HeaderText = "Nombre";
            this.clmCoilerMachineName.Name = "clmCoilerMachineName";
            this.clmCoilerMachineName.Width = 150;
            // 
            // clmCoilerNumber
            // 
            this.clmCoilerNumber.HeaderText = "Número Bobina";
            this.clmCoilerNumber.Name = "clmCoilerNumber";
            this.clmCoilerNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCoilerNumber.Width = 150;
            // 
            // btnSaveCoiler
            // 
            this.btnSaveCoiler.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSaveCoiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveCoiler.Location = new System.Drawing.Point(497, 369);
            this.btnSaveCoiler.Name = "btnSaveCoiler";
            this.btnSaveCoiler.Size = new System.Drawing.Size(25, 25);
            this.btnSaveCoiler.TabIndex = 38;
            this.btnSaveCoiler.UseVisualStyleBackColor = true;
            this.btnSaveCoiler.Click += new System.EventHandler(this.btnSaveCoiler_Click);
            // 
            // pnlPackagingType
            // 
            this.pnlPackagingType.Controls.Add(this.grpbPackagingForm);
            this.pnlPackagingType.Controls.Add(this.grpbPackagingList);
            this.pnlPackagingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPackagingType.Location = new System.Drawing.Point(0, 0);
            this.pnlPackagingType.Name = "pnlPackagingType";
            this.pnlPackagingType.Size = new System.Drawing.Size(666, 524);
            this.pnlPackagingType.TabIndex = 1;
            // 
            // grpbPackagingForm
            // 
            this.grpbPackagingForm.Controls.Add(this.cmbPackagingTypeUnit);
            this.grpbPackagingForm.Controls.Add(this.lblPackagingTypeUnit);
            this.grpbPackagingForm.Controls.Add(this.btnPackagingTypeCancel);
            this.grpbPackagingForm.Controls.Add(this.btnPackagingTypeSave);
            this.grpbPackagingForm.Controls.Add(this.txtPackagingTypeInitial);
            this.grpbPackagingForm.Controls.Add(this.txtPackagingTypeName);
            this.grpbPackagingForm.Controls.Add(this.lblPackagingTypeInitial);
            this.grpbPackagingForm.Controls.Add(this.lblPackagingTypeName);
            this.grpbPackagingForm.Location = new System.Drawing.Point(3, 253);
            this.grpbPackagingForm.Name = "grpbPackagingForm";
            this.grpbPackagingForm.Size = new System.Drawing.Size(660, 264);
            this.grpbPackagingForm.TabIndex = 1;
            this.grpbPackagingForm.TabStop = false;
            // 
            // cmbPackagingTypeUnit
            // 
            this.cmbPackagingTypeUnit.FormattingEnabled = true;
            this.cmbPackagingTypeUnit.Location = new System.Drawing.Point(83, 125);
            this.cmbPackagingTypeUnit.Name = "cmbPackagingTypeUnit";
            this.cmbPackagingTypeUnit.Size = new System.Drawing.Size(121, 23);
            this.cmbPackagingTypeUnit.TabIndex = 3;
            // 
            // lblPackagingTypeUnit
            // 
            this.lblPackagingTypeUnit.AutoSize = true;
            this.lblPackagingTypeUnit.Location = new System.Drawing.Point(3, 127);
            this.lblPackagingTypeUnit.Name = "lblPackagingTypeUnit";
            this.lblPackagingTypeUnit.Size = new System.Drawing.Size(47, 15);
            this.lblPackagingTypeUnit.TabIndex = 46;
            this.lblPackagingTypeUnit.Text = "Unidad";
            // 
            // btnPackagingTypeCancel
            // 
            this.btnPackagingTypeCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnPackagingTypeCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackagingTypeCancel.Location = new System.Drawing.Point(628, 233);
            this.btnPackagingTypeCancel.Name = "btnPackagingTypeCancel";
            this.btnPackagingTypeCancel.Size = new System.Drawing.Size(25, 25);
            this.btnPackagingTypeCancel.TabIndex = 45;
            this.btnPackagingTypeCancel.UseVisualStyleBackColor = true;
            this.btnPackagingTypeCancel.Click += new System.EventHandler(this.btnPackagingTypeCancel_Click);
            // 
            // btnPackagingTypeSave
            // 
            this.btnPackagingTypeSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPackagingTypeSave.BackgroundImage")));
            this.btnPackagingTypeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackagingTypeSave.Location = new System.Drawing.Point(603, 233);
            this.btnPackagingTypeSave.Name = "btnPackagingTypeSave";
            this.btnPackagingTypeSave.Size = new System.Drawing.Size(25, 25);
            this.btnPackagingTypeSave.TabIndex = 44;
            this.btnPackagingTypeSave.UseVisualStyleBackColor = true;
            this.btnPackagingTypeSave.Click += new System.EventHandler(this.btnPackagingTypeSave_Click);
            // 
            // txtPackagingTypeInitial
            // 
            this.txtPackagingTypeInitial.Location = new System.Drawing.Point(83, 85);
            this.txtPackagingTypeInitial.Name = "txtPackagingTypeInitial";
            this.txtPackagingTypeInitial.Size = new System.Drawing.Size(121, 21);
            this.txtPackagingTypeInitial.TabIndex = 2;
            // 
            // txtPackagingTypeName
            // 
            this.txtPackagingTypeName.Location = new System.Drawing.Point(83, 43);
            this.txtPackagingTypeName.Name = "txtPackagingTypeName";
            this.txtPackagingTypeName.Size = new System.Drawing.Size(121, 21);
            this.txtPackagingTypeName.TabIndex = 1;
            // 
            // lblPackagingTypeInitial
            // 
            this.lblPackagingTypeInitial.AutoSize = true;
            this.lblPackagingTypeInitial.Location = new System.Drawing.Point(3, 85);
            this.lblPackagingTypeInitial.Name = "lblPackagingTypeInitial";
            this.lblPackagingTypeInitial.Size = new System.Drawing.Size(39, 15);
            this.lblPackagingTypeInitial.TabIndex = 1;
            this.lblPackagingTypeInitial.Text = "Inicial";
            // 
            // lblPackagingTypeName
            // 
            this.lblPackagingTypeName.AutoSize = true;
            this.lblPackagingTypeName.Location = new System.Drawing.Point(3, 43);
            this.lblPackagingTypeName.Name = "lblPackagingTypeName";
            this.lblPackagingTypeName.Size = new System.Drawing.Size(52, 15);
            this.lblPackagingTypeName.TabIndex = 0;
            this.lblPackagingTypeName.Text = "Nombre";
            // 
            // grpbPackagingList
            // 
            this.grpbPackagingList.Controls.Add(this.btnPackagingTypeAdd);
            this.grpbPackagingList.Controls.Add(this.btnPackagingTypeEdit);
            this.grpbPackagingList.Controls.Add(this.btnPackagingTypeDelete);
            this.grpbPackagingList.Controls.Add(this.dgvPackagingType);
            this.grpbPackagingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPackagingList.Location = new System.Drawing.Point(0, 0);
            this.grpbPackagingList.Name = "grpbPackagingList";
            this.grpbPackagingList.Size = new System.Drawing.Size(666, 253);
            this.grpbPackagingList.TabIndex = 0;
            this.grpbPackagingList.TabStop = false;
            // 
            // btnPackagingTypeAdd
            // 
            this.btnPackagingTypeAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPackagingTypeAdd.BackgroundImage")));
            this.btnPackagingTypeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackagingTypeAdd.Location = new System.Drawing.Point(579, 222);
            this.btnPackagingTypeAdd.Name = "btnPackagingTypeAdd";
            this.btnPackagingTypeAdd.Size = new System.Drawing.Size(25, 25);
            this.btnPackagingTypeAdd.TabIndex = 51;
            this.btnPackagingTypeAdd.UseVisualStyleBackColor = true;
            this.btnPackagingTypeAdd.Click += new System.EventHandler(this.btnPackagingTypeAdd_Click);
            // 
            // btnPackagingTypeEdit
            // 
            this.btnPackagingTypeEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPackagingTypeEdit.BackgroundImage")));
            this.btnPackagingTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackagingTypeEdit.Location = new System.Drawing.Point(605, 222);
            this.btnPackagingTypeEdit.Name = "btnPackagingTypeEdit";
            this.btnPackagingTypeEdit.Size = new System.Drawing.Size(25, 25);
            this.btnPackagingTypeEdit.TabIndex = 49;
            this.btnPackagingTypeEdit.UseVisualStyleBackColor = true;
            this.btnPackagingTypeEdit.Click += new System.EventHandler(this.btnPackagingTypeEdit_Click);
            // 
            // btnPackagingTypeDelete
            // 
            this.btnPackagingTypeDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPackagingTypeDelete.BackgroundImage")));
            this.btnPackagingTypeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackagingTypeDelete.Location = new System.Drawing.Point(631, 222);
            this.btnPackagingTypeDelete.Name = "btnPackagingTypeDelete";
            this.btnPackagingTypeDelete.Size = new System.Drawing.Size(25, 25);
            this.btnPackagingTypeDelete.TabIndex = 50;
            this.btnPackagingTypeDelete.UseVisualStyleBackColor = true;
            // 
            // dgvPackagingType
            // 
            this.dgvPackagingType.AllowUserToAddRows = false;
            this.dgvPackagingType.AllowUserToDeleteRows = false;
            this.dgvPackagingType.AllowUserToOrderColumns = true;
            this.dgvPackagingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagingType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPackagingTypeCodsec,
            this.clmPackagingTypeName,
            this.clmPackagingTypeUnit,
            this.clmPackagingTypeInitial});
            this.dgvPackagingType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPackagingType.Location = new System.Drawing.Point(3, 17);
            this.dgvPackagingType.Name = "dgvPackagingType";
            this.dgvPackagingType.ReadOnly = true;
            this.dgvPackagingType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackagingType.Size = new System.Drawing.Size(660, 198);
            this.dgvPackagingType.TabIndex = 0;
            // 
            // clmPackagingTypeCodsec
            // 
            this.clmPackagingTypeCodsec.HeaderText = "Codsec";
            this.clmPackagingTypeCodsec.Name = "clmPackagingTypeCodsec";
            this.clmPackagingTypeCodsec.ReadOnly = true;
            this.clmPackagingTypeCodsec.Visible = false;
            // 
            // clmPackagingTypeName
            // 
            this.clmPackagingTypeName.HeaderText = "Nombre";
            this.clmPackagingTypeName.Name = "clmPackagingTypeName";
            this.clmPackagingTypeName.ReadOnly = true;
            this.clmPackagingTypeName.Width = 250;
            // 
            // clmPackagingTypeUnit
            // 
            this.clmPackagingTypeUnit.HeaderText = "Unidad";
            this.clmPackagingTypeUnit.Name = "clmPackagingTypeUnit";
            this.clmPackagingTypeUnit.ReadOnly = true;
            // 
            // clmPackagingTypeInitial
            // 
            this.clmPackagingTypeInitial.HeaderText = "Inicial";
            this.clmPackagingTypeInitial.Name = "clmPackagingTypeInitial";
            this.clmPackagingTypeInitial.ReadOnly = true;
            // 
            // pnlTypeMainCoil
            // 
            this.pnlTypeMainCoil.Controls.Add(this.grpbMainCoilTypeForm);
            this.pnlTypeMainCoil.Controls.Add(this.grpbMainCoilTypeList);
            this.pnlTypeMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTypeMainCoil.Location = new System.Drawing.Point(0, 0);
            this.pnlTypeMainCoil.Name = "pnlTypeMainCoil";
            this.pnlTypeMainCoil.Size = new System.Drawing.Size(666, 524);
            this.pnlTypeMainCoil.TabIndex = 1;
            // 
            // grpbMainCoilTypeForm
            // 
            this.grpbMainCoilTypeForm.Controls.Add(this.btnMainCoilTypeCancel);
            this.grpbMainCoilTypeForm.Controls.Add(this.btnMainCoilTypeSave);
            this.grpbMainCoilTypeForm.Controls.Add(this.txtMainCoilTypeDescription);
            this.grpbMainCoilTypeForm.Controls.Add(this.txtMainCoilTypeName);
            this.grpbMainCoilTypeForm.Controls.Add(this.lblMainCoilTypeDescription);
            this.grpbMainCoilTypeForm.Controls.Add(this.lblMainCoilTypeName);
            this.grpbMainCoilTypeForm.Location = new System.Drawing.Point(0, 253);
            this.grpbMainCoilTypeForm.Name = "grpbMainCoilTypeForm";
            this.grpbMainCoilTypeForm.Size = new System.Drawing.Size(666, 267);
            this.grpbMainCoilTypeForm.TabIndex = 1;
            this.grpbMainCoilTypeForm.TabStop = false;
            // 
            // btnMainCoilTypeCancel
            // 
            this.btnMainCoilTypeCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilTypeCancel.BackgroundImage")));
            this.btnMainCoilTypeCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilTypeCancel.Location = new System.Drawing.Point(627, 236);
            this.btnMainCoilTypeCancel.Name = "btnMainCoilTypeCancel";
            this.btnMainCoilTypeCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilTypeCancel.TabIndex = 44;
            this.btnMainCoilTypeCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilTypeCancel.Click += new System.EventHandler(this.btnMainCoilTypeCancel_Click);
            // 
            // btnMainCoilTypeSave
            // 
            this.btnMainCoilTypeSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilTypeSave.BackgroundImage")));
            this.btnMainCoilTypeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilTypeSave.Location = new System.Drawing.Point(602, 236);
            this.btnMainCoilTypeSave.Name = "btnMainCoilTypeSave";
            this.btnMainCoilTypeSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilTypeSave.TabIndex = 43;
            this.btnMainCoilTypeSave.UseVisualStyleBackColor = true;
            this.btnMainCoilTypeSave.Click += new System.EventHandler(this.btnMainCoilTypeSave_Click);
            // 
            // txtMainCoilTypeDescription
            // 
            this.txtMainCoilTypeDescription.Location = new System.Drawing.Point(79, 48);
            this.txtMainCoilTypeDescription.Name = "txtMainCoilTypeDescription";
            this.txtMainCoilTypeDescription.Size = new System.Drawing.Size(350, 21);
            this.txtMainCoilTypeDescription.TabIndex = 3;
            // 
            // txtMainCoilTypeName
            // 
            this.txtMainCoilTypeName.Location = new System.Drawing.Point(79, 14);
            this.txtMainCoilTypeName.Name = "txtMainCoilTypeName";
            this.txtMainCoilTypeName.Size = new System.Drawing.Size(200, 21);
            this.txtMainCoilTypeName.TabIndex = 2;
            // 
            // lblMainCoilTypeDescription
            // 
            this.lblMainCoilTypeDescription.AutoSize = true;
            this.lblMainCoilTypeDescription.Location = new System.Drawing.Point(3, 51);
            this.lblMainCoilTypeDescription.Name = "lblMainCoilTypeDescription";
            this.lblMainCoilTypeDescription.Size = new System.Drawing.Size(72, 15);
            this.lblMainCoilTypeDescription.TabIndex = 1;
            this.lblMainCoilTypeDescription.Text = "Descripción";
            // 
            // lblMainCoilTypeName
            // 
            this.lblMainCoilTypeName.AutoSize = true;
            this.lblMainCoilTypeName.Location = new System.Drawing.Point(3, 17);
            this.lblMainCoilTypeName.Name = "lblMainCoilTypeName";
            this.lblMainCoilTypeName.Size = new System.Drawing.Size(52, 15);
            this.lblMainCoilTypeName.TabIndex = 0;
            this.lblMainCoilTypeName.Text = "Nombre";
            // 
            // grpbMainCoilTypeList
            // 
            this.grpbMainCoilTypeList.Controls.Add(this.btnMainCoilTypeDelete);
            this.grpbMainCoilTypeList.Controls.Add(this.btnMainCoilTypeAdd);
            this.grpbMainCoilTypeList.Controls.Add(this.btnMainCoilTypeEdit);
            this.grpbMainCoilTypeList.Controls.Add(this.dgvMainCoilType);
            this.grpbMainCoilTypeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMainCoilTypeList.Location = new System.Drawing.Point(0, 0);
            this.grpbMainCoilTypeList.Name = "grpbMainCoilTypeList";
            this.grpbMainCoilTypeList.Size = new System.Drawing.Size(666, 253);
            this.grpbMainCoilTypeList.TabIndex = 0;
            this.grpbMainCoilTypeList.TabStop = false;
            // 
            // btnMainCoilTypeDelete
            // 
            this.btnMainCoilTypeDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnMainCoilTypeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilTypeDelete.Location = new System.Drawing.Point(630, 221);
            this.btnMainCoilTypeDelete.Name = "btnMainCoilTypeDelete";
            this.btnMainCoilTypeDelete.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilTypeDelete.TabIndex = 47;
            this.btnMainCoilTypeDelete.UseVisualStyleBackColor = true;
            // 
            // btnMainCoilTypeAdd
            // 
            this.btnMainCoilTypeAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnMainCoilTypeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilTypeAdd.Location = new System.Drawing.Point(578, 221);
            this.btnMainCoilTypeAdd.Name = "btnMainCoilTypeAdd";
            this.btnMainCoilTypeAdd.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilTypeAdd.TabIndex = 45;
            this.btnMainCoilTypeAdd.UseVisualStyleBackColor = true;
            this.btnMainCoilTypeAdd.Click += new System.EventHandler(this.btnMainCoilTypeAdd_Click);
            // 
            // btnMainCoilTypeEdit
            // 
            this.btnMainCoilTypeEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnMainCoilTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilTypeEdit.Location = new System.Drawing.Point(604, 221);
            this.btnMainCoilTypeEdit.Name = "btnMainCoilTypeEdit";
            this.btnMainCoilTypeEdit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilTypeEdit.TabIndex = 46;
            this.btnMainCoilTypeEdit.UseVisualStyleBackColor = true;
            this.btnMainCoilTypeEdit.Click += new System.EventHandler(this.btnMainCoilTypeEdit_Click);
            // 
            // dgvMainCoilType
            // 
            this.dgvMainCoilType.AllowUserToAddRows = false;
            this.dgvMainCoilType.AllowUserToDeleteRows = false;
            this.dgvMainCoilType.AllowUserToOrderColumns = true;
            this.dgvMainCoilType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilTypeCodsec,
            this.clmMainCoilTypeName,
            this.clmMainCoilTypeDescription});
            this.dgvMainCoilType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMainCoilType.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilType.Name = "dgvMainCoilType";
            this.dgvMainCoilType.ReadOnly = true;
            this.dgvMainCoilType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilType.Size = new System.Drawing.Size(660, 198);
            this.dgvMainCoilType.TabIndex = 0;
            // 
            // clmMainCoilTypeCodsec
            // 
            this.clmMainCoilTypeCodsec.HeaderText = "Codsec";
            this.clmMainCoilTypeCodsec.Name = "clmMainCoilTypeCodsec";
            this.clmMainCoilTypeCodsec.ReadOnly = true;
            this.clmMainCoilTypeCodsec.Visible = false;
            // 
            // clmMainCoilTypeName
            // 
            this.clmMainCoilTypeName.HeaderText = "Nombre";
            this.clmMainCoilTypeName.Name = "clmMainCoilTypeName";
            this.clmMainCoilTypeName.ReadOnly = true;
            this.clmMainCoilTypeName.Width = 150;
            // 
            // clmMainCoilTypeDescription
            // 
            this.clmMainCoilTypeDescription.HeaderText = "Descripción";
            this.clmMainCoilTypeDescription.Name = "clmMainCoilTypeDescription";
            this.clmMainCoilTypeDescription.ReadOnly = true;
            this.clmMainCoilTypeDescription.Width = 350;
            // 
            // pnlDecrease
            // 
            this.pnlDecrease.Controls.Add(this.grpbDecreasForm);
            this.pnlDecrease.Controls.Add(this.grpbDecreasList);
            this.pnlDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDecrease.Location = new System.Drawing.Point(0, 0);
            this.pnlDecrease.Name = "pnlDecrease";
            this.pnlDecrease.Size = new System.Drawing.Size(666, 524);
            this.pnlDecrease.TabIndex = 1;
            // 
            // grpbDecreasForm
            // 
            this.grpbDecreasForm.Controls.Add(this.btnDecreaseCancel);
            this.grpbDecreasForm.Controls.Add(this.btnDecreaseSave);
            this.grpbDecreasForm.Controls.Add(this.txtDecreaseDescription);
            this.grpbDecreasForm.Controls.Add(this.txtDecreaseName);
            this.grpbDecreasForm.Controls.Add(this.lblDecreaseDescription);
            this.grpbDecreasForm.Controls.Add(this.lblDecreaseName);
            this.grpbDecreasForm.Location = new System.Drawing.Point(0, 253);
            this.grpbDecreasForm.Name = "grpbDecreasForm";
            this.grpbDecreasForm.Size = new System.Drawing.Size(666, 267);
            this.grpbDecreasForm.TabIndex = 1;
            this.grpbDecreasForm.TabStop = false;
            // 
            // btnDecreaseCancel
            // 
            this.btnDecreaseCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseCancel.BackgroundImage")));
            this.btnDecreaseCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseCancel.Location = new System.Drawing.Point(627, 236);
            this.btnDecreaseCancel.Name = "btnDecreaseCancel";
            this.btnDecreaseCancel.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseCancel.TabIndex = 42;
            this.btnDecreaseCancel.UseVisualStyleBackColor = true;
            this.btnDecreaseCancel.Click += new System.EventHandler(this.btnDecreaseCancel_Click);
            // 
            // btnDecreaseSave
            // 
            this.btnDecreaseSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseSave.BackgroundImage")));
            this.btnDecreaseSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseSave.Location = new System.Drawing.Point(602, 236);
            this.btnDecreaseSave.Name = "btnDecreaseSave";
            this.btnDecreaseSave.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseSave.TabIndex = 41;
            this.btnDecreaseSave.UseVisualStyleBackColor = true;
            this.btnDecreaseSave.Click += new System.EventHandler(this.btnDecreaseSave_Click);
            // 
            // txtDecreaseDescription
            // 
            this.txtDecreaseDescription.Location = new System.Drawing.Point(79, 48);
            this.txtDecreaseDescription.Name = "txtDecreaseDescription";
            this.txtDecreaseDescription.Size = new System.Drawing.Size(300, 21);
            this.txtDecreaseDescription.TabIndex = 3;
            // 
            // txtDecreaseName
            // 
            this.txtDecreaseName.Location = new System.Drawing.Point(79, 14);
            this.txtDecreaseName.Name = "txtDecreaseName";
            this.txtDecreaseName.Size = new System.Drawing.Size(200, 21);
            this.txtDecreaseName.TabIndex = 2;
            // 
            // lblDecreaseDescription
            // 
            this.lblDecreaseDescription.AutoSize = true;
            this.lblDecreaseDescription.Location = new System.Drawing.Point(3, 51);
            this.lblDecreaseDescription.Name = "lblDecreaseDescription";
            this.lblDecreaseDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDecreaseDescription.TabIndex = 1;
            this.lblDecreaseDescription.Text = "Descripción";
            // 
            // lblDecreaseName
            // 
            this.lblDecreaseName.AutoSize = true;
            this.lblDecreaseName.Location = new System.Drawing.Point(3, 17);
            this.lblDecreaseName.Name = "lblDecreaseName";
            this.lblDecreaseName.Size = new System.Drawing.Size(52, 15);
            this.lblDecreaseName.TabIndex = 0;
            this.lblDecreaseName.Text = "Nombre";
            // 
            // grpbDecreasList
            // 
            this.grpbDecreasList.Controls.Add(this.btnDecreaseDelete);
            this.grpbDecreasList.Controls.Add(this.btnDecreaseAdd);
            this.grpbDecreasList.Controls.Add(this.btnDecreaseEdit);
            this.grpbDecreasList.Controls.Add(this.dgvDecrease);
            this.grpbDecreasList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDecreasList.Location = new System.Drawing.Point(0, 0);
            this.grpbDecreasList.Name = "grpbDecreasList";
            this.grpbDecreasList.Size = new System.Drawing.Size(666, 253);
            this.grpbDecreasList.TabIndex = 0;
            this.grpbDecreasList.TabStop = false;
            // 
            // btnDecreaseDelete
            // 
            this.btnDecreaseDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDecreaseDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseDelete.Location = new System.Drawing.Point(630, 221);
            this.btnDecreaseDelete.Name = "btnDecreaseDelete";
            this.btnDecreaseDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseDelete.TabIndex = 44;
            this.btnDecreaseDelete.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseAdd
            // 
            this.btnDecreaseAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnDecreaseAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseAdd.Location = new System.Drawing.Point(578, 221);
            this.btnDecreaseAdd.Name = "btnDecreaseAdd";
            this.btnDecreaseAdd.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseAdd.TabIndex = 42;
            this.btnDecreaseAdd.UseVisualStyleBackColor = true;
            this.btnDecreaseAdd.Click += new System.EventHandler(this.btnDecreaseAdd_Click);
            // 
            // btnDecreaseEdit
            // 
            this.btnDecreaseEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnDecreaseEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseEdit.Location = new System.Drawing.Point(604, 221);
            this.btnDecreaseEdit.Name = "btnDecreaseEdit";
            this.btnDecreaseEdit.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseEdit.TabIndex = 43;
            this.btnDecreaseEdit.UseVisualStyleBackColor = true;
            this.btnDecreaseEdit.Click += new System.EventHandler(this.btnDecreaseEdit_Click);
            // 
            // dgvDecrease
            // 
            this.dgvDecrease.AllowUserToAddRows = false;
            this.dgvDecrease.AllowUserToDeleteRows = false;
            this.dgvDecrease.AllowUserToOrderColumns = true;
            this.dgvDecrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDecreaseCodsec,
            this.clmDecreaseName,
            this.clmDecreaseDescription});
            this.dgvDecrease.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDecrease.Location = new System.Drawing.Point(3, 17);
            this.dgvDecrease.Name = "dgvDecrease";
            this.dgvDecrease.ReadOnly = true;
            this.dgvDecrease.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDecrease.Size = new System.Drawing.Size(660, 198);
            this.dgvDecrease.TabIndex = 0;
            // 
            // clmDecreaseCodsec
            // 
            this.clmDecreaseCodsec.HeaderText = "Codsec";
            this.clmDecreaseCodsec.Name = "clmDecreaseCodsec";
            this.clmDecreaseCodsec.ReadOnly = true;
            this.clmDecreaseCodsec.Visible = false;
            // 
            // clmDecreaseName
            // 
            this.clmDecreaseName.HeaderText = "Nombre";
            this.clmDecreaseName.Name = "clmDecreaseName";
            this.clmDecreaseName.ReadOnly = true;
            this.clmDecreaseName.Width = 150;
            // 
            // clmDecreaseDescription
            // 
            this.clmDecreaseDescription.HeaderText = "Descripción";
            this.clmDecreaseDescription.Name = "clmDecreaseDescription";
            this.clmDecreaseDescription.ReadOnly = true;
            this.clmDecreaseDescription.Width = 450;
            // 
            // pnlTransport
            // 
            this.pnlTransport.Controls.Add(this.grpbTransportForm);
            this.pnlTransport.Controls.Add(this.grpbTransportList);
            this.pnlTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransport.Location = new System.Drawing.Point(0, 0);
            this.pnlTransport.Name = "pnlTransport";
            this.pnlTransport.Size = new System.Drawing.Size(666, 524);
            this.pnlTransport.TabIndex = 1;
            // 
            // grpbTransportForm
            // 
            this.grpbTransportForm.Controls.Add(this.btnTransportCancel);
            this.grpbTransportForm.Controls.Add(this.btnTransportSave);
            this.grpbTransportForm.Controls.Add(this.txtTransportGrossCapacity);
            this.grpbTransportForm.Controls.Add(this.lblTransportGrossCapacity);
            this.grpbTransportForm.Controls.Add(this.txtTransportusefulLong);
            this.grpbTransportForm.Controls.Add(this.lblTransportusefulLong);
            this.grpbTransportForm.Controls.Add(this.txtTransportusefulHigh);
            this.grpbTransportForm.Controls.Add(this.lblTransportusefulHigh);
            this.grpbTransportForm.Controls.Add(this.txtTransportusefulWidth);
            this.grpbTransportForm.Controls.Add(this.lblTransportusefulWidth);
            this.grpbTransportForm.Controls.Add(this.txtTransportName);
            this.grpbTransportForm.Controls.Add(this.lblTransportName);
            this.grpbTransportForm.Location = new System.Drawing.Point(3, 253);
            this.grpbTransportForm.Name = "grpbTransportForm";
            this.grpbTransportForm.Size = new System.Drawing.Size(660, 264);
            this.grpbTransportForm.TabIndex = 1;
            this.grpbTransportForm.TabStop = false;
            // 
            // btnTransportCancel
            // 
            this.btnTransportCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnTransportCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportCancel.Location = new System.Drawing.Point(626, 233);
            this.btnTransportCancel.Name = "btnTransportCancel";
            this.btnTransportCancel.Size = new System.Drawing.Size(25, 25);
            this.btnTransportCancel.TabIndex = 43;
            this.btnTransportCancel.UseVisualStyleBackColor = true;
            this.btnTransportCancel.Click += new System.EventHandler(this.btnTransportCancel_Click);
            // 
            // btnTransportSave
            // 
            this.btnTransportSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransportSave.BackgroundImage")));
            this.btnTransportSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportSave.Location = new System.Drawing.Point(601, 233);
            this.btnTransportSave.Name = "btnTransportSave";
            this.btnTransportSave.Size = new System.Drawing.Size(25, 25);
            this.btnTransportSave.TabIndex = 42;
            this.btnTransportSave.UseVisualStyleBackColor = true;
            this.btnTransportSave.Click += new System.EventHandler(this.btnTransportSave_Click);
            // 
            // txtTransportGrossCapacity
            // 
            this.txtTransportGrossCapacity.Location = new System.Drawing.Point(135, 150);
            this.txtTransportGrossCapacity.Name = "txtTransportGrossCapacity";
            this.txtTransportGrossCapacity.Size = new System.Drawing.Size(121, 21);
            this.txtTransportGrossCapacity.TabIndex = 5;
            // 
            // lblTransportGrossCapacity
            // 
            this.lblTransportGrossCapacity.AutoSize = true;
            this.lblTransportGrossCapacity.Location = new System.Drawing.Point(3, 153);
            this.lblTransportGrossCapacity.Name = "lblTransportGrossCapacity";
            this.lblTransportGrossCapacity.Size = new System.Drawing.Size(98, 15);
            this.lblTransportGrossCapacity.TabIndex = 8;
            this.lblTransportGrossCapacity.Text = "Capacidad Bruta";
            // 
            // txtTransportusefulLong
            // 
            this.txtTransportusefulLong.Location = new System.Drawing.Point(135, 116);
            this.txtTransportusefulLong.Name = "txtTransportusefulLong";
            this.txtTransportusefulLong.Size = new System.Drawing.Size(121, 21);
            this.txtTransportusefulLong.TabIndex = 4;
            // 
            // lblTransportusefulLong
            // 
            this.lblTransportusefulLong.AutoSize = true;
            this.lblTransportusefulLong.Location = new System.Drawing.Point(3, 119);
            this.lblTransportusefulLong.Name = "lblTransportusefulLong";
            this.lblTransportusefulLong.Size = new System.Drawing.Size(60, 15);
            this.lblTransportusefulLong.TabIndex = 6;
            this.lblTransportusefulLong.Text = "Largo Util";
            // 
            // txtTransportusefulHigh
            // 
            this.txtTransportusefulHigh.Location = new System.Drawing.Point(135, 82);
            this.txtTransportusefulHigh.Name = "txtTransportusefulHigh";
            this.txtTransportusefulHigh.Size = new System.Drawing.Size(121, 21);
            this.txtTransportusefulHigh.TabIndex = 3;
            // 
            // lblTransportusefulHigh
            // 
            this.lblTransportusefulHigh.AutoSize = true;
            this.lblTransportusefulHigh.Location = new System.Drawing.Point(3, 85);
            this.lblTransportusefulHigh.Name = "lblTransportusefulHigh";
            this.lblTransportusefulHigh.Size = new System.Drawing.Size(48, 15);
            this.lblTransportusefulHigh.TabIndex = 4;
            this.lblTransportusefulHigh.Text = "Alto Util";
            // 
            // txtTransportusefulWidth
            // 
            this.txtTransportusefulWidth.Location = new System.Drawing.Point(135, 48);
            this.txtTransportusefulWidth.Name = "txtTransportusefulWidth";
            this.txtTransportusefulWidth.Size = new System.Drawing.Size(121, 21);
            this.txtTransportusefulWidth.TabIndex = 2;
            // 
            // lblTransportusefulWidth
            // 
            this.lblTransportusefulWidth.AutoSize = true;
            this.lblTransportusefulWidth.Location = new System.Drawing.Point(3, 51);
            this.lblTransportusefulWidth.Name = "lblTransportusefulWidth";
            this.lblTransportusefulWidth.Size = new System.Drawing.Size(62, 15);
            this.lblTransportusefulWidth.TabIndex = 2;
            this.lblTransportusefulWidth.Text = "Ancho Util";
            // 
            // txtTransportName
            // 
            this.txtTransportName.Location = new System.Drawing.Point(135, 14);
            this.txtTransportName.Name = "txtTransportName";
            this.txtTransportName.Size = new System.Drawing.Size(121, 21);
            this.txtTransportName.TabIndex = 1;
            // 
            // lblTransportName
            // 
            this.lblTransportName.AutoSize = true;
            this.lblTransportName.Location = new System.Drawing.Point(3, 17);
            this.lblTransportName.Name = "lblTransportName";
            this.lblTransportName.Size = new System.Drawing.Size(52, 15);
            this.lblTransportName.TabIndex = 0;
            this.lblTransportName.Text = "Nombre";
            // 
            // grpbTransportList
            // 
            this.grpbTransportList.Controls.Add(this.btnTransportAdd);
            this.grpbTransportList.Controls.Add(this.btnTransportEdit);
            this.grpbTransportList.Controls.Add(this.btnTransportDelete);
            this.grpbTransportList.Controls.Add(this.dgvTransport);
            this.grpbTransportList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTransportList.Location = new System.Drawing.Point(0, 0);
            this.grpbTransportList.Name = "grpbTransportList";
            this.grpbTransportList.Size = new System.Drawing.Size(666, 253);
            this.grpbTransportList.TabIndex = 0;
            this.grpbTransportList.TabStop = false;
            // 
            // btnTransportAdd
            // 
            this.btnTransportAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransportAdd.BackgroundImage")));
            this.btnTransportAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportAdd.Location = new System.Drawing.Point(579, 221);
            this.btnTransportAdd.Name = "btnTransportAdd";
            this.btnTransportAdd.Size = new System.Drawing.Size(25, 25);
            this.btnTransportAdd.TabIndex = 48;
            this.btnTransportAdd.UseVisualStyleBackColor = true;
            this.btnTransportAdd.Click += new System.EventHandler(this.btnTransportAdd_Click);
            // 
            // btnTransportEdit
            // 
            this.btnTransportEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransportEdit.BackgroundImage")));
            this.btnTransportEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportEdit.Location = new System.Drawing.Point(605, 221);
            this.btnTransportEdit.Name = "btnTransportEdit";
            this.btnTransportEdit.Size = new System.Drawing.Size(25, 25);
            this.btnTransportEdit.TabIndex = 46;
            this.btnTransportEdit.UseVisualStyleBackColor = true;
            this.btnTransportEdit.Click += new System.EventHandler(this.btnTransportEdit_Click);
            // 
            // btnTransportDelete
            // 
            this.btnTransportDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransportDelete.BackgroundImage")));
            this.btnTransportDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportDelete.Location = new System.Drawing.Point(631, 221);
            this.btnTransportDelete.Name = "btnTransportDelete";
            this.btnTransportDelete.Size = new System.Drawing.Size(25, 25);
            this.btnTransportDelete.TabIndex = 47;
            this.btnTransportDelete.UseVisualStyleBackColor = true;
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.AllowUserToOrderColumns = true;
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTransportCodsec,
            this.clmTransportName,
            this.clmTransportusefulWidth,
            this.clmTransportusefulHigh,
            this.clmTransportusefulLong,
            this.clmTransportGrossCapacity});
            this.dgvTransport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTransport.Location = new System.Drawing.Point(3, 17);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true;
            this.dgvTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransport.Size = new System.Drawing.Size(660, 198);
            this.dgvTransport.TabIndex = 0;
            // 
            // clmTransportCodsec
            // 
            this.clmTransportCodsec.HeaderText = "Codsec";
            this.clmTransportCodsec.Name = "clmTransportCodsec";
            this.clmTransportCodsec.ReadOnly = true;
            this.clmTransportCodsec.Visible = false;
            // 
            // clmTransportName
            // 
            this.clmTransportName.HeaderText = "Nombre";
            this.clmTransportName.Name = "clmTransportName";
            this.clmTransportName.ReadOnly = true;
            this.clmTransportName.Width = 200;
            // 
            // clmTransportusefulWidth
            // 
            this.clmTransportusefulWidth.HeaderText = "Ancho Util";
            this.clmTransportusefulWidth.Name = "clmTransportusefulWidth";
            this.clmTransportusefulWidth.ReadOnly = true;
            // 
            // clmTransportusefulHigh
            // 
            this.clmTransportusefulHigh.HeaderText = "Alto Util";
            this.clmTransportusefulHigh.Name = "clmTransportusefulHigh";
            this.clmTransportusefulHigh.ReadOnly = true;
            // 
            // clmTransportusefulLong
            // 
            this.clmTransportusefulLong.HeaderText = "Largo Util";
            this.clmTransportusefulLong.Name = "clmTransportusefulLong";
            this.clmTransportusefulLong.ReadOnly = true;
            // 
            // clmTransportGrossCapacity
            // 
            this.clmTransportGrossCapacity.HeaderText = "Capacidad Bruta";
            this.clmTransportGrossCapacity.Name = "clmTransportGrossCapacity";
            this.clmTransportGrossCapacity.ReadOnly = true;
            // 
            // pnlLayer
            // 
            this.pnlLayer.Controls.Add(this.grpbLayerForm);
            this.pnlLayer.Controls.Add(this.grpbLayerList);
            this.pnlLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayer.Location = new System.Drawing.Point(0, 0);
            this.pnlLayer.Name = "pnlLayer";
            this.pnlLayer.Size = new System.Drawing.Size(666, 524);
            this.pnlLayer.TabIndex = 1;
            // 
            // grpbLayerForm
            // 
            this.grpbLayerForm.Controls.Add(this.btnLayerCancel);
            this.grpbLayerForm.Controls.Add(this.btnLayerSave);
            this.grpbLayerForm.Controls.Add(this.txtLayerDescription);
            this.grpbLayerForm.Controls.Add(this.lblLayerDescription);
            this.grpbLayerForm.Controls.Add(this.txtLayerName);
            this.grpbLayerForm.Controls.Add(this.lblLayerName);
            this.grpbLayerForm.Location = new System.Drawing.Point(3, 253);
            this.grpbLayerForm.Name = "grpbLayerForm";
            this.grpbLayerForm.Size = new System.Drawing.Size(660, 264);
            this.grpbLayerForm.TabIndex = 1;
            this.grpbLayerForm.TabStop = false;
            // 
            // btnLayerCancel
            // 
            this.btnLayerCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnLayerCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayerCancel.Location = new System.Drawing.Point(626, 233);
            this.btnLayerCancel.Name = "btnLayerCancel";
            this.btnLayerCancel.Size = new System.Drawing.Size(25, 25);
            this.btnLayerCancel.TabIndex = 41;
            this.btnLayerCancel.UseVisualStyleBackColor = true;
            this.btnLayerCancel.Click += new System.EventHandler(this.btnLayerCancel_Click);
            // 
            // btnLayerSave
            // 
            this.btnLayerSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerSave.BackgroundImage")));
            this.btnLayerSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayerSave.Location = new System.Drawing.Point(601, 233);
            this.btnLayerSave.Name = "btnLayerSave";
            this.btnLayerSave.Size = new System.Drawing.Size(25, 25);
            this.btnLayerSave.TabIndex = 40;
            this.btnLayerSave.UseVisualStyleBackColor = true;
            this.btnLayerSave.Click += new System.EventHandler(this.btnLayerSave_Click);
            // 
            // txtLayerDescription
            // 
            this.txtLayerDescription.Location = new System.Drawing.Point(80, 82);
            this.txtLayerDescription.Name = "txtLayerDescription";
            this.txtLayerDescription.Size = new System.Drawing.Size(300, 21);
            this.txtLayerDescription.TabIndex = 2;
            // 
            // lblLayerDescription
            // 
            this.lblLayerDescription.AutoSize = true;
            this.lblLayerDescription.Location = new System.Drawing.Point(3, 85);
            this.lblLayerDescription.Name = "lblLayerDescription";
            this.lblLayerDescription.Size = new System.Drawing.Size(72, 15);
            this.lblLayerDescription.TabIndex = 2;
            this.lblLayerDescription.Text = "Descripción";
            // 
            // txtLayerName
            // 
            this.txtLayerName.Location = new System.Drawing.Point(80, 41);
            this.txtLayerName.Name = "txtLayerName";
            this.txtLayerName.Size = new System.Drawing.Size(121, 21);
            this.txtLayerName.TabIndex = 1;
            // 
            // lblLayerName
            // 
            this.lblLayerName.AutoSize = true;
            this.lblLayerName.Location = new System.Drawing.Point(3, 43);
            this.lblLayerName.Name = "lblLayerName";
            this.lblLayerName.Size = new System.Drawing.Size(52, 15);
            this.lblLayerName.TabIndex = 0;
            this.lblLayerName.Text = "Nombre";
            // 
            // grpbLayerList
            // 
            this.grpbLayerList.Controls.Add(this.btnLayerAdd);
            this.grpbLayerList.Controls.Add(this.btnLayerEdit);
            this.grpbLayerList.Controls.Add(this.btnLayerDelete);
            this.grpbLayerList.Controls.Add(this.dgvLayer);
            this.grpbLayerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbLayerList.Location = new System.Drawing.Point(0, 0);
            this.grpbLayerList.Name = "grpbLayerList";
            this.grpbLayerList.Size = new System.Drawing.Size(666, 253);
            this.grpbLayerList.TabIndex = 0;
            this.grpbLayerList.TabStop = false;
            // 
            // btnLayerAdd
            // 
            this.btnLayerAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerAdd.BackgroundImage")));
            this.btnLayerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayerAdd.Location = new System.Drawing.Point(580, 222);
            this.btnLayerAdd.Name = "btnLayerAdd";
            this.btnLayerAdd.Size = new System.Drawing.Size(25, 25);
            this.btnLayerAdd.TabIndex = 45;
            this.btnLayerAdd.UseVisualStyleBackColor = true;
            this.btnLayerAdd.Click += new System.EventHandler(this.btnLayerAdd_Click);
            // 
            // btnLayerEdit
            // 
            this.btnLayerEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerEdit.BackgroundImage")));
            this.btnLayerEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayerEdit.Location = new System.Drawing.Point(606, 222);
            this.btnLayerEdit.Name = "btnLayerEdit";
            this.btnLayerEdit.Size = new System.Drawing.Size(25, 25);
            this.btnLayerEdit.TabIndex = 43;
            this.btnLayerEdit.UseVisualStyleBackColor = true;
            this.btnLayerEdit.Click += new System.EventHandler(this.btnLayerEdit_Click);
            // 
            // btnLayerDelete
            // 
            this.btnLayerDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerDelete.BackgroundImage")));
            this.btnLayerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayerDelete.Location = new System.Drawing.Point(632, 222);
            this.btnLayerDelete.Name = "btnLayerDelete";
            this.btnLayerDelete.Size = new System.Drawing.Size(25, 25);
            this.btnLayerDelete.TabIndex = 44;
            this.btnLayerDelete.UseVisualStyleBackColor = true;
            this.btnLayerDelete.Click += new System.EventHandler(this.btnLayerDelete_Click);
            // 
            // dgvLayer
            // 
            this.dgvLayer.AllowUserToAddRows = false;
            this.dgvLayer.AllowUserToDeleteRows = false;
            this.dgvLayer.AllowUserToOrderColumns = true;
            this.dgvLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLayerCodsec,
            this.clmLayerName,
            this.clmLayerDescription});
            this.dgvLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLayer.Location = new System.Drawing.Point(3, 17);
            this.dgvLayer.Name = "dgvLayer";
            this.dgvLayer.ReadOnly = true;
            this.dgvLayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLayer.Size = new System.Drawing.Size(660, 198);
            this.dgvLayer.TabIndex = 0;
            // 
            // clmLayerCodsec
            // 
            this.clmLayerCodsec.HeaderText = "Codsec";
            this.clmLayerCodsec.Name = "clmLayerCodsec";
            this.clmLayerCodsec.ReadOnly = true;
            this.clmLayerCodsec.Visible = false;
            // 
            // clmLayerName
            // 
            this.clmLayerName.HeaderText = "Nombre";
            this.clmLayerName.Name = "clmLayerName";
            this.clmLayerName.ReadOnly = true;
            // 
            // clmLayerDescription
            // 
            this.clmLayerDescription.HeaderText = "Descripción";
            this.clmLayerDescription.Name = "clmLayerDescription";
            this.clmLayerDescription.ReadOnly = true;
            this.clmLayerDescription.Width = 350;
            // 
            // pnlDiameter
            // 
            this.pnlDiameter.Controls.Add(this.grpbDiameterForm);
            this.pnlDiameter.Controls.Add(this.grpbDiameterList);
            this.pnlDiameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiameter.Location = new System.Drawing.Point(0, 0);
            this.pnlDiameter.Name = "pnlDiameter";
            this.pnlDiameter.Size = new System.Drawing.Size(666, 524);
            this.pnlDiameter.TabIndex = 1;
            // 
            // grpbDiameterForm
            // 
            this.grpbDiameterForm.Controls.Add(this.btnCancel);
            this.grpbDiameterForm.Controls.Add(this.btnDiameterSave);
            this.grpbDiameterForm.Controls.Add(this.txtDiameterValue);
            this.grpbDiameterForm.Controls.Add(this.txtDiameterInitial);
            this.grpbDiameterForm.Controls.Add(this.txtDiameterName);
            this.grpbDiameterForm.Controls.Add(this.lblDiameterValue);
            this.grpbDiameterForm.Controls.Add(this.lblDiameterInitial);
            this.grpbDiameterForm.Controls.Add(this.lblDiameterName);
            this.grpbDiameterForm.Location = new System.Drawing.Point(3, 253);
            this.grpbDiameterForm.Name = "grpbDiameterForm";
            this.grpbDiameterForm.Size = new System.Drawing.Size(660, 264);
            this.grpbDiameterForm.TabIndex = 1;
            this.grpbDiameterForm.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(626, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDiameterSave
            // 
            this.btnDiameterSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiameterSave.BackgroundImage")));
            this.btnDiameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiameterSave.Location = new System.Drawing.Point(601, 233);
            this.btnDiameterSave.Name = "btnDiameterSave";
            this.btnDiameterSave.Size = new System.Drawing.Size(25, 25);
            this.btnDiameterSave.TabIndex = 40;
            this.btnDiameterSave.UseVisualStyleBackColor = true;
            this.btnDiameterSave.Click += new System.EventHandler(this.btnDiameterSave_Click);
            // 
            // txtDiameterValue
            // 
            this.txtDiameterValue.Location = new System.Drawing.Point(80, 127);
            this.txtDiameterValue.Name = "txtDiameterValue";
            this.txtDiameterValue.Size = new System.Drawing.Size(121, 21);
            this.txtDiameterValue.TabIndex = 3;
            // 
            // txtDiameterInitial
            // 
            this.txtDiameterInitial.Location = new System.Drawing.Point(80, 85);
            this.txtDiameterInitial.Name = "txtDiameterInitial";
            this.txtDiameterInitial.Size = new System.Drawing.Size(121, 21);
            this.txtDiameterInitial.TabIndex = 2;
            // 
            // txtDiameterName
            // 
            this.txtDiameterName.Location = new System.Drawing.Point(80, 41);
            this.txtDiameterName.Name = "txtDiameterName";
            this.txtDiameterName.Size = new System.Drawing.Size(121, 21);
            this.txtDiameterName.TabIndex = 1;
            // 
            // lblDiameterValue
            // 
            this.lblDiameterValue.AutoSize = true;
            this.lblDiameterValue.Location = new System.Drawing.Point(3, 127);
            this.lblDiameterValue.Name = "lblDiameterValue";
            this.lblDiameterValue.Size = new System.Drawing.Size(35, 15);
            this.lblDiameterValue.TabIndex = 2;
            this.lblDiameterValue.Text = "Valor";
            // 
            // lblDiameterInitial
            // 
            this.lblDiameterInitial.AutoSize = true;
            this.lblDiameterInitial.Location = new System.Drawing.Point(3, 85);
            this.lblDiameterInitial.Name = "lblDiameterInitial";
            this.lblDiameterInitial.Size = new System.Drawing.Size(39, 15);
            this.lblDiameterInitial.TabIndex = 1;
            this.lblDiameterInitial.Text = "Inicial";
            // 
            // lblDiameterName
            // 
            this.lblDiameterName.AutoSize = true;
            this.lblDiameterName.Location = new System.Drawing.Point(3, 43);
            this.lblDiameterName.Name = "lblDiameterName";
            this.lblDiameterName.Size = new System.Drawing.Size(52, 15);
            this.lblDiameterName.TabIndex = 0;
            this.lblDiameterName.Text = "Nombre";
            // 
            // grpbDiameterList
            // 
            this.grpbDiameterList.Controls.Add(this.btnDiameterAdd);
            this.grpbDiameterList.Controls.Add(this.btnDiameterEdit);
            this.grpbDiameterList.Controls.Add(this.btnDiameterDelete);
            this.grpbDiameterList.Controls.Add(this.dgvDiameter);
            this.grpbDiameterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDiameterList.Location = new System.Drawing.Point(0, 0);
            this.grpbDiameterList.Name = "grpbDiameterList";
            this.grpbDiameterList.Size = new System.Drawing.Size(666, 253);
            this.grpbDiameterList.TabIndex = 0;
            this.grpbDiameterList.TabStop = false;
            // 
            // btnDiameterAdd
            // 
            this.btnDiameterAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiameterAdd.BackgroundImage")));
            this.btnDiameterAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiameterAdd.Location = new System.Drawing.Point(577, 221);
            this.btnDiameterAdd.Name = "btnDiameterAdd";
            this.btnDiameterAdd.Size = new System.Drawing.Size(25, 25);
            this.btnDiameterAdd.TabIndex = 45;
            this.btnDiameterAdd.UseVisualStyleBackColor = true;
            this.btnDiameterAdd.Click += new System.EventHandler(this.btnDiameterAdd_Click);
            // 
            // btnDiameterEdit
            // 
            this.btnDiameterEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiameterEdit.BackgroundImage")));
            this.btnDiameterEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiameterEdit.Location = new System.Drawing.Point(603, 221);
            this.btnDiameterEdit.Name = "btnDiameterEdit";
            this.btnDiameterEdit.Size = new System.Drawing.Size(25, 25);
            this.btnDiameterEdit.TabIndex = 43;
            this.btnDiameterEdit.UseVisualStyleBackColor = true;
            this.btnDiameterEdit.Click += new System.EventHandler(this.btnDiameterEdit_Click);
            // 
            // btnDiameterDelete
            // 
            this.btnDiameterDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiameterDelete.BackgroundImage")));
            this.btnDiameterDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiameterDelete.Location = new System.Drawing.Point(629, 221);
            this.btnDiameterDelete.Name = "btnDiameterDelete";
            this.btnDiameterDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDiameterDelete.TabIndex = 44;
            this.btnDiameterDelete.UseVisualStyleBackColor = true;
            // 
            // dgvDiameter
            // 
            this.dgvDiameter.AllowUserToAddRows = false;
            this.dgvDiameter.AllowUserToDeleteRows = false;
            this.dgvDiameter.AllowUserToOrderColumns = true;
            this.dgvDiameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDiameterCodsec,
            this.clmDiameterName,
            this.clmDiameterInitial,
            this.clmDiameterValue});
            this.dgvDiameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDiameter.Location = new System.Drawing.Point(3, 17);
            this.dgvDiameter.Name = "dgvDiameter";
            this.dgvDiameter.ReadOnly = true;
            this.dgvDiameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiameter.Size = new System.Drawing.Size(660, 198);
            this.dgvDiameter.TabIndex = 0;
            // 
            // clmDiameterCodsec
            // 
            this.clmDiameterCodsec.HeaderText = "Codsec";
            this.clmDiameterCodsec.Name = "clmDiameterCodsec";
            this.clmDiameterCodsec.ReadOnly = true;
            this.clmDiameterCodsec.Visible = false;
            // 
            // clmDiameterName
            // 
            this.clmDiameterName.HeaderText = "Nombre";
            this.clmDiameterName.Name = "clmDiameterName";
            this.clmDiameterName.ReadOnly = true;
            // 
            // clmDiameterInitial
            // 
            this.clmDiameterInitial.HeaderText = "Inicial";
            this.clmDiameterInitial.Name = "clmDiameterInitial";
            this.clmDiameterInitial.ReadOnly = true;
            // 
            // clmDiameterValue
            // 
            this.clmDiameterValue.HeaderText = "Valor";
            this.clmDiameterValue.Name = "clmDiameterValue";
            this.clmDiameterValue.ReadOnly = true;
            // 
            // pnlIncoterms
            // 
            this.pnlIncoterms.Controls.Add(this.grpbIncotermsForm);
            this.pnlIncoterms.Controls.Add(this.grpbIncotermsList);
            this.pnlIncoterms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncoterms.Location = new System.Drawing.Point(0, 0);
            this.pnlIncoterms.Name = "pnlIncoterms";
            this.pnlIncoterms.Size = new System.Drawing.Size(666, 524);
            this.pnlIncoterms.TabIndex = 1;
            // 
            // grpbIncotermsForm
            // 
            this.grpbIncotermsForm.Controls.Add(this.btnIncotermsCancel);
            this.grpbIncotermsForm.Controls.Add(this.btnIncotermsSave);
            this.grpbIncotermsForm.Controls.Add(this.txtIncotermsDescription);
            this.grpbIncotermsForm.Controls.Add(this.lblIncotermsDescription);
            this.grpbIncotermsForm.Controls.Add(this.txtIncotermsAbbreviation);
            this.grpbIncotermsForm.Controls.Add(this.lblIncotermsAbbreviation);
            this.grpbIncotermsForm.Controls.Add(this.txtIncotermsName);
            this.grpbIncotermsForm.Controls.Add(this.lblIncotermsName);
            this.grpbIncotermsForm.Location = new System.Drawing.Point(3, 253);
            this.grpbIncotermsForm.Name = "grpbIncotermsForm";
            this.grpbIncotermsForm.Size = new System.Drawing.Size(660, 264);
            this.grpbIncotermsForm.TabIndex = 1;
            this.grpbIncotermsForm.TabStop = false;
            // 
            // btnIncotermsCancel
            // 
            this.btnIncotermsCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnIncotermsCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncotermsCancel.Location = new System.Drawing.Point(628, 233);
            this.btnIncotermsCancel.Name = "btnIncotermsCancel";
            this.btnIncotermsCancel.Size = new System.Drawing.Size(25, 25);
            this.btnIncotermsCancel.TabIndex = 41;
            this.btnIncotermsCancel.UseVisualStyleBackColor = true;
            this.btnIncotermsCancel.Click += new System.EventHandler(this.btnIncotermsCancel_Click);
            // 
            // btnIncotermsSave
            // 
            this.btnIncotermsSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncotermsSave.BackgroundImage")));
            this.btnIncotermsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncotermsSave.Location = new System.Drawing.Point(603, 233);
            this.btnIncotermsSave.Name = "btnIncotermsSave";
            this.btnIncotermsSave.Size = new System.Drawing.Size(25, 25);
            this.btnIncotermsSave.TabIndex = 40;
            this.btnIncotermsSave.UseVisualStyleBackColor = true;
            this.btnIncotermsSave.Click += new System.EventHandler(this.btnIncotermsSave_Click);
            // 
            // txtIncotermsDescription
            // 
            this.txtIncotermsDescription.Location = new System.Drawing.Point(80, 126);
            this.txtIncotermsDescription.Name = "txtIncotermsDescription";
            this.txtIncotermsDescription.Size = new System.Drawing.Size(450, 21);
            this.txtIncotermsDescription.TabIndex = 3;
            // 
            // lblIncotermsDescription
            // 
            this.lblIncotermsDescription.AutoSize = true;
            this.lblIncotermsDescription.Location = new System.Drawing.Point(3, 127);
            this.lblIncotermsDescription.Name = "lblIncotermsDescription";
            this.lblIncotermsDescription.Size = new System.Drawing.Size(72, 15);
            this.lblIncotermsDescription.TabIndex = 4;
            this.lblIncotermsDescription.Text = "Descripción";
            // 
            // txtIncotermsAbbreviation
            // 
            this.txtIncotermsAbbreviation.Location = new System.Drawing.Point(80, 81);
            this.txtIncotermsAbbreviation.Name = "txtIncotermsAbbreviation";
            this.txtIncotermsAbbreviation.Size = new System.Drawing.Size(121, 21);
            this.txtIncotermsAbbreviation.TabIndex = 2;
            // 
            // lblIncotermsAbbreviation
            // 
            this.lblIncotermsAbbreviation.AutoSize = true;
            this.lblIncotermsAbbreviation.Location = new System.Drawing.Point(3, 85);
            this.lblIncotermsAbbreviation.Name = "lblIncotermsAbbreviation";
            this.lblIncotermsAbbreviation.Size = new System.Drawing.Size(70, 15);
            this.lblIncotermsAbbreviation.TabIndex = 2;
            this.lblIncotermsAbbreviation.Text = "Abreviación";
            // 
            // txtIncotermsName
            // 
            this.txtIncotermsName.Location = new System.Drawing.Point(80, 41);
            this.txtIncotermsName.Name = "txtIncotermsName";
            this.txtIncotermsName.Size = new System.Drawing.Size(121, 21);
            this.txtIncotermsName.TabIndex = 1;
            // 
            // lblIncotermsName
            // 
            this.lblIncotermsName.AutoSize = true;
            this.lblIncotermsName.Location = new System.Drawing.Point(3, 43);
            this.lblIncotermsName.Name = "lblIncotermsName";
            this.lblIncotermsName.Size = new System.Drawing.Size(52, 15);
            this.lblIncotermsName.TabIndex = 0;
            this.lblIncotermsName.Text = "Nombre";
            // 
            // grpbIncotermsList
            // 
            this.grpbIncotermsList.Controls.Add(this.btnIncotermsAdd);
            this.grpbIncotermsList.Controls.Add(this.btnIncotermsEdit);
            this.grpbIncotermsList.Controls.Add(this.btnIncotermsDelete);
            this.grpbIncotermsList.Controls.Add(this.dgvIncoterms);
            this.grpbIncotermsList.Controls.Add(this.dataGridView1);
            this.grpbIncotermsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbIncotermsList.Location = new System.Drawing.Point(0, 0);
            this.grpbIncotermsList.Name = "grpbIncotermsList";
            this.grpbIncotermsList.Size = new System.Drawing.Size(666, 253);
            this.grpbIncotermsList.TabIndex = 0;
            this.grpbIncotermsList.TabStop = false;
            // 
            // btnIncotermsAdd
            // 
            this.btnIncotermsAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncotermsAdd.BackgroundImage")));
            this.btnIncotermsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncotermsAdd.Location = new System.Drawing.Point(579, 221);
            this.btnIncotermsAdd.Name = "btnIncotermsAdd";
            this.btnIncotermsAdd.Size = new System.Drawing.Size(25, 25);
            this.btnIncotermsAdd.TabIndex = 45;
            this.btnIncotermsAdd.UseVisualStyleBackColor = true;
            this.btnIncotermsAdd.Click += new System.EventHandler(this.btnIncotermsAdd_Click);
            // 
            // btnIncotermsEdit
            // 
            this.btnIncotermsEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncotermsEdit.BackgroundImage")));
            this.btnIncotermsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncotermsEdit.Location = new System.Drawing.Point(605, 221);
            this.btnIncotermsEdit.Name = "btnIncotermsEdit";
            this.btnIncotermsEdit.Size = new System.Drawing.Size(25, 25);
            this.btnIncotermsEdit.TabIndex = 43;
            this.btnIncotermsEdit.UseVisualStyleBackColor = true;
            this.btnIncotermsEdit.Click += new System.EventHandler(this.btnIncotermsEdit_Click);
            // 
            // btnIncotermsDelete
            // 
            this.btnIncotermsDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncotermsDelete.BackgroundImage")));
            this.btnIncotermsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncotermsDelete.Location = new System.Drawing.Point(631, 221);
            this.btnIncotermsDelete.Name = "btnIncotermsDelete";
            this.btnIncotermsDelete.Size = new System.Drawing.Size(25, 25);
            this.btnIncotermsDelete.TabIndex = 44;
            this.btnIncotermsDelete.UseVisualStyleBackColor = true;
            // 
            // dgvIncoterms
            // 
            this.dgvIncoterms.AllowUserToAddRows = false;
            this.dgvIncoterms.AllowUserToDeleteRows = false;
            this.dgvIncoterms.AllowUserToOrderColumns = true;
            this.dgvIncoterms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncoterms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIncotermsCodsec,
            this.clmIncotermsName,
            this.clmIncotermsAbbreviation,
            this.clmIncotermsDescription});
            this.dgvIncoterms.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvIncoterms.Location = new System.Drawing.Point(3, 17);
            this.dgvIncoterms.Name = "dgvIncoterms";
            this.dgvIncoterms.ReadOnly = true;
            this.dgvIncoterms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncoterms.Size = new System.Drawing.Size(660, 198);
            this.dgvIncoterms.TabIndex = 1;
            // 
            // clmIncotermsCodsec
            // 
            this.clmIncotermsCodsec.HeaderText = "Codsec";
            this.clmIncotermsCodsec.Name = "clmIncotermsCodsec";
            this.clmIncotermsCodsec.ReadOnly = true;
            this.clmIncotermsCodsec.Visible = false;
            // 
            // clmIncotermsName
            // 
            this.clmIncotermsName.HeaderText = "Nombre";
            this.clmIncotermsName.Name = "clmIncotermsName";
            this.clmIncotermsName.ReadOnly = true;
            // 
            // clmIncotermsAbbreviation
            // 
            this.clmIncotermsAbbreviation.HeaderText = "Abrev.";
            this.clmIncotermsAbbreviation.Name = "clmIncotermsAbbreviation";
            this.clmIncotermsAbbreviation.ReadOnly = true;
            // 
            // clmIncotermsDescription
            // 
            this.clmIncotermsDescription.HeaderText = "Descripción";
            this.clmIncotermsDescription.Name = "clmIncotermsDescription";
            this.clmIncotermsDescription.ReadOnly = true;
            this.clmIncotermsDescription.Width = 450;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 596);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlProductionLine
            // 
            this.pnlProductionLine.Controls.Add(this.grpbProductionLineForm);
            this.pnlProductionLine.Controls.Add(this.grpbProductionLineList);
            this.pnlProductionLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductionLine.Location = new System.Drawing.Point(0, 0);
            this.pnlProductionLine.Name = "pnlProductionLine";
            this.pnlProductionLine.Size = new System.Drawing.Size(666, 524);
            this.pnlProductionLine.TabIndex = 1;
            // 
            // grpbProductionLineForm
            // 
            this.grpbProductionLineForm.Controls.Add(this.btnProductionLineCancel);
            this.grpbProductionLineForm.Controls.Add(this.btnProductionLineSave);
            this.grpbProductionLineForm.Controls.Add(this.txtProductionLineDescription);
            this.grpbProductionLineForm.Controls.Add(this.lblProductionLineDescription);
            this.grpbProductionLineForm.Controls.Add(this.txtProductionLineName);
            this.grpbProductionLineForm.Controls.Add(this.lblProductionLineName);
            this.grpbProductionLineForm.Controls.Add(this.txtProductionLineLine);
            this.grpbProductionLineForm.Controls.Add(this.lblProductionLineLine);
            this.grpbProductionLineForm.Controls.Add(this.cmbProductionLinePlant);
            this.grpbProductionLineForm.Controls.Add(this.lblProductionLinePlant);
            this.grpbProductionLineForm.Location = new System.Drawing.Point(3, 253);
            this.grpbProductionLineForm.Name = "grpbProductionLineForm";
            this.grpbProductionLineForm.Size = new System.Drawing.Size(660, 264);
            this.grpbProductionLineForm.TabIndex = 1;
            this.grpbProductionLineForm.TabStop = false;
            // 
            // btnProductionLineCancel
            // 
            this.btnProductionLineCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductionLineCancel.BackgroundImage")));
            this.btnProductionLineCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionLineCancel.Location = new System.Drawing.Point(622, 233);
            this.btnProductionLineCancel.Name = "btnProductionLineCancel";
            this.btnProductionLineCancel.Size = new System.Drawing.Size(25, 25);
            this.btnProductionLineCancel.TabIndex = 40;
            this.btnProductionLineCancel.UseVisualStyleBackColor = true;
            this.btnProductionLineCancel.Click += new System.EventHandler(this.btnProductionLineCancel_Click);
            // 
            // btnProductionLineSave
            // 
            this.btnProductionLineSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductionLineSave.BackgroundImage")));
            this.btnProductionLineSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionLineSave.Location = new System.Drawing.Point(597, 233);
            this.btnProductionLineSave.Name = "btnProductionLineSave";
            this.btnProductionLineSave.Size = new System.Drawing.Size(25, 25);
            this.btnProductionLineSave.TabIndex = 39;
            this.btnProductionLineSave.UseVisualStyleBackColor = true;
            this.btnProductionLineSave.Click += new System.EventHandler(this.btnProductionLineSave_Click);
            // 
            // txtProductionLineDescription
            // 
            this.txtProductionLineDescription.Location = new System.Drawing.Point(98, 151);
            this.txtProductionLineDescription.Name = "txtProductionLineDescription";
            this.txtProductionLineDescription.Size = new System.Drawing.Size(210, 21);
            this.txtProductionLineDescription.TabIndex = 4;
            // 
            // lblProductionLineDescription
            // 
            this.lblProductionLineDescription.AutoSize = true;
            this.lblProductionLineDescription.Location = new System.Drawing.Point(3, 154);
            this.lblProductionLineDescription.Name = "lblProductionLineDescription";
            this.lblProductionLineDescription.Size = new System.Drawing.Size(72, 15);
            this.lblProductionLineDescription.TabIndex = 6;
            this.lblProductionLineDescription.Text = "Descripción";
            // 
            // txtProductionLineName
            // 
            this.txtProductionLineName.Location = new System.Drawing.Point(98, 108);
            this.txtProductionLineName.Name = "txtProductionLineName";
            this.txtProductionLineName.Size = new System.Drawing.Size(121, 21);
            this.txtProductionLineName.TabIndex = 3;
            // 
            // lblProductionLineName
            // 
            this.lblProductionLineName.AutoSize = true;
            this.lblProductionLineName.Location = new System.Drawing.Point(3, 111);
            this.lblProductionLineName.Name = "lblProductionLineName";
            this.lblProductionLineName.Size = new System.Drawing.Size(52, 15);
            this.lblProductionLineName.TabIndex = 4;
            this.lblProductionLineName.Text = "Nombre";
            // 
            // txtProductionLineLine
            // 
            this.txtProductionLineLine.Location = new System.Drawing.Point(98, 71);
            this.txtProductionLineLine.Name = "txtProductionLineLine";
            this.txtProductionLineLine.Size = new System.Drawing.Size(121, 21);
            this.txtProductionLineLine.TabIndex = 2;
            // 
            // lblProductionLineLine
            // 
            this.lblProductionLineLine.AutoSize = true;
            this.lblProductionLineLine.Location = new System.Drawing.Point(3, 74);
            this.lblProductionLineLine.Name = "lblProductionLineLine";
            this.lblProductionLineLine.Size = new System.Drawing.Size(38, 15);
            this.lblProductionLineLine.TabIndex = 2;
            this.lblProductionLineLine.Text = "Linea";
            // 
            // cmbProductionLinePlant
            // 
            this.cmbProductionLinePlant.FormattingEnabled = true;
            this.cmbProductionLinePlant.Location = new System.Drawing.Point(98, 30);
            this.cmbProductionLinePlant.Name = "cmbProductionLinePlant";
            this.cmbProductionLinePlant.Size = new System.Drawing.Size(121, 23);
            this.cmbProductionLinePlant.TabIndex = 1;
            // 
            // lblProductionLinePlant
            // 
            this.lblProductionLinePlant.AutoSize = true;
            this.lblProductionLinePlant.Location = new System.Drawing.Point(3, 33);
            this.lblProductionLinePlant.Name = "lblProductionLinePlant";
            this.lblProductionLinePlant.Size = new System.Drawing.Size(42, 15);
            this.lblProductionLinePlant.TabIndex = 0;
            this.lblProductionLinePlant.Text = "Planta";
            // 
            // grpbProductionLineList
            // 
            this.grpbProductionLineList.Controls.Add(this.btnProductionLineDelete);
            this.grpbProductionLineList.Controls.Add(this.btnProductionLineAdd);
            this.grpbProductionLineList.Controls.Add(this.btnProductionLineEdit);
            this.grpbProductionLineList.Controls.Add(this.dgvProductionLine);
            this.grpbProductionLineList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProductionLineList.Location = new System.Drawing.Point(0, 0);
            this.grpbProductionLineList.Name = "grpbProductionLineList";
            this.grpbProductionLineList.Size = new System.Drawing.Size(666, 253);
            this.grpbProductionLineList.TabIndex = 0;
            this.grpbProductionLineList.TabStop = false;
            // 
            // btnProductionLineDelete
            // 
            this.btnProductionLineDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnProductionLineDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionLineDelete.Location = new System.Drawing.Point(630, 221);
            this.btnProductionLineDelete.Name = "btnProductionLineDelete";
            this.btnProductionLineDelete.Size = new System.Drawing.Size(25, 25);
            this.btnProductionLineDelete.TabIndex = 41;
            this.btnProductionLineDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductionLineAdd
            // 
            this.btnProductionLineAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnProductionLineAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionLineAdd.Location = new System.Drawing.Point(578, 221);
            this.btnProductionLineAdd.Name = "btnProductionLineAdd";
            this.btnProductionLineAdd.Size = new System.Drawing.Size(25, 25);
            this.btnProductionLineAdd.TabIndex = 39;
            this.btnProductionLineAdd.UseVisualStyleBackColor = true;
            this.btnProductionLineAdd.Click += new System.EventHandler(this.btnProductionLineAdd_Click);
            // 
            // btnProductionLineEdit
            // 
            this.btnProductionLineEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnProductionLineEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionLineEdit.Location = new System.Drawing.Point(604, 221);
            this.btnProductionLineEdit.Name = "btnProductionLineEdit";
            this.btnProductionLineEdit.Size = new System.Drawing.Size(25, 25);
            this.btnProductionLineEdit.TabIndex = 40;
            this.btnProductionLineEdit.UseVisualStyleBackColor = true;
            this.btnProductionLineEdit.Click += new System.EventHandler(this.btnProductionLineEdit_Click);
            // 
            // dgvProductionLine
            // 
            this.dgvProductionLine.AllowUserToAddRows = false;
            this.dgvProductionLine.AllowUserToDeleteRows = false;
            this.dgvProductionLine.AllowUserToOrderColumns = true;
            this.dgvProductionLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductionLineCodsec,
            this.clmProductionLinePlant,
            this.clmProductionLineNumberLine,
            this.clmProductionLineName,
            this.clmProductionLineDescription});
            this.dgvProductionLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductionLine.Location = new System.Drawing.Point(3, 17);
            this.dgvProductionLine.Name = "dgvProductionLine";
            this.dgvProductionLine.ReadOnly = true;
            this.dgvProductionLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductionLine.Size = new System.Drawing.Size(660, 198);
            this.dgvProductionLine.TabIndex = 0;
            // 
            // clmProductionLineCodsec
            // 
            this.clmProductionLineCodsec.HeaderText = "Codsec";
            this.clmProductionLineCodsec.Name = "clmProductionLineCodsec";
            this.clmProductionLineCodsec.ReadOnly = true;
            this.clmProductionLineCodsec.Visible = false;
            // 
            // clmProductionLinePlant
            // 
            this.clmProductionLinePlant.HeaderText = "Planta";
            this.clmProductionLinePlant.Name = "clmProductionLinePlant";
            this.clmProductionLinePlant.ReadOnly = true;
            // 
            // clmProductionLineNumberLine
            // 
            this.clmProductionLineNumberLine.HeaderText = "Linea";
            this.clmProductionLineNumberLine.Name = "clmProductionLineNumberLine";
            this.clmProductionLineNumberLine.ReadOnly = true;
            // 
            // clmProductionLineName
            // 
            this.clmProductionLineName.HeaderText = "Nombre";
            this.clmProductionLineName.Name = "clmProductionLineName";
            this.clmProductionLineName.ReadOnly = true;
            this.clmProductionLineName.Width = 150;
            // 
            // clmProductionLineDescription
            // 
            this.clmProductionLineDescription.HeaderText = "Descripción";
            this.clmProductionLineDescription.Name = "clmProductionLineDescription";
            this.clmProductionLineDescription.ReadOnly = true;
            this.clmProductionLineDescription.Width = 250;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.grpbBalanceForm);
            this.pnlBalance.Controls.Add(this.grpbBalanceList);
            this.pnlBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBalance.Location = new System.Drawing.Point(0, 0);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(666, 524);
            this.pnlBalance.TabIndex = 1;
            // 
            // grpbBalanceForm
            // 
            this.grpbBalanceForm.Controls.Add(this.cmbBalanceStatus);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceStatus);
            this.grpbBalanceForm.Controls.Add(this.comboBox4);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceSector);
            this.grpbBalanceForm.Controls.Add(this.cmbBalancePlant);
            this.grpbBalanceForm.Controls.Add(this.lblBalancePlant);
            this.grpbBalanceForm.Controls.Add(this.btnBalanceSave);
            this.grpbBalanceForm.Controls.Add(this.btnBalanceCancel);
            this.grpbBalanceForm.Controls.Add(this.txtBalanceCommand);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceCommand);
            this.grpbBalanceForm.Controls.Add(this.txtBalanceComm);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceComm);
            this.grpbBalanceForm.Controls.Add(this.txtBalanceDelimeterTwo);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceDelimeterTwo);
            this.grpbBalanceForm.Controls.Add(this.txtBalanceDelimeterOne);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceDelimeterOne);
            this.grpbBalanceForm.Controls.Add(this.textBox10);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceCapacity);
            this.grpbBalanceForm.Controls.Add(this.cmbBalanceunit);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceUnit);
            this.grpbBalanceForm.Controls.Add(this.textBox9);
            this.grpbBalanceForm.Controls.Add(this.lblBalanceName);
            this.grpbBalanceForm.Location = new System.Drawing.Point(3, 254);
            this.grpbBalanceForm.Name = "grpbBalanceForm";
            this.grpbBalanceForm.Size = new System.Drawing.Size(563, 132);
            this.grpbBalanceForm.TabIndex = 1;
            this.grpbBalanceForm.TabStop = false;
            // 
            // cmbBalanceStatus
            // 
            this.cmbBalanceStatus.FormattingEnabled = true;
            this.cmbBalanceStatus.Location = new System.Drawing.Point(420, 73);
            this.cmbBalanceStatus.Name = "cmbBalanceStatus";
            this.cmbBalanceStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbBalanceStatus.TabIndex = 10;
            // 
            // lblBalanceStatus
            // 
            this.lblBalanceStatus.AutoSize = true;
            this.lblBalanceStatus.Location = new System.Drawing.Point(359, 79);
            this.lblBalanceStatus.Name = "lblBalanceStatus";
            this.lblBalanceStatus.Size = new System.Drawing.Size(45, 15);
            this.lblBalanceStatus.TabIndex = 35;
            this.lblBalanceStatus.Text = "Estado";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(230, 73);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 9;
            // 
            // lblBalanceSector
            // 
            this.lblBalanceSector.AutoSize = true;
            this.lblBalanceSector.Location = new System.Drawing.Point(180, 79);
            this.lblBalanceSector.Name = "lblBalanceSector";
            this.lblBalanceSector.Size = new System.Drawing.Size(42, 15);
            this.lblBalanceSector.TabIndex = 33;
            this.lblBalanceSector.Text = "Sector";
            // 
            // cmbBalancePlant
            // 
            this.cmbBalancePlant.FormattingEnabled = true;
            this.cmbBalancePlant.Location = new System.Drawing.Point(52, 73);
            this.cmbBalancePlant.Name = "cmbBalancePlant";
            this.cmbBalancePlant.Size = new System.Drawing.Size(121, 23);
            this.cmbBalancePlant.TabIndex = 8;
            // 
            // lblBalancePlant
            // 
            this.lblBalancePlant.AutoSize = true;
            this.lblBalancePlant.Location = new System.Drawing.Point(4, 79);
            this.lblBalancePlant.Name = "lblBalancePlant";
            this.lblBalancePlant.Size = new System.Drawing.Size(42, 15);
            this.lblBalancePlant.TabIndex = 31;
            this.lblBalancePlant.Text = "Planta";
            // 
            // btnBalanceSave
            // 
            this.btnBalanceSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBalanceSave.BackgroundImage")));
            this.btnBalanceSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBalanceSave.Location = new System.Drawing.Point(488, 103);
            this.btnBalanceSave.Name = "btnBalanceSave";
            this.btnBalanceSave.Size = new System.Drawing.Size(25, 25);
            this.btnBalanceSave.TabIndex = 29;
            this.btnBalanceSave.UseVisualStyleBackColor = true;
            // 
            // btnBalanceCancel
            // 
            this.btnBalanceCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnBalanceCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBalanceCancel.Location = new System.Drawing.Point(513, 103);
            this.btnBalanceCancel.Name = "btnBalanceCancel";
            this.btnBalanceCancel.Size = new System.Drawing.Size(25, 25);
            this.btnBalanceCancel.TabIndex = 30;
            this.btnBalanceCancel.UseVisualStyleBackColor = true;
            // 
            // txtBalanceCommand
            // 
            this.txtBalanceCommand.Location = new System.Drawing.Point(441, 42);
            this.txtBalanceCommand.Name = "txtBalanceCommand";
            this.txtBalanceCommand.Size = new System.Drawing.Size(100, 21);
            this.txtBalanceCommand.TabIndex = 7;
            // 
            // lblBalanceCommand
            // 
            this.lblBalanceCommand.AutoSize = true;
            this.lblBalanceCommand.Location = new System.Drawing.Point(374, 46);
            this.lblBalanceCommand.Name = "lblBalanceCommand";
            this.lblBalanceCommand.Size = new System.Drawing.Size(61, 15);
            this.lblBalanceCommand.TabIndex = 10;
            this.lblBalanceCommand.Text = "Comando";
            // 
            // txtBalanceComm
            // 
            this.txtBalanceComm.Location = new System.Drawing.Point(304, 41);
            this.txtBalanceComm.Name = "txtBalanceComm";
            this.txtBalanceComm.Size = new System.Drawing.Size(50, 21);
            this.txtBalanceComm.TabIndex = 6;
            // 
            // lblBalanceComm
            // 
            this.lblBalanceComm.AutoSize = true;
            this.lblBalanceComm.Location = new System.Drawing.Point(244, 46);
            this.lblBalanceComm.Name = "lblBalanceComm";
            this.lblBalanceComm.Size = new System.Drawing.Size(44, 15);
            this.lblBalanceComm.TabIndex = 8;
            this.lblBalanceComm.Text = "Comm";
            // 
            // txtBalanceDelimeterTwo
            // 
            this.txtBalanceDelimeterTwo.Location = new System.Drawing.Point(184, 41);
            this.txtBalanceDelimeterTwo.Name = "txtBalanceDelimeterTwo";
            this.txtBalanceDelimeterTwo.Size = new System.Drawing.Size(50, 21);
            this.txtBalanceDelimeterTwo.TabIndex = 5;
            // 
            // lblBalanceDelimeterTwo
            // 
            this.lblBalanceDelimeterTwo.AutoSize = true;
            this.lblBalanceDelimeterTwo.Location = new System.Drawing.Point(134, 46);
            this.lblBalanceDelimeterTwo.Name = "lblBalanceDelimeterTwo";
            this.lblBalanceDelimeterTwo.Size = new System.Drawing.Size(39, 15);
            this.lblBalanceDelimeterTwo.TabIndex = 6;
            this.lblBalanceDelimeterTwo.Text = "Del. 2";
            // 
            // txtBalanceDelimeterOne
            // 
            this.txtBalanceDelimeterOne.Location = new System.Drawing.Point(63, 41);
            this.txtBalanceDelimeterOne.Name = "txtBalanceDelimeterOne";
            this.txtBalanceDelimeterOne.Size = new System.Drawing.Size(50, 21);
            this.txtBalanceDelimeterOne.TabIndex = 4;
            // 
            // lblBalanceDelimeterOne
            // 
            this.lblBalanceDelimeterOne.AutoSize = true;
            this.lblBalanceDelimeterOne.Location = new System.Drawing.Point(4, 46);
            this.lblBalanceDelimeterOne.Name = "lblBalanceDelimeterOne";
            this.lblBalanceDelimeterOne.Size = new System.Drawing.Size(39, 15);
            this.lblBalanceDelimeterOne.TabIndex = 4;
            this.lblBalanceDelimeterOne.Text = "Del. 1";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(442, 14);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 3;
            // 
            // lblBalanceCapacity
            // 
            this.lblBalanceCapacity.AutoSize = true;
            this.lblBalanceCapacity.Location = new System.Drawing.Point(374, 18);
            this.lblBalanceCapacity.Name = "lblBalanceCapacity";
            this.lblBalanceCapacity.Size = new System.Drawing.Size(66, 15);
            this.lblBalanceCapacity.TabIndex = 3;
            this.lblBalanceCapacity.Text = "Capacidad";
            // 
            // cmbBalanceunit
            // 
            this.cmbBalanceunit.FormattingEnabled = true;
            this.cmbBalanceunit.Location = new System.Drawing.Point(243, 13);
            this.cmbBalanceunit.Name = "cmbBalanceunit";
            this.cmbBalanceunit.Size = new System.Drawing.Size(121, 23);
            this.cmbBalanceunit.TabIndex = 2;
            // 
            // lblBalanceUnit
            // 
            this.lblBalanceUnit.AutoSize = true;
            this.lblBalanceUnit.Location = new System.Drawing.Point(189, 17);
            this.lblBalanceUnit.Name = "lblBalanceUnit";
            this.lblBalanceUnit.Size = new System.Drawing.Size(47, 15);
            this.lblBalanceUnit.TabIndex = 2;
            this.lblBalanceUnit.Text = "Unidad";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(63, 14);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(120, 21);
            this.textBox9.TabIndex = 1;
            // 
            // lblBalanceName
            // 
            this.lblBalanceName.AutoSize = true;
            this.lblBalanceName.Location = new System.Drawing.Point(4, 18);
            this.lblBalanceName.Name = "lblBalanceName";
            this.lblBalanceName.Size = new System.Drawing.Size(52, 15);
            this.lblBalanceName.TabIndex = 0;
            this.lblBalanceName.Text = "Nombre";
            // 
            // grpbBalanceList
            // 
            this.grpbBalanceList.Controls.Add(this.btnBalanceDelete);
            this.grpbBalanceList.Controls.Add(this.btnBalanceAdd);
            this.grpbBalanceList.Controls.Add(this.btnBalanceEdit);
            this.grpbBalanceList.Controls.Add(this.dgvBalance);
            this.grpbBalanceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbBalanceList.Location = new System.Drawing.Point(0, 0);
            this.grpbBalanceList.Name = "grpbBalanceList";
            this.grpbBalanceList.Size = new System.Drawing.Size(666, 253);
            this.grpbBalanceList.TabIndex = 0;
            this.grpbBalanceList.TabStop = false;
            // 
            // btnBalanceDelete
            // 
            this.btnBalanceDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnBalanceDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBalanceDelete.Location = new System.Drawing.Point(519, 221);
            this.btnBalanceDelete.Name = "btnBalanceDelete";
            this.btnBalanceDelete.Size = new System.Drawing.Size(25, 25);
            this.btnBalanceDelete.TabIndex = 44;
            this.btnBalanceDelete.UseVisualStyleBackColor = true;
            // 
            // btnBalanceAdd
            // 
            this.btnBalanceAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnBalanceAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBalanceAdd.Location = new System.Drawing.Point(467, 221);
            this.btnBalanceAdd.Name = "btnBalanceAdd";
            this.btnBalanceAdd.Size = new System.Drawing.Size(25, 25);
            this.btnBalanceAdd.TabIndex = 42;
            this.btnBalanceAdd.UseVisualStyleBackColor = true;
            // 
            // btnBalanceEdit
            // 
            this.btnBalanceEdit.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnBalanceEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBalanceEdit.Location = new System.Drawing.Point(493, 221);
            this.btnBalanceEdit.Name = "btnBalanceEdit";
            this.btnBalanceEdit.Size = new System.Drawing.Size(25, 25);
            this.btnBalanceEdit.TabIndex = 43;
            this.btnBalanceEdit.UseVisualStyleBackColor = true;
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            this.dgvBalance.AllowUserToOrderColumns = true;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBalanceCodsec,
            this.clmBalanceName,
            this.clmBalanceUnit,
            this.clmBalanceCapacity,
            this.clmBalanceDelimeterOne,
            this.clmBalanceDelimeterTwo,
            this.clmBalanceComm,
            this.clmBalanceCommand,
            this.clmBalanceSector,
            this.clmBalancePlant,
            this.clmBalanceStatus});
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBalance.Location = new System.Drawing.Point(3, 17);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.ReadOnly = true;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(660, 198);
            this.dgvBalance.TabIndex = 0;
            // 
            // clmBalanceCodsec
            // 
            this.clmBalanceCodsec.HeaderText = "Codsec";
            this.clmBalanceCodsec.Name = "clmBalanceCodsec";
            this.clmBalanceCodsec.ReadOnly = true;
            this.clmBalanceCodsec.Visible = false;
            // 
            // clmBalanceName
            // 
            this.clmBalanceName.HeaderText = "Nombre";
            this.clmBalanceName.Name = "clmBalanceName";
            this.clmBalanceName.ReadOnly = true;
            // 
            // clmBalanceUnit
            // 
            this.clmBalanceUnit.HeaderText = "Unidad";
            this.clmBalanceUnit.Name = "clmBalanceUnit";
            this.clmBalanceUnit.ReadOnly = true;
            // 
            // clmBalanceCapacity
            // 
            this.clmBalanceCapacity.HeaderText = "Capacidad";
            this.clmBalanceCapacity.Name = "clmBalanceCapacity";
            this.clmBalanceCapacity.ReadOnly = true;
            // 
            // clmBalanceDelimeterOne
            // 
            this.clmBalanceDelimeterOne.HeaderText = "Primer Delimitador ";
            this.clmBalanceDelimeterOne.Name = "clmBalanceDelimeterOne";
            this.clmBalanceDelimeterOne.ReadOnly = true;
            // 
            // clmBalanceDelimeterTwo
            // 
            this.clmBalanceDelimeterTwo.HeaderText = "Delimitador Dos";
            this.clmBalanceDelimeterTwo.Name = "clmBalanceDelimeterTwo";
            this.clmBalanceDelimeterTwo.ReadOnly = true;
            // 
            // clmBalanceComm
            // 
            this.clmBalanceComm.HeaderText = "Comm";
            this.clmBalanceComm.Name = "clmBalanceComm";
            this.clmBalanceComm.ReadOnly = true;
            // 
            // clmBalanceCommand
            // 
            this.clmBalanceCommand.HeaderText = "Comando";
            this.clmBalanceCommand.Name = "clmBalanceCommand";
            this.clmBalanceCommand.ReadOnly = true;
            // 
            // clmBalanceSector
            // 
            this.clmBalanceSector.HeaderText = "Sector";
            this.clmBalanceSector.Name = "clmBalanceSector";
            this.clmBalanceSector.ReadOnly = true;
            // 
            // clmBalancePlant
            // 
            this.clmBalancePlant.HeaderText = "Planta";
            this.clmBalancePlant.Name = "clmBalancePlant";
            this.clmBalancePlant.ReadOnly = true;
            // 
            // clmBalanceStatus
            // 
            this.clmBalanceStatus.HeaderText = "Estado";
            this.clmBalanceStatus.Name = "clmBalanceStatus";
            this.clmBalanceStatus.ReadOnly = true;
            // 
            // pnlCommercialCondition
            // 
            this.pnlCommercialCondition.Controls.Add(this.grpbCommercialConditionForm);
            this.pnlCommercialCondition.Controls.Add(this.grpbCommercialConditionList);
            this.pnlCommercialCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommercialCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlCommercialCondition.Name = "pnlCommercialCondition";
            this.pnlCommercialCondition.Size = new System.Drawing.Size(666, 524);
            this.pnlCommercialCondition.TabIndex = 1;
            // 
            // grpbCommercialConditionForm
            // 
            this.grpbCommercialConditionForm.Controls.Add(this.btnCommercialConditionCancel);
            this.grpbCommercialConditionForm.Controls.Add(this.btnCommercialConditionSave);
            this.grpbCommercialConditionForm.Controls.Add(this.txtCommercialConditionDescription);
            this.grpbCommercialConditionForm.Controls.Add(this.txtCommercialConditionName);
            this.grpbCommercialConditionForm.Controls.Add(this.lblCommercialConditionDescription);
            this.grpbCommercialConditionForm.Controls.Add(this.lblCommercialConditionName);
            this.grpbCommercialConditionForm.Location = new System.Drawing.Point(3, 253);
            this.grpbCommercialConditionForm.Name = "grpbCommercialConditionForm";
            this.grpbCommercialConditionForm.Size = new System.Drawing.Size(560, 132);
            this.grpbCommercialConditionForm.TabIndex = 1;
            this.grpbCommercialConditionForm.TabStop = false;
            // 
            // btnCommercialConditionCancel
            // 
            this.btnCommercialConditionCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommercialConditionCancel.BackgroundImage")));
            this.btnCommercialConditionCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCommercialConditionCancel.Location = new System.Drawing.Point(513, 103);
            this.btnCommercialConditionCancel.Name = "btnCommercialConditionCancel";
            this.btnCommercialConditionCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCommercialConditionCancel.TabIndex = 36;
            this.btnCommercialConditionCancel.UseVisualStyleBackColor = true;
            this.btnCommercialConditionCancel.Click += new System.EventHandler(this.btnCommercialConditionCancel_Click);
            // 
            // btnCommercialConditionSave
            // 
            this.btnCommercialConditionSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommercialConditionSave.BackgroundImage")));
            this.btnCommercialConditionSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCommercialConditionSave.Location = new System.Drawing.Point(488, 103);
            this.btnCommercialConditionSave.Name = "btnCommercialConditionSave";
            this.btnCommercialConditionSave.Size = new System.Drawing.Size(25, 25);
            this.btnCommercialConditionSave.TabIndex = 28;
            this.btnCommercialConditionSave.UseVisualStyleBackColor = true;
            this.btnCommercialConditionSave.Click += new System.EventHandler(this.btnCommercialConditionSave_Click);
            // 
            // txtCommercialConditionDescription
            // 
            this.txtCommercialConditionDescription.Location = new System.Drawing.Point(79, 48);
            this.txtCommercialConditionDescription.Name = "txtCommercialConditionDescription";
            this.txtCommercialConditionDescription.Size = new System.Drawing.Size(462, 21);
            this.txtCommercialConditionDescription.TabIndex = 3;
            // 
            // txtCommercialConditionName
            // 
            this.txtCommercialConditionName.Location = new System.Drawing.Point(79, 14);
            this.txtCommercialConditionName.Name = "txtCommercialConditionName";
            this.txtCommercialConditionName.Size = new System.Drawing.Size(462, 21);
            this.txtCommercialConditionName.TabIndex = 2;
            // 
            // lblCommercialConditionDescription
            // 
            this.lblCommercialConditionDescription.AutoSize = true;
            this.lblCommercialConditionDescription.Location = new System.Drawing.Point(3, 51);
            this.lblCommercialConditionDescription.Name = "lblCommercialConditionDescription";
            this.lblCommercialConditionDescription.Size = new System.Drawing.Size(72, 15);
            this.lblCommercialConditionDescription.TabIndex = 1;
            this.lblCommercialConditionDescription.Text = "Descripción";
            // 
            // lblCommercialConditionName
            // 
            this.lblCommercialConditionName.AutoSize = true;
            this.lblCommercialConditionName.Location = new System.Drawing.Point(3, 17);
            this.lblCommercialConditionName.Name = "lblCommercialConditionName";
            this.lblCommercialConditionName.Size = new System.Drawing.Size(52, 15);
            this.lblCommercialConditionName.TabIndex = 0;
            this.lblCommercialConditionName.Text = "Nombre";
            // 
            // grpbCommercialConditionList
            // 
            this.grpbCommercialConditionList.Controls.Add(this.btnCommercialConditionDelete);
            this.grpbCommercialConditionList.Controls.Add(this.btnCommercialConditionEdit);
            this.grpbCommercialConditionList.Controls.Add(this.btnCommercialConditionAdd);
            this.grpbCommercialConditionList.Controls.Add(this.dgvCommercialCondition);
            this.grpbCommercialConditionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCommercialConditionList.Location = new System.Drawing.Point(0, 0);
            this.grpbCommercialConditionList.Name = "grpbCommercialConditionList";
            this.grpbCommercialConditionList.Size = new System.Drawing.Size(666, 253);
            this.grpbCommercialConditionList.TabIndex = 0;
            this.grpbCommercialConditionList.TabStop = false;
            // 
            // btnCommercialConditionDelete
            // 
            this.btnCommercialConditionDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommercialConditionDelete.BackgroundImage")));
            this.btnCommercialConditionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCommercialConditionDelete.Location = new System.Drawing.Point(519, 221);
            this.btnCommercialConditionDelete.Name = "btnCommercialConditionDelete";
            this.btnCommercialConditionDelete.Size = new System.Drawing.Size(25, 25);
            this.btnCommercialConditionDelete.TabIndex = 36;
            this.btnCommercialConditionDelete.UseVisualStyleBackColor = true;
            // 
            // btnCommercialConditionEdit
            // 
            this.btnCommercialConditionEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommercialConditionEdit.BackgroundImage")));
            this.btnCommercialConditionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCommercialConditionEdit.Location = new System.Drawing.Point(493, 221);
            this.btnCommercialConditionEdit.Name = "btnCommercialConditionEdit";
            this.btnCommercialConditionEdit.Size = new System.Drawing.Size(25, 25);
            this.btnCommercialConditionEdit.TabIndex = 35;
            this.btnCommercialConditionEdit.UseVisualStyleBackColor = true;
            this.btnCommercialConditionEdit.Click += new System.EventHandler(this.btnCommercialConditionEdit_Click);
            // 
            // btnCommercialConditionAdd
            // 
            this.btnCommercialConditionAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommercialConditionAdd.BackgroundImage")));
            this.btnCommercialConditionAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCommercialConditionAdd.Location = new System.Drawing.Point(467, 221);
            this.btnCommercialConditionAdd.Name = "btnCommercialConditionAdd";
            this.btnCommercialConditionAdd.Size = new System.Drawing.Size(25, 25);
            this.btnCommercialConditionAdd.TabIndex = 34;
            this.btnCommercialConditionAdd.UseVisualStyleBackColor = true;
            this.btnCommercialConditionAdd.Click += new System.EventHandler(this.btnCommercialConditionAdd_Click);
            // 
            // dgvCommercialCondition
            // 
            this.dgvCommercialCondition.AllowUserToAddRows = false;
            this.dgvCommercialCondition.AllowUserToDeleteRows = false;
            this.dgvCommercialCondition.AllowUserToOrderColumns = true;
            this.dgvCommercialCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommercialCondition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCommercialConditionCodsec,
            this.clmCommercialConditionName,
            this.clmCommercialConditionDescription});
            this.dgvCommercialCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCommercialCondition.Location = new System.Drawing.Point(3, 17);
            this.dgvCommercialCondition.Name = "dgvCommercialCondition";
            this.dgvCommercialCondition.ReadOnly = true;
            this.dgvCommercialCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommercialCondition.Size = new System.Drawing.Size(660, 198);
            this.dgvCommercialCondition.TabIndex = 0;
            // 
            // clmCommercialConditionCodsec
            // 
            this.clmCommercialConditionCodsec.HeaderText = "Codsec";
            this.clmCommercialConditionCodsec.Name = "clmCommercialConditionCodsec";
            this.clmCommercialConditionCodsec.ReadOnly = true;
            this.clmCommercialConditionCodsec.Visible = false;
            // 
            // clmCommercialConditionName
            // 
            this.clmCommercialConditionName.HeaderText = "Nombre";
            this.clmCommercialConditionName.Name = "clmCommercialConditionName";
            this.clmCommercialConditionName.ReadOnly = true;
            this.clmCommercialConditionName.Width = 120;
            // 
            // clmCommercialConditionDescription
            // 
            this.clmCommercialConditionDescription.HeaderText = "Descripcion";
            this.clmCommercialConditionDescription.Name = "clmCommercialConditionDescription";
            this.clmCommercialConditionDescription.ReadOnly = true;
            this.clmCommercialConditionDescription.Width = 300;
            // 
            // Panel39
            // 
            this.Panel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel39.Location = new System.Drawing.Point(0, 0);
            this.Panel39.Name = "Panel39";
            this.Panel39.Size = new System.Drawing.Size(666, 524);
            this.Panel39.TabIndex = 1;
            // 
            // Panel40
            // 
            this.Panel40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel40.Location = new System.Drawing.Point(0, 0);
            this.Panel40.Name = "Panel40";
            this.Panel40.Size = new System.Drawing.Size(666, 524);
            this.Panel40.TabIndex = 1;
            // 
            // frmSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 524);
            this.Controls.Add(this.sptcConfig);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSystemConfig";
            this.Text = "Configuración del Sistema";
            this.Load += new System.EventHandler(this.frmSystemConfig_Load);
            this.sptcConfig.Panel1.ResumeLayout(false);
            this.sptcConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptcConfig)).EndInit();
            this.sptcConfig.ResumeLayout(false);
            this.pnlMetallizer.ResumeLayout(false);
            this.grpbMetallizerForm.ResumeLayout(false);
            this.grpbMetallizerForm.PerformLayout();
            this.grpbMetallizerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetallizer)).EndInit();
            this.pnlCellarByExtruder.ResumeLayout(false);
            this.grpbCellarByExtruderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellarbyMachine)).EndInit();
            this.grpbCellarByExtruderForm.ResumeLayout(false);
            this.grpbCellarByExtruderForm.PerformLayout();
            this.pnlExtruders.ResumeLayout(false);
            this.grpbExtruderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtruder)).EndInit();
            this.grpbExtruderForm.ResumeLayout(false);
            this.grpbExtruderForm.PerformLayout();
            this.pnlMold.ResumeLayout(false);
            this.grpbMoldView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.grpbMoldForm.ResumeLayout(false);
            this.grpbMoldForm.PerformLayout();
            this.pnlThermExtruder.ResumeLayout(false);
            this.grpbThermExtruderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermExtruder)).EndInit();
            this.grpbThermExtruderForm.ResumeLayout(false);
            this.grpbThermExtruderForm.PerformLayout();
            this.pnlThermDefects.ResumeLayout(false);
            this.grpbThermDefectsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermDefect)).EndInit();
            this.grpbThermDefectsForm.ResumeLayout(false);
            this.grpbThermDefectsForm.PerformLayout();
            this.pnlSupply.ResumeLayout(false);
            this.grpbSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.grpbSupplyForm.ResumeLayout(false);
            this.grpbSupplyForm.PerformLayout();
            this.pnlThermoformed.ResumeLayout(false);
            this.grpbThermoformedDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThermoformed)).EndInit();
            this.grpbThermoformedForm.ResumeLayout(false);
            this.grpbThermoformedForm.PerformLayout();
            this.pnlOunce.ResumeLayout(false);
            this.grpbOunceForm.ResumeLayout(false);
            this.grpbOunceForm.PerformLayout();
            this.grpbOunceView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOunce)).EndInit();
            this.pnlColor.ResumeLayout(false);
            this.grpbColorForm.ResumeLayout(false);
            this.grpbColorForm.PerformLayout();
            this.grpbColorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorDetail)).EndInit();
            this.pnlCore.ResumeLayout(false);
            this.grpbCoreForm.ResumeLayout(false);
            this.grpbCoreForm.PerformLayout();
            this.grpbCoreList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCore)).EndInit();
            this.pnlBopp.ResumeLayout(false);
            this.tctrlBoppFilm.ResumeLayout(false);
            this.tbpFamily.ResumeLayout(false);
            this.grpbFamilyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            this.grpbFamilyForm.ResumeLayout(false);
            this.grpbFamilyForm.PerformLayout();
            this.tbpSeal.ResumeLayout(false);
            this.grpbSealList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeal)).EndInit();
            this.grpbSealForm.ResumeLayout(false);
            this.grpbSealForm.PerformLayout();
            this.tbpBoppAdditivation.ResumeLayout(false);
            this.grpbAdditivationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditivation)).EndInit();
            this.grpbAdditivationForm.ResumeLayout(false);
            this.grpbAdditivationForm.PerformLayout();
            this.tbpBoppThickness.ResumeLayout(false);
            this.grpbThicknessForm.ResumeLayout(false);
            this.grpbThicknessForm.PerformLayout();
            this.grpbThicknessList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThickness)).EndInit();
            this.tbpBoppTreatment.ResumeLayout(false);
            this.grpbTreatmentForm.ResumeLayout(false);
            this.grpbTreatmentForm.PerformLayout();
            this.grpbTreatmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).EndInit();
            this.pnlInning.ResumeLayout(false);
            this.grpbInningForm.ResumeLayout(false);
            this.grpbInningForm.PerformLayout();
            this.grpbInningList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInning)).EndInit();
            this.pnlRole.ResumeLayout(false);
            this.grpbRoleForm.ResumeLayout(false);
            this.grpbRoleForm.PerformLayout();
            this.grpbRoleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.pnlRawMaterial.ResumeLayout(false);
            this.grpbRawMaterialForm.ResumeLayout(false);
            this.grpbRawMaterialForm.PerformLayout();
            this.grpbRawMaterialList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            this.pnlUnit.ResumeLayout(false);
            this.grpbUnitForm.ResumeLayout(false);
            this.grpbUnitForm.PerformLayout();
            this.grpbUnitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.pnlCast.ResumeLayout(false);
            this.tctrlCastFilm.ResumeLayout(false);
            this.tbpProcess.ResumeLayout(false);
            this.grpbProcessForm.ResumeLayout(false);
            this.grpbProcessForm.PerformLayout();
            this.grpbProcessList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.tbpStructure.ResumeLayout(false);
            this.grpbStructureForm.ResumeLayout(false);
            this.grpbStructureForm.PerformLayout();
            this.grpbStructureList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructure)).EndInit();
            this.tbpCastAdditivations.ResumeLayout(false);
            this.grpbCastAdditivationForm.ResumeLayout(false);
            this.grpbCastAdditivationForm.PerformLayout();
            this.grpbCastAdditivationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCastAdditivation)).EndInit();
            this.tbpCastThickness.ResumeLayout(false);
            this.grpbThicknessCastForm.ResumeLayout(false);
            this.grpbThicknessCastForm.PerformLayout();
            this.grpbThicknessCastList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThicknessCast)).EndInit();
            this.tbpCastTreatments.ResumeLayout(false);
            this.grpbTreatmentCastForm.ResumeLayout(false);
            this.grpbTreatmentCastForm.PerformLayout();
            this.grpbTreatmentCastList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentCast)).EndInit();
            this.pnlSupplyByentity.ResumeLayout(false);
            this.grpbSubbplyByEntityDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyByEntity)).EndInit();
            this.grpbSubbplyByEntityForm.ResumeLayout(false);
            this.grpbSubbplyByEntityForm.PerformLayout();
            this.pnlRawMaterialTypeByEntity.ResumeLayout(false);
            this.grpbRawMaterialTypeByEntityForm.ResumeLayout(false);
            this.grpbRawMaterialTypeByEntityForm.PerformLayout();
            this.grpbRawMaterialTypeByEntityList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialTypeByEntity)).EndInit();
            this.pnlCellar.ResumeLayout(false);
            this.grpbCellarList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellar)).EndInit();
            this.grpbCellarForm.ResumeLayout(false);
            this.grpbCellarForm.PerformLayout();
            this.pnlStatusGroup.ResumeLayout(false);
            this.grpbStatusGroupForm.ResumeLayout(false);
            this.grpbStatusGroupForm.PerformLayout();
            this.grpbStatusGroupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusGroup)).EndInit();
            this.pnlMill.ResumeLayout(false);
            this.grpbMillForm.ResumeLayout(false);
            this.grpbMillForm.PerformLayout();
            this.grpbMillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMill)).EndInit();
            this.pnlCutter.ResumeLayout(false);
            this.grpbCutterForm.ResumeLayout(false);
            this.grpbCutterForm.PerformLayout();
            this.grpbCutterList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutter)).EndInit();
            this.pnlCompany.ResumeLayout(false);
            this.tctrlCompany.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbCompanyInfo.ResumeLayout(false);
            this.grpbCompanyInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpbAddressList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyAddress)).EndInit();
            this.grpbAddressInfo.ResumeLayout(false);
            this.grpbAddressInfo.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.grpbUserForm.ResumeLayout(false);
            this.grpbUserForm.PerformLayout();
            this.grpbUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.grpbStatusForm.ResumeLayout(false);
            this.grpbStatusForm.PerformLayout();
            this.grpbStatusList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.pnlRawMaterialType.ResumeLayout(false);
            this.grpbRawMaterialTypeForm.ResumeLayout(false);
            this.grpbRawMaterialTypeForm.PerformLayout();
            this.grpbRawMaterialTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialType)).EndInit();
            this.pnlCoating.ResumeLayout(false);
            this.tctrlCoatingFilm.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grpbProcessCoatingForm.ResumeLayout(false);
            this.grpbProcessCoatingForm.PerformLayout();
            this.grpbProcessCoatingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingProcess)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpbStructureCoatingForm.ResumeLayout(false);
            this.grpbStructureCoatingForm.PerformLayout();
            this.grpbStructureCoatingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingStructure)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.grpbThicknessCoatingForm.ResumeLayout(false);
            this.grpbThicknessCoatingForm.PerformLayout();
            this.grpbThicknessCoatingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingThickness)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.grpbTreatmentCoatingForm.ResumeLayout(false);
            this.grpbTreatmentCoatingForm.PerformLayout();
            this.grpbTreatmentCoatingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoatingTreatment)).EndInit();
            this.pnlSector.ResumeLayout(false);
            this.grpbSectorForm.ResumeLayout(false);
            this.grpbSectorForm.PerformLayout();
            this.grpbSectorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).EndInit();
            this.pnlPlant.ResumeLayout(false);
            this.grpbPlantForm.ResumeLayout(false);
            this.grpbPlantForm.PerformLayout();
            this.grpbPlantList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlant)).EndInit();
            this.pnlIdType.ResumeLayout(false);
            this.grpbidtypeForm.ResumeLayout(false);
            this.grpbidtypeForm.PerformLayout();
            this.grpbidtypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdType)).EndInit();
            this.pnlLanguage.ResumeLayout(false);
            this.grpbLanguageForm.ResumeLayout(false);
            this.grpbLanguageForm.PerformLayout();
            this.grpbLanguageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).EndInit();
            this.pnlCurrency.ResumeLayout(false);
            this.grpbCurrencyForm.ResumeLayout(false);
            this.grpbCurrencyForm.PerformLayout();
            this.grpbCurrencyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.pnlGeographic.ResumeLayout(false);
            this.pnlGeographic.PerformLayout();
            this.gpbInfoCity.ResumeLayout(false);
            this.gpbInfoCity.PerformLayout();
            this.gpbInfoState.ResumeLayout(false);
            this.gpbInfoState.PerformLayout();
            this.gpbInfoCountry.ResumeLayout(false);
            this.gpbInfoCountry.PerformLayout();
            this.gpbActionsCity.ResumeLayout(false);
            this.gpbActionsState.ResumeLayout(false);
            this.gpbActionsCountry.ResumeLayout(false);
            this.pnlCoiler.ResumeLayout(false);
            this.grpbCoilers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilers)).EndInit();
            this.pnlPackagingType.ResumeLayout(false);
            this.grpbPackagingForm.ResumeLayout(false);
            this.grpbPackagingForm.PerformLayout();
            this.grpbPackagingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).EndInit();
            this.pnlTypeMainCoil.ResumeLayout(false);
            this.grpbMainCoilTypeForm.ResumeLayout(false);
            this.grpbMainCoilTypeForm.PerformLayout();
            this.grpbMainCoilTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilType)).EndInit();
            this.pnlDecrease.ResumeLayout(false);
            this.grpbDecreasForm.ResumeLayout(false);
            this.grpbDecreasForm.PerformLayout();
            this.grpbDecreasList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).EndInit();
            this.pnlTransport.ResumeLayout(false);
            this.grpbTransportForm.ResumeLayout(false);
            this.grpbTransportForm.PerformLayout();
            this.grpbTransportList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.pnlLayer.ResumeLayout(false);
            this.grpbLayerForm.ResumeLayout(false);
            this.grpbLayerForm.PerformLayout();
            this.grpbLayerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayer)).EndInit();
            this.pnlDiameter.ResumeLayout(false);
            this.grpbDiameterForm.ResumeLayout(false);
            this.grpbDiameterForm.PerformLayout();
            this.grpbDiameterList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiameter)).EndInit();
            this.pnlIncoterms.ResumeLayout(false);
            this.grpbIncotermsForm.ResumeLayout(false);
            this.grpbIncotermsForm.PerformLayout();
            this.grpbIncotermsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncoterms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlProductionLine.ResumeLayout(false);
            this.grpbProductionLineForm.ResumeLayout(false);
            this.grpbProductionLineForm.PerformLayout();
            this.grpbProductionLineList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionLine)).EndInit();
            this.pnlBalance.ResumeLayout(false);
            this.grpbBalanceForm.ResumeLayout(false);
            this.grpbBalanceForm.PerformLayout();
            this.grpbBalanceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.pnlCommercialCondition.ResumeLayout(false);
            this.grpbCommercialConditionForm.ResumeLayout(false);
            this.grpbCommercialConditionForm.PerformLayout();
            this.grpbCommercialConditionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommercialCondition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptcConfig;
        private System.Windows.Forms.TreeView trvConfigs;
        private System.Windows.Forms.Panel pnlGeographic;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ListBox lstbCity;
        private System.Windows.Forms.ListBox lstbState;
        private System.Windows.Forms.ListBox lstbCountry;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbInfoCity;
        private System.Windows.Forms.GroupBox gpbInfoState;
        private System.Windows.Forms.GroupBox gpbInfoCountry;
        private System.Windows.Forms.GroupBox gpbActionsCity;
        private System.Windows.Forms.GroupBox gpbActionsState;
        private System.Windows.Forms.GroupBox gpbActionsCountry;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Button btnEditCountry;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnEditCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnDeleteState;
        private System.Windows.Forms.Button btnEditState;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Button btnSaveCity;
        private System.Windows.Forms.Button btnSaveState;
        private System.Windows.Forms.Button btnSaveCountry;
        private System.Windows.Forms.TextBox txtcountryAbbreviation;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCommercialCondition;
        private System.Windows.Forms.Panel pnlIdType;
        private System.Windows.Forms.Panel pnlSector;
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.Panel pnlInning;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlStatusGroup;
        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.Panel pnlBopp;
        private System.Windows.Forms.Panel pnlCast;
        private System.Windows.Forms.Panel pnlCoating;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlPlant;
        private System.Windows.Forms.Panel pnlCoiler;
        private System.Windows.Forms.Panel pnlExtruders;
        private System.Windows.Forms.Panel pnlCutter;
        private System.Windows.Forms.Panel pnlMetallizer;
        private System.Windows.Forms.Panel pnlMill;
        private System.Windows.Forms.Panel pnlRawMaterialType;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlRawMaterialTypeByEntity;
        private System.Windows.Forms.Panel pnlProductionLine;
        private System.Windows.Forms.Panel pnlUnit;
        private System.Windows.Forms.Panel pnlCore;
        private System.Windows.Forms.Panel pnlIncoterms;
        private System.Windows.Forms.Panel pnlRawMaterial;
        private System.Windows.Forms.Panel pnlPackagingType;
        private System.Windows.Forms.Panel pnlDiameter;
        private System.Windows.Forms.Panel pnlLayer;
        private System.Windows.Forms.Panel pnlTransport;
        private System.Windows.Forms.Panel pnlDecrease;
        private System.Windows.Forms.Panel pnlTypeMainCoil;
        private System.Windows.Forms.Panel pnlCellar;
        private System.Windows.Forms.Panel pnlSupply;
        private System.Windows.Forms.Panel pnlSupplyByentity;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel pnlOunce;
        private System.Windows.Forms.Panel pnlThermoformed;
        private System.Windows.Forms.Panel pnlMold;
        private System.Windows.Forms.Panel pnlThermExtruder;
        private System.Windows.Forms.Panel pnlThermDefects;
        private System.Windows.Forms.Panel pnlThermByExtruder;
        private System.Windows.Forms.Panel pnlCellarByExtruder;
        private System.Windows.Forms.Panel Panel39;
        private System.Windows.Forms.Panel Panel40;
        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.Button btnCancelCountry;
        private System.Windows.Forms.Button btnCancelCity;
        private System.Windows.Forms.Button btnCancelState;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.TabControl tctrlCompany;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnCancelCompany;
        private System.Windows.Forms.GroupBox grpbCompanyInfo;
        private System.Windows.Forms.ComboBox cmbCurrencyMoney;
        private System.Windows.Forms.ComboBox cmbCountryCompany;
        private System.Windows.Forms.RadioButton rdoDistrib;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.TextBox txtDescriptionCompany;
        private System.Windows.Forms.TextBox txtNameCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCmpDescription;
        private System.Windows.Forms.Label lblCmyCountry;
        private System.Windows.Forms.Label lblCmpName;
        private System.Windows.Forms.GroupBox grpbAddressList;
        private System.Windows.Forms.GroupBox grpbAddressInfo;
        private System.Windows.Forms.DataGridView dgvCompanyAddress;
        private System.Windows.Forms.DataGridViewImageColumn IsDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.TextBox txtCompanyFax;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private System.Windows.Forms.TextBox txtCompanyZip;
        private System.Windows.Forms.TextBox txtCompanyPhone2;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyContact;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsDefaultAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCompanyCity;
        private System.Windows.Forms.ComboBox cmbCompanyCountry;
        private System.Windows.Forms.ComboBox cmbCompanyState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCompanyAddressSave;
        private System.Windows.Forms.Button btnCompanyAddressEdit;
        private System.Windows.Forms.Button btnCompanyAddressCancel;
        private System.Windows.Forms.TabControl tctrlBoppFilm;
        private System.Windows.Forms.TabPage tbpFamily;
        private System.Windows.Forms.TabPage tbpSeal;
        private System.Windows.Forms.TabPage tbpBoppAdditivation;
        private System.Windows.Forms.TabPage tbpBoppThickness;
        private System.Windows.Forms.TabPage tbpBoppTreatment;
        private System.Windows.Forms.TabControl tctrlCastFilm;
        private System.Windows.Forms.TabPage tbpProcess;
        private System.Windows.Forms.TabPage tbpStructure;
        private System.Windows.Forms.TabPage tbpCastAdditivations;
        private System.Windows.Forms.TabPage tbpCastThickness;
        private System.Windows.Forms.TabPage tbpCastTreatments;
        private System.Windows.Forms.TabControl tctrlCoatingFilm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox grpbFamilyList;
        private System.Windows.Forms.DataGridView dgvFamily;
        private System.Windows.Forms.Button btnBoppFamilyAdd;
        private System.Windows.Forms.Button btnBoppFamilyEdit;
        private System.Windows.Forms.Button btnBoppFamilyDelete;
        private System.Windows.Forms.GroupBox grpbFamilyForm;
        private System.Windows.Forms.TextBox txtBoppFamilyAbbreviation;
        private System.Windows.Forms.TextBox txtBoppFamilyName;
        private System.Windows.Forms.Label lblBoppFamilyAvbreviation;
        private System.Windows.Forms.Label lblBoppFamilyName;
        private System.Windows.Forms.Button btnBoppFamilySave;
        private System.Windows.Forms.Button btnBoppFamilyCancel;
        private System.Windows.Forms.GroupBox grpbSealList;
        private System.Windows.Forms.DataGridView dgvSeal;
        private System.Windows.Forms.GroupBox grpbSealForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBoppSealAdd;
        private System.Windows.Forms.Button btnBoppSealEdit;
        private System.Windows.Forms.Button btnBoppSealDelete;
        private System.Windows.Forms.Button btnBoppSealSave;
        private System.Windows.Forms.Button btnBoppSealCancel;
        private System.Windows.Forms.TextBox txtSealName;
        private System.Windows.Forms.TextBox txtSealAbbreviation;
        private System.Windows.Forms.Label lblSealAbbreviation;
        private System.Windows.Forms.Label lblSealName;
        private System.Windows.Forms.GroupBox grpbAdditivationList;
        private System.Windows.Forms.DataGridView dgvAdditivation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdditivationCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdditivationAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdditivationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdditivationForBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdditivationForCast;
        private System.Windows.Forms.Button btnBoppAdditivationDelete;
        private System.Windows.Forms.Button btnBoppAdditivationEdit;
        private System.Windows.Forms.Button btnBoppAdditivationAdd;
        private System.Windows.Forms.GroupBox grpbAdditivationForm;
        private System.Windows.Forms.TextBox txtAdditivationName;
        private System.Windows.Forms.TextBox txtAdditivationAbbreviation;
        private System.Windows.Forms.Label lblAdditivationAbbreviation;
        private System.Windows.Forms.Label lblAdditivationName;
        private System.Windows.Forms.Button btnBoppAdditivationCancel;
        private System.Windows.Forms.Button btnBoppAdditivationSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSealCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSealAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSealName;
        private System.Windows.Forms.CheckBox chbxCastAdditivation;
        private System.Windows.Forms.CheckBox chbxBoppAdditivation;
        private System.Windows.Forms.GroupBox grpbThicknessList;
        private System.Windows.Forms.GroupBox grpbThicknessForm;
        private System.Windows.Forms.DataGridView dgvThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessValue;
        private System.Windows.Forms.Button btnBoppThicknessDelete;
        private System.Windows.Forms.Button btnBoppThicknessEdit;
        private System.Windows.Forms.Button btnBoppThicknessAdd;
        private System.Windows.Forms.TextBox txtThicknessValue;
        private System.Windows.Forms.Label lblThicknessValue;
        private System.Windows.Forms.GroupBox grpbox2;
        private System.Windows.Forms.Button btnBoppThicknessCancel;
        private System.Windows.Forms.Button btnBoppThicknessSave;
        private System.Windows.Forms.GroupBox grpbTreatmentList;
        private System.Windows.Forms.DataGridView dgvTreatment;
        private System.Windows.Forms.GroupBox grpbTreatmentForm;
        private System.Windows.Forms.Button btnBoppTreatmentDelete;
        private System.Windows.Forms.Button btnBoppTreatmentEdit;
        private System.Windows.Forms.Button btnBoppTreatmentAdd;
        private System.Windows.Forms.TextBox txtTreatmentAbbreviation;
        private System.Windows.Forms.TextBox txtTreatmentName;
        private System.Windows.Forms.Label lblTreatmentAbbreviation;
        private System.Windows.Forms.Label lblTreatmentName;
        private System.Windows.Forms.Button btnBoppTreatmentCancel;
        private System.Windows.Forms.Button btnBoppTreatmentSave;
        private System.Windows.Forms.CheckBox chbxCoatingTreatment;
        private System.Windows.Forms.CheckBox chbxCastTreatment;
        private System.Windows.Forms.CheckBox chbxBoppTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentCoating;
        private System.Windows.Forms.GroupBox grpbProcessList;
        private System.Windows.Forms.GroupBox grpbProcessForm;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.TextBox txtProcessAbbreviation;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblProcessAbbreviation;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Button btnCastProcessAdd;
        private System.Windows.Forms.Button btnCastProcessEdit;
        private System.Windows.Forms.Button btnCastProcessDelete;
        private System.Windows.Forms.Button btnCastProcessSave;
        private System.Windows.Forms.Button btnCastProcessCancel;
        private System.Windows.Forms.GroupBox grpbStructureList;
        private System.Windows.Forms.GroupBox grpbStructureForm;
        private System.Windows.Forms.TextBox txtStructureAbbreviation;
        private System.Windows.Forms.TextBox txtStructureName;
        private System.Windows.Forms.Label lblStructureAbbreviation;
        private System.Windows.Forms.Label lblStructureName;
        private System.Windows.Forms.DataGridView dgvStructure;
        private System.Windows.Forms.Button btnCastStructureCancel;
        private System.Windows.Forms.Button btnCastStructureSave;
        private System.Windows.Forms.Button btnCastStructureDelete;
        private System.Windows.Forms.Button btnCastStructureEdit;
        private System.Windows.Forms.Button btnCastStructureAdd;
        private System.Windows.Forms.GroupBox grpbCastAdditivationList;
        private System.Windows.Forms.GroupBox grpbCastAdditivationForm;
        private System.Windows.Forms.DataGridView dgvCastAdditivation;
        private System.Windows.Forms.CheckBox chbxAdditivationCast;
        private System.Windows.Forms.CheckBox chbxAdditivationBopp;
        private System.Windows.Forms.TextBox txtCastAdditivationAbbreviation;
        private System.Windows.Forms.TextBox txtCastAdditivationName;
        private System.Windows.Forms.Label lblCastAdditivationAbbreviation;
        private System.Windows.Forms.Label lblCastAdditivationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastAdditivationCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastAdditivationAbreviattion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastAdditivationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastAdditivationBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastAdditivationCast;
        private System.Windows.Forms.Button btnCastAdditivationDelete;
        private System.Windows.Forms.Button btnCastAdditivationEdit;
        private System.Windows.Forms.Button btnCastAdditivationAdd;
        private System.Windows.Forms.Button btnCastAdditivationCancel;
        private System.Windows.Forms.Button btnCastAdditivationSave;
        private System.Windows.Forms.GroupBox grpbThicknessCastForm;
        private System.Windows.Forms.GroupBox grpbThicknessCastList;
        private System.Windows.Forms.DataGridView dgvThicknessCast;
        private System.Windows.Forms.Label lblThicknessCastValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessCastCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessCastValue;
        private System.Windows.Forms.Button btnCastThicknessCancel;
        private System.Windows.Forms.Button btnCastThicknessSave;
        private System.Windows.Forms.Button btnCastThicknessDelete;
        private System.Windows.Forms.Button btnCastThicknessEdit;
        private System.Windows.Forms.Button btnCastThicknessAdd;
        private System.Windows.Forms.GroupBox grpbTreatmentCastForm;
        private System.Windows.Forms.GroupBox grpbTreatmentCastList;
        private System.Windows.Forms.CheckBox chbxTreatmentCastCoating;
        private System.Windows.Forms.CheckBox chbxTreatmentCastCast;
        private System.Windows.Forms.CheckBox chbxTreatmentCastBopp;
        private System.Windows.Forms.TextBox txtTreatmentCastAbbreviation;
        private System.Windows.Forms.TextBox txtTreatmentCastName;
        private System.Windows.Forms.Label lblTreatmentCastAbbreviation;
        private System.Windows.Forms.Label lblTreatmentCastName;
        private System.Windows.Forms.DataGridView dgvTreatmentCast;
        private System.Windows.Forms.Button btnCastTreatmentCancel;
        private System.Windows.Forms.Button btnCastTreatmentSave;
        private System.Windows.Forms.Button btnCastTreatmentDelete;
        private System.Windows.Forms.Button btnCastTreatmentEdit;
        private System.Windows.Forms.Button btnCastTreatmentAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmenCastCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcessCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcessAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcessCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcessCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoating;
        private System.Windows.Forms.GroupBox grpbProcessCoatingForm;
        private System.Windows.Forms.GroupBox grpbProcessCoatingList;
        private System.Windows.Forms.DataGridView dgvCoatingProcess;
        private System.Windows.Forms.TextBox txtProcessCoatingName;
        private System.Windows.Forms.Label lblProcessCoatingAbbreviation;
        private System.Windows.Forms.Label lblProcessCoatingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingProcessAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingProcessCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingProcessCoating;
        private System.Windows.Forms.CheckBox chbxProcessCoatingCoating;
        private System.Windows.Forms.CheckBox chbxProcessCoatingCast;
        private System.Windows.Forms.TextBox txtProcessCoatingAbbreviation;
        private System.Windows.Forms.Button btnCoatingProcessCancel;
        private System.Windows.Forms.Button btnCoatingProcessSave;
        private System.Windows.Forms.Button btnCoatingProcessDelete;
        private System.Windows.Forms.Button btnCoatingProcessAdd;
        private System.Windows.Forms.Button btnCoatingProcessEdit;
        private System.Windows.Forms.GroupBox grpbStructureCoatingList;
        private System.Windows.Forms.GroupBox grpbStructureCoatingForm;
        private System.Windows.Forms.CheckBox chbxCoatingStructureCoating;
        private System.Windows.Forms.CheckBox chbxCoatingStructureCast;
        private System.Windows.Forms.TextBox txtCoatingStructureAbbreviation;
        private System.Windows.Forms.TextBox txtCoatingStructureName;
        private System.Windows.Forms.Label lblCoatingStructureAbbreviation;
        private System.Windows.Forms.Label lblCoatingStructureName;
        private System.Windows.Forms.DataGridView dgvCoatingStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoatingCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoatingAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoatingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoatingCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStructureCoatingCoating;
        private System.Windows.Forms.GroupBox grpbThicknessCoatingList;
        private System.Windows.Forms.GroupBox grpbThicknessCoatingForm;
        private System.Windows.Forms.DataGridView dgvCoatingThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessCoatingCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThicknessCoatingValue;
        private System.Windows.Forms.TextBox txtThicknessCoating;
        private System.Windows.Forms.Label lblThicknessCoating;
        private System.Windows.Forms.Button btnCoatingStructureCancel;
        private System.Windows.Forms.Button btnCoatingStructureSave;
        private System.Windows.Forms.Button btnCoatingStructureDelete;
        private System.Windows.Forms.Button btnCoatingStructureAdd;
        private System.Windows.Forms.Button btnCoatingStructureEdit;
        private System.Windows.Forms.Button btnCoatingThicknessDelete;
        private System.Windows.Forms.Button btnCoatingThicknessAdd;
        private System.Windows.Forms.Button btnCoatingThicknessEdit;
        private System.Windows.Forms.Button btnCoatingThicknessCancel;
        private System.Windows.Forms.Button btnCoatingThicknessSave;
        private System.Windows.Forms.TextBox txtThicknessCastValue;
        private System.Windows.Forms.GroupBox grpbTreatmentCoatingForm;
        private System.Windows.Forms.GroupBox grpbTreatmentCoatingList;
        private System.Windows.Forms.DataGridView dgvCoatingTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingTreatmentCoating;
        private System.Windows.Forms.TextBox txtCoatingTreatmentAbbreviation;
        private System.Windows.Forms.TextBox txtCoatingTreatmentName;
        private System.Windows.Forms.CheckBox chbxCoatingTreatmentCoating;
        private System.Windows.Forms.CheckBox chbxCoatingTreatmentCast;
        private System.Windows.Forms.CheckBox chbxCoatingTreatmentBopp;
        private System.Windows.Forms.Label lblCoatingTreatmentAbbreviation;
        private System.Windows.Forms.Label lblCoatingTreatmentName;
        private System.Windows.Forms.Button btnCoatingTreatmentCancel;
        private System.Windows.Forms.Button btnCoatingTreatmentSave;
        private System.Windows.Forms.Button btnCoatingTreatmentDelete;
        private System.Windows.Forms.Button btnCoatingTreatmentAdd;
        private System.Windows.Forms.Button btnCoatingTreatmentEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyName;
        private System.Windows.Forms.CheckBox chbxProcessCast;
        private System.Windows.Forms.CheckBox chbxProcessCoating;
        private System.Windows.Forms.CheckBox chbxStructureCoating;
        private System.Windows.Forms.CheckBox chbxStructureCast;
        private System.Windows.Forms.GroupBox grpbLanguageList;
        private System.Windows.Forms.GroupBox grpbLanguageForm;
        private System.Windows.Forms.DataGridView dgvLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanguageCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanguageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanguageAbbreviation;
        private System.Windows.Forms.TextBox txtLanguageAbbreviation;
        private System.Windows.Forms.TextBox txtLanguageName;
        private System.Windows.Forms.Label lblLanguageAbbreviation;
        private System.Windows.Forms.Label lblLanguageName;
        private System.Windows.Forms.Button btnLanguageSave;
        private System.Windows.Forms.Button btnLanguageCancel;
        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Button btnLanguageEdit;
        private System.Windows.Forms.Button btnLanguageDelete;
        private System.Windows.Forms.GroupBox grpbCommercialConditionForm;
        private System.Windows.Forms.GroupBox grpbCommercialConditionList;
        private System.Windows.Forms.DataGridView dgvCommercialCondition;
        private System.Windows.Forms.TextBox txtCommercialConditionDescription;
        private System.Windows.Forms.TextBox txtCommercialConditionName;
        private System.Windows.Forms.Label lblCommercialConditionDescription;
        private System.Windows.Forms.Label lblCommercialConditionName;
        private System.Windows.Forms.Button btnCommercialConditionEdit;
        private System.Windows.Forms.Button btnCommercialConditionAdd;
        private System.Windows.Forms.Button btnCommercialConditionCancel;
        private System.Windows.Forms.Button btnCommercialConditionSave;
        private System.Windows.Forms.Button btnCommercialConditionDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCommercialConditionCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCommercialConditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCommercialConditionDescription;
        private System.Windows.Forms.GroupBox grpbidtypeForm;
        private System.Windows.Forms.GroupBox grpbidtypeList;
        private System.Windows.Forms.TextBox txtIdtypeName;
        private System.Windows.Forms.Label lblIdtypeName;
        private System.Windows.Forms.DataGridView dgvIdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdTypeCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdTypeName;
        private System.Windows.Forms.Button btnIdTypeAdd;
        private System.Windows.Forms.Button btnIdTypeEdit;
        private System.Windows.Forms.Button btnIdTypeDelete;
        private System.Windows.Forms.Button btnIdTypeCancel;
        private System.Windows.Forms.Button btnIdTypeSave;
        private System.Windows.Forms.GroupBox grpbSectorList;
        private System.Windows.Forms.GroupBox grpbSectorForm;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.Label lblSectorName;
        private System.Windows.Forms.DataGridView dgvSector;
        private System.Windows.Forms.Button btnSectorAdd;
        private System.Windows.Forms.Button btnSectorEdit;
        private System.Windows.Forms.Button btnSectorDelete;
        private System.Windows.Forms.Button btnSectorCancel;
        private System.Windows.Forms.Button btnSectorSave;
        private System.Windows.Forms.GroupBox grpbRoleList;
        private System.Windows.Forms.GroupBox grpbRoleForm;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TextBox txtRoleDescription;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleDescription;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleDescription;
        private System.Windows.Forms.Button btnRoleCancel;
        private System.Windows.Forms.Button btnRoleSave;
        private System.Windows.Forms.Button btnRoleDelete;
        private System.Windows.Forms.Button btnRoleEdit;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.GroupBox grpbInningList;
        private System.Windows.Forms.GroupBox grpbInningForm;
        private System.Windows.Forms.DataGridView dgvInning;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInningCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInningName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInningDescription;
        private System.Windows.Forms.Label lblInningDescription;
        private System.Windows.Forms.TextBox txtInningName;
        private System.Windows.Forms.Label lblInningName;
        private System.Windows.Forms.TextBox txtInningDescription;
        private System.Windows.Forms.Button btnInningCancel;
        private System.Windows.Forms.Button btnInningSave;
        private System.Windows.Forms.Button btnInningDelete;
        private System.Windows.Forms.Button btnInningEdit;
        private System.Windows.Forms.Button btnInningAdd;
        private System.Windows.Forms.GroupBox grpbCurrencyForm;
        private System.Windows.Forms.Button btnCurrencySave;
        private System.Windows.Forms.Button btnCurrencyCancel;
        private System.Windows.Forms.TextBox txtCurrencyDecimal;
        private System.Windows.Forms.TextBox txtCurrencySymbol;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.Label lblCurrencyDecimal;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.GroupBox grpbCurrencyList;
        private System.Windows.Forms.Button btnCurrencyAdd;
        private System.Windows.Forms.Button btnCurrencyEdit;
        private System.Windows.Forms.Button btnCurrencyDelete;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrencySymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrencyDecimal;
        private System.Windows.Forms.GroupBox grpbUserForm;
        private System.Windows.Forms.GroupBox grpbUserList;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserUserName;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserUserName;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserInning;
        private System.Windows.Forms.ComboBox cmbUserInning;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.CheckBox chbxPasswordChange;
        private System.Windows.Forms.GroupBox grpbStatusGroupList;
        private System.Windows.Forms.GroupBox grpbStatusGroupForm;
        private System.Windows.Forms.Label lblStatusGroupName;
        private System.Windows.Forms.DataGridView dgvStatusGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusGroupCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusGroupName;
        private System.Windows.Forms.TextBox txtStatusGroupName;
        private System.Windows.Forms.Button btnStatusGroupAdd;
        private System.Windows.Forms.Button btnStatusGroupDelete;
        private System.Windows.Forms.Button btnStatusGroupEdit;
        private System.Windows.Forms.Button btnStatusGroupCancel;
        private System.Windows.Forms.Button btnStatusGroupSave;
        private System.Windows.Forms.GroupBox grpbStatusForm;
        private System.Windows.Forms.GroupBox grpbStatusList;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Label lblStatusGroup;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Label lblStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusStatusGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusUserCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusModificatorUser;
        private System.Windows.Forms.TextBox txtStatusDescription;
        private System.Windows.Forms.Label lblStatusDescription;
        private System.Windows.Forms.ComboBox cmbStatusGroup;
        private System.Windows.Forms.Button btnStatusDelete;
        private System.Windows.Forms.Button btnStatusAdd;
        private System.Windows.Forms.Button btnStatusEdit;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusSave;
        private System.Windows.Forms.ComboBox cmbUserStatus;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserInningName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserCreatorUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserModificatorDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserModificatorUser;
        private System.Windows.Forms.GroupBox grpbPlantForm;
        private System.Windows.Forms.GroupBox grpbPlantList;
        private System.Windows.Forms.DataGridView dgvPlant;
        private System.Windows.Forms.TextBox txtPlantName;
        private System.Windows.Forms.Label lblPlantName;
        private System.Windows.Forms.Button btnPlantCancel;
        private System.Windows.Forms.Button btnPlantSave;
        private System.Windows.Forms.Button btnPlantAdd;
        private System.Windows.Forms.Button btnPlantEdit;
        private System.Windows.Forms.Button btnPlantDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlantCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlantName;
        private System.Windows.Forms.ListBox lstbPlant;
        private System.Windows.Forms.RadioButton rdoOnePlant;
        private System.Windows.Forms.RadioButton rdoMorePlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSectorCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSectorPlantName;
        private System.Windows.Forms.GroupBox grpbExtruderForm;
        private System.Windows.Forms.GroupBox grpbExtruderList;
        private System.Windows.Forms.DataGridView dgvExtruder;
        private System.Windows.Forms.Label lblExtruderName;
        private System.Windows.Forms.TextBox txtExtruderKilogramsPerHour;
        private System.Windows.Forms.TextBox txtExtruderMinFilmWidth;
        private System.Windows.Forms.TextBox txtExtruderCoilNumber;
        private System.Windows.Forms.TextBox txtExtruderName;
        private System.Windows.Forms.Label lblExtruderKilogramsPerHour;
        private System.Windows.Forms.Label lblExtruderCoilNumber;
        private System.Windows.Forms.Label lblExtruderMinFilmWidth;
        private System.Windows.Forms.Button btnExtruderDelete;
        private System.Windows.Forms.Button btnExtruderAdd;
        private System.Windows.Forms.Button btnExtruderEdit;
        private System.Windows.Forms.Label lblExtruderSector;
        private System.Windows.Forms.Button btnExtruderCancel;
        private System.Windows.Forms.Button btnExtruderSave;
        private System.Windows.Forms.ComboBox cmbxExtruderStatus;
        private System.Windows.Forms.Label lblExtruderStatus;
        private System.Windows.Forms.ComboBox cmbxExtruderSector;
        private System.Windows.Forms.GroupBox grpbCutterForm;
        private System.Windows.Forms.GroupBox grpbCutterList;
        private System.Windows.Forms.DataGridView dgvCutter;
        private System.Windows.Forms.Label lblCutterFilmWidth;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.TextBox txtCutterMaxVelocity;
        private System.Windows.Forms.Label lblCutterMaxVelocity;
        private System.Windows.Forms.TextBox txtCutterArms;
        private System.Windows.Forms.Label lblCutterArms;
        private System.Windows.Forms.TextBox txtCutterFilmWidth;
        private System.Windows.Forms.TextBox txtCutterName;
        private System.Windows.Forms.Button btnCutterDelete;
        private System.Windows.Forms.Button btnCutterAdd;
        private System.Windows.Forms.Button btnCutterEdit;
        private System.Windows.Forms.Button btnCutterCancel;
        private System.Windows.Forms.Button btnCutterSave;
        private System.Windows.Forms.GroupBox grpbMetallizerForm;
        private System.Windows.Forms.GroupBox grpbMetallizerList;
        private System.Windows.Forms.TextBox txtMetallizerMaxVelocity;
        private System.Windows.Forms.TextBox txtMetallizerMinFilmWidth;
        private System.Windows.Forms.Label lblMetallizerMaxVelocity;
        private System.Windows.Forms.Label lblMetallizerMinFilmWidth;
        private System.Windows.Forms.Label lblMetallizerName;
        private System.Windows.Forms.TextBox txtMetallizerName;
        private System.Windows.Forms.DataGridView dgvMetallizer;
        private System.Windows.Forms.Button btnMetallizerCancel;
        private System.Windows.Forms.Button btnMetallizerSave;
        private System.Windows.Forms.Button btnMetallizerDelete;
        private System.Windows.Forms.Button btnMetallizerAdd;
        private System.Windows.Forms.Button btnMetallizerEdit;
        private System.Windows.Forms.GroupBox grpbMillForm;
        private System.Windows.Forms.GroupBox grpbMillList;
        private System.Windows.Forms.Label lblMillName;
        private System.Windows.Forms.DataGridView dgvMill;
        private System.Windows.Forms.TextBox txtMillName;
        private System.Windows.Forms.TextBox txtMillKilogramsPerHour;
        private System.Windows.Forms.Label lblMillKilogramsPerHour;
        private System.Windows.Forms.Label lblMillStatus;
        private System.Windows.Forms.Label lblMillSector;
        private System.Windows.Forms.ComboBox cmbxMillStatus;
        private System.Windows.Forms.ComboBox cmbxMillSector;
        private System.Windows.Forms.Label lblMetallizerSector;
        private System.Windows.Forms.ComboBox cmbxMetallizerStatus;
        private System.Windows.Forms.Label lblMetallizerStatus;
        private System.Windows.Forms.ComboBox cmbxMetallizerSector;
        private System.Windows.Forms.Button btnMillDelete;
        private System.Windows.Forms.Button btnMillAdd;
        private System.Windows.Forms.Button btnMillEdit;
        private System.Windows.Forms.ComboBox cmbxCutterStatus;
        private System.Windows.Forms.Label lblCutterStatus;
        private System.Windows.Forms.ComboBox cmbxCutterSector;
        private System.Windows.Forms.Label lblCutterSector;
        private System.Windows.Forms.Button btnMillCancel;
        private System.Windows.Forms.Button btnMillSave;
        private System.Windows.Forms.ComboBox cmbxMillPlant;
        private System.Windows.Forms.Label lblMillPlant;
        private System.Windows.Forms.ComboBox cmbxCutterPlant;
        private System.Windows.Forms.Label lblCutterPlant;
        private System.Windows.Forms.ComboBox cmbxExtruderPlant;
        private System.Windows.Forms.Label lblExtruderPlant;
        private System.Windows.Forms.ComboBox cmbxMetallizerPlant;
        private System.Windows.Forms.Label lblMetallizerPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillKilogramsPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMillStatus;
        private System.Windows.Forms.GroupBox grpbRawMaterialTypeList;
        private System.Windows.Forms.GroupBox grpbRawMaterialTypeForm;
        private System.Windows.Forms.DataGridView dgvRawMaterialType;
        private System.Windows.Forms.TextBox txtRawMaterialTypeName;
        private System.Windows.Forms.Label lblRawMaterialTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterilaTypeCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterilaTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterilaTypeCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeCreatorUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeModificatorUser;
        private System.Windows.Forms.Button btnRawMaterialTypeDelete;
        private System.Windows.Forms.Button btnRawMaterialTypeAdd;
        private System.Windows.Forms.Button btnRawMaterialTypeEdit;
        private System.Windows.Forms.Button btnRawMaterialTypeCancel;
        private System.Windows.Forms.Button btnRawMaterialTypeSave;
        private System.Windows.Forms.GroupBox grpbBalanceForm;
        private System.Windows.Forms.GroupBox grpbBalanceList;
        private System.Windows.Forms.DataGridView dgvBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceDelimeterOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceDelimeterTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceComm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalancePlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalanceStatus;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblBalanceName;
        private System.Windows.Forms.Label lblBalanceCapacity;
        private System.Windows.Forms.ComboBox cmbBalanceunit;
        private System.Windows.Forms.Label lblBalanceUnit;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblBalanceDelimeterTwo;
        private System.Windows.Forms.TextBox txtBalanceDelimeterOne;
        private System.Windows.Forms.Label lblBalanceDelimeterOne;
        private System.Windows.Forms.TextBox txtBalanceComm;
        private System.Windows.Forms.Label lblBalanceComm;
        private System.Windows.Forms.TextBox txtBalanceDelimeterTwo;
        private System.Windows.Forms.Label lblBalanceCommand;
        private System.Windows.Forms.TextBox txtBalanceCommand;
        private System.Windows.Forms.Button btnBalanceSave;
        private System.Windows.Forms.Button btnBalanceCancel;
        private System.Windows.Forms.Label lblBalancePlant;
        private System.Windows.Forms.Label lblBalanceStatus;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblBalanceSector;
        private System.Windows.Forms.ComboBox cmbBalancePlant;
        private System.Windows.Forms.ComboBox cmbBalanceStatus;
        private System.Windows.Forms.Button btnBalanceDelete;
        private System.Windows.Forms.Button btnBalanceAdd;
        private System.Windows.Forms.Button btnBalanceEdit;
        private System.Windows.Forms.GroupBox grpbRawMaterialTypeByEntityList;
        private System.Windows.Forms.GroupBox grpbRawMaterialTypeByEntityForm;
        private System.Windows.Forms.DataGridView dgvRawMaterialTypeByEntity;
        private System.Windows.Forms.ComboBox cmbRawMaterialTypeByEntityEntityName;
        private System.Windows.Forms.Label lblRawMaterialTypeByEntityEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeByEntityModifiedBy;
        private System.Windows.Forms.Button btnRMTypeByEntityAdd;
        private System.Windows.Forms.Button btnRMTypeByEntityEdit;
        private System.Windows.Forms.Button btnRMTypeByEntityDelete;
        private System.Windows.Forms.RadioButton rdoManyTypes;
        private System.Windows.Forms.RadioButton rdoOneType;
        private System.Windows.Forms.Button btnRMTypeByEntityCancel;
        private System.Windows.Forms.Button btnRMTypeByEntitySave;
        private System.Windows.Forms.ListBox lstbTypes;
        private System.Windows.Forms.TextBox txtExtruderMaxVelocity;
        private System.Windows.Forms.Label lblExtruderMaxVelocity;
        private System.Windows.Forms.TextBox txtExtruderMaxFilmWidth;
        private System.Windows.Forms.Label lblExtruderMaxFilmWidth;
        private System.Windows.Forms.GroupBox grpbProductionLineForm;
        private System.Windows.Forms.GroupBox grpbProductionLineList;
        private System.Windows.Forms.Label lblProductionLinePlant;
        private System.Windows.Forms.DataGridView dgvProductionLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionLineCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionLinePlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionLineNumberLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionLineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionLineDescription;
        private System.Windows.Forms.TextBox txtProductionLineName;
        private System.Windows.Forms.Label lblProductionLineName;
        private System.Windows.Forms.TextBox txtProductionLineLine;
        private System.Windows.Forms.Label lblProductionLineLine;
        private System.Windows.Forms.ComboBox cmbProductionLinePlant;
        private System.Windows.Forms.TextBox txtProductionLineDescription;
        private System.Windows.Forms.Label lblProductionLineDescription;
        private System.Windows.Forms.Button btnProductionLineDelete;
        private System.Windows.Forms.Button btnProductionLineAdd;
        private System.Windows.Forms.Button btnProductionLineEdit;
        private System.Windows.Forms.Button btnProductionLineCancel;
        private System.Windows.Forms.Button btnProductionLineSave;
        private System.Windows.Forms.Label lblExtruderLine;
        private System.Windows.Forms.ComboBox cmbExtruderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderminFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtrudermaxFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtrudermaxVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderCoilNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderKilogramsPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderProductionLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruderStatus;
        private System.Windows.Forms.ComboBox cmbCutterLine;
        private System.Windows.Forms.Label lblCutterLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterArms;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterUtilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterMaxVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterProductionLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutterStatus;
        private System.Windows.Forms.ComboBox cmbMetallizerLine;
        private System.Windows.Forms.Label lblMetallizerLine;
        private System.Windows.Forms.Label lblMetallizerMaxFilmWidth;
        private System.Windows.Forms.TextBox txtMetallizerMaxDiameter;
        private System.Windows.Forms.Label lblMetallizerMaxDiameter;
        private System.Windows.Forms.TextBox txtMetallizerMaxFilmWidth;
        private System.Windows.Forms.GroupBox grpbUnitList;
        private System.Windows.Forms.GroupBox grpbUnitForm;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitSymbol;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitSymbol;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtUnitSymbol;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Button btnUnitEdit;
        private System.Windows.Forms.Button btnUnitDelete;
        private System.Windows.Forms.Button btnUnitCancel;
        private System.Windows.Forms.Button btnUnitSave;
        private System.Windows.Forms.GroupBox grpbCoreList;
        private System.Windows.Forms.GroupBox grpbCoreForm;
        private System.Windows.Forms.DataGridView dgvCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreValue;
        private System.Windows.Forms.TextBox txtCoreValue;
        private System.Windows.Forms.TextBox txtCoreName;
        private System.Windows.Forms.Label lblCoreValue;
        private System.Windows.Forms.Label lblCoreName;
        private System.Windows.Forms.Button btnCoreCancel;
        private System.Windows.Forms.Button btnCoreSave;
        private System.Windows.Forms.Button btnCoreAdd;
        private System.Windows.Forms.Button btnCoreEdit;
        private System.Windows.Forms.Button btnCoreDelete;
        private System.Windows.Forms.GroupBox grpbIncotermsForm;
        private System.Windows.Forms.GroupBox grpbIncotermsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvIncoterms;
        private System.Windows.Forms.Button btnIncotermsAdd;
        private System.Windows.Forms.Button btnIncotermsEdit;
        private System.Windows.Forms.Button btnIncotermsDelete;
        private System.Windows.Forms.TextBox txtIncotermsDescription;
        private System.Windows.Forms.Label lblIncotermsDescription;
        private System.Windows.Forms.TextBox txtIncotermsAbbreviation;
        private System.Windows.Forms.Label lblIncotermsAbbreviation;
        private System.Windows.Forms.TextBox txtIncotermsName;
        private System.Windows.Forms.Label lblIncotermsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIncotermsCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIncotermsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIncotermsAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIncotermsDescription;
        private System.Windows.Forms.Button btnIncotermsCancel;
        private System.Windows.Forms.Button btnIncotermsSave;
        private System.Windows.Forms.GroupBox grpbRawMaterialList;
        private System.Windows.Forms.GroupBox grpbRawMaterialForm;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.Label lblRawMaterialEntity;
        private System.Windows.Forms.Label lblRawMaterialType;
        private System.Windows.Forms.ComboBox cmbRawMaterialEntity;
        private System.Windows.Forms.ComboBox cmbRawMaterialType;
        private System.Windows.Forms.TextBox txtRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialCode;
        private System.Windows.Forms.TextBox txtRawMaterialCode;
        private System.Windows.Forms.ComboBox cmbPackagingType;
        private System.Windows.Forms.Label lblPackagingType;
        private System.Windows.Forms.ComboBox cmbRawMaterialUnit;
        private System.Windows.Forms.Label lblRawMaterialUnit;
        private System.Windows.Forms.TextBox txtRawMaterialNote;
        private System.Windows.Forms.Label lblRawMaterialNote;
        private System.Windows.Forms.Button btnRawMaterialAdd;
        private System.Windows.Forms.Button btnRawMaterialEdit;
        private System.Windows.Forms.Button btnRawMaterialDelete;
        private System.Windows.Forms.Button btnRawMaterialCancel;
        private System.Windows.Forms.Button btnRawMaterialSave;
        private System.Windows.Forms.GroupBox grpbPackagingForm;
        private System.Windows.Forms.GroupBox grpbPackagingList;
        private System.Windows.Forms.Label lblPackagingTypeInitial;
        private System.Windows.Forms.Label lblPackagingTypeName;
        private System.Windows.Forms.DataGridView dgvPackagingType;
        private System.Windows.Forms.TextBox txtPackagingTypeInitial;
        private System.Windows.Forms.TextBox txtPackagingTypeName;
        private System.Windows.Forms.Button btnPackagingTypeAdd;
        private System.Windows.Forms.Button btnPackagingTypeEdit;
        private System.Windows.Forms.Button btnPackagingTypeDelete;
        private System.Windows.Forms.Button btnPackagingTypeCancel;
        private System.Windows.Forms.Button btnPackagingTypeSave;
        private System.Windows.Forms.GroupBox grpbDiameterList;
        private System.Windows.Forms.GroupBox grpbDiameterForm;
        private System.Windows.Forms.DataGridView dgvDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterValue;
        private System.Windows.Forms.TextBox txtDiameterValue;
        private System.Windows.Forms.TextBox txtDiameterInitial;
        private System.Windows.Forms.TextBox txtDiameterName;
        private System.Windows.Forms.Label lblDiameterValue;
        private System.Windows.Forms.Label lblDiameterInitial;
        private System.Windows.Forms.Label lblDiameterName;
        private System.Windows.Forms.Button btnDiameterAdd;
        private System.Windows.Forms.Button btnDiameterEdit;
        private System.Windows.Forms.Button btnDiameterDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDiameterSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialPackagingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCreatorUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialModificatorUser;
        private System.Windows.Forms.GroupBox grpbLayerList;
        private System.Windows.Forms.GroupBox grpbLayerForm;
        private System.Windows.Forms.DataGridView dgvLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLayerCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLayerDescription;
        private System.Windows.Forms.TextBox txtLayerDescription;
        private System.Windows.Forms.Label lblLayerDescription;
        private System.Windows.Forms.TextBox txtLayerName;
        private System.Windows.Forms.Label lblLayerName;
        private System.Windows.Forms.Button btnLayerCancel;
        private System.Windows.Forms.Button btnLayerSave;
        private System.Windows.Forms.Button btnLayerAdd;
        private System.Windows.Forms.Button btnLayerEdit;
        private System.Windows.Forms.Button btnLayerDelete;
        private System.Windows.Forms.GroupBox grpbTransportForm;
        private System.Windows.Forms.GroupBox grpbTransportList;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportusefulWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportusefulHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportusefulLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportGrossCapacity;
        private System.Windows.Forms.TextBox txtTransportGrossCapacity;
        private System.Windows.Forms.Label lblTransportGrossCapacity;
        private System.Windows.Forms.TextBox txtTransportusefulLong;
        private System.Windows.Forms.Label lblTransportusefulLong;
        private System.Windows.Forms.TextBox txtTransportusefulHigh;
        private System.Windows.Forms.Label lblTransportusefulHigh;
        private System.Windows.Forms.TextBox txtTransportusefulWidth;
        private System.Windows.Forms.Label lblTransportusefulWidth;
        private System.Windows.Forms.TextBox txtTransportName;
        private System.Windows.Forms.Label lblTransportName;
        private System.Windows.Forms.Button btnTransportAdd;
        private System.Windows.Forms.Button btnTransportEdit;
        private System.Windows.Forms.Button btnTransportDelete;
        private System.Windows.Forms.Button btnTransportCancel;
        private System.Windows.Forms.Button btnTransportSave;
        private System.Windows.Forms.GroupBox grpbDecreasForm;
        private System.Windows.Forms.GroupBox grpbDecreasList;
        private System.Windows.Forms.TextBox txtDecreaseDescription;
        private System.Windows.Forms.TextBox txtDecreaseName;
        private System.Windows.Forms.Label lblDecreaseDescription;
        private System.Windows.Forms.Label lblDecreaseName;
        private System.Windows.Forms.DataGridView dgvDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseDescription;
        private System.Windows.Forms.Button btnDecreaseCancel;
        private System.Windows.Forms.Button btnDecreaseSave;
        private System.Windows.Forms.Button btnDecreaseDelete;
        private System.Windows.Forms.Button btnDecreaseAdd;
        private System.Windows.Forms.Button btnDecreaseEdit;
        private System.Windows.Forms.GroupBox grpbMainCoilTypeForm;
        private System.Windows.Forms.GroupBox grpbMainCoilTypeList;
        private System.Windows.Forms.DataGridView dgvMainCoilType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilTypeCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilTypeDescription;
        private System.Windows.Forms.Label lblMainCoilTypeDescription;
        private System.Windows.Forms.Label lblMainCoilTypeName;
        private System.Windows.Forms.TextBox txtMainCoilTypeDescription;
        private System.Windows.Forms.TextBox txtMainCoilTypeName;
        private System.Windows.Forms.Button btnMainCoilTypeDelete;
        private System.Windows.Forms.Button btnMainCoilTypeAdd;
        private System.Windows.Forms.Button btnMainCoilTypeEdit;
        private System.Windows.Forms.Button btnMainCoilTypeCancel;
        private System.Windows.Forms.Button btnMainCoilTypeSave;
        private System.Windows.Forms.ComboBox cmbPackagingTypeUnit;
        private System.Windows.Forms.Label lblPackagingTypeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPackagingTypeCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPackagingTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPackagingTypeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPackagingTypeInitial;
        private System.Windows.Forms.GroupBox grpbCoilers;
        private System.Windows.Forms.Button btnSaveCoiler;
        private System.Windows.Forms.DataGridView dgvCoilers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilerExtruderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilerMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilerNumber;
        private System.Windows.Forms.GroupBox grpbCellarList;
        private System.Windows.Forms.Button btnAddCellar;
        private System.Windows.Forms.Button btnDeleteCellar;
        private System.Windows.Forms.Button btnEditCellar;
        private System.Windows.Forms.DataGridView dgvCellar;
        private System.Windows.Forms.GroupBox grpbCellarForm;
        private System.Windows.Forms.Button btnCancelCellar;
        private System.Windows.Forms.TextBox txtCellarName;
        private System.Windows.Forms.Button btnSaveCellar;
        private System.Windows.Forms.Label lblCellarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarDescription;
        private System.Windows.Forms.TextBox txtCellarDescription;
        private System.Windows.Forms.Label lblCellarDescription;
        private System.Windows.Forms.GroupBox grpbSupply;
        private System.Windows.Forms.Button btnSupplyAdd;
        private System.Windows.Forms.Button btnSupplyEdit;
        private System.Windows.Forms.Button btnSupplyDelete;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.GroupBox grpbSupplyForm;
        private System.Windows.Forms.Button btnSupplyCancel;
        private System.Windows.Forms.Button btnSupplySave;
        private System.Windows.Forms.TextBox txtSupplyNotes;
        private System.Windows.Forms.Label lblSupplyNotes;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtSupplyCode;
        private System.Windows.Forms.Label lblSupplyCode;
        private System.Windows.Forms.TextBox txtSupplyName;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.ComboBox cmbSupplyEntity;
        private System.Windows.Forms.Label lblSupplyEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyModifiedBy;
        private System.Windows.Forms.GroupBox grpbSubbplyByEntityDetail;
        private System.Windows.Forms.Button btnSupplyByEntityAdd;
        private System.Windows.Forms.Button btnSupplyByEntityEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvSupplyByEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyByEntityCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyByEntityfkEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyByEntityEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyByEntityfkSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyByEntitySupplyName;
        private System.Windows.Forms.GroupBox grpbSubbplyByEntityForm;
        private System.Windows.Forms.ComboBox cmbSupplyByentitySupply;
        private System.Windows.Forms.Label lblSupplyByentitySupply;
        private System.Windows.Forms.Button btnSupplyByEntityCancel;
        private System.Windows.Forms.Button btnSupplyByEntitySave;
        private System.Windows.Forms.ComboBox cmbSupplyByentityEntity;
        private System.Windows.Forms.Label lblSupplyByentityEntity;
        private System.Windows.Forms.GroupBox grpbColorForm;
        private System.Windows.Forms.Button btnColorCancel;
        private System.Windows.Forms.Button btnColorSave;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.GroupBox grpbColorView;
        private System.Windows.Forms.Button btnColorAdd;
        private System.Windows.Forms.DataGridView dgvColorDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColorCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColorCode;
        private System.Windows.Forms.Button btnColorEdit;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.GroupBox grpbOunceForm;
        private System.Windows.Forms.Button btnOunceCancel;
        private System.Windows.Forms.Button btnOunceSave;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.GroupBox grpbOunceView;
        private System.Windows.Forms.Button btnOunceAdd;
        private System.Windows.Forms.DataGridView dgvOunce;
        private System.Windows.Forms.Button btnOunceEdit;
        private System.Windows.Forms.Button btnOunceDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOunceCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOunceValue;
        private System.Windows.Forms.GroupBox grpbThermoformedDetail;
        private System.Windows.Forms.Button btnThermoformedDelete;
        private System.Windows.Forms.Button btnThermoformedAdd;
        private System.Windows.Forms.Button btnThermoformedEdit;
        private System.Windows.Forms.DataGridView dgvThermoformed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedMinHitsPerMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedMaxHitsPerMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermoformedIncludeExtruder;
        private System.Windows.Forms.GroupBox grpbThermoformedForm;
        private System.Windows.Forms.CheckBox chbxThermoformedIncludeExtruder;
        private System.Windows.Forms.TextBox txtThermoformedMaxHitsPerMinute;
        private System.Windows.Forms.Label lblThermoformedMaxHitsPerMinute;
        private System.Windows.Forms.TextBox txtThermoformedMinHitsPerMinute;
        private System.Windows.Forms.Label lblThermoformedMinHitsPerMinute;
        private System.Windows.Forms.Button btnThermoformedCancel;
        private System.Windows.Forms.Button btnThermoformedSave;
        private System.Windows.Forms.TextBox txtThermoformedFilmWidth;
        private System.Windows.Forms.TextBox txtThermoformedName;
        private System.Windows.Forms.Label lblThermoformedFilmWidth;
        private System.Windows.Forms.Label lblThermoformedName;
        private System.Windows.Forms.GroupBox grpbMoldView;
        private System.Windows.Forms.Button btnMoldDelete;
        private System.Windows.Forms.Button btnMoldAdd;
        private System.Windows.Forms.Button btnMoldEdit;
        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoldCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoldDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoldProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoldCavityNumber;
        private System.Windows.Forms.GroupBox grpbMoldForm;
        private System.Windows.Forms.ComboBox cmbMoldProduct;
        private System.Windows.Forms.TextBox txtMoldDescription;
        private System.Windows.Forms.Label lblMoldDescription;
        private System.Windows.Forms.TextBox txtMoldCavityNumber;
        private System.Windows.Forms.Label lblMoldCavityNumber;
        private System.Windows.Forms.Button btnMoldCancel;
        private System.Windows.Forms.Button btnMoldSave;
        private System.Windows.Forms.TextBox txtMoldName;
        private System.Windows.Forms.Label lblMoldProduct;
        private System.Windows.Forms.Label lblMoldName;
        private System.Windows.Forms.GroupBox grpbThermExtruderView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThermExtruderAdd;
        private System.Windows.Forms.Button btnThermExtruderEdit;
        private System.Windows.Forms.DataGridView dgvThermExtruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderCodesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderMinFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderMaxFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderMaxVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderCoilNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermExtruderKgPerHour;
        private System.Windows.Forms.GroupBox grpbThermExtruderForm;
        private System.Windows.Forms.TextBox txtThermExtruderKgPerHour;
        private System.Windows.Forms.TextBox txtThermExtruderCoilNumbers;
        private System.Windows.Forms.Label lblThermExtruderKgPerHour;
        private System.Windows.Forms.Label lblThermExtruderCoilNumbers;
        private System.Windows.Forms.TextBox txtThermExtruderMaxVelocity;
        private System.Windows.Forms.TextBox txtThermExtruderMaxFilmWidth;
        private System.Windows.Forms.Label lblThermExtruderMaxVelocity;
        private System.Windows.Forms.Label lblThermExtruderMaxFilmWidth;
        private System.Windows.Forms.TextBox txtThermExtruderMinFilmWidth;
        private System.Windows.Forms.Button btnThermExtruderCancel;
        private System.Windows.Forms.Button btnThermExtruderSave;
        private System.Windows.Forms.TextBox txtThermExtruderName;
        private System.Windows.Forms.Label lblThermExtruderMinFilmWidth;
        private System.Windows.Forms.Label lblThermExtruderName;
        private System.Windows.Forms.GroupBox grpbThermDefectsView;
        private System.Windows.Forms.Button btnThermDefectsDelete;
        private System.Windows.Forms.Button btnThermDefectsAdd;
        private System.Windows.Forms.Button btnThermDefectsEdit;
        private System.Windows.Forms.DataGridView dgvThermDefect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermDefectsCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermDefectsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThermDefectsDescription;
        private System.Windows.Forms.GroupBox grpbThermDefectsForm;
        private System.Windows.Forms.TextBox txtThermDefectDescription;
        private System.Windows.Forms.Label lblThermDefectDescription;
        private System.Windows.Forms.Button btnThermDefectsCancel;
        private System.Windows.Forms.Button btnThermDefectsSave;
        private System.Windows.Forms.TextBox txtThermDefectName;
        private System.Windows.Forms.Label lblThermDefectName;
        private System.Windows.Forms.ToolTip ttpSystemConfig;
        private System.Windows.Forms.GroupBox grpbCellarByExtruderList;
        private System.Windows.Forms.Button btnCellarByExtDelete;
        private System.Windows.Forms.Button btnCellarByExtAdd;
        private System.Windows.Forms.Button btnCellarByExtEdit;
        private System.Windows.Forms.DataGridView dgvCellarbyMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarByExtruderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarByExtruderCellarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarByExtruderExtName;
        private System.Windows.Forms.GroupBox grpbCellarByExtruderForm;
        private System.Windows.Forms.ComboBox cmbCellarByExtLineName;
        private System.Windows.Forms.Label lblCellarByExtLineName;
        private System.Windows.Forms.ComboBox cmbCellarByExtCellarName;
        private System.Windows.Forms.Label lblCellarByExtCellarName;
        private System.Windows.Forms.Button btnCellarByExtCancel;
        private System.Windows.Forms.Button btnCellarByExtSave;
        private System.Windows.Forms.TextBox txtMetalizedNumber;
        private System.Windows.Forms.Label lblMetalizedNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerMinFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerMaxFilmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerMaxVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerMaxDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizerStatus;
    }
}