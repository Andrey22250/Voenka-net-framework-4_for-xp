using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voenka
{
    public partial class StudyForm : Form
    {
        public StudyForm()
        {
            InitializeComponent();
            LoadDynamicContent("content.txt");
        }

        private void LoadDynamicContent(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Файл контента не найден.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var panel = panelContent;

            int xOffset = 0; // Горизонтальное смещение
            int yOffset = 20; // Вертикальное смещение
            int maxWidth = panel.Width - 20; // Максимальная ширина текста, с учетом отступов

            foreach (var line in lines)
            {
                if (line.StartsWith("#"))
                {
                    // Заголовок
                    var label = new Label
                    {
                        Text = line.TrimStart('#').Trim(),
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        AutoSize = true,
                        MaximumSize = new Size(maxWidth, 0), // Ограничиваем ширину
                        Location = new Point(xOffset, yOffset)
                    };
                    panel.Controls.Add(label);
                    yOffset += label.Height + 10;
                }
                else if (line.StartsWith("[image:"))
                {
                    // Изображение
                    string imagePath = line.Substring(7).TrimEnd(']');
                    if (File.Exists(imagePath))
                    {
                        var pictureBox = new PictureBox
                        {
                            Image = Image.FromFile(imagePath),
                            SizeMode = PictureBoxSizeMode.AutoSize,
                            MaximumSize = new Size(maxWidth, 0),
                            Location = new Point(xOffset, yOffset)
                        };
                        panel.Controls.Add(pictureBox);
                        yOffset += pictureBox.Height + 10;
                    }
                }
                else
                {
                    // Обычный текст
                    var label = new Label
                    {
                        Text = line,
                        Font = new Font("Arial", 12),
                        AutoSize = true,
                        MaximumSize = new Size(maxWidth, 0), // Ограничиваем ширину
                        Location = new Point(xOffset, yOffset)
                    };
                    panel.Controls.Add(label);
                    yOffset += label.Height + 10;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Обработка закрытия формы через крестик
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None) // Если результат не был установлен кнопками
            {
                this.DialogResult = DialogResult.Cancel; // Устанавливаем "Отмена"
            }
            base.OnFormClosing(e);
        }
    }
}
