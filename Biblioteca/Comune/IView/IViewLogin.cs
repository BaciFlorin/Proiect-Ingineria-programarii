namespace Comune
{
    public interface IViewLogin
    {
        void Start();

        void SetController(IControllerLogin controllerLogin);

        void DisplayEroareLogin(string msg);

        void LoginAsUser();

        void LoginAsAdmin();

        void SetLoggedUser(int idUser);

        void ClearInterface();
    }
}
