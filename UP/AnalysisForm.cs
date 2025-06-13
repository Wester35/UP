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

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series = new Series("Разница")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue
            };
            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "№";
            chart1.ChartAreas[0].AxisY.Title = "Разница";

            var data_ = DatabaseHelper.GetAllResultsForAnalys();
            foreach (var entry in data_)
            {
                chart1.Series[0].Points.AddXY(entry.Id, entry.Difference);
            }
        }
    }
}
