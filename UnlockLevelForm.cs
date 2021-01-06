using System;
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
    public partial class UnlockLevelForm : Form
    {
        public UnlockLevelForm()
        {
            InitializeComponent();
        }

        private void unlock_level_textBox_TextChanged(object sender, EventArgs e)
        {
            this.outcome_label.Text = "";

            if(this.unlock_level_textBox.TextLength == 4)
            {
                int newLevel = MainMenuStateForm.levels.LastIndexOf(Convert.ToInt32(this.unlock_level_textBox.Text));
                if(newLevel != -1)
                {
                    MainMenuStateForm.level = newLevel + 2;
                    this.outcome_label.ForeColor = Color.Green;
                    this.outcome_label.Text = "Success!";

                } else
                {
                    this.outcome_label.ForeColor = Color.Red;
                    this.outcome_label.Text = "Wrong pasword!";
                }
                Console.WriteLine(MainMenuStateForm.level);
            }
        }
    }
}
