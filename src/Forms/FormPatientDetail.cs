using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DentalSoftware.Models;
using DentalSoftware.Utils;

namespace DentalSoftware.Forms
{
    public partial class FormPatientDetail : Form
    {
        public bool Changed { get; private set; }

        private readonly Color PEN_SPLITTER_COLOR = Color.Red;
        private readonly Color PEN_BRIDGE_COLOR = Color.Black;
        private const int PEN_BRIDGE_WIDTH = 3;

        private int _patientId;

        private DatabaseService _dbService;
        private PatientService _patientService;
        private TreatmentService _treatmentService;

        private Dictionary<ToothVerticalPosition, Button[]> _teeth;
        private Dictionary<ToothVerticalPosition, ToothStatusFlags[]> _flags;

        private ToothVerticalPosition _lastSelectedToothVerticalPosition;
        private int _lastSelectedToothIndex;

        private List<Point[]> _lines;

        public FormPatientDetail(DatabaseService dbService, int patientId)
        {
            InitializeComponent();

            _dbService = dbService;

            _patientId = patientId;

            Init();

            RenderTooth();
        }

        private void Init()
        {
            _patientService = new PatientService(_dbService);
            _treatmentService = new TreatmentService(_dbService);

            string teethMap = _patientService.GetTeethMap(_patientId);

            const int countX = 16;
            const int countY = 2;

            const int marginLeft = 5;
            const int marginRight = 5;
            const int marginTop = 25;
            const int marginBottom = 5;

            const int spaceX = 4;
            const int spaceY = 40;

            int stageWidth = tabPageTeeth.Width - marginLeft - marginRight;
            int stageHeight = tabPageTeeth.Height - marginTop - marginBottom;

            int buttonWidth = (stageWidth - (countX * spaceX)) / countX;
            int buttonHeight = (stageHeight - ((countY - 1) * spaceY)) / countY;

            _teeth = new Dictionary<ToothVerticalPosition, Button[]>()
            {
                { ToothVerticalPosition.TOP, new Button[countX] },
                { ToothVerticalPosition.BOTTOM, new Button[countX] }
            };

            _flags = new Dictionary<ToothVerticalPosition, ToothStatusFlags[]>()
            {
                { ToothVerticalPosition.TOP, StringToFlags(teethMap.Substring(0, 16)) },
                { ToothVerticalPosition.BOTTOM, StringToFlags(teethMap.Substring(16, 16)) }
            };

            for (int y = 0; y < countY; y++)
            {
                for (int x = 0; x < countX; x++)
                {
                    Button button = new Button();
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Width = buttonWidth;
                    button.Height = buttonHeight;
                    button.AccessibleName = (y == 0 ? "TOP_" : "BOTTOM_") + (x < (countX / 2) ? "LEFT_" + ((countX / 2) - x) : "RIGHT_" + (x - (countX / 2) + 1));

                    Point p = new Point();
                    p.X = marginLeft + ((buttonWidth + spaceX + (x / (countX / 2))) * x);
                    p.Y = marginTop + ((buttonHeight + spaceY) * y);

                    button.Location = p;

                    button.MouseUp += button_MouseUp;

                    _teeth[(ToothVerticalPosition)y][x] = button;

                    tabPageTeeth.Controls.Add(button);
                }
            }

            LoadTreatmentGrid();
        }

        private ToothStatusFlags[] StringToFlags(string array)
        {
            return array
                .Select(x => Enum.Parse(typeof(ToothStatusFlags), x.ToString()))
                .Cast<ToothStatusFlags>()
                .ToArray();
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button button = (Button)sender;

                string[] definitions = button.AccessibleName.Split('_');

                ToothVerticalPosition verticalPosition = (ToothVerticalPosition)Enum.Parse(typeof(ToothVerticalPosition), definitions[0]);
                string horizontalPosition = definitions[1];
                int toothNumber = int.Parse(definitions[2]);

                int toothIndex = horizontalPosition == "LEFT" ? 8 - toothNumber : 7 + toothNumber;

                Rules(verticalPosition, toothIndex);

                Point location = button.PointToScreen(e.Location);
                contextMenuStrip1.Show(location);
            }
        }

