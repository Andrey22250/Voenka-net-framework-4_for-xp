using System.Drawing;
using System.Windows.Forms;

namespace voenka
{
    partial class ResultForm
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
            components = new System.ComponentModel.Container();
            lblResult = new Label();
            lblHeader = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(12, 139);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(760, 65);
            lblResult.TabIndex = 0;
            lblResult.Text = "СДАЛ/НЕ СДАЛ";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(12, 92);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(760, 47);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Результат тестирования";
            lblHeader.TextAlign = ContentAlignment.BottomCenter;
            // 
            // timer
            // 
            timer.Interval = 30000;
            timer.Tick += timer1_Tick;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 361);
            Controls.Add(lblHeader);
            Controls.Add(lblResult);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResultForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результат тестирования";
            FormClosing += ResultForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Label lblHeader;
        private System.Windows.Forms.Timer timer;
    }
}