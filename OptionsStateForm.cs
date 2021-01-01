﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockudoku
{
    public partial class OptionsStateForm : StateForm
    {
        public OptionsStateForm()
        {
            InitializeComponent();
        }

        private void timed_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.timed = this.timed_checkBox.Checked;
        }

        private void obstacles_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.obstacles = this.obstacles_checkBox.Checked;
        }

        private void theme_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.theme = this.theme_comboBox.SelectedIndex;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

        private void OptionsStateForm_Load(object sender, EventArgs e)
        {
            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width / 2, this.Size.Height * 4 / 5);
        }

        private void OptionsStateForm_SizeChanged(object sender, EventArgs e)
        {
            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width / 2, this.Size.Height * 4 / 5);
        }
    }
}