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
     * class represents base class  for all the states of the game 
     */
    public partial class StateForm : Form
    {
        // 
        public static int level { get; set; }
        // game with time; true/false
        public bool timed { get; set; }
        //game with obstacles; true/false
        public bool obstacles { get; set; }
        // score in game
        public int score { get; set; }
        // color of blocks in grid
        public Color colorBlocks { get; set; }
        //background color
        public Color colorBackground { get; set; }

        public StateForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            colorBlocks = System.Drawing.Color.DarkBlue;
            colorBackground = System.Drawing.Color.Azure;
            score = 0;
        }

        /*
         * Prevents flickering
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
    }
}
