namespace OPD_Section
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.OuterTabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.OPDTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_newrecord = new System.Windows.Forms.Button();
            this.btn_archieve = new System.Windows.Forms.Button();
            this.txt_personname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_personid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_visitid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VISIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBTab = new System.Windows.Forms.TabPage();
            this.InnerTabControl = new System.Windows.Forms.TabControl();
            this.VillagesTab = new System.Windows.Forms.TabPage();
            this.VillagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BtnVillageReset = new System.Windows.Forms.Button();
            this.BtnVillageSearch = new System.Windows.Forms.Button();
            this.BtnVillageUpdate = new System.Windows.Forms.Button();
            this.BtnVillageDelete = new System.Windows.Forms.Button();
            this.BtnVillageInsert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtVillageNoOfHouses = new System.Windows.Forms.TextBox();
            this.TxtVillageCode = new System.Windows.Forms.TextBox();
            this.TxtVillageName = new System.Windows.Forms.TextBox();
            this.TxtVillageId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TblVillage = new System.Windows.Forms.DataGridView();
            this.VillageIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblVillageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblVillagePrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblVillagePrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.HousesTab = new System.Windows.Forms.TabPage();
            this.HousesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TxtHouseVillageName = new System.Windows.Forms.ComboBox();
            this.BtnHouseReset = new System.Windows.Forms.Button();
            this.BtnHouseSearch = new System.Windows.Forms.Button();
            this.BtnHouseUpdate = new System.Windows.Forms.Button();
            this.BtnHouseDelete = new System.Windows.Forms.Button();
            this.BtnHouseInsert = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TxtHouseNoOfPeople = new System.Windows.Forms.TextBox();
            this.TxtHouseId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TblHouse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblHouseContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblHousePrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblHousePrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.PeopleSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TxtPersonHouseId = new System.Windows.Forms.ComboBox();
            this.TxtPersonVillageName = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.TxtPersonAge = new System.Windows.Forms.NumericUpDown();
            this.TxtPersonGender = new System.Windows.Forms.ComboBox();
            this.BtnPersonReset = new System.Windows.Forms.Button();
            this.BtnPersonSearch = new System.Windows.Forms.Button();
            this.BtnPersonUpdate = new System.Windows.Forms.Button();
            this.BtnPersonDelete = new System.Windows.Forms.Button();
            this.BtnPersonInsert = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.TxtPersonPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.TxtPersonId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TblPerson = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblPersonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblPersonPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblPersonPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.LogsTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BtnVillageLogsReset = new System.Windows.Forms.Button();
            this.BtnVillageLogsSearch = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.TxtVillageLogsNoOfHouses = new System.Windows.Forms.TextBox();
            this.TxtVillageLogsVillageCode = new System.Windows.Forms.TextBox();
            this.TxtVillageLogsVillageName = new System.Windows.Forms.TextBox();
            this.TxtVillageLogsVillageId = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.TblVillageLogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblVillageLogsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblVillageLogsPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblVillageLogsPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BtnHouseLogsReset = new System.Windows.Forms.Button();
            this.BtnHouseLogsSearch = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.TxtHouseLogsNoOfPeople = new System.Windows.Forms.TextBox();
            this.TxtHouseLogsVillageName = new System.Windows.Forms.TextBox();
            this.TxtHouseLogsHouseId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.TblHouseLogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblHouseLogsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblHouseLogsPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblHouseLogsPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.BtnPersonLogsReset = new System.Windows.Forms.Button();
            this.BtnPersonLogsSearch = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.TxtPersonLogsPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsName = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsGender = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsAge = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsVillageName = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsHouseId = new System.Windows.Forms.TextBox();
            this.TxtPersonLogsPersonId = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.TblPersonLogs = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblPersonLogsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblPersonLogsPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblPersonLogsPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.InnerImageList = new System.Windows.Forms.ImageList(this.components);
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.MedicinesTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.TxtMedicineQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnMedicineReset = new System.Windows.Forms.Button();
            this.BtnMedicineSearcch = new System.Windows.Forms.Button();
            this.BtnMedicineUpdate = new System.Windows.Forms.Button();
            this.BtnMedicineDelete = new System.Windows.Forms.Button();
            this.BtnMedicineInsert = new System.Windows.Forms.Button();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.TxtMedicineName = new System.Windows.Forms.TextBox();
            this.TxtMedicineId = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.TblMedicines = new System.Windows.Forms.DataGridView();
            this.DisposablesTab = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.TxtDisposableQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnDisposableReset = new System.Windows.Forms.Button();
            this.BtnDisposableSearch = new System.Windows.Forms.Button();
            this.BtnDisposableUpdate = new System.Windows.Forms.Button();
            this.BtnDisposableDelete = new System.Windows.Forms.Button();
            this.BtnDisposableInsert = new System.Windows.Forms.Button();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.TxtDisposableName = new System.Windows.Forms.TextBox();
            this.TxtDisposableId = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.TblDisposables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationaryTab = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.TxtStationaryQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnStstionaryReset = new System.Windows.Forms.Button();
            this.BtnStstionarySearch = new System.Windows.Forms.Button();
            this.BtnStstionaryUpdate = new System.Windows.Forms.Button();
            this.BtnStstionaryDelete = new System.Windows.Forms.Button();
            this.BtnStstionaryInsert = new System.Windows.Forms.Button();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.TxtStationaryName = new System.Windows.Forms.TextBox();
            this.TxtStationaryId = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.TblStationary = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.TxtMiscellaneousQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnMiscellaneousReset = new System.Windows.Forms.Button();
            this.BtnMiscellaneousSearch = new System.Windows.Forms.Button();
            this.BtnMiscellaneousUpdate = new System.Windows.Forms.Button();
            this.BtnMiscellaneousDelete = new System.Windows.Forms.Button();
            this.BtnMiscellaneousInsert = new System.Windows.Forms.Button();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.TxtMiscellaneousName = new System.Windows.Forms.TextBox();
            this.TxtMiscellaneousId = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.TblMiscellaneous = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryLogsTab = new System.Windows.Forms.TabPage();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.OuterImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.TblMedicinesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblMedicinesPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblMedicinesPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.TblDisposablesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblDisposablesPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblDisposablesPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.TblStationaryContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblStationaryPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblStationaryPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.TblMiscellaneousContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TblMiscellaneousPrintAsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.TblMiscellaneousPrintAsExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerPanel.SuspendLayout();
            this.OuterTabControl.SuspendLayout();
            this.OPDTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DBTab.SuspendLayout();
            this.InnerTabControl.SuspendLayout();
            this.VillagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VillagesSplitContainer)).BeginInit();
            this.VillagesSplitContainer.Panel1.SuspendLayout();
            this.VillagesSplitContainer.Panel2.SuspendLayout();
            this.VillagesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblVillage)).BeginInit();
            this.TblVillageContextMenuStrip.SuspendLayout();
            this.HousesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HousesSplitContainer)).BeginInit();
            this.HousesSplitContainer.Panel1.SuspendLayout();
            this.HousesSplitContainer.Panel2.SuspendLayout();
            this.HousesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblHouse)).BeginInit();
            this.TblHouseContextMenuStrip.SuspendLayout();
            this.PeopleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleSplitContainer)).BeginInit();
            this.PeopleSplitContainer.Panel1.SuspendLayout();
            this.PeopleSplitContainer.Panel2.SuspendLayout();
            this.PeopleSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPerson)).BeginInit();
            this.TblPersonContextMenuStrip.SuspendLayout();
            this.LogsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblVillageLogs)).BeginInit();
            this.TblVillageLogsContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblHouseLogs)).BeginInit();
            this.TblHouseLogsContextMenuStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblPersonLogs)).BeginInit();
            this.TblPersonLogsContextMenuStrip.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.MedicinesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMedicineQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMedicines)).BeginInit();
            this.DisposablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisposableQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblDisposables)).BeginInit();
            this.StationaryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStationaryQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblStationary)).BeginInit();
            this.MiscellaneousTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiscellaneousQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMiscellaneous)).BeginInit();
            this.InventoryLogsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.TblMedicinesContextMenuStrip.SuspendLayout();
            this.TblDisposablesContextMenuStrip.SuspendLayout();
            this.TblStationaryContextMenuStrip.SuspendLayout();
            this.TblMiscellaneousContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowerPanel
            // 
            this.LowerPanel.BackColor = System.Drawing.Color.White;
            this.LowerPanel.Controls.Add(this.OuterTabControl);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerPanel.Location = new System.Drawing.Point(0, 0);
            this.LowerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(1770, 904);
            this.LowerPanel.TabIndex = 0;
            // 
            // OuterTabControl
            // 
            this.OuterTabControl.Controls.Add(this.HomeTab);
            this.OuterTabControl.Controls.Add(this.OPDTab);
            this.OuterTabControl.Controls.Add(this.DBTab);
            this.OuterTabControl.Controls.Add(this.InventoryTab);
            this.OuterTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterTabControl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuterTabControl.ItemSize = new System.Drawing.Size(71, 40);
            this.OuterTabControl.Location = new System.Drawing.Point(0, 0);
            this.OuterTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OuterTabControl.Name = "OuterTabControl";
            this.OuterTabControl.SelectedIndex = 0;
            this.OuterTabControl.Size = new System.Drawing.Size(1770, 904);
            this.OuterTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.OuterTabControl.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.ImageKey = "icons8-home-page-48.png";
            this.HomeTab.Location = new System.Drawing.Point(4, 44);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(1762, 856);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "   Home Page   ";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // OPDTab
            // 
            this.OPDTab.Controls.Add(this.panel5);
            this.OPDTab.ImageKey = "icons8-clinic-50.png";
            this.OPDTab.Location = new System.Drawing.Point(4, 44);
            this.OPDTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OPDTab.Name = "OPDTab";
            this.OPDTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OPDTab.Size = new System.Drawing.Size(1762, 856);
            this.OPDTab.TabIndex = 1;
            this.OPDTab.Text = "   OPD Clinic   ";
            this.OPDTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1756, 852);
            this.panel5.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_personname);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_personid);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_visitid);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1756, 852);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_newrecord);
            this.panel6.Controls.Add(this.btn_archieve);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 629);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 223);
            this.panel6.TabIndex = 40;
            // 
            // btn_newrecord
            // 
            this.btn_newrecord.BackColor = System.Drawing.Color.Gold;
            this.btn_newrecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_newrecord.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_newrecord.Location = new System.Drawing.Point(0, 0);
            this.btn_newrecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newrecord.Name = "btn_newrecord";
            this.btn_newrecord.Size = new System.Drawing.Size(290, 223);
            this.btn_newrecord.TabIndex = 37;
            this.btn_newrecord.Text = "VISIT DETAILS";
            this.btn_newrecord.UseVisualStyleBackColor = false;
            this.btn_newrecord.Click += new System.EventHandler(this.btn_newrecord_Click_1);
            // 
            // btn_archieve
            // 
            this.btn_archieve.BackColor = System.Drawing.Color.Gold;
            this.btn_archieve.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_archieve.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_archieve.Location = new System.Drawing.Point(66, 0);
            this.btn_archieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_archieve.Name = "btn_archieve";
            this.btn_archieve.Size = new System.Drawing.Size(388, 223);
            this.btn_archieve.TabIndex = 39;
            this.btn_archieve.Text = "ARCHIEVE";
            this.btn_archieve.UseVisualStyleBackColor = false;
            this.btn_archieve.Click += new System.EventHandler(this.btn_archieve_Click);
            // 
            // txt_personname
            // 
            this.txt_personname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_personname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_personname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt_personname.Location = new System.Drawing.Point(29, 394);
            this.txt_personname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_personname.Name = "txt_personname";
            this.txt_personname.Size = new System.Drawing.Size(155, 34);
            this.txt_personname.TabIndex = 35;
            this.txt_personname.TextChanged += new System.EventHandler(this.txt_personname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Person Name";
            // 
            // txt_personid
            // 
            this.txt_personid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_personid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt_personid.Location = new System.Drawing.Point(29, 271);
            this.txt_personid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_personid.Name = "txt_personid";
            this.txt_personid.Size = new System.Drawing.Size(155, 34);
            this.txt_personid.TabIndex = 33;
            this.txt_personid.TextChanged += new System.EventHandler(this.txt_personid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Person ID";
            // 
            // txt_visitid
            // 
            this.txt_visitid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_visitid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_visitid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt_visitid.Location = new System.Drawing.Point(29, 144);
            this.txt_visitid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_visitid.Name = "txt_visitid";
            this.txt_visitid.Size = new System.Drawing.Size(155, 34);
            this.txt_visitid.TabIndex = 31;
            this.txt_visitid.TextChanged += new System.EventHandler(this.txt_visitid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Visit ID";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 37);
            this.label6.TabIndex = 29;
            this.label6.Text = "OPD Section";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VISIT_ID,
            this.PERSON_ID,
            this.PERSON_NAME,
            this.DATE,
            this.TIME});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 852);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.HeaderText = "VISIT ID";
            this.VISIT_ID.MinimumWidth = 6;
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.ReadOnly = true;
            // 
            // PERSON_ID
            // 
            this.PERSON_ID.HeaderText = "PERSON ID";
            this.PERSON_ID.MinimumWidth = 6;
            this.PERSON_ID.Name = "PERSON_ID";
            this.PERSON_ID.ReadOnly = true;
            // 
            // PERSON_NAME
            // 
            this.PERSON_NAME.HeaderText = "PERSON NAME";
            this.PERSON_NAME.MinimumWidth = 6;
            this.PERSON_NAME.Name = "PERSON_NAME";
            this.PERSON_NAME.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // TIME
            // 
            this.TIME.HeaderText = "TIME";
            this.TIME.MinimumWidth = 6;
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            // 
            // DBTab
            // 
            this.DBTab.Controls.Add(this.InnerTabControl);
            this.DBTab.ImageKey = "icons8-database-50.png";
            this.DBTab.Location = new System.Drawing.Point(4, 44);
            this.DBTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBTab.Name = "DBTab";
            this.DBTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBTab.Size = new System.Drawing.Size(1762, 856);
            this.DBTab.TabIndex = 0;
            this.DBTab.Text = "   Database Records   ";
            this.DBTab.UseVisualStyleBackColor = true;
            // 
            // InnerTabControl
            // 
            this.InnerTabControl.Controls.Add(this.VillagesTab);
            this.InnerTabControl.Controls.Add(this.HousesTab);
            this.InnerTabControl.Controls.Add(this.PeopleTab);
            this.InnerTabControl.Controls.Add(this.LogsTab);
            this.InnerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerTabControl.ImageList = this.InnerImageList;
            this.InnerTabControl.ItemSize = new System.Drawing.Size(71, 35);
            this.InnerTabControl.Location = new System.Drawing.Point(3, 2);
            this.InnerTabControl.Name = "InnerTabControl";
            this.InnerTabControl.SelectedIndex = 0;
            this.InnerTabControl.Size = new System.Drawing.Size(1756, 852);
            this.InnerTabControl.TabIndex = 1;
            // 
            // VillagesTab
            // 
            this.VillagesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VillagesTab.Controls.Add(this.VillagesSplitContainer);
            this.VillagesTab.ImageKey = "icons8-village-60.png";
            this.VillagesTab.Location = new System.Drawing.Point(4, 39);
            this.VillagesTab.Name = "VillagesTab";
            this.VillagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.VillagesTab.Size = new System.Drawing.Size(1748, 809);
            this.VillagesTab.TabIndex = 0;
            this.VillagesTab.Text = "   Villages   ";
            this.VillagesTab.UseVisualStyleBackColor = true;
            // 
            // VillagesSplitContainer
            // 
            this.VillagesSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VillagesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VillagesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.VillagesSplitContainer.IsSplitterFixed = true;
            this.VillagesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.VillagesSplitContainer.Name = "VillagesSplitContainer";
            // 
            // VillagesSplitContainer.Panel1
            // 
            this.VillagesSplitContainer.Panel1.AutoScroll = true;
            this.VillagesSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.VillagesSplitContainer.Panel1.Controls.Add(this.BtnVillageReset);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.BtnVillageSearch);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.BtnVillageUpdate);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.BtnVillageDelete);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.BtnVillageInsert);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.panel4);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.panel3);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.panel2);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.panel1);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.TxtVillageNoOfHouses);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.TxtVillageCode);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.TxtVillageName);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.TxtVillageId);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.label5);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.label7);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.label8);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.label9);
            this.VillagesSplitContainer.Panel1.Controls.Add(this.label10);
            // 
            // VillagesSplitContainer.Panel2
            // 
            this.VillagesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.VillagesSplitContainer.Panel2.Controls.Add(this.TblVillage);
            this.VillagesSplitContainer.Size = new System.Drawing.Size(1742, 803);
            this.VillagesSplitContainer.SplitterDistance = 420;
            this.VillagesSplitContainer.SplitterWidth = 5;
            this.VillagesSplitContainer.TabIndex = 0;
            // 
            // BtnVillageReset
            // 
            this.BtnVillageReset.AutoSize = true;
            this.BtnVillageReset.Location = new System.Drawing.Point(151, 608);
            this.BtnVillageReset.Name = "BtnVillageReset";
            this.BtnVillageReset.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageReset.TabIndex = 4;
            this.BtnVillageReset.Text = "RESET";
            this.BtnVillageReset.UseVisualStyleBackColor = true;
            this.BtnVillageReset.Click += new System.EventHandler(this.BtnVillageReset_Click);
            // 
            // BtnVillageSearch
            // 
            this.BtnVillageSearch.AutoSize = true;
            this.BtnVillageSearch.Location = new System.Drawing.Point(288, 535);
            this.BtnVillageSearch.Name = "BtnVillageSearch";
            this.BtnVillageSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageSearch.TabIndex = 4;
            this.BtnVillageSearch.Text = "SEARCH";
            this.BtnVillageSearch.UseVisualStyleBackColor = true;
            this.BtnVillageSearch.Click += new System.EventHandler(this.BtnVillageSearch_Click);
            // 
            // BtnVillageUpdate
            // 
            this.BtnVillageUpdate.AutoSize = true;
            this.BtnVillageUpdate.Location = new System.Drawing.Point(288, 459);
            this.BtnVillageUpdate.Name = "BtnVillageUpdate";
            this.BtnVillageUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageUpdate.TabIndex = 4;
            this.BtnVillageUpdate.Text = "UPDATE";
            this.BtnVillageUpdate.UseMnemonic = false;
            this.BtnVillageUpdate.UseVisualStyleBackColor = false;
            this.BtnVillageUpdate.Click += new System.EventHandler(this.BtnVillageUpdate_Click);
            // 
            // BtnVillageDelete
            // 
            this.BtnVillageDelete.AutoSize = true;
            this.BtnVillageDelete.Location = new System.Drawing.Point(16, 535);
            this.BtnVillageDelete.Name = "BtnVillageDelete";
            this.BtnVillageDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageDelete.TabIndex = 4;
            this.BtnVillageDelete.Text = "DELETE";
            this.BtnVillageDelete.UseVisualStyleBackColor = true;
            this.BtnVillageDelete.Click += new System.EventHandler(this.BtnVillageDelete_Click);
            // 
            // BtnVillageInsert
            // 
            this.BtnVillageInsert.AutoSize = true;
            this.BtnVillageInsert.Location = new System.Drawing.Point(16, 459);
            this.BtnVillageInsert.Name = "BtnVillageInsert";
            this.BtnVillageInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageInsert.TabIndex = 4;
            this.BtnVillageInsert.Text = "INSERT";
            this.BtnVillageInsert.UseVisualStyleBackColor = true;
            this.BtnVillageInsert.Click += new System.EventHandler(this.BtnVillageInsert_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(16, 426);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(16, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 2);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(16, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 2);
            this.panel1.TabIndex = 3;
            // 
            // TxtVillageNoOfHouses
            // 
            this.TxtVillageNoOfHouses.BackColor = System.Drawing.Color.White;
            this.TxtVillageNoOfHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageNoOfHouses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageNoOfHouses.HideSelection = false;
            this.TxtVillageNoOfHouses.Location = new System.Drawing.Point(16, 397);
            this.TxtVillageNoOfHouses.Name = "TxtVillageNoOfHouses";
            this.TxtVillageNoOfHouses.ReadOnly = true;
            this.TxtVillageNoOfHouses.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageNoOfHouses.TabIndex = 0;
            // 
            // TxtVillageCode
            // 
            this.TxtVillageCode.BackColor = System.Drawing.Color.White;
            this.TxtVillageCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageCode.HideSelection = false;
            this.TxtVillageCode.Location = new System.Drawing.Point(16, 314);
            this.TxtVillageCode.Name = "TxtVillageCode";
            this.TxtVillageCode.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageCode.TabIndex = 0;
            this.TxtVillageCode.TextChanged += new System.EventHandler(this.TxtVillageCode_TextChanged);
            // 
            // TxtVillageName
            // 
            this.TxtVillageName.BackColor = System.Drawing.Color.White;
            this.TxtVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageName.HideSelection = false;
            this.TxtVillageName.Location = new System.Drawing.Point(16, 231);
            this.TxtVillageName.Name = "TxtVillageName";
            this.TxtVillageName.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageName.TabIndex = 0;
            this.TxtVillageName.TextChanged += new System.EventHandler(this.TxtVillageName_TextChanged);
            // 
            // TxtVillageId
            // 
            this.TxtVillageId.BackColor = System.Drawing.Color.White;
            this.TxtVillageId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageId.HideSelection = false;
            this.TxtVillageId.Location = new System.Drawing.Point(16, 147);
            this.TxtVillageId.Name = "TxtVillageId";
            this.TxtVillageId.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageId.TabIndex = 0;
            this.TxtVillageId.TextChanged += new System.EventHandler(this.TxtVillageId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "No. of Houses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Village Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Village Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Village ID";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(446, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "VILLAGE DETAILS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblVillage
            // 
            this.TblVillage.AllowUserToAddRows = false;
            this.TblVillage.AllowUserToDeleteRows = false;
            this.TblVillage.AllowUserToOrderColumns = true;
            this.TblVillage.AllowUserToResizeRows = false;
            this.TblVillage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblVillage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblVillage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblVillage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VillageIdColumn,
            this.Column1,
            this.Column2,
            this.Column3});
            this.TblVillage.ContextMenuStrip = this.TblVillageContextMenuStrip;
            this.TblVillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblVillage.Location = new System.Drawing.Point(0, 0);
            this.TblVillage.MultiSelect = false;
            this.TblVillage.Name = "TblVillage";
            this.TblVillage.ReadOnly = true;
            this.TblVillage.RowHeadersVisible = false;
            this.TblVillage.RowHeadersWidth = 51;
            this.TblVillage.RowTemplate.DividerHeight = 2;
            this.TblVillage.RowTemplate.Height = 50;
            this.TblVillage.RowTemplate.ReadOnly = true;
            this.TblVillage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TblVillage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblVillage.Size = new System.Drawing.Size(1313, 799);
            this.TblVillage.TabIndex = 0;
            this.TblVillage.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblVillage_CellMouseDoubleClick);
            // 
            // VillageIdColumn
            // 
            this.VillageIdColumn.HeaderText = "VILLAGE ID";
            this.VillageIdColumn.MinimumWidth = 200;
            this.VillageIdColumn.Name = "VillageIdColumn";
            this.VillageIdColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "VILLAGE NAME";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "VILLAGE CODE";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NO. OF HOUSES";
            this.Column3.MinimumWidth = 200;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // TblVillageContextMenuStrip
            // 
            this.TblVillageContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblVillageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblVillagePrintAsPDF,
            this.TblVillagePrintAsExcel});
            this.TblVillageContextMenuStrip.Name = "TblVillageContextMenuStrip";
            this.TblVillageContextMenuStrip.Size = new System.Drawing.Size(165, 52);
            // 
            // TblVillagePrintAsPDF
            // 
            this.TblVillagePrintAsPDF.Name = "TblVillagePrintAsPDF";
            this.TblVillagePrintAsPDF.Size = new System.Drawing.Size(164, 24);
            this.TblVillagePrintAsPDF.Text = "Print as PDF";
            this.TblVillagePrintAsPDF.Click += new System.EventHandler(this.TblVillagePrintAsPDF_Click);
            // 
            // TblVillagePrintAsExcel
            // 
            this.TblVillagePrintAsExcel.Name = "TblVillagePrintAsExcel";
            this.TblVillagePrintAsExcel.Size = new System.Drawing.Size(164, 24);
            this.TblVillagePrintAsExcel.Text = "Print as Excel";
            this.TblVillagePrintAsExcel.Click += new System.EventHandler(this.TblVillagePrintAsExcel_Click);
            // 
            // HousesTab
            // 
            this.HousesTab.Controls.Add(this.HousesSplitContainer);
            this.HousesTab.ImageKey = "icons8-home-page-48.png";
            this.HousesTab.Location = new System.Drawing.Point(4, 39);
            this.HousesTab.Name = "HousesTab";
            this.HousesTab.Padding = new System.Windows.Forms.Padding(3);
            this.HousesTab.Size = new System.Drawing.Size(1748, 809);
            this.HousesTab.TabIndex = 1;
            this.HousesTab.Text = "   Houses   ";
            this.HousesTab.UseVisualStyleBackColor = true;
            // 
            // HousesSplitContainer
            // 
            this.HousesSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HousesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HousesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HousesSplitContainer.IsSplitterFixed = true;
            this.HousesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.HousesSplitContainer.Name = "HousesSplitContainer";
            // 
            // HousesSplitContainer.Panel1
            // 
            this.HousesSplitContainer.Panel1.AutoScroll = true;
            this.HousesSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.HousesSplitContainer.Panel1.Controls.Add(this.TxtHouseVillageName);
            this.HousesSplitContainer.Panel1.Controls.Add(this.BtnHouseReset);
            this.HousesSplitContainer.Panel1.Controls.Add(this.BtnHouseSearch);
            this.HousesSplitContainer.Panel1.Controls.Add(this.BtnHouseUpdate);
            this.HousesSplitContainer.Panel1.Controls.Add(this.BtnHouseDelete);
            this.HousesSplitContainer.Panel1.Controls.Add(this.BtnHouseInsert);
            this.HousesSplitContainer.Panel1.Controls.Add(this.panel7);
            this.HousesSplitContainer.Panel1.Controls.Add(this.panel8);
            this.HousesSplitContainer.Panel1.Controls.Add(this.panel9);
            this.HousesSplitContainer.Panel1.Controls.Add(this.TxtHouseNoOfPeople);
            this.HousesSplitContainer.Panel1.Controls.Add(this.TxtHouseId);
            this.HousesSplitContainer.Panel1.Controls.Add(this.label11);
            this.HousesSplitContainer.Panel1.Controls.Add(this.label12);
            this.HousesSplitContainer.Panel1.Controls.Add(this.label13);
            this.HousesSplitContainer.Panel1.Controls.Add(this.label14);
            // 
            // HousesSplitContainer.Panel2
            // 
            this.HousesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.HousesSplitContainer.Panel2.Controls.Add(this.TblHouse);
            this.HousesSplitContainer.Size = new System.Drawing.Size(1742, 803);
            this.HousesSplitContainer.SplitterDistance = 420;
            this.HousesSplitContainer.SplitterWidth = 5;
            this.HousesSplitContainer.TabIndex = 1;
            // 
            // TxtHouseVillageName
            // 
            this.TxtHouseVillageName.FormattingEnabled = true;
            this.TxtHouseVillageName.Location = new System.Drawing.Point(16, 227);
            this.TxtHouseVillageName.Name = "TxtHouseVillageName";
            this.TxtHouseVillageName.Size = new System.Drawing.Size(516, 33);
            this.TxtHouseVillageName.TabIndex = 5;
            // 
            // BtnHouseReset
            // 
            this.BtnHouseReset.AutoSize = true;
            this.BtnHouseReset.Location = new System.Drawing.Point(145, 546);
            this.BtnHouseReset.Name = "BtnHouseReset";
            this.BtnHouseReset.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseReset.TabIndex = 4;
            this.BtnHouseReset.Text = "RESET";
            this.BtnHouseReset.UseVisualStyleBackColor = true;
            this.BtnHouseReset.Click += new System.EventHandler(this.BtnHouseReset_Click);
            // 
            // BtnHouseSearch
            // 
            this.BtnHouseSearch.AutoSize = true;
            this.BtnHouseSearch.Location = new System.Drawing.Point(288, 476);
            this.BtnHouseSearch.Name = "BtnHouseSearch";
            this.BtnHouseSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseSearch.TabIndex = 4;
            this.BtnHouseSearch.Text = "SEARCH";
            this.BtnHouseSearch.UseVisualStyleBackColor = true;
            this.BtnHouseSearch.Click += new System.EventHandler(this.BtnHouseSearch_Click);
            // 
            // BtnHouseUpdate
            // 
            this.BtnHouseUpdate.AutoSize = true;
            this.BtnHouseUpdate.Location = new System.Drawing.Point(288, 400);
            this.BtnHouseUpdate.Name = "BtnHouseUpdate";
            this.BtnHouseUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseUpdate.TabIndex = 4;
            this.BtnHouseUpdate.Text = "UPDATE";
            this.BtnHouseUpdate.UseVisualStyleBackColor = true;
            this.BtnHouseUpdate.Click += new System.EventHandler(this.BtnHouseUpdate_Click);
            // 
            // BtnHouseDelete
            // 
            this.BtnHouseDelete.AutoSize = true;
            this.BtnHouseDelete.Location = new System.Drawing.Point(16, 476);
            this.BtnHouseDelete.Name = "BtnHouseDelete";
            this.BtnHouseDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseDelete.TabIndex = 4;
            this.BtnHouseDelete.Text = "DELETE";
            this.BtnHouseDelete.UseVisualStyleBackColor = true;
            this.BtnHouseDelete.Click += new System.EventHandler(this.BtnHouseDelete_Click);
            // 
            // BtnHouseInsert
            // 
            this.BtnHouseInsert.AutoSize = true;
            this.BtnHouseInsert.Location = new System.Drawing.Point(16, 400);
            this.BtnHouseInsert.Name = "BtnHouseInsert";
            this.BtnHouseInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseInsert.TabIndex = 4;
            this.BtnHouseInsert.Text = "INSERT";
            this.BtnHouseInsert.UseVisualStyleBackColor = true;
            this.BtnHouseInsert.Click += new System.EventHandler(this.BtnHouseInsert_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(16, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(516, 2);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(16, 260);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(516, 2);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(16, 176);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(516, 2);
            this.panel9.TabIndex = 3;
            // 
            // TxtHouseNoOfPeople
            // 
            this.TxtHouseNoOfPeople.BackColor = System.Drawing.Color.White;
            this.TxtHouseNoOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseNoOfPeople.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseNoOfPeople.HideSelection = false;
            this.TxtHouseNoOfPeople.Location = new System.Drawing.Point(16, 316);
            this.TxtHouseNoOfPeople.Name = "TxtHouseNoOfPeople";
            this.TxtHouseNoOfPeople.ReadOnly = true;
            this.TxtHouseNoOfPeople.Size = new System.Drawing.Size(516, 27);
            this.TxtHouseNoOfPeople.TabIndex = 0;
            // 
            // TxtHouseId
            // 
            this.TxtHouseId.BackColor = System.Drawing.Color.White;
            this.TxtHouseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseId.HideSelection = false;
            this.TxtHouseId.Location = new System.Drawing.Point(16, 147);
            this.TxtHouseId.Name = "TxtHouseId";
            this.TxtHouseId.Size = new System.Drawing.Size(516, 27);
            this.TxtHouseId.TabIndex = 0;
            this.TxtHouseId.TextChanged += new System.EventHandler(this.TxtHouseId_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "No. of People";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Village";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "House ID";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(446, 37);
            this.label14.TabIndex = 1;
            this.label14.Text = "HOUSE DETAILS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblHouse
            // 
            this.TblHouse.AllowUserToAddRows = false;
            this.TblHouse.AllowUserToDeleteRows = false;
            this.TblHouse.AllowUserToOrderColumns = true;
            this.TblHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.TblHouse.ContextMenuStrip = this.TblHouseContextMenuStrip;
            this.TblHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblHouse.Location = new System.Drawing.Point(0, 0);
            this.TblHouse.Name = "TblHouse";
            this.TblHouse.ReadOnly = true;
            this.TblHouse.RowHeadersVisible = false;
            this.TblHouse.RowHeadersWidth = 51;
            this.TblHouse.RowTemplate.Height = 50;
            this.TblHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblHouse.Size = new System.Drawing.Size(1313, 799);
            this.TblHouse.TabIndex = 0;
            this.TblHouse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblHouse_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "NO. OF PEOPLE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TblHouseContextMenuStrip
            // 
            this.TblHouseContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblHouseContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblHousePrintAsPDF,
            this.TblHousePrintAsExcel});
            this.TblHouseContextMenuStrip.Name = "TblHouseContextMenuStrip";
            this.TblHouseContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TblHouseContextMenuStrip.ShowImageMargin = false;
            this.TblHouseContextMenuStrip.Size = new System.Drawing.Size(142, 52);
            // 
            // TblHousePrintAsPDF
            // 
            this.TblHousePrintAsPDF.Name = "TblHousePrintAsPDF";
            this.TblHousePrintAsPDF.Size = new System.Drawing.Size(141, 24);
            this.TblHousePrintAsPDF.Text = "Print as PDF";
            this.TblHousePrintAsPDF.Click += new System.EventHandler(this.TblHousePrintAsPDF_Click);
            // 
            // TblHousePrintAsExcel
            // 
            this.TblHousePrintAsExcel.Name = "TblHousePrintAsExcel";
            this.TblHousePrintAsExcel.Size = new System.Drawing.Size(141, 24);
            this.TblHousePrintAsExcel.Text = "Print As Excel";
            this.TblHousePrintAsExcel.Click += new System.EventHandler(this.TblHousePrintAsExcel_Click);
            // 
            // PeopleTab
            // 
            this.PeopleTab.Controls.Add(this.PeopleSplitContainer);
            this.PeopleTab.ImageKey = "icons8-account-48.png";
            this.PeopleTab.Location = new System.Drawing.Point(4, 39);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTab.Size = new System.Drawing.Size(1748, 809);
            this.PeopleTab.TabIndex = 2;
            this.PeopleTab.Text = "   People   ";
            this.PeopleTab.UseVisualStyleBackColor = true;
            // 
            // PeopleSplitContainer
            // 
            this.PeopleSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PeopleSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeopleSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PeopleSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.PeopleSplitContainer.Name = "PeopleSplitContainer";
            // 
            // PeopleSplitContainer.Panel1
            // 
            this.PeopleSplitContainer.Panel1.AutoScroll = true;
            this.PeopleSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonHouseId);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonVillageName);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel13);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel11);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonAge);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonGender);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.BtnPersonReset);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.BtnPersonSearch);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.BtnPersonUpdate);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.BtnPersonDelete);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.BtnPersonInsert);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel10);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel12);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel14);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel15);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.panel16);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonPhoneNo);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonName);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.TxtPersonId);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label15);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label16);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.Label);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label17);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label18);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label19);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label20);
            this.PeopleSplitContainer.Panel1.Controls.Add(this.label21);
            // 
            // PeopleSplitContainer.Panel2
            // 
            this.PeopleSplitContainer.Panel2.AutoScroll = true;
            this.PeopleSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.PeopleSplitContainer.Panel2.Controls.Add(this.TblPerson);
            this.PeopleSplitContainer.Size = new System.Drawing.Size(1742, 803);
            this.PeopleSplitContainer.SplitterDistance = 425;
            this.PeopleSplitContainer.SplitterWidth = 5;
            this.PeopleSplitContainer.TabIndex = 1;
            // 
            // TxtPersonHouseId
            // 
            this.TxtPersonHouseId.FormattingEnabled = true;
            this.TxtPersonHouseId.Location = new System.Drawing.Point(21, 272);
            this.TxtPersonHouseId.Name = "TxtPersonHouseId";
            this.TxtPersonHouseId.Size = new System.Drawing.Size(515, 33);
            this.TxtPersonHouseId.TabIndex = 11;
            // 
            // TxtPersonVillageName
            // 
            this.TxtPersonVillageName.FormattingEnabled = true;
            this.TxtPersonVillageName.Location = new System.Drawing.Point(22, 199);
            this.TxtPersonVillageName.Name = "TxtPersonVillageName";
            this.TxtPersonVillageName.Size = new System.Drawing.Size(515, 33);
            this.TxtPersonVillageName.TabIndex = 10;
            this.TxtPersonVillageName.SelectedIndexChanged += new System.EventHandler(this.TxtPersonVillageName_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(21, 232);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(515, 2);
            this.panel13.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(20, 305);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(515, 2);
            this.panel11.TabIndex = 7;
            // 
            // TxtPersonAge
            // 
            this.TxtPersonAge.Location = new System.Drawing.Point(20, 412);
            this.TxtPersonAge.Name = "TxtPersonAge";
            this.TxtPersonAge.Size = new System.Drawing.Size(515, 34);
            this.TxtPersonAge.TabIndex = 6;
            this.TxtPersonAge.ThousandsSeparator = true;
            this.TxtPersonAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtPersonGender
            // 
            this.TxtPersonGender.DisplayMember = "HOUSE_ID";
            this.TxtPersonGender.DropDownHeight = 100;
            this.TxtPersonGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtPersonGender.FormattingEnabled = true;
            this.TxtPersonGender.IntegralHeight = false;
            this.TxtPersonGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.TxtPersonGender.Location = new System.Drawing.Point(20, 484);
            this.TxtPersonGender.Name = "TxtPersonGender";
            this.TxtPersonGender.Size = new System.Drawing.Size(515, 33);
            this.TxtPersonGender.TabIndex = 5;
            this.TxtPersonGender.ValueMember = "HOUSE_ID";
            // 
            // BtnPersonReset
            // 
            this.BtnPersonReset.AutoSize = true;
            this.BtnPersonReset.Location = new System.Drawing.Point(156, 734);
            this.BtnPersonReset.Name = "BtnPersonReset";
            this.BtnPersonReset.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonReset.TabIndex = 4;
            this.BtnPersonReset.Text = "RESET";
            this.BtnPersonReset.UseVisualStyleBackColor = true;
            this.BtnPersonReset.Click += new System.EventHandler(this.BtnPersonReset_Click);
            // 
            // BtnPersonSearch
            // 
            this.BtnPersonSearch.AutoSize = true;
            this.BtnPersonSearch.Location = new System.Drawing.Point(290, 675);
            this.BtnPersonSearch.Name = "BtnPersonSearch";
            this.BtnPersonSearch.Size = new System.Drawing.Size(247, 41);
            this.BtnPersonSearch.TabIndex = 4;
            this.BtnPersonSearch.Text = "SEARCH";
            this.BtnPersonSearch.UseVisualStyleBackColor = true;
            this.BtnPersonSearch.Click += new System.EventHandler(this.BtnPersonSearch_Click);
            // 
            // BtnPersonUpdate
            // 
            this.BtnPersonUpdate.AutoSize = true;
            this.BtnPersonUpdate.Location = new System.Drawing.Point(290, 616);
            this.BtnPersonUpdate.Name = "BtnPersonUpdate";
            this.BtnPersonUpdate.Size = new System.Drawing.Size(247, 41);
            this.BtnPersonUpdate.TabIndex = 4;
            this.BtnPersonUpdate.Text = "UPDATE";
            this.BtnPersonUpdate.UseVisualStyleBackColor = true;
            this.BtnPersonUpdate.Click += new System.EventHandler(this.BtnPersonUpdate_Click);
            // 
            // BtnPersonDelete
            // 
            this.BtnPersonDelete.AutoSize = true;
            this.BtnPersonDelete.Location = new System.Drawing.Point(19, 675);
            this.BtnPersonDelete.Name = "BtnPersonDelete";
            this.BtnPersonDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonDelete.TabIndex = 4;
            this.BtnPersonDelete.Text = "DELETE";
            this.BtnPersonDelete.UseVisualStyleBackColor = true;
            this.BtnPersonDelete.Click += new System.EventHandler(this.BtnPersonDelete_Click);
            // 
            // BtnPersonInsert
            // 
            this.BtnPersonInsert.AutoSize = true;
            this.BtnPersonInsert.Location = new System.Drawing.Point(19, 616);
            this.BtnPersonInsert.Name = "BtnPersonInsert";
            this.BtnPersonInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonInsert.TabIndex = 4;
            this.BtnPersonInsert.Text = "INSERT";
            this.BtnPersonInsert.UseVisualStyleBackColor = true;
            this.BtnPersonInsert.Click += new System.EventHandler(this.BtnPersonInsert_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(20, 518);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(515, 2);
            this.panel10.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(20, 447);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(515, 2);
            this.panel12.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(20, 589);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(515, 2);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(20, 376);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(515, 2);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(20, 158);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(515, 2);
            this.panel16.TabIndex = 3;
            // 
            // TxtPersonPhoneNo
            // 
            this.TxtPersonPhoneNo.BackColor = System.Drawing.Color.White;
            this.TxtPersonPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonPhoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonPhoneNo.HideSelection = false;
            this.TxtPersonPhoneNo.Location = new System.Drawing.Point(20, 560);
            this.TxtPersonPhoneNo.Name = "TxtPersonPhoneNo";
            this.TxtPersonPhoneNo.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonPhoneNo.TabIndex = 0;
            this.TxtPersonPhoneNo.TextChanged += new System.EventHandler(this.TxtPersonPhoneNo_TextChanged);
            // 
            // TxtPersonName
            // 
            this.TxtPersonName.BackColor = System.Drawing.Color.White;
            this.TxtPersonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonName.HideSelection = false;
            this.TxtPersonName.Location = new System.Drawing.Point(20, 347);
            this.TxtPersonName.Name = "TxtPersonName";
            this.TxtPersonName.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonName.TabIndex = 0;
            this.TxtPersonName.TextChanged += new System.EventHandler(this.TxtPersonName_TextChanged);
            // 
            // TxtPersonId
            // 
            this.TxtPersonId.BackColor = System.Drawing.Color.White;
            this.TxtPersonId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonId.HideSelection = false;
            this.TxtPersonId.Location = new System.Drawing.Point(20, 129);
            this.TxtPersonId.Name = "TxtPersonId";
            this.TxtPersonId.Size = new System.Drawing.Size(516, 27);
            this.TxtPersonId.TabIndex = 0;
            this.TxtPersonId.TextChanged += new System.EventHandler(this.TxtPersonId_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Gender";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Age";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(15, 531);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(165, 25);
            this.Label.TabIndex = 2;
            this.Label.Text = "Phone Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "Village";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "House ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Person ID";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(534, 37);
            this.label21.TabIndex = 1;
            this.label21.Text = "PERSON DETAILS";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblPerson
            // 
            this.TblPerson.AllowUserToAddRows = false;
            this.TblPerson.AllowUserToDeleteRows = false;
            this.TblPerson.AllowUserToOrderColumns = true;
            this.TblPerson.AllowUserToResizeRows = false;
            this.TblPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6,
            this.dataGridViewTextBoxColumn6,
            this.Column4,
            this.Column5,
            this.Column7});
            this.TblPerson.ContextMenuStrip = this.TblPersonContextMenuStrip;
            this.TblPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPerson.Location = new System.Drawing.Point(0, 0);
            this.TblPerson.MultiSelect = false;
            this.TblPerson.Name = "TblPerson";
            this.TblPerson.ReadOnly = true;
            this.TblPerson.RowHeadersVisible = false;
            this.TblPerson.RowHeadersWidth = 51;
            this.TblPerson.RowTemplate.Height = 50;
            this.TblPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblPerson.Size = new System.Drawing.Size(1308, 799);
            this.TblPerson.TabIndex = 0;
            this.TblPerson.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblPerson_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PERSON ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "VILLAGE";
            this.Column6.MinimumWidth = 200;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AGE";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GENDER";
            this.Column5.MinimumWidth = 150;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PHONE NO.";
            this.Column7.MinimumWidth = 150;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TblPersonContextMenuStrip
            // 
            this.TblPersonContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblPersonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblPersonPrintAsPDF,
            this.TblPersonPrintAsExcel});
            this.TblPersonContextMenuStrip.Name = "contextMenuStrip1";
            this.TblPersonContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TblPersonContextMenuStrip.ShowImageMargin = false;
            this.TblPersonContextMenuStrip.Size = new System.Drawing.Size(140, 52);
            // 
            // TblPersonPrintAsPDF
            // 
            this.TblPersonPrintAsPDF.Name = "TblPersonPrintAsPDF";
            this.TblPersonPrintAsPDF.Size = new System.Drawing.Size(139, 24);
            this.TblPersonPrintAsPDF.Text = "Print as PDF";
            this.TblPersonPrintAsPDF.Click += new System.EventHandler(this.TblPersonPrintAsPDF_Click);
            // 
            // TblPersonPrintAsExcel
            // 
            this.TblPersonPrintAsExcel.Name = "TblPersonPrintAsExcel";
            this.TblPersonPrintAsExcel.Size = new System.Drawing.Size(139, 24);
            this.TblPersonPrintAsExcel.Text = "Print as Excel";
            this.TblPersonPrintAsExcel.Click += new System.EventHandler(this.TblPersonPrintAsExcel_Click);
            // 
            // LogsTab
            // 
            this.LogsTab.Controls.Add(this.tabControl1);
            this.LogsTab.Location = new System.Drawing.Point(4, 39);
            this.LogsTab.Name = "LogsTab";
            this.LogsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogsTab.Size = new System.Drawing.Size(1748, 809);
            this.LogsTab.TabIndex = 3;
            this.LogsTab.Text = "   Logs   ";
            this.LogsTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.InnerImageList;
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 35);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1742, 803);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.ImageKey = "icons8-village-60.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1734, 760);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "   Village Logs   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.BtnVillageLogsReset);
            this.splitContainer2.Panel1.Controls.Add(this.BtnVillageLogsSearch);
            this.splitContainer2.Panel1.Controls.Add(this.panel17);
            this.splitContainer2.Panel1.Controls.Add(this.panel18);
            this.splitContainer2.Panel1.Controls.Add(this.panel19);
            this.splitContainer2.Panel1.Controls.Add(this.panel20);
            this.splitContainer2.Panel1.Controls.Add(this.TxtVillageLogsNoOfHouses);
            this.splitContainer2.Panel1.Controls.Add(this.TxtVillageLogsVillageCode);
            this.splitContainer2.Panel1.Controls.Add(this.TxtVillageLogsVillageName);
            this.splitContainer2.Panel1.Controls.Add(this.TxtVillageLogsVillageId);
            this.splitContainer2.Panel1.Controls.Add(this.label22);
            this.splitContainer2.Panel1.Controls.Add(this.label23);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            this.splitContainer2.Panel1.Controls.Add(this.label26);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.TblVillageLogs);
            this.splitContainer2.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer2.SplitterDistance = 420;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // BtnVillageLogsReset
            // 
            this.BtnVillageLogsReset.AutoSize = true;
            this.BtnVillageLogsReset.Location = new System.Drawing.Point(151, 550);
            this.BtnVillageLogsReset.Name = "BtnVillageLogsReset";
            this.BtnVillageLogsReset.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageLogsReset.TabIndex = 4;
            this.BtnVillageLogsReset.Text = "RESET";
            this.BtnVillageLogsReset.UseVisualStyleBackColor = true;
            this.BtnVillageLogsReset.Click += new System.EventHandler(this.BtnVillageLogsReset_Click);
            // 
            // BtnVillageLogsSearch
            // 
            this.BtnVillageLogsSearch.AutoSize = true;
            this.BtnVillageLogsSearch.Location = new System.Drawing.Point(151, 474);
            this.BtnVillageLogsSearch.Name = "BtnVillageLogsSearch";
            this.BtnVillageLogsSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnVillageLogsSearch.TabIndex = 4;
            this.BtnVillageLogsSearch.Text = "SEARCH";
            this.BtnVillageLogsSearch.UseVisualStyleBackColor = true;
            this.BtnVillageLogsSearch.Click += new System.EventHandler(this.BtnVillageLogsSearch_Click);
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Location = new System.Drawing.Point(16, 426);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(516, 2);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Location = new System.Drawing.Point(16, 343);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(516, 2);
            this.panel18.TabIndex = 3;
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Location = new System.Drawing.Point(16, 260);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(516, 2);
            this.panel19.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Location = new System.Drawing.Point(16, 176);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(516, 2);
            this.panel20.TabIndex = 3;
            // 
            // TxtVillageLogsNoOfHouses
            // 
            this.TxtVillageLogsNoOfHouses.BackColor = System.Drawing.Color.White;
            this.TxtVillageLogsNoOfHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageLogsNoOfHouses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageLogsNoOfHouses.HideSelection = false;
            this.TxtVillageLogsNoOfHouses.Location = new System.Drawing.Point(16, 397);
            this.TxtVillageLogsNoOfHouses.Name = "TxtVillageLogsNoOfHouses";
            this.TxtVillageLogsNoOfHouses.ReadOnly = true;
            this.TxtVillageLogsNoOfHouses.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageLogsNoOfHouses.TabIndex = 0;
            // 
            // TxtVillageLogsVillageCode
            // 
            this.TxtVillageLogsVillageCode.BackColor = System.Drawing.Color.White;
            this.TxtVillageLogsVillageCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageLogsVillageCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageLogsVillageCode.HideSelection = false;
            this.TxtVillageLogsVillageCode.Location = new System.Drawing.Point(16, 314);
            this.TxtVillageLogsVillageCode.Name = "TxtVillageLogsVillageCode";
            this.TxtVillageLogsVillageCode.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageLogsVillageCode.TabIndex = 0;
            // 
            // TxtVillageLogsVillageName
            // 
            this.TxtVillageLogsVillageName.BackColor = System.Drawing.Color.White;
            this.TxtVillageLogsVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageLogsVillageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageLogsVillageName.HideSelection = false;
            this.TxtVillageLogsVillageName.Location = new System.Drawing.Point(16, 231);
            this.TxtVillageLogsVillageName.Name = "TxtVillageLogsVillageName";
            this.TxtVillageLogsVillageName.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageLogsVillageName.TabIndex = 0;
            // 
            // TxtVillageLogsVillageId
            // 
            this.TxtVillageLogsVillageId.BackColor = System.Drawing.Color.White;
            this.TxtVillageLogsVillageId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVillageLogsVillageId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVillageLogsVillageId.HideSelection = false;
            this.TxtVillageLogsVillageId.Location = new System.Drawing.Point(16, 147);
            this.TxtVillageLogsVillageId.Name = "TxtVillageLogsVillageId";
            this.TxtVillageLogsVillageId.Size = new System.Drawing.Size(516, 27);
            this.TxtVillageLogsVillageId.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 365);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 25);
            this.label22.TabIndex = 2;
            this.label22.Text = "No. of Houses";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 282);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "Village Code";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 25);
            this.label24.TabIndex = 2;
            this.label24.Text = "Village Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 25);
            this.label25.TabIndex = 2;
            this.label25.Text = "Village ID";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(43, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(446, 37);
            this.label26.TabIndex = 1;
            this.label26.Text = "VILLAGE DETAILS";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblVillageLogs
            // 
            this.TblVillageLogs.AllowUserToAddRows = false;
            this.TblVillageLogs.AllowUserToDeleteRows = false;
            this.TblVillageLogs.AllowUserToOrderColumns = true;
            this.TblVillageLogs.AllowUserToResizeRows = false;
            this.TblVillageLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblVillageLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblVillageLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.TblVillageLogs.ContextMenuStrip = this.TblVillageLogsContextMenuStrip;
            this.TblVillageLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblVillageLogs.Location = new System.Drawing.Point(0, 0);
            this.TblVillageLogs.MultiSelect = false;
            this.TblVillageLogs.Name = "TblVillageLogs";
            this.TblVillageLogs.ReadOnly = true;
            this.TblVillageLogs.RowHeadersVisible = false;
            this.TblVillageLogs.RowHeadersWidth = 51;
            this.TblVillageLogs.RowTemplate.DividerHeight = 2;
            this.TblVillageLogs.RowTemplate.Height = 50;
            this.TblVillageLogs.RowTemplate.ReadOnly = true;
            this.TblVillageLogs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TblVillageLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblVillageLogs.Size = new System.Drawing.Size(1299, 750);
            this.TblVillageLogs.TabIndex = 0;
            this.TblVillageLogs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblVillageLogs_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "LOG ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "OPERATION";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "VILLAGE ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "VILLAGE NAME";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.HeaderText = "VILLAGE CODE";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.HeaderText = "NO. OF HOUSES";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // TblVillageLogsContextMenuStrip
            // 
            this.TblVillageLogsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblVillageLogsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblVillageLogsPrintAsPDF,
            this.TblVillageLogsPrintAsExcel});
            this.TblVillageLogsContextMenuStrip.Name = "contextMenuStrip1";
            this.TblVillageLogsContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TblVillageLogsContextMenuStrip.ShowImageMargin = false;
            this.TblVillageLogsContextMenuStrip.Size = new System.Drawing.Size(140, 52);
            // 
            // TblVillageLogsPrintAsPDF
            // 
            this.TblVillageLogsPrintAsPDF.Name = "TblVillageLogsPrintAsPDF";
            this.TblVillageLogsPrintAsPDF.Size = new System.Drawing.Size(139, 24);
            this.TblVillageLogsPrintAsPDF.Text = "Print as PDF";
            this.TblVillageLogsPrintAsPDF.Click += new System.EventHandler(this.TblVillageLogsPrintAsPDF_Click);
            // 
            // TblVillageLogsPrintAsExcel
            // 
            this.TblVillageLogsPrintAsExcel.Name = "TblVillageLogsPrintAsExcel";
            this.TblVillageLogsPrintAsExcel.Size = new System.Drawing.Size(139, 24);
            this.TblVillageLogsPrintAsExcel.Text = "Print as Excel";
            this.TblVillageLogsPrintAsExcel.Click += new System.EventHandler(this.TblVillageLogsPrintAsExcel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.ImageKey = "icons8-home-page-48.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1734, 760);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   House Logs   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel1.Controls.Add(this.BtnHouseLogsReset);
            this.splitContainer3.Panel1.Controls.Add(this.BtnHouseLogsSearch);
            this.splitContainer3.Panel1.Controls.Add(this.panel21);
            this.splitContainer3.Panel1.Controls.Add(this.panel22);
            this.splitContainer3.Panel1.Controls.Add(this.panel23);
            this.splitContainer3.Panel1.Controls.Add(this.TxtHouseLogsNoOfPeople);
            this.splitContainer3.Panel1.Controls.Add(this.TxtHouseLogsVillageName);
            this.splitContainer3.Panel1.Controls.Add(this.TxtHouseLogsHouseId);
            this.splitContainer3.Panel1.Controls.Add(this.label27);
            this.splitContainer3.Panel1.Controls.Add(this.label28);
            this.splitContainer3.Panel1.Controls.Add(this.label29);
            this.splitContainer3.Panel1.Controls.Add(this.label30);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.TblHouseLogs);
            this.splitContainer3.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer3.SplitterDistance = 420;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // BtnHouseLogsReset
            // 
            this.BtnHouseLogsReset.AutoSize = true;
            this.BtnHouseLogsReset.Location = new System.Drawing.Point(145, 469);
            this.BtnHouseLogsReset.Name = "BtnHouseLogsReset";
            this.BtnHouseLogsReset.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseLogsReset.TabIndex = 4;
            this.BtnHouseLogsReset.Text = "RESET";
            this.BtnHouseLogsReset.UseVisualStyleBackColor = true;
            this.BtnHouseLogsReset.Click += new System.EventHandler(this.BtnHouseLogsReset_Click);
            // 
            // BtnHouseLogsSearch
            // 
            this.BtnHouseLogsSearch.AutoSize = true;
            this.BtnHouseLogsSearch.Location = new System.Drawing.Point(145, 393);
            this.BtnHouseLogsSearch.Name = "BtnHouseLogsSearch";
            this.BtnHouseLogsSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseLogsSearch.TabIndex = 4;
            this.BtnHouseLogsSearch.Text = "SEARCH";
            this.BtnHouseLogsSearch.UseVisualStyleBackColor = true;
            this.BtnHouseLogsSearch.Click += new System.EventHandler(this.BtnHouseLogsSearch_Click);
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Location = new System.Drawing.Point(16, 345);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(516, 2);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Location = new System.Drawing.Point(16, 260);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(516, 2);
            this.panel22.TabIndex = 3;
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Location = new System.Drawing.Point(16, 176);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(516, 2);
            this.panel23.TabIndex = 3;
            // 
            // TxtHouseLogsNoOfPeople
            // 
            this.TxtHouseLogsNoOfPeople.BackColor = System.Drawing.Color.White;
            this.TxtHouseLogsNoOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseLogsNoOfPeople.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseLogsNoOfPeople.HideSelection = false;
            this.TxtHouseLogsNoOfPeople.Location = new System.Drawing.Point(16, 316);
            this.TxtHouseLogsNoOfPeople.Name = "TxtHouseLogsNoOfPeople";
            this.TxtHouseLogsNoOfPeople.ReadOnly = true;
            this.TxtHouseLogsNoOfPeople.Size = new System.Drawing.Size(516, 27);
            this.TxtHouseLogsNoOfPeople.TabIndex = 0;
            // 
            // TxtHouseLogsVillageName
            // 
            this.TxtHouseLogsVillageName.BackColor = System.Drawing.Color.White;
            this.TxtHouseLogsVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseLogsVillageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseLogsVillageName.HideSelection = false;
            this.TxtHouseLogsVillageName.Location = new System.Drawing.Point(18, 230);
            this.TxtHouseLogsVillageName.Name = "TxtHouseLogsVillageName";
            this.TxtHouseLogsVillageName.Size = new System.Drawing.Size(516, 27);
            this.TxtHouseLogsVillageName.TabIndex = 0;
            // 
            // TxtHouseLogsHouseId
            // 
            this.TxtHouseLogsHouseId.BackColor = System.Drawing.Color.White;
            this.TxtHouseLogsHouseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseLogsHouseId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseLogsHouseId.HideSelection = false;
            this.TxtHouseLogsHouseId.Location = new System.Drawing.Point(16, 147);
            this.TxtHouseLogsHouseId.Name = "TxtHouseLogsHouseId";
            this.TxtHouseLogsHouseId.Size = new System.Drawing.Size(516, 27);
            this.TxtHouseLogsHouseId.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 288);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 25);
            this.label27.TabIndex = 2;
            this.label27.Text = "No. of People";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 201);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 25);
            this.label28.TabIndex = 2;
            this.label28.Text = "Village";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 111);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 25);
            this.label29.TabIndex = 2;
            this.label29.Text = "House ID";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(43, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(446, 37);
            this.label30.TabIndex = 1;
            this.label30.Text = "HOUSE DETAILS";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblHouseLogs
            // 
            this.TblHouseLogs.AllowUserToAddRows = false;
            this.TblHouseLogs.AllowUserToDeleteRows = false;
            this.TblHouseLogs.AllowUserToOrderColumns = true;
            this.TblHouseLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblHouseLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblHouseLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.TblHouseLogs.ContextMenuStrip = this.TblHouseLogsContextMenuStrip;
            this.TblHouseLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblHouseLogs.Location = new System.Drawing.Point(0, 0);
            this.TblHouseLogs.Name = "TblHouseLogs";
            this.TblHouseLogs.ReadOnly = true;
            this.TblHouseLogs.RowHeadersVisible = false;
            this.TblHouseLogs.RowHeadersWidth = 51;
            this.TblHouseLogs.RowTemplate.Height = 50;
            this.TblHouseLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblHouseLogs.Size = new System.Drawing.Size(1299, 750);
            this.TblHouseLogs.TabIndex = 0;
            this.TblHouseLogs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblHouseLogs_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "LOG ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 249;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "OPERATION";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 249;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 250;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 249;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "NO. OF PEOPLE";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 249;
            // 
            // TblHouseLogsContextMenuStrip
            // 
            this.TblHouseLogsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblHouseLogsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblHouseLogsPrintAsPDF,
            this.TblHouseLogsPrintAsExcel});
            this.TblHouseLogsContextMenuStrip.Name = "TblVillageContextMenuStrip";
            this.TblHouseLogsContextMenuStrip.Size = new System.Drawing.Size(165, 52);
            // 
            // TblHouseLogsPrintAsPDF
            // 
            this.TblHouseLogsPrintAsPDF.Name = "TblHouseLogsPrintAsPDF";
            this.TblHouseLogsPrintAsPDF.Size = new System.Drawing.Size(164, 24);
            this.TblHouseLogsPrintAsPDF.Text = "Print as PDF";
            this.TblHouseLogsPrintAsPDF.Click += new System.EventHandler(this.TblHouseLogsPrintAsPDF_Click);
            // 
            // TblHouseLogsPrintAsExcel
            // 
            this.TblHouseLogsPrintAsExcel.Name = "TblHouseLogsPrintAsExcel";
            this.TblHouseLogsPrintAsExcel.Size = new System.Drawing.Size(164, 24);
            this.TblHouseLogsPrintAsExcel.Text = "Print as Excel";
            this.TblHouseLogsPrintAsExcel.Click += new System.EventHandler(this.TblHouseLogsPrintAsExcel_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.ImageKey = "icons8-account-48.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1734, 760);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "   People Logs   ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel1.Controls.Add(this.panel24);
            this.splitContainer4.Panel1.Controls.Add(this.panel25);
            this.splitContainer4.Panel1.Controls.Add(this.BtnPersonLogsReset);
            this.splitContainer4.Panel1.Controls.Add(this.BtnPersonLogsSearch);
            this.splitContainer4.Panel1.Controls.Add(this.panel26);
            this.splitContainer4.Panel1.Controls.Add(this.panel27);
            this.splitContainer4.Panel1.Controls.Add(this.panel28);
            this.splitContainer4.Panel1.Controls.Add(this.panel29);
            this.splitContainer4.Panel1.Controls.Add(this.panel30);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsPhoneNo);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsName);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsGender);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsAge);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsVillageName);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsHouseId);
            this.splitContainer4.Panel1.Controls.Add(this.TxtPersonLogsPersonId);
            this.splitContainer4.Panel1.Controls.Add(this.label31);
            this.splitContainer4.Panel1.Controls.Add(this.label32);
            this.splitContainer4.Panel1.Controls.Add(this.label33);
            this.splitContainer4.Panel1.Controls.Add(this.label34);
            this.splitContainer4.Panel1.Controls.Add(this.label35);
            this.splitContainer4.Panel1.Controls.Add(this.label36);
            this.splitContainer4.Panel1.Controls.Add(this.label37);
            this.splitContainer4.Panel1.Controls.Add(this.label38);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.AutoScroll = true;
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel2.Controls.Add(this.TblPersonLogs);
            this.splitContainer4.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer4.SplitterDistance = 425;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Location = new System.Drawing.Point(21, 232);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(515, 2);
            this.panel24.TabIndex = 9;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Location = new System.Drawing.Point(20, 305);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(515, 2);
            this.panel25.TabIndex = 7;
            // 
            // BtnPersonLogsReset
            // 
            this.BtnPersonLogsReset.AutoSize = true;
            this.BtnPersonLogsReset.Location = new System.Drawing.Point(156, 703);
            this.BtnPersonLogsReset.Name = "BtnPersonLogsReset";
            this.BtnPersonLogsReset.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonLogsReset.TabIndex = 4;
            this.BtnPersonLogsReset.Text = "RESET";
            this.BtnPersonLogsReset.UseVisualStyleBackColor = true;
            this.BtnPersonLogsReset.Click += new System.EventHandler(this.BtnPersonLogsReset_Click);
            // 
            // BtnPersonLogsSearch
            // 
            this.BtnPersonLogsSearch.AutoSize = true;
            this.BtnPersonLogsSearch.Location = new System.Drawing.Point(156, 627);
            this.BtnPersonLogsSearch.Name = "BtnPersonLogsSearch";
            this.BtnPersonLogsSearch.Size = new System.Drawing.Size(247, 41);
            this.BtnPersonLogsSearch.TabIndex = 4;
            this.BtnPersonLogsSearch.Text = "SEARCH";
            this.BtnPersonLogsSearch.UseVisualStyleBackColor = true;
            this.BtnPersonLogsSearch.Click += new System.EventHandler(this.BtnPersonLogsSearch_Click);
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Location = new System.Drawing.Point(20, 518);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(515, 2);
            this.panel26.TabIndex = 3;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Location = new System.Drawing.Point(20, 447);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(515, 2);
            this.panel27.TabIndex = 3;
            // 
            // panel28
            // 
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Location = new System.Drawing.Point(20, 589);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(515, 2);
            this.panel28.TabIndex = 3;
            // 
            // panel29
            // 
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Location = new System.Drawing.Point(20, 376);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(515, 2);
            this.panel29.TabIndex = 3;
            // 
            // panel30
            // 
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Location = new System.Drawing.Point(20, 158);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(515, 2);
            this.panel30.TabIndex = 3;
            // 
            // TxtPersonLogsPhoneNo
            // 
            this.TxtPersonLogsPhoneNo.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsPhoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsPhoneNo.HideSelection = false;
            this.TxtPersonLogsPhoneNo.Location = new System.Drawing.Point(20, 561);
            this.TxtPersonLogsPhoneNo.Name = "TxtPersonLogsPhoneNo";
            this.TxtPersonLogsPhoneNo.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsPhoneNo.TabIndex = 0;
            // 
            // TxtPersonLogsName
            // 
            this.TxtPersonLogsName.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsName.HideSelection = false;
            this.TxtPersonLogsName.Location = new System.Drawing.Point(20, 348);
            this.TxtPersonLogsName.Name = "TxtPersonLogsName";
            this.TxtPersonLogsName.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsName.TabIndex = 0;
            // 
            // TxtPersonLogsGender
            // 
            this.TxtPersonLogsGender.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsGender.HideSelection = false;
            this.TxtPersonLogsGender.Location = new System.Drawing.Point(21, 489);
            this.TxtPersonLogsGender.Name = "TxtPersonLogsGender";
            this.TxtPersonLogsGender.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsGender.TabIndex = 0;
            // 
            // TxtPersonLogsAge
            // 
            this.TxtPersonLogsAge.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsAge.HideSelection = false;
            this.TxtPersonLogsAge.Location = new System.Drawing.Point(22, 418);
            this.TxtPersonLogsAge.Name = "TxtPersonLogsAge";
            this.TxtPersonLogsAge.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsAge.TabIndex = 0;
            // 
            // TxtPersonLogsVillageName
            // 
            this.TxtPersonLogsVillageName.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsVillageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsVillageName.HideSelection = false;
            this.TxtPersonLogsVillageName.Location = new System.Drawing.Point(21, 203);
            this.TxtPersonLogsVillageName.Name = "TxtPersonLogsVillageName";
            this.TxtPersonLogsVillageName.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsVillageName.TabIndex = 0;
            // 
            // TxtPersonLogsHouseId
            // 
            this.TxtPersonLogsHouseId.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsHouseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsHouseId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsHouseId.HideSelection = false;
            this.TxtPersonLogsHouseId.Location = new System.Drawing.Point(20, 277);
            this.TxtPersonLogsHouseId.Name = "TxtPersonLogsHouseId";
            this.TxtPersonLogsHouseId.Size = new System.Drawing.Size(515, 27);
            this.TxtPersonLogsHouseId.TabIndex = 0;
            // 
            // TxtPersonLogsPersonId
            // 
            this.TxtPersonLogsPersonId.BackColor = System.Drawing.Color.White;
            this.TxtPersonLogsPersonId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonLogsPersonId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonLogsPersonId.HideSelection = false;
            this.TxtPersonLogsPersonId.Location = new System.Drawing.Point(20, 130);
            this.TxtPersonLogsPersonId.Name = "TxtPersonLogsPersonId";
            this.TxtPersonLogsPersonId.Size = new System.Drawing.Size(516, 27);
            this.TxtPersonLogsPersonId.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 458);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 25);
            this.label31.TabIndex = 2;
            this.label31.Text = "Gender";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 384);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 25);
            this.label32.TabIndex = 2;
            this.label32.Text = "Age";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(15, 531);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(165, 25);
            this.label33.TabIndex = 2;
            this.label33.Text = "Phone Number";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 318);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 25);
            this.label34.TabIndex = 2;
            this.label34.Text = "Name";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(15, 170);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 25);
            this.label35.TabIndex = 2;
            this.label35.Text = "Village";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(15, 243);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 25);
            this.label36.TabIndex = 2;
            this.label36.Text = "House ID";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(11, 98);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 25);
            this.label37.TabIndex = 2;
            this.label37.Text = "Person ID";
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(2, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(534, 37);
            this.label38.TabIndex = 1;
            this.label38.Text = "PERSON DETAILS";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblPersonLogs
            // 
            this.TblPersonLogs.AllowUserToAddRows = false;
            this.TblPersonLogs.AllowUserToDeleteRows = false;
            this.TblPersonLogs.AllowUserToOrderColumns = true;
            this.TblPersonLogs.AllowUserToResizeRows = false;
            this.TblPersonLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblPersonLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblPersonLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblPersonLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.TblPersonLogs.ContextMenuStrip = this.TblPersonLogsContextMenuStrip;
            this.TblPersonLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPersonLogs.Location = new System.Drawing.Point(0, 0);
            this.TblPersonLogs.MultiSelect = false;
            this.TblPersonLogs.Name = "TblPersonLogs";
            this.TblPersonLogs.ReadOnly = true;
            this.TblPersonLogs.RowHeadersVisible = false;
            this.TblPersonLogs.RowHeadersWidth = 51;
            this.TblPersonLogs.RowTemplate.Height = 50;
            this.TblPersonLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblPersonLogs.Size = new System.Drawing.Size(1294, 750);
            this.TblPersonLogs.TabIndex = 0;
            this.TblPersonLogs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblPersonLogs_CellMouseDoubleClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "LOG ID";
            this.Column8.MinimumWidth = 150;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "OPERATION";
            this.Column9.MinimumWidth = 200;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "PERSON ID";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 200;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "AGE";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "GENDER";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "PHONE NO.";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // TblPersonLogsContextMenuStrip
            // 
            this.TblPersonLogsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblPersonLogsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblPersonLogsPrintAsPDF,
            this.TblPersonLogsPrintAsExcel});
            this.TblPersonLogsContextMenuStrip.Name = "TblHouseContextMenuStrip";
            this.TblPersonLogsContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TblPersonLogsContextMenuStrip.ShowImageMargin = false;
            this.TblPersonLogsContextMenuStrip.Size = new System.Drawing.Size(142, 52);
            // 
            // TblPersonLogsPrintAsPDF
            // 
            this.TblPersonLogsPrintAsPDF.Name = "TblPersonLogsPrintAsPDF";
            this.TblPersonLogsPrintAsPDF.Size = new System.Drawing.Size(141, 24);
            this.TblPersonLogsPrintAsPDF.Text = "Print as PDF";
            this.TblPersonLogsPrintAsPDF.Click += new System.EventHandler(this.TblPersonLogsPrintAsPDF_Click);
            // 
            // TblPersonLogsPrintAsExcel
            // 
            this.TblPersonLogsPrintAsExcel.Name = "TblPersonLogsPrintAsExcel";
            this.TblPersonLogsPrintAsExcel.Size = new System.Drawing.Size(141, 24);
            this.TblPersonLogsPrintAsExcel.Text = "Print As Excel";
            this.TblPersonLogsPrintAsExcel.Click += new System.EventHandler(this.TblPersonLogsPrintAsExcel_Click);
            // 
            // InnerImageList
            // 
            this.InnerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("InnerImageList.ImageStream")));
            this.InnerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.InnerImageList.Images.SetKeyName(0, "icons8-village-60.png");
            this.InnerImageList.Images.SetKeyName(1, "icons8-home-page-48.png");
            this.InnerImageList.Images.SetKeyName(2, "icons8-account-48.png");
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.tabControl2);
            this.InventoryTab.ImageKey = "icons8-warehouse-50.png";
            this.InventoryTab.Location = new System.Drawing.Point(4, 44);
            this.InventoryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(1762, 856);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "   Inventory   ";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.MedicinesTab);
            this.tabControl2.Controls.Add(this.DisposablesTab);
            this.tabControl2.Controls.Add(this.StationaryTab);
            this.tabControl2.Controls.Add(this.MiscellaneousTab);
            this.tabControl2.Controls.Add(this.InventoryLogsTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ImageList = this.InnerImageList;
            this.tabControl2.ItemSize = new System.Drawing.Size(71, 35);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1762, 856);
            this.tabControl2.TabIndex = 2;
            // 
            // MedicinesTab
            // 
            this.MedicinesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MedicinesTab.Controls.Add(this.splitContainer5);
            this.MedicinesTab.ImageKey = "icons8-village-60.png";
            this.MedicinesTab.Location = new System.Drawing.Point(4, 39);
            this.MedicinesTab.Name = "MedicinesTab";
            this.MedicinesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MedicinesTab.Size = new System.Drawing.Size(1754, 813);
            this.MedicinesTab.TabIndex = 0;
            this.MedicinesTab.Text = "   Medicines   ";
            this.MedicinesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.AutoScroll = true;
            this.splitContainer5.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer5.Panel1.Controls.Add(this.TxtMedicineQuantity);
            this.splitContainer5.Panel1.Controls.Add(this.BtnMedicineReset);
            this.splitContainer5.Panel1.Controls.Add(this.BtnMedicineSearcch);
            this.splitContainer5.Panel1.Controls.Add(this.BtnMedicineUpdate);
            this.splitContainer5.Panel1.Controls.Add(this.BtnMedicineDelete);
            this.splitContainer5.Panel1.Controls.Add(this.BtnMedicineInsert);
            this.splitContainer5.Panel1.Controls.Add(this.panel32);
            this.splitContainer5.Panel1.Controls.Add(this.panel33);
            this.splitContainer5.Panel1.Controls.Add(this.panel34);
            this.splitContainer5.Panel1.Controls.Add(this.TxtMedicineName);
            this.splitContainer5.Panel1.Controls.Add(this.TxtMedicineId);
            this.splitContainer5.Panel1.Controls.Add(this.label40);
            this.splitContainer5.Panel1.Controls.Add(this.label41);
            this.splitContainer5.Panel1.Controls.Add(this.label42);
            this.splitContainer5.Panel1.Controls.Add(this.label43);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer5.Panel2.Controls.Add(this.TblMedicines);
            this.splitContainer5.Size = new System.Drawing.Size(1748, 807);
            this.splitContainer5.SplitterDistance = 420;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // TxtMedicineQuantity
            // 
            this.TxtMedicineQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineQuantity.Location = new System.Drawing.Point(16, 310);
            this.TxtMedicineQuantity.Name = "TxtMedicineQuantity";
            this.TxtMedicineQuantity.Size = new System.Drawing.Size(516, 30);
            this.TxtMedicineQuantity.TabIndex = 5;
            // 
            // BtnMedicineReset
            // 
            this.BtnMedicineReset.AutoSize = true;
            this.BtnMedicineReset.Location = new System.Drawing.Point(151, 549);
            this.BtnMedicineReset.Name = "BtnMedicineReset";
            this.BtnMedicineReset.Size = new System.Drawing.Size(244, 41);
            this.BtnMedicineReset.TabIndex = 4;
            this.BtnMedicineReset.Text = "RESET";
            this.BtnMedicineReset.UseVisualStyleBackColor = true;
            this.BtnMedicineReset.Click += new System.EventHandler(this.BtnMedicineReset_Click);
            // 
            // BtnMedicineSearcch
            // 
            this.BtnMedicineSearcch.AutoSize = true;
            this.BtnMedicineSearcch.Location = new System.Drawing.Point(288, 476);
            this.BtnMedicineSearcch.Name = "BtnMedicineSearcch";
            this.BtnMedicineSearcch.Size = new System.Drawing.Size(244, 41);
            this.BtnMedicineSearcch.TabIndex = 4;
            this.BtnMedicineSearcch.Text = "SEARCH";
            this.BtnMedicineSearcch.UseVisualStyleBackColor = true;
            this.BtnMedicineSearcch.Click += new System.EventHandler(this.BtnMedicineSearcch_Click);
            // 
            // BtnMedicineUpdate
            // 
            this.BtnMedicineUpdate.AutoSize = true;
            this.BtnMedicineUpdate.Location = new System.Drawing.Point(288, 400);
            this.BtnMedicineUpdate.Name = "BtnMedicineUpdate";
            this.BtnMedicineUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnMedicineUpdate.TabIndex = 4;
            this.BtnMedicineUpdate.Text = "UPDATE";
            this.BtnMedicineUpdate.UseMnemonic = false;
            this.BtnMedicineUpdate.UseVisualStyleBackColor = false;
            this.BtnMedicineUpdate.Click += new System.EventHandler(this.BtnMedicineUpdate_Click);
            // 
            // BtnMedicineDelete
            // 
            this.BtnMedicineDelete.AutoSize = true;
            this.BtnMedicineDelete.Location = new System.Drawing.Point(16, 476);
            this.BtnMedicineDelete.Name = "BtnMedicineDelete";
            this.BtnMedicineDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnMedicineDelete.TabIndex = 4;
            this.BtnMedicineDelete.Text = "DELETE";
            this.BtnMedicineDelete.UseVisualStyleBackColor = true;
            this.BtnMedicineDelete.Click += new System.EventHandler(this.BtnMedicineDelete_Click);
            // 
            // BtnMedicineInsert
            // 
            this.BtnMedicineInsert.AutoSize = true;
            this.BtnMedicineInsert.Location = new System.Drawing.Point(16, 400);
            this.BtnMedicineInsert.Name = "BtnMedicineInsert";
            this.BtnMedicineInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnMedicineInsert.TabIndex = 4;
            this.BtnMedicineInsert.Text = "INSERT";
            this.BtnMedicineInsert.UseVisualStyleBackColor = true;
            this.BtnMedicineInsert.Click += new System.EventHandler(this.BtnMedicineInsert_Click);
            // 
            // panel32
            // 
            this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel32.Location = new System.Drawing.Point(16, 343);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(516, 2);
            this.panel32.TabIndex = 3;
            // 
            // panel33
            // 
            this.panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel33.Location = new System.Drawing.Point(16, 260);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(516, 2);
            this.panel33.TabIndex = 3;
            // 
            // panel34
            // 
            this.panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel34.Location = new System.Drawing.Point(16, 176);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(516, 2);
            this.panel34.TabIndex = 3;
            // 
            // TxtMedicineName
            // 
            this.TxtMedicineName.BackColor = System.Drawing.Color.White;
            this.TxtMedicineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMedicineName.HideSelection = false;
            this.TxtMedicineName.Location = new System.Drawing.Point(16, 231);
            this.TxtMedicineName.Name = "TxtMedicineName";
            this.TxtMedicineName.Size = new System.Drawing.Size(516, 27);
            this.TxtMedicineName.TabIndex = 0;
            // 
            // TxtMedicineId
            // 
            this.TxtMedicineId.BackColor = System.Drawing.Color.White;
            this.TxtMedicineId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMedicineId.HideSelection = false;
            this.TxtMedicineId.Location = new System.Drawing.Point(16, 147);
            this.TxtMedicineId.Name = "TxtMedicineId";
            this.TxtMedicineId.Size = new System.Drawing.Size(516, 27);
            this.TxtMedicineId.TabIndex = 0;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(11, 282);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(100, 25);
            this.label40.TabIndex = 2;
            this.label40.Text = "Quantity";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(11, 199);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(169, 25);
            this.label41.TabIndex = 2;
            this.label41.Text = "Medicine Name";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(11, 112);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(136, 25);
            this.label42.TabIndex = 2;
            this.label42.Text = "Medicine ID";
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(43, 30);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(446, 37);
            this.label43.TabIndex = 1;
            this.label43.Text = "MEDICINES";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblMedicines
            // 
            this.TblMedicines.AllowUserToAddRows = false;
            this.TblMedicines.AllowUserToDeleteRows = false;
            this.TblMedicines.AllowUserToOrderColumns = true;
            this.TblMedicines.AllowUserToResizeRows = false;
            this.TblMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblMedicines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.TblMedicines.ContextMenuStrip = this.TblVillageContextMenuStrip;
            this.TblMedicines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMedicines.Location = new System.Drawing.Point(0, 0);
            this.TblMedicines.MultiSelect = false;
            this.TblMedicines.Name = "TblMedicines";
            this.TblMedicines.ReadOnly = true;
            this.TblMedicines.RowHeadersVisible = false;
            this.TblMedicines.RowHeadersWidth = 51;
            this.TblMedicines.RowTemplate.DividerHeight = 2;
            this.TblMedicines.RowTemplate.Height = 50;
            this.TblMedicines.RowTemplate.ReadOnly = true;
            this.TblMedicines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TblMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMedicines.Size = new System.Drawing.Size(1319, 803);
            this.TblMedicines.TabIndex = 0;
            this.TblMedicines.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblMedicines_CellMouseDoubleClick);
            // 
            // DisposablesTab
            // 
            this.DisposablesTab.Controls.Add(this.splitContainer6);
            this.DisposablesTab.ImageKey = "icons8-home-page-48.png";
            this.DisposablesTab.Location = new System.Drawing.Point(4, 39);
            this.DisposablesTab.Name = "DisposablesTab";
            this.DisposablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisposablesTab.Size = new System.Drawing.Size(1754, 813);
            this.DisposablesTab.TabIndex = 1;
            this.DisposablesTab.Text = "   Disposables   ";
            this.DisposablesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.AutoScroll = true;
            this.splitContainer6.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer6.Panel1.Controls.Add(this.TxtDisposableQuantity);
            this.splitContainer6.Panel1.Controls.Add(this.BtnDisposableReset);
            this.splitContainer6.Panel1.Controls.Add(this.BtnDisposableSearch);
            this.splitContainer6.Panel1.Controls.Add(this.BtnDisposableUpdate);
            this.splitContainer6.Panel1.Controls.Add(this.BtnDisposableDelete);
            this.splitContainer6.Panel1.Controls.Add(this.BtnDisposableInsert);
            this.splitContainer6.Panel1.Controls.Add(this.panel35);
            this.splitContainer6.Panel1.Controls.Add(this.panel36);
            this.splitContainer6.Panel1.Controls.Add(this.panel37);
            this.splitContainer6.Panel1.Controls.Add(this.TxtDisposableName);
            this.splitContainer6.Panel1.Controls.Add(this.TxtDisposableId);
            this.splitContainer6.Panel1.Controls.Add(this.label44);
            this.splitContainer6.Panel1.Controls.Add(this.label45);
            this.splitContainer6.Panel1.Controls.Add(this.label46);
            this.splitContainer6.Panel1.Controls.Add(this.label47);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer6.Panel2.Controls.Add(this.TblDisposables);
            this.splitContainer6.Size = new System.Drawing.Size(1748, 807);
            this.splitContainer6.SplitterDistance = 420;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 1;
            // 
            // TxtDisposableQuantity
            // 
            this.TxtDisposableQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisposableQuantity.Location = new System.Drawing.Point(16, 314);
            this.TxtDisposableQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.TxtDisposableQuantity.Name = "TxtDisposableQuantity";
            this.TxtDisposableQuantity.Size = new System.Drawing.Size(516, 30);
            this.TxtDisposableQuantity.TabIndex = 6;
            // 
            // BtnDisposableReset
            // 
            this.BtnDisposableReset.AutoSize = true;
            this.BtnDisposableReset.Location = new System.Drawing.Point(145, 546);
            this.BtnDisposableReset.Name = "BtnDisposableReset";
            this.BtnDisposableReset.Size = new System.Drawing.Size(244, 41);
            this.BtnDisposableReset.TabIndex = 4;
            this.BtnDisposableReset.Text = "RESET";
            this.BtnDisposableReset.UseVisualStyleBackColor = true;
            this.BtnDisposableReset.Click += new System.EventHandler(this.BtnDisposableReset_Click);
            // 
            // BtnDisposableSearch
            // 
            this.BtnDisposableSearch.AutoSize = true;
            this.BtnDisposableSearch.Location = new System.Drawing.Point(288, 476);
            this.BtnDisposableSearch.Name = "BtnDisposableSearch";
            this.BtnDisposableSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnDisposableSearch.TabIndex = 4;
            this.BtnDisposableSearch.Text = "SEARCH";
            this.BtnDisposableSearch.UseVisualStyleBackColor = true;
            this.BtnDisposableSearch.Click += new System.EventHandler(this.BtnDisposableSearch_Click);
            // 
            // BtnDisposableUpdate
            // 
            this.BtnDisposableUpdate.AutoSize = true;
            this.BtnDisposableUpdate.Location = new System.Drawing.Point(288, 400);
            this.BtnDisposableUpdate.Name = "BtnDisposableUpdate";
            this.BtnDisposableUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnDisposableUpdate.TabIndex = 4;
            this.BtnDisposableUpdate.Text = "UPDATE";
            this.BtnDisposableUpdate.UseVisualStyleBackColor = true;
            this.BtnDisposableUpdate.Click += new System.EventHandler(this.BtnDisposableUpdate_Click);
            // 
            // BtnDisposableDelete
            // 
            this.BtnDisposableDelete.AutoSize = true;
            this.BtnDisposableDelete.Location = new System.Drawing.Point(16, 476);
            this.BtnDisposableDelete.Name = "BtnDisposableDelete";
            this.BtnDisposableDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnDisposableDelete.TabIndex = 4;
            this.BtnDisposableDelete.Text = "DELETE";
            this.BtnDisposableDelete.UseVisualStyleBackColor = true;
            this.BtnDisposableDelete.Click += new System.EventHandler(this.BtnDisposableDelete_Click);
            // 
            // BtnDisposableInsert
            // 
            this.BtnDisposableInsert.AutoSize = true;
            this.BtnDisposableInsert.Location = new System.Drawing.Point(16, 400);
            this.BtnDisposableInsert.Name = "BtnDisposableInsert";
            this.BtnDisposableInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnDisposableInsert.TabIndex = 4;
            this.BtnDisposableInsert.Text = "INSERT";
            this.BtnDisposableInsert.UseVisualStyleBackColor = true;
            this.BtnDisposableInsert.Click += new System.EventHandler(this.BtnDisposableInsert_Click);
            // 
            // panel35
            // 
            this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel35.Location = new System.Drawing.Point(16, 345);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(516, 2);
            this.panel35.TabIndex = 3;
            // 
            // panel36
            // 
            this.panel36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel36.Location = new System.Drawing.Point(16, 260);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(516, 2);
            this.panel36.TabIndex = 3;
            // 
            // panel37
            // 
            this.panel37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel37.Location = new System.Drawing.Point(16, 176);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(516, 2);
            this.panel37.TabIndex = 3;
            // 
            // TxtDisposableName
            // 
            this.TxtDisposableName.BackColor = System.Drawing.Color.White;
            this.TxtDisposableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisposableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDisposableName.HideSelection = false;
            this.TxtDisposableName.Location = new System.Drawing.Point(17, 229);
            this.TxtDisposableName.Name = "TxtDisposableName";
            this.TxtDisposableName.Size = new System.Drawing.Size(516, 27);
            this.TxtDisposableName.TabIndex = 0;
            this.TxtDisposableName.TextChanged += new System.EventHandler(this.TxtDisposableName_TextChanged);
            // 
            // TxtDisposableId
            // 
            this.TxtDisposableId.BackColor = System.Drawing.Color.White;
            this.TxtDisposableId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisposableId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDisposableId.HideSelection = false;
            this.TxtDisposableId.Location = new System.Drawing.Point(16, 147);
            this.TxtDisposableId.Name = "TxtDisposableId";
            this.TxtDisposableId.Size = new System.Drawing.Size(516, 27);
            this.TxtDisposableId.TabIndex = 0;
            this.TxtDisposableId.TextChanged += new System.EventHandler(this.TxtDisposableId_TextChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(11, 288);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(100, 25);
            this.label44.TabIndex = 2;
            this.label44.Text = "Quantity";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(11, 201);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(183, 25);
            this.label45.TabIndex = 2;
            this.label45.Text = "Disposable Name";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(11, 111);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(150, 25);
            this.label46.TabIndex = 2;
            this.label46.Text = "Disposable ID";
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(43, 30);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(446, 37);
            this.label47.TabIndex = 1;
            this.label47.Text = "DISPOSABLES";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblDisposables
            // 
            this.TblDisposables.AllowUserToAddRows = false;
            this.TblDisposables.AllowUserToDeleteRows = false;
            this.TblDisposables.AllowUserToOrderColumns = true;
            this.TblDisposables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblDisposables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblDisposables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblDisposables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.TblDisposables.ContextMenuStrip = this.TblHouseContextMenuStrip;
            this.TblDisposables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblDisposables.Location = new System.Drawing.Point(0, 0);
            this.TblDisposables.Name = "TblDisposables";
            this.TblDisposables.ReadOnly = true;
            this.TblDisposables.RowHeadersVisible = false;
            this.TblDisposables.RowHeadersWidth = 51;
            this.TblDisposables.RowTemplate.Height = 50;
            this.TblDisposables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblDisposables.Size = new System.Drawing.Size(1319, 803);
            this.TblDisposables.TabIndex = 0;
            this.TblDisposables.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblDisposables_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.HeaderText = "DISPOSABLE ID";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "DISPOSABLE NAME";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // StationaryTab
            // 
            this.StationaryTab.Controls.Add(this.splitContainer7);
            this.StationaryTab.ImageKey = "icons8-account-48.png";
            this.StationaryTab.Location = new System.Drawing.Point(4, 39);
            this.StationaryTab.Name = "StationaryTab";
            this.StationaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationaryTab.Size = new System.Drawing.Size(1754, 813);
            this.StationaryTab.TabIndex = 2;
            this.StationaryTab.Text = "   Stationary   ";
            this.StationaryTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.AutoScroll = true;
            this.splitContainer7.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer7.Panel1.Controls.Add(this.TxtStationaryQuantity);
            this.splitContainer7.Panel1.Controls.Add(this.BtnStstionaryReset);
            this.splitContainer7.Panel1.Controls.Add(this.BtnStstionarySearch);
            this.splitContainer7.Panel1.Controls.Add(this.BtnStstionaryUpdate);
            this.splitContainer7.Panel1.Controls.Add(this.BtnStstionaryDelete);
            this.splitContainer7.Panel1.Controls.Add(this.BtnStstionaryInsert);
            this.splitContainer7.Panel1.Controls.Add(this.panel41);
            this.splitContainer7.Panel1.Controls.Add(this.panel42);
            this.splitContainer7.Panel1.Controls.Add(this.panel43);
            this.splitContainer7.Panel1.Controls.Add(this.TxtStationaryName);
            this.splitContainer7.Panel1.Controls.Add(this.TxtStationaryId);
            this.splitContainer7.Panel1.Controls.Add(this.label49);
            this.splitContainer7.Panel1.Controls.Add(this.label51);
            this.splitContainer7.Panel1.Controls.Add(this.label53);
            this.splitContainer7.Panel1.Controls.Add(this.label55);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.AutoScroll = true;
            this.splitContainer7.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer7.Panel2.Controls.Add(this.TblStationary);
            this.splitContainer7.Size = new System.Drawing.Size(1748, 807);
            this.splitContainer7.SplitterDistance = 425;
            this.splitContainer7.SplitterWidth = 5;
            this.splitContainer7.TabIndex = 1;
            // 
            // TxtStationaryQuantity
            // 
            this.TxtStationaryQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStationaryQuantity.Location = new System.Drawing.Point(16, 314);
            this.TxtStationaryQuantity.Name = "TxtStationaryQuantity";
            this.TxtStationaryQuantity.Size = new System.Drawing.Size(516, 30);
            this.TxtStationaryQuantity.TabIndex = 20;
            // 
            // BtnStstionaryReset
            // 
            this.BtnStstionaryReset.AutoSize = true;
            this.BtnStstionaryReset.Location = new System.Drawing.Point(145, 546);
            this.BtnStstionaryReset.Name = "BtnStstionaryReset";
            this.BtnStstionaryReset.Size = new System.Drawing.Size(244, 41);
            this.BtnStstionaryReset.TabIndex = 14;
            this.BtnStstionaryReset.Text = "RESET";
            this.BtnStstionaryReset.UseVisualStyleBackColor = true;
            this.BtnStstionaryReset.Click += new System.EventHandler(this.BtnStstionaryReset_Click);
            // 
            // BtnStstionarySearch
            // 
            this.BtnStstionarySearch.AutoSize = true;
            this.BtnStstionarySearch.Location = new System.Drawing.Point(288, 476);
            this.BtnStstionarySearch.Name = "BtnStstionarySearch";
            this.BtnStstionarySearch.Size = new System.Drawing.Size(244, 41);
            this.BtnStstionarySearch.TabIndex = 15;
            this.BtnStstionarySearch.Text = "SEARCH";
            this.BtnStstionarySearch.UseVisualStyleBackColor = true;
            this.BtnStstionarySearch.Click += new System.EventHandler(this.BtnStstionarySearch_Click);
            // 
            // BtnStstionaryUpdate
            // 
            this.BtnStstionaryUpdate.AutoSize = true;
            this.BtnStstionaryUpdate.Location = new System.Drawing.Point(288, 400);
            this.BtnStstionaryUpdate.Name = "BtnStstionaryUpdate";
            this.BtnStstionaryUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnStstionaryUpdate.TabIndex = 16;
            this.BtnStstionaryUpdate.Text = "UPDATE";
            this.BtnStstionaryUpdate.UseVisualStyleBackColor = true;
            this.BtnStstionaryUpdate.Click += new System.EventHandler(this.BtnStstionaryUpdate_Click);
            // 
            // BtnStstionaryDelete
            // 
            this.BtnStstionaryDelete.AutoSize = true;
            this.BtnStstionaryDelete.Location = new System.Drawing.Point(16, 476);
            this.BtnStstionaryDelete.Name = "BtnStstionaryDelete";
            this.BtnStstionaryDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnStstionaryDelete.TabIndex = 17;
            this.BtnStstionaryDelete.Text = "DELETE";
            this.BtnStstionaryDelete.UseVisualStyleBackColor = true;
            this.BtnStstionaryDelete.Click += new System.EventHandler(this.BtnStstionaryDelete_Click);
            // 
            // BtnStstionaryInsert
            // 
            this.BtnStstionaryInsert.AutoSize = true;
            this.BtnStstionaryInsert.Location = new System.Drawing.Point(16, 400);
            this.BtnStstionaryInsert.Name = "BtnStstionaryInsert";
            this.BtnStstionaryInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnStstionaryInsert.TabIndex = 18;
            this.BtnStstionaryInsert.Text = "INSERT";
            this.BtnStstionaryInsert.UseVisualStyleBackColor = true;
            this.BtnStstionaryInsert.Click += new System.EventHandler(this.BtnStstionaryInsert_Click);
            // 
            // panel41
            // 
            this.panel41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel41.Location = new System.Drawing.Point(16, 345);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(516, 2);
            this.panel41.TabIndex = 11;
            // 
            // panel42
            // 
            this.panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel42.Location = new System.Drawing.Point(16, 260);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(516, 2);
            this.panel42.TabIndex = 12;
            // 
            // panel43
            // 
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Location = new System.Drawing.Point(16, 176);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(516, 2);
            this.panel43.TabIndex = 13;
            // 
            // TxtStationaryName
            // 
            this.TxtStationaryName.BackColor = System.Drawing.Color.White;
            this.TxtStationaryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStationaryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStationaryName.HideSelection = false;
            this.TxtStationaryName.Location = new System.Drawing.Point(16, 229);
            this.TxtStationaryName.Name = "TxtStationaryName";
            this.TxtStationaryName.Size = new System.Drawing.Size(516, 27);
            this.TxtStationaryName.TabIndex = 7;
            this.TxtStationaryName.TextChanged += new System.EventHandler(this.TxtStationaryName_TextChanged);
            // 
            // TxtStationaryId
            // 
            this.TxtStationaryId.BackColor = System.Drawing.Color.White;
            this.TxtStationaryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStationaryId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStationaryId.HideSelection = false;
            this.TxtStationaryId.Location = new System.Drawing.Point(16, 147);
            this.TxtStationaryId.Name = "TxtStationaryId";
            this.TxtStationaryId.Size = new System.Drawing.Size(516, 27);
            this.TxtStationaryId.TabIndex = 7;
            this.TxtStationaryId.TextChanged += new System.EventHandler(this.TxtStationaryId_TextChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 288);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(100, 25);
            this.label49.TabIndex = 8;
            this.label49.Text = "Quantity";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(11, 201);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(124, 25);
            this.label51.TabIndex = 9;
            this.label51.Text = "Item Name";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(11, 111);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(91, 25);
            this.label53.TabIndex = 10;
            this.label53.Text = "Item ID";
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(2, 30);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(534, 37);
            this.label55.TabIndex = 1;
            this.label55.Text = "STATIONARY";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblStationary
            // 
            this.TblStationary.AllowUserToAddRows = false;
            this.TblStationary.AllowUserToDeleteRows = false;
            this.TblStationary.AllowUserToOrderColumns = true;
            this.TblStationary.AllowUserToResizeRows = false;
            this.TblStationary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblStationary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblStationary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblStationary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblStationary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.TblStationary.ContextMenuStrip = this.TblPersonContextMenuStrip;
            this.TblStationary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblStationary.Location = new System.Drawing.Point(0, 0);
            this.TblStationary.MultiSelect = false;
            this.TblStationary.Name = "TblStationary";
            this.TblStationary.ReadOnly = true;
            this.TblStationary.RowHeadersVisible = false;
            this.TblStationary.RowHeadersWidth = 51;
            this.TblStationary.RowTemplate.Height = 50;
            this.TblStationary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblStationary.Size = new System.Drawing.Size(1314, 803);
            this.TblStationary.TabIndex = 0;
            this.TblStationary.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblStationary_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.HeaderText = "PERSON ID";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.HeaderText = "AGE";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.HeaderText = "GENDER";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.HeaderText = "PHONE NO.";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.splitContainer9);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 39);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousTab.Size = new System.Drawing.Size(1754, 813);
            this.MiscellaneousTab.TabIndex = 4;
            this.MiscellaneousTab.Text = "   Miscellaneous   ";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer9
            // 
            this.splitContainer9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.Location = new System.Drawing.Point(3, 3);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.AutoScroll = true;
            this.splitContainer9.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer9.Panel1.Controls.Add(this.TxtMiscellaneousQuantity);
            this.splitContainer9.Panel1.Controls.Add(this.BtnMiscellaneousReset);
            this.splitContainer9.Panel1.Controls.Add(this.BtnMiscellaneousSearch);
            this.splitContainer9.Panel1.Controls.Add(this.BtnMiscellaneousUpdate);
            this.splitContainer9.Panel1.Controls.Add(this.BtnMiscellaneousDelete);
            this.splitContainer9.Panel1.Controls.Add(this.BtnMiscellaneousInsert);
            this.splitContainer9.Panel1.Controls.Add(this.panel38);
            this.splitContainer9.Panel1.Controls.Add(this.panel39);
            this.splitContainer9.Panel1.Controls.Add(this.panel40);
            this.splitContainer9.Panel1.Controls.Add(this.TxtMiscellaneousName);
            this.splitContainer9.Panel1.Controls.Add(this.TxtMiscellaneousId);
            this.splitContainer9.Panel1.Controls.Add(this.label48);
            this.splitContainer9.Panel1.Controls.Add(this.label50);
            this.splitContainer9.Panel1.Controls.Add(this.label52);
            this.splitContainer9.Panel1.Controls.Add(this.label71);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.AutoScroll = true;
            this.splitContainer9.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer9.Panel2.Controls.Add(this.TblMiscellaneous);
            this.splitContainer9.Size = new System.Drawing.Size(1748, 807);
            this.splitContainer9.SplitterDistance = 425;
            this.splitContainer9.SplitterWidth = 5;
            this.splitContainer9.TabIndex = 2;
            // 
            // TxtMiscellaneousQuantity
            // 
            this.TxtMiscellaneousQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMiscellaneousQuantity.Location = new System.Drawing.Point(16, 315);
            this.TxtMiscellaneousQuantity.Name = "TxtMiscellaneousQuantity";
            this.TxtMiscellaneousQuantity.Size = new System.Drawing.Size(516, 30);
            this.TxtMiscellaneousQuantity.TabIndex = 21;
            // 
            // BtnMiscellaneousReset
            // 
            this.BtnMiscellaneousReset.AutoSize = true;
            this.BtnMiscellaneousReset.Location = new System.Drawing.Point(145, 546);
            this.BtnMiscellaneousReset.Name = "BtnMiscellaneousReset";
            this.BtnMiscellaneousReset.Size = new System.Drawing.Size(244, 41);
            this.BtnMiscellaneousReset.TabIndex = 14;
            this.BtnMiscellaneousReset.Text = "RESET";
            this.BtnMiscellaneousReset.UseVisualStyleBackColor = true;
            this.BtnMiscellaneousReset.Click += new System.EventHandler(this.BtnMiscellaneousReset_Click);
            // 
            // BtnMiscellaneousSearch
            // 
            this.BtnMiscellaneousSearch.AutoSize = true;
            this.BtnMiscellaneousSearch.Location = new System.Drawing.Point(288, 476);
            this.BtnMiscellaneousSearch.Name = "BtnMiscellaneousSearch";
            this.BtnMiscellaneousSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnMiscellaneousSearch.TabIndex = 15;
            this.BtnMiscellaneousSearch.Text = "SEARCH";
            this.BtnMiscellaneousSearch.UseVisualStyleBackColor = true;
            this.BtnMiscellaneousSearch.Click += new System.EventHandler(this.BtnMiscellaneousSearch_Click);
            // 
            // BtnMiscellaneousUpdate
            // 
            this.BtnMiscellaneousUpdate.AutoSize = true;
            this.BtnMiscellaneousUpdate.Location = new System.Drawing.Point(288, 400);
            this.BtnMiscellaneousUpdate.Name = "BtnMiscellaneousUpdate";
            this.BtnMiscellaneousUpdate.Size = new System.Drawing.Size(244, 41);
            this.BtnMiscellaneousUpdate.TabIndex = 16;
            this.BtnMiscellaneousUpdate.Text = "UPDATE";
            this.BtnMiscellaneousUpdate.UseVisualStyleBackColor = true;
            this.BtnMiscellaneousUpdate.Click += new System.EventHandler(this.BtnMiscellaneousUpdate_Click);
            // 
            // BtnMiscellaneousDelete
            // 
            this.BtnMiscellaneousDelete.AutoSize = true;
            this.BtnMiscellaneousDelete.Location = new System.Drawing.Point(16, 476);
            this.BtnMiscellaneousDelete.Name = "BtnMiscellaneousDelete";
            this.BtnMiscellaneousDelete.Size = new System.Drawing.Size(244, 41);
            this.BtnMiscellaneousDelete.TabIndex = 17;
            this.BtnMiscellaneousDelete.Text = "DELETE";
            this.BtnMiscellaneousDelete.UseVisualStyleBackColor = true;
            this.BtnMiscellaneousDelete.Click += new System.EventHandler(this.BtnMiscellaneousDelete_Click);
            // 
            // BtnMiscellaneousInsert
            // 
            this.BtnMiscellaneousInsert.AutoSize = true;
            this.BtnMiscellaneousInsert.Location = new System.Drawing.Point(16, 400);
            this.BtnMiscellaneousInsert.Name = "BtnMiscellaneousInsert";
            this.BtnMiscellaneousInsert.Size = new System.Drawing.Size(244, 41);
            this.BtnMiscellaneousInsert.TabIndex = 18;
            this.BtnMiscellaneousInsert.Text = "INSERT";
            this.BtnMiscellaneousInsert.UseVisualStyleBackColor = true;
            this.BtnMiscellaneousInsert.Click += new System.EventHandler(this.BtnMiscellaneousInsert_Click);
            // 
            // panel38
            // 
            this.panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel38.Location = new System.Drawing.Point(16, 345);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(516, 2);
            this.panel38.TabIndex = 11;
            // 
            // panel39
            // 
            this.panel39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel39.Location = new System.Drawing.Point(16, 260);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(516, 2);
            this.panel39.TabIndex = 12;
            // 
            // panel40
            // 
            this.panel40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel40.Location = new System.Drawing.Point(16, 176);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(516, 2);
            this.panel40.TabIndex = 13;
            // 
            // TxtMiscellaneousName
            // 
            this.TxtMiscellaneousName.BackColor = System.Drawing.Color.White;
            this.TxtMiscellaneousName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMiscellaneousName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMiscellaneousName.HideSelection = false;
            this.TxtMiscellaneousName.Location = new System.Drawing.Point(16, 229);
            this.TxtMiscellaneousName.Name = "TxtMiscellaneousName";
            this.TxtMiscellaneousName.Size = new System.Drawing.Size(516, 27);
            this.TxtMiscellaneousName.TabIndex = 7;
            this.TxtMiscellaneousName.TextChanged += new System.EventHandler(this.TxtMiscellaneousName_TextChanged);
            // 
            // TxtMiscellaneousId
            // 
            this.TxtMiscellaneousId.BackColor = System.Drawing.Color.White;
            this.TxtMiscellaneousId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMiscellaneousId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMiscellaneousId.HideSelection = false;
            this.TxtMiscellaneousId.Location = new System.Drawing.Point(16, 147);
            this.TxtMiscellaneousId.Name = "TxtMiscellaneousId";
            this.TxtMiscellaneousId.Size = new System.Drawing.Size(516, 27);
            this.TxtMiscellaneousId.TabIndex = 7;
            this.TxtMiscellaneousId.TextChanged += new System.EventHandler(this.TxtMiscellaneousId_TextChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 288);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(100, 25);
            this.label48.TabIndex = 8;
            this.label48.Text = "Quantity";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 201);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(124, 25);
            this.label50.TabIndex = 9;
            this.label50.Text = "Item Name";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(11, 111);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(91, 25);
            this.label52.TabIndex = 10;
            this.label52.Text = "Item ID";
            // 
            // label71
            // 
            this.label71.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(2, 30);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(534, 37);
            this.label71.TabIndex = 1;
            this.label71.Text = "MISCELLANEOUS";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblMiscellaneous
            // 
            this.TblMiscellaneous.AllowUserToAddRows = false;
            this.TblMiscellaneous.AllowUserToDeleteRows = false;
            this.TblMiscellaneous.AllowUserToOrderColumns = true;
            this.TblMiscellaneous.AllowUserToResizeRows = false;
            this.TblMiscellaneous.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblMiscellaneous.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblMiscellaneous.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblMiscellaneous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMiscellaneous.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn49,
            this.Column10});
            this.TblMiscellaneous.ContextMenuStrip = this.TblPersonContextMenuStrip;
            this.TblMiscellaneous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMiscellaneous.Location = new System.Drawing.Point(0, 0);
            this.TblMiscellaneous.MultiSelect = false;
            this.TblMiscellaneous.Name = "TblMiscellaneous";
            this.TblMiscellaneous.ReadOnly = true;
            this.TblMiscellaneous.RowHeadersVisible = false;
            this.TblMiscellaneous.RowHeadersWidth = 51;
            this.TblMiscellaneous.RowTemplate.Height = 50;
            this.TblMiscellaneous.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMiscellaneous.Size = new System.Drawing.Size(1314, 803);
            this.TblMiscellaneous.TabIndex = 0;
            this.TblMiscellaneous.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblMiscellaneous_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.HeaderText = "ITEM ID";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn49.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "QUANTITY";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // InventoryLogsTab
            // 
            this.InventoryLogsTab.Controls.Add(this.splitContainer8);
            this.InventoryLogsTab.Location = new System.Drawing.Point(4, 39);
            this.InventoryLogsTab.Name = "InventoryLogsTab";
            this.InventoryLogsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryLogsTab.Size = new System.Drawing.Size(1754, 813);
            this.InventoryLogsTab.TabIndex = 3;
            this.InventoryLogsTab.Text = "   Logs   ";
            this.InventoryLogsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            this.splitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer8.Location = new System.Drawing.Point(3, 3);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.AutoScroll = true;
            this.splitContainer8.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer8.Panel1.Controls.Add(this.comboBox5);
            this.splitContainer8.Panel1.Controls.Add(this.comboBox6);
            this.splitContainer8.Panel1.Controls.Add(this.panel45);
            this.splitContainer8.Panel1.Controls.Add(this.panel46);
            this.splitContainer8.Panel1.Controls.Add(this.numericUpDown2);
            this.splitContainer8.Panel1.Controls.Add(this.comboBox7);
            this.splitContainer8.Panel1.Controls.Add(this.button16);
            this.splitContainer8.Panel1.Controls.Add(this.button17);
            this.splitContainer8.Panel1.Controls.Add(this.button18);
            this.splitContainer8.Panel1.Controls.Add(this.button19);
            this.splitContainer8.Panel1.Controls.Add(this.button20);
            this.splitContainer8.Panel1.Controls.Add(this.panel47);
            this.splitContainer8.Panel1.Controls.Add(this.panel48);
            this.splitContainer8.Panel1.Controls.Add(this.panel49);
            this.splitContainer8.Panel1.Controls.Add(this.panel50);
            this.splitContainer8.Panel1.Controls.Add(this.panel51);
            this.splitContainer8.Panel1.Controls.Add(this.textBox10);
            this.splitContainer8.Panel1.Controls.Add(this.textBox11);
            this.splitContainer8.Panel1.Controls.Add(this.textBox12);
            this.splitContainer8.Panel1.Controls.Add(this.label56);
            this.splitContainer8.Panel1.Controls.Add(this.label57);
            this.splitContainer8.Panel1.Controls.Add(this.label58);
            this.splitContainer8.Panel1.Controls.Add(this.label59);
            this.splitContainer8.Panel1.Controls.Add(this.label60);
            this.splitContainer8.Panel1.Controls.Add(this.label61);
            this.splitContainer8.Panel1.Controls.Add(this.label62);
            this.splitContainer8.Panel1.Controls.Add(this.label63);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.AutoScroll = true;
            this.splitContainer8.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer8.Panel2.Controls.Add(this.dataGridView5);
            this.splitContainer8.Size = new System.Drawing.Size(1748, 807);
            this.splitContainer8.SplitterDistance = 425;
            this.splitContainer8.SplitterWidth = 5;
            this.splitContainer8.TabIndex = 2;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(21, 272);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(515, 33);
            this.comboBox5.TabIndex = 11;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(22, 199);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(515, 33);
            this.comboBox6.TabIndex = 10;
            // 
            // panel45
            // 
            this.panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel45.Location = new System.Drawing.Point(21, 232);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(515, 2);
            this.panel45.TabIndex = 9;
            // 
            // panel46
            // 
            this.panel46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel46.Location = new System.Drawing.Point(20, 305);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(515, 2);
            this.panel46.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(20, 412);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(515, 34);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.ThousandsSeparator = true;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox7
            // 
            this.comboBox7.DisplayMember = "HOUSE_ID";
            this.comboBox7.DropDownHeight = 100;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.IntegralHeight = false;
            this.comboBox7.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.comboBox7.Location = new System.Drawing.Point(20, 484);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(515, 33);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.ValueMember = "HOUSE_ID";
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.Location = new System.Drawing.Point(156, 734);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(244, 41);
            this.button16.TabIndex = 4;
            this.button16.Text = "RESET";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.Location = new System.Drawing.Point(290, 675);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(247, 41);
            this.button17.TabIndex = 4;
            this.button17.Text = "SEARCH";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(290, 616);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(247, 41);
            this.button18.TabIndex = 4;
            this.button18.Text = "UPDATE";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.Location = new System.Drawing.Point(19, 675);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(244, 41);
            this.button19.TabIndex = 4;
            this.button19.Text = "DELETE";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(19, 616);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(244, 41);
            this.button20.TabIndex = 4;
            this.button20.Text = "INSERT";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // panel47
            // 
            this.panel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel47.Location = new System.Drawing.Point(20, 518);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(515, 2);
            this.panel47.TabIndex = 3;
            // 
            // panel48
            // 
            this.panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel48.Location = new System.Drawing.Point(20, 447);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(515, 2);
            this.panel48.TabIndex = 3;
            // 
            // panel49
            // 
            this.panel49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel49.Location = new System.Drawing.Point(20, 589);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(515, 2);
            this.panel49.TabIndex = 3;
            // 
            // panel50
            // 
            this.panel50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel50.Location = new System.Drawing.Point(20, 376);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(515, 2);
            this.panel50.TabIndex = 3;
            // 
            // panel51
            // 
            this.panel51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel51.Location = new System.Drawing.Point(20, 158);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(515, 2);
            this.panel51.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox10.HideSelection = false;
            this.textBox10.Location = new System.Drawing.Point(20, 560);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(515, 27);
            this.textBox10.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox11.HideSelection = false;
            this.textBox11.Location = new System.Drawing.Point(20, 347);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(515, 27);
            this.textBox11.TabIndex = 0;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox12.HideSelection = false;
            this.textBox12.Location = new System.Drawing.Point(20, 129);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(516, 27);
            this.textBox12.TabIndex = 0;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(15, 458);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(88, 25);
            this.label56.TabIndex = 2;
            this.label56.Text = "Gender";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(15, 384);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(51, 25);
            this.label57.TabIndex = 2;
            this.label57.Text = "Age";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(15, 531);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(165, 25);
            this.label58.TabIndex = 2;
            this.label58.Text = "Phone Number";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(15, 318);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 25);
            this.label59.TabIndex = 2;
            this.label59.Text = "Name";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(15, 170);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(77, 25);
            this.label60.TabIndex = 2;
            this.label60.Text = "Village";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(15, 243);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(107, 25);
            this.label61.TabIndex = 2;
            this.label61.Text = "House ID";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(11, 98);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(114, 25);
            this.label62.TabIndex = 2;
            this.label62.Text = "Person ID";
            // 
            // label63
            // 
            this.label63.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(2, 30);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(534, 37);
            this.label63.TabIndex = 1;
            this.label63.Text = "PERSON DETAILS";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToOrderColumns = true;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45});
            this.dataGridView5.ContextMenuStrip = this.TblPersonContextMenuStrip;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 50;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1314, 803);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.HeaderText = "PERSON ID";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.HeaderText = "AGE";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.HeaderText = "GENDER";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.HeaderText = "PHONE NO.";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel.Controls.Add(this.BtnExit);
            this.UpperPanel.Controls.Add(this.LblTime);
            this.UpperPanel.Controls.Add(this.LblDate);
            this.UpperPanel.Controls.Add(this.label1);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1770, 150);
            this.UpperPanel.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1576, 89);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(167, 44);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(248, 96);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(90, 25);
            this.LblTime.TabIndex = 2;
            this.LblTime.Text = "Time :- ";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(8, 96);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(88, 25);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "Date :- ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1393, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "E HEALTH-CARE PORTAL";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.IsSplitterFixed = true;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.UpperPanel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.AutoScroll = true;
            this.SplitContainer.Panel2.Controls.Add(this.LowerPanel);
            this.SplitContainer.Size = new System.Drawing.Size(1770, 1055);
            this.SplitContainer.SplitterDistance = 150;
            this.SplitContainer.SplitterWidth = 1;
            this.SplitContainer.TabIndex = 1;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTImer_Tick);
            // 
            // OuterImageList
            // 
            this.OuterImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OuterImageList.ImageStream")));
            this.OuterImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.OuterImageList.Images.SetKeyName(0, "icons8-home-page-48.png");
            this.OuterImageList.Images.SetKeyName(1, "icons8-clinic-50.png");
            this.OuterImageList.Images.SetKeyName(2, "icons8-database-50.png");
            this.OuterImageList.Images.SetKeyName(3, "icons8-warehouse-50.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TblMedicinesContextMenuStrip
            // 
            this.TblMedicinesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblMedicinesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblMedicinesPrintAsPDF,
            this.TblMedicinesPrintAsExcel});
            this.TblMedicinesContextMenuStrip.Name = "contextMenuStrip1";
            this.TblMedicinesContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TblMedicinesContextMenuStrip.ShowImageMargin = false;
            this.TblMedicinesContextMenuStrip.Size = new System.Drawing.Size(140, 52);
            // 
            // TblMedicinesPrintAsPDF
            // 
            this.TblMedicinesPrintAsPDF.Name = "TblMedicinesPrintAsPDF";
            this.TblMedicinesPrintAsPDF.Size = new System.Drawing.Size(139, 24);
            this.TblMedicinesPrintAsPDF.Text = "Print as PDF";
            this.TblMedicinesPrintAsPDF.Click += new System.EventHandler(this.TblMedicinesPrintAsPDF_Click);
            // 
            // TblMedicinesPrintAsExcel
            // 
            this.TblMedicinesPrintAsExcel.Name = "TblMedicinesPrintAsExcel";
            this.TblMedicinesPrintAsExcel.Size = new System.Drawing.Size(139, 24);
            this.TblMedicinesPrintAsExcel.Text = "Print as Excel";
            this.TblMedicinesPrintAsExcel.Click += new System.EventHandler(this.TblMedicinesPrintAsExcel_Click);
            // 
            // TblDisposablesContextMenuStrip
            // 
            this.TblDisposablesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblDisposablesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblDisposablesPrintAsPDF,
            this.TblDisposablesPrintAsExcel});
            this.TblDisposablesContextMenuStrip.Name = "TblVillageContextMenuStrip";
            this.TblDisposablesContextMenuStrip.Size = new System.Drawing.Size(165, 52);
            // 
            // TblDisposablesPrintAsPDF
            // 
            this.TblDisposablesPrintAsPDF.Name = "TblDisposablesPrintAsPDF";
            this.TblDisposablesPrintAsPDF.Size = new System.Drawing.Size(164, 24);
            this.TblDisposablesPrintAsPDF.Text = "Print as PDF";
            this.TblDisposablesPrintAsPDF.Click += new System.EventHandler(this.TblDisposablesPrintAsPDF_Click);
            // 
            // TblDisposablesPrintAsExcel
            // 
            this.TblDisposablesPrintAsExcel.Name = "TblDisposablesPrintAsExcel";
            this.TblDisposablesPrintAsExcel.Size = new System.Drawing.Size(164, 24);
            this.TblDisposablesPrintAsExcel.Text = "Print as Excel";
            this.TblDisposablesPrintAsExcel.Click += new System.EventHandler(this.TblDisposablesPrintAsExcel_Click);
            // 
            // TblStationaryContextMenuStrip
            // 
            this.TblStationaryContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblStationaryContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblStationaryPrintAsPDF,
            this.TblStationaryPrintAsExcel});
            this.TblStationaryContextMenuStrip.Name = "TblHouseContextMenuStrip";
            this.TblStationaryContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TblStationaryContextMenuStrip.ShowImageMargin = false;
            this.TblStationaryContextMenuStrip.Size = new System.Drawing.Size(142, 52);
            // 
            // TblStationaryPrintAsPDF
            // 
            this.TblStationaryPrintAsPDF.Name = "TblStationaryPrintAsPDF";
            this.TblStationaryPrintAsPDF.Size = new System.Drawing.Size(141, 24);
            this.TblStationaryPrintAsPDF.Text = "Print as PDF";
            this.TblStationaryPrintAsPDF.Click += new System.EventHandler(this.TblStationaryPrintAsPDF_Click);
            // 
            // TblStationaryPrintAsExcel
            // 
            this.TblStationaryPrintAsExcel.Name = "TblStationaryPrintAsExcel";
            this.TblStationaryPrintAsExcel.Size = new System.Drawing.Size(141, 24);
            this.TblStationaryPrintAsExcel.Text = "Print As Excel";
            this.TblStationaryPrintAsExcel.Click += new System.EventHandler(this.TblStationaryPrintAsExcel_Click);
            // 
            // TblMiscellaneousContextMenuStrip
            // 
            this.TblMiscellaneousContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblMiscellaneousContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TblMiscellaneousPrintAsPDF,
            this.TblMiscellaneousPrintAsExcel});
            this.TblMiscellaneousContextMenuStrip.Name = "contextMenuStrip1";
            this.TblMiscellaneousContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TblMiscellaneousContextMenuStrip.ShowImageMargin = false;
            this.TblMiscellaneousContextMenuStrip.Size = new System.Drawing.Size(140, 52);
            // 
            // TblMiscellaneousPrintAsPDF
            // 
            this.TblMiscellaneousPrintAsPDF.Name = "TblMiscellaneousPrintAsPDF";
            this.TblMiscellaneousPrintAsPDF.Size = new System.Drawing.Size(139, 24);
            this.TblMiscellaneousPrintAsPDF.Text = "Print as PDF";
            this.TblMiscellaneousPrintAsPDF.Click += new System.EventHandler(this.TblMiscellaneousPrintAsPDF_Click);
            // 
            // TblMiscellaneousPrintAsExcel
            // 
            this.TblMiscellaneousPrintAsExcel.Name = "TblMiscellaneousPrintAsExcel";
            this.TblMiscellaneousPrintAsExcel.Size = new System.Drawing.Size(139, 24);
            this.TblMiscellaneousPrintAsExcel.Text = "Print as Excel";
            this.TblMiscellaneousPrintAsExcel.Click += new System.EventHandler(this.TblMiscellaneousPrintAsExcel_Click);
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "MEDICINE ID";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "MEDICINE NAME";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1055);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.LowerPanel.ResumeLayout(false);
            this.OuterTabControl.ResumeLayout(false);
            this.OPDTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DBTab.ResumeLayout(false);
            this.InnerTabControl.ResumeLayout(false);
            this.VillagesTab.ResumeLayout(false);
            this.VillagesSplitContainer.Panel1.ResumeLayout(false);
            this.VillagesSplitContainer.Panel1.PerformLayout();
            this.VillagesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VillagesSplitContainer)).EndInit();
            this.VillagesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblVillage)).EndInit();
            this.TblVillageContextMenuStrip.ResumeLayout(false);
            this.HousesTab.ResumeLayout(false);
            this.HousesSplitContainer.Panel1.ResumeLayout(false);
            this.HousesSplitContainer.Panel1.PerformLayout();
            this.HousesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HousesSplitContainer)).EndInit();
            this.HousesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblHouse)).EndInit();
            this.TblHouseContextMenuStrip.ResumeLayout(false);
            this.PeopleTab.ResumeLayout(false);
            this.PeopleSplitContainer.Panel1.ResumeLayout(false);
            this.PeopleSplitContainer.Panel1.PerformLayout();
            this.PeopleSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleSplitContainer)).EndInit();
            this.PeopleSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPerson)).EndInit();
            this.TblPersonContextMenuStrip.ResumeLayout(false);
            this.LogsTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblVillageLogs)).EndInit();
            this.TblVillageLogsContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblHouseLogs)).EndInit();
            this.TblHouseLogsContextMenuStrip.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblPersonLogs)).EndInit();
            this.TblPersonLogsContextMenuStrip.ResumeLayout(false);
            this.InventoryTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.MedicinesTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMedicineQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMedicines)).EndInit();
            this.DisposablesTab.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisposableQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblDisposables)).EndInit();
            this.StationaryTab.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtStationaryQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblStationary)).EndInit();
            this.MiscellaneousTab.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiscellaneousQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMiscellaneous)).EndInit();
            this.InventoryLogsTab.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.TblMedicinesContextMenuStrip.ResumeLayout(false);
            this.TblDisposablesContextMenuStrip.ResumeLayout(false);
            this.TblStationaryContextMenuStrip.ResumeLayout(false);
            this.TblMiscellaneousContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.TabControl OuterTabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage OPDTab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_newrecord;
        private System.Windows.Forms.Button btn_archieve;
        private System.Windows.Forms.TextBox txt_personname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_personid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_visitid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISIT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.ContextMenuStrip TblVillageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblVillagePrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblVillagePrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblHouseContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblHousePrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblHousePrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblPersonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblPersonPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblPersonPrintAsExcel;
        private System.Windows.Forms.ImageList InnerImageList;
        private System.Windows.Forms.ImageList OuterImageList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.TabPage DBTab;
        private System.Windows.Forms.TabControl InnerTabControl;
        private System.Windows.Forms.TabPage VillagesTab;
        private System.Windows.Forms.SplitContainer VillagesSplitContainer;
        private System.Windows.Forms.Button BtnVillageReset;
        private System.Windows.Forms.Button BtnVillageSearch;
        private System.Windows.Forms.Button BtnVillageUpdate;
        private System.Windows.Forms.Button BtnVillageDelete;
        private System.Windows.Forms.Button BtnVillageInsert;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtVillageNoOfHouses;
        private System.Windows.Forms.TextBox TxtVillageCode;
        private System.Windows.Forms.TextBox TxtVillageName;
        private System.Windows.Forms.TextBox TxtVillageId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView TblVillage;
        private System.Windows.Forms.DataGridViewTextBoxColumn VillageIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage HousesTab;
        private System.Windows.Forms.SplitContainer HousesSplitContainer;
        private System.Windows.Forms.ComboBox TxtHouseVillageName;
        private System.Windows.Forms.Button BtnHouseReset;
        private System.Windows.Forms.Button BtnHouseSearch;
        private System.Windows.Forms.Button BtnHouseUpdate;
        private System.Windows.Forms.Button BtnHouseDelete;
        private System.Windows.Forms.Button BtnHouseInsert;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TxtHouseNoOfPeople;
        private System.Windows.Forms.TextBox TxtHouseId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView TblHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.SplitContainer PeopleSplitContainer;
        private System.Windows.Forms.ComboBox TxtPersonHouseId;
        private System.Windows.Forms.ComboBox TxtPersonVillageName;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown TxtPersonAge;
        private System.Windows.Forms.ComboBox TxtPersonGender;
        private System.Windows.Forms.Button BtnPersonReset;
        private System.Windows.Forms.Button BtnPersonSearch;
        private System.Windows.Forms.Button BtnPersonUpdate;
        private System.Windows.Forms.Button BtnPersonDelete;
        private System.Windows.Forms.Button BtnPersonInsert;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox TxtPersonPhoneNo;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.TextBox TxtPersonId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView TblPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabPage LogsTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BtnVillageLogsReset;
        private System.Windows.Forms.Button BtnVillageLogsSearch;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox TxtVillageLogsNoOfHouses;
        private System.Windows.Forms.TextBox TxtVillageLogsVillageCode;
        private System.Windows.Forms.TextBox TxtVillageLogsVillageName;
        private System.Windows.Forms.TextBox TxtVillageLogsVillageId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView TblVillageLogs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BtnHouseLogsReset;
        private System.Windows.Forms.Button BtnHouseLogsSearch;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox TxtHouseLogsNoOfPeople;
        private System.Windows.Forms.TextBox TxtHouseLogsHouseId;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView TblHouseLogs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button BtnPersonLogsReset;
        private System.Windows.Forms.Button BtnPersonLogsSearch;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.TextBox TxtPersonLogsPhoneNo;
        private System.Windows.Forms.TextBox TxtPersonLogsName;
        private System.Windows.Forms.TextBox TxtPersonLogsPersonId;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView TblPersonLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.ContextMenuStrip TblVillageLogsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblVillageLogsPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblVillageLogsPrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblHouseLogsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblHouseLogsPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblHouseLogsPrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblPersonLogsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblPersonLogsPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblPersonLogsPrintAsExcel;
        private System.Windows.Forms.TextBox TxtHouseLogsVillageName;
        private System.Windows.Forms.TextBox TxtPersonLogsVillageName;
        private System.Windows.Forms.TextBox TxtPersonLogsHouseId;
        private System.Windows.Forms.TextBox TxtPersonLogsAge;
        private System.Windows.Forms.TextBox TxtPersonLogsGender;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage MedicinesTab;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button BtnMedicineReset;
        private System.Windows.Forms.Button BtnMedicineSearcch;
        private System.Windows.Forms.Button BtnMedicineUpdate;
        private System.Windows.Forms.Button BtnMedicineDelete;
        private System.Windows.Forms.Button BtnMedicineInsert;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.TextBox TxtMedicineName;
        private System.Windows.Forms.TextBox TxtMedicineId;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataGridView TblMedicines;
        private System.Windows.Forms.TabPage DisposablesTab;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button BtnDisposableReset;
        private System.Windows.Forms.Button BtnDisposableSearch;
        private System.Windows.Forms.Button BtnDisposableUpdate;
        private System.Windows.Forms.Button BtnDisposableDelete;
        private System.Windows.Forms.Button BtnDisposableInsert;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.TextBox TxtDisposableId;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DataGridView TblDisposables;
        private System.Windows.Forms.TabPage StationaryTab;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.DataGridView TblStationary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.TabPage MiscellaneousTab;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.DataGridView TblMiscellaneous;
        private System.Windows.Forms.TabPage InventoryLogsTab;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.Button BtnStstionaryReset;
        private System.Windows.Forms.Button BtnStstionarySearch;
        private System.Windows.Forms.Button BtnStstionaryUpdate;
        private System.Windows.Forms.Button BtnStstionaryDelete;
        private System.Windows.Forms.Button BtnStstionaryInsert;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.TextBox TxtStationaryId;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button BtnMiscellaneousReset;
        private System.Windows.Forms.Button BtnMiscellaneousSearch;
        private System.Windows.Forms.Button BtnMiscellaneousUpdate;
        private System.Windows.Forms.Button BtnMiscellaneousDelete;
        private System.Windows.Forms.Button BtnMiscellaneousInsert;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.TextBox TxtMiscellaneousId;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown TxtMedicineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.NumericUpDown TxtDisposableQuantity;
        private System.Windows.Forms.TextBox TxtDisposableName;
        private System.Windows.Forms.NumericUpDown TxtStationaryQuantity;
        private System.Windows.Forms.NumericUpDown TxtMiscellaneousQuantity;
        private System.Windows.Forms.TextBox TxtMiscellaneousName;
        private System.Windows.Forms.TextBox TxtStationaryName;
        private System.Windows.Forms.ContextMenuStrip TblMedicinesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblMedicinesPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblMedicinesPrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblDisposablesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblDisposablesPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblDisposablesPrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblStationaryContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblStationaryPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblStationaryPrintAsExcel;
        private System.Windows.Forms.ContextMenuStrip TblMiscellaneousContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TblMiscellaneousPrintAsPDF;
        private System.Windows.Forms.ToolStripMenuItem TblMiscellaneousPrintAsExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    }
}