        /// <param name="index">0 - 15</param>
        private void Rules(ToothVerticalPosition tvp, int index)
        {
            bool kopruSaga = true;
            bool kopruSola = true;
            bool gosterGizle = true;
            bool implant = true;

            // BRIDGE LEFT
            if (_flags[tvp][index] == ToothStatusFlags.Hidden)
            {
                kopruSola = false;
            }
            else if (index < 2)
            {
                kopruSola = false;
            }
            else if (_flags[tvp][index - 2] == ToothStatusFlags.Hidden)
            {
                kopruSola = false;
            }
            else if (_flags[tvp][index - 1] != ToothStatusFlags.Hidden && _flags[tvp][index - 1] != ToothStatusFlags.Bridge)
            {
                kopruSola = false;
            }

            // BRIDGE RIGHT
            if (_flags[tvp][index] == ToothStatusFlags.Hidden)
            {
                kopruSaga = false;
            }
            else if (index > 13)
            {
                kopruSaga = false;
            }
            else if (_flags[tvp][index + 2] == ToothStatusFlags.Hidden)
            {
                kopruSaga = false;
            }
            else if (_flags[tvp][index + 1] != ToothStatusFlags.Hidden && _flags[tvp][index + 1] != ToothStatusFlags.Bridge)
            {
                kopruSaga = false;
            }

            // SHOW / HIDE
            if (_flags[tvp][index] != ToothStatusFlags.Hidden && _flags[tvp][index] != ToothStatusFlags.Normal)
            {
                gosterGizle = false;
            }
            else if (index > 0 && _flags[tvp][index - 1] == ToothStatusFlags.Bridge)
            {
                gosterGizle = false;
            }
            else if (index < 15 && _flags[tvp][index + 1] == ToothStatusFlags.Bridge)
            {
                gosterGizle = false;
            }

            // IMPLANT
            if (_flags[tvp][index] != ToothStatusFlags.Normal && _flags[tvp][index] != ToothStatusFlags.Implant)
            {
                implant = false;
            }

            btnKopruSaga.Visible = kopruSaga;
            btnKopruSola.Visible = kopruSola;
            btnGizleGoster.Visible = gosterGizle;
            btnImplant.Visible = implant;

            _lastSelectedToothVerticalPosition = tvp;
            _lastSelectedToothIndex = index;
        }

        private void RenderTooth()
        {
            SaveTeethMap();
            
            _lines = new List<Point[]>();

            foreach (var row in _teeth)
            {
                for (int i = 0; i < row.Value.Length; i++)
                {
                    Button button = row.Value[i];
                    ToothStatusFlags flags = _flags[row.Key][i];

                    string imageName = button.AccessibleName
                        .Replace("TOP", "U")
                        .Replace("BOTTOM", "L")
                        .Replace("LEFT", "R")
                        .Replace("RIGHT", "L")
                        .Replace("_", "");

                    button.BackgroundImage = Image.FromFile("images/" + imageName + ".jpg");

                    switch (flags)
                    {
                        case ToothStatusFlags.Hidden:
                            button.BackgroundImage = Image.FromFile("images/NULL.jpg"); ;
                            break;

                        case ToothStatusFlags.Normal:
                            break;

                        case ToothStatusFlags.Bridge:
                            button.Visible = true;
                            button.BackgroundImage = Image.FromFile("images/bridge.jpg");

                            Button btnLeft = row.Value[i - 1];
                            Button btnRight = row.Value[i + 1];

                            Point p1 = btnLeft.Location;
                            p1.X += btnLeft.Width / 2;

                            Point p2 = p1;
                            p2.Y -= 10;

                            Point p4 = btnRight.Location;
                            p4.X += btnRight.Width / 2;

                            Point p3 = p4;
                            p3.Y -= 10;

                            _lines.Add(new Point[] { p1, p2, p3, p4 });

                            break;

                        case ToothStatusFlags.Filling:

                            break;

                        case ToothStatusFlags.Implant:
                            Image imageImplant = Image.FromFile("images/implant.jpg");

                            if (row.Key == ToothVerticalPosition.TOP)
                            {
                                imageImplant.RotateFlip(RotateFlipType.RotateNoneFlipY);
                            }

                            button.BackgroundImage = imageImplant;

                            break;
                    }
                }
            }

            tabControl1.Invalidate();
        }

        private void tabPageTeeth_Paint(object sender, PaintEventArgs e)
        {
            Pen penSplitter = new Pen(PEN_SPLITTER_COLOR);
            penSplitter.DashStyle = DashStyle.Dot;

            Button[] btnTop = _teeth[ToothVerticalPosition.TOP];
            Button[] btnBottom = _teeth[ToothVerticalPosition.BOTTOM];

            Point pointTop = new Point((btnTop[7].Location.X + btnTop[7].Width + btnTop[8].Location.X) / 2, btnTop[7].Location.Y);

            Point pointBottom = new Point(pointTop.X, btnBottom[7].Location.Y + btnBottom[7].Height);

            Point pointLeft = new Point(btnTop[0].Location.X, (btnTop[0].Location.Y + btnTop[0].Height + btnBottom[0].Location.Y) / 2);

            Point pointRight = new Point(btnTop[15].Location.X + btnTop[15].Width, pointLeft.Y);

            e.Graphics.DrawLine(penSplitter, pointTop, pointBottom);
            e.Graphics.DrawLine(penSplitter, pointLeft, pointRight);

            penSplitter.Dispose();

            if (_lines != null)
            {
                Pen penBridge = new Pen(PEN_BRIDGE_COLOR, PEN_BRIDGE_WIDTH);

                foreach (var row in _lines)
                {
                    for (int i = 0; i < row.Length - 1; i++)
                    {
                        e.Graphics.DrawLine(penBridge, row[i], row[i + 1]);
                    }
                }

                penBridge.Dispose();
            }
        }

