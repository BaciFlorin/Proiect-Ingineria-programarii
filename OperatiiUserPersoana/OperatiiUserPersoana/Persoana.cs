using System;
using System.Collections.Generic;
using System.Text;

namespace OperatiiUserPersoana
{
    class Persoana
    {
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
