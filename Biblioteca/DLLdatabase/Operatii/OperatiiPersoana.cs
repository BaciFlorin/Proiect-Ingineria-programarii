/**************************************************************************
 *                                                                        *
 *  File:        OperatiiPersoana.cs                                      *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Descriere operatii care se afectueaza asupra tabelei     *
 *               Persoana din baza de date.                               *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using SqliteHandle;
using Entitati;
namespace Operatii
{
    public class OperatiiPersoana
    {
        private static DatabaseConnection _connection = DatabaseConnection.GetDbConnection();
        /// <summary>
        /// Inserarea unei persoane noi
        /// </summary>
        /// <typeparam name="persoana">persoana pe care doresti sa o introduci</typeparam>
        public bool InserarePersoanaNoua(Persoana persoana)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO Persoana( Nume,Prenume,Adresa,Email,Telefon,Poza_path)" +
                " VALUES('" + persoana.Nume + "','" + persoana.Prenume + "','" + persoana.Adresa + "','" +
                persoana.Email + "','" + persoana.Telefon + "','" + persoana.Poza_path + "');");
            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Stergerea unei persoane identificata de un id
        /// </summary>
        /// <typeparam name="id">Id-ul unic atribuit persoanei pe care vrei sa o stergi</typeparam>
        public bool StergePersoana(int ID)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM Persoana WHERE ID = " + ID.ToString());
            return _connection.ExecutaComenzi(commands);
        }
        /// <summary>
        /// Cautarea persoanei cu un anumit ID 
        /// </summary>
        /// <typeparam name="id">ID-ul persoanei cautate</typeparam>
        public List<Persoana> SelecteazaPersoanaDupaID(int id)
        {

            List<List<string>> result = _connection.ExecutaComandaSelect("SELECT * " +
                "FROM Persoana WHERE ID =  " + id.ToString() + ";", new string[] { "ID", "Nume", "Prenume", "Adresa", "Email", "Telefon", "Poza_path" });
            List<Persoana> persoana = new List<Persoana>(result.Count);
            foreach (List<string> linie in result)
            {
                persoana.Add(new Persoana(int.Parse(linie[0]), linie[1], linie[2], linie[3], linie[4], linie[5], linie[6]));
            }
            return persoana;
        }

        /// <summary>
        /// Cautarea tuturor persoanelor
        /// </summary>
        /// <returns></returns>
        public List<Persoana> SelecteazaToatePersoanele()
        {

            List<List<string>> result = _connection.ExecutaComandaSelect("SELECT * " +
                "FROM Persoana;", new string[] { "ID", "Nume", "Prenume", "Adresa", "Email", "Telefon", "Poza_path" });
            List<Persoana> persoane = new List<Persoana>(result.Count);
            foreach (List<string> linie in result)
            {
                persoane.Add(new Persoana(int.Parse(linie[0]), linie[1], linie[2], linie[3], linie[4], linie[5], linie[6]));
            }
            return persoane;

        }
    }
}
