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
        public MainForm()
        {
            InitializeComponent();
        }

        private double CalculateFormulaArea(double x0, double y0, double R, double C, string direction)
        {
            double area = 0;
            if (direction == "Вертикальная")
            {
                double dx = C - x0;
                if (Math.Abs(dx) < R)
                {
                    area = Math.PI * R * R - (R * R * Math.Acos(dx / R) - dx * Math.Sqrt(R * R - dx * dx));
                }
            }
            else if (direction == "Горизонтальная")
            {
                double dy = C - y0;
                if (Math.Abs(dy) < R)
                {
                    area = Math.PI * R * R - (R * R * Math.Acos(dy / R) - dy * Math.Sqrt(R * R - dy * dy));
                }
            }
            return area;
        }

        private double CalculateMonteCarloArea(double x0, double y0, double R, double C, string direction, int N)
        {
            Random rand = new Random();
            int K = 0;
            for (int i = 0; i < N; i++)
            {
                double x = x0 - R + 2 * R * rand.NextDouble();
                double y = y0 - R + 2 * R * rand.NextDouble();

                double dist = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
                if (dist <= R)
                {
                    if (direction == "Вертикальная" && x >= C)
                        K++;
                    if (direction == "Горизонтальная" && y >= C)
                        K++;
                }
            }

            double squareArea = 4 * R * R;
            return ((double)K / N) * squareArea;
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

                DrawVisualization(x0, y0, R, C, direction);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        private void DrawVisualization(double x0, double y0, double R, double C, string direction)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float scale = 30f;
            float centerX = pictureBox1.Width / 2;
            float centerY = pictureBox1.Height / 2;

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
            AnalysisForm form = new AnalysisForm();
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
                            formulaResultLabel.Text = "Формула: " + row["FormulaResult"].ToString();
                            monteCarloResultLabel.Text = "Монте-Карло: " + row["MonteCarloResult"].ToString();

                            DrawVisualization(x0, y0, R, C, direction);
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
    }
}
