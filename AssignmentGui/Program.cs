using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGui
{
    // By: Calvin Pierce(101253832), Rey-C Mendoza(101257302), Shiming Ye (101274045)
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventCoordinator eCoord = new EventCoordinator(200, 1000, 101, 5000, 300, 10000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(eCoord));
        }
    }
}
