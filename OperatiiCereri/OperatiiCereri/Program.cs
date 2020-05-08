using System;
using SqliteHandle;
using System.Collections.Generic;

namespace OperatiiCereri
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseConnection.get_database_connection().execute_command("PRAGMA foreign_keys = ON;");
            Console.WriteLine("Hello World!");
            if (OperatiiCerere.inserareCerereNoua(1,1324,"I") == true)
            {
                //op succes
                Console.WriteLine("Succes!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
            if (OperatiiCerere.stergeCerere(1) == true)
            {
                //op succes
                Console.WriteLine("Succes!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
            List<Cerere> cereri = new List<Cerere>();
            cereri = OperatiiCerere.selecteazaCereri();
            foreach(Cerere cerere in cereri)
            {
                Console.WriteLine(cerere.ID.ToString() +" "+ cerere.ID_Carte + " " + cerere.ID_User + " " + cerere.Tip_cerere);
            }

        }
    }
}
