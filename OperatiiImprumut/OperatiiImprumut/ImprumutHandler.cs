/**************************************************************************
 *                                                                        *
 *  File:        ImprumutHandler.cs                                       *
 *  Copyright:   (c) 2020, Atomei Georgiana                               *
 *  Description: Contine implememtarea pentru toate operatiile necesare   *
 *  pentru manipularea unui obiect de tip Imprumut.                       *
 *                                                                        *
 **************************************************************************/

using Entitati;
using System;
using System.Collections.Generic;
using SqliteHandle;

namespace Modele
{
    /// <summary>
    /// Clasa prin care se realizeaza operatii asupra tabelei Imprumut
    /// </summary>
    public class ImprumutHandler
    {
        private database_connection _dbConnection = database_connection.get_database_connection();

        
        /// <summary>
        /// Insereaza un nou imprumut in baza de date
        /// </summary>
        /// <param name="imprumut"></param>
        public void Insereaza(Imprumut imprumut)
        {
            bool result = false;
            string commandText = "INSERT INTO Imprumut (ID_Carte, ID_User, Data_imprumut,Data_restituire)" +
              " VALUES('" + imprumut.IdCarte + "', '" + imprumut.IdUser + "', '" + imprumut.DataImprumut.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + imprumut.DataRestituire.ToString("yyyy-MM-dd HH:mm:ss")  + "');";

            result = _dbConnection.execute_comm(commandText);
            
        }
       
        /// <summary>
        /// Se sterge un imprumut din baza de date
        /// Imprumutul e identificat in mod unic de id
        /// </summary>
        /// <param name="idImprumut"></param>
        public void Sterge(int idImprumut)
        {
            bool result = false;
            string commandText = "DELETE FROM Imprumut WHERE ID_Imprumut=" + idImprumut + "";
            result = _dbConnection.execute_comm(commandText);
        }

        /// <summary>
        /// Metoda realizeaza cautarea tuturor imprumuturile existente
        /// </summary>
        /// <returns>O lista de obiecte tip Imprumut</returns>
        public List<Imprumut> Selecteaza()
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            string commandText = "SELECT * FROM Imprumut";
            List<List<String>> imprumuturiDB = _dbConnection.execute_select_comand(commandText,
                new string[] { "ID_Imprumut", "ID_Carte", "ID_User", "Data_imprumut", "Data_restituire" });


            foreach (List<String> imprumutDB in imprumuturiDB)
            {
                int idImprumut = Int32.Parse(imprumutDB[0]);
                int idCarte = Int32.Parse(imprumutDB[1]);
                int idUser = Int32.Parse(imprumutDB[2]);
                DateTime dataImprumut = DateTime.Parse(imprumutDB[3]);
                DateTime dataRestituire = DateTime.Parse(imprumutDB[4]);
                imprumuturi.Add(new Imprumut(idImprumut, idCarte, idUser, dataImprumut, dataRestituire));
            }

            return imprumuturi;
        }

        /// <summary>
        /// Metoda realizeaza cautarea tuturor imprumuturilor ale unui utilizator dat
        /// Utilizatorul e identificat prin id
        /// </summary>
        /// <param name="userId">Id-ul utilizatorului dupa care se filtreaza</param>
        /// <returns>O lista de obiecte tip Imprumut</returns>
        public List<Imprumut> SelecteazaDupaUtilizator(int userId)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            string commandText = "SELECT * FROM Imprumut WHERE ID_User=" + userId + "";

            List<List<String>> imprumuturiDB = _dbConnection.execute_select_comand(commandText,
               new string[] { "ID_Imprumut", "ID_Carte", "ID_User", "Data_imprumut", "Data_restituire" });


            foreach (List<String> imprumutDB in imprumuturiDB)
            {
                int idImprumut = Int32.Parse(imprumutDB[0]);
                int idCarte = Int32.Parse(imprumutDB[1]);
                int idUser = Int32.Parse(imprumutDB[2]);
                DateTime dataImprumut = DateTime.Parse(imprumutDB[3]);
                DateTime dataRestituire = DateTime.Parse(imprumutDB[4]);
                imprumuturi.Add(new Imprumut(idImprumut, idCarte, idUser, dataImprumut, dataRestituire));
            }

