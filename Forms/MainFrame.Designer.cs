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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InnerImageList = new System.Windows.Forms.ImageList(this.components);
            this.InventoryTab = new System.Windows.Forms.TabPage();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
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
            this.HousesSplitContainer.SplitterDistance = 425;
            this.HousesSplitContainer.SplitterWidth = 5;
            this.HousesSplitContainer.TabIndex = 1;
            // 
            // TxtHouseVillageName
            // 
            this.TxtHouseVillageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHouseVillageName.FormattingEnabled = true;
            this.TxtHouseVillageName.Location = new System.Drawing.Point(16, 227);
            this.TxtHouseVillageName.Name = "TxtHouseVillageName";
            this.TxtHouseVillageName.Size = new System.Drawing.Size(240, 33);
            this.TxtHouseVillageName.TabIndex = 5;
            // 
            // BtnHouseReset
            // 
            this.BtnHouseReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnHouseReset.AutoSize = true;
            this.BtnHouseReset.Location = new System.Drawing.Point(16, 546);
            this.BtnHouseReset.Name = "BtnHouseReset";
            this.BtnHouseReset.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseReset.TabIndex = 4;
            this.BtnHouseReset.Text = "RESET";
            this.BtnHouseReset.UseVisualStyleBackColor = true;
            this.BtnHouseReset.Click += new System.EventHandler(this.BtnHouseReset_Click);
            // 
            // BtnHouseSearch
            // 
            this.BtnHouseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHouseSearch.AutoSize = true;
            this.BtnHouseSearch.Location = new System.Drawing.Point(16, 476);
            this.BtnHouseSearch.Name = "BtnHouseSearch";
            this.BtnHouseSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnHouseSearch.TabIndex = 4;
            this.BtnHouseSearch.Text = "SEARCH";
            this.BtnHouseSearch.UseVisualStyleBackColor = true;
            this.BtnHouseSearch.Click += new System.EventHandler(this.BtnHouseSearch_Click);
            // 
            // BtnHouseUpdate
            // 
            this.BtnHouseUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHouseUpdate.AutoSize = true;
            this.BtnHouseUpdate.Location = new System.Drawing.Point(16, 400);
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
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(16, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 2);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(16, 260);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 2);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(16, 176);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(240, 2);
            this.panel9.TabIndex = 3;
            // 
            // TxtHouseNoOfPeople
            // 
            this.TxtHouseNoOfPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHouseNoOfPeople.BackColor = System.Drawing.Color.White;
            this.TxtHouseNoOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseNoOfPeople.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseNoOfPeople.HideSelection = false;
            this.TxtHouseNoOfPeople.Location = new System.Drawing.Point(16, 316);
            this.TxtHouseNoOfPeople.Name = "TxtHouseNoOfPeople";
            this.TxtHouseNoOfPeople.ReadOnly = true;
            this.TxtHouseNoOfPeople.Size = new System.Drawing.Size(240, 27);
            this.TxtHouseNoOfPeople.TabIndex = 0;
            // 
            // TxtHouseId
            // 
            this.TxtHouseId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHouseId.BackColor = System.Drawing.Color.White;
            this.TxtHouseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHouseId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHouseId.HideSelection = false;
            this.TxtHouseId.Location = new System.Drawing.Point(16, 147);
            this.TxtHouseId.Name = "TxtHouseId";
            this.TxtHouseId.Size = new System.Drawing.Size(240, 27);
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
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 37);
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
            this.TblHouse.RowHeadersWidth = 51;
            this.TblHouse.RowTemplate.Height = 50;
            this.TblHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblHouse.Size = new System.Drawing.Size(1308, 799);
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
            this.TxtPersonHouseId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonHouseId.FormattingEnabled = true;
            this.TxtPersonHouseId.Location = new System.Drawing.Point(21, 272);
            this.TxtPersonHouseId.Name = "TxtPersonHouseId";
            this.TxtPersonHouseId.Size = new System.Drawing.Size(239, 33);
            this.TxtPersonHouseId.TabIndex = 11;
            // 
            // TxtPersonVillageName
            // 
            this.TxtPersonVillageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonVillageName.FormattingEnabled = true;
            this.TxtPersonVillageName.Location = new System.Drawing.Point(22, 198);
            this.TxtPersonVillageName.Name = "TxtPersonVillageName";
            this.TxtPersonVillageName.Size = new System.Drawing.Size(239, 33);
            this.TxtPersonVillageName.TabIndex = 10;
            this.TxtPersonVillageName.SelectedIndexChanged += new System.EventHandler(this.TxtPersonVillageName_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(21, 232);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 2);
            this.panel13.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(20, 305);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(240, 2);
            this.panel11.TabIndex = 7;
            // 
            // TxtPersonAge
            // 
            this.TxtPersonAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonAge.Location = new System.Drawing.Point(20, 412);
            this.TxtPersonAge.Name = "TxtPersonAge";
            this.TxtPersonAge.Size = new System.Drawing.Size(240, 34);
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
            this.TxtPersonGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TxtPersonGender.Size = new System.Drawing.Size(240, 33);
            this.TxtPersonGender.TabIndex = 5;
            this.TxtPersonGender.ValueMember = "HOUSE_ID";
            // 
            // BtnPersonReset
            // 
            this.BtnPersonReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPersonReset.AutoSize = true;
            this.BtnPersonReset.Location = new System.Drawing.Point(21, 730);
            this.BtnPersonReset.Name = "BtnPersonReset";
            this.BtnPersonReset.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonReset.TabIndex = 4;
            this.BtnPersonReset.Text = "RESET";
            this.BtnPersonReset.UseVisualStyleBackColor = true;
            this.BtnPersonReset.Click += new System.EventHandler(this.BtnPersonReset_Click);
            // 
            // BtnPersonSearch
            // 
            this.BtnPersonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonSearch.AutoSize = true;
            this.BtnPersonSearch.Location = new System.Drawing.Point(22, 675);
            this.BtnPersonSearch.Name = "BtnPersonSearch";
            this.BtnPersonSearch.Size = new System.Drawing.Size(244, 41);
            this.BtnPersonSearch.TabIndex = 4;
            this.BtnPersonSearch.Text = "SEARCH";
            this.BtnPersonSearch.UseVisualStyleBackColor = true;
            this.BtnPersonSearch.Click += new System.EventHandler(this.BtnPersonSearch_Click);
            // 
            // BtnPersonUpdate
            // 
            this.BtnPersonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonUpdate.AutoSize = true;
            this.BtnPersonUpdate.Location = new System.Drawing.Point(22, 616);
            this.BtnPersonUpdate.Name = "BtnPersonUpdate";
            this.BtnPersonUpdate.Size = new System.Drawing.Size(244, 41);
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
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(20, 518);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 2);
            this.panel10.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(20, 447);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(240, 2);
            this.panel12.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(20, 589);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(240, 2);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(20, 376);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(240, 2);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(20, 158);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(240, 2);
            this.panel16.TabIndex = 3;
            // 
            // TxtPersonPhoneNo
            // 
            this.TxtPersonPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonPhoneNo.BackColor = System.Drawing.Color.White;
            this.TxtPersonPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonPhoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonPhoneNo.HideSelection = false;
            this.TxtPersonPhoneNo.Location = new System.Drawing.Point(20, 560);
            this.TxtPersonPhoneNo.Name = "TxtPersonPhoneNo";
            this.TxtPersonPhoneNo.Size = new System.Drawing.Size(240, 27);
            this.TxtPersonPhoneNo.TabIndex = 0;
            this.TxtPersonPhoneNo.TextChanged += new System.EventHandler(this.TxtPersonPhoneNo_TextChanged);
            // 
            // TxtPersonName
            // 
            this.TxtPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonName.BackColor = System.Drawing.Color.White;
            this.TxtPersonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonName.HideSelection = false;
            this.TxtPersonName.Location = new System.Drawing.Point(20, 347);
            this.TxtPersonName.Name = "TxtPersonName";
            this.TxtPersonName.Size = new System.Drawing.Size(240, 27);
            this.TxtPersonName.TabIndex = 0;
            this.TxtPersonName.TextChanged += new System.EventHandler(this.TxtPersonName_TextChanged);
            // 
            // TxtPersonId
            // 
            this.TxtPersonId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersonId.BackColor = System.Drawing.Color.White;
            this.TxtPersonId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPersonId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonId.HideSelection = false;
            this.TxtPersonId.Location = new System.Drawing.Point(20, 129);
            this.TxtPersonId.Name = "TxtPersonId";
            this.TxtPersonId.Size = new System.Drawing.Size(240, 27);
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
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(304, 37);
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
            this.LogsTab.Text = "Logs";
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
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.button5);
            this.splitContainer2.Panel1.Controls.Add(this.panel17);
            this.splitContainer2.Panel1.Controls.Add(this.panel18);
            this.splitContainer2.Panel1.Controls.Add(this.panel19);
            this.splitContainer2.Panel1.Controls.Add(this.panel20);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label22);
            this.splitContainer2.Panel1.Controls.Add(this.label23);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            this.splitContainer2.Panel1.Controls.Add(this.label26);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer2.SplitterDistance = 425;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(16, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(16, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(16, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "UPDATE";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(16, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(16, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "INSERT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Location = new System.Drawing.Point(16, 426);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(240, 2);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Location = new System.Drawing.Point(16, 343);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(240, 2);
            this.panel18.TabIndex = 3;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Location = new System.Drawing.Point(16, 260);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(240, 2);
            this.panel19.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Location = new System.Drawing.Point(16, 176);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(240, 2);
            this.panel20.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(16, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(16, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 27);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(16, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 27);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.HideSelection = false;
            this.textBox4.Location = new System.Drawing.Point(16, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 27);
            this.textBox4.TabIndex = 0;
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
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(2, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(321, 37);
            this.label26.TabIndex = 1;
            this.label26.Text = "VILLAGE DETAILS";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView2.ContextMenuStrip = this.TblVillageContextMenuStrip;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.DividerHeight = 2;
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1294, 750);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "VILLAGE ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "VILLAGE NAME";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "VILLAGE CODE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "NO. OF HOUSES";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
            this.tabPage2.Text = "   House Logs  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer3.Panel1.Controls.Add(this.button6);
            this.splitContainer3.Panel1.Controls.Add(this.button7);
            this.splitContainer3.Panel1.Controls.Add(this.button8);
            this.splitContainer3.Panel1.Controls.Add(this.button9);
            this.splitContainer3.Panel1.Controls.Add(this.button10);
            this.splitContainer3.Panel1.Controls.Add(this.panel21);
            this.splitContainer3.Panel1.Controls.Add(this.panel22);
            this.splitContainer3.Panel1.Controls.Add(this.panel23);
            this.splitContainer3.Panel1.Controls.Add(this.textBox5);
            this.splitContainer3.Panel1.Controls.Add(this.textBox6);
            this.splitContainer3.Panel1.Controls.Add(this.label27);
            this.splitContainer3.Panel1.Controls.Add(this.label28);
            this.splitContainer3.Panel1.Controls.Add(this.label29);
            this.splitContainer3.Panel1.Controls.Add(this.label30);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer3.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer3.SplitterDistance = 425;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(16, 546);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(244, 41);
            this.button6.TabIndex = 4;
            this.button6.Text = "RESET";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(16, 476);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 41);
            this.button7.TabIndex = 4;
            this.button7.Text = "SEARCH";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(16, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(244, 41);
            this.button8.TabIndex = 4;
            this.button8.Text = "UPDATE";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(16, 476);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(244, 41);
            this.button9.TabIndex = 4;
            this.button9.Text = "DELETE";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(16, 400);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(244, 41);
            this.button10.TabIndex = 4;
            this.button10.Text = "INSERT";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Location = new System.Drawing.Point(16, 345);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(240, 2);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Location = new System.Drawing.Point(16, 260);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(240, 2);
            this.panel22.TabIndex = 3;
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Location = new System.Drawing.Point(16, 176);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(240, 2);
            this.panel23.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.HideSelection = false;
            this.textBox5.Location = new System.Drawing.Point(16, 316);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(240, 27);
            this.textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point(16, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(240, 27);
            this.textBox6.TabIndex = 0;
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
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(2, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(284, 37);
            this.label30.TabIndex = 1;
            this.label30.Text = "HOUSE DETAILS";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView3.ContextMenuStrip = this.TblHouseContextMenuStrip;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 50;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1294, 750);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "NO. OF PEOPLE";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
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
            this.tabPage3.Text = "   People Logs";
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
            this.splitContainer4.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer4.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer4.Panel1.Controls.Add(this.panel24);
            this.splitContainer4.Panel1.Controls.Add(this.panel25);
            this.splitContainer4.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer4.Panel1.Controls.Add(this.comboBox4);
            this.splitContainer4.Panel1.Controls.Add(this.button11);
            this.splitContainer4.Panel1.Controls.Add(this.button12);
            this.splitContainer4.Panel1.Controls.Add(this.button13);
            this.splitContainer4.Panel1.Controls.Add(this.button14);
            this.splitContainer4.Panel1.Controls.Add(this.button15);
            this.splitContainer4.Panel1.Controls.Add(this.panel26);
            this.splitContainer4.Panel1.Controls.Add(this.panel27);
            this.splitContainer4.Panel1.Controls.Add(this.panel28);
            this.splitContainer4.Panel1.Controls.Add(this.panel29);
            this.splitContainer4.Panel1.Controls.Add(this.panel30);
            this.splitContainer4.Panel1.Controls.Add(this.textBox7);
            this.splitContainer4.Panel1.Controls.Add(this.textBox8);
            this.splitContainer4.Panel1.Controls.Add(this.textBox9);
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
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer4.Size = new System.Drawing.Size(1728, 754);
            this.splitContainer4.SplitterDistance = 425;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(22, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 33);
            this.comboBox3.TabIndex = 10;
            // 
            // panel24
            // 
            this.panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Location = new System.Drawing.Point(21, 232);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(177, 2);
            this.panel24.TabIndex = 9;
            // 
            // panel25
            // 
            this.panel25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Location = new System.Drawing.Point(20, 305);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(177, 2);
            this.panel25.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(20, 412);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 34);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.DisplayMember = "HOUSE_ID";
            this.comboBox4.DropDownHeight = 100;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.comboBox4.Location = new System.Drawing.Point(20, 484);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(177, 33);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "HOUSE_ID";
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(-9, 730);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(244, 41);
            this.button11.TabIndex = 4;
            this.button11.Text = "RESET";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(-41, 675);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(244, 41);
            this.button12.TabIndex = 4;
            this.button12.Text = "SEARCH";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(-41, 616);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(244, 41);
            this.button13.TabIndex = 4;
            this.button13.Text = "UPDATE";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(19, 675);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(244, 41);
            this.button14.TabIndex = 4;
            this.button14.Text = "DELETE";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Location = new System.Drawing.Point(19, 616);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(244, 41);
            this.button15.TabIndex = 4;
            this.button15.Text = "INSERT";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // panel26
            // 
            this.panel26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Location = new System.Drawing.Point(20, 518);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(177, 2);
            this.panel26.TabIndex = 3;
            // 
            // panel27
            // 
            this.panel27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Location = new System.Drawing.Point(20, 447);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(177, 2);
            this.panel27.TabIndex = 3;
            // 
            // panel28
            // 
            this.panel28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Location = new System.Drawing.Point(20, 589);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(177, 2);
            this.panel28.TabIndex = 3;
            // 
            // panel29
            // 
            this.panel29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Location = new System.Drawing.Point(20, 376);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(177, 2);
            this.panel29.TabIndex = 3;
            // 
            // panel30
            // 
            this.panel30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Location = new System.Drawing.Point(20, 158);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(177, 2);
            this.panel30.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox7.HideSelection = false;
            this.textBox7.Location = new System.Drawing.Point(20, 560);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(177, 27);
            this.textBox7.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox8.HideSelection = false;
            this.textBox8.Location = new System.Drawing.Point(20, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(177, 27);
            this.textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox9.HideSelection = false;
            this.textBox9.Location = new System.Drawing.Point(20, 129);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(177, 27);
            this.textBox9.TabIndex = 0;
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
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(2, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(241, 37);
            this.label38.TabIndex = 1;
            this.label38.Text = "PERSON DETAILS";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dataGridView4.ContextMenuStrip = this.TblPersonContextMenuStrip;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 50;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1294, 750);
            this.dataGridView4.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "PERSON ID";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "HOUSE ID";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "VILLAGE";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "AGE";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "GENDER";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "PHONE NO.";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
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
            this.InventoryTab.ImageKey = "icons8-warehouse-50.png";
            this.InventoryTab.Location = new System.Drawing.Point(4, 44);
            this.InventoryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(1762, 856);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "   Inventory   ";
            this.InventoryTab.UseVisualStyleBackColor = true;
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
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1055);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainFrame";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}