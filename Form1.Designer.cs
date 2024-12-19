

using System.Drawing;
using System.Windows.Forms;

namespace voenka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudyMode = new System.Windows.Forms.Button();
            this.btnTestMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(13, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1159, 51);
            label1.TabIndex = 0;
            label1.Text = "Выберите режим работы программы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStudyMode
            // 
            btnStudyMode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStudyMode.BackColor = Color.FromArgb(45, 45, 45);
            btnStudyMode.BackgroundImageLayout = ImageLayout.None;
            btnStudyMode.FlatAppearance.BorderSize = 0;
            btnStudyMode.FlatStyle = FlatStyle.Flat;
            btnStudyMode.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudyMode.ForeColor = SystemColors.ButtonFace;
            btnStudyMode.Location = new Point(138, 290);
            btnStudyMode.Margin = new Padding(4, 5, 4, 5);
            btnStudyMode.Name = "btnStudyMode";
            btnStudyMode.Size = new Size(370, 90);
            btnStudyMode.TabIndex = 1;
            btnStudyMode.Text = "Учебный режим";
            btnStudyMode.UseVisualStyleBackColor = false;
            btnStudyMode.Click += btnStudyMode_Click;
            // 
            // btnTestMode
            // 
            btnTestMode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTestMode.BackColor = Color.FromArgb(45, 45, 45);
            btnTestMode.FlatAppearance.BorderSize = 0;
            btnTestMode.FlatStyle = FlatStyle.Flat;
            btnTestMode.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTestMode.ForeColor = SystemColors.ButtonFace;
            btnTestMode.Location = new Point(699, 290);
            btnTestMode.Margin = new Padding(4, 5, 4, 5);
            btnTestMode.Name = "btnTestMode";
            btnTestMode.Size = new Size(370, 90);
            btnTestMode.TabIndex = 2;
            btnTestMode.Text = "Тестовый режим";
            btnTestMode.UseVisualStyleBackColor = false;
            btnTestMode.Click += btnTestMode_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(1160, 86);
            label2.TabIndex = 3;
            label2.Text = "МТО-АТ (МРС-АТ)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(45, 45, 45);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(415, 460);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(370, 90);
            button1.TabIndex = 4;
            button1.Text = "Выход из программы";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CloseBtn);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 28);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 1;
            label3.Text = "МТО-АТ";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.CloseBtn.FlatStyle = FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImageAlign = ContentAlignment.TopCenter;
            this.CloseBtn.Location = new System.Drawing.Point(1135, 0);
            this.CloseBtn.Margin = new Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new Size(40, 25);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.TextAlign = ContentAlignment.TopCenter;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += CloseBtn_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ClientSize = new Size(1176, 587);
            this.ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnTestMode);
            Controls.Add(btnStudyMode);
            Controls.Add(label1);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = SystemColors.ControlText;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Margin = new Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new Padding(3);
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudyMode;
        private System.Windows.Forms.Button btnTestMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label3;
    }
}