            return imprumuturi;
        }

        /// <summary>
        /// Metoda realizeaza cautarea tuturor imprumuturilor de la un autor dat
        /// </summary>
        /// <param name="autor">Numele autorului dupa care se filtreaza</param>
        /// <returns>O lista de obiecte tip Imprumut</returns>
        public List<Imprumut> SelecteazaDupaAutor(string autor)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            string commandText = "SELECT * FROM Imprumut WHERE ID_Carte in " +
                "(SELECT c.ID FROM Carte c WHERE c.Autor='" + autor + "');";

            List<List<String>> imprumuturiDB = _dbConnection.execute_select_comand(commandText,
               new string[] { "ID_Imprumut", "ID_Carte", "ID_User", "Data_imprumut", "Data_restituire" });


            foreach (List<String> imprumutDB in imprumuturiDB)
            {
                int idImprumut = int.Parse(imprumutDB[0]);
                int idCarte = int.Parse(imprumutDB[1]);
                int idUser = int.Parse(imprumutDB[2]);
                DateTime dataImprumut = DateTime.Parse(imprumutDB[3]);
                DateTime dataRestituire = DateTime.Parse(imprumutDB[4]);
                imprumuturi.Add(new Imprumut(idImprumut, idCarte, idUser, dataImprumut, dataRestituire));
            }

            return imprumuturi;
        }


        /// <summary>
        /// Metoda realizeaza cautarea tuturor imprumuturilor pentru carti cu un anumit titlu
        /// </summary>
        /// <param name="titlu">Titlul cartii dupa care se filtreaza</param>
        /// <returns>O lista de obiecte tip Imprumut</returns>
        public List<Imprumut> SelecteazaDupaTitlu(string titlu)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            string commandText = "SELECT * FROM Imprumut WHERE ID_Carte in " +
                "(SELECT c.ID FROM Carte c WHERE c.Titlu='" + titlu + "');";

            List<List<String>> imprumuturiDB = _dbConnection.execute_select_comand(commandText,
               new string[] { "ID_Imprumut", "ID_Carte", "ID_User", "Data_imprumut", "Data_restituire" });


            foreach (List<String> imprumutDB in imprumuturiDB)
            {
                int idImprumut = int.Parse(imprumutDB[0]);
                int idCarte = int.Parse(imprumutDB[1]);
                int idUser = int.Parse(imprumutDB[2]);
                DateTime dataImprumut = DateTime.Parse(imprumutDB[3]);
                DateTime dataRestituire = DateTime.Parse(imprumutDB[4]);
                imprumuturi.Add(new Imprumut(idImprumut, idCarte, idUser, dataImprumut, dataRestituire));
            }

            return imprumuturi;
        }

        /// <summary>
        /// Metoda realizeaza cautarea tuturor imprumuturilor pentru carti dintr-o categorie anume
        /// </summary>
        /// <param name="categorie">Numele categoriei dupa care se filtreaza</param>
        /// <returns>O lista de obiecte tip Imprumut</returns>
        public List<Imprumut> SelecteazaDupaCategorie(string categorie)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            string commandText = "SELECT * FROM Imprumut WHERE ID_Carte in " +
                "(SELECT c.ID FROM Carte c WHERE c.Categorie='" + categorie + "');";

            List<List<String>> imprumuturiDB = _dbConnection.execute_select_comand(commandText,
               new string[] { "ID_Imprumut", "ID_Carte", "ID_User", "Data_imprumut", "Data_restituire" });


            foreach (List<String> imprumutDB in imprumuturiDB)
            {
                int idImprumut = int.Parse(imprumutDB[0]);
                int idCarte = int.Parse(imprumutDB[1]);
                int idUser = int.Parse(imprumutDB[2]);
                DateTime dataImprumut = DateTime.Parse(imprumutDB[3]);
                DateTime dataRestituire = DateTime.Parse(imprumutDB[4]);
                imprumuturi.Add(new Imprumut(idImprumut, idCarte, idUser, dataImprumut, dataRestituire));
            }

            return imprumuturi;
        }
    }
}
