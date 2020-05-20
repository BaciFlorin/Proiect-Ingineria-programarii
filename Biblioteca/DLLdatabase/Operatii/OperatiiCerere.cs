/**************************************************************************
 *                                                                        *
 *  File:        OperatiiCerere.cs                                        *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Descriere operatii care se afectueaza asupra tabelei     *
 *               Cerere din baza de date.                                 *
 *                                                                        *
 **************************************************************************/

using SqliteHandle;
using System;
using System.Collections.Generic;
using System.Text;
using Entitati;

namespace Operatii
{
    public class OperatiiCerere
    {
        private DatabaseConnection _connection = DatabaseConnection.GetDbConnection();
        /// <summary>
        /// Inserarea unei cereri noi
        /// </summary>
        /// <typeparam name="cerere">cererea pe care doresti sa o introduci</typeparam>
        public bool InserareCerereNoua(Cerere cerere)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO Cerere(ID_Carte, ID_User,Tip_cerere)" +
                " VALUES(" + cerere.ID_Carte.ToString() + "," + cerere.ID_User.ToString() + ",'" + cerere.Tip_cerere + "');");
            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Stergerea unei cereri identificata de un id
        /// </summary>
        /// <typeparam name="id">Id-ul unic atribuit cererii pe care vrei sa o stergi</typeparam>
        public bool StergeCerere(int ID)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM Cerere WHERE ID = " + ID.ToString());
            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Selectarea tuturor cererilor din baza de date
        /// </summary>
        public List<Cerere> SelecteazaCerere()
        {

            List<List<string>> result = _connection.ExecutaComandaSelect("SELECT * " +
                "FROM Cerere ", new string[] { "ID", "ID_Carte", "ID_User", "Tip_cerere"});
            List<Cerere> cerere = new List<Cerere>(result.Count);
            foreach (List<string> linie in result)
            {
                cerere.Add(new Cerere(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]), linie[3]));
            }
            return cerere;
        }
    }
}
