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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindPatient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnRenklendir = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clmNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRenkTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.bugünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiGünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiGünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnFindPatient,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.btnRenklendir,
            this.toolStripSeparator2,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPatient,
            this.btnEditPatient,
            this.btnDeletePatient});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Hasta İşlemleri";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(180, 22);
            this.btnAddPatient.Text = "Hasta Ekle";
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(180, 22);
            this.btnEditPatient.Text = "Hasta Düzenle";
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(180, 22);
            this.btnDeletePatient.Text = "Hasta Sil";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFindPatient.Image = global::DentalSoftware.Properties.Resources.Find_16x16;
            this.btnFindPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(23, 22);
            this.btnFindPatient.Text = "Hasta Ara";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "Hakkında";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePatients);
            this.tabControl1.Controls.Add(this.tabPageAppointments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 436);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatients.Size = new System.Drawing.Size(776, 410);
            this.tabPagePatients.TabIndex = 0;
            this.tabPagePatients.Text = "Hastalar";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.dataGridViewAppointments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(776, 410);
            this.tabPageAppointments.TabIndex = 1;
            this.tabPageAppointments.Text = "Randevular";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(770, 404);
            this.dataGridViewPatients.TabIndex = 0;
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
            this.clmPhoneNumber});
            this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(770, 404);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellEndEdit);
            // 
            // btnRenklendir
            // 
            this.btnRenklendir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRenklendir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRenkTemizle});
            this.btnRenklendir.Image = ((System.Drawing.Image)(resources.GetObject("btnRenklendir.Image")));
            this.btnRenklendir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenklendir.Name = "btnRenklendir";
            this.btnRenklendir.Size = new System.Drawing.Size(32, 22);
            this.btnRenklendir.Text = "Renklendir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPhoneNumber.DataPropertyName = "PHONE_NUMBER";
            this.clmPhoneNumber.HeaderText = "Telefon Numarası";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnRenkTemizle
            // 
            this.btnRenkTemizle.Name = "btnRenkTemizle";
            this.btnRenkTemizle.Size = new System.Drawing.Size(180, 22);
            this.btnRenkTemizle.Text = "Temizle";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugünToolStripMenuItem,
            this.sonrakiGünToolStripMenuItem,
            this.öncekiGünToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "Git";
            // 
            // bugünToolStripMenuItem
            // 
            this.bugünToolStripMenuItem.Name = "bugünToolStripMenuItem";
            this.bugünToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.bugünToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bugünToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bugünToolStripMenuItem.Text = "Bugün";
            // 
            // sonrakiGünToolStripMenuItem
            // 
            this.sonrakiGünToolStripMenuItem.Name = "sonrakiGünToolStripMenuItem";
            this.sonrakiGünToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.sonrakiGünToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sonrakiGünToolStripMenuItem.Text = "Sonraki Gün";
            // 
            // öncekiGünToolStripMenuItem
            // 
            this.öncekiGünToolStripMenuItem.Name = "öncekiGünToolStripMenuItem";
            this.öncekiGünToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.öncekiGünToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.öncekiGünToolStripMenuItem.Text = "Önceki Gün";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Takip Sistemi";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePatients.ResumeLayout(false);
            this.tabPageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnAddPatient;
        private System.Windows.Forms.ToolStripMenuItem btnEditPatient;
        private System.Windows.Forms.ToolStripMenuItem btnDeletePatient;
        private System.Windows.Forms.ToolStripButton btnFindPatient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.ToolStripSplitButton btnRenklendir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.ToolStripMenuItem btnRenkTemizle;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem bugünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiGünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiGünToolStripMenuItem;
    }
}

