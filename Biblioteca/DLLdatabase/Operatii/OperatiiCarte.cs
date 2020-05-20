/**************************************************************************
 *                                                                        *
 *  File:        OperatiiCarte.cs                                         *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Descriere operatii care se afectueaza asupra tabelei     *
 *               Carte din baza de date.                                  *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitati;
using SqliteHandle;

namespace Operatii
{
    public class OperatiiCarte
    {
        private DatabaseConnection _conexiune = DatabaseConnection.GetDbConnection();
        /// <summary>
        /// Inserarea unei carti noi
        /// </summary>
        /// <typeparam name="carte">Cartea pe care doresti sa o introduci</typeparam>
        public bool InserareCarteNoua(Carte carte)
        {
            List<string> comenzi = new List<string>();
            comenzi.Add("INSERT INTO Carte(Titlu, Autor,ISBN,Categorie,Descriere)" +
                " VALUES('" + carte.Titlu + "','" + carte.Autor + "'," + carte.Isbn + ",'" + carte.Categorie + "','" + carte.Descriere + "');");
            comenzi.Add("INSERT INTO Stoc VALUES(" +
                "(SELECT ID FROM Carte WHERE ISBN=" + carte.Isbn + ")," + carte.Stoc.ToString() + ");");
            return _conexiune.ExecutaComenzi(comenzi);
        }

        /// <summary>
        /// Stergerea unei carti identificata de un id
        /// </summary>
        /// <typeparam name="id">Id-ul unic atribuit cartii pe care vrei sa o stergi</typeparam>
        public bool StergeCarte(int id)
        {
            List<string> comenzi = new List<string>();
            comenzi.Add("DELETE FROM Stoc WHERE ID_Carte = " + id.ToString() + ";");
            comenzi.Add("DELETE FROM Carte WHERE ID=" + id.ToString() + ";");
            return _conexiune.ExecutaComenzi(comenzi);
        }

        /// <summary>
        /// Actualizarea stocului unei carti
        /// </summary>
        /// <typeparam name="id">Id-ul unic al cartii caruia vrei sa ii actualizezi stocul</typeparam>
        /// <typeparam name="numar">Numarul de carti pe care vrei sa il introduci sau sa il retragi
        /// Introdu un numar negativ pentru retragere</typeparam>
        public bool ActualizareStoc(int id, int numar)
        {
            string numarSir = "";
            if (numar < 0)
                numarSir = "-" + (-numar).ToString();
            else
                numarSir = "+" + numar.ToString();
            return _conexiune.ExecutaComanda("UPDATE Stoc SET Numar=Numar" + numarSir +
                " WHERE ID_carte=" + id.ToString() + ";");
        }

        /// <summary>
        /// Cautarea cartilor scrise de un anumit autor
        /// </summary>
        /// <typeparam name="autor">Autorul care a scris cartile cautate</typeparam>
        public List<Carte> SelecteazaCartiDupaAutor(string autor)
        {
            List<List<string>> rezultat = _conexiune.ExecutaComandaSelect("SELECT ID, Titlu, ISBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Autor =='" + autor + "' AND " +
                "Carte.ID == Stoc.ID_Carte;", new string[] { "ID", "Titlu", "ISBN", "Categorie", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(rezultat.Count);
            foreach (List<string> linie in rezultat)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], autor, linie[2], linie[3], linie[4], int.Parse(linie[5])));
            }
            return carti;
        }

        /// <summary>
        /// Cautarea cartilor care au un anumit titlu
        /// </summary>
        /// <typeparam name="titlu">Titlul cartilor pe care le cauti</typeparam>
        public List<Carte> SelecteazaCartiDupaTitlu(string titlu)
        {
            List<List<string>> rezultat = _conexiune.ExecutaComandaSelect("SELECT ID, Autor, ISBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Titlu =='" + titlu + "' AND " +
                "Carte.ID == Stoc.ID_Carte;", new string[] { "ID", "Autor", "ISBN", "Categorie", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(rezultat.Count);
            foreach (List<string> linie in rezultat)
            {
                carti.Add(new Carte(int.Parse(linie[0]), titlu, linie[1], linie[2], linie[3], linie[4], int.Parse(linie[5])));
            }
            return carti;
        }
        /// <summary>
        /// Cautarea cartilor care fac parte dintr-o anumita categorie
        /// </summary>
        /// <typeparam name="categorie">Categoria cartilor pe care le cauti</typeparam>
        public List<Carte> SelecteazaCartiDupaCategorie(string categorie)
        {
            List<List<string>> rezultat = _conexiune.ExecutaComandaSelect("SELECT ID, Titlu, Autor, ISBN, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Categorie =='" + categorie + "' AND " +
                "Carte.ID == Stoc.ID_Carte;", new string[] { "ID", "Titlu", "Autor", "ISBN", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(rezultat.Count);
            foreach (List<string> linie in rezultat)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], linie[2], linie[3], categorie, linie[4], int.Parse(linie[5])));
            }
            return carti;
        }

        /// <summary>
        /// Selectarea tuturor cartilor din baza de date
        /// </summary>
        public List<Carte> SelecteazaToateCartile()
        {
            List<List<string>> rezultat = _conexiune.ExecutaComandaSelect("SELECT ID, Titlu, Autor, ISBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Carte.ID == Stoc.ID_Carte;", new string[] { "ID", "Titlu", "Autor", "ISBN", "Categorie", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(rezultat.Count);
            foreach (List<string> linie in rezultat)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], linie[2], linie[3], linie[4], linie[5], int.Parse(linie[6])));
            }
            return carti;
        }
    }
}