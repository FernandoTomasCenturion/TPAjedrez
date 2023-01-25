using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAjedrez
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main()
        {
            Peon peon = new Peon();
            Torre torre = new Torre();
            Caballo caballo = new Caballo();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            peon.Mover();
            torre.Mover();
            caballo.Mover();

        }
    }
}
