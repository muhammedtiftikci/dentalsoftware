using System;
using System.Windows.Forms;

namespace DentalSoftware.Forms
{
    public partial class FormCalendar : Form
    {
        public DateTime Date
        {
            set
            {
                monthCalendar.SetDate(value.Date);
            }
            get
            {
                return monthCalendar.SelectionStart.Date;
            }
        }

        public FormCalendar()
        {
            InitializeComponent();
        }

        private void FormCalendar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
