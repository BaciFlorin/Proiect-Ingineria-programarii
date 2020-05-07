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
            imprumutHandler.Insereaza(imprumut);
            List<Imprumut> imprumuturi = imprumutHandler.Selecteaza();
            //List<Imprumut> imprumuturi = imprumutHandler.SelecteazaDupaAutor("Virgil Ciulei");
            //List<Imprumut> imprumuturi = imprumutHandler.SelecteazaDupaUtilizator(1);
            //List<Imprumut> imprumuturi = imprumutHandler.SelecteazaDupaTitlu("In padurea cu alune");
            //List<Imprumut> imprumuturi = imprumutHandler.SelecteazaDupaCategorie("Copilasi");
            //imprumutHandler.Sterge(imprumuturi[0]);
            foreach (Imprumut imprmt in imprumuturi)
            {
                Console.WriteLine(imprmt.ToString());
            }


        }
    }
}
