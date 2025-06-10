using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView1.DataSource = DatabaseHelper.GetAllResults();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить ВСЕ записи? Это действие нельзя отменить.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteAllResult();
                MessageBox.Show("Все записи успешно удалены.", "Успех");
            }
        }

        private void deleteIDButton_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                form.Text = "Удаление по ID";
                form.Size = new Size(300, 150);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.MinimizeBox = false;
                form.MaximizeBox = false;

                var label = new Label { Text = "Введите ID:", Left = 10, Top = 20, Width = 80 };
                var textBox = new TextBox { Left = 100, Top = 20, Width = 150 };
                var okButton = new Button { Text = "Удалить", Left = 100, Top = 60, Width = 80, DialogResult = DialogResult.OK };

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);

                form.AcceptButton = okButton;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(textBox.Text, out int id))
                    {
                        DialogResult confirm = MessageBox.Show(
                            $"Вы действительно хотите удалить запись с ID {id}?",
                            "Подтверждение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirm == DialogResult.Yes)
                        {
                            DatabaseHelper.DeleteResult(id);
                            MessageBox.Show($"Запись с ID {id} удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dataGridView1.DataSource = DatabaseHelper.GetAllResults();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректный ID! Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
