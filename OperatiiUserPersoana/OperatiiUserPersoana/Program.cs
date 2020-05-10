using System;


namespace OperatiiUserPersoana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine(OperatiiPersoana.inserarePersoanaNoua("ana","ciulei","blabla","sdasda","9847329","dsada"));
            // foreach (Persoana pers in  OperatiiPersoana.selecteazaPersoanaDupaID(3))
            // {
            //     Console.WriteLine(pers.Nume);
            // }
            // Console.WriteLine(OperatiiPersoana.stergePersoana(3));
            //Console.WriteLine(OperatiiUser.inserareUserNou(2,"dsasa","dsada"));
            //Console.WriteLine(OperatiiUser.stergeUser(2));
            User x;
             foreach (User user in OperatiiUser.selecteazaUseri())
             {
                 x = new User(user.ID, user.User_name, user.Parola);
                 Console.WriteLine(user.User_name);
                Console.WriteLine(OperatiiUser.user_exist(x));
            }
            //Console.WriteLine(OperatiiUser.user_exist(x));
        }
    }
}
