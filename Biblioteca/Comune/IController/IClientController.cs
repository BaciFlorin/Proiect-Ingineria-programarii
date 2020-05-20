using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
