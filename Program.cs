using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> output;
            Console.WriteLine("Hello World!");

            //bool state = database_connection.get_database_connection().execute_comm("INSERT INTO Carte(Titlu, Autor,IBN,Categorie,Descriere) VALUES('a','b',1,'c','d')");
            //bool state = database_connection.get_database_connection().execute_comm("DELETE FROM  Carte WHERE ID=2");
            bool state = database_connection.get_database_connection().execute_comm("UPDATE Carte SET Categorie = 'HAPPY' WHERE ID=3");
            Console.WriteLine(state);
            output = database_connection.get_database_connection().execute_select_comand("SELECT * FROM Carte" ,new string[] { "Titlu", "Autor", "IBN", "Categorie", "Descriere" });
            database_connection.get_database_connection().show_output(output);
            //database_connection.get_database_connection().execute_comm("")
        }
    }
}
