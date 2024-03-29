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
    /*
     * class represents explanation of the rules of the game 
     */
    public partial class RulesStateForm : StateForm
    {
        public RulesStateForm()
        {
            InitializeComponent();
            // cursor isn't shown
            customTextBox_rules.Enter += (s, e) => {
                customTextBox_rules.Parent.Focus(); 
            };

            this.Text = "";
        }

        /*
         * Prevents flickering background
         */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        /*
         * Update size of objects on form
         */
        private void RulesStateForm_SizeChanged(object sender, EventArgs e)
        {
            this.groupBox_Rules.Width = this.Width * 2 / 3;
            this.groupBox_Rules.Height = this.Height * 2 / 3;

            // 2/3 gropubox, 1/6 left,right,top,down
            int x1 = Convert.ToInt32(this.Width / 6);
            int y1 = Convert.ToInt32(this.Height / 6);

            this.groupBox_Rules.Location = new Point(x1, y1);

            this.customTextBox_rules.Width = this.groupBox_Rules.Width * 2 / 3;
            this.customTextBox_rules.Height = this.groupBox_Rules.Height * 2 / 3;

            // 2/3 textBox, 1/6 left,right,top,down
            int x2 = Convert.ToInt32(this.groupBox_Rules.Width / 6);
            int y2 = Convert.ToInt32(this.groupBox_Rules.Height / 6);

            this.customTextBox_rules.Location = new Point(x2, y2);

            this.button_Rules_back.Width = customTextBox_rules.Width / 4;
            this.button_Rules_back.Height = customTextBox_rules.Height / 8;

            // 1/4 button, 3/8 left,right, top: textbox+y2
            int x3 = Convert.ToInt32(this.groupBox_Rules.Width * 3 / 8);
            int y3 = Convert.ToInt32(y2 + customTextBox_rules.Height);

            this.button_Rules_back.Location = new Point(x3, y3);
        }

        /*
         * Go back to Main Menu through back button
         */
        private void button_Rules_back_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

    }
}
