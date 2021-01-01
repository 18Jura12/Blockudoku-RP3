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
    public partial class StateForm : Form
    {

        public int level { get; set; }
        public int theme { get; set; }
        public bool timed { get; set; }
        public bool obstacles { get; set; }

        public StateForm()
        {
            InitializeComponent();
        }
    }
}
