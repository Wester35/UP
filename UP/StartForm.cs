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
    public partial class StartForm : Form
    {
        // Конструктор формы запуска
        public StartForm()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаём экземпляр основной формы приложения
            var newForm = new MainForm();

            // Подписываемся на событие закрытия основной формы: при закрытии показываем стартовую форму снова
            newForm.FormClosed += (s, args) => this.Show();

            // Показываем основную форму
            newForm.Show();

            // Скрываем стартовую форму
            this.Hide();
        }
    }
}
