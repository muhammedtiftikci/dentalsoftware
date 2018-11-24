using DentalSoftware.Models;
using DentalSoftware.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalSoftware.Forms
{
    public partial class FormPatientIU : Form
    {
        private DatabaseService _dbService;
        private PatientService _patientService;

        public FormPatientIU(DatabaseService dbService)
        {
            InitializeComponent();

            _dbService = dbService;
            _patientService = new PatientService(dbService);

            btnOk.Click += (s, e) => InsertToDb();
        }

        public FormPatientIU(DatabaseService dbService, int patientId)
        {
            InitializeComponent();

            _dbService = dbService;
            _patientService = new PatientService(dbService);

            btnOk.Click += (s, e) => UpdateDb(patientId);

            LoadData(patientId);
        }

        private void InsertToDb()
        {
            Patient model = new Patient()
            {
                NAME = tbName.Text,
                SURNAME = tbSurname.Text,
                PHONE_NUMBER = mtbPhoneNumber.MaskCompleted ? mtbPhoneNumber.Text : string.Empty,
                ADDRESS = tbAddress.Text,
                BOOK_NAME = tbBookName.Text,
                BOOK_PAGE_NUMBER = (int)nudBookPageNumber.Value
            };

            int affectedRows = _patientService.Insert(model);

            if (affectedRows == 0)
            {
                MessageBox.Show("Hasta ekleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (affectedRows == 1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(affectedRows + " adet ekleme yapıldı.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadData(int patientId)
        {
            Patient patient = _patientService.First(patientId);

            tbName.Text = patient.NAME;
            tbSurname.Text = patient.SURNAME;
            mtbPhoneNumber.Text = patient.PHONE_NUMBER;
            tbAddress.Text = patient.ADDRESS;
            tbBookName.Text = patient.BOOK_NAME;
            nudBookPageNumber.Value = patient.BOOK_PAGE_NUMBER;
        }

        private void UpdateDb(int patientId)
        {
            Patient model = new Patient()
            {
                ID = patientId,
                NAME = tbName.Text,
                SURNAME = tbSurname.Text,
                PHONE_NUMBER = mtbPhoneNumber.MaskCompleted ? mtbPhoneNumber.Text : string.Empty,
                ADDRESS = tbAddress.Text,
                BOOK_NAME = tbBookName.Text,
                BOOK_PAGE_NUMBER = (int)nudBookPageNumber.Value
            };

            int affectedRows = _patientService.Update(model);

            if (affectedRows == 0)
            {
                MessageBox.Show("Hasta güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (affectedRows == 1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(affectedRows + " adet güncelleme yapıldı.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
