using Entities;
using SqlHandle;
using System;
using System.Collections.Generic;

namespace ImprumutProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprumut imprumut = new Imprumut(1, 1, DateTime.Now, DateTime.Now.AddDays(21));
            ImprumutHandler imprumutHandler = new ImprumutHandler();
            //imprumutHandler.insereaza(imprumut);
            List<Imprumut> imprumuturi = imprumutHandler.selecteaza();
            //List<Imprumut> imprumuturi = imprumutHandler.selecteazaDupaAutor("Virgil Ciulei");
            //List<Imprumut> imprumuturi = imprumutHandler.selecteazaDupaUtilizator(1);
            //List<Imprumut> imprumuturi = imprumutHandler.selecteazaDupaTitlu("In padurea cu alune");
            //List<Imprumut> imprumuturi = imprumutHandler.selecteazaDupaCategorie("Copilasi");
            //imprumutHandler.sterge(imprumuturi[0]);
            foreach (Imprumut imprmt in imprumuturi)
            {
                Console.WriteLine(imprmt.ToString());
            }


        }
    }
}
