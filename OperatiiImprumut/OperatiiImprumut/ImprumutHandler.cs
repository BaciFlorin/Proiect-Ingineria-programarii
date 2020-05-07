using Entities;
using System;
using System.Collections.Generic;


namespace SqlHandle
{
    class ImprumutHandler
    {
        private database_connection _dbConnection = database_connection.get_database_connection();

        public void insereaza(Imprumut imprumut)
        {
            bool result = false;
            string commandText = "INSERT INTO Imprumut (ID_Carte, ID_User, Data_imprumut,Data_restituire)" +
              " VALUES('" + imprumut.IdCarte + "', '" + imprumut.IdUser + "', '" + imprumut.DataImprumut.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + imprumut.DataRestituire.ToString("yyyy-MM-dd HH:mm:ss")  + "');";

            result = _dbConnection.execute_comm(commandText);

            if (result)
            {
                //log succes
            }
            else
            {
                //log eroare
            }


        }

        public void sterge(Imprumut imprumut)
        {
            bool result = false;
            string commandText = "DELETE FROM Imprumut WHERE ID_Imprumut=" + imprumut.IdImprumut + "";
            result = _dbConnection.execute_comm(commandText);
            if (result)
            {
                //log succes
            }
            else
            {
                //log eroare
            }
        }
        public List<Imprumut> selecteaza()
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
        public List<Imprumut> selecteazaDupaUtilizator(int userId)
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

        public List<Imprumut> selecteazaDupaAutor(string autor)
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
        public List<Imprumut> selecteazaDupaTitlu(string titlu)
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

        public List<Imprumut> selecteazaDupaCategorie(string categorie)
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
