using System;
using System.Collections.Generic;
using System.Text;

namespace OperatiiCereri
{
    class Cerere
    {
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
