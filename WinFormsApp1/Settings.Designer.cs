namespace WinFormsApp1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            checkBoxTimer = new CheckBox();
            label1 = new Label();
            numericUpDownScore = new NumericUpDown();
            label2 = new Label();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScore).BeginInit();
            SuspendLayout();
            // 
            // checkBoxTimer
            // 
            checkBoxTimer.AutoSize = true;
            checkBoxTimer.BackColor = Color.Cyan;
            checkBoxTimer.Cursor = Cursors.Cross;
            checkBoxTimer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxTimer.Location = new Point(174, 133);
            checkBoxTimer.Margin = new Padding(3, 4, 3, 4);
            checkBoxTimer.Name = "checkBoxTimer";
            checkBoxTimer.Size = new Size(122, 45);
            checkBoxTimer.TabIndex = 1;
            checkBoxTimer.Text = "Timer";
            checkBoxTimer.UseVisualStyleBackColor = false;
            checkBoxTimer.CheckedChanged += checkBoxTimer_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 49);
            label1.Name = "label1";
            label1.Size = new Size(248, 35);
            label1.TabIndex = 2;
            label1.Text = "Усі налаштування:";
            // 
            // numericUpDownScore
            // 
            numericUpDownScore.Cursor = Cursors.Cross;
            numericUpDownScore.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownScore.Location = new Point(318, 192);
            numericUpDownScore.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownScore.Name = "numericUpDownScore";
            numericUpDownScore.ReadOnly = true;
            numericUpDownScore.Size = new Size(45, 40);
            numericUpDownScore.TabIndex = 4;
            numericUpDownScore.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownScore.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 192);
            label2.Name = "label2";
            label2.Size = new Size(128, 40);
            label2.TabIndex = 5;
            label2.Text = "Max Score:";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(453, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(30, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 553);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(numericUpDownScore);
            Controls.Add(label1);
            Controls.Add(checkBoxTimer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public CheckBox checkBoxTimer;
        private Label label1;
        private Label label2;
        private Button buttonExit;
        public NumericUpDown numericUpDownScore;
    }
}