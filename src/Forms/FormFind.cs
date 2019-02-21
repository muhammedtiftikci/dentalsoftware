using System.Windows.Forms;

namespace DentalSoftware.Forms
{
    public partial class FormFind : Form
    {
        public string SearchText { get { return textBox1.Text; } }

        public FormFind()
        {
            InitializeComponent();
        }

        private void FormFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
