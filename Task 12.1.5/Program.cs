using System;
using System.Collections.Generic;
using System.Threading;


namespace Task_12._1._5
{ 
    class Program
    {
        static void Main()
        {
            List<user> users = new List<user>()
        {   new user("jack__", "Jack", true),
            new user("gregor", "George", false),
            new user("nicol123", "Nicole", true),
            new user("_lena_85", "Jelena", false),
            new user("peter@gmail", "Peter", true),};

            foreach (user user in users)
            {
                Console.WriteLine($"Hello, {user.Name}!");

                if (!user.IsPremium)
                    ShowAds();
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
