/**************************************************************************
 *                                                                        *
 *  File:        IControllerLogin.cs                                      *
 *  Copyright:   (c) 2020, Țurcaș Irina                                   *
 *  Description: Interfata controlerului de login                         *
 *                                                                        *
 **************************************************************************/

using Entitati;

namespace Comune
{
    public interface IControllerLogin
    {
        IViewLogin Login { get; set; }
        IViewSignup Signup { get; set; }

        /// <summary>
        /// Verifica existenta unui utilizator in tabelul corespunzator
        /// </summary>
        /// <param name="user"></param>
        bool ExistaUser(string username);
        /// <summary>
        /// Verifica credentialele unui user (pentru logare)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool VerificaUser(User user);
        
        /// <summary>
        /// Verifica existenta unei peroane in tabelul corespunzator
        /// </summary>
        /// <param name="persoana"></param>
        bool ExistaPersoana(Persoana persoana);
        /// <summary>
        /// Insereaza o persoana in baza de date
        /// </summary>
        /// <param name="persoana"></param>
        void AdaugaPersoana(Persoana persoana, User user);

        /// <summary>
        /// Daca datele care au fost introduse sunt corecte, utilizatorul va fi logat
        /// </summary>
        /// <param name="user"></param>
        void Logare(User user);

        /// <summary>
        /// Se creeaza un nou utilizator daca datele introduse sunt valide
        /// </summary>
        /// <param name="persoana"></param>
        /// <param name="user"></param>
        /// <param name="passConfirm"></param>
        void Inregistrare(Persoana persoana, User user, string passConfirm);

    }
}
