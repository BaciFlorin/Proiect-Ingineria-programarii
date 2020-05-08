using SqliteHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatiiCereri
{
    class OperatiiCerere
    {
        private static DatabaseConnection _connection = DatabaseConnection.get_database_connection();
        public static bool inserareCerereNoua(int id_carte, int id_user, string tip_cerere)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO Cerere(ID_Carte, ID_User,Tip_cerere)" +
                " VALUES(" + id_carte.ToString() + "," + id_user.ToString() + ",'" + tip_cerere + "');");
            return _connection.execute_transaction(commands);
        }
        public static bool stergeCerere(int ID)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM Cerere WHERE ID = " + ID.ToString());
            return _connection.execute_transaction(commands);
        }
        public static List<Cerere> selecteazaCereri()
        {

            List<List<string>> result = _connection.execute_select_comand("SELECT * " +
                "FROM Cerere ", new string[] { "ID", "ID_Carte", "ID_User", "Tip_cerere"});
            List<Cerere> carti = new List<Cerere>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new Cerere(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]), linie[3]));
            }
            return carti;
        }
    }
}
