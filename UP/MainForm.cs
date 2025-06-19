using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP
{

    public partial class MainForm : Form
    {
        protected List<MonteCarloPoint> monteCarloPoints = new List<MonteCarloPoint>();

        public MainForm()
        {
            InitializeComponent();
        }

        private double CalculateFormulaArea(double x0, double y0, double R, double C, string direction)
        {
            double d = direction == "Вертикальная" ? Math.Abs(C - x0) : Math.Abs(C - y0);

            if (d >= R)
            {
                return d > R ? 0 : Math.PI * R * R / 2;
            }

            double segmentArea = R * R * Math.Acos(d / R) - d * Math.Sqrt(R * R - d * d);

            return Math.PI * R * R - segmentArea;
        }

        private double CalculateMonteCarloArea(double x0, double y0, double R, double C, string direction, int N)
        {
            if (N <= 0 || R <= 0) return 0;

            Random rand = new Random();
            int K = 0;
            double squareArea = 4 * R * R;

            for (int i = 0; i < N; i++)
            {
                double x = x0 - R + 2 * R * rand.NextDouble();
                double y = y0 - R + 2 * R * rand.NextDouble();

                if (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) > R * R) continue;

                bool isInSegment = direction == "Вертикальная" ? (x >= C) : (y >= C);
                if (isInSegment) K++;

                monteCarloPoints.Add(new MonteCarloPoint(x, y, isInSegment));
            }

            double segmentArea = ((double)K / N) * squareArea;

            double fullCircle = Math.PI * R * R;
            return Math.Max(segmentArea, fullCircle - segmentArea);
        }



        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = double.Parse(x0Box.Text);
                double y0 = double.Parse(y0Box.Text);
                double R = double.Parse(rBox.Text);
                double C = double.Parse(cBox.Text);
                int N = int.Parse(numericUpDown1.Text);

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите направление прямой.");
                    return;
                }

                string direction = comboBox1.SelectedItem.ToString();

                double formulaArea = CalculateFormulaArea(x0, y0, R, C, direction);
                formulaResultLabel.Text = $"Формула: {formulaArea}";

                double monteCarloArea = CalculateMonteCarloArea(x0, y0, R, C, direction, N);
                monteCarloResultLabel.Text = $"Монте-Карло: {monteCarloArea}";

                DatabaseHelper.AddResult(x0, y0, R, C, direction, N, formulaArea, monteCarloArea);

                DrawVisualization(x0, y0, R, C, direction, monteCarloPoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        private void DrawVisualization(double x0, double y0, double R, double C, string direction, List<MonteCarloPoint> points)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float scale = 30f;
            float centerX = pictureBox1.Width / 2;
            float centerY = pictureBox1.Height / 2;

            Pen gridPen = new Pen(Color.LightGray, 1);
            gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            for (float x = centerX; x < pictureBox1.Width; x += scale)
                g.DrawLine(gridPen, x, 0, x, pictureBox1.Height);
            for (float x = centerX - scale; x >= 0; x -= scale)
                g.DrawLine(gridPen, x, 0, x, pictureBox1.Height);
            for (float y = centerY; y < pictureBox1.Height; y += scale)
                g.DrawLine(gridPen, 0, y, pictureBox1.Width, y);
            for (float y = centerY - scale; y >= 0; y -= scale)
                g.DrawLine(gridPen, 0, y, pictureBox1.Width, y);

            Pen axisPen = new Pen(Color.Gray, 1);
            g.DrawLine(axisPen, 0, centerY, pictureBox1.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, pictureBox1.Height);

            Pen circlePen = new Pen(Color.Black, 2);
            g.DrawEllipse(circlePen,
                centerX + (float)(x0 - R) * scale,
                centerY - (float)(y0 + R) * scale,
                (float)(2 * R * scale),
                (float)(2 * R * scale));

            Pen linePen = new Pen(Color.Red, 2);
            if (direction == "Горизонтальная")
            {
                float yLine = centerY - (float)(C * scale);
                g.DrawLine(linePen, 0, yLine, pictureBox1.Width, yLine);
            }
            else
            {
                float xLine = centerX + (float)(C * scale);
                g.DrawLine(linePen, xLine, 0, xLine, pictureBox1.Height);
            }

            foreach (var point in points)
            {
                float px = centerX + (float)(point.X * scale);
                float py = centerY - (float)(point.Y * scale);
                Brush brush = point.InSegment ? Brushes.Red : Brushes.Blue;
                g.FillEllipse(brush, px - 2, py - 2, 3, 3);
            }

            monteCarloPoints.Clear();

            pictureBox1.Image = bmp;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            x0Box.Text = "X0";
            x0Box.ForeColor = Color.Gray;

            y0Box.Text = "Y0";
            y0Box.ForeColor = Color.Gray;

            rBox.Text = "R";
            rBox.ForeColor = Color.Gray;

            cBox.Text = "C";
            cBox.ForeColor = Color.Gray;

            x0Box.Enter += x0Box_Enter;
            x0Box.Leave += x0Box_Leave;

            y0Box.Enter += y0Box_Enter;
            y0Box.Leave += y0Box_Leave;

            rBox.Enter += rBox_Enter;
            rBox.Leave += rBox_Leave;

            cBox.Enter += cBox_Enter;
            cBox.Leave += cBox_Leave;

            comboBox1.Items.Add("Вертикальная");
            comboBox1.Items.Add("Горизонтальная");

            DatabaseHelper.InitializeDatabase();
        }
        private void x0Box_Enter(object sender, EventArgs e)
        {
            if (x0Box.Text == "X0")
            {
                x0Box.Text = "";
                x0Box.ForeColor = Color.Black;
            }
        }

        private void x0Box_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(x0Box.Text))
            {
                x0Box.Text = "X0";
                x0Box.ForeColor = Color.Gray;
            }
        }

        private void y0Box_Enter(object sender, EventArgs e)
        {
            if (y0Box.Text == "Y0")
            {
                y0Box.Text = "";
                y0Box.ForeColor = Color.Black;
            }
        }

        private void y0Box_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(y0Box.Text))
            {
                y0Box.Text = "Y0";
                y0Box.ForeColor = Color.Gray;
            }
        }

        private void rBox_Enter(object sender, EventArgs e)
        {
            if (rBox.Text == "R")
            {
                rBox.Text = "";
                rBox.ForeColor = Color.Black;
            }
        }

        private void rBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rBox.Text))
            {
                rBox.Text = "R";
                rBox.ForeColor = Color.Gray;
            }
        }

        private void cBox_Enter(object sender, EventArgs e)
        {
            if (cBox.Text == "C")
            {
                cBox.Text = "";
                cBox.ForeColor = Color.Black;
            }
        }

        private void cBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBox.Text))
            {
                cBox.Text = "C";
                cBox.ForeColor = Color.Gray;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            x0Box.Clear();
            y0Box.Clear();
            rBox.Clear();   
            cBox.Clear();

            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = -1;
            }

            numericUpDown1.Value = 0;
            pictureBox1.Image = null;

            x0Box.Text = "X0";
            x0Box.ForeColor = Color.Gray;

            y0Box.Text = "Y0";
            y0Box.ForeColor = Color.Gray;

            rBox.Text = "R";
            rBox.ForeColor = Color.Gray;

            cBox.Text = "C";
            cBox.ForeColor = Color.Gray;

            formulaResultLabel.Clear();
            monteCarloResultLabel.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new Form())
            {
                inputForm.Text = "Загрузка записи";
                inputForm.Size = new Size(300, 150);
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.StartPosition = FormStartPosition.CenterParent;
                var label = new Label
                {
                    Text = "Введите ID:",
                    Left = 10,
                    Top = 20,
                    Width = 80
                };

                var textBox = new System.Windows.Forms.TextBox
                {
                    Left = 100,
                    Top = 20,
                    Width = 150
                };

                var okButton = new System.Windows.Forms.Button
                {
                    Text = "Загрузить",
                    Left = 100,
                    Top = 60,
                    Width = 80,
                    DialogResult = DialogResult.OK
                };

                inputForm.Controls.Add(label);
                inputForm.Controls.Add(textBox);
                inputForm.Controls.Add(okButton);
                inputForm.AcceptButton = okButton;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(textBox.Text, out int id))
                    {
                        DataRow row = DatabaseHelper.GetResultById(id);

                        if (row != null)
                        {
                            x0Box.Text = row["X0"].ToString();
                            y0Box.Text = row["Y0"].ToString();
                            rBox.Text = row["R"].ToString();
                            cBox.Text = row["C"].ToString();
                            comboBox1.SelectedItem = row["Direction"].ToString();

                            double x0 = double.Parse(x0Box.Text);
                            double y0 = double.Parse(y0Box.Text);
                            double R = double.Parse(rBox.Text);
                            double C = double.Parse(cBox.Text);
                            string direction = comboBox1.SelectedItem.ToString();

                            numericUpDown1.Value = Convert.ToDecimal(row["N"]);
                            int N = (int)numericUpDown1.Value;

                            formulaResultLabel.Text = "Формула: " + row["FormulaResult"].ToString();
                            monteCarloResultLabel.Text = "Монте-Карло: " + row["MonteCarloResult"].ToString();

                            CalculateMonteCarloArea(x0, y0, R, C, direction, N);

                            DrawVisualization(x0, y0, R, C, direction, monteCarloPoints);
                        }
                        else
                        {
                            MessageBox.Show("Запись не найдена!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректный ID!");
                    }
                }
            }
        }

        private void toolAnalisys_Click(object sender, EventArgs e)
        {
            AnalysisForm form = new AnalysisForm();
            form.ShowDialog();
        }
    }
}
