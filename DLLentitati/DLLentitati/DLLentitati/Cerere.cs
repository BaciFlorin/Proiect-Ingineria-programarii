/**************************************************************************
 *                                                                        *
 *  File:        Cerere.cs                                                *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Clasa care stocheaza informatiile despre o cerere din    *
 *               baza de date.                                            *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitati
{
    public class Cerere
    {
        /// <summary>
        /// Constructor clasa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id_carte"></param>
        /// <param name="id_user"></param>
        /// <param name="tip_cerere"></param>
        public Cerere(int id, int id_carte, int id_user, string tip_cerere)
        {
            ID = id;
            ID_Carte = id_carte;
            ID_User = id_user;
            Tip_cerere = tip_cerere;
        }

        public int ID { get; private set; }

        public int ID_Carte { get; private set; }

        public int ID_User { get; private set; }

        public string Tip_cerere { get; private set; }

    }
}
