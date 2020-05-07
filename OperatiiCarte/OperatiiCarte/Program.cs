using System;
using System.Collections.Generic;

namespace SqliteHandle
{
    class Program
    {
        static void show_output(List<Carte> carti)
        {
            foreach(Carte carte in carti)
            {
                Console.WriteLine(carte.ID.ToString() + " Titlu:" + carte.Titlu + " Autor:" + carte.Autor + " IBBN:" + carte.IBBN +
                    " Categorie:" + carte.Categorie + " Descriere:" + carte.Descriere + " Stoc:" + carte.Stoc);
            }
        }
        static void Main(string[] args)
        {
            List<Carte> output;
            OperatiiBazaDeDateCarte.stergeCarte(4);
            output = OperatiiBazaDeDateCarte.selecteazaCartiDupaAutor("a");
            show_output(output);
            Console.Read();
        }
    }
}
