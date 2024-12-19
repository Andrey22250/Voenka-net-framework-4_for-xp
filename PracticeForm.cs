using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using voenka.Model;

namespace voenka
{
    public partial class PracticeForm : Form
    {
        private bool isStudyMode;
        private bool _isAnswerGiven = false;
        private bool isAnswerGiven
        {
            get
            {
                return _isAnswerGiven;
            }
            set
            {
                _isAnswerGiven = value;
                IsAnswerGivenChanged(value);
            }
        }

        private List<PracticeQuestionModel> questions;
        private PracticeQuestionModel currentQuestion;
        private int currentQuestionIndex = -1;
        private int chosenOptionIndex = 1;

        private bool isTestCompleted = false;
        private bool isWrong = false;

        private bool closeForm = false;

        public PracticeForm(bool isStudyMode)
        {
            InitializeComponent();
            LoadQuestions("practice_data_encrypted.json");

            this.lblCounter.Text = "0";
            this.isStudyMode = isStudyMode; // определение, в каком режиме практическая форма

            NextQuestionActions();
        }

        //private void LoadQuestions(string filePath)
        //{
        //    var json = File.ReadAllText(filePath);
        //    questions = JsonSerializer.Deserialize<List<PracticeQuestionModel>>(json);
        //}

        private void LoadQuestions(string encryptedFilePath)
        {
            var decryptedJson = FileEncryptor.DecryptFile(encryptedFilePath);
            questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PracticeQuestionModel>>(decryptedJson);
        }

        private void NextQuestionActions()
        {
            if (++currentQuestionIndex < questions.Count) // шаги не закончились
            {
                currentQuestion = questions[currentQuestionIndex];
                isAnswerGiven = false;
                UpdateQuestionDetails();
            }
            else // шаги закончились
            {
                MessageBox.Show("Шаги закончились!");
            }
        }

        private void UpdateQuestionDetails()
        {
            lblCounter.Text = Convert.ToString(Convert.ToInt32(lblCounter.Text) + 1);
            lblStepName.Text = currentQuestion.StepName;
            lblQuestion.Text = currentQuestion.Question;
            radioButton1.Text = currentQuestion.Options[0];
            radioButton2.Text = currentQuestion.Options[1];
            radioButton3.Text = currentQuestion.Options[2];
            lblDescription.Text = currentQuestion.Description;
            panelDescription.Controls.Add(lblDescription);
            Image mainImage;
            try
            {
                mainImage = Image.FromFile(currentQuestion.MainImagePath);
                pictureBox.Image = mainImage;
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла критическая ошибка при загрузке изображения!\n" + e.Message);
            }

            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = true;
        }

        private void IsAnswerGivenChanged(bool isAnswerGiven)
        {
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButton1, radioButton2, radioButton3 };

            if (isAnswerGiven)
            {
                if (currentQuestionIndex + 1 == questions.Count) // был ли это последний вопрос
                {
                    buttonAccept.Visible = false;
                    buttonFinish.Location = buttonAccept.Location;

                    isTestCompleted = true;
                }

                groupBoxOptions.Location = new Point(groupBoxOptions.Location.X, 278);
                groupBoxDescription.Visible = true;
                buttonAccept.Text = "Следующий шаг";

                string actionImagePath = currentQuestion.ActionImagePath;
                if (actionImagePath != null)
                {
                    try
                    {
                        Image actionImage = Image.FromFile(actionImagePath);
                        pictureBox.Image = actionImage;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Произошла критическая ошибка при загрузке изображения!\n" + e.Message);
                    }
                }

                lblYourAnswerHeader.Visible = true;
                lblYourAnswerRight.Visible = true;
                bool isAnswerRight = chosenOptionIndex == currentQuestion.AnswerIndex;
                lblYourAnswerRight.Text = isAnswerRight ? "правильный" : "неправильный";
                lblYourAnswerRight.ForeColor = isAnswerRight ? Color.Green : Color.Red;

                foreach (var radioButton in radioButtons)
                {
                    //radioButton.Enabled = false; // деактивировать элемент

                    int radioButtonIndex = Convert.ToInt32(radioButton.Tag);
                    if (radioButtonIndex == chosenOptionIndex)
                    {
                        if (isAnswerRight)
                            radioButton.ForeColor = Color.Green;
                        else
                            radioButton.ForeColor = Color.Red;
                    }

                    else if (!isAnswerRight && radioButtonIndex == currentQuestion.AnswerIndex)
                        radioButton.ForeColor = Color.Green;
                }
            }
            else
            {
                groupBoxOptions.Location = new Point(groupBoxOptions.Location.X, 451);
                groupBoxDescription.Visible = false;
                buttonAccept.Text = "Подтвердить ответ";

                lblYourAnswerHeader.Visible = false;
                lblYourAnswerRight.Visible = false;

                foreach (var radioButton in radioButtons)
                {
                    radioButton.ForeColor = SystemColors.ControlText;
                    //radioButton.Enabled = true; // активировать элемент
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (isAnswerGiven) // если ответ уже дан, то состояние радиобаттонов не будет меняться
            {
                int radioButtonIndex = Convert.ToInt32(radioButton.Tag);
                radioButton.Checked = chosenOptionIndex == radioButtonIndex;
            }
            else
            {
                if (radioButton.Checked) // меняем индекс выбранного радиобаттона
                {
                    chosenOptionIndex = Convert.ToInt32(radioButton.Tag);
                }
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!isAnswerGiven) // проверка и соответствующие действия
            {
                bool isAnswerRight = chosenOptionIndex == currentQuestion.AnswerIndex; // правильный ли дан ответ

                if (!isAnswerRight) // ответ неверный
                {
                    if (isStudyMode) // учебный режим
                    {
                        MessageBox.Show("Ответ неверный! Смотри описание.");
                        isAnswerGiven = true;
                    }
                    else // тестовый режим
                    {
                        MessageBox.Show("Ответ неверный! Вы не сдали.");
                        isWrong = true;
                        closeForm = true;
                        this.DialogResult = DialogResult.No;
                        this.Close();
                    }
                }
                else // ответ верный
                {
                    isAnswerGiven = true;
                }
            }
            else // переход к следующему шагу
            {
                NextQuestionActions();
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (isTestCompleted)
            {
                this.DialogResult = DialogResult.Yes;

                if (isStudyMode)
                {
                    MessageBox.Show("Запуск генератора успешно произведен! Удачи в тестовом режиме!");
                }

                this.Close();
            }
            else // тест не завершен
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Вы не завершили тест. Вы точно хотите завершить тест?",
                    "Вы уверены?",
                    MessageBoxButtons.YesNo
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    closeForm = true;
                    this.Close();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (closeForm)
            {
                base.OnFormClosing(e);
            }
            else
            {
                // если тестовый режим и тест был завершен, но форма закрыта на крестик
                if (!isStudyMode)
                {
                    if (!isTestCompleted)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                        "Вы не завершили тест. Вы точно хотите завершить тест?",
                        "Вы уверены?",
                        MessageBoxButtons.YesNo
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            this.DialogResult = DialogResult.Cancel;
                            closeForm = true;
                            this.Close();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else if (isTestCompleted)
                        this.DialogResult = DialogResult.Yes;
                    else if (isWrong)
                        this.DialogResult = DialogResult.No;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }

                base.OnFormClosing(e);
            }
        }

        private void PracticeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!isStudyMode && !isTestCompleted)
            //{
                
            //}
        }
    }
}
