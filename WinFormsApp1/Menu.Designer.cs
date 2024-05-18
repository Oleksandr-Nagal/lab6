namespace WinFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            buttonTwoPlayers = new Button();
            buttonInfo = new Button();
            buttonStartWithBot = new Button();
            SuspendLayout();
            // 
            // buttonTwoPlayers
            // 
            buttonTwoPlayers.Font = new Font("Tw Cen MT Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTwoPlayers.ForeColor = Color.Green;
            buttonTwoPlayers.Location = new Point(126, 24);
            buttonTwoPlayers.Name = "buttonTwoPlayers";
            buttonTwoPlayers.Size = new Size(299, 100);
            buttonTwoPlayers.TabIndex = 0;
            buttonTwoPlayers.Text = "Гра на Двох";
            buttonTwoPlayers.UseVisualStyleBackColor = true;
            buttonTwoPlayers.Click += buttonTwoPlayers_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Tw Cen MT Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.ForeColor = Color.Green;
            buttonInfo.Location = new Point(126, 261);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(299, 100);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Керування";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonStartWithBot
            // 
            buttonStartWithBot.Font = new Font("Tw Cen MT Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartWithBot.ForeColor = Color.Green;
            buttonStartWithBot.Location = new Point(126, 142);
            buttonStartWithBot.Name = "buttonStartWithBot";
            buttonStartWithBot.Size = new Size(299, 100);
            buttonStartWithBot.TabIndex = 2;
            buttonStartWithBot.Text = "Гра з Ботом";
            buttonStartWithBot.UseVisualStyleBackColor = true;
            buttonStartWithBot.Click += buttonStartWithBot_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(551, 401);
            Controls.Add(buttonStartWithBot);
            Controls.Add(buttonInfo);
            Controls.Add(buttonTwoPlayers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(569, 500);
            MinimizeBox = false;
            MinimumSize = new Size(569, 448);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTwoPlayers;
        private Button buttonInfo;
        private Button buttonStartWithBot;
    }
}