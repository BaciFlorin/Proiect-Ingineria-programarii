/**************************************************************************
 *                                                                        *
 *  File:        ControllerLogin.cs                                       *
 *  Copyright:   (c) 2020, Țurcaș Irina                                   *
 *  Description: Clasa care controleaza operatiile ce se pot efectua      *  
 *               asupra bazei de date la autentificare si inregistrare    *
 *                                                                        *
 **************************************************************************/

using Entitati;
using Operatii;
using Comune;

namespace Controlere
{
    public class ControllerLogin : IControllerLogin
    {
        private OperatiiPersoana _persoana;
        private OperatiiUser _user;

        private IViewLogin _login;
        public IViewLogin Login { get => _login;  set => _login = value; }

        private IViewSignup _signup;
        public IViewSignup Signup { get => _signup;  set => _signup = value; }

        public ControllerLogin()
        {
            _persoana = new OperatiiPersoana();
            _user = new OperatiiUser();
        }

        public void AdaugaPersoana(Persoana persoana, User user)
        {
           _persoana.InserarePersoanaNoua(persoana);

            Persoana nouaPersoana = _persoana.SelecteazaToatePersoanele().Find((Persoana pers) =>
            {
                return persoana.Nume == pers.Nume &&
                persoana.Prenume == pers.Prenume;
            });
            if(nouaPersoana!=null)
                _user.InserareUserNou(new User(nouaPersoana.ID, user.User_name, user.Parola));
        }

        public bool ExistaPersoana(Persoana persoana)
        {
            Persoana persoanaGasita = _persoana.SelecteazaToatePersoanele().Find((Persoana prs) =>
            {
                return prs.Nume == persoana.Nume &&
                prs.Prenume == persoana.Prenume
                && prs.Email == persoana.Email;
            });

            if (persoanaGasita!=null)
                return true;

            return false;

        }

        public bool ExistaUser(string username)
        {
            User userGasit = _user.SelecteazaUseri().Find((User usr) =>
              {
                  return usr.User_name == username;
              });

            if (userGasit != null )
                // userul exista deja - este ok la logare, dar nu la creare cont
                return true;
            return false;

        }

        public bool VerificaUser(User user)
        {
            User userGasit = _user.SelecteazaUseri().Find((User usr) =>
              {
                  return usr.User_name == user.User_name;
              });

            if (userGasit!=null )
                if (userGasit.Parola == user.Parola)
                    return true;
            return false;

        }
        public void Logare(User user)
        {
            if (user.User_name != "" && user.Parola != "")  
            {
                User userGasit = _user.SelecteazaUseri().Find((User usr) =>
                {
                    return usr.User_name == user.User_name && usr.Parola == user.Parola;
                });

                if (userGasit != null ) //daca exista userul 
                {
                    _login.SetLoggedUser(userGasit.ID);
                    _login.ClearInterface();
                    if (userGasit.ID == 1) //admin-ul va avea id-ul 1
                        _login.LoginAsAdmin();
                    else
                        _login.LoginAsUser();
                }
                else
                    _login.DisplayEroareLogin("Username sau parola incorecte.");
            }
            else
                _login.DisplayEroareLogin("Campurile trebuie completate.");
               
        }

        public void Inregistrare(Persoana persoana, User user, string passConfirm)
        {
            // nu trebuie sa existe persoane identice
            // nu trebuie sa existe 2 persoane sub acelasi utilizator
            // nu trebuie sa existe 2 persoane cu acelasi numar matricol in aceeasi unitate de invatamant
            // nu e recomandat sa existe 2 persoane cu acelasi nr de telefon sau email, dar e permis

            if (!ExistaPersoana(persoana))
            {
                if (user.Parola == passConfirm)
                {
                    if (!ExistaUser(user.User_name))
                    {
                        AdaugaPersoana(persoana, user);
                        _signup.InregistrareCuSucces();
                    }
                    else
                    {
                        _signup.SeteazaEroarea("\nAcest utilizator are deja o persoana asociata. Este posibil sa aveti deja un cont.");
                        _signup.SpecificaEroarea();
                    }
                }
                
            }
            else
            {
                _signup.SeteazaEroarea("\nDatele introduse sunt deja asociate unui utilizator existent.");
                _signup.SpecificaEroarea();
            }
        }
    }
}
