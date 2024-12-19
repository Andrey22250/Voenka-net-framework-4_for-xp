using System.Drawing;
using System.Windows.Forms;

namespace voenka
{
    partial class PracticeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblStepName = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblYourAnswerHeader = new System.Windows.Forms.Label();
            this.lblYourAnswerRight = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Мастерская_тестирование.Properties.Resources.Фото_салона_сбоку;
            this.pictureBox.Location = new System.Drawing.Point(10, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(657, 652);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblStepName
            // 
            this.lblStepName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblStepName.Location = new System.Drawing.Point(763, 13);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(488, 71);
            this.lblStepName.TabIndex = 1;
            this.lblStepName.Text = "Текст текущего шага";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.panel1);
            this.groupBoxOptions.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxOptions.Location = new System.Drawing.Point(763, 451);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(488, 160);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Варианты ответа:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 123);
            this.panel1.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(150, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "testtesttesttest";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "testtesttesttest";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "testtesttesttest";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonFinish.Location = new System.Drawing.Point(763, 617);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(167, 50);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "Завершить тест";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAccept.Location = new System.Drawing.Point(1085, 619);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(167, 50);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Подтвердить ответ";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblQuestion.Location = new System.Drawing.Point(763, 84);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(488, 166);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Текст вопроса для текущего шага";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.panelDescription);
            this.groupBoxDescription.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxDescription.Location = new System.Drawing.Point(764, 451);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(488, 160);
            this.groupBoxDescription.TabIndex = 6;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Ответ";
            this.groupBoxDescription.Visible = false;
            // 
            // panelDescription
            // 
            this.panelDescription.AutoScroll = true;
            this.panelDescription.Controls.Add(this.lblDescription);
            this.panelDescription.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panelDescription.Location = new System.Drawing.Point(6, 31);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(465, 119);
            this.panelDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(445, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "label1";
            // 
            // lblYourAnswerHeader
            // 
            this.lblYourAnswerHeader.AutoSize = true;
            this.lblYourAnswerHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourAnswerHeader.Location = new System.Drawing.Point(1008, 630);
            this.lblYourAnswerHeader.Name = "lblYourAnswerHeader";
            this.lblYourAnswerHeader.Size = new System.Drawing.Size(66, 15);
            this.lblYourAnswerHeader.TabIndex = 7;
            this.lblYourAnswerHeader.Text = "Ваш ответ:";
            this.lblYourAnswerHeader.Visible = false;
            // 
            // lblYourAnswerRight
            // 
            this.lblYourAnswerRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYourAnswerRight.Location = new System.Drawing.Point(980, 645);
            this.lblYourAnswerRight.Name = "lblYourAnswerRight";
            this.lblYourAnswerRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYourAnswerRight.Size = new System.Drawing.Size(94, 15);
            this.lblYourAnswerRight.TabIndex = 8;
            this.lblYourAnswerRight.Text = "правильный?";
            this.lblYourAnswerRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblYourAnswerRight.Visible = false;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCounter.Location = new System.Drawing.Point(943, 639);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(19, 15);
            this.lblCounter.TabIndex = 9;
            this.lblCounter.Text = "10";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(958, 639);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "/17";
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblYourAnswerRight);
            this.Controls.Add(this.lblYourAnswerHeader);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.lblStepName);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PracticeForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая часть";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Label lblStepName;
        private GroupBox groupBoxOptions;
        private Button buttonFinish;
        private Button buttonAccept;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lblQuestion;
        private GroupBox groupBoxDescription;
        private Label lblYourAnswerHeader;
        private Label lblYourAnswerRight;
        private Panel panelDescription;
        private Label lblDescription;
        private Panel panel1;
        private Label lblCounter;
        private Label label2;
    }
}