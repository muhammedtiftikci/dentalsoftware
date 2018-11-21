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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientDetail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTeeth = new System.Windows.Forms.TabPage();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGizleGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImplant = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKopruSaga = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKopruSola = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(118, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 100);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 431);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageTeeth
            // 
            this.tabPageTeeth.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeeth.Name = "tabPageTeeth";
            this.tabPageTeeth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeeth.Size = new System.Drawing.Size(952, 405);
            this.tabPageTeeth.TabIndex = 0;
            this.tabPageTeeth.Text = "Dişler";
            this.tabPageTeeth.UseVisualStyleBackColor = true;
            this.tabPageTeeth.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageTeeth_Paint);
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(952, 405);
            this.tabPageAppointments.TabIndex = 1;
            this.tabPageAppointments.Text = "İşlemler";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGizleGoster,
            this.btnImplant,
            this.btnKopruSaga,
            this.btnKopruSola});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 92);
            // 
            // btnGizleGoster
            // 
            this.btnGizleGoster.Name = "btnGizleGoster";
            this.btnGizleGoster.Size = new System.Drawing.Size(142, 22);
            this.btnGizleGoster.Text = "Gizle/Göster";
            this.btnGizleGoster.Click += new System.EventHandler(this.btnGizleGoster_Click);
            // 
            // btnImplant
            // 
            this.btnImplant.Name = "btnImplant";
            this.btnImplant.Size = new System.Drawing.Size(142, 22);
            this.btnImplant.Text = "İmplant";
            this.btnImplant.Click += new System.EventHandler(this.btnImplant_Click);
            // 
            // btnKopruSaga
            // 
            this.btnKopruSaga.Name = "btnKopruSaga";
            this.btnKopruSaga.Size = new System.Drawing.Size(142, 22);
            this.btnKopruSaga.Text = "Köprü (Sağa)";
            this.btnKopruSaga.Click += new System.EventHandler(this.btnKopruSaga_Click);
            // 
            // btnKopruSola
            // 
            this.btnKopruSola.Name = "btnKopruSola";
            this.btnKopruSola.Size = new System.Drawing.Size(142, 22);
            this.btnKopruSola.Text = "Köprü (Sola)";
            this.btnKopruSola.Click += new System.EventHandler(this.btnKopruSola_Click);
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
    }
}