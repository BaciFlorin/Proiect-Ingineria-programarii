using System;
using System.Collections.Generic;
using System.Text;
using SqliteHandle;
namespace OperatiiUserPersoana
{
    class OperatiiUser
    {
        private static DatabaseConnection _connection = DatabaseConnection.get_database_connection();
        public static bool inserareUserNou(int ID_User, string user_name, string parola)
        {
            List<string> commands = new List<string>();
            commands.Add("INSERT INTO User(ID_User, Username,Parola)" +
                " VALUES(" + ID_User.ToString() + ",'" + user_name + "','" + parola + "');");
            return _connection.execute_transaction(commands);
        }
        public static bool stergeUser(int ID_User)
        {
            List<string> commands = new List<string>();
            commands.Add("DELETE FROM User WHERE ID_User = " + ID_User.ToString());
            return _connection.execute_transaction(commands);
        }
        public static List<User> selecteazaUseri()
        {

            List<List<string>> result = _connection.execute_select_comand("SELECT * " +
                "FROM User ;", new string[] { "ID_User", "Username", "Parola" });
            List<User> carti = new List<User>(result.Count);
            foreach (List<string> linie in result)
            {
                carti.Add(new User(int.Parse(linie[0]), linie[1], linie[2]));
            }
            return carti;
        }
        public static bool user_exist(User user)
        {

            List<List<string>> result = _connection.execute_select_comand("SELECT * " +
                "FROM User WHERE ID_User ="+user.ID.ToString()+ " AND Username ='" +user.User_name+ "';", new string[] { "ID_User", "Username", "Parola" });
            if (result.Count != 0 )
                return true;
            return false;
        }
    }
}
