using Interfete;
using Comune;
using Controlere;
using System;
using System.Windows.Forms;

namespace Biblioteca
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
            // init. view si controller
            IViewLogin login = new Autentificare();

            IControllerLogin controllerLogin = new ControllerLogin();
            controllerLogin.Login = login;

            login.SetController(controllerLogin);
            
            ((Autentificare)login).Start();
        }
    }
}
