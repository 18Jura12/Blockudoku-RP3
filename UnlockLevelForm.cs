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
    /*
     * class represents a form where one can input a password for unlocking levels in arcade game mode
     */
    public partial class UnlockLevelForm : Form
    {
        public UnlockLevelForm()
        {
            InitializeComponent();
            this.Text = "";
        }

        //checks whether the password is in good format and changes the level state of arcade game
        //if the password is correct
        private void unlock_level_textBox_TextChanged(object sender, EventArgs e)
        {
            this.outcome_label.Text = "";

            if(this.unlock_level_textBox.TextLength == 4)
            {
                int newLevel;
                try
                {
                    newLevel = MainMenuStateForm.levels.LastIndexOf(Convert.ToInt32(this.unlock_level_textBox.Text));
                } catch(FormatException)
                {
                    newLevel = -1;
                }

                if(newLevel != -1)
                {
                    if(newLevel + 2 > MainMenuStateForm.level) MainMenuStateForm.level = newLevel + 2;
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
