﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void buttonStartWithBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
            main.CPU = true;
            Cursor.Hide();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

            Info info = new Info();
            info.ShowDialog();
        }
        private void buttonTwoPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
            Cursor.Hide();
        }
    }
}
