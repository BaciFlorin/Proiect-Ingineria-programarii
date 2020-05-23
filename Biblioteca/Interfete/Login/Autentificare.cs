using Comune;
using Controlere;
using Entitati;
using System;
using System.Windows.Forms;

namespace Interfete
{
    public partial class Autentificare : Form, IViewLogin
    {
        private IControllerLogin _controllerLogin;

        private int _loggedUserId;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public Autentificare()
        {
            
            InitializeComponent();
        }

        public void Start()
        {
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            User user = new User(0, input_usr.Text, input_pwd.Text);
            _controllerLogin.Logare(user);

            if (this == null || this.IsDisposed)
                return;

            else
                this.Show();
        }

        private void link_cont_nou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IViewSignup creeaza_cont = new Creeaza_un_cont();
            IControllerLogin controller = new ControllerLogin();
            controller.Signup = creeaza_cont;
            creeaza_cont.SetController(controller);
            this.Hide();
            creeaza_cont.SetController(controller);

            ((Creeaza_un_cont)creeaza_cont).ShowDialog(this);

            // daca se poate iesi dintr-un form child, trebuie sa verific daca acesta este inca valid inainte sa il afisez
            if (this == null || this.IsDisposed)
                return;

            else
                this.Show();
        }

        private void butt_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void SetController(IControllerLogin controllerLogin)
        {
            _controllerLogin = controllerLogin;
        }

        public void DisplayEroareLogin(string msg)
        {
            MessageBox.Show(msg);
        }

        public void LoginAsUser()
        {
            //creare interfata user
            
            IClientView view = new InterfataUtilizator(_loggedUserId);
            IClientController controller = new ClientController(view);
            view.SetController(controller);
            ((InterfataUtilizator)view).Start();
            this.Hide();
            ((InterfataUtilizator)view).ShowDialog(this);

        }

        public void LoginAsAdmin()
        {
            IViewAdmin view = new InterfataBibliotecar();
            IControllerAdmin controller = new ControllerInterfataAdmin(view);
            view.SetController(controller);
            ((InterfataBibliotecar)view).Start();
            this.Hide();
            ((InterfataBibliotecar)view).ShowDialog(this);
            
        }

        public void SetLoggedUser(int idUser)
        {
            _loggedUserId = idUser;
        }
        public void ClearInterface()
        {
            input_usr.Text = "";
            input_pwd.Text = "";
        }
    }
}
