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

        private DateTime _date;

        public FormMain()
        {
            InitializeComponent();

            //using (OleDbConnection connection = new OleDbConnection(Settings.Default.CONNECTION_STRING_PATIENTS))
            //{
            //    connection.Open();

            //    string query = "SELECT Kimlik, CustomerName, CustomerSurname, CustomerPlace, CustomerPhoneNo, CustomerOwe, CustomerLastProcess, CustomerRegisterDate FROM customer WHERE CustomerIsActive = 'true'";

            //    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            //    {
            //        DataTable table = new DataTable();

            //        adapter.Fill(table);

            //        dataGridView1.DataSource = table;
            //    }
            //}

            Init();
        }

        private void Init()
        {
            _dbService = new DatabaseService(Settings.Default.CONNECTION_STRING);

            dataGridViewAppointments.ColumnCount = 3;

            TimeSpan startTime = Settings.Default.APPOINTMENT_START_TIME;
            TimeSpan endTime = Settings.Default.APPOINTMENT_END_TIME;
            TimeSpan duration = Settings.Default.APPOINTMENT_DURATION;

            for (int i = 0; startTime < endTime; i++)
            {
                dataGridViewAppointments.Rows.Add();

                TimeSpan endOfDuration = startTime.Add(duration);

                dataGridViewAppointments.Rows[i].HeaderCell.Value = $"{startTime.ToString("hh\\:mm")} → {endOfDuration.ToString("hh\\:mm")}";

                startTime = endOfDuration;
            }

            dataGridViewAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        }

        private void dataGridViewAppointments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = (string)dataGridViewAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}
