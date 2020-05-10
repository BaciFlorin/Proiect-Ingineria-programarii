using System;
using System.Collections.Generic;
using System.Text;

namespace OperatiiUserPersoana
{
    class User
    {
        public User(int id, string user_name, string parola)
        {
            ID = id;
            User_name = user_name;
            Parola = parola;
        }

        public int ID { get; private set; }

        public string User_name { get; private set; }

        public string Parola { get; private set; }
    }
}
