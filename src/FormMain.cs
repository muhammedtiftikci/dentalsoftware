﻿using DentalSoftware.Forms;
using DentalSoftware.Utils;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DentalSoftware
{
    public partial class FormMain : Form
    {
        private DatabaseService _dbService;
        private PatientService _patientService;
        private AppointmentService _appointmentService;

        private DateTime _date;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            try
            {
                Init();

                LoadPatientGrid();
                LoadAppointmentGrid(DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Program kapatılacak.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Application.Exit();
            }
        }

        private void Init()
        {
            _dbService = new DatabaseService(Settings.Default.CONNECTION_STRING);
            _patientService = new PatientService(_dbService);
            _appointmentService = new AppointmentService(_dbService);

            // Set up appointment grid.
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

            // Init fast paint button iamges.
            SetFastPaintButtonImage(btnFastPaint1, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_1);
            SetFastPaintButtonImage(btnFastPaint2, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_2);
            SetFastPaintButtonImage(btnFastPaint3, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_3);
            SetFastPaintButtonImage(btnFastPaint4, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_4);
            SetFastPaintButtonImage(btnFastPaint5, Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_5);
        }

        #region PATIENT

        private void LoadPatientGrid()
        {
            int? selectedRowIndex = default(int?);

            if (dataGridViewPatients.Rows.Count > 0)
            {
                if (dataGridViewPatients.SelectedRows.Count > 0)
                {
                    selectedRowIndex = dataGridViewPatients.SelectedRows[0].Index;
                }
            }

            DataTable table = _patientService.GetDataTable();

            dataGridViewPatients.DataSource = table;

            for (int i = 1; i <= table.Rows.Count; i++)
            {
                dataGridViewPatients.Rows[i - 1].HeaderCell.Value = i.ToString();
            }

            if (selectedRowIndex.HasValue)
            {
                dataGridViewPatients.Rows[selectedRowIndex.Value].Selected = true;
            }

            dataGridViewPatients.Focus();
        }

        #endregion

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
            HastaAra();
        }

        private void HastaAra()
        {
            FormFind form = new FormFind();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                DataTable table = _patientService.Search(form.SearchText, true);
                dataGridViewPatients.DataSource = table;

                for (int i = 1; i <= table.Rows.Count; i++)
                {
                    dataGridViewPatients.Rows[i - 1].HeaderCell.Value = i.ToString();
                }
            }

            dataGridViewAppointments.Focus();
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
                btnGoTo.Visible = false;
                btnPaint.Visible = false;

                lblInfo.Text = string.Empty;
            }
            else if (tabControl1.SelectedTab == tabPageAppointments)
            {
                Text = $"Randevular - {programName}";

                ddbPatient.Visible = false;
                btnFindPatient.Visible = false;
                btnGoTo.Visible = true;
                btnPaint.Visible = true;

                lblInfo.Text = $"Tarih: {_date.ToLongDateString()}";
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
                    SetFastPaintButtonImage(btnFastPaint1, colorDialog.Color);

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
                    SetFastPaintButtonImage(btnFastPaint2, colorDialog.Color);

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
                    SetFastPaintButtonImage(btnFastPaint3, colorDialog.Color);

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
                    SetFastPaintButtonImage(btnFastPaint4, colorDialog.Color);

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
                    SetFastPaintButtonImage(btnFastPaint5, colorDialog.Color);

                    Settings.Default.APPOINTMENT_FAST_PAINT_COLOR_5 = colorDialog.Color;
                    Settings.Default.Save();
                }
            }
        }

        private void SetFastPaintButtonImage(ToolStripMenuItem button, Color color)
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

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPagePatients)
            {
                if (e.Control && e.KeyCode == Keys.F)
                {
                    HastaAra();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    DataTable table = _patientService.Search(string.Empty);
                    dataGridViewPatients.DataSource = table;

                    for (int i = 1; i <= table.Rows.Count; i++)
                    {
                        dataGridViewPatients.Rows[i - 1].HeaderCell.Value = i.ToString();
                    }

                    dataGridViewAppointments.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (dataGridViewPatients.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = dataGridViewPatients.SelectedRows[0].Index;

                        if (selectedRowIndex >= 0)
                        {
                            //ShowDetail(selectedRowIndex);
                        }
                    }
                }
            }
            else if (tabControl1.SelectedTab == tabPageAppointments)
            {
                if (e.Control && e.KeyCode == Keys.T)
                {
                    btnGoTo_ButtonClick(this, EventArgs.Empty);
                }
            }
        }

        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetail(e.RowIndex);
        }

        private void ShowDetail(int rowIndex)
        {
            int id = (int)dataGridViewPatients.Rows[rowIndex].Cells["clmID"].Value;
            string ad = (string)dataGridViewPatients.Rows[rowIndex].Cells["clmPATIENT_NAME"].Value;
            string soyad = (string)dataGridViewPatients.Rows[rowIndex].Cells["clmPATIENT_SURNAME"].Value;

            FormPatientDetail form = new FormPatientDetail(_dbService, id);
            form.Text = $"{ad} {soyad} - {form.Text}";
            form.ShowDialog();

            if (form.Changed)
            {
                // TODO: Hasta işlemlerinde bir değişiklik olduktan sonra bakiyeyi güncelle.
                //LoadPatientGrid();
                dataGridViewPatients.Rows[rowIndex].Cells["clmPATIENT_BALANCE"].Value = form.TotalNet;
            }
        }

        #region Patient CRUD

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FormPatientIU form = new FormPatientIU(_dbService);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                int rowIndex = dataGridViewPatients.SelectedRows[0].Index;

                LoadPatientGrid();

                dataGridViewPatients.Rows[rowIndex].Selected = true;
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count != 1)
            {
                return;
            }

            int patientId = (int)dataGridViewPatients.SelectedRows[0].Cells["clmID"].Value;

            FormPatientIU form = new FormPatientIU(_dbService, patientId);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                int rowIndex = dataGridViewPatients.SelectedRows[0].Index;

                LoadPatientGrid();

                dataGridViewPatients.Rows[rowIndex].Selected = true;
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count != 1)
            {
                return;
            }

            int patientId = (int)dataGridViewPatients.SelectedRows[0].Cells["clmID"].Value;

            string ad = (string)dataGridViewPatients.SelectedRows[0].Cells["clmPATIENT_NAME"].Value;
            string soyad = (string)dataGridViewPatients.SelectedRows[0].Cells["clmPATIENT_SURNAME"].Value;

            DialogResult dr = MessageBox.Show($"{ad} {soyad} hasta bilgileri silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                return;
            }

            PatientService patientService = new PatientService(_dbService);
            int affectedRows = patientService.Delete(patientId);

            if (affectedRows == 0)
            {
                MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (affectedRows == 1)
            {
                LoadPatientGrid();
            }
            else
            {
                MessageBox.Show(affectedRows + " adet hasta kaydı silindi!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void dataGridViewPatients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            decimal balance = (decimal)dataGridViewPatients.Rows[e.RowIndex].Cells["clmPATIENT_BALANCE"].Value;

            if (balance > 0)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            else if (balance < 0)
            {
                e.CellStyle.ForeColor = Color.Blue;
            }
        }

        private void btnShowAllPatients_Click(object sender, EventArgs e)
        {
            DataTable table = _patientService.Search(string.Empty, true);
            dataGridViewPatients.DataSource = table;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string currentFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");

            if (File.Exists(currentFileName))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = $"Musteri Takip {DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss")}.db";
                sfd.Filter = "database|*.db";
                var dr = sfd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    File.Copy(currentFileName, sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
