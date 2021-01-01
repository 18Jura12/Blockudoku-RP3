﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockudoku
{
    class StateManager
    {

        public StateManager(StateForm Form)
        {
            CurrentState = Form;
            CurrentState.MdiParent = Program.container;
            CurrentState.Dock = DockStyle.Fill;
            CurrentState.Show();
        }

        public void Transition(StateForm NewState)
        {
            NewState.level = CurrentState.level;
            NewState.timed = CurrentState.timed;
            NewState.obstacles = CurrentState.obstacles;
            NewState.theme = CurrentState.theme;

            CurrentState.FormClosing += (sender, e) =>
            {
                NewState.MdiParent = Program.container;
                NewState.FormBorderStyle = FormBorderStyle.None;
                NewState.Dock = DockStyle.Fill;
                NewState.Show();
            };
            CurrentState.Close();
            CurrentState = NewState;
        }

        public StateForm CurrentState { get; private set; }
    }
}