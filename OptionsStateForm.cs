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
     * Class represents an option menu, where one can adjust standard game settings
     */
    public partial class OptionsStateForm : StateForm
    {

        public OptionsStateForm()
        {
            InitializeComponent();
            this.Text = "";
        }


        //updates timed status for standard game
        private void timed_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.timed = this.timed_checkBox.Checked;
        }

        //updates obstacle status for standard game
        private void obstacles_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.obstacles = this.obstacles_checkBox.Checked;
        }

        /*
         * Depending on the index, method selects background color and color of blocks in grid
         */
        private void theme_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.theme_comboBox.SelectedIndex)
            {
                case 0:
                    this.colorBlocks = System.Drawing.Color.DarkBlue;
                    this.colorBackground = System.Drawing.Color.Azure;
                    break;
                case 1:
                    this.colorBlocks = System.Drawing.Color.DarkGreen;
                    this.colorBackground = System.Drawing.Color.Honeydew;
                    break;
                case 2:
                    this.colorBlocks = System.Drawing.Color.DarkOrchid;
                    this.colorBackground = System.Drawing.Color.LavenderBlush;
                    break;
            }
        }

        /*
         * Go back to Main Menu through back button
         */
        private void back_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

        private void OptionsStateForm_Load(object sender, EventArgs e)
        {
            this.timed_checkBox.Checked = timed;
            this.obstacles_checkBox.Checked = obstacles;

            switch (colorBlocks.Name)
            {
                case "DarkBlue":
                    this.theme_comboBox.SelectedIndex = 0;
                    break;
                case "DarkGreen":
                    this.theme_comboBox.SelectedIndex = 1;
                    break;
                case "DarkOrchid":
                    this.theme_comboBox.SelectedIndex = 2;
                    break;
                default:
                    break;
            }

            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width * 2/3, this.Size.Height * 4 / 5);
            this.options_groupBox.Location = new Point((this.Size.Width - this.options_groupBox.Size.Width) / 2, (this.Size.Height - this.options_groupBox.Size.Height) / 2);
            this.timed_checkBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height / 10);
            this.obstacles_checkBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 3 / 10);
            this.theme_label.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 5 / 10);
            this.theme_comboBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width * 3 / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 5 / 10);
            this.back_button.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 7 / 10);
        }

        //updates option menu components' size upon window manipulation
        private void OptionsStateForm_SizeChanged(object sender, EventArgs e)
        {
            float kWidth = this.options_groupBox.Size.Width;
            float kHeight = this.options_groupBox.Size.Height;
            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width *2/3, this.Size.Height *4/5);
            this.options_groupBox.Location = new Point((this.Size.Width - this.options_groupBox.Size.Width)/2, (this.Size.Height - this.options_groupBox.Size.Height) / 2);
            this.timed_checkBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height / 10);
            this.obstacles_checkBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 3 / 10);
            this.theme_label.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 5 / 10);
            this.theme_comboBox.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width * 3 / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 5 / 10);
            this.back_button.Location = new Point(this.options_groupBox.Location.X + this.options_groupBox.Size.Width / 10, this.options_groupBox.Location.Y + this.options_groupBox.Size.Height * 7 / 10);

            /*kWidth = this.options_groupBox.Size.Width / kWidth;
            kHeight = this.options_groupBox.Size.Height / kHeight;

            var newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.options_groupBox.Font.Size), FontStyle.Bold);
            this.options_groupBox.Font = newFont;
            newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.timed_checkBox.Font.Size), FontStyle.Bold);
            this.timed_checkBox.Font = newFont;
            newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.obstacles_checkBox.Font.Size), FontStyle.Bold);
            this.obstacles_checkBox.Font = newFont;
            newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.theme_label.Font.Size), FontStyle.Bold);
            this.theme_label.Font = newFont;
            newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.theme_comboBox.Font.Size), FontStyle.Bold);
            this.theme_comboBox.Font = newFont;
            newFont = new Font("Papyrus", (float)(Math.Sqrt(kWidth * kHeight) * this.back_button.Font.Size), FontStyle.Bold);
            this.back_button.Font = newFont;*/

        }
    }
}
