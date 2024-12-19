using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using voenka.Model;

namespace voenka
{
    public partial class TestForm : Form
    {
        private const string QUESTIONS_FILE_NAME = "test_data_encrypted.json";
        private const bool NEED_TO_RANDOMIZE_QUESTIONS = true;

        private List<QuestionModel> _questions;
        private List<TestResult> _results;

        public List<TestResult> TestResults { get; private set; }
        private bool _isTestCompleted;

        public TestForm()
        {
            InitializeComponent();

            LoadQuestions(QUESTIONS_FILE_NAME);
            GenerateQuestionControls();
        }

        private void LoadQuestions(string encryptedFilePath)
        {
            var decryptedJson = FileEncryptor.DecryptFile(encryptedFilePath);
            _questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<QuestionModel>>(decryptedJson);

            // Перемешиваем вопросы, если необходимо
            if (NEED_TO_RANDOMIZE_QUESTIONS)
            {
                var rng = new Random();
                _questions = _questions.OrderBy(_ => rng.Next()).ToList();

            }

            // Инициализируем результаты
            _results = _questions.Select(q => new TestResult { SelectedIndex = -1 }).ToList();
        }

        private void GenerateQuestionControls()
        {
            // Создаем панель для прокрутки
            var scrollPanel = new Panel
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - 100), // Панель занимает почти всю форму
                AutoScroll = true // Включаем автоскроллинг
            };

            this.Controls.Add(scrollPanel);

            int y = 10;

            foreach (var question in _questions)
            {
                // Заголовок вопроса
                var lblQuestion = new Label
                {
                    Text = question.Question,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    MaximumSize = new System.Drawing.Size(scrollPanel.Width - 40, 0),
                    Location = new System.Drawing.Point(10, y)
                };
                scrollPanel.Controls.Add(lblQuestion);
                y += lblQuestion.Size.Height; // Отступ после заголовка

                // Группа радио-кнопок
                var groupBox = new GroupBox
                {
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true,
                    Size = new System.Drawing.Size(scrollPanel.Width - 40, 100)
                };

                int optionY = 20; // Начальная позиция внутри groupBox
                foreach (var option in question.Options.Select((text, index) => (text, index)))
                {
                    var radioButton = new RadioButton
                    {
                        Text = option.text,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12),
                        Location = new System.Drawing.Point(10, optionY),
                        MaximumSize = new System.Drawing.Size(groupBox.Size.Width - 20, 0),
                        MinimumSize = new System.Drawing.Size(groupBox.Size.Width - 20, 46),
                        Tag = (Question: question, OptionIndex: option.index) // Сохраняем информацию о вопросе и индексе
                    };
                    radioButton.CheckedChanged += RadioButton_CheckedChanged;
                    groupBox.Controls.Add(radioButton);
                    optionY += radioButton.Size.Height + 5; // Отступ между радио-кнопками
                }

                scrollPanel.Controls.Add(groupBox);
                y += groupBox.Size.Height + 20; // Отступ после группы
            }

            // Кнопка "Отмена"
            var btnCancel = new Button
            {
                Text = "Отмена",
                Font = new Font("Segoe UI", 16),
                Size = new System.Drawing.Size(140, 40),
                Location = new System.Drawing.Point(10, this.ClientSize.Height - 50)
            };
            btnCancel.Click += (s, e) => CancelTest();

            // Кнопка "Завершить тест"
            var btnFinish = new Button
            {
                Text = "Завершить тест",
                Font = new Font("Segoe UI", 16),
                Size = new System.Drawing.Size(140, 40),
                Location = new System.Drawing.Point(160, this.ClientSize.Height - 50)
            };
            btnFinish.Click += (s, e) => FinishTest();

            this.Controls.Add(btnCancel);
            this.Controls.Add(btnFinish);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                var (question, optionIndex) = ((QuestionModel, int))radioButton.Tag;
                var questionIndex = _questions.IndexOf(question);
                _results[questionIndex].SelectedIndex = optionIndex;
            }
        }

        private void FinishTest()
        {
            // Проверяем, все ли вопросы отвечены
            if (_results.Any(r => r.SelectedIndex == -1))
            {
                MessageBox.Show("Не все вопросы имеют ответы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подсчитываем правильные ответы
            for (int i = 0; i < _questions.Count; i++)
            {
                _results[i].IsCorrect = _results[i].SelectedIndex == _questions[i].AnswerIndex;
            }

            int correctAnswers = _results.Count(r => r.IsCorrect);

            // Выводим количество правильных ответов
            //MessageBox.Show($"Количество правильных ответов: {correctAnswers}", "Результаты");

            _isTestCompleted = true;
            TestResults = _results;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelTest()
        {
            _isTestCompleted = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!_isTestCompleted)
            {
                TestResults = null;
                this.DialogResult = DialogResult.Cancel;
            }

            base.OnFormClosing(e);
        }
    }
}
