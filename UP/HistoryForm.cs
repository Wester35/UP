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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        // Событие загрузки формы HistoryForm
        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных из БД в таблицу
            dataGridView1.DataSource = DatabaseHelper.GetAllResults();

            // Автоматическое масштабирование колонок по ширине
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Установка режима выбора всей строки
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Только для чтения, редактирование запрещено
            dataGridView1.ReadOnly = true;
        }

        // Обработчик кнопки Удалить все записи
        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            // Подтверждение от пользователя
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить ВСЕ записи? Это действие нельзя отменить.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Удаление всех записей из базы данных
                DatabaseHelper.DeleteAllResult();

                // Уведомление об успешном удалении
                MessageBox.Show("Все записи успешно удалены.", "Успех");

                // Обновление отображаемой таблицы
                dataGridView1.DataSource = DatabaseHelper.GetAllResults();
            }
        }

        // Обработчик кнопки Удалить по ID
        private void deleteIDButton_Click(object sender, EventArgs e)
        {
            // Создание вспомогательной формы для ввода ID
            using (var form = new Form())
            {
                form.Text = "Удаление по ID";
                form.Size = new Size(300, 150);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.MinimizeBox = false;
                form.MaximizeBox = false;

                // Элементы управления формы
                var label = new Label { Text = "Введите ID:", Left = 10, Top = 20, Width = 80 };
                var textBox = new System.Windows.Forms.TextBox { Left = 100, Top = 20, Width = 150 };
                var okButton = new System.Windows.Forms.Button { Text = "Удалить", Left = 100, Top = 60, Width = 80, DialogResult = DialogResult.OK };

                // Добавление элементов на форму
                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);

                // Установка кнопки Удалить в качестве кнопки по Enter
                form.AcceptButton = okButton;

                // Показ формы и обработка нажатия Удалить
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Проверка корректности ввода ID
                    if (int.TryParse(textBox.Text, out int id))
                    {
                        // Подтверждение удаления записи с указанным ID
                        DialogResult confirm = MessageBox.Show(
                            $"Вы действительно хотите удалить запись с ID {id}?",
                            "Подтверждение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirm == DialogResult.Yes)
                        {
                            // Удаление записи
                            DatabaseHelper.DeleteResult(id);

                            // Уведомление об успешном удалении
                            MessageBox.Show($"Запись с ID {id} удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Обновление таблицы после удаления
                            dataGridView1.DataSource = DatabaseHelper.GetAllResults();
                        }
                    }
                    else
                    {
                        // Ошибка при некорректном вводе
                        MessageBox.Show("Некорректный ID! Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
