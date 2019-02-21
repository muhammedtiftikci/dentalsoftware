namespace DentalSoftware
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ddbPatient = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindPatient = new System.Windows.Forms.ToolStripButton();
            this.separatorAppointment = new System.Windows.Forms.ToolStripSeparator();
            this.btnGoTo = new System.Windows.Forms.ToolStripSplitButton();
            this.btnGoToToday = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoToNextDay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoToPreviousDay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaint = new System.Windows.Forms.ToolStripSplitButton();
            this.btnFastPaint1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFastPaint2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFastPaint3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFastPaint4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFastPaint5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRenkTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_TELEPHONE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_BOOK_PAGE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_CREATED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_MODIFIED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPATIENT_BALANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeeth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.clmNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPHONE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbPatient,
            this.btnFindPatient,
            this.separatorAppointment,
            this.btnGoTo,
            this.btnPaint,
            this.toolStripSeparator2,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ddbPatient
            // 
            this.ddbPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ddbPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPatient,
            this.btnEditPatient,
            this.btnDeletePatient});
            this.ddbPatient.Image = ((System.Drawing.Image)(resources.GetObject("ddbPatient.Image")));
            this.ddbPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbPatient.Name = "ddbPatient";
            this.ddbPatient.Size = new System.Drawing.Size(34, 24);
            this.ddbPatient.Text = "Hasta İşlemleri";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(180, 26);
            this.btnAddPatient.Text = "Hasta Ekle";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(180, 26);
            this.btnEditPatient.Text = "Hasta Düzenle";
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(180, 26);
            this.btnDeletePatient.Text = "Hasta Sil";
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFindPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPatient.Image")));
            this.btnFindPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(24, 24);
            this.btnFindPatient.Text = "Hasta Ara";
            this.btnFindPatient.ToolTipText = "Hasta Ara (Ctrl + F)";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // separatorAppointment
            // 
            this.separatorAppointment.Name = "separatorAppointment";
            this.separatorAppointment.Size = new System.Drawing.Size(6, 27);
            // 
            // btnGoTo
            // 
            this.btnGoTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoToToday,
            this.btnGoToNextDay,
            this.btnGoToPreviousDay});
            this.btnGoTo.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTo.Image")));
            this.btnGoTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(39, 24);
            this.btnGoTo.Text = "Git";
            this.btnGoTo.ToolTipText = "Git (Ctrl + T)";
            this.btnGoTo.ButtonClick += new System.EventHandler(this.btnGoTo_ButtonClick);
            // 
            // btnGoToToday
            // 
            this.btnGoToToday.Name = "btnGoToToday";
            this.btnGoToToday.ShortcutKeyDisplayString = "";
            this.btnGoToToday.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.btnGoToToday.Size = new System.Drawing.Size(216, 26);
            this.btnGoToToday.Text = "Bugün";
            this.btnGoToToday.Click += new System.EventHandler(this.btnGoToToday_Click);
            // 
            // btnGoToNextDay
            // 
            this.btnGoToNextDay.Name = "btnGoToNextDay";
            this.btnGoToNextDay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnGoToNextDay.Size = new System.Drawing.Size(216, 26);
            this.btnGoToNextDay.Text = "Sonraki Gün";
            this.btnGoToNextDay.Click += new System.EventHandler(this.btnGoToNextDay_Click);
            // 
            // btnGoToPreviousDay
            // 
            this.btnGoToPreviousDay.Name = "btnGoToPreviousDay";
            this.btnGoToPreviousDay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnGoToPreviousDay.Size = new System.Drawing.Size(216, 26);
            this.btnGoToPreviousDay.Text = "Önceki Gün";
            this.btnGoToPreviousDay.Click += new System.EventHandler(this.btnGoToPreviousDay_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFastPaint1,
            this.btnFastPaint2,
            this.btnFastPaint3,
            this.btnFastPaint4,
            this.btnFastPaint5,
            this.toolStripSeparator1,
            this.btnRenkTemizle});
            this.btnPaint.Image = ((System.Drawing.Image)(resources.GetObject("btnPaint.Image")));
            this.btnPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(39, 24);
            this.btnPaint.Text = "Renklendir";
            this.btnPaint.ButtonClick += new System.EventHandler(this.btnPaint_ButtonClick);
            // 
            // btnFastPaint1
            // 
            this.btnFastPaint1.Name = "btnFastPaint1";
            this.btnFastPaint1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.btnFastPaint1.Size = new System.Drawing.Size(212, 26);
            this.btnFastPaint1.Text = "Hızlı Renk 1";
            this.btnFastPaint1.Click += new System.EventHandler(this.btnFastPaint1_Click);
            this.btnFastPaint1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastPaint1_MouseDown);
            // 
            // btnFastPaint2
            // 
            this.btnFastPaint2.Name = "btnFastPaint2";
            this.btnFastPaint2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.btnFastPaint2.Size = new System.Drawing.Size(212, 26);
            this.btnFastPaint2.Text = "Hızlı Renk 2";
            this.btnFastPaint2.Click += new System.EventHandler(this.btnFastPaint2_Click);
            this.btnFastPaint2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastPaint2_MouseDown);
            // 
            // btnFastPaint3
            // 
            this.btnFastPaint3.Name = "btnFastPaint3";
            this.btnFastPaint3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.btnFastPaint3.Size = new System.Drawing.Size(212, 26);
            this.btnFastPaint3.Text = "Hızlı Renk 3";
            this.btnFastPaint3.Click += new System.EventHandler(this.btnFastPaint3_Click);
            this.btnFastPaint3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastPaint3_MouseDown);
            // 
            // btnFastPaint4
            // 
            this.btnFastPaint4.Name = "btnFastPaint4";
            this.btnFastPaint4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.btnFastPaint4.Size = new System.Drawing.Size(212, 26);
            this.btnFastPaint4.Text = "Hızlı Renk 4";
            this.btnFastPaint4.Click += new System.EventHandler(this.btnFastPaint4_Click);
            this.btnFastPaint4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastPaint4_MouseDown);
            // 
            // btnFastPaint5
            // 
            this.btnFastPaint5.Name = "btnFastPaint5";
            this.btnFastPaint5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.btnFastPaint5.Size = new System.Drawing.Size(212, 26);
            this.btnFastPaint5.Text = "Hızlı Renk 5";
            this.btnFastPaint5.Click += new System.EventHandler(this.btnFastPaint5_Click);
            this.btnFastPaint5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastPaint5_MouseDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // btnRenkTemizle
            // 
            this.btnRenkTemizle.Name = "btnRenkTemizle";
            this.btnRenkTemizle.Size = new System.Drawing.Size(212, 26);
            this.btnRenkTemizle.Text = "Temizle";
            this.btnRenkTemizle.Click += new System.EventHandler(this.btnRenkTemizle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(24, 24);
            this.btnAbout.Text = "Hakkında";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePatients);
            this.tabControl1.Controls.Add(this.tabPageAppointments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 540);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 25);
            this.tabPagePatients.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePatients.Size = new System.Drawing.Size(1037, 511);
            this.tabPagePatients.TabIndex = 0;
            this.tabPagePatients.Text = "Hastalar";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmPATIENT_NAME,
            this.clmPATIENT_SURNAME,
            this.clmPATIENT_ADDRESS,
            this.clmPATIENT_TELEPHONE_NUMBER,
            this.clmPATIENT_BOOK_NAME,
            this.clmPATIENT_BOOK_PAGE_NUMBER,
            this.clmPATIENT_CREATED_DATE,
            this.clmPATIENT_MODIFIED_DATE,
            this.clmPATIENT_BALANCE,
            this.clmTeeth});
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1029, 503);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
            this.dataGridViewPatients.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewPatients_CellPainting);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmPATIENT_NAME
            // 
            this.clmPATIENT_NAME.DataPropertyName = "NAME";
            this.clmPATIENT_NAME.HeaderText = "Ad";
            this.clmPATIENT_NAME.Name = "clmPATIENT_NAME";
            this.clmPATIENT_NAME.ReadOnly = true;
            // 
            // clmPATIENT_SURNAME
            // 
            this.clmPATIENT_SURNAME.DataPropertyName = "SURNAME";
            this.clmPATIENT_SURNAME.HeaderText = "Soyad";
            this.clmPATIENT_SURNAME.Name = "clmPATIENT_SURNAME";
            this.clmPATIENT_SURNAME.ReadOnly = true;
            // 
            // clmPATIENT_ADDRESS
            // 
            this.clmPATIENT_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPATIENT_ADDRESS.DataPropertyName = "ADDRESS";
            this.clmPATIENT_ADDRESS.HeaderText = "Adres";
            this.clmPATIENT_ADDRESS.Name = "clmPATIENT_ADDRESS";
            this.clmPATIENT_ADDRESS.ReadOnly = true;
            // 
            // clmPATIENT_TELEPHONE_NUMBER
            // 
            this.clmPATIENT_TELEPHONE_NUMBER.DataPropertyName = "PHONE_NUMBER";
            this.clmPATIENT_TELEPHONE_NUMBER.HeaderText = "Telefon Numarası";
            this.clmPATIENT_TELEPHONE_NUMBER.Name = "clmPATIENT_TELEPHONE_NUMBER";
            this.clmPATIENT_TELEPHONE_NUMBER.ReadOnly = true;
            // 
            // clmPATIENT_BOOK_NAME
            // 
            this.clmPATIENT_BOOK_NAME.DataPropertyName = "BOOK_NAME";
            this.clmPATIENT_BOOK_NAME.HeaderText = "Kitap";
            this.clmPATIENT_BOOK_NAME.Name = "clmPATIENT_BOOK_NAME";
            this.clmPATIENT_BOOK_NAME.ReadOnly = true;
            // 
            // clmPATIENT_BOOK_PAGE_NUMBER
            // 
            this.clmPATIENT_BOOK_PAGE_NUMBER.DataPropertyName = "BOOK_PAGE_NUMBER";
            this.clmPATIENT_BOOK_PAGE_NUMBER.HeaderText = "Kitap Sayfa Numarası";
            this.clmPATIENT_BOOK_PAGE_NUMBER.Name = "clmPATIENT_BOOK_PAGE_NUMBER";
            this.clmPATIENT_BOOK_PAGE_NUMBER.ReadOnly = true;
            // 
            // clmPATIENT_CREATED_DATE
            // 
            this.clmPATIENT_CREATED_DATE.DataPropertyName = "CREATED_DATE";
            this.clmPATIENT_CREATED_DATE.HeaderText = "Eklenme Tarihi";
            this.clmPATIENT_CREATED_DATE.Name = "clmPATIENT_CREATED_DATE";
            this.clmPATIENT_CREATED_DATE.ReadOnly = true;
            this.clmPATIENT_CREATED_DATE.Visible = false;
            // 
            // clmPATIENT_MODIFIED_DATE
            // 
            this.clmPATIENT_MODIFIED_DATE.DataPropertyName = "MODIFIED_DATE";
            this.clmPATIENT_MODIFIED_DATE.HeaderText = "Düzenlenme Tarihi";
            this.clmPATIENT_MODIFIED_DATE.Name = "clmPATIENT_MODIFIED_DATE";
            this.clmPATIENT_MODIFIED_DATE.ReadOnly = true;
            this.clmPATIENT_MODIFIED_DATE.Visible = false;
            // 
            // clmPATIENT_BALANCE
            // 
            this.clmPATIENT_BALANCE.DataPropertyName = "BALANCE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.clmPATIENT_BALANCE.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmPATIENT_BALANCE.HeaderText = "Bakiye";
            this.clmPATIENT_BALANCE.Name = "clmPATIENT_BALANCE";
            this.clmPATIENT_BALANCE.ReadOnly = true;
            // 
            // clmTeeth
            // 
            this.clmTeeth.HeaderText = "Dişler";
            this.clmTeeth.Name = "clmTeeth";
            this.clmTeeth.ReadOnly = true;
            this.clmTeeth.Visible = false;
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.dataGridViewAppointments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAppointments.Size = new System.Drawing.Size(1037, 511);
            this.tabPageAppointments.TabIndex = 1;
            this.tabPageAppointments.Text = "Randevular";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AllowUserToResizeRows = false;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNAME,
            this.clmDESCRIPTION,
            this.clmPHONE_NUMBER});
            this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1029, 503);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellEndEdit);
            // 
            // clmNAME
            // 
            this.clmNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNAME.DataPropertyName = "NAME";
            this.clmNAME.HeaderText = "Ad Soyad";
            this.clmNAME.Name = "clmNAME";
            this.clmNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDESCRIPTION
            // 
            this.clmDESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.clmDESCRIPTION.HeaderText = "Yapılacak İşlem";
            this.clmDESCRIPTION.Name = "clmDESCRIPTION";
            this.clmDESCRIPTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPHONE_NUMBER
            // 
            this.clmPHONE_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPHONE_NUMBER.DataPropertyName = "PHONE_NUMBER";
            this.clmPHONE_NUMBER.HeaderText = "Telefon Numarası";
            this.clmPHONE_NUMBER.Name = "clmPHONE_NUMBER";
            this.clmPHONE_NUMBER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1045, 33);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(166, 28);
            this.lblInfo.Text = "Dental Software";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ddbPatient;
        private System.Windows.Forms.ToolStripMenuItem btnAddPatient;
        private System.Windows.Forms.ToolStripMenuItem btnEditPatient;
        private System.Windows.Forms.ToolStripMenuItem btnDeletePatient;
        private System.Windows.Forms.ToolStripButton btnFindPatient;
        private System.Windows.Forms.ToolStripSeparator separatorAppointment;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.ToolStripSplitButton btnPaint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnRenkTemizle;
        private System.Windows.Forms.ToolStripSplitButton btnGoTo;
        private System.Windows.Forms.ToolStripMenuItem btnGoToToday;
        private System.Windows.Forms.ToolStripMenuItem btnGoToNextDay;
        private System.Windows.Forms.ToolStripMenuItem btnGoToPreviousDay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPHONE_NUMBER;
        private System.Windows.Forms.ToolStripMenuItem btnFastPaint1;
        private System.Windows.Forms.ToolStripMenuItem btnFastPaint2;
        private System.Windows.Forms.ToolStripMenuItem btnFastPaint3;
        private System.Windows.Forms.ToolStripMenuItem btnFastPaint4;
        private System.Windows.Forms.ToolStripMenuItem btnFastPaint5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_TELEPHONE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_BOOK_PAGE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_CREATED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_MODIFIED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPATIENT_BALANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeeth;
    }
}

