/**************************************************************************
 *                                                                        *
 *  File:        Persoana.cs                                              *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Clasa care stocheaza informatiile despre o persoana din  *
 *               baza de date.                                            *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitati
{
    public class Persoana
    {
        /// <summary>
        /// Constructor clasa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        /// <param name="adresa"></param>
        /// <param name="email"></param>
        /// <param name="telefon"></param>
        /// <param name="poza_path"></param>
        public Persoana(int id, string nume, string prenume, string adresa, string email,string telefon, string poza_path)
        {
            ID = id;
            Nume = nume;
            Prenume = prenume;
            Adresa = adresa;
            Email = email;
            Telefon = telefon;
            Poza_path = poza_path;
        }

        public int ID { get; private set; }

        public string Nume { get; private set; }

        public string Prenume { get; private set; }

        public string Adresa { get; private set; }

        public string Email { get; private set; }

        public string Telefon { get; private set; }

        public string Poza_path { get; private set; }
    }
}
