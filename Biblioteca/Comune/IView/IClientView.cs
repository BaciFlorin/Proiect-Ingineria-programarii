﻿/**************************************************************************
 *                                                                        *
 *  File:        IClientView                                              *
 *  Copyright:   (c) 2020, Atomei Georgiana                               *
 *  E-mail:      georgiana.atomei@student.tuiasi.ro                       *
 *  Description: Interafata view-ului client.                             *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;
using Entitati;


namespace Comune
{
    public interface IClientView
    {
        void Start();
        void SetController(IClientController controller);
        void AfiseazaImprumuturi();
        void AfiseazaCarti();
        void AfiseazaDetalii(string detalii);
        void AfiseazaDetaliiUtlizator(string detalii);
        void SeteazaListaImprumuturi(List<Imprumut> imprumuturi);
        void SeteazaListaCarti(List<Carte> carti);
        void SeteazaPozaUser(string path);
        void SeteazaUsername(string username);
        void ClearDetalii();
        void AfiseazaMesaj(string msg);
    }
}
