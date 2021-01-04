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
    public partial class MainMenuStateForm : StateForm
    {
        public MainMenuStateForm()
        {
            InitializeComponent();

            // flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

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

        private void options_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new OptionsStateForm());
        }

        private void standard_game_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm());
        }

        private void rules_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new RulesStateForm());
        }

        private void top_scores_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new TopScoresStateForm());
        }
    }
}
