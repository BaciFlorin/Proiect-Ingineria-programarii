using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteHandle
{
    class Carte
    {
        public Carte(int id, string titlu, string autor, string ibbn, string categorie, string descriere, int stoc)
        {
            ID = id;
            Autor = autor;
            Titlu = titlu;
            IBBN = ibbn;
            Categorie = categorie;
            Descriere = descriere;
            Stoc = stoc;
        }

        public int ID { get; private set; }

        public string Titlu { get; private set; }

        public string Autor { get; private set; }

        public string Categorie { get; private set; }

        public string Descriere { get; private set; }

        public string IBBN { get; private set; }

        public int Stoc { get; private set; }

    }
}
