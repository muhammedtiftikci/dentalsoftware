using DentalSoftware.Forms;
using DentalSoftware.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalSoftware
{
    public partial class FormMain : Form
    {
        private DatabaseService _dbService;
        private AppointmentService _appointmentService;

        private DateTime _date;

        public FormMain()
        {
            InitializeComponent();

            Init();

            LoadAppointmentGrid(DateTime.Now.Date);
        }

        private void Init()
        {
            LoadFastPaintColors(btnFastPaint1, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_1);
            LoadFastPaintColors(btnFastPaint2, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_2);
            LoadFastPaintColors(btnFastPaint3, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_3);
            LoadFastPaintColors(btnFastPaint4, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_4);
            LoadFastPaintColors(btnFastPaint5, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_5);

            _dbService = new DatabaseService(Settings.Default.CONNECTION_STRING);
            _appointmentService = new AppointmentService(_dbService);

            TimeSpan startTime = Settings.Default.APPOINTMENT_START_TIME;
            TimeSpan endTime = Settings.Default.APPOINTMENT_END_TIME;
            TimeSpan duration = Settings.Default.APPOINTMENT_DURATION;

            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            for (int i = 0; startTime < endTime; i++)
            {
                dataGridViewAppointments.Rows.Add();

                TimeSpan endOfDuration = startTime.Add(duration);

                dataGridViewAppointments.Rows[i].HeaderCell.Value = $"{startTime.ToString("hh\\:mm")} → {endOfDuration.ToString("hh\\:mm")}";

                startTime = endOfDuration;
            }

            dataGridViewAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        }

        private void LoadAppointmentGrid(DateTime date)
        {
            _date = date;

            SetTitle();

            ClearAppointmentGrid();

            DataTable table = _appointmentService.GetDataTable(_date);

            foreach (DataRow row in table.Rows)
            {
                byte rowNumber = (byte)row["ROW_NUMBER"];

                dataGridViewAppointments.Rows[rowNumber].Cells["clmNAME"].Value = row["NAME"];
                dataGridViewAppointments.Rows[rowNumber].Cells["clmDESCRIPTION"].Value = row["DESCRIPTION"];
                dataGridViewAppointments.Rows[rowNumber].Cells["clmPHONE_NUMBER"].Value = row["PHONE_NUMBER"];

                dataGridViewAppointments.Rows[rowNumber].Cells["clmNAME"].Style.BackColor = ColorFromDb(row["COLOR_NAME"]);
                dataGridViewAppointments.Rows[rowNumber].Cells["clmDESCRIPTION"].Style.BackColor = ColorFromDb(row["COLOR_DESCRIPTION"]);
                dataGridViewAppointments.Rows[rowNumber].Cells["clmPHONE_NUMBER"].Style.BackColor = ColorFromDb(row["COLOR_PHONE_NUMBER"]);
            }
        }

        private Color ColorFromDb(object value)
        {
            if (value == null || value is DBNull)
            {
                return Color.White;
            }

            int valueARGB = (int)value;

            if (valueARGB == 0)
            {
                return Color.White;
            }

            return Color.FromArgb(valueARGB);
        }

        private void ClearAppointmentGrid()
        {
            for (int i = 0; i < dataGridViewAppointments.RowCount; i++)
            {
                dataGridViewAppointments.Rows[i].Cells["clmNAME"].Value = null;
                dataGridViewAppointments.Rows[i].Cells["clmDESCRIPTION"].Value = null;
                dataGridViewAppointments.Rows[i].Cells["clmPHONE_NUMBER"].Value = null;

                dataGridViewAppointments.Rows[i].Cells["clmNAME"].Style.BackColor = Color.White;
                dataGridViewAppointments.Rows[i].Cells["clmDESCRIPTION"].Style.BackColor = Color.White;
                dataGridViewAppointments.Rows[i].Cells["clmPHONE_NUMBER"].Style.BackColor = Color.White;
            }
        }

        private void dataGridViewAppointments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            byte rowNumber = (byte)e.RowIndex;
            string fieldName = dataGridViewAppointments.Columns[e.ColumnIndex].DataPropertyName;
            string value = (string)dataGridViewAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? string.Empty;

            int affectedRows = _appointmentService.InsertOrUpdate(_date, rowNumber, fieldName, value);

            switch (affectedRows)
            {
                case 0:
                    MessageBox.Show($"Kayıt yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // TODO: Save log.

                    break;
                case 1:

                    break;
                default:
                    MessageBox.Show($"Etkilenen satır adedi: {affectedRows}! Lütfen sistem yöneticiniz ile iletişime geçiniz!", "Önemli Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // TODO: Save log.

                    break;
            }
        }

        private void btnGoTo_ButtonClick(object sender, EventArgs e)
        {
            FormCalendar form = new FormCalendar();
            form.Date = _date;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadAppointmentGrid(form.Date);
            }
        }

        private void btnPaint_ButtonClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult dr = colorDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                PaintSelectedCells(colorDialog.Color);
            }
        }

        private void PaintSelectedCells(Color color)
        {
            foreach (DataGridViewCell cell in dataGridViewAppointments.SelectedCells)
            {
                string fieldName = $"COLOR_{cell.OwningColumn.DataPropertyName}";

                int affectedRows = _appointmentService.InsertOrUpdate(_date, (byte)cell.RowIndex, fieldName, color.ToArgb());

                switch (affectedRows)
                {
                    case 0:
                        MessageBox.Show("Kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    case 1:
                        cell.Style.BackColor = color;

                        break;
                    default:
                        MessageBox.Show($"{affectedRows} adet güncelleme yapıldı!", "Önemli Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                }
            }
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            FormFind form = new FormFind();
            form.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTitle();
        }

        private void SetTitle()
        {
            string programName = "Hasta Takip Sistemi";

            if (tabControl1.SelectedTab == tabPagePatients)
            {
                Text = $"Hastalar - {programName}";
                
                ddbPatient.Visible = true;
                btnFindPatient.Visible = true;
                separatorAppointment.Visible = false;
                btnGoTo.Visible = false;
                btnPaint.Visible = false;

                lblInfo.Text = string.Empty;
            }
            else if (tabControl1.SelectedTab == tabPageAppointments)
            {
                Text = $"Randevular - {programName}";

                ddbPatient.Visible = false;
                btnFindPatient.Visible = false;
                separatorAppointment.Visible = true;
                btnGoTo.Visible = true;
                btnPaint.Visible = true;

                lblInfo.Text = $"Tarih: {_date.ToString("dd MMMM yyyy")}";
            }
        }

        private void btnGoToToday_Click(object sender, EventArgs e)
        {
            LoadAppointmentGrid(DateTime.Now);
        }

        private void btnGoToNextDay_Click(object sender, EventArgs e)
        {
            LoadAppointmentGrid(_date.AddDays(1));
        }

        private void btnGoToPreviousDay_Click(object sender, EventArgs e)
        {
            LoadAppointmentGrid(_date.AddDays(-1));
        }

        private void btnFastPaint1_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_1);
        }

        private void btnFastPaint2_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_2);
        }

        private void btnFastPaint3_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_3);
        }

        private void btnFastPaint4_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_4);
        }

        private void btnFastPaint5_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_5);
        }

        private void btnRenkTemizle_Click(object sender, EventArgs e)
        {
            PaintSelectedCells(Color.White);
        }

        private void btnFastPaint1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                ColorDialog colorDialog = new ColorDialog();
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    LoadFastPaintColors(btnFastPaint1, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_1 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void btnFastPaint2_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                ColorDialog colorDialog = new ColorDialog();
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    LoadFastPaintColors(btnFastPaint2, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_2 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void btnFastPaint3_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                ColorDialog colorDialog = new ColorDialog();
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    LoadFastPaintColors(btnFastPaint3, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_3 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void btnFastPaint4_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                ColorDialog colorDialog = new ColorDialog();
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    LoadFastPaintColors(btnFastPaint4, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_4 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void btnFastPaint5_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                ColorDialog colorDialog = new ColorDialog();
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    LoadFastPaintColors(btnFastPaint5, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_5 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void LoadFastPaintColors(ToolStripMenuItem button, Color color)
        {
            if (color == Color.White)
            {
                button.Image = null;
            }
            else
            {
                Bitmap bitmap = new Bitmap(16, 16);

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        bitmap.SetPixel(i, j, color);
                    }
                }

                button.Image = bitmap;
            }
        }
    }
}
