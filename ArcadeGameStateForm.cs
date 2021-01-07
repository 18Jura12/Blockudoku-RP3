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
    public partial class ArcadeGameStateForm : StateForm
    {

        public ArcadeGameStateForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

        private void ArcadeGameStateForm_Load(object sender, EventArgs e)
        {
            update_level();
        }

        private void update_level()
        {
            switch (level)
            {
                case 2:
                    this.level_2_button.Enabled = true;
                    break;
                case 3:
                    this.level_2_button.Enabled = true;
                    this.level_3_button.Enabled = true;
                    break;
                case 4:
                    this.level_2_button.Enabled = true;
                    this.level_3_button.Enabled = true;
                    this.level_4_button.Enabled = true;
                    break;
                case 5:
                    this.level_2_button.Enabled = true;
                    this.level_3_button.Enabled = true;
                    this.level_4_button.Enabled = true;
                    this.level_5_button.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void level_1_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm(), 1);
        }

        private void level_2_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm(), 2);
        }

        private void level_3_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm(), 3);
        }

        private void level_4_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm(), 4);
        }

        private void level_5_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm(), 5);
        }
    }
}
