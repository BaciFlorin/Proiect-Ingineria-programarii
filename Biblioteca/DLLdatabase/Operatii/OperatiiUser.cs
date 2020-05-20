/**************************************************************************
 *                                                                        *
 *  File:        OperatiiUser.cs                                          *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Descriere operatii care se afectueaza asupra tabelei     *
 *               User din baza de date.                                   *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using SqliteHandle;
using Entitati;
namespace Operatii
{
    public class OperatiiUser
    {
        private static DatabaseConnection _connection = DatabaseConnection.GetDbConnection();
        /// <summary>
        /// Inserarea unui user nou
        /// </summary>
        /// <typeparam name="user">user-ul pe care doresti sa-l  introduci</typeparam>
        public bool InserareUserNou(User user)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO User(ID_User, Username, Parola)" +
                " VALUES('"+user.ID+"','" + user.User_name + "','" + user.Parola + "');");

            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Stergerea unui user identificat de un id
        /// </summary>
        /// <typeparam name="id">Id-ul unic atribuit user-ului pe care vrei sa-l stergi</typeparam>
        public bool StergeUser(int ID_User)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM User WHERE ID_User = " + ID_User.ToString());
            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Selectarea tuturor user-ilor din baza de date
        /// </summary>
        public List<User> SelecteazaUseri()
        {

            List<List<string>> result = _connection.ExecutaComandaSelect("SELECT * " +
                "FROM User ;", new string[] { "ID_User", "Username", "Parola" });
            List<User> user = new List<User>(result.Count);
            foreach (List<string> linie in result)
            {
                user.Add(new User(int.Parse(linie[0]), linie[1], linie[2]));
            }
            return user;
        }
        /// <summary>
        /// Cautarea unui user 
        /// </summary>
        /// <typeparam name="user">user-ul cautat</typeparam>
        public bool UserExist(User user)
        {

            List<List<string>> result = _connection.ExecutaComandaSelect("SELECT * " +
                "FROM User WHERE ID_User =" + user.ID.ToString() + " AND Username ='" + user.User_name + "';", new string[] { "ID_User", "Username", "Parola" });
            if (result.Count != 0)
                return true;
            return false;
        }
    }
}
