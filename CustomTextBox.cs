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
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                 //ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        private void redrawText()
        {
            RectangleF rect = new RectangleF(1F, 1F, this.Width, this.Height);
            using (Graphics graphics = this.CreateGraphics())
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
                //graphics.DrawString(this.Text, this.Font, brush, 1, 1);
                graphics.DrawString(this.Text, this.Font, brush, rect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            redrawText();
        }
    }
}
