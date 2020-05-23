/**************************************************************************
 *                                                                        *
 *  File:        IContollerAdmin.cs                                       *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuias.ro                           *
 *  Description: Interfata Controlerului.                                 *
 *                                                                        *
 **************************************************************************/


namespace Comune
{
    public interface IControllerAdmin
    {
        bool AdaugaCartiInStoc(int id, int numarCarti);
        void FiltreazaDupaAutor(int tab, string text);
        void FiltreazaDupaUser(int tab, string text);
        void FiltreazaDupaGen(int tab, string text);
        void FiltreazaDupaTitlu(int tab, string text);
        void AfiseazaToate(int tab);
        bool StergeCarte(int id);
        bool AcceptaCerere(int id);
        bool AdaugaCarteNoua(string titlu, string autor, string IBSN, string descriere, string categotie, int stoc);
        bool RespingeCerere(int id);
        void InfoCerere(int id);
        void InfoUtilizator(int id);
        void InfoImprumut(int id);
        void InfoCarte(int id);
        void Init();
    }
}
