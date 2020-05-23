/**************************************************************************
 *                                                                        *
 *  File:        IViewLogin.cs                                            *
 *  Copyright:   (c) 2020, Țurcaș Irina                                   *
 *  Description: Interfata view-ului de autentificare                     *
 *                                                                        *
 **************************************************************************/

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
