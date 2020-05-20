/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Clasa care stocheaza informatiile despre un user din     *
 *               baza de date.                                            *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitati
{
    public class User
    {
        /// <summary>
        /// Constructor clasa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user_name"></param>
        /// <param name="parola"></param>
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
