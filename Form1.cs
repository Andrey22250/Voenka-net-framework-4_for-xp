using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace voenka
{
    public partial class Form1 : Form
    {
        private const int CORRECT_ANSWERS_MINIMUM = 6; // минимум правильных ответов в тесте для перехода к практике
        bool drag = false;
        Point Start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent(); 
        }

        private void btnStudyMode_Click(object sender, EventArgs e)
        {
            this.Hide();

            bool goToPractice = false;
            using (var studyForm = new StudyForm())
            {
                var result = studyForm.ShowDialog(); // РћС‚РєСЂС‹РІР°РµРј С„РѕСЂРјСѓ "РћР±СѓС‡РµРЅРёРµ"
                goToPractice = result == DialogResult.OK ? true : false;
            }

            if (goToPractice)
            {
                var practiceForm = new PracticeForm(true);
                practiceForm.ShowDialog();
            }

            this.Show(); // Возврат в начальную форму
        }

        private void btnTestMode_Click(object sender, EventArgs e)
        {
            this.Hide();

            // открыть форму с тестом по теории
            using (var testForm = new TestForm())
            {
                var result = testForm.ShowDialog();

                if (result == DialogResult.OK && testForm.TestResults != null)
                {
                    var testResults = testForm.TestResults;

                    // Подсчитываем правильные ответы
                    int correctAnswers = testResults.Count(r => r.IsCorrect);
                    string baseMessage = $"Количество правильных ответов: {correctAnswers}\n";

                    if (correctAnswers >= CORRECT_ANSWERS_MINIMUM) // Минимальный порог для прохождения
                    {

                        MessageBox.Show(baseMessage + "Вы сдали тест! Переход в практический режим.");

                        // Логика открытия практической формы
                        var practiceForm = new PracticeForm(false);
                        var practiceFormResult = practiceForm.ShowDialog();

                        ResultForm resultForm;

                        switch (practiceFormResult)
                        {
                            case DialogResult.Yes:
                                // запуск формы с результатом "Сдал"
                                resultForm = new ResultForm(true);
                                resultForm.ShowDialog();
                                break;
                            case DialogResult.No:
                                // запуск формы с результатом "Не сдал"
                                resultForm = new ResultForm(false);
                                resultForm.ShowDialog();
                                break;
                            case DialogResult.Cancel:
                                // никаких действий не нужно
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(baseMessage + "Вы не сдали тест!");

                        // запуск формы с результатом "Не сдал"
                        var resultForm = new ResultForm(false);
                        resultForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Тест был отменен.");
                }
            }

            // если тестовая форма была закрыта без завершения теста то ничего не предпринимать
            // если тест был пройден и было меньше 40% правильных ответов то сразу вызвать результат "Не сдан";
            // практическую форму не запускать
            // если тест был пройден на >=40% правильных ответов, запустить практическую форму 

            this.Show(); // временная хуйня
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            Start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_point.X, p.Y - Start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
