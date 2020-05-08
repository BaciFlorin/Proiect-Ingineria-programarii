using System;
using System.Collections.Generic;
using System.Text;
    
using System.Data.SQLite;

namespace SqliteHandle
{

    class DatabaseConnection
    {
        private static DatabaseConnection _instance =null;
        SQLiteConnection con = null;
        SQLiteCommand cmd = null;
        private DatabaseConnection()
        {
            string cs = @"URI=file:F:\database.db";

            con = new SQLiteConnection(cs);
            con.Open();

            cmd = new SQLiteCommand(con);
            cmd.Connection = con;
        }

        static public DatabaseConnection get_database_connection()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
				_instance.execute_command("PRAGMA foreign_keys = ON;");
            }
            return _instance;
        }


        public List<List<string>> execute_select_comand(string database_operation, string[] cols)
        {
            List<List<string>> ret_val = new List<List<string>>();
            cmd.CommandText = database_operation;
            using (SQLiteDataReader result = cmd.ExecuteReader())
            {
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        List<string> aux = new List<string>();

                        for (int i = 0; i < cols.Length; i++)
                            aux.Add(result[cols[i]].ToString());

                        ret_val.Add(aux);
                    }
                }
            }
            return ret_val;
        }

        public bool execute_command(string database_operation)
        {
            bool status = true;
            cmd.CommandText = database_operation;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                status = false;
            }
            return status;
        }

        public bool execute_transaction(List<string> commands)
        {
            SQLiteTransaction myTrans;

            // Start a local transaction
            myTrans = con.BeginTransaction();
            // Assign transaction object for a pending local transaction
            cmd.Transaction = myTrans;
            try
            {
                foreach(string command in commands)
                {
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                }
                myTrans.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                myTrans.Rollback();
                return false;
            }
            return true;
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
