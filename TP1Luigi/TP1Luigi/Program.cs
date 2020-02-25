using System;
using System.Windows.Forms;

namespace TP1Luigi
{
    static class Program
    {
        /// <summary>
        /// Point d entree du programme
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
