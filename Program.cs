using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockudoku
{
    static class Program
    {
        //window in which all states are shown
        public static MdiContainer container;

        //class that manages state transitions
        public static StateManager stateManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            container = new MdiContainer();
            stateManager = new StateManager(new MainMenuStateForm());

            Application.Run(container);
        }
    }
}