        #region ContextMenuStrip Events

        private void btnGizleGoster_Click(object sender, EventArgs e)
        {
            Button button = _teeth[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];
            ToothStatusFlags flags = _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];

            if (flags == ToothStatusFlags.Hidden)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex] = ToothStatusFlags.Normal;
            }
            else if (flags == ToothStatusFlags.Normal)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex] = ToothStatusFlags.Hidden;
            }

            RenderTooth();
        }

        private void btnImplant_Click(object sender, EventArgs e)
        {
            Button button = _teeth[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];
            ToothStatusFlags flags = _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];

            if (flags == ToothStatusFlags.Implant)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex] = ToothStatusFlags.Normal;
            }
            else if (flags == ToothStatusFlags.Normal)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex] = ToothStatusFlags.Implant;
            }

            RenderTooth();
        }

        private void btnKopruSaga_Click(object sender, EventArgs e)
        {
            Button button = _teeth[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];
            ToothStatusFlags flags = _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex + 1];

            if (flags == ToothStatusFlags.Hidden)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex + 1] = ToothStatusFlags.Bridge;
            }
            else if (flags == ToothStatusFlags.Bridge)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex + 1] = ToothStatusFlags.Hidden;
            }

            RenderTooth();
        }

        private void btnKopruSola_Click(object sender, EventArgs e)
        {
            Button button = _teeth[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex];
            ToothStatusFlags flags = _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex - 1];

            if (flags == ToothStatusFlags.Hidden)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex - 1] = ToothStatusFlags.Bridge;
            }
            else if (flags == ToothStatusFlags.Bridge)
            {
                _flags[_lastSelectedToothVerticalPosition][_lastSelectedToothIndex - 1] = ToothStatusFlags.Hidden;
            }

            RenderTooth();
        }

        #endregion

        private void SaveTeethMap()
        {
            string teethMap = _flags[ToothVerticalPosition.TOP].Aggregate("", (current, flag) => current + (int)flag);
            teethMap += _flags[ToothVerticalPosition.BOTTOM].Aggregate("", (current, flag) => current + (int)flag);

            _patientService.SetTeethMap(_patientId, teethMap);
        }

        private void LoadTreatmentGrid()
        {
            DataTable table = _treatmentService.GetDataTable(_patientId);

            dataGridViewTreatments.DataSource = table;
        }

        private void dataGridViewTreatments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewTreatments.Rows[e.RowIndex];

            int? id = row.Cells["clmTREATMENT_ID"].Value is DBNull ? default(int?) : (int)row.Cells["clmTREATMENT_ID"].Value;
            DateTime date = (DateTime)row.Cells["clmTREATMENT_DATE"].Value;
            string description = row.Cells["clmTREATMENT_DESCRIPTION"].Value is DBNull ? string.Empty : (string)row.Cells["clmTREATMENT_DESCRIPTION"].Value;
            decimal price = (decimal)row.Cells["clmTREATMENT_PRICE"].Value;
            decimal paid = (decimal)row.Cells["clmTREATMENT_PAID"].Value;

            Treatment model = new Treatment()
            {
                ID = id.HasValue ? id.Value : 0,
                PATIENT_ID = _patientId,
                DATE = date,
                DESCRIPTION = description,
                PRICE = (float)price,
                PAID = (float)paid,
            };

            int affectedRows = 0;

            if (!id.HasValue)
            {
                affectedRows = _treatmentService.Insert(model);
            }
            else
            {
                affectedRows = _treatmentService.Update(model);
            }
            
            if (affectedRows == 0)
            {
                MessageBox.Show("Kayıt eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (affectedRows > 1)
            {
                MessageBox.Show("Birden fazla etkilenen satır oldu.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Changed = true;

                LoadTreatmentGrid();
            }
        }

        private void dataGridViewTreatments_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["clmTREATMENT_DATE"].Value = DateTime.Now;
            e.Row.Cells["clmTREATMENT_PRICE"].Value = 0m;
            e.Row.Cells["clmTREATMENT_PAID"].Value = 0m;
        }

        private void FormPatientDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewTreatments.EndEdit();
        }
    }

    public enum ToothVerticalPosition
    {
        TOP,
        BOTTOM
    }

    public enum ToothStatusFlags
    {
        Hidden = 0,
        Normal = 1,
        Filling = 2,
        Bridge = 4,
        Implant = 8
    }
}
