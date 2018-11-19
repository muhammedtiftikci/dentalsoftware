namespace DentalSoftware.Forms
{
    partial class FormCalendar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnGo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(3, 176);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(240, 25);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Git";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FormCalendar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Takvim";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCalendar_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnGo;
    }
}