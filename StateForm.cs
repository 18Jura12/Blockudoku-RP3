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
    public partial class StateForm : Form
    {

        public static int level { get; set; }
        public bool timed { get; set; }
        public bool obstacles { get; set; }
        public int score { get; set; }
        public Color colorBlocks { get; set; }
        public Color colorBackground { get; set; }

        public StateForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            colorBlocks = System.Drawing.Color.DarkBlue;
            colorBackground = System.Drawing.Color.Azure;
        }
    }
}
