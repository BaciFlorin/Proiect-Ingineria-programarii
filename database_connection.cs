using System;
using System.Collections.Generic;
using System.Text;
    
using System.Data.SQLite;

namespace ConsoleApp1
{

    class database_connection
    {
        private static database_connection _instance =null;
        SQLiteConnection con = null;
        SQLiteCommand cmd = null;
        private database_connection()
        {
            string cs = @"URI=file:D:\ProiectIP\database.db";

            con = new SQLiteConnection(cs);
            con.Open();

            cmd = new SQLiteCommand(con);
        }

        static public database_connection get_database_connection()
        {
            if (_instance == null)
            {
                _instance = new database_connection();
            }
            return _instance;
        }
        public List<List<string>> execute_select_comand(string database_operation,string[] cols)
        {
            List<List<string>> ret_val = new List<List<string>>();
            cmd.CommandText = database_operation;
            SQLiteDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while(result.Read())
                {
                    List<string> aux = new List<string>();

                    for (int i = 0; i < cols.Length; i++)
                        aux.Add(result[cols[i]].ToString());

                    ret_val.Add(aux);
                }
            }
            return ret_val;
            
        }
        public bool execute_comm(string database_operation)
        {
            int result = 0 ;
            cmd.CommandText = database_operation;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                result = 0;
            }
            if (result == 1)
                return true;
            return false;
        }
        public void show_output(List<List<string>> output)
        {
            foreach(List<string> row in output)
            {
                foreach( string col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
