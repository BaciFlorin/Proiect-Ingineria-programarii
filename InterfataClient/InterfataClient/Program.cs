using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comune;
using Controlere;


namespace InterfataClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IClientView view = new InterfataUtilizator(1);
            IClientController controller = new ClientController(view);
            view.SetController(controller);
            ((InterfataUtilizator)view).Start();
        }
    }
}
