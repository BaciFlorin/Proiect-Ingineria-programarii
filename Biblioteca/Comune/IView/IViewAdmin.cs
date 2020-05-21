/**************************************************************************
 *                                                                        *
 *  File:        IViewAdmin.cs                                            *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuias.ro                           *
 *  Description: Interfata View-ului.                                     *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comune
{
    public interface IViewAdmin
    {
        void Start();
        void SetController(IControllerAdmin controller);
        void PuneImprumutInLista(string imprumut);
        void PuneUtilizatorInLista(string utilizator);
        void PuneCerereInLista(string cerere);
        void PuneCarteInLista(string carte);
        void Afiseaza(string text);
        void CurataListaImprumut();
        void CurataListaUtilizatori();
        void CurataListaCereri();
        void CurataListaCarti();
    }
}
