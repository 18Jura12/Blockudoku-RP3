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
        }

        private void options_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new OptionsStateForm());
        }

        private void standard_game_button_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new PlayStateForm());
        }
    }
}
