/**************************************************************************
 *                                                                        *
 *  File:        IViewSignUp.cs                                           *
 *  Copyright:   (c) 2020, Țurcaș Irina                                   *
 *  Description: Interfata view-ului de inregistrare                      *
 *                                                                        *
 **************************************************************************/

namespace Comune
{
    public interface IViewSignup
    {
        void SetController(IControllerLogin controllerLogin);
      
        /// <summary>
        /// Functie care aduce fereastra in starea initiala
        /// </summary>
        void ReseteazaCampuri();
        /// <summary>
        /// Functie care scoate in evidenta campurile incorecte si compune mesajul de eroare
        /// </summary>
        void SpecificaEroarea();

        void SeteazaEroarea(string message);

        void InregistrareCuSucces();
    }
}
