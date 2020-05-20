using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comune
{
    public interface IControllerAdmin
    {
        void AdaugaCartiInStoc(int id, int numarCarti);
        void FiltreazaDupaAutor(int tab, string text);
        void FiltreazaDupaUser(int tab, string text);
        void FiltreazaDupaGen(int tab, string text);
        void FiltreazaDupaTitlu(int tab, string text);
        void AfiseazaToate(int tab);
        void StergeCarte(int id);
        void AcceptaCerere(int id);
        void AdaugaCarteNoua(string titlu, string autor, string IBSN, string descriere, string categotie, int stoc);
        void RespingeCerere(int id);
        void InfoCerere(int id);
        void InfoUtilizator(int id);
        void InfoImprumut(int id);
        void InfoCarte(int id);
        void Init();
    }
}
