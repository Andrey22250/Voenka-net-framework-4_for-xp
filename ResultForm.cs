using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voenka
{
    public partial class ResultForm : Form
    {
        private bool passedSuccessfully;
        private bool timerDone = false;

        public ResultForm(bool passedSuccessfully)
        {
            InitializeComponent();
            timer.Enabled = true;

            this.passedSuccessfully = passedSuccessfully;
            lblResult.Text = passedSuccessfully ? "СДАЛ" : "НЕ СДАЛ";
            lblResult.ForeColor = passedSuccessfully ? Color.Green : Color.Red;
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!passedSuccessfully && !timerDone)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDone = true;
        }
    }
}
