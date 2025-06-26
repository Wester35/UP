using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UP
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        // Обработчик события загрузки формы
        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            // Очищаем предыдущие серии данных на графике (если есть)
            chart1.Series.Clear();

            // Создаем новую серию данных для отображения разницы
            var series = new Series("Разница")
            {
                ChartType = SeriesChartType.Column, // Тип диаграммы: столбчатая
                Color = Color.SteelBlue              // Цвет столбцов
            };

            // Добавляем серию на график
            chart1.Series.Add(series);

            // Устанавливаем подписи осей
            chart1.ChartAreas[0].AxisX.Title = "№";            // По оси X — ID или номер опыта
            chart1.ChartAreas[0].AxisY.Title = "Разница";      // По оси Y — разница между методами

            // Получаем данные для анализа из базы данных
            var data_ = DatabaseHelper.GetAllResultsForAnalys();

            // Заполняем график точками на основе полученных данных
            foreach (var entry in data_)
            {
                chart1.Series[0].Points.AddXY(entry.Id, entry.Difference);
            }
        }
    }
}
