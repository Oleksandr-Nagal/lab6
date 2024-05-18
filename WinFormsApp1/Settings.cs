using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsApp1
{
    public partial class Settings : Form
    {
        private Main ownerForm;

        public Settings(Main ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numericUpDownScore.Minimum = numericUpDownScore.Value = ownerForm.MaxScore;
            checkBoxTimer.Checked = ownerForm.Timer;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ownerForm.MaxScore = Convert.ToInt32(numericUpDownScore.Value);
        }

        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            ownerForm.labelTimermain.Visible = checkBoxTimer.Checked;
            ownerForm.labelTimer.Visible = checkBoxTimer.Checked;
            ownerForm.Timer = checkBoxTimer.Checked;
        }



            private void buttonExit_Click(object sender, EventArgs e)
        {
            if (!ownerForm.timerPause.Enabled)
            {
                ownerForm.timerGame.Start();
                ownerForm.timer.Start();
            }
            Cursor.Hide();
            this.Close();
        }
    }
}
