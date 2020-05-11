/**************************************************************************
 *                                                                        *
 *  File:        Carte.cs                                                 *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Clasa care stocheaza informatiile despre o carte din     *
 *               baza de date.                                            *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public class Carte
    {
        /// <summary>
        /// Constructor clasa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titlu"></param>
        /// <param name="autor"></param>
        /// <param name="ibsn"></param>
        /// <param name="categorie"></param>
        /// <param name="descriere"></param>
        /// <param name="stoc"></param>

        public Carte(int id, string titlu, string autor, string ibsn, string categorie, string descriere, int stoc)
        {
            Id = id;
            Autor = autor;
            Titlu = titlu;
            Ibsn = ibsn;
            Categorie = categorie;
            Descriere = descriere;
            Stoc = stoc;
        }

        /// <summary>
        /// Id-ul unic atribuit fiecarei carti in baza de date
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titlul cartii
        /// </summary>
        public string Titlu { get; set; }

        /// <summary>
        /// Autorul cartii
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Gen-ul din care face parte cartea
        /// </summary>
        public string Categorie { get; set; }

        /// <summary>
        /// Descrierea sumara a cartii
        /// </summary>
        public string Descriere { get; set; }

        /// <summary>
        /// Cod internaţional de identificare a cărţilor
        /// </summary>
        public string Ibsn { get; set; }

        /// <summary>
        /// Stocul cartii
        /// </summary>
        public int Stoc { get; set; }

        /// <summary>
        /// Metoda folosita pentru reprezentarea in format text a cartii
        /// </summary>
        public override string ToString()
        {
            string carte = "";
            carte += "Titlu:" + this.Titlu + "\n";
            carte += "Autor:" + this.Autor + "\n";
            carte += "Categorie:" + this.Categorie + "\n";
            carte += "Descriere:" + this.Descriere + "\n";
            carte += "IBSN:" + this.Ibsn + "\n";
            carte += "Stoc:" + this.Stoc + "\n";

            return carte;
        }
    }
}
