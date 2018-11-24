namespace DentalSoftware.Forms
{
    partial class FormPatientDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientDetail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTeeth = new System.Windows.Forms.TabPage();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGizleGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImplant = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKopruSaga = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKopruSola = new System.Windows.Forms.ToolStripMenuItem();
            this.clmTREATMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTREATMENT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTREATMENT_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTREATMENT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTREATMENT_PAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(157, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1139, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muhammed Emin TİFTİKÇİ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTeeth);
            this.tabControl1.Controls.Add(this.tabPageAppointments);
            this.tabControl1.Location = new System.Drawing.Point(16, 145);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 530);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageTeeth
            // 
            this.tabPageTeeth.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeeth.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTeeth.Name = "tabPageTeeth";
            this.tabPageTeeth.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTeeth.Size = new System.Drawing.Size(1272, 501);
            this.tabPageTeeth.TabIndex = 0;
            this.tabPageTeeth.Text = "Dişler";
            this.tabPageTeeth.UseVisualStyleBackColor = true;
            this.tabPageTeeth.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageTeeth_Paint);
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.dataGridViewTreatments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAppointments.Size = new System.Drawing.Size(1272, 501);
            this.tabPageAppointments.TabIndex = 1;
            this.tabPageAppointments.Text = "İşlemler";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AllowUserToDeleteRows = false;
            this.dataGridViewTreatments.AllowUserToResizeRows = false;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTREATMENT_ID,
            this.clmTREATMENT_DATE,
            this.clmTREATMENT_DESCRIPTION,
            this.clmTREATMENT_PRICE,
            this.clmTREATMENT_PAID});
            this.dataGridViewTreatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTreatments.MultiSelect = false;
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.RowHeadersVisible = false;
            this.dataGridViewTreatments.Size = new System.Drawing.Size(1264, 493);
            this.dataGridViewTreatments.TabIndex = 0;
            this.dataGridViewTreatments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTreatments_CellEndEdit);
            this.dataGridViewTreatments.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTreatments_DefaultValuesNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGizleGoster,
            this.btnImplant,
            this.btnKopruSaga,
            this.btnKopruSola});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 100);
            // 
            // btnGizleGoster
            // 
            this.btnGizleGoster.Name = "btnGizleGoster";
            this.btnGizleGoster.Size = new System.Drawing.Size(165, 24);
            this.btnGizleGoster.Text = "Gizle/Göster";
            this.btnGizleGoster.Click += new System.EventHandler(this.btnGizleGoster_Click);
            // 
            // btnImplant
            // 
            this.btnImplant.Name = "btnImplant";
            this.btnImplant.Size = new System.Drawing.Size(165, 24);
            this.btnImplant.Text = "İmplant";
            this.btnImplant.Click += new System.EventHandler(this.btnImplant_Click);
            // 
            // btnKopruSaga
            // 
            this.btnKopruSaga.Name = "btnKopruSaga";
            this.btnKopruSaga.Size = new System.Drawing.Size(165, 24);
            this.btnKopruSaga.Text = "Köprü (Sağa)";
            this.btnKopruSaga.Click += new System.EventHandler(this.btnKopruSaga_Click);
            // 
            // btnKopruSola
            // 
            this.btnKopruSola.Name = "btnKopruSola";
            this.btnKopruSola.Size = new System.Drawing.Size(165, 24);
            this.btnKopruSola.Text = "Köprü (Sola)";
            this.btnKopruSola.Click += new System.EventHandler(this.btnKopruSola_Click);
            // 
            // clmTREATMENT_ID
            // 
            this.clmTREATMENT_ID.DataPropertyName = "ID";
            this.clmTREATMENT_ID.HeaderText = "ID";
            this.clmTREATMENT_ID.Name = "clmTREATMENT_ID";
            this.clmTREATMENT_ID.Visible = false;
            // 
            // clmTREATMENT_DATE
            // 
            this.clmTREATMENT_DATE.DataPropertyName = "DATE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd MMMM yyyy HH:mm";
            this.clmTREATMENT_DATE.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTREATMENT_DATE.HeaderText = "Tarih";
            this.clmTREATMENT_DATE.Name = "clmTREATMENT_DATE";
            // 
            // clmTREATMENT_DESCRIPTION
            // 
            this.clmTREATMENT_DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTREATMENT_DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.clmTREATMENT_DESCRIPTION.HeaderText = "İşlem";
            this.clmTREATMENT_DESCRIPTION.Name = "clmTREATMENT_DESCRIPTION";
            // 
            // clmTREATMENT_PRICE
            // 
            this.clmTREATMENT_PRICE.DataPropertyName = "PRICE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clmTREATMENT_PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmTREATMENT_PRICE.HeaderText = "Tutar";
            this.clmTREATMENT_PRICE.Name = "clmTREATMENT_PRICE";
            // 
            // clmTREATMENT_PAID
            // 
            this.clmTREATMENT_PAID.DataPropertyName = "PAID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clmTREATMENT_PAID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmTREATMENT_PAID.HeaderText = "Ödenen";
            this.clmTREATMENT_PAID.Name = "clmTREATMENT_PAID";
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPatientDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTeeth;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnGizleGoster;
        private System.Windows.Forms.ToolStripMenuItem btnImplant;
        private System.Windows.Forms.ToolStripMenuItem btnKopruSaga;
        private System.Windows.Forms.ToolStripMenuItem btnKopruSola;
        private System.Windows.Forms.DataGridView dataGridViewTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTREATMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTREATMENT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTREATMENT_DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTREATMENT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTREATMENT_PAID;
    }
}