using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteHandle
{
    class OperatiiBazaDeDateCarte
    {
        private static DatabaseConnection _connection = DatabaseConnection.get_database_connection();

        public static bool inserareCarteNoua(string autor, string titlu, string ibbn, string categorie, string descriere, int stoc)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO Carte(Titlu, Autor,IBBN,Categorie,Descriere)" +
                " VALUES('"+titlu+"','" + autor + "'," + ibbn + ",'" + categorie + "','" + descriere + "')");
            commands.Add("INSERT INTO Stoc VALUES(" +
                "(SELECT ID FROM Carte WHERE IBBN='" + ibbn + "')," + stoc.ToString() + ")");
            return _connection.execute_transaction(commands);
        }

        public static bool stergeCarte(int ID)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM Stoc WHERE ID_Carte = " + ID.ToString());
            commands.Add("DELETE FROM Carte WHERE ID=" + ID.ToString());
            return _connection.execute_transaction(commands);
        }

        public static bool actualizareStoc(int ID, int numar)
        {
            return _connection.execute_command("UPDATE Stoc SET Numar=Numar+" + numar.ToString() +
                " WHERE ID_carte=" + ID.ToString());
        }

        public static List<Carte> selecteazaCartiDupaAutor(string autor)
        {
            
            List<List<string>> result = _connection.execute_select_comand("SELECT ID, Titlu, IBBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Autor =='" + autor + "' AND " +
                "Carte.ID == Stoc.ID_Carte", new string[] { "ID", "Titlu", "IBBN", "Categorie", "Descriere", "Numar"});
            List<Carte> carti = new List<Carte>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], autor, linie[2], linie[3], linie[4],int.Parse(linie[5])));
            }
            return carti;
        }

        public static List<Carte> selecteazaCartiDupaTitlu(string titlu)
        {
            List<List<string>> result = _connection.execute_select_comand("SELECT ID, Autor, IBBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Titlu =='" + titlu + "' AND " +
                "Carte.ID == Stoc.ID_Carte", new string[] { "ID", "Autor", "IBBN", "Categorie", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Carte(int.Parse(linie[0]), titlu, linie[1], linie[2], linie[3], linie[4], int.Parse(linie[5])));
            }
            return carti;
        }

        public static List<Carte> selecteazaCartiDupaCategorie(string categorie)
        {

            List<List<string>> result = _connection.execute_select_comand("SELECT ID, Titlu, Autor, IBBN, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Categorie =='" + categorie + "' AND " +
                "Carte.ID == Stoc.ID_Carte", new string[] { "ID", "Titlu","Autor", "IBBN", "Descriere", "Numar" });
            List<Carte> carti = new List<Carte>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], linie[2], linie[3], categorie, linie[4], int.Parse(linie[5])));
            }
            return carti;
        }

        public static List<Carte> selecteazaToateCartile()
        {
            List<List<string>> result = _connection.execute_select_comand("SELECT ID, Titlu, Autor, IBBN, Categorie, Descriere, Numar " +
                "FROM Carte, Stoc WHERE Carte.ID == Stoc.ID_Carte", new string[] { "ID", "Titlu","Autor", "IBBN", "Categorie", "Descriere","Numar"});
            if (result.Count == 0)
            {
                return null;
            }
            List<Carte> carti = new List<Carte>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Carte(int.Parse(linie[0]), linie[1], linie[2], linie[3], linie[4],linie[5],int.Parse(linie[6])));
            }
            return carti;
        }
    }
}
