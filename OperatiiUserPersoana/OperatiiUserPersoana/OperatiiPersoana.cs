using System;
using System.Collections.Generic;
using System.Text;
using SqliteHandle;
namespace OperatiiUserPersoana
{
    class OperatiiPersoana
    {
        private static DatabaseConnection _connection = DatabaseConnection.get_database_connection();
        public static bool inserarePersoanaNoua(string nume, string prenume, string adresa, string email,string telefon , string poza_path)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO Persoana( Nume,Prenume,Adresa,Email,Telefon,Poza_path)" +
                " VALUES('" + nume + "','" + prenume + "','" + adresa + "','" + email + "','"+ telefon+ "','" + poza_path +"');");
            return _connection.execute_transaction(commands);
        }
        public static bool stergePersoana(int ID)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM Persoana WHERE ID = " + ID.ToString());
            return _connection.execute_transaction(commands);
        }
        public static List<Persoana> selecteazaPersoanaDupaID(int id)
        {

            List<List<string>> result = _connection.execute_select_comand("SELECT * " +
                "FROM Persoana WHERE ID =  " + id.ToString() + ";", new string[] { "ID", "Nume", "Prenume", "Adresa" , "Email", "Telefon", "Poza_path" });
            List<Persoana> carti = new List<Persoana>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Persoana(int.Parse(linie[0]),linie[1], linie[2], linie[3], linie[4], linie[5], linie[6]));
            }
            return carti;
        }
    }
}
