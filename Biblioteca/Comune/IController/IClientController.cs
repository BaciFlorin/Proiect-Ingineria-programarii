/**************************************************************************
 *                                                                        *
 *  File:        IClientController                                        *
 *  Copyright:   (c) 2020, Atomei Georgiana                               *
 *  E-mail:      georgiana.atomei@student.tuiasi.ro                       *
 *  Description: Interafata controlerului client.                         *
 *                                                                        *
 **************************************************************************/

using Entitati;

namespace Comune
{
    public enum TipFiltru
    {
        None,
        Titlu,
        Autor,
        Categorie

    };
    public interface IClientController
    {
        void ReturneazaCarte(Imprumut imprumut);
        void AdaugaImprumut(Carte carte, int userId);
        void ObtineCarti(TipFiltru tipFiltru, string filtru);
        void ObtineImprumuturi(TipFiltru tipFiltru, string filtru);
        void DetaliiImprumut(int idImprumut);
        void DetaliiCarte(Carte carte);
        void DetaliiUser(int idUser);
        void ObtinePathPozaUser(int userId);
        void ObtineUsername(int userId);
        void Init();
    }
}
