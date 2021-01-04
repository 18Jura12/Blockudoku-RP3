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
            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width * 2/3, this.Size.Height * 4 / 5);
            this.options_groupBox.Location = new Point((this.Size.Width - this.options_groupBox.Size.Width) / 2, (this.Size.Height - this.options_groupBox.Size.Height) / 2);
        }

        private void OptionsStateForm_SizeChanged(object sender, EventArgs e)
        {
            float kWidth = this.options_groupBox.Size.Width;
            float kHeight = this.options_groupBox.Size.Height;
            this.options_groupBox.Size = new System.Drawing.Size(this.Size.Width *2/3, this.Size.Height *4/5);
            this.options_groupBox.Location = new Point((this.Size.Width - this.options_groupBox.Size.Width)/2, (this.Size.Height - this.options_groupBox.Size.Height) / 2);
            //treba namjestiti lokaciju komponenata groupBoxa!!

            kWidth = this.options_groupBox.Size.Width / kWidth;
            kHeight = this.options_groupBox.Size.Height / kHeight;

            var newFont = new Font("Papyrus", kWidth * kHeight * this.options_groupBox.Font.Size, FontStyle.Bold);
            this.options_groupBox.Font = newFont;
            newFont = new Font("Papyrus", kWidth * kHeight * this.timed_checkBox.Font.Size, FontStyle.Bold);
            this.timed_checkBox.Font = newFont;
            newFont = new Font("Papyrus", kWidth * kHeight * this.obstacles_checkBox.Font.Size, FontStyle.Bold);
            this.obstacles_checkBox.Font = newFont;
            newFont = new Font("Papyrus", kWidth * kHeight * this.theme_label.Font.Size, FontStyle.Bold);
            this.theme_label.Font = newFont;
            newFont = new Font("Papyrus", kWidth * kHeight * this.theme_comboBox.Font.Size, FontStyle.Bold);
            this.theme_comboBox.Font = newFont;
            newFont = new Font("Papyrus", kWidth * kHeight * this.back_button.Font.Size, FontStyle.Bold);
            this.back_button.Font = newFont;

        }
    }
}
