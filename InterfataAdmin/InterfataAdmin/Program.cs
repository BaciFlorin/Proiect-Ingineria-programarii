using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comune;
using Controlere;

namespace InterfataAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IViewAdmin view = new InterfataBibliotecar();
            IControllerAdmin controller = new ControllerInterfataAdmin(view);
            view.SetController(controller);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ((InterfataBibliotecar)view).Start();
        }
    }
}
